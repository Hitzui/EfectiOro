Imports EfectiOro.Database

Public Class frmCierrePrecios
    Private Const Title As String = "Cerrar precio"
    Private aux As Integer
    Private _datosCierreCliente As Integer
    Private _cierreSeleccionado As Integer
    Sub enableGrupos(opcion As Boolean)
        grpCliente.Enabled = opcion
        grpDatos.Enabled = opcion
        grpLista.Enabled = opcion
    End Sub
    Private Function recuperarCierre(codigo As Integer) As CierrePrecios
        Using ctx As New Contexto
            Try
                Dim buscar = (From cp In ctx.CierrePrecios Where cp.CodCierre = codigo Select cp).Single
                Return buscar
            Catch ex As Exception
                Return New CierrePrecios
            End Try
        End Using
    End Function
    Sub enableButtons(nuevo As Boolean, guardar As Boolean, editar As Boolean, eliminiar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnEditar.Enabled = editar
        btnEliminar.Enabled = eliminiar
        btnCancelar.Enabled = cancelar
    End Sub
    Sub clear()
        For Each Control In Me.Controls
            If TypeOf Control Is GroupBox Then
                Dim box As GroupBox = DirectCast(Control, GroupBox)
                For Each ctrl In box.Controls
                    If TypeOf ctrl Is TextBox Then
                        Dim text As TextBox = DirectCast(ctrl, TextBox)
                        text.Clear()
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub cargarCierrePreciosCliente()
        Using ctx As New Contexto
            Try
                dgvCierresCliente.Rows.Clear()
                Dim datos = (From cp In ctx.CierrePrecios
                             Where cp.Codcliente = txtCodigo.Text And cp.SaldoOnzas > 0 And cp.Status = True
                             Select cp).ToList
                _datosCierreCliente = datos.Count
                btnCerrarPrecio.Enabled = True
                For Each valor As CierrePrecios In datos
                    dgvCierresCliente.Rows.Add(valor.CodCierre, valor.PrecioOro, valor.OnzasFinas, valor.SaldoOnzas, valor.Fecha, valor.PrecioBase)
                Next
            Catch ex As Exception
                MsgBox("NO se pudo recuperar los valore de cierre de precios del cliente: " & ex.Message, MsgBoxStyle.Critical, "Error grid cierre precios")
            End Try
        End Using
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result = MsgBox("¿Salir del formulario cierre de precios, cualquier dato no se guardará?", MsgBoxStyle.YesNo, "Salir")
        If result = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtNombre_Enter(sender As Object, e As EventArgs) Handles txtNombre.Enter
        If dgvCliente.Visible = False Then
            dgvCliente.Visible = True
            dgvCliente.Size = New Size(435, 100)
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Using ctx As New Contexto
            Try
                If dgvCliente.Visible = False Then
                    dgvCliente.Visible = True
                End If
                Dim buscar = (From cli In ctx.Cliente Where cli.Nombres.Contains(txtNombre.Text) OrElse cli.Apellidos.Contains(txtNombre.Text)
                              Select cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Numcedula).ToList
                dgvCliente.DataSource = buscar
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                dgvCliente.Focus()
        End Select
    End Sub

    Private Sub dgvCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCliente.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter
                    Dim row As DataGridViewRow = dgvCliente.CurrentRow
                    Me.txtCodigo.Text = row.Cells(0).Value
                    Me.txtNombre.Text = row.Cells(1).Value & " " & row.Cells(2).Value
                    Me.dgvCliente.Visible = False
                    txtOnzas.Focus()
                    cargarCierrePreciosCliente()
                    If aux = 1 Then
                        dgvCierresCliente.Enabled = False
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtOnzas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnzas.KeyPress
        NumeroDec(e, txtOnzas)
    End Sub

    Private Sub txtPrecioOro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioOro.KeyPress
        NumeroDec(e, txtPrecioOro)
    End Sub

    Private Sub txtMargen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMargen.KeyPress
        NumeroDec(e, txtMargen)
    End Sub

    Private Sub txtOnzas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOnzas.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtPrecioOro.Focus()
        End Select
    End Sub
    Private Sub txtPrecioOro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioOro.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtMargen.Focus()
        End Select
    End Sub
    Private Sub txtOnzas_TextChanged(sender As Object, e As EventArgs) Handles txtOnzas.TextChanged
        Try
            Dim onzas As Decimal = Decimal.Zero
            If txtOnzas.Text.Trim.Length <= 0 Then
                erp.SetError(txtOnzas, "Establezca un valor para continuar")
                txtOnzas.Focus()
                Return
            Else
                erp.SetError(txtOnzas, "")
                onzas = Convert.ToDecimal(txtOnzas.Text)
                txtGramos.Text = Convert.ToString(onzas * 31.1035)
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error al convertir las onzas a gramos." & vbCr & ex.Message, MsgBoxStyle.Critical, "Error onzas")
        End Try
    End Sub
    Private Function tipoCambio() As Decimal
        Try
            Using ctx As New Contexto
                Dim valor = (From tc In ctx.TipoCambio Where tc.Fecha = Now Select tc).Single
                Return valor.Tipocambio1
            End Using
        Catch ex As Exception
            Return Decimal.Zero
        End Try
    End Function
    Sub calcularPrecioBase()
        Try
            Dim precioOro As Decimal = Decimal.Zero
            Dim margen As Decimal = Decimal.Zero
            Dim daoTc = DataContext.daoTipoCambio
            If txtPrecioOro.Text.Trim.Length <= 0 Then
                erp.SetError(txtPrecioOro, "Establezca un valor para continuar")
                txtPrecioOro.Focus()
                Return
            Else
                precioOro = Convert.ToDecimal(txtPrecioOro.Text)
            End If
            If txtMargen.Text.Trim.Length <= 0 Then
                erp.SetError(txtMargen, "Establezca un valor para continuar")
                txtMargen.Focus()
                Return
            Else
                margen = Convert.ToDecimal(txtMargen.Text)
            End If
            Dim precioBase As Decimal = Decimal.Zero
            precioBase = (1 - (margen / 100)) * (1 - 0.002) * 0.994 * (precioOro - 0.5) * tipoCambio() / 31.1035 / 24
            txtPrecioBase.Text = Convert.ToString(Decimal.Round(precioBase, 2))
        Catch ex As Exception
            MsgBox("Error al calcular el precio base: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub txtPrecioOro_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioOro.TextChanged
        If txtPrecioOro.Text.Trim.Length > 0 Then
            erp.SetError(txtPrecioOro, "")
        End If
    End Sub

    Private Sub txtMargen_TextChanged(sender As Object, e As EventArgs) Handles txtMargen.TextChanged
        If txtMargen.Text.Trim.Length > 0 Then
            erp.SetError(txtMargen, "")
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        calcularPrecioBase()
        btnGuardar.Focus()
    End Sub

    Private Sub frmCierrePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Cierre de precios"
        clear()
        enableGrupos(False)
        enableButtons(True, False, True, True, False)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me._datosCierreCliente = 0
        Me._cierreSeleccionado = 0
        clear()
        enableGrupos(False)
        enableButtons(True, False, True, True, False)
        If dgvCliente.Visible = True Then
            dgvCliente.Visible = False
        End If
        btnCerrarPrecio.Enabled = False
        erp.Clear()
        dgvCierresCliente.Rows.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        aux = 1
        clear()
        enableGrupos(True)
        enableButtons(False, True, False, False, True)
        txtNombre.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        aux = 2
        clear()
        enableGrupos(True)
        enableButtons(False, True, False, False, True)
        txtNombre.Focus()
        dgvCierresCliente.Enabled = True
        If _datosCierreCliente > 0 Then
            btnCerrarPrecio.Enabled = True
            Me.dgvCierresCliente.Rows(0).Selected = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        aux = 3
        enableButtons(False, True, False, False, True)
        txtNombre.Focus()
        dgvCierresCliente.Enabled = True
        If _datosCierreCliente > 0 Then
            Me.dgvCierresCliente.Rows(0).Selected = True
        End If
        enableGrupos(True)
        grpDatos.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Using ctx As New Contexto
            Try
                Dim onzas As Decimal = Decimal.Zero
                Dim gramos As Decimal = Decimal.Zero
                Dim precioOro As Decimal = Decimal.Zero
                Dim precioBase As Decimal = Decimal.Zero
                Dim margen As Decimal = Decimal.Zero
                If txtCodigo.Text.Trim.Length <= 0 Then
                    MsgBox("Debe especificar un cliente para continuar", MsgBoxStyle.Critical, "Error")
                    txtNombre.Focus()
                    Return
                End If
                Dim codigo As String = txtCodigo.Text
                If txtOnzas.Text.Trim.Length <= 0 Then
                    erp.SetError(txtOnzas, "Debe especificar un valor")
                    txtOnzas.Focus()
                    Return
                Else
                    onzas = Convert.ToDecimal(txtOnzas.Text)
                End If
                If txtGramos.Text.Trim.Length <= 0 Then
                    erp.SetError(txtOnzas, "Debe especificar un valor")
                    txtOnzas.Focus()
                    Return
                Else
                    gramos = Convert.ToDecimal(txtGramos.Text)
                End If
                If txtPrecioOro.Text.Trim.Length <= 0 Then
                    erp.SetError(txtPrecioOro, "Debe especificar un valor")
                    txtPrecioOro.Focus()
                    Return
                Else
                    precioOro = Convert.ToDecimal(txtPrecioOro.Text)
                End If
                If txtMargen.Text.Trim.Length <= 0 Then
                    erp.SetError(txtMargen, "Debe especificar un valor")
                    txtMargen.Focus()
                    Return
                Else
                    margen = Convert.ToDecimal(txtMargen.Text)
                End If
                If txtPrecioBase.Text.Trim.Length <= 0 Then
                    MsgBox("NO se ha calculado el precio base, intente nuevamente", MsgBoxStyle.Information, "Guardar")
                    txtPrecioOro.Focus()
                    Return
                Else
                    precioBase = Convert.ToDecimal(txtPrecioBase.Text)
                End If
                Select Case aux
                    Case 1
                        'guardar nuevo registro
                        Dim cierre_precio As New CierrePrecios
                        cierre_precio.Codcliente = codigo
                        cierre_precio.Fecha = Now
                        cierre_precio.GramosFinos = gramos
                        cierre_precio.OnzasFinas = onzas
                        cierre_precio.PrecioBase = precioBase
                        cierre_precio.PrecioOro = precioOro
                        cierre_precio.Status = True
                        cierre_precio.SaldoOnzas = onzas
                        cierre_precio.Margen = margen
                        Dim result As DialogResult = MsgBox("¿Guardar registro de cierre de precio?", MsgBoxStyle.YesNo, "Guardar")
                        If result = Windows.Forms.DialogResult.Yes Then
                            ctx.CierrePrecios.InsertOnSubmit(cierre_precio)
                            ctx.SubmitChanges()
                            MsgBox("Registros guardados de form correcta", MsgBoxStyle.Information, "Guardar")
                            btnCancelar_Click(sender, e)
                        End If
                    Case 2
                        'editar registros
                        Dim usuario As String = DataContext.usuarioLog.Codoperador
                        If String.Equals(usuario, "ADMIN") = False Then
                            MsgBox("NO cuenta con los privilegios para editar datos.", MsgBoxStyle.Information, "Error")
                            Return
                        End If
                        If Me._cierreSeleccionado = 0 Then
                            MsgBox("NO ha seleccionado ningun valor para editar", MsgBoxStyle.Information, "Error")
                            Return
                        End If
                        Dim buscar As CierrePrecios = (From cp In ctx.CierrePrecios Where cp.CodCierre = Me._cierreSeleccionado Select cp).Single
                        If buscar.OnzasFinas <> buscar.SaldoOnzas Then
                            MsgBox("NO se puede editar este cierre de precio, ya que se han aplicado compras a dicho cierre", MsgBoxStyle.Information, "Guardar")
                            Return
                        End If
                        Dim result As DialogResult = MsgBox("¿Guardar registro de cierre de precio?", MsgBoxStyle.YesNo, "Guardar")
                        If result = Windows.Forms.DialogResult.Yes Then
                            buscar.GramosFinos = gramos
                            buscar.OnzasFinas = onzas
                            buscar.PrecioBase = precioBase
                            buscar.PrecioOro = precioOro
                            buscar.SaldoOnzas = onzas
                            buscar.Margen = margen
                            ctx.SubmitChanges()
                            MsgBox("Registros guardados de form correcta", MsgBoxStyle.Information, "Guardar")
                            btnCancelar_Click(sender, e)
                        End If
                    Case 3
                        'eliminar registro
                        'editar registros
                        Dim usuario As String = DataContext.usuarioLog.Codoperador
                        If String.Equals(usuario, "ADMIN") = False Then
                            MsgBox("NO cuenta con los privilegios para eliminar datos.", MsgBoxStyle.Information, "Error")
                            Return
                        End If
                        If Me._cierreSeleccionado = 0 Then
                            MsgBox("NO ha seleccionado ningun valor para editar", MsgBoxStyle.Information, "Error")
                            Return
                        End If
                        Dim buscar As CierrePrecios = (From cp In ctx.CierrePrecios Where cp.CodCierre = Me._cierreSeleccionado Select cp).Single
                        If buscar.OnzasFinas <> buscar.SaldoOnzas Then
                            MsgBox("NO se puede eliminar este cierre de precio, ya que se han aplicado compras a dicho cierre", MsgBoxStyle.Information, "Guardar")
                            Return
                        End If
                        Dim result As DialogResult = MsgBox("¿Guardar registro de cierre de precio?", MsgBoxStyle.YesNo, "Guardar")
                        If result = Windows.Forms.DialogResult.Yes Then
                            ctx.CierrePrecios.DeleteOnSubmit(buscar)
                            ctx.SubmitChanges()
                            MsgBox("Registros guardados de form correcta", MsgBoxStyle.Information, "Guardar")
                            btnCancelar_Click(sender, e)
                        End If
                End Select
                btnNuevo.Focus()
            Catch ex As Exception
                MsgBox("Se produjo un error al guardar los datos: " & ex.Message, MsgBoxStyle.Critical, "Error al guardar")
            End Try
        End Using
    End Sub


    Private Sub dgvCierresCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCierresCliente.CellClick
        Try
            Dim row As DataGridViewRow = dgvCierresCliente.CurrentRow
            Dim buscar As CierrePrecios = Me.recuperarCierre(Convert.ToInt32(row.Cells(0).Value))
            txtOnzas.Text = Convert.ToString(buscar.OnzasFinas)
            txtGramos.Text = Convert.ToString(buscar.GramosFinos)
            Dim daoCliente = DataContext.daoCliente
            Dim cliente As Cliente = daoCliente.findById(buscar.Codcliente)
            txtNombre.Text = cliente.Nombres & " " & cliente.Apellidos
            txtCodigo.Text = buscar.Codcliente
            txtMargen.Text = Convert.ToString(buscar.Margen)
            txtPrecioBase.Text = Convert.ToString(buscar.PrecioBase)
            txtPrecioOro.Text = Convert.ToString(buscar.PrecioOro)
            Me._cierreSeleccionado = Convert.ToInt32(row.Cells(0).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtMargen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMargen.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                btnCalcular.Focus()
        End Select
    End Sub

    Private Sub btnCalcular_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCalcular.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                btnGuardar.Focus()
        End Select
    End Sub

    Private Sub btnCerrarPrecio_Click(sender As Object, e As EventArgs) Handles btnCerrarPrecio.Click
        Using ctx As New Contexto
            Try
                Dim row As DataGridViewRow = dgvCierresCliente.CurrentRow
                Dim codcierre As Integer = Convert.ToInt32(row.Cells("colCodigo").Value)
                Dim config As New ConfiguracionGeneral
                Dim agencia As String = config.getAgencia
                Dim buscar = (From c In ctx.CierrePrecios Where c.CodCierre = codcierre And c.Status = True Select c).Single
                Dim result As DialogResult = MsgBox("¿Seguro desea cerrar el precio seleccionado, esta acción no se puede revertir?", MsgBoxStyle.YesNo, Title)
                If result = DialogResult.No Then
                    Return
                End If
                Dim deta As New Detacierre With {.Codcierre = buscar.CodCierre, .Codagencia = agencia, .Fecha = Date.Now, .Cantidad = buscar.SaldoOnzas, .Numcompra = "0", .Onzas = buscar.SaldoOnzas, .Saldo = Decimal.Zero}
                buscar.Status = False
                buscar.SaldoOnzas = Decimal.Zero
                ctx.DetaCierre.InsertOnSubmit(deta)
                ctx.SubmitChanges()
                MsgBox("Se ha cerrado el precio seleccionado", MsgBoxStyle.Information, Title)
                btnCancelar_Click(sender, e)
            Catch ex As Exception
                MsgBox("Se produjo un error al intentar cerrar el precio" & vbCr & ex.Message, MsgBoxStyle.Information, Title)
            End Try
        End Using
    End Sub
End Class

Imports EfectiOro.Database

Public Class frmPrecios2
    Private Const Title As String = "Precios"
    Private _codcliente As String
    Private _salir As DialogResult = DialogResult.Yes
    Private _nombreCliente As String
    ''' <summary>
    ''' La diferencia de onzas, al ingresar al grid, de forma informativa, no se guarda el valor
    ''' </summary>
    Private dif_onzas As Decimal = Decimal.Zero
    ''' <summary>
    ''' Vemos cuantas onzas disponibles tiene, para mostrar al usuarios
    ''' </summary>
    Dim onzasDisponibles As Decimal = Decimal.Zero
    ''' <summary>
    ''' Esto para mostrar las onzas que se estan ingresando, en el tooltip, de forma informativa, no se usa para guardar
    ''' </summary>
    Private onzas_acumuladas As Decimal = Decimal.Zero
    ''' <summary>
    ''' Esta variable es para saber si guardo algun dato
    ''' </summary>
    Private guardo As Boolean
    ''' <summary>
    ''' Linea que indica en que posicion se encuetra el precio
    ''' </summary>
    Private linea As Integer = 1
    ''' <summary>
    ''' Esto es para el calculo del precio cuando se usa mas de un cierre, una multiplicacion de matriz 1 x 1
    ''' </summary>
    Private calculoPrecioBaseMatriz As List(Of Decimal)
    ''' <summary>
    ''' Precio bases de los cierres usados para las onzas a ingresar
    ''' </summary>
    Private _preciosBaseCierres As Dictionary(Of Integer, Decimal)
    ''' <summary>
    ''' Esto se usa para saber la diferencia de onzas segun el cierre q se uso
    ''' </summary>
    ''' <remarks></remarks>
    Private _onzasDiferencias As Dictionary(Of Integer, Decimal)
    ''' <summary>
    ''' Esto se usa para cuando el usuario quita una linea de precio, asi se regresan las onzas correspondiente.
    ''' </summary>
    Private onzasUsadasLinea As Dictionary(Of Integer, List(Of CierrePrecios))
    ''' <summary>
    ''' Lista de cierre seleccionados en el grid
    ''' </summary>
    Private listaCierreClientes As List(Of CierrePrecios)
    ''' <summary>
    ''' Esta lista se usa para saber que cierras ha usado y poder guardar su detalle
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _listaCierresUsar As List(Of CierrePrecios)
    ''' <summary>
    ''' Esto para cuando las onzas a ingresar son mayores a las disponibles, entonces se cancela el ingreso y se regresan las onzas usadas a su respectivo cierre
    ''' </summary>
    Private onzasUsadas As Dictionary(Of Integer, Dictionary(Of Integer, Decimal))


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _onzasDiferencias = New Dictionary(Of Integer, Decimal)
        frmPrecios2._listaCierresUsar = New List(Of CierrePrecios)
        _preciosBaseCierres = New Dictionary(Of Integer, Decimal)
        calculoPrecioBaseMatriz = New List(Of Decimal)
        onzasUsadasLinea = New Dictionary(Of Integer, List(Of CierrePrecios))
        listaCierreClientes = New List(Of CierrePrecios)
        onzasUsadas = New Dictionary(Of Integer, Dictionary(Of Integer, Decimal))
    End Sub
    Sub clear()
        If dgvCliente.Visible = True Then
            dgvCliente.Visible = False
        End If
        txtNombre.Clear()
        txtCodigo.Clear()
    End Sub
    Sub clearText()
        txtNombre.Clear()
        txtCodigo.Clear()
        txtPrecioOro.Clear()
        txtMargen.Clear()
        txtQuilate.Clear()
        txtGramos.Clear()
        dgvPrecios.Rows.Clear()
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnCancelar_Click(sender, e)
        If _salir = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Sub seleccionarCliente()
        Dim row As DataGridViewRow = dgvCliente.CurrentRow
        _codcliente = row.Cells(0).Value
        _nombreCliente = row.Cells(1).Value & " " & row.Cells(2).Value
        Using ctx As New Contexto
            Try
                Dim findCierres = (From cp In ctx.CierrePrecios Where cp.Codcliente = _codcliente _
                                    And cp.Status = True And cp.SaldoOnzas > 0 Order By cp.CodCierre Ascending Select cp).ToList
                onzasDisponibles = findCierres.Sum(Function(c) c.SaldoOnzas)
                lblOnzasDisponibles.Text = onzasDisponibles
                bsCierres.DataSource = findCierres
                For Each rows As DataGridViewRow In dgvCierrePrecios.Rows
                    rows.Cells(0).Value = True
                Next
                listaCierreClientes.AddRange(findCierres)
                lblOnzasDisponibles.Text = findCierres.Sum(Function(p) p.SaldoOnzas).ToString("#,##0.000")
                lblOnzasIngresar.Text = findCierres.Sum(Function(p) p.SaldoOnzas).ToString("#,##0.000")
                Dim preciosCliente = (From p In ctx.Precios Where p.Codcliente = _codcliente Select p).ToList
                If preciosCliente.Count > 0 Then
                    MsgBox("El cliente actual tiene precios establecidos, eliminelos para poder continuar", MsgBoxStyle.Information, Title)
                End If
            Catch ex As Exception

            End Try
        End Using
    End Sub
    Private Sub TxtNombre_Enter(sender As Object, e As EventArgs) Handles txtNombre.Enter
        If dgvCliente.Visible = False Then
            dgvCliente.Visible = True
            dgvCliente.Size = New Size(477, 150)
        End If
    End Sub


    Private Sub txtNombre_TextChanged_1(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Try
            Using ctx As New Contexto
                Dim buscar = (From c In ctx.Cliente Where c.Nombres.Contains(txtNombre.Text) OrElse c.Apellidos.Contains(txtNombre.Text)
                              Select c.Codcliente, c.Nombres, c.Apellidos, c.Numcedula).ToList
                dgvCliente.DataSource = buscar
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error buscar")
        End Try
    End Sub

    Private Sub txtQuilate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuilate.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                If txtPrecioOro.Text.Trim.Length <= 0 Then
                    txtPrecioOro.Text = Convert.ToString(Decimal.One)
                End If
                txtPrecioOro.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Enter
                btnAgregar.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim quilate, precioOro, margen As Decimal
        Dim gramos As Decimal = Decimal.Zero
        Dim dao = DataContext.daoPrecioKilate
        If txtCodigo.Text.Trim.Length <= 0 Then
            MsgBox("Debe especificar el cliente para continuar", MsgBoxStyle.Information, Title)
            txtNombre.Focus()
            Return
        End If
        If txtQuilate.Text.Trim.Length <= 0 Then
            erp.SetError(txtQuilate, "Debe establecer un valor para continuar")
            txtQuilate.Focus()
            Return
        Else
            quilate = Convert.ToDecimal(txtQuilate.Text)
        End If
        If txtPrecioOro.Text.Trim.Length <= 0 Then
            erp.SetError(txtPrecioOro, "Debe establecer un valor para continuar")
            txtPrecioOro.Focus()
            Return
        Else
            precioOro = Convert.ToDecimal(txtPrecioOro.Text)
        End If
        If txtMargen.Text.Trim.Length <= 0 Then
            erp.SetError(txtMargen, "Debe establecer un valor para continuar")
            txtMargen.Focus()
            Return
        Else
            margen = Convert.ToDecimal(txtMargen.Text)
        End If
        If txtGramos.Text.Trim.Length <= 0 Then
            erp.SetError(txtGramos, "Debe establecer un valor para continuar")
            txtGramos.Focus()
            Return
        Else
            gramos = Convert.ToDecimal(txtGramos.Text)
        End If
        'calculamos el precio a establecer segun el quilataje especificado
        Try
            Dim daoPrecios = DataContext.daoPrecioKilate
            Dim onzas_grid As Decimal = Decimal.Zero
            Dim onzas_diferencia As Decimal = Decimal.Zero
            Dim onzas_ingresar As Decimal = gramos * quilate / 24 / 31.1035
            Dim temp_onzas As Decimal = onzas_ingresar
            Dim listaCierreClientes As List(Of CierrePrecios) = dao.listaCierresPreciosCliente(txtCodigo.Text)
            If listaCierreClientes.Count > 0 Then
                Dim sum_onzas = listaCierreClientes.Sum(Function(p) p.SaldoOnzas)
                Dim ver_onzas = Decimal.Subtract(onzas_ingresar, sum_onzas)
                ver_onzas = Decimal.Round(redondearMenos(ver_onzas, 0.0005), 3)
                If ver_onzas > Decimal.Zero Then
                    MsgBox("No hay onzas disponibles para ingresar, intente nuevamente." & vbCr & "Diferencias en Onzas: " & ver_onzas.ToString("#,##0.000"), MsgBoxStyle.Information, "Mensaje")
                    Return
                End If
                onzas_acumuladas = Decimal.Add(onzas_acumuladas, onzas_ingresar)
                onzas_acumuladas = redondearMenos(onzas_acumuladas, 0.0005)
                lblOnzasIngresar.Text = Decimal.Round(onzas_acumuladas, 3)
                dif_onzas = Decimal.Subtract(onzasDisponibles, onzas_acumuladas)
                dif_onzas = redondearMenos(dif_onzas, 0.0005)
                lblOnzasDiferencia.Text = Decimal.Round(dif_onzas, 3)
                calculoPrecioBaseMatriz.Clear()
                'Dim aux_linea As Integer = linea
                calcularPrecio(onzas_ingresar, quilate, gramos)
                txtQuilate.Clear()
                txtGramos.Clear()
                txtQuilate.Focus()
                'If onzas_ingresar > Decimal.Zero Then
                '    MsgBox("NO se pudo ingresar el precio, ya que las onza a ingresar son mayores a las disponibles", MsgBoxStyle.Information, "Precios")
                'End If
            Else
                Dim precioBase As Decimal = Decimal.Zero
                Dim precio As Decimal = Decimal.Zero
                Dim tipoCambio As Decimal = Decimal.Zero
                Dim merma As Decimal = 0.002
                Dim porcentajeRmc As Decimal = 0.994
                Dim daoTipoCambio = DataContext.daoTipoCambio
                tipoCambio = daoTipoCambio.buscarDato(Now).Tipocambio1
                margen = Decimal.Divide(margen, 100)
                precioBase = (1 - margen) * (1 - merma) * porcentajeRmc * (precioOro - 0.5) * tipoCambio / 31.1035 / 24
                precioBase = Decimal.Round(precioBase, 2)
                precio = quilate * precioBase
                precio = Decimal.Round(precio, 2)
                precio = redondearMenos(precio)
                dgvPrecios.Rows.Add(linea, quilate, Decimal.Round(precio, 0), gramos)
                linea = linea + 1
                txtQuilate.Clear()
                txtGramos.Clear()
                txtQuilate.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error al ingresar los datos: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error en el grid")
        End Try
    End Sub

    Private Sub txtQuilate_TextChanged(sender As Object, e As EventArgs) Handles txtQuilate.TextChanged
        If txtQuilate.Text.Trim.Length > 0 Then
            erp.SetError(txtQuilate, "")
        End If
    End Sub

    Private Sub txtQuilate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuilate.KeyPress
        ServiciosBasicos.NumeroDec(e, txtQuilate)
    End Sub


    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                If dgvCliente.Visible = True Then
                    dgvCliente.Focus()
                End If
        End Select
    End Sub

    Private Sub dgvCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCliente.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter
                    seleccionarCliente()
                    dgvCliente.Visible = False
                    txtCodigo.Text = _codcliente
                    txtNombre.Text = _nombreCliente
                    txtQuilate.Focus()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecioOro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioOro.KeyPress
        ServiciosBasicos.NumeroDec(e, txtPrecioOro)
    End Sub

    Private Sub txtMargen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMargen.KeyPress
        ServiciosBasicos.NumeroDec(e, txtMargen)
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

    Private Sub txtMargen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMargen.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtGramos.Focus()
                e.Handled = True
        End Select
    End Sub
    Private Sub txtGramos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGramos.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                e.Handled = True
                btnAgregar.Focus()
        End Select
    End Sub

    Private Sub txtPrecioOro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioOro.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                If txtMargen.Text.Trim.Length <= 0 Then
                    txtMargen.Text = Convert.ToString(Decimal.One)
                End If
                txtMargen.Focus()
                e.Handled = True
        End Select
    End Sub
    Sub enableGrupos(opcion As Boolean)
        GroupBox1.Enabled = opcion
        GroupBox2.Enabled = opcion
        txtMargen.Enabled = opcion
        txtPrecioOro.Enabled = opcion
    End Sub
    Sub enableButtons(nuevo As Boolean, guardar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        btnRefrescarCierres.Enabled = cancelar
        btnQuitarSeleccion.Enabled = cancelar
    End Sub

    Private Sub frmPrecios2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Establecer Precios"
        enableGrupos(False)
        enableButtons(True, False, False)
        erp.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        enableGrupos(True)
        enableButtons(False, True, True)
        txtNombre.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If dgvPrecios.Rows.Count > 0 Then
            Dim result As DialogResult = MsgBox("¿Cancelar el ingreso de precios acutal?", MsgBoxStyle.YesNo, "Cancelar")
            If result = DialogResult.No Then
                _salir = DialogResult.No
                Return
            End If
            _salir = DialogResult.Yes
        End If
        If dgvCliente.Visible = True Then
            dgvCliente.Visible = False
        End If
        _codcliente = String.Empty
        _nombreCliente = String.Empty
        _onzasDiferencias.Clear()
        listaCierreClientes.Clear()
        linea = 1
        _preciosBaseCierres.Clear()
        onzasUsadasLinea.Clear()
        calculoPrecioBaseMatriz.Clear()
        dgvPrecios.Rows.Clear()
        dgvCierrePrecios.Rows.Clear()
        lblOnzasDiferencia.Text = "0.00"
        lblOnzasDisponibles.Text = "0.00"
        lblOnzasIngresar.Text = "0.00"
        onzas_acumuladas = Decimal.Zero
        onzasDisponibles = Decimal.Zero
        enableGrupos(False)
        enableButtons(True, False, False)
        _onzasDiferencias.Clear()
        onzasUsadas.Clear()
        clearText()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs)
        Try
            Dim result As DialogResult = MsgBox("¿Seguro desea quitar el item seleccionado de la lista?", MsgBoxStyle.YesNo, Title)
            If result = Windows.Forms.DialogResult.No Then
                Return
            End If
            Dim fila As DataGridViewRow = dgvPrecios.CurrentRow
            Dim linea As Integer = Convert.ToInt32(fila.Cells("colLinea").Value)
            Dim listaCierres As List(Of CierrePrecios) = onzasUsadasLinea.Item(linea)
            For Each dato As CierrePrecios In listaCierres
                _onzasDiferencias.Item(dato.CodCierre) = Decimal.Add(dato.SaldoOnzas, _onzasDiferencias.Item(dato.CodCierre))
            Next
            onzasUsadasLinea.Remove(linea)
            dgvPrecios.Rows.Remove(fila)
        Catch ex As Exception
            MsgBox("NO se pudo quitar la fila seleccionada: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Using ctx As New Contexto
                If dgvPrecios.Rows.Count <= 0 Then
                    MsgBox("No hay datos a guardar, por favor intente nuevamente", MsgBoxStyle.Information, "Guarar")
                    Return
                End If
                Dim result As DialogResult = MsgBox("¿Guardar los datos de precios del cliente?", MsgBoxStyle.YesNo, Title)
                If result = Windows.Forms.DialogResult.No Then
                    Return
                End If
                Dim guardarDatos As New List(Of Precios)
                For Each row As DataGridViewRow In dgvPrecios.Rows
                    Dim datos As New Precios
                    datos.Precio = Convert.ToDecimal(row.Cells("colPrecio").Value)
                    datos.Kilate = Convert.ToDecimal(row.Cells("colQuilate").Value)
                    datos.Codcliente = txtCodigo.Text
                    datos.PrecioOro = Convert.ToDecimal(txtPrecioOro.Text)
                    datos.Gramos = Convert.ToDecimal(row.Cells("colGramos").Value)
                    guardarDatos.Add(datos)
                Next
                Dim tmpPrecios As New List(Of TmpPrecios)
                If _onzasDiferencias.Count > 0 Then
                    If _listaCierresUsar.Count > 0 Then
                        _listaCierresUsar.Clear()
                    End If
                    linea = 1
                    For Each dato In _onzasDiferencias
                        Dim cierre As New CierrePrecios
                        Dim tmp_precios As New TmpPrecios
                        tmp_precios.Codcierre = dato.Key
                        tmp_precios.Cantidad = dato.Value
                        tmp_precios.Codcliente = txtCodigo.Text
                        tmp_precios.Fecha = Now
                        tmp_precios.Linea = linea
                        cierre.CodCierre = dato.Key
                        cierre.SaldoOnzas = dato.Value
                        cierre.Codcliente = txtCodigo.Text
                        tmpPrecios.Add(tmp_precios)
                        _listaCierresUsar.Add(cierre)
                        linea += 1
                    Next
                End If
                ctx.TmpPrecios.InsertAllOnSubmit(tmpPrecios)
                ctx.Precios.InsertAllOnSubmit(guardarDatos)
                ctx.SubmitChanges()
                guardo = True
                clearText()
                btnCancelar_Click(sender, e)
            End Using
        Catch ex As Exception
            MsgBox("Se produjo un error al guardar: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub txtGramos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGramos.KeyPress
        NumeroDec(e, txtGramos)
    End Sub

    Private Sub dgvCierrePrecios_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCierrePrecios.CellValueChanged
        'Try
        '    Dim dao = DataContext.daoPrecioKilate
        '    If dgvCierrePrecios.Columns(e.ColumnIndex).Name = "colSeleccionar" Then
        '        Dim row As DataGridViewRow = dgvCierrePrecios.Rows(e.RowIndex)
        '        Dim cellSeleccion As DataGridViewCheckBoxCell = row.Cells("colSeleccionar")
        '        Dim codigo As Integer = Convert.ToInt32(row.Cells("colCodcierre").Value)
        '        Dim cierre_precio As CierrePrecios = dao.findCierrePrecio(codigo)
        '        If Convert.ToBoolean(cellSeleccion.Value) = True Then
        '            onzasDisponibles = Decimal.Add(onzasDisponibles, cierre_precio.SaldoOnzas)
        '            dif_onzas = Decimal.Subtract(onzasDisponibles, onzas_acumuladas)
        '            dif_onzas = redondearMenos(dif_onzas, 0.0005)
        '            listaCierreClientes.Add(cierre_precio)
        '        Else
        '            Dim find = listaCierreClientes.Find(Function(d) d.CodCierre = cierre_precio.CodCierre)
        '            onzasDisponibles = Decimal.Subtract(onzasDisponibles, cierre_precio.SaldoOnzas)
        '            dif_onzas = Decimal.Subtract(onzasDisponibles, onzas_acumuladas)
        '            dif_onzas = redondearMenos(dif_onzas, 0.0005)
        '            listaCierreClientes.Remove(find)
        '        End If
        '        lblOnzasDiferencia.Text = Decimal.Round(dif_onzas, 3)
        '        lblOnzasDisponibles.Text = Decimal.Round(onzasDisponibles, 3)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Warning")
        'End Try
    End Sub

    Private Sub btnQuitarSeleccion_Click(sender As Object, e As EventArgs) Handles btnQuitarSeleccion.Click
        Using ctx As New Contexto
            Try
                Dim result As DialogResult = MsgBox("¿Eliminar precios del cliente (esta acción no se puede revertir)?", MsgBoxStyle.YesNo, Title)
                If result = DialogResult.No Then
                    Return
                End If
                If txtCodigo.Text.Trim.Length <= 0 Then
                    MsgBox("No se ha especificado el cliente, intente nuevamente", MsgBoxStyle.Information, Title)
                    txtCodigo.Focus()
                    Return
                End If
                Dim buscarPreciosCliente = (From p In ctx.Precios Where p.Codcliente = txtCodigo.Text Select p).ToList
                Dim buscarTempPrecios = (From tmp In ctx.TmpPrecios Where tmp.Codcliente = txtCodigo.Text Select tmp).ToList
                If buscarPreciosCliente.Count <= 0 Then
                    MsgBox("El cliente actual no tiene precios a eliminar", MsgBoxStyle.Information, Title)
                    Return
                End If
                ctx.Precios.DeleteAllOnSubmit(buscarPreciosCliente)
                ctx.TmpPrecios.DeleteAllOnSubmit(buscarTempPrecios)
                ctx.SubmitChanges()
                MsgBox("Se han limpiado los precios del cliente seleccionado, ahora puede proceder a establecer nuevos precios", MsgBoxStyle.Information, Title)
            Catch ex As Exception
                MsgBox("No se pudo completar la operación debido a un error interno: " & ex.Message, MsgBoxStyle.Critical, "Error precios")
            End Try
        End Using
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        btnCancelar_Click(sender, e)
        If _salir = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnRefrescarCierres_Click(sender As Object, e As EventArgs) Handles btnRefrescarCierres.Click
        Using ctx As New Contexto
            Try
                Dim list_x As List(Of Integer) = (From c In bsCierres.Cast(Of CierrePrecios) Select c.CodCierre).ToList
                Dim listaCierres = (From c In ctx.CierrePrecios
                                    Where c.Codcliente = txtCodigo.Text And c.Status = True
                                    Select c).ToList
                Dim nuevosCierres = (From c In listaCierres Where Not list_x.Contains(c.CodCierre) Select c).ToList
                For Each valor As CierrePrecios In bsCierres
                    Dim y_saldo As Decimal = Decimal.Zero
                    For Each x_row As DataGridViewRow In dgvCierrePrecios.Rows
                        Dim x_value = Convert.ToInt32(x_row.Cells("CodCierreDataGridViewTextBoxColumn").Value)
                        If valor.CodCierre = x_value Then
                            y_saldo = Convert.ToDecimal(x_row.Cells("OnzasFinasDataGridViewTextBoxColumn").Value)
                            Exit For
                        End If
                    Next
                    Dim var = (From c In listaCierres Where c.CodCierre = valor.CodCierre Select c).Single
                    If var.OnzasFinas <> valor.OnzasFinas Then
                        Dim dif = Decimal.Subtract(var.SaldoOnzas, y_saldo)
                        valor.SaldoOnzas = Decimal.Add(valor.SaldoOnzas, dif)
                        valor.OnzasFinas = var.OnzasFinas
                        If _onzasDiferencias.ContainsKey(valor.CodCierre) Then
                            Dim sal = _onzasDiferencias.Item(valor.CodCierre)
                            sal = Decimal.Add(sal, dif)
                            _onzasDiferencias.Item(valor.CodCierre) = sal
                        End If
                    End If
                Next
                For Each valor As CierrePrecios In nuevosCierres
                    bsCierres.Add(valor)
                Next
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub dgvCierrePrecios_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCierrePrecios.CellEndEdit
        Try
            Dim seleccionar As Boolean
            Dim x_cierre As CierrePrecios
            If e.ColumnIndex = 0 Then
                seleccionar = dgvCierrePrecios.Rows(e.RowIndex).Cells(0).Value
                x_cierre = bsCierres.Item(e.RowIndex)
                Using ctx As New Contexto
                    Dim findCierre = (From c In ctx.CierrePrecios Where c.CodCierre = x_cierre.CodCierre Select c).Single
                    If seleccionar = True Then
                        If Not listaCierreClientes.Contains(x_cierre) Then
                            listaCierreClientes.Add(x_cierre)
                        End If
                    Else
                        If Not findCierre.SaldoOnzas.Equals(x_cierre.SaldoOnzas) Then
                            dgvCierrePrecios.Rows(e.RowIndex).Cells(0).Value = True
                            MsgBox("No puede quitar el cierre seleccinado ya que se ha usado para ingresar precios.", MsgBoxStyle.Exclamation, Title)
                            Return
                        End If
                        If listaCierreClientes.Contains(x_cierre) Then
                            listaCierreClientes.Remove(x_cierre)
                        End If
                    End If
                    Dim x_onzas As Decimal = listaCierreClientes.Sum(Function(c) c.SaldoOnzas)
                    dif_onzas = Decimal.Subtract(x_onzas, onzas_acumuladas)
                    lblOnzasDiferencia.Text = Decimal.Round(dif_onzas, 3)
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Warning")
        End Try
    End Sub

    Private Sub BtnQuitarLinea_Click(sender As Object, e As EventArgs) Handles BtnQuitarLinea.Click
        Try
            Dim result = MessageBox.Show(Me, "¿Seguiro quiere quitar la linea seleccionada?", "Quitar item", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return
            End If
            Dim row = dgvPrecios.CurrentRow()
            Dim aux_linea As Integer = row.Cells("colLinea").Value
            If onzasUsadas.ContainsKey(aux_linea) Then
                'despues de devolver las onzas recalculamos los precios bases nuevamente
                For Each dato As CierrePrecios In listaCierreClientes
                    For Each valor In onzasUsadas
                        Dim tmp = valor.Value
                        If tmp.ContainsKey(dato.CodCierre) Then
                            dato.SaldoOnzas = Decimal.Add(dato.SaldoOnzas, tmp.Item(dato.CodCierre))
                        End If
                    Next
                Next
                linea = 1
                onzasUsadas.Clear()
                _onzasDiferencias.Clear()
                _preciosBaseCierres.Clear()
                calculoPrecioBaseMatriz.Clear()
                Dim valores_grid As New Dictionary(Of Decimal, Decimal)
                If dgvPrecios.Rows.Count > 1 Then
                    dgvPrecios.Rows.RemoveAt(row.Index)
                Else
                    dgvPrecios.Rows.RemoveAt(row.Index)
                    Return
                End If
                For Each value_row In dgvPrecios.Rows
                    Dim quilate As Decimal = Convert.ToDecimal(value_row.Cells("colQuilate").Value)
                    Dim gramos As Decimal = Convert.ToDecimal(value_row.Cells("colGramos").Value)
                    valores_grid.Add(quilate, gramos)
                Next
                dgvPrecios.Rows.Clear()
                For Each dato In valores_grid
                    Dim quilate As Decimal = dato.Key
                    Dim gramos As Decimal = dato.Value
                    Dim onzas_ingresar = gramos * quilate / 24 / 31.1035
                    calcularPrecio(onzas_ingresar, quilate, gramos)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub calcularPrecio(onzas_ingresar As Decimal, quilate As Decimal, gramos As Decimal)
        Try
            Dim aux_linea = linea
            'Dim onzas_ingresar As Decimal = gramos * quilate / 24 / 31.1035
            Dim temp_onzas As Decimal = onzas_ingresar
            Dim onzas_diferencia = Decimal.Zero
            For Each dato As CierrePrecios In listaCierreClientes
                Dim saldo_onzas = dato.SaldoOnzas
                If onzas_ingresar > Decimal.Zero Then
                    If _onzasDiferencias.ContainsKey(dato.CodCierre) Then
                        Dim findOnzas = _onzasDiferencias.Item(dato.CodCierre)
                        If findOnzas > 0 Then
                            Dim temporal_onzas As Decimal = findOnzas
                            'esta variable es para almecenar las onzas encontradas para luego comparar
                            temporal_onzas = redondearMenos(findOnzas, 0.005)
                            Dim temporal_onzas_ingresar As Decimal = redondearMenos(onzas_ingresar, 0.005)
                            'restamos las variables temporales con 4 decimales
                            'con un redondeo hacia abajo
                            Dim difrencias_temporales As Decimal = Decimal.Subtract(temporal_onzas, temporal_onzas_ingresar)
                            onzas_diferencia = Decimal.Subtract(findOnzas, onzas_ingresar)
                            If difrencias_temporales < Decimal.Zero Then
                                _onzasDiferencias.Item(dato.CodCierre) = Decimal.Zero
                                Dim calculo As Decimal = dato.PrecioBase * findOnzas
                                'calculo = ServiciosBasicos.redondearMenos(calculo)
                                calculoPrecioBaseMatriz.Add(calculo)
                                onzas_ingresar = Decimal.Subtract(onzas_ingresar, findOnzas)
                                'onzas_ingresar = onzas_ingresar
                                'este es valor que se uso para las onzas
                                dato.SaldoOnzas = Decimal.Zero
                            Else
                                _onzasDiferencias.Item(dato.CodCierre) = Decimal.Round(onzas_diferencia, 3)
                                Dim pb As Decimal = _preciosBaseCierres.Item(dato.CodCierre)
                                'pb = ServiciosBasicos.redondearMenos(pb)
                                Dim precio As Decimal = pb * quilate
                                'precio = ServiciosBasicos.redondearMenos(precio)
                                dgvPrecios.Rows.Add(linea, quilate, Decimal.Round(precio, 2), gramos)
                                'onzas usadas para el precio
                                dato.SaldoOnzas = Decimal.Subtract(dato.SaldoOnzas, onzas_ingresar)
                                linea = linea + 1
                                onzas_ingresar = Decimal.Zero
                            End If
                        End If
                    Else
                        Dim temporal_onzas As Decimal = dato.SaldoOnzas
                        'esta variable es para almecenar las onzas encontradas para luego comparar
                        temporal_onzas = redondearMenos(dato.SaldoOnzas, 0.0005)
                        Dim temporal_onzas_ingresar As Decimal = redondearMenos(onzas_ingresar, 0.0005)
                        'restamos las variables temporales con 4 decimales
                        'con un redondeo hacia abajo
                        Dim difrencias_temporales As Decimal = Decimal.Subtract(dato.SaldoOnzas, temporal_onzas_ingresar)
                        onzas_diferencia = Decimal.Subtract(dato.SaldoOnzas, onzas_ingresar)
                        If difrencias_temporales < Decimal.Zero Then
                            _onzasDiferencias.Add(dato.CodCierre, Decimal.Zero)
                            _preciosBaseCierres.Add(dato.CodCierre, dato.PrecioBase)
                            Dim calculo As Decimal = dato.PrecioBase * dato.SaldoOnzas
                            'calculo = ServiciosBasicos.redondearMenos(calculo)
                            calculoPrecioBaseMatriz.Add(calculo)
                            onzas_ingresar = Decimal.Subtract(onzas_ingresar, dato.SaldoOnzas)
                            dato.SaldoOnzas = Decimal.Zero
                        Else
                            Dim precio As Decimal = Decimal.Zero
                            Dim pb As Decimal = Decimal.Zero
                            If Decimal.Equals(onzas_ingresar, temp_onzas) = False Then
                                pb = dato.PrecioBase * onzas_ingresar
                                Dim sum_pb As Decimal = calculoPrecioBaseMatriz.Sum()
                                'sum_pb = ServiciosBasicos.redondearMenos(sum_pb)
                                Dim tempPrecioBase As Decimal = (pb + sum_pb) / temp_onzas
                                'tempPrecioBase = ServiciosBasicos.redondearMenos(tempPrecioBase)
                                tempPrecioBase = Decimal.Round(tempPrecioBase, 2)
                                precio = tempPrecioBase * quilate
                            Else
                                precio = dato.PrecioBase * quilate
                                precio = redondearMenos(precio, 0.0005)
                            End If
                            'precio = ServiciosBasicos.redondearMenos(precio)
                            _onzasDiferencias.Add(dato.CodCierre, Decimal.Round(onzas_diferencia, 3))
                            _preciosBaseCierres.Add(dato.CodCierre, dato.PrecioBase)
                            precio = redondearMenos(precio, 0.005)
                            precio = Decimal.Round(precio, 2)
                            dgvPrecios.Rows.Add(linea, quilate, precio, gramos)
                            'onzas usadas para el precio
                            dato.SaldoOnzas = Decimal.Subtract(dato.SaldoOnzas, onzas_ingresar)
                            linea = linea + 1
                            onzas_ingresar = Decimal.Zero
                        End If
                    End If
                End If
                Dim x_onzas = Decimal.Subtract(saldo_onzas, dato.SaldoOnzas)
                If onzasUsadas.ContainsKey(aux_linea) Then
                    Dim buscar_onzas = onzasUsadas.Item(aux_linea)
                    buscar_onzas.Add(dato.CodCierre, x_onzas)
                Else
                    onzasUsadas.Add(aux_linea, New Dictionary(Of Integer, Decimal) From {{dato.CodCierre, x_onzas}})
                End If
            Next
            If onzas_ingresar > Decimal.Zero Then
                MsgBox("NO se pudo ingresar el precio, ya que las onza a ingresar son mayores a las disponibles", MsgBoxStyle.Information, "Precios")
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error al calcular el precio de las onzas: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class

Imports EfectiOro.Database

Public Class frmPrecios2
    Private _codcliente As String
    Private _nombreCliente As String
    ''' <summary>
    ''' Esta variable es para saber si guardo algun dato
    ''' </summary>
    Private guardo As Boolean
    ''' <summary>
    ''' Linea que indica en que posicion se encuetra el precio
    ''' </summary>
    Private linea As Integer = 1
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
    ''' Esto para cuando las onzas a ingresar son mayores a las disponibles, entonces se can
    ''' </summary>
    Private onzasUsadas As Dictionary(Of Integer, Decimal)
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
        onzasUsadas = New Dictionary(Of Integer, Decimal)
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
        _codcliente = String.Empty
        _nombreCliente = String.Empty
        clear()
        clearText()
        linea = 1
        dgvCierrePrecios.Rows.Clear()
        onzasUsadasLinea.Clear()
        calculoPrecioBaseMatriz.Clear()
        _onzasDiferencias.Clear()
        _preciosBaseCierres.Clear()
        If guardo = False Then
            listaCierreClientes.Clear()
            _listaCierresUsar.Clear()
            dgvPrecios.Rows.Clear()
        End If
        Me.Close()
    End Sub
    Sub seleccionarCliente()
        Dim row As DataGridViewRow = dgvCliente.CurrentRow
        _codcliente = row.Cells(0).Value
        _nombreCliente = row.Cells(1).Value & " " & row.Cells(2).Value
        Using ctx As New Contexto
            Try
                dgvCierrePrecios.Rows.Clear()
                listaCierreClientes = (From cp In ctx.CierrePrecios Where cp.Codcliente = _codcliente And cp.Status = True And cp.SaldoOnzas > 0 Select cp).ToList
                For Each valor In listaCierreClientes
                    dgvCierrePrecios.Rows.Add(True, valor.CodCierre, valor.SaldoOnzas, valor.PrecioOro, valor.PrecioBase, valor.Margen)
                Next
                Dim preciosCliente = (From p In ctx.Precios Where p.Codcliente = _codcliente Select p).ToList
                If preciosCliente.Count > 0 Then
                    MsgBox("El cliente actual tiene precios establecidos, eliminelos para poder continuar", MsgBoxStyle.Information, "Precios")
                End If
            Catch ex As Exception

            End Try
        End Using
    End Sub
    Private Sub txtNombre_Enter(sender As Object, e As EventArgs) Handles txtNombre.Enter
        If dgvCliente.Visible = False Then
            dgvCliente.Visible = True
            dgvCliente.Size = New Size(477, 150)
        End If
    End Sub


    Private Sub txtNombre_TextChanged_1(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Try
            Using ctx As New Contexto
                Dim buscar = (From c In ctx.Cliente Where c.Nombres.Contains(txtNombre.Text) Select c.Codcliente, c.Nombres, c.Apellidos, c.Numcedula).ToList
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
            MsgBox("Debe especificar el cliente para continuar", MsgBoxStyle.Information, "Cierre precios")
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
            Dim listaCierresUsadosPrecios As New List(Of CierrePrecios)
            Dim onzas_grid As Decimal = Decimal.Zero
            Dim onzas_diferencia As Decimal = Decimal.Zero
            Dim onzas_ingresar As Decimal = gramos * quilate / 24 / 31.1035
            onzas_ingresar = onzas_ingresar
            Dim temp_onzas As Decimal = onzas_ingresar
            'Dim listaCierreClientes As List(Of CierrePrecios) = dao.listaCierresPreciosCliente(txtCodigo.Text)
            If listaCierreClientes.Count > 0 Then
                Dim onzasDisponibles As Decimal = listaCierreClientes.Sum(Function(p) p.SaldoOnzas)
                calculoPrecioBaseMatriz.Clear()
                onzasUsadas.Clear()
                For Each dato As CierrePrecios In listaCierreClientes
                    If onzas_ingresar > Decimal.Zero Then
                        Try
                            Dim findOnzas = _onzasDiferencias.Item(dato.CodCierre)
                            If findOnzas > 0 Then
                                onzas_diferencia = Decimal.Subtract(findOnzas, onzas_ingresar)
                                If onzas_diferencia < Decimal.Zero Then
                                    _onzasDiferencias.Item(dato.CodCierre) = Decimal.Zero
                                    Dim calculo As Decimal = dato.PrecioBase * findOnzas
                                    'calculo = ServiciosBasicos.redondearMenos(calculo)
                                    calculoPrecioBaseMatriz.Add(calculo)
                                    onzas_ingresar = Decimal.Subtract(onzas_ingresar, findOnzas)
                                    onzas_ingresar = onzas_ingresar
                                    'este es valor que se uso para las onzas
                                    dato.SaldoOnzas = findOnzas
                                    onzasUsadas.Add(dato.CodCierre, findOnzas)
                                    listaCierresUsadosPrecios.Add(dato)
                                Else
                                    _onzasDiferencias.Item(dato.CodCierre) = Decimal.Round(onzas_diferencia, 4)
                                    Dim pb As Decimal = _preciosBaseCierres.Item(dato.CodCierre)
                                    'pb = ServiciosBasicos.redondearMenos(pb)
                                    Dim precio As Decimal = pb * quilate
                                    'precio = ServiciosBasicos.redondearMenos(precio)
                                    dgvPrecios.Rows.Add(linea, quilate, Decimal.Round(precio, 2), gramos)
                                    'onzas usadas para el precio
                                    dato.SaldoOnzas = onzas_ingresar
                                    onzasUsadas.Add(dato.CodCierre, onzas_ingresar)
                                    listaCierresUsadosPrecios.Add(dato)
                                    onzasUsadasLinea.Add(linea, listaCierresUsadosPrecios)
                                    linea = linea + 1
                                    onzas_ingresar = Decimal.Zero
                                End If
                            End If
                        Catch ex As Exception
                            onzas_diferencia = Decimal.Subtract(dato.SaldoOnzas, onzas_ingresar)
                            If onzas_diferencia < Decimal.Zero Then
                                _onzasDiferencias.Add(dato.CodCierre, Decimal.Zero)
                                _preciosBaseCierres.Add(dato.CodCierre, dato.PrecioBase)
                                Dim calculo As Decimal = dato.PrecioBase * dato.SaldoOnzas
                                'calculo = ServiciosBasicos.redondearMenos(calculo)
                                calculoPrecioBaseMatriz.Add(calculo)
                                onzas_ingresar = Decimal.Subtract(onzas_ingresar, dato.SaldoOnzas)
                                onzas_ingresar = onzas_ingresar
                                onzasUsadas.Add(dato.CodCierre, dato.SaldoOnzas)
                                listaCierresUsadosPrecios.Add(dato)
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
                                End If
                                'precio = ServiciosBasicos.redondearMenos(precio)
                                _onzasDiferencias.Add(dato.CodCierre, onzas_diferencia)
                                _preciosBaseCierres.Add(dato.CodCierre, dato.PrecioBase)
                                dgvPrecios.Rows.Add(linea, quilate, Decimal.Round(precio, 2), gramos)
                                onzasUsadas.Add(dato.CodCierre, onzas_ingresar)
                                'onzas usadas para el precio
                                dato.SaldoOnzas = onzas_ingresar
                                listaCierresUsadosPrecios.Add(dato)
                                onzasUsadasLinea.Add(linea, listaCierresUsadosPrecios)
                                linea = linea + 1
                                onzas_ingresar = Decimal.Zero
                            End If
                        End Try
                    End If
                Next
                txtQuilate.Clear()
                txtGramos.Clear()
                txtQuilate.Focus()
                If onzas_ingresar > Decimal.Zero Then
                    If onzasUsadas.Count > 0 Then
                        For Each valor In onzasUsadas
                            If _onzasDiferencias.ContainsKey(valor.Key) Then
                                _onzasDiferencias.Item(valor.Key) = _onzasDiferencias.Item(valor.Key) + valor.Value
                            End If
                        Next
                    End If
                    MsgBox("NO se pudo ingresar el precio, ya que las onza a ingresar son mayores a las disponibles", MsgBoxStyle.Information, "Precios")
                End If
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
                Return
            End If
        End If
        If dgvCliente.Visible = True Then
            dgvCliente.Visible = False
        End If
        _onzasDiferencias.Clear()
        listaCierreClientes.Clear()
        linea = 1
        _preciosBaseCierres.Clear()
        onzasUsadasLinea.Clear()
        calculoPrecioBaseMatriz.Clear()
        dgvPrecios.Rows.Clear()
        dgvCierrePrecios.Rows.Clear()
        enableGrupos(False)
        enableButtons(True, False, False)
        clearText()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            Dim result As DialogResult = MsgBox("¿Seguro desea quitar el item seleccionado de la lista?", MsgBoxStyle.YesNo, "Precios")
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
                Dim result As DialogResult = MsgBox("¿Guardar los datos de precios del cliente?", MsgBoxStyle.YesNo, "Precios")
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
                If _onzasDiferencias.Count > 0 Then
                    If _listaCierresUsar.Count > 0 Then
                        _listaCierresUsar.Clear()
                    End If
                    For Each dato In _onzasDiferencias
                        Dim cierre As New CierrePrecios
                        cierre.CodCierre = dato.Key
                        cierre.SaldoOnzas = dato.Value
                        cierre.Codcliente = txtCodigo.Text
                        'Dim find = (From cp In ctx.CierrePrecios Where cp.CodCierre = dato.Key Select cp).Single
                        'find.SaldoOnzas = dato.Value
                        _listaCierresUsar.Add(cierre)
                    Next
                End If
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
        Try
            Dim dao = DataContext.daoPrecioKilate
            If dgvCierrePrecios.Columns(e.ColumnIndex).Name = "colSeleccionar" Then
                Dim row As DataGridViewRow = dgvCierrePrecios.Rows(e.RowIndex)
                Dim cellSeleccion As DataGridViewCheckBoxCell = row.Cells("colSeleccionar")
                Dim codigo As Integer = Convert.ToInt32(row.Cells("colCodcierre").Value)
                Dim cierre_precio As CierrePrecios = dao.findCierrePrecio(codigo)
                If Convert.ToBoolean(cellSeleccion.Value) = True Then
                    listaCierreClientes.Add(cierre_precio)
                Else
                    Dim find = listaCierreClientes.Find(Function(d) d.CodCierre = cierre_precio.CodCierre)
                    listaCierreClientes.Remove(find)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Warning")
        End Try
    End Sub

    Private Sub btnQuitarSeleccion_Click(sender As Object, e As EventArgs) Handles btnQuitarSeleccion.Click
        Using ctx As New Contexto
            Try
                Dim result As DialogResult = MsgBox("¿Eliminar precios del cliente (esta acción no se puede revertir)?", MsgBoxStyle.YesNo, "Precios")
                If result = DialogResult.No Then
                    Return
                End If
                If txtCodigo.Text.Trim.Length <= 0 Then
                    MsgBox("No se ha especificado el cliente, intente nuevamente", MsgBoxStyle.Information, "Precios")
                    txtCodigo.Focus()
                    Return
                End If
                Dim buscarPreciosCliente = (From p In ctx.Precios Where p.Codcliente = txtCodigo.Text Select p).ToList
                If buscarPreciosCliente.Count <= 0 Then
                    MsgBox("El cliente actual no tiene precios a eliminar", MsgBoxStyle.Information, "Precios")
                    Return
                End If
                ctx.Precios.DeleteAllOnSubmit(buscarPreciosCliente)
                ctx.SubmitChanges()
            Catch ex As Exception
                MsgBox("No se pudo completar la operación debido a un error interno: " & ex.Message, MsgBoxStyle.Critical, "Error precios")
            End Try
        End Using
    End Sub
End Class

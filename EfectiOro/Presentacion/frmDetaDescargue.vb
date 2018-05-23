Imports EfectiOro.Database

Public Class frmDetaDescargue
    Dim pesoTotal, sumTotales As Decimal
    Dim cantidadCompras As Integer
    Dim listaDetaCompra As List(Of Det_compra)
    Dim seleccionarDetaCompra As New List(Of KeyValuePair(Of String, Integer))
    Dim listaCompras As New List(Of Compras)
    Dim dataView As New DataView
    Dim dataSet As DataSet
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim fecha = txtFechaGenerar.Value
        Dim dao = DataContext.daoDescargues
        Dim generar = dao.generarLote(txtFechaGenerar.Value, "%%")
        dgvCompra.DataSource = ServiciosBasicos.ToDataTable(generar)
        listaCompras = dao.generarLote(fecha, "%%")
    End Sub

    Private Sub calcularValores()
        Dim cantidadCompras = seleccionarDetaCompra.Distinct().ToList().Count
        lblCantidadCompras.Text = cantidadCompras
        Dim dao = DataContext.daoCompras
        Dim sumaPeso As Decimal = Decimal.Zero
        Dim sumaTotal As Decimal = Decimal.Zero
        For Each valor In seleccionarDetaCompra
            Dim buscarDetaCompra = dao.findDetaCompra(valor.Key)
            Dim sumPeso = buscarDetaCompra.Where(Function(p) p.Linea = valor.Value).Sum(Function(c) c.Peso)
            Dim sumTotal = buscarDetaCompra.Where(Function(p) p.Linea = valor.Value).Sum(Function(c) c.Importe)
            sumaPeso += sumPeso
            sumaTotal += sumTotal
        Next
        pesoTotal = sumaPeso
        sumTotales = sumaTotal
        Me.cantidadCompras = cantidadCompras
        lblPesoTotal.Text = sumaPeso.ToString("#,###,##0.00")
        lblTotales.Text = sumaTotal.ToString("#,###,##0.00")
    End Sub

    Private Sub frmDetaDescargue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaDetaCompra = New List(Of Det_compra)
        lblTitulo.Text = "Generar descargue por compra"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function validarDetaCompraDescargadas(grid As DataGridView, numRow As Integer) As Boolean
        Dim dao = DataContext.daoCompras
        Dim opcion As Boolean = False
        Dim row = dgvCompra.CurrentRow
        Dim numcompra = row.Cells(2).Value
        Dim listaDetacompra = dao.findDetaCompra(numcompra)
        Dim count = listaDetacompra.Count
        Dim validar = listaDetacompra.Where(Function(f) f.Numdescargue > 0).Count
        If count = validar Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub dgvCompra_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Sub seleccionarDetaCompraDatagrid()
        Try
            Dim opcion As Boolean = False
            Dim row = dgvCompra.CurrentRow
            Dim numcompra = row.Cells(2).Value
            Dim dao = DataContext.daoCompras
            Dim listaDetacompra = dao.findDetaCompra(numcompra)
            Dim count = listaDetacompra.Count
            Dim validar = listaDetacompra.Where(Function(f) f.Numdescargue > 0).Count
            If count > validar Then
                MsgBox("Hay valores disponibles en la compra para seleccionar: " & validar)
            End If
            dgvDetacompra.Rows.Clear()
            For Each deta In listaDetacompra
                If (seleccionarDetaCompra.Count > 0) Then
                    Try
                        Dim valor = New KeyValuePair(Of String, Integer)(deta.Numcompra, deta.Linea)
                        If seleccionarDetaCompra.Contains(valor) Then
                            opcion = True
                        Else
                            opcion = False
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        opcion = False
                    End Try
                End If
                dgvDetacompra.Rows.Add(opcion, deta.Numcompra, deta.Peso, deta.Preciok, deta.Importe, deta.Linea, deta.Numdescargue)
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvCompra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompra.CellClick
        Me.seleccionarDetaCompraDatagrid()
    End Sub


    Private Sub txtFiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrar.TextChanged
        Try
            Dim dao = DataContext.daoDescargues
            Dim dt = dao.generarLoteTabla(txtFechaGenerar.Value).Tables(0)
            dataView = dt.AsDataView
            dataView.RowFilter = "numcompra like '%" & txtFiltrar.Text & "%'"
            dgvCompra.DataSource = dataView
        Catch ex As Exception
            MsgBox("No se pudo filtrar por el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvDetacompra_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetacompra.CellValueChanged
        Try
            Select Case dgvDetacompra.Columns(e.ColumnIndex).Name
                Case "colSeleccionar"
                    Dim row As DataGridViewRow = dgvDetacompra.Rows(e.RowIndex)
                    Dim cellSeleccion As DataGridViewCheckBoxCell = row.Cells(0)
                    Dim dao = DataContext.daoCompras
                    Dim numcompra As String = row.Cells("colDetanumcompra").Value
                    Dim linea = row.Cells("colLinea").Value
                    Dim valor = New KeyValuePair(Of String, Integer)(numcompra, linea)
                    If Convert.ToBoolean(cellSeleccion.Value) = True Then
                        If seleccionarDetaCompra.Contains(valor) = False Then
                            seleccionarDetaCompra.Add(valor)
                            calcularValores()
                        End If
                    Else
                        If seleccionarDetaCompra.Remove(valor) = False Then
                            MsgBox("No se pudo remover el item seleccionado debido a un error interno, intente nuevamente.", MsgBoxStyle.Information, "Error")
                        End If
                        calcularValores()
                    End If
            End Select
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvCompra_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCompra.SelectionChanged
        Me.seleccionarDetaCompraDatagrid()
    End Sub

    Private Sub dgvDetacompra_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvDetacompra.RowsAdded
        Dim row = dgvDetacompra.Rows(e.RowIndex).Cells("colNumdescargue").Value
        If row > 0 Then
            dgvDetacompra.Rows(e.RowIndex).ReadOnly = True
            dgvDetacompra.Rows(e.RowIndex).Cells("colSeleccionar").Value = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim config As New ConfiguracionGeneral
        Dim dao = DataContext.daoDescargues
        Dim caja As String = config.getCaja()
        Dim agencia As String = config.getAgencia()
        Dim descargue As New Descargues()
        descargue.Dgnumdes = dao.numeroDeDescargue()
        descargue.Dgcodage = agencia
        descargue.Dgcodcaj = caja
        descargue.Dgpesbrt = pesoTotal
        descargue.Dgpesntt = pesoTotal
        descargue.Dgcancom = cantidadCompras
        descargue.Dgimptcom = sumTotales
        descargue.Dgfecdes = Now
        descargue.Dgusuari = DataContext.usuarioLog.Usuario1
        descargue.Dgfecgen = txtFechaGenerar.Value
        If MessageBox.Show(Me, "¿Desea guardar el lote generado hasta la fecha seleccionada?", "Guardar", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If
        If dao.guardarLotoeDetaCompra(seleccionarDetaCompra, descargue) = True Then
            MsgBox("Se ha guardado el lote generado de forma correcta.")
            seleccionarDetaCompra.Clear()
            dgvCompra.DataSource = Nothing
            dgvDetacompra.Rows.Clear()
            txtFechaGenerar.Value = Date.Now
            txtFiltrar.Clear()
        Else
            MsgBox(dao.ErrorSms)
        End If
    End Sub
End Class

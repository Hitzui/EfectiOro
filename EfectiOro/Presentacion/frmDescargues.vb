Imports EfectiOro.Database

Public Class frmDescargues

    Private pesoT As Decimal
    Private importeT As Decimal
    'especificamos el patron de busqueda, para que busque por todos
    'al seleccionar en el combobox se filtrara segun lo seleccionado.
    Private _agencia As String = "%%"
    Private _comprasSeleccionadas As List(Of String)
    Public Property copmrasSeleccionadas() As List(Of String)
        Get
            Return _comprasSeleccionadas
        End Get
        Set(ByVal value As List(Of String))
            _comprasSeleccionadas = value
        End Set
    End Property
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cargarSucursales()
        Using ctx As New Contexto
            Try
                Dim cargar = (From a In ctx.Agencia Select a)
                Dim dt As DataTable = ServiciosBasicos.ToDataTable(cargar)
                cmbFiltrarSucursal.DataSource = dt
                cmbFiltrarSucursal.DisplayMember = dt.Columns("nomagencia").ToString
                cmbFiltrarSucursal.ValueMember = dt.Columns("codagencia").ToString
            Catch ex As Exception
                MsgBox("No se pudo cargar los datos de las sucursales debido a un error. Lea la siguiente información. " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub
    Sub calcular()
        Dim pesoTotal As Decimal = 0
        Dim importeTotal As Decimal = 0
        For Each row In dgvGenerar.Rows
            pesoTotal += row.Cells("Peso").Value
            importeTotal += row.Cells("Importe").Value
        Next
        Me.pesoT = pesoTotal
        Me.importeT = importeTotal
        lblPesototal.Text = pesoTotal.ToString("#,###,###.00")
        lblImportetotal.Text = importeTotal.ToString("#,###,###.00")
        lblCantidadcompras.Text = dgvGenerar.Rows.Count
    End Sub
    Sub generar()
        Dim dao = DataContext.daoDescargues
        Dim listarDescargues As New List(Of Compras)
        listarDescargues = dao.generarLote(txtFechaHasta.Value, _agencia)
        If listarDescargues.Count <= 0 Then
            MsgBox("No hay compras para generar el lote hasta la fecha seleccionada, intente nuevamente", MsgBoxStyle.Information, "Descargues")
            Return
        End If
        Dim listaMod = (From l In listarDescargues
                        Select New With
                               {l.Numcompra, l.Peso, l.Total,
                                .Estado = IIf(l.Codestado = 1, "Vigente",
                                              IIf(l.Codestado = 2, "Cerrada", IIf(l.Codestado = 3, "Descargada", "Anulada"))),
                                l.Fecha}).ToList()
        ComprasBindingSource.DataSource = listarDescargues
    End Sub

    Private Sub frmDescargues_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.lblTitulo.Text = "Generar Descargues - EfectiOro"
        ServiciosBasicos.colorearGrid(dgvVerlotes)
        pesoT = 0
        importeT = 0
        _comprasSeleccionadas = New List(Of String)
        cargarSucursales()
    End Sub

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        'Me.generar()
        'Me.calcular()
        If chkFiltrar.CheckState = CheckState.Checked Then
            _agencia = cmbFiltrarSucursal.SelectedValue
        Else
            _agencia = "%%"
        End If
        _comprasSeleccionadas.Clear()
        Dim dao = DataContext.daoDescargues
        Dim listarDescargues As New List(Of Compras)
        listarDescargues = dao.generarLote(txtFechaHasta.Value, _agencia)
        If listarDescargues.Count <= 0 Then
            MsgBox("No hay compras para generar el lote hasta la fecha seleccionada, intente nuevamente", MsgBoxStyle.Information, "Descargues")
            Return
        End If
        Me.ComprasBindingSource.DataSource = listarDescargues
        chekTodos.Visible = True
        lblPesototal.Text = "0.00"
        lblImportetotal.Text = "0.00"
        lblCantidadcompras.Text = "0"
    End Sub

    Private Sub btnGuardarlote_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarlote.Click
        If chkFiltrar.CheckState = CheckState.Checked Then
            _agencia = cmbFiltrarSucursal.SelectedValue
        Else
            _agencia = String.Empty
        End If
        Dim dao = DataContext.daoDescargues
        Dim daoCompra = DataContext.daoCompras
        Dim result As DialogResult = MsgBox("¿Guardar el descargue generado?", MsgBoxStyle.YesNo, "Guardar descargue")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        If _comprasSeleccionadas.Count <= 0 Then
            MsgBox("No se puede guardar el lote, no se han seleccionado compras.",
                   MsgBoxStyle.Information, "Generar lote")
            Return
        End If
        Dim config As New ConfiguracionGeneral
        Dim caja As String = config.getCaja()
        Dim agencia As String
        If String.IsNullOrEmpty(_agencia) Then
            agencia = config.getAgencia()
        Else
            agencia = _agencia
        End If
        Dim descargue As New Descargues()
        descargue.Dgnumdes = dao.numeroDeDescargue()
        descargue.Dgcodage = agencia
        descargue.Dgcodcaj = caja
        descargue.Dgpesbrt = pesoT
        descargue.Dgpesntt = pesoT
        descargue.Dgcancom = _comprasSeleccionadas.Count
        descargue.Dgimptcom = importeT
        descargue.Dgfecdes = Now
        descargue.Dgusuari = DataContext.usuarioLog.Usuario1
        descargue.Dgfecgen = txtFechaHasta.Value
        If dao.guardarLoteGenerado(descargue) Then
            For Each numcompra As String In _comprasSeleccionadas
                Dim compra As New Compras
                compra.Numcompra = numcompra
                compra.Codestado = 3 'indicado descargado
                compra.Dgnumdes = descargue.Dgnumdes
                daoCompra.actualizarCompraDescargue(compra, _agencia)
            Next
            MsgBox("Se guardó el lote actual en el sistema", MsgBoxStyle.Information, "Guardar lote")
            ComprasBindingSource.Clear()
            dgvGenerar.DataSource = ComprasBindingSource
            _comprasSeleccionadas.Clear()
            chekTodos.Visible = False
            txtFechaHasta.Value = Now
            lblPesototal.Text = "0.00"
            lblImportetotal.Text = "0.00"
            lblCantidadcompras.Text = "0"
            pesoT = 0
            importeT = 0
        Else
            MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnVerlote_Click(sender As System.Object, e As System.EventArgs) Handles btnVerlote.Click
        Dim desde As Date = txtDesde.Value
        Dim hasta As Date = txtHasta.Value
        Dim dao = DataContext.daoDescargues
        Dim verlotes As List(Of Descargues) = dao.verLotesDescargados(desde, hasta)
        If verlotes.Count <= 0 Then
            MsgBox("No hay datos a mostrar, no lotes generados en las fechas indicadas", MsgBoxStyle.Information, "Ver lotes")
        End If
        DescarguesBindingSource.Clear()
        DescarguesBindingSource.DataSource = verlotes
        dgvVerlotes.DataSource = DescarguesBindingSource
    End Sub

    Private Sub dgvVerlotes_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVerlotes.CellDoubleClick
        Dim dao = DataContext.daoDescargues
        Dim row As DataGridViewRow = dgvVerlotes.CurrentRow
        Try
            Dim numdes As Integer = row.Cells("colNumdescargue").Value
            Dim listar As List(Of Compras) = dao.verDescarguesCompras(numdes)
            panelDetalledescargue.Visible = True
            ComprasBindingSource.DataSource = listar
            ComprasDataGridView.DataSource = ComprasBindingSource
            lblLote.Text = numdes
        Catch ex As Exception
            MsgBox("Error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Descargue")
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        If panelDetalledescargue.Visible = True Then
            panelDetalledescargue.Visible = False
        End If
    End Sub

    Private Sub btnVercompras_Click(sender As System.Object, e As System.EventArgs) Handles btnVercompras.Click
        Dim dao = DataContext.daoDescargues
        Try
            Dim listar As List(Of Compras) = dao.verDescarguesCompras(txtDesdecompra.Value, txtHastacompra.Value)
            compraSource.DataSource = listar
            dgvVercompras.DataSource = compraSource
            Dim peso As Decimal = 0
            Dim importe As Decimal = 0
            For Each row As DataGridViewRow In dgvVercompras.Rows
                peso += row.Cells("colPesocompras").Value
                importe += row.Cells("colTotalcompras").Value
            Next
            lblImportecompras.Text = importe.ToString("#,###,###.##")
            lblPesocompras.Text = peso.ToString("#,###,###.##")
            lblCantcompras.Text = dgvVercompras.Rows.Count
        Catch ex As Exception
            MsgBox("Error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Descargue")
        End Try
    End Sub

    Private Sub btnBuscar_Numdescargue_Click(sender As Object, e As EventArgs) Handles btnBuscar_Numdescargue.Click
        Try
            If (String.IsNullOrEmpty(txtNumdescargue.Text)) Then
                MsgBox("Debe especificar un numero de descargue para prodecer con la busqueda.", MsgBoxStyle.Exclamation, "Buscar descargue")
                Return
            End If
            Dim num_descargue As Integer = Integer.Parse(txtNumdescargue.Text)
            Dim dao = DataContext.daoDescargues
            Dim buscar As Descargues = dao.buscarDescarguesPorNumero(num_descargue)
            If buscar Is Nothing Then
                MsgBox("No se encontraron resultados por el numero de descargue especificado.", MsgBoxStyle.Information, "Buscar descargue")
                Return
            End If
            DescarguesBindingSource.Clear()
            DescarguesBindingSource.DataSource = buscar
            dgvVerlotes.DataSource = DescarguesBindingSource
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNumdescargue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumdescargue.KeyPress
        Select Case e.KeyChar
            Case ChrW(13)
                btnBuscar_Numdescargue.Focus()
        End Select
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Dim dao = DataContext.daoDescargues
        Dim numdescargue As Integer = 0
        Dim row As DataGridViewRow
        If dgvVerlotes.Rows.Count <= 0 Then
            MsgBox("No hay datos en la grilla, filtre los rangos o busque un descargue por su número, e intente nuevamente", MsgBoxStyle.MsgBoxHelp, "Descargues")
            Return
        End If
        row = dgvVerlotes.CurrentRow
        numdescargue = row.Cells("colNumdescargue").Value
        If numdescargue <= 0 Then
            MsgBox("No se ha especificado el número de dascargue, seleccione uno en la grilla e intente nuevamente.", MsgBoxStyle.MsgBoxHelp, "Descargues")
            Return
        End If
        Dim dialogo As New frmVerDescargueCompraOpcion("Generar reporte de descargue por compra")
        Dim opcionReporte As Integer = 0
        dialogo.ShowDialog()
        If dialogo.DialogResult = DialogResult.OK Then
            opcionReporte = dialogo.Opcion
        Else
            Return
        End If
        If opcionReporte = 1 Then
            Dim lista = dao.buscarGeneralDescarguePorCompra(numdescargue)
            If lista Is Nothing Then
                MsgBox(dao.ErrorSms, MsgBoxStyle.MsgBoxHelp, "Error")
                Return
            End If
            Dim frm As New frmVerDescargueDetalleReporte("Reporte de descargue por compra")
            Dim report As New rptVerDescargueGeneralCompra
            report.SetDataSource(lista)
            frm.viewer.ReportSource = report
            frm.Show()
        Else
            Dim lista = dao.buscarDetalleDescarguePorCompra(numdescargue)
            If lista Is Nothing Then
                MsgBox(dao.ErrorSms, MsgBoxStyle.MsgBoxHelp, "Error")
                Return
            End If
            Dim frm As New frmVerDescargueDetalleReporte("Reporte de descargue por compra detallado")
            Dim report As New rtpVerDescargueDetalle
            report.SetDataSource(lista)
            frm.viewer.ReportSource = report
            frm.Show()
        End If


    End Sub

    Private Sub dgvGenerar_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgvGenerar.CellChange
        Try
            Dim opcion As Boolean = Boolean.Parse(e.Cell.Text)
            Dim row = e.Cell.Row()
            Dim rowNumcompra = row.Cells.Item(1).Value
            Dim rowPeso = row.Cells.Item("Peso").Value
            Dim rowTotal = row.Cells.Item("Total").Value
            If opcion = True Then
                If _comprasSeleccionadas.Contains(rowNumcompra) = False Then
                    _comprasSeleccionadas.Add(rowNumcompra)
                    pesoT += rowPeso
                    importeT += rowTotal
                End If
            Else
                If _comprasSeleccionadas.Count > 0 Then
                    If _comprasSeleccionadas.Contains(rowNumcompra) = True Then
                        _comprasSeleccionadas.Remove(rowNumcompra)
                        pesoT -= rowPeso
                        importeT -= rowTotal
                    End If
                End If
            End If
            lblPesototal.Text = pesoT.ToString("#,###,###.00")
            lblImportetotal.Text = importeT.ToString("#,###,###.00")
            lblCantidadcompras.Text = _comprasSeleccionadas.Count
            'Revisamos los valores ingresado
            'For Each valor As String In _comprasSeleccionadas
            '    Debug.WriteLine("Compra en la lista: " & valor)
            'Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub chekTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chekTodos.CheckedChanged
        If chekTodos.Checked Then
            If dgvGenerar.Rows.Count <= 0 Then
                MsgBox("No ha datos en la grilla", MsgBoxStyle.Information, "Seleccionar todo")
                Return
            End If
            For Each row In dgvGenerar.Rows
                row.Cells.Item("colSeleccionar").Value = "True"
                Dim rowPeso = row.Cells.Item("Peso").Value
                Dim rowTotal = row.Cells.Item("Total").Value
                Dim rowNumcompra = row.Cells.Item("Numcompra").Value
                If _comprasSeleccionadas.Contains(rowNumcompra) = False Then
                    _comprasSeleccionadas.Add(rowNumcompra)
                    pesoT += rowPeso
                    importeT += rowTotal
                End If
            Next
            lblPesototal.Text = pesoT.ToString("#,###,###.00")
            lblImportetotal.Text = importeT.ToString("#,###,###.00")
            lblCantidadcompras.Text = _comprasSeleccionadas.Count
        Else
            _comprasSeleccionadas.Clear()
            For Each row In dgvGenerar.Rows
                row.Cells.Item("colSeleccionar").Value = "False"
            Next
            pesoT = 0
            importeT = 0
        End If
        lblPesototal.Text = pesoT.ToString("#,###,###.00")
        lblImportetotal.Text = importeT.ToString("#,###,###.00")
        lblCantidadcompras.Text = _comprasSeleccionadas.Count
    End Sub


    Private Sub chkFiltrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltrar.CheckedChanged
        If chkFiltrar.CheckState = CheckState.Checked Then
            If cmbFiltrarSucursal.Enabled = False Then
                cmbFiltrarSucursal.Enabled = True
            End If
        Else
            If cmbFiltrarSucursal.Enabled = True Then
                cmbFiltrarSucursal.Enabled = False
            End If
        End If
    End Sub
End Class

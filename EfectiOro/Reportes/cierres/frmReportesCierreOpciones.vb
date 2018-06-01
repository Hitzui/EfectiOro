Imports EfectiOro.Database

Public Class frmReportesCierreOpciones

    Private Sub frmReportesCierreOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Reportes de Cierres de Precios"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Try
            Using ctx As New Contexto
                Dim buscar = (From c In ctx.Cliente Where c.Nombres.Contains(txtFiltro.Text)
                              Select c.Codcliente, c.Nombres, c.Apellidos, c.Numcedula).ToList
                dgvCliente.DataSource = buscar
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error buscar")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If dgvCliente.Rows.Count <= 0 Then
            MsgBox("NO ha filtrado un cliente para buscar datos, intente nuevamente", MsgBoxStyle.Information, "Buscar")
            Return
        End If
        Using ctx As New Contexto
            Try
                Dim row As DataGridViewRow = dgvCliente.CurrentRow
                Dim codcliente As String = row.Cells(0).Value
                Dim listaCierres As List(Of CierrePrecios) = (From cp In ctx.CierrePrecios
                                                              Where cp.Codcliente = codcliente And cp.Fecha >= txtDesde.Value And cp.Fecha <= txtHasta.Value
                                                              Select cp).ToList
                If listaCierres.Count <= 0 Then
                    MsgBox("No hay datos a mostar segun el rango de fechas indicada, intente nuevamente", MsgBoxStyle.Information, "Buscar")
                    Return
                End If
                Dim listaDetaCierres As List(Of DetaCierre) = (From cp In ctx.DetaCierre
                                                               Where cp.Fecha >= txtDesde.Value And cp.Fecha <= txtHasta.Value
                                                               Select cp).ToList
                Dim listaCliente As List(Of Cliente) = (From cli In ctx.Cliente Where cli.Codcliente = codcliente Select cli).ToList
                Dim report As New rptCierrePreciosClientesGeneral
                report.Database.Tables(0).SetDataSource(listaCliente)
                report.Database.Tables(1).SetDataSource(listaCierres)
                report.Database.Tables(2).SetDataSource(listaDetaCierres)
                frmReporteCierre.reportViewer.ReportSource = report
                frmReporteCierre.Show()
            Catch ex As Exception
                MsgBox("Error al crear el reporte, revise la siguiente información: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub
End Class

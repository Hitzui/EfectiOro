Imports EfectiOro.Database

Public Class frmReportesCierreOpciones

    ''' <summary>
    ''' Variable cliente que se seleccionó
    ''' </summary>
    Private _clienteSeleccionado As String = String.Empty

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
    Private Function validarSelecionCliente() As Boolean
        If String.IsNullOrEmpty(_clienteSeleccionado) Then
            MsgBox("Debe seleccionar un cliente para poder continuar", MsgBoxStyle.Information, "Reporte de cierres")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Using ctx As New Contexto
            If radSaldos.Checked = True Then
                Select Case cmbSaldos.SelectedIndex
                    Case 0
                        'general por cliente
                        If validarSelecionCliente() = False Then
                            Return
                        End If
                        Dim row As DataGridViewRow = dgvCliente.CurrentRow
                        Dim codcliente As String = row.Cells(0).Value
                        Dim listaCierres As List(Of CierrePrecios) = (From cp In ctx.CierrePrecios
                                                                      Where cp.Codcliente = codcliente And cp.Fecha.Date >= txtDesde.Value.Date And cp.Fecha.Date <= txtHasta.Value.Date
                                                                      Select cp).ToList
                        If listaCierres.Count <= 0 Then
                            MsgBox("No hay datos a mostar segun el rango de fechas indicada, intente nuevamente", MsgBoxStyle.Information, "Buscar")
                            Return
                        End If
                        Dim listaCliente As List(Of Cliente) = (From cli In ctx.Cliente Where cli.Codcliente = codcliente Select cli).ToList
                        Dim report As New rptCierreClienteGeneral
                        report.Database.Tables(0).SetDataSource(listaCierres)
                        report.Database.Tables(1).SetDataSource(listaCliente)
                        ParametrosCrystal(txtDesde.Value, txtHasta.Value, frm:=frmReporteCierre, rpt:=report)
                    Case 1
                        'general todos
                    Case 2
                        'detallado por cliente
                        Try
                            If validarSelecionCliente() = False Then
                                Return
                            End If
                            Dim row As DataGridViewRow = dgvCliente.CurrentRow
                            Dim codcliente As String = row.Cells(0).Value
                            Dim listaCierres As List(Of CierrePrecios) = (From cp In ctx.CierrePrecios
                                                                          Where cp.Codcliente = codcliente And cp.Fecha.Date >= txtDesde.Value.Date And cp.Fecha.Date <= txtHasta.Value.Date
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
                            ParametrosCrystal(txtDesde.Value, txtHasta.Value, frm:=frmReporteCierre, rpt:=report)
                            'frmReporteCierre.reportViewer.ReportSource = report
                            'frmReporteCierre.Show()
                        Catch ex As Exception
                            MsgBox("Error al crear el reporte, revise la siguiente información: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
                        End Try
                End Select
            End If
        End Using
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()
    End Sub

    Private Sub radSaldos_CheckedChanged(sender As Object, e As EventArgs) Handles radSaldos.CheckedChanged
        If radSaldos.Checked Then
            cmbSaldos.Visible = True
        Else
            cmbSaldos.Visible = False
        End If
    End Sub

    Private Sub dgvCliente_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.RowEnter
        Try
            Dim row As DataGridViewRow = dgvCliente.CurrentRow
            _clienteSeleccionado = row.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        _clienteSeleccionado = String.Empty
        MsgBox("Se ha quitado la selección de cliente actual", MsgBoxStyle.Information, "Reportes de Cierre")
    End Sub
End Class

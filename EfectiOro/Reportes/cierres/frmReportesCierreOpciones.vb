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
        Using ctx As New Contexto
            Try
                Dim row As DataGridViewRow = dgvCliente.CurrentRow
                Dim codcliente As String = row.Cells(0).Value
                Dim listaCierres As List(Of CierrePrecios) = (From cp In ctx.CierrePrecios
                                                              Where cp.Codcliente = codcliente And cp.Fecha.ToShortDateString >= txtDesde.Value.ToShortDateString And cp.Fecha.ToShortDateString <= txtHasta.Value.ToShortDateString
                                                              Select cp).ToList
                Dim listaDetaCierres As List(Of DetaCierre) = (From cp In ctx.DetaCierre
                                                               Where cp.Fecha.ToShortDateString >= txtDesde.Value.ToShortDateString And cp.Fecha.ToShortDateString <= txtHasta.Value.ToShortDateString
                                                               Select cp).ToList
            Catch ex As Exception

            End Try
        End Using
    End Sub
End Class

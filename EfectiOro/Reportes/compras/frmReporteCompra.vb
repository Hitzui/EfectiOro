Public Class frmReporteCompra
    Private Sub frmReporteCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Recibo de Compra - Usuario: " & DataContext.usuarioLog.Nombre
    End Sub
End Class
Public Class frmUPM
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmUMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "UPM - Precio de Oro Reservado"
    End Sub
End Class

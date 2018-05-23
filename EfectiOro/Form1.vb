Imports EfectiOro.ConfiguracionGeneral

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim valor As Decimal = CDec(TextBox1.Text)
        Label1.Text = ConvertirNumeroLetros(valor)
    End Sub
End Class

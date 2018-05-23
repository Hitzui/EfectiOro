Public Class frmPersonalizado
    Dim pos As Point = Point.Empty
    Dim mover As Boolean = False
    Protected Sub lblTitulo_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseDown
        pos = New Point(e.X, e.Y)
        mover = True
    End Sub

    Protected Sub lblTitulo_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        If mover Then
            frmPrincipal.Refresh()
            Me.Location = New Point((Me.Left + e.X - pos.X), (Me.Top + e.Y - pos.Y))
        End If
    End Sub

    Protected Sub lblTitulo_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseUp
        mover = False
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click
        frmPrincipal.Refresh()
        Me.BringToFront()
    End Sub
End Class
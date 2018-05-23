Imports EfectiOro.Database

Public Class frmRecuperarClave
    Dim user As Usuario
    Private Sub frmRecuperarClave_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Recuperar clave de acceso"
        btnClose.Visible = False
        Me.limpiar()
    End Sub
    Sub limpiar()
        For Each Control In Me.Controls
            If TypeOf Control Is GroupBox Then
                Dim grp As GroupBox = Control
                For Each texto In grp.Controls
                    If TypeOf texto Is TextBox Then
                        Dim txt As TextBox = texto
                        txt.Clear()
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim dao = DataContext.daoUsuario
            user = dao.findByUsuario(txtnombre.Text)
            txtpregunta.Text = user.Pregunta
        Catch ex As Exception
            MsgBox("No existe el usuario indicado, intente nuevamente", MsgBoxStyle.Information, "Recuperar clave")
        End Try
    End Sub

    Private Sub btnRecuperar_Click(sender As System.Object, e As System.EventArgs) Handles btnRecuperar.Click
        Try
            If user.Respuesta <> txtrespuesta.Text Then
                MsgBox("La respuesta a la pregunta de seguridad es incorrecta, intente nuevamente", MsgBoxStyle.Information, "Recuperar clave")
                txtrespuesta.SelectAll()
                Return
            End If
            txtclave.Text = user.Clave
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class

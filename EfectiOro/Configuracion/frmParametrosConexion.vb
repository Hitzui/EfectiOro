Imports System.Data.SqlClient

Public Class frmParametrosConexion
    Inherits frmPersonalizado

    Dim config As New ConfiguracionGeneral()

    Public Function probarConexion() As Boolean
        Dim con As String = ""
        If radSeguridad.Checked = True Then
            con = "Data Source = " & txtInstancia.Text & "; Initial Catalog = " & txtCatalogo.Text & "; Integrated Security = True"
        End If
        If radServer.Checked = True Then
            con = "Data Source=" & txtInstancia.Text & ";Initial Catalog=" & txtCatalogo.Text & ";Persist Security Info=True;User ID=" & txtUsuario.Text & ";Password=" & txtPassword.Text
        End If
        Dim cnn As New SqlConnection(con)
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            Return True
        Catch ex As Exception
            MsgBox("Se produjo un error al intentar conectarse debido a: " & ex.Message, MsgBoxStyle.Critical, "Probar conexion")
            Return False
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Function
    Private Sub radSeguridad_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSeguridad.CheckedChanged
        If radSeguridad.Checked = True Then
            txtUsuario.Enabled = False
            txtPassword.Enabled = False
        End If
    End Sub

    Private Sub frmParametrosConexion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Establecer parámetros de conexión"
        panelTitulo.BackColor = Color.FromName("HotTrack")
        lblTitulo.ForeColor = Color.White
        txtInstancia.Focus()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If probarConexion() Then
            MsgBox("Se ha establecido la conexión con el servidor", MsgBoxStyle.Information, "Probar conexión")
        End If
    End Sub

    Private Sub radServer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radServer.CheckedChanged
        If radServer.Checked Then
            txtUsuario.Enabled = True
            txtPassword.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If probarConexion() Then
            config.setInstancia(txtInstancia.Text)
            config.setCatalogo(txtCatalogo.Text)
            config.setUsuario(txtUsuario.Text)
            config.setPassword(txtPassword.Text)
            If radSeguridad.Checked Then
                config.setSecurity("True")
            Else
                config.setSecurity("False")
            End If
            Me.Close()
        End If
    End Sub
End Class
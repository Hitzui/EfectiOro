Imports EfectiOro.Database
Imports System.Data

Public Class frmLogin
    Private Sub txtUsuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.TextLength > 0 Then
            erp.SetError(txtUsuario, String.Empty)
        End If
    End Sub

    Private Sub txtClave_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtClave.TextChanged
        If txtClave.TextLength > 0 Then
            erp.SetError(txtClave, String.Empty)
        End If
    End Sub

    Private Sub txtUsuario_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        ServiciosBasicos.keyCharEnter(txtClave, e)
    End Sub

    Private Sub cargarSucursales()
        Using ctx As New Contexto
            Try
                Dim list_agencia = (From a In ctx.Agencia.AsEnumerable Select a)
                Dim dt As New DataTable
                dt = ServiciosBasicos.ToDataTable(list_agencia)
                cmbSucursal.DataSource = dt
                cmbSucursal.DisplayMember = dt.Columns("nomagencia").ToString
                cmbSucursal.ValueMember = dt.Columns("codagencia").ToString
            Catch ex As Exception
                MsgBox("Ocurrio un error al intentar recuperar la agencia (sucursal). Revise la siguiente información: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub
    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click, btnAceptar.Click
        If txtUsuario.TextLength <= 0 Then
            erp.SetError(txtUsuario, "Especifique un usuario para ingresar")
            txtUsuario.Focus()
            Return
        End If
        If txtClave.TextLength <= 0 Then
            erp.SetError(txtClave, "Especifique un usuario para ingresar")
            txtClave.Focus()
            Return
        End If
        Dim dao = DataContext.daoUsuario
        Try
            Dim user As Usuario = dao.findByUsuario(txtUsuario.Text)
            If user.Clave <> txtClave.Text Then
                MsgBox("Contraseña incorrecta, intente nuevamente", MsgBoxStyle.Exclamation, "Ingresar al sistema")
                txtClave.SelectAll()
                txtClave.Focus()
                Return
            End If
            DataContext.usuarioLog = user
            ServiciosBasicos.VerificarRol(user.Nivel)
            Dim config As New ConfiguracionGeneral
            config.setAgencia(cmbSucursal.SelectedValue)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox("No existe el usuario especificado, intente nuevamente" & vbCr & ex.Message, MsgBoxStyle.Exclamation, "Ingresar al sistema")
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PanelBotones.BackColor = Color.DimGray
        Me.lblTitulo.Text = "Ingresar al sistema - SunMetals Perú"
        Me.btnClose.Visible = False
        Dim ctx As New Contexto
        cargarSucursales()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click, btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lblRecuperarContraseña_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblRecuperarContraseña.LinkClicked
        frmRecuperarClave.ShowDialog()
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbSucursal.Focus()
        End Select
    End Sub

    Private Sub cmbSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSucursal.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnAceptar.Focus()
        End Select
    End Sub
End Class

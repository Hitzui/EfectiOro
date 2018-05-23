Imports EfectiOro.Database

Public Class frmUsuario

    Private auxiliar As Integer

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub cargarGrid()
        Try
            dgvUsuario.Rows.Clear()
            Dim dao = DataContext.daoUsuario
            Dim listar As List(Of Usuario) = dao.findAll()
            For Each user As Usuario In listar
                dgvUsuario.Rows.Add(user.Codoperador, user.Nombre, user.Usuario1, user.Nivel, user.Estado)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub habilitarBotones(nuevo As Boolean, guardar As Boolean, editar As Boolean, eliminar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnEditar.Enabled = editar
        btnEliminar.Enabled = eliminar
        btnCancelar.Enabled = cancelar
    End Sub
    Sub habilitarTextBox(ByVal opcion As Boolean)
        For Each Control As Control In Me.Controls
            If TypeOf Control Is Panel Then
                Dim ctrl As Panel = Control
                For Each xctr As Control In ctrl.Controls
                    If TypeOf xctr Is TextBox Then
                        Dim txt As TextBox = xctr
                        txt.Enabled = opcion
                    End If
                    If TypeOf xctr Is ComboBox Then
                        Dim cmb As ComboBox = xctr
                        cmb.Enabled = opcion
                    End If
                Next
            End If
        Next
    End Sub
    Sub limpiar()
        For Each Control As Control In Me.Controls
            If TypeOf Control Is Panel Then
                Dim ctrl As Panel = Control
                For Each xctr As Control In ctrl.Controls
                    If TypeOf xctr Is TextBox Then
                        Dim txt As TextBox = xctr
                        txt.Clear()
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub frmUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Crear Usuario - EfectiOro"
        Me.habilitarTextBox(False)
        Me.cargarGrid()
        Me.cmbEstado.SelectedIndex = 0
        Me.cmbNivel.SelectedIndex = 0
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.habilitarTextBox(True)
        Me.habilitarBotones(False, True, False, False, True)
        Me.limpiar()
        Me.auxiliar = 1
        Me.txtNombrecompleto.Focus()
        Me.dgvUsuario.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Me.habilitarTextBox(True)
        Me.habilitarBotones(False, True, False, False, True)
        dgvUsuario.Enabled = False
        Me.auxiliar = 2
        Me.txtCodoperador.Enabled = False
        Me.txtPregunta.Enabled = False
        Me.txtUsuario.Enabled = False
        Me.cmbNivel.Enabled = False
        Me.txtNombrecompleto.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Me.habilitarTextBox(False)
        Me.habilitarBotones(False, True, False, False, True)
        Me.auxiliar = 3
        Me.dgvUsuario.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.habilitarTextBox(False)
        Me.habilitarBotones(True, False, True, True, False)
        Me.dgvUsuario.Enabled = True
        Me.limpiar()
        Me.auxiliar = 0
        Me.cargarGrid()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If txtCodoperador.TextLength <= 0 Then
            erp.SetError(txtCodoperador, ServiciosBasicos.campoVacio)
            txtCodoperador.Focus()
            Return
        End If
        If txtNombrecompleto.TextLength <= 0 Then
            erp.SetError(txtNombrecompleto, campoVacio)
            txtNombrecompleto.Focus()
            Return
        End If

        Dim result As DialogResult = MsgBox("¿Guardar los datos del usuario?", MsgBoxStyle.YesNo, "Usuario")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim usuario As New Usuario
        usuario.Codoperador = txtCodoperador.Text
        usuario.Usuario1 = txtUsuario.Text
        usuario.Clave = txtClave.Text
        usuario.Nombre = txtNombrecompleto.Text
        usuario.Estado = cmbEstado.Text
        usuario.Nivel = cmbNivel.SelectedIndex
        usuario.Pregunta = txtPregunta.Text
        usuario.Respuesta = txtRespuesta.Text
        Dim dao = DataContext.daoUsuario
        Select Case auxiliar
            Case 1
                'guardar usuario
                If txtClave.Text <> txtConfirmarClave.Text Then
                    erp.SetError(txtConfirmarClave, "No coincide la confirmacion de la contraseña con la clave especificada")
                    txtConfirmarClave.Focus()
                    Return
                End If
                If txtClave.TextLength <= 0 Then
                    erp.SetError(txtClave, "Especifique una clave de acceso")
                    txtClave.Focus()
                    Return
                End If
                If txtUsuario.TextLength <= 0 Then
                    erp.SetError(txtUsuario, campoVacio)
                    txtUsuario.Focus()
                    Return
                End If
                If cmbNivel.SelectedIndex = 0 Then
                    MsgBox("Seleccione el nivel de acceso del usuario para poder continuar", MsgBoxStyle.Information, "Usuario")
                    Return
                End If
                If dao.crearUsuario(usuario) = True Then
                    MsgBox("Se guardaron los dato del usuario en el sistema", MsgBoxStyle.Information, "Usuario")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            Case 2
                'editar usuario
                If txtClave.Text <> txtConfirmarClave.Text Then
                    erp.SetError(txtConfirmarClave, "No coincide la confirmacion de la contraseña con la clave especificada")
                    txtConfirmarClave.Focus()
                    Return
                End If
                If txtClave.TextLength <= 0 Then
                    erp.SetError(txtClave, "Especifique una clave de acceso")
                    txtClave.Focus()
                    Return
                End If
                If txtUsuario.TextLength <= 0 Then
                    erp.SetError(txtUsuario, campoVacio)
                    txtUsuario.Focus()
                    Return
                End If
                If cmbNivel.SelectedIndex = 0 Then
                    MsgBox("Seleccione el nivel de acceso del usuario para poder continuar", MsgBoxStyle.Information, "Usuario")
                    Return
                End If
                Dim find As Usuario = dao.findByCodigo(txtCodoperador.Text)
                If find.Respuesta <> txtRespuesta.Text Then
                    MsgBox("La respuesta proporcionada no es valida, intente nuevamente", MsgBoxStyle.Exclamation, "Usuario")
                    Return
                End If
                If dao.actualizarDatosUsuario(usuario) = True Then
                    MsgBox("Se actualizaron los dato del usuario en el sistema", MsgBoxStyle.Information, "Usuario")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            Case 3
                'eliminar usuario
                If dao.eliminarUsuario(usuario) = True Then
                    MsgBox("Se eliminaron los dato del usuario en el sistema", MsgBoxStyle.Information, "Usuario")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
        End Select
    End Sub

    Private Sub dgvUsuario_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvUsuario.SelectionChanged
        Try
            Dim row As DataGridViewRow = dgvUsuario.CurrentRow
            txtCodoperador.Text = row.Cells(0).Value
            Dim dao = DataContext.daoUsuario
            Dim find As Usuario = dao.findByCodigo(txtCodoperador.Text)
            txtNombrecompleto.Text = find.Nombre
            txtUsuario.Text = find.Usuario1
            txtPregunta.Text = find.Pregunta
            cmbNivel.SelectedIndex = find.Nivel
        Catch ex As Exception

        End Try
    End Sub

#Region "TextBox"
    Private Sub txtCodoperador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodoperador.TextChanged
        If txtCodoperador.TextLength > 0 Then
            erp.SetError(txtCodoperador, String.Empty)
        End If
    End Sub

    Private Sub txtNombrecompleto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombrecompleto.TextChanged
        If txtNombrecompleto.TextLength > 0 Then
            erp.SetError(txtNombrecompleto, String.Empty)
        End If
    End Sub

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

    Private Sub txtConfirmarClave_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtConfirmarClave.TextChanged
        If txtConfirmarClave.TextLength > 0 Then
            erp.SetError(txtConfirmarClave, String.Empty)
        End If
    End Sub

    Private Sub txtPregunta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPregunta.TextChanged
        If txtPregunta.TextLength > 0 Then
            erp.SetError(txtPregunta, String.Empty)
        End If
    End Sub

    Private Sub txtRespuesta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRespuesta.TextChanged
        If txtRespuesta.TextLength > 0 Then
            erp.SetError(txtRespuesta, String.Empty)
        End If
    End Sub

    Private Sub txtCodoperador_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodoperador.KeyPress
        ServiciosBasicos.keyCharEnter(txtNombrecompleto, e)
    End Sub

    Private Sub txtNombrecompleto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombrecompleto.KeyPress
        ServiciosBasicos.keyCharEnter(txtUsuario, e)
    End Sub

    Private Sub txtUsuario_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        ServiciosBasicos.keyCharEnter(txtClave, e)
    End Sub

    Private Sub txtClave_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        ServiciosBasicos.keyCharEnter(txtConfirmarClave, e)
    End Sub

    Private Sub txtConfirmarClave_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmarClave.KeyPress
        ServiciosBasicos.keyCharEnter(txtPregunta, e)
    End Sub

    Private Sub txtPregunta_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPregunta.KeyPress
        ServiciosBasicos.keyCharEnter(txtRespuesta, e)
    End Sub
#End Region

End Class

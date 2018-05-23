Imports EfectiOro.Database

Public Class frmAgencia

    Dim auxiliar As Integer = 0

    Sub codigoAgencia()
        Dim daoAgencia = DataContext.daoAgencia
        lblCodigo.Text = daoAgencia.codigoAgencia()
    End Sub
    Sub cargarDatos()
        Dim daoAgencia = DataContext.daoAgencia
        Dim listar As List(Of Agencia) = daoAgencia.findAll()
        AgenciaBindingSource.DataSource = listar
    End Sub
    Private Sub frmAgencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Agencias - EfectiOro"
        habilitarTextBox(False)
        txtFiltrar.Enabled = True
        codigoAgencia()
        cargarDatos()
    End Sub

#Region "TextBox"
    Sub habilitarTextBox(opcion As Boolean)
        ServiciosBasicos.HabilitarTextBox(Me, opcion)
    End Sub
    Private Sub txtNombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtDireccion.Focus()
        End Select
    End Sub

    Private Sub txtDireccion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtDistrito.Focus()
        End Select
    End Sub

    Private Sub txtDistrito_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDistrito.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTelefono.Focus()
        End Select
    End Sub

    Private Sub txtTelefono_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                btnGuardar.Focus()
        End Select
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        If txtNombre.TextLength > 0 Then
            erp.SetError(txtNombre, String.Empty)
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDireccion.TextChanged
        If txtDireccion.TextLength > 0 Then
            erp.SetError(txtDireccion, String.Empty)
        End If
    End Sub

    Private Sub txtDistrito_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDistrito.TextChanged
        If txtDistrito.TextLength > 0 Then
            erp.SetError(txtDistrito, String.Empty)
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTelefono.TextChanged
        If txtTelefono.TextLength > 0 Then
            erp.SetError(txtTelefono, String.Empty)
        End If
    End Sub
#End Region

#Region "color en textbox"
    Private Sub txtNombre_Enter(sender As System.Object, e As System.EventArgs) Handles txtNombre.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtNombre)
    End Sub

    Private Sub txtNombre_Leave(sender As System.Object, e As System.EventArgs) Handles txtNombre.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtNombre)
    End Sub

    Private Sub txtDireccion_Enter(sender As System.Object, e As System.EventArgs) Handles txtDireccion.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtDireccion)
    End Sub

    Private Sub txtDireccion_Leave(sender As System.Object, e As System.EventArgs) Handles txtDireccion.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtDireccion)
    End Sub

    Private Sub txtDistrito_Enter(sender As System.Object, e As System.EventArgs) Handles txtDistrito.Enter
        ServiciosBasicos.colorDeFondoInfo(txtDistrito)
    End Sub

    Private Sub txtDistrito_Leave(sender As System.Object, e As System.EventArgs) Handles txtDistrito.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtDistrito)
    End Sub

    Private Sub txtTelefono_Enter(sender As System.Object, e As System.EventArgs) Handles txtTelefono.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtTelefono)
    End Sub

    Private Sub txtTelefono_Leave(sender As System.Object, e As System.EventArgs) Handles txtTelefono.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtTelefono)
    End Sub
#End Region

#Region "Botones"
    Sub habilitarBotones(ByVal nuevo As Boolean, guardar As Boolean, editar As Boolean, eliminar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnEditar.Enabled = editar
        btnEliminar.Enabled = eliminar
        btnCancelar.Enabled = cancelar
    End Sub
    Sub limpiarTextBox()
        ServiciosBasicos.Limpiar_TextBox(Me)
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If txtNombre.TextLength > 0 Then
            Dim result As DialogResult = MsgBox("¿Hay datos pendientes para guardar, seguro desea salir?", MsgBoxStyle.YesNo, "Agencia")
            If result = Windows.Forms.DialogResult.No Then
                Return
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiarTextBox()
        habilitarBotones(True, False, True, True, False)
        habilitarTextBox(False)
        cargarDatos()
        codigoAgencia()
        btnNuevo.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        auxiliar = 1
        habilitarBotones(False, True, False, False, True)
        limpiarTextBox()
        habilitarTextBox(True)
        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If txtNombre.TextLength <= 0 Then
            erp.SetError(txtNombre, ServiciosBasicos.campoVacio)
            txtNombre.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Desea aplicar los cambios hechos en la agencia seleccionada?", MsgBoxStyle.YesNo, "Agencia")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim daoAgencia = DataContext.daoAgencia
        Dim agencia As New Agencia()
        agencia.Nomagencia = txtNombre.Text
        agencia.Diragencia = txtDireccion.Text
        agencia.Disagencia = txtDistrito.Text
        agencia.Telagencia = txtTelefono.Text
        Select Case auxiliar
            Case 1 'guardar nueva agencia
                agencia.Codagencia = daoAgencia.codigoAgencia
                If daoAgencia.create(agencia) Then
                    MsgBox("Se ha ingresado la nueva agencia al sistema.", MsgBoxStyle.Information, "Guardar Agencia")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo un error al intentar guardar la agencia debido a: " & vbCr & daoAgencia.ErrorSms, _
                           MsgBoxStyle.Information, "Guardar Agencia")
                End If
            Case 2 'editar agencia
                agencia.Codagencia = lblCodigo.Text
                If daoAgencia.update(agencia) Then
                    MsgBox("Se han actualizado los datos de la agencia de forma correcta.", MsgBoxStyle.Information, "Editar Agencia")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo un error al intentar editar la agencia debido a: " & vbCr & daoAgencia.ErrorSms, _
                           MsgBoxStyle.Information, "Guardar Agencia")
                End If
            Case 3 'eliminar agencia
                agencia.Codagencia = lblCodigo.Text
                If daoAgencia.delete(agencia) Then
                    MsgBox("Se ha eliminado la agencia del sistema.", MsgBoxStyle.Information, "Eliminar Agencia")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo un error al intentar eliminar la agencia debido a: " & vbCr & daoAgencia.ErrorSms, _
                           MsgBoxStyle.Information, "Guardar Agencia")
                End If
        End Select
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        auxiliar = 2
        habilitarTextBox(True)
        habilitarBotones(False, True, False, False, True)
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        auxiliar = 3
        habilitarBotones(False, True, False, False, True)
    End Sub
#End Region

    Private Sub txtFiltrar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFiltrar.TextChanged
        Try
            Dim daoAgencia = DataContext.daoAgencia
            dgvAgencias.Rows.Clear()
            Dim listar As List(Of Agencia) = daoAgencia.filtrarPorNombre(txtFiltrar.Text)
            AgenciaBindingSource.DataSource = listar
        Catch ex As Exception
            MsgBox("No hay datos a mostrar.", MsgBoxStyle.Information, "FiltrarAgencia")
        End Try
    End Sub

    Private Sub dgvAgencias_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dgvAgencias.DoubleClick
        Try
            Dim row = dgvAgencias.CurrentRow
            lblCodigo.Text = row.Cells(0).Value
            txtNombre.Text = row.Cells(1).Value
            txtDireccion.Text = row.Cells(2).Value
            txtDistrito.Text = row.Cells(3).Value
            txtTelefono.Text = row.Cells(4).Value
            pageDetalle.Select()

        Catch ex As Exception

        End Try
    End Sub
End Class

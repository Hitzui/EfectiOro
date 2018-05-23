Imports EfectiOro.Database

Public Class frmMovimientosCaja

    Dim auxiliar As Integer
    Dim codmov As Integer

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
    Sub habilitarGrupos(ByVal datos As Boolean, detalle As Boolean)
        grupoDatos.Enabled = datos
        grupoDetalles.Enabled = detalle
    End Sub
    Sub cargarCombo()
        Dim daoRubro = DataContext.daoRubro
        'RubroBindingSource.DataSource = daoRubro
        cmbRubro.DataSource = daoRubro.findAll()
        cmbRubro.DisplayMember = "Descrubro"
        cmbRubro.ValueMember = "Codrubro"
    End Sub
    Sub cargarDatos()
        Dim daoMov = DataContext.daoMovimientosCaja
        MovcajaBindingSource.DataSource = daoMov.findAll()
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmMovimientosCaja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Movimientos de Caja - EfectiOro"
        cargarCombo()
        cargarDatos()
        Me.habilitarGrupos(False, True)
    End Sub

    Private Sub btnRubros_Click(sender As System.Object, e As System.EventArgs) Handles btnRubros.Click
        frmRubros.ShowDialog()
    End Sub

    Private Sub dgvMovimientos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvMovimientos.SelectionChanged
        Try
            codmov = 0
            Dim row = dgvMovimientos.CurrentRow
            codmov = row.Cells(0).Value
            Dim codrubro As Integer = row.Cells(2).Value
            cmbRubro.SelectedValue = codrubro
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDescripcion_Enter(sender As System.Object, e As System.EventArgs) Handles txtDescripcion.Enter
        ServiciosBasicos.colorDeFondoInfo(txtDescripcion)
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                cmbRubro.Focus()
        End Select
    End Sub

    Private Sub txtDescripcion_Leave(sender As System.Object, e As System.EventArgs) Handles txtDescripcion.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtDescripcion)
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescripcion.TextChanged
        If txtDescripcion.TextLength > 0 Then
            erp.SetError(txtDescripcion, "")
        End If
    End Sub

    Private Sub cmbRubro_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRubro.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                btnGuardar.Focus()
        End Select
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        auxiliar = 1
        Me.habilitarGrupos(True, False)
        Me.habilitarBotones(False, True, False, False, True)
        Me.limpiarTextBox()
        txtDescripcion.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If txtDescripcion.TextLength <= 0 Then
            erp.SetError(txtDescripcion, ServiciosBasicos.campoVacio)
            txtDescripcion.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Guardar los cambios hechos en el movimiento de caja?", MsgBoxStyle.YesNo, "Movimientos de caja")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim mov As New Movcaja()
        mov.Descripcion = txtDescripcion.Text
        mov.Codrubro = Convert.ToInt32(cmbRubro.SelectedValue)
        Dim daoMov = DataContext.daoMovimientosCaja
        Select Case auxiliar
            Case 1
                'guardar
                If daoMov.create(mov) Then
                    MsgBox("Se guardaron los datos del movimiento en el sistema", MsgBoxStyle.Information, "Movimientos de caja")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & daoMov.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            Case 2
                'editar
                mov.Idmov = codmov
                If daoMov.update(mov) Then
                    MsgBox("Se actualizaron los datos del movimiento en el sistema", MsgBoxStyle.Information, "Movimientos de caja")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & daoMov.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            Case 3
                'eliminar
                mov.Idmov = codmov
                If daoMov.delete(mov) Then
                    MsgBox("Se eliminar los datos del movimiento en el sistema", MsgBoxStyle.Information, "Movimientos de caja")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & daoMov.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
        End Select
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        auxiliar = 2
        Me.habilitarGrupos(True, False)
        Me.habilitarBotones(False, True, False, False, True)
        txtDescripcion.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        auxiliar = 3
        Me.habilitarGrupos(False, False)
        Me.habilitarBotones(False, True, False, False, True)
        btnGuardar.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.habilitarGrupos(False, True)
        Me.habilitarBotones(True, False, True, True, False)
        cargarCombo()
        cargarDatos()
    End Sub
End Class

Public Class frmRubros

    Dim auxiliar As Integer
    Dim codigo As Integer

    Sub cargarDatos()
        ServiciosBasicos.colorearGrid(dgvRubro)
        Dim dao = DataContext.daoRubro
        RubroBindingSource.DataSource = dao.findAll()
    End Sub

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
        grupoDetalle.Enabled = detalle
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmRubros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Rubros - Cajas"
        Me.cargarDatos()
    End Sub

#Region "TextBox"
    Private Sub DescrubroTextBox_Enter(sender As System.Object, e As System.EventArgs) Handles DescrubroTextBox.Enter
        ServiciosBasicos.colorDeFondoInfo(DescrubroTextBox)
    End Sub

    Private Sub DescrubroTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles DescrubroTextBox.Leave
        ServiciosBasicos.colorDeFondoBlanco(DescrubroTextBox)
    End Sub

    Private Sub DescrubroTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DescrubroTextBox.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                radEntrada.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub DescrubroTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DescrubroTextBox.TextChanged
        If DescrubroTextBox.TextLength > 0 Then
            erp.SetError(DescrubroTextBox, "")
        End If
    End Sub
#End Region

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        auxiliar = 1
        Me.habilitarBotones(False, True, False, False, True)
        Me.limpiarTextBox()
        Me.habilitarGrupos(True, False)
        Me.DescrubroTextBox.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        auxiliar = 2
        Me.habilitarBotones(False, True, False, False, True)
        Me.habilitarGrupos(True, False)
        Me.DescrubroTextBox.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        auxiliar = 3
        Me.habilitarBotones(False, True, False, False, True)
        Me.habilitarGrupos(False, False)
        Me.DescrubroTextBox.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.habilitarBotones(True, False, True, True, False)
        Me.habilitarGrupos(False, True)
        Me.cargarDatos()
    End Sub

    Private Sub dgvRubro_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvRubro.SelectionChanged
        Try
            Dim row = dgvRubro.CurrentRow
            codigo = row.Cells(0).Value
            Dim val As Integer = row.Cells(2).Value
            If val = 1 Then
                radEntrada.Checked = True
            Else
                radSalida.Checked = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If DescrubroTextBox.TextLength <= 0 Then
            erp.SetError(DescrubroTextBox, ServiciosBasicos.campoVacio)
            DescrubroTextBox.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Guardar los cambios hechos en el rubro seleccionado?", MsgBoxStyle.YesNo, "Rubro")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim rubro As New Database.Rubro()
        rubro.Descrubro = DescrubroTextBox.Text
        If radEntrada.Checked Then
            rubro.Naturaleza = 1
        ElseIf radSalida.Checked Then
            rubro.Naturaleza = 0
        Else
            MsgBox("Seleccione la naturaleza del rubro para continuar", MsgBoxStyle.Information, "Rubro")
            Return
        End If
        Dim dao = DataContext.daoRubro
        Select Case auxiliar
            Case 1 'guardar rubro
                If dao.create(rubro) Then
                    MsgBox("Se guardo el rubro en el sistema", MsgBoxStyle.Information, "Rubro")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            Case 2 'editar rubro
                rubro.Codrubro = codigo
                If dao.update(rubro) Then
                    MsgBox("Se actualizaron los datos del rubro en el sistema", MsgBoxStyle.Information, "Rubro")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            Case 3 'eliminar rubro
                rubro.Codrubro = codigo
                If dao.delete(rubro) Then
                    MsgBox("Se eliminaro los datos del rubro del sistema", MsgBoxStyle.Information, "Rubro")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
        End Select
    End Sub
End Class

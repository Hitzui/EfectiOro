Public Class frmCaja

    Dim auxiliar As Integer

    Sub codigoCaja()
        Dim dao = DataContext.daoCaja
        CodcajaTextBox.Text = dao.codigoCaja()
    End Sub
    Sub cargarDatos()
        dgvCajas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Dim dao = DataContext.daoCaja
        CajaBindingSource.DataSource = dao.findAll()
    End Sub
    Sub habilitarTextBox(opcion As Boolean)
        ServiciosBasicos.HabilitarTextBox(Me, opcion)
    End Sub
    Sub habilitarBotones(ByVal nuevo As Boolean, guardar As Boolean, editar As Boolean, eliminar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnEditar.Enabled = editar
        btnEliminar.Enabled = eliminar
        btnCancelar.Enabled = cancelar
    End Sub
    Sub limpiarTextBox()
        DescripcionTextBox.Clear()
    End Sub
    Private Sub frmCaja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.habilitarTextBox(False)
        lblTitulo.Text = "Cajas - EfectiOro"
        codigoCaja()
        cargarDatos()
    End Sub

#Region "TextBox"
    Private Sub CodcajaTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CodcajaTextBox.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                'DescripcionTextBox.Focus()
        End Select
    End Sub

    Private Sub DescripcionTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTextBox.KeyPress
        ServiciosBasicos.keyCharEnter(btnGuardar, e)
    End Sub

    Private Sub CodcajaTextBox_Enter(sender As System.Object, e As System.EventArgs) Handles CodcajaTextBox.Enter
        ServiciosBasicos.colorDeFondoInfo(CodcajaTextBox)
    End Sub

    Private Sub DescripcionTextBox_Enter(sender As System.Object, e As System.EventArgs) Handles DescripcionTextBox.Enter
        ServiciosBasicos.colorDeFondoInfo(DescripcionTextBox)
    End Sub

    Private Sub CodcajaTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles CodcajaTextBox.Leave
        ServiciosBasicos.colorDeFondoBlanco(CodcajaTextBox)
    End Sub

    Private Sub DescripcionTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles DescripcionTextBox.Leave
        ServiciosBasicos.colorDeFondoBlanco(DescripcionTextBox)
    End Sub

    Private Sub CodcajaTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CodcajaTextBox.TextChanged
        If CodcajaTextBox.TextLength > 0 Then
            erp.SetError(CodcajaTextBox, "")
        End If
    End Sub

    Private Sub DescripcionTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DescripcionTextBox.TextChanged
        If DescripcionTextBox.TextLength > 0 Then
            erp.SetError(DescripcionTextBox, "")
        End If
    End Sub
#End Region

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        auxiliar = 1
        dgvCajas.Enabled = False
        Me.habilitarBotones(False, True, False, False, True)
        Me.habilitarTextBox(True)
        Me.limpiarTextBox()
        Me.codigoCaja()
        Me.DescripcionTextBox.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        auxiliar = 2
        Me.habilitarTextBox(True)
        Me.habilitarBotones(False, True, False, False, True)
        dgvCajas.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        auxiliar = 3
        Me.habilitarTextBox(True)
        Me.habilitarBotones(False, True, False, False, True)
        dgvCajas.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.habilitarBotones(True, False, True, True, False)
        Me.habilitarTextBox(False)
        codigoCaja()
        dgvCajas.Enabled = True
        cargarDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If DescripcionTextBox.TextLength <= 0 Then
            erp.SetError(DescripcionTextBox, ServiciosBasicos.campoVacio)
            DescripcionTextBox.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Desea guardar la información de la caja seleccionada en el sistema?", MsgBoxStyle.YesNo, "Caja")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim dao = DataContext.daoCaja
        Dim caja As New Database.Caja
        caja.Descripcion = DescripcionTextBox.Text
        Select Case auxiliar
            Case 1 'guardar caja
                caja.Codcaja = dao.codigoCaja()
                If dao.create(caja) Then
                    MsgBox("Se ha creado la caja de form correcta", MsgBoxStyle.Information, "Caja")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Caja")
                End If
            Case 2 'editar caja
                caja.Codcaja = CodcajaTextBox.Text
                If dao.update(caja) Then
                    MsgBox("Se han actualizado los datos de la caja de form correcta", MsgBoxStyle.Information, "Caja")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Caja")
                End If
            Case 3 'eliminar caja
                caja.Codcaja = CodcajaTextBox.Text
                If dao.delete(caja) Then
                    MsgBox("Se han eliminado los datos de la caja de form correcta", MsgBoxStyle.Information, "Caja")
                    btnCancelar_Click(sender, e)
                Else
                    MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Caja")
                End If
        End Select
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DescripcionTextBox_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DescripcionTextBox.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                e.Handled = True
                btnGuardar.Focus()
        End Select
    End Sub
End Class

Imports EfectiOro.Database

Public Class frmUPM
    Private Const _tituloMensaje As String = "UPM"
    Private aux As Integer = 1

    Private Sub habilitarCampos(opcion As Boolean)
        txtCodigoUPM.Enabled = opcion
        txtOnzas.Enabled = opcion
        txtPrecio.Enabled = opcion
        txtFecha.Enabled = opcion
    End Sub
    Private Sub habilitarBotones(nuevo As Boolean, guardar As Boolean, editar As Boolean, eliminar As Boolean, cancelar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnEditar.Enabled = editar
        btnEliminar.Enabled = eliminar
        btnCancelar.Enabled = cancelar
    End Sub
    Private Sub cargarDatos()
        Using ctx As New Contexto
            Try
                Dim bs As New BindingSource()
                Dim datosUpm = (From upm In ctx.UPM Where upm.Status = True Select upm).ToList
                bs.DataSource = datosUpm
                sourceUPM.DataSource = bs
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, _tituloMensaje)
            End Try
        End Using
    End Sub
    Private Sub LimpiarCampos()
        txtCodigoUPM.Clear()
        txtPrecio.Clear()
        txtOnzas.Clear()
        txtFecha.Value = Now
        txtCodigoUPM.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmUMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "UPM - Precio de Oro Reservado"
        LimpiarCampos()
        habilitarBotones(True, False, True, True, False)
        cargarDatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habilitarCampos(True)
        habilitarBotones(False, True, False, False, True)
        LimpiarCampos()
        aux = 1
        dgvUpmDatos.Enabled = False
        dgvUpmDatos.ClearSelection()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        habilitarCampos(True)
        habilitarBotones(False, True, False, False, True)
        LimpiarCampos()
        dgvUpmDatos.Enabled = True
        aux = 2
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        habilitarCampos(False)
        habilitarBotones(False, True, False, False, True)
        LimpiarCampos()
        dgvUpmDatos.Enabled = True
        aux = 3
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        habilitarCampos(False)
        habilitarBotones(True, False, True, True, False)
        LimpiarCampos()
        cargarDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult = MsgBox("¿Seguro desea guardar los cambios?", MsgBoxStyle.YesNo, _tituloMensaje)
        If result = DialogResult.No Then
            Return
        End If
        Using ctx As New Contexto
            Try
                Dim codigo As String = txtCodigoUPM.Text
                Dim precio As Decimal = Decimal.Zero
                Dim onzas As Decimal = Decimal.Zero
                Dim fecha As Date = txtFecha.Value
                If txtPrecio.Text.Trim.Length <= 0 Then
                    erp.SetError(txtPrecio, "Establezca un valor para continuar")
                    Return
                Else
                    precio = Convert.ToDecimal(txtPrecio.Text)
                End If
                If txtOnzas.Text.Trim.Length <= 0 Then
                    erp.SetError(txtOnzas, "Establezca un valor para continuar")
                    Return
                Else
                    onzas = Convert.ToDecimal(txtOnzas.Text)
                End If
                Select Case aux
                    Case 1
                        'guardar datos
                        Dim _upm As New Upm With {.Codigo = codigo, .Onzas = onzas, .Precio = precio, .Fecha = txtFecha.Value, .Status = True}
                        ctx.UPM.InsertOnSubmit(_upm)
                        ctx.SubmitChanges()
                        MsgBox("Se han guardado los datos del UPM, de forma correcta", MsgBoxStyle.Information, _tituloMensaje)
                        btnCancelar_Click(sender, e)
                    Case 2
                        'editar datos
                        Dim row As DataGridViewRow = dgvUpmDatos.CurrentRow
                        Dim findUpm As Upm = (From upm In ctx.UPM Where upm.Codupm = Convert.ToInt32(row.Cells("colCodupm").Value) Select upm).Single
                        findUpm.Precio = precio
                        findUpm.Onzas = onzas
                        findUpm.Codigo = codigo
                        ctx.SubmitChanges()
                        MsgBox("Se han guardado los datos del UPM, de forma correcta", MsgBoxStyle.Information, _tituloMensaje)
                        btnCancelar_Click(sender, e)
                    Case 3
                        'eliminar datos
                        Dim row As DataGridViewRow = dgvUpmDatos.CurrentRow
                        Dim findUpm As Upm = (From upm In ctx.UPM Where upm.Codupm = Convert.ToInt32(row.Cells("colCodupm").Value) Select upm).Single
                        ctx.UPM.DeleteOnSubmit(findUpm)
                        ctx.SubmitChanges()
                        MsgBox("Se han eliminado los datos del UPM, de forma correcta", MsgBoxStyle.Information, _tituloMensaje)
                        btnCancelar_Click(sender, e)
                End Select
            Catch ex As Exception
                MsgBox("Se produjo un error al intentar guardar: " & ex.Message, MsgBoxStyle.Critical, _tituloMensaje)
            End Try
        End Using
    End Sub

    Private Sub txtCodigoUPM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoUPM.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtOnzas.Focus()
        End Select
    End Sub

    Private Sub txtOnzas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOnzas.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtPrecio.Focus()
        End Select
    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtFecha.Focus()
        End Select
    End Sub

    Private Sub txtOnzas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnzas.KeyPress
        NumeroDec(e, txtOnzas)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        NumeroDec(e, txtPrecio)
    End Sub

    Private Sub txtOnzas_TextChanged(sender As Object, e As EventArgs) Handles txtOnzas.TextChanged
        erp.SetError(txtOnzas, "")
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        erp.SetError(txtPrecio, "")
    End Sub

    Private Sub dgvUpmDatos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUpmDatos.RowEnter
        Try
            Dim row As DataGridViewRow = dgvUpmDatos.CurrentRow
            txtCodigoUPM.Text = row.Cells("colCodigo").Value
            txtPrecio.Text = row.Cells("colPrecio").Value
            txtOnzas.Text = row.Cells("colOnzas").Value
            txtFecha.Value = row.Cells("colFecha").Value
        Catch ex As Exception
        End Try
    End Sub
End Class

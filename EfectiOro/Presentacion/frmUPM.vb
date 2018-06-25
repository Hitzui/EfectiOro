Imports EfectiOro.Database

Public Class frmUPM

    Private Const _tituloMensaje As String = "UPM"
    Private aux As Integer = 1
    Private listaCierresSeleccionados As List(Of CierrePrecios)
    Private onzas_cierres As Decimal = Decimal.Zero
    Private onzas_upm As Decimal = Decimal.Zero

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        listaCierresSeleccionados = New List(Of CierrePrecios)
    End Sub
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
                Dim bsCierres As New BindingSource
                Dim datosCierre = (From cierre In ctx.CierrePrecios Where cierre.Status = True Select cierre).ToList
                bsCierres.DataSource = datosCierre
                sourcecierre.DataSource = bsCierres
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
        Select Case tabUPM.SelectedIndex
            Case 0
                habilitarCampos(True)
                habilitarBotones(False, True, False, False, True)
                LimpiarCampos()
                dgvUpmDatos.Enabled = False
                dgvUpmDatos.ClearSelection()
            Case 1
                dgvCierres.Enabled = True
                habilitarBotones(False, True, False, False, True)
                Using ctx As New Contexto
                    Try
                        Dim rowUpm As DataGridViewRow = dgvUPM.CurrentRow
                        Dim codupm As Integer = Convert.ToInt32(rowUpm.Cells("colCodupmRegistro").Value)
                        Dim findDetaUpm = (From deta In ctx.Detaupm Where deta.Codupm = codupm Select deta).ToList
                        If findDetaUpm.Count > 0 Then
                            MsgBox("La seleccion de UPM ya tiene cierre de precios establecidos, si desea editar eliga la opción indicada.", MsgBoxStyle.Information, _tituloMensaje)
                            btnCancelar_Click(sender, e)
                            Return
                        End If
                        dgvUPM.Enabled = False
                        habilitarBotones(False, True, False, False, True)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, _tituloMensaje)
                    End Try
                End Using
        End Select
        aux = 1
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Select Case tabUPM.SelectedIndex
            Case 0
                habilitarCampos(True)
                habilitarBotones(False, True, False, False, True)
                LimpiarCampos()
                dgvUpmDatos.Enabled = True
            Case 1
                dgvCierres.Enabled = True
                Using ctx As New Contexto
                    Try
                        Dim rowUpm As DataGridViewRow = dgvUPM.CurrentRow
                        Dim codupm As Integer = Convert.ToInt32(rowUpm.Cells("colCodupmRegistro").Value)
                        Dim findDetaUpm = (From deta In ctx.Detaupm Where deta.Codupm = codupm Select deta).ToList
                        For Each dato As Detaupm In findDetaUpm
                            For Each row As DataGridViewRow In dgvCierres.Rows
                                If dato.Codcierre = Convert.ToInt32(row.Cells("colCodCierre").Value) Then
                                    row.Cells("colSeleccionar").Value = True
                                End If
                            Next
                        Next
                        dgvUPM.Enabled = False
                        habilitarBotones(False, True, False, False, True)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, _tituloMensaje)
                    End Try
                End Using
        End Select
        aux = 2
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Select Case tabUPM.SelectedIndex
            Case 0
                habilitarCampos(False)
                habilitarBotones(False, True, False, False, True)
                LimpiarCampos()
                dgvUpmDatos.Enabled = True
            Case 1
                dgvCierres.Enabled = False
                Using ctx As New Contexto
                    Try
                        Dim rowUpm As DataGridViewRow = dgvUPM.CurrentRow
                        Dim codupm As Integer = Convert.ToInt32(rowUpm.Cells("colCodupmRegistro").Value)
                        Dim findDetaUpm = (From deta In ctx.Detaupm Where deta.Codupm = codupm Select deta).ToList
                        For Each dato As Detaupm In findDetaUpm
                            For Each row As DataGridViewRow In dgvCierres.Rows
                                If dato.Codcierre = Convert.ToInt32(row.Cells("colCodCierre").Value) Then
                                    row.Cells("colSeleccionar").Value = True
                                End If
                            Next
                        Next
                        dgvUPM.Enabled = False
                        habilitarBotones(False, True, False, False, True)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, _tituloMensaje)
                    End Try
                End Using
        End Select
        aux = 3
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Select Case tabUPM.SelectedIndex
            Case 0
                habilitarCampos(False)
                habilitarBotones(True, False, True, True, False)
                LimpiarCampos()
            Case 1
                dgvUPM.Enabled = True
                dgvCierres.Enabled = False
                lblOnzasUPM.Text = "(0.00)"
                lblOnzasCierre.Text = "(0.00)"
                onzas_cierres = Decimal.Zero
                onzas_upm = Decimal.Zero
                habilitarBotones(True, False, True, True, False)
        End Select
        cargarDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult = MsgBox("¿Seguro desea guardar los cambios?", MsgBoxStyle.YesNo, _tituloMensaje)
        If result = DialogResult.No Then
            Return
        End If
        Using ctx As New Contexto
            Try
                Select Case tabUPM.SelectedIndex
                    Case 0
                        'registro de datos
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
                    Case 1
                        'seleccion de datos upm y cierre de precio
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

    Private Sub tabUPM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabUPM.SelectedIndexChanged
        cargarDatos()
    End Sub

    Private Sub dgvCierres_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCierres.CellValueChanged
        Using ctx As New Contexto
            Try
                Dim rowUpm As DataGridViewRow = dgvUPM.CurrentRow
                Dim onzasUPM As Decimal = Convert.ToDecimal(rowUpm.Cells("OnzasDataGridViewTextBoxColumn").Value)
                If dgvCierres.Columns(e.ColumnIndex).Name = "colSeleccionar" Then
                    Dim row As DataGridViewRow = dgvCierres.Rows(e.RowIndex)
                    Dim cellSeleccion As DataGridViewCheckBoxCell = row.Cells("colSeleccionar")
                    Dim codigo As Integer = Convert.ToInt32(row.Cells("colCodcierre").Value)
                    Dim buscarCierre As CierrePrecios = (From cierre In ctx.CierrePrecios Where cierre.CodCierre = codigo Select cierre).Single
                    If Convert.ToBoolean(cellSeleccion.Value) = True Then
                        onzas_cierres = Decimal.Add(onzas_cierres, buscarCierre.OnzasFinas)
                        listaCierresSeleccionados.Add(buscarCierre)
                    Else
                        Dim find = listaCierresSeleccionados.Find(Function(d) d.CodCierre = buscarCierre.CodCierre)
                        listaCierresSeleccionados.Remove(find)
                        onzas_cierres = Decimal.Subtract(onzas_cierres, buscarCierre.OnzasFinas)
                    End If
                    lblOnzasCierre.Text = onzas_cierres.ToString("#,##0.000")
                End If
                If onzasUPM < onzas_cierres Then
                    MsgBox("Las onzas reservadas a UPM son menores a las onzas seleccionadas", MsgBoxStyle.Information, _tituloMensaje)
                End If
            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Warning")
            End Try
        End Using
    End Sub

    Private Sub dgvUPM_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUPM.SelectionChanged
        Try
            Dim row As DataGridViewRow = dgvUPM.CurrentRow
            Dim onzasUPM As Decimal = Convert.ToDecimal(row.Cells("OnzasDataGridViewTextBoxColumn").Value)
            lblOnzasUPM.Text = onzasUPM.ToString("#,##0.000")
        Catch ex As Exception

        End Try
    End Sub
End Class

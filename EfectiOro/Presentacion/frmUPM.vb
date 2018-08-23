Imports EfectiOro.Database

Public Class frmUPM

    Private Const _tituloMensaje As String = "Formulario UPM"
    Private Const DobleZero As String = "0.00"
    Private aux As Integer = 1
    Private listaUPMSeleccionados As List(Of Upm)
    Private onzas_cierres As Decimal = Decimal.Zero
    Private onzas_upm As Decimal = Decimal.Zero
    Private bsCierres As New BindingSource

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        listaUPMSeleccionados = New List(Of Upm)
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click, btnSalir2.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Select Case tabUPM.SelectedIndex
            Case 0
                habilitarCampos(True)
                habilitarBotones(False, True, False, False, True)
                dgvUpmDatos.Enabled = False
                dgvUpmDatos.ClearSelection()
                LimpiarCampos()
                chkStatus.Checked = True
                chkStatus.Enabled = False
            Case 1

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
                chkStatus.Enabled = True
            Case 1

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
                chkStatus.Enabled = False
            Case 1

        End Select
        aux = 3
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        habilitarCampos(False)
        habilitarBotones(True, False, True, True, False)
        LimpiarCampos()
        chkStatus.Enabled = False
        onzas_cierres = Decimal.Zero
        onzas_upm = Decimal.Zero
        habilitarBotones(True, False, True, True, False)
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
#Region "ingreso y modificaciones de UPM"
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
                                Dim _upm As New Upm With {.Codigo = codigo, .Onzas = onzas, .Saldo = onzas, .Precio = precio, .Fecha = txtFecha.Value, .Status = True}
                                ctx.UPM.InsertOnSubmit(_upm)
                                ctx.SubmitChanges()
                                MsgBox("Se han guardado los datos del UPM, de forma correcta", MsgBoxStyle.Information, _tituloMensaje)
                                btnCancelar_Click(sender, e)
                            Case 2
                                'editar datos
                                Dim row As DataGridViewRow = dgvUpmDatos.CurrentRow
                                Dim findUpm As Upm = (From upm In ctx.UPM Where upm.Codupm = Convert.ToInt32(row.Cells("colCodupm").Value) Select upm).Single
                                Dim detaupm = (From deta In ctx.Detaupm Where deta.Codupm = Convert.ToInt32(row.Cells("colCodupm").Value) Select deta).ToList
                                If detaupm.Count > 0 Then
                                    Dim deta_onzas As Decimal = detaupm.Sum(Function(d) d.Onzas)
                                    If onzas < deta_onzas Then
                                        MsgBox("No puede editar el UPM, ya que las onzas establecidas son menores respecto a los cierres viculados a este UPM", MsgBoxStyle.Information, _tituloMensaje)
                                        Return
                                    End If
                                End If
                                findUpm.Precio = precio
                                findUpm.Onzas = onzas
                                findUpm.Codigo = codigo
                                findUpm.Status = chkStatus.Checked
                                ctx.SubmitChanges()
                                MsgBox("Se han guardado los datos del UPM, de forma correcta", MsgBoxStyle.Information, _tituloMensaje)
                                btnCancelar_Click(sender, e)
                            Case 3
                                'eliminar datos
                                Dim row As DataGridViewRow = dgvUpmDatos.CurrentRow
                                Dim findUpm As Upm = (From upm In ctx.UPM Where upm.Codupm = Convert.ToInt32(row.Cells("colCodupm").Value) Select upm).Single
                                Dim detaupm = (From deta In ctx.Detaupm Where deta.Codupm = Convert.ToInt32(row.Cells("colCodupm").Value) Select deta).ToList
                                If detaupm.Count > 0 Then
                                    MsgBox("No puede elminar el UPM actual ya que esta vinculado con cierre de precios", MsgBoxStyle.Information, _tituloMensaje)
                                    Return
                                End If
                                ctx.UPM.DeleteOnSubmit(findUpm)
                                ctx.SubmitChanges()
                                MsgBox("Se han eliminado los datos del UPM, de forma correcta", MsgBoxStyle.Information, _tituloMensaje)
                                btnCancelar_Click(sender, e)
                        End Select
#End Region
#Region "Tab panel 2"
                    Case 1

#End Region
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


    Private Sub tabUPM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabUPM.SelectedIndexChanged
        cargarDatos()
    End Sub

    Private Sub dgvUpmDatos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUpmDatos.SelectionChanged
        Try
            Dim row As DataGridViewRow = dgvUpmDatos.CurrentRow
            txtCodigoUPM.Text = row.Cells("colCodigo").Value
            txtPrecio.Text = row.Cells("colPrecio").Value
            txtOnzas.Text = row.Cells("colOnzas").Value
            txtFecha.Value = row.Cells("colFecha").Value
            chkStatus.Checked = Convert.ToBoolean(row.Cells("colStatus").Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCalcularOnzasCompra_Click(sender As Object, e As EventArgs) Handles btnCalcularOnzasCompra.Click
        Using ctx As New Contexto
            Try
                Dim onzasCompras As Decimal = (From dc In ctx.Det_compra Where dc.Fecha >= txtDesde.Value And dc.Fecha <= txtHasta.Value And dc.Numdescargue = 0
                                               Group dc By dc.Numcompra, dc.Codagencia, dc.Fecha Into Group
                                               Select New With {.Onzas = Group.Sum(Function(c) c.Peso * Convert.ToDecimal(c.Kilate) / 24 / 31.1035)}).Sum(Function(c) c.Onzas)
                Dim s As String = Convert.ToString(Decimal.Round(onzasCompras, 3))
                lblSumOnzasCompras.Text = s
            Catch ex As Exception
                lblSumOnzasCompras.Text = DobleZero
            End Try
        End Using
    End Sub

    Private Sub btnCalcularOnzasCierres_Click(sender As Object, e As EventArgs) Handles btnCalcularOnzasCierres.Click
        Using ctx As New Contexto
            Try
                Dim onzasCierres As Decimal = (From c In ctx.CierrePrecios Where c.Status = True Select c.SaldoOnzas).Sum
                Dim s As String = Convert.ToString(Decimal.Round(onzasCierres, 3))
                lblOnzasCierres.Text = s
            Catch ex As Exception
                lblOnzasCierres.Text = DobleZero
            End Try
        End Using
    End Sub

    Private Sub btnCalcularOnzasUPM_Click(sender As Object, e As EventArgs) Handles btnCalcularOnzasUPM.Click
        Using ctx As New Contexto
            Try
                Dim onzasUPM As Decimal = (From u In ctx.UPM Where u.Status = True Select u.Saldo).Sum
                Dim s As String = Convert.ToString(Decimal.Round(onzasUPM, 3))
                lblOnzasUPM.Text = s
            Catch ex As Exception
                lblOnzasUPM.Text = DobleZero
            End Try
        End Using
    End Sub

    Private Sub btnOnzas_Click(sender As Object, e As EventArgs) Handles btnOnzas.Click
        Using ctx As New Contexto
            Try
                Dim onzasCompras As Decimal = (From dc In ctx.Det_compra Where dc.Fecha >= txtDesde.Value And dc.Fecha <= txtHasta.Value And dc.Numdescargue = 0
                                               Group dc By dc.Numcompra, dc.Codagencia, dc.Fecha Into Group
                                               Select New With {.Onzas = Group.Sum(Function(c) c.Peso * Convert.ToDecimal(c.Kilate) / 24 / 31.1035)}).Sum(Function(c) c.Onzas)
                Dim onzasCierres As Decimal = (From c In ctx.CierrePrecios Where c.Status = True Select c.SaldoOnzas).Sum
                Dim onzasUPM As Decimal = (From u In ctx.UPM Where u.Status = True Select u.Saldo).Sum
                Dim dif As Decimal = onzasUPM - onzasCompras - onzasCierres
                lblOnzas.Text = dif.ToString("#,##0.000")
            Catch ex As Exception
                MsgBox("No hay datos de onzas para las compras segun la fecha seleccionada, intente con un rango de fecha distinto", MsgBoxStyle.Information, "Onzas")
                lblOnzas.Text = "0.0"
            End Try
        End Using
    End Sub

    Private Sub txtMontoEstimado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoEstimado.KeyPress
        NumeroDec(e, txtMontoEstimado)
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Using ctx As New Contexto
            Try
                Dim filtrar = (From upm In ctx.UPM Where upm.Fecha.Date <= txtFiltrarFecha.Value.Date And upm.Status = True Select upm).ToList
                sourceUPM.DataSource = filtrar
                dgvUpm.DataSource = sourceUPM
            Catch ex As Exception
                MsgBox("NO hay datos en la fecha especificada, por favor intente con otro rango de fechas", MsgBoxStyle.Information, "Filtrar")
            End Try
        End Using
    End Sub

    Private Sub btnGuardarDetaUPM_Click(sender As Object, e As EventArgs) Handles btnGuardarDetaUPM.Click
        Using ctx As New Contexto
            Try
                Dim onzasEstimadas As Decimal = Decimal.Zero
                If txtMontoEstimado.Text.Trim.Length <= 0 Then
                    MsgBox("Debe especificar las onzas estimadas para continuar", MsgBoxStyle.Information, _tituloMensaje)
                    Return
                Else
                    onzasEstimadas = Convert.ToDecimal(txtMontoEstimado.Text)
                End If
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub dgvUpm_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUpm.CellEndEdit
        Try
            Dim seleccion As Boolean
            Dim x_upm As Upm
            If e.ColumnIndex = 0 Then
                seleccion = dgvUpm.Item(e.ColumnIndex, e.RowIndex).Value
                x_upm = sourceUPM.Item(e.RowIndex)
                If seleccion = True Then
                    If Not listaUPMSeleccionados.Contains(x_upm) Then
                        listaUPMSeleccionados.Add(x_upm)
                    End If
                Else
                    If listaUPMSeleccionados.Contains(x_upm) Then
                        listaUPMSeleccionados.Remove(x_upm)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

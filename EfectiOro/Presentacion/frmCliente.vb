
Imports EfectiOro.Database

Public Class frmCliente

    Const vacio As String = "No puede estar vacio este campo"
    Dim auxiliar As Integer = 0
    Dim picaActual As Integer

    Sub filtrarCliente()
        Try
            dgvFiltrar.Size = New Point(410, 150)
            dgvFiltrar.Rows.Clear()
            Dim daoCliente = DataContext.daoCliente
            Dim lista = daoCliente.filtrarPorNombre(txtCodCliente.Text)
            For Each dato In lista
                dgvFiltrar.Rows.Add(dato.Codcliente, dato.Nombres, dato.Apellidos)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Function validarFechaCedula() As Boolean
        Dim añoEmision = Me.txtFechaEmision.Value.Year
        Dim añoVencimiento = Me.txtFechaVencimiento.Value.Year
        Dim diferencias = añoVencimiento - añoEmision
        If diferencias <= 5 Then
            erp.SetError(Me.txtFechaVencimiento, "Fecha de vencimiento incorrecta")
            Me.txtFechaVencimiento.Focus()
            Return False
        Else
            erp.SetError(Me.txtFechaVencimiento, String.Empty)
            Return True
        End If
    End Function
    Sub codigoCliente()
        Dim daoCliente = DataContext.daoCliente
        txtCodCliente.Text = daoCliente.codCliente()
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codigoCliente()
        lblTitulo.Text = "Catalogo de Clientes - EfectiOro"
        lblTitulo.ForeColor = Color.White
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnContinuar1_Click(sender As Object, e As EventArgs) Handles btnContinuar1.Click
        Me.tabClienteCentral.SelectTab(1)
    End Sub

    Private Sub btnRegresar1_Click(sender As Object, e As EventArgs) Handles btnRegresar1.Click
        Me.tabClienteCentral.SelectTab(0)
    End Sub

    Private Sub btnContinuar2_Click(sender As Object, e As EventArgs) Handles btnContinuar2.Click
        Me.tabClienteCentral.SelectTab(2)
    End Sub

    Private Sub btnRegresar2_Click(sender As Object, e As EventArgs) Handles btnRegresar2.Click
        Me.tabClienteCentral.SelectTab(1)
    End Sub

#Region "Limpiar Todo"
    Private Sub limpiarTodo()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtFechaNac.Value = Date.Now
        txtDireccion.Clear()
        txtCiudad.Clear()
        txtEstadoCivil.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtCorreo.Clear()
        txtCedula.Clear()
        txtFechaEmision.Value = Date.Now
        txtFechaVencimiento.Value = Date.Now
        txtOcupacion.Clear()
        txtDireccionNegocio.Clear()
        txtTiempoNeg.Clear()
        radNo.Checked = True
        grupoOtraActividad.Enabled = False
        radPorCuenta.Checked = True
        grupoTercero.Enabled = False
        txtNombreTercero.Clear()
        txtDireccionTercero.Clear()
        txtNombreCuenta.Clear()
        txtNumeroCuenta.Clear()
        txtBanco.Clear()
        txtMontoMensual.Clear()
        txtNumeroOperaciones.Clear()
        checHabilitarPerfil.Checked = False
        grupoPerfil.Enabled = False
        txtNombre_Banco_1.Clear()
        txtTipo_Relacion_1.Clear()
        txtTiempo_Negocio_1.Clear()
        txtNombre_Banco_2.Clear()
        txtTipo_Relacion_2.Clear()
        txtTiempo_Negocio_2.Clear()
        txtNombre_Banco_3.Clear()
        txtTipo_Relacion_3.Clear()
        txtTiempo_Negocio_3.Clear()
        txtIngresosMensuales.Clear()
        txtOtraActividad.Clear()
        txtFechaIngreso.Value = Date.Now
    End Sub
#End Region

    Private Sub habilitarBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal editar As Boolean, ByVal eliminar As Boolean, ByVal cancelar As Boolean, ByVal buscar As Boolean)
        btnNuevo.Enabled = nuevo
        btnGuardar.Enabled = guardar
        btnEditar.Enabled = editar
        btnEliminar.Enabled = eliminar
        btnCancelar.Enabled = cancelar
        btnBuscar.Enabled = buscar
    End Sub

#Region "KeyPress Datos"
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtApellidos.Focus()
        End Select
    End Sub

    Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtFechaNac.Focus()
        End Select
    End Sub

    Private Sub txtFechaNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaNac.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtDireccion.Focus()
        End Select
    End Sub

    Private Sub txtCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCiudad.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtEstadoCivil.Focus()
        End Select
    End Sub

    Private Sub txtEstadoCivil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadoCivil.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTelefono.Focus()
        End Select
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtCelular.Focus()
        End Select
    End Sub

    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtCorreo.Focus()
        End Select
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtCedula.Focus()
        End Select
    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtFechaEmision.Focus()
        End Select
    End Sub

    Private Sub txtFechaEmision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaEmision.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtFechaVencimiento.Focus()
        End Select
    End Sub

    Private Sub txtFechaVencimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaVencimiento.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                btnContinuar1.Focus()
        End Select
    End Sub
#End Region

#Region "KeyPress Actividad"
    Private Sub txtOcupacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOcupacion.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtDireccionNegocio.Focus()
        End Select
    End Sub

    Private Sub txtLugar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccionNegocio.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTiempoNeg.Focus()
        End Select
    End Sub

    Private Sub txtTiempoActividad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiempoNeg.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                radNo.Focus()
        End Select
    End Sub
    Private Sub radSi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles radSi.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtOtraActividad.Focus()
        End Select
    End Sub
    Private Sub txtOtraActividad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtraActividad.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                radTercero.Focus()
        End Select
    End Sub
    Private Sub radNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles radNo.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                radPorCuenta.Focus()
        End Select
    End Sub
    Private Sub radPorCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles radPorCuenta.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtNombreCuenta.Focus()
        End Select
    End Sub
    Private Sub radTercero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles radTercero.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtNombreTercero.Focus()
        End Select
    End Sub
    Private Sub txtNombreTercero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreTercero.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtDireccionTercero.Focus()
        End Select
    End Sub

    Private Sub txtDireccionTercero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccionTercero.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtNombreCuenta.Focus()
        End Select
    End Sub

    Private Sub txtNombreCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCuenta.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtNumeroCuenta.Focus()
        End Select
    End Sub

    Private Sub txtNumeroCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroCuenta.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtBanco.Focus()
        End Select
    End Sub

    Private Sub txtBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBanco.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtMontoMensual.Focus()
        End Select
    End Sub

    Private Sub txtMontoMensual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoMensual.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtNumeroOperaciones.Focus()
        End Select
    End Sub

    Private Sub txtNumeroOperaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroOperaciones.KeyPress
        ServiciosBasicos.NumeroDec(e, txtNumeroOperaciones)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                btnContinuar2.Focus()
        End Select
    End Sub
#End Region

#Region "KeyPress Referencias"
    Private Sub txtNombre_Banco_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre_Banco_1.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTipo_Relacion_1.Focus()
        End Select
    End Sub

    Private Sub txtTipo_Relacion_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo_Relacion_1.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTiempo_Negocio_1.Focus()
        End Select
    End Sub

    Private Sub txtTiempo_Negocio_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiempo_Negocio_1.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtNombre_Banco_2.Focus()
        End Select
    End Sub

    Private Sub txtNombre_Banco_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre_Banco_2.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTipo_Relacion_2.Focus()
        End Select
    End Sub

    Private Sub txtTipo_Relacion_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo_Relacion_2.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTiempo_Negocio_2.Focus()
        End Select
    End Sub

    Private Sub txtTiempo_Negocio_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiempo_Negocio_2.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtNombre_Banco_3.Focus()
        End Select
    End Sub

    Private Sub txtNombre_Banco_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre_Banco_3.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTipo_Relacion_3.Focus()
        End Select
    End Sub

    Private Sub txtTipo_Relacion_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo_Relacion_3.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtTiempo_Negocio_3.Focus()
        End Select
    End Sub

    Private Sub txtTiempo_Negocio_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiempo_Negocio_3.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                txtIngresosMensuales.Focus()
        End Select
    End Sub
#End Region

#Region "Radio Button Checked"
    Private Sub checHabilitarPerfil_CheckedChanged(sender As Object, e As EventArgs) Handles checHabilitarPerfil.CheckedChanged
        If checHabilitarPerfil.CheckState = CheckState.Checked Then
            grupoPerfil.Enabled = True
        End If
        If checHabilitarPerfil.CheckState = CheckState.Unchecked Then
            grupoPerfil.Enabled = False
        End If
    End Sub

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        If radNo.Checked Then
            grupoOtraActividad.Enabled = False
        End If
    End Sub

    Private Sub radSi_CheckedChanged(sender As Object, e As EventArgs) Handles radSi.CheckedChanged
        If radSi.Checked Then
            grupoOtraActividad.Enabled = True
        End If
    End Sub

    Private Sub radPorCuenta_CheckedChanged(sender As Object, e As EventArgs) Handles radPorCuenta.CheckedChanged
        If radPorCuenta.Checked Then
            grupoTercero.Enabled = False
        End If
    End Sub

    Private Sub radTercero_CheckedChanged(sender As Object, e As EventArgs) Handles radTercero.CheckedChanged
        If radTercero.Checked Then
            grupoTercero.Enabled = True
        End If
    End Sub
#End Region

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        auxiliar = 1
        limpiarTodo()
        habilitarBotones(False, True, False, False, True, False)
        tabClienteCentral.Enabled = True
        txtNombre.Focus()
        codigoCliente()
        Me.btnImprimir.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim daoCliente = DataContext.daoCliente
        Try
            Dim buscar As Cliente = daoCliente.findById(txtCodCliente.Text)
            If buscar.Nombres.Length > 0 Then
                auxiliar = 2
                habilitarBotones(False, True, False, False, True, False)
                tabClienteCentral.Enabled = True
                txtNombre.Focus()
            End If
        Catch ex As Exception
            MsgBox("No existe el cliente con el codigo seleccionado, intente nuevamente",
                   MsgBoxStyle.Information, "Editar Cliente")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim dao = DataContext.daoCliente
        If dao.existeCliente(txtCodCliente.Text) = False Then
            MsgBox("NO existe el cliente seleccionado, intente nuevamente", MsgBoxStyle.Information, "Eliminar Cliente")
            Return
        End If
        auxiliar = 3
        habilitarBotones(False, True, False, False, True, False)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodCliente.Enabled = False
        limpiarTodo()

        habilitarBotones(True, False, True, True, False, True)
        btnAceptar.Visible = False
        tabClienteCentral.Enabled = False
        codigoCliente()
        dgvFiltrar.Visible = False
        Me.erp.Clear()
        Me.btnImprimir.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.txtCodCliente.Clear()
        btnAceptar.Visible = True
        habilitarBotones(False, False, False, False, True, False)
        txtCodCliente.Enabled = True
        txtCodCliente.Focus()
        dgvFiltrar.Visible = True
        Me.filtrarCliente()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim daoCliente = DataContext.daoCliente
        Dim daoPica = DataContext.daoPica
        Try
            Dim buscar As Cliente = daoCliente.findById(txtCodCliente.Text)
            If buscar.Nombres.Length > 0 Then
                MsgBox("Cliente Encontrado", MsgBoxStyle.Information, "Buscar cliente")
            End If
            txtNombre.Text = buscar.Nombres
            txtApellidos.Text = buscar.Apellidos
            txtFechaIngreso.Value = buscar.F_ingreso
            txtFechaNac.Value = buscar.F_nacimiento
            txtDireccion.Text = buscar.Direccion
            txtCiudad.Text = buscar.Ciudad
            txtEstadoCivil.Text = buscar.Estadocivil
            txtTelefono.Text = buscar.Telefono
            txtCelular.Text = buscar.Celular
            txtCorreo.Text = buscar.Email
            txtCedula.Text = buscar.Numcedula
            txtFechaEmision.Value = buscar.F_emision
            txtFechaVencimiento.Value = buscar.F_vencimiento
            txtOcupacion.Text = buscar.Ocupacion
            txtDireccionNegocio.Text = buscar.Direccion_negocio
            txtTiempoNeg.Text = buscar.Tiempo_neg
            txtOtraActividad.Text = buscar.Desc_otra
            txtNombreTercero.Text = buscar.Nombre_tercero
            txtDireccionTercero.Text = buscar.Direccion_tercero
            txtMontoMensual.Text = buscar.Monto_mensual
            txtNumeroOperaciones.Text = buscar.Total_operaciones
            If buscar.Otra_ae = "Si" Then
                radSi.Checked = True
            Else
                radNo.Checked = True
            End If
            If buscar.Actua_por = "Cuenta propia" Then
                radPorCuenta.Checked = True
            Else
                radTercero.Checked = True
            End If
            txtNombreCuenta.Text = buscar.Nom_cuenta
            txtNumeroCuenta.Text = buscar.Num_cuenta
            txtBanco.Text = buscar.Nom_banco
            If buscar.Pica = 1 Then
                checHabilitarPerfil.CheckState = CheckState.Checked
                grupoPerfil.Enabled = True
                Try
                    'Recuperamos el cliente si este es PICA
                    Dim picaCliente = daoPica.findById(txtCodCliente.Text)
                    Dim pica1 = picaCliente.Item(0)
                    txtNombre_Banco_1.Text = pica1.Nombre_entidad
                    txtTipo_Relacion_1.Text = pica1.Tipo_relacion
                    txtTiempo_Negocio_1.Text = pica1.Tiempo_mantener
                    txtIngresosMensuales.Text = pica1.Ingreso_mensual
                    Dim pica2 = picaCliente.Item(1)
                    txtNombre_Banco_2.Text = pica2.Nombre_entidad
                    txtTipo_Relacion_2.Text = pica2.Tipo_relacion
                    txtTiempo_Negocio_2.Text = pica2.Tiempo_mantener
                    Dim pica3 = picaCliente.Item(2)
                    txtNombre_Banco_3.Text = pica3.Nombre_entidad
                    txtTipo_Relacion_3.Text = pica3.Tipo_relacion
                    txtTiempo_Negocio_3.Text = pica3.Tiempo_mantener
                    'Tenemos un catch por si solo tiene un registro
                    'y asi no arroje un error fuera de indice
                Catch ex As Exception
                End Try
            Else
                checHabilitarPerfil.CheckState = CheckState.Unchecked
                grupoPerfil.Enabled = False
            End If
            picaActual = buscar.Pica
            txtCodCliente.Enabled = False
            btnAceptar.Visible = False
            dgvFiltrar.Visible = False
            habilitarBotones(True, False, True, True, False, True)
            btnImprimir.Enabled = True
        Catch ex As Exception
            MsgBox("No existe el cliente con el codigo especificado, intente nuevamente",
                   MsgBoxStyle.Critical, "Buscar Cliente")
        End Try
    End Sub

    Private Sub txtCodCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged
        Me.filtrarCliente()
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCliente.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                dgvFiltrar.Focus()
            Case Keys.Enter
                btnAceptar_Click(sender, e)
        End Select
    End Sub

    Private Sub dgvFiltrar_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvFiltrar.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                Dim row As DataGridViewRow = dgvFiltrar.CurrentRow
                txtCodCliente.Text = row.Cells(0).Value
                dgvFiltrar.Visible = False
                txtCodCliente.Focus()
        End Select
    End Sub
    Sub imprimirCliente()
        Using ctx As New Contexto
            Dim daoCliente = DataContext.daoCliente
            Dim buscar As New List(Of Cliente)
            Dim codigo As String = Me.txtCodCliente.Text
            buscar = (From c In ctx.Cliente Where c.Codcliente = codigo Select c).ToList()
            For Each dato In buscar
                Dim cod As String = dato.Codcliente
                Dim rptContrato As New rptContratoCliente
                rptContrato.SetDataSource(buscar)
                frmReporteContrato.CrystalReportViewer1.ReportSource = rptContrato
                frmReporteContrato.Show()
                If dato.Pica = 1 Then
                    Dim frmReportePica As New frmReportePica
                    Dim report As New rptPica
                    Dim pica As List(Of Pica) = (From p In ctx.Pica Where p.Codcliente = cod Select p).ToList()
                    report.Database.Tables(0).SetDataSource(buscar)
                    report.Database.Tables(1).SetDataSource(pica)
                    frmReportePica.CrystalReportViewer1.ReportSource = report
                    frmReportePica.Show()
                    Exit For
                End If
                If dato.Pica = 0 Then
                    Dim frmReportePic As New frmReportePic
                    Dim report As New rptPic
                    report.SetDataSource(buscar)
                    frmReportePic.CrystalReportViewer1.ReportSource = report
                    frmReportePic.Show()
                    Exit For
                End If
            Next
        End Using
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim daocliente = DataContext.daoCliente
        Dim daoPica = DataContext.daoPica
        Dim cliente As New Cliente()
        Dim pica As New List(Of Pica)
        Try
            Dim sinEspecificar As String = String.Empty
            If txtNombre.TextLength <= 0 Then
                erp.SetError(txtNombre, vacio)
                'pageDatos.Tab.Selected = True
                txtNombre.Focus()
                Return
            Else
                cliente.Nombres = txtNombre.Text
            End If
            If txtApellidos.TextLength <= 0 Then
                erp.SetError(txtApellidos, vacio)
                'pageDatos.Tab.Selected = True
                txtApellidos.Focus()
                Return
            Else
                cliente.Apellidos = txtApellidos.Text
            End If
            If txtDireccion.TextLength <= 0 Then
                erp.SetError(txtDireccion, vacio)
                'pageDatos.Tab.Selected = True
                txtDireccion.Focus()
                Return
            Else
                cliente.Direccion = txtDireccion.Text
            End If
            If txtCedula.TextLength <= 0 Then
                erp.SetError(txtCedula, vacio)
                'pageDatos.Tab.Selected = True
                txtCedula.Focus()
                Return
            Else
                cliente.Numcedula = txtCedula.Text
            End If
            If radSi.Checked = True Then
                If txtOtraActividad.TextLength <= 0 Then
                    erp.SetError(txtOtraActividad, vacio)
                    'pageActividad.Tab.Selected = True
                    txtOtraActividad.Focus()
                    Return
                End If
                cliente.Otra_ae = "Si"
                cliente.Desc_otra = txtOtraActividad.Text
            Else
                cliente.Otra_ae = "No"
                cliente.Desc_otra = sinEspecificar
            End If
            If radTercero.Checked = True Then
                If txtNombreTercero.TextLength <= 0 Then
                    erp.SetError(txtNombreTercero, vacio)
                    'pageActividad.Tab.Selected = True
                    txtNombreTercero.Focus()
                    Return
                End If
                If txtDireccionTercero.TextLength <= 0 Then
                    erp.SetError(txtDireccionTercero, vacio)
                    'pageActividad.Tab.Selected = True
                    txtDireccionTercero.Focus()
                    Return
                End If
                cliente.Actua_por = "Tercero"
                cliente.Nombre_tercero = txtNombreTercero.Text
                cliente.Direccion_tercero = txtDireccionTercero.Text
            Else
                cliente.Actua_por = "Cuenta propia"
                cliente.Nombre_tercero = sinEspecificar
                cliente.Direccion_tercero = sinEspecificar
            End If
            If Me.txtOcupacion.TextLength <= 0 Then
                erp.SetError(Me.txtOcupacion, vacio)
                'pageActividad.Tab.Selected = True
                Me.txtOcupacion.Focus()
                Return
            End If
            If txtOcupacion.TextLength > 0 Then
                If txtDireccionNegocio.TextLength <= 0 Then
                    erp.SetError(txtDireccionNegocio, vacio)
                    'pageActividad.Tab.Selected = True
                    txtDireccionNegocio.Focus()
                    Return
                End If
                If txtTiempoNeg.TextLength <= 0 Then
                    erp.SetError(txtTiempoNeg, vacio)
                    'pageActividad.Tab.Selected = True
                    txtTiempoNeg.Focus()
                    Return
                End If
                cliente.Ocupacion = txtOcupacion.Text
                cliente.Direccion_negocio = txtDireccionNegocio.Text
                cliente.Tiempo_neg = txtTiempoNeg.Text
            Else
                cliente.Ocupacion = sinEspecificar
                cliente.Direccion_negocio = sinEspecificar
                cliente.Tiempo_neg = sinEspecificar
            End If
            If txtNombreCuenta.TextLength > 0 Then
                If txtNumeroCuenta.TextLength <= 0 Then
                    erp.SetError(txtNumeroCuenta, vacio)
                    'pageActividad.Tab.Selected = True
                    txtNumeroCuenta.Focus()
                    Return
                End If
                If txtBanco.TextLength <= 0 Then
                    erp.SetError(txtBanco, vacio)
                    'pageActividad.Tab.Selected = True
                    txtBanco.Focus()
                    Return
                End If
                cliente.Nom_cuenta = txtNombreCuenta.Text
                cliente.Num_cuenta = txtNumeroCuenta.Text
                cliente.Nom_banco = txtBanco.Text
            Else
                cliente.Nom_cuenta = sinEspecificar
                cliente.Num_cuenta = sinEspecificar
                cliente.Nom_banco = sinEspecificar
            End If
            If txtMontoMensual.TextLength <= 0 Then
                erp.SetError(txtMontoMensual, campoVacio)
                'pageActividad.Tab.Selected = True
                txtMontoMensual.Focus()
                Return
            End If
            If txtMontoMensual.TextLength > 0 Then
                cliente.Monto_mensual = txtMontoMensual.Text
            Else
                cliente.Monto_mensual = Decimal.Parse(0)
            End If
            If txtNumeroOperaciones.TextLength <= 0 Then
                erp.SetError(txtNumeroOperaciones, campoVacio)
                'pageActividad.Tab.Selected = True
                txtNumeroOperaciones.Focus()
                Return
            End If
            If txtNumeroOperaciones.TextLength > 0 Then
                cliente.Total_operaciones = txtNumeroOperaciones.Text
            Else
                cliente.Total_operaciones = Decimal.Parse(0)
            End If
            If checHabilitarPerfil.CheckState = CheckState.Checked Then
                If txtNombre_Banco_1.TextLength > 0 Then
                    Dim pica1 As New Pica()
                    pica1.Nombre_entidad = txtNombre_Banco_1.Text
                    If txtTipo_Relacion_1.TextLength <= 0 Then
                        erp.SetError(txtTipo_Relacion_1, vacio)
                        'pageReferencias.Tab.Selected = True
                        txtTipo_Relacion_1.Focus()
                        Return
                    Else
                        pica1.Tipo_relacion = txtTipo_Relacion_1.Text
                    End If
                    If txtTiempo_Negocio_1.TextLength <= 0 Then
                        erp.SetError(txtTiempo_Negocio_1, vacio)
                        'pageReferencias.Tab.Selected = True
                        txtTiempo_Negocio_1.Focus()
                        Return
                    Else
                        pica1.Tiempo_mantener = txtTiempo_Negocio_1.Text
                    End If
                    If auxiliar = 1 Then
                        pica1.Codcliente = daocliente.codCliente()
                    End If
                    If auxiliar = 2 Then
                        pica1.Codcliente = txtCodCliente.Text
                    End If
                    If txtIngresosMensuales.TextLength <= 0 Then
                        erp.SetError(txtIngresosMensuales, vacio)
                        'pageReferencias.Tab.Selected = True
                        txtIngresosMensuales.Focus()
                        Return
                    End If
                    pica1.Ingreso_mensual = txtIngresosMensuales.Text
                    pica.Add(pica1)
                End If
                If txtNombre_Banco_2.TextLength > 0 Then
                    Dim pica2 As New Pica()
                    pica2.Nombre_entidad = txtNombre_Banco_2.Text
                    If txtTipo_Relacion_2.TextLength <= 0 Then
                        erp.SetError(txtTipo_Relacion_2, vacio)
                        'pageReferencias.Tab.Selected = True
                        txtTipo_Relacion_2.Focus()
                        Return
                    End If
                    If txtTiempo_Negocio_2.TextLength <= 0 Then
                        erp.SetError(txtTiempo_Negocio_2, vacio)
                        'pageReferencias.Tab.Selected = True
                        txtTiempo_Negocio_2.Focus()
                        Return
                    End If
                    pica2.Tipo_relacion = txtTipo_Relacion_2.Text
                    pica2.Tiempo_mantener = txtTiempo_Negocio_2.Text
                    If auxiliar = 1 Then
                        pica2.Codcliente = daocliente.codCliente()
                    End If
                    If auxiliar = 2 Then
                        pica2.Codcliente = txtCodCliente.Text
                    End If
                    pica2.Ingreso_mensual = txtIngresosMensuales.Text
                    pica.Add(pica2)
                End If
                If txtNombre_Banco_3.TextLength > 0 Then
                    Dim pica3 As New Pica()
                    pica3.Nombre_entidad = txtNombre_Banco_3.Text
                    If txtTipo_Relacion_3.TextLength <= 0 Then
                        erp.SetError(txtTipo_Relacion_2, vacio)
                        'pageReferencias.Tab.Selected = True
                        txtTipo_Relacion_3.Focus()
                        Return
                    End If
                    If txtTiempo_Negocio_3.TextLength <= 0 Then
                        erp.SetError(txtTiempo_Negocio_3, vacio)
                        'pageReferencias.Tab.Selected = True
                        txtTiempo_Negocio_3.Focus()
                        Return
                    End If
                    pica3.Tipo_relacion = txtTipo_Relacion_3.Text
                    pica3.Tiempo_mantener = txtTiempo_Negocio_3.Text
                    If auxiliar = 1 Then
                        pica3.Codcliente = daocliente.codCliente()
                    End If
                    If auxiliar = 2 Then
                        pica3.Codcliente = txtCodCliente.Text
                    End If
                    pica3.Ingreso_mensual = txtIngresosMensuales.Text
                    pica.Add(pica3)
                End If
                'esto nos dice si el cliente tiene pica
                cliente.Pica = 1
            Else
                'esto nos dice que no tiene pica
                cliente.Pica = 0
            End If
            If txtCiudad.TextLength <= 0 Then
                cliente.Ciudad = sinEspecificar
            Else
                cliente.Ciudad = txtCiudad.Text
            End If
            If txtEstadoCivil.TextLength <= 0 Then
                cliente.Estadocivil = sinEspecificar
            Else
                cliente.Estadocivil = txtEstadoCivil.Text
            End If
            If txtCelular.TextLength <= 0 Then
                cliente.Celular = sinEspecificar
            Else
                cliente.Celular = txtCelular.Text
            End If
            If txtTelefono.TextLength <= 0 Then
                cliente.Telefono = sinEspecificar
            Else
                cliente.Telefono = txtTelefono.Text
            End If
            If txtCorreo.TextLength <= 0 Then
                txtCorreo.Text = sinEspecificar
            End If
            If txtFechaEmision.Text.Length > 0 Then
                cliente.F_emision = txtFechaEmision.Value
            End If
            If txtFechaVencimiento.Text.Length > 0 Then
                cliente.F_vencimiento = txtFechaVencimiento.Value
            End If
            If txtFechaNac.Text.Length > 0 Then
                cliente.F_nacimiento = txtFechaNac.Value
            End If
            If txtCorreo.TextLength > 0 Then
                cliente.Email = txtCorreo.Text
            Else
                cliente.Email = sinEspecificar
            End If
            If txtFechaIngreso.Text.Length > 0 Then
                cliente.F_ingreso = txtFechaIngreso.Value
            End If
            Dim result As DialogResult = MsgBox("¿Guardar los datos del cliente seleccionado en el sistema?", MsgBoxStyle.YesNo, "Cliente")
            If result = Windows.Forms.DialogResult.No Then
                Return
            End If
            'realizamos las operaciones de CRUD del Cliente
            Select Case auxiliar
                Case 1 'ingresar cliente
                    cliente.Codcliente = daocliente.codCliente()
                    If daocliente.create(cliente) = True Then
                        For Each pic In pica
                            daoPica.create(pic)
                        Next
                        MsgBox("Se ingresó el cliente el sistema de forma correcta",
                               MsgBoxStyle.Information, "Ingresar Cliente")
                        If MsgBox("¿Imprimir el cliente ingresado?", MsgBoxStyle.YesNo, "Imprimir") = MsgBoxResult.Yes Then
                            Me.txtCodCliente.Text = cliente.Codcliente
                            Me.imprimirCliente()
                        End If
                        pica.Clear()
                        btnCancelar_Click(sender, e)
                    Else
                        MsgBox("Se produjo un error al intentar ingresar el cliente, revise la siguiente información: " &
                               daocliente.ErrorSms, MsgBoxStyle.Critical, "Ingresar Cliente")
                    End If
                Case 2 'editar los datos del cliente
                    cliente.Codcliente = txtCodCliente.Text
                    If daocliente.update(cliente) = True Then
                        If picaActual = 1 Then
                            daoPica.deleteByCodCliente(txtCodCliente.Text)
                            daoPica.update(pica)
                        Else
                            For Each pic In pica
                                daoPica.create(pic)
                            Next
                        End If
                        MsgBox("Se actualizarón los datos del cliente en el sistema de forma correcta",
                               MsgBoxStyle.Information, "Editar Cliente")
                        pica.Clear()
                        btnCancelar_Click(sender, e)
                    Else
                        MsgBox("Se produjo un error al intentar ingresar el cliente, revise la siguiente información: " &
                               daocliente.ErrorSms, MsgBoxStyle.Critical, "Ingresar Cliente")
                    End If
                Case 3 'eliminar cliente del sistema
                    cliente.Codcliente = txtCodCliente.Text
                    If daocliente.delete(cliente) = True Then
                        For Each pic In pica
                            daoPica.delete(pic)
                        Next
                        MsgBox("Se eliminarón los datos del cliente en el sistema de forma correcta",
                               MsgBoxStyle.Information, "Eliminar Cliente")
                        pica.Clear()
                        btnCancelar_Click(sender, e)
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "TextChanged para limpiar el ErrorProvider"
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.TextLength > 0 Then
            erp.SetError(txtNombre, String.Empty)
        End If
    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged
        If txtApellidos.TextLength > 0 Then
            erp.SetError(txtApellidos, String.Empty)
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        If txtDireccion.TextLength > 0 Then
            erp.SetError(txtDireccion, String.Empty)
        End If
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        If txtCedula.TextLength > 0 Then
            erp.SetError(txtCedula, String.Empty)
        End If
    End Sub

    Private Sub txtOtraActividad_TextChanged(sender As Object, e As EventArgs) Handles txtOtraActividad.TextChanged
        If txtOtraActividad.TextLength > 0 Then
            erp.SetError(txtOtraActividad, String.Empty)
        End If
    End Sub

    Private Sub txtNombreTercero_TextChanged(sender As Object, e As EventArgs) Handles txtNombreTercero.TextChanged
        If txtNombreTercero.TextLength > 0 Then
            erp.SetError(txtNombreTercero, String.Empty)
        End If
    End Sub

    Private Sub txtDireccionTercero_TextChanged(sender As Object, e As EventArgs) Handles txtDireccionTercero.TextChanged
        If txtDireccionTercero.TextLength > 0 Then
            erp.SetError(txtDireccionTercero, String.Empty)
        End If
    End Sub

    Private Sub txtNumeroCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroCuenta.TextChanged
        If txtNumeroCuenta.TextLength > 0 Then
            erp.SetError(txtNumeroCuenta, String.Empty)
        End If
    End Sub

    Private Sub txtBanco_TextChanged(sender As Object, e As EventArgs) Handles txtBanco.TextChanged
        If txtBanco.TextLength > 0 Then
            erp.SetError(txtBanco, String.Empty)
        End If
    End Sub

    Private Sub txtLugar_TextChanged(sender As Object, e As EventArgs) Handles txtDireccionNegocio.TextChanged
        If txtDireccionNegocio.TextLength > 0 Then
            erp.SetError(txtDireccionNegocio, String.Empty)
        End If
    End Sub

    Private Sub txtTiempoActividad_TextChanged(sender As Object, e As EventArgs) Handles txtTiempoNeg.TextChanged
        If txtTiempoNeg.TextLength > 0 Then
            erp.SetError(txtTiempoNeg, String.Empty)
        End If
    End Sub
    Private Sub txtTipo_Relacion_1_TextChanged(sender As Object, e As EventArgs) Handles txtTipo_Relacion_1.TextChanged
        If txtTipo_Relacion_1.TextLength > 0 Then
            erp.SetError(txtTipo_Relacion_1, String.Empty)
        End If
    End Sub

    Private Sub txtTiempo_Negocio_1_TextChanged(sender As Object, e As EventArgs) Handles txtTiempo_Negocio_1.TextChanged
        If txtTiempo_Negocio_1.TextLength > 0 Then
            erp.SetError(txtTiempo_Negocio_1, String.Empty)
        End If
    End Sub

    Private Sub txtTipo_Relacion_2_TextChanged(sender As Object, e As EventArgs) Handles txtTipo_Relacion_2.TextChanged
        If txtTipo_Relacion_2.TextLength > 0 Then
            erp.SetError(txtTipo_Relacion_2, String.Empty)
        End If
    End Sub

    Private Sub txtTipo_Relacion_3_TextChanged(sender As Object, e As EventArgs) Handles txtTipo_Relacion_3.TextChanged
        If txtTipo_Relacion_3.TextLength > 0 Then
            erp.SetError(txtTipo_Relacion_3, String.Empty)
        End If
    End Sub

    Private Sub txtTiempo_Negocio_2_TextChanged(sender As Object, e As EventArgs) Handles txtTiempo_Negocio_2.TextChanged
        If txtTiempo_Negocio_2.TextLength > 0 Then
            erp.SetError(txtTiempo_Negocio_2, String.Empty)
        End If
    End Sub

    Private Sub txtTiempo_Negocio_3_TextChanged(sender As Object, e As EventArgs) Handles txtTiempo_Negocio_3.TextChanged
        If txtTiempo_Negocio_3.TextLength > 0 Then
            erp.SetError(txtTiempo_Negocio_3, String.Empty)
        End If
    End Sub
    Private Sub txtIngresosMensuales_TextChanged(sender As Object, e As EventArgs) Handles txtIngresosMensuales.TextChanged
        If txtIngresosMensuales.TextLength > 0 Then
            erp.SetError(txtIngresosMensuales, String.Empty)
        End If
    End Sub
#End Region

    Private Sub txtFechaVencimiento_Validated(sender As System.Object, e As System.EventArgs) Handles txtFechaVencimiento.Validated

    End Sub

    Private Sub txtFechaVencimiento_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFechaVencimiento.ValueChanged
        Me.validarFechaCedula()
    End Sub

    Private Sub txtOcupacion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOcupacion.TextChanged
        If Me.txtOcupacion.TextLength > 0 Then
            erp.SetError(Me.txtOcupacion, "")
        End If
    End Sub

    Private Sub txtMontoMensual_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMontoMensual.TextChanged
        If txtMontoMensual.TextLength > 0 Then
            erp.SetError(Me.txtMontoMensual, String.Empty)
        End If
    End Sub

    Private Sub txtNumeroOperaciones_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumeroOperaciones.TextChanged
        If txtNumeroOperaciones.TextLength > 0 Then
            erp.SetError(Me.txtNumeroOperaciones, String.Empty)
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Me.imprimirCliente()
    End Sub

    Private Sub txtMontoMensual_Enter(sender As System.Object, e As System.EventArgs) Handles txtMontoMensual.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtMontoMensual)
        If auxiliar = 1 Then
            Me.txtMontoMensual.Text = "1"
        End If
    End Sub

    Private Sub txtMontoMensual_Leave(sender As System.Object, e As System.EventArgs) Handles txtMontoMensual.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtMontoMensual)
    End Sub


    Private Sub txtCedula_Validated(sender As Object, e As EventArgs) Handles txtCedula.Validated
        Dim corte As Array = Me.txtCedula.Text.Split(CChar("-"))
        Me.txtCedula.Clear()
        For Each valor In corte
            Me.txtCedula.Text += valor
        Next
        Dim dao = DataContext.daoCliente
        Try
            Dim verCliente = dao.findByCedula(Me.txtCedula.Text)
            If auxiliar = 1 Then
                If verCliente.Nombres.Length > 0 Then
                    If MsgBox("Ya existe un cliente con esta cedula en la base de datos." &
                           vbCr & "¿Desea continuar con el ingreso del cliente?", MsgBoxStyle.YesNo, "Cliente") = MsgBoxResult.No Then
                        Me.btnCancelar_Click(sender, e)
                    End If
                Else
                    MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

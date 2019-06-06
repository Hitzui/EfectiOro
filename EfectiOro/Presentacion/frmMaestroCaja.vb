Imports EfectiOro.Database

Public Class frmMaestroCaja
    Private Const _titleAbrirCaja As String = "Abrir caja"
    Private Const _titleError As String = "Error"
    Private Const _titleCerrarCaja As String = "Cerrar caja"
    Dim FORMATO_DECIMAL As String = "#,###,#00.00"
    Dim cajaActual As String
    Dim agenciaActual As String = "A001"
    Dim idmovimiento As Integer
    Dim recIdmov As Integer
    Private revMovcaja As Movcaja
    Private Function validarMovmientoCaja(movimiento As Integer) As Boolean
        Try
            Dim daoIds = DataContext.daoParametros
            Dim recIds = daoIds.recuperarParametros()
            Select Case movimiento
                Case recIds.id_adelantos
                    MsgBox("No puede realizar adelantos en el moduo de caja", MsgBoxStyle.Exclamation, "Caja")
                    Return False
                Case recIds.idcompras
                    MsgBox("No puede realizar compras en el moduo de caja", MsgBoxStyle.Exclamation, "Caja")
                    Return False
                Case recIds.cierre_compra
                    MsgBox("No puede realizar abonos a compras en el moduo de caja", MsgBoxStyle.Exclamation, "Caja")
                    Return False
                Case recIds.anular_compra
                    MsgBox("No puede realizar reversión (anular) de compras desde caja, esto es posible desde la pantalla de compras",
                           MsgBoxStyle.Exclamation, "Caja")
                    Return False
                Case recIds.anular_adelanto
                    MsgBox("No puede realizar reversión (anular) de adelantos desde caja.",
                           MsgBoxStyle.Exclamation, "Caja")
            End Select
            Return True
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, _titleError)
            Return False
        End Try
    End Function
    Sub cargarSaldosCaja()
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        Dim xcaja As Mcaja = dao.recuperarSaldoCaja(cajaActual)
        lblSaldo.Text = xcaja.Sfinal.ToString(Me.FORMATO_DECIMAL)
        lblInicial.Text = xcaja.Sinicial.ToString(Me.FORMATO_DECIMAL)
        lblEntrada.Text = xcaja.Entrada.ToString(Me.FORMATO_DECIMAL)
        lblSalida.Text = xcaja.Salida.ToString(Me.FORMATO_DECIMAL)
        Try
            If dao.ErrorSms.Length > 0 Then
                MsgBox("Se produjo un error al intentar recuper el saldo de la caja. Revise la siguiente información: " &
                       vbCr & dao.ErrorSms, MsgBoxStyle.Critical, _titleError)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub revisarEstadoCaja()
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        If dao.validarPrestamosPuentes() = 0 Then
            Me.lblVermonto.Text = dao.ErrorSms
        Else
            Me.lblVermonto.Text = dao.validarPrestamosPuentes().ToString()
        End If
        If dao.estadoCaja(cajaActual) = True Then
            btnAbrirCaja.Enabled = False
            btnCerrarCaja.Enabled = True
            cargarSaldosCaja()
            Me.btnAbrirCaja.ForeColor = Color.White
            Me.btnAbrirCaja.BackColor = Color.DimGray
            Me.btnCerrarCaja.BackColor = Color.FromName("HotTrack")
            Me.btnCerrarCaja.ForeColor = Color.White
        Else
            btnCerrarCaja.Enabled = False
            btnAbrirCaja.Enabled = True
            Me.btnAbrirCaja.BackColor = Color.FromName("HotTrack")
            Me.btnAbrirCaja.ForeColor = Color.White
            Me.btnCerrarCaja.BackColor = Color.DimGray
            Me.btnCerrarCaja.ForeColor = Color.White
        End If
    End Sub

    Sub cargarCaja()
        Dim config As New ConfiguracionGeneral()
        Me.cajaActual = config.getCaja()
        'Me.agenciaActual = config.getAgencia()
        'MsgBox("Caja: " & cajaActual)
    End Sub
    Private Sub frmMovCaja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.panReimprimir.Visible = True Then
            Me.panReimprimir.Visible = False
        End If
        btnClose.Visible = False
        Me.cargarCaja()
        lblTitulo.Text = "Movimientos del Día - " & cajaActual
        lblFecha.Text = Now.ToShortDateString()
        llenarCombo()
        Me.revisarEstadoCaja()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        lblHora.Text = Now.ToLongTimeString()
    End Sub

#Region "KeyChar y TextChange"
    Private Sub txtReferencias_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtReferencias.KeyPress
        ServiciosBasicos.keyCharEnter(txtMonto, e)
    End Sub

    Private Sub txtMonto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                cmbRubro.Focus()
                e.Handled = True
        End Select
        ServiciosBasicos.TextBoxNumeric_KeyPress(sender, e)
    End Sub

    Private Sub cmbRubro_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRubro.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                e.Handled = True
                'aqui el boton de guardar
        End Select
    End Sub

    Private Sub txtReferencias_Enter(sender As System.Object, e As System.EventArgs) Handles txtReferencias.Enter
        ServiciosBasicos.colorDeFondoInfo(txtReferencias)
    End Sub

    Private Sub txtMonto_Enter(sender As System.Object, e As System.EventArgs) Handles txtMonto.Enter
        ServiciosBasicos.colorDeFondoInfo(txtMonto)
    End Sub

    Private Sub txtReferencias_Leave(sender As System.Object, e As System.EventArgs) Handles txtReferencias.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtReferencias)
    End Sub

    Private Sub txtMonto_Leave(sender As System.Object, e As System.EventArgs) Handles txtMonto.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtMonto)
    End Sub

    Private Sub txtReferencias_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReferencias.TextChanged
        If txtReferencias.TextLength > 0 Then
            erp.SetError(txtReferencias, "")
        End If
    End Sub

    Private Sub txtMonto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMonto.TextChanged
        If txtMonto.TextLength > 0 Then
            erp.SetError(txtMonto, "")
        End If
    End Sub
#End Region

    Sub limpiar()
        txtReferencias.Clear()
        txtMonto.Clear()
    End Sub

    Sub llenarCombo()
        Dim dao = DataContext.daoMovimientosCaja
        cmbRubro.DataSource = dao.findAll()
        cmbRubro.DisplayMember = "Descripcion"
        cmbRubro.ValueMember = "Idmov"
    End Sub
    Sub habilitarCajas(opcion As Boolean)
        txtReferencias.Enabled = opcion
        txtMonto.Enabled = opcion
        cmbRubro.Enabled = opcion
        grupoTransacciones.Enabled = opcion
    End Sub
    Private Sub UltraButton3_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        btnGuardar.Visible = True
        btnNuevo.Visible = False
        btnCancelar.Visible = True
        Me.habilitarCajas(True)
        Me.txtReferencias.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        btnNuevo.Visible = True
        btnGuardar.Visible = False
        btnCancelar.Visible = False
        Me.habilitarCajas(False)
        Me.limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub imprimirVoucher()
        Try
            If chkImprimir.CheckState = CheckState.Checked Then
                Dim daoParametros = DataContext.daoParametros
                Dim parametro As Ids = daoParametros.recuperarParametros()
                Dim llenar As New List(Of Voucher)
                Dim voucher As New Voucher
                Dim recibe = DataContext.daoUsuario().findAll().Where(Function(u) u.Codoperador = parametro.recibe).Single()
                voucher.Caja = cajaActual
                voucher.Recibi = recibe.Nombre
                voucher.Nombre = DataContext.usuarioLog.Nombre
                voucher.cantidadLetra = ConvertirNumeroLetros(CDec(txtMonto.Text))
                If radCheque.Checked Then
                    voucher.Concepto = "Cheque " & Me.txtReferencias.Text
                ElseIf radTransferencia.Checked Then
                    voucher.Concepto = "Transferencia " & Me.txtReferencias.Text
                ElseIf radEfectivo.Checked Then
                    voucher.Concepto = "Efectivo " & Me.txtReferencias.Text
                End If
                voucher.Monto = CDec(txtMonto.Text)
                llenar.Add(voucher)
                Dim reporte As New rptVoucherTransferencia
                reporte.SetDataSource(llenar)
                frmReportes.viewer.ReportSource = reporte
                frmReportes.Show()
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error al intentar visualizar el voucher, rebice la siguiente información: " &
                   vbCr & ex.Message, MsgBoxStyle.Exclamation, _titleError)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Me.validarMovmientoCaja(recIdmov) = False Then
            Return
        End If
        If btnAbrirCaja.Enabled = True Then
            MsgBox("Abra la caja antes de realizar alguna transacción", MsgBoxStyle.Information, "Movimientos de caja")
            Return
        End If
        'Dim result As DialogResult = MsgBox("¿Aplicar el movimiento a la caja actual?", MsgBoxStyle.YesNo, "Guardar")
        'If result = Windows.Forms.DialogResult.No Then
        '    Return
        'End If
        If txtMonto.TextLength <= 0 Then
            erp.SetError(txtMonto, ServiciosBasicos.campoVacio)
            txtMonto.Focus()
            Return
        End If
        Me.cargarCaja()
        Dim idmov As Integer
        Dim dao As IDaoMaestroCaja = DataContext.daoMcaja
        If dao.validarCajaAbierta(Me.cajaActual) = False Then
            MsgBox("Para realizar movimientos de caja debe cerrar la caja y volverla a abrir, ya que esta quedó abierta del dia anterior", MsgBoxStyle.Information, "Caja")
            Return
        End If
        Try
            idmov = cmbRubro.SelectedValue
        Catch ex As Exception
        End Try
        If dao.validarMovimiento(idmov) Then
            idmovimiento = 1
        Else
            idmovimiento = 0
        End If
        Dim dcaja As New Detacaja
        Dim xcaja As Mcaja = dao.recuperarSaldoCaja(cajaActual)
        Dim ycaja As New Mcaja()
        dcaja.referencia = txtReferencias.Text
        dcaja.concepto = cmbRubro.Text
        dcaja.idmov = cmbRubro.SelectedValue
        'especificamos el tipo de transaccion a realizar
        If radCheque.Checked Then
            dcaja.cheque = Convert.ToDecimal(txtMonto.Text)
            dcaja.efectivo = Decimal.Zero
            dcaja.transferencia = Decimal.Zero
        End If
        If radEfectivo.Checked Then
            dcaja.efectivo = Convert.ToDecimal(txtMonto.Text)
            dcaja.transferencia = Decimal.Zero
            dcaja.cheque = Decimal.Zero
        End If
        If radTransferencia.Checked Then
            dcaja.transferencia = Convert.ToDecimal(txtMonto.Text)
            dcaja.cheque = Decimal.Zero
            dcaja.efectivo = Decimal.Zero
        End If
        dcaja.fecha = DateTime.Now
        dcaja.hora = lblHora.Text
        dcaja.idcaja = xcaja.Idcaja
        dcaja.codcaja = cajaActual
        If idmovimiento = 1 Then
            'entrada de movimiento
            If radCheque.Checked Then
                ycaja.Entrada = Decimal.Zero
            End If
            If radTransferencia.Checked Then
                ycaja.Entrada = 0D
            End If
            If radEfectivo.Checked Then
                ycaja.Entrada = Convert.ToDecimal(txtMonto.Text)
            End If
            ycaja.Salida = 0
        End If
        If idmovimiento = 0 Then
            'salida de movmiento
            If radCheque.Checked Then
                ycaja.Salida = Decimal.Zero
            End If
            If radTransferencia.Checked Then
                ycaja.Salida = 0D
            End If
            If radEfectivo.Checked Then
                ycaja.Salida = Convert.ToDecimal(txtMonto.Text)
            End If
            ycaja.Entrada = 0
        End If
        ycaja.Idcaja = xcaja.Idcaja
        ycaja.Codcaja = cajaActual
        ycaja.Codagencia = xcaja.Codagencia
        If xcaja.Sfinal < ycaja.Salida Then
            MsgBox("No hay saldo suficiente para realizar la transaccion, intente nuevamente." &
                              vbCr & "Saldo disponible: " & xcaja.Sfinal,
                              MsgBoxStyle.Information, "Caja")
            Return
        End If
        'actualizamos el maestro de caja
        'ingresamos el detalle en detacaja
        Dim mensaje = MessageBox.Show(Me, "¿Aplicar el movimiento a la caja actual caja?" & vbCr & "Valor a ingresar: " & txtMonto.Text, "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If mensaje = DialogResult.Cancel Then
            Return
        End If
        If dao.guardarDatosDetaCaja(dcaja, ycaja) Then
            MsgBox("Se ingresó el movimiento", MsgBoxStyle.Information, "Movimientos de caja")
            Me.imprimirVoucher()
            Me.chkImprimir.CheckState = CheckState.Unchecked
            Me.cargarSaldosCaja()
            Me.btnCancelar_Click(sender, e)
        Else
            MsgBox(dao.ErrorSms)
        End If
    End Sub

    Private Sub btnCerrarCaja_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrarCaja.Click
        Dim result As DialogResult = MessageBox.Show(Me, "¿Cerrar la caja actual?", _titleCerrarCaja, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            Return
        End If
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        If dao.cerrarCaja(cajaActual) Then
            lblSaldo.Text = "0.0"
            lblInicial.Text = "0.0"
            lblEntrada.Text = "0.0"
            lblSalida.Text = "0.0"
            MsgBox("Caja cerrada de forma correcta", MsgBoxStyle.Information, _titleCerrarCaja)
            Me.revisarEstadoCaja()
        Else
            MsgBox("Se produjo un error al intentar cerrar la caja. Revise la siguiente información: " &
                       vbCr & dao.ErrorSms, MsgBoxStyle.Critical, _titleError)
        End If
    End Sub

    Private Sub btnAbrirCaja_Click(sender As System.Object, e As System.EventArgs) Handles btnAbrirCaja.Click
        Dim result As DialogResult = MessageBox.Show(Me, "¿Desea abrir la caja actual?", _titleAbrirCaja, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            Return
        End If
        Me.cargarCaja()
        Dim dao = DataContext.daoMcaja
        If dao.abrirCaja(cajaActual, agenciaActual) Then
            MsgBox("Apertura de caja de forma correcta", MsgBoxStyle.Information, _titleAbrirCaja)
            Me.revisarEstadoCaja()
        Else
            MsgBox("Se produjo un error al intentar abrir la caja. Revise la siguiente información: " &
                       vbCr & dao.ErrorSms, MsgBoxStyle.Critical, _titleError)
        End If
    End Sub


    Private Sub cmbRubro_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbRubro.SelectedValueChanged
        Dim dao = DataContext.daoMcaja
        Dim idmov As Integer
        Try
            idmov = cmbRubro.SelectedValue
        Catch ex As Exception
        End Try
        If dao.validarMovimiento(idmov) Then
            idmovimiento = 1
        Else
            idmovimiento = 0
        End If
    End Sub

    Private Sub cmbRubro_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbRubro.SelectionChangeCommitted
        Try
            Dim idmov As Integer = cmbRubro.SelectedValue
            Me.recIdmov = idmov
            Me.validarMovmientoCaja(idmov)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnMovimientosDelDia_Click(sender As System.Object, e As System.EventArgs) Handles btnMovimientosDelDia.Click
        Using ctx As New Contexto
            Try
                Me.cargarCaja()
                Dim query = (From v In ctx.Vdetacaja
                             Where v.Fecha.Day = DateTime.Now.Day And v.Codcaja = cajaActual
                             Order By v.Fecha Ascending Select v).ToList()
                'Dim query = ctx.ExecuteQuery(Of Vdetacaja)("select * from vdetacaja where fecha = '" & Now.ToShortDateString & _
                '                                          "' and codcaja = '" & cajaActual & "' order by CAST(hora as timestamp) asc").ToList()
                Dim report As New rptCaja
                Dim frm As New frmReporteCaja
                report.SetDataSource(query)
                'ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value)
                frm.viewer.ReportSource = report
                frm.Show()
            Catch ex As Exception
                MsgBox("Error al intentar recuperar los datos de la caja, debido a: " &
                       ex.Message, MsgBoxStyle.Critical, _titleError)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReimpimirPanel.Click
        Using ctx As New Contexto
            Try
                Dim dia As String = Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day
                Dim daoParametros = DataContext.daoParametros
                Dim parametro As Ids = daoParametros.recuperarParametros()
                Dim listarMov = ctx.ExecuteQuery(Of RecibosReimprimir)(String.Format("select r.descrubro as rubro,mc.descripcion as movimiento, " &
                    "dc.efectivo, dc.cheque,dc.transferencia,dc.fecha,dc.hora " &
                    "from detacaja dc " &
                    "join movcaja mc on dc.idmov = mc.idmov " &
                    "join Rubro r on mc.codrubro = r.codrubro " &
                    "where CAST(fecha as date) = cast('{0}' as date) and dc.codcaja = '{1}' " &
                    "and mc.idmov <> {2} and mc.idmov <> {3}", dia, Me.cajaActual, parametro.idcompras, parametro.id_adelantos)).ToList
                If Me.panReimprimir.Visible = False Then
                    Me.panReimprimir.Size = New Size(643, 315)
                    Me.panReimprimir.Visible = True
                    dgvReimprimir.DataSource = listarMov
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If Me.panReimprimir.Visible = True Then
            Me.panReimprimir.Visible = False
        End If
    End Sub

    Private Sub btnReimprimir_Click(sender As Object, e As EventArgs) Handles btnReimprimir.Click
        Try
            Dim currentRow = dgvReimprimir.CurrentRow
            Dim efectivo As Decimal = currentRow.Cells(2).Value
            Dim cheque As Decimal = currentRow.Cells(3).Value
            Dim transferencia As Decimal = currentRow.Cells(4).Value
            Dim daoParametros = DataContext.daoParametros
            Dim parametro As Ids = daoParametros.recuperarParametros()
            Dim llenar As New List(Of Voucher)
            Dim voucher As New Voucher
            Dim recibe = DataContext.daoUsuario().findAll().Where(Function(u) u.Codoperador = parametro.recibe).Single()
            voucher.Caja = cajaActual
            voucher.Recibi = recibe.Nombre
            voucher.Nombre = DataContext.usuarioLog.Nombre
            If cheque > 0 Then
                voucher.Concepto = "Cheque " & cheque
                voucher.cantidadLetra = ConvertirNumeroLetros(CDec(cheque))
                voucher.Monto = CDec(cheque)
            ElseIf transferencia > 0 Then
                voucher.Concepto = "Transferencia " & transferencia
                voucher.cantidadLetra = ConvertirNumeroLetros(CDec(transferencia))
                voucher.Monto = CDec(transferencia)
            ElseIf efectivo > 0 Then
                voucher.Concepto = "Efectivo " & efectivo
                voucher.cantidadLetra = ConvertirNumeroLetros(CDec(efectivo))
                voucher.Monto = CDec(efectivo)
            End If
            llenar.Add(voucher)
            Dim reporte As New rptVoucherTransferencia
            reporte.SetDataSource(llenar)
            frmReportes.viewer.ReportSource = reporte
            frmReportes.Show()
        Catch ex As Exception
            MsgBox("Se produjo un error al intentar visualizar el voucher, rebice la siguiente información: " &
                   vbCr & ex.Message, MsgBoxStyle.Exclamation, _titleError)
        End Try
    End Sub
End Class

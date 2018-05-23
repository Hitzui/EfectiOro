Imports EfectiOro.Database
Imports System.Data.Linq.SqlClient
Imports CrystalDecisions.Shared

Public Class frmPagoCompra

    Private codigoCliente As String
    Private numeroCompra As String
    Private compraSeleccionada As Compras
    Private valorTotal As Decimal = 0D
    Private FORMATO_DECIMAL As String = "#,###,#00.00"

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        compraSeleccionada = New Compras()
    End Sub
    Sub limpiar()
        ServiciosBasicos.Limpiar_TextBox(Me)
    End Sub
    Sub cancelar()
        Me.nuevo(False)
        Me.btnNuevo.Visible = True
        If Me.dgvFiltrarCliente.Visible = True Then
            Me.dgvFiltrarCliente.Visible = False
        End If
        Me.dgvCompras.Rows.Clear()
        Me.lblPorpagar.Text = "(0.0)"
        Me.lblTotal.Text = "(0.0)"
    End Sub
    Sub llenarGrid()
        Dim dao = DataContext.daoCliente
        Dim find = dao.findAll()
        If dgvFiltrarCliente.Rows.Count <= 0 Then
            dgvFiltrarCliente.Rows.Clear()
            For Each dato As Cliente In find
                dgvFiltrarCliente.Rows.Add(dato.Codcliente, dato.Nombres, dato.Apellidos, dato.Numcedula, dato.Direccion)
            Next
        End If
    End Sub
    Private Sub llenarLista(codigo As String)
        Dim dao = DataContext.daoCompras
        Try
            Me.dgvCompras.Rows.Clear()
            Dim listar As List(Of Compras) = dao.findComprasByCodigoCliente(codigo)
            Dim filtrar As New List(Of Compras)
            filtrar.Clear()
            filtrar.AddRange((From c As Compras In listar
                       Where c.Saldo_por_pagar > 0 And c.Codestado = 1
                       Order By c.Fecha Descending
                       Select c).ToList())
            'If filtrar.Count <= 0 Then
            '    MsgBox("El cliente seleccionado no tiene compras pendientes de pago.", MsgBoxStyle.Information, "Buscar")
            '    Me.nuevo(False)
            '    Me.btnNuevo.Visible = True
            '    If Me.dgvFiltrarCliente.Visible = True Then
            '        Me.dgvFiltrarCliente.Visible = False
            '    End If
            '    Return
            'End If
            If filtrar.Count > 0 Then
                For Each dato As Compras In filtrar
                    Me.dgvCompras.Rows.Add(dato.Numcompra, dato.Fecha, dato.Saldo_por_pagar, dato.Efectivo, dato.Cheque, dato.Transferencia)
                Next
            Else
                lblTotal.Text = "(0.0)"
                lblPorpagar.Text = "(0.0)"
            End If
        Catch ex As Exception
            Dim xerror As String = ex.Message
            If dao.ErrorSms.Length > 0 Then
                xerror = ex.Message & vbCr & dao.ErrorSms
                MsgBox("Error al intentar llenar la lista de compras." & vbCr & xerror, MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub
    Sub GridFiltrarCliente(filtrar As String)
        dgvFiltrarCliente.Rows.Clear()
        If txtNombre.TextLength > 0 Then
            'filtrarmos por nombre
            Dim dao = DataContext.daoCliente
            Dim find = dao.filtrarPorNombre(filtrar)
            For Each dato As Cliente In find
                dgvFiltrarCliente.Rows.Add(dato.Codcliente, dato.Nombres, dato.Apellidos, dato.Numcedula, dato.Direccion)
            Next
        End If
        If txtCodigo.TextLength > 0 Then
            'filtramos por codigo
            Dim dao = DataContext.daoCliente
            Dim find = dao.filtrarPorCodigo(filtrar)
            For Each dato As Cliente In find
                dgvFiltrarCliente.Rows.Add(dato.Codcliente, dato.Nombres, dato.Apellidos, dato.Numcedula, dato.Direccion)
            Next
        End If
    End Sub

    Private Sub frmPagoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dgvFiltrarCliente.Visible = True Then
            dgvFiltrarCliente.Visible = False
        End If
        Me.PanelBotones.BackColor = Color.Green
        Me.limpiar()
        Me.cancelar()
        ServiciosBasicos.colorearGrid(Me.dgvCompras)
        Me.txtNombre.Focus()
        Me.lblTitulo.Text = "Aplicar pago a compra pendiente de cierre"
        Me.llenarGrid()
        Me.dgvFiltrarCliente.Size = New Size(468, 100)
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Me.GridFiltrarCliente(txtNombre.Text)
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Me.GridFiltrarCliente(txtCodigo.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_Enter(sender As Object, e As EventArgs) Handles txtNombre.Enter
        Try
            ServiciosBasicos.colorDeFondoInfo(Me.txtNombre)
            Me.dgvFiltrarCliente.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodigo_Enter(sender As Object, e As EventArgs) Handles txtCodigo.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtCodigo)
        Me.dgvFiltrarCliente.Visible = True
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave, txtCodigo.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtNombre)
        ServiciosBasicos.colorDeFondoBlanco(Me.txtCodigo)
    End Sub

    Private Sub dgvFiltrarCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvFiltrarCliente.KeyDown
        Try
            Me.codigoCliente = String.Empty
            Dim row As DataGridViewRow = dgvFiltrarCliente.CurrentRow
            Select Case e.KeyValue
                Case Keys.Enter
                    Me.codigoCliente = Convert.ToString(row.Cells("colCodcliente").Value)
                    Me.llenarLista(codigoCliente)
                    Me.txtNombre.Text = Convert.ToString(row.Cells("colNombre").Value) & " " & Convert.ToString(row.Cells("colApellidos").Value)
                    Me.txtCodigo.Text = codigoCliente
                    Me.dgvFiltrarCliente.Visible = False
            End Select
        Catch ex As Exception
            'MsgBox("Error en el Grid, producido por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                e.Handled = True
            Case ChrW(Keys.Down)
                Me.dgvFiltrarCliente.Focus()
        End Select
    End Sub

    Private Sub txtNombre_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                Me.dgvFiltrarCliente.Focus()
        End Select
    End Sub

    Private Sub txtCodigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                Me.dgvFiltrarCliente.Focus()
        End Select
    End Sub



#Region "Colores de fondos en TextBox"
    Private Sub txtEfectivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEfectivo.KeyPress
        ServiciosBasicos.NumeroDec(e, Me.txtEfectivo)
    End Sub

    Private Sub txtTransferencia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransferencia.KeyPress
        ServiciosBasicos.NumeroDec(e, Me.txtTransferencia)
    End Sub

    Private Sub txtCheque_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheque.KeyPress
        ServiciosBasicos.NumeroDec(e, Me.txtCheque)
    End Sub

    Private Sub txtEfectivo_Enter(sender As System.Object, e As System.EventArgs) Handles txtEfectivo.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtEfectivo)
    End Sub

    Private Sub txtTransferencia_Enter(sender As System.Object, e As System.EventArgs) Handles txtTransferencia.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtTransferencia)
    End Sub

    Private Sub txtCheque_Enter(sender As System.Object, e As System.EventArgs) Handles txtCheque.Enter
        ServiciosBasicos.colorDeFondoInfo(Me.txtCheque)
    End Sub

    Private Sub txtEfectivo_Leave(sender As System.Object, e As System.EventArgs) Handles txtEfectivo.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtEfectivo)
    End Sub

    Private Sub txtTransferencia_Leave(sender As System.Object, e As System.EventArgs) Handles txtTransferencia.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtTransferencia)
    End Sub

    Private Sub txtCheque_Leave(sender As System.Object, e As System.EventArgs) Handles txtCheque.Leave
        ServiciosBasicos.colorDeFondoBlanco(Me.txtCheque)
    End Sub

#End Region

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim daoCompra = DataContext.daoCompras
        Dim config As New ConfiguracionGeneral
        Dim parametros As Ids
        Dim caja, agencia As String
        Dim dao = DataContext.daoParametros
        Dim modCaja As Mcaja
        Dim daoMcaja = DataContext.daoMcaja
        Try
            caja = config.getCaja()
            agencia = config.getAgencia()
            modCaja = daoMcaja.recuperarSaldoCaja(caja)
            parametros = dao.recuperarParametros()
            Dim xefectivo As Decimal = 0D
            Dim suma As Decimal = 0D
            Dim xcheque As Decimal = 0D
            Dim xtransferencia As Decimal = 0D
            If Me.txtEfectivo.TextLength > 0 Then
                xefectivo = Convert.ToDecimal(Me.txtEfectivo.Text)
            End If
            If Me.txtCheque.TextLength > 0 Then
                xcheque = Convert.ToDecimal(Me.txtCheque.Text)
            End If
            If Me.txtTransferencia.TextLength > 0 Then
                xtransferencia = Convert.ToDecimal(Me.txtTransferencia.Text)
            End If
            suma = xefectivo + xcheque + xtransferencia
            If suma = 0 Then
                MsgBox("No ha especificado un monto para realizar la transacción.", MsgBoxStyle.Information, "Guardar")
                Return
            End If
            If xefectivo > 0 Then
                Me.compraSeleccionada.Efectivo += xefectivo
            End If
            If xcheque > 0 Then
                Me.compraSeleccionada.Cheque += xcheque
            End If
            If xtransferencia > 0 Then
                Me.compraSeleccionada.Transferencia += xtransferencia
            End If
            'restamos el efectivo por el saldo que tiene pendiente
            If suma <= Me.compraSeleccionada.Saldo_por_pagar Then
                Me.compraSeleccionada.Saldo_por_pagar -= suma
            Else
                MsgBox("El monto a aplicar es mayor que el saldo pendiente por pagar", MsgBoxStyle.Information, "Guardar")
                Return
            End If
            If Me.compraSeleccionada.Saldo_por_pagar = 0 Then
                Me.compraSeleccionada.Codestado = 2
            End If
            If MsgBox("¿Actualizar la compra seleccionada?", MsgBoxStyle.YesNo, "Guardar") = MsgBoxResult.No Then
                Return
            End If
            'creamos el movimiento del detalle del maestro de caja
            Dim detaCaja As New Detacaja
            detaCaja.codcaja = caja
            detaCaja.idmov = parametros.Cierre_compra
            detaCaja.idcaja = modCaja.Idcaja
            detaCaja.fecha = Now
            detaCaja.concepto = "***CANCELA COMPRA: " & Me.compraSeleccionada.Numcompra & "***"
            detaCaja.referencia = "CANCELA COMPRA: " & Me.compraSeleccionada.Numcompra
            detaCaja.efectivo = xefectivo
            detaCaja.cheque = xcheque
            detaCaja.transferencia = xtransferencia
            detaCaja.hora = Now.ToLongTimeString
            'especificamo la salida de dinero
            modCaja.Salida = xefectivo
            modCaja.Entrada = Decimal.Zero
            If modCaja.Sfinal = 0 And xefectivo > 0 Then
                MsgBox("No hay saldo para poder realizar la compra", MsgBoxStyle.Critical, "Guardar compra")
                Return
            End If
            If modCaja.Sfinal < suma And xefectivo > 0 Then
                MsgBox("No hay saldo suficiente para realizar la transaccion, intente nuevamente." & _
                       vbCr & "Saldo disponible: " & modCaja.Sfinal, _
                       MsgBoxStyle.Information, "Guardar compra")
                Return
            End If
            If daoMcaja.validarCajaAbierta(caja) = False Then
                MsgBox("La caja actual quedó abierta del día anterior, por favor cierre y vuelva abrir la caja", _
                       MsgBoxStyle.Critical, "Guardar compra")
                Return
            End If
            If daoCompra.actualizarCompra(compraSeleccionada) Then
                daoMcaja.guardarDatosDetaCaja(detaCaja, modCaja)
                Dim daoCliente As IDaoCliente = New DaoCliente
                Dim listar As New List(Of Compras)
                listar.Add(compraSeleccionada)
                Dim preg As DialogResult = MsgBox("Se ha actualizado la compra seleccionada de forma correcta. " & vbCr & "¿Imprimir el recibo de pago?", MsgBoxStyle.YesNo, "Guardar")
                If preg = Windows.Forms.DialogResult.Yes Then
                    Dim param As ParameterFields = New ParameterFields()
                    Dim parMontoLetra As ParameterField = New ParameterField()
                    Dim parMonto As ParameterField = New ParameterField()
                    Dim disMontoLetra As ParameterDiscreteValue = New ParameterDiscreteValue()
                    Dim disMonto As ParameterDiscreteValue = New ParameterDiscreteValue()
                    'esta variable es para guardar el valor que se le esta dando,
                    'ya sea efectivo o cheque o transferencia
                    Dim montoPagar As Decimal = Decimal.Zero
                    parMontoLetra.ParameterFieldName = "Monto_letra"
                    parMonto.ParameterFieldName = "Valor"
                    parMonto.ParameterValueType = ParameterValueKind.NumberParameter
                    If txtEfectivo.Text.Trim.Length > 0 Then
                        montoPagar = Decimal.Add(montoPagar, Convert.ToDecimal(txtEfectivo.Text))
                    End If
                    If txtCheque.Text.Trim.Length > 0 Then
                        montoPagar = Decimal.Add(montoPagar, Convert.ToDecimal(txtCheque.Text))
                    End If
                    If txtTransferencia.Text.Trim.Length > 0 Then
                        montoPagar = Decimal.Add(montoPagar, Convert.ToDecimal(txtTransferencia.Text))
                    End If
                    disMontoLetra.Value = ConvertirNumeroLetros(Convert.ToDecimal(montoPagar))
                    disMonto.Value = Convert.ToDecimal(montoPagar)
                    parMontoLetra.CurrentValues.Add(disMontoLetra)
                    parMonto.CurrentValues.Add(disMonto)
                    param.Add(parMontoLetra)
                    param.Add(parMonto)
                    Dim reportRecibo As New rptPagoCompraPendiente
                    reportRecibo.Database.Tables(0).SetDataSource(daoCliente.findAll())
                    reportRecibo.Database.Tables(1).SetDataSource(listar)
                    frmReporteCompra.viewer.ParameterFieldInfo = param
                    frmReporteCompra.viewer.ReportSource = reportRecibo
                    frmReporteCompra.Show()
                End If
                btnCancelar_Click(sender, e)
            Else
                MsgBox("Se produjo el siguiente error: " & vbCr & daoCompra.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error global al intentar actualizar la compra: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub nuevo(opcion As Boolean)
        Me.txtNombre.Enabled = opcion
        Me.txtCodigo.Enabled = opcion
        Me.chkCheque.Enabled = opcion
        Me.chkEfectivo.Enabled = opcion
        Me.chkTransferencia.Enabled = opcion
        Me.txtEfectivo.Enabled = opcion
        Me.txtCheque.Enabled = opcion
        Me.txtTransferencia.Enabled = opcion
        Me.limpiar()
        Me.txtNombre.Focus()
        Me.btnCancelar.Enabled = opcion
        Me.btnGuardar.Visible = opcion
    End Sub
    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.nuevo(True)
        Me.llenarGrid()
        Me.btnNuevo.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.cancelar()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs)
        btnCancelar_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub chkEfectivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEfectivo.CheckedChanged
        If Me.chkEfectivo.CheckState = CheckState.Checked Then
            Me.txtEfectivo.Visible = True
            Me.txtEfectivo.Focus()
        Else
            Me.txtEfectivo.Visible = False
            Me.txtEfectivo.Clear()
        End If
    End Sub

    Private Sub chkTransferencia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTransferencia.CheckedChanged
        If Me.chkTransferencia.CheckState = CheckState.Checked Then
            Me.txtTransferencia.Visible = True
            Me.txtTransferencia.Focus()
        Else
            Me.txtTransferencia.Visible = False
            Me.txtTransferencia.Clear()
        End If
    End Sub

    Private Sub chkCheque_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheque.CheckedChanged
        If Me.chkCheque.CheckState = CheckState.Checked Then
            Me.txtCheque.Visible = True
            Me.txtCheque.Focus()
        Else
            Me.txtCheque.Visible = False
            Me.txtCheque.Clear()
        End If
    End Sub

    Private Sub seleccionarCompraGrid()
        Dim dao = DataContext.daoCompras
        Try
            Dim config As New ConfiguracionGeneral
            Dim _agencia As String = config.getAgencia
            Dim row As DataGridViewRow = dgvCompras.CurrentRow
            Me.numeroCompra = CStr(row.Cells("colNumcompra").Value)
            Me.compraSeleccionada = New Compras()
            Dim xcompra As Compras = dao.findCompraById(Me.numeroCompra, _agencia)
            Me.compraSeleccionada = xcompra
            Me.lblTotal.Text = xcompra.Total.ToString(FORMATO_DECIMAL)
            Me.lblPorpagar.Text = xcompra.Saldo_por_pagar.ToString(FORMATO_DECIMAL)
            Me.valorTotal = xcompra.Total
        Catch ex As Exception
            If dao.ErrorSms.Length > 0 Then
                Dim xerror As String = ex.Message & vbCr & dao.ErrorSms
                MsgBox("No se pudo encontra la compra indicada debido a un error." & vbCr & _
                       "Error: " & xerror, MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub


    Private Sub dgvCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompras.CellClick
        Me.seleccionarCompraGrid()
    End Sub

    Private Sub dgvCompras_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCompras.SelectionChanged
        Me.seleccionarCompraGrid()
    End Sub

    Private Sub dgvFiltrarCliente_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFiltrarCliente.CellDoubleClick
        Try
            Me.codigoCliente = String.Empty
            Dim row As DataGridViewRow = dgvFiltrarCliente.CurrentRow
            Me.codigoCliente = Convert.ToString(row.Cells("colCodcliente").Value)
            Me.llenarLista(codigoCliente)
            Me.txtNombre.Text = Convert.ToString(row.Cells("colNombre").Value) & " " & _
                Convert.ToString(row.Cells("colApellidos").Value)
            Me.txtCodigo.Text = codigoCliente
            Me.dgvFiltrarCliente.Visible = False
        Catch ex As Exception
            'MsgBox("Error en el Grid, producido por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvFiltrarCliente_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvFiltrarCliente.SelectionChanged
        Dim dao = DataContext.daoCompras
        Try
            Me.dgvCompras.Rows.Clear()
            Dim row As DataGridViewRow = dgvFiltrarCliente.CurrentRow
            Dim codigo As String = CStr(row.Cells("colCodcliente").Value)
            Me.llenarLista(codigo)
        Catch ex As Exception
            MsgBox("Se produjo un error al intentar filtrar la compras pendientes de pago." & _
                   vbCr & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtEfectivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEfectivo.KeyDown, txtCheque.KeyDown, txtTransferencia.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnGuardar.Focus()
        End Select
    End Sub
End Class

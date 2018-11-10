Imports System.Data.Linq.SqlClient
Imports System.Data.SqlClient
Imports EfectiOro.Database

Public Class frmCompras
    Private Const tituloError As String = "Error"
#Region "Properties"
    Public Shared _codmoneda As Integer = 0
    Dim config As New ConfiguracionGeneral
    Dim agencia As String
    Private bsCliente As New BindingSource
    Private auxiliar As Integer
    Private _compraActual As Compras
    'Dim daoCliente As IDaoCliente
    Private _preciosSeleccionados As List(Of Precios)
    Public ReadOnly Property precio_seleccionado() As List(Of Precios)
        Get
            If _preciosSeleccionados.Count = 0 Then
                Return New List(Of Precios)
            End If
            Return _preciosSeleccionados
        End Get
    End Property
    Public ReadOnly Property CompraActual As Compras
        Get
            Return _compraActual
        End Get
    End Property
    Private _detalleComprasActual
    Public ReadOnly Property DetalleComprasActual As List(Of Det_compra)
        Get
            Return _detalleComprasActual
        End Get
    End Property
    Private _clienteActual As Cliente
    Public ReadOnly Property ClienteActual As Cliente
        Get
            Return _clienteActual
        End Get
    End Property

    ''' <summary>
    ''' Guarda el total de la compra, para luego poder validar al guardar si se ha ingresado el total correcto
    ''' </summary>
    ''' <value>0</value>
    ''' <returns>Deicmal</returns>
    ''' <remarks>Total de la compra</remarks>
    Public Property totalGeneral As Decimal
    Public Property aplicarAdelanto As Decimal
    Public verAdelanto As List(Of Adelantos)
    Private Property compraEncontrada As Boolean
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.verAdelanto = New List(Of Adelantos)
        Me.totalGeneral = 0D
        _preciosSeleccionados = New List(Of Precios)
        agencia = config.getAgencia
    End Sub
#End Region
#Region "Imprimir compra"
    Sub imprimirCompra(numero_compra As String)
        If MessageBox.Show("¿Visualizar la compra para poder imprimirla?", "Imprimir",
        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Dim dao = DataContext.daoCompras
            dao.imprimirCompra(numero_compra)
            numero_compra = String.Empty
        End If
    End Sub
#End Region
    Sub deshabilitarChecBox(opcion As Boolean)
        checAdelantos.Checked = opcion
        checEfectivo.Checked = opcion
        checTransferencias.Checked = opcion
        checCheque.Checked = opcion
        checPorpagar.Checked = opcion
    End Sub
    Sub filtrarCompra()
        Using ctx As New Contexto
            Try
                'estado de compras
                ' 0 = Anulada
                ' 1 = Vigente
                ' 2 = Cerrada
                ' 3 = Descargada
                Dim filtrar = (From c In ctx.Compras Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                               Where c.Codestado = 1 Or c.Codestado = 2 Order By Convert.ToInt32(c.Numcompra) Ascending
                               Select c.Numcompra, cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Direccion, c.Codagencia).ToList()
                dgvBuscar_compra.Rows.Clear()
                For Each dato In filtrar.Where(Function(c) c.Codagencia = agencia And c.Numcompra.Contains(txtNumcompra.Text)).ToList()
                    Me.dgvBuscar_compra.Rows.Add(dato.Numcompra, dato.Codcliente, dato.Nombres, dato.Apellidos, dato.Direccion)
                Next
            Catch ex As Exception
                MsgBox("Error fatal: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub
    Sub filtrarCliente()
        Try
            Dim daoCliente = DataContext.daoCliente
            Dim listar As List(Of Cliente) = daoCliente.filtrarPorNombre(txtNomcliente.Text)
            bsCliente.DataSource = listar
            ClienteBindingSource.DataSource = bsCliente
        Catch ex As Exception
            MsgBox("Error al intentar filtrar los datos, producido por: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub visibilidadFormaPago(opcion As Boolean)
        For Each Control As Control In Me.Controls
            If TypeOf Control Is GroupBox Then
                Dim gr As GroupBox = Control
                If gr.Name = "grupoDetalle" Then
                    For Each valor In gr.Controls
                        If TypeOf valor Is TextBox Then
                            Dim txt As TextBox = valor
                            txt.Visible = opcion
                        End If
                    Next
                End If
            End If
        Next
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub recuperarCodigo()
        Dim dao = DataContext.daoCompras
        txtNumcompra.Text = dao.codigoCompra()
    End Sub
    Private Sub revisarAdelanto(codigo As String)
        'revisamos si el cliente actual tiene adelantos
        'le mostramos que el cliene tiene un saldo
        Dim daoAdelanto = DataContext.daoAdelantos
        Try
            verAdelanto = daoAdelanto.listarAdelantosPorClientes(codigo)
            Dim saldo As Decimal = 0D
            For Each dato As Adelantos In verAdelanto
                saldo += dato.Saldo
            Next
            If saldo > 0 Then
                MsgBox("El cliente seleccionado tiene adelanto con un saldo pendiente de: " & saldo, MsgBoxStyle.Information, "Adelanto de cliente")
                checAdelantos.Enabled = True
            End If
        Catch ex As Exception
            'esta instruccion queda en vacio, solo si el cliente no tiene adelanto
            checAdelantos.Enabled = False
        End Try
    End Sub
    Private Function comprobarTotales() As Boolean
        Dim efectivo, transaccion, cheque, porpagar, adelantos, suma, xvalor As Decimal
        If txtEfectivo.TextLength > 0 Then
            efectivo = Convert.ToDecimal(txtEfectivo.Text)
        Else
            efectivo = Decimal.Zero
        End If
        If txtTransferencia.TextLength > 0 Then
            transaccion = Convert.ToDecimal(txtTransferencia.Text)
        Else
            transaccion = Decimal.Zero
        End If
        If txtCheque.TextLength > 0 Then
            cheque = Convert.ToDecimal(txtCheque.Text)
        Else
            cheque = Decimal.Zero
        End If
        If txtPorpagar.TextLength > 0 Then
            porpagar = Convert.ToDecimal(txtPorpagar.Text)
        Else
            porpagar = Decimal.Zero
        End If
        If txtAdelantos.TextLength > 0 Then
            adelantos = Convert.ToDecimal(txtAdelantos.Text)
        Else
            adelantos = Decimal.Zero
        End If
        'asignamos el total a la variable
        If txtTotal.TextLength > 0 Then
            xvalor = Convert.ToDecimal(txtTotal.Text)
        End If
        'sumamos los valores
        suma = efectivo + transaccion + cheque + porpagar + adelantos
        'comparamos si son iguales
        If xvalor <> suma Then
            Return False
        Else
            totalGeneral = suma
            Return True
        End If
    End Function
    Sub limpiarFormaPago()
        txtCheque.Clear()
        txtTransferencia.Clear()
        txtPorpagar.Clear()
        txtAdelantos.Clear()
        txtEfectivo.Clear()
    End Sub
    Sub limpiarCliente()
        txtCodcliente.Clear()
        txtNomcliente.Clear()
        txtApecliente.Clear()
        txtDircliente.Clear()
    End Sub
    Sub limpiarPrecios()
        txtPeso.Clear()
        txtImporte.Clear()
        txtPrecio.Clear()
    End Sub
    Sub habilitarBotones(nuevo As Boolean, guardar As Boolean, editar As Boolean, cancelar As Boolean, buscar As Boolean, imprimir As Boolean)
        btnGuardar.Enabled = guardar
        btnNueva.Enabled = nuevo
        btnCancelar.Enabled = cancelar
        btnEditar.Enabled = editar
        btnBuscar.Enabled = buscar
        btnImprimir.Enabled = imprimir
    End Sub
    Sub habilitarCampos(opcion As Boolean)
        txtCodcliente.Enabled = opcion
        txtNomcliente.Enabled = opcion
        txtApecliente.Enabled = opcion
        txtDircliente.Enabled = opcion

    End Sub
    Sub habilitarGrupos(cliente As Boolean, item As Boolean, lista As Boolean, detalle As Boolean)
        grupoCliente.Enabled = cliente
        grupoItem.Enabled = item
        grupoDetalle.Enabled = detalle
        grupoLista.Enabled = lista
    End Sub
    Sub llenarComboKilate()
        Dim dao = DataContext.daoPrecioKilate
        Dim listaPrecios = dao.listaPreciosCliente(txtCodcliente.Text)
        If listaPrecios.Count <= 0 Then
            cmbPrecios2.DataSource = dao.findAll()
            cmbPrecios2.ValueMember = "Kilate_peso"
            cmbPrecios2.DisplayMember = "Kilate_peso"
        Else
            cmbPrecios2.DataSource = dao.preciosClientes(txtCodcliente.Text)
            cmbPrecios2.ValueMember = "Gramos"
            cmbPrecios2.DisplayMember = "Kilate"
        End If
    End Sub

    Sub buscarPrecio()
        Dim dao = DataContext.daoPrecioKilate
        Try
            Dim listaprecios = dao.listaPreciosCliente(txtCodcliente.Text)
            If listaprecios.Count <= 0 Then
                Dim value = cmbPrecios2.SelectedRow.Cells(0).Value
                Dim value1 = cmbPrecios2.SelectedRow.Cells(1).Value
                Dim value2 = cmbPrecios2.SelectedRow.Cells(2).Value
                Dim precio As Decimal = dao.findByvDescripcion(value).Precio_kilate
                txtPrecio.Text = precio
            Else
                Dim kilate = cmbPrecios2.SelectedRow.Cells(0).Value
                Dim precio = cmbPrecios2.SelectedRow.Cells(1).Value
                Dim gramos = cmbPrecios2.SelectedRow.Cells(2).Value
                Dim findPrecio = (From p In listaprecios Where p.Gramos = gramos And p.Kilate = kilate Select p).Single
                txtPrecio.Text = Convert.ToString(findPrecio.Precio)
                txtPeso.Text = Convert.ToString(findPrecio.Gramos)
            End If
        Catch ex As Exception
            MsgBox("Establesca los precios del oro para poder ingresar la compra", MsgBoxStyle.Information, "Compras")
        End Try
    End Sub
    Sub calcularTotales()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvCompras.Rows
            total += row.Cells(4).Value
        Next
        txtTotal.Text = total.ToString("#,###,###,###.00")
        Me.totalGeneral = total
    End Sub
    Sub agregarAlGrid()
        Try
            Dim total As Decimal
            Dim linea As Integer = 0
            linea = dgvCompras.Rows.Count + 1
            dgvCompras.Rows.Add(linea, cmbPrecios2.SelectedRow.Cells(0).Value, txtPeso.Text, txtPrecio.Text, txtImporte.Text)
            total = 0
            For Each row As DataGridViewRow In dgvCompras.Rows
                total += row.Cells(4).Value
            Next
            txtTotal.Text = total.ToString("#,###,###,###.00")
            Me.totalGeneral = total
            dgvCompras.AutoGenerateColumns = True
        Catch ex As Exception

        End Try
    End Sub
    Sub calcularPrecio()
        Try
            Dim precio, peso, suma As Decimal
            Dim linea As Integer = 0
            If txtPrecio.TextLength <= 0 Then
                precio = 0
            Else
                precio = Convert.ToDecimal(txtPrecio.Text)
            End If
            If txtPeso.TextLength <= 0 Then
                peso = 0
            Else
                peso = Convert.ToDecimal(txtPeso.Text)
            End If
            suma = peso * precio
            txtImporte.Text = suma.ToString("#,###,#00.00")
        Catch ex As Exception
            MsgBox("No se pudo calcular el precio: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    ''' <summary>
    ''' Cargar los datos del tipo de moneda al formulario
    ''' </summary>
    Private Sub cargarMoneda()
        Using ctx As New Contexto
            Try
                Dim monedas = ctx.Moneda.ToList
                cmbMoneda.DataSource = monedas
                cmbMoneda.DisplayMember = "Descripcion"
                cmbMoneda.ValueMember = "codmoneda"
            Catch ex As Exception

            End Try
        End Using
    End Sub
    Private Sub frmCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.compraEncontrada = False
        Me.cmbEstado.SelectedIndex = 1
        cargarMoneda()
        'Me.filtrarCliente()
        Me.recuperarCodigo()
        Me.habilitarGrupos(False, False, False, False)
        lblTitulo.Text = "Formulario de Compras - EfectiOro"
        dgvFiltrarCliente.Visible = False
        ServiciosBasicos.colorearGrid(dgvCompras)
        ServiciosBasicos.colorearGrid(dgvFiltrarCliente)
        'Me.llenarComboKilate()
        'Me.buscarPrecio()
    End Sub

    Private Sub checEfectivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checEfectivo.CheckedChanged
        If checEfectivo.CheckState = CheckState.Checked Then
            Me.txtEfectivo.Enabled = True
            txtEfectivo.Visible = True
            txtEfectivo.Clear()
            txtEfectivo.Focus()
        End If
        If checEfectivo.CheckState = CheckState.Unchecked Then
            txtEfectivo.Visible = False
            txtEfectivo.Clear()
        End If
    End Sub

    Private Sub checCheque_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checCheque.CheckedChanged
        If checCheque.CheckState = CheckState.Checked Then
            txtCheque.Visible = True
            txtCheque.Clear()
            txtCheque.Focus()
        End If
        If checCheque.CheckState = CheckState.Unchecked Then
            txtCheque.Visible = False
            txtCheque.Clear()
        End If
    End Sub

    Private Sub checPorpagar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checPorpagar.CheckedChanged
        If checPorpagar.CheckState = CheckState.Checked Then
            txtPorpagar.Visible = True
            txtPorpagar.Clear()
            txtPorpagar.Focus()
        End If
        If checPorpagar.CheckState = CheckState.Unchecked Then
            txtPorpagar.Visible = False
            txtPorpagar.Clear()
        End If
    End Sub

    Private Sub checTransferencias_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checTransferencias.CheckedChanged
        If checTransferencias.CheckState = CheckState.Checked Then
            txtTransferencia.Visible = True
            txtTransferencia.Clear()
            txtTransferencia.Focus()
        End If
        If checTransferencias.CheckState = CheckState.Unchecked Then
            txtTransferencia.Visible = False
            txtTransferencia.Clear()
        End If
    End Sub

    Private Sub checAdelantos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checAdelantos.CheckedChanged
        If checAdelantos.CheckState = CheckState.Checked Then
            txtAdelantos.Visible = True
            btnAdelantos.Visible = True
            txtAdelantos.Clear()
            txtAdelantos.Focus()
        End If
        If checAdelantos.CheckState = CheckState.Unchecked Then
            txtAdelantos.Visible = False
            btnAdelantos.Visible = False
            txtAdelantos.Clear()
        End If
    End Sub

#Region "Textos"
    Private Sub txtCodcliente_Enter(sender As System.Object, e As System.EventArgs) Handles txtCodcliente.Enter
        ServiciosBasicos.colorDeFondoInfo(txtCodcliente)
        dgvFiltrarCliente.Size = New Size(440, 130)
        dgvFiltrarCliente.Visible = True
    End Sub

    Private Sub txtNomcliente_Enter(sender As System.Object, e As System.EventArgs) Handles txtNomcliente.Enter
        ServiciosBasicos.colorDeFondoInfo(txtNomcliente)
        dgvFiltrarCliente.Size = New Size(440, 100)
        dgvFiltrarCliente.Visible = True
    End Sub

    Private Sub txtApecliente_Enter(sender As System.Object, e As System.EventArgs) Handles txtApecliente.Enter
        ServiciosBasicos.colorDeFondoInfo(txtApecliente)
        dgvFiltrarCliente.Size = New Size(440, 100)
        dgvFiltrarCliente.Visible = True
    End Sub

    Private Sub txtDircliente_Enter(sender As System.Object, e As System.EventArgs) Handles txtDircliente.Enter
        ServiciosBasicos.colorDeFondoInfo(txtDircliente)
    End Sub

    Private Sub txtCodcliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtCodcliente.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtCodcliente)
    End Sub

    Private Sub txtNomcliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtNomcliente.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtNomcliente)
    End Sub

    Private Sub txtApecliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtApecliente.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtApecliente)
    End Sub

    Private Sub txtDircliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtDircliente.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtDircliente)
    End Sub

    Private Sub txtCodcliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodcliente.KeyPress
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Down)
        End Select
    End Sub

    Private Sub txtNomcliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomcliente.KeyPress

    End Sub

    Private Sub txtApecliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApecliente.KeyPress

    End Sub

    Private Sub txtDircliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDircliente.KeyPress

    End Sub
#End Region

    Private Sub txtNomcliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomcliente.TextChanged
        Me.filtrarCliente()
        If txtNomcliente.TextLength > 0 Then
            erp.SetError(txtNomcliente, "")
        End If
    End Sub

    Private Sub txtCodcliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodcliente.TextChanged
        Dim dao = DataContext.daoCliente
        Dim listar As List(Of Cliente) = dao.filtrarPorCodigo(txtCodcliente.Text)
        bsCliente.DataSource = listar
        ClienteBindingSource.DataSource = bsCliente
        If txtCodcliente.TextLength > 0 Then
            erp.SetError(txtCodcliente, "")
        End If
    End Sub

    Private Sub txtApecliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApecliente.TextChanged
        Dim dao = DataContext.daoCliente
        Dim listar As List(Of Cliente) = dao.filtrarPorApellido(txtApecliente.Text)
        bsCliente.DataSource = listar
        ClienteBindingSource.DataSource = bsCliente
    End Sub

    Private Sub txtCodcliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodcliente.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                dgvFiltrarCliente.Focus()
            Case Keys.Enter
                txtNomcliente.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtNomcliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNomcliente.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                dgvFiltrarCliente.Focus()
            Case Keys.Enter
                txtApecliente.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txtApecliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApecliente.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                dgvFiltrarCliente.Focus()
            Case Keys.Enter
                txtDircliente.Focus()
                e.Handled = True
        End Select
    End Sub
    Private Sub txtDircliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDircliente.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                cmbPrecios2.Focus()
                e.Handled = True
        End Select
    End Sub
    Private Sub dgvFiltrarCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvFiltrarCliente.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter
                    Dim dao = DataContext.daoCliente
                    Dim row As DataGridViewRow = dgvFiltrarCliente.CurrentRow
                    _clienteActual = dao.findById(row.Cells("colCodcliente").Value)
                    txtCodcliente.Text = _clienteActual.Codcliente
                    txtNomcliente.Text = _clienteActual.Nombres
                    txtApecliente.Text = _clienteActual.Apellidos
                    txtDircliente.Text = _clienteActual.Direccion
                    Me.revisarAdelanto(_clienteActual.Codcliente)
                    dgvFiltrarCliente.Visible = False
                    llenarComboKilate()
                    cmbPrecios2.Focus()
                Case Keys.Escape
                    dgvFiltrarCliente.Visible = False
                    cmbPrecios2.Focus()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, tituloError)
        End Try
    End Sub

    Private Sub cmbDescripcion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        Try
            Select Case e.KeyValue
                Case Keys.Enter
                    txtPeso.Focus()
                    e.Handled = True
            End Select
        Catch ex As Exception
            MsgBox("Error al intentar actualizar el precio" & vbCr & ex.Message, MsgBoxStyle.Critical, tituloError)
        End Try
    End Sub

    Private Sub txtPeso_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPeso.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter
                    btnAgregar.Focus()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If Me.txtImporte.TextLength <= 0 Then
            MsgBox("No se ha indicado el importe al item seleccionado, intente nuevamente", MsgBoxStyle.Information, "Compras")
            Me.txtPrecio.Focus()
            Return
        End If
        If txtPrecio.TextLength <= 0 Then
            erp.SetError(txtPrecio, "Especifique el precio del item")
            txtPrecio.Focus()
            Return
        End If
        If txtPeso.TextLength <= 0 Then
            erp.SetError(txtPeso, "Especifique el peso del item")
            txtPeso.Focus()
            Return
        End If
        Me.calcularPrecio()
        Me.agregarAlGrid()
        Dim daoPrecios = DataContext.daoPrecioKilate
        Dim preciosClientes = daoPrecioKilate.listaPreciosCliente(txtCodcliente.Text)
        If preciosClientes.Count > 0 Then
            Dim kilate = cmbPrecios2.SelectedRow.Cells(0).Value
            Dim precio = cmbPrecios2.SelectedRow.Cells(1).Value
            Dim gramos = cmbPrecios2.SelectedRow.Cells(2).Value
            Dim buscar_precio = (From p In preciosClientes Where p.Kilate = kilate And p.Gramos = gramos Select p).Single
            _preciosSeleccionados.Add(buscar_precio)
        End If
        cmbPrecios2.Focus()
        Me.limpiarPrecios()
        erp.Clear()
    End Sub



    Private Sub txtPeso_Leave(sender As System.Object, e As System.EventArgs) Handles txtPeso.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtPeso)
        Me.calcularPrecio()
    End Sub

    Private Sub txtPeso_Enter(sender As System.Object, e As System.EventArgs) Handles txtPeso.Enter
        ServiciosBasicos.colorDeFondoInfo(txtPeso)
    End Sub


    Private Sub txtPeso_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPeso.TextChanged
        If txtPeso.TextLength > 0 Then
            erp.SetError(txtPeso, "")
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click
        Try
            Dim result As DialogResult = MsgBox("¿Seguro desea quitar el item seleccionado de la lista?", MsgBoxStyle.YesNo, "Compras")
            If result = Windows.Forms.DialogResult.No Then
                Return
            End If
            Dim fila As DataGridViewRow = dgvCompras.CurrentRow
            Dim precio As Decimal = Convert.ToDecimal(fila.Cells("colPrecio").Value)
            Dim kilate As Decimal = Convert.ToDecimal(fila.Cells("colDescripcion").Value)
            Dim peso As Decimal = Convert.ToDecimal(fila.Cells("colPeso").Value)
            Using ctx As New Contexto
                Dim remove_precio = _preciosSeleccionados.Find(Function(p) p.Gramos = peso And p.Kilate = kilate)
                _preciosSeleccionados.Remove(remove_precio)
            End Using
            dgvCompras.Rows.Remove(fila)
            Dim linea As Integer = 0
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In dgvCompras.Rows
                linea += 1
                row.Cells(0).Value = linea
                total += row.Cells(4).Value
            Next
            txtTotal.Text = total.ToString("#,###,###,###.00")
        Catch ex As Exception
            MsgBox("Error al quitar los valores: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnNueva_Click(sender As System.Object, e As System.EventArgs) Handles btnNueva.Click
        Me.auxiliar = 1
        Me.habilitarBotones(False, True, False, True, False, False)
        Me.habilitarGrupos(True, True, True, True)
        Me.limpiarPrecios()
        Me.limpiarCliente()
        txtNomcliente.Focus()
        Me.cmbEstado.Enabled = True
        Me.cmbEstado.SelectedIndex = 1
        cmbMoneda.Enabled = True
        Me.btnCerrarcompra.Enabled = False
        'Me.filtrarCliente()
        'MsgBox(cmbMoneda.SelectedValue & " - " & cmbMoneda.SelectedItem.Descripcion)
        _codmoneda = CInt(cmbMoneda.SelectedValue)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.cmbEstado.Enabled = False
        cmbMoneda.Enabled = False
        If Me.panelBuscar_compra.Visible = True Then
            Me.panelBuscar_compra.Visible = False
        End If
        Me.txtNumcompra.ReadOnly = True
        Me.recuperarCodigo()
        Me.dgvFiltrarCliente.Visible = False
        Me.habilitarGrupos(False, False, False, False)
        Me.habilitarBotones(True, False, True, False, False, False)
        Me.limpiarPrecios()
        Me.limpiarCliente()
        Me.limpiarFormaPago()
        Me.checAdelantos.Enabled = False
        Me.dgvCompras.Rows.Clear()
        Me.txtTotal.Clear()
        Me.totalGeneral = Decimal.Zero
        Me.deshabilitarChecBox(False)
        Me.visibilidadFormaPago(False)
        Me.erp.Clear()
        Me.btnAnular.Enabled = False
        Me.checEfectivo.Enabled = True
        'Me.filtrarCliente()
        Me.compraEncontrada = False
        Me.btnCerrarcompra.Enabled = True
        Me.txtFecha.Value = Now
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        'Dim result As DialogResult = MsgBox("¿Guardar la compra actual?", MsgBoxStyle.YesNo, "Guardar compra")
        'If result = Windows.Forms.DialogResult.No Then
        '    Return
        'End If
        If dgvCompras.Rows.Count = 0 Then
            MsgBox("No hay datos que guardar, la lista se encuentra vacia, intente nuevamente", MsgBoxStyle.Information, "Guardar compra")
            ServiciosBasicos.agregarAlLog(Me, "Guardar compra", "No hay datos en el grid a guardar")
            Return
        End If
        If txtNomcliente.TextLength <= 0 Then
            erp.SetError(txtNomcliente, "Especifique el nombre del cliente para continuar")
            txtNomcliente.Focus()
            Return
        End If
        If txtCodcliente.TextLength <= 0 Then
            erp.SetError(txtCodcliente, "Especifique el codigo del cliente")
            txtCodcliente.Focus()
            Return
        End If
        If Me.comprobarTotales() = False Then
            MsgBox("El total de la compra no corresponde al desglose especificado en el detalle, intente nuevamente", MsgBoxStyle.Information, "Guardar Compra")
            Return
        End If
        Dim estado As Integer
        Select Case Me.cmbEstado.SelectedIndex
            Case 0
                estado = 1 'estado vigente, donde todavía hay saldo por pagar a la compra
            Case 1
                estado = 2 'estado cerrada, no hay saldo a pagar al cliente
        End Select
        Dim daoCompra = DataContext.daoCompras
        Dim daoMcaja = DataContext.daoMcaja
        'definimos los detalles de la compra
        Dim nuevaCompra As New Compras()
        Dim config As New ConfiguracionGeneral
        Dim caja, agencia As String
        Dim peso As Decimal = 0
        Dim total As Decimal = 0
        Dim efectivo As Decimal = 0
        Dim cheque As Decimal = 0
        Dim transferencia As Decimal = 0
        Dim por_cobrar As Decimal = 0
        Dim por_pagar As Decimal = 0
        Dim adelantos As Decimal = 0
        agencia = config.getAgencia
        caja = config.getCaja
        nuevaCompra.Codagencia = agencia
        nuevaCompra.Codcaja = caja
        nuevaCompra.Codcliente = txtCodcliente.Text
        For Each row As DataGridViewRow In dgvCompras.Rows
            peso += CDec(row.Cells(2).Value)
        Next
        nuevaCompra.Peso = peso
        nuevaCompra.Total = totalGeneral
        Dim moneda As Moneda = cmbMoneda.SelectedItem
        nuevaCompra.Codmoneda = moneda.Codmoneda
        nuevaCompra.Fecha = txtFecha.Value
        'Estado de la compra 
        '0:anulada
        '1:vigente
        '2:cerrada
        '3:descargado
        nuevaCompra.Codestado = estado
        nuevaCompra.Usuario = DataContext.usuarioLog.Codoperador
        nuevaCompra.Hora = Now.ToLongTimeString
        nuevaCompra.Forma_pago = String.Empty
        nuevaCompra.Dgnumdes = 0
        nuevaCompra.Por_cobrar = Decimal.Zero
        If txtPorpagar.TextLength > 0 Then
            nuevaCompra.Por_pagar = Convert.ToDecimal(txtPorpagar.Text)
            nuevaCompra.Saldo_por_pagar = Convert.ToDecimal(txtPorpagar.Text)
        Else
            nuevaCompra.Por_pagar = Decimal.Zero
            nuevaCompra.Saldo_por_pagar = Decimal.Zero
        End If
        If txtEfectivo.TextLength > 0 Then
            efectivo = Convert.ToDecimal(txtEfectivo.Text)
        End If
        If txtCheque.TextLength > 0 Then
            cheque = Convert.ToDecimal(txtCheque.Text)
        End If
        If txtTransferencia.TextLength > 0 Then
            transferencia = Convert.ToDecimal(txtTransferencia.Text)
        End If
        If txtAdelantos.TextLength > 0 Then
            adelantos = Convert.ToDecimal(txtAdelantos.Text)
        End If
        nuevaCompra.Efectivo = efectivo
        nuevaCompra.Cheque = cheque
        nuevaCompra.Transferencia = transferencia
        nuevaCompra.Adelantos = adelantos
        'seleccionamos el metodo a guardar la compra
        ' 1 - nueva compra
        ' 2 - editar compra
        Select Case auxiliar
            Case 1
                'definimos los detalles del det_compra  
                'nuevaCompra.Numcompra = daoCompra.codigoCompra
                Dim listaDeta As New List(Of Det_compra)
                Dim daoPrecio = DataContext.daoPrecioKilate
                For Each row As DataGridViewRow In dgvCompras.Rows
                    Dim deta As New Det_compra
                    'deta.Numcompra = daoCompra.codigoCompra()
                    deta.Descripcion = "Oro en bruto"
                    deta.Peso = Convert.ToDecimal(row.Cells(2).Value)
                    deta.Preciok = Convert.ToDecimal(row.Cells(3).Value)
                    deta.Importe = Convert.ToDecimal(row.Cells(4).Value)
                    deta.Linea = Convert.ToInt32(row.Cells(0).Value)
                    deta.Kilshowdoc = Convert.ToString(row.Cells(1).Value)
                    deta.Kilate = row.Cells("colDescripcion").Value
                    deta.Numdescargue = 0
                    deta.Fecha = nuevaCompra.Fecha
                    listaDeta.Add(deta)
                Next
                'definimos el maestro de caja
                Dim modCaja As Mcaja
                'esta variable parametros es para recuperar el movimiento que corresponde
                'a la compra en la tabla ids, [idcompras]
                Dim parametros As Ids
                Try
                    modCaja = daoMcaja.recuperarSaldoCaja(caja)
                    Dim dao = DataContext.daoParametros
                    parametros = dao.recuperarParametros()
                    'validamos si la caja tiene saldo disponible para aplicar la transaccion
                    If modCaja.Sfinal = 0 Then
                        MsgBox("No hay saldo para poder realizar la compra", MsgBoxStyle.Critical, "Guardar compra")
                        Return
                    End If
                    If modCaja.Sfinal < efectivo Then
                        MsgBox("No hay saldo suficiente para realizar la transaccion, intente nuevamente." &
                               vbCr & "Saldo disponible: " & modCaja.Sfinal,
                               MsgBoxStyle.Information, "Guardar compra")
                        Return
                    End If
                    If daoMcaja.validarCajaAbierta(caja) = False Then
                        MsgBox("La caja actual quedó abierta del día anterior, por favor cierre y vuelva abrir la caja",
                               MsgBoxStyle.Critical, "Guardar compra")
                        Return
                    End If
                    'verificamos el valor del cheque
                    Dim listaVal = daoMcaja.recuperarDetaCajaValores(modCaja)

                Catch ex As Exception
                    MsgBox("Hubo un problema al intentar recuperar la caja, revise la siguiente información: " & vbCr & daoMcaja.ErrorSms, MsgBoxStyle.Critical, "Error")
                    Return
                End Try
                'las compras son salidas de dinero por lo tanto solo definiremos salida
                modCaja.Salida = efectivo
                modCaja.Entrada = Decimal.Zero
                'creamos el detalle del movimiento en la caja
                Dim detaCaja As New Detacaja
                detaCaja.codcaja = caja
                detaCaja.idmov = parametros.Idcompras
                detaCaja.idcaja = modCaja.Idcaja
                detaCaja.fecha = DateTime.Now
                'detaCaja.Concepto = "***COMPRA: " & nuevaCompra.Numcompra & "***"
                'detaCaja.Referencia = "COMPRA: " & nuevaCompra.Numcompra
                detaCaja.efectivo = efectivo
                detaCaja.cheque = cheque
                detaCaja.transferencia = transferencia
                detaCaja.hora = Now.ToLongTimeString
                'guardamos los datos de la compra
                'listo, ahora a guardar los datos
                _compraActual = nuevaCompra
                _detalleComprasActual = listaDeta
                frmVerDetalleCompras.CompraSeleccionada = Me.CompraActual
                frmVerDetalleCompras.ListaDetalleCompra = Me.DetalleComprasActual
                frmVerDetalleCompras.ClienteSeleccionado = Me.ClienteActual
                frmVerDetalleCompras.btnAceptar.Focus()
                frmVerDetalleCompras.ShowDialog()
                If frmVerDetalleCompras.DialogResult = Windows.Forms.DialogResult.No Then
                    frmVerDetalleCompras.Dispose()
                    Return
                End If
                If daoCompra.crearCompra(nuevaCompra, listaDeta, modCaja, detaCaja, frmVerAdelantos.adelantoSeleccionados, frmPrecios2._listaCierresUsar) Then
                    Dim daoPrecios = DataContext.daoPrecioKilate
                    'If txtAdelantos.TextLength > 0 Then
                    '    Dim daoAdelanto = DataContext.daoAdelantos
                    '    daoAdelanto.actualizarAdelanto(aplicarAdelanto, txtCodcliente.Text, nuevaCompra.Numcompra)
                    'End If
                    'daoMcaja.actualizarDatosMaestroCaja(modCaja)
                    'daoMcaja.guardarDatosDetaCaja(detaCaja)
                    If parametros.Varias_compras = False Then
                        daoPrecio.valoresPorDefault()
                    End If
                    MsgBox("Se guardaron los datos de la compra en el sistema", MsgBoxStyle.Information, "Guardar Compra")
                    btnCancelar_Click(sender, e)
                    Me.imprimirCompra(nuevaCompra.Numcompra)
                Else
                    MsgBox("Error al ingresar la compra" & vbCr & "1- Compra: " & daoCompra.ErrorSms & vbCr &
                           "2-Caja: " & daoMcaja.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
            Case 2
                'editamos los datos de la compra
                If txtNumcompra.TextLength <= 0 Then
                    MsgBox("Especifique el numero de compra a editar, intente nuevamente", MsgBoxStyle.Information, "Guardar compra")
                    Return
                End If
                nuevaCompra.Numcompra = txtNumcompra.Text
                'definimos los detalles del det_compra        
                Dim listaDeta As New List(Of Det_compra)
                For Each row As DataGridViewRow In dgvCompras.Rows
                    Dim deta As New Det_compra
                    deta.Numcompra = nuevaCompra.Numcompra
                    deta.Descripcion = "Oro en bruto"
                    deta.Peso = Convert.ToDecimal(row.Cells(2).Value)
                    deta.Preciok = Convert.ToDecimal(row.Cells(3).Value)
                    deta.Importe = Convert.ToDecimal(row.Cells(4).Value)
                    deta.Linea = Convert.ToInt32(row.Cells(0).Value)
                    deta.Kilshowdoc = Convert.ToString(row.Cells(1).Value)
                    deta.Kilate = row.Cells("colDescripcion").Value
                    deta.Codagencia = nuevaCompra.Codagencia
                    deta.Fecha = nuevaCompra.Fecha
                    listaDeta.Add(deta)
                Next
                nuevaCompra.Numcompra = txtNumcompra.Text
                If daoCompra.actualizarCompra(nuevaCompra, listaDeta) Then
                    If txtAdelantos.TextLength > 0 Then
                        Dim daoAdelanto = DataContext.daoAdelantos
                        daoAdelanto.actualizarAdelanto(aplicarAdelanto, txtCodcliente.Text, nuevaCompra.Numcompra)
                    End If
                    MsgBox("Se guardaron los datos de la compra en el sistema", MsgBoxStyle.Information, "Guardar Compra")
                    btnCancelar_Click(sender, e)
                    Me.imprimirCompra(nuevaCompra.Numcompra)
                Else
                    MsgBox("No se pudo editar la compra. Por favor revise la siguiente informacion" & daoCompra.ErrorSms, MsgBoxStyle.Critical, "Error")
                End If
        End Select
    End Sub

    Private Sub btnAdelantos_Click(sender As Object, e As EventArgs) Handles btnAdelantos.Click
        If totalGeneral <= 0 Then
            MsgBox("Especifique un monto para aplicar al adelanto de la compra",
                   MsgBoxStyle.Information, "Compra")
            Return
        End If
        Dim saldo As Decimal = 0D
        For Each dato As Adelantos In verAdelanto
            saldo += dato.Saldo
        Next
        If saldo <= 0 Then
            MsgBox("El cliente seleccionado no cuenta con adelantos para aplicar a la compra", MsgBoxStyle.Information, "Aplicar adelanto")
            Return
        End If
        Dim frm As New frmVerAdelantos()
        _codmoneda = cmbMoneda.SelectedValue
        frm.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        If DataContext.usuarioLog.Nivel = 4 Then
            MsgBox("NO cuenta con los suficientes privilegios para realizar la edición de la compra.",
                   MsgBoxStyle.Information, "Editar compra")
            Return
        End If
        Me.btnCerrarcompra.Enabled = False
        Me.auxiliar = 2
        Me.habilitarBotones(False, True, False, True, True, True)
        Me.habilitarGrupos(True, True, True, True)
        Me.txtNumcompra.Clear()
        txtNumcompra.ReadOnly = False
        txtNumcompra.Focus()
        Me.panelBuscar_compra.Visible = True
        Me.panelBuscar_compra.Size = New Size(387, 133)
        Me.checEfectivo.Enabled = False
        If checEfectivo.Enabled = False Then
            Me.txtEfectivo.Enabled = False
        End If
        Me.cmbEstado.Enabled = True
        'cmbMoneda.Enabled = True
        Me.filtrarCompra()
    End Sub
    Sub buscarCompra()
        Using ctx As New Contexto
            Try
                Dim dao = DataContext.daoCompras
                Dim row As DataGridViewRow = dgvBuscar_compra.CurrentRow
                Me.txtNumcompra.Text = Convert.ToString(row.Cells(0).Value)
                Dim findCompra As Compras = dao.findCompraById(Me.txtNumcompra.Text, agencia)
                'revisamos si la compra esta anulada
                If findCompra.Codestado = 0 Then
                    MsgBox("La compra seleccionada esta anulada y por lo tanto no se puede seleccionar, intente nuevamente",
                           MsgBoxStyle.Information, "Buscar compra")
                    Return
                End If
                If findCompra.Codestado = 3 Then
                    MsgBox("La compra seleccionada ya ha sido descargada, por lo tanto no puede editarla, intente nuevamente",
                           MsgBoxStyle.Information, "Buscar compra")
                    Return
                End If
                Me.txtFecha.Value = findCompra.Fecha
                Me.dgvCompras.Rows.Clear()
                Me.txtNumcompra.Text = row.Cells(0).Value
                Me.txtCodcliente.Text = row.Cells(1).Value
                Me.txtNomcliente.Text = row.Cells(2).Value
                Me.txtApecliente.Text = row.Cells(3).Value
                Me.txtDircliente.Text = row.Cells(4).Value
                Me.panelBuscar_compra.Visible = False
                Dim filtrar As List(Of Det_compra) = dao.findDetaCompra(txtNumcompra.Text)
                For Each dato As Det_compra In filtrar
                    dgvCompras.Rows.Add(dato.Linea, dato.Kilate, dato.Peso, dato.Preciok, dato.Importe)
                Next
                Me.cmbPrecios2.Focus()
                Me.calcularTotales()
                Me.btnAnular.Enabled = True
                If findCompra.Efectivo > 0 Then
                    Me.txtEfectivo.Visible = True
                    Me.txtEfectivo.Text = findCompra.Efectivo
                End If
                If findCompra.Cheque > 0 Then
                    Me.txtCheque.Visible = True
                    Me.checCheque.Checked = True
                    Me.txtCheque.Text = findCompra.Cheque
                End If
                If findCompra.Transferencia > 0 Then
                    Me.txtTransferencia.Visible = True
                    Me.checTransferencias.Checked = True
                    Me.txtTransferencia.Text = findCompra.Transferencia
                End If
                If findCompra.Saldo_por_pagar > 0 Then
                    Me.txtPorpagar.Visible = True
                    Me.checPorpagar.Checked = True
                    Me.txtPorpagar.Text = findCompra.Saldo_por_pagar
                End If
                If findCompra.Adelantos > 0 Then
                    Me.txtAdelantos.Visible = True
                    Me.checAdelantos.Checked = True
                    Me.txtAdelantos.Text = findCompra.Adelantos
                End If
                If findCompra.Codestado = 1 Then
                    Me.cmbEstado.SelectedIndex = 0
                ElseIf findCompra.Codestado = 2 Then
                    Me.cmbEstado.SelectedIndex = 1
                End If
                For indice = 0 To cmbMoneda.Items.Count - 1
                    If findCompra.Codmoneda = cmbMoneda.Items(indice).codmoneda Then
                        cmbMoneda.SelectedIndex = indice
                    End If
                Next
                Me.compraEncontrada = True
            Catch ex As Exception
                MsgBox("No existe la compra seleccionada " & vbCr & ex.Message, MsgBoxStyle.Information, "Buscar compra")
                Me.compraEncontrada = False
            End Try
        End Using
    End Sub
    Private Sub txtNumcompra_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumcompra.TextChanged
        Me.filtrarCompra()
    End Sub

    Private Sub dgvBuscar_compra_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBuscar_compra.CellDoubleClick
        Me.buscarCompra()
    End Sub

    Private Sub txtNumcompra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumcompra.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                Me.dgvBuscar_compra.Focus()
            Case Keys.Enter
                Me.buscarCompra()
        End Select
    End Sub

    Private Sub txtFiltrar_compra_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFiltrar_compra.TextChanged
        Using ctx As New Contexto
            Try
                Dim config As New ConfiguracionGeneral
                Dim agencia As String = config.getAgencia
                Dim filtrar = (From c In ctx.Compras Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                               Where c.Codestado = 1 Or c.Codestado = 2
                               Order By Convert.ToInt32(c.Numcompra) Ascending
                               Select c.Numcompra, cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Direccion, c.Codagencia).ToList()
                dgvBuscar_compra.Rows.Clear()
                For Each dato In filtrar.Where(Function(c) c.Nombres.Contains(txtFiltrar_compra.Text) And c.Codagencia = agencia).ToList
                    Me.dgvBuscar_compra.Rows.Add(dato.Numcompra, dato.Codcliente, dato.Nombres, dato.Apellidos, dato.Direccion)
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, tituloError)
            End Try
        End Using
    End Sub

    Private Sub txtFiltrar_compra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFiltrar_compra.KeyDown
        Select Case e.KeyValue
            Case Keys.Down
                Me.dgvBuscar_compra.Focus()
        End Select
    End Sub

    Private Sub dgvBuscar_compra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvBuscar_compra.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                Me.buscarCompra()
        End Select
    End Sub

    Private Sub txtPeso_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress
        ServiciosBasicos.keyCharEnter(btnAgregar, e)
        ServiciosBasicos.NumeroDec(e, txtPeso)
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Me.buscarCompra()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Me.imprimirCompra(txtNumcompra.Text)
    End Sub

    Private Sub txtFiltrar_compra_Enter(sender As System.Object, e As System.EventArgs) Handles txtFiltrar_compra.Enter
        ServiciosBasicos.colorDeFondoInfo(txtFiltrar_compra)
    End Sub

    Private Sub txtFiltrar_compra_Leave(sender As System.Object, e As System.EventArgs) Handles txtFiltrar_compra.Leave
        ServiciosBasicos.colorDeFondoBlanco(txtFiltrar_compra)
    End Sub

    Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
        If DataContext.usuarioLog.Nivel = 4 Then
            MsgBox("No cuenta con los privilegios suficientes para anular la compra.",
                   MsgBoxStyle.Information, "Anular compra")
            btnCancelar_Click(sender, e)
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Anular la compra seleccionada?", MsgBoxStyle.YesNo, "Anular compra")
        If result = DialogResult.No Then
            Return
        End If
        Dim dao = DataContext.daoCompras
        If dao.anularCompra(txtNumcompra.Text) = True Then
            MsgBox("Se ha anulado la compra seleccionada", MsgBoxStyle.Information, "Anular compra")
            Me.btnCancelar_Click(sender, e)
        Else
            MsgBox("se produjo el siguiente error al intentar anular la compra: " & vbCr & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub txtNumcompra_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumcompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvCompras_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCompras.CellEndEdit
        Try
            Dim row As DataGridViewRow = dgvCompras.CurrentRow
            If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
                Dim total As Decimal = 0
                Dim precio As Decimal = row.Cells("colPrecio").Value
                Dim peso As Decimal = row.Cells("colPeso").Value
                Dim importe As Decimal = 0
                importe = precio * peso
                row.Cells("colImporte").Value = importe.ToString("#,###,#00.00")
                For Each Val As DataGridViewRow In dgvCompras.Rows
                    total += Val.Cells("colImporte").Value
                Next
                Me.totalGeneral = total
                Me.txtTotal.Text = total.ToString("#,###,###,#00.00")
                row.Cells("colPrecio").Value = precio.ToString("#,###,#00.00")
                row.Cells("colPeso").Value = peso.ToString("#,###,#00.00")
            End If
        Catch ex As Exception
            MsgBox("Error al intentar editar la celda: " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtPorpagar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPorpagar.TextChanged
        If txtPorpagar.TextLength > 0 Then
            Me.cmbEstado.SelectedIndex = 0
        Else
            Me.cmbEstado.SelectedIndex = 1
        End If
    End Sub

    Private Sub btnCerrarcompra_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrarcompra.Click
        frmPagoCompra.ShowDialog()
    End Sub

    Private Sub ToolTip_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip.Popup

    End Sub

    Private Sub txtEfectivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEfectivo.KeyDown
        If Me.txtCheque.Visible = False Then
            Select Case e.KeyValue
                Case Keys.Enter
                    Me.txtCheque.Focus()
            End Select
            Return
        End If
        If Me.txtPorpagar.Visible = False Then
            Select Case e.KeyValue
                Case Keys.Enter
                    Me.txtPorpagar.Focus()
            End Select
            Return
        End If
        If Me.txtTransferencia.Visible = False Then
            Select Case e.KeyValue
                Case Keys.Enter
                    Me.btnGuardar.Focus()
            End Select
            Return
        End If
        Select Case e.KeyValue
            Case Keys.Enter
                btnGuardar.Focus()
        End Select
    End Sub

    Private Sub btnGuardar_Enter(sender As Object, e As EventArgs) Handles btnGuardar.Enter
        Me.btnGuardar.FlatAppearance.BorderColor = Color.Black
        Me.btnGuardar.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnGuardar_Leave(sender As Object, e As EventArgs) Handles btnGuardar.Leave
        Me.btnGuardar.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub txtCheque_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCheque.KeyDown
        If Me.txtPorpagar.Visible = False Then
            Select Case e.KeyValue
                Case Keys.Enter
                    Me.btnGuardar.Focus()
            End Select
        Else
            Me.txtPorpagar.Focus()
        End If
        If Me.txtTransferencia.Visible = False Then
            Select Case e.KeyValue
                Case Keys.Enter
                    Me.btnGuardar.Focus()
            End Select
        Else
            Me.txtTransferencia.Focus()
        End If
    End Sub

    Private Sub txtPorpagar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPorpagar.KeyDown
        If Me.txtTransferencia.Visible = False Then
            Select Case e.KeyValue
                Case Keys.Enter
                    Me.btnGuardar.Focus()
            End Select
        Else
            Me.txtTransferencia.Focus()
        End If
    End Sub

    Private Sub cmbDescripcion_SelectedValueChanged(sender As Object, e As EventArgs)
        Try
            Me.buscarPrecio()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbPrecios2_RowSelected(sender As Object, e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles cmbPrecios2.RowSelected
        Try
            buscarPrecio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbPrecios2_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPrecios2.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtPeso.Focus()
        End Select
    End Sub

    Private Sub txtTransferencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTransferencia.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                btnGuardar.Focus()
        End Select
    End Sub

    Private Sub cmbMoneda_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMoneda.SelectionChangeCommitted
        Try
            If _codmoneda <> cmbMoneda.SelectedValue Then
                'en este momento son distintos los valores
            End If
            _codmoneda = cmbMoneda.SelectedValue
        Catch ex As Exception
            MsgBox("No se pudo establecer el tipo de moneda seleccionado debido al siguiente error: " & vbCr & ex.Message, MsgBoxStyle.Exclamation, tituloError)
        End Try
    End Sub
End Class

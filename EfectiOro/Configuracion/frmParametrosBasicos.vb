Imports EfectiOro.Database

Public Class frmParametrosBasicos
    Inherits frmPersonalizado

    Private parametrosCargados As Boolean = False

    Sub cargarComboBox()
        Dim dao = DataContext.daoMovimientosCaja
        cmbAdelantos.DataSource = dao.findAll()
        cmbCompra.DataSource = dao.findAll()
        cmbSaldoCaja.DataSource = dao.findAll()
        cmbCierrecompra.DataSource = dao.findAll()
        cmbPrestamoEgreso.DataSource = dao.findAll()
        cmbPrestamoIngreso.DataSource = dao.findAll()
        cmbAnularCompra.DataSource = dao.findAll()
        cmbAnularAdelanto.DataSource = dao.findAll()
        cmbPagoAdelantos.DataSource = dao.findAll
        cmbAdelantos.ValueMember = "Idmov"
        cmbAdelantos.DisplayMember = "Descripcion"
        cmbCompra.ValueMember = "Idmov"
        cmbCompra.DisplayMember = "Descripcion"
        cmbSaldoCaja.ValueMember = "Idmov"
        cmbSaldoCaja.DisplayMember = "Descripcion"
        cmbCierrecompra.ValueMember = "Idmov"
        cmbCierrecompra.DisplayMember = "Descripcion"
        cmbPrestamoEgreso.ValueMember = "Idmov"
        cmbPrestamoEgreso.DisplayMember = "Descripcion"
        cmbPrestamoIngreso.ValueMember = "Idmov"
        cmbPrestamoIngreso.DisplayMember = "Descripcion"
        cmbAnularCompra.ValueMember = "Idmov"
        cmbAnularCompra.DisplayMember = "Descripcion"
        cmbAnularAdelanto.ValueMember = "Idmov"
        cmbAnularAdelanto.DisplayMember = "Descripcion"
        Dim daoUser = DataContext.daoUsuario
        cmbVoucher.DataSource = daoUser.findAll()
        cmbVoucher.DisplayMember = "Nombre"
        cmbVoucher.ValueMember = "Codoperador"
        cmbPagoAdelantos.DisplayMember = "Descripcion"
        cmbPagoAdelantos.ValueMember = "Idmov"
    End Sub
<<<<<<< HEAD


=======
    Sub cargarMoneda()
        Using ctx As New Contexto
            cmbMoneda.DataSource = ctx.Moneda.ToList
            cmbMoneda.DisplayMember = "Descripcion"
            cmbMoneda.ValueMember = "Codmoneda"
        End Using
    End Sub
>>>>>>> d8bfd5a6acabacd5117db978dba64f782dae3e16
    Sub cargarParametros()
        Dim dao = DataContext.daoParametros
        Try
            Dim para As Ids = dao.recuperarParametros()
            txtcodagencia.Text = para.Codagencia
            txtcodcliente.Text = para.Codcliente
            txtidadelanto.Text = para.Idadelanto
            txtnumcompra.Text = para.Numcompra
            cmbAdelantos.SelectedValue = para.Id_adelantos
            cmbCompra.SelectedValue = para.Idcompras
            cmbSaldoCaja.SelectedValue = para.Saldo_anterior
            cmbCierrecompra.SelectedValue = para.Cierre_compra
            cmbPrestamoEgreso.SelectedValue = para.Prestamo_egreso
            cmbPrestamoIngreso.SelectedValue = para.Prestamo_ingreso
            cmbAnularCompra.SelectedValue = para.anular_compra
            cmbAnularAdelanto.SelectedValue = para.Anular_adelanto
            cmbVoucher.SelectedValue = para.recibe
            cmbPagoAdelantos.SelectedValue = para.Pago_adelanto
            Me.parametrosCargados = True
        Catch ex As Exception
            Me.parametrosCargados = False
        End Try
    End Sub

    Private Sub frmParametrosBasicos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.panelTitulo.Visible = False
        cargarComboBox()
        cargarMoneda()
        cmbMoneda.SelectedIndex = 0
        Me.cargarParametros()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        'Codagencia
        'Codcliente
        'Id_adelantos
        'Idadelanto
        'Idcompras
        'Numcompra
        Dim dao = DataContext.daoParametros
        Dim para As New Ids
        Dim find = dao.recuperarParametros()
        para.Codagencia = CInt(txtcodagencia.Text)
        para.Codcliente = CInt(txtcodcliente.Text)
        para.Idadelanto = CInt(txtidadelanto.Text)
        para.Numcompra = CInt(txtnumcompra.Text)
        para.Id_adelantos = CInt(cmbAdelantos.SelectedValue)
        para.Idcompras = CInt(cmbCompra.SelectedValue)
        para.Saldo_anterior = CInt(cmbSaldoCaja.SelectedValue)
        para.Cierre_compra = CInt(cmbCierrecompra.SelectedValue)
        para.Prestamo_egreso = CInt(cmbPrestamoEgreso.SelectedValue)
        para.Prestamo_ingreso = CInt(cmbPrestamoIngreso.SelectedValue)
        para.anular_compra = CInt(cmbAnularCompra.SelectedValue)
        para.Anular_adelanto = CInt(cmbAnularAdelanto.SelectedValue)
        para.recibe = cmbVoucher.SelectedValue
        para.Varias_compras = False
        para.pago_adelanto = CInt(cmbPagoAdelantos.SelectedValue)
        para.dolares = CInt(cmbMoneda.SelectedValue)
        para.backup = find.backup
        para.idreserva = find.idreserva
        If Me.parametrosCargados Then
            If dao.actualizarParametros(para) Then
                MsgBox("Se actualizaron los parametros de configuracion", MsgBoxStyle.Information, "Establecer parametros")
                Me.cargarParametros()
            End If
        Else
            If dao.crearParametros(para) Then
                MsgBox("Se crearon los parametros de configuracion", MsgBoxStyle.Information, "Establecer parametros")
                Me.cargarParametros()
            End If
        End If
        
    End Sub

End Class
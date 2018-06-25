<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarFechaHoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarDescargueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosKilateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosDeCajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdelantosAClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarDescarguePorCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservarOroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolPreciosCierres = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeDescarguesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeCajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierrePreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.btnMcaja = New Infragistics.Win.Misc.UltraButton()
        Me.btnTipocambio = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrecios = New Infragistics.Win.Misc.UltraButton()
        Me.btnCompras = New Infragistics.Win.Misc.UltraButton()
        Me.btnCliente = New Infragistics.Win.Misc.UltraButton()
        Me.panelCentral = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UPMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.panelLateral.SuspendLayout()
        Me.status.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.CatalogoToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(981, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.InicioToolStripMenuItem.Text = "&Inicio"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'CrearUsuarioToolStripMenuItem
        '
        Me.CrearUsuarioToolStripMenuItem.Name = "CrearUsuarioToolStripMenuItem"
        Me.CrearUsuarioToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.CrearUsuarioToolStripMenuItem.Text = "Crear Usuario"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionToolStripMenuItem, Me.BackupBaseDeDatosToolStripMenuItem, Me.ActualizarFechaHoraToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'BackupBaseDeDatosToolStripMenuItem
        '
        Me.BackupBaseDeDatosToolStripMenuItem.Name = "BackupBaseDeDatosToolStripMenuItem"
        Me.BackupBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.BackupBaseDeDatosToolStripMenuItem.Text = "Backup Base de datos"
        '
        'ActualizarFechaHoraToolStripMenuItem
        '
        Me.ActualizarFechaHoraToolStripMenuItem.Name = "ActualizarFechaHoraToolStripMenuItem"
        Me.ActualizarFechaHoraToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.ActualizarFechaHoraToolStripMenuItem.Text = "Actualizar Fecha-Hora"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.AgenciaToolStripMenuItem, Me.CajasToolStripMenuItem, Me.RubrosToolStripMenuItem, Me.MovimientosDeCajaToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CatalogoToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.catalog
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(92, 23)
        Me.CatalogoToolStripMenuItem.Text = "&Catalogo"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'AgenciaToolStripMenuItem
        '
        Me.AgenciaToolStripMenuItem.Name = "AgenciaToolStripMenuItem"
        Me.AgenciaToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.AgenciaToolStripMenuItem.Text = "Agencia"
        '
        'CajasToolStripMenuItem
        '
        Me.CajasToolStripMenuItem.Name = "CajasToolStripMenuItem"
        Me.CajasToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.CajasToolStripMenuItem.Text = "Cajas"
        '
        'RubrosToolStripMenuItem
        '
        Me.RubrosToolStripMenuItem.Name = "RubrosToolStripMenuItem"
        Me.RubrosToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.RubrosToolStripMenuItem.Text = "Rubros"
        '
        'MovimientosDeCajaToolStripMenuItem
        '
        Me.MovimientosDeCajaToolStripMenuItem.Name = "MovimientosDeCajaToolStripMenuItem"
        Me.MovimientosDeCajaToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.MovimientosDeCajaToolStripMenuItem.Text = "Movimientos de caja"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.TipoDeCambioToolStripMenuItem, Me.GenerarDescargueToolStripMenuItem, Me.PreciosKilateToolStripMenuItem, Me.CajaToolStripMenuItem, Me.EstadisticaToolStripMenuItem, Me.GenerarDescarguePorCompraToolStripMenuItem, Me.ReservarOroToolStripMenuItem, Me.toolPreciosCierres, Me.UPMToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MantenimientoToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.surveys
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(131, 23)
        Me.MantenimientoToolStripMenuItem.Text = "&Mantenimiento"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.SHOPPING_CART
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'TipoDeCambioToolStripMenuItem
        '
        Me.TipoDeCambioToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.currency_euro_blue
        Me.TipoDeCambioToolStripMenuItem.Name = "TipoDeCambioToolStripMenuItem"
        Me.TipoDeCambioToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.TipoDeCambioToolStripMenuItem.Text = "Tipo de cambio"
        '
        'GenerarDescargueToolStripMenuItem
        '
        Me.GenerarDescargueToolStripMenuItem.Name = "GenerarDescargueToolStripMenuItem"
        Me.GenerarDescargueToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.GenerarDescargueToolStripMenuItem.Text = "Generar Descargue"
        '
        'PreciosKilateToolStripMenuItem
        '
        Me.PreciosKilateToolStripMenuItem.Name = "PreciosKilateToolStripMenuItem"
        Me.PreciosKilateToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.PreciosKilateToolStripMenuItem.Text = "Precios kilate"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientosDeCajaToolStripMenuItem1, Me.AdelantosAClientesToolStripMenuItem})
        Me.CajaToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.finance51
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'MovimientosDeCajaToolStripMenuItem1
        '
        Me.MovimientosDeCajaToolStripMenuItem1.Name = "MovimientosDeCajaToolStripMenuItem1"
        Me.MovimientosDeCajaToolStripMenuItem1.Size = New System.Drawing.Size(204, 24)
        Me.MovimientosDeCajaToolStripMenuItem1.Text = "Movimientos de caja"
        '
        'AdelantosAClientesToolStripMenuItem
        '
        Me.AdelantosAClientesToolStripMenuItem.Name = "AdelantosAClientesToolStripMenuItem"
        Me.AdelantosAClientesToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.AdelantosAClientesToolStripMenuItem.Text = "Adelantos a clientes"
        '
        'EstadisticaToolStripMenuItem
        '
        Me.EstadisticaToolStripMenuItem.Name = "EstadisticaToolStripMenuItem"
        Me.EstadisticaToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.EstadisticaToolStripMenuItem.Text = "Estadistica"
        '
        'GenerarDescarguePorCompraToolStripMenuItem
        '
        Me.GenerarDescarguePorCompraToolStripMenuItem.Name = "GenerarDescarguePorCompraToolStripMenuItem"
        Me.GenerarDescarguePorCompraToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.GenerarDescarguePorCompraToolStripMenuItem.Text = "Generar Descargue por compra"
        '
        'ReservarOroToolStripMenuItem
        '
        Me.ReservarOroToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.cierre
        Me.ReservarOroToolStripMenuItem.Name = "ReservarOroToolStripMenuItem"
        Me.ReservarOroToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.ReservarOroToolStripMenuItem.Text = "Reservar oro"
        '
        'toolPreciosCierres
        '
        Me.toolPreciosCierres.Image = Global.EfectiOro.My.Resources.Resources.dollar_red
        Me.toolPreciosCierres.Name = "toolPreciosCierres"
        Me.toolPreciosCierres.Size = New System.Drawing.Size(270, 24)
        Me.toolPreciosCierres.Text = "Precios Cierres"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeComprasToolStripMenuItem, Me.DeClientesToolStripMenuItem, Me.DeDescarguesToolStripMenuItem, Me.DeCajasToolStripMenuItem, Me.CierrePreciosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportesToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.analysis
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(91, 23)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'DeComprasToolStripMenuItem
        '
        Me.DeComprasToolStripMenuItem.Name = "DeComprasToolStripMenuItem"
        Me.DeComprasToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.DeComprasToolStripMenuItem.Text = "De compras"
        '
        'DeClientesToolStripMenuItem
        '
        Me.DeClientesToolStripMenuItem.Name = "DeClientesToolStripMenuItem"
        Me.DeClientesToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.DeClientesToolStripMenuItem.Text = "De clientes"
        '
        'DeDescarguesToolStripMenuItem
        '
        Me.DeDescarguesToolStripMenuItem.Name = "DeDescarguesToolStripMenuItem"
        Me.DeDescarguesToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.DeDescarguesToolStripMenuItem.Text = "De descargues"
        '
        'DeCajasToolStripMenuItem
        '
        Me.DeCajasToolStripMenuItem.Name = "DeCajasToolStripMenuItem"
        Me.DeCajasToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.DeCajasToolStripMenuItem.Text = "De cajas"
        '
        'CierrePreciosToolStripMenuItem
        '
        Me.CierrePreciosToolStripMenuItem.Name = "CierrePreciosToolStripMenuItem"
        Me.CierrePreciosToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.CierrePreciosToolStripMenuItem.Text = "Cierre precios"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 23)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "currency_euro blue.png")
        Me.ImageList1.Images.SetKeyName(1, "currency_euro yellow.png")
        Me.ImageList1.Images.SetKeyName(2, "dollar green.png")
        Me.ImageList1.Images.SetKeyName(3, "dollar red.png")
        Me.ImageList1.Images.SetKeyName(4, "shopping_cart blue.png")
        Me.ImageList1.Images.SetKeyName(5, "shopping_cart red.png")
        Me.ImageList1.Images.SetKeyName(6, "User Card.png")
        Me.ImageList1.Images.SetKeyName(7, "Usercard_01.png")
        Me.ImageList1.Images.SetKeyName(8, "cash_register.png")
        Me.ImageList1.Images.SetKeyName(9, "cash_register2.png")
        Me.ImageList1.Images.SetKeyName(10, "money_plus.png")
        '
        'panelLateral
        '
        Me.panelLateral.BackColor = System.Drawing.Color.Transparent
        Me.panelLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelLateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelLateral.Controls.Add(Me.btnMcaja)
        Me.panelLateral.Controls.Add(Me.btnTipocambio)
        Me.panelLateral.Controls.Add(Me.btnPrecios)
        Me.panelLateral.Controls.Add(Me.btnCompras)
        Me.panelLateral.Controls.Add(Me.btnCliente)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLateral.Location = New System.Drawing.Point(0, 27)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(75, 576)
        Me.panelLateral.TabIndex = 1
        '
        'btnMcaja
        '
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.Name = "Arial"
        Appearance11.ForeColor = System.Drawing.Color.White
        Appearance11.Image = "cash_register.png"
        Appearance11.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance11.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance11.TextVAlignAsString = "Bottom"
        Me.btnMcaja.Appearance = Appearance11
        Me.btnMcaja.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnMcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Appearance12.Image = "cash_register2.png"
        Me.btnMcaja.HotTrackAppearance = Appearance12
        Me.btnMcaja.ImageList = Me.ImageList1
        Me.btnMcaja.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnMcaja.Location = New System.Drawing.Point(1, 421)
        Me.btnMcaja.Name = "btnMcaja"
        Me.btnMcaja.Size = New System.Drawing.Size(67, 95)
        Me.btnMcaja.TabIndex = 4
        Me.btnMcaja.Text = "Caja"
        Me.btnMcaja.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnTipocambio
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.Name = "Arial"
        Appearance1.ForeColor = System.Drawing.Color.White
        Appearance1.Image = "currency_euro blue.png"
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance1.TextVAlignAsString = "Bottom"
        Me.btnTipocambio.Appearance = Appearance1
        Me.btnTipocambio.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnTipocambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Appearance2.Image = "currency_euro yellow.png"
        Me.btnTipocambio.HotTrackAppearance = Appearance2
        Me.btnTipocambio.ImageList = Me.ImageList1
        Me.btnTipocambio.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnTipocambio.Location = New System.Drawing.Point(2, 320)
        Me.btnTipocambio.Name = "btnTipocambio"
        Me.btnTipocambio.Size = New System.Drawing.Size(67, 95)
        Me.btnTipocambio.TabIndex = 3
        Me.btnTipocambio.Text = "T/C"
        Me.btnTipocambio.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnPrecios
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.FontData.Name = "Arial"
        Appearance3.ForeColor = System.Drawing.Color.White
        Appearance3.Image = "dollar green.png"
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance3.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance3.TextVAlignAsString = "Bottom"
        Me.btnPrecios.Appearance = Appearance3
        Me.btnPrecios.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Appearance4.Image = "dollar red.png"
        Me.btnPrecios.HotTrackAppearance = Appearance4
        Me.btnPrecios.ImageList = Me.ImageList1
        Me.btnPrecios.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnPrecios.Location = New System.Drawing.Point(2, 219)
        Me.btnPrecios.Name = "btnPrecios"
        Me.btnPrecios.Size = New System.Drawing.Size(67, 95)
        Me.btnPrecios.TabIndex = 2
        Me.btnPrecios.Text = "Precios"
        Me.btnPrecios.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCompras
        '
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.Name = "Arial"
        Appearance5.ForeColor = System.Drawing.Color.White
        Appearance5.Image = "shopping_cart blue.png"
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance5.TextVAlignAsString = "Bottom"
        Me.btnCompras.Appearance = Appearance5
        Me.btnCompras.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Appearance6.Image = "shopping_cart red.png"
        Me.btnCompras.HotTrackAppearance = Appearance6
        Me.btnCompras.ImageList = Me.ImageList1
        Me.btnCompras.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnCompras.Location = New System.Drawing.Point(2, 118)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(67, 95)
        Me.btnCompras.TabIndex = 1
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCliente
        '
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.Name = "Arial"
        Appearance7.ForeColor = System.Drawing.Color.White
        Appearance7.Image = "User Card.png"
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance7.TextVAlignAsString = "Bottom"
        Me.btnCliente.Appearance = Appearance7
        Me.btnCliente.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Appearance8.Image = "Usercard_01.png"
        Me.btnCliente.HotTrackAppearance = Appearance8
        Me.btnCliente.ImageList = Me.ImageList1
        Me.btnCliente.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnCliente.Location = New System.Drawing.Point(2, 17)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(67, 95)
        Me.btnCliente.TabIndex = 0
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'panelCentral
        '
        Me.panelCentral.AutoScroll = True
        Me.panelCentral.BackColor = System.Drawing.Color.Transparent
        Me.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentral.Location = New System.Drawing.Point(75, 27)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(906, 576)
        Me.panelCentral.TabIndex = 2
        '
        'status
        '
        Me.status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.status.Location = New System.Drawing.Point(75, 579)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(906, 24)
        Me.status.TabIndex = 0
        Me.status.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(140, 19)
        Me.lblStatus.Text = "ToolStripStatusLabel1"
        '
        'UPMToolStripMenuItem
        '
        Me.UPMToolStripMenuItem.Image = Global.EfectiOro.My.Resources.Resources.finance51
        Me.UPMToolStripMenuItem.Name = "UPMToolStripMenuItem"
        Me.UPMToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.UPMToolStripMenuItem.Text = "UPM"
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.EfectiOro.My.Resources.Resources.abstracta_fondo_de_pantalla
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(981, 603)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.panelCentral)
        Me.Controls.Add(Me.panelLateral)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:. EFECTIORO .:."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelLateral.ResumeLayout(False)
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CatalogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeCambioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarDescargueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosKilateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosDeCajaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdelantosAClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeDescarguesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeCajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelLateral As System.Windows.Forms.Panel
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupBaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents panelCentral As System.Windows.Forms.Panel
    Friend WithEvents ActualizarFechaHoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnCliente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTipocambio As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrecios As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCompras As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMcaja As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GenerarDescarguePorCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservarOroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents status As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CierrePreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolPreciosCierres As ToolStripMenuItem
    Friend WithEvents UPMToolStripMenuItem As ToolStripMenuItem
End Class

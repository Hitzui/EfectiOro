<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrecios2
    Inherits EfectiOro.frmPersonalizado

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrecios2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGramos = New System.Windows.Forms.TextBox()
        Me.btnQuitar = New Infragistics.Win.Misc.UltraButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMargen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioOro = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.txtQuilate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPrecios = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnQuitarSeleccion = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnNuevo = New Infragistics.Win.Misc.UltraButton()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvCierrePrecios = New System.Windows.Forms.DataGridView()
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCodcierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOnzas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioOro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMargen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOnzasDisponibles = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblOnzasIn = New System.Windows.Forms.ToolStripLabel()
        Me.lblOnzasIngresar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOnzasDiferencia = New System.Windows.Forms.ToolStripLabel()
        Me.colLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuilate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGramos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAgencia = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCierrePrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(980, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(367, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(119, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(74, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(225, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'dgvCliente
        '
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(21, 76)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.Size = New System.Drawing.Size(477, 10)
        Me.dgvCliente.TabIndex = 2
        Me.dgvCliente.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtGramos)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtMargen)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPrecioOro)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.txtQuilate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dgvPrecios)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 242)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Gramos:"
        '
        'txtGramos
        '
        Me.txtGramos.Location = New System.Drawing.Point(306, 28)
        Me.txtGramos.Name = "txtGramos"
        Me.txtGramos.Size = New System.Drawing.Size(88, 20)
        Me.txtGramos.TabIndex = 16
        '
        'btnQuitar
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.PAGE_REMOVE
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnQuitar.Appearance = Appearance2
        Me.btnQuitar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnQuitar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnQuitar.Location = New System.Drawing.Point(310, 19)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(66, 45)
        Me.btnQuitar.TabIndex = 15
        Me.btnQuitar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.btnQuitar.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Margen Bruto:"
        '
        'txtMargen
        '
        Me.txtMargen.Location = New System.Drawing.Point(207, 28)
        Me.txtMargen.Name = "txtMargen"
        Me.txtMargen.Size = New System.Drawing.Size(88, 20)
        Me.txtMargen.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Precio del oro:"
        '
        'txtPrecioOro
        '
        Me.txtPrecioOro.Location = New System.Drawing.Point(108, 28)
        Me.txtPrecioOro.Name = "txtPrecioOro"
        Me.txtPrecioOro.Size = New System.Drawing.Size(88, 20)
        Me.txtPrecioOro.TabIndex = 11
        '
        'btnAgregar
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.money_plus
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnAgregar.Appearance = Appearance1
        Me.btnAgregar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnAgregar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnAgregar.Location = New System.Drawing.Point(420, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(48, 36)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtQuilate
        '
        Me.txtQuilate.Location = New System.Drawing.Point(9, 28)
        Me.txtQuilate.Name = "txtQuilate"
        Me.txtQuilate.Size = New System.Drawing.Size(88, 20)
        Me.txtQuilate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quilate:"
        '
        'dgvPrecios
        '
        Me.dgvPrecios.AllowUserToAddRows = False
        Me.dgvPrecios.AllowUserToDeleteRows = False
        Me.dgvPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrecios.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLinea, Me.colQuilate, Me.colPrecio, Me.colGramos, Me.colAgencia})
        Me.dgvPrecios.Location = New System.Drawing.Point(6, 54)
        Me.dgvPrecios.Name = "dgvPrecios"
        Me.dgvPrecios.ReadOnly = True
        Me.dgvPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrecios.Size = New System.Drawing.Size(480, 182)
        Me.dgvPrecios.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnQuitarSeleccion)
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.btnQuitar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 85)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'btnQuitarSeleccion
        '
        Appearance3.Image = Global.EfectiOro.My.Resources.Resources.refresh01
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance3.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnQuitarSeleccion.Appearance = Appearance3
        Me.btnQuitarSeleccion.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnQuitarSeleccion.Enabled = False
        Me.btnQuitarSeleccion.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnQuitarSeleccion.Location = New System.Drawing.Point(408, 19)
        Me.btnQuitarSeleccion.Name = "btnQuitarSeleccion"
        Me.btnQuitarSeleccion.Size = New System.Drawing.Size(60, 60)
        Me.btnQuitarSeleccion.TabIndex = 20
        Me.toolTip.SetToolTip(Me.btnQuitarSeleccion, "Restablecer precios del cliente")
        Me.btnQuitarSeleccion.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCancelar
        '
        Appearance4.Image = Global.EfectiOro.My.Resources.Resources.cancel01
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCancelar.Appearance = Appearance4
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCancelar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnCancelar.Location = New System.Drawing.Point(182, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 60)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnGuardar
        '
        Appearance5.Image = Global.EfectiOro.My.Resources.Resources.SAVE
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnGuardar.Appearance = Appearance5
        Me.btnGuardar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnGuardar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnGuardar.Location = New System.Drawing.Point(104, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 60)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnNuevo
        '
        Appearance6.Image = Global.EfectiOro.My.Resources.Resources.add01
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance6.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnNuevo.Appearance = Appearance6
        Me.btnNuevo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnNuevo.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnNuevo.Location = New System.Drawing.Point(22, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 60)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        Me.erp.Icon = CType(resources.GetObject("erp.Icon"), System.Drawing.Icon)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvCierrePrecios)
        Me.GroupBox4.Location = New System.Drawing.Point(518, 31)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(450, 397)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'dgvCierrePrecios
        '
        Me.dgvCierrePrecios.AllowUserToAddRows = False
        Me.dgvCierrePrecios.AllowUserToDeleteRows = False
        Me.dgvCierrePrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCierrePrecios.BackgroundColor = System.Drawing.Color.White
        Me.dgvCierrePrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCierrePrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar, Me.colCodcierre, Me.colOnzas, Me.colPrecioOro, Me.colPrecioBase, Me.colMargen})
        Me.dgvCierrePrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCierrePrecios.Location = New System.Drawing.Point(3, 16)
        Me.dgvCierrePrecios.Name = "dgvCierrePrecios"
        Me.dgvCierrePrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCierrePrecios.Size = New System.Drawing.Size(444, 378)
        Me.dgvCierrePrecios.TabIndex = 0
        '
        'colSeleccionar
        '
        Me.colSeleccionar.HeaderText = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colCodcierre
        '
        Me.colCodcierre.HeaderText = "Codigo"
        Me.colCodcierre.Name = "colCodcierre"
        Me.colCodcierre.ReadOnly = True
        '
        'colOnzas
        '
        Me.colOnzas.HeaderText = "Onzas"
        Me.colOnzas.Name = "colOnzas"
        Me.colOnzas.ReadOnly = True
        '
        'colPrecioOro
        '
        Me.colPrecioOro.HeaderText = "Precio oro"
        Me.colPrecioOro.Name = "colPrecioOro"
        Me.colPrecioOro.ReadOnly = True
        '
        'colPrecioBase
        '
        Me.colPrecioBase.HeaderText = "Precio Base"
        Me.colPrecioBase.Name = "colPrecioBase"
        Me.colPrecioBase.ReadOnly = True
        '
        'colMargen
        '
        Me.colMargen.HeaderText = "Margen"
        Me.colMargen.Name = "colMargen"
        Me.colMargen.ReadOnly = True
        '
        'toolTip
        '
        Me.toolTip.ToolTipTitle = "EfectiOro"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lblOnzasDisponibles, Me.ToolStripSeparator1, Me.lblOnzasIn, Me.lblOnzasIngresar, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.lblOnzasDiferencia})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 437)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(980, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripLabel1.Text = "Onzas Disponibles:"
        '
        'lblOnzasDisponibles
        '
        Me.lblOnzasDisponibles.Name = "lblOnzasDisponibles"
        Me.lblOnzasDisponibles.Size = New System.Drawing.Size(28, 22)
        Me.lblOnzasDisponibles.Text = "0.00"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblOnzasIn
        '
        Me.lblOnzasIn.Name = "lblOnzasIn"
        Me.lblOnzasIn.Size = New System.Drawing.Size(101, 22)
        Me.lblOnzasIn.Text = "Onzas ingresadas:"
        '
        'lblOnzasIngresar
        '
        Me.lblOnzasIngresar.Name = "lblOnzasIngresar"
        Me.lblOnzasIngresar.Size = New System.Drawing.Size(28, 22)
        Me.lblOnzasIngresar.Text = "0.00"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripLabel2.Text = "Diferencia Onzas:"
        '
        'lblOnzasDiferencia
        '
        Me.lblOnzasDiferencia.Name = "lblOnzasDiferencia"
        Me.lblOnzasDiferencia.Size = New System.Drawing.Size(28, 22)
        Me.lblOnzasDiferencia.Text = "0.00"
        '
        'colLinea
        '
        Me.colLinea.HeaderText = "Linea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.ReadOnly = True
        '
        'colQuilate
        '
        Me.colQuilate.HeaderText = "Quilate"
        Me.colQuilate.Name = "colQuilate"
        Me.colQuilate.ReadOnly = True
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        '
        'colGramos
        '
        Me.colGramos.HeaderText = "Gramos"
        Me.colGramos.Name = "colGramos"
        Me.colGramos.ReadOnly = True
        '
        'colAgencia
        '
        Me.colAgencia.HeaderText = "Sucursal"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.ReadOnly = True
        '
        'frmPrecios2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(980, 462)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrecios2"
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.dgvCliente, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvCierrePrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtQuilate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioOro As System.Windows.Forms.TextBox
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnNuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMargen As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnQuitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCierrePrecios As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGramos As TextBox
    Friend WithEvents btnQuitarSeleccion As Infragistics.Win.Misc.UltraButton
    Friend WithEvents colSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents colCodcierre As DataGridViewTextBoxColumn
    Friend WithEvents colOnzas As DataGridViewTextBoxColumn
    Friend WithEvents colPrecioOro As DataGridViewTextBoxColumn
    Friend WithEvents colPrecioBase As DataGridViewTextBoxColumn
    Friend WithEvents colMargen As DataGridViewTextBoxColumn
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblOnzasDisponibles As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblOnzasIn As ToolStripLabel
    Friend WithEvents lblOnzasIngresar As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblOnzasDiferencia As ToolStripLabel
    Friend WithEvents colLinea As DataGridViewTextBoxColumn
    Friend WithEvents colQuilate As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents colGramos As DataGridViewTextBoxColumn
    Friend WithEvents colAgencia As DataGridViewComboBoxColumn
End Class

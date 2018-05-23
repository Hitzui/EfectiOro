<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptComrpas
    Inherits EfectiOro.frmPersonalizado

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTab1 = New System.Windows.Forms.TabControl()
        Me.pageCompragen = New System.Windows.Forms.TabPage()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.txtFechaSaldos = New System.Windows.Forms.DateTimePicker()
        Me.radSaldosComprasDescargues = New System.Windows.Forms.RadioButton()
        Me.cmbComprasGen = New System.Windows.Forms.ComboBox()
        Me.cmbOperadorFiltrar = New System.Windows.Forms.ComboBox()
        Me.radDetalleCompra = New System.Windows.Forms.RadioButton()
        Me.radOperador_general = New System.Windows.Forms.RadioButton()
        Me.cmbOperador = New System.Windows.Forms.ComboBox()
        Me.radPoroperador = New System.Windows.Forms.RadioButton()
        Me.radDetalle = New System.Windows.Forms.RadioButton()
        Me.radGeneral = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbFiltrarAgencia = New System.Windows.Forms.ComboBox()
        Me.chkFiltrarAgencia = New System.Windows.Forms.CheckBox()
        Me.txtHastaGen = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesdeGen = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraTab2 = New System.Windows.Forms.TabControl()
        Me.pageCompradet = New System.Windows.Forms.TabPage()
        Me.chkComprobante = New System.Windows.Forms.CheckBox()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.btnBuscardet = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvFiltrar = New System.Windows.Forms.DataGridView()
        Me.colNumeroCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtHastadet = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesdedet = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radPornumcompra = New System.Windows.Forms.RadioButton()
        Me.radPornombre = New System.Windows.Forms.RadioButton()
        Me.radPorcodigo = New System.Windows.Forms.RadioButton()
        Me.UltraTabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCargarLiquidacion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvLiquidacion = New System.Windows.Forms.DataGridView()
        Me.panelTitulo.SuspendLayout()
        Me.pageCompragen.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pageCompradet.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.UltraTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(638, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(613, 25)
        '
        'UltraTab1
        '
        Me.UltraTab1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTab1.Name = "UltraTab1"
        Me.UltraTab1.SelectedIndex = 0
        Me.UltraTab1.Size = New System.Drawing.Size(200, 100)
        Me.UltraTab1.TabIndex = 0
        Me.UltraTab1.Tag = "General"
        Me.UltraTab1.Text = "Compras Generales"
        '
        'pageCompragen
        '
        Me.pageCompragen.BackColor = System.Drawing.Color.White
        Me.pageCompragen.Controls.Add(Me.btnCancelar)
        Me.pageCompragen.Controls.Add(Me.btnBuscar)
        Me.pageCompragen.Controls.Add(Me.GroupBox2)
        Me.pageCompragen.Controls.Add(Me.GroupBox1)
        Me.pageCompragen.Location = New System.Drawing.Point(4, 22)
        Me.pageCompragen.Name = "pageCompragen"
        Me.pageCompragen.Size = New System.Drawing.Size(630, 319)
        Me.pageCompragen.TabIndex = 0
        Me.pageCompragen.Text = "Ver compras en general"
        '
        'btnCancelar
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnCancelar.Appearance = Appearance1
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCancelar.Location = New System.Drawing.Point(537, 271)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 40)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnBuscar
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.print_view_48
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnBuscar.Appearance = Appearance2
        Me.btnBuscar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnBuscar.ImageSize = New System.Drawing.Size(38, 38)
        Me.btnBuscar.Location = New System.Drawing.Point(245, 261)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(74, 50)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTipoPago)
        Me.GroupBox2.Controls.Add(Me.txtFechaSaldos)
        Me.GroupBox2.Controls.Add(Me.radSaldosComprasDescargues)
        Me.GroupBox2.Controls.Add(Me.cmbComprasGen)
        Me.GroupBox2.Controls.Add(Me.cmbOperadorFiltrar)
        Me.GroupBox2.Controls.Add(Me.radDetalleCompra)
        Me.GroupBox2.Controls.Add(Me.radOperador_general)
        Me.GroupBox2.Controls.Add(Me.cmbOperador)
        Me.GroupBox2.Controls.Add(Me.radPoroperador)
        Me.GroupBox2.Controls.Add(Me.radDetalle)
        Me.GroupBox2.Controls.Add(Me.radGeneral)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(226, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 241)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por"
        '
        'cmbTipoPago
        '
        Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPago.FormattingEnabled = True
        Me.cmbTipoPago.Items.AddRange(New Object() {"Agrupadas por cliente", "General"})
        Me.cmbTipoPago.Location = New System.Drawing.Point(234, 89)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.Size = New System.Drawing.Size(152, 23)
        Me.cmbTipoPago.TabIndex = 14
        Me.cmbTipoPago.Visible = False
        '
        'txtFechaSaldos
        '
        Me.txtFechaSaldos.CustomFormat = "yyyy"
        Me.txtFechaSaldos.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaSaldos.Location = New System.Drawing.Point(234, 188)
        Me.txtFechaSaldos.Name = "txtFechaSaldos"
        Me.txtFechaSaldos.Size = New System.Drawing.Size(152, 21)
        Me.txtFechaSaldos.TabIndex = 13
        Me.txtFechaSaldos.Visible = False
        '
        'radSaldosComprasDescargues
        '
        Me.radSaldosComprasDescargues.AutoSize = True
        Me.radSaldosComprasDescargues.Location = New System.Drawing.Point(14, 188)
        Me.radSaldosComprasDescargues.Name = "radSaldosComprasDescargues"
        Me.radSaldosComprasDescargues.Size = New System.Drawing.Size(206, 19)
        Me.radSaldosComprasDescargues.TabIndex = 12
        Me.radSaldosComprasDescargues.Text = "Ver saldos compras / descargues"
        Me.radSaldosComprasDescargues.UseVisualStyleBackColor = True
        '
        'cmbComprasGen
        '
        Me.cmbComprasGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComprasGen.FormattingEnabled = True
        Me.cmbComprasGen.Items.AddRange(New Object() {"Consilidado", "Agrupados por clientes", "General onzas", "Saldos por pagar"})
        Me.cmbComprasGen.Location = New System.Drawing.Point(234, 32)
        Me.cmbComprasGen.Name = "cmbComprasGen"
        Me.cmbComprasGen.Size = New System.Drawing.Size(152, 23)
        Me.cmbComprasGen.TabIndex = 11
        '
        'cmbOperadorFiltrar
        '
        Me.cmbOperadorFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperadorFiltrar.FormattingEnabled = True
        Me.cmbOperadorFiltrar.Items.AddRange(New Object() {"General", "Detallado"})
        Me.cmbOperadorFiltrar.Location = New System.Drawing.Point(234, 122)
        Me.cmbOperadorFiltrar.Name = "cmbOperadorFiltrar"
        Me.cmbOperadorFiltrar.Size = New System.Drawing.Size(152, 23)
        Me.cmbOperadorFiltrar.TabIndex = 10
        Me.cmbOperadorFiltrar.Visible = False
        '
        'radDetalleCompra
        '
        Me.radDetalleCompra.AutoSize = True
        Me.radDetalleCompra.Location = New System.Drawing.Point(14, 95)
        Me.radDetalleCompra.Name = "radDetalleCompra"
        Me.radDetalleCompra.Size = New System.Drawing.Size(169, 19)
        Me.radDetalleCompra.TabIndex = 9
        Me.radDetalleCompra.Text = "Detalle compras tipo pago"
        Me.radDetalleCompra.UseVisualStyleBackColor = True
        '
        'radOperador_general
        '
        Me.radOperador_general.AutoSize = True
        Me.radOperador_general.Location = New System.Drawing.Point(14, 126)
        Me.radOperador_general.Name = "radOperador_general"
        Me.radOperador_general.Size = New System.Drawing.Size(214, 19)
        Me.radOperador_general.TabIndex = 7
        Me.radOperador_general.Text = "Compras agrupados por operador:"
        Me.radOperador_general.UseVisualStyleBackColor = True
        '
        'cmbOperador
        '
        Me.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperador.FormattingEnabled = True
        Me.cmbOperador.Location = New System.Drawing.Point(234, 154)
        Me.cmbOperador.Name = "cmbOperador"
        Me.cmbOperador.Size = New System.Drawing.Size(152, 23)
        Me.cmbOperador.TabIndex = 6
        Me.cmbOperador.Visible = False
        '
        'radPoroperador
        '
        Me.radPoroperador.AutoSize = True
        Me.radPoroperador.Location = New System.Drawing.Point(14, 157)
        Me.radPoroperador.Name = "radPoroperador"
        Me.radPoroperador.Size = New System.Drawing.Size(149, 19)
        Me.radPoroperador.TabIndex = 5
        Me.radPoroperador.Text = "Compras por operador"
        Me.radPoroperador.UseVisualStyleBackColor = True
        '
        'radDetalle
        '
        Me.radDetalle.AutoSize = True
        Me.radDetalle.Location = New System.Drawing.Point(14, 64)
        Me.radDetalle.Name = "radDetalle"
        Me.radDetalle.Size = New System.Drawing.Size(150, 19)
        Me.radDetalle.TabIndex = 2
        Me.radDetalle.Text = "Detalle de compras TC"
        Me.radDetalle.UseVisualStyleBackColor = True
        '
        'radGeneral
        '
        Me.radGeneral.AutoSize = True
        Me.radGeneral.Checked = True
        Me.radGeneral.Location = New System.Drawing.Point(14, 33)
        Me.radGeneral.Name = "radGeneral"
        Me.radGeneral.Size = New System.Drawing.Size(97, 19)
        Me.radGeneral.TabIndex = 0
        Me.radGeneral.TabStop = True
        Me.radGeneral.Text = "Ver compras:"
        Me.radGeneral.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbFiltrarAgencia)
        Me.GroupBox1.Controls.Add(Me.chkFiltrarAgencia)
        Me.GroupBox1.Controls.Add(Me.txtHastaGen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDesdeGen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 241)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fechas"
        '
        'cmbFiltrarAgencia
        '
        Me.cmbFiltrarAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltrarAgencia.Enabled = False
        Me.cmbFiltrarAgencia.FormattingEnabled = True
        Me.cmbFiltrarAgencia.Location = New System.Drawing.Point(24, 178)
        Me.cmbFiltrarAgencia.Name = "cmbFiltrarAgencia"
        Me.cmbFiltrarAgencia.Size = New System.Drawing.Size(161, 23)
        Me.cmbFiltrarAgencia.TabIndex = 5
        '
        'chkFiltrarAgencia
        '
        Me.chkFiltrarAgencia.AutoSize = True
        Me.chkFiltrarAgencia.Location = New System.Drawing.Point(24, 153)
        Me.chkFiltrarAgencia.Name = "chkFiltrarAgencia"
        Me.chkFiltrarAgencia.Size = New System.Drawing.Size(130, 19)
        Me.chkFiltrarAgencia.TabIndex = 4
        Me.chkFiltrarAgencia.Text = "Filtrar por sucursal:"
        Me.chkFiltrarAgencia.UseVisualStyleBackColor = True
        '
        'txtHastaGen
        '
        Me.txtHastaGen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHastaGen.Location = New System.Drawing.Point(24, 97)
        Me.txtHastaGen.Name = "txtHastaGen"
        Me.txtHastaGen.Size = New System.Drawing.Size(161, 21)
        Me.txtHastaGen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'txtDesdeGen
        '
        Me.txtDesdeGen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesdeGen.Location = New System.Drawing.Point(24, 49)
        Me.txtDesdeGen.Name = "txtDesdeGen"
        Me.txtDesdeGen.Size = New System.Drawing.Size(161, 21)
        Me.txtDesdeGen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'UltraTab2
        '
        Me.UltraTab2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTab2.Name = "UltraTab2"
        Me.UltraTab2.SelectedIndex = 0
        Me.UltraTab2.Size = New System.Drawing.Size(200, 100)
        Me.UltraTab2.TabIndex = 0
        Me.UltraTab2.Tag = "Detalle"
        Me.UltraTab2.Text = "Compras en detalles"
        '
        'pageCompradet
        '
        Me.pageCompradet.BackColor = System.Drawing.Color.White
        Me.pageCompradet.Controls.Add(Me.chkComprobante)
        Me.pageCompradet.Controls.Add(Me.UltraButton2)
        Me.pageCompradet.Controls.Add(Me.btnBuscardet)
        Me.pageCompradet.Controls.Add(Me.GroupBox5)
        Me.pageCompradet.Controls.Add(Me.GroupBox4)
        Me.pageCompradet.Controls.Add(Me.GroupBox3)
        Me.pageCompradet.Location = New System.Drawing.Point(4, 22)
        Me.pageCompradet.Name = "pageCompradet"
        Me.pageCompradet.Size = New System.Drawing.Size(630, 319)
        Me.pageCompradet.TabIndex = 0
        Me.pageCompradet.Text = "Filtrar por cliente"
        '
        'chkComprobante
        '
        Me.chkComprobante.AutoSize = True
        Me.chkComprobante.Location = New System.Drawing.Point(12, 269)
        Me.chkComprobante.Name = "chkComprobante"
        Me.chkComprobante.Size = New System.Drawing.Size(195, 17)
        Me.chkComprobante.TabIndex = 8
        Me.chkComprobante.Text = "Imprimir Comprobante de liquidacion"
        Me.chkComprobante.UseVisualStyleBackColor = True
        '
        'UltraButton2
        '
        Appearance3.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.UltraButton2.Appearance = Appearance3
        Me.UltraButton2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.UltraButton2.ImageSize = New System.Drawing.Size(32, 32)
        Me.UltraButton2.Location = New System.Drawing.Point(538, 258)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(51, 50)
        Me.UltraButton2.TabIndex = 7
        Me.UltraButton2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnBuscardet
        '
        Appearance4.Image = Global.EfectiOro.My.Resources.Resources.print_view_48
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnBuscardet.Appearance = Appearance4
        Me.btnBuscardet.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnBuscardet.ImageSize = New System.Drawing.Size(38, 38)
        Me.btnBuscardet.Location = New System.Drawing.Point(232, 258)
        Me.btnBuscardet.Name = "btnBuscardet"
        Me.btnBuscardet.Size = New System.Drawing.Size(61, 50)
        Me.btnBuscardet.TabIndex = 6
        Me.btnBuscardet.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvFiltrar)
        Me.GroupBox5.Controls.Add(Me.txtFiltrar)
        Me.GroupBox5.Controls.Add(Me.lblBuscar)
        Me.GroupBox5.Location = New System.Drawing.Point(191, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(434, 248)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'dgvFiltrar
        '
        Me.dgvFiltrar.AllowUserToAddRows = False
        Me.dgvFiltrar.AllowUserToDeleteRows = False
        Me.dgvFiltrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFiltrar.BackgroundColor = System.Drawing.Color.White
        Me.dgvFiltrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiltrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumeroCompra, Me.colCodigo, Me.colNombre, Me.colApellido})
        Me.dgvFiltrar.Location = New System.Drawing.Point(6, 62)
        Me.dgvFiltrar.Name = "dgvFiltrar"
        Me.dgvFiltrar.ReadOnly = True
        Me.dgvFiltrar.Size = New System.Drawing.Size(422, 180)
        Me.dgvFiltrar.TabIndex = 2
        '
        'colNumeroCompra
        '
        Me.colNumeroCompra.HeaderText = "N° Compra"
        Me.colNumeroCompra.Name = "colNumeroCompra"
        Me.colNumeroCompra.ReadOnly = True
        Me.colNumeroCompra.Visible = False
        Me.colNumeroCompra.Width = 83
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 65
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 69
        '
        'colApellido
        '
        Me.colApellido.HeaderText = "Apellido"
        Me.colApellido.Name = "colApellido"
        Me.colApellido.ReadOnly = True
        Me.colApellido.Width = 69
        '
        'txtFiltrar
        '
        Me.txtFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltrar.Location = New System.Drawing.Point(6, 36)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(422, 20)
        Me.txtFiltrar.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(6, 20)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(46, 13)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "(Buscar)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtHastadet)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtDesdedet)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(173, 112)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rango de fechas"
        '
        'txtHastadet
        '
        Me.txtHastadet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHastadet.Location = New System.Drawing.Point(11, 82)
        Me.txtHastadet.Name = "txtHastadet"
        Me.txtHastadet.Size = New System.Drawing.Size(132, 20)
        Me.txtHastadet.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hasta:"
        '
        'txtDesdedet
        '
        Me.txtDesdedet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesdedet.Location = New System.Drawing.Point(11, 34)
        Me.txtDesdedet.Name = "txtDesdedet"
        Me.txtDesdedet.Size = New System.Drawing.Size(132, 20)
        Me.txtDesdedet.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Desde:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radPornumcompra)
        Me.GroupBox3.Controls.Add(Me.radPornombre)
        Me.GroupBox3.Controls.Add(Me.radPorcodigo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 130)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Generar"
        '
        'radPornumcompra
        '
        Me.radPornumcompra.AutoSize = True
        Me.radPornumcompra.Location = New System.Drawing.Point(11, 73)
        Me.radPornumcompra.Name = "radPornumcompra"
        Me.radPornumcompra.Size = New System.Drawing.Size(132, 17)
        Me.radPornumcompra.TabIndex = 2
        Me.radPornumcompra.Text = "Por número de compra"
        Me.radPornumcompra.UseVisualStyleBackColor = True
        '
        'radPornombre
        '
        Me.radPornombre.AutoSize = True
        Me.radPornombre.Location = New System.Drawing.Point(11, 48)
        Me.radPornombre.Name = "radPornombre"
        Me.radPornombre.Size = New System.Drawing.Size(128, 17)
        Me.radPornombre.TabIndex = 1
        Me.radPornombre.Text = "Por nombre de cliente"
        Me.radPornombre.UseVisualStyleBackColor = True
        '
        'radPorcodigo
        '
        Me.radPorcodigo.AutoSize = True
        Me.radPorcodigo.Checked = True
        Me.radPorcodigo.Location = New System.Drawing.Point(11, 23)
        Me.radPorcodigo.Name = "radPorcodigo"
        Me.radPorcodigo.Size = New System.Drawing.Size(125, 17)
        Me.radPorcodigo.TabIndex = 0
        Me.radPorcodigo.TabStop = True
        Me.radPorcodigo.Text = "Por código de cliente"
        Me.radPorcodigo.UseVisualStyleBackColor = True
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.pageCompragen)
        Me.UltraTabControl1.Controls.Add(Me.pageCompradet)
        Me.UltraTabControl1.Controls.Add(Me.TabPage1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 25)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SelectedIndex = 0
        Me.UltraTabControl1.Size = New System.Drawing.Size(638, 345)
        Me.UltraTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.btnCargarLiquidacion)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.dgvLiquidacion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(630, 319)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Liquidacion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.EfectiOro.My.Resources.Resources._23
        Me.Button2.Location = New System.Drawing.Point(534, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCargarLiquidacion
        '
        Me.btnCargarLiquidacion.Location = New System.Drawing.Point(30, 256)
        Me.btnCargarLiquidacion.Name = "btnCargarLiquidacion"
        Me.btnCargarLiquidacion.Size = New System.Drawing.Size(100, 35)
        Me.btnCargarLiquidacion.TabIndex = 2
        Me.btnCargarLiquidacion.Text = "Cargar datos"
        Me.btnCargarLiquidacion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.EfectiOro.My.Resources.Resources.analysis
        Me.Button1.Location = New System.Drawing.Point(416, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvLiquidacion
        '
        Me.dgvLiquidacion.BackgroundColor = System.Drawing.Color.White
        Me.dgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLiquidacion.Location = New System.Drawing.Point(8, 6)
        Me.dgvLiquidacion.Name = "dgvLiquidacion"
        Me.dgvLiquidacion.Size = New System.Drawing.Size(614, 234)
        Me.dgvLiquidacion.TabIndex = 0
        '
        'frmRptComrpas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(638, 370)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Name = "frmRptComrpas"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.UltraTabControl1, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.pageCompragen.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pageCompradet.ResumeLayout(False)
        Me.pageCompradet.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabControl1 As TabControl
    Friend WithEvents pageCompragen As TabPage
    Friend WithEvents pageCompradet As TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHastaGen As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesdeGen As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radDetalle As System.Windows.Forms.RadioButton
    Friend WithEvents radGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radPornumcompra As System.Windows.Forms.RadioButton
    Friend WithEvents radPornombre As System.Windows.Forms.RadioButton
    Friend WithEvents radPorcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHastadet As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDesdedet As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvFiltrar As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents colNumeroCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents radPoroperador As System.Windows.Forms.RadioButton
    Friend WithEvents cmbOperador As System.Windows.Forms.ComboBox
    Friend WithEvents radOperador_general As System.Windows.Forms.RadioButton
    Friend WithEvents radDetalleCompra As System.Windows.Forms.RadioButton
    Friend WithEvents cmbOperadorFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbComprasGen As System.Windows.Forms.ComboBox
    Friend WithEvents UltraTab1 As TabControl
    Friend WithEvents UltraTab2 As TabControl
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBuscardet As Infragistics.Win.Misc.UltraButton
    Friend WithEvents radSaldosComprasDescargues As System.Windows.Forms.RadioButton
    Friend WithEvents txtFechaSaldos As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkComprobante As CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnCargarLiquidacion As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvLiquidacion As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbFiltrarAgencia As System.Windows.Forms.ComboBox
    Friend WithEvents chkFiltrarAgencia As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
End Class

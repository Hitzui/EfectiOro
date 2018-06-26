<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUPM
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.tabUPM = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvUpmDatos = New System.Windows.Forms.DataGridView()
        Me.colCodupm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOnzas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sourceUPM = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOnzas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoUPM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabRegistro = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvCierres = New System.Windows.Forms.DataGridView()
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCodCierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OnzasFinasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GramosFinosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioOroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioBaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoOnzasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MargenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sourcecierre = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvUPM = New System.Windows.Forms.DataGridView()
        Me.colCodupmRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnzasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnNuevo = New Infragistics.Win.Misc.UltraButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblOnzasUPM2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOnzasUPM = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOnzasCierre = New System.Windows.Forms.ToolStripLabel()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabUPM.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvUpmDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourceUPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabRegistro.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvCierres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourcecierre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvUPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(620, 25)
        '
        'tabUPM
        '
        Me.tabUPM.Controls.Add(Me.tabDatos)
        Me.tabUPM.Controls.Add(Me.tabRegistro)
        Me.tabUPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabUPM.Location = New System.Drawing.Point(0, 25)
        Me.tabUPM.Name = "tabUPM"
        Me.tabUPM.SelectedIndex = 0
        Me.tabUPM.Size = New System.Drawing.Size(620, 295)
        Me.tabUPM.TabIndex = 1
        '
        'tabDatos
        '
        Me.tabDatos.AutoScroll = True
        Me.tabDatos.Controls.Add(Me.GroupBox3)
        Me.tabDatos.Controls.Add(Me.GroupBox1)
        Me.tabDatos.Location = New System.Drawing.Point(4, 22)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatos.Size = New System.Drawing.Size(612, 269)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos UPM"
        Me.tabDatos.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvUpmDatos)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(224, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 263)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'dgvUpmDatos
        '
        Me.dgvUpmDatos.AllowUserToAddRows = False
        Me.dgvUpmDatos.AllowUserToDeleteRows = False
        Me.dgvUpmDatos.AutoGenerateColumns = False
        Me.dgvUpmDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUpmDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvUpmDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpmDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodupm, Me.colCodigo, Me.colOnzas, Me.colPrecio, Me.colFecha, Me.colStatus})
        Me.dgvUpmDatos.DataSource = Me.sourceUPM
        Me.dgvUpmDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUpmDatos.Enabled = False
        Me.dgvUpmDatos.Location = New System.Drawing.Point(3, 16)
        Me.dgvUpmDatos.Name = "dgvUpmDatos"
        Me.dgvUpmDatos.ReadOnly = True
        Me.dgvUpmDatos.Size = New System.Drawing.Size(379, 244)
        Me.dgvUpmDatos.TabIndex = 0
        '
        'colCodupm
        '
        Me.colCodupm.DataPropertyName = "Codupm"
        Me.colCodupm.HeaderText = "Codupm"
        Me.colCodupm.Name = "colCodupm"
        Me.colCodupm.ReadOnly = True
        Me.colCodupm.Visible = False
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "Codigo"
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        '
        'colOnzas
        '
        Me.colOnzas.DataPropertyName = "Onzas"
        Me.colOnzas.HeaderText = "Onzas"
        Me.colOnzas.Name = "colOnzas"
        Me.colOnzas.ReadOnly = True
        '
        'colPrecio
        '
        Me.colPrecio.DataPropertyName = "Precio"
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        '
        'colFecha
        '
        Me.colFecha.DataPropertyName = "Fecha"
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "Status"
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'sourceUPM
        '
        Me.sourceUPM.DataSource = GetType(EfectiOro.Database.Upm)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOnzas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigoUPM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 263)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(83, 145)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(106, 20)
        Me.txtFecha.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(83, 107)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(106, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio:"
        '
        'txtOnzas
        '
        Me.txtOnzas.Enabled = False
        Me.txtOnzas.Location = New System.Drawing.Point(83, 71)
        Me.txtOnzas.Name = "txtOnzas"
        Me.txtOnzas.Size = New System.Drawing.Size(106, 20)
        Me.txtOnzas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Onzas (Qty):"
        '
        'txtCodigoUPM
        '
        Me.txtCodigoUPM.Enabled = False
        Me.txtCodigoUPM.Location = New System.Drawing.Point(83, 26)
        Me.txtCodigoUPM.Name = "txtCodigoUPM"
        Me.txtCodigoUPM.Size = New System.Drawing.Size(106, 20)
        Me.txtCodigoUPM.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo UPM:"
        '
        'tabRegistro
        '
        Me.tabRegistro.Controls.Add(Me.GroupBox5)
        Me.tabRegistro.Controls.Add(Me.GroupBox4)
        Me.tabRegistro.Location = New System.Drawing.Point(4, 22)
        Me.tabRegistro.Name = "tabRegistro"
        Me.tabRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRegistro.Size = New System.Drawing.Size(612, 269)
        Me.tabRegistro.TabIndex = 1
        Me.tabRegistro.Text = "Registro UPM"
        Me.tabRegistro.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvCierres)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(272, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(337, 263)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cierre onzas"
        '
        'dgvCierres
        '
        Me.dgvCierres.AllowUserToAddRows = False
        Me.dgvCierres.AllowUserToDeleteRows = False
        Me.dgvCierres.AutoGenerateColumns = False
        Me.dgvCierres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCierres.BackgroundColor = System.Drawing.Color.White
        Me.dgvCierres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCierres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar, Me.colCodCierre, Me.CodclienteDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn1, Me.OnzasFinasDataGridViewTextBoxColumn, Me.GramosFinosDataGridViewTextBoxColumn, Me.PrecioOroDataGridViewTextBoxColumn, Me.PrecioBaseDataGridViewTextBoxColumn, Me.SaldoOnzasDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn1, Me.MargenDataGridViewTextBoxColumn})
        Me.dgvCierres.DataSource = Me.sourcecierre
        Me.dgvCierres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCierres.Enabled = False
        Me.dgvCierres.Location = New System.Drawing.Point(3, 16)
        Me.dgvCierres.Name = "dgvCierres"
        Me.dgvCierres.Size = New System.Drawing.Size(331, 244)
        Me.dgvCierres.TabIndex = 1
        '
        'colSeleccionar
        '
        Me.colSeleccionar.HeaderText = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Width = 69
        '
        'colCodCierre
        '
        Me.colCodCierre.DataPropertyName = "CodCierre"
        Me.colCodCierre.HeaderText = "Codigo"
        Me.colCodCierre.Name = "colCodCierre"
        Me.colCodCierre.ReadOnly = True
        Me.colCodCierre.Width = 65
        '
        'CodclienteDataGridViewTextBoxColumn
        '
        Me.CodclienteDataGridViewTextBoxColumn.DataPropertyName = "Codcliente"
        Me.CodclienteDataGridViewTextBoxColumn.HeaderText = "Cod cliente"
        Me.CodclienteDataGridViewTextBoxColumn.Name = "CodclienteDataGridViewTextBoxColumn"
        Me.CodclienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodclienteDataGridViewTextBoxColumn.Width = 85
        '
        'StatusDataGridViewCheckBoxColumn1
        '
        Me.StatusDataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.StatusDataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn1.Name = "StatusDataGridViewCheckBoxColumn1"
        Me.StatusDataGridViewCheckBoxColumn1.Visible = False
        Me.StatusDataGridViewCheckBoxColumn1.Width = 43
        '
        'OnzasFinasDataGridViewTextBoxColumn
        '
        Me.OnzasFinasDataGridViewTextBoxColumn.DataPropertyName = "OnzasFinas"
        Me.OnzasFinasDataGridViewTextBoxColumn.HeaderText = "Onzas"
        Me.OnzasFinasDataGridViewTextBoxColumn.Name = "OnzasFinasDataGridViewTextBoxColumn"
        Me.OnzasFinasDataGridViewTextBoxColumn.ReadOnly = True
        Me.OnzasFinasDataGridViewTextBoxColumn.Width = 62
        '
        'GramosFinosDataGridViewTextBoxColumn
        '
        Me.GramosFinosDataGridViewTextBoxColumn.DataPropertyName = "GramosFinos"
        Me.GramosFinosDataGridViewTextBoxColumn.HeaderText = "GramosFinos"
        Me.GramosFinosDataGridViewTextBoxColumn.Name = "GramosFinosDataGridViewTextBoxColumn"
        Me.GramosFinosDataGridViewTextBoxColumn.Visible = False
        Me.GramosFinosDataGridViewTextBoxColumn.Width = 93
        '
        'PrecioOroDataGridViewTextBoxColumn
        '
        Me.PrecioOroDataGridViewTextBoxColumn.DataPropertyName = "PrecioOro"
        Me.PrecioOroDataGridViewTextBoxColumn.HeaderText = "PrecioOro"
        Me.PrecioOroDataGridViewTextBoxColumn.Name = "PrecioOroDataGridViewTextBoxColumn"
        Me.PrecioOroDataGridViewTextBoxColumn.Visible = False
        Me.PrecioOroDataGridViewTextBoxColumn.Width = 79
        '
        'PrecioBaseDataGridViewTextBoxColumn
        '
        Me.PrecioBaseDataGridViewTextBoxColumn.DataPropertyName = "PrecioBase"
        Me.PrecioBaseDataGridViewTextBoxColumn.HeaderText = "PrecioBase"
        Me.PrecioBaseDataGridViewTextBoxColumn.Name = "PrecioBaseDataGridViewTextBoxColumn"
        Me.PrecioBaseDataGridViewTextBoxColumn.Visible = False
        Me.PrecioBaseDataGridViewTextBoxColumn.Width = 86
        '
        'SaldoOnzasDataGridViewTextBoxColumn
        '
        Me.SaldoOnzasDataGridViewTextBoxColumn.DataPropertyName = "SaldoOnzas"
        Me.SaldoOnzasDataGridViewTextBoxColumn.HeaderText = "SaldoOnzas"
        Me.SaldoOnzasDataGridViewTextBoxColumn.Name = "SaldoOnzasDataGridViewTextBoxColumn"
        Me.SaldoOnzasDataGridViewTextBoxColumn.Visible = False
        Me.SaldoOnzasDataGridViewTextBoxColumn.Width = 89
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.Visible = False
        Me.FechaDataGridViewTextBoxColumn1.Width = 62
        '
        'MargenDataGridViewTextBoxColumn
        '
        Me.MargenDataGridViewTextBoxColumn.DataPropertyName = "Margen"
        Me.MargenDataGridViewTextBoxColumn.HeaderText = "Margen"
        Me.MargenDataGridViewTextBoxColumn.Name = "MargenDataGridViewTextBoxColumn"
        Me.MargenDataGridViewTextBoxColumn.Visible = False
        Me.MargenDataGridViewTextBoxColumn.Width = 68
        '
        'sourcecierre
        '
        Me.sourcecierre.DataSource = GetType(EfectiOro.Database.CierrePrecios)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvUPM)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(269, 263)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "UPM"
        '
        'dgvUPM
        '
        Me.dgvUPM.AllowUserToAddRows = False
        Me.dgvUPM.AllowUserToDeleteRows = False
        Me.dgvUPM.AutoGenerateColumns = False
        Me.dgvUPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUPM.BackgroundColor = System.Drawing.Color.White
        Me.dgvUPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUPM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodupmRegistro, Me.CodigoDataGridViewTextBoxColumn, Me.OnzasDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn})
        Me.dgvUPM.DataSource = Me.sourceUPM
        Me.dgvUPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUPM.Location = New System.Drawing.Point(3, 16)
        Me.dgvUPM.Name = "dgvUPM"
        Me.dgvUPM.ReadOnly = True
        Me.dgvUPM.Size = New System.Drawing.Size(263, 244)
        Me.dgvUPM.TabIndex = 0
        '
        'colCodupmRegistro
        '
        Me.colCodupmRegistro.DataPropertyName = "Codupm"
        Me.colCodupmRegistro.HeaderText = "Codupm"
        Me.colCodupmRegistro.Name = "colCodupmRegistro"
        Me.colCodupmRegistro.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OnzasDataGridViewTextBoxColumn
        '
        Me.OnzasDataGridViewTextBoxColumn.DataPropertyName = "Onzas"
        Me.OnzasDataGridViewTextBoxColumn.HeaderText = "Onzas"
        Me.OnzasDataGridViewTextBoxColumn.Name = "OnzasDataGridViewTextBoxColumn"
        Me.OnzasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.ReadOnly = True
        Me.StatusDataGridViewCheckBoxColumn.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 82)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnSalir
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnSalir.Appearance = Appearance1
        Me.btnSalir.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnSalir.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnSalir.Location = New System.Drawing.Point(530, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(68, 48)
        Me.btnSalir.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Salir")
        Me.btnSalir.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCancelar
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.cancel02
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnCancelar.Appearance = Appearance2
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnCancelar.Location = New System.Drawing.Point(337, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(68, 48)
        Me.btnCancelar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar todo")
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEliminar
        '
        Appearance3.Image = Global.EfectiOro.My.Resources.Resources.trash
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnEliminar.Appearance = Appearance3
        Me.btnEliminar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnEliminar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnEliminar.Location = New System.Drawing.Point(258, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 48)
        Me.btnEliminar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar Registro")
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEditar
        '
        Appearance4.Image = Global.EfectiOro.My.Resources.Resources.edit01
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnEditar.Appearance = Appearance4
        Me.btnEditar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnEditar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnEditar.Location = New System.Drawing.Point(179, 19)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(68, 48)
        Me.btnEditar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnEditar, "Editar registro")
        Me.btnEditar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnGuardar
        '
        Appearance5.Image = Global.EfectiOro.My.Resources.Resources.save01
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnGuardar.Appearance = Appearance5
        Me.btnGuardar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Location = New System.Drawing.Point(100, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(68, 48)
        Me.btnGuardar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar registro")
        Me.btnGuardar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnNuevo
        '
        Appearance6.Image = Global.EfectiOro.My.Resources.Resources.add01
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnNuevo.Appearance = Appearance6
        Me.btnNuevo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnNuevo.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnNuevo.Location = New System.Drawing.Point(21, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(68, 48)
        Me.btnNuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo Registro")
        Me.btnNuevo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblOnzasUPM2, Me.lblOnzasUPM, Me.ToolStripLabel1, Me.lblOnzasCierre})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 402)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(620, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblOnzasUPM2
        '
        Me.lblOnzasUPM2.Name = "lblOnzasUPM2"
        Me.lblOnzasUPM2.Size = New System.Drawing.Size(71, 22)
        Me.lblOnzasUPM2.Text = "Onzas UPM:"
        '
        'lblOnzasUPM
        '
        Me.lblOnzasUPM.Name = "lblOnzasUPM"
        Me.lblOnzasUPM.Size = New System.Drawing.Size(36, 22)
        Me.lblOnzasUPM.Text = "(0.00)"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripLabel1.Text = "Onzas cierres:"
        '
        'lblOnzasCierre
        '
        Me.lblOnzasCierre.Name = "lblOnzasCierre"
        Me.lblOnzasCierre.Size = New System.Drawing.Size(36, 22)
        Me.lblOnzasCierre.Text = "(0.00)"
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmUPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(620, 427)
        Me.Controls.Add(Me.tabUPM)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmUPM"
        Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.tabUPM, 0)
        Me.tabUPM.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvUpmDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourceUPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabRegistro.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvCierres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourcecierre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvUPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabUPM As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents tabRegistro As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOnzas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoUPM As TextBox
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnNuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents erp As ErrorProvider
    Friend WithEvents sourceUPM As BindingSource
    Friend WithEvents dgvUpmDatos As DataGridView
    Friend WithEvents colCodupm As DataGridViewTextBoxColumn
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colOnzas As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvCierres As DataGridView
    Friend WithEvents dgvUPM As DataGridView
    Friend WithEvents sourcecierre As BindingSource
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lblOnzasUPM2 As ToolStripLabel
    Friend WithEvents lblOnzasUPM As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblOnzasCierre As ToolStripLabel
    Friend WithEvents colSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents colCodCierre As DataGridViewTextBoxColumn
    Friend WithEvents CodclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents OnzasFinasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GramosFinosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioOroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioBaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoOnzasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MargenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colCodupmRegistro As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OnzasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class

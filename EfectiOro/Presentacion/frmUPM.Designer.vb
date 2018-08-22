<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUPM
    Inherits EfectiOro.frmPersonalizado

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOnzas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoUPM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnNuevo = New Infragistics.Win.Misc.UltraButton()
        Me.tabRegistro = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblOnzas = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnOnzas = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblOnzasUPM = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalcularOnzasUPM = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblOnzasCierres = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalcularOnzasCierres = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblSumOnzasCompras = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalcularOnzasCompra = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnGuardarDetaUPM = New Infragistics.Win.Misc.UltraButton()
        Me.btnSalir2 = New Infragistics.Win.Misc.UltraButton()
        Me.btnFiltrar = New Infragistics.Win.Misc.UltraButton()
        Me.txtMontoEstimado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFiltrarFecha = New System.Windows.Forms.DateTimePicker()
        Me.dgvUpm = New System.Windows.Forms.DataGridView()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sourcecierre = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsUpm = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSeleccionarUPM = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodupmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnzasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabUPM.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvUpmDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourceUPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabRegistro.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvUpm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourcecierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUpm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabUPM.Controls.Add(Me.TabPage1)
        Me.tabUPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabUPM.Location = New System.Drawing.Point(0, 25)
        Me.tabUPM.Name = "tabUPM"
        Me.tabUPM.SelectedIndex = 0
        Me.tabUPM.Size = New System.Drawing.Size(620, 402)
        Me.tabUPM.TabIndex = 1
        '
        'tabDatos
        '
        Me.tabDatos.AutoScroll = True
        Me.tabDatos.Controls.Add(Me.GroupBox3)
        Me.tabDatos.Controls.Add(Me.GroupBox1)
        Me.tabDatos.Controls.Add(Me.GroupBox2)
        Me.tabDatos.Location = New System.Drawing.Point(4, 22)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatos.Size = New System.Drawing.Size(612, 376)
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
        Me.GroupBox3.Size = New System.Drawing.Size(385, 288)
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
        Me.dgvUpmDatos.Size = New System.Drawing.Size(379, 269)
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
        Me.GroupBox1.Controls.Add(Me.chkStatus)
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
        Me.GroupBox1.Size = New System.Drawing.Size(221, 288)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Checked = True
        Me.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStatus.Enabled = False
        Me.chkStatus.Location = New System.Drawing.Point(80, 188)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(103, 17)
        Me.chkStatus.TabIndex = 8
        Me.chkStatus.Text = "Estado del UPM"
        Me.chkStatus.UseVisualStyleBackColor = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 82)
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
        Me.btnNuevo.Location = New System.Drawing.Point(26, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(68, 48)
        Me.btnNuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo Registro")
        Me.btnNuevo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'tabRegistro
        '
        Me.tabRegistro.Controls.Add(Me.GroupBox8)
        Me.tabRegistro.Controls.Add(Me.GroupBox7)
        Me.tabRegistro.Controls.Add(Me.GroupBox6)
        Me.tabRegistro.Controls.Add(Me.GroupBox5)
        Me.tabRegistro.Controls.Add(Me.GroupBox4)
        Me.tabRegistro.Location = New System.Drawing.Point(4, 22)
        Me.tabRegistro.Name = "tabRegistro"
        Me.tabRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRegistro.Size = New System.Drawing.Size(612, 376)
        Me.tabRegistro.TabIndex = 1
        Me.tabRegistro.Text = "Registro UPM"
        Me.tabRegistro.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblOnzas)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.btnOnzas)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 225)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(596, 100)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Onzas cierres"
        '
        'lblOnzas
        '
        Me.lblOnzas.AutoSize = True
        Me.lblOnzas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnzas.Location = New System.Drawing.Point(303, 24)
        Me.lblOnzas.Name = "lblOnzas"
        Me.lblOnzas.Size = New System.Drawing.Size(45, 15)
        Me.lblOnzas.TabIndex = 5
        Me.lblOnzas.Text = "(0.00)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Suma onzas de cierres disponibles o mayores a zero:"
        '
        'btnOnzas
        '
        Appearance7.Image = Global.EfectiOro.My.Resources.Resources.Calculator11
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnOnzas.Appearance = Appearance7
        Me.btnOnzas.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton
        Me.btnOnzas.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnOnzas.Location = New System.Drawing.Point(532, 19)
        Me.btnOnzas.Name = "btnOnzas"
        Me.btnOnzas.Size = New System.Drawing.Size(49, 51)
        Me.btnOnzas.TabIndex = 0
        Me.btnOnzas.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblOnzasUPM)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.btnCalcularOnzasUPM)
        Me.GroupBox7.Location = New System.Drawing.Point(314, 119)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(290, 100)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Onzas UPM"
        '
        'lblOnzasUPM
        '
        Me.lblOnzasUPM.AutoSize = True
        Me.lblOnzasUPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnzasUPM.Location = New System.Drawing.Point(16, 43)
        Me.lblOnzasUPM.Name = "lblOnzasUPM"
        Me.lblOnzasUPM.Size = New System.Drawing.Size(45, 15)
        Me.lblOnzasUPM.TabIndex = 5
        Me.lblOnzasUPM.Text = "(0.00)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Suma onzas de UPM disponibles o mayores a zero:"
        '
        'btnCalcularOnzasUPM
        '
        Appearance8.Image = Global.EfectiOro.My.Resources.Resources.Calculator11
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance8.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCalcularOnzasUPM.Appearance = Appearance8
        Me.btnCalcularOnzasUPM.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton
        Me.btnCalcularOnzasUPM.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCalcularOnzasUPM.Location = New System.Drawing.Point(226, 43)
        Me.btnCalcularOnzasUPM.Name = "btnCalcularOnzasUPM"
        Me.btnCalcularOnzasUPM.Size = New System.Drawing.Size(49, 51)
        Me.btnCalcularOnzasUPM.TabIndex = 0
        Me.btnCalcularOnzasUPM.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblOnzasCierres)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.btnCalcularOnzasCierres)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 119)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(290, 100)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Onzas cierres"
        '
        'lblOnzasCierres
        '
        Me.lblOnzasCierres.AutoSize = True
        Me.lblOnzasCierres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnzasCierres.Location = New System.Drawing.Point(16, 43)
        Me.lblOnzasCierres.Name = "lblOnzasCierres"
        Me.lblOnzasCierres.Size = New System.Drawing.Size(45, 15)
        Me.lblOnzasCierres.TabIndex = 5
        Me.lblOnzasCierres.Text = "(0.00)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Suma onzas de cierres disponibles o mayores a zero:"
        '
        'btnCalcularOnzasCierres
        '
        Appearance9.Image = Global.EfectiOro.My.Resources.Resources.Calculator11
        Appearance9.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance9.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCalcularOnzasCierres.Appearance = Appearance9
        Me.btnCalcularOnzasCierres.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton
        Me.btnCalcularOnzasCierres.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCalcularOnzasCierres.Location = New System.Drawing.Point(222, 40)
        Me.btnCalcularOnzasCierres.Name = "btnCalcularOnzasCierres"
        Me.btnCalcularOnzasCierres.Size = New System.Drawing.Size(49, 51)
        Me.btnCalcularOnzasCierres.TabIndex = 0
        Me.btnCalcularOnzasCierres.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblSumOnzasCompras)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.btnCalcularOnzasCompra)
        Me.GroupBox5.Location = New System.Drawing.Point(214, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(390, 107)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Onzas compras"
        '
        'lblSumOnzasCompras
        '
        Me.lblSumOnzasCompras.AutoSize = True
        Me.lblSumOnzasCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumOnzasCompras.Location = New System.Drawing.Point(217, 24)
        Me.lblSumOnzasCompras.Name = "lblSumOnzasCompras"
        Me.lblSumOnzasCompras.Size = New System.Drawing.Size(45, 15)
        Me.lblSumOnzasCompras.TabIndex = 5
        Me.lblSumOnzasCompras.Text = "(0.00)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Suma de onzas según rango de fechas:"
        '
        'btnCalcularOnzasCompra
        '
        Appearance10.Image = Global.EfectiOro.My.Resources.Resources.Calculator11
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCalcularOnzasCompra.Appearance = Appearance10
        Me.btnCalcularOnzasCompra.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton
        Me.btnCalcularOnzasCompra.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCalcularOnzasCompra.Location = New System.Drawing.Point(326, 24)
        Me.btnCalcularOnzasCompra.Name = "btnCalcularOnzasCompra"
        Me.btnCalcularOnzasCompra.Size = New System.Drawing.Size(49, 51)
        Me.btnCalcularOnzasCompra.TabIndex = 0
        Me.btnCalcularOnzasCompra.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtHasta)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtDesde)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 107)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rango fechas"
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(54, 50)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(125, 20)
        Me.txtHasta.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(54, 17)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(125, 20)
        Me.txtDesde.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Desde:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnGuardarDetaUPM)
        Me.TabPage1.Controls.Add(Me.btnSalir2)
        Me.TabPage1.Controls.Add(Me.btnFiltrar)
        Me.TabPage1.Controls.Add(Me.txtMontoEstimado)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtFiltrarFecha)
        Me.TabPage1.Controls.Add(Me.dgvUpm)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(612, 376)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Cierre UPM"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnGuardarDetaUPM
        '
        Appearance11.Image = Global.EfectiOro.My.Resources.Resources.save01
        Appearance11.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance11.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnGuardarDetaUPM.Appearance = Appearance11
        Me.btnGuardarDetaUPM.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton
        Me.btnGuardarDetaUPM.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnGuardarDetaUPM.Location = New System.Drawing.Point(281, 316)
        Me.btnGuardarDetaUPM.Name = "btnGuardarDetaUPM"
        Me.btnGuardarDetaUPM.Size = New System.Drawing.Size(75, 52)
        Me.btnGuardarDetaUPM.TabIndex = 7
        Me.btnGuardarDetaUPM.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSalir2
        '
        Appearance12.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnSalir2.Appearance = Appearance12
        Me.btnSalir2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton
        Me.btnSalir2.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnSalir2.Location = New System.Drawing.Point(529, 316)
        Me.btnSalir2.Name = "btnSalir2"
        Me.btnSalir2.Size = New System.Drawing.Size(75, 52)
        Me.btnSalir2.TabIndex = 6
        Me.btnSalir2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnFiltrar
        '
        Appearance13.BorderColor = System.Drawing.Color.Teal
        Me.btnFiltrar.Appearance = Appearance13
        Me.btnFiltrar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonButton
        Me.btnFiltrar.Location = New System.Drawing.Point(529, 18)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 5
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtMontoEstimado
        '
        Me.txtMontoEstimado.Location = New System.Drawing.Point(380, 21)
        Me.txtMontoEstimado.Name = "txtMontoEstimado"
        Me.txtMontoEstimado.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoEstimado.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(269, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Onzas estimadas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Filtrar:"
        '
        'txtFiltrarFecha
        '
        Me.txtFiltrarFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFiltrarFecha.Location = New System.Drawing.Point(80, 22)
        Me.txtFiltrarFecha.Name = "txtFiltrarFecha"
        Me.txtFiltrarFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrarFecha.TabIndex = 1
        '
        'dgvUpm
        '
        Me.dgvUpm.AllowUserToAddRows = False
        Me.dgvUpm.AllowUserToDeleteRows = False
        Me.dgvUpm.AutoGenerateColumns = False
        Me.dgvUpm.BackgroundColor = System.Drawing.Color.White
        Me.dgvUpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionarUPM, Me.CodupmDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.OnzasDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn})
        Me.dgvUpm.DataSource = Me.sourceUPM
        Me.dgvUpm.Location = New System.Drawing.Point(8, 48)
        Me.dgvUpm.Name = "dgvUpm"
        Me.dgvUpm.Size = New System.Drawing.Size(596, 262)
        Me.dgvUpm.TabIndex = 0
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'sourcecierre
        '
        Me.sourcecierre.DataSource = GetType(EfectiOro.Database.CierrePrecios)
        '
        'bsUpm
        '
        Me.bsUpm.DataSource = Me.sourceUPM
        '
        'colSeleccionarUPM
        '
        Me.colSeleccionarUPM.HeaderText = "Seleccionar"
        Me.colSeleccionarUPM.Name = "colSeleccionarUPM"
        '
        'CodupmDataGridViewTextBoxColumn
        '
        Me.CodupmDataGridViewTextBoxColumn.DataPropertyName = "Codupm"
        Me.CodupmDataGridViewTextBoxColumn.HeaderText = "Codupm"
        Me.CodupmDataGridViewTextBoxColumn.Name = "CodupmDataGridViewTextBoxColumn"
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
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.ReadOnly = True
        Me.StatusDataGridViewCheckBoxColumn.Visible = False
        '
        'frmUPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(620, 427)
        Me.Controls.Add(Me.tabUPM)
        Me.Name = "frmUPM"
        Me.Controls.SetChildIndex(Me.tabUPM, 0)
        Me.tabUPM.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvUpmDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourceUPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.tabRegistro.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvUpm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourcecierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUpm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents sourcecierre As BindingSource
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtHasta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDesde As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCalcularOnzasCompra As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblSumOnzasCompras As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblOnzasUPM As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCalcularOnzasUPM As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblOnzasCierres As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalcularOnzasCierres As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblOnzas As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnOnzas As Infragistics.Win.Misc.UltraButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtMontoEstimado As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFiltrarFecha As DateTimePicker
    Friend WithEvents dgvUpm As DataGridView
    Friend WithEvents btnFiltrar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardarDetaUPM As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents bsUpm As BindingSource
    Friend WithEvents colSeleccionarUPM As DataGridViewCheckBoxColumn
    Friend WithEvents CodupmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OnzasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class

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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvUpmDatos = New System.Windows.Forms.DataGridView()
        Me.colCodupm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOnzas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sourceUPM = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnNuevo = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOnzas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoUPM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab2 = New System.Windows.Forms.TabPage()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tab1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvUpmDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourceUPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab1)
        Me.TabControl1.Controls.Add(Me.tab2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(620, 351)
        Me.TabControl1.TabIndex = 1
        '
        'tab1
        '
        Me.tab1.AutoScroll = True
        Me.tab1.Controls.Add(Me.GroupBox3)
        Me.tab1.Controls.Add(Me.GroupBox2)
        Me.tab1.Controls.Add(Me.GroupBox1)
        Me.tab1.Location = New System.Drawing.Point(4, 22)
        Me.tab1.Name = "tab1"
        Me.tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1.Size = New System.Drawing.Size(612, 325)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "Datos UPM"
        Me.tab1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvUpmDatos)
        Me.GroupBox3.Location = New System.Drawing.Point(235, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(369, 231)
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
        Me.dgvUpmDatos.Size = New System.Drawing.Size(363, 212)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 240)
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
        Me.btnNuevo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 231)
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
        'tab2
        '
        Me.tab2.Location = New System.Drawing.Point(4, 22)
        Me.tab2.Name = "tab2"
        Me.tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2.Size = New System.Drawing.Size(612, 325)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "Registro UPM"
        Me.tab2.UseVisualStyleBackColor = True
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmUPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(620, 376)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmUPM"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvUpmDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourceUPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab1 As TabPage
    Friend WithEvents tab2 As TabPage
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
End Class

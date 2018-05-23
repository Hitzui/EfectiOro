<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrecios
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPrecio = New System.Windows.Forms.DataGridView()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKilataje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioKilateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton()
        Me.btnDefault = New Infragistics.Win.Misc.UltraButton()
        Me.btnDeshabilitar = New Infragistics.Win.Misc.UltraButton()
        Me.btnHabilitar = New Infragistics.Win.Misc.UltraButton()
        Me.btnActualizar = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrecios2 = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioKilateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPrecio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 392)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgvPrecio
        '
        Me.dgvPrecio.AllowUserToOrderColumns = True
        Me.dgvPrecio.AutoGenerateColumns = False
        Me.dgvPrecio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrecio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPrecio.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrecio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDescripcion, Me.colKilataje, Me.colPrecio})
        Me.dgvPrecio.DataSource = Me.PrecioKilateBindingSource
        Me.dgvPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPrecio.Location = New System.Drawing.Point(3, 16)
        Me.dgvPrecio.MultiSelect = False
        Me.dgvPrecio.Name = "dgvPrecio"
        Me.dgvPrecio.Size = New System.Drawing.Size(464, 373)
        Me.dgvPrecio.TabIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.DataPropertyName = "Desc_kilate"
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.Name = "colDescripcion"
        '
        'colKilataje
        '
        Me.colKilataje.DataPropertyName = "Kilate_peso"
        Me.colKilataje.HeaderText = "Kilataje"
        Me.colKilataje.Name = "colKilataje"
        '
        'colPrecio
        '
        Me.colPrecio.DataPropertyName = "Precio_kilate"
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        '
        'PrecioKilateBindingSource
        '
        Me.PrecioKilateBindingSource.DataSource = GetType(EfectiOro.Database.PrecioKilate)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPrecios2)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnDefault)
        Me.GroupBox2.Controls.Add(Me.btnDeshabilitar)
        Me.GroupBox2.Controls.Add(Me.btnHabilitar)
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Location = New System.Drawing.Point(488, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(139, 389)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnSalir
        '
        Appearance3.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Me.btnSalir.Appearance = Appearance3
        Me.btnSalir.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.HotTrackAppearance = Appearance4
        Me.btnSalir.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnSalir.Location = New System.Drawing.Point(6, 341)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(127, 41)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnDefault
        '
        Appearance5.Image = Global.EfectiOro.My.Resources.Resources._48
        Me.btnDefault.Appearance = Appearance5
        Me.btnDefault.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDefault.HotTrackAppearance = Appearance6
        Me.btnDefault.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnDefault.Location = New System.Drawing.Point(6, 217)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(127, 41)
        Me.btnDefault.TabIndex = 7
        Me.btnDefault.Text = "Valores por default"
        Me.btnDefault.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnDeshabilitar
        '
        Appearance7.Image = Global.EfectiOro.My.Resources.Resources.switch_off
        Me.btnDeshabilitar.Appearance = Appearance7
        Me.btnDeshabilitar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeshabilitar.HotTrackAppearance = Appearance8
        Me.btnDeshabilitar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnDeshabilitar.Location = New System.Drawing.Point(6, 155)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(127, 41)
        Me.btnDeshabilitar.TabIndex = 6
        Me.btnDeshabilitar.Text = "Deshabilitar Varias Compras"
        Me.btnDeshabilitar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnHabilitar
        '
        Appearance9.Image = Global.EfectiOro.My.Resources.Resources.switch_on
        Me.btnHabilitar.Appearance = Appearance9
        Me.btnHabilitar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHabilitar.HotTrackAppearance = Appearance10
        Me.btnHabilitar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnHabilitar.Location = New System.Drawing.Point(6, 93)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(127, 41)
        Me.btnHabilitar.TabIndex = 5
        Me.btnHabilitar.Text = "Habilitar Varias Compras"
        Me.btnHabilitar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnActualizar
        '
        Appearance11.Image = Global.EfectiOro.My.Resources.Resources.refresh01
        Me.btnActualizar.Appearance = Appearance11
        Me.btnActualizar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnActualizar.HotTrackAppearance = Appearance12
        Me.btnActualizar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnActualizar.Location = New System.Drawing.Point(6, 31)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(127, 41)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnPrecios2
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.cierre
        Me.btnPrecios2.Appearance = Appearance1
        Me.btnPrecios2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrecios2.HotTrackAppearance = Appearance2
        Me.btnPrecios2.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnPrecios2.Location = New System.Drawing.Point(6, 279)
        Me.btnPrecios2.Name = "btnPrecios2"
        Me.btnPrecios2.Size = New System.Drawing.Size(127, 41)
        Me.btnPrecios2.TabIndex = 9
        Me.btnPrecios2.Text = "Precio por clientes"
        Me.btnPrecios2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frmPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(640, 438)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPrecios"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioKilateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPrecio As System.Windows.Forms.DataGridView
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKilataje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioKilateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnActualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDefault As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDeshabilitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnHabilitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrecios2 As Infragistics.Win.Misc.UltraButton
End Class

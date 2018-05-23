<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstadisticoCompra
    Inherits EfectiOro.frmPersonalizado

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCampo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dgvEstadistica = New System.Windows.Forms.DataGridView()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuma2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblSumaFilas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelDialogo = New System.Windows.Forms.Panel()
        Me.btnCalcular = New Infragistics.Win.Misc.UltraButton()
        Me.lblRangoDias = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCampo = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnVisualizar = New Infragistics.Win.Misc.UltraButton()
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDialogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(607, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(582, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCampo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDesde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtHasta)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Especificar los parametros de busqueda"
        '
        'cmbCampo
        '
        Me.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampo.FormattingEnabled = True
        Me.cmbCampo.Location = New System.Drawing.Point(303, 104)
        Me.cmbCampo.Name = "cmbCampo"
        Me.cmbCampo.Size = New System.Drawing.Size(138, 21)
        Me.cmbCampo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Especificar campo:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(18, 43)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(199, 20)
        Me.txtDesde.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especificar fecha de inicio:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(303, 41)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(102, 20)
        Me.txtValor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Espicifacar n-valor:"
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(18, 104)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(199, 20)
        Me.txtHasta.TabIndex = 2
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(15, 87)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(114, 13)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Especificar fecha final:"
        '
        'dgvEstadistica
        '
        Me.dgvEstadistica.AllowUserToAddRows = False
        Me.dgvEstadistica.AllowUserToDeleteRows = False
        Me.dgvEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEstadistica.BackgroundColor = System.Drawing.Color.White
        Me.dgvEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCantidad, Me.colFecha, Me.colSuma2})
        Me.dgvEstadistica.Location = New System.Drawing.Point(13, 31)
        Me.dgvEstadistica.Name = "dgvEstadistica"
        Me.dgvEstadistica.ReadOnly = True
        Me.dgvEstadistica.Size = New System.Drawing.Size(412, 296)
        Me.dgvEstadistica.TabIndex = 4
        '
        'colCantidad
        '
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.ReadOnly = True
        '
        'colFecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colFecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        '
        'colSuma2
        '
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colSuma2.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSuma2.HeaderText = "Suma Total"
        Me.colSuma2.Name = "colSuma2"
        Me.colSuma2.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cantidad de datos:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(532, 107)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(54, 13)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "(cantidad)"
        '
        'lblSumaFilas
        '
        Me.lblSumaFilas.AutoSize = True
        Me.lblSumaFilas.Location = New System.Drawing.Point(488, 154)
        Me.lblSumaFilas.Name = "lblSumaFilas"
        Me.lblSumaFilas.Size = New System.Drawing.Size(38, 13)
        Me.lblSumaFilas.TabIndex = 6
        Me.lblSumaFilas.Text = "(suma)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Suma:"
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.Location = New System.Drawing.Point(472, 214)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(56, 13)
        Me.lblPromedio.TabIndex = 8
        Me.lblPromedio.Text = "(promedio)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(472, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Promedio:"
        '
        'panelDialogo
        '
        Me.panelDialogo.Controls.Add(Me.btnCalcular)
        Me.panelDialogo.Controls.Add(Me.lblRangoDias)
        Me.panelDialogo.Controls.Add(Me.Label8)
        Me.panelDialogo.Controls.Add(Me.Label7)
        Me.panelDialogo.Controls.Add(Me.lblCampo)
        Me.panelDialogo.Controls.Add(Me.GroupBox1)
        Me.panelDialogo.Location = New System.Drawing.Point(0, 28)
        Me.panelDialogo.Name = "panelDialogo"
        Me.panelDialogo.Padding = New System.Windows.Forms.Padding(5)
        Me.panelDialogo.Size = New System.Drawing.Size(607, 326)
        Me.panelDialogo.TabIndex = 9
        '
        'btnCalcular
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.calculator2
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance1.TextVAlignAsString = "Bottom"
        Me.btnCalcular.Appearance = Appearance1
        Me.btnCalcular.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCalcular.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnCalcular.Location = New System.Drawing.Point(523, 251)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(72, 63)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'lblRangoDias
        '
        Me.lblRangoDias.AutoSize = True
        Me.lblRangoDias.Location = New System.Drawing.Point(193, 285)
        Me.lblRangoDias.Name = "lblRangoDias"
        Me.lblRangoDias.Size = New System.Drawing.Size(45, 13)
        Me.lblRangoDias.TabIndex = 9
        Me.lblRangoDias.Text = "(campo)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Rango de dias a calcular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Campo a utilizar para calcular:"
        '
        'lblCampo
        '
        Me.lblCampo.AutoSize = True
        Me.lblCampo.Location = New System.Drawing.Point(193, 251)
        Me.lblCampo.Name = "lblCampo"
        Me.lblCampo.Size = New System.Drawing.Size(45, 13)
        Me.lblCampo.TabIndex = 6
        Me.lblCampo.Text = "(campo)"
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Image = Global.EfectiOro.My.Resources.Resources._28
        Me.btnVolver.Location = New System.Drawing.Point(484, 295)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(111, 47)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnVisualizar
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.buscar_48
        Me.btnVisualizar.Appearance = Appearance2
        Me.btnVisualizar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnVisualizar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnVisualizar.Location = New System.Drawing.Point(478, 44)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(108, 34)
        Me.btnVisualizar.TabIndex = 12
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frmEstadisticoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(607, 354)
        Me.Controls.Add(Me.panelDialogo)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblPromedio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSumaFilas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvEstadistica)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Name = "frmEstadisticoCompra"
        Me.Controls.SetChildIndex(Me.btnVisualizar, 0)
        Me.Controls.SetChildIndex(Me.dgvEstadistica, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblCantidad, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblSumaFilas, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.lblPromedio, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.btnVolver, 0)
        Me.Controls.SetChildIndex(Me.panelDialogo, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDialogo.ResumeLayout(False)
        Me.panelDialogo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dgvEstadistica As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblSumaFilas As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPromedio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCampo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelDialogo As System.Windows.Forms.Panel
    Friend WithEvents colCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSuma2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblCampo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblRangoDias As System.Windows.Forms.Label
    Friend WithEvents btnVisualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCalcular As Infragistics.Win.Misc.UltraButton
End Class

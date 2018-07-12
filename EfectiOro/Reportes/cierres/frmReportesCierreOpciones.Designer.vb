<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesCierreOpciones
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbTodos = New System.Windows.Forms.ComboBox()
        Me.radGeneral = New System.Windows.Forms.RadioButton()
        Me.cmbSaldos = New System.Windows.Forms.ComboBox()
        Me.radSaldos = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.btnVolver = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(741, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDesde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fecha"
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(62, 50)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(132, 20)
        Me.txtHasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(62, 20)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(132, 20)
        Me.txtDesde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFiltro)
        Me.GroupBox2.Location = New System.Drawing.Point(289, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 284)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'dgvCliente
        '
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(6, 47)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.Size = New System.Drawing.Size(428, 233)
        Me.dgvCliente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Filtrar Cliente:"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(100, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(334, 20)
        Me.txtFiltro.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbTodos)
        Me.GroupBox3.Controls.Add(Me.radGeneral)
        Me.GroupBox3.Controls.Add(Me.cmbSaldos)
        Me.GroupBox3.Controls.Add(Me.radSaldos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 174)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'cmbTodos
        '
        Me.cmbTodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTodos.FormattingEnabled = True
        Me.cmbTodos.Items.AddRange(New Object() {"Por Cliente", "Detallado Cliente", "Todos los clientes", "Detallado Todos"})
        Me.cmbTodos.Location = New System.Drawing.Point(101, 55)
        Me.cmbTodos.Name = "cmbTodos"
        Me.cmbTodos.Size = New System.Drawing.Size(164, 21)
        Me.cmbTodos.TabIndex = 3
        Me.cmbTodos.Visible = False
        '
        'radGeneral
        '
        Me.radGeneral.AutoSize = True
        Me.radGeneral.Location = New System.Drawing.Point(6, 56)
        Me.radGeneral.Name = "radGeneral"
        Me.radGeneral.Size = New System.Drawing.Size(89, 17)
        Me.radGeneral.TabIndex = 2
        Me.radGeneral.TabStop = True
        Me.radGeneral.Text = "Todos cierres"
        Me.radGeneral.UseVisualStyleBackColor = True
        '
        'cmbSaldos
        '
        Me.cmbSaldos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSaldos.FormattingEnabled = True
        Me.cmbSaldos.Items.AddRange(New Object() {"General Por Cliente", "General todos", "Detallado por cliente"})
        Me.cmbSaldos.Location = New System.Drawing.Point(101, 28)
        Me.cmbSaldos.Name = "cmbSaldos"
        Me.cmbSaldos.Size = New System.Drawing.Size(164, 21)
        Me.cmbSaldos.TabIndex = 1
        Me.cmbSaldos.Visible = False
        '
        'radSaldos
        '
        Me.radSaldos.AutoSize = True
        Me.radSaldos.Location = New System.Drawing.Point(6, 29)
        Me.radSaldos.Name = "radSaldos"
        Me.radSaldos.Size = New System.Drawing.Size(79, 17)
        Me.radSaldos.TabIndex = 0
        Me.radSaldos.TabStop = True
        Me.radSaldos.Text = "Con Saldos"
        Me.radSaldos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.analysis
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnBuscar.Appearance = Appearance1
        Me.btnBuscar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnBuscar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnBuscar.Location = New System.Drawing.Point(300, 318)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 49)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnVolver
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnVolver.Appearance = Appearance2
        Me.btnVolver.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnVolver.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnVolver.Location = New System.Drawing.Point(654, 318)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 49)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraButton1
        '
        Appearance3.Image = Global.EfectiOro.My.Resources.Resources.USER_MALE_REMOVE
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraButton1.Appearance = Appearance3
        Me.UltraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.UltraButton1.ImageSize = New System.Drawing.Size(36, 36)
        Me.UltraButton1.Location = New System.Drawing.Point(12, 318)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(170, 49)
        Me.UltraButton1.TabIndex = 6
        Me.UltraButton1.Text = "Quitar seleccion cliente"
        Me.UltraButton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frmReportesCierreOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(741, 379)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportesCierreOpciones"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnVolver, 0)
        Me.Controls.SetChildIndex(Me.UltraButton1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radSaldos As RadioButton
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVolver As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmbSaldos As ComboBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmbTodos As ComboBox
    Friend WithEvents radGeneral As RadioButton
End Class

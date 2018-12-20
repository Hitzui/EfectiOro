<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAplicarAdelantoEfectivo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAplicarAdelantoEfectivo))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvAdelanto = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRefrescar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAplicarSaldo = New Infragistics.Win.Misc.UltraButton()
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton()
        Me.colSeleccionar2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAdelanto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(701, 25)
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(516, 112)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(173, 20)
        Me.txtSaldo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(513, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Saldo a aplicar:"
        '
        'dgvAdelanto
        '
        Me.dgvAdelanto.AllowUserToAddRows = False
        Me.dgvAdelanto.AllowUserToDeleteRows = False
        Me.dgvAdelanto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAdelanto.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdelanto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdelanto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar2, Me.colCodigo, Me.colFecha, Me.colMonto, Me.colSaldo, Me.colMoneda})
        Me.dgvAdelanto.Location = New System.Drawing.Point(12, 81)
        Me.dgvAdelanto.Name = "dgvAdelanto"
        Me.dgvAdelanto.Size = New System.Drawing.Size(481, 202)
        Me.dgvAdelanto.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 42)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(354, 13)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(287, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del Cliente:"
        '
        'txtCodcliente
        '
        Me.txtCodcliente.Location = New System.Drawing.Point(110, 13)
        Me.txtCodcliente.Name = "txtCodcliente"
        Me.txtCodcliente.ReadOnly = True
        Me.txtCodcliente.Size = New System.Drawing.Size(136, 20)
        Me.txtCodcliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo del Cliente:"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "aceptar.png")
        Me.ImageList1.Images.SetKeyName(1, "48.PNG")
        Me.ImageList1.Images.SetKeyName(2, "23.PNG")
        '
        'btnRefrescar
        '
        Appearance1.Image = "48.PNG"
        Me.btnRefrescar.Appearance = Appearance1
        Me.btnRefrescar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnRefrescar.ImageList = Me.ImageList1
        Me.btnRefrescar.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnRefrescar.Location = New System.Drawing.Point(499, 245)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(87, 34)
        Me.btnRefrescar.TabIndex = 17
        Me.btnRefrescar.Text = "Refrescar"
        Me.ToolTip1.SetToolTip(Me.btnRefrescar, "Refrescar datos")
        Me.btnRefrescar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAplicarSaldo
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.aceptar
        Me.btnAplicarSaldo.Appearance = Appearance2
        Me.btnAplicarSaldo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnAplicarSaldo.Location = New System.Drawing.Point(614, 138)
        Me.btnAplicarSaldo.Name = "btnAplicarSaldo"
        Me.btnAplicarSaldo.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarSaldo.TabIndex = 16
        Me.btnAplicarSaldo.Text = "Aceptar"
        Me.btnAplicarSaldo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSalir
        '
        Appearance3.Image = "23.PNG"
        Me.btnSalir.Appearance = Appearance3
        Me.btnSalir.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnSalir.ImageList = Me.ImageList1
        Me.btnSalir.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnSalir.Location = New System.Drawing.Point(614, 245)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 34)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'colSeleccionar2
        '
        Me.colSeleccionar2.HeaderText = "Seleccionar"
        Me.colSeleccionar2.Name = "colSeleccionar2"
        Me.colSeleccionar2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSeleccionar2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colFecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colFecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        '
        'colMonto
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.colMonto.DefaultCellStyle = DataGridViewCellStyle2
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        '
        'colSaldo
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.colSaldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSaldo.HeaderText = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        '
        'colMoneda
        '
        Me.colMoneda.HeaderText = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        '
        'frmAplicarAdelantoEfectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(701, 302)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.btnAplicarSaldo)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvAdelanto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAplicarAdelantoEfectivo"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.dgvAdelanto, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtSaldo, 0)
        Me.Controls.SetChildIndex(Me.btnAplicarSaldo, 0)
        Me.Controls.SetChildIndex(Me.btnRefrescar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        CType(Me.dgvAdelanto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

    Friend WithEvents dgvAdelanto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAplicarSaldo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnRefrescar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents colSeleccionar2 As DataGridViewCheckBoxColumn
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents colMonto As DataGridViewTextBoxColumn
    Friend WithEvents colSaldo As DataGridViewTextBoxColumn
    Friend WithEvents colMoneda As DataGridViewTextBoxColumn
End Class

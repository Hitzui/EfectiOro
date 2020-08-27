<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerAdelantos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerAdelantos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSaldoTotal = New System.Windows.Forms.Label()
        Me.txtNumcompra = New System.Windows.Forms.TextBox()
        Me.txtCodcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAdelanto = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.btnAplicarSaldo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMontoCompra = New System.Windows.Forms.Label()
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAdelanto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClose.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(734, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSaldoTotal)
        Me.GroupBox1.Controls.Add(Me.txtNumcompra)
        Me.GroupBox1.Controls.Add(Me.txtCodcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 42)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblSaldoTotal
        '
        Me.lblSaldoTotal.AutoSize = True
        Me.lblSaldoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoTotal.Location = New System.Drawing.Point(545, 14)
        Me.lblSaldoTotal.Name = "lblSaldoTotal"
        Me.lblSaldoTotal.Size = New System.Drawing.Size(50, 15)
        Me.lblSaldoTotal.TabIndex = 4
        Me.lblSaldoTotal.Text = "(Monto)"
        '
        'txtNumcompra
        '
        Me.txtNumcompra.Location = New System.Drawing.Point(358, 13)
        Me.txtNumcompra.Name = "txtNumcompra"
        Me.txtNumcompra.ReadOnly = True
        Me.txtNumcompra.Size = New System.Drawing.Size(123, 20)
        Me.txtNumcompra.TabIndex = 0
        '
        'txtCodcliente
        '
        Me.txtCodcliente.Location = New System.Drawing.Point(110, 13)
        Me.txtCodcliente.Name = "txtCodcliente"
        Me.txtCodcliente.ReadOnly = True
        Me.txtCodcliente.Size = New System.Drawing.Size(136, 20)
        Me.txtCodcliente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número de comrpa:"
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
        'dgvAdelanto
        '
        Me.dgvAdelanto.AllowUserToAddRows = False
        Me.dgvAdelanto.AllowUserToDeleteRows = False
        Me.dgvAdelanto.AllowUserToOrderColumns = True
        Me.dgvAdelanto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAdelanto.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdelanto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdelanto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar, Me.colCodigo, Me.colFecha, Me.colMonto, Me.colSaldo, Me.colMoneda})
        Me.dgvAdelanto.Location = New System.Drawing.Point(13, 80)
        Me.dgvAdelanto.Name = "dgvAdelanto"
        Me.dgvAdelanto.Size = New System.Drawing.Size(481, 202)
        Me.dgvAdelanto.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ImageIndex = 2
        Me.btnSalir.ImageList = Me.ImageList1
        Me.btnSalir.Location = New System.Drawing.Point(643, 245)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(68, 37)
        Me.btnSalir.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Volver a la compra")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "aceptar.png")
        Me.ImageList1.Images.SetKeyName(1, "48.PNG")
        Me.ImageList1.Images.SetKeyName(2, "23.PNG")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(524, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Saldo a aplicar:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(521, 105)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(122, 20)
        Me.txtSaldo.TabIndex = 0
        '
        'btnAplicarSaldo
        '
        Me.btnAplicarSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAplicarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicarSaldo.ImageIndex = 0
        Me.btnAplicarSaldo.ImageList = Me.ImageList1
        Me.btnAplicarSaldo.Location = New System.Drawing.Point(672, 97)
        Me.btnAplicarSaldo.Name = "btnAplicarSaldo"
        Me.btnAplicarSaldo.Size = New System.Drawing.Size(50, 34)
        Me.btnAplicarSaldo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnAplicarSaldo, "Aplicar saldo al monto de la compra")
        '
        'btnRefrescar
        '
        Me.btnRefrescar.FlatAppearance.BorderSize = 0
        Me.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.ImageIndex = 1
        Me.btnRefrescar.ImageList = Me.ImageList1
        Me.btnRefrescar.Location = New System.Drawing.Point(500, 245)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(82, 37)
        Me.btnRefrescar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnRefrescar, "Volver a cargar los datos de adelantos")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(518, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Monto compra:"
        '
        'lblMontoCompra
        '
        Me.lblMontoCompra.AutoSize = True
        Me.lblMontoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoCompra.Location = New System.Drawing.Point(614, 156)
        Me.lblMontoCompra.Name = "lblMontoCompra"
        Me.lblMontoCompra.Size = New System.Drawing.Size(39, 15)
        Me.lblMontoCompra.TabIndex = 8
        Me.lblMontoCompra.Text = "(0.00)"
        '
        'colSeleccionar
        '
        Me.colSeleccionar.HeaderText = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colSeleccionar.Width = 88
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 65
        '
        'colFecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colFecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        Me.colFecha.Width = 62
        '
        'colMonto
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.colMonto.DefaultCellStyle = DataGridViewCellStyle2
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.ReadOnly = True
        Me.colMonto.Width = 62
        '
        'colSaldo
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.colSaldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSaldo.HeaderText = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.ReadOnly = True
        Me.colSaldo.Width = 59
        '
        'colMoneda
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colMoneda.DefaultCellStyle = DataGridViewCellStyle4
        Me.colMoneda.HeaderText = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.Width = 71
        '
        'frmVerAdelantos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(734, 294)
        Me.Controls.Add(Me.lblMontoCompra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.btnAplicarSaldo)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvAdelanto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVerAdelantos"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.dgvAdelanto, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtSaldo, 0)
        Me.Controls.SetChildIndex(Me.btnAplicarSaldo, 0)
        Me.Controls.SetChildIndex(Me.btnRefrescar, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblMontoCompra, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAdelanto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumcompra As System.Windows.Forms.TextBox
    Friend WithEvents txtCodcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvAdelanto As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents btnAplicarSaldo As Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblSaldoTotal As System.Windows.Forms.Label
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMontoCompra As Label
    Friend WithEvents colSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents colMonto As DataGridViewTextBoxColumn
    Friend WithEvents colSaldo As DataGridViewTextBoxColumn
    Friend WithEvents colMoneda As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagoCompra))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvFiltrarCliente = New System.Windows.Forms.DataGridView()
        Me.colCodcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumcedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.colNumcompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEfectivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.chkCheque = New System.Windows.Forms.CheckBox()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.chkTransferencia = New System.Windows.Forms.CheckBox()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.chkEfectivo = New System.Windows.Forms.CheckBox()
        Me.lblPorpagar = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFiltrarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(722, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Green
        Me.lblTitulo.Size = New System.Drawing.Size(697, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 55)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(573, 18)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(524, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(109, 20)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(389, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del cliente"
        '
        'dgvFiltrarCliente
        '
        Me.dgvFiltrarCliente.AllowUserToAddRows = False
        Me.dgvFiltrarCliente.AllowUserToDeleteRows = False
        Me.dgvFiltrarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFiltrarCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvFiltrarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiltrarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodcliente, Me.colNombre, Me.colApellidos, Me.colNumcedula, Me.colDireccion})
        Me.dgvFiltrarCliente.Location = New System.Drawing.Point(121, 75)
        Me.dgvFiltrarCliente.Name = "dgvFiltrarCliente"
        Me.dgvFiltrarCliente.ReadOnly = True
        Me.dgvFiltrarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFiltrarCliente.Size = New System.Drawing.Size(576, 36)
        Me.dgvFiltrarCliente.TabIndex = 4
        Me.dgvFiltrarCliente.Visible = False
        '
        'colCodcliente
        '
        Me.colCodcliente.HeaderText = "Codigo cliente"
        Me.colCodcliente.Name = "colCodcliente"
        Me.colCodcliente.ReadOnly = True
        Me.colCodcliente.Width = 107
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombres"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 106
        '
        'colApellidos
        '
        Me.colApellidos.HeaderText = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.ReadOnly = True
        Me.colApellidos.Width = 107
        '
        'colNumcedula
        '
        Me.colNumcedula.FillWeight = 150.0!
        Me.colNumcedula.HeaderText = "Numero de cedula"
        Me.colNumcedula.Name = "colNumcedula"
        Me.colNumcedula.ReadOnly = True
        Me.colNumcedula.Width = 150
        '
        'colDireccion
        '
        Me.colDireccion.HeaderText = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.ReadOnly = True
        Me.colDireccion.Width = 107
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCompras)
        Me.GroupBox2.Controls.Add(Me.txtCheque)
        Me.GroupBox2.Controls.Add(Me.chkCheque)
        Me.GroupBox2.Controls.Add(Me.txtTransferencia)
        Me.GroupBox2.Controls.Add(Me.chkTransferencia)
        Me.GroupBox2.Controls.Add(Me.txtEfectivo)
        Me.GroupBox2.Controls.Add(Me.chkEfectivo)
        Me.GroupBox2.Controls.Add(Me.lblPorpagar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 231)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AllowUserToDeleteRows = False
        Me.dgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCompras.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumcompra, Me.colFecha, Me.colSaldo, Me.colEfectivo, Me.colCheque, Me.colTransferencia})
        Me.dgvCompras.Location = New System.Drawing.Point(6, 31)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.ReadOnly = True
        Me.dgvCompras.Size = New System.Drawing.Size(394, 190)
        Me.dgvCompras.TabIndex = 22
        '
        'colNumcompra
        '
        Me.colNumcompra.HeaderText = "N° compra"
        Me.colNumcompra.Name = "colNumcompra"
        Me.colNumcompra.ReadOnly = True
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
        'colSaldo
        '
        Me.colSaldo.HeaderText = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.ReadOnly = True
        '
        'colEfectivo
        '
        Me.colEfectivo.HeaderText = "Efectivo"
        Me.colEfectivo.Name = "colEfectivo"
        Me.colEfectivo.ReadOnly = True
        '
        'colCheque
        '
        Me.colCheque.HeaderText = "Cheque"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.ReadOnly = True
        '
        'colTransferencia
        '
        Me.colTransferencia.HeaderText = "Transferencia"
        Me.colTransferencia.Name = "colTransferencia"
        Me.colTransferencia.ReadOnly = True
        '
        'txtCheque
        '
        Me.txtCheque.Enabled = False
        Me.txtCheque.Location = New System.Drawing.Point(547, 174)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(125, 20)
        Me.txtCheque.TabIndex = 15
        Me.txtCheque.Visible = False
        '
        'chkCheque
        '
        Me.chkCheque.AutoSize = True
        Me.chkCheque.Location = New System.Drawing.Point(444, 176)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(63, 17)
        Me.chkCheque.TabIndex = 14
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.UseVisualStyleBackColor = True
        '
        'txtTransferencia
        '
        Me.txtTransferencia.Enabled = False
        Me.txtTransferencia.Location = New System.Drawing.Point(547, 139)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(125, 20)
        Me.txtTransferencia.TabIndex = 13
        Me.txtTransferencia.Visible = False
        '
        'chkTransferencia
        '
        Me.chkTransferencia.AutoSize = True
        Me.chkTransferencia.Location = New System.Drawing.Point(444, 142)
        Me.chkTransferencia.Name = "chkTransferencia"
        Me.chkTransferencia.Size = New System.Drawing.Size(97, 17)
        Me.chkTransferencia.TabIndex = 12
        Me.chkTransferencia.Text = "Transaferencia"
        Me.chkTransferencia.UseVisualStyleBackColor = True
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Enabled = False
        Me.txtEfectivo.Location = New System.Drawing.Point(547, 106)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(125, 20)
        Me.txtEfectivo.TabIndex = 11
        Me.txtEfectivo.Visible = False
        '
        'chkEfectivo
        '
        Me.chkEfectivo.AutoSize = True
        Me.chkEfectivo.Location = New System.Drawing.Point(444, 108)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(65, 17)
        Me.chkEfectivo.TabIndex = 10
        Me.chkEfectivo.Text = "Efectivo"
        Me.chkEfectivo.UseVisualStyleBackColor = True
        '
        'lblPorpagar
        '
        Me.lblPorpagar.AutoSize = True
        Me.lblPorpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorpagar.Location = New System.Drawing.Point(556, 64)
        Me.lblPorpagar.Name = "lblPorpagar"
        Me.lblPorpagar.Size = New System.Drawing.Size(32, 15)
        Me.lblPorpagar.TabIndex = 7
        Me.lblPorpagar.Text = "(0.0)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Pendiente por pagar:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(556, 40)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(32, 15)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "(0.0)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(438, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total de la compra:"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "23.PNG")
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ImageIndex = 0
        Me.btnSalir.ImageList = Me.ImageList1
        Me.btnSalir.Location = New System.Drawing.Point(627, 386)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(83, 25)
        Me.btnSalir.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Salir del formulario")
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.EfectiOro.My.Resources.Resources._48
        Me.btnCancelar.Location = New System.Drawing.Point(499, 373)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.btnCancelar.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar")
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.EfectiOro.My.Resources.Resources._8
        Me.btnNuevo.Location = New System.Drawing.Point(433, 373)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(45, 45)
        Me.btnNuevo.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.EfectiOro.My.Resources.Resources._7
        Me.btnGuardar.Location = New System.Drawing.Point(367, 373)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(45, 45)
        Me.btnGuardar.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
        Me.btnGuardar.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(724, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Datos de la Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPagoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(722, 424)
        Me.Controls.Add(Me.dgvFiltrarCliente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPagoCompra"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.dgvFiltrarCliente, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFiltrarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvFiltrarCliente As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPorpagar As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents txtTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents chkTransferencia As System.Windows.Forms.CheckBox
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents colCodcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumcedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumcompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEfectivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTransferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents dgvCompras As System.Windows.Forms.DataGridView

End Class

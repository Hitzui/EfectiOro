<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdelantos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdelantos))
        Me.grupoRegistrar = New System.Windows.Forms.GroupBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttransferencia = New System.Windows.Forms.TextBox()
        Me.txtcheque = New System.Windows.Forms.TextBox()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.chekTransferencia = New System.Windows.Forms.CheckBox()
        Me.chekCheque = New System.Windows.Forms.CheckBox()
        Me.chekEfectivo = New System.Windows.Forms.CheckBox()
        Me.txtreferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAdelantos = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grupoRegistrar.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(554, 25)
        '
        'grupoRegistrar
        '
        Me.grupoRegistrar.Controls.Add(Me.dgvCliente)
        Me.grupoRegistrar.Controls.Add(Me.lbltotal)
        Me.grupoRegistrar.Controls.Add(Me.Label3)
        Me.grupoRegistrar.Controls.Add(Me.txttransferencia)
        Me.grupoRegistrar.Controls.Add(Me.txtcheque)
        Me.grupoRegistrar.Controls.Add(Me.txtefectivo)
        Me.grupoRegistrar.Controls.Add(Me.chekTransferencia)
        Me.grupoRegistrar.Controls.Add(Me.chekCheque)
        Me.grupoRegistrar.Controls.Add(Me.chekEfectivo)
        Me.grupoRegistrar.Controls.Add(Me.txtreferencia)
        Me.grupoRegistrar.Controls.Add(Me.Label2)
        Me.grupoRegistrar.Controls.Add(Me.txtcodcliente)
        Me.grupoRegistrar.Controls.Add(Me.Label1)
        Me.grupoRegistrar.Controls.Add(Me.lblFecha)
        Me.grupoRegistrar.Controls.Add(Me.lblHora)
        Me.grupoRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoRegistrar.Location = New System.Drawing.Point(12, 31)
        Me.grupoRegistrar.Name = "grupoRegistrar"
        Me.grupoRegistrar.Size = New System.Drawing.Size(530, 162)
        Me.grupoRegistrar.TabIndex = 1
        Me.grupoRegistrar.TabStop = False
        Me.grupoRegistrar.Text = "Registrar Adelanto a cliente"
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colNombre, Me.colApellido})
        Me.dgvCliente.Location = New System.Drawing.Point(143, 48)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.Size = New System.Drawing.Size(380, 10)
        Me.dgvCliente.TabIndex = 18
        Me.dgvCliente.Visible = False
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 71
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 77
        '
        'colApellido
        '
        Me.colApellido.HeaderText = "Apellidos"
        Me.colApellido.Name = "colApellido"
        Me.colApellido.ReadOnly = True
        Me.colApellido.Width = 82
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbltotal.Location = New System.Drawing.Point(412, 129)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(40, 17)
        Me.lbltotal.TabIndex = 17
        Me.lbltotal.Text = "(total)"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(369, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txttransferencia
        '
        Me.txttransferencia.Location = New System.Drawing.Point(143, 129)
        Me.txttransferencia.Name = "txttransferencia"
        Me.txttransferencia.Size = New System.Drawing.Size(139, 21)
        Me.txttransferencia.TabIndex = 15
        Me.txttransferencia.Visible = False
        '
        'txtcheque
        '
        Me.txtcheque.Location = New System.Drawing.Point(143, 104)
        Me.txtcheque.Name = "txtcheque"
        Me.txtcheque.Size = New System.Drawing.Size(139, 21)
        Me.txtcheque.TabIndex = 14
        Me.txtcheque.Visible = False
        '
        'txtefectivo
        '
        Me.txtefectivo.Location = New System.Drawing.Point(143, 79)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(139, 21)
        Me.txtefectivo.TabIndex = 13
        '
        'chekTransferencia
        '
        Me.chekTransferencia.AutoSize = True
        Me.chekTransferencia.Location = New System.Drawing.Point(14, 131)
        Me.chekTransferencia.Name = "chekTransferencia"
        Me.chekTransferencia.Size = New System.Drawing.Size(123, 19)
        Me.chekTransferencia.TabIndex = 12
        Me.chekTransferencia.Text = "Por Transferencia"
        Me.chekTransferencia.UseVisualStyleBackColor = True
        '
        'chekCheque
        '
        Me.chekCheque.AutoSize = True
        Me.chekCheque.Location = New System.Drawing.Point(13, 106)
        Me.chekCheque.Name = "chekCheque"
        Me.chekCheque.Size = New System.Drawing.Size(124, 19)
        Me.chekCheque.TabIndex = 11
        Me.chekCheque.Text = "Monto en Cheque"
        Me.chekCheque.UseVisualStyleBackColor = True
        '
        'chekEfectivo
        '
        Me.chekEfectivo.AutoSize = True
        Me.chekEfectivo.Checked = True
        Me.chekEfectivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chekEfectivo.Location = New System.Drawing.Point(14, 81)
        Me.chekEfectivo.Name = "chekEfectivo"
        Me.chekEfectivo.Size = New System.Drawing.Size(123, 19)
        Me.chekEfectivo.TabIndex = 10
        Me.chekEfectivo.Text = "Monto en Efectivo"
        Me.chekEfectivo.UseVisualStyleBackColor = True
        '
        'txtreferencia
        '
        Me.txtreferencia.Location = New System.Drawing.Point(143, 49)
        Me.txtreferencia.Name = "txtreferencia"
        Me.txtreferencia.Size = New System.Drawing.Size(273, 21)
        Me.txtreferencia.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(61, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Referencias:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(155, 24)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(127, 21)
        Me.txtcodcliente.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo del cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFecha
        '
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblFecha.Location = New System.Drawing.Point(325, 18)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(81, 20)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "(Fecha)"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHora
        '
        Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblHora.Location = New System.Drawing.Point(412, 18)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(90, 20)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "(hora)"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnAdelantos)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 61)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ImageIndex = 5
        Me.btnSalir.ImageList = Me.ImageList1
        Me.btnSalir.Location = New System.Drawing.Point(445, 10)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 45)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "23.PNG")
        Me.ImageList1.Images.SetKeyName(1, "48.PNG")
        Me.ImageList1.Images.SetKeyName(2, "ADD_PAGE.PNG")
        Me.ImageList1.Images.SetKeyName(3, "filesave.png")
        Me.ImageList1.Images.SetKeyName(4, "grafica.png")
        Me.ImageList1.Images.SetKeyName(5, "HOME.PNG")
        '
        'btnAdelantos
        '
        Me.btnAdelantos.FlatAppearance.BorderSize = 0
        Me.btnAdelantos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdelantos.ImageIndex = 4
        Me.btnAdelantos.ImageList = Me.ImageList1
        Me.btnAdelantos.Location = New System.Drawing.Point(228, 10)
        Me.btnAdelantos.Name = "btnAdelantos"
        Me.btnAdelantos.Size = New System.Drawing.Size(54, 45)
        Me.btnAdelantos.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnAdelantos, "Ver adelantos de clientes")
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ImageIndex = 1
        Me.btnCancelar.ImageList = Me.ImageList1
        Me.btnCancelar.Location = New System.Drawing.Point(165, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.btnCancelar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar")
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ImageIndex = 3
        Me.btnGuardar.ImageList = Me.ImageList1
        Me.btnGuardar.Location = New System.Drawing.Point(95, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(45, 45)
        Me.btnGuardar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ImageIndex = 2
        Me.btnNuevo.ImageList = Me.ImageList1
        Me.btnNuevo.Location = New System.Drawing.Point(23, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(45, 45)
        Me.btnNuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo adelanto")
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmAdelantos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(554, 272)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grupoRegistrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdelantos"
        Me.Controls.SetChildIndex(Me.grupoRegistrar, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.grupoRegistrar.ResumeLayout(False)
        Me.grupoRegistrar.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoRegistrar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtreferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents chekEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents chekTransferencia As System.Windows.Forms.CheckBox
    Friend WithEvents chekCheque As System.Windows.Forms.CheckBox
    Friend WithEvents txttransferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtcheque As System.Windows.Forms.TextBox
    Friend WithEvents txtefectivo As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAdelantos As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As ImageList
End Class

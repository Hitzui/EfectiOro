<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierrePrecios
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierrePrecios))
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New Infragistics.Win.Misc.UltraButton()
        Me.txtMargen = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioBase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGramos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioOro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOnzas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnNuevo = New Infragistics.Win.Misc.UltraButton()
        Me.grpLista = New System.Windows.Forms.GroupBox()
        Me.dgvCierresCliente = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOnzas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpCliente.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        Me.grpButtons.SuspendLayout()
        Me.grpLista.SuspendLayout()
        CType(Me.dgvCierresCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(913, 25)
        '
        'grpCliente
        '
        Me.grpCliente.Controls.Add(Me.txtCodigo)
        Me.grpCliente.Controls.Add(Me.Label2)
        Me.grpCliente.Controls.Add(Me.txtNombre)
        Me.grpCliente.Controls.Add(Me.Label1)
        Me.grpCliente.Location = New System.Drawing.Point(12, 31)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(456, 59)
        Me.grpCliente.TabIndex = 1
        Me.grpCliente.TabStop = False
        Me.grpCliente.Text = "Cliente"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(345, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(99, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo cliente"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(64, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(173, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'dgvCliente
        '
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(21, 83)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(435, 27)
        Me.dgvCliente.TabIndex = 2
        Me.dgvCliente.Visible = False
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.btnCalcular)
        Me.grpDatos.Controls.Add(Me.txtMargen)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.txtPrecioBase)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.txtGramos)
        Me.grpDatos.Controls.Add(Me.Label5)
        Me.grpDatos.Controls.Add(Me.txtPrecioOro)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.txtOnzas)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Location = New System.Drawing.Point(12, 96)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(456, 166)
        Me.grpDatos.TabIndex = 3
        Me.grpDatos.TabStop = False
        '
        'btnCalcular
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.calculator2
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCalcular.Appearance = Appearance1
        Me.btnCalcular.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCalcular.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCalcular.Location = New System.Drawing.Point(220, 97)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(40, 39)
        Me.btnCalcular.TabIndex = 5
        Me.tip.SetToolTip(Me.btnCalcular, "Nuevo Registro")
        Me.btnCalcular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtMargen
        '
        Me.txtMargen.Location = New System.Drawing.Point(105, 106)
        Me.txtMargen.Name = "txtMargen"
        Me.txtMargen.Size = New System.Drawing.Size(100, 20)
        Me.txtMargen.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Margen bruto"
        '
        'txtPrecioBase
        '
        Me.txtPrecioBase.Location = New System.Drawing.Point(336, 64)
        Me.txtPrecioBase.Name = "txtPrecioBase"
        Me.txtPrecioBase.ReadOnly = True
        Me.txtPrecioBase.Size = New System.Drawing.Size(108, 20)
        Me.txtPrecioBase.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(246, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Precio Base"
        '
        'txtGramos
        '
        Me.txtGramos.Location = New System.Drawing.Point(336, 20)
        Me.txtGramos.Name = "txtGramos"
        Me.txtGramos.ReadOnly = True
        Me.txtGramos.Size = New System.Drawing.Size(108, 20)
        Me.txtGramos.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(228, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gramos (finos)"
        '
        'txtPrecioOro
        '
        Me.txtPrecioOro.Location = New System.Drawing.Point(105, 64)
        Me.txtPrecioOro.Name = "txtPrecioOro"
        Me.txtPrecioOro.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioOro.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio oro"
        '
        'txtOnzas
        '
        Me.txtOnzas.Location = New System.Drawing.Point(105, 19)
        Me.txtOnzas.Name = "txtOnzas"
        Me.txtOnzas.Size = New System.Drawing.Size(100, 20)
        Me.txtOnzas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Onzas (finas)"
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnCancelar)
        Me.grpButtons.Controls.Add(Me.btnEliminar)
        Me.grpButtons.Controls.Add(Me.btnEditar)
        Me.grpButtons.Controls.Add(Me.btnGuardar)
        Me.grpButtons.Controls.Add(Me.btnNuevo)
        Me.grpButtons.Location = New System.Drawing.Point(12, 268)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(456, 89)
        Me.grpButtons.TabIndex = 4
        Me.grpButtons.TabStop = False
        '
        'btnCancelar
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.cancel02
        Me.btnCancelar.Appearance = Appearance2
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCancelar.ImageSize = New System.Drawing.Size(38, 38)
        Me.btnCancelar.Location = New System.Drawing.Point(277, 20)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(50, 50)
        Me.btnCancelar.TabIndex = 4
        Me.tip.SetToolTip(Me.btnCancelar, "Cancelar")
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEliminar
        '
        Appearance3.Image = Global.EfectiOro.My.Resources.Resources.trash
        Me.btnEliminar.Appearance = Appearance3
        Me.btnEliminar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnEliminar.ImageSize = New System.Drawing.Size(38, 38)
        Me.btnEliminar.Location = New System.Drawing.Point(210, 20)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnEliminar.TabIndex = 3
        Me.tip.SetToolTip(Me.btnEliminar, "Eliminar Registro")
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEditar
        '
        Appearance4.Image = Global.EfectiOro.My.Resources.Resources.edit01
        Me.btnEditar.Appearance = Appearance4
        Me.btnEditar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnEditar.ImageSize = New System.Drawing.Size(38, 38)
        Me.btnEditar.Location = New System.Drawing.Point(143, 20)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(50, 50)
        Me.btnEditar.TabIndex = 2
        Me.tip.SetToolTip(Me.btnEditar, "Editar Registro")
        Me.btnEditar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnGuardar
        '
        Appearance5.Image = Global.EfectiOro.My.Resources.Resources.save01
        Me.btnGuardar.Appearance = Appearance5
        Me.btnGuardar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnGuardar.ImageSize = New System.Drawing.Size(38, 38)
        Me.btnGuardar.Location = New System.Drawing.Point(76, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(50, 50)
        Me.btnGuardar.TabIndex = 1
        Me.tip.SetToolTip(Me.btnGuardar, "Guardar Registro")
        Me.btnGuardar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnNuevo
        '
        Appearance6.Image = Global.EfectiOro.My.Resources.Resources.new01
        Me.btnNuevo.Appearance = Appearance6
        Me.btnNuevo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnNuevo.ImageSize = New System.Drawing.Size(38, 38)
        Me.btnNuevo.Location = New System.Drawing.Point(9, 20)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(50, 50)
        Me.btnNuevo.TabIndex = 0
        Me.tip.SetToolTip(Me.btnNuevo, "Nuevo Registro")
        Me.btnNuevo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'grpLista
        '
        Me.grpLista.Controls.Add(Me.dgvCierresCliente)
        Me.grpLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLista.Location = New System.Drawing.Point(474, 31)
        Me.grpLista.Name = "grpLista"
        Me.grpLista.Size = New System.Drawing.Size(427, 329)
        Me.grpLista.TabIndex = 5
        Me.grpLista.TabStop = False
        Me.grpLista.Text = "Lista de cierres del cliente"
        '
        'dgvCierresCliente
        '
        Me.dgvCierresCliente.AllowUserToAddRows = False
        Me.dgvCierresCliente.AllowUserToDeleteRows = False
        Me.dgvCierresCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCierresCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCierresCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colPrecio, Me.colOnzas, Me.colSaldo, Me.colFecha, Me.colPrecioBase})
        Me.dgvCierresCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCierresCliente.Location = New System.Drawing.Point(3, 17)
        Me.dgvCierresCliente.Name = "dgvCierresCliente"
        Me.dgvCierresCliente.ReadOnly = True
        Me.dgvCierresCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCierresCliente.Size = New System.Drawing.Size(421, 309)
        Me.dgvCierresCliente.TabIndex = 0
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 63
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        Me.colPrecio.Width = 63
        '
        'colOnzas
        '
        Me.colOnzas.HeaderText = "Onzas"
        Me.colOnzas.Name = "colOnzas"
        Me.colOnzas.ReadOnly = True
        Me.colOnzas.Width = 63
        '
        'colSaldo
        '
        Me.colSaldo.HeaderText = "Saldo Oz"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.ReadOnly = True
        Me.colSaldo.Width = 63
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        Me.colFecha.Width = 63
        '
        'colPrecioBase
        '
        Me.colPrecioBase.HeaderText = "Precio Base"
        Me.colPrecioBase.Name = "colPrecioBase"
        Me.colPrecioBase.ReadOnly = True
        Me.colPrecioBase.Width = 63
        '
        'tip
        '
        Me.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        Me.erp.Icon = CType(resources.GetObject("erp.Icon"), System.Drawing.Icon)
        '
        'frmCierrePrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(913, 372)
        Me.Controls.Add(Me.grpLista)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCierrePrecios"
        Me.Controls.SetChildIndex(Me.grpCliente, 0)
        Me.Controls.SetChildIndex(Me.grpDatos, 0)
        Me.Controls.SetChildIndex(Me.dgvCliente, 0)
        Me.Controls.SetChildIndex(Me.grpButtons, 0)
        Me.Controls.SetChildIndex(Me.grpLista, 0)
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.grpButtons.ResumeLayout(False)
        Me.grpLista.ResumeLayout(False)
        CType(Me.dgvCierresCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrecioOro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOnzas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrecioBase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGramos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpLista As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCierresCliente As System.Windows.Forms.DataGridView
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOnzas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnNuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tip As System.Windows.Forms.ToolTip
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtMargen As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As Infragistics.Win.Misc.UltraButton
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents colPrecioBase As DataGridViewTextBoxColumn
End Class

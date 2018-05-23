<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservaOro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservaOro))
        Me.grupoCliente = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.txtOnzasSaldo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKilate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOnzasDiferencia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOnzasEntregadas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecioKilate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOnzas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGramos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioInternacional = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaCierre = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listReservas = New System.Windows.Forms.ListView()
        Me.colIdreserva = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblInformacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panelTitulo.SuspendLayout()
        Me.grupoCliente.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grupoDatos.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(617, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(592, 25)
        '
        'grupoCliente
        '
        Me.grupoCliente.Controls.Add(Me.Label11)
        Me.grupoCliente.Controls.Add(Me.Label10)
        Me.grupoCliente.Controls.Add(Me.txtApellidos)
        Me.grupoCliente.Controls.Add(Me.txtNombres)
        Me.grupoCliente.Controls.Add(Me.txtCodigo)
        Me.grupoCliente.Controls.Add(Me.Label1)
        Me.grupoCliente.Location = New System.Drawing.Point(12, 28)
        Me.grupoCliente.Name = "grupoCliente"
        Me.grupoCliente.Size = New System.Drawing.Size(588, 67)
        Me.grupoCliente.TabIndex = 1
        Me.grupoCliente.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(375, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Apellidos del cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(190, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nombre del cliente"
        '
        'txtApellidos
        '
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Location = New System.Drawing.Point(378, 29)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(172, 20)
        Me.txtApellidos.TabIndex = 3
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(193, 29)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(172, 20)
        Me.txtNombres.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(30, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo del cliente"
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(32, 78)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(440, 13)
        Me.dgvCliente.TabIndex = 2
        Me.dgvCliente.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReporte)
        Me.GroupBox2.Controls.Add(Me.btnCerrar)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 66)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Image = Global.EfectiOro.My.Resources.Resources.surveys
        Me.btnReporte.Location = New System.Drawing.Point(348, 9)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(61, 51)
        Me.btnReporte.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnReporte, "Ver reporte general")
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Enabled = False
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.EfectiOro.My.Resources.Resources.INSERT_TO_SHOPPING_CART
        Me.btnCerrar.Location = New System.Drawing.Point(281, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(61, 51)
        Me.btnCerrar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnCerrar, "Cerrar precio")
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.EfectiOro.My.Resources.Resources._48
        Me.btnCancelar.Location = New System.Drawing.Point(214, 9)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 51)
        Me.btnCancelar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar operación")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.EfectiOro.My.Resources.Resources._7
        Me.btnGuardar.Location = New System.Drawing.Point(147, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 51)
        Me.btnGuardar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar los datos")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = Global.EfectiOro.My.Resources.Resources._2
        Me.btnEditar.Location = New System.Drawing.Point(80, 9)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(61, 51)
        Me.btnEditar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnEditar, "Buscar cierre para editar")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.EfectiOro.My.Resources.Resources._8
        Me.btnNuevo.Location = New System.Drawing.Point(13, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 51)
        Me.btnNuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo cierre")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.txtOnzasSaldo)
        Me.grupoDatos.Controls.Add(Me.Label13)
        Me.grupoDatos.Controls.Add(Me.txtKilate)
        Me.grupoDatos.Controls.Add(Me.Label12)
        Me.grupoDatos.Controls.Add(Me.txtOnzasDiferencia)
        Me.grupoDatos.Controls.Add(Me.Label8)
        Me.grupoDatos.Controls.Add(Me.txtOnzasEntregadas)
        Me.grupoDatos.Controls.Add(Me.Label9)
        Me.grupoDatos.Controls.Add(Me.txtPrecioKilate)
        Me.grupoDatos.Controls.Add(Me.Label7)
        Me.grupoDatos.Controls.Add(Me.txtOnzas)
        Me.grupoDatos.Controls.Add(Me.Label6)
        Me.grupoDatos.Controls.Add(Me.txtGramos)
        Me.grupoDatos.Controls.Add(Me.Label5)
        Me.grupoDatos.Controls.Add(Me.txtPrecioInternacional)
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.txtFechaEntrega)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtFechaCierre)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 101)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(479, 146)
        Me.grupoDatos.TabIndex = 2
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Opciones"
        '
        'txtOnzasSaldo
        '
        Me.txtOnzasSaldo.Enabled = False
        Me.txtOnzasSaldo.Location = New System.Drawing.Point(344, 120)
        Me.txtOnzasSaldo.Name = "txtOnzasSaldo"
        Me.txtOnzasSaldo.Size = New System.Drawing.Size(116, 20)
        Me.txtOnzasSaldo.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(262, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Onzas (Saldo):"
        '
        'txtKilate
        '
        Me.txtKilate.Enabled = False
        Me.txtKilate.Location = New System.Drawing.Point(119, 116)
        Me.txtKilate.Name = "txtKilate"
        Me.txtKilate.Size = New System.Drawing.Size(116, 20)
        Me.txtKilate.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Kilataje:"
        '
        'txtOnzasDiferencia
        '
        Me.txtOnzasDiferencia.Enabled = False
        Me.txtOnzasDiferencia.Location = New System.Drawing.Point(345, 90)
        Me.txtOnzasDiferencia.Name = "txtOnzasDiferencia"
        Me.txtOnzasDiferencia.Size = New System.Drawing.Size(116, 20)
        Me.txtOnzasDiferencia.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Onzas diferencia:"
        '
        'txtOnzasEntregadas
        '
        Me.txtOnzasEntregadas.Enabled = False
        Me.txtOnzasEntregadas.Location = New System.Drawing.Point(119, 90)
        Me.txtOnzasEntregadas.Name = "txtOnzasEntregadas"
        Me.txtOnzasEntregadas.Size = New System.Drawing.Size(116, 20)
        Me.txtOnzasEntregadas.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Onzas entregadas:"
        '
        'txtPrecioKilate
        '
        Me.txtPrecioKilate.Enabled = False
        Me.txtPrecioKilate.Location = New System.Drawing.Point(345, 38)
        Me.txtPrecioKilate.Name = "txtPrecioKilate"
        Me.txtPrecioKilate.Size = New System.Drawing.Size(116, 20)
        Me.txtPrecioKilate.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio por quilate:"
        '
        'txtOnzas
        '
        Me.txtOnzas.Enabled = False
        Me.txtOnzas.Location = New System.Drawing.Point(345, 64)
        Me.txtOnzas.Name = "txtOnzas"
        Me.txtOnzas.Size = New System.Drawing.Size(116, 20)
        Me.txtOnzas.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Onzas (Monto):"
        '
        'txtGramos
        '
        Me.txtGramos.Enabled = False
        Me.txtGramos.Location = New System.Drawing.Point(119, 64)
        Me.txtGramos.Name = "txtGramos"
        Me.txtGramos.Size = New System.Drawing.Size(116, 20)
        Me.txtGramos.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gramos:"
        '
        'txtPrecioInternacional
        '
        Me.txtPrecioInternacional.Enabled = False
        Me.txtPrecioInternacional.Location = New System.Drawing.Point(119, 38)
        Me.txtPrecioInternacional.Name = "txtPrecioInternacional"
        Me.txtPrecioInternacional.Size = New System.Drawing.Size(116, 20)
        Me.txtPrecioInternacional.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Precio internacional:"
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.Enabled = False
        Me.txtFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaEntrega.Location = New System.Drawing.Point(345, 13)
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Size = New System.Drawing.Size(116, 20)
        Me.txtFechaEntrega.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de entrega:"
        '
        'txtFechaCierre
        '
        Me.txtFechaCierre.Enabled = False
        Me.txtFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaCierre.Location = New System.Drawing.Point(119, 13)
        Me.txtFechaCierre.Name = "txtFechaCierre"
        Me.txtFechaCierre.Size = New System.Drawing.Size(116, 20)
        Me.txtFechaCierre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha de cierre:"
        '
        'listReservas
        '
        Me.listReservas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIdreserva})
        Me.listReservas.Enabled = False
        Me.listReservas.Location = New System.Drawing.Point(504, 101)
        Me.listReservas.MultiSelect = False
        Me.listReservas.Name = "listReservas"
        Me.listReservas.Size = New System.Drawing.Size(96, 218)
        Me.listReservas.TabIndex = 3
        Me.listReservas.UseCompatibleStateImageBehavior = False
        Me.listReservas.View = System.Windows.Forms.View.Details
        '
        'colIdreserva
        '
        Me.colIdreserva.Text = "No reserva"
        Me.colIdreserva.Width = 90
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblInformacion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 332)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(617, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblInformacion
        '
        Me.lblInformacion.BackColor = System.Drawing.Color.Transparent
        Me.lblInformacion.Name = "lblInformacion"
        Me.lblInformacion.Size = New System.Drawing.Size(72, 17)
        Me.lblInformacion.Text = "Informacion"
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmReservaOro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(617, 354)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.listReservas)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.grupoDatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grupoCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReservaOro"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.grupoCliente, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.grupoDatos, 0)
        Me.Controls.SetChildIndex(Me.dgvCliente, 0)
        Me.Controls.SetChildIndex(Me.listReservas, 0)
        Me.Controls.SetChildIndex(Me.StatusStrip1, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.grupoCliente.ResumeLayout(False)
        Me.grupoCliente.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grupoCliente As GroupBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCliente As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents grupoDatos As GroupBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtFechaEntrega As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaCierre As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecioKilate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOnzas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGramos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecioInternacional As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents listReservas As ListView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblInformacion As ToolStripStatusLabel
    Friend WithEvents txtOnzasDiferencia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOnzasEntregadas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents erp As ErrorProvider
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtKilate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents colIdreserva As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtOnzasSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class

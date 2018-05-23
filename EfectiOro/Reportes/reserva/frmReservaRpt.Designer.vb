<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservaRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservaRpt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.codigoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrecliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radPorCliente = New System.Windows.Forms.RadioButton()
        Me.cmbGeneral = New System.Windows.Forms.ComboBox()
        Me.radGeneral = New System.Windows.Forms.RadioButton()
        Me.lblClienteSeleccionado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.listReservas = New System.Windows.Forms.ListView()
        Me.colIdreserva = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbporcliente = New System.Windows.Forms.ComboBox()
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(855, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(830, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSeleccion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtHasta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 338)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'lblSeleccion
        '
        Me.lblSeleccion.AutoSize = True
        Me.lblSeleccion.Location = New System.Drawing.Point(7, 318)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(60, 13)
        Me.lblSeleccion.TabIndex = 4
        Me.lblSeleccion.Text = "(Selección)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta:"
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(6, 83)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(157, 20)
        Me.txtHasta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(6, 36)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(157, 20)
        Me.txtDesde.TabIndex = 0
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoCliente, Me.nombrecliente, Me.apellidoCliente})
        Me.dgvClientes.Location = New System.Drawing.Point(6, 55)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(489, 119)
        Me.dgvClientes.TabIndex = 2
        '
        'codigoCliente
        '
        Me.codigoCliente.HeaderText = "Codigo Cliente"
        Me.codigoCliente.Name = "codigoCliente"
        Me.codigoCliente.ReadOnly = True
        '
        'nombrecliente
        '
        Me.nombrecliente.HeaderText = "Nombres"
        Me.nombrecliente.Name = "nombrecliente"
        Me.nombrecliente.ReadOnly = True
        '
        'apellidoCliente
        '
        Me.apellidoCliente.HeaderText = "Apellidos"
        Me.apellidoCliente.Name = "apellidoCliente"
        Me.apellidoCliente.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbporcliente)
        Me.GroupBox2.Controls.Add(Me.dgvClientes)
        Me.GroupBox2.Controls.Add(Me.radPorCliente)
        Me.GroupBox2.Controls.Add(Me.cmbGeneral)
        Me.GroupBox2.Controls.Add(Me.radGeneral)
        Me.GroupBox2.Controls.Add(Me.lblClienteSeleccionado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFiltrar)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 338)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'radPorCliente
        '
        Me.radPorCliente.AutoSize = True
        Me.radPorCliente.Location = New System.Drawing.Point(31, 232)
        Me.radPorCliente.Name = "radPorCliente"
        Me.radPorCliente.Size = New System.Drawing.Size(117, 17)
        Me.radPorCliente.TabIndex = 8
        Me.radPorCliente.TabStop = True
        Me.radPorCliente.Text = "Reporte Por Cliente"
        Me.radPorCliente.UseVisualStyleBackColor = True
        '
        'cmbGeneral
        '
        Me.cmbGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneral.FormattingEnabled = True
        Me.cmbGeneral.Items.AddRange(New Object() {"Todos", "Detallado"})
        Me.cmbGeneral.Location = New System.Drawing.Point(175, 192)
        Me.cmbGeneral.Name = "cmbGeneral"
        Me.cmbGeneral.Size = New System.Drawing.Size(155, 21)
        Me.cmbGeneral.TabIndex = 7
        Me.cmbGeneral.Visible = False
        '
        'radGeneral
        '
        Me.radGeneral.AutoSize = True
        Me.radGeneral.Location = New System.Drawing.Point(31, 191)
        Me.radGeneral.Name = "radGeneral"
        Me.radGeneral.Size = New System.Drawing.Size(103, 17)
        Me.radGeneral.TabIndex = 6
        Me.radGeneral.TabStop = True
        Me.radGeneral.Text = "Reporte General"
        Me.radGeneral.UseVisualStyleBackColor = True
        '
        'lblClienteSeleccionado
        '
        Me.lblClienteSeleccionado.AutoSize = True
        Me.lblClienteSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteSeleccionado.Location = New System.Drawing.Point(235, 30)
        Me.lblClienteSeleccionado.Name = "lblClienteSeleccionado"
        Me.lblClienteSeleccionado.Size = New System.Drawing.Size(61, 17)
        Me.lblClienteSeleccionado.TabIndex = 5
        Me.lblClienteSeleccionado.Text = "(Cliente)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Filtrar:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(60, 29)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(169, 20)
        Me.txtFiltrar.TabIndex = 3
        '
        'listReservas
        '
        Me.listReservas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIdreserva})
        Me.listReservas.Location = New System.Drawing.Point(725, 31)
        Me.listReservas.MultiSelect = False
        Me.listReservas.Name = "listReservas"
        Me.listReservas.Size = New System.Drawing.Size(118, 338)
        Me.listReservas.TabIndex = 4
        Me.listReservas.UseCompatibleStateImageBehavior = False
        Me.listReservas.View = System.Windows.Forms.View.Details
        '
        'colIdreserva
        '
        Me.colIdreserva.Text = "No reserva"
        Me.colIdreserva.Width = 90
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(831, 91)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Me.btnSalir.Location = New System.Drawing.Point(626, 23)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 62)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.EfectiOro.My.Resources.Resources.print_view_48
        Me.btnBuscar.Location = New System.Drawing.Point(206, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 62)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cmbporcliente
        '
        Me.cmbporcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbporcliente.FormattingEnabled = True
        Me.cmbporcliente.Items.AddRange(New Object() {"General", "Detallado"})
        Me.cmbporcliente.Location = New System.Drawing.Point(175, 231)
        Me.cmbporcliente.Name = "cmbporcliente"
        Me.cmbporcliente.Size = New System.Drawing.Size(155, 21)
        Me.cmbporcliente.TabIndex = 9
        Me.cmbporcliente.Visible = False
        '
        'frmReservaRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(855, 479)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.listReservas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReservaRpt"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.listReservas, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSeleccion As System.Windows.Forms.Label
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents codigoCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombrecliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidoCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents listReservas As System.Windows.Forms.ListView
    Friend WithEvents colIdreserva As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblClienteSeleccionado As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGeneral As System.Windows.Forms.ComboBox
    Friend WithEvents radGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents radPorCliente As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbporcliente As System.Windows.Forms.ComboBox

End Class

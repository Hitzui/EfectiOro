<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdelantosReportes
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.colCodcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumcedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FemisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FvencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadocivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OcupacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionnegocioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiemponegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtraaeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescotraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontomensualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaloperacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActuaporDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreterceroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionterceroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(816, 25)
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodcliente, Me.colNombres, Me.colApellidos, Me.NumcedulaDataGridViewTextBoxColumn, Me.FemisionDataGridViewTextBoxColumn, Me.FvencimientoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.FnacimientoDataGridViewTextBoxColumn, Me.EstadocivilDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.FingresoDataGridViewTextBoxColumn, Me.OcupacionDataGridViewTextBoxColumn, Me.DireccionnegocioDataGridViewTextBoxColumn, Me.TiemponegDataGridViewTextBoxColumn, Me.OtraaeDataGridViewTextBoxColumn, Me.DescotraDataGridViewTextBoxColumn, Me.NomcuentaDataGridViewTextBoxColumn, Me.NumcuentaDataGridViewTextBoxColumn, Me.NombancoDataGridViewTextBoxColumn, Me.MontomensualDataGridViewTextBoxColumn, Me.TotaloperacionesDataGridViewTextBoxColumn, Me.ActuaporDataGridViewTextBoxColumn, Me.NombreterceroDataGridViewTextBoxColumn, Me.DireccionterceroDataGridViewTextBoxColumn, Me.PicaDataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.bsClientes
        Me.dgvClientes.Location = New System.Drawing.Point(6, 44)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(435, 185)
        Me.dgvClientes.TabIndex = 1
        '
        'colCodcliente
        '
        Me.colCodcliente.DataPropertyName = "Codcliente"
        Me.colCodcliente.HeaderText = "Cod Cliente"
        Me.colCodcliente.Name = "colCodcliente"
        Me.colCodcliente.ReadOnly = True
        '
        'colNombres
        '
        Me.colNombres.DataPropertyName = "Nombres"
        Me.colNombres.HeaderText = "Nombres"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        '
        'colApellidos
        '
        Me.colApellidos.DataPropertyName = "Apellidos"
        Me.colApellidos.HeaderText = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.ReadOnly = True
        '
        'NumcedulaDataGridViewTextBoxColumn
        '
        Me.NumcedulaDataGridViewTextBoxColumn.DataPropertyName = "Numcedula"
        Me.NumcedulaDataGridViewTextBoxColumn.HeaderText = "Numcedula"
        Me.NumcedulaDataGridViewTextBoxColumn.Name = "NumcedulaDataGridViewTextBoxColumn"
        Me.NumcedulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumcedulaDataGridViewTextBoxColumn.Visible = False
        '
        'FemisionDataGridViewTextBoxColumn
        '
        Me.FemisionDataGridViewTextBoxColumn.DataPropertyName = "F_emision"
        Me.FemisionDataGridViewTextBoxColumn.HeaderText = "F_emision"
        Me.FemisionDataGridViewTextBoxColumn.Name = "FemisionDataGridViewTextBoxColumn"
        Me.FemisionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FemisionDataGridViewTextBoxColumn.Visible = False
        '
        'FvencimientoDataGridViewTextBoxColumn
        '
        Me.FvencimientoDataGridViewTextBoxColumn.DataPropertyName = "F_vencimiento"
        Me.FvencimientoDataGridViewTextBoxColumn.HeaderText = "F_vencimiento"
        Me.FvencimientoDataGridViewTextBoxColumn.Name = "FvencimientoDataGridViewTextBoxColumn"
        Me.FvencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FvencimientoDataGridViewTextBoxColumn.Visible = False
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Visible = False
        '
        'FnacimientoDataGridViewTextBoxColumn
        '
        Me.FnacimientoDataGridViewTextBoxColumn.DataPropertyName = "F_nacimiento"
        Me.FnacimientoDataGridViewTextBoxColumn.HeaderText = "F_nacimiento"
        Me.FnacimientoDataGridViewTextBoxColumn.Name = "FnacimientoDataGridViewTextBoxColumn"
        Me.FnacimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnacimientoDataGridViewTextBoxColumn.Visible = False
        '
        'EstadocivilDataGridViewTextBoxColumn
        '
        Me.EstadocivilDataGridViewTextBoxColumn.DataPropertyName = "Estadocivil"
        Me.EstadocivilDataGridViewTextBoxColumn.HeaderText = "Estadocivil"
        Me.EstadocivilDataGridViewTextBoxColumn.Name = "EstadocivilDataGridViewTextBoxColumn"
        Me.EstadocivilDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadocivilDataGridViewTextBoxColumn.Visible = False
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CiudadDataGridViewTextBoxColumn.Visible = False
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Visible = False
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        Me.CelularDataGridViewTextBoxColumn.Visible = False
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Visible = False
        '
        'FingresoDataGridViewTextBoxColumn
        '
        Me.FingresoDataGridViewTextBoxColumn.DataPropertyName = "F_ingreso"
        Me.FingresoDataGridViewTextBoxColumn.HeaderText = "F_ingreso"
        Me.FingresoDataGridViewTextBoxColumn.Name = "FingresoDataGridViewTextBoxColumn"
        Me.FingresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FingresoDataGridViewTextBoxColumn.Visible = False
        '
        'OcupacionDataGridViewTextBoxColumn
        '
        Me.OcupacionDataGridViewTextBoxColumn.DataPropertyName = "Ocupacion"
        Me.OcupacionDataGridViewTextBoxColumn.HeaderText = "Ocupacion"
        Me.OcupacionDataGridViewTextBoxColumn.Name = "OcupacionDataGridViewTextBoxColumn"
        Me.OcupacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.OcupacionDataGridViewTextBoxColumn.Visible = False
        '
        'DireccionnegocioDataGridViewTextBoxColumn
        '
        Me.DireccionnegocioDataGridViewTextBoxColumn.DataPropertyName = "Direccion_negocio"
        Me.DireccionnegocioDataGridViewTextBoxColumn.HeaderText = "Direccion_negocio"
        Me.DireccionnegocioDataGridViewTextBoxColumn.Name = "DireccionnegocioDataGridViewTextBoxColumn"
        Me.DireccionnegocioDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionnegocioDataGridViewTextBoxColumn.Visible = False
        '
        'TiemponegDataGridViewTextBoxColumn
        '
        Me.TiemponegDataGridViewTextBoxColumn.DataPropertyName = "Tiempo_neg"
        Me.TiemponegDataGridViewTextBoxColumn.HeaderText = "Tiempo_neg"
        Me.TiemponegDataGridViewTextBoxColumn.Name = "TiemponegDataGridViewTextBoxColumn"
        Me.TiemponegDataGridViewTextBoxColumn.ReadOnly = True
        Me.TiemponegDataGridViewTextBoxColumn.Visible = False
        '
        'OtraaeDataGridViewTextBoxColumn
        '
        Me.OtraaeDataGridViewTextBoxColumn.DataPropertyName = "Otra_ae"
        Me.OtraaeDataGridViewTextBoxColumn.HeaderText = "Otra_ae"
        Me.OtraaeDataGridViewTextBoxColumn.Name = "OtraaeDataGridViewTextBoxColumn"
        Me.OtraaeDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtraaeDataGridViewTextBoxColumn.Visible = False
        '
        'DescotraDataGridViewTextBoxColumn
        '
        Me.DescotraDataGridViewTextBoxColumn.DataPropertyName = "Desc_otra"
        Me.DescotraDataGridViewTextBoxColumn.HeaderText = "Desc_otra"
        Me.DescotraDataGridViewTextBoxColumn.Name = "DescotraDataGridViewTextBoxColumn"
        Me.DescotraDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescotraDataGridViewTextBoxColumn.Visible = False
        '
        'NomcuentaDataGridViewTextBoxColumn
        '
        Me.NomcuentaDataGridViewTextBoxColumn.DataPropertyName = "Nom_cuenta"
        Me.NomcuentaDataGridViewTextBoxColumn.HeaderText = "Nom_cuenta"
        Me.NomcuentaDataGridViewTextBoxColumn.Name = "NomcuentaDataGridViewTextBoxColumn"
        Me.NomcuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomcuentaDataGridViewTextBoxColumn.Visible = False
        '
        'NumcuentaDataGridViewTextBoxColumn
        '
        Me.NumcuentaDataGridViewTextBoxColumn.DataPropertyName = "Num_cuenta"
        Me.NumcuentaDataGridViewTextBoxColumn.HeaderText = "Num_cuenta"
        Me.NumcuentaDataGridViewTextBoxColumn.Name = "NumcuentaDataGridViewTextBoxColumn"
        Me.NumcuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumcuentaDataGridViewTextBoxColumn.Visible = False
        '
        'NombancoDataGridViewTextBoxColumn
        '
        Me.NombancoDataGridViewTextBoxColumn.DataPropertyName = "Nom_banco"
        Me.NombancoDataGridViewTextBoxColumn.HeaderText = "Nom_banco"
        Me.NombancoDataGridViewTextBoxColumn.Name = "NombancoDataGridViewTextBoxColumn"
        Me.NombancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombancoDataGridViewTextBoxColumn.Visible = False
        '
        'MontomensualDataGridViewTextBoxColumn
        '
        Me.MontomensualDataGridViewTextBoxColumn.DataPropertyName = "Monto_mensual"
        Me.MontomensualDataGridViewTextBoxColumn.HeaderText = "Monto_mensual"
        Me.MontomensualDataGridViewTextBoxColumn.Name = "MontomensualDataGridViewTextBoxColumn"
        Me.MontomensualDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontomensualDataGridViewTextBoxColumn.Visible = False
        '
        'TotaloperacionesDataGridViewTextBoxColumn
        '
        Me.TotaloperacionesDataGridViewTextBoxColumn.DataPropertyName = "Total_operaciones"
        Me.TotaloperacionesDataGridViewTextBoxColumn.HeaderText = "Total_operaciones"
        Me.TotaloperacionesDataGridViewTextBoxColumn.Name = "TotaloperacionesDataGridViewTextBoxColumn"
        Me.TotaloperacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotaloperacionesDataGridViewTextBoxColumn.Visible = False
        '
        'ActuaporDataGridViewTextBoxColumn
        '
        Me.ActuaporDataGridViewTextBoxColumn.DataPropertyName = "Actua_por"
        Me.ActuaporDataGridViewTextBoxColumn.HeaderText = "Actua_por"
        Me.ActuaporDataGridViewTextBoxColumn.Name = "ActuaporDataGridViewTextBoxColumn"
        Me.ActuaporDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActuaporDataGridViewTextBoxColumn.Visible = False
        '
        'NombreterceroDataGridViewTextBoxColumn
        '
        Me.NombreterceroDataGridViewTextBoxColumn.DataPropertyName = "Nombre_tercero"
        Me.NombreterceroDataGridViewTextBoxColumn.HeaderText = "Nombre_tercero"
        Me.NombreterceroDataGridViewTextBoxColumn.Name = "NombreterceroDataGridViewTextBoxColumn"
        Me.NombreterceroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreterceroDataGridViewTextBoxColumn.Visible = False
        '
        'DireccionterceroDataGridViewTextBoxColumn
        '
        Me.DireccionterceroDataGridViewTextBoxColumn.DataPropertyName = "Direccion_tercero"
        Me.DireccionterceroDataGridViewTextBoxColumn.HeaderText = "Direccion_tercero"
        Me.DireccionterceroDataGridViewTextBoxColumn.Name = "DireccionterceroDataGridViewTextBoxColumn"
        Me.DireccionterceroDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionterceroDataGridViewTextBoxColumn.Visible = False
        '
        'PicaDataGridViewTextBoxColumn
        '
        Me.PicaDataGridViewTextBoxColumn.DataPropertyName = "Pica"
        Me.PicaDataGridViewTextBoxColumn.HeaderText = "Pica"
        Me.PicaDataGridViewTextBoxColumn.Name = "PicaDataGridViewTextBoxColumn"
        Me.PicaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PicaDataGridViewTextBoxColumn.Visible = False
        '
        'bsClientes
        '
        Me.bsClientes.DataSource = GetType(EfectiOro.Database.Cliente)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFiltrar)
        Me.GroupBox1.Controls.Add(Me.dgvClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 235)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filtrar:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(53, 17)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(388, 20)
        Me.txtFiltrar.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHasta)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtDesde)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(465, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 229)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(68, 83)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(110, 20)
        Me.txtHasta.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(68, 40)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(110, 20)
        Me.txtDesde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
        '
        'frmAdelantosReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(816, 498)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAdelantosReportes"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents colCodcliente As DataGridViewTextBoxColumn
    Friend WithEvents colNombres As DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As DataGridViewTextBoxColumn
    Friend WithEvents NumcedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FemisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FvencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadocivilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FingresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OcupacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionnegocioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiemponegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtraaeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescotraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumcuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontomensualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotaloperacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActuaporDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreterceroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionterceroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PicaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsClientes As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltrar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesde As DateTimePicker
    Friend WithEvents Label2 As Label
End Class

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSaldoDolares = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSaldoCordobas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AdelantosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbAdelantoCliente = New System.Windows.Forms.ComboBox()
        Me.radAdelantoCliente = New System.Windows.Forms.RadioButton()
        Me.btnVerReporte = New Infragistics.Win.Misc.UltraButton()
        Me.radVerAdelanto = New System.Windows.Forms.RadioButton()
        Me.AdelantosDataGridView = New System.Windows.Forms.DataGridView()
        Me.colSaldocordobasAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldodolaresAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidsalidaAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodclienteAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombrecliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMontoAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldoAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEfectivoAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChequeAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTransferenciaAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodcajaAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuarioAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMontoletrasAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodmonedaAdelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AdelantosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AdelantosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(871, 25)
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToOrderColumns = True
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodcliente, Me.colNombres, Me.colApellidos, Me.NumcedulaDataGridViewTextBoxColumn, Me.FemisionDataGridViewTextBoxColumn, Me.FvencimientoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.FnacimientoDataGridViewTextBoxColumn, Me.EstadocivilDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.FingresoDataGridViewTextBoxColumn, Me.OcupacionDataGridViewTextBoxColumn, Me.DireccionnegocioDataGridViewTextBoxColumn, Me.TiemponegDataGridViewTextBoxColumn, Me.OtraaeDataGridViewTextBoxColumn, Me.DescotraDataGridViewTextBoxColumn, Me.NomcuentaDataGridViewTextBoxColumn, Me.NumcuentaDataGridViewTextBoxColumn, Me.NombancoDataGridViewTextBoxColumn, Me.MontomensualDataGridViewTextBoxColumn, Me.TotaloperacionesDataGridViewTextBoxColumn, Me.ActuaporDataGridViewTextBoxColumn, Me.NombreterceroDataGridViewTextBoxColumn, Me.DireccionterceroDataGridViewTextBoxColumn, Me.PicaDataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.bsClientes
        Me.dgvClientes.Location = New System.Drawing.Point(6, 44)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(410, 185)
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
        Me.GroupBox1.Size = New System.Drawing.Size(422, 235)
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
        Me.txtFiltrar.Size = New System.Drawing.Size(363, 20)
        Me.txtFiltrar.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHasta)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtDesde)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 136)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar segun fecha:"
        '
        'txtHasta
        '
        Me.txtHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(64, 72)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(110, 20)
        Me.txtHasta.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(64, 30)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(110, 20)
        Me.txtDesde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSaldoDolares)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblSaldoCordobas)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(203, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 136)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Saldos del cleinte:"
        '
        'lblSaldoDolares
        '
        Me.lblSaldoDolares.AutoSize = True
        Me.lblSaldoDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoDolares.Location = New System.Drawing.Point(26, 97)
        Me.lblSaldoDolares.Name = "lblSaldoDolares"
        Me.lblSaldoDolares.Size = New System.Drawing.Size(40, 13)
        Me.lblSaldoDolares.TabIndex = 3
        Me.lblSaldoDolares.Text = "(0.00)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Saldo Dólares (U$):"
        '
        'lblSaldoCordobas
        '
        Me.lblSaldoCordobas.AutoSize = True
        Me.lblSaldoCordobas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCordobas.Location = New System.Drawing.Point(26, 53)
        Me.lblSaldoCordobas.Name = "lblSaldoCordobas"
        Me.lblSaldoCordobas.Size = New System.Drawing.Size(40, 13)
        Me.lblSaldoCordobas.TabIndex = 1
        Me.lblSaldoCordobas.Text = "(0.00)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Saldo Cordobas (C$):"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.AdelantosDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(440, 31)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(419, 235)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'AdelantosBindingSource
        '
        Me.AdelantosBindingSource.AllowNew = False
        Me.AdelantosBindingSource.DataSource = GetType(EfectiOro.Database.Adelantos)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbAdelantoCliente)
        Me.GroupBox5.Controls.Add(Me.radAdelantoCliente)
        Me.GroupBox5.Controls.Add(Me.btnVerReporte)
        Me.GroupBox5.Controls.Add(Me.radVerAdelanto)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(440, 272)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(416, 214)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Opciones"
        '
        'cmbAdelantoCliente
        '
        Me.cmbAdelantoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdelantoCliente.Enabled = False
        Me.cmbAdelantoCliente.FormattingEnabled = True
        Me.cmbAdelantoCliente.Items.AddRange(New Object() {"Detallado por fecha", "Consolidado por fecha"})
        Me.cmbAdelantoCliente.Location = New System.Drawing.Point(163, 75)
        Me.cmbAdelantoCliente.Name = "cmbAdelantoCliente"
        Me.cmbAdelantoCliente.Size = New System.Drawing.Size(130, 21)
        Me.cmbAdelantoCliente.TabIndex = 8
        '
        'radAdelantoCliente
        '
        Me.radAdelantoCliente.AutoSize = True
        Me.radAdelantoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAdelantoCliente.Location = New System.Drawing.Point(26, 76)
        Me.radAdelantoCliente.Name = "radAdelantoCliente"
        Me.radAdelantoCliente.Size = New System.Drawing.Size(107, 17)
        Me.radAdelantoCliente.TabIndex = 7
        Me.radAdelantoCliente.TabStop = True
        Me.radAdelantoCliente.Text = "Adelantos Cliente"
        Me.radAdelantoCliente.UseVisualStyleBackColor = True
        '
        'btnVerReporte
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.analysis
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnVerReporte.Appearance = Appearance1
        Me.btnVerReporte.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ScenicRibbonScrollbarButton
        Me.btnVerReporte.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnVerReporte.Location = New System.Drawing.Point(344, 154)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(66, 54)
        Me.btnVerReporte.TabIndex = 6
        Me.btnVerReporte.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'radVerAdelanto
        '
        Me.radVerAdelanto.AutoSize = True
        Me.radVerAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVerAdelanto.Location = New System.Drawing.Point(26, 34)
        Me.radVerAdelanto.Name = "radVerAdelanto"
        Me.radVerAdelanto.Size = New System.Drawing.Size(136, 17)
        Me.radVerAdelanto.TabIndex = 5
        Me.radVerAdelanto.TabStop = True
        Me.radVerAdelanto.Text = "Ver detalle del adelanto"
        Me.radVerAdelanto.UseVisualStyleBackColor = True
        '
        'AdelantosDataGridView
        '
        Me.AdelantosDataGridView.AllowUserToAddRows = False
        Me.AdelantosDataGridView.AllowUserToDeleteRows = False
        Me.AdelantosDataGridView.AutoGenerateColumns = False
        Me.AdelantosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AdelantosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdelantosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSaldocordobasAdelanto, Me.colSaldodolaresAdelanto, Me.colidsalidaAdelanto, Me.colCodclienteAdelanto, Me.DataGridViewTextBoxColumn6, Me.colNombrecliente, Me.colFechaAdelanto, Me.colHoraAdelanto, Me.colMontoAdelanto, Me.colSaldoAdelanto, Me.colEfectivoAdelanto, Me.colChequeAdelanto, Me.colTransferenciaAdelanto, Me.colCodcajaAdelanto, Me.colUsuarioAdelanto, Me.colMontoletrasAdelanto, Me.colCodmonedaAdelanto})
        Me.AdelantosDataGridView.DataSource = Me.AdelantosBindingSource
        Me.AdelantosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdelantosDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.AdelantosDataGridView.Name = "AdelantosDataGridView"
        Me.AdelantosDataGridView.ReadOnly = True
        Me.AdelantosDataGridView.Size = New System.Drawing.Size(413, 216)
        Me.AdelantosDataGridView.TabIndex = 0
        '
        'colSaldocordobasAdelanto
        '
        Me.colSaldocordobasAdelanto.DataPropertyName = "saldoCordobas"
        Me.colSaldocordobasAdelanto.HeaderText = "saldoCordobas"
        Me.colSaldocordobasAdelanto.Name = "colSaldocordobasAdelanto"
        Me.colSaldocordobasAdelanto.ReadOnly = True
        Me.colSaldocordobasAdelanto.Visible = False
        '
        'colSaldodolaresAdelanto
        '
        Me.colSaldodolaresAdelanto.DataPropertyName = "saldoDolares"
        Me.colSaldodolaresAdelanto.HeaderText = "saldoDolares"
        Me.colSaldodolaresAdelanto.Name = "colSaldodolaresAdelanto"
        Me.colSaldodolaresAdelanto.ReadOnly = True
        Me.colSaldodolaresAdelanto.Visible = False
        '
        'colidsalidaAdelanto
        '
        Me.colidsalidaAdelanto.DataPropertyName = "Idsalida"
        Me.colidsalidaAdelanto.HeaderText = "Cod Adelanto"
        Me.colidsalidaAdelanto.Name = "colidsalidaAdelanto"
        Me.colidsalidaAdelanto.ReadOnly = True
        '
        'colCodclienteAdelanto
        '
        Me.colCodclienteAdelanto.DataPropertyName = "Codcliente"
        Me.colCodclienteAdelanto.HeaderText = "Codcliente"
        Me.colCodclienteAdelanto.Name = "colCodclienteAdelanto"
        Me.colCodclienteAdelanto.ReadOnly = True
        Me.colCodclienteAdelanto.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Numcompra"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Numcompra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'colNombrecliente
        '
        Me.colNombrecliente.DataPropertyName = "nombreCliente"
        Me.colNombrecliente.HeaderText = "Moneda"
        Me.colNombrecliente.Name = "colNombrecliente"
        Me.colNombrecliente.ReadOnly = True
        '
        'colFechaAdelanto
        '
        Me.colFechaAdelanto.DataPropertyName = "Fecha"
        Me.colFechaAdelanto.HeaderText = "Fecha"
        Me.colFechaAdelanto.Name = "colFechaAdelanto"
        Me.colFechaAdelanto.ReadOnly = True
        '
        'colHoraAdelanto
        '
        Me.colHoraAdelanto.DataPropertyName = "Hora"
        Me.colHoraAdelanto.HeaderText = "Hora"
        Me.colHoraAdelanto.Name = "colHoraAdelanto"
        Me.colHoraAdelanto.ReadOnly = True
        '
        'colMontoAdelanto
        '
        Me.colMontoAdelanto.DataPropertyName = "Monto"
        Me.colMontoAdelanto.HeaderText = "Monto"
        Me.colMontoAdelanto.Name = "colMontoAdelanto"
        Me.colMontoAdelanto.ReadOnly = True
        '
        'colSaldoAdelanto
        '
        Me.colSaldoAdelanto.DataPropertyName = "Saldo"
        Me.colSaldoAdelanto.HeaderText = "Saldo"
        Me.colSaldoAdelanto.Name = "colSaldoAdelanto"
        Me.colSaldoAdelanto.ReadOnly = True
        '
        'colEfectivoAdelanto
        '
        Me.colEfectivoAdelanto.DataPropertyName = "Efectivo"
        Me.colEfectivoAdelanto.HeaderText = "Efectivo"
        Me.colEfectivoAdelanto.Name = "colEfectivoAdelanto"
        Me.colEfectivoAdelanto.ReadOnly = True
        '
        'colChequeAdelanto
        '
        Me.colChequeAdelanto.DataPropertyName = "Cheque"
        Me.colChequeAdelanto.HeaderText = "Cheque"
        Me.colChequeAdelanto.Name = "colChequeAdelanto"
        Me.colChequeAdelanto.ReadOnly = True
        '
        'colTransferenciaAdelanto
        '
        Me.colTransferenciaAdelanto.DataPropertyName = "Transferencia"
        Me.colTransferenciaAdelanto.HeaderText = "Transferencia"
        Me.colTransferenciaAdelanto.Name = "colTransferenciaAdelanto"
        Me.colTransferenciaAdelanto.ReadOnly = True
        '
        'colCodcajaAdelanto
        '
        Me.colCodcajaAdelanto.DataPropertyName = "Codcaja"
        Me.colCodcajaAdelanto.HeaderText = "Codcaja"
        Me.colCodcajaAdelanto.Name = "colCodcajaAdelanto"
        Me.colCodcajaAdelanto.ReadOnly = True
        '
        'colUsuarioAdelanto
        '
        Me.colUsuarioAdelanto.DataPropertyName = "Usuario"
        Me.colUsuarioAdelanto.HeaderText = "Usuario"
        Me.colUsuarioAdelanto.Name = "colUsuarioAdelanto"
        Me.colUsuarioAdelanto.ReadOnly = True
        Me.colUsuarioAdelanto.Visible = False
        '
        'colMontoletrasAdelanto
        '
        Me.colMontoletrasAdelanto.DataPropertyName = "Monto_letras"
        Me.colMontoletrasAdelanto.HeaderText = "Monto_letras"
        Me.colMontoletrasAdelanto.Name = "colMontoletrasAdelanto"
        Me.colMontoletrasAdelanto.ReadOnly = True
        Me.colMontoletrasAdelanto.Visible = False
        '
        'colCodmonedaAdelanto
        '
        Me.colCodmonedaAdelanto.DataPropertyName = "Codmoneda"
        Me.colCodmonedaAdelanto.HeaderText = "Codmoneda"
        Me.colCodmonedaAdelanto.Name = "colCodmonedaAdelanto"
        Me.colCodmonedaAdelanto.ReadOnly = True
        Me.colCodmonedaAdelanto.Visible = False
        '
        'frmAdelantosReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(871, 498)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAdelantosReportes"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.AdelantosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.AdelantosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblSaldoDolares As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSaldoCordobas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents AdelantosBindingSource As BindingSource
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents radVerAdelanto As RadioButton
    Friend WithEvents btnVerReporte As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmbAdelantoCliente As ComboBox
    Friend WithEvents radAdelantoCliente As RadioButton
    Friend WithEvents AdelantosDataGridView As DataGridView
    Friend WithEvents colSaldocordobasAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colSaldodolaresAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colidsalidaAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colCodclienteAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents colNombrecliente As DataGridViewTextBoxColumn
    Friend WithEvents colFechaAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colHoraAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colMontoAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colSaldoAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colEfectivoAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colChequeAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colTransferenciaAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colCodcajaAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colUsuarioAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colMontoletrasAdelanto As DataGridViewTextBoxColumn
    Friend WithEvents colCodmonedaAdelanto As DataGridViewTextBoxColumn
End Class

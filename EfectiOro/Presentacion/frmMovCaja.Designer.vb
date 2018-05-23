<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovCaja
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnAbrirCaja = New Infragistics.Win.Misc.UltraButton()
        Me.btnCerrarCaja = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRubro = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReferencias = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnNuevo = New Infragistics.Win.Misc.UltraButton()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grupoTransacciones = New System.Windows.Forms.GroupBox()
        Me.radTransferencia = New System.Windows.Forms.RadioButton()
        Me.radCheque = New System.Windows.Forms.RadioButton()
        Me.radEfectivo = New System.Windows.Forms.RadioButton()
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton()
        Me.btnMovimientosDelDia = New Infragistics.Win.Misc.UltraButton()
        Me.Tool = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoTransacciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(594, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(569, 25)
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MOVIMIENTOS DE CAJA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblHora.Location = New System.Drawing.Point(217, 41)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(49, 19)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "(hora)"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFecha.Location = New System.Drawing.Point(321, 41)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(59, 19)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "(Fecha)"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAbrirCaja
        '
        Appearance1.BackColor = System.Drawing.Color.Gray
        Appearance1.ForeColor = System.Drawing.Color.White
        Me.btnAbrirCaja.Appearance = Appearance1
        Me.btnAbrirCaja.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaToolbarButton
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbrirCaja.HotTrackAppearance = Appearance2
        Me.btnAbrirCaja.Location = New System.Drawing.Point(426, 41)
        Me.btnAbrirCaja.Name = "btnAbrirCaja"
        Me.btnAbrirCaja.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirCaja.TabIndex = 4
        Me.btnAbrirCaja.Text = "Abrir caja"
        Me.Tool.SetToolTip(Me.btnAbrirCaja, "Abrir caja actual")
        Me.btnAbrirCaja.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCerrarCaja
        '
        Appearance3.BackColor = System.Drawing.Color.Gray
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.btnCerrarCaja.Appearance = Appearance3
        Me.btnCerrarCaja.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaToolbarButton
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrarCaja.HotTrackAppearance = Appearance4
        Me.btnCerrarCaja.Location = New System.Drawing.Point(507, 41)
        Me.btnCerrarCaja.Name = "btnCerrarCaja"
        Me.btnCerrarCaja.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarCaja.TabIndex = 5
        Me.btnCerrarCaja.Text = "Cerrar caja"
        Me.Tool.SetToolTip(Me.btnCerrarCaja, "Cerrar la caja actual")
        Me.btnCerrarCaja.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Location = New System.Drawing.Point(21, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 30)
        Me.Panel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(553, 30)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 28)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Fecha"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(444, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Saldo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(334, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 28)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Monto Extraido"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(224, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 28)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Monto Ingresado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(114, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 28)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Monto Inicial"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblSaldo, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSalida, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEntrada, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFecha, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInicial, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 116)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(553, 30)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'lblSaldo
        '
        Me.lblSaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSaldo.Location = New System.Drawing.Point(444, 1)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(105, 28)
        Me.lblSaldo.TabIndex = 4
        Me.lblSaldo.Text = "0.0"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalida
        '
        Me.lblSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSalida.Location = New System.Drawing.Point(334, 1)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(103, 28)
        Me.lblSalida.TabIndex = 3
        Me.lblSalida.Text = "0.0"
        Me.lblSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEntrada
        '
        Me.lblEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEntrada.Location = New System.Drawing.Point(224, 1)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(103, 28)
        Me.lblEntrada.TabIndex = 2
        Me.lblEntrada.Text = "0.0"
        Me.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFecha
        '
        Me.txtFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFecha.Enabled = False
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(4, 4)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(103, 20)
        Me.txtFecha.TabIndex = 0
        '
        'lblInicial
        '
        Me.lblInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInicial.Location = New System.Drawing.Point(114, 1)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(103, 28)
        Me.lblInicial.TabIndex = 1
        Me.lblInicial.Text = "0.0"
        Me.lblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cmbRubro)
        Me.Panel2.Controls.Add(Me.txtMonto)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtReferencias)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(21, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(553, 100)
        Me.Panel2.TabIndex = 8
        '
        'btnCancelar
        '
        Appearance5.Image = Global.EfectiOro.My.Resources.Resources.PAGE_REMOVE
        Me.btnCancelar.Appearance = Appearance5
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelar.HotTrackAppearance = Appearance6
        Me.btnCancelar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancelar.Location = New System.Drawing.Point(485, 53)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 10
        Me.Tool.SetToolTip(Me.btnCancelar, "Cancelar Movimiento de caja")
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.btnCancelar.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Concepto:"
        '
        'cmbRubro
        '
        Me.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRubro.Enabled = False
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(167, 64)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.Size = New System.Drawing.Size(295, 23)
        Me.cmbRubro.TabIndex = 4
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(167, 37)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(295, 21)
        Me.txtMonto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monto a Retirar/Depositar"
        '
        'txtReferencias
        '
        Me.txtReferencias.Enabled = False
        Me.txtReferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencias.Location = New System.Drawing.Point(167, 11)
        Me.txtReferencias.Name = "txtReferencias"
        Me.txtReferencias.Size = New System.Drawing.Size(295, 21)
        Me.txtReferencias.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Referencias:"
        '
        'btnGuardar
        '
        Appearance7.Image = Global.EfectiOro.My.Resources.Resources._7
        Me.btnGuardar.Appearance = Appearance7
        Me.btnGuardar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.HotTrackAppearance = Appearance8
        Me.btnGuardar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnGuardar.Location = New System.Drawing.Point(485, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 11
        Me.Tool.SetToolTip(Me.btnGuardar, "Guardar la transaccion")
        Me.btnGuardar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.btnGuardar.Visible = False
        '
        'btnNuevo
        '
        Appearance9.Image = Global.EfectiOro.My.Resources.Resources.ADD_PAGE
        Me.btnNuevo.Appearance = Appearance9
        Me.btnNuevo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNuevo.HotTrackAppearance = Appearance10
        Me.btnNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnNuevo.Location = New System.Drawing.Point(485, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.TabIndex = 9
        Me.Tool.SetToolTip(Me.btnNuevo, "Nuevo movmiento de caja")
        Me.btnNuevo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'grupoTransacciones
        '
        Me.grupoTransacciones.Controls.Add(Me.radTransferencia)
        Me.grupoTransacciones.Controls.Add(Me.radCheque)
        Me.grupoTransacciones.Controls.Add(Me.radEfectivo)
        Me.grupoTransacciones.Enabled = False
        Me.grupoTransacciones.Location = New System.Drawing.Point(21, 268)
        Me.grupoTransacciones.Name = "grupoTransacciones"
        Me.grupoTransacciones.Size = New System.Drawing.Size(345, 53)
        Me.grupoTransacciones.TabIndex = 9
        Me.grupoTransacciones.TabStop = False
        Me.grupoTransacciones.Text = "Establecer Tipo de transacción"
        '
        'radTransferencia
        '
        Me.radTransferencia.AutoSize = True
        Me.radTransferencia.Location = New System.Drawing.Point(229, 20)
        Me.radTransferencia.Name = "radTransferencia"
        Me.radTransferencia.Size = New System.Drawing.Size(90, 17)
        Me.radTransferencia.TabIndex = 2
        Me.radTransferencia.Text = "Transferencia"
        Me.radTransferencia.UseVisualStyleBackColor = True
        '
        'radCheque
        '
        Me.radCheque.AutoSize = True
        Me.radCheque.Location = New System.Drawing.Point(128, 20)
        Me.radCheque.Name = "radCheque"
        Me.radCheque.Size = New System.Drawing.Size(62, 17)
        Me.radCheque.TabIndex = 1
        Me.radCheque.Text = "Cheque"
        Me.radCheque.UseVisualStyleBackColor = True
        '
        'radEfectivo
        '
        Me.radEfectivo.AutoSize = True
        Me.radEfectivo.Checked = True
        Me.radEfectivo.Location = New System.Drawing.Point(25, 20)
        Me.radEfectivo.Name = "radEfectivo"
        Me.radEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.radEfectivo.TabIndex = 0
        Me.radEfectivo.TabStop = True
        Me.radEfectivo.Text = "Efectivo"
        Me.radEfectivo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Appearance13.Image = Global.EfectiOro.My.Resources.Resources.HOME
        Me.btnSalir.Appearance = Appearance13
        Me.btnSalir.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.HotTrackAppearance = Appearance14
        Me.btnSalir.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSalir.Location = New System.Drawing.Point(507, 282)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 39)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.Tool.SetToolTip(Me.btnSalir, "Salir del formulario")
        Me.btnSalir.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnMovimientosDelDia
        '
        Appearance11.Image = Global.EfectiOro.My.Resources.Resources.printer
        Me.btnMovimientosDelDia.Appearance = Appearance11
        Me.btnMovimientosDelDia.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnMovimientosDelDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMovimientosDelDia.HotTrackAppearance = Appearance12
        Me.btnMovimientosDelDia.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMovimientosDelDia.Location = New System.Drawing.Point(392, 282)
        Me.btnMovimientosDelDia.Name = "btnMovimientosDelDia"
        Me.btnMovimientosDelDia.Size = New System.Drawing.Size(109, 39)
        Me.btnMovimientosDelDia.TabIndex = 13
        Me.btnMovimientosDelDia.Text = "Movimientos del Dia"
        Me.Tool.SetToolTip(Me.btnMovimientosDelDia, "Ver movimientos del dia")
        Me.btnMovimientosDelDia.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Tool
        '
        Me.Tool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tool.ToolTipTitle = "Movimientos"
        '
        'frmMovCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(594, 333)
        Me.Controls.Add(Me.btnMovimientosDelDia)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.grupoTransacciones)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCerrarCaja)
        Me.Controls.Add(Me.btnAbrirCaja)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMovCaja"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblHora, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.btnAbrirCaja, 0)
        Me.Controls.SetChildIndex(Me.btnCerrarCaja, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.grupoTransacciones, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnMovimientosDelDia, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoTransacciones.ResumeLayout(False)
        Me.grupoTransacciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnAbrirCaja As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCerrarCaja As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblSalida As System.Windows.Forms.Label
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents lblInicial As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReferencias As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnNuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grupoTransacciones As System.Windows.Forms.GroupBox
    Friend WithEvents radTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents radCheque As System.Windows.Forms.RadioButton
    Friend WithEvents radEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMovimientosDelDia As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Tool As System.Windows.Forms.ToolTip

End Class

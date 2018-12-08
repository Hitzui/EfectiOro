<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaestroCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaestroCaja))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnAbrirCaja = New System.Windows.Forms.Button()
        Me.btnCerrarCaja = New System.Windows.Forms.Button()
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
        Me.lblVermonto = New System.Windows.Forms.Label()
        Me.chkImprimir = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRubro = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReferencias = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grupoTransacciones = New System.Windows.Forms.GroupBox()
        Me.radTransferencia = New System.Windows.Forms.RadioButton()
        Me.radCheque = New System.Windows.Forms.RadioButton()
        Me.radEfectivo = New System.Windows.Forms.RadioButton()
        Me.Tool = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReimpimirPanel = New System.Windows.Forms.Button()
        Me.btnMovimientosDelDia = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New Infragistics.Win.Misc.UltraButton()
        Me.panReimprimir = New System.Windows.Forms.Panel()
        Me.btnReimprimir = New Infragistics.Win.Misc.UltraButton()
        Me.dgvReimprimir = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoTransacciones.SuspendLayout()
        Me.panReimprimir.SuspendLayout()
        CType(Me.dgvReimprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(643, 25)
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
        Me.btnAbrirCaja.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAbrirCaja.FlatAppearance.BorderSize = 0
        Me.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirCaja.ForeColor = System.Drawing.Color.White
        Me.btnAbrirCaja.Location = New System.Drawing.Point(470, 41)
        Me.btnAbrirCaja.Name = "btnAbrirCaja"
        Me.btnAbrirCaja.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirCaja.TabIndex = 4
        Me.btnAbrirCaja.Text = "Abrir caja"
        Me.Tool.SetToolTip(Me.btnAbrirCaja, "Abrir caja actual")
        Me.btnAbrirCaja.UseVisualStyleBackColor = False
        '
        'btnCerrarCaja
        '
        Me.btnCerrarCaja.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCerrarCaja.FlatAppearance.BorderSize = 0
        Me.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarCaja.ForeColor = System.Drawing.Color.White
        Me.btnCerrarCaja.Location = New System.Drawing.Point(551, 41)
        Me.btnCerrarCaja.Name = "btnCerrarCaja"
        Me.btnCerrarCaja.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarCaja.TabIndex = 5
        Me.btnCerrarCaja.Text = "Cerrar caja"
        Me.Tool.SetToolTip(Me.btnCerrarCaja, "Cerrar la caja actual")
        Me.btnCerrarCaja.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Location = New System.Drawing.Point(21, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 30)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(609, 30)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 28)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Fecha"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(488, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Saldo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(367, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 28)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Monto Extraido"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(246, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 28)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Monto Ingresado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(125, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 28)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 112)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(609, 30)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'lblSaldo
        '
        Me.lblSaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSaldo.Location = New System.Drawing.Point(488, 1)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(117, 28)
        Me.lblSaldo.TabIndex = 4
        Me.lblSaldo.Text = "0.0"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalida
        '
        Me.lblSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSalida.Location = New System.Drawing.Point(367, 1)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(114, 28)
        Me.lblSalida.TabIndex = 3
        Me.lblSalida.Text = "0.0"
        Me.lblSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEntrada
        '
        Me.lblEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEntrada.Location = New System.Drawing.Point(246, 1)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(114, 28)
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
        Me.txtFecha.Size = New System.Drawing.Size(114, 20)
        Me.txtFecha.TabIndex = 0
        '
        'lblInicial
        '
        Me.lblInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInicial.Location = New System.Drawing.Point(125, 1)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(114, 28)
        Me.lblInicial.TabIndex = 1
        Me.lblInicial.Text = "0.0"
        Me.lblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblVermonto)
        Me.Panel2.Controls.Add(Me.chkImprimir)
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
        Me.Panel2.Location = New System.Drawing.Point(21, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(609, 122)
        Me.Panel2.TabIndex = 8
        '
        'lblVermonto
        '
        Me.lblVermonto.AutoSize = True
        Me.lblVermonto.Location = New System.Drawing.Point(245, 97)
        Me.lblVermonto.Name = "lblVermonto"
        Me.lblVermonto.Size = New System.Drawing.Size(148, 15)
        Me.lblVermonto.TabIndex = 13
        Me.lblVermonto.Text = "Monto a Retirar/Depositar"
        Me.lblVermonto.Visible = False
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoSize = True
        Me.chkImprimir.Location = New System.Drawing.Point(73, 93)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(72, 19)
        Me.chkImprimir.TabIndex = 12
        Me.chkImprimir.Text = "Imprimir"
        Me.chkImprimir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelar.ImageIndex = 1
        Me.btnCancelar.ImageList = Me.ImageList1
        Me.btnCancelar.Location = New System.Drawing.Point(546, 64)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 10
        Me.Tool.SetToolTip(Me.btnCancelar, "Cancelar Movimiento de caja")
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "7.PNG")
        Me.ImageList1.Images.SetKeyName(1, "PAGE_REMOVE.PNG")
        Me.ImageList1.Images.SetKeyName(2, "ADD_PAGE.PNG")
        Me.ImageList1.Images.SetKeyName(3, "print_view_48.png")
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
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.ImageIndex = 0
        Me.btnGuardar.ImageList = Me.ImageList1
        Me.btnGuardar.Location = New System.Drawing.Point(546, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 11
        Me.Tool.SetToolTip(Me.btnGuardar, "Guardar la transaccion")
        Me.btnGuardar.UseVisualStyleBackColor = False
        Me.btnGuardar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNuevo.ImageIndex = 2
        Me.btnNuevo.ImageList = Me.ImageList1
        Me.btnNuevo.Location = New System.Drawing.Point(546, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.TabIndex = 9
        Me.Tool.SetToolTip(Me.btnNuevo, "Nuevo movmiento de caja")
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.grupoTransacciones.Location = New System.Drawing.Point(16, 276)
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
        'Tool
        '
        Me.Tool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tool.ToolTipTitle = "Movimientos"
        '
        'btnReimpimirPanel
        '
        Me.btnReimpimirPanel.BackColor = System.Drawing.Color.White
        Me.btnReimpimirPanel.FlatAppearance.BorderSize = 0
        Me.btnReimpimirPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReimpimirPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReimpimirPanel.ForeColor = System.Drawing.Color.Black
        Me.btnReimpimirPanel.Image = Global.EfectiOro.My.Resources.Resources.print_view_48
        Me.btnReimpimirPanel.Location = New System.Drawing.Point(379, 278)
        Me.btnReimpimirPanel.Name = "btnReimpimirPanel"
        Me.btnReimpimirPanel.Size = New System.Drawing.Size(73, 51)
        Me.btnReimpimirPanel.TabIndex = 14
        Me.btnReimpimirPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Tool.SetToolTip(Me.btnReimpimirPanel, "Reimprimir recibos")
        Me.btnReimpimirPanel.UseVisualStyleBackColor = False
        '
        'btnMovimientosDelDia
        '
        Me.btnMovimientosDelDia.BackColor = System.Drawing.Color.White
        Me.btnMovimientosDelDia.FlatAppearance.BorderSize = 0
        Me.btnMovimientosDelDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovimientosDelDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimientosDelDia.ForeColor = System.Drawing.Color.Black
        Me.btnMovimientosDelDia.Image = Global.EfectiOro.My.Resources.Resources.printer
        Me.btnMovimientosDelDia.Location = New System.Drawing.Point(467, 278)
        Me.btnMovimientosDelDia.Name = "btnMovimientosDelDia"
        Me.btnMovimientosDelDia.Size = New System.Drawing.Size(73, 51)
        Me.btnMovimientosDelDia.TabIndex = 13
        Me.btnMovimientosDelDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Tool.SetToolTip(Me.btnMovimientosDelDia, "Ver movimientos del dia")
        Me.btnMovimientosDelDia.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(555, 278)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 51)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.Tool.SetToolTip(Me.btnSalir, "Salir del formulario")
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources._23
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnVolver.Appearance = Appearance1
        Me.btnVolver.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnVolver.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnVolver.Location = New System.Drawing.Point(543, 265)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 45)
        Me.btnVolver.TabIndex = 2
        Me.Tool.SetToolTip(Me.btnVolver, "Volver")
        Me.btnVolver.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'panReimprimir
        '
        Me.panReimprimir.Controls.Add(Me.btnVolver)
        Me.panReimprimir.Controls.Add(Me.btnReimprimir)
        Me.panReimprimir.Controls.Add(Me.dgvReimprimir)
        Me.panReimprimir.Location = New System.Drawing.Point(0, 28)
        Me.panReimprimir.Name = "panReimprimir"
        Me.panReimprimir.Size = New System.Drawing.Size(643, 10)
        Me.panReimprimir.TabIndex = 15
        '
        'btnReimprimir
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.print_view_48
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnReimprimir.Appearance = Appearance2
        Me.btnReimprimir.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnReimprimir.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnReimprimir.Location = New System.Drawing.Point(427, 265)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(75, 45)
        Me.btnReimprimir.TabIndex = 1
        Me.btnReimprimir.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'dgvReimprimir
        '
        Me.dgvReimprimir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReimprimir.BackgroundColor = System.Drawing.Color.White
        Me.dgvReimprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReimprimir.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvReimprimir.Location = New System.Drawing.Point(0, 0)
        Me.dgvReimprimir.Name = "dgvReimprimir"
        Me.dgvReimprimir.Size = New System.Drawing.Size(643, 259)
        Me.dgvReimprimir.TabIndex = 0
        '
        'frmMaestroCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(643, 343)
        Me.Controls.Add(Me.panReimprimir)
        Me.Controls.Add(Me.btnReimpimirPanel)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaestroCaja"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblHora, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.btnAbrirCaja, 0)
        Me.Controls.SetChildIndex(Me.btnCerrarCaja, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.grupoTransacciones, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnMovimientosDelDia, 0)
        Me.Controls.SetChildIndex(Me.btnReimpimirPanel, 0)
        Me.Controls.SetChildIndex(Me.panReimprimir, 0)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoTransacciones.ResumeLayout(False)
        Me.grupoTransacciones.PerformLayout()
        Me.panReimprimir.ResumeLayout(False)
        CType(Me.dgvReimprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnAbrirCaja As Button
    Friend WithEvents btnCerrarCaja As Button
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
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents grupoTransacciones As System.Windows.Forms.GroupBox
    Friend WithEvents radTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents radCheque As System.Windows.Forms.RadioButton
    Friend WithEvents radEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMovimientosDelDia As Button
    Friend WithEvents Tool As System.Windows.Forms.ToolTip
    Friend WithEvents chkImprimir As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblVermonto As Label
    Friend WithEvents btnReimpimirPanel As System.Windows.Forms.Button
    Friend WithEvents panReimprimir As System.Windows.Forms.Panel
    Friend WithEvents dgvReimprimir As System.Windows.Forms.DataGridView
    Private WithEvents btnVolver As Infragistics.Win.Misc.UltraButton
    Private WithEvents btnReimprimir As Infragistics.Win.Misc.UltraButton
End Class

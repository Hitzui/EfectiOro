<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDescargues
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Compras", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codagencia")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numcompra")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codcliente")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codcaja")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codmoneda")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codestado")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Forma_pago")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dgnumdes")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Efectivo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cheque")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Transferencia")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Por_cobrar")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Por_pagar")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Adelantos")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo_por_pagar")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo_adelanto")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo_adelanto_Dolares")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("colSeleccionar", 0)
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition(-1) {}, New Infragistics.Win.Appearance(-1) {})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescargues))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTab1 = New System.Windows.Forms.TabControl()
        Me.pageGenerar = New System.Windows.Forms.TabPage()
        Me.cmbFiltrarSucursal = New System.Windows.Forms.ComboBox()
        Me.chkFiltrar = New System.Windows.Forms.CheckBox()
        Me.chekTodos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.dgvGenerar = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblImportetotal = New System.Windows.Forms.Label()
        Me.lblPesototal = New System.Windows.Forms.Label()
        Me.lblCantidadcompras = New System.Windows.Forms.Label()
        Me.btnGuardarlote = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraTab2 = New System.Windows.Forms.TabControl()
        Me.pageVerlote = New System.Windows.Forms.TabPage()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.txtNumdescargue = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnBuscar_Numdescargue = New Infragistics.Win.Misc.UltraButton()
        Me.panelDetalledescargue = New System.Windows.Forms.Panel()
        Me.btnVolver = New Infragistics.Win.Misc.UltraButton()
        Me.ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgnumdes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVerlote = New System.Windows.Forms.Button()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvVerlotes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumdescargue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltraTab3 = New System.Windows.Forms.TabControl()
        Me.pageComprasdescargadas = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblImportecompras = New System.Windows.Forms.Label()
        Me.lblPesocompras = New System.Windows.Forms.Label()
        Me.lblCantcompras = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvVercompras = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPesocompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalcompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compraSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnVercompras = New System.Windows.Forms.Button()
        Me.txtHastacompra = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesdecompra = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabCentral = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DescarguesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pageGenerar.SuspendLayout()
        CType(Me.chekTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGenerar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pageVerlote.SuspendLayout()
        CType(Me.txtNumdescargue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetalledescargue.SuspendLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVerlotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageComprasdescargadas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvVercompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compraSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCentral.SuspendLayout()
        CType(Me.DescarguesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(805, 25)
        '
        'UltraTab1
        '
        Me.UltraTab1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTab1.Name = "UltraTab1"
        Me.UltraTab1.SelectedIndex = 0
        Me.UltraTab1.Size = New System.Drawing.Size(200, 100)
        Me.UltraTab1.TabIndex = 0
        Me.UltraTab1.Text = "Generar lote"
        '
        'pageGenerar
        '
        Me.pageGenerar.AutoScroll = True
        Me.pageGenerar.BackColor = System.Drawing.Color.White
        Me.pageGenerar.Controls.Add(Me.cmbFiltrarSucursal)
        Me.pageGenerar.Controls.Add(Me.chkFiltrar)
        Me.pageGenerar.Controls.Add(Me.chekTodos)
        Me.pageGenerar.Controls.Add(Me.dgvGenerar)
        Me.pageGenerar.Controls.Add(Me.GroupBox1)
        Me.pageGenerar.Controls.Add(Me.btnGenerar)
        Me.pageGenerar.Controls.Add(Me.txtFechaHasta)
        Me.pageGenerar.Controls.Add(Me.Label1)
        Me.pageGenerar.Location = New System.Drawing.Point(4, 22)
        Me.pageGenerar.Name = "pageGenerar"
        Me.pageGenerar.Size = New System.Drawing.Size(797, 456)
        Me.pageGenerar.TabIndex = 0
        Me.pageGenerar.Text = "Generar lote"
        '
        'cmbFiltrarSucursal
        '
        Me.cmbFiltrarSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltrarSucursal.Enabled = False
        Me.cmbFiltrarSucursal.FormattingEnabled = True
        Me.cmbFiltrarSucursal.Location = New System.Drawing.Point(131, 353)
        Me.cmbFiltrarSucursal.Name = "cmbFiltrarSucursal"
        Me.cmbFiltrarSucursal.Size = New System.Drawing.Size(145, 21)
        Me.cmbFiltrarSucursal.TabIndex = 12
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(11, 355)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(114, 17)
        Me.chkFiltrar.TabIndex = 11
        Me.chkFiltrar.Text = "Filtrar por sucursal:"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'chekTodos
        '
        Me.chekTodos.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.chekTodos.Location = New System.Drawing.Point(453, 20)
        Me.chekTodos.Name = "chekTodos"
        Me.chekTodos.Size = New System.Drawing.Size(120, 20)
        Me.chekTodos.TabIndex = 10
        Me.chekTodos.Text = "Seleccionar todos"
        Me.chekTodos.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.chekTodos.Visible = False
        '
        'dgvGenerar
        '
        Me.dgvGenerar.DataSource = Me.ComprasBindingSource
        Appearance1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Appearance1.BorderColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvGenerar.DisplayLayout.Appearance = Appearance1
        Me.dgvGenerar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.Caption = "Sucursal"
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Width = 74
        UltraGridColumn2.Header.Caption = "No compra"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 99
        UltraGridColumn3.Header.Caption = "Cod cliente"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Caja"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 83
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Width = 153
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Width = 89
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 17
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 18
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 19
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn20.Hidden = True
        UltraGridColumn22.Header.Caption = "Saldo Cordobas"
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.Width = 70
        UltraGridColumn23.Header.Caption = "Saldo Dolares"
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.Width = 128
        UltraGridColumn21.DataType = GetType(Boolean)
        UltraGridColumn21.DefaultCellValue = False
        UltraGridColumn21.Header.Caption = "Seleccionar"
        UltraGridColumn21.Header.VisiblePosition = 0
        ConditionValueAppearance1.ApplyAllMatchingConditions = False
        UltraGridColumn21.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn21.Width = 58
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn22, UltraGridColumn23, UltraGridColumn21})
        Me.dgvGenerar.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgvGenerar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.dgvGenerar.DisplayLayout.DefaultSelectedBackColor = System.Drawing.SystemColors.HotTrack
        Me.dgvGenerar.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.dgvGenerar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.dgvGenerar.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.dgvGenerar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        Me.dgvGenerar.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree
        Me.dgvGenerar.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.dgvGenerar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.dgvGenerar.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.dgvGenerar.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.dgvGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvGenerar.Location = New System.Drawing.Point(11, 58)
        Me.dgvGenerar.Name = "dgvGenerar"
        Me.dgvGenerar.Size = New System.Drawing.Size(775, 281)
        Me.dgvGenerar.TabIndex = 8
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataSource = GetType(EfectiOro.Database.Compras)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblImportetotal)
        Me.GroupBox1.Controls.Add(Me.lblPesototal)
        Me.GroupBox1.Controls.Add(Me.lblCantidadcompras)
        Me.GroupBox1.Controls.Add(Me.btnGuardarlote)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 378)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 66)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblImportetotal
        '
        Me.lblImportetotal.AutoSize = True
        Me.lblImportetotal.Location = New System.Drawing.Point(540, 29)
        Me.lblImportetotal.Name = "lblImportetotal"
        Me.lblImportetotal.Size = New System.Drawing.Size(22, 15)
        Me.lblImportetotal.TabIndex = 7
        Me.lblImportetotal.Text = "(0)"
        '
        'lblPesototal
        '
        Me.lblPesototal.AutoSize = True
        Me.lblPesototal.Location = New System.Drawing.Point(338, 29)
        Me.lblPesototal.Name = "lblPesototal"
        Me.lblPesototal.Size = New System.Drawing.Size(22, 15)
        Me.lblPesototal.TabIndex = 6
        Me.lblPesototal.Text = "(0)"
        '
        'lblCantidadcompras
        '
        Me.lblCantidadcompras.AutoSize = True
        Me.lblCantidadcompras.Location = New System.Drawing.Point(168, 29)
        Me.lblCantidadcompras.Name = "lblCantidadcompras"
        Me.lblCantidadcompras.Size = New System.Drawing.Size(22, 15)
        Me.lblCantidadcompras.TabIndex = 5
        Me.lblCantidadcompras.Text = "(0)"
        '
        'btnGuardarlote
        '
        Me.btnGuardarlote.FlatAppearance.BorderSize = 0
        Me.btnGuardarlote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarlote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarlote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarlote.ImageIndex = 2
        Me.btnGuardarlote.ImageList = Me.ImageList1
        Me.btnGuardarlote.Location = New System.Drawing.Point(679, 22)
        Me.btnGuardarlote.Name = "btnGuardarlote"
        Me.btnGuardarlote.Size = New System.Drawing.Size(96, 31)
        Me.btnGuardarlote.TabIndex = 4
        Me.btnGuardarlote.Text = "Guardar "
        Me.btnGuardarlote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnGuardarlote, "Guardar lote generado")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "23.PNG")
        Me.ImageList1.Images.SetKeyName(1, "28.PNG")
        Me.ImageList1.Images.SetKeyName(2, "filesave.png")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(456, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Importe total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(268, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peso total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(34, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad de compras:"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.LightBlue
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Location = New System.Drawing.Point(668, 19)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(118, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar Lote"
        Me.ToolTip1.SetToolTip(Me.btnGenerar, "Generar lote hasta la fecha indicada")
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaHasta.Location = New System.Drawing.Point(187, 20)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(156, 20)
        Me.txtFechaHasta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(63, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generar hasta la fecha:"
        '
        'UltraTab2
        '
        Me.UltraTab2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTab2.Name = "UltraTab2"
        Me.UltraTab2.SelectedIndex = 0
        Me.UltraTab2.Size = New System.Drawing.Size(200, 100)
        Me.UltraTab2.TabIndex = 0
        Me.UltraTab2.Text = "Ver lotes descargados"
        '
        'pageVerlote
        '
        Me.pageVerlote.BackColor = System.Drawing.Color.White
        Me.pageVerlote.Controls.Add(Me.UltraButton1)
        Me.pageVerlote.Controls.Add(Me.txtNumdescargue)
        Me.pageVerlote.Controls.Add(Me.btnBuscar_Numdescargue)
        Me.pageVerlote.Controls.Add(Me.panelDetalledescargue)
        Me.pageVerlote.Controls.Add(Me.btnVerlote)
        Me.pageVerlote.Controls.Add(Me.txtHasta)
        Me.pageVerlote.Controls.Add(Me.Label6)
        Me.pageVerlote.Controls.Add(Me.txtDesde)
        Me.pageVerlote.Controls.Add(Me.Label5)
        Me.pageVerlote.Controls.Add(Me.dgvVerlotes)
        Me.pageVerlote.Location = New System.Drawing.Point(4, 22)
        Me.pageVerlote.Name = "pageVerlote"
        Me.pageVerlote.Size = New System.Drawing.Size(797, 456)
        Me.pageVerlote.TabIndex = 0
        Me.pageVerlote.Text = "Ver lotes"
        '
        'UltraButton1
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources.analysis
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.UltraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.ImageSize = New System.Drawing.Size(32, 32)
        Me.UltraButton1.Location = New System.Drawing.Point(736, 404)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(53, 46)
        Me.UltraButton1.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.UltraButton1, "Ver descargue")
        Me.UltraButton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtNumdescargue
        '
        Me.txtNumdescargue.Location = New System.Drawing.Point(51, 416)
        Me.txtNumdescargue.Name = "txtNumdescargue"
        Me.txtNumdescargue.NullText = "Buscar por numero de descargue"
        Appearance3.ForeColor = System.Drawing.Color.Silver
        Me.txtNumdescargue.NullTextAppearance = Appearance3
        Me.txtNumdescargue.Size = New System.Drawing.Size(151, 21)
        Me.txtNumdescargue.TabIndex = 9
        '
        'btnBuscar_Numdescargue
        '
        Me.btnBuscar_Numdescargue.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnBuscar_Numdescargue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar_Numdescargue.Location = New System.Drawing.Point(208, 414)
        Me.btnBuscar_Numdescargue.Name = "btnBuscar_Numdescargue"
        Me.btnBuscar_Numdescargue.Size = New System.Drawing.Size(126, 23)
        Me.btnBuscar_Numdescargue.TabIndex = 8
        Me.btnBuscar_Numdescargue.Text = "Buscar descargue"
        Me.btnBuscar_Numdescargue.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'panelDetalledescargue
        '
        Me.panelDetalledescargue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalledescargue.Controls.Add(Me.btnVolver)
        Me.panelDetalledescargue.Controls.Add(Me.ComprasDataGridView)
        Me.panelDetalledescargue.Controls.Add(Me.lblLote)
        Me.panelDetalledescargue.Controls.Add(Me.Label7)
        Me.panelDetalledescargue.Location = New System.Drawing.Point(11, 61)
        Me.panelDetalledescargue.Name = "panelDetalledescargue"
        Me.panelDetalledescargue.Size = New System.Drawing.Size(781, 337)
        Me.panelDetalledescargue.TabIndex = 7
        Me.panelDetalledescargue.Visible = False
        '
        'btnVolver
        '
        Appearance4.Image = Global.EfectiOro.My.Resources.Resources._23
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnVolver.Appearance = Appearance4
        Me.btnVolver.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnVolver.ImageSize = New System.Drawing.Size(35, 25)
        Me.btnVolver.Location = New System.Drawing.Point(649, 296)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(69, 36)
        Me.btnVolver.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnVolver, "Volver a la lista")
        Me.btnVolver.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ComprasDataGridView
        '
        Me.ComprasDataGridView.AllowUserToAddRows = False
        Me.ComprasDataGridView.AllowUserToDeleteRows = False
        Me.ComprasDataGridView.AutoGenerateColumns = False
        Me.ComprasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ComprasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.Dgnumdes, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.ComprasDataGridView.DataSource = Me.ComprasBindingSource
        Me.ComprasDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComprasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ComprasDataGridView.Name = "ComprasDataGridView"
        Me.ComprasDataGridView.ReadOnly = True
        Me.ComprasDataGridView.Size = New System.Drawing.Size(779, 290)
        Me.ComprasDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Codagencia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codagencia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 89
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Numcompra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Numero de compra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 112
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Codcliente"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Codigo cliente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 91
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Codcaja"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Caja"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 53
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Peso"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 56
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Codmoneda"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Codmoneda"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 89
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 56
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 62
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Codestado"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Codestado"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 83
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 68
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 55
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Forma_pago"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Forma_pago"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 91
        '
        'Dgnumdes
        '
        Me.Dgnumdes.DataPropertyName = "Dgnumdes"
        Me.Dgnumdes.HeaderText = "Numero descargue"
        Me.Dgnumdes.Name = "Dgnumdes"
        Me.Dgnumdes.ReadOnly = True
        Me.Dgnumdes.Width = 112
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Efectivo"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Efectivo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 71
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Cheque"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Cheque"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 69
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Transferencia"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Transferencia"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 97
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Por_cobrar"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Por_cobrar"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        Me.DataGridViewTextBoxColumn26.Width = 84
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Por_pagar"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Por_pagar"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        Me.DataGridViewTextBoxColumn27.Width = 81
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Adelantos"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Adelantos"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 79
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(166, 309)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(34, 13)
        Me.lblLote.TabIndex = 2
        Me.lblLote.Text = "(Lote)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Número de lote descargado:"
        '
        'btnVerlote
        '
        Me.btnVerlote.BackColor = System.Drawing.Color.LightBlue
        Me.btnVerlote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerlote.Location = New System.Drawing.Point(674, 23)
        Me.btnVerlote.Name = "btnVerlote"
        Me.btnVerlote.Size = New System.Drawing.Size(118, 23)
        Me.btnVerlote.TabIndex = 6
        Me.btnVerlote.Text = "Ver lotes"
        Me.ToolTip1.SetToolTip(Me.btnVerlote, "Ver lotes descargados en el rango de fechas")
        Me.btnVerlote.UseVisualStyleBackColor = False
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(334, 23)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(156, 20)
        Me.txtHasta.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(290, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(95, 22)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(156, 20)
        Me.txtDesde.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(48, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Desde:"
        '
        'dgvVerlotes
        '
        Me.dgvVerlotes.AllowUserToAddRows = False
        Me.dgvVerlotes.AllowUserToDeleteRows = False
        Me.dgvVerlotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVerlotes.BackgroundColor = System.Drawing.Color.White
        Me.dgvVerlotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVerlotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.colNumdescargue, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvVerlotes.Location = New System.Drawing.Point(11, 61)
        Me.dgvVerlotes.Name = "dgvVerlotes"
        Me.dgvVerlotes.ReadOnly = True
        Me.dgvVerlotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVerlotes.Size = New System.Drawing.Size(781, 337)
        Me.dgvVerlotes.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Dgcodage"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dgcodage"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dgcodcaj"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dgcodcaj"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Dgusuari"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dgusuari"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'colNumdescargue
        '
        Me.colNumdescargue.DataPropertyName = "Dgnumdes"
        Me.colNumdescargue.HeaderText = "Numero descargue"
        Me.colNumdescargue.Name = "colNumdescargue"
        Me.colNumdescargue.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Dgcancom"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cant/Compras"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Dgpesbrt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Peso total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Dgpesntt"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Peso total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Dgimptcom"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Dgfecdes"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha descargue"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Dgfecgen"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha generado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'UltraTab3
        '
        Me.UltraTab3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTab3.Name = "UltraTab3"
        Me.UltraTab3.SelectedIndex = 0
        Me.UltraTab3.Size = New System.Drawing.Size(200, 100)
        Me.UltraTab3.TabIndex = 0
        Me.UltraTab3.Text = "Ver compras descargadas"
        '
        'pageComprasdescargadas
        '
        Me.pageComprasdescargadas.BackColor = System.Drawing.Color.White
        Me.pageComprasdescargadas.Controls.Add(Me.GroupBox2)
        Me.pageComprasdescargadas.Controls.Add(Me.dgvVercompras)
        Me.pageComprasdescargadas.Controls.Add(Me.btnVercompras)
        Me.pageComprasdescargadas.Controls.Add(Me.txtHastacompra)
        Me.pageComprasdescargadas.Controls.Add(Me.Label8)
        Me.pageComprasdescargadas.Controls.Add(Me.txtDesdecompra)
        Me.pageComprasdescargadas.Controls.Add(Me.Label9)
        Me.pageComprasdescargadas.Location = New System.Drawing.Point(4, 22)
        Me.pageComprasdescargadas.Name = "pageComprasdescargadas"
        Me.pageComprasdescargadas.Size = New System.Drawing.Size(797, 456)
        Me.pageComprasdescargadas.TabIndex = 0
        Me.pageComprasdescargadas.Text = "Ver lotes de compras"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblImportecompras)
        Me.GroupBox2.Controls.Add(Me.lblPesocompras)
        Me.GroupBox2.Controls.Add(Me.lblCantcompras)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(781, 66)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'lblImportecompras
        '
        Me.lblImportecompras.AutoSize = True
        Me.lblImportecompras.Location = New System.Drawing.Point(540, 29)
        Me.lblImportecompras.Name = "lblImportecompras"
        Me.lblImportecompras.Size = New System.Drawing.Size(22, 15)
        Me.lblImportecompras.TabIndex = 7
        Me.lblImportecompras.Text = "(0)"
        '
        'lblPesocompras
        '
        Me.lblPesocompras.AutoSize = True
        Me.lblPesocompras.Location = New System.Drawing.Point(338, 29)
        Me.lblPesocompras.Name = "lblPesocompras"
        Me.lblPesocompras.Size = New System.Drawing.Size(22, 15)
        Me.lblPesocompras.TabIndex = 6
        Me.lblPesocompras.Text = "(0)"
        '
        'lblCantcompras
        '
        Me.lblCantcompras.AutoSize = True
        Me.lblCantcompras.Location = New System.Drawing.Point(168, 29)
        Me.lblCantcompras.Name = "lblCantcompras"
        Me.lblCantcompras.Size = New System.Drawing.Size(22, 15)
        Me.lblCantcompras.TabIndex = 5
        Me.lblCantcompras.Text = "(0)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(456, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Importe total:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(268, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Peso total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(34, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Cantidad de compras:"
        '
        'dgvVercompras
        '
        Me.dgvVercompras.AllowUserToAddRows = False
        Me.dgvVercompras.AllowUserToDeleteRows = False
        Me.dgvVercompras.AutoGenerateColumns = False
        Me.dgvVercompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVercompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dgvVercompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVercompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.colPesocompras, Me.DataGridViewTextBoxColumn34, Me.colTotalcompras, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47})
        Me.dgvVercompras.DataSource = Me.compraSource
        Me.dgvVercompras.Location = New System.Drawing.Point(11, 61)
        Me.dgvVercompras.Name = "dgvVercompras"
        Me.dgvVercompras.ReadOnly = True
        Me.dgvVercompras.Size = New System.Drawing.Size(781, 311)
        Me.dgvVercompras.TabIndex = 12
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Codagencia"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Codagencia"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        Me.DataGridViewTextBoxColumn29.Width = 89
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Numcompra"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Numero de compra"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 112
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Codcliente"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Codigo cliente"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 91
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Codcaja"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Caja"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 53
        '
        'colPesocompras
        '
        Me.colPesocompras.DataPropertyName = "Peso"
        Me.colPesocompras.HeaderText = "Peso"
        Me.colPesocompras.Name = "colPesocompras"
        Me.colPesocompras.ReadOnly = True
        Me.colPesocompras.Width = 56
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Codmoneda"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Codmoneda"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Visible = False
        Me.DataGridViewTextBoxColumn34.Width = 89
        '
        'colTotalcompras
        '
        Me.colTotalcompras.DataPropertyName = "Total"
        Me.colTotalcompras.HeaderText = "Total"
        Me.colTotalcompras.Name = "colTotalcompras"
        Me.colTotalcompras.ReadOnly = True
        Me.colTotalcompras.Width = 56
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 62
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Codestado"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Codestado"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Visible = False
        Me.DataGridViewTextBoxColumn37.Width = 83
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Visible = False
        Me.DataGridViewTextBoxColumn38.Width = 68
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Width = 55
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Forma_pago"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Forma_pago"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        Me.DataGridViewTextBoxColumn40.Width = 91
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Dgnumdes"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Numero descargue"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Width = 112
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Efectivo"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Efectivo"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Width = 71
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Cheque"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Cheque"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Width = 69
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "Transferencia"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Transferencia"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Width = 97
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "Por_cobrar"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Por_cobrar"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Visible = False
        Me.DataGridViewTextBoxColumn45.Width = 84
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "Por_pagar"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Por_pagar"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Visible = False
        Me.DataGridViewTextBoxColumn46.Width = 81
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Adelantos"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Adelantos"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Width = 79
        '
        'compraSource
        '
        Me.compraSource.DataSource = GetType(EfectiOro.Database.Compras)
        '
        'btnVercompras
        '
        Me.btnVercompras.BackColor = System.Drawing.Color.LightBlue
        Me.btnVercompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVercompras.Location = New System.Drawing.Point(648, 22)
        Me.btnVercompras.Name = "btnVercompras"
        Me.btnVercompras.Size = New System.Drawing.Size(144, 24)
        Me.btnVercompras.TabIndex = 11
        Me.btnVercompras.Text = "Ver lotes de compras"
        Me.ToolTip1.SetToolTip(Me.btnVercompras, "Ver lotes de compras descargados")
        Me.btnVercompras.UseVisualStyleBackColor = False
        '
        'txtHastacompra
        '
        Me.txtHastacompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHastacompra.Location = New System.Drawing.Point(334, 23)
        Me.txtHastacompra.Name = "txtHastacompra"
        Me.txtHastacompra.Size = New System.Drawing.Size(156, 20)
        Me.txtHastacompra.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(290, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Hasta:"
        '
        'txtDesdecompra
        '
        Me.txtDesdecompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesdecompra.Location = New System.Drawing.Point(95, 22)
        Me.txtDesdecompra.Name = "txtDesdecompra"
        Me.txtDesdecompra.Size = New System.Drawing.Size(156, 20)
        Me.txtDesdecompra.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(48, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Desde:"
        '
        'tabCentral
        '
        Me.tabCentral.Controls.Add(Me.pageGenerar)
        Me.tabCentral.Controls.Add(Me.pageVerlote)
        Me.tabCentral.Controls.Add(Me.pageComprasdescargadas)
        Me.tabCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCentral.Location = New System.Drawing.Point(0, 25)
        Me.tabCentral.Name = "tabCentral"
        Me.tabCentral.SelectedIndex = 0
        Me.tabCentral.Size = New System.Drawing.Size(805, 482)
        Me.tabCentral.TabIndex = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Descargue"
        '
        'DescarguesBindingSource
        '
        Me.DescarguesBindingSource.DataSource = GetType(EfectiOro.Database.Descargues)
        '
        'frmDescargues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(805, 507)
        Me.Controls.Add(Me.tabCentral)
        Me.Name = "frmDescargues"
        Me.Controls.SetChildIndex(Me.tabCentral, 0)
        Me.pageGenerar.ResumeLayout(False)
        Me.pageGenerar.PerformLayout()
        CType(Me.chekTodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGenerar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pageVerlote.ResumeLayout(False)
        Me.pageVerlote.PerformLayout()
        CType(Me.txtNumdescargue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetalledescargue.ResumeLayout(False)
        Me.panelDetalledescargue.PerformLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVerlotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageComprasdescargadas.ResumeLayout(False)
        Me.pageComprasdescargadas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvVercompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compraSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCentral.ResumeLayout(False)
        CType(Me.DescarguesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabCentral As TabControl
    Friend WithEvents pageGenerar As TabPage
    Friend WithEvents pageVerlote As TabPage
    Friend WithEvents pageComprasdescargadas As TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarlote As Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblImportetotal As System.Windows.Forms.Label
    Friend WithEvents lblPesototal As System.Windows.Forms.Label
    Friend WithEvents lblCantidadcompras As System.Windows.Forms.Label
    Friend WithEvents dgvVerlotes As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnVerlote As Button
    Friend WithEvents txtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DescarguesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents panelDetalledescargue As System.Windows.Forms.Panel
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumdescargue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvVercompras As System.Windows.Forms.DataGridView
    Friend WithEvents btnVercompras As Button
    Friend WithEvents txtHastacompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDesdecompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents compraSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblImportecompras As System.Windows.Forms.Label
    Friend WithEvents lblPesocompras As System.Windows.Forms.Label
    Friend WithEvents lblCantcompras As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPesocompras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalcompras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltraTab1 As TabControl
    Friend WithEvents UltraTab2 As TabControl
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents UltraTab3 As TabControl
    Friend WithEvents txtNumdescargue As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnBuscar_Numdescargue As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Dgnumdes As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Public WithEvents btnVolver As Infragistics.Win.Misc.UltraButton
    Public WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents dgvGenerar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chekTodos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmbFiltrarSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetaDescargue
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFechaGenerar = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCompra = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFiltrar = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDetacompra = New System.Windows.Forms.DataGridView()
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colDetanumcompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumdescargue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCantidadCompras = New System.Windows.Forms.Label()
        Me.lblTotales = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPesoTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetacompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(725, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(700, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFechaGenerar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtFechaGenerar
        '
        Me.txtFechaGenerar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaGenerar.Location = New System.Drawing.Point(101, 19)
        Me.txtFechaGenerar.Name = "txtFechaGenerar"
        Me.txtFechaGenerar.Size = New System.Drawing.Size(123, 20)
        Me.txtFechaGenerar.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnBuscar.Location = New System.Drawing.Point(230, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Compra:"
        '
        'dgvCompra
        '
        Me.dgvCompra.AllowUserToAddRows = False
        Me.dgvCompra.AllowUserToDeleteRows = False
        Me.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCompra.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompra.Location = New System.Drawing.Point(12, 92)
        Me.dgvCompra.Name = "dgvCompra"
        Me.dgvCompra.ReadOnly = True
        Me.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompra.Size = New System.Drawing.Size(688, 212)
        Me.dgvCompra.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtFiltrar)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 54)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filtrar compra por:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(114, 17)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.NullText = "Filtrar por numero de compra"
        Appearance1.ForeColor = System.Drawing.Color.Silver
        Me.txtFiltrar.NullTextAppearance = Appearance1
        Me.txtFiltrar.Size = New System.Drawing.Size(209, 21)
        Me.txtFiltrar.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 507)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cant. compras:"
        '
        'dgvDetacompra
        '
        Me.dgvDetacompra.AllowUserToAddRows = False
        Me.dgvDetacompra.AllowUserToDeleteRows = False
        Me.dgvDetacompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetacompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetacompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar, Me.colDetanumcompra, Me.colPeso, Me.colPrecio, Me.colImporte, Me.colLinea, Me.colNumdescargue})
        Me.dgvDetacompra.Location = New System.Drawing.Point(12, 310)
        Me.dgvDetacompra.Name = "dgvDetacompra"
        Me.dgvDetacompra.Size = New System.Drawing.Size(688, 169)
        Me.dgvDetacompra.TabIndex = 6
        '
        'colSeleccionar
        '
        Me.colSeleccionar.HeaderText = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        '
        'colDetanumcompra
        '
        Me.colDetanumcompra.HeaderText = "No Compra"
        Me.colDetanumcompra.Name = "colDetanumcompra"
        Me.colDetanumcompra.ReadOnly = True
        Me.colDetanumcompra.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDetanumcompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPeso
        '
        Me.colPeso.HeaderText = "Peso"
        Me.colPeso.Name = "colPeso"
        Me.colPeso.ReadOnly = True
        Me.colPeso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPeso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        Me.colPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colImporte
        '
        Me.colImporte.HeaderText = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.ReadOnly = True
        Me.colImporte.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colLinea
        '
        Me.colLinea.HeaderText = "Linea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.ReadOnly = True
        Me.colLinea.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colLinea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colNumdescargue
        '
        Me.colNumdescargue.HeaderText = "No Descargue"
        Me.colNumdescargue.Name = "colNumdescargue"
        '
        'lblCantidadCompras
        '
        Me.lblCantidadCompras.AutoSize = True
        Me.lblCantidadCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadCompras.Location = New System.Drawing.Point(121, 507)
        Me.lblCantidadCompras.Name = "lblCantidadCompras"
        Me.lblCantidadCompras.Size = New System.Drawing.Size(26, 17)
        Me.lblCantidadCompras.TabIndex = 7
        Me.lblCantidadCompras.Text = "(0)"
        '
        'lblTotales
        '
        Me.lblTotales.AutoSize = True
        Me.lblTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotales.Location = New System.Drawing.Point(270, 507)
        Me.lblTotales.Name = "lblTotales"
        Me.lblTotales.Size = New System.Drawing.Size(26, 17)
        Me.lblTotales.TabIndex = 9
        Me.lblTotales.Text = "(0)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(170, 507)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Suma totales:"
        '
        'lblPesoTotal
        '
        Me.lblPesoTotal.AutoSize = True
        Me.lblPesoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoTotal.Location = New System.Drawing.Point(454, 507)
        Me.lblPesoTotal.Name = "lblPesoTotal"
        Me.lblPesoTotal.Size = New System.Drawing.Size(26, 17)
        Me.lblPesoTotal.TabIndex = 11
        Me.lblPesoTotal.Text = "(0)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(373, 507)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Peso total:"
        '
        'btnGuardar
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources._7
        Me.btnGuardar.Appearance = Appearance2
        Me.btnGuardar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnGuardar.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnGuardar.Location = New System.Drawing.Point(617, 488)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(83, 36)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Generar descargue de las compras seleccionadas")
        Me.btnGuardar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frmDetaDescargue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(725, 533)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblPesoTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotales)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCantidadCompras)
        Me.Controls.Add(Me.dgvDetacompra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvCompra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetaDescargue"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.dgvCompra, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.dgvDetacompra, 0)
        Me.Controls.SetChildIndex(Me.lblCantidadCompras, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblTotales, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.lblPesoTotal, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetacompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCompra As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDetacompra As DataGridView
    Friend WithEvents txtFechaGenerar As DateTimePicker
    Friend WithEvents txtFiltrar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblCantidadCompras As Label
    Friend WithEvents lblTotales As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPesoTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents colSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents colDetanumcompra As DataGridViewTextBoxColumn
    Friend WithEvents colPeso As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents colImporte As DataGridViewTextBoxColumn
    Friend WithEvents colLinea As DataGridViewTextBoxColumn
    Friend WithEvents colNumdescargue As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoCambio
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
        Me.lblHora = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarExcel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtValorOro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTipo = New System.Windows.Forms.DataGridView()
        Me.TipoCambioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGrabarValorOro = New System.Windows.Forms.Button()
        Me.btnBuscarDato = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.BuscarArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoCambioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(533, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(508, 25)
        '
        'lblHora
        '
        Me.lblHora.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblHora.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(0, 512)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(533, 20)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Label1"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarExcel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 109)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Archivo de Excel"
        '
        'btnBuscarExcel
        '
        Me.btnBuscarExcel.AutoSize = True
        Me.btnBuscarExcel.FlatAppearance.BorderSize = 0
        Me.btnBuscarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarExcel.ForeColor = System.Drawing.Color.Navy
        Me.btnBuscarExcel.Location = New System.Drawing.Point(25, 34)
        Me.btnBuscarExcel.Name = "btnBuscarExcel"
        Me.btnBuscarExcel.Size = New System.Drawing.Size(135, 23)
        Me.btnBuscarExcel.TabIndex = 0
        Me.btnBuscarExcel.Text = "Buscar Archivo en Disco"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtValorOro)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFecha)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 109)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar Dato"
        '
        'txtValorOro
        '
        Me.txtValorOro.Location = New System.Drawing.Point(102, 49)
        Me.txtValorOro.Name = "txtValorOro"
        Me.txtValorOro.Size = New System.Drawing.Size(124, 20)
        Me.txtValorOro.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Valor del Oro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha del valor:"
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(102, 83)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(124, 20)
        Me.txtFecha.TabIndex = 4
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(102, 22)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(124, 20)
        Me.txtValor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valor del dolar:"
        '
        'dgvTipo
        '
        Me.dgvTipo.AllowUserToAddRows = False
        Me.dgvTipo.AllowUserToDeleteRows = False
        Me.dgvTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTipo.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipo.Location = New System.Drawing.Point(13, 147)
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.ReadOnly = True
        Me.dgvTipo.Size = New System.Drawing.Size(354, 362)
        Me.dgvTipo.TabIndex = 4
        '
        'TipoCambioBindingSource
        '
        Me.TipoCambioBindingSource.DataSource = GetType(EfectiOro.Database.TipoCambio)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGrabarValorOro)
        Me.GroupBox3.Controls.Add(Me.btnBuscarDato)
        Me.GroupBox3.Controls.Add(Me.btnRefrescar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnModificar)
        Me.GroupBox3.Controls.Add(Me.btnIngresar)
        Me.GroupBox3.Controls.Add(Me.btnGrabar)
        Me.GroupBox3.Location = New System.Drawing.Point(373, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 362)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'btnGrabarValorOro
        '
        Me.btnGrabarValorOro.BackColor = System.Drawing.SystemColors.Control
        Me.btnGrabarValorOro.Location = New System.Drawing.Point(20, 295)
        Me.btnGrabarValorOro.Name = "btnGrabarValorOro"
        Me.btnGrabarValorOro.Size = New System.Drawing.Size(115, 25)
        Me.btnGrabarValorOro.TabIndex = 7
        Me.btnGrabarValorOro.Text = "Grabar valor del oro"
        Me.btnGrabarValorOro.UseVisualStyleBackColor = False
        '
        'btnBuscarDato
        '
        Me.btnBuscarDato.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarDato.Location = New System.Drawing.Point(20, 254)
        Me.btnBuscarDato.Name = "btnBuscarDato"
        Me.btnBuscarDato.Size = New System.Drawing.Size(115, 25)
        Me.btnBuscarDato.TabIndex = 6
        Me.btnBuscarDato.Text = "Buscar dato"
        Me.btnBuscarDato.UseVisualStyleBackColor = False
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefrescar.Location = New System.Drawing.Point(20, 207)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(115, 25)
        Me.btnRefrescar.TabIndex = 5
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Location = New System.Drawing.Point(20, 160)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(115, 25)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar valor"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificar.Location = New System.Drawing.Point(20, 113)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 25)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar valor"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.Control
        Me.btnIngresar.Location = New System.Drawing.Point(20, 66)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(115, 25)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar dato"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGrabar.Location = New System.Drawing.Point(20, 19)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(115, 25)
        Me.btnGrabar.TabIndex = 1
        Me.btnGrabar.Text = "Grabar datos"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'BuscarArchivo
        '
        Me.BuscarArchivo.Filter = "Archivos de Excel|*.xlsx"
        Me.BuscarArchivo.Title = "Buscar Archivo de Excel"
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmTipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(533, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvTipo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblHora)
        Me.Name = "frmTipoCambio"
        Me.Controls.SetChildIndex(Me.lblHora, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.dgvTipo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoCambioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarExcel As Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtValor As TextBox
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TipoCambioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnBuscarDato As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents BuscarArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Tipocambio1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtValorOro As TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGrabarValorOro As Button

End Class

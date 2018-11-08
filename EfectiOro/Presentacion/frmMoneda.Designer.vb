<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMoneda
    Inherits EfectiOro.frmPersonalizado

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvMoneda = New System.Windows.Forms.DataGridView()
        Me.dgvCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSimbolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(526, 25)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvMoneda)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 419)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'dgvMoneda
        '
        Me.dgvMoneda.AutoGenerateColumns = False
        Me.dgvMoneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMoneda.BackgroundColor = System.Drawing.Color.White
        Me.dgvMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMoneda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCodigo, Me.dgvDescripcion, Me.dgvSimbolo, Me.dgvFecha})
        Me.dgvMoneda.DataSource = Me.MonedaBindingSource
        Me.dgvMoneda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMoneda.Location = New System.Drawing.Point(3, 16)
        Me.dgvMoneda.Name = "dgvMoneda"
        Me.dgvMoneda.Size = New System.Drawing.Size(520, 400)
        Me.dgvMoneda.TabIndex = 0
        '
        'dgvCodigo
        '
        Me.dgvCodigo.DataPropertyName = "Codmoneda"
        Me.dgvCodigo.HeaderText = "Codmoneda"
        Me.dgvCodigo.Name = "dgvCodigo"
        Me.dgvCodigo.ReadOnly = True
        Me.dgvCodigo.Visible = False
        '
        'dgvDescripcion
        '
        Me.dgvDescripcion.DataPropertyName = "Descripcion"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvDescripcion.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDescripcion.HeaderText = "Descripcion"
        Me.dgvDescripcion.Name = "dgvDescripcion"
        '
        'dgvSimbolo
        '
        Me.dgvSimbolo.DataPropertyName = "Simbolo"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvSimbolo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSimbolo.HeaderText = "Simbolo"
        Me.dgvSimbolo.Name = "dgvSimbolo"
        '
        'dgvFecha
        '
        Me.dgvFecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvFecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFecha.HeaderText = "Fecha"
        Me.dgvFecha.Name = "dgvFecha"
        '
        'MonedaBindingSource
        '
        Me.MonedaBindingSource.DataSource = GetType(EfectiOro.Database.Moneda)
        '
        'frmMoneda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(526, 444)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMoneda"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvMoneda As DataGridView
    Friend WithEvents MonedaBindingSource As BindingSource
    Friend WithEvents dgvCodigo As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgvSimbolo As DataGridViewTextBoxColumn
    Friend WithEvents dgvFecha As DataGridViewTextBoxColumn
End Class

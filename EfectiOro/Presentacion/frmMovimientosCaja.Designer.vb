<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientosCaja
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
        Dim CodrubroLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.btnRubros = New System.Windows.Forms.Button()
        Me.cmbRubro = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.MovcajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grupoDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        CodrubroLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        Me.grupoDatos.SuspendLayout()
        CType(Me.MovcajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalles.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(722, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(697, 25)
        '
        'CodrubroLabel
        '
        CodrubroLabel.AutoSize = True
        CodrubroLabel.Location = New System.Drawing.Point(35, 82)
        CodrubroLabel.Name = "CodrubroLabel"
        CodrubroLabel.Size = New System.Drawing.Size(53, 13)
        CodrubroLabel.TabIndex = 0
        CodrubroLabel.Text = "Codrubro:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(35, 25)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripcion:"
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.btnRubros)
        Me.grupoDatos.Controls.Add(CodrubroLabel)
        Me.grupoDatos.Controls.Add(Me.cmbRubro)
        Me.grupoDatos.Controls.Add(DescripcionLabel)
        Me.grupoDatos.Controls.Add(Me.txtDescripcion)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 31)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(324, 142)
        Me.grupoDatos.TabIndex = 1
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos"
        '
        'btnRubros
        '
        Me.btnRubros.Location = New System.Drawing.Point(231, 98)
        Me.btnRubros.Name = "btnRubros"
        Me.btnRubros.Size = New System.Drawing.Size(24, 23)
        Me.btnRubros.TabIndex = 4
        Me.btnRubros.Text = "..."
        Me.btnRubros.UseVisualStyleBackColor = True
        '
        'cmbRubro
        '
        Me.cmbRubro.DisplayMember = "Codrubro"
        Me.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRubro.FormattingEnabled = True
        Me.cmbRubro.Location = New System.Drawing.Point(38, 98)
        Me.cmbRubro.Name = "cmbRubro"
        Me.cmbRubro.Size = New System.Drawing.Size(186, 21)
        Me.cmbRubro.TabIndex = 1
        Me.cmbRubro.ValueMember = "Codrubro"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovcajaBindingSource, "Descripcion", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(38, 41)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(217, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'MovcajaBindingSource
        '
        Me.MovcajaBindingSource.DataSource = GetType(EfectiOro.Database.Movcaja)
        '
        'grupoDetalles
        '
        Me.grupoDetalles.Controls.Add(Me.dgvMovimientos)
        Me.grupoDetalles.Location = New System.Drawing.Point(342, 31)
        Me.grupoDetalles.Name = "grupoDetalles"
        Me.grupoDetalles.Size = New System.Drawing.Size(380, 224)
        Me.grupoDetalles.TabIndex = 2
        Me.grupoDetalles.TabStop = False
        Me.grupoDetalles.Text = "Detalles"
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AutoGenerateColumns = False
        Me.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvMovimientos.DataSource = Me.MovcajaBindingSource
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientos.Location = New System.Drawing.Point(3, 16)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.ReadOnly = True
        Me.dgvMovimientos.Size = New System.Drawing.Size(374, 205)
        Me.dgvMovimientos.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idmov"
        Me.DataGridViewTextBoxColumn1.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codrubro"
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rubro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(324, 76)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.EfectiOro.My.Resources.Resources._48
        Me.btnCancelar.Location = New System.Drawing.Point(252, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.btnCancelar.TabIndex = 16
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.EfectiOro.My.Resources.Resources._9
        Me.btnEliminar.Location = New System.Drawing.Point(196, 16)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(45, 45)
        Me.btnEliminar.TabIndex = 15
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = Global.EfectiOro.My.Resources.Resources._2
        Me.btnEditar.Location = New System.Drawing.Point(140, 16)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(45, 45)
        Me.btnEditar.TabIndex = 14
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.EfectiOro.My.Resources.Resources._7
        Me.btnGuardar.Location = New System.Drawing.Point(84, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(45, 45)
        Me.btnGuardar.TabIndex = 12
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.EfectiOro.My.Resources.Resources._8
        Me.btnNuevo.Location = New System.Drawing.Point(28, 16)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(45, 45)
        Me.btnNuevo.TabIndex = 13
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmMovimientosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(722, 267)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grupoDetalles)
        Me.Controls.Add(Me.grupoDatos)
        Me.Name = "frmMovimientosCaja"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.grupoDatos, 0)
        Me.Controls.SetChildIndex(Me.grupoDetalles, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.MovcajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalles.ResumeLayout(False)
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grupoDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents MovcajaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRubros As System.Windows.Forms.Button
    Friend WithEvents cmbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider

End Class

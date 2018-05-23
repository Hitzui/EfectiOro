<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRubros
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
        Dim DescrubroLabel As System.Windows.Forms.Label
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.radSalida = New System.Windows.Forms.RadioButton()
        Me.radEntrada = New System.Windows.Forms.RadioButton()
        Me.DescrubroTextBox = New System.Windows.Forms.TextBox()
        Me.RubroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvRubro = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        DescrubroLabel = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        Me.grupoDatos.SuspendLayout()
        CType(Me.RubroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalle.SuspendLayout()
        CType(Me.dgvRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(677, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(652, 25)
        '
        'DescrubroLabel
        '
        DescrubroLabel.AutoSize = True
        DescrubroLabel.Location = New System.Drawing.Point(23, 28)
        DescrubroLabel.Name = "DescrubroLabel"
        DescrubroLabel.Size = New System.Drawing.Size(110, 13)
        DescrubroLabel.TabIndex = 2
        DescrubroLabel.Text = "Descripcion del rubro:"
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.radSalida)
        Me.grupoDatos.Controls.Add(Me.radEntrada)
        Me.grupoDatos.Controls.Add(DescrubroLabel)
        Me.grupoDatos.Controls.Add(Me.DescrubroTextBox)
        Me.grupoDatos.Enabled = False
        Me.grupoDatos.Location = New System.Drawing.Point(12, 31)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(284, 100)
        Me.grupoDatos.TabIndex = 1
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos"
        '
        'radSalida
        '
        Me.radSalida.AutoSize = True
        Me.radSalida.Location = New System.Drawing.Point(171, 73)
        Me.radSalida.Name = "radSalida"
        Me.radSalida.Size = New System.Drawing.Size(54, 17)
        Me.radSalida.TabIndex = 5
        Me.radSalida.Text = "Salida"
        Me.radSalida.UseVisualStyleBackColor = True
        '
        'radEntrada
        '
        Me.radEntrada.AutoSize = True
        Me.radEntrada.Checked = True
        Me.radEntrada.Location = New System.Drawing.Point(26, 73)
        Me.radEntrada.Name = "radEntrada"
        Me.radEntrada.Size = New System.Drawing.Size(62, 17)
        Me.radEntrada.TabIndex = 4
        Me.radEntrada.TabStop = True
        Me.radEntrada.Text = "Entrada"
        Me.radEntrada.UseVisualStyleBackColor = True
        '
        'DescrubroTextBox
        '
        Me.DescrubroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescrubroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RubroBindingSource, "Descrubro", True))
        Me.DescrubroTextBox.Location = New System.Drawing.Point(26, 44)
        Me.DescrubroTextBox.Name = "DescrubroTextBox"
        Me.DescrubroTextBox.Size = New System.Drawing.Size(235, 20)
        Me.DescrubroTextBox.TabIndex = 3
        '
        'RubroBindingSource
        '
        Me.RubroBindingSource.DataSource = GetType(EfectiOro.Database.Rubro)
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.dgvRubro)
        Me.grupoDetalle.Location = New System.Drawing.Point(302, 31)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(375, 194)
        Me.grupoDetalle.TabIndex = 2
        Me.grupoDetalle.TabStop = False
        Me.grupoDetalle.Text = "Detalle"
        '
        'dgvRubro
        '
        Me.dgvRubro.AllowUserToAddRows = False
        Me.dgvRubro.AllowUserToDeleteRows = False
        Me.dgvRubro.AutoGenerateColumns = False
        Me.dgvRubro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRubro.BackgroundColor = System.Drawing.Color.White
        Me.dgvRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRubro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvRubro.DataSource = Me.RubroBindingSource
        Me.dgvRubro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRubro.Location = New System.Drawing.Point(3, 16)
        Me.dgvRubro.Name = "dgvRubro"
        Me.dgvRubro.ReadOnly = True
        Me.dgvRubro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRubro.Size = New System.Drawing.Size(369, 175)
        Me.dgvRubro.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codrubro"
        Me.DataGridViewTextBoxColumn3.FillWeight = 45.36327!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Descrubro"
        Me.DataGridViewTextBoxColumn1.FillWeight = 126.2611!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Naturaleza"
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Naturaleza"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 88)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.EfectiOro.My.Resources.Resources._48
        Me.btnCancelar.Location = New System.Drawing.Point(232, 22)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.btnCancelar.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.EfectiOro.My.Resources.Resources._9
        Me.btnEliminar.Location = New System.Drawing.Point(176, 22)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(45, 45)
        Me.btnEliminar.TabIndex = 10
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = Global.EfectiOro.My.Resources.Resources._2
        Me.btnEditar.Location = New System.Drawing.Point(120, 22)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(45, 45)
        Me.btnEditar.TabIndex = 9
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.EfectiOro.My.Resources.Resources._7
        Me.btnGuardar.Location = New System.Drawing.Point(64, 22)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(45, 45)
        Me.btnGuardar.TabIndex = 7
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.EfectiOro.My.Resources.Resources._8
        Me.btnNuevo.Location = New System.Drawing.Point(8, 22)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(45, 45)
        Me.btnNuevo.TabIndex = 8
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(677, 232)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grupoDatos)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Name = "frmRubros"
        Me.Controls.SetChildIndex(Me.grupoDetalle, 0)
        Me.Controls.SetChildIndex(Me.grupoDatos, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.RubroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalle.ResumeLayout(False)
        CType(Me.dgvRubro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvRubro As System.Windows.Forms.DataGridView
    Friend WithEvents RubroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents radSalida As System.Windows.Forms.RadioButton
    Friend WithEvents radEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents DescrubroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

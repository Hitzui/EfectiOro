<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgencia
    Inherits frmPersonalizado

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
        Me.UltraTab1 = New System.Windows.Forms.TabControl()
        Me.pageDetalle = New System.Windows.Forms.TabPage()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraTab2 = New System.Windows.Forms.TabControl()
        Me.pageLista = New System.Windows.Forms.TabPage()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAgencias = New System.Windows.Forms.DataGridView()
        Me.CodagenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomagenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiragenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisagenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelagenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabAgencia = New System.Windows.Forms.TabControl()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panelTitulo.SuspendLayout()
        Me.pageDetalle.SuspendLayout()
        Me.pageLista.SuspendLayout()
        CType(Me.dgvAgencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAgencia.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(423, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(398, 25)
        '
        'UltraTab1
        '
        Me.UltraTab1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTab1.Name = "UltraTab1"
        Me.UltraTab1.SelectedIndex = 0
        Me.UltraTab1.Size = New System.Drawing.Size(200, 100)
        Me.UltraTab1.TabIndex = 0
        Me.UltraTab1.Text = "Datos de Agencia"
        '
        'pageDetalle
        '
        Me.pageDetalle.BackColor = System.Drawing.Color.White
        Me.pageDetalle.Controls.Add(Me.btnCancelar)
        Me.pageDetalle.Controls.Add(Me.btnEliminar)
        Me.pageDetalle.Controls.Add(Me.btnEditar)
        Me.pageDetalle.Controls.Add(Me.btnGuardar)
        Me.pageDetalle.Controls.Add(Me.btnNuevo)
        Me.pageDetalle.Controls.Add(Me.txtTelefono)
        Me.pageDetalle.Controls.Add(Me.txtDistrito)
        Me.pageDetalle.Controls.Add(Me.txtDireccion)
        Me.pageDetalle.Controls.Add(Me.txtNombre)
        Me.pageDetalle.Controls.Add(Me.Label7)
        Me.pageDetalle.Controls.Add(Me.Label6)
        Me.pageDetalle.Controls.Add(Me.Label5)
        Me.pageDetalle.Controls.Add(Me.Label4)
        Me.pageDetalle.Controls.Add(Me.lblCodigo)
        Me.pageDetalle.Controls.Add(Me.Label2)
        Me.pageDetalle.Location = New System.Drawing.Point(4, 22)
        Me.pageDetalle.Name = "pageDetalle"
        Me.pageDetalle.Size = New System.Drawing.Size(415, 306)
        Me.pageDetalle.TabIndex = 0
        Me.pageDetalle.Text = "Datos Agencia"
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.EfectiOro.My.Resources.Resources._48
        Me.btnCancelar.Location = New System.Drawing.Point(304, 238)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.btnCancelar.TabIndex = 14
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.EfectiOro.My.Resources.Resources._9
        Me.btnEliminar.Location = New System.Drawing.Point(244, 238)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(45, 45)
        Me.btnEliminar.TabIndex = 13
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = Global.EfectiOro.My.Resources.Resources._2
        Me.btnEditar.Location = New System.Drawing.Point(180, 238)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(45, 45)
        Me.btnEditar.TabIndex = 12
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.EfectiOro.My.Resources.Resources._7
        Me.btnGuardar.Location = New System.Drawing.Point(117, 238)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(45, 45)
        Me.btnGuardar.TabIndex = 11
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.EfectiOro.My.Resources.Resources._8
        Me.btnNuevo.Location = New System.Drawing.Point(47, 238)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(45, 45)
        Me.btnNuevo.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(180, 182)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(149, 20)
        Me.txtTelefono.TabIndex = 9
        '
        'txtDistrito
        '
        Me.txtDistrito.Location = New System.Drawing.Point(180, 156)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(149, 20)
        Me.txtDistrito.TabIndex = 8
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(180, 92)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(149, 58)
        Me.txtDireccion.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(180, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 20)
        Me.txtNombre.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Telefono de la Agencia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Distrito de la Agencia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Dirección de la Agencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre de la Agencia:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(177, 31)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(46, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "(Codigo)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo de la agencia:"
        '
        'UltraTab2
        '
        Me.UltraTab2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTab2.Name = "UltraTab2"
        Me.UltraTab2.SelectedIndex = 0
        Me.UltraTab2.Size = New System.Drawing.Size(200, 100)
        Me.UltraTab2.TabIndex = 0
        Me.UltraTab2.Text = "Detalles de Agencias"
        '
        'pageLista
        '
        Me.pageLista.BackColor = System.Drawing.Color.White
        Me.pageLista.Controls.Add(Me.txtFiltrar)
        Me.pageLista.Controls.Add(Me.Label1)
        Me.pageLista.Controls.Add(Me.dgvAgencias)
        Me.pageLista.Location = New System.Drawing.Point(4, 22)
        Me.pageLista.Name = "pageLista"
        Me.pageLista.Size = New System.Drawing.Size(415, 306)
        Me.pageLista.TabIndex = 0
        Me.pageLista.Text = "Lista de agencias"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltrar.Location = New System.Drawing.Point(130, 7)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(253, 20)
        Me.txtFiltrar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Agencia:"
        '
        'dgvAgencias
        '
        Me.dgvAgencias.AllowUserToAddRows = False
        Me.dgvAgencias.AllowUserToDeleteRows = False
        Me.dgvAgencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAgencias.AutoGenerateColumns = False
        Me.dgvAgencias.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvAgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodagenciaDataGridViewTextBoxColumn, Me.NomagenciaDataGridViewTextBoxColumn, Me.DiragenciaDataGridViewTextBoxColumn, Me.DisagenciaDataGridViewTextBoxColumn, Me.TelagenciaDataGridViewTextBoxColumn})
        Me.dgvAgencias.DataSource = Me.AgenciaBindingSource
        Me.dgvAgencias.Location = New System.Drawing.Point(0, 37)
        Me.dgvAgencias.Name = "dgvAgencias"
        Me.dgvAgencias.ReadOnly = True
        Me.dgvAgencias.Size = New System.Drawing.Size(421, 273)
        Me.dgvAgencias.TabIndex = 0
        '
        'CodagenciaDataGridViewTextBoxColumn
        '
        Me.CodagenciaDataGridViewTextBoxColumn.DataPropertyName = "Codagencia"
        Me.CodagenciaDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodagenciaDataGridViewTextBoxColumn.Name = "CodagenciaDataGridViewTextBoxColumn"
        Me.CodagenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomagenciaDataGridViewTextBoxColumn
        '
        Me.NomagenciaDataGridViewTextBoxColumn.DataPropertyName = "Nomagencia"
        Me.NomagenciaDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NomagenciaDataGridViewTextBoxColumn.Name = "NomagenciaDataGridViewTextBoxColumn"
        Me.NomagenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiragenciaDataGridViewTextBoxColumn
        '
        Me.DiragenciaDataGridViewTextBoxColumn.DataPropertyName = "Diragencia"
        Me.DiragenciaDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DiragenciaDataGridViewTextBoxColumn.Name = "DiragenciaDataGridViewTextBoxColumn"
        Me.DiragenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DisagenciaDataGridViewTextBoxColumn
        '
        Me.DisagenciaDataGridViewTextBoxColumn.DataPropertyName = "Disagencia"
        Me.DisagenciaDataGridViewTextBoxColumn.HeaderText = "Distrito"
        Me.DisagenciaDataGridViewTextBoxColumn.Name = "DisagenciaDataGridViewTextBoxColumn"
        Me.DisagenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelagenciaDataGridViewTextBoxColumn
        '
        Me.TelagenciaDataGridViewTextBoxColumn.DataPropertyName = "Telagencia"
        Me.TelagenciaDataGridViewTextBoxColumn.HeaderText = "Teleono"
        Me.TelagenciaDataGridViewTextBoxColumn.Name = "TelagenciaDataGridViewTextBoxColumn"
        Me.TelagenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgenciaBindingSource
        '
        Me.AgenciaBindingSource.DataSource = GetType(EfectiOro.Database.Agencia)
        '
        'tabAgencia
        '
        Me.tabAgencia.Controls.Add(Me.pageDetalle)
        Me.tabAgencia.Controls.Add(Me.pageLista)
        Me.tabAgencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAgencia.Location = New System.Drawing.Point(0, 25)
        Me.tabAgencia.Name = "tabAgencia"
        Me.tabAgencia.SelectedIndex = 0
        Me.tabAgencia.Size = New System.Drawing.Size(423, 332)
        Me.tabAgencia.TabIndex = 1
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmAgencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(423, 357)
        Me.Controls.Add(Me.tabAgencia)
        Me.Name = "frmAgencia"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.tabAgencia, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.pageDetalle.ResumeLayout(False)
        Me.pageDetalle.PerformLayout()
        Me.pageLista.ResumeLayout(False)
        Me.pageLista.PerformLayout()
        CType(Me.dgvAgencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAgencia.ResumeLayout(False)
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabAgencia As TabControl
    Friend WithEvents pageDetalle As TabPage
    Friend WithEvents pageLista As TabPage
    Friend WithEvents dgvAgencias As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDistrito As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents AgenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodagenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomagenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiragenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisagenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelagenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltraTab1 As TabControl
    Friend WithEvents UltraTab2 As TabControl
End Class

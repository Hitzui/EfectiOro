<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim ClaveLabel As System.Windows.Forms.Label
        Dim lblCodoperador As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim FcreauLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Dim lblNombre As System.Windows.Forms.Label
        Dim PreguntaLabel As System.Windows.Forms.Label
        Dim RespuestaLabel As System.Windows.Forms.Label
        Dim Usuario1Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.panelIngreso = New System.Windows.Forms.Panel()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.txtConfirmarClave = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtCodoperador = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNombrecompleto = New System.Windows.Forms.TextBox()
        Me.txtPregunta = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.panelGrid = New System.Windows.Forms.Panel()
        Me.dgvUsuario = New System.Windows.Forms.DataGridView()
        Me.colCodoperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        ClaveLabel = New System.Windows.Forms.Label()
        lblCodoperador = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        FcreauLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        lblNombre = New System.Windows.Forms.Label()
        PreguntaLabel = New System.Windows.Forms.Label()
        RespuestaLabel = New System.Windows.Forms.Label()
        Usuario1Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        Me.panelIngreso.SuspendLayout()
        Me.panelFooter.SuspendLayout()
        Me.panelGrid.SuspendLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(815, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(790, 25)
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.Location = New System.Drawing.Point(71, 98)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(64, 13)
        ClaveLabel.TabIndex = 0
        ClaveLabel.Text = "Contraseña:"
        '
        'lblCodoperador
        '
        lblCodoperador.AutoSize = True
        lblCodoperador.Location = New System.Drawing.Point(30, 20)
        lblCodoperador.Name = "lblCodoperador"
        lblCodoperador.Size = New System.Drawing.Size(105, 13)
        lblCodoperador.TabIndex = 2
        lblCodoperador.Text = "Codigo del operador:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(92, 229)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 4
        EstadoLabel.Text = "Estado:"
        '
        'FcreauLabel
        '
        FcreauLabel.AutoSize = True
        FcreauLabel.Location = New System.Drawing.Point(95, 255)
        FcreauLabel.Name = "FcreauLabel"
        FcreauLabel.Size = New System.Drawing.Size(40, 13)
        FcreauLabel.TabIndex = 6
        FcreauLabel.Text = "Fecha:"
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Location = New System.Drawing.Point(48, 202)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(87, 13)
        NivelLabel.TabIndex = 8
        NivelLabel.Text = "Nivel de acceso:"
        '
        'lblNombre
        '
        lblNombre.AutoSize = True
        lblNombre.Location = New System.Drawing.Point(42, 46)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New System.Drawing.Size(93, 13)
        lblNombre.TabIndex = 10
        lblNombre.Text = "Nombre completo:"
        '
        'PreguntaLabel
        '
        PreguntaLabel.AutoSize = True
        PreguntaLabel.Location = New System.Drawing.Point(18, 150)
        PreguntaLabel.Name = "PreguntaLabel"
        PreguntaLabel.Size = New System.Drawing.Size(117, 13)
        PreguntaLabel.TabIndex = 12
        PreguntaLabel.Text = "Pregunta de seguridad:"
        '
        'RespuestaLabel
        '
        RespuestaLabel.AutoSize = True
        RespuestaLabel.Location = New System.Drawing.Point(64, 176)
        RespuestaLabel.Name = "RespuestaLabel"
        RespuestaLabel.Size = New System.Drawing.Size(61, 13)
        RespuestaLabel.TabIndex = 14
        RespuestaLabel.Text = "Respuesta:"
        '
        'Usuario1Label
        '
        Usuario1Label.AutoSize = True
        Usuario1Label.Location = New System.Drawing.Point(36, 72)
        Usuario1Label.Name = "Usuario1Label"
        Usuario1Label.Size = New System.Drawing.Size(99, 13)
        Usuario1Label.TabIndex = 16
        Usuario1Label.Text = "Nombre de usuario:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(25, 124)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(110, 13)
        Label1.TabIndex = 18
        Label1.Text = "Confirmar contraseña:"
        '
        'panelIngreso
        '
        Me.panelIngreso.Controls.Add(Me.panelFooter)
        Me.panelIngreso.Controls.Add(Me.cmbEstado)
        Me.panelIngreso.Controls.Add(Me.cmbNivel)
        Me.panelIngreso.Controls.Add(Label1)
        Me.panelIngreso.Controls.Add(Me.txtConfirmarClave)
        Me.panelIngreso.Controls.Add(ClaveLabel)
        Me.panelIngreso.Controls.Add(Me.txtClave)
        Me.panelIngreso.Controls.Add(lblCodoperador)
        Me.panelIngreso.Controls.Add(Me.txtCodoperador)
        Me.panelIngreso.Controls.Add(EstadoLabel)
        Me.panelIngreso.Controls.Add(FcreauLabel)
        Me.panelIngreso.Controls.Add(Me.txtfecha)
        Me.panelIngreso.Controls.Add(NivelLabel)
        Me.panelIngreso.Controls.Add(lblNombre)
        Me.panelIngreso.Controls.Add(Me.txtNombrecompleto)
        Me.panelIngreso.Controls.Add(PreguntaLabel)
        Me.panelIngreso.Controls.Add(Me.txtPregunta)
        Me.panelIngreso.Controls.Add(RespuestaLabel)
        Me.panelIngreso.Controls.Add(Me.txtRespuesta)
        Me.panelIngreso.Controls.Add(Usuario1Label)
        Me.panelIngreso.Controls.Add(Me.txtUsuario)
        Me.panelIngreso.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelIngreso.Location = New System.Drawing.Point(0, 25)
        Me.panelIngreso.Name = "panelIngreso"
        Me.panelIngreso.Size = New System.Drawing.Size(392, 370)
        Me.panelIngreso.TabIndex = 1
        '
        'panelFooter
        '
        Me.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelFooter.Controls.Add(Me.btnCancelar)
        Me.panelFooter.Controls.Add(Me.btnEliminar)
        Me.panelFooter.Controls.Add(Me.btnEditar)
        Me.panelFooter.Controls.Add(Me.btnGuardar)
        Me.panelFooter.Controls.Add(Me.btnNuevo)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 304)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(392, 66)
        Me.panelFooter.TabIndex = 3
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.EfectiOro.My.Resources.Resources._48
        Me.btnCancelar.Location = New System.Drawing.Point(302, 9)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.btnCancelar.TabIndex = 14
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.EfectiOro.My.Resources.Resources.USER_MALE_REMOVE
        Me.btnEliminar.Location = New System.Drawing.Point(242, 9)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(45, 45)
        Me.btnEliminar.TabIndex = 13
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = Global.EfectiOro.My.Resources.Resources.USER_MALE_EDIT
        Me.btnEditar.Location = New System.Drawing.Point(178, 9)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(45, 45)
        Me.btnEditar.TabIndex = 12
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.EfectiOro.My.Resources.Resources.filesave
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(115, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(45, 45)
        Me.btnGuardar.TabIndex = 11
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.EfectiOro.My.Resources.Resources.nuevo_usuario
        Me.btnNuevo.Location = New System.Drawing.Point(45, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(45, 45)
        Me.btnNuevo.TabIndex = 10
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"(Seleccione una opcion)", "Activo", "Inactivo", "Despedido"})
        Me.cmbEstado.Location = New System.Drawing.Point(141, 226)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(153, 21)
        Me.cmbEstado.TabIndex = 8
        '
        'cmbNivel
        '
        Me.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNivel.FormattingEnabled = True
        Me.cmbNivel.Items.AddRange(New Object() {"(Seleccione una opcion)", "Administrador", "Supervisor", "Supervisor de caja", "Caja"})
        Me.cmbNivel.Location = New System.Drawing.Point(141, 199)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(153, 21)
        Me.cmbNivel.TabIndex = 7
        '
        'txtConfirmarClave
        '
        Me.txtConfirmarClave.Location = New System.Drawing.Point(141, 121)
        Me.txtConfirmarClave.Name = "txtConfirmarClave"
        Me.txtConfirmarClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarClave.Size = New System.Drawing.Size(200, 20)
        Me.txtConfirmarClave.TabIndex = 4
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(141, 95)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(200, 20)
        Me.txtClave.TabIndex = 3
        '
        'txtCodoperador
        '
        Me.txtCodoperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodoperador.Location = New System.Drawing.Point(141, 17)
        Me.txtCodoperador.Name = "txtCodoperador"
        Me.txtCodoperador.Size = New System.Drawing.Size(200, 20)
        Me.txtCodoperador.TabIndex = 0
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(141, 253)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(153, 20)
        Me.txtfecha.TabIndex = 9
        '
        'txtNombrecompleto
        '
        Me.txtNombrecompleto.Location = New System.Drawing.Point(141, 43)
        Me.txtNombrecompleto.Name = "txtNombrecompleto"
        Me.txtNombrecompleto.Size = New System.Drawing.Size(200, 20)
        Me.txtNombrecompleto.TabIndex = 1
        '
        'txtPregunta
        '
        Me.txtPregunta.Location = New System.Drawing.Point(141, 147)
        Me.txtPregunta.Name = "txtPregunta"
        Me.txtPregunta.Size = New System.Drawing.Size(200, 20)
        Me.txtPregunta.TabIndex = 5
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(141, 173)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(200, 20)
        Me.txtRespuesta.TabIndex = 6
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(141, 69)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(200, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'panelGrid
        '
        Me.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGrid.Controls.Add(Me.dgvUsuario)
        Me.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelGrid.Location = New System.Drawing.Point(392, 25)
        Me.panelGrid.Name = "panelGrid"
        Me.panelGrid.Size = New System.Drawing.Size(423, 370)
        Me.panelGrid.TabIndex = 2
        '
        'dgvUsuario
        '
        Me.dgvUsuario.AllowUserToAddRows = False
        Me.dgvUsuario.AllowUserToDeleteRows = False
        Me.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUsuario.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodoperador, Me.colNombre, Me.colUsuario, Me.colNivel, Me.colEstado})
        Me.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuario.Location = New System.Drawing.Point(0, 0)
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.ReadOnly = True
        Me.dgvUsuario.Size = New System.Drawing.Size(421, 368)
        Me.dgvUsuario.TabIndex = 0
        '
        'colCodoperador
        '
        Me.colCodoperador.HeaderText = "Codigo del operador"
        Me.colCodoperador.Name = "colCodoperador"
        Me.colCodoperador.ReadOnly = True
        Me.colCodoperador.Width = 116
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre completo"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Width = 105
        '
        'colUsuario
        '
        Me.colUsuario.HeaderText = "Nombre de usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        Me.colUsuario.Width = 111
        '
        'colNivel
        '
        Me.colNivel.HeaderText = "Nivel de acceso"
        Me.colNivel.Name = "colNivel"
        Me.colNivel.ReadOnly = True
        '
        'colEstado
        '
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.Width = 65
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(815, 395)
        Me.Controls.Add(Me.panelGrid)
        Me.Controls.Add(Me.panelIngreso)
        Me.Name = "frmUsuario"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.panelIngreso, 0)
        Me.Controls.SetChildIndex(Me.panelGrid, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.panelIngreso.ResumeLayout(False)
        Me.panelIngreso.PerformLayout()
        Me.panelFooter.ResumeLayout(False)
        Me.panelGrid.ResumeLayout(False)
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelIngreso As System.Windows.Forms.Panel
    Friend WithEvents panelGrid As System.Windows.Forms.Panel
    Friend WithEvents panelFooter As System.Windows.Forms.Panel
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents txtConfirmarClave As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtCodoperador As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombrecompleto As System.Windows.Forms.TextBox
    Friend WithEvents txtPregunta As System.Windows.Forms.TextBox
    Friend WithEvents txtRespuesta As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents dgvUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents colCodoperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNivel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider

End Class

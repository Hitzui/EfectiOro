<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptClientes
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.btnSalir = New Infragistics.Win.Misc.UltraButton()
        Me.cmbReembolsos = New System.Windows.Forms.ComboBox()
        Me.radReembolsos = New System.Windows.Forms.RadioButton()
        Me.cmbTransacciones = New System.Windows.Forms.ComboBox()
        Me.cmbAdelantosPendientes = New System.Windows.Forms.ComboBox()
        Me.radAdelantosSaldosPendientesDetallado = New System.Windows.Forms.RadioButton()
        Me.radCatalogo_pica = New System.Windows.Forms.RadioButton()
        Me.radCatalogo_pic = New System.Windows.Forms.RadioButton()
        Me.radCatalogo = New System.Windows.Forms.RadioButton()
        Me.radTransaccionesEfectivo = New System.Windows.Forms.RadioButton()
        Me.radVariaciones = New System.Windows.Forms.RadioButton()
        Me.radGeneral = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New Infragistics.Win.Misc.UltraButton()
        Me.lblcodigocliente = New System.Windows.Forms.Label()
        Me.txtHastagen = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesdegen = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscardet = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvFiltrar = New System.Windows.Forms.DataGridView()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radApellido = New System.Windows.Forms.RadioButton()
        Me.radPorcodigo = New System.Windows.Forms.RadioButton()
        Me.radPorcedula = New System.Windows.Forms.RadioButton()
        Me.radPornombre = New System.Windows.Forms.RadioButton()
        Me.fillDataTable = New System.ComponentModel.BackgroundWorker()
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(719, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(694, 25)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.cmbReembolsos)
        Me.GroupBox2.Controls.Add(Me.radReembolsos)
        Me.GroupBox2.Controls.Add(Me.cmbTransacciones)
        Me.GroupBox2.Controls.Add(Me.cmbAdelantosPendientes)
        Me.GroupBox2.Controls.Add(Me.radAdelantosSaldosPendientesDetallado)
        Me.GroupBox2.Controls.Add(Me.radCatalogo_pica)
        Me.GroupBox2.Controls.Add(Me.radCatalogo_pic)
        Me.GroupBox2.Controls.Add(Me.radCatalogo)
        Me.GroupBox2.Controls.Add(Me.radTransaccionesEfectivo)
        Me.GroupBox2.Controls.Add(Me.radVariaciones)
        Me.GroupBox2.Controls.Add(Me.radGeneral)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 266)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generar reporte"
        '
        'btnBuscar
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.buscar_48
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnBuscar.Appearance = Appearance1
        Me.btnBuscar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnBuscar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnBuscar.Location = New System.Drawing.Point(32, 224)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(107, 35)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Visualizar"
        Me.btnBuscar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSalir
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources._23
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnSalir.Appearance = Appearance2
        Me.btnSalir.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnSalir.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnSalir.Location = New System.Drawing.Point(344, 225)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 35)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'cmbReembolsos
        '
        Me.cmbReembolsos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReembolsos.FormattingEnabled = True
        Me.cmbReembolsos.Items.AddRange(New Object() {"Historico", "Actual", "Numero de adelanto", "Consolidado", "Historico por fecha"})
        Me.cmbReembolsos.Location = New System.Drawing.Point(255, 165)
        Me.cmbReembolsos.Name = "cmbReembolsos"
        Me.cmbReembolsos.Size = New System.Drawing.Size(160, 21)
        Me.cmbReembolsos.TabIndex = 12
        Me.cmbReembolsos.Visible = False
        '
        'radReembolsos
        '
        Me.radReembolsos.AutoSize = True
        Me.radReembolsos.Location = New System.Drawing.Point(28, 166)
        Me.radReembolsos.Name = "radReembolsos"
        Me.radReembolsos.Size = New System.Drawing.Size(145, 17)
        Me.radReembolsos.TabIndex = 11
        Me.radReembolsos.Text = "Aplicación de reembolsos"
        Me.radReembolsos.UseVisualStyleBackColor = True
        '
        'cmbTransacciones
        '
        Me.cmbTransacciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransacciones.FormattingEnabled = True
        Me.cmbTransacciones.Items.AddRange(New Object() {"General", "Detalle de transacciones", "Detallado por cliente"})
        Me.cmbTransacciones.Location = New System.Drawing.Point(255, 78)
        Me.cmbTransacciones.Name = "cmbTransacciones"
        Me.cmbTransacciones.Size = New System.Drawing.Size(160, 21)
        Me.cmbTransacciones.TabIndex = 10
        Me.cmbTransacciones.Visible = False
        '
        'cmbAdelantosPendientes
        '
        Me.cmbAdelantosPendientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdelantosPendientes.FormattingEnabled = True
        Me.cmbAdelantosPendientes.Items.AddRange(New Object() {"Detallado", "Consolidado"})
        Me.cmbAdelantosPendientes.Location = New System.Drawing.Point(255, 132)
        Me.cmbAdelantosPendientes.Name = "cmbAdelantosPendientes"
        Me.cmbAdelantosPendientes.Size = New System.Drawing.Size(160, 21)
        Me.cmbAdelantosPendientes.TabIndex = 9
        Me.cmbAdelantosPendientes.Visible = False
        '
        'radAdelantosSaldosPendientesDetallado
        '
        Me.radAdelantosSaldosPendientesDetallado.AutoSize = True
        Me.radAdelantosSaldosPendientesDetallado.Location = New System.Drawing.Point(28, 133)
        Me.radAdelantosSaldosPendientesDetallado.Name = "radAdelantosSaldosPendientesDetallado"
        Me.radAdelantosSaldosPendientesDetallado.Size = New System.Drawing.Size(179, 17)
        Me.radAdelantosSaldosPendientesDetallado.TabIndex = 7
        Me.radAdelantosSaldosPendientesDetallado.Text = "Adelanto con saldos pendientes:"
        Me.radAdelantosSaldosPendientesDetallado.UseVisualStyleBackColor = True
        '
        'radCatalogo_pica
        '
        Me.radCatalogo_pica.AutoSize = True
        Me.radCatalogo_pica.Location = New System.Drawing.Point(255, 106)
        Me.radCatalogo_pica.Name = "radCatalogo_pica"
        Me.radCatalogo_pica.Size = New System.Drawing.Size(148, 17)
        Me.radCatalogo_pica.TabIndex = 6
        Me.radCatalogo_pica.Text = "Catálogo de clientes PICA"
        Me.radCatalogo_pica.UseVisualStyleBackColor = True
        '
        'radCatalogo_pic
        '
        Me.radCatalogo_pic.AutoSize = True
        Me.radCatalogo_pic.Location = New System.Drawing.Point(28, 106)
        Me.radCatalogo_pic.Name = "radCatalogo_pic"
        Me.radCatalogo_pic.Size = New System.Drawing.Size(141, 17)
        Me.radCatalogo_pic.TabIndex = 5
        Me.radCatalogo_pic.Text = "Catálogo de clientes PIC"
        Me.radCatalogo_pic.UseVisualStyleBackColor = True
        '
        'radCatalogo
        '
        Me.radCatalogo.AutoSize = True
        Me.radCatalogo.Location = New System.Drawing.Point(255, 25)
        Me.radCatalogo.Name = "radCatalogo"
        Me.radCatalogo.Size = New System.Drawing.Size(121, 17)
        Me.radCatalogo.TabIndex = 4
        Me.radCatalogo.Text = "Catálogo de clientes"
        Me.radCatalogo.UseVisualStyleBackColor = True
        '
        'radTransaccionesEfectivo
        '
        Me.radTransaccionesEfectivo.AutoSize = True
        Me.radTransaccionesEfectivo.Location = New System.Drawing.Point(28, 79)
        Me.radTransaccionesEfectivo.Name = "radTransaccionesEfectivo"
        Me.radTransaccionesEfectivo.Size = New System.Drawing.Size(111, 17)
        Me.radTransaccionesEfectivo.TabIndex = 2
        Me.radTransaccionesEfectivo.Text = "De transacciones:"
        Me.radTransaccionesEfectivo.UseVisualStyleBackColor = True
        '
        'radVariaciones
        '
        Me.radVariaciones.AutoSize = True
        Me.radVariaciones.Location = New System.Drawing.Point(28, 52)
        Me.radVariaciones.Name = "radVariaciones"
        Me.radVariaciones.Size = New System.Drawing.Size(96, 17)
        Me.radVariaciones.TabIndex = 1
        Me.radVariaciones.Text = "De variaciones"
        Me.radVariaciones.UseVisualStyleBackColor = True
        '
        'radGeneral
        '
        Me.radGeneral.AutoSize = True
        Me.radGeneral.Checked = True
        Me.radGeneral.Location = New System.Drawing.Point(28, 25)
        Me.radGeneral.Name = "radGeneral"
        Me.radGeneral.Size = New System.Drawing.Size(123, 17)
        Me.radGeneral.TabIndex = 0
        Me.radGeneral.TabStop = True
        Me.radGeneral.Text = "Reporte consolidado"
        Me.radGeneral.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.lblcodigocliente)
        Me.GroupBox1.Controls.Add(Me.txtHastagen)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDesdegen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fechas"
        '
        'btnLimpiar
        '
        Appearance3.Image = Global.EfectiOro.My.Resources.Resources._48
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnLimpiar.Appearance = Appearance3
        Me.btnLimpiar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnLimpiar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnLimpiar.Location = New System.Drawing.Point(30, 212)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(107, 35)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar seleccion"
        Me.btnLimpiar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'lblcodigocliente
        '
        Me.lblcodigocliente.AutoSize = True
        Me.lblcodigocliente.Location = New System.Drawing.Point(24, 162)
        Me.lblcodigocliente.Name = "lblcodigocliente"
        Me.lblcodigocliente.Size = New System.Drawing.Size(100, 13)
        Me.lblcodigocliente.TabIndex = 5
        Me.lblcodigocliente.Text = "(Seleccione cliente)"
        '
        'txtHastagen
        '
        Me.txtHastagen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHastagen.Location = New System.Drawing.Point(24, 98)
        Me.txtHastagen.Name = "txtHastagen"
        Me.txtHastagen.Size = New System.Drawing.Size(162, 20)
        Me.txtHastagen.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo del Cliente seleccionado:"
        '
        'txtDesdegen
        '
        Me.txtDesdegen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesdegen.Location = New System.Drawing.Point(24, 46)
        Me.txtDesdegen.Name = "txtDesdegen"
        Me.txtDesdegen.Size = New System.Drawing.Size(162, 20)
        Me.txtDesdegen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'btnBuscardet
        '
        Me.btnBuscardet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscardet.Image = Global.EfectiOro.My.Resources.Resources.buscar_24
        Me.btnBuscardet.Location = New System.Drawing.Point(6, 211)
        Me.btnBuscardet.Name = "btnBuscardet"
        Me.btnBuscardet.Size = New System.Drawing.Size(136, 32)
        Me.btnBuscardet.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvFiltrar)
        Me.GroupBox4.Controls.Add(Me.txtFiltrar)
        Me.GroupBox4.Location = New System.Drawing.Point(161, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(546, 248)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'dgvFiltrar
        '
        Me.dgvFiltrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFiltrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFiltrar.BackgroundColor = System.Drawing.Color.White
        Me.dgvFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFiltrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiltrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFiltrar.Location = New System.Drawing.Point(3, 36)
        Me.dgvFiltrar.Name = "dgvFiltrar"
        Me.dgvFiltrar.Size = New System.Drawing.Size(540, 209)
        Me.dgvFiltrar.TabIndex = 2
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFiltrar.Location = New System.Drawing.Point(3, 16)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(540, 20)
        Me.txtFiltrar.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radApellido)
        Me.GroupBox3.Controls.Add(Me.btnBuscardet)
        Me.GroupBox3.Controls.Add(Me.radPorcodigo)
        Me.GroupBox3.Controls.Add(Me.radPorcedula)
        Me.GroupBox3.Controls.Add(Me.radPornombre)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 249)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar por"
        '
        'radApellido
        '
        Me.radApellido.AutoSize = True
        Me.radApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radApellido.Location = New System.Drawing.Point(11, 77)
        Me.radApellido.Name = "radApellido"
        Me.radApellido.Size = New System.Drawing.Size(69, 19)
        Me.radApellido.TabIndex = 3
        Me.radApellido.Text = "Apellido"
        Me.radApellido.UseVisualStyleBackColor = True
        '
        'radPorcodigo
        '
        Me.radPorcodigo.AutoSize = True
        Me.radPorcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPorcodigo.Location = New System.Drawing.Point(11, 153)
        Me.radPorcodigo.Name = "radPorcodigo"
        Me.radPorcodigo.Size = New System.Drawing.Size(120, 19)
        Me.radPorcodigo.TabIndex = 2
        Me.radPorcodigo.Text = "Código de cliente"
        Me.radPorcodigo.UseVisualStyleBackColor = True
        '
        'radPorcedula
        '
        Me.radPorcedula.AutoSize = True
        Me.radPorcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPorcedula.Location = New System.Drawing.Point(11, 115)
        Me.radPorcedula.Name = "radPorcedula"
        Me.radPorcedula.Size = New System.Drawing.Size(127, 19)
        Me.radPorcedula.TabIndex = 1
        Me.radPorcedula.Text = "Número de cedula"
        Me.radPorcedula.UseVisualStyleBackColor = True
        '
        'radPornombre
        '
        Me.radPornombre.AutoSize = True
        Me.radPornombre.Checked = True
        Me.radPornombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPornombre.Location = New System.Drawing.Point(11, 39)
        Me.radPornombre.Name = "radPornombre"
        Me.radPornombre.Size = New System.Drawing.Size(70, 19)
        Me.radPornombre.TabIndex = 0
        Me.radPornombre.TabStop = True
        Me.radPornombre.Text = "Nombre"
        Me.radPornombre.UseVisualStyleBackColor = True
        '
        'fillDataTable
        '
        '
        'frmRptClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(719, 555)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmRptClientes"
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radTransaccionesEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents radVariaciones As System.Windows.Forms.RadioButton
    Friend WithEvents radGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHastagen As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDesdegen As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscardet As Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radPorcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents radPorcedula As System.Windows.Forms.RadioButton
    Friend WithEvents radPornombre As System.Windows.Forms.RadioButton
    Friend WithEvents dgvFiltrar As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents lblcodigocliente As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radCatalogo As System.Windows.Forms.RadioButton
    Friend WithEvents radCatalogo_pica As System.Windows.Forms.RadioButton
    Friend WithEvents radCatalogo_pic As System.Windows.Forms.RadioButton
    Friend WithEvents radAdelantosSaldosPendientesDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents radApellido As System.Windows.Forms.RadioButton
    Friend WithEvents cmbAdelantosPendientes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTransacciones As System.Windows.Forms.ComboBox
    Friend WithEvents fillDataTable As System.ComponentModel.BackgroundWorker
    Friend WithEvents radReembolsos As System.Windows.Forms.RadioButton
    Friend WithEvents cmbReembolsos As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLimpiar As Infragistics.Win.Misc.UltraButton

End Class

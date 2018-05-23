<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptCaja
    Inherits EfectiOro.frmPersonalizado

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCajafiltrar = New System.Windows.Forms.ComboBox()
        Me.radFiltrarCaja = New System.Windows.Forms.RadioButton()
        Me.radFiltrarCajaActual = New System.Windows.Forms.RadioButton()
        Me.cmbCajaconsolidado = New System.Windows.Forms.ComboBox()
        Me.radConsolodidadoCaja = New System.Windows.Forms.RadioButton()
        Me.radConsolidadoTodos = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.radConsolidadoRangoFecha = New System.Windows.Forms.RadioButton()
        Me.panelTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(681, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(656, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDesde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 201)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fechas"
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(21, 118)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(179, 21)
        Me.txtHasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(21, 47)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(179, 21)
        Me.txtDesde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radConsolidadoRangoFecha)
        Me.GroupBox2.Controls.Add(Me.cmbCajafiltrar)
        Me.GroupBox2.Controls.Add(Me.radFiltrarCaja)
        Me.GroupBox2.Controls.Add(Me.radFiltrarCajaActual)
        Me.GroupBox2.Controls.Add(Me.cmbCajaconsolidado)
        Me.GroupBox2.Controls.Add(Me.radConsolodidadoCaja)
        Me.GroupBox2.Controls.Add(Me.radConsolidadoTodos)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 201)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'cmbCajafiltrar
        '
        Me.cmbCajafiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajafiltrar.FormattingEnabled = True
        Me.cmbCajafiltrar.Location = New System.Drawing.Point(210, 132)
        Me.cmbCajafiltrar.Name = "cmbCajafiltrar"
        Me.cmbCajafiltrar.Size = New System.Drawing.Size(149, 21)
        Me.cmbCajafiltrar.TabIndex = 5
        Me.cmbCajafiltrar.Visible = False
        '
        'radFiltrarCaja
        '
        Me.radFiltrarCaja.AutoSize = True
        Me.radFiltrarCaja.Location = New System.Drawing.Point(28, 133)
        Me.radFiltrarCaja.Name = "radFiltrarCaja"
        Me.radFiltrarCaja.Size = New System.Drawing.Size(103, 17)
        Me.radFiltrarCaja.TabIndex = 4
        Me.radFiltrarCaja.TabStop = True
        Me.radFiltrarCaja.Text = "Especificar caja:"
        Me.radFiltrarCaja.UseVisualStyleBackColor = True
        '
        'radFiltrarCajaActual
        '
        Me.radFiltrarCajaActual.AutoSize = True
        Me.radFiltrarCajaActual.Location = New System.Drawing.Point(28, 97)
        Me.radFiltrarCajaActual.Name = "radFiltrarCajaActual"
        Me.radFiltrarCajaActual.Size = New System.Drawing.Size(78, 17)
        Me.radFiltrarCajaActual.TabIndex = 3
        Me.radFiltrarCajaActual.TabStop = True
        Me.radFiltrarCajaActual.Text = "Caja actual"
        Me.radFiltrarCajaActual.UseVisualStyleBackColor = True
        '
        'cmbCajaconsolidado
        '
        Me.cmbCajaconsolidado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajaconsolidado.FormattingEnabled = True
        Me.cmbCajaconsolidado.Location = New System.Drawing.Point(210, 60)
        Me.cmbCajaconsolidado.Name = "cmbCajaconsolidado"
        Me.cmbCajaconsolidado.Size = New System.Drawing.Size(149, 21)
        Me.cmbCajaconsolidado.TabIndex = 2
        Me.cmbCajaconsolidado.Visible = False
        '
        'radConsolodidadoCaja
        '
        Me.radConsolodidadoCaja.AutoSize = True
        Me.radConsolodidadoCaja.Location = New System.Drawing.Point(28, 61)
        Me.radConsolodidadoCaja.Name = "radConsolodidadoCaja"
        Me.radConsolodidadoCaja.Size = New System.Drawing.Size(135, 17)
        Me.radConsolodidadoCaja.TabIndex = 1
        Me.radConsolodidadoCaja.TabStop = True
        Me.radConsolodidadoCaja.Text = "Consolidado de la caja:"
        Me.radConsolodidadoCaja.UseVisualStyleBackColor = True
        '
        'radConsolidadoTodos
        '
        Me.radConsolidadoTodos.AutoSize = True
        Me.radConsolidadoTodos.Location = New System.Drawing.Point(28, 25)
        Me.radConsolidadoTodos.Name = "radConsolidadoTodos"
        Me.radConsolidadoTodos.Size = New System.Drawing.Size(156, 17)
        Me.radConsolidadoTodos.TabIndex = 0
        Me.radConsolidadoTodos.TabStop = True
        Me.radConsolidadoTodos.Text = "Consolidado de caja por dia"
        Me.radConsolidadoTodos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Appearance1.Image = Global.EfectiOro.My.Resources.Resources.buscar_48
        Me.btnBuscar.Appearance = Appearance1
        Me.btnBuscar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnBuscar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnBuscar.Location = New System.Drawing.Point(151, 238)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 32)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Visualizar"
        Me.btnBuscar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCancelar
        '
        Appearance2.Image = Global.EfectiOro.My.Resources.Resources._23
        Me.btnCancelar.Appearance = Appearance2
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCancelar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnCancelar.Location = New System.Drawing.Point(467, 238)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 32)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'radConsolidadoRangoFecha
        '
        Me.radConsolidadoRangoFecha.AutoSize = True
        Me.radConsolidadoRangoFecha.Location = New System.Drawing.Point(210, 25)
        Me.radConsolidadoRangoFecha.Name = "radConsolidadoRangoFecha"
        Me.radConsolidadoRangoFecha.Size = New System.Drawing.Size(161, 17)
        Me.radConsolidadoRangoFecha.TabIndex = 6
        Me.radConsolidadoRangoFecha.TabStop = True
        Me.radConsolidadoRangoFecha.Text = "Consolidado por rango fecha"
        Me.radConsolidadoRangoFecha.UseVisualStyleBackColor = True
        '
        'frmRptCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 282)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptCaja"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCajaconsolidado As System.Windows.Forms.ComboBox
    Friend WithEvents radConsolodidadoCaja As System.Windows.Forms.RadioButton
    Friend WithEvents radConsolidadoTodos As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCajafiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents radFiltrarCaja As System.Windows.Forms.RadioButton
    Friend WithEvents radFiltrarCajaActual As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents radConsolidadoRangoFecha As System.Windows.Forms.RadioButton
End Class

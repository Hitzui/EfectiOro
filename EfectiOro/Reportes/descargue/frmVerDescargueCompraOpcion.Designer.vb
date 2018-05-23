<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerDescargueCompraOpcion
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
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.radGeneral = New System.Windows.Forms.RadioButton()
        Me.radDetallado = New System.Windows.Forms.RadioButton()
        Me.btnCancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btnOk = New Infragistics.Win.Misc.UltraButton()
        Me.panelTitulo.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.radDetallado)
        Me.UltraGroupBox1.Controls.Add(Me.radGeneral)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(420, 136)
        Me.UltraGroupBox1.TabIndex = 1
        '
        'radGeneral
        '
        Me.radGeneral.AutoSize = True
        Me.radGeneral.Checked = True
        Me.radGeneral.Location = New System.Drawing.Point(52, 22)
        Me.radGeneral.Name = "radGeneral"
        Me.radGeneral.Size = New System.Drawing.Size(261, 17)
        Me.radGeneral.TabIndex = 0
        Me.radGeneral.Text = "Generar reporte de descargue por compra general"
        Me.radGeneral.UseVisualStyleBackColor = True
        '
        'radDetallado
        '
        Me.radDetallado.AutoSize = True
        Me.radDetallado.Location = New System.Drawing.Point(52, 66)
        Me.radDetallado.Name = "radDetallado"
        Me.radDetallado.Size = New System.Drawing.Size(269, 17)
        Me.radDetallado.TabIndex = 1
        Me.radDetallado.Text = "Generar reporte de descargue por compra detallado"
        Me.radDetallado.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(231, 189)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnOk
        '
        Me.btnOk.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2010Button
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(357, 189)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Generar"
        Me.btnOk.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frmVerDescargueCompraOpcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(444, 224)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frmVerDescargueCompraOpcion"
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.panelTitulo.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents radDetallado As RadioButton
    Friend WithEvents radGeneral As RadioButton
    Friend WithEvents btnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOk As Infragistics.Win.Misc.UltraButton
End Class

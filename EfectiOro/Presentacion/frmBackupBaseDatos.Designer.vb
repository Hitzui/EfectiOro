<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupBaseDatos
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupBaseDatos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UltraButton1 = New System.Windows.Forms.Button()
        Me.lblRutaRespaldo = New System.Windows.Forms.Label()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UltraButton2 = New System.Windows.Forms.Button()
        Me.lblRutaRestaurar = New System.Windows.Forms.Label()
        Me.UltraButton3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraButton1)
        Me.GroupBox1.Controls.Add(Me.lblRutaRespaldo)
        Me.GroupBox1.Controls.Add(Me.btnRuta)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear respaldo de la base de datos"
        '
        'UltraButton1
        '
        Me.UltraButton1.FlatAppearance.BorderSize = 0
        Me.UltraButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UltraButton1.Location = New System.Drawing.Point(152, 166)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(114, 23)
        Me.UltraButton1.TabIndex = 2
        Me.UltraButton1.Text = "Guardar archivo"
        '
        'lblRutaRespaldo
        '
        Me.lblRutaRespaldo.Location = New System.Drawing.Point(26, 38)
        Me.lblRutaRespaldo.Name = "lblRutaRespaldo"
        Me.lblRutaRespaldo.Size = New System.Drawing.Size(240, 29)
        Me.lblRutaRespaldo.TabIndex = 1
        Me.lblRutaRespaldo.Text = "(Ruta)"
        '
        'btnRuta
        '
        Me.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRuta.Location = New System.Drawing.Point(29, 83)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(114, 23)
        Me.btnRuta.TabIndex = 0
        Me.btnRuta.Text = "Ruta del archivo"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.back"
        Me.SaveFileDialog1.Title = "Ruta de archivo backup"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UltraButton2)
        Me.GroupBox2.Controls.Add(Me.lblRutaRestaurar)
        Me.GroupBox2.Controls.Add(Me.UltraButton3)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(291, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 195)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Restaurar base de datos"
        '
        'UltraButton2
        '
        Me.UltraButton2.FlatAppearance.BorderSize = 0
        Me.UltraButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UltraButton2.Location = New System.Drawing.Point(141, 166)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(114, 23)
        Me.UltraButton2.TabIndex = 2
        Me.UltraButton2.Text = "Restaurar"
        '
        'lblRutaRestaurar
        '
        Me.lblRutaRestaurar.Location = New System.Drawing.Point(26, 38)
        Me.lblRutaRestaurar.Name = "lblRutaRestaurar"
        Me.lblRutaRestaurar.Size = New System.Drawing.Size(229, 30)
        Me.lblRutaRestaurar.TabIndex = 1
        Me.lblRutaRestaurar.Text = "(Ruta)"
        '
        'UltraButton3
        '
        Me.UltraButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UltraButton3.Location = New System.Drawing.Point(29, 84)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(114, 23)
        Me.UltraButton3.TabIndex = 0
        Me.UltraButton3.Text = "Ruta del archivo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmBackupBaseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(569, 220)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackupBaseDatos"
        Me.Text = "Copia de seguridad de la base de datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRutaRespaldo As System.Windows.Forms.Label
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents UltraButton1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButton2 As System.Windows.Forms.Button
    Friend WithEvents lblRutaRestaurar As System.Windows.Forms.Label
    Friend WithEvents UltraButton3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteCaja))
        Me.viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptCaja1 = New EfectiOro.rptCaja()
        Me.SuspendLayout()
        '
        'viewer
        '
        Me.viewer.ActiveViewIndex = -1
        Me.viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewer.Location = New System.Drawing.Point(0, 0)
        Me.viewer.Name = "viewer"
        Me.viewer.Size = New System.Drawing.Size(681, 558)
        Me.viewer.TabIndex = 0
        Me.viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReporteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 558)
        Me.Controls.Add(Me.viewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptCaja1 As rptCaja
End Class

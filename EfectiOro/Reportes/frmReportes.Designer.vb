<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
    Inherits Form
    '    Inherits EfectiOro.frmPersonalizado

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportes))
        Me.viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptComprasGeneral1 = New EfectiOro.rptComprasGeneral()
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
        Me.viewer.Size = New System.Drawing.Size(806, 602)
        Me.viewer.TabIndex = 1
        Me.viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportes
        '
        Me.ClientSize = New System.Drawing.Size(806, 602)
        Me.Controls.Add(Me.viewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportes"
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptComprasGeneral1 As EfectiOro.rptComprasGeneral

End Class

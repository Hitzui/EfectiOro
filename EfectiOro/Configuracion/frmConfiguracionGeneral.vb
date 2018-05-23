Public Class frmConfiguracionGeneral

    Dim config As New ConfiguracionGeneral()
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim nodo As String = TreeView1.SelectedNode.Tag
        Select Case nodo
            Case "Caja"
                If Me.panelCentral.Controls.Count > 0 Then
                    panelCentral.Controls.RemoveAt(0)
                End If
                frmConfig.TopLevel = False
                panelCentral.Controls.Add(frmConfig)
                frmConfig.WindowState = FormWindowState.Maximized
                frmConfig.Show()
            Case "Parametros"
                If Me.panelCentral.Controls.Count > 0 Then
                    panelCentral.Controls.RemoveAt(0)
                End If
                frmParametrosBasicos.TopLevel = False
                panelCentral.Controls.Add(frmParametrosBasicos)
                frmParametrosBasicos.WindowState = FormWindowState.Maximized
                frmParametrosBasicos.Show()
        End Select
    End Sub

    Private Sub frmConfiguracionGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class frmVerDescargueDetalleReporte

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal titulo As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = titulo
    End Sub

    Private Sub frmVerDescargueDetalleReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class

Public Class frmVerDescargueCompraOpcion

    Private _opcion As Integer
    ''' <summary>
    ''' Opcion para generar reporte
    ''' 1 - General
    ''' 2 - Detallado
    ''' </summary>
    ''' <returns></returns>
    Public Property Opcion() As Integer
        Get
            Return _opcion
        End Get
        Set(ByVal value As Integer)
            _opcion = value
        End Set
    End Property
    Private _generar As Boolean
    Public Property Generar() As Boolean
        Get
            Return _generar
        End Get
        Set(ByVal value As Boolean)
            _generar = value
        End Set
    End Property
    Private _cancelar As Boolean
    Public Property Cancelar() As Boolean
        Get
            Return _cancelar
        End Get
        Set(ByVal value As Boolean)
            _cancelar = value
        End Set
    End Property

    Public Sub New(titulo As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        btnClose.Visible = False
        lblTitulo.Text = titulo
    End Sub

    Private Sub frmVerDescargueCompraOpcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me._opcion = 1
    End Sub

    Private Sub radGeneral_CheckedChanged(sender As Object, e As EventArgs) Handles radGeneral.CheckedChanged
        If radGeneral.Checked Then
            _opcion = 1
        Else
            _opcion = 0
        End If
    End Sub

    Private Sub radDetallado_CheckedChanged(sender As Object, e As EventArgs) Handles radDetallado.CheckedChanged
        If radDetallado.Checked Then
            _opcion = 2
        Else
            _opcion = 0
        End If
    End Sub
End Class

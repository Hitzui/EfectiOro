Public Class ViewClientes
    Private _codcliente As String
    Public Property Codcliente() As String
        Get
            Return _codcliente
        End Get
        Set(ByVal value As String)
            _codcliente = value
        End Set
    End Property
    Private _nombres As String
    Public Property Nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property
    Private _apellidos As String
    Public Property Apellidos() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property
    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Private _mes As String
    Public Property Mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
        End Set
    End Property
    Private _monto As Decimal
    Public Property Monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property
    Private _montoMensual As Decimal
    Public Property Montomensual() As Decimal
        Get
            Return _montoMensual
        End Get
        Set(ByVal value As Decimal)
            _montoMensual = value
        End Set
    End Property
    Private _variacion As Decimal
    Public Property Variacion() As Decimal
        Get
            Return _variacion
        End Get
        Set(ByVal value As Decimal)
            _variacion = value
        End Set
    End Property

    Public Sub New()
    End Sub
End Class

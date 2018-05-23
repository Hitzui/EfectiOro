Public Class AdelantosPendientesReport
    Private _idSalida As String
    Public Property IdSalida() As String
        Get
            Return _idSalida
        End Get
        Set(ByVal value As String)
            _idSalida = value
        End Set
    End Property
    Private _codcliente As String
    Public Property CodCliente() As String
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
    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Private _saldo As Decimal
    Public Property Saldo() As Decimal
        Get
            Return _saldo
        End Get
        Set(ByVal value As Decimal)
            _saldo = value
        End Set
    End Property
    Private _codcaja As String
    Public Property Codcaja() As String
        Get
            Return _codcaja
        End Get
        Set(ByVal value As String)
            _codcaja = value
        End Set
    End Property

End Class

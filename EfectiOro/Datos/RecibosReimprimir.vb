Public Class RecibosReimprimir

    Private _rubro As String
    Public Property Rubro() As String
        Get
            Return _rubro
        End Get
        Set(ByVal value As String)
            _rubro = value
        End Set
    End Property
    Private _movimiento As String
    Public Property Movimiento() As String
        Get
            Return _movimiento
        End Get
        Set(ByVal value As String)
            _movimiento = value
        End Set
    End Property
    Private _efectivo As Decimal
    Public Property Efectivo() As Decimal
        Get
            Return _efectivo
        End Get
        Set(ByVal value As Decimal)
            _efectivo = value
        End Set
    End Property
    Private _cheque As Decimal
    Public Property Cheque() As Decimal
        Get
            Return _cheque
        End Get
        Set(ByVal value As Decimal)
            _cheque = value
        End Set
    End Property
    Private _transferencia As Decimal
    Public Property Transferencia() As Decimal
        Get
            Return _transferencia
        End Get
        Set(ByVal value As Decimal)
            _transferencia = value
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
    Private _hora As String
    Public Property Hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class

Public Class VConsolidadoCajaFecha
    Private _idcaja As Integer
    Public Property Idcaja() As Integer
        Get
            Return _idcaja
        End Get
        Set(ByVal value As Integer)
            _idcaja = value
        End Set
    End Property
    Private _codrubro As Integer
    Public Property Codrubro() As Integer
        Get
            Return _codrubro
        End Get
        Set(ByVal value As Integer)
            _codrubro = value
        End Set
    End Property
    Private _idmov As Integer
    Public Property Idmov() As Integer
        Get
            Return _idmov
        End Get
        Set(ByVal value As Integer)
            _idmov = value
        End Set
    End Property
    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
    Private _transferencia As Decimal
    Public Property Transferencia() As Decimal
        Get
            Return _transferencia
        End Get
        Set(ByVal value As Decimal)
            _transferencia = value
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
    Private _codcaja As String
    Public Property Codcaja() As String
        Get
            Return _codcaja
        End Get
        Set(ByVal value As String)
            _codcaja = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class

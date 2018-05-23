Public Class Estadisticos
    Private _cantidad As Decimal
    Public Property Cantidad() As Decimal
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Decimal)
            _cantidad = value
        End Set
    End Property
    Private _suma As Decimal
    Public Property Suma() As Decimal
        Get
            Return _suma
        End Get
        Set(ByVal value As Decimal)
            _suma = value
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
    Public Sub New()

    End Sub
    Private _total As Decimal
    Public Property Total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property
    Private _totalCantidad As Decimal
    Public Property TotalCantidad() As Decimal
        Get
            Return _totalCantidad
        End Get
        Set(ByVal value As Decimal)
            _totalCantidad = value
        End Set
    End Property

    Public Sub New(cant As Decimal, suma As Decimal, fecha As Date)
        Me._cantidad = cant
        Me._suma = suma
        Me._fecha = fecha
    End Sub
End Class

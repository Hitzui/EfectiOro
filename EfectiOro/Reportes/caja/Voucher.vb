Public Class Voucher
    Private _caja As String
    Public Property Caja() As String
        Get
            Return _caja
        End Get
        Set(ByVal value As String)
            _caja = value
        End Set
    End Property

    Private _recibi As String
    Public Property Recibi() As String
        Get
            Return _recibi
        End Get
        Set(ByVal value As String)
            _recibi = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _cantidadLetra As String
    Public Property cantidadLetra() As String
        Get
            Return _cantidadLetra
        End Get
        Set(ByVal value As String)
            _cantidadLetra = value
        End Set
    End Property

    Private _concepto As String
    Public Property Concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
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


End Class

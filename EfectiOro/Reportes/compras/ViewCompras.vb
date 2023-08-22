Public Class ViewCompras
    Private _agencia As String
    Public Property Codagencia() As String
        Get
            Return _agencia
        End Get
        Set(ByVal value As String)
            _agencia = value
        End Set
    End Property

    Private _numcompra As String
    Public Property Numcompra() As String
        Get
            Return _numcompra
        End Get
        Set(ByVal value As String)
            _numcompra = value
        End Set
    End Property
    Private _codclietne As String
    Public Property Codcliente() As String
        Get
            Return _codclietne
        End Get
        Set(value As String)
            _codclietne = value
        End Set
    End Property
    Private _numcedula As String
    Public Property Numcedula() As String
        Get
            Return _numcedula
        End Get
        Set(ByVal value As String)
            _numcedula = value
        End Set
    End Property

    Private _nomcliente As String
    Public Property Nomcliente() As String
        Get
            Return _nomcliente
        End Get
        Set(ByVal value As String)
            _nomcliente = value
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
    Private _total As Decimal
    Public Property Total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property
    Private _totalGeneral As Decimal
    Public Property TotalGeneral() As Decimal
        Get
            Return _totalGeneral
        End Get
        Set(ByVal value As Decimal)
            _totalGeneral = value
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

    Private _peso As Decimal
    Public Property Peso() As Decimal
        Get
            Return _peso
        End Get
        Set(ByVal value As Decimal)
            _peso = value
        End Set
    End Property
    Private _precio As Decimal
    Public Property Precio() As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property
    Private _importe As Decimal
    Public Property Importe() As Decimal
        Get
            Return _importe
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property
    Private _importeTipoCambio As Decimal
    Public Property ImporteTipoCambio() As Decimal
        Get
            Return _importeTipoCambio
        End Get
        Set(ByVal value As Decimal)
            _importeTipoCambio = value
        End Set
    End Property
    Private _kilate As String
    Public Property Kilate() As String
        Get
            Return _kilate
        End Get
        Set(ByVal value As String)
            _kilate = value
        End Set
    End Property
    Private _tipoCambiop As Decimal
    Public Property Tipocambio() As Decimal
        Get
            Return _tipoCambiop
        End Get
        Set(ByVal value As Decimal)
            _tipoCambiop = value
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
    Private _adelantos As Decimal
    Public Property Adelantos() As Decimal
        Get
            Return _adelantos
        End Get
        Set(ByVal value As Decimal)
            _adelantos = value
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
    Private _transferncia As Decimal
    Public Property Transferencia() As Decimal
        Get
            Return _transferncia
        End Get
        Set(ByVal value As Decimal)
            _transferncia = value
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
    Private _porPagar As Decimal
    Public Property Porpagar() As Decimal
        Get
            Return _porPagar
        End Get
        Set(ByVal value As Decimal)
            _porPagar = value
        End Set
    End Property
    Private _notaAdelanto As String
    Public Property NotaAdelanto() As String
        Get
            Return _notaAdelanto
        End Get
        Set(ByVal value As String)
            _notaAdelanto = value
        End Set
    End Property
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Private _saldo_adelanto As Decimal
    Public Property Saldo_adelanto() As Decimal
        Get
            Return _saldo_adelanto
        End Get
        Set(ByVal value As Decimal)
            _saldo_adelanto = value
        End Set
    End Property
    Public Property kilateValor As Decimal
    Public Property Margen As Decimal
    Public Property pesoTotal As Decimal
    Private _codMoneda As Integer
    Public Property CodMoneda() As Integer
        Get
            Return _codMoneda
        End Get
        Set(ByVal value As Integer)
            _codMoneda = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class

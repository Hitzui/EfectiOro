Public Class VistaMovCaja

    Private _anio As Integer
    Public Property Anio() As Integer
        Get
            Return _anio
        End Get
        Set(ByVal value As Integer)
            _anio = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Private _dia As Integer
    Public Property Dia() As Integer
        Get
            Return _dia
        End Get
        Set(ByVal value As Integer)
            _dia = value
        End Set
    End Property
    Private _mes As Integer
    Public Property Mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
        End Set
    End Property


    Private _Rubro As String
    Public Property Rubro() As String
        Get
            Return _Rubro
        End Get
        Set(ByVal value As String)
            _Rubro = value
        End Set
    End Property
    Private _descripcion As String
    Public Property Descripcoin() As String
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
    Private _caja As String
    Public Property Caja() As String
        Get
            Return _caja
        End Get
        Set(ByVal value As String)
            _caja = value
        End Set
    End Property
    Public Property Estado As Integer
    Public Property Hora As String

    Public Property Fecha As Date
End Class

Public Class SaldoCompra

    Private _mes As Integer
    Public Property mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
        End Set
    End Property


    Private _pesoC As Decimal
    Public Property pesoC() As Decimal
        Get
            Return _pesoC
        End Get
        Set(ByVal value As Decimal)
            _pesoC = value
        End Set
    End Property

    Private _valorC As Decimal
    Public Property valorC() As Decimal
        Get
            Return _valorC
        End Get
        Set(ByVal value As Decimal)
            _valorC = value
        End Set
    End Property
    
    Public Sub New()
        Me._mes = 0
        Me._pesoC = Decimal.Zero
        Me._valorC = Decimal.Zero
        
    End Sub
    Public Sub New(mes As Integer, ByVal pesoc As Decimal, valorc As Decimal, pesod As Decimal, valord As Decimal, pesos As Decimal, valors As Decimal)
        Me._mes = mes
        Me._pesoC = pesoc
        Me._valorC = valorc
    End Sub
End Class

Public Class SaldoDescargue
    Public Sub New()
        
    End Sub
    Private _mes As Integer
    Public Property mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
        End Set
    End Property

    Private _pesoD As Decimal
    Public Property pesoD() As Decimal
        Get
            Return _pesoD
        End Get
        Set(ByVal value As Decimal)
            _pesoD = value
        End Set
    End Property

    Private _valorD As Decimal
    Public Property valorD() As Decimal
        Get
            Return _valorD
        End Get
        Set(ByVal value As Decimal)
            _valorD = value
        End Set
    End Property

End Class
Public Class Saldo
    Public Sub New()
        _mes = 0
        _pesoS = Decimal.Zero
        _valoS = Decimal.Zero
    End Sub
    Private _mes As Integer
    Public Property mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
        End Set
    End Property

    Private _pesoS As Decimal
    Public Property pesoS() As Decimal
        Get
            Return _pesoS
        End Get
        Set(ByVal value As Decimal)
            _pesoS = value
        End Set
    End Property

    Private _valoS As Decimal
    Public Property valorS() As Decimal
        Get
            Return _valoS
        End Get
        Set(ByVal value As Decimal)
            _valoS = value
        End Set
    End Property

End Class
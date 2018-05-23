Namespace Database

    Public Class GeneralDescarguePorCompra
        'SELECT d.dgnumdes,cli.codcliente as numcliente, d.dgfecdes, c.numcompra, c.fecha, cli.nombres, " &
        'cli.apellidos, c.peso, c.total, d.dgcancom As Cantcompra " &
        'FROM dbo.descargues AS d INNER JOIN " &
        'dbo.compras As c On d.dgnumdes = c.dgnumdes " &
        'INNER JOIN Cliente As cli On c.codcliente = cli.codcliente " &
        'where d.dgnumdes = " & numdes & " order by numcompra asc")
        Public Sub New(dgnumdes As Integer,
                       numcliente As String,
                       dgfecdes As Date,
                       numcompra As String,
                       fecha As Date,
                       codcliente As String,
                       nombres As String,
                       apellidos As String,
                       peso As Decimal,
                       total As Decimal,
                       cantcompra As Integer)
            Me._numcliente = numcliente
            Me._dgnumdes = dgnumdes
            Me._dgfecdes = dgfecdes
            Me._numcompra = numcompra
            Me._fecha = fecha
            Me._nombres = nombres
            Me._apellidos = apellidos
            Me._peso = peso
            Me._total = total
            Me._Cantcompra = cantcompra
        End Sub
        Private _dgnumdes As Integer
        Public Property dgnumdes() As Integer
            Get
                Return _dgnumdes
            End Get
            Set(ByVal value As Integer)
                _dgnumdes = value
            End Set
        End Property
        Private _numcliente As String
        Public Property numcliente() As String
            Get
                Return _numcliente
            End Get
            Set(ByVal value As String)
                _numcliente = value
            End Set
        End Property
        Private _dgfecdes As Date
        Public Property dgfecdes() As Date
            Get
                Return _dgfecdes
            End Get
            Set(ByVal value As Date)
                _dgfecdes = value
            End Set
        End Property
        Private _numcompra As String
        Public Property numcompra() As String
            Get
                Return _numcompra
            End Get
            Set(ByVal value As String)
                _numcompra = value
            End Set
        End Property
        Private _fecha As Date
        Public Property fecha() As Date
            Get
                Return _fecha
            End Get
            Set(ByVal value As Date)
                _fecha = value
            End Set
        End Property

        Private _nombres As String
        Public Property nombres() As String
            Get
                Return _nombres
            End Get
            Set(ByVal value As String)
                _nombres = value
            End Set
        End Property
        Private _apellidos As String
        Public Property apellidos() As String
            Get
                Return _apellidos
            End Get
            Set(ByVal value As String)
                _apellidos = value
            End Set
        End Property
        Private _peso As Decimal
        Public Property peso() As Decimal
            Get
                Return _peso
            End Get
            Set(ByVal value As Decimal)
                _peso = value
            End Set
        End Property
        Private _total As Decimal
        Public Property total() As Decimal
            Get
                Return _total
            End Get
            Set(ByVal value As Decimal)
                _total = value
            End Set
        End Property
        Private _Cantcompra As Integer
        Public Property Cantcompra() As Integer
            Get
                Return _Cantcompra
            End Get
            Set(ByVal value As Integer)
                _Cantcompra = value
            End Set
        End Property

        Public Sub New()

        End Sub
    End Class
End Namespace

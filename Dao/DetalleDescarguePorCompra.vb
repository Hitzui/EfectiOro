Namespace Database
    ''' <summary>
    ''' Esto nos sirve para generar el reporte de detalle de descargue por compras.
    ''' </summary>
    Public Class DetalleDescarguePorCompra
        'Select Case d.dgnumdes, d.dgfecdes, c.numcompra, c.fecha, c.codcliente, cli.nombres, 
        'cli.apellidos, c.peso, c.total, d.dgcancom AS Cantcompra, dc.kilshowdoc, dc.peso, as detaPeso dc.importe
        'FROM dbo.descargues As d INNER JOIN
        'dbo.compras AS c ON d.dgnumdes = c.dgnumdes 
        'join det_compra As dc On c.numcompra = dc.numcompra
        'INNER JOIN Cliente As cli On c.codcliente = cli.codcliente
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
                       cantcompra As Integer,
                       kilshowdoc As String,
                       detapesoa As Decimal,
                       importe As Decimal)
            Me._numcliente = numcliente
            Me._dgnumdes = dgnumdes
            Me._dgfecdes = dgfecdes
            Me._numcompra = numcompra
            Me._fecha = fecha
            Me._codcliente = codcliente
            Me._nombres = nombres
            Me._apellidos = apellidos
            Me._peso = peso
            Me._total = total
            Me._Cantcompra = cantcompra
            Me._kilshowdoc = kilshowdoc
            Me._detaPeso = detapesoa
            Me._importe = importe
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
        Private _codcliente As String
        Public Property codcliente() As String
            Get
                Return _codcliente
            End Get
            Set(ByVal value As String)
                _codcliente = value
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
        Private _kilshowdoc As String
        Public Property kilshowdoc() As String
            Get
                Return _kilshowdoc
            End Get
            Set(ByVal value As String)
                _kilshowdoc = value
            End Set
        End Property
        Private _detaPeso As Decimal
        Public Property detaPeso() As Decimal
            Get
                Return _detaPeso
            End Get
            Set(ByVal value As Decimal)
                _detaPeso = value
            End Set
        End Property
        Private _importe As Decimal
        Public Property importe() As Decimal
            Get
                Return _importe
            End Get
            Set(ByVal value As Decimal)
                _importe = value
            End Set
        End Property
        Public Sub New()

        End Sub
    End Class
End Namespace

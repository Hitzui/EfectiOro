Imports Microsoft.Practices.Unity
Imports EfectiOro.Database

Module DataContext

    Dim contenedor As New UnityContainer()

    Sub New()
        contenedor.RegisterType(Of IDaoCliente, DaoCliente)()
        contenedor.RegisterType(Of IDaoPica, DaoPica)()
        contenedor.RegisterType(Of IDaoAgencia, DaoAgencia)()
        contenedor.RegisterType(Of IDaoCaja, DaoCaja)()
        contenedor.RegisterType(Of IDaoRubros, DaoRubro)()
        contenedor.RegisterType(Of IDaoMovimientosCaja, DaoMovimientosCaja)()
        contenedor.RegisterType(Of IDaoPreciosKilates, DaoPreciosKilates)()
        contenedor.RegisterType(Of IDaoTipoCambio, DaoTipoCambio)()
        contenedor.RegisterType(Of IDaoMaestroCaja, DaoMaestroCaja)()
        contenedor.RegisterType(Of IDaoAdelantos, DaoAdelantos)()
        contenedor.RegisterType(Of IDaoParametros, DaoParametros)()
        contenedor.RegisterType(Of IDaoCompras, DaoCompras)()
        contenedor.RegisterType(Of IDaoUsuario, DaoUsuario)()
        contenedor.RegisterType(Of IDaoDescargues, DaoDescargues)()
    End Sub

    Private _daoCliente As IDaoCliente
    Public ReadOnly Property daoCliente() As IDaoCliente
        Get
            _daoCliente = contenedor.Resolve(Of IDaoCliente)()
            Return _daoCliente
        End Get
    End Property

    Private _daoPica As IDaoPica
    Public ReadOnly Property daoPica() As IDaoPica
        Get
            _daoPica = contenedor.Resolve(Of IDaoPica)()
            Return _daoPica
        End Get
    End Property
    Public ReadOnly Property daoAgencia As IDaoAgencia
        Get
            Return contenedor.Resolve(Of IDaoAgencia)()
        End Get
    End Property
    Public ReadOnly Property daoCaja As IDaoCaja
        Get
            Return contenedor.Resolve(Of IDaoCaja)()
        End Get
    End Property
    Public ReadOnly Property daoRubro As IDaoRubros
        Get
            Return contenedor.Resolve(Of IDaoRubros)()
        End Get
    End Property
    Public ReadOnly Property daoMovimientosCaja As IDaoMovimientosCaja
        Get
            Return contenedor.Resolve(Of IDaoMovimientosCaja)()
        End Get
    End Property
    Public ReadOnly Property daoPrecioKilate As IDaoPreciosKilates
        Get
            Return contenedor.Resolve(Of IDaoPreciosKilates)()
        End Get
    End Property
    Public ReadOnly Property daoTipoCambio As IDaoTipoCambio
        Get
            Return contenedor.Resolve(Of IDaoTipoCambio)()
        End Get
    End Property
    Public ReadOnly Property daoMcaja As IDaoMaestroCaja
        Get
            Return contenedor.Resolve(Of IDaoMaestroCaja)()
        End Get
    End Property
    Public ReadOnly Property daoAdelantos As IDaoAdelantos
        Get
            Return contenedor.Resolve(Of IDaoAdelantos)()
        End Get
    End Property
    Public ReadOnly Property daoParametros As IDaoParametros
        Get
            Return contenedor.Resolve(Of IDaoParametros)()
        End Get
    End Property
    Public ReadOnly Property daoCompras As IDaoCompras
        Get
            Return contenedor.Resolve(Of IDaoCompras)()
        End Get
    End Property
    Public ReadOnly Property daoUsuario As IDaoUsuario
        Get
            Return contenedor.Resolve(Of IDaoUsuario)()
        End Get
    End Property
    Public ReadOnly Property daoDescargues As IDaoDescargues
        Get
            Return contenedor.Resolve(Of IDaoDescargues)()
        End Get
    End Property
    ''' <summary>
    ''' Definimos el usuario que ha accedido al sistema
    ''' </summary>
    ''' <remarks></remarks>
    Private _user As Usuario
    ''' <summary>
    ''' Usuario que ha accedido al sistema
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property usuarioLog As Usuario
        Get
            Return _user
        End Get
        Set(value As Usuario)
            _user = value
        End Set
    End Property
End Module

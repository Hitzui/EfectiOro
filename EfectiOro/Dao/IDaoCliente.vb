Imports EfectiOro.Database

Public Interface IDaoCliente

    Function codCliente() As String
    Function create(ByVal cliente As Cliente) As Boolean
    Function update(ByVal cliente As Cliente) As Boolean
    Function delete(ByVal cliente As Cliente) As Boolean
    Function findById(ByVal codcliente As String) As Cliente
    Function findAll() As List(Of Cliente)
    ''' <summary>
    ''' Recuperamos los clientes con Ado.Net
    ''' </summary>
    ''' <returns>Lista de Clientes</returns>
    ''' <remarks></remarks>
    Function recuperarTodosClientes() As List(Of Cliente)
    Function findByNombre(ByVal nombre As String) As Cliente
    Function findByApellido(ByVal apellido As String) As Cliente
    Function findByCedula(cedula As String) As Cliente
    Function filtrarPorNombre(ByVal nombre As String) As List(Of Cliente)
    Function filtrarPorCodigo(ByVal codigo As String) As List(Of Cliente)
    Function filtrarPorApellido(ByVal apellido As String) As List(Of Cliente)
    ''' <summary>
    ''' Recuperamos una lista de clientes filtrados por nombre utilizando Ado.Net
    ''' </summary>
    ''' <param name="nombre">Nombre del cliente</param>
    ''' <returns>Lista de clientes</returns>
    ''' <remarks></remarks>
    Function recuperarPorNombre(ByVal nombre As String) As List(Of Cliente)
    Property ErrorSms As String
    Function existeCliente(codcliente As String) As Boolean
    Function findAllClientesDS() As DataTable
    ''' <summary>
    ''' filtramos por nombre o apellidos
    ''' </summary>
    ''' <returns>Lista Clientes</returns>
    Function filtrarPorNombrePorApellido(filtro As String) As List(Of Cliente)
End Interface

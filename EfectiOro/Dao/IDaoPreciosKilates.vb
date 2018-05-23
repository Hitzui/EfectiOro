Imports EfectiOro.Database

Public Interface IDaoPreciosKilates
    Function findAll() As List(Of PrecioKilate)
    Function actualizar(precios As List(Of PrecioKilate)) As Boolean
    Function valoresPorDefault() As Boolean
    ReadOnly Property ErrorSms As String
    Function findByvDescripcion(descripcion As String) As PrecioKilate
    Function preciosClientes(codcliente As String) As List(Of Precios)
    Function listaPreciosCliente(codcliente As String) As List(Of Precios)
    Function findCierrePrecio(codcierre As Integer) As CierrePrecios
    Function listaCierresPreciosCliente(codcliente As String) As List(Of CierrePrecios)
End Interface

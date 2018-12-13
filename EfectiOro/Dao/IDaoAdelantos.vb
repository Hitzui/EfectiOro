Imports EfectiOro.Database

Public Interface IDaoAdelantos
    Function crearAdelanto(ByVal adelanto As Adelantos) As Boolean
    Function actualizarAdelanto(adelanto As Decimal, idsalida As String, numcompra As String) As Boolean
    Function findByCodigoCliente(codigo As String) As Adelantos
    Function findByCodigoAdelanto(codigo As String) As Adelantos
    Function findAll() As List(Of Adelantos)
    Function recpuerarCodigoAdelanto() As String
    ReadOnly Property ErrorSms As String
    Function listarAdelantosPorClientes(codigo As String) As List(Of Adelantos)
    Function anularAdelanto(codigo As String) As Boolean
    ''' <summary>
    ''' Esta funcion permite aplicar efectivo a un adelanto sin necesidad de pasar por compra
    ''' </summary>
    ''' <param name="listaAdelantos">Lista de adelantos</param>
    ''' <param name="monto">Monto a restar</param>
    ''' <param name="codcliente">Codigo del cliente</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function aplicarAdelantoEfectivo(listaAdelantos As List(Of Adelantos), monto As Decimal, Optional ByVal codcliente As String = "") As Boolean
    Function imprimir(codigo As String, nombre As String)
End Interface

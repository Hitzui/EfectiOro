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
    ''' <summary>
    ''' Filtrar adelantos por cliente y rando de fechas, esto filtra todos los adelantos, tenga o no saldo
    ''' </summary>
    ''' <param name="codigo">Codigo del cliente</param>
    ''' <param name="desde">Fecha desde</param>
    ''' <param name="hasta">Fecha hasta</param>
    ''' <returns>Lista de adelantos</returns>
    Function listarAdelantosPorClientes(codigo As String, desde As Date, hasta As Date) As List(Of Adelantos)
    Function anularAdelanto(codigo As String) As Boolean
    ''' <summary>
    ''' Esta funcion permite aplicar efectivo a un adelanto sin necesidad de pasar por compra
    ''' </summary>
    ''' <param name="listaAdelantos">Lista de adelantos</param>
    ''' <param name="monto">Monto a restar</param>
    ''' <param name="codcliente">Codigo del cliente</param>
    ''' <returns>Boolean</returns>
    ''' <remarks>Aplica efectivo a un adelanto sin una compra en especifico</remarks>
    Function aplicarAdelantoEfectivo(listaAdelantos As List(Of Adelantos), monto As Decimal, Optional ByVal codcliente As String = "") As Boolean
    Sub imprimir(codigo As String, nombre As String)
    ''' <summary>
    ''' Listar adelantos por fecha y por codigo del cliente
    ''' </summary>
    ''' <param name="desde">Date</param>
    ''' <param name="hasta">Date</param>
    ''' <param name="codcliente">String</param>
    ''' <returns>Lista de adelantos</returns>
    Function listarAdelantosPorFecha(desde As Date, hasta As Date, codcliente As String) As List(Of Adelantos)
    ''' <summary>
    ''' Buscar lista de adelantos por compras, kardex de adelantos
    ''' </summary>
    ''' <param name="idadelanto">Id Adelanto</param>
    ''' <returns>Lista de comrpas adelantos</returns>
    Function listarAdelantosComrpas(idadelanto As String) As List(Of Compras_adelantos)
    ''' <summary>
    ''' Recupera la lista de adelantos aplicados por compras segun el cliente indicado
    ''' </summary>
    ''' <param name="codcliente">Codigo del cliente</param>
    ''' <returns>Lista de compras-adelantos</returns>
    Function listarAdelantosComrpasCliente(codcliente As String) As List(Of Compras_adelantos)
End Interface

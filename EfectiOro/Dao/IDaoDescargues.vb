Imports EfectiOro.Database

Public Interface IDaoDescargues

    Function generarLote(ByVal fecha As Date, agencia As String) As List(Of Compras)
    Function guardarLoteGenerado(descargue As Descargues) As Boolean
    ReadOnly Property ErrorSms As String
    Function numeroDeDescargue() As Integer
    Function verLotesDescargados(desde As Date, hasta As Date) As List(Of Descargues)
    Function verDescarguesCompras(numdes As Integer) As List(Of Compras)
    Function verDescarguesCompras(desde As Date, hasta As Date) As List(Of Compras)
    ''' <summary>
    ''' Buscar Descargue por numero de Descargue
    ''' </summary>
    ''' <param name="numdes"></param>
    ''' <returns></returns>
    Function buscarDescarguesPorNumero(numdes As Integer) As Descargues
    ''' <summary>
    ''' Busca el detalle de descargue por compra
    ''' </summary>
    ''' <param name="numdes"></param>
    ''' <returns></returns>
    Function buscarDetalleDescarguePorCompra(numdes As Integer) As List(Of DetalleDescarguePorCompra)
    ''' <summary>
    ''' Generar reporte de descargues por compra general
    ''' </summary>
    ''' <param name="numdes"></param>
    ''' <returns></returns>
    Function buscarGeneralDescarguePorCompra(numdes As Integer) As List(Of GeneralDescarguePorCompra)
    ''' <summary>
    ''' Este metodo se utiliza para escoger de una compra la linea a descargar de su detalle, no toda la compra, sino de forma parcial.
    ''' </summary>
    ''' <param name="numcompra"></param>
    ''' <param name="detaCompra"></param>
    ''' <returns></returns>
    Function guardarDescargueDetalleCompra(numcompra As String, detaCompra As List(Of Det_compra)) As Boolean
    ''' <summary>
    ''' Recuperamos las compras por fecha, pero no como una lista sino como dataset
    ''' </summary>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    Function generarLoteTabla(fecha As Date) As DataSet
    ''' <summary>
    ''' Guardamos el lote generado por detalle de compra seleccionado
    ''' </summary>
    ''' <param name="detalle"></param>
    ''' <param name="descargue"></param>
    ''' <returns></returns>
    Function guardarLotoeDetaCompra(ByVal detalle As List(Of KeyValuePair(Of String, Integer)), descargue As Descargues) As Boolean
    ''' <summary>
    ''' Function que nos regresa una lista de los saldos referente a las compras comparados con los descargues por mes
    ''' </summary>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function reporteSaldoCompraDescargues(fecha As Date) As List(Of SaldoCompra)
End Interface

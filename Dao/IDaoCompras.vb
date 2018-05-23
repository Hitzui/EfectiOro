Imports EfectiOro.Database

Public Interface IDaoCompras
    Sub imprimirCompra(numero_compra As String)
    ''' <summary>
    ''' Creamos la compra junto con el detalle
    ''' </summary>
    ''' <param name="compra">Compras</param>
    ''' <param name="detaCompras">List(Of Det_Compra)</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Function crearCompra(compra As Compras, detaCompras As List(Of Det_compra), Optional ByVal modcaja As Mcaja = Nothing, Optional ByVal dcaja As Detacaja = Nothing, Optional ByVal listaAdelantos As List(Of Adelantos) = Nothing) As Boolean
    Function actualizarCompraDescargue(compra As Compras) As Boolean
    Function codigoCompra() As String
    ReadOnly Property ErrorSms As String
    Function findDetaCompra(numcompra As String) As List(Of Det_compra)
    Function findCompraById(numerocompra As String) As Compras
    Function actualizarCompra(compra As Compras, detacompras As List(Of Det_compra)) As Boolean
    ''' <summary>
    ''' Anular la compra seleccionada
    ''' </summary>
    ''' <param name="numeroCompra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function anularCompra(numeroCompra As String) As Boolean
    ''' <summary>
    ''' Recuperamos la lista de compras segun el cliente
    ''' </summary>
    ''' <param name="codCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function findComprasByCodigoCliente(codCliente As String) As List(Of Compras)
    ''' <summary>
    ''' Esta función es para actualizar la compra en el caso de que sea pendiente de cierre
    ''' Ya que esta funcion solo actualiza los valores de efectivo, transferencia, cheque y adelanto
    ''' </summary>
    ''' <param name="compra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function actualizarCompra(compra As Compras) As Boolean
End Interface

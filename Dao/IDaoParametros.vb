Imports EfectiOro.Database

Public Interface IDaoParametros

    Function recuperarParametros() As Ids
    Function actualizarParametros(param As Ids) As Boolean
    Function crearParametros(parametros As Ids) As Boolean
    ''' <summary>
    ''' De esta manera los precios de oro no volveran a los defualts
    ''' al menos que el usuario indique lo contrario.
    ''' Así se podrán realizar compras sin que se espere a que otro
    ''' usuario termine la compra.
    ''' </summary>
    ''' <returns>True, habilitar varias compras</returns>
    ''' <remarks></remarks>
    Function habilitarVariasCompras(opcion As Integer) As Boolean

End Interface

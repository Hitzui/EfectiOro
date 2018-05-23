Imports EfectiOro.Database

Public Interface IDaoTipoCambio

    Function modificarValor(tipo As TipoCambio) As Boolean

    Function findAll() As List(Of TipoCambio)
    ''' <summary>
    ''' Buscamos los tipos de cambio respectivo al mes en el que nos encontramos
    ''' </summary>
    ''' <returns>Lista de Tipos de Cambios</returns>
    ''' <remarks></remarks>
    Function findAllByMes() As List(Of TipoCambio)
    Function findAllByMes(mes As Date) As List(Of TipoCambio)
    Function grabarDatos(tipoCambioLista As List(Of TipoCambio)) As Boolean
    Function ingresarDato(tipoCambio As TipoCambio) As Boolean
    Function modificarValor(hora As String, fecha As Date, tc As Decimal) As Boolean
    Function eliminarValor(tipoCambio As TipoCambio) As Boolean
    Function buscarDato(fecha As Date) As TipoCambio
    ReadOnly Property ErrorSms As String
    ''' <summary>
    ''' Grabamos el valor del oro, segun la fecha del tipo de cambio
    ''' </summary>
    ''' <param name="valor">Valor del oro</param>
    ''' <param name="fecha">Fecha indicada</param>
    ''' <returns>True si se guarda</returns>
    ''' <remarks></remarks>
    Function grabarValorOro(valor As Decimal, fecha As Date) As Boolean
End Interface

Imports EfectiOro.Database

Public Interface IDaoReservaOro
    ReadOnly Property ErrorS As String
    Function save(reserva As ReservaOro, detaReserva As DetaReserva) As Boolean
    Function edit(reserva As ReservaOro, detaReserva As DetaReserva) As Boolean
    Function findAll() As List(Of ReservaOro)
    Function findByCliente(codcliente As String) As List(Of ReservaOro)
    Function findSaldoReserva(idreserva As Integer) As DetaReserva
    Function findReserva(idreserva As Integer) As ReservaOro
    Function cerrar(reserva As ReservaOro) As Boolean

    Function findDetaReserva(idreserva As Integer) As List(Of DetaReserva)
    ''' <summary>
    ''' Filtrar las reservas de oro segun la fecha de reserva
    ''' </summary>
    ''' <param name="desde">Desde</param>
    ''' <param name="hasta">Hasta</param>
    ''' <returns>Lista de reservas</returns>
    Function buscarReservasFecha(desde As Date, hasta As Date) As List(Of ReservaOro)
    ''' <summary>
    ''' Filtrar detareservas por fecha
    ''' </summary>
    ''' <param name="desde">Desde</param>
    ''' <param name="hasta">Hasta</param>
    ''' <returns>List de DetaReservas</returns>
    Function buscarDetaReservasFecha(desde As Date, hasta As Date) As List(Of DetaReserva)
End Interface

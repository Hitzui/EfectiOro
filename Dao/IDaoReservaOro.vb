Imports EfectiOro.Database

Public Interface IDaoReservaOro
    ReadOnly Property ErrorS As String
    Function save(reserva As ReservaOro, detaReserva As DetaReserva) As Boolean
    Function edit(reserva As ReservaOro, detaReserva As DetaReserva) As Boolean
    Function findAll() As List(Of ReservaOro)
    Function findByCliente(codcliente As String) As List(Of ReservaOro)
    Function findSaldoReserva(idreserva As Integer) As DetaReserva
    Function findReserva(idreserva As Integer) As ReservaOro
End Interface

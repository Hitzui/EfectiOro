Imports EfectiOro.Database

Public Interface IDaoMovimientosCaja
    Function create(movcaja As Movcaja) As Boolean
    Function update(movcaja As Movcaja) As Boolean
    Function delete(movcaja As Movcaja) As Boolean
    Function findAll() As List(Of Movcaja)
    Function findByCod(idmov As Integer) As Movcaja
    ReadOnly Property ErrorSms As String
End Interface

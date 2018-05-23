Imports EfectiOro.Database

Public Interface IDaoPica
    Function create(ByVal pica As Pica) As Boolean
    Function update(pica As List(Of Pica)) As Boolean
    Function delete(ByVal pica As Pica) As Boolean
    Function deleteByCodCliente(ByVal codcliente As String) As Boolean
    Function findById(ByVal codcliente As String) As List(Of Pica)
    Property ErrorSms As String
End Interface

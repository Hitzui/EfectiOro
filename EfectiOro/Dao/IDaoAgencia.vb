Imports EfectiOro.Database

Public Interface IDaoAgencia
    Function codigoAgencia() As String
    Function create(agencia As Agencia) As Boolean
    Function update(agencia As Agencia) As Boolean
    Function delete(agencia As Agencia) As Boolean
    Function findAll() As List(Of Agencia)
    Function findById(codagencia As String) As Agencia
    Function filtrarPorNombre(nomagencia As String) As List(Of Agencia)
    Property ErrorSms() As String
End Interface

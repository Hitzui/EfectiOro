Imports EfectiOro.Database

Public Interface IDaoCaja
    Property ErrorSms As String
    Function create(caja As Caja) As Boolean
    Function update(caja As Caja) As Boolean
    Function delete(caja As Caja) As Boolean
    Function findAll() As List(Of Caja)
    Function findByCod(codigo As String) As Caja
    Function codigoCaja() As String
End Interface

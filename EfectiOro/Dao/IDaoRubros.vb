Imports EfectiOro.Database

Public Interface IDaoRubros
    Function create(rubro As Rubro) As Boolean
    Function update(rubro As Rubro) As Boolean
    Function delete(rubro As Rubro) As Boolean
    Function findAll() As List(Of Rubro)
    Function findByCod(codrubro As Integer) As Rubro
    Property ErrorSms As String
End Interface

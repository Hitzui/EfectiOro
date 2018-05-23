Imports EfectiOro.Database
Imports LinqToExcel

Public Class LeerExcel
    Public Function leerHoja(ByVal path As String) As IList(Of Excel)
        Try
            Dim book As New ExcelQueryFactory(path)
            Dim result = (From row In book.Worksheet(Of Excel)("Archivo")
                          Select row).ToList()
            Return result
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
Public Class Excel
    Private _tipocambio As Decimal
    Public Property tipocambio() As Decimal
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Decimal)
            _tipocambio = value
        End Set
    End Property
    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

End Class

Imports EfectiOro.Database

Public Class DaoPreciosKilates
    Implements IDaoPreciosKilates
    Private _error As String
    Public Function valoresPorDefault() As Boolean Implements IDaoPreciosKilates.valoresPorDefault
        Using ctx As New Contexto
            Try
                ctx.ExecuteQuery(Of Integer)("update preciokilate set precio_kilate = 1")
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function actualizar(precios As System.Collections.Generic.List(Of Database.PrecioKilate)) As Boolean Implements IDaoPreciosKilates.actualizar
        Using ctx As New Contexto
            Try
                ctx.ExecuteQuery(Of Integer)("delete from preciokilate")
                For Each valor In precios
                    ctx.PrecioKilate.InsertOnSubmit(valor)
                Next
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public ReadOnly Property ErrorSms As String Implements IDaoPreciosKilates.ErrorSms
        Get
            Return _error
        End Get
    End Property
    Public Function findByvDescripcion(descripcion As String) As PrecioKilate Implements IDaoPreciosKilates.findByvDescripcion
        Using ctx As New Contexto
            Try
                Dim find = (From p In ctx.PrecioKilate Where p.Kilate_peso = descripcion Select p).First()
                Return find
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function findAll() As System.Collections.Generic.List(Of Database.PrecioKilate) Implements IDaoPreciosKilates.findAll
        Using ctx As New Contexto
            Dim buscarTodos = (From pk As PrecioKilate In ctx.PrecioKilate
                               Order By pk.Kilate_peso Ascending
                               Select pk).ToList
            Return buscarTodos
        End Using
    End Function
End Class

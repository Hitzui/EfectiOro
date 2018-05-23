Imports EfectiOro.Database

Public Class DaoRubro
    Implements IDaoRubros
    Private _error As String
    Public Function create(rubro As Database.Rubro) As Boolean Implements IDaoRubros.create
        Using ctx As New Contexto()
            Try
                ctx.Rubro.InsertOnSubmit(rubro)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function delete(rubro As Database.Rubro) As Boolean Implements IDaoRubros.delete
        Using ctx As New Contexto()
            Try
                Dim buscar = (From r In ctx.Rubro Where r.Codrubro = rubro.Codrubro Select r).First()
                ctx.Rubro.DeleteOnSubmit(buscar)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Property ErrorSms As String Implements IDaoRubros.ErrorSms
        Get
            Return _error
        End Get
        Set(value As String)
            _error = value
        End Set
    End Property

    Public Function findAll() As System.Collections.Generic.List(Of Database.Rubro) Implements IDaoRubros.findAll
        Using ctx As New Contexto()
            Return ctx.Rubro.ToList()
        End Using
    End Function

    Public Function findByCod(codrubro As Integer) As Database.Rubro Implements IDaoRubros.findByCod
        Using ctx As New Contexto()
            Try
                Dim buscar = (From r In ctx.Rubro Where r.Codrubro = codrubro Select r).First()
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function update(rubro As Database.Rubro) As Boolean Implements IDaoRubros.update
        Using ctx As New Contexto()
            Try
                Dim buscar = (From r In ctx.Rubro Where r.Codrubro = rubro.Codrubro Select r).First()
                buscar.Descrubro = rubro.Descrubro
                buscar.Naturaleza = rubro.Naturaleza
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
End Class

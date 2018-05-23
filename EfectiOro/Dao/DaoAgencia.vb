Imports System.Data.Linq.SqlClient
Imports EfectiOro.Database

Public Class DaoAgencia
    Implements IDaoAgencia

    Public Function codigoAgencia() As String Implements IDaoAgencia.codigoAgencia
        Using ctx As New Contexto
            Try
                Dim var = (From id In ctx.Ids Where id.Codagencia > 0
                           Select id).Single()
                Return "A" & Convert.ToString(var.Codagencia).PadLeft(3, "0")
            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    Public Function create(agencia As Agencia) As Boolean Implements IDaoAgencia.create
        Using ctx As New Contexto()
            Try
                ctx.Agencia.InsertOnSubmit(agencia)
                'ctx.ExecuteQuery(Of Integer)("update ids set codagencia = codagencia +1")
                Dim id = (From cod In ctx.Ids Where cod.Codagencia > 0
                         Select cod).Single()
                id.Codagencia = id.Codagencia + 1
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function delete(agencia As Agencia) As Boolean Implements IDaoAgencia.delete
        Using ctx As New Contexto()
            Try
                Dim var = (From a In ctx.Agencia Where a.Codagencia = agencia.Codagencia
                           Select a).First()
                ctx.Agencia.DeleteOnSubmit(var)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Private _error As String
    Public Property ErrorSms As String Implements IDaoAgencia.ErrorSms
        Get
            Return _error
        End Get
        Set(value As String)
            _error = value
        End Set
    End Property

    Public Function filtrarPorNombre(nomagencia As String) As System.Collections.Generic.List(Of Agencia) Implements IDaoAgencia.filtrarPorNombre
        Using ctx As New Contexto()
            Dim var = (From a In ctx.Agencia
                       Where SqlMethods.Like(a.Nomagencia, "%" & nomagencia & "%")
                       Select a).ToList()
            Return var
        End Using
    End Function

    Public Function findAll() As System.Collections.Generic.List(Of Agencia) Implements IDaoAgencia.findAll
        Using ctx As New Contexto()
            Return ctx.Agencia.ToList()
        End Using
    End Function

    Public Function findById(codagencia As String) As Agencia Implements IDaoAgencia.findById
        Using ctx As New Contexto()
            Try
                Dim var = (From a In ctx.Agencia
                           Where a.Codagencia = codagencia
                           Select a).First()
                Return var
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function update(agencia As Agencia) As Boolean Implements IDaoAgencia.update
        Using ctx As New Contexto()
            Try
                Dim var = (From a In ctx.Agencia Where a.Codagencia = agencia.Codagencia
                           Select a).First
                var.Nomagencia = agencia.Nomagencia
                var.Diragencia = agencia.Diragencia
                var.Disagencia = agencia.Disagencia
                var.Telagencia = agencia.Telagencia
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
End Class

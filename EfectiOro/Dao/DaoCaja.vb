Imports EfectiOro.Database
Imports System.Data.Linq

Public Class DaoCaja
    Implements IDaoCaja

    Private _error As String

    ''' <summary>
    ''' Consulta compilada para recuprar la caja por codigo
    ''' </summary>
    ''' <remarks></remarks>
    Public cajaPorCodigo As Func(Of Contexto, String, IQueryable(Of Caja)) = _
        CompiledQuery.Compile(Function(db As Contexto, codigo As String) _
                                  From c In db.Caja Where c.Codcaja = codigo Select c)


    Public Function codigoCaja() As String Implements IDaoCaja.codigoCaja
        Using ctx As New Contexto()
            Try
                Dim var = (From c In ctx.Caja Order By c.Codcaja Descending Select c).First()
                Dim cod = Convert.ToInt32(var.Codcaja.Substring(1)) + 1
                Return "C" + Convert.ToString(cod).PadLeft(2, "0")
            Catch ex As Exception
                Return "C01"
            End Try
        End Using
    End Function

    Public Function create(caja As Efectioro.Database.Caja) As Boolean Implements IDaoCaja.create
        Using ctx As New Contexto()
            Try
                ctx.Caja.InsertOnSubmit(caja)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function delete(caja As Efectioro.Database.Caja) As Boolean Implements IDaoCaja.delete
        Using ctx As New Contexto()
            Try
                Dim buscar = cajaPorCodigo(ctx, caja.Codcaja).Single()
                ctx.Caja.DeleteOnSubmit(buscar)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Property ErrorSms As String Implements IDaoCaja.ErrorSms
        Get
            Return _error
        End Get
        Set(value As String)
            _error = value
        End Set
    End Property

    Public Function findAll() As System.Collections.Generic.List(Of Efectioro.Database.Caja) Implements IDaoCaja.findAll
        Using ctx As New Contexto()
            Return ctx.Caja.ToList()
        End Using
    End Function

    Public Function findByCod(codigo As String) As Efectioro.Database.Caja Implements IDaoCaja.findByCod
        Using ctx As New Contexto()
            Try
                Dim var = (From c In ctx.Caja Where c.Codcaja = codigo Select c).First()
                Return var
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function update(caja As Efectioro.Database.Caja) As Boolean Implements IDaoCaja.update
        Using ctx As New Contexto()
            Try
                Dim buscar = cajaPorCodigo(ctx, caja.Codcaja).First()
                buscar.Descripcion = caja.Descripcion
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
End Class

Imports EfectiOro.Database
Imports System.Data.Linq

Public Class DaoMovimientosCaja
    Implements IDaoMovimientosCaja

    Private _error As String
    Private findById As Func(Of Contexto, Integer, IQueryable(Of Movcaja)) = _
        CompiledQuery.Compile(Function(db As Contexto, codigo As Integer) _
                                  From mov In db.Movcaja Where mov.Idmov = codigo Select mov)
    Public Function create(movcaja As Database.Movcaja) As Boolean Implements IDaoMovimientosCaja.create
        Using ctx As New Contexto
            Try
                ctx.Movcaja.InsertOnSubmit(movcaja)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function delete(movcaja As Database.Movcaja) As Boolean Implements IDaoMovimientosCaja.delete
        Using ctx As New Contexto
            Try
                Dim var = findById(ctx, movcaja.Idmov).First()
                ctx.Movcaja.DeleteOnSubmit(var)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public ReadOnly Property ErrorSms As String Implements IDaoMovimientosCaja.ErrorSms
        Get
            Return _error
        End Get
    End Property

    Public Function findAll() As System.Collections.Generic.List(Of Database.Movcaja) Implements IDaoMovimientosCaja.findAll
        Using ctx As New Contexto
            Return ctx.Movcaja.ToList()
        End Using
    End Function

    Public Function findByCod(idmov As Integer) As Database.Movcaja Implements IDaoMovimientosCaja.findByCod
        Using ctx As New Contexto
            Return Me.findById(ctx, idmov)
        End Using
    End Function

    Public Function update(movcaja As Database.Movcaja) As Boolean Implements IDaoMovimientosCaja.update
        Using ctx As New Contexto
            Try
                Dim var = findById(ctx, movcaja.Idmov).Single()
                var.Descripcion = movcaja.Descripcion
                var.Codrubro = movcaja.Codrubro
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
End Class

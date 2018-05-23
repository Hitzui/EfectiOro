Imports EfectiOro.Database

Public Class DaoTipoCambio
    Implements IDaoTipoCambio

    Private _error As String


    Public Function buscarDato(fecha As Date) As Database.TipoCambio Implements IDaoTipoCambio.buscarDato
        Using ctx As New Contexto
            Try
                Dim valor = (From t In ctx.TipoCambio Where t.Fecha = fecha Select t).First()
                Return valor
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function eliminarValor(tipoCambio As Database.TipoCambio) As Boolean Implements IDaoTipoCambio.eliminarValor
        Using ctx As New Contexto
            Try
                Dim valor = (From t In ctx.TipoCambio
                             Where t.Fecha = tipoCambio.Fecha And
                             t.Hora = tipoCambio.Hora And
                             t.Tipocambio1 = tipoCambio.Tipocambio1
                             Select t).First()
                ctx.TipoCambio.DeleteOnSubmit(valor)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public ReadOnly Property ErrorSms As String Implements IDaoTipoCambio.ErrorSms
        Get
            Return _error
        End Get
    End Property

    Public Function findAllByMes() As List(Of TipoCambio) Implements IDaoTipoCambio.findAllByMes
        Using ctx As New Contexto
            Dim query = (From tc As TipoCambio In ctx.TipoCambio
                         Where tc.Fecha.Month = Now.Month
                         Order By tc.Fecha Select tc).ToList()
            Return query
        End Using
    End Function
    Public Function findAllByMes(mes As Date) As List(Of TipoCambio) Implements IDaoTipoCambio.findAllByMes
        Using ctx As New Contexto
            Dim query = (From tc As TipoCambio In ctx.TipoCambio
                         Where tc.Fecha.Month = mes.Month And tc.Fecha.Year = mes.Year
                         Order By tc.Fecha Select tc).ToList()
            Return query
        End Using
    End Function

    Public Function findAll() As System.Collections.Generic.List(Of Database.TipoCambio) Implements IDaoTipoCambio.findAll
        Using ctx As New Contexto
            Dim query = (From tc As TipoCambio In ctx.TipoCambio
                         Order By tc.Fecha Select tc).ToList()
            Return query
        End Using
    End Function

    Public Function grabarDatos(tipoCambioLista As System.Collections.Generic.List(Of Database.TipoCambio)) As Boolean Implements IDaoTipoCambio.grabarDatos
        Using ctx As New Contexto
            Try
                For Each valor As TipoCambio In tipoCambioLista
                    ctx.TipoCambio.InsertOnSubmit(valor)
                Next
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function ingresarDato(tipoCambio As Database.TipoCambio) As Boolean Implements IDaoTipoCambio.ingresarDato
        Using ctx As New Contexto
            Try
                ctx.TipoCambio.InsertOnSubmit(tipoCambio)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function modificarValor(tipo As Database.TipoCambio) As Boolean Implements IDaoTipoCambio.modificarValor
        Using ctx As New Contexto
            Try
                Dim findTipo = (From tc In ctx.TipoCambio Where tc.Fecha = tipo.Fecha Select tc).First()
                If IsNothing(findTipo) = True Then
                    Me._error = "No existe el tipo de cambio para esta fecha indicada"
                    Return False
                End If
                findTipo.Tipocambio1 = tipo.Tipocambio1
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                Me._error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function modificarValor(hora As String, fecha As Date, tc As Decimal) As Boolean Implements IDaoTipoCambio.modificarValor
        Using ctx As New Contexto
            Try
                ctx.ExecuteQuery(Of Integer)("update tipocambio set tipocambio = " & tc & _
                                             " where fecha = '" & fecha & "' and hora = '" & _
                                             hora & "'")
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function grabarValorOro(valor As Decimal, fecha As Date) As Boolean Implements IDaoTipoCambio.grabarValorOro
        Using ctx As New Contexto
            Dim buscar As TipoCambio
            Try
                buscar = (From tc In ctx.TipoCambio
                         Where tc.Fecha = fecha
                         Select tc).First()
                buscar.Precio_oro = valor
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = "No se puede ingresar el valor del oro, primero ingrese el valor del dolar para el día indicado."
                Return False
            End Try
        End Using
    End Function
End Class

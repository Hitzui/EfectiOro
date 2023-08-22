Imports EfectiOro
Imports EfectiOro.Database

Public Class DaoReservaOro
    Implements IDaoReservaOro
    Private _error As String
    Public ReadOnly Property ErrorS As String Implements IDaoReservaOro.ErrorS
        Get
            Return _error
        End Get
    End Property
    Public Function buscarDetaReservasFecha(desde As Date, hasta As Date) As List(Of DetaReserva) Implements IDaoReservaOro.buscarDetaReservasFecha
        Using ctx As New Contexto
            Try
                Dim buscar = (From dr In ctx.DetaReserva
                              Where dr.fecha <= hasta And dr.fecha >= desde
                              Select dr).ToList
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return New List(Of DetaReserva)
            End Try
        End Using
    End Function
    Public Function buscarReservasFecha(desde As Date, hasta As Date) As List(Of ReservaOro) Implements IDaoReservaOro.buscarReservasFecha
        Using ctx As New Contexto
            Try
                Dim buscar = (From r In ctx.ReservaOro
                              Where r.FechaReserva <= hasta And r.FechaReserva >= desde
                              Select r).ToList
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return New List(Of ReservaOro)
            End Try
        End Using
    End Function
    Public Function cerrar(reserva As ReservaOro) As Boolean Implements IDaoReservaOro.cerrar
        Using ctx As New Contexto
            Try
                Dim findReserva = (From r In ctx.ReservaOro Where r.Idreserva = reserva.Idreserva Select r).First
                findReserva.Estado = False
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function edit(reserva As ReservaOro, detaReserva As DetaReserva) As Boolean Implements IDaoReservaOro.edit
        Using ctx As New Contexto
            Try
                'ctx.ReservaOro.InsertOnSubmit(reserva)
                Dim linea As Integer = 0
                Dim contar = Me.findDetaReserva(reserva.Idreserva).Count
                linea = contar + 1
                detaReserva.linea = linea
                detaReserva.idreserva = reserva.Idreserva
                ctx.DetaReserva.InsertOnSubmit(detaReserva)
                Dim onzas_dif As Decimal = Decimal.Zero
                'If reserva.Onzas <> Me.findReserva(reserva.Idreserva).Onzas Then
                ctx.ReservaOro.Attach(reserva, Me.findReserva(reserva.Idreserva))
                Dim saldoOnzas As Decimal = Me.findSaldoReserva(reserva.Idreserva).diferencia
                onzas_dif = Decimal.Subtract(saldoOnzas, detaReserva.entregadas)
                Dim act_detaReserva = (From d In ctx.DetaReserva Where d.idreserva = reserva.Idreserva Select d).ToList
                'For Each dato In act_detaReserva
                '    dato.diferencia = dato.diferencia + onzas_dif
                'Next
                'End If
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function findAll() As List(Of ReservaOro) Implements IDaoReservaOro.findAll
        Using ctx As New Contexto
            Try
                Return ctx.ReservaOro.ToList
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function findByCliente(codcliente As String) As List(Of ReservaOro) Implements IDaoReservaOro.findByCliente
        Using ctx As New Contexto
            Try
                Dim buscar As List(Of ReservaOro) = (From r In ctx.ReservaOro Where r.Codcliente = codcliente And r.Estado = True Order By r.Idreserva Ascending Select r).ToList
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    
    Public Function save(reserva As ReservaOro, detaReserva As DetaReserva) As Boolean Implements IDaoReservaOro.save
        Using ctx As New Contexto
            Try
                Dim idreserva As Integer = 0
                Dim parametro = (From id As Ids In ctx.Ids Where id.Idreserva > 0 Select id).Single
                idreserva = parametro.Idreserva
                reserva.Idreserva = idreserva
                ctx.ReservaOro.InsertOnSubmit(reserva)
                Dim linea As Integer = 0
                Dim contar As Integer = 0
                Try
                    contar = Me.findDetaReserva(reserva.Idreserva).Count
                Catch ex As Exception
                    contar = 0
                End Try
                linea = contar + 1
                detaReserva.linea = linea
                detaReserva.idreserva = idreserva
                detaReserva.diferencia = reserva.Onzas
                idreserva += 1
                ctx.DetaReserva.InsertOnSubmit(detaReserva)
                If ctx.ExecuteCommand(String.Format("update Ids set idreserva = {0}", idreserva)) > 0 Then
                    ctx.SubmitChanges()
                Else
                    _error = "No se pudo actualizar el identificador de la llave primaria en la tabla IDS, revisra dicha tabla, ver si se actualiza"
                End If
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function findReserva(idreserva As Integer) As ReservaOro Implements IDaoReservaOro.findReserva
        Using ctx As New Contexto
            Try
                Dim buscar = (From r In ctx.ReservaOro Where r.Idreserva = idreserva Select r)
                Return buscar.Single
            Catch ex As Exception
                _error = ex.Message
                Return New ReservaOro
            End Try
        End Using
    End Function
    Public Function findSaldoReserva(idreserva As Integer) As DetaReserva Implements IDaoReservaOro.findSaldoReserva
        Using ctx As New Contexto
            Try
                Dim buscar = (From d In ctx.DetaReserva Where d.idreserva = idreserva Order By d.linea Descending Select d).First
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return New DetaReserva
            End Try
        End Using
    End Function
    Public Function findDetaReserva(idreserva As Integer) As List(Of DetaReserva) Implements IDaoReservaOro.findDetaReserva
        Using ctx As New Contexto
            Try
                Dim buscar = (From dr As DetaReserva In ctx.DetaReserva
                              Where dr.idreserva = idreserva
                              Select dr).ToList
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
End Class

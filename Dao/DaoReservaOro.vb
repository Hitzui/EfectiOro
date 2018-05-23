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
                If reserva.Onzas <> Me.findReserva(reserva.Idreserva).Onzas Then
                    ctx.ReservaOro.Attach(reserva, Me.findReserva(reserva.Idreserva))
                    onzas_dif = Decimal.Subtract(reserva.Onzas, Me.findReserva(reserva.Idreserva).Onzas)
                    Dim act_detaReserva = (From d In ctx.DetaReserva Where d.idreserva = reserva.Idreserva Select d).ToList
                    For Each dato In act_detaReserva
                        dato.diferencia = dato.diferencia + onzas_dif
                    Next
                End If
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
                Dim parametro = ctx.Ids.Single()
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
                parametro.Idreserva += 1
                ctx.DetaReserva.InsertOnSubmit(detaReserva)
                ctx.SubmitChanges()
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
            End Try
        End Using
    End Function
    Public Function findDetaReserva(idreserva As Integer) As List(Of DetaReserva)
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

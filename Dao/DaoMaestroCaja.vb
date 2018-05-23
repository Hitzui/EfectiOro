Imports EfectiOro.Database

Public Class DaoMaestroCaja
    Implements IDaoMaestroCaja

    Private _error As String
    Public ReadOnly Property ErrorSms As String Implements IDaoMaestroCaja.ErrorSms
        Get
            Return _error
        End Get
    End Property
    Public Function validarCajaAbierta(ByVal caja As String) As Boolean Implements IDaoMaestroCaja.validarCajaAbierta
        Using ctx As New Contexto
            Try
                Dim xcaja = (From c In ctx.Mcaja
                             Where c.Codcaja = caja And c.Estado = 1
                             Order By c.Idcaja Descending
                             Select c).First()
                If xcaja.Fecha.Value.Day = DateTime.Now.Day Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function estadoCaja(ByVal caja As String) As Boolean Implements IDaoMaestroCaja.estadoCaja
        Using ctx As New Contexto
            Try
                Dim xcaja = (From c In ctx.Mcaja
                             Where c.Codcaja = caja
                             Order By c.Idcaja Descending
                             Select c).First()
                If xcaja.Estado = 1 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function abrirCaja(caja As String, agencia As String) As Boolean Implements IDaoMaestroCaja.abrirCaja
        Using ctx As New Contexto
            Try
                Dim xestado As New Mcaja
                Try
                    xestado = (From c In ctx.Mcaja
                               Where c.Codcaja = caja And c.Codagencia = agencia
                               Order By c.Idcaja Descending
                               Select c).First()
                Catch ex As Exception
                    xestado.Sfinal = 0
                    xestado.Sinicial = 0
                    xestado.Estado = 0
                    xestado.Idcaja = 0
                    xestado.Fecha = Date.Now
                End Try
                If xestado.Estado = 1 Then
                    Return False
                End If
                Dim daoIds = DataContext.daoParametros
                Dim parametros As Ids = daoIds.recuperarParametros()
                'sumamos uno al idcaja el cual es el que controla los registros
                Dim sumid As Integer = xestado.Idcaja + 1
                Dim crearM As New Mcaja
                Dim dcaja As New Detacaja()
                'creamos el detalle de caja, en el maestro de caja
                'como en la tabla detacaja
                crearM.Idcaja = sumid
                crearM.Codcaja = caja
                crearM.Codagencia = agencia
                crearM.Entrada = 0
                crearM.Salida = 0
                crearM.Fecha = Now
                crearM.Estado = 1
                crearM.Sinicial = xestado.Sfinal
                crearM.Sfinal = xestado.Sfinal
                'detalle de la caja
                dcaja.Idcaja = crearM.Idcaja
                dcaja.fecha = DateTime.Now
                dcaja.Concepto = "***APERTURA DE CAJA***"
                dcaja.Transferencia = 0
                dcaja.Cheque = 0
                dcaja.Hora = Now.ToLongTimeString()
                dcaja.Idmov = parametros.Saldo_anterior
                dcaja.Referencia = String.Empty
                dcaja.Codcaja = caja
                If xestado.Fecha.Value.Day = Now.Day Then
                    dcaja.Efectivo = 0
                Else
                    dcaja.Efectivo = crearM.Sfinal
                End If
                ctx.Detacaja.InsertOnSubmit(dcaja)
                ctx.Mcaja.InsertOnSubmit(crearM)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function cerrarCaja(caja As String) As Boolean Implements IDaoMaestroCaja.cerrarCaja
        Using ctx As New Contexto
            Try
                If Me.validarPrestamosPuentes() <> 0 Then
                    _error = "La diferencia entre el prestamo puente egreso e ingreso es: " & Me.validarPrestamosPuentes().ToString("#,###,##0.00") & ", revise las cajas y los debidos prestamos."
                    Return False
                End If
                Dim daoIds = DataContext.daoParametros
                Dim parametros As Ids = daoIds.recuperarParametros()
                Dim crearM = (From c In ctx.Mcaja Where c.Codcaja = caja And c.Estado = 1 Select c).First()
                Dim dcaja As New Detacaja
                dcaja.Idcaja = crearM.Idcaja
                dcaja.Fecha = Now
                dcaja.Concepto = "***CIERRE DE CAJA***"
                dcaja.Efectivo = 0
                dcaja.Transferencia = 0
                dcaja.Cheque = 0
                dcaja.Hora = Now.ToLongTimeString()
                dcaja.Idmov = parametros.Saldo_anterior
                dcaja.Referencia = String.Empty
                dcaja.Codcaja = caja
                ctx.Detacaja.InsertOnSubmit(dcaja)
                crearM.Estado = 0
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function validarPrestamosPuentes() As Decimal Implements IDaoMaestroCaja.validarPrestamosPuentes
        Using ctx As New Contexto
            Try
                Dim daoIds = DataContext.daoParametros
                Dim parametros As Ids = daoIds.recuperarParametros()
                Dim datosPrestamosEgreso As Decimal = 0D
                Try
                    datosPrestamosEgreso = (From dc In ctx.Detacaja
                                            Where dc.idmov = parametros.Prestamo_egreso And dc.fecha.Year = Now.Year And dc.fecha.DayOfYear = Now.DayOfYear
                                            Group dc By dc.idmov Into g = Group
                                            Select Efectivo = g.Sum(Function(p) p.efectivo)).Single()
                Catch ex As Exception
                    _error = ex.Message
                    datosPrestamosEgreso = 0D
                End Try
                Dim datosPrestamosIngreso As Decimal = 0D
                Try
                    datosPrestamosIngreso = (From dc In ctx.Detacaja
                                             Where dc.idmov = parametros.Prestamo_ingreso And dc.fecha.Year = Now.Year And dc.fecha.DayOfYear = Now.DayOfYear
                                             Group dc By dc.idmov Into g = Group
                                             Select Efectivo = g.Sum(Function(p) p.efectivo)).Single()
                Catch ex As Exception
                    _error = ex.Message
                    datosPrestamosIngreso = 0D
                End Try
                Dim suma As Decimal = 0D
                suma = datosPrestamosEgreso - datosPrestamosIngreso
                Return suma
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function guardarDatosDetaCaja(dcaja As Database.Detacaja, mocaja As Database.Mcaja) As Boolean Implements IDaoMaestroCaja.guardarDatosDetaCaja
        Using ctx As New Contexto
            Try
                Dim xcaja = (From c In ctx.Mcaja Where c.Codcaja = mocaja.Codcaja And
                             c.Estado = 1 And c.Codagencia = mocaja.Codagencia
                             Select c).First
                xcaja.Entrada = xcaja.Entrada + mocaja.Entrada
                xcaja.Salida = xcaja.Salida + mocaja.Salida
                xcaja.Sfinal = xcaja.Sfinal + mocaja.Entrada - mocaja.Salida
                ctx.Detacaja.InsertOnSubmit(dcaja)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = "Deta caja" & ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function actualizarDatosMaestroCaja(mocaja As Database.Mcaja) As Boolean Implements IDaoMaestroCaja.actualizarDatosMaestroCaja
        Using ctx As New Contexto
            Try
                Dim xcaja = (From c In ctx.Mcaja Where c.Codcaja = mocaja.Codcaja And
                             c.Estado = 1 And c.Codagencia = mocaja.Codagencia
                             Select c).First
                xcaja.Entrada = xcaja.Entrada + mocaja.Entrada
                xcaja.Salida = xcaja.Salida + mocaja.Salida
                xcaja.Sfinal = xcaja.Sfinal + mocaja.Entrada - mocaja.Salida
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = "MCaja: " & ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function listarDetaCaja(caja As String) As System.Collections.Generic.List(Of Database.Detacaja) Implements IDaoMaestroCaja.listarDetaCaja
        Using ctx As New Contexto
            Dim xlista = (From d In ctx.Detacaja Order By d.Idcaja Descending Select d).ToList()
            Return xlista
        End Using
    End Function

    Public Function recuperarSaldoCaja(caja As String) As Database.Mcaja Implements IDaoMaestroCaja.recuperarSaldoCaja
        Using ctx As New Contexto
            Try
                Dim xcaj = (From c In ctx.Mcaja
                             Where c.Codcaja = caja And c.Estado = 1
                             Select c).First()
                Return xcaj
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function recuperarDetaCajaValores(mcaja As Mcaja) As List(Of Decimal) Implements IDaoMaestroCaja.recuperarDetaCajaValores
        Using ctx As New Contexto
            Try
                Dim verDetaCaja = From dc In ctx.Detacaja
                                  Join mov In ctx.Movcaja On dc.idmov Equals mov.Idmov
                                  Join ru In ctx.Rubro On mov.Codrubro Equals ru.Codrubro
                                  Where dc.idcaja = mcaja.Idcaja
                                  Select New With {
                                        .Cheque = IIf(ru.Naturaleza = 1, dc.cheque, -1 * dc.cheque),
                                        .Efectivo = IIf(ru.Naturaleza = 1, dc.efectivo, -1 * dc.efectivo),
                                        .Transferencia = IIf(ru.Naturaleza = 1, dc.transferencia, -1 * dc.transferencia)
                                      }
                'realizamos las operaciones debidas
                Return verDetaCaja.AsEnumerable()
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function validarMovimiento(idmov As Integer) As Boolean Implements IDaoMaestroCaja.validarMovimiento
        Using ctx As New Contexto
            Try
                Dim nat = (From mc In ctx.Movcaja Join r In ctx.Rubro On mc.Codrubro Equals r.Codrubro
                           Where mc.Idmov = idmov Select r.Naturaleza).First()
                If nat = 1 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
End Class

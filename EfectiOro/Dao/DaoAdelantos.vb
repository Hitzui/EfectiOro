Imports EfectiOro.Database
Imports System.Data.Linq
Imports System.Transactions
Imports System.Data.SqlClient
Imports EfectiOro

Public Class DaoAdelantos
    Implements IDaoAdelantos

    Private _error As String

    Public Function recuperarCodigoAdelanto() As String Implements IDaoAdelantos.recpuerarCodigoAdelanto
        Using ctx As New Contexto
            Dim id = ctx.ExecuteQuery(Of Integer)("select idadelanto from ids").First()
            Return Convert.ToString(id).PadLeft(10, "0")
        End Using
    End Function

    Private Sub actualizarCodigoAdelanto()
        Using ctx As New Contexto
            ctx.ExecuteQuery(Of Integer)("update ids set idadelanto = idadelanto+1")
        End Using
    End Sub
    Public ReadOnly findAdelantoById As Func(Of Contexto, String, IQueryable(Of Adelantos)) =
    CompiledQuery.Compile(Of Contexto, String, IQueryable(Of Adelantos))(
                Function(ctx As Contexto, idsalida As String) _
                    From a In ctx.Adelantos Where a.Idsalida = idsalida And a.Saldo > 0 Select a)
    Public Function actualizarAdelanto(adelanto As Decimal, idsalida As String, numcompra As String) As Boolean Implements IDaoAdelantos.actualizarAdelanto
        Using ctx As New Contexto
            Try
                Dim config As New ConfiguracionGeneral
                Dim agencia As String = config.getAgencia
                Dim find = (From a In ctx.Adelantos Where a.Idsalida = idsalida Select a).First()
                find.Saldo = adelanto
                If find.Numcompra.Length <= 0 Then
                    find.Numcompra = agencia & "." & numcompra
                Else
                    find.Numcompra = find.Numcompra & "; " & agencia & "." & numcompra
                End If
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function crearAdelanto(adelanto As Database.Adelantos) As Boolean Implements IDaoAdelantos.crearAdelanto
        Try
            Dim config As New ConfiguracionGeneral
            Dim agencia = config.getAgencia
            Using ctx As New Contexto
                Dim comprasAdelantos As New Compras_adelantos
                comprasAdelantos.Numcompra = String.Empty
                comprasAdelantos.Codcliente = adelanto.Codcliente
                comprasAdelantos.Codcaja = adelanto.Codcaja
                comprasAdelantos.Idadelanto = adelanto.Idsalida
                comprasAdelantos.Fecha = Now
                comprasAdelantos.Hora = New TimeSpan(Now.Hour, Now.Minute, Now.Second)
                comprasAdelantos.Monto = adelanto.Monto
                comprasAdelantos.Sinicial = Decimal.Zero
                comprasAdelantos.Sfinal = adelanto.Monto
                comprasAdelantos.Usuario = DataContext.usuarioLog.Usuario1
                comprasAdelantos.Codagencia = agencia
                comprasAdelantos.Codmoneda = adelanto.Codmoneda
                ctx.Compras_adelantos.InsertOnSubmit(comprasAdelantos)
                ctx.Adelantos.InsertOnSubmit(adelanto)
                ctx.SubmitChanges()
                Me.actualizarCodigoAdelanto()
                Return True
            End Using
        Catch ex As Exception
            _error = ex.Message
            Return False
        End Try
    End Function

    Public ReadOnly Property ErrorSms As String Implements IDaoAdelantos.ErrorSms
        Get
            Return _error
        End Get
    End Property

    Public Function findAll() As System.Collections.Generic.List(Of Database.Adelantos) Implements IDaoAdelantos.findAll
        Using ctx As New Contexto
            Return ctx.Adelantos.ToList
        End Using
    End Function

    Public Function findByCodigoCliente(codigo As String) As Database.Adelantos Implements IDaoAdelantos.findByCodigoCliente
        Using ctx As New Contexto
            Try
                Dim find = (From a In ctx.Adelantos Where a.Codcliente = codigo And a.Saldo > 0 Select a).First
                Return find
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public ReadOnly findAdelantoByCliente As Func(Of Contexto, String, IQueryable(Of Adelantos)) =
    CompiledQuery.Compile(Of Contexto, String, IQueryable(Of Adelantos))(
                Function(ctx As Contexto, codigo As String) _
                    From a In ctx.Adelantos Where a.Codcliente = codigo _
                            And a.Saldo > 0 Order By a.Fecha Ascending Select a)
    Public Function listarAdelantosPorClientes(codigo As String) As List(Of Adelantos) Implements IDaoAdelantos.listarAdelantosPorClientes
        Using ctx As New Contexto
            Try
                Dim find = findAdelantoByCliente(ctx, codigo).ToList
                Return find
            Catch ex As Exception
                Return Nothing
                _error = ex.Message
            End Try
        End Using
    End Function
    Public Function findByCodigoAdelanto(codigo As String) As Database.Adelantos Implements IDaoAdelantos.findByCodigoAdelanto
        Using ctx As New Contexto
            Try
                Return Me.findAdelantoById(ctx, codigo).First()
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function anularAdelanto(codigo As String) As Boolean Implements IDaoAdelantos.anularAdelanto
        Dim daoCaja = DataContext.daoMcaja
        Dim parametros = DataContext.daoParametros
        Using ctx As New Contexto
            Try
                'primero buscamos el adelanto
                'y dejamos el saldo en cero'
                'de esta manera no se filtrará y quedará registrado
                'especificamos que el monto sea igual al saldo para
                'asegurar que no tenga una aplicación en alguna compra
                Dim buscarAdelanto As Adelantos
                Try
                    buscarAdelanto = (From a In ctx.Adelantos
                                      Where a.Idsalida = codigo And a.Monto = a.Saldo
                                      Select a).First()
                Catch ex As Exception
                    _error = "No puede anular el adelanto ya que se ha aplicado en distintas compras."
                    Return False
                End Try
                buscarAdelanto.Saldo = 0
                ctx.SubmitChanges()
                If MsgBox("¿Desea revertir el monto en efectivo a la caja?", MsgBoxStyle.YesNo, "Revertir adelanto") = MsgBoxResult.Yes Then
                    'buscamos la caja con su saldos para actualizarlos
                    Dim buscarCaja As Mcaja
                    Try
                        buscarCaja = (From mc In ctx.Mcaja
                                      Where mc.Codcaja = buscarAdelanto.Codcaja And mc.Estado = 1
                                      Select mc).First
                    Catch ex As Exception
                        _error = "La caja que ingresó el adelanto no esta abierta, " &
                            "por lo tanto abra la caja para realizar el reembolso del adelanto."
                        Return False
                    End Try
                    buscarCaja.Entrada = buscarAdelanto.Efectivo
                    buscarCaja.Salida = 0
                    'buscamos el movimiento
                    'ahora creamos un nuevo movimiento de caja
                    'revirtiendo este adelanto
                    Dim nuevoDetaCaja As New Detacaja With {
                                .codcaja = buscarAdelanto.Codcaja,
                                .idcaja = buscarCaja.Idcaja,
                                .efectivo = buscarAdelanto.Efectivo,
                                .cheque = buscarAdelanto.Cheque,
                                .transferencia = buscarAdelanto.Transferencia,
                                .idmov = parametros.recuperarParametros().anular_adelanto,
                                .referencia = "Revertir adelanto con codigo N°: " & codigo,
                                .hora = Now.ToLongTimeString(),
                                .concepto = "***REVERTIR ADELANTO: " & codigo & "***",
                                .fecha = DateTime.Now
                        }
                    If daoMcaja.guardarDatosDetaCaja(nuevoDetaCaja, buscarCaja) = True Then
                        MsgBox("Se ha ingreso el monto en efectivo a la caja", MsgBoxStyle.Information, "Revertir adelanto")
                    Else
                        MsgBox("Se produjo un error al intentar ingresar el monto a la caja, producido por: " &
                               vbCr & daoCaja.ErrorSms, MsgBoxStyle.Critical, "Error")
                    End If
                End If
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Private Function aplicarEfectivo(listaAdelantos As List(Of Adelantos), monto As Decimal, Optional ByVal codigocliente As String = "") As Boolean
        Using ctx As New Contexto()
            Dim d_saldo = Decimal.Zero
            Dim listarAdelantosPrint As New List(Of Adelantos)
            Dim daoParam = DataContext.daoParametros
            Dim parametros = daoParam.recuperarParametros
            Dim config As New ConfiguracionGeneral
            Dim caja As String = config.getCaja
            Dim detaCaja As New Detacaja
            'detalle del detacaja
            detaCaja.idmov = parametros.pago_adelanto
            detaCaja.codcaja = config.getCaja
            detaCaja.concepto = "***EFECTIVO A ADELANTO(S): "
            detaCaja.efectivo = monto
            detaCaja.cheque = 0D
            detaCaja.fecha = DateTime.Now
            detaCaja.hora = Now.ToLongTimeString
            detaCaja.referencia = "Pago en efectivo a adelanto"
            detaCaja.transferencia = 0D
            Dim xcaja = (From c In ctx.Mcaja
                         Where c.Codcaja = config.getCaja And
                         c.Estado = 1 And c.Codagencia = "A001"
                         Select c).First
            xcaja.Entrada = xcaja.Entrada + monto
            xcaja.Sfinal = xcaja.Sfinal + monto
            detaCaja.idcaja = xcaja.Idcaja
            ctx.Detacaja.InsertOnSubmit(detaCaja)
            Try
                Dim tipoCambio = (From tc In ctx.TipoCambio Where tc.Fecha = Now.Date Select tc).Single
                'listaAdelantos.OrderBy(Function(p) p.Idsalida).ToList()
                For Each adelanto As Adelantos In listaAdelantos
                    If monto > 0 Then

                        detaCaja.concepto += adelanto.Idsalida & "; "
                        Dim idsalida As String = adelanto.Idsalida
                        Dim saldo As Decimal = adelanto.Saldo
                        'guardamos el monto que se ha aplicado a la compra
                        'en la tabla compras_adelanto
                        Dim hora As TimeSpan = New TimeSpan(Now.Hour, Now.Minute, Now.Second)
                        Dim comprasAdelantos As New Compras_adelantos()
                        comprasAdelantos.Codcaja = detaCaja.codcaja
                        comprasAdelantos.Codcliente = adelanto.Codcliente
                        comprasAdelantos.Fecha = Now
                        comprasAdelantos.Hora = hora
                        comprasAdelantos.Idadelanto = idsalida
                        comprasAdelantos.Numcompra = adelanto.Idsalida & " " & hora.ToString("h\:mm\:ss")
                        comprasAdelantos.Usuario = DataContext.usuarioLog.Usuario1
                        comprasAdelantos.Codmoneda = adelanto.Codmoneda
                        'Saldo inicial es el monto con el que esta al momento
                        comprasAdelantos.Sinicial = adelanto.Saldo
                        Select Case adelanto.Codmoneda
                            Case parametros.cordobas
                                If saldo >= monto Then
                                    'si el saldo es mayor que el adelanto
                                    'le restamos al saldo el adelanto y el adelanto queda en zero
                                    comprasAdelantos.Monto = monto
                                    saldo = Decimal.Subtract(saldo, monto) 'saldo - monto
                                    monto = Decimal.Zero
                                Else
                                    'si el adelanto es mayor que el saldo
                                    'le restamos al adelanto el saldo y el saldo queda en zero
                                    comprasAdelantos.Monto = saldo
                                    monto = monto - saldo
                                    saldo = 0
                                End If
                                comprasAdelantos.Sfinal = saldo
                            Case parametros.dolares
                                d_saldo = Decimal.Multiply(saldo, tipoCambio.Tipocambio1)
                                Dim d_monto = Decimal.Divide(monto, tipoCambio.Tipocambio1)
                                If saldo >= d_monto Then
                                    comprasAdelantos.Monto = d_monto
                                    saldo = Decimal.Subtract(saldo, d_monto)
                                    monto = Decimal.Zero
                                ElseIf d_monto >= saldo Then
                                    comprasAdelantos.Monto = saldo
                                    monto = Decimal.Subtract(monto, d_saldo)
                                    saldo = Decimal.Zero
                                End If
                                comprasAdelantos.Sfinal = saldo
                        End Select
                        Dim findAdelanto As Adelantos = (From a In ctx.Adelantos Where a.Idsalida = idsalida Select a).Single()
                        findAdelanto.Saldo = saldo
                        ctx.Compras_adelantos.InsertOnSubmit(comprasAdelantos)
                        listarAdelantosPrint.Add(findAdelanto)
                    End If
                Next
                Dim saldoCliente = (From a In ctx.Adelantos Where a.Codcliente = codigocliente And a.Saldo > 0 Group By a.Codcliente Into saldo = Sum(a.Saldo) Select saldo).Single
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function aplicarAdelantoEfectivo(listaAdelantos As List(Of Adelantos), monto As Decimal, Optional ByVal codcliente As String = "") As Boolean Implements IDaoAdelantos.aplicarAdelantoEfectivo
        Return Me.aplicarEfectivo(listaAdelantos, monto, codcliente)
    End Function

    Public Function imprimir(codigo As String, nombre As String) As Object Implements IDaoAdelantos.imprimir
        Using ctx As New Contexto
            Try
                Dim parametros = ctx.Ids.First
                Dim buscar = (From a In ctx.Adelantos Where a.Idsalida = codigo Select a).ToList()
                Dim listar As New List(Of Adelantos)
                For Each dato In buscar
                    Dim adelanto As New Adelantos
                    adelanto.Idsalida = dato.Idsalida
                    adelanto.Codcliente = dato.Codcliente
                    adelanto.Monto_letras = dato.Monto_letras
                    adelanto.Fecha = dato.Fecha
                    adelanto.Hora = dato.Hora
                    adelanto.Monto = dato.Monto
                    adelanto.nombreCliente = nombre
                    adelanto.Codmoneda = dato.Codmoneda
                    Try
                        adelanto.saldoCordobas = ctx.Adelantos.Where(Function(a) a.Codmoneda = parametros.cordobas And a.Saldo > 0 And a.Codcliente = dato.Codcliente).Sum(Function(a) a.Saldo)
                    Catch ex As Exception
                        'esto para cuando no hay saldo en cordobas
                        adelanto.saldoCordobas = Decimal.Zero
                    End Try
                    Try
                        adelanto.saldoDolares = ctx.Adelantos.Where(Function(a) a.Codmoneda = parametros.dolares And a.Saldo > 0 And a.Codcliente = dato.Codcliente).Sum(Function(a) a.Saldo)
                    Catch ex As Exception
                        'esto para cuando no hay saldo en dolares
                        adelanto.saldoDolares = Decimal.Zero
                    End Try
                    listar.Add(adelanto)
                Next
                Dim report As New rptReciboAdelanto
                'report.SetDataSource(listar)
                report.Database.Tables(0).SetDataSource(listar)
                report.Database.Tables(1).SetDataSource(ctx.Moneda.ToList)
                'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                frmReporteReciboAdelantoAbono.viewer.ReportSource = report
                frmReporteReciboAdelantoAbono.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Function
End Class

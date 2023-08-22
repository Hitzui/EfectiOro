Imports EfectiOro.Database
Imports System.Data.Linq
Imports System.Data.Linq.SqlClient
Imports System.Data.Linq.Mapping
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Transactions

Public Class DaoCompras
    Implements IDaoCompras

    Private Const formatoNumero As String = "#,###,##0.00"
    Private _error As String
    Private config As New ConfiguracionGeneral()
    Private cajaActual, _agencia As String

    Public Sub New()
        Me.cajaActual = config.getCaja
        _agencia = config.getAgencia
    End Sub
    Public Function findComprasByCodigoCliente(codCliente As String) As List(Of Compras) Implements IDaoCompras.findComprasByCodigoCliente
        Using ctx As New Contexto
            Try
                Dim find = (From c In ctx.Compras
                            Where c.Codcliente = codCliente
                            Select c).ToList()
                Return find
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function findCompraById(numerocompra As String, agencia As String) As Compras Implements IDaoCompras.findCompraById
        Using ctx As New Contexto
            Try
                Dim find = (From c In ctx.Compras
                            Where c.Numcompra = numerocompra And SqlMethods.Like(c.Codagencia, agencia)
                            Select c).First()
                Return find
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function actualizarCompra(compra As Compras) As Boolean Implements IDaoCompras.actualizarCompra
        Using ctx As New Contexto
            Try
                Dim buscar = (From c In ctx.Compras Where c.Numcompra = compra.Numcompra And c.Codagencia = compra.Codagencia Select c).First()
                buscar.Efectivo = compra.Efectivo
                buscar.Cheque = compra.Cheque
                buscar.Transferencia = compra.Transferencia
                buscar.Por_pagar = compra.Por_pagar
                buscar.Adelantos = compra.Adelantos
                buscar.Saldo_por_pagar = compra.Saldo_por_pagar
                buscar.Codestado = compra.Codestado
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function actualizarCompra(compra As Compras, detacompras As List(Of Det_compra)) As Boolean Implements IDaoCompras.actualizarCompra
        Using ctx As New Contexto
            Try
                'eliminamos la compra y el detalle respectivo
                'para luego volver a ingresar sus datos desde cero
                Dim buscar As Compras = (From c In ctx.Compras
                                         Where c.Numcompra = compra.Numcompra _
                                        And c.Codagencia = compra.Codagencia
                                         Select c).First
                'ahora ingresamos los datos nuevos
                ctx.Compras.DeleteOnSubmit(buscar)
                ctx.Compras.InsertOnSubmit(compra)
                For Each deta As Det_compra In detacompras
                    Dim buscar_det As Det_compra = (From dc In ctx.Det_compra
                                                    Where dc.Numcompra = compra.Numcompra And dc.Linea = deta.Linea And dc.Codagencia = compra.Codagencia
                                                    Select dc).First
                    'deta.Descripcion = "Oro en bruto"
                    buscar_det.Importe = deta.Importe
                    buscar_det.Preciok = deta.Preciok
                    buscar_det.Peso = deta.Peso
                    'ctx.Det_compra.InsertOnSubmit(deta)
                Next
                'buscamos el detalle de caja, y actualizamos lo necesario: cheque y transferencia
                'efectivo no se edita ***COMPRA: 5***
                Dim buscarDetalleCaja = (From dc In ctx.Detacaja Where dc.concepto = "***COMPRA: " & compra.Numcompra & "***" Select dc).First
                buscarDetalleCaja.cheque = compra.Cheque
                buscarDetalleCaja.transferencia = compra.Transferencia
                'aceptamos los cambios
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = "Se produjo un error al intentar editar la compra: " & ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function findDetaCompra(numcompra As String) As List(Of Det_compra) Implements IDaoCompras.findDetaCompra
        Using ctx As New Contexto
            Try
                Dim filtrar = (From dt In ctx.Det_compra
                               Where dt.Numcompra = numcompra And dt.Codagencia = _agencia
                               Order By dt.Linea Ascending
                               Select dt).ToList()
                Return filtrar
            Catch ex As Exception
                _error = "No existe la compra con el numero indicado, intente nuevamente"
                Return Nothing
            End Try
        End Using
    End Function
    Public Function actualizarCompraDescargue(compra As Compras, agencia As String) As Boolean Implements IDaoCompras.actualizarCompraDescargue
        Using ctx As New Contexto
            Try
                Dim find = (From c In ctx.Compras Where c.Numcompra = compra.Numcompra And c.Codagencia = compra.Codagencia Select c).Single()
                Dim detaCompra = (From dc In ctx.Det_compra Where dc.Numcompra = compra.Numcompra And dc.Codagencia = compra.Codagencia).ToList
                For Each dato As Det_compra In detaCompra
                    dato.Numdescargue = compra.Dgnumdes
                Next
                find.Codestado = compra.Codestado
                find.Dgnumdes = compra.Dgnumdes
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return True
            End Try
        End Using
    End Function

    Private Function reccuperarNumeroCompra() As Integer
        Using ctx As New Contexto
            Try
                Dim cod As Integer = (From i As Agencia In ctx.Agencia Where i.Codagencia = _agencia Select i.Numcompra).Single()
                Return cod
            Catch ex As Exception
                _error = ex.Message
                Return 0
            End Try
        End Using
    End Function
    Private Function actualizarIDCompra() As Boolean
        Using ctx As New Contexto
            Try
                Dim actualizar_num = (From a In ctx.Agencia Where a.Codagencia = _agencia Select a).Single
                Dim numero As Integer = actualizar_num.Numcompra
                actualizar_num.Numcompra = numero + 1
                ctx.SubmitChanges()
                'ctx.ExecuteQuery(Of Integer)("update ids set numcompra = numcompra +1")
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function
    'Private Function VerSiguienteNumeroCompra() As Integer
    '    Using ctx As New Contexto
    '        Try
    '            Dim cmp = (From c In ctx.Compras Order By c.Numcompra Descending Select c.Numcompra).First()
    '            Return Integer.Parse(cmp)
    '        Catch ex As Exception
    '            Return 0
    '        End Try
    '    End Using
    'End Function
    Public Function codigoCompra() As String Implements IDaoCompras.codigoCompra
        'If Me.reccuperarNumeroCompra = 0 Then
        '    Return "Error de codigo"
        'End If
        Using ctx As New Contexto
            'Dim config As New ConfiguracionGeneral
            'Dim caja, agencia As String
            'caja = config.getCaja
            'agencia = config.getAgencia
            Try
                Dim num_compra = ctx.ExecuteQuery(Of Integer)(String.Format("select a.numcompra from Agencia a where a.codagencia = '{0}'", _agencia))
                Return Convert.ToString(num_compra.First)
            Catch ex As Exception
                _error = ex.Message
                Return "Error de codigo"
            End Try
        End Using
    End Function
    Public Function anularCompra(numeroCompra As String) As Boolean Implements IDaoCompras.anularCompra
        'para que funcione este procedimiento se agregó un procedimiento almacenado
        'y luego se creó mediante linq to sql
        Dim daoAdelanto = DataContext.daoAdelantos
        Dim daoCaja = DataContext.daoMcaja
        'Dim config As New ConfiguracionGeneral
        'Dim daoParametro = DataContext.daoParametros
        Using tx As New TransactionScope()
            Using ctx As New Contexto()
                Dim parametros = ctx.Ids.Single
                'anular la comra
                'primero busquemos la compra y guardemosla en memoria
                Dim buscarCompra As Compras = Me.findCompraById(numeroCompra, _agencia)
                'busquemos el detalle de caja que se ingrsó el movimiento
                'ejemplo de concepto: ***COMPRA: 7***
                Dim verDetalleCaja As Detacaja = (From dc As Detacaja In ctx.Detacaja
                                                  Where dc.codcaja = buscarCompra.Codcaja And
                                     dc.concepto = "***COMPRA: " & numeroCompra & "***"
                                                  Select dc).Single()
                Dim tipoCambio = verDetalleCaja.tipocambio
                'buscamos el maestro de caja para actualizar los saldos
                Dim verMaestroCaja As Mcaja
                Try
                    verMaestroCaja = (From mc As Mcaja In ctx.Mcaja
                                      Where mc.Codcaja = buscarCompra.Codcaja And
                                      mc.Estado = 1 And mc.Codagencia = buscarCompra.Codagencia
                                      Select mc).Single()
                Catch ex As Exception
                    _error = "La caja que realizó la compra se encuentra cerrada, para anular la " &
                        "compra revise que la caja esté abierta. Caja: " & buscarCompra.Codcaja
                    Return False
                End Try
                'CREAR EL MOVMIENTO
                'revisar el tipo de moneda
                Dim efectivo = Decimal.Zero
                Select Case buscarCompra.Codmoneda
                    Case parametros.dolares
                        efectivo = buscarCompra.Efectivo * tipoCambio
                    Case parametros.cordobas
                        efectivo = buscarCompra.Efectivo
                End Select
                Dim nuevoDetaCaja As New Detacaja With {
                    .cheque = buscarCompra.Cheque,
                    .efectivo = efectivo,
                    .transferencia = buscarCompra.Transferencia,
                    .codcaja = verDetalleCaja.codcaja,
                    .concepto = "***REVERTIR COMPRA: " & numeroCompra & "***",
                    .fecha = Now,
                    .hora = Now.ToLongTimeString(),
                    .idmov = parametros.anular_compra,
                    .referencia = "Movimiento realizado por anulación de compra número: " & numeroCompra,
                    .idcaja = verMaestroCaja.Idcaja,
                    .tipocambio = tipoCambio
                }
                'ACTUALIZAMOS LOS DETALLES DEL MAESTRO DE CAJA
                Dim entrada = verMaestroCaja.Entrada
                Dim sfinal = verMaestroCaja.Sfinal
                verMaestroCaja.Entrada = efectivo + entrada
                verMaestroCaja.Sfinal = efectivo + sfinal
                Try
                    'revisamos si tiene cierre de precios y revertimos las onzas usadas en dicha compra
                    Dim buscarCierres = (From dc As Detacierre In ctx.DetaCierre
                                         Where dc.Numcompra = buscarCompra.Numcompra And dc.Codagencia = buscarCompra.Codagencia Select dc).ToList
                    For Each dato In buscarCierres
                        Dim findCierre As CierrePrecios = (From cp In ctx.CierrePrecios Where cp.CodCierre = dato.Codcierre Select cp).Single
                        findCierre.SaldoOnzas = Decimal.Add(findCierre.SaldoOnzas, dato.Cantidad)
                        If findCierre.SaldoOnzas > 0 Then
                            findCierre.Status = True
                        End If
                    Next
                    ctx.DetaCierre.DeleteAllOnSubmit(buscarCierres)
                    ctx.SubmitChanges()
                Catch ex As Exception
                    'no tiene cierre la compra seleccionada
                End Try
                Try
                    'si la compra tiene un monto en adelanto
                    'creamos un adelanto con ese monto
                    If buscarCompra.Adelantos > 0 Then
                        'buscamos los montos aplicados en la tabla compras adelantos
                        'y ese es el saldo a retornar
                        Dim buscarAdelanto = (From ca In ctx.Compras_adelantos Where ca.Numcompra = buscarCompra.Numcompra Select ca).ToList
                        Dim sum_cordobas = Decimal.Zero
                        Dim sum_dolares = Decimal.Zero
                        For Each dato In buscarAdelanto
                            Select Case dato.Codmoneda
                                Case parametros.cordobas
                                    sum_cordobas = Decimal.Add(sum_cordobas, dato.Monto)
                                Case parametros.dolares
                                    sum_dolares = Decimal.Add(sum_dolares, dato.Monto)
                            End Select
                        Next
                        If sum_cordobas > Decimal.Zero Then
                            Dim adelanto As New Adelantos With {
                                .Codmoneda = parametros.cordobas,
                                .Codcaja = verMaestroCaja.Codcaja,
                                .Hora = Now.ToShortTimeString,
                                .Fecha = Now,
                                .Monto = sum_cordobas,
                                .Saldo = sum_cordobas,
                                .Numcompra = "",
                                .Transferencia = 0D,
                                .Cheque = 0D,
                                .Usuario = DataContext.usuarioLog.Usuario1,
                                .Codcliente = buscarCompra.Codcliente,
                                .Monto_letras = ConvertirNumeroLetros(sum_cordobas),
                                .Idsalida = daoAdelanto.recpuerarCodigoAdelanto()
                            }
                            daoAdelanto.crearAdelanto(adelanto)
                        End If
                        If sum_dolares > Decimal.Zero Then
                            Dim adelanto As New Adelantos With {
                                .Codmoneda = parametros.dolares,
                                .Codcaja = verMaestroCaja.Codcaja,
                                .Hora = Now.ToShortTimeString,
                                .Fecha = Now,
                                .Monto = sum_dolares,
                                .Saldo = sum_dolares,
                                .Numcompra = "",
                                .Transferencia = 0D,
                                .Cheque = 0D,
                                .Usuario = DataContext.usuarioLog.Usuario1,
                                .Codcliente = buscarCompra.Codcliente,
                                .Monto_letras = ConvertirNumeroLetros(sum_dolares),
                                .Idsalida = daoAdelanto.recpuerarCodigoAdelanto()
                            }
                            daoAdelanto.crearAdelanto(adelanto)
                        End If
                        ctx.Compras_adelantos.DeleteAllOnSubmit(buscarAdelanto)
                    End If
                    ctx.AnularCompra(numeroCompra, _agencia)
                    ctx.Detacaja.InsertOnSubmit(nuevoDetaCaja)
                    ctx.SubmitChanges()
                    tx.Complete()
                    Return True
                Catch ex As Exception
                    _error = ex.Message
                    Return False
                End Try
            End Using
        End Using
    End Function
    Private Function ActualizarDetalleCompra(numeroCompra As String) As Boolean
        Using ctx As New Contexto
            Try
                ctx.ExecuteCommand("update compras set peso = 0, total = 0, codestado = 0, efectivo = 0,cheque = 0,transferencia = 0,por_cobrar= 0, " &
                    "por_pagar = 0, adelantos = 0, saldo_por_pagar = 0 where numcompra = '{0}'", numeroCompra)
                ctx.ExecuteCommand("update det_compra set precioK = 0, peso = 0, importe = 0, " &
                                   "kilshowdoc = '' where numcompra = '{0}'", numeroCompra)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function crearCompra(compra As Compras, detaCompras As List(Of Det_compra),
                                Optional modcaja As Mcaja = Nothing,
                                Optional dcaja As Detacaja = Nothing,
                                Optional listaAdelantos As List(Of Adelantos) = Nothing,
                                Optional listaPreciosaCerrar As List(Of CierrePrecios) = Nothing) As Boolean Implements IDaoCompras.crearCompra
        Using ctx As New Contexto()
            'recuperamos el numero de la copmra segun la agencia o sucursal
            Dim xid As String = reccuperarNumeroCompra()
            Dim saldoCordobas As Decimal = Decimal.Zero
            Dim saldoDolares As Decimal = Decimal.Zero
            Dim parametros = ctx.Ids.First
            Dim tipoCambio = (From tc In ctx.TipoCambio Where tc.Fecha.Date = Now.Date Select tc).Single
            dcaja.tipocambio = tipoCambio.Tipocambio1
            Try
                'recuperamos el saldo en cordobas
                saldoCordobas = (From a In ctx.Adelantos
                                 Where a.Codcliente = compra.Codcliente And
                                     a.Saldo > Decimal.Zero And a.Codmoneda = parametros.cordobas
                                 Select a.Saldo).Sum()
            Catch ex As Exception
                saldoCordobas = Decimal.Zero
            End Try
            Try
                'recuperamos el saldo en dolares
                saldoDolares = (From a In ctx.Adelantos
                                Where a.Codcliente = compra.Codcliente And
                                    a.Saldo > Decimal.Zero And a.Codmoneda = parametros.dolares
                                Select a.Saldo).Sum()
            Catch ex As Exception
                saldoDolares = Decimal.Zero
            End Try
            Dim moneda = (From m In ctx.Moneda Where m.Codmoneda = compra.Codmoneda Select m).Single
            compra.Numcompra = xid
            dcaja.concepto = "***COMPRA: " & xid & "***"
            dcaja.referencia = "COMPRA: " & xid & " - Tipo de moneda: " & moneda.Descripcion
            Try
                Dim sumOnzas As Decimal = Decimal.Zero
                'Recuperamos el detalle de caja correspondiente 
                'para validar el monto de los cheques
                'validamos saldo en cheque, que pueda retirar
                For Each deta As Det_compra In detaCompras
                    deta.Numcompra = xid
                    deta.Codagencia = compra.Codagencia
                    ctx.Det_compra.InsertOnSubmit(deta)
                Next
                Try
                    'buscamos los cierres q se usaron para establecer los precios
                    'en la tabla temporal de precios para proceder a guardarlos
                    Dim buscar_cierres = (From tmp In ctx.TmpPrecios Where tmp.Codcliente = compra.Codcliente Select tmp).ToList
                    Dim listaDetaCierres As New List(Of Detacierre)
                    If buscar_cierres.Count > 0 Then
                        For Each dato As TmpPrecios In buscar_cierres
                            Dim cierre As CierrePrecios = (From c In ctx.CierrePrecios Where c.CodCierre = dato.Codcierre Select c).Single
                            Dim xsaldo As Decimal = Decimal.Subtract(cierre.SaldoOnzas, dato.Cantidad)
                            Dim detacierre As New Detacierre With {
                                .Codcierre = dato.Codcierre,
                                .Cantidad = xsaldo,
                                .Onzas = cierre.SaldoOnzas,
                                .Saldo = dato.Cantidad,
                                .Fecha = Now,
                                .Numcompra = compra.Numcompra,
                                .Codagencia = compra.Codagencia
                            }
                            cierre.SaldoOnzas = dato.Cantidad
                            'si el cierre queda en zero entonces estado seria false
                            If dato.Cantidad = Decimal.Zero Then
                                cierre.Status = False
                            End If
                            listaDetaCierres.Add(detacierre)
                        Next
                        ctx.DetaCierre.InsertAllOnSubmit(listaDetaCierres)
                        ctx.TmpPrecios.DeleteAllOnSubmit(buscar_cierres)
                    End If
                Catch ex As Exception
                    'no hay cierres para el cliente especificado
                End Try
                Dim c_saldo = Decimal.Zero
                Dim d_saldo = Decimal.Zero
                actualizarIDCompra()
                ctx.Detacaja.InsertOnSubmit(dcaja)
                If compra.Adelantos > 0 Then
                    'compra.Adelantos, es el valor del adelanto especificado
                    'en este caso viene en dolares, este cambio se hizo el 08/2020
                    'ha solicitud del cliente
                    Dim daoAdelanto = DataContext.daoAdelantos
                    'en este caso pueden haber ingresado de un cliente
                    'y aplicado de varios adelantos, es decir, de un cliente aplicaron
                    'varios adelantos
                    Dim adelanto As Decimal = compra.Adelantos
                    'listaAdelantos = listaAdelantos.ToList()
                    For Each dato As Adelantos In listaAdelantos
                        If adelanto > 0 Then
                            Dim idsalida As String = dato.Idsalida
                            Dim hora As TimeSpan = New TimeSpan(Now.Hour, Now.Minute, Now.Second)
                            Dim comprasAdelantos As New Compras_adelantos With {
                                .Codcaja = dcaja.codcaja,
                                .Codcliente = compra.Codcliente,
                                .Fecha = Now,
                                .Hora = hora,
                                .Idadelanto = idsalida,
                                .Numcompra = compra.Numcompra,
                                .Usuario = usuarioLog.Usuario1,
                                .Codagencia = compra.Codagencia,
                                .Codmoneda = dato.Codmoneda
                            }
                            Select Case dato.Codmoneda
                                Case parametros.dolares
                                    d_saldo = dato.Saldo
                                    'guardamos el monto que se ha aplicado a la compra
                                    'en la tabla compras_adelanto
                                    'Saldo inicial es el monto con el que esta al momento
                                    comprasAdelantos.Sinicial = dato.Saldo
                                    If d_saldo > adelanto Then
                                        'si el saldo es mayor que el adelanto
                                        'le restamos al saldo el adelanto y el adelanto queda en zero
                                        comprasAdelantos.Monto = adelanto
                                        d_saldo = Decimal.Subtract(d_saldo, adelanto)
                                        adelanto = Decimal.Zero
                                    Else
                                        'si el adelanto es mayor que el saldo
                                        'le restamos al adelanto el saldo y el saldo queda en zero
                                        comprasAdelantos.Monto = dato.Saldo
                                        adelanto = Decimal.Subtract(adelanto, d_saldo)
                                        d_saldo = 0
                                    End If
                                    'el saldo final es el valor de saldo
                                    comprasAdelantos.Sfinal = Decimal.Subtract(dato.Saldo, comprasAdelantos.Monto)
                                    Dim findAdelanto = (From a In ctx.Adelantos Where a.Idsalida = idsalida Select a).Single()
                                    'daoAdelanto.actualizarAdelanto(saldo, idsalida, compra.Numcompra)
                                    findAdelanto.Saldo = d_saldo 'Decimal.Divide(d_saldo, tipoCambio.Tipocambio1)
                                    saldoDolares = Decimal.Subtract(saldoDolares, comprasAdelantos.Monto)
                                    If findAdelanto.Numcompra.Length <= 0 Then
                                        findAdelanto.Numcompra = compra.Codagencia & "-" & compra.Numcompra
                                    Else
                                        findAdelanto.Numcompra = findAdelanto.Numcompra & "; " & compra.Codagencia & "-" & compra.Numcompra
                                    End If
                                    'adelanto = Decimal.Multiply(d_monto, tipoCambio.Tipocambio1)
                                Case parametros.cordobas
                                    c_saldo = dato.Saldo
                                    Dim temp_dolares = Decimal.Divide(c_saldo, tipoCambio.Tipocambio1)
                                    Dim temp_adelanto = Decimal.Multiply(adelanto, tipoCambio.Tipocambio1)
                                    'guardamos el monto que se ha aplicado a la compra
                                    'en la tabla compras_adelanto
                                    'Saldo inicial es el monto con el que esta al momento
                                    comprasAdelantos.Sinicial = dato.Saldo
                                    If temp_dolares > adelanto Then
                                        'si el saldo es mayor que el adelanto
                                        'le restamos al saldo el adelanto y el adelanto queda en zero
                                        comprasAdelantos.Monto = adelanto
                                        c_saldo = Decimal.Subtract(c_saldo, temp_adelanto) 'd_saldo - adelanto
                                        adelanto = Decimal.Zero
                                    Else
                                        'si el adelanto es mayor que el saldo
                                        'le restamos al adelanto el saldo y el saldo queda en zero
                                        comprasAdelantos.Monto = c_saldo
                                        adelanto = Decimal.Subtract(adelanto, temp_dolares)
                                        c_saldo = 0
                                    End If
                                    'el saldo final es el valor de saldo
                                    comprasAdelantos.Sfinal = c_saldo
                                    Dim findAdelanto = (From a In ctx.Adelantos Where a.Idsalida = idsalida Select a).Single()
                                    'daoAdelanto.actualizarAdelanto(saldo, idsalida, compra.Numcompra)
                                    findAdelanto.Saldo = c_saldo
                                    saldoCordobas = Decimal.Subtract(saldoCordobas, comprasAdelantos.Monto)
                                    If findAdelanto.Numcompra.Length <= 0 Then
                                        findAdelanto.Numcompra = compra.Codagencia & "-" & compra.Numcompra
                                    Else
                                        findAdelanto.Numcompra = findAdelanto.Numcompra & "; " & compra.Codagencia & "-" & compra.Numcompra
                                    End If
                            End Select
                            ctx.Compras_adelantos.InsertOnSubmit(comprasAdelantos)
                        End If
                    Next
                End If
                Dim xcaja = (From c In ctx.Mcaja
                             Where c.Codcaja = modcaja.Codcaja And
                             c.Estado = 1 And c.Codagencia = modcaja.Codagencia
                             Select c).First
                If xcaja.Sfinal < modcaja.Salida Then
                    _error = "No hay saldo suficiente para realizar la compra, saldo disponible: " & xcaja.Sfinal
                    Return False
                End If
                compra.Saldo_adelanto = saldoCordobas
                compra.Saldo_adelanto_Dolares = saldoDolares
                ctx.Compras.InsertOnSubmit(compra)
                xcaja.Salida = xcaja.Salida + modcaja.Salida
                xcaja.Sfinal = xcaja.Sfinal - modcaja.Salida
                Dim eliminarPreciosCliente = (From p In ctx.Precios Where p.Codcliente = compra.Codcliente Select p).ToList
                ctx.Precios.DeleteAllOnSubmit(eliminarPreciosCliente)
                ctx.SubmitChanges()
                Return True
            Catch cco As ChangeConflictException
                DisplayChangeConflict(ctx)
                Return False
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Private Shared Sub DisplayChangeConflict(db As Contexto)
        For Each occ As ObjectChangeConflict In db.ChangeConflicts
            Dim metaTable As MetaTable = db.Mapping.GetTable(occ.Object.GetType())
            Dim entityConfilct As Object = CType(occ.Object, Object)
            MsgBox(String.Format("Tabla {0}, IsResolved: {1}", metaTable.TableName, occ.IsResolved))
            For Each mcc As MemberChangeConflict In occ.MemberConflicts
                Dim currVal = mcc.CurrentValue
                Dim origVal = mcc.OriginalValue
                Dim dataBaseVal = mcc.DatabaseValue
                Dim mi As MemberInfo = mcc.Member
                MsgBox(String.Format("Memeber: {0}", mi))
                MsgBox(String.Format("current value: {0}", currVal.ToString()))
                MsgBox(String.Format("original value: {0}", origVal.ToString()))
                MsgBox(String.Format("database value: {0}", dataBaseVal.ToString()))
            Next
        Next
    End Sub
    Public Sub imprimirCompra(numero_compra As String) Implements IDaoCompras.imprimirCompra
        Using ctx As New Contexto
            'Try
            Dim cod_agencia = config.getAgencia
            Dim siAdelanto As Boolean = False
            'Dim cod_agencia = ctx.Compras.Where(Function(a) a.Numcompra = numero_compra).Select(Function(a) a.Codagencia).Single
            Dim agencias = (From a In ctx.Agencia Where a.Codagencia = cod_agencia Select a).ToList
            Dim lisGeneral =
                (From c In ctx.Compras
                 Join dc In ctx.Det_compra On c.Codagencia Equals dc.Codagencia
                 Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                 Where c.Numcompra = numero_compra And c.Codestado <> 0 And dc.Numcompra = numero_compra And dc.Codagencia = cod_agencia
                 Order By cli.Nombres
                 Select c.Codagencia, c.Numcompra, cli.Numcedula, dc.Descripcion, c.Codcliente, cli.Nombres, cli.Apellidos, cli.Direccion,
                c.Adelantos, c.Transferencia, c.Cheque, c.Efectivo, c.Por_pagar, c.Codmoneda,
                dc.Kilate, dc.Peso, dc.Preciok, dc.Importe, c.Total, c.Fecha, c.Usuario, c.Saldo_adelanto).ToList()
            If lisGeneral.Count <= 0 Then
                MsgBox("No hay datos a mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Reporte de compras por cliente")
                Return
            End If
            Dim lista As New List(Of ViewCompras)
            Dim suma As Decimal = 0
            Dim param = (From p In ctx.Ids Where p.cordobas > 0 Select p).First
            For Each dato In lisGeneral
                Dim vista As New ViewCompras
                suma += dato.Total
                cod_agencia = dato.Codagencia
                vista.Codagencia = dato.Codagencia
                vista.Numcompra = dato.Numcompra
                vista.Codcliente = dato.Codcliente
                vista.Numcedula = dato.Numcedula
                vista.Direccion = dato.Direccion
                vista.Fecha = dato.Fecha
                vista.Total = dato.Total
                vista.Descripcion = dato.Descripcion
                vista.Kilate = dato.Kilate
                vista.Nomcliente = dato.Nombres & " " & dato.Apellidos
                vista.TotalGeneral = suma
                vista.Peso = dato.Peso
                vista.Precio = dato.Preciok
                vista.Importe = dato.Importe
                vista.Adelantos = dato.Adelantos
                vista.Efectivo = dato.Efectivo
                vista.Cheque = dato.Cheque
                vista.Transferencia = dato.Transferencia
                vista.Porpagar = dato.Por_pagar
                vista.Usuario = dato.Usuario
                vista.Saldo_adelanto = dato.Saldo_adelanto
                vista.CodMoneda = dato.Codmoneda
                lista.Add(vista)
                If dato.Adelantos > 0 Then
                    siAdelanto = True
                    Dim numAdelanto = (From a In ctx.Adelantos
                                       Where a.Codcliente = vista.Codcliente And
                                       a.Numcompra.Contains(dato.Numcompra)
                                       Select a).ToList()
                    Dim saldoPendAdelantosCordobas As Decimal = ctx.ExecuteQuery(Of Decimal)(String.Format("select iif(SUM(a.saldo)>0,sum(a.saldo),0) as saldo from adelantos a where a.codcliente = '{0}' and a.saldo >0 and a.codmoneda = {1}", dato.Codcliente, param.cordobas)).First()
                    Dim saldoPendAdelantosDolares As Decimal = ctx.ExecuteQuery(Of Decimal)(String.Format("select iif(SUM(a.saldo)>0,sum(a.saldo),0) as saldo from adelantos a where a.codcliente = '{0}' and a.saldo >0 and a.codmoneda = {1}", dato.Codcliente, param.dolares)).First()
                    If vista.Saldo_adelanto <= Decimal.Zero Then
                        vista.Saldo_adelanto = saldoPendAdelantosCordobas
                    End If
                    Dim nextIdAdelanto As String = String.Empty
                    Dim codAdelanto As String = String.Empty
                    For Each valorAdelantoCliente In numAdelanto
                        nextIdAdelanto = valorAdelantoCliente.Idsalida
                        If nextIdAdelanto.Length = 0 Then
                            codAdelanto = nextIdAdelanto
                        End If
                        codAdelanto = codAdelanto & "; " & nextIdAdelanto
                    Next
                    vista.NotaAdelanto = "Nota: En esta compra se aplica un reembolso de C$" & vista.Adelantos.ToString(formatoNumero) & " correspondiente al adelanto número " &
                        codAdelanto & ". El nuevo saldo es C$: " & saldoPendAdelantosCordobas.ToString(formatoNumero)
                    If saldoPendAdelantosDolares > Decimal.Zero Then
                        vista.NotaAdelanto = String.Concat(vista.NotaAdelanto, ", y U$: " & saldoPendAdelantosDolares.ToString(formatoNumero) & vbCr)
                    Else
                        vista.NotaAdelanto = String.Concat(vista.NotaAdelanto, vbCr)
                    End If
                End If
                If vista.Porpagar > 0 Then
                    vista.NotaAdelanto &= "Nota: Esta compra tiene un saldo pendiente por pagar (pendiente de cierre): " & vista.Porpagar.ToString("#,###,##0.000")
                End If
            Next
            Dim report As New rptCompra
            Dim reportComprobante As New rptComprobanteLiquidacion
            Dim frmReporteCompra As New frmReporteCompra
            Dim frmcomprobante As New frmReporteComprobanteLiquidacion
            'reportComprobante.SetDataSource(lista)
            reportComprobante.Database.Tables(0).SetDataSource(lista)
            reportComprobante.Database.Tables(1).SetDataSource(ctx.Moneda.ToList)
            reportComprobante.Database.Tables(2).SetDataSource(agencias)
            report.Database.Tables(0).SetDataSource(lista)
            report.Database.Tables(1).SetDataSource(ctx.Moneda.ToList)
            report.Database.Tables(2).SetDataSource(agencias)
            'report.SetDataSource(lista)
            'ServiciosBasicos.ParametrosCrystal(txtDesdedet.Value, txtHastadet.Value)
            frmcomprobante.viewer.ReportSource = reportComprobante
            frmcomprobante.Show()
            frmReporteCompra.viewer.ReportSource = report
            frmReporteCompra.Show()
            'Catch ex As Exception
            '    MsgBox("No se pudo imprimir la compra debido al siguiente error: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
            'End Try
        End Using
    End Sub

    Public ReadOnly Property ErrorSms As String Implements IDaoCompras.ErrorSms
        Get
            Return _error
        End Get
    End Property
End Class

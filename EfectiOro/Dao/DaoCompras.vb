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
                Dim buscar = (From c In ctx.Compras Where c.Numcompra = compra.Numcompra Select c).First()
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
    Public Function actualizarCompraDescargue(compra As Database.Compras, agencia As String) As Boolean Implements IDaoCompras.actualizarCompraDescargue
        Using ctx As New Contexto
            Try
                Dim find = (From c In ctx.Compras Where c.Numcompra = compra.Numcompra And SqlMethods.Like(c.Codagencia, agencia) Select c).Single()
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
        Dim daoParametro = DataContext.daoParametros
        'Using tx As New TransactionScope()
        Using ctx As New Contexto()
            'anular la comra
            'primero busquemos la compra y guardemosla en memoria
            Dim buscarCompra As Compras = Me.findCompraById(numeroCompra, _agencia)
            'busquemos el detalle de caja que se ingrsó el movimiento
            'ejemplo de concepto: ***COMPRA: 7***
            Dim verDetalleCaja As Detacaja = (From dc As Detacaja In ctx.Detacaja
                                 Where dc.codcaja = buscarCompra.Codcaja And
                                 dc.concepto = "***COMPRA: " & numeroCompra & "***"
                                 Select dc).First()
            'buscamos el maestro de caja para actualizar los saldos
            Dim verMaestroCaja As Mcaja
            Try
                verMaestroCaja = (From mc As Mcaja In ctx.Mcaja
                                  Where mc.Codcaja = verDetalleCaja.codcaja And
                                  mc.Estado = 1 Select mc).First()
            Catch ex As Exception
                _error = "La caja que realizó la compra se encuentra cerrada, para anular la " & _
                    "compra revise que la caja esté abierta. Caja: " & buscarCompra.Codcaja
                Return False
            End Try
            'CREAR EL MOVMIENTO
            Dim nuevoDetaCaja As New Detacaja
            nuevoDetaCaja.cheque = buscarCompra.Cheque
            nuevoDetaCaja.efectivo = buscarCompra.Efectivo
            nuevoDetaCaja.transferencia = buscarCompra.Transferencia
            nuevoDetaCaja.codcaja = verDetalleCaja.codcaja
            nuevoDetaCaja.concepto = "***REVERTIR COMPRA: " & numeroCompra & "***"
            nuevoDetaCaja.fecha = DateTime.Now
            nuevoDetaCaja.hora = Now.ToLongTimeString()
            nuevoDetaCaja.idmov = daoParametro.recuperarParametros().Anular_compra
            nuevoDetaCaja.referencia = "Movimiento realizado por anulación de compra número: " & numeroCompra
            nuevoDetaCaja.idcaja = verMaestroCaja.Idcaja
            'ACTUALIZAMOS LOS DETALLES DEL MAESTRO DE CAJA
            verMaestroCaja.Entrada = buscarCompra.Efectivo
            verMaestroCaja.Salida = 0
            Try
                'revisamos si tiene cierre de precios y revertimos las onzas usadas en dicha compra
                Dim buscarCierres = (From dc As Detacierre In ctx.DetaCierre
                                     Where dc.Numcompra = numeroCompra And dc.Codagencia = buscarCompra.Codagencia Select dc).ToList
                For Each dato In buscarCierres
                    Dim findCierre As CierrePrecios = (From cp In ctx.CierrePrecios Where cp.CodCierre = dato.CodCierre Select cp).Single
                    findCierre.SaldoOnzas = Decimal.Add(findCierre.SaldoOnzas, dato.Cantidad)
                    findCierre.Status = True
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
                    Dim adelanto As New Adelantos
                    adelanto.Codcaja = verMaestroCaja.Codcaja
                    adelanto.Hora = Now.ToShortTimeString
                    adelanto.Fecha = Now
                    adelanto.Monto = buscarCompra.Adelantos
                    adelanto.Saldo = buscarCompra.Adelantos
                    adelanto.Numcompra = ""
                    adelanto.Transferencia = 0D
                    adelanto.Cheque = 0D
                    adelanto.Usuario = DataContext.usuarioLog.Usuario1
                    adelanto.Codcliente = buscarCompra.Codcliente
                    adelanto.Monto_letras = ConvertirNumeroLetros(buscarCompra.Adelantos)
                    adelanto.Idsalida = daoAdelanto.recpuerarCodigoAdelanto()
                    daoAdelanto.crearAdelanto(adelanto)
                End If
                ctx.AnularCompra(numeroCompra, _agencia)
                daoMcaja.guardarDatosDetaCaja(nuevoDetaCaja, verMaestroCaja)
                'tx.Complete()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
        'End Using
    End Function
    Private Function actualizarDetalleCompra(numeroCompra As String) As Boolean
        Using ctx As New Contexto
            Try
                ctx.ExecuteCommand("update compras set peso = 0, total = 0, codestado = 0, efectivo = 0,cheque = 0,transferencia = 0,por_cobrar= 0, " & _
                    "por_pagar = 0, adelantos = 0, saldo_por_pagar = 0 where numcompra = '{0}'", numeroCompra)
                ctx.ExecuteCommand("update det_compra set precioK = 0, peso = 0, importe = 0, " & _
                                   "kilshowdoc = '' where numcompra = '{0}'", numeroCompra)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    
    Private Sub actualizarIdComprasAdelantos()
        Using ctx As New Contexto
            ctx.ExecuteCommand("update Ids set compras_adelantos = compras_adelantos +1")
        End Using
    End Sub
    Public Function crearCompra(compra As Database.Compras, detaCompras As List(Of Database.Det_compra),
                                Optional ByVal modcaja As Mcaja = Nothing,
                                Optional ByVal dcaja As Detacaja = Nothing,
                                Optional ByVal listaAdelantos As List(Of Adelantos) = Nothing,
                                Optional ByVal listaPreciosaCerrar As List(Of CierrePrecios) = Nothing) As Boolean Implements IDaoCompras.crearCompra
        Using ctx As New Contexto()
            'Dim xid As String = Me.codigoCompra()
            'recuperamos el numero de la copmra segun la agencia o sucursal
            Dim xid As String = Me.reccuperarNumeroCompra
            Dim ver_saldo As Decimal = Decimal.Zero
            'recuperamos el saldo y lo guardamos en la tabla compras
            'esto es para cuando re-impriman el voucher de compra
            'aparezca el saldo de adelanto que habia en ese momento
            Try
                ver_saldo = ctx.Adelantos.Where(Function(a) a.Saldo > 0).Where(Function(a) a.Codcliente = compra.Codcliente).Sum(Function(a) a.Saldo)
            Catch ex As Exception
                ver_saldo = Decimal.Zero
            End Try
            If compra.Adelantos > 0 Then
                compra.Saldo_adelanto = ver_saldo - compra.Adelantos
            Else
                compra.Saldo_adelanto = Decimal.Zero
            End If
            compra.Numcompra = xid
            dcaja.concepto = "***COMPRA: " & xid & "***"
            dcaja.referencia = "COMPRA: " & xid
            ctx.Compras.InsertOnSubmit(compra)
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
                            Dim detacierre As New Detacierre
                            Dim xsaldo As Decimal = Decimal.Subtract(cierre.SaldoOnzas, dato.Cantidad)
                            detacierre.Codcierre = dato.Codcierre
                            detacierre.Cantidad = xsaldo
                            detacierre.Onzas = cierre.SaldoOnzas
                            detacierre.Saldo = dato.Cantidad
                            detacierre.Fecha = Now
                            detacierre.Numcompra = compra.Numcompra
                            detacierre.Codagencia = compra.Codagencia
                            cierre.SaldoOnzas = dato.Cantidad
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
                'If listaPreciosaCerrar IsNot Nothing Then
                '    If listaPreciosaCerrar.Count > 0 Then
                '        Dim listaDetaCierres As New List(Of Detacierre)
                '        For Each dato As CierrePrecios In listaPreciosaCerrar
                '            Dim detaCierre As New Detacierre
                '            Dim find As CierrePrecios = (From cp In ctx.CierrePrecios Where cp.CodCierre = dato.CodCierre Select cp).Single
                '            detaCierre.Onzas = find.SaldoOnzas
                '            find.SaldoOnzas = Decimal.Round(dato.SaldoOnzas, 3)
                '            detaCierre.Codcierre = dato.CodCierre
                '            detaCierre.Fecha = Now
                '            detaCierre.Numcompra = compra.Numcompra
                '            detaCierre.Saldo = Decimal.Round(dato.SaldoOnzas, 3)
                '            detaCierre.Cantidad = Decimal.Subtract(detaCierre.Onzas, detaCierre.Saldo)
                '            If dato.SaldoOnzas = Decimal.Zero Then
                '                find.Status = False
                '            End If
                '            listaDetaCierres.Add(detaCierre)
                '        Next
                '        ctx.DetaCierre.InsertAllOnSubmit(listaDetaCierres)
                '    End If
                'End If
                Dim saldo = Decimal.Zero
                Me.actualizarIDCompra()
                ctx.Detacaja.InsertOnSubmit(dcaja)
                If compra.Adelantos > 0 Then
                    Dim daoAdelanto = DataContext.daoAdelantos
                    'Dim find = daoAdelanto.listarAdelantosPorClientes(compra.Codcliente)
                    'en este caso pueden haber ingresado de un cliente
                    'y aplicado de varios adelantos, es decir, de un cliente aplicaron
                    'varios adelantos
                    Dim adelanto As Decimal = compra.Adelantos
                    listaAdelantos = listaAdelantos.OrderBy(Function(p) p.Idsalida).ToList()
                    For Each dato As Adelantos In listaAdelantos
                        If adelanto > 0 Then
                            Dim idsalida As String = dato.Idsalida
                            saldo = dato.Saldo
                            'guardamos el monto que se ha aplicado a la compra
                            'en la tabla compras_adelanto
                            Dim hora As TimeSpan = New TimeSpan(Now.Hour, Now.Minute, Now.Second)
                            Dim comprasAdelantos As New Compras_adelantos()
                            comprasAdelantos.Codcaja = dcaja.codcaja
                            comprasAdelantos.Codcliente = compra.Codcliente
                            comprasAdelantos.Fecha = Now
                            comprasAdelantos.Hora = hora
                            comprasAdelantos.Idadelanto = idsalida
                            comprasAdelantos.Numcompra = compra.Numcompra
                            comprasAdelantos.Usuario = DataContext.usuarioLog.Usuario1
                            'Saldo inicial es el monto con el que esta al momento
                            comprasAdelantos.Sinicial = dato.Saldo
                            If saldo > adelanto Then
                                'si el saldo es mayor que el adelanto
                                'le restamos al saldo el adelanto y el adelanto queda en zero
                                comprasAdelantos.Monto = adelanto
                                saldo = saldo - adelanto
                                adelanto = Decimal.Zero
                            Else
                                'si el adelanto es mayor que el saldo
                                'le restamos al adelanto el saldo y el saldo queda en zero
                                comprasAdelantos.Monto = saldo
                                adelanto = adelanto - saldo
                                saldo = 0
                            End If
                            'el saldo final es el valor de saldo
                            comprasAdelantos.Sfinal = saldo
                            Dim findAdelanto = (From a In ctx.Adelantos Where a.Idsalida = idsalida Select a).Single()
                            'daoAdelanto.actualizarAdelanto(saldo, idsalida, compra.Numcompra)
                            findAdelanto.Saldo = saldo
                            If findAdelanto.Numcompra.Length <= 0 Then
                                findAdelanto.Numcompra = compra.Codagencia & "-" & compra.Numcompra
                            Else
                                findAdelanto.Numcompra = findAdelanto.Numcompra & "; " & compra.Codagencia & "." & compra.Numcompra
                            End If
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
            Try
                Dim siAdelanto As Boolean = False
                Dim lisGeneral =
                    (From c In ctx.Compras
                     Join dc In ctx.Det_compra On c.Codagencia Equals dc.Codagencia
                     Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                     Where c.Numcompra = numero_compra And c.Codestado <> 0 And dc.Numcompra = numero_compra And dc.Codagencia = _agencia
                     Order By cli.Nombres
                     Select c.Numcompra, cli.Numcedula, dc.Descripcion, c.Codcliente, cli.Nombres, cli.Apellidos, cli.Direccion,
                    c.Adelantos, c.Transferencia, c.Cheque, c.Efectivo, c.Por_pagar,
                    dc.Kilate, dc.Peso, dc.Preciok, dc.Importe, c.Total, c.Fecha, c.Usuario, c.Saldo_adelanto).ToList()
                If lisGeneral.Count <= 0 Then
                    MsgBox("No hay datos a mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Reporte de compras por cliente")
                    Return
                End If
                Dim lista As New List(Of ViewCompras)
                Dim suma As Decimal = 0
                For Each dato In lisGeneral
                    Dim vista As New ViewCompras
                    suma += dato.Total
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
                    lista.Add(vista)
                    If dato.Adelantos > 0 Then
                        siAdelanto = True
                        Dim numAdelanto = (From a In ctx.Adelantos
                                           Where a.Codcliente = vista.Codcliente And
                                           a.Numcompra.Contains(dato.Numcompra)
                                           Select a).ToList()
                        Dim saldoPendAdelantos As Decimal =
                            ctx.ExecuteQuery(Of Decimal)("select iif(SUM(a.saldo)>0,sum(a.saldo),0) as saldo " &
                             "from adelantos a where a.codcliente = '" & dato.Codcliente & "' and a.saldo >0").First()
                        If vista.Saldo_adelanto <= Decimal.Zero Then
                            vista.Saldo_adelanto = saldoPendAdelantos
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
                        vista.NotaAdelanto = "Nota: En esta compra se aplica un reembolso de C$" & vista.Adelantos.ToString("#,###,##0.00") & " correspondiente al adelanto número " &
                            codAdelanto & ". El nuevo saldo es C$" & vista.Saldo_adelanto.ToString("#,###,##0.00") & vbCr
                    End If
                    If vista.Porpagar > 0 Then
                        vista.NotaAdelanto &= "Nota: Esta compra tiene un saldo pendiente por pagar (pendiente de cierre): " & vista.Porpagar.ToString("#,###,##0.000")
                    End If
                Next
                Dim report As New rptCompra
                Dim reportComprobante As New rptComprobanteLiquidacion
                Dim frmReporteCompra As New frmReporteCompra
                Dim frmcomprobante As New frmReporteComprobanteLiquidacion
                reportComprobante.SetDataSource(lista)
                report.SetDataSource(lista)
                'ServiciosBasicos.ParametrosCrystal(txtDesdedet.Value, txtHastadet.Value)
                frmcomprobante.viewer.ReportSource = reportComprobante
                frmcomprobante.Show()
                frmReporteCompra.viewer.ReportSource = report
                frmReporteCompra.Show()
            Catch ex As Exception
                MsgBox("No se pudo imprimir la compra debido al siguiente error: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub
    
    Public ReadOnly Property ErrorSms As String Implements IDaoCompras.ErrorSms
        Get
            Return _error
        End Get
    End Property
End Class

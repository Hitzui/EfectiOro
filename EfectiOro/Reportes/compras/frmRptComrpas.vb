Imports EfectiOro.Database
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports System.Data.Linq.SqlClient

Public Class frmRptComrpas
    'combobox compras
    'Consilidado
    'Agrupados por clientes
    'General onzas
    'Saldos por pagar
    'end combobox
    Private Sub cargarSucursales()
        Using ctx As New Contexto
            Try
                Dim list_agencia = (From a In ctx.Agencia Select a)
                Dim dt As New DataTable
                dt = ServiciosBasicos.ToDataTable(list_agencia)
                cmbFiltrarAgencia.DataSource = dt
                cmbFiltrarAgencia.DisplayMember = dt.Columns("nomagencia").ToString
                cmbFiltrarAgencia.ValueMember = dt.Columns("codagencia").ToString
            Catch ex As Exception
                MsgBox("Se produjo un error al cargar las sucursales. Revise la siguiente información: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub
    Private codigoCliente As String = String.Empty
    Private numeroCompra As String = String.Empty
    Private nombreCliente As String = String.Empty
    Private _agencia As String = "%%"

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

#Region "Compras generales"
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Using ctx As New Contexto
            If chkFiltrarAgencia.CheckState = CheckState.Checked Then
                _agencia = cmbFiltrarAgencia.SelectedValue
            Else
                _agencia = String.Empty
            End If
            If Me.radSaldosComprasDescargues.Checked Then
                Dim fecha = txtFechaSaldos.Value
                Try
                    'hacemos la suma de los totales por mes de las compras
                    If chkFiltrarAgencia.Checked Then
                        _agencia = " and c.codagencia = '" & cmbFiltrarAgencia.SelectedValue & "' "
                    Else
                        _agencia = String.Empty
                    End If
                    Dim buscarc = ctx.ExecuteQuery(Of SaldoCompra)(String.Format("select MONTH(c.fecha) mes, sum(c.total) as valorc, sum(c.peso) as pesoc " &
                                "from compras c where YEAR(c.fecha) = {0} " & _agencia &
                                "group by month(c.fecha) " &
                                "order by month(c.fecha) asc", fecha.Year)).ToList
                    Dim buscard = ctx.ExecuteQuery(Of SaldoDescargue)(String.Format("select MONTH(fecha) as mes, SUM(importe) as valorD, SUM(peso) as pesoD " &
                                                                    "from (select distinct d.dgfecdes as fecha,d.dgimptcom as importe, d.dgpesbrt as peso " &
                                                                    "from descargues d join compras c on d.dgnumdes=c.dgnumdes " &
                                                                    "where year(d.dgfecdes) = {0} " & _agencia & ") as temporal " &
                                                                    "group by MONTH(fecha)", fecha.Year)).ToList
                    Dim saldoAnioAnterior As New Saldo
                    saldoAnioAnterior = ServiciosBasicos.saldosAnioAnterior(fecha.Year, _agencia)
                    Dim tempListaDescargue As New List(Of SaldoDescargue)
                    Dim tempListaCompras As New List(Of SaldoCompra)
                    Dim listar As New List(Of Saldo)
                    Dim saldoAcumulado As Decimal = saldoAnioAnterior.valorS
                    Dim pesoAcumulado As Decimal = saldoAnioAnterior.pesoS
                    For i As Integer = 1 To 12
                        Dim tempSaldoDescargue As New SaldoDescargue
                        Dim tempSaldoCompra As New SaldoCompra
                        Dim saldo As New Saldo
                        Dim sum As Decimal = Decimal.Zero
                        Dim temp As Integer = i
                        'Se realiza en un try catch en caso de que no haya un resultado
                        'entonces se dan valores en zero.
                        Try
                            Dim buscar_d = buscard.Where(Function(p) p.mes = temp).Single
                            tempSaldoDescargue.mes = temp
                            tempSaldoDescargue.pesoD = buscar_d.pesoD
                            tempSaldoDescargue.valorD = buscar_d.valorD
                        Catch ex As Exception
                            tempSaldoDescargue.mes = temp
                            tempSaldoDescargue.pesoD = Decimal.Zero
                            tempSaldoDescargue.valorD = Decimal.Zero
                        End Try
                        'Se realiza en un try catch en caso de que no haya un resultado
                        'entonces se dan valores en zero.
                        Try
                            Dim buscar_c = buscarc.Where(Function(c) c.mes = temp).Single
                            tempSaldoCompra.mes = temp
                            tempSaldoCompra.pesoC = buscar_c.pesoC
                            tempSaldoCompra.valorC = buscar_c.valorC
                        Catch ex As Exception
                            tempSaldoCompra.mes = temp
                            tempSaldoCompra.pesoC = Decimal.Zero
                            tempSaldoCompra.valorC = Decimal.Zero
                        End Try
                        saldo.mes = temp
                        saldo.valorS = Math.Abs(saldoAcumulado + tempSaldoCompra.valorC - tempSaldoDescargue.valorD)
                        saldo.pesoS = Math.Abs(pesoAcumulado + tempSaldoCompra.pesoC - tempSaldoDescargue.pesoD)
                        saldoAcumulado = Math.Abs(saldo.valorS)
                        pesoAcumulado = Math.Abs(saldo.pesoS)
                        listar.Add(saldo)
                        tempListaCompras.Add(tempSaldoCompra)
                        tempListaDescargue.Add(tempSaldoDescargue)
                    Next
                    Dim report As New rptSaldosComprasDescargue
                    report.Database.Tables(0).SetDataSource(listar)
                    report.Database.Tables(1).SetDataSource(tempListaCompras)
                    report.Database.Tables(2).SetDataSource(tempListaDescargue)
                    ServiciosBasicos.ParametrosCrystal(txtFechaSaldos.Value, txtFechaSaldos.Value, saldoAnioAnterior.valorS, saldoAnioAnterior.pesoS)
                    frmReportes.viewer.ReportSource = report
                    frmReportes.Show()
                    Return
                Catch ex As Exception
                    MessageBox.Show("No se pudo realizar la consulta debido a un error interno. " & vbCr & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End If
            If Me.radOperador_general.Checked Then
                If cmbOperadorFiltrar.SelectedIndex = 0 Then
                    Dim lisCompras = (From c In ctx.Compras Where c.Fecha <= Me.txtHastaGen.Value And c.Fecha >= Me.txtDesdeGen.Value And c.Codestado > 0 And c.Codestado < 3 Select c).ToList()
                    If chkFiltrarAgencia.Checked Then
                        lisCompras = lisCompras.Where(Function(c) c.Codagencia = _agencia).ToList
                    End If
                    If lisCompras.Count <= 0 Then
                        MsgBox("No hay datos a mostar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Compras")
                        Return
                    End If
                    Dim report As New rptComprasOperadorGeneral
                    report.SetDataSource(lisCompras)
                    ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                    frmReportes.viewer.ReportSource = report
                End If
                If cmbOperadorFiltrar.SelectedIndex = 1 Then
                    Dim lisCompras = (From c In ctx.Compras_operador
                                      Where c.Fecha <= Me.txtHastaGen.Value And c.Fecha >= Me.txtDesdeGen.Value
                                      Select c).ToList()
                    If chkFiltrarAgencia.Checked Then
                        lisCompras = lisCompras.Where(Function(c) c.CodAgencia = _agencia).ToList
                    End If
                    If lisCompras.Count <= 0 Then
                        MsgBox("No hay datos a mostar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Compras")
                        Return
                    End If
                    Dim report As New rptComprasOperadorDetalle
                    report.SetDataSource(lisCompras)
                    ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                    frmReportes.viewer.ReportSource = report
                End If
                frmReportes.Show()
            End If
            If Me.radPoroperador.Checked Then
                Try
                    Dim lisCompras As New List(Of Compras_operador)
                    lisCompras = (From c In ctx.Compras_operador
                                  Where c.Fecha <= Me.txtHastaGen.Value And c.Fecha >= Me.txtDesdeGen.Value _
                                         And c.Nombre = Me.cmbOperador.Text Select c).ToList()
                    If chkFiltrarAgencia.Checked Then
                        lisCompras = lisCompras.Where(Function(c) c.CodAgencia = _agencia).ToList
                    End If
                    If lisCompras.Count <= 0 Then
                        MsgBox("No hay datos a mostar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Compras")
                        Return
                    End If
                    Dim report As New rptComprasOperadorDetalle
                    report.SetDataSource(lisCompras)
                    ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                    frmReportes.viewer.ReportSource = report
                    frmReportes.Show()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error Operador")
                End Try
            End If
            If radGeneral.Checked Then
                If cmbComprasGen.SelectedIndex = 0 Then
                    'ver en general
                    Dim lisGeneral =
                                        (From c In ctx.Compras
                                         Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                                         Where c.Fecha >= txtDesdeGen.Value And c.Fecha <= txtHastaGen.Value _
                                         And c.Codestado <> 0 Group c, cli
                                        By c.Numcompra, c.Codcliente, c.Fecha, c.Peso, c.Total, cli.Nombres, cli.Apellidos, c.Codagencia Into Group
                                         Select Numcompra, Codcliente, Fecha, Peso, Total, Nombres, Apellidos, Codagencia).ToList()
                    If chkFiltrarAgencia.Checked Then
                        lisGeneral = lisGeneral.Where(Function(c) c.Codagencia = _agencia).ToList()
                    End If
                    Dim lista As New List(Of ViewCompras)
                    Dim suma As Decimal = 0
                    For Each dato In lisGeneral
                        Dim vista As New ViewCompras
                        suma += dato.Total
                        vista.Numcompra = dato.Numcompra
                        vista.Codcliente = dato.Codcliente
                        vista.Fecha = dato.Fecha
                        vista.Total = dato.Total
                        vista.Nomcliente = dato.Nombres & " " & dato.Apellidos
                        vista.TotalGeneral = suma
                        vista.Peso = dato.Peso
                        lista.Add(vista)
                    Next
                    If lisGeneral.Count <= 0 Then
                        MsgBox("No hay datos mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, Me.lblTitulo.Text)
                        Return
                    End If
                    Dim report As New rptComprasGeneral
                    report.SetDataSource(lista)
                    ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                    frmReportes.viewer.ReportSource = report
                End If
                If cmbComprasGen.SelectedIndex = 1 Then
                    'Agrupados por cliente en determinada fecha
                    Dim lisGeneral =
                        (From c In ctx.Compras
                         Join dc In ctx.Det_compra On c.Codagencia Equals dc.Codagencia
                         Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                         Where c.Fecha >= txtDesdeGen.Value And c.Fecha <= txtHastaGen.Value _
                         And dc.Numcompra = c.Numcompra And c.Codestado <> 0 Order By cli.Nombres
                         Select c.Numcompra, c.Codcliente, cli.Nombres, cli.Apellidos, dc.Peso, dc.Preciok, dc.Importe, c.Total, c.Fecha, dc.Kilate, c.Codagencia).ToList()
                    If chkFiltrarAgencia.Checked Then
                        lisGeneral = lisGeneral.Where(Function(c) c.Codagencia = _agencia).ToList
                    End If
                    If lisGeneral.Count <= 0 Then
                        MsgBox("No hay datos mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, Me.lblTitulo.Text)
                        Return
                    End If
                    Dim lista As New List(Of ViewCompras)
                    Dim sumpeso As Decimal = 0
                    Dim suma As Decimal = 0
                    For Each dato In lisGeneral
                        Dim vista As New ViewCompras
                        suma += dato.Total
                        sumpeso += dato.Peso
                        vista.pesoTotal = sumpeso
                        vista.Numcompra = dato.Numcompra
                        vista.Codcliente = dato.Codcliente
                        vista.Fecha = dato.Fecha
                        vista.Total = dato.Total
                        vista.Nomcliente = dato.Nombres & " " & dato.Apellidos
                        vista.TotalGeneral = suma
                        vista.Peso = dato.Peso
                        vista.Precio = dato.Preciok
                        vista.Importe = dato.Importe
                        vista.kilateValor = dato.Kilate
                        lista.Add(vista)
                    Next
                    Dim report As New rptComprasAgrupado
                    report.SetDataSource(lista)
                    ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                    frmReportes.viewer.ReportSource = report
                End If
                If cmbComprasGen.SelectedIndex = 2 Then
                    'ver reporte onzas                    
                    Try
                        Dim lisGeneral =
                            (From c In ctx.Compras
                             Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                             Join dc In ctx.Det_compra On c.Numcompra Equals dc.Numcompra
                             Join tc In ctx.TipoCambio On c.Fecha Equals tc.Fecha
                             Where dc.Importe > Decimal.Zero And
                                   dc.Fecha >= txtDesdeGen.Value.Date And dc.Fecha <= txtHastaGen.Value.Date And
                                   c.Codestado >= 1 And c.Codestado <= 3 And c.Codagencia = dc.Codagencia And c.Codagencia.Contains(_agencia)
                             Order By dc.Fecha Descending
                             Let pr_gramo = dc.Importe / If(dc.Peso = Decimal.Zero, Decimal.One, dc.Peso) / If(tc.Tipocambio1 = Decimal.Zero, Decimal.One, tc.Tipocambio1)
                             Let y_value = 31.1035 * 24 / CDec(dc.Kilate) / If(tc.Precio_oro = Decimal.Zero, Decimal.One, tc.Precio_oro)
                             Let v_margen = CType(Decimal.One - (pr_gramo * y_value), Decimal)
                             Let _precioKilate = CType(dc.Importe / If(dc.Peso = Decimal.Zero, Decimal.One, dc.Peso) / dc.Kilate, Decimal)
                             Select
                                  dc.Codagencia,
                                  dc.Numcompra,
                                  c.Codcliente,
                                  cli.Nombres,
                                  cli.Apellidos,
                                  dc.Kilate,
                                  dc.Peso,
                                  dc.Preciok,
                                  dc.Importe,
                                  c.Total,
                                  dc.Fecha,
                                  tc.Tipocambio1,
                                  tc.Precio_oro,
                                  Margen = v_margen,
                                  PrecioKilate = _precioKilate
                                ).ToList()
                        If chkFiltrarAgencia.Checked Then
                            lisGeneral = (From li In lisGeneral Where li.Codagencia = _agencia Select li).ToList
                        End If
                        If lisGeneral.Count <= 0 Then
                            MsgBox("No hay datos mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, Me.lblTitulo.Text)
                            Return
                        End If
                        Dim lista As New List(Of ViewCompras)
                        Dim suma As Decimal = 0
                        For Each dato In lisGeneral
                            Dim vista As New ViewCompras
                            suma += dato.Total
                            vista.Numcompra = dato.Numcompra
                            vista.Codcliente = dato.Codcliente
                            vista.Fecha = dato.Fecha
                            vista.Total = dato.Total
                            vista.Nomcliente = dato.Nombres & " " & dato.Apellidos
                            vista.TotalGeneral = suma
                            vista.kilateValor = Convert.ToDecimal(dato.Kilate)
                            vista.Peso = dato.Peso
                            vista.Precio = dato.Preciok
                            vista.Importe = dato.Importe
                            vista.Tipocambio = dato.Tipocambio1
                            vista.Margen = Decimal.Divide(dato.Margen, 100) '* 100
                            'usamos el campo Porpagar, para no crear otro,
                            'y no cargar más.
                            vista.Porpagar = dato.PrecioKilate
                            'para no crear mas campos uso vista.Efectivo,
                            'al valor del oro
                            vista.Efectivo = dato.Precio_oro
                            vista.Codagencia = dato.Codagencia
                            lista.Add(vista)
                        Next
                        Dim report As New rptCompraOnzas
                        report.SetDataSource(lista)
                        ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                        frmReportes.viewer.ReportSource = report
                    Catch ex As Exception
                        MsgBox("Debe especificar el precio del oro en el rango especificado, por favor revise si lo ha establecido en las fechas." & vbCr & ex.Message, MsgBoxStyle.Information, "Error")
                    End Try
                End If
                If Me.cmbComprasGen.SelectedIndex = 3 Then
                    'ver saldos por pagar
                    Dim compra = (From c In ctx.Compras
                                  Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                                  Where c.Saldo_por_pagar > 0 And c.Fecha <= txtHastaGen.Value _
                                  And c.Fecha >= txtDesdeGen.Value
                                  Order By c.Fecha Ascending
                                  Select c).ToList()
                    Dim clientes = (From cli In ctx.Cliente Select cli).ToList
                    If chkFiltrarAgencia.Checked Then
                        compra = compra.Where(Function(c) c.Codagencia = _agencia).ToList
                    End If
                    If compra.Count <= 0 Then
                        MsgBox("No hay datos a mostar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Compras")
                        Return
                    End If
                    Dim report As New rptSaldosPorPagar
                    report.Database.Tables(0).SetDataSource(compra)
                    report.Database.Tables(1).SetDataSource(clientes)
                    ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                    frmReportes.viewer.ReportSource = report
                End If
                frmReportes.Show()
            End If
            If radDetalle.Checked Then
                Dim lisDetalle =
                    (From c In ctx.Compras
                     Join dc In ctx.Det_compra On c.Numcompra Equals dc.Numcompra
                     Join tc In ctx.TipoCambio On c.Fecha Equals tc.Fecha
                     Where c.Fecha >= txtDesdeGen.Value And c.Fecha <= txtHastaGen.Value And c.Codestado <> 0
                     Select c.Numcompra, dc.Kilshowdoc, dc.Preciok, dc.Peso, dc.Importe, tc.Tipocambio1, c.Codagencia).ToList()
                If chkFiltrarAgencia.Checked Then
                    lisDetalle = lisDetalle.Where(Function(c) c.Codagencia = _agencia).ToList
                End If
                If lisDetalle.Count <= 0 Then
                    MsgBox("No hay datos mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, Me.lblTitulo.Text)
                    Return
                End If
                Dim lista As New List(Of ViewCompras)
                Dim suma As Decimal = Decimal.Zero
                For Each dato In lisDetalle
                    'en este caso haremos que el tipo de cambio sea el total en moneda extrangera
                    'el importe representará la moneda nacional
                    Dim vista As New ViewCompras
                    vista.Numcompra = dato.Numcompra
                    vista.Total = (dato.Importe / dato.Tipocambio1)
                    vista.Importe = dato.Importe
                    vista.Peso = dato.Peso
                    vista.Precio = dato.Preciok
                    vista.Kilate = dato.Kilshowdoc
                    vista.Tipocambio = dato.Tipocambio1
                    lista.Add(vista)
                Next
                Dim report As New rptDetalleCompraTC
                report.SetDataSource(lista)
                ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            End If
            If radDetalleCompra.Checked Then
                Dim compra = (From c In ctx.Compras Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                                      Where c.Fecha <= txtHastaGen.Value And c.Fecha >= txtDesdeGen.Value And c.Codestado <> 0
                                      Order By c.Fecha Ascending
                                      Select c).ToList()
                Dim clientes = (From cli In ctx.Cliente Select cli).ToList
                If chkFiltrarAgencia.Checked Then
                    compra = compra.Where(Function(c) c.Codagencia = _agencia).ToList
                End If
                If compra.Count <= 0 Then
                    MsgBox("No hay datos a mostar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Compras")
                    Return
                End If
                Select Case cmbTipoPago.SelectedIndex
                    Case 0
                        Dim report As New rptDetalleCompraTipoPago
                        report.Database.Tables(0).SetDataSource(compra)
                        report.Database.Tables(1).SetDataSource(clientes)
                        ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                        frmReportes.viewer.ReportSource = report
                        frmReportes.Show()
                    Case 1
                        Dim report As New rptCompraTipoPagoGeneral
                        report.Database.Tables(0).SetDataSource(compra)
                        report.Database.Tables(1).SetDataSource(clientes)
                        ServiciosBasicos.ParametrosCrystal(txtDesdeGen.Value, txtHastaGen.Value)
                        frmReportes.viewer.ReportSource = report
                        frmReportes.Show()
                End Select
            End If
        End Using
    End Sub
#End Region

    Private Sub frmRptComrpas_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblTitulo.Text = "Generar reporte de compras"
        Me.cmbComprasGen.SelectedIndex = 0
        Me.cmbOperadorFiltrar.SelectedIndex = 0
        Me.cmbTipoPago.SelectedIndex = 0
        btnClose.Visible = False
        Me.llenarComboUsuario()
        cargarSucursales()
    End Sub

    Private Sub UltraButton1_Click(sender As System.Object, e As System.EventArgs) Handles  UltraButton2.Click
        Me.Close()
    End Sub

    Private Sub radPorcodigo_Click(sender As System.Object, e As System.EventArgs) Handles radPorcodigo.Click
        lblBuscar.Text = "Filtrar Por codigo"
        txtFiltrar.Focus()
    End Sub

    Private Sub radPornombre_Click(sender As System.Object, e As System.EventArgs) Handles radPornombre.Click
        lblBuscar.Text = "Filtrar por nombre de cliente"
        txtFiltrar.Focus()
    End Sub

    Private Sub radPornumcompra_Click(sender As System.Object, e As System.EventArgs) Handles radPornumcompra.Click
        lblBuscar.Text = "Filtrar por número de compra"
        txtFiltrar.Focus()
    End Sub

    'Private Sub UltraTabControl1_SelectedTabChanged(sender As System.Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs)
    '    Select Case e.Tab.Key
    '        Case "General"

    '        Case "Detalle"
    '            txtFiltrar.Focus()
    '            lblBuscar.Text = "Filtrar Por codigo"
    '    End Select
    'End Sub
    Sub filtrarValores()
        Using ctx As New Contexto
            colNumeroCompra.Visible = False
            If radPorcodigo.Checked Then
                Dim filtrar = (From cli In ctx.Cliente
                               Where System.Data.Linq.SqlClient.SqlMethods.Like(cli.Codcliente, "%" & txtFiltrar.Text & "%")
                               Select cli.Codcliente, cli.Nombres, cli.Apellidos).ToList()
                dgvFiltrar.Rows.Clear()
                For Each dato In filtrar
                    dgvFiltrar.Rows.Add("", dato.Codcliente, dato.Nombres, dato.Apellidos)
                Next
            End If
            If radPornombre.Checked Then
                Dim filtrar = (From cli In ctx.Cliente
                               Where System.Data.Linq.SqlClient.SqlMethods.Like(cli.Nombres, "%" & txtFiltrar.Text & "%")
                               Select cli.Codcliente, cli.Nombres, cli.Apellidos).ToList()
                dgvFiltrar.Rows.Clear()
                For Each dato In filtrar
                    dgvFiltrar.Rows.Add("", dato.Codcliente, dato.Nombres, dato.Apellidos)
                Next
            End If
            If radPornumcompra.Checked Then
                colNumeroCompra.Visible = True
                Dim filtrar = (From cli In ctx.Cliente
                               Join c In ctx.Compras On cli.Codcliente Equals c.Codcliente
                               Where SqlMethods.Like(c.Numcompra, "%" & txtFiltrar.Text & "%") And
                               c.Fecha >= txtDesdedet.Value And c.Fecha <= txtHastadet.Value And c.Codestado <> 0
                               Select c.Numcompra, cli.Codcliente, cli.Nombres, cli.Apellidos).ToList()
                dgvFiltrar.Rows.Clear()
                For Each dato In filtrar
                    dgvFiltrar.Rows.Add(dato.Numcompra, dato.Codcliente, dato.Nombres, dato.Apellidos)
                Next
            End If
        End Using
    End Sub
    Private Sub txtFiltrar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFiltrar.TextChanged
        Me.filtrarValores()
    End Sub

    Private Sub btnBuscardet_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscardet.Click
        Using ctx As New Contexto
            If radPorcodigo.Checked Then
                If codigoCliente.Length <= 0 Then
                    MsgBox("No se ha especificado un codigo de cliente, intente nuevamente", MsgBoxStyle.Information, "Buscar por codigo")
                    Return
                End If
                '0 indica anulada, ver aquellas que no sean anuladas
                Dim lisGeneral =
                    (From c In ctx.Compras
                     Join dc In ctx.Det_compra On c.Numcompra Equals dc.Numcompra
                     Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                     Where c.Fecha >= txtDesdedet.Value And c.Fecha <= txtHastadet.Value _
                         And SqlMethods.Like(dc.Codagencia, _agencia) And SqlMethods.Like(c.Codagencia, _agencia) _
                         And c.Codcliente = codigoCliente And c.Codestado <> 0
                     Order By cli.Nombres
                     Select c.Numcompra, c.Codcliente, cli.Nombres, cli.Apellidos, dc.Peso, dc.Preciok, dc.Importe, c.Total, c.Fecha).ToList()
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
                    vista.Fecha = dato.Fecha
                    vista.Total = dato.Total
                    vista.Nomcliente = dato.Nombres & " " & dato.Apellidos
                    vista.TotalGeneral = suma
                    vista.Peso = dato.Peso
                    vista.Precio = dato.Preciok
                    vista.Importe = dato.Importe
                    lista.Add(vista)
                Next
                codigoCliente = String.Empty
                Dim report As New rptComprasAgrupado
                report.SetDataSource(lista)
                ServiciosBasicos.ParametrosCrystal(txtDesdedet.Value, txtHastadet.Value)
                frmReportes.viewer.ReportSource = report

                frmReportes.Show()
            End If
            If radPornombre.Checked Then
                Dim lisGeneral =
                    (From c In ctx.Compras
                     Join dc In ctx.Det_compra On c.Numcompra Equals dc.Numcompra
                     Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                     Where c.Fecha >= txtDesdedet.Value And c.Fecha <= txtHastadet.Value _
                         And cli.Nombres = nombreCliente And c.Codestado <> 0 _
                         And SqlMethods.Like(dc.Codagencia, _agencia) And SqlMethods.Like(c.Codagencia, _agencia)
                     Order By cli.Nombres
                     Select c.Numcompra, c.Codcliente, cli.Nombres, cli.Apellidos, dc.Peso, dc.Preciok, dc.Importe, c.Total, c.Fecha).ToList()
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
                    vista.Fecha = dato.Fecha
                    vista.Total = dato.Total
                    vista.Nomcliente = dato.Nombres & " " & dato.Apellidos
                    vista.TotalGeneral = suma
                    vista.Peso = dato.Peso
                    vista.Precio = dato.Preciok
                    vista.Importe = dato.Importe
                    lista.Add(vista)
                Next
                nombreCliente = String.Empty
                Dim report As New rptComprasAgrupado
                report.SetDataSource(lista)
                ServiciosBasicos.ParametrosCrystal(txtDesdedet.Value, txtHastadet.Value)
                frmReportes.viewer.ReportSource = report

                frmReportes.Show()
            End If
            If radPornumcompra.Checked Then
                Dim dao = DataContext.daoCompras
                dao.imprimirCompra(numeroCompra)
                Me.numeroCompra = String.Empty
            End If
        End Using
    End Sub

    Private Sub dgvFiltrar_Click(sender As System.Object, e As System.EventArgs) Handles dgvFiltrar.Click
        Try
            Dim row As DataGridViewRow = dgvFiltrar.CurrentRow
            codigoCliente = row.Cells("colCodigo").Value
            nombreCliente = row.Cells("colNombre").Value
            numeroCompra = row.Cells("colNumeroCompra").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDesdedet_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdedet.ValueChanged
        Using ctx As New Contexto
            Me.filtrarValores()
        End Using
    End Sub

    Private Sub txtHastadet_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtHastadet.ValueChanged
        Me.filtrarValores()
    End Sub

    Private Sub radPorcodigo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPorcodigo.CheckedChanged
        Me.filtrarValores()
    End Sub

    Private Sub radPornombre_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPornombre.CheckedChanged
        Me.filtrarValores()
    End Sub

    Private Sub radPornumcompra_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPornumcompra.CheckedChanged
        Me.filtrarValores()
    End Sub
    Sub llenarComboUsuario()
        Try
            Dim dao = DataContext.daoUsuario
            Dim listar = dao.findAll()
            cmbOperador.DataSource = listar
            cmbOperador.DisplayMember = "Nombre"
            cmbOperador.ValueMember = "Usuario"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub radPoroperador_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPoroperador.CheckedChanged
        If radPoroperador.Checked Then
            Me.cmbOperador.Visible = True
        Else
            Me.cmbOperador.Visible = False
        End If
    End Sub

    Private Sub radOperador_general_CheckedChanged(sender As Object, e As EventArgs) Handles radOperador_general.CheckedChanged
        If radOperador_general.Checked = True Then
            Me.cmbOperadorFiltrar.Visible = True
        Else
            Me.cmbOperadorFiltrar.Visible = False
        End If
    End Sub

    Private Sub radGeneral_CheckedChanged(sender As Object, e As EventArgs) Handles radGeneral.CheckedChanged
        If Me.radGeneral.Checked = True Then
            Me.cmbComprasGen.Visible = True
        Else
            Me.cmbComprasGen.Visible = False
        End If
    End Sub

    Private Sub radSaldosComprasDescargues_CheckedChanged(sender As Object, e As EventArgs) Handles radSaldosComprasDescargues.CheckedChanged
        If radSaldosComprasDescargues.Checked = True Then
            Me.txtFechaSaldos.Visible = True
        Else
            Me.txtFechaSaldos.Visible = False
        End If
    End Sub

    Private Sub btnCargarLiquidacion_Click(sender As Object, e As EventArgs) Handles btnCargarLiquidacion.Click
        Using ctx As New Contexto
            Try
                dgvLiquidacion.DataSource = Nothing
                Dim buscar = (From l In ctx.Liquidacion Select l).ToList
                dgvLiquidacion.DataSource = buscar
            Catch ex As Exception
                MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If dgvLiquidacion.Rows.Count <= 0 Then
                MsgBox("Cargar datos para poder imprimir.", MsgBoxStyle.Critical, "Mensaje")
                Return
            End If
            Dim row As DataGridViewRow = dgvLiquidacion.CurrentRow
            Dim recibo As String = row.Cells(4).Value
            Using ctx As New Contexto
                Dim buscar = (From l In ctx.Liquidacion Where l.Recibo = recibo Select l).ToList
                Dim clientes = (From c In ctx.Cliente Select c).ToList
                Dim reportComprobante As New rptComprobanteLiquidacion
                Dim frmcomprobante As New frmReporteComprobanteLiquidacion
                reportComprobante.Database.Tables(0).SetDataSource(clientes)
                reportComprobante.Database.Tables(1).SetDataSource(buscar)
                frmcomprobante.viewer.ReportSource = reportComprobante
                frmcomprobante.Show()
            End Using
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkFiltrarAgencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltrarAgencia.CheckedChanged
        If chkFiltrarAgencia.CheckState = CheckState.Checked Then
            If cmbFiltrarAgencia.Enabled = False Then
                cmbFiltrarAgencia.Enabled = True
            End If
        Else
            If cmbFiltrarAgencia.Enabled = True Then
                cmbFiltrarAgencia.Enabled = False
            End If
        End If
    End Sub

    Private Sub radDetalleCompra_CheckedChanged(sender As Object, e As EventArgs) Handles radDetalleCompra.CheckedChanged
        If radDetalleCompra.Checked Then
            If cmbTipoPago.Visible = False Then
                cmbTipoPago.Visible = True
            End If
        Else
            If cmbTipoPago.Visible = True Then
                cmbTipoPago.Visible = False
            End If
        End If
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub
End Class

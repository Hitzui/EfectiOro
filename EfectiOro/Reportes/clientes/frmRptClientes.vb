Imports EfectiOro.Database
Imports System.Data.Linq

Imports System.Data.Linq.SqlClient
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading

Public Class frmRptClientes
    Private Const tituloError As String = "Error"
    Private daoCliente As IDaoCliente
    Private demoThread As Thread = Nothing
    ''' <summary>
    ''' Recuperamos: codcliente,nombres,apellidos,numcedula,direccion de los clientes
    ''' </summary>
    ''' <remarks></remarks>
    Private tablaCliente As New DataTable
    Private _codigoClienteSeleccionado As String = String.Empty
    Public ReadOnly Property CodigoClienteSeleccionado() As String
        Get
            Return _codigoClienteSeleccionado
        End Get
    End Property
    Private Function llenarDataTable() As DataTable
        Using con As New SqlConnection(Contexto.conectar)
            Try
                con.Open()
                Dim cmd As New SqlCommand("select codcliente,nombres,apellidos,numcedula,direccion from cliente order by nombres asc", con)
                cmd.Connection = con
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable("Cliente")
                da.Fill(dt)
                Return dt
            Catch ex As Exception
                MsgBox("Error al recuperar los clientes: " & ex.Message, MsgBoxStyle.Critical, tituloError)
                Return Nothing
            Finally
                con.Close()
            End Try
        End Using
    End Function
    Sub llenarGridPorClienteAdo()
        Try
            Using ctx As New Contexto
                If radPornombre.Checked Then
                    Dim buscar = (From c In ctx.Cliente Where c.Nombres.Contains(txtFiltrar.Text)
                                  Select c.Codcliente, c.Nombres, c.Apellidos, c.Numcedula, c.Direccion).ToList
                    dgvFiltrar.DataSource = buscar
                ElseIf radPorcedula.Checked Then
                    Dim buscar = (From c In ctx.Cliente Where c.Numcedula.Contains(txtFiltrar.Text)
                                  Select c.Codcliente, c.Nombres, c.Apellidos, c.Numcedula, c.Direccion).ToList
                    dgvFiltrar.DataSource = buscar
                ElseIf radPorcodigo.Checked Then
                    Dim buscar = (From c In ctx.Cliente Where c.Codcliente.Contains(txtFiltrar.Text)
                                  Select c.Codcliente, c.Nombres, c.Apellidos, c.Numcedula, c.Direccion).ToList
                    dgvFiltrar.DataSource = buscar
                ElseIf radApellido.Checked Then
                    Dim buscar = (From c In ctx.Cliente Where c.Apellidos.Contains(txtFiltrar.Text)
                                  Select c.Codcliente, c.Nombres, c.Apellidos, c.Numcedula, c.Direccion).ToList
                    dgvFiltrar.DataSource = buscar
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error al recuperar los clientes: " & ex.Message, MsgBoxStyle.Critical, tituloError)
        End Try
    End Sub

    Private recuperarClientesDatos As Func(Of Contexto, IQueryable(Of Cliente)) =
        CompiledQuery.Compile(Function(ctx As Contexto) _
                                  From c In ctx.Cliente Select c)

    Sub cargarFiltroClientes()
        If radPornombre.Checked Then
            Using ctx As New Contexto
                'Dim dao = DataContext.daoCliente
                Dim recCliente = (From c In daoCliente.recuperarTodosClientes Select c.Codcliente, c.Nombres, c.Apellidos, c.Direccion)
                dgvFiltrar.DataSource = recCliente
            End Using
        End If
    End Sub
    Public Sub New()
        daoCliente = New DaoCliente
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        'Me.fillDataTable.RunWorkerAsync()
    End Sub
    Private Sub frmRptClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Generar reporte de clientes"
        btnClose.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Using ctx As New Contexto
            If Me.radReserva.Checked Then
                Select Case cmbReserva.SelectedIndex
                    Case 0
                        Try
                            Dim buscar As New List(Of Cliente)
                            Dim buscarReserva As New List(Of ReservaOro)
                            If CodigoClienteSeleccionado.Length > 0 Then
                                buscar = (From c In ctx.Cliente
                                          Where c.Codcliente = _codigoClienteSeleccionado
                                          Select c).ToList
                                buscarReserva = (From r In ctx.ReservaOro
                                                 Where r.Codcliente = _codigoClienteSeleccionado _
                                                 And r.FechaReserva <= txtHastagen.Value And r.FechaReserva >= txtDesdegen.Value
                                                 Select r).ToList
                            Else
                                buscar = (From c In ctx.Cliente Select c).ToList
                                buscarReserva = (From r In ctx.ReservaOro
                                                 Where r.FechaReserva <= txtHastagen.Value And r.FechaReserva >= txtDesdegen.Value
                                                 Select r).ToList
                            End If
                            Dim rptReserva As New rptReservaPorCliente
                            rptReserva.Database.Tables(0).SetDataSource(buscar)
                            rptReserva.Database.Tables(1).SetDataSource(buscarReserva)
                            ServiciosBasicos.ParametrosCrystal(txtDesdegen.Value, txtHastagen.Value, frmReporteReservas, rptReserva)
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en reserva")
                        End Try
                End Select
            End If
            If radPorcedula.Checked Then
                MsgBox("No se puede filtrar los valores por el numero de cedula del cliente solo por codigo.", MsgBoxStyle.Information, "Filtrar")
                Return
            End If
            Dim tipoCambio As Decimal
            Try
                tipoCambio = (From tc As TipoCambio In ctx.TipoCambio Where tc.Fecha = Date.Now Select tc.Tipocambio1).First()
            Catch
                MsgBox("No se ha ingresado el tipo de cambio para el día de hoy, ingrese el tipo de cambio para continuar.", MsgBoxStyle.Information, "Tipo de cambio")
                Return
            End Try
            If Me.radAdelantosSaldosPendientesDetallado.Checked Then
                If cmbAdelantosPendientes.SelectedIndex = 0 Then
                    'selecciono para ver el reporte de forma detallada
                    'adelantos con saldos
                    Try
                        Dim buscarAdelantos = (From a In ctx.Adelantos
                                               Where a.Saldo > 0
                                               Order By a.Fecha Ascending Select a).ToList()
                        Dim buscarClientes = (From cli In ctx.Cliente Order By cli.Nombres Ascending Select cli).ToList
                        If CodigoClienteSeleccionado.Length > 0 Then
                            buscarAdelantos = buscarAdelantos.Where(Function(c) c.Codcliente = CodigoClienteSeleccionado).ToList
                        End If
                        If buscarAdelantos.Count <= 0 Then
                            MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                            Return
                        End If
                        Dim report As New rptAdelantosConSaldos
                        report.Database.Tables(0).SetDataSource(buscarAdelantos)
                        report.Database.Tables(1).SetDataSource(buscarClientes)
                        'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                        frmReportes.viewer.ReportSource = report
                        frmReportes.Show()
                    Catch ex As Exception

                    End Try
                End If
                If Me.cmbAdelantosPendientes.SelectedIndex = 1 Then
                    'selecciono para ver el reporte de forma general
                    Try
                        Dim buscarAdelantos = (From a In ctx.Adelantos
                                               Join cli In ctx.Cliente On a.Codcliente Equals cli.Codcliente
                                               Where a.Saldo > 0 And SqlMethods.Like(a.Codcliente, "%" & Me.CodigoClienteSeleccionado & "%")
                                               Order By a.Fecha Ascending
                                               Group a By a.Codcliente, cli.Nombres, cli.Apellidos Into g = Group
                                               Select Codcliente, Nombres, Apellidos, Monto = g.Sum(Function(p) p.Monto),
                                               Saldo = g.Sum(Function(p) p.Saldo)).ToList()
                        If buscarAdelantos.Count <= 0 Then
                            MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                            Return
                        End If
                        Dim listaAdelantos As New List(Of AdelantosPendientesReport)
                        For Each dato In buscarAdelantos
                            Dim pendiente As New AdelantosPendientesReport
                            pendiente.Nombres = dato.Nombres
                            pendiente.Apellidos = dato.Apellidos
                            pendiente.Monto = dato.Monto
                            pendiente.Saldo = dato.Saldo
                            pendiente.CodCliente = dato.Codcliente
                            listaAdelantos.Add(pendiente)
                        Next
                        Dim report As New rptAdelantosConSaldosGeneral
                        report.SetDataSource(listaAdelantos)
                        'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                        frmReportes.viewer.ReportSource = report
                        frmReportes.Show()
                    Catch ex As Exception

                    End Try
                End If
                If cmbAdelantosPendientes.SelectedIndex = 2 Then
                    'adelantos en general, independientemente de si tiene saldo o no
                    'estos son filtrados por fecha
                    Try
                        Dim buscarAdelanto As New List(Of Adelantos)
                        Dim buscarCliente As New List(Of Cliente)
                        If CodigoClienteSeleccionado.Length > 0 Then
                            buscarAdelanto = (From a In ctx.Adelantos
                                              Where a.Codcliente = CodigoClienteSeleccionado And
                                                  a.Fecha >= txtDesdegen.Value And a.Fecha <= txtHastagen.Value
                                              Order By a.Fecha Ascending
                                              Select a).ToList
                            buscarCliente = (From c In ctx.Cliente
                                             Where c.Codcliente = CodigoClienteSeleccionado
                                             Order By c.Nombres Ascending
                                             Select c).ToList
                        Else
                            buscarAdelanto = (From a In ctx.Adelantos
                                              Where a.Fecha >= txtDesdegen.Value And a.Fecha <= txtHastagen.Value
                                              Order By a.Fecha Ascending
                                              Select a).ToList
                            buscarCliente = (From c In ctx.Cliente
                                             Order By c.Nombres Ascending
                                             Select c).ToList
                        End If
                        Dim rptAdelantog As New rptAdelantosGeneral
                        ParametrosCrystal(txtDesdegen.Value, txtHastagen.Value)
                        rptAdelantog.Database.Tables(0).SetDataSource(buscarAdelanto)
                        rptAdelantog.Database.Tables(1).SetDataSource(buscarCliente)
                        'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                        frmReportes.viewer.ReportSource = rptAdelantog
                        frmReportes.Show()
                    Catch ex As Exception

                    End Try
                End If
                If cmbAdelantosPendientes.SelectedIndex = 3 Then
                    'adelantos en general, independientemente de si tiene saldo o no
                    'estos son filtrados por fecha
                    Try
                        Dim buscarAdelanto As New List(Of Adelantos)
                        Dim buscarCliente As New List(Of Cliente)
                        buscarAdelanto = (From a In ctx.Adelantos
                                          Where a.Fecha >= txtDesdegen.Value And a.Fecha <= txtHastagen.Value
                                          Order By a.Fecha Ascending
                                          Select a).ToList
                        buscarCliente = (From c In ctx.Cliente
                                         Order By c.Nombres Ascending
                                         Select c).ToList
                        If CodigoClienteSeleccionado.Length > 0 Then
                            buscarAdelanto = buscarAdelanto.Where(Function(c) c.Codcliente = CodigoClienteSeleccionado).ToList
                            buscarCliente = buscarCliente.Where(Function(c) c.Codcliente = CodigoClienteSeleccionado).ToList
                        End If
                        Dim rptAdelantog As New rptAdelantos
                        ParametrosCrystal(txtDesdegen.Value, txtHastagen.Value)
                        rptAdelantog.Database.Tables(0).SetDataSource(buscarAdelanto)
                        rptAdelantog.Database.Tables(1).SetDataSource(buscarCliente)
                        'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                        frmReportes.viewer.ReportSource = rptAdelantog
                        frmReportes.Show()
                    Catch ex As Exception

                    End Try
                End If
                If cmbAdelantosPendientes.SelectedIndex = 4 Then
                    'forma en la que se aplico el adelanto
                    'reporte detallado
                    Try
                        Dim query = (From a In ctx.Adelantos Where a.Fecha >= txtDesdegen.Value And a.Fecha <= txtHastagen.Value Select a.Numcompra).AsEnumerable
                        Dim caracteres As String() = {"; ", "-", "."}
                        Dim numeroCompras = query.Where(Function(f) f.Length > 5).SelectMany(Function(f) f.Split(caracteres, StringSplitOptions.RemoveEmptyEntries)).Distinct.ToList
                        Dim compras = (From c In ctx.Compras Where numeroCompras.Contains(c.Numcompra) And c.Adelantos > 0 Select c).ToList
                        Dim value As Int16 = 0
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, tituloError)
                    End Try
                End If
            End If
            If radGeneral.Checked Then
                'buscamos todos los clientes
                Dim buscar = (From cli In ctx.Cliente
                              Where cli.F_ingreso >= txtDesdegen.Value And cli.F_ingreso <= txtHastagen.Value
                              Order By cli.Codcliente Ascending
                              Select cli).ToList()
                If buscar.Count <= 0 Then
                    MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                    Return
                End If
                Dim report As New rptGeneralClientes
                report.SetDataSource(buscar)
                ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            End If
            If radVariaciones.Checked Then
                Try
                    Dim variacionCliente As New List(Of VVariacionesCliente)
                    Dim buscar = (From cli In ctx.Cliente
                                  Join c In ctx.Compras On cli.Codcliente Equals c.Codcliente
                                  Where c.Fecha >= txtDesdegen.Value And c.Fecha <= txtHastagen.Value And cli.Monto_mensual > 1
                                  Order By c.Fecha Ascending
                                  Group By cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Monto_mensual
                                 Into MontoMensual = Sum(c.Total), Cantcompras = Count()
                                  Select Codcliente, Nombres, Apellidos, Monto = (Monto_mensual * tipoCambio), MontoMensual,
                                 Variacion = (MontoMensual / (Monto_mensual * tipoCambio)) * 100, Cantcompras Order By Nombres).ToList()
                    If CodigoClienteSeleccionado.Length > 0 Then
                        buscar = buscar.Where(Function(c) c.Codcliente = CodigoClienteSeleccionado).ToList
                    End If
                    If buscar.Count <= 0 Then
                        MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                        Return
                    End If
                    For Each dato In buscar
                        Dim variacionCli As New VVariacionesCliente
                        variacionCli.Codcliente = dato.Codcliente
                        variacionCli.Nombres = dato.Nombres
                        variacionCli.Apellidos = dato.Apellidos
                        variacionCli.Monto = dato.Monto
                        variacionCli.MontoMensual = dato.MontoMensual
                        variacionCli.Variacion = Decimal.Round(dato.Variacion, 2)
                        variacionCli.Cantcompras = dato.Cantcompras
                        variacionCliente.Add(variacionCli)
                    Next
                    Dim report As New rptVariacionCliente
                    report.SetDataSource(buscar)
                    ServiciosBasicos.ParametrosCrystal(txtDesdegen.Value, txtHastagen.Value)
                    frmReportes.viewer.ReportSource = report
                    frmReportes.Show()
                Catch ex As Exception
                    MsgBox("Error al dividir por cero. Revise la información del cliente para mostrar sus variaciones" & vbCr & ex.Message, MsgBoxStyle.Exclamation, tituloError)
                End Try
            End If
            If radTransaccionesEfectivo.Checked Then
                If Me.cmbTransacciones.SelectedIndex = 0 Then
                    'Transacciones en general
                    Dim buscar = (From cli In ctx.Cliente Join c In ctx.Compras On cli.Codcliente Equals c.Codcliente
                                  Where c.Fecha >= txtDesdegen.Value And c.Fecha <= txtHastagen.Value And c.Codestado <> 3
                                  Group cli, c By cli.Nombres, cli.Apellidos, cli.Codcliente
                              Into Total = Sum(c.Total), Transacciones = Count(), Peso = Sum(c.Peso)
                                  Order By Nombres Ascending
                                  Select Codcliente, Nombres, Apellidos, Total, Transacciones, Peso).ToList()
                    If String.IsNullOrEmpty(CodigoClienteSeleccionado) = False Then
                        buscar = buscar.Where(Function(c) c.Codcliente = CodigoClienteSeleccionado).ToList
                    End If
                    If buscar.Count <= 0 Then
                        MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                        Return
                    End If
                    Dim listar As New List(Of TransaccionEfectivo)
                    For Each dato In buscar
                        Dim valor As New TransaccionEfectivo
                        valor.Codcliente = dato.Codcliente
                        valor.Nombres = dato.Nombres
                        valor.Apellidos = dato.Apellidos
                        valor.Total = dato.Total
                        valor.Transacciones = dato.Transacciones
                        listar.Add(valor)
                    Next
                    Dim report As New rptTransacciones
                    report.SetDataSource(buscar)
                    ServiciosBasicos.ParametrosCrystal(txtDesdegen.Value, txtHastagen.Value)
                    frmReportes.viewer.ReportSource = report
                    frmReportes.Show()
                ElseIf Me.cmbTransacciones.SelectedIndex = 1 Then
                    'transacciones en detalle
                    Dim valor As Decimal
                    valor = Convert.ToDecimal(InputBox("Especifique una cantidad: ", "Rango", "10000")) * tipoCambio
                    'MsgBox("Valor: " & valor, MsgBoxStyle.OkCancel, "Valor")
                    Dim buscar = (From c In ctx.Compras
                                  Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                                  Where c.Fecha >= txtDesdegen.Value And c.Fecha <= txtHastagen.Value And
                             SqlMethods.Like(cli.Codcliente, "%" & Me.CodigoClienteSeleccionado & "%") And
                             c.Efectivo > valor Group By cli.Codcliente, cli.Nombres, cli.Apellidos Into g = Group
                                  Order By Nombres Ascending
                                  Select Codcliente, Nombres, Apellidos, Efectivo = g.Sum(Function(p) p.c.Efectivo),
                             Transferencia = g.Sum(Function(p) p.c.Transferencia), Cheque = g.Sum(Function(p) p.c.Cheque),
                             Adelantos = g.Sum(Function(p) p.c.Adelantos), Total = g.Sum(Function(p) p.c.Total),
                             Transacciones = g.Count(Function(p) p.c.Numcompra))
                    Dim listaTransacciones As New List(Of TransaccionEfectivo)
                    For Each dato In buscar
                        Dim tran As New TransaccionEfectivo
                        tran.Codcliente = dato.Codcliente
                        tran.Nombres = dato.Nombres
                        tran.Apellidos = dato.Apellidos
                        tran.Efectivo = dato.Efectivo
                        tran.Cheque = dato.Cheque
                        tran.Transferencia = dato.Transferencia
                        tran.Transacciones = dato.Transacciones
                        tran.Adelantos = dato.Adelantos
                        tran.Total = dato.Total
                        listaTransacciones.Add(tran)
                    Next
                    If buscar.Count <= 0 Then
                        MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                        Return
                    End If
                    Dim report As New rptTransaccionesEfectivo
                    report.SetDataSource(listaTransacciones)
                    ServiciosBasicos.ParametrosCrystal(txtDesdegen.Value, txtHastagen.Value)
                    frmReportes.viewer.ReportSource = report
                    frmReportes.Show()
                ElseIf Me.cmbTransacciones.SelectedIndex = 2 Then
                    'transacciones detallado por cliente
                    Dim valor As Decimal
                    valor = Convert.ToDecimal(InputBox("Especifique una cantidad: ", "Rango", "10000")) * tipoCambio
                    Dim buscar = (From c In ctx.Compras
                                  Join cli In ctx.Cliente On c.Codcliente Equals cli.Codcliente
                                  Where c.Fecha >= txtDesdegen.Value And c.Fecha <= txtHastagen.Value And
                             SqlMethods.Like(cli.Codcliente, "%" & Me.CodigoClienteSeleccionado & "%")
                                  Group By cli.Codcliente, cli.Nombres, cli.Apellidos, c.Numcompra Into g = Group
                                  Order By Nombres Ascending
                                  Select Codcliente, Nombres, Apellidos, Numcompra, Efectivo = g.Sum(Function(p) p.c.Efectivo),
                             Transferencia = g.Sum(Function(p) p.c.Transferencia), Cheque = g.Sum(Function(p) p.c.Cheque),
                             Adelantos = g.Sum(Function(p) p.c.Adelantos),
                             Total = g.Sum(Function(p) p.c.Total), Peso = g.Sum(Function(p) p.c.Peso))
                    Dim listaTransacciones As New List(Of TransaccionEfectivo)
                    For Each dato In buscar
                        Dim tran As New TransaccionEfectivo
                        tran.Codcliente = dato.Codcliente
                        tran.Nombres = dato.Nombres
                        tran.Apellidos = dato.Apellidos
                        tran.Numcompra = dato.Numcompra
                        tran.Efectivo = dato.Efectivo
                        tran.Cheque = dato.Cheque
                        tran.Transferencia = dato.Transferencia
                        tran.Adelantos = dato.Adelantos
                        tran.Total = dato.Total
                        tran.Peso = dato.Peso
                        listaTransacciones.Add(tran)
                    Next
                    If buscar.Count <= 0 Then
                        MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                        Return
                    End If
                    Dim report As New rptTransaccionesDetalladoCliente
                    report.SetDataSource(listaTransacciones)
                    ServiciosBasicos.ParametrosCrystal(txtDesdegen.Value, txtHastagen.Value)
                    frmReportes.viewer.ReportSource = report
                    frmReportes.Show()
                End If
            End If

            If radCatalogo.Checked Then
                'buscamos todos los clientes
                Dim buscar = (From cli In ctx.Cliente
                              Order By cli.Nombres Ascending
                              Select cli).ToList()
                'If buscar.Count <= 0 Then
                '    MsgBox("No hay datos a mostrar en la fecha indicada, intente nuevamente", MsgBoxStyle.Information, "Reporte de cliente")
                '    Return
                'End If
                Dim report As New rptCatalogoClientes
                report.SetDataSource(buscar)
                ServiciosBasicos.ParametrosCrystal(buscar.Count)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            End If
            If Me.radCatalogo_pic.Checked Then
                'buscamos todos los clientes
                Dim buscar = (From cli In ctx.Cliente
                              Where cli.Pica = 0
                              Order By cli.Nombres Ascending
                              Select cli).ToList()
                Dim report As New rptCatalogoPic
                report.SetDataSource(buscar)
                ServiciosBasicos.ParametrosCrystal(buscar.Count)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            End If
            If Me.radCatalogo_pica.Checked Then
                'buscamos todos los clientes
                Dim buscar = (From cli In ctx.Cliente
                              Where cli.Pica = 1
                              Order By cli.Nombres Ascending
                              Select cli).ToList()
                Dim pica = (From p In ctx.Pica
                            Join c In ctx.Cliente On p.Codcliente Equals c.Codcliente
                            Select p).ToList()
                Dim report As New rptCatalogoPica
                report.Database.Tables(0).SetDataSource(buscar)
                report.Database.Tables(1).SetDataSource(pica)
                ServiciosBasicos.ParametrosCrystal(buscar.Count)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            End If
            'reporte de reembolsos según cliente
            If Me.radReembolsos.Checked Then
                Dim buscar As New List(Of Compras_adelantos)
                Dim listaClientes As List(Of Cliente) = (From cli In ctx.Cliente
                                                         Where cli.Codcliente = Me.CodigoClienteSeleccionado
                                                         Select cli).ToList()
                Dim verAdelantosCliente As List(Of Adelantos) = (From a In ctx.Adelantos
                                                                 Where a.Codcliente = Me.CodigoClienteSeleccionado
                                                                 Select a).ToList
                Select Case Me.cmbReembolsos.SelectedIndex
                    Case 0
                        'historico de reembolsos
                        buscar = (From ca In ctx.Compras_adelantos
                                  Where ca.Codcliente = Me.CodigoClienteSeleccionado And
                                  ca.Fecha >= Me.txtDesdegen.Value And ca.Fecha <= Me.txtHastagen.Value
                                  Select ca).ToList()
                    Case 1
                        'reembolsos mayores a cero
                        buscar = (From ca In ctx.Compras_adelantos
                                  Let saldo = (From a In ctx.Adelantos Where a.Idsalida = ca.Idadelanto Select a.Saldo).First
                                  Where ca.Codcliente = Me.CodigoClienteSeleccionado And saldo > 0D _
                                    And ca.Fecha >= Me.txtDesdegen.Value And ca.Fecha <= Me.txtHastagen.Value
                                  Order By ca.Fecha Descending Select ca).ToList()
                    Case 2
                        'especifico por numero de adelanto
                        Dim numAdelanto As String
                        numAdelanto = InputBox("Especifique un adelanto para ver su detalle: ", "Número de adelanto", "")
                        buscar = (From ca In ctx.Compras_adelantos
                                  Where ca.Codcliente = Me.CodigoClienteSeleccionado And
                                  ca.Idadelanto = numAdelanto Order By ca.Fecha Ascending Select ca).ToList()
                    Case 3
                        'consolidado de aplicacion de adelantos
                        buscar = (From ca In ctx.Compras_adelantos
                                  Where ca.Codcliente = Me.CodigoClienteSeleccionado _
                                  And ca.Fecha >= Me.txtDesdegen.Value And ca.Fecha <= Me.txtHastagen.Value
                                  Order By ca.Idadelanto Descending, ca.Fecha Ascending Select ca).ToList()
                        Dim xSaldo As Decimal = 0D
                        For Each dato In verAdelantosCliente
                            If dato.Saldo > 0 Then
                                xSaldo = Decimal.Add(xSaldo, dato.Saldo)
                            End If
                        Next
                        Dim viewReport As New rptAdelantosAplicadosConsolidado
                        viewReport.Database.Tables(0).SetDataSource(buscar)
                        viewReport.Database.Tables(1).SetDataSource(listaClientes)
                        viewReport.Database.Tables(2).SetDataSource(verAdelantosCliente)
                        ServiciosBasicos.ParametrosCrystal(xSaldo, txtDesdegen.Value, txtHastagen.Value)
                        frmReportes.viewer.ReportSource = viewReport
                        frmReportes.Show()
                        Exit Sub
                End Select
                Dim totalSaldoAdelanto As Decimal = 0D
                For Each dato In verAdelantosCliente
                    If dato.Saldo > 0 Then
                        totalSaldoAdelanto = Decimal.Add(totalSaldoAdelanto, dato.Saldo)
                    End If
                Next
                Dim report As New rptAdelantosAplicados
                report.Database.Tables(0).SetDataSource(buscar)
                report.Database.Tables(1).SetDataSource(listaClientes)
                report.Database.Tables(2).SetDataSource(verAdelantosCliente)
                ServiciosBasicos.ParametrosCrystal(totalSaldoAdelanto, txtDesdegen.Value, txtHastagen.Value)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            End If
        End Using
    End Sub

    Private Sub UltraButton2_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtFiltrar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFiltrar.TextChanged
        Using ctx As New Contexto
            Try
                If radPornombre.Checked Then
                    Dim buscarCliente = (From cli In ctx.Cliente Where cli.Nombres.Contains(txtFiltrar.Text) Select cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Numcedula).ToList
                    dgvFiltrar.DataSource = buscarCliente
                ElseIf radPorcedula.Checked Then
                    Dim buscarCliente = (From cli In ctx.Cliente Where cli.Numcedula.Contains(txtFiltrar.Text) Select cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Numcedula).ToList
                    dgvFiltrar.DataSource = buscarCliente
                ElseIf radPorcodigo.Checked Then
                    Dim buscarCliente = (From cli In ctx.Cliente Where cli.Codcliente.Contains(txtFiltrar.Text) Select cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Numcedula).ToList
                    dgvFiltrar.DataSource = buscarCliente
                ElseIf radApellido.Checked Then
                    Dim buscarCliente = (From cli In ctx.Cliente Where cli.Apellidos.Contains(txtFiltrar.Text) Select cli.Codcliente, cli.Nombres, cli.Apellidos, cli.Numcedula).ToList
                    dgvFiltrar.DataSource = buscarCliente
                End If
            Catch ex As Exception
                MsgBox("Se produjo un error al buscar el cliente: " & ex.Message, MsgBoxStyle.Information, tituloError)
            End Try
        End Using
    End Sub

    Private Sub radPornombre_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPornombre.CheckedChanged
        If radPornombre.Checked Then
            txtFiltrar.Focus()
        End If
    End Sub
    Private Sub radApellido_CheckedChanged(sender As Object, e As EventArgs) Handles radApellido.CheckedChanged
        If Me.radApellido.Checked Then
            txtFiltrar.Focus()
        End If
    End Sub
    Private Sub radPorcedula_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPorcedula.CheckedChanged
        If radPorcedula.Checked Then
            txtFiltrar.Focus()
        End If
    End Sub

    Private Sub radPorcodigo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radPorcodigo.CheckedChanged
        If radPorcodigo.Checked Then
            txtFiltrar.Focus()
        End If
    End Sub

    Private Sub btnBuscardet_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscardet.Click
        Using ctx As New Contexto
            Dim row As DataGridViewRow = dgvFiltrar.CurrentRow
            'Dim daoCliente = DataContext.daoCliente
            Dim buscar As New List(Of Cliente)
            If radPornombre.Checked Then
                Dim nombre As String = row.Cells(1).Value
                buscar = daoCliente.recuperarPorNombre(nombre).Where(Function(c) c.Nombres.Equals(nombre) = True).ToList
            End If
            If radPorcedula.Checked Then
                Dim cedula As String = row.Cells(3).Value
                buscar = (From c In ctx.Cliente Where c.Numcedula = cedula Select c).ToList()
            End If
            If radPorcodigo.Checked Then
                Dim codigo As String = row.Cells(0).Value
                buscar = daoCliente.filtrarPorCodigo(codigo)
                'buscar = (From c In ctx.Cliente Where c.Codcliente = codigo Select c).ToList()
            End If
            For Each dato In buscar
                Dim cod As String = dato.Codcliente
                Dim rptContrato As New rptContratoCliente
                rptContrato.SetDataSource(buscar)
                frmReporteContrato.CrystalReportViewer1.ReportSource = rptContrato
                frmReporteContrato.Show()
                If dato.Pica = 1 Then
                    Dim report As New rptPica
                    Dim pica As List(Of Pica) = (From p In ctx.Pica Where p.Codcliente = cod Select p).ToList()
                    report.Database.Tables(0).SetDataSource(buscar)
                    report.Database.Tables(1).SetDataSource(pica)
                    Dim form As New frmReportePica
                    form.CrystalReportViewer1.ReportSource = report
                    form.Show()
                End If
                If dato.Pica = 0 Then
                    Dim report As New rptPic
                    report.SetDataSource(buscar)
                    Dim frmpic As New frmReportePic
                    frmpic.CrystalReportViewer1.ReportSource = report
                    frmpic.Show()
                End If
            Next
        End Using
    End Sub

    Private Sub dgvFiltrar_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFiltrar.CellClick
        Try
            Dim row As DataGridViewRow = dgvFiltrar.CurrentRow
            _codigoClienteSeleccionado = row.Cells(0).Value
            lblcodigocliente.Text = _codigoClienteSeleccionado
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnlimpiarSeleccion_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Me._codigoClienteSeleccionado = String.Empty
        lblcodigocliente.Text = Me._codigoClienteSeleccionado
    End Sub


    Private Sub radAdelantosSaldosPendientesDetallado_CheckedChanged(sender As Object, e As EventArgs) Handles radAdelantosSaldosPendientesDetallado.CheckedChanged
        If Me.radAdelantosSaldosPendientesDetallado.Checked Then
            Me.cmbAdelantosPendientes.Visible = True
            cmbAdelantosPendientes.SelectedIndex = 0
        Else
            Me.cmbAdelantosPendientes.Visible = False
        End If
    End Sub

    Private Sub radTransaccionesEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles radTransaccionesEfectivo.CheckedChanged
        If Me.radTransaccionesEfectivo.Checked Then
            Me.cmbTransacciones.Visible = True
            cmbTransacciones.SelectedIndex = 0
        Else
            Me.cmbTransacciones.Visible = False
        End If
    End Sub

    Private Sub fillDataTable_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles fillDataTable.DoWork
        Try
            tablaCliente = Me.llenarDataTable()
        Catch ex As Exception
            MsgBox("no se pudo llenar el grid devido al siguiente error: " & ex.Message, MsgBoxStyle.Critical, tituloError)
        End Try
    End Sub
    Private Sub llenarGrid()
        Me.dgvFiltrar.DataSource = Me.llenarDataTable
    End Sub

    Private Sub radReembolsos_CheckedChanged(sender As Object, e As EventArgs) Handles radReembolsos.CheckedChanged
        If Me.radReembolsos.Checked Then
            Me.cmbReembolsos.Visible = True
            Me.cmbReembolsos.SelectedIndex = 0
        Else
            Me.cmbReembolsos.Visible = False
        End If
    End Sub

    Private Sub radReserva_CheckedChanged(sender As Object, e As EventArgs) Handles radReserva.CheckedChanged
        If Me.cmbReserva.Visible = False Then
            Me.cmbReserva.Visible = True
            Me.cmbReserva.SelectedIndex = 0
        Else
            Me.cmbReserva.Visible = False
        End If
    End Sub
End Class

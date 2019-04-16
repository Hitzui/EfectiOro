Imports System.ComponentModel
Imports CrystalDecisions.Shared
Imports EfectiOro.Database
Imports Infragistics.Win.UltraWinGrid

Public Class frmAdelantosReportes
    Private Const formatMoneda As String = "#,###,#00.00"
    Private Const [error] As String = "Error"

    Sub loadClientes()
        Dim dao = DataContext.daoCliente
        Dim daoAdelanto = DataContext.daoAdelantos
        Dim adelantos = daoAdelanto.findAll().Select(Function(a) a.Codcliente).ToList
        Dim buscar = dao.filtrarPorNombrePorApellido(txtFiltrar.Text).Where(Function(a) adelantos.Contains(a.Codcliente)).ToList
        bsClientes.DataSource = buscar
    End Sub

    Sub loadAdelantosCliente(codcliente As String)
        Try
            Dim daoAdelantos = DataContext.daoAdelantos
            Dim findByCliente = daoAdelantos.listarAdelantosPorClientes(codcliente)
            AdelantosBindingSource.DataSource = findByCliente
        Catch ex As Exception
            MsgBox("Error al filtrar por cliente: " & vbCr & ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub

    Private Sub frmAdelantosReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Reportes de Adelantos"
        loadClientes()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtFiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrar.TextChanged
        loadClientes()
    End Sub

    Sub datosAdelantosGrid()
        Try
            Dim daoParametroas = DataContext.daoParametros
            Dim daoAdelantos = DataContext.daoAdelantos
            Dim desde, hasta As Date
            desde = txtDesde.Value
            hasta = txtHasta.Value
            Dim codCliente As String = String.Empty
            Dim row As DataGridViewRow = dgvClientes.CurrentRow
            codCliente = row.Cells("colCodcliente").Value
            Dim filtrar = daoAdelantos.listarAdelantosPorFecha(desde, hasta, codCliente)
            AdelantosBindingSource.DataSource = filtrar
            Dim param = daoParametroas.recuperarParametros
            Dim saldoCordobas As Decimal = filtrar.Where(Function(a) a.Codmoneda = param.cordobas).Sum(Function(a) a.Saldo)
            Dim saldoDolares As Decimal = filtrar.Where(Function(a) a.Codmoneda = param.dolares).Sum(Function(a) a.Saldo)
            lblSaldoCordobas.Text = saldoCordobas.ToString(formatMoneda)
            lblSaldoDolares.Text = saldoDolares.ToString(formatMoneda)
            cambiarValorMostrarMoneda()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        datosAdelantosGrid()
    End Sub

    Private Sub dgvClientes_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellEnter
        datosAdelantosGrid()
    End Sub

    Private Sub cambiarValorMostrarMoneda()
        Try
            Dim daoParametros = DataContext.daoParametros
            Dim parametros = daoParametros.recuperarParametros
            For Each row As DataGridViewRow In AdelantosDataGridView.Rows
                Dim celda = Convert.ToInt32(row.Cells("Codmoneda").Value)
                Select Case celda
                    Case parametros.cordobas
                        row.Cells("nombreCliente").Value = "Cordobas"
                    Case parametros.dolares
                        row.Cells("nombreCliente").Value = "Dolares"
                End Select
            Next
        Catch ex As Exception
            MsgBox("Moneda: " & ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub

    Private Sub txtDesde_ValueChanged(sender As Object, e As EventArgs) Handles txtDesde.ValueChanged
        datosAdelantosGrid()
    End Sub
    Private Sub txtHasta_ValueChanged(sender As Object, e As EventArgs) Handles txtHasta.ValueChanged
        datosAdelantosGrid()
    End Sub
    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        Try
            Dim daoCliente = DataContext.daoCliente
            Dim daoAdelanto = DataContext.daoAdelantos
            Dim daoParametros = DataContext.daoParametros
            Dim param = daoParametros.recuperarParametros
            Dim rowAdelanto = AdelantosDataGridView.CurrentRow
            Dim Parametros As ParameterFields = New ParameterFields()
            Dim rowCliente As DataGridViewRow = dgvClientes.CurrentRow
            Dim desde As Date = txtDesde.Value
            Dim hasta As Date = txtHasta.Value
            Dim codcliente As String = rowCliente.Cells("colCodcliente").Value
            Dim nombre_Cliente As String = rowCliente.Cells("colNombres").Value & " " & rowCliente.Cells("colApellidos").Value
            Dim idAdelanto As String = rowAdelanto.Cells("Idsalida").Value
            Dim listaClientes = daoCliente.findAll.Where(Function(c) c.Codcliente = codcliente).ToList
            Dim compras_adelantos = daoAdelanto.listarAdelantosComrpasCliente(codcliente)
            If radVerAdelanto.Checked Then
                Dim parMoneda As ParameterField = New ParameterField()
                Dim disMoneda As ParameterDiscreteValue = New ParameterDiscreteValue()
                parMoneda.ParameterFieldName = "Moneda"
                Dim codmoneda As Int32 = rowAdelanto.Cells("Codmoneda").Value
                Select Case codmoneda
                    Case param.cordobas
                        disMoneda.Value = "Cordobas"
                    Case param.dolares
                        disMoneda.Value = "Dolares"
                    Case Else
                        disMoneda.Value = "Sin Valor"
                End Select
                parMoneda.CurrentValues().Add(disMoneda)
                Parametros.Add(parMoneda)
                Dim sel_adelanto = daoAdelanto.findAll.Where(Function(a) a.Idsalida = idAdelanto).ToList()
                sel_adelanto.ForEach(Sub(s As Adelantos) s.nombreCliente = nombre_Cliente)
                Dim report As New rptVerAdelantoDetalle
                report.Database.Tables(0).SetDataSource(sel_adelanto)
                report.Database.Tables(1).SetDataSource(compras_adelantos)
                frmReporteReciboAdelantoAbono.viewer.ReportSource = report
                frmReporteReciboAdelantoAbono.viewer.ParameterFieldInfo = Parametros
                frmReporteReciboAdelantoAbono.Show()
            End If
            If radAdelantoCliente.Checked Then
                Dim findAelantos = daoAdelanto.listarAdelantosPorFecha(desde, hasta, codcliente)
                findAelantos.ForEach(Sub(a) If a.Codmoneda = param.cordobas Then a.nombreCliente = "Cordobas" Else If a.Codmoneda = param.dolares Then a.nombreCliente = "Dolares")
                Select Case cmbAdelantoCliente.SelectedIndex
                    Case 0
                        'Detallado por fecha
                        Dim report As New rptAdelantosAplicados
                        report.Database.Tables(0).SetDataSource(compras_adelantos)
                        report.Database.Tables(1).SetDataSource(listaClientes)
                        report.Database.Tables(2).SetDataSource(findAelantos)
                        Dim frm As New Form
                        frm.WindowState = FormWindowState.Maximized
                        frm.Text = "Reporte Reembolsos por fecha"
                        ServiciosBasicos.ParametrosCrystal(desde, hasta, frm, report)
                    Case 1
                        'consolidado por fecha
                        Dim saldoCordobas = findAelantos.Where(Function(a) a.Codmoneda = param.cordobas).Sum(Function(a) a.Saldo)
                        Dim saldodolares = findAelantos.Where(Function(a) a.Codmoneda = param.dolares).Sum(Function(a) a.Saldo)
                        findAelantos.ForEach(Sub(a) If a.Codmoneda = param.cordobas Then a.saldoCordobas = saldoCordobas)
                        Dim report As New rptAdelantosConsolidado
                        report.Database.Tables(0).SetDataSource(compras_adelantos)
                        report.Database.Tables(1).SetDataSource(listaClientes)
                        report.Database.Tables(2).SetDataSource(findAelantos)
                        Dim frm As New Form
                        frm.Text = "Reporte Reembolsos por fecha"
                        frm.WindowState = FormWindowState.Maximized
                        ServiciosBasicos.ParametrosCrystal(desde, hasta, frm, report)
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub
    Shared Sub Process(items As List(Of Integer))
        Dim result As Integer = 10
        For Each item As Integer In items
            result *= item
            result -= item * 2
        Next item
    End Sub

    Private Sub radAdelantoCliente_CheckedChanged(sender As Object, e As EventArgs) Handles radAdelantoCliente.CheckedChanged
        If radAdelantoCliente.Checked Then
            cmbAdelantoCliente.Enabled = True
            cmbAdelantoCliente.SelectedIndex = 0
        Else
            cmbAdelantoCliente.Enabled = False
        End If
    End Sub



    Private Sub AdelantosDataGridView_CellChange(sender As Object, e As CellEventArgs)
        Try
            rowAdelanto = e.Cell.Row()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub


End Class
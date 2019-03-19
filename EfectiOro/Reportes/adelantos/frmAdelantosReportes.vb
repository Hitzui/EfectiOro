Imports System.ComponentModel
Imports CrystalDecisions.Shared
Imports EfectiOro.Database

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
            Dim daoAdelantos = DataContext.daoAdelantos
            Dim daoParam = DataContext.daoParametros
            Dim desde, hasta As Date
            desde = txtDesde.Value
            hasta = txtHasta.Value
            Dim codCliente As String = String.Empty
            Dim row As DataGridViewRow = dgvClientes.CurrentRow
            codCliente = row.Cells("colCodcliente").Value
            Dim filtrar = daoAdelantos.listarAdelantosPorFecha(txtDesde.Value, txtHasta.Value, codCliente)
            AdelantosBindingSource.DataSource = filtrar
            Dim param = daoParam.recuperarParametros
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
                Dim celda = Convert.ToInt32(row.Cells("DataGridViewTextBoxColumn17").Value)
                Select Case celda
                    Case parametros.cordobas
                        row.Cells("DataGridViewTextBoxColumn3").Value = "Cordobas"
                    Case parametros.dolares
                        row.Cells("DataGridViewTextBoxColumn3").Value = "Dolares"
                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub

    Private Sub txtDesde_ValueChanged(sender As Object, e As EventArgs) Handles txtDesde.ValueChanged
        datosAdelantosGrid()
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        Try
            Dim Parametros As ParameterFields = New ParameterFields()
            Dim rowAdelanto As DataGridViewRow = AdelantosDataGridView.CurrentRow
            Dim rowCliente As DataGridViewRow = dgvClientes.CurrentRow
            Dim nombre_Cliente As String = rowCliente.Cells("colNombres").Value & " " & rowCliente.Cells("colApellidos").Value
            Dim idAdelanto As String = rowAdelanto.Cells("DataGridViewTextBoxColumn4").Value
            Dim daoAdelanto = DataContext.daoAdelantos
            If radVerAdelanto.Checked Then
                Dim parMoneda As ParameterField = New ParameterField()
                Dim disMoneda As ParameterDiscreteValue = New ParameterDiscreteValue()
                parMoneda.ParameterFieldName = "Moneda"
                disMoneda.Value = rowAdelanto.Cells("DataGridViewTextBoxColumn3").Value
                parMoneda.CurrentValues().Add(disMoneda)
                Parametros.Add(parMoneda)
                Dim sel_adelanto = daoAdelanto.findAll.Where(Function(a) a.Idsalida = idAdelanto).ToList()
                sel_adelanto.ForEach(Sub(s As Adelantos) s.nombreCliente = nombre_Cliente)
                Dim compras_adelantos = daoAdelanto.listarAdelantosComrpas(idAdelanto)
                Dim report As New rptVerAdelantoDetalle
                report.Database.Tables(0).SetDataSource(sel_adelanto)
                report.Database.Tables(1).SetDataSource(compras_adelantos)
                frmReporteReciboAdelantoAbono.viewer.ReportSource = report
                frmReporteReciboAdelantoAbono.viewer.ParameterFieldInfo = Parametros
                frmReporteReciboAdelantoAbono.Show()
            End If
            If radAdelantoCliente.Checked Then
                Select Case cmbAdelantoCliente.SelectedIndex
                    Case 0
                        'Detallado por fecha   

                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
    Shared Sub Process(items As List(Of Integer))
        Dim result As Integer = 10
        For Each item As Integer In items
            result *= item
            result -= item * 2
        Next item
    End Sub
End Class
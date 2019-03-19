Imports System.ComponentModel
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
            Dim row As DataGridViewRow = AdelantosDataGridView.CurrentRow
            Dim idAdelanto As String = row.Cells("DataGridViewTextBoxColumn4").Value
            Dim daoAdelanto = DataContext.daoAdelantos
            If radVerAdelanto.Checked Then
                Dim sel_adelanto = daoAdelanto.findAll.Where(Function(a) a.Idsalida = idAdelanto).ToList
                Dim compras_adelantos = daoAdelanto.listarAdelantosComrpas(idAdelanto)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

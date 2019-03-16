Imports System.ComponentModel
Imports EfectiOro.Database

Public Class frmAdelantosReportes
    Private Const formatMoneda As String = "#,###,#00.00"
    Private Const [error] As String = "Error"

    Sub loadClientes()
        Dim daoClientes = DataContext.daoCliente
        bsClientes.DataSource = daoClientes.findAll
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
        Dim dao = DataContext.daoCliente
        Dim buscar = dao.filtrarPorNombrePorApellido(txtFiltrar.Text)
        bsClientes.DataSource = buscar
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


End Class

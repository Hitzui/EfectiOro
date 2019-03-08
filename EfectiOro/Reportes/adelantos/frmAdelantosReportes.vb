Imports System.ComponentModel
Imports EfectiOro.Database

Public Class frmAdelantosReportes
    Private Const formatMoneda As String = "#,###,#00.00"
    Private Const [error] As String = "Error"

    Sub loadClientes()
        Dim daoClientes = DataContext.daoCliente
        bsClientes.DataSource = daoClientes.findAll
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

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        Try
            Using ctx As New Contexto
                Dim codCliente As String = String.Empty
                Dim row As DataGridViewRow = dgvClientes.CurrentRow
                codCliente = row.Cells("colCodcliente").Value
                Dim filtrar = (From a In ctx.Adelantos Where a.Codcliente = codCliente And a.Saldo > 0 Select a).ToList
                Dim param = (From p In ctx.Ids Select p).First
                Dim saldoCordobas As Decimal = filtrar.Where(Function(a) a.Codmoneda = param.cordobas).Sum(Function(a) a.Saldo)
                Dim saldoDolares As Decimal = filtrar.Where(Function(a) a.Codmoneda = param.dolares).Sum(Function(a) a.Saldo)
                lblSaldoCordobas.Text = saldoCordobas.ToString(formatMoneda)
                lblSaldoDolares.Text = saldoDolares.ToString(formatMoneda)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub

    Private Sub dgvClientes_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellEnter
        Try
            Using ctx As New Contexto
                Dim codCliente As String = String.Empty
                Dim row As DataGridViewRow = dgvClientes.CurrentRow
                codCliente = row.Cells("colCodcliente").Value
                Dim filtrar = (From a In ctx.Adelantos Where a.Codcliente = codCliente And a.Saldo > 0 Select a).ToList
                Dim param = (From p In ctx.Ids Select p).First
                Dim saldoCordobas As Decimal = filtrar.Where(Function(a) a.Codmoneda = param.cordobas).Sum(Function(a) a.Saldo)
                Dim saldoDolares As Decimal = filtrar.Where(Function(a) a.Codmoneda = param.dolares).Sum(Function(a) a.Saldo)
                lblSaldoCordobas.Text = saldoCordobas.ToString(formatMoneda)
                lblSaldoDolares.Text = saldoDolares.ToString(formatMoneda)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, [error])
        End Try
    End Sub


End Class

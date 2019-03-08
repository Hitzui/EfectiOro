Imports EfectiOro.Database

Public Class frmAdelantosReportes

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
End Class

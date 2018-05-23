Imports EfectiOro.Database

Public Class frmReservaRpt

    Private reservaSeleccionada As ReservaOro
    Private codigo_cliente As String = String.Empty
    Private daoCliente As IDaoCliente
    Private daoReserva As IDaoReservaOro
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        daoReserva = New DaoReservaOro
        daoCliente = New DaoCliente
        ' Add any initialization after the InitializeComponent() call.
        If IsNothing(frmReservaOro.reservaSelected) = True Then

        Else
            reservaSeleccionada = frmReservaOro.reservaSelected
        End If
    End Sub
    Private Sub frmReservaRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Reportes de cierre de precios"
        If IsNothing(frmReservaOro.reservaSelected) = False Then
            lblSeleccion.Text = "Reserva seleccionada: " & reservaSeleccionada.Idreserva
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Function buscarPorCliente(codigo As String) As Integer
        Dim buscar As List(Of ReservaOro) = daoReserva.findByCliente(codigo)
        If buscar Is Nothing Then
            buscar = New List(Of ReservaOro)
            Return 0
        End If
        If buscar.Count <= 0 Then
            Return 0
        End If
        If listReservas.Items.Count > 0 Then
            listReservas.Items.Clear()
        End If
        For Each b In buscar
            listReservas.Items.Add(b.Idreserva)
        Next
        Return buscar.Count
    End Function
    Private Sub seleccionarFila()
        Try
            Dim rowSelect As DataGridViewRow = dgvClientes.CurrentRow
            Dim codcliente As String = rowSelect.Cells("codigoCliente").Value
            If Me.buscarPorCliente(codcliente) = 0 Then
                MsgBox("El cliente seleccionado no tiene cierre de precios.", MsgBoxStyle.Information, "Buscar")
                txtFiltrar.Focus()
            Else
                Dim listar = daoReserva.findByCliente(codcliente)
                lblClienteSeleccionado.Text = rowSelect.Cells("nombrecliente").Value & " " & rowSelect.Cells("apellidoCliente").Value
                Me.codigo_cliente = codcliente
                'dgvClientes.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub txtFiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrar.TextChanged
        Using ctx As New Contexto
            Dim filtrar = (From cli In ctx.Cliente
                               Where System.Data.Linq.SqlClient.SqlMethods.Like(cli.Nombres, "%" & txtFiltrar.Text & "%")
                               Select cli.Codcliente, cli.Nombres, cli.Apellidos).ToList()
            dgvClientes.Rows.Clear()
            For Each dato In filtrar
                dgvClientes.Rows.Add(dato.Codcliente, dato.Nombres, dato.Apellidos)
            Next
        End Using
    End Sub

    Private Sub txtFiltrar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltrar.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                Me.dgvClientes.Focus()
        End Select
    End Sub

    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvClientes.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                seleccionarFila()
        End Select
    End Sub

    Private Sub listReservas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listReservas.SelectedIndexChanged
        Try
            Dim index As Integer = 0
            For Each items As ListViewItem In listReservas.Items
                If items.Selected Then
                    index = items.Index
                End If
            Next
            Dim idreserva = Convert.ToInt32(listReservas.Items(index).Text)
            lblSeleccion.Text = "Reserva seleccionada: " & idreserva
        Catch ex As Exception

        End Try
    End Sub

    Private Sub radGeneral_CheckedChanged(sender As Object, e As EventArgs) Handles radGeneral.CheckedChanged
        If radGeneral.Checked Then
            If cmbGeneral.Visible = False Then
                cmbGeneral.Visible = True
                cmbGeneral.SelectedIndex = 0
            End If
        Else
            If cmbGeneral.Visible = True Then
                cmbGeneral.Visible = False
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Using ctx As New Contexto
                If radGeneral.Checked Then
                    Select Case cmbGeneral.SelectedIndex
                        Case 0
                            'todos  
                            Dim clientes = (From cli In ctx.Cliente Select cli).ToList
                            Dim reservas = (From rev In ctx.ReservaOro
                                            Where rev.FechaReserva <= txtHasta.Value And _
                                            rev.FechaReserva >= txtDesde.Value And rev.Estado = True
                                            Select rev).ToList
                            If reservas.Count <= 0 Then
                                MsgBox("No hay datos a mostrar según el rango de fecha, intente nuevamente.", MsgBoxStyle.Information, "Buscar")
                                Return
                            End If
                            Dim rpt As New rptReservaPorCliente
                            Dim rptFrm As New frmReporteReservas
                            rpt.Database.Tables(0).SetDataSource(clientes)
                            rpt.Database.Tables(1).SetDataSource(reservas)
                            ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value, rptFrm, rpt)
                        Case 1
                            'detallado'
                            Dim clientes = (From cli In ctx.Cliente Select cli).ToList
                            Dim reservas = (From rev In ctx.ReservaOro
                                            Where rev.FechaReserva <= txtHasta.Value And _
                                            rev.FechaReserva >= txtDesde.Value And rev.Estado = True
                                            Select rev).ToList
                            Dim detaReserva = (From deta In ctx.DetaReserva
                                               Where deta.fecha >= txtDesde.Value And deta.fecha <= txtHasta.Value _
                                               And reservas.Select(Function(a) a.Idreserva).Contains(deta.idreserva)
                                               Select deta).ToList
                            If reservas.Count <= 0 Then
                                MsgBox("No hay datos a mostrar según el rango de fecha, intente nuevamente.", MsgBoxStyle.Information, "Buscar")
                                Return
                            End If
                            Dim rpt As New rptDetalladoReserva
                            Dim rptFrm As New frmReporteReservas
                            rpt.Database.Tables(0).SetDataSource(clientes)
                            rpt.Database.Tables(1).SetDataSource(detaReserva)
                            rpt.Database.Tables(2).SetDataSource(reservas)
                            ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value, rptFrm, rpt)
                    End Select
                End If
                If radPorCliente.Checked Then
                    Select Case cmbporcliente.SelectedIndex
                        Case 0
                            'general
                            Dim clientes = (From cli In ctx.Cliente Select cli).ToList
                            Dim reservas = (From rev In ctx.ReservaOro
                                            Where rev.FechaReserva <= txtHasta.Value And _
                                            rev.FechaReserva >= txtDesde.Value And rev.Estado = True
                                            Select rev).ToList
                            If reservas.Count <= 0 Then
                                MsgBox("No hay datos a mostrar según el rango de fecha, intente nuevamente.", MsgBoxStyle.Information, "Buscar")
                                Return
                            End If
                            Dim rpt As New rptReservaPorCliente
                            Dim rptFrm As New frmReporteReservas
                            rpt.Database.Tables(0).SetDataSource(clientes)
                            rpt.Database.Tables(1).SetDataSource(reservas)
                            ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value, rptFrm, rpt)
                        Case 1
                            'detallado
                    End Select
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error al intentar filtrar la informacion." & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub radPorCliente_CheckedChanged(sender As Object, e As EventArgs) Handles radPorCliente.CheckedChanged
        If radPorCliente.Checked Then
            cmbporcliente.Visible = True
            cmbporcliente.SelectedIndex = 0
        Else
            cmbporcliente.Visible = False
        End If
    End Sub
End Class

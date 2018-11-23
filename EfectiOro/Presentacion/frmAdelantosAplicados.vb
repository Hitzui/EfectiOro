Imports EfectiOro.Database


Public Class frmAdelantosAplicados

    Public Property numeroCompra As String
    Public Property codigoCliente As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        numeroCompra = String.Empty
        codigoCliente = String.Empty
    End Sub
    Private Sub recuperarAdelantos()
        Using ctx As New Contexto
            Try
                Dim sumsaldo As Decimal = 0D
                Dim maySaldo As Decimal = 0D
                Dim minSaldo As Decimal = 100000D
                Dim tipocambio = (From tc In ctx.TipoCambio Where tc.Fecha = Now.Date Select tc).Single
                Dim parametros = ctx.Ids.First
                dgvAdelantos.Rows.Clear()
                Dim listar = (From a In ctx.Adelantos
                              Join cli In ctx.Cliente On a.Codcliente Equals cli.Codcliente
                              Where a.Saldo > 0
                              Order By a.Idsalida Ascending
                              Select New With {a.Idsalida,
                                               a.Codcliente,
                                               .Nombres = cli.Nombres & " " & cli.Apellidos,
                                               a.Fecha, a.Hora,
                                               a.Monto, a.Saldo,
                                               a.Codcaja, a.Usuario, a.Codmoneda}).ToList()
                For Each dato In listar
                    Dim saldo As Decimal = dato.Saldo
                    Select Case dato.Codmoneda
                        Case parametros.dolares
                            saldo = Decimal.Multiply(dato.Saldo, tipocambio.Tipocambio1)
                        Case parametros.cordobas
                            saldo = dato.Saldo
                    End Select
                    If saldo <= minSaldo Then
                        minSaldo = saldo
                    End If
                    If saldo >= maySaldo Then
                        maySaldo = saldo
                    End If
                    sumsaldo = Decimal.Add(sumsaldo, saldo)
                    dgvAdelantos.Rows.Add(dato.Idsalida, dato.Codcliente, dato.Nombres, dato.Fecha, dato.Hora, dato.Monto, dato.Saldo, dato.Codcaja, dato.Usuario)
                Next
                Me.lblSaldoStatus.Text = "Total de Saldo pendientes de pago: " & sumsaldo.ToString("#,###,#00.00")
                Me.lblSaldoMayor.Text = "Saldo mayor: " & maySaldo.ToString("#,###,#00.00")
                Me.lblMenorSaldo.Text = "Saldo menor: " & minSaldo.ToString("#,###,#00.00")
            Catch ex As Exception
                MsgBox("NO hay datos a mostrar debido al siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    Private Sub frmAdelantosAplicados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Detalle de adelantos"
        Me.recuperarAdelantos()
        Me.txtFiltrar.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvAdelantos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAdelantos.CellClick
        Try

            Dim row As DataGridViewRow = dgvAdelantos.CurrentRow
            Dim idAdelanto As String = CStr(row.Cells("colIdsalida").Value)
            Me.codigoCliente = CStr(row.Cells("colCodcliente").Value)
            Dim dao As IDaoAdelantos = DataContext.daoAdelantos
            Dim adelantoCliente As Adelantos = dao.findByCodigoAdelanto(idAdelanto)
            Dim comprasAplicadas() As String = adelantoCliente.Numcompra.Split(CChar("; "))
            For Each valor As String In comprasAplicadas

            Next
        Catch ex As Exception
            'MsgBox("Error al intentar filtrar los adelantos del cliente: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtFiltrar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFiltrar.TextChanged
        Using ctx As New Contexto
            Try
                Dim saldo As Decimal = 0D
                Dim maySaldo As Decimal = 0D
                Dim minSaldo As Decimal = 1000000D
                Dim sumSaldo As Decimal = 0D
                Dim parametros = ctx.Ids.First
                Dim tipocambio = (From tc In ctx.TipoCambio Where tc.Fecha.Date = Now.Date Select tc).First
                dgvAdelantos.Rows.Clear()
                Dim listar = (From a In ctx.Adelantos
                              Join cli In ctx.Cliente On a.Codcliente Equals cli.Codcliente
                              Where a.Saldo > 0 And System.Data.Linq.SqlClient.SqlMethods.Like(cli.Nombres, "%" & Me.txtFiltrar.Text & "%")
                              Select New With {a.Idsalida,
                                               a.Codcliente,
                                               .Nombres = cli.Nombres & " " & cli.Apellidos,
                                               a.Fecha, a.Hora,
                                               a.Monto, a.Saldo,
                                               a.Codcaja, a.Usuario, a.Codmoneda}).ToList()
                For Each dato In listar
                    Select Case dato.Codmoneda
                        Case parametros.dolares
                            saldo = Decimal.Multiply(dato.Saldo, tipocambio.Tipocambio1)
                        Case parametros.cordobas
                            saldo = dato.Saldo
                    End Select
                    If saldo <= minSaldo Then
                        minSaldo = saldo
                    End If
                    If saldo >= maySaldo Then
                        maySaldo = saldo
                    End If
                    sumSaldo += saldo
                    dgvAdelantos.Rows.Add(dato.Idsalida, dato.Codcliente, dato.Nombres, dato.Fecha, dato.Hora, dato.Monto, dato.Saldo, dato.Codcaja, dato.Usuario)
                Next
                Me.lblSaldoStatus.Text = "Total de Saldo pendientes de pago: " & sumSaldo.ToString("#,###,#00.00")
                Me.lblSaldoMayor.Text = "Saldo mayor: " & maySaldo.ToString("#,###,#00.00")
                Me.lblMenorSaldo.Text = "Saldo menor: " & minSaldo.ToString("#,###,#00.00")
            Catch ex As Exception
                MsgBox("NO hay datos a mostrar debido al siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    Private Sub listCompras_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) 'Handles listCompras.MouseClick
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
            Case Windows.Forms.MouseButtons.Right
                Me.menuDerecho.Show()
        End Select
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        Try
            Clipboard.SetDataObject(Me.numeroCompra)
            MsgBox("Copiado al portapapeles el numero: " & Me.numeroCompra, MsgBoxStyle.Exclamation, "Clipboard")
        Catch ex As Exception
            MsgBox("Error al copiar producido por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub VerCompraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerCompraToolStripMenuItem.Click
        Dim daoCompra = DataContext.daoCompras
        Dim daoCliente = DataContext.daoCliente
        Try
            Dim compra As Compras = daoCompra.findCompraById(numeroCompra, "")
            frmVerDetalleCompras.CompraSeleccionada = compra
            Dim cliente As Cliente = daoCliente.findById(Me.codigoCliente)
            frmVerDetalleCompras.ClienteSeleccionado = cliente
            frmVerDetalleCompras.btnCancelar.Visible = False
            frmVerDetalleCompras.ShowDialog()
        Catch ex As Exception
            MsgBox("Seleccione una compra para poder ver sus detalles", MsgBoxStyle.Information, "Ver compras")
        End Try
    End Sub

    Private Sub dgvAdelantos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvAdelantos.SelectionChanged
        Try
            'Me.listCompras.Items.Clear()
            Dim row As DataGridViewRow = dgvAdelantos.CurrentRow
            Dim idAdelanto As String = CStr(row.Cells("colIdsalida").Value)
            Me.codigoCliente = CStr(row.Cells("colCodcliente").Value)
            Dim dao As IDaoAdelantos = DataContext.daoAdelantos
            Dim adelantoCliente As Adelantos = dao.findByCodigoAdelanto(idAdelanto)
            Dim comprasAplicadas() As String = adelantoCliente.Numcompra.Split(CChar("; "))
            If comprasAplicadas.Count <= 0 Then
                Me.listCompras.Items.Add("No hay compras aplicadas")
            Else
                Me.listCompras.DataSource = comprasAplicadas.Select(Function(p) p.Trim).ToArray()
            End If
        Catch ex As Exception
            'MsgBox("Error al intentar filtrar los adelantos del cliente: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub imprimir(codigoAdelanto As String, nombre As String)
        Using ctx As New Contexto
            Try
                Dim buscar = (From a In ctx.Adelantos Where a.Idsalida = codigoAdelanto Select a).ToList()
                Dim saldoActual As Decimal = (From a In ctx.Adelantos Where a.Codcliente = codigoCliente And a.Saldo > 0
                          Group By a.Codcliente Into g = Group Select saldo = g.Sum(Function(p) p.Saldo)).First()
                Dim listar As New List(Of Adelantos)
                For Each dato In buscar
                    Dim adelanto As New Adelantos
                    adelanto.Idsalida = dato.Idsalida
                    adelanto.Monto_letras = dato.Monto_letras
                    adelanto.Fecha = dato.Fecha
                    adelanto.Hora = dato.Hora
                    adelanto.Monto = dato.Monto
                    adelanto.nombreCliente = nombre
                    adelanto.Saldo = saldoActual
                    listar.Add(adelanto)
                Next
                Dim report As New rptReciboAdelanto
                report.SetDataSource(listar)
                'ServiciosBasicos.ParametrosCrystal(buscar.Count, txtDesdegen.Value, txtHastagen.Value)
                frmReportes.viewer.ReportSource = report
                frmReportes.Show()
            Catch ex As Exception

            End Try
        End Using
    End Sub
    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim row As DataGridViewRow = dgvAdelantos.CurrentRow
            Dim numadelanto As String = row.Cells("colIdsalida").Value
            Dim nombres As String = row.Cells("colNombres").Value
            Me.imprimir(numadelanto, nombres)
        Catch ex As Exception
            MsgBox("se produjo el siguiente error al intentar imprimir: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UltraButton2_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            Dim dao = DataContext.daoAdelantos
            Dim row As DataGridViewRow = dgvAdelantos.CurrentRow
            Dim codigo As String = row.Cells("colIdsalida").Value
            If MsgBox("¿Seguro desea anular el adelanto seleccionado del sistema?", MsgBoxStyle.YesNo, "Anular adelanto") = MsgBoxResult.No Then
                Return
            End If
            If dao.anularAdelanto(codigo) = True Then
                MsgBox("Se ha anulado el adelanto con código N°: " & codigo, MsgBoxStyle.Information, "Revertir adelanto")
                Me.recuperarAdelantos()
            Else
                MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UltraButton3_Click(sender As Object, e As EventArgs) Handles btnAdelantoEfectivo.Click
        frmAplicarAdelantoEfectivo.Show()
    End Sub
    Private Sub verCompras()
        Dim daoCompra = DataContext.daoCompras
        Dim daoCliente = DataContext.daoCliente
        Dim agencia As String = "%%"
        If listCompras.Items.Count <= 0 Then
            MsgBox("NO hay items en la lista para poder ver la compra", MsgBoxStyle.Information, "Ver ccompra")
            Return
        End If
        Try
            Dim seleccion_compra() As String = listCompras.SelectedItem.ToString().Split(CChar("-"))
            If seleccion_compra.Length > 1 Then
                agencia = seleccion_compra(0)
                Me.numeroCompra = seleccion_compra(1)
            Else
                agencia = "%%"
                Me.numeroCompra = listCompras.SelectedItem
            End If
            Dim compra As Compras = daoCompra.findCompraById(numeroCompra, agencia)
            frmVerDetalleCompras.CompraSeleccionada = compra
            Dim cliente As Cliente = daoCliente.findById(Me.codigoCliente)
            frmVerDetalleCompras.ClienteSeleccionado = cliente
            frmVerDetalleCompras.btnCancelar.Visible = False
            frmVerDetalleCompras.ShowDialog()
        Catch ex As Exception
            MsgBox("Seleccione una compra para poder ver sus detalles", MsgBoxStyle.Information, "Ver compras")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.verCompras()
    End Sub


End Class

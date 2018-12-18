Imports EfectiOro.Database

Public Class frmVerAdelantos
    Private Const _tituloError As String = "Error"
    Private codigoCliente, numeroCompra As String
    Private verAdelanto As New Adelantos()
    Private montoCompra, saldoTotal As Decimal
    Private _codmoneda As Integer = 0
    Private valorSeleccionadoMonto As Decimal = Decimal.Zero
    ''' <summary>
    ''' Adelantos seleccionados
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared adelantoSeleccionados As List(Of Adelantos)

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        frmVerAdelantos.adelantoSeleccionados = New List(Of Adelantos)
    End Sub
    Sub llenarGrid()
        dgvAdelanto.Rows.Clear()
        Dim dao = DataContext.daoAdelantos
        Dim daoParametros = DataContext.daoParametros
        Dim param = daoParametros.recuperarParametros
        Dim daoTipoCambio = DataContext.daoTipoCambio
        Dim tipoCambio = daoTipoCambio.buscarDato(Now.Date)
        Try
            saldoTotal = Decimal.Zero
            Dim listar As List(Of Adelantos) = dao.listarAdelantosPorClientes(codigoCliente)
            Dim seleccionar As Boolean = True
            For Each dato As Adelantos In listar
                Dim descMoneda As String
                If dato.Codmoneda = param.dolares Then
                    Dim dolares = Decimal.Multiply(dato.Saldo, tipoCambio.Tipocambio1)
                    saldoTotal = Decimal.Add(saldoTotal, dolares)
                    descMoneda = "Dolares"
                Else
                    saldoTotal = Decimal.Add(saldoTotal, dato.Saldo)
                    descMoneda = "Cordobas"
                End If
                valorSeleccionadoMonto = saldoTotal
                'valorSeleccionadoMonto = redondearMas(valorSeleccionadoMonto, 0.01)
                adelantoSeleccionados.Add(dato)
                dgvAdelanto.Rows.Add(seleccionar, dato.Idsalida, dato.Fecha, dato.Monto, dato.Saldo, descMoneda)
            Next
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Information, _tituloError)
        End Try
    End Sub

    Private Sub frmVerAdelantos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtSaldo.Clear()
        txtSaldo.Focus()
        lblTitulo.Text = "Adelantos del Cliente"
        Me.codigoCliente = frmCompras.txtCodcliente.Text
        Me.numeroCompra = frmCompras.txtNumcompra.Text
        Me.txtCodcliente.Text = Me.codigoCliente
        Me.txtNumcompra.Text = Me.numeroCompra
        Me.llenarGrid()
        lblSaldoTotal.Text = saldoTotal.ToString("#,###,#00.00")
        Me.montoCompra = frmCompras.totalGeneral
        _codmoneda = frmCompras._codmoneda
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnAplicarSaldo_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarSaldo.Click
        Dim saldo As Decimal = Decimal.Zero
        Try
            If txtSaldo.TextLength <= 0 Then
                MsgBox("Especifique un saldo a apalicar a la compra", MsgBoxStyle.Critical, "Adelantos")
                Return
            Else
                saldo = Convert.ToDecimal(txtSaldo.Text)
            End If
            If valorSeleccionadoMonto < saldo Then
                MsgBox("El saldo a aplicar es mayor que el saldo del adelanto del cliente, intente nuevamente", MsgBoxStyle.Information, "Adelantos")
                Return
            End If
            If saldo > frmCompras.totalGeneral Then
                MsgBox("El saldo a aplicar es mayor que el monto de la compra, intente nuevamente", MsgBoxStyle.Information, "Adelantos")
                Return
            End If
            frmCompras.aplicarAdelanto = saldo
            frmCompras.txtAdelantos.Text = saldo
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSaldo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldo.KeyPress
        ServiciosBasicos.NumeroDec(e, txtSaldo)
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtSaldo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSaldo.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                Me.btnAplicarSaldo.Focus()
        End Select
    End Sub

    Private Sub UltraButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click
        Me.txtSaldo.Clear()
        txtSaldo.Focus()
        Me.codigoCliente = frmCompras.txtCodcliente.Text
        Me.numeroCompra = frmCompras.txtNumcompra.Text
        Me.txtCodcliente.Text = Me.codigoCliente
        Me.txtNumcompra.Text = Me.numeroCompra
        Me.llenarGrid()
        lblSaldoTotal.Text = saldoTotal.ToString("#,###,#00.00")
        Me.montoCompra = frmCompras.totalGeneral
    End Sub

    Private Sub dgvAdelanto_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdelanto.CellValueChanged
        Me.validarSeleccionGrid(e)
    End Sub

    Sub validarSeleccionGrid(e As DataGridViewCellEventArgs)
        Try
            Dim dao = DataContext.daoAdelantos
            Dim daoParam = DataContext.daoParametros
            Dim daoTipoCambio = DataContext.daoTipoCambio
            Dim param = daoParam.recuperarParametros
            Dim tipocambio = daoTipoCambio.buscarDato(Now.Date)
            Dim dolares = Decimal.Zero
            If dgvAdelanto.Columns(e.ColumnIndex).Name = "colSeleccionar" Then
                Dim row As DataGridViewRow = dgvAdelanto.Rows(e.RowIndex)
                Dim cellSeleccion As DataGridViewCheckBoxCell = row.Cells("colSeleccionar")
                Dim addAdelanto As Adelantos = dao.findByCodigoAdelanto(Convert.ToString(row.Cells("colCodigo").Value))
                Dim saldo As Decimal = Convert.ToDecimal(row.Cells("colSaldo").Value)
                If Convert.ToBoolean(cellSeleccion.Value) = True Then
                    If addAdelanto.Codmoneda = param.dolares Then
                        dolares = Decimal.Multiply(addAdelanto.Saldo, tipocambio.Tipocambio1)
                        valorSeleccionadoMonto = Decimal.Add(valorSeleccionadoMonto, dolares)
                    Else
                        valorSeleccionadoMonto = Decimal.Add(valorSeleccionadoMonto, saldo)
                    End If
                    adelantoSeleccionados.Add(addAdelanto)
                Else
                    If addAdelanto.Codmoneda = param.dolares Then
                        dolares = Decimal.Multiply(saldo, tipocambio.Tipocambio1)
                        valorSeleccionadoMonto = Decimal.Subtract(valorSeleccionadoMonto, dolares)
                    Else
                        valorSeleccionadoMonto = Decimal.Subtract(valorSeleccionadoMonto, saldo)
                    End If
                    Dim find = frmVerAdelantos.adelantoSeleccionados.Find(Function(d) d.Idsalida = addAdelanto.Idsalida)
                    adelantoSeleccionados.Remove(find)
                End If
                saldoTotal = Decimal.Round(valorSeleccionadoMonto, 2)
                lblSaldoTotal.Text = Convert.ToString(valorSeleccionadoMonto.ToString("#,###,#00.00"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

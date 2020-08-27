Imports EfectiOro.Database

Public Class frmVerAdelantos
    Private Const _tituloError As String = "Error"
    Private Const Format As String = "#,###,#00.00"
    Private codigoCliente, numeroCompra As String
    Private verAdelanto As New Adelantos()
    Private montoCompra, saldoTotal As Decimal
    Private montoCompraDolares As Decimal = 0D
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
            Dim seleccionar As Boolean
            If adelantoSeleccionados.Count = 0 Then
                adelantoSeleccionados.AddRange(listar)
            End If
            For Each dato As Adelantos In listar
                Dim descMoneda As String = "Dolares"
                If adelantoSeleccionados.Exists(Function(a) a.Idsalida = dato.Idsalida) Then
                    seleccionar = True
                    If dato.Codmoneda = param.dolares Then
                        'Dim dolares = Decimal.Multiply(dato.Saldo, tipoCambio.Tipocambio1)
                        saldoTotal = Decimal.Add(saldoTotal, dato.Saldo)
                    Else
                        Dim dolares = Decimal.Divide(dato.Saldo, tipoCambio.Tipocambio1)
                        saldoTotal = Decimal.Add(saldoTotal, dolares)
                        'descMoneda = "Cordobas"
                    End If
                Else
                    seleccionar = False
                End If
                valorSeleccionadoMonto = saldoTotal
                'adelantoSeleccionados.Add(dato)
                dgvAdelanto.Rows.Add(seleccionar, dato.Idsalida, dato.Fecha, dato.Monto, dato.Saldo, descMoneda)
            Next
            montoCompraDolares = Decimal.Divide(montoCompra, tipoCambio.Tipocambio1)
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & vbCr & dao.ErrorSms, MsgBoxStyle.Information, _tituloError)
        End Try
    End Sub

    Private Sub frmVerAdelantos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        montoCompra = frmCompras.totalGeneral
        Me.txtSaldo.Clear()
        txtSaldo.Focus()
        lblTitulo.Text = "Adelantos del Cliente"
        Me.codigoCliente = frmCompras.txtCodcliente.Text
        Me.numeroCompra = frmCompras.txtNumcompra.Text
        Me.txtCodcliente.Text = Me.codigoCliente
        Me.txtNumcompra.Text = Me.numeroCompra
        Me.llenarGrid()
        lblSaldoTotal.Text = saldoTotal.ToString(Format)
        lblMontoCompra.Text = "U$ " & montoCompraDolares.ToString(Format)
        '_codmoneda = frmCompras._codmoneda
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnAplicarSaldo_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarSaldo.Click
        Dim saldo As Decimal = Decimal.Zero
        montoCompraDolares = Decimal.Round(montoCompraDolares, 2)
        Try
            If txtSaldo.TextLength <= 0 Then
                MsgBox("Especifique un saldo a apalicar a la compra", MsgBoxStyle.Critical, "Adelantos")
                Return
            Else
                saldo = Convert.ToDecimal(txtSaldo.Text)
            End If
            If saldoTotal < saldo Then
                MsgBox("El saldo a aplicar es mayor que el saldo del adelanto del cliente, intente nuevamente", MsgBoxStyle.Information, "Adelantos")
                Return
            End If
            If saldo > montoCompraDolares Then
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
        lblSaldoTotal.Text = "U$ " & saldoTotal.ToString(Format)
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
                        'dolares = Decimal.Multiply(addAdelanto.Saldo, tipocambio.Tipocambio1)
                        valorSeleccionadoMonto = Decimal.Add(valorSeleccionadoMonto, saldo)
                    ElseIf addAdelanto.Codmoneda = param.cordobas Then
                        dolares = Decimal.Divide(saldo, tipocambio.Tipocambio1)
                        valorSeleccionadoMonto = Decimal.Add(valorSeleccionadoMonto, dolares)
                    End If
                    adelantoSeleccionados.Add(addAdelanto)
                Else
                    If addAdelanto.Codmoneda = param.dolares Then
                        'dolares = Decimal.Multiply(saldo, tipocambio.Tipocambio1)
                        valorSeleccionadoMonto = Decimal.Subtract(valorSeleccionadoMonto, saldo)
                    ElseIf addAdelanto.Codmoneda = param.cordobas Then
                        dolares = Decimal.Divide(saldo, tipocambio.Tipocambio1)
                        valorSeleccionadoMonto = Decimal.Subtract(valorSeleccionadoMonto, dolares)
                    End If
                    Dim find = frmVerAdelantos.adelantoSeleccionados.Find(Function(d) d.Idsalida = addAdelanto.Idsalida)
                    adelantoSeleccionados.Remove(find)
                End If
                saldoTotal = Me.valorSeleccionadoMonto
                lblSaldoTotal.Text = "U$ " & valorSeleccionadoMonto.ToString(Format)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

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
        _codmoneda = frmCompras._codmoneda
        Try
            saldoTotal = Decimal.Zero
            Dim listar As List(Of Adelantos) = dao.listarAdelantosPorClientes(codigoCliente)
            Dim seleccionar As Boolean
            For Each dato As Adelantos In listar
                If _codmoneda <> dato.Codmoneda Then
                    seleccionar = False
                Else
                    seleccionar = True
                End If
                dgvAdelanto.Rows.Add(seleccionar, dato.Idsalida, dato.Fecha, dato.Monto, dato.Saldo)
                adelantoSeleccionados.Add(dato)
                saldoTotal += dato.Saldo
                valorSeleccionadoMonto = saldoTotal
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
            If saldoTotal < saldo Then
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
            If dgvAdelanto.Columns(e.ColumnIndex).Name = "colSeleccionar" Then
                Dim row As DataGridViewRow = dgvAdelanto.Rows(e.RowIndex)
                Dim cellSeleccion As DataGridViewCheckBoxCell = row.Cells("colSeleccionar")
                Dim addAdelanto As Adelantos = dao.findByCodigoAdelanto(Convert.ToString(row.Cells("colCodigo").Value))
                If addAdelanto.Codmoneda <> _codmoneda Then
                    MsgBox("No se puede seleccionar el adelanto ya que el tipo de moneda de la compras es distinto al adelanto, intente nuevamente", MsgBoxStyle.Information, "Adelanto")
                    row.Cells("colseleccionar").Value = False
                    Return
                End If
                If Convert.ToBoolean(cellSeleccion.Value) = True Then
                    valorSeleccionadoMonto += Convert.ToDecimal(row.Cells("colSaldo").Value)
                    adelantoSeleccionados.Add(addAdelanto)
                Else
                    valorSeleccionadoMonto -= Convert.ToDecimal(row.Cells("colSaldo").Value)
                    Dim find = frmVerAdelantos.adelantoSeleccionados.Find(Function(d) d.Idsalida = addAdelanto.Idsalida)
                    adelantoSeleccionados.Remove(find)
                End If
                saldoTotal = Me.valorSeleccionadoMonto
                lblSaldoTotal.Text = Convert.ToString(valorSeleccionadoMonto)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

Imports EfectiOro.Database

Public Class frmVerDetalleCompras
    ''' <summary>
    ''' Obtiene o estable la compra seleccionada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CompraSeleccionada As Compras
    ''' <summary>
    ''' Obtiene o estable la lista de detalle de la compra
    ''' </summary>
    ''' <value>Compras</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ListaDetalleCompra As List(Of Det_compra)
    ''' <summary>
    ''' Obtiene o establece el cliente seleccionado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ClienteSeleccionado As Cliente
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Me.CompraSeleccionada = frmCompras.CompraActual
        'Me.ListaDetalleCompra = frmCompras.DetalleComprasActual
        'Me.ClienteSeleccionado = frmCompras.ClienteActual
        Me.btnAceptar.Select()
        Me.btnAceptar.Focus()
    End Sub
    Sub llenarDatos()
        'datos del cliente
        If CompraSeleccionada Is Nothing Then
            CompraSeleccionada = New Compras
        End If
        Me.lblNombre.Text = Me.ClienteSeleccionado.Nombres & " " & Me.ClienteSeleccionado.Apellidos
        Me.lblDireccion.Text = Me.ClienteSeleccionado.Direccion
        ' Me.lblNumero.Text = Me.CompraSeleccionada.Numcompra
        Me.lblPeso.Text = Me.CompraSeleccionada.Peso
        Me.lblTotal.Text = Me.CompraSeleccionada.Total.ToString("#,###,##0.00")
        Me.lblEfectivo.Text = Me.CompraSeleccionada.Efectivo.ToString("#,###,##0.00")
        Me.lblCheque.Text = Me.CompraSeleccionada.Cheque.ToString("#,###,##0.00")
        Me.lblPorpagar.Text = Me.CompraSeleccionada.Por_pagar.ToString("#,###,##0.00")
        Me.lblTransferencia.Text = Me.CompraSeleccionada.Transferencia.ToString("#,###,##0.00")
        Me.lblAdelanto.Text = Me.CompraSeleccionada.Adelantos.ToString("#,###,##0.00")
        Select Case Me.CompraSeleccionada.Codestado
            Case 0
                Me.lblEstado.Text = "Anulada"
            Case 1
                Me.lblEstado.Text = "Vigente"
            Case 2
                Me.lblEstado.Text = "Cerrada"
            Case 3
                Me.lblEstado.Text = "Descargada"
        End Select
    End Sub

    Private Sub frmVerDetalleCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Detalle de compras del cliente: " & Me.ClienteSeleccionado.Codcliente
        Me.btnAceptar.Focus()
        Me.btnClose.Visible = False
        Me.llenarDatos()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnAceptar_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAceptar.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.DialogResult = Windows.Forms.DialogResult.No
        End Select
    End Sub
End Class
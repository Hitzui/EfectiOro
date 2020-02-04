Imports EfectiOro.Database
Imports CrystalDecisions.Shared

Public Class frmAplicarAdelantoEfectivo

    Public codigoCliente As String
    Private saldoTotal As Decimal = 0D
    Private valorSeleccionadoMonto As Decimal = Decimal.Zero
    Public adelantoSeleccionados As List(Of Adelantos)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        adelantoSeleccionados = New List(Of Adelantos)
    End Sub

    Function recuperarMoneda(codmoneda As Integer) As Moneda
        Using ctx As New Contexto
            Try
                Return ctx.Moneda.Where(Function(m) m.Codmoneda = codmoneda).First
            Catch ex As Exception
                Return New Moneda
            End Try
        End Using
    End Function

    Public Sub cerrar()
        Me.saldoTotal = Decimal.Zero
        Me.adelantoSeleccionados.Clear()
        Me.Close()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.cerrar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.cerrar()
    End Sub

    Private Sub init()
        Me.txtCodcliente.Text = codigoCliente
        Me.txtSaldo.Clear()
        Try
            If adelantoSeleccionados.Count > 0 Then
                Me.adelantoSeleccionados.Clear()
            End If
            Me.dgvAdelanto.Rows.Clear()
            saldoTotal = Decimal.Zero
            valorSeleccionadoMonto = Decimal.Zero
            Dim daoCliente = DataContext.daoCliente
            Dim findCliente = daoCliente.findById(Me.codigoCliente)
            Me.txtNombre.Text = findCliente.Nombres & " " & findCliente.Apellidos
            Dim daoAdelantos = DataContext.daoAdelantos
            Dim findAdelantos = daoAdelantos.listarAdelantosPorClientes(Me.codigoCliente)
            For Each dato As Adelantos In findAdelantos
                Dim moneda = recuperarMoneda(dato.Codmoneda)
                dgvAdelanto.Rows.Add(False, dato.Idsalida, dato.Fecha, dato.Monto, dato.Saldo, moneda.Descripcion)
            Next
        Catch ex As Exception
            MsgBox("Error al recuperar los adelantos, lea la siguiente instruccion: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmAplicarAdelantoEfectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Aplicar efectivo a adelanto"
        Me.codigoCliente = frmAdelantosAplicados.codigoCliente
        Me.init()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Me.init()
    End Sub
    Private Sub dgvAdelanto_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdelanto.CellValueChanged
        Me.validarSeleccionGrid(e)
    End Sub
    Sub validarSeleccionGrid(e As DataGridViewCellEventArgs)
        Try
            Dim dao = DataContext.daoAdelantos
            If dgvAdelanto.Columns(e.ColumnIndex).Name = "colSeleccionar2" Then
                Dim row As DataGridViewRow = dgvAdelanto.Rows(e.RowIndex)
                Dim cellSeleccion As DataGridViewCheckBoxCell = row.Cells("colSeleccionar2")
                Dim addAdelanto As Adelantos = dao.findByCodigoAdelanto(CStr(row.Cells("colCodigo").Value))
                If Convert.ToBoolean(cellSeleccion.Value) = True Then
                    'valorSeleccionadoMonto += Convert.ToDecimal(row.Cells("colSaldo").Value)
                    adelantoSeleccionados.Add(addAdelanto)
                Else
                    'valorSeleccionadoMonto -= Convert.ToDecimal(row.Cells("colSaldo").Value)
                    Dim find = adelantoSeleccionados.Find(Function(d) d.Idsalida = addAdelanto.Idsalida)
                    adelantoSeleccionados.Remove(find)
                End If
                'saldoTotal = Me.valorSeleccionadoMonto
                'lblSaldo.Text = valorSeleccionadoMonto.ToString("#,###,###.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Warning")
        End Try
    End Sub

    Private Sub btnAplicarSaldo_Click(sender As Object, e As EventArgs) Handles btnAplicarSaldo.Click
        Dim saldoAplicar As Decimal = Decimal.Zero
        If Me.txtSaldo.Text.Length <= 0 Then
            MsgBox("Especifique un monto para aplicar")
            Return
        End If
        For Each row As DataGridViewRow In dgvAdelanto.Rows
            If row.Cells("colSeleccionar2").Value = True Then
                saldoTotal += Convert.ToDecimal(row.Cells("colSaldo").Value)
            End If
        Next
        If Me.adelantoSeleccionados.Count <= 0 Then
            MsgBox("Especifique los adelantos a aplicar el monto", MsgBoxStyle.Information, "Aplicar")
            Return
        End If
        saldoAplicar = Convert.ToDecimal(Me.txtSaldo.Text)
        If saldoTotal < saldoAplicar Then
            MsgBox("El monto a aplicar es mayor al saldo disponible, intente nuevamente", MsgBoxStyle.Exclamation, "Información")
            Return
        End If
        If MsgBox("¿Desea aplicar el monto de C$ " & txtSaldo.Text & " a los adelantos seleccionados?", MsgBoxStyle.YesNo, "Aplicar") = vbNo Then
            Return
        End If
        'If saldoTotal < saldoAplicar Then
        '    MsgBox("NO puede aplicar un monto mayor al disponible por el cliente, por favor intente nuevamente", MsgBoxStyle.Information, "Aplicar monto")
        '    Return
        'End If
        Dim config As New ConfiguracionGeneral
        Dim caja As String = config.getCaja
        Dim cod_agencia = config.getAgencia
        Dim daoCaja = DataContext.daoMcaja
        Try
            If daoCaja.validarCajaAbierta(caja) = False Then
                MsgBox("La caja actual quedó abierta, cierre la caja y vuelva a abrirla para realizar la transacción.",
                       MsgBoxStyle.Information, "Adelantos")
                Return
            End If
        Catch ex As Exception
            MsgBox("No existe la caja actual, por favor intente nuevamente." &
                   vbCr & "Se produjo el siguiente error:" & daoCaja.ErrorSms, MsgBoxStyle.Critical, "Error")
            Return
        End Try
        Dim daoAdelanto = DataContext.daoAdelantos
        Dim daoCliente = DataContext.daoCliente
        Dim daoAgencia = DataContext.daoAgencia
        If daoAdelanto.aplicarAdelantoEfectivo(adelantoSeleccionados, saldoAplicar, Me.codigoCliente) Then
            MsgBox("Aplicación de efectivo a adelanto(s) seleccionado(s) de forma correcta", MsgBoxStyle.Information, "Aplicar")
            If MsgBox("¿Imprimir recibo de pago de reembolso?", MsgBoxStyle.YesNo, "Imprimir") = MsgBoxResult.Yes Then
                Dim listaAdelantos = daoAdelanto.findAll.Where(Function(a) a.Codcliente = Me.codigoCliente).ToList()
                Dim lista As New List(Of Adelantos)
                Dim codigosAdelantos As String = String.Empty
                For Each dato As Adelantos In adelantoSeleccionados
                    For Each valor As Adelantos In listaAdelantos
                        If valor.Idsalida = dato.Idsalida Then
                            If String.IsNullOrEmpty(codigosAdelantos) Then
                                codigosAdelantos = valor.Idsalida
                            Else
                                codigosAdelantos = codigosAdelantos & "; " & valor.Idsalida
                            End If
                            lista.Add(valor)
                            Continue For
                        End If
                    Next
                Next
                Dim agencias = daoAgencia.findAll().Where(Function(a) a.Codagencia = cod_agencia).ToList
                Dim cliente = daoCliente.findById(Me.codigoCliente)
                Dim listaCliente As New List(Of Cliente)
                listaCliente.Clear()
                listaCliente.Add(cliente)
                Dim saldoCliente As Decimal = listaAdelantos.Sum(Function(c) c.Saldo)
                Dim reporte As New rptReciboAdelantoAbono
                'ServiciosBasicos.ParametrosCrystal(saldoCliente, saldoAplicar, codigosAdelantos, "Saldo", "saldoAplicar")
                Dim parametros As ParameterFields = New ParameterFields()
                Dim parTotal As New ParameterField()
                Dim disTotal As New ParameterDiscreteValue()
                Dim parSaldo As New ParameterField()
                Dim disSaldo As New ParameterDiscreteValue()
                Dim parCodigoAdelantos As New ParameterField()
                Dim disCodigoAdelantos As New ParameterDiscreteValue()
                parTotal.ParameterFieldName = "Saldo"
                parSaldo.ParameterFieldName = "saldoAplicar"
                parCodigoAdelantos.ParameterFieldName = "codigoAdelantos"
                'Paso los Datos        
                disTotal.Value = saldoCliente
                disSaldo.Value = saldoAplicar
                disCodigoAdelantos.Value = codigosAdelantos
                'agregamos al report viewer        
                parTotal.CurrentValues.Add(disTotal)
                parSaldo.CurrentValues.Add(disSaldo)
                parCodigoAdelantos.CurrentValues.Add(disCodigoAdelantos)
                'Cargo los parametros y los envio al Crystal        
                parametros.Add(parTotal)
                parametros.Add(parSaldo)
                parametros.Add(parCodigoAdelantos)
                frmReporteReciboAdelantoAbono.viewer.ParameterFieldInfo = parametros
                reporte.Database.Tables(0).SetDataSource(lista)
                reporte.Database.Tables(1).SetDataSource(listaCliente)
                reporte.Database.Tables(2).SetDataSource(agencias)
                frmReporteReciboAdelantoAbono.viewer.ReportSource = reporte
                frmReporteReciboAdelantoAbono.Show()
            End If
            Me.Close()
        Else
            MsgBox("Se produjo el siguiente error: " & daoAdelanto.ErrorSms)
        End If
    End Sub
    Private Sub imprimir(codigoAdelanto As String, nombre As String)
        Using ctx As New Contexto
            Try
                Dim buscar = (From a In ctx.Adelantos Where a.Idsalida = codigoAdelanto Select a).ToList()
                Dim listar As New List(Of Adelantos)
                For Each dato In buscar
                    Dim adelanto As New Adelantos
                    adelanto.Idsalida = dato.Idsalida
                    adelanto.Monto_letras = dato.Monto_letras
                    adelanto.Fecha = dato.Fecha
                    adelanto.Hora = dato.Hora
                    adelanto.Monto = dato.Monto
                    adelanto.nombreCliente = nombre
                    'adelanto.Saldo = Me.saldoActual
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

    Private Sub txtSaldo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSaldo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnAplicarSaldo.Focus()
        End Select
    End Sub
End Class

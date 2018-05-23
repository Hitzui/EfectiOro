Imports System.Data.SqlClient
Imports EfectiOro.Database

Public Class frmReservaOro
    Private auxiliar As Integer = 0
    Private daoCliente As IDaoCliente
    Private daoReserva As IDaoReservaOro
    Public Shared reservaSelected As ReservaOro
    Private detaReservaSelected As DetaReserva
    Public Sub New()
        daoCliente = New DaoCliente
        daoReserva = New DaoReservaOro
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Function buscarReserva(idreserva As Integer) As ReservaOro
        Me.detaReservaSelected = daoReserva.findSaldoReserva(idreserva)
        reservaSelected = daoReserva.findReserva(idreserva)
        Return reservaSelected
    End Function
    Private Sub frmReservaOro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Formulario Reserva de oro"
    End Sub
    Private Sub habilitarBotones(nuevo As Boolean, editar As Boolean, guardar As Boolean, cancelar As Boolean)
        Me.btnEditar.Enabled = nuevo
        Me.btnGuardar.Enabled = guardar
        Me.btnCancelar.Enabled = cancelar
        Me.btnNuevo.Enabled = nuevo
    End Sub
    Private Sub habilitarGrupos(opcion As Boolean)
        grupoCliente.Enabled = opcion
        grupoDatos.Enabled = opcion
        listReservas.Enabled = opcion
        dgvCliente.Enabled = opcion
    End Sub
    Private Sub cancelar(opcion As Boolean)
        habilitarGrupos(opcion)
        habilitarBotones(True, True, False, False)
        erp.Clear()
    End Sub
    Private Sub habiliatarTextBoxs(habilitar As Boolean, inhabilitar As Boolean)
        Me.listReservas.Enabled = inhabilitar
        Me.txtFechaCierre.Enabled = habilitar
        Me.txtFechaEntrega.Enabled = inhabilitar
        Me.txtOnzasEntregadas.Enabled = inhabilitar
        Me.txtNombres.Enabled = habilitar
        Me.txtApellidos.Enabled = habilitar
        Me.txtCodigo.Enabled = habilitar
        Me.txtGramos.Enabled = habilitar
        Me.txtOnzas.Enabled = habilitar
        Me.txtPrecioInternacional.Enabled = habilitar
        Me.txtPrecioKilate.Enabled = habilitar
        Me.txtKilate.Enabled = habilitar
    End Sub
    Private Sub limpiarCampos()
        For Each control In Me.Controls
            If control.GetType Is GetType(ListView) Then
                Dim listcontrol As ListView = control
                listcontrol.Items.Clear()
            End If
            If control.GetType Is GetType(GroupBox) Then
                Dim controlGroup As GroupBox = control
                For Each c In controlGroup.Controls
                    If c.GetType Is GetType(TextBox) Then
                        Dim txtControl As TextBox = c
                        txtControl.Clear()
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub seleccionarFila()
        Try
            Dim rowSelect As DataGridViewRow = dgvCliente.CurrentRow
            txtNombres.Text = rowSelect.Cells(1).Value
            rowSelect = dgvCliente.CurrentRow
            txtApellidos.Text = rowSelect.Cells(2).Value
            rowSelect = dgvCliente.CurrentRow
            txtCodigo.Text = rowSelect.Cells(0).Value
            Me.dgvCliente.Visible = False
            If auxiliar = 2 Then
                If Me.buscarPorCliente(txtCodigo.Text) = 0 Then
                    MsgBox("El cliente seleccionado no tiene cierre de precios.", MsgBoxStyle.Information, "Buscar")
                    Me.cancelar(False)
                    Me.limpiarCampos()
                    btnCerrar.Enabled = False
                Else
                    Dim listar = daoReserva.findByCliente(txtCodigo.Text)
                    Dim sumaSaldos As Decimal = Decimal.Zero
                    Dim sumaEntregadas As Decimal = Decimal.Zero
                    For Each dato In listar
                        Dim buscarDetalle = daoReserva.findSaldoReserva(dato.Idreserva)
                        sumaSaldos = Decimal.Add(sumaSaldos, buscarDetalle.diferencia)
                        sumaEntregadas = Decimal.Add(sumaEntregadas, daoReserva.findDetaReserva(dato.Idreserva).Sum(Function(p) p.entregadas))
                    Next
                    lblInformacion.Text = "Saldo del cliente: " & sumaSaldos.ToString("#,###,#00.000") & " -- Onzas entregadas: " & sumaEntregadas.ToString("#,###,#00.000")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.auxiliar = 1
        habilitarBotones(False, False, True, True)
        habilitarGrupos(True)
        habiliatarTextBoxs(True, False)
        listReservas.Enabled = False
        Me.btnReporte.Visible = False
        Me.txtNombres.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.auxiliar = 2
        habilitarBotones(False, False, True, True)
        habilitarGrupos(True)
        habiliatarTextBoxs(True, True)
        Me.txtFechaCierre.Enabled = False
        Me.btnReporte.Visible = True
        Me.txtNombres.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.cancelar(False)
        lblInformacion.Text = ""
        Me.limpiarCampos()
        btnCerrar.Enabled = False
        If Me.dgvCliente.Visible = True Then
            Me.dgvCliente.Visible = False
        End If
        btnReporte.Visible = True
        reservaSelected = Nothing
    End Sub
    Public Sub llenarGrid()
        Try
            Dim listar = daoCliente.findAll
            dgvCliente.DataSource = (From c In listar Select c.Codcliente, c.Nombres, c.Apellidos).ToList
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub txtCodigo_Enter(sender As Object, e As EventArgs) Handles txtCodigo.Enter, txtNombres.Enter, txtApellidos.Enter
        Me.dgvCliente.Size = New Size(445, 100)
        If Me.dgvCliente.Visible = False Then
            Me.dgvCliente.Visible = True
        End If
        llenarGrid()
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Try
            'Dim dao = DataContext.daoCliente
            Dim listar As List(Of Cliente) = daoCliente.filtrarPorCodigo(txtCodigo.Text)
            dgvCliente.DataSource = (From c In listar Select c.Codcliente, c.Nombres, c.Apellidos).ToList
            If txtCodigo.TextLength > 0 Then
                erp.SetError(txtCodigo, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged
        Try
            'Dim dao = DataContext.daoCliente
            Dim listar As List(Of Cliente) = daoCliente.filtrarPorNombre(txtNombres.Text)
            dgvCliente.DataSource = (From c In listar Select c.Codcliente, c.Nombres, c.Apellidos).ToList
            If txtCodigo.TextLength > 0 Then
                erp.SetError(txtCodigo, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged
        Try
            'Dim dao = DataContext.daoCliente
            Dim listar As List(Of Cliente) = daoCliente.filtrarPorApellido(txtApellidos.Text)
            dgvCliente.DataSource = (From c In listar Select c.Codcliente, c.Nombres, c.Apellidos).ToList
            If txtCodigo.TextLength > 0 Then
                erp.SetError(txtCodigo, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim codigo As String = String.Empty
            Dim gramos As Decimal = Decimal.Zero
            Dim onzas As Decimal = Decimal.Zero
            Dim onzasEntregadas As Decimal = Decimal.Zero
            Dim onzasDiferencia As Decimal = Decimal.Zero
            Dim precioInternacional As Decimal = Decimal.Zero
            Dim precioKilate As Decimal = Decimal.Zero
            Dim kilateprom As Decimal = Decimal.Zero
            If Me.txtCodigo.Text.Trim.Length <= 0 Then
                erp.SetError(txtCodigo, "Debe especificar un cliente para continuar")
                txtCodigo.Focus()
                Return
            Else
                codigo = txtCodigo.Text
                erp.SetError(txtCodigo, "")
            End If
            If Me.txtPrecioInternacional.Text.Trim.Length <= 0 Then
                erp.SetError(txtPrecioInternacional, "Debe especificar el precio a usar")
                txtPrecioInternacional.Focus()
                Return
            Else
                precioInternacional = Convert.ToDecimal(txtPrecioInternacional.Text)
                erp.SetError(txtPrecioInternacional, "")
            End If
            If Me.txtPrecioKilate.Text.Trim.Length <= 0 Then
                erp.SetError(txtPrecioKilate, "Debe especificar el kilataje")
                txtPrecioKilate.Focus()
                Return
            Else
                precioKilate = Convert.ToDecimal(txtPrecioKilate.Text)
                erp.SetError(txtPrecioKilate, "")
            End If
            If Me.txtGramos.Text.Trim.Length <= 0 Then
                erp.SetError(txtGramos, "Ingrese los gramos a usar o especifique las onzas")
                txtGramos.Focus()
                Return
            Else
                gramos = Convert.ToDecimal(txtGramos.Text)
                erp.SetError(txtGramos, "")
            End If
            If Me.txtOnzas.Text.Trim.Length <= 0 Then
                erp.SetError(txtOnzas, "Ingrese las onzas para continuar")
                txtOnzas.Focus()
                Return
            Else
                onzas = Convert.ToDecimal(txtOnzas.Text)
                erp.SetError(txtOnzas, "")
            End If
            If Me.txtKilate.Text.Trim.Length <= 0 Then
                erp.SetError(txtKilate, "Ingrese el quilataje a usar.")
                txtKilate.Focus()
                Return
            Else
                kilateprom = Convert.ToDecimal(txtKilate.Text)
                erp.SetError(txtOnzas, "")
            End If
            Dim cliente As Cliente = daoCliente.findById(codigo)
            If cliente Is Nothing Then
                MsgBox("No existe el cliente indicado, por favor intente nuevamente.", MsgBoxStyle.Information, "Informacion")
                Return
            End If
            Select Case auxiliar
                Case 1
                    'guardar una nueva reserva de oro
                    Dim reserva As New ReservaOro
                    reserva.Codcliente = cliente.Codcliente
                    reserva.Estado = True
                    reserva.FechaReserva = txtFechaCierre.Value
                    reserva.Gramos = gramos
                    reserva.Onzas = onzas
                    reserva.PrecioKilate = precioKilate
                    reserva.PrecioReservado = precioInternacional
                    reserva.KilateProm = kilateprom
                    reserva.Saldo = onzas
                    Dim detaReserva As New DetaReserva
                    detaReserva.entregadas = 0
                    detaReserva.diferencia = 0
                    detaReserva.fecha = txtFechaEntrega.Value
                    detaReserva.usuario = DataContext.usuarioLog.Usuario1
                    detaReserva.hora = Now.ToShortTimeString
                    Dim result As DialogResult = MessageBox.Show("¿Guardar los datos de reserva de oro en el sistema?", "Guardar", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        Return
                    End If
                    If daoReserva.save(reserva, detaReserva) = True Then
                        MsgBox("Se han guardado los datos en el sistema de forma correcta", MsgBoxStyle.Information, "Información")
                        btnCancelar_Click(sender, e)
                    Else
                        MsgBox(daoReserva.ErrorS, MsgBoxStyle.Critical, "Error")
                        Return
                    End If
                Case 2
                    'editar una nueva reserva de oro
                    Dim detaReserva As New DetaReserva
                    Dim saldoOnzas As Decimal = daoReserva.findSaldoReserva(reservaSelected.Idreserva).diferencia
                    If txtFechaCierre.Value.Day > txtFechaEntrega.Value.Day Then
                        MsgBox("La fecha de entrega es igual o menor que la fecha de cierre, intente nuevamente.", MsgBoxStyle.Information, "Información")
                        Return
                    End If
                    If txtOnzasDiferencia.Text.Trim.Length <= 0 Then
                        erp.SetError(txtOnzasDiferencia, "Debe especificar este campo")
                        txtOnzasEntregadas.Focus()
                        Return
                    Else
                        onzasEntregadas = Convert.ToDecimal(txtOnzasEntregadas.Text)
                        onzasDiferencia = Convert.ToDecimal(txtOnzasDiferencia.Text)
                        reservaSelected.Saldo = onzasDiferencia
                    End If
                    If txtOnzas.Text.Trim.Length <= 0 Then
                        erp.SetError(txtOnzas, "Debe especificar las onzzas para continuar")
                        txtOnzas.Focus()
                        Return
                    Else
                        onzas = Convert.ToDecimal(txtOnzas.Text)
                    End If
                    If txtGramos.Text.Trim.Length <= 0 Then
                        erp.SetError(txtGramos, "Debe especificar los gramos para continuar")
                        txtGramos.Focus()
                        Return
                    Else
                        gramos = Convert.ToDecimal(txtGramos.Text)
                    End If
                    If txtPrecioInternacional.Text.Trim.Length > 0 Then
                        precioInternacional = Convert.ToDecimal(txtPrecioInternacional.Text)
                        reservaSelected.PrecioReservado = precioInternacional
                    End If
                    If txtPrecioKilate.Text.Trim.Length > 0 Then
                        precioKilate = Convert.ToDecimal(txtPrecioKilate.Text)
                        reservaSelected.PrecioKilate = precioKilate
                    End If
                    If txtKilate.Text.Trim.Length > 0 Then
                        kilateprom = Convert.ToDecimal(txtKilate.Text)
                        reservaSelected.KilateProm = txtKilate.Text
                    End If
                    'al editar el usuario puede actualzar las onzas
                    'debido a varios factores
                    'entonces hacemos el procedimiento adecuado de actualizacion
                    Dim resultOnzas As DialogResult
                    If Decimal.Compare(reservaSelected.Onzas, onzas) <> 0 Then
                        resultOnzas = MsgBox("Las onzas especificadas son diferentes a las onzas guardadas en el sistema." & vbCr & "¿Desea actualizar las onzas?", MsgBoxStyle.YesNo, "Cierre de precio")
                    End If
                    If resultOnzas = Windows.Forms.DialogResult.Yes Then
                        reservaSelected.Onzas = onzas
                        reservaSelected.Gramos = gramos
                    End If
                    'detalle de la reserva
                    detaReserva.entregadas = onzasEntregadas
                    detaReserva.diferencia = onzasDiferencia
                    detaReserva.fecha = txtFechaEntrega.Value
                    detaReserva.usuario = DataContext.usuarioLog.Usuario1
                    detaReserva.hora = Now.ToShortTimeString
                    Dim result As DialogResult = MessageBox.Show("¿Guardar los datos de reserva de oro en el sistema?", "Guardar", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        Return
                    End If
                    If daoReserva.edit(reservaSelected, detaReserva) Then
                        MsgBox("Se ha editado el cierre de forma correcta", MsgBoxStyle.Information, "Información")
                        Dim verSaldo As Decimal = daoReserva.findSaldoReserva(reservaSelected.Idreserva).diferencia
                        If verSaldo <= 0 Then
                            MsgBox("Se cerrará el precio reservado de forma automatica, ya que este valor es menor de cero.", MsgBoxStyle.Information, "Cierre de precio")
                            If daoReserva.cerrar(reservaSelected) = False Then
                                MsgBox("No se pudo realizar el cierre de la compra debido al siguiente error: " & daoReserva.ErrorS, MsgBoxStyle.Critical, "Error")
                            End If
                        End If
                        btnCancelar_Click(sender, e)
                    Else
                        MsgBox(daoReserva.ErrorS, MsgBoxStyle.Critical, "Error")
                        Return
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Error general: " & ex.Message, MsgBoxStyle.Critical, "Error fatal")
        End Try
    End Sub


    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                Me.dgvCliente.Focus()
            Case Keys.Escape
                Me.dgvCliente.Visible = False
        End Select
    End Sub

    Private Sub txtNombres_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombres.KeyDown
        Me.txtCodigo_KeyDown(sender, e)
    End Sub

    Private Sub txtApellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtApellidos.KeyDown
        Me.txtCodigo_KeyDown(sender, e)
    End Sub

    Private Sub dgvCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCliente.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                Me.seleccionarFila()
                Me.txtFechaCierre.Focus()
            Case Keys.Escape
                Me.dgvCliente.Visible = False
        End Select
    End Sub

    Private Sub dgvCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellDoubleClick
        Me.seleccionarFila()
        Me.txtFechaCierre.Focus()
    End Sub

    Private Sub txtPrecioInternacional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioKilate.KeyPress
        NumeroDec(e, txtPrecioKilate)
    End Sub

    Private Sub txtPrecioInternacional_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtPrecioInternacional.KeyPress
        NumeroDec(e, txtPrecioInternacional)
    End Sub

    Private Sub txtGramos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGramos.KeyPress
        NumeroDec(e, txtGramos)
    End Sub

    Private Sub txtOnzas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnzas.KeyPress
        NumeroDec(e, txtOnzas)
    End Sub

    Private Sub txtOnzasEntregadas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnzasEntregadas.KeyPress
        NumeroDec(e, txtOnzasEntregadas)
    End Sub

    Private Sub txtOnzasDiferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOnzasDiferencia.KeyPress
        NumeroDec(e, txtOnzasDiferencia)
    End Sub

    Private Sub txtGramos_Leave(sender As Object, e As EventArgs) Handles txtGramos.Leave
        Try
            If txtGramos.Text.Trim.Length <= 0 Then
                Return
            End If
            Dim kilate As Decimal = Decimal.Zero
            If txtKilate.Text.Trim.Length <= 0 Then
                erp.SetError(txtKilate, "Especifique los quilates para convertir de gramos a onzas")
                txtKilate.Focus()
                Return
            Else
                kilate = Convert.ToDecimal(txtKilate.Text)
            End If
            Dim gramos As Decimal = Convert.ToDecimal(txtGramos.Text)
            Dim onzas As Decimal = ((gramos * kilate) / 24) / 31.1035
            txtOnzas.Text = onzas
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtKilate_Leave(sender As Object, e As EventArgs) Handles txtKilate.Leave
        Try
            If txtKilate.Text.Trim.Length <= 0 Then
                Return
            End If
            Dim kilate As Decimal = Decimal.Zero
            kilate = Convert.ToDecimal(txtKilate.Text)
            If txtGramos.Text.Trim.Length <= 0 Then
                Return
            End If
            Dim gramos As Decimal = Convert.ToDecimal(txtGramos.Text)
            Dim onzas As Decimal = ((gramos * kilate) / 24) / 31.1035
            txtOnzas.Text = onzas
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtKilate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKilate.KeyPress
        NumeroDec(e, txtKilate)
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
            Me.buscarReserva(idreserva)
            If reservaSelected Is Nothing Then
                Return
            End If
            btnCerrar.Enabled = True
            Me.txtPrecioInternacional.Text = reservaSelected.PrecioReservado
            Me.txtPrecioKilate.Text = reservaSelected.PrecioKilate
            Me.txtGramos.Text = reservaSelected.Gramos
            Me.txtOnzas.Text = reservaSelected.Onzas
            Me.txtOnzasSaldo.Text = detaReservaSelected.diferencia
            Me.txtKilate.Text = reservaSelected.KilateProm
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtKilate_TextChanged(sender As Object, e As EventArgs) Handles txtKilate.TextChanged
        If txtKilate.Text.Trim.Length > 0 Then
            erp.SetError(txtKilate, "")
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            Dim detaReserva As New DetaReserva
            Dim onzasEntregadas As Decimal = Decimal.Zero
            Dim onzasDiferencia As Decimal = Decimal.Zero
            Dim onzas As Decimal = Decimal.Zero
            If txtOnzasEntregadas.Text.Length > 0 Then
                onzasEntregadas = Convert.ToDecimal(txtOnzasEntregadas.Text)
            Else
                onzasEntregadas = Decimal.Zero
            End If
            If txtOnzas.Text.Length <= 0 Then
                erp.SetError(txtOnzas, "Debe especificar las onzas para continuar")
                txtOnzas.Focus()
                Return
            Else
                onzas = Convert.ToDecimal(txtOnzas.Text)
            End If
            If txtOnzasDiferencia.Text.Trim.Length > 0 Then
                onzasDiferencia = Convert.ToDecimal(txtOnzasDiferencia.Text)
            Else
                onzasDiferencia = Me.daoReserva.findSaldoReserva(reservaSelected.Idreserva).diferencia
            End If
            If reservaSelected Is Nothing Then
                MsgBox("Debe seleccionar una reserva  para continuar", MsgBoxStyle.Information, "Información")
                Return
            End If
            reservaSelected.Estado = False
            detaReserva.diferencia = onzasDiferencia
            detaReserva.entregadas = onzasEntregadas
            detaReserva.fecha = Now
            detaReserva.usuario = usuarioLog.Usuario1
            detaReserva.hora = Now.ToShortTimeString
            Dim result As DialogResult = MessageBox.Show("¿Actualizar la reserva de oro seleccionado?", "Cerrar reserva", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.No Then
                Return
            End If
            If daoReserva.edit(reservaSelected, detaReserva) = True Then
                MsgBox("Se ha cerrado la reserva de forma correcta", MsgBoxStyle.Information, "Información")
                btnCancelar_Click(sender, e)
            Else
                MsgBox("Se produjo el siguiente error: " & daoReserva.ErrorS, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error general: " & ex.Message, MsgBoxStyle.Critical, "Error fatal")
        End Try
    End Sub

    Private Sub txtOnzas_TextChanged(sender As Object, e As EventArgs) Handles txtOnzas.TextChanged
        If txtOnzas.Text.Trim.Length > 0 Then
            erp.SetError(txtOnzas, "")
        End If
    End Sub

    Private Sub txtGramos_TextChanged(sender As Object, e As EventArgs) Handles txtGramos.TextChanged
        If txtGramos.Text.Trim.Length > 0 Then
            erp.SetError(txtGramos, "")
        End If
    End Sub

    Private Sub txtPrecioInternacional_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioInternacional.TextChanged
        If txtPrecioInternacional.Text.Trim.Length > 0 Then
            erp.SetError(txtPrecioInternacional, "")
        End If
    End Sub

    Private Sub txtPrecioKilate_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioKilate.TextChanged
        If txtPrecioKilate.Text.Trim.Length > 0 Then
            erp.SetError(txtPrecioKilate, "")
        End If
    End Sub

    Private Sub txtOnzasEntregadas_Leave(sender As Object, e As EventArgs) Handles txtOnzasEntregadas.Leave
        Dim onzas As Decimal = Decimal.Zero
        Dim onzasEntregadas As Decimal = Decimal.Zero
        Dim onzasDiferencia As Decimal = Decimal.Zero
        Select Case auxiliar
            Case 1
                If txtOnzas.Text.Trim.Length <= 0 Then
                    erp.SetError(txtOnzas, "Debe especificar las onzas o gramos para continuar")
                    txtOnzas.Focus()
                    Return
                Else
                    erp.SetError(txtOnzas, "")
                    onzas = Convert.ToDecimal(txtOnzas.Text)
                End If
            Case 2
                If reservaSelected.Idreserva > 0 Then
                    onzas = daoReserva.findSaldoReserva(reservaSelected.Idreserva).diferencia
                End If
        End Select
        If txtOnzasEntregadas.Text.Trim.Length <= 0 Then
            Return
        End If
        onzasEntregadas = Convert.ToDecimal(txtOnzasEntregadas.Text)
        onzasDiferencia = Decimal.Subtract(onzas, onzasEntregadas)
        txtOnzasDiferencia.Text = onzasDiferencia
    End Sub

    Private Sub txtPrecioInternacional_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioInternacional.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtPrecioKilate.Focus()
        End Select
    End Sub

    Private Sub txtPrecioKilate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioKilate.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtGramos.Focus()
        End Select
    End Sub

    Private Sub txtGramos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGramos.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtOnzas.Focus()
        End Select
    End Sub

    Private Sub txtOnzas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOnzas.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtOnzasEntregadas.Focus()
        End Select
    End Sub

    Private Sub txtOnzasEntregadas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOnzasEntregadas.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                btnGuardar.Focus()
        End Select
    End Sub

    Private Sub txtKilate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKilate.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                txtOnzas.Focus()
        End Select
    End Sub


    Private Sub txtOnzas_Validated(sender As Object, e As EventArgs) Handles txtOnzas.Validated
        Try
            If Me.txtKilate.Text.Trim.Length <= 0 Then
                Return
            End If
            Dim kilate As Decimal = Convert.ToDecimal(txtKilate.Text)
            Dim onzas As Decimal = Convert.ToDecimal(txtOnzas.Text)
            Dim gramos As Decimal = Decimal.Zero
            gramos = (onzas / kilate) * 31.1035 * 24
            Me.txtGramos.Text = gramos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            frmReservaRpt.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class

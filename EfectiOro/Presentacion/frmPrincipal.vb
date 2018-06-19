Public Class frmPrincipal

    Dim configuracion As New ConfiguracionGeneral()

    Private Sub nivelAcceso(ByVal usuario As Boolean, catalogo As Boolean, compra As Boolean, _
                          tipocambio As Boolean, descargue As Boolean, precios As Boolean, _
                          adelantoEfectivo As Boolean, adelantoOtros As Boolean, adelanto As Boolean)
        Me.CrearUsuarioToolStripMenuItem.Enabled = usuario
        Me.CatalogoToolStripMenuItem.Enabled = catalogo
        Me.btnCliente.Visible = compra
        Me.ComprasToolStripMenuItem.Enabled = compra
        Me.btnCompras.Visible = compra
        Me.TipoDeCambioToolStripMenuItem.Enabled = tipocambio
        Me.btnTipocambio.Visible = tipocambio
        Me.GenerarDescargueToolStripMenuItem.Enabled = descargue
        Me.PreciosKilateToolStripMenuItem.Enabled = precios
        Me.btnPrecios.Visible = precios
        Me.AdelantosAClientesToolStripMenuItem.Enabled = adelanto
        toolPreciosCierres.Enabled = compra
        frmAdelantos.chekEfectivo.Enabled = adelantoEfectivo
        frmAdelantos.chekCheque.Enabled = adelantoOtros
        frmAdelantos.chekTransferencia.Enabled = adelantoOtros
    End Sub
    Private Sub verificarUsuario(nivel As Integer)
        Select Case nivel
            Case 1
                'rol de administrador, acceso a todo
                nivelAcceso(True, True, True, True, True, True, True, True, True)
                Me.btnMcaja.Visible = True
            Case 2
                'rol de supervisor
                nivelAcceso(False, True, False, True, True, True, False, True, False)
                Me.MantenimientoToolStripMenuItem.Enabled = False
                Me.btnPrecios.Visible = False
                Me.btnTipocambio.Visible = False
                Me.btnMcaja.Visible = False
            Case 3
                'rol de supervisor de caja
                nivelAcceso(False, False, True, True, False, True, True, False, True)
                Me.btnMcaja.Visible = True
            Case 4
                'rol de cajero
                nivelAcceso(False, False, True, False, False, False, True, False, True)
                Me.btnMcaja.Visible = True
        End Select
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.panelLateral.BackColor = Color.FromArgb(8, Color.Gray)
        Me.verificarUsuario(DataContext.usuarioLog.Nivel)
        Me.lblStatus.Text = "Sucursal: " & configuracion.getAgencia & " .:. Usuario: " & DataContext.usuarioLog.Usuario1 & " .:. " & Date.Now.ToShortTimeString() & " .:. Caja: " & configuracion.getCaja
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)
                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
        Select Case usuarioLog.Nivel
            Case 1, 2
                If Now.Day = 15 Or Now.Day = 30 Then
                    MessageBox.Show("Realice un respaldo de la base de datos.", "Back Up")
                    frmBackupBaseDatos.ShowDialog()
                End If
        End Select
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        'Me.IsMdiContainer = True
        'frmCliente.Show()
        'Me.IsMdiContainer = False
        ServiciosBasicos.agregarAlPanel(frmCliente, Me.panelCentral)
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        ClienteToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub

    Private Sub AgenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgenciaToolStripMenuItem.Click
        'frmAgencia.MdiParent = Me
        'frmAgencia.Show()
        ServiciosBasicos.agregarAlPanel(frmAgencia, Me.panelCentral)
    End Sub

    Private Sub CajasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CajasToolStripMenuItem.Click
        'frmCaja.MdiParent = Me
        'frmCaja.Show()
        ServiciosBasicos.agregarAlPanel(frmCaja, Me.panelCentral)
    End Sub

    Private Sub MovimientosDeCajaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MovimientosDeCajaToolStripMenuItem.Click
        'frmMovimientosCaja.MdiParent = Me
        'frmMovimientosCaja.Show()
        ServiciosBasicos.agregarAlPanel(frmMovimientosCaja, Me.panelCentral)
    End Sub

    Private Sub RubrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RubrosToolStripMenuItem.Click
        'frmRubros.MdiParent = Me
        'frmRubros.Show()
        ServiciosBasicos.agregarAlPanel(frmRubros, Me.panelCentral)
    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        'frmTipoCambio.MdiParent = Me
        'frmTipoCambio.Show()
        ServiciosBasicos.agregarAlPanel(frmTipoCambio, Me.panelCentral)
    End Sub

    Private Sub PreciosKilateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PreciosKilateToolStripMenuItem.Click
        'frmPrecios.MdiParent = Me
        'frmPrecios.Show()
        ServiciosBasicos.agregarAlPanel(frmPrecios, Me.panelCentral)
    End Sub

    Private Sub AdelantosAClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdelantosAClientesToolStripMenuItem.Click
        'frmAdelantos.MdiParent = Me
        'frmAdelantos.Show()
        ServiciosBasicos.agregarAlPanel(frmAdelantos, Me.panelCentral)
    End Sub

    Private Sub MovimientosDeCajaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MovimientosDeCajaToolStripMenuItem1.Click, btnMcaja.Click
        'frmMovCaja.MdiParent = Me
        'frmMovCaja.Show()
        ServiciosBasicos.agregarAlPanel(frmMaestroCaja, Me.panelCentral)
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        'frmCompras.MdiParent = Me
        'frmCompras.Show()
        ServiciosBasicos.agregarAlPanel(frmCompras, Me.panelCentral)
    End Sub

    Private Sub btnCompras_Click(sender As System.Object, e As System.EventArgs) Handles btnCompras.Click
        'frmCompras.MdiParent = Me
        'frmCompras.Show()
        ServiciosBasicos.agregarAlPanel(frmCompras, Me.panelCentral)
    End Sub

    Private Sub btnPrecios_Click(sender As System.Object, e As System.EventArgs) Handles btnPrecios.Click
        'My.Forms.frmPrecios.MdiParent = Me
        'frmPrecios.Show()
        ServiciosBasicos.agregarAlPanel(frmPrecios, Me.panelCentral)
    End Sub

    Private Sub btnTipocambio_Click(sender As System.Object, e As System.EventArgs) Handles btnTipocambio.Click
        'frmTipoCambio.MdiParent = Me
        'frmTipoCambio.Show()
        ServiciosBasicos.agregarAlPanel(frmTipoCambio, Me.panelCentral)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CrearUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrearUsuarioToolStripMenuItem.Click
        'frmUsuario.MdiParent = Me
        'frmUsuario.Show()
        ServiciosBasicos.agregarAlPanel(frmUsuario, Me.panelCentral)
    End Sub

    Private Sub GenerarDescargueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarDescargueToolStripMenuItem.Click
        'frmDescargues.MdiParent = Me
        'frmDescargues.Show()
        ServiciosBasicos.agregarAlPanel(frmDescargues, Me.panelCentral)
    End Sub

    Private Sub DeComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeComprasToolStripMenuItem.Click
        'frmRptComrpas.MdiParent = Me
        'frmRptComrpas.Show()
        ServiciosBasicos.agregarAlPanel(frmRptComrpas, Me.panelCentral)
    End Sub

    Private Sub frmPrincipal_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.EnabledChanged
        ServiciosBasicos.VerificarRol(DataContext.usuarioLog.Nivel)
    End Sub

    Private Sub DeClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeClientesToolStripMenuItem.Click
        'frmRptClientes.MdiParent = Me
        'frmRptClientes.Show()
        ServiciosBasicos.agregarAlPanel(frmRptClientes, Me.panelCentral)
    End Sub

    Private Sub DeDescarguesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeDescarguesToolStripMenuItem.Click
        'frmRptDescargue.MdiParent = Me
        'frmRptDescargue.Show()
        ServiciosBasicos.agregarAlPanel(frmRptDescargue, Me.panelCentral)
    End Sub

    Private Sub DeCajasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeCajasToolStripMenuItem.Click
        'frmRptCaja.MdiParent = Me
        'frmRptCaja.Show()
        ServiciosBasicos.agregarAlPanel(frmRptCaja, Me.panelCentral)
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        frmConfiguracionGeneral.ShowDialog()
    End Sub

    Private Sub BackupBaseDeDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackupBaseDeDatosToolStripMenuItem.Click
        frmBackupBaseDatos.ShowDialog()
    End Sub

    Private Sub btnCliente_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)
        ServiciosBasicos.textoHorizontal(e, Me.btnCliente, "Cliente")
    End Sub

    Private Sub btnCompras_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)
        ServiciosBasicos.textoHorizontal(e, Me.btnCompras, "Compras")
    End Sub

    Private Sub btnPrecios_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)
        ServiciosBasicos.textoHorizontal(e, Me.btnPrecios, "Tipos de precios")
    End Sub

    Private Sub btnTipocambio_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)
        ServiciosBasicos.textoHorizontal(e, Me.btnTipocambio, "Tipo de cambio")
    End Sub

    Private Sub ActualizarFechaHoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarFechaHoraToolStripMenuItem.Click
        frmActualizarFechaDetaCaja.ShowDialog()
    End Sub

    Private Sub EstadisticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaToolStripMenuItem.Click
        ServiciosBasicos.agregarAlPanel(frmEstadisticoCompra, Me.panelCentral)
    End Sub

    Private Sub GenerarDescarguePorCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarDescarguePorCompraToolStripMenuItem.Click
        ServiciosBasicos.agregarAlPanel(frmDetaDescargue, Me.panelCentral)
    End Sub

    Private Sub ReservarOroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservarOroToolStripMenuItem.Click
        ServiciosBasicos.agregarAlPanel(frmCierrePrecios, Me.panelCentral)
    End Sub

    Private Sub CierrePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierrePreciosToolStripMenuItem.Click
        ServiciosBasicos.agregarAlPanel(frmReportesCierreOpciones, Me.panelCentral)
    End Sub

    Private Sub toolPreciosCierres_Click(sender As Object, e As EventArgs) Handles toolPreciosCierres.Click
        agregarAlPanel(frmPrecios2, panelCentral)
    End Sub
End Class
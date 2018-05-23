Public Class frmConfig
    Dim configuracion As ConfiguracionGeneral
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        configuracion = New ConfiguracionGeneral()
    End Sub
    Sub llenarComboCaja()
        Dim daoCaja = DataContext.daoCaja
        Me.cmbCaja.DataSource = daoCaja.findAll()
        Me.cmbCaja.ValueMember = "Codcaja"
        Me.cmbCaja.DisplayMember = "Codcaja"
    End Sub

    Sub llenarComboAgencia()
        Dim daoAgencia = DataContext.daoAgencia
        Me.cmbAgencia.DataSource = daoAgencia.findAll()
        Me.cmbAgencia.ValueMember = "Codagencia"
        Me.cmbAgencia.DisplayMember = "Codagencia"
    End Sub

    Private Sub frmConfig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        panelTitulo.Visible = False
        lblAgencia.Text = configuracion.getAgencia()
        lblCaja.Text = configuracion.getCaja()
        Me.llenarComboAgencia()
        Me.llenarComboCaja()
    End Sub

    Private Sub btnAplicarCaja_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarCaja.Click
        If Me.cmbCaja.Text.Length <= 0 Then
            Me.cmbCaja.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Cambiar la Caja actual del sistema?", MsgBoxStyle.OkCancel, "Configuración")
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
        configuracion.setCaja(cmbCaja.Text)
        MsgBox("Se han aplicado los cambios", MsgBoxStyle.Information, "Configuración")
    End Sub

    Private Sub btnAplicarAgencia_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicarAgencia.Click
        If Me.cmbAgencia.Text.Length <= 0 Then
            Me.cmbAgencia.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Cambiar la Agencia actual del sistema?", MsgBoxStyle.OkCancel, "Configuración")
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
        configuracion.setAgencia(Me.cmbAgencia.Text)
        MsgBox("Se han aplicado los cambios", MsgBoxStyle.Information, "Configuración")
    End Sub
End Class

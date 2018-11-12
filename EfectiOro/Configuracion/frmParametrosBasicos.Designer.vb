<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosBasicos
    Inherits EfectiOro.frmPersonalizado

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametrosBasicos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cmbPagoAdelantos = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbVoucher = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbAnularAdelanto = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbAnularCompra = New System.Windows.Forms.ComboBox()
        Me.txtidadelanto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPrestamoIngreso = New System.Windows.Forms.ComboBox()
        Me.txtnumcompra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbPrestamoEgreso = New System.Windows.Forms.ComboBox()
        Me.txtcodagencia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCierrecompra = New System.Windows.Forms.ComboBox()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSaldoCaja = New System.Windows.Forms.ComboBox()
        Me.cmbAdelantos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCompra = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.panelTitulo.SuspendLayout()
=======
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
>>>>>>> d8bfd5a6acabacd5117db978dba64f782dae3e16
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.Size = New System.Drawing.Size(479, 25)
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(454, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMoneda)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.cmbPagoAdelantos)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbVoucher)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbAnularAdelanto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbAnularCompra)
        Me.GroupBox1.Controls.Add(Me.txtidadelanto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbPrestamoIngreso)
        Me.GroupBox1.Controls.Add(Me.txtnumcompra)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbPrestamoEgreso)
        Me.GroupBox1.Controls.Add(Me.txtcodagencia)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCierrecompra)
        Me.GroupBox1.Controls.Add(Me.txtcodcliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSaldoCaja)
        Me.GroupBox1.Controls.Add(Me.cmbAdelantos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbCompra)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 431)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.EfectiOro.My.Resources.Resources.filesave
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(387, 377)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(52, 48)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cmbPagoAdelantos
        '
        Me.cmbPagoAdelantos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPagoAdelantos.FormattingEnabled = True
        Me.cmbPagoAdelantos.Location = New System.Drawing.Point(219, 327)
        Me.cmbPagoAdelantos.Name = "cmbPagoAdelantos"
        Me.cmbPagoAdelantos.Size = New System.Drawing.Size(191, 21)
        Me.cmbPagoAdelantos.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(222, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Pago o abono a adelantos"
        '
        'cmbVoucher
        '
        Me.cmbVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVoucher.FormattingEnabled = True
        Me.cmbVoucher.Location = New System.Drawing.Point(17, 327)
        Me.cmbVoucher.Name = "cmbVoucher"
        Me.cmbVoucher.Size = New System.Drawing.Size(191, 21)
        Me.cmbVoucher.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Establecer usuario de voucher:"
        '
        'cmbAnularAdelanto
        '
        Me.cmbAnularAdelanto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnularAdelanto.FormattingEnabled = True
        Me.cmbAnularAdelanto.Location = New System.Drawing.Point(17, 274)
        Me.cmbAnularAdelanto.Name = "cmbAnularAdelanto"
        Me.cmbAnularAdelanto.Size = New System.Drawing.Size(191, 21)
        Me.cmbAnularAdelanto.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Anular adelanto:"
        '
        'cmbAnularCompra
        '
        Me.cmbAnularCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnularCompra.FormattingEnabled = True
        Me.cmbAnularCompra.Location = New System.Drawing.Point(17, 226)
        Me.cmbAnularCompra.Name = "cmbAnularCompra"
        Me.cmbAnularCompra.Size = New System.Drawing.Size(191, 21)
        Me.cmbAnularCompra.TabIndex = 15
        '
        'txtidadelanto
        '
        Me.txtidadelanto.Location = New System.Drawing.Point(17, 179)
        Me.txtidadelanto.Name = "txtidadelanto"
        Me.txtidadelanto.Size = New System.Drawing.Size(180, 20)
        Me.txtidadelanto.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Anular compra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Numero de adelanto:"
        '
        'cmbPrestamoIngreso
        '
        Me.cmbPrestamoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrestamoIngreso.FormattingEnabled = True
        Me.cmbPrestamoIngreso.Location = New System.Drawing.Point(219, 274)
        Me.cmbPrestamoIngreso.Name = "cmbPrestamoIngreso"
        Me.cmbPrestamoIngreso.Size = New System.Drawing.Size(191, 21)
        Me.cmbPrestamoIngreso.TabIndex = 13
        '
        'txtnumcompra
        '
        Me.txtnumcompra.Location = New System.Drawing.Point(17, 131)
        Me.txtnumcompra.Name = "txtnumcompra"
        Me.txtnumcompra.Size = New System.Drawing.Size(180, 20)
        Me.txtnumcompra.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(222, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Prestamo puente ingreso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numero de compra:"
        '
        'cmbPrestamoEgreso
        '
        Me.cmbPrestamoEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrestamoEgreso.FormattingEnabled = True
        Me.cmbPrestamoEgreso.Location = New System.Drawing.Point(219, 226)
        Me.cmbPrestamoEgreso.Name = "cmbPrestamoEgreso"
        Me.cmbPrestamoEgreso.Size = New System.Drawing.Size(191, 21)
        Me.cmbPrestamoEgreso.TabIndex = 11
        '
        'txtcodagencia
        '
        Me.txtcodagencia.Location = New System.Drawing.Point(17, 83)
        Me.txtcodagencia.Name = "txtcodagencia"
        Me.txtcodagencia.Size = New System.Drawing.Size(180, 20)
        Me.txtcodagencia.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(222, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Prestamo puente egreso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo de la agecia"
        '
        'cmbCierrecompra
        '
        Me.cmbCierrecompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCierrecompra.FormattingEnabled = True
        Me.cmbCierrecompra.Location = New System.Drawing.Point(219, 178)
        Me.cmbCierrecompra.Name = "cmbCierrecompra"
        Me.cmbCierrecompra.Size = New System.Drawing.Size(191, 21)
        Me.cmbCierrecompra.TabIndex = 9
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(17, 35)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(180, 20)
        Me.txtcodcliente.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(222, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cierre de compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo del cliente:"
        '
        'cmbSaldoCaja
        '
        Me.cmbSaldoCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSaldoCaja.FormattingEnabled = True
        Me.cmbSaldoCaja.Location = New System.Drawing.Point(219, 130)
        Me.cmbSaldoCaja.Name = "cmbSaldoCaja"
        Me.cmbSaldoCaja.Size = New System.Drawing.Size(191, 21)
        Me.cmbSaldoCaja.TabIndex = 7
        '
        'cmbAdelantos
        '
        Me.cmbAdelantos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdelantos.FormattingEnabled = True
        Me.cmbAdelantos.Location = New System.Drawing.Point(219, 34)
        Me.cmbAdelantos.Name = "cmbAdelantos"
        Me.cmbAdelantos.Size = New System.Drawing.Size(191, 21)
        Me.cmbAdelantos.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Saldo del día anterior"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Movimiento de adelanto:"
        '
        'cmbCompra
        '
        Me.cmbCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompra.FormattingEnabled = True
        Me.cmbCompra.Location = New System.Drawing.Point(219, 82)
        Me.cmbCompra.Name = "cmbCompra"
        Me.cmbCompra.Size = New System.Drawing.Size(191, 21)
        Me.cmbCompra.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Movimiento de compras:"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(17, 375)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(191, 21)
        Me.cmbMoneda.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Establecer parametro del dolar:"
        '
        'frmParametrosBasicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 474)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmParametrosBasicos"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.panelTitulo, 0)
        Me.panelTitulo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidadelanto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnumcompra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodagencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAdelantos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    'Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbSaldoCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCierrecompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbPrestamoIngreso As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbPrestamoEgreso As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbAnularCompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbAnularAdelanto As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbVoucher As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbPagoAdelantos As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbMoneda As ComboBox
    Friend WithEvents Label15 As Label
End Class

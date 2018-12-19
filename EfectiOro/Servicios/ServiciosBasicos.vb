Imports CrystalDecisions.Shared
Imports Infragistics.Win.Misc
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports EfectiOro.Database

Module ServiciosBasicos
#Region "Recuperar saldos descargues vs compras"
    Public Function saldosAnioAnterior(ByVal anio As Integer, ByVal _agencia As String) As Saldo
        Using ctx As New Contexto
            Dim fecha As Integer = anio - 1
            Dim saldo As New Saldo
            Try
                Dim buscarc = ctx.ExecuteQuery(Of SaldoCompra)(String.Format("select MONTH(c.fecha) mes, sum(c.total) as valorc, sum(c.peso) as pesoc " &
                            "from compras c where YEAR(c.fecha) = {0} " & _agencia &
                            "group by month(c.fecha) " &
                            "order by month(c.fecha) asc", fecha)).ToList
                Dim buscard = ctx.ExecuteQuery(Of SaldoDescargue)(String.Format("select MONTH(fecha) as mes, SUM(importe) as valorD, SUM(peso) as pesoD " &
                                                                "from (select distinct d.dgfecdes as fecha,d.dgimptcom as importe, d.dgpesbrt as peso " &
                                                                "from descargues d join compras c on d.dgnumdes=c.dgnumdes " &
                                                                "where year(d.dgfecdes) = {0} " & _agencia & ") as temporal " &
                                                                "group by MONTH(fecha)", fecha)).ToList
                Dim tempListaDescargue As New List(Of SaldoDescargue)
                Dim tempListaCompras As New List(Of SaldoCompra)
                Dim listar As New List(Of Saldo)
                Dim saldoAcumulado As Decimal = Decimal.Zero
                Dim pesoAcumulado As Decimal = Decimal.Zero
                For i As Integer = 1 To 12
                    Dim tempSaldoDescargue As New SaldoDescargue
                    Dim tempSaldoCompra As New SaldoCompra
                    Dim sum As Decimal = Decimal.Zero
                    Dim temp As Integer = i
                    'Se realiza en un try catch en caso de que no haya un resultado
                    'entonces se dan valores en zero.
                    Try
                        Dim buscar_d = buscard.Where(Function(p) p.mes = temp).Single
                        tempSaldoDescargue.mes = temp
                        tempSaldoDescargue.pesoD = buscar_d.pesoD
                        tempSaldoDescargue.valorD = buscar_d.valorD
                    Catch ex As Exception
                        tempSaldoDescargue.mes = temp
                        tempSaldoDescargue.pesoD = Decimal.Zero
                        tempSaldoDescargue.valorD = Decimal.Zero
                    End Try
                    'Se realiza en un try catch en caso de que no haya un resultado
                    'entonces se dan valores en zero.
                    Try
                        Dim buscar_c = buscarc.Where(Function(c) c.mes = temp).Single
                        tempSaldoCompra.mes = temp
                        tempSaldoCompra.pesoC = buscar_c.pesoC
                        tempSaldoCompra.valorC = buscar_c.valorC
                    Catch ex As Exception
                        tempSaldoCompra.mes = temp
                        tempSaldoCompra.pesoC = Decimal.Zero
                        tempSaldoCompra.valorC = Decimal.Zero
                    End Try
                    saldo.mes = temp
                    saldo.valorS = Math.Abs(saldoAcumulado + tempSaldoCompra.valorC - tempSaldoDescargue.valorD)
                    saldo.pesoS = Math.Abs(pesoAcumulado + tempSaldoCompra.pesoC - tempSaldoDescargue.pesoD)
                    saldoAcumulado = Math.Abs(saldo.valorS)
                    pesoAcumulado = Math.Abs(saldo.pesoS)
                    listar.Add(saldo)
                    tempListaCompras.Add(tempSaldoCompra)
                    tempListaDescargue.Add(tempSaldoDescargue)
                Next
                Return saldo
            Catch ex As Exception
                Return New Saldo
            End Try
        End Using
    End Function
#End Region
#Region "Consulta Linq a DataTable"
    Public Function ToDataTable(ByVal parIList As System.Collections.IEnumerable) As System.Data.DataTable
        Dim ret As New System.Data.DataTable()
        Try
            Dim ppi As System.Reflection.PropertyInfo() = Nothing
            If parIList Is Nothing Then Return ret
            For Each itm In parIList
                If ppi Is Nothing Then
                    ppi = DirectCast(itm.[GetType](), System.Type).GetProperties()
                    For Each pi As System.Reflection.PropertyInfo In ppi
                        Dim colType As System.Type = pi.PropertyType
                        If (colType.IsGenericType) AndAlso
                           (colType.GetGenericTypeDefinition() Is GetType(System.Nullable(Of ))) Then colType = colType.GetGenericArguments()(0)
                        ret.Columns.Add(New System.Data.DataColumn(pi.Name, colType))
                    Next
                End If
                Dim dr As System.Data.DataRow = ret.NewRow
                For Each pi As System.Reflection.PropertyInfo In ppi
                    dr(pi.Name) = If(pi.GetValue(itm, Nothing) Is Nothing, DBNull.Value, pi.GetValue(itm, Nothing))
                Next
                ret.Rows.Add(dr)
            Next
            For Each c As System.Data.DataColumn In ret.Columns
                c.ColumnName = c.ColumnName.Replace("_", " ")
            Next
        Catch ex As Exception
            ret = New System.Data.DataTable()
        End Try
        Return ret
    End Function
#End Region
#Region "Parametros Crystal Report"
    Public Sub ParametrosCrystal(ByVal desde As Date, ByVal hasta As Date, ByVal frm As Form, ByVal rpt As ReportClass)
        'Nombre del Parametro definido dentro de “Campos de Parametros” del Crystal..
        Dim Parametros As ParameterFields = New ParameterFields()
        Dim parDesde As ParameterField = New ParameterField()
        Dim parHasta As ParameterField = New ParameterField()
        Dim disDesde As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disHasta As ParameterDiscreteValue = New ParameterDiscreteValue()
        parDesde.ParameterFieldName = "Desde"
        parHasta.ParameterFieldName = "Hasta"
        'Paso los Datos
        disDesde.Value = desde
        disHasta.Value = hasta
        'agregamos al report viewer
        parDesde.CurrentValues.Add(disDesde)
        parHasta.CurrentValues.Add(disHasta)
        'Cargo los parametros y los envio al Crystal
        Parametros.Add(parDesde)
        Parametros.Add(parHasta)
        Dim viewer As New CrystalReportViewer
        viewer.ParameterFieldInfo = Parametros
        viewer.Dock = DockStyle.Fill
        viewer.ToolPanelView = ToolPanelViewType.None
        viewer.ReportSource = rpt
        frm.Controls.Add(viewer)
        frm.Show()
    End Sub
    Public Sub ParametrosCrystal(ByVal total As Decimal, Optional ByVal nombreCampo As String = "Total")
        Dim parametros As ParameterFields = New ParameterFields()
        Dim parTotal As New ParameterField()
        Dim disTotal As New ParameterDiscreteValue()
        parTotal.ParameterFieldName = nombreCampo
        'Paso los Datos        
        disTotal.Value = total
        'agregamos al report viewer        
        parTotal.CurrentValues.Add(disTotal)
        'Cargo los parametros y los envio al Crystal        
        parametros.Add(parTotal)
        frmReportes.viewer.ParameterFieldInfo = parametros
    End Sub
    Public Sub ParametrosCrystal(ByVal total As Decimal, ByVal saldo As Decimal,
                                 Optional ByVal codigoAdelantos As String = "",
                                 Optional ByVal nombreCampo As String = "Total",
                                 Optional ByVal nombreCampo2 As String = "Saldo",
                                 Optional ByVal nombreCampo3 As String = "codigoAdelantos")
        Dim parametros As ParameterFields = New ParameterFields()
        Dim parTotal As New ParameterField()
        Dim disTotal As New ParameterDiscreteValue()
        Dim parSaldo As New ParameterField()
        Dim disSaldo As New ParameterDiscreteValue()
        Dim parCodigoAdelantos As New ParameterField()
        Dim disCodigoAdelantos As New ParameterDiscreteValue()
        parTotal.ParameterFieldName = nombreCampo
        parSaldo.ParameterFieldName = nombreCampo2
        parCodigoAdelantos.ParameterFieldName = nombreCampo3
        'Paso los Datos        
        disTotal.Value = total
        disSaldo.Value = saldo
        disCodigoAdelantos.Value = codigoAdelantos
        'agregamos al report viewer        
        parTotal.CurrentValues.Add(disTotal)
        parSaldo.CurrentValues.Add(disSaldo)
        parCodigoAdelantos.CurrentValues.Add(disCodigoAdelantos)
        'Cargo los parametros y los envio al Crystal        
        parametros.Add(parTotal)
        parametros.Add(parSaldo)
        parametros.Add(parCodigoAdelantos)
        frmReportes.viewer.ParameterFieldInfo = parametros
    End Sub
    Public Sub ParametrosCrystal(ByVal total As Decimal, ByVal desde As Date, ByVal hasta As Date)
        Dim parametros As ParameterFields = New ParameterFields()
        Dim parTotal As New ParameterField()
        Dim parDesde As ParameterField = New ParameterField()
        Dim parHasta As ParameterField = New ParameterField()
        Dim disDesde As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disHasta As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disTotal As New ParameterDiscreteValue()
        parDesde.ParameterFieldName = "Desde"
        parHasta.ParameterFieldName = "Hasta"
        parTotal.ParameterFieldName = "Total"
        'Paso los Datos
        disDesde.Value = desde
        disHasta.Value = hasta
        disTotal.Value = total
        'agregamos al report viewer
        parDesde.CurrentValues.Add(disDesde)
        parHasta.CurrentValues.Add(disHasta)
        parTotal.CurrentValues.Add(disTotal)
        'Cargo los parametros y los envio al Crystal
        parametros.Add(parDesde)
        parametros.Add(parHasta)
        parametros.Add(parTotal)
        frmReportes.viewer.ParameterFieldInfo = parametros
    End Sub
    Public Sub ParametrosCrystal(ByVal desde As Date, ByVal hasta As Date, ByVal saldoS As Decimal, ByVal pesoS As Decimal)
        'Nombre del Parametro definido dentro de “Campos de Parametros” del Crystal..
        Dim Parametros As ParameterFields = New ParameterFields()
        Dim parDesde As ParameterField = New ParameterField()
        Dim parHasta As ParameterField = New ParameterField()
        Dim parSaldoS As ParameterField = New ParameterField()
        Dim parPesoS As ParameterField = New ParameterField()
        Dim disDesde As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disHasta As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disSaldoS As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disPesoS As ParameterDiscreteValue = New ParameterDiscreteValue()
        parDesde.ParameterFieldName = "Desde"
        parHasta.ParameterFieldName = "Hasta"
        parSaldoS.ParameterFieldName = "saldoS"
        parPesoS.ParameterFieldName = "pesoS"

        'Paso los Datos
        disDesde.Value = desde
        disHasta.Value = hasta
        disSaldoS.Value = saldoS
        disPesoS.Value = pesoS
        'agregamos al report viewer
        parDesde.CurrentValues.Add(disDesde)
        parHasta.CurrentValues.Add(disHasta)
        parSaldoS.CurrentValues.Add(disSaldoS)
        parPesoS.CurrentValues.Add(disPesoS)
        'Cargo los parametros y los envio al Crystal
        Parametros.Add(parDesde)
        Parametros.Add(parHasta)
        Parametros.Add(parSaldoS)
        Parametros.Add(parPesoS)
        frmReportes.viewer.ParameterFieldInfo = Parametros
        frmReporteConsolodidadoGeneral.CrystalReportViewer1.ParameterFieldInfo = Parametros
    End Sub
    Public Sub ParametrosCrystal(ByVal desde As Date, ByVal hasta As Date, Optional ByVal form As Boolean = False)
        'Nombre del Parametro definido dentro de “Campos de Parametros” del Crystal..
        Dim Parametros As ParameterFields = New ParameterFields()
        Dim parDesde As ParameterField = New ParameterField()
        Dim parHasta As ParameterField = New ParameterField()
        Dim disDesde As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disHasta As ParameterDiscreteValue = New ParameterDiscreteValue()
        parDesde.ParameterFieldName = "Desde"
        parHasta.ParameterFieldName = "Hasta"
        'Paso los Datos
        disDesde.Value = desde
        disHasta.Value = hasta
        'agregamos al report viewer
        parDesde.CurrentValues.Add(disDesde)
        parHasta.CurrentValues.Add(disHasta)
        'Cargo los parametros y los envio al Crystal
        Parametros.Add(parDesde)
        Parametros.Add(parHasta)
        frmReportes.viewer.ParameterFieldInfo = Parametros
        frmReporteConsolodidadoGeneral.CrystalReportViewer1.ParameterFieldInfo = Parametros
    End Sub
#End Region

#Region "Variables Globales"
    Public Const campoVacio As String = "No puede estar vacio este campo"
    Public logger As log4net.ILog
#End Region
    Public Function redondearMenos(ByVal var As Decimal) As Decimal
        Try
            Dim Input As Decimal
            Dim Output As Decimal
            Input = Decimal.Round(var, 3)
            Output = Input - (Input Mod 0.55)
            Return Output
        Catch ex As Exception
            Return var
        End Try
    End Function
    Public Function redondearMenos(ByVal var As Decimal, Optional _decimal As Decimal = 0.55) As Decimal
        Try
            Dim Input As Decimal
            Dim Output As Decimal
            Input = Decimal.Round(var, 4)
            Output = Input - (Input Mod _decimal)
            Return Output
        Catch ex As Exception
            Return var
        End Try
    End Function
    Public Sub colorearGrid(ByVal dgv As DataGridView)
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        ' Set the selection background color for all the cells.
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromName("HotTrack")
        dgv.DefaultCellStyle.SelectionForeColor = Color.White

        ' Set the background color for all rows and for alternating rows. 
        ' The value for alternating rows overrides the value for all rows. 
        dgv.RowsDefaultCellStyle.BackColor = Color.DarkGray
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub AgregarFormularioPanel(ByVal panel As Panel, ByVal form As Form)
        If panel.Controls.Count > 0 Then
            panel.Controls.Clear()
        End If
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        panel.Controls.Add(form)
        panel.Tag = form
        form.Show()
    End Sub

    Public Sub Limpiar_TextBox(ByVal formulario As Form)
        'Recorremos todos los controles del formulario que enviamos  
        For Each ctrl As Control In formulario.Controls
            If TypeOf ctrl Is GroupBox Then
                Dim gr As GroupBox = ctrl
                For Each valor In gr.Controls
                    'MsgBox(valor.GetType().Name)
                    If TypeOf valor Is TextBox Then
                        Dim txt As TextBox = valor
                        txt.Clear()
                    End If
                Next
            End If
            'en el caso que usemos un tab control
            'entramos a las paginas del tab control
            If TypeOf ctrl Is TabControl Then
                Dim tab As TabControl = ctrl
                For Each valor In tab.Controls
                    If TypeOf valor Is TabPage Then
                        Dim zval As TabPage = valor
                        For Each aval In zval.Controls
                            If TypeOf aval Is TextBox Then
                                Dim txt As TextBox = aval
                                txt.Clear()
                            End If
                        Next
                    End If
                Next
            End If
            'Filtramos solo aquellos de tipo TextBox 
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = "" ' eliminar el texto  
            End If
        Next
    End Sub
    Public Sub HabilitarTextBox(ByVal formulario As Form, ByVal opcion As Boolean)
        'Recorremos todos los controles del formulario que enviamos         
        'en el caso que esten los controles en el formulario
        'sin un contenedor como un groupBox o un panel
        For Each ctrl As Control In formulario.Controls
            'en el caso que usemos un tab control
            'entramos a las paginas del tab control
            If TypeOf ctrl Is TabControl Then
                Dim tab As TabControl = ctrl
                For Each valor In tab.Controls
                    If TypeOf valor Is TabPage Then
                        Dim zval As TabPage = valor
                        For Each aval In zval.Controls
                            If TypeOf aval Is TextBox Then
                                Dim txt As TextBox = aval
                                txt.Enabled = opcion
                            End If
                        Next
                    End If
                Next
            End If
            'Filtramos solo aquellos de tipo TextBox 
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = ctrl
                txt.Enabled = opcion
            End If
            If TypeOf ctrl Is GroupBox Then
                Dim gr As GroupBox = ctrl
                For Each valor In gr.Controls
                    If TypeOf valor Is TextBox Then
                        Dim txt As TextBox = valor
                        txt.Enabled = opcion
                    End If
                Next
            End If
        Next
    End Sub
#Region "Validar numero decimal"
    Function NumeroDec(ByVal e As KeyPressEventArgs, ByVal Text As TextBox) As Integer

        Dim dig As Integer = Len(Text.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        ' se verifica si es un digito o un punto 
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return a
        Else
            e.Handled = True
        End If
        ' se verifica que el primer digito ingresado no sea un punto al seleccionar
        If Text.SelectedText <> "" Then
            If e.KeyChar = "." Then
                e.Handled = True
                Return a
            End If
        End If
        If dig = 1 And e.KeyChar = "." Then
            e.Handled = True
            Return a
        End If
        'aqui se hace la verificacion cuando es seleccionado el valor del texto
        'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
        If Text.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(Text.Text & e.KeyChar)
                If car.Substring(a, 1) = "." Then
                    esDecimal = esDecimal + 1
                    esDec = True
                End If
                If esDec = True Then
                    NumDecimales = NumDecimales + 1
                End If
                ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
                If NumDecimales >= 6 Or esDecimal >= 2 Then
                    e.Handled = True
                End If
            Next
        End If
    End Function
#End Region

#Region "KeyChar y numero decimal"
    Public CODIGOSEPARADOR As Char = System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator

    Public Sub PALNUMEROS(EV As KeyPressEventArgs, DECIMALES As Integer, TXB As TextBox)
        REM se llama así
        ' Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'PALNUMEROS(e, 2, sender)
        ' el 2 es la cantidad de decimales y se puede cambiar
        'End Sub
        REM Fin de comentario
        If DECIMALES < 0 Then DECIMALES = 0
        If EV.KeyChar = Convert.ToChar(Keys.Return) Then
            EV.Handled = True
            TXB.Focus()
        ElseIf EV.KeyChar = "."c Or EV.KeyChar = ","c Then
            If (TXB.Text.IndexOf(","c) >= 0) Or (DECIMALES = 0) Then
                EV.Handled = True
            Else
                EV.KeyChar = CODIGOSEPARADOR  REM","c
            End If
        ElseIf EV.KeyChar = "-"c And TXB.TextLength = 0 Then
            EV.KeyChar = "-"c
        ElseIf Not (Char.IsControl(EV.KeyChar) Or Char.IsDigit(EV.KeyChar)) Then
            EV.Handled = True
        ElseIf TXB.Text.IndexOf(","c) > 0 Then
            If (TXB.Text.Length - TXB.Text.IndexOf(","c) > DECIMALES) And (TXB.SelectionStart > TXB.Text.IndexOf(","c)) And (Not (Char.IsControl(EV.KeyChar))) Then
                EV.Handled = True
            End If
        End If
    End Sub

    Public Sub PALRRELLENO(Decimales As Integer, TXB As TextBox)
        ' se llama así
        ' Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'PALRRELLENO(2, sender)
        ' End Sub
        Dim Nu As Double
        Dim texto As String
        If Decimal.TryParse(TXB.Text, Nu) Then
            texto = "N" & Trim(Str(Decimales))
            TXB.Text = Nu.ToString(texto)
        Else

            TXB.Text = ""

        End If
    End Sub

    Public Sub keyCharEnter(ByVal textBox2 As TextBox, ByVal e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                textBox2.Focus()
        End Select
    End Sub
    Public Sub keyCharEnter(ByVal boton As Button, ByVal e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
                boton.Focus()
        End Select
    End Sub

    Public Sub TextBoxNumeric_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim noNumero As Boolean
        noNumero = True
        If e.KeyChar >= Convert.ToChar(Keys.D0) And e.KeyChar <= Convert.ToChar(Keys.D9) Or _
            e.KeyChar = Convert.ToChar(8) Or e.KeyChar = Convert.ToChar(46) Then
            noNumero = False
        End If
        If noNumero = True Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Public Sub quitarPitido(ByVal e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                e.Handled = True
        End Select
    End Sub
#End Region

#Region "Verificar Rol de usuario"
    Private Sub nivelAcceso(ByVal usuario As Boolean, catalogo As Boolean, compra As Boolean, _
                           tipocambio As Boolean, descargue As Boolean, precios As Boolean, _
                           adelantoEfectivo As Boolean, adelantoOtros As Boolean)
        frmPrincipal.CrearUsuarioToolStripMenuItem.Enabled = usuario
        frmPrincipal.CatalogoToolStripMenuItem.Enabled = catalogo
        frmPrincipal.ComprasToolStripMenuItem.Enabled = compra
        frmPrincipal.btnCompras.Enabled = compra
        frmPrincipal.TipoDeCambioToolStripMenuItem.Enabled = tipocambio
        frmPrincipal.btnTipocambio.Enabled = tipocambio
        frmPrincipal.GenerarDescargueToolStripMenuItem.Enabled = descargue
        frmPrincipal.PreciosKilateToolStripMenuItem.Enabled = precios
        frmPrincipal.btnPrecios.Enabled = precios
        frmAdelantos.chekEfectivo.Enabled = adelantoEfectivo
        frmAdelantos.chekEfectivo.Checked = adelantoEfectivo
        frmAdelantos.txtefectivo.Visible = adelantoEfectivo
        frmAdelantos.chekCheque.Enabled = adelantoOtros
        frmAdelantos.chekTransferencia.Enabled = adelantoOtros
        frmPrincipal.Refresh()
    End Sub
    Public Sub VerificarRol(nivel As Integer)
        Select Case nivel
            Case 1
                'rol de administrador, acceso a todo
                nivelAcceso(True, True, True, True, True, True, True, True)
            Case 2
                'rol de supervisor
                nivelAcceso(False, True, False, True, True, True, False, True)
            Case 3
                'rol de supervisor de caja
                nivelAcceso(False, False, True, True, False, True, True, False)
            Case 4
                'rol de cajero
                nivelAcceso(False, False, True, False, False, False, True, False)
        End Select
    End Sub
#End Region

#Region "Colores de fondo a textos"

    Public Sub colorDeFondoInfo(ByVal textBox As TextBox)
        textBox.BackColor = Color.FromName("Info")
    End Sub
    Public Sub colorDeFondoBlanco(ByVal textBox As TextBox)
        textBox.BackColor = Color.White
    End Sub

#End Region

#Region "Panel como MdiParent"
    Public Sub agregarAlPanel(frm As Form, panel As Panel)
        For Each ctrl In panel.Controls
            If TypeOf ctrl Is Form Then
                Dim form As Form = ctrl
                If frm.Name = form.Name Then
                    frm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        frm.TopLevel = False
        frm.Location = New Point((panel.Size.Width / 2) - (frm.Size.Width / 2), (panel.Size.Height / 2) - (frm.Size.Height / 2))
        panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
#End Region

#Region "Log4net"
    Public Sub agregarAlLog(Optional frm As Form = Nothing, Optional metodo As String = "", Optional smsError As String = "")
        'Try
        '    logger = log4net.LogManager.GetLogger("log4net.assembly.xml")
        '    logger.Info("Formulario: " & frm.Name)
        '    logger.Debug("methodo: " & metodo)
        '    logger.Error("error: " & smsError)
        'Catch ex As Exception
        '    Try
        '        logger.Error(frm.Name & ", error: " & ex.Message)
        '    Catch ex2 As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End Try
    End Sub
#End Region

#Region "Texto horizontal"
    Public Sub textoHorizontal(e As System.Windows.Forms.PaintEventArgs, btn As Button, texto As String)
        Dim format As New StringFormat
        format.FormatFlags = StringFormatFlags.DirectionVertical
        format.LineAlignment = StringAlignment.Near
        e.Graphics.DrawString(texto, New Font("Arial", 10), Brushes.White, New Point(0, (btn.Size.Height / 4) - (texto.Trim.Length / 2)), format)
    End Sub
    Public Sub textoHorizontal(e As System.Windows.Forms.PaintEventArgs, btn As UltraButton, texto As String)
        Dim format As New StringFormat
        format.FormatFlags = StringFormatFlags.DirectionVertical
        format.LineAlignment = StringAlignment.Near
        e.Graphics.DrawString(texto, New Font("Arial", 10), Brushes.White, New Point(0, (btn.Size.Height / 4) - (texto.Trim.Length / 2)), format)
    End Sub
#End Region
End Module
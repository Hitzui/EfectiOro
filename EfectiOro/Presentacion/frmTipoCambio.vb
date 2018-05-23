Imports EfectiOro.Database

Public Class frmTipoCambio

    Private openFileName As String, folderName As String

    Private Sub frmTipoCambio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Tipo de Cambio"
        cargarDatos()
    End Sub
    Sub cargarDatos()
        Dim dao = DataContext.daoTipoCambio
        'dgvTipo.DataSource = dao.findAllByMes()
        'Dim dao = DataContext.daoTipoCambio
        dgvTipo.DataSource = dao.findAllByMes(txtFecha.Value)
    End Sub
    Sub cargarDatosDesdeArchvio()
        Dim leer As New LeerExcel()
        Dim var As IList(Of Excel) = leer.leerHoja(openFileName)
        dgvTipo.DataSource = var
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub timer_Tick(sender As System.Object, e As System.EventArgs) Handles timer.Tick
        lblHora.Text = Now.ToString("hh:mm:ss")
    End Sub

    Private Sub txtValor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        ServiciosBasicos.NumeroDec(e, txtValor)
    End Sub

    Private Sub btnBuscarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarExcel.Click
        Me.BuscarArchivo.DefaultExt = "xls"
        Me.BuscarArchivo.Filter = "Archivos de Excel|*.xlsx|Archivos de Excel(97-2007)|*.xls"
        ' Display the openFile dialog.
        Dim result As DialogResult = BuscarArchivo.ShowDialog()
        If (result = DialogResult.OK) Then
            openFileName = BuscarArchivo.FileName
            cargarDatosDesdeArchvio()
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click
        cargarDatos()
    End Sub

    Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
        Dim result As DialogResult = MsgBox("¿Ingresar los datos al sistema?", MsgBoxStyle.YesNo, "Ingresar dato")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim dao = DataContext.daoTipoCambio
        Dim listar As New List(Of TipoCambio)
        Try
            For Each row As DataGridViewRow In dgvTipo.Rows
                Dim tipo As New TipoCambio
                tipo.Fecha = row.Cells(1).Value
                tipo.Tipocambio1 = row.Cells(0).Value
                tipo.Hora = lblHora.Text
                tipo.Precio_oro = 0D
                listar.Add(tipo)
            Next
            If dao.grabarDatos(listar) Then
                MsgBox("Se ingresaron los valores en la base de datos", MsgBoxStyle.Information, "Ingresar Datos")
                cargarDatos()
            Else
                MsgBox("No su pudo guardar los datos debido a un error, producido por: " & vbCr _
                       & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox("No se pueden ingresaro los dato seleccionados intente nuevamente", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        If txtValor.TextLength <= 0 Then
            erp.SetError(txtValor, ServiciosBasicos.campoVacio)
            txtValor.Focus()
            Return
        End If
        Dim result As DialogResult = MsgBox("¿Ingresar tipo de cambio al sistema?", MsgBoxStyle.YesNo, "Ingresar dato")
        If result = Windows.Forms.DialogResult.No Then
            Return
        End If
        Dim tipo As New TipoCambio
        tipo.Tipocambio1 = Convert.ToDecimal(txtValor.Text)
        tipo.Fecha = txtFecha.Value
        tipo.Hora = lblHora.Text
        tipo.Precio_oro = 0D
        Dim dao = DataContext.daoTipoCambio
        Dim revisarSiExiste = dao.buscarDato(tipo.Fecha)
        If IsNothing(revisarSiExiste) = False Then
            If MsgBox("Ya existe un tipo de cambio para la fecha indicada, ¿Desea sustituir el valor actual?", _
                      MsgBoxStyle.YesNo, "Tipo de cambio") = MsgBoxResult.No Then
                Return
            Else
                If dao.modificarValor(tipo) Then
                    MsgBox("Se modificó el dato en la base de datos", MsgBoxStyle.Information, "Modificar Datos")
                    cargarDatos()
                    txtValor.Clear()
                Else
                    MsgBox("Se produjo el siguiente errror: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error al ingresar el tipo de cambio")
                    Return
                End If
            End If
        Else
            If dao.ingresarDato(tipo) Then
                MsgBox("Se ingresó el dato en la base de datos", MsgBoxStyle.Information, "Ingresar Datos")
                cargarDatos()
                txtValor.Clear()
            Else
                MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error al ingresar el tipo de cambio")
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Try
            If txtValor.TextLength <= 0 Then
                erp.SetError(txtValor, ServiciosBasicos.campoVacio)
                txtValor.Focus()
                Return
            End If
            Dim result As DialogResult = MsgBox("¿Actualizar el valor del tipo cambio?", MsgBoxStyle.YesNo, "Actualizar dato")
            If result = Windows.Forms.DialogResult.No Then
                Return
            End If
            Dim row As DataGridViewRow = dgvTipo.CurrentRow
            Dim tipo As New TipoCambio
            tipo.Fecha = row.Cells(0).Value
            tipo.Hora = row.Cells(2).Value
            tipo.Tipocambio1 = CDec(txtValor.Text)
            Dim dao = DataContext.daoTipoCambio
            If dao.modificarValor(tipo.Hora, tipo.Fecha.ToShortDateString(), CDec(txtValor.Text)) Then
                MsgBox("Se modificó el dato en la base de datos", MsgBoxStyle.Information, "Modificar Datos")
                cargarDatos()
                txtValor.Clear()
            Else
                MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim result As DialogResult = MsgBox("¿Eliminar el tipo de cambio del sistema?", MsgBoxStyle.YesNo, "Eliminar dato")
            If result = Windows.Forms.DialogResult.No Then
                Return
            End If
            Dim row As DataGridViewRow = dgvTipo.CurrentRow
            Dim tipo As New TipoCambio
            tipo.Fecha = row.Cells(0).Value
            tipo.Hora = row.Cells(2).Value
            tipo.Tipocambio1 = row.Cells(1).Value
            Dim dao = DataContext.daoTipoCambio
            If dao.eliminarValor(tipo) Then
                MsgBox("Se eliminaron los datos del tipo de cambio del sistema", MsgBoxStyle.Information, "Eliminar Datos")
                cargarDatos()
                txtValor.Clear()
            Else
                MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarDato_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarDato.Click
        Try
            Dim dao = DataContext.daoTipoCambio
            Dim indice As Integer
            Dim fecha As String = txtFecha.Text
            Dim indiceCol As Integer = 0
            For Each row As DataGridViewRow In dgvTipo.Rows
                Dim fec As String = row.Cells(0).Value
                'MsgBox("Valor de la fecha: " & fec & vbCr & "Valor de busqueda: " & fecha)
                If fec = fecha Then
                    indice = row.Index
                    dgvTipo.Rows(indice).Selected = True
                    dgvTipo.CurrentCell = dgvTipo.Rows(indice).Cells(0)
                    Exit For
                End If
            Next
            If indice > 0 Then
                dgvTipo.Rows(indice).Selected = True
                dgvTipo.CurrentCell = dgvTipo.Rows(indice).Cells(0)
            Else
                MsgBox("No hay valores que mostrar para la fecha especificada, intente nuevamente", MsgBoxStyle.Information, "Buscar Dato")
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabarValorOro_Click(sender As Object, e As EventArgs) Handles btnGrabarValorOro.Click
        Try
            Dim dao = DataContext.daoTipoCambio
            If dao.grabarValorOro(Convert.ToDecimal(txtValorOro.Text), txtFecha.Value) = True Then
                MsgBox("Se guardó el valor del oro en la fecha indicada de forma correcta.", MsgBoxStyle.Information, "Guardar valor del oro")
                Me.txtValorOro.Clear()
                Me.txtFecha.Value = Now
                Me.cargarDatos()
            Else
                MsgBox(dao.ErrorSms, MsgBoxStyle.Information, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar el valor del oro: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtFecha_ValueChanged(sender As Object, e As EventArgs) Handles txtFecha.ValueChanged
        If Now.Month <> txtFecha.Value.Month Then
            Dim dao = DataContext.daoTipoCambio
            Me.dgvTipo.DataSource = dao.findAllByMes(txtFecha.Value)
        Else
            Me.cargarDatos()
        End If
    End Sub
End Class

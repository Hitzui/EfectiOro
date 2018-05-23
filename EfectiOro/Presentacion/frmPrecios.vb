Imports EfectiOro.Database

Public Class frmPrecios

    Sub rellenarGridConColumnasVacias()
        'Try
        '    If dgvPrecio.Rows.Count > 0 Then
        '        Return
        '    End If
        '    For index = 1 To 10

        '    Next
        'Catch ex As Exception

        'End Try
    End Sub
    Sub cargarDatos()
        Dim dao = DataContext.daoPrecioKilate
        PrecioKilateBindingSource.DataSource = dao.findAll()
        ServiciosBasicos.colorearGrid(dgvPrecio)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPrecios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Establecer Precio - EfectiOro"
        Me.btnClose.Visible = False
        cargarDatos()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim result = MsgBox("¿Actualizar los precios de los items seleccionados?", MsgBoxStyle.YesNo, "Actualizar los precios")
            If result = MsgBoxResult.No Then
                Return
            End If
            Dim dao = DataContext.daoPrecioKilate
            Dim listaPrecio As New List(Of PrecioKilate)
            For Each row As DataGridViewRow In dgvPrecio.Rows
                If row.Cells("colPrecio").Value > 0 Then
                    Dim precio As New PrecioKilate
                    precio.Desc_kilate = row.Cells(0).Value
                    precio.Kilate_peso = row.Cells(1).Value
                    precio.Precio_kilate = row.Cells(2).Value
                    listaPrecio.Add(precio)
                End If
            Next
            If dao.actualizar(listaPrecio) Then
                MsgBox("Se han actualizado los precios seleccionados", MsgBoxStyle.Information, "Actualizar precios")
                cargarDatos()
            Else
                MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDefault_Click(sender As System.Object, e As System.EventArgs) Handles btnDefault.Click
        Dim dao = DataContext.daoPrecioKilate
        Dim result = MsgBox("¿Establecer precios por default?", MsgBoxStyle.YesNo, "Actualizar los precios")
        If result = MsgBoxResult.No Then
            Return
        End If
        If dao.valoresPorDefault() Then
            MsgBox("Se establecieron los valores por default a todos los precios", MsgBoxStyle.Information, "Precio kilate")
            cargarDatos()
        Else
            MsgBox("Se produjo el siguiente error: " & dao.ErrorSms, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub dgvPrecio_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPrecio.EditingControlShowing
        Try
            If CInt(DirectCast(sender, System.Windows.Forms.DataGridView).CurrentCell.ColumnIndex) = 2 Then
                Dim txt As TextBox = CType(e.Control, TextBox)
                AddHandler txt.KeyPress, AddressOf ServiciosBasicos.TextBoxNumeric_KeyPress
            End If
        Catch ex As Exception
        End Try
    End Sub
    Function validarNum(ByVal texto As String) As Boolean
        Try
            Decimal.Parse(texto)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub dgvPrecio_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPrecio.DataError
        Try
            If dgvPrecio.Rows(e.RowIndex).IsNewRow = False Then
                If e.ColumnIndex = 2 Then
                    MsgBox(e.Exception.Message)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvPrecio_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPrecio.CellFormatting
        Try
            If e.ColumnIndex = 0 Then
                If e.Value.ToString().Contains("Kilate") = False Then
                    e.Value = e.Value & " Kilate"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvPrecio_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrecio.CellEndEdit
        Try
            Dim kilataje As Decimal = dgvPrecio.Rows(e.RowIndex).Cells("colDescripcion").Value
            dgvPrecio.Rows(e.RowIndex).Cells("colKilataje").Value = kilataje
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        Dim dao = DataContext.daoParametros
        If dao.habilitarVariasCompras(1) = True Then
            MsgBox("Se a habilitado en el sistema la opción para realizar varias compras." & vbCr _
                   & "De esta manera los precios no se actualizarán a 1, sino hasta desabilitar dicha opción", _
                   MsgBoxStyle.Information, "Habilitar varias compras")
        End If
    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        Dim dao = DataContext.daoParametros
        If dao.habilitarVariasCompras(0) = True Then
            MsgBox("Se ha deshabilitado la opción para realizar varias compras de forma correcta", _
                   MsgBoxStyle.Information, "Habilitar varias compras")
        End If
    End Sub

    Private Sub btnPrecios2_Click(sender As Object, e As EventArgs) Handles btnPrecios2.Click
        frmPrecios2.ShowDialog()
    End Sub
End Class

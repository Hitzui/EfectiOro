Imports EfectiOro.Database

Public Class frmMoneda
    Private Const _guardar As String = "Guardar"
    Dim newRow As Boolean = False

    Private Sub frmMoneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Formulario Moneda Internacional - Local"
        initData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub initData()
        Using ctx As New Contexto
            Try
                MonedaBindingSource.DataSource = ctx.Moneda.ToList()
                dgvMoneda.Columns("dgvFecha").Visible = False
                Dim img_column As New DataGridViewImageColumn
                img_column.Name = "dgvImagen"
                img_column.Image = New Bitmap(My.Resources.delete_20x20)
                img_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvMoneda.Columns.Add(img_column)
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub dgvMoneda_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMoneda.RowEnter
        Try
            If e.RowIndex = dgvMoneda.NewRowIndex Then
                newRow = True
                dgvMoneda.Rows(e.RowIndex).Cells("dgvImagen").Value = My.Resources.save20x20
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvMoneda_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMoneda.CellValueChanged
        Using ctx As New Contexto
            Try
                If newRow = False Then
                    Dim codigo As String = dgvMoneda.Rows(e.RowIndex).Cells("dgvCodigo").Value
                    Dim find = (From m In ctx.Moneda Where m.Codmoneda = codigo Select m).Single
                    find.Descripcion = dgvMoneda.Rows(e.RowIndex).Cells("dgvDescripcion").Value
                    find.Simbolo = dgvMoneda.Rows(e.RowIndex).Cells("dgvSimbolo").Value
                    ctx.SubmitChanges()
                    MsgBox("Datos guardados de forma correcta", MsgBoxStyle.Information, _guardar)
                End If
            Catch ex As Exception
                ' MsgBox("No se pudo guardar los datos, debido al siguiente error: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    Private Sub dgvMoneda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMoneda.CellClick
        Using ctx As New Contexto
            Try
                If dgvMoneda.Rows(e.RowIndex).Cells("dgvImagen").Selected = True Then
                    If newRow = True Then
                        Dim result As DialogResult = MessageBox.Show(Me, "¿Guardar los datos en el sistema?", _guardar, MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            newRow = False
                            Return
                        End If
                        'add new reg
                        Dim moneda As New Moneda With {
                            .Descripcion = dgvMoneda.Rows(e.RowIndex).Cells("dgvDescripcion").Value,
                            .Simbolo = dgvMoneda.Rows(e.RowIndex).Cells("dgvSimbolo").Value
                        }
                        ctx.Moneda.InsertOnSubmit(moneda)
                        ctx.SubmitChanges()
                        newRow = False
                        dgvMoneda.Rows(e.RowIndex).Cells("dgvImagen").Value = My.Resources.delete_20x20
                        MsgBox("Datos guardados de forma correcta", MsgBoxStyle.Information, _guardar)
                    ElseIf newRow = False And e.RowIndex >= 0 Then
                        Dim result As DialogResult = MessageBox.Show(Me, "¿Eliminar los datos en el sistema?", _guardar, MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            Return
                        End If
                        Dim codigo As String = dgvMoneda.Rows(e.RowIndex).Cells("dgvCodigo").Value
                        Dim find = (From m In ctx.Moneda Where m.Codmoneda = codigo Select m).Single
                        ctx.Moneda.DeleteOnSubmit(find)
                        ctx.SubmitChanges()
                        dgvMoneda.Rows.RemoveAt(e.RowIndex)
                        MsgBox("Datos eliminados de forma correcta", MsgBoxStyle.Information, _guardar)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dgvMoneda_CancelRowEdit(sender As Object, e As QuestionEventArgs) Handles dgvMoneda.CancelRowEdit
        newRow = False
    End Sub

    Private Sub dgvMoneda_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMoneda.CellEndEdit
        If Not (Me.dgvMoneda.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Is Nothing Then
            Me.dgvMoneda.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Me.dgvMoneda.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper
        End If
    End Sub

    Private Sub dgvMoneda_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvMoneda.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub
End Class

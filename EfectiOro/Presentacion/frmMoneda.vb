Imports EfectiOro.Database

Public Class frmMoneda

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
                dgvMoneda.Columns(0).ReadOnly = True
                dgvMoneda.Columns(3).Visible = False
                Dim img_column As New DataGridViewImageColumn
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
                dgvMoneda.Columns(0).ReadOnly = False
                dgvMoneda.Rows(e.RowIndex).Cells(4).Value = My.Resources.save20x20
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvMoneda_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMoneda.CellValueChanged
        Using ctx As New Contexto
            Try
                If newRow = False Then
                    Dim codigo As String = dgvMoneda.Rows(e.RowIndex).Cells(0).Value
                    Dim find = (From m In ctx.Moneda Where m.Codmoneda = codigo Select m).Single
                    find.Descripcion = dgvMoneda.Rows(e.RowIndex).Cells(1).Value
                    find.Simbolo = dgvMoneda.Rows(e.RowIndex).Cells(2).Value
                    ctx.SubmitChanges()
                End If
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub dgvMoneda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMoneda.CellClick
        Using ctx As New Contexto
            Try
                If dgvMoneda.Rows(e.RowIndex).Cells(4).Selected = True Then
                    If newRow = True Then
                        Dim result As DialogResult = MessageBox.Show(Me, "¿Guardar los datos en el sistema?", "Guardar", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            newRow = False
                            Return
                        End If
                        'add new reg
                        Dim moneda As New Moneda With {
                            .Codmoneda = dgvMoneda.Rows(e.RowIndex).Cells(0).Value,
                            .Descripcion = dgvMoneda.Rows(e.RowIndex).Cells(1).Value,
                            .Simbolo = dgvMoneda.Rows(e.RowIndex).Cells(2).Value
                        }
                        ctx.Moneda.InsertOnSubmit(moneda)
                        ctx.SubmitChanges()
                        newRow = False
                        dgvMoneda.Columns(0).ReadOnly = True
                        dgvMoneda.Rows(e.RowIndex).Cells(4).Value = My.Resources.delete_20x20
                    ElseIf newRow = False And e.RowIndex >= 0 Then
                        Dim result As DialogResult = MessageBox.Show(Me, "¿Eliminar los datos en el sistema?", "Guardar", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            Return
                        End If
                        Dim codigo As String = dgvMoneda.Rows(e.RowIndex).Cells(0).Value
                        Dim find = (From m In ctx.Moneda Where m.Codmoneda = codigo Select m).Single
                        ctx.Moneda.DeleteOnSubmit(find)
                        ctx.SubmitChanges()
                        dgvMoneda.Rows.RemoveAt(e.RowIndex)
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
End Class

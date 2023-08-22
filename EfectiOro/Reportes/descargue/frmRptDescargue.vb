Imports EfectiOro.Database

Public Class frmRptDescargue

    Private Sub frmRptDescargue_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Generar Report de Descargues"
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Using ctx As New Contexto
            Try
                If radDescarguegen.Checked Then
                    Dim desc As List(Of Descargues) = (From d In ctx.Descargues
                                                       Where d.Dgfecdes <= txtHasta.Value And d.Dgfecdes >= txtDesde.Value
                                                       Select d).ToList()
                    Dim report As New rptDescargaGen
                    If desc.Count <= 0 Then
                        MsgBox("No hay datos a mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Descargues")
                        Return
                    End If
                    report.SetDataSource(desc)
                    ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value)
                    frmReportes.viewer.ReportSource = report
                    frmReportes.Show()
                End If
                If radDescarguedet.Checked Then
                    Dim desc As List(Of DescargueByCompra) = (From d In ctx.DescargueByCompra
                                                              Where d.Dgfecdes >= txtDesde.Value And d.Dgfecdes <= txtHasta.Value
                                                              Select d).ToList()
                    If desc.Count <= 0 Then
                        MsgBox("No hay datos a mostrar en el rango de fechas indicado, intente nuevamente", MsgBoxStyle.Information, "Descargues")
                        Return
                    End If
                    'Dim report As New rptDescarguedet
                    'report.SetDataSource(desc)
                    'ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value)
                    'frmReportes.viewer.ReportSource = report
                    'frmReportes.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
            End Try
        End Using
    End Sub
End Class

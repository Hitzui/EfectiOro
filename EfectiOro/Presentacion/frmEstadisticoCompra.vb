Imports EfectiOro.Database
Imports System.Reflection

Public Class frmEstadisticoCompra

    Private listaAcumuladoDatos As List(Of Estadisticos)

    Private Sub llenarComboBox()
        Dim compra As New Compras
        Dim esteObjeto As Type = compra.GetType()
        Dim propiedades As PropertyInfo() = esteObjeto.GetProperties()
        Dim listaDecimales As New List(Of PropertyInfo)
        For Each dato In propiedades
            If dato.PropertyType.Name = "Decimal" Then
                listaDecimales.Add(dato)
            End If
        Next
        Me.cmbCampo.DisplayMember = "Name"
        Me.cmbCampo.DataSource = listaDecimales
    End Sub


    Private Function recuperarSumaCompras(ByVal n As Integer) As Boolean
        Using ctx As New Contexto
            Try
                Me.listaAcumuladoDatos = New List(Of Estadisticos)
                Me.dgvEstadistica.Rows.Clear()
                Dim total_acumulado, total_cantidad As Decimal
                '*****************************************************************
                'especificamos la consulta a recuperar los datos
                'esta consulta lo que hace es solo recuperar las cantidades
                'sin calcular la suma acumulada
                '*****************************************************************
                Dim recuperarSumaPorDia = (From c In ctx.Compras.AsEnumerable
                                           Where c.Fecha <= Me.txtHasta.Value And c.Fecha >= Me.txtDesde.Value
                                           Group By c.Fecha Into suma = Sum(CType(CType(cmbCampo.SelectedValue, PropertyInfo).GetValue(c, Nothing), Decimal)),
                                           Cantidad = Count() Select Cantidad, Fecha, suma).ToList
                If recuperarSumaPorDia.Count < 0 Then
                    MsgBox("No hay datos a mostrar en el rango de fechas indicado", MsgBoxStyle.Information, "Buscar")
                    Return False
                End If
                Dim sumcantidad As Decimal = 0D
                Dim sumar As Decimal = 0D
                '*********************************************************************
                'recorremos la lista de datos el cual contine la suma de cada dia
                'no lo ha acumulado segun la variable n especificada
                '*********************************************************************
                For Each dato In recuperarSumaPorDia
                    n = Convert.ToInt32(txtValor.Text)
                    sumar = 0D
                    sumcantidad = 0D
                    Dim estadistico As New Estadisticos()
                    Dim dias_del_mes As Integer = dato.Fecha.Day
                    If dato.Fecha.Month = txtHasta.Value.Month Then
                        If dato.Fecha.Day = txtHasta.Value.Day Then
                            If n = Convert.ToInt32(txtValor.Text) Then
                                'n -= 1
                            End If
                        End If
                    End If
                    Dim restar_dias As Date = dato.Fecha.AddDays(1 - n)
                    '*****************************************************************
                    'esta consulta lo que hace es agrupar los datos
                    'en la fecha especifica, ya se calcula la suma acumulada
                    '*****************************************************************
                    Dim calcular = (From c In ctx.Compras.AsEnumerable
                                    Where c.Fecha <= dato.Fecha And c.Fecha >= restar_dias
                                    Group By c.Fecha Into suma = Sum(CType(CType(cmbCampo.SelectedValue, PropertyInfo).GetValue(c, Nothing), Decimal)),
                                    Cantidad = Count() Select Cantidad, suma, Fecha).ToList
                    For Each sub_dato In calcular
                        sumar += sub_dato.suma
                        sumcantidad += sub_dato.Cantidad
                    Next
                    total_acumulado += sumar
                    total_cantidad += sumcantidad
                    estadistico.Fecha = dato.Fecha
                    estadistico.Cantidad = sumcantidad
                    estadistico.Suma = sumar
                    estadistico.Total = total_acumulado
                    estadistico.TotalCantidad = total_cantidad
                    Me.listaAcumuladoDatos.Add(estadistico)
                Next
                For Each dato As Estadisticos In Me.listaAcumuladoDatos.OrderBy(Function(p) p.Fecha)
                    dgvEstadistica.Rows.Add(dato.Cantidad, dato.Fecha, dato.Suma)
                Next
                Return True
            Catch ex As Exception
                MsgBox("Se produjo el siguiente error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub frmEstadisticoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.recuperarSumaCompras(1)
        Me.lblTitulo.Text = "Informe estadistico"
        panelDialogo.Size = New Size(607, 326)
        Me.llenarComboBox()
    End Sub


    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        ServiciosBasicos.NumeroDec(e, Me.txtValor)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnCalcular.Focus()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If txtValor.Text = String.Empty Then
            MsgBox("Debe especificar un valor para poder realizar los calculos necesarios", MsgBoxStyle.Exclamation, "Calcular")
            Return
        End If
        If panelDialogo.Visible = True Then
            panelDialogo.Visible = False
        End If
        Dim dato As Integer = Convert.ToInt32(Me.txtValor.Text)
        If Me.recuperarSumaCompras(dato) = False Then
            If Me.panelDialogo.Visible = False Then
                Me.panelDialogo.Visible = True
            End If
        End If
        Dim suma As Decimal = 0D
        Dim promedio As Decimal = 0D
        Me.lblCantidad.Text = Me.dgvEstadistica.Rows.Count
        Try
            For Each row As DataGridViewRow In Me.dgvEstadistica.Rows
                suma += row.Cells(2).Value
            Next
            Me.lblSumaFilas.Text = suma.ToString("#,###,#00.000")
            promedio = suma / dgvEstadistica.Rows.Count
            Me.lblPromedio.Text = promedio.ToString("#,###,#00.000")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If Me.panelDialogo.Visible = False Then
            Me.panelDialogo.Visible = True
        End If
    End Sub

    Private Sub cmbCampo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCampo.SelectedValueChanged

    End Sub

    Private Sub cmbCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCampo.SelectedIndexChanged
        Me.lblCampo.Text = CType(cmbCampo.SelectedValue, PropertyInfo).Name
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        If Me.listaAcumuladoDatos.Count <= 0 Then
            MsgBox("No ha especificado los datos a visualizar, intente nuevamente", MsgBoxStyle.Information, "Visualizar")
            Return
        End If
        Dim xreport As New rptEstadistico
        xreport.SetDataSource(Me.listaAcumuladoDatos)
        ServiciosBasicos.ParametrosCrystal(txtDesde.Value, txtHasta.Value)
        frmReportes.viewer.ReportSource = xreport
        frmReportes.Show()
    End Sub

    Private Sub txtDesde_ValueChanged(sender As Object, e As EventArgs) Handles txtDesde.ValueChanged
        Try
            Dim valor = txtDesde.Value.DayOfYear - txtHasta.Value.DayOfYear
            lblRangoDias.Text = Convert.ToString(valor)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtHasta_ValueChanged(sender As Object, e As EventArgs) Handles txtHasta.ValueChanged
        Try
            Dim valor = txtDesde.Value.DayOfYear - txtHasta.Value.DayOfYear
            lblRangoDias.Text = Convert.ToString(valor)
        Catch ex As Exception

        End Try
    End Sub
End Class


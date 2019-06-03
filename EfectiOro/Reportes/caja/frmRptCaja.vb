Imports CrystalDecisions.Shared
Imports EfectiOro.Database

Public Class frmRptCaja

    Private Sub verCombosCajas()
        If Me.radConsolodidadoCaja.Checked = True Then
            Me.cmbCajaconsolidado.Visible = True
        Else
            Me.cmbCajaconsolidado.Visible = False
        End If
        If Me.radConsolodidadoCaja.Checked = True Or Me.radConsolidadoTodos.Checked = True Then
            Me.txtDesde.Enabled = False
        Else
            Me.txtDesde.Enabled = True
        End If
        If Me.radFiltrarCaja.Checked Then
            Me.cmbCajafiltrar.Visible = True
        Else
            Me.cmbCajafiltrar.Visible = False
        End If
    End Sub

    Private Sub llenarComboFiltrar()
        Dim daoCaja = DataContext.daoCaja
        Me.cmbCajafiltrar.DataSource = daoCaja.findAll()
        Me.cmbCajafiltrar.ValueMember = "Codcaja"
        Me.cmbCajafiltrar.DisplayMember = "Codcaja"
    End Sub

    Private Sub llenarComboConsolidado()
        Dim daoCaja = DataContext.daoCaja
        Me.cmbCajaconsolidado.DataSource = daoCaja.findAll()
        Me.cmbCajaconsolidado.ValueMember = "Codcaja"
        Me.cmbCajaconsolidado.DisplayMember = "Codcaja"
    End Sub

    Private Sub frmRptCaja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Gererar reporte de cajas"
        Me.btnClose.Visible = False
        Me.llenarComboConsolidado()
        Me.llenarComboFiltrar()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        'select mc.codcaja,r.descrubro, m.descripcion, SUM(dc.efectivo) AS Efectivo,
        'SUM(dc.cheque) AS cheque, SUM(dc.transferencia) AS transferencia
        'FROM dbo.detacaja AS dc join mcaja mc on dc.idcaja = mc.idcaja
        'INNER JOIN dbo.movcaja AS m ON dc.idmov = m.idmov 
        'INNER JOIN dbo.Rubro AS r ON m.codrubro = r.codrubro
        'where dc.fecha>=CAST('26/05/2015' as date) and mc.codcaja='C01'
        'GROUP BY m.descripcion, r.descrubro,mc.codcaja
        Dim Parametros As ParameterFields = New ParameterFields()
        Dim parDesde As ParameterField = New ParameterField()
        Dim parHasta As ParameterField = New ParameterField()
        Dim disDesde As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim disHasta As ParameterDiscreteValue = New ParameterDiscreteValue()
        parDesde.ParameterFieldName = "Desde"
        parHasta.ParameterFieldName = "Hasta"
        'Paso los Datos
        disDesde.Value = txtDesde.Value
        disHasta.Value = txtHasta.Value
        'agregamos al report viewer
        parDesde.CurrentValues.Add(disDesde)
        parHasta.CurrentValues.Add(disHasta)
        'Cargo los parametros y los envio al Crystal
        Parametros.Add(parDesde)
        Parametros.Add(parHasta)
        Using ctx As New Contexto
            Dim consulta As New List(Of VistaMovCaja)
            Dim query As IList = New List(Of Object)
            Dim recCaja As String
            Dim config As New ConfiguracionGeneral
            recCaja = config.getCaja()
            If radConsolidadoRangoFecha.Checked Then
                Select Case cmbConsolidadoCajaFecha.SelectedIndex
                    Case 0
                        'reporte de caja consolidado segun rando de fecha por dia
                        Dim datos = (From dc In ctx.Detacaja
                                     Join mc In ctx.Mcaja On dc.codcaja Equals mc.Codcaja _
                                      And dc.idcaja Equals mc.Idcaja
                                     Join mov In ctx.Movcaja On dc.idmov Equals mov.Idmov
                                     Join r In ctx.Rubro On mov.Codrubro Equals r.Codrubro
                                     Where
                                       dc.fecha.Date >= txtDesde.Value.Date And dc.fecha.Date <= txtHasta.Value.Date
                                     Group New With {r, mov, dc} By
                                       r.Naturaleza,
                                       mov.Descripcion,
                                       dia = CType(dc.fecha.Day, Integer),
                                       mes = CType(dc.fecha.Month, Integer),
                                       anio = CType(dc.fecha.Year, Integer),
                                       r.Descrubro
                                      Into g = Group
                                     Order By
                                       mes, dia
                                     Select
                                       anio, dia, mes, Descrubro, Descripcion,
                                       efectivo = If(Naturaleza = 1, g.Sum(Function(p) p.dc.efectivo), (-1 * g.Sum(Function(p) p.dc.efectivo))),
                                       cheque = If(Naturaleza = 1, g.Sum(Function(p) p.dc.cheque), (-1 * g.Sum(Function(p) p.dc.cheque))),
                                       transferencia = If(Naturaleza = 1, g.Sum(Function(p) p.dc.transferencia), (-1 * g.Sum(Function(p) p.dc.transferencia)))).ToList()
                        consulta = New List(Of VistaMovCaja)
                        If datos.Count <= 0 Then
                            MsgBox("No hay datos que mostrar en el rango de fechas especificado, intente nuevamente",
                                   MsgBoxStyle.Information, "Consolidado de cajas")
                            Return
                        End If
                        For Each dato In datos
                            Dim vista As New VistaMovCaja
                            vista.Anio = dato.anio
                            vista.Transferencia = dato.transferencia
                            vista.Cheque = dato.cheque
                            vista.Caja = String.Empty
                            vista.Descripcoin = dato.Descripcion
                            vista.Rubro = dato.Descrubro
                            vista.Efectivo = dato.efectivo
                            vista.Dia = dato.dia
                            vista.Mes = dato.mes
                            consulta.Add(vista)
                        Next
                        Dim frmrpt As New frmReporteConsolodidadoGeneral
                        Dim xreport As New rptConsolidadoRangoFecha
                        xreport.SetDataSource(consulta)
                        frmrpt.CrystalReportViewer1.ParameterFieldInfo = Parametros
                        frmrpt.CrystalReportViewer1.ReportSource = xreport
                        frmrpt.Show()
                        Return
                    Case 1
                        Dim buscar = ctx.ConsolidadoCajaFecha(txtDesde.Value.Date, txtHasta.Value.Date, "C001").ToList
                        If buscar.Count > 0 Then

                        End If
                End Select
            End If
            If radConsolidadoTodos.Checked Then
                query = (From dc In ctx.Detacaja
                         Join mc In ctx.Mcaja On New With {dc.idcaja} Equals New With {mc.Idcaja}
                         Join m In ctx.Movcaja On dc.idmov Equals m.Idmov
                         Join r In ctx.Rubro On New With {.Codrubro = CInt(m.Codrubro)} Equals New With {.Codrubro = r.Codrubro}
                         Where dc.fecha.Date = txtHasta.Value.Date And dc.codcaja = mc.Codcaja
                         Group New With {m, r, mc, dc} By m.Descripcion, r.Descrubro, r.Naturaleza Into g = Group
                         Select Descrubro, Descripcion, Efectivo = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.efectivo), -1 * g.Sum(Function(p) p.dc.efectivo)), Decimal?),
                              cheque = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.cheque), -1 * g.Sum(Function(p) p.dc.cheque)), Decimal?),
                              transferencia = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.transferencia), -1 * g.Sum(Function(p) p.dc.transferencia)), Decimal?)).ToList()
                consulta = New List(Of VistaMovCaja)
                If query.Count <= 0 Then
                    MsgBox("No hay datos que mostrar en el rango de fechas especificado, intente nuevamente",
                           MsgBoxStyle.Information, "Consolidado de cajas")
                    Return
                End If
                For Each dato In query
                    Dim vista As New VistaMovCaja
                    vista.Transferencia = dato.transferencia
                    vista.Cheque = dato.cheque
                    vista.Caja = String.Empty
                    vista.Descripcoin = dato.Descripcion
                    vista.Rubro = dato.Descrubro
                    vista.Efectivo = Convert.ToDecimal(dato.Efectivo)
                    consulta.Add(vista)
                Next
                Dim frmrpt As New frmReporteConsolodidadoGeneral
                Dim xreport As New rptConsolidadoGeneral
                xreport.SetDataSource(consulta)
                frmrpt.CrystalReportViewer1.ParameterFieldInfo = Parametros
                frmrpt.CrystalReportViewer1.ReportSource = xreport
                frmrpt.Show()
                Return
            End If
            If radConsolodidadoCaja.Checked Then
                Dim caja As String = cmbCajaconsolidado.SelectedValue
                'query = (From dc In ctx.Detacaja _
                '            Join mc In ctx.Mcaja On New With {dc.Idcaja} Equals New With {mc.Idcaja} _
                '            Join m In ctx.Movcaja On dc.Idmov Equals m.Idmov _
                '            Join r In ctx.Rubro On New With {.Codrubro = CInt(m.Codrubro)} Equals New With {.Codrubro = r.Codrubro} _
                '            Where dc.Codcaja = caja And mc.Codcaja = caja And dc.Fecha >= txtDesde.Value And dc.Fecha <= txtHasta.Value _
                '            Group New With {m, r, mc, dc} By m.Descripcion, r.Descrubro, mc.Codcaja, r.Naturaleza Into g = Group _
                '            Select Codcaja, Descrubro, Descripcion, Efectivo = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.Efectivo), -1 * g.Sum(Function(p) p.dc.Efectivo)), Decimal?), _
                '              cheque = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.Cheque), -1 * g.Sum(Function(p) p.dc.Cheque)), Decimal?), _
                '              transferencia = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.Transferencia), -1 * g.Sum(Function(p) p.dc.Transferencia)), Decimal?)).ToList()
                query = (From r In ctx.Rubro Join mc In ctx.Movcaja On r.Codrubro Equals mc.Codrubro
                         Join dc In ctx.Detacaja On mc.Idmov Equals dc.idmov
                         Where (dc.codcaja = caja And dc.fecha.Date = txtHasta.Value.Date)
                         Group New With {r, mc, dc} By mc.Descripcion, r.Descrubro, dc.codcaja, r.Naturaleza Into g = Group
                         Select codcaja, Descrubro, Descripcion, EFectivo = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.efectivo), -1 * g.Sum(Function(p) p.dc.efectivo)), Decimal?),
                              cheque = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.cheque), -1 * g.Sum(Function(p) p.dc.cheque)), Decimal?),
                              transferencia = CType(IIf(Naturaleza = 1, g.Sum(Function(p) p.dc.transferencia), -1 * g.Sum(Function(p) p.dc.transferencia)), Decimal?)).ToList()
                consulta = New List(Of VistaMovCaja)
                If query.Count <= 0 Then
                    MsgBox("No hay datos que mostrar en el rango de fechas especificado, intente nuevamente", _
                           MsgBoxStyle.Information, "Consolidado de cajas")
                    Return
                End If
                For Each dato In query
                    Dim vista As New VistaMovCaja
                    vista.Transferencia = Convert.ToDecimal(dato.transferencia)
                    vista.Cheque = Convert.ToDecimal(dato.cheque)
                    vista.Caja = dato.Codcaja
                    vista.Descripcoin = dato.Descripcion
                    vista.Rubro = dato.Descrubro
                    vista.Efectivo = Convert.ToDecimal(dato.Efectivo)
                    consulta.Add(vista)
                Next
                Dim frmrpt As New frmReporteConsolodidadoGeneral
                Dim xreport As New rptConsolidadoGeneral
                xreport.SetDataSource(consulta)
                frmrpt.CrystalReportViewer1.ParameterFieldInfo = Parametros
                frmrpt.CrystalReportViewer1.ReportSource = xreport
                frmrpt.Show()
                Return
            End If

            Dim buscarCaja As New List(Of Detacaja)

            If radFiltrarCajaActual.Checked Then
                buscarCaja.Clear()
                Dim dcCaja = (From dc In ctx.Detacaja
                              Join mc In ctx.Movcaja On dc.idmov Equals mc.Idmov
                              Join r In ctx.Rubro On mc.Codrubro Equals r.Codrubro
                              Where dc.codcaja = recCaja And dc.fecha.Date <= txtHasta.Value.Date And dc.fecha >= txtDesde.Value.Date
                              Order By dc.fecha Ascending
                              Select New With { _
                                    dc.idcaja, dc.idmov, dc.hora, dc.fecha, dc.concepto,
                                    .efectivo = IIf(r.Naturaleza = 1, dc.efectivo, -1 * dc.efectivo), _
                                    .cheque = IIf(r.Naturaleza = 1, dc.cheque, -1 * dc.cheque), _
                                    .transferencia = IIf(r.Naturaleza = 1, dc.transferencia, -1 * dc.transferencia), _
                                    dc.codcaja
                                  }).ToList
                For Each dato In dcCaja
                    buscarCaja.Add(New Detacaja With {
                                    .idcaja = dato.idcaja, _
                                    .idmov = dato.idmov, _
                                    .hora = dato.hora, _
                                    .fecha = dato.fecha, _
                                    .concepto = dato.concepto, _
                                    .efectivo = Convert.ToDecimal(dato.efectivo), _
                                    .cheque = Convert.ToDecimal(dato.cheque), _
                                    .transferencia = CDec(.transferencia), _
                                    .codcaja = dato.codcaja
                                })
                Next
            End If
            If radFiltrarCaja.Checked Then
                recCaja = cmbCajafiltrar.Text
                buscarCaja.Clear()
                Dim dcCaja = (From dc In ctx.Detacaja
                              Join mc In ctx.Movcaja On dc.idmov Equals mc.Idmov
                              Join r In ctx.Rubro On mc.Codrubro Equals r.Codrubro
                              Where dc.codcaja = recCaja And dc.fecha.Date <= txtHasta.Value.Date _
                              And dc.fecha.Date >= txtDesde.Value.Date Order By dc.fecha Ascending
                              Select New With { _
                                    dc.idcaja, dc.idmov, dc.hora, dc.fecha, dc.concepto,
                                    .efectivo = IIf(r.Naturaleza = 1, dc.efectivo, -1 * dc.efectivo), _
                                    .cheque = IIf(r.Naturaleza = 1, dc.cheque, -1 * dc.cheque), _
                                    .transferencia = IIf(r.Naturaleza = 1, dc.transferencia, -1 * dc.transferencia), _
                                    dc.codcaja
                                  }).ToList
                For Each dato In dcCaja
                    buscarCaja.Add(New Detacaja With {
                                   .idcaja = dato.idcaja, _
                                   .idmov = dato.idmov, _
                                   .hora = dato.hora, _
                                   .fecha = dato.fecha, _
                                   .concepto = dato.concepto, _
                                   .efectivo = Convert.ToDecimal(dato.efectivo), _
                                   .cheque = Convert.ToDecimal(dato.cheque), _
                                   .transferencia = CDec(.transferencia), _
                                   .codcaja = dato.codcaja
                               })
                Next
            End If
            If buscarCaja.Count <= 0 Then
                MsgBox("No hay datos que mostrar en el rango de fechas especificado, intente nuevamente",
                       MsgBoxStyle.Information, "Reporte de cajas")
                Return
            End If
            Dim frmcajaAcual As New frmReporteCajaActual
            Dim report As New rptCajaActual
            report.SetDataSource(buscarCaja)
            'Nombre del Parametro definido dentro de “Campos de Parametros” del Crystal..
            'Paso los Datos
            disDesde.Value = txtDesde.Value
            disHasta.Value = txtHasta.Value
            'agregamos al report viewer
            parDesde.CurrentValues.Add(disDesde)
            parHasta.CurrentValues.Add(disHasta)
            'Cargo los parametros y los envio al Crystal
            Parametros.Add(parDesde)
            Parametros.Add(parHasta)
            frmcajaAcual.viewer.ParameterFieldInfo = Parametros
            frmcajaAcual.viewer.ReportSource = report
            frmcajaAcual.Show()
        End Using
    End Sub

    Private Sub radConsolodidadoCaja_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radConsolodidadoCaja.CheckedChanged
        Me.verCombosCajas()
    End Sub

    Private Sub radFiltrarCaja_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Me.verCombosCajas()
    End Sub

    Private Sub radConsolidadoTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radConsolidadoTodos.CheckedChanged
        Me.verCombosCajas()
    End Sub

    Private Sub radFiltrarCaja_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles radFiltrarCaja.CheckedChanged
        Me.verCombosCajas()
    End Sub

    Private Sub radConsolidadoRangoFecha_CheckedChanged(sender As Object, e As EventArgs) Handles radConsolidadoRangoFecha.CheckedChanged
        If radConsolidadoRangoFecha.Checked Then
            cmbConsolidadoCajaFecha.Visible = True
        Else
            cmbConsolidadoCajaFecha.Visible = False
        End If
    End Sub
End Class
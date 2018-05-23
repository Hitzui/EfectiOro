Imports System.Data.SqlClient
Imports System.Data.Linq.SqlClient
Imports EfectiOro.Database

Public Class DaoDescargues
    Implements IDaoDescargues

    Private _error As String

    Public ReadOnly Property ErrorSms As String Implements IDaoDescargues.ErrorSms
        Get
            Return _error
        End Get
    End Property
    Public Function guardarDescargueDetalleCompra(numcompra As String, detaCompra As List(Of Det_compra)) As Boolean Implements IDaoDescargues.guardarDescargueDetalleCompra
        Using ctx As New Contexto
            Try
                Dim compra = (From c In ctx.Compras Where c.Numcompra = numcompra Select c).First
                compra.Dgnumdes = numeroDeDescargue()
                For Each deta As Det_compra In detaCompra
                    deta.Numdescargue = numeroDeDescargue()
                    ctx.Det_compra.InsertOnSubmit(deta)
                Next
                ctx.Compras.InsertOnSubmit(compra)
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function numeroDeDescargue() As Integer Implements IDaoDescargues.numeroDeDescargue
        Using ctx As New Contexto
            Try
                Dim siguienteCod = (From d In ctx.Descargues Order By d.Dgnumdes Descending Select d).First
                Dim dgnumero As Integer = siguienteCod.Dgnumdes + 1
                Return dgnumero
            Catch ex As Exception
                _error = ex.Message
                Return 1
            End Try
        End Using
    End Function
    Public Function generarLote(fecha As Date, agencia As String) As System.Collections.Generic.List(Of Database.Compras) Implements IDaoDescargues.generarLote
        Using ctx As New Contexto
            Try
                'estados de la compra:
                '0 - anulado
                '1 - Vigente
                '2 - Cerrado
                '3 - Descargado
                Dim generar As New List(Of Compras)
                If agencia.Trim.Length <= 0 Then
                    generar = (From c In ctx.Compras
                               Where c.Fecha <= fecha And c.Codestado = 2
                               Order By c.Numcompra Ascending
                               Select c).ToList()
                Else
                    generar = (From c In ctx.Compras
                               Where c.Fecha <= fecha And c.Codestado = 2 _
                               And c.Codagencia = agencia
                               Order By c.Numcompra Ascending
                               Select c).ToList()
                End If
                Return generar
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function generarLoteTabla(fecha As Date) As DataSet Implements IDaoDescargues.generarLoteTabla
        Using ctx As New Contexto
            Try
                Dim connection = ctx.Connection
                Dim cmd = New SqlCommand()
                cmd.CommandText = "select codcaja,codcliente,numcompra,peso,total,fecha from compras where codestado = 2 and fecha <= '" &
                    fecha.Month & "-" & fecha.Day & "-" & fecha.Year & "' order by numcompra desc"
                cmd.CommandType = CommandType.Text
                cmd.Connection = connection
                Dim da = New SqlDataAdapter()
                da.SelectCommand = cmd
                Dim ds = New DataSet
                da.Fill(ds)
                Return ds
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function guardarLotoeDetaCompra(ByVal detalle As List(Of KeyValuePair(Of String, Integer)), descargue As Descargues) As Boolean Implements IDaoDescargues.guardarLotoeDetaCompra
        Using ctx As New Contexto
            Dim numdescargue = numeroDeDescargue()
            Dim connection = ctx.Connection
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim tx = connection.BeginTransaction
            Dim dao = DataContext.daoCompras
            Try
                Dim result As Integer = 0
                For Each valor In detalle
                    Dim cmd As New SqlCommand
                    cmd.Connection = connection
                    cmd.Transaction = tx
                    'Guardamos el detalle de compra con su lote generado
                    cmd.CommandText = "update det_compra set numdescargue = " & numdescargue & " where numcompra = '" & valor.Key & "' and linea = " & valor.Value
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = connection
                    cmd2.Transaction = tx
                    'guardamos el lote generado y le pasamos el numero de lote a la compra
                    'codestado = 3, indica que se ha descargado la compra
                    Dim lista = dao.findDetaCompra(valor.Key).Count
                    Dim count = dao.findDetaCompra(valor.Key).Where(Function(f) f.Numdescargue > 0).Count
                    Dim estado As Integer
                    If lista > count Then
                        estado = 2
                    ElseIf lista = count Then
                        estado = 3
                    End If
                    cmd2.CommandText = "update compras set dgnumdes = " & numdescargue & ", codestado = " & estado & " where numcompra = '" & valor.Key & "'"
                    cmd2.CommandType = CommandType.Text
                    cmd2.ExecuteNonQuery()
                Next
                Dim cmdDescargue As New SqlCommand()
                cmdDescargue.CommandText = "INSERT INTO [dbo].[descargues]  VALUES " &
                           "('" & descargue.Dgcodage & "','" & descargue.Dgcodcaj &
                           "','" & descargue.Dgusuari & "', " & descargue.Dgnumdes &
                           "," & descargue.Dgcancom & "," & descargue.Dgpesbrt &
                           "," & descargue.Dgpesntt & ", " & descargue.Dgimptcom &
                           ",'" & descargue.Dgfecdes.Month & "-" & descargue.Dgfecdes.Day & "-" & descargue.Dgfecdes.Year &
                           "','" & descargue.Dgfecgen.Month & "-" & descargue.Dgfecgen.Day & "-" & descargue.Dgfecgen.Year & "')"
                cmdDescargue.CommandType = CommandType.Text
                cmdDescargue.Connection = connection
                cmdDescargue.Transaction = tx
                cmdDescargue.ExecuteNonQuery()
                tx.Commit()
                Return True
            Catch ex As Exception
                tx.Rollback()
                _error = ex.Message
                Return False
            Finally
                connection.Close()
            End Try
        End Using
    End Function
    
    Public Function guardarLoteGenerado(descargue As Descargues) As Boolean Implements IDaoDescargues.guardarLoteGenerado
        Using ctx As New Contexto
            Try
                ctx.Descargues.InsertOnSubmit(descargue)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function
    Public Function verLotesDescargados(desde As Date, hasta As Date) As List(Of Descargues) Implements IDaoDescargues.verLotesDescargados
        Using ctx As New Contexto
            Try
                Dim ver = (From d In ctx.Descargues Where d.Dgfecdes <= hasta And d.Dgfecdes >= desde Select d).ToList()
                Return ver
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function verDescarguesCompras(numdes As Integer) As List(Of Compras) Implements IDaoDescargues.verDescarguesCompras
        Using ctx As New Contexto
            Try
                Dim lote = (From c In ctx.Compras Where c.Dgnumdes = numdes Select c).ToList()
                Return lote
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function verDescarguesCompras(desde As Date, hasta As Date) As List(Of Compras) Implements IDaoDescargues.verDescarguesCompras
        Using ctx As New Contexto
            Try
                Dim lote = (From c In ctx.Compras Join d In ctx.Descargues On c.Dgnumdes Equals d.Dgnumdes
                            Where c.Dgnumdes > 0 And d.Dgfecdes >= desde And d.Dgfecdes <= hasta
                            Order By c.Dgnumdes Descending Select c).ToList()
                Return lote
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function buscarDescarguesPorNumero(numdes As Integer) As Descargues Implements IDaoDescargues.buscarDescarguesPorNumero
        Using ctx As New Contexto
            Try
                Dim buscar = (From d As Descargues In ctx.Descargues
                              Where d.Dgnumdes = numdes
                              Select d).FirstOrDefault()
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function buscarGeneralDescarguePorCompra(numdes As Integer) As List(Of GeneralDescarguePorCompra) Implements IDaoDescargues.buscarGeneralDescarguePorCompra
        Using ctx As New Contexto
            Try
                Dim buscar = ctx.ExecuteQuery(Of GeneralDescarguePorCompra)("SELECT d.dgnumdes,cli.codcliente as numcliente, d.dgfecdes, c.numcompra, c.fecha, cli.nombres, " &
               "cli.apellidos, c.peso, c.total, d.dgcancom As Cantcompra " &
               "FROM dbo.descargues AS d INNER JOIN " &
               "compras As c On d.dgnumdes = c.dgnumdes " &
               "INNER JOIN Cliente As cli On c.codcliente = cli.codcliente " &
               "where d.dgnumdes = " & numdes & " order by c.numcompra asc")
                Return buscar.ToList()
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function buscarDetalleDescarguePorCompra(numdes As Integer) As List(Of DetalleDescarguePorCompra) Implements IDaoDescargues.buscarDetalleDescarguePorCompra
        Using ctx As New Contexto
            Try
                Dim buscar = ctx.ExecuteQuery(Of DetalleDescarguePorCompra)(" SELECT d.dgnumdes,cli.codcliente as numcliente, d.dgfecdes, c.numcompra, c.fecha, c.codcliente, cli.nombres, " & _
                "cli.apellidos, c.peso, c.total, d.dgcancom As Cantcompra, dc.kilshowdoc, dc.peso As detaPeso, dc.importe " &
                "FROM dbo.descargues AS d INNER JOIN " &
                "dbo.compras As c On d.dgnumdes = c.dgnumdes " &
                "join det_compra as dc on c.numcompra = dc.numcompra " &
                "INNER JOIN Cliente As cli On c.codcliente = cli.codcliente " &
                "where d.dgnumdes = " & numdes & " order by numcompra asc")
                Return buscar.ToList()
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function reporteSaldoCompraDescargues(fecha As Date) As List(Of SaldoCompra) Implements IDaoDescargues.reporteSaldoCompraDescargues
        Using ctx As New Contexto
            Try
                Dim buscar = ctx.ExecuteQuery(Of SaldoCompra)(String.Format("select sum(c.peso) as pesoc, sum(c.total) as valorc, " &
                        "SUM(d.dgpesntt) as pesod, sum(d.dgimptcom) as valord, " &
                        "sum(d.dgpesntt - c.peso) as pesos, SUM(d.dgimptcom - c.total) as valors " &
                        "from compras c  join descargues d on c.dgnumdes = d.dgnumdes where Year(d.dgfecgen) = {0} " &
                        "group by MONTH(d.dgfecgen)", fecha.Year))
                Return buscar.ToList
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
End Class

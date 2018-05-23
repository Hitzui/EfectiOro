Imports EfectiOro.Database
Imports System.Data.SqlClient
Imports System.Reflection

Public Class DaoCliente
    Implements IDaoCliente

    Private contexto As New EfectiOro.Database.Contexto()
    Public Function DataReaderMapToList(Of T)(ByVal dr As IDataReader) As List(Of T)
        Dim list As New List(Of T)
        Dim obj As T
        While dr.Read()
            obj = Activator.CreateInstance(Of T)()
            For Each prop As PropertyInfo In obj.GetType().GetProperties()
                If Not Object.Equals(dr(prop.Name), DBNull.Value) Then
                    prop.SetValue(obj, dr(prop.Name), Nothing)
                End If
            Next
            list.Add(obj)
        End While
        Return list
    End Function
    Public Function existeCliente(codcliente As String) As Boolean Implements IDaoCliente.existeCliente
        Try
            Dim cli = Me.findById(codcliente)
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function

    Public Function findByCedula(cedula As String) As Cliente Implements IDaoCliente.findByCedula
        Using ctx As New Contexto
            Try
                Dim buscar = (From cli In ctx.Cliente Where cli.Numcedula = cedula Select cli).First()
                Return buscar
            Catch ex As Exception
                ErrorSms = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function codCliente() As String Implements IDaoCliente.codCliente
        Try
            Dim config As New ConfiguracionGeneral()
            Dim caja As String = config.getCaja()
            Dim agencia As String = config.getAgencia()
            Dim valor = contexto.ExecuteQuery(Of Ids)("select * from ids").First()
            Dim codigo As Integer = valor.codcliente + 1
            Return caja & Convert.ToString(codigo).PadLeft(10, "0")
        Catch ex As Exception
            Return ErrorSms = ex.Message
        End Try
    End Function

    Public Function create(cliente As EfectiOro.Database.Cliente) As Boolean Implements IDaoCliente.create
        Try
            contexto.Cliente.InsertOnSubmit(cliente)
            contexto.ExecuteQuery(Of Integer)("update ids set codcliente = codcliente +1")
            contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function

    Public Function delete(cliente As EfectiOro.Database.Cliente) As Boolean Implements IDaoCliente.delete
        Try
            Dim cli = Me.findById(cliente.Codcliente)
            contexto.Cliente.DeleteOnSubmit(cli)
            contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function

    Public Property ErrorSms As String Implements IDaoCliente.ErrorSms

    Public Function findAll() As List(Of Cliente) Implements IDaoCliente.findAll
        Try
            Dim buscar = contexto.ExecuteQuery(Of Cliente)("select * from Cliente order by nombres asc").ToList()
            Return buscar
        Catch ex As Exception
            ErrorSms = ex.Message
            Return Nothing
        End Try
        'Return contexto.Cliente.ToList()
    End Function

    Public Function findByApellido(ByVal apellido As String) As Cliente Implements IDaoCliente.findByApellido
        Try
            Dim cli = (From c In contexto.Cliente Where c.Apellidos = apellido
                       Select c).First()
            Return cli
        Catch ex As Exception
            ErrorSms = "No existe el cliente con el apellido especificado, intente nuevamente"
            Return Nothing
        End Try
    End Function

    Public Function findById(codcliente As String) As Cliente Implements IDaoCliente.findById
        Try
            Dim cli = (From c In contexto.Cliente Where c.Codcliente = codcliente
                       Select c).First()
            Return cli
        Catch ex As Exception
            ErrorSms = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function findByNombre(nombre As String) As Cliente Implements IDaoCliente.findByNombre
        Try
            Dim cli = (From c In contexto.Cliente Where c.Nombres = nombre
                       Select c).First()
            Return cli
        Catch ex As Exception
            ErrorSms = "No existe el cliente con el nombre especificado, intente nuevamente"
            Return Nothing
        End Try
    End Function

    Public Function update(cliente As Cliente) As Boolean Implements IDaoCliente.update
        Try
            Dim cliX = Me.findById(cliente.Codcliente)
            cliX.Nombres = cliente.Nombres
            cliX.Apellidos = cliente.Apellidos
            cliX.Direccion = cliente.Direccion
            cliX.Actua_por = cliente.Actua_por
            cliX.Celular = cliente.Celular
            cliX.Ciudad = cliente.Ciudad
            cliX.Desc_otra = cliente.Desc_otra
            cliX.Direccion_negocio = cliente.Direccion_negocio
            cliX.Direccion_tercero = cliente.Direccion_tercero
            cliX.Email = cliente.Email
            cliX.Estadocivil = cliente.Estadocivil
            cliX.F_emision = cliente.F_emision
            cliX.F_ingreso = cliente.F_ingreso
            cliX.F_nacimiento = cliente.F_nacimiento
            cliX.F_vencimiento = cliente.F_vencimiento
            cliX.Monto_mensual = cliente.Monto_mensual
            cliX.Nombre_tercero = cliente.Nombre_tercero
            cliX.Nom_banco = cliente.Nom_banco
            cliX.Nom_cuenta = cliente.Nom_cuenta
            cliX.Numcedula = cliente.Numcedula
            cliX.Ocupacion = cliente.Ocupacion
            cliX.Num_cuenta = cliente.Num_cuenta
            cliX.Otra_ae = cliX.Otra_ae
            cliX.Tiempo_neg = cliente.Tiempo_neg
            cliX.Telefono = cliente.Telefono
            cliX.Total_operaciones = cliente.Total_operaciones
            cliX.Pica = cliente.Pica
            contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function
    Public Function filtrarPorNombre(ByVal nombre As String) As List(Of Cliente) Implements IDaoCliente.filtrarPorNombre
        Try
            Dim var = (From c In contexto.Cliente
                       Where System.Data.Linq.SqlClient.SqlMethods.Like(c.Nombres, "%" & nombre & "%")
                       Order By c.Nombres Ascending
                       Order By c.Nombres Ascending
                       Select c).ToList()
            Return var
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function filtrarPorCodigo(ByVal codigo As String) As List(Of Cliente) Implements IDaoCliente.filtrarPorCodigo
        Try
            Dim var = (From c In contexto.Cliente
                       Where System.Data.Linq.SqlClient.SqlMethods.Like(c.Codcliente, "%" & codigo & "%")
                       Order By c.Nombres Ascending
                       Select c).ToList()
            Return var
        Catch ex As Exception
            ErrorSms = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function filtrarPorApelldio(ByVal apellido As String) As List(Of Cliente) Implements IDaoCliente.filtrarPorApellido
        Try
            Dim var = (From c In contexto.Cliente
                       Where System.Data.Linq.SqlClient.SqlMethods.Like(c.Apellidos, "%" & apellido & "%")
                       Order By c.Nombres Ascending
                       Select c).ToList()
            Return var
        Catch ex As Exception
            ErrorSms = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function recuperarPorNombre(ByVal nombre As String) As List(Of Cliente) Implements IDaoCliente.recuperarPorNombre
        Using cnn As New SqlConnection(contexto.conectar)
            Try
                Dim query As String = "select * from Cliente where nombres like '%" & nombre & "%' order by nombres asc"
                Dim cmd As New SqlCommand(query, cnn)
                cnn.Open()
                Dim dr As IDataReader = cmd.ExecuteReader
                Dim list = Me.DataReaderMapToList(Of Cliente)(dr)
                dr.Close()
                Return list
            Catch ex As Exception
                ErrorSms = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
    Public Function recuperarTodosClientes() As List(Of Cliente) Implements IDaoCliente.recuperarTodosClientes
        Using cnn As New SqlConnection(contexto.conectar)
            Try
                Dim query As String = "select * from Cliente order by nombres asc"
                cnn.Open()
                Dim ad As New SqlDataAdapter(query, cnn)
                Dim dr As SqlDataReader = ad.SelectCommand.ExecuteReader
                Dim list = Me.DataReaderMapToList(Of Cliente)(dr)
                dr.Close()
                Return list
            Catch ex As Exception
                ErrorSms = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function findAllClientesDS() As DataTable Implements IDaoCliente.findAllClientesDS
        Using cnn As New SqlConnection(Contexto.conectar)
            Try
                Dim query As String = "select * from Cliente order by nombres asc"
                cnn.Open()
                Dim ad As New SqlDataAdapter(query, cnn)
                Dim dr As SqlDataReader = ad.SelectCommand.ExecuteReader
                dr.Close()
                Dim ds = New DataSet
                ad.Fill(ds)
                Return ds.Tables(0)
            Catch ex As Exception
                ErrorSms = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
End Class

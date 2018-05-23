Imports EfectiOro.Database


Public Class DaoUsuario
    Implements IDaoUsuario

    Private _error As String

    Public Function actualizarDatosUsuario(usuario As Database.Usuario) As Boolean Implements IDaoUsuario.actualizarDatosUsuario
        Using ctx As New Contexto
            Try
                Dim buscar = (From u In ctx.Usuario Where u.Codoperador = usuario.Codoperador Select u).First
                buscar.Nombre = usuario.Nombre
                buscar.Clave = usuario.Clave
                buscar.Estado = usuario.Estado
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function crearUsuario(usuario As Database.Usuario) As Boolean Implements IDaoUsuario.crearUsuario
        Using ctx As New Contexto
            Try
                ctx.Usuario.InsertOnSubmit(usuario)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public Function eliminarUsuario(usuario As Database.Usuario) As Boolean Implements IDaoUsuario.eliminarUsuario
        Using ctx As New Contexto
            Try
                Dim buscar = (From u In ctx.Usuario Where u.Codoperador = usuario.Codoperador Select u).First
                ctx.Usuario.DeleteOnSubmit(buscar)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                _error = ex.Message
                Return False
            End Try
        End Using
    End Function

    Public ReadOnly Property ErrorSms As String Implements IDaoUsuario.ErrorSms
        Get
            Return _error
        End Get
    End Property

    Public Function findAll() As System.Collections.Generic.List(Of Database.Usuario) Implements IDaoUsuario.findAll
        Using ctx As New Contexto
            Return ctx.Usuario.ToList()
        End Using
    End Function

    Public Function findByCodigo(codigo As String) As Database.Usuario Implements IDaoUsuario.findByCodigo
        Using ctx As New Contexto
            Try
                Dim buscar = (From u As Usuario In ctx.Usuario Where u.Codoperador = codigo Select u).First
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function

    Public Function findByUsuario(nomusuario As String) As Database.Usuario Implements IDaoUsuario.findByUsuario
        Using ctx As New Contexto
            Try
                Dim buscar = (From u As Usuario In ctx.Usuario Where u.Usuario1 = nomusuario Select u).First
                Return buscar
            Catch ex As Exception
                _error = ex.Message
                Return Nothing
            End Try
        End Using
    End Function
End Class

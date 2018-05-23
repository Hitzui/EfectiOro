Public Interface IDaoUsuario
    Function actualizarDatosUsuario(usuario As Database.Usuario) As Boolean
    Function crearUsuario(usuario As Database.Usuario) As Boolean
    Function eliminarUsuario(usuario As Database.Usuario) As Boolean
    ReadOnly Property ErrorSms As String
    Function findAll() As System.Collections.Generic.List(Of Database.Usuario)
    Function findByCodigo(codigo As String) As Database.Usuario
    Function findByUsuario(nomusuario As String) As Database.Usuario
End Interface

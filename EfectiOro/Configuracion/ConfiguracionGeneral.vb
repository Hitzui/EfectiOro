Imports System.IO
Imports System.Xml

Public Class ConfiguracionGeneral

    Public Sub New()
        If Me.existeArchivo = False Then
            Me.crearArchivo()
            frmParametrosConexion.ShowDialog()
        End If
        Me.cargarDocumento()
    End Sub

    Dim ruta As String = "c:\config\opcion.xml"
    Dim xdoc As XDocument
    Public Function cargarDocumento() As XDocument
        Try
            'crearArchivo()
            xdoc = XDocument.Load(ruta)
        Catch ex As Exception
        End Try
        Return xdoc
    End Function
    Public Function existeArchivo() As Boolean
        Return File.Exists(ruta)
    End Function
    Private Function existeCarpet() As Boolean
        Return Directory.Exists("c:\config")
    End Function
    Public Function crearArchivo() As Boolean
        If existeCarpet() = False Then
            Directory.CreateDirectory("c:\config")
        End If
        If existeArchivo() = False Then
            'File.CreateText(ruta)
            Dim config As XDocument =
            <?xml version="1.0"?>
            <Configuracion>
                <Caja>C01</Caja>
                <Agencia>A001</Agencia>
                <Instancia>server</Instancia>
                <Catalogo>EfectiOro</Catalogo>
                <Usuario>sa</Usuario>
                <Password>reyes</Password>
                <Security>False</Security>
            </Configuracion>
            config.Save(ruta)
            Return True
        End If
        Return False
    End Function
#Region "Archivo XML de configuracion"
    Public Function getAgencia() As String
        Dim val = (From x In xdoc...<Agencia> Select x).Single().Value
        Return val
    End Function
    Public Sub setAgencia(ByVal valor As String)
        For Each xval In From elemento In xdoc.<Configuracion>
            xval.<Agencia>.Value = valor
            xval.Save(ruta)
        Next
    End Sub
    Public Function getCaja() As String
        Dim val = (From x In xdoc...<Caja> Select x).Single().Value
        Return val
    End Function
    Public Sub setCaja(ByVal valor As String)
        For Each xval In From elemento In xdoc.<Configuracion>
            xval.<Caja>.Value = valor
            xval.Save(ruta)
        Next
    End Sub
    Public Function getInstancia() As String
        Dim val = (From x In xdoc...<Instancia> Select x).Single().Value
        Return val
    End Function
    Public Sub setInstancia(ByVal valor As String)
        For Each xval In From elemento In xdoc.<Configuracion>
            xval.<Instancia>.Value = valor
            xval.Save(ruta)
        Next
    End Sub
    Public Function getCatalogo() As String
        Dim val = (From x In xdoc...<Catalogo> Select x).Single().Value
        Return val
    End Function
    Public Sub setCatalogo(ByVal valor As String)
        For Each xval In From elemento In xdoc.<Configuracion>
            xval.<Catalogo>.Value = valor
            xval.Save(ruta)
        Next
    End Sub
    Public Function getUsuario() As String
        Dim val = (From x In xdoc...<Usuario> Select x).Single().Value
        Return val
    End Function
    Public Sub setUsuario(ByVal valor As String)
        For Each xval In From elemento In xdoc.<Configuracion>
            xval.<Usuario>.Value = valor
            xval.Save(ruta)
        Next
    End Sub
    Public Function getPassword() As String
        Dim val = (From x In xdoc...<Password> Select x).Single().Value
        Return val
    End Function
    Public Sub setPassword(ByVal valor As String)
        For Each xval In From elemento In xdoc.<Configuracion>
            xval.<Password>.Value = valor
            xval.Save(ruta)
        Next
    End Sub
    Public Function getSecurity() As String
        Dim val = (From x In xdoc...<Security> Select x).Single().Value
        Return val
    End Function
    Public Sub setSecurity(ByVal valor As String)
        For Each xval In From elemento In xdoc.<Configuracion>
            xval.<Security>.Value = valor
            xval.Save(ruta)
        Next
    End Sub
#End Region

End Class

Imports EfectiOro.Database
Imports System.Reflection

Public Class Submain

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic)
        Dim configuracion As New ConfiguracionGeneral()
        If configuracion.existeArchivo() = False Then
            frmParametrosConexion.ShowDialog()
        End If
        'Application.Run(New Form1)
        'Dim db As New Contexto
        'db.CreateDatabase()
        'Dim dao = DataContext.daoCliente
        Dim login As New frmLogin
        'MsgBox("Longitud del texto: " & dao.codCliente().Length)
        login.ShowDialog()
        If login.DialogResult = DialogResult.OK Then

            If frmPrincipal.Created Then
                Return
            End If
            Try
                Dim frm As New frmPrincipal()
                Application.Run(frm)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Application.Run(New frmPagoCompra)
    End Sub
End Class

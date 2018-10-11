Imports System.Data.SqlClient
Imports EfectiOro.Database


Public Class frmBackupBaseDatos

    Private config As New ConfiguracionGeneral

    Private Property RutaArchivoBackup As String
    Private Property RutaArchivoRestaurar As String
    Private Property directorioRestaurar As String

    Private Sub btnRuta_Click(sender As System.Object, e As System.EventArgs) Handles btnRuta.Click
        Try
            SaveFileDialog1.Filter = "Archivo bak|*.bak"
            Me.SaveFileDialog1.DefaultExt = "bak"
            Me.SaveFileDialog1.AddExtension = True
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName <> String.Empty Then
                Me.RutaArchivoBackup = SaveFileDialog1.FileName
                Me.lblRutaRespaldo.Text = Me.RutaArchivoBackup
            End If
        Catch ex As Exception
            MsgBox("Hubo un problema al intentar recuperar la ruta seleccionada, siga las instrucciones para ver el error." & _
                   vbCr & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UltraButton1_Click(sender As System.Object, e As System.EventArgs) Handles UltraButton1.Click
        Using ctx As New Contexto
            Dim nombreBaseDatos As String = Me.config.getCatalogo()
            If Me.RutaArchivoBackup Is Nothing Then
                MsgBox("Especifique la ruta para guardar el archivo de respaldo de la base de datos.", MsgBoxStyle.Information, "Respaldar base de datos")
                Return
            End If
            Try
                'USE AdventureWorks2012;
                'GO
                'BACKUP DATABASE AdventureWorks2012
                'TO DISK = 'Z:\SQLServerBackups\AdventureWorks2012.Bak'
                'WITH FORMAT,
                'MEDIANAME = 'Z_SQLServerBackups',
                'NAME = 'Full Backup of AdventureWorks2012';
                'GO
                ctx.ExecuteQuery(Of Integer)("use " & nombreBaseDatos & "; backup database EfectiOro " & _
                                             "to disk='" & Me.RutaArchivoBackup & "' with format, " & _
                                             "medianame = 'Z_EfectiOroBackups', name='Full Backup of Efectioro';" & _
                                             "backup database " & nombreBaseDatos & " to disk='" & Me.RutaArchivoBackup & "' WITH DIFFERENTIAL;")
                MsgBox("Se ha realizado la copia de seguridad de forma correcta", MsgBoxStyle.Information, "Backup de la Base de datos")
                Dim param = (From p In ctx.Ids Where p.Backup.Date < Now.Date Select p).First
                param.Backup = Now
            Catch ex As Exception
                MsgBox("Se produjo un error al intentar crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    Private Sub UltraButton2_Click(sender As System.Object, e As System.EventArgs) Handles UltraButton2.Click
        Using ctx As New Contexto
            Try
                Dim nombreBaseDatos As String = Me.config.getCatalogo()
                Dim ahora As String = Now.ToShortDateString()
                Dim restaurar As String = "USE [master] ALTER DATABASE " & nombreBaseDatos & " SET RECOVERY SIMPLE; " & _
                                            "RESTORE DATABASE [" & nombreBaseDatos & "] " & _
                                            "FROM  DISK = N'" & Me.RutaArchivoRestaurar & "' " & _
                                            "WITH  FILE = 1,  NORECOVERY" & _
                                            "RESTORE DATABASE EfectiOro  " & _
                                            "FROM DISK = '" & Me.RutaArchivoBackup & "' " & _
                                            "WITH FILE=2, RECOVERY; " & _
                                            "ctx.ExecuteQuery(Of Integer)(restaurar)"
                MsgBox("Se ha restaurado la base de datos de forma correcta", MsgBoxStyle.Information, "Restaurar base de datos")
            Catch ex As Exception
                MsgBox("Error al intentar restaurar la base de datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    Private Sub UltraButton3_Click(sender As System.Object, e As System.EventArgs) Handles UltraButton3.Click
        Try
            OpenFileDialog1.Filter = "Archivo bak|*.bak"
            OpenFileDialog1.Title = "Restaurar base de datos"
            OpenFileDialog1.AddExtension = True
            Me.OpenFileDialog1.DefaultExt = "bak"
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.lblRutaRestaurar.Text = OpenFileDialog1.FileName
                Me.RutaArchivoRestaurar = Me.OpenFileDialog1.FileName
                Me.directorioRestaurar = IO.Path.GetDirectoryName(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBackupBaseDatos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblRutaRestaurar.Text = ""
        Me.lblRutaRespaldo.Text = ""
    End Sub
End Class
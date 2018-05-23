Imports EfectiOro.Database

Public Class DaoPica
    Implements IDaoPica

    Dim contexto As New Efectioro.Database.Contexto()

    Public Function create(pica As Pica) As Boolean Implements IDaoPica.create
        Try
            contexto.Pica.InsertOnSubmit(pica)
            contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function

    Public Function delete(pica As Pica) As Boolean Implements IDaoPica.delete
        Try
            contexto.Pica.DeleteOnSubmit(pica)
            contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function

    Public Property ErrorSms As String Implements IDaoPica.ErrorSms

    Public Function findById(codcliente As String) As List(Of Pica) Implements IDaoPica.findById
        Try
            Dim picas = (From p In contexto.Pica Where p.Codcliente = codcliente
                    Select p).ToList()
            Return picas
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Function deleteByCodCliente(ByVal codcliente As String) As Boolean Implements IDaoPica.deleteByCodCliente
        Try
            Dim v = contexto.ExecuteQuery(Of Integer)(String.Format("delete from Pica where codcliente = '{0}'", codcliente))
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function
    Public Function update(pica As List(Of Pica)) As Boolean Implements IDaoPica.update
        Try
            For Each pic In pica
                contexto.Pica.InsertOnSubmit(pic)
            Next
            contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            ErrorSms = ex.Message
            Return False
        End Try
    End Function
End Class

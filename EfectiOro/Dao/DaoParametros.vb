Imports EfectiOro.Database

Public Class DaoParametros
    Implements IDaoParametros

    Public Function habilitarVariasCompras(opcion As Integer) As Boolean Implements IDaoParametros.habilitarVariasCompras
        Using ctx As New Contexto
            Try
                If opcion > 1 And opcion < 0 Then
                    MsgBox("No puede habilitar esta opción con el parametro indicado, tiene que ser 1 = True; 0 = False", _
                           MsgBoxStyle.Critical, "Error")
                    Return False
                End If
                ctx.ExecuteCommand("update ids set varias_compras = " & opcion)
                Return True
            Catch ex As Exception
                MsgBox("Error al habilitar la compra: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Function recuperarParametros() As Database.Ids Implements IDaoParametros.recuperarParametros
        Using ctx As New Contexto
            Return ctx.Ids.First()
        End Using
    End Function
    Public Function crearParametros(parametros As Ids) As Boolean Implements IDaoParametros.crearParametros
        Using ctx As New Contexto
            Try
                ctx.Ids.InsertOnSubmit(parametros)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                MsgBox("No se pudo ingresar los parametros debido al siguiente error: " & vbCr & _
                       ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Using
    End Function
    Public Function actualizarParametros(param As Ids) As Boolean Implements IDaoParametros.actualizarParametros
        Using ctx As New Contexto
            Try
                Dim find = (From i In ctx.Ids Where i.codcliente > 0 Select i).First()
                ctx.Ids.DeleteOnSubmit(find)
                ctx.Ids.InsertOnSubmit(param)
                ctx.SubmitChanges()
                Return True
            Catch ex As Exception
                MsgBox("Se produjo el siguiente error: " & vbCr & ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Using
    End Function
End Class

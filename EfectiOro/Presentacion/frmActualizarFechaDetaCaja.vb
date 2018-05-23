Imports EfectiOro.Database

Public Class frmActualizarFechaDetaCaja
    Dim config As ConfiguracionGeneral
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        config = New ConfiguracionGeneral
    End Sub
    Sub recargarCaja()
        config = New ConfiguracionGeneral
    End Sub
    Sub llenarGrid()
        Dim dao = DataContext.daoMcaja
        DetacajaBindingSource.DataSource = dao.listarDetaCaja(config.getCaja())
    End Sub
    Private Sub frmActualizarFechaDetaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.recargarCaja()
        Me.llenarGrid()
        ServiciosBasicos.colorearGrid(dgvDetacaja)
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        If DataContext.usuarioLog.Nivel <> 1 Then
            MsgBox("No cuenta con los privilegios para realizar la acción.")
            Return
        End If
        Using ctx As New Contexto
            Try
                Dim lista = (From dc In ctx.Detacaja
                             Where dc.codcaja = config.getCaja
                            Select dc).ToList()
                Dim fechaHora As New List(Of String)
                For Each dato As Detacaja In lista
                    Dim convertir As Date = Convert.ToDateTime(dato.fecha & " " & dato.hora)
                    dato.fecha = convertir
                    ctx.SubmitChanges()
                Next
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Information, "Error")
            End Try
        End Using
    End Sub

    Private Sub UltraButton2_Click(sender As Object, e As EventArgs) Handles UltraButton2.Click
        Me.recargarCaja()
        Me.llenarGrid()
    End Sub
End Class
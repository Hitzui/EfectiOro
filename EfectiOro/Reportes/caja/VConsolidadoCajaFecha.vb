<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.vconsolidadocajafecha")>
Partial Public Class vconsolidadocajafecha

    Private _idcaja As Decimal

    Private _codrubro As System.Nullable(Of Integer)

    Private _descrubro As String

    Private _idmov As Integer

    Private _descripcion As String

    Private _fecha As Date

    Private _efectivo As Decimal

    Private _transferencias As Decimal

    Private _cheque As Decimal

    Private _codcaja As String

    Public Sub New()
        MyBase.New
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idcaja", DbType:="Decimal(18,0) NOT NULL")>
    Public Property idcaja() As Decimal
        Get
            Return Me._idcaja
        End Get
        Set
            If ((Me._idcaja = Value) _
                        = False) Then
                Me._idcaja = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_codrubro", DbType:="Int")>
    Public Property codrubro() As System.Nullable(Of Integer)
        Get
            Return Me._codrubro
        End Get
        Set
            If (Me._codrubro.Equals(Value) = False) Then
                Me._codrubro = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_descrubro", DbType:="VarChar(250) NOT NULL", CanBeNull:=False)>
    Public Property descrubro() As String
        Get
            Return Me._descrubro
        End Get
        Set
            If (String.Equals(Me._descrubro, Value) = False) Then
                Me._descrubro = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idmov", DbType:="Int NOT NULL")>
    Public Property idmov() As Integer
        Get
            Return Me._idmov
        End Get
        Set
            If ((Me._idmov = Value) _
                        = False) Then
                Me._idmov = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_descripcion", DbType:="VarChar(250) NOT NULL", CanBeNull:=False)>
    Public Property descripcion() As String
        Get
            Return Me._descripcion
        End Get
        Set
            If (String.Equals(Me._descripcion, Value) = False) Then
                Me._descripcion = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fecha", DbType:="DateTime")>
    Public Property fecha() As Date
        Get
            Return Me._fecha
        End Get
        Set
            If (Me._fecha.Equals(Value) = False) Then
                Me._fecha = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_efectivo", DbType:="Decimal(38,2)")>
    Public Property efectivo() As Decimal
        Get
            Return Me._efectivo
        End Get
        Set
            If (Me._efectivo.Equals(Value) = False) Then
                Me._efectivo = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_transferencias", DbType:="Decimal(38,2)")>
    Public Property transferencias() As Decimal
        Get
            Return Me._transferencias
        End Get
        Set
            If (Me._transferencias.Equals(Value) = False) Then
                Me._transferencias = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cheque", DbType:="Decimal(38,2)")>
    Public Property cheque() As Decimal
        Get
            Return Me._cheque
        End Get
        Set
            If (Me._cheque.Equals(Value) = False) Then
                Me._cheque = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_codcaja", DbType:="VarChar(10)")>
    Public Property codcaja() As String
        Get
            Return Me._codcaja
        End Get
        Set
            If (String.Equals(Me._codcaja, Value) = False) Then
                Me._codcaja = Value
            End If
        End Set
    End Property
End Class

Partial Public Class ConsolidadoCajaFechaResult

    Private _codrubro As Integer

    Private _descrubro As String

    Private _idmov As Integer

    Private _descripcion As String

    Private _efectivo As Decimal

    Private _cheque As Decimal

    Private _transferencias As Decimal

    Private _codcaja As String
    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_codcaja", DbType:="VarChar(10)")>
    Public Property codcaja() As String
        Get
            Return Me._codcaja
        End Get
        Set
            If (String.Equals(Me._codcaja, Value) = False) Then
                Me._codcaja = Value
            End If
        End Set
    End Property

    Public Sub New()
        MyBase.New
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_codrubro", DbType:="Int NOT NULL")>
    Public Property codrubro() As Integer
        Get
            Return Me._codrubro
        End Get
        Set
            If ((Me._codrubro = Value) _
                        = False) Then
                Me._codrubro = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_descrubro", DbType:="VarChar(250) NOT NULL", CanBeNull:=False)>
    Public Property descrubro() As String
        Get
            Return Me._descrubro
        End Get
        Set
            If (String.Equals(Me._descrubro, Value) = False) Then
                Me._descrubro = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idmov", DbType:="Int NOT NULL")>
    Public Property idmov() As Integer
        Get
            Return Me._idmov
        End Get
        Set
            If ((Me._idmov = Value) _
                        = False) Then
                Me._idmov = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_descripcion", DbType:="VarChar(250) NOT NULL", CanBeNull:=False)>
    Public Property descripcion() As String
        Get
            Return Me._descripcion
        End Get
        Set
            If (String.Equals(Me._descripcion, Value) = False) Then
                Me._descripcion = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_efectivo", DbType:="Decimal(38,2)")>
    Public Property efectivo() As Decimal
        Get
            Return Me._efectivo
        End Get
        Set
            If (Me._efectivo.Equals(Value) = False) Then
                Me._efectivo = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cheque", DbType:="Decimal(38,2)")>
    Public Property cheque() As Decimal
        Get
            Return Me._cheque
        End Get
        Set
            If (Me._cheque.Equals(Value) = False) Then
                Me._cheque = Value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_transferencias", DbType:="Decimal(38,2)")>
    Public Property transferencias() As Decimal
        Get
            Return Me._transferencias
        End Get
        Set
            If (Me._transferencias.Equals(Value) = False) Then
                Me._transferencias = Value
            End If
        End Set
    End Property
End Class


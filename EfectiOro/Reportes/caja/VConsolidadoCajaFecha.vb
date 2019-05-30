Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection

<Table(Name:="vconsolidadocajafecha")>
Public Class VConsolidadoCajaFecha

    Private _idcaja As Integer
    <Column(Name:="idcaja", Storage:="_idcaja", DbType:="Int")>
    Public Property Idcaja() As Integer
        Get
            Return _idcaja
        End Get
        Set(ByVal value As Integer)
            _idcaja = value
        End Set
    End Property
    Private _codrubro As Integer
    <Column(Name:="codrubro", Storage:="_codrubro", DbType:="Int")>
    Public Property Codrubro() As Integer
        Get
            Return _codrubro
        End Get
        Set(ByVal value As Integer)
            _codrubro = value
        End Set
    End Property
    Private _idmov As Integer
    <Column(Name:="idmov", Storage:="_idmov", DbType:="Int")>
    Public Property Idmov() As Integer
        Get
            Return _idmov
        End Get
        Set(ByVal value As Integer)
            _idmov = value
        End Set
    End Property
    Private _descripcion As String
    <Column(Name:="descripcion", Storage:="_descripcion", DbType:="varchar(250)")>
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Private _fecha As Date
    <Column(Name:="fecha", Storage:="_fecha", DbType:="datetime")>
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Private _efectivo As Decimal
    <Column(Name:="efectivo", Storage:="_efectivo", DbType:="numeric(38,2")>
    Public Property Efectivo() As Decimal
        Get
            Return _efectivo
        End Get
        Set(ByVal value As Decimal)
            _efectivo = value
        End Set
    End Property
    Private _transferencia As Decimal
    <Column(Name:="transferencia", Storage:="_transferencia", DbType:="numeric(38,2")>
    Public Property Transferencia() As Decimal
        Get
            Return _transferencia
        End Get
        Set(ByVal value As Decimal)
            _transferencia = value
        End Set
    End Property
    Private _cheque As Decimal
    <Column(Name:="cheque", Storage:="_cheque", DbType:="numeric(38,2")>
    Public Property Cheque() As Decimal
        Get
            Return _cheque
        End Get
        Set(ByVal value As Decimal)
            _cheque = value
        End Set
    End Property
    Private _codcaja As String
    <Column(Name:="codcaja", Storage:="_codcaja", DbType:="varchar(10)")>
    Public Property Codcaja() As String
        Get
            Return _codcaja
        End Get
        Set(ByVal value As String)
            _codcaja = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class

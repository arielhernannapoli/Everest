Imports System.Collections.Generic

Public Class Padron_AGIP
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Padron As Integer
    Dim mFecha As DateTime
    Dim mDescripcion As String
    Dim mDetalle_AGIP As List(Of Detalle_AGIP)

    Public Property Id_Padron() As Integer
        Get
            Return mId_Padron
        End Get
        Set(ByVal Value As Integer)
            mId_Padron = Value
        End Set
    End Property

    Public Property Fecha() As DateTime
        Get
            Return mFecha
        End Get
        Set(ByVal Value As DateTime)
            mFecha = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property

    Public Property Detalle_AGIP() As List(Of Detalle_AGIP)
        Get
            If mDetalle_AGIP Is Nothing Then
                mDetalle_AGIP = New List(Of Detalle_AGIP)
            End If
            Return mDetalle_AGIP
        End Get
        Set(ByVal Value As List(Of Detalle_AGIP))
            mDetalle_AGIP = Value
        End Set
    End Property
#End Region

    Sub New()
        MyBase.New("Padrones_AGIP")
    End Sub

    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
        Me.Id_Padron = IIf(IsDBNull(dr("Id_Padron")), 0, dr("Id_Padron"))
        Me.Fecha = IIf(IsDBNull(dr("Fecha")), 0, dr("Fecha"))
        Me.Descripcion = IIf(IsDBNull(dr("Descripcion")), 0, dr("Descripcion"))
    End Sub

    Public Overloads Function Agregar(ByVal p_fecha As DateTime, ByVal p_descripcion As String, _
    ByVal p_detalle_AGIP As List(Of Detalle_AGIP)) As Object
        Dim id_Padron As Integer
        Try
            MyBase.IniciarTransaccion()
            id_Padron = MyBase.Agregar(p_fecha, p_descripcion)
            For Each detalle As Detalle_AGIP In p_detalle_AGIP
                detalle.Agregar(id_Padron, detalle.CUIT, detalle.RazonSocial, detalle.CodigoAGIP, detalle.Clase, detalle.Tipo, detalle.Caracteristica, detalle.Sup, detalle.Zona, detalle.Direccion, detalle.Altura)
            Next
            MyBase.TerminarTransaccion()
        Catch ex As Exception
            MyBase.AbortarTransaccion()
            id_Padron = 0
        End Try
        Return id_Padron
    End Function

    Public Function Borrar(ByVal p_id_padron As Integer) As Object
        Return MyBase.Borrar(p_id_padron)
    End Function

    Public Function ValidarPadron(ByVal p_fecha As DateTime) As Object
        Return Me.Ejecutar("SPK_PADRONES_AGIP.SP_EXISTE", p_fecha)
    End Function

    Public Function ObtenerUltimo() As DataTable
        Return Me.TraerDataSet("SPK_PADRONES_AGIP.SP_SELECT_ULTIMO").Tables(0)
    End Function

    'LC 05/08/2014 Excepciones AGIP en BD 
    Public Function ObtenerExcepciones() As DataTable
        Return Me.TraerDataSet("SPK_DETALLES_AGIP.SP_SELECT_EXCEPCIONES").Tables(0)
    End Function

End Class

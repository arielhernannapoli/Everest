Imports MSL
Imports Framework

Public Class Colocaciones

    Dim oDatosMaestros As Maestros

#Region "Propiedades"
    Dim mId_Medio As Integer
    Dim mId_Colocacion As Integer
    Dim mDesc_Colocacion As String

    Public Property Id_Medio() As Integer
        Get
            Return mId_Medio
        End Get
        Set(ByVal Value As Integer)
            mId_Medio = Value
        End Set
    End Property

    Public Property Id_Colocacion() As Integer
        Get
            Return mId_Colocacion
        End Get
        Set(ByVal Value As Integer)
            mId_Colocacion = Value
        End Set
    End Property

    Public Property Desc_Colocacion() As String
        Get
            Return mDesc_Colocacion
        End Get
        Set(ByVal Value As String)
            mDesc_Colocacion = Value
        End Set
    End Property

#End Region

#Region "Funciones Propias"

#End Region

#Region "Funciones de MSL"

    Public Function ObtenerColocaciones() As DataTable

        Dim DtResultado As DataTable
        oDatosMaestros = New Maestros

        If Activo.DTColocacionesCache Is Nothing Then
            Activo.DTColocacionesCache = oDatosMaestros.ObtenerColocaciones(Me.Id_Medio)
        End If

        'DtResultado = oDatosMaestros.ObtenerColocaciones(Me.Id_Medio)

        Return Activo.DTColocacionesCache

    End Function

#End Region

End Class

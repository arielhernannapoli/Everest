Imports MSL
Imports Framework

Public Class Poblacion

    Dim mId_Poblacion As Integer
    Dim mId_Provincia As Integer
    Dim oDatosMaestros As Maestros

    Public Property Id_Provincia() As Integer
        Get
            Return mId_Provincia
        End Get
        Set(ByVal Value As Integer)
            mId_Provincia = Value
        End Set
    End Property

    Public Property Id_Poblacion() As Integer
        Get
            Return mId_Poblacion
        End Get
        Set(ByVal Value As Integer)
            mId_Poblacion = Value
        End Set
    End Property

    Public Function ObtenerProvincia() As DataTable
        'AGuzzardi Modificaciones MMS ----------------------------------------------------------------------------------------
        oDatosMaestros = New Maestros
        If Activo.DTProvinciaCache Is Nothing Then
            Activo.DTProvinciaCache = oDatosMaestros.poblaciones1Obtener(Constantes.COD_PAIS_ARGENTINA)
        End If
        Return Activo.DTProvinciaCache
    End Function

    Public Function ObtenerPoblacion() As DataTable
        'AGuzzardi Modificaciones MMS ----------------------------------------------------------------------------------------
        oDatosMaestros = New Maestros
        If Activo.DTPoblacionCache Is Nothing Then
            Activo.DTPoblacionCache = oDatosMaestros.poblaciones2ObtenerAlternativa(Constantes.COD_PAIS_ARGENTINA, Me.mId_Provincia, Me.mId_Poblacion)
        End If
        Return Activo.DTPoblacionCache
    End Function


End Class

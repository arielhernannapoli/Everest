Imports MSL
Imports Framework


Public Class Secciones

    Dim mId_medio As Integer
    Dim mId_seccion As Integer
    Dim oDatosMaestros As Maestros

    Public Property Id_seccion() As Integer
        Get
            Return mId_seccion
        End Get
        Set(ByVal Value As Integer)
            mId_seccion = Value
        End Set
    End Property

    Public Property Id_medio() As Integer
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Integer)
            mId_medio = Value
        End Set
    End Property


    Public Function ObtenerSecciones() As DataTable
        'AGuzzardi Modificaciones MMS ----------------------------------------------------------------------------------------
        oDatosMaestros = New Maestros
        If Activo.DTSeccionesCache Is Nothing Then
            Activo.DTSeccionesCache = oDatosMaestros.seccionesObtener(Me.Id_medio)
        End If
        Return Activo.DTSeccionesCache
    End Function

End Class

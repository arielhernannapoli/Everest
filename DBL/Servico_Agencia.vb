Imports MSL
Imports Framework

Public Class Servico_Agencia

    Dim oDatosMaestros As Maestros

#Region "Propiedades"
    Dim mId_Compania As Integer
    Dim mId_Cliente As Integer
    Dim mFDesde As String
    Dim mFHasta As String

    Public Property Id_Compania() As Integer
        Get
            Return mId_Compania
        End Get
        Set(ByVal Value As Integer)
            mId_Compania = Value
        End Set
    End Property

    Public Property Id_Cliente() As Integer
        Get
            Return mId_Cliente
        End Get
        Set(ByVal Value As Integer)
            mId_Cliente = Value
        End Set
    End Property

    Public Property FDesde() As String
        Get
            Return mFDesde
        End Get
        Set(ByVal Value As String)
            mFDesde = Value
        End Set
    End Property

    Public Property FHasta() As String
        Get
            Return mFHasta
        End Get
        Set(ByVal Value As String)
            mFHasta = Value
        End Set
    End Property


#Region "Funciones de MSL"

    Public Function ObtenerServiciosAgenciaInternet() As DataTable

        oDatosMaestros = New Maestros

        If Activo.DTServicioAgenciaInterneteCache Is Nothing Then
            Activo.DTServicioAgenciaInterneteCache = oDatosMaestros.ObtenerServicioAgenciaInternet(Me.Id_Compania, Me.Id_Cliente, Me.FDesde, Me.FHasta)
        End If

        Return Activo.DTServicioAgenciaInterneteCache

    End Function

#End Region


#End Region

End Class

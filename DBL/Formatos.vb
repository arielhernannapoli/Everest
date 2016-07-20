Imports MSL
Imports Framework

Public Class Formatos

    Dim oDatosMaestros As Maestros

#Region "Propiedades"

    Dim mId_Medio As Integer
    Dim mId_Anuncio As Integer
    Dim mDesc_Anuncio As String
    Dim mInd_Fijo As Integer
    Dim mDesc_Anuncio_Ingles As String
    Dim mF_Baja As Date

    Public Property Id_Medio() As Integer
        Get
            Return mId_Medio
        End Get
        Set(ByVal Value As Integer)
            mId_Medio = Value
        End Set
    End Property

    Public Property Id_Anuncio() As Integer
        Get
            Return mId_Anuncio
        End Get
        Set(ByVal Value As Integer)
            mId_Anuncio = Value
        End Set
    End Property

    Public Property Desc_Anuncio() As String
        Get
            Return mDesc_Anuncio
        End Get
        Set(ByVal Value As String)
            mDesc_Anuncio = Value
        End Set
    End Property

    Public Property Ind_Fijo() As Integer
        Get
            Return mInd_Fijo
        End Get
        Set(ByVal Value As Integer)
            mInd_Fijo = Value
        End Set
    End Property

    Public Property Desc_Anuncio_Ingles() As String
        Get
            Return mDesc_Anuncio_Ingles
        End Get
        Set(ByVal Value As String)
            mDesc_Anuncio_Ingles = Value
        End Set
    End Property

    Public Property F_Baja() As Date
        Get
            Return mF_Baja
        End Get
        Set(ByVal Value As Date)
            mF_Baja = Value
        End Set
    End Property

#End Region

#Region "Funciones Propias"

#End Region

#Region "Funciones de MSL"

    Public Function ObtenerFormatos() As DataTable

        Dim DtResultado As DataTable
        oDatosMaestros = New Maestros

        If Activo.DTFormatosCache Is Nothing Then
            Activo.DTFormatosCache = oDatosMaestros.ObtenerFormatos(Me.Id_Medio)
        End If

        DtResultado = Activo.DTFormatosCache

        Return DtResultado

    End Function

#End Region



     

End Class

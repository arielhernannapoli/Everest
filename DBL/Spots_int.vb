
Imports Framework

Public Class Spots_int
    Inherits Entidad

#Region "Variables y Propiedades"

    '======== Declaro Variables =====
    '==== PROPIEDADES TABLA SPOT ====
    Dim mId_spot As Integer
    Dim mId_campania As Integer
    Dim mId_sistema As Integer
    Dim mId_ejercicio As Integer
    Dim mId_soporte As Integer
    Dim mId_tarifa As Integer
    Dim mBruto As Double
    Dim mDcto1 As Single
    Dim mDcto2 As Single
    Dim mNeto As Double
    Dim mF_alta As DateTime
    Dim mU_alta As String
    Dim mF_modi As DateTime
    Dim mU_modi As String
    Dim mId_convenio As Integer
    Dim mId_Medio As Integer
    '==== PROPIEDADES TABLA SPOT INTERNET ====

    Dim mId_proveedor As Integer
    Dim mId_tipo_soporte As Integer
    Dim mId_ubicacion As Integer
    Dim mId_tipo_formato As Integer
    Dim mId_formato As Integer
    Dim mTipo_Compra As Integer
    Dim mF_inicio As Date
    Dim mF_fin As Date
    Dim mCantidad_dias As Integer
    Dim mCantidad_horas As Integer
    Dim mInversion As Double
    Dim mImpresiones As Integer
    Dim mClicks As Integer
    Dim mViews As Integer
    Dim mShare As Single
    Dim mPorSag As Single
    Dim mImpSag As Double
    Dim mId_usuario As Integer
    Dim mTotal As Double
    Dim mCA As Integer
    '======== Declaro Dts ===========
    Dim DtResultado As New DataTable

#End Region

#Region "Propieddades"

    '==== PROPIEDADES TABLA SPOTS =====
    Public Property Id_spot() As Integer
        Get
            Return mId_spot
        End Get
        Set(ByVal Value As Integer)
            mId_spot = Value
        End Set
    End Property

    Public Property Id_campania() As Integer
        Get
            Return mId_campania
        End Get
        Set(ByVal Value As Integer)
            mId_campania = Value
        End Set
    End Property

    Public Property Id_sistema() As Integer
        Get
            Return mId_sistema
        End Get
        Set(ByVal Value As Integer)
            mId_sistema = Value
        End Set
    End Property

    Public Property Id_ejercicio() As Integer
        Get
            Return mId_ejercicio
        End Get
        Set(ByVal Value As Integer)
            mId_ejercicio = Value
        End Set
    End Property

    Public Property Id_soporte() As Integer
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Integer)
            mId_soporte = Value
        End Set
    End Property

    Public Property Id_tarifa() As Integer
        Get
            Return mId_tarifa
        End Get
        Set(ByVal Value As Integer)
            mId_tarifa = Value
        End Set
    End Property

    Public Property Bruto() As Double
        Get
            Return mBruto
        End Get
        Set(ByVal Value As Double)
            mBruto = Value
        End Set
    End Property

    Public Property Dcto1() As Single
        Get
            Return mDcto1
        End Get
        Set(ByVal Value As Single)
            mDcto1 = Value
        End Set
    End Property

    Public Property Dcto2() As Single
        Get
            Return mDcto2
        End Get
        Set(ByVal Value As Single)
            mDcto2 = Value
        End Set
    End Property

    Public Property Neto() As Double
        Get
            Return mNeto
        End Get
        Set(ByVal Value As Double)
            mNeto = Value
        End Set
    End Property

    Public Property F_alta() As DateTime
        Get
            Return mF_alta
        End Get
        Set(ByVal Value As DateTime)
            mF_alta = Value
        End Set
    End Property

    Public Property U_alta() As String
        Get
            Return mU_alta
        End Get
        Set(ByVal Value As String)
            mU_alta = Value
        End Set
    End Property

    Public Property F_modi() As DateTime
        Get
            Return mF_modi
        End Get
        Set(ByVal Value As DateTime)
            mF_modi = Value
        End Set
    End Property

    Public Property U_modi() As String
        Get
            Return mU_modi
        End Get
        Set(ByVal Value As String)
            mU_modi = Value
        End Set
    End Property

    Public Property Id_convenio() As Int64
        Get
            Return mId_convenio
        End Get
        Set(ByVal Value As Int64)
            mId_convenio = Value
        End Set
    End Property

    Public Property Id_Medio() As Int32
        Get
            Return mId_Medio
        End Get
        Set(ByVal Value As Int32)
            mId_Medio = Value
        End Set
    End Property

    '==== PROPIEDADES TABLA SPOT INTERNET ===

    Public Property Id_proveedor() As Integer
        Get
            Return mId_proveedor
        End Get
        Set(ByVal Value As Integer)
            mId_proveedor = Value
        End Set
    End Property

    Public Property Id_tipo_soporte() As Integer
        Get
            Return mId_tipo_soporte
        End Get
        Set(ByVal Value As Integer)
            mId_tipo_soporte = Value
        End Set
    End Property

    Public Property Id_ubicacion() As Integer
        Get
            Return mId_ubicacion
        End Get
        Set(ByVal Value As Integer)
            mId_ubicacion = Value
        End Set
    End Property

    Public Property Id_tipo_formato() As Integer
        Get
            Return mId_tipo_formato
        End Get
        Set(ByVal Value As Integer)
            mId_tipo_formato = Value
        End Set
    End Property

    Public Property Id_formato() As Integer
        Get
            Return mId_formato
        End Get
        Set(ByVal Value As Integer)
            mId_formato = Value
        End Set
    End Property

    Public Property Id_Tipo_Compra() As Integer
        Get
            Return mTipo_Compra
        End Get
        Set(ByVal Value As Integer)
            mTipo_Compra = Value
        End Set
    End Property

    Public Property F_inicio() As Date
        Get
            Return mF_inicio
        End Get
        Set(ByVal Value As Date)
            mF_inicio = Value
        End Set
    End Property

    Public Property F_fin() As Date
        Get
            Return mF_fin
        End Get
        Set(ByVal Value As Date)
            mF_fin = Value
        End Set
    End Property

    Public Property Cantidad_dias() As Integer
        Get
            Return mCantidad_dias
        End Get
        Set(ByVal Value As Integer)
            mCantidad_dias = Value
        End Set
    End Property

    Public Property Cantidad_horas() As Integer
        Get
            Return mCantidad_horas
        End Get
        Set(ByVal Value As Integer)
            mCantidad_horas = Value
        End Set
    End Property

    Public Property Inversion() As Double
        Get
            Return mInversion
        End Get
        Set(ByVal Value As Double)
            mInversion = Value
        End Set
    End Property

    Public Property Impresiones() As Integer
        Get
            Return mImpresiones
        End Get
        Set(ByVal Value As Integer)
            mImpresiones = Value
        End Set
    End Property

    Public Property Clicks() As Integer
        Get
            Return mClicks
        End Get
        Set(ByVal Value As Integer)
            mClicks = Value
        End Set
    End Property

    Public Property Views() As Integer
        Get
            Return mViews
        End Get
        Set(ByVal Value As Integer)
            mViews = Value
        End Set
    End Property

    Public Property Share() As Single
        Get
            Return mShare
        End Get
        Set(ByVal Value As Single)
            mShare = Value
        End Set
    End Property

    Public Property PorSag() As Single
        Get
            Return mPorSag
        End Get
        Set(ByVal Value As Single)
            mPorSag = Value
        End Set
    End Property

    Public Property ImpSag() As Double
        Get
            Return mImpSag
        End Get
        Set(ByVal Value As Double)
            mImpSag = Value
        End Set
    End Property

    Public Property Id_usuario() As Integer
        Get
            Return mId_usuario
        End Get
        Set(ByVal Value As Integer)
            mId_usuario = Value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return mTotal
        End Get
        Set(ByVal Value As Double)
            mTotal = Value
        End Set
    End Property

    Public Property CA() As Integer
        Get
            Return mCA
        End Get
        Set(ByVal Value As Integer)
            mCA = Value
        End Set
    End Property

#End Region


#Region "Funciones Tabla SPOTS"

    Sub New()
        MyBase.New("Spots_int")
    End Sub

    Public Function Insertar_Spots() As Long

        Dim NuevoIdSpot As Long
        NuevoIdSpot = Me.Ejecutar("SPK_SPOTS_INTERNET.SP_INSERT_SPOTS", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio, Me.Id_soporte, Me.Id_tarifa, Me.Bruto, Me.Dcto1, Me.Dcto2, Me.Neto, Me.F_alta, Me.U_alta, Me.F_modi, Me.U_modi, Me.Id_convenio)
        Return NuevoIdSpot

    End Function

    Public Function Actualizar_Spots()
        Me.Ejecutar("SPK_SPOTS_INTERNET.SP_UPDATE_SPOTS", Me.Id_spot, Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio, Me.Id_soporte, Me.Id_tarifa, Me.Bruto, Me.Dcto1, Me.Dcto2, Me.Neto, Me.F_modi, Me.U_modi, Me.Id_convenio)
    End Function

    Public Function Eliminar_Spots()

    End Function

#End Region

#Region "Funciones Tabla SPOTS_INTERNET"

    Public Function Insertar_SpotsInternet()
        Me.Ejecutar("SPK_SPOTS_INTERNET.SP_INSERT_SPOT_INTERNET", Me.Id_spot, Me.Id_proveedor, Me.Id_tipo_soporte, Me.Id_ubicacion, Me.Id_tipo_formato, Me.Id_formato, Me.Id_Tipo_Compra, Me.F_inicio, Me.F_fin, Me.Cantidad_dias, Me.Cantidad_horas, Me.Inversion, Me.Impresiones, Me.Clicks, Me.Views, Me.Share, Me.PorSag, Me.ImpSag, Me.Total, Me.Id_usuario, Me.CA)
    End Function

    Public Function Actualizar_SpotsInternet()
        Me.Ejecutar("SPK_SPOTS_INTERNET.SP_UPDATE_SPOT_INTERNET", Me.Id_spot, Me.Id_proveedor, Me.Id_tipo_soporte, Me.Id_ubicacion, Me.Id_tipo_formato, Me.Id_formato, Me.Id_Tipo_Compra, Me.F_inicio, Me.F_fin, Me.Cantidad_dias, Me.Cantidad_horas, Me.Inversion, Me.Impresiones, Me.Clicks, Me.Views, Me.Share, Me.PorSag, Me.ImpSag, Me.Total, Me.Id_usuario, Me.CA)
    End Function

    Public Function Eliminar_SpotsInternet()
        Me.Ejecutar("SPK_SPOTS_INTERNET.SP_BAJA_LOGICA_SPOT_INTERNET", Me.Id_spot, Me.Id_usuario)
    End Function

#Region "Funciones en Comun"

    Public Function ObtenerSpots() As DataTable

        DtResultado = Me.TraerDataSet("SPK_SPOTS_INTERNET.SP_OBTENER_SPOTS", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio).Tables(0)

        Return DtResultado

    End Function

    Public Function ObtenerCantidadSpots(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer) As Integer
        Return Me.Ejecutar("SPK_SPOTS_INTERNET.SP_SELECT_CANT_SPOTS", pId_Campania, pId_Sistema, pId_Ejercicio)
    End Function

    Public Function ValidarSpotsExisteBaja() As Integer
        Return Me.Ejecutar("SPK_SPOTS_INTERNET.SP_EXISTE_SPOTS_BAJA", Me.Id_spot, Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio)
    End Function

#End Region

#Region "Procedimientos envio a Compras"

    Public Function ObtenerSoportesInternet(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer, ByVal pId_tipo_soporte As Integer) As DataSet
        Return Me.TraerDataSet("SPK_SPOTS_INTERNET.SP_SELECT_SOP_INTERNET", pId_Campania, pId_Sistema, pId_Ejercicio, pId_tipo_soporte)
    End Function

#End Region

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
    End Sub

#End Region

End Class

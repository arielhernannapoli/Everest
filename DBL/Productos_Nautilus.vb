Public Class Productos_Nautilus
    Inherits Entidad

#Region "Propiedades"
    Dim mCod_Sps As Int32
    Dim mNom_Sps As String
    Dim mSec_Sps As Int16
    Dim mGru_Sps As Int16
    Dim mPro_Sps As Int16
    Dim mCan_Sps As Int32
    Dim mFal_Sps As DateTime
    Dim mDes_Sps As String
    Dim mMds_Sps As String

    Public Property Cod_Sps() As Int32
        Get
            Return mCod_Sps
        End Get
        Set(ByVal Value As Int32)
            mCod_Sps = Value
        End Set
    End Property

    Public Property Nom_Sps() As String
        Get
            Return mNom_Sps
        End Get
        Set(ByVal Value As String)
            mNom_Sps = Value
        End Set
    End Property

    Public Property Sec_Sps() As Int16
        Get
            Return mSec_Sps
        End Get
        Set(ByVal Value As Int16)
            mSec_Sps = Value
        End Set
    End Property

    Public Property Gru_Sps() As Int16
        Get
            Return mGru_Sps
        End Get
        Set(ByVal Value As Int16)
            mGru_Sps = Value
        End Set
    End Property

    Public Property Pro_Sps() As Int16
        Get
            Return mPro_Sps
        End Get
        Set(ByVal Value As Int16)
            mPro_Sps = Value
        End Set
    End Property

    Public Property Can_Sps() As Int32
        Get
            Return mCan_Sps
        End Get
        Set(ByVal Value As Int32)
            mCan_Sps = Value
        End Set
    End Property

    Public Property Fal_Sps() As DateTime
        Get
            Return mFal_Sps
        End Get
        Set(ByVal Value As DateTime)
            mFal_Sps = Value
        End Set
    End Property

    Public Property Des_Sps() As String
        Get
            Return mDes_Sps
        End Get
        Set(ByVal Value As String)
            mDes_Sps = Value
        End Set
    End Property

    Public Property Mds_Sps() As String
        Get
            Return mMds_Sps
        End Get
        Set(ByVal Value As String)
            mMds_Sps = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Productos_Nautilus")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Cod_sps, Nom_sps, Sec_sps, Gru_sps, Pro_sps, Can_sps, Fal_sps, Des_sps, Mds_sps)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Cod_sps, Nom_sps, Sec_sps, Gru_sps, Pro_sps, Can_sps, Fal_sps, Des_sps, Mds_sps)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Cod_sps)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Cod_sps)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Cod_sps = IIf(IsDBNull(Dr("Cod_sps")), 0, Dr("Cod_sps"))
        Me.Nom_sps = IIf(IsDBNull(Dr("Nom_sps")), "", Dr("Nom_sps"))
        Me.Sec_sps = IIf(IsDBNull(Dr("Sec_sps")), 0, Dr("Sec_sps"))
        Me.Gru_sps = IIf(IsDBNull(Dr("Gru_sps")), 0, Dr("Gru_sps"))
        Me.Pro_sps = IIf(IsDBNull(Dr("Pro_sps")), 0, Dr("Pro_sps"))
        Me.Can_sps = IIf(IsDBNull(Dr("Can_sps")), 0, Dr("Can_sps"))
        Me.Fal_sps = IIf(IsDBNull(Dr("Fal_sps")), Nothing, Dr("Fal_sps"))
        Me.Des_sps = IIf(IsDBNull(Dr("Des_sps")), "", Dr("Des_sps"))
        Me.Mds_sps = IIf(IsDBNull(Dr("Mds_sps")), "", Dr("Mds_sps"))
    End Sub

    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
    End Function
    Public Overloads Sub IniciarTransaccion()
        MyBase.IniciarTransaccion()
    End Sub

    Public Overloads Sub TerminarTransaccion()
        MyBase.TerminarTransaccion()
    End Sub

    Public Overloads Sub AbortarTransaccion()
        MyBase.AbortarTransaccion()
    End Sub

#End Region

#Region "Funciones Propias"
#End Region

End Class

Public Class Programa_Ext
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Consulta As Int32
    Dim mFec_Prg As DateTime
    Dim mCad_Prg As String
    Dim mHor_Prg As Int32
    Dim mCod_Prg As Int32
    Dim mNiv_Prg As String
    Dim mDrm_Prg As Int16
    Dim mDrs_Prg As Int16
    Dim mHfn_Prg As Int32
    Dim mGen_Prg As String
    Dim mNac_Prg As Int16
    Dim mRep_Prg As String
    Dim mDif_Prg As String
    Dim mCdf_Prg As String
    Dim mTi2_Prg As String
    Dim mVem_Prg As Int16

    Public Property Id_Consulta() As Int32
        Get
            Return mId_consulta
        End Get
        Set(ByVal Value As Int32)
            mId_consulta = Value
        End Set
    End Property

    Public Property Fec_Prg() As DateTime
        Get
            Return mFec_prg
        End Get
        Set(ByVal Value As DateTime)
            mFec_prg = Value
        End Set
    End Property

    Public Property Cad_Prg() As String
        Get
            Return mCad_prg
        End Get
        Set(ByVal Value As String)
            mCad_prg = Value
        End Set
    End Property

    Public Property Hor_Prg() As Int32
        Get
            Return mHor_prg
        End Get
        Set(ByVal Value As Int32)
            mHor_prg = Value
        End Set
    End Property

    Public Property Cod_Prg() As Int32
        Get
            Return mCod_prg
        End Get
        Set(ByVal Value As Int32)
            mCod_prg = Value
        End Set
    End Property

    Public Property Niv_Prg() As String
        Get
            Return mNiv_prg
        End Get
        Set(ByVal Value As String)
            mNiv_prg = Value
        End Set
    End Property

    Public Property Drm_Prg() As Int16
        Get
            Return mDrm_prg
        End Get
        Set(ByVal Value As Int16)
            mDrm_prg = Value
        End Set
    End Property

    Public Property Drs_Prg() As Int16
        Get
            Return mDrs_prg
        End Get
        Set(ByVal Value As Int16)
            mDrs_prg = Value
        End Set
    End Property

    Public Property Hfn_Prg() As Int32
        Get
            Return mHfn_prg
        End Get
        Set(ByVal Value As Int32)
            mHfn_prg = Value
        End Set
    End Property

    Public Property Gen_Prg() As String
        Get
            Return mGen_prg
        End Get
        Set(ByVal Value As String)
            mGen_prg = Value
        End Set
    End Property

    Public Property Nac_Prg() As Int16
        Get
            Return mNac_prg
        End Get
        Set(ByVal Value As Int16)
            mNac_prg = Value
        End Set
    End Property

    Public Property Rep_Prg() As String
        Get
            Return mRep_prg
        End Get
        Set(ByVal Value As String)
            mRep_prg = Value
        End Set
    End Property

    Public Property Dif_Prg() As String
        Get
            Return mDif_prg
        End Get
        Set(ByVal Value As String)
            mDif_prg = Value
        End Set
    End Property

    Public Property Cdf_Prg() As String
        Get
            Return mCdf_prg
        End Get
        Set(ByVal Value As String)
            mCdf_prg = Value
        End Set
    End Property

    Public Property Ti2_Prg() As String
        Get
            Return mTi2_prg
        End Get
        Set(ByVal Value As String)
            mTi2_prg = Value
        End Set
    End Property

    Public Property Vem_Prg() As Int16
        Get
            Return mVem_prg
        End Get
        Set(ByVal Value As Int16)
            mVem_prg = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Programa_Ext")
    End Sub

    Public Overloads Function Agregar() As Integer
        MyBase.Agregar(Id_consulta, Fec_prg, Cad_prg, Hor_prg, Cod_prg, Niv_prg, Drm_prg, Drs_prg, Hfn_prg, Gen_prg, Nac_prg, Rep_prg, Dif_prg, Cdf_prg, Ti2_prg, Vem_prg)
    End Function

    Public Overloads Function Modificar() As Integer
        MyBase.Modificar(Id_consulta, Fec_prg, Cad_prg, Hor_prg, Cod_prg, Niv_prg, Drm_prg, Drs_prg, Hfn_prg, Gen_prg, Nac_prg, Rep_prg, Dif_prg, Cdf_prg, Ti2_prg, Vem_prg)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_consulta)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_consulta)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_consulta = IIf(IsDBNull(Dr("Id_consulta")), 0, Dr("Id_consulta"))
        Me.Fec_prg = IIf(IsDBNull(Dr("Fec_prg")), Nothing, Dr("Fec_prg"))
        Me.Cad_prg = IIf(IsDBNull(Dr("Cad_prg")), "", Dr("Cad_prg"))
        Me.Hor_prg = IIf(IsDBNull(Dr("Hor_prg")), 0, Dr("Hor_prg"))
        Me.Cod_prg = IIf(IsDBNull(Dr("Cod_prg")), 0, Dr("Cod_prg"))
        Me.Niv_prg = IIf(IsDBNull(Dr("Niv_prg")), "", Dr("Niv_prg"))
        Me.Drm_prg = IIf(IsDBNull(Dr("Drm_prg")), 0, Dr("Drm_prg"))
        Me.Drs_prg = IIf(IsDBNull(Dr("Drs_prg")), 0, Dr("Drs_prg"))
        Me.Hfn_prg = IIf(IsDBNull(Dr("Hfn_prg")), 0, Dr("Hfn_prg"))
        Me.Gen_prg = IIf(IsDBNull(Dr("Gen_prg")), "", Dr("Gen_prg"))
        Me.Nac_prg = IIf(IsDBNull(Dr("Nac_prg")), 0, Dr("Nac_prg"))
        Me.Rep_prg = IIf(IsDBNull(Dr("Rep_prg")), "", Dr("Rep_prg"))
        Me.Dif_prg = IIf(IsDBNull(Dr("Dif_prg")), "", Dr("Dif_prg"))
        Me.Cdf_prg = IIf(IsDBNull(Dr("Cdf_prg")), "", Dr("Cdf_prg"))
        Me.Ti2_prg = IIf(IsDBNull(Dr("Ti2_prg")), "", Dr("Ti2_prg"))
        Me.Vem_prg = IIf(IsDBNull(Dr("Vem_prg")), 0, Dr("Vem_prg"))
    End Sub

    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
    End Function
#End Region

#Region "Funciones Propias"

    Private Sub BuscarPorIDCad_Prg()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".SP_SELECT_ID_CAD_PRG", Id_Consulta, Cad_Prg)
    End Sub

    Public Sub CargarAudiencia(ByVal pId_medio As Short, ByVal pId_Soporte As Long, ByVal pIdCadena As String, ByVal pCliente As Long, ByVal F_Aud_Desde As Date, ByVal F_Aud_Hasta As Date, ByVal F_Sis_Desde As Date, ByVal F_Sis_Hasta As Date)
        ' inserto audiencia, saco los datos de tarifas_tv con el cliente que me pasa
        MyBase.Ejecutar("spk_Programa_Ext.InsertaPrograma_Ext", mId_Consulta, pId_medio, pId_Soporte, pIdCadena, pCliente, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta)
        Try
            BuscarPorIDCad_Prg() ' Busco, si no insertó, es porque no encontro datos en tarifas_tv con ese cliente
        Catch ex As DataReaderVacioExcepcion ' si no lo encuentro con id cliente, lo busco con el generico (0)
            MyBase.Ejecutar("spk_Programa_Ext.InsertaPrograma_Ext", mId_Consulta, pId_medio, pId_Soporte, pIdCadena, 0, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta)
        End Try
    End Sub
    Public Sub CargarAudienciaReducida(ByVal pId_medio As Short, ByVal pId_Soporte As Long, ByVal pCliente As Long, ByVal F_Aud_Desde As Date, ByVal F_Aud_Hasta As Date, ByVal F_Sis_Desde As Date, ByVal F_Sis_Hasta As Date, ByVal Id_Campania As Long, ByVal Id_Sistema As Long, ByVal Id_Ejercicio As Long)
        ' inserto audiencia, saco los datos de tarifas_tv con el cliente que me pasa
        MyBase.Ejecutar("spk_Programa_Ext.INSERTAPROGRAMA_EXT_SPOTS", mId_Consulta, pId_medio, pId_Soporte, pCliente, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta, id_campania, id_sistema, id_ejercicio)
        Try
            BuscarPorIDCad_Prg() ' Busco, si no insertó, es porque no encontro datos en tarifas_tv con ese cliente
        Catch ex As DataReaderVacioExcepcion ' si no lo encuentro con id cliente, lo busco con el generico (0)
            MyBase.Ejecutar("spk_Programa_Ext.INSERTAPROGRAMA_EXT_SPOTS", mId_Consulta, pId_medio, pId_Soporte, 0, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta, id_campania, id_sistema, id_ejercicio)
        End Try
    End Sub

    Public Sub BuscarPorID_Cad_Fec_Hor()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select_Id_Cad_Fec_Hor", Id_Consulta, Fec_Prg, Cad_Prg, Hor_Prg)
    End Sub

#End Region

End Class

Imports Framework
Public Class Audiencia_rd
    Inherits Entidad

#Region "Propiedades"
    Dim mId_ola As Decimal
    Dim mTar_ape As String
    Dim mCad_ape As String
    Dim mCob_ape As Int16
    Dim mSop_ape As Int16
    Dim mAme_ape As Single
    Dim mDia_ape As Int16

    Public Property Id_ola() As Decimal
        Get
            Return mId_ola
        End Get
        Set(ByVal Value As Decimal)
            mId_ola = Value
        End Set
    End Property

    Public Property Tar_ape() As String
        Get
            Return mTar_ape
        End Get
        Set(ByVal Value As String)
            mTar_ape = Value
        End Set
    End Property

    Public Property Cad_ape() As String
        Get
            Return mCad_ape
        End Get
        Set(ByVal Value As String)
            mCad_ape = Value
        End Set
    End Property

    Public Property Cob_ape() As Int16
        Get
            Return mCob_ape
        End Get
        Set(ByVal Value As Int16)
            mCob_ape = Value
        End Set
    End Property

    Public Property Sop_ape() As Int16
        Get
            Return mSop_ape
        End Get
        Set(ByVal Value As Int16)
            mSop_ape = Value
        End Set
    End Property

    Public Property Ame_ape() As Single
        Get
            Return mAme_ape
        End Get
        Set(ByVal Value As Single)
            mAme_ape = Value
        End Set
    End Property

    Public Property Dia_ape() As Int16
        Get
            Return mDia_ape
        End Get
        Set(ByVal Value As Int16)
            mDia_ape = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("audiencia_rd")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_ola, Tar_ape, Cad_ape, Cob_ape, Sop_ape, Ame_ape, Dia_ape)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_ola, Tar_ape, Cad_ape, Cob_ape, Sop_ape, Ame_ape, Dia_ape)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_ola)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_ola)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_ola = IIf(IsDBNull(Dr("Id_ola")), 0, Dr("Id_ola"))
        Me.Tar_ape = IIf(IsDBNull(Dr("Tar_ape")), "", Dr("Tar_ape"))
        Me.Cad_ape = IIf(IsDBNull(Dr("Cad_ape")), "", Dr("Cad_ape"))
        Me.Cob_ape = IIf(IsDBNull(Dr("Cob_ape")), 0, Dr("Cob_ape"))
        Me.Sop_ape = IIf(IsDBNull(Dr("Sop_ape")), 0, Dr("Sop_ape"))
        Me.Ame_ape = IIf(IsDBNull(Dr("Ame_ape")), 0, Dr("Ame_ape"))
        Me.Dia_ape = IIf(IsDBNull(Dr("Dia_ape")), 0, Dr("Dia_ape"))
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
    Public Function ObtenerTargets() As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_targets_all").Tables(0)
    End Function

    Public Function ObtenerTarget() As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_targets").Tables(0)
    End Function

    Public Function ObtenerPesoDemografico(ByVal pTipo_Individuo As Integer, ByVal pEdad_Desde As Integer, ByVal pEdad_Hasta As Integer, ByVal pSexo As String, ByVal pDes_Nivel As String) As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_peso_demografico", pTipo_Individuo, pEdad_Desde, pEdad_Hasta, pSexo, pDes_Nivel).Tables(0)
    End Function

    Public Function ObtenerPesoTarget(ByVal pTipo_Individuo As Integer, ByVal pEdad_Desde As Integer, ByVal pEdad_Hasta As Integer, ByVal pSexo As String, ByVal pDes_Nivel As String) As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_peso_target", pTipo_Individuo, pEdad_Desde, pEdad_Hasta, pSexo, pDes_Nivel).Tables(0)
    End Function

    Public Function ObtenerOlaAudiencia() As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_olas_all").Tables(0)
    End Function

    Public Function ObtenerAudiencia(ByVal pId_Ola As Integer) As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_all", pId_Ola).Tables(0)
    End Function

    Public Function ObtenerAudienciaParcial(ByVal pId_Ola As Integer, ByVal pId_Target As String, ByVal pId_Soporte As String, ByVal pHora_Desde As Integer, ByVal pMinuto_Desde As Integer, ByVal pHora_Hasta As Integer, ByVal pMinuto_Hasta As Integer, ByVal pDias As String) As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_audiencia", pId_Ola, pId_Target, pId_Soporte, pHora_Desde, pMinuto_Desde, pHora_Hasta, pMinuto_Hasta, pDias).Tables(0)
    End Function

    Public Function ObtenerExistenciaAudiencia(ByVal pId_Ola As Integer, ByVal pId_Target As String) As Integer
        Return Me.TraerValor("spk_audiencia_rd.sp_select_count", pId_Ola, pId_Target)
    End Function

    Public Function ObtenerEmisoras() As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_emisoras").Tables(0)
    End Function

    Public Function ObtenerEmisorasIntermedias() As DataTable
        
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_emisoras_intermedias").Tables(0)
    End Function

    Public Function AgregarOlaAudiencia(ByVal pFechaInicio As DateTime, ByVal pFechaFin As DateTime, ByVal pDescripcion As String) As Integer
        Return Me.Ejecutar("spk_audiencia_rd.sp_insert_ola", pFechaInicio, pFechaFin, pDescripcion)
    End Function

    Public Function AgregarEmisoraIntermedia(ByVal pIdSoporte As Integer, ByVal pIdCorrelativo As Integer) As Integer
        Return Me.Ejecutar("spk_audiencia_rd.sp_insert_emisora_intermedia", pIdSoporte, pIdCorrelativo)
    End Function

    Public Function BorrarEmisoraIntermedia(ByVal pIdSoporte As Integer, ByVal pIdCorrelativo As Integer) As Integer
        Return Me.Ejecutar("spk_audiencia_rd.sp_delete_emisora_intermedia", pIdSoporte, pIdCorrelativo)
    End Function

    Public Sub ObteniendoAudienciaRadio(ByVal Ds As DataSet, ByVal NombreTabla As String, ByVal IdSoporte As Integer, ByVal FechaInicioSistema As DateTime, ByVal FechaFinSistema As DateTime, ByVal FechaInicioAudiencia As DateTime, ByVal FechaFinAudiencia As DateTime, ByVal Target1 As Integer, ByVal Target2 As Integer)
        Me.CargarDataSet(Ds, NombreTabla, "spk_audiencia_rd.sp_select_promedio", IdSoporte, FechaInicioSistema, FechaFinSistema, FechaInicioAudiencia, FechaFinAudiencia, Target1, Target2)
    End Sub

    Public Function ObtenerAudienciaRadio(ByVal IdSoporte As Integer, ByVal FechaInicioSistema As DateTime, ByVal FechaFinSistema As DateTime, ByVal FechaInicioAudiencia As DateTime, ByVal FechaFinAudiencia As DateTime, ByVal Target1 As Integer, ByVal Target2 As Integer) As DataTable
        Return Me.TraerDataSet("spk_audiencia_rd.sp_select_promedio", IdSoporte, FechaInicioSistema, FechaFinSistema, FechaInicioAudiencia, FechaFinAudiencia, Target1, Target2).Tables(0)
    End Function
#End Region

End Class




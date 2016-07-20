Public Class Tarifas_tv
    Inherits Entidad

#Region "Propiedades"
    Dim mId_tarifa_tv As Int64
    Dim mId_medio As Int64
    Dim mId_soporte As Int64
    Dim mId_cliente As Int64
    Dim mPrograma As String
    Dim mD_l As String
    Dim mD_m As String
    Dim mD_x As String
    Dim mD_j As String
    Dim mD_v As String
    Dim mD_s As String
    Dim mD_d As String
    Dim mH_desde As Int16
    Dim mM_desde As Int16
    Dim mH_hasta As Int16
    Dim mM_hasta As Int16
    Dim mF_inicio_vig As DateTime
    Dim mF_fin_vig As DateTime
    Dim mInd_especial As String
    Dim mId_programa As Int64
    Dim mBruto As Double

    Public Property Id_tarifa_tv() As Int64
        Get
            Return mId_tarifa_tv
        End Get
        Set(ByVal Value As Int64)
            mId_tarifa_tv = Value
        End Set
    End Property

    Public Property Id_medio() As Int16
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Int16)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_soporte() As Int64
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Int64)
            mId_soporte = Value
        End Set
    End Property

    Public Property Id_cliente() As Int64
        Get
            Return mId_cliente
        End Get
        Set(ByVal Value As Int64)
            mId_cliente = Value
        End Set
    End Property

    Public Property Programa() As String
        Get
            Return mPrograma
        End Get
        Set(ByVal Value As String)
            mPrograma = Value
        End Set
    End Property

    Public Property D_l() As String
        Get
            Return mD_l
        End Get
        Set(ByVal Value As String)
            mD_l = Value
        End Set
    End Property

    Public Property D_m() As String
        Get
            Return mD_m
        End Get
        Set(ByVal Value As String)
            mD_m = Value
        End Set
    End Property

    Public Property D_x() As String
        Get
            Return mD_x
        End Get
        Set(ByVal Value As String)
            mD_x = Value
        End Set
    End Property

    Public Property D_j() As String
        Get
            Return mD_j
        End Get
        Set(ByVal Value As String)
            mD_j = Value
        End Set
    End Property

    Public Property D_v() As String
        Get
            Return mD_v
        End Get
        Set(ByVal Value As String)
            mD_v = Value
        End Set
    End Property

    Public Property D_s() As String
        Get
            Return mD_s
        End Get
        Set(ByVal Value As String)
            mD_s = Value
        End Set
    End Property

    Public Property D_d() As String
        Get
            Return mD_d
        End Get
        Set(ByVal Value As String)
            mD_d = Value
        End Set
    End Property

    Public Property H_desde() As Int16
        Get
            Return mH_desde
        End Get
        Set(ByVal Value As Int16)
            mH_desde = Value
        End Set
    End Property

    Public Property M_desde() As Int16
        Get
            Return mM_desde
        End Get
        Set(ByVal Value As Int16)
            mM_desde = Value
        End Set
    End Property

    Public Property H_hasta() As Int16
        Get
            Return mH_hasta
        End Get
        Set(ByVal Value As Int16)
            mH_hasta = Value
        End Set
    End Property

    Public Property M_hasta() As Int16
        Get
            Return mM_hasta
        End Get
        Set(ByVal Value As Int16)
            mM_hasta = Value
        End Set
    End Property

    Public Property F_inicio_vig() As DateTime
        Get
            Return mF_inicio_vig
        End Get
        Set(ByVal Value As DateTime)
            mF_inicio_vig = Value
        End Set
    End Property

    Public Property F_fin_vig() As DateTime
        Get
            Return mF_fin_vig
        End Get
        Set(ByVal Value As DateTime)
            mF_fin_vig = Value
        End Set
    End Property

    Public Property Ind_especial() As String
        Get
            Return mInd_especial
        End Get
        Set(ByVal Value As String)
            mInd_especial = Value
        End Set
    End Property

    Public Property Id_programa() As Int64
        Get
            Return mId_programa
        End Get
        Set(ByVal Value As Int64)
            mId_programa = Value
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
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("tarifas_tv")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_tarifa_tv, Id_medio, Id_soporte, Id_cliente, Programa, D_l, D_m, D_x, D_j, D_v, D_s, D_d, H_desde, M_desde, H_hasta, M_hasta, F_inicio_vig, F_fin_vig, Ind_especial, Id_programa, Bruto)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_tarifa_tv, Id_medio, Id_soporte, Id_cliente, Programa, D_l, D_m, D_x, D_j, D_v, D_s, D_d, H_desde, M_desde, H_hasta, M_hasta, F_inicio_vig, F_fin_vig, Ind_especial, Id_programa, Bruto)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_tarifa_tv)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_tarifa_tv)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_tarifa_tv = IIf(IsDBNull(Dr("Id_tarifa_tv")), 0, Dr("Id_tarifa_tv"))
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Id_cliente = IIf(IsDBNull(Dr("Id_cliente")), 0, Dr("Id_cliente"))
        Me.Programa = IIf(IsDBNull(Dr("Programa")), "", Dr("Programa"))
        Me.D_l = IIf(IsDBNull(Dr("D_l")), "", Dr("D_l"))
        Me.D_m = IIf(IsDBNull(Dr("D_m")), "", Dr("D_m"))
        Me.D_x = IIf(IsDBNull(Dr("D_x")), "", Dr("D_x"))
        Me.D_j = IIf(IsDBNull(Dr("D_j")), "", Dr("D_j"))
        Me.D_v = IIf(IsDBNull(Dr("D_v")), "", Dr("D_v"))
        Me.D_s = IIf(IsDBNull(Dr("D_s")), "", Dr("D_s"))
        Me.D_d = IIf(IsDBNull(Dr("D_d")), "", Dr("D_d"))
        Me.H_desde = IIf(IsDBNull(Dr("H_desde")), 0, Dr("H_desde"))
        Me.M_desde = IIf(IsDBNull(Dr("M_desde")), 0, Dr("M_desde"))
        Me.H_hasta = IIf(IsDBNull(Dr("H_hasta")), 0, Dr("H_hasta"))
        Me.M_hasta = IIf(IsDBNull(Dr("M_hasta")), 0, Dr("M_hasta"))
        Me.F_inicio_vig = IIf(IsDBNull(Dr("F_inicio_vig")), Nothing, Dr("F_inicio_vig"))
        Me.F_fin_vig = IIf(IsDBNull(Dr("F_fin_vig")), Nothing, Dr("F_fin_vig"))
        Me.Ind_especial = IIf(IsDBNull(Dr("Ind_especial")), "", Dr("Ind_especial"))
        Me.Id_programa = IIf(IsDBNull(Dr("Id_programa")), 0, Dr("Id_programa"))
        Me.Bruto = IIf(IsDBNull(Dr("Bruto")), 0, Dr("Bruto"))
    End Sub

    Public Overloads Sub ObtenerEsquema(ByVal Dt As DataTable)
        Me.ObtenerEsquema("spk_agencias.sp_select_all", Dt)
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
    Public Function ObtenerDatosGantt() As DataTable
        Return Me.TraerDataSet("spk_tarifas_tv.sp_tarifas_tv_grilla", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.F_inicio_vig, Me.F_fin_vig).Tables(0)
    End Function

    Public Sub ObteniendoTarifas(ByVal Ds As DataSet, ByVal NombreTabla As String)
        Me.CargarDataSet(Ds, NombreTabla, "spk_tarifas_tv.sp_tarifas_grilla", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.F_inicio_vig, Me.F_fin_vig)
    End Sub

    Public Function Buscar_x_Cadena_Nombre_Dia()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_Buscar_x_Cadena_Nombre_Dia", mId_soporte, mPrograma, "X")
    End Function

    Public Sub CargarEsquema(ByVal dt As DataTable)
        Me.ObtenerEsquema("spk_tarifas_tv.sp_select_all", dt)
    End Sub

    Public Sub ObteniendoDias(ByVal Ds As DataSet, ByVal NombreTabla As String)
        Me.CargarDataSet(Ds, NombreTabla, "spk_tarifas_tv.sp_dias_programa_grilla", Me.Id_medio, Me.Id_soporte)
    End Sub
    Public Function ObtenerDia() As String
        Try
            Dim dtValues As New DataTable
            dtValues = MyBase.TraerDataSet("spk_tarifas_tv.sp_dias_programa_grilla", Me.Id_tarifa_tv).Tables(0)
            If dtValues.Rows(0).Item("Dias").ToString = "" Then
                Return Nothing
            Else
                Return dtValues.Rows(0).Item("Dias")
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function ObtenerFechaInicio() As String
        Return MyBase.TraerDataSet("spk_tarifas_tv.sp_dias_programa_grilla", Me.Id_tarifa_tv).Tables(0).Rows(0).Item("f_inicio_vig")
    End Function
    Public Function ObtenerBruto() As Single
        Return MyBase.TraerDataSet("spk_tarifas_tv.sp_dias_programa_grilla", Me.Id_tarifa_tv).Tables(0).Rows(0).Item("Bruto")
    End Function
    Public Function EsEspecial() As Integer
        Return MyBase.TraerDataSet("spk_tarifas_tv.sp_dias_programa_grilla", Me.Id_tarifa_tv).Tables(0).Rows(0).Item("ind_especial")
    End Function
    Public Sub AgregarTarifas(ByVal Ds As DataSet)
        'Me.GuadarDataSet(Ds, "spk_tarifas_tv.sp_insert", True, Me.Id_tarifa_tv, Me.Id_medio, Me.Id_soporte, Me.Id_cliente, Me.D_l, Me.D_m, Me.D_x, Me.D_j, Me.D_v, Me.D_s, Me.D_d, Me.H_desde, Me.H_hasta, Me.M_desde, Me.M_hasta, Me.F_inicio_vig, Me.F_fin_vig, Me.Ind_especial)
    End Sub

    Public Sub ModificarTarifas(ByVal Ds As DataSet)
        'Me.GuadarDataSet(Ds, "spk_tarifas_tv.sp_UPDATE", False, _
        'Me.Id_tarifa_tv, Me.Id_medio, Me.Id_soporte, _
        'Me.Id_cliente, Me.Programa, Me.D_l, Me.D_m, Me.D_x, Me.D_j, Me.D_v, Me.D_s, Me.D_d, _
        'Me.H_desde, Me.M_desde, Me.H_hasta, Me.M_hasta, Me.F_inicio_vig, Me.F_fin_vig, Me.Ind_especial)
    End Sub

    Public Function Buscar_Id_Tarifa_Carga(ByVal pF_Emision As Date) As Boolean
        Dim ret As Boolean = False
        Try
            Me.TraerUno("spk_" + Tabla + ".SP_SELECT_ID_TARIFA_CARGA", Id_cliente, Id_medio, Id_soporte, pF_Emision, Programa)
        Catch ex As DataReaderVacioExcepcion
            ret = True
        End Try
    End Function

    Public Function Buscar_IdPrograma() As Boolean
        Dim ret As Boolean = False
        Try
            Me.Ejecutar("spk_" + Tabla + ".SP_SELECT_ID_PROGRAMA", Id_medio, Id_soporte, Programa, Id_programa)
        Catch ex As DataReaderVacioExcepcion
            ret = True
        End Try
    End Function

    Public Function Modificar_IdPrograma() As DataSet
        Modificar_IdPrograma = Me.TraerDataSet("spk_" + Tabla + ".SP_UPDATE_ID_PROGRAMA_CARGA", Id_medio, Id_soporte, Id_tarifa_tv, Id_programa)
    End Function

    Public Function TraerTarifasCongeladas() As DataTable
        Try
            TraerTarifasCongeladas = Me.TraerDataSet("spk_tarifas_tv.SP_TARIFAS_CONGELADAS", mId_medio, mId_soporte, mId_cliente, mF_inicio_vig).Tables(0)
        Catch ex As DataReaderVacioExcepcion
            Throw ex
        End Try
    End Function
    'SP_CHEQUEA_TARIFAS_GRILLA
    Public Function ComprobarSoporteVigente() As Integer
        Return MyBase.Ejecutar("spk_tarifas_tv.SP_CHEQUEA_TARIFAS_GRILLA", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.F_inicio_vig, Me.F_fin_vig)
    End Function

    '************* WILLY
    Public Sub ActualizarVigencia(ByVal id_Tarifa As Integer, ByVal f_fin_vig As Date)
        Me.Ejecutar("spk_tarifas_tv.SP_UPDATE_FECHA_VIGENCIA", id_Tarifa, f_fin_vig)
    End Sub

    Public Function BorrarMayores(ByVal id_medio As Integer, ByVal id_soporte As Integer, ByVal id_cliente As Integer, ByVal fecha As Date)
        'SP_DELETE_MAYORVIGENCIA (P_ID_MEDIO IN NUMBER,P_ID_CLIENTE IN NUMBER, P_ID_SOPORTE IN NUMBER, P_F_VIGENCIA IN DATE) 
        Me.Ejecutar("spk_tarifas_tv.SP_DELETE_MAYORVIGENCIA", id_medio, id_cliente, id_soporte, fecha)
    End Function

    Public Function Existe() As Boolean
        Dim ex As Boolean
        ex = Me.TraerDataSet("spk_tarifas_tv.SP_EXISTE", Me.Id_medio, Me.Id_soporte, Me.Id_cliente, Me.Id_tarifa_tv, D_l, D_m, D_x, D_j, D_v, D_s, D_d, Me.H_desde, Me.M_desde, Me.H_hasta, Me.M_hasta, Me.F_inicio_vig, Me.F_fin_vig, Me.Ind_especial).Tables(0).Rows.Count > 0
        Existe = ex
    End Function

    Public Function TraerTodosConVigencia(ByVal fecha As Date) As DataTable
        Return Me.TraerDataSet("spk_tarifas_tv.SP_SELECT_ALL_VIGENCIA", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, fecha).Tables(0)
    End Function

    Public Function TraerTodosConVigencia() As DataTable
        Return Me.TraerDataSet("spk_tarifas_tv.SP_SELECT_CARGA_TARIFA", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.F_inicio_vig).Tables(0)
    End Function
    Public Function TraerTodosDelAño() As DataTable
        Return Me.TraerDataSet("spk_tarifas_tv.SP_SELECT_TARIFA_ALTAS", Me.Id_cliente, Me.Id_medio, Me.Id_soporte).Tables(0)
    End Function

    Public Function TraerTodosSinVigencia() As DataTable
        Return Me.TraerDataSet("spk_tarifas_tv.SP_SELECT_CARGA_TARIFA_TODOS", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.F_inicio_vig).Tables(0)
    End Function

    Public Sub ActualizarTarifas(ByVal ds As DataSet, ByVal Nombre As String, ByVal idCampania As Integer, ByVal IdSistema As Integer, ByVal IDEjercicio As Integer)
        Me.CargarDataSet(ds, Nombre, "spk_tarifas_tv.SP_GRILLA_NUEVA_PROGRAMACION", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, idCampania, IdSistema, IDEjercicio, Me.F_inicio_vig, Me.F_fin_vig)
    End Sub
    Public Function TraerReporteTarifas() As DataTable
        Return Me.TraerDataSet("spk_tarifas_tv.SP_SELECT_TARIFA_PRINT", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.F_inicio_vig, Me.F_fin_vig).Tables(0)
    End Function
    Public Function TraerReporteTarifasPromedio() As DataTable
        Return Me.TraerDataSet("spk_tarifas_tv.SP_SELECT_TARIFA_PROMEDIO", Me.F_inicio_vig, Me.F_fin_vig).Tables(0)
    End Function
    Public Function TraerTarifasCliente() As DataSet
        Return Me.TraerDataSet("spk_tarifas_tv.sp_tarifas_cliente", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.F_inicio_vig, Me.F_fin_vig)
    End Function

    Public Function TraerTarifasSoporteConVigencia(ByVal pId_medio As Short, ByVal pId_Soporte As Long, ByVal pCliente As Long, ByVal F_Aud_Desde As Date, ByVal F_Aud_Hasta As Date, ByVal F_Sis_Desde As Date, ByVal F_Sis_Hasta As Date) As DataSet
        Return Me.TraerDataSet("spk_tarifas_tv.SP_TARIFAS_SOPORTE", pId_medio, pId_Soporte, pCliente, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta)
    End Function
    '****************

    Public Function TraerDiasEmision() As DataTable
        Return Me.TraerDataSet("SPK_TARIFAS_TV.SP_OBTENER_DIAS_EMISION", Me.Id_cliente, Me.Id_medio, Me.Id_soporte, Me.Id_tarifa_tv, Me.F_inicio_vig, Me.F_fin_vig).Tables(0)
    End Function

    'AG  12/06/2014 ===================================================================================
    Public Function ReporteTarifasTvCapital(ByVal Fecha_hasta As Date) As DataTable

        Dim DtTarifas As New DataTable
        Try
            DtTarifas = Me.TraerDataSet("spk_tarifas_tv.TARIFAS_TV_CAPITAL", Fecha_hasta).Tables(0)
        Catch ex As DataReaderVacioExcepcion
            Throw ex
        End Try

        Return DtTarifas

    End Function
    '===============================================================================================

    Public Function TienePautasAsociadas() As DataTable

        Dim DtTarifas As New DataTable
        Try
            DtTarifas = Me.TraerDataSet("spk_tarifas_tv.TIENE_PAUTAS_ASOCIADAS", Id_tarifa_tv).Tables(0)
        Catch ex As DataReaderVacioExcepcion
            Throw ex
        End Try

        Return DtTarifas

    End Function
#End Region

End Class

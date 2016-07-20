Imports MSL
Imports Framework
Public Class Spots
    Inherits Entidad

#Region "Propiedades"
    Dim mId_spot As Int64
    Dim mId_campania As Int32
    Dim mId_sistema As Int32
    Dim mId_ejercicio As Int32
    Dim mId_soporte As Int32
    Dim mId_tarifa_tv As Int64
    Dim mId_programa As Int64
    Dim mPrograma As String
    Dim mH_inicio As Int16
    Dim mM_inicio As Int16
    Dim mH_fin As Int16
    Dim mM_fin As Int16
    Dim mTipo_planificacion As Int16
    Dim mBruto As Double
    Dim mDcto1 As Single
    Dim mDcto2 As Single
    Dim mDcto3 As Single
    Dim mDcto4 As Single
    Dim mDcto5 As Single
    Dim mNeto As Double
    Dim mRat_prog_target_1 As Double
    Dim mShr_prog_target_1 As Double
    Dim mAff_prog_target_1 As Double
    Dim mRch_prog_target_1 As Double
    Dim mRat_m_prog_target_1 As Double
    Dim mFid_prog_target_1 As Double
    Dim mRat_prog_target_2 As Double
    Dim mShr_prog_target_2 As Double
    Dim mAff_prog_target_2 As Double
    Dim mRch_prog_target_2 As Double
    Dim mRat_m_prog_target_2 As Double
    Dim mFid_prog_target_2 As Double
    Dim mRat_tanda_target_1 As Double
    Dim mShr_tanda_target_1 As Double
    Dim mAff_tanda_target_1 As Double
    Dim mRch_tanda_target_1 As Double
    Dim mRat_m_tanda_target_1 As Double
    Dim mFid_tanda_target_1 As Double
    Dim mRat_tanda_target_2 As Double
    Dim mShr_tanda_target_2 As Double
    Dim mAff_tanda_target_2 As Double
    Dim mRch_tanda_target_2 As Double
    Dim mRat_m_tanda_target_2 As Double
    Dim mFid_tanda_target_2 As Double
    Dim mF_alta As DateTime
    Dim mU_alta As String
    Dim mF_modi As DateTime
    Dim mU_modi As String
    Dim mId_convenio As Int64
    Dim mDescCampaña As String
    Dim mDescSistema As String
    Dim mDescEjercicio As String
    Dim mId_Medio As Int32

    Public Property Id_spot() As Int64
        Get
            Return mId_spot
        End Get
        Set(ByVal Value As Int64)
            mId_spot = Value
        End Set
    End Property

    Public Property Id_campania() As Int32
        Get
            Return mId_campania
        End Get
        Set(ByVal Value As Int32)
            mId_campania = Value
        End Set
    End Property

    Public Property Id_sistema() As Int32
        Get
            Return mId_sistema
        End Get
        Set(ByVal Value As Int32)
            mId_sistema = Value
        End Set
    End Property

    Public Property Id_ejercicio() As Int32
        Get
            Return mId_ejercicio
        End Get
        Set(ByVal Value As Int32)
            mId_ejercicio = Value
        End Set
    End Property

    Public Property Id_soporte() As Int32
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Int32)
            mId_soporte = Value
        End Set
    End Property

    Public Property Id_tarifa_tv() As Int64
        Get
            Return mId_tarifa_tv
        End Get
        Set(ByVal Value As Int64)
            mId_tarifa_tv = Value
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

    Public Property Programa() As String
        Get
            Return mPrograma
        End Get
        Set(ByVal Value As String)
            mPrograma = Value
        End Set
    End Property

    Public Property H_inicio() As Int16
        Get
            Return mH_inicio
        End Get
        Set(ByVal Value As Int16)
            mH_inicio = Value
        End Set
    End Property

    Public Property M_inicio() As Int16
        Get
            Return mM_inicio
        End Get
        Set(ByVal Value As Int16)
            mM_inicio = Value
        End Set
    End Property

    Public Property H_fin() As Int16
        Get
            Return mH_fin
        End Get
        Set(ByVal Value As Int16)
            mH_fin = Value
        End Set
    End Property

    Public Property M_fin() As Int16
        Get
            Return mM_fin
        End Get
        Set(ByVal Value As Int16)
            mM_fin = Value
        End Set
    End Property

    Public Property Tipo_planificacion() As Int16
        Get
            Return mTipo_planificacion
        End Get
        Set(ByVal Value As Int16)
            mTipo_planificacion = Value
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

    Public Property Dcto3() As Single
        Get
            Return mDcto3
        End Get
        Set(ByVal Value As Single)
            mDcto3 = Value
        End Set
    End Property

    Public Property Dcto4() As Single
        Get
            Return mDcto4
        End Get
        Set(ByVal Value As Single)
            mDcto4 = Value
        End Set
    End Property

    Public Property Dcto5() As Single
        Get
            Return mDcto5
        End Get
        Set(ByVal Value As Single)
            mDcto5 = Value
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

    Public Property Rat_prog_target_1() As Double
        Get
            Return mRat_prog_target_1
        End Get
        Set(ByVal Value As Double)
            mRat_prog_target_1 = Value
        End Set
    End Property

    Public Property Shr_prog_target_1() As Double
        Get
            Return mShr_prog_target_1
        End Get
        Set(ByVal Value As Double)
            mShr_prog_target_1 = Value
        End Set
    End Property

    Public Property Aff_prog_target_1() As Double
        Get
            Return mAff_prog_target_1
        End Get
        Set(ByVal Value As Double)
            mAff_prog_target_1 = Value
        End Set
    End Property

    Public Property Rch_prog_target_1() As Double
        Get
            Return mRch_prog_target_1
        End Get
        Set(ByVal Value As Double)
            mRch_prog_target_1 = Value
        End Set
    End Property

    Public Property Rat_m_prog_target_1() As Double
        Get
            Return mRat_m_prog_target_1
        End Get
        Set(ByVal Value As Double)
            mRat_m_prog_target_1 = Value
        End Set
    End Property

    Public Property Fid_prog_target_1() As Double
        Get
            Return mFid_prog_target_1
        End Get
        Set(ByVal Value As Double)
            mFid_prog_target_1 = Value
        End Set
    End Property

    Public Property Rat_prog_target_2() As Double
        Get
            Return mRat_prog_target_2
        End Get
        Set(ByVal Value As Double)
            mRat_prog_target_2 = Value
        End Set
    End Property

    Public Property Shr_prog_target_2() As Double
        Get
            Return mShr_prog_target_2
        End Get
        Set(ByVal Value As Double)
            mShr_prog_target_2 = Value
        End Set
    End Property

    Public Property Aff_prog_target_2() As Double
        Get
            Return mAff_prog_target_2
        End Get
        Set(ByVal Value As Double)
            mAff_prog_target_2 = Value
        End Set
    End Property

    Public Property Rch_prog_target_2() As Double
        Get
            Return mRch_prog_target_2
        End Get
        Set(ByVal Value As Double)
            mRch_prog_target_2 = Value
        End Set
    End Property

    Public Property Rat_m_prog_target_2() As Double
        Get
            Return mRat_m_prog_target_2
        End Get
        Set(ByVal Value As Double)
            mRat_m_prog_target_2 = Value
        End Set
    End Property

    Public Property Fid_prog_target_2() As Double
        Get
            Return mFid_prog_target_2
        End Get
        Set(ByVal Value As Double)
            mFid_prog_target_2 = Value
        End Set
    End Property

    Public Property Rat_tanda_target_1() As Double
        Get
            Return mRat_tanda_target_1
        End Get
        Set(ByVal Value As Double)
            mRat_tanda_target_1 = Value
        End Set
    End Property

    Public Property Shr_tanda_target_1() As Double
        Get
            Return mShr_tanda_target_1
        End Get
        Set(ByVal Value As Double)
            mShr_tanda_target_1 = Value
        End Set
    End Property

    Public Property Aff_tanda_target_1() As Double
        Get
            Return mAff_tanda_target_1
        End Get
        Set(ByVal Value As Double)
            mAff_tanda_target_1 = Value
        End Set
    End Property

    Public Property Rch_tanda_target_1() As Double
        Get
            Return mRch_tanda_target_1
        End Get
        Set(ByVal Value As Double)
            mRch_tanda_target_1 = Value
        End Set
    End Property

    Public Property Rat_m_tanda_target_1() As Double
        Get
            Return mRat_m_tanda_target_1
        End Get
        Set(ByVal Value As Double)
            mRat_m_tanda_target_1 = Value
        End Set
    End Property

    Public Property Fid_tanda_target_1() As Double
        Get
            Return mFid_tanda_target_1
        End Get
        Set(ByVal Value As Double)
            mFid_tanda_target_1 = Value
        End Set
    End Property

    Public Property Rat_tanda_target_2() As Double
        Get
            Return mRat_tanda_target_2
        End Get
        Set(ByVal Value As Double)
            mRat_tanda_target_2 = Value
        End Set
    End Property

    Public Property Shr_tanda_target_2() As Double
        Get
            Return mShr_tanda_target_2
        End Get
        Set(ByVal Value As Double)
            mShr_tanda_target_2 = Value
        End Set
    End Property

    Public Property Aff_tanda_target_2() As Double
        Get
            Return mAff_tanda_target_2
        End Get
        Set(ByVal Value As Double)
            mAff_tanda_target_2 = Value
        End Set
    End Property

    Public Property Rch_tanda_target_2() As Double
        Get
            Return mRch_tanda_target_2
        End Get
        Set(ByVal Value As Double)
            mRch_tanda_target_2 = Value
        End Set
    End Property

    Public Property Rat_m_tanda_target_2() As Double
        Get
            Return mRat_m_tanda_target_2
        End Get
        Set(ByVal Value As Double)
            mRat_m_tanda_target_2 = Value
        End Set
    End Property

    Public Property Fid_tanda_target_2() As Double
        Get
            Return mFid_tanda_target_2
        End Get
        Set(ByVal Value As Double)
            mFid_tanda_target_2 = Value
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

    Public Property DescCampaña() As String
        Get
            Return mDescCampaña
        End Get
        Set(ByVal Value As String)
            mDescCampaña = Value
        End Set
    End Property

    Public Property DescSistema() As String
        Get
            Return mDescSistema
        End Get
        Set(ByVal Value As String)
            mDescSistema = Value
        End Set
    End Property

    Public Property DescEjercicio() As String
        Get
            Return mDescEjercicio
        End Get
        Set(ByVal Value As String)
            mDescEjercicio = Value
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
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Spots")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_spot, Id_campania, Id_sistema, Id_ejercicio, Id_soporte, Id_tarifa_tv, Id_programa, Programa, H_inicio, M_inicio, H_fin, M_fin, Tipo_planificacion, Bruto, Dcto1, Dcto2, Dcto3, Dcto4, Dcto5, Neto, Rat_prog_target_1, Shr_prog_target_1, Aff_prog_target_1, Rch_prog_target_1, Rat_m_prog_target_1, Fid_prog_target_1, Rat_prog_target_2, Shr_prog_target_2, Aff_prog_target_2, Rch_prog_target_2, Rat_m_prog_target_2, Fid_prog_target_2, Rat_tanda_target_1, Shr_tanda_target_1, Aff_tanda_target_1, Rch_tanda_target_1, Rat_m_tanda_target_1, Fid_tanda_target_1, Rat_tanda_target_2, Shr_tanda_target_2, Aff_tanda_target_2, Rch_tanda_target_2, Rat_m_tanda_target_2, Fid_tanda_target_2, F_alta, U_alta, F_modi, U_modi, Id_convenio, DescCampaña, DescSistema, DescEjercicio)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_spot, Id_campania, Id_sistema, Id_ejercicio, Id_soporte, Id_tarifa_tv, Id_programa, Programa, H_inicio, M_inicio, H_fin, M_fin, Tipo_planificacion, Bruto, Dcto1, Dcto2, Dcto3, Dcto4, Dcto5, Neto, Rat_prog_target_1, Shr_prog_target_1, Aff_prog_target_1, Rch_prog_target_1, Rat_m_prog_target_1, Fid_prog_target_1, Rat_prog_target_2, Shr_prog_target_2, Aff_prog_target_2, Rch_prog_target_2, Rat_m_prog_target_2, Fid_prog_target_2, Rat_tanda_target_1, Shr_tanda_target_1, Aff_tanda_target_1, Rch_tanda_target_1, Rat_m_tanda_target_1, Fid_tanda_target_1, Rat_tanda_target_2, Shr_tanda_target_2, Aff_tanda_target_2, Rch_tanda_target_2, Rat_m_tanda_target_2, Fid_tanda_target_2, F_alta, U_alta, F_modi, U_modi, Id_convenio, DescCampaña, DescSistema, DescEjercicio)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_spot, Id_campania, Id_sistema, Id_ejercicio, _
        Programa, H_inicio, M_inicio, H_fin, M_fin, Bruto, Dcto1, _
        Dcto2, Dcto3, Dcto4, Dcto5, Rat_prog_target_1, _
        Rat_tanda_target_1, U_modi, F_modi, DescCampaña, DescSistema, DescEjercicio)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_spot)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_spot = IIf(IsDBNull(Dr("Id_spot")), 0, Dr("Id_spot"))
        Me.Id_campania = IIf(IsDBNull(Dr("Id_campania")), 0, Dr("Id_campania"))
        Me.Id_sistema = IIf(IsDBNull(Dr("Id_sistema")), 0, Dr("Id_sistema"))
        Me.Id_ejercicio = IIf(IsDBNull(Dr("Id_ejercicio")), 0, Dr("Id_ejercicio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Id_tarifa_tv = IIf(IsDBNull(Dr("Id_tarifa_tv")), 0, Dr("Id_tarifa_tv"))
        Me.Id_programa = IIf(IsDBNull(Dr("Id_programa")), 0, Dr("Id_programa"))
        Me.Programa = IIf(IsDBNull(Dr("Programa")), "", Dr("Programa"))
        Me.H_inicio = IIf(IsDBNull(Dr("H_inicio")), 0, Dr("H_inicio"))
        Me.M_inicio = IIf(IsDBNull(Dr("M_inicio")), 0, Dr("M_inicio"))
        Me.H_fin = IIf(IsDBNull(Dr("H_fin")), 0, Dr("H_fin"))
        Me.M_fin = IIf(IsDBNull(Dr("M_fin")), 0, Dr("M_fin"))
        Me.Tipo_planificacion = IIf(IsDBNull(Dr("Tipo_planificacion")), 0, Dr("Tipo_planificacion"))
        Me.Bruto = IIf(IsDBNull(Dr("Bruto")), 0, Dr("Bruto"))
        Me.Dcto1 = IIf(IsDBNull(Dr("Dcto1")), 0, Dr("Dcto1"))
        Me.Dcto2 = IIf(IsDBNull(Dr("Dcto2")), 0, Dr("Dcto2"))
        Me.Dcto3 = IIf(IsDBNull(Dr("Dcto3")), 0, Dr("Dcto3"))
        Me.Dcto4 = IIf(IsDBNull(Dr("Dcto4")), 0, Dr("Dcto4"))
        Me.Dcto5 = IIf(IsDBNull(Dr("Dcto5")), 0, Dr("Dcto5"))
        Me.Neto = IIf(IsDBNull(Dr("Neto")), 0, Dr("Neto"))
        Me.Rat_prog_target_1 = IIf(IsDBNull(Dr("Rat_prog_target_1")), 0, Dr("Rat_prog_target_1"))
        Me.Shr_prog_target_1 = IIf(IsDBNull(Dr("Shr_prog_target_1")), 0, Dr("Shr_prog_target_1"))
        Me.Aff_prog_target_1 = IIf(IsDBNull(Dr("Aff_prog_target_1")), 0, Dr("Aff_prog_target_1"))
        Me.Rch_prog_target_1 = IIf(IsDBNull(Dr("Rch_prog_target_1")), 0, Dr("Rch_prog_target_1"))
        Me.Rat_m_prog_target_1 = IIf(IsDBNull(Dr("Rat_m_prog_target_1")), 0, Dr("Rat_m_prog_target_1"))
        Me.Fid_prog_target_1 = IIf(IsDBNull(Dr("Fid_prog_target_1")), 0, Dr("Fid_prog_target_1"))
        Me.Rat_prog_target_2 = IIf(IsDBNull(Dr("Rat_prog_target_2")), 0, Dr("Rat_prog_target_2"))
        Me.Shr_prog_target_2 = IIf(IsDBNull(Dr("Shr_prog_target_2")), 0, Dr("Shr_prog_target_2"))
        Me.Aff_prog_target_2 = IIf(IsDBNull(Dr("Aff_prog_target_2")), 0, Dr("Aff_prog_target_2"))
        Me.Rch_prog_target_2 = IIf(IsDBNull(Dr("Rch_prog_target_2")), 0, Dr("Rch_prog_target_2"))
        Me.Rat_m_prog_target_2 = IIf(IsDBNull(Dr("Rat_m_prog_target_2")), 0, Dr("Rat_m_prog_target_2"))
        Me.Fid_prog_target_2 = IIf(IsDBNull(Dr("Fid_prog_target_2")), 0, Dr("Fid_prog_target_2"))
        Me.Rat_tanda_target_1 = IIf(IsDBNull(Dr("Rat_tanda_target_1")), 0, Dr("Rat_tanda_target_1"))
        Me.Shr_tanda_target_1 = IIf(IsDBNull(Dr("Shr_tanda_target_1")), 0, Dr("Shr_tanda_target_1"))
        Me.Aff_tanda_target_1 = IIf(IsDBNull(Dr("Aff_tanda_target_1")), 0, Dr("Aff_tanda_target_1"))
        Me.Rch_tanda_target_1 = IIf(IsDBNull(Dr("Rch_tanda_target_1")), 0, Dr("Rch_tanda_target_1"))
        Me.Rat_m_tanda_target_1 = IIf(IsDBNull(Dr("Rat_m_tanda_target_1")), 0, Dr("Rat_m_tanda_target_1"))
        Me.Fid_tanda_target_1 = IIf(IsDBNull(Dr("Fid_tanda_target_1")), 0, Dr("Fid_tanda_target_1"))
        Me.Rat_tanda_target_2 = IIf(IsDBNull(Dr("Rat_tanda_target_2")), 0, Dr("Rat_tanda_target_2"))
        Me.Shr_tanda_target_2 = IIf(IsDBNull(Dr("Shr_tanda_target_2")), 0, Dr("Shr_tanda_target_2"))
        Me.Aff_tanda_target_2 = IIf(IsDBNull(Dr("Aff_tanda_target_2")), 0, Dr("Aff_tanda_target_2"))
        Me.Rch_tanda_target_2 = IIf(IsDBNull(Dr("Rch_tanda_target_2")), 0, Dr("Rch_tanda_target_2"))
        Me.Rat_m_tanda_target_2 = IIf(IsDBNull(Dr("Rat_m_tanda_target_2")), 0, Dr("Rat_m_tanda_target_2"))
        Me.Fid_tanda_target_2 = IIf(IsDBNull(Dr("Fid_tanda_target_2")), 0, Dr("Fid_tanda_target_2"))
        Me.F_alta = IIf(IsDBNull(Dr("F_alta")), Nothing, Dr("F_alta"))
        Me.U_alta = IIf(IsDBNull(Dr("U_alta")), "", Dr("U_alta"))
        Me.F_modi = IIf(IsDBNull(Dr("F_modi")), Nothing, Dr("F_modi"))
        Me.U_modi = IIf(IsDBNull(Dr("U_modi")), "", Dr("U_modi"))
        Me.Id_convenio = IIf(IsDBNull(Dr("Id_convenio")), 0, Dr("Id_convenio"))
    End Sub

    Public Overloads Sub ActualizarDataSet(ByVal Ds As DataSet, ByVal NombreTabla As String)
        'Dim Dr As DataRow
        'Dim S As String

        'For Each Dr In Ds.Tables(NombreTabla).GetChanges.Rows
        '    S += Dr("id_spot", DataRowVersion.Original) & " - " & Dr("programa", DataRowVersion.Original) & " - " & Dr.RowState.ToString & vbCrLf
        'Next

        'MsgBox(S)
        'If EsDsDetalle Then
        'MyBase.ActualizarDataSet(Ds, NombreTabla, EsDsDetalle)
        'Else
        MyBase.ActualizarDataSet(Ds, NombreTabla)
        'End If

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
    Public Sub CargarEsquema(ByVal dt As DataTable)
        Me.ObtenerEsquema("spk_spots.sp_select_all", dt)

        Me.AgregarColumnasDescripcion(dt)
    End Sub

    Public Function ObtenerSpots() As DataTable
        Dim Dt As DataTable

        Dt = Me.TraerDataSet("spk_spots.sp_existe", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio).Tables(0)

        If Dt.Columns.Contains("desc_campania") Then
            Return Dt
        End If

        Me.AgregarColumnasDescripcion(Dt)

        Return Dt
    End Function

    Private Sub AgregarColumnasDescripcion(ByVal Dt As DataTable)
        Dt.Columns.Add("desc_campania", GetType(String))
        Dt.Columns.Add("desc_sistema", GetType(String))
        Dt.Columns.Add("desc_ejercicio", GetType(String))
    End Sub

    Public Function ObtenerSoportesGuardados() As DataTable

        'AGuzzardi Modificacion MMS -----------------------------------------------------------------
        Dim DtSoportes As New DataTable
        DtSoportes = Me.TraerDataSet("spk_spots.sp_soportes_guardados", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio).Tables(0)

        Return AnexarSoportesMMS(DtSoportes, Me.Id_Medio)
        '--------------------------------------------------------------------------------------------

        'AGuzzardi Codigo Original -----------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_spots.sp_soportes_guardados", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio, Me.Id_Medio).Tables(0)
        '-------------------------------------------------------------------------------------------------

    End Function

    Public Function TraerPrgSinRelacion() As DataTable
        Return Me.TraerDataSet("spk_spots.sp_Select_Prg_Sin_Relacion").Tables(0)
    End Function
    'SP_CANTIDAD_SPOTS_TARIFAS
    Public Function CantidadSpotsTarifas(ByVal Tarifa As Integer) As Integer
        Return Me.TraerValor("spk_spots.SP_CANTIDAD_SPOTS_TARIFAS", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio, Tarifa)
    End Function

    Public Function ControlConvenio(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal idTema As String, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As Boolean
        'AG Nota: Verifico si para esta ( campania, sistema, ejercicio) tienen todos los convenios aplicados en cada spots de la tabla SPOTS

        Dim dt As DataTable
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO", idCampania, idSistema, idEjercicio, idSoporte, idTema, idMedio, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            Return True ' Si el resultado es MAYOR a CERO ( O ) entonces significa que faltan CONVENIOS en la Tabla SPOTS
        Else
            Return False 'Si el resultado e IGUAL a CERO (0) entonces significa que estan todos lo CONVENIOS en la Tabla SPOTS
        End If
    End Function

    Public Function ControlConveniopr(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As Boolean
        'AG Nota: Verifico si para esta ( campania, sistema, ejercicio) tienen todos los convenios aplicados en cada spots de la tabla SPOTS

        Dim dt As DataTable
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO_PR", idCampania, idSistema, idEjercicio, idSoporte, idMedio, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            Return True ' Si el resultado es MAYOR a CERO ( O ) entonces significa que faltan CONVENIOS en la Tabla SPOTS
        Else
            Return False 'Si el resultado e IGUAL a CERO (0) entonces significa que estan todos lo CONVENIOS en la Tabla SPOTS
        End If
    End Function

    Public Function ControlConvenioInt(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As Boolean
        Dim dt As DataTable
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO_INT", idCampania, idSistema, idEjercicio, idSoporte, idMedio, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            Return True ' Si el resultado es MAYOR a CERO ( O ) entonces significa que faltan CONVENIOS en la Tabla SPOTS
        Else
            Return False 'Si el resultado e IGUAL a CERO (0) entonces significa que estan todos lo CONVENIOS en la Tabla SPOTS
        End If
    End Function




    Public Function ControlConvenioSoportes(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idMedio As Integer) As String
        'AG Nota: Obtengo la descripcion de los soportes que no tienen convenios aplicados

        Dim dt As DataTable
        Dim DtSoporte As DataTable
        Dim DesSoportes As String
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONV_SOPO", idCampania, idSistema, idEjercicio, idMedio).Tables(0)

        If dt.Rows.Count > 0 Then
            DtSoporte = AnexarSoportesMMS(dt, idMedio)
            For Each r As DataRow In DtSoporte.Rows
                DesSoportes += "  " & r("DESCRIPCION") & "  " & vbCrLf
            Next
        Else
            DesSoportes = ""
        End If

        Return DesSoportes

    End Function

    Public Function ControlConvenioVigenciaTVRD(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal idTema As String, ByVal idCliente As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal idProducto As Integer) As DataTable
        'AG Nota: verifico la vigencia del vconvenio con la de la fecha spot
        'AG 17/04/2013
        Dim dt As DataTable
        Dim DtResultado As DataTable
        Dim filtros As New ArrayList

        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO_TVRD_VIG", idCampania, idSistema, idEjercicio, idSoporte, idTema, idMedio, idCliente, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            filtros.Add(idMedio)
            filtros.Add(idProducto)
            DtResultado = AnexarDescripcionMaestros(AnexarDescripcionMaestros(dt, filtros, Activo.CachesMMS.CacheSoportes, "soporte"), filtros, Activo.CachesMMS.CacheMateriales, "material")
        Else
            DtResultado = dt.Clone
        End If
        Return DtResultado
    End Function

    Public Function ControlConvenioVigenciaPRRE(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal idCliente As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal idProducto As Integer) As DataTable
        'AG Nota: verifico la vigencia del vconvenio con la de la fecha spot
        'AG 17/04/2013
        Dim dt As DataTable
        Dim DtResultado As DataTable
        Dim filtros As New ArrayList
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO_PR_VIG", idCampania, idSistema, idEjercicio, idSoporte, idMedio, idCliente, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            filtros.Add(idMedio)
            filtros.Add(idProducto)
            DtResultado = AnexarDescripcionMaestros(AnexarDescripcionMaestros(AnexarDescripcionMaestros(dt, filtros, Activo.CachesMMS.CacheSoportes, "soporte"), filtros, Activo.CachesMMS.CacheMateriales, "material"), filtros, Activo.CachesMMS.CacheSecciones, "seccion")
        Else
            DtResultado = dt.Clone
        End If
        Return DtResultado
        Return dt
    End Function

    Public Function ControlConvenioVigenciaEX(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal idCliente As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal idProducto As Integer) As DataTable
        'AG Nota: verifico la vigencia del vconvenio con la de la fecha spot
        'AG 17/04/2013
        Dim dt As DataTable
        Dim DtResultado As DataTable
        Dim filtros As New ArrayList
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO_EX_VIG", idCampania, idSistema, idEjercicio, idSoporte, idMedio, idCliente, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            filtros.Add(idMedio)
            filtros.Add(idProducto)
            DtResultado = AnexarDescripcionMaestros(AnexarDescripcionMaestros(AnexarDescripcionMaestros(dt, filtros, Activo.CachesMMS.CacheSoportes, "soporte"), filtros, Activo.CachesMMS.CacheMateriales, "material"), filtros, Activo.CachesMMS.CacheProvincia, "provincia", "poblacion")
        Else
            DtResultado = dt.Clone
        End If
        Return DtResultado
        Return dt
    End Function

    Public Function ControlConvenioVigenciaPRO(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal idCliente As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal idProducto As Integer) As DataTable
        'AG Nota: verifico la vigencia del vconvenio con la de la fecha spot
        'AG 17/04/2013
        Dim dt As DataTable
        Dim DtResultado As DataTable
        Dim filtros As New ArrayList
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO_PRO_VIG", idCampania, idSistema, idEjercicio, idSoporte, idMedio, idCliente, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            filtros.Add(idMedio)
            filtros.Add(idProducto)
            DtResultado = AnexarDescripcionMaestros(AnexarDescripcionMaestros(dt, filtros, Activo.CachesMMS.CacheSoportes, "soporte"), filtros, Activo.CachesMMS.CacheProvincia, "provincia", "poblacion")
        Else
            DtResultado = dt.Clone
        End If
        Return DtResultado
        Return dt
    End Function

    Public Function ControlConvenioVigenciaINT(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal idCliente As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal idProducto As Integer) As DataTable
        'AG Nota: verifico la vigencia del vconvenio con la de la fecha spot
        'AG 17/04/2013
        Dim dt As DataTable
        Dim DtResultado As DataTable
        Dim filtros As New ArrayList
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONVENIO_INT_VIG", idCampania, idSistema, idEjercicio, idSoporte, idMedio, idCliente, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            filtros.Add(idMedio)
            'filtros.Add(idProducto)
            DtResultado = AnexarDescripcionMaestros(dt, filtros, Activo.CachesMMS.CacheSoportes, "soporte")
        Else
            DtResultado = dt.Clone
        End If
        Return DtResultado
        Return dt
    End Function

    Public Function ControlClienteConvenio(ByVal idCliente As Integer) As Boolean
        'AG Nota: Verifico en la Tabla CONTROL_CONVENIO_CLIENTE si esta el codigo de cliente, si se encuentra en esa tabla significa que se puede enviar a compras teniendo spots sin CONVENIOS aplicados

        Dim dt As DataTable
        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_CONV_CLIENTE", idCliente).Tables(0)
        If dt.Rows.Count > 0 Then
            Return True 'Puede enviarse a compras para este cliente sin importar que existan convenios no aplicados
        Else
            Return False 'No puede enviarse a compras si existen convenios no aplicados
        End If
    End Function

    Public Function ObtenerSpotsLog(ByVal IdCampaña As Integer, ByVal IdSistema As Integer, ByVal IdEjercicio As Integer, ByVal IdMedio As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots.sp_select_log", IdCampaña, IdSistema, IdEjercicio, IdMedio).Tables(0)
    End Function
#End Region


    Private Function AnexarSoportesMMS(ByVal DtSoportes As DataTable, ByVal IdMedio As Integer) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer
        Dim Dr As DataRow
        Dim DtSoporteFiltro As New DataTable

        DtSoportes.Columns.Add("DESCRIPCION", GetType(String))

        DtSoportes.AcceptChanges()

        For Each r As DataRow In DtSoportes.Rows

            Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & IdMedio)

            For i = 0 To Rows.Length - 1
                r("DESCRIPCION") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next

        DtSoporteFiltro = DtSoportes.DefaultView.ToTable(True, "id_soporte", "descripcion")

        Return DtSoporteFiltro


    End Function

    Public Function ControlConvenioAplicado(ByVal Id_Convenio As Integer) As Boolean

        Dim Dt As DataTable
        Dim Cantidad As Integer

        Cantidad = Me.TraerValor("spk_spots.SP_CONTROL_CONVENIO_SP", Id_Convenio)

        If Cantidad > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function AnexarDescripcionMaestros(ByVal DTBaseDatos As DataTable, ByVal Filtros As ArrayList, ByVal CacheIndex As Integer, ByVal ParamArray Parametros() As Object) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer
        Dim oDatosMaestros As New Maestros

        Select Case CacheIndex
            Case Activo.CachesMMS.CacheSoportes
                For Each r As DataRow In DTBaseDatos.Rows
                    Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & CInt(r("soporte")) & " and " & "ID_MEDIO=" & Filtros(0).ToString())
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CacheProductos
                For Each r As DataRow In DTBaseDatos.Rows
                    Rows = Activo.DTProductosCache.Select("ID_PRODUCTO=" & r("id_producto") & " and " & "ID_CLIENTE=" & r("id_cliente"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CacheMateriales
                For Each r As DataRow In DTBaseDatos.Rows
                    Rows = Activo.DTMaterialesCache.Select("id_medio=" & Filtros(0).ToString() & " and id_material=" & CInt(r("material")) & " and id_producto=" & CInt(Filtros(1).ToString()) & " and id_cliente=" & CInt(Activo.IDCliente))
                    If r("material") = -1 Then
                        r(Parametros(0)) = "Sin Material"
                    End If
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CacheSecciones
                For Each r As DataRow In DTBaseDatos.Rows
                    For Each s As DataRow In Activo.DTSeccionesCache.Rows
                        If r("seccion") = s("id_seccion") Then
                            r(Parametros(0)) = s("DESCRIPCION").ToString
                        End If
                    Next        
                Next
            Case Activo.CachesMMS.CacheProvincia
                For Each r As DataRow In DTBaseDatos.Rows
                    Rows = Activo.DTProvinciaCache.Select("COD_POBL1=" & r("provincia"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("Nom_Pobl1").ToString
                        r(Parametros(1)) = oDatosMaestros.poblaciones2ObtenerAlternativa(Constantes.COD_PAIS_ARGENTINA, CInt(Rows(i).Item("COD_POBL1")), CInt(r("poblacion"))).Rows(0).Item("NOM_POBL2").ToString
                    Next
                Next
        End Select

        DTBaseDatos.AcceptChanges()
        Return DTBaseDatos

    End Function

    Public Function ControlTarifasVigenciaTVRD(ByVal idCampania As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal idSoporte As Integer, ByVal idMedio As Integer, ByVal idCliente As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As DataTable

        'AG 22/07/2017
        Dim dt As DataTable
        Dim DtResultado As DataTable
        Dim filtros As New ArrayList

        dt = Me.TraerDataSet("spk_spots.SP_CONTROL_TARIFAS_TVRD_VIG", idCampania, idSistema, idEjercicio, idSoporte, idMedio, idCliente, FechaDesde, FechaHasta).Tables(0)
        If dt.Rows.Count > 0 Then
            filtros.Add(idMedio)
            DtResultado = AnexarDescripcionMaestros(dt, filtros, Activo.CachesMMS.CacheSoportes, "soporte")
        Else
            DtResultado = dt.Clone
        End If
        Return DtResultado
    End Function

End Class

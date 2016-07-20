Public Class Audiencia_Tva
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Audiencia As Int64
    Dim mId_Plaza As Int16
    Dim mId_Target As Int32
    Dim mF_Programa As DateTime
    Dim mId_Medio As String
    Dim mId_Soporte As Int64
    Dim mId_Programa As Int64
    Dim mPrograma_Tanda As String
    Dim mH_Inicio As String
    Dim mH_Fin As String
    Dim mRat As Double
    Dim mShr As Double
    Dim mAff As Double
    Dim mRch As Double
    Dim mRat_m As Double
    Dim mFid As Double
    Dim mVar07 As Double
    Dim mVar08 As Double
    Dim mVar09 As Double
    Dim mVar10 As Double

    Public Property Id_Audiencia() As Int64
        Get
            Return mId_Audiencia
        End Get
        Set(ByVal Value As Int64)
            mId_Audiencia = Value
        End Set
    End Property

    Public Property Id_Plaza() As Int16
        Get
            Return mId_Plaza
        End Get
        Set(ByVal Value As Int16)
            mId_Plaza = Value
        End Set
    End Property

    Public Property Id_Target() As Int32
        Get
            Return mId_Target
        End Get
        Set(ByVal Value As Int32)
            mId_Target = Value
        End Set
    End Property

    Public Property F_Programa() As DateTime
        Get
            Return mF_Programa
        End Get
        Set(ByVal Value As DateTime)
            mF_Programa = Value
        End Set
    End Property

    Public Property Id_Medio() As String
        Get
            Return mId_Medio
        End Get
        Set(ByVal Value As String)
            mId_Medio = Value
        End Set
    End Property

    Public Property Id_Soporte() As Int64
        Get
            Return mId_Soporte
        End Get
        Set(ByVal Value As Int64)
            mId_Soporte = Value
        End Set
    End Property

    Public Property Id_Programa() As Int64
        Get
            Return mId_Programa
        End Get
        Set(ByVal Value As Int64)
            mId_Programa = Value
        End Set
    End Property

    Public Property Programa_Tanda() As String
        Get
            Return mPrograma_Tanda
        End Get
        Set(ByVal Value As String)
            mPrograma_Tanda = Value
        End Set
    End Property

    Public Property H_Inicio() As String
        Get
            Return mH_Inicio
        End Get
        Set(ByVal Value As String)
            mH_Inicio = Value
        End Set
    End Property

    Public Property H_Fin() As String
        Get
            Return mH_Fin
        End Get
        Set(ByVal Value As String)
            mH_Fin = Value
        End Set
    End Property

    Public Property Rat() As Double
        Get
            Return mRat
        End Get
        Set(ByVal Value As Double)
            mRat = Value
        End Set
    End Property

    Public Property Shr() As Double
        Get
            Return mShr
        End Get
        Set(ByVal Value As Double)
            mShr = Value
        End Set
    End Property

    Public Property Aff() As Double
        Get
            Return mAff
        End Get
        Set(ByVal Value As Double)
            mAff = Value
        End Set
    End Property

    Public Property Rch() As Double
        Get
            Return mRch
        End Get
        Set(ByVal Value As Double)
            mRch = Value
        End Set
    End Property

    Public Property Rat_m() As Double
        Get
            Return mRat_m
        End Get
        Set(ByVal Value As Double)
            mRat_m = Value
        End Set
    End Property

    Public Property Fid() As Double
        Get
            Return mFid
        End Get
        Set(ByVal Value As Double)
            mFid = Value
        End Set
    End Property

    Public Property Var07() As Double
        Get
            Return mVar07
        End Get
        Set(ByVal Value As Double)
            mVar07 = Value
        End Set
    End Property

    Public Property Var08() As Double
        Get
            Return mVar08
        End Get
        Set(ByVal Value As Double)
            mVar08 = Value
        End Set
    End Property

    Public Property Var09() As Double
        Get
            Return mVar09
        End Get
        Set(ByVal Value As Double)
            mVar09 = Value
        End Set
    End Property

    Public Property Var10() As Double
        Get
            Return mVar10
        End Get
        Set(ByVal Value As Double)
            mVar10 = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Audiencia_TVA")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_audiencia, Id_plaza, Id_target, F_programa, Id_medio, Id_soporte, Id_programa, Programa_tanda, H_inicio, H_fin, Rat, Shr, Aff, Rch, Rat_m, Fid, Var07, Var08, Var09, Var10)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_audiencia, Id_plaza, Id_target, F_programa, Id_medio, Id_soporte, Id_programa, Programa_tanda, H_inicio, H_fin, Rat, Shr, Aff, Rch, Rat_m, Fid, Var07, Var08, Var09, Var10)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_audiencia)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_audiencia)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_audiencia = IIf(IsDBNull(Dr("Id_audiencia")), 0, Dr("Id_audiencia"))
        Me.Id_plaza = IIf(IsDBNull(Dr("Id_plaza")), 0, Dr("Id_plaza"))
        Me.Id_target = IIf(IsDBNull(Dr("Id_target")), 0, Dr("Id_target"))
        Me.F_programa = IIf(IsDBNull(Dr("F_programa")), Nothing, Dr("F_programa"))
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), "", Dr("Id_medio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Id_programa = IIf(IsDBNull(Dr("Id_programa")), 0, Dr("Id_programa"))
        Me.Programa_tanda = IIf(IsDBNull(Dr("Programa_tanda")), "", Dr("Programa_tanda"))
        Me.H_inicio = IIf(IsDBNull(Dr("H_inicio")), "", Dr("H_inicio"))
        Me.H_fin = IIf(IsDBNull(Dr("H_fin")), "", Dr("H_fin"))
        Me.Rat = IIf(IsDBNull(Dr("Rat")), 0, Dr("Rat"))
        Me.Shr = IIf(IsDBNull(Dr("Shr")), 0, Dr("Shr"))
        Me.Aff = IIf(IsDBNull(Dr("Aff")), 0, Dr("Aff"))
        Me.Rch = IIf(IsDBNull(Dr("Rch")), 0, Dr("Rch"))
        Me.Rat_m = IIf(IsDBNull(Dr("Rat_m")), 0, Dr("Rat_m"))
        Me.Fid = IIf(IsDBNull(Dr("Fid")), 0, Dr("Fid"))
        Me.Var07 = IIf(IsDBNull(Dr("Var07")), 0, Dr("Var07"))
        Me.Var08 = IIf(IsDBNull(Dr("Var08")), 0, Dr("Var08"))
        Me.Var09 = IIf(IsDBNull(Dr("Var09")), 0, Dr("Var09"))
        Me.Var10 = IIf(IsDBNull(Dr("Var10")), 0, Dr("Var10"))
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
    Public Sub ObteniendoAudienciaTVA(ByVal Ds As DataSet, ByVal NombreTabla As String, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Target1 As Int32, ByVal Target2 As Int32)
        Me.CargarDataSet(Ds, NombreTabla, "spk_Audiencia_tva.SP_SELECT_PROMEDIO", Me.Id_Soporte, Me.Id_Medio, FechaInicio, FechaFin, Target1, Target2)
    End Sub

    Public Function ObtenerAudienciaTVA(ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Target1 As Int32, ByVal Target2 As Int32) As DataTable
        Return Me.TraerDataSet("spk_Audiencia_tva.SP_SELECT_PROMEDIO", Me.Id_Soporte, Me.Id_Medio, FechaInicio, FechaFin, Target1, Target2).Tables(0)
    End Function

    Public Sub BorrarDatos_Carga(ByVal Desde As Date, ByVal Hasta As Date)
        Ejecutar("spk_" + Tabla + ".sp_delete_Datos_Carga", Id_Plaza, Id_Target, Id_Medio, desde, hasta)
    End Sub

    Public Function ObtenerDetalleAudienciaTVA(ByVal IdMedio As Integer, ByVal IdSoporte As Integer, ByVal IdPrograma As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal IdTarget As Integer, ByVal ProgramaTanda As String) As DataTable
        Return MyBase.TraerDataSet("spk_Audiencia_tva.SP_CONSULTA_PROMEDIO_DIA", IdMedio, IdSoporte, IdPrograma, _
        FechaInicio, FechaFin, IdTarget, ProgramaTanda).Tables(0)
    End Function
    Public Function ObtenerRatingReal(ByVal IdMedio As Integer, ByVal IdSoporte As Integer, ByVal IdPrograma As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal IdTarget As Integer, ByVal ProgramaTanda As String) As Single
        Return IIf(IsDBNull(MyBase.Ejecutar("spk_Audiencia_tva.SP_CONSULTA_PROGRAMA_REAL", IdMedio, IdSoporte, IdPrograma, FechaInicio, FechaFin, IdTarget, ProgramaTanda)) = True, 0, MyBase.Ejecutar("spk_Audiencia_tva.SP_CONSULTA_PROGRAMA_REAL", IdMedio, IdSoporte, IdPrograma, FechaInicio, FechaFin, IdTarget, ProgramaTanda))

    End Function

    Public Sub ObtenerHoraIniFinPrg()
        Try
            Me.TraerUno("spk_" & Tabla & ".sp_select_HoraIniFin", Id_Medio, Id_Soporte, Id_Programa, F_Programa)
        Catch ex As DataReaderVacioExcepcion
            mH_Inicio = ""
            mH_Fin = ""
        End Try
    End Sub

    Public Function TraerAudienciaParaMatcheo(ByVal fdesde As Date, ByVal fhasta As Date) As DataTable
        Return MyBase.TraerDataSet("spk_Audiencia_tva.SP_SELECT_MATCHEO", Id_Medio, Id_Soporte, fdesde, fhasta, Id_Programa).Tables(0)
    End Function
#End Region

End Class

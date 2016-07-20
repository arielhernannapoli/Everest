Public Class Audiencia_TVI
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Audiencia As Int64
    Dim mId_Plaza As Int16
    Dim mF_Programa As DateTime
    Dim mId_Medio As Int16
    Dim mId_Soporte As Int64
    Dim mId_Tarifa_TV As Int64
    Dim mH_Inicio As String
    Dim mH_Fin As String
    Dim mId_Target_1 As Int32
    Dim mRat_1 As Double
    Dim mId_Target_2 As Int32
    Dim mRat_2 As Double

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

    Public Property F_Programa() As DateTime
        Get
            Return mF_Programa
        End Get
        Set(ByVal Value As DateTime)
            mF_Programa = Value
        End Set
    End Property

    Public Property Id_Medio() As Int16
        Get
            Return mId_Medio
        End Get
        Set(ByVal Value As Int16)
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

    Public Property Id_Tarifa_TV() As Int64
        Get
            Return mId_Tarifa_TV
        End Get
        Set(ByVal Value As Int64)
            mId_Tarifa_TV = Value
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

    Public Property Id_Target_1() As Int32
        Get
            Return mId_Target_1
        End Get
        Set(ByVal Value As Int32)
            mId_Target_1 = Value
        End Set
    End Property

    Public Property Rat_1() As Double
        Get
            Return mRat_1
        End Get
        Set(ByVal Value As Double)
            mRat_1 = Value
        End Set
    End Property

    Public Property Id_Target_2() As Int32
        Get
            Return mId_Target_2
        End Get
        Set(ByVal Value As Int32)
            mId_Target_2 = Value
        End Set
    End Property

    Public Property Rat_2() As Double
        Get
            Return mRat_2
        End Get
        Set(ByVal Value As Double)
            mRat_2 = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Audiencia_TVI")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_Plaza, F_Programa, Id_Medio, Id_Soporte, Id_Tarifa_TV, H_Inicio, H_Fin, Id_Target_1, Rat_1, Id_Target_2, Rat_2)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_audiencia, Id_plaza, F_programa, Id_medio, Id_soporte, Id_tarifa_tv, H_inicio, H_fin, Id_target_1, Rat_1, Id_target_2, Rat_2)
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
        Me.F_programa = IIf(IsDBNull(Dr("F_programa")), Nothing, Dr("F_programa"))
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Id_tarifa_tv = IIf(IsDBNull(Dr("Id_tarifa_tv")), 0, Dr("Id_tarifa_tv"))
        Me.H_inicio = IIf(IsDBNull(Dr("H_inicio")), "", Dr("H_inicio"))
        Me.H_fin = IIf(IsDBNull(Dr("H_fin")), "", Dr("H_fin"))
        Me.Id_target_1 = IIf(IsDBNull(Dr("Id_target_1")), 0, Dr("Id_target_1"))
        Me.Rat_1 = IIf(IsDBNull(Dr("Rat_1")), 0, Dr("Rat_1"))
        Me.Id_target_2 = IIf(IsDBNull(Dr("Id_target_2")), 0, Dr("Id_target_2"))
        Me.Rat_2 = IIf(IsDBNull(Dr("Rat_2")), 0, Dr("Rat_2"))
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
    Public Sub BorrarAudiencia(ByVal Id_Tarifa_TV As Integer, ByVal desde As Date, ByVal hasta As Date)
        Ejecutar("Spk_" & MyBase.Tabla & ".sp_delete_fecha", Id_Plaza, Id_Medio, Id_Soporte, Id_Tarifa_TV, Id_Target_1, Id_Target_2, desde, hasta)
    End Sub

    Public Function ObtenerAudienciaTVI(ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Target1 As Int32, ByVal Target2 As Int32) As DataTable
        Return Me.TraerDataSet("spk_Audiencia_tvi.SP_SELECT_PROMEDIO_TVI", Me.Id_Soporte, Me.Id_Medio, FechaInicio, FechaFin, Target1, Target2).Tables(0)
    End Function

    Public Sub ObteniendoAudienciaTVI(ByVal Ds As DataSet, ByVal NombreTabla As String, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Target1 As Int32, ByVal Target2 As Int32)
        Me.CargarDataSet(Ds, NombreTabla, "spk_Audiencia_tvi.SP_SELECT_PROMEDIO_TVI", Me.Id_Soporte, Me.Id_Medio, FechaInicio, FechaFin, Target1, Target2)
    End Sub

    Public Function ObtenerDetalleAudienciaTVA(ByVal IdMedio As Integer, ByVal IdSoporte As Integer, ByVal IdPrograma As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal IdTarget As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_Audiencia_tvi.SP_CONSULTA_PROMEDIO_DIA", IdMedio, IdSoporte, IdPrograma, _
        FechaInicio, FechaFin, IdTarget).Tables(0)
    End Function

    Public Function ObtenerRatingReal(ByVal IdMedio As Integer, ByVal IdSoporte As Integer, ByVal IdTarifa As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal IdTarget As Integer) As Single
        ' Return MyBase.TraerDataSet("spk_Audiencia_tva.SP_CONSULTA_PROMEDIO_DIA", IdMedio, IdSoporte, IdPrograma, _
        ' FechaInicio, FechaFin, IdTarget, ProgramaTanda).Tables(0)
        Return IIf(IsDBNull(MyBase.Ejecutar("spk_Audiencia_tvi.SP_CONSULTA_PROGRAMA_REAL", IdMedio, IdSoporte, IdTarifa, FechaInicio, FechaFin, IdTarget)), 0, MyBase.Ejecutar("spk_Audiencia_tvi.SP_CONSULTA_PROGRAMA_REAL", IdMedio, IdSoporte, IdTarifa, FechaInicio, FechaFin, IdTarget))
    End Function
#End Region

End Class

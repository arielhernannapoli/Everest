Imports Framework

Public Class Programas
    Inherits Entidad

#Region "Propiedades"
    Dim mId_programa As Int64
    Dim mId_medio As Int16
    Dim mId_soporte As Int64
    Dim mDescripcion As String
    Dim mId_programa_monitor As String
    Dim mMarca As String

    Public Property Id_programa() As Int64
        Get
            Return mId_programa
        End Get
        Set(ByVal Value As Int64)
            mId_programa = Value
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

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property

    Public Property Id_programa_monitor() As String
        Get
            Return mId_programa_monitor
        End Get
        Set(ByVal Value As String)
            mId_programa_monitor = Value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return mMarca
        End Get
        Set(ByVal Value As String)
            mMarca = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Programas")
    End Sub

    Public Overloads Function Agregar() As Object
        Agregar = MyBase.Agregar(Id_medio, Id_soporte, Descripcion, Id_programa_monitor, Marca, Id_programa)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_programa, Id_medio, Id_soporte, Descripcion, Id_programa_monitor, Marca)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_programa)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_programa)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_programa = IIf(IsDBNull(Dr("Id_programa")), 0, Dr("Id_programa"))
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Id_programa_monitor = IIf(IsDBNull(Dr("Id_programa_monitor")), "", Dr("Id_programa_monitor"))
        Me.Marca = IIf(IsDBNull(Dr("Marca")), "", Dr("Marca"))
    End Sub

    Public Overloads Sub ActualizarDataSet(ByVal Ds As DataSet, ByVal NombreTabla As String)
        MyBase.ActualizarDataSet(Ds, NombreTabla)
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
    Public Function BuscarAgregarMonitor() As Boolean
        Dim ret As Boolean

        ret = False
        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select_programa_monitor", Id_programa_monitor)
        Catch ex As DataReaderVacioExcepcion ' si no esta, lo agrego
            Agregar()
            ret = True
        End Try
        BuscarAgregarMonitor = ret
    End Function

    Public Function BuscarAgregar() As Long
        Dim ret As Boolean = False

        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select_id_programa", Id_soporte, Descripcion)
        Catch ex As DataReaderVacioExcepcion ' si no esta, lo agrego
            mId_programa = Agregar() ' traigo el sequence correspondiente al recien insertado.
            ret = True
        End Try
        BuscarAgregar = ret
    End Function

    Public Function BuscarProgramasMarcados(ByVal IdMedio As Integer) As DataTable
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".sp_select_all_Marcados", IdMedio).Tables(0)
    End Function

    Public Function LlenarGrillaProgramas() As DataTable
        'AG agregar soporte Enlace_MMS -------------------------------------------------------------------------------------
        Dim OGAdmin As New GrillAdmin
        Return OGAdmin.AnexarSoportesMMS(MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".sp_select_all_NoMarcados").Tables(0), "Descripcion_soporte", -1)
        '-------------------------------------------------------------------------------------------------------------------

        'AGuzzardi codigo Original -----------------------------------------------------------------
        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".sp_select_all_NoMarcados").Tables(0)
        '-------------------------------------------------------------------------------------------
    End Function

    '************* WILLY
    Public Function TraerIDDescripcion(ByVal id_medio As Integer, ByVal id_soporte As Integer) As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_PROGRAMAS_DESCRIPCION", id_medio, id_soporte).Tables(0)
    End Function

    Public Function TraerPrgSugeridosPorSop() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_MATCHEO_PROGSUG", Id_medio, Id_soporte, Descripcion).Tables(0)
    End Function

    Public Function TraerPrgPorSop() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_MATCHEO_PROGALL", Id_medio, Id_soporte).Tables(0)
    End Function

#End Region

End Class


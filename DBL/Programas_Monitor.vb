Public Class Programas_Monitor
    Inherits Entidad

#Region "Propiedades"
    Dim mF_Emision As DateTime
    Dim mCadena_Monitor As String
    Dim mPlaza_Monitor As String
    Dim mId_Programa_Monitor As String
    Dim mHoinprog As Int32
    Dim mCanal_Monitor As String
    Dim mDescripcion As String
    Dim mHoFiProg As Int32
    Dim mTipoVehic As String

    Public Property F_Emision() As DateTime
        Get
            Return mF_Emision
        End Get
        Set(ByVal Value As DateTime)
            mF_Emision = Value
        End Set
    End Property

    Public Property Cadena_Monitor() As String
        Get
            Return mCadena_Monitor
        End Get
        Set(ByVal Value As String)
            mCadena_Monitor = Value
        End Set
    End Property

    Public Property Plaza_Monitor() As String
        Get
            Return mPlaza_Monitor
        End Get
        Set(ByVal Value As String)
            mPlaza_Monitor = Value
        End Set
    End Property

    Public Property Id_programa_Monitor() As String
        Get
            Return mId_Programa_Monitor
        End Get
        Set(ByVal Value As String)
            mId_Programa_Monitor = Value
        End Set
    End Property

    Public Property HoInProg() As Int32
        Get
            Return mHoinprog
        End Get
        Set(ByVal Value As Int32)
            mHoinprog = Value
        End Set
    End Property

    Public Property Canal_Monitor() As String
        Get
            Return mCanal_Monitor
        End Get
        Set(ByVal Value As String)
            mCanal_Monitor = Value
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

    Public Property HoFiProg() As Int32
        Get
            Return mHoFiProg
        End Get
        Set(ByVal Value As Int32)
            mHoFiProg = Value
        End Set
    End Property

    Public Property TipoVehic() As String
        Get
            Return mTipoVehic
        End Get
        Set(ByVal Value As String)
            mTipoVehic = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Programas_Monitor")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(F_emision, Cadena_monitor, Plaza_monitor, Id_programa_monitor, Hoinprog, Canal_monitor, Descripcion, Hofiprog, Tipovehic)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(F_emision, Cadena_monitor, Plaza_monitor, Id_programa_monitor, Hoinprog, Canal_monitor, Descripcion, Hofiprog, Tipovehic)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(F_emision)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    'Public Overloads Sub BuscarPorID()
    '    MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", F_emision)
    'End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.F_emision = IIf(IsDBNull(Dr("F_emision")), Nothing, Dr("F_emision"))
        Me.Cadena_monitor = IIf(IsDBNull(Dr("Cadena_monitor")), "", Dr("Cadena_monitor"))
        Me.Plaza_monitor = IIf(IsDBNull(Dr("Plaza_monitor")), "", Dr("Plaza_monitor"))
        Me.Id_programa_monitor = IIf(IsDBNull(Dr("Id_programa_monitor")), "", Dr("Id_programa_monitor"))
        Me.Hoinprog = IIf(IsDBNull(Dr("Hoinprog")), 0, Dr("Hoinprog"))
        Me.Canal_monitor = IIf(IsDBNull(Dr("Canal_monitor")), "", Dr("Canal_monitor"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Hofiprog = IIf(IsDBNull(Dr("Hofiprog")), 0, Dr("Hofiprog"))
        Me.Tipovehic = IIf(IsDBNull(Dr("Tipovehic")), "", Dr("Tipovehic"))
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

    Public Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".SP_SELECT", F_Emision, Cadena_Monitor, Plaza_Monitor, Id_programa_Monitor, HoInProg)
    End Sub

    Public Sub BuscarAgregar()
        Try
            BuscarPorID()
        Catch ex As DataReaderVacioExcepcion
            Agregar()
        End Try
    End Sub

    Public Function TraerProgramasParaMatcheo(ByVal fdesde As Date, ByVal fhasta As Date) As DataTable
        Return MyBase.TraerDataSet("spk_Programas_Monitor.SP_SELECT_MATCHEO", Id_programa_Monitor, Plaza_Monitor, fdesde, fhasta).Tables(0)
    End Function

#End Region

End Class

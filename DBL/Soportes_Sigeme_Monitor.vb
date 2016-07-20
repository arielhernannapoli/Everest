Public Class Soportes_sigeme_monitor
    Inherits Entidad

#Region "Propiedades"
    Dim mId_medio As Int16
    Dim mId_soporte As Int16
    Dim mCadena_monitor As String
    Dim mPlaza_monitor As String

    Public Property Id_medio() As Int16
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Int16)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_soporte() As Int16
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Int16)
            mId_soporte = Value
        End Set
    End Property

    Public Property Cadena_monitor() As String
        Get
            Return mCadena_monitor
        End Get
        Set(ByVal Value As String)
            mCadena_monitor = Value
        End Set
    End Property

    Public Property Plaza_monitor() As String
        Get
            Return mPlaza_monitor
        End Get
        Set(ByVal Value As String)
            mPlaza_monitor = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Soportes_Sigeme_Monitor")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_medio, Id_soporte, Cadena_monitor, Plaza_monitor)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_medio, Id_soporte, Cadena_monitor, Plaza_monitor)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_medio)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_medio)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Cadena_monitor = IIf(IsDBNull(Dr("Cadena_monitor")), "", Dr("Cadena_monitor"))
        Me.Plaza_monitor = IIf(IsDBNull(Dr("Plaza_monitor")), "", Dr("Plaza_monitor"))
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
    Public Function Select_Cadena_Plaza()
        Dim ret As Boolean = True

        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".SP_SELECT_CADENA_PLAZA", Cadena_monitor, Plaza_monitor)
        Catch ex As DataReaderVacioExcepcion
            ret = False
        End Try

        Select_Cadena_Plaza = ret
    End Function

    Public Function Select_Medio_Soporte() As Boolean
        Dim ret As Boolean = True

        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".SP_SELECT_MEDIO_SOPORTE", Id_medio, Id_soporte)
        Catch ex As Exception
            ret = False
        End Try

        Select_Medio_Soporte = ret
    End Function

#End Region

End Class

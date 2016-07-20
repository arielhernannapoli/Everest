Public Class Soportes_sigeme_telereport
    Inherits Entidad

#Region "Propiedades"
    Dim mId_medio As Int16
    Dim mId_soporte As Int16
    Dim mId_soporte_telereport As String

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

    Public Property Id_soporte_telereport() As String
        Get
            Return mId_soporte_telereport
        End Get
        Set(ByVal Value As String)
            mId_soporte_telereport = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Soportes_Sigeme_Telereport")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_medio, Id_soporte, Id_soporte_telereport)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_medio, Id_soporte, Id_soporte_telereport)
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
        Me.Id_soporte_telereport = IIf(IsDBNull(Dr("Id_soporte_telereport")), "", Dr("Id_soporte_telereport"))
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
    Public Function BuscarPorDescripcion()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".SP_SELECT_SOPORTE_TELEREPORT", mId_soporte_telereport)
    End Function
#End Region

End Class

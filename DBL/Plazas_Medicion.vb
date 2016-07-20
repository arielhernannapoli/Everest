Public Class Plazas_Medicion
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Plaza As Int32
    Dim mMedicion As String

    Public Property Id_Plaza() As Int32
        Get
            Return mId_Plaza
        End Get
        Set(ByVal Value As Int32)
            mId_Plaza = Value
        End Set
    End Property

    Public Property Medicion() As String
        Get
            Return mMedicion
        End Get
        Set(ByVal Value As String)
            mMedicion = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Plazas_Medicion")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_plaza, Medicion)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_plaza, Medicion)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_plaza)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_Plaza)
        Catch ex As DataReaderVacioExcepcion
            Me.Id_Plaza = -1
        End Try

    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_plaza = IIf(IsDBNull(Dr("Id_plaza")), 0, Dr("Id_plaza"))
        Me.Medicion = IIf(IsDBNull(Dr("Medicion")), "", Dr("Medicion"))
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
#End Region

End Class

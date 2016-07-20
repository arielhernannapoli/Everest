Public Class Targets_telereport
    Inherits Entidad

#Region "Propiedades"
    Dim mId_target As Int32
    Dim mDescripcion As String

    Public Property Id_target() As Int32
        Get
            Return mId_target
        End Get
        Set(ByVal Value As Int32)
            mId_target = Value
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
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Targets_Telereport")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_target, Descripcion)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_target, Descripcion)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_target)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_target)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_target = IIf(IsDBNull(Dr("Id_target")), 0, Dr("Id_target"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
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
    Public Overloads Sub BuscarAgregar()
        Dim ret As Boolean

        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select_descripcion", Descripcion)
        Catch ex As DataReaderVacioExcepcion
            Agregar()
        End Try
    End Sub
#End Region

End Class

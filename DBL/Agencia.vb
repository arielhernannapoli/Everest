Public Class Agencia
    Inherits Entidad

    Dim mAgencia As Short
    Dim mNombre As String = ""

    Sub New()
        MyBase.New("Agencias")
    End Sub

    Public Property Agencia() As Short
        Get
            Return mAgencia
        End Get
        Set(ByVal Value As Short)
            mAgencia = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal Value As String)
            mNombre = Value
        End Set
    End Property

    Public Overloads Function Agregar() As Object
        'lanzamos excepciones propias para comunicarnos con la Vista
        If Me.Agencia = 0 Then
            Throw New PropiedadVaciaExcepcion("Debe Ingresar el Código de Agencia")
        End If

        If Me.Nombre = "" Then
            Throw New PropiedadVaciaExcepcion("Debe Ingresar el Nombre de la Agencia")
        End If

        Try
            MyBase.Agregar(Me.Agencia, Me.Nombre)
        Catch ex As BaseDatosExcepcion
            'podes tambien manejar una excepcion de base de datos, etc.
        Catch ex As Exception
            Throw ex 'pasa cualquier otra excepcion a la Vista
        End Try
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Me.Agencia, Me.Nombre)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Me.Agencia)
    End Function
    Public Overloads Function TraerTablas() As DataTable
        Return MyBase.EjecutarSQL("select * from user_tables").Tables(0)
    End Function
    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("spk_" & MyBase.Tabla & ".sp_select", Me.Agencia)
    End Sub

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Public Overloads Sub ActualizarDataSet(ByVal Ds As DataSet, ByVal Tabla As String)
        MyBase.ActualizarDataSet(Ds, Tabla)
    End Sub

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Agencia = Dr("Agencia")
        Me.Nombre = Dr("Nombre")
    End Sub

End Class

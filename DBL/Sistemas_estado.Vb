Public Class Sistemas_estado
Inherits Entidad

#Region "Propiedades"
	Dim mId_sistema_est As Int16
	Dim mDescripcion As String
	Dim mColor As Int64
	Dim mOk As Int16

	Public Property Id_sistema_est() AS Int16
		Get
			Return mId_sistema_est
		End Get
		Set(ByVal Value as Int16)
			mId_sistema_est= Value
		End Set
	End Property

	Public Property Descripcion() AS String
		Get
			Return mDescripcion
		End Get
		Set(ByVal Value as String)
			mDescripcion= Value
		End Set
	End Property

	Public Property Color() AS Int64
		Get
			Return mColor
		End Get
		Set(ByVal Value as Int64)
			mColor= Value
		End Set
	End Property

	Public Property Ok() AS Int16
		Get
			Return mOk
		End Get
		Set(ByVal Value as Int16)
			mOk= Value
		End Set
	End Property
#End Region

#Region "Funciones Comunes"
	Sub New()
		MyBase.New("Sistemas_estado")
	End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_sistema_est, Descripcion, Color, Ok)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_sistema_est, Descripcion, Color, Ok)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_sistema_est)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_sistema_est)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_sistema_est = Dr("Id_sistema_est")
        Me.Descripcion = Dr("Descripcion")
        Me.Color = Dr("Color")
        Me.Ok = Dr("Ok")
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

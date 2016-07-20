Public Class Ejercicios_estado
Inherits Entidad

#Region "Propiedades"
	Dim mId_ejercicio_est As Int16
	Dim mDescripcion As String
	Dim mColor As Int64
	Dim mOk As Int16

	Public Property Id_ejercicio_est() AS Int16
		Get
			Return mId_ejercicio_est
		End Get
		Set(ByVal Value as Int16)
			mId_ejercicio_est= Value
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
		MyBase.New("Ejercicios_estado")
	End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_ejercicio_est, Descripcion, Color, Ok)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_ejercicio_est, Descripcion, Color, Ok)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_ejercicio_est)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_ejercicio_est)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_ejercicio_est = IIf(IsDBNull(Dr("Id_ejercicio_est")), 0, Dr("Id_ejercicio_est"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Color = IIf(IsDBNull(Dr("Color")), 0, Dr("Color"))
        Me.Ok = IIf(IsDBNull(Dr("Ok")), 0, Dr("Ok"))
    End Sub

    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
    End Function
#End Region

#Region "Funciones Propias"
#End Region

End Class

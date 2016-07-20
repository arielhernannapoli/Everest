Public Class Targets
    Inherits Entidad
    Implements IDisposable

#Region "Propiedades"
	Dim mId_target As Int64
	Dim mDescripcion As String

	Public Property Id_target() AS Int64
		Get
			Return mId_target
		End Get
		Set(ByVal Value as Int64)
			mId_target= Value
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
#End Region

#Region "Funciones Comunes"
	Sub New()
		MyBase.New("Targets")
	End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_target, Descripcion)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_target, Descripcion)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_target)
    End Function

    Public Overloads Function TraerTodos(ByVal IDTipoSoporte As Short) As DataTable
        Return MyBase.TraerTodos(IDTipoSoporte)
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_target)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Procedimiento, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_target = Dr("Id_target")
        Me.Descripcion = Dr("Descripcion")
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
    Public Function TraetTargetsIbope(ByVal TipoSoporte As Integer) As DataTable
        Return MyBase.TraerDataSet("SPK_TARGETS.SP_SELECT_TARGETS", TipoSoporte).Tables(0)

    End Function

    Public Function ObtenerTargetReporteCPR(ByVal IdTarget As Integer) As DataTable
        Return MyBase.TraerDataSet("SPK_TARGETS.SP_SELECT_TARGET_CPR", IdTarget).Tables(0)
    End Function

#End Region

    Public Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class

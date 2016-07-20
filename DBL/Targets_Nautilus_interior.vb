Public Class Targets_Nautilus_Interior
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Target As Int64
    Dim mId_Target_nautilus As Int32

    Public Property Id_Target() As Int64
        Get
            Return mId_Target
        End Get
        Set(ByVal Value As Int64)
            mId_Target = Value
        End Set
    End Property

    Public Property Id_Target_Nautilus() As Int32
        Get
            Return mId_Target_nautilus
        End Get
        Set(ByVal Value As Int32)
            mId_Target_nautilus = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Targets_Nautilus_Interior")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_target, Id_target_nautilus)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_target, Id_target_nautilus)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_target)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_Target_Nautilus)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_target = IIf(IsDBNull(Dr("Id_target")), 0, Dr("Id_target"))
        Me.Id_target_nautilus = IIf(IsDBNull(Dr("Id_target_nautilus")), 0, Dr("Id_target_nautilus"))
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
    Public Overloads Sub BuscarPorTarget()
        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select_Target", Id_Target)
        Catch ex As DataReaderVacioExcepcion
            mId_Target_nautilus = -1
        End Try

    End Sub
#End Region

End Class

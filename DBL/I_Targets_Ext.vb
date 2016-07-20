Public Class I_Targets_Ext
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Consulta As Int32
    Dim mId_Trgt As Int32

    Public Property Id_Consulta() As Int32
        Get
            Return mId_Consulta
        End Get
        Set(ByVal Value As Int32)
            mId_Consulta = Value
        End Set
    End Property

    Public Property Id_Trgt() As Int32
        Get
            Return mId_Trgt
        End Get
        Set(ByVal Value As Int32)
            mId_Trgt = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("I_Targets_Ext")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_consulta, Id_trgt)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_consulta, Id_trgt)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_consulta)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_consulta)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_consulta = IIf(IsDBNull(Dr("Id_consulta")), 0, Dr("Id_consulta"))
        Me.Id_trgt = IIf(IsDBNull(Dr("Id_trgt")), 0, Dr("Id_trgt"))
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

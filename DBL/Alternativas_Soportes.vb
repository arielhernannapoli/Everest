Public Class Alternativas_soportes
    Inherits Entidad

#Region "Propiedades"
    Dim mId_campania As Int32
    Dim mId_alternativa As Int32
    Dim mId_sistema As Int32
    Dim mId_ejercicio As Int32
    Dim mId_soporte As Int32

    Public Property Id_campania() As Int32
        Get
            Return mId_campania
        End Get
        Set(ByVal Value As Int32)
            mId_campania = Value
        End Set
    End Property

    Public Property Id_alternativa() As Int32
        Get
            Return mId_alternativa
        End Get
        Set(ByVal Value As Int32)
            mId_alternativa = Value
        End Set
    End Property

    Public Property Id_sistema() As Int32
        Get
            Return mId_sistema
        End Get
        Set(ByVal Value As Int32)
            mId_sistema = Value
        End Set
    End Property

    Public Property Id_ejercicio() As Int32
        Get
            Return mId_ejercicio
        End Get
        Set(ByVal Value As Int32)
            mId_ejercicio = Value
        End Set
    End Property

    Public Property Id_soporte() As Int32
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Int32)
            mId_soporte = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Alternativas_Soportes")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_campania, Id_alternativa, Id_sistema, Id_ejercicio, Id_soporte)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_campania, Id_alternativa, Id_sistema, Id_ejercicio, Id_soporte)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_campania, Id_alternativa)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_campania)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_campania = IIf(IsDBNull(Dr("Id_campania")), 0, Dr("Id_campania"))
        Me.Id_alternativa = IIf(IsDBNull(Dr("Id_alternativa")), 0, Dr("Id_alternativa"))
        Me.Id_sistema = IIf(IsDBNull(Dr("Id_sistema")), 0, Dr("Id_sistema"))
        Me.Id_ejercicio = IIf(IsDBNull(Dr("Id_ejercicio")), 0, Dr("Id_ejercicio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
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
    Public Function ObtenerSistemaEjerciciosSoportes() As DataTable
        Return Me.TraerDataSet("SPK_SISTEMAS.SP_SELECT_ALL", Me.Id_campania, Me.Id_alternativa).Tables(0)
    End Function

    Public Function BorrarSoportes() As Object
        Return Me.Ejecutar("spk_alternativas_soportes.sp_delete", Me.Id_campania, Me.Id_alternativa)
    End Function
#End Region

End Class


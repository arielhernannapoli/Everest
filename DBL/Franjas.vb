Public Class Franjas
    Inherits Entidad

#Region "Propiedades"
    Dim mId_franja As Int16
    Dim mDescripcion As String
    Dim mId_cliente As Int32
    Dim mH_desde As Int16
    Dim mH_hasta As Int16

    Public Property Id_franja() As Int16
        Get
            Return mId_franja
        End Get
        Set(ByVal Value As Int16)
            mId_franja = Value
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

    Public Property Id_cliente() As Int32
        Get
            Return mId_cliente
        End Get
        Set(ByVal Value As Int32)
            mId_cliente = Value
        End Set
    End Property

    Public Property H_desde() As Int16
        Get
            Return mH_desde
        End Get
        Set(ByVal Value As Int16)
            mH_desde = Value
        End Set
    End Property

    Public Property H_hasta() As Int16
        Get
            Return mH_hasta
        End Get
        Set(ByVal Value As Int16)
            mH_hasta = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Franjas")
    End Sub

    Public Overloads Function Agregar() As Object
        Return MyBase.Agregar(Descripcion, Id_cliente, H_desde, H_hasta)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_franja, Descripcion, Id_cliente, H_desde, H_hasta)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_franja)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_franja)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_franja = IIf(IsDBNull(Dr("Id_franja")), 0, Dr("Id_franja"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Id_cliente = IIf(IsDBNull(Dr("Id_cliente")), 0, Dr("Id_cliente"))
        Me.H_desde = IIf(IsDBNull(Dr("H_desde")), 0, Dr("H_desde"))
        Me.H_hasta = IIf(IsDBNull(Dr("H_hasta")), 0, Dr("H_hasta"))
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
    Public Function ObtenerPorCliente(ByVal IDCliente As Integer) As DataTable
        Try
            Return MyBase.TraerDataSet("spk_franjas.sp_por_cliente", IDCliente).Tables(0)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region

End Class

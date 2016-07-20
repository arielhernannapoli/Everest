Public Class Franjas_Detalle
    Inherits Entidad
    Implements IDisposable

#Region "Propiedades"
    Dim mId_Franja As Int16
    Dim mId_Franja_Item As Int16
    Dim mDescripcion As String
    Dim mH_Desde As Int16
    Dim mH_Hasta As Int16

    Public Property Id_Franja() As Int16
        Get
            Return mId_Franja
        End Get
        Set(ByVal Value As Int16)
            mId_Franja = Value
        End Set
    End Property

    Public Property Id_Franja_Item() As Int16
        Get
            Return mId_Franja_Item
        End Get
        Set(ByVal Value As Int16)
            mId_Franja_Item = Value
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

    Public Property H_Desde() As Int16
        Get
            Return mH_Desde
        End Get
        Set(ByVal Value As Int16)
            mH_Desde = Value
        End Set
    End Property

    Public Property H_Hasta() As Int16
        Get
            Return mH_Hasta
        End Get
        Set(ByVal Value As Int16)
            mH_Hasta = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Franjas_Detalle")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_franja, Id_franja_item, Descripcion, H_desde, H_hasta)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_franja, Id_franja_item, Descripcion, H_desde, H_hasta)
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
        Me.Id_franja_item = IIf(IsDBNull(Dr("Id_franja_item")), 0, Dr("Id_franja_item"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
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

    Public Overloads Sub ActualizarDataSet(ByVal Ds As DataSet, ByVal NombreTabla As String)
        MyBase.ActualizarDataSet(Ds, NombreTabla)
    End Sub
#End Region

#Region "Funciones Propias"
    Public Overloads Sub ObtenerEsquema(ByRef Dt As DataTable)
        Me.ObtenerEsquema("spk_franjas_detalle.sp_select_all", Dt)
    End Sub

    Public Function BuscarFranjasDetalle(ByVal IDFranja As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_franjas_detalle.sp_select", IDFranja).Tables(0)
    End Function

    Public Function ObtenerPorCliente(ByVal IDCliente As Integer, ByVal IDFranja As Integer) As DataTable
        Try
            Return MyBase.TraerDataSet("spk_franjas_detalle.sp_por_cliente", IDCliente, IDFranja).Tables(0)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function ObtenerFranjasSistema(ByVal IDCampania As Integer, ByVal IDsistema As Integer) As DataTable
        Return MyBase.TraerDataSet("SPK_GENERADOR_REPORTES.SP_VER_FRANJA_SISTEMA", IDCampania, IDsistema).Tables(0)
    End Function
#End Region

    Sub Dispose() Implements IDisposable.Dispose

    End Sub

End Class

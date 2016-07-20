Imports MSL
Imports Framework

Public Class Productos
    Inherits Entidad

    Dim oDatosMaestros As Maestros

#Region "Propiedades"
    Dim mId_cliente As Int16
    Dim mId_producto As Int16
    Dim mDescripcion As String

    Public Property Id_cliente() As Int16
        Get
            Return mId_cliente
        End Get
        Set(ByVal Value As Int16)
            mId_cliente = Value
        End Set
    End Property

    Public Property Id_producto() As Int16
        Get
            Return mId_producto
        End Get
        Set(ByVal Value As Int16)
            mId_producto = Value
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
        MyBase.New("Productos")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_cliente, Id_producto, Descripcion)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_cliente, Id_producto, Descripcion)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_cliente)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_cliente)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_cliente = IIf(IsDBNull(Dr("Id_cliente")), 0, Dr("Id_cliente"))
        Me.Id_producto = IIf(IsDBNull(Dr("Id_producto")), 0, Dr("Id_producto"))
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
    'Public Function TraerProductos() As DataTable
    '    Return MyBase.TraerDataSet("spk_acceso_vistas.sp_productos", Me.Id_cliente).Tables(0)
    'End Function

    'Public Function TraerTodosProductos() As DataTable
    '    Return MyBase.TraerDataSet("spk_acceso_vistas.sp_productos_all").Tables(0)
    'End Function
#End Region

    ''*****************************************************************
    ''                    ACCESO A DATOS MMS
    ''*****************************************************************
    '' Modified by daniel caime

#Region "******************    DATOS MMS  ************************"

    Public Function traerTodosProductosEnvioaCompras(ByVal id_cliente As Integer, ByVal id_compania As Integer, ByVal id_medio As Integer, ByVal id_tiposoporte As Integer) As DataTable
        ''Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_TEMAS", Id_Cliente, Id_Campania, Id_Medio, Id_Tipo_Soporte, Id_Target).Tables(0)
        Dim dt As DataTable
        oDatosMaestros = New Maestros
        dt = oDatosMaestros.ProductosTraerTodos(Constantes.COD_PAIS_ARGENTINA, id_cliente)
        Return dt
    End Function

    Public Function traerTodosProductos() As DataTable
        Dim dt As DataTable
        oDatosMaestros = New Maestros
        dt = oDatosMaestros.ProductosTraerTodos(Constantes.COD_PAIS_ARGENTINA, Id_cliente)
        Return dt
    End Function

    Public Function TraerProductos() As DataTable
        ''modificado por dcaime 02/08/2010
        Dim dt As DataTable
        If Activo.DTProductosCache Is Nothing Then
            oDatosMaestros = New Maestros
            dt = oDatosMaestros.ProductosTraerTodos(Constantes.COD_PAIS_ARGENTINA, Id_cliente)
        Else
            dt = Activo.DTProductosCache
        End If

        Return dt
    End Function

    Public Function traerDescripcion(ByVal Id_producto As Integer) As String
        Dim sDescripcion As String
        oDatosMaestros = New Maestros
        Id_cliente = Activo.IDCliente
        sDescripcion = oDatosMaestros.productoDescripcion(Id_cliente, Id_producto)
        Return sDescripcion
    End Function
#End Region


End Class


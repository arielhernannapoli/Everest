Imports MSL
Imports Framework

Public Class Tarifas_Internet

    Inherits Entidad
    Dim oDatosMaestros As Maestros

#Region "Propiedades y Variables Datos TARIFAS_INTERNET"

    Dim mId_tarifa As Integer
    Dim mId_Tipo_Formato As Integer
    Dim mId_Formato As Integer
    Dim mId_Tipo_Compra As Integer
    Dim mId_soporte As Integer
    Dim mId_cliente As Integer
    Dim mId_Tipo_soporte As Integer
    Dim mF_inicio As DateTime
    Dim mF_fin As DateTime
    Dim mBruto As Double
    Dim mIdUsuario As Integer
    Dim mFCarga As DateTime
    Dim mFModificacion As DateTime
    Dim mFVigenciaTilde As DateTime

    Public Property Id_tarifa() As Integer
        Get
            Return mId_tarifa
        End Get
        Set(ByVal Value As Integer)
            mId_tarifa = Value
        End Set
    End Property

    Public Property Id_Tipo_Formato() As Integer
        Get
            Return mId_Tipo_Formato
        End Get
        Set(ByVal Value As Integer)
            mId_Tipo_Formato = Value
        End Set
    End Property

    Public Property Id_Formato() As Integer
        Get
            Return mId_Formato
        End Get
        Set(ByVal Value As Integer)
            mId_Formato = Value
        End Set
    End Property

    Public Property Id_Tipo_Compra() As Integer
        Get
            Return mId_Tipo_Compra
        End Get
        Set(ByVal Value As Integer)
            mId_Tipo_Compra = Value
        End Set
    End Property

    Public Property Id_soporte() As Integer
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Integer)
            mId_soporte = Value
        End Set
    End Property

    Public Property Id_cliente() As Integer
        Get
            Return mId_cliente
        End Get
        Set(ByVal Value As Integer)
            mId_cliente = Value
        End Set
    End Property

    Public Property Id_Tipo_soporte() As Integer
        Get
            Return mId_Tipo_soporte
        End Get
        Set(ByVal Value As Integer)
            mId_Tipo_soporte = Value
        End Set
    End Property

    Public Property F_inicio() As DateTime
        Get
            Return mF_inicio
        End Get
        Set(ByVal Value As DateTime)
            mF_inicio = Value
        End Set
    End Property

    Public Property F_fin() As DateTime
        Get
            Return mF_fin
        End Get
        Set(ByVal Value As DateTime)
            mF_fin = Value
        End Set
    End Property

    Public Property Bruto() As Double
        Get
            Return mBruto
        End Get
        Set(ByVal Value As Double)
            mBruto = Value
        End Set
    End Property

    Public Property IdUsuario() As Integer
        Get
            Return mIdUsuario
        End Get
        Set(ByVal Value As Integer)
            mIdUsuario = Value
        End Set
    End Property

    Public Property FCarga() As DateTime
        Get
            Return mFCarga
        End Get
        Set(ByVal Value As DateTime)
            mFCarga = Value
        End Set
    End Property

    Public Property FModificacion() As DateTime
        Get
            Return mFModificacion
        End Get
        Set(ByVal Value As DateTime)
            mFModificacion = Value
        End Set
    End Property

    Public Property FVigenciaTilde() As DateTime
        Get
            Return mFVigenciaTilde
        End Get
        Set(ByVal Value As DateTime)
            mFVigenciaTilde = Value
        End Set
    End Property




#End Region

#Region "Propiedades y Variables Datos TARIFAS_INTERNET_UBICACIONES"

    Dim vIdtarifa As Integer
    Dim vIdUbicacion As Integer
    Dim vIdUsuario As Integer


    Public Property pId_tarifa() As Integer
        Get
            Return vIdtarifa
        End Get
        Set(ByVal Value As Integer)
            vIdtarifa = Value
        End Set
    End Property

    Public Property pIdUbicacion() As Integer
        Get
            Return vIdUbicacion
        End Get
        Set(ByVal Value As Integer)
            vIdUbicacion = Value
        End Set
    End Property

    Public Property pIdUsuario() As Integer
        Get
            Return vIdUsuario
        End Get
        Set(ByVal Value As Integer)
            vIdUsuario = Value
        End Set
    End Property

#End Region

#Region "Funciones"

    Sub New()
        MyBase.New("Tarifas_Internet")
    End Sub

    Public Overloads Function Agregar() As Integer
        Return MyBase.Agregar(Me.Id_Tipo_Formato, Me.Id_Formato, Me.Id_Tipo_Compra, Me.Id_soporte, Me.Id_cliente, Me.Id_Tipo_soporte, Me.F_inicio, Me.F_fin, Bruto, Me.IdUsuario)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Me.Id_tarifa, Me.Id_Tipo_Formato, Me.Id_Formato, Me.Id_Tipo_Compra, Me.Id_soporte, Me.Id_cliente, Me.Id_Tipo_soporte, Me.F_inicio, Me.F_fin, Me.Bruto, Me.IdUsuario)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Me.Id_tarifa)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Me.Id_tarifa)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)

        'Me.Id_tarifa = IIf(IsDBNull(Dr("Id_tarifa_tv")), 0, Dr("Id_tarifa_tv"))
        'Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        'Me.Id_cliente = IIf(IsDBNull(Dr("Id_cliente")), 0, Dr("Id_cliente"))
        'Me.Id_Tipo_Formato = IIf(IsDBNull(Dr("F_inicio_vig")), Nothing, Dr("F_inicio_vig"))
        'Me.Id_Formato = IIf(IsDBNull(Dr("F_fin_vig")), Nothing, Dr("F_fin_vig"))
        'Me.Id_Tipo_Compra = IIf(IsDBNull(Dr("Ind_especial")), "", Dr("Ind_especial"))
        'Me.Id_soporte = IIf(IsDBNull(Dr("Id_programa")), 0, Dr("Id_programa"))
        'Me.Id_cliente = IIf(IsDBNull(Dr("F_inicio_vig")), Nothing, Dr("F_inicio_vig"))
        'Me.Id_Tipo_soporte = IIf(IsDBNull(Dr("F_fin_vig")), Nothing, Dr("F_fin_vig"))
        'Me.F_inicio = IIf(IsDBNull(Dr("Ind_especial")), "", Dr("Ind_especial"))
        'Me.F_fin = IIf(IsDBNull(Dr("Id_programa")), 0, Dr("Id_programa"))
        'Me.Bruto = IIf(IsDBNull(Dr("Bruto")), 0, Dr("Bruto"))
        'Me.IdUsuario = IIf(IsDBNull(Dr("Ind_especial")), "", Dr("Ind_especial"))
        'Me.FCarga = IIf(IsDBNull(Dr("Id_programa")), 0, Dr("Id_programa"))
        'Me.FModificacion = IIf(IsDBNull(Dr("Bruto")), 0, Dr("Bruto"))

    End Sub

    Public Function ObtenerSiguienteIDTarifa() As Integer

        Dim IdResultado As Integer

        IdResultado = CInt(Me.TraerDataSet("SPK_TARIFAS_INTERNET.SP_SELECT_PROXIMOIDTARIFA").Tables(0).Rows(0)("IDTARIFAPROXIMO")).ToString()

        Return IdResultado

    End Function

    Public Function TraerModalidadCompra() As DataTable
        Dim DtResultado As DataTable
        DtResultado = Me.TraerDataSet("SPK_TARIFAS_INTERNET.SP_SELECT_TIPO_COMPRA").Tables(0)
        Return DtResultado
    End Function

    Public Function TraerTodosConVigencia() As DataTable
        Dim DtResultado As DataTable
        DtResultado = Me.TraerDataSet("SPK_TARIFAS_INTERNET.SP_SELECT_CON_VIGENCIA", Me.Id_cliente, Me.Id_soporte, Me.FVigenciaTilde).Tables(0)
        Return DtResultado
    End Function

    Public Function TraerTodosSinVigencia() As DataTable
        Dim DtResultado As DataTable
        DtResultado = Me.TraerDataSet("SPK_TARIFAS_INTERNET.SP_SELECT_SIN_VIGENCIA", Me.Id_cliente, Me.Id_soporte).Tables(0)
        Return DtResultado
    End Function

    Public Function VerificarTarifaExistente() As Boolean
        Dim Resultado As Boolean
        Resultado = Me.TraerDataSet("SPK_TARIFAS_INTERNET.SP_EXISTE", Me.Id_soporte, Me.Id_cliente, 0, Me.F_inicio, Me.F_fin).Tables(0).Rows.Count > 0
        Return Resultado
    End Function

#End Region

#Region "Metodos Ubicaciones X Tarifas"

    Public Sub AgregarTarifasUbicaciones()
        Me.Ejecutar("SPK_TARIFAS_INTERNET.SP_INSERT_TARIFA_UBICACION", Me.pId_tarifa, Me.pIdUbicacion, -1, Me.pIdUsuario)
    End Sub

    Public Sub EliminarTarifasUbicaciones()
        Me.Ejecutar("SPK_TARIFAS_INTERNET.SP_DELETE_TARIFA_UBICACION", Me.Id_tarifa)
    End Sub

    Public Function TraerTarifasUbicaciones() As DataTable

        Dim DtResultado As DataTable
        DtResultado = Me.TraerDataSet("SPK_TARIFAS_INTERNET.SP_SELECT_TARIFA_UBICACION", Me.pId_tarifa).Tables(0)
        Return DtResultado

    End Function

    Public Function TraerTarifasPlanificacion() As DataTable

        Dim DtResultado As DataTable

        DtResultado = Me.TraerDataSet("SPK_TARIFAS_INTERNET.SP_SELECT_TARIFA_HOJA_PLAN", Me.Id_cliente, Me.Id_soporte, Me.Id_Tipo_Compra, Me.Id_Tipo_Formato, Me.pIdUbicacion, Me.Id_Formato, F_inicio, F_fin).Tables(0)

        Return DtResultado

    End Function

#End Region

#Region "Obtener Datos MSL"

#End Region

End Class

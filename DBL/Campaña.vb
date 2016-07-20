Imports MSL
Imports Framework
Public Class Campaña
    Inherits Entidad

    Dim oCampana As Maestros

#Region "Propiedades"
    Dim mID_Campania As Int64
    Dim mAnio As Int64
    Dim mID_Cliente As Int64
    Dim mDescripcion As String
    Dim mF_inicio As DateTime
    Dim mF_fin As DateTime
    Dim mBrf_neto As Decimal
    Dim mBrf_bruto As Decimal
    Dim mVar1_texto As String
    Dim mVar1_valor As Decimal
    Dim mVar2_texto As String
    Dim mVar2_valor As Decimal
    Dim mObservacion As String
    Dim mID_Campania_est As Int16
    Dim mF_alta As DateTime
    Dim mU_alta As String
    Dim mF_modi As DateTime
    Dim mU_modi As String
    Dim mS_Ag_Med As Single

    Public Property ID_Campania() As Int64
        Get
            Return mID_Campania
        End Get
        Set(ByVal Value As Int64)
            mID_Campania = Value
        End Set
    End Property

    Public Property Anio() As Int64
        Get
            Return mAnio
        End Get
        Set(ByVal Value As Int64)
            mAnio = Value
        End Set
    End Property

    Public Property ID_Cliente() As Int64
        Get
            Return mID_Cliente
        End Get
        Set(ByVal Value As Int64)
            mID_Cliente = Value
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

    Public Property Brf_neto() As Decimal
        Get
            Return mBrf_neto
        End Get
        Set(ByVal Value As Decimal)
            mBrf_neto = Value
        End Set
    End Property

    Public Property Brf_bruto() As Decimal
        Get
            Return mBrf_bruto
        End Get
        Set(ByVal Value As Decimal)
            mBrf_bruto = Value
        End Set
    End Property

    Public Property Var1_texto() As String
        Get
            Return mVar1_texto
        End Get
        Set(ByVal Value As String)
            mVar1_texto = Value
        End Set
    End Property

    Public Property Var1_valor() As Decimal
        Get
            Return mVar1_valor
        End Get
        Set(ByVal Value As Decimal)
            mVar1_valor = Value
        End Set
    End Property

    Public Property Var2_texto() As String
        Get
            Return mVar2_texto
        End Get
        Set(ByVal Value As String)
            mVar2_texto = Value
        End Set
    End Property

    Public Property Var2_valor() As Decimal
        Get
            Return mVar2_valor
        End Get
        Set(ByVal Value As Decimal)
            mVar2_valor = Value
        End Set
    End Property

    Public Property Observacion() As String
        Get
            Return mObservacion
        End Get
        Set(ByVal Value As String)
            mObservacion = Value
        End Set
    End Property

    Public Property ID_Campania_est() As Int16
        Get
            Return mID_Campania_est
        End Get
        Set(ByVal Value As Int16)
            mID_Campania_est = Value
        End Set
    End Property

    Public Property F_alta() As DateTime
        Get
            Return mF_alta
        End Get
        Set(ByVal Value As DateTime)
            mF_alta = Value
        End Set
    End Property

    Public Property U_alta() As String
        Get
            Return mU_alta
        End Get
        Set(ByVal Value As String)
            mU_alta = Value
        End Set
    End Property

    Public Property F_modi() As DateTime
        Get
            Return mF_modi
        End Get
        Set(ByVal Value As DateTime)
            mF_modi = Value
        End Set
    End Property

    Public Property U_modi() As String
        Get
            Return mU_modi
        End Get
        Set(ByVal Value As String)
            mU_modi = Value
        End Set
    End Property

    Public Property S_Ag_Med() As Single
        Get
            Return mS_Ag_Med
        End Get
        Set(ByVal Value As Single)
            mS_Ag_Med = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Campanias")
    End Sub

    Public Overloads Function Agregar() As Object
        Try
            Return MyBase.Agregar(Me.ID_Cliente, Me.Descripcion, Me.F_inicio, _
            Me.F_fin, Me.Brf_neto, Me.Brf_bruto, Me.Var1_texto, Me.Var1_valor, _
            Me.Var2_texto, Me.Var2_valor, Me.Observacion, Me.ID_Campania_est, _
            Me.F_alta, Me.U_alta, "I", Me.S_Ag_Med)
        Catch ex As Exception
            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.MetodoAgregar, "Campaña.Agregar")
        End Try
    End Function

    Public Overloads Function Modificar() As Object
        Try
            Return MyBase.Modificar(Me.ID_Campania, Me.Descripcion, Me.F_inicio, _
                Me.F_fin, Me.Brf_neto, Me.Brf_bruto, Me.Var1_texto, _
                Me.Var1_valor, Me.Var2_texto, Me.Var2_valor, Me.Observacion, _
                Me.ID_Campania_est, Me.F_modi, Me.U_modi, Me.S_Ag_Med)
        Catch ex As Exception
            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.MetodoAgregar, "Campaña.Modificar")
        End Try
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Me.ID_Campania)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("spk_" & MyBase.Tabla & ".sp_select", Me.ID_Campania)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
    End Function

    Public Sub CargarPropiedades(ByVal Dt As DataTable)
        With Dt.Rows(0)
            ID_Campania = .Item("ID_Campania")
            Anio = .Item("anio")
            ID_Cliente = .Item("ID_Cliente")
            Descripcion = .Item("descripcion")
            F_inicio = .Item("f_inicio")
            F_fin = .Item("f_fin")
            Brf_neto = .Item("brf_neto")
            Brf_bruto = .Item("brf_bruto")
            Var1_texto = .Item("var1_texto")
            Var1_valor = .Item("var1_valor")
            Var2_texto = .Item("var2_texto")
            Var2_valor = .Item("var2_valor")
            Observacion = .Item("Observacion")
            ID_Campania_est = .Item("idcampaña_est")
            F_alta = .Item("f_alta")
            U_alta = .Item("u_alta")
            F_modi = .Item("f_modi")
            U_modi = .Item("u_modi")
        End With
    End Sub

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.ID_Campania = Dr("Id_Campania")
        Me.ID_Cliente = Dr("Id_Cliente")
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.F_inicio = Dr("F_inicio")
        Me.F_fin = Dr("F_fin")
        Me.Brf_neto = Dr("Brf_neto")
        Me.Brf_bruto = Dr("Brf_bruto")
        Me.Var1_texto = IIf(IsDBNull(Dr("Var1_texto")), "", Dr("Var1_texto"))
        Me.Var1_valor = IIf(IsDBNull(Dr("Var1_valor")), "", Dr("Var1_valor"))
        Me.Var2_texto = IIf(IsDBNull(Dr("Var2_texto")), "", Dr("Var2_texto"))
        Me.Var2_valor = IIf(IsDBNull(Dr("Var2_valor")), "", Dr("Var2_valor"))
        Me.Observacion = IIf(IsDBNull(Dr("Observacion")), "", Dr("observacion"))
        Me.ID_Campania_est = Dr("Id_campania_est")
        Me.F_alta = Dr("F_alta")
        Me.U_alta = Dr("U_alta")
        Me.F_modi = IIf(IsDBNull(Dr("F_modi")), Nothing, Dr("f_modi"))
        Me.U_modi = IIf(IsDBNull(Dr("U_modi")), Nothing, Dr("u_modi"))
    End Sub

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
    'trae todas las campañas de un cliente
    Public Function ObtenerCampañasCliente(ByVal FechaDesde As Date, ByVal FechaHasta As Date) As DataTable
        Return Me.TraerDataSet("spk_" & Tabla & ".sp_campania_cliente_inicio", Me.ID_Cliente, FechaDesde, FechaHasta).Tables(0)
    End Function

    'trae las inversiones realizadas, agrupadas por tipo de soporte
    Public Function ObtenerInversionPorTipoSoporte() As DataTable

        Dim dtResultado As DataTable

        'AG DBCompania
        If Activo.DBConexionTEC10GP = True Then
            dtResultado = Me.TraerDataSet("spk_inversion.sp_inversion_por_tipo_soporte", Me.ID_Campania).Tables(0)
        Else
        End If

        Return dtResultado
        'Return Me.TraerDataSet("spk_inversion.sp_inversion_por_tipo_soporte", Me.ID_Campania).Tables(0)
    End Function

    Public Function ObtenerInversionPorTipoSoporteMensual() As DataTable
        Return Me.TraerDataSet("spk_inversion.sp_inv_tipo_soporte_mensual", Me.ID_Campania).Tables(0)
    End Function

    Public Function ObtenerSistemas() As DataSet
        Return Me.TraerDataSet("spk_sistemas.sp_sistemas_campania", Me.ID_Campania)
    End Function

    Public Function ObtenerDatosGantt() As DataTable
        Return Me.TraerDataSet("spk_campanias.sp_gantt_sistemas", Me.ID_Campania).Tables(0)
    End Function

    Public Function VerificarSistemaFueraRango() As Boolean
        Dim dt As DataTable

        dt = Me.TraerDataSet("SPK_CAMPANIAS.SP_SELECT_SISTEMAS_FUERA_RANGO", Me.ID_Campania, Me.F_inicio, Me.F_fin).Tables(0)

        VerificarSistemaFueraRango = (dt.Rows(0).Item(0) > 0)
    End Function

    Public Function Duplicar() As Long
        Me.BuscarPorID()
        Me.Descripcion = "Duplicado de " & Me.Descripcion
        Duplicar = Me.Agregar()
    End Function

#End Region

    ''*****************************************************************
    ''                    ACCESO A DATOS MMS
    ''*****************************************************************
    '' Modified by daniel caime

#Region "******************    DATOS MMS  ************************"

    Public Function MMSCampañasEnvioCompras(ByVal id_compania As Integer, ByVal id_cliente As Integer, ByVal id_producto As Integer, ByVal f_desde As String, ByVal f_hasta As String) As DataTable

        Dim dt As New DataTable
        oCampana = New Maestros()
        dt = oCampana.campanasTraerTodos(Constantes.COD_PAIS_ARGENTINA, id_compania, id_cliente, id_producto, f_desde, f_hasta)
        Return dt
    End Function
#End Region

End Class

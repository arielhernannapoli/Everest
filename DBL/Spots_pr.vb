Imports Framework
Public Class Spots_pr
    Inherits Entidad

#Region "Propiedades"
    Dim mId_spot As Int64
    Dim mId_producto As Int16
    Dim mId_material As String
    Dim mConcepto As String
    Dim mId_seccion As Int16
    Dim mInd_fijo As Int16
    Dim mAncho As Int16
    Dim mAlto As Single
    Dim _detalleColor As Integer
    Dim mTitulo_anuncio As String

    Public Property Id_spot() As Int64
        Get
            Return mId_spot
        End Get
        Set(ByVal Value As Int64)
            mId_spot = Value
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

    Public Property Id_material() As String
        Get
            Return mId_material
        End Get
        Set(ByVal Value As String)
            mId_material = Value
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return mConcepto
        End Get
        Set(ByVal Value As String)
            mConcepto = Value
        End Set
    End Property

    Public Property Id_seccion() As Int16
        Get
            Return mId_seccion
        End Get
        Set(ByVal Value As Int16)
            mId_seccion = Value
        End Set
    End Property

    Public Property Ind_fijo() As Int16
        Get
            Return mInd_fijo
        End Get
        Set(ByVal Value As Int16)
            mInd_fijo = Value
        End Set
    End Property

    Public Property Ancho() As Int16
        Get
            Return mAncho
        End Get
        Set(ByVal Value As Int16)
            mAncho = Value
        End Set
    End Property

    Public Property Alto() As Single
        Get
            Return mAlto
        End Get
        Set(ByVal Value As Single)
            mAlto = Value
        End Set
    End Property

    Public Property Titulo_anuncio() As String
        Get
            Return mTitulo_anuncio
        End Get
        Set(ByVal Value As String)
            mTitulo_anuncio = Value
        End Set
    End Property


    Public Property DetalleColor() As Integer
        Get
            Return _detalleColor
        End Get
        Set(ByVal value As Integer)
            _detalleColor = value
        End Set
    End Property

#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("SPOTS_PR")
    End Sub

    Public Overloads Function Agregar(ByVal p_id_campania As Integer, ByVal p_id_sistema As Integer, _
    ByVal p_id_ejercicio As Integer, ByVal p_id_soporte As Integer, ByVal p_id_producto As Integer, _
    ByVal p_id_material As String, ByVal p_concepto As String, ByVal p_detalle_color As Integer, ByVal p_id_seccion As Integer, _
    ByVal p_ind_fijo As Integer, ByVal p_ancho As Double, ByVal p_alto As Double, _
    ByVal p_bruto As Double, ByVal p_dcto1 As Double, ByVal p_dcto2 As Double, _
    ByVal p_dcto3 As Double, ByVal p_dcto4 As Double, ByVal p_dcto5 As Double, ByVal p_neto As Double, _
    ByVal p_id_convenio As Integer, ByVal p_u_alta As String, ByVal p_f_alta As DateTime) As Object
        '--
        Return MyBase.Agregar(p_id_campania, p_id_sistema, p_id_ejercicio, p_id_soporte, p_id_producto, p_id_material, p_concepto, p_detalle_color, p_id_seccion, p_ind_fijo, p_ancho, p_alto, p_bruto, p_dcto1, p_dcto2, p_dcto3, p_dcto4, p_dcto5, p_neto, p_id_convenio, p_u_alta, p_f_alta)
    End Function

    Public Overloads Function Modificar(ByVal p_id_spot As Integer, ByVal p_id_campania As Integer, ByVal p_id_sistema As Integer, _
    ByVal p_id_ejercicio As Integer, ByVal p_id_soporte As Integer, ByVal p_id_producto As Integer, _
    ByVal p_id_material As String, ByVal p_concepto As String, ByVal p_detalle_color As Integer, ByVal p_id_seccion As Integer, _
    ByVal p_ind_fijo As Integer, ByVal p_ancho As Double, ByVal p_alto As Double, _
    ByVal p_bruto As Double, ByVal p_dcto1 As Double, ByVal p_dcto2 As Double, _
    ByVal p_dcto3 As Double, ByVal p_dcto4 As Double, ByVal p_dcto5 As Double, ByVal p_neto As Double, _
    ByVal p_id_convenio As Integer, ByVal p_u_modi As String, ByVal p_f_modi As DateTime) As Object
        MyBase.Modificar(p_id_spot, p_id_campania, p_id_sistema, p_id_ejercicio, p_id_soporte, p_id_producto, p_id_material, p_concepto, p_detalle_color, p_id_seccion, p_ind_fijo, p_ancho, p_alto, p_bruto, p_dcto1, p_dcto2, p_dcto3, p_dcto4, p_dcto5, p_neto, p_id_convenio, p_u_modi, p_f_modi)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_spot)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_spot)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_spot = IIf(IsDBNull(Dr("Id_spot")), 0, Dr("Id_spot"))
        Me.Id_producto = IIf(IsDBNull(Dr("Id_producto")), 0, Dr("Id_producto"))
        Me.Id_material = IIf(IsDBNull(Dr("Id_material")), "", Dr("Id_material"))
        Me.Concepto = IIf(IsDBNull(Dr("Concepto")), "", Dr("Concepto"))
        Me.Id_seccion = IIf(IsDBNull(Dr("Id_seccion")), 0, Dr("Id_seccion"))
        Me.Ind_fijo = IIf(IsDBNull(Dr("Ind_fijo")), 0, Dr("Ind_fijo"))
        Me.Ancho = IIf(IsDBNull(Dr("Ancho")), 0, Dr("Ancho"))
        Me.Alto = IIf(IsDBNull(Dr("Alto")), 0, Dr("Alto"))
        Me.Titulo_anuncio = IIf(IsDBNull(Dr("Titulo_anuncio")), "", Dr("Titulo_anuncio"))
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

    Public Overloads Sub Desconectar()
        MyBase.Desconectar()
    End Sub
#End Region

#Region "Funciones Propias"
    Public Function AgregarDetalle(ByVal p_id_spot As Integer, ByVal p_id_tema As String, _
    ByVal p_f_spot As DateTime, ByVal p_duracion As Integer, ByVal p_u_alta As String, ByVal p_f_alta As DateTime, _
    ByVal p_id_spot_estado As String, ByVal p_observacion As String) As Object
        Return Me.EjecutarConectado("spk_spots_pr.SP_INSERT_DETALLE", p_id_spot, p_id_tema, p_f_spot, p_duracion, p_u_alta, p_f_alta, p_id_spot_estado, p_observacion)
    End Function

    Public Sub ModificarDetalle(ByVal p_id_spot As Integer, ByVal p_id_spot_detalle As Integer, _
    ByVal p_id_tema As String, ByVal p_f_spot As DateTime, ByVal p_duracion As Integer, ByVal p_id_spot_estado As String, _
    ByVal p_observacion As String, ByVal p_u_modi As String, ByVal p_f_modi As DateTime)
        Me.EjecutarConectado("spk_spots_pr.SP_UPDATE_DETALLE", p_id_spot, p_id_spot_detalle, p_id_tema, p_f_spot, p_duracion, p_id_spot_estado, p_observacion, p_u_modi, p_f_modi)
    End Sub

    Public Sub BorrarDetalle(ByVal p_id_spot As Integer, ByVal p_id_spot_detalle As Integer)
        Me.EjecutarConectado("spk_spots_pr.SP_DELETE_DETALLE", p_id_spot, p_id_spot_detalle)
    End Sub

    Public Function ObtenerSpots_Pr(ByVal pId_campania As Integer, ByVal pId_sistema As Integer, ByVal pId_ejercicio As Integer) As DataSet
        Return Me.TraerDataSet("spk_spots_pr.SP_SELECT_TOTAL", pId_campania, pId_sistema, pId_ejercicio)
    End Function

    Public Function ObtenerMateriales(ByVal pId_campania As Integer, ByVal pId_Medio As Integer, ByVal pId_Tipo_Soporte As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots_pr.SP_SELECT_MATERIAL", pId_campania, pId_Medio, pId_Tipo_Soporte).Tables(0)
    End Function

    Public Function ObtenerProductos(ByVal pId_campania As Integer, ByVal pId_Medio As Integer, ByVal pId_Tipo_Soporte As Integer, ByVal p_id_cliente As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots_pr.SP_SELECT_PRODUCTO", pId_campania, pId_Medio, pId_Tipo_Soporte, p_id_cliente).Tables(0)
    End Function

    Public Function ObtenerConceptos(ByVal pId_Medio As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots_pr.SP_SELECT_CONCEPTO", pId_Medio).Tables(0)
    End Function

    Public Function ObtenerSecciones(ByVal pId_Medio As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots_pr.SP_SELECT_SECCION", pId_Medio).Tables(0)
    End Function

    Public Function ObtenerSoportesSeccionesConceptos(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer, ByVal pid_Producto As Integer, ByVal pid_material As String) As DataSet

        Return Me.TraerDataSet("spk_spots_pr.SP_SELECT_SEC_CON_SOP", pId_Campania, pId_Sistema, pId_Ejercicio, pid_Producto, pid_material)

    End Function
    Public Function ObtenerCantidadSpots(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer) As Integer
        Return Me.Ejecutar("spk_spots_pr.SP_SELECT_CANT_SPOTS", pId_Campania, pId_Sistema, pId_Ejercicio)
    End Function
    'p_id_campanIa in number, p_id_sistema in number, p_id_ejercicio in number,
    'p_f_desde in date, p_f_hasta in date,p_id_producto in number,p_id_material in number,p_id_seccion in number,p_id_soporte in number,p_concepto in varchar2

#End Region

End Class


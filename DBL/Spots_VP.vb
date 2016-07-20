Imports MSL
Imports Framework

'GG 19/05/2015 Dimensiones + CISOP
Public Class Spots_vp
    Inherits Entidad
    Dim oMaestro As Maestros

#Region "Propiedades"
    Dim mId_spot As Int64
    Dim mId_producto As Int16
    Dim mId_material As String
    Dim mDes_formato As String
    Dim mCod_pobl1 As Int16
    Dim mCod_pobl2 As Int16
    Dim mDireccion1 As String
    Dim mDireccion2 As String
    Dim mTitulo_anuncio As String
    Dim mDes_localizacion As String
    Dim mNum_Caras As Integer
    Dim mCod_AGIP As Integer
    Dim mId_tipo_elemento As Integer
    Dim mAncho As Single
    Dim mAlto As Single
    Dim mCisop As Long
    Dim mCostoUnitario As Double

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

    Public Property Des_formato() As String
        Get
            Return mDes_formato
        End Get
        Set(ByVal Value As String)
            mDes_formato = Value
        End Set
    End Property

    Public Property Cod_pobl1() As Int16
        Get
            Return mCod_pobl1
        End Get
        Set(ByVal Value As Int16)
            mCod_pobl1 = Value
        End Set
    End Property

    Public Property Cod_pobl2() As Int16
        Get
            Return mCod_pobl2
        End Get
        Set(ByVal Value As Int16)
            mCod_pobl2 = Value
        End Set
    End Property

    Public Property Direccion1() As String
        Get
            Return mDireccion1
        End Get
        Set(ByVal Value As String)
            mDireccion1 = Value
        End Set
    End Property

    Public Property Direccion2() As String
        Get
            Return mDireccion2
        End Get
        Set(ByVal Value As String)
            mDireccion2 = Value
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

    Public Property Des_localizacion() As String
        Get
            Return mDes_localizacion
        End Get
        Set(ByVal Value As String)
            mDes_localizacion = Value
        End Set
    End Property

    Public Property Num_Caras() As Integer
        Get
            Return mNum_Caras
        End Get
        Set(ByVal Value As Integer)
            mNum_Caras = Value
        End Set
    End Property

    Public Property Cod_AGIP() As Integer
        Get
            Return mCod_AGIP
        End Get
        Set(ByVal Value As Integer)
            mCod_AGIP = Value
        End Set
    End Property

    Public Property Id_tipo_elemento() As Integer
        Get
            Return mId_tipo_elemento
        End Get
        Set(ByVal Value As Integer)
            mId_tipo_elemento = Value
        End Set
    End Property

    Public Property Ancho() As Integer
        Get
            Return mAncho
        End Get
        Set(ByVal Value As Integer)
            mAncho = Value
        End Set
    End Property

    Public Property Alto() As Integer
        Get
            Return mAlto
        End Get
        Set(ByVal Value As Integer)
            mAlto = Value
        End Set
    End Property

    Public Property Cisop() As Long
        Get
            Return mCisop
        End Get
        Set(ByVal Value As Long)
            mCisop = Value
        End Set
    End Property

    Public Property CostoUnitario() As Double
        Get
            Return mCostoUnitario
        End Get
        Set(ByVal Value As Double)
            mCostoUnitario = Value
        End Set
    End Property

#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Spots_VP")
    End Sub


    Public Overloads Function Agregar(ByVal p_id_campania As Integer, ByVal p_id_sistema As Integer, _
    ByVal p_id_ejercicio As Integer, ByVal p_id_soporte As Integer, ByVal p_id_producto As Integer, _
    ByVal p_id_material As String, ByVal p_des_formato As String, _
    ByVal p_cod_pobl1 As Integer, ByVal p_cod_pobl2 As Integer, ByVal p_direccion1 As String, _
    ByVal p_bruto As Double, ByVal p_dcto1 As Double, ByVal p_dcto2 As Double, _
    ByVal p_dcto3 As Double, ByVal p_dcto4 As Double, ByVal p_dcto5 As Double, ByVal p_neto As Double, _
    ByVal p_id_convenio As Integer, ByVal p_num_caras As Integer, ByVal p_u_alta As String, ByVal p_f_alta As DateTime, ByVal p_cod_AGIP As String, ByVal p_id_tipo_elemento As Integer, ByVal p_ancho As Object, ByVal p_alto As Object, ByVal p_cisop As Object, ByVal p_cunitario As Double) As Object
        Return MyBase.Agregar(p_id_campania, p_id_sistema, p_id_ejercicio, p_id_soporte, p_id_producto, p_id_material, p_des_formato, p_cod_pobl1, p_cod_pobl2, p_direccion1, p_bruto, p_dcto1, p_dcto2, p_dcto3, p_dcto4, p_dcto5, p_neto, p_id_convenio, p_num_caras, p_u_alta, p_f_alta, p_cod_AGIP, p_id_tipo_elemento, p_ancho, p_alto, p_cisop, p_cunitario)
    End Function


    Public Overloads Function Modificar(ByVal p_id_spot As Integer, ByVal p_id_campania As Integer, ByVal p_id_sistema As Integer, _
    ByVal p_id_ejercicio As Integer, ByVal p_id_soporte As Integer, ByVal p_id_producto As Integer, _
    ByVal p_id_material As String, ByVal p_des_formato As String, _
    ByVal p_cod_pobl1 As Integer, ByVal p_cod_pobl2 As Integer, ByVal p_direccion1 As String, _
    ByVal p_bruto As Double, ByVal p_dcto1 As Double, ByVal p_dcto2 As Double, _
    ByVal p_dcto3 As Double, ByVal p_dcto4 As Double, ByVal p_dcto5 As Double, ByVal p_neto As Double, _
    ByVal p_id_convenio As Integer, ByVal p_num_caras As Integer, ByVal p_u_modi As String, ByVal p_f_modi As DateTime, ByVal p_cod_AGIP As String, ByVal p_id_tipo_elemento As Integer, ByVal p_ancho As Object, ByVal p_alto As Object, ByVal p_cisop As Object, ByVal p_cunitario As Double) As Object
        MyBase.Modificar(p_id_spot, p_id_campania, p_id_sistema, p_id_ejercicio, p_id_soporte, p_id_producto, p_id_material, p_des_formato, p_cod_pobl1, p_cod_pobl2, p_direccion1, p_bruto, p_dcto1, p_dcto2, p_dcto3, p_dcto4, p_dcto5, p_neto, p_id_convenio, p_num_caras, p_u_modi, p_f_modi, p_cod_AGIP, p_id_tipo_elemento, p_ancho, p_alto, p_cisop, p_cunitario)
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
        Me.Des_formato = IIf(IsDBNull(Dr("Des_formato")), "", Dr("Des_formato"))
        Me.Cod_pobl1 = IIf(IsDBNull(Dr("Cod_pobl1")), 0, Dr("Cod_pobl1"))
        Me.Cod_pobl2 = IIf(IsDBNull(Dr("Cod_pobl2")), 0, Dr("Cod_pobl2"))
        Me.Direccion1 = IIf(IsDBNull(Dr("Direccion1")), "", Dr("Direccion1"))
        Me.Direccion2 = IIf(IsDBNull(Dr("Direccion2")), "", Dr("Direccion2"))
        Me.Titulo_anuncio = IIf(IsDBNull(Dr("Titulo_anuncio")), "", Dr("Titulo_anuncio"))
        Me.Des_localizacion = IIf(IsDBNull(Dr("Des_localizacion")), "", Dr("Des_localizacion"))
        Me.Num_Caras = IIf(IsDBNull(Dr("Num_Caras")), "", Dr("Num_Caras"))
        Me.Id_tipo_elemento = IIf(IsDBNull(Dr("Id_tipo_elemento")), 0, Dr("Id_tipo_elemento"))
        Me.Ancho = IIf(IsDBNull(Dr("AnchoVP")), 0, Dr("AnchoVP"))
        Me.Alto = IIf(IsDBNull(Dr("AltoVP")), 0, Dr("AltoVP"))
        Me.Cisop = IIf(IsDBNull(Dr("Cisop")), 0, Dr("Cisop"))
        Me.CostoUnitario = IIf(IsDBNull(Dr("CUnitario")), 0, Dr("CUnitario"))
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

    Public Function ObtenerSpots_Vp(ByVal pId_campania As Integer, ByVal pId_sistema As Integer, ByVal pId_ejercicio As Integer) As DataSet
        Return Me.TraerDataSet("spk_spots_vp.SP_SELECT_TOTAL", pId_campania, pId_sistema, pId_ejercicio)
    End Function

    'Public Function ObtenerProvincias() As DataTable
    '    Return Me.TraerDataSet("spk_spots_vp.SP_SELECT_POBLACION_NIVEL1").Tables(0)
    'End Function

    'Public Function ObtenerPoblaciones() As DataTable
    '    Return Me.TraerDataSet("spk_spots_vp.SP_SELECT_POBLACION_NIVEL2", mCod_pobl1).Tables(0)
    'End Function

    Public Function ObtenerCantidadSpots(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer) As Integer
        Return Me.Ejecutar("spk_spots_vp.SP_SELECT_CANT_SPOTS", pId_Campania, pId_Sistema, pId_Ejercicio)
    End Function

    Public Function ObtenerSoportesProvincia(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer, ByVal pid_Producto As Integer, ByVal pid_material As String) As DataSet
        Return Me.TraerDataSet("spk_spots_vp.SP_SELECT_SOP_POB", pId_Campania, pId_Sistema, pId_Ejercicio, pid_Producto, pid_material)
    End Function
    Public Function ObtenerMateriales(ByVal pId_campania As Integer, ByVal pId_Medio As Integer, ByVal pId_Tipo_Soporte As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots_vp.SP_SELECT_MATERIAL", pId_campania, pId_Medio, pId_Tipo_Soporte).Tables(0)
    End Function

    Public Function ObtenerProductos(ByVal pId_campania As Integer, ByVal pId_Medio As Integer, ByVal pId_Tipo_Soporte As Integer, ByVal p_id_cliente As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots_vp.SP_SELECT_PRODUCTO", pId_campania, pId_Medio, pId_Tipo_Soporte, p_id_cliente).Tables(0)
    End Function
#End Region

#Region "DATOS MMS"

    ''' <summary>
    ''' Obtener poblaciones1
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerProvincias() As DataTable
        Dim dtProvincias As DataTable
        oMaestro = New Maestros
        dtProvincias = oMaestro.poblaciones1Obtener(Activo.CodPaisMms)
        Return dtProvincias
    End Function

    Public Function ObtenerPoblaciones() As DataTable
        Dim dtPoblaciones As DataTable
        oMaestro = New Maestros
        dtPoblaciones = oMaestro.poblaciones2Obtener(Activo.CodPaisMms, Cod_pobl1)
        Return dtPoblaciones
    End Function

#End Region
End Class


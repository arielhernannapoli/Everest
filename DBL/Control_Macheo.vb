Imports Admedia.DBL
Imports MSL
Imports HM.Contratos.Entidad.Campanas
Imports MSL.Control
Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports Framework
Imports System.Globalization
Imports System.Collections.Generic
Imports HM.Comun.SolutionEntityFramework

Public Class Control_Macheo
    Inherits Entidad
    Implements IDisposable

    Dim mMaestros As Maestros
    Dim AgenteControl As Mantenimiento
    Dim s As Control.Mantenimiento

#Region "Propiedades"
    Private mCod_Presupuesto As Double
    Private mCod_Soporte As String
    Private mCod_Cli As Integer
    Private mCod_Prod As Integer
    Private mTipo_Aviso As Integer
    Private mFecha_Desde As DateTime
    Private mFecha_Hasta As DateTime
    Private mCod_Producto As String 'JJP - Matcheo interior códigos de producto
    Private mCod_Pais As Integer
    Private mCod_Compania As Integer


    Public Property Cod_Presupuesto() As Double
        Get
            Return mCod_Presupuesto
        End Get
        Set(ByVal Value As Double)
            mCod_Presupuesto = Value
        End Set
    End Property

    Public Property Cod_Soporte() As String
        Get
            Return mCod_Soporte
        End Get
        Set(ByVal Value As String)
            mCod_Soporte = Value
        End Set
    End Property

    Public Property Cod_Cli() As Integer
        Get
            Return mCod_Cli
        End Get
        Set(ByVal Value As Integer)
            mCod_Cli = Value
        End Set
    End Property

    Public Property Cod_Prod() As Integer
        Get
            Return mCod_Prod
        End Get
        Set(ByVal Value As Integer)
            mCod_Prod = Value
        End Set
    End Property

    Public Property Tipo_Aviso() As Integer
        Get
            Return mTipo_Aviso
        End Get
        Set(ByVal Value As Integer)
            mTipo_Aviso = Value
        End Set
    End Property

    Public Property Fecha_Desde() As DateTime
        Get
            Return mFecha_Desde
        End Get
        Set(ByVal Value As DateTime)
            mFecha_Desde = Value
        End Set
    End Property

    Public Property Fecha_Hasta() As DateTime
        Get
            Return mFecha_Hasta
        End Get
        Set(ByVal Value As DateTime)
            mFecha_Hasta = Value
        End Set
    End Property

    Public Property Cod_Producto() As String
        Get
            Return mCod_Producto
        End Get
        Set(ByVal Value As String)
            mCod_Producto = Value
        End Set
    End Property

    Public Property Cod_Pais() As Integer
        Get
            Return mCod_Pais
        End Get
        Set(ByVal Value As Integer)
            mCod_Pais = Value
        End Set
    End Property

    Public Property Cod_Compania() As Integer
        Get
            Return mCod_Compania
        End Get
        Set(ByVal Value As Integer)
            mCod_Compania = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Public Sub New()
        MyBase.New("Control")
    End Sub

    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
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
    Public Function BuscarTipoSpots() As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_TIPO_SPOTS")
    End Function

    Public Function BuscarOrdenes() As DataSet

        AgenteControl = New Mantenimiento

        Dim controlEnt As New ControlEntidad
        controlEnt.codigoPresupuesto = Integer.Parse(Cod_Presupuesto.ToString)
        controlEnt.codigoCompania = Cod_Compania

        Return AgenteControl.ObtenerOrdenesSinConfirmar(Cod_Compania, Integer.Parse(Cod_Presupuesto.ToString), False)

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ORDENES_JJP", mCod_Presupuesto)

    End Function

    Public Function BuscarOrdenesMacheo() As Dictionary(Of String, List(Of OrdenMatcheo))
        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerOrdenesMatcheo(Activo.IDCompaniaMMS, mCod_Presupuesto)

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ORDENES_MACHEO", mCod_Presupuesto).Tables(0)
    End Function

    Public Function BuscarSpot() As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_SPOT_JJP", mCod_Soporte, mCod_Cli, mCod_Prod, mTipo_Aviso, mFecha_Desde, mFecha_Hasta)
        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_SPOT", mCod_Soporte, mCod_Cli, mCod_Prod, mTipo_Aviso, mFecha_Desde, mFecha_Hasta)
    End Function

    Public Function BuscarSpots(ByVal codProducto As Nullable(Of Integer)) As DataTable
        Dim admedia As New Admedia_Matcheo

        Return admedia.ObtenerProductos(mCod_Cli, codProducto)

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_SPOTS", mCod_Cli).Tables(0)
    End Function

    Public Function BuscarTarifas_TV(ByVal pCod_Soporte As Integer, ByVal pProgramas As String, ByVal pFecha As DateTime, ByVal pHora As Integer) As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_TARIFAS_TV", pCod_Soporte, pProgramas, pHora, pFecha)
    End Function

    'Public Function BuscarAvisosCaidos() As DataSet

    '    Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_AR_AVISOS_CAIDOS", mCod_Presupuesto)

    'End Function

    Public Function BuscarAvisosCaidos() As System.Collections.Generic.List(Of HM.MMS.AR.Server.BusinessEntity.Control.AvisoCaido)

        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerAvisosCaidos(Activo.IDCompaniaMMS, Convert.ToInt32(mCod_Presupuesto))

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_AR_AVISOS_CAIDOS", mCod_Presupuesto)


    End Function

    Public Function BuscarAvisosNoConfirmados(ByVal codCompania As Integer, ByVal codPresupuesto As Integer) As List(Of AvisoNoConfirmado)

        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerAvisosNoConfirmados(codCompania, codPresupuesto)

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_AR_AVISOS_NOCONF", mCod_Presupuesto)
    End Function

    Public Function BuscarAvisosReporteFacturacion(ByVal codCompania As Integer, ByVal codPresupuesto As Integer) As List(Of AvisoNoConfirmado)

        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerAvisosReporteFacturacion(codCompania, codPresupuesto)

    End Function

    Public Function BuscarOrdenesConfirmadas() As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ORDENES_CONFIRMADAS", mCod_Presupuesto)
    End Function

    Public Function BuscarSpotsConfirmados(ByVal pCod_Spot As Double, ByVal pCod_Cliente As Integer, ByVal pCod_Cadena As String, ByVal pHora As Integer, ByVal pSegundos As Integer, ByVal pFecha As DateTime) As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_SPOTS_CONFIRMADOS", pCod_Spot, pCod_Cliente, pCod_Cadena, pHora, pSegundos, pFecha)
    End Function

    Public Function BuscarAnunciantes(ByVal pCodAnunciante As Double) As DataTable
        Dim admedia As New Admedia_Matcheo

        Return admedia.ObtenerAnunciante(pCodAnunciante)

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ANUNCIANTES", pCodAnunciante).Tables(0)
    End Function

    Public Function BuscarAr_Clientes_Sig_Nau() As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_AR_CLIENTES_SIG_NAU", mCod_Cli)
    End Function

    Public Function BuscarAr_Productos_Sig_Nau() As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_AR_PRODUCTOS_SIG_NAU", mCod_Cli, mCod_Prod)
    End Function

    Public Function BuscarPresupuesto_Id(ByVal pCod_Presupuesto As Double) As DataTable

        mMaestros = New Maestros

        Return ArmarDtPresupuesto(mMaestros.presupuestoTraer(Activo.CodPaisMms, Activo.IDCompaniaMMS, pCod_Presupuesto))

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_PRESUPUESTO_ID", pCod_Presupuesto).Tables(0)
    End Function

    Public Sub ActualizarEstadoOrden(ByVal pCod_Orden As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_UPDATE_ORDEN_ESTADO", pCod_Orden)
    End Sub

    Public Sub ActualizarAr_Clientes_Sig_Nau(ByVal pCod_Cli_Sig As Double, ByVal pCod_Cli_Nau As Double, ByVal pCod_Cli_Nau_Nuevo As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_UPDATE_AR_CLIENTES_SIG_NAU", pCod_Cli_Sig, pCod_Cli_Nau, pCod_Cli_Nau_Nuevo)
    End Sub

    Public Sub AgregarConfirmaciones_TV(ByVal pCod_Orden As Double, ByVal pFec_Confirmacion As DateTime, ByVal pFec_Aparicion As DateTime, ByVal pHora As Integer, ByVal pMinuto As Integer, ByVal pInd_Diferencia As Integer, ByVal pUsuario As String, ByVal pAplicativo As String, ByVal pVersion As Integer)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_INSERT_CONFIRMACIONES_TV", pCod_Orden, pFec_Confirmacion, pFec_Aparicion, pHora, pMinuto, pInd_Diferencia, pUsuario, pAplicativo, pVersion)
    End Sub

    Public Sub AgregarAvisosConfirmados(ByVal pCod_Spot As Double, ByVal pCod_Orden As Double, ByVal pFec_Spot As DateTime, ByVal pHora_Spot As Integer, ByVal pCod_Soporte As String, ByVal pSS_Spot As Integer)

        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_INSERT_AR_AVISOS_CONF", pCod_Spot, pCod_Orden, pFec_Spot, pHora_Spot, pCod_Soporte, pSS_Spot)
    End Sub

    Public Sub AgregarAvisosNoConfirmados(ByVal pCod_Presupuesto As Double, ByVal pCod_Orden_Origen As Double, ByVal pCod_Orden_Destino As Double, ByVal pEstado As String)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_INSERT_AR_AVISOS_NOCONF", pCod_Presupuesto, pCod_Orden_Origen, pCod_Orden_Destino, pEstado)
    End Sub

    Public Sub AgregarAvisosManuales(ByVal pCod_Presupuesto As Double, ByVal pCod_Orden As Double, ByVal pCod_Medio As Integer, ByVal pCod_Soporte As Integer, ByVal pFecha As DateTime, ByVal pHora As String, ByVal pPrograma As String, ByVal pDuracion As Integer, ByVal pNeto As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_INSERT_AR_AVISOS_MANUALES", pCod_Presupuesto, pCod_Orden, pCod_Medio, pCod_Soporte, pFecha, pHora, pPrograma, pDuracion, pNeto)
    End Sub

    Public Sub AgregarAvisoCaido(ByVal pId_Presupuesto As Integer, ByVal pId_Orden_Sigeme As Integer, ByVal pU_Alta As Integer, ByVal pF_Alta As DateTime, ByVal pCompania As Integer)
        AgenteControl = New Mantenimiento
        Dim avisos As New System.Collections.Generic.List(Of HM.MMS.AR.Server.BusinessEntity.Control.AvisoCaido)
        Dim aviso As New HM.MMS.AR.Server.BusinessEntity.Control.AvisoCaido()
        aviso.CodigoOrden = pId_Orden_Sigeme
        aviso.CodigoPresupuesto = pId_Presupuesto
        avisos.Add(aviso)
        AgenteControl.InsertarAvisosCaidos(pU_Alta, Constantes.COD_PAIS_ARGENTINA, pCompania, avisos)
        'MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_INSERT_AR_AVISOS_CAIDOS", pId_Presupuesto, pId_Orden_Sigeme, pU_Alta, pF_Alta)
    End Sub

    Public Sub AgregarAr_Clientes_Sig_Nau(ByVal pCod_Cli_Sig As Double, ByVal pCod_Cli_Nau As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_INSERT_AR_CLIENTES_SIG_NAU", pCod_Cli_Sig, pCod_Cli_Nau)
    End Sub

    Public Sub AgregarAr_Productos_Sig_Nau(ByVal pCod_Cli_Sig As Double, ByVal pCod_Cli_Nau As Double, ByVal pCod_Prod_Sig As Double, ByVal pCod_Prod_Nau As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_INSERT_AR_PRODUCTOS_SIG_NAU", pCod_Cli_Sig, pCod_Cli_Nau, pCod_Prod_Sig, pCod_Prod_Nau)
    End Sub

    Public Sub EliminarAvisoCaido(ByVal pId_Presupuesto As Double, ByVal pId_Orden_Sigeme As Double, ByVal pU_Alta As Integer, ByVal pCompania As Integer)
        Dim avisos As New System.Collections.Generic.List(Of HM.MMS.AR.Server.BusinessEntity.Control.AvisoCaido)
        Dim aviso As New HM.MMS.AR.Server.BusinessEntity.Control.AvisoCaido()
        aviso.CodigoOrden = Convert.ToInt32(pId_Orden_Sigeme)
        aviso.CodigoPresupuesto = Convert.ToInt32(pId_Presupuesto)
        avisos.Add(aviso)
        AgenteControl = New Mantenimiento
        AgenteControl.EliminarAvisoCaido(pU_Alta, pCompania, Constantes.COD_PAIS_ARGENTINA, avisos)
        'MyBase.Ejecutar("Spk_Control.SP_DELETE_AR_AVISOS_CAIDOS", pId_Presupuesto, pId_Orden_Sigeme)
    End Sub

    Public Sub EliminarAr_Clientes_Sig_Nau(ByVal pCod_Cli_Sig As Double, ByVal pCod_Cli_Nau As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_DELETE_AR_CLIENTES_SIG_NAU", pCod_Cli_Sig, pCod_Cli_Nau)
    End Sub

    Public Sub EliminarAr_Productos_Sig_Nau(ByVal pCod_Cli_Sig As Double, ByVal pCod_Cli_Nau As Double, ByVal pCod_Prod_Sig As Double, ByVal pCod_Prod_Nau As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_DELETE_AR_PRODUCTOS_SIG_NAU", pCod_Cli_Sig, pCod_Cli_Nau, pCod_Prod_Sig, pCod_Prod_Nau)
    End Sub

    Public Sub EliminarAvisosNoConfirmados(ByVal pCod_Presupuesto As Double, ByVal pCod_Orden_Origen As Double, ByVal pCod_Orden_Destino As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_DELETE_AR_AVISOS_NOCONF", pCod_Presupuesto, pCod_Orden_Origen, pCod_Orden_Destino)
    End Sub

    Public Sub EliminarAvisosManuales(ByVal pId_Presupuesto As Double, ByVal pId_Orden As Double)
        MyBase.Ejecutar("Spk_Control.SP_DELETE_AR_AVISOS_MANUALES", pId_Presupuesto, pId_Orden)
    End Sub

    Public Sub ActualizarAvisosNoConfirmados(ByVal pCod_Presupuesto As Double, ByVal pCod_Orden_Origen As Double, ByVal pCod_Orden_Destino As Double, ByVal pObservaciones As String)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_UPDATE_AR_AVISOS_NOCONF", pCod_Presupuesto, pCod_Orden_Origen, pCod_Orden_Destino, pObservaciones)
    End Sub

    Public Function BuscarPresupuestosPendiente(ByVal codCompania As Integer, ByVal pVigenciaDesde As DateTime, ByVal pVigenciaHasta As DateTime) As List(Of AvisoPresupuesto)
        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerPresupuestosPendientes(codCompania, pVigenciaDesde, pVigenciaHasta)

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_PRES_PENDIENTES", pVigenciaDesde, pVigenciaHasta)
    End Function

    Public Function BuscarOrdenesADesconfirmar() As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ORDENES_CONF", mCod_Presupuesto)
    End Function

    Public Function BuscarOrdenesADesconfirmar(ByVal codCompania As Integer, ByVal codPresupuesto As Integer) As KeyValuePair(Of String, List(Of AvisoConfirmado))

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ORDENES_CONF", mCod_Presupuesto)
    End Function

    Public Sub DesconfirmarOrden(ByVal pCod_Orden As Double)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_DESCONFIRMAR_ORDEN", pCod_Orden)
    End Sub

    Public Function BuscarOrdenesFacturadas() As DataSet
        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerOrdenesSinConfirmar(Integer.Parse(Cod_Presupuesto.ToString), Cod_Compania, True)

        'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ORDENES_FACT", mCod_Presupuesto)
    End Function

    Public Sub ActualizarConfirmacionesTV(ByVal pCod_Orden As Double, ByVal pFec_Confirmacion As DateTime, ByVal pUsuario As String, ByVal pAplicativo As String)
        MyBase.Ejecutar("Spk_" & MyBase.Tabla & ".SP_UPDATE_CONF_TV", pCod_Orden, pFec_Confirmacion, pAplicativo, pUsuario)
    End Sub

    'JJP - Matcheo interior
    ''' <summary>
    ''' Trae los códigos de Admedia para los códigos de soporte de la pauta
    ''' </summary>
    ''' <param name="codSoporte">Los soportes a buscar</param>
    ''' <returns>Tabla SOPORTES_ADMEDIA</returns>
    Public Function BuscarAr_Soportes_Admedia(ByVal codSoporte As String) As DataSet
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_AR_SOPORTES_ADMEDIA", codSoporte)
    End Function

    Public Function TraeAvisosConfirmados(ByVal Soportes As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Return MyBase.TraerDataSet("SPK_" & MyBase.Tabla & ".SP_SELECT_AR_AVISOS_CONF", fechaDesde, fechaHasta, Soportes).Tables(0)
    End Function

    'Public Function TraerSpotsAdmediaInterior(ByVal tipoSoporte As Integer, ByVal tipo_Aviso As String) As DataSet
    '    Dim admedia As New Admedia_Matcheo

    '    Return admedia.TraerSpotsMatcheoInterior(mFecha_Desde, mFecha_Hasta, mCod_Soporte, mCod_Cli, mCod_Producto, tipo_Aviso, tipoSoporte)

    'End Function

    Public Function TraerSpotsAdmedia(ByVal tipoSoporte As Integer, ByVal tipo_Aviso As String) As DataSet
        Dim admedia As New Admedia.DBL.Admedia_Matcheo
        Return admedia.TraerSpotsMatcheo(mFecha_Desde, mFecha_Hasta, mCod_Soporte, mCod_Cli, mCod_Producto, tipo_Aviso, tipoSoporte)
    End Function

    Public Function TraerTipoSoportes(ByVal medio As Integer) As DataTable

        mMaestros = New Maestros
        Dim dt As New DataTable
        Dim tipos As New System.Collections.Generic.List(Of Integer)

        tipos.Add(1)
        tipos.Add(2)

        Return mMaestros.TipoSoporteByMedioByTipoSoporte(Constantes.COD_PAIS_ARGENTINA, medio, tipos)

        'Return MyBase.TraerDataSet("SPK_" & MyBase.Tabla & ".SP_SELECT_TIPOS_SOPORTE")

    End Function

    Public Function TraerSpotConfirmadoAdmedia(ByVal codProducto As Integer, ByVal codCliente As Integer, _
                    ByVal codSoportes As String, ByVal hora As Integer, ByVal segundos As Integer, _
                    ByVal fecha As Date, ByVal codTipoSoporte As Integer) As DataSet

        Dim admedia As New Admedia.DBL.Admedia_Matcheo
        Return admedia.TraerSpotConfirmado(codProducto, codCliente, codSoportes, hora, segundos, fecha, codTipoSoporte)

    End Function

    Public Function ObtenerPresupuesto(ByVal codPais As Integer, ByVal codCompania As Integer, ByVal codPresupuesto As Integer) As PresupuestoEntidad

        mMaestros = New Maestros

        Return mMaestros.presupuestoTraer(codPais, codCompania, codPresupuesto)

    End Function

    Public Function ArmarDtPresupuesto(ByVal presupuesto As PresupuestoEntidad) As DataTable

        Dim dr As DataRow
        Dim dtPresupuesto As DataTable

        If Not presupuesto Is Nothing Then

            dtPresupuesto = New DataTable
            dtPresupuesto.Columns.Add("CLIENTE", GetType(String))
            dtPresupuesto.Columns.Add("PRODUCTO", GetType(String))
            dtPresupuesto.Columns.Add("CAMPANIA", GetType(String))
            dtPresupuesto.Columns.Add("PERIODO", GetType(String))
            dtPresupuesto.Columns.Add("PAUTA", GetType(Integer))
            dtPresupuesto.Columns.Add("MEDIO", GetType(Integer))
            'LC 02/07/2014 Restriccion de envio de ajustes de pautas planificadas
            dtPresupuesto.Columns.Add("TIPO", GetType(String))

            dr = dtPresupuesto.NewRow()
            dr("CLIENTE") = presupuesto.Subcampana.Campana.Cliente.DescripcionCliente
            dr("PRODUCTO") = presupuesto.Subcampana.Campana.Producto.Descripcion
            dr("CAMPANIA") = presupuesto.Subcampana.Campana.Descripcion
            dr("PERIODO") = CultureInfo.GetCultureInfo("es-AR").DateTimeFormat.GetMonthName(presupuesto.FechaEmisionOrdenes.Month)
            dr("PAUTA") = presupuesto.Codigo.Value
            dr("MEDIO") = presupuesto.Subcampana.Medio.CodMedio.Value
            'LC 02/07/2014 Restriccion de envio de ajustes de pautas planificadas
            dr("TIPO") = presupuesto.Tipo

            dtPresupuesto.Rows.Add(dr)

        End If

        Return dtPresupuesto

    End Function

    Public Function InsertarAvisosConfirmados(ByVal lAvisos As List(Of AvisoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.InsertarAvisosConfirmados(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, lAvisos)

    End Function

    Public Function InsertarAvisosNoConfirmados(ByVal lAvisos As List(Of AvisoNoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.InsertarAvisosNoConfirmados(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, lAvisos)

    End Function

    Public Function InsertarAvisosManuales(ByVal lAvisos As List(Of AvisoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.InsertarAvisosManuales(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, lAvisos)

    End Function

    Public Function ActualizarAvisosNoConfirmados(ByVal lAvisos As List(Of AvisoNoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.ActualizarAvisosNoConfirmados(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, lAvisos)

    End Function

    Public Function EliminarAvisosNoConfirmados(ByVal lAvisos As List(Of AvisoNoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.EliminarAvisosNoConfirmados(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, lAvisos)

    End Function

    Public Function EliminarAvisosManuales(ByVal lAvisos As List(Of AvisoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.EliminarAvisosManuales(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, lAvisos)

    End Function

    Public Function ConfirmarAvisos(ByVal lAvisos As List(Of AvisoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.ConfirmarAvisos(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, Activo.Login, Activo.PassWd, lAvisos)

    End Function

    Public Function ObtenerAvisosConfirmados(ByVal codCompania As Integer, ByVal lSoportes As List(Of Integer), ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime) As Dictionary(Of String, List(Of AvisoConfirmado))
        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerAvisosConfirmados(codCompania, lSoportes, fechaDesde, fechaHasta)

    End Function

    Public Function DesconfirmarAvisos(ByVal lAvisos As List(Of AvisoConfirmado)) As String
        AgenteControl = New Mantenimiento

        Return AgenteControl.DesconfirmarAvisos(Activo.CodUsuarioMms, Activo.CodPaisMms, Activo.IDCompaniaMMS, lAvisos)

    End Function

    Public Function ObtenerOrdenesConfirmados(ByVal codCompania As Integer, ByVal codPresupuesto As Integer, ByVal ordenamiento As String) As Dictionary(Of String, List(Of AvisoConfirmado))
        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerOrdenesConfirmadas(codCompania, codPresupuesto, ordenamiento)

    End Function

    Public Function ObtenerDatosActualizacion() As DataTable
        Dim admedia As New Admedia.DBL.Admedia_Matcheo

        Return admedia.ObtenerEstadoActualizacion

    End Function

    Public Function ObtenerDatosDisponibles(ByVal anio As Integer, ByVal mes As Integer) As DataTable
        Dim admedia As New Admedia.DBL.Admedia_Matcheo

        Return admedia.ObtenerDatosCargados(anio, mes)

    End Function

    ''' <summary>
    ''' JJP - Obtiene la informacion de ordenes confirmadas de MMS
    ''' </summary>
    ''' <param name="codCompania"></param>
    ''' <param name="codCliente"></param>
    ''' <param name="fechaDesde">Fecha de ejecucion del aviso desde</param>
    ''' <param name="fechaHasta">Fecha de ejecucion del aviso hasta</param>
    ''' <returns>Un diccionario con el valor key vacío en caso de que la operación sea exitosa o con el mensaje de error en caso contrario.
    ''' \r\n Una lista de OrdenConfirmada</returns>
    ''' <remarks></remarks>
    ''' 

    Public Function ObtenerOrdenesConfirmadasCPR(ByVal codCompania As Integer, ByVal codCliente As Integer, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As Dictionary(Of String, List(Of OrdenConfirmada))
        AgenteControl = New Mantenimiento

        Return AgenteControl.ObtenerOrdenesConfirmadasCPR(codCompania, codCliente, fechaDesde, fechaHasta)

    End Function

    'AG 25/02/2013 +++++++++++++++

    Public Function ObtenerSoportesPermitidos() As DataTable
        Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SOPORTES_PERMITIDOS").Tables(0)
    End Function

    'Return MyBase.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_SELECT_ORDENES_MACHEO", mCod_Presupuesto).Tables(0)

#Region "Metodos de Ajuste Automatico en MMS"

    Public Function InsertarAvisosAjuste(ByVal lAvisosAjustar As List(Of AvisosAjustes)) As String

        Dim ResultadoInsert As String

        AgenteControl = New Mantenimiento
        ResultadoInsert = AgenteControl.InsertarAvisosAjuste(lAvisosAjustar)
        Return ResultadoInsert

    End Function

    Public Function GenerarAjusteAutomatico(ByVal CodCompania As Integer, ByVal CodPresupuesto As Integer) As List(Of AvisosAjustes)

        Dim LOrdenesAjustadas As List(Of AvisosAjustes)
        AgenteControl = New Mantenimiento

        LOrdenesAjustadas = AgenteControl.GenerarAjustesOrdenes(CodCompania, CodPresupuesto)

        Return LOrdenesAjustadas

    End Function

    Public Function ValidarAjustesExistentes(ByVal CodCompania As Integer, ByVal CodPresupuesto As Integer) As List(Of Integer)

        Dim LOrdenesExistente As List(Of Integer)

        AgenteControl = New Mantenimiento

        LOrdenesExistente = AgenteControl.ValidarAjustesExistentes(CodCompania, CodPresupuesto)

        Return LOrdenesExistente

    End Function

#End Region

    Public Function ObtenerHoraInicioFinAviso(ByVal Ds As DataSet) As DataSet

        Dim DtAvisosHorario As New DataTable
        Dim DrRegistros As DataRow
        Dim Dr As DataRow
        Dim DtTarifasTv As DataTable = Ds.Tables(0).DefaultView.ToTable(True, "COD_TARIFA")
        Dim RowRegistroOrden As DataRow()
        Dim j As Integer

        With Ds.Tables(0)
            .Columns.Add("HMDESDE", GetType(String))
            .Columns.Add("HMHASTA", GetType(String))
        End With

        Dim DtFinal As DataTable = Ds.Tables(0).Clone
        DtFinal = Ds.Tables(0).Copy

        For Each DrRegistros In DtTarifasTv.Rows
            If DrRegistros("COD_TARIFA").ToString <> "" Or IsDBNull(DrRegistros("COD_TARIFA")) = False Then
                DtAvisosHorario = MyBase.TraerDataSet("SPK_TARIFAS_TV.OBTENER_HORA_INICIO_FIN", DrRegistros("COD_TARIFA")).Tables(0)
                If DtAvisosHorario.Rows.Count > 0 Then
                    'RowRegistroOrden = Nothing
                    For Each Dr In DtFinal.Rows
                        If Dr("COD_TARIFA").ToString <> "" Or IsDBNull(Dr("COD_TARIFA")) = False Then
                            If Dr("COD_TARIFA") = DrRegistros("COD_TARIFA") Then
                                Dr("HMDESDE") = DtAvisosHorario.Rows(0)("HMDESDE")
                                Dr("HMHASTA") = DtAvisosHorario.Rows(0)("HMHASTA")
                            End If
                        End If
                    Next
                End If
            End If
        Next

        Ds.Tables.RemoveAt(0)
        Ds.Tables.Add(DtFinal)


        Return Ds

    End Function

    Public Sub Realizar_Ajuste(ByVal ID_ORDEN_MMS As Integer, ByVal NETO_AJUSTE As Double, ByVal BRUTO_AJUSTE As Double, ByVal DURACION As Integer, ByVal ID_ORDEN_MMS_NEW As Integer)
        MyBase.Ejecutar("SPK_SPOTS_DETALLE.SP_AJUSTE_SPOTS_DETALLE", ID_ORDEN_MMS, NETO_AJUSTE, BRUTO_AJUSTE, Activo.Login, ID_ORDEN_MMS_NEW)
    End Sub

#End Region

    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar otro estado (objetos administrados).
            End If

            ' TODO: Liberar su propio estado (objetos no administrados).
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

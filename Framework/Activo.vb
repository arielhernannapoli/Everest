Public Class ColorEstado
    Public Shared ColorActivo As System.Drawing.Color = System.Drawing.Color.Green
    Public Shared ColorFinal As System.Drawing.Color = System.Drawing.Color.Blue
    Public Shared ColorACompra As System.Drawing.Color = System.Drawing.Color.Red
End Class
Public Enum TipoListado
    ClienteVig = 1
    ClienteNoVig = 2
    ClienteMedioVig = 3
    ClienteMedioNoVig = 4
    ClienteMedioTipoSoporteVig = 5
    ClienteMedioTipoSoporteNoVig = 6
    MedioVig = 7
    MedioNoVig = 8
    MedioTipoSoporteVig = 9
    MedioTipoSoporteNoVig = 10
    MedioTipoVig = 11
    MedioTipoNoVig = 12
    ClienteMedioTipoVig = 13
    ClienteMedioTipoNoVig = 14
End Enum
Public Enum ReporteMotorP
    General = 1
    PorCanal = 2
    PorSemana7 = 3
    PorSemanaC = 4
    PorTema = 5
    PorAvisos = 6
End Enum
Public Enum CapacidadesUsuario
    Planificador = 5
    Compras = 6
    Sistemas = 2
    Finansas = 4
    Direccion = 7
End Enum
Public Enum EstadoEjercicio
    Activo = 1
    Final = 2
    Compra = 3
End Enum
'En este tipo se guarda la informacion
'del ultimo sistema
Public Structure DatosSistema

    Dim idCampaña As Integer
    Dim FechaInicio As Date
    Dim FechaFin As Date
    Dim FechaInicioAud As Date
    Dim FechaFinAud As Date
    Dim Descripcion As String
    Dim Target1 As ItemLista
    Dim Target2 As ItemLista
    'Dim idTarget1 As Integer
    'Dim idTarget2 As Integer
    Dim Bruto As Decimal
    Dim Neto As Decimal
    Dim FechaOpcional As Date
    Dim TipoRating As String
    Dim idTipoSoporte As Integer
    Dim TipoSoporte As String
    Dim Deflactacion As Decimal
    Dim Franja As String
    Dim idFranja As Integer
    Dim idPlaza As Integer
    Dim Plaza As String
End Structure




Public Class Activo
    ' Public Shared CalculoCpr As New CalculoCpr
    Public Shared Control As Boolean
    Public Shared UltimoSistema As DatosSistema
    Shared mProducto As String
    Shared mEmpresa As String
    Shared mTarget As String
    Shared mIDUsuario As Short
    Shared mLogin As String
    Shared mPassWd As String
    Shared mNombre As String
    Shared mApellido1 As String
    Shared mApellido2 As String

    Shared idDelegacion As Integer

    Shared mIDPerfil_Datos As Short

    Shared mIDCliente As Integer
    Shared mCliente As String

    Shared mIDCampaña As Integer
    Shared mCampaña As String

    Shared mIDSistema As Integer
    Shared mSistema As String

    Shared mIDEjercicio As Integer
    Shared mEjercicio As String
    Shared mIDEstadoEjercicio As Integer

    Shared mIDTema As Integer
    Shared mIDAlternativa As Integer
    Shared mIDMedio As Integer
    Shared mIDTipoSoporte As Integer
    Shared mIDPlaza As Integer

    Shared mFechaInicioCampaña As Date
    Shared mFechaFinCampaña As Date

    Shared mFechaInicioSistema As Date
    Shared mFechaFinSistema As Date

    Shared mFechaDesdeCampaña As Date
    Shared mFechaHastaCampaña As Date

    Shared mFechaInicioAudiencia As Date
    Shared mFechaFinAudiencia As Date

    Shared mNodoIndiceSeleccionado As Integer
    'AG 05/06/2014 ============
    Shared mIDTipoEjercicio As Integer
    '==========================

    Shared mEjerciciosCargados As ArrayList
    Shared mEstado As Integer
    Shared mPlaza As String
    Shared mEspeciales As ArrayList
    Shared mId_Cod_Capacidad As Short

    Shared mIDCompaniaMMS As Integer
    Shared mIDUsuarioMMS As Integer
    Shared mDTClientes As DataTable
    Shared mDTMedios As DataTable
    Shared mDTCompanias As DataTable
    Shared mDTDelegaciones As DataTable
    Shared mDTSoportes As DataTable
    Shared mDTProductos As DataTable
    Shared mDTMateriales As DataTable
    Shared mDTPlaza As DataTable
    Shared mDTSoportesCache As DataTable
    Shared mDTProductosCache As DataTable
    Shared mDTMaterialesCache As DataTable
    Shared mDTClientesCache As DataTable
    Shared mDTPlazaCache As DataTable
    Shared mDTTipoSoporteCache As DataTable
    Shared mDTMediosCache As DataTable
    Shared mDTCompaniasCache As DataTable
    Shared mDTDelegacionesCache As DataTable
    Shared mDTProveedorCache As DataTable
    Shared mDTProveedorSoporteCache As DataTable
    Shared mDTSeccionesCache As DataTable
    Shared mDTProvinciaCache As DataTable
    Shared mDTPoblacionCache As DataTable

    Shared mDTColocacionesCache As DataTable
    Shared mDTFormatosCache As DataTable
    Shared mDTSeccionesInternetCache As DataTable
    Shared mDTServicioAgenciaInterneteCache As DataTable

    'Shared _IdEdritorial As Integer
    'Shared mIdContrato As String
    'Shared mBonificacion As Boolean
    'Shared mTEjecicioActivo As Integer
    'Shared mColumnaDescTarifa As String

    ''propiedades de usuario MMS
    Shared mmsCodPaisActual As Integer
    Shared mmsCodUsuario As Integer
    Shared mmsCodCampaniaActual As Integer
    Shared MaterialEjercicio As Boolean
    'AG CP +++++++++++++++++++++++
    Shared mTEjecicioActivo As Integer
    '+++++++++++++++++++++++++++
    Shared _Alternativanueva As Integer
    Shared mDBConexionTEC10GP As Boolean 'AG DBCompania
    Shared mPerfilConvenios As Integer
    Shared mmsCantidadDiasBloqueoPresupuesto As Integer

#Region "Argentina Datatables Maestros"

    Shared mDTEditorial As DataTable

    'AG 23/10/2013 DIGITAL =================================================
    Public Shared Property DTSeccionesInternetCache() As DataTable
        Get
            Return mDTSeccionesInternetCache
        End Get
        Set(ByVal Value As DataTable)
            mDTSeccionesInternetCache = Value
        End Set
    End Property

    Public Shared Property DTServicioAgenciaInterneteCache() As DataTable
        Get
            Return mDTServicioAgenciaInterneteCache
        End Get
        Set(ByVal Value As DataTable)
            mDTServicioAgenciaInterneteCache = Value
        End Set
    End Property

    Public Shared Property DTColocacionesCache() As DataTable
        Get
            Return mDTColocacionesCache
        End Get
        Set(ByVal Value As DataTable)
            mDTColocacionesCache = Value
        End Set
    End Property

    Public Shared Property DTFormatosCache() As DataTable
        Get
            Return mDTFormatosCache
        End Get
        Set(ByVal Value As DataTable)
            mDTFormatosCache = Value
        End Set
    End Property
    '======================================================================

    Public Shared Property DTProvinciaCache() As DataTable
        Get
            Return mDTProvinciaCache
        End Get
        Set(ByVal Value As DataTable)
            mDTProvinciaCache = Value
        End Set
    End Property

    Public Shared Property DTPoblacionCache() As DataTable
        Get
            Return mDTPoblacionCache
        End Get
        Set(ByVal Value As DataTable)
            mDTPoblacionCache = Value
        End Set
    End Property


    Public Shared Property DTSeccionesCache() As DataTable
        Get
            Return mDTSeccionesCache
        End Get
        Set(ByVal Value As DataTable)
            mDTSeccionesCache = Value
        End Set
    End Property

    Public Shared Property DTPlazaCache() As DataTable
        Get
            Return mDTPlazaCache
        End Get
        Set(ByVal Value As DataTable)
            mDTPlazaCache = Value
        End Set
    End Property

    Public Shared Property DTProductosCache() As DataTable
        Get
            Return mDTProductosCache
        End Get
        Set(ByVal Value As DataTable)
            mDTProductosCache = Value
        End Set
    End Property

    Public Shared Property DTMaterialesCache() As DataTable
        Get
            Return mDTMaterialesCache
        End Get
        Set(ByVal Value As DataTable)
            mDTMaterialesCache = Value
        End Set
    End Property

    Public Shared Property DTClientesCache() As DataTable
        Get
            Return mDTClientesCache
        End Get
        Set(ByVal Value As DataTable)
            mDTClientesCache = Value
        End Set
    End Property

    Public Shared Property DTSoportesCache() As DataTable
        Get
            Return mDTSoportesCache
        End Get
        Set(ByVal Value As DataTable)
            mDTSoportesCache = Value
        End Set
    End Property

    Public Shared Property DTProveedorCache() As DataTable
        Get
            Return mDTProveedorCache
        End Get
        Set(ByVal Value As DataTable)
            mDTProveedorCache = Value
        End Set
    End Property

    Public Shared Property DTEditorial() As DataTable
        Get
            Return mDTEditorial
        End Get
        Set(ByVal value As DataTable)
            mDTEditorial = value
        End Set
    End Property

    Public Shared Property DTClientes() As DataTable
        Get
            Return mDTClientes
        End Get
        Set(ByVal Value As DataTable)
            mDTClientes = Value
        End Set
    End Property

    Public Shared Property DTMedios() As DataTable
        Get
            Return mDTMedios
        End Get
        Set(ByVal Value As DataTable)
            mDTMedios = Value
        End Set
    End Property
    Public Shared Property DTCompanias() As DataTable
        Get
            Return mDTCompanias
        End Get
        Set(ByVal Value As DataTable)
            mDTCompanias = Value
        End Set
    End Property
    Public Shared Property DTDelegaciones() As DataTable
        Get
            Return mDTDelegaciones
        End Get
        Set(ByVal Value As DataTable)
            mDTDelegaciones = Value
        End Set
    End Property

    Public Shared Property DTSoportes() As DataTable
        Get
            Return mDTSoportes
        End Get
        Set(ByVal Value As DataTable)
            mDTSoportes = Value
        End Set
    End Property

    Public Shared Property DTProductos() As DataTable
        Get
            Return mDTProductos
        End Get
        Set(ByVal Value As DataTable)
            mDTProductos = Value
        End Set
    End Property

    Public Shared Property DTMateriales() As DataTable
        Get
            Return mDTMateriales
        End Get
        Set(ByVal Value As DataTable)
            mDTMateriales = Value
        End Set
    End Property
    Public Shared Property DTPlaza() As DataTable
        Get
            Return mDTPlaza
        End Get
        Set(ByVal Value As DataTable)
            mDTPlaza = Value
        End Set
    End Property

    Public Shared Property DTTipoSoporteCache() As DataTable
        Get
            Return mDTTipoSoporteCache
        End Get
        Set(ByVal Value As DataTable)
            mDTTipoSoporteCache = Value
        End Set
    End Property
    Public Shared Property DTMediosCache() As DataTable
        Get
            Return mDTMediosCache
        End Get
        Set(ByVal Value As DataTable)
            mDTMediosCache = Value
        End Set
    End Property
    Public Shared Property DTCompaniasCache() As DataTable
        Get
            Return mDTCompaniasCache
        End Get
        Set(ByVal Value As DataTable)
            mDTCompaniasCache = Value
        End Set
    End Property
    Public Shared Property DTDelegacionesCache() As DataTable
        Get
            Return mDTDelegacionesCache
        End Get
        Set(ByVal Value As DataTable)
            mDTDelegacionesCache = Value
        End Set
    End Property
    Public Shared Property IDCompaniaMMS() As Integer
        Get
            Return mIDCompaniaMMS
        End Get
        Set(ByVal Value As Integer)
            mIDCompaniaMMS = Value
        End Set
    End Property

    Public Shared Property IDUsuarioMMS() As Integer
        Get
            Return mIDUsuarioMMS
        End Get
        Set(ByVal Value As Integer)
            mIDUsuarioMMS = Value
        End Set
    End Property

#End Region

#Region "Datos del usuario MMS"

    Public Shared Property CodPaisMms() As String
        Get
            Return mmsCodPaisActual
        End Get
        Set(ByVal value As String)
            mmsCodPaisActual = value
        End Set
    End Property

    Public Shared Property CodUsuarioMms() As String
        Get
            Return mmsCodUsuario
        End Get
        Set(ByVal value As String)
            mmsCodUsuario = value
        End Set
    End Property

    Public Shared Property CantidadDiasBloqueoPresupuestoMms() As Integer
        Get
            Return mmsCantidadDiasBloqueoPresupuesto
        End Get
        Set(ByVal value As Integer)
            mmsCantidadDiasBloqueoPresupuesto = value
        End Set
    End Property

    Public Shared Property CodCampaniaActualMms() As String
        Get
            Return mmsCodCampaniaActual
        End Get
        Set(ByVal value As String)
            mmsCodCampaniaActual = value
        End Set
    End Property

    Public Shared Property IsMaterialEjercicio() As Boolean
        Get
            Return MaterialEjercicio
        End Get
        Set(ByVal value As Boolean)
            MaterialEjercicio = value
        End Set
    End Property


    Public Shared Property DBConexionTEC10GP() As Boolean 'AG DBCompania
        Get
            Return mDBConexionTEC10GP
        End Get
        Set(ByVal value As Boolean)
            mDBConexionTEC10GP = value
        End Set
    End Property

#End Region

    Public Shared Property PerfilConvenios() As Integer
        Get
            Return mPerfilConvenios
        End Get
        Set(ByVal Value As Integer)
            mPerfilConvenios = Value
        End Set
    End Property

    Public Shared Property Alternativanueva() As Integer
        Get
            Return _Alternativanueva
        End Get
        Set(ByVal value As Integer)
            _Alternativanueva = value
        End Set
    End Property
    Public Shared Property CodCapacidad() As Short
        Get
            Return mId_Cod_Capacidad
        End Get
        Set(ByVal Value As Short)
            mId_Cod_Capacidad = Value
        End Set
    End Property

    Public Shared Property Especiales() As ArrayList
        Get
            If mEspeciales Is Nothing Then
                mEspeciales = New ArrayList
            End If

            Return mEspeciales
        End Get
        Set(ByVal Value As ArrayList)
            mEspeciales = Value
        End Set
    End Property

    Public Shared Property Plaza() As String
        Get
            Return mPlaza
        End Get
        Set(ByVal Value As String)
            mPlaza = Value
        End Set
    End Property


    Public Shared Property Id_Delegacion() As String
        Get
            Return idDelegacion
        End Get
        Set(ByVal value As String)
            idDelegacion = value
        End Set
    End Property

    Public Shared Property Producto() As String
        Get
            Return mProducto
        End Get
        Set(ByVal Value As String)
            mProducto = Value
        End Set
    End Property
    Public Shared Property Target() As String
        Get
            Return mTarget
        End Get
        Set(ByVal Value As String)
            mTarget = Value
        End Set
    End Property
    Public Shared Property Empresa() As String
        Get
            Return mEmpresa
        End Get
        Set(ByVal Value As String)
            mEmpresa = Value
        End Set
    End Property

    Public Shared Property Estado() As Integer
        Get
            Return mEstado
        End Get
        Set(ByVal Value As Integer)
            mEstado = Value
        End Set
    End Property
    Public Shared Property EjerciciosCargados() As ArrayList
        Get
            If mEjerciciosCargados Is Nothing Then
                mEjerciciosCargados = New ArrayList
            End If

            Return mEjerciciosCargados
        End Get
        Set(ByVal Value As ArrayList)
            mEjerciciosCargados = Value
        End Set
    End Property
    Public Shared Property Cliente() As String
        Get
            Return mCliente
        End Get
        Set(ByVal Value As String)
            mCliente = Value
        End Set
    End Property

    Public Shared Property FechaInicioAudiencia() As Date
        Get
            Return mFechaInicioAudiencia
        End Get
        Set(ByVal Value As Date)
            mFechaInicioAudiencia = Value
        End Set
    End Property
    Public Shared Property FechaFinAudiencia() As Date
        Get
            Return mFechaFinAudiencia
        End Get
        Set(ByVal Value As Date)
            mFechaFinAudiencia = Value
        End Set
    End Property
    Public Shared Property FechaDesdeCampaña() As Date
        Get
            Return mFechaDesdeCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaDesdeCampaña = Value
        End Set
    End Property

    Public Shared Property FechaHastaCampaña() As Date
        Get
            Return mFechaHastaCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaHastaCampaña = Value
        End Set
    End Property

    Public Shared Property IDUsuario() As Short
        Get
            Return mIDUsuario
        End Get
        Set(ByVal Value As Short)
            mIDUsuario = Value
        End Set
    End Property

    Public Shared Property Login() As String
        Get
            Return mLogin
        End Get
        Set(ByVal Value As String)
            mLogin = Value
        End Set
    End Property

    Public Shared Property PassWd() As String
        Get
            Return mPassWd
        End Get
        Set(ByVal Value As String)
            mPassWd = Value
        End Set
    End Property

    Public Shared Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal Value As String)
            mNombre = Value
        End Set
    End Property

    Public Shared Property Apellido1() As String
        Get
            Return mApellido1
        End Get
        Set(ByVal Value As String)
            mApellido1 = Value
        End Set
    End Property

    Public Shared Property Apellido2() As String
        Get
            Return mApellido2
        End Get
        Set(ByVal Value As String)
            mApellido2 = Value
        End Set
    End Property

    Public Shared Property IDPerfil_Datos() As Short
        Get
            Return mIDPerfil_Datos
        End Get
        Set(ByVal Value As Short)
            mIDPerfil_Datos = Value
        End Set
    End Property

    Public Shared Property IDCliente() As Integer
        Get
            Return mIDCliente
        End Get
        Set(ByVal Value As Integer)
            mIDCliente = Value
        End Set
    End Property

    'AG 05/06/2014 ===============================
    Public Shared Property IDTipoEjercicio() As Integer
        Get
            Return mIDTipoEjercicio
        End Get
        Set(ByVal Value As Integer)
            mIDTipoEjercicio = Value
        End Set
    End Property

    Public Shared Property IDCampaña() As Integer
        Get
            Return mIDCampaña
        End Get
        Set(ByVal Value As Integer)
            mIDCampaña = Value
        End Set
    End Property

    Public Shared Property FechaInicioCampaña() As Date
        Get
            Return mFechaInicioCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaInicioCampaña = Value
        End Set
    End Property

    Public Shared Property FechaFinCampaña() As Date
        Get
            Return mFechaFinCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaFinCampaña = Value
        End Set
    End Property

    Public Shared Property FechaInicioSistema() As Date
        Get
            Return mFechaInicioSistema
        End Get
        Set(ByVal Value As Date)
            mFechaInicioSistema = Value
        End Set
    End Property

    Public Shared Property FechaFinSistema() As Date
        Get
            Return mFechaFinSistema
        End Get
        Set(ByVal Value As Date)
            mFechaFinSistema = Value
        End Set
    End Property

    Public Shared Property IDSistema() As Integer
        Get
            Return mIDSistema
        End Get
        Set(ByVal Value As Integer)
            mIDSistema = Value
        End Set
    End Property

    Public Shared Property IDTema() As Integer
        Get
            Return mIDTema
        End Get
        Set(ByVal Value As Integer)
            mIDTema = Value
        End Set
    End Property

    Public Shared Property IDEjercicio() As Integer
        Get
            Return mIDEjercicio
        End Get
        Set(ByVal Value As Integer)
            mIDEjercicio = Value
        End Set
    End Property

    Public Shared Property IDAlternativa() As Integer
        Get
            Return mIDAlternativa
        End Get
        Set(ByVal Value As Integer)
            mIDAlternativa = Value
        End Set
    End Property

    Public Shared Property IDMedio() As Integer
        Get
            Return mIDMedio
        End Get
        Set(ByVal Value As Integer)
            mIDMedio = Value
        End Set
    End Property

    Public Shared Property IDTipoSoporte() As Integer
        Get
            Return mIDTipoSoporte
        End Get
        Set(ByVal Value As Integer)
            mIDTipoSoporte = Value
        End Set
    End Property

    Public Shared Property IDPlaza() As Integer
        Get
            Return mIDPlaza
        End Get
        Set(ByVal Value As Integer)
            mIDPlaza = Value
        End Set
    End Property

    Public Shared Property NodoIndiceSeleccionado() As Integer
        Get
            Return mNodoIndiceSeleccionado
        End Get
        Set(ByVal Value As Integer)
            mNodoIndiceSeleccionado = Value
        End Set
    End Property

    Public Shared Property Campaña() As String
        Get
            Return mCampaña
        End Get
        Set(ByVal Value As String)
            mCampaña = Value
        End Set
    End Property

    Public Shared Property Sistema() As String
        Get
            Return mSistema
        End Get
        Set(ByVal Value As String)
            mSistema = Value
        End Set
    End Property

    Public Shared Property Ejercicio() As String
        Get
            Return mEjercicio
        End Get
        Set(ByVal Value As String)
            mEjercicio = Value
        End Set
    End Property

    Public Shared Property IDEstadoEjercicio() As Integer
        Get
            Return mIDEstadoEjercicio
        End Get
        Set(ByVal Value As Integer)
            mIDEstadoEjercicio = Value
        End Set
    End Property

    'AG CP ++++++++++++++++++++++++++++++++
    Public Shared Property TEjecicioActivo() As Integer
        Get
            Return mTEjecicioActivo
        End Get
        Set(ByVal Value As Integer)
            mTEjecicioActivo = Value
        End Set
    End Property
    '+++++++++++++++++++++++++++++++++++++
    Public Enum DiaSemana
        Lunes = 1
        Martes = 2
        Miercoles = 3
        Jueves = 4
        Viernes = 5
        Sabado = 6
        Domingo = 0
    End Enum

    'AG CP ++++++++++++++++
    Public Enum TipoEjercicio
        Estandar = 0
        CPunto = 1
    End Enum
    '++++++++++++++++++++

    Public Enum Medios
        Tv = 1
        Radio = 6
        Exterior = 3
        Prensa = 4
        Revista = 5
        Produccion = 7
        Internet = 2
    End Enum

    Public Enum PerfilConvenio
        Administrador = 1
        ConsultaDos = 2
        ConsultaTres = 3
        SinPermisos = 4
    End Enum

    Public Enum CachesMMS
        CacheSoportes = 1
        CacheMateriales = 2
        CacheProductos = 3
        CacheClientes = 4
        CacheTipoSoportes = 5
        CacheMedios = 6
        CachePlazas = 7
        CacheProveedor = 8
        CacheSecciones = 9
        CacheProvincia = 10
        CachePoblacion = 11
    End Enum
End Class
Public Enum Medios
    Tv = 1
    Radio = 6
    Exterior = 3
    Prensa = 4
    Revista = 5
    Produccion = 7 'AG Produccion
    Internet = 2   'AG 22/10/2013 DIGITAL 
End Enum



Public Structure EjercicioActivo
    Dim IDCampaña As Integer
    Dim IDSistema As Integer
    Dim IDEjercicio As Integer
End Structure
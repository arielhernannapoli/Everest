Imports Framework
Imports MSL

Public Class Spots_detalle
    Inherits Entidad
    Implements IDisposable

#Region "Propiedades"
    Dim mId_spot As Int64
    Dim mId_spot_detalle As Int64
    Dim mF_spot As DateTime
    Dim mDuracion As Int32
    Dim mId_tema As String
    Dim mF_alta As DateTime
    Dim mU_alta As String
    Dim mF_modi As DateTime
    Dim mU_modi As String

    Public Property Id_spot() As Int64
        Get
            Return mId_spot
        End Get
        Set(ByVal Value As Int64)
            mId_spot = Value
        End Set
    End Property

    Public Property Id_spot_detalle() As Int64
        Get
            Return mId_spot_detalle
        End Get
        Set(ByVal Value As Int64)
            mId_spot_detalle = Value
        End Set
    End Property

    Public Property F_spot() As DateTime
        Get
            Return mF_spot
        End Get
        Set(ByVal Value As DateTime)
            mF_spot = Value
        End Set
    End Property

    Public Property Duracion() As Int32
        Get
            Return mDuracion
        End Get
        Set(ByVal Value As Int32)
            mDuracion = Value
        End Set
    End Property

    Public Property Id_tema() As String
        Get
            Return mId_tema
        End Get
        Set(ByVal Value As String)
            mId_tema = Value
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
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Spots_Detalle")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_spot, Id_spot_detalle, F_spot, Duracion, Id_tema, F_alta, U_alta, F_modi, U_modi)
    End Function

    'Public Overloads Function Modificar() As Object
    '    MyBase.Modificar(Id_spot, Id_spot_detalle, F_spot, Duracion, Id_tema, F_alta, U_alta, F_modi, U_modi)
    'End Function

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
        Me.Id_spot_detalle = IIf(IsDBNull(Dr("Id_spot_detalle")), 0, Dr("Id_spot_detalle"))
        Me.F_spot = IIf(IsDBNull(Dr("F_spot")), Nothing, Dr("F_spot"))
        Me.Duracion = IIf(IsDBNull(Dr("Duracion")), 0, Dr("Duracion"))
        Me.Id_tema = IIf(IsDBNull(Dr("Id_tema")), "", Dr("Id_tema"))
        Me.F_alta = IIf(IsDBNull(Dr("F_alta")), Nothing, Dr("F_alta"))
        Me.U_alta = IIf(IsDBNull(Dr("U_alta")), "", Dr("U_alta"))
        Me.F_modi = IIf(IsDBNull(Dr("F_modi")), Nothing, Dr("F_modi"))
        Me.U_modi = IIf(IsDBNull(Dr("U_modi")), "", Dr("U_modi"))
    End Sub

    Private Sub BuscarDescripciones(ByVal S As Spots_detalle_log)
        'busca las descripciones de la camapaña, sistema y ejercicio
        Dim C As New Campaña

        C.ID_Campania = S.Id_campania
        C.BuscarPorID()

        S.Desc_campania = C.Descripcion

        Dim SI As New Sistemas

        SI.Id_campania = S.Id_campania
        SI.Id_sistema = S.Id_sistema
        SI.BuscarPorID()

        S.Desc_sistema = SI.Deflactacion

        Dim EJ As New Ejercicios

        EJ.Id_campania = S.Id_campania
        EJ.Id_sistema = S.Id_sistema
        EJ.Id_ejercicio = S.Id_ejercicio
        EJ.BuscarPorID()

        S.Desc_ejercicio = EJ.Descripcion
    End Sub

    Private Sub GuadarSpotsDetalleLog(ByVal Tema As DataRow, ByVal Spot As DataTable, ByVal Usuario As String, ByVal IDEstadoEjercicio As Integer)
        '*** AGREGA LOS SPOTS NUEVOS A SPOTS_DETALLE_LOG

        'guarda el LOG solo para el Ejercicio FINAL
        If IDEstadoEjercicio <> 2 Then
            Exit Sub
        End If

        Dim S As New Spots_detalle_log
        Dim Programa As DataRow
        Dim Version As DataRowVersion

        If Tema.RowState = DataRowState.Deleted Then
            Version = DataRowVersion.Original

            S.Accion = "B"
            S.F_accion = Now
        End If

        If Tema.RowState = DataRowState.Added Then
            Version = DataRowVersion.Current

            S.Accion = "A"
            S.F_accion = IIf(Tema("f_alta", Version) Is DBNull.Value, Now, Tema("f_alta", Version))
        End If

        Programa = Spot.Select("id_spot='" & Tema("id_spot", Version) & "'")(0)

        S.Id_campania = Programa("id_campania")
        S.Id_sistema = Programa("id_sistema")
        S.Id_ejercicio = Programa("id_ejercicio")

        Me.BuscarDescripciones(S)

        S.Id_spot = Programa("id_spot")
        S.Id_spot_detalle = Tema("id_spot_detalle", Version)

        S.Programa = Programa("programa")
        S.H_icio = Programa("h_inicio")
        S.H_f = Programa("h_fin")

        S.Neto = Programa("neto")
        S.Id_tema = Tema("id_tema", Version)

        S.Dcto1 = Programa("dcto1")
        S.Dcto2 = Programa("dcto2")
        S.Dcto3 = Programa("dcto3")
        S.Dcto4 = Programa("dcto4")
        S.Dcto5 = Programa("dcto5")

        S.U_accion = Usuario

        S.Agregar()
    End Sub

    Public Overloads Sub ActualizarDataSet(ByVal Ds As DataSet, ByVal NombreTabla As String, ByVal NombreTablaSpots As String, ByVal Usuario As String, ByVal IDEstadoEjercicio As Integer)
        'Dim Dr As DataRow

        'If Not Ds.Tables(NombreTabla).GetChanges Is Nothing Then
        '    'recorre las filas que se agregaron o borraron en el DataTable
        '    For Each Dr In Ds.Tables(NombreTabla).GetChanges.Rows
        '        If Dr.RowState = DataRowState.Added Or Dr.RowState = DataRowState.Deleted Then
        'Me.GuadarSpotsDetalleLog(Dr, Ds.Tables(NombreTablaSpots), Usuario, IDEstadoEjercicio)
        '        End If
        '    Next
        'End If

        MyBase.ActualizarDataSet(Ds, NombreTabla)
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

    ''' <summary>
    ''' Concatena el Id del tema con la descripcion del Material
    ''' </summary>
    ''' <param name="_dtTemas">Contiene el registro a modificar</param>
    ''' <param name="_descMaterial">Descripcion del Material</param>
    ''' <returns>DataTable Modificado</returns>
    ''' <remarks></remarks>
    Public Function ConcatenarDesMaterial(ByVal _dtTemas As DataTable, ByVal _descMaterial As String) As DataTable

        Dim _idTema As String = _dtTemas.Rows(0)("tema").ToString
        Dim _newDesc As String = _idTema & " - " & _descMaterial
        _dtTemas.Rows(0)("tema") = _newDesc
        Return _dtTemas

    End Function

#End Region

#Region "Funciones Propias"
    Public Sub CargarEsquema(ByVal dt As DataTable)
        Me.ObtenerEsquema("spk_spots_Detalle.sp_select_all", dt)
    End Sub

    Public Function ObtenerSpotDetalle(ByVal idCampaña As Integer, ByVal IdSistema As Integer, ByVal IdEjercicio As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_spots_detalle.sp_select_grilla", idCampaña, IdSistema, IdEjercicio).Tables(0)
    End Function

    Public Function ReporteCalendarioDiarioTotales(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal IDPlaza As Integer) As DataTable
        Dim OGAdmin As New GrillAdmin
        With OGAdmin
            Dim dsDatos As DataSet
            dsDatos = MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_diario", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza)
            Return .EliminarColumnasDTMMS(.CargarDTMMS(dsDatos.Tables(1), Activo.CachesMMS.CacheSoportes, "Cadena"), Activo.CachesMMS.CacheSoportes, "id_soporte", "id_medio")
        End With
    End Function

    Public Function ReporteCalendarioDiario(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal IDPlaza As Integer) As DataTable

        'AGuzzardi Modificacion Soportes MMS -------------------------------------------------------------------------------------------------------------------------------
        Dim OGAdmin As New GrillAdmin
        With OGAdmin
            Dim dsDatos As DataSet
            dsDatos = MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_diario", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza)
            Return .EliminarColumnasDTMMS(.CargarDTMMS(dsDatos.Tables(0), Activo.CachesMMS.CacheSoportes, "Cadena"), Activo.CachesMMS.CacheSoportes, "id_soporte", "id_medio")
        End With

        'AGuzzardi Codigo Anterior ----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Return MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_diario", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza).Tables(0)
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

    Public Function ObtenerFactor(ByVal IdOrdnesMMS As String, ByVal IdCompania As Integer, ByVal IdMedio As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.SP_OBTENER_FACTOR", IdOrdnesMMS, IdCompania, IdMedio).Tables(0)
    End Function

    Public Function ReporteCalendarioDiarioLog(ByVal IDCampaña As Integer, ByVal IDSistema As Integer, ByVal IdEjercicio As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_diario_log", IDCampaña, IDSistema, IdEjercicio).Tables(0)
    End Function
    Public Function ReporteCalendarioDiarioPrensa(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal IDPlaza As Integer) As DataTable
        Return EliminarColumnasDTReportes(AnexarSoportesReportesPrensa(MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_diario_prensa", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza).Tables(0), ""), "ID_MEDIO", "ID_SOPORTE", "ID_PRODUCTO", "ID_MATERIAL", "ID_SECCION")
    End Function
    Public Function ReporteCalendarioDiarioInternet(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal IDPlaza As Integer) As DataTable
        Return EliminarColumnasDTReportes(AnexarSoportesReportesInternet(MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_diario_internet", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza).Tables(0), ""), "ID_MEDIO", "ID_SOPORTE", "ID_PRODUCTO", "ID_MATERIAL", "ID_SECCION")
    End Function
    Public Function ReporteCalendarioDiarioExterior(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal IDPlaza As Integer) As DataTable
        Return EliminarColumnasDTReportes(AnexarSoportesReportesExterior(MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_diario_exterior", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza).Tables(0), ""), "ID_MEDIO", "ID_SOPORTE", "ID_PRODUCTO", "ID_MATERIAL", "COD_POBL1", "COD_POBL2")
    End Function
    Public Function FechasCalendario(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_fecha_calendario", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
    End Function
    Public Function FechasCalendarioPrensa(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable
        'AGuzzardi Anexar la Descripcon de los soportes Traer de la consulta Idmedio y IdSoportes luego eliminar estos 2 ids------------------
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_fecha_calendario_pr", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
    End Function
    Public Function FechasCalendarioInternet(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable
        'AGuzzardi Anexar la Descripcon de los soportes Traer de la consulta Idmedio y IdSoportes luego eliminar estos 2 ids------------------
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_fecha_calendario_int", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
    End Function

    Public Function FechasCalendarioExterior(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable
        'AGuzzardi Anexar la Descripcon de los soportes Traer de la consulta Idmedio y IdSoportes y filtrar por idsoporte luego eliminar estos 2 ids------------------
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_fecha_calendario_vp", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
        'Return AnexarSoportesReportes(MyBase.TraerDataSet("spk_generador_reportes.sp_fecha_calendario_vp", IDCampaña, IDAlternativa, IDPlaza).Tables(0), "")
    End Function

    Public Function ObtenerSpotPorSoporte(ByVal id_campania As Int32, ByVal id_sistema As Int32, ByVal id_ejercicio As Int32, ByVal id_soporte As Int32) As DataTable
        Dim Ds As DataSet

        Try
            Ds = Me.TraerDataSet("spk_spots_detalle.SP_SELECT_GRILLA_X_SOPORTE", id_campania, id_sistema, id_ejercicio, id_soporte)

            ObtenerSpotPorSoporte = Ds.Tables(0)
        Catch ex As DataReaderVacioExcepcion
            ObtenerSpotPorSoporte = Nothing
        End Try
    End Function

    Public Function ObtenerCalendarioEncabezado(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal IdMedio As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As DataTable

        'AGuzzardi Modificacion (TipoSoportes,Plazas) MMS -------------------------------------------------------------------------------------------------------------------------------
        Dim OGAdmin As New GrillAdmin
        Dim DtDatos As DataTable
        With OGAdmin
            DtDatos = .EliminarColumnasDTMMS(.CargarDTMMS(MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_datos_encabezado", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza, IdMedio).Tables(0), Activo.CachesMMS.CacheTipoSoportes, "tipo_soporte"), Activo.CachesMMS.CacheTipoSoportes, "id_tipo_soporte", "id_medio")
            Return .EliminarColumnasDTMMS(.CargarDTMMS(DtDatos, Activo.CachesMMS.CachePlazas, "plaza"), Activo.CachesMMS.CachePlazas, "id_plaza")
        End With
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'AGuzzardi Codigo Original --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Return MyBase.TraerDataSet("spk_generador_reportes.sp_calendario_datos_encabezado", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza, IdMedio).Tables(0)
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

    Public Function TieneSpotsAsociados(ByVal IDCampaña As Integer, ByVal IDTema As String) As Boolean
        Dim Dt As DataTable

        Dt = MyBase.TraerDataSet("spk_spots_detalle.sp_cantidad_temas", IDCampaña, IDTema).Tables(0)

        If Dt.Rows(0).Item("Cantidad_temas") = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub ActualizarDuracion(ByVal IDCampaña As Integer, ByVal IDTema As String, ByVal Duracion As Integer)
        MyBase.Ejecutar("spk_spots_detalle.sp_actualiza_duracion", IDCampaña, IDTema, Duracion)
    End Sub

    Public Sub ActualizarTema(ByVal IdCampaña As Integer, ByVal IdSistema As String, ByVal IdEjercicio As String, ByVal IdSoporte As String, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime, ByVal IdTemaOrigen As String, ByVal IdTemaDestino As String, ByVal Duracion As Integer, ByVal FechaModificacion As DateTime, ByVal Usuario As String)
        MyBase.Ejecutar("spk_spots_detalle.SP_ACTUALIZA_TEMA", IdCampaña, IdSistema, IdEjercicio, IdSoporte, FechaDesde, FechaHasta, IdTemaOrigen, IdTemaDestino, Duracion, FechaModificacion, Usuario)
    End Sub

    Public Function ResumenEconomico_Cadena(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable

        'JSperk Modificaciones MMS Soporte --------------------------------
        Dim OGAmin As New GrillAdmin
        With OGAmin
            Return .EliminarColumnasDTMMS(.EliminarColumnasDTMMS(.CargarDTMMS(MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_cadena", IDCampaña, IDAlternativa, IDPlaza).Tables(0), Activo.CachesMMS.CacheSoportes, "SOPORTE"), Activo.CachesMMS.CacheSoportes, "id_soporte"), Activo.CachesMMS.CacheMedios, "id_medio")
        End With
        '-------------------------------------------------
        'JSperk Codigo Original --------------------------
        ''Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_cadena", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
        '-------------------------------------------------
    End Function

    ''TRAE LA CONSULTA POR FECHA DEL FILTRO DCAIME 06/07/2010
    Public Function ResumenEconomico_Cadena2(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable

        Dim OGAmin As New GrillAdmin
        Dim dt As DataTable
        With OGAmin
            dt = MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_cadena2", IDCampaña, IDAlternativa, IDPlaza, f_inicio, f_fin).Tables(0)
            Return .EliminarColumnasDTMMS(.EliminarColumnasDTMMS(.CargarDTMMS(dt, Activo.CachesMMS.CacheSoportes, "SOPORTE"), Activo.CachesMMS.CacheSoportes, "id_soporte"), Activo.CachesMMS.CacheMedios, "id_medio")
        End With
    End Function


    Public Function ResumenEconomico_Ver_Franjas(ByVal IDCampaña As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_ver_franja", IDCampaña).Tables(0)
    End Function

    Public Function ResumenEconomico_Franjas(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal IDFranja As Integer, ByVal HoraDesde As String, ByVal HoraHasta As String) As DataTable

        'JSperk Modificaciones MMS Soporte --------------------------------
        Dim OGAdmin As New GrillAdmin
        With OGAdmin
            Return .EliminarColumnasDTMMS(.EliminarColumnasDTMMS(.CargarDTMMS(MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_franja", IDCampaña, _
        IDAlternativa, IDPlaza, IDFranja, HoraDesde, HoraHasta).Tables(0), Activo.CachesMMS.CacheSoportes, "SOPORTE"), Activo.CachesMMS.CacheSoportes, "id_soporte"), Activo.CachesMMS.CacheMedios, "id_medio")
        End With
        '-------------------------------------------------
        'JSperk Codigo Original --------------------------
        'Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_franja", IDCampaña, _
        'IDAlternativa, IDPlaza, IDFranja, HoraDesde, HoraHasta).Tables(0)
        '-------------------------------------------------
    End Function

    ''dcaime
    Public Function ResumenEconomico_Franjas2(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal IDFranja As Integer, ByVal HoraDesde As String, ByVal HoraHasta As String, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable

        Dim OGAdmin As New GrillAdmin
        Dim dt As DataTable
        With OGAdmin
            dt = MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_franja2", IDCampaña, IDAlternativa, IDPlaza, IDFranja, HoraDesde, HoraHasta, f_inicio, f_fin).Tables(0)
            Return .EliminarColumnasDTMMS(.EliminarColumnasDTMMS(.CargarDTMMS(dt, Activo.CachesMMS.CacheSoportes, "SOPORTE"), Activo.CachesMMS.CacheSoportes, "id_soporte"), Activo.CachesMMS.CacheMedios, "id_medio")
        End With
    End Function

    Public Function ResumenEconomico_Temas(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable
        ''Jsperk Modificaciones MMS Soporte-----------------------------------
        Dim OGAdmin As New GrillAdmin
        With OGAdmin
            Dim objMSL As New Maestros
            Dim _dtTemas As DataTable = TraerDataSet("spk_generador_reportes.sp_resumen_por_tema", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
            Dim _descMaterial As String = objMSL.MaterialDescripcion(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente, CInt(_dtTemas.Rows(0)("id_material").ToString))
            Return .EliminarColumnasDTMMS(ConcatenarDesMaterial(_dtTemas, _descMaterial), Activo.CachesMMS.CacheMateriales, "id_material")
        End With

        'Jsperk Código Original----------------------------
        'Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_tema", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
        '-------------------------------------------------
    End Function

    ''dcaime
    Public Function ResumenEconomico_Temas2(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable
        Dim OGAdmin As New GrillAdmin
        With OGAdmin
            Dim objMSL As New Maestros
            Dim _dtTemas As DataTable = TraerDataSet("spk_generador_reportes.sp_resumen_por_tema2", IDCampaña, IDAlternativa, IDPlaza, f_inicio, f_fin).Tables(0)
            Dim _descMaterial As String = objMSL.MaterialDescripcion(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente, CInt(_dtTemas.Rows(0)("id_material").ToString))
            Return .EliminarColumnasDTMMS(ConcatenarDesMaterial(_dtTemas, _descMaterial), Activo.CachesMMS.CacheMateriales, "id_material")
        End With
    End Function

    Public Function ResumenEconomico_Dias(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_dia", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
    End Function

    ''dcaime
    Public Function ResumenEconomico_Dias2(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_dia2", IDCampaña, IDAlternativa, IDPlaza, f_inicio, f_fin).Tables(0)
    End Function

    Public Function ResumenEconomico_Semana(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_semana", IDCampaña, IDAlternativa, IDPlaza).Tables(0)
    End Function

    ''dcaime
    Public Function ResumenEconomico_Semana2(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_semana2", IDCampaña, IDAlternativa, IDPlaza, f_inicio, f_fin).Tables(0)
    End Function

    Public Function ObtenerSpotsDetalleLog(ByVal IdCampaña As Integer, ByVal IdSistema As Integer, ByVal IdEjercicio As Integer) As DataTable
        Return Me.TraerDataSet("spk_spots_detalle.sp_select_log", IdCampaña, IdSistema, IdEjercicio).Tables(0)
    End Function

    Public Function ObtenerAvisosConfirmados(ByVal IdCampaña As Integer, ByVal IdSistema As Integer, ByVal IdEjercicio As Integer, ByVal IdMedio As Integer, ByVal IdTipoSoporte As Integer) As DataTable

        'AGuzzardi Anexar soportes MMS --------------------------------------------------------------------------------------
        'Anexo a los datos que traigo de la consulta las descripciones de los soportes, buscandolos por el idsoporte que se obtiene de la consulta 
        Dim OAGrilla As New GrillAdmin

        Return OAGrilla.AnexarSoportesMMS(Me.TraerDataSet("spk_spots_detalle.sp_select_avisos_confirmados", IdCampaña, IdSistema, IdEjercicio, IdMedio, IdTipoSoporte).Tables(0), "Cadena", IdMedio)


        '--------------------------------------------------------------------------------------------------------------------
        'AGuzzardi codigo Original ------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_spots_detalle.sp_select_avisos_confirmados", IdCampaña, IdSistema, IdEjercicio, IdMedio, IdTipoSoporte).Tables(0)
        '--------------------------------------------------------------------------------------------------------------------

    End Function

    Public Function BuscarPorSpot(ByVal pIdSpot As Integer) As DataSet
        Return Me.TraerDataSet("spk_spots_detalle.sp_select", pIdSpot)
    End Function

    Public Function AnexarSoportesReportesExterior(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String)
        Dim Rows() As DataRow
        Dim i As Integer
        Dim DtSoporteFiltro As New DataTable
        Dim ObjMaterial As New Materiales
        Dim ProductoMaterial As String

        'If NombreColumna <> "" Then
        '    DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
        '    DtBaseDatos.AcceptChanges()
        'End If


        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("cadena") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next

        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTProductosCache.Select("ID_PRODUCTO=" & r("ID_PRODUCTO"))
            'Rows = Activo.DTMaterialesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("Producto-Material") = Rows(i).Item("DESCRIPCION").ToString + " - "
                ProductoMaterial = ObjMaterial.ObtenerMaterial(CInt(Rows(i).Item("ID_CLIENTE").ToString()), CInt(Rows(i).Item("ID_PRODUCTO").ToString()), r("id_medio"), r("id_material"))
                r("Producto-Material") &= ProductoMaterial
            Next
        Next

        Return ObtenerPoblacion(DtBaseDatos)
    End Function

    Public Function AnexarSoportesReportesPrensa(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String)
        Dim Rows() As DataRow
        Dim i As Integer
        Dim DtSoporteFiltro As New DataTable
        Dim ObjMaterial As New Materiales
        Dim ProductoMaterial As String
        Dim OMsl As New Maestros
        Dim DtSecciones As New DataTable


        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("cadena") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next

        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTProductosCache.Select("ID_PRODUCTO=" & r("ID_PRODUCTO"))
            For i = 0 To Rows.Length - 1
                r("Producto-Material") = Rows(i).Item("DESCRIPCION").ToString + " - "
                ProductoMaterial = ObjMaterial.ObtenerMaterial(CInt(Rows(i).Item("ID_CLIENTE").ToString()), CInt(Rows(i).Item("ID_PRODUCTO").ToString()), r("id_medio"), r("id_material"))
                r("Producto-Material") &= ProductoMaterial
            Next
        Next

        For Each r As DataRow In DtBaseDatos.Rows
            Dim idseccion As String = "'" & r("ID_SECCION").ToString & "'"
            DtSecciones = OMsl.seccionesObtener(r("id_medio"))

            Rows = DtSecciones.Select("ID_SECCION=" & idseccion & " and " & "ID_MEDIO=" & 4)
            For i = 0 To Rows.Length - 1
                r("Concepto-Seccion") &= Rows(i).Item("DESCRIPCION").ToString
            Next
        Next


        Return DtBaseDatos
    End Function

    Public Function AnexarSoportesReportesInternet(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String)
        Dim Rows() As DataRow
        Dim i As Integer
        Dim DtSoporteFiltro As New DataTable
        'Dim ObjMaterial As New Materiales
        'Dim ProductoMaterial As String
        Dim OMsl As New Maestros
        Dim DtSecciones As New DataTable


        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("SOPORTE") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next

        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTProveedorCache.Select("ID_PROVEEDOR=" & r("id_proveedor"))
            For i = 0 To Rows.Length - 1
                r("PROVEEDOR") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next
         
        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTSeccionesInternetCache.Select("ID_SECCION='" & r("ID_UBICACION") & "' and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("UBICACION") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next        

        For Each r As DataRow In DtBaseDatos.Rows
             Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("TIPO_SOPORTE") = Rows(i).Item("DES_TIPO_SOPORTE").ToString
            Next
        Next

        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTColocacionesCache.Select("ID_COLOCACION=" & r("ID_TIPO_FORMATO") & " and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("TIPO_FORMATO") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next

        For Each r As DataRow In DtBaseDatos.Rows
            Rows = Activo.DTFormatosCache.Select("ID_ANUNCIO='" & r("ID_FORMATO") & "' and " & "ID_MEDIO=" & r("id_medio"))
            For i = 0 To Rows.Length - 1
                r("FORMATO") = Rows(i).Item("DESCRIPCION").ToString
            Next
        Next

        Return DtBaseDatos
    End Function

    Private Function ObtenerSeccionesPrensa(ByVal Dt As DataTable) As DataTable

        Dim i As Integer
        Dim Rows() As DataRow
        Dim OMsl As New Maestros
        Dim DtProvincia As DataTable
        Dim DtPoblacion As New DataTable

        'Obtengo del MSL las Provincias ------------------------------------------------------------------------------------
        DtProvincia = OMsl.poblaciones1Obtener(Constantes.COD_PAIS_ARGENTINA)
        '----------------------------------------------------------------------------------------------------------------------------

        'Recorre el Dt con los datos para anexarle las provincias -----------------------------------------------------
        For Each r As DataRow In Dt.Rows
            Rows = DtProvincia.Select("COD_POBL1=" & r("COD_POBL1"))
            For i = 0 To Rows.Length - 1
                r("Provincia-Poblacion") = Rows(i).Item("NOM_POBL1").ToString + " - "
                DtPoblacion = OMsl.poblaciones2Obtener(Constantes.COD_PAIS_ARGENTINA, CInt(r("COD_POBL2")))
                r("Provincia-Poblacion") &= DtPoblacion.Rows(0).Item("NOM_POBL2").ToString
            Next
        Next
        '----------------------------------------------------------------------------------------------------------------------------

        Return Dt

    End Function


    Private Function ObtenerPoblacion(ByVal Dt As DataTable) As DataTable

        Dim i As Integer
        Dim Rows() As DataRow
        Dim OMsl As New Maestros
        Dim DtProvincia As DataTable
        Dim DtPoblacion As New DataTable

        'Obtengo del MSL las Provincias ------------------------------------------------------------------------------------
        DtProvincia = OMsl.poblaciones1Obtener(Constantes.COD_PAIS_ARGENTINA)
        '----------------------------------------------------------------------------------------------------------------------------

        'Recorre el Dt con los datos para anexarle las provincias -----------------------------------------------------
        For Each r As DataRow In Dt.Rows
            Rows = DtProvincia.Select("COD_POBL1=" & r("COD_POBL1"))
            For i = 0 To Rows.Length - 1
                r("Provincia-Poblacion") = Rows(i).Item("NOM_POBL1").ToString + " - "
                DtPoblacion = OMsl.poblaciones2ObtenerAlternativa(Constantes.COD_PAIS_ARGENTINA, CInt(r("COD_POBL1")), CInt(r("COD_POBL2")))
                r("Provincia-Poblacion") &= DtPoblacion.Rows(0).Item("NOM_POBL2").ToString
            Next
        Next
        '----------------------------------------------------------------------------------------------------------------------------

        Return Dt

    End Function

    Public Function EliminarColumnasDTReportes(ByVal DtDatos As DataTable, ByVal ParamArray Parametros() As Object) As DataTable

        Dim i As Integer
        For i = 0 To Parametros.Length - 1
            If (DtDatos.Columns.Contains(Parametros(i).ToString)) Then
                DtDatos.Columns.Remove(Parametros(i).ToString)
            End If
        Next
        Return DtDatos
    End Function

    Public Function ObtenerSpotReporteCPR(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal IDPlaza As Integer) As DataTable

        Dim OGAdmin As New GrillAdmin
        With OGAdmin
            Return .EliminarColumnasDTMMS(.CargarDTMMS(MyBase.TraerDataSet("spk_generador_reportes.SP_AVISOS_REPORTE_CPR", IDCampaña, IDAlternativa, FechaDesde, FechaHasta, IDPlaza).Tables(0), Activo.CachesMMS.CacheSoportes, "Cadena"), Activo.CachesMMS.CacheSoportes, "id_medio")
        End With
    End Function


#End Region

#Region "Funciones Nuevas Resumen Economico"

    Public Function ResumenEconomico_Semana3(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_semana3", IDCampaña, IDAlternativa, IDPlaza, f_inicio, f_fin).Tables(0)
    End Function

    Public Function ResumenEconomico_Dias3(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable
        Return MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_dia3", IDCampaña, IDAlternativa, IDPlaza, f_inicio, f_fin).Tables(0)
    End Function

    Public Function ResumenEconomico_Franjas3(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer, ByVal IDPlaza As Integer, ByVal IDFranja As Integer, ByVal HoraDesde As String, ByVal HoraHasta As String, ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable

        Dim OGAdmin As New GrillAdmin
        Dim dt As DataTable
        With OGAdmin
            dt = MyBase.TraerDataSet("spk_generador_reportes.sp_resumen_por_franja3", IDCampaña, IDAlternativa, IDPlaza, IDFranja, HoraDesde, HoraHasta, f_inicio, f_fin).Tables(0)
            Return .EliminarColumnasDTMMS(.EliminarColumnasDTMMS(.CargarDTMMS(dt, Activo.CachesMMS.CacheSoportes, "SOPORTE"), Activo.CachesMMS.CacheSoportes, "id_soporte"), Activo.CachesMMS.CacheMedios, "id_medio")
        End With
    End Function

    Public Function ControlReporteCPR(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer) As Boolean

        Dim OGAdmin As New GrillAdmin
        Dim dt As DataTable
        Dim Resultado As Boolean
        Dim Dr As DataRow

        With OGAdmin
            dt = MyBase.TraerDataSet("spk_generador_reportes.SP_CONTROL_REPORTE_CPR", IDCampaña, IDAlternativa).Tables(0)

            If dt.Rows.Count > 0 Then
                For Each Dr In dt.Rows
                    If Dr("id_medio").ToString = "1" And Dr("id_tipo_soporte").ToString = "1" Then
                        'Es medio =1 
                        Resultado = True
                    Else
                        Resultado = False
                    End If
                Next
            End If

            Return Resultado

        End With
    End Function

#End Region

    Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class


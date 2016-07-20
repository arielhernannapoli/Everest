Imports MSL
Imports Framework
Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports System.Collections.Generic
Public Class Envio_Compras
    Inherits Entidad

#Region "Propiedades"
    Dim mid_Cliente As Integer
    Dim mId_Campania As Long
    Dim mId_Tipo_Soporte As Integer
    Dim mId_Medio As Integer
    Dim mId_Target As Long
    Dim mId_Producto As Integer
    Dim mId_Sistema As Long
    Dim mId_Ejercicio As Long
    Dim mFecha_Desde As Date
    Dim mFecha_Hasta As Date
    Dim mId_Campania_Sigeme As Integer
    Dim mId_SubCampania_Sigeme As Integer
    Dim mId_Target_Nautilus As Integer
    Dim mId_Grupo_Usuario As Integer
    Dim mDesc_Campania As String
    Dim mUsuario As String
    Dim mDesc_SubCampania As String
    Dim mId_Presupuesto_Sigeme As Long
    Dim mId_Material As String
    Dim mid_Seccion As Integer
    Dim mId_Soporte As Integer
    Dim mLista_Soportes As String
    Dim mConcepto As String
    Dim mid_Provincia As Integer
    Dim mId_Intercambio As String

    Public Property ListaSoportes() As String
        Get
            Return mLista_Soportes
        End Get
        Set(ByVal Value As String)
            mLista_Soportes = Value
        End Set
    End Property
    Public Property id_Provincia() As Integer
        Get
            Return mid_Provincia
        End Get
        Set(ByVal Value As Integer)
            mid_Provincia = Value
        End Set
    End Property
    Public Property Id_Soporte() As Integer
        Get
            Return mId_Soporte
        End Get
        Set(ByVal Value As Integer)
            mId_Soporte = Value
        End Set
    End Property
    Public Property id_Seccion() As Integer
        Get
            Return mid_Seccion
        End Get
        Set(ByVal Value As Integer)
            mid_Seccion = Value
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

    ''DATOS MMS
    Dim _id_campania_mms As Integer
    Dim _id_subcampania_mms As Integer
    Dim _id_presupuesto_mms As Integer
    Dim _maestro As Maestros()

    Public Property Id_Cliente()
        Get
            Id_Cliente = mid_Cliente
        End Get
        Set(ByVal Value)
            mid_Cliente = Value
        End Set
    End Property

    Public Property Id_Campania()
        Get
            Id_Campania = mId_Campania
        End Get
        Set(ByVal Value)
            mId_Campania = Value
        End Set
    End Property

    Public Property Id_Tipo_Soporte()
        Get
            Id_Tipo_Soporte = mId_Tipo_Soporte
        End Get
        Set(ByVal Value)
            mId_Tipo_Soporte = Value
        End Set
    End Property

    Public Property Id_Medio()
        Get
            Id_Medio = mId_Medio
        End Get
        Set(ByVal Value)
            mId_Medio = Value
        End Set
    End Property

    Public Property Id_Target()
        Get
            Id_Target = mId_Target
        End Get
        Set(ByVal Value)
            mId_Target = Value
            mId_Target_Nautilus = GetTargetNautilus(mId_Target)
        End Set
    End Property

    Public Property Id_Producto() As Integer
        Get
            Return mId_Producto
        End Get
        Set(ByVal Value As Integer)
            mId_Producto = Value
        End Set
    End Property

    Public Property Id_Sistema()
        Get
            Id_Sistema = mId_Sistema
        End Get
        Set(ByVal Value)
            mId_Sistema = Value
        End Set
    End Property

    Public Property Id_Ejercicio()
        Get
            Id_Ejercicio = mId_Ejercicio
        End Get
        Set(ByVal Value)
            mId_Ejercicio = Value
        End Set
    End Property

    Public Property Fecha_Desde()
        Get
            Fecha_Desde = mFecha_Desde
        End Get
        Set(ByVal Value)
            mFecha_Desde = Value
        End Set
    End Property

    Public Property Fecha_Hasta()
        Get
            Fecha_Hasta = mFecha_Hasta
        End Get
        Set(ByVal Value)
            mFecha_Hasta = Value
        End Set
    End Property

    Public Property Id_Campania_Sigeme()
        Get
            Id_Campania_Sigeme = mId_Campania_Sigeme
        End Get
        Set(ByVal Value)
            mId_Campania_Sigeme = Value
        End Set
    End Property

    Public Property Id_SubCampania_Sigeme()
        Get
            Id_SubCampania_Sigeme = mId_SubCampania_Sigeme
        End Get
        Set(ByVal Value)
            mId_SubCampania_Sigeme = Value
        End Set
    End Property

    Public Property Id_Grupo_Usuario()
        Get
            Id_Grupo_Usuario = mId_Grupo_Usuario
        End Get
        Set(ByVal Value)
            mId_Grupo_Usuario = Value
        End Set
    End Property

    Public Property Desc_Campania()
        Get
            Desc_Campania = mDesc_Campania
        End Get
        Set(ByVal Value)
            mDesc_Campania = Value
        End Set
    End Property

    Public Property Usuario()
        Get
            Usuario = mUsuario
        End Get
        Set(ByVal Value)
            mUsuario = Value
        End Set
    End Property

    Public Property Desc_SubCampania()
        Get
            Desc_SubCampania = mDesc_SubCampania
        End Get
        Set(ByVal Value)
            mDesc_SubCampania = Value
        End Set
    End Property

    Public Property Id_Presupuesto_Sigeme()
        Get
            Id_Presupuesto_Sigeme = mId_Presupuesto_Sigeme
        End Get
        Set(ByVal Value)
            mId_Presupuesto_Sigeme = Value
        End Set
    End Property

    Property Id_Material()
        Get
            Id_Material = mId_Material
        End Get
        Set(ByVal Value)
            mId_Material = Value
        End Set
    End Property

    Public Property Id_Intercambio()
        Get
            Id_Intercambio = mId_Intercambio
        End Get
        Set(ByVal Value)
            mId_Intercambio = Value
        End Set
    End Property

#End Region

    Public Sub New()
        MyBase.New("Envio_Compras")
    End Sub

#Region ""
    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
        ' nada
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

    Public Function TraerTipoSoportes() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_TIPO_SOPORTE", Id_Campania).Tables(0)
    End Function

    Public Function TraerTargets() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_TARGETS", Id_Campania, Id_Medio, Id_Tipo_Soporte).Tables(0)
    End Function
#End Region

    Public Function TraerProductos() As DataTable
        Dim dt As DataTable
        Dim otemas As Temas = New Temas
        otemas.id_cliente = Id_Cliente
        otemas.Id_campania = Id_Campania
        Dim dtProductos As DataTable
        Dim dtReturn As DataTable

        Dim oproducto As Productos = New Productos
        oproducto.Id_cliente = Id_Cliente
        'oproducto.traerTodosProductosEnvioaCompras(Id_Cliente

        dtProductos = oproducto.TraerProductos()

        If Id_Medio = 1 Or Id_Medio = 6 Then
            dt = Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_TEMAS", Id_Cliente, Id_Campania, Id_Medio, Id_Tipo_Soporte, Id_Target).Tables(0)
            dtReturn = dtProductos.Clone()
            For index As Integer = 0 To dt.Rows.Count - 1
                For Each row As DataRow In dtProductos.Select("id_producto =" & dt.Rows(index)("ID_PRODUCTO"))
                    dtReturn.ImportRow(row)
                Next
            Next
            Return dtReturn
        Else
            Return dtProductos
        End If

    End Function

    Public Function TraerSistemasEjercicios() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SISTEMAS_EJERCICIOS", Id_Campania, Id_Medio, Id_Tipo_Soporte, Id_Target, Id_Producto, Fecha_Desde, Fecha_Hasta).Tables(0)
    End Function

    Public Function TraerSistemasEjerciciosMedios() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SIS_EJER_MEDIOS", Id_Campania, Id_Medio, Id_Tipo_Soporte, Id_Producto, Fecha_Desde, Fecha_Hasta, Id_Target).Tables(0)
    End Function

    Public Function TraerSistemasEjerciciosExterior() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SIS_EJER_EXTERIOR", Id_Campania, Id_Medio, Id_Tipo_Soporte, Id_Producto, Fecha_Desde, Fecha_Hasta, Id_Target).Tables(0)
    End Function

    'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Public Function TraerSistemasEjerciciosProduccion() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SIS_EJER_PODUCCION", Id_Campania, Id_Medio, Id_Tipo_Soporte, Id_Producto, Fecha_Desde, Fecha_Hasta).Tables(0)
    End Function

    'AG Internet +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Public Function TraerSistemasEjerciciosInternet() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SIS_EJER_INTERNET", Id_Campania, Id_Medio, Id_Tipo_Soporte, Fecha_Desde, Fecha_Hasta).Tables(0)
    End Function

    'Public Function TraerSoportesTemas() As DataTable
    '    Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SOPORTES_TEMAS", Id_Campania, Id_Sistema, Id_Ejercicio, Id_Producto).Tables(0)
    'End Function

    Public Function TraerCampanias(ByVal id_compania As Integer, ByVal id_cliente As Integer, ByVal id_producto As Integer, ByVal f_desde As String, ByVal f_hasta As String) As DataTable

        'AGuzzardi MMS ----------------------------------------------------------------------------
        Dim ocamp As New Campaña
        Dim dt As DataTable
        dt = ocamp.MMSCampañasEnvioCompras(id_compania, id_cliente, id_producto, f_desde, f_hasta)
        '------------------------------------------------------------------------------------------

        'AG Codigo anterior ------------------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_CAMPANAS_SIGEME", mid_Cliente, mId_Target, mId_Producto, mId_Medio).Tables(0)
        'AG Codigo anterior ------------------------------------------------------------------------------------------------------

        Return dt
    End Function

    Public Function TraerSubCampaniasMMS(ByVal id_compania As Integer, ByVal id_campania As Integer, ByVal id_medio As Integer) As DataTable

        'AGuzzardi MMS ----------------------------------------------------------------------------
        Dim dt As DataTable
        Dim oSubCampanas As New Maestros()
        dt = oSubCampanas.subCampanasTraerTodos(Constantes.COD_PAIS_ARGENTINA, id_compania, id_campania, id_medio)
        Return dt
        '------------------------------------------------------------------------------------------

        'AG Codigo anterior ------------------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SUBCAMPANAS_SIGEME", mId_Campania_Sigeme, mId_Medio).Tables(0)
        '-------------------------------------------------------------------------------------------------------------------------
    End Function

    Public Function TraerPresupuestosMMS(ByVal id_compania As Integer, ByVal Id_Campania As Integer, ByVal id_subcampania As Integer, ByVal f_desde As DateTime, ByVal f_hasta As DateTime) As DataTable

        'AGuzzardi MMS --------------------------------------------------------------------------------------------
        Dim dt As DataTable
        Dim oPresupuesto As New Maestros()
        dt = oPresupuesto.presupuestoTraerTodos(Constantes.COD_PAIS_ARGENTINA, id_compania, Id_Campania, id_subcampania, f_desde, f_hasta)

        Return dt
        '----------------------------------------------------------------------------------------------------------

        'AG Codigo anterior --------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_PRESUPUESTOS_SIGEME", mId_Campania_Sigeme, mId_SubCampania_Sigeme, mId_Target, mFecha_Desde, mFecha_Hasta, mId_Medio).Tables(0)
        '----------------------------------------------------------------------------------------------------------
    End Function

    Public Function ObtenerTipoSoporteByPresupuesto(ByVal id_compania As Integer, ByVal Id_Campania As Integer, ByVal id_subcampania As Integer, ByVal id_presupuesto As String, ByVal cod_medio As Integer) As Integer

        Dim oPresupuesto As New Maestros()
        Return oPresupuesto.ObtenerTipoSoporteByPresupuesto(Constantes.COD_PAIS_ARGENTINA, id_compania, Id_Campania, id_subcampania, id_presupuesto, cod_medio)
    End Function

    Public Function ObtenerEstadoBloqueadoPresupuesto(ByVal id_compania As Integer, ByVal id_presupuesto As String) As Boolean

        Dim oPresupuesto As New Maestros()
        Return oPresupuesto.ObtenerEstadoBloqueadoPresupuesto(id_compania, id_presupuesto)
    End Function

    Public Function ActualizarOCPresupuesto(ByVal id_compania As Integer, ByVal id_presupuesto As Integer, ByVal NumeroOC As String)

        Dim oPresupuesto As New Maestros()
        oPresupuesto.ActualizarOCPresupuesto(id_compania, id_presupuesto, NumeroOC)
    End Function

    Public Function ObtenerTipoPresupuestoByPresupuesto(ByVal id_compania As Integer, ByVal Id_Campania As Integer, ByVal id_subcampania As Integer, ByVal id_presupuesto As String, ByVal cod_medio As Integer) As Integer

        Dim oPresupuesto As New Maestros()
        Return oPresupuesto.ObtenerTipoPresupuestoByPresupuesto(Constantes.COD_PAIS_ARGENTINA, id_compania, Id_Campania, id_subcampania, id_presupuesto, cod_medio)
    End Function

    Public Function ObtenerOCByPresupuesto(ByVal id_compania As Integer, ByVal Id_Campania As Integer, ByVal id_subcampania As Integer, ByVal id_presupuesto As String, ByVal cod_medio As Integer) As String

        Dim oPresupuesto As New Maestros()
        Return oPresupuesto.ObtenerOCByPresupuesto(Constantes.COD_PAIS_ARGENTINA, id_compania, Id_Campania, id_subcampania, id_presupuesto, cod_medio)
    End Function

    Private Function GetTargetNautilus(ByVal id As Integer) As Integer
        Dim TN As New Targets_nautilus

        TN.Id_target = id
        TN.BuscarPorTarget()
        GetTargetNautilus = TN.Id_target_nautilus
    End Function

    Public Function ExisteCampania() As Boolean
        ' TODO: GW NO PUEDE BUSCAR UN TARGET EN SIGEME PARA ENVIAR A COMPRAS!!!!
        Return Convert.ToBoolean(MyBase.Ejecutar("spk_envio_compras.SP_EXISTE_TARGET_SIGEME", Me.Id_Target, Me.Id_Medio))
    End Function

    Public Function Inserta_Campania(ByVal F_Creacion As Date) As Long

        'AGuzzardi MMS ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim oCampania As New Maestros()
        Dim shortDescCamp As String

        If Desc_Campania.ToString.Length > 50 Then
            shortDescCamp = Desc_Campania.ToString.Substring(0, 50)
        Else
            shortDescCamp = Desc_Campania
        End If

        Id_Campania_Sigeme = oCampania.InsertarCampanias(Id_Cliente, Id_Producto, shortDescCamp, MSL.Constantes.COD_PAIS_ARGENTINA, Activo.IDCompaniaMMS, F_Creacion, Activo.IDUsuarioMMS)
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'AG Codigo anterior ---------------------------------------------------------------------------------------------------------------------------
        'Id_Campania_Sigeme = Me.Ejecutar("spk_envio_compras.sp_insert_campanas_sigeme", Id_Cliente, Id_Producto, Id_Medio, Desc_Campania, mId_Target, Id_Grupo_Usuario)
        '---------------------------------------------------------------------------------------------------------------------------------------------------
        Return Id_Campania_Sigeme
    End Function

    Public Function Inserta_SubCampania(ByVal F_Creacion As String) As Long
        Dim AUXSubCampania As String

        If CStr(Desc_SubCampania).Length > 38 Then
            AUXSubCampania = CStr(Desc_SubCampania).Substring(0, 37)
        Else
            AUXSubCampania = Desc_SubCampania
        End If

        'AGuzzardi MMS ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim oSubCampania As New Maestros()
        Id_SubCampania_Sigeme = oSubCampania.InsertarSubCampania(Id_Cliente, Id_Medio, Id_Campania_Sigeme, AUXSubCampania, MSL.Constantes.COD_PAIS_ARGENTINA, Activo.IDCompaniaMMS, Fecha_Desde, Fecha_Hasta, CDate(F_Creacion))
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'AG Codigo anterior ---------------------------------------------------------------------------------------------------------------------------
        'Id_SubCampania_Sigeme = Me.Ejecutar("spk_envio_compras.sp_insert_subcampanas_sigeme", Id_Campania_Sigeme, Id_Cliente, Id_Producto, Id_Medio, Fecha_Desde, Fecha_Hasta, Usuario, AUXSubCampania)
        '---------------------------------------------------------------------------------------------------------------------------------------------------
        Return Id_SubCampania_Sigeme
    End Function

    Public Function Inserta_Presupuesto(ByVal fecha As Date, ByVal usuario As String, ByVal Id_TPresupuesto As Integer, ByVal NumeroOC As String) As Long

        'AGuzzardi MMS ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim oPresupuesto As New Maestros()
        'Dim Id_TPresupuesto As Integer

        'Id_TPresupuesto = 1 ' Siempre es 1 el tipo de presupuesto enviado al MMS
        ''ARREGLAR PARA ENVIAR LOS DATOS DE MMS

        If Id_Intercambio = "" Then
            Return oPresupuesto.InsertarPresupuestoSinIntercambio(Id_Cliente, Id_TPresupuesto, Id_Campania_Sigeme, Id_SubCampania_Sigeme, MSL.Constantes.COD_PAIS_ARGENTINA, Activo.IDCompaniaMMS, fecha, NumeroOC)
        Else
            Return oPresupuesto.InsertarPresupuesto(Id_Cliente, Id_TPresupuesto, Id_Campania_Sigeme, Id_SubCampania_Sigeme, MSL.Constantes.COD_PAIS_ARGENTINA, Activo.IDCompaniaMMS, fecha, Me.Id_Intercambio, NumeroOC)
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'AG Codigo anterior ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Return Me.Ejecutar("spk_envio_compras.sp_insert_presupuestos_sigeme", Id_Campania_Sigeme, Id_SubCampania_Sigeme, fecha, mId_Target, mId_Medio)
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

#Region "Metodos Presupuesto Anticipado"

    Public Function ObtenerPresupuestoPASaldo(ByVal CodCompania As Integer, ByVal IdMedio As Integer, ByVal IdCliente As Integer, ByVal IdSoporte As Integer, ByVal fPrimerAviso As Date, ByVal fUltimoAviso As Date, ByVal Monto As Decimal) As DataTable

        Dim OPresupuestoPA As New MSL.Control.Mantenimiento
        Dim LPAnticipado As New System.Collections.Generic.List(Of HM.MMS.AR.Server.BusinessEntity.Control.PresupuestoPA)

        LPAnticipado = OPresupuestoPA.ObtenerPresupuestoPA(CodCompania, IdMedio, IdCliente, IdSoporte, fPrimerAviso, fUltimoAviso, 0)

        Return ObtenerDtPresupuestoPA(LPAnticipado)

    End Function

    Private Function ObtenerDtPresupuestoPA(ByVal LPresupuestoPA As System.Collections.Generic.List(Of HM.MMS.AR.Server.BusinessEntity.Control.PresupuestoPA)) As DataTable

        Dim DtDatosPA As New DataTable
        Dim lPA As New List(Of PresupuestoPA)
        Dim FilaNueva As DataRow

        With DtDatosPA
            .Columns.Add("CodSoporte", GetType(Integer))
            .Columns.Add("DesSoporte", GetType(String))
            .Columns.Add("CodPresupuestoPA", GetType(Integer))
            .Columns.Add("Saldo", GetType(Decimal))
            .Columns.Add("CodPresupuestoPC", GetType(Integer))
            .Columns.Add("SelPA", GetType(Boolean))
        End With

        For Each DatoPA As PresupuestoPA In LPresupuestoPA
            FilaNueva = DtDatosPA.NewRow
            FilaNueva("CodSoporte") = DatoPA.CodigoSoporte
            FilaNueva("DesSoporte") = DatoPA.DesSoporte.ToString
            FilaNueva("CodPresupuestoPA") = DatoPA.CodigoPresupuestoPA
            FilaNueva("Saldo") = DatoPA.ImporteSaldo
            FilaNueva("SelPA") = False
            DtDatosPA.Rows.Add(FilaNueva)
        Next

        Return DtDatosPA

    End Function

    Public Function InsertarRelacionPCPAMMS(ByVal CodCompania As Integer, ByVal CodPresupuestoC As Integer, ByVal CodPresupuestoA As Integer) As Integer

        Dim Resultado As Integer
        Dim OPresupuestoPA As New MSL.Control.Mantenimiento

        OPresupuestoPA.InsertarPAPC(CodCompania, CodPresupuestoC, CodPresupuestoA)

        Return Resultado

    End Function

    Public Function InsertarRelacionPCPAEverest(ByVal CodCompania As Integer, ByVal CodCampanaMMS As Integer, ByVal CodSubCampanaMMS As Integer, ByVal CodPresupuestoPcMMS As Integer, ByVal CodPresupuestoPaMMS As Integer, ByVal CodSoporteMMS As Integer, ByVal Anio As Integer, ByVal Mes As Integer, ByVal CodUsuario As Integer, ByVal SaldoPAPermitido As Integer, ByVal SaldoPCEnvio As Integer, ByVal Autorizado As Integer, ByVal CodMedio As Integer)
        Me.Ejecutar("SPK_PAGO_ANTICIPADO.SP_INSERT", CodCompania, CodCampanaMMS, CodSubCampanaMMS, CodPresupuestoPcMMS, CodPresupuestoPaMMS, CodSoporteMMS, Anio, Mes, CodUsuario, SaldoPAPermitido, SaldoPCEnvio, Autorizado, CodMedio)
    End Function

    Public Function InsertarRelacionPCPAEverestTemp(ByVal CodCompania As Integer, ByVal CodCampanaMMS As Integer, ByVal CodSubCampanaMMS As Integer, ByVal CodPresupuestoPcMMS As Integer, ByVal CodPresupuestoPaMMS As Integer, ByVal CodSoporteMMS As Integer, ByVal Anio As Integer, ByVal Mes As Integer, ByVal CodUsuario As Integer, ByVal SaldoPAPermitido As Integer, ByVal SaldoPCEnvio As Integer, ByVal Autorizado As Integer, ByVal CodMedio As Integer)
        Me.Ejecutar("SPK_PAGO_ANTICIPADO.SP_INSERT_TEMP", CodCompania, CodCampanaMMS, CodSubCampanaMMS, CodPresupuestoPcMMS, CodPresupuestoPaMMS, CodSoporteMMS, Anio, Mes, CodUsuario, SaldoPAPermitido, SaldoPCEnvio, Autorizado, CodMedio)
    End Function

    Public Function ObtenerPACargadosConcatenados(ByVal CodCompania As Integer, ByVal CodCampanaMMS As Integer, ByVal CodSubCampanaMMS As Integer, ByVal CodPresupuestoPcMMS As Integer, ByVal CodPresupuestoPaMMS As Integer, ByVal CodSoporteMMS As Integer, ByVal Anio As Integer, ByVal Mes As Integer, ByVal IdMedio As Integer, ByVal TipoBusqueda As Integer) As DataTable

        Dim dt As DataTable
        Dim Rows() As DataRow
        Dim COD_PRESUPUESTO_PA As String
        Dim DtDistint As New DataTable
        Dim DTReturn As New DataTable
        Dim OSoporte As New Soportes

        Try
            dt = Me.TraerDataSet("SPK_PAGO_ANTICIPADO.SP_SELECT_PA", CodCompania, CodCampanaMMS, CodSubCampanaMMS, CodPresupuestoPcMMS, CodPresupuestoPaMMS, CodSoporteMMS, Anio, Mes).Tables(0)

            DtDistint = dt.DefaultView.ToTable(True, "COD_COMPANIA", "COD_CAMPANA", "COD_SUBCAMPANA", "COD_PRESUPUESTO_PC")

            If TipoBusqueda = 0 Then

                DtDistint.Columns.Add("COD_PRESUPUESTO_PA", GetType(String))
                DtDistint.Columns.Add("COD_SOPORTE", GetType(Integer))
                DtDistint.Columns.Add("ANO", GetType(Integer))
                DtDistint.Columns.Add("MES", GetType(Integer))

                For Each row As DataRow In DtDistint.Rows
                    Rows = dt.Select("COD_PRESUPUESTO_PC = " & row("COD_PRESUPUESTO_PC"))
                    If Rows.Length > 1 Then
                        COD_PRESUPUESTO_PA = ""
                        For i As Integer = 0 To Rows.Length - 1
                            OSoporte.Id_medio = IdMedio
                            COD_PRESUPUESTO_PA += Rows(i)("COD_PRESUPUESTO_PA") + " - " + OSoporte.ObtenerDescripcion(CInt(Rows(i)("COD_SOPORTE"))) + " | "
                        Next
                        row("COD_PRESUPUESTO_PA") = COD_PRESUPUESTO_PA
                        row("COD_SOPORTE") = Rows(0)("COD_SOPORTE")
                        row("ANO") = Rows(0)("ANO")
                        row("MES") = Rows(0)("MES")
                        COD_PRESUPUESTO_PA = ""
                    ElseIf Rows.Length = 1 Then
                        For i As Integer = 0 To Rows.Length - 1
                            OSoporte.Id_medio = IdMedio
                            COD_PRESUPUESTO_PA += Rows(i)("COD_PRESUPUESTO_PA") + " - " + OSoporte.ObtenerDescripcion(CInt(Rows(i)("COD_SOPORTE"))) + " | "
                        Next
                        row("COD_PRESUPUESTO_PA") = COD_PRESUPUESTO_PA 'Rows(0)("COD_PRESUPUESTO_PA")
                        row("COD_SOPORTE") = Rows(0)("COD_SOPORTE")
                        row("ANO") = Rows(0)("ANO")
                        row("MES") = Rows(0)("MES")
                    End If
                Next
                DTReturn = DtDistint
            Else
                DTReturn = dt
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return DTReturn
    End Function

    Public Function ObtenerSoportesPA(ByVal CodCompania As Integer, ByVal CodPresupuestoPA As Integer) As DataTable

        Dim Dt As New DataTable
        Dim FilaNueva As DataRow
        Dim PASoportes As New System.Collections.Generic.List(Of HM.MMS.AR.Server.BusinessEntity.Control.PresupuestoPA)
        Dim OPresupuestoPA As New MSL.Control.Mantenimiento

        PASoportes = OPresupuestoPA.ObtenerSoportesPA(CodCompania, CodPresupuestoPA)

        With Dt
            .Columns.Add("CodSoporte", GetType(Integer))
        End With

        For Each DatoPA As PresupuestoPA In PASoportes
            FilaNueva = Dt.NewRow
            FilaNueva("CodSoporte") = DatoPA.CodigoSoporte
            Dt.Rows.Add(FilaNueva)
        Next

        Return Dt

    End Function

    Public Function ObtenerPACargadosSinCocatenar(ByVal CodCompania As Integer, ByVal CodCampanaMMS As Integer, ByVal CodSubCampanaMMS As Integer, ByVal CodPresupuestoPcMMS As Integer, ByVal CodPresupuestoPaMMS As Integer, ByVal CodSoporteMMS As Integer, ByVal Anio As Integer, ByVal Mes As Integer) As DataTable

        Dim dt As DataTable
        Dim Rows() As DataRow

        Try
            dt = Me.TraerDataSet("SPK_PAGO_ANTICIPADO.SP_SELECT_PA", CodCompania, CodCampanaMMS, CodSubCampanaMMS, CodPresupuestoPcMMS, CodPresupuestoPaMMS, CodSoporteMMS, Anio, Mes).Tables(0)
            For Each row As DataRow In dt.Rows
                Rows = dt.Select("COD_PRESUPUESTO_PC = " & row("COD_PRESUPUESTO_PC"))
                If Rows.Length > 1 Then
                    row("COD_PRESUPUESTO_PA") = ""
                    For i As Integer = 0 To Rows.Length - 1
                        row("COD_PRESUPUESTO_PA") += Rows(i)("COD_PRESUPUESTO_PA") + " - "
                    Next
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    Public Function ObtenerrPresupuestosUsados(ByVal CodCompania As Integer, ByVal CodCampanaMMS As Integer, ByVal CodSubCampanaMMS As Integer, ByVal CodPresupuestoPc As Integer, ByVal CodSoporteMMS As Integer) As DataTable

        Dim dt As DataTable

        dt = Me.TraerDataSet("SPK_PAGO_ANTICIPADO.SP_SELECT_SELECCIONADOS", CodCompania, CodCampanaMMS, CodSubCampanaMMS, CodPresupuestoPc, CodSoporteMMS).Tables(0)

        Return dt

    End Function

    Public Function ObtenerYaEnviados(ByVal CodCompania As Integer, ByVal CodCampanaMMS As Integer, ByVal CodSubCampanaMMS As Integer, ByVal CodMedio As Integer) As DataTable

        Dim dt As DataTable

        dt = Me.TraerDataSet("SPK_PAGO_ANTICIPADO.SP_SELECT_YAENVIADOS", CodCompania, CodCampanaMMS, CodSubCampanaMMS, CodMedio).Tables(0)

        Return dt

    End Function

    Public Function ObtenerPACargadosConcatenadosTemp(ByVal CodCompania As Integer, ByVal CodCampanaMMS As Integer, ByVal CodSubCampanaMMS As Integer, ByVal CodPresupuestoPcMMS As Integer, ByVal CodPresupuestoPaMMS As Integer, ByVal CodSoporteMMS As Integer, ByVal Anio As Integer, ByVal Mes As Integer, ByVal IdMedio As Integer, ByVal TipoBusqueda As Integer) As DataTable

        Dim dt As DataTable
        Dim Rows() As DataRow
        Dim COD_PRESUPUESTO_PA As String
        Dim DtDistint As New DataTable
        Dim DTReturn As New DataTable
        Dim OSoporte As New Soportes

        Try
            dt = Me.TraerDataSet("SPK_PAGO_ANTICIPADO.SP_SELECT_PA_TEMP", CodCompania, CodCampanaMMS, CodSubCampanaMMS, CodPresupuestoPcMMS, CodPresupuestoPaMMS, CodSoporteMMS, Anio, Mes, IdMedio).Tables(0)

            DtDistint = dt.DefaultView.ToTable(True, "COD_COMPANIA", "COD_CAMPANA", "COD_SUBCAMPANA", "COD_PRESUPUESTO_PC")

            If TipoBusqueda = 0 Then
                DtDistint.Columns.Add("COD_PRESUPUESTO_PA", GetType(String))
                DtDistint.Columns.Add("COD_SOPORTE", GetType(Integer))
                DtDistint.Columns.Add("ANO", GetType(Integer))
                DtDistint.Columns.Add("MES", GetType(Integer))

                For Each row As DataRow In DtDistint.Rows
                    Rows = dt.Select("COD_PRESUPUESTO_PC = " & row("COD_PRESUPUESTO_PC"))
                    If Rows.Length > 1 Then
                        COD_PRESUPUESTO_PA = ""
                        For i As Integer = 0 To Rows.Length - 1
                            OSoporte.Id_medio = IdMedio
                            COD_PRESUPUESTO_PA += Rows(i)("COD_PRESUPUESTO_PA") + " - " + OSoporte.ObtenerDescripcion(CInt(Rows(i)("COD_SOPORTE"))) + " | "
                        Next
                        row("COD_PRESUPUESTO_PA") = COD_PRESUPUESTO_PA
                        row("COD_SOPORTE") = Rows(0)("COD_SOPORTE")
                        row("ANO") = Rows(0)("ANO")
                        row("MES") = Rows(0)("MES")
                        COD_PRESUPUESTO_PA = ""
                    ElseIf Rows.Length = 1 Then
                        row("COD_PRESUPUESTO_PA") = Rows(0)("COD_PRESUPUESTO_PA")
                        row("COD_SOPORTE") = Rows(0)("COD_SOPORTE")
                        row("ANO") = Rows(0)("ANO")
                        row("MES") = Rows(0)("MES")
                    End If
                Next
                DTReturn = DtDistint
            Else
                DTReturn = dt
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return DTReturn
    End Function

    Public Function EliminarTempPA(ByVal CodCompania As Integer, ByVal Cod_campania_mms As Integer, ByVal Cod_subcampania_mms As Integer, ByVal Cod_PresupuestoPC As Integer, ByVal Cod_PresupuestoPA As Integer, ByVal anio As Integer, ByVal mes As Integer, ByVal cod_medio As Integer, ByVal cod_soporte As Integer, ByVal cod_usuario As Integer)

        Me.Ejecutar("SPK_PAGO_ANTICIPADO.SP_DELETE_TEMP", CodCompania, Cod_campania_mms, Cod_subcampania_mms, Cod_PresupuestoPC, Cod_PresupuestoPA, anio, mes, cod_medio, cod_soporte, cod_usuario)

    End Function

    Public Function EliminarTempPAUsuario(ByVal CodCompania As Integer, ByVal Cod_campania_mms As Integer, ByVal cod_usuario As Integer)

        Me.Ejecutar("SPK_PAGO_ANTICIPADO.SP_DELETE_TEMP_USUARIO", CodCompania, Cod_campania_mms, cod_usuario)

    End Function

#End Region

    Public Function Traer_Avisos_MMS_TV(ByVal temas As String, ByVal Id_Soporte As Long, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer) As DataTable
        Dim dt As DataTable
        Dim otema As New Temas
        Try
            dt = Me.TraerDataSet("spk_envio_compras_2.SP_SELECCION_AVISOS_TV_MMS", Id_Campania, Id_Sistema, Id_Ejercicio, temas, Fecha_Desde, Fecha_Hasta, Id_Soporte).Tables(0)
            For Each row As DataRow In dt.Rows
                otema.Id_tema = temas
                otema.Id_campania = Id_Campania
                otema.BuscarPorID()

                row.Item("CODIGOCAMPANA") = Id_Campania
                row.Item("CODIGOCLIENTE") = Activo.IDCliente
                row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
                row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
                row.Item("CODIGOMATERIAL") = otema.Id_material ''id_material
                row.Item("CODIGOPRODUCTO") = otema.Id_producto ''id_material
                row.Item("CODIGOMEDIO") = Activo.IDMedio
                row.Item("CODIGOSUBCAMPANA") = codigoSubCampanaMms 'Me.Id_SubCampania_Sigeme
                row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            Next

        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    Public Function Traer_Avisos_Soporte_Radio(ByVal temas As String, ByVal Id_Soporte As Long) As DataTable
        Dim dt As DataTable
        Try
            dt = Me.TraerDataSet("spk_envio_compras.SP_SEL_AVISOS_SOPORTE_RADIO", Id_Campania, Id_Sistema, Id_Ejercicio, temas, Fecha_Desde, Fecha_Hasta, Id_Soporte).Tables(0)
        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    Public Function Traer_Avisos_Soporte_Prensa(ByVal pid_campania As Integer, ByVal pid_sistema As Integer, ByVal pid_ejercicio As Integer, ByVal pfecha_desde As Date, ByVal pfecha_hasta As Date, ByVal pid_producto As Integer, ByVal pid_material As Integer, ByVal pid_seccion As Integer, ByVal pid_soporte As Integer, ByVal pconsepto As String) As DataTable
        Dim dt As DataTable
        Try
            dt = Me.TraerDataSet("spk_envio_compras.SP_SELECCION_AVISOS_PRENSA", pid_campania, pid_sistema, pid_ejercicio, pfecha_desde, pfecha_hasta, pid_producto, pid_material, pid_seccion, pid_soporte, pconsepto).Tables(0)
        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    ''' <summary>
    ''' Setea los valores faltantes y los envia a Insertar en MMS.
    ''' </summary>
    ''' <param name="dtEnvio">DataTable</param>
    ''' <param name="idcampaniaMms">Id Campania MMS.</param>
    ''' <param name="codigoSubCampanaMms">Codigo Sub Campana MMS</param>
    ''' <param name="mmsCodPais">Codigo Pais.</param>
    ''' <param name="mmsCodUsuario">Codigo Usuario.</param>
    ''' <param name="mmsCodCompania">Codigo Compania</param>
    ''' <param name="codPresupuesto">Codigo Presupuesto.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InsertaAvisos_ext(ByVal dtEnvio As DataTable, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer, ByVal mmsCodPais As Integer, ByVal mmsCodUsuario As Integer, ByVal mmsCodCompania As Integer, ByVal codPresupuesto As Integer) As DataTable ''ByVal dtEnvio As DataTable) As DataTable
        Dim oMaestro As New Maestros
        Dim dtResult As DataTable
        For Each row As DataRow In dtEnvio.Rows
            row.Item("CODIGOCAMPANA") = idcampaniaMms
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = mmsCodCompania
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = codigoSubCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            'row.Item("CODIGOPRESUPUESTO") = codPresupuesto
        Next
        dtResult = oMaestro.InsertarOrdenExt(dtEnvio, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania)
        If Not dtResult.Rows.Count > 0 Then
        Else
            For Each row As DataRow In dtResult.Rows
                InsertaAvisos(0, row.Item("id_spot"), row.Item("id_spot_detalle"), row.Item("id_orden_mms"))
            Next
        End If
        Return dtResult
    End Function

    ''' <summary>
    ''' Inserta los avisos de Radio.
    ''' </summary>
    ''' <param name="idcampaniaMms">Id Campania MMS</param>
    ''' <param name="codigoSubCampanaMms">Sub Campania MMS</param>
    ''' <returns>DataTable con los codigo de orden.</returns>
    ''' <remarks></remarks>
    Public Function InsertaAvisosRadio(ByVal dt As DataTable, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer, ByVal mmsCodPais As Integer, ByVal mmsCodUsuario As Integer, ByVal mmsCodCompania As Integer) As DataTable
        Dim dtReturn As DataTable

        Dim _maestros As New Maestros
        dtReturn = _maestros.InsertarOrdenRadio(dt, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania)

        If Not dtReturn.Rows.Count > 0 Then

        Else
            For Each row As DataRow In dtReturn.Rows
                ''VEMOS DE AGREGAR EL USUARIO D_C
                ''ACTUALIZAMOS LA BASE DE DATOS DE EVEREST
                InsertaAvisos(0, row.Item("id_spot"), row.Item("id_spot_detalle"), row.Item("id_orden_mms"))
            Next
        End If

        Return dtReturn
    End Function

    'AG Produccion ++++++++++++++++++++++
    Public Function InsertaAvisos_pro(ByVal dtEnvio As DataTable, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer, ByVal mmsCodPais As Integer, ByVal mmsCodUsuario As Integer, ByVal mmsCodCompania As Integer, ByVal codPresupuesto As Integer) As DataTable
        Dim oMaestro As New Maestros
        Dim dtResult As DataTable
        For Each row As DataRow In dtEnvio.Rows
            row.Item("CODIGOCAMPANA") = idcampaniaMms
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = mmsCodCompania
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = codigoSubCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            'row.Item("CODIGOPRESUPUESTO") = codPresupuesto
        Next

        dtResult = oMaestro.InsertarOrdenPro(dtEnvio, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania)

        'dtResult = oMaestro.InsertarOrdenExt(dtEnvio, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania)
        If Not dtResult.Rows.Count > 0 Then
        Else
            For Each row As DataRow In dtResult.Rows
                InsertaAvisos(0, row.Item("id_spot"), row.Item("id_spot_detalle"), row.Item("id_orden_mms"))
            Next
        End If
        Return dtResult
    End Function

    Public Function InsertaAvisos_Internet(ByVal dtEnvio As DataTable, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer, ByVal mmsCodPais As Integer, ByVal mmsCodUsuario As Integer, ByVal mmsCodCompania As Integer, ByVal codPresupuesto As Integer, ByVal mmsCodCliente As Integer, ByVal mesPresupuestos As String, ByVal anioPresupuestos As String, ByVal codigoPresupuestos As String, ByVal esEnvioDoble As Boolean) As DataTable

        Dim oMaestro As New Maestros
        Dim dtResult As DataTable

        If Not esEnvioDoble Then
            For Each row As DataRow In dtEnvio.Rows
                row.Item("CODIGOCAMPANA") = idcampaniaMms
                row.Item("CODIGOCLIENTE") = Activo.IDCliente
                row.Item("CODIGOCOMPANIA") = mmsCodCompania
                row.Item("CODIGODELEGACION") = 1
                row.Item("CODIGOMEDIO") = Activo.IDMedio
                row.Item("CODIGOSUBCAMPANA") = codigoSubCampanaMms
                row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            Next
        End If

        dtResult = oMaestro.InsertarOrdenInternet(dtEnvio, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania, mmsCodCliente, mesPresupuestos, anioPresupuestos, codigoPresupuestos, esEnvioDoble)

        If Not esEnvioDoble Then
            If Not dtResult.Rows.Count > 0 Then
            Else
                For Each row As DataRow In dtResult.Rows
                    InsertaAvisosInterent(row.Item("id_spot"), row.Item("id_orden_mms"))
                Next
            End If
        End If

        Return dtResult
    End Function



    Public Sub ActualizarPresupuesto(ByVal pCodPresupuesto As Double, ByVal pCodIntercambio As Double)
        Me.Ejecutar("SPK_ENVIO_COMPRAS.SP_UPDATE_PRESUPUESTOS_SIGEME", pCodPresupuesto, pCodIntercambio)
    End Sub

    Public Function Cantidad_Spot_Enviados() As Integer
        Try
            Cantidad_Spot_Enviados = Me.Ejecutar("SPK_ENVIO_COMPRAS.SP_CONTROL_NUM_PASE", Id_Presupuesto_Sigeme)
        Catch ex As Exception
            Cantidad_Spot_Enviados = 0
        End Try
    End Function

    Public Function Cantidad_Ordenes_Enviados() As Integer
        Try
            Cantidad_Ordenes_Enviados = Me.Ejecutar("SPK_ENVIO_COMPRAS.SP_CONTROL_ORDEN_PRESUPUESTO", Id_Presupuesto_Sigeme)
        Catch ex As Exception
            Cantidad_Ordenes_Enviados = 0
        End Try
    End Function

    Public Function TraerIntercambiosOld() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_INTERCAMBIOS", mid_Cliente, mFecha_Desde).Tables(0)
    End Function

    Public Function ObtenerSpotsPrensa() As DataTable
        Return Me.TraerDataSet("SPK_ENVIO_COMPRAS_2.SP_SELECCION_AVISOS_PRENSA_MMS", mId_Campania, mId_Sistema, mId_Ejercicio, Activo.IDMedio, mFecha_Desde, mFecha_Hasta, mId_Producto, mId_Material, mid_Seccion, mLista_Soportes, mConcepto).Tables(0)
    End Function

#Region "Spots para P.A"

    Public Function ObtenerSpotsPrensaPA() As DataTable
        Return Me.TraerDataSet("SPK_ENVIO_COMPRAS.SP_SELECCION_AVISOS_PR_MMS_PA", mId_Campania, mId_Sistema, mId_Ejercicio, Activo.IDMedio, mFecha_Desde, mFecha_Hasta, mId_Producto, mId_Material, mid_Seccion, mLista_Soportes, mConcepto).Tables(0)
    End Function

    Public Function traer_avisos_MMS_EXTPA(ByVal cod_campanaMms As Integer, ByVal cod_subCampanaMms As Integer, ByVal cod_paismms As Integer, ByVal cod_Usuariomms As Integer, ByVal cod_Companiamms As Integer, ByVal id_Material As Integer, ByVal id_Producto As Integer, ByVal id_campania As Integer, ByVal cod_Presupuestomms As Integer) As DataTable
        Dim dt As New DataTable

        dt = TraerDataSet("SPK_ENVIO_COMPRAS.SP_SELECCION_AVISOS_EXT_MMS_PA", mId_Campania, mId_Sistema, mId_Ejercicio, mFecha_Desde, mFecha_Hasta, mId_Producto, id_Material, mid_Provincia, mLista_Soportes).Tables(0)

        For Each row As DataRow In dt.Rows
            row.Item("CODIGOCAMPANA") = id_campania
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = cod_subCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            'row.Item("CODIGOPRESUPUESTO") = cod_Presupuestomms
        Next
        Return dt
    End Function

    'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Public Function traer_avisos_MMS_ProduccionPA(ByVal cod_campanaMms As Integer, ByVal cod_subCampanaMms As Integer, ByVal cod_paismms As Integer, ByVal cod_Usuariomms As Integer, ByVal cod_Companiamms As Integer, ByVal id_Material As Integer, ByVal id_Producto As Integer, ByVal id_campania As Integer, ByVal cod_Presupuestomms As Integer) As DataTable
        Dim dt As New DataTable

        dt = TraerDataSet("SPK_ENVIO_COMPRAS.SP_SELECCION_AVISOS_PRO_MMS_PA", mId_Campania, mId_Sistema, mId_Ejercicio, mFecha_Desde, mFecha_Hasta, mId_Producto, mid_Provincia, mLista_Soportes).Tables(0)

        For Each row As DataRow In dt.Rows
            row.Item("CODIGOCAMPANA") = id_campania
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = cod_subCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            'row.Item("CODIGOPRESUPUESTO") = cod_Presupuestomms
        Next
        Return dt
    End Function

    Public Function traer_avisos_MMS_InternetPA(ByVal cod_campanaMms As Integer, ByVal cod_subCampanaMms As Integer, ByVal cod_paismms As Integer, ByVal cod_Usuariomms As Integer, ByVal cod_Companiamms As Integer, ByVal id_campania As Integer, ByVal cod_Presupuestomms As Integer) As DataTable
        Dim dt As New DataTable

        dt = TraerDataSet("SPK_ENVIO_COMPRAS.SP_SELECCION_AVISOS_INT_MMS_PA", mId_Campania, mId_Sistema, mId_Ejercicio, Activo.Medios.Internet, mFecha_Desde, mFecha_Hasta, mLista_Soportes).Tables(0)

        For Each row As DataRow In dt.Rows
            row.Item("CODIGOCAMPANA") = id_campania
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = cod_subCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
        Next
        Return dt
    End Function

#End Region

    Public Function Traer_Avisos_MMS_RD(ByVal temas As String, ByVal Id_Soporte As Long, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer) As DataTable
        Dim dt As DataTable
        Dim otema As New Temas
        Try

            dt = Me.TraerDataSet("spk_envio_compras.SP_SELECCION_AVISOS_RD_MMS", Activo.IDCampaña, Id_Sistema, Id_Ejercicio, temas, Fecha_Desde, Fecha_Hasta, Id_Soporte).Tables(0)
            For Each row As DataRow In dt.Rows
                otema.Id_tema = temas
                otema.Id_campania = Id_Campania
                otema.BuscarPorID()

                row.Item("CODIGOCAMPANA") = Id_Campania
                row.Item("CODIGOCLIENTE") = Activo.IDCliente
                row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
                row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
                row.Item("CODIGOMATERIAL") = otema.Id_material ''id_material
                row.Item("CODIGOPRODUCTO") = otema.Id_producto ''id_material
                row.Item("CODIGOMEDIO") = Activo.IDMedio
                row.Item("CODIGOSUBCAMPANA") = Me.Id_SubCampania_Sigeme
                row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            Next

        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    Public Function InsertaAvisosPrensa(ByVal dt As DataTable, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer, ByVal mmsCodPais As Integer, ByVal mmsCodUsuario As Integer, ByVal mmsCodCompania As Integer, ByVal idMaterial As Integer, ByVal idProd As Integer, ByVal id_campania As Integer, ByVal codPresupuesto As Integer) As DataTable
        Dim dtReturn As DataTable
        Dim _maestros As New Maestros
        Dim material As String
        Try

            For Each row As DataRow In dt.Rows
                row.Item("CODIGOCAMPANA") = id_campania
                row.Item("CODIGOCLIENTE") = Activo.IDCliente
                row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
                row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
                row.Item("CODIGOMATERIAL") = idMaterial
                row.Item("CODIGOPRODUCTO") = idProd
                row.Item("CODIGOMEDIO") = Activo.IDMedio
                row.Item("CODIGOSUBCAMPANA") = codigoSubCampanaMms
                row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            Next

            If Activo.IDMedio = 4 Then
                dtReturn = _maestros.InsertarOdenPrensa(dt, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania)
            Else
                dtReturn = _maestros.InsertarOrdenRevista(dt, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania)
            End If

            If Not dtReturn.Rows.Count > 0 Then
                ''
            Else
                For Each row As DataRow In dtReturn.Rows
                    ''VEMOS DE AGREGAR EL USUARIO D_C
                    ''ACTUALIZAMOS LA BASE DE DATOS DE EVEREST
                    InsertaAvisos(0, row.Item("id_spot"), row.Item("id_spot_detalle"), row.Item("id_orden_mms"))
                Next
            End If
            Return dtReturn
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function InsertaAvisosExterior(ByVal pIntercambio As Integer, ByVal pid_spot As Long, ByVal pid_spot_detalle As Long, ByVal pUsuario As String) As Integer
    '    'Try
    '    '    Return Me.Ejecutar("SPK_ENVIO_COMPRAS.SP_INSERTA_TABLAS_EXTERIOR_ALL", mid_Cliente, mId_Producto, mId_Material, mId_Campania_Sigeme, mId_SubCampania_Sigeme, mId_Presupuesto_Sigeme, mId_Medio, pIntercambio, pid_spot, pid_spot_detalle, pUsuario)
    '    'Catch ex As Exception
    '    '    Throw ex
    '    'End Try
    'End Function

#Region "DATOS MMS"

    ''' <summary>
    ''' Trae de la base de datos de Everest los spots para enviar a compras, se completa con los datos de MMS
    ''' </summary>
    ''' <param name="cod_campanaMms"></param>
    ''' <param name="cod_subCampanaMms"></param>
    ''' <param name="cod_paismms"></param>
    ''' <param name="cod_Usuariomms"></param>
    ''' <param name="cod_Companiamms"></param>
    ''' <param name="id_Material"></param>
    ''' <param name="id_Producto"></param>
    ''' <param name="id_campania"></param>
    ''' <param name="cod_Presupuestomms"></param>
    ''' <returns>datatable de spots Exterior</returns>
    ''' <remarks></remarks>
    Public Function traer_avisos_MMS_EXT(ByVal cod_campanaMms As Integer, ByVal cod_subCampanaMms As Integer, ByVal cod_paismms As Integer, ByVal cod_Usuariomms As Integer, ByVal cod_Companiamms As Integer, ByVal id_Material As Integer, ByVal id_Producto As Integer, ByVal id_campania As Integer, ByVal cod_Presupuestomms As Integer) As DataTable
        Dim dt As New DataTable

        dt = TraerDataSet("SPK_ENVIO_COMPRAS_2.SP_SELECCION_AVISOS_EXT_MMS", mId_Campania, mId_Sistema, mId_Ejercicio, mFecha_Desde, mFecha_Hasta, mId_Producto, id_Material, mid_Provincia, mLista_Soportes).Tables(0)

        For Each row As DataRow In dt.Rows
            row.Item("CODIGOCAMPANA") = id_campania
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = cod_subCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            'row.Item("CODIGOPRESUPUESTO") = cod_Presupuestomms
        Next
        Return dt
    End Function

    'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Public Function traer_avisos_MMS_Produccion(ByVal cod_campanaMms As Integer, ByVal cod_subCampanaMms As Integer, ByVal cod_paismms As Integer, ByVal cod_Usuariomms As Integer, ByVal cod_Companiamms As Integer, ByVal id_Material As Integer, ByVal id_Producto As Integer, ByVal id_campania As Integer, ByVal cod_Presupuestomms As Integer) As DataTable
        Dim dt As New DataTable

        dt = TraerDataSet("SPK_ENVIO_COMPRAS_2.SP_SELECCION_AVISOS_PRO_MMS", mId_Campania, mId_Sistema, mId_Ejercicio, mFecha_Desde, mFecha_Hasta, mId_Producto, mid_Provincia, mLista_Soportes).Tables(0)

        For Each row As DataRow In dt.Rows
            row.Item("CODIGOCAMPANA") = id_campania
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = cod_subCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            'row.Item("CODIGOPRESUPUESTO") = cod_Presupuestomms
        Next
        Return dt
    End Function

    Public Function traer_avisos_MMS_Internet(ByVal cod_campanaMms As Integer, ByVal cod_subCampanaMms As Integer, ByVal cod_paismms As Integer, ByVal cod_Usuariomms As Integer, ByVal cod_Companiamms As Integer, ByVal id_campania As Integer, ByVal cod_Presupuestomms As Integer) As DataTable
        Dim dt As New DataTable

        dt = TraerDataSet("SPK_ENVIO_COMPRAS.SP_SELECCION_AVISOS_INT_MMS", mId_Campania, mId_Sistema, mId_Ejercicio, Activo.Medios.Internet, mFecha_Desde, mFecha_Hasta, mLista_Soportes).Tables(0)

        For Each row As DataRow In dt.Rows
            row.Item("CODIGOCAMPANA") = id_campania
            row.Item("CODIGOCLIENTE") = Activo.IDCliente
            row.Item("CODIGOCOMPANIA") = Activo.IDCompaniaMMS
            row.Item("CODIGODELEGACION") = 1 '' delegacion HACK: Jsperk - Consultar a que se refiere con delegacion.// SE OBTIENE DESDE EL ACTIVO
            row.Item("CODIGOMEDIO") = Activo.IDMedio
            row.Item("CODIGOSUBCAMPANA") = cod_subCampanaMms
            row.Item("CODIGOUSUARIO") = Activo.IDUsuarioMMS
            If cod_Presupuestomms > 0 Then
                row.Item("CODIGOPRESUPUESTO") = cod_Presupuestomms
            End If
        Next
        Return dt
    End Function


    ''' <summary>
    ''' Inserta los spots y devuelve otro datatable con las ordenes de MMS
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <param name="idcampaniaMms"></param>
    ''' <param name="codigoSubCampanaMms"></param>
    ''' <param name="mmsCodPais"></param>
    ''' <param name="mmsCodUsuario"></param>
    ''' <param name="mmsCodCompania"></param>
    ''' <param name="mmsCodCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InsertaAvisosMMS(ByVal dt As DataTable, ByVal idcampaniaMms As Integer, ByVal codigoSubCampanaMms As Integer, ByVal mmsCodPais As Integer, ByVal mmsCodUsuario As Integer, ByVal mmsCodCompania As Integer, ByVal mmsCodCliente As Integer) As DataTable
        Dim dtReturn As DataTable
        ''//DANIEL CAIME
        ''// ACA VA TODA LA FUNCIONALIDAD PARA EL INSERT DE MMS
        Dim _maestros As New Maestros

        dtReturn = _maestros.InsertarOrden(dt, idcampaniaMms, codigoSubCampanaMms, mmsCodPais, mmsCodUsuario, mmsCodCompania, mmsCodCliente)

        If Not dtReturn.Rows.Count > 0 Then
            ''sarasa
        Else
            For Each row As DataRow In dtReturn.Rows
                ''VEMOS DE AGREGAR EL USUARIO D_C
                ''ACTUALIZAMOS LA BASE DE DATOS DE EVEREST
                ' LO COMENTO POR DESARROLLO DE ENVIO A COMPRA LIGERO (AN)
                'InsertaAvisos(0, row.Item("id_spot"), row.Item("id_spot_detalle"), row.Item("id_orden_mms"))
            Next
        End If

        Return dtReturn
    End Function

    ''' <summary>
    ''' Actualiza la tabla de Spots_detalle con los codigos de orden de mms, cambio de estado a compra
    ''' </summary>
    ''' <param name="Intercambio"></param>
    ''' <param name="id_spot">Id Spot</param>
    ''' <param name="id_spot_detalle">Id Spot Detalle</param>
    ''' <param name="id_orden_mms">Id Orden</param>
    ''' <remarks></remarks>
    Public Sub InsertaAvisos(ByVal Intercambio As Integer, ByVal id_spot As Long, ByVal id_spot_detalle As Long, ByVal id_orden_mms As Long)
        Me.Ejecutar("SPK_ENVIO_COMPRAS.SP_INSERTA_TABLAS_MMS_ALL", id_spot, id_spot_detalle, "mms", id_orden_mms)
    End Sub

    Public Sub InsertaAvisosInterent(ByVal id_spot As Long, ByVal id_orden_mms As Long)
        Me.Ejecutar("SPK_ENVIO_COMPRAS.SP_INSERTA_ORDEN_MMS_INT", id_spot, id_orden_mms)
    End Sub


    Public Function TraerSoportesTemas() As DataTable
        Dim osoporte As Soportes = New Soportes
        Dim dt As DataTable = New DataTable
        'AGuzzardi Anexo Soportes MMS --------------------------------------------------------------------------
        Dim OGAdmin As New GrillAdmin
        dt = AnexarSoporteMMS(Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SOPORTES_TEMAS", Id_Campania, Id_Sistema, Id_Ejercicio, Id_Producto).Tables(0), "descripcion")
        '-------------------------------------------------------------------------------------------------------
        'AGuzzardi Codigo Original ------------------------------------------------------------------------------
        'dt = Me.TraerDataSet("Spk_" & MyBase.Tabla & ".SP_FILTRO_SOPORTES_TEMAS", Id_Campania, Id_Sistema, Id_Ejercicio, 1).Tables(0) 'Id_Producto).Tables(0)
        '-------------------------------------------------------------------------------------------------------
        ''For Each dr As DataRow In dt.Rows
        ''dr.Item("DESCRIPCION") = osoporte.ObtenerDescripcion(dr.Item("ID_SOPORTE"))
        ''Next
        Return dt
    End Function

    Private Function AnexarSoporteMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else

            DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
            DtBaseDatos.Columns.Add("DES_PROVEEDOR", GetType(String))
            DtBaseDatos.Columns.Add("DES_SOPORTE", GetType(String))
            DtBaseDatos.Columns.Add("ID_PROVEEDOR", GetType(Integer))

            DtBaseDatos.AcceptChanges()

            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                    r("des_proveedor") = Rows(i).Item("DES_PROVEEDOR").ToString
                    r("des_soporte") = Rows(i).Item("DES_SOPORTE").ToString
                    r("id_proveedor") = Rows(i).Item("ID_PROVEEDOR").ToString
                Next
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos
    End Function

    Public Function TraerIntercambiosMMS(ByVal idcliente As Integer, ByVal FDesde As Date, ByVal FHasta As Date, Optional ByVal CodIntercambio As String = "") As DataTable

        Dim OIntercambio As New Maestros
        Dim dt As DataTable
        dt = OIntercambio.ObtenerIntercambio(CInt(Activo.CodPaisMms), CInt(Activo.IDCompaniaMMS), idcliente, FDesde, FHasta, CodIntercambio)

        If dt Is Nothing Then
        Else
            If dt.Rows.Count > 0 Then
                dt = ArmarEstructuraIntercambioMMS(dt)
            End If
        End If

        Return dt

    End Function

    Public Function InsertarIntercambio(ByVal codpais As Integer, ByVal codcompania As Integer, ByVal codcliente As Integer, ByVal descripcion As String, ByVal inporte As Decimal, ByVal FDesde As Date, ByVal FFin As Date) As DataTable

        Dim OIntercambio As New Maestros
        Dim dt As DataTable
        OIntercambio.InsertarIntercambio(codpais, codcompania, codcliente, descripcion, inporte, FDesde, FFin)
        Return dt

    End Function

    Public Function ArmarEstructuraIntercambioMMS(ByVal DtIntercambio As DataTable) As DataTable

        Dim DtIntercambios As New DataTable
        Dim DrIntercambio As DataRow
        Dim FilaNueva As DataRow

        With DtIntercambios.Columns
            .Add("cod_intercambio", GetType(Integer))
            .Add("des_intercambio", GetType(String))
            .Add("f_inicio_intercambio", GetType(Date))
            .Add("f_fin_intercambio", GetType(Date))
            .Add("importe", GetType(Decimal))
        End With


        If Not DtIntercambio Is Nothing Then
            If DtIntercambio.Rows.Count > 0 Then
                For Each DrIntercambio In DtIntercambio.Rows
                    FilaNueva = DtIntercambios.NewRow
                    FilaNueva("cod_intercambio") = DrIntercambio("COD_INTERCAMBIO")
                    FilaNueva("des_intercambio") = DrIntercambio("DES_INTERCAMBIO")
                    FilaNueva("f_inicio_intercambio") = DrIntercambio("FECHAINICIO")
                    FilaNueva("f_fin_intercambio") = DrIntercambio("FECHAFIN")
                    FilaNueva("importe") = DrIntercambio("IMPINTERCAMBIO")
                    DtIntercambios.Rows.Add(FilaNueva)
                Next
            End If
        End If

        Return DtIntercambios

    End Function

#End Region
End Class

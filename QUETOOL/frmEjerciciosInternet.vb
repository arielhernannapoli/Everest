Imports MPG.DBL
Imports System.Text
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Framework.Mensajes
Imports Infragistics.Win.Printing
Imports MSL
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Shared
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class frmEjerciciosInternet

#Region "Variables Generales"

    Private mId_Campania As Integer
    Private mId_Sistema As Integer
    Private mId_Ejercicio As Integer
    Private mIdTipoSoporte As Integer
    Private mIdCliente As Integer
    Private mFechaInicio As DateTime
    Private mFechaFin As DateTime
    Private mDescCliente As String
    Private mDescCampania As String
    Private mDescSistema As String
    Private mDescEjercicio As String
    Private EspacioBlanco As String = "  "
    Private mConvenios As SortedList
    Private Ejer As EjercicioActivo
    Dim mListaSoportes As New ArrayList
    Dim ListaSpotDuplicados As New ArrayList
    Dim mEsCargaNueva As Boolean
    Dim mAperturaNuevaHoja As Boolean
    Dim ProximoIdSpot As Long
    Private mTConvenio As String
    Dim ControlDeCambiosDatos As Boolean
    Dim AgregarNuevosSoportes As Boolean
    Dim EliminarRegistros As Boolean
    Dim ControlGuardarSalir As Boolean
    '======= Operacion Fila Grilla ========
    Dim OperacionFilaNueva As String = "0"
    Dim OperacionFilaEditar As String = "1"
    '=========== Datatables ===============
    Private DtGrilla As New DataTable
    Dim DtTarifas As New DataTable
    Dim DtSpot As New DataTable
    Dim DtSpot_Internet As New DataTable
    '=========== Datatables Proveedor ======
    Dim DtDesgloseProveedor As New DataTable
    '============ Mensajes ================
    Dim MensajeTitulo As String = "Everest Planificacion DIGITAL"
    Dim MensajeFilaSeleccionadaDuplicar As String = "Debe seleccionar la Fila ORIGEN, que desea DUPLICAR."
    Dim MensajeValidacionTarfias As String = "Debe seleccionar datos correspondientes, para la apliacion de TARIFAS."
    Dim MensajeValidacionBusquedaTarifas As String = "No existen TARIFAS, cargadas para esos parametros seleccionados."
    Dim MensajeSeleccion As String = "No existen registros seleccionados."
    Dim MensajeIDSPOTNoExiste As String = "No se encuentra el IDSPOT, en el DtGrilla."
    Dim MensajeMesDistinto As String = "El mes no Puede ser distinto. "
    Dim MensajeAnioDistinto As String = "El año no Puede ser distinto. "
    Dim MensajeFechaInicioMAYOR As String = "La fecha de inicio no puede ser mayor a la fecha fin. "
    Dim MensajeFechaFinMENOR As String = "La fecha de Hasta no puede ser menor a la fecha inicio. "
    Dim MensajeCamposIncompletos As String = "Campos incompletos. "
    Dim MensajeGuardarSalir As String = "No se puede guardar el ejercicio debido a que exiten errores de Fechas."
    '============ Config. Colores =========
    Private ColorColTotales As Color = Color.LightYellow


#End Region

#Region "Objetos"

    '============= Declaracion de Objetos Clases ============
    Dim OSpots As Spots_int
    Dim OSpotInternet As Spots_int
    Dim GrillaFormato As New GrillaFormato
    Dim OTarifaInternet As Tarifas_Internet
    Dim OFormatos As Formatos
    Dim OSecciones As Secciones
    Dim OColocaciones As Colocaciones


    '======== Declaracion de Objetos Listas para Combos de la Grilla ============
    Private vlistUbicacion As ValueList   '= Secciones en MMS
    Private vlistTipoFormato As ValueList '= Colocacion en MMS
    Private vlistFormatos As ValueList    '= Formato en MMS
    Private vlistModalidadCompra As ValueList  '= Tipo Planificacion Tabla SPOTS
    Private vlistTipoSoporte As ValueList    '= TipoSoporte
    Private vlistSoporte As ValueList    '= Soporte
    Private vlistProveedor As ValueList  '= Proeevor 

    '======= Declaracion de Objetos Formularios ================
    Public WithEvents ConveniosMedios As New frmConveniosMedios

#End Region

#Region "Propiedades"

    Public Property ListaSoportes() As ArrayList
        Get
            Return mListaSoportes
        End Get
        Set(ByVal Value As ArrayList)
            mListaSoportes = Value
        End Set
    End Property

    Public Property Id_Campania() As Integer
        Get
            Return mId_Campania
        End Get
        Set(ByVal Value As Integer)
            mId_Campania = Value
        End Set
    End Property

    Public Property Id_Sistema() As Integer
        Get
            Return mId_Sistema
        End Get
        Set(ByVal Value As Integer)
            mId_Sistema = Value
        End Set
    End Property

    Public Property Id_Ejercicio() As Integer
        Get
            Return mId_Ejercicio
        End Get
        Set(ByVal Value As Integer)
            mId_Ejercicio = Value
        End Set
    End Property

    Public Property IdTipoSoporte() As Integer
        Get
            Return mIdTipoSoporte
        End Get
        Set(ByVal Value As Integer)
            mIdTipoSoporte = Value
        End Set
    End Property

    Public Property IdCliente() As Integer
        Get
            Return mIdCliente
        End Get
        Set(ByVal Value As Integer)
            mIdCliente = Value
        End Set
    End Property

    Public Property Campania() As String
        Get
            Return mDescCampania
        End Get
        Set(ByVal Value As String)
            mDescCampania = Value
        End Set
    End Property

    Public Property Sistema() As String
        Get
            Return mDescSistema
        End Get
        Set(ByVal Value As String)
            mDescSistema = Value
        End Set
    End Property

    Public Property Ejercicio() As String
        Get
            Return mDescEjercicio
        End Get
        Set(ByVal Value As String)
            mDescEjercicio = Value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return mDescCliente
        End Get
        Set(ByVal Value As String)
            mDescCliente = Value
        End Set
    End Property

    Public Property FechaInicio() As DateTime
        Get
            Return mFechaInicio
        End Get
        Set(ByVal Value As DateTime)
            mFechaInicio = Value
        End Set
    End Property

    Public Property FechaFin() As DateTime
        Get
            Return mFechaFin
        End Get
        Set(ByVal Value As DateTime)
            mFechaFin = Value
        End Set
    End Property

    Public Property EsCargaNueva() As Boolean
        Get
            Return mEsCargaNueva
        End Get
        Set(ByVal Value As Boolean)
            mEsCargaNueva = Value
        End Set
    End Property

    Public Property AperturaNuevaHoja() As Boolean
        Get
            Return mAperturaNuevaHoja
        End Get
        Set(ByVal Value As Boolean)
            mAperturaNuevaHoja = Value
        End Set
    End Property


#End Region

#Region "Eventos"


#Region "Eventos Grilla"

    ''AZ--se agrega validacion para fechas en la grilla antes de enviar a convenios-falta impllementacio

    Private Function ValidarFechas(ByVal fechaDesde As Date, ByVal fechaHasta As Date) As Integer

        'AG 11/05/2015 Arreglo de las modificaciones de ARIEL 

        Dim resultado As Integer = ValidarFecha.OKFechas

        If fechaDesde.Month <> fechaHasta.Month Then
            resultado = ValidarFecha.MesDistinto
            ControlGuardarSalir = True
            Return resultado
        End If

        If fechaDesde.Year <> fechaHasta.Year Then
            resultado = ValidarFecha.AnioDistinto
            ControlGuardarSalir = True
            Return resultado
        End If

        If fechaDesde.Date > fechaHasta.Date Then
            resultado = ValidarFecha.FInicioMayor
            ControlGuardarSalir = True
            Return resultado
        End If


        If fechaHasta.Date < fechaDesde.Date Then
            resultado = ValidarFecha.FFinMenor
            ControlGuardarSalir = True
            Return resultado
        End If

        ControlGuardarSalir = False

    End Function

    Private Sub ugPlanificacionInternet_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugPlanificacionInternet.AfterCellUpdate

        Dim IndiceResultadoValidacion As Integer
        Dim IndiceResultadoBusqueda As Integer
        Dim ResultadoFechas As Integer

        OTarifaInternet = New Tarifas_Internet


        Dim valueOriginal As Integer
        Dim value As Integer

        If EliminarRegistros = False Then

            Select Case e.Cell.Column.Key
                Case "F_INICIO", "F_FIN"
                    Me.txtFoco.Focus()

                    'AG 11/05/2015 Arreglo de las modificaciones de ARIEL ===============================================================================================
                    ResultadoFechas = ValidarFechas(Me.ugPlanificacionInternet.ActiveRow.Cells("F_INICIO").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("F_FIN").Value)
                    Select Case ResultadoFechas
                        Case ValidarFecha.MesDistinto
                            MsgBox(MensajeMesDistinto, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                        Case ValidarFecha.AnioDistinto
                            MsgBox(MensajeAnioDistinto, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                        Case ValidarFecha.FInicioMayor
                            MsgBox(MensajeFechaInicioMAYOR, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                        Case ValidarFecha.FFinMenor
                            MsgBox(MensajeFechaFinMENOR, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                    End Select
                    '====================================================================================================================================================

                    IndiceResultadoValidacion = ValidarDatosTarifa(TipoValidacion.AplicacionTarifas)
                    SetearIconoEdicion(CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SPOT").Value), True)
                    Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar.ToString
                    If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                    End If
                    If IndiceResultadoValidacion = ResultadoOperacion.DatosOk Then
                        IndiceResultadoBusqueda = AplicarTarifasHoja(Me.IdCliente, CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SOPORTE").Value), CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_UBICACION").Value), Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_FORMATO").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("ID_FORMATO").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("F_INICIO").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("F_FIN").Value)
                        If IndiceResultadoBusqueda = ResultadoOperacion.TarifasNoExisten Then
                            ObtenerNetoCalculado()
                            Exit Select
                        ElseIf IndiceResultadoBusqueda = ResultadoOperacion.DatosOk Then
                            ObtenerNetoCalculado()
                        End If
                    Else
                        MsgBox(MensajeValidacionTarfias, MsgBoxStyle.Information, MensajeTitulo)
                        Exit Sub
                    End If


                Case "DCTO1", "DCTO2"
                    Me.txtFoco.Focus()
                    ObtenerNetoCalculado()
                    CalcularShareGrilla(CInt(Me.ugPlanificacionInternet.ActiveRow.Index), True) 'AG 03/01/2014
                    ControlCeldasVacias(e.Cell.Column.Key)
                    SetearIconoEdicion(CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SPOT").Value), True)
                    Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar.ToString
                    If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                    End If
                Case "BRUTO", "IMPRESIONES"
                    'LC 07/07/2014 Habilita la edicion de la columna BRUTO e IMPRESIONES
                    Me.txtFoco.Focus()
                    ObtenerNetoCalculado()
                    CalcularShareGrilla(CInt(Me.ugPlanificacionInternet.ActiveRow.Index), True) 'AG 03/01/2014
                    ControlCeldasVacias(e.Cell.Column.Key)
                    SetearIconoEdicion(CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SPOT").Value), True)
                    Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar.ToString
                    If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                    End If
            End Select

            Select Case e.Cell.Column.Key
                Case "CANTIDAD_DIAS", "CANTIDAD_HORAS", "INVERSION"
                    ControlCeldasVacias(e.Cell.Column.Key)
                    SetearIconoEdicion(CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SPOT").Value), True)
                    If e.Cell.Column.Key = "INVERSION" Then 'Recalcula el SHARE cuando edita columna Inversion
                        CalcularShareGrilla(CInt(Me.ugPlanificacionInternet.ActiveRow.Index), True) 'AG 03/01/2013
                        CalcularImporteServicioAgenciaXFila() 'ReCalculo el Importe del Servico de Agencia
                        ObtenerCalcularTotalxFila() 'Recalculo el Total por FILA 
                    End If
                    Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar.ToString
                    If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                    End If
            End Select

            Me.iugProveedor.DataSource = PoblarDesgloseProveedor()

            ControlDeCambiosDatos = True

        End If



    End Sub

    Private Sub ugPlanificacionInternet_AfterExitEditMode1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugPlanificacionInternet.AfterExitEditMode


        If Not ugPlanificacionInternet.ActiveRow Is Nothing Then

            If Not ugPlanificacionInternet.ActiveCell Is Nothing Then

                If ugPlanificacionInternet.ActiveCell.Column.Key = "INVERSION" Then
                    FormatoEdicionColumnasEspecialesDesdeCELDA(ugPlanificacionInternet.ActiveCell.Column.Key)
                ElseIf ugPlanificacionInternet.ActiveCell.Column.Key = "CANTIDAD_DIAS" Then
                    FormatoEdicionColumnasEspecialesDesdeCELDA(ugPlanificacionInternet.ActiveCell.Column.Key)
                ElseIf ugPlanificacionInternet.ActiveCell.Column.Key = "CANTIDAD_HORAS" Then
                    FormatoEdicionColumnasEspecialesDesdeCELDA(ugPlanificacionInternet.ActiveCell.Column.Key)
                ElseIf ugPlanificacionInternet.ActiveCell.Column.Key = "DCTO1" Then
                    FormatoEdicionColumnasEspecialesDesdeCELDA(ugPlanificacionInternet.ActiveCell.Column.Key)
                    ObtenerNetoCalculado()
                ElseIf ugPlanificacionInternet.ActiveCell.Column.Key = "DCTO2" Then
                    FormatoEdicionColumnasEspecialesDesdeCELDA(ugPlanificacionInternet.ActiveCell.Column.Key)
                    ObtenerNetoCalculado()
                ElseIf ugPlanificacionInternet.ActiveCell.Column.Key = "BRUTO" Then
                    FormatoEdicionColumnasEspecialesDesdeCELDA(ugPlanificacionInternet.ActiveCell.Column.Key)
                    ObtenerNetoCalculado()
                End If
            End If
        End If
    End Sub

    Private Sub ugPlanificacionInternet_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugPlanificacionInternet.CellChange
        Dim IndiceResultadoValidacion As Integer
        Dim IndiceResultadoBusqueda As Integer
        OTarifaInternet = New Tarifas_Internet

        Dim valueOriginal As Integer
        Dim value As Integer

        Select Case e.Cell.Column.Key
            Case "ID_TIPO_COMPRA", "ID_UBICACION", "ID_TIPO_FORMATO", "ID_FORMATO"
                Me.txtFoco.Focus()
                SetearIconoEdicion(CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SPOT").Value), True)
                Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar.ToString
                If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                    Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                End If
                IndiceResultadoValidacion = ValidarDatosTarifa(TipoValidacion.AplicacionTarifas)
                If IndiceResultadoValidacion = ResultadoOperacion.DatosOk Then
                    IndiceResultadoBusqueda = AplicarTarifasHoja(Me.IdCliente, CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SOPORTE").Value), CInt(Me.ugPlanificacionInternet.ActiveRow.Cells("ID_UBICACION").Value), Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_FORMATO").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("ID_FORMATO").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("F_INICIO").Value, Me.ugPlanificacionInternet.ActiveRow.Cells("F_FIN").Value)
                    If IndiceResultadoBusqueda = ResultadoOperacion.TarifasNoExisten Then
                        ObtenerNetoCalculado()
                        Exit Select
                    ElseIf IndiceResultadoBusqueda = ResultadoOperacion.DatosOk Then
                        ObtenerNetoCalculado()
                    End If
                Else
                    MsgBox(MensajeValidacionTarfias, MsgBoxStyle.Information, MensajeTitulo)
                    Exit Sub
                End If
        End Select

        'AG == Aqui recalcula los valores segun la modalidad de compra que se elija en el compro de tipo compras
        Select Case e.Cell.Column.Key
            Case "ID_TIPO_COMPRA"
                FormatoEdicionColumnasEspecialesDesdeCOMBO(e.Cell.Column.Key)
        End Select

        ControlDeCambiosDatos = True
    End Sub

    Private Sub ugPlanificacionInternet_DoubleClickCell1(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles ugPlanificacionInternet.DoubleClickCell
        ugPlanificacionInternet.PerformAction(EnterEditMode)
    End Sub

    Private Sub ugPlanificacionInternet_InitializeLayout1(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ugPlanificacionInternet.InitializeLayout
        OcultarColumnas()
        CambiarNombreColumnas(e)
        CambiarFormatoColumnasDropDownList(e)
        CambiarFormatoColumnasDropCalendario(e)
        CambiarFormatoColumnaBotton(e)
        CambiarFormatoColumnasMoneda()
        CambiarFormatoColumnasDecimal()
        CambiarFormatoColumnasNumeral()

        Me.ugPlanificacionInternet.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True
        Me.ugPlanificacionInternet.DisplayLayout.Override.CellClickAction = CellClickAction.Edit

        ObtenerTotalPlanificacion()
        ObtenerTotalInversionFinalPlanificacion()
    End Sub

    Private Sub ugPlanificacionInternet_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ugPlanificacionInternet.KeyDown

        If Not ugPlanificacionInternet.ActiveRow Is Nothing Then
            If e.KeyCode <> 109 Then
                If Not ugPlanificacionInternet.ActiveCell Is Nothing Then
                    Dim EnEdicion As Boolean = ugPlanificacionInternet.ActiveCell.IsInEditMode
                    If Not ugPlanificacionInternet.ActiveRow Is Nothing AndAlso Me.ugPlanificacionInternet.ActiveRow.Selected Then
                        If e.KeyCode = Keys.Delete Then
                            If Not ugPlanificacionInternet.ActiveCell Is Nothing Then
                                If Not ugPlanificacionInternet.ActiveCell.IsInEditMode Then
                                    ugPlanificacionInternet.ActiveCell.Value = ""
                                End If
                            End If
                        End If
                    End If

                    Select Case e.KeyValue
                        Case Keys.Delete
                            ugPlanificacionInternet.ActiveCell.Value = 0

                        Case Keys.Enter, Keys.F2
                            e.Handled = True
                            If EnEdicion Then
                                ugPlanificacionInternet.PerformAction(ExitEditMode, False, False)
                            Else
                                ugPlanificacionInternet.PerformAction(EnterEditMode, False, False)
                            End If
                            ugPlanificacionInternet.UpdateData()
                        Case Keys.Escape
                            ugPlanificacionInternet.PerformAction(UndoCell, False, False)
                            e.Handled = True
                    End Select
                End If
            End If
        End If

    End Sub


#End Region

#Region "Eventos Menu Pop"

    Private Sub ugPlanificacionInternet_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugPlanificacionInternet.MouseDown
        If e.Button = MouseButtons.Right Then
            Me.CtxMenu.Show(Me.ugPlanificacionInternet, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub PopMenuDuplicarFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuDuplicarFila.Click
        Me.ugPlanificacionInternet.ActiveRow.Selected = True
        DuplicarFilaSeleccionada()
        CalcularShareGrilla(0, True)
        ReCargarGrilla()
        SetearIconoEdicionFilaNuevaSoporte()
    End Sub

    Private Sub PopMenuEliminarFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEliminarFila.Click
        Me.ugPlanificacionInternet.ActiveRow.Selected = True
        EliminarRegistros = True
        EliminarFilas()
        CalcularShareGrilla(0, True)
        ReCargarGrilla()
        If EliminarRegistros = True Then
            EliminarRegistros = False
        End If
    End Sub

    Private Sub PopMenuAplicarConvenioPuntual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuAplicarConvenioPuntual.Click
        Me.ugPlanificacionInternet.ActiveRow.Selected = True
        If Not Me.ugPlanificacionInternet.ActiveRow Is Nothing Then
            If ugPlanificacionInternet.Selected.Rows.Count > 0 Then
                If Not Me.ugPlanificacionInternet.ActiveRow.Cells("ID_ORDEN_MMS").Value Is System.DBNull.Value Then
                    MsgBox("No se puede aplicar convenio en esta FILA, Debido a que fue enviado a Compras", MsgBoxStyle.Information, MensajeTitulo)
                    Exit Sub
                End If
            End If
        End If
        BuscarConvenios(True)
    End Sub

#End Region

#Region "Eventos Controles"

    Private Sub frmEjerciciosInternet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub frmEjerciciosInternet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ConfigurarResolucionPantalla()
        CargarDatosCabecera()
        InHabilitarControlesCabecera()
        ObtenerRegistrosInicial()
        AliniaTitulosColumnas()
        AliniarDatosCeldas()
        HabilitarColumnasCargaInicialSegunModalidad()

        Ejer.IDCampaña = mId_Campania
        Ejer.IDSistema = mId_Sistema
        Ejer.IDEjercicio = mId_Ejercicio

        GrillaFormato.HabilitarFiltro(ugPlanificacionInternet, DefaultableBoolean.True)

        '============================================ Seccion de Desglose por PROVEEDOR =======================================
        If Not ugPlanificacionInternet Is Nothing Then
            If ugPlanificacionInternet.Rows.Count > 0 Then
                If Me.EsCargaNueva = False Then
                    ArmarEstructuraDtDesgloseProveedor()
                    iugProveedor.DataSource = PoblarDesgloseProveedor()
                Else
                    If DtDesgloseProveedor.Rows.Count = 0 Then
                        'ArmarEstructuraDtDesgloseProveedor()
                        iugProveedor.DataSource = DtDesgloseProveedor
                    End If
                End If
                SetearGrillaDesgloseProveedor()
                'LC 29/05/2014 Actualizar los Share al abrir la hoja digital
                RecorrerGrillaActualizarShare()
            End If
        End If

    End Sub

    Private Sub frmEjerciciosInternet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        If ControlDeCambiosDatos = True Then
            If Mensajes.Mensaje("¿Desea Guardar los Cambios realizados?", TipoMensaje.SiNo, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
                    For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
                        Dim Dr As DataRow
                        Dr = DtGrilla.Select("ID_SPOT = " & RowGrilla.Cells("ID_SPOT").Value)(0)
                        If Not Dr Is Nothing Then
                            If (IsDBNull(RowGrilla.Cells("ID_UBICACION").Value) Or RowGrilla.Cells("ID_UBICACION").Value = 0) Or (IsDBNull(RowGrilla.Cells("ID_TIPO_FORMATO").Value) Or RowGrilla.Cells("ID_TIPO_FORMATO").Value = 0) Or (IsDBNull(RowGrilla.Cells("ID_FORMATO").Value) Or RowGrilla.Cells("ID_FORMATO").Value = 0) Or (IsDBNull(RowGrilla.Cells("ID_TIPO_COMPRA").Value) Or RowGrilla.Cells("ID_TIPO_COMPRA").Value = 0) Then
                                MsgBox("No se puede guardar el ejercicio debido a que tiene campos incompletos", MsgBoxStyle.Exclamation, MensajeTitulo)
                                Activo.EjerciciosCargados.Remove(Ejer)
                                Exit Sub
                            End If
                        End If
                    Next
                End If

                'AG 11/05/2015 ========================================================================================================
                If ControlGuardarSalir = True Then
                    MsgBox(MensajeGuardarSalir, MsgBoxStyle.Exclamation, MensajeTitulo)
                    ControlGuardarSalir = False
                    Activo.EjerciciosCargados.Remove(Ejer)
                    Exit Sub
                Else
                    IgualarDtGrillaConGrillaDatos()
                    EjecutarOperacionDB()
                    Activo.EjerciciosCargados.Remove(Ejer)
                End If
                '=======================================================================================================================
            Else
                Activo.EjerciciosCargados.Remove(Ejer)
            End If
        Else
            Activo.EjerciciosCargados.Remove(Ejer)
        End If
    End Sub

    Private Sub btoAddFila_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoAddFila.Click

        If Me.ugPlanificacionInternet.ActiveRow Is Nothing And Me.ugPlanificacionInternet.ActiveCell Is Nothing Then
            MsgBox(MensajeFilaSeleccionadaDuplicar, MsgBoxStyle.Information, MensajeTitulo)
            Exit Sub
        Else
            DuplicarFilaSeleccionada()
            CalcularShareGrilla(0, True)
            ReCargarGrilla()
            SetearIconoEdicionFilaNuevaSoporte()
            MostrarPrimeraFila()
        End If

    End Sub

    Private Sub DtoQuitarFila_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtoQuitarFila.Click

        EliminarRegistros = True
        EliminarFilas()
        CalcularShareGrilla(0, True)
        ReCargarGrilla()
        'SetearIconoGuardarEditar()
        'ControlDeCambiosDatos = True
        If EliminarRegistros = True Then
            EliminarRegistros = False
        End If

    End Sub

    Private Sub BtoSoporte_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoSoporte.Click

        AgregarSoportes()
        AgregarNuevosSoportes = True
        ReCargarGrilla()
        SetearIconoEdicionFilaNuevaSoporte()
        MostrarPrimeraFila()

    End Sub

    Private Sub btoExportar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoExportar.Click
        ExportarImprimir(False)
    End Sub

    Private Sub btoImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoImprimir.Click
        ExportarImprimir(True)
    End Sub

    Private Sub btoConvenioPuntual_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoConvenioPuntual.Click
        If Not Me.ugPlanificacionInternet.ActiveRow Is Nothing Then
            If ugPlanificacionInternet.Selected.Rows.Count > 0 Then
                If Not Me.ugPlanificacionInternet.ActiveRow.Cells("ID_ORDEN_MMS").Value Is System.DBNull.Value Then
                    MsgBox("No se puede aplicar convenio en esta FILA, Debido a que fue enviado a Compras", MsgBoxStyle.Information, MensajeTitulo)
                    Exit Sub
                End If
            End If
        End If

        BuscarConvenios(True)
    End Sub

    Private Sub btoConvenioGlobal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoConvenioGlobal.Click
        BuscarConvenios(False)
    End Sub

    Private Sub BtoGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoGuardar.Click
        ''se agrega metodo para la validacion de fechas 
        Dim ResultadoFEchas As Integer

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then

            For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows

                Dim fdesde As Date = RowGrilla.Cells("F_INICIO").Value
                Dim fhasta As Date = RowGrilla.Cells("F_FIN").Value
                Dim Dr As DataRow

                Dr = DtGrilla.Select("ID_SPOT = " & RowGrilla.Cells("ID_SPOT").Value)(0)

                If Not Dr Is Nothing Then

                    'AG 11/05/2015 Arreglo de las modificaciones de ARIEL ==========================
                    ResultadoFEchas = ValidarFechas(fdesde, fhasta)

                    Select Case ResultadoFEchas
                        Case ValidarFecha.MesDistinto
                            MsgBox(MensajeMesDistinto, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                        Case ValidarFecha.AnioDistinto
                            MsgBox(MensajeAnioDistinto, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                        Case ValidarFecha.FInicioMayor
                            MsgBox(MensajeFechaInicioMAYOR, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                        Case ValidarFecha.FFinMenor
                            MsgBox(MensajeFechaFinMENOR, MsgBoxStyle.Information, MensajeTitulo)
                            ControlGuardarSalir = True
                            Exit Sub
                    End Select
                    '================================================================================

                    If (IsDBNull(RowGrilla.Cells("ID_UBICACION").Value) Or RowGrilla.Cells("ID_UBICACION").Value = 0) Or (IsDBNull(RowGrilla.Cells("ID_TIPO_FORMATO").Value) Or RowGrilla.Cells("ID_TIPO_FORMATO").Value = 0) Or (IsDBNull(RowGrilla.Cells("ID_FORMATO").Value) Or RowGrilla.Cells("ID_FORMATO").Value = 0) Or (IsDBNull(RowGrilla.Cells("ID_TIPO_COMPRA").Value) Or RowGrilla.Cells("ID_TIPO_COMPRA").Value = 0) Then
                        MsgBox(MensajeCamposIncompletos, MsgBoxStyle.Exclamation, MensajeTitulo)
                        Return
                    End If
                Else
                    Return
                End If
            Next
        End If

        IgualarDtGrillaConGrillaDatos()
        EjecutarOperacionDB()
        ReCargarGrilla()
        If EliminarRegistros = True Then
            EliminarRegistros = False
        End If
        If ControlDeCambiosDatos = True Then
            ControlDeCambiosDatos = False
            SetearIconoGuardar()
        Else
            SetearIconoGuardar()
        End If
    End Sub

    Private Sub btoSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoSalir.Click
        Me.Close()
    End Sub

#End Region

#End Region

#Region "Funciones y Metodos"

#Region "Metodos Generelaes"

    Private Sub ReCargarGrilla()

        Me.ugPlanificacionInternet.DataSource = DtGrilla
        AliniaTitulosColumnas()
        AliniarDatosCeldas()
        InhabilitarEdicionColumnasXFila()

    End Sub

    Private Sub CargarHojaNueva()

        If Not mListaSoportes Is Nothing AndAlso mListaSoportes.Count > 0 Then
            AgregarSoportesCargaNueva()
            ReCargarGrilla()
        End If

    End Sub

    Private Function ObtenerRegistrosInicial()

        OSpotInternet = New Spots_int

        With OSpotInternet
            .Id_campania = Me.Id_Campania
            .Id_sistema = Me.Id_Sistema
            .Id_ejercicio = Me.Id_Ejercicio
            DtSpot = .ObtenerSpots
        End With

        If DtSpot.Rows.Count = 0 Or DtSpot Is Nothing Or Me.EsCargaNueva = True Then
            DtGrilla = DtSpot.Clone
            CargarHojaNueva()
        ElseIf DtSpot.Rows.Count > 0 Then
            DtGrilla = CargarDescripcionMaestrosHojaExistente(DtSpot)
            DtGrilla = AgregarEstadoFilasPlanExistente(DtGrilla)
        End If

        Me.ugPlanificacionInternet.DataSource = DtGrilla

        RecorrerGrillaActualizarIconosSpotComprados()
        RecorrerGrillaSombrearSpotComprados()

        If DtSpot.Rows.Count = 0 Or DtSpot Is Nothing Or Me.EsCargaNueva = True Then
            If Not Me.ugPlanificacionInternet.DataSource Is Nothing Then
                For Each RowParent As UltraGridRow In Me.ugPlanificacionInternet.Rows
                    SetearIconoEdicion(RowParent.Cells("ID_SPOT").Value, True)
                    'RowParent.Cells("ID_SPOT").Value
                    'SetearIconoEdicion(ugPlanificacionInternet.Rows(0).Cells("ID_SPOT").Value, True)
                Next
            End If
        End If

    End Function

    Private Function AgregarFilaNueva(ByVal DtInicial As DataTable) As DataTable

        Dim FilaNueva As DataRow

        FilaNueva = DtInicial.NewRow
        FilaNueva("OPERACION_FILA") = OperacionFila.Actualizar.ToString
        FilaNueva("OPERACION_DB") = OperacionDB.Nuevo.ToString
        FilaNueva("ID_SPOT") = ObtenerProximoIdSpot(DtGrilla)
        FilaNueva("ID_CAMPANIA") = Me.Id_Campania
        FilaNueva("ID_SISTEMA") = Me.Id_Sistema
        FilaNueva("ID_EJERCICIO") = Me.Id_Ejercicio
        FilaNueva("ID_TARIFA") = 0
        FilaNueva("ID_CONVENIO") = 0
        FilaNueva("ID_PROVEEDOR") = 0
        FilaNueva("PROVEEDOR") = ""
        FilaNueva("ID_TIPO_SOPORTE") = 0
        FilaNueva("TIPO_SOPORTE") = ""
        FilaNueva("ID_SOPORTE") = 0
        FilaNueva("SOPORTE") = ""
        FilaNueva("ID_UBICACION") = 0
        FilaNueva("ID_TIPO_FORMATO") = 0
        FilaNueva("ID_FORMATO") = 0
        FilaNueva("F_INICIO") = Me.FechaInicio
        FilaNueva("F_FIN") = Me.FechaFin
        FilaNueva("ID_TIPO_COMPRA") = 0
        FilaNueva("CANTIDAD_DIAS") = 0
        FilaNueva("CANTIDAD_HORAS") = 0
        FilaNueva("BRUTO") = 0
        FilaNueva("DCTO1") = 0
        FilaNueva("DCTO2") = 0
        FilaNueva("NETO") = 0
        FilaNueva("INVERSION") = 0
        FilaNueva("IMPRESIONES") = 0
        FilaNueva("CLICKS") = 0
        FilaNueva("VIEWS") = 0
        FilaNueva("SHAR") = 0
        FilaNueva("PORSAG") = 0
        FilaNueva("IMPSAG") = 0
        FilaNueva("TOTAL") = 0
        FilaNueva("ID_USUARIO") = Activo.IDUsuarioMMS
        FilaNueva("ESTADO") = System.DBNull.Value

        DtInicial.Rows.Add(FilaNueva)

        Return DtInicial

    End Function

    Private Function AgregarFila(ByVal IdSpot As Integer, ByVal IdTarifa As Integer, ByVal IdConvenio As Integer, ByVal IdProveedor As Integer, ByVal Proveedor As String, ByVal IdTSoporte As Integer, ByVal TipoSoporte As String, ByVal IdSoporte As Integer, ByVal Soporte As String, ByVal IdUbicacion As Integer, ByVal IdTipoFormato As Integer, ByVal IdFormato As Integer, ByVal FInicio As Date, ByVal FFin As Date, ByVal IdTipoCompra As Integer, ByVal CantidadDias As Integer, ByVal CantidadHoras As Integer, ByVal Bruto As Double, ByVal Desc1 As Single, ByVal Desc2 As Single, ByVal Neto As Double, ByVal Inversion As Double, ByVal Impresiones As Integer, ByVal Clicks As Integer, ByVal Views As Integer, ByVal Share As Double, ByVal PorcentajeSag As Single, ByVal PesosSag As Double, ByVal Total As Double, ByVal IdUsuario As Integer, ByVal Ca As Double)

        Dim FilaNueva As DataRow

        FilaNueva = DtGrilla.NewRow()
        FilaNueva("OPERACION_FILA") = OperacionFila.Actualizar.ToString
        FilaNueva("OPERACION_DB") = OperacionDB.Nuevo.ToString
        FilaNueva("ID_SPOT") = ObtenerProximoIdSpot(DtGrilla)
        FilaNueva("ID_CAMPANIA") = Me.Id_Campania
        FilaNueva("ID_SISTEMA") = Me.Id_Sistema
        FilaNueva("ID_EJERCICIO") = Me.Id_Ejercicio
        FilaNueva("ID_TARIFA") = IdTarifa
        FilaNueva("ID_CONVENIO") = IdConvenio
        FilaNueva("ID_PROVEEDOR") = IdProveedor
        FilaNueva("PROVEEDOR") = Proveedor
        FilaNueva("ID_TIPO_SOPORTE") = IdTSoporte
        FilaNueva("TIPO_SOPORTE") = TipoSoporte
        FilaNueva("ID_SOPORTE") = IdSoporte
        FilaNueva("SOPORTE") = Soporte
        FilaNueva("ID_UBICACION") = IdUbicacion
        FilaNueva("ID_TIPO_FORMATO") = IdTipoFormato
        FilaNueva("ID_FORMATO") = IdFormato
        FilaNueva("F_INICIO") = FInicio
        FilaNueva("F_FIN") = FFin
        FilaNueva("ID_TIPO_COMPRA") = IdTipoCompra
        FilaNueva("CANTIDAD_DIAS") = CantidadDias
        FilaNueva("CANTIDAD_HORAS") = CantidadHoras
        FilaNueva("BRUTO") = Bruto
        FilaNueva("DCTO1") = Desc1
        FilaNueva("DCTO2") = Desc2
        FilaNueva("NETO") = Neto
        FilaNueva("INVERSION") = Inversion
        FilaNueva("IMPRESIONES") = Impresiones
        FilaNueva("CLICKS") = Clicks
        FilaNueva("VIEWS") = Views
        FilaNueva("SHAR") = Share
        FilaNueva("PORSAG") = Math.Round(PorcentajeSag, 2)
        FilaNueva("IMPSAG") = PesosSag
        FilaNueva("TOTAL") = Total
        FilaNueva("CA") = Ca
        FilaNueva("ID_USUARIO") = Activo.IDUsuarioMMS
        FilaNueva("ESTADO") = "Fila_Soporte"

        ListaSpotDuplicados.Add(CInt((FilaNueva("ID_SPOT").ToString)))

        DtGrilla.Rows.Add(FilaNueva)

    End Function

    Private Sub CargarDatosCabecera()

        Me.txtNombreUsuario.Text = EspacioBlanco + Activo.Nombre.ToString.ToUpper
        Me.txtApellidoUsuario.Text = EspacioBlanco + Activo.Apellido1.ToString.ToUpper
        Me.txtDesCliente.Text = EspacioBlanco + Activo.Cliente.ToUpper
        Me.txtCampania.Text = EspacioBlanco + ObtenerDescripcion(1)
        Me.txtSistema.Text = EspacioBlanco + ObtenerDescripcion(2)
        Me.txtEjercicio.Text = EspacioBlanco + ObtenerDescripcion(3)
        Me.dtpFecha.Value = Date.Now

    End Sub

    Private Function ObtenerDescripcion(ByVal TipoBusqueda As Integer) As String

        Dim OCampania As New Campaña
        Dim OSistema As New Sistemas
        Dim OEjercicio As New Ejercicios
        Dim Descripcion As String = ""

        Select Case TipoBusqueda
            Case 1

                With OCampania
                    .ID_Campania = Activo.IDCampaña
                    .BuscarPorID()
                    Descripcion = .Descripcion.ToUpper
                End With
            Case 2

                With OSistema
                    .Id_campania = Activo.IDCampaña
                    .Id_sistema = Activo.IDSistema
                    .BuscarPorID()
                    Descripcion = .Descripcion.ToUpper
                End With
            Case 3
                With OEjercicio
                    .Id_campania = Activo.IDCampaña
                    .Id_sistema = Activo.IDSistema
                    .Id_ejercicio = Activo.IDEjercicio
                    .BuscarPorID()
                    Descripcion = .Descripcion.ToUpper
                End With
        End Select


        Return Descripcion

    End Function

    Private Sub InHabilitarControlesCabecera()

        'Inabilito los controles de la Cabecera
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtApellidoUsuario.ReadOnly = True
        Me.txtDesCliente.ReadOnly = True
        Me.txtCampania.ReadOnly = True
        Me.txtSistema.ReadOnly = True
        Me.txtEjercicio.ReadOnly = True
        Me.dtpFecha.ReadOnly = True

        'Color de Fondo de los controles de la Cabecera
        Me.txtNombreUsuario.BackColor = Color.GhostWhite
        Me.txtApellidoUsuario.BackColor = Color.GhostWhite
        Me.txtDesCliente.BackColor = Color.GhostWhite
        Me.txtCampania.BackColor = Color.GhostWhite
        Me.txtSistema.BackColor = Color.GhostWhite
        Me.txtEjercicio.BackColor = Color.GhostWhite
        Me.dtpFecha.Value = Color.GhostWhite

    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub CambiarNombreColumnas(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_PROVEEDOR", "Grupo")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_SOPORTE", "Soporte")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_TIPO_SOPORTE", "Tipo Soporte")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_UBICACION", "Ubicacion")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_TIPO_FORMATO", "Tipo Formato")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_FORMATO", "Formato")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "F_INICIO", "F.Inicio")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "F_FIN", "F.Fin")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_TIPO_COMPRA", "Modalidad Compra")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "CANTIDAD_DIAS", "Cant. Dias")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "CANTIDAD_HORAS", "Cant. Horas")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ID_CONVENIO", "Convenio Aplicado")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "BRUTO", "Costo Unit. Bruto")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "DCTO1", "% Descuento 1")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "DCTO2", "% Descuento 2")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "NETO", "Costo Unit. Neto")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "INVERSION", "Inversion")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "IMPRESIONES", "Impresiones")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "CLICKS", "Clicks")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "VIEWS", "Views")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "PROVEEDOR", "Proveedor")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "SOPORTE", "Soporte")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "TIPO_SOPORTE", "Tipo Soporte")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "ESTADO", "Estado")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "SHAR", "% Share Inversion")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "PORSAG", "% Sag")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "IMPSAG", "$ Sag")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "TOTAL", "Total")
        Listas.CambiarTituloColumna(Me.ugPlanificacionInternet, "CA", "Conversiones/Acciones")

    End Sub

    Private Sub CambiarFormatoColumnasDropDownList(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_UBICACION"))
        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_TIPO_COMPRA"))
        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_TIPO_FORMATO"))
        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_FORMATO"))

    End Sub

    Private Sub CambiarFormatoColumnasDropCalendario(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        AplicarFormatoDropDownCalendar(e.Layout.Bands(0).Columns("F_INICIO"))
        AplicarFormatoDropDownCalendar(e.Layout.Bands(0).Columns("F_FIN"))

    End Sub

    Private Sub CambiarFormatoColumnasMoneda()
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "BRUTO", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "NETO", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "INVERSION", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "IMPSAG", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "TOTAL", Formato.Moneda)

    End Sub

    Private Sub CambiarFormatoColumnasDecimal()
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "DCTO1", Formato.General)
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "DCTO2", Formato.General)
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "PORSAG", Formato.General)
        GrillaFormato.CambiarFormatoColumna(ugPlanificacionInternet, "SHAR", Formato.General)
    End Sub

    Private Sub CambiarFormatoColumnaBotton(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        'AplicarFormatoBotton(e.Layout.Bands(0).Columns("CONFIRMACION"))
    End Sub

    Private Sub CambiarFormatoColumnasNumeral()

        ugPlanificacionInternet.DisplayLayout.Bands(0).Columns("CANTIDAD_DIAS").Style = ColumnStyle.IntegerNonNegative
        ugPlanificacionInternet.DisplayLayout.Bands(0).Columns("CANTIDAD_HORAS").Style = ColumnStyle.IntegerNonNegative
        ugPlanificacionInternet.DisplayLayout.Bands(0).Columns("IMPRESIONES").Style = ColumnStyle.IntegerNonNegative
        ugPlanificacionInternet.DisplayLayout.Bands(0).Columns("CLICKS").Style = ColumnStyle.IntegerNonNegative
        ugPlanificacionInternet.DisplayLayout.Bands(0).Columns("VIEWS").Style = ColumnStyle.IntegerNonNegative
        ugPlanificacionInternet.DisplayLayout.Bands(0).Columns("CA").Style = ColumnStyle.IntegerNonNegative

    End Sub

    Private Sub HabilitarColumnasCargaInicialSegunModalidad()

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
                If RowGrilla.Cells("ID_ORDEN_MMS").Value Is System.DBNull.Value Then  'AG 21/11/2013
                    Select Case RowGrilla.Cells("ID_TIPO_COMPRA").Value
                        Case TipoCompra.CPM
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        Case TipoCompra.Fijo_x_Dia
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                            'LC 07/07/2014 Habilita la edicion de la columna BRUTO e IMPRESIONES
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        Case TipoCompra.Fijo_x_Hora
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                            'LC 07/07/2014 Habilita la edicion de la columna BRUTO e IMPRESIONES
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                        Case TipoCompra.Fijo_Mensual
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        Case TipoCompra.Costo_Paquete
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            'LC 07/07/2014 Habilita la edicion de la columna IMPRESIONES
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        Case TipoCompra.Bonificacion 'AG 06/01/2014
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                        Case TipoCompra.CPA  'AG 06/01/2014
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                            GrillaFormato.HabilitarCelda(RowGrilla.Cells("CA"), Activation.NoEdit)

                    End Select

                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("PROVEEDOR"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("SOPORTE"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("TIPO_SOPORTE"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("TOTAL"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("ESTADO"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_CONVENIO"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("SHAR"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("PORSAG"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPSAG"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("NETO"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_PROVEEDOR"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_SOPORTE"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_TIPO_SOPORTE"), Activation.NoEdit)
                    GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_CONVENIO"), Activation.NoEdit)
                Else
                    InhabilitarFilaSpotsComprado(RowGrilla)
                End If
            Next
        End If
    End Sub

    Private Sub InhabilitarEdicionColumnasXFila()

        Dim Indice As Integer

        If AgregarNuevosSoportes = False Then
            If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
                For Indice = 0 To ListaSpotDuplicados.Count - 1
                    For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
                        If Not ListaSpotDuplicados Is Nothing AndAlso ListaSpotDuplicados.Count > 0 Then
                            If ListaSpotDuplicados(Indice) = RowGrilla.Cells("ID_SPOT").Value Then
                                Select Case RowGrilla.Cells("ID_TIPO_COMPRA").Value
                                    Case TipoCompra.CPM
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                                    Case TipoCompra.Fijo_x_Dia
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO e IMPRESIONES
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                                    Case TipoCompra.Fijo_x_Hora
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO e IMPRESIONES
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                                    Case TipoCompra.Fijo_Mensual
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                                    Case TipoCompra.Costo_Paquete
                                        'LC 07/07/2014 Habilita la edicion de la columna IMPRESIONES
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                                    Case TipoCompra.CPA  'AG 06/01/2014
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                                        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                                End Select

                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("PROVEEDOR"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("SOPORTE"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("TIPO_SOPORTE"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("TOTAL"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("ESTADO"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_CONVENIO"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("SHAR"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("PORSAG"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPSAG"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("NETO"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_PROVEEDOR"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_SOPORTE"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_TIPO_SOPORTE"), Activation.NoEdit)
                                GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_CONVENIO"), Activation.NoEdit)
                            End If
                        End If
                    Next
                Next
            End If

        Else
            'AG 02/12/2013 =========================================================================================
            'GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "BRUTO")
            'GrillaFormato.HabilitarCelda(ugPlanificacionInternet.ActiveRow.Cells("BRUTO"), Activation.AllowEdit)
            '=======================================================================================================

            GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "CLICKS")
            GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "VIEWS")
            'LC 07/07/2014 Habilita la edicion de la columna BRUTO
            'GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "IMPRESIONES")
        End If

        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "PROVEEDOR")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "SOPORTE")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "TIPO_SOPORTE")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "TOTAL")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "ESTADO")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "ID_CONVENIO")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "SHAR")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "PORSAG")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "IMPSAG")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "NETO")

        ListaSpotDuplicados.Clear()

        If AgregarNuevosSoportes = True Then
            AgregarNuevosSoportes = False
        End If
    End Sub

    Private Sub FormatoEdicionColumnasEspecialesDesdeCOMBO(ByVal NombreColumna As String)

        Dim ValorNeto As Double
        Dim ValorDias As Double
        Dim ValorInversion As Double
        Dim Resultado_Multiplicacion As Double
        Dim ValorBruto As Double
        Dim Resultado As Double

        Select Case NombreColumna

            Case "ID_TIPO_COMPRA"
                Select Case ugPlanificacionInternet.ActiveRow.Cells(NombreColumna).Value
                    Case TipoCompra.CPM
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000 'Resultado_Multiplicacion
                        Else
                            Resultado = 0
                        End If

                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = Math.Round(Resultado, 2)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.Fijo_x_Dia
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.Fijo_x_Hora
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.Fijo_Mensual
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.Costo_Paquete
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                        '======================================== Formato Columna CA =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = 0
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                    Case TipoCompra.CPA 'AG 07/01/2014
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000 'Resultado_Multiplicacion
                        Else
                            Resultado = 0
                        End If

                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)

                        '================================== Formato Columna CA ============================================
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = Resultado
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        'ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                End Select
        End Select

    End Sub

    Private Sub FormatoEdicionColumnasEspecialesDesdeCELDA(ByVal NombreColumna As String)

        Dim ValorNeto As Double
        Dim ValorDias As Double
        Dim ValorInversion As Double
        Dim Resultado_Multiplicacion As Double
        Dim ValorBruto As Double
        Dim Resultado As Double

        Select Case NombreColumna
            Case "INVERSION"
                Select Case ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value
                    Case TipoCompra.CPM
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Dia
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Hora
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.Fijo_Mensual
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Costo_Paquete
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.AllowEdit)
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.CPA 'AG 07/01/2014
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000 'Resultado_Multiplicacion
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '================================== Formato Columna CA ============================================
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = Resultado
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                        '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                        'AG 08/01/2014
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        If ValorInversion <= 0 Then
                            ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                            ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                        End If
                End Select
            Case "DCTO1"
                Select Case ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value
                    Case TipoCompra.CPM
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Dia
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Hora
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.Fijo_Mensual
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Costo_Paquete
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.AllowEdit)
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.CPA 'AG 07/01/2014
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000 'Resultado_Multiplicacion
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '================================== Formato Columna CA ============================================
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = Resultado
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                End Select
            Case "DCTO2"
                Select Case ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value
                    Case TipoCompra.CPM
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Dia
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Hora
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.Fijo_Mensual
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Costo_Paquete
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.AllowEdit)
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.CPA 'AG 07/01/2014
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000 'Resultado_Multiplicacion
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '================================== Formato Columna CA ============================================
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = Resultado
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                End Select
            Case "BRUTO"
                Select Case ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value
                    Case TipoCompra.CPM
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Dia
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Hora
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.Fijo_Mensual
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Costo_Paquete
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.AllowEdit)
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.CPA 'AG 07/01/2014
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000 'Resultado_Multiplicacion
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                        '================================== Formato Columna CA ============================================
                        'ValorBruto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CA").Value = Resultado
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CA"), Activation.NoEdit)
                End Select
                '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                'AG 08/01/2014
                ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                If ValorInversion <= 0 Then
                    ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                    ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                End If
                '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
            Case "CANTIDAD_DIAS"
                Select Case ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value
                    Case TipoCompra.CPM
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Dia
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Hora
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.Fijo_Mensual
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Costo_Paquete
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.AllowEdit)
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                End Select
                '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                'AG 08/01/2014
                ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                If ValorInversion <= 0 Then
                    ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                    ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                End If
            Case "CANTIDAD_HORAS"
                Select Case ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value
                    Case TipoCompra.CPM
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.NoEdit)
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto * 1000
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = Math.Round(Resultado, 2)
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPC_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        '======================================== Formato Columna VIEWS ==============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.CPV_Fijo_Dinamico_Estimado
                        '===================================== Formato Columna BRUTO ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS ==============================================
                        ValorNeto = 0
                        ValorDias = 0
                        ValorInversion = 0
                        Resultado_Multiplicacion = 0
                        Resultado = 0
                        ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        If ValorInversion > 0 And ValorNeto > 0 Then
                            Resultado = ValorInversion / ValorNeto
                        Else
                            Resultado = 0
                        End If
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = Math.Round(Resultado, 2)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Dia
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Fijo_x_Hora
                        '===================================== Formato Columna BRUTO ============================================
                        'LC 07/07/2014 Habilita la edicion de la columna BRUTO
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '===================================== Formato Columna INVERSION ============================================
                        ValorNeto = 0
                        ValorDias = 0
                        Resultado = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        ValorNeto = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("NETO").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("NETO").Value)
                        ValorDias = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value)
                        Resultado = ValorNeto * ValorDias
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = Math.Round(Resultado, 2)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                    Case TipoCompra.Fijo_Mensual
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Costo_Paquete
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.NoEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = ugPlanificacionInternet.ActiveRow.Cells("NETO").Value
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("IMPRESIONES").Value = 0
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("CLICKS").Value = 0
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.NoEdit)
                        ugPlanificacionInternet.ActiveRow.Cells("VIEWS").Value = 0
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_DIAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.NoEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        ugPlanificacionInternet.ActiveRow.Cells("CANTIDAD_HORAS").Value = 0
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.NoEdit)
                    Case TipoCompra.Bonificacion 'AG 06/01/2014
                        '===================================== Formato Columna INVERSION ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("INVERSION"), Activation.AllowEdit)
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("BRUTO"), Activation.AllowEdit)
                        '=================================== Formato Columna IMPRESIONES ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("IMPRESIONES"), Activation.AllowEdit)
                        '======================================== Formato Columna CLICKS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CLICKS"), Activation.AllowEdit)
                        '======================================== Formato Columna VIEWS =============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("VIEWS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x DIAS ============================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_DIAS"), Activation.AllowEdit)
                        '================================== Formato Columna FIJOS x HORAS ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                        '================================== Formato Columna BONIFICACION ===========================================
                        GrillaFormato.HabilitarCelda(Me.ugPlanificacionInternet.Rows(ugPlanificacionInternet.ActiveRow.Index).Cells("CANTIDAD_HORAS"), Activation.AllowEdit)
                End Select
                '=============================================== Valido los Valores del TOTAL por FILA y Importe del SAG Pongo en ( CERO )==================================
                'AG 08/01/2014
                ValorInversion = IIf(IsDBNull(ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value), 0, ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value)
                If ValorInversion <= 0 Then
                    ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = 0
                    ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = 0
                End If
        End Select
    End Sub

    Private Sub OcultarColumnas()
        Listas.OcultarColumnas(Me.ugPlanificacionInternet, "OPERACION_FILA", "OPERACION_DB", "ID_SPOT", "Id_Campania", "Id_Sistema", "Id_Ejercicio", "ID_PROVEEDOR", "ID_SOPORTE", "ID_USUARIO", "ID_TARIFA", "ID_TIPO_SOPORTE", "ID_ORDEN_MMS")
    End Sub

    Private Sub AliniaTitulosColumnas()

        With ugPlanificacionInternet.DisplayLayout.Bands(0)
            .Columns("PROVEEDOR").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SOPORTE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_TIPO_SOPORTE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_UBICACION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_TIPO_FORMATO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_FORMATO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("F_INICIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("F_FIN").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_TIPO_COMPRA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CANTIDAD_DIAS").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CANTIDAD_HORAS").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_CONVENIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("BRUTO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DCTO1").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DCTO2").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("NETO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("INVERSION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("IMPRESIONES").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CLICKS").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("VIEWS").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SHAR").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PORSAG").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("IMPSAG").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TOTAL").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ESTADO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PROVEEDOR").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SOPORTE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TIPO_SOPORTE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With
    End Sub

    Private Sub AliniarDatosCeldas()

        With ugPlanificacionInternet.DisplayLayout.Bands(0)
            .Columns("PROVEEDOR").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("SOPORTE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_TIPO_SOPORTE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_UBICACION").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_TIPO_FORMATO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_FORMATO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("F_INICIO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("F_FIN").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_TIPO_COMPRA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("CANTIDAD_DIAS").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("CANTIDAD_HORAS").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_CONVENIO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("BRUTO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DCTO1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DCTO2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("NETO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("INVERSION").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("IMPRESIONES").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("CLICKS").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("VIEWS").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("SHAR").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("PORSAG").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("IMPSAG").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("TOTAL").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ESTADO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PROVEEDOR").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("SOPORTE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("TIPO_SOPORTE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("ESTADO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        End With

    End Sub

    Private Sub SetearIconoEdicionFilaNuevaSoporte()
        For Each RowParent As UltraGridRow In Me.ugPlanificacionInternet.Rows
            If Not RowParent.Cells("ESTADO").Value Is System.DBNull.Value Then
                If RowParent.Cells("ESTADO").Value = "Fila_Soporte" Then
                    RowParent.Cells("ESTADO").Value = ""
                    RowParent.Cells("ESTADO").Appearance.Image = ImageList.Images(0)
                    RowParent.Cells("ESTADO").Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    Me.BtoGuardar.Image = Image.FromFile(Application.StartupPath & "\Comun\Imagenes\EdicionGuardar.ico")
                End If
            End If
        Next
    End Sub

    Private Sub MostrarPrimeraFila()
        Me.ugPlanificacionInternet.Rows(0).Activate()
    End Sub

    Private Sub SetearIconoEdicion(ByVal pIdSpot As Integer, ByVal pMostrar As Boolean)

        For Each RowParent As UltraGridRow In Me.ugPlanificacionInternet.Rows
            If RowParent.Cells("ID_SPOT").Value = pIdSpot Then
                If pMostrar Then
                    RowParent.Cells("ESTADO").Value = ""
                    RowParent.Cells("ESTADO").Appearance.Image = ImageList.Images(0)
                    RowParent.Cells("ESTADO").Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    Me.BtoGuardar.Image = Image.FromFile(Application.StartupPath & "\Comun\Imagenes\EdicionGuardar.ico")
                Else
                    RowParent.Cells("ESTADO").Appearance.Image = Nothing
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub SetearIconoConfirmacion(ByVal pIdSpot As Integer, ByVal pMostrar As Boolean)

        For Each RowParent As UltraGridRow In Me.ugPlanificacionInternet.Rows
            If RowParent.Cells("ID_SPOT").Value = pIdSpot Then
                If pMostrar Then
                    RowParent.Cells("ESTADO").Appearance.Image = ImageList.Images(1)
                    RowParent.Cells("ESTADO").Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    Me.BtoGuardar.Image = Image.FromFile(Application.StartupPath & "\Comun\Imagenes\Guardar.ico")
                Else
                    RowParent.Cells("ESTADO").Appearance.Image = Nothing
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub SetearIconoGuardar()
        'If EliminarRegistros = True Then
        Me.BtoGuardar.Image = Image.FromFile(Application.StartupPath & "\Comun\Imagenes\Guardar.ico")
        EliminarRegistros = False
        'End If
    End Sub

    Private Sub SetearIconoGuardarEditar()
        If EliminarRegistros = True Then
            Me.BtoGuardar.Image = Image.FromFile(Application.StartupPath & "\Comun\Imagenes\EdicionGuardar.ico")
            EliminarRegistros = False
        End If
    End Sub

    Private Function RecorrerGrillaActualizarIconos(ByVal IdSpot As Integer) As DataTable

        Dim Dr As DataRow
        Dr = DtGrilla.Select("ID_SPOT = " & IdSpot)(0)

        If Not Dr Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
                If Dr("ID_ORDEN_MMS") Is System.DBNull.Value Then
                    If RowGrilla.Cells("ID_SPOT").Value = Dr("ID_SPOT") Then
                        SetearIconoConfirmacion(CInt(RowGrilla.Cells("ID_SPOT").Value), True)
                        Exit For
                    End If
                End If
            Next
        End If
        Return DtGrilla

    End Function

    Private Function RecorrerGrillaActualizarIconosSpotComprados() As DataTable

        For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
            Dim Dr As DataRow
            Dr = DtGrilla.Select("ID_SPOT = " & RowGrilla.Cells("ID_SPOT").Value)(0)
            If Not Dr Is Nothing Then
                If Not RowGrilla.Cells("ID_ORDEN_MMS").Value Is System.DBNull.Value Then
                    RowGrilla.Cells("ESTADO").Appearance.Image = ImageList.Images(4)
                    RowGrilla.Cells("ESTADO").Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    InhabilitarFilaSpotsComprado(RowGrilla)
                End If
            End If
        Next

    End Function

    'LC 29/05/2014 Actualizar los Share al abrir la hoja digital
    Private Function RecorrerGrillaActualizarShare() As DataTable
        Dim InversionTotal As Double
        Dim DtTemporal As New DataTable
        Dim Resultado As Double
        Dim InversionFila As Double
        Dim Dr As DataRow

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
            DtTemporal = ugPlanificacionInternet.DataSource

            If DtTemporal.Rows.Count > 0 Then
                InversionTotal = DtTemporal.Compute("sum(INVERSION)", "")
            End If
            For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
                InversionFila = 0
                If RowGrilla.Cells("INVERSION").Value Is System.DBNull.Value Then
                    InversionFila = 0
                Else
                    InversionFila = RowGrilla.Cells("INVERSION").Value
                End If
                If InversionFila > 0 And InversionTotal > 0 Then
                    Resultado = Math.Round(InversionFila / InversionTotal * 100, 2)
                Else
                    Resultado = 0
                End If
                If Resultado <> RowGrilla.Cells("SHAR").Value Then
                    RowGrilla.Cells("SHAR").Value = Resultado
                    RowGrilla.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
                    RowGrilla.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                    Me.BtoGuardar.Image = Image.FromFile(Application.StartupPath & "\Comun\Imagenes\EdicionGuardar.ico")
                End If
            Next
        End If
    End Function

    Private Sub InhabilitarFilaSpotsComprado(ByVal RowGrilla As UltraGridRow)

        GrillaFormato.HabilitarCelda(RowGrilla.Cells("PROVEEDOR"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_SOPORTE"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("SOPORTE"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_TIPO_SOPORTE"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("TIPO_SOPORTE"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_UBICACION"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_TIPO_FORMATO"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_FORMATO"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("F_INICIO"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("F_FIN"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_TIPO_COMPRA"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("BRUTO"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("DCTO1"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("DCTO2"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("NETO"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("INVERSION"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPRESIONES"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CLICKS"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("VIEWS"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("SHAR"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("PORSAG"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("IMPSAG"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("TOTAL"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_CONVENIO"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_DIAS"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CANTIDAD_HORAS"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ESTADO"), Activation.NoEdit)
        'AN 08/04/2016 Si el spot esta comprado, inhabilito TODAS las columnas
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("CA"), Activation.NoEdit)

    End Sub

    Private Function RecorrerGrillaSombrearSpotComprados() As DataTable

        For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
            Dim Dr As DataRow
            Dr = DtGrilla.Select("ID_SPOT = " & RowGrilla.Cells("ID_SPOT").Value)(0)
            If Not Dr Is Nothing Then
                If Not RowGrilla.Cells("ID_ORDEN_MMS").Value Is System.DBNull.Value Then
                    RowGrilla.Appearance.BackColor = Color.Cornsilk
                End If
            End If
        Next

    End Function

#End Region

#Region "Metodos Busqueda datos Combos"

    Private Function ObtenerTipoFormato() As ValueList

        Dim DtColocaciones As New DataTable
        OColocaciones = New Colocaciones
        vlistTipoFormato = New ValueList

        OColocaciones.Id_Medio = Activo.Medios.Internet
        DtColocaciones = OColocaciones.ObtenerColocaciones
        vlistTipoFormato.ValueListItems.Add("0", "--")

        If Not DtColocaciones Is Nothing Then
            For Each RowColocaciones As DataRow In DtColocaciones.Rows
                vlistTipoFormato.ValueListItems.Add(RowColocaciones("ID_COLOCACION"), RowColocaciones("DESCRIPCION"))
            Next
        End If

        Return vlistTipoFormato

    End Function

    Private Function ObtenerFormatos() As ValueList

        Dim DtFormatos As New DataTable
        OFormatos = New Formatos
        vlistFormatos = New ValueList

        OFormatos.Id_Medio = Activo.Medios.Internet
        DtFormatos = OFormatos.ObtenerFormatos
        vlistFormatos.ValueListItems.Add(0, "--")

        If Not DtFormatos Is Nothing Then
            For Each RowFormato As DataRow In DtFormatos.Rows
                vlistFormatos.ValueListItems.Add(RowFormato("ID_ANUNCIO"), RowFormato("DESCRIPCION"))
            Next
        End If

        Return vlistFormatos

    End Function

    Private Function ObtenerSecciones() As DataTable

        Dim OMaestro As New Maestros

        If Activo.DTSeccionesInternetCache Is Nothing Then
            Activo.DTSeccionesInternetCache = OMaestro.seccionesObtener(Activo.Medios.Internet)
        End If

        Return Activo.DTSeccionesInternetCache

    End Function

    Private Function ObtenerModalidadCompra() As ValueList

        Dim DtModalidadCompras As New DataTable
        OTarifaInternet = New Tarifas_Internet
        vlistModalidadCompra = New ValueList

        DtModalidadCompras = OTarifaInternet.TraerModalidadCompra()
        vlistModalidadCompra.ValueListItems.Add(0, "--")

        If Not DtModalidadCompras Is Nothing Then
            For Each RowModalidadCompras As DataRow In DtModalidadCompras.Rows
                vlistModalidadCompra.ValueListItems.Add(RowModalidadCompras("ID_TIPO_COMPRA"), RowModalidadCompras("DESCRIPCION"))
            Next
        End If

        Return vlistModalidadCompra

    End Function

    Private Function ObtenerUbicaciones() As ValueList

        Dim DtUbicaciones As DataTable
        Dim _maestro As New Maestros

        vlistUbicacion = New ValueList

        DtUbicaciones = _maestro.seccionesObtener(Activo.Medios.Internet)

        vlistUbicacion.ValueListItems.Add(0, "--")

        If Not DtUbicaciones Is Nothing Then
            For Each Seccion As DataRow In DtUbicaciones.Rows
                vlistUbicacion.ValueListItems.Add(Seccion("id_Seccion"), Seccion("Descripcion"))
            Next
        End If

        Return vlistUbicacion

    End Function

    Private Function ObtenerSoportes() As ValueList

        Dim Sop As New Soportes
        Dim dtSoportes As DataTable

        vlistSoporte = New ValueList

        Sop.Id_medio = Activo.Medios.Internet
        Sop.Id_tipo_soporte = mIdTipoSoporte
        dtSoportes = Sop.ObtenerSoportes()

        vlistSoporte.ValueListItems.Add(0, "--")
        If Not dtSoportes Is Nothing Then
            For Each Soporte As DataRow In dtSoportes.Rows
                vlistSoporte.ValueListItems.Add(Soporte("Id_Soporte"), Soporte("Descripcion"))
            Next
        End If

        Return vlistSoporte

    End Function

#End Region

#Region "Metodos Especiales"

    Private Sub AplicarFormatoDropDownList(ByRef pColumna As UltraGridColumn)

        Dim Lista As ValueList

        Select Case pColumna.Key
            Case "ID_TIPO_COMPRA"
                Lista = ObtenerModalidadCompra()
            Case "ID_TIPO_FORMATO"
                Lista = ObtenerTipoFormato()
            Case "ID_FORMATO"
                Lista = ObtenerFormatos()
            Case "ID_UBICACION"
                Lista = ObtenerUbicaciones()
        End Select

        With pColumna
            .ValueList = Lista
            .Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            .ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            .Width = 140
        End With

    End Sub

    Private Sub AplicarFormatoDropDownCalendar(ByRef pColumna As UltraGridColumn)

        With pColumna
            .Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar
            .ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            .Width = 130
        End With

    End Sub

    Private Sub AplicarFormatoBotton(ByRef pColumna As UltraGridColumn)

        With pColumna
            .ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Style = ColumnStyle.Button
            .CellAppearance.BackColor = System.Drawing.Color.DarkGray
            .CellAppearance.ForeColor = System.Drawing.Color.White
            .Header.Caption = "Confirmar"
            .Width = 95
        End With

    End Sub

    Private Sub ExportarExcel()

        SaveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            Dim Excel As New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
            Try
                Excel.Export(ugPrinter, SaveFileDialog.FileName)
                Mensaje("El archivo se grabó con éxito.", TipoMensaje.Informacion)
            Catch ioex As IO.IOException
                Mensaje(ioex.Message, TipoMensaje.DeError)
            End Try
        End If

    End Sub

    Private Sub Imprimir()

        Dim upp As New UltraGridPrintDocument
        Dim ultraprintpreview As New UltraPrintPreviewDialog

        upp.Grid = ugPrinter
        upp.FitWidthToPages = 1
        upp.Header.Appearance.ImageHAlign = HAlign.Left
        upp.Header.Appearance.ImageVAlign = VAlign.Default
        upp.Header.Appearance.FontData.SizeInPoints = 9
        upp.Header.BorderStyle = UIElementBorderStyle.None
        upp.Footer.TextRight = "Pagina <#>."
        upp.Footer.Height = 100
        upp.Footer.Appearance.FontData.SizeInPoints = 9
        upp.Footer.Appearance.TextHAlign = HAlign.Left
        upp.Footer.BorderStyle = UIElementBorderStyle.None
        upp.Footer.Appearance.FontData.Italic = DefaultableBoolean.True
        upp.PageBody.BorderStyle = UIElementBorderStyle.None
        upp.Page.BorderStyle = UIElementBorderStyle.None
        upp.DefaultPageSettings.Landscape = True
        upp.DefaultPageSettings.Margins.Bottom = 10
        upp.DefaultPageSettings.Margins.Left = 10
        upp.DefaultPageSettings.Margins.Right = 10
        upp.DefaultPageSettings.Margins.Top = 10
        upp.DocumentName = "PLANIFICACION - DIGITAL"

        With ultraprintpreview
            .Document = upp
            .AutoGeneratePreview = True
            .DisplayPrintStatus = True
            .DisplayPreviewStatus = True
            .MaximumPreviewPages = 50
            .PreviewMouseAction = PreviewMouseAction.DynamicZoom
            .PreviewSettings.ScrollMode = UltraWinScrollBar.ScrollMode.Immediate
            .PreviewSettings.ScrollTipStyle = UltraWinScrollBar.ScrollTipStyle.Show
            .ThumbnailSettings.PageNumberDisplayStyle = PageNumberDisplayStyle.LeftOfRow
            .ThumbnailSettings.BorderStyle = UIElementBorderStyle.InsetSoft
            .StatusBarVisible = True
            .Style = UltraWinToolbars.ToolbarStyle.VisualStudio2005
            .ThumbnailAreaVisible = True
            .ThumbnailCurrentPreviewPageAppearance.BackColor = Color.Yellow
            .ThumbnailCurrentPreviewPageNumberAppearance.ForeColor = Color.Red
            .ThumbnailViewBoxAppearance.BackColor = Color.Aqua
            .ThumbnailViewBoxAppearance.BackColorAlpha = Alpha.UseAlphaLevel
            .ThumbnailViewBoxAppearance.AlphaLevel = 80
            .ThumbnailViewBoxDisplayStyle = ViewBoxDisplayStyle.AllVisiblePreviewPages
            .ThumbnailViewBoxDragMode = ViewBoxDragMode.RestrictWithinPage
            .UseAntiAlias = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ExportarImprimir(Optional ByVal pImprimir As Boolean = True)

        Dim DatosImprimir As New DataTable

        AgregarColumnasImpresion(DatosImprimir)
        CargarDatoImpresion(DatosImprimir)

        ugPrinter.DataSource = DatosImprimir
        ugPrinter.DataBind()

        CambiarNombreColumnasImpresion()
        AplicarFormatosColumnas()

        If pImprimir Then
            Call Imprimir()
        Else
            Call ExportarExcel()
        End If
    End Sub

    Private Sub AgregarColumnasImpresion(ByRef pDatosImprimir As DataTable)

        With pDatosImprimir.Columns
            .Add("PROVEEDOR", GetType(String))
            .Add("TIPO_SOPORTE", GetType(String))
            .Add("SOPORTE", GetType(String))
            .Add("UBICACION", GetType(String))
            .Add("TIPO_FORMATO", GetType(String))
            .Add("FORMATO", GetType(String))
            .Add("F_INICIO", GetType(String))
            .Add("F_FIN", GetType(String))
            .Add("TIPO_COMPRA", GetType(String))
            .Add("CANTIDAD_DIAS", GetType(Integer))
            .Add("CANTIDAD_HORAS", GetType(Integer))
            .Add("BRUTO", GetType(Double))
            .Add("DCTO1", GetType(Double))
            .Add("DCTO2", GetType(Double))
            .Add("NETO", GetType(Double))
            .Add("INVERSION", GetType(Double))
            .Add("IMPRESIONES", GetType(Integer))
            .Add("CLICKS", GetType(Integer))
            .Add("VIEWS", GetType(Integer))
            .Add("SHAR", GetType(Double))
            .Add("PORSAG", GetType(Double))
            .Add("IMPSAG", GetType(Double))
            .Add("TOTAL", GetType(Double))
        End With

    End Sub

    Private Sub CargarDatoImpresion(ByRef pDatosImprimir As DataTable)

        Dim DatoImprimir As DataRow

        For Each RGrilla As DataRow In Me.DtGrilla.Rows
            DatoImprimir = pDatosImprimir.NewRow
            DatoImprimir("PROVEEDOR") = RGrilla("PROVEEDOR")
            DatoImprimir("TIPO_SOPORTE") = RGrilla("TIPO_SOPORTE")
            DatoImprimir("SOPORTE") = RGrilla("SOPORTE")
            DatoImprimir("UBICACION") = "FALTA"
            DatoImprimir("TIPO_FORMATO") = ObtenerDescripcion("ID_TIPO_FORMATO", RGrilla("ID_TIPO_FORMATO"))
            DatoImprimir("FORMATO") = ObtenerDescripcion("ID_FORMATO", RGrilla("ID_FORMATO"))
            DatoImprimir("F_INICIO") = RGrilla("F_INICIO")
            DatoImprimir("F_FIN") = RGrilla("F_FIN")
            DatoImprimir("TIPO_COMPRA") = ObtenerDescripcion("ID_TIPO_COMPRA", RGrilla("ID_TIPO_COMPRA"))
            DatoImprimir("CANTIDAD_DIAS") = RGrilla("CANTIDAD_DIAS")
            DatoImprimir("CANTIDAD_HORAS") = RGrilla("CANTIDAD_HORAS")
            DatoImprimir("BRUTO") = RGrilla("BRUTO")
            DatoImprimir("DCTO1") = RGrilla("DCTO1")
            DatoImprimir("DCTO2") = RGrilla("DCTO2")
            DatoImprimir("NETO") = RGrilla("NETO")
            DatoImprimir("INVERSION") = RGrilla("INVERSION")
            DatoImprimir("IMPRESIONES") = RGrilla("IMPRESIONES")
            DatoImprimir("CLICKS") = RGrilla("CLICKS")
            DatoImprimir("VIEWS") = RGrilla("VIEWS")
            DatoImprimir("SHAR") = RGrilla("SHAR")
            DatoImprimir("PORSAG") = RGrilla("PORSAG")
            DatoImprimir("IMPSAG") = RGrilla("IMPSAG")
            DatoImprimir("TOTAL") = RGrilla("TOTAL")
            pDatosImprimir.Rows.Add(DatoImprimir)
        Next

    End Sub

    Private Sub CambiarNombreColumnasImpresion()

        ugPrinter.DisplayLayout.Override.HeaderAppearance.FontData.Bold = DefaultableBoolean.True

        Listas.CambiarTituloColumna(Me.ugPrinter, "PROVEEDOR", "Grupo")
        Listas.CambiarTituloColumna(Me.ugPrinter, "TIPO_SOPORTE", "Tipo Soporte")
        Listas.CambiarTituloColumna(Me.ugPrinter, "SOPORTE", "Soporte")
        Listas.CambiarTituloColumna(Me.ugPrinter, "UBICACION", "Ubicacion")
        Listas.CambiarTituloColumna(Me.ugPrinter, "TIPO_FORMATO", "Tipo Formato")
        Listas.CambiarTituloColumna(Me.ugPrinter, "FORMATO", "Formato")
        Listas.CambiarTituloColumna(Me.ugPrinter, "F_INICIO", "F.Inicio Vigencia")
        Listas.CambiarTituloColumna(Me.ugPrinter, "F_FIN", "F.Fin Vigencia")
        Listas.CambiarTituloColumna(Me.ugPrinter, "TIPO_COMPRA", "Modalidad Compra")
        Listas.CambiarTituloColumna(Me.ugPrinter, "CANTIDAD_DIAS", "Cant. Dias")
        Listas.CambiarTituloColumna(Me.ugPrinter, "CANTIDAD_HORAS", "Cant. Horas")
        Listas.CambiarTituloColumna(Me.ugPrinter, "BRUTO", "Costo Unit. Bruto")
        Listas.CambiarTituloColumna(Me.ugPrinter, "DCTO1", "% Descuento 1")
        Listas.CambiarTituloColumna(Me.ugPrinter, "DCTO2", "% Descuento 2")
        Listas.CambiarTituloColumna(Me.ugPrinter, "NETO", "Costo Unit. Neto")
        Listas.CambiarTituloColumna(Me.ugPrinter, "INVERSION", "Inversion")
        Listas.CambiarTituloColumna(Me.ugPrinter, "IMPRESIONES", "Impresiones")
        Listas.CambiarTituloColumna(Me.ugPrinter, "CLICKS", "Clicks")
        Listas.CambiarTituloColumna(Me.ugPrinter, "VIEWS", "Views")
        Listas.CambiarTituloColumna(Me.ugPrinter, "SHAR", "Share Inversion")
        Listas.CambiarTituloColumna(Me.ugPrinter, "PORSAG", "% Sag")
        Listas.CambiarTituloColumna(Me.ugPrinter, "IMPSAG", "$ Sag")
        Listas.CambiarTituloColumna(Me.ugPrinter, "TOTAL", "Total")

    End Sub

    Private Sub AplicarFormatosColumnas()

        AplicarFormatoCurrency(ugPrinter.DisplayLayout.Bands(0).Columns("Bruto"))
        AplicarFormatoCurrency(ugPrinter.DisplayLayout.Bands(0).Columns("Neto"))
        AplicarSumatoria(ugPrinter, ugPrinter.DisplayLayout.Bands(0))
        AplicarFormatoColumnaSize(ugPrinter.DisplayLayout.Bands(0))

    End Sub

    Private Sub AplicarFormatoColumnaSize(ByRef pBanda As UltraGridBand)

        For Each Columna As UltraGridColumn In pBanda.Columns
            If Columna.CalculateAutoResizeWidth(PerformAutoSizeType.AllRowsInBand, False) > Columna.Width Then
                Columna.Width = Columna.CalculateAutoResizeWidth(PerformAutoSizeType.AllRowsInBand, False) + 20
            End If
        Next

    End Sub

    Private Sub AplicarSumatoria(ByVal pGrid As UltraGrid, ByVal pBand As UltraGridBand)

        If pBand.Summaries.Count = 0 Then
            pBand.Summaries.Add(SummaryType.Sum, pBand.Columns("Total"), SummaryPosition.UseSummaryPositionColumn).DisplayFormat = "{0:#####.00}"
            pGrid.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
            pGrid.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
            pGrid.DisplayLayout.Override.SummaryDisplayArea = SummaryDisplayAreas.Bottom
        End If
    End Sub

    Private Sub AplicarFormatoColumnaTotal(ByVal pColumna As UltraGridColumn)
        pColumna.CellAppearance.BackColor = ColorColTotales
    End Sub

    Private Sub AplicarFormatoCurrency(ByRef pColumna As UltraGridColumn)

        pColumna.PromptChar = String.Empty
        pColumna.MaskInput = "$ nn,nnn,nnn.nn"
        pColumna.MaskDisplayMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.MaskDataMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.MaskClipMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.CellAppearance.TextHAlign = HAlign.Right

    End Sub

    Private Function ObtenerDescripcion(ByVal pNombreColumna As String, ByVal pValue As String) As String

        Dim Descripcion As String

        Select Case pNombreColumna
            Case "ID_TIPO_FORMATO"
                If Not vlistTipoFormato.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = vlistTipoFormato.FindByDataValue(pValue).DisplayText
                End If
            Case "ID_FORMATO"
                If Not vlistFormatos.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = vlistFormatos.FindByDataValue(pValue).DisplayText
                End If
            Case "ID_TIPO_COMPRA"
                If Not vlistModalidadCompra.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = vlistModalidadCompra.FindByDataValue(pValue).DisplayText
                End If
        End Select

        Return Descripcion

    End Function

    Private Sub ConfigurarResolucionPantalla()

        Dim Ancho As String = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width.ToString()
        Dim Alto As String = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height.ToString()
        Dim Tamaño As String = Ancho + "x" + Alto

        Select Case Tamaño
            Case "800x600"
                CambiarResolucion(Me, Ancho, Alto)
            Case "1024x600"
                CambiarResolucion(Me, Ancho, Alto)
            Case "1024x768"
                CambiarResolucion(Me, Ancho, Alto)
            Case "1920x1080"
                CambiarResolucion(Me, Ancho, Alto)
        End Select
    End Sub

    Private Sub CambiarResolucion(ByVal Formulario As System.Windows.Forms.Form, ByVal Ancho As Double, ByVal Alto As Double)

        Formulario.AutoScaleDimensions = New System.Drawing.SizeF(Ancho, Alto)
        Formulario.PerformAutoScale()

    End Sub

    Private Sub ControlCeldasVacias(ByVal ColumnaNombre As String)

        If EliminarRegistros = False Then
            Select Case ColumnaNombre
                Case "NETO"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "CANTIDAD_DIAS"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "CANTIDAD_HORAS"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "DCTO1"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "DCTO2"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "INVERSION"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "IMPRESIONES"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "CLICKS"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "VIEWS"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "SHAR"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "PORSAG"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
                Case "IMPSAG"
                    If Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value Is System.DBNull.Value Then
                        Me.ugPlanificacionInternet.ActiveRow.Cells(ColumnaNombre).Value = 0
                    End If
            End Select
        End If
    End Sub

#End Region

#Region "Metodos Convenios y Tarifas"

    Private Function AplicarTarifasHoja(ByVal IdCliente As Integer, ByVal IdSoporte As Integer, ByVal IdUbicacion As Integer, ByVal IdTipoCompra As Integer, ByVal IdTipoFormato As Integer, ByVal IdFormato As Integer, ByVal FInico As Date, ByVal FFin As Date) As Integer

        Dim DtTarifas As New DataTable
        Dim IndiceResultado As Integer

        OTarifaInternet = New Tarifas_Internet

        With OTarifaInternet
            .Id_cliente = IdCliente
            .Id_soporte = IdSoporte
            .pIdUbicacion = IdUbicacion
            .Id_Tipo_Compra = IdTipoCompra
            .Id_Tipo_Formato = IdTipoFormato
            .Id_Formato = IdFormato
            .F_inicio = FInico
            .F_fin = FFin
            DtTarifas = .TraerTarifasPlanificacion
        End With

        If DtTarifas.Rows.Count > 0 Then
            Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Activated = True
            Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value = DtTarifas.Rows(0)("BRUTO")
            Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Activated = False
            Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TARIFA").Value = DtTarifas.Rows(0)("ID_TARIFA")
            Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
            If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
            End If
            IndiceResultado = ResultadoOperacion.DatosOk
        Else
            Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Activated = True
            Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value = 0
            Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Activated = False
            Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TARIFA").Value = 0  'AG
            Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
            If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
            End If
            IndiceResultado = ResultadoOperacion.TarifasNoExisten
        End If

        Return IndiceResultado

    End Function

    Private Sub BuscarConvenios(Optional ByVal pPuntual As Boolean = True)

        Dim Soportes As New ArrayList
        Dim CantidadSeleccionada As Integer
        Dim Seleccionadas As New ArrayList

        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        If pPuntual Then

            CantidadSeleccionada = ugPlanificacionInternet.Selected.Rows.Count
            If CantidadSeleccionada = 0 Then
                MsgBox(MensajeSeleccion, MsgBoxStyle.Information, MensajeTitulo)
                Exit Sub
            End If

            For IndexSeleccionada As Integer = 0 To CantidadSeleccionada - 1
                If ugPlanificacionInternet.Selected.Rows(IndexSeleccionada).Band.Index = 0 Then
                    If Not Seleccionadas.Contains(ugPlanificacionInternet.Selected.Rows(IndexSeleccionada).ListIndex) Then
                        Seleccionadas.Add(ugPlanificacionInternet.Selected.Rows(IndexSeleccionada).ListIndex)
                    End If
                End If
            Next
            If Not Seleccionadas Is Nothing AndAlso Seleccionadas.Count > 0 Then
                For Index As Integer = 0 To Seleccionadas.Count - 1
                    For Each RowParent As UltraGridRow In ugPlanificacionInternet.Rows
                        If RowParent.ListIndex = Seleccionadas(Index) Then
                            RowParent.Selected = True
                        End If
                    Next
                Next
            End If
            For Each RowSeleccionada As UltraGridRow In ugPlanificacionInternet.Selected.Rows
                If Not Soportes.Contains(RowSeleccionada.Cells("ID_SOPORTE").Value) Then
                    Soportes.Add(RowSeleccionada.Cells("ID_SOPORTE").Value)
                End If
            Next
        Else
            For Each RowParent As UltraGridRow In ugPlanificacionInternet.Rows
                If Not Soportes.Contains(RowParent.Cells("ID_SOPORTE").Value) Then
                    Soportes.Add(RowParent.Cells("ID_SOPORTE").Value)
                End If
            Next
        End If

        ConveniosMedios.FechaDesde = Me.FechaInicio
        ConveniosMedios.FechaHasta = Me.FechaFin
        ConveniosMedios.IdCliente = Me.IdCliente
        ConveniosMedios.IdMedio = Activo.Medios.Internet
        ConveniosMedios.Soportes = Soportes
        ConveniosMedios.Puntual = pPuntual
        ConveniosMedios.ShowDialog()

    End Sub

    Private Sub ConveniosMedios_AplicarConvenio(ByVal pId_Convenio As Integer, ByVal pId_Soporte As Integer, ByVal pId_Producto As Integer, ByVal pD1 As Double, ByVal pD2 As Double, ByVal pD3 As Double, ByVal pD4 As Double, ByVal pD5 As Double, ByVal pNeto As Double, ByVal pTipoConvenio As String, ByVal pPuntual As Boolean) Handles ConveniosMedios.AplicarConvenio
        Dim RowModified As UltraGridRow

        If pPuntual Then
            Me.mTConvenio = pTipoConvenio
            For Each RowSeleccionada As UltraGridRow In ugPlanificacionInternet.Selected.Rows
                If RowSeleccionada.Cells("ID_SOPORTE").Value = pId_Soporte Then 'AndAlso RowSeleccionada.Cells("BRUTO").Activation <> Activation.NoEdit Then
                    If RowSeleccionada Is Nothing Then Exit Sub
                    If pTipoConvenio = "D" Then
                        RowSeleccionada.Cells("DCTO1").Value = pD1
                        RowSeleccionada.Cells("DCTO2").Value = pD2
                        RowSeleccionada.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
                        If RowSeleccionada.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                            RowSeleccionada.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                        End If
                    Else
                        'AG 20/12/2013 =============================================================
                        If Mensajes.Mensaje("¿Desea reemplazar el valor de la Tarifa actual ($ " + RowSeleccionada.Cells("BRUTO").Value.ToString() + " ), por el valor de la Tarifa del Convenio?. ($ " + pNeto.ToString() + " )", TipoMensaje.SiNo, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            RowSeleccionada.Cells("BRUTO").Value = pNeto
                        Else
                            pNeto = RowSeleccionada.Cells("BRUTO").Value
                            RowSeleccionada.Cells("BRUTO").Value = RowSeleccionada.Cells("BRUTO").Value
                        End If
                        '=============================================================================
                        'RowSeleccionada.Cells("BRUTO").Value = pNeto
                        'RowSeleccionada.Cells("BRUTO").Value = pNeto

                        RowSeleccionada.Cells("DCTO1").Value = pD1
                        RowSeleccionada.Cells("DCTO2").Value = pD2
                        RowSeleccionada.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
                        If RowSeleccionada.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                            RowSeleccionada.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                        End If
                    End If
                    RowSeleccionada.Cells("ID_CONVENIO").Value = pId_Convenio
                    Dim Dr As DataRow
                    Try
                        Dr = DtGrilla.Select("ID_SPOT = " & RowSeleccionada.Cells("ID_SPOT").Value)(0)
                    Catch ex As IndexOutOfRangeException
                        MsgBox(MensajeIDSPOTNoExiste, MsgBoxStyle.Critical, MensajeTitulo)
                        Exit Sub
                    End Try
                    Dr("ID_CONVENIO") = pId_Convenio
                    If pTipoConvenio = "D" Then
                        Dr("DCTO1") = pD1
                        Dr("DCTO2") = pD2
                    Else
                        Dr("BRUTO") = pNeto
                        Dr("DCTO1") = pD1
                        Dr("DCTO2") = pD2
                    End If
                    If pId_Convenio > 0 Then
                        SetearIconoEdicion(CInt(RowSeleccionada.Cells("ID_SPOT").Value), True)
                    Else
                    End If
                    ObtenerNetoCalculado()
                End If
            Next
        Else
            Me.mTConvenio = pTipoConvenio
            Dim ControlMensaje As Boolean = False
            Dim ControlCambioBruto As Boolean = False

            For Each RowParent As UltraGridRow In ugPlanificacionInternet.Rows
                If RowParent.Cells("ID_ORDEN_MMS").Value Is System.DBNull.Value Then
                    If RowParent.Cells("ID_SOPORTE").Value = pId_Soporte Then 'AndAlso RowParent.Cells("BRUTO").Activation <> Activation.NoEdit Then
                        If pTipoConvenio = "D" Then
                            RowParent.Cells("DCTO1").Value = pD1
                            RowParent.Cells("DCTO2").Value = pD2
                            RowParent.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
                            If RowParent.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                                RowParent.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                            End If
                        Else
                            'AG 20/12/2013 =============================================================
                            If ControlMensaje = False Then
                                If Mensajes.Mensaje("¿Desea reemplazar el valor de la Tarifa actual ($ " + RowParent.Cells("BRUTO").Value.ToString() + " ), por el valor de la Tarifa del Convenio?. ($ " + pNeto.ToString() + " )", TipoMensaje.SiNo, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                                    ControlCambioBruto = True
                                Else
                                    ControlCambioBruto = False
                                End If
                                ControlMensaje = True
                            End If

                            If ControlCambioBruto = True Then
                                RowParent.Cells("BRUTO").Value = pNeto
                            Else
                                RowParent.Cells("BRUTO").Value = RowParent.Cells("BRUTO").Value
                            End If
                            '=============================================================================
                            'RowParent.Cells("BRUTO").Value = pNeto

                            RowParent.Cells("DCTO1").Value = pD1
                            RowParent.Cells("DCTO2").Value = pD2
                            RowParent.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
                            If RowParent.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                                RowParent.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                            End If
                        End If
                        RowParent.Cells("ID_CONVENIO").Value = pId_Convenio
                        If pId_Convenio > 0 Then
                            SetearIconoEdicion(CInt(RowParent.Cells("ID_SPOT").Value), True)
                        End If
                        ObtenerNetoCalculadoxFila(CInt(RowParent.Cells("ID_SPOT").Value))
                    End If
                End If
            Next
        End If
    End Sub

#End Region

#Region "Metodos Genereles"

    Private Function ValidarDatosTarifa(ByVal IndiceTipoValidacion As Integer) As Integer

        Dim IndexError As Integer = ResultadoOperacion.DatosOk

        Select Case IndiceTipoValidacion

            Case TipoValidacion.AplicacionTarifas
                If Not Me.ugPlanificacionInternet.ActiveRow Is Nothing Then
                    If Me.ugPlanificacionInternet.ActiveRow.Cells("ID_SOPORTE").Value Is DBNull.Value Or Me.ugPlanificacionInternet.ActiveRow.Cells("ID_UBICACION").Value Is DBNull.Value Or Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_FORMATO").Value Is DBNull.Value Or Me.ugPlanificacionInternet.ActiveRow.Cells("ID_FORMATO").Value Is DBNull.Value Or Me.ugPlanificacionInternet.ActiveRow.Cells("ID_TIPO_COMPRA").Value Is DBNull.Value Or Me.ugPlanificacionInternet.ActiveRow.Cells("F_INICIO").Value Is DBNull.Value Or Me.ugPlanificacionInternet.ActiveRow.Cells("F_FIN").Value Is DBNull.Value Then
                        IndexError = ResultadoOperacion.DatosIncompletos
                        Return IndexError
                        Exit Function
                    End If
                End If

            Case TipoValidacion.AplicacionConvenios

        End Select

        Return IndexError

    End Function

    Private Sub AgregarSoportes()

        Dim RowMaestros As DataRow()
        Dim DesTipoSoporte, DesProveedor, DesSoporte As String
        Dim IdTipoSoporte, IdProveedor As Integer
        Dim FiltrarSoporteInt As New frmFiltrarSoporteInternet
        Dim PServicioAgencia As Single 'AG 27/12/2013

        FiltrarSoporteInt.Id_medio = Activo.Medios.Internet
        FiltrarSoporteInt.Id_tipo_soporte = mIdTipoSoporte
        FiltrarSoporteInt.ShowDialog()

        If Not FiltrarSoporteInt.Cancelado Then
            If Not FiltrarSoporteInt.ListaSoportes Is Nothing AndAlso FiltrarSoporteInt.ListaSoportes.Count > 0 Then
                For Each SoportesSeleccionados As ItemLista In FiltrarSoporteInt.ListaSoportes
                    RowMaestros = ObtenerDescripcionTipoSoporte(Activo.Medios.Internet, SoportesSeleccionados.ID)
                    If RowMaestros.Length > 0 Then
                        IdTipoSoporte = CInt(RowMaestros(0)("COD_TIPO_SOPORTE").ToString)
                        DesTipoSoporte = RowMaestros(0)("DES_TIPO_SOPORTE").ToString.ToUpper
                        DesSoporte = ObtenerDescripcionMaestros(TipoBusquedas.Descripcion, BusquedaDescripcion.Soporte, SoportesSeleccionados.Descripcion, BusquedaCodigos.Nada).ToUpper
                        ObtenerDescripcionMaestros(TipoBusquedas.Descripcion, BusquedaDescripcion.Proveedor, SoportesSeleccionados.Descripcion, BusquedaCodigos.Nada).ToUpper()
                        IdProveedor = CInt(ObtenerDescripcionMaestros(TipoBusquedas.Codigo, BusquedaDescripcion.Proveedor, SoportesSeleccionados.Descripcion, BusquedaCodigos.Proveedor).ToUpper)
                        DesProveedor = ObtenerDescripcionMaestros(TipoBusquedas.Descripcion, BusquedaDescripcion.Proveedor, SoportesSeleccionados.Descripcion, BusquedaCodigos.Nada).ToUpper
                        PServicioAgencia = ObtenerServicioAgencia(IdTipoSoporte)
                        AgregarFila(0, 0, 0, IdProveedor, DesProveedor, IdTipoSoporte, DesTipoSoporte, SoportesSeleccionados.ID, DesSoporte, 0, 0, 0, Me.FechaInicio, Me.FechaFin, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, PServicioAgencia, 0, 0, Activo.IDUsuarioMMS, 0)
                    Else
                        AgregarFila(-1, 0, 0, -1, "SIN PROVEEDOR", -1, "SIN TIPO SOPORTE", SoportesSeleccionados.ID, DesSoporte, 0, 0, 0, Me.FechaInicio, Me.FechaFin, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Activo.IDUsuarioMMS, 0)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub AgregarSoportesCargaNueva()

        Dim RowMaestros As DataRow()
        Dim DesTipoSoporte, DesProveedor, DesSoporte As String
        Dim IdTipoSoporte, IdProveedor As Integer
        Dim PServicioAgencia As Single

        If Not mListaSoportes Is Nothing AndAlso mListaSoportes.Count > 0 Then
            For Each SoportesSeleccionados As ItemLista In mListaSoportes
                RowMaestros = ObtenerDescripcionTipoSoporte(Activo.Medios.Internet, SoportesSeleccionados.ID)
                If RowMaestros.Length > 0 Then
                    IdTipoSoporte = CInt(RowMaestros(0)("COD_TIPO_SOPORTE").ToString)
                    DesTipoSoporte = RowMaestros(0)("DES_TIPO_SOPORTE").ToString.ToUpper
                    DesSoporte = ObtenerDescripcionMaestros(TipoBusquedas.Descripcion, BusquedaDescripcion.Soporte, SoportesSeleccionados.Descripcion, BusquedaCodigos.Nada).ToUpper
                    IdProveedor = CInt(ObtenerDescripcionMaestros(TipoBusquedas.Codigo, BusquedaDescripcion.Proveedor, SoportesSeleccionados.Descripcion, BusquedaCodigos.Proveedor).ToUpper)
                    DesProveedor = ObtenerDescripcionMaestros(TipoBusquedas.Descripcion, BusquedaDescripcion.Proveedor, SoportesSeleccionados.Descripcion, BusquedaCodigos.Nada).ToUpper
                    PServicioAgencia = ObtenerServicioAgencia(IdTipoSoporte)
                    AgregarFila(0, 0, 0, IdProveedor, DesProveedor, IdTipoSoporte, DesTipoSoporte, SoportesSeleccionados.ID, DesSoporte, 0, 0, 0, Me.FechaInicio, Me.FechaFin, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, PServicioAgencia, 0, 0, Activo.IDUsuarioMMS, 0)
                Else
                    AgregarFila(0, 0, 0, -1, "SIN PROVEEDOR", -1, "SIN TIPO SOPORTE", SoportesSeleccionados.ID, DesSoporte, 0, 0, 0, Me.FechaInicio, Me.FechaFin, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, PServicioAgencia, 0, 0, Activo.IDUsuarioMMS, 0)
                End If
            Next
        End If
    End Sub

    Private Function DuplicarFilaSeleccionada()
        For Each CellSelected As UltraGridCell In Me.ugPlanificacionInternet.Selected.Cells
            AgregarFila(0, CInt(CellSelected.Row.Cells("ID_TARIFA").Value), CInt(CellSelected.Row.Cells("ID_CONVENIO").Value), CInt(CellSelected.Row.Cells("ID_PROVEEDOR").Value), CellSelected.Row.Cells("PROVEEDOR").Value, CInt(CellSelected.Row.Cells("ID_TIPO_SOPORTE").Value), CellSelected.Row.Cells("TIPO_SOPORTE").Value, CInt(CellSelected.Row.Cells("ID_SOPORTE").Value), CellSelected.Row.Cells("SOPORTE").Value, CInt(CellSelected.Row.Cells("ID_UBICACION").Value), CInt(CellSelected.Row.Cells("ID_TIPO_FORMATO").Value), CInt(CellSelected.Row.Cells("ID_FORMATO").Value), CDate(CellSelected.Row.Cells("F_INICIO").Value), CDate(CellSelected.Row.Cells("F_FIN").Value), CInt(CellSelected.Row.Cells("ID_TIPO_COMPRA").Value), CInt(CellSelected.Row.Cells("CANTIDAD_DIAS").Value), CInt(CellSelected.Row.Cells("CANTIDAD_HORAS").Value), CDbl(CellSelected.Row.Cells("BRUTO").Value), CSng(CellSelected.Row.Cells("DCTO1").Value), CSng(CellSelected.Row.Cells("DCTO2").Value), CDbl(CellSelected.Row.Cells("NETO").Value), CDbl(CellSelected.Row.Cells("INVERSION").Value), CInt(CellSelected.Row.Cells("IMPRESIONES").Value), CInt(CellSelected.Row.Cells("CLICKS").Value), CInt(CellSelected.Row.Cells("VIEWS").Value), CDbl(CellSelected.Row.Cells("SHAR").Value), CDbl(CellSelected.Row.Cells("PORSAG").Value), CSng(CellSelected.Row.Cells("IMPSAG").Value), CDbl(CellSelected.Row.Cells("TOTAL").Value), Activo.IDUsuarioMMS, CDbl(CellSelected.Row.Cells("CA").Value))
        Next

        For Each RowSelected As UltraGridRow In Me.ugPlanificacionInternet.Selected.Rows
            AgregarFila(0, CInt(RowSelected.Cells("ID_TARIFA").Value), CInt(RowSelected.Cells("ID_CONVENIO").Value), CInt(RowSelected.Cells("ID_PROVEEDOR").Value), RowSelected.Cells("PROVEEDOR").Value, CInt(RowSelected.Cells("ID_TIPO_SOPORTE").Value), RowSelected.Cells("TIPO_SOPORTE").Value, CInt(RowSelected.Cells("ID_SOPORTE").Value), RowSelected.Cells("SOPORTE").Value, CInt(RowSelected.Cells("ID_UBICACION").Value), CInt(RowSelected.Cells("ID_TIPO_FORMATO").Value), CInt(RowSelected.Cells("ID_FORMATO").Value), CDate(RowSelected.Cells("F_INICIO").Value), CDate(RowSelected.Cells("F_FIN").Value), CInt(RowSelected.Cells("ID_TIPO_COMPRA").Value), CInt(RowSelected.Cells("CANTIDAD_DIAS").Value), CInt(RowSelected.Cells("CANTIDAD_HORAS").Value), CDbl(RowSelected.Cells("BRUTO").Value), CSng(RowSelected.Cells("DCTO1").Value), CSng(RowSelected.Cells("DCTO2").Value), CDbl(RowSelected.Cells("NETO").Value), CDbl(RowSelected.Cells("INVERSION").Value), CInt(RowSelected.Cells("IMPRESIONES").Value), CInt(RowSelected.Cells("CLICKS").Value), CInt(RowSelected.Cells("VIEWS").Value), CDbl(RowSelected.Cells("SHAR").Value), CDbl(RowSelected.Cells("PORSAG").Value), CSng(RowSelected.Cells("IMPSAG").Value), CDbl(RowSelected.Cells("TOTAL").Value), Activo.IDUsuarioMMS, CDbl(RowSelected.Cells("CA").Value))
        Next

    End Function

    Private Function CargarDescripcionMaestrosHojaExistente(ByVal DtDatos As DataTable) As DataTable

        Dim DescripcionSoporteProveedor As String

        If DtDatos.Rows.Count > 0 Then
            For Each R As DataRow In DtDatos.Rows
                Try
                    R("TIPO_SOPORTE") = Activo.DTSoportesCache.Select("ID_SOPORTE=" & R("ID_SOPORTE") & " and " & "ID_MEDIO=" & Activo.Medios.Internet & " and " & "COD_TIPO_SOPORTE=" & R("ID_TIPO_SOPORTE"))(0)("DES_TIPO_SOPORTE").ToString().ToUpper
                Catch ex As Exception
                    R("TIPO_SOPORTE") = "Ya no existe relación en MMS: " & "ID_SOPORTE=" & R("ID_SOPORTE") & " and " & "ID_MEDIO=" & Activo.Medios.Internet & " and " & "COD_TIPO_SOPORTE=" & R("ID_TIPO_SOPORTE")
                End Try
                Try
                    DescripcionSoporteProveedor = Activo.DTSoportesCache.Select("ID_SOPORTE=" & R("ID_SOPORTE") & " and " & "ID_MEDIO=" & Activo.Medios.Internet & " and " & "COD_TIPO_SOPORTE=" & R("ID_TIPO_SOPORTE"))(0)("DESCRIPCION").ToString().ToUpper
                Catch ex As Exception
                    DescripcionSoporteProveedor = "Ya no existe relación en MMS: " & "ID_SOPORTE=" & R("ID_SOPORTE") & " and " & "ID_MEDIO=" & Activo.Medios.Internet & " and " & "COD_TIPO_SOPORTE=" & R("ID_TIPO_SOPORTE")
                End Try
                Try
                    R("SOPORTE") = ObtenerDescripcionMaestros(TipoBusquedas.Descripcion, BusquedaDescripcion.Soporte, DescripcionSoporteProveedor, BusquedaCodigos.Nada).ToUpper
                    R("PROVEEDOR") = ObtenerDescripcionMaestros(TipoBusquedas.Descripcion, BusquedaDescripcion.Proveedor, DescripcionSoporteProveedor, BusquedaCodigos.Nada).ToUpper
                Catch ex As Exception

                End Try
            Next
        End If

        Return DtDatos

    End Function

    Private Function CargarServicioAgencia(ByVal DtDatos As DataTable) As DataTable

        Dim DescripcionSoporteProveedor As String

        If DtDatos.Rows.Count > 0 Then
            For Each R As DataRow In DtDatos.Rows
                R("PORSAG") = ObtenerServicioAgencia(CInt(R("TIPO_SOPORTE")))
            Next
        End If

        Return DtDatos

    End Function

    Private Function AgregarEstadoFilasPlanExistente(ByVal DtDatos As DataTable) As DataTable

        If DtDatos.Rows.Count > 0 Then
            For Each R As DataRow In DtDatos.Rows
                R("OPERACION_FILA") = OperacionFila.Mostrar
                R("OPERACION_DB") = OperacionDB.Mostrar
            Next
        End If

        Return DtDatos

    End Function

    Private Function ObtenerDescripcionTipoSoporte(ByVal IdMedio As Integer, ByVal IdSoporte As Integer) As DataRow()

        Dim DRowsMaestros As DataRow()

        DRowsMaestros = Activo.DTSoportesCache.Select("ID_SOPORTE=" & IdSoporte & " and " & "ID_MEDIO=" & IdMedio)

        Return DRowsMaestros

    End Function

    Private Function ObtenerDescripcionMaestros(ByVal TipoBusqueda As Integer, ByVal TipoDescripcion As Integer, ByVal Cadena As String, ByVal TipoCodigo As Integer) As String

        Dim Descripcion As String
        Dim TramaSeparadaNivel() As String
        Dim TramaSeparadaNivel1() As String
        Dim TramaSeparadaNivel2() As String

        If TipoBusqueda = TipoBusquedas.Codigo Then
            Select Case TipoCodigo
                Case BusquedaCodigos.Proveedor
                    TramaSeparadaNivel = Cadena.Split("|")
                    TramaSeparadaNivel1 = TramaSeparadaNivel(1).ToString.Split("[")
                    TramaSeparadaNivel2 = TramaSeparadaNivel1(1).ToString.Split("]")
                    Descripcion = TramaSeparadaNivel2(0).Trim
            End Select
        ElseIf TipoBusqueda = TipoBusquedas.Descripcion Then
            Select Case TipoDescripcion
                Case BusquedaDescripcion.Soporte
                    TramaSeparadaNivel = Cadena.Split("|")
                    TramaSeparadaNivel = Cadena.Split("[")
                    Descripcion = TramaSeparadaNivel(0)
                Case BusquedaDescripcion.Proveedor
                    TramaSeparadaNivel = Cadena.Split("|")
                    TramaSeparadaNivel1 = TramaSeparadaNivel(1).ToString.Split("[")
                    Descripcion = TramaSeparadaNivel1(0).Trim
            End Select
        End If

        Return Descripcion
    End Function

    Private Function ObtenerProximoIdSpot(ByVal Dt As DataTable) As Long

        Dim id As Integer
        Dim fila As DataRow()

        Dt.DefaultView.Sort = "ID_SPOT DESC"

        If Dt.Rows.Count = 0 Then
            ProximoIdSpot = 1
        Else
            ProximoIdSpot = CLng(Dt.DefaultView(0)("ID_SPOT").ToString) + 1
        End If

        Return ProximoIdSpot

    End Function

    Private Function ObtenerServicioAgencia(ByVal IdTipoSoporte As Integer) As Single

        Dim Porcentaje As Single

        If Not Activo.DTServicioAgenciaInterneteCache Is Nothing Then
            If Activo.DTServicioAgenciaInterneteCache.Rows.Count > 0 Then
                For Each Dr As DataRow In Activo.DTServicioAgenciaInterneteCache.Rows
                    If IdTipoSoporte = Dr("COD_TIPO_SOPORTE") Then
                        Porcentaje = Activo.DTServicioAgenciaInterneteCache.Select("COD_TIPO_SOPORTE=" & IdTipoSoporte)(0)("PORCENTAJE_AGENCIA")
                        Exit For
                    End If
                Next
            Else
                Porcentaje = 0
            End If

        End If

        Return Math.Round(Porcentaje, 2)

    End Function

    Private Sub EliminarFilas()

        Dim Seleccionados As New SortedList
        Dim CantidadSeleccionados As Integer
        Dim Resultado As Integer
        Dim DrEliminar As DataRow
        OSpotInternet = New Spots_int

        For Each RowSelected As UltraGridRow In Me.ugPlanificacionInternet.Selected.Rows

            If RowSelected.Cells("ID_ORDEN_MMS").Value Is System.DBNull.Value Then
                'If Not Seleccionados.ContainsKey(RowSelected.ListIndex) Then
                'Seleccionados.Add(RowSelected.ListIndex, RowSelected.ListIndex)

                'AG 11/03/2015 Se arreglo bug de eliminar filas =================
                If Not Seleccionados.ContainsKey(RowSelected.Index) Then
                    Seleccionados.Add(RowSelected.Index, RowSelected.Index)
                End If
                '================================================================
            End If
        Next

        CantidadSeleccionados = Seleccionados.Count - 1

        For Index As Integer = CantidadSeleccionados To 0 Step -1
            Me.ugPlanificacionInternet.Rows(Seleccionados.GetKey(Index)).Selected = True
        Next

        For Indice As Integer = CantidadSeleccionados To 0 Step -1
            With OSpotInternet
                .Id_spot = Me.ugPlanificacionInternet.Rows(Seleccionados.GetKey(Indice)).Cells("ID_SPOT").Value
                .Id_campania = Me.ugPlanificacionInternet.Rows(Indice).Cells("ID_CAMPANIA").Value
                .Id_sistema = Me.ugPlanificacionInternet.Rows(Indice).Cells("ID_SISTEMA").Value
                .Id_ejercicio = Me.ugPlanificacionInternet.Rows(Indice).Cells("ID_EJERCICIO").Value
                Resultado = .ValidarSpotsExisteBaja()
            End With

            If Resultado > 0 Then
                OSpotInternet.Id_usuario = CInt(Activo.CodUsuarioMms)
                OSpotInternet.Id_spot = Me.ugPlanificacionInternet.Rows(Seleccionados.GetKey(Indice)).Cells("ID_SPOT").Value
                OSpotInternet.Eliminar_SpotsInternet()
                '=============================================== ELIMINO LOS REGISTROS DEL DT MEMORIA =================================================
                DrEliminar = DtGrilla.Select("ID_SPOT = " & Me.ugPlanificacionInternet.Rows(Seleccionados.GetKey(Indice)).Cells("ID_SPOT").Value)(0)
                If Not DrEliminar Is Nothing Then
                    DtGrilla.Rows.Remove(DrEliminar)
                End If
            Else
                If DtGrilla.Rows.Count > 0 Then
                    '========================== ELIMINO LOS REGISTROS DEL DT MEMORIA EN CASO QUE NO EXISTA EL ID_SPOT EN DB =============================
                    DrEliminar = DtGrilla.Select("ID_SPOT = " & Me.ugPlanificacionInternet.Rows(Seleccionados.GetKey(Indice)).Cells("ID_SPOT").Value)(0)
                    If Not DrEliminar Is Nothing Then
                        DtGrilla.Rows.Remove(DrEliminar)
                    End If
                End If
            End If
        Next

    End Sub

#End Region

#Region "Funciones de Calculos"

    Private Function CalcularImporteServicioAgenciaXFila() As Double

        Dim Porcentaje As Single
        Dim Resultado As Double
        Dim Inversion As Double

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
            If Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value Is DBNull.Value Then
                Inversion = 0
            Else
                Inversion = Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value
            End If

            If Me.ugPlanificacionInternet.ActiveRow.Cells("PORSAG").Value Is DBNull.Value Then
                Porcentaje = 0
            Else
                Porcentaje = Me.ugPlanificacionInternet.ActiveRow.Cells("PORSAG").Value
            End If

            If Inversion > 0 And Porcentaje > 0 Then
                Resultado = (Inversion * Porcentaje) / 100
                Me.ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value = Math.Round(Resultado, 2)
            End If
        End If

    End Function

    Private Function ObtenerCalcularTotalxFila() As Boolean

        Dim Inversion As Double
        Dim ImpSag As Double
        Dim Resultado As Double

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
            If Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value Is DBNull.Value Then
                Inversion = 0
            Else
                Inversion = Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value
            End If
            If Me.ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value Is DBNull.Value Then
                ImpSag = 0
            Else
                ImpSag = Me.ugPlanificacionInternet.ActiveRow.Cells("IMPSAG").Value
            End If
            Resultado = Math.Round(Inversion + ImpSag, 2)
            Me.ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = Math.Round(Resultado, 2)
        Else
            Resultado = 0
            Me.ugPlanificacionInternet.ActiveRow.Cells("TOTAL").Value = Resultado
        End If

    End Function

    Private Function ObtenerNetoCalculado() As Double

        Dim NetoCalculado As Double
        Dim Bruto As Double
        Dim Desc1, Desc2 As Single

        If Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value Is DBNull.Value Then
            Bruto = 0
        Else
            Bruto = Me.ugPlanificacionInternet.ActiveRow.Cells("BRUTO").Value
        End If

        If Me.ugPlanificacionInternet.ActiveRow.Cells("DCTO1").Value Is DBNull.Value Then
            Desc1 = 0
        Else
            Desc1 = Me.ugPlanificacionInternet.ActiveRow.Cells("DCTO1").Value
        End If

        If Me.ugPlanificacionInternet.ActiveRow.Cells("DCTO2").Value Is DBNull.Value Then
            Desc2 = 0
        Else
            Desc2 = Me.ugPlanificacionInternet.ActiveRow.Cells("DCTO2").Value
        End If

        NetoCalculado = Bruto * (1 - Desc1 / 100) * (1 - Desc2 / 100)
        Me.ugPlanificacionInternet.ActiveRow.Cells("NETO").Value = NetoCalculado
        Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
        If Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
            Me.ugPlanificacionInternet.ActiveRow.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
        End If


    End Function

    Private Function ObtenerNetoCalculadoxFila(ByVal IdSpot As Integer) As Double

        Dim NetoCalculado As Double
        Dim Bruto As Double
        Dim Desc1, Desc2 As Single

        For Each RowParent As UltraGridRow In Me.ugPlanificacionInternet.Rows
            If RowParent.Cells("ID_SPOT").Value = IdSpot Then

                If RowParent.Cells("BRUTO").Value Is DBNull.Value Then
                    Bruto = 0
                Else
                    Bruto = RowParent.Cells("BRUTO").Value
                End If

                If RowParent.Cells("DCTO1").Value Is DBNull.Value Then
                    Desc1 = 0
                Else
                    Desc1 = RowParent.Cells("DCTO1").Value
                End If

                If RowParent.Cells("DCTO2").Value Is DBNull.Value Then
                    Desc2 = 0
                Else
                    Desc2 = RowParent.Cells("DCTO2").Value
                End If

                NetoCalculado = Bruto * (1 - Desc1 / 100) * (1 - Desc2 / 100)
                RowParent.Cells("NETO").Value = NetoCalculado
                RowParent.Cells("OPERACION_FILA").Value = OperacionFila.Actualizar
                If RowParent.Cells("OPERACION_DB").Value <> OperacionDB.Nuevo.ToString Then
                    RowParent.Cells("OPERACION_DB").Value = OperacionDB.Actualizar
                End If
                Exit For
            End If
        Next
    End Function


    Private Function ObtenerTotalInversionFinalPlanificacion() As Double

        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "Total")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "Total", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

    End Function

    Private Function ObtenerTotalPlanificacion() As Double

        '================================================== TOTAL INVERSION ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "INVERSION")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "INVERSION", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL IMPRESIONES ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "IMPRESIONES")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "IMPRESIONES", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL CLICKS ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "CLICKS")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "CLICKS", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL VIEWS ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "VIEWS")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "VIEWS", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL IMPSAG ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "IMPSAG")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "IMPSAG", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL CANTIDAD DIAS ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "CANTIDAD_DIAS")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "CANTIDAD_DIAS", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL CANTIDAD HORAS ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "CANTIDAD_HORAS")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "CANTIDAD_HORAS", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL PORCENTAJE %SHARE ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "SHAR")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "SHAR", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}") '0:% ##,##
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL CA ( CONVERSIONES/ACCIONES ) ============================================================
        GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "CA")
        GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "CA", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False


        '================================================== TOTAL PORCENTAJE %AGENCIA ============================================================
        'GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "PORSAG")
        'GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "PORSAG", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0: ##,###.00}")
        'ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        'ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '============================================================ TOTAL BRUTO ============================================================
        'GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "BRUTO")
        'GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "BRUTO", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        'ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        'ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        '================================================== TOTAL NETO =======================================================================
        'GrillaFormato.HabilitarSumatoria(ugPlanificacionInternet, "NETO")
        'GrillaFormato.AcivarOperacion(Me.ugPlanificacionInternet, "NETO", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        'ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        'ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False



    End Function

    Private Sub CalcularShareGrilla(ByVal FilaActiva As Integer, ByVal TodaHoja As Boolean)

        Dim InversionTotal As Double
        Dim DtTemporal As New DataTable
        Dim Resultado As Double
        Dim InversionFila As Double

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
            DtTemporal = ugPlanificacionInternet.DataSource

            If DtTemporal.Rows.Count > 0 Then
                InversionTotal = DtTemporal.Compute("sum(INVERSION)", "")
            End If

            If TodaHoja = True Then
                If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
                    InversionFila = 0
                    For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
                        If RowGrilla.Cells("INVERSION").Value Is System.DBNull.Value Then
                            InversionFila = 0
                        Else
                            InversionFila = RowGrilla.Cells("INVERSION").Value
                        End If
                        If InversionFila > 0 And InversionTotal > 0 Then
                            Resultado = InversionFila / InversionTotal * 100
                        Else
                            Resultado = 0
                        End If
                        RowGrilla.Cells("SHAR").Value = Math.Round(Resultado, 2)
                    Next
                End If
            Else
                If Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value Is System.DBNull.Value Then
                    Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value = 0
                End If

                If Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value > 0 And InversionTotal > 0 Then
                    Resultado = Me.ugPlanificacionInternet.ActiveRow.Cells("INVERSION").Value / InversionTotal * 100
                Else
                    Resultado = 0
                End If
                Me.ugPlanificacionInternet.ActiveRow.Cells("SHAR").Value = Math.Round(Resultado, 2)
            End If
        End If

    End Sub

#End Region

#Region "Metodos Base de Datos"

    Private Function EjecutarOperacionDB() As Integer

        Dim IdSopsRealDB As Long

        If DtGrilla.Rows.Count > 0 Then
            For Each Dr As DataRow In DtGrilla.Rows
                OSpots = New Spots_int
                OSpotInternet = New Spots_int
                IdSopsRealDB = 0
                If Dr("OPERACION_DB") = OperacionDB.Actualizar.ToString Or Dr("OPERACION_DB") = OperacionDB.Nuevo.ToString Then
                    '=========== Cargo los Objetos para la tabla SPOTS ==================
                    With OSpots
                        .Id_campania = CInt(Dr("ID_CAMPANIA"))
                        .Id_sistema = CInt(Dr("ID_SISTEMA"))
                        .Id_ejercicio = CInt(Dr("ID_EJERCICIO"))
                        .Id_soporte = CInt(Dr("ID_SOPORTE"))
                        .Id_tarifa = CInt(Dr("ID_TARIFA"))
                        .Id_convenio = CInt(Dr("ID_CONVENIO"))
                        .Bruto = CDbl(Dr("BRUTO"))
                        .Dcto1 = CSng(Dr("DCTO1"))
                        .Dcto2 = CSng(Dr("DCTO2"))
                        .Neto = CDbl(Dr("NETO"))
                        If Dr("OPERACION_DB") = OperacionDB.Nuevo.ToString Then
                            .F_alta = CDate(Date.Today)
                            .U_alta = CStr(Activo.Login)
                            IdSopsRealDB = .Insertar_Spots
                        ElseIf Dr("OPERACION_DB") = OperacionDB.Actualizar.ToString Then
                            .Id_spot = Dr("ID_SPOT")
                            .F_modi = CDate(Date.Today)
                            .U_modi = CStr(Activo.Login)
                            .Actualizar_Spots()
                        End If
                        RecorrerGrillaActualizarIconos(Dr("ID_SPOT"))
                    End With
                    '=========== Cargo los Objetos para la tabla SPOTS_INTERNET ==================
                    With OSpotInternet
                        .Id_proveedor = CInt(Dr("ID_PROVEEDOR"))
                        .Id_tipo_soporte = CInt(Dr("ID_TIPO_SOPORTE"))
                        .Id_ubicacion = CInt(Dr("ID_UBICACION"))
                        .Id_tipo_formato = CInt(Dr("ID_TIPO_FORMATO"))
                        .Id_formato = CInt(Dr("ID_FORMATO"))
                        .Id_Tipo_Compra = CInt(Dr("ID_TIPO_COMPRA"))
                        .F_inicio = CDate(Dr("F_INICIO"))
                        .F_fin = CDate(Dr("F_FIN"))
                        .Cantidad_dias = CInt(Dr("CANTIDAD_DIAS"))
                        .Cantidad_horas = CInt(Dr("CANTIDAD_HORAS"))
                        .Inversion = CDbl(Dr("INVERSION"))
                        .Impresiones = CInt(Dr("IMPRESIONES"))
                        .Clicks = CInt(Dr("CLICKS"))
                        .Views = CInt(Dr("VIEWS"))
                        .Share = CSng(Dr("SHAR"))
                        .PorSag = CSng(Dr("PORSAG"))
                        .ImpSag = CDbl(Dr("IMPSAG"))
                        .Total = CDbl(Dr("TOTAL"))
                        .Id_usuario = CInt(Dr("ID_USUARIO"))
                        .CA = CInt(Dr("CA"))
                        If Dr("OPERACION_DB") = OperacionDB.Nuevo.ToString Then
                            .Id_spot = IdSopsRealDB
                            .Insertar_SpotsInternet()
                        ElseIf Dr("OPERACION_DB") = OperacionDB.Actualizar.ToString Then
                            .Id_spot = Dr("ID_SPOT")
                            .Actualizar_SpotsInternet()
                        End If
                    End With
                    If Dr("OPERACION_DB") = OperacionDB.Nuevo.ToString Then
                        Dr("ID_SPOT") = IdSopsRealDB
                    End If
                    Dr("OPERACION_FILA") = OperacionFila.Mostrar
                    Dr("OPERACION_DB") = OperacionDB.Mostrar
                End If
            Next
        End If

    End Function

    Private Function IgualarDtGrillaConGrillaDatos() As DataTable

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.ugPlanificacionInternet.Rows
                Dim Dr As DataRow
                Dr = DtGrilla.Select("ID_SPOT = " & RowGrilla.Cells("ID_SPOT").Value)(0)
                If Not Dr Is Nothing Then
                    Dr("OPERACION_DB") = IIf(IsDBNull(RowGrilla.Cells("OPERACION_DB").Value), "", RowGrilla.Cells("OPERACION_DB").Value)
                    Dr("OPERACION_FILA") = IIf(IsDBNull(RowGrilla.Cells("OPERACION_FILA").Value), "", RowGrilla.Cells("OPERACION_FILA").Value)
                    Dr("ID_CAMPANIA") = IIf(IsDBNull(RowGrilla.Cells("ID_CAMPANIA").Value), 0, RowGrilla.Cells("ID_CAMPANIA").Value)
                    Dr("ID_SISTEMA") = IIf(IsDBNull(RowGrilla.Cells("ID_SISTEMA").Value), 0, RowGrilla.Cells("ID_SISTEMA").Value)
                    Dr("ID_EJERCICIO") = IIf(IsDBNull(RowGrilla.Cells("ID_EJERCICIO").Value), 0, RowGrilla.Cells("ID_EJERCICIO").Value)
                    Dr("ID_TARIFA") = IIf(IsDBNull(RowGrilla.Cells("ID_TARIFA").Value), 0, RowGrilla.Cells("ID_TARIFA").Value)
                    Dr("ID_CONVENIO") = IIf(IsDBNull(RowGrilla.Cells("ID_CONVENIO").Value), 0, RowGrilla.Cells("ID_CONVENIO").Value)
                    Dr("ID_PROVEEDOR") = IIf(IsDBNull(RowGrilla.Cells("ID_PROVEEDOR").Value), 0, RowGrilla.Cells("ID_PROVEEDOR").Value)
                    Dr("PROVEEDOR") = IIf(IsDBNull(RowGrilla.Cells("PROVEEDOR").Value), "", RowGrilla.Cells("PROVEEDOR").Value)
                    Dr("ID_SOPORTE") = IIf(IsDBNull(RowGrilla.Cells("ID_SOPORTE").Value), 0, RowGrilla.Cells("ID_SOPORTE").Value)
                    Dr("SOPORTE") = IIf(IsDBNull(RowGrilla.Cells("SOPORTE").Value), "", RowGrilla.Cells("SOPORTE").Value)
                    Dr("ID_TIPO_SOPORTE") = IIf(IsDBNull(RowGrilla.Cells("ID_TIPO_SOPORTE").Value), 0, RowGrilla.Cells("ID_TIPO_SOPORTE").Value)
                    Dr("TIPO_SOPORTE") = IIf(IsDBNull(RowGrilla.Cells("TIPO_SOPORTE").Value), "", RowGrilla.Cells("TIPO_SOPORTE").Value)
                    Dr("ID_UBICACION") = IIf(IsDBNull(RowGrilla.Cells("ID_UBICACION").Value), 0, RowGrilla.Cells("ID_UBICACION").Value)
                    Dr("ID_TIPO_FORMATO") = IIf(IsDBNull(RowGrilla.Cells("ID_TIPO_FORMATO").Value), 0, RowGrilla.Cells("ID_TIPO_FORMATO").Value)
                    Dr("ID_FORMATO") = IIf(IsDBNull(RowGrilla.Cells("ID_FORMATO").Value), 0, RowGrilla.Cells("ID_FORMATO").Value)
                    Dr("F_INICIO") = IIf(IsDBNull(RowGrilla.Cells("F_INICIO").Value), "01/01/1900", RowGrilla.Cells("F_INICIO").Value)
                    Dr("F_FIN") = IIf(IsDBNull(RowGrilla.Cells("F_FIN").Value), "01/01/1900", RowGrilla.Cells("F_FIN").Value)
                    Dr("ID_TIPO_COMPRA") = IIf(IsDBNull(RowGrilla.Cells("ID_TIPO_COMPRA").Value), 0, RowGrilla.Cells("ID_TIPO_COMPRA").Value)
                    Dr("CANTIDAD_DIAS") = IIf(IsDBNull(RowGrilla.Cells("CANTIDAD_DIAS").Value), 0, RowGrilla.Cells("CANTIDAD_DIAS").Value)
                    Dr("CANTIDAD_HORAS") = IIf(IsDBNull(RowGrilla.Cells("CANTIDAD_HORAS").Value), 0, RowGrilla.Cells("CANTIDAD_HORAS").Value)
                    Dr("BRUTO") = IIf(IsDBNull(RowGrilla.Cells("BRUTO").Value), 0, RowGrilla.Cells("BRUTO").Value)
                    Dr("DCTO1") = IIf(IsDBNull(RowGrilla.Cells("DCTO1").Value), 0, RowGrilla.Cells("DCTO1").Value)
                    Dr("DCTO2") = IIf(IsDBNull(RowGrilla.Cells("DCTO2").Value), 0, RowGrilla.Cells("DCTO2").Value)
                    Dr("NETO") = IIf(IsDBNull(RowGrilla.Cells("NETO").Value), 0, RowGrilla.Cells("NETO").Value)
                    Dr("INVERSION") = IIf(IsDBNull(RowGrilla.Cells("INVERSION").Value), 0, RowGrilla.Cells("INVERSION").Value)
                    Dr("IMPRESIONES") = IIf(IsDBNull(RowGrilla.Cells("IMPRESIONES").Value), 0, RowGrilla.Cells("IMPRESIONES").Value)
                    Dr("CLICKS") = IIf(IsDBNull(RowGrilla.Cells("CLICKS").Value), 0, RowGrilla.Cells("CLICKS").Value)
                    Dr("VIEWS") = IIf(IsDBNull(RowGrilla.Cells("VIEWS").Value), 0, RowGrilla.Cells("VIEWS").Value)
                    Dr("SHAR") = IIf(IsDBNull(RowGrilla.Cells("SHAR").Value), 0, RowGrilla.Cells("SHAR").Value)
                    Dr("PORSAG") = IIf(IsDBNull(RowGrilla.Cells("PORSAG").Value), 0, RowGrilla.Cells("PORSAG").Value)
                    Dr("IMPSAG") = IIf(IsDBNull(RowGrilla.Cells("IMPSAG").Value), 0, RowGrilla.Cells("IMPSAG").Value)
                    Dr("TOTAL") = IIf(IsDBNull(RowGrilla.Cells("TOTAL").Value), 0, RowGrilla.Cells("TOTAL").Value)
                    Dr("ID_USUARIO") = IIf(IsDBNull(RowGrilla.Cells("ID_USUARIO").Value), 0, RowGrilla.Cells("ID_USUARIO").Value)
                End If
            Next
        End If

        Return DtGrilla

    End Function

#End Region

#End Region

#Region "Seccion Desglose PROVEEDOR"

    Private Sub SetearGrillaDesgloseProveedor()
        CambiarFormatoColumnasDesgloseProveedor()
        CambiarNombreColumnasDesgloseProveedor()
        OcultarColumnasDesgloseProveedor()
        InhabilitarColumnasDesgloseProveedor()
        AliniaTitulosColumnasDesgloseProveedor()
        AliniarDatosCeldasDesgloseProveedor()
        ObtenerTotalInversionProveedor()
    End Sub

    Private Sub CambiarFormatoColumnasDesgloseProveedor()
        GrillaFormato.CambiarFormatoColumna(iugProveedor, "INVERSION", Formato.Moneda)
    End Sub

    Private Sub CambiarNombreColumnasDesgloseProveedor()

        Listas.CambiarTituloColumna(Me.iugProveedor, "PROVEEDOR", "Grupo")
        Listas.CambiarTituloColumna(Me.iugProveedor, "INVERSION", "Inversion")
        Listas.CambiarTituloColumna(Me.iugProveedor, "SHARE", "% Share Inversion")

    End Sub

    Private Sub OcultarColumnasDesgloseProveedor()

        Listas.OcultarColumnas(Me.iugProveedor, "ID_PROVEEDOR")

    End Sub

    Private Sub InhabilitarColumnasDesgloseProveedor()

        GrillaFormato.HabilitarEdicionColumna(Me.iugProveedor, Activation.NoEdit, "ID_PROVEEDOR")
        GrillaFormato.HabilitarEdicionColumna(Me.iugProveedor, Activation.NoEdit, "PROVEEDOR")
        GrillaFormato.HabilitarEdicionColumna(Me.iugProveedor, Activation.NoEdit, "INVERSION")
        GrillaFormato.HabilitarEdicionColumna(Me.iugProveedor, Activation.NoEdit, "SHARE")

    End Sub

    Private Sub AliniaTitulosColumnasDesgloseProveedor()

        With Me.iugProveedor.DisplayLayout.Bands(0)
            .Columns("ID_PROVEEDOR").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PROVEEDOR").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("INVERSION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SHARE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With
    End Sub

    Private Sub AliniarDatosCeldasDesgloseProveedor()

        With iugProveedor.DisplayLayout.Bands(0)
            .Columns("ID_PROVEEDOR").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("PROVEEDOR").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("INVERSION").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("SHARE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        End With

    End Sub

    Private Function ArmarEstructuraDtDesgloseProveedor() As DataTable

        With DtDesgloseProveedor.Columns
            .Add("ID_PROVEEDOR", GetType(Integer))
            .Add("PROVEEDOR", GetType(String))
            .Add("INVERSION", GetType(Double))
            .Add("SHARE", GetType(Single))
        End With

        Return DtDesgloseProveedor

    End Function

    Private Function PoblarDesgloseProveedor() As DataTable

        Dim DtDistintProveedor As New DataTable
        Dim DtTemporal As New DataTable
        Dim DrProveedor As DataRow
        Dim FilaNueva As DataRow
        Dim TotalInversion As Double


        If DtDesgloseProveedor.Rows.Count = 0 Then
            If Not DtDesgloseProveedor Is Nothing Then

                DtDesgloseProveedor = Nothing
                DtDesgloseProveedor = New DataTable
                DtDesgloseProveedor = ArmarEstructuraDtDesgloseProveedor()
            Else
                DtDesgloseProveedor = ArmarEstructuraDtDesgloseProveedor()
            End If

        End If

        If Not Me.ugPlanificacionInternet.Rows Is Nothing Then
            If Me.ugPlanificacionInternet.Rows.Count > 0 Then
                DtTemporal = Me.ugPlanificacionInternet.DataSource
                DtDistintProveedor = DtTemporal.DefaultView.ToTable(True, "ID_PROVEEDOR", "PROVEEDOR")
                If DtDistintProveedor.Rows.Count > 0 Then
                    If DtDistintProveedor.Rows.Count > 0 Then
                        DtDesgloseProveedor.Rows.Clear()
                        TotalInversion = DtTemporal.Compute("Sum(INVERSION)", "")
                        For Each DrProveedor In DtDistintProveedor.Rows
                            FilaNueva = DtDesgloseProveedor.NewRow
                            FilaNueva("ID_PROVEEDOR") = DrProveedor("ID_PROVEEDOR")
                            FilaNueva("PROVEEDOR") = DtTemporal.Select("ID_PROVEEDOR =" & DrProveedor("ID_PROVEEDOR"))(0)("PROVEEDOR").ToString
                            FilaNueva("INVERSION") = DtTemporal.Compute("Sum(INVERSION)", "ID_PROVEEDOR=" & DrProveedor("ID_PROVEEDOR"))
                            If FilaNueva("INVERSION").ToString() <> "" Or FilaNueva("INVERSION") > 0 Then
                                If TotalInversion > 0 Then
                                    FilaNueva("SHARE") = FilaNueva("INVERSION") / TotalInversion * 100
                                    FilaNueva("SHARE") = Math.Round(FilaNueva("SHARE"), 2)
                                    DtDesgloseProveedor.Rows.Add(FilaNueva)
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        End If

        Return DtDesgloseProveedor

    End Function

    Private Function ObtenerTotalInversionProveedor()

        GrillaFormato.HabilitarSumatoria(iugProveedor, "INVERSION")
        GrillaFormato.AcivarOperacion(Me.iugProveedor, "INVERSION", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        GrillaFormato.HabilitarSumatoria(iugProveedor, "SHARE")
        GrillaFormato.AcivarOperacion(Me.iugProveedor, "SHARE", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        ugPlanificacionInternet.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        ugPlanificacionInternet.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

    End Function

#End Region

#Region "Enumeradores"

    Public Enum BusquedaDescripcion
        Nada = 0
        Soporte = 1
        Proveedor = 2
    End Enum

    Public Enum BusquedaCodigos
        Nada = 0
        Soporte = 1
        Proveedor = 2
    End Enum

    Public Enum TipoBusquedas
        Nada = 0
        Codigo = 1
        Descripcion = 2
    End Enum

    Public Enum OperacionFila
        Nuevo = 1
        Actualizar = 2
        Eliminar = 3
        Mostrar = 4
    End Enum

    Public Enum OperacionDB
        Nuevo = 1
        Actualizar = 2
        Eliminar = 3
        Mostrar = 4
    End Enum

    Public Enum ResultadoOperacion
        DatosOk = 1
        TarifasNoExisten = 2
        ConveniosNoExisten = 3
        DatosIncompletos = 4
    End Enum

    Public Enum TipoValidacion
        AplicacionTarifas = 1
        AplicacionConvenios = 2
    End Enum

    Public Enum TipoCompra
        CPM = 1
        CPC_Fijo_Dinamico_Estimado = 2
        CPV_Fijo_Dinamico_Estimado = 3
        Fijo_x_Dia = 4
        Fijo_x_Hora = 5
        Fijo_Mensual = 6
        Costo_Paquete = 7
        Bonificacion = 8
        CPA = 9
    End Enum

    Public Enum ValidarFecha
        OKFechas = 0
        MesDistinto = 1
        AnioDistinto = 2
        FInicioMayor = 3
        FFinMenor = 4
    End Enum

#End Region

#Region "Metodos Sin Utilizar"

    Private Sub InhabilitarEdicionColumnas()
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "PROVEEDOR")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "SOPORTE")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "BRUTO")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "TIPO_SOPORTE")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "TOTAL")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "ESTADO")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "ID_CONVENIO")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "SHAR")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "PORSAG")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "IMPSAG")
        GrillaFormato.HabilitarEdicionColumna(Me.ugPlanificacionInternet, Activation.NoEdit, "NETO")
    End Sub

#End Region



End Class

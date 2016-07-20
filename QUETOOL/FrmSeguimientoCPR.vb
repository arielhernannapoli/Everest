Imports MSL.Maestros
Imports HM.Contratos.Entidad
Imports HM.Contratos.Entidad.Campanas
Imports HM.Contratos.Entidad.Soportes
Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports System.Collections.Generic
Imports MPG.DBL
Imports System.Text

Public Class FrmSeguimientoCPR

#Region "Variables"

    Dim mFDesde, mFHasta As Date
    Dim mIdCampania, mIdSistema, mIdEjercicio, mIdSoporte, mIdTarget, mIdTarget2, mIdAlternativa As Integer
    Dim mNumPedido As Integer
    Dim mImporteTV As Double
    Dim mDesTarget, mDesTarget2 As String
    Dim CPRCanal13, CPRTelefe, CPRAmerica, CPRCanal9 As Double
    Dim OBSpotDetalle As Spots_detalle
    Dim OBFOneCPR As New frmFormulaOne
    Dim UltimoFspot As Date
    Dim Cod_SPS As Long
    Dim CantSpotInsertados As Integer
    Const TVA = 0
    Dim Alter As New Alternativas
    Dim TipoMedicion As Medicion
    Dim IDnuevo As Long
    Dim Reportes As New ArrayList
    Dim Totales As New ArrayList
    Dim MayorFecha As Date
    Dim MenorFecha As Date
    Dim IdPlaza As Integer
    Dim idArchivo As String
    Dim ResultadoValidacion As Boolean = False
    Dim SinAvisosMacheados As Boolean = False
    Dim ErrorNombrePrograma As String
    Dim ErrorNroOrden As String
    Dim MensajeErrorMotorAudiencia As String

#End Region

#Region "DataTables"

    Dim mDtDatosAlternativa As DataTable
    Dim DtSpotEverest As New DataTable
    Dim DtAvisosMMS As DataTable
    Dim dtTemas As DataTable
    Dim dtSoportesIbope As New DataTable
    Dim dtSopAlternativas As DataTable
    Dim DtFinalCompletoSinMMS As DataTable
    Dim DtDuracionPromediaSoporte As DataTable
    Dim DtCalculoFinalPauta As DataTable
    Dim ArrPlaAvisos As New ArrayList
    Dim SoporteTvAbierta() As String = {"11", "13", "48", "1870"}
    Dim DtTemasAplicados As New DataTable

    '++++++++++++ Variales de Totales +++++++++++++++++
    '++++++++++++ Planificacion ++++++++++++++++++++++
    Dim PlaInversionNeta As Double
    Dim PlaGRPS As Double
    Dim PlaDuracionPromedio As Double
    Dim PlaCPRPromedio As Double
    Dim PlaSOIxCanal As Double
    '++++++++++++ Emitidos +++++++++++++++++++++++++
    Dim EmiInversionNeta As Double
    Dim EmiGRPS As Double
    Dim EmiDuracionPromedio As Double
    Dim EmiCPRPromedio As Double
    Dim EmiSOIxCanal As Double
    '++++++++++++ Seguimiento ++++++++++++++++++++++
    Dim TotalOrdenCompra As Double
    Dim DifTotalNetoRealCompra As Double
    Dim TotalInversionNetaCompleta As Double

#End Region

#Region "Propiedades"

    Public Property FDesde() As Date
        Get
            Return mFDesde
        End Get
        Set(ByVal value As Date)
            mFDesde = value
        End Set
    End Property

    Public Property FHasta() As Date
        Get
            Return mFHasta
        End Get
        Set(ByVal value As Date)
            mFHasta = value
        End Set
    End Property

    Public Property IdCampania() As Integer
        Get
            Return mIdCampania
        End Get
        Set(ByVal value As Integer)
            mIdCampania = value
        End Set
    End Property

    Public Property IdSistema() As Integer
        Get
            Return mIdSistema
        End Get
        Set(ByVal value As Integer)
            mIdSistema = value
        End Set
    End Property

    Public Property IdEjercicio() As Integer
        Get
            Return mIdEjercicio
        End Get
        Set(ByVal value As Integer)
            mIdEjercicio = value
        End Set
    End Property

    Public Property IdAlternativa() As Integer
        Get
            Return mIdAlternativa
        End Get
        Set(ByVal value As Integer)
            mIdAlternativa = value
        End Set
    End Property

    Public Property IdSoporte() As Integer
        Get
            Return IdSoporte
        End Get
        Set(ByVal value As Integer)
            mIdSoporte = value
        End Set
    End Property

    Public Property IdTarget() As Integer
        Get
            Return mIdTarget
        End Get
        Set(ByVal value As Integer)
            mIdTarget = value
        End Set
    End Property

    Public Property DesTarget() As String
        Get
            Return mDesTarget
        End Get
        Set(ByVal value As String)
            mDesTarget = value
        End Set
    End Property

    Public Property IdTarget2() As Integer 'AG 15/03/2013 
        Get
            Return mIdTarget2
        End Get
        Set(ByVal value As Integer)
            mIdTarget2 = value
        End Set
    End Property

    Public Property DesTarget2() As String 'AG 15/03/2013 
        Get
            Return mDesTarget2
        End Get
        Set(ByVal value As String)
            mDesTarget2 = value
        End Set
    End Property

    Public Property NumPedido() As Integer
        Get
            Return mNumPedido
        End Get
        Set(ByVal value As Integer)
            mNumPedido = value
        End Set
    End Property

    Public Property ImporteTV() As Double
        Get
            Return mImporteTV
        End Get
        Set(ByVal value As Double)
            mImporteTV = value
        End Set
    End Property

    Public Property DtDatosAlternativa() As DataTable
        Get
            Return mDtDatosAlternativa
        End Get
        Set(ByVal value As DataTable)
            mDtDatosAlternativa = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub FrmSeguimientoCPR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargarTargetSistema()
        ConfigurarControles()

    End Sub

    Private Sub txtCPRC13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRC13.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtCPRC9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRC9.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtCPRTelefe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRTelefe.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtCPRAmerica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRAmerica.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim DtCompletoDatos As New DataTable
        Dim DtCompletoFinal As New DataTable
        Dim DtDesgloseFinal As New DataTable
        Dim DtDesgloseSeguimientoFinal As New DataTable
        Dim OControlMache As New Control_Macheo
        Dim resultado As New Dictionary(Of String, List(Of OrdenConfirmada))
        Dim lOrdenes As New List(Of OrdenConfirmada)
        Dim i As Integer
        Dim DtProvisorio As New DataTable
        Dim Maximo As Integer = 2

        Me.ValidarDatos()

        If ResultadoValidacion = True Then
            Exit Sub
        End If

        OBSpotDetalle = New Spots_detalle

        'Datos Para Evaluacion ++++++++++++++++++++++++++++++++++++++++++
        Dim s As New Soportes
        Dim P As New Pautas_mp

        Alter.Id_campania = Activo.IDCampaña
        Alter.Id_alternativa = Activo.IDAlternativa
        Me.dtSoportesIbope = Alter.ObtenerSoportesIbope
        Alter.BuscarPorID()
        Me.dtSoportesIbope = Alter.ObtenerSoportesIbope
        MenorFecha = Alter.ObtenerMinFIniSist()
        MayorFecha = Alter.ObtenerMaxFFinSist()
        dtSopAlternativas = Alter.ObtenerSoportesGuardados
        IDnuevo = P.NuevoID + 1

        s.Id_soporte = dtSopAlternativas.Rows(0).Item("id_soporte")
        s.Id_medio = dtSopAlternativas.Rows(0).Item("id_medio")
        s.BuscarPorID_Soporte()

        Dim r As DataRow, NuevaFecha As Date, dias As Integer
        r = dtSoportesIbope.Select("id_soporte=" & s.Id_soporte)(0)

        idArchivo = r("id_archivo")
        IdPlaza = r("plaza")
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'Obtengo Datos de EVEREST ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        DtSpotEverest = OBSpotDetalle.ObtenerSpotReporteCPR(Me.IdCampania, Me.IdAlternativa, Me.dtpFechaDesde.Value, Me.dtpFechaHasta.Value, 1)
        If DtSpotEverest Is Nothing Or DtSpotEverest.Rows.Count = 0 Then
            MsgBox("No se encontraron datos de Everest para la alternativa elegida." & vbCrLf & "Compruebe que los avisos estén enviados a compras", MsgBoxStyle.Information, "Reporte CPR")
            Exit Sub
        End If
        'Obtengo Datos de MMS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        DtAvisosMMS = ObtenerAvisosMMS()
        'Enlazo los Datos de MMS y Everest +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        DtCompletoDatos = ProcesarDatos(EnlazarDatosEverest_MMS(AnexarColumnasDtEverest(DtSpotEverest), DtAvisosMMS))
        For i = 0 To Maximo - 1 'AG 15/03/2013
            DtProvisorio = EvaluarMotorP(DtCompletoDatos, i)
        Next i

        DtCompletoFinal = EliminarColumnasDtCompleto(DtProvisorio)

        'Contemplo que existan datos de audiencia traidos del motor  de calculo +++++++++++++++++++++++++++++++++
        If ComprobarDatosMotorAudiencia(DtCompletoFinal) = True Then
            MsgBox("El Reporte de CPR no se ejecuto debido al Siguiente Problema :   " & vbCrLf & MensajeErrorMotorAudiencia + " ", MsgBoxStyle.Information)
            MensajeErrorMotorAudiencia = ""
            Exit Sub
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        DtCompletoFinal = ControlAvisosDificultosos(DtCompletoFinal)
        DtDesgloseFinal = RecojerDatosTotales(DtCompletoFinal, ArmarDtDesglose())

        DtDesgloseSeguimientoFinal = RecojerDatosSeguimiento(DtDesgloseFinal, ArmarDtDesgloseSeguimiento(), DtCompletoFinal)

        DtCompletoFinal.Columns.Remove("id_soporte")
        DtCompletoFinal.Columns.Remove("IdAviso")
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        OBFOneCPR.MostrarFOneCPR(DtSpotEverest, DtAvisosMMS, DtCompletoFinal, DtDesgloseFinal, DtDesgloseSeguimientoFinal, New DataTable(), New DataTable(), New DataTable())
        ResultadoValidacion = False
        OBFOneCPR.Show()
        Me.Close()

    End Sub

#End Region

#Region "Funciones Primarias"

    Private Sub ConfigurarControles()
        Me.dtpFechaDesde.Value = Me.FDesde
        Me.dtpFechaHasta.Value = Me.FHasta
        Me.dtpFechaDesde.Enabled = True
        Me.dtpFechaHasta.Enabled = True
        Me.txtCPRAmerica.Enabled = True
        Me.txtCPRC13.Enabled = True
        Me.txtCPRC9.Enabled = True
        Me.txtCPRTelefe.Enabled = True
        Me.txtImporteTV.Enabled = True
        Me.txtTarget.Enabled = False
        Me.txttarget2.Enabled = False
    End Sub

    Private Sub CargarTargetSistema()

        Dim OBTarget As New Targets
        Dim DtTarget As DataTable

        DtTarget = OBTarget.ObtenerTargetReporteCPR(Me.IdTarget)

        If DtTarget.Rows.Count > 0 Then
            Me.DesTarget = DtTarget.Rows(0)("DESCRIPCION").ToString
            Me.IdTarget = DtTarget.Rows(0)("ID_TARGET")
            Me.txtTarget.Text = DtTarget.Rows(0)("DESCRIPCION").ToString    
        End If

        If Me.IdTarget2 > 0 Then
            DtTarget = OBTarget.ObtenerTargetReporteCPR(Me.IdTarget2)
            Me.IdTarget2 = DtTarget.Rows(0)("ID_TARGET")
            Me.DesTarget2 = DtTarget.Rows(0)("DESCRIPCION").ToString
            Me.txttarget2.Text = DtTarget.Rows(0)("DESCRIPCION").ToString
        Else
            Me.txttarget2.Text = "NINGUNO"
        End If
        

    End Sub

    Private Function ValidarDatos() As Boolean

        If Me.txtCPRC13.Text <> "" Then
            If Not IsNumeric(Me.txtCPRC13.Text) Then
                MsgBox("Debe Ingresar un Valor Numerico del CPR. para el Canal 13", MsgBoxStyle.Information, "Reporte CPR")
                Me.txtCPRC13.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.CPRCanal13 = Me.txtCPRC13.Text
                ResultadoValidacion = False
            End If
        End If

        If Me.txtCPRC9.Text <> "" Then
            If Not IsNumeric(Me.txtCPRC9.Text) Then
                MsgBox("Debe Ingresar un Valor Numerico del CPR. para el Canal 9", MsgBoxStyle.Information, "Reporte CPR")
                Me.txtCPRC9.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.CPRCanal9 = Me.txtCPRC9.Text
                ResultadoValidacion = False
            End If
        End If

        If Me.txtCPRTelefe.Text <> "" Then
            If Not IsNumeric(Me.txtCPRTelefe.Text) Then
                MsgBox("Debe Ingresar un Valor Numerico del CPR. para Telefe ", MsgBoxStyle.Information, "Reporte CPR")
                Me.txtCPRTelefe.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.CPRTelefe = Me.txtCPRTelefe.Text
                ResultadoValidacion = False
            End If
        End If

        If Me.txtCPRAmerica.Text <> "" Then
            If Not IsNumeric(Me.txtCPRAmerica.Text) Then
                MsgBox("Debe Ingresar un Valor Numerico del CPR. para America ", MsgBoxStyle.Information, "Reporte CPR")
                Me.txtCPRAmerica.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.CPRAmerica = Me.txtCPRAmerica.Text
                ResultadoValidacion = False
            End If
        End If

        'If Me.txtnumpedido.Text <> "" Then
        '    If Not IsNumeric(Me.txtnumpedido.Text) Then
        '        MsgBox("Debe Ingresar un Valor Numerico para el Pedido Solicitado. ", MsgBoxStyle.Information, "Reporte CPR")
        '        Me.txtnumpedido.Focus()
        '        ResultadoValidacion = True
        '        Exit Function
        '    Else
        '        Me.NumPedido = CInt(Me.txtnumpedido.Text)
        '        ResultadoValidacion = False
        '    End If
        'End If

        If Me.txtImporteTV.Text <> "" Then
            If Not IsNumeric(Me.txtImporteTV.Text) Then
                MsgBox("Debe Ingresar un Importe Numerico, para campo Importe TV ", MsgBoxStyle.Information, "Reporte CPR")
                Me.txtImporteTV.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.ImporteTV = Math.Round(Double.Parse(Me.txtImporteTV.Text.ToString), 2)
                ResultadoValidacion = False
            End If
        End If


    End Function

    Private Function AnexarColumnasDtEverest(ByVal Dt As DataTable) As DataTable

        Dt.Columns.Add("OP", GetType(String))
        Dt.Columns.Add("Presupuesto", GetType(String))
        Dt.Columns.Add("NroPedido", GetType(String))
        Dt.Columns.Add("InversionNeta", GetType(String))
        Dt.Columns.Add("NProgramaFuente", GetType(String))
        Dt.Columns.Add("HoraMinutoReal", GetType(String))
        Dt.Columns.Add("Duracion", GetType(String))
        Dt.Columns.Add("RatingRealTarget1", GetType(String))
        Dt.Columns.Add("RatingRealTarget2", GetType(String))
        Dt.Columns.Add("CprxSoporte", GetType(String))
        Dt.Columns.Add("InversionReal", GetType(String))
        Dt.Columns.Add("DifInversionNeta", GetType(String))
        Dt.Columns.Add("DifRating", GetType(String))
        Dt.Columns.Add("DifRating%", GetType(String))
        Dt.Columns.Add("DifCPR", GetType(String))
        'Columnas que se deben Eliminar luego ++++++++++++++++++++++
        Dt.Columns.Add("fejecucion", GetType(DateTime))
        Dt.Columns.Add("HoraMinutoEliminar", GetType(String))
        Dt.Columns.Add("IdAviso", GetType(Integer))
        Dt.Columns.Add("Control", GetType(String))
        '++++++++++++++++++++++++++++++++++++++++++++++++++
        Return Dt

    End Function

    Private Function FormatoHora(ByVal pHora As Integer, ByVal pMinuto As Integer) As String
        Dim Hora As New StringBuilder
        Dim HoraParcial As String
        Dim Minuto As String
        Dim NuevaHora As String

        HoraParcial = pHora
        NuevaHora = pHora
        If HoraParcial.Length < 4 Then
            HoraParcial = HoraParcial.Insert(0, "0")
            HoraParcial = HoraParcial.Substring(0, 2)
            Minuto = NuevaHora.Substring(1, 2)
            NuevaHora = HoraParcial + ":" + Minuto
        Else
            HoraParcial = HoraParcial.Substring(0, 2)
            Minuto = NuevaHora.Substring(2, 2)
            NuevaHora = HoraParcial + ":" + Minuto
        End If

        Return NuevaHora.ToString
    End Function

    Private Function EnlazarDatosEverest_MMS(ByVal DtCompleto As DataTable, ByVal DtAvisosMMS As DataTable) As DataTable

        Dim Filas() As DataRow
        Dim DtResultado As DataTable

            If Not DtAvisosMMS Is Nothing Then
                For Each RowDatosCompletos As DataRow In DtCompleto.Rows
                    Filas = DtAvisosMMS.Select("COD_ORDEN=" & RowDatosCompletos("id_orden_sigeme"))
                    If Filas.Length > 0 Then
                        '++++++++++++ Obtengo datos de Identificacion de Error +++++++++++++++++++
                        ErrorNombrePrograma = RowDatosCompletos("programa").ToString
                        ErrorNroOrden = RowDatosCompletos("id_orden_sigeme").ToString
                        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        RowDatosCompletos("OP") = Filas(0)("COD_CONTRATO")
                        RowDatosCompletos("Presupuesto") = Filas(0)("COD_PRESUPUESTO")
                        RowDatosCompletos("NroPedido") = Filas(0)("NUMERO_PEDIDO")
                        RowDatosCompletos("InversionNeta") = Filas(0)("NETO_VENTA")
                        RowDatosCompletos("NProgramaFuente") = Filas(0)("DES_PROGRAMA_REAL")
                        RowDatosCompletos("HoraMinutoReal") = FormatoHora(CInt(Filas(0)("HORAREAL")), 0)
                        RowDatosCompletos("Duracion") = Filas(0)("DURACION_REAL")
                        '++++++++++++++++ Verifico si es con Decimales o no El CPR +++++++++++++++++++++++++++++++

                    If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Then ' Cliente Claro
                        RowDatosCompletos("CprxSoporte") = AsignarCPRxSoporte(RowDatosCompletos("id_soporte"))
                    Else
                        RowDatosCompletos("CprxSoporte") = AsignarCPRxSoporte(RowDatosCompletos("id_soporte"))
                        '++++++++++++++++++++++++++++++++ Codigo Anterior ++++++++++++++++++++++++++++++
                        'RowDatosCompletos("CprxSoporte") = CInt(AsignarCPRxSoporte(CInt(RowDatosCompletos("id_soporte"))))
                        'RowDatosCompletos("CPRProg") = CInt(RowDatosCompletos("CPRProg"))
                        'RowDatosCompletos("CPRTanda") = CInt(RowDatosCompletos("CPRTanda"))
                        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    End If
                        RowDatosCompletos("fejecucion") = Filas(0)("FECHAREAL")
                        RowDatosCompletos("HoraMinutoEliminar") = Filas(0)("HORAREAL").ToString
                    End If
                Next
                Return RellenarAvisosSinOP(DtCompleto)
            Else
                Return RellenarAvisosSinOP(DtCompleto)
            End If

    End Function

    Private Function EliminarColumnasDtCompleto(ByVal Dt As DataTable)
        '+++++++++ Elimino las columnas que no voy a utilizar para el reporte +++++++++++++++++
            Dt.Columns.Remove("FEJECUCION")
            Dt.Columns.Remove("ID_SISTEMA")
            Dt.Columns.Remove("ID_EJERCICIO")
            Dt.Columns.Remove("HoraMinutoEliminar")
            Dt.Columns.Remove("DifCPR")
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Return Dt
    End Function

    Private Function AsignarCPRxSoporte(ByVal IdSoporte As Integer) As String

        Dim CPRxSoporte As String

        Select Case IdSoporte
            Case 11
                CPRxSoporte = Me.CPRTelefe
            Case 13
                CPRxSoporte = Me.CPRCanal13
            Case 48
                CPRxSoporte = Me.CPRAmerica
            Case 1870
                CPRxSoporte = Me.CPRCanal9
        End Select


        Return CPRxSoporte
    End Function

#Region "Calculo de CPR Motor"

    Private Function ProcesarDatos(ByVal DtCompleto As DataTable) As DataTable

        Dim HoraMinuto As Integer
        Dim Aviso As Integer = 0

        For Each RowDato As DataRow In DtCompleto.Rows
            If RowDato("Duracion") > 0 Then
                HoraMinuto = CInt(RowDato("HoraMinutoEliminar"))
                RowDato.Item("IdAviso") = Me.CargarPautas(Aviso, RowDato.Item("FEJECUCION"), HoraMinuto, RowDato.Item("Id_Soporte"), RowDato.Item("id_tema"), RowDato.Item("NProgramaFuente"))
            Else
            End If
        Next

        Return DtCompleto

    End Function

    Private Function CargarPautas(ByVal Aviso As Long, ByVal Fecha As Date, ByVal Hora As String, ByVal Canal As Integer, ByVal Tema As String, ByVal Programa As String) As Integer
        Dim P As New Pautas_mp
        Dim Plaza As Integer

        Try
            Dim idSoprote_Ibope As DataRow = dtSoportesIbope.Select("id_soporte = " & Canal)(0)
            If Programa.Length > 19 Then ' La tabla tiene un maxlen de 20
                Programa = Mid(Programa, 1, 19)
            End If
            P.Id = IDnuevo
            P.Fecha = Fecha
            '+++++ Utilizar siempre la fecha del Aviso ++++++++++
            'If Me.TipoMedicion = Medicion.Cuadernillo Then
            'P.Fecha = Fecha
            'Else
            'P.Fecha = getDia(Fecha)
            'End If
            '+++++++++++++++++++++++++++++++++++++++
            P.Hora = Hora
            P.Canal = idSoprote_Ibope("id_ibope")
            P.Programa = Programa
            P.tema = Tema
            P.Plaza = idSoprote_Ibope("plaza")

            P.Agregar()
        Catch e As Exception
            MsgBox(e.Message)
        End Try

        Return P.Aviso

    End Function

    Private Function getDia(ByVal fSpot As Date) As Date

        Dim dia As Date
        ' calcula el dia por diferencia contra el dia de inicio mas chioo de todos los sistemas que mando a evaluar
        dia = CDate(Me.FDesde).AddDays(DateDiff(DateInterval.Day, Me.FHasta, fSpot, FirstDayOfWeek.Monday))
        While dia.DayOfWeek <> fSpot.DayOfWeek ' no va a pasar pero por las dudas si hay algun defasaje, esto lo corregiria
            dia = dia.AddDays(1)
        End While
        getDia = dia

    End Function

#End Region

#Region "Funciones Segundarias"

    Private Function ObtenerColeccionSoporte() As String

        Dim Soportes As String
        Dim SoporteSinComaFinal As String
        Dim i As Integer
        Dim CantCaracteres As Integer
        Dim CantCaracteresObtene As Integer

        For i = 0 To Me.DtDatosAlternativa.Rows.Count - 1
            Soportes += DtDatosAlternativa.Rows(i)("ID_SOPORTE").ToString + ","
        Next

        CantCaracteres = Soportes.Length
        CantCaracteresObtene = Soportes.Length - 2

        SoporteSinComaFinal = Soportes.ToString.Substring(1, CantCaracteresObtene).ToString

        Return SoporteSinComaFinal

    End Function

    Private Function ObtenerAvisosMMS() As DataTable

        Dim ControlMatcheo As New Control_Macheo
        Dim dsAvisos As New DataSet
        Dim dtAvisos As New DataTable
        Dim dr As DataRow
        Dim aviso As New OrdenConfirmada
        Dim lSoportes As New List(Of Integer)
        Dim aSoportes As String()
        Dim resultado As New Dictionary(Of String, List(Of OrdenConfirmada))
        Dim lOrdenes As New List(Of OrdenConfirmada)

        ArmarEstructuraAvisosConfirmados(dtAvisos)

        'Obtengo Datos de MMS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        resultado = ControlMatcheo.ObtenerOrdenesConfirmadasCPR(CInt(Activo.CodCampaniaActualMms), Activo.IDCliente, Me.FDesde, Me.FHasta)
        If resultado Is Nothing Or Not String.IsNullOrEmpty(resultado.Keys(0)) Then
            MessageBox.Show(resultado.Keys(0))
            Exit Function
        End If

        lOrdenes = resultado.Values(0)

        If Not lOrdenes Is Nothing AndAlso lOrdenes.Count > 0 Then
            For Each item As OrdenConfirmada In lOrdenes
                dr = dtAvisos.NewRow
                dr("COD_ORDEN") = item.CodigoOrden.Value
                dr("COD_CONTRATO") = item.CodigoContrato
                dr("COD_PRESUPUESTO") = item.CodigoPresupuesto
                dr("DURACION_REAL") = item.DuracionReal
                dr("FECHAREAL") = item.FechaReal
                dr("HORAREAL") = item.HoraReal
                dr("SEGUNDOREAL") = item.SegundoReal
                dr("NETO_VENTA") = item.Neto
                dr("NUMERO_PEDIDO") = item.NumeroPedido
                dr("DES_PROGRAMA_REAL") = item.ProgramaReal
                dtAvisos.Rows.Add(dr)
            Next
        End If

        Return dtAvisos

    End Function

    Private Sub ArmarEstructuraAvisosConfirmados(ByRef dtOrdenes As DataTable)

        dtOrdenes.Columns.Add("COD_ORDEN", GetType(Integer))
        dtOrdenes.Columns.Add("COD_CONTRATO", GetType(Integer))
        dtOrdenes.Columns.Add("COD_PRESUPUESTO", GetType(Integer))
        dtOrdenes.Columns.Add("DURACION_REAL", GetType(String))
        dtOrdenes.Columns.Add("FECHAREAL", GetType(DateTime))
        dtOrdenes.Columns.Add("HORAREAL", GetType(Integer))
        dtOrdenes.Columns.Add("SEGUNDOREAL", GetType(Integer))
        dtOrdenes.Columns.Add("NETO_VENTA", GetType(Decimal))
        dtOrdenes.Columns.Add("NUMERO_PEDIDO", GetType(String))
        dtOrdenes.Columns.Add("DES_PROGRAMA_REAL", GetType(String))

        dtOrdenes.AcceptChanges()
    End Sub

    Private Function ArmarDtDesglose() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("CodSoporte", GetType(String))
        'Columnas Totales Planificacion ++++++++++++++++++++++
        Dt.Columns.Add("PlaInversionNeta", GetType(String))
        Dt.Columns.Add("PlaGRPS", GetType(String))
        Dt.Columns.Add("PlaDuracionPromedio", GetType(String))
        Dt.Columns.Add("PlaCPRPromedio", GetType(String))
        Dt.Columns.Add("PlaSOIxCanal", GetType(String))
        'Columnas Totales Emitidos +++++++++++++++++++++++++
        Dt.Columns.Add("EmiInversionNeta", GetType(String))
        Dt.Columns.Add("EmiGRPS", GetType(String))
        Dt.Columns.Add("EmiDuracionPromedio", GetType(String))
        Dt.Columns.Add("EmiCPRPromedio", GetType(String))
        Dt.Columns.Add("EmiSOIxCanal", GetType(String))
        'Columnas Totales Campania ++++++++++++++++++++++++
        Dt.Columns.Add("PlaTotalInversionCamp", GetType(String))
        Dt.Columns.Add("PlaTotalGrpsCamp", GetType(String))
        Dt.Columns.Add("PlaTotalDuracionProCamp", GetType(String))
        Dt.Columns.Add("PlaTotalCPRCamp", GetType(String))
        Dt.Columns.Add("PlaTotalSOIxCamp", GetType(String))
        Dt.Columns.Add("EmiTotalInversionCamp", GetType(String))
        Dt.Columns.Add("EmiTotalGrpsCamp", GetType(String))
        Dt.Columns.Add("EmiTotalDuracionProCamp", GetType(String))
        Dt.Columns.Add("EmiTotalCPRCamp", GetType(String))
        Dt.Columns.Add("EmiTotalSOIxCamp", GetType(String))
        'Columnas Totales Diferencia Desgloes +++++++++++++++++
        Dt.Columns.Add("DiferenciaInversion", GetType(String))
        Dt.Columns.Add("DiferenciaGrps", GetType(String))
        Return Dt

    End Function

    Private Function ArmarDtDesgloseSeguimiento() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("TotalOrdenCompra", GetType(String))
        Dt.Columns.Add("DifTotalNetoRealCompra", GetType(String))
        Dt.Columns.Add("PlaTotalPautaCPRPromedio", GetType(String))
        Dt.Columns.Add("EmiTotalPautaCPRPromedio", GetType(String))

        Return Dt

    End Function

    Private Function ArmarDtCPRPromedio() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("PlaAvisos", GetType(String))
        Dt.Columns.Add("PlaDuracion", GetType(String))
        Dt.Columns.Add("PlaTotalDuracion", GetType(String))
        Dt.Columns.Add("EmiAvisos", GetType(String))
        Dt.Columns.Add("EmiDuracion", GetType(String))
        Dt.Columns.Add("EmiTotalDuracion", GetType(String))
        Return Dt

    End Function

    Private Function ArmarDtDurcionPromedioSoporte() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("IdSoporte", GetType(String))
        Dt.Columns.Add("PlaGrps", GetType(String))
        Dt.Columns.Add("PlaDur", GetType(String))
        Dt.Columns.Add("PlaTema", GetType(String))
        Dt.Columns.Add("PlaGrpsPromedio", GetType(String))
        Dt.Columns.Add("PlaDuracionPromedio", GetType(String))
        Dt.Columns.Add("PlaCantAvisos", GetType(String))
        Dt.Columns.Add("PlaTotalInversionSoporte", GetType(String))
        Dt.Columns.Add("PlaCPRFinalSoporte", GetType(String))
        Dt.Columns.Add("EmiGrps", GetType(String))
        Dt.Columns.Add("EmiDur", GetType(String))
        Dt.Columns.Add("EmiTema", GetType(String))
        Dt.Columns.Add("EmiGrpsPromedio", GetType(String))
        Dt.Columns.Add("EmiDuracionPromedio", GetType(String))
        Dt.Columns.Add("EmiCantAvisos", GetType(String))
        Dt.Columns.Add("EmiTotalInversionSoporte", GetType(String))
        Dt.Columns.Add("EmiCPRFinalSoporte", GetType(String))

        Return Dt

    End Function

    Private Function ArmarDtFinalPauta() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("PlaTotalDuracionProCamp", GetType(String))
        Dt.Columns.Add("PlaTotalCPRCamp", GetType(String))
        Dt.Columns.Add("EmiTotalDuracionProCamp", GetType(String))
        Dt.Columns.Add("EmiTotalCPRCamp", GetType(String))

        Return Dt

    End Function

    Private Function ArmarDtCalculoFinalPauta() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("IdSoporte", GetType(String))
        Dt.Columns.Add("PlaGrps", GetType(String))
        Dt.Columns.Add("PlaDur", GetType(String))
        Dt.Columns.Add("PlaTema", GetType(String))
        Dt.Columns.Add("PlaGrpsPromedio", GetType(String))
        Dt.Columns.Add("PlaDuracionPromedio", GetType(String))
        Dt.Columns.Add("PlaCantAvisos", GetType(String))
        Dt.Columns.Add("PlaTotalInversionSoporte", GetType(String))
        Dt.Columns.Add("PlaCPRFinalSoporte", GetType(String))
        Dt.Columns.Add("EmiGrps", GetType(String))
        Dt.Columns.Add("EmiDur", GetType(String))
        Dt.Columns.Add("EmiTema", GetType(String))
        Dt.Columns.Add("EmiGrpsPromedio", GetType(String))
        Dt.Columns.Add("EmiDuracionPromedio", GetType(String))
        Dt.Columns.Add("EmiCantAvisos", GetType(String))
        Dt.Columns.Add("EmiTotalInversionSoporte", GetType(String))
        Dt.Columns.Add("EmiCPRFinalSoporte", GetType(String))

        Return Dt

    End Function

    Private Function EvaluarMotorP(ByVal DtCompleto As DataTable, ByVal IndiceTarget As Integer) As DataTable

        Dim Motor As New MotorP
        Cursor.Current = Cursors.WaitCursor
        Dim PermitirCalcular As Boolean
        Dim DtResultado As New DataTable

        Try
            With Motor
                Select Case IndiceTarget
                    Case 0
                        If Me.IdTarget > -1 Then
                            .Target = Me.IdTarget
                            PermitirCalcular = True
                        End If
                    Case 1
                        If Me.IdTarget2 > 0 Then
                            .Target = Me.IdTarget2 'AG 15/03/2013
                            PermitirCalcular = True
                        End If
                End Select
                .Plaza = 110
                .Sistema = idArchivo
                .Pauta = IDnuevo
                If PermitirCalcular = True Then
                    .Conectar()
                    If .MensajeError <> "" Then
                        'Throw New Exception(.MensajeError)
                        MensajeErrorMotorAudiencia = .MensajeError
                        Return DtCompleto
                    End If
                    Dim Dt As DataTable
                    Dt = .ObtenerPBRxAvisos
                    Dt.TableName = "pbr"
                    Motor.Desconectar()
                    DtResultado = EnlazarDatosAudienicaAvisos(Dt, DtCompleto, IndiceTarget) 'AG 15/03/2013
                End If
                PermitirCalcular = False
                'EnlazarDatosAudienicaAvisos(Dt, DtCompleto)
            End With

            If IndiceTarget = 1 Then
                If Me.IdTarget2 <= 0 Then
                    DtResultado = CargarRating2Nulo(DtCompleto)
                End If
            End If

            Return DtResultado

        Catch ex As Exception
            Motor.Desconectar()
            MsgBox(ex.Message)
            Cursor.Current = Cursors.Default
        End Try



        'Dim Motor As New MotorP
        'Cursor.Current = Cursors.WaitCursor

        'Try
        '    With Motor
        '        .Target = Me.IdTarget
        '        .Plaza = 110
        '        .Sistema = idArchivo
        '        .Pauta = IDnuevo
        '        .Conectar()
        '        If .MensajeError <> "" Then
        '            'Throw New Exception(.MensajeError)
        '            MensajeErrorMotorAudiencia = .MensajeError
        '            Return DtCompleto
        '        End If
        '        Dim Dt As DataTable
        '        Dt = .ObtenerPBRxAvisos
        '        Dt.TableName = "pbr"
        '        Motor.Desconectar()
        '        Return EnlazarDatosAudienicaAvisos(Dt, DtCompleto)
        '    End With

        'Catch ex As Exception
        '    Motor.Desconectar()
        '    MsgBox(ex.Message)
        '    Cursor.Current = Cursors.Default
        'End Try

    End Function

    Private Function CargarRating2Nulo(ByVal DtCompleto As DataTable) As DataTable

        Dim DtResultado As New DataTable

        For Each RowDatosCompletos As DataRow In DtCompleto.Rows
            RowDatosCompletos("RatingRealTarget2") = "0"
        Next

        Return DtCompleto

    End Function

    Private Function EnlazarDatosAudienicaAvisos(ByVal Dt As DataTable, ByVal DtCompleto As DataTable, ByVal IndiceTarget As Integer) As DataTable

        Dim Filas() As DataRow

        For Each RowDatosCompletos As DataRow In DtCompleto.Rows
            If RowDatosCompletos("IdAviso") <> -1 Then
                Filas = Dt.Select("Aviso=" & RowDatosCompletos("IdAviso"))
                If Filas.Length > 0 Then
                    If IndiceTarget = 1 Then 'AG 15/03/2013 Target 2
                        RowDatosCompletos("RatingRealTarget2") = Filas(0)("PBR").ToString
                    ElseIf IndiceTarget = 0 Then 'AG 15/03/2013 Target 1
                        RowDatosCompletos("RatingRealTarget1") = Filas(0)("PBR").ToString
                        RowDatosCompletos("InversionReal") = CStr(RowDatosCompletos("Duracion") * RowDatosCompletos("CprxSoporte") * RowDatosCompletos("RatingRealTarget1"))
                        '++++++++++++++++++++++++++++ TOTALES DE FILAS +++++++++++++++++++++++++++++++++
                        'Calculo Diferencia Diferencia Inversion +++++++++++++++++++++++++++++++++++++++++++++++++++++
                        RowDatosCompletos("DifInversionNeta") = RowDatosCompletos("InversionReal") - RowDatosCompletos("costospot")
                        'Calculo Diferencia Rating +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        RowDatosCompletos("DifRating") = RowDatosCompletos("RatingRealTarget1") - RowDatosCompletos("Rating")   'System.Math.Abs(RowDatosCompletos("RatingRealTarget1") - RowDatosCompletos("Rating"))
                        'Calculo Diferencia Rating Porcentaje +++++++++++++++++++++++++++++++++++++++++++++++++
                        If RowDatosCompletos("Rating") = 0 Then  'Valor del Rating en la Planificacion en Cero Evita Desbordamiento
                            RowDatosCompletos("DifRating%") = "0"  '- (RowDatosCompletos("RatingRealTarget1") / RowDatosCompletos("Rating") - 1) * 100 '(System.Math.Abs((RowDatosCompletos("RatingRealTarget1") / RowDatosCompletos("Rating")) - 1) * 100)
                        Else
                            RowDatosCompletos("DifRating%") = (RowDatosCompletos("RatingRealTarget1") / RowDatosCompletos("Rating") - 1) * 100 '(System.Math.Abs((RowDatosCompletos("RatingRealTarget1") / RowDatosCompletos("Rating")) - 1) * 100)
                        End If
                    End If
                End If
            End If
        Next

        Return DtCompleto

    End Function

    Private Function RecojerDatosTotales(ByVal DtCompleto As DataTable, ByVal DtDesglose As DataTable) As DataTable

        Dim Filas() As DataRow
        Dim PlaCantAvisos, EmiCantAvisos, CantSinAvisos As Integer
        Dim PlaSumDuracion, EmiSumDuracion As Integer
        Dim Canales() As String = {"11", "13", "48", "1870"}
        Dim i As Integer
        Dim j As Integer

            '++++++++++++++++++++ Datos provisorios ++++++++++++++++++++++
            For i = 0 To Canales.Length - 1
                Filas = DtCompleto.Select("id_soporte=" & Canales(i))
                If Filas.Length > 0 Then
                    For j = 0 To Filas.Length - 1
                        '++++++++++++ Obtengo datos de Identificacion de Error +++++++++++++++++++
                        ErrorNombrePrograma = Filas(j)("programa").ToString
                        ErrorNroOrden = Filas(j)("id_orden_sigeme").ToString
                        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        If Filas(j)("IdAviso") = -1 Then
                            CantSinAvisos += 1
                        Else
                            EmiCantAvisos += 1
                        End If
                        PlaCantAvisos += 1
                        PlaSumDuracion += Double.Parse(Filas(j)("Dur").ToString)
                        EmiSumDuracion += Double.Parse(Filas(j)("Duracion").ToString)
                        '++++++++++++++++ Datos Planificacion +++++++++++++++++++++++++++++
                    'AG 08/04/2013 Sin redondeos +++++++++++++++++++++++++++++++++++++
                    PlaInversionNeta += Double.Parse(Filas(j)("CostoSpot").ToString)
                    PlaGRPS += Double.Parse(Filas(j)("Rating").ToString)
                    'AG Datos con Redondeo de Decimale ++++++++++++++++++++++++++++++++
                    'PlaInversionNeta += Math.Round(Double.Parse(Filas(j)("CostoSpot").ToString), 2)
                    'PlaGRPS += Math.Round(Double.Parse(Filas(j)("Rating").ToString), 2)
                    '++++++++++++ Emitidos +++++++++++++++++++++++++++++++++++++++++
                        EmiInversionNeta += Math.Round(Double.Parse(Filas(j)("InversionReal").ToString), 2)
                        EmiGRPS += Math.Round(Double.Parse(Filas(j)("RatingRealTarget1").ToString), 2)
                    Next
                '++++++++++++ Calculos Planificacion ++++++++++++++++++++++
                'AG 08/04/2013  Sin redondeos +++++++++++++++++++++++++++++++++
                PlaDuracionPromedio = PlaSumDuracion / PlaCantAvisos
                PlaCPRPromedio = PlaInversionNeta / PlaGRPS / PlaDuracionPromedio
                'AG Datos con Redondeo de Decimale ++++++++++++++++++++++++++++++++
                'PlaDuracionPromedio = Math.Round(PlaSumDuracion / PlaCantAvisos, 2)
                'PlaCPRPromedio = Math.Round(PlaInversionNeta / PlaGRPS / PlaDuracionPromedio, 2)
                    '++++++++++++ Calculos Emitidos +++++++++++++++++++++++++
                    EmiCantAvisos = EmiCantAvisos '- CantSinAvisos
                    If EmiCantAvisos > 0 Then
                        EmiDuracionPromedio = Math.Round(EmiSumDuracion / EmiCantAvisos, 2)
                        EmiCPRPromedio = Math.Round(EmiInversionNeta / EmiGRPS / EmiDuracionPromedio, 2)
                    Else
                        EmiDuracionPromedio = 0
                        EmiCPRPromedio = 0
                    End If
                End If
                If Filas.Length > 0 Then
                    If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Then ' Cliente Claro
                        PlaCPRPromedio = PlaCPRPromedio
                        EmiCPRPromedio = EmiCPRPromedio
                Else
                    PlaCPRPromedio = PlaCPRPromedio
                    EmiCPRPromedio = EmiCPRPromedio
                    '++++++++ Codigo Anterior +++++++++++++++
                    'PlaCPRPromedio = CStr(CInt(PlaCPRPromedio))
                    'EmiCPRPromedio = CStr(CInt(EmiCPRPromedio))
                    '+++++++++++++++++++++++++++++++++++
                End If
                    DtDesglose = AnexarFilaDesglose(DtDesglose, CInt(Canales(i)), PlaInversionNeta, PlaGRPS, PlaDuracionPromedio, PlaCPRPromedio, PlaSOIxCanal, EmiInversionNeta, EmiGRPS, EmiDuracionPromedio, EmiCPRPromedio, EmiSOIxCanal)
                    '+++++ Limpo las variables +++++++++++
                    CantSinAvisos = 0
                    PlaCantAvisos = 0
                    EmiCantAvisos = 0
                    '++++++ Planificados +++++++
                    PlaSumDuracion = 0
                    PlaInversionNeta = 0
                    PlaGRPS = 0
                    PlaDuracionPromedio = 0
                    PlaCPRPromedio = 0
                    PlaSOIxCanal = 0
                    '+++++++ Emitidos ++++++++
                    EmiSumDuracion = 0
                    EmiInversionNeta = 0
                    EmiGRPS = 0
                    EmiDuracionPromedio = 0
                    EmiCPRPromedio = 0
                    EmiSOIxCanal = 0
                End If
            Next

            DtDesglose = CalcularSOI(DtDesglose)
            DtDesglose = FilasTotales(DtDesglose, DtCompleto)

            Return DtDesglose

    End Function

    Private Function AnexarFilaDesglose(ByVal DtDesglose As DataTable, ByVal CodSoporte As Integer, ByVal PlaInversionNeta As Double, ByVal PlaGRPS As Double, ByVal PlaDuracionPromedio As Double, ByVal PlaCPRPromedio As Double, ByVal PlaSOIxCanal As Double, ByVal EmiInversionNeta As Double, ByVal EmiGRPS As Double, ByVal EmiDuracionPromedio As Double, ByVal EmiCPRPromedio As Double, ByVal EmiSOIxCanal As Double) As DataTable

        Dim Dr As DataRow

        Dr = DtDesglose.NewRow
        Dr("CodSoporte") = CodSoporte
        'AG 08/04/2013 Sin Redondeo +++++++++++++++++++++++++++++++
        Dr("PlaInversionNeta") = Double.Parse(PlaInversionNeta)
        Dr("PlaGRPS") = Double.Parse(PlaGRPS)
        'AG Datos con redondeo de decimales +++++++++++++++++++++++++
        'Dr("PlaInversionNeta") = Math.Round(Double.Parse(PlaInversionNeta), 2)
        'Dr("PlaGRPS") = Math.Round(Double.Parse(PlaGRPS), 2)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++
        Dr("PlaDuracionPromedio") = PlaDuracionPromedio
        Dr("PlaCPRPromedio") = PlaCPRPromedio
        Dr("EmiInversionNeta") = Math.Round(EmiInversionNeta, 2)
        Dr("EmiGRPS") = Math.Round(EmiGRPS, 2)
        Dr("EmiDuracionPromedio") = EmiDuracionPromedio
        Dr("EmiCPRPromedio") = EmiCPRPromedio
        DtDesglose.Rows.Add(Dr)

        Return DtDesglose

    End Function

    Private Function CalcularSOI(ByVal DtDesglose As DataTable) As DataTable

        Dim PlanTotalInversion As Double
        Dim EmiTotalInversion As Double
        Dim Dr As DataRow

            For Each Dr In DtDesglose.Rows
                PlanTotalInversion += Math.Round(Double.Parse(Dr("PlaInversionNeta")), 2)
                EmiTotalInversion += Math.Round(Double.Parse(Dr("EmiInversionNeta")), 2)
            Next

            For Each Dr In DtDesglose.Rows
                Dr("PlaSOIxCanal") = CStr(Math.Round(((Dr("PlaInversionNeta") * 100) / PlanTotalInversion), 2)) + "%"
                '++++++++++ Control por si no existen avisos macheados del lado de MMS ++++++++++++++++++++++
                If CInt(Dr("EmiInversionNeta")) = 0 And EmiTotalInversion = 0 Then
                    Dr("EmiSOIxCanal") = "0" + " %"
                Else
                    Dr("EmiSOIxCanal") = CStr(Math.Round(((Dr("EmiInversionNeta") * 100) / EmiTotalInversion), 2)) + " %"
                End If
            Next

            TotalInversionNetaCompleta = EmiTotalInversion

            Return DtDesglose

    End Function

    Private Function RecojerDatosSeguimiento(ByVal DtDesglose As DataTable, ByVal DtDesgloseSeguimiento As DataTable, ByVal DtCompletoFinal As DataTable) As DataTable

        Dim DtCPRPromedio As DataTable
        Dim Dr As DataRow

        Dr = DtDesgloseSeguimiento.NewRow

        Dr("TotalOrdenCompra") = Me.ImporteTV
        Dr("DifTotalNetoRealCompra") = Math.Round(TotalInversionNetaCompleta - Double.Parse(Dr("TotalOrdenCompra")), 2)

        DtDesgloseSeguimiento.Rows.Add(Dr)

        DtCPRPromedio = RecogerDatosCPRPromedio(DtCompletoFinal)

        DtDesgloseSeguimiento = CalcularCPRPromedioPautaCompleta(DtCompletoFinal, DtDesglose, DtDesgloseSeguimiento, DtCPRPromedio)

        TotalInversionNetaCompleta = 0

        Return DtDesgloseSeguimiento

    End Function

    Private Function RecogerDatosCPRPromedio(ByVal DtCompletoFinal As DataTable) As DataTable

        Dim DtCPRPromedio As New DataTable
        Dim Filas(), EmiSinAvisos() As DataRow
        Dim Dt As New DataTable
        Dim Dr As DataRow
        Dim EmiAvisosCant As Integer
        Dim EmiDuracion As String
        Dim i As Integer

        Dt = DtCompletoFinal.DefaultView.ToTable(True, "ID_TEMA", "Dur")
        DtCPRPromedio = ArmarDtCPRPromedio()

        For Each RowDatos As DataRow In Dt.Rows
            Filas = DtCompletoFinal.Select("ID_TEMA='" & RowDatos("ID_TEMA").ToString & "'")
            If Filas.Length > 0 Then
                Dr = DtCPRPromedio.NewRow
                '+++++++++++++++++++++++ Planificado +++++++++++++++++++++++
                Dr("PlaAvisos") = Filas.Count
                Dr("PlaDuracion") = Filas(0)("Dur")
                Dr("PlaTotalDuracion") = CStr(CInt(Dr("PlaAvisos")) * Double.Parse(Dr("PlaDuracion")))
                '+++++++++++++++++++++++ Emitidos +++++++++++++++++++++++
                EmiAvisosCant = 0
                EmiDuracion = ""
                For i = 0 To Filas.Length - 1
                    If Filas(i)("IdAviso") > -1 Then
                        EmiAvisosCant += 1
                        EmiDuracion = Filas(i)("Duracion").ToString
                    End If
                Next
                Dr("EmiAvisos") = EmiAvisosCant
                If EmiDuracion = "" Then
                    Dr("EmiDuracion") = 0
                Else
                    Dr("EmiDuracion") = EmiDuracion
                End If
                Dr("EmiTotalDuracion") = CStr(CInt(Dr("EmiAvisos")) * Double.Parse(Dr("EmiDuracion")))
                DtCPRPromedio.Rows.Add(Dr)
            End If
        Next

        Return DtCPRPromedio

    End Function

    Private Function CalcularCPRPromedioPautaCompleta(ByVal DtCompletoFinal As DataTable, ByVal DtDesglose As DataTable, ByVal DtDesgloseSeguimiento As DataTable, ByVal DtCPRPromedio As DataTable) As DataTable

        Dim PlaSegundoPromedio, EmiSegundoPromedio As Double
        Dim PlaTotalGrps, EmiTotalGrps As Double
        Dim PlaTotalAvisos, EmiTotalAvisos As Double
        Dim PlaTolalSegundos, EmiTolalSegundos As Double
        Dim PlaTotalCPRPromedio, EmiTotalCPRPromedio As Double
        Dim PlaTolalInversion, EmiTolalInversion As Double

        For Each RowSegundos As DataRow In DtCPRPromedio.Rows
            '+++++++++++++++++++++++ Planificado +++++++++++++++++++++++
            PlaTolalSegundos += Double.Parse(RowSegundos("PlaTotalDuracion"))
            PlaTotalAvisos += CInt(RowSegundos("PlaAvisos"))
            '+++++++++++++++++++++++ Emitidos ++++++++++++++++++++++++
            EmiTolalSegundos += Double.Parse(RowSegundos("EmiTotalDuracion"))
            EmiTotalAvisos += CInt(RowSegundos("EmiAvisos"))
        Next

        '++++++ Calculo el Seg Promedio de Planificado y Emitido +++++++++++++++
        PlaSegundoPromedio = PlaTolalSegundos / PlaTotalAvisos

        '++++++++++ Control por si no existen avisos macheados del lado de MMS ++++++++++++++++++++++
        If EmiTolalSegundos = 0 And EmiTotalAvisos = 0 Then
            EmiSegundoPromedio = 0 ' Si no hay avisos del lado de MMS coloco todos los valores en CERO ( 0 ) para que no pinche los calculos de di
        Else
            EmiSegundoPromedio = EmiTolalSegundos / EmiTotalAvisos
        End If

        For Each RowGrps As DataRow In DtDesglose.Rows
            '+++++++++++++++++++++++ Planificado +++++++++++++++++++++++
            PlaTotalGrps += Double.Parse(RowGrps("PlaGRPS"))
            '+++++++++++++++++++++++ Emitidos ++++++++++++++++++++++++
            EmiTotalGrps += Double.Parse(RowGrps("EmiGRPS"))
        Next

        For Each RowInversion As DataRow In DtCompletoFinal.Rows
            '+++++++++++++++++++++++ Planificado +++++++++++++++++++++++
            PlaTolalInversion += Double.Parse(RowInversion("CostoSpot"))
            '+++++++++++++++++++++++ Emitidos ++++++++++++++++++++++++
            EmiTolalInversion += Double.Parse(RowInversion("InversionReal"))
        Next

        '+++++++++++++++++++ Calculo el CPR Promedio de Planificado y Emitido +++++++++++++++++
        PlaTotalCPRPromedio = Math.Round((PlaTolalInversion / PlaTotalGrps / PlaSegundoPromedio), 2)
        '++++++++++ Control por si no existen avisos macheados del lado de MMS ++++++++++++++++++++++
        If EmiTolalInversion = 0 And EmiTotalGrps = 0 And EmiSegundoPromedio = 0 Then
            EmiTotalCPRPromedio = 0
        ElseIf EmiSegundoPromedio = 0 Then
            EmiTotalCPRPromedio = 0
        ElseIf EmiTotalGrps = 0 Then
            EmiTotalCPRPromedio = 0
        ElseIf EmiTolalInversion = 0 Then
            EmiTotalCPRPromedio = 0
        Else
            EmiTotalCPRPromedio = Math.Round((EmiTolalInversion / EmiTotalGrps / EmiSegundoPromedio), 2)
        End If

        '++++++++++ Estos calculos estan mal por ese motivo no se asigan nada y se comenta las 5 lineas de codigo +++++++++++++++
        'For Each RowFinal As DataRow In DtDesgloseSeguimiento.Rows
        '    '+++++++++++++++++++++++ Planificado +++++++++++++++++++++++
        '    RowFinal("PlaTotalPautaCPRPromedio") = PlaTotalCPRPromedio.ToString
        '    '+++++++++++++++++++++++ Emitidos ++++++++++++++++++++++++
        '    RowFinal("EmiTotalPautaCPRPromedio") = EmiTotalCPRPromedio.ToString
        'Next


        'AG 14/01/2013 +++++++++++++++++++++++++++++
        'Piso el calculo anterior debido a que no esta bien calculado. El calculo correcto lo traigo ya calculado del DtDeglose
        For Each RowFinal As DataRow In DtDesgloseSeguimiento.Rows
            '+++++++++++++++++++++++ Planificado +++++++++++++++++++++++
            RowFinal("PlaTotalPautaCPRPromedio") = DtDesglose.Rows(0)("PlaTotalCPRCamp").ToString
            '+++++++++++++++++++++++ Emitidos ++++++++++++++++++++++++
            RowFinal("EmiTotalPautaCPRPromedio") = DtDesglose.Rows(0)("EmiTotalCPRCamp").ToString
        Next

        '++++++++++++++++++++++++++++++++++++++++

        Return DtDesgloseSeguimiento

    End Function

    Private Enum Medicion
        PeopleMeter = 1
        Cuadernillo = 2
        Ninguna = 3
    End Enum

    Private Function FilasTotales(ByVal DtDesglose As DataTable, ByVal DtCompletoFinal As DataTable) As DataTable

        Dim PlaTotalInversionCamp, PlaTotalGrpsCamp, PlaTotalDuracionProCamp, PlaTotalCPRCamp, PlaTotalSOIxCamp As Double
        Dim EmiTotalInversionCamp, EmiTotalGrpsCamp, EmiTotalDuracionProCamp, EmiTotalCPRCamp, EmiTotalSOIxCamp As Double
        Dim TotalInversionDiferencia, TotalGrpsDiferencia As Double
        Dim i As Integer
        Dim Rows, Dr As DataRow
        Dim CantiFilas As Integer
        Dim DtDesgloseFinal As New DataTable
        Dim DtResultadoCPRPromedio As New DataTable
        Dim DtResultadoFinalPautaCPR As New DataTable

        'AG 09/01/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        DtResultadoCPRPromedio = ObtenerDtDuracionPromedioSoporte(DtCompletoFinal, DtDesglose)
        Dim f As Integer
        Dim RowSop() As DataRow
        Dim Row() As DataRow

        'Piso o Actualizo los valores nuevos con los nuevos calculos +++++++++++++++++++++++++++++++++++
        For f = 0 To SoporteTvAbierta.Length - 1
            RowSop = DtResultadoCPRPromedio.Select("idsoporte='" & SoporteTvAbierta(f) & "'")
            If RowSop.Length > 0 Then
                Row = DtDesglose.Select("codsoporte='" & SoporteTvAbierta(f) & "'")
                If Row.Length > 0 Then
                    Row(0)("PlaCPRPromedio") = RowSop(0)("PlaCPRFinalSoporte")
                    Row(0)("PlaDuracionPromedio") = RowSop(0)("PlaDuracionPromedio")
                    Row(0)("PlaGRPS") = RowSop(0)("PlaGrps")
                    Row(0)("PlaInversionNeta") = RowSop(0)("PlaTotalInversionSoporte")
                    Row(0)("EmiCPRPromedio") = RowSop(0)("EmiCPRFinalSoporte")
                    Row(0)("EmiDuracionPromedio") = RowSop(0)("EmiDuracionPromedio")
                    Row(0)("EmiGRPS") = RowSop(0)("EmiGrps")
                    Row(0)("EmiInversionNeta") = RowSop(0)("EmiTotalInversionSoporte")
                End If
            End If
        Next

        DtDesglose = CalcularSOI(DtDesglose) 'Vuelvo a recalcular el valor de SOI

        'Obtengo los calculos Finales de la fila Totales ++++++++++++++++++++++++
        DtResultadoFinalPautaCPR = ObtenerDtFinalPautaPromedioCPR_Duracion(DtCompletoFinal, DtDesglose)

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        For Each Rows In DtDesglose.Rows
            '+++++++++++++++++ Totales Planificado +++++++++++++++++++
            PlaTotalInversionCamp += Double.Parse(Rows("PlaInversionNeta").ToString)
            PlaTotalGrpsCamp += Double.Parse(Rows("PlaGRPS").ToString)
            PlaTotalCPRCamp += Double.Parse(Rows("PlaCPRPromedio").ToString)
            PlaTotalSOIxCamp += Double.Parse(Rows("PlaSOIxCanal").ToString.Replace("%", ""))
            '+++++++++++++++++ Totales Emitidos +++++++++++++++++++
            EmiTotalInversionCamp += Double.Parse(Rows("EmiInversionNeta").ToString)
            EmiTotalGrpsCamp += Double.Parse(Rows("EmiGRPS").ToString)
            EmiTotalCPRCamp += Double.Parse(Rows("EmiCPRPromedio").ToString)
            EmiTotalSOIxCamp += Double.Parse(Rows("EmiSOIxCanal").ToString.Replace("%", ""))
        Next

        '+++++++++++++++++++++++++++++ NO se utiliza este calculo +++++++++++++++++++++++++++++++++++++
        'PlaTotalDuracionProCamp = Math.Round(Double.Parse(RecogerDuracionPromedioCampanias(DtCompletoFinal, 0)), 2)
        'EmiTotalDuracionProCamp = Math.Round(Double.Parse(RecogerDuracionPromedioCampanias(DtCompletoFinal, 1)), 2)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        CantiFilas = DtDesglose.Rows.Count

        For Each Rows In DtDesglose.Rows
            '+++++++++++++++++ Totales Planificado +++++++++++++++++++
            Rows("PlaTotalInversionCamp") = PlaTotalInversionCamp.ToString
            Rows("PlaTotalGrpsCamp") = PlaTotalGrpsCamp.ToString
            Rows("PlaTotalDuracionProCamp") = DtResultadoFinalPautaCPR.Rows(0)("PlaTotalDuracionProCamp").ToString   'PlaTotalDuracionProCamp.ToString
            Rows("PlaTotalCPRCamp") = DtResultadoFinalPautaCPR.Rows(0)("PlaTotalCPRCamp").ToString 'Math.Round(Double.Parse(Rows("PlaTotalInversionCamp").ToString) / Double.Parse(Rows("PlaTotalGrpsCamp").ToString) / Double.Parse(Rows("PlaTotalDuracionProCamp").ToString), 2)
            Rows("PlaTotalSOIxCamp") = PlaTotalSOIxCamp.ToString + " %"
            '+++++++++++++++++ Totales Emitidos ++++++++++++++++++++
            Rows("EmiTotalInversionCamp") = EmiTotalInversionCamp.ToString
            Rows("EmiTotalGrpsCamp") = EmiTotalGrpsCamp.ToString
            Rows("EmiTotalDuracionProCamp") = DtResultadoFinalPautaCPR.Rows(0)("EmiTotalDuracionProCamp").ToString 'EmiTotalDuracionProCamp.ToString
            Rows("EmiTotalCPRCamp") = DtResultadoFinalPautaCPR.Rows(0)("EmiTotalCPRCamp").ToString 'Math.Round(Double.Parse(Rows("EmiTotalInversionCamp").ToString) / Double.Parse(Rows("EmiTotalGrpsCamp").ToString) / Double.Parse(Rows("EmiTotalDuracionProCamp").ToString), 2)
            Rows("EmiTotalSOIxCamp") = EmiTotalSOIxCamp.ToString + " %"
            Exit For
        Next

        '+++++++++++++ Calculo de Diferencia de Inversion y Grps Desglose +++++++++++
        For Each Rows In DtDesglose.Rows
            Rows("DiferenciaInversion") = Double.Parse(Rows("EmiInversionNeta").ToString) - Double.Parse(Rows("PlaInversionNeta").ToString)
            Rows("DiferenciaGrps") = Double.Parse(Rows("EmiGRPS").ToString) - Double.Parse(Rows("PlaGRPS").ToString)
            TotalInversionDiferencia += Double.Parse(Rows("DiferenciaInversion").ToString)
            TotalGrpsDiferencia += Double.Parse(Rows("DiferenciaGrps").ToString)
        Next

        Return DtDesglose

    End Function

    Private Function ObtenerDtDuracionPromedioSoporte(ByVal DtCompleto As DataTable, ByVal DtDesglose As DataTable) As DataTable

        Dim DrSoporteTema As DataRow()
        Dim DrSoporteResumen As DataRow()
        Dim DrSoporte As DataRow()
        Dim Dr, DrTemas As DataRow
        Dim i, u As Integer
        Dim FilaNueva As DataRow
        Dim PlaTotalGrps, EmiTotalGrps As Double
        Dim PlaTotalGrpsSoporte, EmiTotalGrpsSoporte As Double
        Dim PlaCantAvisos, EmiCantAvisos As Integer
        Dim PlaTemaDuracion, EmiTemaDuracion As Integer
        Dim PlaTema, EmiTema As String
        Dim IdSoporte As Integer
        Dim AgregarFila As Boolean = False

        DtTemasAplicados = DtCompleto.DefaultView.ToTable(True, "ID_TEMA")
        DtDuracionPromediaSoporte = ArmarDtDurcionPromedioSoporte()

        For i = 0 To SoporteTvAbierta.Length - 1
            For Each DrTemas In DtTemasAplicados.Rows
                'Filtro por Soporte y Tema oara Sumarizar Grps aplicados a cada TEMA ++++++++++++++++++++++++++++++++++++
                DrSoporteTema = DtCompleto.Select("id_soporte=" & SoporteTvAbierta(i) & " and ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                If DrSoporteTema.Length > 0 Then
                    For u = 0 To DrSoporteTema.Length - 1
                        IdSoporte = DrSoporteTema(u)("ID_SOPORTE").ToString.Trim
                        PlaTotalGrps += CDbl(DrSoporteTema(u)("Rating"))
                        PlaTemaDuracion = CInt(DrSoporteTema(u)("DUR"))
                        PlaTema = DrSoporteTema(u)("ID_TEMA").ToString
                        PlaCantAvisos = DrSoporteTema.Length
                        EmiTotalGrps += CDbl(DrSoporteTema(u)("RatingRealTarget1"))
                        If CInt(DrSoporteTema(u)("Duracion")) = 0 Then
                            EmiTemaDuracion = CInt(DrSoporteTema(u)("DUR"))
                        Else
                            EmiTemaDuracion = CInt(DrSoporteTema(u)("Duracion"))
                        End If
                        EmiTema = DrSoporteTema(u)("ID_TEMA").ToString
                        EmiCantAvisos = DrSoporteTema.Length
                    Next
                    'Añado los nuevos datos al Datatable nuevo +++++++++++++++++++++++
                    FilaNueva = DtDuracionPromediaSoporte.NewRow
                    FilaNueva("IdSoporte") = IdSoporte
                    FilaNueva("PlaGrps") = PlaTotalGrps
                    FilaNueva("PlaDur") = PlaTemaDuracion
                    FilaNueva("PlaTema") = PlaTema
                    FilaNueva("PlaCantAvisos") = CStr(PlaCantAvisos)
                    FilaNueva("EmiGrps") = EmiTotalGrps
                    FilaNueva("EmiDur") = EmiTemaDuracion
                    FilaNueva("EmiTema") = EmiTema
                    FilaNueva("EmiCantAvisos") = CStr(EmiCantAvisos)
                    DtDuracionPromediaSoporte.Rows.Add(FilaNueva)
                    PlaTotalGrps = 0
                    PlaTemaDuracion = 0
                    PlaTema = ""
                    PlaCantAvisos = 0
                    EmiTotalGrps = 0
                    EmiTemaDuracion = 0
                    EmiTema = ""
                    EmiCantAvisos = 0
                End If
            Next
        Next

        'Limpio y Blanqueo las variables empleadas +++++++++++++++++++++++
        PlaTotalGrps = 0
        PlaTemaDuracion = 0
        PlaTema = ""
        PlaCantAvisos = 0
        EmiTotalGrps = 0
        EmiTemaDuracion = 0
        EmiTema = ""
        EmiCantAvisos = 0


        For i = 0 To SoporteTvAbierta.Length - 1
            DrSoporteResumen = DtDuracionPromediaSoporte.Select("idsoporte='" & SoporteTvAbierta(i) & "'")
            If DrSoporteResumen.Length > 0 Then
                For u = 0 To DrSoporteResumen.Length - 1
                    'Sumo los Grps de cada soporte para obtener el valor total de GRPS aplicados en la Pauta ( Planificadios y Emitidos )
                    PlaTotalGrps += CDbl(DrSoporteResumen(u)("PlaGrps"))
                    EmiTotalGrps += CDbl(DrSoporteResumen(u)("EmiGrps"))
                Next
                For Each DrTemas In DtTemasAplicados.Rows
                    'Calculo el promedio de Grps por tema dentro de cada soporte con el total de Grps del soporte en Planificacion
                    DrSoporte = DtDuracionPromediaSoporte.Select("idsoporte='" & SoporteTvAbierta(i) & "' and PlaTema='" & DrTemas("ID_TEMA") & "'")
                    If DrSoporte.Length > 0 Then
                        DrSoporte(0)("PlaGrpsPromedio") = CStr(DrSoporte(0)("PlaGrps") / PlaTotalGrps)
                        DrSoporte(0)("PlaDuracionPromedio") = CStr(DrSoporte(0)("PlaGrpsPromedio") * DrSoporte(0)("PlaDur"))
                    End If
                Next
                PlaTotalGrps = 0
                For Each DrTemas In DtTemasAplicados.Rows
                    'Calculo el promedio de Grps por tema dentro de cada soporte con el total de Grps del soporte en Emitidos
                    DrSoporte = DtDuracionPromediaSoporte.Select("idsoporte='" & SoporteTvAbierta(i) & "' and EmiTema='" & DrTemas("ID_TEMA") & "'")
                    If DrSoporte.Length > 0 Then
                        DrSoporte(0)("EmiGrpsPromedio") = CStr(DrSoporte(0)("EmiGrps") / EmiTotalGrps)
                        DrSoporte(0)("EmiDuracionPromedio") = CStr(DrSoporte(0)("EmiGrpsPromedio") * DrSoporte(0)("EmiDur"))
                    End If
                Next
                EmiTotalGrps = 0
            End If
        Next

        '++++++++ Clone la estructura del DtDuracionPromedioSoporte para unificar los valores por soporte y sumarizar sus valores ++++++++

        Dim DtSoportesUnificadosDurProm As New DataTable
        Dim DrSoportes() As DataRow
        Dim Drs() As DataRow
        Dim PlaTotalAvisos, EmiTotalAvisos As Integer
        Dim PlaTotalGrpsPromedio, PlaTotalDuracionPromedio, EmiTotalGrpsPromedio, EmiTotalDuracionPromedio As Double
        DtSoportesUnificadosDurProm = DtDuracionPromediaSoporte.Clone

        For i = 0 To SoporteTvAbierta.Length - 1
            PlaTotalGrps = 0
            PlaCantAvisos = 0
            PlaTotalGrpsPromedio = 0
            PlaTotalDuracionPromedio = 0
            EmiCantAvisos = 0
            EmiTotalGrps = 0
            EmiTotalGrpsPromedio = 0
            EmiTotalDuracionPromedio = 0
            DrSoportes = DtDuracionPromediaSoporte.Select("idsoporte='" & SoporteTvAbierta(i) & "'")
            If DrSoportes.Length > 0 Then
                For u = 0 To DrSoportes.Length - 1
                    IdSoporte = DrSoportes(u)("IdSoporte")
                    PlaTotalGrps += CDbl(DrSoportes(u)("PlaGrps"))
                    PlaTemaDuracion = "0"
                    PlaTema = "Null"
                    PlaCantAvisos += CDbl(DrSoportes(u)("PlaCantAvisos"))
                    PlaTotalGrpsPromedio += CDbl(DrSoportes(u)("PlaGrpsPromedio"))
                    PlaTotalDuracionPromedio += CDbl(DrSoportes(u)("PlaDuracionPromedio"))
                    EmiTotalGrps += CDbl(DrSoportes(u)("EmiGrps"))
                    EmiTemaDuracion = "0"
                    EmiTema = "Null"
                    EmiCantAvisos += CDbl(DrSoportes(u)("EmiCantAvisos"))
                    EmiTotalGrpsPromedio += CDbl(DrSoportes(u)("EmiGrpsPromedio"))
                    EmiTotalDuracionPromedio += CDbl(DrSoportes(u)("EmiDuracionPromedio"))
                Next
                FilaNueva = DtSoportesUnificadosDurProm.NewRow
                FilaNueva("IdSoporte") = IdSoporte
                FilaNueva("PlaGrps") = PlaTotalGrps
                FilaNueva("PlaDur") = PlaTemaDuracion
                FilaNueva("PlaTema") = ""
                FilaNueva("PlaCantAvisos") = PlaCantAvisos
                FilaNueva("PlaGrpsPromedio") = PlaTotalGrpsPromedio
                FilaNueva("PlaDuracionPromedio") = PlaTotalDuracionPromedio
                FilaNueva("EmiGrps") = EmiTotalGrps
                FilaNueva("EmiDur") = EmiTemaDuracion
                FilaNueva("EmiTema") = ""
                FilaNueva("EmiCantAvisos") = EmiCantAvisos
                FilaNueva("EmiGrpsPromedio") = EmiTotalGrpsPromedio
                FilaNueva("EmiDuracionPromedio") = EmiTotalDuracionPromedio
                DtSoportesUnificadosDurProm.Rows.Add(FilaNueva)
            End If
        Next

        '++++++++++++++++++++++++++++++++++++ Calculo Final CPR X soporte total ++++++++++++++++++++++++++++++++++++++++
        Dim DrSopInversion() As DataRow
        Dim DrSopFinal() As DataRow
        Dim e As Integer

        For e = 0 To SoporteTvAbierta.Length - 1
            DrSopInversion = DtDesglose.Select("codsoporte='" & SoporteTvAbierta(e) & "'")
            If DrSopInversion.Length > 0 Then
                DrSopFinal = DtSoportesUnificadosDurProm.Select("idsoporte='" & SoporteTvAbierta(e) & "'")
                If DrSopFinal.Length > 0 Then
                    DrSopFinal(0)("PlaTotalInversionSoporte") = DrSopInversion(0)("PlaInversionNeta")
                    DrSopFinal(0)("EmiTotalInversionSoporte") = DrSopInversion(0)("EmiInversionNeta")
                    'Calculo el CPR Final por cada soporte de acuerdo a su inversion correspondiente ++++++++++++++++++++++++++++++++
                    'AG 08/04/2013 Sin redondeo +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    DrSopFinal(0)("PlaCPRFinalSoporte") = CStr(DrSopFinal(0)("PlaTotalInversionSoporte") / DrSopFinal(0)("PlaGrps") / DrSopFinal(0)("PlaDuracionPromedio"))
                    'AG 08/04/2013 Datos con redondeos de decimales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    'DrSopFinal(0)("PlaCPRFinalSoporte") = CStr(Math.Round(DrSopFinal(0)("PlaTotalInversionSoporte") / DrSopFinal(0)("PlaGrps") / DrSopFinal(0)("PlaDuracionPromedio"), 2))
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    DrSopFinal(0)("EmiCPRFinalSoporte") = CStr(Math.Round(DrSopFinal(0)("EmiTotalInversionSoporte") / DrSopFinal(0)("EmiGrps") / DrSopFinal(0)("EmiDuracionPromedio"), 2))
                End If
            End If
        Next

        Return DtSoportesUnificadosDurProm

    End Function

    Private Function ObtenerDtFinalPautaPromedioCPR_Duracion(ByVal DtFinal As DataTable, ByVal DtDesglose As DataTable)

        Dim i, u As Integer
        Dim PlaTotalGrps, EmiTotalGrps As Double
        Dim PlaTotalGrpsSoporte, EmiTotalGrpsSoporte As Double
        Dim PlaCantAvisos, EmiCantAvisos As Integer
        Dim PlaTemaDuracion, EmiTemaDuracion As Integer
        Dim PlaTema, EmiTema As String
        Dim IdSoporte As Integer
        Dim DrTemas As DataRow
        Dim DrTemasGrps As DataRow
        Dim FilaNueva As DataRow
        Dim DrTema() As DataRow
        Dim PlaTotalGRPSPauta, EmiTotalGRPSPauta As Double
        Dim DtFinalPauta As New DataTable

        DtTemasAplicados = DtFinal.DefaultView.ToTable(True, "ID_TEMA")
        DtCalculoFinalPauta = ArmarDtCalculoFinalPauta()

        For Each DrTemas In DtTemasAplicados.Rows
            DrTema = DtFinal.Select("ID_TEMA='" & DrTemas("ID_TEMA") & "'")
            If DrTema.Length > 0 Then
                For u = 0 To DrTema.Length - 1
                    PlaTotalGrps += CDbl(DrTema(u)("Rating"))
                    PlaTemaDuracion = CInt(DrTema(u)("DUR"))
                    PlaTema = DrTema(u)("ID_TEMA").ToString
                    PlaCantAvisos = DrTema.Length
                    EmiTotalGrps += CDbl(DrTema(u)("RatingRealTarget1"))
                    'AG En caso de que LOS INTELIGENTES USUARIOS NO HICIERON SU TRABAJO ALGO TAN SIMPLE COMO MACHEARRRRRRRR CARAJOO pd: A prueba de boludossssss!!
                    If CInt(DrTema(u)("Duracion")) = 0 Then
                        EmiTemaDuracion = CInt(DrTema(u)("DUR"))
                    Else
                        EmiTemaDuracion = CInt(DrTema(u)("Duracion"))
                    End If
                    EmiTema = DrTema(u)("ID_TEMA").ToString
                    EmiCantAvisos = DrTema.Length
                    'Sumo Gprs para el total Grps de la pauta +++++++++++++
                    PlaTotalGRPSPauta += CDbl(DrTema(u)("Rating"))
                    EmiTotalGRPSPauta += CDbl(DrTema(u)("RatingRealTarget1"))
                Next
                FilaNueva = DtCalculoFinalPauta.NewRow
                FilaNueva("IdSoporte") = ""
                FilaNueva("PlaGrps") = PlaTotalGrps
                FilaNueva("PlaDur") = PlaTemaDuracion
                FilaNueva("PlaTema") = PlaTema
                FilaNueva("PlaCantAvisos") = CStr(PlaCantAvisos)
                FilaNueva("EmiGrps") = EmiTotalGrps
                FilaNueva("EmiDur") = EmiTemaDuracion
                FilaNueva("EmiTema") = EmiTema
                FilaNueva("EmiCantAvisos") = CStr(EmiCantAvisos)
                DtCalculoFinalPauta.Rows.Add(FilaNueva)
                PlaTotalGrps = 0
                PlaTemaDuracion = 0
                PlaTema = ""
                PlaCantAvisos = 0
                EmiTotalGrps = 0
                EmiTemaDuracion = 0
                EmiTema = ""
                EmiCantAvisos = 0
            End If
        Next

        For Each DrTemasGrps In DtCalculoFinalPauta.Rows
            DrTemasGrps("PlaGrpsPromedio") = CStr(DrTemasGrps("PlaGrps") / PlaTotalGRPSPauta)
            DrTemasGrps("PlaDuracionPromedio") = CStr(DrTemasGrps("PlaGrpsPromedio") * DrTemasGrps("PlaDur"))
            DrTemasGrps("EmiGrpsPromedio") = CStr(DrTemasGrps("EmiGrps") / EmiTotalGRPSPauta)
            DrTemasGrps("EmiDuracionPromedio") = CStr(DrTemasGrps("EmiGrpsPromedio") * DrTemasGrps("EmiDur"))
        Next

        '++++++++++++++++++++++++++++++++++++ Calculo Final CPR X total Pauta ++++++++++++++++++++++++++++++++++++++++
        Dim DrInversion As DataRow
        Dim DrGrpsFinal As DataRow
        Dim PlaInversionPauta, EmiInversionPauta As Double
        Dim PlaDuracionPronedioPauta, EmiDuracionPronedioPauta As Double

        For Each DrGrpsFinal In DtCalculoFinalPauta.Rows
            PlaDuracionPronedioPauta += CDbl(DrGrpsFinal("PlaDuracionPromedio"))
            EmiDuracionPronedioPauta += CDbl(DrGrpsFinal("EmiDuracionPromedio"))
        Next

        For Each DrInversion In DtDesglose.Rows
            PlaInversionPauta += CDbl(DrInversion("PlaInversionNeta"))
            EmiInversionPauta += CDbl(DrInversion("EmiInversionNeta"))
        Next

        DtFinalPauta = ArmarDtFinalPauta()

        FilaNueva = DtFinalPauta.NewRow
        FilaNueva("PlaTotalDuracionProCamp") = CStr(Math.Round(PlaDuracionPronedioPauta, 2))
        FilaNueva("PlaTotalCPRCamp") = CStr(Math.Round(PlaInversionPauta / PlaTotalGRPSPauta / PlaDuracionPronedioPauta, 2))
        FilaNueva("EmiTotalDuracionProCamp") = CStr(Math.Round(EmiDuracionPronedioPauta, 2))
        FilaNueva("EmiTotalCPRCamp") = CStr(Math.Round(EmiInversionPauta / EmiTotalGRPSPauta / EmiDuracionPronedioPauta, 2))

        DtFinalPauta.Rows.Add(FilaNueva)

        PlaTotalGRPSPauta = 0
        EmiTotalGRPSPauta = 0

        Return DtFinalPauta

    End Function

    Private Function RecogerDuracionPromedioCampanias(ByVal DtCompleto As DataTable, ByVal TipoRecoleccion As Integer) As String

        Dim Dr As DataRow
        Dim PromedioDuracion As String
        Dim PlaCantAvisos, EmiCantAvisos As Integer
        Dim PlaDuracionTotal, EmiDuracionTotal As Double

        Dim Orden, Programa As String

        For Each Dr In DtCompleto.Rows
            '++++++++++++ Obtengo datos de Identificacion de Error +++++++++++++++++++
            ErrorNombrePrograma = Dr("programa").ToString
            ErrorNroOrden = Dr("id_orden_sigeme").ToString
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            '+++++ Recojo Datos de Planificacion ++++++++++
            If TipoRecoleccion = 0 Then
                PlaCantAvisos += 1
                PlaDuracionTotal += Double.Parse(Dr("Dur").ToString)
            End If
            '+++++ Recojo Datos de Emision +++++++++++++
            If TipoRecoleccion = 1 Then
                If Dr("IdAviso") = "-1" And Dr("Duracion") = "0" Then
                Else
                    EmiCantAvisos += 1
                    EmiDuracionTotal += Double.Parse(Dr("Duracion").ToString)
                End If
            End If
        Next

        If TipoRecoleccion = 0 Then  'Datos Planificacion 
            If PlaDuracionTotal > 0 Then
                PromedioDuracion = PlaDuracionTotal / PlaCantAvisos
            Else
                PromedioDuracion = 0
            End If
        End If

        If TipoRecoleccion = 1 Then 'Datos Emitidos O MMS
            If EmiDuracionTotal > 0 Then
                PromedioDuracion = EmiDuracionTotal / EmiCantAvisos
            Else
                PromedioDuracion = 0
            End If
        End If

        Return PromedioDuracion

    End Function

    Private Function RellenarAvisosSinOP(ByVal DtCompleto As DataTable) As DataTable

        For Each Rows As DataRow In DtCompleto.Rows
            If IsDBNull(Rows("OP")) Then
                Rows("OP") = "0"
                Rows("Presupuesto") = "0"
                Rows("NroPedido") = "0"
                Rows("InversionNeta") = "0"
                Rows("NProgramaFuente") = ""
                Rows("HoraMinutoReal") = "00:00"
                Rows("Duracion") = "0"
                Rows("RatingRealTarget1") = "0"
                Rows("CprxSoporte") = "0"
                Rows("InversionReal") = "0"
                If Rows("CostoSpot") > 0 Then
                    Rows("DifInversionNeta") = CStr(0 - Rows("CostoSpot"))
                Else
                    Rows("DifInversionNeta") = "0"
                End If
                Rows("DifRating") = "0"
                Rows("DifRating%") = "0"
                Rows("IdAviso") = -1
            End If
        Next

        For Each Rows As DataRow In DtCompleto.Rows
            If Rows("NroPedido").ToString = "" Then
                Rows("NroPedido") = "0"
            End If
        Next

        Return (DtCompleto)

    End Function

    Private Function ControlAvisosDificultosos(ByVal DtCompleto As DataTable) As DataTable

        Dim NroAviso As String
        Dim Programa As String

        For Each Rows As DataRow In DtCompleto.Rows
            If Rows("InversionReal").ToString = "0" Then
                Rows("Control") = "rojo"
            ElseIf CInt(Rows("DifRating%")) > 10 And CInt(Rows("DifRating%")) <= 20 Then
                Rows("Control") = "amarillo"
            ElseIf CInt(Rows("DifRating%")) > 20 Then
                Rows("Control") = "naranja"
            Else
                Rows("Control") = "vacio"
            End If
            'AG 22/03/2013 ++++++++++++++++++++++++++++++++
            Rows("RatingRealTarget2") = Valores.CastDBNullString(IIf(IsDBNull(Rows("RatingRealTarget2")), 0, Rows("RatingRealTarget2")))
            Rows("NProgramaFuente") = Valores.CastDBNullString(IIf(IsDBNull(Rows("NProgramaFuente")), Rows("Programa"), Rows("NProgramaFuente")))
            If Rows("NProgramaFuente") = "" Then
                Rows("NProgramaFuente") = "----"
            End If
            '+++++++++++++++++++++++++++++++++++++++++++
        Next

        Return DtCompleto

    End Function

    Private Function ComprobarDatosMotorAudiencia(ByVal DtCompleto As DataTable) As Boolean

        Dim ControlAudiencia As Boolean = False
        For Each Rows As DataRow In DtCompleto.Rows
            If IsDBNull(Rows("DifRating%")) And MensajeErrorMotorAudiencia <> "" Then
                ControlAudiencia = True
                Exit For
            End If
        Next

        Return ControlAudiencia
    End Function

#End Region

#End Region

#Region "Metodos Sin Utilizar"

    Private Function RemoverAvisoNoConfirmadoMMS(ByVal DtMMS As DataTable, ByVal DtEverest As DataTable) As DataTable

        Dim Filas() As DataRow
        Dim FilasEverest() As DataRow
        Dim Dr As DataRow
        Dim DrFilasRemove() As DataRow
        Dim i As Integer

        DtFinalCompletoSinMMS = DtEverest.Clone

        For Each RowEverest As DataRow In DtEverest.Rows
            Filas = DtMMS.Select("COD_ORDEN=" & RowEverest("id_orden_sigeme"))
            If Filas.Length = 0 Then
                FilasEverest = DtEverest.Select("id_orden_sigeme=" & RowEverest("id_orden_sigeme"))
                Dr = DtFinalCompletoSinMMS.NewRow()
                Dr("cadena") = FilasEverest(0)("cadena")
                Dr("Dia") = FilasEverest(0)("Dia")
                Dr("ID_SOPORTE") = FilasEverest(0)("ID_SOPORTE")
                Dr("TIPO_RATING") = FilasEverest(0)("TIPO_RATING")
                Dr("ID_TARGET_1") = FilasEverest(0)("ID_TARGET_1")
                Dr("DESCRIPCION") = FilasEverest(0)("DESCRIPCION")
                Dr("ID_ORDEN_SIGEME") = FilasEverest(0)("ID_ORDEN_SIGEME")
                Dr("ID_SPOT_ESTADO") = FilasEverest(0)("ID_SPOT_ESTADO")
                Dr("CostoSpot") = FilasEverest(0)("CostoSpot")
                Dr("CPRProg") = FilasEverest(0)("CPRProg")
                Dr("CPRTanda") = FilasEverest(0)("CPRTanda")
                Dr("Programa") = FilasEverest(0)("Programa")
                Dr("F_SPOT") = FilasEverest(0)("F_SPOT")
                Dr("Hora") = FilasEverest(0)("Hora")
                Dr("Rating") = FilasEverest(0)("Rating")
                Dr("Dur") = FilasEverest(0)("Dur")
                Dr("ID_TEMA") = FilasEverest(0)("ID_TEMA")
                Dr("TarifaBruta") = FilasEverest(0)("TarifaBruta")
                Dr("D1") = FilasEverest(0)("D1")
                Dr("D2") = FilasEverest(0)("D2")
                Dr("D3") = FilasEverest(0)("D3")
                Dr("D4") = FilasEverest(0)("D4")
                Dr("D5") = FilasEverest(0)("D5")
                Dr("TarifaNeta") = FilasEverest(0)("TarifaNeta")
                Dr("CPRPlanificado") = FilasEverest(0)("CPRPlanificado")
                Dr("ID_SISTEMA") = FilasEverest(0)("ID_SISTEMA")
                Dr("ID_EJERCICIO") = FilasEverest(0)("ID_EJERCICIO")
                DtFinalCompletoSinMMS.Rows.Add(Dr)
            End If
        Next

        Return DtEverest

    End Function

    Private Function RemoverAvisoSinOP(ByVal DtCompleto As DataTable) As DataTable

        Dim Dr As DataRow
        Dim DrFilasRemove() As DataRow
        Dim i As Integer
        Dim ArrPlaAviso As New ArrayList

        For Each Rows As DataRow In DtCompleto.Rows
            If IsDBNull(Rows("OP")) Then
                Dr = DtFinalCompletoSinMMS.NewRow()
                Dr("cadena") = Rows("cadena")
                Dr("Dia") = Rows("Dia")
                Dr("ID_SOPORTE") = Rows("ID_SOPORTE")
                Dr("TIPO_RATING") = Rows("TIPO_RATING")
                Dr("ID_TARGET_1") = Rows("ID_TARGET_1")
                Dr("DESCRIPCION") = Rows("DESCRIPCION")
                Dr("ID_ORDEN_SIGEME") = Rows("ID_ORDEN_SIGEME")
                Dr("ID_SPOT_ESTADO") = Rows("ID_SPOT_ESTADO")
                Dr("CostoSpot") = Rows("CostoSpot")
                Dr("CPRProg") = Rows("CPRProg")
                Dr("CPRTanda") = Rows("CPRTanda")
                Dr("Programa") = Rows("Programa")
                Dr("F_SPOT") = Rows("F_SPOT")
                Dr("Hora") = Rows("Hora")
                Dr("Rating") = Rows("Rating")
                Dr("Dur") = Rows("Dur")
                Dr("ID_TEMA") = Rows("ID_TEMA")
                Dr("TarifaBruta") = Rows("TarifaBruta")
                Dr("D1") = Rows("D1")
                Dr("D2") = Rows("D2")
                Dr("D3") = Rows("D3")
                Dr("D4") = Rows("D4")
                Dr("D5") = Rows("D5")
                Dr("TarifaNeta") = Rows("TarifaNeta")
                Dr("CPRPlanificado") = Rows("CPRPlanificado")
                Dr("ID_SISTEMA") = Rows("ID_SISTEMA")
                Dr("ID_EJERCICIO") = Rows("ID_EJERCICIO")
                DtFinalCompletoSinMMS.Rows.Add(Dr)
            End If
        Next

        If DtFinalCompletoSinMMS.Rows.Count > 0 Then
            For Each RowEverest As DataRow In DtFinalCompletoSinMMS.Rows
                DrFilasRemove = DtCompleto.Select("id_orden_sigeme=" & RowEverest("id_orden_sigeme"))
                If DrFilasRemove.Length > 0 Then
                    DtCompleto.Rows.Remove(DrFilasRemove(0))
                End If
            Next
        End If

        DtCompleto.AcceptChanges()

        Return DtCompleto

    End Function

    Private Function AnexarFilasDtFinalSinMMS(ByVal DtCompleto As DataTable, ByVal DtFinalCompletoSinMMS As DataTable) As DataTable

        Dim Dr As DataRow

        For Each Rows As DataRow In DtFinalCompletoSinMMS.Rows
            Dr = DtCompleto.NewRow()
            Dr("cadena") = Rows("cadena")
            Dr("Dia") = Rows("Dia")
            Dr("ID_SOPORTE") = Rows("ID_SOPORTE")
            Dr("TIPO_RATING") = Rows("TIPO_RATING")
            Dr("ID_TARGET_1") = Rows("ID_TARGET_1")
            Dr("DESCRIPCION") = Rows("DESCRIPCION")
            Dr("ID_ORDEN_SIGEME") = Rows("ID_ORDEN_SIGEME")
            Dr("ID_SPOT_ESTADO") = Rows("ID_SPOT_ESTADO")
            Dr("CostoSpot") = Rows("CostoSpot")
            Dr("CPRProg") = Rows("CPRProg")
            Dr("CPRTanda") = Rows("CPRTanda")
            Dr("Programa") = Rows("Programa")
            Dr("F_SPOT") = Rows("F_SPOT")
            Dr("Hora") = Rows("Hora")
            Dr("Rating") = Rows("Rating")
            Dr("Dur") = Rows("Dur")
            Dr("ID_TEMA") = Rows("ID_TEMA")
            Dr("TarifaBruta") = Rows("TarifaBruta")
            Dr("D1") = Rows("D1")
            Dr("D2") = Rows("D2")
            Dr("D3") = Rows("D3")
            Dr("D4") = Rows("D4")
            Dr("D5") = Rows("D5")
            Dr("TarifaNeta") = Rows("TarifaNeta")
            Dr("CPRPlanificado") = Rows("CPRPlanificado")
            '++++++++ Agrego Datos Vacios para que no explote el dbnull +++++++++++++
            Dr("OP") = ""
            Dr("Presupuesto") = ""
            Dr("NroPedido") = ""
            Dr("InversionNeta") = "0"
            Dr("NProgramaFuente") = ""
            Dr("HoraMinutoReal") = ""
            Dr("Duracion") = "0"
            Dr("RatingRealTarget1") = "0"
            Dr("CprxSoporte") = ""
            Dr("InversionReal") = "0"
            Dr("DifInversionNeta") = "0"
            Dr("DifRating") = "0"
            Dr("DifRating%") = "0"
            DtCompleto.Rows.Add(Dr)
        Next

        Return DtCompleto

    End Function

#End Region

End Class
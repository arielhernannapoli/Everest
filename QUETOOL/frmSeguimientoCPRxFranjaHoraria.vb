Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports System.Collections.Generic
Imports System.Text

#Region " Enumeradores "
Enum Errores As Integer
    SinValor = 0
    FranjaRepetida = 1
    ImporteVacio = 2
End Enum
#End Region

Public Class frmSeguimientoCPRxFranjaHoraria

#Region " Variables y Constantes "
    Dim IdTarget As Integer
    Dim IdTarget2 As Integer
    Dim IdPauta As Integer
    Dim IdArchivo As String
    Dim IdPlaza As Integer
    Dim IdFranja As Integer
    Dim PlaInversionNeta As Double
    Dim PlaGRPS As Double
    Dim PlaDuracionPromedio As Double
    Dim PlaCPRPromedio As Double
    Dim PlaSOIxCanal As Double
    Dim EmiInversionNeta As Double
    Dim EmiGRPS As Double
    Dim EmiDuracionPromedio As Double
    Dim EmiCPRPromedio As Double
    Dim EmiSOIxCanal As Double
    Dim TotalOrdenCompra As Double
    Dim DifTotalNetoRealCompra As Double
    Dim TotalInversionNetaCompleta As Double
    Dim ErrorNombrePrograma As String
    Dim ErrorNroOrden As String
    Dim MensajeErrorMotorAudiencia As String
    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato
    Dim DtSoportesAlternativa As DataTable
    Dim dtTemas As DataTable
    Dim DtFinalCompletoSinMMS As DataTable
    Dim DtDuracionPromediaSoporte As DataTable
    Dim DtCalculoFinalPauta As DataTable
    Dim ArrPlaAvisos As New ArrayList
    Dim DtTemasAplicados As New DataTable
    Dim frmFormulaOne As New frmFormulaOne
    Dim SoporteTvAbierta() As String = {"11", "13", "48", "1870"}
    Dim CargoCuadroResumen As Boolean = False
    Dim workerBusy As Boolean = False

    Const SoporteTelefe As Integer = 11
    Const SoporteCanal13 As Integer = 13
    Const SoporteAmerica As Integer = 48
    Const SoporteCanal9 As Integer = 1870
#End Region

#Region " Constructores "
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

    End Sub

    Public Sub New(ByVal soportes As DataTable)
        InitializeComponent()
        Me.DtSoportesAlternativa = soportes
        Me.CargarTargetSistema()
        Me.CargarConvenios()
        Me.FormatearGrilla()
    End Sub
#End Region

#Region " Metodos Privados "
    Private Delegate Sub SetDataSourceDelegate(ByVal value As Object)

    Private Sub SetDataSource(ByVal value As Object)
        iugConvenios.DataSource = value
    End Sub

    Private Sub CargarConvenios()
        Dim dt As New DataTable
        Using ConvenioDBL As New MPG.DBL.Convenios()
            dt = ConvenioDBL.ObtenerConveniosCPR(Activo.IDCliente, Me.dtpFechaDesde.Value, Me.dtpFechaHasta.Value)
            If iugConvenios.InvokeRequired Then
                iugConvenios.Invoke(New SetDataSourceDelegate(AddressOf SetDataSource), New Object() {dt})
            Else
                SetDataSource(dt)
            End If
        End Using
    End Sub

    Private Sub CargarTargetSistema()
        Dim OBTarget As New Targets
        Dim DtTarget As DataTable

        Using SistemasDBL As New MPG.DBL.Sistemas
            Using TargetsDBL As New MPG.DBL.Targets
                SistemasDBL.Id_campania = Activo.IDCampaña
                SistemasDBL.Id_sistema = Me.DtSoportesAlternativa.Rows(0)("id_sistema")
                SistemasDBL.BuscarPorID()

                Me.IdFranja = SistemasDBL.Id_date_part

                DtTarget = TargetsDBL.ObtenerTargetReporteCPR(SistemasDBL.Id_target_1)

                If DtTarget.Rows.Count > 0 Then
                    Me.IdTarget = DtTarget.Rows(0)("ID_TARGET")
                    Me.txtTarget1.Text = DtTarget.Rows(0)("DESCRIPCION").ToString
                End If

                If SistemasDBL.Id_target_2 > 0 Then
                    DtTarget = OBTarget.ObtenerTargetReporteCPR(SistemasDBL.Id_target_2)
                    Me.IdTarget2 = DtTarget.Rows(0)("ID_TARGET")
                    Me.txtTarget2.Text = DtTarget.Rows(0)("DESCRIPCION").ToString
                Else
                    Me.txtTarget2.Text = "NINGUNO"
                End If

                Me.dtpFechaDesde.Value = SistemasDBL.F_inicio
                Me.dtpFechaHasta.Value = SistemasDBL.F_fin

                Me.txtTarget1.Enabled = False
                Me.txtTarget2.Enabled = False
            End Using
        End Using
    End Sub

    Private Sub FormatearGrilla()

        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Me.iugConvenios.Rows
            For Each celda As Infragistics.Win.UltraWinGrid.UltraGridCell In fila.Cells
                If celda.Column.Index > 0 Then
                    celda.Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                End If
            Next
        Next

        Me.iugConvenios.DisplayLayout.Bands(0).Columns(0).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(0).Header.Caption = String.Empty
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(1).Hidden = True
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Convenio"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Descripcion"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(4).Header.Caption = "Soporte"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(5).Header.Caption = "CPR"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(6).Header.Caption = "Fecha Inicio"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(7).Header.Caption = "Fecha Fin"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(8).Header.Caption = "Hora Inicio"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(9).Header.Caption = "Hora Fin"
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(10).Header.Caption = "Cliente"

        GrillaFormato.AutoAjustarColumnas(Me.iugConvenios)

        Me.iugConvenios.DisplayLayout.Bands(0).Columns(3).AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.None
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(10).AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.None
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(3).Width = 150
        Me.iugConvenios.DisplayLayout.Bands(0).Columns(10).Width = 150

    End Sub

    Private Function ValidoConvenios(ByRef err As Integer) As Boolean

        If (ObtenerConveniosSoporte(Me.SoporteTelefe).Count = 0 And String.IsNullOrEmpty(Me.txtCPRTelefe.Text)) Then
            err = Errores.SinValor
            Return False
        Else
            If Not ValidoFranjas(Me.SoporteTelefe) Then
                err = Errores.FranjaRepetida
                Return False
            End If
        End If

        If (ObtenerConveniosSoporte(Me.SoporteCanal13).Count = 0 And String.IsNullOrEmpty(Me.txtCPRC13.Text)) Then
            err = Errores.SinValor
            Return False
        Else
            If Not ValidoFranjas(Me.SoporteCanal13) Then
                err = Errores.FranjaRepetida
                Return False
            End If
        End If

        If (ObtenerConveniosSoporte(Me.SoporteAmerica).Count = 0 And String.IsNullOrEmpty(Me.txtCPRAmerica.Text)) Then
            err = Errores.SinValor
            Return False
        Else
            If Not ValidoFranjas(Me.SoporteAmerica) Then
                err = Errores.FranjaRepetida
                Return False
            End If
        End If

        If (ObtenerConveniosSoporte(Me.SoporteCanal9).Count = 0 And String.IsNullOrEmpty(Me.txtCPRC9.Text)) Then
            err = Errores.SinValor
            Return False
        Else
            If Not ValidoFranjas(Me.SoporteCanal9) Then
                err = Errores.FranjaRepetida
                Return False
            End If
        End If

        If String.IsNullOrEmpty(Me.txtImporteTV.Text) Then
            err = Errores.ImporteVacio
            Return False
        End If

        Return True
    End Function

    Private Function ObtenerConveniosSoporte(ByVal soporte As Integer) As ArrayList
        Dim a As New ArrayList()
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Me.iugConvenios.Rows
            If fila.Cells(0).Value = 1 And fila.Cells(1).Value = soporte Then
                a.Add(fila.Cells(4).Value)
            End If
        Next
        Return a
    End Function

    Private Function ValidoFranjas(ByVal soporte As Integer) As Boolean
        Dim dt As DataTable = Me.iugConvenios.DataSource
        Dim dr() As DataRow
        Dim franjasDesde As New ArrayList()
        Dim franjasHasta As New ArrayList()
        dr = dt.Select(String.Concat("COD_SOPORTE=", soporte.ToString()))
        For Each fila As DataRow In dr
            If fila(0) = 1 Then
                franjasDesde.Add(Convert.ToInt16(fila("HORA_DESDE").ToString().Replace(":", "")))
                franjasHasta.Add(Convert.ToInt16(fila("HORA_HASTA").ToString().Replace(":", "")))
            End If
        Next
        For x As Integer = 0 To franjasDesde.Count - 1
            For y As Integer = 0 To franjasDesde.Count - 1
                If x <> y Then
                    If Not (franjasDesde(x) > franjasHasta(y) Or _
                        franjasDesde(y) > franjasHasta(x)) Then
                        Return False
                    End If
                End If
            Next
        Next
        Return True
    End Function

    Private Sub InitializeCuadroInversion(ByRef cuadro As DataTable)
        For x As Integer = 1 To 5
            Dim row As DataRow = cuadro.NewRow()
            For y As Integer = 0 To cuadro.Columns.Count - 1
                row(y) = 0
            Next
            cuadro.Rows.Add(row)
        Next
    End Sub

    Private Sub InitializeCuadroResumenGPR(ByRef cuadro As DataTable)
        For x As Integer = 1 To 10
            Dim row As DataRow = cuadro.NewRow()
            For y As Integer = 0 To cuadro.Columns.Count - 1
                row(y) = 0
            Next
            cuadro.Rows.Add(row)
        Next
    End Sub

    Private Function ArmarDtCuadroResumenInversion(ByVal franjas As DataTable) As DataTable
        Dim Dt As New DataTable
        Dt.Columns.Add("Inversion_Planificado", GetType(Double))
        Dt.Columns.Add("Inversion_Planificado_%", GetType(Double))
        Dt.Columns.Add("Inversion_Post", GetType(Double))
        Dt.Columns.Add("Inversion_Post_%", GetType(Double))
        For x As Integer = 0 To franjas.Rows.Count - 1
            Dt.Columns.Add(String.Concat("Post_", franjas.Rows(x)("DESCRIPCION")), GetType(Double))
        Next
        For x As Integer = 0 To franjas.Rows.Count - 1
            Dt.Columns.Add(String.Concat("PBR_", franjas.Rows(x)("DESCRIPCION")), GetType(Double))
        Next
        Dt.Columns.Add("Inversion_Diferencia", GetType(Double))
        Return Dt
    End Function

    Private Function ArmarDtCuadroResumenGPR(ByVal franjas As DataTable) As DataTable
        Dim Dt As New DataTable
        For x As Integer = 0 To franjas.Rows.Count - 1
            Dt.Columns.Add(String.Concat("GPR_", franjas.Rows(x)("DESCRIPCION")), GetType(Double))
            Dt.Columns.Add(String.Concat("SOV%_", franjas.Rows(x)("DESCRIPCION")), GetType(Double))
        Next
        Dt.Columns.Add("TOTAL_GRP", GetType(Double))
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

    Private Function ObtenerDtDesglose() As DataTable
        Dim dtDesglose As New DataTable
        dtDesglose.Columns.Add("CodSoporte", GetType(String))
        dtDesglose.Columns.Add("PlaInversionNeta", GetType(String))
        dtDesglose.Columns.Add("PlaGRPS", GetType(String))
        dtDesglose.Columns.Add("PlaDuracionPromedio", GetType(String))
        dtDesglose.Columns.Add("PlaCPRPromedio", GetType(String))
        dtDesglose.Columns.Add("PlaSOIxCanal", GetType(String))
        dtDesglose.Columns.Add("EmiInversionNeta", GetType(String))
        dtDesglose.Columns.Add("EmiGRPS", GetType(String))
        dtDesglose.Columns.Add("EmiDuracionPromedio", GetType(String))
        dtDesglose.Columns.Add("EmiCPRPromedio", GetType(String))
        dtDesglose.Columns.Add("EmiSOIxCanal", GetType(String))
        dtDesglose.Columns.Add("PlaTotalInversionCamp", GetType(String))
        dtDesglose.Columns.Add("PlaTotalGrpsCamp", GetType(String))
        dtDesglose.Columns.Add("PlaTotalDuracionProCamp", GetType(String))
        dtDesglose.Columns.Add("PlaTotalCPRCamp", GetType(String))
        dtDesglose.Columns.Add("PlaTotalSOIxCamp", GetType(String))
        dtDesglose.Columns.Add("EmiTotalInversionCamp", GetType(String))
        dtDesglose.Columns.Add("EmiTotalGrpsCamp", GetType(String))
        dtDesglose.Columns.Add("EmiTotalDuracionProCamp", GetType(String))
        dtDesglose.Columns.Add("EmiTotalCPRCamp", GetType(String))
        dtDesglose.Columns.Add("EmiTotalSOIxCamp", GetType(String))
        dtDesglose.Columns.Add("DiferenciaInversion", GetType(String))
        dtDesglose.Columns.Add("DiferenciaGrps", GetType(String))
        Return dtDesglose
    End Function

    Private Function ObtenerDtAvisosConfirmados() As DataTable
        Dim dtOrdenes As New DataTable
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
        Return dtOrdenes
    End Function

    Private Sub Procesar()
        Try
            Using SpotsDetalleDBL As New MPG.DBL.Spots_detalle
                Dim dtSpots, dtAvisosMMS, dtCompleto, dtDesglose, dtDesgloseSeguimiento, dtFranjas, dtCuadroResumen, dtCuadroInversion As DataTable
                Dim err As String
                dtFranjas = ObtenerFranjasSistema()
                dtCuadroResumen = ArmarDtCuadroResumenGPR(dtFranjas)
                dtCuadroInversion = ArmarDtCuadroResumenInversion(dtFranjas)
                InitializeCuadroResumenGPR(dtCuadroResumen)
                InitializeCuadroInversion(dtCuadroInversion)
                dtSpots = SpotsDetalleDBL.ObtenerSpotReporteCPR(Activo.IDCampaña, Activo.IDAlternativa, Me.dtpFechaDesde.Value, Me.dtpFechaHasta.Value, 1)
                If dtSpots Is Nothing Or dtSpots.Rows.Count = 0 Then
                    MsgBox("No se encontraron datos de Everest para la alternativa elegida." & vbCrLf & "Compruebe que los avisos estén enviados a compras", MsgBoxStyle.Information, "Reporte CPR")
                    Exit Sub
                End If
                dtAvisosMMS = ObtenerAvisosConfirmados(err)
                If dtAvisosMMS.Rows.Count = 0 Then
                    MessageBox.Show(err)
                    Exit Sub
                End If
                dtCompleto = ObtenerAvisosCompletos(dtSpots, dtAvisosMMS, dtCuadroResumen, dtFranjas, dtCuadroInversion)
                If ComprobarDatosMotorAudiencia(dtCompleto) = True Then
                    MsgBox("El Reporte de CPR no se ejecuto debido al Siguiente Problema :   " & vbCrLf & MensajeErrorMotorAudiencia + " ", MsgBoxStyle.Information)
                    MensajeErrorMotorAudiencia = ""
                    Exit Sub
                End If
                dtCompleto = ControlAvisosDificultosos(dtCompleto)
                dtDesglose = RecojerDatosTotales(dtCompleto)
                dtDesgloseSeguimiento = RecojerDatosSeguimiento(dtDesglose, ArmarDtDesgloseSeguimiento(), dtCompleto)
                dtCompleto.Columns.Remove("id_soporte")
                dtCompleto.Columns.Remove("IdAviso")
                frmFormulaOne.MostrarFOneCPR(dtSpots, dtAvisosMMS, dtCompleto, dtDesglose, dtDesgloseSeguimiento, dtFranjas, dtCuadroResumen, dtCuadroInversion)
                frmFormulaOne.Show()
                Me.Close()
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error al procesar la informacion", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Function ObtenerFranjasSistema() As DataTable
        Dim dtFranjas As DataTable
        Using FranjasDetalleDBL As New MPG.DBL.Franjas_Detalle
            dtFranjas = FranjasDetalleDBL.ObtenerFranjasSistema(Activo.IDCampaña, Me.DtSoportesAlternativa.Rows(0)("id_sistema"))
        End Using
        Return dtFranjas
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
            If DtDesglose.Rows.Count > 0 Then
                '+++++++++++++++++++++++ Planificado +++++++++++++++++++++++
                RowFinal("PlaTotalPautaCPRPromedio") = DtDesglose.Rows(0)("PlaTotalCPRCamp").ToString
                '+++++++++++++++++++++++ Emitidos ++++++++++++++++++++++++
                RowFinal("EmiTotalPautaCPRPromedio") = DtDesglose.Rows(0)("EmiTotalCPRCamp").ToString
            Else
                RowFinal("PlaTotalPautaCPRPromedio") = 0
                RowFinal("EmiTotalPautaCPRPromedio") = 0
            End If
        Next

        '++++++++++++++++++++++++++++++++++++++++

        Return DtDesgloseSeguimiento

    End Function

    Private Function RecojerDatosSeguimiento(ByVal DtDesglose As DataTable, ByVal DtDesgloseSeguimiento As DataTable, ByVal DtCompletoFinal As DataTable) As DataTable

        Dim DtCPRPromedio As DataTable
        Dim Dr As DataRow

        Dr = DtDesgloseSeguimiento.NewRow

        Dr("TotalOrdenCompra") = Me.txtImporteTV.Text
        Dr("DifTotalNetoRealCompra") = Math.Round(TotalInversionNetaCompleta - Double.Parse(Dr("TotalOrdenCompra")), 2)

        DtDesgloseSeguimiento.Rows.Add(Dr)

        DtCPRPromedio = RecogerDatosCPRPromedio(DtCompletoFinal)

        DtDesgloseSeguimiento = CalcularCPRPromedioPautaCompleta(DtCompletoFinal, DtDesglose, DtDesgloseSeguimiento, DtCPRPromedio)

        TotalInversionNetaCompleta = 0

        Return DtDesgloseSeguimiento

    End Function

    Private Function ControlAvisosDificultosos(ByVal DtCompleto As DataTable) As DataTable

        Dim NroAviso As String
        Dim Programa As String

        For Each Rows As DataRow In DtCompleto.Rows
            If IIf(IsDBNull(Rows("InversionReal")), 0, Rows("InversionReal")).ToString = "0" Then
                Rows("Control") = "rojo"
            ElseIf CInt(IIf(IsDBNull(Rows("DifRating%")), 0, Rows("DifRating%"))) > 10 And CInt(IIf(IsDBNull(Rows("DifRating%")), 0, Rows("DifRating%"))) <= 20 Then
                Rows("Control") = "amarillo"
            ElseIf CInt(IIf(IsDBNull(Rows("DifRating%")), 0, Rows("DifRating%"))) > 20 Then
                Rows("Control") = "naranja"
            Else
                Rows("Control") = "vacio"
            End If
            Rows("RatingRealTarget2") = Valores.CastDBNullString(IIf(IsDBNull(Rows("RatingRealTarget2")), 0, Rows("RatingRealTarget2")))
            Rows("NProgramaFuente") = Valores.CastDBNullString(IIf(IsDBNull(Rows("NProgramaFuente")), Rows("Programa"), Rows("NProgramaFuente")))
            If Rows("NProgramaFuente") = "" Then
                Rows("NProgramaFuente") = "----"
            End If
        Next

        Return DtCompleto

    End Function

    Private Function ObtenerAvisosConfirmados(ByRef err As String) As DataTable
        Using ControlMacheoDBL As New MPG.DBL.Control_Macheo
            Dim resultado As New Dictionary(Of String, List(Of OrdenConfirmada))
            Dim lOrdenes As New List(Of OrdenConfirmada)
            Dim dtAvisos As DataTable = ObtenerDtAvisosConfirmados()
            Dim dr As DataRow
            resultado = ControlMacheoDBL.ObtenerOrdenesConfirmadasCPR(CInt(Activo.CodCampaniaActualMms), Activo.IDCliente, Me.dtpFechaDesde.Value, Me.dtpFechaHasta.Value)
            lOrdenes = resultado.Values(0)
            err = resultado.Keys(0)

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
        End Using
    End Function

    Private Function ModificarDtSpotsEverest(ByVal dtSpots As DataTable) As DataTable
        dtSpots.Columns.Add("OP", GetType(String))
        dtSpots.Columns.Add("Presupuesto", GetType(String))
        dtSpots.Columns.Add("NroPedido", GetType(String))
        dtSpots.Columns.Add("InversionNeta", GetType(String))
        dtSpots.Columns.Add("NProgramaFuente", GetType(String))
        dtSpots.Columns.Add("HoraMinutoReal", GetType(String))
        dtSpots.Columns.Add("Duracion", GetType(String))
        dtSpots.Columns.Add("RatingRealTarget1", GetType(String))
        dtSpots.Columns.Add("RatingRealTarget2", GetType(String))
        dtSpots.Columns.Add("CprxSoporte", GetType(String))
        dtSpots.Columns.Add("InversionReal", GetType(String))
        dtSpots.Columns.Add("DifInversionNeta", GetType(String))
        dtSpots.Columns.Add("DifRating", GetType(String))
        dtSpots.Columns.Add("DifRating%", GetType(String))
        dtSpots.Columns.Add("DifCPR", GetType(String))
        dtSpots.Columns.Add("fejecucion", GetType(DateTime))
        dtSpots.Columns.Add("HoraMinutoEliminar", GetType(String))
        dtSpots.Columns.Add("IdAviso", GetType(Integer))
        dtSpots.Columns.Add("Control", GetType(String))
        Return dtSpots
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

    Private Function AsignarCPRxSoporte(ByVal IdSoporte As Integer, ByVal HoraMinutoReal As Integer, ByVal FechaReal As DateTime) As String
        Dim cprRetorno As String

        'NUEVO CALCULO DE CPR (AN 06-11-2015)
        Dim dt As DataTable = Me.iugConvenios.DataSource
        Dim dr() As DataRow
        dr = dt.Select(String.Concat("COD_SOPORTE=", IdSoporte.ToString()))
        For Each fila As DataRow In dr
            If fila(0) = 1 Then 'FILAS DEL SOPORTE CHECKEADAS
                Dim fechaDesde As DateTime = CDate(fila("FEC_INICIO"))
                Dim fechaHasta As DateTime = CDate(fila("FEC_FIN"))
                Dim horaDesde As Integer = Convert.ToInt16(fila("HORA_DESDE").ToString().Replace(":", ""))
                Dim horaHasta As Integer = Convert.ToInt16(fila("HORA_HASTA").ToString().Replace(":", ""))

                If FechaReal >= fechaDesde And FechaReal <= fechaHasta And horaDesde < HoraMinutoReal And horaHasta >= HoraMinutoReal Then
                    Return fila("CPR").ToString()
                End If
            End If
        Next

        'SI NO HAY CONVENIOS APLICABLES USO VALOR DEL USUARIO
        Select Case IdSoporte
            Case SoporteTelefe
                cprRetorno = Me.txtCPRTelefe.Text
            Case SoporteAmerica
                cprRetorno = Me.txtCPRAmerica.Text
            Case SoporteCanal13
                cprRetorno = Me.txtCPRC13.Text
            Case SoporteCanal9
                cprRetorno = Me.txtCPRC9.Text
        End Select

        Return IIf(String.IsNullOrEmpty(cprRetorno), "NO SE PUEDE CALCULAR", cprRetorno)
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

    Private Function ObtenerDtSoportesIbope() As DataTable
        Dim dtSoportesIbope, dtSopAlternativas As DataTable
        Dim r As DataRow, NuevaFecha As Date, dias As Integer
        Using AlternativasDBL As New MPG.DBL.Alternativas
            Using SoportesDBL As New MPG.DBL.Soportes
                Using PautasMpDBL As New MPG.DBL.Pautas_mp
                    AlternativasDBL.Id_campania = Activo.IDCampaña
                    AlternativasDBL.Id_alternativa = Activo.IDAlternativa
                    dtSoportesIbope = AlternativasDBL.ObtenerSoportesIbope
                    AlternativasDBL.BuscarPorID()
                    dtSoportesIbope = AlternativasDBL.ObtenerSoportesIbope
                    dtSopAlternativas = AlternativasDBL.ObtenerSoportesGuardados
                    SoportesDBL.Id_soporte = dtSopAlternativas.Rows(0).Item("id_soporte")
                    SoportesDBL.Id_medio = dtSopAlternativas.Rows(0).Item("id_medio")
                    SoportesDBL.BuscarPorID_Soporte()
                    r = dtSoportesIbope.Select("id_soporte=" & SoportesDBL.Id_soporte)(0)
                    Me.IdArchivo = r("id_archivo")
                    Me.IdPlaza = r("plaza")
                    If Me.IdPauta = 0 Then
                        Me.IdPauta = PautasMpDBL.NuevoID + 1
                    End If
                End Using
            End Using
        End Using
        Return dtSoportesIbope
    End Function

    Private Function CargarPautas(ByVal Aviso As Long, ByVal Fecha As Date, ByVal Hora As String, ByVal Canal As Integer, ByVal Tema As String, ByVal Programa As String) As Integer
        Dim P As New Pautas_mp
        Dim Plaza As Integer

        Try
            Dim dtSoportesIbope As DataTable = ObtenerDtSoportesIbope()
            Dim idSoprote_Ibope As DataRow = dtSoportesIbope.Select("id_soporte = " & Canal)(0)
            If Programa.Length > 19 Then ' La tabla tiene un maxlen de 20
                Programa = Mid(Programa, 1, 19)
            End If
            P.Id = Me.IdPauta
            P.Fecha = Fecha
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

    Private Function CargarRating2Nulo(ByVal DtCompleto As DataTable) As DataTable

        Dim DtResultado As New DataTable

        For Each RowDatosCompletos As DataRow In DtCompleto.Rows
            RowDatosCompletos("RatingRealTarget2") = "0"
        Next

        Return DtCompleto

    End Function

    Private Function EnlazarDatosAudienicaAvisos(ByVal Dt As DataTable, ByVal DtCompleto As DataTable, ByVal IndiceTarget As Integer, ByRef DtCuadroResumen As DataTable, ByVal DtFranjas As DataTable, ByRef DtCuadroInversion As DataTable) As DataTable

        Dim Filas() As DataRow

        For Each RowDatosCompletos As DataRow In DtCompleto.Rows
            If RowDatosCompletos("IdAviso") <> -1 Then
                Filas = Dt.Select("Aviso=" & RowDatosCompletos("IdAviso"))
                If Filas.Length > 0 Then
                    If IndiceTarget = 1 Then
                        RowDatosCompletos("RatingRealTarget2") = Filas(0)("PBR").ToString
                    ElseIf IndiceTarget = 0 Then
                        RowDatosCompletos("RatingRealTarget1") = Filas(0)("PBR").ToString
                        If Not IsNumeric(RowDatosCompletos("CprxSoporte")) Then
                            RowDatosCompletos("InversionReal") = 0
                        Else
                            RowDatosCompletos("InversionReal") = CStr(RowDatosCompletos("Duracion") * RowDatosCompletos("CprxSoporte") * RowDatosCompletos("RatingRealTarget1"))
                        End If
                        RowDatosCompletos("DifInversionNeta") = RowDatosCompletos("InversionReal") - RowDatosCompletos("costospot")
                        RowDatosCompletos("DifRating") = RowDatosCompletos("RatingRealTarget1") - RowDatosCompletos("Rating")
                        If RowDatosCompletos("Rating") = 0 Then
                            RowDatosCompletos("DifRating%") = "0"
                        Else
                            RowDatosCompletos("DifRating%") = (RowDatosCompletos("RatingRealTarget1") / RowDatosCompletos("Rating") - 1) * 100
                        End If
                    End If

                    If Not CargoCuadroResumen Then
                        'CARGA DE DATOS EN CUADRO RESUMEN DE GPR (AN 09-11-2015)
                        Dim soporte As Integer = Convert.ToInt64(RowDatosCompletos("Id_Soporte"))
                        Dim hora As Integer = Convert.ToInt64(RowDatosCompletos("Hora").Split("-")(0).Replace(":", ""))
                        Dim horaReal As Integer = Convert.ToInt64(RowDatosCompletos("HoraMinutoReal").Replace(":", ""))
                        Dim rating As Double = Convert.ToDouble(RowDatosCompletos("Rating"))
                        Dim ratingReal As Double = Convert.ToDouble(RowDatosCompletos("RatingRealTarget1"))
                        Dim costoSpot As Double = Convert.ToDouble(RowDatosCompletos("costospot"))
                        Dim inversionReal As Double = Convert.ToDouble(RowDatosCompletos("InversionReal"))
                        Dim columnaTotales As Integer = DtFranjas.Rows.Count * 2

                        'AN 26/02/2016 CARGO CUADRO DE INVERSION CENCOSUD
                        Dim filaInversion As Integer = 0
                        Select Case soporte
                            Case SoporteCanal13
                                filaInversion = 0
                            Case SoporteTelefe
                                filaInversion = 1
                            Case SoporteAmerica
                                filaInversion = 2
                            Case SoporteCanal9
                                filaInversion = 3
                        End Select
                        DtCuadroInversion.Rows(filaInversion)(0) += costoSpot
                        DtCuadroInversion.Rows(filaInversion)(2) += inversionReal
                        DtCuadroInversion.Rows(4)(0) += FormatNumber(costoSpot, 2)
                        DtCuadroInversion.Rows(4)(2) += FormatNumber(inversionReal, 2)

                        For x As Integer = 0 To DtFranjas.Rows.Count - 1
                            Dim columna As Integer = x * 2
                            Dim horaDesde As Integer = _
                                String.Concat(IIf(DtFranjas(x)("H_DESDE").ToString().Length = 1, "0" & DtFranjas(x)("H_DESDE").ToString(), DtFranjas(x)("H_DESDE").ToString()), _
                                              IIf(DtFranjas(x)("M_DESDE").ToString().Length = 1, "0" & DtFranjas(x)("M_DESDE").ToString(), DtFranjas(x)("M_DESDE").ToString()))

                            Dim horaHasta As Integer = _
                                                        String.Concat(IIf(DtFranjas(x)("H_HASTA").ToString().Length = 1, "0" & DtFranjas(x)("H_HASTA").ToString(), DtFranjas(x)("H_HASTA").ToString()), _
                                                                      IIf(DtFranjas(x)("M_HASTA").ToString().Length = 1, "0" & DtFranjas(x)("M_HASTA").ToString(), DtFranjas(x)("M_HASTA").ToString()))

                            If hora >= horaDesde And hora <= horaHasta Then
                                Dim fila As Integer = 0
                                Select Case soporte
                                    Case SoporteCanal13
                                        fila = 0
                                    Case SoporteTelefe
                                        fila = 1
                                    Case SoporteAmerica
                                        fila = 2
                                    Case SoporteCanal9
                                        fila = 3
                                End Select
                                DtCuadroResumen.Rows(fila)(columna) += rating
                                DtCuadroResumen.Rows(4)(columna) += FormatNumber(rating, 2)
                                DtCuadroResumen.Rows(fila)(columnaTotales) += FormatNumber(rating, 2)
                                DtCuadroResumen.Rows(4)(columnaTotales) += FormatNumber(rating, 2)
                            End If

                            If horaReal >= horaDesde And horaReal <= horaHasta Then
                                Dim fila As Integer = 0
                                Select Case soporte
                                    Case SoporteCanal13
                                        fila = 5
                                    Case SoporteTelefe
                                        fila = 6
                                    Case SoporteAmerica
                                        fila = 7
                                    Case SoporteCanal9
                                        fila = 8
                                End Select
                                DtCuadroResumen.Rows(fila)(columna) += ratingReal
                                DtCuadroResumen.Rows(9)(columna) += FormatNumber(ratingReal, 2)
                                DtCuadroResumen.Rows(fila)(columnaTotales) += FormatNumber(ratingReal, 2)
                                DtCuadroResumen.Rows(9)(columnaTotales) += FormatNumber(ratingReal, 2)
                            End If

                            'AN 26/02/2016 CARGO CUADRO DE INVERSION CENCOSUD
                            If horaReal >= horaDesde And horaReal <= horaHasta Then
                                Dim columnaInversion As Integer = 0
                                Dim columnaRating As Integer = 0
                                columnaInversion = 3 + (x + 1)
                                columnaRating = 3 + (DtFranjas.Rows.Count) + (x + 1)
                                DtCuadroInversion.Rows(filaInversion)(columnaInversion) += inversionReal
                                DtCuadroInversion.Rows(4)(columnaInversion) += inversionReal
                                DtCuadroInversion.Rows(filaInversion)(columnaRating) += ratingReal
                            End If

                        Next
                    End If
                End If
            Else
                If Not CargoCuadroResumen Then
                    'CARGA DE DATOS EN CUADRO RESUMEN DE GPR (AN 09-11-2015)
                    Dim soporte As Integer = Convert.ToInt64(RowDatosCompletos("Id_Soporte"))
                    Dim hora As Integer = Convert.ToInt64(RowDatosCompletos("Hora").Split("-")(0).Replace(":", ""))
                    Dim horaReal As Integer = Convert.ToInt64(RowDatosCompletos("HoraMinutoReal").Replace(":", ""))
                    Dim rating As Double = Convert.ToDouble(RowDatosCompletos("Rating"))
                    Dim ratingReal As Double = Convert.ToDouble(RowDatosCompletos("RatingRealTarget1"))
                    Dim costoSpot As Double = Convert.ToDouble(RowDatosCompletos("costospot"))
                    Dim inversionReal As Double = Convert.ToDouble(RowDatosCompletos("InversionReal"))
                    Dim columnaTotales As Integer = DtFranjas.Rows.Count * 2

                    'AN 26/02/2016 CARGO CUADRO DE INVERSION CENCOSUD
                    Dim filaInversion As Integer = 0
                    Select Case soporte
                        Case SoporteCanal13
                            filaInversion = 0
                        Case SoporteTelefe
                            filaInversion = 1
                        Case SoporteAmerica
                            filaInversion = 2
                        Case SoporteCanal9
                            filaInversion = 3
                    End Select
                    DtCuadroInversion.Rows(filaInversion)(0) += costoSpot
                    DtCuadroInversion.Rows(filaInversion)(2) += inversionReal
                    DtCuadroInversion.Rows(4)(0) += FormatNumber(costoSpot, 2)
                    DtCuadroInversion.Rows(4)(2) += FormatNumber(inversionReal, 2)

                    For x As Integer = 0 To DtFranjas.Rows.Count - 1
                        Dim columna As Integer = x * 2
                        Dim horaDesde As Integer = _
                            String.Concat(IIf(DtFranjas(x)("H_DESDE").ToString().Length = 1, "0" & DtFranjas(x)("H_DESDE").ToString(), DtFranjas(x)("H_DESDE").ToString()), _
                                          IIf(DtFranjas(x)("M_DESDE").ToString().Length = 1, "0" & DtFranjas(x)("M_DESDE").ToString(), DtFranjas(x)("M_DESDE").ToString()))

                        Dim horaHasta As Integer = _
                                                    String.Concat(IIf(DtFranjas(x)("H_HASTA").ToString().Length = 1, "0" & DtFranjas(x)("H_HASTA").ToString(), DtFranjas(x)("H_HASTA").ToString()), _
                                                                  IIf(DtFranjas(x)("M_HASTA").ToString().Length = 1, "0" & DtFranjas(x)("M_HASTA").ToString(), DtFranjas(x)("M_HASTA").ToString()))

                        If hora >= horaDesde And hora <= horaHasta Then
                            Dim fila As Integer = 0
                            Select Case soporte
                                Case SoporteCanal13
                                    fila = 0
                                Case SoporteTelefe
                                    fila = 1
                                Case SoporteAmerica
                                    fila = 2
                                Case SoporteCanal9
                                    fila = 3
                            End Select
                            DtCuadroResumen.Rows(fila)(columna) += rating
                            DtCuadroResumen.Rows(4)(columna) += FormatNumber(rating, 2)
                            DtCuadroResumen.Rows(fila)(columnaTotales) += FormatNumber(rating, 2)
                            DtCuadroResumen.Rows(4)(columnaTotales) += FormatNumber(rating, 2)
                        End If

                        If horaReal >= horaDesde And horaReal <= horaHasta Then
                            Dim fila As Integer = 0
                            Select Case soporte
                                Case SoporteCanal13
                                    fila = 5
                                Case SoporteTelefe
                                    fila = 6
                                Case SoporteAmerica
                                    fila = 7
                                Case SoporteCanal9
                                    fila = 8
                            End Select
                            DtCuadroResumen.Rows(fila)(columna) += ratingReal
                            DtCuadroResumen.Rows(9)(columna) += FormatNumber(ratingReal, 2)
                            DtCuadroResumen.Rows(fila)(columnaTotales) += FormatNumber(ratingReal, 2)
                            DtCuadroResumen.Rows(9)(columnaTotales) += FormatNumber(ratingReal, 2)
                        End If

                        'AN 26/02/2016 CARGO CUADRO DE INVERSION CENCOSUD
                        If horaReal >= horaDesde And horaReal <= horaHasta Then
                            Dim columnaInversion As Integer = 0
                            Dim columnaRating As Integer = 0
                            columnaInversion = 3 + (x + 1)
                            columnaRating = 3 + (DtFranjas.Rows.Count) + (x + 1)
                            DtCuadroInversion.Rows(filaInversion)(columnaInversion) += inversionReal
                            DtCuadroInversion.Rows(4)(columnaInversion) += inversionReal
                            DtCuadroInversion.Rows(filaInversion)(columnaRating) += ratingReal
                        End If
                    Next
                End If
            End If
        Next

        If Not CargoCuadroResumen Then
            'CALCULO DE PORCENTAJES EN CUADRO RESUMEN DE GPR (AN 09-11-2015)
            Dim columnaTotalesPorc As Integer = DtFranjas.Rows.Count * 2
            For x As Integer = 0 To DtFranjas.Rows.Count - 1
                Dim columna As Integer = x * 2
                Dim columnaPorc As Integer = (x * 2) + 1
                For y As Integer = 0 To 9
                    DtCuadroResumen.Rows(y)(columna) = FormatNumber(DtCuadroResumen.Rows(y)(columna), 2)
                    DtCuadroResumen.Rows(y)(columnaTotalesPorc) = FormatNumber(DtCuadroResumen.Rows(y)(columnaTotalesPorc), 2)
                    DtCuadroResumen.Rows(y)(columnaPorc) = FormatNumber((DtCuadroResumen.Rows(y)(columna) / DtCuadroResumen.Rows(y)(columnaTotalesPorc)) * 100, 2)
                Next
            Next
            CargoCuadroResumen = Not CargoCuadroResumen

            'AN 26/02/2016 PORCENTAJES Y DIFERENCIAS DE CUADRO DE INVERSION CENCOSUD
            For x As Integer = 0 To 4
                Dim columnaDiferencias As Integer = 0
                columnaDiferencias = 4 + (DtFranjas.Rows.Count * 2)
                DtCuadroInversion.Rows(x)(1) = FormatNumber(((DtCuadroInversion.Rows(x)(0) / DtCuadroInversion.Rows(4)(0)) * 100), 2)
                DtCuadroInversion.Rows(x)(3) = FormatNumber(((DtCuadroInversion.Rows(x)(2) / DtCuadroInversion.Rows(4)(2)) * 100), 2)
                DtCuadroInversion.Rows(x)(columnaDiferencias) = DtCuadroInversion.Rows(x)(2) - DtCuadroInversion.Rows(x)(0)
            Next
        End If

        Return DtCompleto

    End Function

    Private Function EvaluarMotorP(ByVal DtCompleto As DataTable, ByVal IndiceTarget As Integer, ByRef DtCuadroResumen As DataTable, ByVal DtFranjas As DataTable, ByRef DtCuadroInversion As DataTable) As DataTable
        Dim Motor As New MotorP
        Cursor.Current = Cursors.WaitCursor
        Dim PermitirCalcular As Boolean
        Dim DtResultado As New DataTable

        Motor.Progreso = New ProgressBar()

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
                            .Target = Me.IdTarget2
                            PermitirCalcular = True
                        End If
                End Select
                .Plaza = 110
                .Sistema = IdArchivo
                .Pauta = IdPauta
                If PermitirCalcular = True Then
                    .Conectar()
                    If .MensajeError <> "" Then
                        MensajeErrorMotorAudiencia = .MensajeError
                        Return DtCompleto
                    End If
                    Dim Dt As DataTable
                    Dt = .ObtenerPBRxAvisos
                    Dt.TableName = "pbr"
                    Motor.Desconectar()
                    DtResultado = EnlazarDatosAudienicaAvisos(Dt, DtCompleto, IndiceTarget, DtCuadroResumen, DtFranjas, DtCuadroInversion)
                End If
                PermitirCalcular = False
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
    End Function

    Private Function EliminarColumnasDtCompleto(ByVal Dt As DataTable)
        Dt.Columns.Remove("FEJECUCION")
        Dt.Columns.Remove("ID_SISTEMA")
        Dt.Columns.Remove("ID_EJERCICIO")
        Dt.Columns.Remove("HoraMinutoEliminar")
        Dt.Columns.Remove("DifCPR")
        Return Dt
    End Function

    Private Function ObtenerAvisosCompletos(ByVal dtSpots As DataTable, ByVal dtAvisosMMS As DataTable, ByRef dtCuadroResumen As DataTable, ByVal dtFranjas As DataTable, ByRef dtCuadroInversion As DataTable) As DataTable
        Dim Filas() As DataRow
        Dim DtResultado As DataTable
        Dim dtProvisorio As DataTable
        Dim Maximo As Integer = 2

        dtSpots = ModificarDtSpotsEverest(dtSpots)

        If Not dtAvisosMMS Is Nothing Then
            For Each RowDatosCompletos As DataRow In dtSpots.Rows
                Filas = dtAvisosMMS.Select("COD_ORDEN=" & RowDatosCompletos("id_orden_sigeme"))
                If Filas.Length > 0 Then
                    ErrorNombrePrograma = RowDatosCompletos("programa").ToString
                    ErrorNroOrden = RowDatosCompletos("id_orden_sigeme").ToString
                    RowDatosCompletos("OP") = Filas(0)("COD_CONTRATO")
                    RowDatosCompletos("Presupuesto") = Filas(0)("COD_PRESUPUESTO")
                    RowDatosCompletos("NroPedido") = Filas(0)("NUMERO_PEDIDO")
                    RowDatosCompletos("InversionNeta") = Filas(0)("NETO_VENTA")
                    RowDatosCompletos("NProgramaFuente") = Filas(0)("DES_PROGRAMA_REAL")
                    RowDatosCompletos("HoraMinutoReal") = FormatoHora(CInt(Filas(0)("HORAREAL")), 0)
                    RowDatosCompletos("Duracion") = Filas(0)("DURACION_REAL")
                    RowDatosCompletos("CprxSoporte") = AsignarCPRxSoporte(RowDatosCompletos("id_soporte"), CInt(Filas(0)("HORAREAL")), CDate(Filas(0)("FECHAREAL")))
                    RowDatosCompletos("fejecucion") = Filas(0)("FECHAREAL")
                    RowDatosCompletos("HoraMinutoEliminar") = Filas(0)("HORAREAL").ToString
                End If
            Next
        End If

        DtResultado = ProcesarDatos(RellenarAvisosSinOP(dtSpots))

        For i As Integer = 0 To Maximo - 1
            dtProvisorio = EvaluarMotorP(DtResultado, i, dtCuadroResumen, dtFranjas, dtCuadroInversion)
        Next i

        Return EliminarColumnasDtCompleto(dtProvisorio)
    End Function

    Private Function AnexarFilaDesglose(ByVal DtDesglose As DataTable, ByVal CodSoporte As Integer, ByVal PlaInversionNeta As Double, ByVal PlaGRPS As Double, ByVal PlaDuracionPromedio As Double, ByVal PlaCPRPromedio As Double, ByVal PlaSOIxCanal As Double, ByVal EmiInversionNeta As Double, ByVal EmiGRPS As Double, ByVal EmiDuracionPromedio As Double, ByVal EmiCPRPromedio As Double, ByVal EmiSOIxCanal As Double) As DataTable
        Dim Dr As DataRow
        Dr = DtDesglose.NewRow
        Dr("CodSoporte") = CodSoporte
        Dr("PlaInversionNeta") = Double.Parse(PlaInversionNeta)
        Dr("PlaGRPS") = Double.Parse(PlaGRPS)
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
            If CInt(Dr("EmiInversionNeta")) = 0 And EmiTotalInversion = 0 Then
                Dr("EmiSOIxCanal") = "0" + " %"
            Else
                Dr("EmiSOIxCanal") = CStr(Math.Round(((Dr("EmiInversionNeta") * 100) / EmiTotalInversion), 2)) + " %"
            End If
        Next
        TotalInversionNetaCompleta = EmiTotalInversion
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
                        PlaTotalGrps += CDbl(IIf(IsDBNull(DrSoporteTema(u)("Rating")), 0, DrSoporteTema(u)("Rating")))
                        PlaTemaDuracion = CInt(IIf(IsDBNull(DrSoporteTema(u)("DUR")), 0, DrSoporteTema(u)("DUR")))
                        PlaTema = DrSoporteTema(u)("ID_TEMA").ToString
                        PlaCantAvisos = DrSoporteTema.Length
                        EmiTotalGrps += CDbl(IIf(IsDBNull(DrSoporteTema(u)("RatingRealTarget1")), 0, DrSoporteTema(u)("RatingRealTarget1")))
                        If CInt(IIf(IsDBNull(DrSoporteTema(u)("Duracion")), 0, DrSoporteTema(u)("Duracion"))) = 0 Then
                            EmiTemaDuracion = CInt(IIf(IsDBNull(DrSoporteTema(u)("DUR")), 0, DrSoporteTema(u)("DUR")))
                        Else
                            EmiTemaDuracion = CInt(IIf(IsDBNull(DrSoporteTema(u)("Duracion")), 0, DrSoporteTema(u)("Duracion")))
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
                    PlaTotalGrps += CDbl(IIf(IsDBNull(DrSoporteResumen(u)("PlaGrps")), 0, DrSoporteResumen(u)("PlaGrps")))
                    EmiTotalGrps += CDbl(IIf(IsDBNull(DrSoporteResumen(u)("EmiGrps")), 0, DrSoporteResumen(u)("EmiGrps")))
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
                    PlaTotalGrps += CDbl(IIf(IsDBNull(DrSoportes(u)("PlaGrps")), 0, DrSoportes(u)("PlaGrps")))
                    PlaTemaDuracion = "0"
                    PlaTema = "Null"
                    PlaCantAvisos += CDbl(IIf(IsDBNull(DrSoportes(u)("PlaCantAvisos")), 0, DrSoportes(u)("PlaCantAvisos")))
                    PlaTotalGrpsPromedio += CDbl(IIf(IsDBNull(DrSoportes(u)("PlaGrpsPromedio")), 0, DrSoportes(u)("PlaGrpsPromedio")))
                    PlaTotalDuracionPromedio += CDbl(IIf(IsDBNull(DrSoportes(u)("PlaDuracionPromedio")), 0, DrSoportes(u)("PlaDuracionPromedio")))
                    EmiTotalGrps += CDbl(IIf(IsDBNull(DrSoportes(u)("EmiGrps")), 0, DrSoportes(u)("EmiGrps")))
                    EmiTemaDuracion = "0"
                    EmiTema = "Null"
                    EmiCantAvisos += CDbl(IIf(IsDBNull(DrSoportes(u)("EmiCantAvisos")), 0, DrSoportes(u)("EmiCantAvisos")))
                    EmiTotalGrpsPromedio += CDbl(IIf(IsDBNull(DrSoportes(u)("EmiGrpsPromedio")), 0, DrSoportes(u)("EmiGrpsPromedio")))
                    EmiTotalDuracionPromedio += CDbl(IIf(IsDBNull(DrSoportes(u)("EmiDuracionPromedio")), 0, DrSoportes(u)("EmiDuracionPromedio")))
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
                    If System.DBNull.Value.Equals(DrTema(u)("Rating")) Then
                        PlaTotalGrps += 0
                    Else
                        PlaTotalGrps += CDbl(DrTema(u)("Rating"))
                    End If
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
                    If System.DBNull.Value.Equals(DrTema(u)("Rating")) Then
                        PlaTotalGRPSPauta += 0
                    Else
                        PlaTotalGRPSPauta += CDbl(DrTema(u)("Rating"))
                    End If  
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

        DtResultadoFinalPautaCPR = ObtenerDtFinalPautaPromedioCPR_Duracion(DtCompletoFinal, DtDesglose)

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        For Each Rows In DtDesglose.Rows
            '+++++++++++++++++ Totales Planificado +++++++++++++++++++
            PlaTotalInversionCamp += Double.Parse(IIf(IsDBNull(Rows("PlaInversionNeta")), 0, Rows("PlaInversionNeta")).ToString)
            PlaTotalGrpsCamp += Double.Parse(IIf(IsDBNull(Rows("PlaGRPS")), 0, Rows("PlaGRPS")).ToString)
            PlaTotalCPRCamp += Double.Parse(IIf(IsDBNull(Rows("PlaCPRPromedio")), 0, Rows("PlaCPRPromedio")).ToString)
            PlaTotalSOIxCamp += Double.Parse(IIf(IsDBNull(Rows("PlaSOIxCanal")), 0, Rows("PlaSOIxCanal")).ToString.Replace("%", ""))
            '+++++++++++++++++ Totales Emitidos +++++++++++++++++++
            EmiTotalInversionCamp += Double.Parse(IIf(IsDBNull(Rows("EmiInversionNeta")), 0, Rows("EmiInversionNeta")).ToString)
            EmiTotalGrpsCamp += Double.Parse(IIf(IsDBNull(Rows("EmiGRPS")), 0, Rows("EmiGRPS")).ToString)
            EmiTotalCPRCamp += Double.Parse(IIf(IsDBNull(Rows("EmiCPRPromedio")), 0, Rows("EmiCPRPromedio")).ToString)
            EmiTotalSOIxCamp += Double.Parse(IIf(IsDBNull(Rows("EmiSOIxCanal")), 0, Rows("EmiSOIxCanal")).ToString.Replace("%", ""))
        Next

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
            Rows("DiferenciaInversion") = Double.Parse(IIf(IsDBNull(Rows("EmiInversionNeta")), 0, Rows("EmiInversionNeta")).ToString) - Double.Parse(IIf(IsDBNull(Rows("PlaInversionNeta")), 0, Rows("PlaInversionNeta")).ToString)
            Rows("DiferenciaGrps") = Double.Parse(IIf(IsDBNull(Rows("EmiGRPS")), 0, Rows("EmiGRPS")).ToString) - Double.Parse(IIf(IsDBNull(Rows("PlaGRPS")), 0, Rows("PlaGRPS")).ToString)
            TotalInversionDiferencia += Double.Parse(IIf(IsDBNull(Rows("DiferenciaInversion")), 0, Rows("DiferenciaInversion")).ToString)
            TotalGrpsDiferencia += Double.Parse(IIf(IsDBNull(Rows("DiferenciaGrps")), 0, Rows("DiferenciaGrps")).ToString)
        Next

        Return DtDesglose

    End Function

    Private Function RecojerDatosTotales(ByVal DtCompleto As DataTable) As DataTable
        Dim DtDesglose As DataTable = ObtenerDtDesglose()
        Dim Filas() As DataRow
        Dim PlaCantAvisos, EmiCantAvisos, CantSinAvisos As Integer
        Dim PlaSumDuracion, EmiSumDuracion As Integer
        Dim Canales() As String = {"11", "13", "48", "1870"}
        Dim i As Integer
        Dim j As Integer

        For i = 0 To Canales.Length - 1
            Filas = DtCompleto.Select("id_soporte=" & Canales(i))
            If Filas.Length > 0 Then
                For j = 0 To Filas.Length - 1
                    ErrorNombrePrograma = Filas(j)("programa").ToString
                    ErrorNroOrden = Filas(j)("id_orden_sigeme").ToString
                    If Filas(j)("IdAviso") = -1 Then
                        CantSinAvisos += 1
                    Else
                        EmiCantAvisos += 1
                    End If
                    PlaCantAvisos += 1
                    PlaSumDuracion += Double.Parse(IIf(IsDBNull(Filas(j)("Dur")), 0, Filas(j)("Dur")).ToString)
                    EmiSumDuracion += Double.Parse(IIf(IsDBNull(Filas(j)("Duracion")), 0, Filas(j)("Duracion")).ToString)
                    PlaInversionNeta += Double.Parse(IIf(IsDBNull(Filas(j)("CostoSpot")), 0, Filas(j)("CostoSpot")).ToString)
                    PlaGRPS += Double.Parse(IIf(IsDBNull(Filas(j)("Rating")), 0, Filas(j)("Rating")).ToString)
                    EmiInversionNeta += Math.Round(Double.Parse(IIf(IsDBNull(Filas(j)("InversionReal")), 0, Filas(j)("InversionReal")).ToString), 2)
                    EmiGRPS += Math.Round(Double.Parse(IIf(IsDBNull(Filas(j)("RatingRealTarget1")), 0, Filas(j)("RatingRealTarget1")).ToString), 2)
                Next
                PlaDuracionPromedio = PlaSumDuracion / PlaCantAvisos
                PlaCPRPromedio = PlaInversionNeta / PlaGRPS / PlaDuracionPromedio
                EmiCantAvisos = EmiCantAvisos
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
                End If
                DtDesglose = AnexarFilaDesglose(DtDesglose, CInt(Canales(i)), PlaInversionNeta, PlaGRPS, PlaDuracionPromedio, PlaCPRPromedio, PlaSOIxCanal, EmiInversionNeta, EmiGRPS, EmiDuracionPromedio, EmiCPRPromedio, EmiSOIxCanal)
                CantSinAvisos = 0
                PlaCantAvisos = 0
                EmiCantAvisos = 0
                PlaSumDuracion = 0
                PlaInversionNeta = 0
                PlaGRPS = 0
                PlaDuracionPromedio = 0
                PlaCPRPromedio = 0
                PlaSOIxCanal = 0
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
#End Region

#Region " Eventos "
    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim err As Integer
        Cursor.Current = Cursors.WaitCursor
        If Me.ValidoConvenios(err) Then
            Me.Procesar()
        Else
            Select Case err
                Case Errores.SinValor
                    MessageBox.Show("Falta definir valores de CPR para todos los soportes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Errores.FranjaRepetida
                    MessageBox.Show("Hay franjas repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Errores.ImporteVacio
                    MessageBox.Show("El importe de TV no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCPRAmerica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRAmerica.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtCPRC13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRC13.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtCPRC9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRC9.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtCPRTelefe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPRTelefe.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtImporteTV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteTV.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub dtpFechaDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.LostFocus

        If Not Me.workerBusy Then
            iugConvenios.Enabled = False
            Me.BackgroundWorker1.RunWorkerAsync()
            Me.workerBusy = True
        End If

    End Sub

    Private Sub dtpFechaHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.LostFocus
        If Not Me.workerBusy Then
            iugConvenios.Enabled = False
            Me.BackgroundWorker1.RunWorkerAsync()
            Me.workerBusy = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CargarConvenios()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.workerBusy = False
        iugConvenios.Enabled = True
    End Sub

    Private Sub dtpFechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dtpFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region

End Class

Imports System.Collections.Generic

Namespace Calendarios.TVRadio
    Public Class CalendarioDiarioConNumerosTVRadio
        Inherits CalendarioDiarioConNumeros

        Public Sub New(ByVal FOne As AdminFormulaOne, ByVal IdPlaza As List(Of Integer), ByVal Plaza As List(Of String), ByVal IdCampaña As Integer, ByVal IdAlternativa As Integer, ByVal IdCompania As Integer, ByVal IdMedio As Integer, ByVal Alternativa As String, ByVal SemanaNatural As Boolean, ByVal CalcularIVA As Boolean, ByVal CalcularIVANetoAgencia As Boolean, ByVal CalcularIVASoloAgencia As Boolean)
            Dim contador As Integer = 0
            Me.CantidadColumnas = 16
            Me.ColumnaRatingTanda = "RATINGTANDATOTAL"
            Me.ColumnaRatingPrograma = "RATINGPROGRAMATOTAL"
            Me.FOne = FOne
            Me.IdCampaña = IdCampaña
            Me.IdAlternativa = IdAlternativa
            Me.IdCompania = IdCompania
            Me.IdMedio = IdMedio
            Me.mDescripcion = Alternativa
            Me.SemanaNatural = SemanaNatural
            Me.CalcularIVA = CalcularIVA
            Me.CalcularIVANetoAgencia = CalcularIVANetoAgencia
            Me.UrlTemplate = String.Concat(Application.StartupPath, "\Comun\caldiarionuevo.vts")
            MyBase.InicializarTemplate()
            FilaActual = 1
            For contador = 0 To IdPlaza.Count - 1
                Me.IdPlaza = IdPlaza(contador)
                Me.Plaza = Plaza(contador)
                Me.ObtenerFechasCalendario()
                If Not (Me.FechaDesde.Equals(DateTime.MinValue) And Me.FechaHasta.Equals(DateTime.MinValue)) Then
                    Me.ObtenerDatosCalendario()
                    Me.ObtenerDatosTotalesCalendario()
                    Me.CargarFactores()
                    Me.CargarDatosArray()
                    Me.CargarColumnasCalendario()
                    Me.CargarEncabezadoCalendario()
                    Me.CargarCuerpoCalendario()
                    Me.CargarPromedios()
                    Me.CargarSpotsSemana()
                    Me.CargarTotalesFinales()
                    Me.CargarTotalesTRPS()
                    Me.CargarTotalesGenerales()
                    Me.CargarEtiquetasTemas()
                    FilaActual += 5
                    If contador <> IdPlaza.Count - 1 Then
                        Me.CopiarCabecera()
                        Me.CopiarCabeceraTotales()
                    End If
                    Me.LimpiarTotalesCache()
                    ColumnaActual = 0
                End If
            Next
            MyBase.CompletarTemplate()
        End Sub

        Protected Overrides Sub ObtenerDatosCalendario()
            Using S As New Spots_detalle
                Me.Spots = S.ReporteCalendarioDiario(IdCampaña, IdAlternativa, FechaDesde, FechaHasta, IdPlaza)
            End Using
        End Sub

        Protected Overrides Sub CargarFactores()
            MyBase.CargarFactores()
            Me.SpotsTotales = New DataView(SpotsTotales, "", "Cadena ASC, Factor DESC", DataViewRowState.CurrentRows).ToTable
        End Sub

        Protected Overrides Sub ObtenerDatosTotalesCalendario()
            Using S As New Spots_detalle
                Me.SpotsTotales = S.ReporteCalendarioDiarioTotales(IdCampaña, IdAlternativa, FechaDesde, FechaHasta, IdPlaza)
                Me.SpotsDatos = Me.SpotsTotales
            End Using
        End Sub

        Protected Overrides Sub CargarDatosArray()
            Dim Dr As DataRow
            Dim DrSpot As DataRow
            Dim DrAnterior As DataRow
            Dim RegCal As RegistroCalendario = New RegistroCalendario
            Dim Datos As New ArrayList
            Dim Dia As DiaCalendario
            Dim PrimerRegistro As Boolean = True

            Me.Spots.Columns.Add("TotalTrps", GetType(Decimal))
            Me.Spots.Columns.Add("Rating", GetType(Decimal))

            DrAnterior = Spots.Rows(Spots.Rows.Count - 1)

            For Each Dr In Spots.Rows
                If PrimerRegistro OrElse Me.EsDiferente(Dr, DrAnterior, True, True) Then
                    RegCal = New RegistroCalendario
                    RegCal.Cargar(Dr, True)
                    Dia = New DiaCalendario(Convert.ToDateTime(Dr("f_spot")), Convert.ToChar(Dr("id_tema")), Convert.ToDouble(Dr("costospot")))
                    RegCal.Dias.Add(Dia)
                    PrimerRegistro = False
                Else
                    Dia = New DiaCalendario(Convert.ToDateTime(Dr("f_spot")), Convert.ToChar(Dr("id_tema")), Convert.ToDouble(Dr("costospot")))
                    RegCal.Dias.Add(Dia)
                    RegCal.Cargar(Dr, True)
                End If

                DrAnterior = Dr
            Next

            Me.SpotsTotales.Columns.Add("TotalTrps", GetType(Decimal))
            Me.SpotsTotales.Columns.Add("Rating", GetType(Decimal))

            DrAnterior = SpotsTotales.Rows(SpotsTotales.Rows.Count - 1)

            For Each Dr In SpotsTotales.Rows
                RegCal = New RegistroCalendario
                RegCal.Cargar(Dr, True)

                If Dr("Tipo_Rating").ToString() = "P" Or Dr("Tipo_Rating").ToString() = "F" Then
                    RegCal.Rating = Convert.ToSingle(Dr("ratingprograma"))
                Else
                    RegCal.Rating = Convert.ToSingle(Dr("ratingtanda"))
                End If

                RegCal.TotalSpots = Convert.ToInt16(Dr("cantidad"))
                RegCal.TotalNeto = RegCal.TarifaNeta * RegCal.Dur * RegCal.TotalSpots
                For Each DrSpot In Spots.Select("Cadena='" & Dr("Cadena").ToString() & "' and Programa='" & Dr("Programa").ToString() & "' and id_tema='" & Dr("id_tema").ToString() & "' and Hora='" & Dr("Hora").ToString() & "'")
                    Dia = New DiaCalendario(Convert.ToDateTime(DrSpot("f_spot")), Convert.ToChar(DrSpot("id_tema")), Convert.ToDouble(DrSpot("costospot")))
                    RegCal.Dias.Add(Dia)
                Next
                Datos.Add(RegCal)
            Next
            Me.SpotsDatos = Me.SpotsTotales
            Me.DatosArray = Datos
        End Sub

        Protected Overrides Sub CargarDatoSpotEnGrilla(ByVal tema As String, ByVal fila As Integer, ByVal columna As Integer, ByVal concatenar As Boolean)
            FOne.CargarDato((1).ToString(), fila, columna, concatenar)
        End Sub

        Protected Overrides Sub CargarTotalesFinales()
            Dim Total As Decimal
            Dim SpotsData As DataTable = SpotsTotales
            Dim formulaSpots As String
            Dim formulaTrps As String
            Dim formulaNetos As String

            Total = SpotsData.Compute("sum(cantidad)", "")

            For Each formula As String In TotalesSpots
                formulaSpots += String.Concat(formula, "+")
            Next

            For Each formula As String In TotalesTrps
                formulaTrps += String.Concat(formula, "+")
            Next

            For Each formula As String In TotalesNetos
                formulaNetos += String.Concat(formula, "+")
            Next

            formulaSpots = formulaSpots.Substring(0, formulaSpots.Length - 1)
            formulaTrps = formulaTrps.Substring(0, formulaTrps.Length - 1)
            formulaNetos = formulaNetos.Substring(0, formulaNetos.Length - 1)

            FOne.Grilla.set_FormulaRC(FilaActual, ColumnaActual - 2, formulaSpots)
            FOne.Grilla.set_FormulaRC(FilaActual, ColumnaActual - 1, formulaTrps)
            FOne.Grilla.set_FormulaRC(FilaActual, ColumnaActual, formulaNetos)

            Me.CargarLeyendasTotales()
        End Sub

        Protected Overrides Sub CargarEnGrilla(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
            MyBase.CargarEnGrilla(Reg, Fila, MaxCol)
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 2, String.Format("SUM({0}:{1})", GetCellName(18, Fila), GetCellName(MaxCol - 4, Fila)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 1, String.Format("{0}*{1}", GetCellName(14, Fila), GetCellName(MaxCol - 2, Fila)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol, String.Format("{0}*{1}", GetCellName(13, Fila), GetCellName(MaxCol - 2, Fila)))
            Me.TotalNetoFinal += Reg.TotalNeto
        End Sub

        Protected Overrides Function CalculoCPRDuracionPromedioCompleto() As DataTable

            Dim DtResultado As DataTable
            Dim DtTemasCalculos As DataTable = ArmarDtCPRPromedio(1)
            Dim DtTemasAplicados As DataTable = Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
            Dim Dr As DataRow
            Dim FilaNueva As DataRow
            Dim DurPromedioFinal, CprPromedioFinal As Single
            Dim SpotsData As DataTable = SpotsTotales

            For Each Dr In DtTemasAplicados.Rows
                FilaNueva = DtTemasCalculos.NewRow
                FilaNueva("id_tema") = Dr("id_tema")
                FilaNueva("Duracion") = Dr("Dur")
                FilaNueva("TotalGrps") = 0
                FilaNueva("SumaTotalInversion") = 0
                FilaNueva("CantTemas") = 0
                FilaNueva("CalculoPonderado1") = 0
                FilaNueva("CalculoPonderado2") = 0
                DtTemasCalculos.Rows.Add(FilaNueva)
            Next

            For Each Dr In DtTemasCalculos.Rows
                Dr("CantTemas") = SpotsData.Compute("SUM(cantidad)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("TotalGrps") = SpotsData.Compute("Sum(ratingprogramatotal)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("CalculoPonderado1") = Dr("TotalGrps") / SpotsData.Compute("sum(ratingprogramatotal)", "")
                Dr("CalculoPonderado2") = Dr("CalculoPonderado1") * Dr("Duracion")
            Next

            DtResultado = ArmarDtCPRPromedio(2)

            DurPromedioFinal = DtTemasCalculos.Compute("sum(CalculoPonderado2)", "")

            If Not DurPromedioFinal.IsNaN(DurPromedioFinal) Then
                Dim TEjercicio As Integer
                Dim ObSistema As New Sistemas

                TEjercicio = ObSistema.ObtenerTipoEjercicio(Activo.IDCampaña, Activo.IDSistema)

                If TEjercicio = Activo.TipoEjercicio.Estandar Then
                    CprPromedioFinal = Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal
                ElseIf TEjercicio = Activo.TipoEjercicio.CPunto Then
                    If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Or Activo.IDCliente = 227 Then ' Cliente Claro
                        CprPromedioFinal = Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal
                    Else
                        CprPromedioFinal = CInt(Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal)
                    End If
                End If
            End If

            FilaNueva = DtResultado.NewRow
            FilaNueva("DurPromFinalPauta") = DurPromedioFinal
            FilaNueva("CPRPromFinalPauta") = CprPromedioFinal
            DtResultado.Rows.Add(FilaNueva)

            Return DtResultado

        End Function

        Protected Overrides Sub LlenarCalculosPromedios()
            Me.CalculosPromedios.Add("sum(tarifanetatotal)/sum(cantidad)")
            Me.CalculosPromedios.Add("sum(duraciontotal)/sum(cantidad)")
            Me.CalculosPromedios.Add("sum(costospottotal)/sum(cantidad)")
        End Sub

        Protected Overrides Sub LlenarCalculosTotales()
            Me.CalculosTotales.Add("sum(tarifanetatotal) / sum(cantidad)")
            Me.CalculosTotales.Add("sum(duraciontotal) / sum(cantidad)")
            Me.CalculosTotales.Add("sum(costospottotal) / sum(cantidad)")

            If TipoRating = "Tanda" Then
                Me.CalculosTotales.Add("sum(RatingTandatotal) / sum(cantidad)")
            Else
                Me.CalculosTotales.Add("sum(RatingProgramatotal) / sum(cantidad)")
            End If
        End Sub

        Protected Overrides Function ObtenerTotalInversion(ByVal Dr As System.Data.DataRow) As Decimal
            Return Convert.ToDecimal(Dr("tarifaneta") * Dr("dur") * Dr("cantidad"))
        End Function

        Protected Overrides Sub CargarTotalesFila(ByRef total As Decimal, ByRef cantidadCadena As Integer, ByRef totalTRP As Decimal, ByRef totalInversionNeta As Decimal, ByVal Cadena As String, ByVal Fila As Integer, ByVal MaxCol As Integer)
            total = SpotsDatos.Compute("sum(cantidad)", "Cadena='" & Cadena & "'")
            cantidadCadena = SpotsDatos.Compute("count(cantidad)", "Cadena='" & Cadena & "'")

            TotalesSpots.Add(String.Format("SUM({0}:{1})", GetCellName(MaxCol - 2, Fila - cantidadCadena), GetCellName(MaxCol - 2, Fila - 1)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 2, String.Format("SUM({0}:{1})", GetCellName(MaxCol - 2, Fila - cantidadCadena), GetCellName(MaxCol - 2, Fila - 1)))

            TotalesTrps.Add(String.Format("SUM({0}:{1})", GetCellName(MaxCol - 1, Fila - cantidadCadena), GetCellName(MaxCol - 1, Fila - 1)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 1, String.Format("SUM({0}:{1})", GetCellName(MaxCol - 1, Fila - cantidadCadena), GetCellName(MaxCol - 1, Fila - 1)))

            TotalesNetos.Add(String.Format("SUM({0}:{1})", GetCellName(MaxCol, Fila - cantidadCadena), GetCellName(MaxCol, Fila - 1)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol, String.Format("SUM({0}:{1})", GetCellName(MaxCol, Fila - cantidadCadena), GetCellName(MaxCol, Fila - 1)))
        End Sub
    End Class
End Namespace

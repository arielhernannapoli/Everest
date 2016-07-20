Imports System.Collections.Generic

Namespace Calendarios.TVRadio
    Public Class CalendarioDiarioConLetrasTVRadio
        Inherits CalendarioDiarioConLetras

        Public Sub New(ByVal FOne As AdminFormulaOne, ByVal IdPlaza As List(Of Integer), ByVal Plaza As List(Of String), ByVal IdCampaña As Integer, ByVal IdAlternativa As Integer, ByVal IdCompania As Integer, ByVal IdMedio As Integer, ByVal Alternativa As String, ByVal SemanaNatural As Boolean, ByVal CalcularIVA As Boolean, ByVal CalcularIVANetoAgencia As Boolean, ByVal CalcularIVASoloAgencia As Boolean)
            Dim contador As Integer = 0
            Me.FOne = FOne
            Me.IdCampaña = IdCampaña
            Me.IdAlternativa = IdAlternativa
            Me.IdCompania = IdCompania
            Me.IdMedio = IdMedio
            Me.Plaza = String.Empty
            Me.mDescripcion = Alternativa
            Me.SemanaNatural = SemanaNatural
            Me.CalcularIVA = CalcularIVA
            Me.CalcularIVANetoAgencia = CalcularIVANetoAgencia
            Me.UrlTemplate = String.Concat(Application.StartupPath, "\Comun\caldiarionuevo.vts")
            MyBase.InicializarTemplate()
            Me.OcultarColumnas()
            FilaActual = 1
            For contador = 0 To IdPlaza.Count - 1
                Me.IdPlaza = IdPlaza(contador)
                Me.Plaza = Plaza(contador)
                Me.ObtenerFechasCalendario()
                If Not (Me.FechaDesde.Equals(DateTime.MinValue) And Me.FechaHasta.Equals(DateTime.MinValue)) Then
                    Me.ObtenerDatosCalendario()
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

        Private Sub OcultarColumnas()
            FOne.Grilla.ClearRange(1, 16, FOne.Grilla.MaxRow, 16, VCF150.F1ClearTypeConstants.F1ClearValues)
            FOne.Grilla.ClearRange(1, 16, FOne.Grilla.MaxRow, 16, VCF150.F1ClearTypeConstants.F1ClearFormats)
            FOne.Grilla.SetColHidden(16, 16, True)
        End Sub

        Protected Overrides Sub CargarDatosArray()
            Dim Dr As DataRow
            Dim DrAnterior As DataRow
            Dim RegCal As RegistroCalendario = New RegistroCalendario
            Dim Datos As New ArrayList
            Dim Dia As DiaCalendario
            Dim PrimerRegistro As Boolean = True

            Me.Spots.Columns.Add("TotalTrps", GetType(Decimal))
            Me.Spots.Columns.Add("Rating", GetType(Decimal))

            DrAnterior = Me.Spots.Rows(Spots.Rows.Count - 1)

            For Each Dr In Me.Spots.Rows
                If PrimerRegistro OrElse Me.EsDiferente(Dr, DrAnterior, True, True) Then
                    RegCal = New RegistroCalendario
                    RegCal.Cargar(Dr, True)
                    Dia = New DiaCalendario(Convert.ToDateTime(Dr("f_spot")), Convert.ToChar(Dr("id_tema")), Convert.ToDouble(Dr("costospot")))
                    RegCal.Dias.Add(Dia)
                    Datos.Add(RegCal)
                    PrimerRegistro = False
                Else
                    Dia = New DiaCalendario(Convert.ToDateTime(Dr("f_spot")), Convert.ToChar(Dr("id_tema")), Convert.ToDouble(Dr("costospot")))
                    RegCal.Dias.Add(Dia)
                    RegCal.Cargar(Dr, True)
                End If

                DrAnterior = Dr
            Next
            Me.SpotsDatos = Me.Spots
            Me.DatosArray = Datos
        End Sub

        Protected Overrides Sub ObtenerDatosCalendario()
            Using S As New Spots_detalle
                Me.Spots = S.ReporteCalendarioDiario(IdCampaña, IdAlternativa, FechaDesde, FechaHasta, IdPlaza)
                Me.SpotsDatos = Me.Spots
            End Using
        End Sub

        Protected Overrides Sub CargarTotalesFinales()
            Dim Total As Decimal
            Dim SpotsData As DataTable = Spots

            Total = SpotsData.Compute("sum(Factor)", "")
            FOne.CargarDato(Math.Round(Total), FilaActual, ColumnaActual - 2)
            Total = SpotsData.Compute("sum(rating)", "")
            FOne.CargarDato(Math.Round(Total, 2), FilaActual, ColumnaActual - 1)
            FOne.CargarDato("$ " & Format(Me.TotalNetoFinal, "#,##0.00"), FilaActual, ColumnaActual)

            Me.CargarLeyendasTotales()
        End Sub

        Protected Overrides Sub CargarEnGrilla(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
            MyBase.CargarEnGrilla(Reg, Fila, MaxCol)
            FOne.CargarDato(Reg.TotalSpots * Reg.Factor, Fila, MaxCol - 2)
            FOne.CargarDato(Math.Round(Reg.TotalTrps, 1), Fila, MaxCol - 1)
            FOne.CargarDato("$ " & Format(Reg.TotalNeto, "#,##0.00"), Fila, MaxCol)
            Me.TotalNetoFinal += Reg.TotalNeto
        End Sub

    End Class
End Namespace

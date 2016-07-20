Imports System.Collections.Generic

Namespace Calendarios
    Public MustInherit Class CalendarioDiario
        Protected FOne As AdminFormulaOne
        Protected IdPlaza As Integer
        Protected IdCampaña As Integer
        Protected IdAlternativa As Integer
        Protected IdCompania As Integer
        Protected IdMedio As Integer
        Protected Spots As DataTable
        Protected SpotsDatos As DataTable
        Protected FechaDesde As Date
        Protected FechaHasta As Date
        Protected FilaActual As Integer
        Protected ColumnaActual As Integer
        Protected UrlTemplate As String
        Protected DatosArray As ArrayList
        Protected SemanaNatural As Boolean
        Protected TipoRating As String
        Protected Plaza As String
        Protected mDescripcion As String
        Protected TotalesSpots As List(Of String) = New List(Of String)
        Protected TotalesTrps As List(Of String) = New List(Of String)
        Protected TotalesNetos As List(Of String) = New List(Of String)
        Protected TotalNetoFinal As Decimal
        Protected MostrarNeto As Boolean
        Protected CalcularIVA As Boolean
        Protected CalcularIVANetoAgencia As Boolean
        Protected ColumnaInicio As Integer = 18
        Protected CantidadColumnas As Integer = 15
        Protected ColumnaRatingTanda As String = "RATINGTANDA"
        Protected ColumnaRatingPrograma As String = "RATINGPROGRAMA"
        Protected CalculosPromedios As New ArrayList
        Protected CalculosTotales As New ArrayList

        Protected MustOverride Sub ObtenerDatosCalendario()
        Protected MustOverride Sub CargarDatosArray()
        Protected MustOverride Sub CargarTotalesFinales()

        Protected Sub InicializarTemplate()
            FOne.CargarTemplate(UrlTemplate)
            FOne.Grilla.SetSelection(1, 25, 1, 25)
            Me.ConfigurarLogo()
        End Sub

        Protected Sub CompletarTemplate()
            FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(FOne.Grilla.MaxCol) & "$" & FOne.Grilla.MaxRow
            FOne.Grilla.PrintRowHeading = False
            FOne.Grilla.PrintGridLines = False
            FOne.Grilla.PrintLandscape = True
            FOne.Grilla.PrintLeftMargin = 0.8
            FOne.Grilla.PrintRightMargin = 0.2
            FOne.Grilla.PrintBottomMargin = 0.2
            FOne.Grilla.PrintHeaderMargin = 0.5
            FOne.Grilla.PrintTopMargin = 0.5
            FOne.Grilla.PrintHeader = ""
            FOne.Grilla.PrintHCenter = False
            FOne.Grilla.PrintScaleFitHPages = 1
            FOne.Grilla.PrintScale = 100
            FOne.Grilla.SetSelection(1, 1, 1, 1)
        End Sub

        Private Function GetLetras(ByVal Col As Integer) As String
            Dim ret As Integer
            ret = Int(Col / 26)
            Return IIf(ret = 0, "", Chr(ret + 64)) & Chr(Col - (ret * 26) + 65)
        End Function

        Private Sub ConfigurarLogo()
            Try
                Select Case Activo.IDCompaniaMMS
                    Case 35, 39
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoMPG"), 17, 4, 22, 6)
                        FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoMPG"), 17, 1, 22, 3)
                    Case 36
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoARE"), 17, 4, 22, 6)
                        FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoARE"), 17, 1, 22, 3)
                    Case 38
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoPRX"), 17, 4, 22, 6)
                        FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoPRX"), 17, 1, 22, 3)
                    Case 41
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoFWD"), 17, 4, 22, 6)
                        FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoFWD"), 17, 1, 22, 3)
                    Case 42
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                        FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoSCL"), 17, 4, 22, 6)
                        FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                        FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoSCL"), 17, 1, 22, 3)
                End Select

            Catch e As Exception

            End Try
        End Sub

        Protected Function GetCellName(ByVal column As Integer, ByVal row As Integer) As String
            Dim cells As New List(Of String)(New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
            If column > cells.Count Then
                Dim ciclos As Integer = Math.Truncate(column / cells.Count)
                Dim cellName As String = cells(ciclos - 1)
                If (column - 1 - (cells.Count() * ciclos)) < 0 Then
                    Return String.Format("{0}{1}", String.Format("{0}{1}", cellName, cells(cells.Count - Math.Abs(column - 1 - (cells.Count() * ciclos)))), row)
                Else
                    Return String.Format("{0}{1}", String.Format("{0}{1}", cellName, cells(column - 1 - (cells.Count() * ciclos))), row)
                End If
            Else
                Return String.Format("{0}{1}", cells(column - 1), row)
            End If
        End Function

        Protected Function ArmarDtCPRPromedio(ByVal TipoDt As Integer)

            Dim DtDatos As New DataTable
            Select Case TipoDt
                Case 1
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                Case 2
                    DtDatos.Columns.Add("DurPromFinalPauta", GetType(Single))
                    DtDatos.Columns.Add("CPRPromFinalPauta", GetType(Single))
                Case 3
                    DtDatos.Columns.Add("Cadena", GetType(String))
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                Case 4
                    DtDatos.Columns.Add("Cadena", GetType(String))
                    DtDatos.Columns.Add("DurPromCadena", GetType(Single))
                    DtDatos.Columns.Add("CPRPromCadena", GetType(Single))
                Case 5
                    DtDatos.Columns.Add("Cadena", GetType(String))
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                    DtDatos.Columns.Add("DurPromCadena", GetType(Single))
                    DtDatos.Columns.Add("CPRPromCadena", GetType(Single))
                Case 6
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                    DtDatos.Columns.Add("DurPromCadena", GetType(Single))
                    DtDatos.Columns.Add("CPRPromCadena", GetType(Single))
                Case 7
                    DtDatos.Columns.Add("Semana", GetType(Integer))
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                    DtDatos.Columns.Add("DurPromSemana", GetType(Single))
                    DtDatos.Columns.Add("CPRPromSemana", GetType(Single))
                Case 8
                    DtDatos.Columns.Add("Dia", GetType(String))
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                    DtDatos.Columns.Add("DurPromDia", GetType(Single))
                    DtDatos.Columns.Add("CPRPromDia", GetType(Single))
                Case 9
                    DtDatos.Columns.Add("Franja", GetType(Integer))
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                    DtDatos.Columns.Add("DurPromFranja", GetType(Single))
                    DtDatos.Columns.Add("CPRPromFranja", GetType(Single))
                Case 10
                    DtDatos.Columns.Add("Soporte", GetType(String))
                    DtDatos.Columns.Add("id_tema", GetType(String))
                    DtDatos.Columns.Add("Duracion", GetType(String))
                    DtDatos.Columns.Add("TotalGrps", GetType(Single))
                    DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                    DtDatos.Columns.Add("CantTemas", GetType(Integer))
                    DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                    DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                    DtDatos.Columns.Add("DurPromFraSoporte", GetType(Single))
                    DtDatos.Columns.Add("CPRPromFraSoporte", GetType(Single))
            End Select
            Return DtDatos

        End Function

        Protected Sub CargarEncabezadoCalendario()
            Dim ColSegundaColumna As Integer = 11
            Dim Dt As DataTable
            Dim Separador As String = " / "

            FOne.CargarDato(String.Empty, FilaActual + 5, 2)
            FOne.CargarDato(String.Empty, FilaActual, ColSegundaColumna)
            FOne.CargarDato(String.Empty, FilaActual + 3, ColSegundaColumna)
            FOne.CargarDato(String.Empty, FilaActual + 4, ColSegundaColumna)

            FOne.CargarDato(Activo.Cliente, FilaActual, 2)
            FOne.CargarDato(Activo.Cliente, FilaActual + 1, 2)
            FOne.CargarDato(Activo.Campaña, FilaActual + 3, 2)
            FOne.CargarDato(FechaDesde & " al " & FechaHasta, FilaActual + 4, 2)
            FOne.CargarDato(Plaza, FilaActual + 5, 2, True)
            FOne.CargarDato(mDescripcion, FilaActual + 6, 2)

            Using S As New Spots_detalle
                Dt = S.ObtenerCalendarioEncabezado(IdCampaña, IdAlternativa, IdPlaza, IdMedio, FechaDesde, FechaHasta)

                For Each Dr As DataRow In Dt.Rows
                    If Dr Is Dt.Rows(Dt.Rows.Count - 1) Then
                        Separador = ""
                    End If

                    FOne.CargarDato(Dr("target").ToString() & Separador, FilaActual, ColSegundaColumna, True)

                    FOne.CargarDato(Dr("f_inicio_aud").ToString() & " al " & Dr("f_fin_aud").ToString() & IIf(Separador = " / ", " * ", "").ToString(), FilaActual + 3, ColSegundaColumna, True)

                    Select Case Dr("tipo_rating").ToString.ToLower
                        Case "p"
                            TipoRating = "Programa"
                        Case "t"
                            TipoRating = "Tanda"
                        Case "f"
                            TipoRating = "Franja"
                    End Select

                    FOne.CargarDato(Dr("tipo_soporte").ToString() & " - " & TipoRating & Separador, FilaActual + 4, ColSegundaColumna, True)
                Next
            End Using
        End Sub

        Protected Sub CargarTotalesTemas(ByVal SoporteDias As SoporteDias, ByVal Fila As Integer, ByVal ColumnaInicio As Integer)
            Dim columna As Integer = ColumnaInicio
            Dim sumatoria As Integer = 0
            Dim contador As Integer = 0
            Dim columnaInicial As Integer = 0
            Dim columnaFinal As Integer = 0
            Dim mes As Integer = 0
            Dim total As Double = 0
            Dim dias As Integer = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)
            mes = Me.FechaDesde.Month
            columnaInicial = columna + contador

            While contador <= dias
                While mes = Me.FechaDesde.AddDays(contador).Month And contador <= dias
                    Dim temas As List(Of DiaCalendario) = SoporteDias.Dias.FindAll(Function(x) x.Fecha = Me.FechaDesde.AddDays(contador))
                    total += temas.Select(Function(x) x.Valor).Sum()
                    columnaFinal = columna + contador
                    contador += 1
                End While
                FOne.CargarDato("$ " & Format(total, "#,##0.00"), Fila, columnaInicial, True)
                FOne.Grilla.SetSelection(Fila, columnaInicial, Fila, columnaFinal)
                FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(True))
                FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))
                columnaInicial = columna + contador
                mes = Me.FechaDesde.AddDays(contador).Month
                total = 0
            End While

        End Sub

        Private Function GetFormatoCeldaGPR(ByVal merge As Boolean) As VCF150.F1CellFormat
            Dim formatoCeldaGPR As VCF150.F1CellFormat
            formatoCeldaGPR = FOne.Grilla.CreateNewCellFormat()
            If merge Then
                formatoCeldaGPR.AlignHorizontal = VCF150.F1HAlignConstants.F1HAlignCenterAcrossCells
            Else
                formatoCeldaGPR.AlignHorizontal = VCF150.F1HAlignConstants.F1HAlignCenter
            End If
            formatoCeldaGPR.FontBold = True
            formatoCeldaGPR.FontSize = 10
            formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1LeftBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
            formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1RightBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
            formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1TopBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
            formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1BottomBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
            Return formatoCeldaGPR
        End Function

        Protected Sub CopiarCabeceraTotales()
            FOne.Grilla.SetSelection(9, ColumnaActual - 2, 11, ColumnaActual)
            FOne.Grilla.EditCopy()
            FOne.Grilla.SetSelection(FilaActual + 8, 20, FilaActual + 10, 22)
            FOne.Grilla.EditPaste()
        End Sub

        Protected Sub LimpiarTotalesCache()
            Me.TotalesNetos.Clear()
            Me.TotalesSpots.Clear()
            Me.TotalesTrps.Clear()
            Me.TotalNetoFinal = 0
        End Sub

        Protected Function EsDiferente(ByVal Dr1 As DataRow, ByVal Dr2 As DataRow, Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As Boolean
            Dim Campos As New ArrayList

            If EsCalendarioDiario Then
                Campos.Add("Cadena")
                If MostrarCampoDia Then
                    Campos.Add("Dia")
                End If
                Campos.Add("Programa")
                Campos.Add("TarifaBruta")
                Campos.Add("D1")
                Campos.Add("D2")
                Campos.Add("D3")
                Campos.Add("D4")
                Campos.Add("D5")
                Campos.Add("TarifaNeta")
                Campos.Add("Dur")
                Campos.Add("Hora")
                Campos.Add("Rating")
                Campos.Add("Factor")
            Else
                Campos.Add("Cadena")
                If MostrarCampoDia Then
                    Campos.Add("Dia")
                End If
                Campos.Add("Programa")
                Campos.Add("Rating")
                Campos.Add("Factor")
            End If

            For Each S As String In Campos
                If Dr1(S) Is DBNull.Value Or Dr2(S) Is DBNull.Value Then
                    If Not Dr1(S) Is Dr2(S) Then
                    End If
                Else
                    If Dr1(S).ToString() <> Dr2(S).ToString() Then
                        Return True
                    End If
                End If
            Next

            Return False
        End Function

        Protected Function CalculoCPRPromedioXCadena(ByVal Cadena As String, ByVal TotalInsercionXsoporte As Decimal) As DataTable

            Dim DtResultado As DataTable
            Dim DtCadenaDatos As DataTable = ArmarDtCPRPromedio(3)
            Dim DtCadena As DataTable = Spots.DefaultView.ToTable(True, "Cadena")
            Dim DtTemas As DataTable = Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
            Dim Dr As DataRow
            Dim DrTemas As DataRow
            Dim FilaNueva As DataRow
            Dim DurPromedioSoporte, CprPromedioSoporte As Single
            Dim DrGrps() As DataRow

            For Each Dr In DtCadena.Rows
                For Each DrTemas In DtTemas.Rows
                    FilaNueva = DtCadenaDatos.NewRow
                    FilaNueva("Cadena") = Dr("Cadena")
                    FilaNueva("TotalGrps") = Spots.Compute("Sum(rating)", "Cadena='" & Dr("Cadena") & "' AND ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                    If FilaNueva("TotalGrps").ToString() <> "" Then
                        FilaNueva("id_tema") = DrTemas("ID_TEMA")
                        FilaNueva("Duracion") = DrTemas("Dur")
                        FilaNueva("CantTemas") = Spots.Compute("Count(ID_TEMA)", "Cadena='" & Dr("Cadena") & "' AND ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                        FilaNueva("CalculoPonderado1") = FilaNueva("TotalGrps") / Spots.Compute("Sum(rating)", "Cadena='" & Dr("Cadena") & "'")
                        FilaNueva("CalculoPonderado2") = FilaNueva("CalculoPonderado1") * DrTemas("Dur")
                        DtCadenaDatos.Rows.Add(FilaNueva)
                    End If
                Next
            Next


            DtResultado = ArmarDtCPRPromedio(4)
            Dim TotalnetoSoporte As Decimal
            TotalnetoSoporte = Spots.Compute("Sum(CostoSpot)", "Cadena='" & Cadena & "'")

            DurPromedioSoporte = DtCadenaDatos.Compute("Sum(CalculoPonderado2)", "Cadena='" & Cadena & "'")
            CprPromedioSoporte = TotalInsercionXsoporte / DtCadenaDatos.Compute("Sum(TotalGrps)", "Cadena='" & Cadena & "'") / DurPromedioSoporte

            FilaNueva = DtResultado.NewRow
            FilaNueva("Cadena") = Cadena
            FilaNueva("DurPromCadena") = Math.Round(DurPromedioSoporte, 2)
            FilaNueva("CPRPromCadena") = Math.Round(CprPromedioSoporte, 2)

            DtResultado.Rows.Add(FilaNueva)

            Return DtResultado

        End Function

        Protected Sub ObtenerFechasCalendario()
            Using S As New Spots_detalle
                Dim fechasSpots As DataTable = S.FechasCalendario(IdCampaña, IdAlternativa, IdPlaza)
                If fechasSpots.Rows.Count > 0 Then
                    Me.FechaDesde = DateTime.Parse(fechasSpots.Select("", "f_spot asc")(0).Item("f_spot").ToString())
                    Me.FechaHasta = DateTime.Parse(fechasSpots.Select("", "f_spot desc")(0).Item("f_spot").ToString())
                Else
                    Me.FechaDesde = DateTime.MinValue
                    Me.FechaHasta = DateTime.MinValue
                End If
            End Using
        End Sub

        Protected Sub CargarColumnasCalendario()
            Dim i, j, Dias As Integer
            Dim MesAnterior As String = String.Empty
            Dim primerDiaDespuesDeDomingo As Boolean = False
            Dias = Convert.ToInt16(DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta))

            For i = 0 To Dias
                Dim D As New DiaCalendario(Me.FechaDesde.AddDays(i))

                If i < Dias Then
                    FOne.DuplicarColumna(ColumnaInicio + i, FilaActual + 8, FilaActual + 21)
                End If

                If MesAnterior <> D.MesLetras Then
                    FOne.CargarDato(D.MesLetras, FilaActual + 8, ColumnaInicio + i)
                    MesAnterior = D.MesLetras

                    If primerDiaDespuesDeDomingo Then
                        FOne.CargarBorde(FilaActual + 8, ColumnaInicio + i, ColumnaInicio + i, 2, 1, 1, 1, -1)
                        primerDiaDespuesDeDomingo = False
                    Else
                        FOne.CargarBorde(FilaActual + 8, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If

                If primerDiaDespuesDeDomingo Then
                    FOne.CargarBorde(FilaActual + 9, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.BordeMedio, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)
                    FOne.CargarBorde(FilaActual + 10, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.BordeMedio, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)
                    FOne.CargarBorde(FilaActual + 11, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.BordeMedio, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)
                    primerDiaDespuesDeDomingo = False
                End If

                If (Me.SemanaNatural And D.Fecha.DayOfWeek = DayOfWeek.Sunday) Or (Not Me.SemanaNatural And (i + 1) Mod 7 = 0) Then
                    FOne.CargarBorde(FilaActual + 9, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    FOne.CargarBorde(FilaActual + 10, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    FOne.CargarBorde(FilaActual + 11, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    primerDiaDespuesDeDomingo = True
                End If
                j += 1

                FOne.CargarDato(D.DiaLetras, FilaActual + 9, ColumnaInicio + i)
                FOne.CargarDato(D.DiaNumero, FilaActual + 10, ColumnaInicio + i)

                FOne.Grilla.set_ColWidth(ColumnaInicio + i, 2000)

            Next

            FOne.Grilla.set_ColWidth(ColumnaInicio + i, FOne.Grilla.get_ColWidth(ColumnaInicio - 1))

            FOne.CargarBorde(FilaActual + 8, ColumnaInicio, ColumnaInicio + i - 1, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio)

            FOne.CargarBorde(FilaActual + 9, ColumnaInicio, ColumnaInicio + i - 1, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)
            FOne.CargarBorde(FilaActual + 10, ColumnaInicio, ColumnaInicio + i - 1, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)

            FOne.Grilla.SetSelection(FilaActual + 8, ColumnaInicio, FilaActual + 10, ColumnaInicio + i - 1)
            FOne.Grilla.FontBold = True

            Me.ColumnaActual = ColumnaInicio + i + 3
        End Sub

        Protected Overridable Sub CargarFactores()
            Using S As New Spots_detalle
                Dim factor As DataTable
                Dim i As Integer = 0
                Dim codigoOrdenesMMS As String = String.Empty
                Dim columnaFactor As DataColumn
                columnaFactor = New DataColumn("Factor", GetType(Integer))
                columnaFactor.DefaultValue = 1
                Me.Spots.Columns.Add(columnaFactor)
                For Each Dr As DataRow In Me.Spots.Rows
                    If Spots.Columns.Contains("id_orden_sigeme") AndAlso Dr("id_orden_sigeme").ToString() <> String.Empty Then
                        codigoOrdenesMMS += Dr("id_orden_sigeme").ToString() + ","
                    Else
                        Dr("Factor") = 1
                    End If
                    If (i = 100 Or i = Me.Spots.Rows.Count - 1) And codigoOrdenesMMS <> String.Empty Then
                        codigoOrdenesMMS = codigoOrdenesMMS.Substring(0, codigoOrdenesMMS.Length - 1)
                        factor = S.ObtenerFactor(codigoOrdenesMMS, IdCompania, IdMedio)
                        For Each factorDr As DataRow In factor.Rows
                            Dim codigoOrdenMMS As Integer = Convert.ToInt32(factorDr("cod_orden").ToString())
                            For Each spotDr As DataRow In Me.Spots.Rows
                                If spotDr("id_orden_sigeme").ToString() <> String.Empty Then
                                    If spotDr("id_orden_sigeme").ToString() = factorDr("cod_orden").ToString() Then
                                        spotDr("Factor") = factorDr("Factor")
                                    End If
                                End If
                            Next
                        Next
                        i = 0
                        codigoOrdenesMMS = String.Empty
                    ElseIf i < 1000 Then
                        i = i + 1
                    End If
                Next
            End Using
            Me.Spots = New DataView(Spots, "", "Cadena ASC, Factor DESC", DataViewRowState.CurrentRows).ToTable
        End Sub

        Protected Overridable Sub CargarEnGrilla(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
            FOne.CargarDato(Reg.Cadena, Fila, 1)
            FOne.CargarDato(Reg.Dia, Fila, 2)
            FOne.CargarDato(Reg.Hora, Fila, 3)
            FOne.CargarDato(Reg.Programa, Fila, 4)
            FOne.CargarDato(Reg.TarifaBruta, Fila, 5)
            FOne.CargarDato(Reg.D1, Fila, 6)
            FOne.CargarDato(Reg.D2, Fila, 7)
            FOne.CargarDato(Reg.D3, Fila, 8)
            FOne.CargarDato(Reg.D4, Fila, 9)
            FOne.CargarDato(Reg.D5, Fila, 10)
            FOne.CargarDato(Format(Reg.TarifaNeta, "#,##0.00"), Fila, 11)
            FOne.CargarDato(Reg.Dur, Fila, 12)
            FOne.CargarDato("$ " & Format(Reg.CostoSpot, "#,##0.00"), Fila, 13)
            FOne.CargarDato(Format(Reg.Rating, "#,##0.00"), Fila, 14)
            FOne.CargarDato("$ " & Format(Reg.CPR, "#0.00"), Fila, 15)
            FOne.CargarDato(Reg.Tema, Fila, 16)
        End Sub

        Protected Sub CargarCuerpoCalendario()
            Dim i As Integer
            Dim CadenaAnterior As String
            Dim Texto As String
            Dim ColCal As Integer
            Dim SoporteDias As New SoporteDias

            FilaActual = FilaActual + 11

            CadenaAnterior = DirectCast(DatosArray(0), RegistroCalendario).Cadena

            SoporteDias.Soporte = CadenaAnterior

            For Each R As RegistroCalendario In DatosArray
                If CadenaAnterior <> R.Cadena Then
                    FOne.DuplicarFila(FilaActual, 1, ColumnaActual)

                    Me.CargarTotalesCadena(CadenaAnterior, FilaActual, ColumnaActual)

                    Me.CargarTotalesTemas(SoporteDias, FilaActual, ColumnaInicio)

                    FilaActual += 1
                    FOne.DuplicarFila(FilaActual, 1, ColumnaActual)
                    FilaActual += 1

                    CadenaAnterior = R.Cadena

                    SoporteDias.Soporte = CadenaAnterior
                    SoporteDias.Dias.Clear()

                End If

                FOne.DuplicarFila(FilaActual, 1, ColumnaActual)

                Me.CargarEnGrilla(R, FilaActual, ColumnaActual)

                For Each D As DiaCalendario In R.Dias
                    Try
                        ColCal = Convert.ToInt16(DateDiff(DateInterval.Day, Me.FechaDesde, D.Fecha))
                        Me.CargarDatoSpotEnGrilla(D.Tema, FilaActual, ColumnaInicio + ColCal, True)
                    Catch e As Exception

                    End Try
                Next

                FOne.CargarBorde(FilaActual, ColumnaActual - 2, ColumnaActual, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)

                Texto = ""

                ' SETEO DE BORDES DE CELDAS DEL CALENDARIO
                For col As Integer = 0 To Convert.ToInt16(DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta))
                    FOne.CargarBorde(FilaActual, ColumnaInicio + col, ColumnaInicio + col, TipoBorde.BordeMedio, TipoBorde.BordeMedio, TipoBorde.BordeMedio, TipoBorde.BordeMedio)
                Next

                For col As Integer = 0 To Convert.ToInt16(DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta))
                    Dim fechaDif As Date = Me.FechaDesde.AddDays(col)
                    If fechaDif.DayOfWeek = DayOfWeek.Sunday Then
                        FOne.CargarBorde(FilaActual, ColumnaInicio + col, ColumnaInicio + col, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    ElseIf fechaDif.DayOfWeek = DayOfWeek.Monday Then
                        FOne.CargarBorde(FilaActual, ColumnaInicio + col, ColumnaInicio + col, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                Next

                FilaActual += 1

                SoporteDias.Dias.AddRange(R.Dias.Cast(Of DiaCalendario).ToList())

            Next

            Me.CargarTotalesCadena(CadenaAnterior, FilaActual, ColumnaActual)
            Me.CargarTotalesTemas(SoporteDias, FilaActual, ColumnaInicio)

            FOne.CargarBorde(FilaActual, ColumnaActual - 2, ColumnaActual, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)

            FilaActual += 2
        End Sub

        Protected Overridable Sub CargarDatoSpotEnGrilla(ByVal tema As String, ByVal fila As Integer, ByVal columna As Integer, ByVal concatenar As Boolean)
            FOne.CargarDato(tema, fila, columna, concatenar)
        End Sub

        Protected Sub CargarEtiquetasTemas()
            Dim A As New Alternativas
            Dim Temas As DataTable
            Dim Texto As String
            Dim Productos As String
            Dim totalTemas As Integer

            A.Id_campania = IdCampaña
            A.Id_alternativa = IdAlternativa

            Temas = A.ObtenerTemasGuardados

            For i As Integer = 0 To Temas.Rows.Count - 1
                Texto = "[" & Temas.Rows(i)("id_tema") & "] " & _
                Temas.Rows(i)("descripcion") & " " & _
                Temas.Rows(i)("duracion") & """ " & _
                Temas.Rows(i)("material")

                FOne.CargarDato(Texto, FilaActual + 2 + i, 4)

                Productos &= Temas.Rows(i)("descripcion") & ", "
            Next

            Productos = Productos.Substring(0, Productos.Length - 2)
            FOne.CargarDato(Productos, 3, 2)

            totalTemas = Temas.Rows.Count

            If totalTemas > 8 Then
                FOne.Grilla.MaxRow = FilaActual + 9 + (Math.Abs(totalTemas - 8))
            Else
                FOne.Grilla.MaxRow = FilaActual + 8
            End If

            FilaActual = FOne.Grilla.MaxRow

            FOne.Grilla.MaxCol -= 1
        End Sub

        Protected Sub CopiarCabecera()
            FOne.Grilla.SetSelection(1, 1, 12, CantidadColumnas)
            FOne.Grilla.EditCopy()
            FOne.Grilla.SetSelection(FilaActual, 1, FilaActual + 12, CantidadColumnas)
            FOne.Grilla.EditPaste()
        End Sub

        Protected Sub CargarTotalesGenerales()
            Dim Total As Decimal
            Dim Texto As String
            Dim SpotsData As DataTable = Spots
            Dim neto As Single
            Dim durprom As Single
            Dim trp As Single
            Dim C As New Clientes
            Dim T As Decimal
            Dim AuxI As Decimal
            Dim IVA As Decimal

            neto = Me.TotalNetoFinal
            trp = SpotsData.Compute("sum(rating)", "")
            durprom = SpotsData.Compute("sum(dur)", "") / SpotsData.Compute("count(rating)", "")

            If neto > 0 Then
                Total = Valores.CastNulo(CalculoCPRDuracionPromedioCompleto().Rows(0)("CPRPromFinalPauta"))
            End If

            FOne.CargarDato("$ " & Format(Total, "#,##0.00"), FilaActual + 2, ColumnaActual)

            Total = Math.Round(CDec(FOne.LeerDato(FilaActual, ColumnaActual)), 2)

            FOne.CargarDato("$ " & Format(Total, "#,##0.00"), FilaActual + 3, ColumnaActual)

            C.Id_cliente = Activo.IDCliente
            C.BuscarPorId()
            C.BuscarPorIDSAG()

            Texto = "S.A. " & C.Servicio_agencia & "%"
            FOne.CargarDato(Texto, FilaActual + 4, ColumnaActual - 2)

            Texto = (Total * C.Servicio_agencia / 100).ToString("0.00")
            T = Texto
            FOne.CargarDato(Format(CDec(Texto), "#,##0.00"), FilaActual + 4, ColumnaActual)

            Texto = (Total + CDec(T)).ToString("0.00")
            T = Texto
            FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), FilaActual + 5, ColumnaActual)

            If CalcularIVA Then
                IVA = 21

                Texto = "IVA " & IVA & "%"
                FOne.CargarDato(Texto, FilaActual + 6, ColumnaActual - 2)

                If CalcularIVANetoAgencia Then
                    Texto = (Total * IVA / 100).ToString("0.00")
                    AuxI = Texto
                    FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), FilaActual + 6, ColumnaActual)
                Else
                    Total = CDec(FOne.LeerDato(FilaActual + 4, ColumnaActual))
                    Texto = (Total * IVA / 100).ToString("0.00")
                    AuxI = Texto
                    FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), FilaActual + 6, ColumnaActual)
                End If

                Texto = CDec(T + AuxI)
                FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), FilaActual + 7, ColumnaActual)
            Else
                FOne.CargarDato("", FilaActual + 6, ColumnaActual - 2)
                Texto = CDec(FOne.LeerDato(FilaActual + 5, ColumnaActual)).ToString("0.00")
                FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), FilaActual + 7, ColumnaActual)
            End If
        End Sub

        Protected Overridable Function CalculoCPRDuracionPromedioCompleto() As DataTable

            Dim DtResultado As DataTable
            Dim DtTemasCalculos As DataTable = ArmarDtCPRPromedio(1)
            Dim DtTemasAplicados As DataTable = Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
            Dim Dr As DataRow
            Dim FilaNueva As DataRow
            Dim DurPromedioFinal, CprPromedioFinal As Single
            Dim SpotsData As DataTable = Spots
            Dim TEjercicio As Integer
            Dim ObSistema As New Sistemas

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
                Dr("CantTemas") = SpotsData.Select(" ID_TEMA='" & Dr("ID_TEMA") & "'").Count
                Dr("TotalGrps") = SpotsData.Compute("Sum(rating)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("CalculoPonderado1") = Dr("TotalGrps") / SpotsData.Compute("sum(rating)", "")
                Dr("CalculoPonderado2") = Dr("CalculoPonderado1") * Dr("Duracion")
            Next

            DtResultado = ArmarDtCPRPromedio(2)

            DurPromedioFinal = DtTemasCalculos.Compute("sum(CalculoPonderado2)", "")

            If Not DurPromedioFinal.IsNaN(DurPromedioFinal) Then
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

        Protected Sub CargarSpotsSemana()
            Dim Total, TotalSemana, TotalSpots As Integer
            Dim Dias, i As Integer
            Dim SpotsData As DataTable = Spots
            Dim Valor As String

            TotalSpots = Spots.Compute("count(id_tema)", "")

            Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

            FOne.CargarBorde(FilaActual + 2, ColumnaInicio, ColumnaActual - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)

            For i = 0 To Dias
                Try
                    Dim SpotsRow As DataRow() = Spots.Select("f_spot='" & Me.FechaDesde.AddDays(i) & "'")
                    If SpotsRow.Count > 0 Then
                        Total = Spots.Compute("sum(Factor)", "f_spot='" & Me.FechaDesde.AddDays(i) & "'")
                    Else
                        Total = 0
                    End If
                Catch ex As Exception
                    Total = 0
                End Try

                FOne.CargarDato(Total, FilaActual, ColumnaInicio + i)
                FOne.CargarBorde(FilaActual, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)
                TotalSemana += Total

                If (Me.SemanaNatural And (Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias)) Or (Not Me.SemanaNatural And ((i + 1) Mod 7 = 0 Or i = Dias)) Then
                    Valor = TotalSemana & " - " & Math.Round(TotalSemana / TotalSpots * 100, 2) & "%"
                    FOne.CargarDato(Valor, FilaActual + 2, ColumnaInicio + i)
                    TotalSemana = 0
                    If i <> Dias Then
                        FOne.CargarBorde(FilaActual + 2, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(FilaActual, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If                
            Next
        End Sub

        Protected Sub CargarTotalesTRPS()
            Dim TotalDia, TotalSemana, Total, TotalInversion As Decimal
            Dim Filas() As DataRow
            Dim Dr As DataRow
            Dim Dias, i As Integer
            Dim Texto As String
            Dim SpotsData As DataTable = SpotsDatos

            Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

            If TipoRating = "Tanda" Then
                Total = SpotsData.Compute(String.Format("SUM({0})", ColumnaRatingTanda), "")
            Else
                Total = SpotsData.Compute(String.Format("SUM({0})", ColumnaRatingPrograma), "")
            End If

            FOne.CargarBorde(FilaActual + 6, ColumnaInicio, ColumnaActual - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)

            If MostrarNeto Then
                FOne.CargarBorde(FilaActual + 8, ColumnaInicio, ColumnaActual - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)
            End If

            For i = 0 To Dias
                Filas = Spots.Select("f_spot='" & Me.FechaDesde.AddDays(i) & "'")

                For Each Dr In Filas
                    TotalDia += Dr("rating")
                    TotalSemana += Dr("rating")
                    TotalInversion += Dr("TarifaNeta") * Dr("Dur")
                Next

                FOne.CargarDato(TotalDia, FilaActual + 4, ColumnaInicio + i)

                FOne.CargarBorde(FilaActual + 4, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)

                TotalDia = 0

                If (Me.SemanaNatural And (Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias)) Or (Not Me.SemanaNatural And ((i + 1) Mod 7 = 0 Or i = Dias)) Then
                    If Total > 0 Then
                        Texto = Math.Round(TotalSemana, 2) & " - " & Math.Round(TotalSemana / Total * 100, 2) & "%"
                    Else
                        Texto = "Total Cero"
                    End If

                    FOne.CargarDato(Texto, FilaActual + 6, ColumnaInicio + i)

                    If MostrarNeto Then
                        FOne.CargarDato("$ " & Format(TotalInversion, "#,##0.00"), FilaActual + 8, ColumnaInicio + i)
                    End If

                    If i <> Dias Then
                        FOne.CargarBorde(FilaActual + 4, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(FilaActual + 6, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        If MostrarNeto Then
                            FOne.CargarBorde(FilaActual + 8, ColumnaInicio + i, ColumnaInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        End If
                    End If

                    TotalSemana = 0
                    TotalInversion = 0
                End If
            Next
        End Sub

        Protected Sub CargarLeyendasTotales()
            FOne.CargarBorde(FilaActual, ColumnaActual - 2, ColumnaActual, TipoBorde.BordeMedio, TipoBorde.BordeMedio, TipoBorde.BordeMedio, TipoBorde.BordeMedio, -1)

            FOne.CargarDato("C.P.R.", FilaActual + 2, ColumnaActual - 2)
            FOne.CargarDato("Total Neto", FilaActual + 3, ColumnaActual - 2)
            FOne.CargarDato("S.A. 0%", FilaActual + 4, ColumnaActual - 2)
            FOne.CargarDato("Subtotal", FilaActual + 5, ColumnaActual - 2)
            FOne.CargarDato("Total a Pagar", FilaActual + 7, ColumnaActual - 2)
            FOne.CargarDato(String.Empty, FilaActual - 1, 1)
            FOne.CargarDato(String.Empty, FilaActual - 1, 2)
            FOne.CargarDato(String.Empty, FilaActual - 1, 7)
            FOne.CargarDato(String.Empty, FilaActual - 1, 11)

            FOne.Grilla.SetSelection(FilaActual + 2, ColumnaActual - 2, FilaActual + 7, ColumnaActual)
            FOne.Grilla.FontBold = True

            FOne.Grilla.SetSelection(FilaActual, 7, FilaActual, 15)
            FOne.Grilla.FontBold = True

            FOne.Grilla.SetSelection(FilaActual, 15, FilaActual + 8, 15)
            FOne.Grilla.FontBold = True
        End Sub

        Protected Sub CargarPromedios()
            Dim Total As Decimal
            Dim Calculos As New ArrayList
            Dim i As Integer
            Dim ColLabelPromedio As Integer = 7
            Dim ColPromedios As Integer = 11
            Dim ColLabelTotales As Integer = 15
            Dim SpotsData As DataTable = Me.SpotsDatos

            Me.CalculosPromedios.Clear()

            If ColLabelPromedio > 0 Then
                Me.LlenarCalculosPromedios()

                FOne.CargarDato("Promedio", FilaActual, ColLabelPromedio)

                For i = 0 To Me.CalculosPromedios.Count - 1
                    Total = SpotsData.Compute(Me.CalculosPromedios(i), "")
                    FOne.CargarDato(Math.Round(Total, 2), FilaActual, ColPromedios + i)
                Next
            End If

            FOne.CargarDato("Spots por Día", FilaActual, ColLabelTotales)
            FOne.CargarDato("Spots por Semana", FilaActual + 2, ColLabelTotales)
            FOne.CargarDato("Trps por Día", FilaActual + 4, ColLabelTotales)
            FOne.CargarDato("Trps por Semana", FilaActual + 6, ColLabelTotales)

            If MostrarNeto Then
                FOne.CargarDato("Inv. por Semana", FilaActual + 8, ColLabelTotales)
            End If
        End Sub

        Protected Overridable Sub LlenarCalculosPromedios()
            Me.CalculosPromedios.Add("avg(TarifaNeta)")
            Me.CalculosPromedios.Add("avg(Dur)")
            Me.CalculosPromedios.Add("avg(CostoSpot)")
        End Sub

        Protected Overridable Sub LlenarCalculosTotales()
            Me.CalculosTotales.Add("avg(TarifaNeta)")
            Me.CalculosTotales.Add("avg(Dur)")
            Me.CalculosTotales.Add("avg(CostoSpot)")

            If TipoRating = "Tanda" Then
                Me.CalculosTotales.Add("sum(RatingTanda) / count(id_tema)")
            Else
                Me.CalculosTotales.Add("sum(RatingPrograma) / count(id_tema)")
            End If
        End Sub

        Protected Overridable Function ObtenerTotalInversion(ByVal Dr As DataRow) As Decimal
            Return Convert.ToDecimal(Dr("tarifaneta") * Dr("dur"))
        End Function

        Protected Overridable Sub CargarTotalesFila(ByRef total As Decimal, ByRef cantidadCadena As Integer, ByRef totalTRP As Decimal, ByRef totalInversionNeta As Decimal, ByVal Cadena As String, ByVal Fila As Integer, ByVal MaxCol As Integer)
            total = SpotsDatos.Compute("sum(Factor)", "Cadena='" & Cadena & "'")
            cantidadCadena = SpotsDatos.Compute("count(Factor)", "Cadena='" & Cadena & "'")

            FOne.CargarDato(total, Fila, MaxCol - 2)

            FOne.CargarDato(Math.Round(totalTRP, 2), Fila, MaxCol - 1)

            FOne.CargarDato("$ " & Format(totalInversionNeta, "#,##0.00"), Fila, MaxCol)
        End Sub

        Protected Sub CargarTotalesCadena(ByVal Cadena As String, ByRef Fila As Integer, ByVal MaxCol As Integer)
            Dim CantidadCadena As Integer
            Dim Total As Decimal
            Dim TotalTRP As Decimal
            Dim totalInversionNeta As Decimal
            Dim Calculos As New ArrayList
            Dim i As Integer
            Dim SpotsData As DataTable = SpotsDatos

            Me.CalculosTotales.Clear()
            Me.LlenarCalculosTotales()

            TotalTRP = Convert.ToDecimal(SpotsData.Compute("sum(rating)", "Cadena='" & Cadena & "'"))

            totalInversionNeta = 0

            For Each Dr As DataRow In SpotsData.Rows
                If Dr("cadena").ToString() = Cadena Then
                    totalInversionNeta += Me.ObtenerTotalInversion(Dr)
                End If
            Next

            For i = 0 To CalculosTotales.Count - 1
                Total = SpotsData.Compute(CalculosTotales(i), "Cadena='" & Cadena & "'")

                If CalculosTotales(i) = "avg(CostoSpot)" Or CalculosTotales(i) = "avg(CPRTanda)" Or CalculosTotales(i) = "avg(CPRProg)" Then
                    FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila, 11 + i)
                ElseIf CalculosTotales(i) = "sum(Dur) / count(id_tema)" Then
                    FOne.CargarDato(Format(Total, ".0"), Fila, 11 + i)
                Else
                    FOne.CargarDato(Math.Round(Total, 2), Fila, 11 + i)
                End If
            Next

            Dim segundosxcadena As Decimal
            segundosxcadena = SpotsData.Compute(CalculosTotales(1), "Cadena='" & Cadena & "'")
            If segundosxcadena = 0 Or TotalTRP = 0 Or totalInversionNeta = 0 Then
                FOne.CargarDato(0, Fila, 11 + i)
            Else
                FOne.CargarDato(CalculoCPRPromedioXCadena(Cadena, totalInversionNeta).Rows(0)("CPRPromCadena").ToString(), Fila, 11 + i)
            End If

            Me.CargarTotalesFila(Total, CantidadCadena, TotalTRP, totalInversionNeta, Cadena, Fila, MaxCol)

            FOne.Grilla.SetColWidth(50, 50, 4000, False)

            FOne.CargarDato("Total Cadena", Fila, MaxCol - 3)

            FOne.Grilla.SetColWidth(MaxCol - 3, MaxCol - 3, 4000, False)

            FOne.Grilla.SetSelection(Fila, 1, Fila, MaxCol)
            FOne.Grilla.FontBold = True

            FOne.CargarBorde(Fila, 1, MaxCol, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeMedio, -1)
        End Sub
    End Class
End Namespace
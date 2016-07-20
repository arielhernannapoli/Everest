Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics.Shared
Imports System.Drawing

Public Class GrillaFormato
    Dim GrillAdmin As New GrillAdmin
    Shared ColumnasAgrupadas As Integer
    Const MedioRadio As Integer = 6
    Const MedioTv As Integer = 1

    Public Sub MoverColumnaTema(ByVal Grilla As UltraGrid, ByVal Posicion As Int16)
        For Each b As UltraGridBand In Grilla.DisplayLayout.Bands
            If b.Index > 0 Then
                For Each c As UltraGridColumn In Grilla.DisplayLayout.Bands(b.Index).Columns
                    If c.Key.ToLower = "tema" Then
                        Me.MoverColumna(c, Posicion)
                    End If
                Next
            End If
        Next
    End Sub



    Public Sub MoverColumna(ByVal Col As UltraGridColumn, ByVal Posicion As Int16)
        Col.Header.VisiblePosition = Posicion
    End Sub
    Public Sub MoverColumna(ByVal Grilla As UltraGrid, ByVal Colkey As String, ByVal Banda As Int16, ByVal Posicion As Int16)
        Grilla.DisplayLayout.Bands(Banda).Columns(Colkey).Header.VisiblePosition = Posicion
    End Sub

    Public Sub MarcarDiaEvento(ByVal Grid As UltraGrid, ByVal NuevaFila As Infragistics.Win.UltraWinDataSource.UltraDataRow, ByVal FilaActual As UltraGridRow, ByVal ColorEvento As Color)
        Dim Fila As UltraGridRow, celda As UltraGridCell
        For Each r As UltraGridRow In Grid.Rows
            If NuevaFila("ID_Spot") = r.Cells("id_Spot").Text Then
                Fila = r
                Exit For
            End If
        Next

        For Each c As UltraGridCell In FilaActual.Cells
            If c.Appearance.BackColor.Equals(ColorEvento) Then
                celda = c
                Exit For
            Else
                celda = Nothing
            End If

        Next

        If celda Is Nothing Then
            Exit Sub
        End If
        Grid.Rows(Fila.Index).Cells(celda.Column).Appearance.BackColor = ColorEvento
        Me.HabilitarCelda(Grid.Rows(Fila.Index).Cells(celda.Column), Activation.NoEdit)
    End Sub
    Public Sub MarcarDiasPrograma(ByVal Grilla As UltraGrid, ByVal ColorDiasPrograma As Color, ByVal ColorVigenciaNula As Color)
        Dim C As UltraGridColumn
        Dim F As UltraGridRow
        Dim Dias As String

        For Each F In Grilla.Rows
            Dias = F.Cells("dias").Text

            For Each C In Grilla.DisplayLayout.Bands(0).Columns

                If GrillAdmin.EsColumnaCalendario(C) Then
                    'marca las celdas en donde NO sale el programa
                    Me.MarcarDiaColor(C, F, Dias, ColorDiasPrograma)

                    'marca en gris los dias en los que el programa no sale mas al aire
                    Me.AnularDiasVigencia(C, F, ColorVigenciaNula)

                End If
            Next
        Next
    End Sub
    Private Sub AnularDiasVigencia(ByVal Col As UltraGridColumn, ByVal Fila As UltraGridRow, ByVal Color As Color)
        Dim F As UltraGridRow
        'f_inicio_vig - f_fin_vig

        'si la fecha del dia calendario que se paso como parametro NO
        'esta adentro de las fechas de vigencia, les cambia el color
        If Fila.Cells("programa").Text.ToLower = "casero a todo culorr" Then
            'Stop
        End If

        If Not (Col.Key >= Fila.Cells("f_inicio_vig").Value And _
            Col.Key <= Fila.Cells("f_fin_vig").Value) Then


            Fila.Cells(Col).Appearance.BackColor = Color
            Me.HabilitarCelda(Fila.Cells(Col), Activation.NoEdit)

            'Anula dias de vigencia para los temas
            If Activo.IDMedio = MedioRadio Then
                For Each F In Fila.ChildBands(0).Rows
                    F.Cells(Col.Key).Appearance.BackColor = Color
                    Me.HabilitarCelda(F.Cells(Col.Key), Activation.NoEdit)
                Next
                'AG Hoja Numero ============================================
            ElseIf Activo.IDMedio = MedioTv Then
                If Not Fila.ChildBands Is Nothing Then
                    If Fila.ChildBands(0).Rows.Count > 0 Then
                        For Each F In Fila.ChildBands(0).Rows
                            F.Cells(Col.Key).Appearance.BackColor = Color
                            Me.HabilitarCelda(F.Cells(Col.Key), Activation.NoEdit)
                        Next
                    End If
                End If
                '============================================================


            End If
        End If
    End Sub

    Private Sub MarcarDiaColor(ByVal C As UltraGridColumn, ByVal Fila As UltraGridRow, ByVal Dias As String, ByVal Color As Color)
        Dim TieneLetra As Boolean
        Dim F As UltraGridRow
        Dim i As Integer

        'busca una de las letras del campo DIAS en el Caption de la columna calendario
        For i = 0 To Dias.Length - 1
            Dim L As String = Dias.Substring(i, 1).ToLower

            If C.Header.Caption.Substring(0, 1).ToLower = L Then
                TieneLetra = True
                Exit For
            End If
        Next

        'marca el dia en el que NO sale el programa
        If Not TieneLetra Then
            Fila.Cells(C.Key).Appearance.BackColor = Color

            'Marca el color del dia para los temas
            If Activo.IDMedio = MedioRadio Then
                For Each F In Fila.ChildBands(0).Rows
                    F.Cells(C.Key).Appearance.BackColor = Color
                Next
                'AG Hoja Numero ============================================
            ElseIf Activo.IDMedio = MedioTv Then
                If Not Fila.ChildBands Is Nothing Then
                    For Each F In Fila.ChildBands(0).Rows
                        F.Cells(C.Key).Appearance.BackColor = Color
                    Next
                End If
                '============================================================
            End If
        End If

        TieneLetra = False
    End Sub
    Public Sub CambiarColorTextoHeader(ByVal Grilla As UltraGrid, ByVal Color As Color, ByVal ParamArray Columnas() As String)
        For Each s As String In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(s).Header.Appearance.ForeColor = Color
        Next
    End Sub

    Public Sub CambiarColorTextoHeader(ByVal Grilla As UltraGrid, ByVal Color As Color, ByVal ColKey As String)

        Grilla.DisplayLayout.Bands(0).Columns(ColKey).Header.Appearance.ForeColor = Color

    End Sub
    Public Sub CambiarColorTextoHeader(ByVal Grilla As UltraGrid, ByVal Color As Color, ByVal Indice As Integer)

        Grilla.DisplayLayout.Bands(0).Columns(Indice).Header.Appearance.ForeColor = Color

    End Sub
    Public Sub CambiarAlineacionColumna(ByVal Grilla As UltraGrid, ByVal ColKey As String, ByVal Alineacion As Infragistics.Win.HAlign)
        Grilla.DisplayLayout.Bands(0).Columns(ColKey).CellAppearance.TextHAlign = Alineacion
    End Sub
    Public Sub CambiarAlineacionColumna(ByVal Grilla As UltraGrid, ByVal ColKey As String, ByVal Alineacion As Infragistics.Win.HAlign, ByVal Banda As Integer)
        Grilla.DisplayLayout.Bands(Banda).Columns(ColKey).CellAppearance.TextHAlign = Alineacion
    End Sub
    Public Sub CambiarAlineacionColumna(ByVal Grilla As UltraGrid, ByVal Indice As Integer, ByVal Alineacion As Infragistics.Win.HAlign)
        Grilla.DisplayLayout.Bands(0).Columns(Indice).CellAppearance.TextHAlign = Alineacion

    End Sub
    Public Sub CambiarAlineacionColumna(ByVal Grilla As UltraGrid, ByVal Alineacion As Infragistics.Win.HAlign)
        Dim C As UltraGridColumn
        For Each C In Grilla.DisplayLayout.Bands(0).Columns
            If C.DataType Is GetType(Int16) Or C.DataType Is GetType(Int32) Or C.DataType Is GetType(Int64) Or C.DataType Is GetType(Integer) Or C.DataType Is GetType(Single) Or C.DataType Is GetType(Double) Then
                C.CellAppearance.TextHAlign = Alineacion
            End If
        Next

    End Sub
    Public Sub CambiarAlineacionColumna(ByVal Grilla As UltraGrid)
        Dim C As UltraGridColumn
        Dim B As UltraGridBand
        For Each B In Grilla.DisplayLayout.Bands
            For Each C In Grilla.DisplayLayout.Bands(B.Index).Columns
                If GrillAdmin.EsColumnaCalendario(C) Then
                    C.CellAppearance.TextHAlign = HAlign.Right
                End If
            Next
        Next


    End Sub
    Public Sub AutoAjustarColumnas(ByVal Grilla As UltraGrid)
        Dim C As UltraGridColumn
        For Each C In Grilla.DisplayLayout.Bands(0).Columns
            C.PerformAutoResize(PerformAutoSizeType.AllRowsInBand)
        Next
    End Sub

    Public Sub AutoAjustarColumnas(ByVal Grilla As UltraGrid, ByVal Colkey As String)
        Grilla.DisplayLayout.Bands(0).Columns(Colkey).PerformAutoResize()
    End Sub

    Public Sub AutoAjustarColumnas(ByVal Grilla As UltraGrid, ByVal Indice As Integer)
        Grilla.DisplayLayout.Bands(0).Columns(Indice).PerformAutoResize()
    End Sub
    Public Sub CambiarColorCelda(ByVal Celda As UltraGridCell, ByVal Color As Color)
        If Not GrillAdmin.EsColumnaCalendario(Celda) Then
            Celda.Appearance.ForeColor = Color
        End If
    End Sub
    Public Sub HabilitarSumatoria(ByVal Grilla As UltraGrid, ByVal Colkey As String)
        Grilla.DisplayLayout.Bands(0).Columns(Colkey).AllowRowSummaries = AllowRowSummaries.True
    End Sub
    Public Sub HabilitarSumatoria(ByVal Grilla As UltraGrid, ByVal Indice As Integer)
        Grilla.DisplayLayout.Bands(0).Columns(Indice).AllowRowSummaries = AllowRowSummaries.True
    End Sub

    Public Sub HabilitarSumatoria(ByVal Grilla As UltraGrid)
        Dim C As UltraGridColumn
        For Each C In Grilla.DisplayLayout.Bands(0).Columns
            If C.DataType Is GetType(Int16) Or C.DataType Is GetType(Int32) Or C.DataType Is GetType(Int64) Or C.DataType Is GetType(Integer) Or C.DataType Is GetType(Single) Or C.DataType Is GetType(Double) Then

                C.AllowRowSummaries = AllowRowSummaries.True

            End If
        Next
    End Sub
    Public Sub HabilitarSumatoria(ByVal Grilla As UltraGrid, ByVal ParamArray Columnas() As String)
        Dim s As String
        For Each s In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(s).AllowRowSummaries = AllowRowSummaries.True
        Next
    End Sub

    Public Sub CambiarColorLinea(ByVal Grilla As UltraGrid, ByVal Indice As Integer, ByVal Col As System.Drawing.Color)
        Grilla.DisplayLayout.Bands(0).Columns(Indice).CellAppearance.BorderColor = Col
    End Sub

    Public Sub CambiarColorLinea(ByVal Grilla As UltraGrid, ByVal ColKey As String, ByVal Col As System.Drawing.Color)
        Grilla.DisplayLayout.Bands(0).Columns(ColKey).CellAppearance.BorderColor = Col
    End Sub

    Public Sub CambiarColorLinea(ByVal Grilla As UltraGrid, ByVal Col As System.Drawing.Color, ByVal ParamArray Columnas() As String)
        Dim s As String

        For Each s In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(s).CellAppearance.BorderColor = Col
        Next
    End Sub
    Public Sub FijarColumna(ByVal Col As UltraGridColumn, ByVal EsFijo As Boolean)
        Col.Header.Fixed = EsFijo
    End Sub
    Public Sub FijarColumna(ByVal Grilla As UltraGrid, ByVal Colkey As String, ByVal Banda As Integer, ByVal EsFijo As Boolean)
        Grilla.DisplayLayout.Bands(Banda).Columns(Colkey).Header.Fixed = EsFijo
    End Sub
    Public Sub FijarColumna(ByVal Grilla As UltraGrid, ByVal EsFijo As Boolean, ByVal ParamArray Columnas() As String)
        For Each s As String In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(s).Header.Fixed = EsFijo
        Next

    End Sub
    Public Function EstaAgrupando(ByVal Grilla As UltraGrid) As TresEstados
        Dim C As UltraGridColumn
        Dim Agrupadas As Integer

        For Each C In Grilla.DisplayLayout.Bands(0).Columns
            If C.IsGroupByColumn Then
                Agrupadas = Agrupadas + 1
            End If
        Next

        If Agrupadas > ColumnasAgrupadas Then
            ColumnasAgrupadas = Agrupadas
            Return TresEstados.Verdadero
        End If

        If Agrupadas < ColumnasAgrupadas Then
            ColumnasAgrupadas = Agrupadas
            Return TresEstados.Falso
        End If

        If Agrupadas = ColumnasAgrupadas Then
            Return TresEstados.Igual
        End If
    End Function
    Public Shared Sub CambiarColorColumna(ByVal Grilla As UltraGrid, ByVal Color As Color, ByVal Banda As Integer, ByVal ParamArray Columnas() As String)
        ' For Each b As UltraGridBand In Grilla.DisplayLayout.Bands
        For Each s As String In Columnas
            Grilla.DisplayLayout.Bands(Banda).Columns(s).CellAppearance.BackColor = Color
        Next
        'Next
    End Sub

    Public Sub ExcluirColumnasOcultar(ByVal Grilla As UltraGrid)
        For Each c As UltraGridColumn In Grilla.DisplayLayout.Bands(0).Columns
            If GrillAdmin.EsColumnaCalendario(c) Then
                c.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
            End If
        Next

    End Sub
    Public Sub ExcluirColumnasOcultar(ByVal Grilla As UltraGrid, ByVal ParamArray Colkey() As String)
        For Each s As String In Colkey
            Grilla.DisplayLayout.Bands(0).Columns(s).ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
        Next

    End Sub
    Public Sub AcivarOperacion(ByVal Grilla As UltraGrid, ByVal ColKey As String, ByVal Operacion As SummaryType, Optional ByVal Texto As String = "", Optional ByVal Posicion As SummaryPosition = SummaryPosition.UseSummaryPositionColumn, Optional ByVal Formato As String = "{0:##,###.00}")
        Grilla.DisplayLayout.Bands(0).Summaries.Add(Operacion, Grilla.DisplayLayout.Bands(0).Columns(ColKey), Posicion).DisplayFormat = Formato '"{0:#####.00}"
        Grilla.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
        'Grilla.DisplayLayout.Override.SummaryValueAppearance.
        Grilla.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
    End Sub

    'Public Sub AcivarOperacion(ByVal Grilla As UltraGrid, ByVal Indice As Integer, ByVal Operacion As SummaryType, Optional ByVal Texto As String = "", Optional ByVal Posicion As SummaryPosition = SummaryPosition.UseSummaryPositionColumn)
    '    Grilla.DisplayLayout.Bands(0).Summaries.Add(Operacion, Grilla.DisplayLayout.Bands(0).Columns(Indice), Posicion).DisplayFormat = Texto & " " & "{0:######.00}"
    'End Sub
    'Public Sub AcivarOperacion(ByVal Grilla As UltraGrid, ByVal ColKey As String)
    '    Dim Cantidad As New CalculoPropio
    '    Grilla.DisplayLayout.Bands(0).Summaries.Add("Compras", SummaryType.Custom, Cantidad, Grilla.DisplayLayout.Bands(0).Columns(ColKey), SummaryPosition.UseSummaryPositionColumn, Nothing).DisplayFormat = "{#}"
    'End Sub
    Public Sub AcivarOperacion(ByVal Grilla As UltraGrid)
        Dim Cantidad As New CalculoPropio
        Dim Rating As New CalculoRatingSpot
        Dim c As UltraGridColumn

        For Each c In Grilla.DisplayLayout.Bands(0).Columns
            If GrillAdmin.EsColumnaCalendario(c) = True Then
                Grilla.DisplayLayout.Bands(0).Summaries.Add(SummaryType.Custom, Cantidad, c, SummaryPosition.UseSummaryPositionColumn, Nothing).DisplayFormat = "{0:#####.00}"
                Grilla.DisplayLayout.Bands(0).Summaries.Add(SummaryType.Custom, Rating, c, SummaryPosition.UseSummaryPositionColumn, Nothing).DisplayFormat = "{0:######.00}"
            End If
        Next
    End Sub
    Public Sub AgruparPorColumna(ByVal Grilla As UltraGrid, ByVal ColKey As String)
        Grilla.DisplayLayout.Bands(0).SortedColumns.Add(ColKey, False, True)
    End Sub
    Public Sub AgruparPorColumna(ByVal Grilla As UltraGrid, ByVal Indice As Integer)
        Dim colkey As String = Grilla.DisplayLayout.Bands(0).Columns(Indice).Key
        Grilla.DisplayLayout.Bands(0).SortedColumns.Add(colkey, False, True)
    End Sub
    Public Function ContarColumnasOcultas(ByVal Grilla As UltraGrid, ByVal Banda As Integer) As Integer
        Dim Cont As Integer
        'If Hijos Then
        For Each c As UltraGridColumn In Grilla.DisplayLayout.Bands(Banda).Columns
            If c.Hidden Then
                Cont += 1
            End If
        Next
        'End If
        Return Cont - 1
    End Function
    Public Function ContarColumnasOcultas(ByVal Grilla As UltraGrid) As Integer
        Dim Cont As Integer
        For Each b As UltraGridBand In Grilla.DisplayLayout.Bands
            If b.Index > 0 Then
                For Each c As UltraGridColumn In Grilla.DisplayLayout.Bands(b.Index).Columns
                    If c.Hidden Then
                        Cont += 1
                    End If

                Next
                Return Cont - 1
            End If
        Next
    End Function
    Public Sub ReocultarColumnasHijos(ByVal Grilla As UltraGrid)
        For Each b As UltraGridBand In Grilla.DisplayLayout.Bands
            If b.Index > 0 Then
                Try
                    For Each c As UltraGridColumn In Grilla.DisplayLayout.Bands(0).Columns
                        If c.Index > 10 And c.Key.IndexOf("Banda") = -1 Then
                            b.Columns(c.Key).Hidden = c.Hidden
                        End If
                    Next
                Catch E As Exception
                    MsgBox("ReocultarColumnasHijos " & E.Message)
                End Try

            End If
        Next

    End Sub
    Public Sub OcultarColumnasHijos(ByVal Grilla As UltraGrid, ByVal ColKey As String, ByVal EsOculto As Boolean)

        For Each b As UltraGridBand In Grilla.DisplayLayout.Bands
            If b.Index > 0 Then
                b.Columns(ColKey).Hidden = EsOculto
            End If
        Next
    End Sub

    Public Sub MarcarCeldasModificadas(ByVal Grilla As UltraGrid, ByVal Color As Color)
        Dim Ur As UltraGridRow
        Dim C As ColumnasManuales
        Dim Constantes As ArrayList
        Dim Columna As String

        For Each Ur In Grilla.Rows
            C = IIf(IsDBNull(Ur.Cells("tipo_planificacion").Value), 0, Ur.Cells("tipo_planificacion").Value)

            Constantes = Algoritmos.ObtenerConstantesSuma(C)

            For Each C In Constantes
                Columna = GrillAdmin.ObtenerColumnaModificable(C)

                If Ur.Cells(Columna).Appearance.ForeColor.Equals(System.Drawing.Color.Black) Or _
                Ur.Cells(Columna).Appearance.ForeColor.Equals(System.Drawing.Color.Empty) Then
                    Ur.Cells(Columna).Appearance.ForeColor = Color
                End If
            Next
        Next
    End Sub

    Public Sub CambiarFormatoColumna(ByVal Grilla As UltraGrid, ByVal Indice As Integer, ByVal Formato As Formato)
        Dim Str As String
        Select Case Formato
            Case Formato.General
                Str = "G"
            Case Formato.Numero
                Str = "N"
            Case Formato.Porcentaje
                Str = "P"
            Case Formato.FechaCorta
                Str = "dd/mm/yyyy"
            Case Formato.FechaLarga
                Str = "D"
            Case Formato.Moneda
                Str = "C"
            Case Formato.Decimales
                Str = "N"
        End Select
        Grilla.DisplayLayout.Bands(0).Columns(Indice).Format = Str
        CambiarAlineacionColumna(Grilla, Indice, HAlign.Right)
    End Sub
    Public Sub CambiarFormatoColumna(ByVal Grilla As UltraGrid, ByVal Formato As Formato, ByVal ParamArray Columnas() As String)
        Dim Str As String
        Select Case Formato
            Case Formato.General
                Str = "G"
            Case Formato.Numero
                Str = "N"
            Case Formato.Porcentaje
                Str = "P"
            Case Formato.FechaCorta
                Str = "dd/mm/yyyy"
            Case Formato.FechaLarga
                Str = "D"
            Case Formato.Moneda
                Str = "C"
            Case Formato.Decimales
                Str = "G"
        End Select
        Dim s As String
        Dim b As UltraGridBand
        For Each b In Grilla.DisplayLayout.Bands
            If b.Index > 0 Then
                For Each s In Columnas
                    Grilla.DisplayLayout.Bands(b.Index).Columns(s).Format = Str
                    CambiarAlineacionColumna(Grilla, s, HAlign.Right, b.Index)
                Next
            End If

        Next
    End Sub
    Public Sub CambiarFormatoColumna(ByVal Grilla As UltraGrid, ByVal ColKey As String, ByVal Formato As Formato)
        Dim Str As String
        Select Case Formato
            Case Formato.General
                Str = "G"
            Case Formato.Numero
                Str = "N"
            Case Formato.Porcentaje
                Str = "P"
            Case Formato.FechaCorta
                Str = "dd/mm/yyyy"
            Case Formato.FechaLarga
                Str = "D"
            Case Formato.Moneda
                Str = "C"
            Case Formato.Decimales
                'Str = "N"
                Str = "G"
        End Select
        Grilla.DisplayLayout.Bands(0).Columns(ColKey).Format = Str
        CambiarAlineacionColumna(Grilla, ColKey, HAlign.Right)

    End Sub
    Public Sub HabilitarFiltro(ByVal Col As UltraGridColumn, ByVal Habilitado As DefaultableBoolean)
        Col.AllowRowFiltering = Habilitado
    End Sub
    Public Sub HabilitarFiltro(ByVal Grilla As UltraGrid, ByVal Habilitado As DefaultableBoolean)
        Dim c As UltraGridColumn

        For Each c In Grilla.DisplayLayout.Bands(0).Columns
            If Not GrillAdmin.EsColumnaCalendario(c) Then
                c.AllowRowFiltering = Habilitado
            End If
        Next

    End Sub
    Public Sub HabilitarFiltro(ByVal Grilla As UltraGrid, ByVal Habilitado As DefaultableBoolean, ByVal ParamArray Columnas() As String)
        Dim S As String
        For Each S In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(S).AllowRowFiltering = Habilitado
        Next
    End Sub
    Public Sub HabilitarOrdenar(ByVal Grilla As UltraGrid, ByVal Habilitado As DefaultableBoolean, ByVal ParamArray Columnas() As String)
        Dim S As String
        For Each S In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(S).AllowRowFiltering = Habilitado
        Next
    End Sub
    Public Sub HabilitarOrdenar(ByVal Col As UltraGridColumn, ByVal Tipo As SortIndicator)
        Col.SortIndicator = Tipo
    End Sub
    Public Sub HabilitarOrdenar(ByVal Grilla As UltraGrid, ByVal Tipo As SortIndicator)
        Dim c As UltraGridColumn

        For Each c In Grilla.DisplayLayout.Bands(0).Columns
            If Not GrillAdmin.EsColumnaCalendario(c) Then
                c.SortIndicator = Tipo
            End If
        Next
    End Sub
    Public Function ContarColumnasCalendario(ByVal Grilla As UltraGrid) As Integer
        Dim c As UltraGridColumn
        Dim contador As Integer

        For Each c In Grilla.DisplayLayout.Bands(0).Columns
            If GrillAdmin.EsColumnaCalendario(c) Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    Public Sub HabilitarEdicionColumnaBandas(ByVal Grilla As UltraGrid, ByVal Modo As Activation, ByVal ParamArray Cols() As String)
        'Dim C As UltraGridColumn
        'Dim B As UltraGridBand

        For Each c As String In Cols
            For Each b As UltraGridBand In Grilla.DisplayLayout.Bands
                If b.Index > 0 Then
                    Grilla.DisplayLayout.Bands(b.Index).Columns(c).CellActivation = Modo
                End If
            Next
        Next

    End Sub

    Public Sub HabilitarEdicionColumna(ByVal Col As UltraGridColumn, ByVal Modo As Activation)
        Col.CellActivation = Modo
    End Sub
    Public Sub HabilitarEdicionColumna(ByVal Grilla As UltraGrid, ByVal ColKey As String, ByVal Modo As Activation)
        Grilla.DisplayLayout.Bands(0).Columns(ColKey).CellActivation = Modo
    End Sub
    Public Sub HabilitarEdicionColumna(ByVal Grilla As UltraGrid, ByVal Indice As Integer, ByVal Modo As Activation)
        Grilla.DisplayLayout.Bands(0).Columns(Indice).CellActivation = Modo
    End Sub
    Public Sub HabilitarEdicionColumna(ByVal Grilla As UltraGrid, ByVal Modo As Activation, ByVal ParamArray Columnas() As String)
        Dim S As String
        For Each S In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(S).CellActivation = Modo
        Next
    End Sub
    Public Sub HabilitarEdicionColumna(ByVal Grilla As UltraGrid, ByVal Modo As Activation, Optional ByVal SoloHijos As Boolean = True)
        Dim C As UltraGridColumn
        Dim B As UltraGridBand

        For Each B In Grilla.DisplayLayout.Bands
            If SoloHijos Then
                If B.Index > 0 Then
                    If Activo.IDMedio <> MedioRadio Then
                        For Each C In Grilla.DisplayLayout.Bands(B.Index).Columns
                            C.CellActivation = Modo
                        Next
                    End If
                End If
            Else
                For Each C In Grilla.DisplayLayout.Bands(0).Columns
                    C.CellActivation = Modo
                Next
            End If
        Next
    End Sub

    Public Sub HabilitarEdicionColumnaHijo(ByVal Grilla As UltraGrid, ByVal ModoNoCalendario As Activation, ByVal ModoCalendario As Activation)
        Dim C As UltraGridColumn
        Dim B As UltraGridBand

        For Each B In Grilla.DisplayLayout.Bands
            If B.Index > 0 Then
                For Each C In Grilla.DisplayLayout.Bands(B.Index).Columns
                    If C.Key.IndexOf("/") > -1 Then
                        C.CellActivation = ModoCalendario
                    Else
                        C.CellActivation = ModoNoCalendario
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub CambiarTamañoColumna(ByVal Grilla As UltraGrid, ByVal Tamaño As Integer, ByVal ParamArray Columnas() As String)
        Dim S As String
        For Each S In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(S).Width = Tamaño
        Next
    End Sub
    Public Sub CambiarTamañoColumna(ByVal Grilla As UltraGrid, ByVal Tamaño As Integer)
        Dim C As UltraGridColumn

        For Each C In Grilla.DisplayLayout.Bands(0).Columns
            If GrillAdmin.EsColumnaCalendario(C) Then
                C.Width = Tamaño
            End If
        Next
    End Sub

    Public Sub HabilitarFijado(ByVal Grilla As UltraGrid, ByVal Modo As FixedHeaderIndicator)
        Dim c As UltraGridColumn

        For Each c In Grilla.DisplayLayout.Bands(0).Columns
            If GrillAdmin.EsColumnaCalendario(c) Then
                c.Header.FixedHeaderIndicator = Modo
            End If
        Next
    End Sub
    Public Sub HabilitarFijado(ByVal Grilla As UltraGrid, ByVal Modo As FixedHeaderIndicator, ByVal ParamArray Columnas() As String)
        Dim s As String

        For Each s In Columnas
            Grilla.DisplayLayout.Bands(0).Columns(s).Header.FixedHeaderIndicator = Modo
        Next
    End Sub
    Public Shared Sub WarpHeader(ByVal Grilla As UltraGrid, ByVal EsMultilinea As DefaultableBoolean)
        Grilla.DisplayLayout.Override.WrapHeaderText = EsMultilinea
        Grilla.DisplayLayout.Override.HeaderAppearance.TextHAlign = HAlign.Center
    End Sub
    Public Sub CambiarColorFondoFila(ByVal Fila As UltraGridRow, ByVal Color As System.Drawing.Color)
        Fila.CellAppearance.BackColor = Color
    End Sub
    Public Sub CambiarColorFondoFila(ByVal grilla As UltraGrid, ByVal Color As System.Drawing.Color, ByVal ParamArray Filas() As Integer)
        For Each i As Integer In Filas
            grilla.Rows(i).CellAppearance.BackColor = Color
        Next
    End Sub
    Public Sub CambiarPosicionHijos(ByVal grilla As UltraGrid, ByVal NuevaPos As Integer, ByVal ColKey As String, ByVal Banda As Integer)
        grilla.DisplayLayout.Bands(Banda).Columns(ColKey).Header.VisiblePosition = NuevaPos
    End Sub
    Public Sub CambiarPosicionHijos(ByVal grilla As UltraGrid, ByVal NuevaPos As Integer, ByVal ColKey As String)
        For Each b As UltraGridBand In grilla.DisplayLayout.Bands
            If b.Index > 0 Then
                'For Each c As UltraGridColumn In grilla.DisplayLayout.Bands(b.Index).Columns
                ' Me.MoverColumna(c, NuevaPos)
                ' Next
                b.Columns(ColKey).Header.VisiblePosition = NuevaPos
            End If
        Next
    End Sub
    Public Sub CambiarPosicionHijos(ByVal grilla As UltraGrid, ByVal NuevaPos As Integer, ByVal indice As Integer)
        For Each b As UltraGridBand In grilla.DisplayLayout.Bands
            If b.Index > 0 Then
                'For Each c As UltraGridColumn In grilla.DisplayLayout.Bands(b.Index).Columns
                ' Me.MoverColumna(c, NuevaPos)
                ' Next
                b.Columns(indice).Header.VisiblePosition = NuevaPos
            End If
        Next
    End Sub
    Public Sub HabilitarCelda(ByVal Celda As UltraGridCell, ByVal Tipo As Activation)
        Celda.Activation = Tipo
    End Sub

End Class

Public Enum Formato
    General
    Numero
    Moneda
    FechaCorta
    FechaLarga
    Porcentaje
    Decimales
End Enum

Public Enum TresEstados
    Verdadero
    Falso
    Igual
End Enum




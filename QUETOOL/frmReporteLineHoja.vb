Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.Printing

Public Class frmReporteLineHoja


#Region "Variables y Propiedades"

    Dim _DtSpot As New DataTable
    Dim _DtSpotDetalle As New DataTable
    Dim _DtTemas As New DataTable
    Dim DtReporte As New DataTable
    Dim _ColumnaTarget1 As String
    Dim _ColumnaTarget2 As String
    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato
    Dim _ValorDolarCotizacion As Decimal

    Public Property ValorDolarCotizacion() As Decimal
        Get
            Return _ValorDolarCotizacion
        End Get
        Set(ByVal value As Decimal)
            _ValorDolarCotizacion = value
        End Set
    End Property

    Public Property DtSpot() As DataTable
        Get
            Return _DtSpot
        End Get
        Set(ByVal value As DataTable)
            _DtSpot = value
        End Set
    End Property

    Public Property DtSpotDetalle() As DataTable
        Get
            Return _DtSpotDetalle
        End Get
        Set(ByVal value As DataTable)
            _DtSpotDetalle = value
        End Set
    End Property

    Public Property DtTemas() As DataTable
        Get
            Return _DtTemas
        End Get
        Set(ByVal value As DataTable)
            _DtTemas = value
        End Set
    End Property

    Public Property ColumnaTarget1() As String
        Get
            Return _ColumnaTarget1
        End Get
        Set(ByVal value As String)
            _ColumnaTarget1 = value
        End Set

    End Property

    Public Property ColumnaTarget2() As String
        Get
            Return _ColumnaTarget2
        End Get
        Set(ByVal value As String)
            _ColumnaTarget2 = value
        End Set

    End Property




#End Region

#Region "Eventos"

    Private Sub frmReporteLineHoja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ArmarDtReporte()
        AgregarFilasDtReporte()
        DtReporte.Columns.Remove("idSpot")

        Me.uigGrillaLine.DataSource = DtReporte
        AplicarFormatoGrilla()
        CambiarNombreColumnas()
        AliniarDatosCeldas()
        AliniaTitulosColumnas()
        AplicarFormatoCeldas()
        TamañoColumnas()

    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

#End Region

#Region "Funciones"


    Private Sub ArmarDtReporte()

        DtReporte.Columns.Add("idSpot", GetType(String))
        DtReporte.Columns.Add("Country", GetType(String))
        DtReporte.Columns.Add("Date", GetType(String))
        DtReporte.Columns.Add("CountryTime", GetType(String))
        DtReporte.Columns.Add("Media", GetType(String))
        DtReporte.Columns.Add("Version", GetType(String))
        DtReporte.Columns.Add("Cadena", GetType(String))
        DtReporte.Columns.Add("Program", GetType(String))
        DtReporte.Columns.Add("Time", GetType(String))
        DtReporte.Columns.Add("Length", GetType(String))
        DtReporte.Columns.Add("TRPS_Target", GetType(String))
        DtReporte.Columns.Add("Cost", GetType(String))
        DtReporte.Columns.Add("CostARG", GetType(String))
        DtReporte.Columns.Add("Reach1", GetType(String))

    End Sub

    Private Sub AgregarFilasDtReporte()

        Dim RowReporte As DataRow

        For Each DrSpot As DataRow In _DtSpot.Rows

            For Each DrDetalle As DataRow In _DtSpotDetalle.Select("ID_SPOT =" & DrSpot("id_Spot"))

                RowReporte = DtReporte.NewRow()
                RowReporte("idSpot") = DrSpot("id_spot")
                'Datos Cabecera SPOT
                RowReporte("Country") = "Argentina"
                RowReporte("CountryTime") = DrSpot("h_inicio")
                RowReporte("Media") = "Open TV"
                RowReporte("Cadena") = ObtenerDescripcionMaestros(Activo.DTSoportesCache.Select("ID_SOPORTE=" & DrSpot("id_soporte") & " and " & "ID_MEDIO=" & Activo.IDMedio)(0)("descripcion").ToString())
                RowReporte("Program") = DrSpot("programa")
                RowReporte("Version") = ObtenerMaterial(DrDetalle("id_tema").ToString())
                RowReporte("Time") = ObtenerHora(DrSpot("h_inicio"), DrSpot("m_inicio")) ' HoraInicio
                RowReporte("TRPS_Target") = DrSpot(ColumnaTarget1)

                If ValorDolarCotizacion > 0 Then
                    RowReporte("Cost") = CStr(Math.Round(DrSpot("neto") / ValorDolarCotizacion, 2)).Replace(".", ",")
                Else
                    RowReporte("Cost") = CStr(DrSpot("neto")).Replace(".", ",")
                End If
                RowReporte("CostARG") = CStr(DrSpot("neto")).Replace(".", ",")
                RowReporte("Reach1") = ""
                'Datos Detalle SPOT_DETALLE
                RowReporte("Date") = CDate(DrDetalle("f_spot")).ToShortDateString
                RowReporte("Length") = DrDetalle("duracion")
                DtReporte.Rows.Add(RowReporte)
                DtReporte.AcceptChanges()

            Next
        Next


    End Sub

    Private Function ObtenerMaterial(ByVal Letra As String) As String

        Dim Material As String = ObtenerDato(DtTemas, "id_tema = '" & Letra & "'", "material")

        If Material Is Nothing Then
            Material = "Sin Material"
        End If
        If Material.ToLower = "no disponible" Then
            Material = "Sin Material"
        End If

        Return Material

    End Function

    Public Function ObtenerDato(ByVal Dt As DataTable, ByVal Filtro As String, ByVal Columna As String) As Object
        Try
            If Not Dt Is Nothing Then
                Dt.CaseSensitive = True

                Return Dt.Select(Filtro)(0).Item(Columna)
            End If
        Catch e As IndexOutOfRangeException
            Exit Function
        Catch ex As Exception
            Throw New Exception("La Columna '" & Columna & "' No Existe en el Data Table" & vbCrLf & ex.Message)
        End Try
    End Function
    

    Private Function ObtenerHora(ByVal Hora As Integer, ByVal Minuto As Integer) As String
        Dim Hs As String, Mn As String
        Dim ret As String
        'Si llega como h_inicio un 7    
        If CStr(Hora).Length < 2 Then
            'se le agrega un 0 delante 
            Hs = Trim("0" & Hora) '& ":"
        Else
            'si es 07 o un hs_inicio de 2 char
            Hs = Hora '& ":"
        End If

        'Si llega como m_inicio un 5    
        If CStr(Minuto).Length < 2 Then
            'se le agrega un 0 delante , osea 05
            Mn &= Trim("0" & Minuto)
        Else
            'si es 07 o un m_inicio de 2 no hace nada, solo lo concatena a la h_inicio
            Mn &= Minuto
        End If

        ret = Trim(Hs & ":" & Mn)

        Return ret

    End Function

    Private Sub AplicarFormatoGrilla()

        GrillaFormato.HabilitarFiltro(Me.uigGrillaLine, Infragistics.Win.DefaultableBoolean.False)
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaLine, Activation.NoEdit, "Country", "Date", "CountryTime", "Media", "Version", "Cadena", "Program", "Length", "TRPS_Target", "Cost", "CostARG", "Reach1")

    End Sub

    Private Sub CambiarNombreColumnas()

        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Country", "Country")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Date", "Date")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "CountryTime", "Country Time")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Media", "Media")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Version", "Version")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Cadena", "Cadena")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Program", "Program")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Time", "Time")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Length", "Length")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "TRPS_Target", "TRPs Target")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Cost", "Cost per spot USD$")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "CostARG", "Cost per spot AR$")
        Listas.CambiarTituloColumna(Me.uigGrillaLine, "Reach1", "Reach +1")

    End Sub

    Private Sub AliniarDatosCeldas()

        With uigGrillaLine.DisplayLayout.Bands(0)
            .Columns("Country").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("Date").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CountryTime").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Media").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("Version").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("Cadena").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("Program").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("Time").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Length").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TRPS_Target").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cost").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CostARG").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Reach1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Sub AliniaTitulosColumnas()

        With uigGrillaLine.DisplayLayout.Bands(0)
            .Columns("Country").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Date").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CountryTime").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Media").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Version").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cadena").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Program").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Time").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Length").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TRPS_Target").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cost").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CostARG").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Reach1").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Sub AplicarFormatoCeldas()
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaLine, "Cost", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaLine, "CostARG", Formato.Moneda)
    End Sub

    Private Sub TamañoColumnas()
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 100, "Country")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 110, "Date")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 110, "CountryTime")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 130, "Media")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 280, "Version")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 200, "Cadena")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 250, "Program")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 100, "Time")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 70, "Length")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 120, "TRPS_Target")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 110, "Cost")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 110, "CostARG")
        GrillaFormato.CambiarTamañoColumna(uigGrillaLine, 100, "Reach1")
    End Sub

    Private Sub ExportarExcel()

        SaveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            Dim Excel As New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
            Try
                Excel.Export(Me.uigGrillaLine, SaveFileDialog.FileName)
                MsgBox("El archivo se grabó con éxito.", MsgBoxStyle.Information, "Reporte Line")
            Catch ioex As IO.IOException
                MsgBox(ioex.Message, TipoMensaje.DeError)
            End Try
        End If

    End Sub

    Private Function ObtenerDescripcionMaestros(ByVal Cadena As String) As String

        Dim Descripcion As String
        Dim TramaSeparadaNivel() As String
        Dim TramaSeparadaNivel1() As String
        Dim TramaSeparadaNivel2() As String

        TramaSeparadaNivel = Cadena.Split("|")
        TramaSeparadaNivel = Cadena.Split("[")
        Descripcion = TramaSeparadaNivel(0)

        Return Descripcion

    End Function

#End Region


    Private Sub uigGrillaLine_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uigGrillaLine.KeyDown

        Dim EnEdicion As Boolean = Me.uigGrillaLine.ActiveCell.IsInEditMode

        If Not Me.uigGrillaLine.ActiveRow Is Nothing AndAlso Me.uigGrillaLine.ActiveRow.Selected Then
            If e.KeyCode = Keys.Delete Then
                If Not uigGrillaLine.ActiveCell Is Nothing Then
                    If Not uigGrillaLine.ActiveCell.IsInEditMode Then
                        uigGrillaLine.ActiveCell.Value = ""
                    End If
                End If
            End If
        End If

        Select Case e.KeyValue

            Case Keys.Delete
                uigGrillaLine.ActiveCell.Value = 0

            Case Keys.Enter, Keys.F2
                e.Handled = True

                If EnEdicion Then
                    uigGrillaLine.PerformAction(ExitEditMode, False, False)
                Else
                    uigGrillaLine.PerformAction(EnterEditMode, False, False)
                End If
                uigGrillaLine.UpdateData()

        End Select

    End Sub

End Class
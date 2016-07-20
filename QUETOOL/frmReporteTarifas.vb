Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.Printing
Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports System.Globalization
Imports MSL
Imports System.IO
Imports System.Drawing

Public Class frmReporteTarifas

#Region "Variables"

    Dim ObjTarifas As Tarifas_tv
    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato

#End Region

#Region "Eventos"

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim DtResultado As New DataTable
        Dim FechaHasta As Date
        ObjTarifas = New Tarifas_tv

        FechaHasta = Me.dtpFechaHasta.Value

        DtResultado = ObjTarifas.ReporteTarifasTvCapital(FechaHasta.ToShortDateString)

        If DtResultado.Rows.Count > 0 Then
            Me.txtregistrosCantidad.Text = DtResultado.Rows.Count.ToString()
            Me.uigGrillatarifas.DataSource = DtResultado

            AplicarFormatoGrilla()
            AplicarFormatoCeldas()
            CambiarNombreColumnas()
            AliniaTitulosColumnas()
            AliniarDatosCeldas()
            GrillaFormato.AcivarOperacion(uigGrillatarifas)
            GrillaFormato.AutoAjustarColumnas(Me.uigGrillatarifas)
        Else
            MsgBox("No se encontraron encontraron registros, para esos filtros seleccionados.", MsgBoxStyle.Information, "Everest")
            Me.txtregistrosCantidad.Text = ""
        End If
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click

        Me.uigGrillatarifas.DataSource = Nothing
        Me.txtregistrosCantidad.Text = ""

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub AplicarFormatoGrilla()

        GrillaFormato.HabilitarFiltro(Me.uigGrillatarifas, DefaultableBoolean.True)
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillatarifas, Activation.NoEdit, "CANAL", "PROGRAMA", "DIAS_EMISION", "HORARIO", "BRUTO")

    End Sub

    Private Sub CambiarNombreColumnas()

        Listas.CambiarTituloColumna(Me.uigGrillatarifas, "CANAL", "Canal")
        Listas.CambiarTituloColumna(Me.uigGrillatarifas, "PROGRAMA", "Programa")
        Listas.CambiarTituloColumna(Me.uigGrillatarifas, "DIAS_EMISION", "Dia Emision")
        Listas.CambiarTituloColumna(Me.uigGrillatarifas, "HORARIO", "Horario")
        Listas.CambiarTituloColumna(Me.uigGrillatarifas, "BRUTO", "Bruto")
        
    End Sub

    Private Sub AliniarDatosCeldas()

        With uigGrillatarifas.DisplayLayout.Bands(0)
            .Columns("CANAL").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("PROGRAMA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("DIAS_EMISION").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("HORARIO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("BRUTO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        End With

    End Sub

    Private Sub AliniaTitulosColumnas()

        With uigGrillatarifas.DisplayLayout.Bands(0)
            .Columns("CANAL").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PROGRAMA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DIAS_EMISION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HORARIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("BRUTO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Sub AplicarFormatoCeldas()

        GrillaFormato.CambiarFormatoColumna(Me.uigGrillatarifas, "BRUTO", Formato.Moneda)

    End Sub

    Private Sub ExportarExcel()

        SaveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            Dim Excel As New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
            Try
                Excel.Export(Me.uigGrillatarifas, SaveFileDialog.FileName)
                Mensaje("El archivo se grabó con éxito.", TipoMensaje.Informacion)
            Catch ioex As IO.IOException
                Mensaje(ioex.Message, TipoMensaje.DeError)
            End Try
        End If

    End Sub

#End Region


    
   
    
End Class
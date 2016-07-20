Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports System.Text
Imports Framework.Mensajes
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports System

Public Class frmAvisosVigenteTarifas

#Region "Propiedades y Variables"

    Dim mdtAvisosSinVigencia As New DataTable
    Dim midMedio As Integer
    Dim GrillaFormato As New GrillaFormato

    Public Property dtAvisosSinVigencia() As DataTable
        Get
            Return mdtAvisosSinVigencia
        End Get
        Set(ByVal value As DataTable)
            mdtAvisosSinVigencia = value
        End Set
    End Property

    Public Property idMedio() As Integer
        Get
            Return midMedio
        End Get
        Set(ByVal value As Integer)
            midMedio = value
        End Set
    End Property


#End Region

#Region "Eventos"


    Private Sub frmAvisosVigenteTarifas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.iugTarifasVigentes.DataSource = Me.dtAvisosSinVigencia
        FormatoGrilla()
    End Sub


    Private Sub FormatoGrilla()

        'Columnas en Comun =============================================================================================
        'Nombre las columnas de la grilla 

        Listas.CambiarTituloColumna(Me.iugTarifasVigentes, "Soporte", "Soporte")
        Listas.CambiarTituloColumna(Me.iugTarifasVigentes, "Programa", "Programa")
        Listas.CambiarTituloColumna(Me.iugTarifasVigentes, "FechaSpot", "Fecha Aviso")
        Listas.CambiarTituloColumna(Me.iugTarifasVigentes, "CantAvisos", "Cant. Avisos")
        Listas.CambiarTituloColumna(Me.iugTarifasVigentes, "TarifaFechaInicio", "Fecha Inicio Tarifa")
        Listas.CambiarTituloColumna(Me.iugTarifasVigentes, "TarifaFechaFin", "Fecha Fin Tarifa")

        'Alineo las columnas 
        GrillaFormato.CambiarAlineacionColumna(iugTarifasVigentes, "Soporte", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugTarifasVigentes, "Programa", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugTarifasVigentes, "FechaSpot", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugTarifasVigentes, "CantAvisos", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugTarifasVigentes, "TarifaFechaInicio", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugTarifasVigentes, "TarifaFechaFin", HAlign.Left)

        'Alineo nombre columnas cabecera
        With iugTarifasVigentes.DisplayLayout.Bands(0)
            .Columns("Soporte").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Programa").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("FechaSpot").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CantAvisos").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TarifaFechaInicio").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TarifaFechaFin").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With
        'Inabilito el filtro
        GrillaFormato.HabilitarFiltro(iugTarifasVigentes, DefaultableBoolean.False)
        'Doy el tamaño de las columnas
        GrillaFormato.CambiarTamañoColumna(iugTarifasVigentes, 400, "Soporte")
        GrillaFormato.CambiarTamañoColumna(iugTarifasVigentes, 280, "Programa")
        GrillaFormato.CambiarTamañoColumna(iugTarifasVigentes, 110, "FechaSpot")
        GrillaFormato.CambiarTamañoColumna(iugTarifasVigentes, 60, "CantAvisos")
        GrillaFormato.CambiarTamañoColumna(iugTarifasVigentes, 110, "TarifaFechaInicio")
        GrillaFormato.CambiarTamañoColumna(iugTarifasVigentes, 110, "TarifaFechaFin")
        'Inabilito columnas edicion
        With iugTarifasVigentes.DisplayLayout.Bands(0)
            .Columns("Soporte").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Programa").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("FechaSpot").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("CantAvisos").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("TarifaFechaInicio").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("TarifaFechaFin").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        End With
        'Color de Celdas Soporte
        CambiarColorCelda("Soporte")

        GrillaFormato.HabilitarFiltro(Me.iugTarifasVigentes, Infragistics.Win.DefaultableBoolean.False)
        '===============================================================================================================

        Select Case midMedio
            Case 1, 6 'Medios: TV y Radio
                GrillaFormato.HabilitarEdicionColumna(iugTarifasVigentes, Activation.NoEdit, "Soporte", "Programa", "FechaSpot", "CantAvisos", "TarifaFechaInicio", "TarifaFechaFin")
        End Select

    End Sub

    Private Sub CambiarColorCelda(ByVal Columnas As String)
        For Each b As UltraGridBand In iugTarifasVigentes.DisplayLayout.Bands
            Dim i As Integer
            For i = 0 To iugTarifasVigentes.Rows.Count - 1
                iugTarifasVigentes.Rows(i).Cells(Columnas.ToString).Appearance.BackColor = Color.Beige
            Next
        Next
    End Sub

#End Region
End Class
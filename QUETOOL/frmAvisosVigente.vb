Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports System.Text
Imports Framework.Mensajes
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports System


Public Class frmAvisosVigente

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

    Private Sub frmAvisosVigente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.iugConveniosVigentes.DataSource = Me.dtAvisosSinVigencia
        FormatoGrilla()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FormatoGrilla()

        'Columnas en Comun =============================================================================================
        'Nombre las columnas de la grilla 

        Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "FechaSpot", "Fecha Spot")
        Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "ConvenioFechaInicio", "Convenio Fecha Inicio")
        Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "ConvenioFechaFin", "Convenio Fecha Fin")
        Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "TipoConvenio", "Tipo Convenio")
        'Alineo las columnas 
        GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Soporte", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "FechaSpot", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "ConvenioFechaInicio", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "ConvenioFechaFin", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "TipoConvenio", HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Observaciones", HAlign.Left)
        'Alineo nombre columnas cabecera
        With iugConveniosVigentes.DisplayLayout.Bands(0)
            .Columns("soporte").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("FechaSpot").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ConvenioFechaInicio").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ConvenioFechaFin").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TipoConvenio").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Observaciones").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With
        'Inabilito el filtro
        GrillaFormato.HabilitarFiltro(iugConveniosVigentes, DefaultableBoolean.False)
        'Doy el tamaño de las columnas
        GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 300, "soporte")
        GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 82, "FechaSpot")
        GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 135, "ConvenioFechaInicio")
        GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 117, "ConvenioFechaFin")
        GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 95, "TipoConvenio")
        GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 370, "Observaciones")
        'Inabilito columnas edicion
        With iugConveniosVigentes.DisplayLayout.Bands(0)
            .Columns("Soporte").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("FechaSpot").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("ConvenioFechaInicio").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("ConvenioFechaFin").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("TipoConvenio").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Observaciones").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        End With
        'Color de Celdas Soporte
        CambiarColorCelda("soporte")
        '===============================================================================================================



        Select Case midMedio
            Case 1, 6 'Medios: TV y Radio
                'Alineo las columnas cabecera ==============================================================================
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("Tema").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Duracion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Programa").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Material").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                End With
                'Inabilito columnas edicion
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("Tema").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Duracion").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Programa").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Material").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                End With
                'Alineo las columnas ======================================================================================
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Tema", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Duracion", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Programa", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Material", HAlign.Left)
                'Inabilito la edicion de las columnas =====================================================================
                GrillaFormato.HabilitarEdicionColumna(iugConveniosVigentes, Activation.NoEdit, "Programa", "Tema", "Duracion", "Material")
                'Doy el tamaño de las columnas ============================================================================                
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 315, "Programa")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 55, "Tema")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 55, "Duracion")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 270, "Material")
            Case 4, 5 'Medios: Prensa y Revista
                'Cambio el nombre de la columnas 
                Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "CantAvisos", "Cant. Avisos")
                'Alineo las columnas cabecera ==============================================================================
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("CantAvisos").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Concepto").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Seccion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Material").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                End With
                'Inabilito columnas edicion
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("CantAvisos").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Concepto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Seccion").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Material").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                End With
                'Alineo las columnas ======================================================================================
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "CantAvisos", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Concepto", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Seccion", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Material", HAlign.Left)
                'Inabilito la edicion de las columnas =====================================================================
                GrillaFormato.HabilitarEdicionColumna(iugConveniosVigentes, Activation.NoEdit, "CantAvisos", "Concepto", "Seccion", "Material")
                'Doy el tamaño de las columnas ============================================================================                
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 105, "CantAvisos")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 160, "Concepto")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 160, "Seccion")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 270, "Material")
            Case 3 'Medios: Exterior
                'Cambio el nombre de la columnas 
                Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "CantAvisos", "Cant. Avisos")
                'Alineo las columnas cabecera ==============================================================================
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("CantAvisos").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Formato").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Provincia").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Poblacion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Calle").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Caras").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Material").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                End With
                'Inabilito columnas edicion
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("CantAvisos").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Formato").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Provincia").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Poblacion").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Calle").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Caras").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Material").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                End With
                'Alineo las columnas ======================================================================================
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "CantAvisos", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Formato", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Provincia", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Poblacion", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Calle", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Caras", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Material", HAlign.Left)
                'Inabilito la edicion de las columnas =====================================================================
                GrillaFormato.HabilitarEdicionColumna(iugConveniosVigentes, Activation.NoEdit, "CantAvisos", "Formato", "Provincia", "Poblacion", "Calle", "Caras", "Material")
                'Doy el tamaño de las columnas ============================================================================                
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 105, "CantAvisos")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 160, "Formato")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 105, "Provincia")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 160, "Poblacion")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 110, "Calle")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 91, "Caras")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 270, "Material")
            Case 7  'Medios: Produccion
                'Cambio el nombre de la columnas 
                Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "CantAvisos", "Cant. Avisos")
                'Alineo las columnas cabecera ==============================================================================
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("CantAvisos").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Formato").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Provincia").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("Poblacion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                End With
                'Inabilito columnas edicion
                With iugConveniosVigentes.DisplayLayout.Bands(0)
                    .Columns("CantAvisos").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Formato").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Provincia").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .Columns("Poblacion").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                End With
                'Alineo las columnas ======================================================================================
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "CantAvisos", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Formato", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Provincia", HAlign.Left)
                GrillaFormato.CambiarAlineacionColumna(iugConveniosVigentes, "Poblacion", HAlign.Left)
                'Inabilito la edicion de las columnas =====================================================================
                GrillaFormato.HabilitarEdicionColumna(iugConveniosVigentes, Activation.NoEdit, "CantAvisos", "Formato", "Provincia", "Poblacion")
                'Doy el tamaño de las columnas ============================================================================                
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 105, "CantAvisos")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 160, "Formato")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 105, "Provincia")
                GrillaFormato.CambiarTamañoColumna(iugConveniosVigentes, 160, "Poblacion")
            Case 2
                Listas.OcultarColumnas(iugConveniosVigentes, "FechaSpot")
                Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "F_INICIO", "Plan Fecha Inicio")
                Listas.CambiarTituloColumna(Me.iugConveniosVigentes, "F_FIN", "Plan Fecha Fin")
                GrillaFormato.HabilitarEdicionColumna(iugConveniosVigentes, Activation.NoEdit, "F_INICIO", "F_FIN")
                iugConveniosVigentes.DisplayLayout.Bands(0).Columns("F_INICIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                iugConveniosVigentes.DisplayLayout.Bands(0).Columns("F_FIN").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End Select

    End Sub

    Private Sub CambiarColorCelda(ByVal Columnas As String)
        For Each b As UltraGridBand In iugConveniosVigentes.DisplayLayout.Bands
            Dim i As Integer
            For i = 0 To iugConveniosVigentes.Rows.Count - 1
                iugConveniosVigentes.Rows(i).Cells(Columnas.ToString).Appearance.BackColor = Color.Beige
            Next
        Next
    End Sub

#End Region

End Class
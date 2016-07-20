Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Shared
Imports System.Text
Imports MSL
Imports System.Reflection
Imports HM.MMS.AR.Client.Reportes

Public Class frmPrincipal
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents UltraDockManager1 As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _frmPrincipalUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmPrincipalUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmPrincipalUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmPrincipalUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmPrincipalAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _frmPrincipal_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPrincipal_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPrincipal_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPrincipal_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents iugSistema As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents chrGrafico As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents tabCampaña As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabSistema As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tlbAcciones As System.Windows.Forms.ToolBar
    Friend WithEvents toolNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents toolGuardar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents treCampaña As System.Windows.Forms.TreeView
    Friend WithEvents treSistema As System.Windows.Forms.TreeView
    Friend WithEvents tabTemas As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabGrafico As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents toolCancelar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tabEjercicios As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents palResumen As System.Windows.Forms.Panel
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents tabAlternativa As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gntGantt As AxprjJanChart.AxJanChart
    Friend WithEvents chrGraficoMensual As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents mnuEjercicio As System.Windows.Forms.ContextMenu
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusBar
    Friend WithEvents toolCubo As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents toolActualizacion As System.Windows.Forms.ToolBarButton
    Friend WithEvents toolMateriales As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCampanias As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents toolImportar As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents toolCambiarTema As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents btnCambiarCompania As System.Windows.Forms.Button
    Friend WithEvents lblCompania As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, New System.Guid("802e9bc5-09e5-4d27-98bf-14c1a5c3dc5f"))
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("32f49f7e-b0a8-4afb-93e6-40bb8f63e994"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("802e9bc5-09e5-4d27-98bf-14c1a5c3dc5f"), -1)
        Dim DockableControlPane4 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("1d8b39a9-1624-4053-bccd-8f95109da5b3"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("802e9bc5-09e5-4d27-98bf-14c1a5c3dc5f"), -1)
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("mnuMenu")
        Dim PopupMenuTool23 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Programa")
        Dim PopupMenuTool24 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Edición")
        Dim PopupMenuTool25 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Ver")
        Dim PopupMenuTool26 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Clientes")
        Dim PopupMenuTool27 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Audiencia")
        Dim PopupMenuTool28 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Tarifas")
        Dim PopupMenuTool29 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("convenio")
        Dim PopupMenuTool30 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("enviocompras")
        Dim PopupMenuTool31 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Actualizacion")
        Dim PopupMenuTool32 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Auxiliar")
        Dim ButtonTool44 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("nuevo")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool45 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("abrir")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool46 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("guardar")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool47 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Imprimir")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool48 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("g1")
        Dim PopupMenuTool33 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Programa")
        Dim StateButtonTool36 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Salir", "")
        Dim StateButtonTool37 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Opciones", "")
        Dim StateButtonTool38 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Salir", "")
        Dim PopupMenuTool34 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Clientes")
        Dim ButtonTool49 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("cambiarcliente")
        Dim StateButtonTool39 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("franjas", "")
        Dim ButtonTool50 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("cambiarcliente")
        Dim StateButtonTool40 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("ExploradorCampañas", "")
        Dim StateButtonTool41 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("ExploradorSistemas", "")
        Dim PopupMenuTool35 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Ver")
        Dim StateButtonTool42 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("ExploradorCampañas", "")
        Dim StateButtonTool43 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("ExploradorSistemas", "")
        Dim PopupMenuTool36 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Audiencia")
        Dim StateButtonTool44 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("AudienciaTVA", "")
        Dim ButtonTool51 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ProgramasMonitor")
        Dim ButtonTool52 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AsociarProgramas")
        Dim ButtonTool53 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("fechas")
        Dim ButtonTool54 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Calcular Audiencia Radio")
        Dim StateButtonTool45 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("AudienciaTVA", "")
        Dim StateButtonTool46 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("AudienciaTVC", "")
        Dim StateButtonTool47 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("AudienciaTVI", "")
        Dim ButtonTool55 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ProgramasMonitor")
        Dim ButtonTool56 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AsociarProgramas")
        Dim PopupMenuTool37 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Tarifas")
        Dim StateButtonTool48 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("CargarTarifas", "")
        Dim StateButtonTool49 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Copiar Tarifas", "")
        Dim ButtonTool57 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reporte tarifas genéricas")
        Dim ButtonTool58 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reporte Tarifa Promedio")
        Dim ButtonTool59 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteTarifasTv")
        Dim StateButtonTool50 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("CargarTarifas", "")
        Dim StateButtonTool51 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("Copiar Tarifas", "")
        Dim StateButtonTool52 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("franjas", "")
        Dim PopupMenuTool38 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("enviocompras")
        Dim StateButtonTool53 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("enviarcompras", "")
        Dim StateButtonTool54 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("enviarcompras", "")
        Dim PopupMenuTool39 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Edición")
        Dim StateButtonTool55 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarCampaña", "")
        Dim StateButtonTool56 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarSistema", "")
        Dim StateButtonTool57 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarEjercicio", "")
        Dim StateButtonTool58 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("BorrarCampaña", "")
        Dim StateButtonTool59 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("BorrarSistema", "")
        Dim StateButtonTool60 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("BorrarEjercicio", "")
        Dim StateButtonTool61 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarCampaña", "")
        Dim StateButtonTool62 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarSistema", "")
        Dim StateButtonTool63 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarEjercicio", "")
        Dim StateButtonTool64 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("BorrarCampaña", "")
        Dim StateButtonTool65 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("BorrarSistema", "")
        Dim StateButtonTool66 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("BorrarEjercicio", "")
        Dim ButtonTool60 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reporte tarifas genéricas")
        Dim ButtonTool61 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("fechas")
        Dim PopupMenuTool40 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("convenio")
        Dim StateButtonTool67 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("listarconvenios", "")
        Dim PopupMenuTool41 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("MantenimientoConvenios")
        Dim ButtonTool62 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reporte_Convenios")
        Dim ButtonTool63 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Convenios Masivo")
        Dim ButtonTool64 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteConveniosEstados")
        Dim ButtonTool65 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ConvenioEspecial")
        Dim StateButtonTool68 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("listarconvenios", "")
        Dim ButtonTool66 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ABMConveniosDescuento")
        Dim ButtonTool67 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ABMConveniosTarifaPlana")
        Dim PopupMenuTool42 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("MantenimientoConvenios")
        Dim ButtonTool68 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ABMConveniosTarifaPlana")
        Dim ButtonTool69 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ABMConveniosDescuento")
        Dim ButtonTool70 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ABMConveniosCPR")
        Dim StateButtonTool69 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarConvenios", "")
        Dim ButtonTool71 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Calcular Audiencia Radio")
        Dim StateButtonTool70 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("DuplicarConvenios", "")
        Dim PopupMenuTool43 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Actualizacion")
        Dim ButtonTool72 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("soporte")
        Dim TextBoxTool2 As Infragistics.Win.UltraWinToolbars.TextBoxTool = New Infragistics.Win.UltraWinToolbars.TextBoxTool("c1745811-c913-4739-8b81-e8cce6cd2b9e")
        Dim LabelTool2 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("b3b205bb-06e7-4f05-a108-c91199421697")
        Dim ButtonTool73 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("soporte")
        Dim PopupControlContainerTool2 As Infragistics.Win.UltraWinToolbars.PopupControlContainerTool = New Infragistics.Win.UltraWinToolbars.PopupControlContainerTool("f907df67-4dd4-4cad-ab2a-30e9b9ca1c88")
        Dim ButtonTool74 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ABMConveniosCPR")
        Dim ButtonTool75 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reporte Tarifa Promedio")
        Dim PopupMenuTool44 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Auxiliar")
        Dim ButtonTool76 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CargarpadronAGIP")
        Dim ButtonTool77 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AdministrarPerfiles")
        Dim ButtonTool78 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cargar padron AGIP")
        Dim ButtonTool79 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CargarpadronAGIP")
        Dim ButtonTool80 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reporte_Convenios")
        Dim ButtonTool81 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteTarifasTv")
        Dim ButtonTool82 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AdministrarPerfiles")
        Dim ButtonTool83 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Convenios_Masivo")
        Dim ButtonTool84 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Convenios Masivo")
        Dim ButtonTool85 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteConveniosEstados")
        Dim ButtonTool86 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ConvenioEspecial")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.chrGrafico = New Infragistics.Win.UltraWinChart.UltraChart
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.chrGraficoMensual = New Infragistics.Win.UltraWinChart.UltraChart
        Me.treCampaña = New System.Windows.Forms.TreeView
        Me.mnuCampanias = New System.Windows.Forms.ContextMenu
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.treSistema = New System.Windows.Forms.TreeView
        Me.mnuEjercicio = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.tabCampaña = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.tabGrafico = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.palResumen = New System.Windows.Forms.Panel
        Me.iugSistema = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.gntGantt = New AxprjJanChart.AxJanChart
        Me.tabSistema = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.tabTemas = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.tabEjercicios = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.tabAlternativa = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraDockManager1 = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._frmPrincipalUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmPrincipalUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmPrincipalUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmPrincipalUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmPrincipalAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmPrincipal_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmPrincipal_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmPrincipal_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.tabPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tlbAcciones = New System.Windows.Forms.ToolBar
        Me.toolNuevo = New System.Windows.Forms.ToolBarButton
        Me.toolGuardar = New System.Windows.Forms.ToolBarButton
        Me.toolCancelar = New System.Windows.Forms.ToolBarButton
        Me.toolCubo = New System.Windows.Forms.ToolBarButton
        Me.toolActualizacion = New System.Windows.Forms.ToolBarButton
        Me.toolMateriales = New System.Windows.Forms.ToolBarButton
        Me.toolImportar = New System.Windows.Forms.ToolBarButton
        Me.toolCambiarTema = New System.Windows.Forms.ToolBarButton
        Me.BarraEstado = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.btnCambiarCompania = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCompania = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.chrGraficoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCampaña.SuspendLayout()
        CType(Me.tabGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrafico.SuspendLayout()
        Me.palResumen.SuspendLayout()
        CType(Me.iugSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gntGantt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDockingArea1.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.chrGrafico)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 1)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(248, 187)
        '
        'chrGrafico
        '
        Me.chrGrafico.Axis.X.Labels.Flip = False
        Me.chrGrafico.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.X.Labels.OrientationAngle = 0
        Me.chrGrafico.Axis.X.Labels.SeriesLabels.Flip = False
        Me.chrGrafico.Axis.X.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGrafico.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.X.ScrollScale.Height = 10
        Me.chrGrafico.Axis.X.ScrollScale.Visible = False
        Me.chrGrafico.Axis.X.ScrollScale.Width = 15
        Me.chrGrafico.Axis.X.TickmarkInterval = 0
        Me.chrGrafico.Axis.X2.Labels.Flip = False
        Me.chrGrafico.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.X2.Labels.OrientationAngle = 0
        Me.chrGrafico.Axis.X2.Labels.SeriesLabels.Flip = False
        Me.chrGrafico.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.X2.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGrafico.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.X2.ScrollScale.Height = 10
        Me.chrGrafico.Axis.X2.ScrollScale.Visible = False
        Me.chrGrafico.Axis.X2.ScrollScale.Width = 15
        Me.chrGrafico.Axis.X2.TickmarkInterval = 0
        Me.chrGrafico.Axis.Y.Labels.Flip = False
        Me.chrGrafico.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.chrGrafico.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.00>"
        Me.chrGrafico.Axis.Y.Labels.OrientationAngle = 0
        Me.chrGrafico.Axis.Y.Labels.SeriesLabels.Flip = False
        Me.chrGrafico.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.chrGrafico.Axis.Y.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGrafico.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Y.ScrollScale.Height = 10
        Me.chrGrafico.Axis.Y.ScrollScale.Visible = False
        Me.chrGrafico.Axis.Y.ScrollScale.Width = 15
        Me.chrGrafico.Axis.Y.TickmarkInterval = 0
        Me.chrGrafico.Axis.Y2.Labels.Flip = False
        Me.chrGrafico.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.00>"
        Me.chrGrafico.Axis.Y2.Labels.OrientationAngle = 0
        Me.chrGrafico.Axis.Y2.Labels.SeriesLabels.Flip = False
        Me.chrGrafico.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.chrGrafico.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.Y2.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGrafico.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Y2.ScrollScale.Height = 10
        Me.chrGrafico.Axis.Y2.ScrollScale.Visible = False
        Me.chrGrafico.Axis.Y2.ScrollScale.Width = 15
        Me.chrGrafico.Axis.Y2.TickmarkInterval = 0
        Me.chrGrafico.Axis.Z.Labels.Flip = False
        Me.chrGrafico.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.Z.Labels.OrientationAngle = 0
        Me.chrGrafico.Axis.Z.Labels.SeriesLabels.Flip = False
        Me.chrGrafico.Axis.Z.Labels.SeriesLabels.FormatString = ""
        Me.chrGrafico.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGrafico.Axis.Z.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGrafico.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Z.ScrollScale.Height = 10
        Me.chrGrafico.Axis.Z.ScrollScale.Visible = False
        Me.chrGrafico.Axis.Z.ScrollScale.Width = 15
        Me.chrGrafico.Axis.Z.TickmarkInterval = 0
        Me.chrGrafico.Axis.Z2.Labels.Flip = False
        Me.chrGrafico.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGrafico.Axis.Z2.Labels.OrientationAngle = 0
        Me.chrGrafico.Axis.Z2.Labels.SeriesLabels.Flip = False
        Me.chrGrafico.Axis.Z2.Labels.SeriesLabels.FormatString = ""
        Me.chrGrafico.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGrafico.Axis.Z2.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGrafico.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGrafico.Axis.Z2.ScrollScale.Height = 10
        Me.chrGrafico.Axis.Z2.ScrollScale.Visible = False
        Me.chrGrafico.Axis.Z2.ScrollScale.Width = 15
        Me.chrGrafico.Axis.Z2.TickmarkInterval = 0
        Me.chrGrafico.ColorModel.ColorBegin = System.Drawing.Color.Black
        Me.chrGrafico.ColorModel.ColorEnd = System.Drawing.Color.Azure
        Me.chrGrafico.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.LinearRange
        Me.chrGrafico.Data.EmptyStyle.LineStyle.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dash
        Me.chrGrafico.Data.EmptyStyle.LineStyle.EndStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.NoAnchor
        Me.chrGrafico.Data.EmptyStyle.LineStyle.MidPointAnchors = False
        Me.chrGrafico.Data.EmptyStyle.LineStyle.StartStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.NoAnchor
        Me.chrGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chrGrafico.EmptyChartText = ""
        Me.chrGrafico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chrGrafico.Legend.Location = Infragistics.UltraChart.[Shared].Styles.LegendLocation.Bottom
        Me.chrGrafico.Legend.Visible = True
        Me.chrGrafico.Location = New System.Drawing.Point(0, 0)
        Me.chrGrafico.Name = "chrGrafico"
        Me.chrGrafico.Size = New System.Drawing.Size(248, 187)
        Me.chrGrafico.TabIndex = 45
        Me.chrGrafico.Tooltips.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.chrGrafico.Tooltips.UseControl = False
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.chrGraficoMensual)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(248, 187)
        '
        ''UltraChart' properties's serialization: Since 'ChartType' changes the way axes look,
        ''ChartType' must be persisted ahead of any Axes change made in design time.
        '
        Me.chrGraficoMensual.ChartType = Infragistics.UltraChart.[Shared].Styles.ChartType.PieChart
        '
        'chrGraficoMensual
        '
        Me.chrGraficoMensual.Axis.X.Labels.Flip = False
        Me.chrGraficoMensual.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGraficoMensual.Axis.X.Labels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.X.Labels.SeriesLabels.Flip = False
        Me.chrGraficoMensual.Axis.X.Labels.SeriesLabels.FormatString = ""
        Me.chrGraficoMensual.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.X.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.X.ScrollScale.Height = 10
        Me.chrGraficoMensual.Axis.X.ScrollScale.Visible = False
        Me.chrGraficoMensual.Axis.X.ScrollScale.Width = 15
        Me.chrGraficoMensual.Axis.X.TickmarkInterval = 0
        Me.chrGraficoMensual.Axis.X2.Labels.Flip = False
        Me.chrGraficoMensual.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGraficoMensual.Axis.X2.Labels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.X2.Labels.SeriesLabels.Flip = False
        Me.chrGraficoMensual.Axis.X2.Labels.SeriesLabels.FormatString = ""
        Me.chrGraficoMensual.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.X2.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.X2.ScrollScale.Height = 10
        Me.chrGraficoMensual.Axis.X2.ScrollScale.Visible = False
        Me.chrGraficoMensual.Axis.X2.ScrollScale.Width = 15
        Me.chrGraficoMensual.Axis.X2.TickmarkInterval = 0
        Me.chrGraficoMensual.Axis.Y.Labels.Flip = False
        Me.chrGraficoMensual.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.00>"
        Me.chrGraficoMensual.Axis.Y.Labels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Y.Labels.SeriesLabels.Flip = False
        Me.chrGraficoMensual.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.chrGraficoMensual.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGraficoMensual.Axis.Y.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Y.ScrollScale.Height = 10
        Me.chrGraficoMensual.Axis.Y.ScrollScale.Visible = False
        Me.chrGraficoMensual.Axis.Y.ScrollScale.Width = 15
        Me.chrGraficoMensual.Axis.Y.TickmarkInterval = 0
        Me.chrGraficoMensual.Axis.Y2.Labels.Flip = False
        Me.chrGraficoMensual.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.Y2.Labels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Y2.Labels.SeriesLabels.Flip = False
        Me.chrGraficoMensual.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.chrGraficoMensual.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGraficoMensual.Axis.Y2.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Y2.ScrollScale.Height = 10
        Me.chrGraficoMensual.Axis.Y2.ScrollScale.Visible = False
        Me.chrGraficoMensual.Axis.Y2.ScrollScale.Width = 15
        Me.chrGraficoMensual.Axis.Y2.TickmarkInterval = 0
        Me.chrGraficoMensual.Axis.Z.Labels.Flip = False
        Me.chrGraficoMensual.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.Z.Labels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Z.Labels.SeriesLabels.Flip = False
        Me.chrGraficoMensual.Axis.Z.Labels.SeriesLabels.FormatString = ""
        Me.chrGraficoMensual.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGraficoMensual.Axis.Z.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Z.ScrollScale.Height = 10
        Me.chrGraficoMensual.Axis.Z.ScrollScale.Visible = False
        Me.chrGraficoMensual.Axis.Z.ScrollScale.Width = 15
        Me.chrGraficoMensual.Axis.Z.TickmarkInterval = 0
        Me.chrGraficoMensual.Axis.Z2.Labels.Flip = False
        Me.chrGraficoMensual.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.chrGraficoMensual.Axis.Z2.Labels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Z2.Labels.SeriesLabels.Flip = False
        Me.chrGraficoMensual.Axis.Z2.Labels.SeriesLabels.FormatString = ""
        Me.chrGraficoMensual.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.chrGraficoMensual.Axis.Z2.Labels.SeriesLabels.OrientationAngle = 0
        Me.chrGraficoMensual.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.chrGraficoMensual.Axis.Z2.ScrollScale.Height = 10
        Me.chrGraficoMensual.Axis.Z2.ScrollScale.Visible = False
        Me.chrGraficoMensual.Axis.Z2.ScrollScale.Width = 15
        Me.chrGraficoMensual.Axis.Z2.TickmarkInterval = 0
        Me.chrGraficoMensual.ColorModel.ColorBegin = System.Drawing.Color.Black
        Me.chrGraficoMensual.ColorModel.ColorEnd = System.Drawing.Color.Azure
        Me.chrGraficoMensual.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.LinearRange
        Me.chrGraficoMensual.Data.EmptyStyle.LineStyle.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dash
        Me.chrGraficoMensual.Data.EmptyStyle.LineStyle.EndStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.NoAnchor
        Me.chrGraficoMensual.Data.EmptyStyle.LineStyle.MidPointAnchors = False
        Me.chrGraficoMensual.Data.EmptyStyle.LineStyle.StartStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.NoAnchor
        Me.chrGraficoMensual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chrGraficoMensual.EmptyChartText = ""
        Me.chrGraficoMensual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chrGraficoMensual.Legend.Location = Infragistics.UltraChart.[Shared].Styles.LegendLocation.Bottom
        Me.chrGraficoMensual.Legend.Visible = True
        Me.chrGraficoMensual.Location = New System.Drawing.Point(0, 0)
        Me.chrGraficoMensual.Name = "chrGraficoMensual"
        Me.chrGraficoMensual.Size = New System.Drawing.Size(248, 187)
        Me.chrGraficoMensual.TabIndex = 46
        Me.chrGraficoMensual.Tooltips.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.chrGraficoMensual.Tooltips.UseControl = False
        '
        'treCampaña
        '
        Me.treCampaña.BackColor = System.Drawing.SystemColors.Window
        Me.treCampaña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treCampaña.ContextMenu = Me.mnuCampanias
        Me.treCampaña.FullRowSelect = True
        Me.treCampaña.HideSelection = False
        Me.treCampaña.ImageIndex = 3
        Me.treCampaña.ImageList = Me.ImageList1
        Me.treCampaña.Location = New System.Drawing.Point(0, 18)
        Me.treCampaña.Name = "treCampaña"
        Me.treCampaña.SelectedImageIndex = 3
        Me.treCampaña.ShowLines = False
        Me.treCampaña.ShowPlusMinus = False
        Me.treCampaña.Size = New System.Drawing.Size(209, 194)
        Me.treCampaña.TabIndex = 91
        '
        'mnuCampanias
        '
        Me.mnuCampanias.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Duplicar"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Borrar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Lime
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        '
        'treSistema
        '
        Me.treSistema.BackColor = System.Drawing.SystemColors.Window
        Me.treSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treSistema.ContextMenu = Me.mnuEjercicio
        Me.treSistema.FullRowSelect = True
        Me.treSistema.HideSelection = False
        Me.treSistema.ImageIndex = 0
        Me.treSistema.ImageList = Me.ImageList1
        Me.treSistema.Location = New System.Drawing.Point(0, 18)
        Me.treSistema.Name = "treSistema"
        Me.treSistema.SelectedImageIndex = 0
        Me.treSistema.Size = New System.Drawing.Size(209, 224)
        Me.treSistema.TabIndex = 90
        '
        'mnuEjercicio
        '
        Me.mnuEjercicio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem18, Me.MenuItem17, Me.MenuItem9, Me.MenuItem15, Me.MenuItem16, Me.MenuItem2, Me.MenuItem10, Me.MenuItem5, Me.MenuItem11, Me.MenuItem20, Me.MenuItem19})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Mostrar Planificación"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem12})
        Me.MenuItem17.Text = "Historial de Planificación"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "Planificación Original"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14})
        Me.MenuItem12.Text = "Diferencias de Planificación"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "Por Programa"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Por Fecha"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 3
        Me.MenuItem9.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "Mostrar Avisos Confirmados"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem2.Text = "Estado"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Activo"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Final"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "Duplicar"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 9
        Me.MenuItem11.Text = "Borrar"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 10
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 11
        Me.MenuItem19.Text = "Cubo del Ejercicio"
        '
        'tabCampaña
        '
        Me.tabCampaña.Controls.Add(Me.Splitter2)
        Me.tabCampaña.Controls.Add(Me.tabGrafico)
        Me.tabCampaña.Controls.Add(Me.palResumen)
        Me.tabCampaña.Location = New System.Drawing.Point(1, 20)
        Me.tabCampaña.Name = "tabCampaña"
        Me.tabCampaña.Size = New System.Drawing.Size(612, 408)
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(359, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 208)
        Me.Splitter2.TabIndex = 48
        Me.Splitter2.TabStop = False
        '
        'tabGrafico
        '
        Me.tabGrafico.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.tabGrafico.Controls.Add(Me.UltraTabPageControl7)
        Me.tabGrafico.Controls.Add(Me.UltraTabPageControl8)
        Me.tabGrafico.Dock = System.Windows.Forms.DockStyle.Right
        Me.tabGrafico.Location = New System.Drawing.Point(362, 0)
        Me.tabGrafico.Name = "tabGrafico"
        Me.tabGrafico.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.tabGrafico.Size = New System.Drawing.Size(250, 208)
        Me.tabGrafico.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.tabGrafico.TabIndex = 0
        Me.tabGrafico.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.BottomLeft
        UltraTab8.Key = "tiposoporte"
        UltraTab8.TabPage = Me.UltraTabPageControl7
        UltraTab8.Text = "Inv. por Soporte"
        UltraTab9.Key = "mensual"
        UltraTab9.TabPage = Me.UltraTabPageControl8
        UltraTab9.Text = "Inv. por Soporte Mensual"
        Me.tabGrafico.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab8, UltraTab9})
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(248, 187)
        '
        'palResumen
        '
        Me.palResumen.Controls.Add(Me.iugSistema)
        Me.palResumen.Controls.Add(Me.gntGantt)
        Me.palResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.palResumen.Location = New System.Drawing.Point(0, 208)
        Me.palResumen.Name = "palResumen"
        Me.palResumen.Size = New System.Drawing.Size(612, 200)
        Me.palResumen.TabIndex = 50
        '
        'iugSistema
        '
        Me.iugSistema.Cursor = System.Windows.Forms.Cursors.Default
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.iugSistema.DisplayLayout.Appearance = Appearance11
        Me.iugSistema.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.iugSistema.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.RaisedSoft
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.iugSistema.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Me.iugSistema.DisplayLayout.Override.CellPadding = 3
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugSistema.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.iugSistema.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance14.BorderColor = System.Drawing.Color.LightGray
        Appearance14.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugSistema.DisplayLayout.Override.RowAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.PowderBlue
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.iugSistema.DisplayLayout.Override.SelectedRowAppearance = Appearance15
        Me.iugSistema.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugSistema.FlatMode = True
        Me.iugSistema.Location = New System.Drawing.Point(0, 0)
        Me.iugSistema.Name = "iugSistema"
        Me.iugSistema.Size = New System.Drawing.Size(612, 200)
        Me.iugSistema.TabIndex = 15
        '
        'gntGantt
        '
        Me.gntGantt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gntGantt.Enabled = True
        Me.gntGantt.Location = New System.Drawing.Point(0, 0)
        Me.gntGantt.Name = "gntGantt"
        Me.gntGantt.OcxState = CType(resources.GetObject("gntGantt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.gntGantt.Size = New System.Drawing.Size(612, 200)
        Me.gntGantt.TabIndex = 51
        '
        'tabSistema
        '
        Me.tabSistema.Enabled = False
        Me.tabSistema.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabSistema.Name = "tabSistema"
        Me.tabSistema.Size = New System.Drawing.Size(612, 408)
        '
        'tabTemas
        '
        Me.tabTemas.Enabled = False
        Me.tabTemas.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabTemas.Name = "tabTemas"
        Me.tabTemas.Size = New System.Drawing.Size(612, 408)
        '
        'tabEjercicios
        '
        Me.tabEjercicios.Enabled = False
        Me.tabEjercicios.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabEjercicios.Name = "tabEjercicios"
        Me.tabEjercicios.Size = New System.Drawing.Size(612, 408)
        '
        'tabAlternativa
        '
        Me.tabAlternativa.Enabled = False
        Me.tabAlternativa.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabAlternativa.Name = "tabAlternativa"
        Me.tabAlternativa.Size = New System.Drawing.Size(612, 408)
        '
        'UltraDockManager1
        '
        DockableControlPane3.Control = Me.treCampaña
        DockableControlPane3.FlyoutSize = New System.Drawing.Size(209, -1)
        DockableControlPane3.Key = "campaña"
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(640, 44, 92, 156)
        DockableControlPane3.Size = New System.Drawing.Size(209, 211)
        DockableControlPane3.Text = "Explorador de Campañas"
        DockableControlPane4.Control = Me.treSistema
        DockableControlPane4.Key = "sistemas"
        DockableControlPane4.OriginalControlBounds = New System.Drawing.Rectangle(500, 40, 96, 120)
        DockableControlPane4.Size = New System.Drawing.Size(209, 244)
        DockableControlPane4.Text = "Explorador de Sistemas"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane3, DockableControlPane4})
        DockAreaPane2.SelectedTabIndex = 1
        DockAreaPane2.Size = New System.Drawing.Size(209, 461)
        Me.UltraDockManager1.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane2})
        Me.UltraDockManager1.HostControl = Me
        '
        '_frmPrincipalUnpinnedTabAreaLeft
        '
        Me._frmPrincipalUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._frmPrincipalUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmPrincipalUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 24)
        Me._frmPrincipalUnpinnedTabAreaLeft.Name = "_frmPrincipalUnpinnedTabAreaLeft"
        Me._frmPrincipalUnpinnedTabAreaLeft.Owner = Me.UltraDockManager1
        Me._frmPrincipalUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 459)
        Me._frmPrincipalUnpinnedTabAreaLeft.TabIndex = 5
        '
        '_frmPrincipalUnpinnedTabAreaRight
        '
        Me._frmPrincipalUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._frmPrincipalUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmPrincipalUnpinnedTabAreaRight.Location = New System.Drawing.Point(828, 24)
        Me._frmPrincipalUnpinnedTabAreaRight.Name = "_frmPrincipalUnpinnedTabAreaRight"
        Me._frmPrincipalUnpinnedTabAreaRight.Owner = Me.UltraDockManager1
        Me._frmPrincipalUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 459)
        Me._frmPrincipalUnpinnedTabAreaRight.TabIndex = 6
        '
        '_frmPrincipalUnpinnedTabAreaTop
        '
        Me._frmPrincipalUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._frmPrincipalUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmPrincipalUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 24)
        Me._frmPrincipalUnpinnedTabAreaTop.Name = "_frmPrincipalUnpinnedTabAreaTop"
        Me._frmPrincipalUnpinnedTabAreaTop.Owner = Me.UltraDockManager1
        Me._frmPrincipalUnpinnedTabAreaTop.Size = New System.Drawing.Size(828, 0)
        Me._frmPrincipalUnpinnedTabAreaTop.TabIndex = 7
        '
        '_frmPrincipalUnpinnedTabAreaBottom
        '
        Me._frmPrincipalUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._frmPrincipalUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmPrincipalUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 483)
        Me._frmPrincipalUnpinnedTabAreaBottom.Name = "_frmPrincipalUnpinnedTabAreaBottom"
        Me._frmPrincipalUnpinnedTabAreaBottom.Owner = Me.UltraDockManager1
        Me._frmPrincipalUnpinnedTabAreaBottom.Size = New System.Drawing.Size(828, 0)
        Me._frmPrincipalUnpinnedTabAreaBottom.TabIndex = 8
        '
        '_frmPrincipalAutoHideControl
        '
        Me._frmPrincipalAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmPrincipalAutoHideControl.Location = New System.Drawing.Point(21, 22)
        Me._frmPrincipalAutoHideControl.Name = "_frmPrincipalAutoHideControl"
        Me._frmPrincipalAutoHideControl.Owner = Me.UltraDockManager1
        Me._frmPrincipalAutoHideControl.Size = New System.Drawing.Size(14, 461)
        Me._frmPrincipalAutoHideControl.TabIndex = 9
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.ImageListSmall = Me.ImageList1
        Me.UltraToolbarsManager1.MdiMergeable = False
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 0
        UltraToolbar2.FloatingLocation = New System.Drawing.Point(528, 394)
        UltraToolbar2.FloatingSize = New System.Drawing.Size(106, 120)
        UltraToolbar2.IsMainMenuBar = True
        UltraToolbar2.Text = "Menu"
        UltraToolbar2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool23, PopupMenuTool24, PopupMenuTool25, PopupMenuTool26, PopupMenuTool27, PopupMenuTool28, PopupMenuTool29, PopupMenuTool30, PopupMenuTool31, PopupMenuTool32})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        Appearance16.Image = 0
        ButtonTool44.SharedProps.AppearancesSmall.Appearance = Appearance16
        ButtonTool44.SharedProps.Caption = "Nuevo"
        Appearance17.Image = 1
        ButtonTool45.SharedProps.AppearancesSmall.Appearance = Appearance17
        ButtonTool45.SharedProps.Caption = "Abrir"
        Appearance18.Image = 2
        ButtonTool46.SharedProps.AppearancesSmall.Appearance = Appearance18
        ButtonTool46.SharedProps.Caption = "Guardar"
        Appearance19.Image = 7
        ButtonTool47.SharedProps.AppearancesSmall.Appearance = Appearance19
        ButtonTool47.SharedProps.Caption = "Imprimir"
        PopupMenuTool33.SharedProps.Caption = "Programa"
        PopupMenuTool33.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool36})
        StateButtonTool37.SharedProps.Caption = "Opciones"
        StateButtonTool38.SharedProps.Caption = "Salir"
        PopupMenuTool34.SharedProps.Caption = "Clientes"
        PopupMenuTool34.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool49, StateButtonTool39})
        ButtonTool50.SharedProps.Caption = "Cambiar de Cliente"
        StateButtonTool40.SharedProps.Caption = "Explorador de Campañas"
        StateButtonTool41.SharedProps.Caption = "Explorador de Sistemas"
        PopupMenuTool35.SharedProps.Caption = "Ver"
        PopupMenuTool35.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool42, StateButtonTool43})
        PopupMenuTool36.SharedProps.Caption = "Audiencia"
        PopupMenuTool36.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool44, ButtonTool51, ButtonTool52, ButtonTool53, ButtonTool54})
        StateButtonTool45.SharedProps.Caption = "Cargar Audiencia TVA"
        StateButtonTool46.SharedProps.Caption = "Cargar Audiencia TVC"
        StateButtonTool47.SharedProps.Caption = "Cargar Audiencia TVI"
        ButtonTool55.SharedProps.Caption = "Cargar Programas"
        ButtonTool56.SharedProps.Caption = "Asociar Programas"
        PopupMenuTool37.SharedProps.Caption = "Tarifas"
        PopupMenuTool37.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool48, StateButtonTool49, ButtonTool57, ButtonTool58, ButtonTool59})
        StateButtonTool50.SharedProps.Caption = "Carga de Tarifas"
        StateButtonTool51.SharedProps.Caption = "Copiar Tarifas"
        StateButtonTool52.SharedProps.Caption = "Franjas"
        PopupMenuTool38.SharedProps.Caption = "Envío a Compras"
        PopupMenuTool38.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool53})
        StateButtonTool54.SharedProps.Caption = "Enviar a Compras"
        PopupMenuTool39.SharedProps.Caption = "Edición"
        StateButtonTool58.InstanceProps.IsFirstInGroup = True
        PopupMenuTool39.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool55, StateButtonTool56, StateButtonTool57, StateButtonTool58, StateButtonTool59, StateButtonTool60})
        StateButtonTool61.SharedProps.Caption = "Duplicar Campaña"
        StateButtonTool62.SharedProps.Caption = "Duplicar Sistema"
        StateButtonTool63.SharedProps.Caption = "Duplicar Ejercicio"
        StateButtonTool64.SharedProps.Caption = "Borrar Campaña"
        StateButtonTool65.SharedProps.Caption = "Borrar Sistema"
        StateButtonTool66.SharedProps.Caption = "Borrar Ejercicio"
        ButtonTool60.SharedProps.Caption = "Reporte tarifas genéricas"
        ButtonTool61.SharedProps.Caption = "Mantenimiento de Fechas"
        PopupMenuTool40.SharedProps.Caption = "Convenios"
        PopupMenuTool40.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool67, PopupMenuTool41, ButtonTool62, ButtonTool63, ButtonTool64, ButtonTool65})
        StateButtonTool68.SharedProps.Caption = "Listar Convenios"
        ButtonTool66.SharedProps.Caption = "Convenios de Descuento"
        ButtonTool67.SharedProps.Caption = "Convenios de Tarifa Plana"
        PopupMenuTool42.SharedProps.Caption = "Mantenimiento de Convenios"
        PopupMenuTool42.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool68, ButtonTool69, ButtonTool70, StateButtonTool69})
        ButtonTool71.SharedProps.Caption = "Calcular Audiencia Radio"
        StateButtonTool70.SharedProps.Caption = "Duplicar Convenios"
        PopupMenuTool43.SharedProps.AllowMultipleInstances = False
        PopupMenuTool43.SharedProps.Caption = "Actualizacion"
        PopupMenuTool43.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool72})
        TextBoxTool2.SharedProps.Caption = "Soportes"
        LabelTool2.SharedProps.Caption = "Soportes"
        ButtonTool73.SharedProps.Caption = "Soportes"
        PopupControlContainerTool2.SharedProps.Caption = "Soportes"
        ButtonTool74.SharedProps.Caption = "Convenios de CPR"
        ButtonTool75.SharedProps.Caption = "Reporte Tarifa Promedio"
        PopupMenuTool44.SharedProps.Caption = "Auxiliar"
        PopupMenuTool44.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool76, ButtonTool77})
        ButtonTool78.SharedProps.Caption = "Cargar padron AGIP"
        ButtonTool79.SharedProps.Caption = "Cargar padron AGIP"
        ButtonTool80.SharedProps.Caption = "Reporte Convenios"
        ButtonTool81.SharedProps.Caption = "Reporte Tarifas Tv Capital"
        ButtonTool82.SharedProps.Caption = "Administrar Perfil"
        ButtonTool83.SharedProps.Caption = "Convenios Masivo"
        ButtonTool84.SharedProps.Caption = "Convenios Masivo"
        ButtonTool85.SharedProps.Caption = "Reporte Convenios Estados"
        ButtonTool86.SharedProps.Caption = "Convenio Especial"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool44, ButtonTool45, ButtonTool46, ButtonTool47, ButtonTool48, PopupMenuTool33, StateButtonTool37, StateButtonTool38, PopupMenuTool34, ButtonTool50, StateButtonTool40, StateButtonTool41, PopupMenuTool35, PopupMenuTool36, StateButtonTool45, StateButtonTool46, StateButtonTool47, ButtonTool55, ButtonTool56, PopupMenuTool37, StateButtonTool50, StateButtonTool51, StateButtonTool52, PopupMenuTool38, StateButtonTool54, PopupMenuTool39, StateButtonTool61, StateButtonTool62, StateButtonTool63, StateButtonTool64, StateButtonTool65, StateButtonTool66, ButtonTool60, ButtonTool61, PopupMenuTool40, StateButtonTool68, ButtonTool66, ButtonTool67, PopupMenuTool42, ButtonTool71, StateButtonTool70, PopupMenuTool43, TextBoxTool2, LabelTool2, ButtonTool73, PopupControlContainerTool2, ButtonTool74, ButtonTool75, PopupMenuTool44, ButtonTool78, ButtonTool79, ButtonTool80, ButtonTool81, ButtonTool82, ButtonTool83, ButtonTool84, ButtonTool85, ButtonTool86})
        '
        '_frmPrincipal_Toolbars_Dock_Area_Left
        '
        Me._frmPrincipal_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipal_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipal_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmPrincipal_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipal_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 24)
        Me._frmPrincipal_Toolbars_Dock_Area_Left.Name = "_frmPrincipal_Toolbars_Dock_Area_Left"
        Me._frmPrincipal_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 459)
        Me._frmPrincipal_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmPrincipal_Toolbars_Dock_Area_Right
        '
        Me._frmPrincipal_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipal_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipal_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmPrincipal_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipal_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(828, 24)
        Me._frmPrincipal_Toolbars_Dock_Area_Right.Name = "_frmPrincipal_Toolbars_Dock_Area_Right"
        Me._frmPrincipal_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 459)
        Me._frmPrincipal_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmPrincipal_Toolbars_Dock_Area_Top
        '
        Me._frmPrincipal_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipal_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipal_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmPrincipal_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipal_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmPrincipal_Toolbars_Dock_Area_Top.Name = "_frmPrincipal_Toolbars_Dock_Area_Top"
        Me._frmPrincipal_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(828, 24)
        Me._frmPrincipal_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmPrincipal_Toolbars_Dock_Area_Bottom
        '
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 483)
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.Name = "_frmPrincipal_Toolbars_Dock_Area_Bottom"
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(828, 0)
        Me._frmPrincipal_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Left
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(0, 24)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.UltraDockManager1
        Me.WindowDockingArea1.Size = New System.Drawing.Size(214, 459)
        Me.WindowDockingArea1.TabIndex = 40
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.treCampaña)
        Me.DockableWindow2.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UltraDockManager1
        Me.DockableWindow2.Size = New System.Drawing.Size(209, 212)
        Me.DockableWindow2.TabIndex = 1
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.treSistema)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 217)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UltraDockManager1
        Me.DockableWindow1.Size = New System.Drawing.Size(209, 242)
        Me.DockableWindow1.TabIndex = 0
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 0
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Tag = "nuevo"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 2
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Tag = "guardar"
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(340, 269)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 2)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(340, 269)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(340, 269)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(2, 2)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(340, 269)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(340, 269)
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(2, 2)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(352, 469)
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Tag = "nuevo"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 2
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Tag = "guardar"
        '
        'tabPrincipal
        '
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.ForeColor = System.Drawing.Color.Blue
        Me.tabPrincipal.ActiveTabAppearance = Appearance7
        Me.tabPrincipal.Controls.Add(Me.tabCampaña)
        Me.tabPrincipal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabPrincipal.Controls.Add(Me.tabSistema)
        Me.tabPrincipal.Controls.Add(Me.tabTemas)
        Me.tabPrincipal.Controls.Add(Me.tabEjercicios)
        Me.tabPrincipal.Controls.Add(Me.tabAlternativa)
        Me.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPrincipal.Location = New System.Drawing.Point(214, 54)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabPrincipal.Size = New System.Drawing.Size(614, 429)
        Me.tabPrincipal.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.tabPrincipal.TabIndex = 51
        UltraTab1.Key = "campaña"
        UltraTab1.TabPage = Me.tabCampaña
        UltraTab1.Text = "Campaña"
        UltraTab2.Key = "sistemas"
        UltraTab2.TabPage = Me.tabSistema
        UltraTab2.Text = "Sistemas"
        UltraTab10.Key = "temas"
        UltraTab10.TabPage = Me.tabTemas
        UltraTab10.Text = "Temas"
        UltraTab11.Key = "ejercicios"
        UltraTab11.TabPage = Me.tabEjercicios
        UltraTab11.Text = "Ejercicios"
        UltraTab12.Key = "alternativas"
        UltraTab12.TabPage = Me.tabAlternativa
        UltraTab12.Text = "Alternativas"
        Me.tabPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab10, UltraTab11, UltraTab12})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(612, 408)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tlbAcciones)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(214, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 30)
        Me.Panel1.TabIndex = 52
        '
        'tlbAcciones
        '
        Me.tlbAcciones.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tlbAcciones.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolNuevo, Me.toolGuardar, Me.toolCancelar, Me.toolCubo, Me.toolActualizacion, Me.toolMateriales, Me.toolImportar, Me.toolCambiarTema})
        Me.tlbAcciones.DropDownArrows = True
        Me.tlbAcciones.ImageList = Me.ImageList1
        Me.tlbAcciones.Location = New System.Drawing.Point(0, 0)
        Me.tlbAcciones.Name = "tlbAcciones"
        Me.tlbAcciones.ShowToolTips = True
        Me.tlbAcciones.Size = New System.Drawing.Size(614, 28)
        Me.tlbAcciones.TabIndex = 56
        '
        'toolNuevo
        '
        Me.toolNuevo.ImageIndex = 0
        Me.toolNuevo.Name = "toolNuevo"
        Me.toolNuevo.Tag = "nuevo"
        Me.toolNuevo.ToolTipText = "Nuevo"
        '
        'toolGuardar
        '
        Me.toolGuardar.ImageIndex = 2
        Me.toolGuardar.Name = "toolGuardar"
        Me.toolGuardar.Tag = "guardar"
        Me.toolGuardar.ToolTipText = "Guardar"
        '
        'toolCancelar
        '
        Me.toolCancelar.ImageIndex = 6
        Me.toolCancelar.Name = "toolCancelar"
        Me.toolCancelar.Tag = "cancelar"
        Me.toolCancelar.ToolTipText = "Cancelar"
        '
        'toolCubo
        '
        Me.toolCubo.ImageIndex = 7
        Me.toolCubo.Name = "toolCubo"
        Me.toolCubo.Tag = "cubo"
        Me.toolCubo.ToolTipText = "Cubo"
        Me.toolCubo.Visible = False
        '
        'toolActualizacion
        '
        Me.toolActualizacion.ImageIndex = 5
        Me.toolActualizacion.Name = "toolActualizacion"
        Me.toolActualizacion.Tag = "actualizacion"
        Me.toolActualizacion.ToolTipText = "Actualización"
        Me.toolActualizacion.Visible = False
        '
        'toolMateriales
        '
        Me.toolMateriales.ImageIndex = 8
        Me.toolMateriales.Name = "toolMateriales"
        Me.toolMateriales.Tag = "materiales"
        Me.toolMateriales.ToolTipText = "Materiales"
        Me.toolMateriales.Visible = False
        '
        'toolImportar
        '
        Me.toolImportar.ImageIndex = 9
        Me.toolImportar.Name = "toolImportar"
        Me.toolImportar.Tag = "importacion"
        Me.toolImportar.ToolTipText = "Importación"
        Me.toolImportar.Visible = False
        '
        'toolCambiarTema
        '
        Me.toolCambiarTema.ImageIndex = 5
        Me.toolCambiarTema.Name = "toolCambiarTema"
        Me.toolCambiarTema.Tag = "CambiarTema"
        Me.toolCambiarTema.ToolTipText = "Cambiar Tema en Planificación"
        Me.toolCambiarTema.Visible = False
        '
        'BarraEstado
        '
        Me.BarraEstado.Location = New System.Drawing.Point(0, 483)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.BarraEstado.Size = New System.Drawing.Size(828, 22)
        Me.BarraEstado.TabIndex = 57
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "18/11/2005"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "Administrador"
        '
        'btnCambiarCompania
        '
        Me.btnCambiarCompania.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCambiarCompania.Location = New System.Drawing.Point(231, 483)
        Me.btnCambiarCompania.Name = "btnCambiarCompania"
        Me.btnCambiarCompania.Size = New System.Drawing.Size(26, 23)
        Me.btnCambiarCompania.TabIndex = 58
        Me.btnCambiarCompania.Text = "..."
        Me.btnCambiarCompania.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Compañía"
        '
        'lblCompania
        '
        Me.lblCompania.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCompania.AutoSize = True
        Me.lblCompania.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompania.ForeColor = System.Drawing.Color.Red
        Me.lblCompania.Location = New System.Drawing.Point(62, 487)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(0, 13)
        Me.lblCompania.TabIndex = 60
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'frmPrincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(828, 505)
        Me.Controls.Add(Me._frmPrincipalAutoHideControl)
        Me.Controls.Add(Me.lblCompania)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCambiarCompania)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Controls.Add(Me._frmPrincipalUnpinnedTabAreaTop)
        Me.Controls.Add(Me._frmPrincipalUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._frmPrincipalUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._frmPrincipalUnpinnedTabAreaRight)
        Me.Controls.Add(Me._frmPrincipal_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmPrincipal_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmPrincipal_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmPrincipal_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me.BarraEstado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Everest v.1.0.0.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.chrGraficoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCampaña.ResumeLayout(False)
        CType(Me.tabGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGrafico.ResumeLayout(False)
        Me.palResumen.ResumeLayout(False)
        CType(Me.iugSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gntGantt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'se usa para que no se seleccione solo el 1er elemento del tree campañas
    Dim Guardando As Boolean = False
    'se usa para que no cargue el grafico y la grilla cuando Load
    Dim Cargando As Boolean = True

    Dim SeccionActiva As SeccionActiva


    Dim ManejoABM As New ManejoABM
    Dim ABM As IABM

    Dim NoMensaje As Boolean
    Const MedioTV As Integer = 1

    Shared mInstancia As frmPrincipal
    Dim TipoEjercicio As Integer


    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Shared Property Instancia() As frmPrincipal
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmPrincipal
            End If


            Return mInstancia
        End Get
        Set(ByVal Value As frmPrincipal)
            mInstancia = Value
        End Set
    End Property

    Dim mUsuario As String
    Dim mContrasenia As String
    Public Property User() As String
        Get
            Return mUsuario
        End Get
        Set(ByVal Value As String)
            mUsuario = Value
        End Set
    End Property

    Public Property Contrasenia() As String
        Get
            Return mContrasenia
        End Get
        Set(ByVal Value As String)
            mContrasenia = Value
        End Set
    End Property

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Fx As New frmConexion

        'Fx.Show()

        Me.Text = "Everest - v." & Assembly.GetExecutingAssembly().GetName().Version.ToString

        '*** INICIALIZACIONES
        SeccionActiva = SeccionActiva.Campaña
        Dim Convenio As New Convenios
        Dim dsConvenio As DataSet
        Me.Instancia = Me
        '***

        '***************** BORRAR ESTAS LINEAS CUANDO ESTE EN PRODUCCION
        'Activo.IDUsuario = 57
        'Activo.Login = "ebaum"
        'Activo.IDPerfil_Datos = 21
        'Activo.IDCliente = 80
        'Activo.Cliente = "Codigo47 On de Rocks"
        'Activo.FechaDesdeCampaña = "10/10/2001"
        'Activo.FechaHastaCampaña = "15/11/2006"
        '***************** 

        '***************** CODIGO PARA ACTIVAR EL LOGIN - SACAR LOS COMENTARIOS CUANDO ESTE EN PRODUCCION
        Dim F As New frmLogIn

        F.ShowDialog()

        If Not F.EsLoginCorrecto Then
            Application.Exit()
            Exit Sub
        End If

        User = F.txtUsuario.Text
        Contrasenia = F.txtContraseña.Text

        'AG DBCompania
        Me.CargarGraficoInversion("tiposoporte")
        Dim OMsl As New Maestros
        lblCompania.Text = OMsl.ObtenerDescripcionCompaniaActual

        If Activo.IDPerfil_Datos = 1 AndAlso Activo.CodCapacidad = 6 Then
            dsConvenio = Convenio.ObtenerExtra(Activo.IDUsuario)
            If Not dsConvenio Is Nothing AndAlso Not dsConvenio.Tables(0) Is Nothing AndAlso dsConvenio.Tables.Count > 0 AndAlso dsConvenio.Tables(0).Rows.Count > 0 AndAlso Not dsConvenio.Tables(0).Columns("Id_Permiso") Is Nothing AndAlso Not dsConvenio.Tables(0).Rows(0)("Id_Permiso") Is DBNull.Value AndAlso (Convert.ToInt32(dsConvenio.Tables(0).Rows(0)("Id_Permiso")) = 2 Or Convert.ToInt32(dsConvenio.Tables(0).Rows(0)("Id_Permiso")) = 1) Then
                Dim rol As New frmRol
                rol.ShowDialog()

                If rol.pRol = frmRol.Rol.Control Then
                    Me.Hide()
                    Dim frmControl As New frmPrincipalControl
                    frmControl.ShowDialog()
                    Me.Close()
                    Exit Sub
                End If
            End If
        End If

        If Not dsConvenio Is Nothing AndAlso Not dsConvenio.Tables(0) Is Nothing AndAlso dsConvenio.Tables.Count > 0 AndAlso dsConvenio.Tables(0).Rows.Count > 0 AndAlso Not dsConvenio.Tables(0).Columns("Id_Permiso") Is Nothing AndAlso Not dsConvenio.Tables(0).Rows(0)("Id_Permiso") Is DBNull.Value Then
            Activo.PerfilConvenios = Convert.ToInt32(dsConvenio.Tables(0).Rows(0)("Id_Permiso"))
        Else
            Activo.PerfilConvenios = Activo.PerfilConvenio.SinPermisos
        End If

        Dim frmElegirCliente As New frmElegirCliente


        frmElegirCliente.CargandoPrimeraVez = True

        frmElegirCliente.ShowDialog()
        '***************** 

        Call CargarCliente(OMsl, dsConvenio, Convenio)


    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim OMsl As New Maestros
        Activo.DTPlazaCache = OMsl.PlazasTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        Activo.DTMaterialesCache = OMsl.TraerMaterialesCliente(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub CargarCliente(ByRef OMsl As Maestros, ByRef dsConvenio As DataSet, ByRef Convenio As Convenios)

        TraerCampañas()

        'Carga de DT Cache Maestros Tipo Soporte, Plazas, Medios, Materiales ---------------------------------------------------------------------------------- 

        'AG Velocidad Cache ==================================================================
        BackgroundWorker1.RunWorkerAsync()
        Activo.DTTipoSoporteCache = OMsl.ObtenerTipoSoportes(Constantes.COD_PAIS_ARGENTINA)
        Activo.DTMediosCache = OMsl.MediosTraerTodos(Constantes.COD_PAIS_ARGENTINA)

        'Activo.DTPlazaCache = OMsl.PlazasTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        'Activo.DTMaterialesCache = OMsl.TraerMaterialesCliente(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente)
        '========================================================================================

        'AG 22/10/2013 DIGITAL =====================================================================================
        '   Dim OSop As New MPG.DBL.Soportes
        '  Activo.DTSoportesCache = OSop.ObtenerSoportesMMSVistaMaterializada(MSL.Constantes.COD_PAIS_ARGENTINA)
        ' comentado gw 08/09/2014 vuelve a cargar los soportes ya filtrados

        Dim OColocaciones As New Colocaciones
        OColocaciones.Id_Medio = Activo.Medios.Internet
        Activo.DTColocacionesCache = OColocaciones.ObtenerColocaciones

        Dim OFormatos As New Formatos
        OFormatos.Id_Medio = Activo.Medios.Internet
        Activo.DTFormatosCache = OFormatos.ObtenerFormatos

        Dim OMaestro As New Maestros
        Activo.DTSeccionesInternetCache = OMaestro.seccionesObtener(Activo.Medios.Internet)
        Activo.DTSeccionesInternetCache.Columns.RemoveAt(0)
        '===========================================================================================================


        'Activo.DTSoportesCache = OMsl.ObtenerSoportes(MSL.Constantes.COD_PAIS_ARGENTINA)
        '-------------------------------------------------------------------------------------------------------------------------------------------------

        SeccionActiva = SeccionActiva.Campaña

        'carga el control de usuario
        Dim U As New abmCampaña
        ManejoABM.CargarControlABM("campaña", U, Me.tabCampaña, ABM)

        Me.ABM_Campaña_Cliente = Activo.Cliente


        Me.AjustarTabCampaña()

        'Habilita Opcion ABM Convenios
        dsConvenio = Convenio.ObtenerExtra(Activo.IDUsuario)
        If Not dsConvenio Is Nothing AndAlso Not dsConvenio.Tables(0) Is Nothing AndAlso dsConvenio.Tables.Count > 0 AndAlso dsConvenio.Tables(0).Rows.Count > 0 AndAlso Not dsConvenio.Tables(0).Columns("Id_Permiso") Is Nothing AndAlso Not dsConvenio.Tables(0).Rows(0)("Id_Permiso") Is DBNull.Value AndAlso Convert.ToInt32(dsConvenio.Tables(0).Rows(0)("Id_Permiso")) = 1 Then
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("MantenimientoConvenios").SharedProps.Enabled = True
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("Reporte_Convenios").SharedProps.Enabled = True
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("Convenios Masivo").SharedProps.Enabled = True 'AG 31/03/2015
        Else
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("MantenimientoConvenios").SharedProps.Enabled = False
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("Reporte_Convenios").SharedProps.Enabled = False
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("Convenios Masivo").SharedProps.Enabled = False 'AG 31/03/2015
        End If

        'AG 2/06/2015 ================================================================
        Dim DtUsuariosAutorizados As New DataTable
        Dim DtUsuariosEspecialConvenios As New DataTable
        Dim ObConvenios As New Convenios

        DtUsuariosAutorizados = ObConvenios.ObtenerUsuAutorizadoConvenios(CInt(Activo.CodCampaniaActualMms), Activo.CodUsuarioMms)

        If DtUsuariosAutorizados.Rows.Count > 0 Then
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("ReporteConveniosEstados").SharedProps.Visible = True
        End If

        DtUsuariosEspecialConvenios = ObConvenios.ObtenerConveniosUsuEspecial(CInt(Activo.CodCampaniaActualMms), Activo.CodUsuarioMms)

        If DtUsuariosEspecialConvenios.Rows.Count > 0 Then
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("ConvenioEspecial").SharedProps.Visible = True
        Else
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Convenio"), UltraWinToolbars.PopupMenuTool).Tools("ConvenioEspecial").SharedProps.Visible = False
        End If

        '==============================================================================

        'AG 11/06/2014 ================================================================
        Dim ObjUsuario As New Usuario
        Dim DtusuarioAdmin As New DataTable
        DtusuarioAdmin = ObjUsuario.UsuariosAdminPerfiles(Activo.IDUsuarioMMS)
        If DtusuarioAdmin.Rows.Count > 0 Then
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Auxiliar"), UltraWinToolbars.PopupMenuTool).Tools("AdministrarPerfiles").SharedProps.Enabled = True
        Else
            CType(UltraToolbarsManager1.Toolbars(0).Tools("Auxiliar"), UltraWinToolbars.PopupMenuTool).Tools("AdministrarPerfiles").SharedProps.Enabled = False
        End If

        '==============================================================================

        Dim GF As New GrillaFormato

        GF.AcivarOperacion(iugSistema, "Bruto", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn)
        GF.AcivarOperacion(iugSistema, "Neto", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn)

        'Dim OMsl As New Maestros
    End Sub


    Private Sub ABM_Sistema_Cancelar()
        If Me.tabSistema.Controls.Count > 0 Then
            DirectCast(Me.tabSistema.Controls(0), IABM).Cancelar()
        End If
    End Sub

    Private Sub ABM_Ejercicio_Cancelar()
        If Me.tabEjercicios.Controls.Count > 0 Then
            DirectCast(Me.tabEjercicios.Controls(0), IABM).Cancelar()
        End If
    End Sub

    Private Sub ABM_Temas_Cancelar()
        If Me.tabTemas.Controls.Count > 0 Then
            DirectCast(Me.tabTemas.Controls(0), IABM).Cancelar()
        End If
    End Sub

    Private WriteOnly Property ABM_Campaña_Cliente() As String
        Set(ByVal Value As String)
            If Me.tabCampaña.Controls.Count > 0 Then
                DirectCast(Me.tabCampaña.Controls(3), abmCampaña).lblCliente.Text = Value
            End If
        End Set
    End Property

    Public Sub ActualizarSoportesEjercicio()
        If Me.tabEjercicios.Controls.Count > 0 Then
            DirectCast(Me.tabEjercicios.Controls(0), abmEjercicios).CargarSoportesSpots()
        End If
    End Sub

    Private Sub TraerCampañas()
        Dim C As New Campaña

        C.ID_Cliente = Activo.IDCliente

        Guardando = True

        Dim Dt As DataTable = C.ObtenerCampañasCliente(Activo.FechaDesdeCampaña, Activo.FechaHastaCampaña)

        Listas.CargarTree(Me.treCampaña, Dt, "id_campania", "descripcion", True)

        If Cargando OrElse Dt.Rows.Count = 0 Then
            'desactiva los temas y los sistemas
            tabTemas.Enabled = False
            tabSistema.Enabled = False
            tabEjercicios.Enabled = False
            tabAlternativa.Enabled = False

            'ya se termino la carga inicial del programa
            Cargando = False
        Else
            'activa los temas y los sistemas
            tabSistema.Enabled = True
            tabTemas.Enabled = True
            tabEjercicios.Enabled = True
            tabAlternativa.Enabled = True
        End If

        If Me.treCampaña.Nodes.Count = 0 Then
            'DesactivarBotonGuardar()
        Else
            ActivarBotonGuardar()
        End If

        Guardando = False
    End Sub

    Private Sub CargarControlABM(ByVal ControlABM As Windows.Forms.Control, ByVal Contenedor As Object, Optional ByVal Left As Short = 0, Optional ByVal Top As Short = 0)
        'carga posiciona un control ABM
        If Left = 0 Then
            ControlABM.Left = Contenedor.Left + 10
        End If

        ControlABM.Top = Top

        'pasa el control a la interfaz (es para poder ejecutar metodos de abm en particular)
        ABM = ControlABM

        'agrega el control al Panel de ABMs
        Contenedor.controls.Add(ControlABM)
    End Sub

    Private Sub tabPrincipal_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabPrincipal.SelectedTabChanged
        Me.tlbAcciones.Buttons(0).Visible = True

        NoMensaje = False

        Select Case e.Tab.Key
            Case "campaña"
                ActivarCampaña()

            Case "sistemas"
                ActivarSistemas()

            Case "temas"
                ActivarTemas()

            Case "ejercicios"
                ActivarEjercicios()

            Case "alternativas"
                ActivarAlternativas()

        End Select
    End Sub

    Public Sub OcultarBotones()
        Me.tlbAcciones.Buttons(Botones.Actualizacion).Visible = False
        Me.tlbAcciones.Buttons(Botones.Materiales).Visible = False
        Me.tlbAcciones.Buttons(Botones.CambioTema).Visible = False
    End Sub

    Public Sub MostrarOcultarBotonToolBar(ByVal Boton As Botones, ByVal Mostrar As Boolean)
        'lo llaman los ABMs para mostrar u ocultar botones de la barra de herramientas
        Me.tlbAcciones.Buttons(Boton).Visible = Mostrar
    End Sub

    Private Sub ActivarCampaña()
        SeccionActiva = SeccionActiva.Campaña

        'recupera el control (el control se carga en el load)
        ManejoABM.RecuperarControl("campaña", Me.tabCampaña, ABM)

        Me.CargarGraficoInversion("tiposoporte")

        Me.tlbAcciones.Buttons(Botones.Cancelar).Visible = True
        Me.tlbAcciones.Buttons(Botones.Cubo).Visible = False
        Me.tlbAcciones.Buttons(Botones.Importacion).Visible = False

        OcultarBotones()
        ActivarBotonGuardar()
    End Sub

    Private Sub ActivarSistemas()
        SeccionActiva = SeccionActiva.Sistemas

        'si no se cargo el control en el form, lo carga, sino, ya devuelve el ABM con el control asignado
        If Not ManejoABM.RecuperarControl("sistemas", Me.tabSistema, ABM) Then
            Dim S As New abmSistemas

            ManejoABM.CargarControlABM("sistemas", S, Me.tabSistema, ABM)

        End If

        Try
            ABM.Cargar()
        Catch ex As Exception
        End Try

        OcultarBotones()

        Me.tlbAcciones.Buttons(Botones.Cancelar).Visible = True
        Me.tlbAcciones.Buttons(Botones.Cubo).Visible = False 'True
        Me.tlbAcciones.Buttons(Botones.Actualizacion).Visible = True
        Me.tlbAcciones.Buttons(Botones.Importacion).Visible = False

        If Activo.IDSistema = 0 Then
            DesactivarBotonGuardar()
        Else
            ActivarBotonGuardar()
        End If
    End Sub

    Private Sub ActivarEjercicios()
        SeccionActiva = SeccionActiva.Ejercicios

        'saca el boton cancelar
        Me.tlbAcciones.Buttons(2).Visible = True
        Me.tlbAcciones.Buttons(Botones.Importacion).Visible = True

        'si no se cargo el control en el form, lo carga, sino, ya devuelve el ABM con el control asignado
        If Not ManejoABM.RecuperarControl("ejercicios", Me.tabEjercicios, ABM) Then
            Dim Ej As New abmEjercicios

            ManejoABM.CargarControlABM("ejercicios", Ej, Me.tabEjercicios, ABM)
        End If

        OcultarBotones()

        If Activo.IDEjercicio = 0 Then
            DesactivarBotonGuardar()
        Else
            ActivarBotonGuardar()
        End If
    End Sub

    Private Sub ActivarTemas()
        SeccionActiva = SeccionActiva.Temas

        'saca el boton nuevo
        Me.tlbAcciones.Buttons(0).Visible = False

        'saca el boton cancelar
        Me.tlbAcciones.Buttons(2).Visible = False
        ' Me.tlbAcciones.Buttons(6).Visible = False

        'si no se cargo el control en el form, lo carga, sino, ya devuelve el ABM con el control asignado
        If Not ManejoABM.RecuperarControl("temas", Me.tabTemas, ABM) Then
            Dim T As New abmTema

            ManejoABM.CargarControlABM("temas", T, Me.tabTemas, ABM)
        End If

        OcultarBotones()

        Me.tlbAcciones.Buttons(Botones.Materiales).Visible = True
        Me.tlbAcciones.Buttons(Botones.CambioTema).Visible = True

        ABM.Cargar()

        Me.tlbAcciones.Buttons(Botones.Cubo).Visible = False
        Me.tlbAcciones.Buttons(Botones.Importacion).Visible = False
        ActivarBotonGuardar()
    End Sub

    Private Sub ActivarAlternativas()
        SeccionActiva = SeccionActiva.Alternativa

        If Not ManejoABM.RecuperarControl("alternativas", Me.tabAlternativa, ABM) Then
            Dim A As New abmAlternativas

            ManejoABM.CargarControlABM("alternativas", A, Me.tabAlternativa, ABM)
        End If

        ABM.Cargar()
        OcultarBotones()
        Me.tlbAcciones.Buttons(Botones.Cancelar).Visible = True
        Me.tlbAcciones.Buttons(Botones.Cubo).Visible = False
        Me.tlbAcciones.Buttons(Botones.Importacion).Visible = False

        If Activo.IDAlternativa = 0 Then
            DesactivarBotonGuardar()
        Else
            ActivarBotonGuardar()
        End If

    End Sub

    Private Sub AjustarTabCampaña()
        If Not ABM Is Nothing Then
            Me.iugSistema.Height = tabCampaña.Height - ABM.Alto - 64
            Me.tabGrafico.Width = tabCampaña.Width - ABM.Ancho - 20
        End If
    End Sub

    Private Sub tlbAcciones_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlbAcciones.ButtonClick
        Select Case e.Button.Tag
            Case "nuevo"
                Nuevo()

            Case "guardar"
                Guardar()

            Case "cancelar"
                Cancelar()

            Case "cubo"
                Cubo()

            Case "materiales"
                Materiales()

            Case "actualizacion"
                Actualizar()
            Case "importacion"
                'Exit Sub

                Importar()
            Case "CambiarTema"
                CambiarTemaPlanificacion()
        End Select
    End Sub
    Private Sub Importar()
        If Activo.IDMedio = 3 OrElse Activo.IDMedio = 4 OrElse Activo.IDMedio = 5 Then Exit Sub

        Dim e As New Ejercicios, s As New Spots_detalle

        e.Id_campania = Activo.IDCampaña
        e.Id_sistema = Activo.IDSistema
        e.Id_ejercicio = Activo.IDEjercicio

        If s.ObtenerSpotDetalle(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio).Rows.Count > 0 Then
            Exit Sub
        End If
        If e.ObtenerSoportesSpots.Rows.Count > 0 Then
            Exit Sub
        End If

        Dim f As New frmImportacion
        f.ShowDialog()


    End Sub
    Private Sub Cubo()
        If Activo.IDMedio = 3 OrElse Activo.IDMedio = 4 OrElse Activo.IDMedio = 5 Then Exit Sub

        Dim dt As DataTable
        Dim t As New Tarifas_tv
        Dim sql As String
        Dim frmCub As New Cubo
        ''MODIFICADO POR DANIEL CAIME
        ''SE COMENTA VISTAS NO EXISTENTES, SE AGREGA CAMPOS CON ID PARA OBTENER DESCRIPCIONES DE DATOS EN MMS

        ''SELECT
        sql = "SELECT DISTINCT"
        ''sql = sql & " s.descripcion RN_SOPORTE,"
        sql = sql & " '' AS RN_SOPORTE,"
        sql = sql & " SPT.PROGRAMA RN_PROGRAMA,"
        ''sql = sql & " sptd.id_tema  ||' - '|| m.Descripcion RN_TEMA,"
        sql = sql & " sptd.id_tema RN_TEMA,"
        sql = sql & " sptd.duracion RN_DURACION, "
        sql = sql & " to_char(to_date(f_spot, 'DD-MM-YYYY'), 'IW') CN_SEMANA, F_SPOT CN_DIA,"
        sql = sql & " E.descripcion PN_EJERCICIO, spt.tipo_planificacion TIPO_PLANI,"
        sql = sql & " 1 DS_SPOTS,"
        sql = sql & " SPT.ID_SOPORTE,"
        sql = sql & " T.ID_MATERIAL,"
        sql = sql & " T.ID_PRODUCTO"
        ''FROM
        sql = sql & " FROM SPOTS SPT, "
        sql = sql & " SPOTS_DETALLE SPTD,"
        ''sql = sql & " SOPORTES S,"
        sql = sql & " TEMAS T,"
        ''sql = sql & " MATERIALES M,"
        sql = sql & " EJERCICIOS E "
        ''WHERE
        sql = sql & " WHERE SPT.ID_CAMPANIA = " & Activo.IDCampaña & " AND SPT.ID_SPOT = SPTD.ID_SPOT AND"
        ''sql = sql & " SPT.ID_SOPORTE = S.ID_SOPORTE AND "
        sql = sql & " SPTD.ID_TEMA = T.ID_TEMA AND"
        sql = sql & " T.ID_CAMPANIA = SPT.ID_CAMPANIA AND "
        ''sql = sql & " t.ID_MATERIAL = M.ID_MATERIAL AND "
        sql = sql & " SPT.ID_EJERCICIO = E.ID_EJERCICIO AND "
        sql = sql & " SPT.ID_CAMPANIA = E.ID_CAMPANIA AND"
        ''ESTO ES UN COMENTARIO
        ''SE LE AGREGO EL PARAMETRO DE EJERCICIO PARA QUE TRAIGA SOLO LOS DATOS DEL EJERCICIO ACTUAL
        ''TENIAMOS PROBLEMAS CUANDO EN VARIAS 
        sql = sql & " E.ID_EJERCICIO = " & Activo.IDEjercicio
        dt = t.EjecutarSQL(sql).Tables(0)

        Dim oSop As New Soportes
        Dim oMaterial As New Materiales
        Dim oprod As New Productos
        For Each row As DataRow In dt.Rows
            oSop.Id_soporte = row.Item("ID_SOPORTE")
            oSop.Id_medio = Activo.IDMedio
            oMaterial.Id_material = row.Item("ID_MATERIAL")
            oMaterial.Id_material = row.Item("ID_MATERIAL")
            Dim s As String = oMaterial.obtenerDescripcion(Activo.IDCliente, 1, row.Item("ID_MATERIAL"))
            row.Item("RN_SOPORTE") = oSop.ObtenerDescripcionXid()
        Next

        frmCub.Nombre = "DistSpotsXCampania"
        frmCub.Titulo = "Distribución de Spots por Campaña"
        frmCub.Modo = 0
        frmCub.DataTableCub = dt
        frmCub.ShowDialog()
    End Sub
    Private Sub Materiales()
        Dim f As New frmMateriales

        f.ShowDialog()
    End Sub

    Private Sub Actualizar()

        If Not DirectCast(ABM, abmSistemas).ActualizarSpots() Then
            Mensajes.Mensaje("No se completó la actualización de spots")
        End If
    End Sub

    Private Sub Nuevo()
        ActivarBotonGuardar()

        ABM.Modificar = False

        ABM.DebeGuardar = False

        NoMensaje = False

        Select Case SeccionActiva
            Case SeccionActiva.Campaña
                Me.LimpiarGraficoGrilla()

                ABM.Modificar = False

                Me.treSistema.Nodes.Clear()

                Me.ABM_Sistema_Cancelar()

                Me.tabSistema.Enabled = False
                Me.tabTemas.Enabled = False
                Me.tabEjercicios.Enabled = False
                Me.tabAlternativa.Enabled = False

        End Select
        'Aguzzardi 20/05/2010 ----------------------------------------
        Activo.Alternativanueva = 3
        Activo.IDAlternativa = 0 'EN BOTON NUEVO BLANQUEO EL IDALTERNATIVA (AN 20-11-2015)
        '--------------------------------------------------------------------
        ABM.LimpiarControles()

    End Sub

    Private Sub Guardar()
        Try
            ABM.Guardar()
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)
        End Try

        Select Case SeccionActiva
            Case SeccionActiva.Campaña
                Me.TraerCampañas() 'actualiza el tree de campañas

            Case SeccionActiva.Sistemas
                Me.TraerSistemasEjercicios(Activo.IDCampaña)

                Me.tabEjercicios.Enabled = True
                Me.tabAlternativa.Enabled = True

            Case SeccionActiva.Ejercicios
                Me.TraerSistemasEjercicios(Activo.IDCampaña)

                Me.treSistema.Nodes.Item(Activo.NodoIndiceSeleccionado).Expand()

        End Select

        NoMensaje = True
    End Sub

    Private Sub Cancelar()
        ABM.Cancelar()

        ABM.DebeGuardar = False

        DesactivarBotonGuardar()

        Select Case SeccionActiva
            Case SeccionActiva.Campaña
                ABM.LimpiarControles()

                Me.tabSistema.Enabled = False
                Me.tabTemas.Enabled = False
                Me.tabEjercicios.Enabled = False

                Me.treCampaña_AfterSelect(Me, New System.Windows.Forms.TreeViewEventArgs(Me.treCampaña.SelectedNode))

                ActivarBotonGuardar()
        End Select
    End Sub

    Private Sub CambiarTemaPlanificacion()
        If Activo.IDCampaña > 0 Then
            Dim ActualizarTema As New frmActualizarTema
            ActualizarTema.Id_Campania = Activo.IDCampaña
            ActualizarTema.Campania = Activo.Campaña
            ActualizarTema.ShowDialog()
        End If
    End Sub

    Private Sub LimpiarGraficoGrilla()
        Me.iugSistema.DataSource = Nothing
        Me.chrGrafico.DataSource = Nothing
    End Sub

    Private Sub treCampaña_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treCampaña.AfterSelect
        NoMensaje = True
        tabEjercicios.Enabled = False
        If e.Node Is Nothing Then
            Exit Sub
        End If

        If e.Node.Index < 0 Or Guardando Then
            Exit Sub
        End If

        If Cargando Then
            Exit Sub
        End If

        'este select case tiene que estar antes que la carga del ABM
        'se usa para que cuando se cambia de tema (y se modifico algo), pregunte si desea
        'gaurdar
        'Select Case SeccionActiva
        '    Case SeccionActiva.Temas
        '        NoMensaje = False
        'End Select

        Activo.IDCampaña = e.Node.Tag

        'si alguien hace click en una campaña diferente desde otra solapa que no sea campaña
        'igualmente se cargan los datos de la campaña
        ManejoABM.RecuperarControl("campaña", Me.tabCampaña).Cargar()

        Activo.Campaña = e.Node.Text

        Select Case SeccionActiva
            Case SeccionActiva.Campaña
                ABM.Modificar = True

                'llena la grilla de resumen de sistemas y el grafico
                Me.CargarGraficoInversion(Me.tabGrafico.SelectedTab.Key)

            Case SeccionActiva.Sistemas
                ABM.Cancelar()
                Me.DesactivarBotonGuardar()

            Case SeccionActiva.Ejercicios
                ABM.Cancelar()

            Case SeccionActiva.Temas
                ABM.Cargar()

            Case SeccionActiva.Alternativa
                ABM.Cancelar()
                'LIMPIO CONTROLES DE ALTERNATIVA AL CAMBIAR LA CAMPAÑA (AN 20-11-2015)
                ABM.LimpiarControles()

        End Select

        'muestra sistemas y ejercicios de la campaña
        Me.TraerSistemasEjercicios(Activo.IDCampaña)

        Me.tabSistema.Enabled = True
        Me.tabTemas.Enabled = True

        'solo habilita ejercicios y alternativas si hay sistemas
        If Me.treSistema.Nodes.Count = 0 Then
            Me.tabEjercicios.Enabled = False
            Me.tabAlternativa.Enabled = False
        Else
            Me.tabEjercicios.Enabled = True
            Me.tabAlternativa.Enabled = True
        End If

        'si tiene sistemas, selecciona el primero 
        If Me.treSistema.Nodes.Count > 0 Then
            Me.treSistema.SelectedNode = Me.treSistema.Nodes(0)
        End If
    End Sub

    Private Sub TraerSistemasEjercicios(ByVal IDCampaña As Integer)
        'busca los sistemas y los ejercicios de la campaña y los carga en el tre
        Dim S As New Sistemas

        S.Id_campania = IDCampaña

        Listas.CargarTree(Me.treSistema, S.ObtenerSistemasEjercicio(), "id_sistema", "sistema", "id_ejercicio", "ejercicio", True, 4, 5)

        CambiarColorEstado(treSistema, IDCampaña)
    End Sub

    Private Sub CambiarColorEstado(ByVal Tree As TreeView, ByVal IdCampaña As Integer)
        Dim E As New Ejercicios
        Dim Ejer() As DataRow
        E.Id_campania = IdCampaña
        Dim Ejercicios As DataTable = E.ObtenerEjerciciosCampaña
        Dim Nodo As TreeNode
        Dim IdEjer As Integer
        Dim estado As EstadoEjercicio
        Try
            For Each Nodo In Tree.Nodes
                For Each Hijo As TreeNode In Nodo.Nodes
                    'If Not Hijo.Parent Is Nothing Then
                    IdEjer = CInt(Hijo.Tag)
                    Ejer = Ejercicios.Select("Id_ejercicio=" & IdEjer)

                    estado = Ejer(0)("Id_Ejercicio_est")

                    Select Case estado
                        Case EstadoEjercicio.Activo
                            Hijo.ForeColor = ColorEstado.ColorActivo
                        Case EstadoEjercicio.Final
                            Hijo.ForeColor = ColorEstado.ColorFinal
                        Case EstadoEjercicio.Compra
                            Hijo.ForeColor = ColorEstado.ColorACompra
                        Case Else
                            Hijo.ForeColor = Color.Black
                    End Select
                    ' End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function CrearDtGrafico(ByVal dt As DataTable) As DataTable
        Dim Tabla As New DataTable
        Dim f As DataRow
        Tabla.Columns.Add("Ejercicio", GetType(String))
        Tabla.Columns.Add("Bruto", GetType(Decimal))
        Tabla.Columns.Add("Neto", GetType(Decimal))

        For Each r As DataRow In dt.Rows
            f = Tabla.NewRow
            f("Ejercicio") = r("ejercicio")
            f("Bruto") = r("bruto")
            f("Neto") = r("neto")

            Tabla.Rows.Add(f)

        Next

        Return Tabla

    End Function

    Private Sub CargarGraficoInversion(ByVal Grafico As String)
        Dim C As New Campaña

        C.ID_Campania = Activo.IDCampaña

        'genera el grafico
        Dim Dt As DataTable

        'grafico de tipo soporte
        If Grafico = "tiposoporte" Then
            Dt = C.ObtenerInversionPorTipoSoporte

            Me.iugSistema.Visible = True
            Me.gntGantt.Visible = False
        End If

        'grafico de tipo soporte mensual
        If Grafico = "mensual" Then
            Dt = C.ObtenerInversionPorTipoSoporteMensual

            Me.iugSistema.Visible = False
            Me.gntGantt.Visible = True
        End If

        Me.chrGrafico.ChartType = Infragistics.UltraChart.[Shared].Styles.ChartType.PieChart

        If Not Dt Is Nothing AndAlso Dt.Rows.Count > 0 Then
            If Grafico = "tiposoporte" Then
                Me.chrGrafico.DataSource = CrearDtGrafico(Dt)
            Else
                Me.chrGrafico.DataSource = Dt
            End If

        Else
            Me.chrGrafico.DataSource = Nothing
        End If

        Me.iugSistema.DataSource = Dt 'Me.chrGrafico.DataSource

        If Not Me.iugSistema.DataSource Is Nothing Then
            Dim GF As New GrillaFormato
            GF.CambiarFormatoColumna(Me.iugSistema, 2, Formato.Moneda)
            GF.CambiarFormatoColumna(Me.iugSistema, 3, Formato.Moneda)
        End If

        Listas.AplicarFormato(Me.iugSistema)

        ArmarGantt(Activo.IDCampaña)
    End Sub

    Private Sub treSistema_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treSistema.AfterSelect
        Me.Cursor = Cursors.WaitCursor
        tabEjercicios.Enabled = False

        'AG CPunto +++++++++++++++++++
        Dim ObjSistemas As New Sistemas
        '+++++++++++++++++++++++++++

        If e.Node.Parent Is Nothing Then
            'SISTEMAS

            'carga los datos del sistema
            Try
                Activo.IDSistema = CInt(e.Node.Tag)

                If SeccionActiva = SeccionActiva.Sistemas Then
                    ' AG CP ++++++++++++++++++++++++++++++++++++++++++++++++++++
                    With ObjSistemas
                        TipoEjercicio = .ObtenerTipoEjercicio(Activo.IDCampaña, Activo.IDSistema)

                        If TipoEjercicio = Activo.TipoEjercicio.Estandar Then
                            Activo.TEjecicioActivo = Activo.TipoEjercicio.Estandar
                        Else
                            Activo.TEjecicioActivo = Activo.TipoEjercicio.CPunto
                        End If

                    End With
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    ABM.Cargar()
                    ActivarBotonGuardar()
                    'Else
                    '    treSistema_DoubleClick(sender, e)
                End If
            Catch ex As SistemaInexistenteExcepcion
            End Try

        Else
            'EJERCICIO
            Activo.IDEjercicio = CInt(e.Node.Tag)
            Activo.IDSistema = CInt(e.Node.Parent.Tag)

            ' AG CP ++++++++++++++++++++++++++++++++++++++++++++++++++++
            With ObjSistemas
                TipoEjercicio = .ObtenerTipoEjercicio(Activo.IDCampaña, Activo.IDSistema)

                If TipoEjercicio = Activo.TipoEjercicio.Estandar Then
                    Activo.TEjecicioActivo = Activo.TipoEjercicio.Estandar
                Else
                    Activo.TEjecicioActivo = Activo.TipoEjercicio.CPunto
                End If

            End With
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            'cargar el idmedio, idplaza y idtiposoporte (para llamar despues a filtrar soportes)
            CargarSistemaParaFiltro()
            tabEjercicios.Enabled = True
            Try
                ABM.Cargar()
            Catch ex As Exception
            End Try

            If Activo.IDEjercicio = 0 Then
                DesactivarBotonGuardar()
            Else
                ActivarBotonGuardar()
            End If

            'busca la descripcion del ejercicio
            Dim Ej As New Ejercicios

            Ej.Id_campania = Activo.IDCampaña
            Ej.Id_sistema = Activo.IDSistema
            Ej.Id_ejercicio = Activo.IDEjercicio

            Ej.BuscarPorID()

            Activo.Ejercicio = Ej.Descripcion
            'AG 05/06/2014 ==========================
            Activo.IDTipoEjercicio = Ej.IDTipoEjercicio
            '========================================
        End If

        'busca la descripcion del sistema
        Dim S As New Sistemas

        S.Id_campania = Activo.IDCampaña
        S.Id_sistema = Activo.IDSistema

        Try
            S.BuscarPorID()
            ''Jsperk - Se setea el Id_Medio en el activo para utilizarlo en diferentes partes de la aplicacion.
            Activo.IDMedio = S.Id_medio
        Catch ex As SistemaInexistenteExcepcion
        End Try

        Activo.FechaInicioSistema = S.F_inicio
        Activo.FechaFinSistema = S.F_fin
        Activo.IDMedio = S.Id_medio
        If S.Id_medio = 3 Or S.Id_medio = 4 Or S.Id_medio = 5 Then
            Activo.FechaInicioAudiencia = S.F_inicio
            Activo.FechaFinAudiencia = S.F_fin
        Else
            Activo.FechaInicioAudiencia = S.F_inicio_aud
            Activo.FechaFinAudiencia = S.F_fin_aud
        End If

        Activo.IDTipoSoporte = S.Id_tipo_soporte
        Activo.Sistema = S.Descripcion
        Activo.IDPlaza = S.ID_Plaza
        '***
        If SeccionActiva <> SeccionActiva.Temas Then
            ABM.Modificar = True
        Else
            ABM.Modificar = False
            ABM.Cargar()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CargarSistemaParaFiltro()
        Dim S As New Sistemas

        S.Id_campania = Activo.IDCampaña
        S.Id_sistema = Activo.IDSistema

        S.BuscarPorID()

        Activo.IDMedio = S.Id_medio
        Activo.IDTipoSoporte = S.Id_tipo_soporte
        Activo.IDPlaza = S.ID_Plaza
    End Sub

    Private Sub UltraTabControl2_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabGrafico.SelectedTabChanged
        'AG DBCompania
        If Activo.DBConexionTEC10GP = True Then
            If Cargando Then
                Exit Sub
            End If
            Me.CargarGraficoInversion(e.Tab.Key)
        Else
        End If

        'If Cargando Then
        '    Exit Sub
        'End If

        'Me.CargarGraficoInversion(e.Tab.Key)
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Dim OMsl As New Maestros

        Select Case e.Tool.Key
            Case "fechas"
                Dim f As New frmABMAudienciaFechas
                f.ShowDialog()

            Case "cambiarcliente"
                Dim F As New frmElegirCliente

                F.ShowDialog()

                If F.Cancelar Then
                    Exit Sub
                End If

                ABM.DebeGuardar = False

                TraerCampañas()
                TraerSistemasEjercicios(0)

                Activo.DTMaterialesCache = OMsl.TraerMaterialesCliente(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente)

                Activo.IDCampaña = 0
                Activo.IDSistema = 0
                Activo.IDEjercicio = 0

                SeccionActiva = SeccionActiva.Campaña

                Me.ABM_Sistema_Cancelar()
                Me.ABM_Ejercicio_Cancelar()
                Me.ABM_Campaña_Cliente = Activo.Cliente

                Me.tabPrincipal.SelectedTab = Me.tabCampaña.Tab

                ABM.Cancelar()

            Case "ExploradorCampañas"
                Me.UltraDockManager1.ControlPanes("campaña").Show()

            Case "ExploradorSistemas"
                Me.UltraDockManager1.ControlPanes("sistemas").Show()

            Case "Salir"
                Application.Exit()

            Case "AudienciaTVA"
                '--Dim atva As New frmCargarAudienciaTVA
                Dim atva As New CargarAudienciaTVA_WM


                atva.ShowDialog()
            Case "AudienciaTVC"
                Dim atvc As New frmCargarAudienciaTVC

                atvc.ShowDialog()
            Case "AudienciaTVI"
                Dim atvi As New frmCargarAudienciaTVI

                atvi.ShowDialog()
            Case "Calcular Audiencia Radio"
                Call CalcularAudienciaRadio()
            Case "ProgramasMonitor"
                Dim oPM As New frmCargaProgMonitor

                oPM.ShowDialog()
            Case "AsociarProgramas"
                Dim oRP As New frmRelacionarProgramas

                oRP.ShowDialog()
            Case "CargarTarifas"

                Dim F As New frmElegirTarifa

                F.ShowDialog()

                If F.Cancelar Then
                    Exit Sub
                Else

                    'AG 23/10/2013 DIGITA ================================================
                    If F.MedioSeleccionado = Activo.Medios.Internet Then
                        Dim ctint As New frmAltaTarifasInternet 'frmCargaTarifaInternet
                        Dim s As New Soportes
                        s.Id_soporte = F.idSoporte
                        s.Id_medio = F.MedioSeleccionado
                        s.BuscarPorID_Soporte()
                        With ctint
                            .IdCliente = F.idCliente
                            .IdSoporte = F.idSoporte
                            .IdMedio = F.idmedio
                            .IdTipoSoporte = 0
                            .DescCliente = F.DescripcionCliente
                            .DescSoporte = F.DescripcionSoporte
                            .DescTipoSoporte = ""
                            .DescMedio = F.DescripcionMedioSeleccionado
                            .FVigencia = F.dtpFecha.DateTime.Date
                            .SoloVigentes = F.SoloVigentes
                            .ShowDialog()
                        End With
                    Else
                        Dim ct As New frmCargaTarifa
                        Dim s As New Soportes
                        s.Id_soporte = F.idSoporte
                        s.Id_medio = F.MedioSeleccionado
                        s.BuscarPorID_Soporte()
                        ct.id_cliente = F.idCliente
                        ct.id_soporte = F.idSoporte
                        ct.desccliente = F.DescripcionCliente
                        ct.descsoporte = F.DescripcionSoporte
                        ct.tipoSoporte = IIf(s.Id_tipo_soporte = 1, 0, 1)
                        ' linea agregada gwinkler
                        ct.solovigentes = F.SoloVigentes
                        ' fin agrgado
                        ct.fvigencia = F.dtpFecha.DateTime.Date
                        ct.id_medio = F.idmedio
                        ct.ShowDialog()
                    End If
                End If
                F.Close()
                '==========================================================================
                ' agregado gwinkler
            Case "Reporte tarifas genéricas"

                Dim fs As New frmElegirSoporteFecha

                fs.ShowDialog()

                If fs.Cancelar Then
                    fs.Close()
                Else

                    Dim F As New frmFormulaOne


                    F.ReporteTVAbierta(fs.dtpFecha.DateTime.Date, fs.idSoporte, fs.TxtDescSoporte.Text)

                    F.ShowDialog()


                End If
                'fin agregado
                'agregado cfanego
            Case "Reporte Tarifa Promedio"

                Dim fs As New frmElegirFechaVigencia

                fs.ShowDialog()

                If fs.Cancelar Then
                    fs.Close()
                Else

                    Dim F As New frmFormulaOne

                    F.ReporteTarifaPromedio(fs.DtpFechaDesde.DateTime.Date, fs.dtpFechaHasta.DateTime.Date)
                    'F.ReporteTVAbierta(fs.dtpFecha.DateTime.Date, fs.idSoporte, fs.TxtDescSoporte.Text)

                    F.ShowDialog()


                End If
                'fin agregado
            Case "Copiar Tarifas"
                Dim f As New frmCopiarTarifa

                f.ShowDialog()

                ' fin agregado
            Case "franjas"
                Dim F As New frmFranjas

                F.ShowDialog()

            Case "enviarcompras"

                If treCampaña.SelectedNode Is Nothing Then
                    Exit Sub
                End If

                Dim f As New frmEnviarCompras
                f.Id_Campania = Activo.IDCampaña
                f.ShowDialog()
                'If f.SeEnvio Then
                '    CambiarEstado(Activo.IDCampaña, Activo.IDSistema, treSistema.SelectedNode, EstadoEjercicio.Compra)
                'End If
            Case "listarconvenios"
                Dim f As New frmConsultaConvenio
                f.ShowDialog()
                'AG 08/11/2010 ----------------------------------
            Case "DuplicarConvenios"
                Dim frmDConvenio As New frmDuplicarConvenios
                frmDConvenio.ShowDialog()
                '--------------------------------------------------------
            Case "Reporte_Convenios"
                Dim FrmReporteConvenio As New FrmConveniosReporte
                FrmReporteConvenio.ShowDialog()

            Case "ReporteConveniosEstados" 'AG 02/06/2015 
                Dim FrmConvenioEstados As New ReporteConveniosWeb
                FrmConvenioEstados.ShowDialog()

            Case "ConvenioEspecial" 'AG 10/07/2015 
                Dim FrmConvenioEspecial As New frmConvenioEspecial
                FrmConvenioEspecial.ShowDialog()

            Case "Convenios Masivo" 'AG 31/03/2015
                Dim FrmReporteConvenioDuplicar As New frmDuplicarConveniosMasivo
                FrmReporteConvenioDuplicar.ShowDialog()
            Case "DuplicarCampaña"
                DuplicarCampania()
            Case "DuplicarSistema"
                DuplicarSistema()
            Case "DuplicarEjercicio"
                DuplicarEjercicio()
            Case "BorrarCampaña"
                BorrarCampania()
            Case "BorrarSistema"
                BorrarSistema()
            Case "BorrarEjercicio"
                BorrarEjercicio()
            Case "ABMConveniosTarifaPlana"
                Call MantenimientoConvenio(frmMantenimientoConvenio.TipoConvenio.Tarifa)
            Case "ABMConveniosDescuento"
                Call MantenimientoConvenio(frmMantenimientoConvenio.TipoConvenio.Descuento)
            Case "ABMConveniosCPR"
                Call MantenimientoConvenio(frmMantenimientoConvenio.TipoConvenio.CPR)
            Case "soporte"
                ActualizarCacheSoportes()
            Case "CargarpadronAGIP"
                Dim f As New frmCargarPadronAGIP
                f.ShowDialog()
            Case "ReporteTarifasTv" 'AG  12/06/2014
                Dim frmTariaTv As New frmReporteTarifas
                frmTariaTv.ShowDialog()
            Case "AdministrarPerfiles" 'AG  12/06/2014
                Dim frmAdmin As New frmAdminPerfil
                frmAdmin.ShowDialog()
        End Select
    End Sub

    Private Sub ActualizarCacheSoportes()
        'Dim OMsl As New Maestros
        'Activo.DTSoportesCache = OMsl.ObtenerSoportes(MSL.Constantes.COD_PAIS_ARGENTINA)


        Dim OSop As New MPG.DBL.Soportes

        OSop.ActualizarSoportes() 'GW 08/09/2014

        Activo.DTSoportesCache = OSop.ObtenerSoportesMMSVistaMaterializada(MSL.Constantes.COD_PAIS_ARGENTINA)

        ' agregado GW 08/09/2014 luego de actualizar el cache filtra nuevamente el cliente danone para mostrar solo sus soportes
        'Dim query As New StringBuilder
        'Dim dt As DataTable
        'Dim dtAux As New DataTable
        'Dim filtro As String

        'query.Append("SELECT * ")
        'query.Append("FROM cliente_danone_ar ")
        'query.AppendFormat("WHERE cod_cliente = {0} ", Activo.IDCliente)
        'query.AppendFormat("AND cod_compania = {0} ", Activo.IDCompaniaMMS)
        'dt = Sqlhelper.ExecuteQuery(query.ToString())
        'If dt.Rows.Count > 0 Then
        '    filtro = "SOPORTE_DANONE = 1"
        '    dtAux = Activo.DTSoportesCache.Clone()
        '    For Each r As DataRow In Activo.DTSoportesCache.Select(filtro)
        '        dtAux.Rows.Add(r.ItemArray)
        '    Next
        '    Activo.DTSoportesCache = dtAux
        'End If
        '===================================================================================

    End Sub

    Private Sub MantenimientoConvenio(ByVal pTipoConvenioApertura As frmMantenimientoConvenio.TipoConvenio)
        Dim MantenimientoConvenio As New frmMantenimientoConvenio
        MantenimientoConvenio.TipoApertura = pTipoConvenioApertura
        MantenimientoConvenio.ShowDialog()
    End Sub

    Private Sub GuardarCambios()
        'cuando se sale de una solapa, pregunta si desea guardar los cambios
        'el flag NoMensaje se usa para cuando se activa otro evento (como el AfterSelect del treCampaña),
        'y no se quiere mostrar el mesanje
        If ABM.DebeGuardar And Not NoMensaje Then
            Dim Res As DialogResult = Mensajes.Mensaje("Si no Guarda se Perderán los Cambios Realizados. ¿Desea Guardar?", TipoMensaje.SiNoCancelar, MessageBoxDefaultButton.Button1)

            Select Case Res
                Case DialogResult.Yes
                    ABM.Guardar()
                    Exit Sub
                Case DialogResult.No
                    Exit Select
                Case DialogResult.Cancel

                    Select Case Me.SeccionActiva
                        Case SeccionActiva.Alternativa
                            Me.tabAlternativa.Select()
                        Case SeccionActiva.Campaña
                            Me.tabCampaña.Select()
                        Case SeccionActiva.Ejercicios
                            Me.tabEjercicios.Select()
                        Case SeccionActiva.Sistemas
                            Me.tabSistema.Select()
                        Case SeccionActiva.Temas
                            Me.tabTemas.Select()
                    End Select

                    Exit Sub
            End Select
        End If

        If SeccionActiva <> SeccionActiva.Campaña And SeccionActiva <> SeccionActiva.Ejercicios Then
            ABM.Cancelar()
        End If
    End Sub

    Private Sub tabTemas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabTemas.Leave
        'saca el boton cancelar
        Me.tlbAcciones.Buttons(2).Visible = True

        GuardarCambios()
    End Sub

    Private Sub tabSistema_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabSistema.Leave
        GuardarCambios()
    End Sub

    Private Sub tabCampaña_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabCampaña.Leave
        GuardarCambios()

        Me.TraerCampañas()
    End Sub

    Private Sub tabAlternativa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabAlternativa.Leave
        GuardarCambios()
    End Sub

    Private Sub treSistema_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles treSistema.LostFocus
        If Me.treSistema.SelectedNode Is Nothing Then
            Exit Sub
        End If

        'If Me.treSistema.SelectedNode.Nodes.Count > 0 Then
        '    Activo.NodoIndiceSeleccionado = Me.treSistema.SelectedNode.Index
        'Else
        If Not Me.treSistema.SelectedNode.Parent Is Nothing Then
            Activo.NodoIndiceSeleccionado = Me.treSistema.SelectedNode.Parent.Index
        End If
        'End If
    End Sub

    Private Sub treSistema_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treSistema.DoubleClick
        If Me.treSistema.SelectedNode.Nodes.Count > 0 Then
            'sistemas
            Me.tabPrincipal.SelectedTab = Me.tabSistema.Tab

            ABM.Cargar()

            ABM.Modificar = True
        Else
            'ejercicios
            Me.tabPrincipal.SelectedTab = Me.tabEjercicios.Tab

            'cargar el idmedio, idplaza y idtiposoporte (para llamar despues a filtrar soportes)
            CargarSistemaParaFiltro()

            ABM.Cargar()

            ABM.Modificar = True
        End If
    End Sub

    Private Sub treCampaña_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treCampaña.DoubleClick
        Me.tabPrincipal.SelectedTab = Me.tabCampaña.Tab

        ABM.Cargar()
    End Sub

    Private Sub ActivarBotonGuardar()
        Me.tlbAcciones.Buttons(1).Visible = True
    End Sub

    Private Sub DesactivarBotonGuardar()
        Me.tlbAcciones.Buttons(1).Visible = False
    End Sub

    Private Sub tabEjercicios_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabEjercicios.Leave
        GuardarCambios()
    End Sub

    Private Sub treSistema_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treSistema.MouseDown
        If MouseButtons = MouseButtons.Right Then
            Dim node As TreeNode = treSistema.GetNodeAt(e.X, e.Y)
            treSistema.SelectedNode = node

        End If
    End Sub

#Region "Gantt"

    Private Sub ArmarGantt(ByVal IdCampania As Int32)
        Dim C As New Campaña, S As New Sistemas
        Dim i As Int32, Cantidad As Int32
        Dim DtSistemas As DataTable
        Dim FechaInicio As Date, FechaFin As Date
        Dim Semanas As Int32
        If IdCampania = 0 Then
            Exit Sub
        End If

        C.ID_Campania = IdCampania
        C.BuscarPorID()

        S.Id_campania = IdCampania
        DtSistemas = S.ObtenerSistemas

        Dim Dt As DataTable = S.ObtenerSistemas

        If Dt Is Nothing OrElse Dt.Rows.Count = 0 Then
            chrGraficoMensual.DataSource = Nothing
        Else
            chrGraficoMensual.DataSource = Dt
        End If

        Cantidad = DtSistemas.Rows.Count

        Semanas = DateDiff(DateInterval.WeekOfYear, C.F_inicio, C.F_fin)

        With gntGantt
            .CaptionNumber = 3
            .Set_CaptionWidth(1, 3000)
            .Set_CaptionWidth(2, 1200)
            .Set_CaptionWidth(3, 1200)

            .Set_CaptionName(1, "Descripción")
            .Set_CaptionName(2, "Fecha Inicio")
            .Set_CaptionName(3, "Fecha Fin")
            .WorksheetNumber = Semanas
            .WorksheetWidth = 1600

            .WorksheetGroupNumber = Semanas
            .Set_WorksheetGroupLabel(1, "Semanas")

            For i = 1 To Semanas
                .Set_WorksheetLabel(i, i)
            Next

            .Refresh()

        End With

        MostrarGantt(C.Descripcion, DtSistemas, Semanas, C.F_inicio, C.F_fin)
    End Sub

    Private Sub MostrarGantt(ByVal Campania As String, ByVal DtSistemas As DataTable, ByVal CantSemanas As Int32, ByVal FechaInicio As Date, ByVal FechaFin As Date)
        Dim i As Int32, Dato() As DatosGantt = CalcularPosiciones(DtSistemas, CantSemanas, FechaInicio)
        Dim CantSistemas As Int32 = DtSistemas.Rows.Count

        With gntGantt
            .DataNumber = DtSistemas.Rows.Count + 1

            .Set_DataCaptionLabel(1, 1, Campania)
            .Set_DataCaptionLabel(1, 2, FechaInicio)
            .Set_DataCaptionLabel(1, 3, FechaFin)

            .Set_DataWorksheet(i + 1, 0, CantSemanas)

            For i = 1 To CantSistemas
                .Set_DataCaptionLabel(i + 1, 1, DtSistemas.Rows(i - 1).Item(3))
                .Set_DataCaptionLabel(i + 1, 2, DtSistemas.Rows(i - 1).Item(4))
                .Set_DataCaptionLabel(i + 1, 3, DtSistemas.Rows(i - 1).Item(5))

                .Set_DataWorksheet(i + 1, Dato(i - 1).Inicio, Dato(i - 1).Fin)

            Next
            .Refresh()
        End With
    End Sub

    Private Function CalcularPosiciones(ByVal DtSistemas As DataTable, ByVal CantSemanas As Int32, ByVal FechaInicio As Date) As DatosGantt()
        Dim i As Int32
        Dim Dr As DataRow
        Dim Dato() As DatosGantt

        ReDim Dato(DtSistemas.Rows.Count)

        For Each Dr In DtSistemas.Rows
            Dato(i).Inicio = DateDiff(DateInterval.WeekOfYear, FechaInicio, Dr("f_inicio"))
            Dato(i).Fin = DateDiff(DateInterval.WeekOfYear, FechaInicio, Dr("f_inicio")) + DateDiff(DateInterval.WeekOfYear, Dr("f_inicio"), Dr("f_fin"))

            i = i + 1
        Next

        Return Dato
    End Function

    Private Structure DatosGantt
        Dim Inicio As Single
        Dim Fin As Single
    End Structure

#End Region

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If treSistema.SelectedNode Is Nothing OrElse treSistema.SelectedNode.Parent Is Nothing Then
            Mensajes.Mensaje("Debe Seleccionar un Ejercicio", TipoMensaje.Informacion)
            Exit Sub
        End If
        Dim G As New Grilla
        Dim Ejer As EjercicioActivo
        Dim Temas As New Temas

        'AG CP +++++++++++++++++++++++++++++++++++++++++
        Dim TEjercicio As Integer
        If Activo.TEjecicioActivo = Activo.TipoEjercicio.Estandar Then
            TEjercicio = Activo.TipoEjercicio.Estandar
        Else
            TEjercicio = Activo.TipoEjercicio.CPunto
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++

        Temas.Id_campania = Activo.IDCampaña

        'si no tiene temas, no ingresa a la grilla
        Ejer.IDCampaña = Activo.IDCampaña
        Ejer.IDSistema = Activo.IDSistema
        Ejer.IDEjercicio = Activo.IDEjercicio

        If G.ComprobarEjercicioActivo(Ejer) Then
            Mensajes.Mensaje("Ya Existe Un Ejercicio Activo", TipoMensaje.Informacion)
            Exit Sub
        End If

        Select Case Activo.IDMedio 'Produccion_AG
            Case 1, 6
                If Temas.TraerTodos.Rows.Count = 0 Then
                    Mensajes.Mensaje("No se Puede Ingresar a la Hoja de Planificación ya que la Campaña No Tiene Temas", TipoMensaje.Informacion)
                    Me.Cursor = Cursors.Default
                    'Activo.EjerciciosCargados.Remove(Ejer)
                    Exit Sub
                End If
        End Select

        'AG CP ++++++++++++++++++++++++++++++++++++++++++
        Select Case Activo.IDMedio 'Produccion_AG
            Case 1, 6
                Select Case Activo.IDTipoSoporte
                    Case 1
                        G.Cargar(True, TipoAudiencia.Abierta, TEjercicio)
                    Case 2
                        G.Cargar(True, TipoAudiencia.Intetior, TEjercicio)
                    Case 3
                        G.Cargar(True, TipoAudiencia.Cable, TEjercicio)
                    Case 4
                        G.Cargar(True, TipoAudiencia.Satelital, TEjercicio)
                    Case 5 'PNT
                        G.Cargar(True, TipoAudiencia.Cable, TEjercicio)
                End Select
            Case 3, 4, 5, 7 'AG Produccion ++++++++++++++++++
                G.Cargar(Activo.IDMedio)
            Case 2
                'AG 22/10/2013 DIGITAL =======================
                G.CargarInternet(Activo.IDMedio)
                '=============================================
        End Select
        '++++++++++++++++++++++++++++++++++++++++++++++++

        ' Select Case Activo.IDTipoSoporte
        '     Case 1
        ' G.Cargar(TipoAudiencia.Abierta)
        '     Case 2
        ' G.Cargar(TipoAudiencia.Intetior)
        '     Case 3
        ' G.Cargar(TipoAudiencia.Cable)
        '     Case 4
        ' G.Cargar(TipoAudiencia.Satelital)
        ' End Select
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        'CAMBIO A ESTADO de ACTIVO
        If treSistema.SelectedNode Is Nothing Then
            Exit Sub
        End If
        If treSistema.SelectedNode.Parent Is Nothing Then
            Exit Sub
        End If
        CambiarEstado(Activo.IDCampaña, Activo.IDSistema, treSistema.SelectedNode, EstadoEjercicio.Activo)
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        'CAMBIO A ESTADO de FINAL
        If treSistema.SelectedNode Is Nothing Then
            Exit Sub
        End If
        If treSistema.SelectedNode.Parent Is Nothing Then
            Exit Sub
        End If
        CambiarEstado(Activo.IDCampaña, Activo.IDSistema, treSistema.SelectedNode, EstadoEjercicio.Final)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If treSistema.SelectedNode Is Nothing OrElse treSistema.SelectedNode.Parent Is Nothing Then
            Mensajes.Mensaje("Debe Seleccionar un Ejercicio", TipoMensaje.Informacion)
            Exit Sub
        End If
        If Activo.IDMedio <> MedioTV Then
            Mensajes.Mensaje("El ejercicio seleccionado no es de medio tv.", TipoMensaje.Informacion)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim F As New frmFormulaOne
        'F.Descripcion = "Original"
        F.CargarReporteCalendarioDiarioLog()

        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            F.Close()

            Exit Sub
        End If

        F.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Call DiferenciasPlanificacion("Cadena,Programa,F_Accion")
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Call DiferenciasPlanificacion("F_Accion,Cadena,Programa")
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Dim SD As New Spots_detalle
        Dim AvisosConf As DataTable
        Dim NivelEjercicio As Boolean = False
        Dim IdEjercicio As Integer = -1

        If treSistema.SelectedNode Is Nothing Then
            Exit Sub
        End If

        If Not treSistema.SelectedNode.Parent Is Nothing Then
            NivelEjercicio = True
            IdEjercicio = Activo.IDEjercicio
        End If

        AvisosConf = SD.ObtenerAvisosConfirmados(Activo.IDCampaña, Activo.IDSistema, IdEjercicio, 1, 1)

        If Not AvisosConf Is Nothing AndAlso AvisosConf.Rows.Count > 0 Then
            Dim Avisos As New AvisosConfirmados

            For Each drAvisosConf As DataRow In AvisosConf.Rows
                Avisos.Avisos.ImportRow(drAvisosConf)
            Next

            Dim Reporte As New frmAvisosConfirmados
            Reporte.NivelEjercicio = NivelEjercicio
            Reporte.DataSource = Avisos
            Reporte.ShowDialog()
        Else
            Mensajes.Mensaje("No existen Avisos Informados.", TipoMensaje.Informacion)
        End If
    End Sub

    Private Sub CambiarEstado(ByVal IdCampaña As Integer, ByVal idSistema As Integer, ByVal Nodo As TreeNode, ByVal Como As EstadoEjercicio)

        Dim E As New Ejercicios
        Dim Ejer() As DataRow
        Dim EjerC() As DataRow
        E.Id_campania = IdCampaña
        E.Id_sistema = idSistema
        Dim Ejercicios As DataTable = E.ObtenerEjerciciosSistema
        Dim IdEjer As Integer
        Dim estado As EstadoEjercicio
        Dim idEjerDt As Integer
        Dim SpotPr As New Spots_pr
        Dim spotsVp As New Spots_vp
        Dim SpotsInt As New Spots_int
        Dim CantidadSp As Integer
        Try
            Select Case Como
                Case EstadoEjercicio.Activo
                    IdEjer = CInt(Nodo.Tag)
                    Ejer = Ejercicios.Select("Id_ejercicio=" & IdEjer)

                    If Not Ejer(0)("id_ejercicio_est") = estado.Final Then
                        Mensajes.Mensaje("Solo el  ejercicio Final puede Volve a Activo")
                        Exit Sub
                    End If
                    Nodo.ForeColor = ColorEstado.ColorActivo
                    E.Id_ejercicio = IdEjer
                    E.Id_ejercicio_est = Como
                    E.Descripcion = Activo.Ejercicio
                    E.F_modi = Date.Today
                    E.U_modi = Activo.Login
                    E.Modificar()
                    'AG 05/06/2014 ============================================
                    E.IDTipoEjercicio = Activo.IDTipoEjercicio
                    '==========================================================
                Case EstadoEjercicio.Final
                    IdEjer = CInt(Nodo.Tag)
                    Ejer = Ejercicios.Select("Id_ejercicio_est=" & estado.Final)
                    EjerC = Ejercicios.Select("Id_ejercicio_est=" & estado.Compra)
                    If Ejer.Length > 0 Then
                        Mensajes.Mensaje("Ya Existe un Ejercicio Final")
                        Exit Sub
                    End If
                    If EjerC.Length > 0 Then
                        Mensajes.Mensaje("Hay un Ejercicio en estado de Compra en el Sistema")
                        Exit Sub
                    End If
                    Dim S As New Spots
                    Dim Spots As DataTable
                    S.Id_campania = Activo.IDCampaña
                    S.Id_sistema = Activo.IDSistema
                    S.Id_ejercicio = Activo.IDEjercicio

                    'If Activo.IDMedio = 1 Or Activo.IDMedio = 6 Then
                    '    Spots = S.ObtenerSpots
                    '    If Spots Is Nothing OrElse Spots.Rows.Count <= 0 Then
                    '        CantidadSp = 0
                    '    Else
                    '        CantidadSp = Spots.Rows.Count
                    '    End If
                    'Else
                    '    CantidadSp = SpotPr.ObtenerCantidadSpots(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
                    'End If
                    Select Case Activo.IDMedio
                        Case 1, 6
                            Spots = S.ObtenerSpots
                            If Spots Is Nothing OrElse Spots.Rows.Count <= 0 Then
                                CantidadSp = 0
                            Else
                                CantidadSp = Spots.Rows.Count
                            End If
                        Case 4, 5
                            CantidadSp = SpotPr.ObtenerCantidadSpots(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
                        Case 3
                            CantidadSp = spotsVp.ObtenerCantidadSpots(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
                        Case 7 'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            CantidadSp = spotsVp.ObtenerCantidadSpots(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
                        Case 2 'AG Internet
                            CantidadSp = SpotsInt.ObtenerCantidadSpots(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
                    End Select

                    If CantidadSp = 0 Then
                        Mensajes.Mensaje("El Ejercicio no tiene Planificación.")
                        Exit Sub
                    End If

                    Nodo.ForeColor = ColorEstado.ColorFinal
                    E.Id_ejercicio = IdEjer
                    E.Id_ejercicio_est = Como
                    E.Descripcion = Activo.Ejercicio
                    E.F_modi = Date.Today
                    E.U_modi = Activo.Login
                    'AG 05/06/2014 ============================================
                    E.IDTipoEjercicio = Activo.IDTipoEjercicio
                    '==========================================================
                    E.Modificar()

                Case EstadoEjercicio.Compra
                    'IdEjer = CInt(Nodo.Tag)
                    'Ejer = Ejercicios.Select("Id_ejercicio=" & IdEjer)

                    'If Not Ejer(0)("id_ejercicio_est") = estado.Final Then
                    '    Mensajes.Mensaje("No es un Ejercicio Final")
                    '    Exit Sub
                    'End If
                    'Nodo.ForeColor = ColorEstado.ColorACompra
                    'E.Id_ejercicio = IdEjer
                    'E.Id_ejercicio_est = Como
                    'E.Descripcion = Activo.Ejercicio
                    'E.Modificar()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ActualizarFranjasEnSistema()
        If SeccionActiva = SeccionActiva.Sistemas Then
            DirectCast(ABM, abmSistemas).CargarFranjas()
        End If
    End Sub

    Private Sub CalcularAudienciaRadio()
        Dim Audiencia As New frmAudienciaRadio
        Audiencia.ShowDialog()
    End Sub

#Region "Borrado/duplicacion de campanias, sistemas y ejercicios"

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''' Borrado/duplicacion de campanias, sistemas y ejercicios ''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If treSistema.SelectedNode Is Nothing Then
            Exit Sub
        End If
        DuplicarSistemaEjercicio()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        DuplicarCampania()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        BorrarCampania()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If treSistema.SelectedNode Is Nothing Then
            Exit Sub
        End If
        BorrarSistemaEjercicio()
    End Sub

    Private Sub DuplicarSistema()
        If Not treSistema.SelectedNode Is Nothing Then
            If treSistema.SelectedNode.GetNodeCount(True) > 0 Then ' si no es un ejercico
                DuplicarSistemaEjercicio()
            Else
                Mensajes.Mensaje("Debe seleccionar el sistema que desea duplicar")
            End If
        End If
    End Sub

    Private Sub DuplicarEjercicio()
        If Not treSistema.SelectedNode Is Nothing Then
            If treSistema.SelectedNode.GetNodeCount(True) = 0 Then ' si es un ejercico
                DuplicarSistemaEjercicio()
            Else
                Mensajes.Mensaje("Debe seleccionar el ejercicio que desea duplicar")
            End If
        End If
    End Sub

    Private Sub BorrarSistema()
        If Not treSistema.SelectedNode Is Nothing Then
            If treSistema.SelectedNode.GetNodeCount(True) > 0 Then ' si no es un ejercico
                BorrarSistemaEjercicio()
            Else
                Mensajes.Mensaje("Debe seleccionar el sistema que desea eliminar")
            End If
        End If
    End Sub

    Private Sub BorrarEjercicio()
        If Not treSistema.SelectedNode Is Nothing Then
            If treSistema.SelectedNode.GetNodeCount(True) = 0 Then ' si es un ejercico
                BorrarSistemaEjercicio()
            Else
                Mensajes.Mensaje("Debe seleccionar el ejercicio que desea eliminar")
            End If
        End If
    End Sub

    Private Sub DuplicarCampania()
        ' Duplicacion de campanias
        Dim camp As New Campaña
        Dim ej As New Ejercicios
        Dim Si As New Sistemas
        Dim te As New Temas

        Dim dt As DataTable
        Dim dtSistemas As DataTable
        Dim New_Id_Sistema As Long
        Dim New_Id_Campania As Long

        If Activo.IDCampaña = 0 Then
            Exit Sub
        End If

        Try
            'ej.IniciarTransaccion()
            camp.ID_Campania = Activo.IDCampaña
            New_Id_Campania = camp.Duplicar
            dtSistemas = camp.ObtenerSistemas.Tables(0)
            For Each rc As DataRow In dtSistemas.Rows
                Si.Id_campania = rc("id_campania")
                Si.Id_sistema = rc("id_sistema")
                New_Id_Sistema = Si.Duplicar(New_Id_Campania, True)
                ej.Id_campania = rc("id_campania")
                ej.Id_sistema = rc("id_sistema")
                dt = ej.ObtenerEjerciciosSistema
                For Each row As DataRow In dt.Rows
                    ej.Id_ejercicio = row("id_ejercicio")
                    ej.Duplicar(New_Id_Campania, New_Id_Sistema, Activo.Login, True)
                Next
            Next

            te.Id_campania = Activo.IDCampaña
            dt = te.ObtenerTemasPorCampaña
            For Each row As DataRow In dt.Rows
                te.Id_campania = Activo.IDCampaña
                te.Id_tema = row("id_tema")
                te.BuscarPorID()
                te.Id_campania = New_Id_Campania
                te.Agregar()
            Next

            TraerCampañas()
            'ej.TerminarTransaccion()
        Catch ex As Exception
            'ej.AbortarTransaccion()
            Mensajes.Mensaje(ex.Message)
        End Try
    End Sub

    Private Sub DuplicarSistemaEjercicio()
        ' duplicacion de ejercicios y de sistemas
        Dim ej As New Ejercicios
        Dim Si As New Sistemas
        Dim dt As DataTable
        Dim New_Id_Sistema As Long

        Try
            'ej.IniciarTransaccion()
            ej.Id_campania = Activo.IDCampaña
            ej.Id_sistema = Activo.IDSistema
            If treSistema.SelectedNode.GetNodeCount(True) = 0 Then ' no tiene hijos, es un ejercicio
                ej.Id_ejercicio = Activo.IDEjercicio
                ej.Duplicar(Activo.IDCampaña, Activo.IDSistema, Activo.Login, False)
            Else
                Si.Id_campania = Activo.IDCampaña
                Si.Id_sistema = Activo.IDSistema
                New_Id_Sistema = Si.Duplicar(Activo.IDCampaña, False)
                dt = ej.ObtenerEjerciciosSistema
                For Each row As DataRow In dt.Rows
                    ej.Id_ejercicio = row("id_ejercicio")
                    ej.Duplicar(Activo.IDCampaña, New_Id_Sistema, Activo.Login, True)
                Next
            End If
            'ej.TerminarTransaccion()
            Me.TraerSistemasEjercicios(Activo.IDCampaña)

        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)
            'ej.AbortarTransaccion()
        End Try
    End Sub

    Private Sub BorrarCampania()
        ' Borra la campania entera

        Dim camp As New Campaña
        Dim ej As New Ejercicios
        Dim Si As New Sistemas
        Dim te As New Temas
        Dim dt As DataTable
        Dim dtSistemas As DataTable
        Dim New_Id_Sistema As Long
        Dim New_Id_Campania As Long
        Dim cant As Integer

        Try
            cant = 0
            camp.ID_Campania = Activo.IDCampaña
            dtSistemas = camp.ObtenerSistemas.Tables(0)
            For Each rc As DataRow In dtSistemas.Rows
                ej.Id_campania = rc("id_campania")
                ej.Id_sistema = rc("id_sistema")
                dt = ej.ObtenerEjerciciosSistema
                For Each row As DataRow In dt.Rows
                    ej.Id_ejercicio = row("id_ejercicio")
                    ej.BuscarPorID()
                    cant = cant + ej.HayEnviadosaCompras
                Next
            Next

            camp.ID_Campania = Activo.IDCampaña
            camp.BuscarPorID()
            If Mensajes.Mensaje("Desea eliminar la campania " & camp.Descripcion, TipoMensaje.SiNo) = DialogResult.Yes Then
                If cant = 0 Then
                    'camp.IniciarTransaccion()
                    dtSistemas = camp.ObtenerSistemas.Tables(0)
                    For Each rc As DataRow In dtSistemas.Rows
                        Si.Id_campania = rc("id_campania")
                        Si.Id_sistema = rc("id_sistema")
                        Si.BuscarPorID()
                        ej.Id_campania = rc("id_campania")
                        ej.Id_sistema = rc("id_sistema")
                        dt = ej.ObtenerEjerciciosSistema
                        For Each row As DataRow In dt.Rows
                            ej.Id_ejercicio = row("id_ejercicio")
                            ej.BuscarPorID()
                            'ej.BorrarSpots(Activo.Login)
                            ej.BorrarSpotsTodos()
                        Next
                        Si.Borrar()
                    Next

                    te.Id_campania = Activo.IDCampaña
                    dt = te.ObtenerTemasPorCampaña()
                    For Each row As DataRow In dt.Rows
                        te.Id_tema = row("Id_tema")
                        te.Borrar()
                    Next
                    camp.Borrar()
                    'camp.TerminarTransaccion()
                    TraerCampañas()
                    treSistema.Nodes.Clear()
                Else
                    Mensajes.Mensaje("No puede eliminar esta campaña ya que contiene pases enviados a compras.")
                End If
            End If
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)
            'camp.AbortarTransaccion()
        End Try
    End Sub

    Private Sub BorrarSistemaEjercicio()
        ' Borrar sistemas o ejercicios

        Dim ej As New Ejercicios
        Dim Si As New Sistemas
        Dim dt As DataTable
        Dim New_Id_Sistema As Long
        Dim cant As Integer

        Try
            ej.Id_campania = Activo.IDCampaña
            ej.Id_sistema = Activo.IDSistema
            If treSistema.SelectedNode.GetNodeCount(True) = 0 Then ' no tiene hijos, es un ejercicio
                'AGREGADO CRISTIAN
                If treSistema.SelectedNode.Parent.GetNodeCount(True) = 1 Then ' que quede un ejercicio por lo menos
                    Mensajes.Mensaje("No puede haber Sistemas sin ejercicio", TipoMensaje.Informacion)
                    Exit Sub
                End If '
                ej.Id_ejercicio = Activo.IDEjercicio
                ej.BuscarPorID()
                If ej.HayEnviadosaCompras = 0 Then
                    If Mensajes.Mensaje("Desea eliminar el ejercicio " & ej.Descripcion, TipoMensaje.SiNo) = DialogResult.Yes Then
                        'ej.BorrarSpots(Activo.Login)
                        ej.BorrarSpotsTodos()
                        Me.TraerSistemasEjercicios(Activo.IDCampaña)
                    End If
                Else
                    Mensajes.Mensaje("Hay pases enviados a compras, no puede eliminar el ejercicio")
                End If
            Else
                Si.Id_campania = Activo.IDCampaña
                Si.Id_sistema = Activo.IDSistema
                Si.BuscarPorID()
                If Mensajes.Mensaje("Desea eliminar el sistema " & Si.Descripcion, TipoMensaje.SiNo) = DialogResult.Yes Then
                    'Si.IniciarTransaccion()
                    dt = ej.ObtenerEjerciciosSistema
                    ' Verifico que no haya spots comprados
                    For Each row As DataRow In dt.Rows
                        ej.Id_ejercicio = row("id_ejercicio")
                        ej.BuscarPorID()
                        cant = cant + ej.HayEnviadosaCompras
                    Next
                    ' Si no hay spots comprados, elimino
                    If cant = 0 Then
                        For Each row As DataRow In dt.Rows
                            ej.Id_ejercicio = row("id_ejercicio")
                            ej.BuscarPorID()
                            'ej.BorrarSpots(Activo.Login)
                            ej.BorrarSpotsTodos()
                        Next
                        Si.Borrar()
                        Me.TraerSistemasEjercicios(Activo.IDCampaña)
                    Else
                        Mensajes.Mensaje("Hay pases enviados a compras en algunos de los ejercicios de este sistema, no puede eliminar el sistema", TipoMensaje.Informacion)
                    End If
                End If
                'Si.TerminarTransaccion()
            End If
        Catch ex As Exception
            'Si.AbortarTransaccion()
            Mensajes.Mensaje(ex.Message)
        End Try
    End Sub



#End Region

    Private Sub DiferenciasPlanificacion(ByVal pFiltro As String)
        If treSistema.SelectedNode Is Nothing OrElse treSistema.SelectedNode.Parent Is Nothing Then
            Mensajes.Mensaje("Debe Seleccionar un Ejercicio", TipoMensaje.Informacion)
            Exit Sub
        End If
        If Activo.IDMedio <> MedioTV Then
            Mensajes.Mensaje("El ejercicio seleccionado no es de medio tv.", TipoMensaje.Informacion)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots
        Dim SD As New Spots_detalle
        Dim Spots As DataTable
        Dim SpotsDetalle As DataTable
        Dim SpotsOriginal As DataTable
        Dim SpotReporte As New SpotsLog
        Dim drSpotCabecera As SpotsLog.CabeceraRow
        Dim drSpotReporte As SpotsLog.Spots_LogRow
        Dim drSpotDetalleReporte As SpotsLog.Spots_Detalle_LogRow
        Dim Filtro As StringBuilder
        Dim Index, IndexOriginal, SpotsCount, IdCampania, IdSistema, IdEjercicio As Integer
        Dim Fecha As DateTime
        Dim Campania As New Campaña
        Dim Sistema As New Sistemas
        Dim Ejercicio As New Ejercicios

        SpotsOriginal = SD.ReporteCalendarioDiarioLog(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
        Spots = S.ObtenerSpotsLog(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio, Activo.IDMedio)
        SpotsDetalle = SD.ObtenerSpotsDetalleLog(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)

        If Not Spots Is Nothing Then
            SpotsCount = Spots.Select("", pFiltro).Length - 1
            If SpotsCount >= 0 Then
                drSpotCabecera = SpotReporte.Cabecera.NewRow

                IdCampania = Spots.Rows(0)("Id_Campania")
                IdSistema = Spots.Rows(0)("Id_Sistema")
                IdEjercicio = Spots.Rows(0)("Id_Ejercicio")
                Campania.ID_Campania = IdCampania
                Campania.BuscarPorID()
                Sistema.Id_campania = IdCampania
                Sistema.Id_sistema = IdSistema
                Sistema.BuscarPorID()
                Ejercicio.Id_campania = IdCampania
                Ejercicio.Id_sistema = IdSistema
                Ejercicio.Id_ejercicio = IdEjercicio
                Ejercicio.BuscarPorID()

                drSpotCabecera.CAMPANIA = Campania.Descripcion & " - " & Campania.ID_Campania
                drSpotCabecera.SISTEMA = Sistema.Descripcion & " - " & Sistema.Id_sistema
                drSpotCabecera.EJERCICIO = Ejercicio.Descripcion & " - " & Ejercicio.Id_ejercicio
                SpotReporte.Cabecera.Rows.Add(drSpotCabecera)
            End If
            For Each drSpots As DataRow In Spots.Select("", pFiltro)
                drSpotReporte = SpotReporte.Spots_Log.NewRow
                drSpotReporte.ID_SPOTS_LOG = Index
                For Each dcSpots As DataColumn In Spots.Columns
                    drSpotReporte(dcSpots.ColumnName) = drSpots(dcSpots.ColumnName)
                Next
                SpotReporte.Spots_Log.Rows.Add(drSpotReporte)
                Filtro = New StringBuilder
                Filtro.Append("Id_Spot = ")
                Filtro.Append(drSpotReporte.ID_SPOT)
                Filtro.Append(" and F_Accion ='")
                Filtro.Append(drSpotReporte.F_ACCION)
                Filtro.Append("'")
                For Each drSpotsDetalle As DataRow In SpotsDetalle.Select(Filtro.ToString)
                    drSpotDetalleReporte = SpotReporte.Spots_Detalle_Log.NewRow
                    drSpotDetalleReporte.ID_SPOTS_LOG = Index
                    For Each dcSpotsDetalle As DataColumn In SpotsDetalle.Columns
                        drSpotDetalleReporte(dcSpotsDetalle.ColumnName) = drSpotsDetalle(dcSpotsDetalle.ColumnName)
                    Next
                    SpotReporte.Spots_Detalle_Log.Rows.Add(drSpotDetalleReporte)
                Next

                If IndexOriginal < SpotsCount AndAlso Spots.Select("", pFiltro)(IndexOriginal).Item("Id_Spot") <> Spots.Select("", pFiltro)(IndexOriginal + 1).Item("Id_Spot") AndAlso Spots.Select("", pFiltro)(IndexOriginal).Item("Accion") <> "S" Then
                    Filtro = New StringBuilder
                    Filtro.Append("Id_Spot = ")
                    Filtro.Append(drSpotReporte.ID_SPOT)
                    Filtro.Append(" and Accion ='S'")

                    If SpotsDetalle.Select(Filtro.ToString).Length > 0 Then
                        drSpotReporte = SpotReporte.Spots_Log.NewRow
                        drSpotReporte.ID_SPOTS_LOG = Index + 1
                        For Each dcSpots As DataColumn In Spots.Columns
                            drSpotReporte(dcSpots.ColumnName) = drSpots(dcSpots.ColumnName)
                        Next
                        drSpotReporte("Accion") = "S"
                        SpotReporte.Spots_Log.Rows.Add(drSpotReporte)

                        For Each drSpotsDetalle As DataRow In SpotsDetalle.Select(Filtro.ToString)
                            drSpotDetalleReporte = SpotReporte.Spots_Detalle_Log.NewRow
                            drSpotDetalleReporte.ID_SPOTS_LOG = Index + 1
                            For Each dcSpotsDetalle As DataColumn In SpotsDetalle.Columns
                                drSpotDetalleReporte(dcSpotsDetalle.ColumnName) = drSpotsDetalle(dcSpotsDetalle.ColumnName)
                            Next
                            SpotReporte.Spots_Detalle_Log.Rows.Add(drSpotDetalleReporte)
                        Next
                        Index += 1
                    End If
                End If

                Index += 1
                IndexOriginal += 1
            Next

            For Each drSpotsLog As SpotsLog.Spots_LogRow In SpotReporte.Spots_Log.Rows
                For Each drSpotsOriginal As DataRow In SpotsOriginal.Select("Id_Spot = " & drSpotsLog.ID_SPOT)
                    If drSpotsOriginal("Programa") <> drSpotsLog.PROGRAMA Then
                        drSpotsLog.PROGRAMA_MODIFICADO = True
                    End If
                    If drSpotsOriginal("TarifaBruta") <> drSpotsLog.TARIFABRUTA Then
                        drSpotsLog.TARIFABRUTA_MODIFICADO = True
                    End If
                    If drSpotsOriginal("D1") <> drSpotsLog.D1 Then
                        drSpotsLog.D1_MODIFICADO = True
                    End If
                    If drSpotsOriginal("D2") <> drSpotsLog.D2 Then
                        drSpotsLog.D2_MODIFICADO = True
                    End If
                    If drSpotsOriginal("D3") <> drSpotsLog.D3 Then
                        drSpotsLog.D3_MODIFICADO = True
                    End If
                    If drSpotsOriginal("D4") <> drSpotsLog.D4 Then
                        drSpotsLog.D4_MODIFICADO = True
                    End If
                    If drSpotsOriginal("D5") <> drSpotsLog.D5 Then
                        drSpotsLog.D5_MODIFICADO = True
                    End If
                    If drSpotsOriginal("TarifaNeta") <> drSpotsLog.TARIFANETA Then
                        drSpotsLog.TARIFANETA_MODIFICADO = True
                    End If
                    If drSpotsLog.TIPO_RATING = "P" Then
                        If drSpotsOriginal("RatingPrograma") <> drSpotsLog.RATINGPROGRAMA Then
                            drSpotsLog.RATING_MODIFICADO = True
                        End If
                    Else
                        If drSpotsOriginal("RatingTanda") <> drSpotsLog.RATINGTANDA Then
                            drSpotsLog.RATING_MODIFICADO = True
                        End If
                    End If
                    Exit For
                Next
            Next

            Dim Reporte As New frmPlanificacionModificadaLog
            Reporte.DataSource = SpotReporte
            Reporte.ShowDialog()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub tabCampaña_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tabCampaña.Paint

    'End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        If Activo.IDMedio = 3 OrElse Activo.IDMedio = 4 OrElse Activo.IDMedio = 5 Then Exit Sub

        Dim c As New Cubo_Listados
        Dim dt As DataTable
        Dim frmCub As New Cubo
        Dim s As New Sistemas

        s.Id_campania = Activo.IDCampaña
        s.Id_sistema = Activo.IDSistema
        s.BuscarPorID()

        c.Id_Campania = Activo.IDCampaña
        c.Id_Sistema = Activo.IDSistema
        c.Id_Ejercicio = Activo.IDEjercicio
        c.Tipo_Rating = s.Tipo_rating
        dt = c.Cubo_Ejercicio()

        frmCub.Nombre = "CuboEjercicio"
        frmCub.Titulo = "Análisis de inserciones"
        frmCub.Modo = 0
        frmCub.DataTableCub = dt
        frmCub.ShowDialog()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem10.Click

    End Sub

    Private Sub btnCambiarCompania_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarCompania.Click
        Dim frm As New frmCambiarCompania
        'Dim U As New Usuario
        Dim Convenio As New Convenios
        Dim dsConvenio As DataSet
        frm.User = User
        frm.Contrasenia = Contrasenia
        frm.ShowDialog()

        Dim OMsl As New Maestros
        'OMsl.CambiarCompania(frm.IdCompania, frm.IdDelegacion)
        lblCompania.Text = OMsl.ObtenerDescripcionCompaniaActual

        'Dim Archivo As String = "C:\Archivos de Programa\MPG\Quetool\Perfiles\"
        'Dim XML As New AMS.Profile.Xml(Archivo & "usuario.xml")
        'XML.SetValue("login", "usuario", User)
        'U.Login = User
        'U.ValidarUsuario(User, Contrasenia)
        Dim OSop As New MPG.DBL.Soportes

        Activo.DTSoportesCache = OSop.ObtenerSoportesMMSVistaMaterializada(MSL.Constantes.COD_PAIS_ARGENTINA)

        If Activo.IDPerfil_Datos = 1 AndAlso Activo.CodCapacidad = 6 Then
            dsConvenio = Convenio.ObtenerExtra(Activo.IDUsuario)
            If Not dsConvenio Is Nothing AndAlso Not dsConvenio.Tables(0) Is Nothing AndAlso dsConvenio.Tables.Count > 0 AndAlso dsConvenio.Tables(0).Rows.Count > 0 AndAlso Not dsConvenio.Tables(0).Columns("Id_Permiso") Is Nothing AndAlso Not dsConvenio.Tables(0).Rows(0)("Id_Permiso") Is DBNull.Value AndAlso (Convert.ToInt32(dsConvenio.Tables(0).Rows(0)("Id_Permiso")) = 2 Or Convert.ToInt32(dsConvenio.Tables(0).Rows(0)("Id_Permiso")) = 1) Then
                Dim rol As New frmRol
                rol.ShowDialog()

                If rol.pRol = frmRol.Rol.Control Then
                    Me.Hide()
                    Dim frmControl As New frmPrincipalControl
                    frmControl.ShowDialog()
                    Me.Close()
                    Exit Sub
                End If
            End If
        End If

        If Not dsConvenio Is Nothing AndAlso Not dsConvenio.Tables(0) Is Nothing AndAlso dsConvenio.Tables.Count > 0 AndAlso dsConvenio.Tables(0).Rows.Count > 0 AndAlso Not dsConvenio.Tables(0).Columns("Id_Permiso") Is Nothing AndAlso Not dsConvenio.Tables(0).Rows(0)("Id_Permiso") Is DBNull.Value Then
            Activo.PerfilConvenios = Convert.ToInt32(dsConvenio.Tables(0).Rows(0)("Id_Permiso"))
        Else
            Activo.PerfilConvenios = Activo.PerfilConvenio.SinPermisos
        End If

        Dim frmElegirCliente As New frmElegirCliente

        frmElegirCliente.CargandoPrimeraVez = True

        frmElegirCliente.ShowDialog()

        CargarCliente(OMsl, dsConvenio, Convenio)

    End Sub

    
    
End Class

Public Enum Botones
    Nuevo = 0
    Guardar = 1
    Cancelar = 2
    Cubo = 3
    Actualizacion = 4
    Materiales = 5
    Importacion = 6
    CambioTema = 7
End Enum

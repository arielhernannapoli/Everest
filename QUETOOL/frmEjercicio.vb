Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.Printing
Imports System.IO, System.Xml
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Core
Imports System.Text
Imports ClosedXML.Excel

Public Class frmEjercicio
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
    Friend WithEvents tblAcciones As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _Form1_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents iugEjercicio As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents CtxMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuColumnasOcultas As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuOcultarColumna As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.MenuItem
    Friend WithEvents UltraDockManager1 As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _frmEjercicioUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmEjercicioUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmEjercicioUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmEjercicioUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmEjercicioAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow4 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents iugSoporte As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents iugTema As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents iugSemana As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents iugFranja As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents WindowDockingArea3 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents lblNeto As System.Windows.Forms.Label
    Friend WithEvents lblBruto As System.Windows.Forms.Label
    Friend WithEvents lblCPR As System.Windows.Forms.Label
    Friend WithEvents lblSegundos As System.Windows.Forms.Label
    Friend WithEvents lblAvisos As System.Windows.Forms.Label
    Friend WithEvents lblGRP As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mnuSemana As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuSemana7Dias As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSemanaCalendario As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents cmdCerrarTotales As System.Windows.Forms.Button
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents WindowDockingArea2 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents tmrFiltro As System.Windows.Forms.Timer
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents exExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents iugExport As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugExportar As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents lblDuracionPromedioCPR As System.Windows.Forms.Label
    Friend WithEvents DuracionPromedioCPR As System.Windows.Forms.Label
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents DockableWindow6 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow7 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow8 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea4 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow5 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents cbCalculoAutomatico As System.Windows.Forms.CheckBox
    Friend WithEvents txtsave As System.Windows.Forms.TextBox
    Friend WithEvents pivotFlex As CuboDock
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("Menu")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("guardar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("borrar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("soportes")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("puntual")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("global")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ocultarcolumnas")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("preevaluacion")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("abrirperfil")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("guardarperfil")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("exportar")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("imprimir")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("cmdcubo")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("excel")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("cubo2")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExpandirColapsar")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteLine")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("guardar")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("borrar")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("preevaluacion")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("soportes")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("puntual")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("global")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ocultarcolumnas")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("imprimir")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("abrirperfil")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("guardarperfil")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("exportar")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("cmdcubo")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("excel")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("cubo2")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExpandirColapsar")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteLine")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEjercicio))
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.Floating, New System.Guid("164d5001-3d21-405e-86c8-0ec176893df0"))
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedBottom, New System.Guid("743737c1-0abf-43a1-996c-cbf700283595"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("46b3d65f-1440-4b9b-8ebe-84643f57b013"), New System.Guid("164d5001-3d21-405e-86c8-0ec176893df0"), -1, New System.Guid("743737c1-0abf-43a1-996c-cbf700283595"), 1)
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("341dd586-de48-4186-a774-8cbe8ad99914"), New System.Guid("164d5001-3d21-405e-86c8-0ec176893df0"), -1, New System.Guid("743737c1-0abf-43a1-996c-cbf700283595"), 2)
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("f4f0226c-e30d-4c10-8c30-6f0c3c6c64ec"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("743737c1-0abf-43a1-996c-cbf700283595"), 1)
        Dim DockableControlPane4 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("1b5daa41-3efd-44d3-8ebc-d8d544696080"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("743737c1-0abf-43a1-996c-cbf700283595"), 0)
        Dim DockableControlPane5 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("1b5daa41-3efd-44d3-8ebc-d8d544696081"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("743737c1-0abf-43a1-996c-cbf700283595"), 3)
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugSoporte = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.iugFranja = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.iugSemana = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.mnuSemana = New System.Windows.Forms.ContextMenu
        Me.mnuSemana7Dias = New System.Windows.Forms.MenuItem
        Me.mnuSemanaCalendario = New System.Windows.Forms.MenuItem
        Me.iugTema = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.pivotFlex = New QUETOOL.CuboDock
        Me.pnlTotal = New System.Windows.Forms.Panel
        Me.cbCalculoAutomatico = New System.Windows.Forms.CheckBox
        Me.lblDuracionPromedioCPR = New System.Windows.Forms.Label
        Me.DuracionPromedioCPR = New System.Windows.Forms.Label
        Me.cmdCerrarTotales = New System.Windows.Forms.Button
        Me.lblNeto = New System.Windows.Forms.Label
        Me.lblBruto = New System.Windows.Forms.Label
        Me.lblCPR = New System.Windows.Forms.Label
        Me.lblSegundos = New System.Windows.Forms.Label
        Me.lblAvisos = New System.Windows.Forms.Label
        Me.lblGRP = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tblAcciones = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me._Form1_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.iugEjercicio = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.CtxMenu = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuBorrar = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.mnuColumnasOcultas = New System.Windows.Forms.ContextMenu
        Me.mnuOcultarColumna = New System.Windows.Forms.MenuItem
        Me.UltraDockManager1 = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._frmEjercicioUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmEjercicioUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmEjercicioUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmEjercicioUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._frmEjercicioAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl
        Me.DockableWindow4 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.DockableWindow7 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.DockableWindow8 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.DockableWindow3 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.DockableWindow6 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.WindowDockingArea3 = New Infragistics.Win.UltraWinDock.WindowDockingArea
        Me.mnuPrincipal = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea
        Me.WindowDockingArea2 = New Infragistics.Win.UltraWinDock.WindowDockingArea
        Me.DockableWindow5 = New Infragistics.Win.UltraWinDock.DockableWindow
        Me.tmrFiltro = New System.Windows.Forms.Timer(Me.components)
        Me.iugExport = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ugExportar = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
        Me.txtsave = New System.Windows.Forms.TextBox
        Me.WindowDockingArea4 = New Infragistics.Win.UltraWinDock.WindowDockingArea
        CType(Me.iugSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugFranja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugTema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pivotFlex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotal.SuspendLayout()
        CType(Me.tblAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._frmEjercicioAutoHideControl.SuspendLayout()
        Me.DockableWindow4.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.DockableWindow7.SuspendLayout()
        Me.DockableWindow8.SuspendLayout()
        Me.DockableWindow3.SuspendLayout()
        Me.WindowDockingArea1.SuspendLayout()
        Me.WindowDockingArea2.SuspendLayout()
        CType(Me.iugExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugSoporte
        '
        Me.iugSoporte.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.White
        Me.iugSoporte.DisplayLayout.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.iugSoporte.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.iugSoporte.DisplayLayout.Override.CellPadding = 3
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugSoporte.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance4.BorderColor = System.Drawing.Color.LightGray
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugSoporte.DisplayLayout.Override.RowAppearance = Appearance4
        Me.iugSoporte.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.Color.PowderBlue
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.iugSoporte.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.iugSoporte.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugSoporte.FlatMode = True
        Me.iugSoporte.Location = New System.Drawing.Point(0, 18)
        Me.iugSoporte.Name = "iugSoporte"
        Me.iugSoporte.Size = New System.Drawing.Size(1131, 114)
        Me.iugSoporte.TabIndex = 23
        '
        'iugFranja
        '
        Me.iugFranja.Cursor = System.Windows.Forms.Cursors.Default
        Appearance6.BackColor = System.Drawing.Color.White
        Me.iugFranja.DisplayLayout.Appearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.iugFranja.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Me.iugFranja.DisplayLayout.Override.CellPadding = 3
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugFranja.DisplayLayout.Override.HeaderAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.LightGray
        Appearance9.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugFranja.DisplayLayout.Override.RowAppearance = Appearance9
        Me.iugFranja.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance10.BackColor = System.Drawing.Color.PowderBlue
        Appearance10.BorderColor = System.Drawing.Color.Black
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.iugFranja.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.iugFranja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugFranja.FlatMode = True
        Me.iugFranja.Location = New System.Drawing.Point(0, 18)
        Me.iugFranja.Name = "iugFranja"
        Me.iugFranja.Size = New System.Drawing.Size(1028, 107)
        Me.iugFranja.TabIndex = 26
        '
        'iugSemana
        '
        Me.iugSemana.ContextMenu = Me.mnuSemana
        Me.iugSemana.Cursor = System.Windows.Forms.Cursors.Default
        Appearance11.BackColor = System.Drawing.Color.White
        Me.iugSemana.DisplayLayout.Appearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.iugSemana.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Me.iugSemana.DisplayLayout.Override.CellPadding = 3
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugSemana.DisplayLayout.Override.HeaderAppearance = Appearance13
        Appearance14.BorderColor = System.Drawing.Color.LightGray
        Appearance14.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugSemana.DisplayLayout.Override.RowAppearance = Appearance14
        Me.iugSemana.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.Color.PowderBlue
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.iugSemana.DisplayLayout.Override.SelectedRowAppearance = Appearance15
        Me.iugSemana.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugSemana.FlatMode = True
        Me.iugSemana.Location = New System.Drawing.Point(0, 18)
        Me.iugSemana.Name = "iugSemana"
        Me.iugSemana.Size = New System.Drawing.Size(1028, 107)
        Me.iugSemana.TabIndex = 25
        '
        'mnuSemana
        '
        Me.mnuSemana.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSemana7Dias, Me.mnuSemanaCalendario})
        '
        'mnuSemana7Dias
        '
        Me.mnuSemana7Dias.Checked = True
        Me.mnuSemana7Dias.Index = 0
        Me.mnuSemana7Dias.Text = "Ver Semana de 7 Días"
        '
        'mnuSemanaCalendario
        '
        Me.mnuSemanaCalendario.Index = 1
        Me.mnuSemanaCalendario.Text = "Ver Semana Calendario"
        '
        'iugTema
        '
        Me.iugTema.Cursor = System.Windows.Forms.Cursors.Default
        Appearance16.BackColor = System.Drawing.Color.White
        Me.iugTema.DisplayLayout.Appearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.iugTema.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Me.iugTema.DisplayLayout.Override.CellPadding = 3
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugTema.DisplayLayout.Override.HeaderAppearance = Appearance18
        Appearance19.BorderColor = System.Drawing.Color.LightGray
        Appearance19.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugTema.DisplayLayout.Override.RowAppearance = Appearance19
        Me.iugTema.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.Color.PowderBlue
        Appearance20.BorderColor = System.Drawing.Color.Black
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.iugTema.DisplayLayout.Override.SelectedRowAppearance = Appearance20
        Me.iugTema.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugTema.FlatMode = True
        Me.iugTema.Location = New System.Drawing.Point(0, 18)
        Me.iugTema.Name = "iugTema"
        Me.iugTema.Size = New System.Drawing.Size(1024, 107)
        Me.iugTema.TabIndex = 24
        '
        'pivotFlex
        '
        Me.pivotFlex.Cursor = System.Windows.Forms.Cursors.Default
        Me.pivotFlex.Location = New System.Drawing.Point(0, 28)
        Me.pivotFlex.Name = "pivotFlex"
        Me.pivotFlex.Size = New System.Drawing.Size(1314, 537)
        Me.pivotFlex.TabIndex = 0
        '
        'pnlTotal
        '
        Me.pnlTotal.Controls.Add(Me.cbCalculoAutomatico)
        Me.pnlTotal.Controls.Add(Me.lblDuracionPromedioCPR)
        Me.pnlTotal.Controls.Add(Me.DuracionPromedioCPR)
        Me.pnlTotal.Controls.Add(Me.cmdCerrarTotales)
        Me.pnlTotal.Controls.Add(Me.lblNeto)
        Me.pnlTotal.Controls.Add(Me.lblBruto)
        Me.pnlTotal.Controls.Add(Me.lblCPR)
        Me.pnlTotal.Controls.Add(Me.lblSegundos)
        Me.pnlTotal.Controls.Add(Me.lblAvisos)
        Me.pnlTotal.Controls.Add(Me.lblGRP)
        Me.pnlTotal.Controls.Add(Me.Label6)
        Me.pnlTotal.Controls.Add(Me.Label5)
        Me.pnlTotal.Controls.Add(Me.Label4)
        Me.pnlTotal.Controls.Add(Me.Label3)
        Me.pnlTotal.Controls.Add(Me.Label2)
        Me.pnlTotal.Controls.Add(Me.Label1)
        Me.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotal.Location = New System.Drawing.Point(0, 342)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(1131, 24)
        Me.pnlTotal.TabIndex = 43
        '
        'cbCalculoAutomatico
        '
        Me.cbCalculoAutomatico.AutoSize = True
        Me.cbCalculoAutomatico.Location = New System.Drawing.Point(975, 7)
        Me.cbCalculoAutomatico.Name = "cbCalculoAutomatico"
        Me.cbCalculoAutomatico.Size = New System.Drawing.Size(117, 17)
        Me.cbCalculoAutomatico.TabIndex = 17
        Me.cbCalculoAutomatico.Text = "Calculo Automático"
        Me.cbCalculoAutomatico.UseVisualStyleBackColor = True
        '
        'lblDuracionPromedioCPR
        '
        Me.lblDuracionPromedioCPR.BackColor = System.Drawing.SystemColors.Window
        Me.lblDuracionPromedioCPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDuracionPromedioCPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracionPromedioCPR.Location = New System.Drawing.Point(905, 4)
        Me.lblDuracionPromedioCPR.Name = "lblDuracionPromedioCPR"
        Me.lblDuracionPromedioCPR.Size = New System.Drawing.Size(64, 20)
        Me.lblDuracionPromedioCPR.TabIndex = 16
        Me.lblDuracionPromedioCPR.Text = "0"
        Me.lblDuracionPromedioCPR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DuracionPromedioCPR
        '
        Me.DuracionPromedioCPR.AutoSize = True
        Me.DuracionPromedioCPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DuracionPromedioCPR.Location = New System.Drawing.Point(802, 8)
        Me.DuracionPromedioCPR.Name = "DuracionPromedioCPR"
        Me.DuracionPromedioCPR.Size = New System.Drawing.Size(97, 13)
        Me.DuracionPromedioCPR.TabIndex = 15
        Me.DuracionPromedioCPR.Text = "Duracion Promedio"
        '
        'cmdCerrarTotales
        '
        Me.cmdCerrarTotales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrarTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrarTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrarTotales.Location = New System.Drawing.Point(1103, 4)
        Me.cmdCerrarTotales.Name = "cmdCerrarTotales"
        Me.cmdCerrarTotales.Size = New System.Drawing.Size(20, 20)
        Me.cmdCerrarTotales.TabIndex = 12
        Me.cmdCerrarTotales.Tag = ""
        Me.cmdCerrarTotales.Text = "X"
        Me.cmdCerrarTotales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNeto
        '
        Me.lblNeto.BackColor = System.Drawing.SystemColors.Window
        Me.lblNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNeto.Location = New System.Drawing.Point(584, 4)
        Me.lblNeto.Name = "lblNeto"
        Me.lblNeto.Size = New System.Drawing.Size(96, 20)
        Me.lblNeto.TabIndex = 11
        Me.lblNeto.Text = "0"
        Me.lblNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBruto
        '
        Me.lblBruto.BackColor = System.Drawing.SystemColors.Window
        Me.lblBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBruto.Location = New System.Drawing.Point(432, 4)
        Me.lblBruto.Name = "lblBruto"
        Me.lblBruto.Size = New System.Drawing.Size(96, 20)
        Me.lblBruto.TabIndex = 10
        Me.lblBruto.Text = "0"
        Me.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCPR
        '
        Me.lblCPR.BackColor = System.Drawing.SystemColors.Window
        Me.lblCPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPR.Location = New System.Drawing.Point(728, 4)
        Me.lblCPR.Name = "lblCPR"
        Me.lblCPR.Size = New System.Drawing.Size(64, 20)
        Me.lblCPR.TabIndex = 9
        Me.lblCPR.Text = "0"
        Me.lblCPR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSegundos
        '
        Me.lblSegundos.BackColor = System.Drawing.SystemColors.Window
        Me.lblSegundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSegundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundos.Location = New System.Drawing.Point(308, 4)
        Me.lblSegundos.Name = "lblSegundos"
        Me.lblSegundos.Size = New System.Drawing.Size(64, 20)
        Me.lblSegundos.TabIndex = 8
        Me.lblSegundos.Text = "0"
        Me.lblSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAvisos
        '
        Me.lblAvisos.BackColor = System.Drawing.SystemColors.Window
        Me.lblAvisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvisos.Location = New System.Drawing.Point(168, 4)
        Me.lblAvisos.Name = "lblAvisos"
        Me.lblAvisos.Size = New System.Drawing.Size(64, 20)
        Me.lblAvisos.TabIndex = 7
        Me.lblAvisos.Text = "0"
        Me.lblAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGRP
        '
        Me.lblGRP.BackColor = System.Drawing.SystemColors.Window
        Me.lblGRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGRP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGRP.Location = New System.Drawing.Point(44, 4)
        Me.lblGRP.Name = "lblGRP"
        Me.lblGRP.Size = New System.Drawing.Size(64, 20)
        Me.lblGRP.TabIndex = 6
        Me.lblGRP.Text = "0"
        Me.lblGRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(700, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CPR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(548, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Neto $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bruto $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(252, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Segundos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Avisos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GRPs"
        '
        'tblAcciones
        '
        Me.tblAcciones.DesignerFlags = 1
        Me.tblAcciones.DockWithinContainer = Me
        Me.tblAcciones.ImageListSmall = Me.ImageList
        Me.tblAcciones.RuntimeCustomizationOptions = Infragistics.Win.UltraWinToolbars.RuntimeCustomizationOptions.None
        Me.tblAcciones.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.Text = "Menu"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool16})
        Me.tblAcciones.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance38.Image = CType(resources.GetObject("Appearance38.Image"), Object)
        ButtonTool17.SharedProps.AppearancesSmall.Appearance = Appearance38
        ButtonTool17.SharedProps.ToolTipText = "Guardar la Hoja de Planificación"
        Appearance39.Image = CType(resources.GetObject("Appearance39.Image"), Object)
        ButtonTool18.SharedProps.AppearancesSmall.Appearance = Appearance39
        ButtonTool18.SharedProps.ToolTipText = "Borrar las Filas Seleccionadas"
        Appearance40.Image = CType(resources.GetObject("Appearance40.Image"), Object)
        ButtonTool19.SharedProps.AppearancesSmall.Appearance = Appearance40
        ButtonTool19.SharedProps.ToolTipText = "Tarifas Congeladas"
        Appearance41.Image = CType(resources.GetObject("Appearance41.Image"), Object)
        ButtonTool20.SharedProps.AppearancesSmall.Appearance = Appearance41
        ButtonTool20.SharedProps.ToolTipText = "Agregar Nuevos Soportes"
        Appearance42.Image = CType(resources.GetObject("Appearance42.Image"), Object)
        ButtonTool21.SharedProps.AppearancesSmall.Appearance = Appearance42
        ButtonTool21.SharedProps.ToolTipText = "Aplicar Convenio al Programa"
        Appearance43.Image = CType(resources.GetObject("Appearance43.Image"), Object)
        ButtonTool22.SharedProps.AppearancesSmall.Appearance = Appearance43
        ButtonTool22.SharedProps.ToolTipText = "Aplicar Convenio a la Hoja"
        Appearance44.Image = CType(resources.GetObject("Appearance44.Image"), Object)
        ButtonTool23.SharedProps.AppearancesSmall.Appearance = Appearance44
        ButtonTool23.SharedProps.ToolTipText = "Ocultar y Mostrar Columnas"
        Appearance45.Image = CType(resources.GetObject("Appearance45.Image"), Object)
        ButtonTool24.SharedProps.AppearancesSmall.Appearance = Appearance45
        ButtonTool24.SharedProps.ToolTipText = "Imprimir Hoja de Planificación"
        Appearance46.Image = CType(resources.GetObject("Appearance46.Image"), Object)
        ButtonTool25.SharedProps.AppearancesSmall.Appearance = Appearance46
        ButtonTool25.SharedProps.ToolTipText = "Abrir Perfil"
        Appearance47.Image = CType(resources.GetObject("Appearance47.Image"), Object)
        ButtonTool26.SharedProps.AppearancesSmall.Appearance = Appearance47
        ButtonTool26.SharedProps.ToolTipText = "Guardar Perfil"
        Appearance48.Image = CType(resources.GetObject("Appearance48.Image"), Object)
        ButtonTool27.SharedProps.AppearancesSmall.Appearance = Appearance48
        ButtonTool27.SharedProps.ToolTipText = "Exportar Ranking CPR "
        Appearance49.Image = CType(resources.GetObject("Appearance49.Image"), Object)
        ButtonTool28.SharedProps.AppearancesSmall.Appearance = Appearance49
        Appearance50.Image = CType(resources.GetObject("Appearance50.Image"), Object)
        ButtonTool29.SharedProps.AppearancesSmall.Appearance = Appearance50
        Appearance51.Image = CType(resources.GetObject("Appearance51.Image"), Object)
        ButtonTool30.SharedProps.AppearancesSmall.Appearance = Appearance51
        ButtonTool30.SharedProps.Caption = "cubo2"
        Appearance52.Image = 1
        ButtonTool31.SharedProps.AppearancesSmall.Appearance = Appearance52
        ButtonTool31.SharedProps.Caption = "Expandir"
        ButtonTool31.SharedProps.Visible = False
        Appearance53.Image = CType(resources.GetObject("Appearance53.Image"), Object)
        ButtonTool32.SharedProps.AppearancesSmall.Appearance = Appearance53
        ButtonTool32.SharedProps.Caption = "Reporte Regional"
        Me.tblAcciones.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool17, ButtonTool18, ButtonTool19, ButtonTool20, ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24, ButtonTool25, ButtonTool26, ButtonTool27, ButtonTool28, ButtonTool29, ButtonTool30, ButtonTool31, ButtonTool32})
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        '
        '_Form1_Toolbars_Dock_Area_Left
        '
        Me._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 24)
        Me._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left"
        Me._Form1_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 504)
        Me._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = Me.tblAcciones
        '
        '_Form1_Toolbars_Dock_Area_Right
        '
        Me._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1131, 24)
        Me._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right"
        Me._Form1_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 504)
        Me._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = Me.tblAcciones
        '
        '_Form1_Toolbars_Dock_Area_Top
        '
        Me._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top"
        Me._Form1_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1131, 24)
        Me._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = Me.tblAcciones
        '
        '_Form1_Toolbars_Dock_Area_Bottom
        '
        Me._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 528)
        Me._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom"
        Me._Form1_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1131, 0)
        Me._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.tblAcciones
        '
        'iugEjercicio
        '
        Me.iugEjercicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iugEjercicio.DataSource = Me.UltraDataSource1
        Appearance21.BackColor = System.Drawing.Color.White
        Me.iugEjercicio.DisplayLayout.Appearance = Appearance21
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Me.iugEjercicio.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Me.iugEjercicio.DisplayLayout.Override.CellPadding = 3
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugEjercicio.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.iugEjercicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance24.BorderColor = System.Drawing.Color.LightGray
        Appearance24.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugEjercicio.DisplayLayout.Override.RowAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.Color.PowderBlue
        Appearance25.BorderColor = System.Drawing.Color.Black
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.iugEjercicio.DisplayLayout.Override.SelectedRowAppearance = Appearance25
        Me.iugEjercicio.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugEjercicio.DisplayLayout.UseFixedHeaders = True
        Me.iugEjercicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugEjercicio.FlatMode = True
        Me.iugEjercicio.Location = New System.Drawing.Point(0, 24)
        Me.iugEjercicio.Name = "iugEjercicio"
        Me.iugEjercicio.Size = New System.Drawing.Size(1131, 318)
        Me.iugEjercicio.TabIndex = 9
        '
        'UltraDataSource1
        '
        '
        'CtxMenu
        '
        Me.CtxMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.mnuBorrar, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem31, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Duplicar"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Index = 1
        Me.mnuBorrar.Text = "Borrar"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 3
        Me.MenuItem21.Text = "Copiar"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Text = "Pegar"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 6
        Me.MenuItem31.Text = "Ver Rating Real"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 7
        Me.MenuItem24.Text = "Ver Detalle de Rating"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 8
        Me.MenuItem25.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 9
        Me.MenuItem26.Text = "Color de Fondo"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 10
        Me.MenuItem27.Text = "Color de Letra"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 11
        Me.MenuItem32.Text = "Bonificar"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 12
        Me.MenuItem33.Text = "-"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 13
        Me.MenuItem34.Text = "Distribución Automatica"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 14
        Me.MenuItem35.Text = "-"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 15
        Me.MenuItem36.Text = "Distribuidor Pases"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 16
        Me.MenuItem37.Text = "Reemplazar Temas"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 366)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1131, 4)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'mnuColumnasOcultas
        '
        Me.mnuColumnasOcultas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOcultarColumna})
        '
        'mnuOcultarColumna
        '
        Me.mnuOcultarColumna.Index = 0
        Me.mnuOcultarColumna.Text = "Ocultar Columna"
        '
        'UltraDockManager1
        '
        DockAreaPane1.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.TabGroup
        DockAreaPane1.DockedBefore = New System.Guid("743737c1-0abf-43a1-996c-cbf700283595")
        DockAreaPane1.FloatingLocation = New System.Drawing.Point(350, 451)
        DockAreaPane1.Size = New System.Drawing.Size(982, 125)
        DockAreaPane2.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.VerticalSplit
        DockAreaPane2.FloatingLocation = New System.Drawing.Point(350, 451)
        DockableControlPane1.Control = Me.iugSoporte
        DockableControlPane1.FlyoutSize = New System.Drawing.Size(-1, 60)
        DockableControlPane1.Key = "soporte"
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(136, 368, 192, 104)
        DockableControlPane1.Size = New System.Drawing.Size(406, 125)
        DockableControlPane1.Text = "Desglose por Soporte"
        DockableControlPane2.Control = Me.iugFranja
        DockableControlPane2.FlyoutSize = New System.Drawing.Size(-1, 125)
        DockableControlPane2.Key = "franja"
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(488, 392, 192, 104)
        DockableControlPane2.Pinned = False
        DockableControlPane2.Size = New System.Drawing.Size(426, 125)
        DockableControlPane2.Text = "Desglose por Franja"
        DockableControlPane3.Control = Me.iugSemana
        DockableControlPane3.FlyoutSize = New System.Drawing.Size(-1, 125)
        DockableControlPane3.Key = "semana"
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(424, 384, 192, 104)
        DockableControlPane3.Pinned = False
        DockableControlPane3.Size = New System.Drawing.Size(411, 125)
        DockableControlPane3.Text = "Desglose por Semana"
        DockableControlPane4.Control = Me.iugTema
        DockableControlPane4.FlyoutSize = New System.Drawing.Size(-1, 125)
        DockableControlPane4.Key = "tema"
        DockableControlPane4.OriginalControlBounds = New System.Drawing.Rectangle(328, 384, 192, 104)
        DockableControlPane4.Pinned = False
        DockableControlPane4.Size = New System.Drawing.Size(433, 125)
        DockableControlPane4.Text = "Desglose por Tema"
        DockableControlPane5.Control = Me.pivotFlex
        DockableControlPane5.FlyoutSize = New System.Drawing.Size(-1, 60)
        DockableControlPane5.Key = "cuboflex"
        DockableControlPane5.OriginalControlBounds = New System.Drawing.Rectangle(136, 368, 192, 104)
        DockableControlPane5.Pinned = False
        DockableControlPane5.Size = New System.Drawing.Size(406, 125)
        DockableControlPane5.Text = "Cubo Flex"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1, DockableControlPane2, DockableControlPane3, DockableControlPane4, DockableControlPane5})
        DockAreaPane2.Size = New System.Drawing.Size(1131, 132)
        Me.UltraDockManager1.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2})
        Me.UltraDockManager1.HostControl = Me
        '
        '_frmEjercicioUnpinnedTabAreaLeft
        '
        Me._frmEjercicioUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._frmEjercicioUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmEjercicioUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 24)
        Me._frmEjercicioUnpinnedTabAreaLeft.Name = "_frmEjercicioUnpinnedTabAreaLeft"
        Me._frmEjercicioUnpinnedTabAreaLeft.Owner = Me.UltraDockManager1
        Me._frmEjercicioUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 504)
        Me._frmEjercicioUnpinnedTabAreaLeft.TabIndex = 18
        '
        '_frmEjercicioUnpinnedTabAreaRight
        '
        Me._frmEjercicioUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._frmEjercicioUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmEjercicioUnpinnedTabAreaRight.Location = New System.Drawing.Point(1131, 24)
        Me._frmEjercicioUnpinnedTabAreaRight.Name = "_frmEjercicioUnpinnedTabAreaRight"
        Me._frmEjercicioUnpinnedTabAreaRight.Owner = Me.UltraDockManager1
        Me._frmEjercicioUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 504)
        Me._frmEjercicioUnpinnedTabAreaRight.TabIndex = 19
        '
        '_frmEjercicioUnpinnedTabAreaTop
        '
        Me._frmEjercicioUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._frmEjercicioUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmEjercicioUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 24)
        Me._frmEjercicioUnpinnedTabAreaTop.Name = "_frmEjercicioUnpinnedTabAreaTop"
        Me._frmEjercicioUnpinnedTabAreaTop.Owner = Me.UltraDockManager1
        Me._frmEjercicioUnpinnedTabAreaTop.Size = New System.Drawing.Size(1131, 0)
        Me._frmEjercicioUnpinnedTabAreaTop.TabIndex = 20
        '
        '_frmEjercicioUnpinnedTabAreaBottom
        '
        Me._frmEjercicioUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._frmEjercicioUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmEjercicioUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 507)
        Me._frmEjercicioUnpinnedTabAreaBottom.Name = "_frmEjercicioUnpinnedTabAreaBottom"
        Me._frmEjercicioUnpinnedTabAreaBottom.Owner = Me.UltraDockManager1
        Me._frmEjercicioUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1131, 21)
        Me._frmEjercicioUnpinnedTabAreaBottom.TabIndex = 21
        '
        '_frmEjercicioAutoHideControl
        '
        Me._frmEjercicioAutoHideControl.Controls.Add(Me.DockableWindow1)
        Me._frmEjercicioAutoHideControl.Controls.Add(Me.DockableWindow7)
        Me._frmEjercicioAutoHideControl.Controls.Add(Me.DockableWindow8)
        Me._frmEjercicioAutoHideControl.Controls.Add(Me.DockableWindow3)
        Me._frmEjercicioAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmEjercicioAutoHideControl.Location = New System.Drawing.Point(0, 497)
        Me._frmEjercicioAutoHideControl.Name = "_frmEjercicioAutoHideControl"
        Me._frmEjercicioAutoHideControl.Owner = Me.UltraDockManager1
        Me._frmEjercicioAutoHideControl.Size = New System.Drawing.Size(1024, 10)
        Me._frmEjercicioAutoHideControl.TabIndex = 22
        '
        'DockableWindow4
        '
        Me.DockableWindow4.Controls.Add(Me.iugSoporte)
        Me.DockableWindow4.Location = New System.Drawing.Point(0, 5)
        Me.DockableWindow4.Name = "DockableWindow4"
        Me.DockableWindow4.Owner = Me.UltraDockManager1
        Me.DockableWindow4.Size = New System.Drawing.Size(1131, 132)
        Me.DockableWindow4.TabIndex = 3
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.iugFranja)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 5)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UltraDockManager1
        Me.DockableWindow1.Size = New System.Drawing.Size(1024, 125)
        Me.DockableWindow1.TabIndex = 0
        '
        'DockableWindow7
        '
        Me.DockableWindow7.Controls.Add(Me.iugSemana)
        Me.DockableWindow7.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow7.Name = "DockableWindow7"
        Me.DockableWindow7.Owner = Me.UltraDockManager1
        Me.DockableWindow7.Size = New System.Drawing.Size(0, 0)
        Me.DockableWindow7.TabIndex = 1
        '
        'DockableWindow8
        '
        Me.DockableWindow8.Controls.Add(Me.iugTema)
        Me.DockableWindow8.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow8.Name = "DockableWindow8"
        Me.DockableWindow8.Owner = Me.UltraDockManager1
        Me.DockableWindow8.Size = New System.Drawing.Size(0, 0)
        Me.DockableWindow8.TabIndex = 1
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.pivotFlex)
        Me.DockableWindow3.Location = New System.Drawing.Point(0, 5)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.UltraDockManager1
        Me.DockableWindow3.Size = New System.Drawing.Size(1024, 132)
        Me.DockableWindow3.TabIndex = 2
        '
        'DockableWindow6
        '
        Me.DockableWindow6.Location = New System.Drawing.Point(0, 5)
        Me.DockableWindow6.Name = "DockableWindow6"
        Me.DockableWindow6.Owner = Me.UltraDockManager1
        Me.DockableWindow6.Size = New System.Drawing.Size(1131, 132)
        Me.DockableWindow6.TabIndex = 1
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Location = New System.Drawing.Point(0, 5)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.UltraDockManager1
        Me.DockableWindow2.Size = New System.Drawing.Size(1024, 132)
        Me.DockableWindow2.TabIndex = 1
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(4, 4)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.UltraDockManager1
        Me.WindowDockingArea3.Size = New System.Drawing.Size(982, 125)
        Me.WindowDockingArea3.TabIndex = 0
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem4, Me.MenuItem3})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem10, Me.MenuItem17})
        Me.MenuItem2.Text = "Hoja"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Guardar"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.Text = "Salir"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem18, Me.MenuItem7, Me.MenuItem19, Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem4.Text = "Programas"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Borrar"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "Cargar Por Soporte"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "Aplicar Convenio Puntual"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 5
        Me.MenuItem9.Text = "Aplicar Convenio Global"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem38, Me.MenuItem28})
        Me.MenuItem3.Text = "Ver"
        '
        'MenuItem11
        '
        Me.MenuItem11.Checked = True
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "Totales"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Checked = True
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "Desglose por Franja"
        '
        'MenuItem14
        '
        Me.MenuItem14.Checked = True
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "Desglose por Semana"
        '
        'MenuItem15
        '
        Me.MenuItem15.Checked = True
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "Desglose por Soporte"
        '
        'MenuItem16
        '
        Me.MenuItem16.Checked = True
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Text = "Desglose por Tema"
        '
        'MenuItem38
        '
        Me.MenuItem38.Checked = True
        Me.MenuItem38.Index = 6
        Me.MenuItem38.Text = "Cubo"
        Me.MenuItem38.Visible = False
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 7
        Me.MenuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem30})
        Me.MenuItem28.Text = "Barra de Totales"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 0
        Me.MenuItem29.Text = "Superior"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 1
        Me.MenuItem30.Text = "Inferior"
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow6)
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow4)
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(0, 370)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.UltraDockManager1
        Me.WindowDockingArea1.Size = New System.Drawing.Size(1131, 137)
        Me.WindowDockingArea1.TabIndex = 48
        '
        'WindowDockingArea2
        '
        Me.WindowDockingArea2.Controls.Add(Me.DockableWindow5)
        Me.WindowDockingArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea2.Location = New System.Drawing.Point(0, 233)
        Me.WindowDockingArea2.Name = "WindowDockingArea2"
        Me.WindowDockingArea2.Owner = Me.UltraDockManager1
        Me.WindowDockingArea2.Size = New System.Drawing.Size(1024, 137)
        Me.WindowDockingArea2.TabIndex = 0
        '
        'DockableWindow5
        '
        Me.DockableWindow5.Location = New System.Drawing.Point(0, 5)
        Me.DockableWindow5.Name = "DockableWindow5"
        Me.DockableWindow5.Owner = Me.UltraDockManager1
        Me.DockableWindow5.Size = New System.Drawing.Size(1024, 132)
        Me.DockableWindow5.TabIndex = 0
        '
        'tmrFiltro
        '
        '
        'iugExport
        '
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.iugExport.DisplayLayout.Appearance = Appearance26
        Me.iugExport.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.iugExport.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.iugExport.DisplayLayout.GroupByBox.Appearance = Appearance27
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.iugExport.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.iugExport.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.iugExport.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.iugExport.DisplayLayout.MaxColScrollRegions = 1
        Me.iugExport.DisplayLayout.MaxRowScrollRegions = 1
        Appearance30.BackColor = System.Drawing.SystemColors.Window
        Appearance30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iugExport.DisplayLayout.Override.ActiveCellAppearance = Appearance30
        Appearance31.BackColor = System.Drawing.SystemColors.Highlight
        Appearance31.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.iugExport.DisplayLayout.Override.ActiveRowAppearance = Appearance31
        Me.iugExport.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.iugExport.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Me.iugExport.DisplayLayout.Override.CardAreaAppearance = Appearance32
        Appearance33.BorderColor = System.Drawing.Color.Silver
        Appearance33.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.iugExport.DisplayLayout.Override.CellAppearance = Appearance33
        Me.iugExport.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.iugExport.DisplayLayout.Override.CellPadding = 0
        Appearance34.BackColor = System.Drawing.SystemColors.Control
        Appearance34.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance34.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.BorderColor = System.Drawing.SystemColors.Window
        Me.iugExport.DisplayLayout.Override.GroupByRowAppearance = Appearance34
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugExport.DisplayLayout.Override.HeaderAppearance = Appearance35
        Me.iugExport.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.iugExport.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.BorderColor = System.Drawing.Color.Silver
        Me.iugExport.DisplayLayout.Override.RowAppearance = Appearance36
        Me.iugExport.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLight
        Me.iugExport.DisplayLayout.Override.TemplateAddRowAppearance = Appearance37
        Me.iugExport.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugExport.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugExport.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.iugExport.Location = New System.Drawing.Point(104, 128)
        Me.iugExport.Name = "iugExport"
        Me.iugExport.Size = New System.Drawing.Size(88, 80)
        Me.iugExport.TabIndex = 53
        Me.iugExport.Text = "UltraGrid1"
        Me.iugExport.Visible = False
        '
        'txtsave
        '
        Me.txtsave.Location = New System.Drawing.Point(168, 128)
        Me.txtsave.Name = "txtsave"
        Me.txtsave.Size = New System.Drawing.Size(152, 20)
        Me.txtsave.TabIndex = 10
        '
        'WindowDockingArea4
        '
        Me.WindowDockingArea4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea4.Location = New System.Drawing.Point(0, 0)
        Me.WindowDockingArea4.Name = "WindowDockingArea4"
        Me.WindowDockingArea4.Owner = Me.UltraDockManager1
        Me.WindowDockingArea4.Size = New System.Drawing.Size(300, 125)
        Me.WindowDockingArea4.TabIndex = 0
        '
        'frmEjercicio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1131, 528)
        Me.Controls.Add(Me._frmEjercicioAutoHideControl)
        Me.Controls.Add(Me.iugEjercicio)
        Me.Controls.Add(Me.pnlTotal)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.iugExport)
        Me.Controls.Add(Me.txtsave)
        Me.Controls.Add(Me.WindowDockingArea4)
        Me.Controls.Add(Me.WindowDockingArea2)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Controls.Add(Me._frmEjercicioUnpinnedTabAreaTop)
        Me.Controls.Add(Me._frmEjercicioUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._frmEjercicioUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._frmEjercicioUnpinnedTabAreaRight)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Bottom)
        Me.Menu = Me.mnuPrincipal
        Me.Name = "frmEjercicio"
        Me.Text = "Hoja de Planificación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.iugSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugFranja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugSemana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugTema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pivotFlex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        CType(Me.tblAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._frmEjercicioAutoHideControl.ResumeLayout(False)
        Me.DockableWindow4.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.DockableWindow7.ResumeLayout(False)
        Me.DockableWindow8.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.WindowDockingArea2.ResumeLayout(False)
        CType(Me.iugExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Dim TempSpots As DataTable
    Dim pivotLoading As Boolean
    Dim AvisosEspeciales As New ArrayList
    Dim DtAfectados As DataTable
    Dim SoportesActualizados As New ArrayList
    Dim dtComprados As New DataTable
    Dim CantidadComprados As Integer
    Dim CopioDescuentos As Boolean = False
    Dim ErrorNautilus As Boolean = False
    Dim TipoDeAudiencia As TipoAudiencia
    Dim Deflactacion As Single
    Dim HayCambios As Boolean
    Dim UltimoText As String
    Dim EstaPresionadoControl As Boolean
    Dim AuxSpotBase As New DataTable
    Dim AuxDetalleBase As New DataTable
    Dim auxColumnasHijos As New ArrayList
    Dim AuxSoportes As Object
    Dim WithEvents SpotBase As New DataTable
    Dim WithEvents DetalleBase As New DataTable
    Dim Fechas As New ArrayList
    Dim Datos() As String
    Dim Mayusculas As Boolean = Teclas.CapsActivado
    Dim LetraValida As Boolean
    Dim LetraNueva As String 'guarda la letra que se ingreso (se usa para guardar el Spots_Detalle_Log)
    Dim dtTemas As New DataTable
    Dim ColumnasHijos As New ArrayList
    Dim ColumnasVisibles As Int16
    Dim ColOcultas As Int16 = 5
    Dim Borrar As Boolean
    Dim EnModoEdicion As Boolean = True
    Dim IndiceColBorrar As Integer
    Dim IndiceFilaUDS As Integer

    Dim arrColumnas As New ArrayList
    Dim ColumnaParaBorrar As String
    Dim TituloColumnaParaBorrar As String
    Dim mColumnasBorradas As Hashtable

    Dim ColorRatingCero As Color = Color.Blue
    Dim ColorEspecial As Color = Color.Blue
    Dim ColorDiaEspecial As Color = Color.LightSkyBlue
    Dim ColorDia As Color = Color.SeaShell
    Dim ColorCambioManual As Color = Color.Black  'Red

    Dim ColorColumnaNoEditable As Color = Color.LightSeaGreen
    Dim ColorColTotales As Color = Color.LightYellow
    Dim ColorVigenciaNula As Color = Color.LightGray
    Dim ColorLinaDomingo As Color = Color.Red
    Dim ColorDia7 As Color = Color.BlueViolet

    Dim LetraMinuscula As Byte = 32
    Dim Inicio As Date

    Dim KeyCompra As String
    Dim TextCompra As String
    Dim IDSpotCompra As Integer

    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato
    Dim GrillaResumen As New GrillaResumen

    Shared mInstancia As frmEjercicio

    Dim Franjas As DataTable
    Dim Semanas As ArrayList
    Dim SoportesDuracion As ArrayList
    Dim ColumnasAOcultar As New ArrayList
    Dim Ejer As EjercicioActivo

    Dim Target As Integer
    Dim Ruta As String = "C:\Archivos de Programa\MPG\Quetool\Perfiles\"
    Dim TipoDeRating As String
    Dim EsCargaDeCero As Boolean = False
    Dim Actual As New Actual
    Dim IDFranja As Integer
    ' Dim ResumenCubo As DataTable
    Const MedioRadio As Integer = 6
    Const MedioTv As Integer = 1
    Dim WithEvents fcubo As Cubo

    'AG 26/4/2010 Auspicio ---------------------------
    Dim DtAuspicios As DataTable
    Dim _ImporteAuspicioTema As Double
    Dim _MontoBrutoAuspicio As Double
    Dim SalidaAuspicio As Boolean
    Dim mControlTipoAuspicio As Integer
    Public _row As DataRow
    '---------------------------------------------------------

    'AG Distribuidor =======================================
    Dim DtSoporteHoja As DataTable
    Dim DtTemasCampania As DataTable
    Dim DtDistribuidorSoporte As DataTable
    Dim DtDistribuidorTemas As DataTable
    Dim DistribuidorValorObjetivo As Double
    Dim DistribuidorValorAvisos As Integer
    Dim DistribuidorTipoObjetivo As Integer
    Dim DistribuidorTipoFranja As Integer
    Dim DistribuidorConjunto As DataTable
    Dim DtOrdenarSpotDistribuidorXRating As DataTable
    Dim DtOrdenarSpotDistribuidorXCPR As DataTable
    Dim DtOrdenarSpotDistribuidorXSoporte As DataTable
    Dim DtFinalSpotDistribuidor As DataTable
    Dim DtOrdenarSpotDistribuidor As DataTable
    Dim DtGrillaEjercicio As New DataTable
    Dim DistribuidorFDesde, DistribuidorFHasta As Date
    Dim DistribuidorCancelar As Boolean
    '=======================================================

    'AG Reemplazo de TEMAS ==================================
    Dim DtReemplazoFinal As DataTable
    Dim DtReemplazoSeleccionados As DataTable
    Dim DtReemplazoAvisosEliminar As DataTable
    Dim DtReemplazoDetalleSpot As DataTable
    Dim ReemplazoTemasTipoObjetivo As Integer
    Dim CantidadAvisosPermitidosReemplazo As Integer
    Dim ReemplazoTipoAplicacion As Integer
    Dim ReemplazoFDesde As Date
    Dim ReemplazoFHasta As Date
    Dim ControlAvisosComprados As Boolean
    Dim ReemplazarCancelar As Boolean
    '========================================================

    Public Shared Property Instancia() As frmEjercicio
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmEjercicio
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As frmEjercicio)
            mInstancia = Value
        End Set
    End Property

    'AG Propiedades para proceso de REEMPLAZO de TEMAS ======

    Public Property _CantidadAvisosPermitidosReemplazo() As Integer
        Get
            Return CantidadAvisosPermitidosReemplazo
        End Get
        Set(ByVal value As Integer)
            CantidadAvisosPermitidosReemplazo = value
        End Set
    End Property

    Public Property _DtReemplazoFinal() As DataTable
        Get
            Return DtReemplazoFinal
        End Get
        Set(ByVal value As DataTable)
            DtReemplazoFinal = value
        End Set
    End Property

    Public Property _DtReemplazoDetalleSpot() As DataTable
        Get
            Return DtReemplazoDetalleSpot
        End Get
        Set(ByVal value As DataTable)
            DtReemplazoDetalleSpot = value
        End Set
    End Property

    Public Property _DtReemplazoSeleccionados() As DataTable
        Get
            Return DtReemplazoSeleccionados
        End Get
        Set(ByVal value As DataTable)
            DtReemplazoSeleccionados = value
        End Set
    End Property

    Public Property _DtReemplazoAvisosEliminar() As DataTable
        Get
            Return DtReemplazoAvisosEliminar
        End Get
        Set(ByVal value As DataTable)
            DtReemplazoAvisosEliminar = value
        End Set
    End Property

    Public Property _ReemplazoTemasTipoObjetivo() As Integer
        Get
            Return ReemplazoTemasTipoObjetivo
        End Get
        Set(ByVal value As Integer)
            ReemplazoTemasTipoObjetivo = value
        End Set
    End Property

    Public Property _ReemplazoFDesde() As Date
        Get
            Return ReemplazoFDesde
        End Get
        Set(ByVal value As Date)
            ReemplazoFDesde = value
        End Set
    End Property

    Public Property _ReemplazoFHasta() As Date
        Get
            Return DistribuidorFHasta
        End Get
        Set(ByVal value As Date)
            ReemplazoFHasta = value
        End Set
    End Property

    Public Property _ReemplazarCancelar() As Boolean
        Get
            Return ReemplazarCancelar
        End Get
        Set(ByVal value As Boolean)
            ReemplazarCancelar = value
        End Set
    End Property

    '===========================================================

    'AG Propiedades para proceso de DISTRIBUCION de PASES ======
    Public Property _DistribuidorValorObjetivo() As Double
        Get
            Return DistribuidorValorObjetivo
        End Get
        Set(ByVal value As Double)
            DistribuidorValorObjetivo = value
        End Set
    End Property

    Public Property _DistribuidorValorAvisos() As Integer
        Get
            Return DistribuidorValorAvisos
        End Get
        Set(ByVal value As Integer)
            DistribuidorValorAvisos = value
        End Set
    End Property

    Public Property _DistribuidorTipoObjetivo() As Integer
        Get
            Return DistribuidorTipoObjetivo
        End Get
        Set(ByVal value As Integer)
            DistribuidorTipoObjetivo = value
        End Set
    End Property


    Public Property _DistribuidorTipoFranja() As Integer
        Get
            Return DistribuidorTipoFranja
        End Get
        Set(ByVal value As Integer)
            DistribuidorTipoFranja = value
        End Set
    End Property

    Public Property _DtDistribuidorSoporte() As DataTable
        Get
            Return DtDistribuidorSoporte
        End Get
        Set(ByVal value As DataTable)
            DtDistribuidorSoporte = value
        End Set
    End Property

    Public Property _DtDistribuidorTemas() As DataTable
        Get
            Return DtDistribuidorTemas
        End Get
        Set(ByVal value As DataTable)
            DtDistribuidorTemas = value
        End Set
    End Property

    Public Property _DtSoporteHoja() As DataTable
        Get
            Return DtSoporteHoja
        End Get
        Set(ByVal value As DataTable)
            DtSoporteHoja = value
        End Set
    End Property


    Public Property _DtTemasCampania() As DataTable
        Get
            Return DtTemasCampania
        End Get
        Set(ByVal value As DataTable)
            DtTemasCampania = value
        End Set
    End Property

    Public Property _DistribuidorConjunto() As DataTable
        Get
            Return DistribuidorConjunto
        End Get
        Set(ByVal value As DataTable)
            DistribuidorConjunto = value
        End Set
    End Property

    Public Property _DistribuidorFDesde() As Date
        Get
            Return DistribuidorFDesde
        End Get
        Set(ByVal value As Date)
            DistribuidorFDesde = value
        End Set
    End Property

    Public Property _DistribuidorFHasta() As Date
        Get
            Return DistribuidorFHasta
        End Get
        Set(ByVal value As Date)
            DistribuidorFHasta = value
        End Set
    End Property

    Public Property _DistribuidorCancelar() As Boolean
        Get
            Return DistribuidorCancelar
        End Get
        Set(ByVal value As Boolean)
            DistribuidorCancelar = value
        End Set
    End Property

    '============================================================

    'AG 26/04/2010 Auspicio -----------------------------
    Public Property DtTemasUtilizados() As DataTable
        Get
            Return dtTemas
        End Get
        Set(ByVal value As DataTable)
            dtTemas = value
        End Set
    End Property

    Public Property ControlTipoAuspicio() As Integer
        Get
            Return mControlTipoAuspicio
        End Get
        Set(ByVal value As Integer)
            mControlTipoAuspicio = value
        End Set
    End Property

    Public Property DtAuspicio() As DataTable
        Get
            Return DtAuspicios
        End Get
        Set(ByVal value As DataTable)
            DtAuspicios = value
        End Set
    End Property

    Public Property ImporteAuspicioTema() As Double
        Get
            Return _ImporteAuspicioTema
        End Get
        Set(ByVal value As Double)
            _ImporteAuspicioTema = value
        End Set
    End Property

    Public Property MontoBrutoAuspicio() As Double
        Get
            Return _MontoBrutoAuspicio
        End Get
        Set(ByVal value As Double)
            _MontoBrutoAuspicio = value
        End Set
    End Property

    Public Property row() As DataRow
        Get
            Return _row
        End Get
        Set(ByVal value As DataRow)
            _row = value
        End Set
    End Property

    Public Function CargarGrilla(ByVal IDCliente As Int32, ByVal IDMedio As Int32, ByVal FechaVigIn As Date, ByVal FechaVigFin As Date, ByVal IDSistema As Int32, Optional ByVal Tipo As TipoAudiencia = TipoAudiencia.Abierta, Optional ByVal Soportes As ArrayList = Nothing, Optional ByVal Temas As ArrayList = Nothing) As Boolean
        Application.DoEvents()
        frmProgresoCargaGrilla.Instancia.Max1 = 5

        Try

            Inicio = Date.Now
            Ejer.IDCampaña = Activo.IDCampaña
            Ejer.IDSistema = IDSistema
            Ejer.IDEjercicio = Activo.IDEjercicio

            Dim Te As New Temas
            dtTemas.CaseSensitive = True
            Te.Id_campania = Activo.IDCampaña
            dtTemas = Te.ObtenerTemasPorCampaña(True) 'AN CAMBIO PARA QUE TRAIGA SOLO LOS TEMAS DEL MEDIO.

            'Filtro de Temas seleccionados
            If IDMedio = MedioRadio Then
                Dim TemasFiltrados As DataTable = dtTemas.Clone
                If Not Temas Is Nothing Then
                    Dim Filtro As StringBuilder
                    Dim Tema As ItemLista

                    For IndexTema As Integer = 0 To Temas.Count - 1
                        Tema = Temas(IndexTema)
                        Filtro = New StringBuilder
                        Filtro.Append("Id_Tema = '")
                        Filtro.Append(Tema.ID)
                        Filtro.Append("'")
                        For Each drTemas As DataRow In dtTemas.Select(Filtro.ToString)
                            TemasFiltrados.ImportRow(drTemas)
                        Next
                    Next

                    dtTemas = TemasFiltrados
                Else
                    TemasFiltrados = Te.ObtenerTemasExistentes(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
                    If Not TemasFiltrados Is Nothing AndAlso TemasFiltrados.Rows.Count > 0 Then
                        dtTemas = TemasFiltrados
                    End If
                End If
            End If

            'Activo.Producto = GrillAdmin.ObtenerDato(dtTemas, "id_producto=" & Te.Id_producto, "Descripcion")

            'En este datat set se guardan los datos de de tarifas_tv de
            Dim DsTarifas As New DataSet '*************
            Dim S As New Spots, Dt As New DataTable("Tarifas")
            Dim Si As New Sistemas
            Dim TipoRating As String
            Dim Ej As New Ejercicios
            Dim ta As New Targets
            Dim pl As New Plazas
            Dim Tar() As DataRow



            Ej.Id_campania = Activo.IDCampaña
            Ej.Id_sistema = Activo.IDSistema
            Ej.Id_ejercicio = Activo.IDEjercicio

            Ej.BuscarPorID()

            Activo.Estado = Ej.Id_ejercicio_est

            'AG 05/06/2014 ========================
            Activo.IDTipoEjercicio = Ej.IDTipoEjercicio
            '======================================

            '*** AGREGADO DE ESTEBAN, mantengo una copia de los 
            'soportes para los calculos de los cuadros de desglose
            AuxSoportes = Soportes

            Si.Id_campania = Activo.IDCampaña
            Si.Id_sistema = Activo.IDSistema
            Si.BuscarPorID()

            'Activo.Target = GrillAdmin.ObtenerDato(ta.TraerTodos(Activo.IDTipoSoporte), "id_target=" & Si.Id_target_1, "descripcion")

            Tar = ta.TraerTodos(Activo.IDTipoSoporte).Select("id_target=" & Si.Id_target_1)

            'ta.BuscarPorID()

            If Tar.Length = 0 And IDMedio = MedioRadio Then
                Tar = ta.TraerTodos(Activo.IDTipoSoporte).Select("id_target=0")
            End If

            Activo.Target = Tar(0)("descripcion")

            Tar = pl.TraerTodos.Select("Id_Plaza=" & Activo.IDPlaza)

            Activo.Plaza = Tar(0)("descripcion")

            '*** AGREGAR ESTEBAN, guarda el idfranja para saber que franjas detalle traer
            Me.IDFranja = Si.Id_date_part
            '***

            Target = Si.Id_target_1
            TipoDeRating = Si.Tipo_rating

            Deflactacion = Si.Deflactacion

            'para que quede en el activo ya que si no se hace click en la solapa de sistema, no se carga.
            Activo.FechaInicioAudiencia = Si.F_inicio_aud
            Activo.FechaFinAudiencia = Si.F_fin_aud
            Activo.FechaInicioSistema = Si.F_inicio
            Activo.FechaFinSistema = Si.F_fin

            S.Id_campania = Activo.IDCampaña
            S.Id_sistema = Activo.IDSistema
            S.Id_ejercicio = Activo.IDEjercicio

            'Segun el tipo de rating, definimos el nombre de las columnas de rating
            If Si.Tipo_rating = "P" Then
                GrillAdmin = New GrillAdmin("rat_prog_target_1", "rat_prog_target_2")
            Else
                If Tipo = TipoAudiencia.Cable Or Tipo = TipoAudiencia.Intetior Then
                    GrillAdmin = New GrillAdmin("rat_prog_target_1", "rat_prog_target_2")
                Else
                    GrillAdmin = New GrillAdmin("rat_tanda_target_1", "rat_tanda_target_2")
                End If
            End If

            Dim Grilla As DataTable
            Dim dsSpots As DataSet
            'Dim TempSpots As DataTable

            Dim Sd As New Spots_detalle

            TempSpots = S.ObtenerSpots

            If TempSpots.Rows.Count > 0 Then
                frmProgresoCargaGrilla.Instancia.Incrementar(1)
                dsSpots = CargarSpotsExistentes(TempSpots, Tipo)
                Application.DoEvents()
                ' iugEjercicio.DisplayLayout.LoadStyle = LoadStyle.LoadOnDemand
                Me.iugEjercicio.DataSource = GrillAdmin.ObtenerUltraDataSource(dsSpots.Tables("grid"), dsSpots.Tables("detalle"), dtTemas, Sd.ObtenerSpotDetalle(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio))
                Me.dtComprados = GrillAdmin.ComprasNumeros
                Application.DoEvents()
                Me.UltraDataSource1 = iugEjercicio.DataSource
                Application.DoEvents()
                CambiarFormatoTVA()
                'AG 09/05/2011 = Control Convenio Igual -1 marcar color fonde celda ++++++++++
                For Each r As UltraGridRow In iugEjercicio.Rows
                    If IsDBNull(r.Cells("id_convenio").Value) Then
                        r.Cells("dcto1").Appearance.BackColor = Color.Bisque   'White
                        r.Cells("dcto2").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto3").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto4").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto5").Appearance.BackColor = Color.Bisque
                    ElseIf r.Cells("id_convenio").Value = 0 Then
                        r.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                        r.Cells("dcto2").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto3").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto4").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto5").Appearance.BackColor = Color.Bisque
                    ElseIf r.Cells("id_convenio").Value = -1 Then
                        r.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                        r.Cells("dcto2").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto3").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto4").Appearance.BackColor = Color.Bisque
                        r.Cells("dcto5").Appearance.BackColor = Color.Bisque
                    ElseIf r.Cells("id_convenio").Value > 0 Then
                        r.Cells("dcto1").Appearance.BackColor = Color.White
                        r.Cells("dcto2").Appearance.BackColor = Color.White
                        r.Cells("dcto3").Appearance.BackColor = Color.White
                        r.Cells("dcto4").Appearance.BackColor = Color.White
                        r.Cells("dcto5").Appearance.BackColor = Color.White
                    End If
                Next
                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Else
                frmProgresoCargaGrilla.Instancia.Incrementar(1)
                EsCargaDeCero = True
                Grilla = CargarTarifas(Soportes, Activo.IDMedio, Activo.IDSistema, Tipo)

                If ErrorNautilus Then
                    Activo.EjerciciosCargados.Remove(Ejer)
                    frmProgresoCargaGrilla.Instancia.Close()
                    Return False
                End If

                Application.DoEvents()

                Me.iugEjercicio.DataSource = GrillAdmin.ObtenerUltraDataSource(Grilla, "BandaSpot", True)

                Application.DoEvents()
                Me.UltraDataSource1 = iugEjercicio.DataSource
                Application.DoEvents()
                CambiarFormatoTVA()
            End If

            'AG Velocidad =====================================================
            'CargarCubo(TempSpots.Copy(), DetalleBase.Copy(), Franjas.Copy(), False)
            '==================================================================

            Select Case Tipo
                Case TipoAudiencia.Abierta
                    Listas.OcultarColumnas(iugEjercicio, "id", "ID_SPOT", "ID_TARIFA_TV", "id_convenio", "ID_PROGRAMA", "ID_Soporte", "Tipo_Planificacion", "f_fin_vig", "f_inicio_vig", "desc_campania", "desc_sistema", "desc_ejercicio") ', "f_modi", "u_modi") ', "u_accion", "f_accion")
                    TipoRating = Si.Tipo_rating
                    TipoDeAudiencia = TipoAudiencia.Abierta

                Case TipoAudiencia.Cable
                    Listas.OcultarColumnas(iugEjercicio, "id", "ID_SPOT", "ID_TARIFA_TV", "id_convenio", "ID_PROGRAMA", "ID_Soporte", "Tipo_Planificacion", "f_fin_vig", "f_inicio_vig", "desc_campania", "desc_sistema", "desc_ejercicio") ', "f_modi", "u_modi") ', "u_accion", "f_accion")
                    TipoRating = "CI"
                    TipoDeAudiencia = TipoAudiencia.Cable

                Case TipoAudiencia.Intetior
                    Listas.OcultarColumnas(iugEjercicio, "id", "ID_SPOT", "ID_TARIFA_TV", "id_convenio", "ID_PROGRAMA", "ID_Soporte", "Tipo_Planificacion", "f_fin_vig", "f_inicio_vig", "desc_campania", "desc_sistema", "desc_ejercicio") ', "f_modi", "u_modi") ', "u_accion", "f_accion")
                    TipoRating = "CI"
                    TipoDeAudiencia = TipoAudiencia.Intetior

                Case TipoAudiencia.Satelital
                    Listas.OcultarColumnas(iugEjercicio, "id", "ID_SPOT", "ID_TARIFA_TV", "id_convenio", "ID_PROGRAMA", "ID_Soporte", "Tipo_Planificacion", "f_fin_vig", "f_inicio_vig", "desc_campania", "desc_sistema", "desc_ejercicio") ', "f_modi", "u_modi") ', "u_accion", "f_accion")
                    TipoRating = "CI"
                    TipoDeAudiencia = TipoAudiencia.Satelital
            End Select

            TitulosFechas(0)

            Listas.OcultarHeader(iugEjercicio)
            '---------
            GrillAdmin.ModificarColumnasHijas(Me.iugEjercicio, True)

            iugEjercicio.DisplayLayout.Override.DefaultColWidth = 50

            ColumnasAOcultar = Me.ObtenerColumnasAOcultar(TipoRating, Si.Id_target_2)

            For Each C As String In ColumnasAOcultar
                iugEjercicio.DisplayLayout.Bands(0).Columns(C).Hidden = True

                Select Case TipoRating
                    Case "CI"
                        If C.IndexOf("RAT") > -1 And C.IndexOf("PROG") > -1 And C.IndexOf("RAT_M") < 0 Or C.IndexOf("brutoactual") > -1 Then
                            Me.mnuColumnasOcultas.MenuItems.Add(iugEjercicio.DisplayLayout.Bands(0).Columns(C).Header.Caption, AddressOf ClickEnMenu)
                            Me.ColumnasBorradas.Add(iugEjercicio.DisplayLayout.Bands(0).Columns(C).Header.Caption, C)
                        End If
                    Case "P", "T"
                        Me.mnuColumnasOcultas.MenuItems.Add(iugEjercicio.DisplayLayout.Bands(0).Columns(C).Header.Caption, AddressOf ClickEnMenu)
                        Me.ColumnasBorradas.Add(iugEjercicio.DisplayLayout.Bands(0).Columns(C).Header.Caption, C)
                End Select

            Next

            GrillaFormato.ReocultarColumnasHijos(iugEjercicio)

            iugEjercicio.DisplayLayout.Override.CellClickAction = CellClickAction.CellSelect

            GrillaFormato.MoverColumnaTema(iugEjercicio, 4)

            'calcula los cuadros de desglose / resumen
            PrepararResumenes()

            'Me.iugEjercicio.Rows(0).Cells("Soporte").Activated = True

            'Carga de Temas para cada programa
            If IDMedio = MedioRadio Then
                For IndexItem As Integer = mnuColumnasOcultas.MenuItems.Count - 1 To 1 Step -1
                    mnuColumnasOcultas.MenuItems.RemoveAt(IndexItem)
                Next
                CargarTemasHijos()
            End If

            'AG Hoja Numero ========================================================
            If Activo.IDMedio = MedioTv Then
                For Index As Integer = 1 To iugEjercicio.DisplayLayout.Bands.Count - 1
                    TitulosFechas(Index)
                Next
            End If
            '==============================================================================

            frmProgresoCargaGrilla.Instancia.Incrementar(1)



            Return True
        Catch ex As ApplicationException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Everest")
        End Try
    End Function

    Private Sub LoadPivot()
        CargarCubo(TempSpots.Copy(), DetalleBase.Copy(), Franjas.Copy(), False)
    End Sub

    Private Sub CargarCubo(ByVal spots As DataTable, ByVal spotsDetalles As DataTable, ByVal Franjas As DataTable, ByVal saveLayout As Boolean)

        'ESTAS SON LAS FRANJAS OK. (AN 23-11-2015)
        Dim F As New Franjas_Detalle
        Franjas = F.ObtenerPorCliente(Activo.IDCliente, Me.IDFranja).Copy()

        pivotLoading = True
        spots.TableName = "SPOTS"
        spotsDetalles.TableName = "SPOTSDETALLES"
        Franjas.TableName = "FRANJAS"

        ' Datos sin guardar para el cubo
        Dim datos = New DataSet
        datos.Tables.Add(spots)
        datos.Tables.Add(spotsDetalles)
        datos.Tables.Add(Franjas)

        Dim relacion As New DataRelation("Relacion", spots.Columns("ID_SPOT"), spotsDetalles.Columns("ID_SPOT"))
        datos.Relations.Add(relacion)

        Dim s As New Sistemas
        s.Id_campania = Activo.IDCampaña
        s.Id_sistema = Activo.IDSistema
        s.BuscarPorID()

        Me.pivotFlex.Enabled = False
        Me.pivotFlex.LoadPivot(datos, s.Tipo_rating, s.F_inicio, "pivotDock")
        Me.pivotFlex.Enabled = True
        Me.pivotFlex.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pivotFlex.LookAndFeel.SkinName = "iMaginary"

        If saveLayout Then
            Me.pivotFlex.SaveLayout("pivotDock")
        End If

        pivotLoading = False
    End Sub

    Private Function CargarSpotsExistentes(ByVal DatosSpots As DataTable, ByVal TipoCarga As TipoAudiencia) As DataSet
        Dim Si As New Sistemas
        Dim Sd As New Spots_detalle
        Dim Detalles As New DataTable("detalle")
        Dim DsSpots As New DataSet
        Si.Id_campania = Activo.IDCampaña
        Si.Id_sistema = Activo.IDSistema
        Si.BuscarPorID()

        Dim t As New Tarifas_tv
        Dim dsEstructura As DataSet = ArmarEstructura(Si.F_inicio, Si.F_fin, Si)
        Dim Spot As New Spots

        'trae los soportes
        Spot.Id_campania = Activo.IDCampaña
        Spot.Id_sistema = Activo.IDSistema
        Spot.Id_ejercicio = Activo.IDEjercicio
        Spot.Id_Medio = Activo.IDMedio

        Dim Dr As DataRow
        Dim Soportes As DataTable = Spot.ObtenerSoportesGuardados

        '*** AGREGADO ESTEBAN, mantengo una copia de los soportes, 
        'para el calculo de los cuadros de desglose
        AuxSoportes = Soportes
        SoportesActualizados = Me.PasarSoportes(Soportes)

        frmProgresoCargaGrilla.Instancia.Incrementar(1)

        Dim dts As DataTable = PasarSpotsGrilla(DatosSpots, dsEstructura.Tables("Grid"))  'DsDias.Tables(0)).Copy


        If AvisosEspeciales.Count > 0 Then
            DtAfectados = Me.ObtenerAfectadosEspeciales(DatosSpots, AvisosEspeciales)
        End If

        Detalles = ModificarDetalleLOG(Sd.ObtenerSpotDetalle(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio))


        DetalleBase = Detalles.Copy
        DetalleBase.TableName = "Detalle"

        frmProgresoCargaGrilla.Instancia.Incrementar(1)

        Detalles = AgregarCamposDetalle(dts, Detalles, Si.F_inicio, Si.F_fin)

        DsSpots.Tables.Add(dts.Copy)

        DsSpots.Tables.Add(Detalles)

        SpotBase = DatosSpots.Copy

        Return DsSpots
    End Function
    Private Function ModificarDetalleLOG(ByVal dt As DataTable) As DataTable
        For Each r As DataRow In dt.Rows
            r("u_modi") = Activo.Login
            r("f_modi") = Today.Today
            dt.AcceptChanges()
        Next
        Return dt
    End Function
    Private Function PasarSoportes(ByVal Dt As DataTable) As ArrayList
        Dim arr As New ArrayList
        Dim item As ItemLista
        For Each dr As DataRow In Dt.Rows
            item = New ItemLista
            item.ID = dr("ID_SOPORTE")
            If dr("DESCRIPCION").ToString() = String.Empty Then
                item.Descripcion = ""
            Else
                item.Descripcion = dr("DESCRIPCION")
            End If
            arr.Add(item)
        Next
        Return arr
    End Function
    Private Function CargarDatosLog(ByVal Spots As DataTable) As DataTable

        For Each dr As DataRow In Spots.Rows
            dr("desc_campania") = Activo.Campaña
            dr("desc_sistema") = Activo.Sistema
            dr("desc_ejercicio") = Activo.Ejercicio

            'Esteban, cambia los estados de las filas a UnChanged (porque cuando se agregan las descripciones
            'no deberia tildar las filas como modificadas
            dr.AcceptChanges()
        Next

        Return Spots
    End Function
    Private Sub CambiarFormatoTVA()

        GrillaFormato.WarpHeader(iugEjercicio, DefaultableBoolean.True)

        Listas.CambiarTituloColumna(iugEjercicio, "PROGRAMA", "Programa")
        Listas.CambiarTituloColumna(iugEjercicio, "H_INICIO", "Hs. Inicio")
        Listas.CambiarTituloColumna(iugEjercicio, "H_FIN", "Hs. Fin")

        Listas.CambiarTituloColumna(iugEjercicio, "BRUTO", "Bruto Actual")
        Listas.CambiarTituloColumna(iugEjercicio, "brutoactual", "Tarifa Bruta")
        Listas.CambiarTituloColumna(iugEjercicio, "NETO", "Tarifa" & vbCrLf & "Neta")
        Listas.CambiarTituloColumna(iugEjercicio, "DCTO1", "D1")
        Listas.CambiarTituloColumna(iugEjercicio, "DCTO2", "D2")
        Listas.CambiarTituloColumna(iugEjercicio, "DCTO3", "D3")
        Listas.CambiarTituloColumna(iugEjercicio, "DCTO4", "D4")
        Listas.CambiarTituloColumna(iugEjercicio, "DCTO5", "D5")
        Listas.CambiarTituloColumna(iugEjercicio, "RAT_PROG_TARGET_1", "RAT % P")
        Listas.CambiarTituloColumna(iugEjercicio, "SHR_PROG_TARGET_1", "SHR P")
        Listas.CambiarTituloColumna(iugEjercicio, "AFF_PROG_TARGET_1", "AFF P")
        Listas.CambiarTituloColumna(iugEjercicio, "RCH_PROG_TARGET_1", "RCH P")
        Listas.CambiarTituloColumna(iugEjercicio, "RAT_M_PROG_TARGET_1", "RAT M P")
        Listas.CambiarTituloColumna(iugEjercicio, "FID_PROG_TARGET_1", "FID P")

        Listas.CambiarTituloColumna(iugEjercicio, "RAT_PROG_TARGET_2", "RAT % P 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "SHR_PROG_TARGET_2", "SHR P 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "AFF_PROG_TARGET_2", "AFF P 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "RCH_PROG_TARGET_2", "RCH P 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "RAT_M_PROG_TARGET_2", "RAT M P 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "FID_PROG_TARGET_2", "FID P 2º")

        Listas.CambiarTituloColumna(iugEjercicio, "RAT_TANDA_TARGET_1", "RAT % T")
        Listas.CambiarTituloColumna(iugEjercicio, "SHR_TANDA_TARGET_1", "SHR T")
        Listas.CambiarTituloColumna(iugEjercicio, "AFF_TANDA_TARGET_1", "AFF T")
        Listas.CambiarTituloColumna(iugEjercicio, "RCH_TANDA_TARGET_1", "RCH T")
        Listas.CambiarTituloColumna(iugEjercicio, "RAT_M_TANDA_TARGET_1", "RAT M T")
        Listas.CambiarTituloColumna(iugEjercicio, "FID_TANDA_TARGET_1", "FID T")

        Listas.CambiarTituloColumna(iugEjercicio, "RAT_TANDA_TARGET_2", "RAT % T 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "SHR_TANDA_TARGET_2", "SHR T 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "AFF_TANDA_TARGET_2", "AFF T 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "RCH_TANDA_TARGET_2", "RCH T 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "RAT_M_TANDA_TARGET_2", "RAT M T 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "FID_TANDA_TARGET_2", "FID T 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "Total GRP Target 1", "GRPs")
        Listas.CambiarTituloColumna(iugEjercicio, "Total GRP Target 2", "GRPs 2º")
        Listas.CambiarTituloColumna(iugEjercicio, "Afinidad", "AFF.T1/T2")
        Listas.CambiarTituloColumna(iugEjercicio, "Total Spots", "Spots")
        Listas.CambiarTituloColumna(iugEjercicio, "Total Bruto", "Inv. Bruta")
        Listas.CambiarTituloColumna(iugEjercicio, "Total Neto", "Inv. Neta")

        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "Bruto", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "Neto", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "brutoactual", Formato.Moneda)

        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "DCTO1", Formato.General)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "DCTO2", Formato.General)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "DCTO3", Formato.General)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "DCTO4", Formato.General)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "DCTO5", Formato.General)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "Total Bruto", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "Total Neto", Formato.Moneda)

        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "Total GRP Target 1", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "Total GRP Target 2", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "Afinidad", Formato.Decimales)

        GrillaFormato.CambiarFormatoColumna(iugEjercicio, "CPR", Formato.Moneda)

        GrillaFormato.CambiarAlineacionColumna(iugEjercicio, HAlign.Right)

        GrillaFormato.CambiarAlineacionColumna(iugEjercicio, "H_Inicio", HAlign.Right)
        GrillaFormato.CambiarAlineacionColumna(iugEjercicio, "H_Fin", HAlign.Right)

        GrillaFormato.HabilitarSumatoria(iugEjercicio, "BRUTO", "brutoactual", "Neto", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2", "CPR", "DUR")
        GrillaFormato.HabilitarSumatoria(iugEjercicio, "RAT_PROG_TARGET_1", "SHR_PROG_TARGET_1", "AFF_PROG_TARGET_1", "RCH_PROG_TARGET_1", "RAT_M_PROG_TARGET_1", "FID_PROG_TARGET_1")
        GrillaFormato.HabilitarSumatoria(iugEjercicio, "RAT_PROG_TARGET_2", "SHR_PROG_TARGET_2", "AFF_PROG_TARGET_2", "RCH_PROG_TARGET_2", "RAT_M_PROG_TARGET_2", "FID_PROG_TARGET_2")
        GrillaFormato.HabilitarSumatoria(iugEjercicio, "RAT_TANDA_TARGET_1", "SHR_TANDA_TARGET_1", "AFF_TANDA_TARGET_1", "RCH_TANDA_TARGET_1", "RAT_M_TANDA_TARGET_1", "FID_TANDA_TARGET_1")
        GrillaFormato.HabilitarSumatoria(iugEjercicio, "RAT_TANDA_TARGET_2", "SHR_TANDA_TARGET_2", "AFF_TANDA_TARGET_2", "RCH_TANDA_TARGET_2", "RAT_M_TANDA_TARGET_2", "FID_TANDA_TARGET_2", "CPR", "Afinidad")

        'GrillaFormato.CambiarColorLinea(iugEjercicio, Color.Blue, "Programa", "bruto", "dias", "shr_prog_target_1", "shr_Tanda_target_1", "shr_prog_target_2", "shr_Tanda_target_2")
        GrillaFormato.CambiarColorTextoHeader(iugEjercicio, Color.Blue, "dias", "soporte", "H_Inicio", "H_Fin", "Total Bruto", "Total Neto", "Total Spots", "Total GRP Target 1", "Total GRP Target 2", "brutoactual", "CPR", "Dur")

        GrillaFormato.AcivarOperacion(iugEjercicio, "Total Bruto", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn)
        GrillaFormato.AcivarOperacion(iugEjercicio, "Total Neto", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn)
        GrillaFormato.AcivarOperacion(iugEjercicio, "Total Spots", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn)
        GrillaFormato.AcivarOperacion(iugEjercicio, "Total GRP Target 1", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn)
        GrillaFormato.AcivarOperacion(iugEjercicio, "Total GRP Target 2", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn)

        GrillaFormato.HabilitarFiltro(iugEjercicio, DefaultableBoolean.True)

        GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, 0, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")

        GrillaFormato.AcivarOperacion(iugEjercicio)
        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit, "brutoactual", "dias", "Dur", "CPR", "soporte", "H_Inicio", "H_Fin", "Total Bruto", "Total Neto", "Total Spots", "Total GRP Target 1", "Total GRP Target 2")

        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit, "SHR_PROG_TARGET_1", "AFF_PROG_TARGET_1", "RCH_PROG_TARGET_1", "RAT_M_PROG_TARGET_1", "FID_PROG_TARGET_1")
        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit, "SHR_PROG_TARGET_2", "AFF_PROG_TARGET_2", "RCH_PROG_TARGET_2", "RAT_M_PROG_TARGET_2", "FID_PROG_TARGET_2")
        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit, "SHR_TANDA_TARGET_1", "AFF_TANDA_TARGET_1", "RCH_TANDA_TARGET_1", "RAT_M_TANDA_TARGET_1", "FID_TANDA_TARGET_1")
        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit, "SHR_TANDA_TARGET_2", "AFF_TANDA_TARGET_2", "RCH_TANDA_TARGET_2", "RAT_M_TANDA_TARGET_2", "FID_TANDA_TARGET_2", "Afinidad")


        GrillaFormato.HabilitarFijado(iugEjercicio, FixedHeaderIndicator.None)
        GrillaFormato.HabilitarFijado(iugEjercicio, FixedHeaderIndicator.None, "dcto1", "dcto2", "dcto3", "dcto4", "dcto5", "Afinidad", "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")

        'AG 07/05/2012 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        GrillaFormato.CambiarColorColumna(iugEjercicio, Color.Bisque, 0, "dcto1", "dcto2", "dcto3", "dcto4", "dcto5")
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        GrillaFormato.FijarColumna(iugEjercicio, True, "Soporte", "Programa")

        For Each b As UltraGridBand In iugEjercicio.DisplayLayout.Bands
            If b.Index > 0 Then
                GrillaFormato.FijarColumna(b.Columns("Tema"), True)

                GrillaFormato.FijarColumna(iugEjercicio.DisplayLayout.Bands(b.Index).Columns(b.Columns("tema").Index + 1), True)
                GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, b.Index, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")
            End If
        Next

        iugEjercicio.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
        iugEjercicio.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

        GrillaFormato.ExcluirColumnasOcultar(iugEjercicio, "Id", "ID_SPOT", "ID_TARIFA_TV", "id_convenio", "ID_PROGRAMA", "ID_Soporte", "Tipo_Planificacion", "f_fin_vig", "f_inicio_vig", "soporte", "programa", "dias", "h_inicio", "h_fin", "total neto")

        GrillaFormato.ExcluirColumnasOcultar(iugEjercicio)

        ColorSinAudiencia()

        'iugEjercicio.DisplayLayout.Bands(0).Columns("soporte").MergedCellStyle = MergedCellStyle.Always
        'iugEjercicio.DisplayLayout.Bands(0).Columns("programa").MergedCellStyle = MergedCellStyle.Always
    End Sub


    Private Function ObtenerColumnasAOcultar(ByVal Tipo As String, ByVal Target2 As Integer) As ArrayList
        Dim C As New ArrayList

        '   With S
        C.Add("brutoactual")
        C.Add("Afinidad")
        Select Case Tipo
            Case "P"
                If Target2 >= 0 Then
                    'Si elijo Programa y Tiene Target 2
                    C.Add("RAT_TANDA_TARGET_1")
                    C.Add("SHR_TANDA_TARGET_1")
                    C.Add("AFF_TANDA_TARGET_1")
                    C.Add("RCH_TANDA_TARGET_1")
                    C.Add("RAT_M_TANDA_TARGET_1")
                    C.Add("FID_TANDA_TARGET_1")

                    C.Add("RAT_TANDA_TARGET_2")
                    C.Add("SHR_TANDA_TARGET_2")
                    C.Add("AFF_TANDA_TARGET_2")
                    C.Add("RCH_TANDA_TARGET_2")
                    C.Add("RAT_M_TANDA_TARGET_2")
                    C.Add("FID_TANDA_TARGET_2")

                    C.Add("SHR_PROG_TARGET_1")
                    C.Add("AFF_PROG_TARGET_1")
                    C.Add("RCH_PROG_TARGET_1")
                    C.Add("RAT_M_PROG_TARGET_1")
                    C.Add("FID_PROG_TARGET_1")

                    C.Add("SHR_PROG_TARGET_2")
                    C.Add("AFF_PROG_TARGET_2")
                    C.Add("RCH_PROG_TARGET_2")
                    C.Add("RAT_M_PROG_TARGET_2")
                    C.Add("FID_PROG_TARGET_2")
                Else
                    C.Add("RAT_TANDA_TARGET_1")
                    C.Add("SHR_TANDA_TARGET_1")
                    C.Add("AFF_TANDA_TARGET_1")
                    C.Add("RCH_TANDA_TARGET_1")
                    C.Add("RAT_M_TANDA_TARGET_1")
                    C.Add("FID_TANDA_TARGET_1")

                    C.Add("RAT_TANDA_TARGET_2")
                    C.Add("SHR_TANDA_TARGET_2")
                    C.Add("AFF_TANDA_TARGET_2")
                    C.Add("RCH_TANDA_TARGET_2")
                    C.Add("RAT_M_TANDA_TARGET_2")
                    C.Add("FID_TANDA_TARGET_2")

                    C.Add("SHR_PROG_TARGET_1")
                    C.Add("AFF_PROG_TARGET_1")
                    C.Add("RCH_PROG_TARGET_1")
                    C.Add("RAT_M_PROG_TARGET_1")
                    C.Add("FID_PROG_TARGET_1")

                    C.Add("RAT_PROG_TARGET_2")
                    C.Add("SHR_PROG_TARGET_2")
                    C.Add("AFF_PROG_TARGET_2")
                    C.Add("RCH_PROG_TARGET_2")
                    C.Add("RAT_M_PROG_TARGET_2")
                    C.Add("FID_PROG_TARGET_2")
                End If
            Case "T"
                If Target2 >= 0 Then
                    'Si elijo Programa y Tiene Target 2

                    C.Add("SHR_TANDA_TARGET_1")
                    C.Add("AFF_TANDA_TARGET_1")
                    C.Add("RCH_TANDA_TARGET_1")
                    C.Add("RAT_M_TANDA_TARGET_1")
                    C.Add("FID_TANDA_TARGET_1")

                    C.Add("SHR_TANDA_TARGET_2")
                    C.Add("AFF_TANDA_TARGET_2")
                    C.Add("RCH_TANDA_TARGET_2")
                    C.Add("RAT_M_TANDA_TARGET_2")
                    C.Add("FID_TANDA_TARGET_2")

                    C.Add("RAT_PROG_TARGET_1")
                    C.Add("SHR_PROG_TARGET_1")
                    C.Add("AFF_PROG_TARGET_1")
                    C.Add("RCH_PROG_TARGET_1")
                    C.Add("RAT_M_PROG_TARGET_1")
                    C.Add("FID_PROG_TARGET_1")

                    C.Add("RAT_PROG_TARGET_2")
                    C.Add("SHR_PROG_TARGET_2")
                    C.Add("AFF_PROG_TARGET_2")
                    C.Add("RCH_PROG_TARGET_2")
                    C.Add("RAT_M_PROG_TARGET_2")
                    C.Add("FID_PROG_TARGET_2")
                Else
                    C.Add("SHR_TANDA_TARGET_1")
                    C.Add("AFF_TANDA_TARGET_1")
                    C.Add("RCH_TANDA_TARGET_1")
                    C.Add("RAT_M_TANDA_TARGET_1")
                    C.Add("FID_TANDA_TARGET_1")

                    C.Add("RAT_TANDA_TARGET_2")
                    C.Add("SHR_TANDA_TARGET_2")
                    C.Add("AFF_TANDA_TARGET_2")
                    C.Add("RCH_TANDA_TARGET_2")
                    C.Add("RAT_M_TANDA_TARGET_2")
                    C.Add("FID_TANDA_TARGET_2")

                    C.Add("RAT_PROG_TARGET_1")
                    C.Add("SHR_PROG_TARGET_1")
                    C.Add("AFF_PROG_TARGET_1")
                    C.Add("RCH_PROG_TARGET_1")
                    C.Add("RAT_M_PROG_TARGET_1")
                    C.Add("FID_PROG_TARGET_1")

                    C.Add("RAT_PROG_TARGET_2")
                    C.Add("SHR_PROG_TARGET_2")
                    C.Add("AFF_PROG_TARGET_2")
                    C.Add("RCH_PROG_TARGET_2")
                    C.Add("RAT_M_PROG_TARGET_2")
                    C.Add("FID_PROG_TARGET_2")
                End If
            Case "CI"
                If Target2 >= 0 Then
                    'Si elijo Cable y Tiene Target 2
                    ' C.Add("RAT_PROG_TARGET_1")
                    C.Add("SHR_PROG_TARGET_1")
                    C.Add("AFF_PROG_TARGET_1")
                    C.Add("RCH_PROG_TARGET_1")
                    C.Add("RAT_M_PROG_TARGET_1")
                    C.Add("FID_PROG_TARGET_1")

                    C.Add("RAT_TANDA_TARGET_1")
                    C.Add("SHR_TANDA_TARGET_1")
                    C.Add("AFF_TANDA_TARGET_1")
                    C.Add("RCH_TANDA_TARGET_1")
                    C.Add("RAT_M_TANDA_TARGET_1")
                    C.Add("FID_TANDA_TARGET_1")

                    ' C.Add("RAT_PROG_TARGET_2")
                    C.Add("SHR_PROG_TARGET_2")
                    C.Add("AFF_PROG_TARGET_2")
                    C.Add("RCH_PROG_TARGET_2")
                    C.Add("RAT_M_PROG_TARGET_2")
                    C.Add("FID_PROG_TARGET_2")

                    C.Add("RAT_TANDA_TARGET_2")
                    C.Add("SHR_TANDA_TARGET_2")
                    C.Add("AFF_TANDA_TARGET_2")
                    C.Add("RCH_TANDA_TARGET_2")
                    C.Add("RAT_M_TANDA_TARGET_2")
                    C.Add("FID_TANDA_TARGET_2")

                Else
                    'C.Add("RAT_PROG_TARGET_1")
                    C.Add("SHR_PROG_TARGET_1")
                    C.Add("AFF_PROG_TARGET_1")
                    C.Add("RCH_PROG_TARGET_1")
                    C.Add("RAT_M_PROG_TARGET_1")
                    C.Add("FID_PROG_TARGET_1")

                    C.Add("RAT_TANDA_TARGET_1")
                    C.Add("SHR_TANDA_TARGET_1")
                    C.Add("AFF_TANDA_TARGET_1")
                    C.Add("RCH_TANDA_TARGET_1")
                    C.Add("RAT_M_TANDA_TARGET_1")
                    C.Add("FID_TANDA_TARGET_1")

                    C.Add("RAT_PROG_TARGET_2")
                    C.Add("SHR_PROG_TARGET_2")
                    C.Add("AFF_PROG_TARGET_2")
                    C.Add("RCH_PROG_TARGET_2")
                    C.Add("RAT_M_PROG_TARGET_2")
                    C.Add("FID_PROG_TARGET_2")

                    C.Add("RAT_TANDA_TARGET_2")
                    C.Add("SHR_TANDA_TARGET_2")
                    C.Add("AFF_TANDA_TARGET_2")
                    C.Add("RCH_TANDA_TARGET_2")
                    C.Add("RAT_M_TANDA_TARGET_2")
                    C.Add("FID_TANDA_TARGET_2")
                End If
        End Select
        ' End With
        Return C
    End Function
    Private Function AgregarCamposDetalle(ByVal Spots As DataTable, ByVal detalle As DataTable, ByVal Inicio As Date, ByVal Fin As Date) As DataTable
        Dim Sistema As New Sistemas
        Dim DtDetalle As New DataTable
        Dim Dias As Int32 = DateDiff(DateInterval.Day, Inicio, Fin)

        Dim i As Integer, Dia(8) As String
        With DtDetalle.Columns

            .Add("Id_Spot", Spots.Columns("id_spot").DataType)
            .Add("id_Spot_Detalle", GetType(Int64))
            .Add("F_Spot", GetType(Date))
            .Add("Duracion", GetType(Integer))
            .Add("ID_Tema", GetType(String))
            .Add("ID_TARIFA_TV", GetType(Long))
            .Add("id_convenio", GetType(Long))
            .Add("Tema", GetType(String))
            .Add("Tipo_Planificacion")
            .Add("soporte")
            '.Add("h_inicio")
            '.Add("h_fin")
            .Add("bruto")
            .Add("brutoactual")
            .Add("id")
            .Add("dcto1")
            .Add("dcto2")
            .Add("dcto3")
            .Add("dcto4")
            .Add("dcto5") '
            .Add("Neto", GetType(Single))

            .Add("desc_campania")
            .Add("desc_ejercicio")
            .Add("desc_sistema")

            ' .Add("f_modi", GetType(Date))
            '.Add("u_modi", GetType(String))

            .Add("f_inicio_vig")

            .Add("f_fin_vig")
            .Add("RAT_PROG_TARGET_1")
            .Add("SHR_PROG_TARGET_1")
            .Add("AFF_PROG_TARGET_1")
            .Add("RCH_PROG_TARGET_1")
            .Add("RAT_M_PROG_TARGET_1")
            .Add("FID_PROG_TARGET_1")

            .Add("RAT_TANDA_TARGET_1")
            .Add("SHR_TANDA_TARGET_1")
            .Add("AFF_TANDA_TARGET_1")
            .Add("RCH_TANDA_TARGET_1")
            .Add("RAT_M_TANDA_TARGET_1")
            .Add("FID_TANDA_TARGET_1")

            .Add("RAT_PROG_TARGET_2")
            .Add("SHR_PROG_TARGET_2")
            .Add("AFF_PROG_TARGET_2")
            .Add("RCH_PROG_TARGET_2")
            .Add("RAT_M_PROG_TARGET_2")
            .Add("FID_PROG_TARGET_2")

            .Add("RAT_TANDA_TARGET_2")
            .Add("SHR_TANDA_TARGET_2")
            .Add("AFF_TANDA_TARGET_2")
            .Add("RCH_TANDA_TARGET_2")
            .Add("RAT_M_TANDA_TARGET_2")
            .Add("FID_TANDA_TARGET_2")
            .Add("Afinidad", GetType(Single))
            .Add("CPR", GetType(Single))
            .Add("DUR", GetType(Integer))
            'Aff t1t2


            'aca se calculan los dias de duracion de camapña

            'Strings con las letras del c/dia
            Dia(1) = "L"
            Dia(2) = "M"
            Dia(3) = "X"
            Dia(4) = "J"
            Dia(5) = "V"
            Dia(6) = "S"
            Dia(7) = "D"
            'dim Te as New 
            For i = 0 To Dias
                .Add(DateAdd(DateInterval.Day, i, Inicio))
                Fechas.Add(Dia(DatePart(DateInterval.Weekday, DateAdd(DateInterval.Day, i, Inicio))) & " (" & DatePart(DateInterval.Day, DateAdd(DateInterval.Day, i, Inicio)) & ")")
                'Fechas.Add(Dia(DatePart(DateInterval.Weekday, DateAdd(DateInterval.Day, i, Inicio))) & vbCrLf & DatePart(DateInterval.Day, DateAdd(DateInterval.Day, i, Inicio)) & "/" & DatePart(DateInterval.Month, DateAdd(DateInterval.Day, i, Inicio)))
                'Fechas.Add(Dia(DatePart(DateInterval.Weekday, DateAdd(DateInterval.Day, i, FechaInicio), FirstDayOfWeek.Monday)) & vbCrLf & DatePart(DateInterval.Day, DateAdd(DateInterval.Day, i, FechaInicio)) & "/" & DatePart(DateInterval.Month, DateAdd(DateInterval.Day, i, FechaInicio), FirstDayOfWeek.Monday))
            Next

            .Add("Total Spots", GetType(Integer))
            Sistema.Id_campania = Activo.IDCampaña
            Sistema.Id_sistema = Activo.IDSistema


            Sistema.BuscarPorID()

            ' If Sistema.Id_target_1 >= 0 Then
            .Add("Total GRP Target 1", GetType(Single))
            ' En If

            'If Sistema.Id_target_2 >= 0 Then
            .Add("Total GRP Target 2", GetType(Single))
            'End If

            .Add("Total Bruto", GetType(Single))
            .Add("Total Neto", GetType(Single))




        End With

        Dim dr As DataRow
        Dim drd As DataRow


        For Each drd In detalle.Rows
            dr = DtDetalle.NewRow

            dr("Id_Spot") = drd("id_spot")
            dr("id_Spot_Detalle") = drd("id_spot_detalle")
            dr("F_Spot") = drd("F_Spot")
            dr("Duracion") = drd("Duracion")
            dr("ID_Tema") = drd("ID_Tema")
            'dr("f_modi") = Now.Today
            ' dr("u_modi") = Activo.Login


            DtDetalle.Rows.Add(dr)
        Next
        frmProgresoCargaGrilla.Instancia.Incrementar(1)
        DtDetalle.TableName = "detalle"

        Return DtDetalle
    End Function
    Private Function ObtenerAfinidad(ByVal Rat1 As Single, ByVal Rat2 As Single) As Single
        If Rat2 = 0 Or Rat1 = 0 Then
            Return 0
        End If
        Return Valores.Redondear((Rat1 / Rat2) * 100, "0.00")

    End Function
    Private Function PasarSpotsGrilla(ByVal Spots As DataTable, ByVal Grilla As DataTable) As DataTable
        Dim drS As DataRow
        Dim FilaGrid As DataRow
        Dim i As Integer, j As Integer
        Dim Spot As New Spots


        Dim S As New Soportes

        S.Id_plaza = Activo.IDPlaza
        S.Id_medio = Activo.IDMedio
        S.Id_tipo_soporte = Activo.IDTipoSoporte

        Dim soporte As String

        Dim t As New Tarifas_tv
        Dim dia As String
        Dim Canal As DataTable = S.ObtenerSoportes
        For Each drS In Spots.Rows
            Try
                FilaGrid = Grilla.NewRow

                FilaGrid("Soporte") = GrillAdmin.ObtenerDato(Canal, "ID_Soporte=" & drS("Id_Soporte"), "descripcion")
                t.Id_tarifa_tv = drS("Id_tarifa_tv")
                t.BuscarPorID()

                'AG Velicidad ===================================
                dia = t.ObtenerDia
                '===============================================

                'If Activo.IDTipoSoporte <> 3 Then
                If t.F_fin_vig > Activo.FechaInicioSistema Then
                    If t.EsEspecial > 0 Then
                        AvisosEspeciales.Add(drS("Id_Spot"))
                    End If
                End If
                ' End If

                FilaGrid("Id_Spot") = drS("Id_Spot")
                FilaGrid("Id_Programa") = drS("Id_Programa")
                FilaGrid("ID_Soporte") = drS("Id_Soporte")
                FilaGrid("id_tarifa_tv") = drS("Id_tarifa_tv")

                'AG 09/05/2011 +++++++++++++++++++++++++
                FilaGrid("id_convenio") = drS("id_convenio")
                '++++++++++++++++++++++++++++++++++++

                FilaGrid("desc_campania") = Activo.Campaña
                FilaGrid("desc_sistema") = Activo.Sistema
                FilaGrid("desc_ejercicio") = Activo.Ejercicio

                'ya que estamos recorriendo los spots para generar otro Dt 
                'cargo el Data Table SpotsBase, en vez de usar la funcion CargarDatosLog
                drS("desc_campania") = Activo.Campaña
                drS("desc_sistema") = Activo.Sistema
                drS("desc_ejercicio") = Activo.Ejercicio
                drS("u_alta") = Activo.Login
                drS("u_modi") = Activo.Login

                drS.AcceptChanges()
                '***

                'FilaGrid("Dias") = dia
                'FilaGrid("Soporte") = soporte
                FilaGrid("Dias") = ObtenerDiasSpots(t) 'dia 'AG Velocidad
                FilaGrid("brutoactual") = t.Bruto 't.ObtenerBruto 'AG Velocidad

                FilaGrid("Programa") = drS("Programa")
                FilaGrid("Tipo_Planificacion") = drS("Tipo_Planificacion")


                FilaGrid("h_inicio") = ObtenerHora(drS("h_inicio"), drS("m_inicio")) ' HoraInicio
                FilaGrid("h_fin") = ObtenerHora(drS("h_fin"), drS("m_fin")) 'HoraFin
                'Aff t1t2
                If drS(GrillAdmin.ColumnaRatingTarget1) Is DBNull.Value Or drS(GrillAdmin.ColumnaRatingTarget1) Is DBNull.Value Then
                    FilaGrid("Afinidad") = 0
                Else
                    FilaGrid("Afinidad") = Me.ObtenerAfinidad(drS(GrillAdmin.ColumnaRatingTarget1), drS(GrillAdmin.ColumnaRatingTarget2))
                End If


                FilaGrid("f_inicio_vig") = drS("f_inicio_vig")
                FilaGrid("f_fin_vig") = drS("f_fin_vig")


                FilaGrid("Bruto") = Valores.CastDBNull(drS("Bruto")) 'BrutoActual

                FilaGrid("Neto") = drS("Neto")

                FilaGrid("brutoactual") = t.ObtenerBruto

                FilaGrid("DCTO1") = drS("DCTO1")
                FilaGrid("DCTO2") = drS("DCTO2")
                FilaGrid("DCTO3") = drS("DCTO3")
                FilaGrid("DCTO4") = drS("DCTO4")
                FilaGrid("DCTO5") = drS("DCTO5")

                FilaGrid("RAT_PROG_TARGET_1") = drS("RAT_PROG_TARGET_1")
                FilaGrid("SHR_PROG_TARGET_1") = drS("SHR_PROG_TARGET_1")
                FilaGrid("AFF_PROG_TARGET_1") = drS("AFF_PROG_TARGET_1")
                FilaGrid("RCH_PROG_TARGET_1") = drS("RCH_PROG_TARGET_1")
                FilaGrid("RAT_M_PROG_TARGET_1") = drS("RAT_M_PROG_TARGET_1")
                FilaGrid("FID_PROG_TARGET_1") = drS("FID_PROG_TARGET_1")

                FilaGrid("RAT_TANDA_TARGET_1") = drS("RAT_TANDA_TARGET_1")
                FilaGrid("SHR_TANDA_TARGET_1") = drS("SHR_TANDA_TARGET_1")
                FilaGrid("AFF_TANDA_TARGET_1") = drS("AFF_TANDA_TARGET_1")
                FilaGrid("RCH_TANDA_TARGET_1") = drS("RCH_TANDA_TARGET_1")
                FilaGrid("RAT_M_TANDA_TARGET_1") = drS("RAT_M_TANDA_TARGET_1")
                FilaGrid("FID_TANDA_TARGET_1") = drS("FID_TANDA_TARGET_1")

                FilaGrid("RAT_PROG_TARGET_2") = drS("RAT_PROG_TARGET_2")
                FilaGrid("SHR_PROG_TARGET_2") = drS("SHR_PROG_TARGET_2")
                FilaGrid("AFF_PROG_TARGET_2") = drS("AFF_PROG_TARGET_2")
                FilaGrid("RCH_PROG_TARGET_2") = drS("RCH_PROG_TARGET_2")
                FilaGrid("RAT_M_PROG_TARGET_2") = drS("RAT_M_PROG_TARGET_2")
                FilaGrid("FID_PROG_TARGET_2") = drS("FID_PROG_TARGET_2")

                FilaGrid("RAT_TANDA_TARGET_2") = drS("RAT_TANDA_TARGET_2")
                FilaGrid("SHR_TANDA_TARGET_2") = drS("SHR_TANDA_TARGET_2")
                FilaGrid("AFF_TANDA_TARGET_2") = drS("AFF_TANDA_TARGET_2")
                FilaGrid("RCH_TANDA_TARGET_2") = drS("RCH_TANDA_TARGET_2")
                FilaGrid("RAT_M_TANDA_TARGET_2") = drS("RAT_M_TANDA_TARGET_2")
                FilaGrid("FID_TANDA_TARGET_2") = drS("FID_TANDA_TARGET_2")

                If drS(GrillAdmin.ColumnaRatingTarget1) = 0 Then
                    FilaGrid("CPR") = 0
                Else
                    FilaGrid("CPR") = Valores.CastNulo(IIf(IsDBNull(FilaGrid("Neto")), 0, FilaGrid("Neto")) / drS(GrillAdmin.ColumnaRatingTarget1))
                End If


                Grilla.Rows.Add(FilaGrid)
                i = i + 1
                'If i = 74 Then
                'Stop
                'End If
            Catch E As Exception
                MsgBox("frmEjercicio PasarSpotsGrilla " & E.Message)
                Exit For
            End Try

        Next

        Return Grilla
    End Function

    Private Function ObtenerDiasSpots(ByVal T As Tarifas_tv)

        Dim Dias As String = ""

        If T.D_l = "X" Then
            Dias += "L"
        End If
        If T.D_m = "X" Then
            Dias += "M"
        End If
        If T.D_x = "X" Then
            Dias += "X"
        End If
        If T.D_j = "X" Then
            Dias += "J"
        End If

        If T.D_v = "X" Then
            Dias += "V"
        End If

        If T.D_s = "X" Then
            Dias += "S"
        End If

        If T.D_d = "X" Then
            Dias += "D"
        End If

        Return Dias

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
    Private Function CargarTarifas(ByVal Soportes As ArrayList, ByVal IDMedio As Integer, ByVal IdSistema As Integer, ByVal TipoCarga As TipoAudiencia, Optional ByVal EsActualizacion As Boolean = False) As DataTable

        Dim Si As New Sistemas
        Dim L As ItemLista
        Dim T As New Tarifas_tv
        Dim A As New Audiencia_Tva
        Dim Ac As New Audiencia_tvc
        Dim Ai As New Audiencia_TVI
        Dim Ar As New Audiencia_rd
        Dim DsTarifas As New DataSet
        Dim DsAudiencia As New DataSet
        Dim Soporte(50) As Long, i As Integer

        Si.Id_campania = Activo.IDCampaña
        Si.Id_sistema = IdSistema
        Si.BuscarPorID()

        Dim dsEstructura As DataSet = ArmarEstructura(Si.F_inicio, Si.F_fin, Si)

        For Each L In Soportes
            ReDim Preserve Soporte(i)

            T.Id_soporte = L.ID
            Soporte(i) = L.ID
            T.Id_medio = Activo.IDMedio
            T.F_inicio_vig = Si.F_inicio
            T.F_fin_vig = Si.F_fin
            T.Id_cliente = Activo.IDCliente '363 
            i += 1
            If Not EsActualizacion Then
                T.ObteniendoTarifas(DsTarifas, "Tarifas")
            Else
                T.ActualizarTarifas(DsTarifas, "Tarifas", Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
            End If
            'se carga las audiencias segun los soportes que selecciono
        Next

        frmProgresoCargaGrilla.Instancia.Incrementar(1)
        If Activo.IDMedio = MedioRadio Then
            Select Case TipoCarga
                Case TipoAudiencia.Abierta
                    For Each L In Soportes
                        Ar.ObteniendoAudienciaRadio(DsAudiencia, "Audiencia", L.ID, Si.F_inicio, Si.F_fin, Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    Next
                Case TipoAudiencia.Intetior
                    DsAudiencia.Tables.Add("Audiencia")
            End Select
        Else
            Select Case TipoCarga
                Case TipoAudiencia.Abierta
                    For Each L In Soportes
                        A.Id_Medio = Activo.IDMedio
                        A.Id_Soporte = L.ID
                        A.ObteniendoAudienciaTVA(DsAudiencia, "Audiencia", Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    Next

                Case TipoAudiencia.Cable
                    frmProgresoCargaGrilla.Instancia.Close()
                    'AGuzzardi 10/06/2010 Audiencia Se quita por problemas de carga de hoja ----------------------
                    Dim f As New frmCargarAudienciaTVC
                    f.Sistema = Si
                    f.Soportes = Soporte
                    f.ShowDialog()
                    If f.HayError Then
                        ErrorNautilus = True
                        Exit Function
                    End If
                    '--------------------------------------------------------------------------------------------------------------------

                    For Each L In Soportes
                        Ac.Id_medio = Activo.IDMedio
                        Ac.Id_soporte = L.ID
                        Ac.ObteniendoAudienciaTVC(DsAudiencia, "AudienciaTVA", Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    Next

                Case TipoAudiencia.Intetior
                    frmProgresoCargaGrilla.Instancia.Close()
                    'AGuzzardi 10/06/2010 Audiencia Se quita por problemas de carga de hoja ----------------------
                    Dim f As New frmCargarAudienciaTVI
                    f.Sistema = Si
                    f.Soportes = Soporte
                    f.ShowDialog()
                    If f.HayError Then
                        ErrorNautilus = True
                        Exit Function
                    End If
                    '--------------------------------------------------------------------------------------------------------------------

                    For Each L In Soportes
                        Ai.Id_Medio = Activo.IDMedio
                        Ai.Id_Soporte = L.ID
                        Ai.ObteniendoAudienciaTVI(DsAudiencia, "AudienciaTVI", Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    Next

                Case TipoAudiencia.Satelital
                    'For Each L In Soportes
                    'A.Id_Medio = 1
                    'A.Id_Soporte = L.ID
                    'A.ObteniendoAudienciaTVA(DsAudiencia, "Audiencia", Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    '
                    DsAudiencia.Tables.Add("Audiencia")
                    'Next
            End Select
        End If

        frmProgresoCargaGrilla.Instancia.Incrementar(1)

        Dim dtSpot As DataTable
        Dim dtGrid As DataTable

        If Activo.IDMedio = MedioRadio Then
            Select Case TipoCarga
                Case TipoAudiencia.Abierta
                    dtSpot = Me.CargarSpotsRadio(DsTarifas.Tables(0), DsAudiencia.Tables(0), dsEstructura.Tables("Spots"), Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio, Si.Id_target_1, Si.Id_target_2)
                Case TipoAudiencia.Intetior
                    dtSpot = Me.CargarSpotsTVS(DsTarifas.Tables(0), DsAudiencia.Tables(0), dsEstructura.Tables("Spots"), Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio, Si.Id_target_1, Si.Id_target_2)
            End Select
            If AvisosEspeciales.Count > 0 Then
                DtAfectados = Me.ObtenerAfectadosEspeciales(dtSpot, AvisosEspeciales, DsTarifas.Tables(0))
            End If
            dtGrid = Me.CargarDTGrilla(DsTarifas.Tables(0), dtSpot, dsEstructura.Tables("Grid"))
        Else
            Select Case TipoCarga
                Case TipoAudiencia.Abierta
                    dtSpot = Me.CargarSopots(DsTarifas.Tables(0), DsAudiencia.Tables(0), dsEstructura.Tables("Spots"), Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio, Si.Id_target_1, Si.Id_target_2, Si.Tipo_rating)
                    If AvisosEspeciales.Count > 0 Then
                        DtAfectados = Me.ObtenerAfectadosEspeciales(dtSpot, AvisosEspeciales, DsTarifas.Tables(0))
                    End If
                    dtGrid = Me.CargarDTGrilla(DsTarifas.Tables(0), dtSpot, dsEstructura.Tables("Grid"))

                Case TipoAudiencia.Cable
                    dtSpot = Me.CargarSpotsTVC(DsTarifas.Tables(0), DsAudiencia.Tables(0), dsEstructura.Tables("Spots"), Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio, Si.Id_target_1, Si.Id_target_2)
                    If AvisosEspeciales.Count > 0 Then
                        DtAfectados = Me.ObtenerAfectadosEspeciales(dtSpot, AvisosEspeciales, DsTarifas.Tables(0))
                    End If
                    dtGrid = Me.CargarDTGrilla(DsTarifas.Tables(0), dtSpot, dsEstructura.Tables("Grid"))

                Case TipoAudiencia.Intetior
                    dtSpot = Me.CargarSpotsTVI(DsTarifas.Tables(0), DsAudiencia.Tables(0), dsEstructura.Tables("Spots"), Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio, Si.Id_target_1, Si.Id_target_2)
                    If AvisosEspeciales.Count > 0 Then
                        DtAfectados = Me.ObtenerAfectadosEspeciales(dtSpot, AvisosEspeciales, DsTarifas.Tables(0))
                    End If
                    dtGrid = Me.CargarDTGrilla(DsTarifas.Tables(0), dtSpot, dsEstructura.Tables("Grid"))

                Case TipoAudiencia.Satelital
                    dtSpot = Me.CargarSpotsTVS(DsTarifas.Tables(0), DsAudiencia.Tables(0), dsEstructura.Tables("Spots"), Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio, Si.Id_target_1, Si.Id_target_2)
                    If AvisosEspeciales.Count > 0 Then
                        DtAfectados = Me.ObtenerAfectadosEspeciales(dtSpot, AvisosEspeciales, DsTarifas.Tables(0))
                    End If
                    dtGrid = Me.CargarDTGrilla(DsTarifas.Tables(0), dtSpot, dsEstructura.Tables("Grid"))
            End Select
        End If


        frmProgresoCargaGrilla.Instancia.Incrementar(1)

        Return dtGrid
    End Function
    Private Function ObtenerAfectadosEspeciales(ByVal Spots As DataTable, ByVal Especiales As ArrayList) As DataTable
        Dim Dt As New DataTable("afectados")
        Dim drAfectados As DataRow
        Dim R As DataRow, SpotEspecial As DataRow
        Dim SpotsEncontrados As DataRow()
        Dim Hie As Integer, Mie As Integer
        Dim Hfe As Integer, Mfe As Integer
        Dim DtCoinciden As DataTable
        Dim Filtro As String = ""
        Dim DiaEspecial As String, DiasPrograma As String, fecha As String

        Dim T As New Tarifas_tv
        Dim idEspeciales As String = Algoritmos.ArrayString(Especiales)



        Dt.Columns.Add("Id_Spot", GetType(Long))
        Dt.Columns.Add("Dia", GetType(String))

        For Each id As Object In Especiales
            SpotEspecial = Spots.Select("ID_Spot=" & id)(0)
            T.Id_tarifa_tv = SpotEspecial("id_tarifa_tv")
            DiaEspecial = T.ObtenerDia
            fecha = T.ObtenerFechaInicio



            Hie = SpotEspecial("h_inicio")
            Mie = SpotEspecial("m_inicio")
            Hfe = SpotEspecial("h_fin")
            Mfe = SpotEspecial("m_fin")

            Filtro = "h_inicio <=" & Hie & " and m_inicio <=" & Mie
            Filtro &= " AND h_fin >=" & Hie & " and m_fin >=" & Mie
            Filtro &= " OR h_inicio >=" & Hie & " and m_inicio >=" & Mie
            Filtro &= " AND h_inicio <=" & Hfe & " and m_inicio <=" & Mfe

            'DtCoinciden = Listas.FiltrarDT(Spots, "id_spot <>" & id & " and id_tarifa_tv <>" & SpotEspecial("id_tarifa_tv") & " and id_soporte=" & SpotEspecial("Id_Soporte"))
            'DtCoinciden = Listas.FiltrarDT(Spots, "id_spot not in(" & idEspeciales & ") and id_soporte=" & SpotEspecial("Id_Soporte"))
            DtCoinciden = Listas.FiltrarDT(Spots, "id_spot not in(" & idEspeciales & ") and id_tarifa_tv <>" & SpotEspecial("id_tarifa_tv") & " and id_soporte=" & SpotEspecial("Id_Soporte"))


            SpotsEncontrados = DtCoinciden.Select(Filtro)

            For Each R In SpotsEncontrados
                T.Id_tarifa_tv = R("id_tarifa_tv")
                DiasPrograma = T.ObtenerDia
                ' fecha = GrillAdmin.ObtenerDato(tarifas, "ID_Tarifa_tv=" & R("id_tarifa_tv"), "f_inicio_vig")
                If DiasPrograma.IndexOf(DiaEspecial) >= 0 Then
                    drAfectados = Dt.NewRow
                    drAfectados("Id_Spot") = R("Id_Spot")
                    drAfectados("Dia") = fecha
                    'fecha
                    Dt.Rows.Add(drAfectados)
                End If
            Next
        Next
        Return Dt
    End Function
    Private Function ObtenerAfectadosEspeciales(ByVal Spots As DataTable, ByVal Especiales As ArrayList, ByVal tarifas As DataTable) As DataTable
        Dim Dt As New DataTable("afectados")
        Dim drAfectados As DataRow
        Dim R As DataRow, SpotEspecial As DataRow
        Dim SpotsEncontrados As DataRow()
        Dim Hie As Integer, Mie As Integer
        Dim Hfe As Integer, Mfe As Integer
        Dim DtCoinciden As DataTable
        Dim Filtro As String = ""
        Dim DiaEspecial As String, DiasPrograma As String, fecha As String
        Dt.Columns.Add("Id_Spot", GetType(Long))
        Dt.Columns.Add("Dia", GetType(String))
        Dim t As New Tarifas_tv

        Dim idEspeciales As String = Algoritmos.ArrayString(Especiales)

        For Each id As Object In Especiales
            SpotEspecial = Spots.Select("ID_Spot=" & id)(0)
            DiaEspecial = GrillAdmin.ObtenerDato(tarifas, "ID_Tarifa_tv=" & SpotEspecial("id_tarifa_tv"), "Dias")
            fecha = GrillAdmin.ObtenerDato(tarifas, "ID_Tarifa_tv=" & SpotEspecial("id_tarifa_tv"), "f_inicio_vig")

            Hie = SpotEspecial("h_inicio")

            Mie = SpotEspecial("m_inicio")
            Hfe = SpotEspecial("h_fin")
            Mfe = SpotEspecial("m_fin")

            Filtro = "h_inicio <=" & Hie & " and m_inicio <=" & Mie
            Filtro &= " AND h_fin >=" & Hie & " and m_fin >=" & Mie
            Filtro &= " OR h_inicio >=" & Hie & " and m_inicio >=" & Mie
            Filtro &= " AND h_inicio <=" & Hfe & " and m_inicio <=" & Mfe

            'DtCoinciden = Listas.FiltrarDT(Spots, "id_spot not in(" & idEspeciales & ") and id_soporte=" & SpotEspecial("Id_Soporte"))
            'DtCoinciden = Listas.FiltrarDT(Spots, "id_spot <>" & id & " and id_tarifa_tv <>" & SpotEspecial("id_tarifa_tv") & " and id_soporte=" & SpotEspecial("Id_Soporte"))
            DtCoinciden = Listas.FiltrarDT(Spots, "id_spot not in(" & idEspeciales & ") and id_tarifa_tv <>" & SpotEspecial("id_tarifa_tv") & " and id_soporte=" & SpotEspecial("Id_Soporte"))

            SpotsEncontrados = DtCoinciden.Select(Filtro)

            For Each R In SpotsEncontrados

                t.Id_tarifa_tv = R("id_tarifa_tv")
                DiasPrograma = t.ObtenerDia

                If DiasPrograma.IndexOf(DiaEspecial) >= 0 Then
                    drAfectados = Dt.NewRow
                    drAfectados("Id_Spot") = R("Id_Spot")
                    drAfectados("Dia") = fecha
                    Dt.Rows.Add(drAfectados)
                End If
            Next
        Next
        Return Dt
    End Function
    Private Sub TitulosFechas(ByVal BandIndex As Integer)
        Dim C As UltraGridColumn
        Dim i As Integer, j As Integer

        For Each C In iugEjercicio.DisplayLayout.Bands(BandIndex).Columns
            If C.Key.IndexOf("/") > -1 Then

                C.Header.Caption = Fechas(i)
                If BandIndex = 0 Then
                    If CStr(Fechas(i)).IndexOf("S") > -1 Or CStr(Fechas(i)).IndexOf("D") > -1 Then
                        GrillaFormato.CambiarColorTextoHeader(iugEjercicio, Me.ColorLinaDomingo, C.Index)
                        GrillaFormato.CambiarColorLinea(iugEjercicio, C.Index, ColorLinaDomingo)
                        GrillaFormato.CambiarColorLinea(iugEjercicio, C.Index + 1, ColorLinaDomingo)
                    End If
                    If j = 7 Then
                        GrillaFormato.CambiarColorLinea(iugEjercicio, C.Index, ColorDia7)
                        j = 0
                    End If
                End If
                j += 1
                i = i + 1
            End If
        Next
    End Sub

    Private Function ArmarEstructura(ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Sistema As Sistemas) As DataSet
        'Este procedimiento arma la estrucutra de los datatables tipados
        'tarifas: aca se guardan todas tarifas para los soportes seleccionados y  se les agrega el dia
        'Spots: aca se guardan los datos de spot
        'grid: este es el datatable con el cual se van a mostrar los datos en la grilla
        Dim dtTarifas As New DataTable("Tarifas")
        Dim esqTarifas As New DataTable("EsquemaTarifas")
        Dim dtSpots As New DataTable("Spots")
        Dim dtDetalle As New DataTable("Spots Detalle")
        Dim dtGrid As New DataTable("Grid")

        Dim DsDatos As New DataSet ' dataset de retorno
        Dim Ti As New CampoTipo
        Dim S As New Spots
        Dim Sd As New Spots_detalle
        Dim T As New Tarifas_tv
        Dim Ocultas As Int16
        Dim Dias As Int16 = DateDiff(DateInterval.Day, FechaInicio, FechaFin)
        'Dim Col As DataColumn
        Dim i As Integer, Dia(8) As String

        T.CargarEsquema(esqTarifas)

        S.CargarEsquema(dtSpots)

        Sd.CargarEsquema(dtDetalle)

        'dtDetalle.Columns.Add("id_estado_ejercicio")

        DetalleBase = dtDetalle.Copy

        ' se cargan todas las columnas de tarifas  + dias
        With dtTarifas.Columns
            .Add(dtSpots.Columns("id_spot").Caption, dtSpots.Columns("id_spot").DataType)
            .Add(dtSpots.Columns("id_Tarifa_Tv").Caption, dtSpots.Columns("id_Tarifa_Tv").DataType)
            .Add(dtSpots.Columns("id_programa").Caption, dtSpots.Columns("id_programa").DataType)
            .Add(esqTarifas.Columns("programa").Caption, esqTarifas.Columns("programa").DataType)
            .Add("dias", Type.GetType("System.String"))
            .Add(dtSpots.Columns("h_inicio").Caption, Type.GetType("System.String"))
            .Add(dtSpots.Columns("h_fin").Caption, Type.GetType("System.String"))
            .Add(esqTarifas.Columns("bruto").Caption, dtSpots.Columns("bruto").DataType)
            .Add(dtSpots.Columns("dcto1").Caption, dtSpots.Columns("dcto1").DataType)
            .Add(dtSpots.Columns("dcto2").Caption, dtSpots.Columns("dcto2").DataType)
            .Add(dtSpots.Columns("dcto3").Caption, dtSpots.Columns("dcto3").DataType)
            .Add(dtSpots.Columns("dcto4").Caption, dtSpots.Columns("dcto4").DataType)
            .Add(dtSpots.Columns("dcto5").Caption, dtSpots.Columns("dcto5").DataType)

        End With
        'de cargan las columnas del  dt con el que se llena el grid
        With dtGrid.Columns
            .Add(dtSpots.Columns("id_soporte").Caption, dtSpots.Columns("Id_Soporte").DataType)
            .Add("Soporte", GetType(String))
            .Add(dtSpots.Columns("Tipo_Planificacion").Caption, dtSpots.Columns("Tipo_Planificacion").DataType)
            .Add(dtSpots.Columns("id_spot").Caption, dtSpots.Columns("id_spot").DataType)
            .Add(dtSpots.Columns("id_Tarifa_Tv").Caption, dtSpots.Columns("id_Tarifa_Tv").DataType)
            .Add(dtSpots.Columns("id_convenio").Caption, dtSpots.Columns("id_convenio").DataType)
            .Add(dtSpots.Columns("id_programa").Caption, dtSpots.Columns("id_programa").DataType)
            .Add(esqTarifas.Columns("programa").Caption, esqTarifas.Columns("programa").DataType)
            .Add("dias", Type.GetType("System.String"))
            .Add(dtSpots.Columns("h_inicio").Caption, Type.GetType("System.String"))
            .Add(dtSpots.Columns("h_fin").Caption, Type.GetType("System.String"))
            .Add(esqTarifas.Columns("bruto").Caption, dtSpots.Columns("bruto").DataType)
            'brutoactual
            .Add("brutoactual", GetType(Decimal))
            .Add("id", GetType(Integer))

            .Add(esqTarifas.Columns("f_inicio_vig").Caption, esqTarifas.Columns("f_inicio_vig").DataType)
            .Add(esqTarifas.Columns("f_fin_vig").Caption, esqTarifas.Columns("f_fin_vig").DataType)

            .Add(dtSpots.Columns("dcto1").Caption, dtSpots.Columns("dcto1").DataType)
            .Add(dtSpots.Columns("dcto2").Caption, dtSpots.Columns("dcto2").DataType)
            .Add(dtSpots.Columns("dcto3").Caption, dtSpots.Columns("dcto3").DataType)
            .Add(dtSpots.Columns("dcto4").Caption, dtSpots.Columns("dcto4").DataType)
            .Add(dtSpots.Columns("dcto5").Caption, dtSpots.Columns("dcto5").DataType)


            .Add(dtSpots.Columns("desc_sistema").Caption, dtSpots.Columns("desc_sistema").DataType)
            .Add(dtSpots.Columns("desc_campania").Caption, dtSpots.Columns("desc_campania").DataType)
            .Add(dtSpots.Columns("desc_ejercicio").Caption, dtSpots.Columns("desc_ejercicio").DataType)
            'LOGGGGGGGG
            '.Add(dtSpots.Columns("u_modi").Caption, GetType(String))
            '.Add(dtSpots.Columns("f_modi").Caption, GetType(Date))

            'Ti = New CampoTipo
            'Ti.Campo = "f_modi"
            'Ti.Tipo = GetType(Date)
            'ColumnasHijos.Add(Ti)

            'Ti = New CampoTipo
            'Ti.Campo = "u_modi"
            'Ti.Tipo = GetType(String)
            'ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "Tema"
            Ti.Tipo = GetType(String)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "f_inicio_vig"
            Ti.Tipo = GetType(String)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "f_fin_vig"
            Ti.Tipo = GetType(String)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "h_inicio"
            Ti.Tipo = GetType(String)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "h_fin"
            Ti.Tipo = GetType(String)
            ColumnasHijos.Add(Ti)

            .Add("Neto", GetType(Single))
            Ti = New CampoTipo
            Ti.Campo = "Neto"
            Ti.Tipo = GetType(Single)
            ColumnasHijos.Add(Ti)

            '--------------------


            '----------
            Ti = New CampoTipo
            Ti.Campo = "desc_campania"
            Ti.Tipo = dtSpots.Columns("desc_campania").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "desc_sistema"
            Ti.Tipo = dtSpots.Columns("desc_sistema").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "desc_ejercicio"
            Ti.Tipo = dtSpots.Columns("desc_ejercicio").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "dcto1"
            Ti.Tipo = dtSpots.Columns("dcto1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "dcto2"
            Ti.Tipo = dtSpots.Columns("dcto2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "dcto3"
            Ti.Tipo = dtSpots.Columns("dcto3").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "dcto4"
            Ti.Tipo = dtSpots.Columns("dcto4").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "dcto5"
            Ti.Tipo = dtSpots.Columns("dcto5").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "bruto"
            Ti.Tipo = dtSpots.Columns("bruto").DataType
            ColumnasHijos.Add(Ti)

            'brutoactual
            Ti = New CampoTipo
            Ti.Campo = "brutoactual"
            Ti.Tipo = dtSpots.Columns("bruto").DataType
            ColumnasHijos.Add(Ti)

            'id
            Ti = New CampoTipo
            Ti.Campo = "id"
            Ti.Tipo = GetType(Integer)
            ColumnasHijos.Add(Ti)

            .Add(dtSpots.Columns("RAT_PROG_TARGET_1").Caption, dtSpots.Columns("RAT_PROG_TARGET_1").DataType)
            .Add(dtSpots.Columns("SHR_PROG_TARGET_1").Caption, dtSpots.Columns("SHR_PROG_TARGET_1").DataType)
            .Add(dtSpots.Columns("AFF_PROG_TARGET_1").Caption, dtSpots.Columns("AFF_PROG_TARGET_1").DataType)
            .Add(dtSpots.Columns("RCH_PROG_TARGET_1").Caption, dtSpots.Columns("RCH_PROG_TARGET_1").DataType)
            .Add(dtSpots.Columns("RAT_M_PROG_TARGET_1").Caption, dtSpots.Columns("RAT_M_PROG_TARGET_1").DataType)
            .Add(dtSpots.Columns("FID_PROG_TARGET_1").Caption, dtSpots.Columns("FID_PROG_TARGET_1").DataType)

            .Add(dtSpots.Columns("RAT_TANDA_TARGET_1").Caption, dtSpots.Columns("RAT_TANDA_TARGET_1").DataType)
            .Add(dtSpots.Columns("SHR_TANDA_TARGET_1").Caption, dtSpots.Columns("SHR_TANDA_TARGET_1").DataType)
            .Add(dtSpots.Columns("AFF_TANDA_TARGET_1").Caption, dtSpots.Columns("AFF_TANDA_TARGET_1").DataType)
            .Add(dtSpots.Columns("RCH_TANDA_TARGET_1").Caption, dtSpots.Columns("RCH_TANDA_TARGET_1").DataType)
            .Add(dtSpots.Columns("RAT_M_TANDA_TARGET_1").Caption, dtSpots.Columns("RAT_M_TANDA_TARGET_1").DataType)
            .Add(dtSpots.Columns("FID_TANDA_TARGET_1").Caption, dtSpots.Columns("FID_TANDA_TARGET_1").DataType)

            .Add(dtSpots.Columns("RAT_PROG_TARGET_2").Caption, dtSpots.Columns("RAT_PROG_TARGET_2").DataType)
            .Add(dtSpots.Columns("SHR_PROG_TARGET_2").Caption, dtSpots.Columns("SHR_PROG_TARGET_2").DataType)
            .Add(dtSpots.Columns("AFF_PROG_TARGET_2").Caption, dtSpots.Columns("AFF_PROG_TARGET_2").DataType)
            .Add(dtSpots.Columns("RCH_PROG_TARGET_2").Caption, dtSpots.Columns("RCH_PROG_TARGET_2").DataType)
            .Add(dtSpots.Columns("RAT_M_PROG_TARGET_2").Caption, dtSpots.Columns("RAT_M_PROG_TARGET_2").DataType)
            .Add(dtSpots.Columns("FID_PROG_TARGET_2").Caption, dtSpots.Columns("FID_PROG_TARGET_2").DataType)

            .Add(dtSpots.Columns("RAT_TANDA_TARGET_2").Caption, dtSpots.Columns("RAT_TANDA_TARGET_2").DataType)
            .Add(dtSpots.Columns("SHR_TANDA_TARGET_2").Caption, dtSpots.Columns("SHR_TANDA_TARGET_2").DataType)
            .Add(dtSpots.Columns("AFF_TANDA_TARGET_2").Caption, dtSpots.Columns("AFF_TANDA_TARGET_2").DataType)
            .Add(dtSpots.Columns("RCH_TANDA_TARGET_2").Caption, dtSpots.Columns("RCH_TANDA_TARGET_2").DataType)
            .Add(dtSpots.Columns("RAT_M_TANDA_TARGET_2").Caption, dtSpots.Columns("RAT_M_TANDA_TARGET_2").DataType)
            .Add(dtSpots.Columns("FID_TANDA_TARGET_2").Caption, dtSpots.Columns("FID_TANDA_TARGET_2").DataType)

            Ti = New CampoTipo
            Ti.Campo = "ID_Spot"
            Ti.Tipo = GetType(Integer)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "ID_Programa"
            Ti.Tipo = GetType(Integer)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RAT_PROG_TARGET_1"
            Ti.Tipo = dtSpots.Columns("RAT_PROG_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "SHR_PROG_TARGET_1"
            Ti.Tipo = dtSpots.Columns("SHR_PROG_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "AFF_PROG_TARGET_1"
            Ti.Tipo = dtSpots.Columns("AFF_PROG_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RCH_PROG_TARGET_1"
            Ti.Tipo = dtSpots.Columns("RCH_PROG_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RAT_M_PROG_TARGET_1"
            Ti.Tipo = dtSpots.Columns("RAT_M_PROG_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "FID_PROG_TARGET_1"
            Ti.Tipo = dtSpots.Columns("FID_PROG_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            '---------------------
            Ti = New CampoTipo
            Ti.Campo = "RAT_TANDA_TARGET_1"
            Ti.Tipo = dtSpots.Columns("RAT_TANDA_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "SHR_TANDA_TARGET_1"
            Ti.Tipo = dtSpots.Columns("SHR_TANDA_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "AFF_TANDA_TARGET_1"
            Ti.Tipo = dtSpots.Columns("AFF_TANDA_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RCH_TANDA_TARGET_1"
            Ti.Tipo = dtSpots.Columns("RCH_TANDA_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RAT_M_TANDA_TARGET_1"
            Ti.Tipo = dtSpots.Columns("RAT_M_TANDA_TARGET_1").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "FID_TANDA_TARGET_1"
            Ti.Tipo = dtSpots.Columns("FID_TANDA_TARGET_1").DataType
            ColumnasHijos.Add(Ti)
            '------------------------------------------
            Ti = New CampoTipo
            Ti.Campo = "RAT_PROG_TARGET_2"
            Ti.Tipo = dtSpots.Columns("RAT_PROG_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "SHR_PROG_TARGET_2"
            Ti.Tipo = dtSpots.Columns("SHR_PROG_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "AFF_PROG_TARGET_2"
            Ti.Tipo = dtSpots.Columns("AFF_PROG_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RCH_PROG_TARGET_2"
            Ti.Tipo = dtSpots.Columns("RCH_PROG_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RAT_M_PROG_TARGET_2"
            Ti.Tipo = dtSpots.Columns("RAT_M_PROG_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "FID_PROG_TARGET_2"
            Ti.Tipo = dtSpots.Columns("FID_PROG_TARGET_2").DataType
            ColumnasHijos.Add(Ti)
            '--------------------------

            Ti = New CampoTipo
            Ti.Campo = "RAT_TANDA_TARGET_2"
            Ti.Tipo = dtSpots.Columns("RAT_TANDA_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "SHR_TANDA_TARGET_2"
            Ti.Tipo = dtSpots.Columns("SHR_TANDA_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "AFF_TANDA_TARGET_2"
            Ti.Tipo = dtSpots.Columns("AFF_TANDA_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RCH_TANDA_TARGET_2"
            Ti.Tipo = dtSpots.Columns("RCH_TANDA_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "RAT_M_TANDA_TARGET_2"
            Ti.Tipo = dtSpots.Columns("RAT_M_TANDA_TARGET_2").DataType
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "FID_TANDA_TARGET_2"
            Ti.Tipo = dtSpots.Columns("FID_TANDA_TARGET_2").DataType
            ColumnasHijos.Add(Ti)
            '----------------------

            .Add("Afinidad", GetType(Single))
            Ti = New CampoTipo
            Ti.Campo = "Afinidad"
            Ti.Tipo = GetType(Single)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "CPR"
            Ti.Tipo = GetType(String)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "DUR"
            Ti.Tipo = GetType(String)
            ColumnasHijos.Add(Ti)

            .Add("CPR", GetType(Single))
            .Add("DUR", GetType(Integer))

            'aca se calculan los dias de duracion de camapña
            'aff t1t2


            'Strings con las letras del c/dia
            Dia(1) = "L"
            Dia(2) = "M"
            Dia(3) = "X"
            Dia(4) = "J"
            Dia(5) = "V"
            Dia(6) = "S"
            Dia(7) = "D"
            'dim Te as New 
            For i = 0 To Dias
                .Add(DateAdd(DateInterval.Day, i, FechaInicio))

                Ti = New CampoTipo
                Ti.Campo = DateAdd(DateInterval.Day, i, FechaInicio)
                Ti.Tipo = GetType(String)
                ColumnasHijos.Add(Ti)
                Fechas.Add(Dia(DatePart(DateInterval.Weekday, DateAdd(DateInterval.Day, i, FechaInicio), FirstDayOfWeek.Monday)) & vbCrLf & DatePart(DateInterval.Day, DateAdd(DateInterval.Day, i, FechaInicio)) & "/" & DatePart(DateInterval.Month, DateAdd(DateInterval.Day, i, FechaInicio), FirstDayOfWeek.Monday))
            Next

            .Add("Total Spots", GetType(Integer))
            Ti = New CampoTipo
            Ti.Campo = "Total Spots"
            Ti.Tipo = GetType(Integer)
            ColumnasHijos.Add(Ti)


            .Add("Total GRP Target 1", GetType(Single))
            Ti = New CampoTipo
            Ti.Campo = "Total GRP Target 1"
            Ti.Tipo = GetType(Single)
            ColumnasHijos.Add(Ti)

            .Add("Total GRP Target 2", GetType(Single))
            Ti = New CampoTipo
            Ti.Campo = "Total GRP Target 2"
            Ti.Tipo = GetType(Single)
            ColumnasHijos.Add(Ti)

            .Add("Total Bruto", GetType(Single))
            .Add("Total Neto", GetType(Single))

            Ti = New CampoTipo
            Ti.Campo = "Total Bruto"
            Ti.Tipo = GetType(Single)
            ColumnasHijos.Add(Ti)

            Ti = New CampoTipo
            Ti.Campo = "Total Neto"
            Ti.Tipo = GetType(Single)
            ColumnasHijos.Add(Ti)
        End With

        'Dim co As String

        'For Each c As DataColumn In dtGrid.Columns

        '    co &= c.Caption & vbCrLf

        'Next

        'Mensajes.Mensaje((co))
        'co = ""
        'For Each c As CampoTipo In ColumnasHijos

        '    co &= c.Campo & vbCrLf

        'Next

        'Mensajes.Mensaje((co))


        DsDatos.Tables.Add(dtTarifas)
        DsDatos.Tables.Add(dtSpots)
        DsDatos.Tables.Add(dtDetalle)
        DsDatos.Tables.Add(dtGrid)

        Return DsDatos
    End Function
    Private Function ObtenerProximoIdSpot(ByVal Spots As DataTable) As Long
        Dim id As Integer
        Dim fila As DataRow()
        fila = Spots.Select("id_spot >= 0", "id_spot desc")
        If fila.Length <= 0 Then
            id = 0
        Else
            id = fila(0)("id_spot")
        End If
        Return id
    End Function

    Private Function CargarSopots(ByVal dtTarifas As DataTable, ByVal dtAudiencia As DataTable, ByVal DtSpot As DataTable, ByVal idCampania As Int64, ByVal idSistema As Int64, ByVal idEjer As Int64, ByVal Target1 As Int64, ByVal Target2 As Int64, Optional ByVal TipoPlanificacion As String = "A")

        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow
        Dim IdPrograma As Integer
        Dim TieneTanda As Boolean = True

        For j = 0 To dtTarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = DtSpot.NewRow
            Try
                If dtTarifas.Rows(j).Item("ID_PROGRAMA") Is DBNull.Value Then
                    IdPrograma = 0
                Else
                    IdPrograma = dtTarifas.Rows(j).Item("ID_PROGRAMA")
                End If

                ColRow = dtAudiencia.Select("ID_PROGRAMA=" & IdPrograma)

                'CAMBIO POR EL TEMA DE RATING TANDA CERO 

                If dtAudiencia.Select("ID_PROGRAMA=" & IdPrograma & " AND PROGRAMA_TANDA='T'").Length > 0 Then
                    TieneTanda = True
                Else
                    TieneTanda = False
                End If

                'agregado Esteban: cuando se carga por 1ra vez la grilla, 
                'pasa la fecha de alta de los spots
                Dr("f_alta") = Now.Date
                Dr("u_alta") = Activo.Login

                If ColRow.Length >= 1 Then
                    'cambio por error de id_spot
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(DtSpot) + k

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    '----------------------------------------


                    Dr("ID_Campania") = idCampania
                    Dr("ID_Sistema") = idSistema
                    Dr("ID_Ejercicio") = idEjer
                    Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = dtTarifas.Rows(j)("Programa")
                    Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("Tipo_Planificacion") = 0
                    Dr("desc_campania") = Activo.Campaña
                    Dr("desc_sistema") = Activo.Sistema
                    Dr("desc_ejercicio") = Activo.Ejercicio
                    Dr("id_Convenio") = 0
                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0

                    'asigna los valores dependiendo los targets y tipo de planificacion
                    If ColRow.Length = 2 And TieneTanda Then
                        ' No tiene Target 2
                        If ColRow(0)("Id_Target") = Target1 Then

                            Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_1") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_1") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_1") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_1") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_1") = ColRow(0)("FID")
                            Dr("RAT_TANDA_TARGET_1") = Valores.Redondear((ColRow(1)("RAT") * Deflactacion), "0.00") ' ColRow(1)("RAT")
                            Dr("SHR_TANDA_TARGET_1") = ColRow(1)("SHR")
                            Dr("AFF_TANDA_TARGET_1") = ColRow(1)("AFF")
                            Dr("RCH_TANDA_TARGET_1") = ColRow(1)("RCH")
                            Dr("RAT_M_TANDA_TARGET_1") = ColRow(1)("RAT_M")
                            Dr("FID_TANDA_TARGET_1") = ColRow(1)("FID")
                            Dr("RAT_PROG_TARGET_2") = 0
                            Dr("RAT_TANDA_TARGET_2") = 0
                        Else
                            Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_2") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_2") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_2") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_2") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_2") = ColRow(0)("FID")

                            Dr("RAT_TANDA_TARGET_2") = Valores.Redondear((ColRow(1)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_2") = ColRow(1)("SHR")
                            Dr("AFF_TANDA_TARGET_2") = ColRow(1)("AFF")
                            Dr("RCH_TANDA_TARGET_2") = ColRow(1)("RCH")
                            Dr("RAT_M_TANDA_TARGET_2") = ColRow(1)("RAT_M")
                            Dr("FID_TANDA_TARGET_2") = ColRow(1)("FID")
                            Dr("RAT_PROG_TARGET_1") = 0
                            Dr("RAT_TANDA_TARGET_1") = 0
                        End If
                    End If
                    'CAMBIO
                    '------------------------------------
                    If ColRow.Length = 2 And Not TieneTanda Then ' con 2 targets
                        ' No tiene Target 2
                        'If ColRow(0)("Id_Target") = Target1 Then

                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * Deflactacion), "0.00")
                        Dr("SHR_PROG_TARGET_1") = ColRow(0)("SHR")
                        Dr("AFF_PROG_TARGET_1") = ColRow(0)("AFF")
                        Dr("RCH_PROG_TARGET_1") = ColRow(0)("RCH")
                        Dr("RAT_M_PROG_TARGET_1") = ColRow(0)("RAT_M")
                        Dr("FID_PROG_TARGET_1") = ColRow(0)("FID")
                        Dr("RAT_TANDA_TARGET_1") = 0
                        Dr("SHR_TANDA_TARGET_1") = 0
                        Dr("AFF_TANDA_TARGET_1") = 0
                        Dr("RCH_TANDA_TARGET_1") = 0
                        Dr("RAT_M_TANDA_TARGET_1") = 0
                        Dr("FID_TANDA_TARGET_1") = 0

                        Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(1)("RAT") * Deflactacion), "0.00")
                        Dr("SHR_PROG_TARGET_2") = ColRow(1)("SHR")
                        Dr("AFF_PROG_TARGET_2") = ColRow(1)("AFF")
                        Dr("RCH_PROG_TARGET_2") = ColRow(1)("RCH")
                        Dr("RAT_M_PROG_TARGET_2") = ColRow(1)("RAT_M")
                        Dr("FID_PROG_TARGET_2") = ColRow(1)("FID")

                        Dr("RAT_TANDA_TARGET_2") = 0
                        Dr("SHR_TANDA_TARGET_2") = 0
                        Dr("AFF_TANDA_TARGET_2") = 0
                        Dr("RCH_TANDA_TARGET_2") = 0
                        Dr("RAT_M_TANDA_TARGET_2") = 0
                        Dr("FID_TANDA_TARGET_2") = 0

                    End If

                    If ColRow.Length = 1 And Not TieneTanda Then ' con 1 targets, si tiene un solo target y no tiene tanda viene un solo registro
                        ' No tiene Target 2
                        'If ColRow(0)("Id_Target") = Target1 Then

                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * Deflactacion), "0.00")
                        Dr("SHR_PROG_TARGET_1") = ColRow(0)("SHR")
                        Dr("AFF_PROG_TARGET_1") = ColRow(0)("AFF")
                        Dr("RCH_PROG_TARGET_1") = ColRow(0)("RCH")
                        Dr("RAT_M_PROG_TARGET_1") = ColRow(0)("RAT_M")
                        Dr("FID_PROG_TARGET_1") = ColRow(0)("FID")
                        Dr("RAT_TANDA_TARGET_1") = 0
                        Dr("SHR_TANDA_TARGET_1") = 0
                        Dr("AFF_TANDA_TARGET_1") = 0
                        Dr("RCH_TANDA_TARGET_1") = 0
                        Dr("RAT_M_TANDA_TARGET_1") = 0
                        Dr("FID_TANDA_TARGET_1") = 0

                        Dr("RAT_PROG_TARGET_2") = 0
                        Dr("SHR_PROG_TARGET_2") = 0
                        Dr("AFF_PROG_TARGET_2") = 0
                        Dr("RCH_PROG_TARGET_2") = 0
                        Dr("RAT_M_PROG_TARGET_2") = 0
                        Dr("FID_PROG_TARGET_2") = 0

                        Dr("RAT_TANDA_TARGET_2") = 0
                        Dr("SHR_TANDA_TARGET_2") = 0
                        Dr("AFF_TANDA_TARGET_2") = 0
                        Dr("RCH_TANDA_TARGET_2") = 0
                        Dr("RAT_M_TANDA_TARGET_2") = 0
                        Dr("FID_TANDA_TARGET_2") = 0

                    End If
                    '------------------------------------
                    If ColRow.Length = 4 Then 'TIENE LOS DOS TARGET
                        If ColRow(0)("Id_Target") = Target1 Then

                            Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_1") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_1") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_1") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_1") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_1") = ColRow(0)("FID")
                            Dr("RAT_TANDA_TARGET_1") = Valores.Redondear((ColRow(1)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_1") = ColRow(1)("SHR")
                            Dr("AFF_TANDA_TARGET_1") = ColRow(1)("AFF")
                            Dr("RCH_TANDA_TARGET_1") = ColRow(1)("RCH")
                            Dr("RAT_M_TANDA_TARGET_1") = ColRow(1)("RAT_M")
                            Dr("FID_TANDA_TARGET_1") = ColRow(1)("FID")
                            Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(2)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_2") = ColRow(2)("SHR")
                            Dr("AFF_PROG_TARGET_2") = ColRow(2)("AFF")
                            Dr("RCH_PROG_TARGET_2") = ColRow(2)("RCH")
                            Dr("RAT_M_PROG_TARGET_2") = ColRow(2)("RAT_M")
                            Dr("FID_PROG_TARGET_2") = ColRow(2)("FID")
                            Dr("RAT_TANDA_TARGET_2") = Valores.Redondear((ColRow(3)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_2") = ColRow(3)("SHR")
                            Dr("AFF_TANDA_TARGET_2") = ColRow(3)("AFF")
                            Dr("RCH_TANDA_TARGET_2") = ColRow(3)("RCH")
                            Dr("RAT_M_TANDA_TARGET_2") = ColRow(3)("RAT_M")
                            Dr("FID_TANDA_TARGET_2") = ColRow(3)("FID")
                        Else
                            Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_2") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_2") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_2") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_2") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_2") = ColRow(0)("FID")

                            Dr("RAT_TANDA_TARGET_2") = Valores.Redondear((ColRow(1)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_2") = ColRow(1)("SHR")
                            Dr("AFF_TANDA_TARGET_2") = ColRow(1)("AFF")
                            Dr("RCH_TANDA_TARGET_2") = ColRow(1)("RCH")
                            Dr("RAT_M_TANDA_TARGET_2") = ColRow(1)("RAT_M")
                            Dr("FID_TANDA_TARGET_2") = ColRow(1)("FID")

                            Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(2)("RAT") * Deflactacion), "0.00") 'ColRow(2)("RAT")
                            Dr("SHR_PROG_TARGET_1") = ColRow(2)("SHR")
                            Dr("AFF_PROG_TARGET_1") = ColRow(2)("AFF")
                            Dr("RCH_PROG_TARGET_1") = ColRow(2)("RCH")
                            Dr("RAT_M_PROG_TARGET_1") = ColRow(2)("RAT_M")
                            Dr("FID_PROG_TARGET_1") = ColRow(2)("FID")

                            Dr("RAT_TANDA_TARGET_1") = Valores.Redondear((ColRow(3)("RAT") * Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_1") = ColRow(3)("SHR")
                            Dr("AFF_TANDA_TARGET_1") = ColRow(3)("AFF")
                            Dr("RCH_TANDA_TARGET_1") = ColRow(3)("RCH")
                            Dr("RAT_M_TANDA_TARGET_1") = ColRow(3)("RAT_M")
                            Dr("FID_TANDA_TARGET_1") = ColRow(3)("FID")
                        End If
                    End If
                Else
                    k = k + 1
                    Dr("id_spot") = Me.ObtenerProximoIdSpot(DtSpot) + k

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    '----------------------------------------

                    Dr("id_campania") = idCampania
                    Dr("id_sistema") = idSistema
                    Dr("id_ejercicio") = idEjer
                    Dr("id_soporte") = dtTarifas.Rows(j)("id_soporte")
                    Dr("id_tarifa_tv") = dtTarifas.Rows(j)("id_tarifa_tv")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("programa") = dtTarifas.Rows(j)("programa")
                    Dr("bruto") = dtTarifas.Rows(j)("Tarifa bruta")
                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("tipo_planificacion") = 0
                    Dr("desc_campania") = Activo.Campaña
                    Dr("desc_sistema") = Activo.Sistema
                    Dr("desc_ejercicio") = Activo.Ejercicio
                    Dr("id_convenio") = 0
                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("dcto1") = 0
                    Dr("dcto2") = 0
                    Dr("dcto3") = 0
                    Dr("dcto4") = 0
                    Dr("dcto5") = 0

                    Dr("rat_prog_target_2") = 0 '-1 AG Hoja Numero 
                    Dr("shr_prog_target_2") = 0
                    Dr("aff_prog_target_2") = 0
                    Dr("rch_prog_target_2") = 0
                    Dr("rat_m_prog_target_2") = 0
                    Dr("fid_prog_target_2") = 0

                    Dr("rat_tanda_target_2") = 0 '-1 AG Hoja Numero 
                    Dr("shr_tanda_target_2") = 0
                    Dr("aff_tanda_target_2") = 0
                    Dr("rch_tanda_target_2") = 0
                    Dr("rat_m_tanda_target_2") = 0
                    Dr("fid_tanda_target_2") = 0

                    Dr("rat_prog_target_1") = 0 '-1 AG Hoja Numero 
                    Dr("shr_prog_target_1") = 0
                    Dr("aff_prog_target_1") = 0
                    Dr("rch_prog_target_1") = 0
                    Dr("rat_m_prog_target_1") = 0
                    Dr("fid_prog_target_1") = 0

                    Dr("rat_tanda_target_1") = 0 '-1 AG Hoja Numero 
                    Dr("shr_tanda_target_1") = 0
                    Dr("aff_tanda_target_1") = 0
                    Dr("rch_tanda_target_1") = 0
                    Dr("rat_m_tanda_target_1") = 0
                    Dr("fid_tanda_target_1") = 0
                End If

                DtSpot.Rows.Add(Dr)

                ' k = k + 1

            Catch e As Exception
            End Try
        Next
        SpotBase = DtSpot.Copy

        Return DtSpot
    End Function


    Private Function CargarDTGrilla(ByVal DtTarifas As DataTable, ByVal DtSpot As DataTable, ByVal DtGrilla As DataTable) As DataTable

        Dim drS As DataRow, i As Int32
        Dim drAu As DataRow, dr As DataRow
        Dim BrutoActual As Decimal, J As Integer
        'aca se cargan los datos dentro del datatable drid el cual se usa para llamar a la grulla
        Dim S As New Soportes
        Dim Tarifa As DataRow()

        S.Id_plaza = Activo.IDPlaza
        S.Id_medio = Activo.IDMedio
        S.Id_tipo_soporte = Activo.IDTipoSoporte


        Dim Sop As DataTable = S.ObtenerSoportes

        Dim soporte As String, IdSoporte As Integer
        Try
            For Each drS In DtSpot.Rows
                soporte = GrillAdmin.ObtenerDato(Sop, "ID_Soporte=" & drS("id_Soporte"), "descripcion")
                Tarifa = DtTarifas.Select("ID_Tarifa_tv=" & drS("ID_Tarifa_tv"))
                dr = DtGrilla.NewRow


                BrutoActual = drS("Bruto")
                ' End If
                dr("brutoactual") = BrutoActual
                dr("id") = 0
                dr("Id_Spot") = drS("Id_Spot")
                dr("Id_Programa") = drS("Id_Programa")
                dr("id_soporte") = drS("Id_Soporte")
                dr("soporte") = soporte
                dr("id_tarifa_tv") = drS("Id_Tarifa_tv")
                dr("id_convenio") = drS("id_convenio")
                dr("Programa") = drS("Programa")
                dr("Dias") = Tarifa(0)("Dias")
                dr("h_inicio") = Tarifa(0)("Hora Inicio")
                dr("h_fin") = Tarifa(0)("Hora Fin")
                dr("Tipo_Planificacion") = drS("Tipo_Planificacion")
                dr("f_inicio_vig") = Tarifa(0)("f_inicio_vig")
                dr("f_fin_vig") = Tarifa(0)("f_fin_vig")
                dr("desc_sistema") = Activo.Sistema
                dr("desc_campania") = Activo.Campaña
                dr("desc_ejercicio") = Activo.Ejercicio


                dr("Neto") = drS("Bruto")
                dr("Bruto") = drS("Bruto")

                'brutoactual
                dr("DCTO1") = drS("DCTO1")
                dr("DCTO2") = drS("DCTO2")
                dr("DCTO3") = drS("DCTO3")
                dr("DCTO4") = drS("DCTO4")
                dr("DCTO5") = drS("DCTO5")

                dr("RAT_PROG_TARGET_1") = drS("RAT_PROG_TARGET_1")
                dr("SHR_PROG_TARGET_1") = drS("SHR_PROG_TARGET_1")
                dr("AFF_PROG_TARGET_1") = drS("AFF_PROG_TARGET_1")
                dr("RCH_PROG_TARGET_1") = drS("RCH_PROG_TARGET_1")
                dr("RAT_M_PROG_TARGET_1") = drS("RAT_M_PROG_TARGET_1")
                dr("FID_PROG_TARGET_1") = drS("FID_PROG_TARGET_1")

                dr("RAT_TANDA_TARGET_1") = drS("RAT_TANDA_TARGET_1")
                dr("SHR_TANDA_TARGET_1") = drS("SHR_TANDA_TARGET_1")
                dr("AFF_TANDA_TARGET_1") = drS("AFF_TANDA_TARGET_1")
                dr("RCH_TANDA_TARGET_1") = drS("RCH_TANDA_TARGET_1")
                dr("RAT_M_TANDA_TARGET_1") = drS("RAT_M_TANDA_TARGET_1")
                dr("FID_TANDA_TARGET_1") = drS("FID_TANDA_TARGET_1")

                dr("RAT_PROG_TARGET_2") = drS("RAT_PROG_TARGET_2")
                dr("SHR_PROG_TARGET_2") = drS("SHR_PROG_TARGET_2")
                dr("AFF_PROG_TARGET_2") = drS("AFF_PROG_TARGET_2")
                dr("RCH_PROG_TARGET_2") = drS("RCH_PROG_TARGET_2")
                dr("RAT_M_PROG_TARGET_2") = drS("RAT_M_PROG_TARGET_2")
                dr("FID_PROG_TARGET_2") = drS("FID_PROG_TARGET_2")

                dr("RAT_TANDA_TARGET_2") = drS("RAT_TANDA_TARGET_2")
                dr("SHR_TANDA_TARGET_2") = drS("SHR_TANDA_TARGET_2")
                dr("AFF_TANDA_TARGET_2") = drS("AFF_TANDA_TARGET_2")
                dr("RCH_TANDA_TARGET_2") = drS("RCH_TANDA_TARGET_2")
                dr("RAT_M_TANDA_TARGET_2") = drS("RAT_M_TANDA_TARGET_2")
                dr("FID_TANDA_TARGET_2") = drS("FID_TANDA_TARGET_2")

                If drS(GrillAdmin.ColumnaRatingTarget1) = 0 Then
                    dr("CPR") = 0
                Else
                    dr("CPR") = dr("Neto") / drS(GrillAdmin.ColumnaRatingTarget1)
                End If



                If drS(GrillAdmin.ColumnaRatingTarget1) Is DBNull.Value Or drS(GrillAdmin.ColumnaRatingTarget1) Is DBNull.Value Then
                    dr("Afinidad") = 0
                Else
                    dr("Afinidad") = Me.ObtenerAfinidad(drS(GrillAdmin.ColumnaRatingTarget1), drS(GrillAdmin.ColumnaRatingTarget2))
                End If

                DtGrilla.Rows.Add(dr)
                i = i + 1
            Next

        Catch ex As Exception
            MsgBox("DT GRID - " & ex.Message)
        End Try

        Return DtGrilla
    End Function

    Private Function CargarSpotsTVC(ByVal dtTarifas As DataTable, ByVal dtAudiencia As DataTable, ByVal DtSpot As DataTable, ByVal idCampania As Int64, ByVal idSistema As Int64, ByVal idEjer As Int64, ByVal Target1 As Int64, ByVal Target2 As Int64) As DataTable
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow
        Dim ids As Long = Me.ObtenerProximoIdSpot(DtSpot)

        For j = 0 To dtTarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = DtSpot.NewRow
            Try
                ColRow = dtAudiencia.Select("ID_TARIFA_TV=" & dtTarifas.Rows(j).Item("ID_TARIFA_TV"))


                If ColRow.Length >= 1 Then
                    k = k + 1
                    Dr("ID_Spot") = ids + k

                    Dr("ID_Campania") = idCampania
                    Dr("ID_Sistema") = idSistema
                    Dr("ID_Ejercicio") = idEjer
                    Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = dtTarifas.Rows(j)("Programa")
                    Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    ' Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")

                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    ' ----------------------------------------

                    'asigna los valores dependiendo los targets y tipo de planificacion
                    If ColRow(0)("Id_Target_1") = Target1 Then
                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("Rating 1") * Deflactacion), "0.00") 'ColRow(0)("Rating 1")
                    Else
                        Dr("RAT_PROG_TARGET_1") = 0
                    End If

                    If ColRow(0)("Id_Target_2") = Target2 Then
                        Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("Rating 2") * Deflactacion), "0.00") 'ColRow(0)("Rating 2")
                    Else
                        Dr("RAT_PROG_TARGET_2") = 0
                    End If
                    Dr("RAT_TANDA_TARGET_1") = 0
                    Dr("RAT_TANDA_TARGET_2") = 0
                    DtSpot.Rows.Add(Dr)



                Else
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(DtSpot) + k
                    Dr("ID_Campania") = idCampania
                    Dr("ID_Sistema") = idSistema
                    Dr("ID_Ejercicio") = idEjer
                    Dr("ID_Soporte") = dtTarifas.Rows(j)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = dtTarifas.Rows(j)("Programa")
                    Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    ' Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    '----------------------------------------

                    'asigna los valores dependiendo los targets y tipo de planificacion

                    Dr("RAT_PROG_TARGET_1") = 0 '-1 AG Hoja Numero
                    Dr("RAT_PROG_TARGET_2") = 0 '-1 AG Hoja Numero
                    Dr("RAT_TANDA_TARGET_1") = 0 '-1 AG Hoja Numero
                    Dr("RAT_TANDA_TARGET_2") = 0 '-1 AG Hoja Numero
                    DtSpot.Rows.Add(Dr)

                End If
            Catch e As Exception
                MsgBox(e.Message)

            End Try

        Next
        SpotBase = DtSpot.Copy
        Return DtSpot
    End Function

    Private Function CargarSpotsTVI(ByVal dtTarifas As DataTable, ByVal dtAudiencia As DataTable, ByVal DtSpot As DataTable, ByVal idCampania As Int64, ByVal idSistema As Int64, ByVal idEjer As Int64, ByVal Target1 As Int64, ByVal Target2 As Int64) As DataTable
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow

        For j = 0 To dtTarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = DtSpot.NewRow
            Try
                ColRow = dtAudiencia.Select("ID_TARIFA_TV=" & dtTarifas.Rows(j).Item("ID_TARIFA_TV"))


                If ColRow.Length >= 1 Then
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(DtSpot) + k

                    Dr("ID_Campania") = idCampania
                    Dr("ID_Sistema") = idSistema
                    Dr("ID_Ejercicio") = idEjer
                    Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = dtTarifas.Rows(j)("Programa")
                    Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    '  Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")

                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    '----------------------------------------

                    'asigna los valores dependiendo los targets y tipo de planificacion
                    If ColRow(0)("Id_Target_1") = Target1 Then
                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("Rating 1") * Deflactacion), "0.00") 'ColRow(0)("Rating 1")
                    Else
                        Dr("RAT_PROG_TARGET_1") = 0
                    End If

                    If ColRow(0)("Id_Target_2") = Target2 Then
                        Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("Rating 2") * Deflactacion), "0.00") 'ColRow(0)("Rating 2")
                    Else
                        Dr("RAT_PROG_TARGET_2") = 0
                    End If
                    Dr("RAT_TANDA_TARGET_1") = 0
                    Dr("RAT_TANDA_TARGET_2") = 0
                    DtSpot.Rows.Add(Dr)
                    ' k = k + 1
                Else
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(DtSpot) + k
                    Dr("ID_Campania") = idCampania
                    Dr("ID_Sistema") = idSistema
                    Dr("ID_Ejercicio") = idEjer
                    Dr("ID_Soporte") = dtTarifas.Rows(j)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = dtTarifas.Rows(j)("Programa")
                    Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    'Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    '----------------------------------------

                    'asigna los valores dependiendo los targets y tipo de planificacion

                    Dr("RAT_PROG_TARGET_1") = 0 '-1 AG Hoja Numero
                    Dr("RAT_PROG_TARGET_2") = 0 '-1 AG Hoja Numero
                    Dr("RAT_TANDA_TARGET_1") = 0 '-1 AG Hoja Numero
                    Dr("RAT_TANDA_TARGET_2") = 0 '-1 AG Hoja Numero
                    DtSpot.Rows.Add(Dr)

                End If
            Catch e As Exception
            End Try

        Next
        SpotBase = DtSpot.Copy
        Return DtSpot
    End Function

    Private Function CargarSpotsRadio(ByVal dtTarifas As DataTable, ByVal dtAudiencia As DataTable, ByVal DtSpot As DataTable, ByVal idCampania As Int64, ByVal idSistema As Int64, ByVal idEjer As Int64, ByVal Target1 As Int64, ByVal Target2 As Int64) As DataTable
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow

        For j = 0 To dtTarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = DtSpot.NewRow
            Try
                ColRow = dtAudiencia.Select("ID_TARIFA_TV=" & dtTarifas.Rows(j).Item("ID_TARIFA_TV"))


                If ColRow.Length >= 1 Then
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(DtSpot) + k

                    Dr("ID_Campania") = idCampania
                    Dr("ID_Sistema") = idSistema
                    Dr("ID_Ejercicio") = idEjer
                    Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = dtTarifas.Rows(j)("Programa")
                    Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    '  Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")

                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    '----------------------------------------

                    Dr("RAT_PROG_TARGET_1") = ColRow(0)("PROMEDIO")
                    Dr("RAT_PROG_TARGET_2") = 0
                    Dr("RAT_TANDA_TARGET_1") = 0
                    Dr("RAT_TANDA_TARGET_2") = 0
                    DtSpot.Rows.Add(Dr)
                    ' k = k + 1
                Else
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(DtSpot) + k
                    Dr("ID_Campania") = idCampania
                    Dr("ID_Sistema") = idSistema
                    Dr("ID_Ejercicio") = idEjer
                    Dr("ID_Soporte") = dtTarifas.Rows(j)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = dtTarifas.Rows(j)("Programa")
                    Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    'Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")

                    Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    '------------AGREGADO ESPECIALES---------
                    If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                        If dtTarifas.Rows(j)("ind_especial") > 0 Then
                            AvisosEspeciales.Add(Dr("ID_Spot"))
                        End If
                    End If
                    '----------------------------------------

                    'asigna los valores dependiendo los targets y tipo de planificacion

                    Dr("RAT_PROG_TARGET_1") = -1
                    Dr("RAT_PROG_TARGET_2") = -1
                    Dr("RAT_TANDA_TARGET_1") = -1
                    Dr("RAT_TANDA_TARGET_2") = -1
                    DtSpot.Rows.Add(Dr)
                    'k = k + 1
                End If


            Catch e As Exception
                ' = k + 1

            End Try

        Next
        SpotBase = DtSpot.Copy
        Return DtSpot
    End Function

    Private Sub iugEjercicio_AfterSortChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BandEventArgs) Handles iugEjercicio.AfterSortChange
        Me.UltraDataSource1 = Me.iugEjercicio.DataSource
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        DuplicarFila()
    End Sub
    Private Sub EjecutarCompra(ByVal Ur As UltraDataRow)
        LetraValida = True
        For Each Uc As UltraDataColumn In Ur.Band.Columns
            If GrillAdmin.EsColumnaCalendario(Uc) Then
                Dim C As New CellDataUpdatingEventArgs(Ur, Uc, Ur.Item(Uc.Key))

                KeyCompra = Uc.Key
                TextCompra = IIf(IsDBNull(Ur.Item(Uc.Key)), "", Ur.Item(Uc.Key))
                IDSpotCompra = Ur.Item("id_spot")
                Me.UltimoText = ""

                If TextCompra <> "" Then
                    Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(Ur.Item("id_spot"))

                    GrillAdmin.AgregarHijo(Me.UltraDataSource1, Me.DetalleBase, Fila.Index, KeyCompra, TextCompra, Me.ColumnasHijos, dtTemas, IDSpotCompra)

                    Listas.OcultarHeader(iugEjercicio)
                    GrillaFormato.ReocultarColumnasHijos(iugEjercicio)

                    GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit)
                    GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Moneda, "Total Bruto", "Total Neto")
                    GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Decimales, "Total GRP Target 1", "Total GRP Target 2")
                    GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.General, "Total Spots", "DUR")
                    GrillaFormato.CambiarAlineacionColumna(iugEjercicio)

                    For Each b As UltraGridBand In iugEjercicio.DisplayLayout.Bands
                        If b.Index > 0 Then
                            GrillaFormato.FijarColumna(b.Columns("Tema"), True)
                            GrillaFormato.FijarColumna(iugEjercicio.DisplayLayout.Bands(b.Index).Columns(b.Columns("tema").Index + 4), True)
                            GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, b.Index, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")
                        End If
                    Next

                    'AG Hoja Numero =========================
                    If Activo.IDMedio = MedioTv Then
                        GrillaFormato.HabilitarEdicionColumnaHijo(iugEjercicio, Activation.NoEdit, Activation.AllowEdit)
                    End If
                    '========================================

                    GrillaFormato.MoverColumnaTema(iugEjercicio, 3)

                    '*** recalcula los cuadros, acumulando la cantidad de temas y sumando las duraciones
                    Dim CompraAnterior As String = Me.UltimoText
                    Dim CompraActual As String = IIf(IsDBNull(TextCompra), "", TextCompra)

                    Me.CalcularGrillasResumen(CompraAnterior.ToUpper, CompraActual.ToUpper, Fila, KeyCompra)

                    Me.UltimoText = IIf(IsDBNull(TextCompra), "", TextCompra)
                End If
            End If
        Next
        LetraValida = False

    End Sub

    Private Function DuplicarFila(Optional ByVal Comprados As Boolean = True, Optional ByVal EstaBonificado As Boolean = False) As UltraDataRow
        If iugEjercicio.ActiveRow Is Nothing OrElse iugEjercicio.ActiveRow.Band.Index > 0 Then
            Exit Function
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim AgregarHijos As Boolean

        If Activo.IDMedio <> MedioRadio Then
            'si tiene hijos, pregunta si desea duplicarlos tambien
            If Me.iugEjercicio.ActiveRow.HasChild Then
                If Comprados Then
                    If Mensajes.Mensaje("¿Desea Duplicar los Temas Comprados?", TipoMensaje.SiNo) = DialogResult.Yes Then
                        AgregarHijos = True
                    Else
                        AgregarHijos = False
                    End If
                Else
                    AgregarHijos = False
                End If
            Else
                AgregarHijos = False
            End If
        Else
            AgregarHijos = True
        End If

        Dim Ur As UltraDataRow
        'Dim Uc As UltraDataColumn

        'duplica la fila programa
        Ur = GrillAdmin.AgregarFila(Me.UltraDataSource1, Me.iugEjercicio, iugEjercicio.ActiveRow.Index, SpotBase, AgregarHijos, EstaBonificado)

        'ejecuta el evento de compra, para duplicar las filas hijas
        If AgregarHijos Then
            EjecutarCompra(Ur)
            'Duplica los temas del programa a duplicar
            If Activo.IDMedio = MedioRadio Then
                GrillAdmin.AgregarHijo(Me.UltraDataSource1, Ur, Me.ColumnasHijos, dtTemas)
            End If
        End If

        'AG ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If EstaBonificado = True Then
            Dim IRow As Integer = iugEjercicio.ActiveRow.Index + 1
            If Me.iugEjercicio.Rows(IRow).Cells("id_convenio").Value = 0 Then
                Me.iugEjercicio.Rows(IRow).Cells("dcto1").Appearance.BackColor = Color.White
                Me.iugEjercicio.Rows(IRow).Cells("dcto2").Appearance.BackColor = Color.White
                Me.iugEjercicio.Rows(IRow).Cells("dcto3").Appearance.BackColor = Color.White
                Me.iugEjercicio.Rows(IRow).Cells("dcto4").Appearance.BackColor = Color.White
                Me.iugEjercicio.Rows(IRow).Cells("dcto5").Appearance.BackColor = Color.White
            End If
        End If

        'AG ++++++++++++++++++++++++++++++++++++++++++++++++++++
        If EstaBonificado = False Then
            Dim IFila As Integer = iugEjercicio.ActiveRow.Index + 1
            If Me.iugEjercicio.Rows(IFila).Cells("id_convenio").Value = -1 Then
                Me.iugEjercicio.Rows(IFila).Cells("dcto1").Appearance.BackColor = Color.Bisque
                Me.iugEjercicio.Rows(IFila).Cells("dcto2").Appearance.BackColor = Color.Bisque
                Me.iugEjercicio.Rows(IFila).Cells("dcto3").Appearance.BackColor = Color.Bisque
                Me.iugEjercicio.Rows(IFila).Cells("dcto4").Appearance.BackColor = Color.Bisque
                Me.iugEjercicio.Rows(IFila).Cells("dcto5").Appearance.BackColor = Color.Bisque
            End If
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++

        GrillaFormato.MarcarDiasPrograma(Me.iugEjercicio, ColorDia, ColorVigenciaNula)
        GrillaFormato.MarcarDiaEvento(iugEjercicio, Ur, iugEjercicio.ActiveRow, Me.ColorDiaEspecial)

        'AG Hoja Numero =========================
        If Activo.IDMedio = MedioTv Then
            GrillaFormato.HabilitarEdicionColumnaHijo(iugEjercicio, Activation.NoEdit, Activation.AllowEdit)
        End If
        '========================================

        Me.Cursor = Cursors.Default
        Return Ur
    End Function
    Private Sub ActualizarEjercicio()

        With Actual
            .IDCampaña = Activo.IDCampaña
            .IDCliente = Activo.IDCliente
            .IDEjercicio = Activo.IDEjercicio
            .IDEstadoEjercicio = Activo.IDEstadoEjercicio
            .IDMedio = Activo.IDMedio
            .IDPlaza = Activo.IDPlaza
            .IDSistema = Activo.IDSistema
            .IDTipoSoporte = Activo.IDTipoSoporte
            .Sistema = Activo.Sistema
            .Target = Activo.Target
            .Campaña = Activo.Campaña
            .Cliente = Activo.Cliente
            .Ejercicio = Activo.Ejercicio
            .Especiales = Activo.Especiales
            .Estado = Activo.Estado
            .FechaDesdeCampaña = Activo.FechaDesdeCampaña
            .FechaFinAudiencia = Activo.FechaFinAudiencia
            .FechaFinCampaña = Activo.FechaFinCampaña
            .FechaFinSistema = Activo.FechaFinSistema
            .FechaHastaCampaña = Activo.FechaHastaCampaña
            .FechaInicioAudiencia = Activo.FechaInicioAudiencia
            .FechaInicioCampaña = Activo.FechaInicioCampaña
            .FechaInicioSistema = Activo.FechaInicioSistema
        End With

    End Sub

    Private Sub frmEjercicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarEjercicio()
        Activo.Control = False

        Me.Text = Activo.Cliente & " -- " & Actual.Campaña & " - " & Actual.Sistema & " - " & Actual.Ejercicio

        'AG 05/06/2014 ====================================================================
        If Activo.IDTipoEjercicio <> 1 Then
            GrillaFormato.MarcarDiasPrograma(iugEjercicio, ColorDia, ColorVigenciaNula)
        End If
        'GrillaFormato.MarcarDiasPrograma(iugEjercicio, ColorDia, ColorVigenciaNula)
        '==================================================================================

        'ColorSinAudiencia()

        GrillaFormato.MarcarCeldasModificadas(iugEjercicio, Me.ColorCambioManual)

        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Moneda, "Total Bruto", "Total Neto")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Decimales, "Total GRP Target 1", "Total GRP Target 2")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.General, "Total Spots", "DUR")
        GrillaFormato.CambiarAlineacionColumna(iugEjercicio)
        iugEjercicio.DisplayLayout.Override.ExpansionIndicator = ShowExpansionIndicator.Always
        iugEjercicio.DisplayLayout.Override.DefaultColWidth = 38

        ' COMENTO POR PERFORMANCE (AN 14-10-2015)
        For Each c As UltraGridColumn In iugEjercicio.DisplayLayout.Bands(0).Columns
            c.PerformAutoResize(PerformAutoSizeType.AllRowsInBand)
        Next


        'Dim contador As Integer
        'For contador = 0 To 60
        '    iugEjercicio.DisplayLayout.Bands(0).Columns(contador).PerformAutoResize(PerformAutoSizeType.AllRowsInBand)
        'Next

        iugEjercicio.DisplayLayout.Bands(0).Columns("Total GRP Target 1").PerformAutoResize(PerformAutoSizeType.AllRowsInBand)
        iugEjercicio.DisplayLayout.Bands(0).Columns("Total GRP Target 2").PerformAutoResize(PerformAutoSizeType.AllRowsInBand)
        iugEjercicio.DisplayLayout.Bands(0).Columns("Total Spots").PerformAutoResize(PerformAutoSizeType.AllRowsInBand)
        iugEjercicio.DisplayLayout.Bands(0).Columns("Total Bruto").PerformAutoResize(PerformAutoSizeType.AllRowsInBand)
        iugEjercicio.DisplayLayout.Bands(0).Columns("Total Neto").PerformAutoResize(PerformAutoSizeType.AllRowsInBand)

        'iugEjercicio.DisplayLayout.Bands(0).Override.ColumnAutoSizeMode = ColumnAutoSizeMode.VisibleRows

        GrillaFormato.CambiarTamañoColumna(iugEjercicio, 38)

        BuscarDirectorio(Ruta)
        PosicionCalendario()


        If Not EsCargaDeCero Then
            If ComprobarActualizacion(SoportesActualizados) Then
                'AG 05/06/2014 Tarifas Automaticas ===================================================================================
                'If Mensajes.Mensaje("Se han detectado nuevas tarifas.¿Desea Actualizar?", TipoMensaje.SiNo) = DialogResult.Yes Then
                If Activo.IDTipoEjercicio = 1 Then
                    'Me.CargarSoportes(True)
                    'Mensajes.Mensaje("Se han actualizado las nuevas tarifas.", TipoMensaje.Informacion)
                Else
                    Me.CargarSoportes(True)
                    Mensajes.Mensaje("Se han actualizado las nuevas tarifas.", TipoMensaje.Informacion)
                    'If Mensajes.Mensaje("Se han detectado nuevas tarifas.¿Desea Actualizar?", TipoMensaje.SiNo) = DialogResult.Yes Then
                    '    Me.CargarSoportes(True)
                    'End If
                End If
                'End If
                '=====================================================================================================================
            End If
        End If

        'AG Hoja Numero =========================
        If Activo.IDMedio = MedioTv Then
            If Not EsCargaDeCero Then
                GrillaFormato.HabilitarEdicionColumnaHijo(iugEjercicio, Activation.NoEdit, Activation.AllowEdit)
            End If
        End If
        '========================================

        If Activo.IDMedio = MedioRadio Then
            tblAcciones.Toolbars(0).Tools("ExpandirColapsar").SharedProps.Visible = True
            GrillaFormato.HabilitarEdicionColumnaHijo(iugEjercicio, Activation.NoEdit, Activation.AllowEdit)
        End If
        ' iugEjercicio.DisplayLayout.Override.AllowColSizing = AllowColSizing.None

        Me.pivotFlex.OptionsMenu.EnableHeaderMenu = True

        Dim label As New Label()
        label.Text = "Refrescando datos"
        label.BackColor = System.Drawing.SystemColors.ButtonFace
    End Sub

    Private Sub PrepararResumenes()
        Dim Dr As DataRow

        Me.Cursor = Cursors.WaitCursor

        '*** FRANJAS
        Dim F As New Franjas_Detalle
        Franjas = F.ObtenerPorCliente(Activo.IDCliente, Me.IDFranja)

        'si el cliente no tiene franjas, se toman las del cliente 0
        If Franjas Is Nothing OrElse Franjas.Rows.Count = 0 Then
            Franjas = F.ObtenerPorCliente(0, 1)
        End If

        'agrega 2 columnas para llevar la cuenta de los temas y la suma de la duracion (para sacar la duracion promedio)
        Franjas.Columns.Add("SumaDuracion", GetType(Single))
        Franjas.Columns.Add("CantidadTemas", GetType(Single))

        'inicializa los valores a CERO
        For Each Dr In Franjas.Rows
            Dr("SumaDuracion") = 0
            Dr("CantidadTemas") = 0
        Next

        '*** SEMANAS

        'arma un array con obejto Semana que guardan las semanas del calendario y mantiene la cuenta de los temas
        'y la suma de las duraciones para sacar la duracion promedio
        Semanas = GrillaResumen.ObtenerSemanas7Dias(Me.UltraDataSource1, Activo.FechaFinSistema)

        '*** SOPORTES
        Me.SoportesDuracion = New ArrayList

        If TypeOf AuxSoportes Is DataTable Then
            'si se carga de la base, se recorre un datatable
            For Each Dr In DirectCast(AuxSoportes, DataTable).Rows
                Dim SD As New SoporteDuracion

                SD.IDSoporte = Dr("id_soporte")

                If Dr("descripcion").ToString = String.Empty Then
                    SD.Soporte = ""
                Else
                    SD.Soporte = Dr("descripcion")
                End If

                SD.CantidadTemas = 0
                SD.TotalDuracion = 0

                Me.SoportesDuracion.Add(SD)
            Next
        Else
            'si se carga por 1ra vez, recorre un array li st
            Dim IL As ItemLista

            For Each IL In DirectCast(AuxSoportes, ArrayList)
                Dim SD As New SoporteDuracion

                SD.IDSoporte = IL.ID
                SD.Soporte = IL.Descripcion
                SD.CantidadTemas = 0
                SD.TotalDuracion = 0

                Me.SoportesDuracion.Add(SD)
            Next
        End If

        GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas)

        'AG Velocidad =========================================================================
        GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
        Exit Sub
        '==========================================================================================

        Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)
        Me.iugTema.DataSource = GrillaResumen.GrillaPorTema(Me.UltraDataSource1, dtTemas)
        Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas, Activo.FechaFinSistema)
        Me.iugFranja.DataSource = GrillaResumen.GrillaPorFranja(Me.UltraDataSource1, Franjas, dtTemas)

        'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR)
        GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "% Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Tarifa Neta", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "% Tarifa Neta", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "CPR", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Bruto", Formato.Moneda)
        'GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "CantidadTemas", Formato.Numero)

        GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "bruto", HAlign.Right)
        GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "CantidadTemas", HAlign.Right)
        GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "PorcentajeDuracion", HAlign.Right)

        GrillaFormato.AcivarOperacion(Me.iugSoporte, "Bruto", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        GrillaFormato.AcivarOperacion(Me.iugSoporte, "CantidadTemas", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        GrillaFormato.AcivarOperacion(Me.iugSoporte, "PorcentajeDuracion", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")

        Listas.CambiarTituloColumna(Me.iugSoporte, "CantidadTemas", "Temas")
        Listas.CambiarTituloColumna(Me.iugSoporte, "PorcentajeDuracion", "% Dur.")

        GrillaFormato.HabilitarEdicionColumna(Me.iugSoporte, Activation.NoEdit, False)
        Listas.OcultarColumnas(Me.iugSoporte, "id_soporte", "SumaDuracion") ', "CantidadTemas", "PorcentajeDuracion")

        GrillaFormato.AutoAjustarColumnas(Me.iugSoporte)
        Me.AgregarSumatoriasDesgloses(Me.iugSoporte)

        GrillaFormato.CambiarFormatoColumna(Me.iugTema, "Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugTema, "% Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugTema, "Tarifa Neta", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.iugTema, "% Tarifa Neta", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugTema, "CPR", Formato.Decimales)
        GrillaFormato.HabilitarEdicionColumna(Me.iugTema, Activation.NoEdit, False)
        Listas.OcultarColumnas(Me.iugTema, "id_tema", "Duracion")
        GrillaFormato.AutoAjustarColumnas(Me.iugTema)
        GrillaFormato.CambiarAlineacionColumna(Me.iugTema, "Temas", HAlign.Right)
        Me.AgregarSumatoriasDesgloses(Me.iugTema)
        GrillaFormato.AcivarOperacion(Me.iugTema, "Temas", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")

        GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "% Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "Tarifa Neta", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "% Tarifa Neta", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "CPR", Formato.Decimales)
        GrillaFormato.HabilitarEdicionColumna(Me.iugSemana, Activation.NoEdit, False)
        Listas.OcultarColumnas(Me.iugSemana, "f_inicio", "f_fin", "SumaDuracion", "CantidadTemas")
        GrillaFormato.AutoAjustarColumnas(Me.iugSemana)
        Me.AgregarSumatoriasDesgloses(Me.iugSemana)

        GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "% Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "Tarifa Neta", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "% Tarifa Neta", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "CPR", Formato.Decimales)
        Listas.CambiarTituloColumna(Me.iugFranja, "CantidadTemas", "Temas")
        GrillaFormato.HabilitarEdicionColumna(Me.iugFranja, Activation.NoEdit, False)
        Listas.OcultarColumnas(Me.iugFranja, "h_desde", "h_hasta", "SumaDuracion")
        GrillaFormato.CambiarAlineacionColumna(Me.iugFranja, "CantidadTemas", HAlign.Right)
        GrillaFormato.AutoAjustarColumnas(Me.iugFranja)
        GrillaFormato.AcivarOperacion(Me.iugFranja, "CantidadTemas", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        Me.AgregarSumatoriasDesgloses(Me.iugFranja)

        'Me.iugSemana.DataSource = Me.SpotBase
        If Activo.IDMedio = MedioRadio Then
            Me.UltraDockManager1.ControlPanes("franja").Close()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AgregarSumatoriasDesgloses(ByVal Grilla As UltraGrid)

        ''AG Velocidad =====================================================================================================================
        GrillaFormato.AcivarOperacion(Grilla, "Grps", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###0.00}")
        GrillaFormato.AcivarOperacion(Grilla, "% Grps", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:#####}")
        GrillaFormato.AcivarOperacion(Grilla, "Tarifa Neta", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###0.00}")
        GrillaFormato.AcivarOperacion(Grilla, "% Tarifa Neta", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:#####}")

        'GrillaFormato.AcivarOperacion(Grilla, "CPR", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###0.00}")
        '===================================================================================================================================
        ActualizarCpr(Grilla)

    End Sub
    Private Sub ActualizarCpr(ByVal grilla As UltraGrid)
        Dim CalculoCpr As New CalculoCPR
        CalculoCpr.lblCPR = lblCPR
        grilla.DisplayLayout.Bands(0).Summaries.Add("CPR", SummaryType.Custom, CalculoCpr, grilla.DisplayLayout.Bands(0).Columns("CPR"), SummaryPosition.UseSummaryPositionColumn, Nothing).DisplayFormat = "{0:$ ##,###0.00}"
    End Sub
    Private Sub CalcularDuracionPromedio(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Fila As UltraDataRow, ByVal Columna As String)
        'va acumulando los temas y sumando las duraciones para sacar la duracion promedio
        'para cada cuadro de resumen o desglose

        If Not GrillAdmin.EsColumnaCalendario(Columna) Then
            Exit Sub
        End If

        'actualiza la duracion promedio para cada franjas
        GrillaResumen.DuracionFranja(CompraAnterior, CompraActual, _
            Fila("h_inicio").ToString.Substring(0, 2), Fila("h_fin").ToString.Substring(0, 2), dtTemas)

        'actualiza la duracion promedio para cada soporte
        GrillaResumen.DuracionSoporte(Fila("id_soporte"), CompraAnterior, CompraActual _
            , Me.SoportesDuracion, dtTemas)

        'actualiza la duracion promedio para cada semanas
        GrillaResumen.DuracionSemana(Columna, CompraAnterior, _
            CompraActual, Me.Semanas, dtTemas)
    End Sub

    Private Sub iugEjercicio_AfterEnterEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles iugEjercicio.AfterEnterEditMode
        Me.UltimoText = Me.iugEjercicio.ActiveCell.Text

        If Me.iugEjercicio.ActiveCell.IsInEditMode Then
            ' Agrego el if para que seleccione el texto si es una columna de numeros
            If Not iugEjercicio.ActiveCell.Column.DataType Is GetType(Single) And Not iugEjercicio.ActiveCell.Column.DataType Is GetType(Double) And Not iugEjercicio.ActiveCell.Column.DataType Is GetType(Integer) Then
                Me.iugEjercicio.ActiveCell.SelStart = Me.iugEjercicio.ActiveCell.Text.Length
                Me.iugEjercicio.ActiveCell.SelLength = 0
            End If
        End If
    End Sub

    Private Sub DuracionFranja(ByVal Fila As UltraGridRow, ByVal Duracion As Integer)
        '*** actualiza la duracion promedio para la franja
        If Fila.Cells("h_inicio").Text <> "" Then

            'calcula la duracion promedio para sacar el cuadro de resumen por franja
            Dim Franja As DataRow

            For Each Franja In Franjas.Rows
                If Fila.Cells("H_inicio").Text.Substring(0, 2) >= Franja("h_desde") And Fila.Cells("H_inicio").Text.Substring(0, 2) <= Franja("h_hasta") Then
                    Franja("CantidadTemas") += 1
                    Franja("SumaDuracion") += Duracion
                End If
            Next
        End If
    End Sub

    Private Sub DuracionSoporte(ByVal Fila As UltraGridRow, ByVal Duracion As Integer)
        '*** actualiza la duracion promedio para los soportes
        Dim SD As SoporteDuracion

        For Each SD In Me.SoportesDuracion
            If Fila.Cells("id_soporte").Value = SD.IDSoporte Then
                SD.CantidadTemas += 1
                SD.TotalDuracion += Duracion
            End If
        Next
    End Sub

    Private Sub DuracionSemana(ByVal Columna As Date, ByVal Duracion As Integer)
        Dim S As Semana

        For Each S In Semanas
            If Columna >= S.FechaInicio And Columna <= S.FechaFin Then
                S.CantidadSpots += 1
                S.TotalDuracion += Duracion
            End If
        Next
    End Sub

    Private Sub tblAcciones_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles tblAcciones.ToolClick

        Select Case e.Tool.Key
            Case "guardar"
                Guardar()

            Case "borrar"
                Me.mnuBorrar_Click(Me.iugEjercicio, New EventArgs)

                Me.HayCambios = True

            Case "preevaluacion"
                ModificarTarifasCongeladas()
                'iugSoporte.DataSource = Me.DetalleBase

            Case "soportes"
                Dim i As Integer = Me.iugEjercicio.Rows.Count

                Me.CargarSoportes()

                If Me.iugEjercicio.Rows.Count > i Then
                    Me.HayCambios = True
                End If
            Case "puntual"
                Me.CargarConvenioPuntual()

                Me.HayCambios = True
            Case "global"
                Me.CargarConvenioGlobal()

                Me.HayCambios = True

            Case "ocultarcolumnas"
                Dim f As New frmColumnas

                f.Grid = iugEjercicio
                f.ExcluirColumnas("ID_SPOT", "Id", "ID_TARIFA_TV", "id_convenio", "ID_PROGRAMA", "ID_Soporte", "Tipo_Planificacion", "f_fin_vig", "f_inicio_vig", "soporte", "programa", "dias", "h_inicio", "h_fin", "total neto", "desc_campania", "desc_sistema", "desc_ejercicio") ', "f_modi", "u_modi") ', "f_accion", "u_accion")
                f.Mostrar()
            Case "imprimir"
                Me.ImprimirGrilla()


            Case "abrirperfil"
                ' CargarXML("c:\file.xml")
                Dim f As New frmPerfiles
                f.Ruta = Ruta
                f.Grid = iugEjercicio
                f.ShowDialog()

            Case "guardarperfil"
                Dim n As String = InputBox("Nombre del Perfil").Trim
                If n = "" Or n.ToLower = "usuario" Then
                    Exit Sub
                End If
                CrearXML(n)
            Case "exportar"
                Exportar()

            Case "cmdcubo"
                MostrarCubo()
            Case "cubo2"
                MostarCuboDesglose()
            Case "excel"
                ExprotarTodo()
            Case "ExpandirColapsar"
                ExpandirColapsar()

                'AG 21/07/2014 ============
            Case "ReporteLine"
                ReporteLine()


        End Select
    End Sub
#Region "ExportarTodo"
    Private Sub ExprotarTodo()
        Dim scd As New SaveFileDialog
        Dim Archivo As String
        scd.CheckPathExists = True
        scd.OverwritePrompt = True
        Dim Exportacion As Boolean = True
        Try
            scd.Filter = "Microsoft Excel (*.xls)|*.xls"
            scd.ShowDialog()

            If scd.FileName.Trim = "" Then
                Exit Sub
            End If
            Archivo = scd.FileName

            iugExport.DataSource = CrearDtAExportar(Exportacion)

            AplicarFormato(iugExport, Exportacion)

            If Exportacion Then
                ugExportar.Export(iugExport, Archivo)
                Mensajes.Mensaje("La Exportación Finalizo Correctamente", TipoMensaje.Informacion)
            End If

        Catch ex As IOException
            Mensajes.Mensaje("No Se puede Reemplazar Un Archivo Abierto.", TipoMensaje.DeError)
            Exit Sub
        End Try
    End Sub
    Private Sub AplicarFormato(ByVal Grid As UltraGrid, ByRef Correcto As Boolean)
        Try
            'GrillaFormato.WarpHeader(Grid, DefaultableBoolean.True)
            For Each c As UltraGridColumn In Grid.DisplayLayout.Bands(0).Columns
                If Not c.Hidden Then
                    Select Case c.Key
                        Case "PROGRAMA"
                            Listas.CambiarTituloColumna(Grid, "PROGRAMA", "Programa")
                        Case "H_INICIO"
                            Listas.CambiarTituloColumna(Grid, "H_INICIO", "Hs. Inicio")
                        Case "H_FIN"
                            Listas.CambiarTituloColumna(Grid, "H_FIN", "Hs. Fin")
                        Case "BRUTO"
                            Listas.CambiarTituloColumna(Grid, "BRUTO", "Bruto Actual")
                            GrillaFormato.CambiarFormatoColumna(Grid, "BRUTO", Formato.Moneda)
                        Case "brutoactual"
                            Listas.CambiarTituloColumna(Grid, "brutoactual", "Tarifa Bruta")
                            GrillaFormato.CambiarFormatoColumna(Grid, "brutoactual", Formato.Moneda)
                        Case "NETO"
                            Listas.CambiarTituloColumna(Grid, "NETO", "Tarifa" & vbCrLf & "Neta")
                            GrillaFormato.CambiarFormatoColumna(Grid, "neto", Formato.Moneda)
                        Case "DCTO1"
                            Listas.CambiarTituloColumna(Grid, "DCTO1", "D1")
                        Case "DCTO2"
                            Listas.CambiarTituloColumna(Grid, "DCTO2", "D2")
                        Case "DCTO3"
                            Listas.CambiarTituloColumna(Grid, "DCTO3", "D3")
                        Case "DCTO4"
                            Listas.CambiarTituloColumna(Grid, "DCTO4", "D4")
                        Case "DCTO5"
                            Listas.CambiarTituloColumna(Grid, "DCTO5", "D5")
                        Case "RAT_PROG_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "RAT_PROG_TARGET_1", "RAT % P")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_PROG_TARGET_1", Formato.Decimales)
                        Case "SHR_PROG_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "SHR_PROG_TARGET_1", "SHR P")
                            GrillaFormato.CambiarFormatoColumna(Grid, "SHR_PROG_TARGET_1", Formato.Decimales)
                        Case "AFF_PROG_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "AFF_PROG_TARGET_1", "AFF P")
                            GrillaFormato.CambiarFormatoColumna(Grid, "AFF_PROG_TARGET_1", Formato.Decimales)
                        Case "RCH_PROG_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "RCH_PROG_TARGET_1", "RCH P")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RCH_PROG_TARGET_1", Formato.Decimales)
                        Case "RAT_M_PROG_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "RAT_M_PROG_TARGET_1", "RAT M P")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_M_PROG_TARGET_1", Formato.Decimales)
                        Case "FID_PROG_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "FID_PROG_TARGET_1", "FID P")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_PROG_TARGET_1", Formato.Decimales)
                        Case "RAT_PROG_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "RAT_PROG_TARGET_2", "RAT % P 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_PROG_TARGET_2", Formato.Decimales)
                        Case "RAT_PROG_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "SHR_PROG_TARGET_2", "SHR P 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "SHR_PROG_TARGET_2", Formato.Decimales)
                        Case "AFF_PROG_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "AFF_PROG_TARGET_2", "AFF P 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "AFF_PROG_TARGET_2", Formato.Decimales)
                        Case "AFF_PROG_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "RCH_PROG_TARGET_2", "RCH P 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_PROG_TARGET_1", Formato.Decimales)
                        Case "RAT_M_PROG_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "RAT_M_PROG_TARGET_2", "RAT M P 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_M_PROG_TARGET_2", Formato.Decimales)
                        Case "FID_PROG_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "FID_PROG_TARGET_2", "FID P 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "FID_PROG_TARGET_2", Formato.Decimales)
                        Case "FID_PROG_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "RAT_TANDA_TARGET_1", "RAT % T")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_TANDA_TARGET_1", Formato.Decimales)
                        Case "SHR_TANDA_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "SHR_TANDA_TARGET_1", "SHR T")
                            GrillaFormato.CambiarFormatoColumna(Grid, "SHR_TANDA_TARGET_1", Formato.Decimales)
                        Case "RAT_TANDA_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "RAT_TANDA_TARGET_1", "RAT % T2")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_TANDA_TARGET_1", Formato.Decimales)
                        Case "AFF_TANDA_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "AFF_TANDA_TARGET_1", "AFF T")
                            GrillaFormato.CambiarFormatoColumna(Grid, "AFF_TANDA_TARGET_1", Formato.Decimales)
                        Case "RCH_TANDA_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "RCH_TANDA_TARGET_1", "RCH T")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RCH_TANDA_TARGET_1", Formato.Decimales)
                        Case "RAT_M_TANDA_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "RAT_M_TANDA_TARGET_1", "RAT M T")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_PROG_TARGET_1", Formato.Decimales)
                        Case "FID_TANDA_TARGET_1"
                            Listas.CambiarTituloColumna(Grid, "FID_TANDA_TARGET_1", "FID T")
                            GrillaFormato.CambiarFormatoColumna(Grid, "FID_TANDA_TARGET_1", Formato.Decimales)
                        Case "RAT_TANDA_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "RAT_TANDA_TARGET_2", "RAT % T 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_TANDA_TARGET_2", Formato.Decimales)
                        Case "SHR_TANDA_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "SHR_TANDA_TARGET_2", "SHR T 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "SHR_TANDA_TARGET_2", Formato.Decimales)
                        Case "AFF_TANDA_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "AFF_TANDA_TARGET_2", "AFF T 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "AFF_TANDA_TARGET_2", Formato.Decimales)
                        Case "RCH_TANDA_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "RCH_TANDA_TARGET_2", "RCH T 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RCH_TANDA_TARGET_2", Formato.Decimales)
                        Case "RAT_M_TANDA_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "RAT_M_TANDA_TARGET_2", "RAT M T 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "RAT_M_TANDA_TARGET_2", Formato.Decimales)
                        Case "FID_TANDA_TARGET_2"
                            Listas.CambiarTituloColumna(Grid, "FID_TANDA_TARGET_2", "FID T 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "FID_TANDA_TARGET_2", Formato.Decimales)
                        Case "Total GRP Target 1"
                            Listas.CambiarTituloColumna(Grid, "Total GRP Target 1", "GRPs")
                            GrillaFormato.CambiarFormatoColumna(Grid, "Total GRP Target 1", Formato.Decimales)
                        Case "Total GRP Target 2"
                            Listas.CambiarTituloColumna(Grid, "Total GRP Target 2", "GRPs 2º")
                            GrillaFormato.CambiarFormatoColumna(Grid, "Total GRP Target 2", Formato.Decimales)
                        Case "Afinidad"
                            Listas.CambiarTituloColumna(Grid, "Afinidad", "AFF.T1/T2")
                            GrillaFormato.CambiarFormatoColumna(Grid, "Afinidad", Formato.Decimales)
                        Case "Total Spots"
                            Listas.CambiarTituloColumna(Grid, "Total Spots", "Spots")
                            GrillaFormato.CambiarFormatoColumna(Grid, "Total Spots", Formato.Numero)
                        Case "Total Bruto"
                            Listas.CambiarTituloColumna(Grid, "Total Bruto", "Inv. Bruta")
                            GrillaFormato.CambiarFormatoColumna(Grid, "Total Bruto", Formato.Moneda)
                        Case "Total Neto"
                            Listas.CambiarTituloColumna(Grid, "Total Neto", "Inv. Neta")
                            GrillaFormato.CambiarFormatoColumna(Grid, "Total Neto", Formato.Moneda)
                    End Select
                End If
            Next

            Dim i As Integer, j As Integer

            For Each C As UltraGridColumn In Grid.DisplayLayout.Bands(0).Columns
                If C.Key.IndexOf("/") > -1 Then
                    C.Header.Caption = Fechas(i)
                    i = i + 1
                End If
            Next

            For Each C As UltraGridColumn In Grid.DisplayLayout.Bands(0).Columns
                If C.Header.Caption.IndexOf(vbCrLf) > -1 Then
                    C.Header.Caption = Replace(C.Header.Caption, vbCrLf, " - ")
                End If
                C.Header.Appearance.FontData.Bold = DefaultableBoolean.True
                C.PerformAutoResize()
            Next
        Catch ex As Exception
            MsgBox("Exportar Todo - Aplicar Formato " & ex.Message)
            Correcto = False
        End Try

    End Sub
    Private Function CrearDtAExportar(ByRef Correcto As Boolean) As DataTable
        Dim dtExcel As New DataTable("Grid")
        Dim fila As DataRow
        Try
            For Each c As UltraGridColumn In iugEjercicio.DisplayLayout.Bands(0).Columns
                If Not c.Hidden Then
                    dtExcel.Columns.Add(c.Key, c.DataType)
                End If
            Next

            For Each r As UltraGridRow In iugEjercicio.Rows
                If r.Band.Index = 0 Then
                    fila = dtExcel.NewRow
                    For Each c As UltraGridCell In r.Cells
                        If Not c.Column.Hidden Then
                            fila(c.Column.Key) = c.Value
                        End If

                    Next
                    dtExcel.Rows.Add(fila)
                End If
            Next
        Catch ex As Exception
            MsgBox("Exportar Todo " & ex.Message)
            Correcto = False
        End Try

        Return dtExcel
    End Function

#End Region

    Private Sub ExpandirColapsar()
        If tblAcciones.Toolbars(0).Tools("ExpandirColapsar").SharedProps.Caption = "Expandir" Then
            tblAcciones.Toolbars(0).Tools("ExpandirColapsar").SharedProps.Caption = "Colapsar"
            tblAcciones.Toolbars(0).Tools("ExpandirColapsar").SharedProps.AppearancesSmall.Appearance.Image = ImageList.Images(0)
            iugEjercicio.Rows.ExpandAll(True)
        Else
            tblAcciones.Toolbars(0).Tools("ExpandirColapsar").SharedProps.Caption = "Expandir"
            tblAcciones.Toolbars(0).Tools("ExpandirColapsar").SharedProps.AppearancesSmall.Appearance.Image = ImageList.Images(1)
            iugEjercicio.Rows.CollapseAll(True)
        End If
    End Sub

    Public Sub MostarCuboDesglose()

        If fcubo Is Nothing Then

            fcubo = New Cubo

            fcubo.AbrirCubo()

        Else
            fcubo.Activate()
            fcubo.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub MostrarCubo()
        'Dim c As New Cubo_Listados
        'Dim dt As DataTable
        'Dim frmCub As New Cubo
        'Dim s As New Sistemas

        's.Id_campania = Activo.IDCampaña
        's.Id_sistema = Activo.IDSistema
        's.BuscarPorID()

        'c.Id_Campania = Activo.IDCampaña
        'c.Id_Sistema = Activo.IDSistema
        'c.Id_Ejercicio = Activo.IDEjercicio
        'c.Tipo_Rating = s.Tipo_rating
        'dt = c.Cubo_Ejercicio()

        'frmCub.Nombre = "CuboEjercicio"
        'frmCub.Titulo = "Análisis de inserciones"
        'frmCub.Modo = 0
        'frmCub.DataTableCub = dt
        'frmCub.ShowDialog()

        Dim frmCubo As New CuboFlex(Me.SpotBase.Copy(), Me.DetalleBase.Copy(), Me.Franjas.Copy())
        frmCubo.ShowDialog()

    End Sub
    Private Sub ImprimirGrilla()
        Dim Mensaje As String
        Dim upp As New UltraGridPrintDocument
        Dim ultraprintpreview As New UltraPrintPreviewDialog
        Dim tit As String

        '***
        For Each c As UltraGridColumn In Me.iugEjercicio.DisplayLayout.Bands(0).Columns
            c.PerformAutoResize()
        Next

        upp.Grid = Me.iugEjercicio
        ' Set the zomm level to 100 % in the print preview.
        upp.FitWidthToPages = 1

        ' Set up the header and the footer.
        upp.Header.Appearance.ImageHAlign = HAlign.Left
        upp.Header.Appearance.ImageVAlign = VAlign.Default

        'upp.Header.Height = 100
        upp.Header.Appearance.FontData.SizeInPoints = 9

        upp.Header.BorderStyle = UIElementBorderStyle.None

        ' Use <#> token in the string to designate page numbers.
        upp.Footer.TextRight = "Pagina <#>."
        upp.Footer.Height = 100
        upp.Footer.Appearance.FontData.SizeInPoints = 9
        upp.Footer.Appearance.TextHAlign = HAlign.Left
        upp.Footer.BorderStyle = UIElementBorderStyle.None
        upp.Footer.Appearance.FontData.Italic = DefaultableBoolean.True

        'e.PrintDocument.PrinterSettings.PaperSizes()
        ' Set the ClippingOverride to Yes.
        upp.PageBody.BorderStyle = UIElementBorderStyle.None
        upp.Page.BorderStyle = UIElementBorderStyle.None


        ' Set the document name through the PrintDocument which returns a PrintDocument object.
        upp.DefaultPageSettings.Landscape = True
        upp.DefaultPageSettings.Margins.Bottom = 10
        upp.DefaultPageSettings.Margins.Left = 10
        upp.DefaultPageSettings.Margins.Right = 10
        upp.DefaultPageSettings.Margins.Top = 10

        upp.DocumentName = "PLANIFICACION"

        With ultraprintpreview
            ' Set its Document property to the UltraGridPrintDocument we created above.
            ' Note: 'Document' type is System.Drawing.Printing.PrintDocument
            ' which UltraGridPrintDocument derives from. Therefore, any
            ' other instance of a PrintDocument will work as well.
            .Document = upp

            ' automatically generate the preview when the dialog is 1st displayed
            ' or when the document changes
            .AutoGeneratePreview = True

            ' show a status dialog while the preview is being generated
            .DisplayPrintStatus = True

            ' show a status dialog during a print operation that was started
            ' by the user selecting the 'Print' item on the 'File' menu
            .DisplayPreviewStatus = True

            ' set the maximum number of preview pages that will be generated.
            ' If Me is set to zero then no maximum is enforced.
            .MaximumPreviewPages = 50

            ' set the initial mouse action that will be specified when
            ' the dialog is first displayed. This can be changed by the
            ' user through a set of tools on the dialog's 'Standard' toolbar
            .PreviewMouseAction = PreviewMouseAction.DynamicZoom

            ' Note: the 'PreviewSettings' apply to the prview area while
            ' the 'ThumbnailSettings' apply to the thumbnail area.
            .PreviewSettings.ScrollMode = UltraWinScrollBar.ScrollMode.Immediate
            .PreviewSettings.ScrollTipStyle = UltraWinScrollBar.ScrollTipStyle.Show
            .ThumbnailSettings.PageNumberDisplayStyle = PageNumberDisplayStyle.LeftOfRow
            .ThumbnailSettings.BorderStyle = UIElementBorderStyle.InsetSoft

            ' make the status bar at the bottom of the dialog visible
            .StatusBarVisible = True

            ' set the overall style of the dialog
            .Style = UltraWinToolbars.ToolbarStyle.VisualStudio2005


            ' make the thumbnail area on the left side of the dialog visible.
            ' Note: Me can be toggled on or off by the user from the 'View'
            ' menu.
            .ThumbnailAreaVisible = True

            ' set the appearance of the current page in the thumbnail area
            .ThumbnailCurrentPreviewPageAppearance.BackColor = Color.Yellow

            ' set the appearance of the current page number in the thumbnail area
            .ThumbnailCurrentPreviewPageNumberAppearance.ForeColor = Color.Red


            ' set the appearance of the view box in the thumbnail area
            ' Note: the view box is the displayed in the thumbnail area to identify
            ' what is currently displayed in the preview area.
            .ThumbnailViewBoxAppearance.BackColor = Color.Aqua
            .ThumbnailViewBoxAppearance.BackColorAlpha = Alpha.UseAlphaLevel
            .ThumbnailViewBoxAppearance.AlphaLevel = 80

            ' set the how the view box is displayed in the thumbnail area
            .ThumbnailViewBoxDisplayStyle = ViewBoxDisplayStyle.AllVisiblePreviewPages

            ' set the how the view box can be dragged within the thumbnail area
            .ThumbnailViewBoxDragMode = ViewBoxDragMode.RestrictWithinPage

            ' use anti-aliasing
            .UseAntiAlias = True

            ' Show the dialog modally
            .ShowDialog()

            ' dispose the dialog
            .Dispose()

        End With
    End Sub

    Private Sub CargarSoportes(Optional ByVal EsActualizacion As Boolean = False)
        Dim Fp As New frmProgresoCargaGrilla

        AuxSpotBase = SpotBase.Copy
        AuxDetalleBase = DetalleBase.Copy
        auxColumnasHijos = ColumnasHijos.Clone

        Dim Canales, ListaTemas As ArrayList
        Dim Texto As String
        AvisosEspeciales.Clear()
        Dim T As New Tarifas_tv
        If Not EsActualizacion Then
            Dim F As Object
            Select Case Activo.IDMedio
                Case 6
                    F = New frmFiltrarSoporteTema
                    F.PrimeraCarga = False
                    ListaTemas = F.ListaTemas
                Case Else
                    F = New frmFiltrarSoporte
            End Select

            F.Id_medio = Activo.IDMedio
            F.Id_tipo_soporte = Activo.IDTipoSoporte
            F.id_plaza = Activo.IDPlaza

            Application.DoEvents()
            F.ShowDialog()

            If F.Cancelado Then
                Exit Sub
            End If

            Canales = F.ListaSoportes

            'AG 05/06/2014 =======================
            If Activo.IDTipoEjercicio = 1 Then
                Canales = QuitarSoporteTarifasAutis(Canales)
            End If
            '=====================================

            Texto = "Agregando Soportes"
        Else
            Canales = SoportesActualizados
            Texto = "Actualizando Tarifas"
        End If

        If Not Canales Is Nothing AndAlso Canales.Count > 0 Then
            Application.DoEvents()
            Fp.Texto = Texto
            Fp.Max1 = 5
            Application.DoEvents()
            Fp.Show()
            Application.DoEvents()

            Dim Tarifa As DataTable = CargarTarifas(Canales, Activo.IDMedio, Activo.IDSistema, TipoDeAudiencia, EsActualizacion)

            SpotBase = AuxSpotBase.Copy
            DetalleBase = AuxDetalleBase.Copy
            ColumnasHijos = auxColumnasHijos.Clone

            GrillAdmin.AgregarFila(Me.UltraDataSource1, SpotBase, Tarifa, Me.UltraDataSource1.Rows.Count, T)
            AvisosEspeciales = Activo.Especiales

            If AvisosEspeciales.Count > 0 Then
                DtAfectados = Me.ObtenerAfectadosEspeciales(SpotBase, AvisosEspeciales, Tarifa)
            End If

            GrillaFormato.MarcarDiasPrograma(iugEjercicio, Me.ColorDia, ColorVigenciaNula)
            frmProgresoCargaGrilla.Instancia.Close()

            '*** cuando se agregan soportes, hay que actualiza el desglose de soportes
            'agrega el nuevo soporte, a la lista de soportes auxiliares
            If TypeOf AuxSoportes Is ArrayList Then
                For Each IL As ItemLista In Canales
                    Dim Soportes As ArrayList
                    Dim ExisteSoporte As Boolean

                    Soportes = DirectCast(AuxSoportes, ArrayList)

                    For Each AuxIL As ItemLista In Soportes
                        If AuxIL.ID = IL.ID Then
                            ExisteSoporte = True
                            Exit For
                        End If
                    Next

                    If Not ExisteSoporte Then
                        Soportes.Add(IL)
                    End If
                Next
            Else
                For Each IL As ItemLista In Canales
                    Dim Soportes As DataTable

                    Soportes = DirectCast(AuxSoportes, DataTable)

                    If Soportes.Select("id_soporte=" & IL.ID).Length = 0 Then
                        Dim Dr As DataRow = Soportes.NewRow

                        Dr("id_soporte") = IL.ID
                        Dr("descripcion") = IL.Descripcion

                        Soportes.Rows.Add(Dr)
                    End If
                Next
            End If

            GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas, , True)

            'AG 28/04/2016 ====================================================================
            If cbCalculoAutomatico.Checked = True Then
                Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)
            End If
            '=================================================================================

            ColorSinAudiencia()
            'Me.iugSemana.DataSource = Me.SpotBase

            'Carga de Temas para cada programa
            If Activo.IDMedio = MedioRadio Then
                CargarTemasHijos()
                GrillaFormato.MarcarDiasPrograma(iugEjercicio, ColorDia, ColorVigenciaNula)
            End If
        End If
        If Not ListaTemas Is Nothing AndAlso ListaTemas.Count > 0 Then
            Dim Te As New Temas
            Dim dtTemasAgregar As DataTable
            Te.Id_campania = Activo.IDCampaña
            dtTemasAgregar = Te.ObtenerTemasPorCampaña()

            Dim Filtro As StringBuilder
            Dim Tema As ItemLista

            For IndexTema As Integer = 0 To ListaTemas.Count - 1
                Tema = ListaTemas(IndexTema)
                Filtro = New StringBuilder
                Filtro.Append("Id_Tema = '")
                Filtro.Append(Tema.ID)
                Filtro.Append("'")

                If dtTemas.Select(Filtro.ToString).Length <= 0 Then
                    For Each drTemas As DataRow In dtTemasAgregar.Select(Filtro.ToString)
                        dtTemas.ImportRow(drTemas)
                    Next
                End If
            Next
            CargarTemasHijos()
            GrillaFormato.MarcarDiasPrograma(iugEjercicio, ColorDia, ColorVigenciaNula)
        End If

        'AG Velocidad Probar ================================================================
        If cbCalculoAutomatico.Checked = False Then

            Exit Sub
        End If

        GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas, , True)
        Me.iugSoporte.DataSource = Nothing
        Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)

        ''==================== Desgloses SOPORTES ==========================
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "% Grps", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Tarifa Neta", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "% Tarifa Neta", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "CPR", Formato.Decimales)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Bruto", Formato.Moneda)
        GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "bruto", HAlign.Right)
        GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "CantidadTemas", HAlign.Right)
        GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "PorcentajeDuracion", HAlign.Right)
        GrillaFormato.AcivarOperacion(Me.iugSoporte, "Bruto", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
        GrillaFormato.AcivarOperacion(Me.iugSoporte, "CantidadTemas", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        GrillaFormato.AcivarOperacion(Me.iugSoporte, "PorcentajeDuracion", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
        Listas.CambiarTituloColumna(Me.iugSoporte, "CantidadTemas", "Temas")
        Listas.CambiarTituloColumna(Me.iugSoporte, "PorcentajeDuracion", "% Dur.")
        GrillaFormato.HabilitarEdicionColumna(Me.iugSoporte, Activation.NoEdit, False)
        Listas.OcultarColumnas(Me.iugSoporte, "id_soporte", "SumaDuracion") ', "CantidadTemas", "PorcentajeDuracion")
        GrillaFormato.AutoAjustarColumnas(Me.iugSoporte)
        Me.AgregarSumatoriasDesgloses(Me.iugSoporte)
        '===========================================================================

    End Sub

    Private Sub CargarTemasHijos()
        GrillAdmin.AgregarHijo(Me.UltraDataSource1, Me.DetalleBase, ColumnasHijos, dtTemas)
        GrillaFormato.ReocultarColumnasHijos(iugEjercicio)
        Listas.OcultarHeader(iugEjercicio)
        For Each b As UltraGridBand In iugEjercicio.DisplayLayout.Bands
            If b.Index > 0 Then
                GrillaFormato.FijarColumna(b.Columns("Tema"), True)
                GrillaFormato.FijarColumna(iugEjercicio.DisplayLayout.Bands(b.Index).Columns(b.Columns("tema").Index + 4), True)
                GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, b.Index, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")
            End If
        Next
        GrillaFormato.MoverColumnaTema(iugEjercicio, 3)
        For Index As Integer = 1 To iugEjercicio.DisplayLayout.Bands.Count - 1
            TitulosFechas(Index)
        Next
    End Sub

    Private Sub CargarConvenioGlobal()
        Dim DtSoportes As DataTable

        If TypeOf AuxSoportes Is ArrayList Then
            DtSoportes = New DataTable

            With DtSoportes.Columns
                .Add("id_soporte", GetType(Integer))
                .Add("descripcion", GetType(String))
            End With

            Dim I As ItemLista
            Dim Dr As DataRow

            'pasa los datos del Array al Data Table
            For Each I In AuxSoportes
                Dr = DtSoportes.NewRow

                Dr("id_soporte") = I.ID
                Dr("descripcion") = I.Descripcion

                DtSoportes.Rows.Add(Dr)
            Next
        Else
            DtSoportes = AuxSoportes
        End If

        Dim F As New frmConvenios

        F.UltraData = Me.UltraDataSource1
        F.F_desde = Activo.FechaInicioSistema
        F.F_Hasta = Activo.FechaFinSistema
        F.id_Spot = CInt(Me.iugEjercicio.ActiveRow.Cells.Item("id_spot").Value) 'Cells("id_spot").Value)
        F.Spots = SpotBase
        F.Soportes = DtSoportes
        F.EsGlobal = True
        F.Cargar()
        ''ESTO ES PARA EVITAR QUE MUESTRE EL FORMULARIO VACIO CUANDO NO TRAE NINGUN CONVENIO
        ''DANIEL CAIME
        If F.iugConvenios.Rows.Count > 0 Then
            F.ShowDialog()
        Else
            MessageBox.Show("No se encontraron convenios", "Convenios")
            'F.Dispose()'NO
            Exit Sub
        End If

        'AG 09/05/2011 = Control Convenio Igual -1 marcar color fonde celda ++++++++++

        For Each r As UltraGridRow In iugEjercicio.Rows

            If F.iugConvenios.ActiveRow.Cells("Tipo_Convenio").Value = "T" Then
                If IsDBNull(r.Cells("id_convenio").Value) Then
                    r.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                    r.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf r.Cells("id_convenio").Value = -1 Then
                    r.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                    r.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf r.Cells("id_convenio").Value > 0 Then
                    r.Cells("dcto1").Appearance.BackColor = Color.White
                    r.Cells("dcto2").Appearance.BackColor = Color.White
                    r.Cells("dcto3").Appearance.BackColor = Color.White
                    r.Cells("dcto4").Appearance.BackColor = Color.White
                    r.Cells("dcto5").Appearance.BackColor = Color.White
                    r.Cells("dcto1").Appearance.ForeColor = Color.Black
                    r.Cells("dcto2").Appearance.ForeColor = Color.Black
                    r.Cells("dcto3").Appearance.ForeColor = Color.Black
                    r.Cells("dcto4").Appearance.ForeColor = Color.Black
                    r.Cells("dcto5").Appearance.ForeColor = Color.Black
                End If

            ElseIf F.iugConvenios.ActiveRow.Cells("Tipo_Convenio").Value = "D" Then
                If IsDBNull(r.Cells("id_convenio").Value) Then
                    r.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                    r.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf r.Cells("id_convenio").Value = -1 Then
                    r.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                    r.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    r.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf r.Cells("id_convenio").Value > 0 Then
                    r.Cells("dcto1").Appearance.BackColor = Color.White
                    r.Cells("dcto2").Appearance.BackColor = Color.White
                    r.Cells("dcto3").Appearance.BackColor = Color.White
                    r.Cells("dcto4").Appearance.BackColor = Color.White
                    r.Cells("dcto5").Appearance.BackColor = Color.White
                    r.Cells("dcto1").Appearance.ForeColor = Color.Black
                    r.Cells("dcto2").Appearance.ForeColor = Color.Black
                    r.Cells("dcto3").Appearance.ForeColor = Color.Black
                    r.Cells("dcto4").Appearance.ForeColor = Color.Black
                    r.Cells("dcto5").Appearance.ForeColor = Color.Black
                End If
            End If
        Next

        'AG Velocidad ================================================================
        If cbCalculoAutomatico.Checked = False Then
            'AG 28/04/2016 
            GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
            Exit Sub
        End If
        '===========================================================================

        'AG 02/08/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)
        Me.iugTema.DataSource = GrillaResumen.GrillaPorTema(Me.UltraDataSource1, dtTemas)
        Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas, Activo.FechaFinSistema)
        Me.iugFranja.DataSource = GrillaResumen.GrillaPorFranja(Me.UltraDataSource1, Franjas, dtTemas)
        'AG 18/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
        'GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    End Sub
    Private Sub CargarConvenioPuntual()
        Dim DtSoportes As New DataTable
        Dim dr As DataRow

        DtSoportes.Columns.Add("id_soporte", GetType(Int64))

        dr = DtSoportes.NewRow()

        If iugEjercicio.ActiveRow Is Nothing And iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If

        dr("id_soporte") = iugEjercicio.ActiveRow.Cells("id_soporte").Value

        DtSoportes.Rows.Add(dr)

        Dim F As New frmConvenios

        F.UltraData = Me.UltraDataSource1
        F.F_desde = Activo.FechaInicioSistema
        F.F_Hasta = Activo.FechaFinSistema
        F.id_Spot = Me.iugEjercicio.ActiveRow.Cells("id_spot").Value
        F.Spots = SpotBase
        F.Soportes = DtSoportes
        F.EsGlobal = False
        F.Cargar()
        ''ESTO ES PARA EVITAR QUE MUESTRE EL FORMULARIO VACIO CUANDO NO TRAE NINGUN CONVENIO
        ''DANIEL CAIME
        If F.iugConvenios.Rows.Count > 0 Then
            F.ShowDialog()
        Else
            MessageBox.Show("No se encontraron convenios", "Convenios")
            Exit Sub
        End If

        'RM 1/7/2011-------------------------------------------------------------------------
        If Not IsDBNull(Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value) Then
            '----------------------------------------------------------------------------------------------
            If F.iugConvenios.ActiveRow.Cells("Tipo_Convenio").Value = "T" Then
                'Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.White
                'Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.White
                'Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.White
                'Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.White
                'Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.White

                If Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value = 0 Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value = -1 Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value > 0 Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.ForeColor = Color.Black
                End If
            ElseIf F.iugConvenios.ActiveRow.Cells("Tipo_Convenio").Value = "D" Then
                'AG 09/05/2011 = Control Convenio Igual -1 marcar color fonde celda ++++++++++
                If Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value = 0 Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value = -1 Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                ElseIf Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value > 0 Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.White
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.ForeColor = Color.Black
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.ForeColor = Color.Black
                End If
            End If
        Else
            MessageBox.Show("No se encontraron convenios que apliquen en los ejercios actuales", "Convenios")
            Exit Sub
        End If


        'AG Velocidad ================================================================
        If cbCalculoAutomatico.Checked = False Then
            'AG 28/04/2016 
            GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
            Exit Sub
        End If
        '===========================================================================

        'AG 02/08/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)
        Me.iugTema.DataSource = GrillaResumen.GrillaPorTema(Me.UltraDataSource1, dtTemas)
        Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas, Activo.FechaFinSistema)
        Me.iugFranja.DataSource = GrillaResumen.GrillaPorFranja(Me.UltraDataSource1, Franjas, dtTemas)
        'AG 18/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR)
        GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    End Sub

    Private Function ObtenerUltraDataRow(ByVal IDSpot As Integer) As UltraDataRow
        Dim Ur As UltraDataRow

        For Each Ur In Me.UltraDataSource1.Rows
            If Ur.Item("id_spot") = IDSpot Then
                Return Ur
            End If
        Next
    End Function

    Private Sub SpotBase_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles SpotBase.ColumnChanging
        'actualiza los id spots en el ultra source
        Dim Ur As UltraDataRow

        If e.Column.ColumnName.ToLower = "id_spot" Then

            For Each Ur In Me.UltraDataSource1.Rows

                If Not e.Row("id_spot") Is DBNull.Value AndAlso Ur.Item("id_spot") = e.Row("id_spot") Then
                    Ur.Item("id_spot") = e.ProposedValue
                End If

            Next

        End If
    End Sub

    Private Sub iugEjercicio_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles iugEjercicio.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub


    Private Sub iugEjercicio_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugEjercicio.AfterCellUpdate
        If Valores.CastDBNullObject(e.Cell.OriginalValue) = "-1" AndAlso GrillAdmin.EsColumnaRating(e.Cell.Column) Then
            'Activo.Control = False
            Exit Sub
        End If

        Dim valorConvenio As Integer


        ''AG 08/05/2012 Control si modifico el valor bruto de la tarifa aplicada tipo Neto 
        ''AN 17/02/2016 Agrego que si modifica la tarifa neta haga exactamente lo mismo.
        If e.Cell.Column.Key.ToLower.IndexOf("bruto") > -1 _
            Or e.Cell.Column.Key.ToLower.IndexOf("neto") > -1 Then
            Dim netoConvenio As Decimal
            Dim dtConvenios As DataTable
            Dim Dr As DataRow = Me.SpotBase.Select("id_spot=" & e.Cell.Row.Cells("id_spot").Value)(0)
            Dim OConvenio As New Convenios
            Dim TipoConvenio As String
            If CInt(Dr("id_convenio")) > 0 Then
                'Busco en la base que tipo de convenio es ( D o T ) mediante el id_convenio
                OConvenio.Id_cliente = Activo.IDCliente
                OConvenio.Id_soporte = CInt(Dr("id_soporte"))
                OConvenio.Id_medio = Activo.IDMedio
                OConvenio.Id_convenio = CInt(Dr("id_convenio"))
                TipoConvenio = OConvenio.ObtenerTipoConvenioSpot()
                dtConvenios = OConvenio.ObtenerConvenioxId()
                If dtConvenios.Rows.Count > 0 Then
                    netoConvenio = dtConvenios.Rows(0)("IMP_NETO_VENTA")
                End If
                'Si el convenio es de TARIFA se pone codigo convenio = -1 y se colorea las celdas de descuentos
                'AN 17/02/2016 Si el convenio es de DESCUENTO y tiene valor de tarifa funciona como el otro caso.
                If TipoConvenio = "T" Or (TipoConvenio = "D" And netoConvenio > 0) Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                    Dr("id_convenio") = -1
                    Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value = -1
                End If

            End If
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        If e.Cell.Column.Key.ToLower.IndexOf("dcto") > -1 Then
            'AG 2/11/2010 -----------------------------------
            'If e.Cell.Text = "" Then
            '    e.Cell.Value = 0
            'End If
            If e.Cell.Value > 100 Then
                e.Cell.Value = 0
            End If
            '-----------------------------------------------------
            'AG 09/05/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++

            If e.Cell.Column.Key.ToLower = "dcto1" Or e.Cell.Column.Key.ToLower = "dcto2" Or e.Cell.Column.Key.ToLower = "dcto3" Or e.Cell.Column.Key.ToLower = "dcto4" Or e.Cell.Column.Key.ToLower = "dcto5" Then
                Dim Dr As DataRow = Me.SpotBase.Select("id_spot=" & e.Cell.Row.Cells("id_spot").Value)(0)
                If Me.iugEjercicio.ActiveRow.Cells("dcto1").Value = 0 And Me.iugEjercicio.ActiveRow.Cells("dcto2").Value = 0 And Me.iugEjercicio.ActiveRow.Cells("dcto3").Value = 0 And Me.iugEjercicio.ActiveRow.Cells("dcto4").Value = 0 And Me.iugEjercicio.ActiveRow.Cells("dcto5").Value = 0 Then
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                    valorConvenio = 0
                    Dr("id_convenio") = 0
                    Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value = 0
                Else
                    Me.iugEjercicio.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                    Me.iugEjercicio.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                    valorConvenio = -1
                    Dr("id_convenio") = -1
                    Me.iugEjercicio.ActiveRow.Cells("id_convenio").Value = -1
                End If
            End If



            'AG Original -----------------------------------------------
            'If e.Cell.Value < 0 Or e.Cell.Value > 100 Then
            'e.Cell.Value = 0
            'End If
            '--------------------------------------------------------------

        Else
            If e.Cell.Column.Key.ToLower.IndexOf("bruto") > -1 _
                Or e.Cell.Column.Key.ToLower.IndexOf("rat_prog_target") > -1 _
                Or e.Cell.Column.Key.ToLower.IndexOf("rat_tanda_target") > -1 Then

                If e.Cell.Text = "" Then
                    e.Cell.Value = 0
                End If
            End If
        End If

        'actualiza el Data Table SpotBase, cuando se modifica el programa
        If e.Cell.Column.Key.ToLower = "programa" Then
            Try
                Dim Dr As DataRow = Me.SpotBase.Select("id_spot=" & e.Cell.Row.Cells("id_spot").Value)(0)

                Dr("programa") = e.Cell.Row.Cells("programa").Value
            Catch ex As IndexOutOfRangeException
                Mensajes.Mensaje("frmEjercicio.ActualizarTotales: Los Registros del UltraSource y el DataTable No Coinciden")
            End Try
        End If

        GrillaFormato.CambiarColorCelda(e.Cell, ColorCambioManual)
        If e.Cell.Band.Key <> "BandaSpot" AndAlso Not e.Cell.Row.ParentRow Is Nothing Then
            Dim Tema As String
            Dim CompraTema, ColumnName As String
            Dim Cantidad As Integer = Convert.ToInt32(IIf(e.Cell.Value = String.Empty, "0", e.Cell.Value))
            Tema = CType(e.Cell.Row.ListObject, UltraDataRow).Tag
            ColumnName = e.Cell.Column.Key
            CompraTema = IIf(Me.UltraDataSource1.Rows(e.Cell.Row.ParentRow.ListIndex).Item(ColumnName) Is DBNull.Value, String.Empty, Me.UltraDataSource1.Rows(e.Cell.Row.ParentRow.ListIndex).Item(ColumnName))
            Dim CompraAnterior As String = CompraTema
            If Cantidad > 0 Then
                For Index As Integer = 0 To Cantidad - 1
                    CompraTema = CompraTema & Tema
                Next
            Else
                CompraTema = CompraTema.Replace(Tema, "")
            End If
            If CompraTema <> String.Empty Then
                OrdenarTemasComprados(CompraTema)
            End If

            Me.UltraDataSource1.Rows(e.Cell.Row.ParentRow.ListIndex).SetCellValue(ColumnName, CompraTema)
            GrillAdmin.ActualizarFilasTemas(Me.UltraDataSource1.Rows(e.Cell.Row.ParentRow.ListIndex), DetalleBase, dtTemas, e.Cell.Band.Key, Me.UltraDataSource1.Rows(e.Cell.Row.ParentRow.ListIndex).Item("id_spot"))
            Dim CompraActual As String = CompraTema
            Me.CalcularGrillasResumen(CompraAnterior.ToUpper, CompraActual.ToUpper, Me.UltraDataSource1.Rows(e.Cell.Row.ParentRow.ListIndex), ColumnName)
            Me.UltimoText = CompraTema
        Else
            GrillAdmin.ModificarColumna(Me.SpotBase, e.Cell, valorConvenio)
        End If

        'CargarCubo(SpotBase.Copy(), DetalleBase.Copy(), Franjas.Copy(), True)
        'TEST
        'SpotBase.AcceptChanges()
    End Sub

    Private Sub OrdenarTemasComprados(ByRef pCompraTema As String)
        Dim Temas As New SortedList
        Dim Index As Integer
        Dim TemasOrdenados As New StringBuilder
        Dim LetraMinuscula As Char
        Dim Letra As String

        For Index = 0 To pCompraTema.Length - 1
            LetraMinuscula = pCompraTema.Substring(Index, 1)
            Letra = pCompraTema.Substring(Index, 1)
            If Not LetraMinuscula.IsLower(LetraMinuscula) Then
                If Not Temas.ContainsKey(Letra) Then
                    Temas.Add(Letra, Letra)
                Else
                    Temas(Letra) = Temas(Letra) & Letra
                End If
            Else
                TemasOrdenados.Append(Letra)
            End If
        Next
        For Each Tema As DataRow In dtTemas.Rows
            If Temas.ContainsKey(Tema("ID_Tema")) Then
                TemasOrdenados.Append(Temas(Tema("ID_Tema")))
            End If
        Next
        pCompraTema = TemasOrdenados.ToString
    End Sub

    Private Sub ActualizarTotales(ByVal E As CellDataUpdatingEventArgs)
        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico

        'AG 28/04/2016
        'If cbCalculoAutomatico.Checked Then
        Dim Col As String = E.Column.Key.ToLower
        Try
            'solo actualiza si se cambiaron las columnas Bruto y los descuentos y el rating t1
            If Col <> "bruto" And Col <> "dcto1" _
            And Col <> "dcto2" And Col <> "dcto3" _
            And Col <> "dcto4" And Col <> "dcto5" _
            And Col <> "neto" And Col <> "rat_prog_target_1" And Col <> "rat_tanda_target_1" _
            And Col <> "rat_prog_target_2" And Col <> "rat_tanda_target_2" Then
                If GrillAdmin.EsColumnaCalendario(Col) Then
                    Dim Dr As DataRow = Me.SpotBase.Select("id_spot=" & E.Row("id_spot"))(0)
                    Dr("f_modi") = Now.Date
                    Dr("u_modi") = Activo.Login
                End If
                Exit Sub
            End If

            'resta los saldos de los cuadros, con el neto viejo
            Me.ActualizarCuadros(E, False)

            'actualiza el neto en la grilla, calculandolo a partir del bruto y los descuentos
            GrillAdmin.ActualizarNeto(E.Row, E.Column.Key, E.NewValue)

            'guarda todos los cambios en el Spot Base (es el Data Table que se usa para guardar)
            GrillAdmin.ActualizarDataTableColumnasManuales(Me.SpotBase, E.Row)

            'actualiza los saldos de los cuadros con el nuevo neto
            Me.ActualizarCuadros(E, True)

            'AG 18/02/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
            'GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR)
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            GrillaResumen.ActualizarCPR(E.Row)
        Catch ez As Exception
            MsgBox("Actualizar Totales" & ez.Message)
        End Try
        LetraValida = False
        'End If
    End Sub

    Private Sub ActualizarCuadros(ByVal E As CellDataUpdatingEventArgs, ByVal Sumar As Boolean)
        'se usa cunado se cambia a mano el bruto, los descuentos o el rating

        For Each Uc As UltraDataColumn In E.Row.Band.Columns
            If GrillAdmin.EsColumnaCalendario(Uc) Then

                If Not E.Row.Item(Uc.Key) Is DBNull.Value AndAlso Not E.Row.Item(Uc.Key) = "" Then
                    If Sumar Then
                        Me.CalcularGrillasResumen("", UCase((E.Row.Item(Uc.Key))), E.Row, Uc.Key)
                    Else
                        Me.CalcularGrillasResumen(UCase(E.Row.Item(Uc.Key)), "", E.Row, Uc.Key)
                    End If

                End If

            End If
        Next
    End Sub

    Private Sub ActualizarSpotsDetalleLog(ByVal Fila As UltraGridRow, ByVal Col As String)
        '*** AGREGA AL LOG LOS SPOTS MODIFICADOS SPOTS_DETALLE_LOG
        Col = Col.ToLower

        'solo actualiza si se on las columnas Bruto y los descuentos o nombre programa
        If Col <> "bruto" And Col <> "dcto1" _
        And Col <> "dcto2" And Col <> "dcto3" _
        And Col <> "dcto4" And Col <> "dcto5" _
        And Col <> "neto" And Col <> "programa" Then
            Exit Sub
        End If

        'guarda el LOG solo para el Ejercicio FINAL
        If Activo.IDEstadoEjercicio = 2 Then
            Dim S As New Spots_detalle_log
            Dim Hijos() As DataRow
            Dim H As DataRow

            Hijos = Me.DetalleBase.Select("id_spot=" & Fila.Cells("id_spot").Value)

            For Each H In Hijos
                S.Id_campania = Activo.IDCampaña
                S.Id_sistema = Activo.IDSistema
                S.Id_ejercicio = Activo.IDEjercicio

                'Me.BuscarDescripciones(S)

                S.Id_spot = H("id_spot")
                S.Id_spot_detalle = H("id_spot_detalle")

                S.Programa = Fila.Cells("programa").Value
                S.H_icio = Fila.Cells("h_inicio").Value.ToString.Substring(0, 2)
                S.H_f = Fila.Cells("h_fin").Value.ToString.Substring(0, 2)

                S.Neto = Fila.Cells("neto").Value
                S.Id_tema = H("id_tema")

                S.Dcto1 = Fila.Cells("dcto1").Value
                S.Dcto2 = Fila.Cells("dcto2").Value
                S.Dcto3 = Fila.Cells("dcto3").Value
                S.Dcto4 = Fila.Cells("dcto4").Value
                S.Dcto5 = Fila.Cells("dcto5").Value

                S.Accion = "M"
                S.U_accion = Activo.Login
                S.F_accion = Valores.CastDBNullDate(H("f_modi"))

                S.Agregar()
            Next
        End If
    End Sub

    Private Sub iugEjercicio_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugEjercicio.CellChange
        HayCambios = True
        ' Activo.Control = False
        If Not GrillAdmin.EsColumnaCalendario(e.Cell.Column) Then
            Exit Sub
        End If

        'AG Hoja Numero ========================================================
        If Activo.IDMedio = MedioTv Then
            For Index As Integer = 1 To iugEjercicio.DisplayLayout.Bands.Count - 1
                TitulosFechas(Index)
            Next
        End If
        '==============================================================================

        'si es una letra valida y no es un dia del programa, 
        'entonces pregunta si realmente quiere comprar en esa celda
        If LetraValida AndAlso Not GrillAdmin.EsDiaPrograma(e.Cell) Then
            If Mensajes.Mensaje("El Día Elegido No es el Día de Emisión del Programa" & vbCrLf & "¿Desea Realizar la Compra?", TipoMensaje.SiNo) = DialogResult.No Then
                Me.iugEjercicio.PerformAction(UndoCell, False, False)
                Exit Sub
            Else
                If e.Cell.IsInEditMode Then
                    e.Cell.EditorResolved.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub iugEjercicio_Key(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles iugEjercicio.KeyDown
        Dim Indice As Integer
        Dim i As Integer
        Dim Letra As String
        Dim ValorAscii As Integer
        Dim EnEdicion As Boolean

        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            Borrar = True
        Else
            Borrar = False
        End If

        If Not Borrar Then
            If Not iugEjercicio.ActiveRow Is Nothing Then
                If e.KeyCode <> 109 Then
                    If Not iugEjercicio.ActiveCell Is Nothing Then
                        If iugEjercicio.ActiveCell.Band.Index > 0 Then
                            If e.KeyCode = Keys.Enter Then
                                e.Handled = True
                                EnEdicion = iugEjercicio.ActiveCell.IsInEditMode
                                If EnEdicion Then
                                    ComprobarCompras()
                                    If GrillAdmin.EsColumnaCalendario(iugEjercicio.ActiveCell) Then
                                        iugEjercicio.UpdateData()
                                    End If
                                    iugEjercicio.PerformAction(ExitEditMode, False, False)
                                Else
                                    iugEjercicio.PerformAction(EnterEditMode, False, False)
                                End If
                            End If
                            If Not ((e.KeyData >= Keys.D0 AndAlso e.KeyData <= Keys.D9) OrElse (e.KeyData >= Keys.NumPad0 AndAlso e.KeyData <= Keys.NumPad9)) Then
                                Exit Sub
                            ElseIf iugEjercicio.ActiveCell.Text.ToString.Length > 2 Then
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End If

        ' Si tengo seleccionada la fila y presiona la tecla delete, borro igual que con el menu
        'If Not iugEjercicio.ActiveRow Is Nothing Then
        If Not iugEjercicio.ActiveRow Is Nothing AndAlso Me.iugEjercicio.ActiveRow.Selected Then
            If e.KeyCode = Keys.Delete Then
                If Not iugEjercicio.ActiveCell Is Nothing Then
                    If Not iugEjercicio.ActiveCell.IsInEditMode Then
                        Me.mnuBorrar_Click(Me.iugEjercicio, New EventArgs)
                    End If
                Else
                    Me.mnuBorrar_Click(Me.iugEjercicio, New EventArgs)
                End If
            End If
        End If

        ' si no tengo seleccionada ni una celda ni una fila, salgo
        If iugEjercicio.ActiveCell Is Nothing Or iugEjercicio.ActiveRow Is Nothing Then
            Exit Sub
        End If

        EnEdicion = iugEjercicio.ActiveCell.IsInEditMode

        If Not Me.iugEjercicio.ActiveCell Is Nothing AndAlso Not EnEdicion Then
            Me.UltimoText = iugEjercicio.ActiveCell.Text
        End If

        Select Case e.KeyValue

            Case Keys.Delete

                'borra el rango de celdas seleccionadas
                'If iugEjercicio.ActiveCell.Band.Index = 0 Then
                'borra el rango de celdas seleccionadas
                If Me.iugEjercicio.Selected.Cells.Count > 1 Then
                    Me.BorrarCeldas(Me.iugEjercicio.Selected.Cells)
                    Exit Sub
                End If

                If GrillAdmin.ObtenerColumnaModificable(Me.iugEjercicio.ActiveCell.Column.Key) > 0 _
                   Or GrillAdmin.EsColumnaCalendario(Me.iugEjercicio.ActiveCell.Column) Then

                    If iugEjercicio.ActiveCell.Band.Key <> "BandaSpot" Then
                        Dim Tema As Char
                        Try
                            Tema = CType(iugEjercicio.ActiveCell.Row.ListObject, UltraDataRow).Tag.ToLower()
                            If GrillAdmin.ObtenerSpotsComprados(iugEjercicio.ActiveCell.Row.ParentRow.Cells(iugEjercicio.ActiveCell.Column.Key), Tema).Length > 0 Then
                                Exit Sub
                            End If
                        Catch ex As Exception
                        End Try
                    Else
                        If GrillAdmin.ObtenerSpotsComprados(iugEjercicio.ActiveCell).Length > 0 Then
                            Exit Sub
                        End If
                    End If

                    If Not EnEdicion Then
                        If iugEjercicio.ActiveCell.Column.DataType Is GetType(Single) Or _
                        iugEjercicio.ActiveCell.Column.DataType Is GetType(Double) Or _
                        iugEjercicio.ActiveCell.Column.DataType Is GetType(Integer) Then

                            iugEjercicio.ActiveCell.Value = 0
                        Else
                            iugEjercicio.ActiveCell.Value = ""
                        End If
                    Else
                        If iugEjercicio.ActiveCell.Band.Index > 0 Then
                            iugEjercicio.ActiveCell.Value = ""
                        End If

                    End If
                End If

            Case Keys.Up
                ComprobarCompras()
                iugEjercicio.PerformAction(AboveCell, False, False)
                e.Handled = True

            Case Keys.Enter, Keys.F2
                e.Handled = True

                If EnEdicion Then

                    ComprobarCompras()
                    If GrillAdmin.EsColumnaCalendario(iugEjercicio.ActiveCell) Then
                        iugEjercicio.UpdateData()
                    End If
                    iugEjercicio.PerformAction(ExitEditMode, False, False)
                Else
                    iugEjercicio.PerformAction(EnterEditMode, False, False)
                End If

            Case Keys.Escape
                iugEjercicio.PerformAction(UndoCell, False, False)
                e.Handled = True

            Case Keys.Left
                If Not EnEdicion Then
                    If iugEjercicio.ActiveCell.Column.Key.ToLower <> "soporte" Then
                        iugEjercicio.PerformAction(PrevCell, False, False)
                    End If
                    e.Handled = True
                End If

            Case Keys.Right
                If Not EnEdicion Then
                    If iugEjercicio.ActiveCell.Column.Key.ToLower <> "total neto" Then
                        iugEjercicio.PerformAction(NextCell, False, False)
                    End If
                    e.Handled = True
                End If

            Case 107 ' +
                iugEjercicio.PerformAction(ExpandRow, False, False)

            Case 109 ' -
                Dim cel As String
                If iugEjercicio.ActiveRow.Band.Index > 0 Then
                    If iugEjercicio.ActiveCell.Column.Key = "Tema" Then
                        cel = "Programa"
                    Else
                        cel = iugEjercicio.ActiveCell.Column.Key
                    End If
                    iugEjercicio.ActiveRow.ParentRow.Cells(cel).Activated = True
                End If
                iugEjercicio.PerformAction(CollapseRow, False, False)

            Case Keys.Down ' SE HACE PARA QUE CUANDO ESTE EN MODO EDICION BAJE
                ComprobarCompras()
                iugEjercicio.PerformAction(BelowCell, False, False)
                e.Handled = True

            Case Keys.Back
                If Me.iugEjercicio.Selected.Cells.Count = 0 AndAlso iugEjercicio.ActiveCell.Band.Index > 0 Then
                    iugEjercicio.ActiveCell.Value = ""
                End If
            Case Keys.End

            Case Keys.Home

            Case Keys.ShiftKey, Keys.Shift

            Case Else
                If Not EnEdicion Then
                    If e.KeyCode = Keys.C And e.Control = True Then
                        If GrillAdmin.EsColumnaCalendario(Me.iugEjercicio.ActiveCell.Column.Key) Then
                            CopiarPegar("C")
                        End If

                        CopiarPegarDescuentos(Me.iugEjercicio.ActiveCell.Column.Key, "C")
                        Exit Sub
                    End If

                    If e.KeyCode = Keys.V And e.Control = True Then
                        If GrillAdmin.EsColumnaCalendario(Me.iugEjercicio.ActiveCell.Column.Key) Then
                            CopiarPegar("P")
                        End If

                        CopiarPegarDescuentos(Me.iugEjercicio.ActiveCell.Column.Key, "P")
                        Exit Sub
                    End If
                End If

                If Not iugEjercicio.ActiveCell Is Nothing AndAlso _
                GrillAdmin.EsColumnaCalendario(iugEjercicio.ActiveCell.Column) Then

                    'si tiene vigencia nula, sale del SUB
                    If Me.iugEjercicio.ActiveCell.Appearance.BackColor.Equals(Me.ColorVigenciaNula) Then
                        Exit Sub
                    End If

                    If Me.iugEjercicio.ActiveCell.Appearance.BackColor.Equals(Me.ColorDiaEspecial) Then
                        Exit Sub
                    End If

                    '*** aca se pasa a mayusculas la letra ingresada ***
                    '(TAMBIEN SE CAMBIA A MAYUSCULAS EN EL KEY PRESS)
                    Dim LetraIngresada As Char

                    Select Case e.KeyCode
                        Case Keys.NumPad0, Keys.D0
                            LetraIngresada = "0"
                        Case Keys.NumPad1, Keys.D1
                            LetraIngresada = "1"
                        Case Keys.NumPad2, Keys.D2
                            LetraIngresada = "2"
                        Case Keys.NumPad3, Keys.D3
                            LetraIngresada = "3"
                        Case Keys.NumPad4, Keys.D4
                            LetraIngresada = "4"
                        Case Keys.NumPad5, Keys.D5
                            LetraIngresada = "5"
                        Case Keys.NumPad6, Keys.D6
                            LetraIngresada = "6"
                        Case Keys.NumPad7, Keys.D7
                            LetraIngresada = "7"
                        Case Keys.NumPad8, Keys.D8
                            LetraIngresada = "8"
                        Case Keys.NumPad9, Keys.D9
                            LetraIngresada = "9"
                        Case Else
                            LetraIngresada = Chr(e.KeyCode).ToUpper(Chr(e.KeyCode))
                    End Select

                    If ValidarLetra(LetraIngresada) OrElse iugEjercicio.ActiveCell.Band.Index > 0 Then
                        LetraValida = True
                        If Not EnEdicion Then
                            iugEjercicio.PerformAction(EnterEditMode)
                            If iugEjercicio.ActiveCell.Band.Index = 0 Then
                                iugEjercicio.ActiveCell.EditorResolved.Value &= LetraIngresada
                            Else
                                Dim Tema As Char
                                Tema = CType(iugEjercicio.ActiveCell.Row.ListObject, UltraDataRow).Tag.ToLower()
                                If GrillAdmin.ObtenerSpotsComprados(iugEjercicio.ActiveCell.Row.ParentRow.Cells(iugEjercicio.ActiveCell.Column.Key), Tema).Length > 0 Then
                                    Exit Sub
                                End If
                                LetraValida = True
                                iugEjercicio.ActiveCell.Value = String.Empty
                                Try
                                    iugEjercicio.ActiveCell.EditorResolved.Value = LetraIngresada
                                Catch ex As System.ArgumentException
                                End Try

                            End If
                        Else
                            iugEjercicio.ActiveCell.EditorResolved.Value &= LetraIngresada
                        End If

                        'guarda la ultima letra que se presiona, se usa para actualiza el Spots_Detalle_Log
                        Me.LetraNueva = LetraIngresada

                        If Me.iugEjercicio.ActiveCell.IsInEditMode Then
                            iugEjercicio.ActiveCell.SelStart = iugEjercicio.ActiveCell.EditorResolved.TextLength
                            iugEjercicio.ActiveCell.SelLength = 0
                        End If
                    End If

                End If
        End Select
    End Sub

    Private Function ValidarLetra(ByVal Letra As String) As Boolean
        dtTemas.CaseSensitive = True

        LetraValida = (dtTemas.Select("ID_Tema='" & Letra & "'").Length >= 1)

        ValidarLetra = LetraValida
    End Function

    Private Sub iugEjercicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles iugEjercicio.KeyPress
        If Not iugEjercicio.ActiveCell Is Nothing AndAlso GrillAdmin.EsColumnaCalendario(iugEjercicio.ActiveCell.Column) Then
            If Asc(e.KeyChar) <> 8 Then

                '*** SE CAMBIA LA LETRA INGRESADA A MAYUSCULAS (TAMBIEN SE CAMBIA EN EL KEY DOWN)
                'If Not ValidarLetra(e.KeyChar) Then
                e.Handled = True
                'End If
            End If
        End If
    End Sub

    Private Sub CopiarPegarDescuentos(ByVal Col As String, ByVal CopiarPegar As Char)
        'solo permite copiar y pegar valores para el Bruto, los Descuentos y los Ratings

        If Col.ToLower <> "bruto" And GrillAdmin.EsColumnaCalendario(Col) And Not GrillAdmin.EsColumnaDescuento(Col) And Not GrillAdmin.EsColumnaRating(Col) Then
            Exit Sub
        End If

        If CopiarPegar.ToLower(CopiarPegar) = "c" Then
            'copia todas las celdas seleecionadas
            Me.CopiarCeldasSeleccionadas()
            Exit Sub
        End If

        If CopiarPegar.ToLower(CopiarPegar) = "p" Then
            If Me.CopioDescuentos Then
                Me.PegarDescuentos()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PegarDescuentos()
        Dim CeldasSeleccionadas As SelectedCellsCollection
        Dim CeldaDestino As UltraGridCell
        Dim CeldaOrigen As CeldaCopiada
        Dim i As Integer = 0
        Dim FilaAnterior As Integer

        'ordena las celdas copiadas, por fila y por columna (sino, cuando se pega, salen en cualquier orden)
        'Array.Sort(Grilla.CeldasCopiadas, New ComparaCeldaCopiada)
        Grilla.CeldasCopiadas.Sort(New ComparaCeldaCopiada)

        CeldasSeleccionadas = Me.iugEjercicio.Selected.Cells

        FilaAnterior = CeldasSeleccionadas(0).Row.Index

        For Each CeldaDestino In CeldasSeleccionadas
            If CeldaDestino.Row.Index <> FilaAnterior Then
                FilaAnterior = CeldaDestino.Row.Index
                i = 0
            End If

            Try
                CeldaOrigen = DirectCast(Grilla.CeldasCopiadas(i), CeldaCopiada)

                CeldaDestino.Value = CeldaOrigen.Texto
            Catch ex As IndexOutOfRangeException

            Catch ex As ArgumentOutOfRangeException

            End Try

            i += 1
        Next
    End Sub

    Private Sub BorrarCeldas(ByVal Celdas As SelectedCellsCollection)
        'borra todas las celdas seleccionadas
        Dim C As UltraGridCell
        Dim Res As DialogResult
        Dim Col As String

        Res = Mensajes.Mensaje("¿Desea Borrar Todas las Celdas?", TipoMensaje.SiNo)

        If Res = DialogResult.No Then
            Exit Sub
        End If



        'recorre las celdas seleccionadas
        For Each C In Celdas
            If GrillAdmin.ObtenerSpotsComprados(C).Length = 0 Then
                Try
                    Col = C.Column.Key.Substring(0, 4).ToLower
                Catch ex As ArgumentOutOfRangeException
                    'si el nombre de la columna tiene menos de 4 caracteres, _
                    'asigna un nombre de columna diferente a "dcto"
                    Col = ""
                End Try

                'si es una columna del calendario o un descuento, borra el contenido
                If GrillAdmin.EsColumnaCalendario(C) Or Col = "dcto" Then
                    'actualiza el ultimo valor que va atener la celda (es para los calculos de los cuadros)
                    Me.UltimoText = Valores.CastDBNullObject(C.Value)
                    'activa la celda que se va a borrar
                    C.Activated = True
                    C.Value = "" 'DBNull.Value
                End If
                ' End If
            End If
        Next
    End Sub

    Private Sub iugEjercicio_DoubleClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles iugEjercicio.DoubleClickCell
        iugEjercicio.PerformAction(EnterEditMode)
    End Sub

    Private Sub CopiarCeldasSeleccionadas()
        'MODIFICACIONES DESCUENTOS COPIA
        Grilla.CeldasCopiadas = Nothing
        Dim Text As String
        'copia todas las celdas seleecionadas
        For Each C As UltraGridCell In Me.iugEjercicio.Selected.Cells
            If C.Band.Index = 0 Then
                Dim Celda As New CeldaCopiada
                'Texto = ObternerSpotsSinCompras(C)
                If GrillAdmin.EsColumnaCalendario(C) Then
                    Text = ObternerSpotsSinCompras(C)
                Else
                    Text = Valores.CastDBNullObject(C.Value)
                End If
                Celda.Texto = Text 'ObternerSpotsSinCompras(C) 'Texto 'Valores.CastDBNullObject(C.Value)
                Celda.IndiceFila = C.Row.Index
                Celda.IndiceColumna = C.Column.Index

                Grilla.CeldasCopiadas.Add(Celda)
                If IsNumeric(Celda.Texto) Or GrillAdmin.EsColumnaDescuento(Celda.IndiceColumna) Then
                    Me.CopioDescuentos = True
                Else
                    Me.CopioDescuentos = False
                End If
            End If
        Next
    End Sub
    Private Function ObternerSpotsSinCompras(ByVal Celda As UltraGridCell) As String
        Dim aux As String = ""
        Dim auxNumeros As String = ""

        Dim filtro As String = "fila=" & Celda.Row.Index & " and columna=" & "'" & Celda.Column.Key & "'"
        Dim CantidadCompra As Integer
        For Each c As Char In Celda.Text
            If Not c.IsLower(c) And Not Char.IsNumber(c) Then
                aux &= c
            ElseIf IsNumeric(c) Then
                If dtComprados.Columns("tema" & c) Is Nothing Then
                    Exit Function
                End If
                CantidadCompra = Valores.CastDBNull(GrillAdmin.ObtenerDato(Me.dtComprados, filtro, "tema" & c))
                If CantidadCompra > 0 Then
                    If CantidadCompra > auxNumeros.Length - 1 Then
                        auxNumeros &= c
                    End If
                End If
            End If
        Next
        Return aux & auxNumeros


    End Function
    Private Function ObternerSpotsSinCompras(ByVal texto As String, ByVal Fila As Integer, ByVal Col As Integer) As String
        Dim aux As String = ""
        Dim auxNumeros As String = ""
        Dim filtro As String = "fila=" & Fila & " and columna=" & "'" & iugEjercicio.Rows(Fila).Cells(Col).Column.Key & "'"
        Dim CantidadCompra As Integer
        For Each c As Char In texto
            If Not c.IsLower(c) And Not Char.IsNumber(c) Then
                aux &= c
            ElseIf IsNumeric(c) Then
                CantidadCompra = Valores.CastDBNull(GrillAdmin.ObtenerDato(Me.dtComprados, filtro, "tema" & c))
                If CantidadCompra > 0 Then
                    If CantidadCompra > auxNumeros.Length - 1 Then
                        auxNumeros &= c
                    End If
                End If
            End If
        Next
        Return aux
    End Function
    Private Sub CopiarPegar(ByVal pCopiarPegar As String)
        'COPIAR
        Dim Cc As New CeldaCopiada

        For Each Cc In Grilla.CeldasCopiadas
            If GrillAdmin.EsColumnaDescuento(Cc.IndiceColumna) Then
                Exit Sub
            End If
        Next

        If pCopiarPegar = "C" Then
            Me.CopiarCeldasSeleccionadas()
        Else
            If Grilla.CeldasCopiadas Is Nothing OrElse Grilla.CeldasCopiadas.Count <= 0 Then
                Exit Sub
            End If
            If Me.CopioDescuentos Then
                Exit Sub
            End If
            Dim ColActual, FilaActual, FilaAnterior, ColInicial, FilaInicial As Integer
            Dim Res As DialogResult
            Dim HayColumnasInvalidas, HayColumnasConTemas, ReemplazarTemas, NoEsDiaEmision As Boolean
            Dim CeldaDestino As UltraGridCell
            Dim IDSpot As Integer
            Dim Ur As UltraDataRow
            Dim CompraAnterior As String
            Dim CompraActual As String
            Dim VisibleActual As Integer

            ColActual = Me.iugEjercicio.ActiveCell.Column.Index
            ColInicial = ColActual
            FilaActual = Me.iugEjercicio.ActiveRow.Index
            FilaInicial = FilaActual
            VisibleActual = FilaActual
            'ordena las celdas copiadas, por fila y por columna (sino, cuando se pega, salen en cualquier orden)
            'Array.Sort(Grilla.CeldasCopiadas, New ComparaCeldaCopiada)
            Grilla.CeldasCopiadas.Sort(New ComparaCeldaCopiada)

            FilaAnterior = DirectCast(Grilla.CeldasCopiadas(0), CeldaCopiada).IndiceFila

            '***
            Me.AnalizarCeldasDestino(HayColumnasInvalidas, HayColumnasConTemas, NoEsDiaEmision, Grilla.CeldasCopiadas, FilaAnterior, FilaActual, ColInicial, ColActual)

            'pregunta si desea continuar con el pegado, a pesar de que hay celdas con temas comprados
            If HayColumnasConTemas Then
                Res = Mensajes.Mensaje("Existen Celdas con Temas Comprados. ¿Desea Reemplazarlos por los Temas Copiados?", TipoMensaje.SiNoCancelar)

                Select Case Res
                    Case DialogResult.Yes

                        ReemplazarTemas = True

                    Case DialogResult.No
                        ReemplazarTemas = False
                    Case DialogResult.Cancel
                        Exit Sub
                End Select
            End If

            'pregunta si desea continuar con el pagado, a pesar de que hay columnas invalidas
            If HayColumnasInvalidas Then
                Res = Mensajes.Mensaje("Existen Columnas Inválidas para Pegar Temas." & vbCrLf & _
                "Sí Continúa con el Pegado, hay Temas Copiados que No se Pegarán." & vbCrLf & _
                "¿Desea Continuar?", TipoMensaje.SiNo)

                If Res = DialogResult.No Then
                    Exit Sub
                End If
            End If

            'pregunta si desae continuar con el pegado,
            'a pesar de que hay celdas en los que el programa no tiene emision
            If NoEsDiaEmision Then
                Res = Mensajes.Mensaje("Alguno de los Días en los que se Pegarán los Temas No son los Días de Emisión del Programa. ¿Desea Continuar?", TipoMensaje.SiNo)

                If Res = DialogResult.No Then
                    Exit Sub
                End If
            End If
            '***

            'recorre las celdas copiadas
            For Each CeldaOrigen As CeldaCopiada In Grilla.CeldasCopiadas
                'si esta en una fila nueva, reinicia el valor de la columna
                If CeldaOrigen.IndiceFila <> FilaAnterior Then
                    'FilaActual += 1
                    ColActual = ColInicial
                    VisibleActual = iugEjercicio.Rows.GetRowAtVisibleIndexOffset(iugEjercicio.Rows(VisibleActual), 1).Index
                End If

                Try
                    CeldaDestino = Me.iugEjercicio.Rows(VisibleActual).Cells(ColActual)
                    'CeldaDestino = iugEjercicio.Rows.GetRowAtVisibleIndex(FilaActual).Cells(ColActual)
                Catch ex As IndexOutOfRangeException
                    Exit Sub
                End Try

                CeldaDestino.Activated = True
                CeldaDestino.Selected = True

                'solo compra si la vigencia lo permite y es una celda del calendario
                If Not CeldaDestino.Appearance.BackColor.Equals(Me.ColorVigenciaNula) AndAlso _
                GrillAdmin.EsColumnaCalendario(CeldaDestino) AndAlso _
                FilaActual <= Me.iugEjercicio.Rows.Count Then

                    'guarda los temas comprados en la tema que se va a pisar con el Pegado
                    Me.UltimoText = Valores.CastDBNullObject(Me.iugEjercicio.Rows(VisibleActual).Cells(ColActual).Value)

                    '*** ACA PEGA EL CONTENIDO DE LA CELDA COPIADA ***

                    If ReemplazarTemas Then ' SI PSO QUE SI
                        If GrillAdmin.ObtenerSpotsComprados(CeldaDestino).Length = 0 Then ' si no tiene compras
                            CeldaDestino.Value = CeldaOrigen.Texto 'Me.ObternerSpotsSinCompras(CeldaOrigen.Texto, CeldaOrigen.IndiceFila, CeldaOrigen.IndiceColumna)
                        Else
                            CeldaDestino.Value = GrillAdmin.ObtenerSpotsComprados(CeldaDestino) & CeldaOrigen.Texto ' Me.ObternerSpotsSinCompras(CeldaOrigen.Texto, CeldaOrigen.IndiceFila, CeldaOrigen.IndiceColumna)
                        End If

                    Else 'QUE NO
                        'agrega los temas copiados a la celda
                        CeldaDestino.Value &= CeldaOrigen.Texto 'Me.ObternerSpotsSinCompras(CeldaOrigen.Texto, CeldaOrigen.IndiceFila, CeldaOrigen.IndiceColumna)
                    End If

                End If

                'contadores que marcan la posicion de la celda en la que se va a pegar
                ColActual += 1
                FilaAnterior = CeldaOrigen.IndiceFila
            Next

        End If
    End Sub

    Private Sub AnalizarCeldasDestino(ByRef HayColumnasInvalidas As Boolean, ByRef HayColumnasConTemas As Boolean, ByRef NoEsDiaEmision As Boolean, ByVal CeldasCopiadas As Object, ByVal FilaAnterior As Integer, ByVal FilaActual As Integer, ByVal ColInicial As Integer, ByVal ColActual As Integer)
        HayColumnasInvalidas = False
        HayColumnasConTemas = False

        'chequea que las celdas en donde se va a pegar son celdas del calendario
        For Each CeldaOrigen As CeldaCopiada In CeldasCopiadas
            If CeldaOrigen.IndiceFila <> FilaAnterior Then
                FilaActual += 1
                ColActual = ColInicial
            End If

            Dim CeldaDestino As UltraGridCell

            Try
                CeldaDestino = Me.iugEjercicio.Rows(FilaActual).Cells(ColActual)
            Catch ex As IndexOutOfRangeException
                'si no tiene mas filas o columnas, se esta queriendo pegar fuera de la grilla
                HayColumnasInvalidas = True
            End Try

            'si hay columnas que no son calendario marca el flag
            If Not GrillAdmin.EsColumnaCalendario(CeldaDestino.Column) Then
                HayColumnasInvalidas = True
            End If

            'si hay celdas que YA TIENEN temas comprados, marca el flag
            If GrillAdmin.EsColumnaCalendario(CeldaDestino.Column) AndAlso Not CeldaDestino.Value Is DBNull.Value AndAlso Not CeldaDestino.Text.Trim = "" Then
                HayColumnasConTemas = True
            End If

            If Not GrillAdmin.EsDiaPrograma(CeldaDestino) AndAlso Not CeldaOrigen.Texto = "" Then
                NoEsDiaEmision = True
            End If

            'sale del SUB si ya se encontro aunque sea una columna invalida y una celda con temas comprados,
            'y una celda de destino que no tiene emision el programa
            If HayColumnasInvalidas And HayColumnasConTemas And NoEsDiaEmision Then
                Exit Sub
            End If

            'contadores que marcan la posicion de la celda en la que se va a pegar
            ColActual += 1
            FilaAnterior = CeldaOrigen.IndiceFila
        Next
    End Sub

    Private Function CalcularLetra(ByVal Valor As Integer, ByVal Shift As Boolean) As String
        Mayusculas = Teclas.CapsActivado
        Dim Letra As Integer
        'If Valor > 64 And Valor < 91 Then
        If Mayusculas Then
            If Shift Then
                Letra = Valor + LetraMinuscula
            Else
                Letra = Valor
            End If
        Else
            If Shift Then
                Letra = Valor
            Else
                Letra = Valor + LetraMinuscula
            End If
        End If
        'End If

        'ValidarLetra(Letra)

        Return Letra
    End Function

    Private Sub UltraDataSource1_CellDataUpdating(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinDataSource.CellDataUpdatingEventArgs) Handles UltraDataSource1.CellDataUpdating
        If e.Row.Band.Key <> "BandaSpot" Then Exit Sub
        ActualizarTotales(e)

        Dim Celda As UltraGridCell

        Celda = Me.iugEjercicio.ActiveCell

        'AG 02/3/2009 Auspicios -------------------------------------------------------------------------------
        If SalidaAuspicio = True Then
            Exit Sub
        End If

        'If SalidaBonificar = True Then
        '    Exit Sub
        'End If
        '---------------------------------------------------------------------------------------------------------

        'AG 13/05/2014 =================
        If ControlAvisosComprados = True Then
            Exit Sub
        End If
        '===============================

        If Not Celda Is Nothing AndAlso GrillAdmin.EsColumnaCalendario(Celda.Column) Then
            IDSpotCompra = Me.iugEjercicio.ActiveRow.Cells("id_spot").Text

            KeyCompra = Celda.Column.Key
            TextCompra = IIf(IsDBNull(e.NewValue), "", e.NewValue)
            If TextCompra <> String.Empty Then
                OrdenarTemasComprados(TextCompra)
                e.NewValue = TextCompra
            End If
        Else
            Exit Sub
        End If

        Me.iugEjercicio.BeginUpdate()

        Dim antRow As Integer
        Dim antCol As Integer

        antRow = iugEjercicio.ActiveCell.Row.Index
        antCol = iugEjercicio.ActiveCell.Column.Index

        'REALIZAR LA COMPRA
        GrillAdmin.AgregarHijo(Me.UltraDataSource1, DetalleBase, e.Row.Index, KeyCompra, TextCompra.ToUpper, ColumnasHijos, Me.dtTemas, IDSpotCompra)

        iugEjercicio.Rows(antRow).Cells(antCol).Activated = True
        iugEjercicio.Rows(antRow).Cells(antCol).Selected = True

        Me.iugEjercicio.EndUpdate()

        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Moneda, "Total Bruto", "Total Neto")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Decimales, "Total GRP Target 1", "Total GRP Target 2")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.General, "Total Spots", "DUR")
        GrillaFormato.CambiarAlineacionColumna(iugEjercicio)

        For Each b As UltraGridBand In iugEjercicio.DisplayLayout.Bands
            If b.Index > 0 Then
                GrillaFormato.FijarColumna(b.Columns("Tema"), True)
                GrillaFormato.FijarColumna(iugEjercicio.DisplayLayout.Bands(b.Index).Columns(b.Columns("tema").Index + 4), True)
                'GrillaFormato.FijarColumna(b.Columns("h_fin"), True)
                GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, b.Index, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")
            End If
        Next

        Listas.OcultarHeader(iugEjercicio)

        GrillaFormato.ReocultarColumnasHijos(iugEjercicio)

        GrillaFormato.MoverColumnaTema(iugEjercicio, 3)

        '*** recalcula los cuadros, acumulando la cantidad de temas y sumando las duraciones
        Dim CompraAnterior As String = IIf(IsNothing(Me.UltimoText), "", Me.UltimoText)
        Dim CompraActual As String = IIf(IsDBNull(e.NewValue), "", e.NewValue)

        Me.CalcularGrillasResumen(CompraAnterior.ToUpper, CompraActual.ToUpper, e.Row, e.Column.Key)

        If e.NewValue Is DBNull.Value Then
            UltimoText = ""
        Else
            UltimoText = DirectCast(e.NewValue, String).ToUpper
        End If

        'AG Hoja Numero ==============================================
        If Activo.IDMedio = MedioTv Then
            GrillaFormato.MarcarDiasPrograma(iugEjercicio, ColorDia, ColorVigenciaNula)
            GrillaFormato.HabilitarEdicionColumnaHijo(iugEjercicio, Activation.NoEdit, Activation.AllowEdit)
        End If
        '===========================================================

        

    End Sub

    Private Sub UltraDataSource1_RowDeleting(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinDataSource.RowDeletingEventArgs) Handles UltraDataSource1.RowDeleting
        GrillAdmin.BorrarFilaDataTable(e.Row.Index, Me.SpotBase)
    End Sub

    Private Property ColumnasBorradas() As Hashtable
        Get
            If mColumnasBorradas Is Nothing Then
                mColumnasBorradas = New Hashtable
            End If

            Return mColumnasBorradas
        End Get
        Set(ByVal Value As Hashtable)
            mColumnasBorradas = Value
        End Set
    End Property

    Private Sub iugEjercicio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iugEjercicio.MouseUp
        Try
            If e.Button = MouseButtons.Right Then

                Dim aUIElement As Infragistics.Win.UIElement

                aUIElement = iugEjercicio.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))

                Dim C As Infragistics.Win.UltraWinGrid.ColumnHeader

                C = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

                If Not C Is Nothing Then
                    ColumnaParaBorrar = C.Column.Key
                    IndiceColBorrar = C.Column.Index
                    TituloColumnaParaBorrar = C.Caption

                    Me.mnuColumnasOcultas.Show(Me.iugEjercicio, New Point(e.X, e.Y))
                Else
                    Dim cel As Infragistics.Win.UltraWinGrid.UltraGridCell
                    cel = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridCell))
                    If Not cel Is Nothing Then
                        If Not iugEjercicio.ActiveCell Is Nothing Then
                            iugEjercicio.ActiveCell.Selected = False
                            iugEjercicio.ActiveCell.Activated = False
                        End If
                        cel.Activated = True
                        cel.Selected = True
                    End If
                    Me.CtxMenu.Show(Me.iugEjercicio, New Point(e.X, e.Y))
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnuOcultarColumna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOcultarColumna.Click
        Select Case ColumnaParaBorrar.ToLower
            Case "soporte", "programa", "dias", "h_inicio", "h_fin", "total neto"
                Exit Sub
        End Select

        If GrillAdmin.EsColumnaCalendario(ColumnaParaBorrar) Then
            Exit Sub
        End If

        Me.iugEjercicio.DisplayLayout.Bands(0).Columns(ColumnaParaBorrar).Hidden = True

        Dim M As New MenuItem

        If Me.mnuColumnasOcultas.MenuItems.Count = 1 Then
            M.Text = "-"
            Me.mnuColumnasOcultas.MenuItems.Add(M)

            M = New MenuItem
        End If

        Me.mnuColumnasOcultas.MenuItems.Add(TituloColumnaParaBorrar, AddressOf ClickEnMenu)

        Me.ColumnasBorradas.Add(Me.mnuColumnasOcultas.MenuItems(Me.mnuColumnasOcultas.MenuItems.Count - 1).Text, ColumnaParaBorrar)

        GrillaFormato.OcultarColumnasHijos(iugEjercicio, ColumnaParaBorrar, True)
    End Sub

    Private Sub ClickEnMenu(ByVal sender As Object, ByVal e As EventArgs)
        Dim M As MenuItem
        Dim Key As String

        M = DirectCast(sender, MenuItem)
        Key = Me.ColumnasBorradas.Item(M.Text).ToString

        Me.iugEjercicio.DisplayLayout.Bands(0).Columns(Key).Hidden = False

        Me.mnuColumnasOcultas.MenuItems.Remove(M)
        Me.ColumnasBorradas.Remove(M.Text)

        If Me.mnuColumnasOcultas.MenuItems.Count = 2 Then
            Me.mnuColumnasOcultas.MenuItems.RemoveAt(1)
        End If
        iugEjercicio.DisplayLayout.Bands(0).Columns(Key).PerformAutoResize()
        GrillaFormato.OcultarColumnasHijos(iugEjercicio, Key, False)
    End Sub

    Private Sub mnuBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBorrar.Click
        Me.Cursor = Cursors.WaitCursor

        Dim F As UltraGridRow
        Dim Mensaje As String
        Dim FilasBorrar As New ArrayList

        For Each F In Me.iugEjercicio.Selected.Rows
            If F.Band.Index = 0 Then
                If Not FilaTieneCompras(F) Then
                    FilasBorrar.Add(F)
                End If
            End If
        Next
        Try
            For Each F In FilasBorrar
                If F.HasChild Then

                    Mensaje = "El Programa '" & F.Cells("Programa").Text & "' Tiene Temas Comprados. " & vbCrLf & "¿Está Seguro que Desea Borrarlo?"

                    If Mensajes.Mensaje(Mensaje, TipoMensaje.SiNo) = DialogResult.Yes Then
                        BorrarPrograma(F)
                    End If
                Else
                    BorrarPrograma(F)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'AG Velocidad ================================================================
        If cbCalculoAutomatico.Checked = False Then
            'AG 28/04/2016 
            GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
            Exit Sub
        End If
        '===========================================================================

        GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas)

        Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)
        Me.iugTema.DataSource = GrillaResumen.GrillaPorTema(Me.UltraDataSource1, dtTemas)
        Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas, Activo.FechaFinSistema)
        Me.iugFranja.DataSource = GrillaResumen.GrillaPorFranja(Me.UltraDataSource1, Franjas, dtTemas)

        Me.Cursor = Cursors.Default
    End Sub
    Private Function FilaTieneCompras(ByVal fila As UltraGridRow) As Boolean
        For Each c As UltraGridCell In fila.Cells
            If GrillAdmin.ObtenerSpotsComprados(c).Length > 0 Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub BorrarPrograma(ByVal Fila As UltraGridRow)
        'borra los datos del Spot que se graba en la base
        Dim Filtro As String = "id_spot=" & Fila.Cells("id_spot").Value
        Dim Dr, Spot As DataRow
        Dim Ur As UltraDataRow

        Try
            Spot = SpotBase.Select(Filtro)(0)

            For Each Dr In DetalleBase.Select("id_spot=" & Spot("id_spot"))
                Dr("f_modi") = Now.Date
                Dr("u_modi") = Activo.Login
                Dr.Delete()
            Next

            Spot("f_modi") = Now.Date
            Spot("u_modi") = Activo.Login
            Spot.Delete()
        Catch ex As Exception
            MsgBox(" BORRAR PROGRAMA " & ex.Message)
        End Try

        'recorre el ultra source
        For Each Ur In Me.UltraDataSource1.Rows
            If Ur.Item("id_spot") = Fila.Cells("id_spot").Value.ToString Then
                Me.UltraDataSource1.Rows.Remove(Ur)
                Exit For
            End If
        Next
    End Sub

    Private Sub CalcularGrillasResumen(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Fila As UltraDataRow, ByVal Columna As String)
        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico

        If cbCalculoAutomatico.Checked Then
            Me.Cursor = Cursors.WaitCursor

            Dim CalSoporte, CalFranja, CalSemana, CalTema As Boolean

            CalSoporte = Not Me.UltraDockManager1.ControlPanes("soporte").Closed
            CalFranja = Not Me.UltraDockManager1.ControlPanes("franja").Closed
            CalSemana = Not Me.UltraDockManager1.ControlPanes("semana").Closed
            CalTema = Not Me.UltraDockManager1.ControlPanes("tema").Closed

            If CalSoporte Or CalFranja Or CalSemana Then
                Me.CalcularDuracionPromedio(CompraAnterior, CompraActual, Fila, Columna)
            End If

            If CalSoporte Then
                Me.iugSoporte.DataSource = GrillaResumen.Soporte(CompraAnterior, CompraActual, Fila, Me.SoportesDuracion, dtTemas)
                'Me.iugSoporte.DisplayLayout.Bands(0).Summaries("CPR").Refresh()
            End If

            If CalFranja Then
                Me.iugFranja.DataSource = GrillaResumen.Franja(CompraAnterior, CompraActual, Fila, Franjas, dtTemas)
                ' Me.iugFranja.DisplayLayout.Bands(0).Summaries("CPR").Refresh()
            End If

            If CalTema Then
                Me.iugTema.DataSource = GrillaResumen.Tema(CompraAnterior, CompraActual, Fila, dtTemas)
                ' Me.iugTema.DisplayLayout.Bands(0).Summaries("CPR").Refresh()
            End If

            If CalSemana Then
                Me.iugSemana.DataSource = GrillaResumen.Semana(CompraAnterior, CompraActual, Fila, Columna, Me.Semanas, dtTemas)
                '  Me.iugSemana.DisplayLayout.Bands(0).Summaries("CPR").Refresh()
            End If

            

            GrillaFormato.AutoAjustarColumnas(Me.iugSoporte)

            Me.Cursor = Cursors.Default
        End If

        'AG 18/02/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'GrillaResumen.ActualizarTotalesResumen(CompraAnterior, CompraActual, Fila, dtTemas, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR)
        GrillaResumen.ActualizarTotalesResumen(CompraAnterior, CompraActual, Fila, dtTemas, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1) 'AG 18/02/2013
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    End Sub

    Private Sub CargarPreEvaluacion()
        Dim PreEvaluacion As New DataTable

        With PreEvaluacion
            .Columns.Add("Id", GetType(Int32))

            .Columns("id").AutoIncrement = True
            .Columns("id").AutoIncrementSeed = 1

            .Columns.Add("Procesar", GetType(Boolean))
            .Columns.Add("Fecha", GetType(String))
            .Columns.Add("Dia", GetType(String))
            .Columns.Add("Hora", GetType(String))
            .Columns.Add("SoporteEvaIbo", GetType(String))
            .Columns.Add("Spots", GetType(Int16), 1)

            .Columns.Add("Id_Soporte", GetType(Int64))
            .Columns.Add("Id_Tarifa", GetType(Int64))
            .Columns.Add("Id_Tema", GetType(String))
            .Columns.Add("Soporte", GetType(String))
            .Columns.Add("Programa", GetType(String))
            .Columns.Add("Material", GetType(String))
            .Columns.Add("Rotlvsd", GetType(String))
            .Columns.Add("DayPart", GetType(Int32))
            .Columns.Add("Duracion", GetType(Int32))
            .Columns.Add("Costo", GetType(Double))

            .Columns.Add("PBR_1", GetType(Double))
            .Columns.Add("PBR_2", GetType(Double))
            .Columns.Add("CPR1_1", GetType(Double))
            .Columns.Add("CPR1_2", GetType(Double))
        End With

        Dim Dr As DataRow
        Dim NuevaFila As DataRow

        For Each Dr In DetalleBase.Rows
            NuevaFila = PreEvaluacion.NewRow

            NuevaFila("fecha") = Dr("f_spot")
            NuevaFila("id_soporte") = GrillAdmin.ObtenerDato(SpotBase, "id_spot=" & Dr("id_spot"), "id_soporte")
            NuevaFila("id_tarifa") = GrillAdmin.ObtenerDato(SpotBase, "id_spot=" & Dr("id_spot"), "id_tarifa_tv")
            NuevaFila("id_tema") = Dr("id_tema")
            NuevaFila("duracion") = Dr("duracion")

            PreEvaluacion.Rows.Add(NuevaFila)
        Next

        Dim S As New Sistemas

        S.Id_campania = Activo.IDCampaña
        S.Id_sistema = Activo.IDSistema

        S.BuscarPorID()

        'llamada al metodo de la pre evaluacion
        Dim F As New frmPreEvaluar

        F.dtSpots = PreEvaluacion
        F.Id_target1 = S.Id_target_1
        F.Id_target2 = S.Id_target_2
        F.F_Desde = S.F_inicio_aud
        F.F_Hasta = S.F_fin_aud

        F.ShowDialog()
    End Sub

    Private Sub iugEjercicio_CellDataError(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs) Handles iugEjercicio.CellDataError
        If Me.iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If

        With iugEjercicio.ActiveCell.Column
            Select Case .Key
                Case "Neto", "Bruto", "RAT_PROG_TARGET_1", "SHR_PROG_TARGET_1", "AFF_PROG_TARGET_1", "RCH_PROG_TARGET_1", "RAT_M_PROG_TARGET_1", "FID_PROG_TARGET_1" _
                , "RAT_PROG_TARGET_2", "SHR_PROG_TARGET_2", "AFF_PROG_TARGET_2", "RCH_PROG_TARGET_2", "RAT_M_PROG_TARGET_2", "FID_PROG_TARGET_2" _
                , "RAT_TANDA_TARGET_2", "SHR_TANDA_TARGET_2", "AFF_TANDA_TARGET_2", "RCH_TANDA_TARGET_2", "RAT_M_TANDA_TARGET_2", "FID_TANDA_TARGET_2" _
                , "RAT_TANDA_TARGET_2", "SHR_TANDA_TARGET_2", "AFF_TANDA_TARGET_2", "RCH_TANDA_TARGET_2", "RAT_M_TANDA_TARGET_2", "FID_TANDA_TARGET_2" _
                , "dcto1", "dcto2", "dcto3", "dcto4", "dcto5"
                    If Not .DataType Is GetType(String) Then
                        Mensajes.Mensaje("Este campo solo admite numeros", TipoMensaje.Informacion)
                        e.RestoreOriginalValue = True
                    End If
            End Select
        End With
        e.RaiseErrorEvent = False
    End Sub

    Private Sub frmEjercicio_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not HayCambios Then
            Activo.EjerciciosCargados.Remove(Ejer)
            Exit Sub
        End If

        Dim Respuesta As DialogResult

        Respuesta = Mensajes.Mensaje("¿Desea Guardar los Cambios?", TipoMensaje.SiNoCancelar)

        If Respuesta = DialogResult.Yes Then
            Guardar()
            Activo.EjerciciosCargados.Remove(Ejer)
            Exit Sub
        End If

        If Respuesta = DialogResult.Cancel Then
            e.Cancel = True
            Exit Sub
        End If

        Activo.EjerciciosCargados.Remove(Ejer)
    End Sub

    Private Sub Guardar()
        Me.Cursor = Cursors.WaitCursor

        Dim Ds As DataSet
        Dim S As New Spots
        Dim D As New Spots_detalle
        'Cuando el Wingrid tiene el foco, a veces no se actualiza bien
        'por lo tanto aca se saca el foco al a otro control
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        Try
            If SpotBase.DataSet Is Nothing Then
                Ds = New DataSet

                Ds.Tables.Add(SpotBase)
                Ds.Tables.Add(DetalleBase)

            End If
            Dim Padre As DataColumn = SpotBase.Columns("id_spot")
            Dim Hijo As DataColumn = DetalleBase.Columns("id_spot")

            Dim R As New DataRelation("Union", Padre, Hijo)

            If Not Ds Is Nothing Then
                Ds.Relations.Add(R)
            End If

            SpotBase.DataSet.EnforceConstraints = False
            S.ActualizarDataSet(SpotBase.DataSet, SpotBase.TableName)
            SpotBase.DataSet.EnforceConstraints = True
            D.ActualizarDataSet(DetalleBase.DataSet, DetalleBase.TableName, SpotBase.TableName, Activo.Login, Activo.Estado)

        Catch ex As Exception
            MsgBox("Ejercicio-Guardar: " & ex.Message)
        End Try
        HayCambios = False

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mnuSemana7Dias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSemana7Dias.Click
        Me.Cursor = Cursors.WaitCursor

        If Not mnuSemana7Dias.Checked Then
            mnuSemana7Dias.Checked = True
            mnuSemanaCalendario.Checked = False

            Me.Semanas = GrillaResumen.ObtenerSemanas7Dias(Me.UltraDataSource1, Activo.FechaFinSistema)

            Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas, Activo.FechaFinSistema)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mnuSemanaCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSemanaCalendario.Click
        Me.Cursor = Cursors.WaitCursor

        If Not mnuSemanaCalendario.Checked Then
            mnuSemanaCalendario.Checked = True
            mnuSemana7Dias.Checked = False

            Me.Semanas = GrillaResumen.ObtenerSemanasCalendario(Me.UltraDataSource1)

            Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Me.Guardar()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PRE EVALUACION
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'BORRAR
        Me.mnuBorrar_Click(Me.iugEjercicio, New EventArgs)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        'CARGAR SOPORTES
        Me.CargarSoportes(False)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'CONVENIO PUNTUAL
        Me.CargarConvenioPuntual()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        'CONVENIO GLOBAL
        Me.CargarConvenioGlobal()
    End Sub

    Private Sub MostrarOcultarDock(ByVal Dock As String, ByVal Menu As MenuItem)
        If Menu.Checked Then
            Menu.Checked = False
            Me.UltraDockManager1.ControlPanes(Dock).Close()
        Else
            Menu.Checked = True
            Me.UltraDockManager1.ControlPanes(Dock).Show()

            Select Case Dock.ToLower
                Case "soporte"
                    GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas)

                    Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)
                Case "franja"
                    GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas)

                    Me.iugFranja.DataSource = GrillaResumen.GrillaPorFranja(Me.UltraDataSource1, Franjas, dtTemas)
                Case "semana"
                    GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas)

                    Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas, Activo.FechaFinSistema)
                Case "tema"
                    Me.iugTema.DataSource = GrillaResumen.GrillaPorTema(Me.UltraDataSource1, dtTemas)
            End Select
        End If
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        'MUESTRA Y OCULTA EL ENCABEZADO DE LOS TOTALES
        'Me.MostrarOcultarDock("totales", Me.MenuItem11)
        If Me.MenuItem11.Checked Then
            Me.pnlTotal.Visible = False
            Me.MenuItem11.Checked = False
        Else
            Me.pnlTotal.Visible = True
            Me.MenuItem11.Checked = True
        End If
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        'CUBO
        Me.MostrarOcultarDock("cuboflex", Me.MenuItem38)
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        'DESGLOSE POR FRANJA
        Me.MostrarOcultarDock("franja", Me.MenuItem13)
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        'DESGLOSE POR SEMANA
        Me.MostrarOcultarDock("semana", Me.MenuItem14)
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        'DESGLOSE POR SOPORTE
        Me.MostrarOcultarDock("soporte", Me.MenuItem15)
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        'DESGLOSE POR TEMA
        Me.MostrarOcultarDock("tema", Me.MenuItem16)
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Me.Close()
    End Sub

    Private Sub iugEjercicio_BeforeSortChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSortChangeEventArgs) Handles iugEjercicio.BeforeSortChange
        For Each c As UltraGridColumn In e.SortedColumns
            If GrillAdmin.EsColumnaCalendario(c) Then
                e.Cancel = True
                Exit Sub
            End If
        Next
    End Sub

    Private Sub frmEjercicio_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        frmPrincipal.Instancia.ActualizarSoportesEjercicio()
    End Sub

    Private Sub UltraDockManager1_AfterPaneButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinDock.PaneButtonEventArgs) Handles UltraDockManager1.AfterPaneButtonClick
        If e.Button <> UltraWinDock.PaneButton.Close Then
            Exit Sub
        End If

        Select Case e.Pane.Key
            Case "totales"
                Me.MenuItem11.Checked = False
            Case "franja"
                Me.MenuItem13.Checked = False
            Case "semana"
                Me.MenuItem14.Checked = False
            Case "soporte"
                Me.MenuItem15.Checked = False
            Case "tema"
                Me.MenuItem16.Checked = False
        End Select
    End Sub

    Private Sub cmdCerrarTotales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrarTotales.Click
        Me.pnlTotal.Visible = False
        Me.MenuItem11.Checked = False

        Me.pnlTotal.Select()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        'VER DETALLE DE RATING
        Me.Cursor = Cursors.WaitCursor
        'VER DETALLE DE RATING
        If Me.iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If

        Dim f As New frmDetalle

        f.IDSoporte = Me.iugEjercicio.ActiveCell.Row.Cells("id_soporte").Value

        Select Case TipoDeAudiencia
            Case TipoAudiencia.Abierta
                If IsDBNull(Me.iugEjercicio.ActiveCell.Row.Cells("id_programa").Value) Then
                    Exit Sub
                End If
                f.IDPrograma = Me.iugEjercicio.ActiveCell.Row.Cells("id_programa").Value
            Case TipoAudiencia.Cable, TipoAudiencia.Intetior
                If IsDBNull(Me.iugEjercicio.ActiveCell.Row.Cells("id_tarifa_tv").Value) Then
                    Exit Sub
                End If
                f.IDPrograma = Me.iugEjercicio.ActiveCell.Row.Cells("id_tarifa_tv").Value
        End Select
        Dim tipo As String

        If iugEjercicio.ActiveCell.Column.Key.IndexOf("RAT_TANDA") > -1 Then
            tipo = "T"
        Else

            tipo = "P"

        End If
        f.IDTarget1 = Target
        f.TipoRating = TipoDeRating
        f.MostrarDetalle(TipoDeAudiencia, tipo)
        f.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CargarPerfil(ByVal Tipo As TipoAudiencia)
        Try
            Select Case Tipo
                Case TipoAudiencia.Abierta
                    iugEjercicio.DisplayLayout.LoadFromXml(Ruta & "DefaultAbierta.xml")
                Case TipoAudiencia.Cable
                    iugEjercicio.DisplayLayout.LoadFromXml(Ruta & "DefaultCable.xml")
                Case TipoAudiencia.Intetior
                    iugEjercicio.DisplayLayout.LoadFromXml(Ruta & "DefaultInterior.xml")
            End Select
        Catch e As Exception
            'MsgBox(e.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub GuardarPerfil(ByVal Tipo As TipoAudiencia)
        Select Case Tipo
            Case TipoAudiencia.Abierta
                iugEjercicio.DisplayLayout.SaveAsXml(Ruta & "DefaultAbierta.xml")
            Case TipoAudiencia.Cable
                iugEjercicio.DisplayLayout.SaveAsXml(Ruta & "DefaultCable.xml")
            Case TipoAudiencia.Intetior
                iugEjercicio.DisplayLayout.SaveAsXml(Ruta & "DefaultInterior.xml")
        End Select
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        'COPIAR
        If iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If
        Me.CopiarPegar("C")
        CopiarPegarDescuentos(Me.iugEjercicio.ActiveCell.Column.Key, "C")
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        'PEGAR
        If iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If
        Me.CopiarPegar("P")
        CopiarPegarDescuentos(Me.iugEjercicio.ActiveCell.Column.Key, "P")
    End Sub

    Private Sub ModificarTarifasCongeladas()
        If iugEjercicio.ActiveCell Is Nothing And iugEjercicio.ActiveRow Is Nothing Then
            Exit Sub
        End If
        Dim f As frmActualizarTarifasCongeladas
        Dim TarPla As New DataTable
        Dim DtSoportes As DataTable
        Dim I As ItemLista
        Dim Dr As DataRow
        Dim NuevaFila As DataRow

        If TypeOf AuxSoportes Is ArrayList Then
            DtSoportes = New DataTable

            With DtSoportes.Columns
                .Add("id_soporte", GetType(Integer))
                .Add("descripcion", GetType(String))
            End With

            'pasa los datos del Array al Data Table
            For Each I In AuxSoportes
                Dr = DtSoportes.NewRow

                Dr("id_soporte") = I.ID
                Dr("descripcion") = I.Descripcion

                DtSoportes.Rows.Add(Dr)
            Next
        Else
            DtSoportes = AuxSoportes
        End If

        With TarPla
            .Columns.Add("id_Spot", GetType(Int64))
            .Columns.Add("id_Programa", GetType(Int32))
            .Columns.Add("Programa", GetType(String))
            .Columns.Add("Bruto", GetType(String))
        End With

        For Each Dr In SpotBase.Rows
            NuevaFila = TarPla.NewRow
            If Dr.RowState <> DataRowState.Deleted Then
                NuevaFila("id_spot") = Dr("id_spot")
                NuevaFila("id_programa") = Dr("id_programa")
                NuevaFila("Programa") = Dr("Programa")
                NuevaFila("Bruto") = Dr("Bruto")
                TarPla.Rows.Add(NuevaFila)
            End If
        Next
        f = New frmActualizarTarifasCongeladas(DtSoportes, TarPla, Activo.FechaInicioAudiencia)
        f.ShowDialog()

        If Not f.Salir Then ' selecciono un convenio
            AplicarTarifasCongeladas(f.Dt)
        End If
    End Sub

    Private Sub AplicarTarifasCongeladas(ByVal dt As DataTable)
        Dim rfil() As DataRow
        Dim i As Integer



        For Each row As DataRow In dt.Rows
            If row("Ok") Then
                For i = 0 To iugEjercicio.Rows.Count - 1
                    If Not IsDBNull(iugEjercicio.Rows(i).Cells("id_programa").Value) AndAlso iugEjercicio.Rows(i).Cells("id_programa").Value = row("id_programa") Then
                        iugEjercicio.Rows(i).Cells("BrutoActual").Value = row("Precio")
                    End If
                Next
            End If
        Next

    End Sub

    Private Sub ColorCelda()
        Dim CdColor As New ColorDialog

        If iugEjercicio.ActiveCell Is Nothing Or iugEjercicio.Selected.Cells.Count = 0 Then
            Exit Sub
        End If

        CdColor.ShowDialog()

        For Each c As UltraGridCell In iugEjercicio.Selected.Cells
            If Not c.Appearance.BackColor.Equals(ColorVigenciaNula) Then
                c.Appearance.BackColor = CdColor.Color
            End If
        Next
    End Sub

    Private Sub LetraCelda()
        Dim CdColor As New ColorDialog

        If iugEjercicio.ActiveCell Is Nothing Or iugEjercicio.Selected.Cells.Count = 0 Then
            Exit Sub
        End If

        CdColor.ShowDialog()

        For Each c As UltraGridCell In iugEjercicio.Selected.Cells
            c.Appearance.ForeColor = CdColor.Color
        Next
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Me.ColorCelda()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Me.LetraCelda()
    End Sub

    Private Sub CrearXML(ByVal Nombre As String)
        Dim Propiedad As String
        Dim ePropiedad As XmlElement
        Dim Dom As New XmlDocument
        Dim i As Integer
        Dim j As Integer
        Dim ePerfil As XmlElement = Dom.CreateElement("perfil", "perfil")
        Dim eCelda As XmlElement
        Dim eColumna As XmlElement
        Dim AttKey As XmlAttribute
        Dim attSistema As XmlAttribute
        Dim attCampaña As XmlAttribute
        Dim TipoSuma As String
        Dim Filtro As String
        Dim attFila As XmlAttribute
        Dim attCol As XmlAttribute
        Dim Convertir As New System.Drawing.ColorConverter
        Try
            Dom.AppendChild(ePerfil)
            attSistema = Dom.CreateAttribute("campania")
            attCampaña = Dom.CreateAttribute("sistema")
            ePerfil.SetAttribute("campania", Activo.IDCampaña.ToString)
            ePerfil.SetAttribute("sistema", Activo.IDSistema.ToString)

            For Each C As UltraGridColumn In iugEjercicio.DisplayLayout.Bands(0).Columns
                If C.Key.IndexOf("Banda") < 0 And GrillAdmin.EsColumnaCalendario(C) = False Then
                    If C.Band.Summaries.Count <= 0 Then
                        TipoSuma = "none"
                    Else
                        TipoSuma = C.Band.Summaries(0).SummaryType
                    End If

                    If C.Band.ColumnFilters(C.Index).FilterConditions.Count <= 0 Then
                        Filtro = "none"
                    Else
                        Filtro = C.Band.ColumnFilters(C.Index).FilterConditions(0).ToString
                    End If

                    eColumna = Dom.CreateNode(XmlNodeType.Element, "columna", "columna")
                    AttKey = Dom.CreateAttribute("key")
                    eColumna.SetAttribute("key", C.Key)

                    ePropiedad = Dom.CreateElement("ancho")
                    ePropiedad.InnerText = C.Width.ToString
                    eColumna.AppendChild(ePropiedad)

                    ePropiedad = Dom.CreateElement("posicion")
                    ePropiedad.InnerText = C.Header.VisiblePosition.ToString
                    eColumna.AppendChild(ePropiedad)

                    ePropiedad = Dom.CreateElement("fijo")
                    ePropiedad.InnerText = C.Header.Fixed.ToString
                    eColumna.AppendChild(ePropiedad)

                    ePropiedad = Dom.CreateElement("sumatoria")
                    ePropiedad.InnerText = TipoSuma
                    eColumna.AppendChild(ePropiedad)

                    ePropiedad = Dom.CreateElement("oculto")
                    ePropiedad.InnerText = C.Hidden.ToString
                    eColumna.AppendChild(ePropiedad)

                    ePropiedad = Dom.CreateElement("ordenado")
                    ePropiedad.InnerText = C.SortIndicator
                    eColumna.AppendChild(ePropiedad)

                    ePropiedad = Dom.CreateElement("filtro")
                    ePropiedad.InnerText = Filtro
                    eColumna.AppendChild(ePropiedad)

                    For Each R As UltraGridRow In iugEjercicio.Rows
                        If Not R.Cells(C).Appearance.BackColor.Equals(ColorDia) _
                         And Not R.Cells(C).Appearance.BackColor.Equals(ColorColumnaNoEditable) _
                         And Not R.Cells(C).Appearance.BackColor.Equals(ColorColTotales) _
                         And Not R.Cells(C).Appearance.BackColor.Equals(ColorVigenciaNula) _
                         And Not R.Cells(C).Appearance.BackColor.ToString = "Color [Empty]" Then
                            eCelda = Dom.CreateNode(XmlNodeType.Element, "celdas", "celdas")
                            attFila = Dom.CreateAttribute("fila")
                            attCol = Dom.CreateAttribute("col")
                            eCelda.SetAttribute("fila", R.Index)
                            eCelda.SetAttribute("col", C.Index)

                            ePropiedad = Dom.CreateElement("colorfondo")
                            ePropiedad.InnerText = Convertir.ConvertToString(R.Cells(C).Appearance.BackColor)
                            eCelda.AppendChild(ePropiedad)

                            ePropiedad = Dom.CreateElement("colorletra")
                            ePropiedad.InnerText = Convertir.ConvertToString(R.Cells(C).Appearance.ForeColor)

                            eCelda.AppendChild(ePropiedad)
                            eColumna.AppendChild(eCelda)
                            ' R.Cells(C)
                        End If
                    Next

                    '  eColumna.AppendChild(eCelda)
                    Dom.DocumentElement.AppendChild(eColumna)
                End If
            Next
            If Nombre.Trim = "" Or Nombre Is DBNull.Value Then
                Nombre = Activo.Campaña & " " & Activo.Sistema & " " & Activo.Ejercicio
            End If

            Dom.Save(Ruta & Nombre & ".xml")

        Catch ex As Exception
            MsgBox("Cargar XML " & ex.Message)
        End Try
    End Sub

    Private Sub iugEjercicio_BeforeColPosChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeColPosChangedEventArgs) Handles iugEjercicio.BeforeColPosChanged
        If e.PosChanged = PosChanged.Moved Then
            If GrillAdmin.EsColumnaCalendario(e.ColumnHeaders(0).Column) _
                 Or e.ColumnHeaders(0).Column.Key = "Total Spots" _
                Or e.ColumnHeaders(0).Column.Key = "Total Neto" _
                Or e.ColumnHeaders(0).Column.Key = "Total Bruto" _
                Or e.ColumnHeaders(0).Column.Key = "Total Spots" _
                Or e.ColumnHeaders(0).Column.Key = "Total GRP Target 1" _
                Or e.ColumnHeaders(0).Column.Key = "Total GRP Target 2" _
                Or e.ColumnHeaders(0).Column.Key = "DUR" Then
                e.Cancel = True
                Exit Sub
            End If

            For Each i As Integer In arrColumnas
                If e.ColumnHeaders(0).VisiblePosition = i Then
                    e.Cancel = True
                    Exit Sub
                End If
            Next
        End If

    End Sub

    Private Sub BuscarDirectorio(ByVal Dir As String)
        Dim D As Directory

        Try
            D.GetDirectories(Dir)
            'D.CreateDirectory(Dir)
        Catch ex As System.IO.DirectoryNotFoundException
            D.CreateDirectory(Dir)
        End Try
    End Sub

    Private Function CargarSpotsTVS(ByVal dtTarifas As DataTable, ByVal dtAudiencia As DataTable, ByVal DtSpot As DataTable, ByVal idCampania As Int64, ByVal idSistema As Int64, ByVal idEjer As Int64, ByVal Target1 As Int64, ByVal Target2 As Int64) As DataTable
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow

        For j = 0 To dtTarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = DtSpot.NewRow
            Try

                k = k + 1
                Dr("ID_Spot") = Me.ObtenerProximoIdSpot(DtSpot) + k
                Dr("ID_Campania") = idCampania
                Dr("ID_Sistema") = idSistema
                Dr("ID_Ejercicio") = idEjer
                Dr("ID_Soporte") = dtTarifas.Rows(j)("ID_SOPORTE")
                Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                Dr("Programa") = dtTarifas.Rows(j)("Programa")
                Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                Dr("DCTO1") = 0
                Dr("DCTO2") = 0
                Dr("DCTO3") = 0
                Dr("DCTO4") = 0
                Dr("DCTO5") = 0
                Dr("Tipo_Planificacion") = 0

                '------------AGREGADO ESPECIALES---------
                If dtTarifas.Rows(j)("f_fin_vig") > Activo.FechaInicioSistema Then
                    If dtTarifas.Rows(j)("ind_especial") > 0 Then
                        AvisosEspeciales.Add(Dr("ID_Spot"))
                    End If
                End If
                '----------------------------------------

                'asigna los valores dependiendo los targets y tipo de planificacion

                Dr("RAT_PROG_TARGET_1") = -1
                Dr("RAT_PROG_TARGET_2") = -1
                Dr("RAT_TANDA_TARGET_1") = -1
                Dr("RAT_TANDA_TARGET_2") = -1
                DtSpot.Rows.Add(Dr)

            Catch e As Exception

            End Try

        Next
        SpotBase = DtSpot.Copy
        Return DtSpot
    End Function


    Private Sub Exportar()
        Dim scd As New SaveFileDialog
        Dim i As Integer, j As Integer
        Dim Archivo As String
        scd.CheckPathExists = True
        scd.OverwritePrompt = True
        'scd.DefaultExt = "*.xls"
        scd.Filter = "Microsoft Excel (*.xls)|*.xls"
        scd.ShowDialog()
        If scd.FileName.Trim = "" Then
            Exit Sub
        End If
        Archivo = scd.FileName
        'LC 20/08/2014 Crear Excel sin utilizar Microsoft.Office.Interop.Excel
        Try
            Dim libro As New XLWorkbook()
            Dim hoja As IXLWorksheet = libro.Worksheets.Add("Cpr")
            Dim rangoTitulos As IXLRange = hoja.Range("A7:M7")
            Dim formatoMoneda As String = "\$ 0.000"
            Dim formatoPorcentaje As String = "0.00%"

            hoja.Cell("A1").Value = "Campaña:"
            hoja.Cell("B1").Value = Activo.Campaña
            hoja.Cell("A2").Value = "Cliente:"
            hoja.Cell("B2").Value = Activo.Cliente
            hoja.Cell("A3").Value = "Periodo:"
            hoja.Cell("B3").Value = Activo.FechaInicioSistema & " a " & Activo.FechaFinSistema
            hoja.Cell("D1").Value = "Plaza:"
            hoja.Cell("E1").Value = Activo.Plaza
            hoja.Cell("D2").Value = "Target:"
            hoja.Cell("E2").Value = Activo.Target
            hoja.Cell("D3").Value = "Periodo Audiencia:"
            hoja.Cell("E3").Value = Activo.FechaInicioAudiencia & " a " & Activo.FechaFinAudiencia
            hoja.Cell("D4").Value = "Tipo De Rating"
            hoja.Cell("E4").Value = IIf(TipoDeRating = "T", "Tanda", "Programa")

            hoja.Cell("A7").Value = "Soportes"
            hoja.Cell("B7").Value = "Programas"
            hoja.Cell("C7").Value = "Bruto"
            hoja.Cell("D7").Value = "Bruto Actual"
            hoja.Cell("E7").Value = "D1"
            hoja.Cell("F7").Value = "D2"
            hoja.Cell("G7").Value = "D3"
            hoja.Cell("H7").Value = "D4"
            hoja.Cell("I7").Value = "D5"
            hoja.Cell("J7").Value = "Neto"
            hoja.Cell("K7").Value = "Afinidad"
            hoja.Cell("L7").Value = "Rating"
            hoja.Cell("M7").Value = "CPR"

            rangoTitulos.Style.Font.SetBold()
            rangoTitulos.Style.Fill.SetBackgroundColor(XLColor.PastelGreen)

            i = 7
            For Each Ur As UltraGridRow In iugEjercicio.Rows
                i += 1
                hoja.Cell("A" & i.ToString()).Value = Ur.Cells("Soporte").Value()
                hoja.Cell("B" & i.ToString()).Value = Ur.Cells("Programa").Value()
                hoja.Cell("C" & i.ToString()).Value = Ur.Cells("brutoactual").Value()
                hoja.Cell("D" & i.ToString()).Value = Ur.Cells("Bruto").Value()
                hoja.Cell("E" & i.ToString()).Value = Ur.Cells("DCTO1").Value() / 100
                hoja.Cell("F" & i.ToString()).Value = Ur.Cells("DCTO2").Value() / 100
                hoja.Cell("G" & i.ToString()).Value = Ur.Cells("DCTO3").Value() / 100
                hoja.Cell("H" & i.ToString()).Value = Ur.Cells("DCTO4").Value() / 100
                hoja.Cell("I" & i.ToString()).Value = Ur.Cells("DCTO5").Value() / 100
                hoja.Cell("J" & i.ToString()).Value = Ur.Cells("Neto").Value()
                hoja.Cell("K" & i.ToString()).Value = Ur.Cells("AFF_TANDA_TARGET_1").Value()
                hoja.Cell("L" & i.ToString()).Value = Ur.Cells("RAT_TANDA_TARGET_1").Value()
                hoja.Cell("M" & i.ToString()).Value = Ur.Cells("CPR").Value()
            Next

            Dim rangoBruto As IXLRange = hoja.Range("C8:C" & i.ToString())
            Dim rangoBrutoActual As IXLRange = hoja.Range("D8:D" & i.ToString())
            Dim rangoNeto As IXLRange = hoja.Range("J8:J" & i.ToString())
            Dim rangoCPR As IXLRange = hoja.Range("M8:M" & i.ToString())
            Dim rangoDCT1 As IXLRange = hoja.Range("E8:E" & i.ToString())
            Dim rangoDCT2 As IXLRange = hoja.Range("F8:F" & i.ToString())
            Dim rangoDCT3 As IXLRange = hoja.Range("G8:G" & i.ToString())
            Dim rangoDCT4 As IXLRange = hoja.Range("H8:H" & i.ToString())
            Dim rangoDCT5 As IXLRange = hoja.Range("I8:I" & i.ToString())
            rangoBruto.Style.NumberFormat.Format = formatoMoneda
            rangoBrutoActual.Style.NumberFormat.Format = formatoMoneda
            rangoNeto.Style.NumberFormat.Format = formatoMoneda
            rangoCPR.Style.NumberFormat.Format = formatoMoneda
            rangoDCT1.Style.NumberFormat.Format = formatoPorcentaje
            rangoDCT2.Style.NumberFormat.Format = formatoPorcentaje
            rangoDCT3.Style.NumberFormat.Format = formatoPorcentaje
            rangoDCT4.Style.NumberFormat.Format = formatoPorcentaje
            rangoDCT5.Style.NumberFormat.Format = formatoPorcentaje
            hoja.Columns().AdjustToContents()

            libro.SaveAs(Archivo)
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

        Mensajes.Mensaje("El Ranking de CPR Fue Exportado Sactisfactoriamente")
    End Sub

    Private Sub PosicionCalendario()
        Dim Posicion As Integer

        For Each c As UltraGridColumn In iugEjercicio.DisplayLayout.Bands(0).Columns
            If GrillAdmin.EsColumnaCalendario(c) Or c.Key.StartsWith("Total") Or c.Key.StartsWith("DUR") Then
                Posicion = c.Header.VisiblePosition
                arrColumnas.Add(Posicion)
            End If
        Next
    End Sub

    Structure DatoColumna
        Dim Titulo As String
        Dim Clave As String
    End Structure

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        iugEjercicio.DisplayLayout.Override.SummaryDisplayArea = SummaryDisplayAreas.TopFixed
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        iugEjercicio.DisplayLayout.Override.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
    End Sub

    Private Sub ColorSinAudiencia()
        Dim FilaActual As Integer
        Dim ColumnaActual As Integer

        If Not iugEjercicio.ActiveCell Is Nothing Then
            ColumnaActual = iugEjercicio.ActiveCell.Column.Index
            FilaActual = iugEjercicio.ActiveCell.Row.Index
        End If



        If iugEjercicio.Rows.Count > 0 Then
            ' iugEjercicio.Rows(1).Cells(1).Activated = True
            'Else
            iugEjercicio.Rows(0).Cells(0).Activated = True
        End If



        Dim i As Integer = 0
        For Each r As UltraGridRow In iugEjercicio.Rows
            If r.Cells("rat_prog_target_1").Value = -1 Then
                r.Cells("rat_prog_target_1").Value = 0
                r.Cells("rat_prog_target_2").Value = 0
                r.Cells("rat_tanda_target_1").Value = 0
                r.Cells("rat_tanda_target_2").Value = 0
                r.Cells("rat_prog_target_1").Appearance.ForeColor = Me.ColorRatingCero
                r.Cells("rat_prog_target_2").Appearance.ForeColor = Me.ColorRatingCero
                r.Cells("rat_tanda_target_1").Appearance.ForeColor = Me.ColorRatingCero
                r.Cells("rat_tanda_target_2").Appearance.ForeColor = Me.ColorRatingCero

            End If
            'If Activo.IDTipoSoporte <> 3 Then
            If AvisosEspeciales.Count > 0 Then
                MarcarProgramasEspeciales(r)
                MarcarDiasEspeciales(r)
            End If
            ' End If
        Next
        'DtAfectados

        If Not iugEjercicio.ActiveCell Is Nothing Then
            iugEjercicio.Rows(FilaActual).Cells(ColumnaActual).Activated = True
        End If
    End Sub
    Private Sub MarcarProgramasEspeciales(ByVal R As UltraGridRow)
        If AvisosEspeciales.IndexOf(R.Cells("id_spot").Value) >= 0 Then
            R.Cells("Programa").Appearance.ForeColor = ColorEspecial
        End If
    End Sub
    Private Sub MarcarDiasEspeciales(ByVal R As UltraGridRow)
        Dim id As Long = Val(R.Cells("id_spot").Value)
        Try
            If Not DtAfectados Is Nothing Then
                If DtAfectados.Select("ID_Spot=" & id).Length > 0 Then
                    Dim Dia As String = GrillAdmin.ObtenerDato(DtAfectados, "id_spot=" & id, "dia")
                    R.Cells(Dia).Appearance.BackColor = Me.ColorDiaEspecial
                    GrillaFormato.HabilitarCelda(R.Cells(Dia), Activation.NoEdit)
                End If
            End If
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message & vbCrLf & "Existen Tarifas cargadas como ESPECIALES, con MAS DE UN DIA de Vigencia", TipoMensaje.Informacion)
            Exit Sub
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub iugEjercicio_AfterRowFilterChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterRowFilterChangedEventArgs) Handles iugEjercicio.AfterRowFilterChanged
        tmrFiltro.Enabled = True

    End Sub
    Private Sub tmrFiltro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFiltro.Tick
        'AG 18/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
        'GrillaResumen.CalcularTotalesResumen(iugEjercicio, lblGRP, lblAvisos, lblSegundos, lblBruto, lblNeto, lblCPR, True)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        tmrFiltro.Enabled = False
    End Sub

    Private Sub iugEjercicio_BeforeEnterEditMode(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles iugEjercicio.BeforeEnterEditMode
        If iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If
        If iugEjercicio.ActiveCell.Band.Key <> "BandaSpot" Then
            Dim Tema As Char
            Try
                Tema = CType(iugEjercicio.ActiveCell.Row.ListObject, UltraDataRow).Tag.ToLower()
                If GrillAdmin.ObtenerSpotsComprados(iugEjercicio.ActiveCell.Row.ParentRow.Cells(iugEjercicio.ActiveCell.Column.Key), Tema).Length > 0 Then
                    e.Cancel = True
                End If
            Catch ex As Exception
            End Try
        End If
        Me.CantidadComprados = GrillAdmin.ObtenerSpotsComprados(iugEjercicio.ActiveCell).Length
    End Sub
    Private Sub ComprobarCompras()
        If EsCargaDeCero Then
            Exit Sub
        End If

        If dtComprados Is Nothing Then
            Exit Sub
        End If
        If iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If
        If Not GrillAdmin.EsColumnaCalendario(iugEjercicio.ActiveCell.Column) Then
            Exit Sub
        End If
        Try
            Dim CantOriginal As Integer
            Dim CantNuevo As Integer
            Dim CompraNueva As String = iugEjercicio.ActiveCell.Text
            Dim Compra As Integer = GrillAdmin.ObtenerSpotsComprados(iugEjercicio.ActiveCell).Length
            If Compra <> Me.CantidadComprados Then
                iugEjercicio.PerformAction(UndoCell, False, False)
                Exit Sub
            End If
            Dim filtro As String = "fila=" & iugEjercicio.ActiveCell.Row.Index & " and columna=" & "'" & iugEjercicio.ActiveCell.Column.Key & "'"

            For Each c As Char In CompraNueva

                If c.IsNumber(c) Then

                    CantOriginal = Valores.CastDBNull(GrillAdmin.ObtenerDato(dtComprados, filtro, "tema" & c))
                    CantNuevo = Algoritmos.ContarLetra(1, CompraNueva, c)
                    If CantNuevo < CantOriginal Then
                        iugEjercicio.PerformAction(UndoCell, False, False)
                        Exit Sub
                    End If
                End If

            Next
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub iugEjercicio_BeforeExitEditMode(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs) Handles iugEjercicio.BeforeExitEditMode
        If GrillAdmin.EsColumnaCalendario(iugEjercicio.ActiveCell.Column) Then
            ComprobarCompras()
        End If
    End Sub

    Private Function ComprobarActualizacion(ByVal Soportes As ArrayList) As Boolean
        Dim si As New Sistemas
        Dim t As New Tarifas_tv
        Dim ds As New DataSet
        si.Id_campania = Activo.IDCampaña
        si.Id_sistema = Activo.IDSistema
        si.BuscarPorID()
        For Each s As ItemLista In Soportes

            t.Id_soporte = s.ID
            t.Id_medio = Activo.IDMedio
            t.F_inicio_vig = si.F_inicio
            t.F_fin_vig = si.F_fin
            t.Id_cliente = Activo.IDCliente '363 

            t.ActualizarTarifas(ds, "Tarifas", Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
        Next

        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click

        Me.Cursor = Cursors.WaitCursor
        'VER  RATING REAL
        If Me.iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If

        Dim f As New frmDetalle

        f.IDSoporte = Me.iugEjercicio.ActiveCell.Row.Cells("id_soporte").Value

        Select Case TipoDeAudiencia
            Case TipoAudiencia.Abierta
                If IsDBNull(Me.iugEjercicio.ActiveCell.Row.Cells("id_programa").Value) Then
                    Exit Sub
                End If
                f.IDPrograma = Me.iugEjercicio.ActiveCell.Row.Cells("id_programa").Value
            Case TipoAudiencia.Cable, TipoAudiencia.Intetior
                If IsDBNull(Me.iugEjercicio.ActiveCell.Row.Cells("id_tarifa_tv").Value) Then
                    Exit Sub
                End If
                f.IDPrograma = Me.iugEjercicio.ActiveCell.Row.Cells("id_tarifa_tv").Value
        End Select
        Dim tipo As String

        If iugEjercicio.ActiveCell.Column.Key.IndexOf("RAT_TANDA") > -1 Then
            tipo = "T"
        Else
            tipo = "P"
        End If
        f.IDTarget1 = Target
        f.TipoRating = TipoDeRating
        f.MostrarRatingReal(TipoDeAudiencia, tipo)
        f.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BonificarAviso()
        If Me.iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If
        If Not GrillAdmin.EsColumnaCalendario(iugEjercicio.ActiveCell.Column) Then
            Exit Sub
        End If
        If iugEjercicio.ActiveCell.Text = "" Then
            Exit Sub
        End If
        If iugEjercicio.ActiveCell.Value Is DBNull.Value Then
            Exit Sub
        End If
        If iugEjercicio.ActiveRow.Cells("dcto1").Value = 100 Then
            Exit Sub
        End If
        If Me.ObternerSpotsSinCompras(iugEjercicio.ActiveCell).Length <> iugEjercicio.ActiveCell.Text.Length Then
            Exit Sub
        End If
        Dim Tema As String
        Dim F As New frmAviso
        F.CargarTemas(iugEjercicio.ActiveCell.Text)
        F.ShowDialog()
        Tema = F.Tema
        If F.Salir Then
            Exit Sub
        End If

        Dim NuevaFila As UltraDataRow
        Dim IndiceFila As Integer

        Dim Celda As UltraGridCell = iugEjercicio.ActiveCell

        Dim DrBonificado As DataRow() = BuscarFilaDuplicada(Celda)

        If Not DrBonificado Is Nothing Then
            If DrBonificado.Length > 0 Then
                For Each fila As UltraDataRow In Me.UltraDataSource1.Rows
                    If fila("Id_Spot") = DrBonificado(0)("Id_Spot") Then
                        IndiceFila = fila.Index
                        Exit For
                    End If
                Next
                Dim valor As String
                If UltraDataSource1.Rows(IndiceFila).GetCellValue(Celda.Column.Key) Is Nothing Or UltraDataSource1.Rows(IndiceFila).GetCellValue(Celda.Column.Key) Is DBNull.Value Then
                    Me.UltimoText = Algoritmos.BorrarCaracter(Tema, Celda.Text)
                    Celda.Value = Algoritmos.BorrarCaracter(Tema, Celda.Text)
                    UltraDataSource1.Rows(IndiceFila).SetCellValue(Celda.Column.Key, Tema)
                Else
                    valor = UltraDataSource1.Rows(IndiceFila).GetCellValue(Celda.Column.Key) & Tema
                    Me.UltimoText = valor
                    Celda.Value = Algoritmos.BorrarCaracter(Tema, Celda.Text)
                    UltraDataSource1.Rows(IndiceFila).SetCellValue(Celda.Column.Key, valor)
                End If
                EjecutarCompra(UltraDataSource1.Rows(IndiceFila))
            Else
                NuevaFila = DuplicarFila(False, True)
                NuevaFila("cpr") = 0
                For Each fila As UltraGridRow In iugEjercicio.Rows
                    If fila.Cells("Id_Spot").Text = NuevaFila("Id_Spot") Then
                        IndiceFila = fila.Index
                        Exit For
                    End If
                Next
                Me.UltimoText = Tema
                Celda.Value = Algoritmos.BorrarCaracter(Tema, Celda.Text)
                NuevaFila(Celda.Column.Key) = Tema
                EjecutarCompra(NuevaFila)
            End If
        Else
            NuevaFila = DuplicarFila(False, True)
            NuevaFila("cpr") = 0
            For Each fila As UltraGridRow In iugEjercicio.Rows
                If fila.Cells("Id_Spot").Text = NuevaFila("Id_Spot") Then
                    IndiceFila = fila.Index
                    Exit For
                End If
            Next
            Me.UltimoText = Tema
            Celda.Value = Algoritmos.BorrarCaracter(Tema, Celda.Text)
            NuevaFila(Celda.Column.Key) = Tema
            EjecutarCompra(NuevaFila)

        End If
    End Sub
    Private Function BuscarFilaDuplicada(ByVal C As UltraGridCell) As DataRow()
        Dim tarifa As Integer, drSpot As DataRow()
        Dim DtBonificados As DataTable, DrBonificado As DataRow()

        Dim FiltroDcto As String = "dcto1 =100 and dcto2 =0 and dcto3 =0 and dcto4 =0 and dcto5 =0 "
        FiltroDcto += "or dcto2 =100 and dcto1 =0 and dcto3 =0 and dcto4 =0 and dcto5 =0"
        FiltroDcto += "or dcto3 =100 and dcto1 =0 and dcto2 =0 and dcto4 =0 and dcto5 =0 "
        FiltroDcto += "or dcto4 =100 and dcto1 =0 and dcto2 =0 and dcto3 =0 and dcto5 =0 "
        FiltroDcto += "or dcto5 =100 and dcto1 =0 and dcto2 =0 and dcto3 =0 and dcto4 =0 "

        tarifa = C.Row.Cells("ID_Tarifa_tv").Text
        Dim id As Integer = C.Row.Cells("ID_spot").Value
        drSpot = SpotBase.Select("Id_Tarifa_tv=" & tarifa)
        If drSpot.Length > 1 Then
            DtBonificados = Listas.FiltrarDT(SpotBase, FiltroDcto)
            DrBonificado = DtBonificados.Select("ID_TARIFA_TV=" & tarifa)

            Return DrBonificado
        Else
            Return Nothing
        End If

    End Function
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Me.BonificarAviso()
    End Sub

    Private Sub fcubo_Actualizar(ByRef DtSpot As System.Data.DataTable, ByRef DtDetalle As System.Data.DataTable, ByRef dtFranja As System.Data.DataTable, ByRef dtSoporte As System.Data.DataTable) Handles fcubo.Actualizar
        'Dim Dt As DataTable
        DtSpot = SpotBase.Copy
        DtDetalle = DetalleBase.Copy
        dtFranja = Franjas.Copy

        If AuxSoportes.GetType Is GetType(ArrayList) Then
            dtSoporte = Algoritmos.ArrayDt(AuxSoportes, "id_soporte", "descripcion").Copy
        Else
            dtSoporte = DirectCast(AuxSoportes, DataTable).Copy
        End If





    End Sub

    Private Sub fcubo_Cerrando() Handles fcubo.Cerrando
        fcubo = Nothing
    End Sub


    Private Sub iugEjercicio_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugEjercicio.InitializeLayout

    End Sub


    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click

        Dim FrmAuspicio As New frmAuspicio
        Dim Fila As Integer
        Dim FilaHijo As UltraGridRow
        Dim DtTemasFila As DataTable

        If iugEjercicio.ActiveRow Is Nothing And iugEjercicio.ActiveCell Is Nothing Then
            Exit Sub
        End If

        If Me.iugEjercicio.ActiveRow.Cells("id_tarifa_tv").Value = 0 Then
            MsgBox("El Proceso de Auspicio, no puede aplicarse, si no existe una tarifa asignada a este programa", MsgBoxStyle.Information, "Everest ")
            Exit Sub
        End If

        FilaHijo = Me.iugEjercicio.ActiveRow
        Fila = Me.iugEjercicio.ActiveRow.Index
        DtTemasFila = ObtenerLetrasFila(FilaHijo)

        Me.mInstancia = Me
        With FrmAuspicio
            .ControlTipoAuspicio = 0
            .IdCampania = Activo.IDCampaña
            .IdSistema = Activo.IDSistema
            .IdTarifa = iugEjercicio.ActiveRow.Cells("id_tarifa_tv").Value
            .IdSoporte = iugEjercicio.ActiveRow.Cells("id_soporte").Value
            .IdMedio = Activo.IDMedio
            .IdCliente = Activo.IDCliente
            .DtTemasEjercicio = DtTemasFila
            frmEjercicio.Instancia.DtTemasUtilizados = dtTemas
            .DtTemasUtilizados = dtTemas
        End With
        FrmAuspicio.DtTemasEjercicio = DtTemasFila
        FrmAuspicio.ShowDialog()
        If FrmAuspicio.Cancelar = False Then
            CargarAupicios(Fila, FilaHijo)
        End If

    End Sub

    Private Function CargarAupicios(ByVal IndiceFila As Integer, ByVal Fila As UltraGridRow)

        Dim Idsoporte As Integer
        Dim IdTCalsificacion As Integer
        Dim IdProgramacion As Integer
        Dim IdClasificacion As String
        Dim Compra As String
        Dim Columna As String
        Dim Row As DataRow
        Dim Dr As DataRow
        Dim DrDatos As DataRow
        Dim IdSpot As Integer
        Dim ControlAuspicio As Boolean
        Dim Desglose As Boolean
        Dim ControlValorTema As String
        Dim CompraAnterior As String = ""

        If Me.DtAuspicio Is Nothing Then
            Exit Function
        Else

            With Me.iugEjercicio
                Idsoporte = .ActiveRow.Cells("ID_Soporte").Value
                IDSpotCompra = Me.iugEjercicio.ActiveRow.Cells("id_spot").Text
                SalidaAuspicio = True
                If MontoBrutoAuspicio > 0 Then
                    .Rows(IndiceFila).Cells("bruto").Value = MontoBrutoAuspicio
                    .Rows(IndiceFila).Cells("Total Bruto").Value = MontoBrutoAuspicio
                    .Rows(IndiceFila).Cells("Total Neto").Value = MontoBrutoAuspicio
                End If
            End With

            For Each DrDatos In DtAuspicio.Rows
                ControlAuspicio = True
                Columna = DrDatos("FEmision")
                Compra = DrDatos("Tema")
                With iugEjercicio
                    CompraAnterior = IIf(IsDBNull(.Rows(IndiceFila).Cells(Columna).Value), "", .Rows(IndiceFila).Cells(Columna).Value)
                    GrillAdmin.AgregarHijoAuspisio(Me.UltraDataSource1, DetalleBase, IndiceFila, Columna, Compra.ToUpper, ColumnasHijos, Me.dtTemas, IDSpotCompra)
                End With
                Me.CalcularGrillasResumen(CompraAnterior.ToUpper, Compra.ToUpper, Me.UltraDataSource1.Rows(IndiceFila), Columna)
            Next
            ControlAuspicio = False
        End If

        Me.iugEjercicio.EndUpdate()
        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Moneda, "Total Bruto", "Total Neto")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Decimales, "Total GRP Target 1")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.General, "Total Spots", "Dur")
        GrillaFormato.CambiarAlineacionColumna(iugEjercicio)
        Listas.OcultarHeader(iugEjercicio)
        GrillaFormato.ReocultarColumnasHijos(iugEjercicio)

        For Each b As UltraGridBand In iugEjercicio.DisplayLayout.Bands
            If b.Index > 0 Then
                GrillaFormato.FijarColumna(b.Columns("Tema"), True)
                GrillaFormato.FijarColumna(iugEjercicio.DisplayLayout.Bands(b.Index).Columns(b.Columns("tema").Index + 4), True)
                GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, b.Index, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")
            End If
        Next

        SalidaAuspicio = False

    End Function

    Private Function ObtenerLetrasFila(ByVal Fila As UltraGridRow) As DataTable

        Dim DtTemasFila As New DataTable
        Dim IdTema As String

        DtTemasFila = CrearDtTemas()

        If Not Fila Is Nothing Then
            If Not Fila.IsFilteredOut Then
                Try
                    For Each b As UltraGridChildBand In Fila.ChildBands
                        If Not b Is Nothing Then
                            For Each br As UltraGridRow In b.Rows
                                If Not br Is Nothing Then
                                    DtTemasFila = CargarDtTemasFila(IdTema, DtTemasFila)
                                End If
                            Next
                        End If
                    Next
                Catch ex As Exception
                End Try
            End If
        End If

        Return DtTemasFila

    End Function

    Private Function CrearDtTemas() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("Id_Tema", GetType(String))

        Return Dt

    End Function

    Private Function CargarDtTemasFila(ByVal Letra As String, ByVal Dt As DataTable) As DataTable

        row = Dt.NewRow
        row("Id_Tema") = Letra
        Dt.Rows.Add(row)

        Dt.AcceptChanges()

        Return Dt

    End Function

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
        Dim estadoCalculoAutomatico As Boolean = cbCalculoAutomatico.Checked
        If cbCalculoAutomatico.Checked Then
            cbCalculoAutomatico.Checked = False
        End If

        ' AGREGO AL MEDIO RADIO PARA USAR EN DISTRIBUIDOR DE PASES (AN 05-10-2015)
        If Activo.IDMedio <> 1 And Activo.IDMedio <> 6 Then
            MsgBox("El Proceso de Distribucion de Pases, solo se aplica para el Medio TELEVISION. ", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If

        ' LO COMENTO PARA QUE PUEDA SER USADO EN TODOS LOS TIPOS DE SOPORTE DE TV. (AN 02-10-2015)
        'If Activo.IDTipoSoporte <> 3 Then
        'MsgBox("El Proceso de Distribucion de Pases, solo se aplica para el tipo de soporte: TELEVISION CABLE. ", MsgBoxStyle.Information, "Everest")
        'Exit Sub
        'End If

        Dim frmDistribuidor As New frmDistribuidor
        Dim ObjTemas As New Temas
        Me.mInstancia = Me


        With frmDistribuidor
            .IdCampania = Activo.IDCampaña
            .FDesde = Activo.FechaInicioSistema
            .FHasta = Activo.FechaFinSistema
            .DtSoportesHoja = ObtenerSoportes()
            .DtTemasCampania = ObjTemas.ObtenerTemasCampañaDistribuidor(Activo.IDCampaña)
            ._AperturaFormulario = False
            frmEjercicio.Instancia._DtSoporteHoja = .DtSoportesHoja
            frmEjercicio.Instancia._DtTemasCampania = .DtTemasCampania
        End With

        frmDistribuidor.ShowDialog()

        If Me._DistribuidorCancelar = True Then
            Exit Sub
        End If

        '============= TRATAMIENTO DE REGISTROS y ORDENAMINETO ============================
        DtOrdenarSpotDistribuidorXRating = Me.SpotBase.Clone
        DtOrdenarSpotDistribuidorXCPR = Me.SpotBase.Clone
        Dim DtOrdenarSpotDistribuidorTemXCPR As DataTable = Me.SpotBase.Clone


        Dim DrSpotXFranja As DataRow()
        Dim DrSpotXCPR As DataRow()
        Dim DrSpot As DataRow()
        Dim DrSpotXSoporte As DataRow()
        Dim HoraDistribuidor As Integer


        'AG 28/05/2014 ====================================================
        Dim Fp As New frmProgresoCargaGrilla
        Application.DoEvents()
        Fp.Texto = "Analizando Celdas Destino a Aplicar."
        Fp.Max1 = 5
        Application.DoEvents()
        Fp.Show()
        Application.DoEvents()
        frmProgresoCargaGrilla.Instancia.Incrementar(1)
        '=====================================================================

        If Me._DistribuidorTipoFranja = TipoFranja.RATMASALTO Then

            '============================= Ordenno por Franja Mayor ========================
            DrSpotXFranja = Me.SpotBase.Select("", GrillAdmin.ColumnaRatingTarget1.ToString() & " DESC")
            If DrSpotXFranja.Length > 0 Then
                DtOrdenarSpotDistribuidorXRating.Columns.Add("HoraDistribuidor", GetType(Integer))
                DtOrdenarSpotDistribuidorXRating.Columns.Add("ControlCantAvisos", GetType(Integer))
                DtOrdenarSpotDistribuidorXRating.Columns.Add("ControlImporteAcumulado", GetType(Double))
                For i As Integer = 0 To DrSpotXFranja.Length - 1
                    DtOrdenarSpotDistribuidorXRating.ImportRow(DrSpotXFranja(i))
                    DtOrdenarSpotDistribuidorXRating(i)("HoraDistribuidor") = ObtenerCalculoHoraDistribuidor(DrSpotXFranja(i)(8).ToString, DrSpotXFranja(i)(9).ToString, DrSpotXFranja(i)(10).ToString, DrSpotXFranja(i)(11).ToString)
                    DtOrdenarSpotDistribuidorXRating(i)("ControlCantAvisos") = DtOrdenarSpotDistribuidorXRating(i)("HoraDistribuidor") * Me._DistribuidorValorAvisos
                Next
                DtOrdenarSpotDistribuidorXRating.AcceptChanges()
            End If

        ElseIf Me._DistribuidorTipoFranja = TipoFranja.CPRMASBAJO Then

            '============================= Ordenno por CPR Menor ========================
            DrSpot = Me.SpotBase.Select("", "ID_SPOT ASC")
            If DrSpot.Length > 0 Then
                DtOrdenarSpotDistribuidorTemXCPR.Columns.Add("HoraDistribuidor", GetType(Integer))
                DtOrdenarSpotDistribuidorTemXCPR.Columns.Add("ControlCantAvisos", GetType(Integer))
                DtOrdenarSpotDistribuidorTemXCPR.Columns.Add("ControlImporteAcumulado", GetType(Double))
                For i As Integer = 0 To DrSpot.Length - 1
                    DtOrdenarSpotDistribuidorTemXCPR.ImportRow(DrSpot(i))
                    DtOrdenarSpotDistribuidorTemXCPR(i)("HoraDistribuidor") = ObtenerCalculoHoraDistribuidor(DrSpot(i)(8).ToString, DrSpot(i)(9).ToString, DrSpot(i)(10).ToString, DrSpot(i)(11).ToString)
                    DtOrdenarSpotDistribuidorTemXCPR(i)("ControlCantAvisos") = DtOrdenarSpotDistribuidorTemXCPR(i)("HoraDistribuidor") * Me._DistribuidorValorAvisos
                Next
                DtOrdenarSpotDistribuidorTemXCPR.AcceptChanges()
            End If

            If DrSpot.Length > 0 Then
                Dim DrBusqueda As DataRow()
                DtOrdenarSpotDistribuidorTemXCPR.Columns.Add("CPRDistribuidor", GetType(Single))
                For f As Integer = 0 To iugEjercicio.Rows.Count - 1
                    DrBusqueda = DtOrdenarSpotDistribuidorTemXCPR.Select("ID_SPOT=" & Me.iugEjercicio.Rows(f).Cells("ID_SPOT").Value)
                    If DrBusqueda.Length > 0 Then
                        DrBusqueda(0)("CPRDistribuidor") = Me.iugEjercicio.Rows(f).Cells("CPR").Value
                    End If
                Next
                DtOrdenarSpotDistribuidorTemXCPR.AcceptChanges()
            End If

            DrSpotXCPR = DtOrdenarSpotDistribuidorTemXCPR.Select("", "CPRDistribuidor ASC")

            If DrSpotXCPR.Length > 0 Then
                DtOrdenarSpotDistribuidorXCPR = DtOrdenarSpotDistribuidorTemXCPR.Clone
                For r As Integer = 0 To DrSpotXCPR.Length - 1
                    DtOrdenarSpotDistribuidorXCPR.ImportRow(DrSpotXCPR(r))
                Next
                DtOrdenarSpotDistribuidorXCPR.AcceptChanges()
            End If
        End If

        '=============================== Orden por Soporte ============================
        If Me._DistribuidorTipoFranja = TipoFranja.RATMASALTO Then
            DrSpotXSoporte = DtOrdenarSpotDistribuidorXRating.Select("", "ID_SOPORTE ASC")
            If DrSpotXSoporte.Length > 0 Then
                DtOrdenarSpotDistribuidorXSoporte = DtOrdenarSpotDistribuidorXRating.Clone
                For i As Integer = 0 To DrSpotXSoporte.Length - 1
                    DtOrdenarSpotDistribuidorXSoporte.ImportRow(DrSpotXSoporte(i))
                Next
                DtOrdenarSpotDistribuidorXSoporte.AcceptChanges()
                DtOrdenarSpotDistribuidor = DtOrdenarSpotDistribuidorXSoporte.Copy
            End If
        ElseIf Me._DistribuidorTipoFranja = TipoFranja.CPRMASBAJO Then
            DrSpotXSoporte = DtOrdenarSpotDistribuidorXCPR.Select("", "ID_SOPORTE ASC")
            If DrSpotXSoporte.Length > 0 Then
                DtOrdenarSpotDistribuidorXSoporte = DtOrdenarSpotDistribuidorXCPR.Clone
                For i As Integer = 0 To DrSpotXSoporte.Length - 1
                    DtOrdenarSpotDistribuidorXSoporte.ImportRow(DrSpotXSoporte(i))
                Next
                DtOrdenarSpotDistribuidorXSoporte.AcceptChanges()
                DtOrdenarSpotDistribuidor = DtOrdenarSpotDistribuidorXSoporte.Copy
            End If
        End If
        '==============================================================================

        'AG 28/05/2014 ============================================
        frmProgresoCargaGrilla.Instancia.Incrementar(1)
        frmProgresoCargaGrilla.Instancia.Incrementar(1)
        frmProgresoCargaGrilla.Instancia.Close()
        '=========================================================

        Dim DrSpotsDistribuidor, DrParametrosDistribuidor As DataRow
        Dim ColumnaCompraDistribuidor As String
        Dim TemaCompraDistribuidor As String
        Dim IDSpotCompraDistribuidor As Integer
        Dim DiaAviso As Date
        Dim DiaAvisoProximo As Date = CDate("01/01/1000")
        Dim DiaAvisoAnterior As Date = Me._DistribuidorFDesde.ToShortDateString
        Dim ContadorAvisosPermitidos, ContadorAvisosComprados As Integer
        Dim DuracionTemaDistribuido As Integer
        Dim CompraAnterior As String
        Dim CompraNueva As String

        Dim SalidaForT As Boolean
        Dim SalidaForT_ControlImporte As Boolean
        Dim SalidaForT_ControlAvisos As Boolean
        Dim AcumuladorTotalControl As Double

        If Not DtOrdenarSpotDistribuidor Is Nothing Then

            Dim DtDetalleNuevo As New DataTable

            'AG Creo el DT DEtalle Nuevo =====================================
            DtDetalleNuevo.Columns.Add("ID_SPOT", GetType(Integer))
            DtDetalleNuevo.Columns.Add("F_SPOT", GetType(String))
            DtDetalleNuevo.Columns.Add("TEMA_NUEVO", GetType(String))
            '=================================================================

            If TipoObjetivo.INVERSION = _DistribuidorTipoObjetivo Then

                'AG 28/05/2014 Barra ==================================
                Dim F As New frmProgresoCargaGrilla
                Application.DoEvents()
                F.Texto = "Cargando Distribucion de Temas "
                F.Max1 = 5
                Application.DoEvents()
                F.Show()
                Application.DoEvents()
                frmProgresoCargaGrilla.Instancia.Incrementar(1)
                frmProgresoCargaGrilla.Instancia.Incrementar(1)
                '=====================================================================

                Dim DtFechas As DataTable = CrearDtAvisosReemplazo()
                Dim DtIdSpot As DataTable = DtOrdenarSpotDistribuidor.DefaultView.ToTable(True, "ID_SPOT")
                Dim FilaNuevaAviso As DataRow
                Dim DtTemas As DataTable = _DistribuidorConjunto.DefaultView.ToTable(True, "ID_TEMA", "DURACION")

                For Each DrIdSpot As DataRow In DtOrdenarSpotDistribuidor.Rows
                    Dim AcumuladorImporteXCelda As Double = 0
                    Dim ContadorAvisosPermitidoXCelda As Integer
                    Dim ContadorTotalInteraciones As Integer
                    Dim ImportePermitidoXTema, AcumuladorImporteComprado, CalculoImporte, ImporteNetoFila, RatingHoja As Double
                    Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(DrIdSpot("id_spot"))
                    Dim IndiceForAvisos As Integer
                    Dim DuracionTema As Integer
                    Dim Calculo As Double
                    Dim Salir As Boolean = False
                    ImporteNetoFila = 0
                    IDSpotCompraDistribuidor = DrIdSpot("id_spot")
                    ContadorAvisosPermitidos = DrIdSpot("ControlCantAvisos")  'Cantidad Avisos prmitido por dias o Celda
                    ImporteNetoFila = DrIdSpot("NETO")

                    RatingHoja = iugEjercicio.Rows(Fila.Index).Cells(GrillAdmin.ColumnaRatingTarget1.ToString()).Value
                    ContadorTotalInteraciones = ContadorAvisosPermitidos * DtFechas.Compute("Count(ID_SPOT)", "ID_SPOT=" & DrIdSpot("id_spot"))

                    If ContadorTotalInteraciones > 0 Then
                        For Each DrTema As DataRow In DtTemas.Rows
                            DuracionTema = DrTema("DURACION")
                            For Each DrSpotsoporte As DataRow In Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")
                                AcumuladorImporteXCelda = 0
                                Dim ImporteTotalPermitidoXSoporteTema As Double = DrSpotsoporte("IMPORTE")
                                For IndiceForAvisos = 0 To ContadorTotalInteraciones - 1
                                    For Each DrAviso As DataRow In DtFechas.Select("id_spot=" & DrIdSpot("id_spot") & "AND FIN =0")
                                        If AcumuladorImporteXCelda <= ImporteTotalPermitidoXSoporteTema Then
                                            If _DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("IMPORTE_CONTROL") <= ImporteTotalPermitidoXSoporteTema Then
                                                If DtDetalleNuevo.Select("F_SPOT = '" & CDate(DrAviso("F_AVISO")).ToShortDateString & "' AND ID_SPOT= " & DrIdSpot("ID_SPOT")).Length <= ContadorAvisosPermitidos Then
                                                    FilaNuevaAviso = DtDetalleNuevo.NewRow
                                                    FilaNuevaAviso("F_SPOT") = CDate(DrAviso("F_AVISO")).ToShortDateString
                                                    FilaNuevaAviso("TEMA_NUEVO") = DrTema("ID_TEMA")
                                                    FilaNuevaAviso("ID_SPOT") = IDSpotCompraDistribuidor
                                                    DtDetalleNuevo.Rows.Add(FilaNuevaAviso)
                                                    DtDetalleNuevo.AcceptChanges()
                                                    ContadorAvisosPermitidoXCelda += 1
                                                    Calculo = ImporteNetoFila * DuracionTema
                                                    AcumuladorImporteXCelda += Calculo
                                                    Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("IMPORTE_CONTROL") += Calculo
                                                    If DtDetalleNuevo.Select("F_SPOT = '" & CDate(DrAviso("F_AVISO")).ToShortDateString & "' AND ID_SPOT= " & DrIdSpot("ID_SPOT")).Length > ContadorAvisosPermitidos Then
                                                        DtDetalleNuevo.Rows.Remove(FilaNuevaAviso)
                                                        DtFechas.Select("F_AVISO = '" & CDate(DrAviso("F_AVISO")).ToShortDateString & "' AND ID_SPOT= " & DrIdSpot("ID_SPOT"))(0)("FIN") = 1 'Fin Carga
                                                        DtDetalleNuevo.AcceptChanges()
                                                        ContadorAvisosPermitidoXCelda -= 1
                                                        AcumuladorImporteXCelda = AcumuladorImporteXCelda - Calculo
                                                        Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("IMPORTE_CONTROL") = Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("IMPORTE_CONTROL") - Calculo
                                                    End If
                                                End If
                                            Else
                                                Salir = True
                                                Exit For
                                            End If
                                        Else
                                            Salir = True
                                            Exit For
                                        End If
                                    Next
                                    If Salir = True Then
                                        Salir = False
                                        Exit For
                                    End If
                                Next
                                AcumuladorImporteXCelda = 0
                            Next
                        Next
                    End If
                Next

                'AG 28/05/2014 =================================================================
                frmProgresoCargaGrilla.Instancia.Incrementar(1)
                frmProgresoCargaGrilla.Instancia.Close()
                '===============================================================================

            ElseIf TipoObjetivo.GRPS = _DistribuidorTipoObjetivo Then

                Dim DtFechas As DataTable = CrearDtAvisosReemplazo()
                Dim DtIdSpot As DataTable = DtOrdenarSpotDistribuidor.DefaultView.ToTable(True, "ID_SPOT")
                Dim FilaNuevaAviso As DataRow
                Dim DtTemas As DataTable = _DistribuidorConjunto.DefaultView.ToTable(True, "ID_TEMA", "DURACION")

                'AG 28/05/2014 Barra ==================================
                Dim Fs As New frmProgresoCargaGrilla
                Application.DoEvents()
                Fs.Texto = "Cargando Distribucion de Temas "
                Fs.Max1 = 5
                Application.DoEvents()
                Fs.Show()
                Application.DoEvents()
                frmProgresoCargaGrilla.Instancia.Incrementar(1)
                frmProgresoCargaGrilla.Instancia.Incrementar(1)
                '=====================================================================

                For Each DrIdSpot As DataRow In DtOrdenarSpotDistribuidor.Rows

                    Dim AcumuladorImporteXCelda As Double = 0
                    Dim ContadorAvisosPermitidoXCelda As Integer
                    Dim ContadorTotalInteraciones As Integer
                    Dim ImportePermitidoXTema, AcumuladorRatingXCelda, RatingHoja As Double
                    Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(DrIdSpot("id_spot"))
                    Dim IndiceForAvisos As Integer
                    Dim Salir As Boolean = False
                    IDSpotCompraDistribuidor = DrIdSpot("id_spot")
                    ContadorAvisosPermitidos = DrIdSpot("ControlCantAvisos")  'Cantidad Avisos prmitido por dias o Celda
                    RatingHoja = iugEjercicio.Rows(Fila.Index).Cells(GrillAdmin.ColumnaRatingTarget1.ToString()).Value
                    ContadorTotalInteraciones = ContadorAvisosPermitidos * DtFechas.Compute("Count(ID_SPOT)", "ID_SPOT=" & DrIdSpot("id_spot"))

                    If ContadorTotalInteraciones > 0 Then
                        For Each DrTema As DataRow In DtTemas.Rows
                            For Each DrSpotsoporte As DataRow In Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")
                                AcumuladorRatingXCelda = 0
                                Dim GrpsTotalPermitidoXSoporteTema As Double = DrSpotsoporte("GRPS")
                                For IndiceForAvisos = 0 To ContadorTotalInteraciones - 1
                                    For Each DrAviso As DataRow In DtFechas.Select("id_spot=" & DrIdSpot("id_spot") & "AND FIN =0")
                                        If AcumuladorRatingXCelda <= GrpsTotalPermitidoXSoporteTema Then
                                            If _DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("GRPS_CONTROL") <= GrpsTotalPermitidoXSoporteTema Then
                                                If DtDetalleNuevo.Select("F_SPOT = '" & CDate(DrAviso("F_AVISO")).ToShortDateString & "' AND ID_SPOT= " & DrIdSpot("ID_SPOT")).Length <= ContadorAvisosPermitidos Then
                                                    FilaNuevaAviso = DtDetalleNuevo.NewRow
                                                    FilaNuevaAviso("F_SPOT") = CDate(DrAviso("F_AVISO")).ToShortDateString
                                                    FilaNuevaAviso("TEMA_NUEVO") = DrTema("ID_TEMA")
                                                    FilaNuevaAviso("ID_SPOT") = IDSpotCompraDistribuidor
                                                    DtDetalleNuevo.Rows.Add(FilaNuevaAviso)
                                                    DtDetalleNuevo.AcceptChanges()
                                                    AcumuladorRatingXCelda += RatingHoja
                                                    Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("GRPS_CONTROL") += RatingHoja
                                                    If DtDetalleNuevo.Select("F_SPOT = '" & CDate(DrAviso("F_AVISO")).ToShortDateString & "' AND ID_SPOT= " & DrIdSpot("ID_SPOT")).Length > ContadorAvisosPermitidos Then
                                                        DtDetalleNuevo.Rows.Remove(FilaNuevaAviso)
                                                        DtFechas.Select("F_AVISO = '" & CDate(DrAviso("F_AVISO")).ToShortDateString & "' AND ID_SPOT= " & DrIdSpot("ID_SPOT"))(0)("FIN") = 1 'Fin Carga
                                                        DtDetalleNuevo.AcceptChanges()
                                                        AcumuladorImporteXCelda = AcumuladorImporteXCelda - RatingHoja
                                                        Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("GRPS_CONTROL") = Me._DistribuidorConjunto.Select("ID_SOPORTE=" & DrIdSpot("id_soporte") & "AND ID_TEMA='" & DrTema("ID_TEMA") & "'")(0)("GRPS_CONTROL") - RatingHoja
                                                    End If
                                                End If
                                            Else
                                                Salir = True
                                                Exit For
                                            End If
                                        Else
                                            Salir = True
                                            Exit For
                                        End If
                                    Next
                                    If Salir = True Then
                                        Salir = False
                                        Exit For
                                    End If
                                Next
                                AcumuladorRatingXCelda = 0
                            Next
                        Next
                    End If
                Next

            End If


            'AG 28/05/2014 =================================================================
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            frmProgresoCargaGrilla.Instancia.Close()

            Dim Ft As New frmProgresoCargaGrilla
            Application.DoEvents()
            Ft.Texto = "Aplicando Distribucion de Temas "
            Ft.Max1 = 5
            Application.DoEvents()
            Ft.Show()
            Application.DoEvents()
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            '=====================================================================

            For Each RowAvisosEliminar As DataRow In DtDetalleNuevo.Rows

                Dim FechaAviso As Date
                Dim CeldaCompra As UltraGridCell
                Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(RowAvisosEliminar("id_spot"))
                Dim FilaTemasSpot As DataRow
                Dim TemasEliminar As String = ""
                Dim ColumnaCompraReemplazo As String

                FechaAviso = CDate(RowAvisosEliminar("F_SPOT")).ToShortDateString()
                ColumnaCompraReemplazo = FechaAviso.ToShortDateString
                CeldaCompra = Me.iugEjercicio.Rows(Fila.Index).Cells(FechaAviso)

                If CeldaCompra.Appearance.BackColor.Equals(ColorVigenciaNula) Then
                    Me.iugEjercicio.PerformAction(UndoCell, False, False)
                Else
                    If GrillAdmin.EsColumnaCalendario(CeldaCompra) Then
                        Dim NombreBanda As String
                        Dim letra As String
                        Dim CompraFinal As String
                        Dim ComptraAnterior As String
                        Dim TemasCeldas As String = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value.ToString()
                        If IsDBNull(iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value) Then
                            CompraFinal = ""
                        Else
                            CompraFinal = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                        End If
                        Dim Caracteres As Array = CompraFinal.ToArray()
                        Array.Sort(Caracteres)
                        CompraFinal = New String(Caracteres)
                        TemasCeldas = CompraFinal
                        For i As Integer = 0 To TemasCeldas.Length - 1
                            letra = TemasCeldas.Substring(i, 1)
                            ComptraAnterior = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                            ' ESTE IF LO HICE YO (AN)
                            If CompraFinal.Length >= (TemasCeldas.IndexOf(letra) + 1) Then
                                CompraFinal = CompraFinal.Substring(TemasCeldas.IndexOf(letra) + 1)
                            End If

                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = True
                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value = CompraFinal
                            Me.CalcularGrillasResumen(ComptraAnterior.ToUpper, CompraFinal.ToUpper, Me.UltraDataSource1.Rows(Fila.Index), ColumnaCompraReemplazo)
                            Me.UltraDataSource1.Rows(Fila.Index).SetCellValue(ColumnaCompraReemplazo, CompraFinal)
                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = False
                            Me.HayCambios = True
                        Next i
                        Me.iugEjercicio.EndUpdate()
                        iugEjercicio.PerformAction(ExitEditMode, False, False)
                    End If
                End If
            Next

            'AG 28/05/2014 ==================================
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            '================================================

            For Each RowAvisosNuevos As DataRow In DtDetalleNuevo.Rows
                Dim FechaAviso As Date
                Dim CeldaCompra As UltraGridCell
                Dim NombreBanda As String
                Dim CompraFinal As String
                Dim ComptraAnterior As String
                Dim ColumnaCompraReemplazo As String

                Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(RowAvisosNuevos("ID_SPOT"))
                FechaAviso = CDate(RowAvisosNuevos("F_SPOT")).ToShortDateString()
                ColumnaCompraReemplazo = FechaAviso.ToShortDateString

                If IsDBNull(iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value) Then
                    ComptraAnterior = ""
                    CompraFinal = ""
                Else
                    ComptraAnterior = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                    CompraFinal = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                End If
                CompraFinal += RowAvisosNuevos("TEMA_NUEVO").ToString
                iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = True
                iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value = CompraFinal
                Me.CalcularGrillasResumen(ComptraAnterior.ToUpper, CompraFinal.ToUpper, Me.UltraDataSource1.Rows(Fila.Index), ColumnaCompraReemplazo)
                Me.UltraDataSource1.Rows(Fila.Index).SetCellValue(ColumnaCompraReemplazo, CompraFinal)
                iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = False
                Me.HayCambios = True
            Next
            Me.iugEjercicio.EndUpdate()

            'AG 28/05/2014 =====================================
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            frmProgresoCargaGrilla.Instancia.Close()
            '===================================================
        End If


        Dim ResultadoCalculoFinal As Double
        Dim ResultadoCalculoFinalStr As String

        'If TipoObjetivo.INVERSION = _DistribuidorTipoObjetivo Then
        '    If AcumuladorTotalControl < DistribuidorValorObjetivo Then
        '        ResultadoCalculoFinal = Math.Abs(Math.Round((DistribuidorValorObjetivo - AcumuladorTotalControl), 2))
        '        ResultadoCalculoFinalStr = ResultadoCalculoFinal.ToString("#,#.00")
        '        MsgBox("No se cumplio con el Objetivo de INVERSION. " & vbCrLf & vbCrLf & "Inversion Ingresada: " & Me.DistribuidorValorObjetivo.ToString("#,#.00") & " " & vbCrLf & "Inversion lograda : " & AcumuladorTotalControl.ToString("#,#.00") & vbCrLf & "Diferencia de Inversion : " & ResultadoCalculoFinalStr & " ")
        '    ElseIf AcumuladorTotalControl > Me.DistribuidorValorObjetivo Then
        '        ResultadoCalculoFinal = Math.Abs(Math.Round((AcumuladorTotalControl - DistribuidorValorObjetivo), 2))
        '        ResultadoCalculoFinalStr = ResultadoCalculoFinal.ToString("#,#.00")
        '        MsgBox("Se supero el Objetivo de INVERSION.  " & vbCrLf & vbCrLf & "Inversion Ingresada: " & Me.DistribuidorValorObjetivo.ToString("#,#.00") & " " & vbCrLf & "Inversion lograda : " & AcumuladorTotalControl.ToString("#,#.00") & vbCrLf & "Diferencia de Inversion : " & ResultadoCalculoFinalStr & " ")
        '    ElseIf AcumuladorTotalControl = Me.DistribuidorValorObjetivo Then
        '        MsgBox("Se alcanzo con el Objetivo de INVERSION. " & vbCrLf & vbCrLf & "Inversion Ingresada: " & Me.DistribuidorValorObjetivo.ToString("#,#.00") & " " & vbCrLf & "Inversion lograda : " & AcumuladorTotalControl.ToString("#,#.00") & ".  ")
        '    End If
        'ElseIf TipoObjetivo.GRPS = _DistribuidorTipoObjetivo Then
        '    If AcumuladorTotalControl < Me.DistribuidorValorObjetivo Then
        '        ResultadoCalculoFinal = Math.Abs(Math.Round((DistribuidorValorObjetivo - AcumuladorTotalControl), 2))
        '        ResultadoCalculoFinalStr = ResultadoCalculoFinal.ToString("#,#.00")
        '        MsgBox("No se cumplio con el Objetivo de GRPS. " & vbCrLf & vbCrLf & "Tipo Objetivo GRPs : " & Me.DistribuidorValorObjetivo.ToString("#,#.00") & " " & vbCrLf & "GRPs logrados : " & AcumuladorTotalControl.ToString("#,#.00") & vbCrLf & "Diferencia de Grps : " & ResultadoCalculoFinalStr & " ")
        '    ElseIf AcumuladorTotalControl > Me.DistribuidorValorObjetivo Then
        '        ResultadoCalculoFinal = Math.Abs(Math.Round((AcumuladorTotalControl - DistribuidorValorObjetivo), 2))
        '        ResultadoCalculoFinalStr = ResultadoCalculoFinal.ToString("#,#.00")
        '        MsgBox("Se supero el Objetivo de GRPS. " & vbCrLf & vbCrLf & "Tipo Objetivo GRPs : " & Me.DistribuidorValorObjetivo.ToString("#,#.00") & " " & vbCrLf & "GRPs logrados : " & AcumuladorTotalControl.ToString("#,#.00") & vbCrLf & "Diferencia de Grps : " & ResultadoCalculoFinalStr & " ")
        '    ElseIf AcumuladorTotalControl = Me.DistribuidorValorObjetivo Then
        '        MsgBox("Se alcanzo con el Objetivo de GRPS. " & vbCrLf & vbCrLf & "Tipo Objetivo GRPs : " & Me.DistribuidorValorObjetivo.ToString("#,#.00") & " " & vbCrLf & "GRPs logrados : " & AcumuladorTotalControl.ToString("#,#.00") & ".  ")
        '    End If
        'End If
        AcumuladorTotalControl = 0


        Me.iugEjercicio.EndUpdate()
        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Moneda, "Total Bruto", "Total Neto")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Decimales, "Total GRP Target 1")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.General, "Total Spots", "Dur")
        GrillaFormato.CambiarAlineacionColumna(iugEjercicio)
        Listas.OcultarHeader(iugEjercicio)
        GrillaFormato.ReocultarColumnasHijos(iugEjercicio)

        For Each b As UltraGridBand In iugEjercicio.DisplayLayout.Bands
            If b.Index > 0 Then
                GrillaFormato.FijarColumna(b.Columns("Tema"), True)
                GrillaFormato.FijarColumna(iugEjercicio.DisplayLayout.Bands(b.Index).Columns(b.Columns("tema").Index + 4), True)
                GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, b.Index, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")
            End If
        Next

        'AG Hoja Numero =========================
        If Activo.IDMedio = MedioTv Then
            GrillaFormato.HabilitarEdicionColumnaHijo(iugEjercicio, Activation.NoEdit, Activation.AllowEdit)
        End If
        '========================================

        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
        cbCalculoAutomatico.Checked = estadoCalculoAutomatico
        If cbCalculoAutomatico.Checked Then
            'LC 01/07/2014 Calculo de totales luego de efectuar el distribuidor de pases o remplazar temas
            GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
        End If
    End Sub

    Private Function CrearDtAvisosReemplazo()

        Dim DtAvisosFechasPermitidas As New DataTable
        Dim DtAvisos As New DataTable
        Dim DtIdSpot As DataTable
        Dim ResultadoDiferencia_Fecha As Integer
        Dim Fila As DataRow
        Dim i As Integer
        Dim DiaAviso As Date
        Dim ImporteNetoFila As Double
        Dim IDSpotCompraDistribuidor As Integer
        Dim ContadorAvisosPermitidos As Integer
        Dim RatingHoja As Double
        Dim TemaCompraDistribuidor As String
        Dim ImportePermitidoXTema As Double
        Dim DuracionTemaDistribuido As Integer
        Dim o As Integer
        Dim CantidadVueltas As Integer
        Dim IndiceDtAvisos As Integer
        Dim DiaAvisoProximo As Date
        Dim DiaAvisoAnterior As Date


        With DtAvisosFechasPermitidas
            .Columns.Add("ID_SPOT", GetType(Integer))
            .Columns.Add("F_AVISO", GetType(String))
            .Columns.Add("FIN", GetType(Integer))
        End With



        ResultadoDiferencia_Fecha = (Me._DistribuidorFHasta - Me._DistribuidorFDesde).TotalDays + 1

        For Each DrSpotsDistribuidor As DataRow In DtOrdenarSpotDistribuidor.Rows
            Dim Filas As UltraDataRow = Me.ObtenerUltraDataRow(DrSpotsDistribuidor("id_spot"))
            IDSpotCompraDistribuidor = DrSpotsDistribuidor("id_spot")
            DiaAvisoProximo = CDate("01/01/1000")

            For e As Integer = 0 To ResultadoDiferencia_Fecha - 1
                Dim CeldaCompra As UltraGridCell

                If DiaAvisoProximo = CDate("01/01/1000") Then
                    DiaAviso = Me._DistribuidorFDesde.ToShortDateString
                    DiaAvisoProximo = Me._DistribuidorFDesde.ToShortDateString
                Else
                    DiaAviso = DiaAviso.AddDays(1).ToShortDateString
                    DiaAvisoProximo = DiaAviso.ToShortDateString
                End If

                If DiaAviso <= Me._DistribuidorFHasta Then
                    CeldaCompra = Me.iugEjercicio.Rows(Filas.Index).Cells(DiaAviso.ToShortDateString)

                    If CeldaCompra.Appearance.BackColor.Equals(ColorVigenciaNula) Then
                        Me.iugEjercicio.PerformAction(UndoCell, False, False)
                    Else

                        If Not GrillAdmin.EsDiaPrograma(CeldaCompra) Then
                        Else
                            Fila = DtAvisosFechasPermitidas.NewRow
                            Fila("F_AVISO") = DiaAviso.ToShortDateString
                            Fila("ID_SPOT") = IDSpotCompraDistribuidor
                            Fila("FIN") = 0 'Permite Agregar Avisos
                            DtAvisosFechasPermitidas.Rows.Add(Fila)
                            DtAvisosFechasPermitidas.AcceptChanges()
                        End If
                    End If
                Else
                    DiaAviso = Me._DistribuidorFDesde.ToShortDateString

                    CeldaCompra = Me.iugEjercicio.Rows(Filas.Index).Cells(DiaAviso.ToShortDateString)

                    If CeldaCompra.Appearance.BackColor.Equals(ColorVigenciaNula) Then
                        Me.iugEjercicio.PerformAction(UndoCell, False, False)
                    Else
                        If Not GrillAdmin.EsDiaPrograma(CeldaCompra) Then
                        Else
                            Fila = DtAvisosFechasPermitidas.NewRow
                            Fila("F_AVISO") = DiaAviso.ToShortDateString
                            Fila("ID_SPOT") = IDSpotCompraDistribuidor
                            Fila("FIN") = 0 'Permite Agregar Avisos
                            DtAvisosFechasPermitidas.Rows.Add(Fila)
                            DtAvisosFechasPermitidas.AcceptChanges()
                        End If
                    End If
                End If
            Next
        Next

        Return DtAvisosFechasPermitidas


    End Function

    Private Function ObtenerSoportes() As DataTable

        Dim DtSoportes As New DataTable
        Dim DrRow As DataRow
        Dim IdSoporte As Integer = -1
        Dim DtSoporteFinal As New DataTable


        With DtSoportes
            .TableName = "SoportesGrilla"
            .Columns.Add("ID_SOPORTE", GetType(Integer))
            .Columns.Add("DESCRIPCION", GetType(String))
            .Columns.Add("PORCENTAJE", GetType(Double))
            .Columns.Add("VALOR", GetType(Double))
            .AcceptChanges()
        End With

        For Each DrGrilla As UltraGridRow In Me.iugEjercicio.Rows
            If IdSoporte <> DrGrilla.Cells("ID_SOPORTE").Value Then
                IdSoporte = DrGrilla.Cells("ID_SOPORTE").Value
                DrRow = DtSoportes.NewRow()
                DrRow("ID_SOPORTE") = IdSoporte
                DrRow("DESCRIPCION") = DrGrilla.Cells("Soporte").Value
                DtSoportes.Rows.Add(DrRow)
            End If
        Next

        DtSoporteFinal = DtSoportes.DefaultView.ToTable(True, "ID_SOPORTE", "DESCRIPCION", "PORCENTAJE", "VALOR")

        Return DtSoporteFinal

    End Function

    Private Function ObtenerCalculoHoraDistribuidor(ByVal HoraInico As String, ByVal MinutoInicio As String, ByVal HoraFin As String, ByVal MinutoFin As String) As Integer

        Dim HoraInicio, HoraFinal As Integer
        Dim DiferenciaHorario As Double
        Dim ResultadoEntero As Integer
        Dim HoraFinNueva As Integer
        Dim HoraFinNuevaStr As String
        Dim MinutoFinAnterior As String


        If MinutoInicio = "0" Then
            MinutoInicio = "00"
        End If

        If MinutoFin = "0" Then
            MinutoFin = "00"
        End If

        MinutoFinAnterior = MinutoFin

        If MinutoFin = "59" Then
            HoraFinNueva = CStr(CInt(HoraFin) + 1)
            HoraFinNuevaStr = CStr(HoraFinNueva)
            MinutoFinAnterior = MinutoFin
            MinutoFin = "00"
        End If

        HoraInicio = CInt(HoraInico + MinutoInicio)

        If MinutoFinAnterior = "59" Then
            HoraFinal = CInt(HoraFinNuevaStr + MinutoFin)
        Else
            HoraFinal = CInt(HoraFin + MinutoFin)
        End If


        DiferenciaHorario = HoraFinal - HoraInicio

        If DiferenciaHorario > 0 Then
            DiferenciaHorario = DiferenciaHorario / 100
            ResultadoEntero = Math.Truncate(DiferenciaHorario)
        End If


        Return ResultadoEntero

    End Function

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
        Dim estadoCalculoAutomatico As Boolean = cbCalculoAutomatico.Checked
        If cbCalculoAutomatico.Checked Then
            cbCalculoAutomatico.Checked = False
        End If


        Dim frmReemplazar As New frmReemplazarTemas
        Dim ObjTemas As New Temas
        Dim DtClonSpotBase As New DataTable
        Dim DtClonSpot As New DataTable
        Dim DtClonSpotDetalle As New DataTable
        Dim DtSpotBaseLimpio As DataTable
        Dim DtSpotDetalleLimpio As DataTable
        Me.mInstancia = Me
        Dim DtDistinto As DataTable
        Dim ColumnaCompraReemplazo As String
        Dim CompraAnterior As String
        Dim CompraNueva As String
        Dim TemaCompraReemplazo As String


        'AG Clono los DataTable ====================
        DtClonSpotBase = SpotBase.Clone
        DtClonSpot = SpotBase.Clone
        DtClonSpotDetalle = DetalleBase.Clone
        'AG Copio Contenido a los DataTable ====================
        DtClonSpotBase = SpotBase.Copy
        DtClonSpotDetalle = DetalleBase.Copy
        'AG Tratamiento de Registros en los DataTable ====================
        DtSpotDetalleLimpio = ObtenerSpotDetalleUtilizables(DtClonSpotDetalle)
        DtSpotBaseLimpio = ObtenerSpotUtilizables(DtClonSpot, DtClonSpotBase, DtSpotDetalleLimpio)


        With frmReemplazar
            .FDesde = Activo.FechaInicioSistema
            .FHasta = Activo.FechaFinSistema
            .DtTemasHoja = ObtenerTemasHojas()
            If Activo.IDMedio = 6 Then
                .DtTemasCampania = ObtenerTemasCampaniaRadio(dtTemas)
            ElseIf Activo.IDMedio = 1 Then
                .DtTemasCampania = BlanquearCampoSel(AgregarColumnasTemasCampania(ObjTemas.ObtenerTemasCampañaDistribuidor(Activo.IDCampaña)))
            End If
            .AperturaFormulario = False
            .DtSpot = DtSpotBaseLimpio
            .DtSpotDetalle = DtSpotDetalleLimpio
            .CantAvisosComprados = CInt(lblAvisos.Text)
            .InversionTotalCompradas = lblNeto.Text
        End With

        frmReemplazar.ShowDialog()


        If _ReemplazarCancelar = True Then
            Exit Sub
        End If

        'AG 28/05/2014 Barra ==================================
        Dim Fp As New frmProgresoCargaGrilla
        '=======================================================

        If _ReemplazoTemasTipoObjetivo = TipoAplicacion.GRPS Then
            If _DtReemplazoDetalleSpot.Rows.Count > 0 Then
                If _DtReemplazoAvisosEliminar.Rows.Count > 0 Then

                    'AG 28/05/2014 ====================================================
                    Application.DoEvents()
                    Fp.Texto = "Verificando Temas a Reemplazar."
                    Fp.Max1 = 5
                    Application.DoEvents()
                    Fp.Show()
                    Application.DoEvents()
                    'frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    '=====================================================================

                    DtDistinto = _DtReemplazoAvisosEliminar.DefaultView.ToTable(True, "ID_SPOT", "F_SPOT")
                    For Each RowAvisosEliminar As DataRow In DtDistinto.Rows
                        Dim DiaAviso As Date
                        Dim CeldaCompra As UltraGridCell
                        Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(RowAvisosEliminar("id_spot"))
                        Dim FilaTemasSpot As DataRow
                        Dim TemasEliminar As String = ""
                        DiaAviso = CDate(RowAvisosEliminar("F_SPOT")).ToShortDateString()
                        ColumnaCompraReemplazo = DiaAviso.ToShortDateString

                        For Each RowTemaSeleccionado As DataRow In _DtReemplazoSeleccionados.Rows
                            CeldaCompra = Me.iugEjercicio.Rows(Fila.Index).Cells(DiaAviso)
                            If CeldaCompra.Appearance.BackColor.Equals(ColorVigenciaNula) Then
                                Me.iugEjercicio.PerformAction(UndoCell, False, False)
                            Else
                                If GrillAdmin.EsColumnaCalendario(CeldaCompra) Then
                                    Dim NombreBanda As String
                                    Dim letra As String
                                    Dim CompraFinal As String
                                    Dim ComptraAnterior As String
                                    Dim PosicionLetraCelda As Integer

                                    Dim TemasCeldas As String = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value.ToString()
                                    CompraFinal = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                                    Dim Caracteres As Array = CompraFinal.ToArray()
                                    Array.Sort(Caracteres)
                                    CompraFinal = New String(Caracteres)
                                    TemasCeldas = CompraFinal
                                    For i As Integer = 0 To TemasCeldas.Length - 1
                                        letra = TemasCeldas.Substring(i, 1)
                                        If RowTemaSeleccionado("TEMA").ToString() = letra Then
                                            ComptraAnterior = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                                            'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                                            Me.UltimoText = ComptraAnterior
                                            '========================================================
                                            'AG 30/05/2014 =====================================================================
                                            CompraFinal = ObtenerCompra(ComptraAnterior, RowTemaSeleccionado("TEMA").ToString())
                                            '==================================================================================

                                            'AG Codigo Anterior =======================================================================
                                            'PosicionLetraCelda = InStr(ComptraAnterior, letra)
                                            'If CompraFinal.Length = 1 Or CompraFinal.Length = 0 Then
                                            '    CompraFinal = ""
                                            'Else
                                            '    CompraFinal = CompraFinal.Substring(PosicionLetraCelda, CompraFinal.Length - 1)
                                            'End If
                                            '============================================================================================

                                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = True
                                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value = CompraFinal
                                            'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                                            'Me.CalcularGrillasResumen(ComptraAnterior.ToUpper, CompraFinal.ToUpper, Me.UltraDataSource1.Rows(Fila.Index), ColumnaCompraReemplazo)
                                            '========================================================
                                            Me.UltraDataSource1.Rows(Fila.Index).SetCellValue(ColumnaCompraReemplazo, CompraFinal)
                                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = False
                                            Me.HayCambios = True
                                        End If
                                    Next i
                                    Me.iugEjercicio.EndUpdate()
                                    iugEjercicio.PerformAction(ExitEditMode, False, False)
                                End If
                            End If
                        Next
                    Next

                    'AG 28/05/2014 =================================================
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    frmProgresoCargaGrilla.Instancia.Close()

                    Dim F As New frmProgresoCargaGrilla

                    Application.DoEvents()
                    F.Texto = "Analizando Reemplazo de Temas"
                    F.Max1 = 5
                    Application.DoEvents()
                    F.Show()
                    Application.DoEvents()
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    '=================================================================

                    For Each RowAvisosNuevos As DataRow In _DtReemplazoDetalleSpot.Rows
                        Dim DiaAviso As Date
                        Dim CeldaCompra As UltraGridCell
                        Dim NombreBanda As String
                        Dim CompraFinal As String
                        Dim ComptraAnterior As String
                        Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(RowAvisosNuevos("ID_SPOT"))
                        DiaAviso = CDate(RowAvisosNuevos("F_SPOT")).ToShortDateString()
                        ColumnaCompraReemplazo = DiaAviso.ToShortDateString
                        ComptraAnterior = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                        Me.UltimoText = ComptraAnterior
                        '========================================================
                        CompraFinal = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                        CompraFinal += RowAvisosNuevos("TEMA_NUEVO").ToString
                        iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = True
                        iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value = CompraFinal
                        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                        'Me.CalcularGrillasResumen(ComptraAnterior.ToUpper, CompraFinal.ToUpper, Me.UltraDataSource1.Rows(Fila.Index), ColumnaCompraReemplazo)
                        '====================================================
                        Me.UltraDataSource1.Rows(Fila.Index).SetCellValue(ColumnaCompraReemplazo, CompraFinal)
                        iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = False
                        Me.HayCambios = True
                    Next
                    Me.iugEjercicio.EndUpdate()
                End If
            End If

            'AG 28/05/2014 =================================================================
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            frmProgresoCargaGrilla.Instancia.Close()
            '===============================================================================

        ElseIf _ReemplazoTemasTipoObjetivo = TipoAplicacion.INVERSION Then

            'AG 28/05/2014 ====================================================
            Application.DoEvents()
            Fp.Texto = "Verificando Temas a Reemplazar."
            Fp.Max1 = 7
            Application.DoEvents()
            Fp.Show()
            Application.DoEvents()
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            frmProgresoCargaGrilla.Instancia.Incrementar(1)
            '=====================================================================

            If _DtReemplazoDetalleSpot.Rows.Count > 0 Then
                If _DtReemplazoAvisosEliminar.Rows.Count > 0 Then
                    DtDistinto = _DtReemplazoAvisosEliminar.DefaultView.ToTable(True, "ID_SPOT", "F_SPOT")
                    For Each RowAvisosEliminar As DataRow In DtDistinto.Rows
                        Dim DiaAviso As Date
                        Dim CeldaCompra As UltraGridCell
                        Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(RowAvisosEliminar("id_spot"))
                        Dim FilaTemasSpot As DataRow
                        Dim TemasEliminar As String = ""
                        DiaAviso = CDate(RowAvisosEliminar("F_SPOT")).ToShortDateString()
                        ColumnaCompraReemplazo = DiaAviso.ToShortDateString

                        For Each RowTemaSeleccionado As DataRow In _DtReemplazoSeleccionados.Rows
                            CeldaCompra = Me.iugEjercicio.Rows(Fila.Index).Cells(DiaAviso)
                            If CeldaCompra.Appearance.BackColor.Equals(ColorVigenciaNula) Then
                                Me.iugEjercicio.PerformAction(UndoCell, False, False)
                            Else
                                If GrillAdmin.EsColumnaCalendario(CeldaCompra) Then
                                    Dim NombreBanda As String
                                    Dim letra As String
                                    Dim CompraFinal As String
                                    Dim ComptraAnterior As String
                                    Dim PosicionLetraCelda As Integer

                                    Dim TemasCeldas As String = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value.ToString()
                                    CompraFinal = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value

                                    Dim Caracteres As Array = CompraFinal.ToArray()
                                    Array.Sort(Caracteres)
                                    CompraFinal = New String(Caracteres)

                                    TemasCeldas = CompraFinal

                                    For i As Integer = 0 To TemasCeldas.Length - 1
                                        letra = TemasCeldas.Substring(i, 1)
                                        If RowTemaSeleccionado("TEMA").ToString() = letra Then
                                            ComptraAnterior = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                                            'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                                            Me.UltimoText = ComptraAnterior
                                            '========================================================
                                            'AG 30/05/2014 =====================================================================
                                            CompraFinal = ObtenerCompra(ComptraAnterior, RowTemaSeleccionado("TEMA").ToString())
                                            '==================================================================================


                                            'AG codigo anterior ====================================================================
                                            'PosicionLetraCelda = InStr(ComptraAnterior, letra)
                                            'If CompraFinal.Length = 1 Or CompraFinal.Length = 0 Then
                                            'CompraFinal = ""
                                            'Else
                                            'CompraFinal = CompraFinal.Substring(PosicionLetraCelda, CompraFinal.Length - 1)
                                            'End If
                                            '========================================================================================

                                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = True
                                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value = CompraFinal
                                            'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                                            'Me.CalcularGrillasResumen(ComptraAnterior.ToUpper, CompraFinal.ToUpper, Me.UltraDataSource1.Rows(Fila.Index), ColumnaCompraReemplazo)
                                            '========================================================
                                            Me.UltraDataSource1.Rows(Fila.Index).SetCellValue(ColumnaCompraReemplazo, CompraFinal)
                                            iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = False
                                            Me.HayCambios = True
                                        End If
                                    Next i
                                    Me.iugEjercicio.EndUpdate()
                                    iugEjercicio.PerformAction(ExitEditMode, False, False)
                                End If
                            End If
                        Next
                    Next

                    'AG 28/05/2014 ===================================================
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    frmProgresoCargaGrilla.Instancia.Close()

                    Dim F As New frmProgresoCargaGrilla

                    Application.DoEvents()
                    F.Texto = "Aplicando Reemplazo de Temas"
                    F.Max1 = 7
                    Application.DoEvents()
                    F.Show()
                    Application.DoEvents()
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    frmProgresoCargaGrilla.Instancia.Incrementar(1)
                    '=================================================================


                    For Each RowAvisosNuevos As DataRow In _DtReemplazoDetalleSpot.Rows
                        Dim DiaAviso As Date
                        Dim CeldaCompra As UltraGridCell
                        Dim NombreBanda As String
                        Dim CompraFinal As String
                        Dim ComptraAnterior As String
                        Dim Fila As UltraDataRow = Me.ObtenerUltraDataRow(RowAvisosNuevos("ID_SPOT"))
                        DiaAviso = CDate(RowAvisosNuevos("F_SPOT")).ToShortDateString()
                        ColumnaCompraReemplazo = DiaAviso.ToShortDateString
                        ComptraAnterior = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                        Me.UltimoText = ComptraAnterior
                        '========================================================
                        CompraFinal = iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value
                        CompraFinal += RowAvisosNuevos("TEMA_NUEVO").ToString
                        iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = True
                        iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Value = CompraFinal
                        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                        'Me.CalcularGrillasResumen(ComptraAnterior.ToUpper, CompraFinal.ToUpper, Me.UltraDataSource1.Rows(Fila.Index), ColumnaCompraReemplazo)
                        '========================================================
                        Me.UltraDataSource1.Rows(Fila.Index).SetCellValue(ColumnaCompraReemplazo, CompraFinal)
                        iugEjercicio.Rows(Fila.Index).Cells(ColumnaCompraReemplazo).Activated = False
                        Me.HayCambios = True
                    Next
                    Me.iugEjercicio.EndUpdate()
                End If
            End If
        End If

        'AG 28/05/2014 =================================================================
        'frmProgresoCargaGrilla.Instancia.Incrementar(1)
        frmProgresoCargaGrilla.Instancia.Incrementar(1)
        frmProgresoCargaGrilla.Instancia.Close()
        '===============================================================================


        Me.iugEjercicio.EndUpdate()
        GrillaFormato.HabilitarEdicionColumna(iugEjercicio, Activation.NoEdit)
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Moneda, "Total Bruto", "Total Neto")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.Decimales, "Total GRP Target 1")
        GrillaFormato.CambiarFormatoColumna(iugEjercicio, Formato.General, "Total Spots", "Dur")
        GrillaFormato.CambiarAlineacionColumna(iugEjercicio)
        Listas.OcultarHeader(iugEjercicio)
        GrillaFormato.ReocultarColumnasHijos(iugEjercicio)

        For Each b As UltraGridBand In iugEjercicio.DisplayLayout.Bands
            If b.Index > 0 Then
                GrillaFormato.FijarColumna(b.Columns("Tema"), True)
                GrillaFormato.FijarColumna(iugEjercicio.DisplayLayout.Bands(b.Index).Columns(b.Columns("tema").Index + 4), True)
                GrillaFormato.CambiarColorColumna(iugEjercicio, ColorColTotales, b.Index, "Total Spots", "Total Bruto", "Total Neto", "Total GRP Target 1", "Total GRP Target 2")
            End If
        Next

        'AG Hoja Numero =========================
        If Activo.IDMedio = MedioTv Then
            GrillaFormato.HabilitarEdicionColumnaHijo(iugEjercicio, Activation.NoEdit, Activation.AllowEdit)
        End If
        '========================================

        'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
        cbCalculoAutomatico.Checked = estadoCalculoAutomatico
        If cbCalculoAutomatico.Checked Then
            'LC 01/07/2014 Calculo de totales luego de efectuar el distribuidor de pases o remplazar temas
            GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )
        End If
    End Sub

    Private Function ObtenerSpotUtilizables(ByVal dtTemporal As DataTable, ByVal dtSpot As DataTable, ByVal dtSpotDetalle As DataTable) As DataTable

        Dim DtResultado As DataTable
        Dim i As Integer
        Dim Rows As DataRow()


        For Each Drdetalle As DataRow In dtSpotDetalle.DefaultView.ToTable(True, "ID_SPOT").Rows
            Rows = dtSpot.Select("ID_SPOT= " & Drdetalle("ID_SPOT"))

            If Rows.Length > 0 Then
                dtTemporal.ImportRow(Rows(0))
            End If

        Next

        dtTemporal.AcceptChanges()

        Return dtTemporal

    End Function

    Private Function ObtenerSpotDetalleUtilizables(ByVal dtTemporal As DataTable) As DataTable

        Dim Rows As DataRow()
        Dim i As Integer
        Dim Letra As String = "C"

        Rows = dtTemporal.Select("ID_SPOT_ESTADO='" & Letra & "'")

        If Rows.Length > 0 Then
            For i = 0 To Rows.Length - 1
                dtTemporal.Rows.Remove(Rows(i))
            Next
        End If

        dtTemporal.AcceptChanges()

        Return dtTemporal

    End Function

    Private Function ObtenerTemasHojas() As DataTable

        Dim DtTemasHojasDetalle As DataTable = DetalleBase.DefaultView.ToTable(True, "ID_TEMA", "DURACION", "ID_SPOT_ESTADO")
        Dim DtTemasHojas As DataTable
        Dim RowNueva As DataRow
        Dim estadoPlanificado As String = "P"

        DtTemasHojas = CrearDtTemasHoja()

        For Each RowTemaHoja As DataRow In DtTemasHojasDetalle.Select("ID_SPOT_ESTADO ='" & estadoPlanificado.ToString() & "'")
            RowNueva = DtTemasHojas.NewRow
            RowNueva("TemaHoja") = RowTemaHoja("ID_TEMA")
            RowNueva("Duracion") = RowTemaHoja("DURACION")
            RowNueva("Sel") = False
            DtTemasHojas.Rows.Add(RowNueva)
            DtTemasHojas.AcceptChanges()
        Next


        Return DtTemasHojas

    End Function

    Private Function BlanquearCampoSel(ByVal dt As DataTable) As DataTable

        For Each dr As DataRow In dt.Rows
            dr("Sel") = False
        Next

        Return dt

    End Function

    Private Function CrearDtTemasHoja() As DataTable

        Dim Dt As New DataTable

        Dt.Columns.Add("TemaHoja", GetType(String))
        Dt.Columns.Add("Duracion", GetType(String))
        Dt.Columns.Add("Sel", GetType(Boolean))

        Return Dt

    End Function

    Private Function AgregarColumnasTemasCampania(ByVal Dt) As DataTable

        Dt.Columns.Add("Sel", GetType(Boolean))

        Return Dt

    End Function

    Private Function ObtenerTemasCampaniaRadio(ByVal Dt As DataTable) As DataTable

        Dim DtTemporal As New DataTable
        Dim FilaNueva As DataRow

        If Dt.Rows.Count > 0 Then

            With DtTemporal.Columns
                .Add("TEMA", GetType(String))
                .Add("PORCENTAJE", GetType(Double))
                .Add("DURACION", GetType(Integer))
                .Add("Sel", GetType(Boolean))
            End With

            For Each Dr As DataRow In Dt.Rows
                FilaNueva = DtTemporal.NewRow
                FilaNueva("TEMA") = Dr("ID_TEMA")
                FilaNueva("DURACION") = Dr("DURACION")
                FilaNueva("Sel") = False
                DtTemporal.Rows.Add(FilaNueva)
            Next
            DtTemporal.AcceptChanges()
        End If

        Return DtTemporal

    End Function

    Private Function ObtenerTemasCampaniaXMedio(ByVal Dt As DataTable) As DataTable

        Dim DtTemporal As New DataTable
        Dim FilaNueva As DataRow

        If Dt.Rows.Count > 0 Then

            With DtTemporal.Columns
                .Add("TEMA", GetType(String))
                .Add("PORCENTAJE", GetType(Double))
                .Add("DURACION", GetType(Integer))
                .Add("Sel", GetType(Boolean))
            End With

            For Each Dr As DataRow In Dt.Rows
                FilaNueva = DtTemporal.NewRow
                FilaNueva("TEMA") = Dr("ID_TEMA")
                FilaNueva("DURACION") = Dr("DURACION")
                FilaNueva("Sel") = False
                DtTemporal.Rows.Add(FilaNueva)
            Next
            DtTemporal.AcceptChanges()
        End If

        Return DtTemporal

    End Function

    Private Function ObtenerCompra(ByVal CompraCelda As String, ByVal LetraReemplazo As String) As String

        Dim CantidadLetrasReemplazo As Integer
        Dim CantidadLetrasNoReemplazo As Integer = 0
        Dim CompraLetrasNoReemplazo As String = ""
        Dim CompraLetrasReemplazo As String
        Dim CompraTemp As String = ""
        Dim LetraQuitar As String
        Dim CantidadLetrasReemplazoPermitido As Integer

        If CompraCelda.Length > 0 Then

            For i As Integer = 0 To CompraCelda.Length - 1
                LetraQuitar = CompraCelda.Substring(i, 1)
                If LetraQuitar = LetraReemplazo Then
                    CantidadLetrasReemplazo += 1
                Else
                    CantidadLetrasNoReemplazo += 1
                    CompraLetrasNoReemplazo += LetraQuitar
                End If
            Next

            CantidadLetrasReemplazoPermitido = CantidadLetrasReemplazo - 1

            If CompraLetrasNoReemplazo.Length > 0 Then
                CompraTemp = CompraLetrasNoReemplazo
                If CantidadLetrasReemplazo > 0 Then
                    If CantidadLetrasReemplazoPermitido > 0 Then
                        For t As Integer = 0 To CantidadLetrasReemplazoPermitido - 1
                            CompraTemp += LetraReemplazo
                        Next
                    End If

                End If
            End If

        End If
        Return CompraTemp


    End Function

    Private Function ObtenerSpotUtilizablesLine(ByVal dtTemporal As DataTable, ByVal dtSpot As DataTable, ByVal dtSpotDetalle As DataTable) As DataTable

        Dim DtResultado As DataTable
        Dim i As Integer
        Dim Rows As DataRow()


        For Each Drdetalle As DataRow In dtSpotDetalle.DefaultView.ToTable(True, "ID_SPOT").Rows
            Rows = dtSpot.Select("ID_SPOT= " & Drdetalle("ID_SPOT"))

            If Rows.Length > 0 Then
                dtTemporal.ImportRow(Rows(0))
            End If

        Next

        dtTemporal.AcceptChanges()

        Return dtTemporal

    End Function

    'AG 05/06/2014 =============================================
    Private Function QuitarSoporteTarifasAutis(ByVal ArraySoportes As ArrayList) As ArrayList

        Dim DtDistintSoportes As DataTable = SpotBase.DefaultView.ToTable(True, "ID_SOPORTE")
        Dim ArraySoporteNuevo As ArrayList = ArraySoportes.Clone


        If DtDistintSoportes.Rows.Count > 0 Then
            For Each IL As ItemLista In ArraySoportes
                If DtDistintSoportes.Select("id_soporte=" & IL.ID).Length > 0 Then
                    ArraySoporteNuevo.Remove(IL)
                End If
            Next
        End If

        Return ArraySoporteNuevo

    End Function

    Private Sub ReporteLine()

        Dim frmReporteRegional As New frmReporteLineHoja
        Dim frmDolar As New frmreporteRegionalCotizadorDolar
        Dim DtCloneSpot As New DataTable
        Dim DtCloneSpotDetalle As New DataTable

        Me.mInstancia = Me
        frmDolar.ShowDialog()

        DtCloneSpot = SpotBase.Clone
        With frmReporteRegional
            .ValorDolarCotizacion = frmDolar.ValorDolar
            DtCloneSpot = ObtenerSpotUtilizablesLine(DtCloneSpot, SpotBase, DetalleBase)
            'DtCloneSpot.Select("", "id_soporte" & " id_soporte DESC")
            DtCloneSpot.Select("", "" & " id_soporte DESC")

            .DtSpot = DtCloneSpot
            .DtTemas = dtTemas
            .DtSpotDetalle = DetalleBase
            .ColumnaTarget1 = GrillAdmin.ColumnaRatingTarget1.ToString()
            .ColumnaTarget2 = GrillAdmin.ColumnaRatingTarget2.ToString()

        End With

        frmReporteRegional.ShowDialog()

    End Sub

    'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
    Private Sub cbCalculoAutomatico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCalculoAutomatico.CheckedChanged
        If cbCalculoAutomatico.Checked Then
            Dim Dr As DataRow
            Me.Cursor = Cursors.WaitCursor

            '*** FRANJAS
            Dim F As New Franjas_Detalle
            Franjas = F.ObtenerPorCliente(Activo.IDCliente, Me.IDFranja)

            'si el cliente no tiene franjas, se toman las del cliente 0
            If Franjas Is Nothing OrElse Franjas.Rows.Count = 0 Then
                Franjas = F.ObtenerPorCliente(0, 1)
            End If

            'agrega 2 columnas para llevar la cuenta de los temas y la suma de la duracion (para sacar la duracion promedio)
            Franjas.Columns.Add("SumaDuracion", GetType(Single))
            Franjas.Columns.Add("CantidadTemas", GetType(Single))

            'inicializa los valores a CERO
            For Each Dr In Franjas.Rows
                Dr("SumaDuracion") = 0
                Dr("CantidadTemas") = 0
            Next

            '*** SEMANAS

            'arma un array con obejto Semana que guardan las semanas del calendario y mantiene la cuenta de los temas
            'y la suma de las duraciones para sacar la duracion promedio
            Semanas = GrillaResumen.ObtenerSemanas7Dias(Me.UltraDataSource1, Activo.FechaFinSistema)

            '*** SOPORTES
            Me.SoportesDuracion = New ArrayList
            If TypeOf AuxSoportes Is DataTable Then
                'si se carga de la base, se recorre un datatable
                For Each Dr In DirectCast(AuxSoportes, DataTable).Rows
                    Dim SD As New SoporteDuracion
                    SD.IDSoporte = Dr("id_soporte")
                    If Dr("descripcion").ToString = String.Empty Then
                        SD.Soporte = ""
                    Else
                        SD.Soporte = Dr("descripcion")
                    End If
                    SD.CantidadTemas = 0
                    SD.TotalDuracion = 0
                    Me.SoportesDuracion.Add(SD)
                Next
            Else
                'si se carga por 1ra vez, recorre un array li st
                Dim IL As ItemLista
                If Not AuxSoportes Is Nothing Then
                    For Each IL In DirectCast(AuxSoportes, ArrayList)
                        Dim SD As New SoporteDuracion
                        SD.IDSoporte = IL.ID
                        SD.Soporte = IL.Descripcion
                        SD.CantidadTemas = 0
                        SD.TotalDuracion = 0
                        Me.SoportesDuracion.Add(SD)
                    Next
                End If
            End If

            If Not AuxSoportes Is Nothing Then

                'AG Velociad ============================================================================================================
                Me.iugSoporte.DataSource = Nothing
                Me.iugTema.DataSource = Nothing
                Me.iugSemana.DataSource = Nothing
                Me.iugFranja.DataSource = Nothing

                GrillaResumen.ObtenerDuracionPromedio(Me.UltraDataSource1, Franjas, AuxSoportes, dtTemas)
                Me.iugSoporte.DataSource = GrillaResumen.GrillaPorSoporte(Me.iugEjercicio, AuxSoportes, dtTemas)
                Me.iugTema.DataSource = GrillaResumen.GrillaPorTema(Me.UltraDataSource1, dtTemas)
                Me.iugSemana.DataSource = GrillaResumen.GrillaPorSemana(Me.UltraDataSource1, dtTemas, Activo.FechaFinSistema)
                Me.iugFranja.DataSource = GrillaResumen.GrillaPorFranja(Me.UltraDataSource1, Franjas, dtTemas)
                GrillaResumen.CalcularTotalesResumen(Me.iugEjercicio, Me.lblGRP, Me.lblAvisos, Me.lblSegundos, Me.lblBruto, Me.lblNeto, Me.lblCPR, Me.lblDuracionPromedioCPR, UltraDataSource1, dtTemas, )

                '==================== Desgloses SOPORTES ==========================
                GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "% Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Tarifa Neta", Formato.Moneda)
                GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "% Tarifa Neta", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "CPR", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugSoporte, "Bruto", Formato.Moneda)
                GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "bruto", HAlign.Right)
                GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "CantidadTemas", HAlign.Right)
                GrillaFormato.CambiarAlineacionColumna(Me.iugSoporte, "PorcentajeDuracion", HAlign.Right)
                GrillaFormato.AcivarOperacion(Me.iugSoporte, "Bruto", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:$ ##,###.00}")
                GrillaFormato.AcivarOperacion(Me.iugSoporte, "CantidadTemas", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
                GrillaFormato.AcivarOperacion(Me.iugSoporte, "PorcentajeDuracion", SummaryType.Sum, , SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
                Listas.CambiarTituloColumna(Me.iugSoporte, "CantidadTemas", "Temas")
                Listas.CambiarTituloColumna(Me.iugSoporte, "PorcentajeDuracion", "% Dur.")
                GrillaFormato.HabilitarEdicionColumna(Me.iugSoporte, Activation.NoEdit, False)
                Listas.OcultarColumnas(Me.iugSoporte, "id_soporte", "SumaDuracion") ', "CantidadTemas", "PorcentajeDuracion")
                GrillaFormato.AutoAjustarColumnas(Me.iugSoporte)
                Me.AgregarSumatoriasDesgloses(Me.iugSoporte)

                '==================== Desgloses TEMAS ==========================
                GrillaFormato.CambiarFormatoColumna(Me.iugTema, "Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugTema, "% Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugTema, "Tarifa Neta", Formato.Moneda)
                GrillaFormato.CambiarFormatoColumna(Me.iugTema, "% Tarifa Neta", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugTema, "CPR", Formato.Decimales)
                GrillaFormato.HabilitarEdicionColumna(Me.iugTema, Activation.NoEdit, False)
                GrillaFormato.AutoAjustarColumnas(Me.iugTema)
                GrillaFormato.CambiarAlineacionColumna(Me.iugTema, "Temas", HAlign.Right)
                Listas.OcultarColumnas(Me.iugTema, "id_tema", "Duracion")
                GrillaFormato.AcivarOperacion(Me.iugTema, "Temas", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
                Me.AgregarSumatoriasDesgloses(Me.iugTema)

                '==================== Desgloses SEMANA ==========================
                GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "% Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "Tarifa Neta", Formato.Moneda)
                GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "% Tarifa Neta", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugSemana, "CPR", Formato.Decimales)
                GrillaFormato.HabilitarEdicionColumna(Me.iugSemana, Activation.NoEdit, False)
                Listas.OcultarColumnas(Me.iugSemana, "f_inicio", "f_fin", "SumaDuracion", "CantidadTemas")
                GrillaFormato.AutoAjustarColumnas(Me.iugSemana)
                Me.AgregarSumatoriasDesgloses(Me.iugSemana)

                '==================== Desgloses FRANJA ==========================
                GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "% Grps", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "Tarifa Neta", Formato.Moneda)
                GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "% Tarifa Neta", Formato.Decimales)
                GrillaFormato.CambiarFormatoColumna(Me.iugFranja, "CPR", Formato.Decimales)
                GrillaFormato.HabilitarEdicionColumna(Me.iugFranja, Activation.NoEdit, False)
                GrillaFormato.CambiarAlineacionColumna(Me.iugFranja, "CantidadTemas", HAlign.Right)
                Listas.CambiarTituloColumna(Me.iugFranja, "CantidadTemas", "Temas")
                Listas.OcultarColumnas(Me.iugFranja, "h_desde", "h_hasta", "SumaDuracion")
                GrillaFormato.AutoAjustarColumnas(Me.iugFranja)
                GrillaFormato.AcivarOperacion(Me.iugFranja, "CantidadTemas", SummaryType.Sum, "", SummaryPosition.UseSummaryPositionColumn, "{0:##,###}")
                Me.AgregarSumatoriasDesgloses(Me.iugFranja)
                '=========================================================================================================

            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub iugEjercicio_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles iugEjercicio.InitializeRow

    End Sub

    Private Sub pivotFlex_FieldAreaChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles pivotFlex.FieldAreaChanged
        If Not pivotLoading Then
            Me.pivotFlex.SaveLayout("pivotDock") ' guardo el layout con cada cambio de area.
        End If
    End Sub

    Private Sub pivotFlex_FieldWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles pivotFlex.FieldWidthChanged
        If Not pivotLoading Then
            Me.pivotFlex.SaveLayout("pivotDock") ' guardo el layout con cada cambio de tamaño de columna.
        End If
    End Sub

    Private Sub pivotFlex_MenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridMenuItemClickEventArgs) Handles pivotFlex.MenuItemClick
        If e.Item.Caption = "Refresh Data" Then
            CargarCubo(Me.SpotBase.Copy(), Me.DetalleBase.Copy(), Me.Franjas.Copy(), True)
            Me.pivotFlex.SaveLayout("pivotDock")
        End If
    End Sub

End Class

Public Enum TipoObjetivo
    INVERSION = 1
    GRPS = 2
End Enum

Public Enum TipoFranja
    RATMASALTO = 1
    CPRMASBAJO = 2
End Enum

Public Enum TipoAplicacion
    INVERSION = 1
    GRPS = 2
End Enum

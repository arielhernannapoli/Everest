Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Collections.Generic
Imports HM.MMS.AR.Server.BusinessEntity.Control

Public Class frmDesconfirmacionAvisos
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
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents frmConfirmacionAvisos_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents pnlFiltro As System.Windows.Forms.Panel
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TxtProducto As QUETOOL.txtTexto
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtPresupuesto As QUETOOL.txtTexto
    Friend WithEvents lblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents pnlGrillas As System.Windows.Forms.Panel
    Friend WithEvents pnlGrillaPrincipal As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsManager2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents pnlGrillaPrincipal_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ugOrdenAviso As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnlGrillaConfirmados As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsManager3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents pnlGrillaConfirmados_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _pnlGrillaConfirmados_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaConfirmados_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaConfirmados_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ugAvisosConfirmados As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPresupuesto As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarPantalla")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Blanquear")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Blanquear")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionSoporte")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionFecha")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Imprimir")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionSoporte")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionFecha")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ClienteExterno")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BusquedaPresupuesto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden", 0)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Soporte", 1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaProg", 2)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaReal", 3)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraProg", 4)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraReal", 5)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DuracionProg", 6)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DuracionReal", 7)
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado", 8)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Programa", 9)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProgramaReal", 10)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAvisoOrden", 11)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Falla", 12)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Soporte", 13)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Spot", 14)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SS_Spot", 15)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProgramaVisible", 16)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material", 17)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tema", 18)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Posicion", 19)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AvisosBloque", 20)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato", 21)
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
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarGrillaConfirmados")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desconfirmar")
        Dim LabelTool1 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("CantidadRegistros")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desconfirmar")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupAvisoConfirmado")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarPopup")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarPopup")
        Dim LabelTool2 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("CantidadRegistros")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden", 0)
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Soporte", 1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaProg", 2)
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaReal", 3)
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraProg", 4)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraReal", 5)
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DuracionProg", 6)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DuracionReal", 7)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado", 8)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Programa", 9)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProgramaReal", 10)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAvisoOrden", 11)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Falla", 12)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Soporte", 13)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Spot", 14)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SS_Spot", 15)
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProgramaVisible", 16)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material", 17)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tema", 18)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Posicion", 19)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AvisosBloque", 20)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato", 21)
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolbar3 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarGrillaPrincipal")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Relacionar")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desvincular")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaido")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MostrarAvisoCaido")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Relacionar")
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desvincular")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupOrdenAviso")
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarPopup")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("RelacionarPopup")
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("DesvincularPopup")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaidoPopup")
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarPopup")
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("RelacionarPopup")
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("DesvincularPopup")
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaido")
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaidoPopup")
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MostrarAvisoCaido")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDesconfirmacionAvisos))
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.frmConfirmacionAvisos_Fill_Panel = New System.Windows.Forms.Panel
        Me.pnlGrillas = New System.Windows.Forms.Panel
        Me.pnlGrillaConfirmados = New System.Windows.Forms.Panel
        Me.pnlGrillaConfirmados_Fill_Panel = New System.Windows.Forms.Panel
        Me.ugAvisosConfirmados = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnlGrillaPrincipal = New System.Windows.Forms.Panel
        Me.pnlGrillaPrincipal_Fill_Panel = New System.Windows.Forms.Panel
        Me.ugOrdenAviso = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.pnlFiltro = New System.Windows.Forms.Panel
        Me.gbDatos = New System.Windows.Forms.GroupBox
        Me.btnPresupuesto = New Infragistics.Win.Misc.UltraButton
        Me.TxtProducto = New QUETOOL.txtTexto
        Me.lblProducto = New System.Windows.Forms.Label
        Me.txtCliente = New QUETOOL.txtTexto
        Me.lblCliente = New System.Windows.Forms.Label
        Me.txtPresupuesto = New QUETOOL.txtTexto
        Me.lblPresupuesto = New System.Windows.Forms.Label
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmConfirmacionAvisos_Fill_Panel.SuspendLayout()
        Me.pnlGrillas.SuspendLayout()
        Me.pnlGrillaConfirmados.SuspendLayout()
        Me.pnlGrillaConfirmados_Fill_Panel.SuspendLayout()
        CType(Me.ugAvisosConfirmados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrillaPrincipal.SuspendLayout()
        Me.pnlGrillaPrincipal_Fill_Panel.SuspendLayout()
        CType(Me.ugOrdenAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltro.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.LockToolbars = True
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar1.Text = "uToolbarPantalla"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool3.SharedProps.Caption = "Blanquear"
        ButtonTool4.SharedProps.Caption = "Salir"
        ButtonTool5.SharedProps.Caption = "Por Soporte"
        ButtonTool6.SharedProps.Caption = "Por Fecha"
        PopupMenuTool1.SharedProps.Caption = "Imprimir"
        PopupMenuTool1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool7, ButtonTool8})
        ButtonTool9.SharedProps.Caption = "Cliente Externo"
        ButtonTool10.SharedProps.Caption = "Busqueda Presupuesto"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6, PopupMenuTool1, ButtonTool9, ButtonTool10})
        '
        'frmConfirmacionAvisos_Fill_Panel
        '
        Me.frmConfirmacionAvisos_Fill_Panel.Controls.Add(Me.pnlGrillas)
        Me.frmConfirmacionAvisos_Fill_Panel.Controls.Add(Me.pnlFiltro)
        Me.frmConfirmacionAvisos_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmConfirmacionAvisos_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmConfirmacionAvisos_Fill_Panel.Location = New System.Drawing.Point(0, 22)
        Me.frmConfirmacionAvisos_Fill_Panel.Name = "frmConfirmacionAvisos_Fill_Panel"
        Me.frmConfirmacionAvisos_Fill_Panel.Size = New System.Drawing.Size(980, 653)
        Me.frmConfirmacionAvisos_Fill_Panel.TabIndex = 0
        '
        'pnlGrillas
        '
        Me.pnlGrillas.Controls.Add(Me.pnlGrillaConfirmados)
        Me.pnlGrillas.Controls.Add(Me.Splitter1)
        Me.pnlGrillas.Controls.Add(Me.pnlGrillaPrincipal)
        Me.pnlGrillas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillas.Location = New System.Drawing.Point(0, 56)
        Me.pnlGrillas.Name = "pnlGrillas"
        Me.pnlGrillas.Size = New System.Drawing.Size(980, 597)
        Me.pnlGrillas.TabIndex = 1
        '
        'pnlGrillaConfirmados
        '
        Me.pnlGrillaConfirmados.Controls.Add(Me.pnlGrillaConfirmados_Fill_Panel)
        Me.pnlGrillaConfirmados.Controls.Add(Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left)
        Me.pnlGrillaConfirmados.Controls.Add(Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right)
        Me.pnlGrillaConfirmados.Controls.Add(Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top)
        Me.pnlGrillaConfirmados.Controls.Add(Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom)
        Me.pnlGrillaConfirmados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillaConfirmados.Location = New System.Drawing.Point(0, 295)
        Me.pnlGrillaConfirmados.Name = "pnlGrillaConfirmados"
        Me.pnlGrillaConfirmados.Size = New System.Drawing.Size(980, 302)
        Me.pnlGrillaConfirmados.TabIndex = 2
        '
        'pnlGrillaConfirmados_Fill_Panel
        '
        Me.pnlGrillaConfirmados_Fill_Panel.Controls.Add(Me.ugAvisosConfirmados)
        Me.pnlGrillaConfirmados_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGrillaConfirmados_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillaConfirmados_Fill_Panel.Location = New System.Drawing.Point(0, 22)
        Me.pnlGrillaConfirmados_Fill_Panel.Name = "pnlGrillaConfirmados_Fill_Panel"
        Me.pnlGrillaConfirmados_Fill_Panel.Size = New System.Drawing.Size(980, 280)
        Me.pnlGrillaConfirmados_Fill_Panel.TabIndex = 0
        '
        'ugAvisosConfirmados
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugAvisosConfirmados.DisplayLayout.Appearance = Appearance1
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn1.CellAppearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 81
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 100
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.CellAppearance = Appearance3
        UltraGridColumn3.Header.Caption = "Fecha Prog."
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 71
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.CellAppearance = Appearance4
        UltraGridColumn4.Header.Caption = "Fecha Real"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 71
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.Caption = "Hora Prog."
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 40
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.Header.Caption = "Hora Real"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 40
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn7.CellAppearance = Appearance7
        UltraGridColumn7.Header.Caption = "Dur. Prog."
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 40
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn8.CellAppearance = Appearance8
        UltraGridColumn8.Header.Caption = "Dur. Real"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 40
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 90
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 190
        UltraGridColumn11.Header.Caption = "Programa Real"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 190
        UltraGridColumn12.DataType = GetType(System.Int32)
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.Caption = "Programa"
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 380
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand1.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand1.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand1.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand1.Override.HeaderAppearance = Appearance9
        UltraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True
        Me.ugAvisosConfirmados.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugAvisosConfirmados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugAvisosConfirmados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.ugAvisosConfirmados.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugAvisosConfirmados.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.ugAvisosConfirmados.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugAvisosConfirmados.DisplayLayout.GroupByBox.Hidden = True
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugAvisosConfirmados.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.ugAvisosConfirmados.DisplayLayout.MaxColScrollRegions = 1
        Me.ugAvisosConfirmados.DisplayLayout.MaxRowScrollRegions = 1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugAvisosConfirmados.DisplayLayout.Override.ActiveCellAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.SystemColors.Highlight
        Appearance14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugAvisosConfirmados.DisplayLayout.Override.ActiveRowAppearance = Appearance14
        Me.ugAvisosConfirmados.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugAvisosConfirmados.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ugAvisosConfirmados.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugAvisosConfirmados.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugAvisosConfirmados.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Me.ugAvisosConfirmados.DisplayLayout.Override.CardAreaAppearance = Appearance15
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Appearance16.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugAvisosConfirmados.DisplayLayout.Override.CellAppearance = Appearance16
        Me.ugAvisosConfirmados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugAvisosConfirmados.DisplayLayout.Override.CellPadding = 0
        Me.ugAvisosConfirmados.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Appearance17.BackColor = System.Drawing.SystemColors.Control
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.ugAvisosConfirmados.DisplayLayout.Override.GroupByRowAppearance = Appearance17
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugAvisosConfirmados.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.ugAvisosConfirmados.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.Color.Silver
        Me.ugAvisosConfirmados.DisplayLayout.Override.RowAppearance = Appearance19
        Me.ugAvisosConfirmados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.ugAvisosConfirmados.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugAvisosConfirmados.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugAvisosConfirmados.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
        Me.ugAvisosConfirmados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugAvisosConfirmados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugAvisosConfirmados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugAvisosConfirmados.FlatMode = True
        Me.ugAvisosConfirmados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugAvisosConfirmados.Location = New System.Drawing.Point(0, 0)
        Me.ugAvisosConfirmados.Name = "ugAvisosConfirmados"
        Me.ugAvisosConfirmados.Size = New System.Drawing.Size(980, 280)
        Me.ugAvisosConfirmados.TabIndex = 4
        Me.ugAvisosConfirmados.TabStop = False
        '
        '_pnlGrillaConfirmados_Toolbars_Dock_Area_Left
        '
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.Name = "_pnlGrillaConfirmados_Toolbars_Dock_Area_Left"
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 280)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager3
        '
        'UltraToolbarsManager3
        '
        Me.UltraToolbarsManager3.DesignerFlags = 1
        Me.UltraToolbarsManager3.DockWithinContainer = Me.pnlGrillaConfirmados
        Me.UltraToolbarsManager3.LockToolbars = True
        Me.UltraToolbarsManager3.ShowFullMenusDelay = 500
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 0
        UltraToolbar2.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar2.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar2.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar2.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar2.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar2.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar2.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar2.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar2.Text = "uToolbarGrillaConfirmados"
        UltraToolbar2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool11, ButtonTool12, LabelTool1})
        Me.UltraToolbarsManager3.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        ButtonTool13.SharedProps.Caption = "Eliminar"
        ButtonTool14.SharedProps.Caption = "Desconfirmar"
        PopupMenuTool2.SharedProps.Caption = "PopupAvisoConfirmado"
        PopupMenuTool2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool15})
        ButtonTool16.SharedProps.Caption = "Eliminar"
        LabelTool2.SharedProps.Caption = "Cantidad :"
        Me.UltraToolbarsManager3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool13, ButtonTool14, PopupMenuTool2, ButtonTool16, LabelTool2})
        '
        '_pnlGrillaConfirmados_Toolbars_Dock_Area_Right
        '
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(980, 22)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.Name = "_pnlGrillaConfirmados_Toolbars_Dock_Area_Right"
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 280)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager3
        '
        '_pnlGrillaConfirmados_Toolbars_Dock_Area_Top
        '
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.Name = "_pnlGrillaConfirmados_Toolbars_Dock_Area_Top"
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(980, 22)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager3
        '
        '_pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom
        '
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 302)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.Name = "_pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom"
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(980, 0)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager3
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 292)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(980, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'pnlGrillaPrincipal
        '
        Me.pnlGrillaPrincipal.Controls.Add(Me.pnlGrillaPrincipal_Fill_Panel)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom)
        Me.pnlGrillaPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGrillaPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlGrillaPrincipal.Name = "pnlGrillaPrincipal"
        Me.pnlGrillaPrincipal.Size = New System.Drawing.Size(980, 292)
        Me.pnlGrillaPrincipal.TabIndex = 0
        '
        'pnlGrillaPrincipal_Fill_Panel
        '
        Me.pnlGrillaPrincipal_Fill_Panel.Controls.Add(Me.ugOrdenAviso)
        Me.pnlGrillaPrincipal_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGrillaPrincipal_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillaPrincipal_Fill_Panel.Location = New System.Drawing.Point(0, 47)
        Me.pnlGrillaPrincipal_Fill_Panel.Name = "pnlGrillaPrincipal_Fill_Panel"
        Me.pnlGrillaPrincipal_Fill_Panel.Size = New System.Drawing.Size(980, 245)
        Me.pnlGrillaPrincipal_Fill_Panel.TabIndex = 0
        '
        'ugOrdenAviso
        '
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugOrdenAviso.DisplayLayout.Appearance = Appearance21
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn23.CellAppearance = Appearance22
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Width = 81
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn24.Width = 100
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.CellAppearance = Appearance23
        UltraGridColumn25.Header.Caption = "Fecha Prog."
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Width = 71
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.CellAppearance = Appearance24
        UltraGridColumn26.Header.Caption = "Fecha Real"
        UltraGridColumn26.Header.VisiblePosition = 3
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.Width = 71
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.CellAppearance = Appearance25
        UltraGridColumn27.Header.Caption = "Hora Prog."
        UltraGridColumn27.Header.VisiblePosition = 4
        UltraGridColumn27.Width = 55
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.CellAppearance = Appearance26
        UltraGridColumn28.Header.Caption = "Hora Real"
        UltraGridColumn28.Header.VisiblePosition = 5
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 55
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn29.CellAppearance = Appearance27
        UltraGridColumn29.Header.Caption = "Dur. Prog."
        UltraGridColumn29.Header.VisiblePosition = 6
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.Width = 55
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn30.CellAppearance = Appearance28
        UltraGridColumn30.Header.Caption = "Dur. Real"
        UltraGridColumn30.Header.VisiblePosition = 7
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.Width = 55
        UltraGridColumn31.Header.VisiblePosition = 8
        UltraGridColumn31.Width = 90
        UltraGridColumn32.Header.VisiblePosition = 9
        UltraGridColumn32.Width = 190
        UltraGridColumn33.Header.Caption = "Programa Real"
        UltraGridColumn33.Header.VisiblePosition = 10
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 190
        UltraGridColumn34.DataType = GetType(System.Int32)
        UltraGridColumn34.Header.VisiblePosition = 11
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 12
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 13
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 14
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 15
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 16
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 17
        UltraGridColumn41.Header.VisiblePosition = 18
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.Caption = "Pos."
        UltraGridColumn42.Header.VisiblePosition = 19
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Width = 60
        UltraGridColumn43.Header.Caption = "Av. Bloque"
        UltraGridColumn43.Header.VisiblePosition = 20
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 60
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn44.CellAppearance = Appearance29
        UltraGridColumn44.Header.VisiblePosition = 21
        UltraGridColumn44.Width = 80
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        UltraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand2.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand2.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand2.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand2.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand2.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand2.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand2.Override.HeaderAppearance = Appearance30
        UltraGridBand2.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True
        Me.ugOrdenAviso.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugOrdenAviso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugOrdenAviso.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance31.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance31.BorderColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.Appearance = Appearance31
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance32
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.Hidden = True
        Appearance33.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance33.BackColor2 = System.Drawing.SystemColors.Control
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.PromptAppearance = Appearance33
        Me.ugOrdenAviso.DisplayLayout.MaxColScrollRegions = 1
        Me.ugOrdenAviso.DisplayLayout.MaxRowScrollRegions = 1
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Appearance34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugOrdenAviso.DisplayLayout.Override.ActiveCellAppearance = Appearance34
        Appearance35.BackColor = System.Drawing.SystemColors.Highlight
        Appearance35.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugOrdenAviso.DisplayLayout.Override.ActiveRowAppearance = Appearance35
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugOrdenAviso.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugOrdenAviso.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.Override.CardAreaAppearance = Appearance36
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Appearance37.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugOrdenAviso.DisplayLayout.Override.CellAppearance = Appearance37
        Me.ugOrdenAviso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugOrdenAviso.DisplayLayout.Override.CellPadding = 0
        Me.ugOrdenAviso.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Appearance38.BackColor = System.Drawing.SystemColors.Control
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.Override.GroupByRowAppearance = Appearance38
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugOrdenAviso.DisplayLayout.Override.HeaderAppearance = Appearance39
        Me.ugOrdenAviso.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance40.BackColor = System.Drawing.SystemColors.Window
        Appearance40.BorderColor = System.Drawing.Color.Silver
        Me.ugOrdenAviso.DisplayLayout.Override.RowAppearance = Appearance40
        Me.ugOrdenAviso.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.ugOrdenAviso.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugOrdenAviso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance41.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugOrdenAviso.DisplayLayout.Override.TemplateAddRowAppearance = Appearance41
        Me.ugOrdenAviso.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugOrdenAviso.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugOrdenAviso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugOrdenAviso.FlatMode = True
        Me.ugOrdenAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugOrdenAviso.Location = New System.Drawing.Point(0, 0)
        Me.ugOrdenAviso.Name = "ugOrdenAviso"
        Me.ugOrdenAviso.Size = New System.Drawing.Size(980, 245)
        Me.ugOrdenAviso.TabIndex = 2
        Me.ugOrdenAviso.TabStop = False
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Left
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 47)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Left"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 245)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager2
        '
        'UltraToolbarsManager2
        '
        Me.UltraToolbarsManager2.DesignerFlags = 1
        Me.UltraToolbarsManager2.DockWithinContainer = Me.pnlGrillaPrincipal
        Me.UltraToolbarsManager2.LockToolbars = True
        Me.UltraToolbarsManager2.ShowFullMenusDelay = 500
        UltraToolbar3.DockedColumn = 0
        UltraToolbar3.DockedRow = 0
        UltraToolbar3.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar3.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar3.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar3.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar3.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar3.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar3.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.False
        UltraToolbar3.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar3.Text = "uToolbarGrillaPrincipal"
        UltraToolbar3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool17, ButtonTool18, ButtonTool19, ButtonTool20, ButtonTool21})
        Me.UltraToolbarsManager2.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar3})
        ButtonTool22.SharedProps.Caption = "Agregar"
        ButtonTool23.SharedProps.Caption = "Relacionar"
        ButtonTool23.SharedProps.ToolTipText = "Relacionar (Orden-Aviso)"
        ButtonTool23.SharedProps.Visible = False
        ButtonTool24.SharedProps.Caption = "Desvincular"
        ButtonTool24.SharedProps.ToolTipText = "Desvincular (Orden-Aviso)"
        ButtonTool24.SharedProps.Visible = False
        PopupMenuTool3.SharedProps.Caption = "PopupOrdenAviso"
        PopupMenuTool3.SharedProps.Visible = False
        PopupMenuTool3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool25, ButtonTool26, ButtonTool27, ButtonTool28})
        ButtonTool29.SharedProps.Caption = "Agregar"
        ButtonTool29.SharedProps.Visible = False
        ButtonTool30.SharedProps.Caption = "Relacionar"
        ButtonTool30.SharedProps.Visible = False
        ButtonTool31.SharedProps.Caption = "Desvincular"
        ButtonTool31.SharedProps.Visible = False
        ButtonTool32.SharedProps.Caption = "Marca Aviso Caido"
        ButtonTool32.SharedProps.ToolTipText = "Marca Aviso Caido"
        ButtonTool32.SharedProps.Visible = False
        ButtonTool33.SharedProps.Caption = "Marca Aviso Caido"
        ButtonTool33.SharedProps.ToolTipText = "Marca Aviso Caido"
        ButtonTool33.SharedProps.Visible = False
        ButtonTool34.SharedProps.Caption = "Ver Avisos Caidos"
        ButtonTool34.SharedProps.Visible = False
        Me.UltraToolbarsManager2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool22, ButtonTool23, ButtonTool24, PopupMenuTool3, ButtonTool29, ButtonTool30, ButtonTool31, ButtonTool32, ButtonTool33, ButtonTool34})
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Right
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(980, 47)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Right"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 245)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager2
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Top
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Top"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(980, 47)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager2
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 292)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(980, 0)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager2
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.gbDatos)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(980, 56)
        Me.pnlFiltro.TabIndex = 0
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.btnPresupuesto)
        Me.gbDatos.Controls.Add(Me.TxtProducto)
        Me.gbDatos.Controls.Add(Me.lblProducto)
        Me.gbDatos.Controls.Add(Me.txtCliente)
        Me.gbDatos.Controls.Add(Me.lblCliente)
        Me.gbDatos.Controls.Add(Me.txtPresupuesto)
        Me.gbDatos.Controls.Add(Me.lblPresupuesto)
        Me.gbDatos.Location = New System.Drawing.Point(4, 3)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(973, 43)
        Me.gbDatos.TabIndex = 16
        Me.gbDatos.TabStop = False
        '
        'btnPresupuesto
        '
        Appearance42.Image = CType(resources.GetObject("Appearance42.Image"), Object)
        Me.btnPresupuesto.Appearance = Appearance42
        Me.btnPresupuesto.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat
        Me.btnPresupuesto.Location = New System.Drawing.Point(144, 14)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(24, 21)
        Me.btnPresupuesto.TabIndex = 18
        '
        'TxtProducto
        '
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.ConDecimal = False
        Me.TxtProducto.Location = New System.Drawing.Point(760, 14)
        Me.TxtProducto.Maximo = 0
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(208, 20)
        Me.TxtProducto.SoloLetra = False
        Me.TxtProducto.SoloNumero = False
        Me.TxtProducto.TabIndex = 4
        Me.TxtProducto.TabStop = False
        Me.TxtProducto.Text = ""
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(704, 16)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(56, 16)
        Me.lblProducto.TabIndex = 15
        Me.lblProducto.Text = "Producto :"
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(492, 14)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtCliente.SoloLetra = False
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 3
        Me.txtCliente.TabStop = False
        Me.txtCliente.Text = ""
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(448, 16)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(46, 16)
        Me.lblCliente.TabIndex = 13
        Me.lblCliente.Text = "Cliente :"
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.AcceptsReturn = True
        Me.txtPresupuesto.AcceptsTab = True
        Me.txtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresupuesto.ConDecimal = False
        Me.txtPresupuesto.Location = New System.Drawing.Point(76, 14)
        Me.txtPresupuesto.Maximo = 0
        Me.txtPresupuesto.MaxLength = 9
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(62, 20)
        Me.txtPresupuesto.SoloLetra = False
        Me.txtPresupuesto.SoloNumero = True
        Me.txtPresupuesto.TabIndex = 1
        Me.txtPresupuesto.Text = ""
        Me.txtPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(6, 16)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(74, 16)
        Me.lblPresupuesto.TabIndex = 10
        Me.lblPresupuesto.Text = "Presupuesto :"
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Left
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Left"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 653)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Right
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(980, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Right"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 653)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Top
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Top"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(980, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 675)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(980, 0)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'frmDesconfirmacionAvisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(980, 675)
        Me.Controls.Add(Me.frmConfirmacionAvisos_Fill_Panel)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDesconfirmacionAvisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desconfirmación de Avisos"
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmConfirmacionAvisos_Fill_Panel.ResumeLayout(False)
        Me.pnlGrillas.ResumeLayout(False)
        Me.pnlGrillaConfirmados.ResumeLayout(False)
        Me.pnlGrillaConfirmados_Fill_Panel.ResumeLayout(False)
        CType(Me.ugAvisosConfirmados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrillaPrincipal.ResumeLayout(False)
        Me.pnlGrillaPrincipal_Fill_Panel.ResumeLayout(False)
        CType(Me.ugOrdenAviso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltro.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private OrdenAvisoPoint As New Point
    Private AvisoConfirmadoPoint As New Point
    Private Enum Impresion As Integer
        Soporte = 0
        Fecha = 1
    End Enum
#End Region

#Region "Eventos"
    Private Sub frmConfirmacionOrdenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetearCantidadAgregados()
        'Call CargaTipoAviso()
    End Sub

    Private Sub btnPresupuesto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPresupuesto.Click
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        If Presupuesto = String.Empty OrElse Convert.ToDouble(Presupuesto) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
        Else
            Call LimpiarDatos()
            Call ObtenerOrdenesAvisos(Convert.ToDouble(Presupuesto))
            If ugOrdenAviso.Rows.Count <= 0 Then
                Mensaje("No existen registros para el presupuesto ingresado.")
            End If
        End If
    End Sub

    Private Sub cboTipoAviso_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        If Presupuesto <> String.Empty AndAlso Convert.ToDouble(Presupuesto) > 0 Then
            Call LimpiarDatos()
            Call ObtenerOrdenesAvisos(Convert.ToDouble(Presupuesto))
            If ugOrdenAviso.Rows.Count <= 0 Then
                Mensaje("No existen registros para el presupuesto ingresado.")
            End If
        End If
    End Sub

    Private Sub txtPresupuesto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPresupuesto.LostFocus
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        If Presupuesto = String.Empty OrElse Convert.ToDouble(Presupuesto) <= 0 Then
            txtPresupuesto.Text = String.Empty
            Call LimpiarDatos()
        End If
    End Sub

    Private Sub ugOrdenAviso_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ugOrdenAviso.DoubleClick
        Dim aUIElement As Infragistics.Win.UIElement
        Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
        Dim GridRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        aUIElement = ugOrdenAviso.DisplayLayout.UIElement.ElementFromPoint(New Point(OrdenAvisoPoint.X, OrdenAvisoPoint.Y))
        ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

        If ColumnHeader Is Nothing Then
            GridRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            If Not GridRow Is Nothing Then
                Call AgregarOrdenAviso()
            End If
        End If
    End Sub

    Private Sub ugAvisosConfirmados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugAvisosConfirmados.DoubleClick
        Dim aUIElement As Infragistics.Win.UIElement
        Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
        Dim GridRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        aUIElement = ugAvisosConfirmados.DisplayLayout.UIElement.ElementFromPoint(New Point(AvisoConfirmadoPoint.X, AvisoConfirmadoPoint.Y))
        ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

        If ColumnHeader Is Nothing Then
            GridRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            If Not GridRow Is Nothing Then
                Call EliminarOrdenAviso()
            End If
        End If
    End Sub

    Private Sub ugOrdenAviso_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugOrdenAviso.MouseDown
        OrdenAvisoPoint.X = e.X
        OrdenAvisoPoint.Y = e.Y
    End Sub

    Private Sub ugAvisosConfirmados_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugAvisosConfirmados.MouseDown
        AvisoConfirmadoPoint.X = e.X
        AvisoConfirmadoPoint.Y = e.Y
    End Sub

    Private Sub ugOrdenAviso_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugOrdenAviso.MouseUp
        If e.Button = MouseButtons.Right Then
            Dim aUIElement As Infragistics.Win.UIElement
            Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
            Dim GridRow As Infragistics.Win.UltraWinGrid.UltraGridRow

            aUIElement = ugOrdenAviso.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
            ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

            If ColumnHeader Is Nothing Then
                GridRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
                If Not GridRow Is Nothing Then
                    Me.UltraToolbarsManager2.ShowPopup("PopupOrdenAviso")
                End If
            End If
        End If
    End Sub

    Private Sub ugAvisosConfirmados_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugAvisosConfirmados.MouseUp
        If e.Button = MouseButtons.Right Then
            Dim aUIElement As Infragistics.Win.UIElement
            Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
            Dim GridRow As Infragistics.Win.UltraWinGrid.UltraGridRow

            aUIElement = ugAvisosConfirmados.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
            ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

            If ColumnHeader Is Nothing Then
                GridRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
                If Not GridRow Is Nothing Then
                    ugAvisosConfirmados.ActiveRow = GridRow
                    GridRow.Selected = True
                    Me.UltraToolbarsManager3.ShowPopup("PopupAvisoConfirmado")
                End If
            End If
        End If
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Blanquear"
                Call LimpiarDatos()
                txtPresupuesto.Text = String.Empty
                'cboTipoAviso.SelectedIndex = 0
            Case "ImpresionSoporte"
                Call Imprimir(Impresion.Soporte)
            Case "ImpresionFecha"
                Call Imprimir(Impresion.Fecha)
            Case "ClienteExterno"
                Call AbrirClienteExterno()
            Case "BusquedaPresupuesto"
                Call BusquedaPresupuesto()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub UltraToolbarsManager2_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager2.ToolClick
        Select Case e.Tool.Key
            Case "Agregar", "AgregarPopup"
                Call AgregarOrdenAviso()
            Case "Relacionar", "RelacionarPopup"
                Call RelacionarOrdenAviso()
            Case "Desvincular", "DesvincularPopup"
                Call DesvincularOrdenAviso()
            Case "AvisoCaido", "AvisoCaidoPopup"
                Call MarcarAvisosCaidos()
            Case "MostrarAvisoCaido"
                Call MostrarAvisosCaidos()
        End Select
    End Sub

    Private Sub UltraToolbarsManager3_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager3.ToolClick
        Select Case e.Tool.Key
            Case "Eliminar", "EliminarPopup"
                Call EliminarOrdenAviso()
            Case "Desconfirmar"
                Call DesconfirmarOrdenAviso()
        End Select
    End Sub
#End Region

#Region "Metodos Privados"
    'Private Sub CargaTipoAviso()
    '    Dim ControlMacheo As New Control_Macheo
    '    Dim TipoAvisos As DataSet

    '    TipoAvisos = ControlMacheo.BuscarTipoSpots()
    '    cboTipoAviso.Items.Clear()
    '    cboTipoAviso.Enabled = True
    '    If Not TipoAvisos Is Nothing AndAlso Not TipoAvisos.Tables(0) Is Nothing AndAlso TipoAvisos.Tables(0).Rows.Count > 0 Then
    '        Combo_Populate(cboTipoAviso, TipoAvisos.Tables(0))
    '    Else
    '        cboTipoAviso.Enabled = False
    '    End If
    'End Sub

    Private Sub Combo_Populate(ByRef pCombo As UltraComboEditor, ByVal pobjTable As DataTable)
        Dim objItem As ValueListItem
        Dim objRow As DataRow

        For Each objRow In pobjTable.Rows
            objItem = New ValueListItem
            objItem.DataValue = objRow
            objItem.DisplayText = objRow("Cod_Tps") & " - " & objRow("Des_Tps")
            pCombo.Items.Add(objItem)
        Next

        If pCombo.Items.Count <> 0 Then
            pCombo.SelectedIndex = 0
        End If
    End Sub

    Private Sub ObtenerOrdenesAvisos(ByVal Presupuesto As Double)
        Dim ControlMacheo As New Control_Macheo
        Dim ControlMacheo2 As New Control_Macheo
        Dim Ordenes, Spots, Tarifas_TV As DataSet
        Dim Fecha_Desde, Fecha_Hasta, FechaOrden As DateTime
        Dim Soportes As New StringBuilder
        Dim Hora As StringBuilder
        Dim ArrSoportes As New ArrayList
        Dim Cod_Cliente, Cod_Producto, TipoAviso, CantidadSoportes, IndexSpot, Index As Integer
        Dim ExisteCoincidiencia As Boolean
        Dim dsOrdenAviso As DataSet
        Dim ItemSoporte As ValueListItem
        Dim TableSoporte As DataTable
        Dim RowSoporte As DataRow
        Dim TipoAvisoOrden, HoraOrden, SoporteOrden As Integer
        Dim Falla, FechaProg, FechaReal, CodOrden, DuracionProg, DuracionReal, Soporte, HoraProg, HoraReal, Estado, Programa, ProgramaReal, HoraParcial, SegundoParcial, ProgramaOrden, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible As String
        Dim Material, Tema, Posicion, AvisosBloque, Contrato As String
        Dim resultado As New Dictionary(Of String, List(Of AvisoConfirmado))
        Dim lOrdenes As New List(Of AvisoConfirmado)

        'ControlMacheo.Cod_Presupuesto = Presupuesto
        'Ordenes = ControlMacheo.BuscarOrdenesADesconfirmar(Activo.IDCompaniaMMS, Presupuesto)

        resultado = ControlMacheo.ObtenerOrdenesConfirmados(Activo.IDCompaniaMMS, Presupuesto, "")

        If resultado Is Nothing Or Not String.IsNullOrEmpty(resultado.Keys(0)) Then
            Mensaje(resultado.Keys(0))
            Exit Sub
        End If

        lOrdenes = resultado.Values(0)
        dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)

        For Each aviso As AvisoConfirmado In lOrdenes
            Cod_Cliente = aviso.CodigoCliente
            Cod_Producto = aviso.CodigoProducto
            txtCliente.Text = aviso.DescripcionCliente
            TxtProducto.Text = aviso.DescripcionProducto

            'Ordenes.Tables(0).Columns.Add("inicio", GetType(Integer))
            'Ordenes.Tables(0).Columns.Add("fin", GetType(Integer))
            'Ordenes.Tables(0).Columns.Add("min_fin", GetType(Integer))

            Index = 0

            Hora = New StringBuilder
            HoraParcial = aviso.HoraReal.ToString()
            HoraParcial = HoraParcial.Substring(0, HoraParcial.Length - 2)
            If HoraParcial.Length < 1 Then
                Hora.Append(0)
            End If
            Hora.Append(HoraParcial)
            Hora.Append(":")
            HoraParcial = aviso.HoraReal.ToString()
            HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
            If HoraParcial.Length < 1 Then
                Hora.Append(0)
            End If
            Hora.Append(HoraParcial)
            Hora.Append(":")
            HoraParcial = HoraParcial.Insert(0, "0")
            SegundoParcial = aviso.SegundoReal.ToString()
            If SegundoParcial.Length = 1 Then
                Hora.Append(0)
            End If
            Hora.Append(SegundoParcial)

            CodOrden = aviso.CodigoOrden
            Soporte = aviso.DescripcionSoporte
            FechaProg = aviso.FechaReal
            FechaReal = String.Empty
            HoraProg = Hora.ToString
            HoraReal = String.Empty
            DuracionProg = String.Empty
            DuracionReal = String.Empty
            Estado = aviso.DescripcionAplicativo
            Programa = aviso.ProgramaReal
            ProgramaReal = String.Empty
            TipoAvisoOrden = 1
            Cod_Soporte = aviso.CadenaSpot
            Cod_Spot = String.Empty
            SS_Spot = String.Empty
            ProgramaVisible = aviso.ProgramaReal

            Material = aviso.DescripcionMaterial
            Tema = String.Empty
            Posicion = String.Empty
            AvisosBloque = String.Empty
            Contrato = aviso.CodigoContrato.Value.ToString()

            Call InsertarOrdenAviso_JJP(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible, Material, Tema, Posicion, AvisosBloque, Contrato)

        Next


        'If Not Ordenes Is Nothing AndAlso Not Ordenes.Tables(0) Is Nothing AndAlso Ordenes.Tables(0).Rows.Count > 0 Then
        '    Cod_Cliente = Convert.ToInt32(Ordenes.Tables(0).Rows(0)("CLIENTE_SIGEME"))
        '    Cod_Producto = Convert.ToInt32(Ordenes.Tables(0).Rows(0)("PRODUCTO_SIGEME"))
        '    txtCliente.Text = Ordenes.Tables(0).Rows(0)("DES_CLIENTE")
        '    TxtProducto.Text = Ordenes.Tables(0).Rows(0)("des_producto")

        '    Ordenes.Tables(0).Columns.Add("inicio", GetType(Integer))
        '    Ordenes.Tables(0).Columns.Add("fin", GetType(Integer))
        '    Ordenes.Tables(0).Columns.Add("min_fin", GetType(Integer))

        '    For Each Orden As DataRow In Ordenes.Tables(0).Rows
        '        Index = 0

        '        Hora = New StringBuilder
        '        HoraParcial = Orden("HR_SPOT")
        '        HoraParcial = HoraParcial.Substring(0, HoraParcial.Length - 2)
        '        If HoraParcial.Length < 1 Then
        '            Hora.Append(0)
        '        End If
        '        Hora.Append(HoraParcial)
        '        Hora.Append(":")
        '        HoraParcial = Orden("HR_SPOT")
        '        HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
        '        If HoraParcial.Length < 1 Then
        '            Hora.Append(0)
        '        End If
        '        Hora.Append(HoraParcial)
        '        Hora.Append(":")
        '        HoraParcial = HoraParcial.Insert(0, "0")
        '        SegundoParcial = Orden("SS_SPOT")
        '        Hora.Append(SegundoParcial)

        '        CodOrden = Orden("COD_ORDEN")
        '        Soporte = Orden("DES_SOPORTE")
        '        FechaProg = Convert.ToDateTime(Orden("FEC_SPOT")).Date
        '        FechaReal = String.Empty
        '        HoraProg = Hora.ToString
        '        HoraReal = String.Empty
        '        DuracionProg = String.Empty
        '        DuracionReal = String.Empty
        '        Estado = Orden("APLICATIVO")
        '        Programa = Orden("programa")
        '        ProgramaReal = String.Empty
        '        TipoAvisoOrden = 1
        '        Cod_Soporte = Orden("CAD_SPOT")
        '        Cod_Spot = String.Empty
        '        SS_Spot = String.Empty
        '        ProgramaVisible = Orden("programa")

        '        'CAMPOS JJP
        '        Material = IIf(IsDBNull(Orden("MATERIAL_SIGEME")), "", Orden("MATERIAL_SIGEME"))
        '        Tema = String.Empty
        '        Posicion = String.Empty
        '        AvisosBloque = String.Empty
        '        Contrato = Orden("COD_CONTRATO")
        '        '|||||||||||||||||||||||||

        '        Call InsertarOrdenAviso_JJP(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible, Material, Tema, Posicion, AvisosBloque, Contrato)
        '        'Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible)
        '    Next
        'End If
        Call AvisosOrdenadoBind(dsOrdenAviso)
        ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()

        For Each columna As Infragistics.Win.UltraWinGrid.UltraGridColumn In ugOrdenAviso.DisplayLayout.Bands(0).Columns
            columna.AllowRowFiltering = DefaultableBoolean.True
        Next

        'ugOrdenAviso.DisplayLayout.Bands(0).Columns("Soporte").AllowRowFiltering = DefaultableBoolean.True
    End Sub

    Private Sub AvisosOrdenadoBind(ByVal pOrdenAviso As DataSet)
        Dim dsOrdenAvisoOrdenado As New DataSet
        Dim dtOrdenAvisoOrdenado As DataTable = pOrdenAviso.Tables(0).Clone
        For Each drOrdenAviso As DataRow In pOrdenAviso.Tables(0).Select("", "TipoAvisoOrden ASC")
            dtOrdenAvisoOrdenado.ImportRow(drOrdenAviso)
        Next
        dsOrdenAvisoOrdenado.Tables.Add(dtOrdenAvisoOrdenado)
        ugOrdenAviso.DataSource = dsOrdenAvisoOrdenado
        ugOrdenAviso.DataBind()
        If dsOrdenAvisoOrdenado.Tables(0).Rows.Count > 0 Then
            ugOrdenAviso.Selected.Rows.Clear()
            ugOrdenAviso.ActiveRow = ugOrdenAviso.Rows(0)
            ugOrdenAviso.Rows(0).Selected = True
        End If
    End Sub

    Private Sub ObtenerOrdenAviso(ByRef pOrdenAviso As DataSet)
        pOrdenAviso = New DataSet
        Dim dtOrdenAviso As New DataTable

        dtOrdenAviso.Columns.Add("Orden", GetType(String))
        dtOrdenAviso.Columns.Add("Soporte", GetType(String))
        dtOrdenAviso.Columns.Add("FechaProg", GetType(String))
        dtOrdenAviso.Columns.Add("FechaReal", GetType(String))
        dtOrdenAviso.Columns.Add("HoraProg", GetType(String))
        dtOrdenAviso.Columns.Add("HoraReal", GetType(String))
        dtOrdenAviso.Columns.Add("DuracionProg", GetType(String))
        dtOrdenAviso.Columns.Add("DuracionReal", GetType(String))
        dtOrdenAviso.Columns.Add("Estado", GetType(String))
        dtOrdenAviso.Columns.Add("Programa", GetType(String))
        dtOrdenAviso.Columns.Add("ProgramaReal", GetType(String))
        dtOrdenAviso.Columns.Add("TipoAvisoOrden", GetType(Integer))
        dtOrdenAviso.Columns.Add("Falla", GetType(String))
        dtOrdenAviso.Columns.Add("Cod_Soporte", GetType(String))
        dtOrdenAviso.Columns.Add("Cod_Spot", GetType(String))
        dtOrdenAviso.Columns.Add("SS_Spot", GetType(String))
        dtOrdenAviso.Columns.Add("ProgramaVisible", GetType(String))
        pOrdenAviso.Tables.Add(dtOrdenAviso)
    End Sub

    Private Sub ObtenerOrdenAviso_JJP(ByRef pOrdenAviso As DataSet)
        pOrdenAviso = New DataSet
        Dim dtOrdenAviso As New DataTable

        dtOrdenAviso.Columns.Add("Orden", GetType(String))
        dtOrdenAviso.Columns.Add("Soporte", GetType(String))
        dtOrdenAviso.Columns.Add("FechaProg", GetType(String))
        dtOrdenAviso.Columns.Add("FechaReal", GetType(String))
        dtOrdenAviso.Columns.Add("HoraProg", GetType(String))
        dtOrdenAviso.Columns.Add("HoraReal", GetType(String))
        dtOrdenAviso.Columns.Add("DuracionProg", GetType(String))
        dtOrdenAviso.Columns.Add("DuracionReal", GetType(String))
        dtOrdenAviso.Columns.Add("Estado", GetType(String))
        dtOrdenAviso.Columns.Add("Programa", GetType(String))
        dtOrdenAviso.Columns.Add("ProgramaReal", GetType(String))
        dtOrdenAviso.Columns.Add("TipoAvisoOrden", GetType(Integer))
        dtOrdenAviso.Columns.Add("Falla", GetType(String))
        dtOrdenAviso.Columns.Add("Cod_Soporte", GetType(String))
        dtOrdenAviso.Columns.Add("Cod_Spot", GetType(String))
        dtOrdenAviso.Columns.Add("SS_Spot", GetType(String))
        dtOrdenAviso.Columns.Add("ProgramaVisible", GetType(String))
        dtOrdenAviso.Columns.Add("Material", GetType(String))
        dtOrdenAviso.Columns.Add("Tema", GetType(String))
        dtOrdenAviso.Columns.Add("Posicion", GetType(String))
        dtOrdenAviso.Columns.Add("AvisosBloque", GetType(String))
        dtOrdenAviso.Columns.Add("Contrato", GetType(String))
        pOrdenAviso.Tables.Add(dtOrdenAviso)
    End Sub

    Private Sub InsertarOrdenAviso(ByRef pOrdenAviso As DataSet, _
                                   ByVal pTipoAvisoOrden As Integer, _
                                   ByVal pFalla As String, _
                                   ByVal pOrden As String, _
                                   ByVal pSoporte As String, _
                                   ByVal pFechaProg As String, _
                                   ByVal pFechaReal As String, _
                                   ByVal pHoraProg As String, _
                                   ByVal pHoraReal As String, _
                                   ByVal pDuracionProg As String, _
                                   ByVal pDuracionReal As String, _
                                   ByVal pEstado As String, _
                                   ByVal pPrograma As String, _
                                   ByVal pProgramaReal As String, _
                                   ByVal pCod_Soporte As String, _
                                   ByVal pCod_Sopt As String, _
                                   ByVal pSS_Spot As String, _
                                   ByVal pProgramaVisible As String)

        Dim drOrdenAviso As DataRow

        drOrdenAviso = pOrdenAviso.Tables(0).NewRow
        drOrdenAviso("Orden") = pOrden
        drOrdenAviso("Soporte") = pSoporte
        drOrdenAviso("FechaProg") = pFechaProg
        drOrdenAviso("FechaReal") = pFechaReal
        drOrdenAviso("HoraProg") = pHoraProg
        drOrdenAviso("HoraReal") = pHoraReal
        drOrdenAviso("DuracionProg") = pDuracionProg
        drOrdenAviso("DuracionReal") = pDuracionReal
        drOrdenAviso("Estado") = pEstado
        drOrdenAviso("Programa") = pPrograma
        drOrdenAviso("ProgramaReal") = pProgramaReal
        drOrdenAviso("TipoAvisoOrden") = pTipoAvisoOrden
        drOrdenAviso("Falla") = pFalla
        drOrdenAviso("Cod_Soporte") = pCod_Soporte
        drOrdenAviso("Cod_Spot") = pCod_Sopt
        drOrdenAviso("SS_Spot") = pSS_Spot
        drOrdenAviso("ProgramaVisible") = pProgramaVisible

        pOrdenAviso.Tables(0).Rows.Add(drOrdenAviso)
    End Sub

    Private Sub InsertarOrdenAviso_JJP(ByRef pOrdenAviso As DataSet, _
                                   ByVal pTipoAvisoOrden As Integer, _
                                   ByVal pFalla As String, _
                                   ByVal pOrden As String, _
                                   ByVal pSoporte As String, _
                                   ByVal pFechaProg As String, _
                                   ByVal pFechaReal As String, _
                                   ByVal pHoraProg As String, _
                                   ByVal pHoraReal As String, _
                                   ByVal pDuracionProg As String, _
                                   ByVal pDuracionReal As String, _
                                   ByVal pEstado As String, _
                                   ByVal pPrograma As String, _
                                   ByVal pProgramaReal As String, _
                                   ByVal pCod_Soporte As String, _
                                   ByVal pCod_Sopt As String, _
                                   ByVal pSS_Spot As String, _
                                   ByVal pProgramaVisible As String, _
                                   ByVal pMaterial As String, _
                                   ByVal pTema As String, _
                                   ByVal pPosicion As String, _
                                   ByVal pAvisosBloque As String, _
                                   ByVal pContrato As String)

        Dim drOrdenAviso As DataRow

        drOrdenAviso = pOrdenAviso.Tables(0).NewRow
        drOrdenAviso("Orden") = pOrden
        drOrdenAviso("Soporte") = pSoporte
        drOrdenAviso("FechaProg") = pFechaProg
        drOrdenAviso("FechaReal") = pFechaReal
        drOrdenAviso("HoraProg") = pHoraProg
        drOrdenAviso("HoraReal") = pHoraReal
        drOrdenAviso("DuracionProg") = pDuracionProg
        drOrdenAviso("DuracionReal") = pDuracionReal
        drOrdenAviso("Estado") = pEstado
        drOrdenAviso("Programa") = pPrograma
        drOrdenAviso("ProgramaReal") = pProgramaReal
        drOrdenAviso("TipoAvisoOrden") = pTipoAvisoOrden
        drOrdenAviso("Falla") = pFalla
        drOrdenAviso("Cod_Soporte") = pCod_Soporte
        drOrdenAviso("Cod_Spot") = pCod_Sopt
        drOrdenAviso("SS_Spot") = pSS_Spot
        drOrdenAviso("ProgramaVisible") = pProgramaVisible
        drOrdenAviso("Material") = pMaterial
        drOrdenAviso("Tema") = pTema
        drOrdenAviso("Posicion") = pPosicion
        drOrdenAviso("AvisosBloque") = pAvisosBloque
        drOrdenAviso("Contrato") = pContrato

        pOrdenAviso.Tables(0).Rows.Add(drOrdenAviso)
    End Sub


    Private Sub LimpiarDatos()
        Dim dsOrdenAviso As DataSet
        Dim dsAvisosConfirmados As DataSet
        txtCliente.Text = String.Empty
        TxtProducto.Text = String.Empty
        Call ObtenerOrdenAviso_JJP(dsOrdenAviso)
        'Call ObtenerOrdenAviso(dsOrdenAviso)
        ugOrdenAviso.DataSource = dsOrdenAviso
        ugOrdenAviso.DataBind()
        Call ObtenerOrdenAviso_JJP(dsAvisosConfirmados)
        'Call ObtenerOrdenAviso(dsAvisosConfirmados)
        ugAvisosConfirmados.DataSource = dsAvisosConfirmados
        ugAvisosConfirmados.DataBind()
    End Sub

    Private Sub RelacionarOrdenAviso()
        Dim dsOrdenAviso As DataSet
        Dim TipoAviso1, TipoAviso2, TipoAvisoOrden, Index1, Index2 As Integer
        Dim Falla, FechaProg, FechaReal, CodOrden, DuracionProg, DuracionReal, Soporte, HoraProg, HoraReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible As String

        If ugOrdenAviso.Selected.Rows.Count <> 2 Then
            Mensaje("Debe seleccionar dos registros a relacionar.")
            Exit Sub
        End If

        TipoAviso1 = ugOrdenAviso.Selected.Rows(0).Cells("TipoAvisoOrden").Value
        TipoAviso2 = ugOrdenAviso.Selected.Rows(1).Cells("TipoAvisoOrden").Value
        Falla = String.Empty
        If TipoAviso1 = 0 OrElse TipoAviso2 = 0 OrElse TipoAviso1 = TipoAviso2 Then
            Mensaje("Los registros seleccionados no se pueden relacionar.")
            Exit Sub
        End If

        For Each RowSeleccionada As UltraGridRow In ugOrdenAviso.Selected.Rows
            If Convert.ToInt32(RowSeleccionada.Cells("TipoAvisoOrden").Value) = 1 Then
                CodOrden = RowSeleccionada.Cells("Orden").Value
                Soporte = RowSeleccionada.Cells("Soporte").Value
                FechaProg = RowSeleccionada.Cells("FechaProg").Value
                HoraProg = RowSeleccionada.Cells("HoraProg").Value
                DuracionProg = RowSeleccionada.Cells("DuracionProg").Value
                Programa = RowSeleccionada.Cells("Programa").Value
                If RowSeleccionada.Cells("Falla").Value <> String.Empty Then
                    Falla = RowSeleccionada.Cells("Falla").Value
                End If
                Index1 = RowSeleccionada.Index
            Else
                FechaReal = RowSeleccionada.Cells("FechaReal").Value
                HoraReal = RowSeleccionada.Cells("HoraReal").Value
                DuracionReal = RowSeleccionada.Cells("DuracionReal").Value
                ProgramaReal = RowSeleccionada.Cells("ProgramaReal").Value
                Cod_Soporte = RowSeleccionada.Cells("Cod_Soporte").Value
                Cod_Spot = RowSeleccionada.Cells("Cod_Spot").Value
                SS_Spot = RowSeleccionada.Cells("SS_Spot").Value
                ProgramaVisible = RowSeleccionada.Cells("ProgramaReal").Value
                If RowSeleccionada.Cells("Falla").Value <> String.Empty Then
                    Falla = RowSeleccionada.Cells("Falla").Value
                End If
                Index2 = RowSeleccionada.Index
            End If
        Next
        TipoAvisoOrden = 0

        If DuracionProg = DuracionReal Then
            If Falla = String.Empty Then
                Estado = "OK"
            Else
                Estado = "FALLADO"
            End If
        Else
            If Falla = String.Empty Then
                Estado = "DIFIEREN DURACION"
            Else
                Estado = "FALLADO"
            End If
        End If

        If Index1 > Index2 Then
            ugOrdenAviso.Rows(Index1).Delete(False)
            ugOrdenAviso.Rows(Index2).Delete(False)
        Else
            ugOrdenAviso.Rows(Index2).Delete(False)
            ugOrdenAviso.Rows(Index1).Delete(False)
        End If

        dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)
        Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible)
        Call AvisosOrdenadoBind(dsOrdenAviso)

        If ugOrdenAviso.Rows.Count >= Index1 Then
            ugOrdenAviso.Selected.Rows.Clear()
            ugOrdenAviso.ActiveRow = ugOrdenAviso.Rows(Index1)
            ugOrdenAviso.Rows(Index1).Selected = True
        End If
    End Sub

    Private Sub DesvincularOrdenAviso()
        Dim dsOrdenAviso As DataSet
        Dim TipoAviso, TipoAvisoOrden1, TipoAvisoOrden2, Index As Integer
        Dim RowSeleccionada As UltraGridRow
        Dim Falla1, FechaProg1, FechaReal1, CodOrden1, DuracionProg1, DuracionReal1, Soporte1, HoraProg1, HoraReal1, Estado1, Programa1, ProgramaReal1, Cod_Soporte1, Cod_Spot1, SS_Spot1, ProgramaVisible1 As String
        Dim Falla2, FechaProg2, FechaReal2, CodOrden2, DuracionProg2, DuracionReal2, Soporte2, HoraProg2, HoraReal2, Estado2, Programa2, ProgramaReal2, Cod_Soporte2, Cod_Spot2, SS_Spot2, ProgramaVisible2 As String

        If ugOrdenAviso.Selected.Rows.Count <> 1 Then
            Mensaje("Debe seleccionar solo un registro a desvincular.")
            Exit Sub
        End If

        TipoAviso = ugOrdenAviso.Selected.Rows(0).Cells("TipoAvisoOrden").Value
        If TipoAviso <> 0 Then
            Mensaje("El registro seleccionado no se puede desvincular.")
            Exit Sub
        End If

        RowSeleccionada = ugOrdenAviso.Selected.Rows(0)
        Index = RowSeleccionada.Index

        CodOrden1 = RowSeleccionada.Cells("Orden").Value
        Soporte1 = RowSeleccionada.Cells("Soporte").Value
        FechaProg1 = RowSeleccionada.Cells("FechaProg").Value
        FechaReal1 = String.Empty
        HoraProg1 = RowSeleccionada.Cells("HoraProg").Value
        HoraReal1 = String.Empty
        DuracionProg1 = RowSeleccionada.Cells("DuracionProg").Value
        DuracionReal1 = String.Empty
        Estado1 = "SOLO SIGEME"
        Programa1 = RowSeleccionada.Cells("Programa").Value
        ProgramaReal1 = String.Empty
        TipoAvisoOrden1 = 1
        Falla1 = RowSeleccionada.Cells("Falla").Value
        Cod_Soporte1 = RowSeleccionada.Cells("Cod_Soporte").Value
        Cod_Spot1 = String.Empty
        SS_Spot1 = String.Empty
        ProgramaVisible1 = RowSeleccionada.Cells("Programa").Value

        CodOrden2 = String.Empty
        Soporte2 = RowSeleccionada.Cells("Soporte").Value
        FechaProg2 = String.Empty
        FechaReal2 = RowSeleccionada.Cells("FechaReal").Value
        HoraProg2 = String.Empty
        HoraReal2 = RowSeleccionada.Cells("HoraReal").Value
        DuracionProg2 = String.Empty
        DuracionReal2 = RowSeleccionada.Cells("DuracionReal").Value
        Estado2 = "FTE EXT"
        Programa2 = String.Empty
        ProgramaReal2 = RowSeleccionada.Cells("ProgramaReal").Value
        TipoAvisoOrden2 = 2
        Falla2 = RowSeleccionada.Cells("Falla").Value
        Cod_Soporte2 = RowSeleccionada.Cells("Cod_Soporte").Value
        Cod_Spot2 = RowSeleccionada.Cells("Cod_Spot").Value
        SS_Spot2 = RowSeleccionada.Cells("SS_Spot").Value
        ProgramaVisible2 = RowSeleccionada.Cells("ProgramaReal").Value

        ugOrdenAviso.Rows(Index).Delete(False)
        dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)
        Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden1, Falla1, CodOrden1, Soporte1, FechaProg1, FechaReal1, HoraProg1, HoraReal1, DuracionProg1, DuracionReal1, Estado1, Programa1, ProgramaReal1, Cod_Soporte1, Cod_Spot1, SS_Spot1, ProgramaVisible1)
        Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden2, Falla2, CodOrden2, Soporte2, FechaProg2, FechaReal2, HoraProg2, HoraReal2, DuracionProg2, DuracionReal2, Estado2, Programa2, ProgramaReal2, Cod_Soporte2, Cod_Spot2, SS_Spot2, ProgramaVisible2)
        Call AvisosOrdenadoBind(dsOrdenAviso)
    End Sub

    Private Sub AgregarOrdenAviso()
        Dim dsAvisosConfirmados As DataSet
        Dim drAvisosConfirmados As DataRow
        Dim TipoAviso, CantidadSeleccionados As Integer
        Dim Seleccionados As New SortedList

        If ugOrdenAviso.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un registro a agregar.")
            Exit Sub
        End If

        For Each RowSeleccionada As UltraGridRow In ugOrdenAviso.Selected.Rows
            TipoAviso = RowSeleccionada.Cells("TipoAvisoOrden").Value
            If TipoAviso <> 0 AndAlso TipoAviso <> 1 Then
                Mensaje("Existen registros seleccionados que no pueden ser agregados.")
                Exit Sub
            End If
        Next

        dsAvisosConfirmados = CType(ugAvisosConfirmados.DataSource, DataSet)

        For Each RowSeleccionada As UltraGridRow In ugOrdenAviso.Selected.Rows
            drAvisosConfirmados = dsAvisosConfirmados.Tables(0).NewRow
            For Each Columns As DataColumn In dsAvisosConfirmados.Tables(0).Columns
                drAvisosConfirmados(Columns.ColumnName) = RowSeleccionada.Cells(Columns.ColumnName).Value
            Next
            dsAvisosConfirmados.Tables(0).Rows.Add(drAvisosConfirmados)
            If Not Seleccionados.ContainsKey(RowSeleccionada.Index) Then
                Seleccionados.Add(RowSeleccionada.Index, RowSeleccionada.Index)
            End If
        Next

        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            ugOrdenAviso.Rows(Seleccionados.GetKey(Index)).Delete(False)
        Next

        ugAvisosConfirmados.DataSource = dsAvisosConfirmados
        ugAvisosConfirmados.DataBind()
        If dsAvisosConfirmados.Tables(0).Rows.Count > 0 Then
            ugAvisosConfirmados.ActiveRow = ugAvisosConfirmados.Rows(0)
            ugAvisosConfirmados.Rows(0).Selected = True
        End If
        Call SetearCantidadAgregados()
    End Sub

    Private Sub EliminarOrdenAviso()
        Dim dsOrdenAviso As DataSet
        Dim drOrdenAviso As DataRow
        Dim CantidadSeleccionados As Integer
        Dim Seleccionados As New SortedList

        If ugAvisosConfirmados.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un registro a eliminar.")
            Exit Sub
        End If

        dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)

        For Each RowSeleccionada As UltraGridRow In ugAvisosConfirmados.Selected.Rows
            drOrdenAviso = dsOrdenAviso.Tables(0).NewRow
            For Each Columns As DataColumn In dsOrdenAviso.Tables(0).Columns
                drOrdenAviso(Columns.ColumnName) = RowSeleccionada.Cells(Columns.ColumnName).Value
            Next
            dsOrdenAviso.Tables(0).Rows.Add(drOrdenAviso)
            If Not Seleccionados.ContainsKey(RowSeleccionada.Index) Then
                Seleccionados.Add(RowSeleccionada.Index, RowSeleccionada.Index)
            End If
        Next

        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            ugAvisosConfirmados.Rows(Seleccionados.GetKey(Index)).Delete(False)
        Next

        Call AvisosOrdenadoBind(dsOrdenAviso)
        Call SetearCantidadAgregados()
    End Sub

    Private Sub DesconfirmarOrdenAviso()
        Dim dsAvisosConfirmados As DataSet
        Dim ControlMacheo As New Control_Macheo
        Dim Cod_Orden As Double
        Dim Fec_Confirmacion, Fec_Aparicion As DateTime
        Dim Hora, Minuto, Ind_Diferencia, Version As Integer
        Dim Usuario, Aplicativo, Cod_Soporte, Cod_Spot, SS_Spot, Hora_Spot As String
        Dim HoraSplit() As String
        Dim lAvisoConfirmado As New List(Of AvisoConfirmado)
        Dim avisoC As AvisoConfirmado

        If ugAvisosConfirmados.Rows.Count <= 0 Then
            Mensaje("No existen registros cargados para desconfirmar.")
            Exit Sub
        End If

        dsAvisosConfirmados = CType(ugAvisosConfirmados.DataSource, DataSet)
        If Not dsAvisosConfirmados Is Nothing AndAlso Not dsAvisosConfirmados.Tables(0) Is Nothing AndAlso dsAvisosConfirmados.Tables(0).Rows.Count > 0 Then

            For Each drAvisosConfirmados As DataRow In dsAvisosConfirmados.Tables(0).Rows
                avisoC = New AvisoConfirmado

                Cod_Orden = Convert.ToDouble(drAvisosConfirmados("Orden"))
                avisoC.CodigoOrden = Cod_Orden

                lAvisoConfirmado.Add(avisoC)

                'ControlMacheo.DesconfirmarOrden(Cod_Orden)

            Next

            If lAvisoConfirmado.Count > 0 Then
                Dim resultado As String
                resultado = ControlMacheo.DesconfirmarAvisos(lAvisoConfirmado)
                If Not String.IsNullOrEmpty(resultado) Then
                    Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
                    Exit Sub
                End If
            End If
            'Call ObtenerOrdenAviso(dsAvisosConfirmados)
            dsAvisosConfirmados.Tables(0).Clear()
            ugAvisosConfirmados.DataSource = dsAvisosConfirmados
            ugAvisosConfirmados.DataBind()
            Mensaje("La operación concluyó exitosamente.")
            Call SetearCantidadAgregados()
        End If
    End Sub

    Private Sub MarcarAvisosCaidos()
        Dim TipoAviso, CantidadSeleccionados As Integer
        Dim Seleccionados As New SortedList
        Dim ControlMacheo As New Control_Macheo
        Dim Id_Presupuesto, Cod_Orden As Integer

        If ugOrdenAviso.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un registro a marcar como Aviso Caido.")
            Exit Sub
        End If

        For Each RowSeleccionada As UltraGridRow In ugOrdenAviso.Selected.Rows
            TipoAviso = RowSeleccionada.Cells("TipoAvisoOrden").Value
            If TipoAviso <> 1 Then
                Mensaje("Existen registros seleccionados que no pueden ser marcados como Aviso Caido.")
                Exit Sub
            End If
        Next

        For Each RowSeleccionada As UltraGridRow In ugOrdenAviso.Selected.Rows
            Id_Presupuesto = Convert.ToDouble(txtPresupuesto.Text.Trim)
            Cod_Orden = RowSeleccionada.Cells("Orden").Value
            Call ControlMacheo.AgregarAvisoCaido(Id_Presupuesto, Cod_Orden, Activo.CodUsuarioMms, Now, Activo.IDCompaniaMMS)
            If Not Seleccionados.ContainsKey(RowSeleccionada.Index) Then
                Seleccionados.Add(RowSeleccionada.Index, RowSeleccionada.Index)
            End If
        Next

        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            ugOrdenAviso.Rows(Seleccionados.GetKey(Index)).Delete(False)
        Next
    End Sub

    Private Sub MostrarAvisosCaidos()
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        If Presupuesto <> String.Empty AndAlso Convert.ToDouble(Presupuesto) > 0 Then
            Dim AvisoCaido As New frmAvisoCaido
            AvisoCaido.Presupuesto = Convert.ToDouble(Presupuesto)
            AvisoCaido.ShowDialog()
            If AvisoCaido.AvisosRstaurados Then
                Call LimpiarDatos()
                Call ObtenerOrdenesAvisos(Convert.ToDouble(Presupuesto))
            End If
        Else
            Mensaje("Debe ingresar un Número de Presupuesto.")
        End If
    End Sub

    Private Sub Imprimir(ByVal pOrden As Impresion)
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        If Presupuesto = String.Empty OrElse Convert.ToDouble(Presupuesto) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
        Else
            Dim FOne As New frmFormulaOne
            Me.Cursor = Cursors.WaitCursor
            Call FOne.ReporteAvisosMacheados(Convert.ToDouble(Presupuesto), pOrden, 1)
            FOne.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub AbrirClienteExterno()
        Dim ClienteExterno As New frmABMClienteExterno
        ClienteExterno.ShowDialog()
    End Sub

    Private Sub SetearCantidadAgregados()
        Dim Cantidad As New StringBuilder
        Dim CantidadDesconfirmar As Double = ugAvisosConfirmados.Rows.Count
        If CantidadDesconfirmar > 0 Then
            Cantidad.Append("                                                                                                    ")
            Cantidad.Append("                                                                                                    ")
            Cantidad.Append("Cantidad a Desconfirmar: ")
            Cantidad.Append(CantidadDesconfirmar)
        End If
        UltraToolbarsManager3.Toolbars(0).Tools("CantidadRegistros").SharedProps.Caption = Cantidad.ToString
    End Sub

    Private Sub BusquedaPresupuesto()
        'Dim Presupuesto As Double
        'Dim PresupuestoPendiente As New frmPresupuestosPendientes
        'PresupuestoPendiente.ShowDialog()
        'Presupuesto = PresupuestoPendiente.Presupuesto
        'If Presupuesto > 0 Then
        '    Call LimpiarDatos()
        '    txtPresupuesto.Text = Presupuesto
        '    cboTipoAviso.SelectedIndex = 0
        '    Call ObtenerOrdenesAvisos(Convert.ToDouble(Presupuesto))
        '    If ugOrdenAviso.Rows.Count <= 0 Then
        '        Mensaje("No existen registros para el presupuesto ingresado.")
        '    End If
        'End If
    End Sub
#End Region

    Private Sub ugOrdenAviso_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ugOrdenAviso.InitializeLayout

    End Sub
End Class

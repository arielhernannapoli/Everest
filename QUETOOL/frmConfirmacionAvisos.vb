Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.Printing
Imports MSL.Maestros
Imports HM.Contratos.Entidad
Imports HM.Contratos.Entidad.Campanas
Imports HM.Contratos.Entidad.Soportes
Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports System.Collections.Generic


Public Class frmConfirmacionAvisos
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
    Friend WithEvents cboTipoAviso As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblTipoAviso As System.Windows.Forms.Label
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
    Friend WithEvents txtTipoSoporte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSegPond As QUETOOL.txtTexto
    Friend WithEvents btnPresupuesto As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar3 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarPantalla")
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Blanquear")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Imprimir")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ClienteExterno")
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BusquedaPresupuesto")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Blanquear")
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionSoporte")
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionFecha")
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Imprimir")
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionSoporte")
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionFecha")
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisosMonitor")
        Dim ButtonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionControl")
        Dim ButtonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ClienteExterno")
        Dim ButtonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BusquedaPresupuesto")
        Dim ButtonTool39 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisosMonitor")
        Dim ButtonTool40 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ImpresionControl")
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
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato", 19)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosicionComercial", 20)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AvisoComercial", 21)
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
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarGrillaConfirmados")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Confirmar")
        Dim LabelTool1 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("CantidadRegistros")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Confirmar")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupAvisoConfirmado")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarPopup")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarPopup")
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
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato", 19)
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosicionComercial", 20)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AvisoComercial", 21)
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
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarGrillaPrincipal")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Relacionar")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desvincular")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaido")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MostrarAvisoCaido")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Relacionar")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desvincular")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupOrdenAviso")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarPopup")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("RelacionarPopup")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("DesvincularPopup")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaidoPopup")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarPopup")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("RelacionarPopup")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("DesvincularPopup")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaido")
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AvisoCaidoPopup")
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MostrarAvisoCaido")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmacionAvisos))
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
        Me.TxtSegPond = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTipoSoporte = New System.Windows.Forms.TextBox
        Me.btnPresupuesto = New Infragistics.Win.Misc.UltraButton
        Me.cboTipoAviso = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblTipoAviso = New System.Windows.Forms.Label
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
        CType(Me.cboTipoAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.LockToolbars = True
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        UltraToolbar3.DockedColumn = 0
        UltraToolbar3.DockedRow = 0
        UltraToolbar3.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar3.Text = "uToolbarPantalla"
        UltraToolbar3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool25, PopupMenuTool3, ButtonTool26, ButtonTool27, ButtonTool28})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar3})
        ButtonTool29.SharedProps.Caption = "Blanquear"
        ButtonTool30.SharedProps.Caption = "Salir"
        ButtonTool31.SharedProps.Caption = "Por Soporte"
        ButtonTool32.SharedProps.Caption = "Por Fecha"
        PopupMenuTool4.SharedProps.Caption = "Imprimir"
        PopupMenuTool4.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool33, ButtonTool34, ButtonTool35, ButtonTool36})
        ButtonTool37.SharedProps.Caption = "Cliente Externo"
        ButtonTool38.SharedProps.Caption = "Busqueda Presupuesto"
        ButtonTool39.SharedProps.Caption = "Avisos Monitor"
        ButtonTool40.SharedProps.Caption = "Por Control"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool29, ButtonTool30, ButtonTool31, ButtonTool32, PopupMenuTool4, ButtonTool37, ButtonTool38, ButtonTool39, ButtonTool40})
        '
        'frmConfirmacionAvisos_Fill_Panel
        '
        Me.frmConfirmacionAvisos_Fill_Panel.Controls.Add(Me.pnlGrillas)
        Me.frmConfirmacionAvisos_Fill_Panel.Controls.Add(Me.pnlFiltro)
        Me.frmConfirmacionAvisos_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmConfirmacionAvisos_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmConfirmacionAvisos_Fill_Panel.Location = New System.Drawing.Point(0, 24)
        Me.frmConfirmacionAvisos_Fill_Panel.Name = "frmConfirmacionAvisos_Fill_Panel"
        Me.frmConfirmacionAvisos_Fill_Panel.Size = New System.Drawing.Size(1208, 651)
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
        Me.pnlGrillas.Size = New System.Drawing.Size(1208, 595)
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
        Me.pnlGrillaConfirmados.Size = New System.Drawing.Size(1208, 300)
        Me.pnlGrillaConfirmados.TabIndex = 2
        '
        'pnlGrillaConfirmados_Fill_Panel
        '
        Me.pnlGrillaConfirmados_Fill_Panel.Controls.Add(Me.ugAvisosConfirmados)
        Me.pnlGrillaConfirmados_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGrillaConfirmados_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillaConfirmados_Fill_Panel.Location = New System.Drawing.Point(0, 24)
        Me.pnlGrillaConfirmados_Fill_Panel.Name = "pnlGrillaConfirmados_Fill_Panel"
        Me.pnlGrillaConfirmados_Fill_Panel.Size = New System.Drawing.Size(1208, 276)
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
        UltraGridColumn1.Width = 72
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
        UltraGridColumn4.Width = 84
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.Caption = "Hora Prog."
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 40
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.Header.Caption = "Hora Real"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 40
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn7.CellAppearance = Appearance7
        UltraGridColumn7.Header.Caption = "Dur. Prog."
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 40
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn8.CellAppearance = Appearance8
        UltraGridColumn8.Header.Caption = "Dur. Real"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 40
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 90
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 190
        UltraGridColumn11.Header.Caption = "Programa Real"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 190
        UltraGridColumn12.DataType = GetType(Integer)
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
        UltraGridColumn17.Width = 380
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "Posicion Comercial"
        UltraGridColumn21.Header.VisiblePosition = 19
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Aviso Comercial"
        UltraGridColumn22.Header.VisiblePosition = 20
        UltraGridColumn22.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand1.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand1.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand1.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand1.Override.HeaderAppearance = Appearance9
        UltraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugAvisosConfirmados.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugAvisosConfirmados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugAvisosConfirmados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
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
        Me.ugAvisosConfirmados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
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
        Me.ugAvisosConfirmados.Size = New System.Drawing.Size(1208, 276)
        Me.ugAvisosConfirmados.TabIndex = 4
        Me.ugAvisosConfirmados.TabStop = False
        '
        '_pnlGrillaConfirmados_Toolbars_Dock_Area_Left
        '
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 24)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.Name = "_pnlGrillaConfirmados_Toolbars_Dock_Area_Left"
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 276)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager3
        '
        'UltraToolbarsManager3
        '
        Me.UltraToolbarsManager3.DesignerFlags = 1
        Me.UltraToolbarsManager3.DockWithinContainer = Me.pnlGrillaConfirmados
        Me.UltraToolbarsManager3.LockToolbars = True
        Me.UltraToolbarsManager3.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar1.Text = "uToolbarGrillaConfirmados"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, LabelTool1})
        Me.UltraToolbarsManager3.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool3.SharedProps.Caption = "Eliminar"
        ButtonTool4.SharedProps.Caption = "Confirmar"
        PopupMenuTool1.SharedProps.Caption = "PopupAvisoConfirmado"
        PopupMenuTool1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5})
        ButtonTool6.SharedProps.Caption = "Eliminar"
        LabelTool2.SharedProps.Caption = "Cantidad :"
        Me.UltraToolbarsManager3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4, PopupMenuTool1, ButtonTool6, LabelTool2})
        '
        '_pnlGrillaConfirmados_Toolbars_Dock_Area_Right
        '
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1208, 24)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.Name = "_pnlGrillaConfirmados_Toolbars_Dock_Area_Right"
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 276)
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
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1208, 24)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager3
        '
        '_pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom
        '
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 300)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.Name = "_pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom"
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1208, 0)
        Me._pnlGrillaConfirmados_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager3
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 292)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1208, 3)
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
        Me.pnlGrillaPrincipal.Size = New System.Drawing.Size(1208, 292)
        Me.pnlGrillaPrincipal.TabIndex = 0
        '
        'pnlGrillaPrincipal_Fill_Panel
        '
        Me.pnlGrillaPrincipal_Fill_Panel.Controls.Add(Me.ugOrdenAviso)
        Me.pnlGrillaPrincipal_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGrillaPrincipal_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillaPrincipal_Fill_Panel.Location = New System.Drawing.Point(0, 24)
        Me.pnlGrillaPrincipal_Fill_Panel.Name = "pnlGrillaPrincipal_Fill_Panel"
        Me.pnlGrillaPrincipal_Fill_Panel.Size = New System.Drawing.Size(1208, 268)
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
        UltraGridColumn28.Width = 55
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn29.CellAppearance = Appearance27
        UltraGridColumn29.Header.Caption = "Dur. Prog."
        UltraGridColumn29.Header.VisiblePosition = 6
        UltraGridColumn29.Width = 55
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn30.CellAppearance = Appearance28
        UltraGridColumn30.Header.Caption = "Dur. Real"
        UltraGridColumn30.Header.VisiblePosition = 7
        UltraGridColumn30.Width = 55
        UltraGridColumn31.Header.VisiblePosition = 8
        UltraGridColumn31.Width = 90
        UltraGridColumn32.Header.VisiblePosition = 9
        UltraGridColumn32.Width = 190
        UltraGridColumn33.Header.Caption = "Programa Real"
        UltraGridColumn33.Header.VisiblePosition = 10
        UltraGridColumn33.Width = 190
        UltraGridColumn34.DataType = GetType(Integer)
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
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn42.CellAppearance = Appearance29
        UltraGridColumn42.Header.VisiblePosition = 21
        UltraGridColumn42.Width = 80
        UltraGridColumn43.Header.Caption = "Posicion Comercial"
        UltraGridColumn43.Header.VisiblePosition = 19
        UltraGridColumn44.Header.Caption = "Avisos Comerciales"
        UltraGridColumn44.Header.VisiblePosition = 20
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        UltraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand2.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand2.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand2.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand2.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand2.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand2.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand2.Override.HeaderAppearance = Appearance30
        UltraGridBand2.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugOrdenAviso.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugOrdenAviso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugOrdenAviso.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
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
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
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
        Me.ugOrdenAviso.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
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
        Me.ugOrdenAviso.Size = New System.Drawing.Size(1208, 268)
        Me.ugOrdenAviso.TabIndex = 2
        Me.ugOrdenAviso.TabStop = False
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Left
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 24)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Left"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 268)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager2
        '
        'UltraToolbarsManager2
        '
        Me.UltraToolbarsManager2.DesignerFlags = 1
        Me.UltraToolbarsManager2.DockWithinContainer = Me.pnlGrillaPrincipal
        Me.UltraToolbarsManager2.LockToolbars = True
        Me.UltraToolbarsManager2.ShowFullMenusDelay = 500
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 0
        UltraToolbar2.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar2.Text = "uToolbarGrillaPrincipal"
        UltraToolbar2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11})
        Me.UltraToolbarsManager2.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        ButtonTool12.SharedProps.Caption = "Agregar"
        ButtonTool13.SharedProps.Caption = "Relacionar"
        ButtonTool13.SharedProps.ToolTipText = "Relacionar (Orden-Aviso)"
        ButtonTool14.SharedProps.Caption = "Desvincular"
        ButtonTool14.SharedProps.ToolTipText = "Desvincular (Orden-Aviso)"
        PopupMenuTool2.SharedProps.Caption = "PopupOrdenAviso"
        PopupMenuTool2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool15, ButtonTool16, ButtonTool17, ButtonTool18})
        ButtonTool19.SharedProps.Caption = "Agregar"
        ButtonTool20.SharedProps.Caption = "Relacionar"
        ButtonTool21.SharedProps.Caption = "Desvincular"
        ButtonTool22.SharedProps.Caption = "Marca Aviso Caido"
        ButtonTool22.SharedProps.ToolTipText = "Marca Aviso Caido"
        ButtonTool23.SharedProps.Caption = "Marca Aviso Caido"
        ButtonTool23.SharedProps.ToolTipText = "Marca Aviso Caido"
        ButtonTool24.SharedProps.Caption = "Ver Avisos Caidos"
        Me.UltraToolbarsManager2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool12, ButtonTool13, ButtonTool14, PopupMenuTool2, ButtonTool19, ButtonTool20, ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24})
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Right
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1208, 24)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Right"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 268)
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
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1208, 24)
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
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1208, 0)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager2
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.gbDatos)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(1208, 56)
        Me.pnlFiltro.TabIndex = 0
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.TxtSegPond)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.txtTipoSoporte)
        Me.gbDatos.Controls.Add(Me.btnPresupuesto)
        Me.gbDatos.Controls.Add(Me.cboTipoAviso)
        Me.gbDatos.Controls.Add(Me.lblTipoAviso)
        Me.gbDatos.Controls.Add(Me.TxtProducto)
        Me.gbDatos.Controls.Add(Me.lblProducto)
        Me.gbDatos.Controls.Add(Me.txtCliente)
        Me.gbDatos.Controls.Add(Me.lblCliente)
        Me.gbDatos.Controls.Add(Me.txtPresupuesto)
        Me.gbDatos.Controls.Add(Me.lblPresupuesto)
        Me.gbDatos.Location = New System.Drawing.Point(4, 3)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(1192, 43)
        Me.gbDatos.TabIndex = 16
        Me.gbDatos.TabStop = False
        '
        'TxtSegPond
        '
        Me.TxtSegPond.AcceptsReturn = True
        Me.TxtSegPond.AcceptsTab = True
        Me.TxtSegPond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSegPond.ConDecimal = False
        Me.TxtSegPond.Location = New System.Drawing.Point(609, 15)
        Me.TxtSegPond.Maximo = 0
        Me.TxtSegPond.MaxLength = 9
        Me.TxtSegPond.Name = "TxtSegPond"
        Me.TxtSegPond.Size = New System.Drawing.Size(62, 20)
        Me.TxtSegPond.SoloLetra = False
        Me.TxtSegPond.SoloNumero = True
        Me.TxtSegPond.TabIndex = 22
        Me.TxtSegPond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Segundo Ponderado :"
        '
        'txtTipoSoporte
        '
        Me.txtTipoSoporte.BackColor = System.Drawing.SystemColors.Info
        Me.txtTipoSoporte.Enabled = False
        Me.txtTipoSoporte.Location = New System.Drawing.Point(327, 15)
        Me.txtTipoSoporte.Name = "txtTipoSoporte"
        Me.txtTipoSoporte.Size = New System.Drawing.Size(159, 20)
        Me.txtTipoSoporte.TabIndex = 19
        '
        'btnPresupuesto
        '
        Appearance42.Image = CType(resources.GetObject("Appearance42.Image"), Object)
        Me.btnPresupuesto.Appearance = Appearance42
        Me.btnPresupuesto.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat
        Me.btnPresupuesto.Location = New System.Drawing.Point(683, 14)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(24, 21)
        Me.btnPresupuesto.TabIndex = 18
        '
        'cboTipoAviso
        '
        Me.cboTipoAviso.AutoSize = True
        Me.cboTipoAviso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoAviso.FlatMode = True
        Me.cboTipoAviso.Location = New System.Drawing.Point(189, 15)
        Me.cboTipoAviso.Name = "cboTipoAviso"
        Me.cboTipoAviso.Size = New System.Drawing.Size(132, 19)
        Me.cboTipoAviso.TabIndex = 5
        '
        'lblTipoAviso
        '
        Me.lblTipoAviso.AutoSize = True
        Me.lblTipoAviso.Location = New System.Drawing.Point(109, 16)
        Me.lblTipoAviso.Name = "lblTipoAviso"
        Me.lblTipoAviso.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoAviso.TabIndex = 17
        Me.lblTipoAviso.Text = "Tipo de Aviso :"
        '
        'TxtProducto
        '
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.ConDecimal = False
        Me.TxtProducto.Location = New System.Drawing.Point(986, 16)
        Me.TxtProducto.Maximo = 0
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(184, 20)
        Me.TxtProducto.SoloLetra = False
        Me.TxtProducto.SoloNumero = False
        Me.TxtProducto.TabIndex = 4
        Me.TxtProducto.TabStop = False
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(924, 19)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(56, 13)
        Me.lblProducto.TabIndex = 15
        Me.lblProducto.Text = "Producto :"
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(767, 16)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(151, 20)
        Me.txtCliente.SoloLetra = False
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 3
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(716, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(45, 13)
        Me.lblCliente.TabIndex = 13
        Me.lblCliente.Text = "Cliente :"
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.AcceptsReturn = True
        Me.txtPresupuesto.AcceptsTab = True
        Me.txtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresupuesto.ConDecimal = False
        Me.txtPresupuesto.Location = New System.Drawing.Point(42, 14)
        Me.txtPresupuesto.Maximo = 0
        Me.txtPresupuesto.MaxLength = 9
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(62, 20)
        Me.txtPresupuesto.SoloLetra = False
        Me.txtPresupuesto.SoloNumero = True
        Me.txtPresupuesto.TabIndex = 1
        Me.txtPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(6, 16)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(35, 13)
        Me.lblPresupuesto.TabIndex = 10
        Me.lblPresupuesto.Text = "Ppto :"
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Left
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 24)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Left"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 651)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Right
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1208, 24)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Right"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 651)
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
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1208, 24)
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
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1208, 0)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'frmConfirmacionAvisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1208, 675)
        Me.Controls.Add(Me.frmConfirmacionAvisos_Fill_Panel)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConfirmacionAvisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmación de Avisos"
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
        Me.gbDatos.PerformLayout()
        CType(Me.cboTipoAviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private OrdenAvisoPoint As New Point
    Private AvisoConfirmadoPoint As New Point
    Private Enum Impresion As Integer
        Soporte = 0
        Fecha = 1
        Control = 2
    End Enum

    Private CodTipoSoporte, CodMedio As Integer
    Dim mPresupuesto As New PresupuestoEntidad
    Dim GrillaFormato As New GrillaFormato
#End Region

#Region "Eventos"

    Private Sub frmConfirmacionAvisos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub frmConfirmacionAvisos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ugAvisosConfirmados.Rows.Count > 0 Then
            If MessageBox.Show("Hay avisos relacionados que no fueron confirmados, ¿Desea perder esta información?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub
    Private Sub frmConfirmacionOrdenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Call SetearCantidadAgregados()
        Call CargaTipoAviso()
        Call CargaTipoSoporte()
    End Sub

    Private Sub btnPresupuesto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPresupuesto.Click
        Dim Presupuesto As String = txtPresupuesto.Text.Trim

        If ugAvisosConfirmados.Rows.Count > 0 Then
            If MessageBox.Show("Hay avisos relacionados que no fueron confirmados, ¿Desea perder esta información?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        If Presupuesto = String.Empty OrElse Convert.ToDouble(Presupuesto) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
        Else
            Call LimpiarDatos()
            mPresupuesto = ObtenerPresupuesto(Integer.Parse(Presupuesto))
            If Not mPresupuesto Is Nothing Then
                CodMedio = mPresupuesto.Subcampana.Medio.CodMedio

                Call ObtenerOrdenesAvisos(Convert.ToDouble(Presupuesto))
                If ugOrdenAviso.Rows.Count <= 0 Then
                    Mensaje("No existen registros para el presupuesto ingresado.")
                End If

            Else
                Mensaje("El presupuesto no existe")
            End If
        End If
    End Sub

    Private Sub cboTipoAviso_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoAviso.SelectionChanged
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

    Private Sub ugOrdenAviso_AfterRowFilterChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterRowFilterChangedEventArgs) Handles ugOrdenAviso.AfterRowFilterChanged


        'If e.Column.Key = "FechaProg" Then
        '    If e.NewColumnFilter.FilterConditions.Count = 0 Then
        '        ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters("FechaReal").FilterConditions.Clear()
        '    Else 'If ugOrdenAviso.DisplayLayout.ValueLists("FechaReal").FindString(e.NewColumnFilter.FilterConditions(0).CompareValue.ToString) < 0 Then
        '        ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters("FechaReal").LogicalOperator = FilterLogicalOperator.And
        '        ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters("FechaProg").LogicalOperator = FilterLogicalOperator.And
        '        e.NewColumnFilter.LogicalOperator = FilterLogicalOperator.And
        '        ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters("FechaReal").FilterConditions.Add(e.NewColumnFilter.FilterConditions(0))
        '        'If ugOrdenAviso.DisplayLayout.Rows.VisibleRowCount = 0 Then
        '        '    ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters("FechaReal").FilterConditions.Clear()
        '        '    ugOrdenAviso.DisplayLayout.RefreshFilters()

        '        'End If
        '    End If
        'End If

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

    Private Sub ugOrdenAviso_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugOrdenAviso.MouseLeave

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
                cboTipoAviso.SelectedIndex = 0
            Case "ImpresionSoporte"
                Call Imprimir(Impresion.Soporte)
            Case "ImpresionFecha"
                Call Imprimir(Impresion.Fecha)
            Case "ImpresionControl" 'AG 13/03/2013
                Call ImprimirControl(Impresion.Control)
            Case "AvisosMonitor"
                Call ImprimirAvisosMonitor(Impresion.Fecha)
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
            Case "Confirmar"
                'If ckbFacturados.Checked = True Then
                'Call ConfirmarOrdenAvisoFacturado()
                'Else
                Call ConfirmarOrdenAviso()
                'End If

        End Select
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub CargaTipoAviso()
        Dim ControlMacheo As New Control_Macheo
        Dim TipoAvisos As DataSet

        TipoAvisos = ControlMacheo.BuscarTipoSpots()
        cboTipoAviso.Items.Clear()
        cboTipoAviso.Enabled = True
        If Not TipoAvisos Is Nothing AndAlso Not TipoAvisos.Tables.Count = 0 AndAlso Not TipoAvisos.Tables(0) Is Nothing AndAlso TipoAvisos.Tables(0).Rows.Count > 0 Then
            Combo_Populate(cboTipoAviso, TipoAvisos.Tables(0))
        Else
            cboTipoAviso.Enabled = False
        End If
    End Sub

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
    'JJP - Matcheo Interior
    Private Sub CargaTipoSoporte()
        Dim ControlMacheo As New Control_Macheo

        Dim tipoSoportes As New DataTable


        'tipoSoportes = ControlMacheo.TraerTipoSoportes(1)

        'cboTipoSoporte.Items.Clear()
        'cboTipoSoporte.Enabled = True
        'If Not tipoSoportes Is Nothing AndAlso tipoSoportes.Rows.Count > 0 Then
        '    FillCombo(cboTipoSoporte, tipoSoportes)
        'Else
        '    cboTipoSoporte.Enabled = False
        'End If

        'JJP MMS
        'Dim TipoSoportes As DataSet

        'TipoSoportes = ControlMacheo.TraerTipoSoportes
        'cboTipoSoporte.Items.Clear()
        'cboTipoSoporte.Enabled = True
        'If Not TipoSoportes Is Nothing AndAlso Not TipoSoportes.Tables(0) Is Nothing AndAlso TipoSoportes.Tables(0).Rows.Count > 0 Then
        '    FillCombo(cboTipoSoporte, TipoSoportes.Tables(0))
        'Else
        '    cboTipoSoporte.Enabled = False
        'End If

    End Sub
    'JJP - Matcheo Interior
    Private Sub FillCombo(ByRef pCombo As UltraComboEditor, ByVal pobjTable As DataTable)
        Dim objItem As ValueListItem
        Dim objRow As DataRow

        For Each objRow In pobjTable.Rows
            objItem = New ValueListItem
            objItem.DataValue = objRow
            objItem.DisplayText = objRow("Descripcion").ToString.Remove(0, 10).Trim
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
        Dim Soportes, SoportesAdmedia, ProductosAdmedia As New StringBuilder
        Dim Hora As StringBuilder
        Dim ArrSoportes As New ArrayList
        Dim Cod_Cliente, Cod_Producto, TipoAviso, CantidadSoportes, Cantidad, IndexSpot, Index As Integer
        Dim ExisteCoincidiencia As Boolean
        Dim dsOrdenAviso As DataSet
        Dim ItemSoporte As ValueListItem
        Dim TableSoporte As DataTable
        Dim RowSoporte As DataRow
        Dim TipoAvisoOrden, HoraOrden, SoporteOrden As Integer
        Dim Falla, FechaProg, FechaReal, CodOrden, DuracionProg, DuracionReal, Soporte, HoraProg, HoraReal, Estado, Programa, ProgramaReal, HoraParcial, ProgramaOrden, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible, PosicionAviso As String
        'CAMPOS JJP
        Dim Material, Tema, Posicion, AvisosBloque, Contrato, tipoAvisoAdmedia, HoraFin, PosicionComercial, AvisoComercial As String
        Dim draux As DataRow()
        Dim IHoraIni, IHoraFin As Integer 'AG 11/03/2013
        Dim HoraIniTemp, HoraFinTemp As String
        '||||||||||||||

        ControlMacheo.Cod_Presupuesto = Presupuesto

        ControlMacheo.Cod_Compania = Activo.IDCompaniaMMS

        'If ckbFacturados.Checked = True Then
        ' Ordenes = ControlMacheo.BuscarOrdenesFacturadas
        ' Else
        Ordenes = ControlMacheo.BuscarOrdenes
        'End If

        'AG 07/03/2013 ++++++++++++++++++++++++++++++++
        Ordenes = ControlMacheo.ObtenerHoraInicioFinAviso(Ordenes)
        '++++++++++++++++++++++++++++++++++++++++++++

        dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)


        'AG 25/02/2013 +++++++++++++++++++++++++++++++++++++++++++++++
        Dim ObjControl As New Control_Macheo
        Dim DtSoportePermitido As New DataTable
        Dim dtResultadoOrdenes As DataTable

        If Ordenes.Tables(0).Rows.Count > 0 Then
            DtSoportePermitido = ObjControl.ObtenerSoportesPermitidos()
            dtResultadoOrdenes = SeleccionarSoportesPermitidos(Ordenes.Tables(0), DtSoportePermitido)
            Ordenes.Tables.Remove(Ordenes.Tables(0))
            Ordenes.Tables.Add(dtResultadoOrdenes)
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        If Not Ordenes Is Nothing AndAlso Not Ordenes.Tables(0) Is Nothing AndAlso Ordenes.Tables(0).Rows.Count > 0 Then
            Fecha_Desde = Convert.ToDateTime(Ordenes.Tables(0).Rows(0)("fecha_sig"))
            Fecha_Hasta = Convert.ToDateTime(Ordenes.Tables(0).Rows(Ordenes.Tables(0).Rows.Count - 1)("fecha_sig"))
            Cod_Cliente = Convert.ToInt32(Ordenes.Tables(0).Rows(0)("cli_sig"))
            Cod_Producto = Convert.ToInt32(Ordenes.Tables(0).Rows(0)("prod_sig"))
            TipoAviso = Convert.ToInt32(cboTipoAviso.SelectedItem.DataValue("Cod_Tps"))
            tipoAvisoAdmedia = cboTipoAviso.SelectedItem.DataValue("Dco_tps").ToString 'JJP - Matcheo interior
            txtCliente.Text = Ordenes.Tables(0).Rows(0)("razon_social")
            TxtProducto.Text = Ordenes.Tables(0).Rows(0)("des_producto")

            Ordenes.Tables(0).Columns.Add("inicio", GetType(Integer))
            Ordenes.Tables(0).Columns.Add("fin", GetType(Integer))
            Ordenes.Tables(0).Columns.Add("min_fin", GetType(Integer))

            draux = Activo.DTSoportesCache.Select("id_soporte = " & Ordenes.Tables(0).Rows(0)("soporte_sig") & " and id_medio = " & CodMedio)
            If Not draux Is Nothing AndAlso draux.Length > 0 Then
                txtTipoSoporte.Text = draux(0)("des_tipo_soporte")
                CodTipoSoporte = draux(0)("cod_tipo_soporte")
            End If

            For Each Orden As DataRow In Ordenes.Tables(0).Rows
                If Not ArrSoportes.Contains(Orden("soporte_sig")) Then
                    ArrSoportes.Add(Orden("soporte_sig"))
                End If
                SoporteOrden = Orden("soporte_sig")
                ProgramaOrden = Orden("programa")
                FechaOrden = Orden("fecha_sig")
                HoraOrden = Orden("hora_sig")



                'AG Codigo Anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                'Se quita debido a que ya trae en el datatable la hora fin y comienzo filtrada por el id de tarifa asociada a la orden de MMS
                'Tarifas_TV = ControlMacheo.BuscarTarifas_TV(SoporteOrden, ProgramaOrden, FechaOrden, HoraOrden)
                'If Not Tarifas_TV Is Nothing AndAlso Not Tarifas_TV.Tables(0) Is Nothing AndAlso Tarifas_TV.Tables(0).Rows.Count > 0 Then
                'Orden("inicio") = Tarifas_TV.Tables(0).Rows(0)("inicio")
                'Orden("fin") = Tarifas_TV.Tables(0).Rows(0)("fin")
                'Orden("min_fin") = Tarifas_TV.Tables(0).Rows(0)("min_fin")
                'Orden("programa") = Tarifas_TV.Tables(0).Rows(0)("programa_tv")
                'Else
                'Orden("inicio") = 0
                'Orden("fin") = 0
                'Orden("min_fin") = 0
                'IHoraFin = 0 'AG 11/03/2013
                'End If
                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Next

            CantidadSoportes = ArrSoportes.Count
            For Index = 0 To ArrSoportes.Count - 1
                Soportes.Append(ArrSoportes(Index))
                If Index < CantidadSoportes - 1 Then
                    Soportes.Append(",")
                End If
            Next

            ControlMacheo.Cod_Soporte = Soportes.ToString
            ControlMacheo.Cod_Cli = Cod_Cliente
            ControlMacheo.Cod_Prod = Cod_Producto
            Dim dsClientesNautilus, dsProductosNautilus, dsSoportesAdmedia As DataSet
            dsClientesNautilus = ControlMacheo.BuscarAr_Clientes_Sig_Nau
            dsProductosNautilus = ControlMacheo.BuscarAr_Productos_Sig_Nau
            dsSoportesAdmedia = ObtenerSoportesAdmedia(Soportes.ToString) 'ControlMacheo.BuscarAr_Soportes_Admedia(Soportes.ToString)

            ControlMacheo.Tipo_Aviso = TipoAviso
            ControlMacheo.Fecha_Desde = Fecha_Desde
            ControlMacheo.Fecha_Hasta = Fecha_Hasta

            'JJP  - 2: TV Interior
            Dim faltaDato As String = ""
            Dim dr() As DataRow

            If Not dsClientesNautilus Is Nothing AndAlso Not dsClientesNautilus.Tables(0) Is Nothing AndAlso dsClientesNautilus.Tables(0).Rows.Count > 0 Then
                dr = dsClientesNautilus.Tables(0).Select("cod_cli_sig=" & Cod_Cliente)
                If dr.Length > 0 Then
                    ControlMacheo.Cod_Cli = dr(0)("Cod_cli_nau")
                Else
                    faltaDato = "No está relacionado el cliente"
                End If
            End If

            If Not dsSoportesAdmedia Is Nothing AndAlso Not dsSoportesAdmedia.Tables(0) Is Nothing AndAlso dsSoportesAdmedia.Tables(0).Rows.Count > 0 Then

                Cantidad = dsSoportesAdmedia.Tables(0).Rows.Count
                If Cantidad <> 0 Then 'Si hay datos
                    For Index = 0 To Cantidad - 1
                        SoportesAdmedia.Append(dsSoportesAdmedia.Tables(0).Rows(Index)("cod_vehiculo_admedia"))
                        If Index < Cantidad - 1 Then
                            SoportesAdmedia.Append(",")
                        End If
                    Next
                    ControlMacheo.Cod_Soporte = SoportesAdmedia.ToString
                ElseIf Cantidad < CantidadSoportes Then
                    MessageBox.Show("Hay soportes no relacionados en la tabla SOPORTES_ADMEDIA." & vbCrLf & " Es posible que la información obtenida de Admedia esté incompleta", "Matcheo de avisos")
                Else
                    faltaDato = "No hay ningún soporte relacionado con Admedia"
                End If

            End If

            If Not dsProductosNautilus Is Nothing AndAlso Not dsProductosNautilus.Tables(0) Is Nothing AndAlso dsProductosNautilus.Tables(0).Rows.Count > 0 Then

                Cantidad = dsProductosNautilus.Tables(0).Rows.Count
                If Cantidad <> 0 Then 'Si hay datos
                    For Index = 0 To Cantidad - 1
                        ProductosAdmedia.Append(dsProductosNautilus.Tables(0).Rows(Index)("cod_prod_nau"))
                        If Index < Cantidad - 1 Then
                            ProductosAdmedia.Append(",")
                        End If
                    Next
                    ControlMacheo.Cod_Producto = ProductosAdmedia.ToString
                Else
                    faltaDato = "No hay ningún producto relacionado "
                End If
            End If

            If faltaDato.Length > 0 Then
                MessageBox.Show("Hay datos sin matchear. " & vbCrLf & faltaDato & ".", "Matcheo de avisos")
                Return
            End If

            'If cboTipoSoporte.SelectedItem.DataValue("id_tipo_soporte") = 2 Then
            'If CodTipoSoporte = 2 Then
            'Spots = ControlSpotAdmedia(ControlMacheo.TraerSpotsAdmediaInterior(2, tipoAvisoAdmedia), Fecha_Desde, Fecha_Hasta, Soportes.ToString)
            'Else
            'Spots = ControlSpotAdmedia(ControlMacheo.TraerSpotsAdmediaInterior(3, tipoAvisoAdmedia), Fecha_Desde, Fecha_Hasta, Soportes.ToString) 'ControlMacheo.BuscarSpot
            'End If
            Spots = ControlSpotAdmedia(ControlMacheo.TraerSpotsAdmedia(CodTipoSoporte, tipoAvisoAdmedia), Fecha_Desde, Fecha_Hasta, Soportes.ToString) 'ControlMacheo.BuscarSpot

            For Each Orden As DataRow In Ordenes.Tables(0).Rows
                ExisteCoincidiencia = False
                Index = 0
                Falla = String.Empty
                If Not Spots Is Nothing AndAlso Not Spots.Tables(0) Is Nothing AndAlso Spots.Tables(0).Rows.Count > 0 Then
                    Hora = New StringBuilder
                    Hora.Append(Orden("fin"))
                    Hora.Append(Orden("min_fin"))

                    'AG 11/03/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    HoraIniTemp = IIf(IsDBNull(Orden("HMDESDE")), "0", Orden("HMDESDE").ToString.Replace(":", ""))
                    IHoraIni = CInt(HoraIniTemp)
                    HoraFinTemp = IIf(IsDBNull(Orden("HMHASTA")), "0", Orden("HMHASTA").ToString.Replace(":", ""))
                    IHoraFin = CInt(HoraFinTemp)
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                    For Each Spot As DataRow In Spots.Tables(0).Rows
                        'AG Original Filtro anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        'If Spot.RowState <> DataRowState.Deleted AndAlso Convert.ToDateTime(Orden("fecha_sig")).Date = Convert.ToDateTime(Spot("fec_spt")).Date AndAlso Orden("soporte_sig") = Spot("cod_soporte") AndAlso Orden("inicio") <= Spot("hora_nau") AndAlso Hora.ToString >= Spot("hm_spt") Then
                        '    ExisteCoincidiencia = True
                        '    IndexSpot = Index
                        '    Exit For
                        'End If
                        'Index += 1
                        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                        'AG 11/03/2013 Nuevo Filtro +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        If Spot.RowState <> DataRowState.Deleted AndAlso Convert.ToDateTime(Orden("fecha_sig")).Date = Convert.ToDateTime(Spot("fec_spt")).Date AndAlso Orden("soporte_sig") = Spot("cod_soporte") AndAlso IHoraIni <= CInt(Spot("hm_spt")) AndAlso IHoraFin >= CInt(Spot("hm_spt")) Then 'AG 11/03/2013

                            'AG 22/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            If Me.TxtSegPond.Text <> "" Then
                                If Not Spots.Tables(0).Columns("Falla") Is Nothing AndAlso Not Spots.Tables(0).Rows(Index)("Falla") Is DBNull.Value Then
                                    Falla = Spots.Tables(0).Rows(Index)("Falla")
                                    If Orden("duracion_sig") = Spots.Tables(0).Rows(Index)("duracion") Then
                                        Estado = "OK - " & Falla
                                        ExisteCoincidiencia = True
                                    Else
                                        If ValidarDuracionAviso(Orden("duracion_sig").ToString, Spots.Tables(0).Rows(Index)("duracion").ToString) = False Then
                                            Estado = "DIFIEREN DURACION"
                                            ExisteCoincidiencia = True 'RELACIONA CON DIFERENCIA Resultado = Menor que el Segundo Ponderado
                                        Else
                                            ExisteCoincidiencia = False 'NO RALACIONA Resultado = Mayor que el Segundo Ponderado
                                        End If
                                    End If
                                Else
                                    If Orden("duracion_sig") = Spots.Tables(0).Rows(Index)("duracion") Then
                                        Estado = "OK"
                                        ExisteCoincidiencia = True
                                    Else
                                        If ValidarDuracionAviso(Orden("duracion_sig").ToString, Spots.Tables(0).Rows(Index)("duracion").ToString) = False Then
                                            Estado = "DIFIEREN DURACION"
                                            ExisteCoincidiencia = True 'RELACIONA CON DIFERENCIA Resultado = Menor que el Segundo Ponderado
                                        Else
                                            ExisteCoincidiencia = False 'NO RALACIONA Resultado = Mayor que el Segundo Ponderado
                                        End If
                                    End If
                                End If
                            Else
                                If Not Spots.Tables(0).Columns("Falla") Is Nothing AndAlso Not Spots.Tables(0).Rows(Index)("Falla") Is DBNull.Value Then
                                    Falla = Spots.Tables(0).Rows(Index)("Falla")
                                    If Orden("duracion_sig") = Spots.Tables(0).Rows(Index)("duracion") Then
                                        Estado = "OK - " & Falla
                                        ExisteCoincidiencia = True
                                    Else
                                        Estado = "DIFIEREN DURACION"
                                        ExisteCoincidiencia = True
                                    End If
                                Else
                                    If Orden("duracion_sig") = Spots.Tables(0).Rows(Index)("duracion") Then
                                        Estado = "OK"
                                        ExisteCoincidiencia = True
                                    Else
                                        Estado = "DIFIEREN DURACION"
                                        ExisteCoincidiencia = True
                                    End If
                                End If
                            End If
                            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            'ExisteCoincidiencia = True 'AG 22/03/2013 
                            IndexSpot = Index
                            Exit For
                        End If
                        Index += 1
                        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Next
                End If

                Hora = New StringBuilder
                HoraParcial = Orden("hora_sig")
                HoraParcial = HoraParcial.Insert(0, "0")
                HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
                Hora.Append(HoraParcial)
                Hora.Append(":")
                HoraParcial = Orden("min_sig")
                HoraParcial = HoraParcial.Insert(0, "0")
                HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
                Hora.Append(HoraParcial)
                If ExisteCoincidiencia Then
                    CodOrden = Orden("Orden")
                    Soporte = Orden("des_soporte")
                    FechaProg = Convert.ToDateTime(Orden("fecha_sig")).Date
                    FechaReal = Convert.ToDateTime(Spots.Tables(0).Rows(IndexSpot)("fec_spt")).Date
                    HoraProg = Hora.ToString
                    HoraReal = Spots.Tables(0).Rows(IndexSpot)("hm_spt")
                    HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                    DuracionProg = Orden("duracion_sig")
                    DuracionReal = Spots.Tables(0).Rows(IndexSpot)("duracion")

                    'AG Codigo Anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    'If Not Spots.Tables(0).Columns("Falla") Is Nothing AndAlso Not Spots.Tables(0).Rows(IndexSpot)("Falla") Is DBNull.Value Then
                    '    Falla = Spots.Tables(0).Rows(IndexSpot)("Falla")
                    '    'If cboTipoSoporte.SelectedItem.DataValue("id_tipo_soporte") = 2 Then
                    '    'If CodTipoSoporte = 2 Then
                    '    If Orden("duracion_sig") = Spots.Tables(0).Rows(IndexSpot)("duracion") Then
                    '        Estado = "OK - " & Falla
                    '    Else
                    '        Estado = "DIFIEREN DURACION"
                    '    End If
                    '    'Else
                    '    '   Estado = "FALLADO"
                    '    'End If
                    'Else
                    '    If Orden("duracion_sig") = Spots.Tables(0).Rows(IndexSpot)("duracion") Then
                    '        Estado = "OK"
                    '    Else
                    '        Estado = "DIFIEREN DURACION"
                    '    End If
                    'End If
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                    Programa = Orden("programa")
                    ProgramaReal = Spots.Tables(0).Rows(IndexSpot)("sprograma")
                    TipoAvisoOrden = 0
                    Cod_Soporte = Spots.Tables(0).Rows(IndexSpot)("cod_soporte")
                    Cod_Spot = Spots.Tables(0).Rows(IndexSpot)("cod_spt")
                    SS_Spot = Spots.Tables(0).Rows(IndexSpot)("ss_spt")
                    ProgramaVisible = Spots.Tables(0).Rows(IndexSpot)("sprograma")
                    Material = IIf(IsDBNull(Orden("material_sig")), "", Orden("material_sig"))
                    Tema = Spots.Tables(0).Rows(IndexSpot)("tema_nau")
                    Posicion = Spots.Tables(0).Rows(IndexSpot)("pos_bloque")
                    PosicionComercial = Spots.Tables(0).Rows(IndexSpot)("POS_COMERCIAL")
                    AvisoComercial = Spots.Tables(0).Rows(IndexSpot)("AVISO_COMERCIAL")
                    AvisosBloque = Spots.Tables(0).Rows(IndexSpot)("avisos_bloque")
                    Contrato = IIf(IsDBNull(Orden("contrato_sig")), "", Orden("contrato_sig"))
                    HoraFin = IIf(IsDBNull(Orden("HMHASTA")), "", Orden("HMHASTA")) 'AG 11/03/2013 
                    Spots.Tables(0).Rows(IndexSpot).Delete()
                Else
                    CodOrden = Orden("Orden")
                    Soporte = Orden("des_soporte")
                    FechaProg = Convert.ToDateTime(Orden("fecha_sig")).Date
                    FechaReal = String.Empty
                    HoraProg = Hora.ToString
                    HoraReal = String.Empty
                    DuracionProg = Orden("duracion_sig")
                    DuracionReal = String.Empty
                    Estado = "SOLO MMS"
                    Programa = Orden("programa")
                    ProgramaReal = String.Empty
                    TipoAvisoOrden = 1
                    Cod_Soporte = Orden("soporte_sig")
                    Cod_Spot = String.Empty
                    SS_Spot = String.Empty
                    ProgramaVisible = Orden("programa")
                    Material = IIf(IsDBNull(Orden("material_sig")), "", Orden("material_sig"))
                    Tema = String.Empty
                    Posicion = String.Empty
                    AvisosBloque = String.Empty
                    PosicionComercial = String.Empty
                    AvisoComercial = String.Empty
                    Contrato = IIf(IsDBNull(Orden("contrato_sig")), "", Orden("contrato_sig"))
                    HoraFin = IIf(IsDBNull(Orden("HMHASTA")), "", Orden("HMHASTA")) 'AG 11/03/2013   Validar si viene NULO el Datos
                End If
                Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible, Material, Tema, Posicion, AvisosBloque, Contrato, HoraFin, PosicionComercial, AvisoComercial)
                'Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible)
            Next

            If Not Spots Is Nothing AndAlso Not Spots.Tables(0) Is Nothing AndAlso Spots.Tables(0).Rows.Count > 0 Then
                For Each Spot As DataRow In Spots.Tables(0).Rows
                    If Spot.RowState <> DataRowState.Deleted Then
                        CodOrden = String.Empty
                        Soporte = Spot("des_soporte")
                        FechaProg = String.Empty
                        FechaReal = Convert.ToDateTime(Spot("fec_spt")).Date
                        HoraProg = String.Empty
                        HoraReal = Spot("hm_spt")
                        HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                        HoraReal = HoraReal.Insert(0, "0")
                        HoraReal = HoraReal.Substring(HoraReal.Length - 5)
                        DuracionProg = String.Empty
                        DuracionReal = Spot("duracion")
                        Estado = "FTE EXT"
                        Programa = String.Empty
                        ProgramaReal = Spot("sprograma")
                        TipoAvisoOrden = 2
                        If Not Spots.Tables(0).Columns("Falla") Is Nothing AndAlso Not Spot("Falla") Is DBNull.Value Then
                            Falla = Spot("Falla")
                        End If
                        Cod_Soporte = Spot("cod_soporte")
                        Cod_Spot = Spot("cod_spt")
                        SS_Spot = Spot("ss_spt")
                        ProgramaVisible = Spot("sprograma")

                        'CAMPOS JJP
                        Material = String.Empty
                        Tema = Spot("tema_nau")
                        Posicion = Spot("pos_bloque")
                        AvisosBloque = Spot("avisos_bloque")
                        PosicionComercial = Spot("POS_COMERCIAL")
                        AvisoComercial = Spot("AVISO_COMERCIAL")
                        Contrato = String.Empty
                        HoraFin = String.Empty 'AG 11/03/2013 
                        '|||||||||||||||||||||||||

                        Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible, Material, Tema, Posicion, AvisosBloque, Contrato, HoraFin, PosicionComercial, AvisoComercial)
                        ''Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible)
                    End If
                Next
            End If
        End If
        Call AvisosOrdenadoBind(dsOrdenAviso)
        ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()

        For Each columna As Infragistics.Win.UltraWinGrid.UltraGridColumn In ugOrdenAviso.DisplayLayout.Bands(0).Columns
            columna.AllowRowFiltering = DefaultableBoolean.True
        Next

        'ugOrdenAviso.DisplayLayout.Bands(0).Columns("Soporte").AllowRowFiltering = DefaultableBoolean.True
    End Sub

    Private Function ValidarDuracionAviso(ByVal DuracionAdmedia As String, ByVal DuracionTema As String) As Boolean

        Dim SPonderado As Integer = Me.TxtSegPond.Text
        Dim ResultadoDiferencia As Integer
        Dim Respuesta As Boolean

        ResultadoDiferencia = Math.Abs(CInt(DuracionAdmedia) - CInt(DuracionTema))

        If ResultadoDiferencia > 0 Then
            If ResultadoDiferencia > SPonderado Then
                Respuesta = True 'No RELACIONAR
            ElseIf ResultadoDiferencia = SPonderado Then
                Respuesta = False 'RELACIONA CON DIFERENCIA
            End If
        ElseIf ResultadoDiferencia = 0 Then
            Respuesta = False 'RELACIONA
        End If
        Return Respuesta

    End Function

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

        'AG 11/03/2013 ++++
        FormatoGrillaAvisos()
        '+++++++++++++++
    End Sub

    Private Sub ObtenerOrdenAvisoOLD(ByRef pOrdenAviso As DataSet)
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
        dtOrdenAviso.Columns.Add("Material", GetType(String))
        dtOrdenAviso.Columns.Add("Tema", GetType(String))
        'dtOrdenAviso.Columns.Add("Posicion", GetType(String)) 'CF 10/02/2014
        'dtOrdenAviso.Columns.Add("AvisosBloque", GetType(String))
        dtOrdenAviso.Columns.Add("Contrato", GetType(String))
        dtOrdenAviso.Columns.Add("HoraFin", GetType(String)) 'AG 11/03/2013 
        dtOrdenAviso.Columns.Add("PosicionComercial", GetType(String))
        dtOrdenAviso.Columns.Add("AvisoComercial", GetType(String))
        pOrdenAviso.Tables.Add(dtOrdenAviso)
    End Sub

    Private Sub InsertarOrdenAvisoOLD(ByRef pOrdenAviso As DataSet, _
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
                                   ByVal pProgramaVisible As String, _
                                   ByVal pMaterial As String, _
                                   ByVal pTema As String, _
                                   ByVal pPosicion As String, _
                                   ByVal pAvisosBloque As String, _
                                   ByVal pContrato As String, _
                                   ByVal pHoraFin As String, _
                                   ByVal PosicionComercial As String, _
                                   ByVal AvisoComercial As String)

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
        'drOrdenAviso("Posicion") = pPosicion 'CF 10/02/2014
        'drOrdenAviso("AvisosBloque") = pAvisosBloque
        drOrdenAviso("Contrato") = pContrato
        drOrdenAviso("PosicionComercial") = PosicionComercial
        drOrdenAviso("AvisoComercial") = AvisoComercial
        drOrdenAviso("HoraFin") = pHoraFin 'AG 11/03/2013 

        pOrdenAviso.Tables(0).Rows.Add(drOrdenAviso)
    End Sub


    Private Sub LimpiarDatos()
        Dim dsOrdenAviso As DataSet
        Dim dsAvisosConfirmados As DataSet
        txtCliente.Text = String.Empty
        TxtProducto.Text = String.Empty
        Call ObtenerOrdenAviso(dsOrdenAviso)
        'Call ObtenerOrdenAviso(dsOrdenAviso)
        ugOrdenAviso.DataSource = dsOrdenAviso
        ugOrdenAviso.DataBind()
        Call ObtenerOrdenAviso(dsAvisosConfirmados)
        'Call ObtenerOrdenAviso(dsAvisosConfirmados)
        ugAvisosConfirmados.DataSource = dsAvisosConfirmados
        ugAvisosConfirmados.DataBind()

        'AG 11/03/2013 +++++++++++++++++++++++
        FormatoGrillaAvisos()
        FromatoGrillaConfirmado()
        '++++++++++++++++++++++++++++++++++
    End Sub

    Private Sub FormatoGrillaAvisos()
        Dim Columna As UltraGridColumn

        With ugOrdenAviso.DisplayLayout.Bands(0)
            .Columns("HoraFin").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HoraFin").CellActivation = Activation.NoEdit
        End With
        GrillaFormato.CambiarAlineacionColumna(ugOrdenAviso, "HoraFin", Infragistics.Win.HAlign.Center)
        Listas.CambiarTituloColumna(ugOrdenAviso, "HoraFin", "Hora Fin")

        Columna = ugOrdenAviso.DisplayLayout.Bands(0).Columns("HoraFin")
        GrillaFormato.MoverColumna(Columna, 6)




    End Sub

    Private Sub FromatoGrillaConfirmado()
        Dim Columna As UltraGridColumn
        With ugAvisosConfirmados.DisplayLayout.Bands(0)
            .Columns("HoraFin").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HoraFin").CellActivation = Activation.NoEdit
        End With
        GrillaFormato.CambiarAlineacionColumna(ugAvisosConfirmados, "HoraFin", Infragistics.Win.HAlign.Center)
        Listas.CambiarTituloColumna(ugAvisosConfirmados, "HoraFin", "Hora Fin")
        Columna = ugAvisosConfirmados.DisplayLayout.Bands(0).Columns("HoraFin")
        GrillaFormato.MoverColumna(Columna, 6)
    End Sub

    Private Sub RelacionarOrdenAviso()
        'Dim dsOrdenAviso As DataSet
        'Dim TipoAviso1, TipoAviso2, TipoAvisoOrden, Index1, Index2 As Integer
        'Dim Falla, FechaProg, FechaReal, CodOrden, DuracionProg, DuracionReal, Soporte, HoraProg, HoraReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible As String

        'If ugOrdenAviso.Selected.Rows.Count <> 2 Then
        '    Mensaje("Debe seleccionar dos registros a relacionar.")
        '    Exit Sub
        'End If

        'TipoAviso1 = ugOrdenAviso.Selected.Rows(0).Cells("TipoAvisoOrden").Value
        'TipoAviso2 = ugOrdenAviso.Selected.Rows(1).Cells("TipoAvisoOrden").Value
        'Falla = String.Empty
        'If TipoAviso1 = 0 OrElse TipoAviso2 = 0 OrElse TipoAviso1 = TipoAviso2 Then
        '    Mensaje("Los registros seleccionados no se pueden relacionar.")
        '    Exit Sub
        'End If

        'For Each RowSeleccionada As UltraGridRow In ugOrdenAviso.Selected.Rows
        '    If Convert.ToInt32(RowSeleccionada.Cells("TipoAvisoOrden").Value) = 1 Then
        '        CodOrden = RowSeleccionada.Cells("Orden").Value
        '        Soporte = RowSeleccionada.Cells("Soporte").Value
        '        FechaProg = RowSeleccionada.Cells("FechaProg").Value
        '        HoraProg = RowSeleccionada.Cells("HoraProg").Value
        '        DuracionProg = RowSeleccionada.Cells("DuracionProg").Value
        '        Programa = RowSeleccionada.Cells("Programa").Value
        '        If RowSeleccionada.Cells("Falla").Value <> String.Empty Then
        '            Falla = RowSeleccionada.Cells("Falla").Value
        '        End If
        '        Index1 = RowSeleccionada.Index
        '    Else
        '        FechaReal = RowSeleccionada.Cells("FechaReal").Value
        '        HoraReal = RowSeleccionada.Cells("HoraReal").Value
        '        DuracionReal = RowSeleccionada.Cells("DuracionReal").Value
        '        ProgramaReal = RowSeleccionada.Cells("ProgramaReal").Value
        '        Cod_Soporte = RowSeleccionada.Cells("Cod_Soporte").Value
        '        Cod_Spot = RowSeleccionada.Cells("Cod_Spot").Value
        '        SS_Spot = RowSeleccionada.Cells("SS_Spot").Value
        '        ProgramaVisible = RowSeleccionada.Cells("ProgramaReal").Value
        '        If RowSeleccionada.Cells("Falla").Value <> String.Empty Then
        '            Falla = RowSeleccionada.Cells("Falla").Value
        '        End If
        '        Index2 = RowSeleccionada.Index
        '    End If
        'Next
        'TipoAvisoOrden = 0

        'If DuracionProg = DuracionReal Then
        '    If Falla = String.Empty Or Falla = "Sin Falla" Then
        '        Estado = "OK"
        '    Else
        '        Estado = "FALLADO"
        '    End If
        'Else
        '    If Falla = String.Empty Then
        '        Estado = "DIFIEREN DURACION"
        '    Else
        '        Estado = "FALLADO"
        '    End If
        'End If

        'If Index1 > Index2 Then
        '    ugOrdenAviso.Rows(Index1).Delete(False)
        '    ugOrdenAviso.Rows(Index2).Delete(False)
        'Else
        '    ugOrdenAviso.Rows(Index2).Delete(False)
        '    ugOrdenAviso.Rows(Index1).Delete(False)
        'End If

        'dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)
        'Call InsertarOrdenAvisoOLD(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible)
        'Call AvisosOrdenadoBind(dsOrdenAviso)

        'If ugOrdenAviso.Rows.Count >= Index1 Then
        '    ugOrdenAviso.Selected.Rows.Clear()
        '    ugOrdenAviso.ActiveRow = ugOrdenAviso.Rows(Index1)
        '    ugOrdenAviso.Rows(Index1).Selected = True
        'End If
        Dim dsOrdenAviso As DataSet
        Dim TipoAviso1, TipoAviso2, TipoAvisoOrden, Index1, Index2 As Integer
        Dim Falla, FechaProg, FechaReal, CodOrden, DuracionProg, DuracionReal, Soporte, HoraProg, HoraReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible As String
        Dim Material, Tema, Posicion, AvisosBloque, Contrato, HoraFin, PosicionComercial, AvisoComercial As String

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
                'JJP - Modificación'
                Contrato = RowSeleccionada.Cells("Contrato").Value
                Material = RowSeleccionada.Cells("Material").Value
                ''''''''''''''''''''
                HoraFin = RowSeleccionada.Cells("HoraFin").Value ' AG 11/02/2013 
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
                'JJP - Modificación'
                Tema = RowSeleccionada.Cells("Tema").Value
                'Posicion = RowSeleccionada.Cells("Posicion").Value
                PosicionComercial = RowSeleccionada.Cells("PosicionComercial").Value
                AvisoComercial = RowSeleccionada.Cells("AvisoComercial").Value
                'AvisosBloque = RowSeleccionada.Cells("AvisosBloque").Value
                ''''''''''''''''''''
                HoraFin = RowSeleccionada.Cells("HoraFin").Value ' AG 11/02/2013 
            End If
        Next
        TipoAvisoOrden = 0


        If DuracionProg = DuracionReal Then
            Estado = "OK - " & Falla
        Else
            Estado = "DIFIEREN DURACION - " & Falla
        End If

        If Index1 > Index2 Then
            ugOrdenAviso.Rows(Index1).Delete(False)
            ugOrdenAviso.Rows(Index2).Delete(False)
        Else
            ugOrdenAviso.Rows(Index2).Delete(False)
            ugOrdenAviso.Rows(Index1).Delete(False)
        End If

        dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)
        Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden, Falla, CodOrden, Soporte, FechaProg, FechaReal, HoraProg, HoraReal, DuracionProg, DuracionReal, Estado, Programa, ProgramaReal, Cod_Soporte, Cod_Spot, SS_Spot, ProgramaVisible, Material, Tema, Posicion, AvisosBloque, Contrato, HoraFin, PosicionComercial, AvisoComercial)
        Call AvisosOrdenadoBind(dsOrdenAviso)

        If ugOrdenAviso.Rows.Count >= Index1 Then
            ugOrdenAviso.Selected.Rows.Clear()
            ugOrdenAviso.ActiveRow = ugOrdenAviso.Rows(Index1)
            ugOrdenAviso.Rows(Index1).Selected = True
        End If

    End Sub

    Private Sub DesvincularOrdenAviso()
        'Dim dsOrdenAviso As DataSet
        'Dim TipoAviso, TipoAvisoOrden1, TipoAvisoOrden2, Index As Integer
        'Dim RowSeleccionada As UltraGridRow
        'Dim Falla1, FechaProg1, FechaReal1, CodOrden1, DuracionProg1, DuracionReal1, Soporte1, HoraProg1, HoraReal1, Estado1, Programa1, ProgramaReal1, Cod_Soporte1, Cod_Spot1, SS_Spot1, ProgramaVisible1 As String
        'Dim Falla2, FechaProg2, FechaReal2, CodOrden2, DuracionProg2, DuracionReal2, Soporte2, HoraProg2, HoraReal2, Estado2, Programa2, ProgramaReal2, Cod_Soporte2, Cod_Spot2, SS_Spot2, ProgramaVisible2 As String

        'If ugOrdenAviso.Selected.Rows.Count <> 1 Then
        '    Mensaje("Debe seleccionar solo un registro a desvincular.")
        '    Exit Sub
        'End If

        'TipoAviso = ugOrdenAviso.Selected.Rows(0).Cells("TipoAvisoOrden").Value
        'If TipoAviso <> 0 Then
        '    Mensaje("El registro seleccionado no se puede desvincular.")
        '    Exit Sub
        'End If

        'RowSeleccionada = ugOrdenAviso.Selected.Rows(0)
        'Index = RowSeleccionada.Index

        'CodOrden1 = RowSeleccionada.Cells("Orden").Value
        'Soporte1 = RowSeleccionada.Cells("Soporte").Value
        'FechaProg1 = RowSeleccionada.Cells("FechaProg").Value
        'FechaReal1 = String.Empty
        'HoraProg1 = RowSeleccionada.Cells("HoraProg").Value
        'HoraReal1 = String.Empty
        'DuracionProg1 = RowSeleccionada.Cells("DuracionProg").Value
        'DuracionReal1 = String.Empty
        'Estado1 = "SOLO SIGEME"
        'Programa1 = RowSeleccionada.Cells("Programa").Value
        'ProgramaReal1 = String.Empty
        'TipoAvisoOrden1 = 1
        'Falla1 = RowSeleccionada.Cells("Falla").Value
        'Cod_Soporte1 = RowSeleccionada.Cells("Cod_Soporte").Value
        'Cod_Spot1 = String.Empty
        'SS_Spot1 = String.Empty
        'ProgramaVisible1 = RowSeleccionada.Cells("Programa").Value

        'CodOrden2 = String.Empty
        'Soporte2 = RowSeleccionada.Cells("Soporte").Value
        'FechaProg2 = String.Empty
        'FechaReal2 = RowSeleccionada.Cells("FechaReal").Value
        'HoraProg2 = String.Empty
        'HoraReal2 = RowSeleccionada.Cells("HoraReal").Value
        'DuracionProg2 = String.Empty
        'DuracionReal2 = RowSeleccionada.Cells("DuracionReal").Value
        'Estado2 = "FTE EXT"
        'Programa2 = String.Empty
        'ProgramaReal2 = RowSeleccionada.Cells("ProgramaReal").Value
        'TipoAvisoOrden2 = 2
        'Falla2 = RowSeleccionada.Cells("Falla").Value
        'Cod_Soporte2 = RowSeleccionada.Cells("Cod_Soporte").Value
        'Cod_Spot2 = RowSeleccionada.Cells("Cod_Spot").Value
        'SS_Spot2 = RowSeleccionada.Cells("SS_Spot").Value
        'ProgramaVisible2 = RowSeleccionada.Cells("ProgramaReal").Value

        'ugOrdenAviso.Rows(Index).Delete(False)
        'dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)
        'Call InsertarOrdenAvisoOLD(dsOrdenAviso, TipoAvisoOrden1, Falla1, CodOrden1, Soporte1, FechaProg1, FechaReal1, HoraProg1, HoraReal1, DuracionProg1, DuracionReal1, Estado1, Programa1, ProgramaReal1, Cod_Soporte1, Cod_Spot1, SS_Spot1, ProgramaVisible1)
        'Call InsertarOrdenAvisoOLD(dsOrdenAviso, TipoAvisoOrden2, Falla2, CodOrden2, Soporte2, FechaProg2, FechaReal2, HoraProg2, HoraReal2, DuracionProg2, DuracionReal2, Estado2, Programa2, ProgramaReal2, Cod_Soporte2, Cod_Spot2, SS_Spot2, ProgramaVisible2)
        'Call AvisosOrdenadoBind(dsOrdenAviso)

        Dim dsOrdenAviso As DataSet
        Dim TipoAviso, TipoAvisoOrden1, TipoAvisoOrden2, Index As Integer
        Dim RowSeleccionada As UltraGridRow
        Dim Falla1, FechaProg1, FechaReal1, CodOrden1, DuracionProg1, DuracionReal1, Soporte1, HoraProg1, HoraReal1, Estado1, Programa1, ProgramaReal1, Cod_Soporte1, Cod_Spot1, SS_Spot1, ProgramaVisible1, Material1, Tema1, Posicion1, AvisosBloque1, Contrato1, HoraFin1, PosicionComercial1, AvisoComercial1 As String
        Dim Falla2, FechaProg2, FechaReal2, CodOrden2, DuracionProg2, DuracionReal2, Soporte2, HoraProg2, HoraReal2, Estado2, Programa2, ProgramaReal2, Cod_Soporte2, Cod_Spot2, SS_Spot2, ProgramaVisible2, Material2, Tema2, Posicion2, AvisosBloque2, Contrato2, HoraFin2, PosicionComercial2, AvisoComercial2 As String


        'AG 21/03/2012 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'Nota: Se comenta este control para permitir realizar una desvinculacion con mas de un aviso
        'If ugOrdenAviso.Selected.Rows.Count <> 1 Then
        'Mensaje("Debe seleccionar solo un registro a desvincular.")
        'Exit Sub
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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
        Estado1 = "SOLO MMS"
        Programa1 = RowSeleccionada.Cells("Programa").Value
        ProgramaReal1 = String.Empty
        TipoAvisoOrden1 = 1
        Falla1 = RowSeleccionada.Cells("Falla").Value
        Cod_Soporte1 = RowSeleccionada.Cells("Cod_Soporte").Value
        Cod_Spot1 = String.Empty
        SS_Spot1 = String.Empty
        ProgramaVisible1 = RowSeleccionada.Cells("Programa").Value
        Material1 = RowSeleccionada.Cells("Material").Value
        Tema1 = String.Empty
        Posicion1 = String.Empty
        AvisosBloque1 = String.Empty
        PosicionComercial1 = String.Empty
        AvisoComercial1 = String.Empty
        Contrato1 = RowSeleccionada.Cells("Contrato").Value

        HoraFin1 = RowSeleccionada.Cells("HoraFin").Value 'AG 11/03/2013 

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
        Material2 = String.Empty
        Tema2 = RowSeleccionada.Cells("Tema").Value
        'Posicion2 = RowSeleccionada.Cells("Posicion").Value
        'AvisosBloque2 = RowSeleccionada.Cells("AvisosBloque").Value
        PosicionComercial2 = RowSeleccionada.Cells("PosicionComercial").Value
        AvisoComercial2 = RowSeleccionada.Cells("AvisoComercial").Value
        Contrato2 = String.Empty

        HoraFin2 = String.Empty 'AG 11/03/2013

        ugOrdenAviso.Rows(Index).Delete(False)
        dsOrdenAviso = CType(ugOrdenAviso.DataSource, DataSet)
        Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden1, Falla1, CodOrden1, Soporte1, FechaProg1, FechaReal1, HoraProg1, HoraReal1, DuracionProg1, DuracionReal1, Estado1, Programa1, ProgramaReal1, Cod_Soporte1, Cod_Spot1, SS_Spot1, ProgramaVisible1, Material1, Tema1, Posicion1, AvisosBloque1, Contrato1, HoraFin1, PosicionComercial1, AvisoComercial1)
        Call InsertarOrdenAviso(dsOrdenAviso, TipoAvisoOrden2, Falla2, CodOrden2, Soporte2, FechaProg2, FechaReal2, HoraProg2, HoraReal2, DuracionProg2, DuracionReal2, Estado2, Programa2, ProgramaReal2, Cod_Soporte2, Cod_Spot2, SS_Spot2, ProgramaVisible2, Material2, Tema2, Posicion2, AvisosBloque2, Contrato2, HoraFin2, PosicionComercial2, AvisoComercial2)
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
            'JJP 09/08/2011 Controla que no se confirmen avisos sin relacionar
            If String.IsNullOrEmpty(RowSeleccionada.Cells("Cod_Spot").Value.ToString()) Then
                Mensaje("Existen avisos sin relacionar.Nro de Orden: " & RowSeleccionada.Cells("Orden").Value.ToString)
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

        'AG 11/03/2013 +++++++++++++
        FromatoGrillaConfirmado()
        '++++++++++++++++++++++++

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

    Private Sub ConfirmarOrdenAviso()
        Dim dsAvisosConfirmados As DataSet
        Dim ControlMacheo As New Control_Macheo
        Dim Cod_Orden As Double
        Dim Fec_Confirmacion, Fec_Aparicion As DateTime
        Dim Hora, Minuto, Ind_Diferencia, Version, Duracion As Integer
        Dim Usuario, Aplicativo, Cod_Soporte, Cod_Spot, SS_Spot, Hora_Spot As String
        Dim HoraSplit() As String
        Dim Control As New Control_Macheo
        Dim lAvisoConfirmado As New List(Of AvisoConfirmado)
        Dim avisoC As AvisoConfirmado

        If ugAvisosConfirmados.Rows.Count <= 0 Then
            Mensaje("No existen registros cargados para confirmar.")
            Exit Sub
        End If

        dsAvisosConfirmados = CType(ugAvisosConfirmados.DataSource, DataSet)
        If Not dsAvisosConfirmados Is Nothing AndAlso Not dsAvisosConfirmados.Tables(0) Is Nothing AndAlso dsAvisosConfirmados.Tables(0).Rows.Count > 0 Then

            For Each drAvisosConfirmados As DataRow In dsAvisosConfirmados.Tables(0).Rows
                avisoC = New AvisoConfirmado

                Cod_Orden = Convert.ToDouble(drAvisosConfirmados("Orden"))
                'ControlMacheo.ActualizarEstadoOrden(Cod_Orden)

                avisoC.CodigoPresupuesto = mPresupuesto.Codigo
                avisoC.CodigoOrden = Cod_Orden
                avisoC.CodigoCliente = mPresupuesto.Subcampana.Campana.Cliente.CodigoCliente
                avisoC.CodigoMedio = mPresupuesto.Subcampana.Medio.CodMedio
                avisoC.Programa = drAvisosConfirmados("Programa").ToString

                If drAvisosConfirmados("HoraReal") <> String.Empty Then
                    Fec_Aparicion = drAvisosConfirmados("FechaReal")
                    HoraSplit = drAvisosConfirmados("HoraReal").ToString.Split(":")
                    If HoraSplit.Length = 2 Then
                        Hora = Convert.ToInt32(HoraSplit(0))
                        Minuto = Convert.ToInt32(HoraSplit(1))
                    End If
                    Duracion = drAvisosConfirmados("DuracionReal")
                    avisoC.ProgramaReal = drAvisosConfirmados("ProgramaReal")
                Else
                    Fec_Aparicion = drAvisosConfirmados("FechaProg")
                    HoraSplit = drAvisosConfirmados("HoraProg").ToString.Split(":")
                    If HoraSplit.Length = 2 Then
                        Hora = Convert.ToInt32(HoraSplit(0))
                        Minuto = Convert.ToInt32(HoraSplit(1))
                    End If
                    Duracion = drAvisosConfirmados("DuracionProg")
                End If
                Fec_Confirmacion = Today
                Ind_Diferencia = 0
                Version = 1
                Usuario = Activo.Login  '"mponce" 
                Aplicativo = "CONF.FTE.EXTERNA"

                avisoC.fechaEjecucion = DateTime.Parse(drAvisosConfirmados("FechaProg").ToString())
                avisoC.FechaReal = Fec_Aparicion
                avisoC.HoraReal = Hora
                avisoC.MinutoReal = Minuto
                avisoC.Version = Version
                avisoC.DuracionReal = Duracion

                'ControlMacheo.AgregarConfirmaciones_TV(Cod_Orden, Fec_Confirmacion, Fec_Aparicion, Hora, Minuto, Ind_Diferencia, Usuario, Aplicativo, Version)

                Cod_Spot = drAvisosConfirmados("Cod_Spot")
                If Cod_Spot <> String.Empty Then
                    Cod_Soporte = drAvisosConfirmados("Cod_Soporte")
                    SS_Spot = drAvisosConfirmados("SS_Spot")
                    Fec_Aparicion = drAvisosConfirmados("FechaReal")
                    Hora_Spot = drAvisosConfirmados("HoraReal")
                    Hora = Convert.ToInt32(Hora_Spot.ToString.Replace(":", ""))

                    avisoC.CodigoSpot = Cod_Spot
                    avisoC.CadenaSpot = Cod_Soporte
                    avisoC.SegundoReal = SS_Spot

                    'ControlMacheo.AgregarAvisosConfirmados(Cod_Spot, Cod_Orden, Fec_Aparicion, Hora, Cod_Soporte, SS_Spot)
                End If

                lAvisoConfirmado.Add(avisoC)
            Next

            If lAvisoConfirmado.Count > 0 Then
                Dim resultado As String
                resultado = Control.ConfirmarAvisos(lAvisoConfirmado)
                If Not String.IsNullOrEmpty(resultado) Then
                    Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
                    Exit Sub
                End If
                Call ObtenerOrdenAviso(dsAvisosConfirmados)
                ugAvisosConfirmados.DataSource = dsAvisosConfirmados
                ugAvisosConfirmados.DataBind()
                'AG 11/03/2013 +++++++++++++
                FromatoGrillaConfirmado()
                '++++++++++++++++++++++++
                Mensaje("La operación concluyó exitosamente.")
                Call SetearCantidadAgregados()
            End If

        End If
    End Sub

    Private Sub ConfirmarOrdenAvisoFacturado()
        Dim dsAvisosConfirmados As DataSet
        Dim ControlMacheo As New Control_Macheo
        Dim Cod_Orden As Double
        Dim Fec_Confirmacion, Fec_Aparicion As DateTime
        Dim Hora, Minuto, Ind_Diferencia, Version As Integer
        Dim Usuario, Aplicativo, Cod_Soporte, Cod_Spot, SS_Spot, Hora_Spot As String
        Dim HoraSplit() As String
        Dim AvisosConf As Integer = 0
        Dim CantAvisos As Integer = 0

        If ugAvisosConfirmados.Rows.Count <= 0 Then
            Mensaje("No existen registros cargados para confirmar.")
            Exit Sub
        End If

        dsAvisosConfirmados = CType(ugAvisosConfirmados.DataSource, DataSet)
        If Not dsAvisosConfirmados Is Nothing AndAlso Not dsAvisosConfirmados.Tables(0) Is Nothing AndAlso dsAvisosConfirmados.Tables(0).Rows.Count > 0 Then
            CantAvisos = dsAvisosConfirmados.Tables(0).Rows.Count

            For Each drAvisosConfirmados As DataRow In dsAvisosConfirmados.Tables(0).Rows
                Cod_Orden = Convert.ToDouble(drAvisosConfirmados("Orden"))
                Cod_Spot = drAvisosConfirmados("Cod_Spot")
                If Cod_Spot <> String.Empty Then
                    Cod_Soporte = drAvisosConfirmados("Cod_Soporte")
                    SS_Spot = drAvisosConfirmados("SS_Spot")
                    Fec_Aparicion = drAvisosConfirmados("FechaReal")
                    Hora_Spot = drAvisosConfirmados("HoraReal")
                    Hora = Convert.ToInt32(Hora_Spot.ToString.Replace(":", ""))
                    ControlMacheo.AgregarAvisosConfirmados(Cod_Spot, Cod_Orden, Fec_Aparicion, Hora, Cod_Soporte, SS_Spot)
                    ControlMacheo.ActualizarConfirmacionesTV(Cod_Orden, Today, Activo.Login, "CONF.FTE.EXTERNA")
                    AvisosConf += 1
                End If
            Next

            Call ObtenerOrdenAviso(dsAvisosConfirmados)
            ugAvisosConfirmados.DataSource = dsAvisosConfirmados
            ugAvisosConfirmados.DataBind()
            'AG 11/03/2013 ++++++++++++++++
            FromatoGrillaConfirmado()
            '+++++++++++++++++++++++++++
            Mensaje("La operación concluyó exitosamente.Se confirmaron " & AvisosConf & " de " & CantAvisos & " avisos.")
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
            Call FOne.ReporteAvisosMacheados(Convert.ToDouble(Presupuesto), pOrden, CodTipoSoporte)

            FOne.NroPresupuesto = txtPresupuesto.Text.Trim()

            'FOne.Grilla.Write(rutaCompleta, 4)

            FOne.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ImprimirControl(ByVal pOrden As Impresion) 'AG 13/03/2013 
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        If Presupuesto = String.Empty OrElse Convert.ToDouble(Presupuesto) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
        Else
            Dim FOne As New frmFormulaOne
            Me.Cursor = Cursors.WaitCursor
            Call FOne.ReporteControlAvisos(Convert.ToDouble(Presupuesto), pOrden, CodTipoSoporte)
            FOne.Show()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ImprimirAvisosMonitor(ByVal pOrden As Impresion)
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        Dim Ordenes As New DataSet
        Ordenes = CType(ugOrdenAviso.DataSource, DataSet)

        Dim AvisosMonitor As DataTable = Ordenes.Tables(0).Clone

        For Each aviso As DataRow In Ordenes.Tables(0).Select("estado= 'FTE EXT'")
            AvisosMonitor.ImportRow(aviso)
        Next


        If AvisosMonitor.Rows.Count > 0 Then
            Ordenes.Tables.Remove("Table1")
            Ordenes.Tables.Add(AvisosMonitor)

            Dim FOne As New frmFormulaOne
            Me.Cursor = Cursors.WaitCursor
            Call FOne.ReporteAvisosMonitor(Convert.ToDouble(Presupuesto), pOrden, Ordenes, txtCliente.Text, TxtProducto.Text)
            FOne.Show()
            Me.Cursor = Cursors.Default
        Else
            Mensajes.Mensaje("No hay avisos para imprimir", TipoMensaje.Informacion)
        End If



    End Sub

    Private Sub AbrirClienteExterno()
        Dim ClienteExterno As New frmABMClienteExterno
        ClienteExterno.ShowDialog()
    End Sub

    Private Sub SetearCantidadAgregados()
        Dim Cantidad As New StringBuilder
        Dim CantidadConfirmar As Double = ugAvisosConfirmados.Rows.Count
        If CantidadConfirmar > 0 Then
            Cantidad.Append("                                                                                                    ")
            Cantidad.Append("                                                                                                    ")
            Cantidad.Append("Cantidad a Confirmar: ")
            Cantidad.Append(CantidadConfirmar)
        End If
        UltraToolbarsManager3.Toolbars(0).Tools("CantidadRegistros").SharedProps.Caption = Cantidad.ToString
    End Sub

    Private Sub BusquedaPresupuesto()
        Dim Presupuesto As Double
        Dim PresupuestoPendiente As New frmPresupuestosPendientes
        PresupuestoPendiente.ShowDialog()
        Presupuesto = PresupuestoPendiente.Presupuesto
        mPresupuesto = ObtenerPresupuesto(Integer.Parse(Presupuesto))
        If Not mPresupuesto Is Nothing Then
            CodMedio = mPresupuesto.Subcampana.Medio.CodMedio
            'If Presupuesto > 0 Then
            Call LimpiarDatos()
            txtPresupuesto.Text = Presupuesto
            cboTipoAviso.SelectedIndex = 0
            Call ObtenerOrdenesAvisos(Convert.ToDouble(Presupuesto))
            If ugOrdenAviso.Rows.Count <= 0 Then
                Mensaje("No existen registros para el presupuesto ingresado.")
            End If
        End If
    End Sub
#End Region

    Private Function ControlSpotAdmedia(ByRef Spots As DataSet, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal Soportes As String) As DataSet
        Dim ds As New DataSet
        Dim dtSpot, dtSpotDestino, dtConf, dtSoportes As New DataTable
        Dim ControlMacheo As New Control_Macheo
        Dim filtro As String = ""
        Dim Aviso(), Soporte() As DataRow
        Dim lAvisoConf As New List(Of AvisoConfirmado)

        Dim accion As String = ""

        Try
            dtSpot = Spots.Tables(0)
            dtSpotDestino = dtSpot.Clone
            dtSoportes = ObtenerSoportesAdmedia(Soportes).Tables(0) 'ControlMacheo.BuscarAr_Soportes_Admedia(Soportes).Tables(0)
            dtConf = ObtenerAvisosConfirmados(Soportes, FechaDesde, FechaHasta)

            If dtConf.Rows.Count > 0 And dtSpot.Rows.Count > 0 And dtSoportes.Rows.Count > 0 Then
                For Each dr As DataRow In dtSpot.Rows
                    Soporte = dtSoportes.Select("cod_vehiculo_admedia = " & dr("nCod_Vehiculo"))
                    accion = "Select soportes"
                    filtro = ""
                    filtro &= "cod_spot = " & dr("cod_spt")
                    filtro &= " AND fec_spot = '" & dr("fec_spt") & "'"
                    filtro &= " AND hr_spot = " & dr("hm_spt")
                    filtro &= " AND ss_spot = " & dr("ss_spt")
                    filtro &= " AND cad_spot = '" & Soporte(0)("id_soporte") & "'"

                    accion = "Select aviso"
                    Aviso = dtConf.Select(filtro)
                    If Aviso.Length = 0 Then
                        Soporte = dtSoportes.Select("cod_vehiculo_admedia = " & dr("nCod_Vehiculo"))
                        dr("cod_soporte") = Soporte(0)("id_soporte")
                        dr("DES_SOPORTE") = Soporte(0)("Des_Soporte")
                        accion = "Import aviso"
                        dtSpotDestino.ImportRow(dr)
                    End If

                Next
            ElseIf dtSpot.Rows.Count > 0 And dtSoportes.Rows.Count > 0 Then
                For Each dr As DataRow In dtSpot.Rows
                    Soporte = dtSoportes.Select("cod_vehiculo_admedia = " & dr("nCod_Vehiculo"))
                    dr("cod_soporte") = Soporte(0)("id_soporte")
                    dr("DES_SOPORTE") = Soporte(0)("Des_Soporte")
                    dtSpotDestino.ImportRow(dr)
                Next
            End If

            ds.Tables.Add(dtSpotDestino)
        Catch ex As Exception
            MsgBox(accion)
            Throw ex
        End Try

        Return ds

    End Function

    Private Sub ugOrdenAviso_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugOrdenAviso.VisibleChanged

    End Sub

    Private Function ObtenerPresupuesto(ByVal codPresupuesto As Integer) As PresupuestoEntidad
        Dim ControlMacheo As New Control_Macheo
        Dim codPais As Integer = Integer.Parse(Activo.CodPaisMms)
        Dim codCompania As Integer = Activo.IDCompaniaMMS

        Return ControlMacheo.ObtenerPresupuesto(codPais, codCompania, codPresupuesto)

    End Function

    Private Function ObtenerSoportesAdmedia(ByVal soportes As String) As DataSet
        Dim ControlMacheo As New Control_Macheo
        Dim Maestros As New MSL.Maestros
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim dsAux As New DataSet
        Dim i, idMedio, idSoporte As Integer
        Dim idPais As Integer = Activo.CodPaisMms
        Dim desSoporte As String = ""

        dsAux = ControlMacheo.BuscarAr_Soportes_Admedia(soportes)

        If Not dsAux Is Nothing AndAlso dsAux.Tables.Count > 0 Then

            ds.Tables.Add(dsAux.Tables(0).Clone)

            For i = 0 To dsAux.Tables(0).Rows.Count - 1

                idMedio = dsAux.Tables(0).Rows(i)("ID_MEDIO")
                idSoporte = dsAux.Tables(0).Rows(i)("ID_SOPORTE")
                desSoporte = Maestros.SoporteDescripcionObtener(idPais, idMedio, idSoporte)

                If desSoporte.Length > 0 Then
                    dr = ds.Tables(0).NewRow
                    dr("ID_MEDIO") = idMedio
                    dr("ID_SOPORTE") = idSoporte
                    dr("DES_SOPORTE") = desSoporte
                    dr("COD_VEHICULO_ADMEDIA") = dsAux.Tables(0).Rows(i)("COD_VEHICULO_ADMEDIA")
                    dr("ID_TIPO_SOPORTE") = dsAux.Tables(0).Rows(i)("ID_TIPO_SOPORTE")
                    dr("DESCRIPCION_ADMEDIA") = dsAux.Tables(0).Rows(i)("DESCRIPCION_ADMEDIA")
                    ds.Tables(0).Rows.Add(dr)
                Else
                    Mensaje("No se encontró el soporte:" & idSoporte & " del medio:" & idMedio)
                End If

            Next
        End If

        Return ds

    End Function

    Private Function ObtenerAvisosConfirmados(ByVal Soportes As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As DataTable
        Dim ControlMatcheo As New Control_Macheo
        Dim dsAvisos As New DataSet
        Dim dtAvisos As New DataTable
        Dim resultado As New Dictionary(Of String, List(Of AvisoConfirmado))
        Dim lAvisos As New List(Of AvisoConfirmado)
        Dim dr As DataRow
        Dim aviso As New AvisoConfirmado
        Dim lSoportes As New List(Of Integer)
        Dim aSoportes As String()

        'AG 05/07
        Dim hora As String
        Dim fecha_spot As String
        Dim codOrden As String
        Dim compania As String
        Dim cod_spot As String
        Dim ss_spot As String
        Dim cad_spot As String

        ArmarEstructuraAvisosConfirmados(dtAvisos)
        aSoportes = Soportes.Split(",")

        For Each item As String In aSoportes
            lSoportes.Add(Integer.Parse(item.ToString()))
        Next

        resultado = ControlMatcheo.ObtenerAvisosConfirmados(Activo.IDCompaniaMMS, lSoportes, fechaDesde, fechaHasta)

        lAvisos = resultado.Values(0)
        For Each item As AvisoConfirmado In lAvisos
            dr = dtAvisos.NewRow
            dr("COD_COMPANIA") = item.CodigoCompania
            dr("COD_ORDEN") = item.CodigoOrden.Value
            dr("COD_SPOT") = item.CodigoSpot.Value
            dr("FEC_SPOT") = item.FechaReal.Value
            dr("HR_SPOT") = item.HoraReal
            dr("SS_SPOT") = item.SegundoReal
            dr("CAD_SPOT") = item.CadenaSpot
            dtAvisos.Rows.Add(dr)
        Next

        Return dtAvisos
    End Function

    Private Sub ArmarEstructuraAvisosConfirmados(ByRef dtOrdenes As DataTable)

        dtOrdenes.Columns.Add("COD_COMPANIA", GetType(Integer))
        dtOrdenes.Columns.Add("COD_ORDEN", GetType(Integer))
        dtOrdenes.Columns.Add("COD_SPOT", GetType(Integer))
        dtOrdenes.Columns.Add("FEC_SPOT", GetType(DateTime))
        dtOrdenes.Columns.Add("HR_SPOT", GetType(Integer))
        dtOrdenes.Columns.Add("SS_SPOT", GetType(Integer))
        dtOrdenes.Columns.Add("CAD_SPOT", GetType(String))

        dtOrdenes.AcceptChanges()

    End Sub

    Private Function SeleccionarSoportesPermitidos(ByVal DtAvisos As DataTable, ByVal DtSopPermitidos As DataTable) As DataTable

        Dim DrDatos As DataRow()
        Dim DrEliminar As DataRow()
        Dim i As Integer
        Dim DtSoporteEliminar As DataTable = DtAvisos.DefaultView.ToTable(True, "soporte_sig")

        For Each RSoporte As DataRow In DtSoporteEliminar.Rows
            DrDatos = DtSopPermitidos.Select("id_medio=" & 1 & " and id_soporte=" & RSoporte("soporte_sig"))
            If DrDatos.Length = 0 Then
                DrEliminar = DtAvisos.Select("soporte_sig=" & RSoporte("soporte_sig"))
                If DrEliminar.Length > 0 Then
                    For i = 0 To DrEliminar.Length - 1
                        DtAvisos.Rows.Remove(DrEliminar(i))
                        DtAvisos.AcceptChanges()
                    Next i
                End If
            End If
        Next

        Return DtAvisos

    End Function

End Class

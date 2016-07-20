Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Text
Imports Framework.Mensajes
Imports Infragistics.Win.Printing
Imports MSL
Imports System.Collections.Generic

Public Class frmEjercicioMedios
    Inherits System.Windows.Forms.Form
    Dim reemplazo As Boolean = False
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
    Friend WithEvents uManager As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _Form1_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ugPlanificacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtFoco As System.Windows.Forms.TextBox
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ugPrinter As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
    Friend WithEvents pnlTotales As System.Windows.Forms.Panel
    Friend WithEvents lblNeto As System.Windows.Forms.Label
    Friend WithEvents lblBruto As System.Windows.Forms.Label
    Friend WithEvents txtBruto As System.Windows.Forms.TextBox
    Friend WithEvents lblAvisos As System.Windows.Forms.Label
    Friend WithEvents txtAvisos As System.Windows.Forms.TextBox
    Friend WithEvents txtNeto As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("Menu")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Borrar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Soportes")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Puntual")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Global")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Imprimir")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExpandirColapsar")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupMenuPadre")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupMenuHijo")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupMenuDia")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Buscar Codigo AGIP")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Mapa")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEjercicioMedios))
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Borrar")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Soportes")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Puntual")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Global")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Imprimir")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExpandirColapsar")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarHijo")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarPadre")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarHijo")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("DuplicarHijo")
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupMenuPadre")
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarHijo")
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarPadre")
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Pegar")
        Dim PopupMenuTool5 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupMenuHijo")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarHijo")
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Copiar")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("DuplicarHijo")
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarConvenioHijo")
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarConvenioHijo")
        Dim PopupMenuTool6 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupMenuDia")
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarObservacion")
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarObservacion")
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ModificarObservacion")
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarObservacion")
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarObservacion")
        Dim ButtonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ModificarObservacion")
        Dim ButtonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AgregarConvenioHijo")
        Dim ButtonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("EliminarConvenioHijo")
        Dim ButtonTool39 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Copiar")
        Dim ButtonTool40 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Pegar")
        Dim ButtonTool41 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Buscar Codigo AGIP")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool42 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Mapa")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Me.uManager = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._Form1_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.ugPlanificacion = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtFoco = New System.Windows.Forms.TextBox
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ugPrinter = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.pnlGrilla = New System.Windows.Forms.Panel
        Me.pnlTotales = New System.Windows.Forms.Panel
        Me.txtNeto = New System.Windows.Forms.TextBox
        Me.txtBruto = New System.Windows.Forms.TextBox
        Me.lblNeto = New System.Windows.Forms.Label
        Me.lblBruto = New System.Windows.Forms.Label
        Me.txtAvisos = New System.Windows.Forms.TextBox
        Me.lblAvisos = New System.Windows.Forms.Label
        CType(Me.uManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugPlanificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrilla.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'uManager
        '
        Me.uManager.DesignerFlags = 1
        Me.uManager.DockWithinContainer = Me
        Me.uManager.LockToolbars = True
        Me.uManager.RuntimeCustomizationOptions = Infragistics.Win.UltraWinToolbars.RuntimeCustomizationOptions.None
        Me.uManager.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Text = "Menu"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool7, ButtonTool8, PopupMenuTool1, PopupMenuTool2, PopupMenuTool3, ButtonTool9, ButtonTool10})
        Me.uManager.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        ButtonTool11.SharedProps.AppearancesSmall.Appearance = Appearance18
        ButtonTool11.SharedProps.ToolTipText = "Guardar la Hoja de Planificación"
        Appearance19.Image = CType(resources.GetObject("Appearance19.Image"), Object)
        ButtonTool12.SharedProps.AppearancesSmall.Appearance = Appearance19
        ButtonTool12.SharedProps.ToolTipText = "Borrar las Filas Seleccionadas"
        Appearance20.Image = CType(resources.GetObject("Appearance20.Image"), Object)
        ButtonTool13.SharedProps.AppearancesSmall.Appearance = Appearance20
        ButtonTool13.SharedProps.ToolTipText = "Agregar Nuevos Soportes"
        Appearance21.Image = CType(resources.GetObject("Appearance21.Image"), Object)
        ButtonTool14.SharedProps.AppearancesSmall.Appearance = Appearance21
        ButtonTool14.SharedProps.ToolTipText = "Aplicar Convenio a las Filas Seleccionadas"
        Appearance22.Image = CType(resources.GetObject("Appearance22.Image"), Object)
        ButtonTool15.SharedProps.AppearancesSmall.Appearance = Appearance22
        ButtonTool15.SharedProps.ToolTipText = "Aplicar Convenio a la Hoja"
        Appearance23.Image = CType(resources.GetObject("Appearance23.Image"), Object)
        ButtonTool16.SharedProps.AppearancesSmall.Appearance = Appearance23
        ButtonTool16.SharedProps.ToolTipText = "Imprimir Hoja de Planificación"
        Appearance24.Image = CType(resources.GetObject("Appearance24.Image"), Object)
        ButtonTool17.SharedProps.AppearancesSmall.Appearance = Appearance24
        ButtonTool17.SharedProps.ToolTipText = "Exportar a Excel la Hoja de Planificación"
        Appearance25.Image = 1
        ButtonTool18.SharedProps.AppearancesSmall.Appearance = Appearance25
        ButtonTool18.SharedProps.Caption = "Expandir"
        ButtonTool19.SharedProps.Caption = "Borrar"
        ButtonTool20.SharedProps.Caption = "Borrar"
        ButtonTool21.SharedProps.Caption = "Agregar"
        ButtonTool22.SharedProps.Caption = "Duplicar"
        PopupMenuTool4.SharedProps.Caption = "PopupMenuPadre"
        PopupMenuTool4.SharedProps.Visible = False
        PopupMenuTool4.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool23, ButtonTool24, ButtonTool25})
        PopupMenuTool5.SharedProps.Caption = "PopupMenuHijo"
        PopupMenuTool5.SharedProps.Visible = False
        ButtonTool29.InstanceProps.IsFirstInGroup = True
        PopupMenuTool5.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool26, ButtonTool27, ButtonTool28, ButtonTool29, ButtonTool30})
        PopupMenuTool6.SharedProps.Caption = "PopupMenuDia"
        PopupMenuTool6.SharedProps.Visible = False
        PopupMenuTool6.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool31, ButtonTool32, ButtonTool33})
        ButtonTool34.SharedProps.Caption = "Agregar Observación"
        ButtonTool35.SharedProps.Caption = "Borrar Observación"
        ButtonTool36.SharedProps.Caption = "Modificar Observación"
        ButtonTool37.SharedProps.Caption = "Aplicar Convenio"
        ButtonTool37.SharedProps.ToolTipText = "Aplicar Convenio"
        ButtonTool38.SharedProps.Caption = "Borrar Convenio"
        ButtonTool38.SharedProps.ToolTipText = "Borrar Convenio"
        ButtonTool39.SharedProps.Caption = "Copiar"
        ButtonTool40.SharedProps.Caption = "Pegar"
        Appearance26.Image = CType(resources.GetObject("Appearance26.Image"), Object)
        ButtonTool41.SharedProps.AppearancesSmall.Appearance = Appearance26
        ButtonTool41.SharedProps.Caption = "Buscar Codigo AGIP"
        Appearance27.Image = CType(resources.GetObject("Appearance27.Image"), Object)
        ButtonTool42.SharedProps.AppearancesSmall.Appearance = Appearance27
        ButtonTool42.SharedProps.Caption = "Mapa"
        Me.uManager.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool16, ButtonTool17, ButtonTool18, ButtonTool19, ButtonTool20, ButtonTool21, ButtonTool22, PopupMenuTool4, PopupMenuTool5, PopupMenuTool6, ButtonTool34, ButtonTool35, ButtonTool36, ButtonTool37, ButtonTool38, ButtonTool39, ButtonTool40, ButtonTool41, ButtonTool42})
        '
        '_Form1_Toolbars_Dock_Area_Top
        '
        Me._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top"
        Me._Form1_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(624, 49)
        Me._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = Me.uManager
        '
        '_Form1_Toolbars_Dock_Area_Bottom
        '
        Me._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 397)
        Me._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom"
        Me._Form1_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(624, 0)
        Me._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.uManager
        '
        '_Form1_Toolbars_Dock_Area_Left
        '
        Me._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 49)
        Me._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left"
        Me._Form1_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 348)
        Me._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = Me.uManager
        '
        '_Form1_Toolbars_Dock_Area_Right
        '
        Me._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(624, 49)
        Me._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right"
        Me._Form1_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 348)
        Me._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = Me.uManager
        '
        'ugPlanificacion
        '
        Me.ugPlanificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugPlanificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Me.ugPlanificacion.DisplayLayout.Appearance = Appearance1
        Me.ugPlanificacion.DisplayLayout.MaxColScrollRegions = 1
        Me.ugPlanificacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugPlanificacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ugPlanificacion.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugPlanificacion.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugPlanificacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugPlanificacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugPlanificacion.DisplayLayout.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        Me.ugPlanificacion.DisplayLayout.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        Me.ugPlanificacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugPlanificacion.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.ugPlanificacion.DisplayLayout.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.ugPlanificacion.DisplayLayout.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        Me.ugPlanificacion.DisplayLayout.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.ugPlanificacion.DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.ugPlanificacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.ugPlanificacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.ugPlanificacion.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.ugPlanificacion.DisplayLayout.Override.CellPadding = 3
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugPlanificacion.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.ugPlanificacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.LightGray
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.ugPlanificacion.DisplayLayout.Override.RowAppearance = Appearance4
        Me.ugPlanificacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.Color.PowderBlue
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.ugPlanificacion.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.ugPlanificacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.ugPlanificacion.FlatMode = True
        Me.ugPlanificacion.Location = New System.Drawing.Point(0, 0)
        Me.ugPlanificacion.Name = "ugPlanificacion"
        Me.ugPlanificacion.Size = New System.Drawing.Size(621, 313)
        Me.ugPlanificacion.TabIndex = 11
        '
        'txtFoco
        '
        Me.txtFoco.Location = New System.Drawing.Point(336, 104)
        Me.txtFoco.Name = "txtFoco"
        Me.txtFoco.Size = New System.Drawing.Size(100, 20)
        Me.txtFoco.TabIndex = 16
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        '
        'ugPrinter
        '
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugPrinter.DisplayLayout.Appearance = Appearance6
        Me.ugPrinter.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugPrinter.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.ugPrinter.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugPrinter.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.ugPrinter.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugPrinter.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.ugPrinter.DisplayLayout.MaxColScrollRegions = 1
        Me.ugPrinter.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugPrinter.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugPrinter.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.ugPrinter.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugPrinter.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.ugPrinter.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugPrinter.DisplayLayout.Override.CellAppearance = Appearance13
        Me.ugPrinter.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugPrinter.DisplayLayout.Override.CellPadding = 0
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ugPrinter.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugPrinter.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.ugPrinter.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugPrinter.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Me.ugPrinter.DisplayLayout.Override.RowAppearance = Appearance16
        Me.ugPrinter.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugPrinter.DisplayLayout.Override.TemplateAddRowAppearance = Appearance17
        Me.ugPrinter.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugPrinter.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugPrinter.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugPrinter.Location = New System.Drawing.Point(320, 64)
        Me.ugPrinter.Name = "ugPrinter"
        Me.ugPrinter.Size = New System.Drawing.Size(104, 32)
        Me.ugPrinter.TabIndex = 21
        Me.ugPrinter.Visible = False
        '
        'pnlGrilla
        '
        Me.pnlGrilla.Controls.Add(Me.ugPlanificacion)
        Me.pnlGrilla.Controls.Add(Me.ugPrinter)
        Me.pnlGrilla.Controls.Add(Me.txtFoco)
        Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrilla.Location = New System.Drawing.Point(0, 49)
        Me.pnlGrilla.Name = "pnlGrilla"
        Me.pnlGrilla.Size = New System.Drawing.Size(624, 348)
        Me.pnlGrilla.TabIndex = 26
        '
        'pnlTotales
        '
        Me.pnlTotales.Controls.Add(Me.txtNeto)
        Me.pnlTotales.Controls.Add(Me.txtBruto)
        Me.pnlTotales.Controls.Add(Me.lblNeto)
        Me.pnlTotales.Controls.Add(Me.lblBruto)
        Me.pnlTotales.Controls.Add(Me.txtAvisos)
        Me.pnlTotales.Controls.Add(Me.lblAvisos)
        Me.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotales.Location = New System.Drawing.Point(0, 365)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Size = New System.Drawing.Size(624, 32)
        Me.pnlTotales.TabIndex = 27
        '
        'txtNeto
        '
        Me.txtNeto.BackColor = System.Drawing.Color.White
        Me.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNeto.Location = New System.Drawing.Point(298, 6)
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.ReadOnly = True
        Me.txtNeto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNeto.Size = New System.Drawing.Size(112, 20)
        Me.txtNeto.TabIndex = 3
        Me.txtNeto.TabStop = False
        Me.txtNeto.Text = "0"
        '
        'txtBruto
        '
        Me.txtBruto.BackColor = System.Drawing.Color.White
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.Location = New System.Drawing.Point(138, 6)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.ReadOnly = True
        Me.txtBruto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBruto.Size = New System.Drawing.Size(112, 20)
        Me.txtBruto.TabIndex = 2
        Me.txtBruto.TabStop = False
        Me.txtBruto.Text = "0"
        '
        'lblNeto
        '
        Me.lblNeto.Location = New System.Drawing.Point(258, 8)
        Me.lblNeto.Name = "lblNeto"
        Me.lblNeto.Size = New System.Drawing.Size(48, 16)
        Me.lblNeto.TabIndex = 4
        Me.lblNeto.Text = "Neto $"
        '
        'lblBruto
        '
        Me.lblBruto.Location = New System.Drawing.Point(96, 8)
        Me.lblBruto.Name = "lblBruto"
        Me.lblBruto.Size = New System.Drawing.Size(48, 16)
        Me.lblBruto.TabIndex = 2
        Me.lblBruto.Text = "Bruto $"
        '
        'txtAvisos
        '
        Me.txtAvisos.BackColor = System.Drawing.Color.White
        Me.txtAvisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvisos.Location = New System.Drawing.Point(48, 6)
        Me.txtAvisos.Name = "txtAvisos"
        Me.txtAvisos.ReadOnly = True
        Me.txtAvisos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAvisos.Size = New System.Drawing.Size(40, 20)
        Me.txtAvisos.TabIndex = 1
        Me.txtAvisos.TabStop = False
        Me.txtAvisos.Text = "0"
        '
        'lblAvisos
        '
        Me.lblAvisos.Location = New System.Drawing.Point(8, 8)
        Me.lblAvisos.Name = "lblAvisos"
        Me.lblAvisos.Size = New System.Drawing.Size(40, 16)
        Me.lblAvisos.TabIndex = 0
        Me.lblAvisos.Text = "Avisos"
        '
        'frmEjercicioMedios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 397)
        Me.Controls.Add(Me.pnlTotales)
        Me.Controls.Add(Me.pnlGrilla)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Bottom)
        Me.Name = "frmEjercicioMedios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoja de Planificación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.uManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugPlanificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrilla.ResumeLayout(False)
        Me.pnlGrilla.PerformLayout()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mListaSoportes, mCopias, mFechas As ArrayList
    Private mDatos As DataSet
    Private Conceptos, Soportes, Productos, Materiales, Secciones, IndiceFijo, Provincias, Poblaciones, TiposElementoVP As ValueList
    Private PrensaPoint As New Point
    Private mId_Campania, mId_Sistema, mId_Ejercicio, mIdMedio, mIdTipoSoporte, mIdPlaza, mIdCliente As Integer
    Private mFechaInicio, mFechaFin As DateTime
    Private mDatosCabecera, mSpots, mSpotsDetalle, mSpotsComprados As DataTable
    Private mCellError, mDescCliente, mDescCampania, mDescSistema, mDescEjercicio As String
    Private mAplicandoHabilitacionDescuento, mAplicandoNullValue, mEsCargaNueva, mCerrar As Boolean
    Private mIdSpotNuevo As Integer = -1
    Private mIdSpotDetalleNuevo As Integer = -1
    Private mConvenios As SortedList
    Private Ejer As EjercicioActivo
    Private TipElemVP As List(Of Tipo_Elemento_VP)

    Private ColorLinaDomingo As Color = Color.Red
    Private ColorDia7 As Color = Color.BlueViolet
    Private ColorColTotales As Color = Color.LightYellow
    Private mTemaPrensa As String = "p"
    Private mTemaViaPublica As String = "v"
    Private mSpotDetalleEstado As String = "P"
    Private mMedioViaPublica As Integer = 3
    Private mMedioProduccion As Integer = 7
    Private mMedioRevista As Integer = 5
    Private mMedioPrensa As Integer = 4
    Private mTConvenio As String
    Public WithEvents ConveniosMedios As New frmConveniosMedios

    Private ActualizarDescuentos As Boolean
    Private FilaDuplicada As Boolean = False
    Private AperturaHoja As Boolean = False
    Private mPaste As Boolean

    Private mModificoCarteles As Boolean = False
#End Region

#Region "Variables y Propiedades Publicas"
    Public WriteOnly Property ListaSoportes() As ArrayList
        Set(ByVal Value As ArrayList)
            mListaSoportes = Value
        End Set
    End Property

    Public WriteOnly Property Id_Campania() As Integer
        Set(ByVal Value As Integer)
            mId_Campania = Value
        End Set
    End Property

    Public WriteOnly Property Id_Sistema() As Integer
        Set(ByVal Value As Integer)
            mId_Sistema = Value
        End Set
    End Property

    Public WriteOnly Property Id_Ejercicio() As Integer
        Set(ByVal Value As Integer)
            mId_Ejercicio = Value
        End Set
    End Property

    Public WriteOnly Property IdMedio() As Integer
        Set(ByVal Value As Integer)
            mIdMedio = Value
        End Set
    End Property

    Public WriteOnly Property IdTipoSoporte() As Integer
        Set(ByVal Value As Integer)
            mIdTipoSoporte = Value
        End Set
    End Property

    Public WriteOnly Property IdPlaza() As Integer
        Set(ByVal Value As Integer)
            mIdPlaza = Value
        End Set
    End Property

    Public WriteOnly Property IdCliente() As Integer
        Set(ByVal Value As Integer)
            mIdCliente = Value
        End Set
    End Property

    Public WriteOnly Property Campania() As String
        Set(ByVal Value As String)
            mDescCampania = Value
        End Set
    End Property

    Public WriteOnly Property Sistema() As String
        Set(ByVal Value As String)
            mDescSistema = Value
        End Set
    End Property

    Public WriteOnly Property Ejercicio() As String
        Set(ByVal Value As String)
            mDescEjercicio = Value
        End Set
    End Property

    Public WriteOnly Property Cliente() As String
        Set(ByVal Value As String)
            mDescCliente = Value
        End Set
    End Property

    Public WriteOnly Property FechaInicio() As DateTime
        Set(ByVal Value As DateTime)
            mFechaInicio = Value
        End Set
    End Property

    Public WriteOnly Property FechaFin() As DateTime
        Set(ByVal Value As DateTime)
            mFechaFin = Value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmEjercicioMedios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetearTitulo()
        'AG ++++
        AperturaHoja = False
        '++++++
        'AG Produccion +++++++++++++++++++++++++++++++++++++
        If mIdMedio = Me.mMedioProduccion Then
            mTemaViaPublica = "m"
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++
        Call SetearGrilla()
        uManager.Tools("Buscar Codigo AGIP").SharedProps.Visible = False
        uManager.Tools("Mapa").SharedProps.Visible = False
        If mIdMedio = Me.mMedioViaPublica Then
            uManager.Tools("Buscar Codigo AGIP").SharedProps.Visible = True
            uManager.Tools("Mapa").SharedProps.Visible = True
        End If
    End Sub

    Private Sub frmEjercicioMedios_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        If CantidadCambios() > 0 Then
            If Mensajes.Mensaje("¿Desea Guardar los Cambios?", TipoMensaje.SiNo, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Call Guardar()
                If Not mCerrar Then
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        End If
        Activo.EjerciciosCargados.Remove(Ejer)
    End Sub

    Private Sub ugPlanificacion_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugPlanificacion.AfterExitEditMode
        reemplazo = False
    End Sub

    Private Sub ugPlanificacion_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ugPlanificacion.InitializeLayout
        'Banda 0 (Cabecera)
        e.Layout.Override.WrapHeaderText = DefaultableBoolean.True
        e.Layout.Override.HeaderAppearance.TextHAlign = HAlign.Center
        e.Layout.Bands(0).Override.CellClickAction = UltraWinGrid.CellClickAction.RowSelect
        e.Layout.Bands(0).Columns("Id_Soporte").ValueList = ObtenerSoportes()
        e.Layout.Bands(0).Columns("Id_Soporte").CellActivation = UltraWinGrid.Activation.NoEdit
        e.Layout.Bands(0).Columns("Id_Soporte").AllowRowFiltering = DefaultableBoolean.True

        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Id_Soporte"), "Soporte")
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Id_Producto"), "Producto")
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Id_Material"), "Material")

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Id_Seccion"), "Sección")
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Concepto"), "Concepto")
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Ind_Fijo"), "Tamaño", 60)
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Ancho"), "Longitud", 60)
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Alto"), "Alto", 60)
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Des_Formato"), "Formato")
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Cod_Pobl1"), "Provincia")
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Cod_Pobl2"), "Población")
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Direccion1"), "Calle", 100)
            Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Num_Caras"), "Carteles", 60)

            'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If mIdMedio = mMedioViaPublica Then
                Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Cod_AGIP"), "AGIP", 60)
                'GG -> CISOP
                Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Id_Tipo_Elemento"), "Tipo Elemento")
                Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("CostoUnitario"), "Costo Unitario")
                Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Id_Tipo_Elemento"))
                Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("AnchoVP"), "Ancho", 0, True)
                Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("AltoVP"), "Alto", 0, True)
                Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Cisop"), "CISOP", 0, True)

                Dim editor As EmbeddableEditorBase = New EditorWithText
                'editor.DataFilter = New NullZeroDataFilter
                'e.Layout.Bands(0).Columns("AnchoVP").Editor = editor
                'e.Layout.Bands(0).Columns("AltoVP").Editor = editor
                'e.Layout.Bands(0).Columns("Cisop").Editor = editor
            End If
        End If

        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Id_Seccion"), "Sección")
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Concepto"), "Concepto")
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Ind_Fijo"), "Tamaño", 60)
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Ancho"), "Longitud", 60)
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Alto"), "Alto", 60)
        'Else
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Des_Formato"), "Formato")
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Cod_Pobl1"), "Provincia")
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Cod_Pobl2"), "Población")
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Direccion1"), "Calle", 100)
        '    'AG Caras ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        '    Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Num_Caras"), "Carteles", 60)
        '    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Bruto"), "Bruto", 90)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("dcto1"), "D1", 30)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("dcto2"), "D2", 30)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("dcto3"), "D3", 30)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("dcto4"), "D4", 30)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("dcto5"), "D5", 30)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("Neto"), "Neto", 90)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("TotalSpots"), "Spots", 40, True)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("TotalBruto"), "Inv. Bruta", 100, True)
        Call AplicarFormatoCabecera(e.Layout.Bands(0).Columns("TotalNeto"), "Inv. Neta", 100, True)
        Call AplicarFormatoColumnaTotal(e.Layout.Bands(0).Columns("TotalSpots"))
        Call AplicarFormatoColumnaTotal(e.Layout.Bands(0).Columns("TotalBruto"))
        Call AplicarFormatoColumnaTotal(e.Layout.Bands(0).Columns("TotalNeto"))
        Call AplicarFormatoCurrency(e.Layout.Bands(0).Columns("TotalBruto"))
        Call AplicarFormatoCurrency(e.Layout.Bands(0).Columns("TotalNeto"))
        Call AplicarFormatoCabeceraCalendario(e.Layout.Bands(0))
        Call DeshabilitarOrdenamiento(e.Layout.Bands(0))

        'Banda 1 (Spots)
        e.Layout.Bands(1).Override.CellClickAction = UltraWinGrid.CellClickAction.Edit
        e.Layout.Bands(1).ColHeadersVisible = False
        e.Layout.Bands(1).Columns("Neto").CellActivation = Activation.NoEdit
        e.Layout.Bands(1).Columns("TotalSpots").CellActivation = Activation.NoEdit
        e.Layout.Bands(1).Columns("TotalBruto").CellActivation = Activation.NoEdit
        e.Layout.Bands(1).Columns("TotalNeto").CellActivation = Activation.NoEdit
        Call AplicarColumnasOcultas(e.Layout.Bands(1))
        e.Layout.Bands(1).Columns("Id_Soporte").Hidden = True
        Call AplicarCeldaOculta(e.Layout.Bands(1).Columns("ControlConvenio"))

        Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Id_Producto"))
        Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Id_Material"))

        'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            e.Layout.Bands(1).Columns("Concepto").MaxLength = 300
            e.Layout.Bands(1).Columns("Concepto").Width = 150
            Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("DetalleColor"))
            Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Id_Seccion"))
            Call AplicarFormatoRadioButton(e.Layout.Bands(1).Columns("Ind_Fijo"))
            Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("Ancho"), False)
            Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("Alto"), False)
            'CF permite numeros negativos
            e.Layout.Bands(1).Columns("Bruto").Format = "C"
            e.Layout.Bands(1).Columns("Bruto").CellAppearance.TextHAlign = HAlign.Right
            e.Layout.Bands(1).Columns("Neto").Format = "C"
            e.Layout.Bands(1).Columns("Neto").CellAppearance.TextHAlign = HAlign.Right
            e.Layout.Bands(1).Columns("TotalBruto").Format = "C"
            e.Layout.Bands(1).Columns("TotalBruto").CellAppearance.TextHAlign = HAlign.Right
            e.Layout.Bands(1).Columns("TotalNeto").Format = "C"
            e.Layout.Bands(1).Columns("TotalNeto").CellAppearance.TextHAlign = HAlign.Right
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            e.Layout.Bands(1).Columns("Des_Formato").MaxLength = 60
            e.Layout.Bands(1).Columns("Direccion1").MaxLength = 100
            Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Cod_Pobl1"))
            Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Cod_Pobl2"))
            'AG Produccion +++++++++++++++++++++++++++++++++++++++++ 
            If mIdMedio = Me.mMedioProduccion Then
                e.Layout.Bands(0).Columns("Num_Caras").Hidden = True
                e.Layout.Bands(0).Columns("Id_Material").Hidden = True
                e.Layout.Bands(0).Columns("Direccion1").Hidden = True
            End If
            If mIdMedio = Me.mMedioViaPublica Then
                e.Layout.Bands(1).Columns("Cod_AGIP").CellActivation = Activation.NoEdit
            End If
            '++++++++++++++++++++++++++++++++++++++++++++++++++++
        End If

        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    e.Layout.Bands(1).Columns("Concepto").MaxLength = 50
        '    e.Layout.Bands(1).Columns("Concepto").Width = 150
        '    Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("DetalleColor"))
        '    ''Call AplicarFormatoDropDown(e.Layout.Bands(1).Columns("Concepto"))
        '    Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Id_Seccion"))
        '    Call AplicarFormatoRadioButton(e.Layout.Bands(1).Columns("Ind_Fijo"))
        '    Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("Ancho"), False)
        '    Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("Alto"), False)
        'Else
        '    e.Layout.Bands(1).Columns("Des_Formato").MaxLength = 50
        '    e.Layout.Bands(1).Columns("Direccion1").MaxLength = 100
        '    Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Cod_Pobl1"))
        '    Call AplicarFormatoDropDownList(e.Layout.Bands(1).Columns("Cod_Pobl2"))
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        'LC permite numeros negativos        
        e.Layout.Bands(1).Columns("Bruto").Format = "C"
        e.Layout.Bands(1).Columns("Bruto").CellAppearance.TextHAlign = HAlign.Right
        e.Layout.Bands(1).Columns("Neto").Format = "C"
        e.Layout.Bands(1).Columns("Neto").CellAppearance.TextHAlign = HAlign.Right
        e.Layout.Bands(1).Columns("TotalBruto").Format = "C"
        e.Layout.Bands(1).Columns("TotalBruto").CellAppearance.TextHAlign = HAlign.Right
        e.Layout.Bands(1).Columns("TotalNeto").Format = "C"
        e.Layout.Bands(1).Columns("TotalNeto").CellAppearance.TextHAlign = HAlign.Right

        Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("dcto1"))
        Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("dcto2"))
        Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("dcto3"))
        Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("dcto4"))
        Call AplicarFormatoPorcentaje(e.Layout.Bands(1).Columns("dcto5"))
        Call AplicarTextoNumericoPosicion(e.Layout.Bands(1))
        Call AplicarFormatoCalendario(e.Layout.Bands(1))
        Call AplicarFormatoColumnaTotal(e.Layout.Bands(1).Columns("TotalSpots"))
        Call AplicarFormatoColumnaTotal(e.Layout.Bands(1).Columns("TotalBruto"))
        Call AplicarFormatoColumnaTotal(e.Layout.Bands(1).Columns("TotalNeto"))

        'Banda 2 (Spots Detalle)
        e.Layout.Bands(2).Hidden = True

        ugPlanificacion.Rows.ExpandAll(True)
        Call AplicarSumatoria(ugPlanificacion, ugPlanificacion.DisplayLayout.Bands(0))
    End Sub

    Private Sub ugPlanificacion_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugPlanificacion.AfterCellUpdate
        If EsColumnaCalendario(e.Cell.Column.Key) Then
            If e.Cell.Band.Index = 1 AndAlso Not mAplicandoNullValue Then
                If ValidarCompras(e.Cell) Then
                    Call ABMSpotsDetalle(e.Cell)
                    Call CalcularTotales()
                End If
            End If
        Else
            Select Case e.Cell.Column.Key
                'Case "Concepto"
                '    Dim ConceptoIngresado As String = e.Cell.Text
                '    If Conceptos.FindByDataValue(ConceptoIngresado) Is Nothing Then
                '        Conceptos.ValueListItems.Add(e.Cell.Text)
                '    End If
                Case "dcto1", "dcto2", "dcto3", "dcto4", "dcto5"
                    If Not mAplicandoHabilitacionDescuento Then
                        mAplicandoHabilitacionDescuento = True
                        Call AplicarHabilitacionDescuento(e.Cell.Row)
                        Call CalcularNeto(e.Cell.Row)
                        Call CalcularTotalesModif(e.Cell)
                        Call CalcularTotales()
                        mAplicandoHabilitacionDescuento = False
                    End If
                Case "Bruto", "Ancho", "Alto"
                    Call ValidarValoresNumericos(e.Cell.Row)
                    If e.Cell.Column.Key = "Bruto" AndAlso e.Cell.Value = 0 Then
                        Call InicializarDescuentos(e.Cell.Row)
                    End If
                    Call CalcularNeto(e.Cell.Row)
                    Call CalcularTotalesModif(e.Cell)
                    Call CalcularTotales()
                Case "Des_Formato", "Concepto"

                    Dim textformat As String
                    textformat = e.Cell.Text.Replace("'", "´")
                    If e.Cell.Value.ToString.Length >= 50 And reemplazo = False Then
                        Mensaje("Se alcanzó el máximo de 50 caracteres del campo", TipoMensaje.Informacion)
                        textformat = "" '04/03/2015 borro el valor del campo cuando supera el maximo de caractres
                    End If

                    If reemplazo = False Then
                        reemplazo = True
                        e.Cell.Value = textformat
                    End If
                Case "Num_Caras"
                    Dim caras As Integer = 0
                    If Not IsNumeric(e.Cell.Value) Then
                        Mensaje("Este campo solo admite números", TipoMensaje.Informacion)
                    Else
                        caras = CInt(e.Cell.Value)
                        'AN 04-03-2016 Flag que indica que se modifico el bruto en base a la cantidad de carteles
                        Me.mModificoCarteles = True
                        e.Cell.Row.Cells("Bruto").Value = e.Cell.Row.Cells("CostoUnitario").Value * caras
                    End If
                Case "CostoUnitario"
                    Dim cunitario As Integer = 0
                    If IsNumeric(e.Cell.Value) Then
                        cunitario = CInt(e.Cell.Value)
                        e.Cell.Row.Cells("Bruto").Value = e.Cell.Row.Cells("Num_Caras").Value * cunitario
                    End If
            End Select
        End If


        Dim pRow As UltraGridRow = e.Cell.Row

        'Bruto = pRow.Cells("Bruto").Value

        If AperturaHoja = True Then
            Try
                If e.Cell.Column.Key = "dcto1" Or e.Cell.Column.Key = "dcto2" Or e.Cell.Column.Key = "dcto3" Or e.Cell.Column.Key = "dcto4" Or e.Cell.Column.Key = "dcto5" Then
                    Dim control As Boolean = False
                    If pRow.Cells("dcto1").Value = 0 And pRow.Cells("dcto2").Value = 0 And pRow.Cells("dcto3").Value = 0 And pRow.Cells("dcto4").Value = 0 And pRow.Cells("dcto5").Value = 0 Then
                        Me.ugPlanificacion.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                        Me.ugPlanificacion.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                        Me.ugPlanificacion.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                        Me.ugPlanificacion.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                        Me.ugPlanificacion.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                        Me.ugPlanificacion.ActiveRow.Cells("Id_Convenio").Value = 0
                    Else
                        If FilaDuplicada = True Then
                            If Me.ugPlanificacion.ActiveRow.Cells("Id_Convenio").Value >= 0 Then
                                Me.ugPlanificacion.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.White
                                Me.ugPlanificacion.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.White
                                Me.ugPlanificacion.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.White
                                Me.ugPlanificacion.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.White
                                Me.ugPlanificacion.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.White
                            End If
                        Else
                            Me.ugPlanificacion.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("Id_Convenio").Value = -1
                            control = True
                        End If
                    End If

                    If control = False Then
                        If Me.ugPlanificacion.ActiveRow.Cells("Id_Convenio").Value > 0 Then
                            Me.ugPlanificacion.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.White
                            Me.ugPlanificacion.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.White
                            Me.ugPlanificacion.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.White
                            Me.ugPlanificacion.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.White
                            Me.ugPlanificacion.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.White
                        End If
                        If Me.ugPlanificacion.ActiveRow.Cells("Id_Convenio").Value = 0 Then
                            Me.ugPlanificacion.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                            Me.ugPlanificacion.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
                            Me.ugPlanificacion.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
                        End If
                    End If
                End If

                'AN 17/02/2016 USAR LA VARIABLE DE ABAJO PARA HABILITAR O DESHABILITAR EL BLANQUEO DE CONVENIOS (En FALSE TODO QUEDA COMO ANTES).
                'AN 04-03-2016 Inhabilito blanqueo de convenio en caso de que la modificacion del bruto sea a causa de la modificion de los carteles.
                Dim habilitaBlanqueoConvenio As Boolean = IIf(Not Me.mModificoCarteles, True, False)
                Dim colorCelda As Color = IIf(habilitaBlanqueoConvenio, Color.Bisque, Color.White)

                'AG 08/05/2012 control de Convenios tarifas +++++++++++++++++++++++++++++++++++++++++++
                If e.Cell.Column.Key = "Neto" Then
                    Dim dtConvenios As DataTable
                    Dim netoConvenio As Decimal
                    Dim controla As Boolean = False
                    If pRow.Cells("Id_Convenio").Value > 0 Then
                        Dim OConvenio As New Convenios
                        Dim TipoConvenio As String
                        'Busco en la base que tipo de convenio es ( D o T ) mediante el id_convenio
                        OConvenio.Id_cliente = Activo.IDCliente
                        OConvenio.Id_soporte = CInt(pRow.Cells("Id_Soporte").Value)
                        OConvenio.Id_medio = Activo.IDMedio
                        OConvenio.Id_convenio = CInt(pRow.Cells("Id_Convenio").Value)
                        TipoConvenio = OConvenio.ObtenerTipoConvenioSpot()
                        dtConvenios = OConvenio.ObtenerConvenioxId()
                        If dtConvenios.Rows.Count > 0 Then
                            netoConvenio = dtConvenios.Rows(0)("IMP_NETO_VENTA")
                        End If
                        'Si el convenio es de TARIFA se pone codigo convenio = -1 y se colorea las celdas de descuentos
                        'Si el conveio es de DESCUENTO te deja cambiara a mano la tarifa bruta y deja el mismo codigo de convenio de descuento
                        If TipoConvenio = "T" Or (TipoConvenio = "D" And netoConvenio > 0 And habilitaBlanqueoConvenio) Then
                            Me.ugPlanificacion.ActiveRow.Cells("dcto1").Appearance.BackColor = colorCelda
                            Me.ugPlanificacion.ActiveRow.Cells("dcto2").Appearance.BackColor = colorCelda
                            Me.ugPlanificacion.ActiveRow.Cells("dcto3").Appearance.BackColor = colorCelda
                            Me.ugPlanificacion.ActiveRow.Cells("dcto4").Appearance.BackColor = colorCelda
                            Me.ugPlanificacion.ActiveRow.Cells("dcto5").Appearance.BackColor = colorCelda
                            If habilitaBlanqueoConvenio Then
                                Me.ugPlanificacion.ActiveRow.Cells("Id_Convenio").Value = -1 'Permite editar un convenio de Tarifa el bruto para que no le quite el codigo del convenio aplicado    
                                Me.ugPlanificacion.ActiveRow.Cells("ControlConvenio").Appearance.Image = Nothing
                            End If
                        End If
                    End If
                End If
                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                If e.Cell.Column.Key = "Num_Caras" Then
                    'AN 04-03-2016 Blanqueo Flag que indica que se modifico el bruto en base a la cantidad de carteles
                    Me.mModificoCarteles = Not Me.mModificoCarteles
                End If
            Catch ex As Exception
                Me.ugPlanificacion.ActiveRow.Cells("dcto1").Appearance.BackColor = Color.White
                Me.ugPlanificacion.ActiveRow.Cells("dcto2").Appearance.BackColor = Color.White
                Me.ugPlanificacion.ActiveRow.Cells("dcto3").Appearance.BackColor = Color.White
                Me.ugPlanificacion.ActiveRow.Cells("dcto4").Appearance.BackColor = Color.White
                Me.ugPlanificacion.ActiveRow.Cells("dcto5").Appearance.BackColor = Color.White
            End Try
        End If
    End Sub

    Private Sub ugPlanificacion_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugPlanificacion.CellChange
        Select Case e.Cell.Column.Key
            Case "Ind_Fijo"
                e.Cell.Row.Cells("Ind_Fijo").Value = CType(e.Cell.EditorResolved, OptionSetEditor).Value
                If CType(e.Cell.EditorResolved, OptionSetEditor).Value Then
                    e.Cell.Row.Cells("Ancho").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("Ancho").Value = 0
                    e.Cell.Row.Cells("Alto").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("Alto").Value = 0
                Else
                    e.Cell.Row.Cells("Ancho").Activation = Activation.AllowEdit
                    e.Cell.Row.Cells("Ancho").Value = 0
                    e.Cell.Row.Cells("Alto").Activation = Activation.AllowEdit
                    e.Cell.Row.Cells("Alto").Value = 0
                End If

                Call CalcularNeto(e.Cell.Row)
                Call CalcularTotales()
            Case "Id_Producto"
                If Convert.ToInt32(CType(e.Cell.EditorResolved, EditorWithCombo).Value) = 0 Then
                    e.Cell.Row.Cells("Id_Material").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("Id_Material").Value = "0"
                Else
                    e.Cell.Row.Cells("Id_Material").ValueList = ObtenerMateriales(Convert.ToInt32(CType(e.Cell.EditorResolved, EditorWithCombo).Value))
                    e.Cell.Row.Cells("Id_Material").Value = "0"
                    e.Cell.Row.Cells("Id_Material").Activation = Activation.AllowEdit
                End If
            Case "Cod_Pobl1"
                If Convert.ToInt32(CType(e.Cell.EditorResolved, EditorWithCombo).Value) = 0 Then
                    e.Cell.Row.Cells("Cod_Pobl2").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("Cod_Pobl2").Value = "0"
                Else
                    e.Cell.Row.Cells("Cod_Pobl2").ValueList = ObtenerPoblaciones(Convert.ToInt32(CType(e.Cell.EditorResolved, EditorWithCombo).Value))
                    e.Cell.Row.Cells("Cod_Pobl2").Value = "0"
                    e.Cell.Row.Cells("Cod_Pobl2").Activation = Activation.AllowEdit
                    'LC 27/03/2014 Cuando la poblacion no es Capital borra el codigo AGIP
                    If mIdMedio = mMedioViaPublica And e.Cell.Row.Cells("Cod_Pobl2").Value <> 1 Then
                        e.Cell.Row.Cells("Cod_AGIP").Value = String.Empty
                    End If
                End If
                'AG 02/09/2011 ++++++++++++++++++++++++++++++++++++++++++++++++++
                If Convert.ToInt32(CType(e.Cell.EditorResolved, EditorWithCombo).Value) > 1 Then
                    e.Cell.Row.Cells("Num_Caras").Value = 0
                    e.Cell.Row.Cells("Num_Caras").Activation = Activation.AllowEdit
                End If
                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                'GG 19/05/2015 Dimensiones + CISOP
            Case "Id_Tipo_Elemento"
                Dim id As Integer = Convert.ToInt32(CType(e.Cell.EditorResolved, EditorWithCombo).Value)

                Dim tipo As Tipo_Elemento_VP = TipElemVP.Where(Function(o) o.IdTipoElemento = id).FirstOrDefault()

                If Not tipo Is Nothing AndAlso tipo.RequiereMedida Then
                    e.Cell.Row.Cells("AnchoVP").Activation = Activation.AllowEdit
                    e.Cell.Row.Cells("AltoVP").Activation = Activation.AllowEdit
                Else
                    e.Cell.Row.Cells("AnchoVP").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("AltoVP").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("Cisop").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("AnchoVP").Value = DBNull.Value
                    e.Cell.Row.Cells("AltoVP").Value = DBNull.Value
                    e.Cell.Row.Cells("Cisop").Value = DBNull.Value
                End If
            Case "AnchoVP"
                Dim act As Boolean = False

                Dim gridAncho As Object
                If e.Cell.EditorResolved.IsValid Then
                    gridAncho = e.Cell.EditorResolved.Value
                Else
                    gridAncho = DBNull.Value
                End If

                Dim gridAlto As Object = e.Cell.Row.Cells("AltoVP").Value

                If (Not gridAncho Is DBNull.Value) AndAlso (Not gridAlto Is DBNull.Value) Then
                    Dim ancho As Single
                    Single.TryParse(gridAncho, ancho)

                    Dim alto As Single
                    Single.TryParse(gridAlto, alto)

                    If (ancho * alto) >= 30 Then
                        act = True
                    End If
                End If

                If act Then
                    e.Cell.Row.Cells("Cisop").Activation = Activation.AllowEdit
                Else
                    e.Cell.Row.Cells("Cisop").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("Cisop").Value = DBNull.Value
                End If
            Case "AltoVP"
                Dim act As Boolean = False

                Dim gridAncho As Object = e.Cell.Row.Cells("AnchoVP").Value
                Dim gridAlto As Object

                If e.Cell.EditorResolved.IsValid Then
                    gridAlto = e.Cell.EditorResolved.Value
                Else
                    gridAlto = DBNull.Value
                End If


                If (Not gridAncho Is DBNull.Value) AndAlso (Not gridAlto Is DBNull.Value) Then
                    Dim ancho As Single
                    Single.TryParse(gridAncho, ancho)

                    Dim alto As Single
                    Single.TryParse(gridAlto, alto)

                    If (ancho * alto) >= 30 Then
                        act = True
                    End If
                End If

                If act Then
                    e.Cell.Row.Cells("Cisop").Activation = Activation.AllowEdit
                Else
                    e.Cell.Row.Cells("Cisop").Activation = Activation.NoEdit
                    e.Cell.Row.Cells("Cisop").Value = DBNull.Value
                End If
        End Select
    End Sub

    Private Sub ugPlanificacion_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugPlanificacion.MouseDown
        PrensaPoint.X = e.X
        PrensaPoint.Y = e.Y
        If e.Button = MouseButtons.Right Then
            Dim aUIElement As Infragistics.Win.UIElement
            Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
            Dim GridCell As Infragistics.Win.UltraWinGrid.UltraGridCell

            aUIElement = ugPlanificacion.DisplayLayout.UIElement.ElementFromPoint(New Point(PrensaPoint.X, PrensaPoint.Y))
            ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

            If ColumnHeader Is Nothing Then
                GridCell = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridCell))
                If Not GridCell Is Nothing Then
                    If EsColumnaCalendario(GridCell.Column.Key) AndAlso GridCell.Row.Band.Index = 1 AndAlso GridCell.Text <> String.Empty AndAlso IsNumeric(GridCell.Value) AndAlso GridCell.Value > 0 Then
                        If GridCell.Activation = Activation.AllowEdit Then
                            ugPlanificacion.Selected.Cells.Clear()
                            ugPlanificacion.Selected.Rows.Clear()
                            ugPlanificacion.Selected.Cells.Add(GridCell)

                            Call SetearMenuDia(GridCell.Row.Cells("Id_Spot").Value, GridCell.Column.Key)
                        End If
                    Else
                        If GridCell.Row.Selected Then
                            If GridCell.Row.Band.Index = 1 Then
                                uManager.ShowPopup("PopupMenuHijo")
                            Else
                                uManager.ShowPopup("PopupMenuPadre")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ugPlanificacion_CellDataError(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs) Handles ugPlanificacion.CellDataError
        If ugPlanificacion.ActiveCell Is Nothing Then
            Exit Sub
        End If
        Select Case ugPlanificacion.ActiveCell.Column.Key
            Case "Neto", "Bruto", "dcto1", "dcto2", "dcto3", "dcto4", "dcto5", "Ancho", "Alto", "AnchoVP", "AltoVP", "CostoUnitario"
                If Not IsNumeric(ugPlanificacion.ActiveCell.Text) Then
                    Mensaje("Este campo solo admite números", TipoMensaje.Informacion)
                Else
                    Select Case ugPlanificacion.ActiveCell.Column.Key
                        Case "dcto1", "dcto2", "dcto3", "dcto4", "dcto5"
                            If ugPlanificacion.ActiveCell.Text > 100 OrElse ugPlanificacion.ActiveCell.Text < -100 Then
                                Mensaje("El porcentaje debe ir desde -100 a 100", TipoMensaje.Informacion)
                            End If
                        Case "Ancho", "Alto"
                            If ugPlanificacion.ActiveCell.Text > 100 OrElse ugPlanificacion.ActiveCell.Text < 0 Then
                                Mensaje("La dimensión debe ir desde 0 a 100", TipoMensaje.Informacion)
                            Else
                                Mensaje("Este campo solo admite números enteros.")
                            End If
                    End Select
                End If
            Case "Num_Caras"
                If Not IsNumeric(ugPlanificacion.ActiveCell.Text) Then
                    Mensaje("Este campo solo admite números", TipoMensaje.Informacion)
                End If
                e.RestoreOriginalValue = True
        End Select

        e.RaiseErrorEvent = False
    End Sub

    Private Sub ugPlanificacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ugPlanificacion.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.Handled = True

            If ugPlanificacion.ActiveCell.IsInEditMode Then
                If EsColumnaCalendario(ugPlanificacion.ActiveCell.Column.Key) Then
                    ugPlanificacion.UpdateData()
                End If
                ugPlanificacion.PerformAction(UltraGridAction.ExitEditMode, False, False)
            Else
                ugPlanificacion.PerformAction(UltraGridAction.EnterEditMode, False, False)
            End If
        End If

        'AG 10/05/2011 +++++++
        AperturaHoja = True
        '++++++++++++++++++
    End Sub

    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Sub ugPlanificacion_DoubleClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles ugPlanificacion.DoubleClickCell
        If mIdMedio = mMedioViaPublica Then
            Dim grid As UltraGrid = DirectCast(sender, UltraGrid)
            Dim element As UIElement = grid.DisplayLayout.UIElement.LastElementEntered
            Dim cell As UltraGridCell = DirectCast(element.GetContext(GetType(UltraGridCell)), UltraGridCell)
            Dim row As UltraGridRow = DirectCast(element.GetContext(GetType(UltraGridRow)), UltraGridRow)
            If cell.Column.Header.Caption = "Cod_AGIP" Then
                Dim f As New frmFiltrarPadronAGIPMasivo()
                If row.Cells("Cod_Pobl1").Value = 1 Then
                    f.DetalleAGIP.CUIT = BuscarCuitProveedor(grid.Rows(Me.ugPlanificacion.ActiveRow.ParentRow.Index).Cells(0).Text)
                    f.CodigosAGIPAnteriores = row.Cells("Cod_AGIP").Value
                    f.ShowDialog()
                    If Not f.Cancelado Then
                        cell.Value = f.CodigoAGIP
                        row.Cells("Cod_AGIP").Activation = Activation.NoEdit
                    End If
                Else
                    cell.Value = String.Empty
                    row.Cells("Cod_AGIP").Activation = Activation.NoEdit
                End If
            End If
        End If
    End Sub

    Private Sub uManager_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles uManager.ToolClick
        Select Case e.Tool.Key
            Case "EliminarHijo"
                If Not ValidarAvisosComprados() Then Exit Sub
                Call EliminarHijo()
            Case "EliminarPadre"
                If Not ValidarAvisosComprados() Then Exit Sub
                Call EliminarPadre()
            Case "AgregarHijo"
                Call AgregarHijo()
            Case "DuplicarHijo"
                Call DuplicarHijo()
            Case "Copiar"
                Call CopiarHijo()
            Case "Pegar"
                Call PegarHijo()
            Case "Guardar"
                Call Guardar()
            Case "Borrar"
                Call Eliminar()
            Case "Soportes"
                Call AgregarSoportes()
            Case "Puntual", "AgregarConvenioHijo"
                Call BuscarConvenios()
            Case "Global"
                Call BuscarConvenios(False)
            Case "EliminarConvenioHijo"
                Call EliminarConvenios()
            Case "Imprimir"
                Call ExportarImprimir()
            Case "Exportar"
                Call ExportarImprimir(False)
            Case "ExpandirColapsar"
                Call ExpandirColapsar()
            Case "AgregarObservacion", "ModificarObservacion"
                Call AgregarModificarObservaciones()
            Case "EliminarObservacion"
                Call EliminarObservacion()
                'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Case "Buscar Codigo AGIP"
                Call AgregarCodigoAGIP()
            Case "Mapa"
                Call MostrarMapa()
        End Select

        'AG 02/06/2011 +++++++++++++
        FilaDuplicada = False
        '++++++++++++++++++++++++
    End Sub

    Private Sub ConveniosMedios_AplicarConvenio(ByVal pId_Convenio As Integer, ByVal pId_Soporte As Integer, ByVal pId_Producto As Integer, ByVal pD1 As Double, ByVal pD2 As Double, ByVal pD3 As Double, ByVal pD4 As Double, ByVal pD5 As Double, ByVal pNeto As Double, ByVal pTipoConvenio As String, ByVal pPuntual As Boolean) Handles ConveniosMedios.AplicarConvenio
        Dim RowModified As UltraGridRow
        If pPuntual Then
            Me.mTConvenio = pTipoConvenio
            For Each RowSeleccionada As UltraGridRow In ugPlanificacion.Selected.Rows
                If RowSeleccionada.Cells("Id_Soporte").Value = pId_Soporte AndAlso (pId_Producto = 0 OrElse RowSeleccionada.Cells("Id_Producto").Value = pId_Producto) AndAlso RowSeleccionada.Cells("Bruto").Activation <> Activation.NoEdit Then
                    RowModified = ObtenerRow(RowSeleccionada.Cells("Id_Spot").Value)
                    If RowModified Is Nothing Then Exit Sub
                    Dim Carteles As Integer = 0
                    If mIdMedio = mMedioViaPublica Then
                        If CInt(RowModified.Cells("Num_Caras").Value) <> 0 Then
                            Carteles = CInt(RowModified.Cells("Num_Caras").Value)
                        End If
                    Else
                        Carteles = 1
                    End If
                    If pTipoConvenio = "D" Then
                        RowModified.Cells("dcto1").Value = pD1
                        RowModified.Cells("dcto2").Value = pD2
                        RowModified.Cells("dcto3").Value = pD3
                        RowModified.Cells("dcto4").Value = pD4
                        RowModified.Cells("dcto5").Value = pD5
                        'AG 16/06/2014 ===============================
                        If pNeto = 0.0 Then 'Es solo descuento 
                            'AN 21-03-2016
                            'RowModified.Cells("Bruto").Value = pNeto
                        ElseIf pNeto > 0.0 Then 'Descuento y Tarifa
                            'RowModified.Cells("Bruto").Value = pNeto
                            'RowModified.Cells("Bruto").Value = pNeto
                            ' corregido gw 31/08/2015
                            RowModified.Cells("Bruto").Value = pNeto * Carteles
                            If mIdMedio = mMedioViaPublica Then
                                RowModified.Cells("CostoUnitario").Value = pNeto
                                RowModified.Cells("CostoUnitario").Activation = ObtenerActivacionCostoUnitario(pTipoConvenio, pNeto)
                            End If
                            '------------------------

                        End If
                        '=============================================
                    Else
                        'RowModified.Cells("Bruto").Value = pNeto
                        'RowModified.Cells("Bruto").Value = pNeto
                        ' modificado gw 31/08/2015
                        RowModified.Cells("Bruto").Value = pNeto * Carteles
                        If mIdMedio = mMedioViaPublica Then
                            RowModified.Cells("CostoUnitario").Value = pNeto
                            RowModified.Cells("CostoUnitario").Activation = ObtenerActivacionCostoUnitario(pTipoConvenio, pNeto)
                        End If
                        ' fin modif
                        'AG 01/09/2011 +++++++++++++++++++++++
                        RowModified.Cells("dcto1").Value = pD1
                        RowModified.Cells("dcto2").Value = pD2
                        RowModified.Cells("dcto3").Value = pD3
                        RowModified.Cells("dcto4").Value = pD4
                        RowModified.Cells("dcto5").Value = pD5
                        '++++++++++++++++++++++++++++++++++
                    End If
                    RowModified.Cells("Id_Convenio").Value = pId_Convenio


                    'JJP 17/09/2010  - Fuerzo la modificación del datatable
                    ' Al guardar la hoja no estaba tomando los cambios en el dataset asociado a la grilla y por eso no guardaba el convenio
                    Dim Dr As DataRow

                    Try
                        Dr = mSpots.Select("id_Spot = " & RowSeleccionada.Cells("Id_Spot").Value)(0)
                    Catch ex As IndexOutOfRangeException
                        Mensajes.Mensaje("El IDSpot No Existe en el DataTable: " & ex.Message, TipoMensaje.DeError)
                        Exit Sub
                    End Try

                    Dr("id_convenio") = pId_Convenio

                    If pTipoConvenio = "D" Then
                        Dr("dcto1") = pD1
                        Dr("dcto2") = pD2
                        Dr("dcto3") = pD3
                        Dr("dcto4") = pD4
                        Dr("dcto5") = pD5
                        'AG 16/06/2014 ===========
                        If pNeto = 0.0 Then 'Es solo descuento 
                            Dr("bruto") = Dr("bruto")
                        ElseIf pNeto > 0.0 Then 'Descuento y Tarifa
                            Dr("bruto") = pNeto * Carteles
                        End If
                        '=========================
                    Else
                        Dr("bruto") = pNeto * Carteles
                        'AG 01/09/2011 +++++++
                        Dr("dcto1") = pD1
                        Dr("dcto2") = pD2
                        Dr("dcto3") = pD3
                        Dr("dcto4") = pD4
                        Dr("dcto5") = pD5
                        'actual
                        '+++++++++++++++++
                    End If
                    'AG 01/07/2011 ---------------------------------------------------------
                    ActualizarDescuentos = True
                    '-----------------------------------------------------------------------------
                    '''''''''''''''''''''''''''''''''''''''''''''''''JJP 17/09/2010

                    If pId_Convenio > 0 Then
                        Call SetearCeldaConvenio(RowSeleccionada.Cells("Id_Spot").Value, True, pId_Producto)
                    Else
                        Call SetearCeldaConvenio(RowSeleccionada.Cells("Id_Spot").Value, False)
                    End If
                End If
            Next
        Else
            Me.mTConvenio = pTipoConvenio
            For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                For Each Childs As UltraGridChildBand In RowParent.ChildBands
                    For Each Row As UltraGridRow In Childs.Rows
                        If Row.Cells("Id_Soporte").Value = pId_Soporte AndAlso (pId_Producto = 0 OrElse Row.Cells("Id_Producto").Value = pId_Producto) AndAlso Row.Cells("Bruto").Activation <> Activation.NoEdit Then
                            Dim Carteles As Integer = 0
                            If mIdMedio = mMedioViaPublica Then
                                If CInt(Row.Cells("Num_Caras").Value) <> 0 Then
                                    Carteles = CInt(Row.Cells("Num_Caras").Value)
                                End If
                            Else
                                Carteles = 1
                            End If
                            If pTipoConvenio = "D" Then
                                Row.Cells("dcto1").Value = pD1
                                Row.Cells("dcto2").Value = pD2
                                Row.Cells("dcto3").Value = pD3
                                Row.Cells("dcto4").Value = pD4
                                Row.Cells("dcto5").Value = pD5
                                'AG 16/06/2014 =====================
                                If pNeto = 0.0 Then 'Es solo descuento 
                                    Row.Cells("Bruto").Value = pNeto
                                ElseIf pNeto > 0.0 Then 'Descuento y Tarifa
                                    'Row.Cells("Bruto").Value = pNeto
                                    'Row.Cells("Bruto").Value = pNeto
                                    ' modificado gw 31/08/2015
                                    Row.Cells("Bruto").Value = pNeto * Carteles
                                    If mIdMedio = mMedioViaPublica Then
                                        Row.Cells("CostoUnitario").Value = pNeto
                                        Row.Cells("CostoUnitario").Activation = ObtenerActivacionCostoUnitario(pTipoConvenio, pNeto)
                                    End If
                                    '--------------------
                                End If
                                'Row.Cells("Bruto").Value = pNeto
                                '===================================
                                'AG 03/11/2010 ---------------------------------------------------------
                                ActualizarDescuentos = True
                                '-----------------------------------------------------------------------------
                            Else
                                Row.Cells("Bruto").Value = pNeto * Carteles
                                If mIdMedio = mMedioViaPublica Then
                                    Row.Cells("CostoUnitario").Value = pNeto
                                    Row.Cells("CostoUnitario").Activation = ObtenerActivacionCostoUnitario(pTipoConvenio, pNeto)
                                End If

                                'AG 01/09/2011 ++++++++++++++++++++
                                Row.Cells("dcto1").Value = pD1
                                Row.Cells("dcto2").Value = pD2
                                Row.Cells("dcto3").Value = pD3
                                Row.Cells("dcto4").Value = pD4
                                Row.Cells("dcto5").Value = pD5
                                ActualizarDescuentos = True
                                '+++++++++++++++++++++++++++++++
                            End If
                            Row.Cells("Id_Convenio").Value = pId_Convenio

                            If pId_Convenio > 0 Then
                                Call SetearCeldaConvenio(Row.Cells("Id_Spot").Value, True, pId_Producto)
                            Else
                                Call SetearCeldaConvenio(Row.Cells("Id_Spot").Value, False)
                            End If


                        End If
                    Next
                Next
            Next
        End If
        Call CalcularTotales()
    End Sub
#End Region

#Region "Metodos Privados"
    Private Function ObtenerActivacionCostoUnitario(ByVal TipoConvenio As String, ByVal ImporteNeto As Double) As Infragistics.Win.UltraWinGrid.Activation
        Select Case TipoConvenio
            Case "T"
                Return Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Case "D"
                If ImporteNeto <> 0 Then
                    Return Infragistics.Win.UltraWinGrid.Activation.NoEdit
                Else
                    Return Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                End If
            Case Else
                Return Infragistics.Win.UltraWinGrid.Activation.NoEdit
        End Select
    End Function

    Private Sub SetearTitulo()
        Dim Titulo As New StringBuilder
        Titulo.Append(mDescCliente)
        Titulo.Append(" -- ")
        Titulo.Append(mDescCampania)
        Titulo.Append(" - ")
        Titulo.Append(mDescSistema)
        Titulo.Append(" - ")
        Titulo.Append(mDescEjercicio)

        Me.Text = Titulo.ToString
    End Sub

    'LC
    Private Sub SetearGrilla()
        Dim SpotsPr As New Spots_pr
        Dim SpotsVp As New Spots_vp
        Dim SpotsObtenidos As DataSet
        Dim NuevaRow As DataRow
        Dim SoportesObtenidos As New ArrayList
        Dim Id_Tipo_Elemento_Obtenido As Integer
        Dim ObservacionObtenida, Concepto_Obtenido, Formato_Obtenido, Direccion1_Obtenido, CodigoAGIP_Obtenido As String
        mDatosCabecera = New DataTable("DatosCabecera")
        mSpots = New DataTable("Datos")
        mSpotsDetalle = New DataTable("Detalle")

        Ejer.IDCampaña = mId_Campania
        Ejer.IDSistema = mId_Sistema
        Ejer.IDEjercicio = mId_Ejercicio

        Call AgregarColumnas(mDatosCabecera, True)
        Call AgregarColumnas(mSpots, False)
        Call AgregarColumnasDetalle()
        Call RelacionarTablas()

        If Not mListaSoportes Is Nothing AndAlso mListaSoportes.Count > 0 Then
            mEsCargaNueva = True
            mDatos.AcceptChanges()
            For Each SoportesSeleccionados As ItemLista In mListaSoportes
                Call CargarCabecera(SoportesSeleccionados.ID)

                'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                ElseIf mIdMedio = Me.mMedioProduccion Then
                    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0)
                ElseIf mIdMedio = mMedioViaPublica Then
                    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Call CargarDato2(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0, String.Empty, 0, DBNull.Value, DBNull.Value, DBNull.Value, 0, String.Empty, 0)
                End If
                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                'AG Codigo Anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                'If mIdMedio <> mMedioViaPublica Then
                '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                'Else
                '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0)
                'End If
                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                mIdSpotNuevo -= 1
            Next
        Else
            mEsCargaNueva = False

            'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                SpotsObtenidos = SpotsPr.ObtenerSpots_Pr(mId_Campania, mId_Sistema, mId_Ejercicio)
            ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
                SpotsObtenidos = SpotsVp.ObtenerSpots_Vp(mId_Campania, mId_Sistema, mId_Ejercicio)
            End If

            'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'If mIdMedio <> mMedioViaPublica Then
            '    SpotsObtenidos = SpotsPr.ObtenerSpots_Pr(mId_Campania, mId_Sistema, mId_Ejercicio)
            'Else
            '    SpotsObtenidos = SpotsVp.ObtenerSpots_Vp(mId_Campania, mId_Sistema, mId_Ejercicio)
            'End If
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            If Not SpotsObtenidos Is Nothing AndAlso Not SpotsObtenidos.Tables Is Nothing Then
                If SpotsObtenidos.Tables.Count >= 1 Then
                    For Each RowSpot As DataRow In SpotsObtenidos.Tables(0).Rows
                        If Not SoportesObtenidos.Contains(RowSpot("Id_Soporte")) Then
                            SoportesObtenidos.Add(RowSpot("Id_Soporte"))
                            Call CargarCabecera(RowSpot("Id_Soporte"))
                        End If

                        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                            If Not RowSpot("Concepto") Is DBNull.Value Then
                                Concepto_Obtenido = RowSpot("Concepto")
                            Else
                                Concepto_Obtenido = String.Empty
                            End If
                            Call CargarDato(RowSpot("Id_Campania"), RowSpot("Id_Sistema"), RowSpot("Id_Ejercicio"), _
                                    RowSpot("Id_Spot"), RowSpot("Id_Convenio"), RowSpot("Id_Soporte"), RowSpot("Id_Producto"), _
                                    RowSpot("Id_Material"), Concepto_Obtenido, RowSpot("Color"), RowSpot("Id_Seccion"), _
                                    RowSpot("Ind_Fijo"), RowSpot("Alto"), RowSpot("Ancho"), RowSpot("Bruto"), RowSpot("dcto1"), _
                                    RowSpot("dcto2"), RowSpot("dcto3"), RowSpot("dcto4"), RowSpot("dcto5"), RowSpot("Neto"))
                        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
                            If Not RowSpot("Des_Formato") Is DBNull.Value Then
                                Formato_Obtenido = RowSpot("Des_Formato")
                            Else
                                Formato_Obtenido = String.Empty
                            End If
                            If Not RowSpot("Direccion1") Is DBNull.Value Then
                                Direccion1_Obtenido = RowSpot("Direccion1")
                            Else
                                Direccion1_Obtenido = String.Empty
                            End If
                            If mIdMedio = mMedioViaPublica Then
                                'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                If Not RowSpot("Cod_AGIP") Is DBNull.Value Then
                                    CodigoAGIP_Obtenido = RowSpot("Cod_AGIP")
                                Else
                                    CodigoAGIP_Obtenido = String.Empty
                                End If

                                If Not RowSpot("Id_Tipo_Elemento") Is DBNull.Value Then
                                    Id_Tipo_Elemento_Obtenido = RowSpot("Id_Tipo_Elemento")
                                Else
                                    Id_Tipo_Elemento_Obtenido = 0
                                End If


                                Call CargarDato2(RowSpot("Id_Campania"), RowSpot("Id_Sistema"), RowSpot("Id_Ejercicio"), _
                                                          RowSpot("Id_Spot"), RowSpot("Id_Convenio"), RowSpot("Id_Soporte"), RowSpot("Id_Producto"), _
                                                          RowSpot("Id_Material"), Formato_Obtenido, _
                                                          RowSpot("Cod_Pobl1"), RowSpot("Cod_Pobl2"), Direccion1_Obtenido, RowSpot("Bruto"), RowSpot("dcto1"), _
                                                          RowSpot("dcto2"), RowSpot("dcto3"), RowSpot("dcto4"), RowSpot("dcto5"), _
                                                          RowSpot("Neto"), RowSpot("Num_Caras"), CodigoAGIP_Obtenido, Id_Tipo_Elemento_Obtenido, RowSpot("AnchoVP"), RowSpot("AltoVP"), RowSpot("Cisop"), RowSpot("CUnitario"), RowSpot("Tipo_Convenio"), RowSpot("Importe_Convenio"))
                            Else
                                Call CargarDato(RowSpot("Id_Campania"), RowSpot("Id_Sistema"), RowSpot("Id_Ejercicio"), _
                                                          RowSpot("Id_Spot"), RowSpot("Id_Convenio"), RowSpot("Id_Soporte"), RowSpot("Id_Producto"), _
                                                          RowSpot("Id_Material"), Formato_Obtenido, _
                                                          RowSpot("Cod_Pobl1"), RowSpot("Cod_Pobl2"), Direccion1_Obtenido, RowSpot("Bruto"), RowSpot("dcto1"), _
                                                          RowSpot("dcto2"), RowSpot("dcto3"), RowSpot("dcto4"), RowSpot("dcto5"), _
                                                          RowSpot("Neto"), RowSpot("Num_Caras"))
                            End If

                        End If


                        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        'If mIdMedio <> mMedioViaPublica Then
                        '    If Not RowSpot("Concepto") Is DBNull.Value Then
                        '        Concepto_Obtenido = RowSpot("Concepto")
                        '    Else
                        '        Concepto_Obtenido = String.Empty
                        '    End If
                        '    Call CargarDato(RowSpot("Id_Campania"), RowSpot("Id_Sistema"), RowSpot("Id_Ejercicio"), _
                        '  RowSpot("Id_Spot"), RowSpot("Id_Convenio"), RowSpot("Id_Soporte"), RowSpot("Id_Producto"), _
                        '  RowSpot("Id_Material"), Concepto_Obtenido, RowSpot("Color"), RowSpot("Id_Seccion"), _
                        '  RowSpot("Ind_Fijo"), RowSpot("Alto"), RowSpot("Ancho"), RowSpot("Bruto"), RowSpot("dcto1"), _
                        '  RowSpot("dcto2"), RowSpot("dcto3"), RowSpot("dcto4"), RowSpot("dcto5"), RowSpot("Neto"))
                        'Else
                        '    If Not RowSpot("Des_Formato") Is DBNull.Value Then
                        '        Formato_Obtenido = RowSpot("Des_Formato")
                        '    Else
                        '        Formato_Obtenido = String.Empty
                        '    End If
                        '    If Not RowSpot("Direccion1") Is DBNull.Value Then
                        '        Direccion1_Obtenido = RowSpot("Direccion1")
                        '    Else
                        '        Direccion1_Obtenido = String.Empty
                        '    End If

                        '    Call CargarDato(RowSpot("Id_Campania"), RowSpot("Id_Sistema"), RowSpot("Id_Ejercicio"), _
                        '                              RowSpot("Id_Spot"), RowSpot("Id_Convenio"), RowSpot("Id_Soporte"), RowSpot("Id_Producto"), _
                        '                              RowSpot("Id_Material"), Formato_Obtenido, _
                        '                              RowSpot("Cod_Pobl1"), RowSpot("Cod_Pobl2"), Direccion1_Obtenido, RowSpot("Bruto"), RowSpot("dcto1"), _
                        '                              RowSpot("dcto2"), RowSpot("dcto3"), RowSpot("dcto4"), RowSpot("dcto5"), RowSpot("Neto"), RowSpot("Num_Caras"))
                        'End If
                        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                        Call CargarMaterialFila(RowSpot("Id_Spot"), RowSpot("Id_Producto"))
                        If RowSpot("Id_Convenio") > 0 Then
                            Call CargarConvenios(RowSpot("Id_Soporte"))
                            Call SetearCeldaConvenio(RowSpot("Id_Spot"), True, ObtenerCampoConvenio(RowSpot("Id_Convenio"), "Id_Producto"))
                        End If
                        If SpotsObtenidos.Tables.Count = 2 Then
                            For Each RowDetalle As DataRow In SpotsObtenidos.Tables(1).Select("Id_Spot = " & RowSpot("Id_Spot"))
                                If Not RowDetalle("Observaciones") Is DBNull.Value Then
                                    ObservacionObtenida = RowDetalle("Observaciones")
                                Else
                                    ObservacionObtenida = String.Empty
                                End If
                                Call CargarDetalle(RowDetalle("Id_Spot"), RowDetalle("Id_Spot_detalle"), RowDetalle("f_Spot"), RowDetalle("Id_Spot_Estado"), ObservacionObtenida)
                                Call CargarObservacion(RowDetalle("Id_Spot"), RowDetalle("f_Spot"), ObservacionObtenida)
                            Next
                            NuevaRow = mSpots.Select("Id_Spot = " & RowSpot("Id_Spot"))(0)
                            Call CalcularTotales(NuevaRow, RowSpot("Id_Soporte"), RowSpot("Id_Spot"))
                        End If
                    Next
                End If

                'AG 10/05/2011 ++++++++++++++++++++++++++++++++++++++++++++++++++++

                For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                    For Each Childs As UltraGridChildBand In RowParent.ChildBands
                        For Each Row As UltraGridRow In Childs.Rows
                            If Row.Cells("Id_Convenio").Value = 0 Then
                                Row.Cells("dcto1").Appearance.BackColor = Color.Bisque 'White
                                Row.Cells("dcto2").Appearance.BackColor = Color.Bisque
                                Row.Cells("dcto3").Appearance.BackColor = Color.Bisque
                                Row.Cells("dcto4").Appearance.BackColor = Color.Bisque
                                Row.Cells("dcto5").Appearance.BackColor = Color.Bisque
                            ElseIf Row.Cells("Id_Convenio").Value > 0 Then
                                Row.Cells("dcto1").Appearance.BackColor = Color.White
                                Row.Cells("dcto2").Appearance.BackColor = Color.White
                                Row.Cells("dcto3").Appearance.BackColor = Color.White
                                Row.Cells("dcto4").Appearance.BackColor = Color.White
                                Row.Cells("dcto5").Appearance.BackColor = Color.White
                            ElseIf Row.Cells("Id_Convenio").Value = -1 Then
                                Row.Cells("dcto1").Appearance.BackColor = Color.Bisque
                                Row.Cells("dcto2").Appearance.BackColor = Color.Bisque
                                Row.Cells("dcto3").Appearance.BackColor = Color.Bisque
                                Row.Cells("dcto4").Appearance.BackColor = Color.Bisque
                                Row.Cells("dcto5").Appearance.BackColor = Color.Bisque
                            End If
                            If mIdMedio = mMedioViaPublica Then
                                Row.Cells("Cod_AGIP").Activation = Activation.NoEdit
                                Row.Cells("CostoUnitario").Activation = ObtenerActivacionCostoUnitario(Row.Cells("TipoConvenio").Value, Row.Cells("ImporteConvenio").Value)
                            End If
                        Next
                    Next
                Next
                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            End If
            Call SetearCampos()
            Call CalcularTotales()
            If Not SpotsObtenidos Is Nothing AndAlso SpotsObtenidos.Tables.Count = 2 Then
                Call CargarSpotsComprados(SpotsObtenidos.Tables(1))
                Call DeshabilitarSpotsComprados()
            End If
            mDatos.AcceptChanges()
        End If

        ugPlanificacion.Rows.ExpandAll(True)
        Call ExpandirColapsar()
    End Sub

    Private Sub SetearGrillaImpresion()
        ugPrinter.DisplayLayout.Override.HeaderAppearance.FontData.Bold = DefaultableBoolean.True
        Dim Index As Integer
        For IndexColumna As Integer = 0 To ugPrinter.DisplayLayout.Bands(0).Columns.Count - 1
            If EsColumnaCalendario(ugPrinter.DisplayLayout.Bands(0).Columns(IndexColumna).Key) Then
                ugPrinter.DisplayLayout.Bands(0).Columns(IndexColumna).Header.Caption = mFechas(Index).ToString.Replace(vbCrLf, " - ")
                Index += 1
            End If
        Next
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Soporte"), "Soporte")
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Producto"), "Producto")
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Material"), "Material")

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Sección"), "Sección")
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Concepto"), "Concepto")
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Tamaño"), "Tamaño", 60)
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Ancho"), "Longitud", 60)
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Alto"), "Alto", 60)
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Formato"), "Formato", 100)
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Provincia"), "Provincia", 100)
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Población"), "Población", 100)
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Calle"), "Calle", 100)
            Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Urbanización"), "Urbanización", 100)
        End If


        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Sección"), "Sección")
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Concepto"), "Concepto")
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Tamaño"), "Tamaño", 60)
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Ancho"), "Longitud", 60)
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Alto"), "Alto", 60)
        'Else
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Formato"), "Formato", 100)
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Provincia"), "Provincia", 100)
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Población"), "Población", 100)
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Calle"), "Calle", 100)
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Urbanización"), "Urbanización", 100)
        '    Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Carteles"), "Carteles", 60)
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Bruto"), "Bruto", 90)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("D1"), "D1", 30)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("D2"), "D2", 30)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("D3"), "D3", 30)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("D4"), "D4", 30)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("D5"), "D5", 30)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("Neto"), "Neto", 90)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("TotalSpots"), "Spots", 40, True)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("TotalBruto"), "Inv. Bruta", 100, True)
        Call AplicarFormatoCabecera(ugPrinter.DisplayLayout.Bands(0).Columns("TotalNeto"), "Inv. Neta", 100, True)
        Call AplicarFormatoColumnaTotal(ugPrinter.DisplayLayout.Bands(0).Columns("TotalSpots"))
        Call AplicarFormatoColumnaTotal(ugPrinter.DisplayLayout.Bands(0).Columns("TotalBruto"))
        Call AplicarFormatoColumnaTotal(ugPrinter.DisplayLayout.Bands(0).Columns("TotalNeto"))

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("Ancho"), False)
            Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("Alto"), False)
        End If

        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("Ancho"), False)
        '    Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("Alto"), False)
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Call AplicarFormatoCurrency(ugPrinter.DisplayLayout.Bands(0).Columns("Bruto"))
        If mIdMedio = mMedioViaPublica Then
            Call AplicarFormatoCurrency(ugPrinter.DisplayLayout.Bands(0).Columns("CostoUnitario"))
        End If
        Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("D1"))
        Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("D2"))
        Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("D3"))
        Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("D4"))
        Call AplicarFormatoPorcentaje(ugPrinter.DisplayLayout.Bands(0).Columns("D5"))
        Call AplicarFormatoCurrency(ugPrinter.DisplayLayout.Bands(0).Columns("Neto"))
        Call AplicarTextoNumericoImpresionPosicion(ugPrinter.DisplayLayout.Bands(0))
        Call AplicarFormatoCalendario(ugPrinter.DisplayLayout.Bands(0))
        Call AplicarFormatoCabeceraImpresionCalendario(ugPrinter.DisplayLayout.Bands(0))
        Call AplicarFormatoColumnaTotal(ugPrinter.DisplayLayout.Bands(0).Columns("TotalSpots"))
        Call AplicarFormatoColumnaTotal(ugPrinter.DisplayLayout.Bands(0).Columns("TotalBruto"))
        Call AplicarFormatoColumnaTotal(ugPrinter.DisplayLayout.Bands(0).Columns("TotalNeto"))
        Call AplicarFormatoCurrency(ugPrinter.DisplayLayout.Bands(0).Columns("TotalBruto"))
        Call AplicarFormatoCurrency(ugPrinter.DisplayLayout.Bands(0).Columns("TotalNeto"))

        Call AplicarSumatoria(ugPrinter, ugPrinter.DisplayLayout.Bands(0))
        Call AplicarFormatoColumnaSize(ugPrinter.DisplayLayout.Bands(0))
    End Sub

    Private Sub SetearCeldaConvenio(ByVal pIdSpot As Integer, ByVal pMostrar As Boolean, Optional ByVal pIdProducto As Integer = 0)
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each RowNueva As UltraGridRow In Childs.Rows
                    If RowNueva.Cells("Id_Spot").Value = pIdSpot Then
                        If pMostrar Then
                            RowNueva.Cells("ControlConvenio").Appearance.Image = ImageList.Images(3)
                            If pIdProducto > 0 Then
                                RowNueva.Cells("Id_Producto").Activation = Activation.NoEdit
                            Else
                                RowNueva.Cells("Id_Producto").Activation = Activation.AllowEdit
                            End If
                        Else
                            RowNueva.Cells("ControlConvenio").Appearance.Image = Nothing
                            RowNueva.Cells("Id_Producto").Activation = Activation.AllowEdit
                        End If
                        Exit For
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub AgregarColumnas(ByRef pTable As DataTable, ByVal pEsCabecera As Boolean)
        Dim Dia(8) As String
        Dim CantidadDias As Integer = DateDiff(DateInterval.Day, mFechaInicio, mFechaFin)
        If Not pEsCabecera Then
            pTable.Columns.Add("Id_Campania", GetType(Integer))
            pTable.Columns.Add("Id_Sistema", GetType(Integer))
            pTable.Columns.Add("Id_Ejercicio", GetType(Integer))
            pTable.Columns.Add("Id_Spot", GetType(Integer))
            pTable.Columns.Add("Id_Convenio", GetType(Integer))
            pTable.Columns.Add("ControlConvenio", GetType(String))
            pTable.Columns.Add("TipoConvenio", GetType(String))
            pTable.Columns.Add("ImporteConvenio", GetType(Double))
        End If
        pTable.Columns.Add("Id_Soporte", GetType(Integer))
        pTable.Columns.Add("Id_Producto", GetType(Integer))
        pTable.Columns.Add("Id_Material", GetType(String))

        'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            pTable.Columns.Add("Concepto", GetType(String))
            pTable.Columns.Add("DetalleColor", GetType(String))
            pTable.Columns.Add("Id_Seccion", GetType(Integer))
            If Not pEsCabecera Then
                pTable.Columns.Add("Ind_Fijo", GetType(Boolean))
            Else
                pTable.Columns.Add("Ind_Fijo", GetType(String))
            End If
            pTable.Columns.Add("Ancho", GetType(Integer))
            pTable.Columns.Add("Alto", GetType(Double))
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            pTable.Columns.Add("Des_Formato", GetType(String))
            pTable.Columns.Add("Cod_Pobl1", GetType(Integer))
            pTable.Columns.Add("Cod_Pobl2", GetType(Integer))
            pTable.Columns.Add("Direccion1", GetType(String))
            pTable.Columns.Add("Num_Caras", GetType(Integer))

            'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If mIdMedio = mMedioViaPublica Then
                pTable.Columns.Add("Cod_AGIP", GetType(String))
                'pTable.Columns("Cod_AGIP").ReadOnly = True

                'GG -> CISOP
                pTable.Columns.Add("Id_Tipo_Elemento", GetType(Integer))
                pTable.Columns.Add("AnchoVP", GetType(Single))
                pTable.Columns("AnchoVP").AllowDBNull = True
                pTable.Columns.Add("AltoVP", GetType(Single))
                pTable.Columns("AltoVP").AllowDBNull = True
                pTable.Columns.Add("Cisop", GetType(Long))
                pTable.Columns("Cisop").AllowDBNull = True
                pTable.Columns.Add("CostoUnitario", GetType(Double))
            End If
        End If

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG Codigo Anterior +++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    pTable.Columns.Add("Concepto", GetType(String))
        '    pTable.Columns.Add("DetalleColor", GetType(String))
        '    pTable.Columns.Add("Id_Seccion", GetType(Integer))
        '    If Not pEsCabecera Then
        '        pTable.Columns.Add("Ind_Fijo", GetType(Boolean))
        '    Else
        '        pTable.Columns.Add("Ind_Fijo", GetType(String))
        '    End If
        '    pTable.Columns.Add("Ancho", GetType(Integer))
        '    pTable.Columns.Add("Alto", GetType(Double))
        'Else
        '    pTable.Columns.Add("Des_Formato", GetType(String))
        '    pTable.Columns.Add("Cod_Pobl1", GetType(Integer))
        '    pTable.Columns.Add("Cod_Pobl2", GetType(Integer))
        '    pTable.Columns.Add("Direccion1", GetType(String))
        '    'AG Caras +++++++++++++++++++++++++++++++
        '    pTable.Columns.Add("Num_Caras", GetType(Integer))
        '    '++++++++++++++++++++++++++++++++++++++
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        pTable.Columns.Add("Bruto", GetType(Double))
        pTable.Columns.Add("dcto1", GetType(Double))
        pTable.Columns.Add("dcto2", GetType(Double))
        pTable.Columns.Add("dcto3", GetType(Double))
        pTable.Columns.Add("dcto4", GetType(Double))
        pTable.Columns.Add("dcto5", GetType(Double))
        pTable.Columns.Add("Neto", GetType(Double))

        mFechas = New ArrayList
        Dia(1) = "L"
        Dia(2) = "M"
        Dia(3) = "X"
        Dia(4) = "J"
        Dia(5) = "V"
        Dia(6) = "S"
        Dia(7) = "D"
        For Index As Integer = 0 To CantidadDias
            pTable.Columns.Add(DateAdd(DateInterval.Day, Index, mFechaInicio), GetType(Integer))
            mFechas.Add(Dia(DatePart(DateInterval.Weekday, DateAdd(DateInterval.Day, Index, mFechaInicio), FirstDayOfWeek.Monday)) & vbCrLf & DatePart(DateInterval.Day, DateAdd(DateInterval.Day, Index, mFechaInicio)) & "/" & DatePart(DateInterval.Month, DateAdd(DateInterval.Day, Index, mFechaInicio), FirstDayOfWeek.Monday))
        Next

        pTable.Columns.Add("TotalSpots", GetType(Integer))
        pTable.Columns.Add("TotalBruto", GetType(Double))
        pTable.Columns.Add("TotalNeto", GetType(Double))
    End Sub

    Private Sub AgregarColumnasDetalle()
        mSpotsDetalle.Columns.Add("Id_Spot", GetType(Integer))
        mSpotsDetalle.Columns.Add("Id_Spot_Detalle", GetType(Integer))
        mSpotsDetalle.Columns.Add("Fecha", GetType(DateTime))
        mSpotsDetalle.Columns.Add("Id_Spot_Estado", GetType(String))
        mSpotsDetalle.Columns.Add("Observacion", GetType(String))
    End Sub

    Private Sub AgregarColumnasImpresion(ByRef pDatosImprimir As DataTable)
        pDatosImprimir.Columns.Add("Soporte", GetType(String))
        pDatosImprimir.Columns.Add("Producto", GetType(String))
        pDatosImprimir.Columns.Add("Material", GetType(String))

        'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            pDatosImprimir.Columns.Add("Concepto", GetType(String))
            pDatosImprimir.Columns.Add("Sección", GetType(String))
            pDatosImprimir.Columns.Add("Tamaño", GetType(String))
            pDatosImprimir.Columns.Add("Ancho", GetType(Integer))
            pDatosImprimir.Columns.Add("Alto", GetType(Double))
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            pDatosImprimir.Columns.Add("Formato", GetType(String))
            pDatosImprimir.Columns.Add("Provincia", GetType(String))
            pDatosImprimir.Columns.Add("Población", GetType(String))
            pDatosImprimir.Columns.Add("Calle", GetType(String))
            pDatosImprimir.Columns.Add("Urbanización", GetType(String))
            pDatosImprimir.Columns.Add("Carteles", GetType(String))
        End If

        If mIdMedio = mMedioViaPublica Then
            pDatosImprimir.Columns.Add("CostoUnitario", GetType(Double))
        End If
        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    pDatosImprimir.Columns.Add("Concepto", GetType(String))
        '    pDatosImprimir.Columns.Add("Sección", GetType(String))
        '    pDatosImprimir.Columns.Add("Tamaño", GetType(String))
        '    pDatosImprimir.Columns.Add("Ancho", GetType(Integer))
        '    pDatosImprimir.Columns.Add("Alto", GetType(Double))
        'Else
        '    pDatosImprimir.Columns.Add("Formato", GetType(String))
        '    pDatosImprimir.Columns.Add("Provincia", GetType(String))
        '    pDatosImprimir.Columns.Add("Población", GetType(String))
        '    pDatosImprimir.Columns.Add("Calle", GetType(String))
        '    pDatosImprimir.Columns.Add("Urbanización", GetType(String))
        '    'AG Caras ++++++++++++++++++++++++++++++++++++
        '    pDatosImprimir.Columns.Add("Carteles", GetType(String))
        '    '+++++++++++++++++++++++++++++++++++++++++++
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        pDatosImprimir.Columns.Add("Bruto", GetType(Double))
        pDatosImprimir.Columns.Add("D1", GetType(Double))
        pDatosImprimir.Columns.Add("D2", GetType(Double))
        pDatosImprimir.Columns.Add("D3", GetType(Double))
        pDatosImprimir.Columns.Add("D4", GetType(Double))
        pDatosImprimir.Columns.Add("D5", GetType(Double))
        pDatosImprimir.Columns.Add("Neto", GetType(Double))

        For Each Columna As DataColumn In mSpots.Columns
            If EsColumnaCalendario(Columna.ColumnName) Then
                pDatosImprimir.Columns.Add(Columna.ColumnName, GetType(Integer))
            End If
        Next

        pDatosImprimir.Columns.Add("TotalSpots", GetType(Integer))
        pDatosImprimir.Columns.Add("TotalBruto", GetType(Double))
        pDatosImprimir.Columns.Add("TotalNeto", GetType(Double))
    End Sub

    Private Sub RelacionarTablas()
        mDatos = New DataSet
        mDatos.Tables.Add(mDatosCabecera)
        mDatos.Tables.Add(mSpots)
        mDatos.Tables.Add(mSpotsDetalle)
        mDatos.Relations.Add("Cabecera_Spots", mDatosCabecera.Columns("Id_Soporte"), mSpots.Columns("Id_Soporte"))
        mDatos.Relations.Add("Spots_SpotsDetalle", mSpots.Columns("Id_Spot"), mSpotsDetalle.Columns("Id_Spot"))
        mDatos.Relations("Cabecera_Spots").Nested = True
        mDatos.Relations("Spots_SpotsDetalle").Nested = True

        ugPlanificacion.DataSource = mDatos
        ugPlanificacion.DataBind()
    End Sub

    Private Sub SetearCampos()
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each Row As UltraGridRow In Childs.Rows
                    Call SetearCampos(Row)
                Next
            Next
        Next
    End Sub

    Private Sub SetearCampos(ByRef pRow As UltraGridRow)
        If Convert.ToInt32(pRow.Cells("Id_Producto").Value) = 0 Then
            pRow.Cells("Id_Material").Activation = Activation.NoEdit
            pRow.Cells("Id_Material").Value = "0"
        End If

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            If Convert.ToBoolean(pRow.Cells("Ind_Fijo").Value) Then
                pRow.Cells("Ancho").Activation = Activation.NoEdit
                pRow.Cells("Ancho").Value = 0
                pRow.Cells("Alto").Activation = Activation.NoEdit
                pRow.Cells("Alto").Value = 0
            End If
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            If Convert.ToInt32(pRow.Cells("Cod_Pobl1").Value) = 0 Then
                pRow.Cells("Cod_Pobl2").Activation = Activation.NoEdit
                pRow.Cells("Cod_Pobl2").Value = "0"
            End If
        End If

        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    If Convert.ToBoolean(pRow.Cells("Ind_Fijo").Value) Then
        '        pRow.Cells("Ancho").Activation = Activation.NoEdit
        '        pRow.Cells("Ancho").Value = 0
        '        pRow.Cells("Alto").Activation = Activation.NoEdit
        '        pRow.Cells("Alto").Value = 0
        '    End If
        'Else
        '    If Convert.ToInt32(pRow.Cells("Cod_Pobl1").Value) = 0 Then
        '        pRow.Cells("Cod_Pobl2").Activation = Activation.NoEdit
        '        pRow.Cells("Cod_Pobl2").Value = "0"
        '    End If
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG 02/06/2011 +++++++++++++++++++++++++++++++++++++
        If pRow.Cells("id_convenio").Value = -1 Or pRow.Cells("id_convenio").Value = 0 Then
            pRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
            pRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
            pRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
            pRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
            pRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++

        Call AplicarHabilitacionDescuento(pRow)
    End Sub

    Private Sub SetearMenuDia(ByVal pIdSpot As Integer, ByVal pColumnName As String)
        Dim Observacion As String
        Dim Filtro As New StringBuilder

        Filtro.Append("Id_Spot = ")
        Filtro.Append(pIdSpot)
        Filtro.Append(" and Fecha = '")
        Filtro.Append(pColumnName)
        Filtro.Append("'")

        If mSpotsDetalle.Select(Filtro.ToString).Length > 0 Then
            Observacion = mSpotsDetalle.Select(Filtro.ToString)(0)("Observacion")
        End If
        If Observacion.Trim = String.Empty Then
            uManager.Tools("AgregarObservacion").SharedProps.Visible = True
            uManager.Tools("ModificarObservacion").SharedProps.Visible = False
            uManager.Tools("EliminarObservacion").SharedProps.Visible = False
        Else
            uManager.Tools("AgregarObservacion").SharedProps.Visible = False
            uManager.Tools("ModificarObservacion").SharedProps.Visible = True
            uManager.Tools("EliminarObservacion").SharedProps.Visible = True
        End If

        uManager.ShowPopup("PopupMenuDia")
    End Sub

    Private Sub ExpandirColapsar()
        If uManager.Toolbars(0).Tools("ExpandirColapsar").SharedProps.Caption = "Expandir" Then
            uManager.Toolbars(0).Tools("ExpandirColapsar").SharedProps.Caption = "Colapsar"
            uManager.Toolbars(0).Tools("ExpandirColapsar").SharedProps.AppearancesSmall.Appearance.Image = ImageList.Images(0)
            ugPlanificacion.Rows.ExpandAll(True)
        Else
            uManager.Toolbars(0).Tools("ExpandirColapsar").SharedProps.Caption = "Expandir"
            uManager.Toolbars(0).Tools("ExpandirColapsar").SharedProps.AppearancesSmall.Appearance.Image = ImageList.Images(1)
            ugPlanificacion.Rows.CollapseAll(True)
        End If
    End Sub

    Private Sub DeshabilitarOrdenamiento(ByVal pBanda As UltraGridBand)
        For Each Columna As UltraGridColumn In pBanda.Columns
            Columna.SortIndicator = SortIndicator.Disabled
        Next
    End Sub

    Private Sub DeshabilitarSpotsComprados()
        If Not mSpotsComprados Is Nothing AndAlso mSpotsComprados.Rows.Count > 0 Then
            For Each SpotComprado As DataRow In mSpotsComprados.Rows
                For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                    For Each Childs As UltraGridChildBand In RowParent.ChildBands
                        For Each RowNueva As UltraGridRow In Childs.Rows
                            If RowNueva.Cells("Id_Spot").Value = SpotComprado("Id_Spot") Then
                                RowNueva.Cells("Id_Producto").Activation = Activation.NoEdit
                                RowNueva.Cells("Id_Material").Activation = Activation.NoEdit

                                'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                                    RowNueva.Cells("Concepto").Activation = Activation.NoEdit
                                    RowNueva.Cells("Id_Seccion").Activation = Activation.NoEdit
                                    RowNueva.Cells("Ind_Fijo").Activation = Activation.NoEdit
                                    RowNueva.Cells("Ancho").Activation = Activation.NoEdit
                                    RowNueva.Cells("Alto").Activation = Activation.NoEdit
                                ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
                                    RowNueva.Cells("Des_Formato").Activation = Activation.NoEdit
                                    RowNueva.Cells("Cod_Pobl1").Activation = Activation.NoEdit
                                    RowNueva.Cells("Cod_Pobl2").Activation = Activation.NoEdit
                                    RowNueva.Cells("Direccion1").Activation = Activation.NoEdit
                                    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                    If mIdMedio = mMedioViaPublica Then
                                        RowNueva.Cells("Cod_AGIP").Activation = Activation.NoEdit
                                        'GG -> CISOP
                                        RowNueva.Cells("Id_Tipo_Elemento").Activation = Activation.NoEdit
                                        RowNueva.Cells("AnchoVP").Activation = Activation.NoEdit
                                        RowNueva.Cells("AltoVP").Activation = Activation.NoEdit
                                        RowNueva.Cells("Cisop").Activation = Activation.NoEdit
                                        'AN 04-03-2016 DESHABILITO LA EDICION EN EL CAMPO CARTELES PARA VIA PUBLICA SI SE ENVIO A COMPRAS.
                                        RowNueva.Cells("Num_Caras").Activation = Activation.NoEdit
                                    End If
                                End If

                                'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                'If mIdMedio <> mMedioViaPublica Then
                                '    RowNueva.Cells("Concepto").Activation = Activation.NoEdit
                                '    RowNueva.Cells("Id_Seccion").Activation = Activation.NoEdit
                                '    RowNueva.Cells("Ind_Fijo").Activation = Activation.NoEdit
                                '    RowNueva.Cells("Ancho").Activation = Activation.NoEdit
                                '    RowNueva.Cells("Alto").Activation = Activation.NoEdit
                                'Else
                                '    RowNueva.Cells("Des_Formato").Activation = Activation.NoEdit
                                '    RowNueva.Cells("Cod_Pobl1").Activation = Activation.NoEdit
                                '    RowNueva.Cells("Cod_Pobl2").Activation = Activation.NoEdit
                                '    RowNueva.Cells("Direccion1").Activation = Activation.NoEdit
                                'End If
                                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                                RowNueva.Cells("Bruto").Activation = Activation.NoEdit
                                RowNueva.Cells("dcto1").Activation = Activation.NoEdit
                                RowNueva.Cells("dcto2").Activation = Activation.NoEdit
                                RowNueva.Cells("dcto3").Activation = Activation.NoEdit
                                RowNueva.Cells("dcto4").Activation = Activation.NoEdit
                                RowNueva.Cells("dcto5").Activation = Activation.NoEdit
                                RowNueva.Cells("Neto").Activation = Activation.NoEdit

                                RowNueva.Cells(Convert.ToDateTime(SpotComprado("f_spot")).ToString("dd/MM/yyyy")).Activation = Activation.NoEdit
                                RowNueva.Cells(Convert.ToDateTime(SpotComprado("f_spot")).ToString("dd/MM/yyyy")).Appearance.ForeColor = Color.Red

                                Exit For
                            End If
                        Next
                    Next
                Next
            Next
        End If
    End Sub

    Private Sub CargarConvenios(ByVal pIdSoporte As Integer)
        Dim Convenio As New Convenios
        Dim dtConvenio As DataTable

        If mConvenios Is Nothing OrElse mConvenios.Count = 0 Then
            mConvenios = New SortedList
        End If

        Convenio.Id_cliente = mIdCliente
        Convenio.Id_soporte = pIdSoporte
        Convenio.F_inicio = mFechaInicio
        Convenio.F_fin = mFechaFin
        Convenio.Id_medio = mIdMedio
        dtConvenio = Convenio.CargarGrillaxSoporte()

        If Not dtConvenio Is Nothing AndAlso dtConvenio.Rows.Count > 0 Then
            For Each drConvenio As DataRow In dtConvenio.Rows
                If Not mConvenios.Contains(Convert.ToInt32(drConvenio("Id_Convenio"))) Then
                    mConvenios.Add(Convert.ToInt32(drConvenio("Id_Convenio")), drConvenio)
                End If
            Next
        End If
    End Sub

    Private Sub CargarSpotsComprados(ByVal pSpotsDetalle As DataTable)
        mSpotsComprados = pSpotsDetalle.Clone
        For Each RowDetalle As DataRow In pSpotsDetalle.Select("Id_Spot_Estado <> 'P'")
            mSpotsComprados.ImportRow(RowDetalle)
        Next
    End Sub

    Private Sub CargarCabecera(ByVal pSoporte As Integer)
        Dim Dato As DataRow

        Dato = mDatosCabecera.NewRow
        Dato("Id_Soporte") = pSoporte
        mDatosCabecera.Rows.Add(Dato)
    End Sub

    Private Sub CargarDatoImpresion(ByRef pDatosImprimir As DataTable)
        Dim DatoImprimir As DataRow

        For Each Spot As DataRow In mSpots.Rows
            DatoImprimir = pDatosImprimir.NewRow
            DatoImprimir("Soporte") = ObtenerDescripcion("Id_Soporte", Spot("Id_Soporte"))
            DatoImprimir("Producto") = ObtenerDescripcion("Id_Producto", Spot("Id_Producto"))
            DatoImprimir("Material") = ObtenerDescripcion("Id_Material", Spot("Id_Material"), Spot("Id_Producto"))

            'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                DatoImprimir("Concepto") = Spot("Concepto")
                DatoImprimir("Sección") = ObtenerDescripcion("Id_Seccion", Spot("Id_Seccion"))
                DatoImprimir("Tamaño") = ObtenerDescripcion("Ind_Fijo", Spot("Ind_Fijo"))
                DatoImprimir("Ancho") = Spot("Ancho")
                DatoImprimir("Alto") = Spot("Alto")
            ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
                DatoImprimir("Formato") = Spot("Des_Formato")
                DatoImprimir("Provincia") = ObtenerDescripcion("Cod_Pobl1", Spot("Cod_Pobl1"))
                DatoImprimir("Población") = ObtenerDescripcion("Cod_Pobl2", Spot("Cod_Pobl2"), Spot("Cod_Pobl1"))
                DatoImprimir("Calle") = Spot("Direccion1")
                DatoImprimir("Carteles") = Spot("Num_Caras")
            End If

            If mIdMedio = mMedioViaPublica Then
                DatoImprimir("CostoUnitario") = Spot("CostoUnitario")
            End If

            'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'If mIdMedio <> mMedioViaPublica Then
            '    DatoImprimir("Concepto") = Spot("Concepto")
            '    DatoImprimir("Sección") = ObtenerDescripcion("Id_Seccion", Spot("Id_Seccion"))
            '    DatoImprimir("Tamaño") = ObtenerDescripcion("Ind_Fijo", Spot("Ind_Fijo"))
            '    DatoImprimir("Ancho") = Spot("Ancho")
            '    DatoImprimir("Alto") = Spot("Alto")
            'Else
            '    DatoImprimir("Formato") = Spot("Des_Formato")
            '    DatoImprimir("Provincia") = ObtenerDescripcion("Cod_Pobl1", Spot("Cod_Pobl1"))
            '    DatoImprimir("Población") = ObtenerDescripcion("Cod_Pobl2", Spot("Cod_Pobl2"), Spot("Cod_Pobl1"))
            '    DatoImprimir("Calle") = Spot("Direccion1")
            '    DatoImprimir("Carteles") = Spot("Num_Caras")
            'End If
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            DatoImprimir("Bruto") = Spot("Bruto")
            DatoImprimir("D1") = Spot("dcto1")
            DatoImprimir("D2") = Spot("dcto2")
            DatoImprimir("D3") = Spot("dcto3")
            DatoImprimir("D4") = Spot("dcto4")
            DatoImprimir("D5") = Spot("dcto5")
            DatoImprimir("Neto") = Spot("Neto")

            For Each Columna As DataColumn In mSpots.Columns
                If EsColumnaCalendario(Columna.ColumnName) Then
                    DatoImprimir(Columna.ColumnName) = Spot(Columna.ColumnName)
                End If
            Next

            DatoImprimir("TotalSpots") = Spot("TotalSpots")
            DatoImprimir("TotalBruto") = Spot("TotalBruto")
            DatoImprimir("TotalNeto") = Spot("TotalNeto")
            pDatosImprimir.Rows.Add(DatoImprimir)
        Next
    End Sub

    Private Sub CargarDato(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer, ByVal pId_Spot As Integer, ByVal pId_Convenio As Integer, ByVal pSoporte As Integer, ByVal pProducto As Integer, ByVal pMaterial As String, ByVal pConcepto As String, ByVal pColor As Integer, ByVal pSeccion As Integer, ByVal pTamano As Boolean, ByVal pAlto As Double, ByVal pAncho As Double, ByVal pBruto As Double, ByVal pD1 As Double, ByVal pD2 As Double, ByVal pD3 As Double, ByVal pD4 As Double, ByVal pD5 As Double, ByVal pNeto As Double)
        Dim Dato As DataRow

        Dato = mSpots.NewRow
        Dato("Id_Campania") = pId_Campania
        Dato("Id_Sistema") = pId_Sistema
        Dato("Id_Ejercicio") = pId_Ejercicio
        Dato("Id_Spot") = pId_Spot
        Dato("Id_Convenio") = pId_Convenio
        Dato("Id_Soporte") = pSoporte
        Dato("Id_Producto") = pProducto
        Dato("Id_Material") = pMaterial
        Dato("Concepto") = pConcepto
        Dato("DetalleColor") = pColor
        Dato("Id_Seccion") = pSeccion
        Dato("Ind_Fijo") = pTamano
        Dato("Ancho") = pAncho
        Dato("Alto") = pAlto
        Dato("Bruto") = pBruto
        Dato("dcto1") = pD1
        Dato("dcto2") = pD2
        Dato("dcto3") = pD3
        Dato("dcto4") = pD4
        Dato("dcto5") = pD5
        Dato("Neto") = pNeto

        mSpots.Rows.Add(Dato)
        Call CargarMaterialFila(pId_Spot, pProducto)
    End Sub

    Private Sub CargarDato(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer, _
                           ByVal pId_Spot As Integer, ByVal pId_Convenio As Integer, ByVal pSoporte As Integer, ByVal pProducto As Integer, _
                           ByVal pMaterial As String, ByVal pDes_Formato As String, ByVal pCod_Pobl1 As Integer, ByVal pCod_Pobl2 As Integer, _
                           ByVal pDireccion1 As String, ByVal pBruto As Double, ByVal pD1 As Double, ByVal pD2 As Double, ByVal pD3 As Double, _
                           ByVal pD4 As Double, ByVal pD5 As Double, ByVal pNeto As Double, ByVal pCaras As Integer)
        Dim Dato As DataRow

        Dato = mSpots.NewRow
        Dato("Id_Campania") = pId_Campania
        Dato("Id_Sistema") = pId_Sistema
        Dato("Id_Ejercicio") = pId_Ejercicio
        Dato("Id_Spot") = pId_Spot
        Dato("Id_Convenio") = pId_Convenio
        Dato("Id_Soporte") = pSoporte
        Dato("Id_Producto") = pProducto
        Dato("Id_Material") = pMaterial
        Dato("Des_Formato") = pDes_Formato
        Dato("Cod_Pobl1") = pCod_Pobl1
        Dato("Cod_Pobl2") = pCod_Pobl2
        Dato("Direccion1") = pDireccion1
        Dato("Bruto") = pBruto
        Dato("dcto1") = pD1
        Dato("dcto2") = pD2
        Dato("dcto3") = pD3
        Dato("dcto4") = pD4
        Dato("dcto5") = pD5
        Dato("Neto") = pNeto
        'AG Caras +++++++++++++++++++
        Dato("Num_Caras") = pCaras
        '++++++++++++++++++++++++++

        mSpots.Rows.Add(Dato)
        Call CargarMaterialFila(pId_Spot, pProducto)
        Call CargarPoblacionFila(pId_Spot, pCod_Pobl1)
    End Sub

    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Sub CargarDato2(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer, _
                           ByVal pId_Spot As Integer, ByVal pId_Convenio As Integer, ByVal pSoporte As Integer, ByVal pProducto As Integer, _
                           ByVal pMaterial As String, ByVal pDes_Formato As String, ByVal pCod_Pobl1 As Integer, ByVal pCod_Pobl2 As Integer, _
                           ByVal pDireccion1 As String, ByVal pBruto As Double, ByVal pD1 As Double, ByVal pD2 As Double, ByVal pD3 As Double, _
                           ByVal pD4 As Double, ByVal pD5 As Double, ByVal pNeto As Double, ByVal pCaras As Integer, ByVal pCod_AGIP As String, _
                           ByVal pTipo_Elemento As Integer, ByVal pAncho As Object, ByVal pAlto As Object, ByVal pCisop As Object, ByVal pCUnitario As Double, ByVal pTipoConvenio As String, ByVal pImporteConvenio As Double)
        Dim Dato As DataRow

        Dato = mSpots.NewRow
        Dato("Id_Campania") = pId_Campania
        Dato("Id_Sistema") = pId_Sistema
        Dato("Id_Ejercicio") = pId_Ejercicio
        Dato("Id_Spot") = pId_Spot
        Dato("Id_Convenio") = pId_Convenio
        Dato("Id_Soporte") = pSoporte
        Dato("Id_Producto") = pProducto
        Dato("Id_Material") = pMaterial
        Dato("Des_Formato") = pDes_Formato
        Dato("Cod_Pobl1") = pCod_Pobl1
        Dato("Cod_Pobl2") = pCod_Pobl2
        Dato("Direccion1") = pDireccion1
        Dato("Cod_AGIP") = pCod_AGIP
        Dato("Bruto") = pBruto
        Dato("dcto1") = pD1
        Dato("dcto2") = pD2
        Dato("dcto3") = pD3
        Dato("dcto4") = pD4
        Dato("dcto5") = pD5
        Dato("Neto") = pNeto
        'AG Caras +++++++++++++++++++
        Dato("Num_Caras") = pCaras
        '++++++++++++++++++++++++++

        'GG -> CISOP
        Dato("Id_Tipo_Elemento") = pTipo_Elemento
        Dato("AnchoVP") = pAncho
        Dato("AltoVP") = pAlto
        Dato("Cisop") = pCisop
        Dato("CostoUnitario") = pCUnitario
        Dato("TipoConvenio") = pTipoConvenio
        Dato("ImporteConvenio") = pImporteConvenio
        mPaste = True
        mSpots.Rows.Add(Dato)
        mPaste = False
        Call CargarMaterialFila(pId_Spot, pProducto)
        Call CargarPoblacionFila(pId_Spot, pCod_Pobl1)
    End Sub

    Private Sub CargarDetalle(ByVal pId_Spot As Integer, ByVal pId_Spot_Detalle As Integer, ByVal pFecha As DateTime, ByVal pEstado As String, ByVal pObservacion As String)
        Dim Detalle As DataRow = mSpotsDetalle.NewRow
        Detalle("Id_Spot") = pId_Spot
        Detalle("Id_Spot_Detalle") = pId_Spot_Detalle
        Detalle("Fecha") = pFecha
        Detalle("Id_Spot_Estado") = pEstado
        Detalle("Observacion") = pObservacion
        mSpotsDetalle.Rows.Add(Detalle)
    End Sub

    Private Sub CargarObservacion(ByVal pId_Spot As Integer, ByVal pColumnName As String, ByVal pObservacion As String)
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each RowNueva As UltraGridRow In Childs.Rows
                    If RowNueva.Cells("Id_Spot").Value = pId_Spot Then
                        If pObservacion <> String.Empty Then
                            RowNueva.Cells(pColumnName).Appearance.Image = ImageList.Images(2)
                        Else
                            RowNueva.Cells(pColumnName).Appearance.Image = Nothing
                        End If
                        RowNueva.Cells(pColumnName).ToolTipText = pObservacion
                        Exit For
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub CargarMaterialFila(ByVal pId_Spot As Integer, ByVal pId_Producto As Integer)
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each RowNueva As UltraGridRow In Childs.Rows
                    If RowNueva.Cells("Id_Spot").Value = pId_Spot Then
                        RowNueva.Cells("Id_Material").ValueList = ObtenerMateriales(pId_Producto)
                        Call SetearCampos(RowNueva)
                        Exit For
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub CargarPoblacionFila(ByVal pId_Spot As Integer, ByVal pId_Provincia As Integer)
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each RowNueva As UltraGridRow In Childs.Rows
                    If RowNueva.Cells("Id_Spot").Value = pId_Spot Then
                        RowNueva.Cells("Cod_Pobl2").ValueList = ObtenerPoblaciones(pId_Provincia)
                        Exit For
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub BuscarConvenios(Optional ByVal pPuntual As Boolean = True)
        Dim Soportes As New ArrayList
        Dim Productos As New ArrayList
        Dim CantidadSeleccionada As Integer
        Dim Seleccionadas As New ArrayList

        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        If pPuntual Then
            CantidadSeleccionada = ugPlanificacion.Selected.Rows.Count
            If CantidadSeleccionada = 0 Then
                Mensaje("No hay Registros seleccionados.", TipoMensaje.Informacion)
                Exit Sub
            End If

            For IndexSeleccionada As Integer = 0 To CantidadSeleccionada - 1
                If ugPlanificacion.Selected.Rows(IndexSeleccionada).Band.Index = 0 Then
                    If Not Seleccionadas.Contains(ugPlanificacion.Selected.Rows(IndexSeleccionada).ListIndex) Then
                        Seleccionadas.Add(ugPlanificacion.Selected.Rows(IndexSeleccionada).ListIndex)
                    End If
                End If
            Next
            If Not Seleccionadas Is Nothing AndAlso Seleccionadas.Count > 0 Then
                For Index As Integer = 0 To Seleccionadas.Count - 1
                    For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                        If RowParent.ListIndex = Seleccionadas(Index) Then
                            For Each Child As UltraGridChildBand In RowParent.ChildBands
                                For Each Row As UltraGridRow In Child.Rows
                                    Row.Selected = True
                                Next
                            Next
                        End If
                    Next
                Next
            End If
            For Each RowSeleccionada As UltraGridRow In ugPlanificacion.Selected.Rows
                'JJP - Validación obsoleta ya que existen productos con código 0
                'If RowSeleccionada.Cells("Id_Producto").Value = 0 Then
                '    Mensaje("Para aplicar Convenio debe seleccionarse el Producto.", TipoMensaje.Informacion)
                '    Exit Sub
                'End If
                If Not Soportes.Contains(RowSeleccionada.Cells("Id_Soporte").Value) Then
                    Soportes.Add(RowSeleccionada.Cells("Id_Soporte").Value)
                End If
                If Not Productos.Contains(RowSeleccionada.Cells("Id_Producto").Value) Then
                    Productos.Add(RowSeleccionada.Cells("Id_Producto").Value)
                End If
            Next
        Else
            For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                For Each Childs As UltraGridChildBand In RowParent.ChildBands
                    For Each Row As UltraGridRow In Childs.Rows
                        'JJP - Validación obsoleta ya que existen productos con código 0
                        'If Row.Cells("Id_Producto").Value = 0 Then
                        '    Mensaje("Para aplicar Convenio debe seleccionarse el Producto.", TipoMensaje.Informacion)
                        '    Exit Sub
                        'End If
                        If Not Soportes.Contains(Row.Cells("Id_Soporte").Value) Then
                            Soportes.Add(Row.Cells("Id_Soporte").Value)
                        End If
                        If Not Productos.Contains(Row.Cells("Id_Producto").Value) Then
                            Productos.Add(Row.Cells("Id_Producto").Value)
                        End If
                    Next
                Next
            Next
        End If

        ConveniosMedios.FechaDesde = mFechaInicio
        ConveniosMedios.FechaHasta = mFechaFin
        ConveniosMedios.IdCliente = mIdCliente
        ConveniosMedios.IdMedio = mIdMedio
        ConveniosMedios.Soportes = Soportes
        ConveniosMedios.Productos = Productos
        ConveniosMedios.Puntual = pPuntual
        ConveniosMedios.ShowDialog()


        'AG 10/05/2011 = Control Convenio Igual -1 marcar color fonde celda ++++++++++
        Dim sin_COnvenios As Boolean
        sin_COnvenios = ConveniosMedios.SinConvenios
        AperturaHoja = True
        If sin_COnvenios = False Then
            If pPuntual = False Then 'Convenio Global
                For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                    For Each Childs As UltraGridChildBand In RowParent.ChildBands
                        For Each Row As UltraGridRow In Childs.Rows
                            If mTConvenio = "T" Then
                                Row.Cells("dcto1").Appearance.BackColor = Color.White
                                Row.Cells("dcto2").Appearance.BackColor = Color.White
                                Row.Cells("dcto3").Appearance.BackColor = Color.White
                                Row.Cells("dcto4").Appearance.BackColor = Color.White
                                Row.Cells("dcto5").Appearance.BackColor = Color.White
                            Else
                                If Row.Cells("Id_Convenio").Value = 0 Then
                                    Row.Cells("dcto1").Appearance.BackColor = Color.White
                                    Row.Cells("dcto2").Appearance.BackColor = Color.White
                                    Row.Cells("dcto3").Appearance.BackColor = Color.White
                                    Row.Cells("dcto4").Appearance.BackColor = Color.White
                                    Row.Cells("dcto5").Appearance.BackColor = Color.White
                                ElseIf Row.Cells("Id_Convenio").Value > 0 Then
                                    Row.Cells("dcto1").Appearance.BackColor = Color.White
                                    Row.Cells("dcto2").Appearance.BackColor = Color.White
                                    Row.Cells("dcto3").Appearance.BackColor = Color.White
                                    Row.Cells("dcto4").Appearance.BackColor = Color.White
                                    Row.Cells("dcto5").Appearance.BackColor = Color.White
                                    Row.Cells("dcto1").Appearance.ForeColor = Color.Black
                                    Row.Cells("dcto2").Appearance.ForeColor = Color.Black
                                    Row.Cells("dcto3").Appearance.ForeColor = Color.Black
                                    Row.Cells("dcto4").Appearance.ForeColor = Color.Black
                                    Row.Cells("dcto5").Appearance.ForeColor = Color.Black
                                End If
                            End If
                        Next
                    Next
                Next
                AperturaHoja = True
            Else
                For Each RowSeleccionada As UltraGridRow In ugPlanificacion.Selected.Rows
                    If mTConvenio = "T" Then
                        RowSeleccionada.Cells("dcto1").Appearance.BackColor = Color.White
                        RowSeleccionada.Cells("dcto2").Appearance.BackColor = Color.White
                        RowSeleccionada.Cells("dcto3").Appearance.BackColor = Color.White
                        RowSeleccionada.Cells("dcto4").Appearance.BackColor = Color.White
                        RowSeleccionada.Cells("dcto5").Appearance.BackColor = Color.White
                    Else
                        If RowSeleccionada.Cells("Id_Convenio").Value = 0 Then
                            RowSeleccionada.Cells("dcto1").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto2").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto3").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto4").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto5").Appearance.BackColor = Color.White
                        ElseIf RowSeleccionada.Cells("Id_Convenio").Value > 0 Then
                            RowSeleccionada.Cells("dcto1").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto2").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto3").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto4").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto5").Appearance.BackColor = Color.White
                            RowSeleccionada.Cells("dcto1").Appearance.ForeColor = Color.Black
                            RowSeleccionada.Cells("dcto2").Appearance.ForeColor = Color.Black
                            RowSeleccionada.Cells("dcto3").Appearance.ForeColor = Color.Black
                            RowSeleccionada.Cells("dcto4").Appearance.ForeColor = Color.Black
                            RowSeleccionada.Cells("dcto5").Appearance.ForeColor = Color.Black
                        End If
                    End If
                Next
                AperturaHoja = True
            End If

        End If

        sin_COnvenios = False
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    End Sub

    Private Sub EliminarConvenios()
        Dim RowModified As DataRow

        For Each RowSeleccionada As UltraGridRow In ugPlanificacion.Selected.Rows
            RowModified = mSpots.Select("Id_Spot = " & RowSeleccionada.Cells("Id_Spot").Value)(0)
            RowModified("Id_Convenio") = 0
            Call SetearCeldaConvenio(RowSeleccionada.Cells("Id_Spot").Value, False)
        Next
    End Sub

    Private Sub Imprimir()
        Dim upp As New UltraGridPrintDocument
        Dim ultraprintpreview As New UltraPrintPreviewDialog

        upp.Grid = ugPrinter
        upp.FitWidthToPages = 1
        upp.Header.Appearance.ImageHAlign = HAlign.Left
        upp.Header.Appearance.ImageVAlign = VAlign.Default
        upp.Header.Appearance.FontData.SizeInPoints = 9
        upp.Header.BorderStyle = UIElementBorderStyle.None
        upp.Footer.TextRight = "Pagina <#>."
        upp.Footer.Height = 100
        upp.Footer.Appearance.FontData.SizeInPoints = 9
        upp.Footer.Appearance.TextHAlign = HAlign.Left
        upp.Footer.BorderStyle = UIElementBorderStyle.None
        upp.Footer.Appearance.FontData.Italic = DefaultableBoolean.True
        upp.PageBody.BorderStyle = UIElementBorderStyle.None
        upp.Page.BorderStyle = UIElementBorderStyle.None
        upp.DefaultPageSettings.Landscape = True
        upp.DefaultPageSettings.Margins.Bottom = 10
        upp.DefaultPageSettings.Margins.Left = 10
        upp.DefaultPageSettings.Margins.Right = 10
        upp.DefaultPageSettings.Margins.Top = 10
        upp.DocumentName = "PLANIFICACION"

        With ultraprintpreview
            .Document = upp
            .AutoGeneratePreview = True
            .DisplayPrintStatus = True
            .DisplayPreviewStatus = True
            .MaximumPreviewPages = 50
            .PreviewMouseAction = PreviewMouseAction.DynamicZoom
            .PreviewSettings.ScrollMode = UltraWinScrollBar.ScrollMode.Immediate
            .PreviewSettings.ScrollTipStyle = UltraWinScrollBar.ScrollTipStyle.Show
            .ThumbnailSettings.PageNumberDisplayStyle = PageNumberDisplayStyle.LeftOfRow
            .ThumbnailSettings.BorderStyle = UIElementBorderStyle.InsetSoft
            .StatusBarVisible = True
            .Style = UltraWinToolbars.ToolbarStyle.VisualStudio2005
            .ThumbnailAreaVisible = True
            .ThumbnailCurrentPreviewPageAppearance.BackColor = Color.Yellow
            .ThumbnailCurrentPreviewPageNumberAppearance.ForeColor = Color.Red
            .ThumbnailViewBoxAppearance.BackColor = Color.Aqua
            .ThumbnailViewBoxAppearance.BackColorAlpha = Alpha.UseAlphaLevel
            .ThumbnailViewBoxAppearance.AlphaLevel = 80
            .ThumbnailViewBoxDisplayStyle = ViewBoxDisplayStyle.AllVisiblePreviewPages
            .ThumbnailViewBoxDragMode = ViewBoxDragMode.RestrictWithinPage
            .UseAntiAlias = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub Exportar()
        SaveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            Dim Excel As New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
            Try
                Excel.Export(ugPrinter, SaveFileDialog.FileName)
                Mensaje("El archivo se grabó con éxito.", TipoMensaje.Informacion)
            Catch ioex As IO.IOException
                Mensaje(ioex.Message, TipoMensaje.DeError)
            End Try
        End If
    End Sub

    Private Sub ExportarImprimir(Optional ByVal pImprimir As Boolean = True)
        Dim DatosImprimir As New DataTable

        Call AgregarColumnasImpresion(DatosImprimir)
        Call CargarDatoImpresion(DatosImprimir)

        ugPrinter.DataSource = DatosImprimir
        ugPrinter.DataBind()
        Call SetearGrillaImpresion()

        If pImprimir Then
            Call Imprimir()
        Else
            Call Exportar()
        End If
    End Sub

    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Function BuscarCuitProveedor(ByVal pDescripcionCabecera As String) As String
        Dim OMsl As New Maestros
        Dim dtProveedorCuit As New DataTable
        Dim detalleRowSeleccionada As String()
        Dim idPorveedor As Integer
        detalleRowSeleccionada = pDescripcionCabecera.Split(New Char() {"["c})
        idPorveedor = Convert.ToInt32(detalleRowSeleccionada(2).Substring(0, detalleRowSeleccionada(2).Length - 1))
        dtProveedorCuit = OMsl.ObtenerProveedorCUIT(MSL.Constantes.COD_PAIS_ARGENTINA, idPorveedor)
        Return dtProveedorCuit.Rows(0).Item(3).ToString()
    End Function

    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Sub AgregarCodigoAGIP()
        Dim rowModified As UltraGridRow
        Dim f As New frmFiltrarPadronAGIP()

        If ugPlanificacion.Selected.Rows.Count = 0 Then
            Mensaje("No hay Registros seleccionados.", TipoMensaje.Informacion)
            Exit Sub
        End If

        For Each RowParent As UltraGridRow In ugPlanificacion.Selected.Rows
            If Not RowParent.ParentRow Is Nothing Then
                rowModified = RowParent
            End If
        Next

        If Not rowModified Is Nothing Then
            If rowModified.Cells("Cod_pobl1").Value = 1 Then
                f.DetalleAGIP.CUIT = BuscarCuitProveedor(Me.ugPlanificacion.Rows(Me.ugPlanificacion.ActiveRow.ParentRow.Index).Cells(0).Text)
                f.ShowDialog()
                If Not f.Cancelado Then
                    rowModified.Cells("Cod_AGIP").Value = f.DetalleAGIP.CodigoAGIP
                    rowModified.Cells("Cod_AGIP").Activation = Activation.NoEdit
                    rowModified.Cells("Direccion1").Value = f.DetalleAGIP.DireccionCompleta
                End If
            End If
        End If
    End Sub

    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Sub MostrarMapa()
        Dim proveedor As String
        Dim CodigosAGIP() As String
        Dim codigosAGIPXProveedor As New Dictionary(Of String, List(Of Detalle_AGIP))
        Dim detalleAGIP As Detalle_AGIP
        Dim detallesAGIP As List(Of Detalle_AGIP)
        Dim f As New frmMapaAGIP()
        For Each rowParent As UltraGridRow In ugPlanificacion.Rows
            proveedor = rowParent.Cells(0).Text.Substring(rowParent.Cells(0).Text.IndexOf("|") + 2, rowParent.Cells(0).Text.Length - (rowParent.Cells(0).Text.IndexOf("|") + 2))
            detallesAGIP = New List(Of Detalle_AGIP)
            For Each Childs As UltraGridChildBand In rowParent.ChildBands
                For Each Row As UltraGridRow In Childs.Rows
                    CodigosAGIP = Row.Cells("Cod_AGIP").Text.Split(New Char() {" "c})
                    For Each codigo As String In CodigosAGIP
                        detalleAGIP = New Detalle_AGIP
                        detalleAGIP.Provincia = Row.Cells("Cod_Pobl1").Text
                        detalleAGIP.Localidad = Row.Cells("Cod_Pobl2").Text
                        If Row.Cells("Cod_Pobl1").Value = 1 Then
                            If codigo <> String.Empty Then
                                detalleAGIP.CodigoAGIP = codigo
                            Else
                                detalleAGIP.CodigoAGIP = -1
                            End If
                        Else
                            detalleAGIP.CodigoAGIP = -1
                            detalleAGIP.Direccion = Row.Cells("Direccion1").Text
                        End If
                        If detalleAGIP.CodigoAGIP <> String.Empty Then
                            detallesAGIP.Add(detalleAGIP)
                        End If
                    Next
                Next
            Next
            codigosAGIPXProveedor.Add(proveedor, detallesAGIP)
        Next
        f.CodigosAGIP = codigosAGIPXProveedor
        f.ShowDialog()
    End Sub

    Private Sub EliminarObservacion()
        Dim Filtro As New StringBuilder

        Filtro.Append("Id_Spot = ")
        Filtro.Append(ugPlanificacion.Selected.Cells(0).Row.Cells("Id_Spot").Value)
        Filtro.Append(" and Fecha = '")
        Filtro.Append(ugPlanificacion.Selected.Cells(0).Column.Key)
        Filtro.Append("'")

        For Each RowDetalle As DataRow In mSpotsDetalle.Select(Filtro.ToString)
            RowDetalle("Observacion") = String.Empty
        Next

        ugPlanificacion.Selected.Cells(0).Appearance.Image = Nothing
        ugPlanificacion.Selected.Cells(0).ToolTipText = String.Empty
    End Sub

    Private Sub Eliminar()
        If ugPlanificacion.Selected.Rows.Count > 0 Then
            If Not ValidarAvisosComprados() Then Exit Sub
            If ugPlanificacion.Selected.Rows(0).Band.Index = 0 Then
                Call EliminarPadre()
            Else
                Call EliminarHijo()
            End If
        End If
    End Sub

    Private Sub EliminarPadre()
        Dim Seleccionados As New SortedList
        Dim CantidadSeleccionados As Integer

        For Each RowSelected As UltraGridRow In ugPlanificacion.Selected.Rows
            If Not Seleccionados.ContainsKey(RowSelected.ListIndex) Then
                Seleccionados.Add(RowSelected.ListIndex, RowSelected.ListIndex)
            End If
        Next
        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            If ugPlanificacion.Rows(Seleccionados.GetKey(Index)).ChildBands.Count > 0 AndAlso ugPlanificacion.Rows(Seleccionados.GetKey(Index)).ChildBands(0).Rows.Count > 0 Then
                For Each RowChild As UltraGridRow In ugPlanificacion.Rows(Seleccionados.GetKey(Index)).ChildBands(0).Rows
                    RowChild.Selected = True
                Next
            End If
            Call EliminarHijo()
        Next
    End Sub

    Private Sub EliminarHijo()
        Dim Seleccionados As New SortedList
        Dim CantidadSeleccionados As Integer
        Dim Key As StringBuilder
        Dim keyCompuesta As String()

        For Each RowSelected As UltraGridRow In ugPlanificacion.Selected.Rows
            If RowSelected.Band.Index = 1 Then
                If ValidarCompras(RowSelected) Then
                    Key = New StringBuilder
                    If RowSelected.ParentRow.ListIndex.ToString.Length = 1 Then
                        Key.Append("0")
                    End If
                    Key.Append(RowSelected.ParentRow.ListIndex)
                    Key.Append("-")
                    If RowSelected.ListIndex.ToString.Length = 1 Then
                        Key.Append("0")
                    End If
                    Key.Append(RowSelected.ListIndex)
                    If Not Seleccionados.ContainsKey(Key.ToString) Then
                        Seleccionados.Add(Key.ToString, Key.ToString)
                    End If
                End If
            End If
        Next
        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            keyCompuesta = Seleccionados.GetKey(Index).ToString().Split("-")
            Call EliminarTodoDetalle(ugPlanificacion.Rows(keyCompuesta(0)).ChildBands(0).Rows(keyCompuesta(1)))
            ugPlanificacion.Rows(keyCompuesta(0)).ChildBands(0).Rows(keyCompuesta(1)).Delete(False)
            If ugPlanificacion.Rows(keyCompuesta(0)).ChildBands(0).Rows.Count = 0 Then
                ugPlanificacion.Rows(keyCompuesta(0)).Delete(False)
            Else
                Call CalcularTotales(ugPlanificacion.Rows(keyCompuesta(0)))
            End If
        Next
        Call CalcularTotales()
    End Sub

    Private Sub EliminarTodoDetalle(ByRef pParentRow As UltraGridRow)
        Dim Seleccionados As New SortedList
        Dim CantidadSeleccionados As Integer
        Dim Key As StringBuilder
        Dim keyCompuesta As String()

        If Not pParentRow.ChildBands Is Nothing AndAlso pParentRow.ChildBands.Count > 0 AndAlso pParentRow.ChildBands(0).Rows.Count > 0 Then
            For Each RowDetalle As UltraGridRow In pParentRow.ChildBands(0).Rows
                Key = New StringBuilder
                If RowDetalle.ParentRow.ParentRow.ListIndex.ToString.Length = 1 Then
                    Key.Append("0")
                End If
                Key.Append(RowDetalle.ParentRow.ParentRow.ListIndex)
                Key.Append("-")
                If RowDetalle.ParentRow.ListIndex.ToString.Length = 1 Then
                    Key.Append("0")
                End If
                Key.Append(RowDetalle.ParentRow.ListIndex)
                Key.Append("-")
                If RowDetalle.ListIndex.ToString.Length = 1 Then
                    Key.Append("0")
                End If
                Key.Append(RowDetalle.ListIndex)
                If Not Seleccionados.ContainsKey(Key.ToString) Then
                    Seleccionados.Add(Key.ToString, Key.ToString)
                End If
            Next
            CantidadSeleccionados = Seleccionados.Count - 1
            For Index As Integer = CantidadSeleccionados To 0 Step -1
                keyCompuesta = Seleccionados.GetKey(Index).ToString().Split("-")
                ugPlanificacion.Rows(keyCompuesta(0)).ChildBands(0).Rows(keyCompuesta(1)).ChildBands(0).Rows(keyCompuesta(2)).Delete(False)
            Next
        End If
        Call CalcularTotales()
    End Sub

    Private Sub EliminarDetalle(ByVal pDetalle As UltraGridRow, ByVal pId_Spot_Detalle As Integer, ByVal pFecha As DateTime)
        If Not pDetalle.ChildBands Is Nothing AndAlso pDetalle.ChildBands.Count > 0 AndAlso pDetalle.ChildBands(0).Rows.Count > 0 Then
            For Each RowDetalle As UltraGridRow In pDetalle.ChildBands(0).Rows
                If RowDetalle.Cells("Id_Spot_Detalle").Value = pId_Spot_Detalle AndAlso Convert.ToDateTime(RowDetalle.Cells("Fecha").Value).Date = pFecha.Date Then
                    RowDetalle.Delete(False)
                    Exit Sub
                End If
            Next
        End If
        Call CalcularTotales()
    End Sub

    Private Sub AgregarSoportes()
        Dim FiltrarSoporte As New frmFiltrarSoporte

        FiltrarSoporte.Id_medio = mIdMedio
        FiltrarSoporte.Id_tipo_soporte = mIdTipoSoporte
        FiltrarSoporte.id_plaza = mIdPlaza

        FiltrarSoporte.ShowDialog()

        If Not FiltrarSoporte.Cancelado Then
            If Not FiltrarSoporte.ListaSoportes Is Nothing AndAlso FiltrarSoporte.ListaSoportes.Count > 0 Then
                For Each SoportesSeleccionados As ItemLista In FiltrarSoporte.ListaSoportes
                    If mDatosCabecera.Select("Id_Soporte = " & SoportesSeleccionados.ID).Length <= 0 Then
                        Call CargarCabecera(SoportesSeleccionados.ID)

                        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                            Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                        ElseIf mIdMedio = Me.mMedioProduccion Then
                            Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0)
                        ElseIf mIdMedio = mMedioViaPublica Then
                            'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            Call CargarDato2(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0, String.Empty, 0, DBNull.Value, DBNull.Value, DBNull.Value, 0, String.Empty, 0)
                        End If

                        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        'If mIdMedio <> mMedioViaPublica Then
                        '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                        'Else
                        '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, SoportesSeleccionados.ID, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0)
                        'End If
                        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                                For Each RowNueva As UltraGridRow In Childs.Rows
                                    If RowNueva.Cells("Id_Spot").Value = mIdSpotNuevo Then
                                        RowNueva.ParentRow.ExpandAll()
                                        'Exit For
                                    End If
                                    If mIdMedio = mMedioViaPublica Then
                                        RowNueva.Cells("Cod_AGIP").Activation = Activation.NoEdit
                                        RowNueva.Cells("CostoUnitario").Activation = Activation.AllowEdit
                                        'RowNueva.Cells("Cisop").Activation = Activation.NoEdit
                                    End If
                                Next
                            Next
                        Next

                        mIdSpotNuevo -= 1
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub AgregarModificarObservaciones()
        Dim Filtro As New StringBuilder
        Dim DetalleObservacion As String
        Dim Observacion As New frmAgregarObservacion

        Filtro.Append("Id_Spot = ")
        Filtro.Append(ugPlanificacion.Selected.Cells(0).Row.Cells("Id_Spot").Value)
        Filtro.Append(" and Fecha = '")
        Filtro.Append(ugPlanificacion.Selected.Cells(0).Column.Key)
        Filtro.Append("'")

        If mSpotsDetalle.Select(Filtro.ToString).Length > 0 Then
            DetalleObservacion = mSpotsDetalle.Select(Filtro.ToString)(0)("Observacion")
        End If

        Observacion.Observaciones = DetalleObservacion
        Observacion.ShowDialog()
        If Observacion.Observaciones <> DetalleObservacion Then
            For Each RowDetalle As DataRow In mSpotsDetalle.Select(Filtro.ToString)
                RowDetalle("Observacion") = Observacion.Observaciones
            Next
            If Observacion.Observaciones <> String.Empty Then
                ugPlanificacion.Selected.Cells(0).Appearance.Image = ImageList.Images(2)
            Else
                ugPlanificacion.Selected.Cells(0).Appearance.Image = Nothing
            End If
            ugPlanificacion.Selected.Cells(0).ToolTipText = Observacion.Observaciones
        End If
    End Sub

    Private Sub AgregarHijo()
        For Each RowSelected As UltraGridRow In ugPlanificacion.Selected.Rows

            'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, RowSelected.Cells("Id_Soporte").Value, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            ElseIf mIdMedio = Me.mMedioProduccion Then
                Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, RowSelected.Cells("Id_Soporte").Value, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0)
            ElseIf mIdMedio = mMedioViaPublica Then
                'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                Call CargarDato2(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, RowSelected.Cells("Id_Soporte").Value, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0, String.Empty, 0, DBNull.Value, DBNull.Value, DBNull.Value, 0, String.Empty, 0)
                For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                    For Each Childs As UltraGridChildBand In RowParent.ChildBands
                        For Each RowNueva As UltraGridRow In Childs.Rows
                            If RowNueva.Cells("Id_Spot").Value = mIdSpotNuevo Then
                                RowNueva.Cells("Cod_AGIP").Activation = Activation.NoEdit
                                Call SetearCampos(RowNueva)
                                Exit For
                            End If
                        Next
                    Next
                Next
            End If

            'AG Codigo anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'If mIdMedio <> mMedioViaPublica Then
            '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, RowSelected.Cells("Id_Soporte").Value, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            'Else
            '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, 0, RowSelected.Cells("Id_Soporte").Value, 0, 0, String.Empty, 0, 0, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0)
            'End If
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                For Each Childs As UltraGridChildBand In RowParent.ChildBands
                    For Each RowNueva As UltraGridRow In Childs.Rows
                        If RowNueva.Cells("Id_Spot").Value = mIdSpotNuevo Then
                            Call SetearCampos(RowNueva)
                            Exit For
                        End If
                    Next
                Next
            Next

            mIdSpotNuevo -= 1
        Next
    End Sub

    Private Sub DuplicarHijo()
        For Each RowSelected As UltraGridRow In ugPlanificacion.Selected.Rows

            'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                FilaDuplicada = True
                Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, RowSelected.Cells("Id_Convenio").Value, RowSelected.Cells("Id_Soporte").Value, RowSelected.Cells("Id_Producto").Value, RowSelected.Cells("Id_Material").Value, RowSelected.Cells("Concepto").Value, RowSelected.Cells("DetalleColor").Value, RowSelected.Cells("Id_Seccion").Value, RowSelected.Cells("Ind_Fijo").Value, RowSelected.Cells("Alto").Value, RowSelected.Cells("Ancho").Value, RowSelected.Cells("Bruto").Value, RowSelected.Cells("dcto1").Value, RowSelected.Cells("dcto2").Value, RowSelected.Cells("dcto3").Value, RowSelected.Cells("dcto4").Value, RowSelected.Cells("dcto5").Value, RowSelected.Cells("Neto").Value)
            ElseIf mIdMedio = Me.mMedioProduccion Then
                FilaDuplicada = True
                Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, RowSelected.Cells("Id_Convenio").Value, RowSelected.Cells("Id_Soporte").Value, RowSelected.Cells("Id_Producto").Value, RowSelected.Cells("Id_Material").Value, RowSelected.Cells("Des_Formato").Value, RowSelected.Cells("Cod_Pobl1").Value, RowSelected.Cells("Cod_Pobl2").Value, RowSelected.Cells("Direccion1").Value, RowSelected.Cells("Bruto").Value, RowSelected.Cells("dcto1").Value, RowSelected.Cells("dcto2").Value, RowSelected.Cells("dcto3").Value, RowSelected.Cells("dcto4").Value, RowSelected.Cells("dcto5").Value, RowSelected.Cells("Neto").Value, RowSelected.Cells("Num_Caras").Value)
                'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            ElseIf mIdMedio = mMedioViaPublica Then
                FilaDuplicada = True
                Call CargarDato2(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, RowSelected.Cells("Id_Convenio").Value, RowSelected.Cells("Id_Soporte").Value, RowSelected.Cells("Id_Producto").Value, RowSelected.Cells("Id_Material").Value, RowSelected.Cells("Des_Formato").Value, RowSelected.Cells("Cod_Pobl1").Value, RowSelected.Cells("Cod_Pobl2").Value, RowSelected.Cells("Direccion1").Value, RowSelected.Cells("Bruto").Value, RowSelected.Cells("dcto1").Value, RowSelected.Cells("dcto2").Value, RowSelected.Cells("dcto3").Value, RowSelected.Cells("dcto4").Value, RowSelected.Cells("dcto5").Value, RowSelected.Cells("Neto").Value, RowSelected.Cells("Num_Caras").Value, RowSelected.Cells("Cod_AGIP").Value, _
                    IIf(Not RowSelected.Cells("Id_Tipo_Elemento").Value Is DBNull.Value, RowSelected.Cells("Id_Tipo_Elemento").Value, 0), _
                    RowSelected.Cells("AnchoVP").Value, RowSelected.Cells("AltoVP").Value, RowSelected.Cells("Cisop").Value, RowSelected.Cells("CostoUnitario").Value, RowSelected.Cells("TipoConvenio").Value, RowSelected.Cells("ImporteConvenio").Value)

                For Each RowParent As UltraGridRow In ugPlanificacion.Rows
                    For Each Childs As UltraGridChildBand In RowParent.ChildBands
                        For Each RowNueva As UltraGridRow In Childs.Rows
                            If RowNueva.Cells("Id_Spot").Value = mIdSpotNuevo Then
                                RowNueva.Cells("Cod_AGIP").Activation = Activation.NoEdit
                                Call SetearCampos(RowNueva)
                                Exit For
                            End If
                        Next
                    Next
                Next
            End If

            'AG Codigo anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'If mIdMedio <> mMedioViaPublica Then
            '    'AG 02/06/2011 ++++++++++++++++++++++++++++++++
            '    FilaDuplicada = True
            '    '+++++++++++++++++++++++++++++++++++++++++++
            '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, RowSelected.Cells("Id_Convenio").Value, RowSelected.Cells("Id_Soporte").Value, RowSelected.Cells("Id_Producto").Value, RowSelected.Cells("Id_Material").Value, RowSelected.Cells("Concepto").Value, RowSelected.Cells("DetalleColor").Value, RowSelected.Cells("Id_Seccion").Value, RowSelected.Cells("Ind_Fijo").Value, RowSelected.Cells("Alto").Value, RowSelected.Cells("Ancho").Value, RowSelected.Cells("Bruto").Value, RowSelected.Cells("dcto1").Value, RowSelected.Cells("dcto2").Value, RowSelected.Cells("dcto3").Value, RowSelected.Cells("dcto4").Value, RowSelected.Cells("dcto5").Value, RowSelected.Cells("Neto").Value)
            'Else
            '    'AG 02/06/2011 ++++++++++++++++++++++++++++++++
            '    FilaDuplicada = True
            '    '+++++++++++++++++++++++++++++++++++++++++++
            '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, RowSelected.Cells("Id_Convenio").Value, RowSelected.Cells("Id_Soporte").Value, RowSelected.Cells("Id_Producto").Value, RowSelected.Cells("Id_Material").Value, RowSelected.Cells("Des_Formato").Value, RowSelected.Cells("Cod_Pobl1").Value, RowSelected.Cells("Cod_Pobl2").Value, RowSelected.Cells("Direccion1").Value, RowSelected.Cells("Bruto").Value, RowSelected.Cells("dcto1").Value, RowSelected.Cells("dcto2").Value, RowSelected.Cells("dcto3").Value, RowSelected.Cells("dcto4").Value, RowSelected.Cells("dcto5").Value, RowSelected.Cells("Neto").Value, RowSelected.Cells("Num_Caras").Value)
            'End If
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            If RowSelected.Cells("Id_Convenio").Value > 0 Then
                Call SetearCeldaConvenio(mIdSpotNuevo, True, RowSelected.Cells("Id_Producto").Value)
            End If
            Call CopiarDetalle(RowSelected.Cells("Id_Spot").Value)

            mIdSpotNuevo -= 1
        Next
        Call CalcularTotales()



    End Sub

    Private Sub CopiarDetalle(ByVal pIdSpot As Integer)
        Dim Fecha As DateTime
        Dim Observacion As String
        Dim Filtro As StringBuilder
        Dim Cantidad As Integer
        Dim NuevaRow As DataRow

        For Each Row As DataRow In mSpots.Select("Id_Spot = " & pIdSpot)
            For Each Columna As DataColumn In mSpots.Columns
                If EsColumnaCalendario(Columna.ColumnName) Then
                    If Not Row(Columna.ColumnName) Is DBNull.Value AndAlso Row(Columna.ColumnName) > 0 Then
                        Cantidad = Row(Columna.ColumnName)
                        Fecha = Convert.ToDateTime(Columna.ColumnName)
                        Observacion = String.Empty
                        Filtro = New StringBuilder
                        Filtro.Append("Id_Spot = ")
                        Filtro.Append(Row("Id_Spot"))
                        Filtro.Append(" and Fecha = '")
                        Filtro.Append(Fecha.Date)
                        Filtro.Append("'")
                        Observacion = mSpotsDetalle.Select(Filtro.ToString)(0)("Observacion")
                        For Index As Integer = 1 To Cantidad
                            Call CargarDetalle(mIdSpotNuevo, mIdSpotDetalleNuevo, Fecha, mSpotDetalleEstado, Observacion)
                            mIdSpotDetalleNuevo -= 1
                        Next
                        Call CargarObservacion(mIdSpotNuevo, Fecha, Observacion)
                    End If
                End If
            Next

            NuevaRow = mSpots.Select("Id_Spot = " & mIdSpotNuevo)(0)
            Call CalcularTotales(NuevaRow, NuevaRow("Id_Soporte"), mIdSpotNuevo)
        Next
    End Sub

    Private Sub CopiarHijo()
        mCopias = New ArrayList
        For Each RowSelected As UltraGridRow In ugPlanificacion.Selected.Rows
            mCopias.Add(RowSelected)
        Next
    End Sub

    Private Sub PegarHijo()
        Dim RowCopia As UltraGridRow
        Dim IdSoporte, IdConvenio As Integer
        If Not mCopias Is Nothing AndAlso mCopias.Count > 0 Then
            For Index As Integer = 0 To mCopias.Count - 1
                RowCopia = DirectCast(mCopias(Index), UltraGridRow)
                For Each RowSelected As UltraGridRow In ugPlanificacion.Selected.Rows
                    IdSoporte = RowSelected.Cells("Id_Soporte").Value
                    If RowSelected.Cells("Id_Soporte").Value = RowCopia.Cells("Id_Soporte").Value Then
                        IdConvenio = RowCopia.Cells("Id_Convenio").Value
                    Else
                        IdConvenio = 0
                    End If

                    'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                        Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, IdConvenio, IdSoporte, RowCopia.Cells("Id_Producto").Value, RowCopia.Cells("Id_Material").Value, RowCopia.Cells("Concepto").Value, RowCopia.Cells("DetalleColor").Value, RowCopia.Cells("Id_Seccion").Value, RowCopia.Cells("Ind_Fijo").Value, RowCopia.Cells("Alto").Value, RowCopia.Cells("Ancho").Value, RowCopia.Cells("Bruto").Value, RowCopia.Cells("dcto1").Value, RowCopia.Cells("dcto2").Value, RowCopia.Cells("dcto3").Value, RowCopia.Cells("dcto4").Value, RowCopia.Cells("dcto5").Value, RowCopia.Cells("Neto").Value)
                    ElseIf mIdMedio = Me.mMedioProduccion Then
                        Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, IdConvenio, IdSoporte, RowCopia.Cells("Id_Producto").Value, RowCopia.Cells("Id_Material").Value, RowCopia.Cells("Des_Formato").Value, RowCopia.Cells("Cod_Pobl1").Value, RowCopia.Cells("Cod_Pobl2").Value, RowCopia.Cells("Direccion1").Value, RowCopia.Cells("Bruto").Value, RowCopia.Cells("dcto1").Value, RowCopia.Cells("dcto2").Value, RowCopia.Cells("dcto3").Value, RowCopia.Cells("dcto4").Value, RowCopia.Cells("dcto5").Value, RowCopia.Cells("Neto").Value, RowCopia.Cells("Num_Caras").Value)
                    ElseIf mIdMedio = mMedioViaPublica Then
                        'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        Call CargarDato2(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, IdConvenio, IdSoporte, RowCopia.Cells("Id_Producto").Value, RowCopia.Cells("Id_Material").Value, RowCopia.Cells("Des_Formato").Value, RowCopia.Cells("Cod_Pobl1").Value, RowCopia.Cells("Cod_Pobl2").Value, RowCopia.Cells("Direccion1").Value, RowCopia.Cells("Bruto").Value, RowCopia.Cells("dcto1").Value, RowCopia.Cells("dcto2").Value, RowCopia.Cells("dcto3").Value, RowCopia.Cells("dcto4").Value, RowCopia.Cells("dcto5").Value, RowCopia.Cells("Neto").Value, RowCopia.Cells("Num_Caras").Value, RowCopia.Cells("Cod_AGIP").Value, _
                            IIf(Not RowCopia.Cells("Id_Tipo_Elemento").Value Is DBNull.Value, RowCopia.Cells("Id_Tipo_Elemento").Value, 0), _
                            RowCopia.Cells("AnchoVP").Value, RowCopia.Cells("AltoVP").Value, RowCopia.Cells("Cisop").Value, RowCopia.Cells("CostoUnitario").Value, RowCopia.Cells("TipoConvenio").Value, RowCopia.Cells("ImporteConvenio").Value)
                    End If

                    'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    'If mIdMedio <> mMedioViaPublica Then
                    '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, IdConvenio, IdSoporte, RowCopia.Cells("Id_Producto").Value, RowCopia.Cells("Id_Material").Value, RowCopia.Cells("Concepto").Value, RowCopia.Cells("DetalleColor").Value, RowCopia.Cells("Id_Seccion").Value, RowCopia.Cells("Ind_Fijo").Value, RowCopia.Cells("Alto").Value, RowCopia.Cells("Ancho").Value, RowCopia.Cells("Bruto").Value, RowCopia.Cells("dcto1").Value, RowCopia.Cells("dcto2").Value, RowCopia.Cells("dcto3").Value, RowCopia.Cells("dcto4").Value, RowCopia.Cells("dcto5").Value, RowCopia.Cells("Neto").Value)
                    'Else
                    '    Call CargarDato(mId_Campania, mId_Sistema, mId_Ejercicio, mIdSpotNuevo, IdConvenio, IdSoporte, RowCopia.Cells("Id_Producto").Value, RowCopia.Cells("Id_Material").Value, RowCopia.Cells("Des_Formato").Value, RowCopia.Cells("Cod_Pobl1").Value, RowCopia.Cells("Cod_Pobl2").Value, RowCopia.Cells("Direccion1").Value, RowCopia.Cells("Bruto").Value, RowCopia.Cells("dcto1").Value, RowCopia.Cells("dcto2").Value, RowCopia.Cells("dcto3").Value, RowCopia.Cells("dcto4").Value, RowCopia.Cells("dcto5").Value, RowCopia.Cells("Neto").Value, RowCopia.Cells("Num_Caras").Value)
                    'End If
                    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                    If IdConvenio > 0 Then
                        Call SetearCeldaConvenio(mIdSpotNuevo, True, RowCopia.Cells("Id_Producto").Value)
                    End If
                    Call CopiarDetalle(RowCopia.Cells("Id_Spot").Value)
                    mIdSpotNuevo -= 1
                Next
            Next
            Call CalcularTotales()
            mCopias.Clear()
        End If
    End Sub

    Private Sub Guardar()
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        Me.Cursor = Cursors.WaitCursor
        mCerrar = True
        If ValidarDatos() Then
            'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                Call GuardarPrensa()
            Else
                Call GuardarViaPublica()
            End If

            'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'If mIdMedio <> mMedioViaPublica Then
            '    Call GuardarPrensa()
            'Else
            '    Call GuardarViaPublica()
            'End If
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Else
            mCerrar = False
        End If
    End Sub

    Private Sub GuardarPrensa()
        Dim Id_SpotNuevo, Id_SpotDetalleNuevo, Id_Spot, Id_Spot_Detalle, Ind_Fijo, CantidadTransacciones As Integer
        Dim SpotsDetalleNuevos As SortedList
        Dim SpotsPr As New Spots_pr
        Dim InsertarDetalle As Boolean
        Dim transaccionTerminada As Boolean = False

        Try
            SpotsPr.IniciarTransaccion()
            'Elimina registros eliminados
            If Not mSpotsDetalle.GetChanges(DataRowState.Deleted) Is Nothing Then
                CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Deleted).Rows.Count
                For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Deleted).Rows
                    Id_Spot = RowDetalle("Id_Spot", DataRowVersion.Original)
                    Id_Spot_Detalle = RowDetalle("Id_Spot_Detalle", DataRowVersion.Original)
                    SpotsPr.BorrarDetalle(Id_Spot, Id_Spot_Detalle)
                Next
            End If
            If Not mSpots.GetChanges(DataRowState.Deleted) Is Nothing Then
                CantidadTransacciones += mSpots.GetChanges(DataRowState.Deleted).Rows.Count
                For Each Row As DataRow In mSpots.GetChanges(DataRowState.Deleted).Rows
                    SpotsPr.Id_spot = Row("Id_Spot", DataRowVersion.Original)
                    SpotsPr.Borrar()
                Next
            End If
            'Agrega nuevos registros
            If Not mSpots.GetChanges(DataRowState.Added) Is Nothing Then
                CantidadTransacciones += mSpots.GetChanges(DataRowState.Added).Rows.Count
                For Each Row As DataRow In mSpots.GetChanges(DataRowState.Added).Rows
                    SpotsDetalleNuevos = New SortedList
                    If Convert.ToBoolean(Row("Ind_Fijo")) Then
                        Ind_Fijo = 1
                    Else
                        Ind_Fijo = 0
                    End If

                    Id_SpotNuevo = SpotsPr.Agregar(mId_Campania, mId_Sistema, mId_Ejercicio, Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Row("Concepto"), Row("DetalleColor"), Row("Id_Seccion"), Ind_Fijo, Row("Ancho"), Row("Alto"), Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Activo.Login, Today)
                    If Not mSpotsDetalle.GetChanges(DataRowState.Added) Is Nothing Then
                        CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Added).Rows.Count
                        For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Added).Select("Id_Spot = " & Row("Id_Spot"))
                            Id_SpotDetalleNuevo = SpotsPr.AgregarDetalle(Id_SpotNuevo, mTemaPrensa, RowDetalle("Fecha"), 0, Activo.Login, Today, mSpotDetalleEstado, RowDetalle("Observacion"))
                            SpotsDetalleNuevos.Add(RowDetalle("Id_Spot_Detalle"), Id_SpotDetalleNuevo)
                        Next
                    End If
                    Call ActualizarSpots(Row("Id_Spot"), Id_SpotNuevo, SpotsDetalleNuevos)
                Next
            End If
            If Not mSpotsDetalle.GetChanges(DataRowState.Added) Is Nothing Then
                CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Added).Rows.Count
                For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Added).Rows
                    InsertarDetalle = True
                    If Not mSpots.GetChanges(DataRowState.Added) Is Nothing Then
                        For Each Row As DataRow In mSpots.GetChanges(DataRowState.Added).Rows
                            If Row("Id_Spot") = RowDetalle("Id_Spot") Then
                                InsertarDetalle = False
                                Exit For
                            End If
                        Next
                    End If
                    If InsertarDetalle Then
                        Id_SpotDetalleNuevo = SpotsPr.AgregarDetalle(RowDetalle("Id_Spot"), mTemaPrensa, RowDetalle("Fecha"), 0, Activo.Login, Today, mSpotDetalleEstado, RowDetalle("Observacion"))
                        Call ActualizarSpots(RowDetalle("Id_Spot"), RowDetalle("Id_Spot_Detalle"), Id_SpotDetalleNuevo)
                    End If
                Next
            End If
            'Actualiza registros modificados
            If Not mSpots.GetChanges(DataRowState.Modified) Is Nothing Then
                CantidadTransacciones += mSpots.GetChanges(DataRowState.Modified).Rows.Count
                For Each Row As DataRow In mSpots.GetChanges(DataRowState.Modified).Rows
                    If Convert.ToBoolean(Row("Ind_Fijo")) Then
                        Ind_Fijo = 1
                    Else
                        Ind_Fijo = 0
                    End If

                    SpotsPr.Modificar(Row("Id_Spot"), Row("Id_Campania"), Row("Id_Sistema"), Row("Id_Ejercicio"), Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Row("Concepto"), Row("DetalleColor"), Row("Id_Seccion"), Ind_Fijo, Row("Ancho"), Row("Alto"), Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Activo.Login, Today)
                Next
            End If

            'AG 03/11/2010 ---------------------------------------------------------------------------------
            If ActualizarDescuentos = True Then
                If mSpots.Rows.Count > 0 Then
                    For Each Row As DataRow In mSpots.Rows
                        If Convert.ToBoolean(Row("Ind_Fijo")) Then
                            Ind_Fijo = 1
                        Else
                            Ind_Fijo = 0
                        End If
                        SpotsPr.Modificar(Row("Id_Spot"), Row("Id_Campania"), Row("Id_Sistema"), Row("Id_Ejercicio"), Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Row("Concepto"), Row("DetalleColor"), Row("Id_Seccion"), Ind_Fijo, Row("Ancho"), Row("Alto"), Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Activo.Login, Today)
                    Next
                    SpotsPr.TerminarTransaccion()
                    transaccionTerminada = True
                    ActualizarDescuentos = False
                End If
            End If
            '-----------------------------------------------------------------------------------------------------

            If Not mSpotsDetalle.GetChanges(DataRowState.Modified) Is Nothing Then
                CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Modified).Rows.Count
                For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Modified).Rows
                    SpotsPr.ModificarDetalle(RowDetalle("Id_Spot"), RowDetalle("Id_Spot_Detalle"), mTemaPrensa, RowDetalle("Fecha"), 0, mSpotDetalleEstado, RowDetalle("Observacion"), Activo.Login, Today)
                Next
            End If
            If CantidadTransacciones > 0 Then
                'AG 10/05/2011 +++++++++++++++
                If transaccionTerminada = True Then
                Else
                    SpotsPr.TerminarTransaccion()
                End If
                '++++++++++++++++++++++++++++
            End If

            SpotsPr.Desconectar()
            mDatos.AcceptChanges()
        Catch ex As Exception
            SpotsPr.AbortarTransaccion()
            Mensaje(ex.Message, TipoMensaje.DeError)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GuardarViaPublica()
        Dim Id_SpotNuevo, Id_SpotDetalleNuevo, Id_Spot, Id_Spot_Detalle, CantidadTransacciones As Integer
        Dim SpotsDetalleNuevos As SortedList
        Dim SpotsVp As New Spots_vp
        Dim Formato, Calle As String
        Dim InsertarDetalle As Boolean
        Dim Caras As Integer
        Dim Id_Tipo_Elemento As Integer

        Try
            SpotsVp.IniciarTransaccion()
            'Elimina registros eliminados
            If Not mSpotsDetalle.GetChanges(DataRowState.Deleted) Is Nothing Then
                CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Deleted).Rows.Count
                For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Deleted).Rows
                    Id_Spot = RowDetalle("Id_Spot", DataRowVersion.Original)
                    Id_Spot_Detalle = RowDetalle("Id_Spot_Detalle", DataRowVersion.Original)
                    SpotsVp.BorrarDetalle(Id_Spot, Id_Spot_Detalle)
                Next
            End If
            If Not mSpots.GetChanges(DataRowState.Deleted) Is Nothing Then
                CantidadTransacciones += mSpots.GetChanges(DataRowState.Deleted).Rows.Count
                For Each Row As DataRow In mSpots.GetChanges(DataRowState.Deleted).Rows
                    SpotsVp.Id_spot = Row("Id_Spot", DataRowVersion.Original)
                    SpotsVp.Borrar()
                Next
            End If
            'Agrega nuevos registros
            If Not mSpots.GetChanges(DataRowState.Added) Is Nothing Then
                CantidadTransacciones += mSpots.GetChanges(DataRowState.Added).Rows.Count
                For Each Row As DataRow In mSpots.GetChanges(DataRowState.Added).Rows
                    SpotsDetalleNuevos = New SortedList
                    If Not Row("Des_Formato") Is DBNull.Value Then
                        Formato = Row("Des_Formato")
                    Else
                        Formato = String.Empty
                    End If
                    If Not Row("Direccion1") Is DBNull.Value Then
                        Calle = Row("Direccion1")
                    Else
                        Calle = String.Empty
                    End If
                    'AG Caras +++++++++++++++++++++++++++
                    If Not Row("Num_Caras") Is DBNull.Value Then
                        Caras = CInt(Row("Num_Caras"))
                    Else
                        Caras = 0
                    End If

                    If mIdMedio = mMedioViaPublica Then
                        'GG CISOP
                        If Not Row("Id_Tipo_Elemento") Is DBNull.Value Then
                            Id_Tipo_Elemento = Row("Id_Tipo_Elemento")
                        Else
                            Id_Tipo_Elemento = 0
                        End If

                        Id_SpotNuevo = SpotsVp.Agregar(mId_Campania, mId_Sistema, mId_Ejercicio, Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Formato, Row("Cod_Pobl1"), Row("Cod_Pobl2"), Calle, Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Caras, Activo.Login, Today, Row("Cod_AGIP"), Id_Tipo_Elemento, Row("AnchoVP"), Row("AltoVP"), Row("Cisop"), Row("CostoUnitario"))
                    Else
                        Id_SpotNuevo = SpotsVp.Agregar(mId_Campania, mId_Sistema, mId_Ejercicio, Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Formato, Row("Cod_Pobl1"), Row("Cod_Pobl2"), Calle, Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Caras, Activo.Login, Today, String.Empty, 0, 0, 0, String.Empty, 0)
                    End If
                    'Id_SpotNuevo = SpotsVp.Agregar(mId_Campania, mId_Sistema, mId_Ejercicio, Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Formato, Row("Cod_Pobl1"), Row("Cod_Pobl2"), Calle, Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Caras, Activo.Login, Today, Row("Cod_AGIP"))
                    If Not mSpotsDetalle.GetChanges(DataRowState.Added) Is Nothing Then
                        CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Added).Rows.Count
                        For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Added).Select("Id_Spot = " & Row("Id_Spot"))
                            Id_SpotDetalleNuevo = SpotsVp.AgregarDetalle(Id_SpotNuevo, mTemaViaPublica, RowDetalle("Fecha"), 0, Activo.Login, Today, mSpotDetalleEstado, RowDetalle("Observacion"))
                            SpotsDetalleNuevos.Add(RowDetalle("Id_Spot_Detalle"), Id_SpotDetalleNuevo)
                        Next
                    End If
                    Call ActualizarSpots(Row("Id_Spot"), Id_SpotNuevo, SpotsDetalleNuevos)
                Next
            End If
            If Not mSpotsDetalle.GetChanges(DataRowState.Added) Is Nothing Then
                CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Added).Rows.Count
                For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Added).Rows
                    InsertarDetalle = True
                    If Not mSpots.GetChanges(DataRowState.Added) Is Nothing Then
                        For Each Row As DataRow In mSpots.GetChanges(DataRowState.Added).Rows
                            If Row("Id_Spot") = RowDetalle("Id_Spot") Then
                                InsertarDetalle = False
                                Exit For
                            End If
                        Next
                    End If
                    If InsertarDetalle Then
                        Id_SpotDetalleNuevo = SpotsVp.AgregarDetalle(RowDetalle("Id_Spot"), mTemaViaPublica, RowDetalle("Fecha"), 0, Activo.Login, Today, mSpotDetalleEstado, RowDetalle("Observacion"))
                        Call ActualizarSpots(RowDetalle("Id_Spot"), RowDetalle("Id_Spot_Detalle"), Id_SpotDetalleNuevo)
                    End If
                Next
            End If
            'Actualiza registros modificados
            If Not mSpots.GetChanges(DataRowState.Modified) Is Nothing Then
                CantidadTransacciones += mSpots.GetChanges(DataRowState.Modified).Rows.Count
                For Each Row As DataRow In mSpots.GetChanges(DataRowState.Modified).Rows
                    If Not Row("Des_Formato") Is DBNull.Value Then
                        Formato = Row("Des_Formato")
                    Else
                        Formato = String.Empty
                    End If
                    If Not Row("Direccion1") Is DBNull.Value Then
                        Calle = Row("Direccion1")
                    Else
                        Calle = String.Empty
                    End If

                    'AG Caras +++++++++++++++++++++++++++
                    If Not Row("Num_Caras") Is DBNull.Value Then
                        Caras = CInt(Row("Num_Caras"))
                    Else
                        Caras = 0
                    End If
                    '++++++++++++++++++++++++++++++++++
                    'LC
                    If mIdMedio = mMedioViaPublica Then
                        'GG CISOP
                        If Not Row("Id_Tipo_Elemento") Is DBNull.Value Then
                            Id_Tipo_Elemento = Row("Id_Tipo_Elemento")
                        Else
                            Id_Tipo_Elemento = 0
                        End If

                        SpotsVp.Modificar(Row("Id_Spot"), Row("Id_Campania"), Row("Id_Sistema"), Row("Id_Ejercicio"), Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Formato, Row("Cod_Pobl1"), Row("Cod_Pobl2"), Calle, Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Caras, Activo.Login, Today, Row("Cod_AGIP"), Id_Tipo_Elemento, Row("AnchoVP"), Row("AltoVP"), Row("Cisop"), Row("CostoUnitario"))
                    Else
                        SpotsVp.Modificar(Row("Id_Spot"), Row("Id_Campania"), Row("Id_Sistema"), Row("Id_Ejercicio"), Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Formato, Row("Cod_Pobl1"), Row("Cod_Pobl2"), Calle, Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Caras, Activo.Login, Today, String.Empty, 0, 0, 0, String.Empty, 0)
                    End If

                Next
            End If

            'AG 03/11/2010 ----------------------------------------------------------------------------------------------------------------------------------------------------------
            If ActualizarDescuentos = True Then
                If mSpots.Rows.Count > 0 Then
                    For Each Row As DataRow In mSpots.Rows
                        If Not Row("Des_Formato") Is DBNull.Value Then
                            Formato = Row("Des_Formato")
                        Else
                            Formato = String.Empty
                        End If
                        If Not Row("Direccion1") Is DBNull.Value Then
                            Calle = Row("Direccion1")
                        Else
                            Calle = String.Empty
                        End If

                        'AG Caras +++++++++++++++++++++++++++
                        If Not Row("Num_Caras") Is DBNull.Value Then
                            Caras = CInt(Row("Num_Caras"))
                        Else
                            Caras = 0
                        End If
                        '++++++++++++++++++++++++++++++++++
                        'LC
                        If mIdMedio = mMedioViaPublica Then

                            'GG CISOP
                            If Not Row("Id_Tipo_Elemento") Is DBNull.Value Then
                                Id_Tipo_Elemento = Row("Id_Tipo_Elemento")
                            Else
                                Id_Tipo_Elemento = 0
                            End If

                            SpotsVp.Modificar(Row("Id_Spot"), Row("Id_Campania"), Row("Id_Sistema"), Row("Id_Ejercicio"), Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Formato, Row("Cod_Pobl1"), Row("Cod_Pobl2"), Calle, Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Caras, Activo.Login, Today, Row("Cod_AGIP"), Id_Tipo_Elemento, Row("AnchoVP"), Row("AltoVP"), Row("Cisop"), Row("CostoUnitario"))
                        Else
                            SpotsVp.Modificar(Row("Id_Spot"), Row("Id_Campania"), Row("Id_Sistema"), Row("Id_Ejercicio"), Row("Id_Soporte"), Row("Id_Producto"), Row("Id_Material"), Formato, Row("Cod_Pobl1"), Row("Cod_Pobl2"), Calle, Row("Bruto"), Row("dcto1"), Row("dcto2"), Row("dcto3"), Row("dcto4"), Row("dcto5"), Row("Neto"), Row("Id_Convenio"), Caras, Activo.Login, Today, String.Empty, 0, 0, 0, String.Empty, 0)
                        End If
                    Next
                    If CantidadTransacciones = 0 Then
                        SpotsVp.TerminarTransaccion()
                    End If
                    ActualizarDescuentos = False
                End If
            End If
            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            If Not mSpotsDetalle.GetChanges(DataRowState.Modified) Is Nothing Then
                CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Modified).Rows.Count
                For Each RowDetalle As DataRow In mSpotsDetalle.GetChanges(DataRowState.Modified).Rows
                    SpotsVp.ModificarDetalle(RowDetalle("Id_Spot"), RowDetalle("Id_Spot_Detalle"), mTemaViaPublica, RowDetalle("Fecha"), 0, mSpotDetalleEstado, RowDetalle("Observacion"), Activo.Login, Today)
                Next
            End If
            If CantidadTransacciones > 0 Then
                SpotsVp.TerminarTransaccion()
            End If
            SpotsVp.Desconectar()
            mDatos.AcceptChanges()
        Catch ex As Exception
            SpotsVp.AbortarTransaccion()
            Mensaje(ex.Message, TipoMensaje.DeError)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ActualizarSpots(ByVal pId_Spot As Integer, ByVal pId_SpotDetalle As Integer, ByVal pId_SpotDetalleNuevo As Integer)
        Dim Filtro As New StringBuilder

        Filtro.Append("Id_Spot = ")
        Filtro.Append(pId_Spot)
        Filtro.Append(" and Id_Spot_Detalle = ")
        Filtro.Append(pId_SpotDetalle)

        For Each RowDetalle As DataRow In mSpotsDetalle.Select(Filtro.ToString)
            RowDetalle("Id_Spot_Detalle") = pId_SpotDetalleNuevo
        Next
    End Sub

    Private Sub ActualizarSpots(ByVal pId_Spot As Integer, ByVal pId_SpotNuevo As Integer, ByVal pSpotsDetalleNuevos As SortedList)
        Dim Filtro As New StringBuilder
        Filtro.Append("Id_Spot = ")
        Filtro.Append(pId_Spot)

        For Each Row As DataRow In mSpots.Select(Filtro.ToString)
            Row("Id_Spot") = pId_SpotNuevo
        Next

        If Not pSpotsDetalleNuevos Is Nothing AndAlso pSpotsDetalleNuevos.Count > 0 Then
            For Index As Integer = 0 To pSpotsDetalleNuevos.Count - 1
                Filtro = New StringBuilder
                Filtro.Append("Id_Spot = ")
                Filtro.Append(pId_SpotNuevo)
                Filtro.Append(" and Id_Spot_Detalle = ")
                Filtro.Append(pSpotsDetalleNuevos.GetKey(Index))

                If mSpotsDetalle.Select(Filtro.ToString).Length > 0 Then
                    For Each RowDetalle As DataRow In mSpotsDetalle.Select(Filtro.ToString)
                        RowDetalle("Id_Spot_Detalle") = pSpotsDetalleNuevos(pSpotsDetalleNuevos.GetKey(Index))
                    Next
                Else
                    Filtro = New StringBuilder
                    Filtro.Append("Id_Spot = ")
                    Filtro.Append(pId_Spot)
                    Filtro.Append(" and Id_Spot_Detalle = ")
                    Filtro.Append(pSpotsDetalleNuevos.GetKey(Index))

                    For Each RowDetalle As DataRow In mSpotsDetalle.Select(Filtro.ToString)
                        RowDetalle("Id_Spot_Detalle") = pSpotsDetalleNuevos(pSpotsDetalleNuevos.GetKey(Index))
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub ABMSpotsDetalle(ByRef pCell As UltraGridCell)
        Dim Fecha As DateTime
        Dim Observacion As String
        Dim Cantidad, CantidadAnterior, Id_Spot, Id_Spot_Detalle, Soporte As Integer
        Dim Filtro, FiltroDetalle As StringBuilder

        If Not pCell.Value Is DBNull.Value AndAlso pCell.Value > 0 Then
            Cantidad = Convert.ToInt32(pCell.Value)
        End If

        If Cantidad >= 100 Then
            Mensaje("La cantidad máxima es 99 avisos.", TipoMensaje.Informacion)
            pCell.Value = pCell.OriginalValue
            Exit Sub
        End If

        Fecha = Convert.ToDateTime(pCell.Column.Key)
        Id_Spot = Convert.ToInt32(pCell.Row.Cells("Id_Spot").Value)
        Soporte = Convert.ToInt32(pCell.Row.Cells("Id_Soporte").Value)

        Filtro = New StringBuilder
        Filtro.Append("Id_Spot = ")
        Filtro.Append(Id_Spot)
        Filtro.Append(" and Fecha = '")
        Filtro.Append(Fecha.Date.ToString("dd/MM/yyyy"))
        Filtro.Append("'")

        CantidadAnterior = mSpotsDetalle.Select(Filtro.ToString).Length

        If Cantidad = 0 AndAlso CantidadAnterior = 0 Then
            mAplicandoNullValue = True
            pCell.Value = DBNull.Value
            mAplicandoNullValue = False
        Else
            If Cantidad = CantidadAnterior Then
                Exit Sub
            End If
            If Cantidad > CantidadAnterior Then
                For Index As Integer = 1 To Cantidad - CantidadAnterior
                    If CantidadAnterior > 0 Then
                        Observacion = mSpotsDetalle.Select(Filtro.ToString)(0)("Observacion")
                    Else
                        Observacion = String.Empty
                    End If
                    Call CargarDetalle(Id_Spot, mIdSpotDetalleNuevo, Fecha, mSpotDetalleEstado, Observacion)
                    mIdSpotDetalleNuevo -= 1
                Next
            Else
                For Index As Integer = 1 To CantidadAnterior - Cantidad
                    Filtro.Append(" and Id_Spot_Estado = 'P'")
                    Id_Spot_Detalle = mSpotsDetalle.Select(Filtro.ToString, "Id_Spot_Detalle asc")(0)("Id_Spot_Detalle")
                    Call EliminarDetalle(pCell.Row, Id_Spot_Detalle, Fecha)
                Next
                If Cantidad = 0 Then
                    mAplicandoNullValue = True
                    pCell.Value = DBNull.Value
                    pCell.Appearance.Image = Nothing
                    mAplicandoNullValue = False
                    pCell.ToolTipText = String.Empty
                End If
            End If

            Call CalcularTotales(pCell, Cantidad - CantidadAnterior)
        End If
    End Sub

    Private Sub InicializarDescuentos(ByVal pRow As UltraGridRow)
        pRow.Cells("dcto1").Value = 0
        pRow.Cells("dcto2").Activation = Activation.NoEdit
        pRow.Cells("dcto2").Value = 0
        pRow.Cells("dcto3").Activation = Activation.NoEdit
        pRow.Cells("dcto3").Value = 0
        pRow.Cells("dcto4").Activation = Activation.NoEdit
        pRow.Cells("dcto4").Value = 0
        pRow.Cells("dcto5").Activation = Activation.NoEdit
        pRow.Cells("dcto5").Value = 0
    End Sub

    Private Sub AplicarHabilitacionDescuento(ByRef pRow As UltraGridRow)
        Call ValidarValoresNumericos(pRow)
        If Convert.ToDouble(pRow.Cells("dcto1").Value) = 0 Then
            pRow.Cells("dcto2").Activation = Activation.NoEdit
            pRow.Cells("dcto2").Value = 0
        Else
            pRow.Cells("dcto2").Activation = Activation.AllowEdit
        End If
        If Convert.ToDouble(pRow.Cells("dcto2").Value) = 0 Then
            pRow.Cells("dcto3").Activation = Activation.NoEdit
            pRow.Cells("dcto3").Value = 0
        Else
            pRow.Cells("dcto3").Activation = Activation.AllowEdit
        End If
        If Convert.ToDouble(pRow.Cells("dcto3").Value) = 0 Then
            pRow.Cells("dcto4").Activation = Activation.NoEdit
            pRow.Cells("dcto4").Value = 0
        Else
            pRow.Cells("dcto4").Activation = Activation.AllowEdit
        End If
        If Convert.ToDouble(pRow.Cells("dcto4").Value) = 0 Then
            pRow.Cells("dcto5").Activation = Activation.NoEdit
            pRow.Cells("dcto5").Value = 0
        Else
            pRow.Cells("dcto5").Activation = Activation.AllowEdit
        End If
    End Sub

    Private Sub AplicarCeldaOculta(ByRef pColumna As UltraGridColumn)
        pColumna.CellActivation = UltraWinGrid.Activation.NoEdit
        pColumna.Width = 120
        pColumna.CellClickAction = CellClickAction.RowSelect
    End Sub

    Private Sub AplicarColumnasOcultas(ByRef pBanda As UltraGridBand)
        pBanda.Columns("Id_Campania").Hidden = True
        pBanda.Columns("Id_Sistema").Hidden = True
        pBanda.Columns("Id_Ejercicio").Hidden = True
        pBanda.Columns("Id_Spot").Hidden = True
        pBanda.Columns("Id_Convenio").Hidden = True
        pBanda.Columns("TipoConvenio").Hidden = True
        pBanda.Columns("ImporteConvenio").Hidden = True
        'AG Produccion ++++++++++++++++++++++++++++++++++
        If mIdMedio = Me.mMedioProduccion Then
            pBanda.Columns("Num_Caras").Hidden = True
            pBanda.Columns("Id_Material").Hidden = True
            pBanda.Columns("Direccion1").Hidden = True
        End If
        '++++++++++++++++++++++++++++++++++++++++++++
    End Sub

    Private Sub AplicarTextoNumericoPosicion(ByRef pBanda As UltraGridBand)

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            pBanda.Columns("Alto").CellAppearance.TextHAlign = HAlign.Right
            pBanda.Columns("Ancho").CellAppearance.TextHAlign = HAlign.Right
        End If

        If mIdMedio = mMedioViaPublica Then
            pBanda.Columns("AnchoVP").CellAppearance.TextHAlign = HAlign.Right
            pBanda.Columns("AltoVP").CellAppearance.TextHAlign = HAlign.Right
            pBanda.Columns("CostoUnitario").CellAppearance.TextHAlign = HAlign.Right
        End If

        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    pBanda.Columns("Alto").CellAppearance.TextHAlign = HAlign.Right
        '    pBanda.Columns("Ancho").CellAppearance.TextHAlign = HAlign.Right
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        pBanda.Columns("Bruto").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("dcto1").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("dcto2").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("dcto3").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("dcto4").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("dcto5").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("TotalSpots").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("TotalBruto").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("TotalNeto").CellAppearance.TextHAlign = HAlign.Right
    End Sub

    Private Sub AplicarTextoNumericoImpresionPosicion(ByRef pBanda As UltraGridBand)

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            pBanda.Columns("Alto").CellAppearance.TextHAlign = HAlign.Right
            pBanda.Columns("Ancho").CellAppearance.TextHAlign = HAlign.Right
        End If

        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    pBanda.Columns("Alto").CellAppearance.TextHAlign = HAlign.Right
        '    pBanda.Columns("Ancho").CellAppearance.TextHAlign = HAlign.Right
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        pBanda.Columns("Bruto").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("D1").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("D2").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("D3").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("D4").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("D5").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("TotalSpots").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("TotalBruto").CellAppearance.TextHAlign = HAlign.Right
        pBanda.Columns("TotalNeto").CellAppearance.TextHAlign = HAlign.Right
    End Sub

    Private Sub AplicarFormatoCabecera(ByRef pColumna As UltraGridColumn, ByVal pEncabezado As String, Optional ByVal pInd_Fijo As Integer = 0, Optional ByVal pNumerico As Boolean = False)
        pColumna.Header.Caption = pEncabezado
        pColumna.Header.Appearance.TextHAlign = HAlign.Center
        If pInd_Fijo > 0 Then
            pColumna.Width = pInd_Fijo
        End If
        If pNumerico Then
            pColumna.CellAppearance.TextHAlign = HAlign.Right
        End If
    End Sub

    Private Sub AplicarFormatoColumnaSize(ByRef pBanda As UltraGridBand)
        For Each Columna As UltraGridColumn In pBanda.Columns
            If Not EsColumnaCalendario(Columna.Key) Then
                If Columna.CalculateAutoResizeWidth(PerformAutoSizeType.AllRowsInBand, False) > Columna.Width Then
                    Columna.Width = Columna.CalculateAutoResizeWidth(PerformAutoSizeType.AllRowsInBand, False) + 20
                End If
            End If
        Next
    End Sub

    Private Sub AplicarFormatoCabeceraCalendario(ByRef pBanda As UltraGridBand)
        Dim Index, IndexDia As Integer
        For IndexColumna As Integer = 0 To pBanda.Columns.Count - 1
            If EsColumnaCalendario(pBanda.Columns(IndexColumna).Key) Then
                pBanda.Columns(IndexColumna).Header.Caption = mFechas(Index)
                pBanda.Columns(IndexColumna).CellAppearance.TextHAlign = HAlign.Right
                pBanda.Columns(IndexColumna).Width = 38
                If CStr(mFechas(Index)).IndexOf("S") > -1 Or CStr(mFechas(Index)).IndexOf("D") > -1 Then
                    pBanda.Columns(IndexColumna).Header.Appearance.ForeColor = ColorLinaDomingo
                    pBanda.Columns(IndexColumna).CellAppearance.BorderColor = ColorLinaDomingo
                    pBanda.Columns(IndexColumna + 1).CellAppearance.BorderColor = ColorLinaDomingo
                End If
                If IndexDia = 7 Then
                    pBanda.Columns(IndexColumna).CellAppearance.BorderColor = ColorDia7
                    IndexDia = 0
                End If
                Index += 1
                IndexDia += 1
            End If
        Next
    End Sub

    Private Sub AplicarFormatoCabeceraImpresionCalendario(ByRef pBanda As UltraGridBand)
        Dim Index, IndexDia As Integer
        For IndexColumna As Integer = 0 To pBanda.Columns.Count - 1
            If EsColumnaCalendario(pBanda.Columns(IndexColumna).Key) Then
                pBanda.Columns(IndexColumna).Header.Appearance.TextHAlign = HAlign.Center
                pBanda.Columns(IndexColumna).CellAppearance.TextHAlign = HAlign.Right
                pBanda.Columns(IndexColumna).Width = 55
            End If
        Next
    End Sub

    Private Sub AplicarFormatoCalendario(ByRef pBanda As UltraGridBand)
        For Each Columna As UltraGridColumn In pBanda.Columns
            If EsColumnaCalendario(Columna.Key) Then
                Columna.Style = ColumnStyle.IntegerNonNegative
                Columna.PromptChar = String.Empty
                Columna.CellAppearance.TextHAlign = HAlign.Right
            End If
        Next
    End Sub

    Private Sub AplicarFormatoColumnaTotal(ByVal pColumna As UltraGridColumn)
        pColumna.CellAppearance.BackColor = ColorColTotales
    End Sub

    Private Sub AplicarFormatoPorcentaje(ByRef pColumna As UltraGridColumn, Optional ByVal pPorcentaje As Boolean = True)
        pColumna.PromptChar = String.Empty
        pColumna.MaxValue = 100
        If pPorcentaje Then
            pColumna.MinValue = -100
        Else
            pColumna.MinValue = 0
        End If
        pColumna.MaskDisplayMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.MaskDataMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.MaskClipMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.CellAppearance.TextHAlign = HAlign.Right
    End Sub

    Private Sub AplicarFormatoCurrency(ByRef pColumna As UltraGridColumn)
        pColumna.PromptChar = String.Empty
        pColumna.MaskInput = "$ nn,nnn,nnn.nn"
        pColumna.MaskDisplayMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.MaskDataMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.MaskClipMode = UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.CellAppearance.TextHAlign = HAlign.Right
    End Sub

    Private Sub AplicarFormatoDropDownList(ByRef pColumna As UltraGridColumn)
        Dim Lista As ValueList
        Select Case pColumna.Key
            Case "Id_Producto"
                Lista = ObtenerProductos()
            Case "Id_Material"
                Lista = ObtenerMateriales(0)
            Case "Id_Seccion"
                Lista = ObtenerSecciones()
            Case "Cod_Pobl1"
                Lista = ObtenerProvincias()
            Case "Cod_Pobl2"
                Lista = ObtenerPoblaciones(0)
            Case "DetalleColor"
                Lista = ObtenerDetalles()
            Case "Id_Tipo_Elemento"
                Lista = ObtenerTiposElementoVP()
        End Select
        pColumna.ValueList = Lista
        pColumna.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        pColumna.ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
        pColumna.Width = 120
    End Sub

    Private Sub AplicarFormatoDropDown(ByRef pColumna As UltraGridColumn)
        pColumna.ValueList = ObtenerConceptos()
        pColumna.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
        pColumna.ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
        pColumna.Width = 120
    End Sub

    ''' <summary>
    ''' Aplica el formato Combo al campo detalle.
    ''' </summary>
    ''' <param name="pColumna">Columna</param>
    ''' <remarks></remarks>
    Private Sub AplicarFormatoDetalle(ByRef pColumna As UltraGridColumn)
        pColumna.ValueList = ObtenerDetalles()
        pColumna.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
        pColumna.ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
        pColumna.Width = 120
    End Sub

    Private Sub AplicarFormatoRadioButton(ByRef pColumna As UltraGridColumn)
        pColumna.Editor = ObtenerEditorOpcional()
        pColumna.ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
        pColumna.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        pColumna.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        pColumna.Width = 120
    End Sub

    Private Sub AplicarSumatoria(ByVal pGrid As UltraGrid, ByVal pBand As UltraGridBand)
        If pBand.Summaries.Count = 0 Then
            For Each Columna As UltraGridColumn In pBand.Columns
                If EsColumnaCalendario(Columna.Key) Then
                    pBand.Summaries.Add(SummaryType.Sum, Columna, SummaryPosition.UseSummaryPositionColumn).DisplayFormat = "{0:#####.00}"
                End If
            Next
            pBand.Summaries.Add(SummaryType.Sum, pBand.Columns("TotalSpots"), SummaryPosition.UseSummaryPositionColumn).DisplayFormat = "{0:#####.00}"
            pBand.Summaries.Add(SummaryType.Sum, pBand.Columns("TotalBruto"), SummaryPosition.UseSummaryPositionColumn).DisplayFormat = "{0:#####.00}"
            pBand.Summaries.Add(SummaryType.Sum, pBand.Columns("TotalNeto"), SummaryPosition.UseSummaryPositionColumn).DisplayFormat = "{0:#####.00}"
            pGrid.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
            pGrid.DisplayLayout.Override.SummaryValueAppearance.TextHAlign = HAlign.Right
            pGrid.DisplayLayout.Override.SummaryDisplayArea = SummaryDisplayAreas.Bottom
        End If
    End Sub

    Private Sub CalcularNeto(ByRef pRow As UltraGridRow)
        Dim Tarifa, Bruto, Alto, Ancho As Double

        Bruto = pRow.Cells("Bruto").Value

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            Alto = pRow.Cells("Alto").Value
            Ancho = pRow.Cells("Ancho").Value
            If Convert.ToBoolean(pRow.Cells("Ind_Fijo").Value) Then
                Tarifa = Bruto
            Else
                Tarifa = Bruto * Alto * Ancho
            End If
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            Tarifa = Bruto
        End If

        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    Alto = pRow.Cells("Alto").Value
        '    Ancho = pRow.Cells("Ancho").Value

        '    If Convert.ToBoolean(pRow.Cells("Ind_Fijo").Value) Then
        '        Tarifa = Bruto
        '    Else
        '        Tarifa = Bruto * Alto * Ancho
        '    End If
        'Else
        '    Tarifa = Bruto
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Call CalcularNeto(pRow, Tarifa, 1)
        pRow.Cells("Neto").Value = Tarifa
    End Sub

    Private Sub CalcularNeto(ByRef pRow As UltraGridRow, ByRef pTarifa As Double, ByVal pNivel As Integer)
        Dim Descuento, DescuentoCalculado As Double
        Dim Columna As String = "dcto" & pNivel.ToString
        If pNivel = 6 Then Exit Sub
        Descuento = Convert.ToDouble(pRow.Cells(Columna).Value)
        If Descuento <> 0 Then
            DescuentoCalculado = (pTarifa * Descuento) / 100
            pTarifa -= DescuentoCalculado
            Call CalcularNeto(pRow, pTarifa, pNivel + 1)
        End If
    End Sub

    Private Sub CalcularTotalesModif(ByRef pCell As UltraGridCell)
        Dim TotalSpots, TotalCabecera, TotalSpotsCabecera As Integer
        Dim TotalBruto, TotalNeto, TotalBrutoCabecera, TotalNetoCabecera As Double

        If Not pCell.Row.Cells("TotalSpots").Value Is DBNull.Value Then
            TotalSpots = pCell.Row.Cells("TotalSpots").Value
        End If

        TotalBruto = ObtenerBruto(pCell.Row)
        TotalNeto = ObtenerNeto(pCell.Row)

        If TotalSpots > 0 Then
            pCell.Row.Cells("TotalSpots").Value = TotalSpots
            pCell.Row.Cells("TotalBruto").Value = TotalBruto * TotalSpots
            pCell.Row.Cells("TotalNeto").Value = TotalNeto * TotalSpots
        Else
            pCell.Row.Cells("TotalSpots").Value = DBNull.Value
            pCell.Row.Cells("TotalBruto").Value = DBNull.Value
            pCell.Row.Cells("TotalNeto").Value = DBNull.Value
        End If

        For Each Child As UltraGridChildBand In pCell.Row.ParentRow.ChildBands
            For Each RowDetalle As UltraGridRow In Child.Rows
                If Not RowDetalle.Cells("TotalSpots").Value Is DBNull.Value Then
                    TotalSpotsCabecera += RowDetalle.Cells("TotalSpots").Value
                End If
                If Not RowDetalle.Cells("TotalBruto").Value Is DBNull.Value Then
                    TotalBrutoCabecera += RowDetalle.Cells("TotalBruto").Value
                End If
                If Not RowDetalle.Cells("TotalNeto").Value Is DBNull.Value Then
                    TotalNetoCabecera += RowDetalle.Cells("TotalNeto").Value
                End If
            Next
        Next

        If TotalBrutoCabecera > 0 Then
            pCell.Row.ParentRow.Cells("TotalBruto").Value = TotalBrutoCabecera
        Else
            pCell.Row.ParentRow.Cells("TotalBruto").Value = DBNull.Value
        End If
        If TotalNetoCabecera > 0 Then
            pCell.Row.ParentRow.Cells("TotalNeto").Value = TotalNetoCabecera
        Else
            pCell.Row.ParentRow.Cells("TotalNeto").Value = DBNull.Value
        End If
    End Sub

    Private Sub CalcularTotales(ByRef pRow As DataRow, ByVal pSoporte As Integer, ByVal pId_Spot As Integer)
        Dim Cabecera As DataRow
        Dim TotalSpots As Integer
        Dim TotalBruto, TotalNeto As Double
        Dim NombreCampoFecha, Estado As String
        Dim PedidoEncontrado As Boolean

        Cabecera = mDatosCabecera.Select("Id_Soporte = " & pSoporte)(0)

        For Each Detalle As DataRow In mSpotsDetalle.Select("Id_Spot = " & pId_Spot)
            NombreCampoFecha = Convert.ToDateTime(Detalle("Fecha")).Date.ToString("dd/MM/yyyy")
            If Not pRow(NombreCampoFecha) Is DBNull.Value Then
                pRow(NombreCampoFecha) += 1
            Else
                pRow(NombreCampoFecha) = 1
            End If
            TotalSpots += 1

            If Not Cabecera(NombreCampoFecha) Is DBNull.Value Then
                Cabecera(NombreCampoFecha) += 1
            Else
                Cabecera(NombreCampoFecha) = 1
            End If
        Next

        For Each Row As UltraGridRow In ugPlanificacion.Rows
            PedidoEncontrado = False
            For Each Child As UltraGridChildBand In Row.ChildBands
                For Each ChildRow As UltraGridRow In Child.Rows
                    If ChildRow.Cells("Id_Spot").Value = pId_Spot Then
                        TotalBruto = ObtenerBruto(ChildRow)
                        TotalNeto = ObtenerNeto(ChildRow)
                        PedidoEncontrado = True
                        Exit For
                    End If
                Next
            Next
            If PedidoEncontrado Then
                Exit For
            End If
        Next

        If TotalSpots > 0 Then
            pRow("TotalSpots") = TotalSpots
            pRow("TotalBruto") = TotalBruto * TotalSpots
            pRow("TotalNeto") = TotalNeto * TotalSpots
        Else
            pRow("TotalSpots") = DBNull.Value
            pRow("TotalBruto") = DBNull.Value
            pRow("TotalNeto") = DBNull.Value
        End If

        Cabecera("TotalSpots") = 0
        Cabecera("TotalBruto") = 0
        Cabecera("TotalNeto") = 0
        If Not Cabecera("TotalSpots") Is DBNull.Value Then
            Cabecera("TotalSpots") += TotalSpots
            Cabecera("TotalBruto") += TotalBruto * TotalSpots
            Cabecera("TotalNeto") += TotalNeto * TotalSpots
        Else
            Cabecera("TotalSpots") = TotalSpots
            Cabecera("TotalBruto") = TotalBruto * TotalSpots
            Cabecera("TotalNeto") = TotalNeto * TotalSpots
        End If

        If Cabecera("TotalSpots") = 0 Then
            Cabecera("TotalSpots") = DBNull.Value
            Cabecera("TotalBruto") = DBNull.Value
            Cabecera("TotalNeto") = DBNull.Value
        End If
    End Sub

    Private Sub CalcularTotales(ByRef pCell As UltraGridCell, ByVal pValor As Integer)
        Dim TotalSpots, TotalCabecera, TotalSpotsCabecera As Integer
        Dim TotalBruto, TotalNeto, TotalBrutoCabecera, TotalNetoCabecera As Double

        If Not pCell.Row.Cells("TotalSpots").Value Is DBNull.Value Then
            TotalSpots = pCell.Row.Cells("TotalSpots").Value
        End If
        TotalSpots += pValor
        TotalBruto = ObtenerBruto(pCell.Row)
        TotalNeto = ObtenerNeto(pCell.Row)

        If TotalSpots > 0 Then
            pCell.Row.Cells("TotalSpots").Value = TotalSpots
            pCell.Row.Cells("TotalBruto").Value = TotalBruto * TotalSpots
            pCell.Row.Cells("TotalNeto").Value = TotalNeto * TotalSpots
        Else
            pCell.Row.Cells("TotalSpots").Value = DBNull.Value
            pCell.Row.Cells("TotalBruto").Value = DBNull.Value
            pCell.Row.Cells("TotalNeto").Value = DBNull.Value
        End If

        If Not pCell.Row.ParentRow.Cells(pCell.Column.Key).Value Is DBNull.Value Then
            TotalCabecera = pCell.Row.ParentRow.Cells(pCell.Column.Key).Value
        End If
        TotalCabecera += pValor

        If TotalCabecera > 0 Then
            pCell.Row.ParentRow.Cells(pCell.Column.Key).Value = TotalCabecera
        Else
            pCell.Row.ParentRow.Cells(pCell.Column.Key).Value = DBNull.Value
        End If

        If Not pCell.Row.ParentRow.Cells("TotalSpots").Value Is DBNull.Value Then
            TotalSpotsCabecera = pCell.Row.ParentRow.Cells("TotalSpots").Value
        End If
        TotalSpotsCabecera += pValor

        If TotalSpotsCabecera > 0 Then
            pCell.Row.ParentRow.Cells("TotalSpots").Value = TotalSpotsCabecera
        Else
            pCell.Row.ParentRow.Cells("TotalSpots").Value = DBNull.Value
        End If

        For Each Child As UltraGridChildBand In pCell.Row.ParentRow.ChildBands
            For Each RowDetalle As UltraGridRow In Child.Rows
                If Not RowDetalle.Cells("TotalBruto").Value Is DBNull.Value Then
                    TotalBrutoCabecera += RowDetalle.Cells("TotalBruto").Value
                End If
                If Not RowDetalle.Cells("TotalNeto").Value Is DBNull.Value Then
                    TotalNetoCabecera += RowDetalle.Cells("TotalNeto").Value
                End If
            Next
        Next

        If TotalBrutoCabecera > 0 Then
            pCell.Row.ParentRow.Cells("TotalBruto").Value = TotalBrutoCabecera
        Else
            pCell.Row.ParentRow.Cells("TotalBruto").Value = DBNull.Value
        End If
        If TotalNetoCabecera > 0 Then
            pCell.Row.ParentRow.Cells("TotalNeto").Value = TotalNetoCabecera
        Else
            pCell.Row.ParentRow.Cells("TotalNeto").Value = DBNull.Value
        End If

    End Sub

    Private Sub CalcularTotales(ByRef pRow As UltraGridRow)
        Dim TotalCelda, Total As Integer
        Dim TotalBruto, TotalNeto As Double

        For Each Celda As UltraGridCell In pRow.Cells
            If EsColumnaCalendario(Celda.Column.Key) Then
                TotalCelda = 0
                If Not pRow.ChildBands Is Nothing AndAlso pRow.ChildBands(0).Rows.Count > 0 Then
                    For Each Row As UltraGridRow In pRow.ChildBands(0).Rows
                        If Not Row.Cells(Celda.Column.Key).Value Is DBNull.Value Then
                            TotalCelda += Row.Cells(Celda.Column.Key).Value
                        End If
                    Next
                End If
                Total += TotalCelda
                If TotalCelda > 0 Then
                    Celda.Value = TotalCelda
                Else
                    Celda.Value = DBNull.Value
                End If
            End If
        Next

        For Each Child As UltraGridChildBand In pRow.ChildBands
            For Each RowDetalle As UltraGridRow In Child.Rows
                If Not RowDetalle.Cells("TotalBruto").Value Is DBNull.Value Then
                    TotalBruto += RowDetalle.Cells("TotalBruto").Value
                End If
                If Not RowDetalle.Cells("TotalNeto").Value Is DBNull.Value Then
                    TotalNeto += RowDetalle.Cells("TotalNeto").Value
                End If
            Next
        Next

        If Total > 0 Then
            pRow.Cells("TotalSpots").Value = Total
            pRow.Cells("TotalBruto").Value = TotalBruto
            pRow.Cells("TotalNeto").Value = TotalNeto
        Else
            pRow.Cells("TotalSpots").Value = DBNull.Value
            pRow.Cells("TotalBruto").Value = DBNull.Value
            pRow.Cells("TotalNeto").Value = DBNull.Value
        End If
    End Sub

    Private Sub CalcularTotales()
        Dim Cantidad, CantidadTotal, Ancho As Integer
        Dim Alto, Bruto, BrutoParcial, BrutoTotal, Neto, NetoParcial, NetoTotal As Double
        Dim IndiceFijo As Boolean

        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            BrutoParcial = 0
            NetoParcial = 0
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each RowNueva As UltraGridRow In Childs.Rows
                    If Not RowNueva.Cells("TotalSpots").Value Is DBNull.Value Then
                        Cantidad = RowNueva.Cells("TotalSpots").Value
                    Else
                        Cantidad = 0
                    End If
                    CantidadTotal += Cantidad
                    Bruto = RowNueva.Cells("Bruto").Value

                    'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                        IndiceFijo = RowNueva.Cells("Ind_Fijo").Value
                        If Not IndiceFijo Then
                            Ancho = RowNueva.Cells("Ancho").Value
                            Alto = RowNueva.Cells("Alto").Value
                            Bruto = Bruto * Alto * Ancho
                        End If
                    End If

                    'AG Codigo anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    'If mIdMedio <> mMedioViaPublica Then
                    '    IndiceFijo = RowNueva.Cells("Ind_Fijo").Value
                    '    If Not IndiceFijo Then
                    '        Ancho = RowNueva.Cells("Ancho").Value
                    '        Alto = RowNueva.Cells("Alto").Value
                    '        Bruto = Bruto * Alto * Ancho
                    '    End If
                    'End If
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                    Bruto = Cantidad * Bruto
                    BrutoTotal += Bruto
                    Neto = RowNueva.Cells("Neto").Value
                    Neto = Cantidad * Neto
                    NetoTotal += Neto

                    BrutoParcial += Bruto
                    NetoParcial += Neto
                Next
            Next
            RowParent.Cells("TotalBruto").Value = BrutoParcial
            RowParent.Cells("TotalNeto").Value = NetoParcial
        Next

        txtAvisos.Text = CantidadTotal
        txtBruto.Text = Math.Round(BrutoTotal, 2).ToString(" ##,###,###,##0.00")
        txtNeto.Text = Math.Round(NetoTotal, 2).ToString(" ##,###,###,##0.00")
    End Sub

    Private Sub ValidarValoresNumericos(ByRef pRow As UltraGridRow)

        'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            If pRow.Cells("Ancho").Value Is DBNull.Value Then
                pRow.Cells("Ancho").Value = 0
            End If
            If pRow.Cells("Alto").Value Is DBNull.Value Then
                pRow.Cells("Alto").Value = 0
            End If
        End If
        'AG Codigo anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    If pRow.Cells("Ancho").Value Is DBNull.Value Then
        '        pRow.Cells("Ancho").Value = 0
        '    End If
        '    If pRow.Cells("Alto").Value Is DBNull.Value Then
        '        pRow.Cells("Alto").Value = 0
        '    End If
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        If mIdMedio = mMedioViaPublica Then
            If pRow.Cells("CostoUnitario").Value Is DBNull.Value Then
                pRow.Cells("CostoUnitario").Value = 0
            End If
        End If

        If pRow.Cells("Bruto").Value Is DBNull.Value Then
            pRow.Cells("Bruto").Value = 0
        End If
        If pRow.Cells("dcto1").Value Is DBNull.Value Then
            pRow.Cells("dcto1").Value = 0
        End If
        If pRow.Cells("dcto2").Value Is DBNull.Value Then
            pRow.Cells("dcto2").Value = 0
        End If
        If pRow.Cells("dcto3").Value Is DBNull.Value Then
            pRow.Cells("dcto3").Value = 0
        End If
        If pRow.Cells("dcto4").Value Is DBNull.Value Then
            pRow.Cells("dcto4").Value = 0
        End If
        If pRow.Cells("dcto5").Value Is DBNull.Value Then
            pRow.Cells("dcto5").Value = 0
        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each Row As UltraGridRow In Childs.Rows

                    'AG Produccion +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
                        If Row.Cells("Id_Producto").Value < 0 OrElse Row.Cells("Id_Seccion").Value <= 0 Then
                            Mensaje("Existen registros incompletos.", TipoMensaje.Informacion)
                            Return False
                        End If
                    ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
                        If Row.Cells("Id_Producto").Value < 0 OrElse Row.Cells("Des_Formato").Value.ToString.Trim = String.Empty OrElse Row.Cells("Cod_Pobl1").Value <= 0 Then
                            Mensaje("Existen registros incompletos.", TipoMensaje.Informacion)
                            Return False
                        End If
                        'AG 02/09/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        If mIdMedio = mMedioViaPublica Then 'Permite guardar los valores de las CAras o Carteles en Cero o Nulo para el Medio Produccion
                            If IsNumeric(Row.Cells("Num_Caras").Value) Then
                                If Convert.ToInt32(Row.Cells("Cod_Pobl1").Value) = 1 And CInt(Row.Cells("Num_Caras").Value) = 0 Then
                                    Mensaje("El numero de Carteles debe ser Mayor a 0 y no Vacio, para Capital Federal. ", TipoMensaje.Informacion)
                                    Return False
                                End If
                            End If
                            If Convert.ToInt32(Row.Cells("Cod_Pobl1").Value) = 1 And Row.Cells("Num_Caras").Value Is DBNull.Value Then
                                Mensaje("El numero de Carteles debe ser Mayor a 0 y no Vacio, para Capital Federal. ", TipoMensaje.Informacion)
                                Return False
                            End If

                            If Row.Cells("Cod_Pobl2").Value <= 0 Then
                                Mensaje("Seleccione una Población.", TipoMensaje.Informacion)
                                Return False
                            End If

                            'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            If Convert.ToInt32(Row.Cells("Cod_Pobl1").Value) = 1 And Row.Cells("Cod_AGIP").Value.ToString.Trim = String.Empty Then
                                Mensaje("Ingrese un código AGIP.", TipoMensaje.Informacion)
                                Return False
                            End If

                            'GG -> CISOP
                            If Not Row.Cells("Id_Tipo_Elemento").Value Is DBNull.Value Then
                                Dim id As Integer = Convert.ToInt32(Row.Cells("Id_Tipo_Elemento").Value)
                                Dim tipo As Tipo_Elemento_VP = TipElemVP.Where(Function(o) o.IdTipoElemento = id).FirstOrDefault()
                                If (Not tipo Is Nothing) AndAlso tipo.RequiereMedida Then
                                    Dim gridAncho As Object = Row.Cells("AnchoVP").Value
                                    If (gridAncho Is DBNull.Value) Then
                                        Mensaje("Ingrese la dimensión ancho", TipoMensaje.Informacion)
                                        Return False
                                    End If

                                    Dim ancho As Single
                                    Single.TryParse(gridAncho, ancho)

                                    If (ancho <= 0) Then
                                        Mensaje("Ingrese la dimensión ancho", TipoMensaje.Informacion)
                                        Return False
                                    End If

                                    Dim gridAlto As Object = Row.Cells("AltoVP").Value
                                    If (gridAlto Is DBNull.Value) Then
                                        Mensaje("El ancho debe ser mayor a 0", TipoMensaje.Informacion)
                                        Return False
                                    End If

                                    Dim alto As Single
                                    Single.TryParse(gridAlto, alto)

                                    If (alto <= 0) Then
                                        Mensaje("El alto debe ser mayor a 0", TipoMensaje.Informacion)
                                        Return False
                                    End If

                                    If ((ancho * alto) >= 30) Then
                                        If Row.Cells("Cisop").Value Is DBNull.Value Then
                                            Mensaje("Ingrese el código Cisop", TipoMensaje.Informacion)
                                            Return False
                                        ElseIf Not IsNumeric(Row.Cells("Cisop").Value) Then
                                            Mensaje("El código Cisop no es válido", TipoMensaje.Informacion)
                                            Return False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    End If

                    'AG Codigo anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    'If mIdMedio <> mMedioViaPublica Then
                    '    If Row.Cells("Id_Producto").Value <= 0 OrElse Row.Cells("Id_Seccion").Value <= 0 Then
                    '        Mensaje("Existen registros incompletos.", TipoMensaje.Informacion)
                    '        Return False
                    '    End If
                    'Else
                    '    If Row.Cells("Id_Producto").Value <= 0 OrElse Row.Cells("Des_Formato").Value.ToString.Trim = String.Empty OrElse Row.Cells("Cod_Pobl1").Value <= 0 Then
                    '        Mensaje("Existen registros incompletos.", TipoMensaje.Informacion)
                    '        Return False
                    '    End If
                    '    'AG 02/09/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    '    If IsNumeric(Row.Cells("Num_Caras").Value) Then
                    '        If Convert.ToInt32(Row.Cells("Cod_Pobl1").Value) = 1 And CInt(Row.Cells("Num_Caras").Value) = 0 Then
                    '            Mensaje("El numero de Carteles debe ser Mayor a 0 y no Vacio, para Capital Federal. ", TipoMensaje.Informacion)
                    '            Return False
                    '        End If
                    '    End If
                    '    If Convert.ToInt32(Row.Cells("Cod_Pobl1").Value) = 1 And Row.Cells("Num_Caras").Value Is DBNull.Value Then
                    '        Mensaje("El numero de Carteles debe ser Mayor a 0 y no Vacio, para Capital Federal. ", TipoMensaje.Informacion)
                    '        Return False
                    '    End If
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    'End If
                    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                Next
            Next
        Next
        Return True
    End Function

    Private Function ValidarCompras(ByVal pRowSelected As UltraGridRow) As Boolean
        If mEsCargaNueva Then
            Return True
        End If
        If mSpotsComprados Is Nothing OrElse mSpotsComprados.Rows.Count <= 0 Then
            Return True
        End If

        Dim CantidadCompra As Integer
        Dim Filtro As New StringBuilder

        Filtro.Append("Id_Spot = ")
        Filtro.Append(pRowSelected.Cells("Id_Spot").Value)
        CantidadCompra = mSpotsComprados.Select(Filtro.ToString).Length
        If CantidadCompra > 0 Then
            Return False
        End If
        Return True
    End Function

    Private Function ValidarCompras(ByVal pCell As UltraGridCell) As Boolean
        If mEsCargaNueva Then
            Return True
        End If
        If mSpotsComprados Is Nothing OrElse mSpotsComprados.Rows.Count <= 0 Then
            Return True
        End If
        If Not EsColumnaCalendario(pCell.Column.Key) Then
            Return True
        End If

        Dim Cantidad, CantidadCompra As Integer
        Dim Filtro As New StringBuilder
        Filtro.Append("Id_Spot = ")
        Filtro.Append(pCell.Row.Cells("Id_Spot").Value)
        Filtro.Append(" and f_spot = '")
        Filtro.Append(pCell.Column.Key)
        Filtro.Append("'")

        CantidadCompra = mSpotsComprados.Select(Filtro.ToString).Length
        If Not pCell.Value Is DBNull.Value AndAlso pCell.Value > 0 Then
            Cantidad = Convert.ToInt32(pCell.Value)
        End If
        If Cantidad < CantidadCompra Then
            Filtro = New StringBuilder
            Filtro.Append("Existen avisos comprados.")
            Filtro.Append(vbCrLf)
            Filtro.Append("La cantidad mínima de avisos es ")
            Filtro.Append(CantidadCompra)
            Mensaje(Filtro.ToString, TipoMensaje.Informacion)
            pCell.Value = pCell.OriginalValue
            Return False
        End If

        Return True
    End Function

    Private Function ValidarAvisosComprados() As Boolean
        If CantidadAvisosComprados() > 0 Then
            If Mensaje("Existen avisos Comprados. " & vbCrLf & "¿Está Seguro que Desea Borrarlo?", TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Function CantidadAvisosComprados() As Integer
        For Each RowSelected As UltraGridRow In ugPlanificacion.Selected.Rows
            If RowSelected.Band.Index = 0 Then
                For Each ChildSelected As UltraGridChildBand In RowSelected.ChildBands
                    For Each RowChildSelected As UltraGridRow In ChildSelected.Rows
                        For Each ChildRowChildSelected As UltraGridChildBand In RowChildSelected.ChildBands
                            CantidadAvisosComprados = ChildRowChildSelected.Rows.Count
                            If CantidadAvisosComprados > 0 Then
                                Return CantidadAvisosComprados
                            End If
                        Next
                    Next
                Next
            Else
                For Each ChildSelected As UltraGridChildBand In RowSelected.ChildBands
                    CantidadAvisosComprados = ChildSelected.Rows.Count
                    If CantidadAvisosComprados > 0 Then
                        Return CantidadAvisosComprados
                    End If
                Next
            End If
        Next
        Return 0
    End Function

    Private Function CantidadCambios() As Integer
        Dim CantidadTransacciones As Integer
        If Not mSpotsDetalle.GetChanges(DataRowState.Deleted) Is Nothing Then
            CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Deleted).Rows.Count
        End If
        If Not mSpots.GetChanges(DataRowState.Deleted) Is Nothing Then
            CantidadTransacciones += mSpots.GetChanges(DataRowState.Deleted).Rows.Count
        End If
        If Not mSpots.GetChanges(DataRowState.Modified) Is Nothing Then
            CantidadTransacciones += mSpots.GetChanges(DataRowState.Modified).Rows.Count
        End If
        If Not mSpotsDetalle.GetChanges(DataRowState.Modified) Is Nothing Then
            CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Modified).Rows.Count
        End If
        If Not mSpots.GetChanges(DataRowState.Added) Is Nothing Then
            CantidadTransacciones += mSpots.GetChanges(DataRowState.Added).Rows.Count
        End If
        If Not mSpotsDetalle.GetChanges(DataRowState.Added) Is Nothing Then
            CantidadTransacciones += mSpotsDetalle.GetChanges(DataRowState.Added).Rows.Count
        End If

        Return CantidadTransacciones
    End Function

    Private Function EsColumnaCalendario(ByVal NombreColumna As String) As Boolean
        'si tiene una barra es una columna del calendario
        '(la barra es porque los nombres de las columnas del calendario son una Fecha '24/11/2005')
        If NombreColumna.IndexOf("/") > -1 Then
            Return True
        End If

        Return False
    End Function

    Private Function ObtenerRow(ByVal pId_Spot As Integer) As UltraGridRow
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each RowNueva As UltraGridRow In Childs.Rows
                    If RowNueva.Cells("Id_Spot").Value = pId_Spot Then
                        Return RowNueva
                    End If
                Next
            Next
        Next
        Return Nothing
    End Function
    'LC 11/02/2014 Via Publica codigo AGIP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Function ObtenerRowSoporte(ByVal pId_Soporte As Integer) As UltraGridRow
        For Each RowParent As UltraGridRow In ugPlanificacion.Rows
            For Each Childs As UltraGridChildBand In RowParent.ChildBands
                For Each RowNueva As UltraGridRow In Childs.Rows
                    If RowNueva.Cells("Id_Soporte").Value = pId_Soporte Then
                        Return RowNueva
                    End If
                Next
            Next
        Next
        Return Nothing
    End Function

    Private Function ObtenerSoportes() As ValueList
        Dim Sop As New Soportes
        Dim dtSoportes As DataTable

        Soportes = New ValueList

        Sop.Id_medio = mIdMedio
        Sop.Id_tipo_soporte = mIdTipoSoporte
        Sop.Id_plaza = mIdPlaza
        dtSoportes = Sop.ObtenerSoportes()

        Soportes.ValueListItems.Add(0, " ")
        If Not dtSoportes Is Nothing Then
            For Each Soporte As DataRow In dtSoportes.Rows
                Soportes.ValueListItems.Add(Soporte("Id_Soporte"), Soporte("Descripcion"))
            Next
        End If

        Return Soportes
    End Function

    Private Function ObtenerProductos() As ValueList
        Dim Prod As New Productos
        Dim dtProductos As DataTable

        Productos = New ValueList

        Prod.Id_cliente = mIdCliente
        dtProductos = Prod.TraerProductos

        Productos.ValueListItems.Add(0, " ")
        If Not dtProductos Is Nothing Then
            For Each Producto As DataRow In dtProductos.Rows
                Productos.ValueListItems.Add(Producto("Id_Producto"), Producto("Descripcion"))
            Next
        End If

        Return Productos
    End Function

    Private Function ObtenerMateriales(ByVal pId_Producto As Integer) As ValueList
        Dim Mat As New Materiales
        Dim dtMateriales As DataTable

        Materiales = New ValueList
        Activo.IsMaterialEjercicio = True
        Mat.Id_cliente = mIdCliente
        Mat.Id_producto = pId_Producto
        Mat.id_medio = mIdMedio
        dtMateriales = Mat.TraerMateriales

        Materiales.ValueListItems.Add("0", " ")
        If Not dtMateriales Is Nothing Then
            For Each Material As DataRow In dtMateriales.Rows
                Materiales.ValueListItems.Add(Material("Id_Material"), Material("Descripcion"))
            Next
        End If

        Return Materiales
    End Function

    Private Function ObtenerConceptos() As ValueList
        Dim SpotsPr As New Spots_pr
        Dim dtConceptos As DataTable

        dtConceptos = SpotsPr.ObtenerConceptos(mIdMedio)

        Conceptos = New ValueList
        Conceptos.ValueListItems.Add(" ")
        If Not dtConceptos Is Nothing Then
            For Each Concepto As DataRow In dtConceptos.Rows
                Conceptos.ValueListItems.Add(Concepto("Des_Anuncio"))
            Next
        End If

        Return Conceptos
    End Function

    'GG 19/05/2015 Dimensiones + CISOP
    Private Function ObtenerTiposElementoVP() As ValueList
        TipElemVP = (New Tipo_Elemento_VP).ObtenerTiposElementosVP

        TiposElementoVP = New ValueList

        TiposElementoVP.ValueListItems.Add("0", " ")
        For Each tipo As Tipo_Elemento_VP In TipElemVP
            TiposElementoVP.ValueListItems.Add(tipo.IdTipoElemento, tipo.Descripcion)
        Next

        Return TiposElementoVP
    End Function

    ''' <summary>
    ''' Genera el DataTable que va a cargar el combo Detalle.
    ''' </summary>
    ''' <returns>ValueList</returns>
    ''' <remarks></remarks>
    Private Function ObtenerDetalles() As ValueList

        Dim dtDetalle As New DataTable
        Dim value As New ValueList
        Dim column As DataColumn
        Dim row As DataRow

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "id_Detalle"
        dtDetalle.Columns.Add(column)

        column = New DataColumn()
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Descripcion"
        dtDetalle.Columns.Add(column)

        row = dtDetalle.NewRow()
        row("id_Detalle") = 1
        row("Descripcion") = "Color"
        dtDetalle.Rows.Add(row)

        row = dtDetalle.NewRow()
        row("id_Detalle") = 2
        row("Descripcion") = "B/N"
        dtDetalle.Rows.Add(row)

        'Convierte el DataTable a ValueList
        If Not dtDetalle Is Nothing Then
            For Each detalle As DataRow In dtDetalle.Rows
                value.ValueListItems.Add(detalle("id_Detalle"), detalle("Descripcion"))
            Next
        End If

        Return value
    End Function

    Private Function ObtenerSecciones() As ValueList
        ''Dim Spotspr As New Spots_pr
        Dim dtSecciones As DataTable
        Dim _maestro As New Maestros

        Secciones = New ValueList

        dtSecciones = _maestro.seccionesObtener(mIdMedio) ''Spotspr.ObtenerSecciones(mIdMedio)
        Secciones.ValueListItems.Add(0, " ")
        If Not dtSecciones Is Nothing Then
            For Each Seccion As DataRow In dtSecciones.Rows
                Secciones.ValueListItems.Add(Seccion("id_Seccion"), Seccion("Descripcion"))
            Next
        End If

        Return Secciones
    End Function

    Private Function ObtenerInd_Fijos() As ValueList
        IndiceFijo = New ValueList
        IndiceFijo.ValueListItems.Add(True, "Fijo")
        IndiceFijo.ValueListItems.Add(False, "Variable")
        Return IndiceFijo
    End Function

    Private Function ObtenerProvincias() As ValueList
        Dim Spotsvp As New Spots_vp
        Dim dtProvincias As DataTable

        Provincias = New ValueList

        dtProvincias = Spotsvp.ObtenerProvincias()
        Provincias.ValueListItems.Add(0, " ")
        If Not dtProvincias Is Nothing Then
            For Each Provincia As DataRow In dtProvincias.Rows
                ''//POBLACION_1 PARA EVEREST ES <=> POBLACION_NIVEL2 DE MMS D_C
                Provincias.ValueListItems.Add(Provincia("Cod_Pobl1"), Provincia("Nom_Pobl1"))
            Next
        End If

        Return Provincias
    End Function

    Private Function ObtenerPoblaciones(ByVal pId_Provincia As Integer) As ValueList
        Dim Spotsvp As New Spots_vp
        Dim dtPoblaciones As DataTable

        Poblaciones = New ValueList

        Spotsvp.Cod_pobl1 = pId_Provincia
        dtPoblaciones = Spotsvp.ObtenerPoblaciones()

        Poblaciones.ValueListItems.Add("0", " ")
        If Not dtPoblaciones Is Nothing Then
            For Each Poblacion As DataRow In dtPoblaciones.Rows
                ''//POBLACION_2 PARA EVEREST ES <=> POBLACION_NIVEL 3 DE MMS D_C
                Poblaciones.ValueListItems.Add(Poblacion("Cod_Pobl2"), Poblacion("Nom_Pobl2"))
            Next
        End If

        Return Poblaciones
    End Function

    Private Function ObtenerDescripcion(ByVal pColumnName As String, ByVal pValue As String, Optional ByVal pOptionalValue As String = "") As String
        Dim Descripcion As String

        Select Case pColumnName
            Case "Id_Soporte"
                If Not Soportes.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = Soportes.FindByDataValue(pValue).DisplayText
                End If
            Case "Id_Producto"
                If Not Productos.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = Productos.FindByDataValue(pValue).DisplayText
                End If
            Case "Id_Material"
                Call ObtenerMateriales(pOptionalValue)
                If Not Materiales.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = Materiales.FindByDataValue(pValue).DisplayText
                End If
            Case "Concepto"
                If Not Conceptos.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = Conceptos.FindByDataValue(pValue).DisplayText
                End If
            Case "Id_Seccion"
                If Not Secciones.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = Secciones.FindByDataValue(pValue).DisplayText
                End If
            Case "Ind_Fijo"
                If Not IndiceFijo.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = IndiceFijo.FindByDataValue(pValue).DisplayText
                End If
            Case "Cod_Pobl1"
                If Not Provincias.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = Provincias.FindByDataValue(pValue).DisplayText
                End If
            Case "Cod_Pobl2"
                Call ObtenerPoblaciones(pOptionalValue)
                If Not Poblaciones.FindByDataValue(pValue) Is Nothing Then
                    Descripcion = Poblaciones.FindByDataValue(pValue).DisplayText
                End If
        End Select

        Return Descripcion
    End Function

    Private Function ObtenerEditorOpcional() As EmbeddableEditorBase
        Dim Ind_Fijos As ValueList = ObtenerInd_Fijos()
        Dim editorSettings As New DefaultEditorOwnerSettings
        editorSettings.DataType = GetType(Boolean)
        editorSettings.ValueList = Ind_Fijos
        Dim editors As New OptionSetEditor(New DefaultEditorOwner(editorSettings))
        Dim editor As EmbeddableEditorBase = Nothing
        editor = DirectCast(editors, EmbeddableEditorBase)

        Return editor
    End Function

    Private Function ObtenerEditorCurrency() As UltraWinMaskedEdit.UltraMaskedEdit
        Dim editorSettings As New UltraWinMaskedEdit.UltraMaskedEdit
        editorSettings.PromptChar = " "
        editorSettings.InputMask = "$ -nn,nnn,nnn.nn"
        editorSettings.DisplayMode = UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        editorSettings.DataMode = UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        editorSettings.ClipMode = UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding

        Return editorSettings
    End Function

    Private Function ObtenerCampoConvenio(ByVal pIdConvenio As Integer, ByVal pCampo As String) As Object
        If Not mConvenios Is Nothing AndAlso mConvenios.Count > 0 Then
            If mConvenios.Contains(pIdConvenio) Then
                Dim RowConvenio As DataRow = mConvenios(pIdConvenio)
                Return RowConvenio(pCampo)
            End If
        End If
    End Function

    Private Function ObtenerBruto(ByVal pRow As UltraGridRow) As Double
        Dim Bruto, Alto, Ancho As Double

        Bruto = pRow.Cells("Bruto").Value

        'AG Produccion ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mIdMedio = mMedioRevista Or mIdMedio = Me.mMedioPrensa Then
            Alto = pRow.Cells("Alto").Value
            Ancho = pRow.Cells("Ancho").Value
            If Convert.ToBoolean(pRow.Cells("Ind_Fijo").Value) Then
                Bruto = Bruto
            Else
                Bruto = Bruto * Alto * Ancho
            End If
        ElseIf mIdMedio = mMedioViaPublica Or mIdMedio = Me.mMedioProduccion Then
            Bruto = Bruto
        End If

        'AG Codigo Anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If mIdMedio <> mMedioViaPublica Then
        '    Alto = pRow.Cells("Alto").Value
        '    Ancho = pRow.Cells("Ancho").Value

        '    If Convert.ToBoolean(pRow.Cells("Ind_Fijo").Value) Then
        '        Bruto = Bruto
        '    Else
        '        Bruto = Bruto * Alto * Ancho
        '    End If
        'Else
        '    Bruto = Bruto
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Return Bruto
    End Function

    Private Function ObtenerNeto(ByVal pRow As UltraGridRow) As Double
        Dim Tarifa As Double
        Tarifa = ObtenerBruto(pRow)
        Call CalcularNeto(pRow, Tarifa, 1)
        Return Tarifa
    End Function


    Private Sub ColorearFilaDescuento(ByRef pRow As UltraGridRow)

        '    Dim index As Integer = pRow.Index + 1

        '    If pRow.Cells("id_convenio").Value = -1 Then
        '        pRow.Cells("dcto1").Appearance.BackColor = Color.Bisque
        '        pRow.Cells("dcto2").Appearance.BackColor = Color.Bisque
        '        pRow.Cells("dcto3").Appearance.BackColor = Color.Bisque
        '        pRow.Cells("dcto4").Appearance.BackColor = Color.Bisque
        '        pRow.Cells("dcto5").Appearance.BackColor = Color.Bisque
        '    End If

        'Bruto = pRow.Cells("Bruto").Value

        'If mIdMedio <> mMedioViaPublica Then
        '    Alto = pRow.Cells("Alto").Value
        '    Ancho = pRow.Cells("Ancho").Value

        '    If Convert.ToBoolean(pRow.Cells("Ind_Fijo").Value) Then
        '        Tarifa = Bruto
        '    Else
        '        Tarifa = Bruto * Alto * Ancho
        '    End If
        'Else
        '    Tarifa = Bruto
        'End If

        'Call CalcularNeto(pRow, Tarifa, 1)
        'pRow.Cells("Neto").Value = Tarifa
    End Sub
#End Region

    'GG 19/05/2015 Dimensiones + CISOP
    Private Sub ugPlanificacion_InitializeRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ugPlanificacion.InitializeRow
        If mIdMedio = mMedioViaPublica Then

            If (Not e.ReInitialize) OrElse mPaste Then
                Try
                    If TipElemVP Is Nothing Then
                        ObtenerTiposElementoVP()
                    End If

                    e.Row.Cells("AnchoVP").Activation = Activation.NoEdit
                    e.Row.Cells("AltoVP").Activation = Activation.NoEdit
                    e.Row.Cells("Cisop").Activation = Activation.NoEdit

                    If Not e.Row.Cells("Id_Tipo_elemento").Value Is DBNull.Value Then
                        Dim id As Integer
                        Integer.TryParse(e.Row.Cells("Id_Tipo_elemento").Value, id)
                        Dim tipo As Tipo_Elemento_VP = TipElemVP.Where(Function(o) o.IdTipoElemento = id).FirstOrDefault()

                        If Not tipo Is Nothing AndAlso tipo.RequiereMedida Then
                            e.Row.Cells("AnchoVP").Activation = Activation.AllowEdit
                            e.Row.Cells("AltoVP").Activation = Activation.AllowEdit

                            If (Not e.Row.Cells("AnchoVP").Value Is DBNull.Value) AndAlso (Not e.Row.Cells("AltoVP").Value Is DBNull.Value) Then
                                Dim ancho As Single
                                Single.TryParse(e.Row.Cells("AnchoVP").Value, ancho)

                                Dim alto As Single
                                Single.TryParse(e.Row.Cells("AltoVP").Value, alto)

                                If (alto * ancho) >= 30 Then
                                    e.Row.Cells("Cisop").Activation = Activation.AllowEdit
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    '...
                End Try
            End If
        End If
    End Sub
End Class

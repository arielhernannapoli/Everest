Imports System.Text
Imports Framework.Mensajes
Imports Infragistics.Win.UltraWinGrid
Imports HM.MMS.AR.Server.BusinessEntity.Control

Public Class frmAvisoCaido
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
    Friend WithEvents pnlGrillaPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pnlGrillaPrincipal_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents ugOrdenAviso As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents frmAvisoCaido_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _frmAvisoCaido_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAvisoCaido_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAvisoCaido_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAvisoCaido_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden", 0)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Soporte", 1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", 2)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora", 3)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duracion", 4)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Programa", 5)
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
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Restaurar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Restaurar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupOrdenAviso")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("RestaurarPopup")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("RestaurarPopup")
        Me.pnlGrillaPrincipal = New System.Windows.Forms.Panel
        Me.pnlGrillaPrincipal_Fill_Panel = New System.Windows.Forms.Panel
        Me.ugOrdenAviso = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.frmAvisoCaido_Fill_Panel = New System.Windows.Forms.Panel
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.pnlGrillaPrincipal.SuspendLayout()
        Me.pnlGrillaPrincipal_Fill_Panel.SuspendLayout()
        CType(Me.ugOrdenAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAvisoCaido_Fill_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGrillaPrincipal
        '
        Me.pnlGrillaPrincipal.Controls.Add(Me.pnlGrillaPrincipal_Fill_Panel)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top)
        Me.pnlGrillaPrincipal.Controls.Add(Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom)
        Me.pnlGrillaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillaPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlGrillaPrincipal.Name = "pnlGrillaPrincipal"
        Me.pnlGrillaPrincipal.Size = New System.Drawing.Size(544, 329)
        Me.pnlGrillaPrincipal.TabIndex = 13
        '
        'pnlGrillaPrincipal_Fill_Panel
        '
        Me.pnlGrillaPrincipal_Fill_Panel.Controls.Add(Me.ugOrdenAviso)
        Me.pnlGrillaPrincipal_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlGrillaPrincipal_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrillaPrincipal_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.pnlGrillaPrincipal_Fill_Panel.Name = "pnlGrillaPrincipal_Fill_Panel"
        Me.pnlGrillaPrincipal_Fill_Panel.Size = New System.Drawing.Size(544, 329)
        Me.pnlGrillaPrincipal_Fill_Panel.TabIndex = 0
        '
        'ugOrdenAviso
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugOrdenAviso.DisplayLayout.Appearance = Appearance1
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn1.CellAppearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 81
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 100
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.CellAppearance = Appearance3
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 71
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.CellAppearance = Appearance4
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 40
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.Caption = "Dur"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 40
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 190
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
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
        UltraGridBand1.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand1.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand1.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand1.Override.HeaderAppearance = Appearance6
        UltraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True
        Me.ugOrdenAviso.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugOrdenAviso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugOrdenAviso.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.ugOrdenAviso.DisplayLayout.MaxColScrollRegions = 1
        Me.ugOrdenAviso.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugOrdenAviso.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugOrdenAviso.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugOrdenAviso.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugOrdenAviso.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugOrdenAviso.DisplayLayout.Override.CellAppearance = Appearance13
        Me.ugOrdenAviso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugOrdenAviso.DisplayLayout.Override.CellPadding = 0
        Me.ugOrdenAviso.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugOrdenAviso.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.ugOrdenAviso.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Me.ugOrdenAviso.DisplayLayout.Override.RowAppearance = Appearance16
        Me.ugOrdenAviso.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.ugOrdenAviso.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugOrdenAviso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugOrdenAviso.DisplayLayout.Override.TemplateAddRowAppearance = Appearance17
        Me.ugOrdenAviso.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugOrdenAviso.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugOrdenAviso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugOrdenAviso.FlatMode = True
        Me.ugOrdenAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugOrdenAviso.Location = New System.Drawing.Point(0, 0)
        Me.ugOrdenAviso.Name = "ugOrdenAviso"
        Me.ugOrdenAviso.Size = New System.Drawing.Size(544, 329)
        Me.ugOrdenAviso.TabIndex = 2
        Me.ugOrdenAviso.TabStop = False
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Left
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Left"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 329)
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Right
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(544, 0)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Right"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 329)
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Top
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Top"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(544, 0)
        '
        '_pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom
        '
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 329)
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.Name = "_pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom"
        Me._pnlGrillaPrincipal_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(544, 0)
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
        UltraToolbar1.Text = "uToolbar"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool3.SharedProps.Caption = "Restaurar"
        ButtonTool3.SharedProps.ToolTipText = "Restaurar Avisos Caidos"
        ButtonTool4.SharedProps.Caption = "Salir"
        PopupMenuTool1.SharedProps.Caption = "PopupOrdenAviso"
        PopupMenuTool1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5})
        ButtonTool6.SharedProps.Caption = "Restaurar"
        ButtonTool6.SharedProps.ToolTipText = "Restaurar Avisos Caidos"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4, PopupMenuTool1, ButtonTool6})
        '
        'frmAvisoCaido_Fill_Panel
        '
        Me.frmAvisoCaido_Fill_Panel.Controls.Add(Me.pnlGrillaPrincipal)
        Me.frmAvisoCaido_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmAvisoCaido_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAvisoCaido_Fill_Panel.Location = New System.Drawing.Point(0, 22)
        Me.frmAvisoCaido_Fill_Panel.Name = "frmAvisoCaido_Fill_Panel"
        Me.frmAvisoCaido_Fill_Panel.Size = New System.Drawing.Size(544, 329)
        Me.frmAvisoCaido_Fill_Panel.TabIndex = 0
        '
        '_frmAvisoCaido_Toolbars_Dock_Area_Left
        '
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.Name = "_frmAvisoCaido_Toolbars_Dock_Area_Left"
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 329)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmAvisoCaido_Toolbars_Dock_Area_Right
        '
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(544, 22)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.Name = "_frmAvisoCaido_Toolbars_Dock_Area_Right"
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 329)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmAvisoCaido_Toolbars_Dock_Area_Top
        '
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.Name = "_frmAvisoCaido_Toolbars_Dock_Area_Top"
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(544, 22)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmAvisoCaido_Toolbars_Dock_Area_Bottom
        '
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 351)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.Name = "_frmAvisoCaido_Toolbars_Dock_Area_Bottom"
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(544, 0)
        Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'frmAvisoCaido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 351)
        Me.Controls.Add(Me.frmAvisoCaido_Fill_Panel)
        Me.Controls.Add(Me._frmAvisoCaido_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmAvisoCaido_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmAvisoCaido_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmAvisoCaido_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAvisoCaido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avisos Caidos"
        Me.pnlGrillaPrincipal.ResumeLayout(False)
        Me.pnlGrillaPrincipal_Fill_Panel.ResumeLayout(False)
        CType(Me.ugOrdenAviso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAvisoCaido_Fill_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mPresupuesto As Double
    Private mAvisosRestaurados As Boolean = False
    Private OrdenAvisoPoint As New Point
#End Region

#Region "Variables y Propiedades Publicas"
    Public WriteOnly Property Presupuesto() As Double
        Set(ByVal Value As Double)
            mPresupuesto = Value
        End Set
    End Property

    Public ReadOnly Property AvisosRstaurados() As Boolean
        Get
            Return mAvisosRestaurados
        End Get
    End Property
#End Region

#Region "Eventos"
    Private Sub frmAvisoCaido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ObtenerAvisosCaidos()
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Restaurar", "RestaurarPopup"
                Call RestaurarAvisosCaidos()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub ugOrdenAviso_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugOrdenAviso.DoubleClick
        Dim aUIElement As Infragistics.Win.UIElement
        Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
        Dim GridRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        aUIElement = ugOrdenAviso.DisplayLayout.UIElement.ElementFromPoint(New Point(OrdenAvisoPoint.X, OrdenAvisoPoint.Y))
        ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

        If ColumnHeader Is Nothing Then
            GridRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            If Not GridRow Is Nothing Then
                Call RestaurarAvisosCaidos()
            End If
        End If
    End Sub

    Private Sub ugOrdenAviso_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugOrdenAviso.MouseDown
        OrdenAvisoPoint.X = e.X
        OrdenAvisoPoint.Y = e.Y
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
                    Me.UltraToolbarsManager1.ShowPopup("PopupOrdenAviso")
                End If
            End If
        End If
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub ObtenerAvisosCaidos()
        If mPresupuesto > 0 Then
            Dim ControlMacheo As New Control_Macheo
            Dim dsAvisosCaidos As System.Collections.Generic.List(Of AvisoCaido)
            Dim dsOrdenAviso As DataSet
            Dim drOrdenAviso As DataRow
            Dim Hora As StringBuilder
            Dim HoraParcial As String

            ControlMacheo.Cod_Presupuesto = mPresupuesto
            Call ObtenerOrdenAviso(dsOrdenAviso)
            dsAvisosCaidos = ControlMacheo.BuscarAvisosCaidos
            If Not dsAvisosCaidos Is Nothing AndAlso dsAvisosCaidos.Count > 0 Then
                'Not dsAvisosCaidos.Tables(0) Is Nothing AndAlso dsAvisosCaidos.Tables(0).Rows.Count > 0 Then
                For Each aviso As AvisoCaido In dsAvisosCaidos
                    drOrdenAviso = dsOrdenAviso.Tables(0).NewRow
                    drOrdenAviso("Orden") = aviso.CodigoOrden
                    drOrdenAviso("Soporte") = aviso.DescripcionSoporte
                    drOrdenAviso("Fecha") = Convert.ToDateTime(aviso.fechaEjecucion).Date.ToString("dd/MM/yyyy")
                    Hora = New StringBuilder
                    HoraParcial = aviso.Hora
                    HoraParcial = HoraParcial.Insert(0, "0")
                    HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
                    Hora.Append(HoraParcial)
                    Hora.Append(":")
                    HoraParcial = aviso.Minuto
                    HoraParcial = HoraParcial.Insert(0, "0")
                    HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
                    Hora.Append(HoraParcial)
                    drOrdenAviso("Hora") = Hora.ToString
                    drOrdenAviso("Duracion") = aviso.Duracion
                    drOrdenAviso("Programa") = aviso.Programa
                    dsOrdenAviso.Tables(0).Rows.Add(drOrdenAviso)
                Next
            End If
            ugOrdenAviso.DataSource = dsOrdenAviso
            ugOrdenAviso.DataBind()
        End If
    End Sub

    Private Sub ObtenerOrdenAviso(ByRef pOrdenAviso As DataSet)
        pOrdenAviso = New DataSet
        Dim dtOrdenAviso As New DataTable

        dtOrdenAviso.Columns.Add("Orden", GetType(String))
        dtOrdenAviso.Columns.Add("Soporte", GetType(String))
        dtOrdenAviso.Columns.Add("Fecha", GetType(String))
        dtOrdenAviso.Columns.Add("Hora", GetType(String))
        dtOrdenAviso.Columns.Add("Duracion", GetType(String))
        dtOrdenAviso.Columns.Add("Programa", GetType(String))
        pOrdenAviso.Tables.Add(dtOrdenAviso)
    End Sub

    Private Sub RestaurarAvisosCaidos()
        Dim ControlMacheo As New Control_Macheo
        Dim Orden As Double

        If ugOrdenAviso.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un registro a restaurar.")
            Exit Sub
        End If

        For Each RowSeleccionada As UltraGridRow In ugOrdenAviso.Selected.Rows
            Orden = RowSeleccionada.Cells("Orden").Value
            Call ControlMacheo.EliminarAvisoCaido(mPresupuesto, Orden, Activo.CodUsuarioMms, Activo.IDCompaniaMMS)
        Next
        mAvisosRestaurados = True
        Call ObtenerAvisosCaidos()
    End Sub
#End Region

End Class

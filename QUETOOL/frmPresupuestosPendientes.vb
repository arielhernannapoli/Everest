Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.Printing
Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports System.Collections.Generic


Public Class frmPresupuestosPendientes
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
    Friend WithEvents pnlFiltro As System.Windows.Forms.Panel
    Friend WithEvents gbFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents pnlReporte As System.Windows.Forms.Panel
    Friend WithEvents DtpFFin As QUETOOL.dtpFecha
    Friend WithEvents lblVigenciaHasta As System.Windows.Forms.Label
    Friend WithEvents DtpFInicio As QUETOOL.dtpFecha
    Friend WithEvents lblVigenciaDesde As System.Windows.Forms.Label
    Friend WithEvents lblDesCliente As System.Windows.Forms.Label
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents txtCodCliente As QUETOOL.txtTexto
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDesProducto As System.Windows.Forms.Label
    Friend WithEvents TxtProducto As QUETOOL.txtTexto
    Friend WithEvents TxtCodProducto As QUETOOL.txtTexto
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblDesSoporte As System.Windows.Forms.Label
    Friend WithEvents TxtSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtCodSoporte As QUETOOL.txtTexto
    Friend WithEvents lblSoporte As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents cboTipoSoporte As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TxtCodTipoSoporte As QUETOOL.txtTexto
    Friend WithEvents ugPresupuestos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents CboMedio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TxtCodMedio As QUETOOL.txtTexto
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Imprimir")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExpandirContraer")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Imprimir")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExpandirContraer")
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPresupuestosPendientes))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
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
        Me.pnlFiltro = New System.Windows.Forms.Panel
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.gbFiltro = New System.Windows.Forms.GroupBox
        Me.CboMedio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.TxtCodMedio = New QUETOOL.txtTexto
        Me.lblMedio = New System.Windows.Forms.Label
        Me.cboTipoSoporte = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.TxtCodTipoSoporte = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDesSoporte = New System.Windows.Forms.Label
        Me.TxtSoporte = New QUETOOL.txtTexto
        Me.TxtCodSoporte = New QUETOOL.txtTexto
        Me.lblSoporte = New System.Windows.Forms.Label
        Me.lblDesProducto = New System.Windows.Forms.Label
        Me.TxtProducto = New QUETOOL.txtTexto
        Me.TxtCodProducto = New QUETOOL.txtTexto
        Me.lblProducto = New System.Windows.Forms.Label
        Me.lblDesCliente = New System.Windows.Forms.Label
        Me.txtCliente = New QUETOOL.txtTexto
        Me.txtCodCliente = New QUETOOL.txtTexto
        Me.lblCliente = New System.Windows.Forms.Label
        Me.DtpFFin = New QUETOOL.dtpFecha
        Me.lblVigenciaHasta = New System.Windows.Forms.Label
        Me.DtpFInicio = New QUETOOL.dtpFecha
        Me.lblVigenciaDesde = New System.Windows.Forms.Label
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.pnlReporte = New System.Windows.Forms.Panel
        Me.ugPresupuestos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.pnlFiltro.SuspendLayout()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltro.SuspendLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReporte.SuspendLayout()
        CType(Me.ugPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom)
        Me.pnlFiltro.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left)
        Me.pnlFiltro.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right)
        Me.pnlFiltro.Controls.Add(Me.gbFiltro)
        Me.pnlFiltro.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(691, 112)
        Me.pnlFiltro.TabIndex = 1
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 112)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(691, 0)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
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
        UltraToolbar1.Settings.BorderStyleDocked = Infragistics.Win.UIElementBorderStyle.None
        UltraToolbar1.Settings.GrabHandleStyle = Infragistics.Win.UltraWinToolbars.GrabHandleStyle.None
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar1.Text = "uToolbar"
        ButtonTool1.InstanceProps.IsFirstInGroup = True
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool6.SharedProps.Caption = "Limpiar"
        ButtonTool7.SharedProps.Caption = "Salir"
        ButtonTool8.SharedProps.Caption = "Consultar"
        ButtonTool8.SharedProps.ToolTipText = "Consultar Presupuestos"
        ButtonTool9.SharedProps.Caption = "Imprimir"
        ButtonTool10.SharedProps.Caption = "ExpandirContraer"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10})
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Left
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Left"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 90)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Right
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(691, 22)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Right"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 90)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.CboMedio)
        Me.gbFiltro.Controls.Add(Me.TxtCodMedio)
        Me.gbFiltro.Controls.Add(Me.lblMedio)
        Me.gbFiltro.Controls.Add(Me.cboTipoSoporte)
        Me.gbFiltro.Controls.Add(Me.TxtCodTipoSoporte)
        Me.gbFiltro.Controls.Add(Me.Label5)
        Me.gbFiltro.Controls.Add(Me.lblDesSoporte)
        Me.gbFiltro.Controls.Add(Me.TxtSoporte)
        Me.gbFiltro.Controls.Add(Me.TxtCodSoporte)
        Me.gbFiltro.Controls.Add(Me.lblSoporte)
        Me.gbFiltro.Controls.Add(Me.lblDesProducto)
        Me.gbFiltro.Controls.Add(Me.TxtProducto)
        Me.gbFiltro.Controls.Add(Me.TxtCodProducto)
        Me.gbFiltro.Controls.Add(Me.lblProducto)
        Me.gbFiltro.Controls.Add(Me.lblDesCliente)
        Me.gbFiltro.Controls.Add(Me.txtCliente)
        Me.gbFiltro.Controls.Add(Me.txtCodCliente)
        Me.gbFiltro.Controls.Add(Me.lblCliente)
        Me.gbFiltro.Controls.Add(Me.DtpFFin)
        Me.gbFiltro.Controls.Add(Me.lblVigenciaHasta)
        Me.gbFiltro.Controls.Add(Me.DtpFInicio)
        Me.gbFiltro.Controls.Add(Me.lblVigenciaDesde)
        Me.gbFiltro.Location = New System.Drawing.Point(4, 21)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(683, 88)
        Me.gbFiltro.TabIndex = 1
        Me.gbFiltro.TabStop = False
        '
        'CboMedio
        '
        Me.CboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Location = New System.Drawing.Point(446, 12)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(208, 19)
        Me.CboMedio.TabIndex = 9
        '
        'TxtCodMedio
        '
        Me.TxtCodMedio.AcceptsReturn = True
        Me.TxtCodMedio.AcceptsTab = True
        Me.TxtCodMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodMedio.ConDecimal = False
        Me.TxtCodMedio.Location = New System.Drawing.Point(404, 11)
        Me.TxtCodMedio.Maximo = 0
        Me.TxtCodMedio.MaxLength = 5
        Me.TxtCodMedio.Name = "TxtCodMedio"
        Me.TxtCodMedio.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodMedio.SoloLetra = False
        Me.TxtCodMedio.SoloNumero = True
        Me.TxtCodMedio.TabIndex = 8
        Me.TxtCodMedio.Text = ""
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(336, 15)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(35, 16)
        Me.lblMedio.TabIndex = 125
        Me.lblMedio.Text = "Medio"
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Location = New System.Drawing.Point(446, 36)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.Size = New System.Drawing.Size(208, 19)
        Me.cboTipoSoporte.TabIndex = 11
        '
        'TxtCodTipoSoporte
        '
        Me.TxtCodTipoSoporte.AcceptsReturn = True
        Me.TxtCodTipoSoporte.AcceptsTab = True
        Me.TxtCodTipoSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodTipoSoporte.ConDecimal = False
        Me.TxtCodTipoSoporte.Location = New System.Drawing.Point(404, 35)
        Me.TxtCodTipoSoporte.Maximo = 0
        Me.TxtCodTipoSoporte.MaxLength = 5
        Me.TxtCodTipoSoporte.Name = "TxtCodTipoSoporte"
        Me.TxtCodTipoSoporte.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodTipoSoporte.SoloLetra = False
        Me.TxtCodTipoSoporte.SoloNumero = True
        Me.TxtCodTipoSoporte.TabIndex = 10
        Me.TxtCodTipoSoporte.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(336, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Tipo Soporte"
        '
        'lblDesSoporte
        '
        Me.lblDesSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesSoporte.Enabled = False
        Me.lblDesSoporte.Image = CType(resources.GetObject("lblDesSoporte.Image"), System.Drawing.Image)
        Me.lblDesSoporte.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesSoporte.Location = New System.Drawing.Point(656, 59)
        Me.lblDesSoporte.Name = "lblDesSoporte"
        Me.lblDesSoporte.Size = New System.Drawing.Size(21, 21)
        Me.lblDesSoporte.TabIndex = 14
        Me.lblDesSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Location = New System.Drawing.Point(446, 59)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.ReadOnly = True
        Me.TxtSoporte.Size = New System.Drawing.Size(208, 20)
        Me.TxtSoporte.SoloLetra = False
        Me.TxtSoporte.SoloNumero = False
        Me.TxtSoporte.TabIndex = 13
        Me.TxtSoporte.TabStop = False
        Me.TxtSoporte.Text = ""
        '
        'TxtCodSoporte
        '
        Me.TxtCodSoporte.AcceptsReturn = True
        Me.TxtCodSoporte.AcceptsTab = True
        Me.TxtCodSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodSoporte.ConDecimal = False
        Me.TxtCodSoporte.Location = New System.Drawing.Point(404, 59)
        Me.TxtCodSoporte.Maximo = 0
        Me.TxtCodSoporte.MaxLength = 5
        Me.TxtCodSoporte.Name = "TxtCodSoporte"
        Me.TxtCodSoporte.ReadOnly = True
        Me.TxtCodSoporte.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodSoporte.SoloLetra = False
        Me.TxtCodSoporte.SoloNumero = True
        Me.TxtCodSoporte.TabIndex = 12
        Me.TxtCodSoporte.Text = ""
        '
        'lblSoporte
        '
        Me.lblSoporte.AutoSize = True
        Me.lblSoporte.Location = New System.Drawing.Point(336, 61)
        Me.lblSoporte.Name = "lblSoporte"
        Me.lblSoporte.Size = New System.Drawing.Size(44, 16)
        Me.lblSoporte.TabIndex = 119
        Me.lblSoporte.Text = "Soporte"
        '
        'lblDesProducto
        '
        Me.lblDesProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesProducto.Enabled = False
        Me.lblDesProducto.Image = CType(resources.GetObject("lblDesProducto.Image"), System.Drawing.Image)
        Me.lblDesProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesProducto.Location = New System.Drawing.Point(308, 59)
        Me.lblDesProducto.Name = "lblDesProducto"
        Me.lblDesProducto.Size = New System.Drawing.Size(21, 21)
        Me.lblDesProducto.TabIndex = 7
        Me.lblDesProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtProducto
        '
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.ConDecimal = False
        Me.TxtProducto.Location = New System.Drawing.Point(98, 59)
        Me.TxtProducto.Maximo = 0
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(208, 20)
        Me.TxtProducto.SoloLetra = False
        Me.TxtProducto.SoloNumero = False
        Me.TxtProducto.TabIndex = 6
        Me.TxtProducto.TabStop = False
        Me.TxtProducto.Text = ""
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.AcceptsReturn = True
        Me.TxtCodProducto.AcceptsTab = True
        Me.TxtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodProducto.ConDecimal = False
        Me.TxtCodProducto.Location = New System.Drawing.Point(56, 59)
        Me.TxtCodProducto.Maximo = 0
        Me.TxtCodProducto.MaxLength = 5
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.ReadOnly = True
        Me.TxtCodProducto.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodProducto.SoloLetra = False
        Me.TxtCodProducto.SoloNumero = True
        Me.TxtCodProducto.TabIndex = 5
        Me.TxtCodProducto.Text = ""
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(5, 61)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 16)
        Me.lblProducto.TabIndex = 115
        Me.lblProducto.Text = "Producto"
        '
        'lblDesCliente
        '
        Me.lblDesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesCliente.Image = CType(resources.GetObject("lblDesCliente.Image"), System.Drawing.Image)
        Me.lblDesCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesCliente.Location = New System.Drawing.Point(308, 35)
        Me.lblDesCliente.Name = "lblDesCliente"
        Me.lblDesCliente.Size = New System.Drawing.Size(21, 21)
        Me.lblDesCliente.TabIndex = 4
        Me.lblDesCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(98, 35)
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
        'txtCodCliente
        '
        Me.txtCodCliente.AcceptsReturn = True
        Me.txtCodCliente.AcceptsTab = True
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.ConDecimal = False
        Me.txtCodCliente.Location = New System.Drawing.Point(56, 35)
        Me.txtCodCliente.Maximo = 0
        Me.txtCodCliente.MaxLength = 5
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtCodCliente.SoloLetra = False
        Me.txtCodCliente.SoloNumero = True
        Me.txtCodCliente.TabIndex = 2
        Me.txtCodCliente.Text = ""
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(5, 37)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(40, 16)
        Me.lblCliente.TabIndex = 111
        Me.lblCliente.Text = "Cliente"
        '
        'DtpFFin
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.DtpFFin.Appearance = Appearance1
        Me.DtpFFin.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpFFin.FlatMode = True
        Me.DtpFFin.Location = New System.Drawing.Point(231, 11)
        Me.DtpFFin.Name = "DtpFFin"
        Me.DtpFFin.Size = New System.Drawing.Size(98, 21)
        Me.DtpFFin.TabIndex = 1
        Me.DtpFFin.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'lblVigenciaHasta
        '
        Me.lblVigenciaHasta.AutoSize = True
        Me.lblVigenciaHasta.Location = New System.Drawing.Point(197, 15)
        Me.lblVigenciaHasta.Name = "lblVigenciaHasta"
        Me.lblVigenciaHasta.Size = New System.Drawing.Size(37, 16)
        Me.lblVigenciaHasta.TabIndex = 108
        Me.lblVigenciaHasta.Text = "Hasta:"
        '
        'DtpFInicio
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.DtpFInicio.Appearance = Appearance2
        Me.DtpFInicio.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpFInicio.FlatMode = True
        Me.DtpFInicio.Location = New System.Drawing.Point(98, 11)
        Me.DtpFInicio.Name = "DtpFInicio"
        Me.DtpFInicio.Size = New System.Drawing.Size(98, 21)
        Me.DtpFInicio.TabIndex = 0
        Me.DtpFInicio.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'lblVigenciaDesde
        '
        Me.lblVigenciaDesde.Location = New System.Drawing.Point(5, 15)
        Me.lblVigenciaDesde.Name = "lblVigenciaDesde"
        Me.lblVigenciaDesde.Size = New System.Drawing.Size(131, 13)
        Me.lblVigenciaDesde.TabIndex = 107
        Me.lblVigenciaDesde.Text = "Ejecución Desde:"
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Top
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Top"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(691, 22)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'pnlReporte
        '
        Me.pnlReporte.Controls.Add(Me.ugPresupuestos)
        Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReporte.Location = New System.Drawing.Point(0, 112)
        Me.pnlReporte.Name = "pnlReporte"
        Me.pnlReporte.Size = New System.Drawing.Size(691, 327)
        Me.pnlReporte.TabIndex = 2
        '
        'ugPresupuestos
        '
        Appearance3.BackColor = System.Drawing.SystemColors.Window
        Appearance3.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugPresupuestos.DisplayLayout.Appearance = Appearance3
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
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand1.Override.HeaderAppearance = Appearance4
        UltraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True
        Me.ugPresupuestos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugPresupuestos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugPresupuestos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.ugPresupuestos.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugPresupuestos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.ugPresupuestos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugPresupuestos.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugPresupuestos.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.ugPresupuestos.DisplayLayout.MaxColScrollRegions = 1
        Me.ugPresupuestos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Appearance8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugPresupuestos.DisplayLayout.Override.ActiveCellAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.SystemColors.Highlight
        Appearance9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugPresupuestos.DisplayLayout.Override.ActiveRowAppearance = Appearance9
        Me.ugPresupuestos.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugPresupuestos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ugPresupuestos.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugPresupuestos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugPresupuestos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Me.ugPresupuestos.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugPresupuestos.DisplayLayout.Override.CellAppearance = Appearance11
        Me.ugPresupuestos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugPresupuestos.DisplayLayout.Override.CellPadding = 0
        Me.ugPresupuestos.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Appearance12.BackColor = System.Drawing.SystemColors.Control
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.ugPresupuestos.DisplayLayout.Override.GroupByRowAppearance = Appearance12
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugPresupuestos.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.ugPresupuestos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Me.ugPresupuestos.DisplayLayout.Override.RowAppearance = Appearance14
        Me.ugPresupuestos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.ugPresupuestos.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugPresupuestos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugPresupuestos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance15
        Me.ugPresupuestos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugPresupuestos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugPresupuestos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugPresupuestos.FlatMode = True
        Me.ugPresupuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugPresupuestos.Location = New System.Drawing.Point(0, 0)
        Me.ugPresupuestos.Name = "ugPresupuestos"
        Me.ugPresupuestos.Size = New System.Drawing.Size(691, 327)
        Me.ugPresupuestos.TabIndex = 4
        Me.ugPresupuestos.TabStop = False
        '
        'frmPresupuestosPendientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(691, 439)
        Me.Controls.Add(Me.pnlReporte)
        Me.Controls.Add(Me.pnlFiltro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPresupuestosPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuestos Pendientes"
        Me.pnlFiltro.ResumeLayout(False)
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltro.ResumeLayout(False)
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReporte.ResumeLayout(False)
        CType(Me.ugPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private Presupuestos As DataSet
    Private Productos As DataTable
    Private VigenciaDesde, VigenciaHasta As DateTime
    Private Cod_Cliente, Cod_Producto, Cod_Soporte, Id_Tipo_Soporte, Id_Medio As String
    Private mCodPresupuesto As Double
    Private PresupuestoPoint As New Point
#End Region

#Region "Variables y Propiedades Publicas"
    Public ReadOnly Property Presupuesto() As Double
        Get
            Return mCodPresupuesto
        End Get
    End Property
#End Region

#Region "Eventos"
    Private Sub frmPresupuestosPendientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BuscarMedios()
        Call BuscarProductos()
        Call LimpiarControles()
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        Dim Cliente As String = txtCliente.Text.Trim
        TxtCodProducto.Text = String.Empty
        TxtProducto.Text = String.Empty
        If Cliente <> "" Then
            TxtCodProducto.ReadOnly = False
            lblDesProducto.Enabled = True
        Else
            TxtCodProducto.ReadOnly = True
            lblDesProducto.Enabled = False
        End If
        Call CambioFiltro()
    End Sub

    Private Sub txtCodCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCliente.Validated
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoCliente <> "" Then
            Dim Usu As New Usuario
            Try
                Usu.IDPerfil_Datos = Activo.IDPerfil_Datos
                If CodigoCliente = 3 Then
                    Usu.IDPerfil_Datos = 1
                End If

                txtCliente.Text = Usu.ObtenerDescripcion(CodigoCliente)
                If txtCliente.Text = String.Empty Then
                    Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                    txtCodCliente.Text = String.Empty
                    txtCodCliente.Select()
                    Exit Sub
                Else
                    TxtCodProducto.ReadOnly = False
                    lblProducto.Enabled = True
                End If
            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                txtCliente.Text = String.Empty
                txtCodCliente.Text = String.Empty
                txtCodCliente.Select()
                Exit Sub
            End Try
        Else
            txtCliente.Text = String.Empty
        End If
    End Sub

    Private Sub lblDesCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesCliente.Click
        Dim Busqueda As New frmBuscar
        Busqueda.CargarFormulario(SeccionActiva.Cliente, txtCliente, txtCodCliente, "id_cliente", "descripcion", "Código", "Cliente")
        Busqueda.ShowDialog()
    End Sub

    Private Sub TxtProducto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProducto.TextChanged
        Call CambioFiltro()
    End Sub

    Private Sub TxtCodProducto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProducto.LostFocus
        Dim CodigoProducto As String = TxtCodProducto.Text.Trim
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoProducto <> String.Empty AndAlso CodigoCliente <> String.Empty Then
            Dim Prod As New Productos
            Dim producto As New DataTable

            Try
                Prod.Id_cliente = CodigoCliente
                producto = Prod.TraerProductos

                If producto Is Nothing OrElse producto.Rows.Count = 0 OrElse producto.Select("Id_Producto = " & CodigoProducto).Length = 0 Then
                    Mensajes.Mensaje("El Producto No Existe  o No Pertenece al Cliente Selccionado")
                    TxtCodProducto.Text = ""
                    TxtCodProducto.Select()
                    Exit Sub
                Else
                    TxtProducto.Text = producto.Select("Id_Producto = " & CodigoProducto)(0)("Descripcion")
                End If

            Catch ex As Exception
                Mensajes.Mensaje("El Producto No Existe o No Pertenece al Cliente Selccionado")
                TxtCodProducto.Text = ""
                TxtCodProducto.Select()
                Exit Sub
            End Try
        Else
            TxtProducto.Text = String.Empty
        End If
    End Sub

    Private Sub lblDesProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesProducto.Click
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoCliente <> String.Empty Then
            Dim Busqueda As New frmBuscar
            Busqueda.CargarFormulario(SeccionActiva.Producto, TxtProducto, TxtCodProducto, "id_producto", "descripcion", "Código", "Producto", CodigoCliente)
            Busqueda.ShowDialog()
        End If
    End Sub

    Private Sub TxtCodTipoSoporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodTipoSoporte.TextChanged
        TxtCodSoporte.Text = String.Empty
        TxtSoporte.Text = String.Empty
        If TxtCodTipoSoporte.Text.Trim <> String.Empty Then
            TxtCodSoporte.ReadOnly = False
            lblDesSoporte.Enabled = True
        Else
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
        End If
    End Sub

    Private Sub TxtCodTipoSoporte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodTipoSoporte.LostFocus
        Dim CodTipoSoporte As String = TxtCodTipoSoporte.Text.Trim
        If CodTipoSoporte <> String.Empty Then
            Call Combo_Position(cboTipoSoporte, "ID_TIPO_SOPORTE", CodTipoSoporte)
            If cboTipoSoporte.SelectedItem Is Nothing OrElse cboTipoSoporte.SelectedItem.DataValue Is Nothing Then
                Mensaje("El código de tipo de soporte no existe.", TipoMensaje.Informacion)
                TxtCodSoporte.ReadOnly = True
                lblDesSoporte.Enabled = False
                TxtCodTipoSoporte.Text = String.Empty
                TxtCodTipoSoporte.Focus()
            Else
                TxtCodSoporte.ReadOnly = False
                lblDesSoporte.Enabled = True
                Me.SelectNextControl(cboTipoSoporte, True, True, True, True)
            End If
        Else
            cboTipoSoporte.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboTipoSoporte_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoSoporte.SelectionChanged
        If cboTipoSoporte.SelectedItem Is Nothing OrElse cboTipoSoporte.SelectedItem.DataValue Is Nothing Then
            TxtCodTipoSoporte.Text = String.Empty
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
        Else
            TxtCodTipoSoporte.Text = cboTipoSoporte.SelectedItem.DataValue("ID_TIPO_SOPORTE")
            TxtCodSoporte.ReadOnly = False
            lblDesSoporte.Enabled = True
        End If
        Call CambioFiltro()
    End Sub

    Private Sub TxtCodMedio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodMedio.TextChanged
        TxtCodTipoSoporte.Text = String.Empty
        cboTipoSoporte.Items.Clear()
        If TxtCodMedio.Text.Trim <> String.Empty Then
            TxtCodTipoSoporte.ReadOnly = False
            cboTipoSoporte.Enabled = True
        Else
            TxtCodTipoSoporte.ReadOnly = True
            cboTipoSoporte.Enabled = False
        End If
    End Sub

    Private Sub TxtCodMedio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodMedio.LostFocus
        Dim CodMedio As String = TxtCodMedio.Text.Trim
        If CodMedio <> String.Empty Then
            Call Combo_Position(CboMedio, "Id_Medio", CodMedio)
            If CboMedio.SelectedItem Is Nothing OrElse CboMedio.SelectedItem.DataValue Is Nothing Then
                Mensaje("El código de medio no existe.", TipoMensaje.Informacion)
                TxtCodTipoSoporte.ReadOnly = True
                cboTipoSoporte.Enabled = False
                TxtCodMedio.Text = String.Empty
                TxtCodMedio.Focus()
            Else
                TxtCodTipoSoporte.ReadOnly = False
                cboTipoSoporte.Enabled = True
                Call BuscarTipoSoportes()
                Me.SelectNextControl(CboMedio, True, True, True, True)
            End If
        Else
            CboMedio.SelectedIndex = 0
        End If
    End Sub

    Private Sub CboMedio_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.SelectionChanged
        If CboMedio.SelectedItem Is Nothing OrElse CboMedio.SelectedItem.DataValue Is Nothing Then
            TxtCodMedio.Text = String.Empty
            TxtCodTipoSoporte.ReadOnly = True
            cboTipoSoporte.Enabled = False
        Else
            TxtCodMedio.Text = CboMedio.SelectedItem.DataValue("Id_Medio")
            TxtCodTipoSoporte.ReadOnly = False
            cboTipoSoporte.Enabled = True
            Call BuscarTipoSoportes()
        End If
    End Sub

    Private Sub TxtSoporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSoporte.TextChanged
        Call CambioFiltro()
    End Sub

    Private Sub TxtCodSoporte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodSoporte.LostFocus
        Dim CodigoSoporte As String = TxtCodSoporte.Text.Trim
        Dim CodigoMedio As String = TxtCodMedio.Text.Trim
        Dim CodigoTipoSoporte As String = TxtCodTipoSoporte.Text.Trim
        If CodigoSoporte <> String.Empty AndAlso CodigoTipoSoporte <> String.Empty AndAlso CodigoMedio <> String.Empty Then
            Dim Sop As New Soportes
            Try

                Sop.Id_medio = CodigoMedio
                Sop.Id_tipo_soporte = CodigoTipoSoporte
                Sop.Id_soporte = CodigoSoporte
                Dim dtSoporte As DataTable = Sop.ObtenerSoportesTipoSoporteID

                If dtSoporte Is Nothing OrElse dtSoporte.Rows.Count <= 0 Then
                    Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                    TxtCodSoporte.Text = String.Empty
                    TxtCodSoporte.Select()
                    Exit Sub
                End If
                TxtSoporte.Text = dtSoporte.Rows(0)("Descripcion")
            Catch ex As Exception
                Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                TxtSoporte.Text = String.Empty
                TxtCodSoporte.Text = ""
                TxtCodSoporte.Select()
                Exit Sub
            End Try
        Else
            TxtSoporte.Text = String.Empty
        End If
    End Sub

    Private Sub lblDesSoporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesSoporte.Click
        Dim CodigoMedio As String = TxtCodMedio.Text.Trim
        Dim CodigoTipoSoporte As String = TxtCodTipoSoporte.Text.Trim
        If CodigoMedio <> String.Empty AndAlso CodigoTipoSoporte <> String.Empty Then
            Dim Busqueda As New frmBuscar
            Busqueda.CargarFormulario(SeccionActiva.Soporte, TxtSoporte, TxtCodSoporte, "id_soporte", "descripcion", "Código", "Soporte", CodigoMedio, CodigoTipoSoporte)
            Busqueda.ShowDialog()
        End If
    End Sub

    Private Sub DtpFFin_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFFin.AfterExitEditMode
        Call CambioFiltro()
    End Sub

    Private Sub DtpFInicio_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFInicio.AfterExitEditMode
        Call CambioFiltro()
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Consultar"
                Call ConsultarPresupuestos()
            Case "Limpiar"
                Call LimpiarControles()
            Case "Imprimir"
                Call Imprimir()
            Case "ExpandirContraer"
                Call ExpandirContraer()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub ugPresupuestos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugPresupuestos.DoubleClick
        Dim aUIElement As Infragistics.Win.UIElement
        Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
        Dim GridRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        aUIElement = ugPresupuestos.DisplayLayout.UIElement.ElementFromPoint(New Point(PresupuestoPoint.X, PresupuestoPoint.Y))
        ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

        If ColumnHeader Is Nothing Then
            GridRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            If Not GridRow Is Nothing AndAlso GridRow.Band.Index = 0 Then
                mCodPresupuesto = GridRow.Cells("Cod_Presupuesto").Value
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ugPresupuestos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugPresupuestos.MouseDown
        PresupuestoPoint.X = e.X
        PresupuestoPoint.Y = e.Y
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub Combo_Load(ByVal pCombo As UltraComboEditor, ByVal pDataTable As DataTable, ByVal pDisplay As String, ByVal pObligatorio As Boolean)
        pCombo.Items.Clear()
        pCombo.Enabled = True
        If pDataTable Is Nothing OrElse pDataTable.Rows.Count = 0 Then
            pCombo.Enabled = False
        Else
            Combo_Populate(pCombo, pDataTable, pDisplay, Not pObligatorio)
        End If
    End Sub

    Private Sub Combo_Populate(ByRef pCombo As UltraComboEditor, ByVal pobjTable As DataTable, ByVal pstrDisplayText As String, Optional ByVal pblnEsSeleccioneOpcion As Boolean = True)
        Dim objItem As ValueListItem
        Dim objRow As DataRow

        If pblnEsSeleccioneOpcion = True Then
            objItem = New ValueListItem
            objItem.DisplayText = ""
            objItem.DataValue = Nothing
            pCombo.Items.Add(objItem)
        End If

        For Each objRow In pobjTable.Rows
            objItem = New ValueListItem
            objItem.DataValue = objRow
            objItem.DisplayText = objRow(pstrDisplayText)
            pCombo.Items.Add(objItem)
        Next

        If pCombo.Items.Count <> 0 Then
            pCombo.SelectedIndex = 0
        End If
    End Sub

    Private Sub Combo_Position(ByVal pCombo As UltraComboEditor, ByVal pColumnName As String, ByVal pValue As String)
        For ItemCount As Integer = 0 To pCombo.Items.Count - 1
            If Not pCombo.Items(ItemCount).ValueList.ValueListItems(ItemCount).DataValue Is Nothing AndAlso pCombo.Items(ItemCount).ValueList.ValueListItems(ItemCount).DataValue(pColumnName) = pValue Then
                pCombo.SelectedIndex = ItemCount
                Return
            End If
        Next
        pCombo.SelectedIndex = 0
    End Sub

    Private Sub BuscarMedios()
        Dim Medios As New Soportes
        Dim dtMedios As DataTable

        dtMedios = Medios.ObtenerMediosActivos
        Call Combo_Load(CboMedio, dtMedios, "Descripcion", False)
    End Sub

    Private Sub BuscarTipoSoportes()
        Dim TiposSoportes As New Tipos_soporte
        Dim dtTipoSoporte As DataTable
        Dim Id_Medio As String = TxtCodMedio.Text.Trim

        If Id_Medio <> String.Empty Then
            TiposSoportes.Id_medio = Id_Medio
            dtTipoSoporte = TiposSoportes.TraerTipoSoporte
            Call Combo_Load(cboTipoSoporte, dtTipoSoporte, "Descripcion", False)
        Else
            cboTipoSoporte.Items.Clear()
            cboTipoSoporte.Enabled = False
            TxtCodTipoSoporte.Text = String.Empty
            TxtCodTipoSoporte.Enabled = False
        End If
    End Sub

    Private Sub BuscarProductos()
        Dim Prod As New Productos
        Productos = Prod.TraerTodosProductos
    End Sub

    Private Sub LimpiarControles()
        DtpFInicio.Value = Now.AddDays(-15)
        DtpFFin.Value = Now

        txtCodCliente.Text = String.Empty
        txtCliente.Text = String.Empty
        TxtCodProducto.Text = String.Empty
        TxtProducto.Text = String.Empty
        TxtCodMedio.Text = String.Empty
        CboMedio.SelectedIndex = 0
        TxtCodTipoSoporte.Text = String.Empty
        cboTipoSoporte.Items.Clear()
        TxtCodSoporte.Text = String.Empty
        TxtSoporte.Text = String.Empty

        TxtCodTipoSoporte.ReadOnly = True
        cboTipoSoporte.Enabled = False
        TxtCodProducto.ReadOnly = True
        lblDesProducto.Enabled = False
        TxtCodSoporte.ReadOnly = True
        lblDesSoporte.Enabled = False

        Call LimpiarPresupuestos()
    End Sub

    Private Sub LimpiarPresupuestos()
        ugPresupuestos.DataSource = Nothing
        ugPresupuestos.DataBind()

        UltraToolbarsManager1.Toolbars(0).Tools("ExpandirContraer").SharedProps.Caption = "Expandir"
    End Sub

    Private Sub ConsultarPresupuestos()
        If Not ValidarConsulta() Then Exit Sub
        Dim ControlMacheo As New Control_Macheo
        Dim Filtro As New StringBuilder
        Dim PresupuestosPendientes As New DataSet
        Dim drPresPendienteCabcera, drPresPendienteDetalle As DataRow
        Dim ExisteCabecera, ExisteDetalle As Boolean

        If VigenciaDesde.Date <> Convert.ToDateTime(DtpFInicio.Value).Date OrElse VigenciaHasta.Date <> Convert.ToDateTime(DtpFFin.Value).Date Then
            VigenciaDesde = Convert.ToDateTime(DtpFInicio.Value).Date
            VigenciaHasta = Convert.ToDateTime(DtpFFin.Value).Date
            Presupuestos = ObtenerPresupuestosPendientes()
        End If

        Cod_Cliente = txtCodCliente.Text.Trim
        Cod_Producto = TxtCodProducto.Text.Trim
        Id_Medio = TxtCodMedio.Text.Trim
        Id_Tipo_Soporte = TxtCodTipoSoporte.Text.Trim
        Cod_Soporte = TxtCodSoporte.Text.Trim

        If Cod_Cliente <> String.Empty Then
            Call ArmarFiltro(Filtro, "cod_cliente", Cod_Cliente)
        End If
        If Cod_Producto <> String.Empty Then
            Call ArmarFiltro(Filtro, "cod_producto", Cod_Producto)
        End If
        If Id_Medio <> String.Empty Then
            Call ArmarFiltro(Filtro, "cod_medio", Id_Medio)
        End If
        If Id_Tipo_Soporte <> String.Empty Then
            Call ArmarFiltro(Filtro, "id_tipo_soporte", Id_Tipo_Soporte)
        End If
        If Cod_Soporte <> String.Empty Then
            Call ArmarFiltro(Filtro, "cod_soporte", Cod_Soporte)
        End If

        ugPresupuestos.DataSource = PresupuestosPendientes
        ugPresupuestos.DataBind()

        Dim ArrayCabecera As New SortedList
        Dim ArrayDetalle As New SortedList
        Dim ClaveCompuesta As StringBuilder

        If Not Presupuestos Is Nothing AndAlso Not Presupuestos.Tables(0) Is Nothing AndAlso Presupuestos.Tables(0).Select(Filtro.ToString).Length > 0 Then
            Call ObtenerEstructuraPresupuesto(PresupuestosPendientes)
            For Each Presupuesto As DataRow In Presupuestos.Tables(0).Select(Filtro.ToString, "cod_cliente,cod_producto,cod_presupuesto,cod_soporte")
                ClaveCompuesta = New StringBuilder
                ClaveCompuesta.Append(Presupuesto("Cod_Cliente"))
                ClaveCompuesta.Append("-")
                ClaveCompuesta.Append(Presupuesto("Cod_Producto"))
                ClaveCompuesta.Append("-")
                ClaveCompuesta.Append(Presupuesto("Cod_Presupuesto"))
                If Not ArrayCabecera.Contains(ClaveCompuesta.ToString) Then
                    ArrayCabecera.Add(ClaveCompuesta.ToString, Presupuesto)
                End If

                ClaveCompuesta = New StringBuilder
                ClaveCompuesta.Append(Presupuesto("Cod_Presupuesto"))
                ClaveCompuesta.Append("-")
                ClaveCompuesta.Append(Presupuesto("Cod_Soporte"))
                If Not ArrayDetalle.ContainsKey(ClaveCompuesta.ToString) Then
                    ArrayDetalle.Add(ClaveCompuesta.ToString, Presupuesto)
                End If
            Next
            Dim PresupuestoCabecera As DataRow
            Dim PresupuestoDetalle As DataRow
            Dim NuevoFiltro As StringBuilder
            For Index As Integer = 0 To ArrayCabecera.Count - 1
                PresupuestoCabecera = CType(ArrayCabecera.GetValueList.Item(Index), DataRow)
                drPresPendienteCabcera = PresupuestosPendientes.Tables("Cabecera").NewRow

                NuevoFiltro = New StringBuilder
                If Filtro.ToString <> String.Empty Then
                    NuevoFiltro.Append(Filtro.ToString)
                    NuevoFiltro.Append(" and ")
                End If
                NuevoFiltro.Append("Cod_Presupuesto = ")
                NuevoFiltro.Append(PresupuestoCabecera("Cod_Presupuesto"))

                drPresPendienteCabcera("Cod_Presupuesto") = PresupuestoCabecera("Cod_Presupuesto")
                drPresPendienteCabcera("Cod_Cliente") = PresupuestoCabecera("Cod_Cliente")
                drPresPendienteCabcera("Des_Cliente") = PresupuestoCabecera("Des_Cliente")
                drPresPendienteCabcera("Cod_Producto") = PresupuestoCabecera("Cod_Producto")
                drPresPendienteCabcera("Des_Producto") = ObtenerProducto(PresupuestoCabecera("Cod_Cliente"), PresupuestoCabecera("Cod_Producto"))
                drPresPendienteCabcera("Cantidad") = Presupuestos.Tables(0).Select(NuevoFiltro.ToString).Length

                PresupuestosPendientes.Tables("Cabecera").Rows.Add(drPresPendienteCabcera)
            Next
            For Index As Integer = 0 To ArrayDetalle.Count - 1
                PresupuestoDetalle = CType(ArrayDetalle.GetValueList.Item(Index), DataRow)
                drPresPendienteDetalle = PresupuestosPendientes.Tables("Detalle").NewRow

                NuevoFiltro = New StringBuilder
                If Filtro.ToString <> String.Empty Then
                    NuevoFiltro.Append(Filtro.ToString)
                    NuevoFiltro.Append(" and ")
                End If
                NuevoFiltro.Append("Cod_Presupuesto = ")
                NuevoFiltro.Append(PresupuestoDetalle("Cod_Presupuesto"))
                NuevoFiltro.Append(" and Cod_Soporte = ")
                NuevoFiltro.Append(PresupuestoDetalle("Cod_Soporte"))

                drPresPendienteDetalle("Cod_Presupuesto") = PresupuestoDetalle("Cod_Presupuesto")
                drPresPendienteDetalle("Cod_Cliente") = PresupuestoDetalle("Cod_Cliente")
                drPresPendienteDetalle("Cod_Producto") = PresupuestoDetalle("Cod_Producto")
                drPresPendienteDetalle("Cod_Soporte") = PresupuestoDetalle("Cod_Soporte")
                drPresPendienteDetalle("Des_Soporte") = PresupuestoDetalle("Des_Soporte")
                drPresPendienteDetalle("Cantidad") = Presupuestos.Tables(0).Select(NuevoFiltro.ToString).Length

                PresupuestosPendientes.Tables("Detalle").Rows.Add(drPresPendienteDetalle)
            Next

            If PresupuestosPendientes.Tables("Cabecera").Rows.Count > 0 Then
                Call AplicarApariencia()
            End If
        End If
        If ugPresupuestos.Rows.Count <= 0 Then
            Mensaje("No Existen presupuestos pendientes para el filtro especificado.")
        End If
    End Sub

    Private Sub ArmarFiltro(ByRef pFiltro As StringBuilder, ByVal pCampo As String, ByVal pValor As String)
        If pFiltro.ToString <> String.Empty Then
            pFiltro.Append(" and ")
        End If
        pFiltro.Append(pCampo)
        pFiltro.Append(" = ")
        pFiltro.Append(pValor)
    End Sub

    Private Sub ObtenerEstructuraPresupuesto(ByRef PresupuestosPendientes As DataSet)
        Dim PresupuestoCabecera As New DataTable("Cabecera")
        Dim PresupuestoDetalle As New DataTable("Detalle")
        Dim ColumnasCabecera(2) As DataColumn
        Dim ColumnasDetalle(2) As DataColumn


        PresupuestoCabecera.Columns.Add("Cod_Presupuesto")
        PresupuestoCabecera.Columns.Add("Cod_Cliente")
        PresupuestoCabecera.Columns.Add("Des_Cliente")
        PresupuestoCabecera.Columns.Add("Cod_Producto")
        PresupuestoCabecera.Columns.Add("Des_Producto")
        PresupuestoCabecera.Columns.Add("Cantidad")

        PresupuestoDetalle.Columns.Add("Cod_Presupuesto")
        PresupuestoDetalle.Columns.Add("Cod_Cliente")
        PresupuestoDetalle.Columns.Add("Cod_Producto")
        PresupuestoDetalle.Columns.Add("Cod_Soporte")
        PresupuestoDetalle.Columns.Add("Des_Soporte")
        PresupuestoDetalle.Columns.Add("Cantidad")

        ColumnasCabecera.SetValue(PresupuestoCabecera.Columns("Cod_Presupuesto"), 0)
        ColumnasCabecera.SetValue(PresupuestoCabecera.Columns("Cod_Cliente"), 1)
        ColumnasCabecera.SetValue(PresupuestoCabecera.Columns("Cod_Producto"), 2)

        ColumnasDetalle.SetValue(PresupuestoDetalle.Columns("Cod_Presupuesto"), 0)
        ColumnasDetalle.SetValue(PresupuestoDetalle.Columns("Cod_Cliente"), 1)
        ColumnasDetalle.SetValue(PresupuestoDetalle.Columns("Cod_Producto"), 2)

        PresupuestosPendientes.Tables.Add(PresupuestoCabecera)
        PresupuestosPendientes.Tables.Add(PresupuestoDetalle)
        PresupuestosPendientes.Relations.Add("RelacionPrincipal", ColumnasCabecera, ColumnasDetalle)
    End Sub

    Private Sub AplicarApariencia()
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cod_Cliente").Hidden = True
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cod_Producto").Hidden = True
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cod_Presupuesto").Header.Caption = "Presupuesto"
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Des_Cliente").Header.Caption = "Cliente"
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Des_Producto").Header.Caption = "Producto"
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cod_Presupuesto").Header.Appearance.TextHAlign = HAlign.Center
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Des_Cliente").Header.Appearance.TextHAlign = HAlign.Center
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Des_Producto").Header.Appearance.TextHAlign = HAlign.Center
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cantidad").Header.Appearance.TextHAlign = HAlign.Center
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cod_Presupuesto").CellAppearance.TextHAlign = HAlign.Right
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cod_Presupuesto").Width = 80
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Des_Cliente").Width = 250
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Des_Producto").Width = 250
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Cantidad").Width = 74
        ugPresupuestos.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        ugPresupuestos.DisplayLayout.Bands(0).Columns("Des_Cliente").AllowRowFiltering = DefaultableBoolean.True
        ugPresupuestos.DisplayLayout.Bands(0).Override.CellClickAction = UltraWinGrid.CellClickAction.RowSelect
        ugPresupuestos.DisplayLayout.Bands(0).Override.AllowDelete = DefaultableBoolean.False

        ugPresupuestos.DisplayLayout.Bands(1).Columns("Cod_Presupuesto").Hidden = True
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Cod_Cliente").Hidden = True
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Cod_Producto").Hidden = True
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Cod_Soporte").Hidden = True
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Des_Soporte").Header.Caption = "Soporte"
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Des_Soporte").Header.Appearance.TextHAlign = HAlign.Center
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Cantidad").Header.Appearance.TextHAlign = HAlign.Center
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Des_Soporte").Width = 561
        ugPresupuestos.DisplayLayout.Bands(1).Columns("Cantidad").Width = 74
        ugPresupuestos.DisplayLayout.Bands(1).Override.CellClickAction = UltraWinGrid.CellClickAction.RowSelect
        ugPresupuestos.DisplayLayout.Bands(1).Override.AllowDelete = DefaultableBoolean.False
    End Sub

    Private Function ValidarConsulta() As Boolean
        If DtpFInicio.Value Is Nothing Then
            Mensaje("Debe ingresar fecha de ejecución desde.")
            Return False
        End If
        If DtpFFin.Value Is Nothing Then
            Mensaje("Debe ingresar fecha de ejecución hasta.")
            Return False
        End If
        If Convert.ToDateTime(DtpFInicio.Value).Date > Convert.ToDateTime(DtpFFin.Value).Date Then
            Mensaje("La fecha de ejecución desde debe ser menor o igual a la fecha de ejecución hasta.")
            Return False
        End If
        Return True
    End Function

    Private Sub CambioFiltro()
        Dim VigenciaDesdeActual, VigenciaHastaActual As DateTime
        Dim Cod_ClienteActual, Cod_ProductoActual, Cod_SoporteActual, Id_Tipo_SoporteActual, Id_Medio_Actual As String

        VigenciaDesdeActual = DtpFInicio.Value
        VigenciaHastaActual = DtpFFin.Value
        Cod_ClienteActual = txtCodCliente.Text.Trim
        Cod_ProductoActual = TxtCodProducto.Text.Trim
        Id_Medio_Actual = TxtCodMedio.Text.Trim
        Id_Tipo_SoporteActual = TxtCodTipoSoporte.Text.Trim
        Cod_SoporteActual = TxtCodSoporte.Text.Trim

        If VigenciaDesde.Date <> VigenciaDesdeActual.Date OrElse _
           VigenciaHasta.Date <> VigenciaHastaActual.Date OrElse _
           Cod_Cliente <> Cod_ClienteActual OrElse _
           Cod_Producto <> Cod_ProductoActual OrElse _
           Id_Medio <> Id_Medio_Actual OrElse _
           Id_Tipo_Soporte <> Id_Tipo_SoporteActual OrElse _
           Cod_Soporte <> Cod_SoporteActual Then
            Call LimpiarPresupuestos()
        End If
    End Sub

    Private Function ObtenerProducto(ByVal pCod_Cliente As Integer, ByVal pCod_Producto As Integer) As String
        Dim Filtro As New StringBuilder
        Filtro.Append("Id_Cliente = ")
        Filtro.Append(pCod_Cliente)
        Filtro.Append(" and Id_Producto = ")
        Filtro.Append(pCod_Producto)
        If Not Productos Is Nothing AndAlso Productos.Rows.Count > 0 Then
            For Each Prod As DataRow In Productos.Select(Filtro.ToString)
                Return Prod("Descripcion")
            Next
        End If
        Return String.Empty
    End Function

    Private Sub Imprimir()
        If ugPresupuestos.Rows.Count > 0 Then
            Dim PrintDocument As New UltraGridPrintDocument
            Dim PrintPreview As New UltraPrintPreviewDialog

            With PrintDocument
                .Grid = ugPresupuestos
                .Grid.Rows.ExpandAll(True)

                .Header.Appearance.ImageHAlign = HAlign.Left
                .Header.Appearance.ImageVAlign = VAlign.Default
                .Header.Appearance.FontData.SizeInPoints = 9
                .Header.BorderStyle = UIElementBorderStyle.None

                .Footer.TextRight = "Pagina <#>."
                .Footer.Height = 100
                .Footer.Appearance.FontData.SizeInPoints = 9
                .Footer.Appearance.TextHAlign = HAlign.Left
                .Footer.BorderStyle = UIElementBorderStyle.None
                .Footer.Appearance.FontData.Italic = DefaultableBoolean.True

                .PageBody.BorderStyle = UIElementBorderStyle.None
                .Page.BorderStyle = UIElementBorderStyle.None

                .DefaultPageSettings.Landscape = False
                .DefaultPageSettings.Margins.Bottom = 10
                .DefaultPageSettings.Margins.Left = 10
                .DefaultPageSettings.Margins.Right = 60
                .DefaultPageSettings.Margins.Top = 10

                .DocumentName = "PRESUPUESTOSPENDIENTES"
            End With

            With PrintPreview
                .Document = PrintDocument
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
            PrintDocument.Grid.Rows.CollapseAll(True)
        Else
            Mensaje("No Existen presupuestos pendientes para imprimir.")
        End If
    End Sub

    Private Sub ExpandirContraer()
        If ugPresupuestos.Rows.Count > 0 Then
            If UltraToolbarsManager1.Toolbars(0).Tools("ExpandirContraer").SharedProps.Caption = "Expandir" Then
                UltraToolbarsManager1.Toolbars(0).Tools("ExpandirContraer").SharedProps.Caption = "Contraer"
                ugPresupuestos.Rows.ExpandAll(True)
            Else
                UltraToolbarsManager1.Toolbars(0).Tools("ExpandirContraer").SharedProps.Caption = "Expandir"
                ugPresupuestos.Rows.CollapseAll(True)
            End If
        Else
            Mensaje("No Existen presupuestos pendientes para expandir.")
        End If
    End Sub

    Private Function ObtenerPresupuestosPendientes() As DataSet
        Dim ControlMatcheo As New Control_Macheo
        Dim dsPresupuestos As New DataSet
        Dim dtPresupuesto As New DataTable
        Dim lAvisos As New List(Of AvisoPresupuesto)
        Dim dr As DataRow

        ArmarEstructuraPresupuestosPendientes(dtPresupuesto)

        lAvisos = ControlMatcheo.BuscarPresupuestosPendiente(Activo.IDCompaniaMMS, VigenciaDesde, VigenciaHasta)

        For Each aviso As AvisoPresupuesto In lAvisos
            dr = dtPresupuesto.NewRow

            dr("COD_CLIENTE") = aviso.CodigoCliente
            dr("COD_PRESUPUESTO") = aviso.CodigoPresupuesto
            dr("DES_CLIENTE") = aviso.DescripcionCliente
            dr("COD_PRODUCTO") = aviso.CodigoProducto
            dr("COD_SOPORTE") = aviso.CodigoSoporte
            dr("DES_SOPORTE") = aviso.DescripcionSoporte
            If Not aviso.CodigoTipoSoporte Is Nothing Then
                dr("ID_TIPO_SOPORTE") = aviso.CodigoTipoSoporte
            Else
                dr("ID_TIPO_SOPORTE") = DBNull.Value
            End If
            dr("COD_MEDIO") = aviso.CodigoMedio

            dtPresupuesto.Rows.Add(dr)
        Next

        dsPresupuestos.Tables.Add(dtPresupuesto)

        Return dsPresupuestos
    End Function

    Private Sub ArmarEstructuraPresupuestosPendientes(ByRef dtPresupuestos As DataTable)

        dtPresupuestos.Columns.Add("COD_CLIENTE", GetType(Integer))
        dtPresupuestos.Columns.Add("COD_PRESUPUESTO", GetType(Integer))
        dtPresupuestos.Columns.Add("DES_CLIENTE", GetType(String))
        dtPresupuestos.Columns.Add("COD_PRODUCTO", GetType(Integer))
        dtPresupuestos.Columns.Add("COD_SOPORTE", GetType(Integer))
        dtPresupuestos.Columns.Add("DES_SOPORTE", GetType(String))
        dtPresupuestos.Columns.Add("ID_TIPO_SOPORTE", GetType(Integer))
        dtPresupuestos.Columns.Add("COD_MEDIO", GetType(Integer))

        dtPresupuestos.AcceptChanges()

    End Sub

#End Region

End Class


Imports Infragistics.Win.UltraWinTree
Imports System.Text
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win
Imports QUETOOL
Imports Framework.Mensajes

Public Class frmActualizarTema
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
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmConfirmacionAvisos_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents uTree As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents cboTemaOrigen As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTemaDestino As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents DtpFFin As QUETOOL.dtpFecha
    Friend WithEvents lblVigenciaHasta As System.Windows.Forms.Label
    Friend WithEvents DtpFInicio As QUETOOL.dtpFecha
    Friend WithEvents lblVigenciaDesde As System.Windows.Forms.Label
    Friend WithEvents lblTemaOrigen As System.Windows.Forms.Label
    Friend WithEvents lblTemaDestino As System.Windows.Forms.Label
    Friend WithEvents gbTemaOrigen As System.Windows.Forms.GroupBox
    Friend WithEvents lblProductoOrigen As System.Windows.Forms.Label
    Friend WithEvents lblMaterialOrigen As System.Windows.Forms.Label
    Friend WithEvents lblDuracionOrigen As System.Windows.Forms.Label
    Friend WithEvents txtProductoOrigen As QUETOOL.txtTexto
    Friend WithEvents txtMaterialOrigen As QUETOOL.txtTexto
    Friend WithEvents txtDuracionOrigen As QUETOOL.txtTexto
    Friend WithEvents gbTemaDestino As System.Windows.Forms.GroupBox
    Friend WithEvents txtDuracionDestino As QUETOOL.txtTexto
    Friend WithEvents txtMaterialDestino As QUETOOL.txtTexto
    Friend WithEvents txtProductoDestino As QUETOOL.txtTexto
    Friend WithEvents lblDuracionDestino As System.Windows.Forms.Label
    Friend WithEvents lblMaterialDestino As System.Windows.Forms.Label
    Friend WithEvents lblProductoDestino As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarPantalla")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reemplazar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Expandir")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Seleccionar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reemplazar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Expandir")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Seleccionar")
        Dim UltraTreeColumnSet1 As Infragistics.Win.UltraWinTree.UltraTreeColumnSet = New Infragistics.Win.UltraWinTree.UltraTreeColumnSet
        Dim Override1 As Infragistics.Win.UltraWinTree.Override = New Infragistics.Win.UltraWinTree.Override
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.uTree = New Infragistics.Win.UltraWinTree.UltraTree
        Me.cboTemaOrigen = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cboTemaDestino = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.DtpFFin = New QUETOOL.dtpFecha
        Me.lblVigenciaHasta = New System.Windows.Forms.Label
        Me.DtpFInicio = New QUETOOL.dtpFecha
        Me.lblVigenciaDesde = New System.Windows.Forms.Label
        Me.lblTemaOrigen = New System.Windows.Forms.Label
        Me.lblTemaDestino = New System.Windows.Forms.Label
        Me.gbTemaOrigen = New System.Windows.Forms.GroupBox
        Me.txtDuracionOrigen = New QUETOOL.txtTexto
        Me.txtMaterialOrigen = New QUETOOL.txtTexto
        Me.txtProductoOrigen = New QUETOOL.txtTexto
        Me.lblDuracionOrigen = New System.Windows.Forms.Label
        Me.lblMaterialOrigen = New System.Windows.Forms.Label
        Me.lblProductoOrigen = New System.Windows.Forms.Label
        Me.gbTemaDestino = New System.Windows.Forms.GroupBox
        Me.txtDuracionDestino = New QUETOOL.txtTexto
        Me.txtMaterialDestino = New QUETOOL.txtTexto
        Me.txtProductoDestino = New QUETOOL.txtTexto
        Me.lblDuracionDestino = New System.Windows.Forms.Label
        Me.lblMaterialDestino = New System.Windows.Forms.Label
        Me.lblProductoDestino = New System.Windows.Forms.Label
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uTree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTemaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTemaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTemaOrigen.SuspendLayout()
        Me.gbTemaDestino.SuspendLayout()
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
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar1.Text = "uToolbarPantalla"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool6.SharedProps.Caption = "Salir"
        ButtonTool7.SharedProps.Caption = "Reemplazar"
        ButtonTool8.SharedProps.Caption = "Limpiar"
        ButtonTool9.SharedProps.Caption = "Expandir"
        ButtonTool10.SharedProps.Caption = "Seleccionar"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10})
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Top
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Top"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(788, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 287)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(788, 0)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Left
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Left"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 265)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Right
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(788, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Right"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 265)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'uTree
        '
        Me.uTree.ColumnSettings.RootColumnSet = UltraTreeColumnSet1
        Me.uTree.FlatMode = True
        Me.uTree.Location = New System.Drawing.Point(8, 24)
        Me.uTree.Name = "uTree"
        Override1.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
        Me.uTree.Override = Override1
        Me.uTree.Size = New System.Drawing.Size(420, 256)
        Me.uTree.TabIndex = 25
        Me.uTree.TabStop = False
        '
        'cboTemaOrigen
        '
        Me.cboTemaOrigen.AutoSize = True
        Me.cboTemaOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTemaOrigen.FlatMode = True
        Me.cboTemaOrigen.Location = New System.Drawing.Point(550, 50)
        Me.cboTemaOrigen.Name = "cboTemaOrigen"
        Me.cboTemaOrigen.Size = New System.Drawing.Size(56, 19)
        Me.cboTemaOrigen.TabIndex = 2
        '
        'cboTemaDestino
        '
        Me.cboTemaDestino.AutoSize = True
        Me.cboTemaDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTemaDestino.FlatMode = True
        Me.cboTemaDestino.Location = New System.Drawing.Point(721, 50)
        Me.cboTemaDestino.Name = "cboTemaDestino"
        Me.cboTemaDestino.Size = New System.Drawing.Size(56, 19)
        Me.cboTemaDestino.TabIndex = 3
        '
        'DtpFFin
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.DtpFFin.Appearance = Appearance1
        Me.DtpFFin.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpFFin.FlatMode = True
        Me.DtpFFin.Location = New System.Drawing.Point(683, 24)
        Me.DtpFFin.Name = "DtpFFin"
        Me.DtpFFin.Size = New System.Drawing.Size(94, 21)
        Me.DtpFFin.TabIndex = 1
        Me.DtpFFin.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'lblVigenciaHasta
        '
        Me.lblVigenciaHasta.Location = New System.Drawing.Point(613, 28)
        Me.lblVigenciaHasta.Name = "lblVigenciaHasta"
        Me.lblVigenciaHasta.Size = New System.Drawing.Size(72, 13)
        Me.lblVigenciaHasta.TabIndex = 108
        Me.lblVigenciaHasta.Text = "Fecha Hasta:"
        '
        'DtpFInicio
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.DtpFInicio.Appearance = Appearance2
        Me.DtpFInicio.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpFInicio.FlatMode = True
        Me.DtpFInicio.Location = New System.Drawing.Point(512, 24)
        Me.DtpFInicio.Name = "DtpFInicio"
        Me.DtpFInicio.Size = New System.Drawing.Size(94, 21)
        Me.DtpFInicio.TabIndex = 0
        Me.DtpFInicio.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'lblVigenciaDesde
        '
        Me.lblVigenciaDesde.Location = New System.Drawing.Point(440, 28)
        Me.lblVigenciaDesde.Name = "lblVigenciaDesde"
        Me.lblVigenciaDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblVigenciaDesde.TabIndex = 107
        Me.lblVigenciaDesde.Text = "Fecha Desde:"
        '
        'lblTemaOrigen
        '
        Me.lblTemaOrigen.Location = New System.Drawing.Point(440, 53)
        Me.lblTemaOrigen.Name = "lblTemaOrigen"
        Me.lblTemaOrigen.Size = New System.Drawing.Size(112, 13)
        Me.lblTemaOrigen.TabIndex = 109
        Me.lblTemaOrigen.Text = "Tema a Reemplazar:"
        '
        'lblTemaDestino
        '
        Me.lblTemaDestino.Location = New System.Drawing.Point(613, 53)
        Me.lblTemaDestino.Name = "lblTemaDestino"
        Me.lblTemaDestino.Size = New System.Drawing.Size(112, 13)
        Me.lblTemaDestino.TabIndex = 111
        Me.lblTemaDestino.Text = "Tema Reemplazante:"
        '
        'gbTemaOrigen
        '
        Me.gbTemaOrigen.Controls.Add(Me.txtDuracionOrigen)
        Me.gbTemaOrigen.Controls.Add(Me.txtMaterialOrigen)
        Me.gbTemaOrigen.Controls.Add(Me.txtProductoOrigen)
        Me.gbTemaOrigen.Controls.Add(Me.lblDuracionOrigen)
        Me.gbTemaOrigen.Controls.Add(Me.lblMaterialOrigen)
        Me.gbTemaOrigen.Controls.Add(Me.lblProductoOrigen)
        Me.gbTemaOrigen.Location = New System.Drawing.Point(432, 80)
        Me.gbTemaOrigen.Name = "gbTemaOrigen"
        Me.gbTemaOrigen.Size = New System.Drawing.Size(352, 96)
        Me.gbTemaOrigen.TabIndex = 4
        Me.gbTemaOrigen.TabStop = False
        Me.gbTemaOrigen.Text = "Tema a Reemplazar"
        '
        'txtDuracionOrigen
        '
        Me.txtDuracionOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracionOrigen.ConDecimal = False
        Me.txtDuracionOrigen.Location = New System.Drawing.Point(80, 69)
        Me.txtDuracionOrigen.Maximo = 0
        Me.txtDuracionOrigen.Name = "txtDuracionOrigen"
        Me.txtDuracionOrigen.ReadOnly = True
        Me.txtDuracionOrigen.Size = New System.Drawing.Size(264, 20)
        Me.txtDuracionOrigen.SoloLetra = False
        Me.txtDuracionOrigen.SoloNumero = False
        Me.txtDuracionOrigen.TabIndex = 2
        Me.txtDuracionOrigen.TabStop = False
        '
        'txtMaterialOrigen
        '
        Me.txtMaterialOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaterialOrigen.ConDecimal = False
        Me.txtMaterialOrigen.Location = New System.Drawing.Point(80, 44)
        Me.txtMaterialOrigen.Maximo = 0
        Me.txtMaterialOrigen.Name = "txtMaterialOrigen"
        Me.txtMaterialOrigen.ReadOnly = True
        Me.txtMaterialOrigen.Size = New System.Drawing.Size(264, 20)
        Me.txtMaterialOrigen.SoloLetra = False
        Me.txtMaterialOrigen.SoloNumero = False
        Me.txtMaterialOrigen.TabIndex = 1
        Me.txtMaterialOrigen.TabStop = False
        '
        'txtProductoOrigen
        '
        Me.txtProductoOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductoOrigen.ConDecimal = False
        Me.txtProductoOrigen.Location = New System.Drawing.Point(80, 20)
        Me.txtProductoOrigen.Maximo = 0
        Me.txtProductoOrigen.Name = "txtProductoOrigen"
        Me.txtProductoOrigen.ReadOnly = True
        Me.txtProductoOrigen.Size = New System.Drawing.Size(264, 20)
        Me.txtProductoOrigen.SoloLetra = False
        Me.txtProductoOrigen.SoloNumero = False
        Me.txtProductoOrigen.TabIndex = 0
        Me.txtProductoOrigen.TabStop = False
        '
        'lblDuracionOrigen
        '
        Me.lblDuracionOrigen.Location = New System.Drawing.Point(9, 73)
        Me.lblDuracionOrigen.Name = "lblDuracionOrigen"
        Me.lblDuracionOrigen.Size = New System.Drawing.Size(56, 13)
        Me.lblDuracionOrigen.TabIndex = 110
        Me.lblDuracionOrigen.Text = "Duración:"
        '
        'lblMaterialOrigen
        '
        Me.lblMaterialOrigen.Location = New System.Drawing.Point(9, 48)
        Me.lblMaterialOrigen.Name = "lblMaterialOrigen"
        Me.lblMaterialOrigen.Size = New System.Drawing.Size(56, 13)
        Me.lblMaterialOrigen.TabIndex = 109
        Me.lblMaterialOrigen.Text = "Material:"
        '
        'lblProductoOrigen
        '
        Me.lblProductoOrigen.Location = New System.Drawing.Point(9, 24)
        Me.lblProductoOrigen.Name = "lblProductoOrigen"
        Me.lblProductoOrigen.Size = New System.Drawing.Size(56, 13)
        Me.lblProductoOrigen.TabIndex = 108
        Me.lblProductoOrigen.Text = "Producto:"
        '
        'gbTemaDestino
        '
        Me.gbTemaDestino.Controls.Add(Me.txtDuracionDestino)
        Me.gbTemaDestino.Controls.Add(Me.txtMaterialDestino)
        Me.gbTemaDestino.Controls.Add(Me.txtProductoDestino)
        Me.gbTemaDestino.Controls.Add(Me.lblDuracionDestino)
        Me.gbTemaDestino.Controls.Add(Me.lblMaterialDestino)
        Me.gbTemaDestino.Controls.Add(Me.lblProductoDestino)
        Me.gbTemaDestino.Location = New System.Drawing.Point(432, 184)
        Me.gbTemaDestino.Name = "gbTemaDestino"
        Me.gbTemaDestino.Size = New System.Drawing.Size(352, 96)
        Me.gbTemaDestino.TabIndex = 5
        Me.gbTemaDestino.TabStop = False
        Me.gbTemaDestino.Text = "Tema Reemplazante"
        '
        'txtDuracionDestino
        '
        Me.txtDuracionDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracionDestino.ConDecimal = False
        Me.txtDuracionDestino.Location = New System.Drawing.Point(80, 69)
        Me.txtDuracionDestino.Maximo = 0
        Me.txtDuracionDestino.Name = "txtDuracionDestino"
        Me.txtDuracionDestino.ReadOnly = True
        Me.txtDuracionDestino.Size = New System.Drawing.Size(264, 20)
        Me.txtDuracionDestino.SoloLetra = False
        Me.txtDuracionDestino.SoloNumero = False
        Me.txtDuracionDestino.TabIndex = 2
        Me.txtDuracionDestino.TabStop = False
        '
        'txtMaterialDestino
        '
        Me.txtMaterialDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaterialDestino.ConDecimal = False
        Me.txtMaterialDestino.Location = New System.Drawing.Point(80, 44)
        Me.txtMaterialDestino.Maximo = 0
        Me.txtMaterialDestino.Name = "txtMaterialDestino"
        Me.txtMaterialDestino.ReadOnly = True
        Me.txtMaterialDestino.Size = New System.Drawing.Size(264, 20)
        Me.txtMaterialDestino.SoloLetra = False
        Me.txtMaterialDestino.SoloNumero = False
        Me.txtMaterialDestino.TabIndex = 1
        Me.txtMaterialDestino.TabStop = False
        '
        'txtProductoDestino
        '
        Me.txtProductoDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductoDestino.ConDecimal = False
        Me.txtProductoDestino.Location = New System.Drawing.Point(80, 20)
        Me.txtProductoDestino.Maximo = 0
        Me.txtProductoDestino.Name = "txtProductoDestino"
        Me.txtProductoDestino.ReadOnly = True
        Me.txtProductoDestino.Size = New System.Drawing.Size(264, 20)
        Me.txtProductoDestino.SoloLetra = False
        Me.txtProductoDestino.SoloNumero = False
        Me.txtProductoDestino.TabIndex = 0
        Me.txtProductoDestino.TabStop = False
        '
        'lblDuracionDestino
        '
        Me.lblDuracionDestino.Location = New System.Drawing.Point(9, 73)
        Me.lblDuracionDestino.Name = "lblDuracionDestino"
        Me.lblDuracionDestino.Size = New System.Drawing.Size(56, 13)
        Me.lblDuracionDestino.TabIndex = 110
        Me.lblDuracionDestino.Text = "Duración:"
        '
        'lblMaterialDestino
        '
        Me.lblMaterialDestino.Location = New System.Drawing.Point(9, 48)
        Me.lblMaterialDestino.Name = "lblMaterialDestino"
        Me.lblMaterialDestino.Size = New System.Drawing.Size(56, 13)
        Me.lblMaterialDestino.TabIndex = 109
        Me.lblMaterialDestino.Text = "Material:"
        '
        'lblProductoDestino
        '
        Me.lblProductoDestino.Location = New System.Drawing.Point(9, 24)
        Me.lblProductoDestino.Name = "lblProductoDestino"
        Me.lblProductoDestino.Size = New System.Drawing.Size(56, 13)
        Me.lblProductoDestino.TabIndex = 108
        Me.lblProductoDestino.Text = "Producto:"
        '
        'frmActualizarTema
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(788, 287)
        Me.Controls.Add(Me.gbTemaDestino)
        Me.Controls.Add(Me.gbTemaOrigen)
        Me.Controls.Add(Me.cboTemaDestino)
        Me.Controls.Add(Me.cboTemaOrigen)
        Me.Controls.Add(Me.lblTemaDestino)
        Me.Controls.Add(Me.lblTemaOrigen)
        Me.Controls.Add(Me.DtpFFin)
        Me.Controls.Add(Me.lblVigenciaHasta)
        Me.Controls.Add(Me.DtpFInicio)
        Me.Controls.Add(Me.lblVigenciaDesde)
        Me.Controls.Add(Me.uTree)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmActualizarTema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Temas en Planificación"
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uTree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTemaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTemaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTemaOrigen.ResumeLayout(False)
        Me.gbTemaOrigen.PerformLayout()
        Me.gbTemaDestino.ResumeLayout(False)
        Me.gbTemaDestino.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mId_Campania As Integer
    Private mCampania As String
    Private mCheckParent As Boolean = False
    Private mCheckChild As Boolean = False
    Private mCheckChildChild As Boolean = False
    Private mFechaInicio As DateTime
    Private mFechaFin As DateTime
    Private SistemaEjercicio As DataTable

    Private Enum TipoTema As Integer
        Origen = 0
        Destino = 1
    End Enum
    Private Enum TipoBusqueda As Integer
        Sistema = 0
        Ejercicio = 1
        Soporte = 2
    End Enum
#End Region

#Region "Propiedades Publicas"
    Public WriteOnly Property Id_Campania() As Integer
        Set(ByVal Value As Integer)
            mId_Campania = Value
        End Set
    End Property

    Public WriteOnly Property Campania() As String
        Set(ByVal Value As String)
            mCampania = Value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmActualizarTema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetearTitulo()
        Call CargarArbol()
        Call ChequearArbol()
        Call ExpandirArbol()
        Call CargarFechaCampaña()
        Call CargarTemas()
    End Sub

    Private Sub uTree_AfterCheck(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinTree.NodeEventArgs) Handles uTree.AfterCheck
        If e.TreeNode.Level = 0 Then
            If Not mCheckChild Then
                mCheckParent = True
                For Each Node As UltraTreeNode In e.TreeNode.Nodes
                    Node.CheckedState = e.TreeNode.CheckedState
                    If Node.Nodes.Count > 0 Then
                        For Each NodeChild As UltraTreeNode In node.Nodes
                            NodeChild.CheckedState = e.TreeNode.CheckedState
                        Next
                    End If
                Next
                mCheckParent = False
            End If
        ElseIf e.TreeNode.Level = 1 Then
            If Not mCheckParent Then
                Dim Estado As CheckState = e.TreeNode.CheckedState
                Dim EstadoIgual As Boolean = True
                mCheckChild = True
                For Each Node As UltraTreeNode In e.TreeNode.Parent.Nodes
                    If node.CheckedState <> Estado Then
                        EstadoIgual = False
                        Exit For
                    End If
                Next
                If e.TreeNode.Nodes.Count > 0 AndAlso Not mCheckChildChild Then
                    For Each NodeChild As UltraTreeNode In e.TreeNode.Nodes
                        NodeChild.CheckedState = e.TreeNode.CheckedState
                    Next
                End If
                If EstadoIgual Then
                    e.TreeNode.Parent.CheckedState = Estado
                Else
                    e.TreeNode.Parent.CheckedState = CheckState.Unchecked
                End If
                mCheckChild = False
            End If
        Else
            If Not mCheckChild Then
                Dim Estado As CheckState = e.TreeNode.CheckedState
                Dim EstadoIgual As Boolean = True
                For Each Node As UltraTreeNode In e.TreeNode.Parent.Nodes
                    If node.CheckedState <> Estado Then
                        EstadoIgual = False
                        Exit For
                    End If
                Next
                mCheckChildChild = True
                If EstadoIgual Then
                    e.TreeNode.Parent.CheckedState = Estado
                Else
                    e.TreeNode.Parent.CheckedState = CheckState.Unchecked
                End If
                mCheckChildChild = False
            End If
        End If
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Reemplazar"
                Call ReemplazarTema()
            Case "Expandir"
                Call ExpandirArbol()
            Case "Seleccionar"
                Call ChequearArbol()
            Case "Limpiar"
                Call Limpiar()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub cboTemaOrigen_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTemaOrigen.SelectionChanged
        Call CompletarTema(TipoTema.Origen)
    End Sub

    Private Sub cboTemaDestino_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTemaDestino.SelectionChanged
        Call CompletarTema(TipoTema.Destino)
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub SetearTitulo()
        Dim Titulo As New StringBuilder
        Titulo.Append(Me.Text)
        Titulo.Append(" ( ")
        Titulo.Append(mCampania)
        Titulo.Append(" ) ")
        Me.Text = Titulo.ToString
    End Sub

    Private Sub CargarArbol()
        Dim Sistema As New Sistemas
        Dim Soportes As New Soportes
        Dim dtSoportes, SistemaEjercicioFiltrado As DataTable

        Sistema.Id_campania = mId_Campania
        SistemaEjercicio = Sistema.ObtenerSistemasEjercicio()
        If Not SistemaEjercicio Is Nothing Then
            SistemaEjercicioFiltrado = SistemaEjercicio.Clone
            For Each SistEje As DataRow In SistemaEjercicio.Select("Id_Medio not in (3,4,5)")
                SistemaEjercicioFiltrado.ImportRow(SistEje)
            Next
        End If

        dtSoportes = Soportes.ObtenerSoportesCampania(mId_Campania)
        If Not SistemaEjercicioFiltrado Is Nothing AndAlso SistemaEjercicioFiltrado.Rows.Count > 0 AndAlso Not dtSoportes Is Nothing AndAlso dtSoportes.Rows.Count > 0 Then
            Call CargarArbol(SistemaEjercicioFiltrado, dtSoportes)
        End If
    End Sub

    Private Sub CargarArbol(ByVal pData As DataTable, ByVal pSoportes As DataTable)
        Dim ParentFolderName, ParentFolderKey As String
        Dim KeyValue As StringBuilder
        Dim Key As String
        Dim ParentNodeSistema As UltraTreeNode
        Dim ParentNodeEjercicio As UltraTreeNode
        Dim ParentNodeSoporte As UltraTreeNode
        Dim Filtro As StringBuilder
        Dim FiltroSoporte As String = ObtenerFiltroSoporte(pSoportes)

        For Each RowSistema As DataRow In pData.Select(FiltroSoporte.ToString)
            KeyValue = New StringBuilder
            KeyValue.Append(RowSistema("Sistema"))
            KeyValue.Append(" - ")
            KeyValue.Append(RowSistema("Id_Sistema"))
            Key = RowSistema("Id_Sistema")
            ParentFolderKey = KeyValue.ToString
            ParentFolderName = KeyValue.ToString
            If Not uTree.Nodes.Exists(ParentFolderKey) Then
                ParentNodeSistema = uTree.Nodes.Add(ParentFolderKey, ParentFolderName)
                ParentNodeSistema.Tag = Key
                For Each RowEjercicio As DataRow In pData.Select("Id_Sistema = " & RowSistema("Id_Sistema"))
                    KeyValue = New StringBuilder
                    KeyValue.Append(RowEjercicio("Ejercicio"))
                    Key = RowEjercicio("Id_Ejercicio")
                    ParentFolderKey = KeyValue.ToString
                    ParentFolderName = KeyValue.ToString
                    ParentNodeEjercicio = ParentNodeSistema.Nodes.Add(ParentFolderKey, ParentFolderName)
                    ParentNodeEjercicio.Tag = Key

                    ''cambio se agrega (') para que no tire error cuando viene en string dcaime 02/07/2010
                    Filtro = New StringBuilder
                    Filtro.Append("Id_Sistema = '")
                    Filtro.Append(RowSistema("Id_Sistema"))
                    Filtro.Append("'")
                    Filtro.Append(" and Id_Ejercicio = '")
                    Filtro.Append(RowEjercicio("Id_Ejercicio"))
                    Filtro.Append("'")
                    For Each RowSoporte As DataRow In pSoportes.Select(Filtro.ToString)
                        KeyValue = New StringBuilder
                        KeyValue.Append(RowSoporte("Des_Soporte"))
                        KeyValue.Append(" - ")
                        KeyValue.Append(RowSoporte("Id_Soporte"))
                        ParentFolderName = KeyValue.ToString

                        KeyValue = New StringBuilder
                        KeyValue.Append(RowEjercicio("Id_Ejercicio"))
                        KeyValue.Append(" - ")
                        KeyValue.Append(RowSoporte("Id_Soporte"))
                        ParentFolderKey = KeyValue.ToString
                        Key = KeyValue.ToString

                        ParentNodeSoporte = ParentNodeEjercicio.Nodes.Add(ParentFolderKey, ParentFolderName)
                        ParentNodeSoporte.Tag = Key
                    Next
                Next
            End If
        Next
    End Sub

    Private Sub ChequearArbol()
        If UltraToolbarsManager1.Toolbars(0).Tools("Seleccionar").SharedProps.Caption = "Seleccionar" Then
            Call ChequearArbol(CheckState.Checked)
        Else
            Call ChequearArbol(CheckState.Unchecked)
        End If
    End Sub

    Private Sub ChequearArbol(ByVal pChequear As CheckState)
        For Each Node As UltraTreeNode In uTree.Nodes
            For Each NodeChild As UltraTreeNode In Node.Nodes
                If NodeChild.Nodes.Count > 0 Then
                    For Each NodeChildChild As UltraTreeNode In NodeChild.Nodes
                        NodeChildChild.CheckedState = pChequear
                    Next
                Else
                        NodeChild.CheckedState = pChequear
                End If
            Next
        Next
        If pChequear = CheckState.Checked Then
            UltraToolbarsManager1.Toolbars(0).Tools("Seleccionar").SharedProps.Caption = "Deseleccionar"
        Else
            UltraToolbarsManager1.Toolbars(0).Tools("Seleccionar").SharedProps.Caption = "Seleccionar"
        End If
    End Sub

    Private Sub ExpandirArbol()
        If UltraToolbarsManager1.Toolbars(0).Tools("Expandir").SharedProps.Caption = "Expandir" Then
            Call ExpandirArbol(True)
        Else
            Call ExpandirArbol(False)
        End If
    End Sub

    Private Sub ExpandirArbol(ByVal pExpandir As Boolean)
        If pExpandir Then
            uTree.ExpandAll(ExpandAllType.OnlyNodesWithChildren)
            UltraToolbarsManager1.Toolbars(0).Tools("Expandir").SharedProps.Caption = "Colapsar"
        Else
            uTree.CollapseAll()
            UltraToolbarsManager1.Toolbars(0).Tools("Expandir").SharedProps.Caption = "Expandir"
        End If
    End Sub

    Private Sub CargarFechaCampaña()
        Dim Campañas As New Campaña
        Campañas.ID_Campania = mId_Campania
        Campañas.BuscarPorID()
        mFechaInicio = Campañas.F_inicio
        mFechaFin = Campañas.F_fin
        DtpFInicio.Value = mFechaInicio
        DtpFInicio.MinDate = mFechaInicio
        DtpFInicio.MaxDate = mFechaFin
        DtpFFin.Value = mFechaFin
        DtpFFin.MinDate = mFechaInicio
        DtpFFin.MaxDate = mFechaFin
    End Sub

    Private Sub CargarTemas()
        Dim Temas As New Temas
        Dim dtTemas As DataTable

        Temas.Id_campania = mId_Campania
        dtTemas = Temas.ObtenerTemasPorCampaña
        Call Combo_Load(cboTemaOrigen, dtTemas, "Id_Tema", False)
        Call Combo_Load(cboTemaDestino, dtTemas, "Id_Tema", False)
    End Sub

    Private Sub CompletarTema(ByVal mTipoTema As TipoTema)
        If mTipoTema = TipoTema.Origen Then
            Call CompletarTema(cboTemaOrigen, txtProductoOrigen, txtMaterialOrigen, txtDuracionOrigen)
        Else
            Call CompletarTema(cboTemaDestino, txtProductoDestino, txtMaterialDestino, txtDuracionDestino)
        End If
    End Sub

    Private Sub CompletarTema(ByVal pCboTema As UltraComboEditor, ByVal pProducto As txtTexto, ByVal pMaterial As txtTexto, ByVal pDuracion As txtTexto)
        If Not pCboTema.SelectedItem Is Nothing AndAlso Not pCboTema.SelectedItem.DataValue Is Nothing Then
            pProducto.Text = pCboTema.SelectedItem.DataValue("Producto")
            pMaterial.Text = pCboTema.SelectedItem.DataValue("Material")
            pDuracion.Text = pCboTema.SelectedItem.DataValue("Duracion")
        Else
            pProducto.Text = String.Empty
            pMaterial.Text = String.Empty
            pDuracion.Text = String.Empty
        End If
    End Sub

    Private Sub Limpiar()
        DtpFInicio.Value = mFechaInicio
        DtpFFin.Value = mFechaFin
        cboTemaOrigen.SelectedIndex = 0
        Call CompletarTema(TipoTema.Origen)
        cboTemaDestino.SelectedIndex = 0
        Call CompletarTema(TipoTema.Destino)
    End Sub

    Private Sub ReemplazarTema()
        If Validar() Then
            Dim SpotDetalle As New Spots_detalle
            Dim Sistemas, Ejercicios, Soportes As StringBuilder
            Dim FechaDesde, FechaHasta, FechaModificacion As DateTime
            Dim IdTemaOrigen, IdTemaDestino, Usuario As String
            Dim Duracion As Integer
            Dim EnviarEjercicio As Boolean
            Dim ArrayTexto As ArrayList
            Dim CantidadTexto As Integer
            Dim SoporteKey As String

            Call ObtenerSistemaEjercicio(Sistemas, TipoBusqueda.Sistema)
            If Not ValidarTemasSeleccionados(Sistemas.ToString) Then Exit Sub
            Call ObtenerSistemaEjercicio(Ejercicios, TipoBusqueda.Ejercicio)
            Call ObtenerSistemaEjercicio(Soportes, TipoBusqueda.Soporte)
            FechaDesde = Convert.ToDateTime(DtpFInicio.Value).Date
            FechaHasta = Convert.ToDateTime(DtpFFin.Value).Date
            FechaModificacion = Now.Date
            IdTemaOrigen = cboTemaOrigen.SelectedItem.DataValue("Id_Tema")
            IdTemaDestino = cboTemaDestino.SelectedItem.DataValue("Id_Tema")
            Duracion = cboTemaDestino.SelectedItem.DataValue("Duracion")
            Usuario = Activo.Login
            If ValidarChequeoCompleto() Then
                SpotDetalle.ActualizarTema(mId_Campania, Sistemas.ToString, Ejercicios.ToString, Soportes.ToString, FechaDesde, FechaHasta, IdTemaOrigen, IdTemaDestino, Duracion, FechaModificacion, Usuario)
            Else
                For Each Sistema As UltraTreeNode In uTree.Nodes
                    For Each Ejercicio As UltraTreeNode In Sistema.Nodes
                        EnviarEjercicio = False
                        Soportes = New StringBuilder
                        ArrayTexto = New ArrayList
                        If Ejercicio.Nodes.Count > 0 Then
                            For Each Soporte As UltraTreeNode In Ejercicio.Nodes
                                If Soporte.CheckedState = CheckState.Checked Then
                                    EnviarEjercicio = True
                                    SoporteKey = Soporte.Tag.ToString.Split("-").GetValue(1).ToString.Trim
                                    If Not ArrayTexto.Contains(SoporteKey) Then
                                        ArrayTexto.Add(SoporteKey)
                                    End If
                                End If
                            Next
                        End If
                        If EnviarEjercicio Then
                            CantidadTexto = ArrayTexto.Count - 1
                            For Index As Integer = 0 To CantidadTexto
                                Soportes.Append(ArrayTexto(Index))
                                If Index < CantidadTexto Then
                                    Soportes.Append(",")
                                End If
                            Next
                            SpotDetalle.ActualizarTema(mId_Campania, Sistema.Tag, Ejercicio.Tag, Soportes.ToString, FechaDesde, FechaHasta, IdTemaOrigen, IdTemaDestino, Duracion, FechaModificacion, Usuario)
                        End If
                    Next
                Next
            End If

            Mensaje("El reemplazo se realizó con éxito.")
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim ExisteChequeado As Boolean = False

        If DtpFInicio.Value Is Nothing Then
            Mensaje("Debe ingresar fecha desde.")
            Return False
        End If
        If DtpFFin.Value Is Nothing Then
            Mensaje("Debe ingresar fecha hasta.")
            Return False
        End If
        If Convert.ToDateTime(DtpFInicio.Value).Date > Convert.ToDateTime(DtpFFin.Value).Date Then
            Mensaje("La fecha desde debe ser menor o igual a la fecha hasta.")
            Return False
        End If
        If cboTemaOrigen.SelectedItem Is Nothing OrElse cboTemaOrigen.SelectedItem.DataValue Is Nothing Then
            Mensaje("Debe seleccionar un tema a reemplazar.")
            Return False
        End If
        If cboTemaDestino.SelectedItem Is Nothing OrElse cboTemaDestino.SelectedItem.DataValue Is Nothing Then
            Mensaje("Debe seleccionar un tema reemplazante.")
            Return False
        End If
        If cboTemaOrigen.SelectedItem.DataValue("Id_Tema") = cboTemaDestino.SelectedItem.DataValue("Id_Tema") Then
            Mensaje("El tema a reemplazar debe ser diferente al tema reemplazante.")
            Return False
        End If
        For Each Sistema As UltraTreeNode In uTree.Nodes
            For Each Ejercicio As UltraTreeNode In Sistema.Nodes
                If Ejercicio.Nodes.Count > 0 Then
                    For Each Soporte As UltraTreeNode In Ejercicio.Nodes
                        If Soporte.CheckedState = CheckState.Checked Then
                            ExisteChequeado = True
                            Return True
                        End If
                    Next
                End If
            Next
        Next
        Mensaje("Debe seleccionar al menos un soporte.")
        Return False
    End Function

    Private Function ValidarChequeoCompleto() As Boolean
        Dim ChequeoCompleto As Boolean = True
        For Each Sistema As UltraTreeNode In uTree.Nodes
            For Each Ejercicio As UltraTreeNode In Sistema.Nodes
                If Ejercicio.Nodes.Count > 0 Then
                    For Each Soporte As UltraTreeNode In Ejercicio.Nodes
                        If Soporte.CheckedState = CheckState.Unchecked Then
                            For Each SoporteEjercicio As UltraTreeNode In Soporte.Parent.Nodes
                                If SoporteEjercicio.CheckedState = CheckState.Checked Then
                                    ChequeoCompleto = False
                                    Return False
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Next
        Return True
    End Function

    Private Function ValidarTemasSeleccionados(ByVal pSistemas As String) As Boolean
        Dim Medio As Integer
        Dim Filtro As New StringBuilder

        If cboTemaDestino.SelectedItem.DataValue("Id_Material") = "-1" Then
            Filtro.Append("Id_Sistema IN (")
            Filtro.Append(pSistemas)
            Filtro.Append(")")

            For Each Sistema As DataRow In SistemaEjercicio.Select(Filtro.ToString)
                If Sistema("Id_Medio") = 6 Then
                    Mensajes.Mensaje("No se puede reemplazar un Tema por otro que no tenga definido un material para los ejercicios de un sistema de medio radio.", TipoMensaje.Informacion)
                    Return False
                End If
            Next
        End If
        Return True
    End Function

    Private Function ObtenerFiltroSoporte(ByVal pSoportes As DataTable)
        Dim Filtro As New StringBuilder
        Dim Sistemas As New ArrayList
        Dim Ejercicios As New ArrayList
        Dim Cantidad As Integer

        For Each Soporte As DataRow In pSoportes.Rows
            If Not Sistemas.Contains(Soporte("Id_Sistema")) Then
                Sistemas.Add(Soporte("Id_Sistema"))
            End If
            If Not Ejercicios.Contains(Soporte("Id_Ejercicio")) Then
                Ejercicios.Add(Soporte("Id_Ejercicio"))
            End If
        Next
        Cantidad = Sistemas.Count - 1
        If Cantidad >= 0 Then
            Filtro.Append("Id_Sistema IN (")
            For Index As Integer = 0 To Cantidad
                Filtro.Append(Sistemas(Index))
                If Index < Cantidad Then
                    Filtro.Append(",")
                End If
            Next
            Filtro.Append(")")
        End If
        Cantidad = Ejercicios.Count - 1
        If Cantidad >= 0 Then
            If Filtro.ToString <> String.Empty Then
                Filtro.Append(" and ")
            End If
            Filtro.Append("Id_Ejercicio IN (")
            For Index As Integer = 0 To Cantidad
                Filtro.Append(Ejercicios(Index))
                If Index < Cantidad Then
                    Filtro.Append(",")
                End If
            Next
            Filtro.Append(")")
        End If

        Return Filtro.ToString
    End Function

    Private Sub ObtenerSistemaEjercicio(ByRef pTexto As StringBuilder, ByVal pTipoBusqueda As TipoBusqueda)
        Dim ArrayTexto As New ArrayList
        Dim CantidadTexto As Integer
        Dim SoporteKey As String
        pTexto = New StringBuilder
        For Each Sistema As UltraTreeNode In uTree.Nodes
            For Each Ejercicio As UltraTreeNode In Sistema.Nodes
                If Ejercicio.Nodes.Count > 0 Then
                    For Each Soporte As UltraTreeNode In Ejercicio.Nodes
                        If Soporte.CheckedState = CheckState.Checked Then
                            If pTipoBusqueda = TipoBusqueda.Sistema Then
                                If Not ArrayTexto.Contains(Soporte.Parent.Parent.Tag) Then
                                    ArrayTexto.Add(Soporte.Parent.Parent.Tag)
                                End If
                            ElseIf pTipoBusqueda = TipoBusqueda.Ejercicio Then
                                If Not ArrayTexto.Contains(Soporte.Parent.Tag) Then
                                    ArrayTexto.Add(Soporte.Parent.Tag)
                                End If
                            Else
                                SoporteKey = Soporte.Tag.ToString.Split("-").GetValue(1).ToString.Trim
                                If Not ArrayTexto.Contains(SoporteKey) Then
                                    ArrayTexto.Add(SoporteKey)
                                End If
                            End If
                        End If
                    Next
                End If
            Next
        Next

        CantidadTexto = ArrayTexto.Count - 1
        For Index As Integer = 0 To CantidadTexto
            pTexto.Append(ArrayTexto(Index))
            If Index < CantidadTexto Then
                pTexto.Append(",")
            End If
        Next
    End Sub

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
#End Region

End Class

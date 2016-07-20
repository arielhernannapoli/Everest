Imports Infragistics.Win.UltraWinGrid
Imports Framework.Mensajes
Imports System.Text

Public Class frmABMClienteExterno
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
    Friend WithEvents gbSigeme As System.Windows.Forms.GroupBox
    Friend WithEvents gbExterno As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesCliente As System.Windows.Forms.Label
    Friend WithEvents lblDesProducto As System.Windows.Forms.Label
    Friend WithEvents TxtProducto As QUETOOL.txtTexto
    Friend WithEvents TxtCodProducto As QUETOOL.txtTexto
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents txtCodCliente As QUETOOL.txtTexto
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDesClienteExterno As System.Windows.Forms.Label
    Friend WithEvents txtClienteExterno As QUETOOL.txtTexto
    Friend WithEvents txtCodClienteExterno As QUETOOL.txtTexto
    Friend WithEvents lblClienteExterno As System.Windows.Forms.Label
    Friend WithEvents lblDesProductoExterno As System.Windows.Forms.Label
    Friend WithEvents TxtProductoExterno As QUETOOL.txtTexto
    Friend WithEvents TxtCodProductoExterno As QUETOOL.txtTexto
    Friend WithEvents lblProductoExterno As System.Windows.Forms.Label
    Friend WithEvents pnlProductos As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsManager2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents pnlProductos_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _pnlProductos_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlProductos_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlProductos_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlProductos_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ugProductos As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarPantalla")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reiniciar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reiniciar")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Cli_Sig", 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Cli_Nau", 1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Prod_Sig", 2)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Prod_Nau", 3)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nom_Prod", 4)
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
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbarProductos")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMClienteExterno))
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.gbSigeme = New System.Windows.Forms.GroupBox
        Me.lblDesCliente = New System.Windows.Forms.Label
        Me.lblDesProducto = New System.Windows.Forms.Label
        Me.TxtProducto = New QUETOOL.txtTexto
        Me.TxtCodProducto = New QUETOOL.txtTexto
        Me.lblProducto = New System.Windows.Forms.Label
        Me.txtCliente = New QUETOOL.txtTexto
        Me.txtCodCliente = New QUETOOL.txtTexto
        Me.lblCliente = New System.Windows.Forms.Label
        Me.gbExterno = New System.Windows.Forms.GroupBox
        Me.pnlProductos = New System.Windows.Forms.Panel
        Me.pnlProductos_Fill_Panel = New System.Windows.Forms.Panel
        Me.ugProductos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlProductos_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlProductos_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlProductos_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlProductos_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.lblDesProductoExterno = New System.Windows.Forms.Label
        Me.TxtProductoExterno = New QUETOOL.txtTexto
        Me.TxtCodProductoExterno = New QUETOOL.txtTexto
        Me.lblProductoExterno = New System.Windows.Forms.Label
        Me.lblDesClienteExterno = New System.Windows.Forms.Label
        Me.txtClienteExterno = New QUETOOL.txtTexto
        Me.txtCodClienteExterno = New QUETOOL.txtTexto
        Me.lblClienteExterno = New System.Windows.Forms.Label
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSigeme.SuspendLayout()
        Me.gbExterno.SuspendLayout()
        Me.pnlProductos.SuspendLayout()
        Me.pnlProductos_Fill_Panel.SuspendLayout()
        CType(Me.ugProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.LockToolbars = True
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
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
        UltraToolbar2.Text = "uToolbarPantalla"
        UltraToolbar2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5, ButtonTool6, ButtonTool7, ButtonTool8})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        ButtonTool9.SharedProps.Caption = "Guardar"
        ButtonTool10.SharedProps.Caption = "Eliminar"
        ButtonTool11.SharedProps.Caption = "Reiniciar"
        ButtonTool12.SharedProps.Caption = "Salir"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12})
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Top
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Top"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(354, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 359)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(354, 0)
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
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 337)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmConfirmacionAvisos_Toolbars_Dock_Area_Right
        '
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(354, 22)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Name = "_frmConfirmacionAvisos_Toolbars_Dock_Area_Right"
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 337)
        Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'gbSigeme
        '
        Me.gbSigeme.Controls.Add(Me.lblDesCliente)
        Me.gbSigeme.Controls.Add(Me.lblDesProducto)
        Me.gbSigeme.Controls.Add(Me.TxtProducto)
        Me.gbSigeme.Controls.Add(Me.TxtCodProducto)
        Me.gbSigeme.Controls.Add(Me.lblProducto)
        Me.gbSigeme.Controls.Add(Me.txtCliente)
        Me.gbSigeme.Controls.Add(Me.txtCodCliente)
        Me.gbSigeme.Controls.Add(Me.lblCliente)
        Me.gbSigeme.Location = New System.Drawing.Point(4, 28)
        Me.gbSigeme.Name = "gbSigeme"
        Me.gbSigeme.Size = New System.Drawing.Size(343, 84)
        Me.gbSigeme.TabIndex = 8
        Me.gbSigeme.TabStop = False
        Me.gbSigeme.Text = "Datos Cliente Sigeme"
        '
        'lblDesCliente
        '
        Me.lblDesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesCliente.Image = CType(resources.GetObject("lblDesCliente.Image"), System.Drawing.Image)
        Me.lblDesCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesCliente.Location = New System.Drawing.Point(314, 24)
        Me.lblDesCliente.Name = "lblDesCliente"
        Me.lblDesCliente.Size = New System.Drawing.Size(21, 21)
        Me.lblDesCliente.TabIndex = 101
        Me.lblDesCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesProducto
        '
        Me.lblDesProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesProducto.Enabled = False
        Me.lblDesProducto.Image = CType(resources.GetObject("lblDesProducto.Image"), System.Drawing.Image)
        Me.lblDesProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesProducto.Location = New System.Drawing.Point(314, 49)
        Me.lblDesProducto.Name = "lblDesProducto"
        Me.lblDesProducto.Size = New System.Drawing.Size(21, 21)
        Me.lblDesProducto.TabIndex = 103
        Me.lblDesProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtProducto
        '
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.ConDecimal = False
        Me.TxtProducto.Location = New System.Drawing.Point(103, 49)
        Me.TxtProducto.Maximo = 0
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(208, 20)
        Me.TxtProducto.SoloLetra = False
        Me.TxtProducto.SoloNumero = False
        Me.TxtProducto.TabIndex = 107
        Me.TxtProducto.TabStop = False
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.AcceptsReturn = True
        Me.TxtCodProducto.AcceptsTab = True
        Me.TxtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodProducto.ConDecimal = False
        Me.TxtCodProducto.Location = New System.Drawing.Point(59, 49)
        Me.TxtCodProducto.Maximo = 0
        Me.TxtCodProducto.MaxLength = 5
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.ReadOnly = True
        Me.TxtCodProducto.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodProducto.SoloLetra = False
        Me.TxtCodProducto.SoloNumero = True
        Me.TxtCodProducto.TabIndex = 102
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(8, 51)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 106
        Me.lblProducto.Text = "Producto"
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(103, 24)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtCliente.SoloLetra = False
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 105
        Me.txtCliente.TabStop = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.AcceptsReturn = True
        Me.txtCodCliente.AcceptsTab = True
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.ConDecimal = False
        Me.txtCodCliente.Location = New System.Drawing.Point(59, 24)
        Me.txtCodCliente.Maximo = 0
        Me.txtCodCliente.MaxLength = 5
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtCodCliente.SoloLetra = False
        Me.txtCodCliente.SoloNumero = True
        Me.txtCodCliente.TabIndex = 100
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(8, 26)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 104
        Me.lblCliente.Text = "Cliente"
        '
        'gbExterno
        '
        Me.gbExterno.Controls.Add(Me.pnlProductos)
        Me.gbExterno.Controls.Add(Me.lblDesProductoExterno)
        Me.gbExterno.Controls.Add(Me.TxtProductoExterno)
        Me.gbExterno.Controls.Add(Me.TxtCodProductoExterno)
        Me.gbExterno.Controls.Add(Me.lblProductoExterno)
        Me.gbExterno.Controls.Add(Me.lblDesClienteExterno)
        Me.gbExterno.Controls.Add(Me.txtClienteExterno)
        Me.gbExterno.Controls.Add(Me.txtCodClienteExterno)
        Me.gbExterno.Controls.Add(Me.lblClienteExterno)
        Me.gbExterno.Location = New System.Drawing.Point(4, 120)
        Me.gbExterno.Name = "gbExterno"
        Me.gbExterno.Size = New System.Drawing.Size(343, 232)
        Me.gbExterno.TabIndex = 9
        Me.gbExterno.TabStop = False
        Me.gbExterno.Text = "Datos Cliente Externo"
        '
        'pnlProductos
        '
        Me.pnlProductos.Controls.Add(Me.pnlProductos_Fill_Panel)
        Me.pnlProductos.Controls.Add(Me._pnlProductos_Toolbars_Dock_Area_Left)
        Me.pnlProductos.Controls.Add(Me._pnlProductos_Toolbars_Dock_Area_Right)
        Me.pnlProductos.Controls.Add(Me._pnlProductos_Toolbars_Dock_Area_Top)
        Me.pnlProductos.Controls.Add(Me._pnlProductos_Toolbars_Dock_Area_Bottom)
        Me.pnlProductos.Location = New System.Drawing.Point(5, 75)
        Me.pnlProductos.Name = "pnlProductos"
        Me.pnlProductos.Size = New System.Drawing.Size(334, 149)
        Me.pnlProductos.TabIndex = 114
        '
        'pnlProductos_Fill_Panel
        '
        Me.pnlProductos_Fill_Panel.Controls.Add(Me.ugProductos)
        Me.pnlProductos_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlProductos_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProductos_Fill_Panel.Location = New System.Drawing.Point(0, 22)
        Me.pnlProductos_Fill_Panel.Name = "pnlProductos_Fill_Panel"
        Me.pnlProductos_Fill_Panel.Size = New System.Drawing.Size(334, 127)
        Me.pnlProductos_Fill_Panel.TabIndex = 0
        '
        'ugProductos
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugProductos.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.DataType = GetType(Double)
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.DataType = GetType(Double)
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.DataType = GetType(Double)
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn4.CellAppearance = Appearance2
        UltraGridColumn4.DataType = GetType(Double)
        UltraGridColumn4.Header.Caption = "Código"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 65
        UltraGridColumn5.Header.Caption = "Producto"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 250
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
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
        UltraGridBand1.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand1.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand1.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand1.Override.HeaderAppearance = Appearance3
        UltraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugProductos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugProductos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugProductos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.ugProductos.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugProductos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.ugProductos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugProductos.DisplayLayout.GroupByBox.Hidden = True
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugProductos.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.ugProductos.DisplayLayout.MaxColScrollRegions = 1
        Me.ugProductos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugProductos.DisplayLayout.Override.ActiveCellAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.SystemColors.Highlight
        Appearance8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugProductos.DisplayLayout.Override.ActiveRowAppearance = Appearance8
        Me.ugProductos.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugProductos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ugProductos.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugProductos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugProductos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Me.ugProductos.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugProductos.DisplayLayout.Override.CellAppearance = Appearance10
        Me.ugProductos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugProductos.DisplayLayout.Override.CellPadding = 0
        Me.ugProductos.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Appearance11.BackColor = System.Drawing.SystemColors.Control
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.ugProductos.DisplayLayout.Override.GroupByRowAppearance = Appearance11
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugProductos.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.ugProductos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.ugProductos.DisplayLayout.Override.RowAppearance = Appearance13
        Me.ugProductos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugProductos.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugProductos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugProductos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.ugProductos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugProductos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugProductos.FlatMode = True
        Me.ugProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugProductos.Location = New System.Drawing.Point(0, 0)
        Me.ugProductos.Name = "ugProductos"
        Me.ugProductos.Size = New System.Drawing.Size(334, 127)
        Me.ugProductos.TabIndex = 3
        Me.ugProductos.TabStop = False
        '
        '_pnlProductos_Toolbars_Dock_Area_Left
        '
        Me._pnlProductos_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlProductos_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlProductos_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlProductos_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlProductos_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._pnlProductos_Toolbars_Dock_Area_Left.Name = "_pnlProductos_Toolbars_Dock_Area_Left"
        Me._pnlProductos_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 127)
        Me._pnlProductos_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager2
        '
        'UltraToolbarsManager2
        '
        Me.UltraToolbarsManager2.DesignerFlags = 1
        Me.UltraToolbarsManager2.DockWithinContainer = Me.pnlProductos
        Me.UltraToolbarsManager2.LockToolbars = True
        Me.UltraToolbarsManager2.ShowFullMenusDelay = 500
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
        UltraToolbar1.Text = "uToolbarProductos"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.UltraToolbarsManager2.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool3.SharedProps.Caption = "Agregar"
        ButtonTool4.SharedProps.Caption = "Eliminar"
        Me.UltraToolbarsManager2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        '
        '_pnlProductos_Toolbars_Dock_Area_Right
        '
        Me._pnlProductos_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlProductos_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlProductos_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlProductos_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlProductos_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(334, 22)
        Me._pnlProductos_Toolbars_Dock_Area_Right.Name = "_pnlProductos_Toolbars_Dock_Area_Right"
        Me._pnlProductos_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 127)
        Me._pnlProductos_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager2
        '
        '_pnlProductos_Toolbars_Dock_Area_Top
        '
        Me._pnlProductos_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlProductos_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlProductos_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlProductos_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlProductos_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlProductos_Toolbars_Dock_Area_Top.Name = "_pnlProductos_Toolbars_Dock_Area_Top"
        Me._pnlProductos_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(334, 22)
        Me._pnlProductos_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager2
        '
        '_pnlProductos_Toolbars_Dock_Area_Bottom
        '
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 149)
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.Name = "_pnlProductos_Toolbars_Dock_Area_Bottom"
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(334, 0)
        Me._pnlProductos_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager2
        '
        'lblDesProductoExterno
        '
        Me.lblDesProductoExterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesProductoExterno.Enabled = False
        Me.lblDesProductoExterno.Image = CType(resources.GetObject("lblDesProductoExterno.Image"), System.Drawing.Image)
        Me.lblDesProductoExterno.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesProductoExterno.Location = New System.Drawing.Point(314, 49)
        Me.lblDesProductoExterno.Name = "lblDesProductoExterno"
        Me.lblDesProductoExterno.Size = New System.Drawing.Size(21, 21)
        Me.lblDesProductoExterno.TabIndex = 111
        Me.lblDesProductoExterno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtProductoExterno
        '
        Me.TxtProductoExterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductoExterno.ConDecimal = False
        Me.TxtProductoExterno.Location = New System.Drawing.Point(103, 49)
        Me.TxtProductoExterno.Maximo = 0
        Me.TxtProductoExterno.Name = "TxtProductoExterno"
        Me.TxtProductoExterno.ReadOnly = True
        Me.TxtProductoExterno.Size = New System.Drawing.Size(208, 20)
        Me.TxtProductoExterno.SoloLetra = False
        Me.TxtProductoExterno.SoloNumero = False
        Me.TxtProductoExterno.TabIndex = 113
        Me.TxtProductoExterno.TabStop = False
        '
        'TxtCodProductoExterno
        '
        Me.TxtCodProductoExterno.AcceptsReturn = True
        Me.TxtCodProductoExterno.AcceptsTab = True
        Me.TxtCodProductoExterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodProductoExterno.ConDecimal = False
        Me.TxtCodProductoExterno.Location = New System.Drawing.Point(59, 49)
        Me.TxtCodProductoExterno.Maximo = 0
        Me.TxtCodProductoExterno.MaxLength = 5
        Me.TxtCodProductoExterno.Name = "TxtCodProductoExterno"
        Me.TxtCodProductoExterno.ReadOnly = True
        Me.TxtCodProductoExterno.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodProductoExterno.SoloLetra = False
        Me.TxtCodProductoExterno.SoloNumero = True
        Me.TxtCodProductoExterno.TabIndex = 110
        '
        'lblProductoExterno
        '
        Me.lblProductoExterno.AutoSize = True
        Me.lblProductoExterno.Location = New System.Drawing.Point(8, 51)
        Me.lblProductoExterno.Name = "lblProductoExterno"
        Me.lblProductoExterno.Size = New System.Drawing.Size(50, 13)
        Me.lblProductoExterno.TabIndex = 112
        Me.lblProductoExterno.Text = "Producto"
        '
        'lblDesClienteExterno
        '
        Me.lblDesClienteExterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesClienteExterno.Enabled = False
        Me.lblDesClienteExterno.Image = CType(resources.GetObject("lblDesClienteExterno.Image"), System.Drawing.Image)
        Me.lblDesClienteExterno.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesClienteExterno.Location = New System.Drawing.Point(314, 24)
        Me.lblDesClienteExterno.Name = "lblDesClienteExterno"
        Me.lblDesClienteExterno.Size = New System.Drawing.Size(21, 21)
        Me.lblDesClienteExterno.TabIndex = 107
        Me.lblDesClienteExterno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtClienteExterno
        '
        Me.txtClienteExterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteExterno.ConDecimal = False
        Me.txtClienteExterno.Location = New System.Drawing.Point(103, 24)
        Me.txtClienteExterno.Maximo = 0
        Me.txtClienteExterno.Name = "txtClienteExterno"
        Me.txtClienteExterno.ReadOnly = True
        Me.txtClienteExterno.Size = New System.Drawing.Size(208, 20)
        Me.txtClienteExterno.SoloLetra = False
        Me.txtClienteExterno.SoloNumero = False
        Me.txtClienteExterno.TabIndex = 109
        Me.txtClienteExterno.TabStop = False
        '
        'txtCodClienteExterno
        '
        Me.txtCodClienteExterno.AcceptsReturn = True
        Me.txtCodClienteExterno.AcceptsTab = True
        Me.txtCodClienteExterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodClienteExterno.ConDecimal = False
        Me.txtCodClienteExterno.Location = New System.Drawing.Point(59, 24)
        Me.txtCodClienteExterno.Maximo = 0
        Me.txtCodClienteExterno.MaxLength = 5
        Me.txtCodClienteExterno.Name = "txtCodClienteExterno"
        Me.txtCodClienteExterno.ReadOnly = True
        Me.txtCodClienteExterno.Size = New System.Drawing.Size(40, 20)
        Me.txtCodClienteExterno.SoloLetra = False
        Me.txtCodClienteExterno.SoloNumero = True
        Me.txtCodClienteExterno.TabIndex = 106
        '
        'lblClienteExterno
        '
        Me.lblClienteExterno.AutoSize = True
        Me.lblClienteExterno.Location = New System.Drawing.Point(8, 26)
        Me.lblClienteExterno.Name = "lblClienteExterno"
        Me.lblClienteExterno.Size = New System.Drawing.Size(39, 13)
        Me.lblClienteExterno.TabIndex = 108
        Me.lblClienteExterno.Text = "Cliente"
        '
        'frmABMClienteExterno
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(354, 359)
        Me.Controls.Add(Me.gbExterno)
        Me.Controls.Add(Me.gbSigeme)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmConfirmacionAvisos_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMClienteExterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Clientes Externos"
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSigeme.ResumeLayout(False)
        Me.gbSigeme.PerformLayout()
        Me.gbExterno.ResumeLayout(False)
        Me.gbExterno.PerformLayout()
        Me.pnlProductos.ResumeLayout(False)
        Me.pnlProductos_Fill_Panel.ResumeLayout(False)
        CType(Me.ugProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private Productos As DataSet
    Private ProductosOriginal As DataSet
#End Region

#Region "Eventos"
    Private Sub frmABMClienteExterno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LimpiarControles()
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        Call txtCliente_TextChanged()
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
                    lblDesProducto.Enabled = True
                    txtCodClienteExterno.ReadOnly = False
                    lblDesClienteExterno.Enabled = True

                    Call CargarClienteExterno(CodigoCliente)
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
        Dim CodCliente As String = txtCodCliente.Text.Trim
        If CodCliente <> String.Empty Then
            Call CargarClienteExterno(CodCliente)
        End If
    End Sub

    Private Sub TxtProducto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProducto.TextChanged
        Dim Producto As String = TxtProducto.Text.Trim
        TxtCodProductoExterno.Text = String.Empty
        TxtProductoExterno.Text = String.Empty
        TxtCodProductoExterno.ReadOnly = True
        lblDesProductoExterno.Enabled = False
        If Producto <> "" Then
            txtCodClienteExterno.ReadOnly = False
            lblDesClienteExterno.Enabled = True
        Else
            txtCodClienteExterno.ReadOnly = True
            lblDesClienteExterno.Enabled = False
        End If
    End Sub

    Private Sub TxtCodProducto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProducto.Validated
        Dim CodigoProducto As String = TxtCodProducto.Text.Trim
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        Call LimpiarProductos()
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
                    If txtClienteExterno.Text.Trim <> String.Empty Then
                        TxtCodProductoExterno.ReadOnly = False
                        lblDesProductoExterno.Enabled = True
                        Call CargarProductoExterno(CodigoCliente, CodigoProducto)
                    End If
                End If

            Catch ex As Exception
                Mensajes.Mensaje("El Producto No Existe o No Pertenece al Cliente Selccionado")
                TxtCodProducto.Text = ""
                TxtCodProducto.Select()
                Exit Sub
            End Try
        Else
            TxtProducto.Text = String.Empty
            TxtCodProductoExterno.Text = String.Empty
            TxtProductoExterno.Text = String.Empty
            TxtCodProductoExterno.ReadOnly = True
            lblDesProductoExterno.Enabled = False
        End If
    End Sub

    Private Sub lblDesProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesProducto.Click
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoCliente <> String.Empty Then
            Dim Busqueda As New frmBuscar
            Busqueda.CargarFormulario(SeccionActiva.Producto, TxtProducto, TxtCodProducto, "id_producto", "descripcion", "Código", "Producto", CodigoCliente)
            Busqueda.ShowDialog()
            Dim CodigoProducto As String = TxtCodProducto.Text.Trim
            If CodigoProducto <> String.Empty Then
                If txtClienteExterno.Text.Trim <> String.Empty Then
                    TxtCodProductoExterno.ReadOnly = False
                    lblDesProductoExterno.Enabled = True
                    Call CargarProductoExterno(CodigoCliente, CodigoProducto)
                End If
            End If
        End If
    End Sub

    Private Sub txtClienteExterno_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClienteExterno.TextChanged
        Dim ClienteExterno As String = txtClienteExterno.Text.Trim
        TxtCodProductoExterno.Text = String.Empty
        TxtProductoExterno.Text = String.Empty
        Call LimpiarProductos()
        If ClienteExterno <> "" And TxtProducto.Text.Trim <> String.Empty Then
            TxtCodProductoExterno.ReadOnly = False
            lblDesProductoExterno.Enabled = True
        Else
            TxtCodProductoExterno.ReadOnly = True
            lblDesProductoExterno.Enabled = False
        End If
    End Sub

    Private Sub txtCodClienteExterno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodClienteExterno.Validated
        Call txtCodClienteExterno_Validated()
    End Sub

    Private Sub lblDesClienteExterno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesClienteExterno.Click
        Dim Busqueda As New frmBuscar
        Busqueda.CargarFormulario(SeccionActiva.Anunciantes, txtClienteExterno, txtCodClienteExterno, "can_anu", "nom_anu", "Código", "Cliente")
        Busqueda.ShowDialog()
    End Sub

    Private Sub TxtCodProductoExterno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProductoExterno.LostFocus
        Dim CodigoProductoExterno As String = TxtCodProductoExterno.Text.Trim
        Dim CodigoClienteExterno As String = txtCodClienteExterno.Text.Trim
        If CodigoProductoExterno <> String.Empty AndAlso CodigoClienteExterno <> String.Empty Then
            Dim ProdExterno As New Control_Macheo
            Dim ProductoExterno As New DataTable

            Try
                ProdExterno.Cod_Cli = CodigoClienteExterno
                ProductoExterno = ProdExterno.BuscarSpots(Nothing)

                If ProductoExterno Is Nothing OrElse ProductoExterno.Rows.Count = 0 OrElse ProductoExterno.Select("Cod_Sps = " & CodigoProductoExterno).Length = 0 Then
                    Mensajes.Mensaje("El Producto No Existe  o No Pertenece al Cliente Selccionado")
                    TxtCodProductoExterno.Text = ""
                    TxtCodProductoExterno.Select()
                    Exit Sub
                Else
                    TxtProductoExterno.Text = ProductoExterno.Select("Cod_Sps = " & CodigoProductoExterno)(0)("Nom_Sps")
                End If

            Catch ex As Exception
                Mensajes.Mensaje("El Producto No Existe o No Pertenece al Cliente Selccionado")
                TxtCodProductoExterno.Text = ""
                TxtCodProductoExterno.Select()
                Exit Sub
            End Try
        Else
            TxtProductoExterno.Text = String.Empty
        End If
    End Sub

    Private Sub lblDesProductoExterno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesProductoExterno.Click
        Dim CodigoClienteExterno As String = txtCodClienteExterno.Text.Trim
        If CodigoClienteExterno <> String.Empty Then
            Dim Busqueda As New frmBuscarPorPeriodo
            Busqueda.CargarFormulario(SeccionActiva.ProductoExterno, TxtProductoExterno, TxtCodProductoExterno, "Cod_Sps", "Nom_Sps", "Fec_Spt", "Fec_Spt", "Código", "Producto", CodigoClienteExterno)
            Busqueda.ShowDialog()
        End If
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Guardar"
                Call Guardar()
            Case "Eliminar"
                Call Eliminar()
            Case "Reiniciar"
                Call LimpiarControles()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub UltraToolbarsManager2_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager2.ToolClick
        Select Case e.Tool.Key
            Case "Agregar"
                Call AgregarProductoGrilla()
            Case "Eliminar"
                Call EliminarProductoGrilla()
        End Select
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub CargarClienteExterno(ByVal pCodigoCliente As Double)
        Dim ControlMacheo As New Control_Macheo
        Dim ClienteExterno As DataSet

        ControlMacheo.Cod_Cli = pCodigoCliente
        ClienteExterno = ControlMacheo.BuscarAr_Clientes_Sig_Nau()
        If Not ClienteExterno Is Nothing AndAlso ClienteExterno.Tables.Count > 0 AndAlso Not ClienteExterno.Tables(0) Is Nothing AndAlso ClienteExterno.Tables(0).Rows.Count > 0 Then
            txtCodClienteExterno.Text = ClienteExterno.Tables(0).Rows(0)("Cod_Cli_Nau")
            Call txtCodClienteExterno_Validated()
        End If
    End Sub

    Private Sub CargarProductoExterno(ByVal pCodigoCliente As Double, ByVal pCodigoProducto As Double)
        Dim ControlMacheo As New Control_Macheo
        Dim ProductoExterno As DataSet
        Dim Producto As DataRow
        Dim ProductoExternoCliente As DataTable
        Dim ClienteNau, ProductoNau As String

        ControlMacheo.Cod_Cli = pCodigoCliente
        ControlMacheo.Cod_Prod = pCodigoProducto
        ProductoExterno = ControlMacheo.BuscarAr_Productos_Sig_Nau()

        If Not ProductoExterno Is Nothing AndAlso ProductoExterno.Tables.Count > 0 AndAlso Not ProductoExterno.Tables(0) Is Nothing AndAlso ProductoExterno.Tables(0).Rows.Count > 0 Then
            ClienteNau = txtCodClienteExterno.Text.Trim

            For Each ProdExterno As DataRow In ProductoExterno.Tables(0).Rows
                Producto = Productos.Tables(0).NewRow
                For Each Columns As DataColumn In ProductoExterno.Tables(0).Columns
                    Producto(Columns.ColumnName) = ProdExterno(Columns.ColumnName)
                Next

                ProductoNau = ProdExterno("Cod_prod_Nau")

                If ClienteNau <> String.Empty Then
                    ControlMacheo.Cod_Cli = ClienteNau
                    ProductoExternoCliente = ControlMacheo.BuscarSpots(ProductoNau)
                End If

                If Not ProductoExternoCliente Is Nothing AndAlso ProductoExternoCliente.Rows.Count > 0 Then
                    Producto("Nom_Prod") = ProductoExternoCliente.Rows(0)("NOM_SPS").ToString()
                End If
                Productos.Tables(0).Rows.Add(Producto)
            Next

        End If

        'JJP 24062010 OLD CODE
        'If Not ProductoExterno Is Nothing AndAlso ProductoExterno.Tables.Count > 0 AndAlso Not ProductoExterno.Tables(0) Is Nothing AndAlso ProductoExterno.Tables(0).Rows.Count > 0 Then
        '    ClienteNau = txtCodClienteExterno.Text.Trim
        '    If ClienteNau <> String.Empty Then
        '        ControlMacheo.Cod_Cli = ClienteNau
        '        ProductoExternoCliente = ControlMacheo.BuscarSpots
        '    End If

        '    For Each ProdExterno As DataRow In ProductoExterno.Tables(0).Rows
        '        Producto = Productos.Tables(0).NewRow
        '        For Each Columns As DataColumn In ProductoExterno.Tables(0).Columns
        '            Producto(Columns.ColumnName) = ProdExterno(Columns.ColumnName)
        '        Next
        '        ProductoNau = ProdExterno("Cod_prod_Nau")
        '        If Not ProductoExternoCliente Is Nothing AndAlso ProductoExternoCliente.Select("Cod_Sps = " & ProductoNau).Length > 0 Then
        '            Producto("Nom_Prod") = ProductoExternoCliente.Select("Cod_Sps = " & ProductoNau)(0).Item("Nom_Sps")
        '        End If
        '        Productos.Tables(0).Rows.Add(Producto)
        '    Next
        'End If

        ProductosOriginal = Productos.Copy
        ugProductos.DataSource = Productos
        ugProductos.DataBind()
    End Sub

    Private Sub ObtenerEstructuraProductos(ByRef pProductos As DataSet)
        pProductos = New DataSet
        Dim Producto As New DataTable
        For Each Columns As UltraGridColumn In ugProductos.DisplayLayout.Bands(0).Columns
            Producto.Columns.Add(Columns.Key, Columns.DataType)
        Next
        pProductos.Tables.Add(Producto)
    End Sub

    Private Sub LimpiarControles()
        txtCodCliente.Text = String.Empty
        txtCliente.Text = String.Empty
        Call txtCliente_TextChanged()
    End Sub

    Private Sub LimpiarProductos()
        If Productos Is Nothing Then
            Call ObtenerEstructuraProductos(Productos)
        End If
        Productos.Tables(0).Rows.Clear()
        ProductosOriginal = Productos.Copy
        ugProductos.DataSource = Productos
        ugProductos.DataBind()
    End Sub

    Private Sub AgregarProductoGrilla()
        Dim CodProductoExterno As String = TxtCodProductoExterno.Text.Trim
        Dim Cantidad As Integer
        Dim Filtro As New StringBuilder
        Dim Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau As Double

        If CodProductoExterno <> String.Empty Then
            Dim Producto As DataRow
            Cod_Cli_Sig = txtCodCliente.Text.Trim
            Cod_Cli_Nau = txtCodClienteExterno.Text.Trim
            Cod_Prod_Sig = TxtCodProducto.Text.Trim
            Cod_Prod_Nau = TxtCodProductoExterno.Text.Trim
            Filtro.Append("Cod_Cli_Sig = ")
            Filtro.Append(Cod_Cli_Sig)
            Filtro.Append(" and Cod_Cli_Nau = ")
            Filtro.Append(Cod_Cli_Nau)
            Filtro.Append(" and Cod_Prod_Sig = ")
            Filtro.Append(Cod_Prod_Sig)
            Filtro.Append(" and Cod_Prod_Nau = ")
            Filtro.Append(Cod_Prod_Nau)

            Cantidad = Productos.Tables(0).Select(Filtro.ToString()).Length

            If Cantidad <= 0 Then
                Producto = Productos.Tables(0).NewRow
                Producto("Cod_Cli_Sig") = Cod_Cli_Sig
                Producto("Cod_Cli_Nau") = Cod_Cli_Nau
                Producto("Cod_Prod_Sig") = Cod_Prod_Sig
                Producto("Cod_Prod_Nau") = Cod_Prod_Nau
                Producto("Nom_Prod") = TxtProductoExterno.Text.Trim
                Productos.Tables(0).Rows.Add(Producto)

                TxtCodProductoExterno.Text = String.Empty
                TxtProductoExterno.Text = String.Empty
            Else
                Mensaje("El Producto ya ha sido ingresado.")
            End If
        Else
            Mensaje("Debe ingresar un Producto Externo.")
        End If
    End Sub

    Private Sub EliminarProductoGrilla()
        Dim Seleccionados As New SortedList
        Dim CantidadSeleccionados As Integer

        If ugProductos.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un Producto a eliminar.")
            Exit Sub
        End If
        For Each RowSeleccionada As UltraGridRow In ugProductos.Selected.Rows
            If Not Seleccionados.ContainsKey(RowSeleccionada.Index) Then
                Seleccionados.Add(RowSeleccionada.Index, RowSeleccionada.Index)
            End If
        Next

        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            Productos.Tables(0).Rows(Seleccionados.GetKey(Index)).Delete()
        Next
    End Sub

    Private Sub Guardar()
        Dim Filtro As StringBuilder
        Dim Cantidad As Integer
        Dim Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau As Double
        Dim ControlMacheo As New Control_Macheo
        Dim ClienteExterno, ProductoExterno As DataSet
        Dim CodCliente, CodClienteExterno, CodProducto As String

        CodCliente = txtCodCliente.Text.Trim
        CodClienteExterno = txtCodClienteExterno.Text.Trim
        If CodCliente = String.Empty OrElse CodClienteExterno = String.Empty Then
            Mensaje("No hay datos seleccionados para guardar.")
        Else
            ControlMacheo.Cod_Cli = CodCliente
            ClienteExterno = ControlMacheo.BuscarAr_Clientes_Sig_Nau()

            If Not ClienteExterno Is Nothing AndAlso ClienteExterno.Tables.Count > 0 AndAlso Not ClienteExterno.Tables(0) Is Nothing AndAlso ClienteExterno.Tables(0).Rows.Count > 0 Then
                'El cliente seleccionado de sigeme tiene asociado un cliente en Nautilus
                If CodClienteExterno <> ClienteExterno.Tables(0).Rows(0)("Cod_Cli_Nau") Then
                    'Se cambio de cliente 
                    'Elimina todos los productos asociados al cliente anterior
                    ControlMacheo.Cod_Cli = CodCliente
                    ControlMacheo.Cod_Prod = 0
                    ProductoExterno = ControlMacheo.BuscarAr_Productos_Sig_Nau()

                    If Not ProductoExterno Is Nothing AndAlso ProductoExterno.Tables.Count > 0 AndAlso Not ProductoExterno.Tables(0) Is Nothing AndAlso ProductoExterno.Tables(0).Rows.Count > 0 Then
                        For Each ProdExterno As DataRow In ProductoExterno.Tables(0).Rows
                            Cod_Cli_Sig = ProdExterno("Cod_Cli_Sig")
                            Cod_Cli_Nau = ProdExterno("Cod_Cli_Nau")
                            Cod_Prod_Sig = ProdExterno("Cod_Prod_Sig")
                            Cod_Prod_Nau = ProdExterno("Cod_Prod_Nau")

                            ControlMacheo.EliminarAr_Productos_Sig_Nau(Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau)
                        Next
                    End If
                    'Actualiza cliente de Nautilus
                    Call ControlMacheo.ActualizarAr_Clientes_Sig_Nau(CodCliente, ClienteExterno.Tables(0).Rows(0)("Cod_Cli_Nau"), CodClienteExterno)
                End If
            Else
                'El cliente seleccionado de sigeme no tiene asociado un cliente de Nautilus - Agrega cliente de Nautilus
                Call ControlMacheo.AgregarAr_Clientes_Sig_Nau(CodCliente, CodClienteExterno)
            End If

            'Verifica si se ha ingresado un codigo de producto
            CodProducto = TxtCodProducto.Text.Trim
            If CodProducto <> String.Empty Then
                For Each ProductoOriginal As DataRow In ProductosOriginal.Tables(0).Rows
                    Cod_Cli_Sig = ProductoOriginal("Cod_Cli_Sig")
                    Cod_Cli_Nau = ProductoOriginal("Cod_Cli_Nau")
                    Cod_Prod_Sig = ProductoOriginal("Cod_Prod_Sig")
                    Cod_Prod_Nau = ProductoOriginal("Cod_Prod_Nau")
                    Filtro = New StringBuilder
                    Filtro.Append("Cod_Cli_Sig = ")
                    Filtro.Append(Cod_Cli_Sig)
                    Filtro.Append(" and Cod_Cli_Nau = ")
                    Filtro.Append(Cod_Cli_Nau)
                    Filtro.Append(" and Cod_Prod_Sig = ")
                    Filtro.Append(Cod_Prod_Sig)
                    Filtro.Append(" and Cod_Prod_Nau = ")
                    Filtro.Append(Cod_Prod_Nau)

                    Cantidad = Productos.Tables(0).Select(Filtro.ToString).Length
                    If Cantidad = 0 Then 'Se elimino un producto que ya existia
                        'Elimina Producto
                        ControlMacheo.EliminarAr_Productos_Sig_Nau(Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau)
                    End If
                Next
                For Each Producto As DataRow In Productos.Tables(0).Rows
                    Cod_Cli_Sig = Producto("Cod_Cli_Sig")
                    Cod_Cli_Nau = Producto("Cod_Cli_Nau")
                    Cod_Prod_Sig = Producto("Cod_Prod_Sig")
                    Cod_Prod_Nau = Producto("Cod_Prod_Nau")
                    Filtro = New StringBuilder
                    Filtro.Append("Cod_Cli_Sig = ")
                    Filtro.Append(Cod_Cli_Sig)
                    Filtro.Append(" and Cod_Cli_Nau = ")
                    Filtro.Append(Cod_Cli_Nau)
                    Filtro.Append(" and Cod_Prod_Sig = ")
                    Filtro.Append(Cod_Prod_Sig)
                    Filtro.Append(" and Cod_Prod_Nau = ")
                    Filtro.Append(Cod_Prod_Nau)

                    Cantidad = ProductosOriginal.Tables(0).Select(Filtro.ToString).Length
                    If Cantidad = 0 Then 'Se agrego un producto nuevo
                        'Agrega Producto
                        ControlMacheo.AgregarAr_Productos_Sig_Nau(Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau)
                    End If
                Next
            End If
            Mensaje("La grabación se realizó con éxito.")
            Call LimpiarControles()
        End If
    End Sub

    Private Sub Eliminar()
        Dim ControlMacheo As New Control_Macheo
        Dim ProductoExterno As DataSet
        Dim CodCliente, CodClienteExterno, CodProducto As String
        Dim Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau As Double

        CodCliente = txtCodCliente.Text.Trim
        CodClienteExterno = txtCodClienteExterno.Text.Trim
        If CodCliente = String.Empty OrElse CodClienteExterno = String.Empty Then
            Mensaje("No hay datos seleccionados para eliminar.")
        Else
            'Verifica si se ha ingresado un codigo de producto
            CodProducto = TxtCodProducto.Text.Trim
            If CodProducto <> String.Empty Then
                'Elimina solo los productos asociados al cliente
                For Each ProductoOriginal As DataRow In ProductosOriginal.Tables(0).Rows
                    Cod_Cli_Sig = ProductoOriginal("Cod_Cli_Sig")
                    Cod_Cli_Nau = ProductoOriginal("Cod_Cli_Nau")
                    Cod_Prod_Sig = ProductoOriginal("Cod_Prod_Sig")
                    Cod_Prod_Nau = ProductoOriginal("Cod_Prod_Nau")

                    ControlMacheo.EliminarAr_Productos_Sig_Nau(Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau)
                Next
            Else
                'Elimina todos los productos asociados al cliente
                ControlMacheo.Cod_Cli = CodCliente
                ControlMacheo.Cod_Prod = 0
                ProductoExterno = ControlMacheo.BuscarAr_Productos_Sig_Nau()

                If Not ProductoExterno Is Nothing AndAlso ProductoExterno.Tables.Count > 0 AndAlso Not ProductoExterno.Tables(0) Is Nothing AndAlso ProductoExterno.Tables(0).Rows.Count > 0 Then
                    For Each ProdExterno As DataRow In ProductoExterno.Tables(0).Rows
                        Cod_Cli_Sig = ProdExterno("Cod_Cli_Sig")
                        Cod_Cli_Nau = ProdExterno("Cod_Cli_Nau")
                        Cod_Prod_Sig = ProdExterno("Cod_Prod_Sig")
                        Cod_Prod_Nau = ProdExterno("Cod_Prod_Nau")

                        ControlMacheo.EliminarAr_Productos_Sig_Nau(Cod_Cli_Sig, Cod_Cli_Nau, Cod_Prod_Sig, Cod_Prod_Nau)
                    Next
                End If
                'Elimina el cliente asociado
                Call ControlMacheo.EliminarAr_Clientes_Sig_Nau(CodCliente, CodClienteExterno)
            End If
            Mensaje("La eliminación se realizó con éxito.")
            Call LimpiarControles()
        End If
    End Sub

    Private Sub txtCodClienteExterno_Validated()
        Dim CodigoClienteExterno As String = txtCodClienteExterno.Text.Trim
        If CodigoClienteExterno <> "" Then
            Dim ClienteExterno As New Control_Macheo
            Dim ClieExterno As DataTable
            Try
                ClieExterno = ClienteExterno.BuscarAnunciantes(CodigoClienteExterno)
                If ClieExterno Is Nothing OrElse ClieExterno.Rows.Count = 0 Then
                    Mensajes.Mensaje("El Cliente No Existe.")
                    txtCodClienteExterno.Text = String.Empty
                    txtCodClienteExterno.Select()
                    Exit Sub
                Else
                    txtClienteExterno.Text = ClieExterno.Rows(0)("Nom_Anu")
                    If TxtProducto.Text.Trim <> String.Empty Then
                        TxtCodProductoExterno.ReadOnly = False
                        lblDesProductoExterno.Enabled = True
                    End If
                End If
            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                txtClienteExterno.Text = String.Empty
                txtCodClienteExterno.Text = String.Empty
                txtCodClienteExterno.Select()
                Exit Sub
            End Try
        Else
            txtClienteExterno.Text = String.Empty
        End If
    End Sub

    Private Sub txtCliente_TextChanged()
        Dim Cliente As String = txtCliente.Text.Trim
        TxtCodProducto.Text = String.Empty
        TxtProducto.Text = String.Empty
        txtCodClienteExterno.Text = String.Empty
        txtClienteExterno.Text = String.Empty
        TxtCodProductoExterno.Text = String.Empty
        TxtProductoExterno.Text = String.Empty
        TxtCodProductoExterno.ReadOnly = True
        lblDesProductoExterno.Enabled = False
        Call LimpiarProductos()
        If Cliente <> String.Empty Then
            TxtCodProducto.ReadOnly = False
            lblDesProducto.Enabled = True
            txtCodClienteExterno.ReadOnly = False
            lblDesClienteExterno.Enabled = True
        Else
            TxtCodProducto.ReadOnly = True
            lblDesProducto.Enabled = False
            txtCodClienteExterno.ReadOnly = True
            lblDesClienteExterno.Enabled = False
        End If
    End Sub
#End Region

End Class

Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Excel

Public Class frmAudienciaRadio
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
    Friend WithEvents utmAudiencia As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents frmAudienciaRadio_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _frmAudienciaRadio_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAudienciaRadio_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAudienciaRadio_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmAudienciaRadio_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents pnlGeneral As System.Windows.Forms.Panel
    Friend WithEvents TabAudiencia As System.Windows.Forms.TabControl
    Friend WithEvents lblPeriodoAudiencia As System.Windows.Forms.Label
    Friend WithEvents emisora As System.Windows.Forms.TabPage
    Friend WithEvents bloque As System.Windows.Forms.TabPage
    Friend WithEvents btnSiguienteEmisoras As System.Windows.Forms.Button
    Friend WithEvents generales As System.Windows.Forms.TabPage
    Friend WithEvents lEmisorasFM As System.Windows.Forms.CheckedListBox
    Friend WithEvents lEmisorasAM As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblEmisorasFM As System.Windows.Forms.Label
    Friend WithEvents lblEmisorasAM As System.Windows.Forms.Label
    Friend WithEvents btnEmisorasAgregarSeleccionadas As System.Windows.Forms.Button
    Friend WithEvents btnEmisorasRetirarTodas As System.Windows.Forms.Button
    Friend WithEvents btnEmisorasAgregarTodasAM As System.Windows.Forms.Button
    Friend WithEvents btnEmisorasAgregarTodasFM As System.Windows.Forms.Button
    Friend WithEvents btnSiguienteBloques As System.Windows.Forms.Button
    Friend WithEvents ugEmisoras As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnAnteriorDatosGenerales As System.Windows.Forms.Button
    Friend WithEvents btnAnteriorEmisoras As System.Windows.Forms.Button
    Friend WithEvents lblHoraDesde As System.Windows.Forms.Label
    Friend WithEvents lblHoraHasta As System.Windows.Forms.Label
    Friend WithEvents ugBloques As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnAgregarBloque As System.Windows.Forms.Button
    Friend WithEvents btnRetirarBloque As System.Windows.Forms.Button
    Friend WithEvents btnCuartos As System.Windows.Forms.Button
    Friend WithEvents btnHoras As System.Windows.Forms.Button
    Friend WithEvents txtHoraDesde As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraHasta As System.Windows.Forms.TextBox
    Friend WithEvents lblTarget As System.Windows.Forms.Label
    Friend WithEvents cboAudienciaRadio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTarget As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnAgregarFranja As System.Windows.Forms.Button
    Friend WithEvents gbDias As System.Windows.Forms.GroupBox
    Friend WithEvents pnlPeriodo As System.Windows.Forms.Panel
    Friend WithEvents chkLV As System.Windows.Forms.CheckBox
    Friend WithEvents chkS As System.Windows.Forms.CheckBox
    Friend WithEvents chkD As System.Windows.Forms.CheckBox
    Friend WithEvents chkSD As System.Windows.Forms.CheckBox
    Friend WithEvents chkDias As System.Windows.Forms.CheckBox
    Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
    Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
    Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
    Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
    Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
    Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utAudiencia")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Procesar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Procesar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Emisora_Id", 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion", 1)
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraDesde", 0)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraHasta", 1)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bloque", 2)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.utmAudiencia = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.frmAudienciaRadio_Fill_Panel = New System.Windows.Forms.Panel
        Me.pnlGeneral = New System.Windows.Forms.Panel
        Me.TabAudiencia = New System.Windows.Forms.TabControl
        Me.generales = New System.Windows.Forms.TabPage
        Me.gbDias = New System.Windows.Forms.GroupBox
        Me.chkDomingo = New System.Windows.Forms.CheckBox
        Me.chkSabado = New System.Windows.Forms.CheckBox
        Me.chkViernes = New System.Windows.Forms.CheckBox
        Me.chkJueves = New System.Windows.Forms.CheckBox
        Me.chkMiercoles = New System.Windows.Forms.CheckBox
        Me.chkMartes = New System.Windows.Forms.CheckBox
        Me.chkLunes = New System.Windows.Forms.CheckBox
        Me.chkDias = New System.Windows.Forms.CheckBox
        Me.chkSD = New System.Windows.Forms.CheckBox
        Me.chkD = New System.Windows.Forms.CheckBox
        Me.chkS = New System.Windows.Forms.CheckBox
        Me.chkLV = New System.Windows.Forms.CheckBox
        Me.cboTarget = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cboAudienciaRadio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblTarget = New System.Windows.Forms.Label
        Me.btnSiguienteEmisoras = New System.Windows.Forms.Button
        Me.lblPeriodoAudiencia = New System.Windows.Forms.Label
        Me.emisora = New System.Windows.Forms.TabPage
        Me.btnAnteriorDatosGenerales = New System.Windows.Forms.Button
        Me.ugEmisoras = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnSiguienteBloques = New System.Windows.Forms.Button
        Me.btnEmisorasAgregarTodasAM = New System.Windows.Forms.Button
        Me.btnEmisorasAgregarTodasFM = New System.Windows.Forms.Button
        Me.btnEmisorasRetirarTodas = New System.Windows.Forms.Button
        Me.btnEmisorasAgregarSeleccionadas = New System.Windows.Forms.Button
        Me.lblEmisorasAM = New System.Windows.Forms.Label
        Me.lblEmisorasFM = New System.Windows.Forms.Label
        Me.lEmisorasAM = New System.Windows.Forms.CheckedListBox
        Me.lEmisorasFM = New System.Windows.Forms.CheckedListBox
        Me.bloque = New System.Windows.Forms.TabPage
        Me.btnAgregarFranja = New System.Windows.Forms.Button
        Me.txtHoraHasta = New System.Windows.Forms.TextBox
        Me.txtHoraDesde = New System.Windows.Forms.TextBox
        Me.btnHoras = New System.Windows.Forms.Button
        Me.btnCuartos = New System.Windows.Forms.Button
        Me.btnRetirarBloque = New System.Windows.Forms.Button
        Me.btnAgregarBloque = New System.Windows.Forms.Button
        Me.ugBloques = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lblHoraHasta = New System.Windows.Forms.Label
        Me.lblHoraDesde = New System.Windows.Forms.Label
        Me.btnAnteriorEmisoras = New System.Windows.Forms.Button
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        CType(Me.utmAudiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAudienciaRadio_Fill_Panel.SuspendLayout()
        Me.pnlGeneral.SuspendLayout()
        Me.TabAudiencia.SuspendLayout()
        Me.generales.SuspendLayout()
        Me.gbDias.SuspendLayout()
        CType(Me.cboTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAudienciaRadio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.emisora.SuspendLayout()
        CType(Me.ugEmisoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bloque.SuspendLayout()
        CType(Me.ugBloques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'utmAudiencia
        '
        Me.utmAudiencia.DesignerFlags = 1
        Me.utmAudiencia.DockWithinContainer = Me
        Me.utmAudiencia.LockToolbars = True
        Me.utmAudiencia.ShowFullMenusDelay = 500
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
        UltraToolbar1.Text = "utAudiencia"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4})
        Me.utmAudiencia.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool5.SharedProps.Caption = "Procesar"
        ButtonTool6.SharedProps.Caption = "Salir"
        ButtonTool7.SharedProps.Caption = "Limpiar"
        ButtonTool8.SharedProps.Caption = "Exportar"
        Me.utmAudiencia.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5, ButtonTool6, ButtonTool7, ButtonTool8})
        '
        'frmAudienciaRadio_Fill_Panel
        '
        Me.frmAudienciaRadio_Fill_Panel.Controls.Add(Me.pnlGeneral)
        Me.frmAudienciaRadio_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmAudienciaRadio_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAudienciaRadio_Fill_Panel.Location = New System.Drawing.Point(0, 22)
        Me.frmAudienciaRadio_Fill_Panel.Name = "frmAudienciaRadio_Fill_Panel"
        Me.frmAudienciaRadio_Fill_Panel.Size = New System.Drawing.Size(656, 415)
        Me.frmAudienciaRadio_Fill_Panel.TabIndex = 0
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.TabAudiencia)
        Me.pnlGeneral.Location = New System.Drawing.Point(4, 7)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(644, 401)
        Me.pnlGeneral.TabIndex = 79
        '
        'TabAudiencia
        '
        Me.TabAudiencia.Controls.Add(Me.generales)
        Me.TabAudiencia.Controls.Add(Me.emisora)
        Me.TabAudiencia.Controls.Add(Me.bloque)
        Me.TabAudiencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAudiencia.Location = New System.Drawing.Point(0, 0)
        Me.TabAudiencia.Name = "TabAudiencia"
        Me.TabAudiencia.SelectedIndex = 0
        Me.TabAudiencia.Size = New System.Drawing.Size(644, 401)
        Me.TabAudiencia.TabIndex = 0
        '
        'generales
        '
        Me.generales.Controls.Add(Me.gbDias)
        Me.generales.Controls.Add(Me.cboTarget)
        Me.generales.Controls.Add(Me.cboAudienciaRadio)
        Me.generales.Controls.Add(Me.lblTarget)
        Me.generales.Controls.Add(Me.btnSiguienteEmisoras)
        Me.generales.Controls.Add(Me.lblPeriodoAudiencia)
        Me.generales.Location = New System.Drawing.Point(4, 22)
        Me.generales.Name = "generales"
        Me.generales.Size = New System.Drawing.Size(636, 375)
        Me.generales.TabIndex = 0
        Me.generales.Text = "Datos Generales"
        '
        'gbDias
        '
        Me.gbDias.Controls.Add(Me.chkDomingo)
        Me.gbDias.Controls.Add(Me.chkSabado)
        Me.gbDias.Controls.Add(Me.chkViernes)
        Me.gbDias.Controls.Add(Me.chkJueves)
        Me.gbDias.Controls.Add(Me.chkMiercoles)
        Me.gbDias.Controls.Add(Me.chkMartes)
        Me.gbDias.Controls.Add(Me.chkLunes)
        Me.gbDias.Controls.Add(Me.chkDias)
        Me.gbDias.Controls.Add(Me.chkSD)
        Me.gbDias.Controls.Add(Me.chkD)
        Me.gbDias.Controls.Add(Me.chkS)
        Me.gbDias.Controls.Add(Me.chkLV)
        Me.gbDias.Location = New System.Drawing.Point(8, 56)
        Me.gbDias.Name = "gbDias"
        Me.gbDias.Size = New System.Drawing.Size(624, 168)
        Me.gbDias.TabIndex = 7
        Me.gbDias.TabStop = False
        Me.gbDias.Text = "Reportes - Días"
        '
        'chkDomingo
        '
        Me.chkDomingo.Location = New System.Drawing.Point(404, 136)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(72, 24)
        Me.chkDomingo.TabIndex = 11
        Me.chkDomingo.Text = "Domingo"
        '
        'chkSabado
        '
        Me.chkSabado.Location = New System.Drawing.Point(338, 136)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(64, 24)
        Me.chkSabado.TabIndex = 10
        Me.chkSabado.Text = "Sabado"
        '
        'chkViernes
        '
        Me.chkViernes.Location = New System.Drawing.Point(275, 136)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(64, 24)
        Me.chkViernes.TabIndex = 9
        Me.chkViernes.Text = "Viernes"
        '
        'chkJueves
        '
        Me.chkJueves.Location = New System.Drawing.Point(213, 136)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(60, 24)
        Me.chkJueves.TabIndex = 8
        Me.chkJueves.Text = "Jueves"
        '
        'chkMiercoles
        '
        Me.chkMiercoles.Location = New System.Drawing.Point(140, 136)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(72, 24)
        Me.chkMiercoles.TabIndex = 7
        Me.chkMiercoles.Text = "Miercoles"
        '
        'chkMartes
        '
        Me.chkMartes.Location = New System.Drawing.Point(80, 136)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(64, 24)
        Me.chkMartes.TabIndex = 6
        Me.chkMartes.Text = "Martes"
        '
        'chkLunes
        '
        Me.chkLunes.Location = New System.Drawing.Point(24, 136)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(56, 24)
        Me.chkLunes.TabIndex = 5
        Me.chkLunes.Text = "Lunes"
        '
        'chkDias
        '
        Me.chkDias.Location = New System.Drawing.Point(8, 112)
        Me.chkDias.Name = "chkDias"
        Me.chkDias.Size = New System.Drawing.Size(120, 24)
        Me.chkDias.TabIndex = 4
        Me.chkDias.Text = "Días de la Semana"
        '
        'chkSD
        '
        Me.chkSD.Location = New System.Drawing.Point(8, 40)
        Me.chkSD.Name = "chkSD"
        Me.chkSD.Size = New System.Drawing.Size(120, 24)
        Me.chkSD.TabIndex = 3
        Me.chkSD.Text = "Sábado y Domingo"
        '
        'chkD
        '
        Me.chkD.Location = New System.Drawing.Point(8, 88)
        Me.chkD.Name = "chkD"
        Me.chkD.Size = New System.Drawing.Size(120, 24)
        Me.chkD.TabIndex = 2
        Me.chkD.Text = "Domingo"
        '
        'chkS
        '
        Me.chkS.Location = New System.Drawing.Point(8, 64)
        Me.chkS.Name = "chkS"
        Me.chkS.Size = New System.Drawing.Size(120, 24)
        Me.chkS.TabIndex = 1
        Me.chkS.Text = "Sábado"
        '
        'chkLV
        '
        Me.chkLV.Location = New System.Drawing.Point(8, 16)
        Me.chkLV.Name = "chkLV"
        Me.chkLV.Size = New System.Drawing.Size(120, 24)
        Me.chkLV.TabIndex = 0
        Me.chkLV.Text = "Lunes a Viernes"
        '
        'cboTarget
        '
        Me.cboTarget.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboTarget.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTarget.FlatMode = True
        Me.cboTarget.Location = New System.Drawing.Point(56, 30)
        Me.cboTarget.Name = "cboTarget"
        Me.cboTarget.Size = New System.Drawing.Size(240, 19)
        Me.cboTarget.TabIndex = 5
        '
        'cboAudienciaRadio
        '
        Me.cboAudienciaRadio.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboAudienciaRadio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAudienciaRadio.FlatMode = True
        Me.cboAudienciaRadio.Location = New System.Drawing.Point(56, 5)
        Me.cboAudienciaRadio.Name = "cboAudienciaRadio"
        Me.cboAudienciaRadio.Size = New System.Drawing.Size(240, 19)
        Me.cboAudienciaRadio.TabIndex = 3
        '
        'lblTarget
        '
        Me.lblTarget.Location = New System.Drawing.Point(8, 29)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(37, 21)
        Me.lblTarget.TabIndex = 4
        Me.lblTarget.Text = "Target"
        Me.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSiguienteEmisoras
        '
        Me.btnSiguienteEmisoras.Location = New System.Drawing.Point(557, 344)
        Me.btnSiguienteEmisoras.Name = "btnSiguienteEmisoras"
        Me.btnSiguienteEmisoras.TabIndex = 6
        Me.btnSiguienteEmisoras.Text = "Siguiente"
        '
        'lblPeriodoAudiencia
        '
        Me.lblPeriodoAudiencia.Location = New System.Drawing.Point(8, 4)
        Me.lblPeriodoAudiencia.Name = "lblPeriodoAudiencia"
        Me.lblPeriodoAudiencia.Size = New System.Drawing.Size(43, 21)
        Me.lblPeriodoAudiencia.TabIndex = 2
        Me.lblPeriodoAudiencia.Text = "Período"
        Me.lblPeriodoAudiencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'emisora
        '
        Me.emisora.Controls.Add(Me.btnAnteriorDatosGenerales)
        Me.emisora.Controls.Add(Me.ugEmisoras)
        Me.emisora.Controls.Add(Me.btnSiguienteBloques)
        Me.emisora.Controls.Add(Me.btnEmisorasAgregarTodasAM)
        Me.emisora.Controls.Add(Me.btnEmisorasAgregarTodasFM)
        Me.emisora.Controls.Add(Me.btnEmisorasRetirarTodas)
        Me.emisora.Controls.Add(Me.btnEmisorasAgregarSeleccionadas)
        Me.emisora.Controls.Add(Me.lblEmisorasAM)
        Me.emisora.Controls.Add(Me.lblEmisorasFM)
        Me.emisora.Controls.Add(Me.lEmisorasAM)
        Me.emisora.Controls.Add(Me.lEmisorasFM)
        Me.emisora.Location = New System.Drawing.Point(4, 22)
        Me.emisora.Name = "emisora"
        Me.emisora.Size = New System.Drawing.Size(636, 375)
        Me.emisora.TabIndex = 1
        Me.emisora.Text = "Emisoras"
        Me.emisora.Visible = False
        '
        'btnAnteriorDatosGenerales
        '
        Me.btnAnteriorDatosGenerales.Location = New System.Drawing.Point(8, 344)
        Me.btnAnteriorDatosGenerales.Name = "btnAnteriorDatosGenerales"
        Me.btnAnteriorDatosGenerales.TabIndex = 10
        Me.btnAnteriorDatosGenerales.Text = "Anterior"
        '
        'ugEmisoras
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugEmisoras.DisplayLayout.Appearance = Appearance1
        Me.ugEmisoras.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance2
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn2.Width = 286
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand1.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
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
        Me.ugEmisoras.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugEmisoras.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugEmisoras.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.ugEmisoras.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugEmisoras.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.ugEmisoras.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugEmisoras.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.ugEmisoras.DisplayLayout.MaxColScrollRegions = 1
        Me.ugEmisoras.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugEmisoras.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugEmisoras.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.ugEmisoras.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugEmisoras.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ugEmisoras.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugEmisoras.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugEmisoras.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.ugEmisoras.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugEmisoras.DisplayLayout.Override.CellAppearance = Appearance9
        Me.ugEmisoras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugEmisoras.DisplayLayout.Override.CellPadding = 0
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.ugEmisoras.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugEmisoras.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.ugEmisoras.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugEmisoras.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.ugEmisoras.DisplayLayout.Override.RowAppearance = Appearance12
        Me.ugEmisoras.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugEmisoras.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.ugEmisoras.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugEmisoras.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugEmisoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugEmisoras.Location = New System.Drawing.Point(344, 28)
        Me.ugEmisoras.Name = "ugEmisoras"
        Me.ugEmisoras.Size = New System.Drawing.Size(288, 308)
        Me.ugEmisoras.TabIndex = 8
        Me.ugEmisoras.TabStop = False
        Me.ugEmisoras.Text = "UltraGrid1"
        '
        'btnSiguienteBloques
        '
        Me.btnSiguienteBloques.Location = New System.Drawing.Point(557, 344)
        Me.btnSiguienteBloques.Name = "btnSiguienteBloques"
        Me.btnSiguienteBloques.TabIndex = 9
        Me.btnSiguienteBloques.Text = "Siguiente"
        '
        'btnEmisorasAgregarTodasAM
        '
        Me.btnEmisorasAgregarTodasAM.Location = New System.Drawing.Point(248, 232)
        Me.btnEmisorasAgregarTodasAM.Name = "btnEmisorasAgregarTodasAM"
        Me.btnEmisorasAgregarTodasAM.Size = New System.Drawing.Size(88, 40)
        Me.btnEmisorasAgregarTodasAM.TabIndex = 7
        Me.btnEmisorasAgregarTodasAM.Text = "Agregar Todas AM"
        '
        'btnEmisorasAgregarTodasFM
        '
        Me.btnEmisorasAgregarTodasFM.Location = New System.Drawing.Point(248, 184)
        Me.btnEmisorasAgregarTodasFM.Name = "btnEmisorasAgregarTodasFM"
        Me.btnEmisorasAgregarTodasFM.Size = New System.Drawing.Size(88, 40)
        Me.btnEmisorasAgregarTodasFM.TabIndex = 6
        Me.btnEmisorasAgregarTodasFM.Text = "Agregar Todas FM"
        '
        'btnEmisorasRetirarTodas
        '
        Me.btnEmisorasRetirarTodas.Location = New System.Drawing.Point(248, 136)
        Me.btnEmisorasRetirarTodas.Name = "btnEmisorasRetirarTodas"
        Me.btnEmisorasRetirarTodas.Size = New System.Drawing.Size(88, 40)
        Me.btnEmisorasRetirarTodas.TabIndex = 5
        Me.btnEmisorasRetirarTodas.Text = "Retirar Todas"
        '
        'btnEmisorasAgregarSeleccionadas
        '
        Me.btnEmisorasAgregarSeleccionadas.Location = New System.Drawing.Point(248, 88)
        Me.btnEmisorasAgregarSeleccionadas.Name = "btnEmisorasAgregarSeleccionadas"
        Me.btnEmisorasAgregarSeleccionadas.Size = New System.Drawing.Size(88, 40)
        Me.btnEmisorasAgregarSeleccionadas.TabIndex = 4
        Me.btnEmisorasAgregarSeleccionadas.Text = "Agregar Seleccionadas"
        '
        'lblEmisorasAM
        '
        Me.lblEmisorasAM.AutoSize = True
        Me.lblEmisorasAM.Location = New System.Drawing.Point(80, 176)
        Me.lblEmisorasAM.Name = "lblEmisorasAM"
        Me.lblEmisorasAM.Size = New System.Drawing.Size(71, 16)
        Me.lblEmisorasAM.TabIndex = 2
        Me.lblEmisorasAM.Text = "Emisoras AM"
        '
        'lblEmisorasFM
        '
        Me.lblEmisorasFM.AutoSize = True
        Me.lblEmisorasFM.Location = New System.Drawing.Point(80, 8)
        Me.lblEmisorasFM.Name = "lblEmisorasFM"
        Me.lblEmisorasFM.Size = New System.Drawing.Size(71, 16)
        Me.lblEmisorasFM.TabIndex = 0
        Me.lblEmisorasFM.Text = "Emisoras FM"
        '
        'lEmisorasAM
        '
        Me.lEmisorasAM.Location = New System.Drawing.Point(8, 196)
        Me.lEmisorasAM.Name = "lEmisorasAM"
        Me.lEmisorasAM.Size = New System.Drawing.Size(232, 139)
        Me.lEmisorasAM.TabIndex = 3
        '
        'lEmisorasFM
        '
        Me.lEmisorasFM.Location = New System.Drawing.Point(8, 28)
        Me.lEmisorasFM.Name = "lEmisorasFM"
        Me.lEmisorasFM.Size = New System.Drawing.Size(232, 139)
        Me.lEmisorasFM.TabIndex = 1
        '
        'bloque
        '
        Me.bloque.Controls.Add(Me.btnAgregarFranja)
        Me.bloque.Controls.Add(Me.txtHoraHasta)
        Me.bloque.Controls.Add(Me.txtHoraDesde)
        Me.bloque.Controls.Add(Me.btnHoras)
        Me.bloque.Controls.Add(Me.btnCuartos)
        Me.bloque.Controls.Add(Me.btnRetirarBloque)
        Me.bloque.Controls.Add(Me.btnAgregarBloque)
        Me.bloque.Controls.Add(Me.ugBloques)
        Me.bloque.Controls.Add(Me.lblHoraHasta)
        Me.bloque.Controls.Add(Me.lblHoraDesde)
        Me.bloque.Controls.Add(Me.btnAnteriorEmisoras)
        Me.bloque.Location = New System.Drawing.Point(4, 22)
        Me.bloque.Name = "bloque"
        Me.bloque.Size = New System.Drawing.Size(636, 375)
        Me.bloque.TabIndex = 2
        Me.bloque.Text = "Bloques"
        Me.bloque.Visible = False
        '
        'btnAgregarFranja
        '
        Me.btnAgregarFranja.Location = New System.Drawing.Point(24, 176)
        Me.btnAgregarFranja.Name = "btnAgregarFranja"
        Me.btnAgregarFranja.Size = New System.Drawing.Size(104, 40)
        Me.btnAgregarFranja.TabIndex = 6
        Me.btnAgregarFranja.Text = "Restablecer Franjas"
        '
        'txtHoraHasta
        '
        Me.txtHoraHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraHasta.Location = New System.Drawing.Point(72, 36)
        Me.txtHoraHasta.MaxLength = 5
        Me.txtHoraHasta.Name = "txtHoraHasta"
        Me.txtHoraHasta.Size = New System.Drawing.Size(76, 20)
        Me.txtHoraHasta.TabIndex = 3
        Me.txtHoraHasta.Text = ""
        '
        'txtHoraDesde
        '
        Me.txtHoraDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraDesde.Location = New System.Drawing.Point(72, 12)
        Me.txtHoraDesde.MaxLength = 5
        Me.txtHoraDesde.Name = "txtHoraDesde"
        Me.txtHoraDesde.Size = New System.Drawing.Size(76, 20)
        Me.txtHoraDesde.TabIndex = 1
        Me.txtHoraDesde.Text = ""
        '
        'btnHoras
        '
        Me.btnHoras.Location = New System.Drawing.Point(24, 264)
        Me.btnHoras.Name = "btnHoras"
        Me.btnHoras.Size = New System.Drawing.Size(104, 40)
        Me.btnHoras.TabIndex = 8
        Me.btnHoras.Text = "Restablecer Todas las Horas"
        '
        'btnCuartos
        '
        Me.btnCuartos.Location = New System.Drawing.Point(24, 220)
        Me.btnCuartos.Name = "btnCuartos"
        Me.btnCuartos.Size = New System.Drawing.Size(104, 40)
        Me.btnCuartos.TabIndex = 7
        Me.btnCuartos.Text = "Restablecer Todos los Cuartos"
        '
        'btnRetirarBloque
        '
        Me.btnRetirarBloque.Location = New System.Drawing.Point(24, 132)
        Me.btnRetirarBloque.Name = "btnRetirarBloque"
        Me.btnRetirarBloque.Size = New System.Drawing.Size(104, 40)
        Me.btnRetirarBloque.TabIndex = 5
        Me.btnRetirarBloque.Text = "Retirar Bloques"
        '
        'btnAgregarBloque
        '
        Me.btnAgregarBloque.Location = New System.Drawing.Point(24, 88)
        Me.btnAgregarBloque.Name = "btnAgregarBloque"
        Me.btnAgregarBloque.Size = New System.Drawing.Size(104, 40)
        Me.btnAgregarBloque.TabIndex = 4
        Me.btnAgregarBloque.Text = "Agregar Bloque"
        '
        'ugBloques
        '
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugBloques.DisplayLayout.Appearance = Appearance14
        Me.ugBloques.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance15
        UltraGridColumn3.Header.Caption = "Hora Desde"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn3.Width = 157
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance16
        UltraGridColumn4.Header.Caption = "Hora Hasta"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn4.Width = 160
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance17
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn5.Width = 161
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        UltraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand2.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand2.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
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
        Me.ugBloques.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugBloques.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugBloques.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.BorderColor = System.Drawing.SystemColors.Window
        Me.ugBloques.DisplayLayout.GroupByBox.Appearance = Appearance18
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugBloques.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance19
        Me.ugBloques.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance20.BackColor2 = System.Drawing.SystemColors.Control
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugBloques.DisplayLayout.GroupByBox.PromptAppearance = Appearance20
        Me.ugBloques.DisplayLayout.MaxColScrollRegions = 1
        Me.ugBloques.DisplayLayout.MaxRowScrollRegions = 1
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugBloques.DisplayLayout.Override.ActiveCellAppearance = Appearance21
        Appearance22.BackColor = System.Drawing.SystemColors.Highlight
        Appearance22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugBloques.DisplayLayout.Override.ActiveRowAppearance = Appearance22
        Me.ugBloques.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ugBloques.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugBloques.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ugBloques.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugBloques.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.ugBloques.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.ugBloques.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugBloques.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Me.ugBloques.DisplayLayout.Override.CardAreaAppearance = Appearance23
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Appearance24.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugBloques.DisplayLayout.Override.CellAppearance = Appearance24
        Me.ugBloques.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugBloques.DisplayLayout.Override.CellPadding = 0
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.ugBloques.DisplayLayout.Override.GroupByRowAppearance = Appearance25
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugBloques.DisplayLayout.Override.HeaderAppearance = Appearance26
        Me.ugBloques.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugBloques.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.Color.Silver
        Me.ugBloques.DisplayLayout.Override.RowAppearance = Appearance27
        Me.ugBloques.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugBloques.DisplayLayout.Override.TemplateAddRowAppearance = Appearance28
        Me.ugBloques.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugBloques.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugBloques.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugBloques.Location = New System.Drawing.Point(152, 8)
        Me.ugBloques.Name = "ugBloques"
        Me.ugBloques.Size = New System.Drawing.Size(480, 328)
        Me.ugBloques.TabIndex = 9
        Me.ugBloques.TabStop = False
        Me.ugBloques.Text = "UltraGrid1"
        '
        'lblHoraHasta
        '
        Me.lblHoraHasta.AutoSize = True
        Me.lblHoraHasta.Location = New System.Drawing.Point(8, 40)
        Me.lblHoraHasta.Name = "lblHoraHasta"
        Me.lblHoraHasta.Size = New System.Drawing.Size(64, 16)
        Me.lblHoraHasta.TabIndex = 2
        Me.lblHoraHasta.Text = "Hora Hasta:"
        '
        'lblHoraDesde
        '
        Me.lblHoraDesde.AutoSize = True
        Me.lblHoraDesde.Location = New System.Drawing.Point(8, 16)
        Me.lblHoraDesde.Name = "lblHoraDesde"
        Me.lblHoraDesde.Size = New System.Drawing.Size(68, 16)
        Me.lblHoraDesde.TabIndex = 0
        Me.lblHoraDesde.Text = "Hora Desde:"
        '
        'btnAnteriorEmisoras
        '
        Me.btnAnteriorEmisoras.Location = New System.Drawing.Point(8, 344)
        Me.btnAnteriorEmisoras.Name = "btnAnteriorEmisoras"
        Me.btnAnteriorEmisoras.TabIndex = 10
        Me.btnAnteriorEmisoras.Text = "Anterior"
        '
        '_frmAudienciaRadio_Toolbars_Dock_Area_Left
        '
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.Name = "_frmAudienciaRadio_Toolbars_Dock_Area_Left"
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 415)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Left.ToolbarsManager = Me.utmAudiencia
        '
        '_frmAudienciaRadio_Toolbars_Dock_Area_Right
        '
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(656, 22)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.Name = "_frmAudienciaRadio_Toolbars_Dock_Area_Right"
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 415)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Right.ToolbarsManager = Me.utmAudiencia
        '
        '_frmAudienciaRadio_Toolbars_Dock_Area_Top
        '
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.Name = "_frmAudienciaRadio_Toolbars_Dock_Area_Top"
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(656, 22)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Top.ToolbarsManager = Me.utmAudiencia
        '
        '_frmAudienciaRadio_Toolbars_Dock_Area_Bottom
        '
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 437)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.Name = "_frmAudienciaRadio_Toolbars_Dock_Area_Bottom"
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(656, 0)
        Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.utmAudiencia
        '
        'frmAudienciaRadio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 437)
        Me.Controls.Add(Me.frmAudienciaRadio_Fill_Panel)
        Me.Controls.Add(Me._frmAudienciaRadio_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmAudienciaRadio_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmAudienciaRadio_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmAudienciaRadio_Toolbars_Dock_Area_Bottom)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudienciaRadio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audiencia Radio Capital"
        CType(Me.utmAudiencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAudienciaRadio_Fill_Panel.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.TabAudiencia.ResumeLayout(False)
        Me.generales.ResumeLayout(False)
        Me.gbDias.ResumeLayout(False)
        CType(Me.cboTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAudienciaRadio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.emisora.ResumeLayout(False)
        CType(Me.ugEmisoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bloque.ResumeLayout(False)
        CType(Me.ugBloques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private Ola As Integer
    Private Target As String
    Private DiasSeleccionados As SortedList
    Private Emisoras, EmisorasSeleccionadas, Bloques As DataTable
    Private mClosePage As Boolean = False
#End Region

#Region "Eventos"
    Private Sub frmAudienciaRadio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarOlas()
        Call CargarTargets()
        Call InicializarPantalla()
    End Sub

    Private Sub frmAudienciaRadio_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        mClosePage = True
    End Sub

    Private Sub TabAudiencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabAudiencia.SelectedIndexChanged
        Select Case TabAudiencia.SelectedTab.Name
            Case "emisora"
                If ValidarAperturaEmisora() Then
                    Call CargarEmisoras()
                End If
            Case "bloque"
                If ValidarAperturaBloque() Then
                    Call InicializarBloques()
                End If
        End Select
    End Sub

    Private Sub btnSiguienteEmisoras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSiguienteEmisoras.Click
        Call SeleccionarTab(1)
    End Sub

    Private Sub btnSiguienteBloques_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSiguienteBloques.Click
        Call SeleccionarTab(2)
    End Sub

    Private Sub btnAnteriorDatosGenerales_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnteriorDatosGenerales.Click
        Call SeleccionarTab(0)
    End Sub

    Private Sub btnAnteriorEmisoras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnteriorEmisoras.Click
        Call SeleccionarTab(1)
    End Sub

    Private Sub btnEmisorasAgregarSeleccionadas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmisorasAgregarSeleccionadas.Click
        Call AgregarSeleccionados()
    End Sub

    Private Sub btnEmisorasAgregarTodasAM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmisorasAgregarTodasAM.Click
        Call SeleccionarEmisoras(lEmisorasAM)
        Call AgregarSeleccionados(lEmisorasAM)
    End Sub

    Private Sub btnEmisorasAgregarTodasFM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmisorasAgregarTodasFM.Click
        Call SeleccionarEmisoras(lEmisorasFM)
        Call AgregarSeleccionados(lEmisorasFM)
    End Sub

    Private Sub btnEmisorasRetirarTodas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmisorasRetirarTodas.Click
        EmisorasSeleccionadas.Rows.Clear()
    End Sub

    Private Sub btnAgregarBloque_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregarBloque.Click
        Call AgregarBloque()
    End Sub

    Private Sub btnAgregarFranja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarFranja.Click
        Call AgregarFranjas()
    End Sub

    Private Sub btnRetirarBloque_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRetirarBloque.Click
        Bloques.Rows.Clear()
    End Sub

    Private Sub btnCuartos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCuartos.Click
        Call AgregarCuartos()
    End Sub

    Private Sub btnHoras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHoras.Click
        Call AgregarHoras()
    End Sub

    Private Sub utmAudiencia_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles utmAudiencia.ToolClick
        Select Case e.Tool.Key
            Case "Procesar"
                Call Procesar()
            Case "Exportar"
                Call Procesar(True)
            Case "Limpiar"
                Call InicializarPantalla()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub txtHoraDesde_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoraDesde.LostFocus
        Call AplicarFormatoHora(txtHoraDesde, True)
    End Sub

    Private Sub txtHoraHasta_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoraHasta.LostFocus
        Call AplicarFormatoHora(txtHoraHasta, False)
    End Sub

    Private Sub ugEmisoras_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ugEmisoras.KeyUp
        If e.KeyData = Keys.Delete AndAlso ugEmisoras.Selected.Rows.Count > 0 Then
            Call EliminarRegistrosSeleccionados(ugEmisoras)
        End If
    End Sub

    Private Sub ugBloques_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ugBloques.KeyUp
        If e.KeyData = Keys.Delete AndAlso ugBloques.Selected.Rows.Count > 0 Then
            Call EliminarRegistrosSeleccionados(ugBloques)
        End If
    End Sub

    Private Sub chkDias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDias.CheckedChanged
        Call ChequearDiasSemana()
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub CargarOlas()
        Dim Audiencia As New Audiencia_rd
        Dim Olas As DataTable

        Olas = Audiencia.ObtenerOlaAudiencia
        If Not Olas Is Nothing AndAlso Olas.Rows.Count > 0 Then
            Me.CargarCombo(cboAudienciaRadio, Olas, "ID_OLA", "DESCRIPCION", False)
            cboAudienciaRadio.SelectedItem = cboAudienciaRadio.Items(0)
        Else
            cboAudienciaRadio.DataSource = Nothing
            cboAudienciaRadio.Enabled = False
        End If
    End Sub

    Private Sub CargarEmisoras()
        If Emisoras Is Nothing OrElse Emisoras.Rows.Count = 0 Then
            Dim Audiencia As New Audiencia_rd
            Emisoras = Audiencia.ObtenerEmisorasIntermedias

            Dim EmisorasFM As DataTable = Emisoras.Clone
            Dim EmisorasAM As DataTable = Emisoras.Clone

            For Each EmisoraFM As DataRow In Emisoras.Select("Id_Banda = 1")
                EmisorasFM.ImportRow(EmisoraFM)
            Next
            For Each EmisoraAM As DataRow In Emisoras.Select("Id_Banda = 0")
                EmisorasAM.ImportRow(EmisoraAM)
            Next

            Listas.CargarList(lEmisorasFM, EmisorasFM, "Id_Soporte", "Descripcion_Soporte")
            Listas.CargarList(lEmisorasAM, EmisorasAM, "Id_Soporte", "Descripcion_Soporte")
            Call InicializarEmisorasSeleccionadas()
        End If
    End Sub

    Private Sub CargarTargets()
        Dim Audiencia As New Audiencia_rd
        Dim Targets As New DataTable

        Targets = Audiencia.ObtenerTarget
        If Not Targets Is Nothing AndAlso Targets.Rows.Count > 0 Then
            Me.CargarCombo(cboTarget, Targets, "ID_TARGET", "descripcion", False)
            cboTarget.SelectedItem = cboTarget.Items(0)
        Else
            cboTarget.DataSource = Nothing
            cboTarget.Enabled = False
        End If
    End Sub

    Private Sub CargarCombo(ByVal Combo As UltraComboEditor, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String, Optional ByVal AgregarFilaVacia As Boolean = False)
        If AgregarFilaVacia Then
            Dim Dr As DataRow
            Dr = Dt.NewRow
            Dr.Item(CampoID) = -1
            Dr.Item(CampoDescripcion) = ""
            Dt.Rows.InsertAt(Dr, 0)
        End If

        Combo.DataSource = Dt
        Combo.DisplayMember = CampoDescripcion
        Combo.ValueMember = CampoID
        Combo.DataBind()
    End Sub

    Private Sub InicializarDatosGenerales()
        If cboAudienciaRadio.Items.Count > 0 Then
            cboAudienciaRadio.SelectedItem = cboAudienciaRadio.Items(0)
        End If
        If cboTarget.Items.Count > 0 Then
            cboTarget.SelectedItem = cboTarget.Items(0)
        End If
        chkLV.Checked = True
        chkSD.Checked = False
        chkS.Checked = False
        chkD.Checked = False
        chkDias.Checked = False
        ChequearDiasSemana()
    End Sub

    Private Sub InicializarEmisorasSeleccionadas()
        If EmisorasSeleccionadas Is Nothing Then
            EmisorasSeleccionadas = New DataTable
            EmisorasSeleccionadas.Columns.Add("Emisora_Id", GetType(Integer))
            EmisorasSeleccionadas.Columns.Add("Descripcion", GetType(String))
        End If
        EmisorasSeleccionadas.Rows.Clear()
        ugEmisoras.DataSource = EmisorasSeleccionadas
    End Sub

    Private Sub InicializarBloques()
        If Bloques Is Nothing Then
            Bloques = New DataTable
            Bloques.Columns.Add("HoraDesde", GetType(String))
            Bloques.Columns.Add("HoraHasta", GetType(String))
            Bloques.Columns.Add("Bloque", GetType(String))
        End If

        ugBloques.DataSource = Bloques
    End Sub

    Private Sub InicializarPantalla()
        Call InicializarDatosGenerales()
        Call InicializarEmisorasSeleccionadas()
        Call InicializarBloques()
        Bloques.Rows.Clear()
        Call SeleccionarTab(0)
    End Sub

    Private Sub SeleccionarTab(ByVal pIndex As Integer)
        TabAudiencia.SelectedTab = TabAudiencia.TabPages(pIndex)
    End Sub

    Private Sub SeleccionarEmisoras(ByVal pEmisora As CheckedListBox)
        Dim Index As Integer

        For Index = 0 To pEmisora.Items.Count - 1
            pEmisora.SetItemChecked(Index, True)
        Next
    End Sub

    Private Sub AgregarSeleccionados()
        Call AgregarSeleccionados(lEmisorasFM)
        Call AgregarSeleccionados(lEmisorasAM)
    End Sub

    Private Sub AgregarSeleccionados(ByVal pEmisora As CheckedListBox)
        Dim Item As ItemLista
        Dim Index As Integer

        For Index = 0 To pEmisora.CheckedItems.Count - 1
            Item = pEmisora.CheckedItems.Item(Index)
            Call AgregarEmisora(Item)
        Next
        For Index = pEmisora.CheckedItems.Count - 1 To 0 Step -1
            pEmisora.SetSelected(pEmisora.CheckedIndices.Item(Index), False)
            pEmisora.SetItemChecked(pEmisora.CheckedIndices.Item(Index), False)
        Next
    End Sub

    Private Sub AgregarEmisora(ByVal pItem As ItemLista)
        If EmisorasSeleccionadas.Select("Emisora_Id = " & pItem.ID).Length <= 0 Then
            Dim RowEmisora As DataRow
            RowEmisora = EmisorasSeleccionadas.NewRow
            RowEmisora("Emisora_Id") = pItem.ID
            RowEmisora("Descripcion") = pItem.Descripcion
            EmisorasSeleccionadas.Rows.Add(RowEmisora)
        End If
    End Sub

    Private Sub AgregarBloque()
        Dim Filtro As StringBuilder

        If ValidarHoras() Then
            Filtro = New StringBuilder

            Filtro.Append("Bloque = '")
            Filtro.Append(txtHoraDesde.Text.Trim)
            Filtro.Append(" - ")
            Filtro.Append(txtHoraHasta.Text.Trim)
            Filtro.Append("'")

            If Bloques.Select(Filtro.ToString).Length <= 0 Then
                Call AgregarBloque(txtHoraDesde.Text.Trim, txtHoraHasta.Text.Trim)
            End If

            txtHoraDesde.Text = String.Empty
            txtHoraHasta.Text = String.Empty
            txtHoraDesde.Focus()
        End If
    End Sub

    Private Sub AgregarBloque(ByVal pHoraDesde As String, ByVal pHoraHasta As String)
        Dim Bloque As New StringBuilder
        Dim ItemBloque As DataRow

        Bloque.Append(pHoraDesde)
        Bloque.Append(" - ")
        Bloque.Append(pHoraHasta)

        ItemBloque = Bloques.NewRow
        ItemBloque("HoraDesde") = pHoraDesde
        ItemBloque("HoraHasta") = pHoraHasta
        ItemBloque("Bloque") = Bloque.ToString
        Bloques.Rows.Add(ItemBloque)
    End Sub

    Private Sub AgregarBloque(ByVal pHora As Integer, ByVal pMinuto As Integer)
        Dim HoraInicio As New StringBuilder
        Dim HoraFin As New StringBuilder
        Dim HoraHasta, MinutoHasta As Integer

        If pHora.ToString.Length = 1 Then
            HoraInicio.Append("0")
        End If
        HoraInicio.Append(pHora.ToString)
        HoraInicio.Append(":")
        If pMinuto.ToString.Length = 1 Then
            HoraInicio.Append("0")
        End If
        HoraInicio.Append(pMinuto.ToString)

        If pMinuto = 45 Then
            If pHora = 29 Then
                HoraHasta = 6
            Else
                HoraHasta = pHora + 1
            End If
            MinutoHasta = 0
        Else
            HoraHasta = pHora
            MinutoHasta = pMinuto + 15
        End If

        If HoraHasta.ToString.Length = 1 Then
            HoraFin.Append("0")
        End If
        HoraFin.Append(HoraHasta.ToString)
        HoraFin.Append(":")
        If MinutoHasta.ToString.Length = 1 Then
            HoraFin.Append("0")
        End If
        HoraFin.Append(MinutoHasta.ToString)

        Call AgregarBloque(HoraInicio.ToString, HoraFin.ToString)
    End Sub

    Private Sub AgregarBloque(ByVal pHora As Integer)
        Dim HoraInicio As New StringBuilder
        Dim HoraFin As New StringBuilder
        Dim HoraHasta As Integer

        If pHora.ToString.Length = 1 Then
            HoraInicio.Append("0")
        End If
        HoraInicio.Append(pHora.ToString)
        HoraInicio.Append(":00")

        If pHora = 29 Then
            HoraHasta = 6
        Else
            HoraHasta = pHora + 1
        End If

        If HoraHasta.ToString.Length = 1 Then
            HoraFin.Append("0")
        End If
        HoraFin.Append(HoraHasta.ToString)
        HoraFin.Append(":00")

        Call AgregarBloque(HoraInicio.ToString, HoraFin.ToString)
    End Sub

    Private Sub AgregarCuartos()
        Bloques.Rows.Clear()
        For Hora As Integer = 28 To 29
            For Minuto As Integer = 0 To 45 Step 15
                Call AgregarBloque(Hora, Minuto)
            Next
        Next
        For Hora As Integer = 6 To 27
            For Minuto As Integer = 0 To 45 Step 15
                Call AgregarBloque(Hora, Minuto)
            Next
        Next
    End Sub

    Private Sub AgregarHoras()
        Bloques.Rows.Clear()
        For Hora As Integer = 28 To 29
            Call AgregarBloque(Hora)
        Next
        For Hora As Integer = 6 To 27
            Call AgregarBloque(Hora)
        Next
    End Sub

    Private Sub AgregarFranjas()
        Bloques.Rows.Clear()
        Call AgregarBloque("06:00", "09:00")
        Call AgregarBloque("09:00", "12:00")
        Call AgregarBloque("12:00", "15:00")
        Call AgregarBloque("15:00", "18:00")
        Call AgregarBloque("18:00", "21:00")
        Call AgregarBloque("21:00", "24:00")
    End Sub

    Private Sub AplicarFormatoHora(ByVal pTexto As TextBox, ByVal pInicio As Boolean)
        If mClosePage Then Return
        Dim Hora As String = pTexto.Text.Trim
        If Hora <> String.Empty Then
            If Not AplicarFormatoHora(Hora, pInicio) Then
                pTexto.Text = String.Empty
                pTexto.Focus()
                Exit Sub
            End If
        Else
            pTexto.Text = String.Empty
        End If
    End Sub

    Private Sub Procesar(Optional ByVal pExportar As Boolean = False)
        If ValidarAperturaEmisora() Then
            Call ObtenerDiasSeleccionados()
            If DiasSeleccionados Is Nothing OrElse DiasSeleccionados.Count <= 0 Then
                Mensaje("Debe seleccionar al menos un Reporte - Día.", TipoMensaje.Informacion)
                Exit Sub
            End If
            If ValidarAperturaBloque() Then
                If ValidarBloque() Then
                    Dim AudienciaReporte As AudienciaRadio
                    Dim ArrayReporte As New ArrayList
                    Dim Audiencia As New Audiencia_rd
                    Dim Datos As DataTable
                    Dim Soportes As String
                    Dim Dias As String
                    Dim HoraDesde, MinutoDesde, HoraHasta, MinutoHasta As Integer
                    Dim Fp As New frmProgresoCargaGrilla

                    Application.DoEvents()
                    Me.Cursor = Cursors.WaitCursor
                    Fp.Texto = "Generando Reporte ..."
                    Fp.Max1 = DiasSeleccionados.Count + 1
                    Application.DoEvents()
                    Fp.Show()
                    Application.DoEvents()

                    Soportes = ObtenerSoportesSeleccionados()
                    Call ObtenerHorario(HoraDesde, MinutoDesde, HoraHasta, MinutoHasta)
                    Call ObtenerHorario(HoraDesde)
                    Call ObtenerHorario(HoraHasta)

                    For Index As Integer = 0 To DiasSeleccionados.Count - 1
                        Fp.Instancia.Incrementar(1)
                        Dias = DiasSeleccionados.GetKey(Index)
                        Datos = Audiencia.ObtenerAudienciaParcial(Ola, Target, Soportes, HoraDesde, MinutoDesde, HoraHasta, MinutoHasta, Dias)
                        If Not Datos Is Nothing AndAlso Datos.Rows.Count > 0 Then
                            AudienciaReporte = New AudienciaRadio
                            Call ArmarReporte(AudienciaReporte, Datos, DiasSeleccionados(DiasSeleccionados.GetKey(Index)))
                            ArrayReporte.Add(AudienciaReporte)
                        Else
                            Fp.Instancia.Close()
                            Me.Cursor = Cursors.Default
                            Mensaje("No hay audiencia para el filtro seleccionado", TipoMensaje.Informacion)
                            Exit Sub
                        End If
                    Next

                    Fp.Instancia.Incrementar(1)
                    Fp.Instancia.Close()
                    Me.Cursor = Cursors.Default
                    If pExportar Then
                        Call ExportarReportes(ArrayReporte)
                    Else
                        Call MostrarReporte(ArrayReporte)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ExportarReportes(ByVal pArrayReporte As ArrayList)
        Dim FileName As String
        Dim AudienciaReporte As AudienciaRadio
        Dim Libro As New Workbook
        Dim Hoja As Worksheet

        SaveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            FileName = SaveFileDialog.FileName
            For Index As Integer = 0 To pArrayReporte.Count - 1
                AudienciaReporte = CType(pArrayReporte(Index), AudienciaRadio)
                Hoja = Libro.Worksheets.Add(AudienciaReporte.DatosAudiencia(0).Dias)
                Hoja.DefaultColumnWidth = 6.29 * 256

                Call CargarEncabezado(Hoja, AudienciaReporte)
                Call CargarCuerpo(Hoja, AudienciaReporte)
            Next

            Try
                Infragistics.Excel.BIFF8Writer.WriteWorkbookToFile(Libro, FileName)
                Mensaje("El archivo se grabó con éxito.", TipoMensaje.Informacion)
            Catch ioex As IO.IOException
                Mensaje(ioex.Message, TipoMensaje.DeError)
            End Try
        End If
    End Sub

    Private Sub CargarEncabezado(ByRef pHoja As Worksheet, ByVal AudienciaReporte As AudienciaRadio)
        Call AplicarFormatoCelda(pHoja, 1, 0, "Período: ", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.True, FontUnderlineStyle.None, "Arial", 8)
        pHoja.MergedCellsRegions.Add(1, 1, 1, 9)
        Call AplicarFormatoCelda(pHoja, 1, 1, AudienciaReporte.DatosAudiencia(0).Trimestre, HorizontalCellAlignment.Left, ExcelDefaultableBoolean.False, FontUnderlineStyle.None, "Arial", 8)
        Call AplicarFormatoCelda(pHoja, 2, 0, "Target: ", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.True, FontUnderlineStyle.None, "Arial", 8)
        pHoja.MergedCellsRegions.Add(2, 1, 2, 9)
        Call AplicarFormatoCelda(pHoja, 2, 1, AudienciaReporte.DatosAudiencia(0).Target, HorizontalCellAlignment.Left, ExcelDefaultableBoolean.False, FontUnderlineStyle.None, "Arial", 8)
        Call AplicarFormatoCelda(pHoja, 3, 0, "Días: ", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.True, FontUnderlineStyle.None, "Arial", 8)
        pHoja.MergedCellsRegions.Add(3, 1, 3, 9)
        Call AplicarFormatoCelda(pHoja, 3, 1, AudienciaReporte.DatosAudiencia(0).Dias, HorizontalCellAlignment.Left, ExcelDefaultableBoolean.False, FontUnderlineStyle.None, "Arial", 8)
    End Sub

    Private Sub CargarCuerpo(ByRef pHoja As Worksheet, ByVal AudienciaReporte As AudienciaRadio)
        Dim RowIndex As Integer = 4
        Dim Emisoras As New ArrayList

        For Each Rating As AudienciaRadio.AudienciaRow In AudienciaReporte.Audiencia.Rows
            If Not Emisoras.Contains(Rating.Soporte) Then
                RowIndex += 1

                Emisoras.Add(Rating.Soporte)
                pHoja.MergedCellsRegions.Add(RowIndex, 0, RowIndex, 4)
                Call AplicarFormatoCelda(pHoja, RowIndex, 0, "Emisora", HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.None, "Arial", 8)
                Call AplicarBordeCelda(pHoja, RowIndex, 0, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
                pHoja.MergedCellsRegions.Add(RowIndex, 5, RowIndex, 7)
                Call AplicarFormatoCelda(pHoja, RowIndex, 5, "Bloque", HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.None, "Arial", 8)
                Call AplicarBordeCelda(pHoja, RowIndex, 5, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
                pHoja.MergedCellsRegions.Add(RowIndex, 8, RowIndex, 9)
                Call AplicarFormatoCelda(pHoja, RowIndex, 8, "Rating", HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.None, "Arial", 8)
                Call AplicarBordeCelda(pHoja, RowIndex, 8, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)

                RowIndex += 1
            End If

            pHoja.MergedCellsRegions.Add(RowIndex, 0, RowIndex, 4)
            Call AplicarFormatoCelda(pHoja, RowIndex, 0, Rating.Soporte, HorizontalCellAlignment.Left, ExcelDefaultableBoolean.False, FontUnderlineStyle.None, "Arial", 8)
            Call AplicarBordeCelda(pHoja, RowIndex, 0, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
            pHoja.MergedCellsRegions.Add(RowIndex, 5, RowIndex, 7)
            Call AplicarFormatoCelda(pHoja, RowIndex, 5, Rating.Bloque, HorizontalCellAlignment.Center, ExcelDefaultableBoolean.False, FontUnderlineStyle.None, "Arial", 8)
            Call AplicarBordeCelda(pHoja, RowIndex, 5, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
            pHoja.MergedCellsRegions.Add(RowIndex, 8, RowIndex, 9)
            Call AplicarFormatoCelda(pHoja, RowIndex, 8, Rating.Rating, HorizontalCellAlignment.Right, ExcelDefaultableBoolean.False, FontUnderlineStyle.None, "Arial", 8)
            Call AplicarBordeCelda(pHoja, RowIndex, 8, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
            Call AplicarFormatoCeldaNumerica(pHoja, RowIndex, 8)

            RowIndex += 1
        Next
    End Sub

    Private Sub AplicarFormatoCelda(ByRef pHoja As Worksheet, ByVal pRow As Integer, ByVal pCell As Integer, ByVal pTexto As String, _
            ByVal pAlign As HorizontalCellAlignment, ByVal pBold As ExcelDefaultableBoolean, ByVal pUnderlineStyle As FontUnderlineStyle, _
            ByVal pFontName As String, ByVal pHeight As Integer)

        pHoja.Rows(pRow).Cells(pCell).Value = pTexto
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Alignment = pAlign
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.Bold = pBold
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.Name = pFontName
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.Height = pHeight * 20
        pHoja.Rows(pRow).Cells(pCell).CellFormat.WrapText = ExcelDefaultableBoolean.False
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.UnderlineStyle = pUnderlineStyle
    End Sub

    Private Sub AplicarBordeCelda(ByRef pHoja As Worksheet, ByVal pRow As Integer, ByVal pCell As Integer, _
            ByVal pBottomStyle As CellBorderLineStyle, ByVal pTopStyle As CellBorderLineStyle, ByVal pLeftStyle As CellBorderLineStyle, ByVal pRightStyle As CellBorderLineStyle)
        pHoja.Rows(pRow).Cells(pCell).CellFormat.BottomBorderStyle = pBottomStyle
        pHoja.Rows(pRow).Cells(pCell).CellFormat.TopBorderStyle = pTopStyle
        pHoja.Rows(pRow).Cells(pCell).CellFormat.LeftBorderStyle = pLeftStyle
        pHoja.Rows(pRow).Cells(pCell).CellFormat.RightBorderStyle = pRightStyle
    End Sub

    Private Sub AplicarFormatoCeldaNumerica(ByRef pHoja As Worksheet, ByVal pRow As Integer, ByVal pCell As Integer)
        pHoja.Rows(pRow).Cells(pCell).Value = Convert.ToDouble(pHoja.Rows(pRow).Cells(pCell).Value)
        pHoja.Rows(pRow).Cells(pCell).CellFormat.FormatString = "#,##0.00"
    End Sub

    Private Sub ChequearDiasSemana()
        Call ChequearDiasSemana(False)
        Call HabilitarDiasSemana(chkDias.Checked)
    End Sub

    Private Sub ChequearDiasSemana(ByVal pChequear As Boolean)
        chkLunes.Checked = pChequear
        chkMartes.Checked = pChequear
        chkMiercoles.Checked = pChequear
        chkJueves.Checked = pChequear
        chkViernes.Checked = pChequear
        chkSabado.Checked = pChequear
        chkDomingo.Checked = pChequear
    End Sub

    Private Sub HabilitarDiasSemana(ByVal pHabilitar As Boolean)
        chkLunes.Enabled = pHabilitar
        chkMartes.Enabled = pHabilitar
        chkMiercoles.Enabled = pHabilitar
        chkJueves.Enabled = pHabilitar
        chkViernes.Enabled = pHabilitar
        chkSabado.Enabled = pHabilitar
        chkDomingo.Enabled = pHabilitar
    End Sub

    Private Sub ObtenerHorario(ByRef pHoraDesde As Integer, ByRef pMinutoDesde As Integer, ByRef pHoraHasta As Integer, ByRef pMinutoHasta As Integer)
        pHoraDesde = 30
        pMinutoDesde = 99
        For Each Bloque As DataRow In Bloques.Rows
            Call ObtenerHorario(pHoraDesde, pMinutoDesde, Bloque("HoraDesde").ToString, True)
            Call ObtenerHorario(pHoraHasta, pMinutoHasta, Bloque("HoraHasta").ToString, False)
        Next
    End Sub

    Private Sub ObtenerHorario(ByRef pHora As Integer, ByRef pMinuto As Integer, ByVal pTextoHora As String, ByVal pEsMenor As Boolean)
        Dim Hora, Minuto As Integer
        Dim HM As String()

        HM = pTextoHora.Split(":")
        Hora = HM(0)
        Minuto = HM(1)

        If Hora = 28 Then
            Hora = 4
        ElseIf Hora = 29 Then
            Hora = 5
        End If

        If pEsMenor Then
            If Hora < pHora Then
                pHora = Hora
                pMinuto = Minuto
            ElseIf Hora = pHora And Minuto < pMinuto Then
                pMinuto = Minuto
            End If
        Else
            If Hora > pHora Then
                pHora = Hora
                pMinuto = Minuto
            ElseIf Hora = pHora And Minuto > pMinuto Then
                pMinuto = Minuto
            End If
        End If
    End Sub

    Private Sub ObtenerHorario(ByRef pHora As Integer)
        If pHora = 4 Then
            pHora = 28
        ElseIf pHora = 5 Then
            pHora = 29
        End If
    End Sub

    Private Sub ArmarReporte(ByRef pAudiencia As AudienciaRadio, ByVal pDatos As DataTable, ByVal pDias As String)

        Dim Datos As AudienciaRadio.DatosAudienciaRow
        Dim BloqueAudiencia As AudienciaRadio.AudienciaRow

        Datos = pAudiencia.DatosAudiencia.NewDatosAudienciaRow
        Datos.Dias = pDias
        Datos.Target = cboTarget.SelectedItem.DisplayText
        Datos.Trimestre = cboAudienciaRadio.SelectedItem.DisplayText
        pAudiencia.DatosAudiencia.Rows.Add(Datos)

        For Each Soporte As DataRow In EmisorasSeleccionadas.Rows
            For Each Bloque As DataRow In Bloques.Rows
                BloqueAudiencia = pAudiencia.Audiencia.NewAudienciaRow
                BloqueAudiencia.Soporte = Soporte("Descripcion")
                BloqueAudiencia.Bloque = Bloque("Bloque")
                BloqueAudiencia.Rating = ObtenerRating(Soporte("Emisora_Id"), Bloque("HoraDesde"), Bloque("HoraHasta"), pDatos)
                pAudiencia.Audiencia.Rows.Add(BloqueAudiencia)
            Next
        Next
    End Sub

    Private Sub MostrarReporte(ByVal pArrayReporte As ArrayList)
        Dim AudienciaReporte As AudienciaRadio

        For Index As Integer = 0 To pArrayReporte.Count - 1
            AudienciaReporte = CType(pArrayReporte(Index), AudienciaRadio)
            Call MostrarReporte(AudienciaReporte)
        Next
    End Sub

    Private Sub MostrarReporte(ByVal pAudiencia As AudienciaRadio)
        Dim Reporte As New frmAudiencia
        Reporte.DataSource = pAudiencia
        Reporte.Show()
    End Sub

    Private Sub ObtenerDiasSeleccionados()
        DiasSeleccionados = New SortedList
        Dim DiasSueltos As New SortedList
        Dim Key, Value As String

        If chkLV.Checked Then
            DiasSeleccionados.Add("1,2,3,4,5", "Lunes a Viernes")
        End If
        If chkSD.Checked Then
            DiasSeleccionados.Add("6,7", "Sábado y Domingo")
        End If
        If chkS.Checked Then
            DiasSeleccionados.Add("6", "Sábado")
        End If
        If chkD.Checked Then
            DiasSeleccionados.Add("7", "Domingo")
        End If
        If chkDias.Checked Then
            If chkLunes.Checked Then
                DiasSueltos.Add("1", "Lunes")
            End If
            If chkMartes.Checked Then
                DiasSueltos.Add("2", "Martes")
            End If
            If chkMiercoles.Checked Then
                DiasSueltos.Add("3", "Miercoles")
            End If
            If chkJueves.Checked Then
                DiasSueltos.Add("4", "Jueves")
            End If
            If chkViernes.Checked Then
                DiasSueltos.Add("5", "Viernes")
            End If
            If chkSabado.Checked Then
                DiasSueltos.Add("6", "Sábado")
            End If
            If chkDomingo.Checked Then
                DiasSueltos.Add("7", "Domingo")
            End If
            For Index As Integer = 0 To DiasSueltos.Count - 1
                Key &= DiasSueltos.GetKey(Index)
                Value &= DiasSueltos(DiasSueltos.GetKey(Index))
                If Index < DiasSueltos.Count - 1 Then
                    Key &= ","
                    Value &= " - "
                End If
            Next
            If Not DiasSeleccionados.Contains(Key) Then
                DiasSeleccionados.Add(Key, Value)
            End If
        End If

    End Sub

    Private Sub EliminarRegistrosSeleccionados(ByRef pGrid As UltraGrid)
        Dim Seleccionados As New SortedList
        Dim CantidadSeleccionados As Integer

        For Each SelRow As UltraGridRow In pGrid.Selected.Rows
            If Not Seleccionados.ContainsKey(SelRow.Index) Then
                Seleccionados.Add(SelRow.Index, SelRow.Index)
            End If
        Next

        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            pGrid.Rows(Seleccionados.GetKey(Index)).Delete(False)
        Next
    End Sub

    Private Function ObtenerRating(ByVal pIdSoporte As Integer, ByVal pHoraDesde As String, ByVal pHoraHasta As String, ByVal pDatos As DataTable) As Double
        Dim BloqueDesde, BloqueHasta As Integer
        Dim Rating As Double
        Dim Hora As String()
        Dim HoraHasta, MinutoHasta, CantidadBloques As Integer
        Dim Filtro As New StringBuilder

        Hora = pHoraDesde.Split(":")
        BloqueDesde = ObtenerBloque(Hora(0), Hora(1))
        Hora = pHoraHasta.Split(":")
        If Hora(1) <> "00" Then
            HoraHasta = Hora(0)
            MinutoHasta = Convert.ToInt32(Hora(1)) - 15
        Else
            If Convert.ToInt32(Hora(0)) = 6 Then
                HoraHasta = 29
            Else
                HoraHasta = Convert.ToInt32(Hora(0)) - 1
            End If
            MinutoHasta = "45"
        End If
        BloqueHasta = ObtenerBloque(HoraHasta, MinutoHasta)
        CantidadBloques = (BloqueHasta - BloqueDesde) + 1

        Filtro.Append("Soporte = '")
        Filtro.Append(pIdSoporte)
        Filtro.Append("' and Bloque in (")
        For Index As Integer = BloqueDesde To BloqueHasta
            Filtro.Append(Index)
            If Index < BloqueHasta Then
                Filtro.Append(",")
            End If
        Next
        Filtro.Append(")")

        Try
            For Each Dato As DataRow In pDatos.Select(Filtro.ToString)
                Rating += Convert.ToDouble(Dato("Audiencia"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Rating = Rating / CantidadBloques

        Return Rating
    End Function

    Private Function ObtenerBloque(ByVal pHora As Integer, ByVal pMinuto As Integer) As Integer
        Dim HoraCompleta As New StringBuilder
        Dim Minuto As Integer

        If pHora.ToString.Length = 1 Then
            HoraCompleta.Append("0")
        End If
        HoraCompleta.Append(pHora)
        HoraCompleta.Append(":")
        If pMinuto = 0 Then
            HoraCompleta.Append("00")
        ElseIf pMinuto = 15 OrElse pMinuto = 30 OrElse pMinuto = 45 Then
            HoraCompleta.Append(pMinuto)
        Else
            Minuto = pMinuto / 15
            Select Case Minuto
                Case 0
                    HoraCompleta.Append("00")
                Case 1
                    HoraCompleta.Append("15")
                Case 2
                    HoraCompleta.Append("30")
                Case 3
                    HoraCompleta.Append("45")
            End Select
        End If
        Return ObtenerBloque(HoraCompleta.ToString)
    End Function

    Private Function ObtenerBloque(ByVal pHora As String) As Integer
        Select Case pHora
            Case "06:00"
                Return 9
            Case "06:15"
                Return 10
            Case "06:30"
                Return 11
            Case "06:45"
                Return 12
            Case "07:00"
                Return 13
            Case "07:15"
                Return 14
            Case "07:30"
                Return 15
            Case "07:45"
                Return 16
            Case "08:00"
                Return 17
            Case "08:15"
                Return 18
            Case "08:30"
                Return 19
            Case "08:45"
                Return 20
            Case "09:00"
                Return 21
            Case "09:15"
                Return 22
            Case "09:30"
                Return 23
            Case "09:45"
                Return 24
            Case "10:00"
                Return 25
            Case "10:15"
                Return 26
            Case "10:30"
                Return 27
            Case "10:45"
                Return 28
            Case "11:00"
                Return 29
            Case "11:15"
                Return 30
            Case "11:30"
                Return 31
            Case "11:45"
                Return 32
            Case "12:00"
                Return 33
            Case "12:15"
                Return 34
            Case "12:30"
                Return 35
            Case "12:45"
                Return 36
            Case "13:00"
                Return 37
            Case "13:15"
                Return 38
            Case "13:30"
                Return 39
            Case "13:45"
                Return 40
            Case "14:00"
                Return 41
            Case "14:15"
                Return 42
            Case "14:30"
                Return 43
            Case "14:45"
                Return 44
            Case "15:00"
                Return 45
            Case "15:15"
                Return 46
            Case "15:30"
                Return 47
            Case "15:45"
                Return 48
            Case "16:00"
                Return 49
            Case "16:15"
                Return 50
            Case "16:30"
                Return 51
            Case "16:45"
                Return 52
            Case "17:00"
                Return 53
            Case "17:15"
                Return 54
            Case "17:30"
                Return 55
            Case "17:45"
                Return 56
            Case "18:00"
                Return 57
            Case "18:15"
                Return 58
            Case "18:30"
                Return 59
            Case "18:45"
                Return 60
            Case "19:00"
                Return 61
            Case "19:15"
                Return 62
            Case "19:30"
                Return 63
            Case "19:45"
                Return 64
            Case "20:00"
                Return 65
            Case "20:15"
                Return 66
            Case "20:30"
                Return 67
            Case "20:45"
                Return 68
            Case "21:00"
                Return 69
            Case "21:15"
                Return 70
            Case "21:30"
                Return 71
            Case "21:45"
                Return 72
            Case "22:00"
                Return 73
            Case "22:15"
                Return 74
            Case "22:30"
                Return 75
            Case "22:45"
                Return 76
            Case "23:00"
                Return 77
            Case "23:15"
                Return 78
            Case "23:30"
                Return 79
            Case "23:45"
                Return 80
            Case "24:00"
                Return 81
            Case "24:15"
                Return 82
            Case "24:30"
                Return 83
            Case "24:45"
                Return 84
            Case "25:00"
                Return 85
            Case "25:15"
                Return 86
            Case "25:30"
                Return 87
            Case "25:45"
                Return 88
            Case "26:00"
                Return 89
            Case "26:15"
                Return 90
            Case "26:30"
                Return 91
            Case "26:45"
                Return 92
            Case "27:00"
                Return 93
            Case "27:15"
                Return 94
            Case "27:30"
                Return 95
            Case "27:45"
                Return 96
            Case "28:00"
                Return 1
            Case "28:15"
                Return 2
            Case "28:30"
                Return 3
            Case "28:45"
                Return 4
            Case "29:00"
                Return 5
            Case "29:15"
                Return 6
            Case "29:30"
                Return 7
            Case "29:45"
                Return 8
        End Select
    End Function

    Private Function ValidarAperturaEmisora() As Boolean
        If cboAudienciaRadio.SelectedItem Is Nothing OrElse cboAudienciaRadio.SelectedItem Is Nothing OrElse cboAudienciaRadio.SelectedItem.DataValue Is Nothing OrElse cboAudienciaRadio.SelectedItem.DataValue Is DBNull.Value Then
            Mensaje("Debe seleccionar un Período.", TipoMensaje.Informacion)
            Return False
        End If
        If cboTarget.SelectedItem Is Nothing OrElse cboTarget.SelectedItem Is Nothing OrElse cboTarget.SelectedItem.DataValue Is Nothing OrElse cboTarget.SelectedItem.DataValue Is DBNull.Value Then
            Mensaje("Debe seleccionar un Target.", TipoMensaje.Informacion)
            Return False
        End If
        Ola = cboAudienciaRadio.SelectedItem.DataValue
        Target = ObtenerTarget(cboTarget.SelectedItem.DisplayText)
        Return True
    End Function

    Private Function ValidarAperturaBloque() As Boolean
        If EmisorasSeleccionadas.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos una Emisora.", TipoMensaje.Informacion)
            Call SeleccionarTab(1)
            Return False
        End If
        Return True
    End Function

    Private Function ValidarBloque() As Boolean
        If Bloques.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un Bloque.", TipoMensaje.Informacion)
            Call SeleccionarTab(2)
            Return False
        End If
        Return True
    End Function

    Private Function ValidarCaracteres(ByVal pValor As String, ByVal pCaracteresPermitidos As String) As Boolean
        Dim Existe As Boolean
        For Index As Integer = 0 To pValor.Length - 1
            Existe = False
            For IndexCaracter As Integer = 0 To pCaracteresPermitidos.Length - 1
                If pValor.Substring(Index, 1) = pCaracteresPermitidos.Substring(IndexCaracter, 1) Then
                    Existe = True
                    Exit For
                End If
            Next
            If Not Existe Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function ValidarHoras() As Boolean
        Dim hora1, minuto1 As Integer
        Dim hora2, minuto2 As Integer
        Dim hora1Aux As Integer
        Dim hora2Aux As Integer

        If txtHoraDesde.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar Hora Desde.", TipoMensaje.Informacion)
            txtHoraDesde.Focus()
            Return False
        End If
        If txtHoraHasta.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar Hora Hasta.", TipoMensaje.Informacion)
            txtHoraHasta.Focus()
            Return False
        End If

        hora1 = DevolverHora(txtHoraDesde.Text)
        minuto1 = DevolverMinutos(txtHoraDesde.Text)
        hora2 = DevolverHora(txtHoraHasta.Text)
        minuto2 = DevolverMinutos(txtHoraHasta.Text)

        If hora1 = 28 Then
            hora1Aux = 4
        ElseIf hora1 = 29 Then
            hora1Aux = 5
        Else
            hora1Aux = hora1
        End If
        If hora2 = 28 Then
            hora2Aux = 4
        ElseIf hora2 = 29 Then
            hora2Aux = 5
        Else
            hora2Aux = hora2
        End If

        If hora1 < 6 Or hora1 > 29 Then
            Mensajes.Mensaje("La hora desde debe estar entre las 28:00 y las 27:59")
            txtHoraDesde.Focus()
            Return False
        End If

        If minuto1 < 0 Or minuto1 > 59 Then
            Mensajes.Mensaje("Los minutos de la hora desde deben ser un valor entre 0 y 59")
            txtHoraDesde.Focus()
            Return False
        End If

        If hora2 < 6 Or hora2 > 29 Then
            Mensajes.Mensaje("La hora hasta debe estar entre las 28:00 y las 27:59")
            txtHoraHasta.Focus()
            Return False
        End If

        If minuto2 < 0 Or minuto2 > 59 Then
            Mensajes.Mensaje("Los minutos de la hora hasta deben ser un valor entre 0 y 59")
            txtHoraHasta.Focus()
            Return False
        End If

        If (hora1Aux > hora2Aux) OrElse (hora1Aux = hora2Aux AndAlso minuto1 > minuto2) Then
            Mensajes.Mensaje("La hora desde no puede ser posterior a la hora hasta")
            txtHoraDesde.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function DevolverHora(ByVal pHora As String) As Integer
        Dim Hora As Integer

        Hora = CInt(pHora.Split(":").GetValue(0))
        Return Hora
    End Function

    Private Function DevolverMinutos(ByVal pHora As String) As Integer
        Dim Hora As Integer

        Hora = CInt(pHora.Split(":").GetValue(1))
        Return Hora
    End Function

    Private Function AplicarFormatoHora(ByVal pHora As String, ByVal pInicio As Boolean) As Boolean
        Dim Message As New StringBuilder
        Dim HoraFinal As New StringBuilder
        Dim ParteHora As String() = pHora.Split(":")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789:"

        Message.Append("El Formato de la Hora es incorrecta.")
        Message.Append(vbCrLf)

        'Valida que no existan caracteres no permitidos
        If Not ValidarCaracteres(pHora, CaracteresPermitidos) OrElse ParteHora.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda de la hora
        Parte = String.Empty
        For Index As Integer = 0 To ParteHora(0).Length - 1
            If ParteHora(0).Substring(Index, 1) <> 0 Then
                Parte = ParteHora(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteHora(0) = Parte
        Else
            ParteHora(0) = 0
        End If

        If ParteHora.Length = 1 Then 'No se ingresó ":"
            If ParteHora(0) = 0 Then 'Si escribio solo ceros
                If pInicio Then
                    txtHoraDesde.Text = String.Empty
                Else
                    txtHoraHasta.Text = String.Empty
                End If
                Return True
            End If
            Select Case ParteHora(0).Length
                Case 1
                    If ParteHora(0) < 6 Then
                        Message.Append("La hora debe ser mayor a 6 y menor a 29")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    HoraFinal.Append("0")
                    HoraFinal.Append(ParteHora(0))
                    HoraFinal.Append(":")
                    If pInicio Then
                        HoraFinal.Append("00")
                    Else
                        HoraFinal.Append("45")
                    End If
                Case 2
                    If ParteHora(0) > 29 AndAlso ParteHora(0).Substring(1, 1) > 5 Then
                        Message.Append("Los minutos deben ser 0, 15, 30 o 45")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    If ParteHora(0) <= 29 Then
                        If ParteHora(0) < 10 Then
                            HoraFinal.Append("0")
                        End If
                        HoraFinal.Append(ParteHora(0))
                    Else
                        HoraFinal.Append("0")
                        HoraFinal.Append(ParteHora(0).Substring(0, 1))
                    End If
                    HoraFinal.Append(":")
                    If ParteHora(0) <= 29 Then
                        If pInicio Then
                            HoraFinal.Append("00")
                        Else
                            HoraFinal.Append("45")
                        End If
                    Else
                        HoraFinal.Append(ParteHora(0).Substring(1, 1))
                        HoraFinal.Append("0")
                    End If
                Case 3
                    If ParteHora(0).Substring(0, 2) > 29 Then
                        If ParteHora(0).Substring(1, 2) > 45 Then
                            Message.Append("Los minutos deben ser 0, 15, 30 o 45")
                            Mensaje(Message.ToString, TipoMensaje.DeError)
                            Return False
                        End If
                    Else
                        If ParteHora(0).Substring(2, 1) > 5 Then
                            Message.Append("Los minutos deben ser 0, 15, 30 o 45")
                            Mensaje(Message.ToString, TipoMensaje.DeError)
                            Return False
                        End If
                    End If
                    If ParteHora(0).Substring(0, 2) <= 29 Then
                        HoraFinal.Append(ParteHora(0).Substring(0, 2))
                    Else
                        HoraFinal.Append("0")
                        HoraFinal.Append(ParteHora(0).Substring(0, 1))
                    End If
                    HoraFinal.Append(":")
                    If ParteHora(0).Substring(0, 2) <= 29 Then
                        HoraFinal.Append(ParteHora(0).Substring(2, 1))
                        HoraFinal.Append("0")
                    Else
                        HoraFinal.Append(ParteHora(0).Substring(1, 2))
                    End If
                Case 4
                    If ParteHora(0).Substring(0, 2) > 29 Then
                        Message.Append("La hora debe ser mayor a 6 y menor a 29")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    If ParteHora(0).Substring(2, 2) > 45 Then
                        Message.Append("Los minutos deben ser 0, 15, 30 o 45")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    HoraFinal.Append(ParteHora(0).Substring(0, 2))
                    HoraFinal.Append(":")
                    HoraFinal.Append(ParteHora(0).Substring(2, 2))
                Case 5
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
            End Select
        Else
            'Valida si hay solo ceros en los minutos
            Parte = String.Empty
            For Index As Integer = 0 To ParteHora(1).Length - 1
                If ParteHora(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteHora(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteHora(1) = 0
            End If
            If ParteHora(0) = 0 AndAlso ParteHora(1) = 0 Then
                If pInicio Then
                    txtHoraDesde.Text = String.Empty
                Else
                    txtHoraHasta.Text = String.Empty
                End If
                Return True
            End If
            If ParteHora(0) < 6 OrElse ParteHora(0) > 29 Then
                Message.Append("La hora debe ser mayor a 6 y menor a 29")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
            If ParteHora(1) <> String.Empty Then
                If ParteHora(1) < 0 OrElse (ParteHora(1).Length = 1 AndAlso ParteHora(1) > 5) OrElse ParteHora(1) > 59 Then
                    Message.Append("Los minutos deben ser 0, 15, 30 o 45")
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
                End If
                If ParteHora(0) = 29 AndAlso ParteHora(1) > 45 Then
                    Message.Append("La hora debe ser mayor a 6:00 y menor a 29:45")
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
                End If
            End If
            If ParteHora(0).Length = 1 Then
                HoraFinal.Append("0")
            End If
            HoraFinal.Append(ParteHora(0))
            HoraFinal.Append(":")
            If ParteHora(1) <> String.Empty Then
                HoraFinal.Append(ParteHora(1))
                If ParteHora(1).Length = 1 Then
                    HoraFinal.Append("0")
                End If
            Else
                If pInicio Then
                    HoraFinal.Append("00")
                Else
                    HoraFinal.Append("45")
                End If
            End If
        End If
        If Not (HoraFinal.ToString.EndsWith("00") OrElse HoraFinal.ToString.EndsWith("15") OrElse HoraFinal.ToString.EndsWith("30") OrElse HoraFinal.ToString.EndsWith("45")) Then
            Message.Append("Los minutos deben ser 0, 15, 30 o 45")
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If
        If pInicio Then
            txtHoraDesde.Text = HoraFinal.ToString
        Else
            txtHoraHasta.Text = HoraFinal.ToString
        End If
        Return True
    End Function

    Private Function ObtenerSoportesSeleccionados() As String
        Dim Soportes As New StringBuilder
        Dim CantEmisoras, Index As Integer

        CantEmisoras = EmisorasSeleccionadas.Rows.Count
        For Each Emisora As DataRow In EmisorasSeleccionadas.Rows
            Index += 1
            Soportes.Append(Emisora("Emisora_Id"))
            If Index < CantEmisoras Then
                Soportes.Append(",")
            End If
        Next
        Return Soportes.ToString
    End Function

    Private Function ObtenerTarget(ByVal pTarget As String) As String
        Dim Targets As String()
        Targets = pTarget.Split("-")
        If Targets.Length > 1 Then
            Return Targets(Targets.Length - 1).Trim
        End If
        Return String.Empty
    End Function
#End Region

End Class

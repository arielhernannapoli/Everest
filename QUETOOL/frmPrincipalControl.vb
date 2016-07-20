
Public Class frmPrincipalControl
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
    Friend WithEvents UltraToolbarsManager As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents frmPrincipalControl_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _frmPrincipalControl_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPrincipalControl_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPrincipalControl_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPrincipalControl_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Avisos")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Datos Disponibles")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Avisos")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Confirmacion")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MacheoNoConfirmados")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desconfirmacion")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Confirmacion")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MacheoNoConfirmados")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Desconfirmacion")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Datos Disponibles")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipalControl))
        Me.UltraToolbarsManager = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.frmPrincipalControl_Fill_Panel = New System.Windows.Forms.Panel
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        CType(Me.UltraToolbarsManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraToolbarsManager
        '
        Me.UltraToolbarsManager.DesignerFlags = 1
        Me.UltraToolbarsManager.DockWithinContainer = Me
        Me.UltraToolbarsManager.LockToolbars = True
        Me.UltraToolbarsManager.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(339, 348)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(286, 22)
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar1.Text = "UltraToolbar"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool1, ButtonTool1, ButtonTool2})
        Me.UltraToolbarsManager.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        PopupMenuTool2.SharedProps.Caption = "Avisos"
        PopupMenuTool2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4, ButtonTool5})
        ButtonTool6.SharedProps.Caption = "Confirmación"
        ButtonTool7.SharedProps.Caption = "Macheo No Confirmados"
        ButtonTool8.SharedProps.Caption = "Salir"
        ButtonTool9.SharedProps.Caption = "Desconfirmación"
        ButtonTool10.SharedProps.Caption = "Datos Disponibles"
        Me.UltraToolbarsManager.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool2, ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10})
        '
        'frmPrincipalControl_Fill_Panel
        '
        Me.frmPrincipalControl_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmPrincipalControl_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmPrincipalControl_Fill_Panel.Location = New System.Drawing.Point(0, 47)
        Me.frmPrincipalControl_Fill_Panel.Name = "frmPrincipalControl_Fill_Panel"
        Me.frmPrincipalControl_Fill_Panel.Size = New System.Drawing.Size(828, 458)
        Me.frmPrincipalControl_Fill_Panel.TabIndex = 0
        '
        '_frmPrincipalControl_Toolbars_Dock_Area_Left
        '
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 47)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.Name = "_frmPrincipalControl_Toolbars_Dock_Area_Left"
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 458)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager
        '
        '_frmPrincipalControl_Toolbars_Dock_Area_Right
        '
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(828, 47)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.Name = "_frmPrincipalControl_Toolbars_Dock_Area_Right"
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 458)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager
        '
        '_frmPrincipalControl_Toolbars_Dock_Area_Top
        '
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.Name = "_frmPrincipalControl_Toolbars_Dock_Area_Top"
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(828, 47)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager
        '
        '_frmPrincipalControl_Toolbars_Dock_Area_Bottom
        '
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 505)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.Name = "_frmPrincipalControl_Toolbars_Dock_Area_Bottom"
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(828, 0)
        Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager
        '
        'frmPrincipalControl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(828, 505)
        Me.Controls.Add(Me.frmPrincipalControl_Fill_Panel)
        Me.Controls.Add(Me._frmPrincipalControl_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmPrincipalControl_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmPrincipalControl_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmPrincipalControl_Toolbars_Dock_Area_Bottom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrincipalControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Everest v.1.0.0.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UltraToolbarsManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Eventos"
    Private Sub UltraToolbarsManager_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager.ToolClick
        Select Case e.Tool.Key
            Case "Confirmacion"
                If Not Actualizando() Then
                    Call ConfirmarAvisos()
                End If
            Case "MacheoNoConfirmados"
                Call MachearNoConfirmados()
            Case "Desconfirmacion"
                If Not Actualizando() Then
                    Call DesconfirmarAvisos()
                End If
                Call DesconfirmarAvisos()
            Case "Datos Disponibles"
                Call DatosDisponibles()
            Case "Salir"
                Me.Close()
        End Select
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub ConfirmarAvisos()
        Dim Confirmados As New frmConfirmacionAvisos
        Call Confirmados.ShowDialog()
    End Sub

    Private Sub MachearNoConfirmados()
        Dim NoConfirmados As New frmMacheoAvisos
        Call NoConfirmados.ShowDialog()
    End Sub

    Private Sub DesconfirmarAvisos()
        Dim Desconfirmados As New frmDesconfirmacionAvisos
        Call Desconfirmados.ShowDialog()
    End Sub

    Private Sub DatosDisponibles()
        Dim ControlMacheo As New Control_Macheo
        Dim dt As New DataTable
        Dim datos As String = "hola" & vbCr

        dt = ControlMacheo.ObtenerDatosDisponibles(Date.Today.Year, Date.Today.Month)

        If Not dt.Rows.Count = 0 Then
            '          [nAnoMes] as ANOMES
            ',[nCierre_Cargado] as CIERRE_CARGADO
            ',[dFecha_Carga_Cierre] as FECHA_CIERRE
            ',[dUltima_Actualizacion] as FECHA_ACTUALIZACION
            ',[nDia_Hasta_TVC] as TV_ABIERTA
            ',[nDia_Hasta_TVI] as TV_INTERIOR
            ',[nDia_Hasta_TVV] as TV_CABLE 

            datos = "Última fecha de actualización: " & dt.Rows(0)("FECHA_ACTUALIZACION").ToString & vbCr & _
            "TV Abierta actualizado hasta el: " & dt.Rows(0)("TV_ABIERTA").ToString & vbCr & _
            "TV Cable actualizado hasta el: " & dt.Rows(0)("TV_CABLE").ToString & vbCr & _
            "TV Interior actualizado hasta el: " & dt.Rows(0)("TV_INTERIOR").ToString

            MessageBox.Show(datos, "Admedia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Datos no encontrados", "Admedia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Function Actualizando() As Boolean
        Dim ControlMacheo As New Control_Macheo
        Dim dt As New DataTable

        dt = ControlMacheo.ObtenerDatosActualizacion()

        If dt.Rows.Count = 0 Then
            Return False
        Else
            MessageBox.Show("El proceso de actualización en el " & dt.Rows(0)("ORIGEN").ToString & " comenzó: " & dt.Rows(0)("FECHA").ToString, "Actualizando Admedia...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If

    End Function

#End Region

    Private Sub frmPrincipalControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class


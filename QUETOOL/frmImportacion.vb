Public Class frmImportacion
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
    Friend WithEvents fraDestino As System.Windows.Forms.GroupBox
    Friend WithEvents fraEjercicios As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAgregarTema As System.Windows.Forms.Button
    Friend WithEvents lstOTema As System.Windows.Forms.ListBox
    Friend WithEvents lstDTema As System.Windows.Forms.ListBox
    Friend WithEvents fraDEjercicio As System.Windows.Forms.GroupBox
    Friend WithEvents FraOejercicio As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAgregarEjer As System.Windows.Forms.Button
    Friend WithEvents fraOTema As System.Windows.Forms.GroupBox
    Friend WithEvents freDTema As System.Windows.Forms.GroupBox
    Friend WithEvents fraOrigen As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOPeriodo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As QUETOOL.txtTexto
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents tblAcciones As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _Form1_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Form1_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents cmdQuitarEjer As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarTema As System.Windows.Forms.Button
    Friend WithEvents treOEjercicio As System.Windows.Forms.TreeView
    Friend WithEvents treDEjercicio As System.Windows.Forms.TreeView
    Friend WithEvents cmdAgregarTodosTema As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarTodosTema As System.Windows.Forms.Button
    Friend WithEvents dtpFinCampaña As QUETOOL.dtpFecha
    Friend WithEvents dtpInicioCampaña As QUETOOL.dtpFecha
    Friend WithEvents lblDias As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDestinoFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDestinoInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDiasDestino As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmImportacion))
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("Menu")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("guardar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("guardar")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.fraDEjercicio = New System.Windows.Forms.GroupBox
        Me.freDTema = New System.Windows.Forms.GroupBox
        Me.lstDTema = New System.Windows.Forms.ListBox
        Me.fraDestino = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDiasDestino = New System.Windows.Forms.Label
        Me.dtpDestinoFin = New System.Windows.Forms.DateTimePicker
        Me.dtpDestinoInicio = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.fraOrigen = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.lblDias = New System.Windows.Forms.Label
        Me.treDEjercicio = New System.Windows.Forms.TreeView
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOPeriodo = New System.Windows.Forms.Label
        Me.FraOejercicio = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFinCampaña = New QUETOOL.dtpFecha
        Me.dtpInicioCampaña = New QUETOOL.dtpFecha
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCodigo = New QUETOOL.txtTexto
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.fraOTema = New System.Windows.Forms.GroupBox
        Me.cmdAgregarTodosTema = New System.Windows.Forms.Button
        Me.cmdQuitarTodosTema = New System.Windows.Forms.Button
        Me.cmdQuitarTema = New System.Windows.Forms.Button
        Me.lstOTema = New System.Windows.Forms.ListBox
        Me.cmdAgregarTema = New System.Windows.Forms.Button
        Me.fraEjercicios = New System.Windows.Forms.GroupBox
        Me.cmdQuitarEjer = New System.Windows.Forms.Button
        Me.cmdAgregarEjer = New System.Windows.Forms.Button
        Me.treOEjercicio = New System.Windows.Forms.TreeView
        Me.tblAcciones = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._Form1_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Form1_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.fraDEjercicio.SuspendLayout()
        Me.freDTema.SuspendLayout()
        Me.fraDestino.SuspendLayout()
        Me.fraOrigen.SuspendLayout()
        Me.FraOejercicio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFinCampaña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicioCampaña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraOTema.SuspendLayout()
        Me.fraEjercicios.SuspendLayout()
        CType(Me.tblAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraDEjercicio
        '
        Me.fraDEjercicio.Controls.Add(Me.freDTema)
        Me.fraDEjercicio.Controls.Add(Me.fraDestino)
        Me.fraDEjercicio.Controls.Add(Me.fraOrigen)
        Me.fraDEjercicio.Location = New System.Drawing.Point(324, 30)
        Me.fraDEjercicio.Name = "fraDEjercicio"
        Me.fraDEjercicio.Size = New System.Drawing.Size(282, 612)
        Me.fraDEjercicio.TabIndex = 17
        Me.fraDEjercicio.TabStop = False
        Me.fraDEjercicio.Text = "Nuevo Ejercicio"
        '
        'freDTema
        '
        Me.freDTema.Controls.Add(Me.lstDTema)
        Me.freDTema.Enabled = False
        Me.freDTema.Location = New System.Drawing.Point(8, 424)
        Me.freDTema.Name = "freDTema"
        Me.freDTema.Size = New System.Drawing.Size(264, 184)
        Me.freDTema.TabIndex = 24
        Me.freDTema.TabStop = False
        Me.freDTema.Text = "Temas"
        '
        'lstDTema
        '
        Me.lstDTema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDTema.Location = New System.Drawing.Point(8, 16)
        Me.lstDTema.Name = "lstDTema"
        Me.lstDTema.Size = New System.Drawing.Size(248, 158)
        Me.lstDTema.TabIndex = 2
        '
        'fraDestino
        '
        Me.fraDestino.Controls.Add(Me.Label3)
        Me.fraDestino.Controls.Add(Me.lblDiasDestino)
        Me.fraDestino.Controls.Add(Me.dtpDestinoFin)
        Me.fraDestino.Controls.Add(Me.dtpDestinoInicio)
        Me.fraDestino.Controls.Add(Me.Label6)
        Me.fraDestino.Controls.Add(Me.Label4)
        Me.fraDestino.Location = New System.Drawing.Point(8, 312)
        Me.fraDestino.Name = "fraDestino"
        Me.fraDestino.Size = New System.Drawing.Size(264, 112)
        Me.fraDestino.TabIndex = 1
        Me.fraDestino.TabStop = False
        Me.fraDestino.Text = "Destino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Días"
        '
        'lblDiasDestino
        '
        Me.lblDiasDestino.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblDiasDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiasDestino.Location = New System.Drawing.Point(192, 88)
        Me.lblDiasDestino.Name = "lblDiasDestino"
        Me.lblDiasDestino.Size = New System.Drawing.Size(56, 20)
        Me.lblDiasDestino.TabIndex = 86
        '
        'dtpDestinoFin
        '
        Me.dtpDestinoFin.Enabled = False
        Me.dtpDestinoFin.Location = New System.Drawing.Point(8, 64)
        Me.dtpDestinoFin.Name = "dtpDestinoFin"
        Me.dtpDestinoFin.Size = New System.Drawing.Size(240, 20)
        Me.dtpDestinoFin.TabIndex = 80
        '
        'dtpDestinoInicio
        '
        Me.dtpDestinoInicio.Enabled = False
        Me.dtpDestinoInicio.Location = New System.Drawing.Point(8, 40)
        Me.dtpDestinoInicio.Name = "dtpDestinoInicio"
        Me.dtpDestinoInicio.Size = New System.Drawing.Size(240, 20)
        Me.dtpDestinoInicio.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Periodo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-88, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Fecha de Inicio"
        '
        'fraOrigen
        '
        Me.fraOrigen.Controls.Add(Me.Label2)
        Me.fraOrigen.Controls.Add(Me.dtpFechaFin)
        Me.fraOrigen.Controls.Add(Me.dtpFechaInicio)
        Me.fraOrigen.Controls.Add(Me.lblDias)
        Me.fraOrigen.Controls.Add(Me.treDEjercicio)
        Me.fraOrigen.Controls.Add(Me.Label9)
        Me.fraOrigen.Controls.Add(Me.Label1)
        Me.fraOrigen.Controls.Add(Me.lblOPeriodo)
        Me.fraOrigen.Location = New System.Drawing.Point(8, 24)
        Me.fraOrigen.Name = "fraOrigen"
        Me.fraOrigen.Size = New System.Drawing.Size(264, 280)
        Me.fraOrigen.TabIndex = 0
        Me.fraOrigen.TabStop = False
        Me.fraOrigen.Text = "Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Días"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(8, 232)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(248, 20)
        Me.dtpFechaFin.TabIndex = 87
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(8, 208)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(248, 20)
        Me.dtpFechaInicio.TabIndex = 86
        '
        'lblDias
        '
        Me.lblDias.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDias.Location = New System.Drawing.Point(200, 256)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(56, 20)
        Me.lblDias.TabIndex = 85
        '
        'treDEjercicio
        '
        Me.treDEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treDEjercicio.FullRowSelect = True
        Me.treDEjercicio.HideSelection = False
        Me.treDEjercicio.ImageIndex = -1
        Me.treDEjercicio.Location = New System.Drawing.Point(8, 56)
        Me.treDEjercicio.Name = "treDEjercicio"
        Me.treDEjercicio.SelectedImageIndex = -1
        Me.treDEjercicio.Size = New System.Drawing.Size(248, 128)
        Me.treDEjercicio.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Periodo a importar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Periodo"
        '
        'lblOPeriodo
        '
        Me.lblOPeriodo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblOPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOPeriodo.Location = New System.Drawing.Point(56, 24)
        Me.lblOPeriodo.Name = "lblOPeriodo"
        Me.lblOPeriodo.Size = New System.Drawing.Size(200, 20)
        Me.lblOPeriodo.TabIndex = 6
        '
        'FraOejercicio
        '
        Me.FraOejercicio.Controls.Add(Me.GroupBox1)
        Me.FraOejercicio.Controls.Add(Me.fraOTema)
        Me.FraOejercicio.Controls.Add(Me.fraEjercicios)
        Me.FraOejercicio.Location = New System.Drawing.Point(0, 30)
        Me.FraOejercicio.Name = "FraOejercicio"
        Me.FraOejercicio.Size = New System.Drawing.Size(318, 612)
        Me.FraOejercicio.TabIndex = 20
        Me.FraOejercicio.TabStop = False
        Me.FraOejercicio.Text = "Ejercicio Origen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFinCampaña)
        Me.GroupBox1.Controls.Add(Me.dtpInicioCampaña)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 108)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'dtpFinCampaña
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFinCampaña.Appearance = Appearance1
        Me.dtpFinCampaña.FlatMode = True
        Me.dtpFinCampaña.Location = New System.Drawing.Point(200, 80)
        Me.dtpFinCampaña.Name = "dtpFinCampaña"
        Me.dtpFinCampaña.Size = New System.Drawing.Size(96, 21)
        Me.dtpFinCampaña.TabIndex = 82
        '
        'dtpInicioCampaña
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpInicioCampaña.Appearance = Appearance2
        Me.dtpInicioCampaña.FlatMode = True
        Me.dtpInicioCampaña.Location = New System.Drawing.Point(80, 80)
        Me.dtpInicioCampaña.Name = "dtpInicioCampaña"
        Me.dtpInicioCampaña.Size = New System.Drawing.Size(96, 21)
        Me.dtpInicioCampaña.TabIndex = 81
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(80, 48)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(216, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Código"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Descripción"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ConDecimal = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(80, 16)
        Me.txtCodigo.Maximo = 0
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(184, 21)
        Me.txtCodigo.SoloLetra = False
        Me.txtCodigo.SoloNumero = True
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Image = CType(resources.GetObject("lblDescripcion.Image"), System.Drawing.Image)
        Me.lblDescripcion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(272, 16)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(21, 21)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fraOTema
        '
        Me.fraOTema.Controls.Add(Me.cmdAgregarTodosTema)
        Me.fraOTema.Controls.Add(Me.cmdQuitarTodosTema)
        Me.fraOTema.Controls.Add(Me.cmdQuitarTema)
        Me.fraOTema.Controls.Add(Me.lstOTema)
        Me.fraOTema.Controls.Add(Me.cmdAgregarTema)
        Me.fraOTema.Location = New System.Drawing.Point(12, 444)
        Me.fraOTema.Name = "fraOTema"
        Me.fraOTema.Size = New System.Drawing.Size(300, 162)
        Me.fraOTema.TabIndex = 23
        Me.fraOTema.TabStop = False
        Me.fraOTema.Text = "Temas"
        '
        'cmdAgregarTodosTema
        '
        Me.cmdAgregarTodosTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTodosTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregarTodosTema.Location = New System.Drawing.Point(256, 56)
        Me.cmdAgregarTodosTema.Name = "cmdAgregarTodosTema"
        Me.cmdAgregarTodosTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarTodosTema.TabIndex = 20
        Me.cmdAgregarTodosTema.Text = "8"
        '
        'cmdQuitarTodosTema
        '
        Me.cmdQuitarTodosTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTodosTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdQuitarTodosTema.Location = New System.Drawing.Point(256, 88)
        Me.cmdQuitarTodosTema.Name = "cmdQuitarTodosTema"
        Me.cmdQuitarTodosTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdQuitarTodosTema.TabIndex = 21
        Me.cmdQuitarTodosTema.Text = "7"
        '
        'cmdQuitarTema
        '
        Me.cmdQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdQuitarTema.Location = New System.Drawing.Point(256, 120)
        Me.cmdQuitarTema.Name = "cmdQuitarTema"
        Me.cmdQuitarTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdQuitarTema.TabIndex = 17
        Me.cmdQuitarTema.Text = "3"
        '
        'lstOTema
        '
        Me.lstOTema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstOTema.Location = New System.Drawing.Point(8, 24)
        Me.lstOTema.Name = "lstOTema"
        Me.lstOTema.Size = New System.Drawing.Size(240, 132)
        Me.lstOTema.TabIndex = 2
        '
        'cmdAgregarTema
        '
        Me.cmdAgregarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregarTema.Location = New System.Drawing.Point(256, 24)
        Me.cmdAgregarTema.Name = "cmdAgregarTema"
        Me.cmdAgregarTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarTema.TabIndex = 11
        Me.cmdAgregarTema.Text = "4"
        '
        'fraEjercicios
        '
        Me.fraEjercicios.Controls.Add(Me.cmdQuitarEjer)
        Me.fraEjercicios.Controls.Add(Me.cmdAgregarEjer)
        Me.fraEjercicios.Controls.Add(Me.treOEjercicio)
        Me.fraEjercicios.Location = New System.Drawing.Point(6, 132)
        Me.fraEjercicios.Name = "fraEjercicios"
        Me.fraEjercicios.Size = New System.Drawing.Size(300, 312)
        Me.fraEjercicios.TabIndex = 22
        Me.fraEjercicios.TabStop = False
        Me.fraEjercicios.Text = "Ejercicios"
        '
        'cmdQuitarEjer
        '
        Me.cmdQuitarEjer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarEjer.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdQuitarEjer.Location = New System.Drawing.Point(256, 56)
        Me.cmdQuitarEjer.Name = "cmdQuitarEjer"
        Me.cmdQuitarEjer.Size = New System.Drawing.Size(32, 28)
        Me.cmdQuitarEjer.TabIndex = 17
        Me.cmdQuitarEjer.Text = "3"
        '
        'cmdAgregarEjer
        '
        Me.cmdAgregarEjer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarEjer.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregarEjer.Location = New System.Drawing.Point(256, 24)
        Me.cmdAgregarEjer.Name = "cmdAgregarEjer"
        Me.cmdAgregarEjer.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarEjer.TabIndex = 14
        Me.cmdAgregarEjer.Text = "4"
        '
        'treOEjercicio
        '
        Me.treOEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treOEjercicio.FullRowSelect = True
        Me.treOEjercicio.HideSelection = False
        Me.treOEjercicio.ImageIndex = -1
        Me.treOEjercicio.Location = New System.Drawing.Point(8, 24)
        Me.treOEjercicio.Name = "treOEjercicio"
        Me.treOEjercicio.SelectedImageIndex = -1
        Me.treOEjercicio.Size = New System.Drawing.Size(240, 280)
        Me.treOEjercicio.TabIndex = 0
        '
        'tblAcciones
        '
        Me.tblAcciones.DesignerFlags = 1
        Me.tblAcciones.DockWithinContainer = Me
        Me.tblAcciones.RuntimeCustomizationOptions = Infragistics.Win.UltraWinToolbars.RuntimeCustomizationOptions.None
        Me.tblAcciones.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.Text = "Menu"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1})
        Me.tblAcciones.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        ButtonTool2.SharedProps.AppearancesSmall.Appearance = Appearance3
        ButtonTool2.SharedProps.ToolTipText = "Guardar la Hoja de Planificación"
        Me.tblAcciones.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool2})
        '
        '_Form1_Toolbars_Dock_Area_Top
        '
        Me._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top"
        Me._Form1_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(606, 24)
        Me._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = Me.tblAcciones
        '
        '_Form1_Toolbars_Dock_Area_Bottom
        '
        Me._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 647)
        Me._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom"
        Me._Form1_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(606, 0)
        Me._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.tblAcciones
        '
        '_Form1_Toolbars_Dock_Area_Left
        '
        Me._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 24)
        Me._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left"
        Me._Form1_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 623)
        Me._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = Me.tblAcciones
        '
        '_Form1_Toolbars_Dock_Area_Right
        '
        Me._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Form1_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(606, 24)
        Me._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right"
        Me._Form1_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 623)
        Me._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = Me.tblAcciones
        '
        'frmImportacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(606, 647)
        Me.Controls.Add(Me.FraOejercicio)
        Me.Controls.Add(Me.fraDEjercicio)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._Form1_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmImportacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importación"
        Me.fraDEjercicio.ResumeLayout(False)
        Me.freDTema.ResumeLayout(False)
        Me.fraDestino.ResumeLayout(False)
        Me.fraOrigen.ResumeLayout(False)
        Me.FraOejercicio.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtpFinCampaña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicioCampaña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraOTema.ResumeLayout(False)
        Me.fraEjercicios.ResumeLayout(False)
        CType(Me.tblAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim Grilladmin As New GrillAdmin
    Dim DebeGuardar As Boolean
    Dim IdoCampaña As Integer
    Dim IdoSistema As Integer
    Dim IdoEjercicio As Integer
    Dim TemasDestino As String
    Dim FechaOrigenSistemai As Date
    Dim FechaOrigenSistemaf As Date
    Dim FechaDestinoi As Date
    Dim FechaDestinof As Date
    Dim OrigenDetalle As DataTable
    Dim Soportes As DataTable
    Dim NuevasTarifas As DataTable
    Dim Audiencia As DataTable
    Dim ErrorNautilus As Boolean
    Dim arrSoporte(150) As Long
    Dim Sistema As New Sistemas
    Dim Spots As New DataTable
    Dim Detalles As New DataTable
    Dim Tipo As TipoAudiencia
    Dim Temas As DataTable
    Dim Calendario As New ArrayList
    Public ErrorCarga As Boolean = False
    Dim dtOtros As New DataTable("Otros")
#End Region

#Region "Metodos"
    Private Sub BuscarCliente()
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Cliente, txtDescripcion, txtCodigo, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()

        If Me.txtCodigo.Text = "" Then
            Me.lstOTema.Items.Clear()
            ' If Me.txtCodigo.Text = "" Then
            Me.treOEjercicio.Nodes.Clear()
            ' Exit Sub
            ' End If
            ' If Me.dtpFinCampaña.Value < Me.dtpInicioCampaña.Value Then
            Me.treOEjercicio.Nodes.Clear()
            ' Exit Sub
            ' End If
            Me.treDEjercicio.Nodes.Clear()
            Me.lstDTema.Items.Clear()
            Exit Sub
        End If

        CargarListas()
    End Sub
    Private Sub CargarListas()
        Me.lstOTema.Items.Clear()
        ' If Me.txtCodigo.Text = "" Then
        Me.treOEjercicio.Nodes.Clear()
        ' Exit Sub
        ' End If
        ' If Me.dtpFinCampaña.Value < Me.dtpInicioCampaña.Value Then
        Me.treOEjercicio.Nodes.Clear()
        ' Exit Sub
        ' End If
        Me.treDEjercicio.Nodes.Clear()
        Me.lstDTema.Items.Clear()
        BuscarEjercicios()
    End Sub
    Private Sub BuscarEjercicios()
        Dim e As New Ejercicios

        Listas.CargarTree(True, Me.treOEjercicio, e.ObtenerEjerciciosCliente(txtCodigo.Text, Me.dtpInicioCampaña.Value, Me.dtpFinCampaña.Value, Activo.IDMedio, Activo.IDTipoSoporte), "id_campania", "Campaña", "id_sistema", "Sistema", "id_ejercicio", "Ejercicio")

    End Sub
    Private Sub AgregarTema()
        'agrega elementos a las listas
        If Me.lstOTema.SelectedItem Is Nothing Then
            Exit Sub
        End If

        'agrega en alternativa
        Me.lstDTema.ValueMember = "ID"
        Me.lstDTema.DisplayMember = "Descripcion"

        'agrega el item en la alternativa
        Me.lstDTema.Items.Add(Me.lstOTema.SelectedItem)

        'lo saca de temas
        Me.lstOTema.Items.RemoveAt(Me.lstOTema.SelectedIndex)
        Me.DebeGuardar = True

    End Sub
    Private Sub AgregarTodosTemas()
        'carga todos los elementos de las alternativas
        Me.lstDTema.ValueMember = "ID"
        Me.lstDTema.DisplayMember = "Descripcion"

        'agrega los items en la alternativa
        Me.lstDTema.Items.AddRange(Me.lstOTema.Items)

        'borra los items de temas
        Me.lstOTema.Items.Clear()
        Me.DebeGuardar = True

    End Sub
    Private Sub QuitarTema()
        If Me.lstDTema.SelectedItem Is Nothing Then
            Exit Sub
        End If

        'agrega en temas
        Me.lstOTema.Items.Add(Me.lstDTema.SelectedItem)

        'lo saca de alternativa
        Me.lstDTema.Items.RemoveAt(Me.lstDTema.SelectedIndex)

        Me.DebeGuardar = True
    End Sub
    Private Sub QuitarTodosTemas()
        'saca todos los temas de la alternativa y los mueve a los temas no seleccionados
        If lstDTema.Items.Count <= 0 Then
            Exit Sub
        End If
        Me.lstDTema.ValueMember = "ID"
        Me.lstDTema.DisplayMember = "Descripcion"

        Me.lstOTema.Items.AddRange(Me.lstDTema.Items)

        Me.lstDTema.Items.Clear()

        Me.DebeGuardar = True
    End Sub
    Private Function ObtenerNuevasTarifas(ByVal Cliente As Integer, ByVal Sopostes As DataTable, ByVal Inicio As Date, ByVal Fin As Date) As DataTable
        Dim T As New Tarifas_tv
        Dim Ds As New DataSet, i As Integer
        For Each dr As DataRow In Soportes.Rows
            ReDim Preserve arrSoporte(i)

            ''dcaime 16/06/2010
            arrSoporte(i) = dr("id_soporte")
            T.Id_cliente = Cliente
            T.Id_medio = Activo.IDMedio
            T.Id_soporte = dr("id_soporte")
            T.F_inicio_vig = Inicio
            T.F_fin_vig = Fin
            T.ObteniendoTarifas(Ds, "Tarifas")
        Next



        Return Ds.Tables(0)


    End Function

    Private Sub AgregarTarifasDuplicadas()
        Dim s As New Spots, cantidad As Int16, i As Integer, Filas As DataRow
        Dim NuevaFila As DataRow

        s.Id_campania = Me.IdoCampaña
        s.Id_sistema = Me.IdoSistema
        s.Id_ejercicio = Me.IdoSistema
        'NuevasTarifas.Columns("Id_

        For Each R As DataRow In NuevasTarifas.Rows
            cantidad = s.CantidadSpotsTarifas(R("ID_TARIFA_TV"))
            If cantidad > 1 Then
                Filas = NuevasTarifas.Select("id_tarifa_tv=" & R("ID_TARIFA_TV"))(0)
                For i = 0 To cantidad - 1
                    NuevasTarifas.Rows.Add(Filas)
                Next
            End If
        Next


    End Sub
    Private Function ObtenerNodo(ByVal Nodo As TreeNode, ByVal Nivel As Integer) As TreeNode
        Dim Ret As TreeNode
        Select Case Nivel
            Case 0
                If Nodo.Parent Is Nothing Then ' si no tiene padre
                    Ret = Nodo
                Else
                    If Nodo.Parent.Parent Is Nothing Then
                        Ret = Nodo.Parent
                    Else
                        Ret = Nodo.Parent.Parent
                    End If
                End If
            Case 1
                If Nodo.GetNodeCount(True) = 0 Then ' si no tiene hijos
                    If Not Nodo.Parent Is Nothing Then ' si tiene padre
                        Ret = Nodo
                    Else ' si no tiene padre
                        Ret = Nodo.Nodes(0)
                    End If
                Else ' si tiene hijos
                    Ret = Nodo.Parent()
                End If
            Case 2
                If Nodo.Parent Is Nothing Then  ' si no tiene padre
                    Ret = Nodo
                Else ' si  tiene padre
                    If Nodo.GetNodeCount(True) = 0 Then 'no tiene hijos
                        Ret = Nodo.Parent.Parent
                    Else 'si tiene hijos
                        Ret = Nodo.Parent


                    End If
                End If

        End Select
        Return Ret
    End Function
    Private Sub PasarEjercicio()

        CopiarEjercicio(treOEjercicio.SelectedNode, Me.treDEjercicio)
        treOEjercicio.Enabled = False
    End Sub
    Private Sub CopiarEjercicio(ByVal nodo As TreeNode, ByVal TreeDestino As TreeView)
        TreeDestino.Nodes.Add(nodo.Parent.Parent.Text).Tag = nodo.Parent.Parent.Tag
        TreeDestino.Nodes(0).Nodes.Add(nodo.Parent.Text).Tag = nodo.Parent.Tag
        TreeDestino.Nodes(0).Nodes(0).Nodes.Add(nodo.Text).Tag = nodo.Tag
        IdoCampaña = nodo.Parent.Parent.Tag
        IdoSistema = nodo.Parent.Tag
        IdoEjercicio = nodo.Tag
    End Sub
    Private Sub DevolverEjercicio()
        If treDEjercicio.SelectedNode Is Nothing Then
            Exit Sub
        End If
        If Not treDEjercicio.SelectedNode.GetNodeCount(True) = 0 Then
            Exit Sub
        End If
        Me.treDEjercicio.Nodes.Remove(Me.treDEjercicio.SelectedNode.Parent.Parent)
        LimpiarDatosOrigen()
        treOEjercicio.Enabled = True
    End Sub
    Sub LimpiarDatosOrigen()
        Me.lblOPeriodo.Text = ""
        Me.IdoCampaña = 0
        Me.IdoEjercicio = 0
        Me.IdoSistema = 0
        Me.QuitarTodosTemas()

    End Sub
    Private Sub LimparFormulario()
        Me.lstOTema.Items.Clear()
        Me.lstDTema.Items.Clear()
        Me.txtCodigo.Text = ""
        Me.txtDescripcion.Text = ""

        Me.lblOPeriodo.Text = ""
        Me.IdoCampaña = 0
        Me.IdoEjercicio = 0
        Me.IdoSistema = 0
    End Sub
    Sub CargarDatosOrigen()
        'Dim  As New Sistemas

        Sistema.Id_campania = IdoCampaña
        Sistema.Id_sistema = IdoSistema

        Sistema.BuscarPorID()

        Dim T As New Temas

        T.Id_campania = Activo.IDCampaña
        Temas = T.ObtenerTemasPorCampaña
        Select Case Activo.IDTipoSoporte
            Case 1
                Tipo = TipoAudiencia.Abierta
            Case 2
                Tipo = TipoAudiencia.Intetior
            Case 3
                Tipo = TipoAudiencia.Cable
            Case 4
                Tipo = TipoAudiencia.Satelital
        End Select

        Me.lblOPeriodo.Text = Sistema.F_inicio & " a " & Sistema.F_fin

        Me.FechaOrigenSistemaf = Sistema.F_fin
        Me.FechaOrigenSistemai = Sistema.F_inicio

        Me.dtpFechaInicio.Value = Sistema.F_inicio
        Me.dtpFechaFin.Value = Sistema.F_fin

    End Sub
    Sub Importar()

        Try

            If treDEjercicio.GetNodeCount(True) = 0 Then  ' si hay datos en el destino
                Exit Sub
            End If
            If Me.lstDTema.Items.Count = 0 Then
                Exit Sub
            End If
            Dim str As String = ControlarFechas(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, Me.FechaDestinoi, Me.FechaDestinof)
            If str <> "" Then
                Mensajes.Mensaje(str, TipoMensaje.Informacion)
                Exit Sub
            End If
            'Dim sd As New Spots_detalle
            'If sd.ObtenerSpotDetalle(Me.IdoCampaña, Me.IdoSistema, Me.IdoEjercicio) Is Nothing Then
            '    Mensajes.Mensaje("El Ejercicio Seleccionado No Tiene Spots", TipoMensaje.Informacion)
            '    Exit Sub
            'End If
            'If sd.ObtenerSpotDetalle(Me.IdoCampaña, Me.IdoSistema, Me.IdoEjercicio).Rows.Count = 0 Then
            '    Mensajes.Mensaje("El Ejercicio Seleccionado No Tiene Spots", TipoMensaje.Informacion)
            '    Exit Sub
            'End If
            '        Dim Calendario As New ArrayList '= Me.ObtenerFechasCalendario(Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value)
            Me.Cursor = Cursors.WaitCursor
            OrigenDetalle = Me.ObtenerSpots(Me.IdoCampaña, Me.IdoSistema, Me.IdoEjercicio, Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, Me.TemasConcatenado)
            Soportes = ObtenerSoportesOrigen()
            NuevasTarifas = Me.ObtenerNuevasTarifas(Me.txtCodigo.Text, Soportes, Me.FechaDestinoi, Me.FechaDestinof)
            'AgregarTarifasDuplicadas()
            Audiencia = Me.CalcularAudiencia(Sistema, Soportes, Sistema.F_inicio_aud, Sistema.F_fin_aud, Sistema.Id_target_1, Sistema.Id_target_2, 1, Tipo)

            Dim S As New Spots
            S.CargarEsquema(Spots)
            Spots.Columns.Add("HINICIO", GetType(Integer))
            Spots.Columns.Add("MINICIO", GetType(Integer))
            Spots.Columns.Add("HFIN", GetType(Integer))
            Spots.Columns.Add("MFIN", GetType(Integer))
            Spots.Columns.Add("Dias", GetType(String))

            Dim D As New Spots_detalle
            D.CargarEsquema(Detalles)
            Sistema.Id_campania = Activo.IDCampaña
            Sistema.Id_sistema = Activo.IDSistema
            Sistema.BuscarPorID()
            Select Case Tipo
                Case TipoAudiencia.Abierta
                    Me.CargarSpotsTVA(NuevasTarifas, Audiencia, Sistema)
                Case TipoAudiencia.Intetior
                    Me.CargarSpotsTVC(NuevasTarifas, Audiencia, Sistema)
                Case TipoAudiencia.Cable
                    Me.CargarSpotsTVC(NuevasTarifas, Audiencia, Sistema)
                Case TipoAudiencia.Satelital
                    Me.CargarSpotsTVS(NuevasTarifas, Audiencia, Sistema)
            End Select
            CrearDtOtros()
            ArmarNuevoEjercicio(Spots, OrigenDetalle, OrigenDetalle, Calendario)
            Guardar()
            MsgBox("Se importaron " & Detalles.Rows.Count & " Avisos de " & OrigenDetalle.Rows.Count & " Originales", MsgBoxStyle.Information)
            Me.Close()
            If dtOtros.Rows.Count > 0 Then
                If Mensajes.Mensaje("¿Desea Ver los Programas No Importados?", TipoMensaje.SiNo) = MsgBoxResult.Yes Then
                    Dim f As New frmTarifasNoEncontradas

                    f.Datos = dtOtros
                    f.Cargar()
                    f.ShowDialog()
                    Me.Close()
                Else
                    Me.Close()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ErrorCarga = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try
    End Sub
    Private Function ArmarNuevoEjercicio(ByVal Spots As DataTable, ByVal DetOrigen As DataTable, ByVal Detalle As DataTable, ByVal Calendario As ArrayList) As DataSet
        Dim SpotsIguales As DataRow()
        Dim DetalleFechas As DataTable
        Dim FilasaBorrar As New ArrayList
        Dim DetallesNuevos As DataRow(), i As Integer
        Dim DetalleTarifa As DataRow(), IdSpot As Integer
        Dim DrNoEncontrado As DataRow
        Dim SpotsTarifa As DataRow()
        Dim tarifa As New Tarifas_tv
        Dim Dias As String

        Dim NuevoRegistro As DataRow
        Dim iD As Integer
        Detalles.Columns("Id_Spot_Detalle").AutoIncrement = True
        Detalles.Columns("Id_Spot_Detalle").AutoIncrementSeed = 1
        Try

            For Each FilaDetalle As DataRow In Detalle.Rows
                DetalleTarifa = Spots.Select("ID_TARIFA_TV=" & FilaDetalle("ID_TARIFA_TV"))
                If DetalleTarifa.Length > 0 Then
                    NuevoRegistro = Detalles.NewRow
                    'IdSpot = Grilladmin.ObtenerDato(Spots, "ID_TARIFA_TV=" & DetalleTarifa("ID_TARIFA_TV"), "ID_SPOT")

                    NuevoRegistro("Id_Spot") = DetalleTarifa(0)("id_spot")  ' FilaSpot("id_spot")

                    NuevoRegistro("Id_Tema") = FilaDetalle("ID_Tema")
                    NuevoRegistro("Duracion") = Grilladmin.ObtenerDato(Temas, "ID_TEMA='" & FilaDetalle("ID_Tema") & "'", "DURACION")
                    NuevoRegistro("F_Spot") = FilaDetalle("NuevaFecha")
                    NuevoRegistro("id_spot_estado") = "P"
                    NuevoRegistro("id_orden_sigeme") = 0

                    Detalles.Rows.Add(NuevoRegistro)
                Else

                    'tarifa.Id_tarifa_tv = FilaDetalle("ID_TARIFA_TV")
                    Dias = ObtenerDiaEmicion(FilaDetalle("F_Spot")) 'tarifa.ObtenerDia 'Grilladmin.ObtenerDato(NuevasTarifas, "ID_TARIFA_TV=" & FilaDetalle("ID_TARIFA_TV"), "Dias")
                    DetallesNuevos = BuscarEquivalente(FilaDetalle("hinicio"), FilaDetalle("minicio"), FilaDetalle("hfin"), FilaDetalle("mfin"), FilaDetalle("id_soporte"), 1, Spots, Dias)
                    If DetallesNuevos.Length > 0 Then
                        NuevoRegistro = Detalles.NewRow
                        ' IdSpot = Grilladmin.ObtenerDato(Spots, "ID_TARIFA_TV=" & DetalleTarifa(0)("ID_TARIFA_TV"), "ID_SPOT")

                        NuevoRegistro("Id_Spot") = DetallesNuevos(0)("id_spot") ' IdSpot(0)("id_spot")  ' FilaSpot("id_spot")

                        NuevoRegistro("Id_Tema") = FilaDetalle("ID_Tema")
                        NuevoRegistro("Duracion") = Grilladmin.ObtenerDato(Temas, "ID_TEMA='" & FilaDetalle("ID_Tema") & "'", "DURACION")
                        NuevoRegistro("F_Spot") = FilaDetalle("NuevaFecha")
                        NuevoRegistro("id_spot_estado") = "P"
                        NuevoRegistro("id_orden_sigeme") = 0

                        Detalles.Rows.Add(NuevoRegistro)
                    Else

                        DrNoEncontrado = dtOtros.NewRow
                        ' tarifa.Id_tarifa_tv = FilaDetalle("ID_TARIFA_TV")
                        DrNoEncontrado("ID_Campania") = Me.IdoCampaña
                        DrNoEncontrado("ID_Sistema") = Me.IdoSistema
                        DrNoEncontrado("ID_Ejercicio") = Me.IdoEjercicio

                        DrNoEncontrado("id_tarifa_tv") = FilaDetalle("ID_TARIFA_TV")
                        DrNoEncontrado("id_programa") = FilaDetalle("id_programa")
                        DrNoEncontrado("id_soporte") = FilaDetalle("id_soporte")
                        DrNoEncontrado("Tema") = FilaDetalle("ID_TEMA")
                        DrNoEncontrado("programa") = FilaDetalle("programa")

                        DrNoEncontrado("Fecha") = FilaDetalle("nuevafecha")
                        DrNoEncontrado("Hora Emicion") = FilaDetalle("Hora Inicio") & " a " & FilaDetalle("Hora Fin")

                        DrNoEncontrado("dias") = Dias

                        'DrNoEncontrado("Soporte") = Grilladmin.ObtenerDato(Soportes, "Senial=" & FilaDetalle("id_soporte"), "Descripcion")

                        DrNoEncontrado("Soporte") = Grilladmin.ObtenerDato(Soportes, "ID_SOPORTE=" & FilaDetalle("id_soporte"), "Descripcion")

                        dtOtros.Rows.Add(DrNoEncontrado)
                    End If


                End If

            Next

        Catch ex As Exception
            ErrorCarga = True
            Throw ex
        End Try
    End Function
    Private Function ObtenerDiaEmicion(ByVal FechaSpot As Date) As String
        Select Case FechaSpot.DayOfWeek
            Case DayOfWeek.Sunday
                Return "D"
            Case DayOfWeek.Monday
                Return "L"
            Case DayOfWeek.Tuesday
                Return "M"
            Case DayOfWeek.Wednesday
                Return "X"
            Case DayOfWeek.Thursday
                Return "J"
            Case DayOfWeek.Friday
                Return "V"
            Case DayOfWeek.Saturday
                Return "S"
        End Select
    End Function
    'Private Sub CargarNoEncontrados()
    '    Dim DrNoEncontrado As DataRow
    '    Dim SpotsTarifa As DataRow()
    '    Dim tarifa As New Tarifas_tv
    '    For Each dr As DataRow In Me.OrigenDetalle.Rows
    '        SpotsTarifa = Spots.Select("id_tarifa_tv=" & dr("id_tarifa_tv"))
    '        If SpotsTarifa.Length = 0 Then
    '            DrNoEncontrado = dtOtros.NewRow
    '            tarifa.Id_tarifa_tv = dr("ID_TARIFA_TV")


    '            DrNoEncontrado("id_tarifa_tv") = dr("ID_TARIFA_TV")
    '            DrNoEncontrado("id_programa") = dr("id_programa")
    '            DrNoEncontrado("id_soporte") = dr("id_soporte")
    '            DrNoEncontrado("Tema") = dr("id_tema")
    '            DrNoEncontrado("programa") = dr("programa")

    '            DrNoEncontrado("Fecha") = dr("nuevafecha")

    '            DrNoEncontrado("dias") = tarifa.ObtenerDia

    '            DrNoEncontrado("Soporte") = Grilladmin.ObtenerDato(Soportes, "id_sooprte=" & dr("id_soporte"), "Descripcion")

    '            dtOtros.Rows.Add(DrNoEncontrado)
    '        End If
    '    Next

    'End Sub
    Private Function BuscarEquivalente(ByVal HoraInicio As Int64, ByVal MinInicio As Int64, ByVal HOrafin As Integer, ByVal MinFin As Integer, ByVal Soporte As Int64, ByVal Medio As Integer, ByVal Spot As DataTable, ByVal Dia As String) As DataRow()
        Try


            Dim Filtro As String = "HINICIO <=" & HoraInicio & " and MINICIO <=" & MinInicio & " and Id_Soporte=" & Soporte & " and HFIN >= " & HoraInicio & " And MFIN >=" & MinInicio
            Filtro &= " and Dias like " & "'%" & Dia & "%'"
            Dim DetPosibles As DataRow() = Spot.Select(Filtro)

            ' If DetPosibles.Length > 0 Then
            Return DetPosibles
            ' End If
        Catch ex As Exception
            ErrorCarga = True
            Throw ex
        End Try
    End Function
    Private Function CalcularAudiencia(ByVal Si As Sistemas, ByVal Soportes As DataTable, ByVal InicioAudiencia As Date, ByVal FinAudiencia As Date, ByVal Target1 As Integer, ByVal Target2 As Integer, ByVal medio As Integer, ByVal Tipo As TipoAudiencia) As DataTable
        Dim dsAudiencia As New DataSet
        Try
            Select Case Tipo
                Case TipoAudiencia.Abierta
                    Dim a As New Audiencia_Tva
                    For Each dr As DataRow In Soportes.Rows

                        ''dcaime 16/06/2010
                        a.Id_Medio = Activo.IDMedio
                        a.Id_Soporte = dr("id_soporte")
                        a.ObteniendoAudienciaTVA(dsAudiencia, "Audiencia", Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    Next
                Case TipoAudiencia.Cable
                    'frmProgresoCargaGrilla.Instancia.Close()
                    Dim f As New frmCargarAudienciaTVC
                    f.Sistema = Si
                    f.Soportes = arrSoporte
                    f.ShowDialog()

                    If f.HayError Then
                        ErrorNautilus = True
                        Exit Function
                    End If
                    Dim ac As New Audiencia_tvc
                    For Each dr As DataRow In Soportes.Rows
                        ac.Id_medio = Activo.IDMedio
                        ac.Id_soporte = dr("id_soporte")
                        ac.ObteniendoAudienciaTVC(dsAudiencia, "AudienciaTVA", Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    Next

                Case TipoAudiencia.Intetior
                    frmProgresoCargaGrilla.Instancia.Close()
                    Dim f As New frmCargarAudienciaTVI
                    f.Sistema = Si
                    f.Soportes = arrSoporte
                    f.ShowDialog()

                    If f.HayError Then
                        ErrorNautilus = True
                        Exit Function
                    End If
                    Dim ai As New Audiencia_TVI
                    For Each dr As DataRow In Soportes.Rows
                        ai.Id_Medio = Activo.IDMedio
                        ai.Id_Soporte = dr("id_soporte")
                        ai.ObteniendoAudienciaTVI(dsAudiencia, "AudienciaTVI", Si.F_inicio_aud, Si.F_fin_aud, Si.Id_target_1, Si.Id_target_2)
                    Next
                Case TipoAudiencia.Satelital
                    dsAudiencia.Tables.Add("Audiencia")
            End Select
            Return dsAudiencia.Tables(0)

        Catch ex As Exception
            ErrorCarga = True
            Throw ex
        End Try
    End Function
    Private Sub CargarSpotsTVA(ByVal Tarifas As DataTable, ByVal Audiencia As DataTable, ByVal sistema As Sistemas)
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow
        Dim IdPrograma As Integer
        Dim TieneTanda As Boolean = True



        For j = 0 To Tarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = Spots.NewRow
            Try
                If Tarifas.Rows(j).Item("ID_PROGRAMA") Is DBNull.Value Then
                    IdPrograma = 0
                Else
                    IdPrograma = Tarifas.Rows(j).Item("ID_PROGRAMA")
                End If

                ColRow = Audiencia.Select("ID_PROGRAMA=" & IdPrograma)

                If Audiencia.Select("ID_PROGRAMA=" & IdPrograma & " AND PROGRAMA_TANDA='T'").Length > 0 Then
                    TieneTanda = True
                Else
                    TieneTanda = False
                End If

                Dr("f_alta") = Now.Date
                Dr("u_alta") = Activo.Login

                If ColRow.Length >= 1 Then

                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(Spots) + k

                    Dr("ID_Campania") = Activo.IDCampaña
                    Dr("ID_Sistema") = Activo.IDSistema
                    Dr("ID_Ejercicio") = Activo.IDEjercicio
                    Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = Tarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = Tarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = Tarifas.Rows(j)("Programa")
                    Dr("Bruto") = Tarifas.Rows(j)("Tarifa Bruta")
                    Dr("Neto") = Tarifas.Rows(j)("Tarifa Bruta")
                    Dr("Tipo_Planificacion") = 0
                    Dr("desc_campania") = Activo.Campaña
                    Dr("desc_sistema") = Activo.Sistema
                    Dr("desc_ejercicio") = Activo.Ejercicio
                    Dr("id_Convenio") = 0
                    Dr("h_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(3, 2)



                    Dr("HINICIO") = Val(Dr("h_inicio"))
                    Dr("HFIN") = Dr("h_fin")

                    Dr("MINICIO") = Dr("m_inicio")
                    Dr("MFIN") = Dr("m_fin")

                    Dr("Dias") = Grilladmin.ObtenerDato(Tarifas, "ID_TARIFA_TV=" & Tarifas.Rows(j)("ID_TARIFA_TV"), "Dias")

                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0

                    'asigna los valores dependiendo los targets y tipo de planificacion
                    If ColRow.Length = 2 And TieneTanda Then
                        ' No tiene Target 2
                        If ColRow(0)("Id_Target") = sistema.Id_target_1 Then

                            Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_1") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_1") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_1") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_1") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_1") = ColRow(0)("FID")
                            Dr("RAT_TANDA_TARGET_1") = Valores.Redondear((ColRow(1)("RAT") * sistema.Deflactacion), "0.00") ' ColRow(1)("RAT")
                            Dr("SHR_TANDA_TARGET_1") = ColRow(1)("SHR")
                            Dr("AFF_TANDA_TARGET_1") = ColRow(1)("AFF")
                            Dr("RCH_TANDA_TARGET_1") = ColRow(1)("RCH")
                            Dr("RAT_M_TANDA_TARGET_1") = ColRow(1)("RAT_M")
                            Dr("FID_TANDA_TARGET_1") = ColRow(1)("FID")
                            Dr("RAT_PROG_TARGET_2") = 0
                            Dr("RAT_TANDA_TARGET_2") = 0
                        Else
                            Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_2") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_2") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_2") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_2") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_2") = ColRow(0)("FID")

                            Dr("RAT_TANDA_TARGET_2") = Valores.Redondear((ColRow(1)("RAT") * sistema.Deflactacion), "0.00")
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
                        'No tiene target 2
                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * sistema.Deflactacion), "0.00")
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

                        Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(1)("RAT") * sistema.Deflactacion), "0.00")
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

                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * sistema.Deflactacion), "0.00")
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
                        If ColRow(0)("Id_Target") = sistema.Id_target_1 Then

                            Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_1") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_1") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_1") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_1") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_1") = ColRow(0)("FID")
                            Dr("RAT_TANDA_TARGET_1") = Valores.Redondear((ColRow(1)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_1") = ColRow(1)("SHR")
                            Dr("AFF_TANDA_TARGET_1") = ColRow(1)("AFF")
                            Dr("RCH_TANDA_TARGET_1") = ColRow(1)("RCH")
                            Dr("RAT_M_TANDA_TARGET_1") = ColRow(1)("RAT_M")
                            Dr("FID_TANDA_TARGET_1") = ColRow(1)("FID")
                            Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(2)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_2") = ColRow(2)("SHR")
                            Dr("AFF_PROG_TARGET_2") = ColRow(2)("AFF")
                            Dr("RCH_PROG_TARGET_2") = ColRow(2)("RCH")
                            Dr("RAT_M_PROG_TARGET_2") = ColRow(2)("RAT_M")
                            Dr("FID_PROG_TARGET_2") = ColRow(2)("FID")
                            Dr("RAT_TANDA_TARGET_2") = Valores.Redondear((ColRow(3)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_2") = ColRow(3)("SHR")
                            Dr("AFF_TANDA_TARGET_2") = ColRow(3)("AFF")
                            Dr("RCH_TANDA_TARGET_2") = ColRow(3)("RCH")
                            Dr("RAT_M_TANDA_TARGET_2") = ColRow(3)("RAT_M")
                            Dr("FID_TANDA_TARGET_2") = ColRow(3)("FID")
                        Else
                            Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_PROG_TARGET_2") = ColRow(0)("SHR")
                            Dr("AFF_PROG_TARGET_2") = ColRow(0)("AFF")
                            Dr("RCH_PROG_TARGET_2") = ColRow(0)("RCH")
                            Dr("RAT_M_PROG_TARGET_2") = ColRow(0)("RAT_M")
                            Dr("FID_PROG_TARGET_2") = ColRow(0)("FID")

                            Dr("RAT_TANDA_TARGET_2") = Valores.Redondear((ColRow(1)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_2") = ColRow(1)("SHR")
                            Dr("AFF_TANDA_TARGET_2") = ColRow(1)("AFF")
                            Dr("RCH_TANDA_TARGET_2") = ColRow(1)("RCH")
                            Dr("RAT_M_TANDA_TARGET_2") = ColRow(1)("RAT_M")
                            Dr("FID_TANDA_TARGET_2") = ColRow(1)("FID")

                            Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(2)("RAT") * sistema.Deflactacion), "0.00") 'ColRow(2)("RAT")
                            Dr("SHR_PROG_TARGET_1") = ColRow(2)("SHR")
                            Dr("AFF_PROG_TARGET_1") = ColRow(2)("AFF")
                            Dr("RCH_PROG_TARGET_1") = ColRow(2)("RCH")
                            Dr("RAT_M_PROG_TARGET_1") = ColRow(2)("RAT_M")
                            Dr("FID_PROG_TARGET_1") = ColRow(2)("FID")

                            Dr("RAT_TANDA_TARGET_1") = Valores.Redondear((ColRow(3)("RAT") * sistema.Deflactacion), "0.00")
                            Dr("SHR_TANDA_TARGET_1") = ColRow(3)("SHR")
                            Dr("AFF_TANDA_TARGET_1") = ColRow(3)("AFF")
                            Dr("RCH_TANDA_TARGET_1") = ColRow(3)("RCH")
                            Dr("RAT_M_TANDA_TARGET_1") = ColRow(3)("RAT_M")
                            Dr("FID_TANDA_TARGET_1") = ColRow(3)("FID")
                        End If
                    End If
                Else
                    k = k + 1
                    Dr("id_spot") = Me.ObtenerProximoIdSpot(Spots) + k

                    Dr("id_campania") = Activo.IDCampaña
                    Dr("id_sistema") = Activo.IDSistema
                    Dr("id_ejercicio") = Activo.IDEjercicio
                    Dr("id_soporte") = Tarifas.Rows(j)("id_soporte")
                    Dr("id_tarifa_tv") = Tarifas.Rows(j)("id_tarifa_tv")
                    Dr("ID_Programa") = Tarifas.Rows(j)("ID_Programa")
                    Dr("programa") = Tarifas.Rows(j)("programa")
                    Dr("bruto") = Tarifas.Rows(j)("Tarifa bruta")

                    Dr("Neto") = Tarifas.Rows(j)("Tarifa Bruta")

                    Dr("tipo_planificacion") = 0
                    Dr("desc_campania") = Activo.Campaña
                    Dr("desc_sistema") = Activo.Sistema
                    Dr("desc_ejercicio") = Activo.Ejercicio

                    Dr("id_convenio") = 0
                    Dr("h_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(3, 2)

                    Dr("HINICIO") = DirectCast(Dr("h_inicio"), Short)
                    Dr("HFIN") = DirectCast(Dr("h_fin"), Short)

                    Dr("MINICIO") = DirectCast(Dr("m_inicio"), Short)
                    Dr("MFIN") = DirectCast(Dr("m_fin"), Short)

                    Dr("Dias") = Grilladmin.ObtenerDato(Tarifas, "ID_TARIFA_TV=" & Tarifas.Rows(j)("ID_TARIFA_TV"), "Dias")

                    Dr("dcto1") = 0
                    Dr("dcto2") = 0
                    Dr("dcto3") = 0
                    Dr("dcto4") = 0
                    Dr("dcto5") = 0

                    Dr("rat_prog_target_2") = 0
                    Dr("shr_prog_target_2") = 0
                    Dr("aff_prog_target_2") = 0
                    Dr("rch_prog_target_2") = 0
                    Dr("rat_m_prog_target_2") = 0
                    Dr("fid_prog_target_2") = 0

                    Dr("rat_tanda_target_2") = 0
                    Dr("shr_tanda_target_2") = 0
                    Dr("aff_tanda_target_2") = 0
                    Dr("rch_tanda_target_2") = 0
                    Dr("rat_m_tanda_target_2") = 0
                    Dr("fid_tanda_target_2") = 0

                    Dr("rat_prog_target_1") = 0
                    Dr("shr_prog_target_1") = 0
                    Dr("aff_prog_target_1") = 0
                    Dr("rch_prog_target_1") = 0
                    Dr("rat_m_prog_target_1") = 0
                    Dr("fid_prog_target_1") = 0

                    Dr("rat_tanda_target_1") = 0
                    Dr("shr_tanda_target_1") = 0
                    Dr("aff_tanda_target_1") = 0
                    Dr("rch_tanda_target_1") = 0
                    Dr("rat_m_tanda_target_1") = 0
                    Dr("fid_tanda_target_1") = 0
                End If

                Spots.Rows.Add(Dr)

            Catch e As Exception
                Me.ErrorCarga = True
                Throw e
            End Try
        Next
        'SpotBase = Spots.Copy

        ' Return Spots
    End Sub
    Private Sub CargarSpotsTVC(ByVal Tarifas As DataTable, ByVal Audiencia As DataTable, ByVal sistema As Sistemas)
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow
        Dim ids As Long = Me.ObtenerProximoIdSpot(Spots)

        For j = 0 To Tarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = Spots.NewRow
            Try
                ColRow = Audiencia.Select("ID_TARIFA_TV=" & Tarifas.Rows(j).Item("ID_TARIFA_TV"))


                If ColRow.Length >= 1 Then
                    k = k + 1
                    Dr("ID_Spot") = ids + k

                    Dr("ID_Campania") = Activo.IDCampaña
                    Dr("ID_Sistema") = Activo.IDSistema
                    Dr("ID_Ejercicio") = Activo.IDEjercicio
                    Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = Tarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = Tarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = Tarifas.Rows(j)("Programa")
                    Dr("Bruto") = Tarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    ' Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")


                    Dr("Neto") = Tarifas.Rows(j)("Tarifa Bruta")
                    Dr("h_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    Dr("HINICIO") = DirectCast(Dr("h_inicio"), Short)
                    Dr("HFIN") = DirectCast(Dr("h_fin"), Short)

                    Dr("MINICIO") = DirectCast(Dr("m_inicio"), Short)
                    Dr("MFIN") = DirectCast(Dr("m_fin"), Short)

                    Dr("Dias") = Grilladmin.ObtenerDato(Tarifas, "ID_TARIFA_TV=" & Tarifas.Rows(j)("ID_TARIFA_TV"), "Dias")

                    'asigna los valores dependiendo los targets y tipo de planificacion
                    If ColRow(0)("Id_Target_1") = sistema.Id_target_1 Then
                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("Rating 1") * sistema.Deflactacion), "0.00") 'ColRow(0)("Rating 1")
                    Else
                        Dr("RAT_PROG_TARGET_1") = 0
                    End If

                    If ColRow(0)("Id_Target_2") = sistema.Id_target_2 Then
                        Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("Rating 2") * sistema.Deflactacion), "0.00") 'ColRow(0)("Rating 2")
                    Else
                        Dr("RAT_PROG_TARGET_2") = 0
                    End If
                    Dr("RAT_TANDA_TARGET_1") = 0
                    Dr("RAT_TANDA_TARGET_2") = 0

                    Spots.Rows.Add(Dr)

                Else
                    k = k + 1
                    Dr("ID_Spot") = ids + k
                    Dr("ID_Campania") = Activo.IDCampaña
                    Dr("ID_Sistema") = Activo.IDSistema
                    Dr("ID_Ejercicio") = Activo.IDEjercicio
                    Dr("ID_Soporte") = Tarifas.Rows(j)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = Tarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = Tarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = Tarifas.Rows(j)("Programa")
                    Dr("Bruto") = Tarifas.Rows(j)("Tarifa Bruta")

                    Dr("Neto") = Tarifas.Rows(j)("Tarifa Bruta")
                    Dr("h_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(3, 2)

                    Dr("HINICIO") = DirectCast(Dr("h_inicio"), Short)
                    Dr("HFIN") = DirectCast(Dr("h_fin"), Short)

                    Dr("MINICIO") = DirectCast(Dr("m_inicio"), Short)
                    Dr("MFIN") = DirectCast(Dr("m_fin"), Short)

                    Dr("Dias") = Grilladmin.ObtenerDato(Tarifas, "ID_TARIFA_TV=" & Tarifas.Rows(j)("ID_TARIFA_TV"), "Dias")

                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    Dr("RAT_PROG_TARGET_1") = 0
                    Dr("RAT_PROG_TARGET_2") = 0
                    Dr("RAT_TANDA_TARGET_1") = 0
                    Dr("RAT_TANDA_TARGET_2") = 0
                    Spots.Rows.Add(Dr)

                End If
            Catch e As Exception
                Me.ErrorCarga = True
                Throw e
            End Try

        Next

    End Sub
    Private Function CargarSpotsTVS(ByVal dtTarifas As DataTable, ByVal dtAudiencia As DataTable, ByVal sistema As Sistemas) As DataTable
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow

        For j = 0 To dtTarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = Spots.NewRow
            Try
                ' ColRow = dtAudiencia.Select("ID_TARIFA_TV=" & dtTarifas.Rows(j).Item("ID_TARIFA_TV"))


                ' If ColRow.Length >= 1 Then

                'Dr("ID_Spot") = k

                'Dr("ID_Campania") = idCampania
                'Dr("ID_Sistema") = idSistema
                'Dr("ID_Ejercicio") = idEjer
                'Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                'Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                'Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                'Dr("Programa") = dtTarifas.Rows(j)("Programa")
                'Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")
                'Dr("Neto") = dtTarifas.Rows(j)("Tarifa Bruta")
                'Dr("h_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                'Dr("h_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                'Dr("m_inicio") = Trim(dtTarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                'Dr("m_fin") = Trim(dtTarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                'Dr("DCTO1") = 0
                'Dr("DCTO2") = 0
                'Dr("DCTO3") = 0
                'Dr("DCTO4") = 0
                'Dr("DCTO5") = 0
                'Dr("Tipo_Planificacion") = 0

                ''asigna los valores dependiendo los targets y tipo de planificacion
                'If ColRow(0)("Id_Target_1") = Target1 Then
                '    Dr("RAT_PROG_TARGET_1") = ColRow(0)("Rating 1")
                'Else
                '    Dr("RAT_PROG_TARGET_1") = 0
                'End If

                'If ColRow(0)("Id_Target_2") = Target2 Then
                '    Dr("RAT_PROG_TARGET_2") = ColRow(0)("Rating 2")
                'Else
                '    Dr("RAT_PROG_TARGET_2") = 0
                'End If
                'Dr("RAT_TANDA_TARGET_1") = 0
                'Dr("RAT_TANDA_TARGET_2") = 0
                'DtSpot.Rows.Add(Dr)
                'k = k + 1


                'Else
                k = k + 1
                Dr("ID_Spot") = Me.ObtenerProximoIdSpot(Spots) + k
                Dr("id_campania") = Activo.IDCampaña
                Dr("id_sistema") = Activo.IDSistema
                Dr("id_ejercicio") = Activo.IDEjercicio
                Dr("ID_Soporte") = dtTarifas.Rows(j)("ID_SOPORTE")
                Dr("ID_Tarifa_Tv") = dtTarifas.Rows(j)("ID_TARIFA_TV")
                Dr("ID_Programa") = dtTarifas.Rows(j)("ID_Programa")
                Dr("Programa") = dtTarifas.Rows(j)("Programa")
                Dr("Bruto") = dtTarifas.Rows(j)("Tarifa Bruta")

                'brutoactual
                '    Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")

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

                'asigna los valores dependiendo los targets y tipo de planificacion

                Dr("RAT_PROG_TARGET_1") = 0
                Dr("RAT_PROG_TARGET_2") = 0
                Dr("RAT_TANDA_TARGET_1") = 0
                Dr("RAT_TANDA_TARGET_2") = 0
                Spots.Rows.Add(Dr)

                'End If

            Catch e As Exception
                ' = k + 1

            End Try

        Next

        'Return DtSpot
    End Function
    Private Sub CargarSpotsTVI(ByVal Tarifas As DataTable, ByVal Audiencia As DataTable, ByVal sistema As Sistemas)
        Dim j As Int64
        Dim i As Int64, k As Int64
        Dim Dr As DataRow, ColRow() As DataRow

        For j = 0 To Tarifas.Rows.Count - 1 'realiza una busqueda buscando coincidencia entre los idprograma
            Dr = Spots.NewRow
            Try
                ColRow = Audiencia.Select("ID_TARIFA_TV=" & Tarifas.Rows(j).Item("ID_TARIFA_TV"))


                If ColRow.Length >= 1 Then
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(Spots) + k

                    Dr("ID_Campania") = Activo.IDCampaña
                    Dr("ID_Sistema") = Activo.IDSistema
                    Dr("ID_Ejercicio") = Activo.IDEjercicio
                    Dr("ID_Soporte") = ColRow(0)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = Tarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = Tarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = Tarifas.Rows(j)("Programa")
                    Dr("Bruto") = Tarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    '  Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")

                    Dr("Neto") = Tarifas.Rows(j)("Tarifa Bruta")
                    Dr("h_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(3, 2)

                    Dr("HINICIO") = DirectCast(Dr("h_inicio"), Short)
                    Dr("HFIN") = DirectCast(Dr("h_fin"), Short)

                    Dr("MINICIO") = DirectCast(Dr("m_inicio"), Short)
                    Dr("MFIN") = DirectCast(Dr("m_fin"), Short)

                    Dr("Dias") = Grilladmin.ObtenerDato(Tarifas, "ID_TARIFA_TV=" & Tarifas.Rows(j)("ID_TARIFA_TV"), "Dias")

                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    'asigna los valores dependiendo los targets y tipo de planificacion
                    If ColRow(0)("Id_Target_1") = sistema.Id_target_1 Then
                        Dr("RAT_PROG_TARGET_1") = Valores.Redondear((ColRow(0)("Rating 1") * sistema.Deflactacion), "0.00") 'ColRow(0)("Rating 1")
                    Else
                        Dr("RAT_PROG_TARGET_1") = 0
                    End If

                    If ColRow(0)("Id_Target_2") = sistema.Id_target_2 Then
                        Dr("RAT_PROG_TARGET_2") = Valores.Redondear((ColRow(0)("Rating 2") * sistema.Deflactacion), "0.00") 'ColRow(0)("Rating 2")
                    Else
                        Dr("RAT_PROG_TARGET_2") = 0
                    End If
                    Dr("RAT_TANDA_TARGET_1") = 0
                    Dr("RAT_TANDA_TARGET_2") = 0
                    Spots.Rows.Add(Dr)
                    ' k = k + 1
                Else
                    k = k + 1
                    Dr("ID_Spot") = Me.ObtenerProximoIdSpot(Spots) + k
                    Dr("ID_Campania") = Activo.IDCampaña
                    Dr("ID_Sistema") = Activo.IDSistema
                    Dr("ID_Ejercicio") = Activo.IDEjercicio
                    Dr("ID_Soporte") = Tarifas.Rows(j)("ID_SOPORTE")
                    Dr("ID_Tarifa_Tv") = Tarifas.Rows(j)("ID_TARIFA_TV")
                    Dr("ID_Programa") = Tarifas.Rows(j)("ID_Programa")
                    Dr("Programa") = Tarifas.Rows(j)("Programa")
                    Dr("Bruto") = Tarifas.Rows(j)("Tarifa Bruta")

                    'brutoactual
                    'Dr("brutoactual") = dtTarifas.Rows(j)("Tarifa Bruta")
                    Dr("Neto") = Tarifas.Rows(j)("Tarifa Bruta")

                    Dr("h_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(0, 2)
                    Dr("h_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(0, 2)
                    Dr("m_inicio") = Trim(Tarifas.Rows(j)("Hora Inicio")).Substring(3, 2)
                    Dr("m_fin") = Trim(Tarifas.Rows(j)("Hora Fin")).Substring(3, 2)
                    Dr("HINICIO") = DirectCast(Dr("h_inicio"), Short)
                    Dr("HFIN") = DirectCast(Dr("h_fin"), Short)

                    Dr("MINICIO") = DirectCast(Dr("m_inicio"), Short)
                    Dr("MFIN") = DirectCast(Dr("m_fin"), Short)
                    Dr("DCTO1") = 0
                    Dr("DCTO2") = 0
                    Dr("DCTO3") = 0
                    Dr("DCTO4") = 0
                    Dr("DCTO5") = 0
                    Dr("Tipo_Planificacion") = 0

                    Dr("Dias") = Grilladmin.ObtenerDato(Tarifas, "ID_TARIFA_TV=" & Tarifas.Rows(j)("ID_TARIFA_TV"), "Dias")

                    'asigna los valores dependiendo los targets y tipo de planificacion

                    Dr("RAT_PROG_TARGET_1") = 0
                    Dr("RAT_PROG_TARGET_2") = 0
                    Dr("RAT_TANDA_TARGET_1") = 0
                    Dr("RAT_TANDA_TARGET_2") = 0
                    Spots.Rows.Add(Dr)
                    'k = k + 1
                End If
            Catch e As Exception
                Me.ErrorCarga = True
                Throw e
            End Try

        Next
    End Sub
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
    Private Function ObtenerSoportesOrigen() As DataTable
        Dim e As New Ejercicios
        e.Id_campania = IdoCampaña
        e.Id_ejercicio = IdoEjercicio
        e.Id_sistema = IdoSistema
        Return e.ObtenerSoportesSpots()
    End Function
    Private Function ObtenerFechasCalendario(ByVal inicio As Date, ByVal fin As Date) As ArrayList
        Dim Arr As New ArrayList
        For i As Int32 = 0 To DateDiff(DateInterval.Day, inicio, fin)
            Arr.Add(inicio.AddDays(i))
        Next

        Return Arr
    End Function
    Private Function ControlarFechas(ByVal oFinicio As Date, ByVal oFFin As Date, ByVal dFInicio As Date, ByVal dFFin As Date) As String
        Dim Er As String = ""
        Dim DiasOrigen As Int16 = DateDiff(DateInterval.Day, oFinicio, oFFin)
        Dim DiasDestino As Int16 = DateDiff(DateInterval.Day, dFInicio, dFFin)

        If oFinicio < Me.FechaOrigenSistemai Or oFFin > FechaOrigenSistemaf Then
            Return "El Periodo que se Desea Importar Debe estar Dentro del Rango del Sistema de Origen"
        End If

        If DiasOrigen > DiasDestino Then
            Return "La Cantidad de Dias de Fecha del Periodo Origen Deber ser Menor o Igual al Periodo Destino"
        End If

        If Not oFinicio.DayOfWeek.Equals(dFInicio.DayOfWeek) Then
            Return "El Primer dia de la semana del Periodo Seleccionado, debe coincir con el Primer dia del Sistema actual"
        End If

    End Function
    Private Function ControlarTemas(ByVal Tipo As ControTema) As Boolean
        Dim Temas As New Temas
        Dim dtO As DataTable
        Dim dtd As DataTable

        Temas.Id_campania = ObtenerNodo(Me.treOEjercicio.SelectedNode, 0).Tag
        dtO = Temas.ObtenerTemasPorCampaña
        Temas.Id_campania = Activo.IDCampaña
        dtd = Temas.ObtenerTemasPorCampaña

        Select Case Tipo
            Case ControTema.TemasEjrcicio

                If dtO.Rows.Count = 0 Or dtd.Rows.Count = 0 Then
                    Return False
                End If

                For Each r As DataRow In dtO.Rows
                    If dtd.Select("ID_TEMA=" & "'" & r("id_tema") & "'").Length > 0 Then
                        Return True
                    End If
                Next
            Case ControTema.TemasSeleccionado
                If dtd.Select("ID_TEMA=" & "'" & DirectCast(lstOTema.SelectedItem, ItemLista).ID & "'").Length = 0 Then
                    Return False
                End If

            Case ControTema.TodosTemas
                For Each r As DataRow In dtO.Rows
                    If dtd.Select("ID_TEMA=" & "'" & r("id_tema") & "'").Length = 0 Then
                        Return False
                    End If
                Next
        End Select

        Return True
    End Function
    Private Function RecalcularFechaSpot(ByVal Finiciod As Date, ByVal Finicioo As Date, ByVal Fspot As Date) As Date
        Dim dias As Int16 = DateDiff(DateInterval.Day, Finiciod, Finicioo)

        Dim Ret As Date = Fspot.AddDays(dias)

        Return Ret

    End Function
    Private Function ObtenerSpots(ByVal IdCampaña As Integer, ByVal IdSistema As Integer, ByVal IdEjercicio As Integer, ByVal Finicio As Date, ByVal ffin As Date, ByVal Temas As String) As DataTable
        Dim e As New Ejercicios, i As Int32
        Try
            Dim SpotsOrigen As DataTable = e.ObtenerEjerciciosImportar(IdCampaña, IdSistema, IdEjercicio, Finicio, ffin, Temas)

            For Each R As DataRow In SpotsOrigen.Rows
                R("NuevaFecha") = Me.RecalcularFechaSpot(Me.dtpFechaInicio.Value.ToShortDateString, Me.FechaDestinoi, R("f_spot")) ' DateAdd(DateInterval.Day, i, Me.dtpFechaInicio.Value) 
                Calendario.Add(R("NuevaFecha"))
                'i += 1
            Next
            SpotsOrigen.AcceptChanges()
            Return SpotsOrigen
        Catch ex As Exception
            Me.ErrorCarga = True
            Throw ex
        End Try

    End Function
    Private Function TemasConcatenado() As String
        Dim str As String
        'str = "("
        For Each i As ItemLista In Me.lstDTema.Items
            str &= i.ID & ","
        Next
        str = Mid(str, 1, str.Length - 1) ' & ")"
        'str = Mid(str, 2, str.Length) ' & ")"
        Return str
    End Function
    Private Sub CrearDtOtros()
        dtOtros.Columns.Add("ID_Campania", GetType(Integer))
        dtOtros.Columns.Add("ID_Sistema", GetType(Integer))
        dtOtros.Columns.Add("ID_Ejercicio", GetType(Integer))
        dtOtros.Columns.Add("Id_Tarifa_Tv", GetType(Integer))
        dtOtros.Columns.Add("id_soporte", GetType(Integer))
        dtOtros.Columns.Add("Id_programa", GetType(Integer))
        dtOtros.Columns.Add("Soporte", GetType(String))
        dtOtros.Columns.Add("Programa", GetType(String))
        dtOtros.Columns.Add("Dias", GetType(String))
        dtOtros.Columns.Add("Hora Emicion", GetType(String))
        dtOtros.Columns.Add("Fecha", GetType(Date))
        dtOtros.Columns.Add("Tema", GetType(String))
    End Sub
    Private Sub Guardar()


        Dim Ds As DataSet
        Dim S As New Spots
        Dim D As New Spots_detalle
        Try
            If Spots.DataSet Is Nothing Then
                Ds = New DataSet

                Ds.Tables.Add(Spots)
                Ds.Tables.Add(Detalles)
            End If

            'If Activo.Control = False Then
            '    MsgBox("no se actializo spot base")
            '     Clipboard.SetDataObject(Ds.GetXml)
            'End If

            Dim Padre As DataColumn = Spots.Columns("id_spot")
            Dim Hijo As DataColumn = Detalles.Columns("id_spot")

            Dim R As New DataRelation("Union", Padre, Hijo)

            If Not Ds Is Nothing Then
                Ds.Relations.Add(R)
            End If

            'actualiza los datos de los programas, leyendo un ultra source y pasando a un data table
            'GrillAdmin.ActualizarDataTable(Me.iugEjercicio.DataSource, Me.SpotBase, "Bruto", "DCTO1", "DCTO2", "DCTO3", "DCTO4", "DCTO5", "Neto", "Programa", "rat_prog_target_1", "rat_prog_target_2")

            S.ActualizarDataSet(Spots.DataSet, Spots.TableName)
            D.ActualizarDataSet(Detalles.DataSet, Detalles.TableName, Spots.TableName, Activo.Login, Activo.Estado)

        Catch ex As Exception
            MsgBox("Ejercicio-Guardar: " & ex.Message)
        End Try
        'HayCambios = False

        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "Eventos"
    Private Sub cmdQuitarEjer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarEjer.Click
        DevolverEjercicio()
    End Sub
    Private Sub tblAcciones_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles tblAcciones.ToolClick
        Select Case e.Tool.Key
            Case "guardar"
                Importar()
        End Select
    End Sub
    Private Sub frmImportacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Sis As New Sistemas

        Sis.Id_campania = Activo.IDCampaña
        Sis.Id_sistema = Activo.IDSistema

        Sis.BuscarPorID()

        Me.dtpFinCampaña.Value = Now.Today
        Me.dtpInicioCampaña.Value = Now.Today.AddMonths(-6)

        Me.FechaDestinoi = Sis.F_inicio
        Me.FechaDestinof = Sis.F_fin
        Me.lblDiasDestino.Text = DateDiff(DateInterval.Day, Sis.F_inicio, Sis.F_fin)

        Me.dtpDestinoFin.Value = Sis.F_fin
        Me.dtpDestinoInicio.Value = Sis.F_inicio

    End Sub
    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescripcion.Click
        BuscarCliente()
    End Sub
    Private Sub treOEjercicio_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treOEjercicio.AfterSelect
        'llena la lista de temas
        Dim T As New Temas
        T.Id_campania = ObtenerNodo(e.Node, 0).Tag
        Listas.CargarList(Me.lstOTema, T.ObtenerTemasPorCampaña, "id_tema", "tema")
    End Sub
    Private Sub cmdAgregarTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTema.Click
        If Me.treDEjercicio.GetNodeCount(True) = 0 Then
            Exit Sub
        End If
        If Me.treOEjercicio.SelectedNode Is Nothing Then
            Exit Sub
        End If
        If Not ControlarTemas(ControTema.TemasSeleccionado) Then
            Mensajes.Mensaje("El Tema eleccionado No Coinciden con ningun Tema de la Campaña de Destino", TipoMensaje.Informacion)
            Exit Sub
        End If
        AgregarTema()
    End Sub
    Private Sub cmdQuitarTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTema.Click
        QuitarTema()
    End Sub
    Private Sub cmdAgregarTodosTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTodosTema.Click
        If Me.treDEjercicio.GetNodeCount(True) = 0 Then
            Exit Sub
        End If
        If Me.treOEjercicio.SelectedNode Is Nothing Then
            Exit Sub
        End If
        If Not ControlarTemas(ControTema.TodosTemas) Then
            Mensajes.Mensaje("Existen Temas que No Coinciden con algun Tema de la Campaña de Destino", TipoMensaje.Informacion)
            Exit Sub
        End If
        Me.AgregarTodosTemas()
    End Sub
    Private Sub cmdQuitarTodosTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTodosTema.Click
        Me.QuitarTodosTemas()
    End Sub
    Private Sub cmdAgregarEjer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarEjer.Click
        If treOEjercicio.SelectedNode Is Nothing Then ' si no se lecciono nada
            Exit Sub
        End If
        If Not treDEjercicio.GetNodeCount(True) = 0 Then ' si hay datos en el destino
            Exit Sub
        End If
        If Not treOEjercicio.SelectedNode.GetNodeCount(True) = 0 Then
            Exit Sub
        End If
        If Not ControlarTemas(ControTema.TemasEjrcicio) Then
            Mensajes.Mensaje("Los temas de la campaña seleccionada No Coinciden con la Campaña de Destino", TipoMensaje.Informacion)
            Exit Sub
        End If


        PasarEjercicio()
        CargarDatosOrigen()
    End Sub
    Private Sub dtpFechaInicio_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicio.ValueChanged
        lblDias.Text = DateDiff(DateInterval.Day, Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value)
    End Sub
    Private Sub dtpFechaFin_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaFin.ValueChanged
        lblDias.Text = DateDiff(DateInterval.Day, Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value)
    End Sub
    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub
    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated

    End Sub
    Private Sub txtCodigo_SePresionoBarra() Handles txtCodigo.SePresionoBarra
        BuscarCliente()
    End Sub
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Return Then
            If txtCodigo.Text <> "" Then
                'Dim C As New Clientes
                Dim U As New Usuario

                'C.Id_cliente = txtCodigo.Text

                Try
                    'C.BuscarPorID()

                    U.IDPerfil_Datos = Activo.IDPerfil_Datos
                    txtDescripcion.Text = U.ObtenerDescripcion(txtCodigo.Text)

                    If txtDescripcion.Text = "" Then
                        Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                        txtCodigo.Text = ""
                        txtCodigo.Select()
                        Exit Sub
                    End If
                    CargarListas()
                Catch ex As ClienteInexistenteExcepcion
                    Mensajes.Mensaje(ex.Message)
                    Exit Sub
                End Try

                'txtDescripcion.Text = C.Descripcion
            End If
        End If
    End Sub
#End Region


    Private Sub fraEjercicios_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraEjercicios.Enter

    End Sub
End Class
Public Enum ControTema
    TemasEjrcicio = 0
    TemasSeleccionado = 1
    TodosTemas = 2
End Enum
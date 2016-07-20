Imports System.IO

Public Class ResEvaluacionDF
    Inherits System.Windows.Forms.UserControl

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal PathEvaIbo As String, ByVal NomArc As String, ByVal cntAvisos As Integer, ByVal InvNeta As Double, ByVal DurPromedio As Single)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()


        lblAvisos.Text = cntAvisos
        lblInvNeta.Text = Format(InvNeta, "##,###,##0.00")
        lblDurProm.Text = Format(DurPromedio, "##,###,##0.00")
        CargarDistFrec(PathEvaIbo, NomArc)
    End Sub
    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPBR2 As System.Windows.Forms.Label
    Friend WithEvents lblIndividuo2 As System.Windows.Forms.Label
    Friend WithEvents lblRepeticion2 As System.Windows.Forms.Label
    Friend WithEvents lblCobertura2 As System.Windows.Forms.Label
    Friend WithEvents lblPBR1 As System.Windows.Forms.Label
    Friend WithEvents lblIndividuo1 As System.Windows.Forms.Label
    Friend WithEvents lblRepeticion1 As System.Windows.Forms.Label
    Friend WithEvents lblCobertura1 As System.Windows.Forms.Label
    Friend WithEvents lblF_Hasta As System.Windows.Forms.Label
    Friend WithEvents lblF_Desde As System.Windows.Forms.Label
    Friend WithEvents iugDistFrec As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblAvisos As System.Windows.Forms.Label
    Friend WithEvents lblInvNeta As System.Windows.Forms.Label
    Friend WithEvents lblDurProm As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblCPR12 As System.Windows.Forms.Label
    Friend WithEvents lblCPRReal2 As System.Windows.Forms.Label
    Friend WithEvents lblCPR302 As System.Windows.Forms.Label
    Friend WithEvents lblCPR11 As System.Windows.Forms.Label
    Friend WithEvents lblCPRReal1 As System.Windows.Forms.Label
    Friend WithEvents lblCPR301 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblCPR12 = New System.Windows.Forms.Label
        Me.lblCPRReal2 = New System.Windows.Forms.Label
        Me.lblCPR302 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblPBR2 = New System.Windows.Forms.Label
        Me.lblIndividuo2 = New System.Windows.Forms.Label
        Me.lblRepeticion2 = New System.Windows.Forms.Label
        Me.lblCobertura2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblCPR11 = New System.Windows.Forms.Label
        Me.lblCPRReal1 = New System.Windows.Forms.Label
        Me.lblCPR301 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblPBR1 = New System.Windows.Forms.Label
        Me.lblIndividuo1 = New System.Windows.Forms.Label
        Me.lblRepeticion1 = New System.Windows.Forms.Label
        Me.lblCobertura1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblF_Hasta = New System.Windows.Forms.Label
        Me.lblF_Desde = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.iugDistFrec = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblAvisos = New System.Windows.Forms.Label
        Me.lblInvNeta = New System.Windows.Forms.Label
        Me.lblDurProm = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.iugDistFrec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCPR12)
        Me.GroupBox3.Controls.Add(Me.lblCPRReal2)
        Me.GroupBox3.Controls.Add(Me.lblCPR302)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.lblPBR2)
        Me.GroupBox3.Controls.Add(Me.lblIndividuo2)
        Me.GroupBox3.Controls.Add(Me.lblRepeticion2)
        Me.GroupBox3.Controls.Add(Me.lblCobertura2)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(240, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 188)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Target 2"
        '
        'lblCPR12
        '
        Me.lblCPR12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCPR12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCPR12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCPR12.Location = New System.Drawing.Point(90, 112)
        Me.lblCPR12.Name = "lblCPR12"
        Me.lblCPR12.Size = New System.Drawing.Size(122, 20)
        Me.lblCPR12.TabIndex = 47
        Me.lblCPR12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCPRReal2
        '
        Me.lblCPRReal2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCPRReal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCPRReal2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCPRReal2.Location = New System.Drawing.Point(90, 136)
        Me.lblCPRReal2.Name = "lblCPRReal2"
        Me.lblCPRReal2.Size = New System.Drawing.Size(122, 20)
        Me.lblCPRReal2.TabIndex = 46
        Me.lblCPRReal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCPR302
        '
        Me.lblCPR302.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCPR302.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCPR302.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCPR302.Location = New System.Drawing.Point(90, 160)
        Me.lblCPR302.Name = "lblCPR302"
        Me.lblCPR302.Size = New System.Drawing.Size(122, 20)
        Me.lblCPR302.TabIndex = 45
        Me.lblCPR302.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 140)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 16)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "CPR: Real"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 116)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 16)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "CPR: 1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 164)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 16)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "CPR: 30"
        '
        'lblPBR2
        '
        Me.lblPBR2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPBR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPBR2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblPBR2.Location = New System.Drawing.Point(90, 18)
        Me.lblPBR2.Name = "lblPBR2"
        Me.lblPBR2.Size = New System.Drawing.Size(122, 20)
        Me.lblPBR2.TabIndex = 29
        Me.lblPBR2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIndividuo2
        '
        Me.lblIndividuo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIndividuo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndividuo2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblIndividuo2.Location = New System.Drawing.Point(90, 41)
        Me.lblIndividuo2.Name = "lblIndividuo2"
        Me.lblIndividuo2.Size = New System.Drawing.Size(122, 20)
        Me.lblIndividuo2.TabIndex = 28
        Me.lblIndividuo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRepeticion2
        '
        Me.lblRepeticion2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRepeticion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRepeticion2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblRepeticion2.Location = New System.Drawing.Point(90, 88)
        Me.lblRepeticion2.Name = "lblRepeticion2"
        Me.lblRepeticion2.Size = New System.Drawing.Size(122, 20)
        Me.lblRepeticion2.TabIndex = 27
        Me.lblRepeticion2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCobertura2
        '
        Me.lblCobertura2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCobertura2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCobertura2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCobertura2.Location = New System.Drawing.Point(90, 64)
        Me.lblCobertura2.Name = "lblCobertura2"
        Me.lblCobertura2.Size = New System.Drawing.Size(122, 20)
        Me.lblCobertura2.TabIndex = 26
        Me.lblCobertura2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Individuos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Repetición"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 16)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "PBR"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 66)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Cobertura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCPR11)
        Me.GroupBox2.Controls.Add(Me.lblCPRReal1)
        Me.GroupBox2.Controls.Add(Me.lblCPR301)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblPBR1)
        Me.GroupBox2.Controls.Add(Me.lblIndividuo1)
        Me.GroupBox2.Controls.Add(Me.lblRepeticion1)
        Me.GroupBox2.Controls.Add(Me.lblCobertura1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 188)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Target 1"
        '
        'lblCPR11
        '
        Me.lblCPR11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCPR11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCPR11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCPR11.Location = New System.Drawing.Point(88, 112)
        Me.lblCPR11.Name = "lblCPR11"
        Me.lblCPR11.Size = New System.Drawing.Size(120, 20)
        Me.lblCPR11.TabIndex = 53
        Me.lblCPR11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCPRReal1
        '
        Me.lblCPRReal1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCPRReal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCPRReal1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCPRReal1.Location = New System.Drawing.Point(88, 136)
        Me.lblCPRReal1.Name = "lblCPRReal1"
        Me.lblCPRReal1.Size = New System.Drawing.Size(120, 20)
        Me.lblCPRReal1.TabIndex = 52
        Me.lblCPRReal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCPR301
        '
        Me.lblCPR301.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCPR301.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCPR301.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCPR301.Location = New System.Drawing.Point(88, 160)
        Me.lblCPR301.Name = "lblCPR301"
        Me.lblCPR301.Size = New System.Drawing.Size(120, 20)
        Me.lblCPR301.TabIndex = 51
        Me.lblCPR301.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "CPR: Real"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 16)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "CPR: 1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "CPR: 30"
        '
        'lblPBR1
        '
        Me.lblPBR1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPBR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPBR1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblPBR1.Location = New System.Drawing.Point(88, 19)
        Me.lblPBR1.Name = "lblPBR1"
        Me.lblPBR1.Size = New System.Drawing.Size(120, 20)
        Me.lblPBR1.TabIndex = 29
        Me.lblPBR1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIndividuo1
        '
        Me.lblIndividuo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIndividuo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndividuo1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblIndividuo1.Location = New System.Drawing.Point(88, 42)
        Me.lblIndividuo1.Name = "lblIndividuo1"
        Me.lblIndividuo1.Size = New System.Drawing.Size(120, 20)
        Me.lblIndividuo1.TabIndex = 28
        Me.lblIndividuo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRepeticion1
        '
        Me.lblRepeticion1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRepeticion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRepeticion1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblRepeticion1.Location = New System.Drawing.Point(88, 89)
        Me.lblRepeticion1.Name = "lblRepeticion1"
        Me.lblRepeticion1.Size = New System.Drawing.Size(120, 20)
        Me.lblRepeticion1.TabIndex = 27
        Me.lblRepeticion1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCobertura1
        '
        Me.lblCobertura1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCobertura1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCobertura1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCobertura1.Location = New System.Drawing.Point(88, 65)
        Me.lblCobertura1.Name = "lblCobertura1"
        Me.lblCobertura1.Size = New System.Drawing.Size(120, 20)
        Me.lblCobertura1.TabIndex = 26
        Me.lblCobertura1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Individuos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Repetición"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "PBR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cobertura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblF_Hasta)
        Me.GroupBox1.Controls.Add(Me.lblF_Desde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 44)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'lblF_Hasta
        '
        Me.lblF_Hasta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblF_Hasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblF_Hasta.Location = New System.Drawing.Point(320, 15)
        Me.lblF_Hasta.Name = "lblF_Hasta"
        Me.lblF_Hasta.Size = New System.Drawing.Size(96, 20)
        Me.lblF_Hasta.TabIndex = 11
        Me.lblF_Hasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblF_Desde
        '
        Me.lblF_Desde.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblF_Desde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblF_Desde.Location = New System.Drawing.Point(92, 17)
        Me.lblF_Desde.Name = "lblF_Desde"
        Me.lblF_Desde.Size = New System.Drawing.Size(96, 20)
        Me.lblF_Desde.TabIndex = 10
        Me.lblF_Desde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Desde"
        '
        'iugDistFrec
        '
        Me.iugDistFrec.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.iugDistFrec.DisplayLayout.Appearance = Appearance1
        Me.iugDistFrec.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.iugDistFrec.DisplayLayout.InterBandSpacing = 10
        Me.iugDistFrec.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.iugDistFrec.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.iugDistFrec.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.iugDistFrec.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.iugDistFrec.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.iugDistFrec.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.iugDistFrec.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.iugDistFrec.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Me.iugDistFrec.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.iugDistFrec.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.iugDistFrec.DisplayLayout.Override.RowSelectorWidth = 12
        Me.iugDistFrec.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.iugDistFrec.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.iugDistFrec.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugDistFrec.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugDistFrec.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugDistFrec.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Me.iugDistFrec.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.iugDistFrec.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugDistFrec.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugDistFrec.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.iugDistFrec.DisplayLayout.UseFixedHeaders = True
        Me.iugDistFrec.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.iugDistFrec.Location = New System.Drawing.Point(12, 308)
        Me.iugDistFrec.Name = "iugDistFrec"
        Me.iugDistFrec.Size = New System.Drawing.Size(452, 152)
        Me.iugDistFrec.TabIndex = 28
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblAvisos)
        Me.GroupBox4.Controls.Add(Me.lblInvNeta)
        Me.GroupBox4.Controls.Add(Me.lblDurProm)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(452, 44)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        '
        'lblAvisos
        '
        Me.lblAvisos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAvisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvisos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblAvisos.Location = New System.Drawing.Point(48, 16)
        Me.lblAvisos.Name = "lblAvisos"
        Me.lblAvisos.Size = New System.Drawing.Size(64, 20)
        Me.lblAvisos.TabIndex = 35
        Me.lblAvisos.Text = "0"
        Me.lblAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvNeta
        '
        Me.lblInvNeta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInvNeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvNeta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblInvNeta.Location = New System.Drawing.Point(198, 16)
        Me.lblInvNeta.Name = "lblInvNeta"
        Me.lblInvNeta.Size = New System.Drawing.Size(66, 20)
        Me.lblInvNeta.TabIndex = 34
        Me.lblInvNeta.Text = "0"
        Me.lblInvNeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDurProm
        '
        Me.lblDurProm.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDurProm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDurProm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDurProm.Location = New System.Drawing.Point(356, 16)
        Me.lblDurProm.Name = "lblDurProm"
        Me.lblDurProm.Size = New System.Drawing.Size(66, 20)
        Me.lblDurProm.TabIndex = 33
        Me.lblDurProm.Text = "0"
        Me.lblDurProm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Inv. Neta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Avisos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(280, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Dur Promedio"
        '
        'ResEvaluacionDF
        '
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.iugDistFrec)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ResEvaluacionDF"
        Me.Size = New System.Drawing.Size(476, 468)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.iugDistFrec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub CargarDistFrec(ByVal PathEvaIbo As String, ByVal NomArc As String)
        Dim cadena As String
        Dim nTar As Byte
        Dim Aux As String
        Dim x As Integer
        Dim xMed As String
        Dim Res_Med As String
        Dim ArcRes As StreamReader
        Dim dtDistFrec As New DataTable
        Dim rowDistFrec() As Object

        dtDistFrec.Columns.Add("Frecuencia", GetType(String))
        dtDistFrec.Columns.Add("Target1", GetType(Double))
        dtDistFrec.Columns.Add("Target2", GetType(Double))

        iugDistFrec.DataSource = dtDistFrec

        ArcRes = File.OpenText(PathEvaIbo & "DF" & NomArc & ".TXT")
        nTar = 0

        cadena = ArcRes.ReadLine
        Aux = ParseStr(cadena, 4, vbTab)
        lblF_Desde.Text = Aux
        Aux = ParseStr(cadena, 5, vbTab)
        lblF_Hasta.Text = Aux
        Aux = ParseStr(cadena, 8, vbTab)
        lblPBR1.Text = Aux
        Aux = ParseStr(cadena, 9, vbTab)
        lblCobertura1.Text = Aux
        Aux = ParseStr(cadena, 10, vbTab)
        lblIndividuo1.Text = Format(CDbl(Aux), "##,###,##0")
        lblRepeticion1.Text = Format(Redondeo(CDbl(lblPBR1.Text) / CDbl(lblCobertura1.Text)), "##,###,##0.00")

        If lblAvisos.Text <> "0" And lblInvNeta.Text <> "0" And lblPBR1.Text <> "0" Then
            lblCPR11.Text = Format(CDbl(lblInvNeta.Text) / CDbl(lblPBR1.Text) / CDbl(lblDurProm.Text), "##,###,##0.00")
            lblCPRReal1.Text = Format(CDbl(lblCPR11.Text) * CDbl(lblDurProm.Text), "##,###,##0.00")
            lblCPR301.Text = Format(CDbl(lblCPR11.Text) * 30, "##,###,##0.00")
        End If

        For x = 1 To 22
            ReDim rowDistFrec(2)
            rowDistFrec(0) = CStr(x)
            dtDistFrec.Rows.Add(rowDistFrec)
        Next x
        rowDistFrec(0) = "22 y +"
        dtDistFrec.Rows.Add(rowDistFrec)

        For x = 0 To 22
            Aux = ParseStr(cadena, 11 + x, vbTab)
            dtDistFrec.Rows(x).Item("Target1") = Aux
        Next x

        cadena = ArcRes.ReadLine
        If Not cadena Is Nothing Then
            Aux = ParseStr(cadena, 8, vbTab)
            lblPBR2.Text = Aux
            Aux = ParseStr(cadena, 9, vbTab)
            lblCobertura2.Text = Aux
            Aux = ParseStr(cadena, 10, vbTab)
            lblIndividuo2.Text = Format(CDbl(Aux), "##,###,##0")
            lblRepeticion2.Text = Format(Redondeo(CDbl(lblPBR1.Text) / CDbl(lblCobertura1.Text)), "##,###,##0.0")

            If lblInvNeta.Text <> "0" And lblInvNeta.Text <> "0" And lblPBR2.Text <> "0" Then
                lblCPR12.Text = Format(CDbl(lblInvNeta.Text) / CDbl(lblPBR2.Text) / CDbl(lblDurProm.Text), "##,###,##0.00")
                lblCPRReal2.Text = Format(CDbl(lblCPR12.Text) * CDbl(lblDurProm.Text), "##,###,##0.00")
                lblCPR302.Text = Format(CDbl(lblCPR12.Text) * 30, "##,###,##0.00")
            End If

            For x = 0 To 22
                Aux = ParseStr(cadena, 11 + x, vbTab)
                dtDistFrec.Rows(x).Item("Target2") = Aux
            Next x
        End If
        ArcRes.Close()

    End Sub
    Private Sub CargaRating(ByVal NomArc As String)
        'Dim Archivo As String
        'Dim cadena As String
        'Dim nTar As Byte
        'Dim Aux As String
        'Dim x As Integer
        'Dim xMed As String
        'Dim Res_Med As String
        'Dim TotPbr1 As Single
        'Dim TotPbr2 As Single
        'Dim TotPbr3 As Single
        'Dim ArcRes As StreamReader
        'Dim dtDistFrec As New DataTable
        'Dim rowDistFrec() As Object

        'Archivo = PathEvaIbo & "RA" & mNombreArchivo & ".TXT"

        'ArcRes = File.OpenText(Archivo)
        'Res_Med = ""

        'TotPbr1 = 0
        'TotPbr2 = 0
        'TotPbr3 = 0
        'x = 0
        'cadena = ArcRes.ReadLine
        'Do While Not cadena Is Nothing
        '    araux = Split(cadena, vbTab)
        '    arDistFrec(x) = araux
        '    xMed = griRat.TextMatrix(griRat.Rows - 1, griRat.ColIndex("CANAL"))

        '    If Res_Med <> xMed Then
        '        rsMed = lDB.Consultar("sp_select_medio_Eva_Ibo", Array(xMed))
        '        Res_Med = xMed
        '    End If

        '    If rsMed.EOF And rsMed.BOF Then
        '        griRat.TextMatrix(griRat.Rows - 1, griRat.ColIndex("CANAL")) = "No Habilitado"
        '    Else
        '        griRat.TextMatrix(griRat.Rows - 1, griRat.ColIndex("CANAL")) = rsMed!nombre
        '    End If
        '    TotPbr1 = TotPbr1 + Val(griRat.TextMatrix(griRat.Rows - 1, 6))
        '    TotPbr2 = TotPbr2 + Val(griRat.TextMatrix(griRat.Rows - 1, 7))
        '    x = x + 1
        'Loop
        'ArcRes.Close()

        'txtPBRs1.Text = TotPbr1
        'txtPBRs2.Text = TotPbr2
    End Sub

    'Private Sub CargaGrillas()
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim r As Integer
    '    Dim s As Integer
    '    Dim arrDia(7) As String
    '    Dim ContSD As Single
    '    Dim ContLV As Single
    '    Dim ContHa19 As Single
    '    Dim ContH19c As Single
    '    Dim ContCobMas3(3) As Single
    '    Dim HoraAct As Double
    '    Dim topSemanas As Integer
    '    Dim topComerciales As Integer
    '    Dim topCanales As Integer

    '    arrDia(1) = "Lunes"
    '    arrDia(2) = "Martes"
    '    arrDia(3) = "Miércoles"
    '    arrDia(4) = "Jueves"
    '    arrDia(5) = "Viernes"
    '    arrDia(6) = "Sábado"
    '    arrDia(7) = "Domingo"

    '    topSemanas = 0
    '    topComerciales = 0
    '    topCanales = 0

    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    '''''''''''''''''''''''  Hoja 2  '''''''''''''''''''''''''''''''''
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '    ContCobMas3(0) = 0
    '    ContCobMas3(1) = 0
    '    ContCobMas3(2) = 0
    '    For i = 1 To griDF.Rows - 1
    '        oExcel.Cells(20 + i, 3).Value = Trim(griDF.TextMatrix(i, 1))
    '        If i > 3 Then
    '            ContCobMas3(0) = ContCobMas3(0) + Val(griDF.TextMatrix(i, 1))
    '            ContCobMas3(1) = ContCobMas3(1) + Val(griDF.TextMatrix(i, 2))
    '            ContCobMas3(2) = ContCobMas3(2) + Val(griDF.TextMatrix(i, 3))
    '        End If
    '    Next i

    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    '''''''''''''''''''''''  Hoja 4  '''''''''''''''''''''''''''''''''
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '    oExcel.Worksheets(4).Select()
    '    oExcel.Worksheets(4).Activate()
    '    i = 1
    '    For j = 1 To mvarGrillaSpots.MaxRows
    '        mvarGrillaSpots.Row = j
    '        mvarGrillaSpots.Col = 1
    '        If (Not mvarGrillaSpots.RowHidden) And (mvarGrillaSpots.Value = 1) Then
    '            oExcel.Range("A" & 20 + i).Select()
    '            oExcel.Selection.EntireRow.Insert()
    '            oExcel.Cells(20 + i, 1).Value = griRat.TextMatrix(i, 3) ' Canal
    '            oExcel.Cells(20 + i, 2).HorizontalAlignment = xlRight
    '            oExcel.Cells(20 + i, 2).Value = Mid(griRat.TextMatrix(i, 4), 1, 10) ' fecha

    '            mvarGrillaSpots.Col = 2
    '            oExcel.Cells(20 + i, 3).Value = GetTema(mvarGrillaSpots.Text)

    '            oExcel.Cells(20 + i, 4).Value = griRat.TextMatrix(i, 5) ' Programa
    '            oExcel.Cells(20 + i, 5).Value = Mid(griRat.TextMatrix(i, 4), 12, 5) ' Hora
    '            oExcel.Cells(20 + i, 6).Value = arrDia(Weekday(Mid(griRat.TextMatrix(i, 4), 1, 10), kInicioDeSemana))  ' Dia
    '            mvarGrillaSpots.Col = 7
    '            oExcel.Cells(20 + i, 7).Value = mvarGrillaSpots.Text

    '            If Weekday(Mid(griRat.TextMatrix(i, 4), 1, 10), kInicioDeSemana) > 5 Then  ' es sabado o domingo
    '                ContSD = ContSD + griRat.TextMatrix(i, 6)
    '            Else
    '                ContLV = ContLV + griRat.TextMatrix(i, 6)
    '            End If


    '            HoraAct = Val(Mid(griRat.TextMatrix(i, 4), 12, 2) & Mid(griRat.TextMatrix(i, 4), 15, 2) & Mid(griRat.TextMatrix(i, 4), 18, 2))

    '            r = 0
    '            Do While r < UBound(ar)
    '                If HoraAct <= Val(ar(r)) Then
    '                    ContHorasCorte(r) = ContHorasCorte(r) + Val(griRat.TextMatrix(i, 6))
    '                    Exit Do
    '                End If
    '                r = r + 1
    '            Loop
    '            If r = UBound(ar) Then
    '                ContHorasCorte(r) = ContHorasCorte(r) + Val(griRat.TextMatrix(i, 6))
    '            End If
    '            If Val(Mid(griRat.TextMatrix(i, 4), 12, 2) & Mid(griRat.TextMatrix(i, 4), 15, 2) & Mid(griRat.TextMatrix(i, 4), 18, 2)) < 190000 Then
    '                ContHa19 = ContHa19 + griRat.TextMatrix(i, 6)
    '            Else
    '                ContH19c = ContH19c + griRat.TextMatrix(i, 6)
    '            End If

    '            AgregaComercial(j, i)
    '            AgregaSemana(j, i)
    '            AgregaCanal(j, i)

    '            oExcel.Cells(20 + i, 8).Value = griRat.TextMatrix(i, 6) ' TRP
    '            oExcel.Cells(20 + i, 9).Value = "" ' &&& griRat.TextMatrix(i, 1) ' Costo neto
    '            oExcel.Cells(20 + i, 10).Value = "" ' &&& griRat.TextMatrix(i, 1) ' CPR:1
    '            i = i + 1
    '        End If
    '    Next j

    '    For r = 0 To topCanales - 1
    '        oExcel.Range("A" & 21 + i + r + 1 + 1).Select()
    '        oExcel.Selection.EntireRow.Insert()
    '        oExcel.Cells(21 + i + r + 1 + 1, 1).Value = arCanales(r, 0) ' Canal
    '        oExcel.Cells(21 + i + r + 1 + 1, 5).Value = arCanales(r, 2) ' Cantidad
    '        oExcel.Cells(21 + i + r + 1 + 1, 6).Value = arCanales(r, 3) / oExcel.Cells(21 + i + r + 1 + 1, 5).Value ' Duracion
    '        oExcel.Cells(21 + i + r + 1 + 1, 7).Value = arCanales(r, 1) ' TRP
    '    Next r

    '    oExcel.Cells(21 + i + r + 1 + 2, 6).Value = CalculaDurPromedio()

    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    '''''''''''''''''''''''  Hoja 1  '''''''''''''''''''''''''''''''''
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    ' Primer cuadro
    '    oExcel.Cells(21, 3).Value = griRat.Rows - 1 ' cant avisos
    '    oExcel.Cells(22, 3).Value = 0 ' Inversion neta
    '    oExcel.Cells(23, 3).Value = txtPBRs(0) ' PBR del target 1
    '    oExcel.Cells(23, 4).Value = txtPBRs(1) ' PBR del target 1
    '    oExcel.Cells(23, 5).Value = txtPBRs(2) ' PBR del target 1
    '    oExcel.Cells(24, 3).Value = Round(CalculaDurPromedio(), 2) ' Duracion promedio

    '    oExcel.Cells(29, 3).Value = txtCobertura(0) 'Cobertura +1
    '    oExcel.Cells(29, 4).Value = txtCobertura(1) 'Cobertura +1
    '    oExcel.Cells(29, 5).Value = txtCobertura(2) 'Cobertura +1
    '    oExcel.Cells(30, 3).Value = ContCobMas3(0)
    '    oExcel.Cells(30, 4).Value = ContCobMas3(1)
    '    oExcel.Cells(30, 5).Value = ContCobMas3(2)
    '    oExcel.Cells(31, 3).Value = txtRepeticion(0)
    '    oExcel.Cells(31, 4).Value = txtRepeticion(1)
    '    oExcel.Cells(31, 5).Value = txtRepeticion(2)
    '    oExcel.Cells(32, 3).Value = txtIndividuos(0)
    '    oExcel.Cells(32, 4).Value = txtIndividuos(1)
    '    oExcel.Cells(32, 5).Value = txtIndividuos(2)
    '    oExcel.Cells(33, 3).Value = CDec(txtIndividuos(0)) * CDec(IIf(txtCobertura(0) = "", 0, txtCobertura(0))) / 100
    '    oExcel.Cells(33, 4).Value = CDec(IIf(txtIndividuos(1) = "", 0, txtIndividuos(1))) * CDec(IIf(txtCobertura(1) = "", 0, txtCobertura(1))) / 100
    '    oExcel.Cells(33, 5).Value = CDec(IIf(txtIndividuos(2) = "", 0, txtIndividuos(2))) * CDec(IIf(txtCobertura(2) = "", 0, txtCobertura(2))) / 100

    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    '''''''''''''''''''''''  Hoja 3  '''''''''''''''''''''''''''''''''
    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '    oExcel.Cells(22, 3).Value = ContLV
    '    oExcel.Cells(23, 3).Value = ContSD
    '    'oExcel.Cells(25, 3).Value = ContHa19
    '    'oExcel.Cells(26, 3).Value = ContH19c

    '    s = 0
    '    Do While s <= UBound(ContHorasCorte)
    '        If s = 0 Then
    '            oExcel.Cells(25 + s, 1).Value = "Desde 06:00 hasta " & Mid(ar(s), 1, 2) & ":" & Mid(ar(s), 3, 2)
    '        ElseIf s = UBound(ContHorasCorte) Then
    '            oExcel.Cells(25 + s, 1).Value = "Desde " & Mid(ar(s - 1), 1, 2) & ":" & Mid(ar(s - 1), 3, 2) & " hasta 30:00"
    '        Else
    '            oExcel.Cells(25 + s, 1).Value = "Desde " & Mid(ar(s - 1), 1, 2) & ":" & Mid(ar(s - 1), 3, 2) & " hasta " & Mid(ar(s), 1, 2) & ":" & Mid(ar(s), 3, 2)
    '        End If
    '        oExcel.Cells(25 + s, 3).Value = ContHorasCorte(s)
    '        s = s + 1
    '    Loop

    '    For i = 0 To topComerciales - 1
    '        oExcel.Range("A" & 28 + i + (s - 1)).Select()
    '        oExcel.Selection.EntireRow.Insert()
    '        oExcel.Cells(28 + i + (s - 1), 1).Value = Mid(arComerciales(i, 0), InStrRev(arComerciales(i, 0), "/") + 1)
    '        oExcel.Cells(28 + i + (s - 1), 3).Value = arComerciales(i, 1)
    '    Next i

    '    For j = 0 To topSemanas - 1
    '        oExcel.Range("A" & 28 + j + i + (s - 1) + 1).Select()
    '        oExcel.Selection.EntireRow.Insert()
    '        oExcel.Cells(28 + j + i + (s - 1) + 1, 1).Value = "Semana del " & arSemanas(j, 0)
    '        oExcel.Cells(28 + j + i + (s - 1) + 1, 3).Value = arSemanas(j, 1)
    '    Next j

    '    For r = 0 To topCanales - 1
    '        oExcel.Range("A" & 28 + j + i + r + s + 1 + 1).Select()
    '        oExcel.Selection.EntireRow.Insert()
    '        oExcel.Cells(28 + j + i + r + 1 + (s - 1) + 1, 1).Value = arCanales(r, 0)
    '        oExcel.Cells(28 + j + i + r + 1 + (s - 1) + 1, 3).Value = arCanales(r, 1)
    '    Next r

    'End Sub

    Private Function ParseStr(ByVal strWork As String, ByVal intTokenNum As Integer, ByVal strDelimitChr As String, Optional ByVal strEncapChr As String = "") As String
        Dim blnExitDo As Boolean
        Dim intDPos As Integer
        Dim intSPtr As Integer
        Dim intEPtr As Integer
        Dim intCurrentTokenNum As Integer
        Dim intWorkStrLen As Integer
        Dim intEncapStatus As Integer
        Static intSPos As Integer
        Dim strTemp As String
        Static intDelimitLen As Integer

        intWorkStrLen = Len(strWork)

        If Len(strEncapChr) Then
            intEncapStatus = Len(strEncapChr)
        End If

        If intWorkStrLen = 0 Or (intSPos > intWorkStrLen And intTokenNum = 0) Then
            intSPos = 0
            Exit Function
        ElseIf intTokenNum > 0 Or intSPos = 0 Then
            intSPos = 1
            intDelimitLen = Len(strDelimitChr)
        End If

        Do

            intDPos = InStr(intSPos, strWork, strDelimitChr)

            If intEncapStatus Then
                intSPtr = InStr(intSPos, strWork, strEncapChr)
                intEPtr = InStr(intSPtr + 1, strWork, strEncapChr)
                If intDPos > intSPtr And intDPos < intEPtr Then
                    intDPos = InStr(intEPtr, strWork, strDelimitChr)
                End If
            End If

            If intDPos < intSPos Then
                intDPos = intWorkStrLen + intDelimitLen
            End If

            If intDPos Then
                If intTokenNum Then
                    intCurrentTokenNum = intCurrentTokenNum + 1
                    If intCurrentTokenNum = intTokenNum Then
                        strTemp = Mid(strWork, intSPos, intDPos - intSPos)
                        blnExitDo = True
                    Else
                        blnExitDo = False
                    End If
                Else
                    strTemp = Mid(strWork, intSPos, intDPos - intSPos)
                    blnExitDo = True
                End If
                intSPos = intDPos + intDelimitLen
            Else
                intSPos = 0
                blnExitDo = True
            End If
        Loop Until blnExitDo

        If intEncapStatus Then
            '    ParseStr = ReplaceCS(strTemp, strEncapChr, "", StringBinaryCompare)
        Else
            ParseStr = strTemp
        End If

    End Function

    Function Redondeo(ByVal Importe As Double) As Double

        If Importe >= 0 Then
            Redondeo = Fix((Importe + 0.005) * 100) / 100
        Else
            Redondeo = Fix((Importe - 0.005) * 100) / 100
        End If

    End Function
End Class

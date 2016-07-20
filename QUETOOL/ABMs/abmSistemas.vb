Public Class abmSistemas
    Inherits System.Windows.Forms.UserControl
    Implements IABM

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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

    Friend WithEvents txtBRFBruto As QUETOOL.txtTexto
    Friend WithEvents txtBRFNeto As QUETOOL.txtTexto
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVar2Texto As QUETOOL.txtTexto
    Friend WithEvents txtVar1Texto As QUETOOL.txtTexto
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtVar4Texto As QUETOOL.txtTexto
    Friend WithEvents txtVar3Texto As QUETOOL.txtTexto
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboTipoSoporte As QUETOOL.cboCombo
    Friend WithEvents cboTipoRating As QUETOOL.cboCombo
    Friend WithEvents cboDatePart As QUETOOL.cboCombo
    Friend WithEvents fraBrief As System.Windows.Forms.GroupBox
    Friend WithEvents fraObjetivos As System.Windows.Forms.GroupBox
    Friend WithEvents fraGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents fraTarget As System.Windows.Forms.GroupBox
    Friend WithEvents fraOtros As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtVar1Valor As QUETOOL.txtTexto
    Friend WithEvents txtVar2Valor As QUETOOL.txtTexto
    Friend WithEvents txtVar3Valor As QUETOOL.txtTexto
    Friend WithEvents txtVar4Valor As QUETOOL.txtTexto
    Friend WithEvents lblConsultarAudiencia As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents fraAudiencia As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaInicio As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaFin As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaInicioAudiencia As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaFinAudiencia As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaVigor As QUETOOL.dtpFecha
    Friend WithEvents chkFechaVigencia As System.Windows.Forms.CheckBox
    Friend WithEvents txtDef As QUETOOL.txtTexto
    Friend WithEvents cboTarget1 As QUETOOL.cboComboWindows
    Friend WithEvents cboTarget2 As QUETOOL.cboComboWindows
    Friend WithEvents cboPlaza As QUETOOL.cboCombo
    Friend WithEvents CboMedio As QUETOOL.cboCombo
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents fraAudienciaRadio As System.Windows.Forms.GroupBox
    Friend WithEvents lblPeriodoAudiencia As System.Windows.Forms.Label
    Friend WithEvents cboAudienciaRadio As QUETOOL.cboCombo
    Friend WithEvents rgTipoSistema As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblTipoRating As System.Windows.Forms.Label

    Private Sub InitializeComponent()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmSistemas))
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.fraBrief = New System.Windows.Forms.GroupBox
        Me.txtBRFBruto = New QUETOOL.txtTexto
        Me.txtBRFNeto = New QUETOOL.txtTexto
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.fraObjetivos = New System.Windows.Forms.GroupBox
        Me.txtVar4Valor = New QUETOOL.txtTexto
        Me.txtVar3Valor = New QUETOOL.txtTexto
        Me.txtVar2Valor = New QUETOOL.txtTexto
        Me.txtVar1Valor = New QUETOOL.txtTexto
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtVar4Texto = New QUETOOL.txtTexto
        Me.txtVar3Texto = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtVar2Texto = New QUETOOL.txtTexto
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtVar1Texto = New QUETOOL.txtTexto
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.fraGeneral = New System.Windows.Forms.GroupBox
        Me.CboMedio = New QUETOOL.cboCombo
        Me.lblMedio = New System.Windows.Forms.Label
        Me.dtpFechaFin = New QUETOOL.dtpFecha
        Me.dtpFechaInicio = New QUETOOL.dtpFecha
        Me.cboPlaza = New QUETOOL.cboCombo
        Me.Label25 = New System.Windows.Forms.Label
        Me.cboTipoRating = New QUETOOL.cboCombo
        Me.cboTipoSoporte = New QUETOOL.cboCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblTipoRating = New System.Windows.Forms.Label
        Me.fraAudiencia = New System.Windows.Forms.GroupBox
        Me.dtpFechaFinAudiencia = New QUETOOL.dtpFecha
        Me.dtpFechaInicioAudiencia = New QUETOOL.dtpFecha
        Me.lblConsultarAudiencia = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.fraTarget = New System.Windows.Forms.GroupBox
        Me.cboTarget2 = New QUETOOL.cboComboWindows
        Me.cboTarget1 = New QUETOOL.cboComboWindows
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.fraOtros = New System.Windows.Forms.GroupBox
        Me.txtDef = New QUETOOL.txtTexto
        Me.chkFechaVigencia = New System.Windows.Forms.CheckBox
        Me.dtpFechaVigor = New QUETOOL.dtpFecha
        Me.cboDatePart = New QUETOOL.cboCombo
        Me.fraAudienciaRadio = New System.Windows.Forms.GroupBox
        Me.cboAudienciaRadio = New QUETOOL.cboCombo
        Me.lblPeriodoAudiencia = New System.Windows.Forms.Label
        Me.rgTipoSistema = New DevExpress.XtraEditors.RadioGroup
        Me.fraBrief.SuspendLayout()
        Me.fraObjetivos.SuspendLayout()
        Me.fraGeneral.SuspendLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPlaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraAudiencia.SuspendLayout()
        CType(Me.dtpFechaFinAudiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioAudiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraTarget.SuspendLayout()
        Me.fraOtros.SuspendLayout()
        CType(Me.dtpFechaVigor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDatePart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraAudienciaRadio.SuspendLayout()
        CType(Me.cboAudienciaRadio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipoSistema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraBrief
        '
        Me.fraBrief.Controls.Add(Me.txtBRFBruto)
        Me.fraBrief.Controls.Add(Me.txtBRFNeto)
        Me.fraBrief.Controls.Add(Me.Label8)
        Me.fraBrief.Controls.Add(Me.Label7)
        Me.fraBrief.Enabled = False
        Me.fraBrief.Location = New System.Drawing.Point(0, 352)
        Me.fraBrief.Name = "fraBrief"
        Me.fraBrief.Size = New System.Drawing.Size(452, 50)
        Me.fraBrief.TabIndex = 4
        Me.fraBrief.TabStop = False
        Me.fraBrief.Text = "Información de Brief"
        '
        'txtBRFBruto
        '
        Me.txtBRFBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBRFBruto.ConDecimal = False
        Me.txtBRFBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRFBruto.Location = New System.Drawing.Point(332, 16)
        Me.txtBRFBruto.Maximo = 0
        Me.txtBRFBruto.MaxLength = 10
        Me.txtBRFBruto.Name = "txtBRFBruto"
        Me.txtBRFBruto.Size = New System.Drawing.Size(108, 21)
        Me.txtBRFBruto.SoloLetra = False
        Me.txtBRFBruto.SoloNumero = True
        Me.txtBRFBruto.TabIndex = 1
        Me.txtBRFBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBRFNeto
        '
        Me.txtBRFNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBRFNeto.ConDecimal = False
        Me.txtBRFNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRFNeto.Location = New System.Drawing.Point(100, 16)
        Me.txtBRFNeto.Maximo = 0
        Me.txtBRFNeto.MaxLength = 10
        Me.txtBRFNeto.Name = "txtBRFNeto"
        Me.txtBRFNeto.Size = New System.Drawing.Size(104, 21)
        Me.txtBRFNeto.SoloLetra = False
        Me.txtBRFNeto.SoloNumero = True
        Me.txtBRFNeto.TabIndex = 0
        Me.txtBRFNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Inversión Bruta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Inversión Neta"
        '
        'fraObjetivos
        '
        Me.fraObjetivos.Controls.Add(Me.txtVar4Valor)
        Me.fraObjetivos.Controls.Add(Me.txtVar3Valor)
        Me.fraObjetivos.Controls.Add(Me.txtVar2Valor)
        Me.fraObjetivos.Controls.Add(Me.txtVar1Valor)
        Me.fraObjetivos.Controls.Add(Me.Label24)
        Me.fraObjetivos.Controls.Add(Me.Label23)
        Me.fraObjetivos.Controls.Add(Me.Label22)
        Me.fraObjetivos.Controls.Add(Me.Label17)
        Me.fraObjetivos.Controls.Add(Me.txtVar4Texto)
        Me.fraObjetivos.Controls.Add(Me.txtVar3Texto)
        Me.fraObjetivos.Controls.Add(Me.Label1)
        Me.fraObjetivos.Controls.Add(Me.Label2)
        Me.fraObjetivos.Controls.Add(Me.txtVar2Texto)
        Me.fraObjetivos.Controls.Add(Me.Label16)
        Me.fraObjetivos.Controls.Add(Me.Label14)
        Me.fraObjetivos.Controls.Add(Me.txtVar1Texto)
        Me.fraObjetivos.Enabled = False
        Me.fraObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraObjetivos.Location = New System.Drawing.Point(0, 408)
        Me.fraObjetivos.Name = "fraObjetivos"
        Me.fraObjetivos.Size = New System.Drawing.Size(452, 182)
        Me.fraObjetivos.TabIndex = 5
        Me.fraObjetivos.TabStop = False
        Me.fraObjetivos.Text = "Objetivos de Comunicación"
        '
        'txtVar4Valor
        '
        Me.txtVar4Valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar4Valor.ConDecimal = False
        Me.txtVar4Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar4Valor.Location = New System.Drawing.Point(384, 140)
        Me.txtVar4Valor.Maximo = 100
        Me.txtVar4Valor.MaxLength = 50
        Me.txtVar4Valor.Name = "txtVar4Valor"
        Me.txtVar4Valor.Size = New System.Drawing.Size(40, 21)
        Me.txtVar4Valor.SoloLetra = False
        Me.txtVar4Valor.SoloNumero = True
        Me.txtVar4Valor.TabIndex = 7
        Me.txtVar4Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVar3Valor
        '
        Me.txtVar3Valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar3Valor.ConDecimal = False
        Me.txtVar3Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar3Valor.Location = New System.Drawing.Point(384, 100)
        Me.txtVar3Valor.Maximo = 100
        Me.txtVar3Valor.MaxLength = 50
        Me.txtVar3Valor.Name = "txtVar3Valor"
        Me.txtVar3Valor.Size = New System.Drawing.Size(40, 21)
        Me.txtVar3Valor.SoloLetra = False
        Me.txtVar3Valor.SoloNumero = True
        Me.txtVar3Valor.TabIndex = 5
        Me.txtVar3Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVar2Valor
        '
        Me.txtVar2Valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar2Valor.ConDecimal = False
        Me.txtVar2Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar2Valor.Location = New System.Drawing.Point(384, 56)
        Me.txtVar2Valor.Maximo = 100
        Me.txtVar2Valor.MaxLength = 50
        Me.txtVar2Valor.Name = "txtVar2Valor"
        Me.txtVar2Valor.Size = New System.Drawing.Size(40, 21)
        Me.txtVar2Valor.SoloLetra = False
        Me.txtVar2Valor.SoloNumero = True
        Me.txtVar2Valor.TabIndex = 3
        Me.txtVar2Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVar1Valor
        '
        Me.txtVar1Valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar1Valor.ConDecimal = False
        Me.txtVar1Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar1Valor.Location = New System.Drawing.Point(384, 16)
        Me.txtVar1Valor.Maximo = 100
        Me.txtVar1Valor.MaxLength = 50
        Me.txtVar1Valor.Multiline = True
        Me.txtVar1Valor.Name = "txtVar1Valor"
        Me.txtVar1Valor.Size = New System.Drawing.Size(40, 21)
        Me.txtVar1Valor.SoloLetra = False
        Me.txtVar1Valor.SoloNumero = True
        Me.txtVar1Valor.TabIndex = 1
        Me.txtVar1Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(428, 144)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 16)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "%"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(428, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 16)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "%"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(428, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 16)
        Me.Label22.TabIndex = 92
        Me.Label22.Text = "%"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(428, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 16)
        Me.Label17.TabIndex = 91
        Me.Label17.Text = "%"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVar4Texto
        '
        Me.txtVar4Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar4Texto.ConDecimal = False
        Me.txtVar4Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar4Texto.Location = New System.Drawing.Point(36, 140)
        Me.txtVar4Texto.Maximo = 0
        Me.txtVar4Texto.MaxLength = 50
        Me.txtVar4Texto.Multiline = True
        Me.txtVar4Texto.Name = "txtVar4Texto"
        Me.txtVar4Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVar4Texto.Size = New System.Drawing.Size(340, 36)
        Me.txtVar4Texto.SoloLetra = False
        Me.txtVar4Texto.SoloNumero = False
        Me.txtVar4Texto.TabIndex = 6
        '
        'txtVar3Texto
        '
        Me.txtVar3Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar3Texto.ConDecimal = False
        Me.txtVar3Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar3Texto.Location = New System.Drawing.Point(36, 100)
        Me.txtVar3Texto.Maximo = 0
        Me.txtVar3Texto.MaxLength = 50
        Me.txtVar3Texto.Multiline = True
        Me.txtVar3Texto.Name = "txtVar3Texto"
        Me.txtVar3Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVar3Texto.Size = New System.Drawing.Size(340, 36)
        Me.txtVar3Texto.SoloLetra = False
        Me.txtVar3Texto.SoloNumero = False
        Me.txtVar3Texto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "3)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "4)"
        '
        'txtVar2Texto
        '
        Me.txtVar2Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar2Texto.ConDecimal = False
        Me.txtVar2Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar2Texto.Location = New System.Drawing.Point(36, 56)
        Me.txtVar2Texto.Maximo = 0
        Me.txtVar2Texto.MaxLength = 50
        Me.txtVar2Texto.Multiline = True
        Me.txtVar2Texto.Name = "txtVar2Texto"
        Me.txtVar2Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVar2Texto.Size = New System.Drawing.Size(340, 40)
        Me.txtVar2Texto.SoloLetra = False
        Me.txtVar2Texto.SoloNumero = False
        Me.txtVar2Texto.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 13)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "1)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 13)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "2)"
        '
        'txtVar1Texto
        '
        Me.txtVar1Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar1Texto.ConDecimal = False
        Me.txtVar1Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar1Texto.Location = New System.Drawing.Point(36, 16)
        Me.txtVar1Texto.Maximo = 0
        Me.txtVar1Texto.MaxLength = 50
        Me.txtVar1Texto.Multiline = True
        Me.txtVar1Texto.Name = "txtVar1Texto"
        Me.txtVar1Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVar1Texto.Size = New System.Drawing.Size(340, 36)
        Me.txtVar1Texto.SoloLetra = False
        Me.txtVar1Texto.SoloNumero = False
        Me.txtVar1Texto.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha Inicio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Tarifas Vigencia Opcional"
        '
        'fraGeneral
        '
        Me.fraGeneral.Controls.Add(Me.rgTipoSistema)
        Me.fraGeneral.Controls.Add(Me.CboMedio)
        Me.fraGeneral.Controls.Add(Me.lblMedio)
        Me.fraGeneral.Controls.Add(Me.dtpFechaFin)
        Me.fraGeneral.Controls.Add(Me.dtpFechaInicio)
        Me.fraGeneral.Controls.Add(Me.cboPlaza)
        Me.fraGeneral.Controls.Add(Me.Label25)
        Me.fraGeneral.Controls.Add(Me.cboTipoRating)
        Me.fraGeneral.Controls.Add(Me.cboTipoSoporte)
        Me.fraGeneral.Controls.Add(Me.Label6)
        Me.fraGeneral.Controls.Add(Me.Label5)
        Me.fraGeneral.Controls.Add(Me.Label4)
        Me.fraGeneral.Controls.Add(Me.txtDescripcion)
        Me.fraGeneral.Controls.Add(Me.Label21)
        Me.fraGeneral.Controls.Add(Me.lblTipoRating)
        Me.fraGeneral.Enabled = False
        Me.fraGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraGeneral.Location = New System.Drawing.Point(0, 4)
        Me.fraGeneral.Name = "fraGeneral"
        Me.fraGeneral.Size = New System.Drawing.Size(452, 144)
        Me.fraGeneral.TabIndex = 0
        Me.fraGeneral.TabStop = False
        Me.fraGeneral.Text = "Información General"
        '
        'CboMedio
        '
        Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboMedio.DisplayMember = ""
        Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboMedio.Enabled = False
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedio.Location = New System.Drawing.Point(92, 16)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(124, 21)
        Me.CboMedio.TabIndex = 76
        Me.CboMedio.Tag = "Tipo de Soporte del Sistema"
        Me.CboMedio.ValueMember = ""
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(12, 20)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(36, 13)
        Me.lblMedio.TabIndex = 77
        Me.lblMedio.Text = "Medio"
        '
        'dtpFechaFin
        '
        Appearance11.FontData.SizeInPoints = 9.0!
        Me.dtpFechaFin.Appearance = Appearance11
        Me.dtpFechaFin.FlatMode = True
        Me.dtpFechaFin.Location = New System.Drawing.Point(316, 112)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(124, 21)
        Me.dtpFechaFin.TabIndex = 5
        '
        'dtpFechaInicio
        '
        Appearance12.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicio.Appearance = Appearance12
        Me.dtpFechaInicio.FlatMode = True
        Me.dtpFechaInicio.Location = New System.Drawing.Point(92, 112)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(124, 21)
        Me.dtpFechaInicio.TabIndex = 4
        '
        'cboPlaza
        '
        Me.cboPlaza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPlaza.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPlaza.DisplayMember = ""
        Me.cboPlaza.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboPlaza.FlatMode = True
        Me.cboPlaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlaza.Location = New System.Drawing.Point(92, 64)
        Me.cboPlaza.Name = "cboPlaza"
        Me.cboPlaza.Size = New System.Drawing.Size(164, 21)
        Me.cboPlaza.TabIndex = 2
        Me.cboPlaza.ValueMember = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 13)
        Me.Label25.TabIndex = 75
        Me.Label25.Text = "Plaza"
        '
        'cboTipoRating
        '
        Me.cboTipoRating.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoRating.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoRating.DisplayMember = ""
        Me.cboTipoRating.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTipoRating.FlatMode = True
        Me.cboTipoRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoRating.Location = New System.Drawing.Point(316, 64)
        Me.cboTipoRating.Name = "cboTipoRating"
        Me.cboTipoRating.Size = New System.Drawing.Size(124, 21)
        Me.cboTipoRating.TabIndex = 1
        Me.cboTipoRating.ValueMember = ""
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoSoporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoSoporte.DisplayMember = ""
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTipoSoporte.Enabled = False
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoSoporte.Location = New System.Drawing.Point(92, 40)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.Size = New System.Drawing.Size(348, 21)
        Me.cboTipoSoporte.TabIndex = 0
        Me.cboTipoSoporte.Tag = "Tipo de Soporte del Sistema"
        Me.cboTipoSoporte.ValueMember = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(244, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Fecha de Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Fecha de Inicio"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(92, 88)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(348, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Tipo Soporte"
        '
        'lblTipoRating
        '
        Me.lblTipoRating.AutoSize = True
        Me.lblTipoRating.Location = New System.Drawing.Point(256, 68)
        Me.lblTipoRating.Name = "lblTipoRating"
        Me.lblTipoRating.Size = New System.Drawing.Size(62, 13)
        Me.lblTipoRating.TabIndex = 34
        Me.lblTipoRating.Text = "Tipo Rating"
        '
        'fraAudiencia
        '
        Me.fraAudiencia.Controls.Add(Me.dtpFechaFinAudiencia)
        Me.fraAudiencia.Controls.Add(Me.dtpFechaInicioAudiencia)
        Me.fraAudiencia.Controls.Add(Me.lblConsultarAudiencia)
        Me.fraAudiencia.Controls.Add(Me.Label10)
        Me.fraAudiencia.Controls.Add(Me.Label9)
        Me.fraAudiencia.Enabled = False
        Me.fraAudiencia.Location = New System.Drawing.Point(0, 228)
        Me.fraAudiencia.Name = "fraAudiencia"
        Me.fraAudiencia.Size = New System.Drawing.Size(452, 48)
        Me.fraAudiencia.TabIndex = 2
        Me.fraAudiencia.TabStop = False
        Me.fraAudiencia.Text = "Audiencia"
        '
        'dtpFechaFinAudiencia
        '
        Appearance13.FontData.SizeInPoints = 9.0!
        Me.dtpFechaFinAudiencia.Appearance = Appearance13
        Me.dtpFechaFinAudiencia.FlatMode = True
        Me.dtpFechaFinAudiencia.Location = New System.Drawing.Point(328, 16)
        Me.dtpFechaFinAudiencia.Name = "dtpFechaFinAudiencia"
        Me.dtpFechaFinAudiencia.Size = New System.Drawing.Size(112, 21)
        Me.dtpFechaFinAudiencia.TabIndex = 1
        '
        'dtpFechaInicioAudiencia
        '
        Appearance14.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicioAudiencia.Appearance = Appearance14
        Me.dtpFechaInicioAudiencia.FlatMode = True
        Me.dtpFechaInicioAudiencia.Location = New System.Drawing.Point(128, 16)
        Me.dtpFechaInicioAudiencia.Name = "dtpFechaInicioAudiencia"
        Me.dtpFechaInicioAudiencia.Size = New System.Drawing.Size(116, 21)
        Me.dtpFechaInicioAudiencia.TabIndex = 0
        '
        'lblConsultarAudiencia
        '
        Me.lblConsultarAudiencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsultarAudiencia.Image = CType(resources.GetObject("lblConsultarAudiencia.Image"), System.Drawing.Image)
        Me.lblConsultarAudiencia.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblConsultarAudiencia.Location = New System.Drawing.Point(12, 18)
        Me.lblConsultarAudiencia.Name = "lblConsultarAudiencia"
        Me.lblConsultarAudiencia.Size = New System.Drawing.Size(21, 21)
        Me.lblConsultarAudiencia.TabIndex = 8
        Me.lblConsultarAudiencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Fecha Fin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Fecha Inicio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Target 1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Target 2"
        '
        'fraTarget
        '
        Me.fraTarget.Controls.Add(Me.cboTarget2)
        Me.fraTarget.Controls.Add(Me.cboTarget1)
        Me.fraTarget.Controls.Add(Me.Label11)
        Me.fraTarget.Controls.Add(Me.Label12)
        Me.fraTarget.Enabled = False
        Me.fraTarget.Location = New System.Drawing.Point(0, 152)
        Me.fraTarget.Name = "fraTarget"
        Me.fraTarget.Size = New System.Drawing.Size(452, 68)
        Me.fraTarget.TabIndex = 1
        Me.fraTarget.TabStop = False
        Me.fraTarget.Text = "Target"
        '
        'cboTarget2
        '
        Me.cboTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTarget2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTarget2.Location = New System.Drawing.Point(68, 44)
        Me.cboTarget2.Name = "cboTarget2"
        Me.cboTarget2.Size = New System.Drawing.Size(372, 21)
        Me.cboTarget2.TabIndex = 31
        '
        'cboTarget1
        '
        Me.cboTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTarget1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTarget1.Location = New System.Drawing.Point(68, 16)
        Me.cboTarget1.Name = "cboTarget1"
        Me.cboTarget1.Size = New System.Drawing.Size(372, 21)
        Me.cboTarget1.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(260, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Deflactación"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Franja Horaria"
        '
        'fraOtros
        '
        Me.fraOtros.BackColor = System.Drawing.SystemColors.Control
        Me.fraOtros.Controls.Add(Me.txtDef)
        Me.fraOtros.Controls.Add(Me.chkFechaVigencia)
        Me.fraOtros.Controls.Add(Me.dtpFechaVigor)
        Me.fraOtros.Controls.Add(Me.cboDatePart)
        Me.fraOtros.Controls.Add(Me.Label15)
        Me.fraOtros.Controls.Add(Me.Label18)
        Me.fraOtros.Controls.Add(Me.Label20)
        Me.fraOtros.Enabled = False
        Me.fraOtros.Location = New System.Drawing.Point(0, 280)
        Me.fraOtros.Name = "fraOtros"
        Me.fraOtros.Size = New System.Drawing.Size(452, 71)
        Me.fraOtros.TabIndex = 3
        Me.fraOtros.TabStop = False
        Me.fraOtros.Text = "Otros"
        '
        'txtDef
        '
        Me.txtDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDef.ConDecimal = True
        Me.txtDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDef.Location = New System.Drawing.Point(332, 16)
        Me.txtDef.Maximo = 0
        Me.txtDef.MaxLength = 4
        Me.txtDef.Name = "txtDef"
        Me.txtDef.Size = New System.Drawing.Size(108, 21)
        Me.txtDef.SoloLetra = False
        Me.txtDef.SoloNumero = False
        Me.txtDef.TabIndex = 1
        Me.txtDef.Text = "1"
        Me.txtDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkFechaVigencia
        '
        Me.chkFechaVigencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFechaVigencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFechaVigencia.Location = New System.Drawing.Point(164, 48)
        Me.chkFechaVigencia.Name = "chkFechaVigencia"
        Me.chkFechaVigencia.Size = New System.Drawing.Size(16, 16)
        Me.chkFechaVigencia.TabIndex = 36
        '
        'dtpFechaVigor
        '
        Appearance15.FontData.SizeInPoints = 9.0!
        Me.dtpFechaVigor.Appearance = Appearance15
        Me.dtpFechaVigor.Enabled = False
        Me.dtpFechaVigor.FlatMode = True
        Me.dtpFechaVigor.Location = New System.Drawing.Point(184, 44)
        Me.dtpFechaVigor.Name = "dtpFechaVigor"
        Me.dtpFechaVigor.Size = New System.Drawing.Size(256, 21)
        Me.dtpFechaVigor.TabIndex = 2
        '
        'cboDatePart
        '
        Me.cboDatePart.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDatePart.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDatePart.DisplayMember = ""
        Me.cboDatePart.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboDatePart.FlatMode = True
        Me.cboDatePart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDatePart.Location = New System.Drawing.Point(96, 16)
        Me.cboDatePart.Name = "cboDatePart"
        Me.cboDatePart.Size = New System.Drawing.Size(148, 21)
        Me.cboDatePart.TabIndex = 0
        Me.cboDatePart.ValueMember = ""
        '
        'fraAudienciaRadio
        '
        Me.fraAudienciaRadio.Controls.Add(Me.cboAudienciaRadio)
        Me.fraAudienciaRadio.Controls.Add(Me.lblPeriodoAudiencia)
        Me.fraAudienciaRadio.Location = New System.Drawing.Point(0, 228)
        Me.fraAudienciaRadio.Name = "fraAudienciaRadio"
        Me.fraAudienciaRadio.Size = New System.Drawing.Size(452, 48)
        Me.fraAudienciaRadio.TabIndex = 6
        Me.fraAudienciaRadio.TabStop = False
        Me.fraAudienciaRadio.Text = "Audiencia"
        Me.fraAudienciaRadio.Visible = False
        '
        'cboAudienciaRadio
        '
        Me.cboAudienciaRadio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAudienciaRadio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudienciaRadio.DisplayMember = ""
        Me.cboAudienciaRadio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboAudienciaRadio.FlatMode = True
        Me.cboAudienciaRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudienciaRadio.Location = New System.Drawing.Point(124, 16)
        Me.cboAudienciaRadio.Name = "cboAudienciaRadio"
        Me.cboAudienciaRadio.Size = New System.Drawing.Size(316, 21)
        Me.cboAudienciaRadio.TabIndex = 6
        Me.cboAudienciaRadio.Tag = "Tipo de Soporte del Sistema"
        Me.cboAudienciaRadio.ValueMember = ""
        '
        'lblPeriodoAudiencia
        '
        Me.lblPeriodoAudiencia.AutoSize = True
        Me.lblPeriodoAudiencia.Location = New System.Drawing.Point(12, 20)
        Me.lblPeriodoAudiencia.Name = "lblPeriodoAudiencia"
        Me.lblPeriodoAudiencia.Size = New System.Drawing.Size(110, 13)
        Me.lblPeriodoAudiencia.TabIndex = 5
        Me.lblPeriodoAudiencia.Text = "Período de Audiencia"
        '
        'rgTipoSistema
        '
        Me.rgTipoSistema.Enabled = False
        Me.rgTipoSistema.Location = New System.Drawing.Point(247, 17)
        Me.rgTipoSistema.Name = "rgTipoSistema"
        Me.rgTipoSistema.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Estandard"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Costo Punto")})
        Me.rgTipoSistema.Size = New System.Drawing.Size(189, 20)
        Me.rgTipoSistema.TabIndex = 79
        '
        'abmSistemas
        '
        Me.Controls.Add(Me.fraAudiencia)
        Me.Controls.Add(Me.fraAudienciaRadio)
        Me.Controls.Add(Me.fraGeneral)
        Me.Controls.Add(Me.fraObjetivos)
        Me.Controls.Add(Me.fraOtros)
        Me.Controls.Add(Me.fraTarget)
        Me.Controls.Add(Me.fraBrief)
        Me.Name = "abmSistemas"
        Me.Size = New System.Drawing.Size(456, 596)
        Me.fraBrief.ResumeLayout(False)
        Me.fraBrief.PerformLayout()
        Me.fraObjetivos.ResumeLayout(False)
        Me.fraObjetivos.PerformLayout()
        Me.fraGeneral.ResumeLayout(False)
        Me.fraGeneral.PerformLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPlaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraAudiencia.ResumeLayout(False)
        Me.fraAudiencia.PerformLayout()
        CType(Me.dtpFechaFinAudiencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioAudiencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraTarget.ResumeLayout(False)
        Me.fraTarget.PerformLayout()
        Me.fraOtros.ResumeLayout(False)
        Me.fraOtros.PerformLayout()
        CType(Me.dtpFechaVigor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDatePart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraAudienciaRadio.ResumeLayout(False)
        Me.fraAudienciaRadio.PerformLayout()
        CType(Me.cboAudienciaRadio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipoSistema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Dim S As New Sistemas

    Dim mParametros As TablaHash

    Dim mModificar As Boolean
    Dim mDebeGuardar As Boolean

    'mantiene los valores seleccionados
    Dim IDPlaza As Integer
    Dim IDTarget1 As Integer
    Dim IDTarget2 As Object

    Dim IDTarget1Anterior, IDTarget2Anterior As Integer
    Dim FechaAudDesdeAnterior, FechaAudHastaAnterior As Date
    Dim FechaSisDesdeAnterior, FechaSisHastaAnterior As Date
    Dim DefAnterior As Decimal
    Dim Guardo As Boolean
    Const MedioRadio As Integer = 6

    Public Property DebeGuardar() As Boolean Implements Framework.IABM.DebeGuardar
        Get
            Return mDebeGuardar
        End Get
        Set(ByVal Value As Boolean)
            mDebeGuardar = Value
        End Set
    End Property

    Public Property Modificar() As Boolean Implements Framework.IABM.Modificar
        Get
            Return mModificar
        End Get
        Set(ByVal Value As Boolean)
            mModificar = Value
        End Set
    End Property

    Public ReadOnly Property Alto() As Integer Implements Framework.IABM.Alto
        Get
            Return Me.Height
        End Get
    End Property

    Public ReadOnly Property Ancho() As Integer Implements Framework.IABM.Ancho
        Get
            Return Me.Width
        End Get
    End Property

    Public Overloads Sub Cargar() Implements Framework.IABM.Cargar
        With S
            ' inicializo la variable que me dice si puede recalcular.
            ' Solo lo dejo recalcular si: Modifico algun campo y no grabo.
            .Id_campania = Activo.IDCampaña
            .Id_sistema = Activo.IDSistema

            .BuscarPorID()

            Activo.FechaInicioSistema = .F_inicio
            Activo.FechaFinSistema = .F_fin
            Activo.IDMedio = .Id_medio
            If .Id_medio = 3 Or .Id_medio = 4 Or .Id_medio = 5 Then
                Activo.FechaInicioAudiencia = .F_inicio
                Activo.FechaFinAudiencia = .F_fin
            Else
                Activo.FechaInicioAudiencia = .F_inicio_aud
                Activo.FechaFinAudiencia = .F_fin_aud
            End If

            Activo.IDTipoSoporte = .Id_tipo_soporte
            Activo.Sistema = Me.txtDescripcion.Text
            Activo.IDPlaza = .ID_Plaza

            'MANTIENE LOS DATOS ANTERIOR (ES PARA SABER SI HAY EJECUTAR EL RECALCULO O NO)
            Me.IDTarget1Anterior = .Id_target_1
            Me.IDTarget2Anterior = .Id_target_2
            IDTarget1 = .Id_target_1
            IDTarget2 = .Id_target_2
            Me.FechaAudDesdeAnterior = .F_inicio_aud
            Me.FechaAudHastaAnterior = .F_fin_aud
            Me.DefAnterior = .Deflactacion
            '***

            Me.txtDescripcion.Text = .Descripcion

            Me.dtpFechaInicio.Value = .F_inicio
            Me.dtpFechaFin.Value = .F_fin

            Me.txtBRFNeto.Text = Format(.Brf_neto, "##,##")
            Me.txtBRFBruto.Text = Format(.Brf_bruto, "##,##")

            Me.txtVar1Texto.Text = .Var1_texto
            Me.txtVar1Valor.Text = .Var1_valor

            Me.txtVar2Texto.Text = .Var2_texto
            Me.txtVar2Valor.Text = .Var2_valor

            Me.txtVar3Texto.Text = .Var3_texto
            Me.txtVar3Valor.Text = .Var3_valor

            Me.txtVar4Texto.Text = .Var4_texto
            Me.txtVar4Valor.Text = .Var4_valor

            Me.CboMedio.Value = .Id_medio
            Me.cboTipoSoporte.Value = .Id_tipo_soporte
            '**
            Me.cboTipoSoporte.Refresh()
            '***
            Me.cboPlaza.Value = .ID_Plaza
            Me.cboPlaza.Refresh()

            'carga los targets en los combos, para despues poder seleccionar el que se guardo
            CargarTargets()

            For i As Integer = 0 To Me.cboTarget1.Items.Count - 1
                If DirectCast(Me.cboTarget1.Items(i), ItemLista).ID = .Id_target_1 Then
                    Me.cboTarget1.SelectedIndex = i
                End If
            Next

            If .Id_target_2 = -1 Then
                cboTarget2.SelectedIndex = 0
            Else
                For i As Integer = 0 To Me.cboTarget2.Items.Count - 1
                    If DirectCast(Me.cboTarget2.Items(i), ItemLista).ID = .Id_target_2 Then
                        Me.cboTarget2.SelectedIndex = i
                    End If
                Next
            End If

            'cuando no hay fecha, captura la excepcion y anua el Check
            Try
                Me.dtpFechaVigor.Value = .F_Vigencia_Opcional
                Me.chkFechaVigencia.Checked = True
                Me.dtpFechaVigor.Enabled = True

            Catch ex As Exception
                Me.chkFechaVigencia.Checked = False
                Me.dtpFechaVigor.Enabled = False
                Me.dtpFechaVigor.Text = ""
            End Try

            Me.cboDatePart.Value = .Id_date_part

            'If cboDatePart.Rows.Count > 0 Then
            '    Me.cboDatePart.Rows(0).Selected = True
            '    Me.cboDatePart.Rows(0).Activated = True
            'End If


            Me.txtDef.Text = .Deflactacion

            Me.cboTipoRating.Value = .Tipo_rating
        End With

        Me.Modificar = True
        Me.DebeGuardar = False
        Me.CboMedio.Enabled = False
        Me.cboTipoSoporte.Enabled = False
        Me.fraAudiencia.Enabled = True
        Me.fraAudienciaRadio.Enabled = True
        Me.fraBrief.Enabled = True
        Me.fraGeneral.Enabled = True
        Me.fraObjetivos.Enabled = True
        Me.fraOtros.Enabled = True
        Me.fraTarget.Enabled = True


        'AG CP +++++++++++++++++++++++++++++++++++++++
        Dim siste As New Sistemas
        siste.Id_campania = Activo.IDCampaña
        siste.Id_sistema = Activo.IDSistema

        siste.BuscarPorID()
        Me.txtDescripcion.Text = siste.Descripcion
        Me.txtDescripcion.Refresh()

        If siste.Id_ejercicio_final = 1 Then
            Me.rgTipoSistema.SelectedIndex = 1
        Else
            Me.rgTipoSistema.SelectedIndex = 0
        End If

        If Activo.IDMedio = 1 Then
            Me.cboTipoSoporte.Value = siste.Id_tipo_soporte
            Me.cboTipoSoporte.Refresh()
            Me.cboTipoSoporte.Enabled = False
        End If
        '+++++++++++++++++++++++++++++++++++++++++++

        Call CargarOlas()
        SetearPantalla(Activo.IDMedio)

        Dim FechaInicioAudiencia, FechaFinAudiencia As DateTime
        If S.F_inicio_aud.Year > 1900 Then
            FechaInicioAudiencia = S.F_inicio_aud
        Else
            FechaInicioAudiencia = Activo.FechaDesdeCampaña
        End If
        If S.F_fin_aud.Year > 1900 Then
            FechaFinAudiencia = S.F_fin_aud
        Else
            FechaFinAudiencia = Activo.FechaFinCampaña
        End If

        Select Case S.Id_medio
            Case 1 ' TV
                Me.dtpFechaInicioAudiencia.Value = FechaInicioAudiencia
                Me.dtpFechaFinAudiencia.Value = FechaFinAudiencia
            Case 6 'RADIO
                Call Combo_Position(cboAudienciaRadio, "f_Inicio", FechaInicioAudiencia, "f_fin", FechaFinAudiencia)
                If cboTipoSoporte.Value = 1 Then
                    fraAudienciaRadio.Enabled = True
                Else
                    fraAudienciaRadio.Enabled = False
                End If
                fraOtros.Enabled = False
                cboTarget2.Enabled = False
            Case 3, 4, 5, 7 ' LOS OTROS 'AG Produccion +++++++++++++' LOS OTROS
                Me.dtpFechaInicioAudiencia.Value = FechaInicioAudiencia
                Me.dtpFechaFinAudiencia.Value = FechaFinAudiencia
        End Select


        Guardo = True
    End Sub

    Public Function CargarObjeto() As Boolean Implements IABM.CargarObjeto
        If Me.txtDescripcion.Text.Trim = "" Then
            Mensajes.Mensaje("Debe Ingresar la Descripción")
            txtDescripcion.Select()
            Return False
        End If

        If Me.cboTarget1.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Target 1")
            cboTarget1.Select()
            Return False
        End If

        'AG CP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'NOTA: Preguntar el tema de los RAING Tanda o Programa

        If Me.CboMedio.Value = Medios.Tv Then
            If Me.cboTipoSoporte.Value = 1 Then ' Solo aplicable para el tipo de Soporte TV ABIERTA
                If Me.rgTipoSistema.SelectedIndex = 1 Then 'Si selecciona CostoPunto
                    If Me.cboTarget2.SelectedIndex = 0 Then 'Valida que haya un Target 2
                        'Mensajes.Mensaje("Debe ingresar el Target 2")
                        'cboTarget2.Select()
                        'Return False
                    End If
                    If Me.cboTipoRating.Value = "T" Then 'Valida que el tipo de rating sea Programa
                        'Mensajes.Mensaje("Un sistema con costo punto debe tener tipo de rating Programa")
                        'cboTipoRating.Select()
                        'Return False
                    End If
                End If
            End If
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        If Not IsDate(Me.dtpFechaInicio.Text) Then
            Mensajes.Mensaje("La Fecha de Inicio No es Correcta")
            dtpFechaInicio.Select()
            Return False
        End If

        If Not IsDate(Me.dtpFechaFin.Text) Then
            Mensajes.Mensaje("La Fecha de Fin No es Correcta")
            dtpFechaFin.Select()
            Return False
        End If

        If fraAudiencia.Visible Then
            If Not IsDate(Me.dtpFechaInicioAudiencia.Text) Then
                Mensajes.Mensaje("La Fecha de Inicio de la Audiencia No es Correcta")
                dtpFechaInicioAudiencia.Select()
                Return False
            End If

            If Not IsDate(Me.dtpFechaFinAudiencia.Text) Then
                Mensajes.Mensaje("La Fecha de Fin de la Audiencia No es Correcta")
                dtpFechaFinAudiencia.Select()
                Return False
            End If
        End If

        If CboMedio.Value <> MedioRadio AndAlso (txtDef.Text = "0" Or Val(txtDef.Text) = 0) Then
            Mensajes.Mensaje("La Deflactación No Debe ser Cero")
            txtDef.Select()
            Return False
        End If

        If Not ValidarFechas() Then
            Return False
        End If

        CambiaCero(Me.txtVar1Valor.Text)
        CambiaCero(Me.txtVar2Valor.Text)
        CambiaCero(Me.txtVar3Valor.Text)
        CambiaCero(Me.txtVar4Valor.Text)
        CambiaCero(Me.txtDef.Text)
        CambiaCero(Me.txtBRFNeto.Text)
        CambiaCero(Me.txtBRFBruto.Text)

        txtDef.Text = txtDef.Text.Replace(",", ".")
        If IsNumeric(txtDef.Text) AndAlso Val(txtDef.Text) > 9.4 Then
            Mensajes.Mensaje("La Deflactación es Más Grande que el Valor Permitido (9.4)")
            txtDef.Select()
            Return False
        End If

        S.Id_sistema = Activo.IDSistema
        S.Id_campania = Activo.IDCampaña

        'guarda la plaza que se pone en el sistema para usar 
        'como plaza por defecto en el sistema que siga
        IDPlaza = Me.cboPlaza.Value
        IDTarget1 = DirectCast(Me.cboTarget1.Items(Me.cboTarget1.SelectedIndex), ItemLista).ID
        IDTarget2 = DirectCast(Me.cboTarget2.Items(Me.cboTarget2.SelectedIndex), ItemLista).ID

        S.ID_Plaza = Me.cboPlaza.Value
        S.Descripcion = Me.txtDescripcion.Text

        S.F_inicio = Me.dtpFechaInicio.Value
        S.F_fin = Me.dtpFechaFin.Value

        S.Brf_neto = Me.txtBRFNeto.Text.Replace(".", "")
        S.Brf_bruto = Me.txtBRFBruto.Text.Replace(".", "")

        S.Var1_texto = Me.txtVar1Texto.Text
        S.Var1_valor = Me.txtVar1Valor.Text

        S.Var2_texto = Me.txtVar2Texto.Text
        S.Var2_valor = Me.txtVar2Valor.Text

        S.Var3_texto = Me.txtVar3Texto.Text
        S.Var3_valor = Me.txtVar3Valor.Text

        S.Var4_texto = Me.txtVar4Texto.Text
        S.Var4_valor = Me.txtVar4Valor.Text

        'AG CP ++++++++++++++++++++++++++++++++++++++
        S.Id_ejercicio_final = rgTipoSistema.SelectedIndex
        '+++++++++++++++++++++++++++++++++++++++++++

        If fraAudiencia.Visible Then
            If Not Me.ValidarFechasAudiencia(cboTarget1) Then
                Mensajes.Mensaje("No Existen Fechas de Audiencia para el Target 1 '" & cboTarget1.Text & "'")
                Return False
            End If

            If Not Me.ValidarFechasAudiencia(cboTarget2) Then
                Mensajes.Mensaje("No Existen Fechas de Audiencia para el Target 2 '" & cboTarget2.Text & "'")
                Return False
            End If

            S.F_inicio_aud = Me.dtpFechaInicioAudiencia.Value

            S.F_fin_aud = Me.dtpFechaFinAudiencia.Value

        Else
            S.F_inicio_aud = Nothing 'Me.dtpFechaInicioAudiencia.Value
            S.F_fin_aud = Nothing 'Me.dtpFechaFinAudiencia.Value
        End If


        If fraAudienciaRadio.Visible Then
            If fraAudienciaRadio.Enabled Then
                If cboAudienciaRadio.SelectedRow Is Nothing OrElse cboAudienciaRadio.Value Is Nothing OrElse cboAudienciaRadio.SelectedRow.Cells(1).Value Is DBNull.Value OrElse cboAudienciaRadio.SelectedRow.Cells(2).Value Is DBNull.Value Then
                    Mensajes.Mensaje("Debe seleccionar un Período de Audiencia.")
                    Return False
                End If

                S.F_inicio_aud = cboAudienciaRadio.SelectedRow.Cells(1).Value
                S.F_fin_aud = cboAudienciaRadio.SelectedRow.Cells(2).Value
            Else
                S.F_inicio_aud = Nothing
                S.F_fin_aud = Nothing
            End If
        End If

        'If Not cboTarget2.SelectedRow Is Nothing AndAlso cboTarget2.SelectedRow.Index <> cboTarget2.Rows.Count - 1 And Not Me.ValidarFechasAudiencia(cboTarget2) Then
        '    Mensajes.Mensaje("No Existen Fechas de Audiencia para el Target 2 '" & cboTarget2.Text & "'")
        '    Return False
        'End If

        S.U_alta = Activo.Login
        S.U_modi = Activo.Login

        S.Id_target_1 = IDTarget1
        S.Id_target_2 = IDTarget2

        'si no esta chequeado, pasa un NOTHING
        If Me.chkFechaVigencia.Checked AndAlso Me.chkFechaVigencia.Enabled Then
            S.F_Vigencia_Opcional = Me.dtpFechaVigor.Value
        Else
            S.F_Vigencia_Opcional = Nothing
        End If

        S.Id_medio = Me.CboMedio.Value
        S.Id_tipo_soporte = Me.cboTipoSoporte.Value

        If CboMedio.Value Is Nothing OrElse CboMedio.Value <> MedioRadio Then
            S.Id_date_part = Me.cboDatePart.Value
            S.Deflactacion = Val(Me.txtDef.Text.Replace(",", "."))
            S.Tipo_rating = Me.cboTipoRating.Value
        Else
            S.Tipo_rating = "P"
        End If



        S.F_alta = Date.Today
        S.F_modi = Date.Today

        Return True
    End Function

    Private Function EjecutarRecalculo() As Boolean
        Dim ret As Boolean

        ret = True

        Dim IDTarget1 As Integer = DirectCast(Me.cboTarget1.Items(Me.cboTarget1.SelectedIndex), ItemLista).ID
        Dim IDTarget2 As Integer = DirectCast(Me.cboTarget2.Items(Me.cboTarget2.SelectedIndex), ItemLista).ID

        'si no se cambiaron los targets o las fechas de audiencia, no ejecuta el proceso
        If Me.IDTarget1Anterior = IDTarget1 And Me.IDTarget2Anterior = IDTarget2 And _
        Me.FechaAudDesdeAnterior = Me.dtpFechaInicioAudiencia.Value And _
        Me.FechaAudHastaAnterior = Me.dtpFechaFinAudiencia.Value And _
        Me.DefAnterior = Me.txtDef.Text Then
            ret = True
        Else
            If Not ActualizarSpots() Then
                Mensajes.Mensaje("El Proceso de Actualización No Ha Sido Terminado. Los Datos del Sistema No Serán Guardados")
                ret = False
            End If
        End If

        If Me.FechaSisDesdeAnterior <> Me.dtpFechaInicioAudiencia.Value Or _
        Me.FechaSisHastaAnterior <> Me.dtpFechaFinAudiencia.Value Then
            Dim s As New Sistemas
            s.Id_campania = Activo.IDCampaña
            s.Id_sistema = Activo.IDSistema
            s.F_inicio = Me.dtpFechaInicio.Value
            s.F_fin = Me.dtpFechaFin.Value
            If Not s.VerificarSpotFueraRango() Then
                If Mensajes.Mensaje("Existen pases planificados en fechas que no pertenecen al nuevo " & Chr(13) & _
                                    "rango de fechas de sistema seleccionado. Desea borrarlos?", TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    If s.VerificarSpotECFueraRango Then
                        s.BorrarSpotFueraRango()
                    Else
                        Mensajes.Mensaje("Hay spots enviados a compras")
                        ret = False
                    End If
                Else
                    ret = False
                End If
            End If
        End If

        Return ret
    End Function

    Public Function ActualizarSpots() As Boolean

        If Not Guardo Then
            Mensajes.Mensaje("Hay cambios pendientes, debe guardar el ejercicio para poder actualizar los datos")
            Exit Function
        End If

        If Activo.IDMedio = 3 OrElse Activo.IDMedio = 4 OrElse Activo.IDMedio = 5 OrElse (Activo.IDMedio = 6 And Activo.IDTipoSoporte = 2) Then Return True

        Dim F As New frmActualizar(Activo.IDCampaña, Activo.IDSistema, IDTarget1, IDTarget2, Me.dtpFechaInicioAudiencia.Value, Me.dtpFechaFinAudiencia.Value, Val(Me.txtDef.Text.Replace(",", ".")))


        'AG CP ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If rgTipoSistema.SelectedIndex = 1 Then 'Si selecciona TipoSistema CostoPunto
        'F.CostoPunto = True
        'Else
        'F.CostoPunto = False
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        F.ShowDialog()

        If Not F.TerminoOK Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub Guardar() Implements IABM.Guardar
        Dim antGuardo As Boolean

        If Not Me.fraGeneral.Enabled Then
            Exit Sub
        End If

        If Not Me.CargarObjeto() Then
            Exit Sub
        End If

        If cboTarget1.Text = cboTarget2.Text Then
            Mensajes.Mensaje("No puede guardar dos targets iguales")
            Exit Sub
        End If

        If cboTipoSoporte.Value Is Nothing Or cboTipoSoporte.Value = 0 Then
            'AG 22/10/2013 DIGITAL ==================================
            If Me.CboMedio.Value <> 2 Then
                Mensajes.Mensaje("Debe elegir un tipo de soporte")
                Exit Sub
            End If
            '========================================================
            'Exit Sub
        End If

        antGuardo = Guardo ' lo guardo porque si me cancela la actualizacion, y no modifico ningun campo
        ' debe seguir con el mismo estado de guardo que traia
        Guardo = True

        '*** LLAMADA AL FORM ACTUALIZAR
        'AG 19/12/2013 Codigo Nuevo =============================
        If Me.CboMedio.Value = Medios.Internet Then
        Else
            If Me.Modificar AndAlso Not Me.EjecutarRecalculo Then
                Guardo = antGuardo
                Exit Sub
            End If
        End If
        '==========================================================
        'AG 19/12/2013 Codigo anterior =============================
        'If Me.Modificar AndAlso Not Me.EjecutarRecalculo Then
        '    Guardo = antGuardo
        '    Exit Sub
        'End If
        '===========================================================

        If Not Me.Modificar Then
            Try
                'inicia la transaccion
                S.IniciarTransaccion()
                'Asegura que se guarde el tipo soporte
                S.Id_tipo_soporte = Me.cboTipoSoporte.Value
                Dim IDSistema As Integer = S.Agregar()

                Activo.IDSistema = IDSistema

                Dim E As New Ejercicios

                E.Id_campania = Activo.IDCampaña
                E.Id_sistema = IDSistema

                'AG CP +++++++++++++++++++++++++++++
                If Me.CboMedio.Value = Medios.Tv Then
                    If Me.rgTipoSistema.SelectedIndex = 1 Then
                        E.Descripcion = "Ejercicio Costo Punto 1"
                    Else
                        E.Descripcion = "Ejercicio Estandar 1"
                    End If
                Else
                    E.Descripcion = "Ejercicio 1"
                End If
                '+++++++++++++++++++++++++++++++++

                E.F_alta = Date.Today
                E.U_alta = Activo.Login

                E.Agregar()

                'termina la transaccion
                S.TerminarTransaccion()

                'AG CP ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                Me.rgTipoSistema.SelectedIndex = 0
                Me.rgTipoSistema.Enabled = False  'Cuando guarda deshabilita la selección de TipoSistema
                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Catch ex As Exception
                S.AbortarTransaccion()

                Mensajes.Mensaje(ex.Message)

                Me.Modificar = False
            End Try
        Else
            'Asegura que se guarde el tipo soporte
            S.Id_tipo_soporte = Me.cboTipoSoporte.Value
            S.Modificar()
        End If

        CopiarDatosUltimos()

        Me.Modificar = True
        Me.DebeGuardar = False
    End Sub

    Public Sub LimpiarControles() Implements IABM.LimpiarControles
        Dim L As New LimpiarObjetoTexto(Me)

        L.LimpiarTextos()

        'AG 12/05/2016 ===============================================
        If Year(Activo.FechaFinCampaña) = Year(Date.Today) Then
            If Month(Activo.FechaFinCampaña) >= Month(Date.Today) Then
                Me.dtpFechaInicio.Value = DateSerial(Year(Date.Today), Month(Date.Today), 1)
                Me.dtpFechaFin.Value = DateSerial(Year(Date.Today), Month(Date.Today) + 1, 0)
            Else
                Me.dtpFechaInicio.Value = DateSerial(Year(Activo.FechaFinCampaña), Month(Activo.FechaFinCampaña), 1)
                Me.dtpFechaFin.Value = DateSerial(Year(Activo.FechaFinCampaña), Month(Activo.FechaFinCampaña) + 1, 0)
            End If
        End If

        'Me.dtpFechaInicio.Value = Activo.FechaInicioCampaña
        'Me.dtpFechaFin.Value = Activo.FechaFinCampaña
        '=============================================================

        CboMedio.Rows(0).Selected = True
        CboMedio.Rows(0).Selected = True
        cboTipoRating.Rows(0).Selected = True
        'cboDatePart.Rows(0).Selected = True
        Me.CboMedio.Enabled = True
        Me.cboTipoSoporte.Enabled = True

        Me.fraTarget.Enabled = True
        Me.fraAudiencia.Enabled = True
        Me.fraAudienciaRadio.Enabled = True
        Me.fraBrief.Enabled = True
        Me.fraGeneral.Enabled = True
        Me.fraObjetivos.Enabled = True
        Me.fraOtros.Enabled = True

        Me.chkFechaVigencia.Checked = False
        Me.dtpFechaVigor.Enabled = False
        Me.dtpFechaVigor.Value = Date.Today

        Me.txtDef.Text = 1

        If Activo.IDCampaña = Activo.UltimoSistema.idCampaña Then
            CargarDatosAnterior()
        End If

        Me.cboTipoSoporte_AfterCloseUp(Me, New System.EventArgs)
        Me.cboTipoSoporte.Select()
        Me.cboTarget1.Enabled = True
        Me.cboTarget2.Enabled = True
        If cboDatePart.Rows.Count > 0 Then
            Me.cboDatePart.Rows(0).Selected = True
            Me.cboDatePart.Rows(0).Activated = True
        End If

        'AG CP +++++++++++++++++++++++++++++++
        If Me.CboMedio.Value <> Medios.Tv Then
            Me.rgTipoSistema.Enabled = False
        Else
            Me.rgTipoSistema.Enabled = True
        End If
        '++++++++++++++++++++++++++++++++++++

        Me.DebeGuardar = True
    End Sub

    Private Sub CargarOlas()
        Dim Audiencia As New Audiencia_rd
        Dim Olas As DataTable

        Olas = Audiencia.ObtenerOlaAudiencia
        Me.CargarCombo(cboAudienciaRadio, Olas, "Id_Ola", "Descripcion", True)
    End Sub

    Private Sub CargarTargets() 'carga los TARGETS  
        If IsDBNull(CboMedio.Value) Then
            Exit Sub
        End If
        If IsDBNull(cboTipoSoporte.Value) Then
            Exit Sub
        End If

        Dim T As New Targets
        Dim TR As New Audiencia_rd
        Dim Dt As DataTable

        If CboMedio.Value <> MedioRadio Then
            Dt = T.TraerTodos(cboTipoSoporte.Value)
        Else
            Dt = TR.ObtenerTarget
        End If

        Me.CargarCombo(cboTarget1, Dt, "ID_TARGET", "DESCRIPCION")
        Me.CargarCombo(cboTarget2, Dt, "ID_TARGET", "DESCRIPCION", True)

        Me.cboTarget1.SelectedIndex = 0
        Me.cboTarget2.SelectedIndex = 0
    End Sub

    Private Sub abmSistemas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim GrillaFormato As New GrillaFormato

        'carga el Tipo Raiting
        Dim Dt As New DataTable

        Dt.Columns.Add("ID_TipoRating", GetType(String))
        Dt.Columns.Add("Descripción", GetType(String))

        Dim Programa() As Object = {"P", "Programa"}
        Dim Tanda() As Object = {"T", "Tanda"}
        Dim Franja() As Object = {"F", "Franja"}

        Dt.Rows.Add(Programa)
        Dt.Rows.Add(Tanda)
        Dt.Rows.Add(Franja)

        Me.cboTipoRating.DisplayMember = "Descripción"
        Me.cboTipoRating.ValueMember = "ID_TipoRating"

        Me.cboTipoRating.DataSource = Dt

        Listas.OcultarColumnas(cboTipoRating, "Id_TipoRating")
        Listas.OcultarHeader(cboTipoRating)

        Dim Medio As New Soportes
        Listas.CargarCombo(Me.CboMedio, Medio.ObtenerMediosActivos, "Id_Medio", "descripcion")

        Listas.OcultarColumnas(CboMedio, "Id_Medio")
        Listas.OcultarHeader(CboMedio)

        'day part
        Me.CargarFranjas()

        'carga la plaza
        Dim P As New Plazas

        Listas.CargarCombo(cboPlaza, P.TraerTodos, "id_plaza", "descripcion")

        Listas.OcultarHeader(cboPlaza)
        Listas.OcultarColumnas(cboPlaza, "id_plaza")
    End Sub

    Private Sub CargarTipoSoporte()
        'tipo soporte
        Dim TS As New Tipos_soporte
        Dim dtTS As DataTable
        If Not CboMedio.Value Is Nothing Then
            'el harcode del id_medio esta en el store
            TS.Id_medio = CboMedio.Value
            Activo.IDMedio = CboMedio.Value
            dtTS = TS.TraerTipoSoporte
            If Not dtTS Is Nothing AndAlso dtTS.Rows.Count > 0 Then
                Listas.CargarCombo(Me.cboTipoSoporte, dtTS, "Id_tipo_soporte", "descripcion")

                Listas.OcultarColumnas(cboTipoSoporte, "Id_Tipo_soporte", "id_medio")
                Listas.OcultarHeader(cboTipoSoporte)

                cboTipoSoporte.Enabled = True
                cboTipoSoporte.Rows(0).Selected = True
            Else
                cboTipoSoporte.DataSource = Nothing
                cboTipoSoporte.Enabled = False
            End If
        Else
            cboTipoSoporte.DataSource = Nothing
            cboTipoSoporte.Enabled = False
        End If
    End Sub

    Private Sub cboTipoSoporte_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoSoporte.AfterCloseUp
        'setea los valores cargados antes
        If IDTarget1 > 0 Then
            Me.cboTarget1.SelectedValue = IDTarget1
        End If

        If IDTarget2 > 0 Then
            Me.cboTarget2.SelectedValue = IDTarget2
        End If

        SetearPantalla(CboMedio.Value)

        'AG CP ++++++++++++++++++++++++++
        If Me.CboMedio.Value <> Medios.Tv Then
            Me.rgTipoSistema.Enabled = False
        End If
        '+++++++++++++++++++++++++++++++

        ArmarDescripcion()

        'los targets se cargan segun el tipo de soporte que este seleccionado
        CargarTargets()

        If Not CboMedio.Value Is Nothing AndAlso fraGeneral.Enabled Then
            If CboMedio.Value = MedioRadio Then
                If cboTipoSoporte.Value = 1 Then
                    fraAudienciaRadio.Enabled = True
                Else
                    fraAudienciaRadio.Enabled = False
                    cboPlaza.Enabled = True
                End If
                fraOtros.Enabled = False
                cboTarget2.Enabled = False
            Else
                fraOtros.Enabled = True
                fraAudienciaRadio.Enabled = True
            End If
        Else
            fraAudiencia.Enabled = False
            fraAudienciaRadio.Enabled = False
            fraOtros.Enabled = False
        End If

        If CboMedio.Value = 0 Then
            If cboTipoSoporte.Value = 2 Then
                Me.cboPlaza.Enabled = True
            Else
                Me.cboPlaza.Enabled = False
            End If
        End If

        'If CboMedio.Value = MedioRadio Then
        '    If cboTipoSoporte.Value = 2 Then
        '        Me.cboPlaza.Enabled = True
        '    Else
        '        Me.cboPlaza.Enabled = False
        '        Me.cboPlaza.Value = Activo.IDPlaza
        '    End If
        'End If

        'If Modificar = True Then
        '    Me.cboPlaza.Enabled = False
        'End If

    End Sub

    Private Sub SetearPantalla(ByVal Medio As Medios)
        'Select Case Medio
        ' Case Medios.Tv, Medios.Radio
        Select Case cboTipoSoporte.Value
            Case 1 'capital
                cboPlaza.Enabled = True
                cboTarget1.Enabled = True
                cboTarget2.Enabled = True
                fraAudiencia.Enabled = True
                fraAudienciaRadio.Enabled = True
                txtDef.Enabled = True

                cboTipoRating.Enabled = True
                cboTipoRating.Rows(2).Hidden = True
                If cboTipoSoporte.Enabled Then
                    cboTipoRating.Rows(1).Selected = True
                End If

                'AG CP +++++++++++++++++++++++++++++
                If Medio = Medios.Tv Then
                    If rgTipoSistema.SelectedIndex = 0 Then
                        cboTipoRating.Enabled = True
                        cboPlaza.Enabled = False
                    End If
                End If
                cboPlaza.Value = 1
                cboPlaza.Enabled = False
                '++++++++++++++++++++++++++++++++++

            Case 2 'interior
                cboPlaza.Enabled = True
                cboTarget1.Enabled = True
                cboTarget2.Enabled = True
                fraAudiencia.Enabled = True
                fraAudienciaRadio.Enabled = True
                txtDef.Enabled = True
                cboTipoRating.Rows(0).Selected = True
                cboTipoRating.Enabled = False
                cboPlaza.Enabled = True
                rgTipoSistema.SelectedIndex = 0

            Case 3 'cable

                cboPlaza.Enabled = True
                cboTarget1.Enabled = True
                cboTarget2.Enabled = True
                fraAudiencia.Enabled = True
                txtDef.Enabled = True
                cboTipoRating.Rows(2).Selected = True
                cboTipoRating.Enabled = False
                cboPlaza.Value = 1
                cboPlaza.Enabled = False
                rgTipoSistema.Enabled = False
                rgTipoSistema.SelectedIndex = 0
            Case 4 ' Satelital
                cboTipoRating.Rows(0).Selected = True
                cboTipoRating.Enabled = False
                cboPlaza.Value = 35 ' total pais
                cboPlaza.Enabled = False
                fraAudiencia.Enabled = False
                txtDef.Enabled = False
                rgTipoSistema.SelectedIndex = 0
                rgTipoSistema.Enabled = False
        End Select

        'AG CP ++++++++++++++++++++++++++++++++++
        If Modificar = True Then
            Me.rgTipoSistema.Enabled = False
            Dim siste As New Sistemas
            siste.Id_campania = Activo.IDCampaña
            siste.Id_sistema = Activo.IDSistema
            siste.BuscarPorID()
            Me.txtDescripcion.Text = siste.Descripcion
        End If

        If Modificar = False Then
            If Me.cboTipoSoporte.Value = 1 Then
                Me.rgTipoSistema.Enabled = True
            Else
                Me.rgTipoSistema.Enabled = False
            End If
        End If
        '+++++++++++++++++++++++++++++++++++++++


        '    Case Medios.Prensa, Medios.Tv, Medios.Exterior
        '' Select Case cboTipoSoporte.Value
        '    Case 1 'capital
        'cboPlaza.Enabled = True
        'cboTarget1.Enabled = True
        'cboTarget2.Enabled = True
        'fraAudiencia.Enabled = True
        'fraAudienciaRadio.Enabled = True
        'txtDef.Enabled = True

        'cboTipoRating.Enabled = True
        'cboTipoRating.Rows(2).Hidden = True
        'If cboTipoSoporte.Enabled Then
        '    cboTipoRating.Rows(1).Selected = True
        'End If

        'cboPlaza.Value = 1
        'cboPlaza.Enabled = False

        '    Case 2 'interior
        'cboPlaza.Enabled = True
        'cboTarget1.Enabled = True
        'cboTarget2.Enabled = True
        'fraAudiencia.Enabled = True
        'fraAudienciaRadio.Enabled = True
        'txtDef.Enabled = True

        'cboTipoRating.Rows(0).Selected = True
        'cboTipoRating.Enabled = False

        'cboPlaza.Enabled = True
        '    Case 3 'cable
        'cboPlaza.Enabled = True
        'cboTarget1.Enabled = True
        'cboTarget2.Enabled = True
        'fraAudiencia.Enabled = True
        'txtDef.Enabled = True

        'cboTipoRating.Rows(2).Selected = True
        'cboTipoRating.Enabled = False

        'cboPlaza.Value = 1
        'cboPlaza.Enabled = False
        '    Case 4 ' Satelital
        'cboTipoRating.Rows(0).Selected = True
        'cboTipoRating.Enabled = False

        'cboPlaza.Value = 35 ' total pais
        'cboPlaza.Enabled = False
        ''cboTarget1.Enabled = False
        '' cboTarget2.Enabled = False
        'fraAudiencia.Enabled = False
        'txtDef.Enabled = False
        'End Select
        'End Select

    End Sub

    Private Sub lblConsultarAudiencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConsultarAudiencia.Click
        If cboTarget1.Text = "" Then
            Exit Sub
        End If

        Dim F As New frmConsultarAudienciaFecha

        '*********** CUIDADO: HARCODEO DEL "ID MEDIO" EN 1
        F.IDTarget = DirectCast(cboTarget1.SelectedItem, ItemLista).ID
        F.IDTipoSoporte = cboTipoSoporte.Value
        F.Id_Plaza = cboPlaza.Value
        F.IDMedio = Activo.IDMedio

        F.ShowDialog()

        If Not F.FechaInicioAudiencia = Nothing And Not F.FechaFinAudiencia = Nothing Then
            Me.dtpFechaInicioAudiencia.Value = F.FechaInicioAudiencia
            Me.dtpFechaFinAudiencia.Value = F.FechaFinAudiencia
        End If
    End Sub

    Private Function ValidarFechasAudiencia(ByVal cboTarget As cboComboWindows) As Boolean
        'VALIDACION CON EL TARGET 1
        If cboTarget.Text = "" Then
            Return False
        End If

        'valida la fecha de fin
        Dim S As String = BuscarFecha(Me.dtpFechaInicioAudiencia.Value, Me.dtpFechaFinAudiencia.Value, cboTarget.SelectedValue)

        If S = "inicio" Then
            Mensajes.Mensaje("La Fecha de Inicio de la Audiencia No es Válida")
            Return False
        End If

        If S = "fin" Then
            Mensajes.Mensaje("La Fecha de Fin de la Audiencia No es Válida")
            Return False
        End If

        Return True
    End Function

    Private Function BuscarFecha(ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal IDTarget As Integer) As String
        Dim Dr As DataRow
        Dim EstaEnRango As Boolean = False
        Dim FechasAudiencia As DataTable

        'trae las fechas de audiencia que hay en la base para el soporte y el target
        Dim A As New Audiencias_fechas

        A.Id_tipo_soporte = cboTipoSoporte.Value
        A.Id_target = IDTarget

        FechasAudiencia = A.ObtenerFechasAudiencias

        If FechasAudiencia.Rows.Count = 0 Then
            Return ""
        End If

        'valida la fecha de inicio
        For Each Dr In FechasAudiencia.Rows
            If FechaInicio >= Dr("Fecha desde") And FechaInicio <= Dr("Fecha hasta") Then
                EstaEnRango = True
            End If
        Next

        If Not EstaEnRango Then
            Return "inicio"
        End If

        'valida la fecha de fin
        EstaEnRango = False

        For Each Dr In FechasAudiencia.Rows
            If FechaFin >= Dr("Fecha desde") And FechaFin <= Dr("Fecha hasta") Then
                EstaEnRango = True
            End If
        Next

        If Not EstaEnRango Then
            Return "fin"
        End If

        Return ""
    End Function

    Private Sub ArmarDescripcion()
        Select Case cboTipoSoporte.Value
            Case 1, 3, 4 'capital y cable
                txtDescripcion.Text = cboTipoSoporte.Text.ToUpper
            Case 2 'interior
                txtDescripcion.Text = cboTipoSoporte.Text & " " & cboPlaza.Text
        End Select
    End Sub

    Private Sub cboPlaza_AfterCloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlaza.AfterCloseUp
        ArmarDescripcion()
    End Sub

    Public Sub Cancelar() Implements IABM.Cancelar
        Me.fraTarget.Enabled = False
        Me.fraAudiencia.Enabled = False
        Me.fraAudienciaRadio.Enabled = False
        Me.fraBrief.Enabled = False
        Me.fraGeneral.Enabled = False
        Me.fraObjetivos.Enabled = False
        Me.fraOtros.Enabled = False
    End Sub

    Private Sub fraGeneral_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraGeneral.EnabledChanged
        If fraGeneral.Enabled Then
            txtDescripcion.BackColor = SystemColors.Window
        Else
            txtDescripcion.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        DebeGuardar = True
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicio.ValueChanged
        DebeGuardar = True
    End Sub

    Private Sub dtpFechaFin_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaFin.ValueChanged
        DebeGuardar = True
    End Sub
    Private Sub chkFechaVigencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaVigencia.CheckedChanged
        If Me.chkFechaVigencia.Checked Then
            Me.dtpFechaVigor.Enabled = True
        Else
            Me.dtpFechaVigor.Enabled = False
        End If
    End Sub

    Public Shared Sub CargarCombo(ByVal Combo As cboComboWindows, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String, Optional ByVal AgregarFilaVacia As Boolean = False)
        Dim IL As ItemLista

        Combo.BeginUpdate()

        Combo.DisplayMember = "Descripcion"
        Combo.ValueMember = "ID"
        Combo.Items.Clear()

        If AgregarFilaVacia Then
            IL = New ItemLista

            IL.ID = -1
            IL.Descripcion = "--- NINGUNO ---"

            Combo.Items.Add(IL)
        End If

        For Each Dr As DataRow In Dt.Rows
            IL = New ItemLista

            IL.ID = Dr(CampoID)
            IL.Descripcion = Dr(CampoDescripcion)

            Combo.Items.Add(IL)
        Next

        Combo.EndUpdate()
    End Sub

    Private Sub CargarCombo(ByVal Combo As cboCombo, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String, Optional ByVal AgregarFilaVacia As Boolean = False)
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

        For Each Band As Infragistics.Win.UltraWinGrid.UltraGridBand In Combo.DisplayLayout.Bands
            Band.ColHeadersVisible = False
            For Each Column As Infragistics.Win.UltraWinGrid.UltraGridColumn In Band.Columns
                If Column.Key.ToLower <> CampoDescripcion.ToLower Then
                    Column.Hidden = True
                Else
                    Column.Width = Combo.Width
                End If
            Next
        Next

    End Sub

    Private Sub Combo_Position(ByVal pCombo As cboCombo, ByVal pColumnName As String, ByVal pValue As String, Optional ByVal pColumnName2 As String = "", Optional ByVal pValue2 As String = "")
        For Each Row As Infragistics.Win.UltraWinGrid.UltraGridRow In pCombo.Rows
            If Not Row.Cells(pColumnName).Value Is DBNull.Value Then
                If pColumnName = String.Empty Then
                    If Row.Cells(pColumnName).Value = pValue Then
                        pCombo.SelectedRow = Row
                        Exit Sub
                    End If
                Else
                    If Row.Cells(pColumnName).Value = pValue AndAlso Row.Cells(pColumnName2).Value = pValue2 Then
                        pCombo.SelectedRow = Row
                        Exit Sub
                    End If
                End If
            End If
        Next
        pCombo.SelectedRow = pCombo.Rows(0)
    End Sub

    Public Sub CambiaCero(ByRef S As String)
        If S = "" Then
            S = "0"
        End If
    End Sub

    Private Function ValidarFechas() As Boolean
        'fecha de inicio de sistema no puede ser menor a la fecha de inicio de campaña
        If dtpFechaInicio.Value < Activo.FechaInicioCampaña Then
            Mensajes.Mensaje("La Fecha de Inicio del Sistema No Puede ser Menor a la Fecha de Inicio de la Campaña")
            dtpFechaInicio.Select()
            Return False
        End If

        'fecha de inicio de sistema no puede ser mayor a la fecha de fin de campaña
        If dtpFechaInicio.Value > Activo.FechaFinCampaña Then
            Mensajes.Mensaje("La Fecha de Inicio del Sistema No Puede ser Mayor a la Fecha de Fin de la Campaña")
            dtpFechaInicio.Select()
            Return False
        End If

        'si la fecha de inicio es mayor a la fecha de fin
        If Me.dtpFechaInicio.Value > Me.dtpFechaFin.Value Then
            Mensajes.Mensaje("La Fecha de Fin No Puede ser Menor a la Fecha de Inicio")
            dtpFechaFin.Select()
            Return False
        End If

        If dtpFechaFin.Value < dtpFechaInicio.Value Then
            Mensajes.Mensaje("La Fecha de Fin No Puede ser Menor a la Fecha de Inicio")
            dtpFechaFin.Select()
            Return False
        End If

        'fecha de fin de sistema no puede ser mayor a la fecha de fin de campaña
        If dtpFechaFin.Value > Activo.FechaFinCampaña Then
            Mensajes.Mensaje("La Fecha de Fin del Sistema No Puede ser Mayor a la Fecha de Fin de la Campaña")
            dtpFechaFin.Select()
            Return False
        End If

        'si la fecha de inicio de audiencia es mayor a la fecha de fin
        If Me.dtpFechaInicioAudiencia.Value > Me.dtpFechaFinAudiencia.Value Then
            Mensajes.Mensaje("La Fecha de Inicio de la Audiencia No Puede ser Mayor a la Fecha de Fin de la Audiencia")
            dtpFechaInicioAudiencia.Select()
            Return False
        End If

        If Me.dtpFechaFinAudiencia.Value < Me.dtpFechaInicioAudiencia.Value Then
            Mensajes.Mensaje("La Fecha de Fin de la Audiencia No Puede ser Menor a la Fecha de Inicio de la Audiencia")
            dtpFechaFinAudiencia.Select()
            Return False
        End If

        Return True
    End Function

    Private Sub CargarDatosAnterior()
        With Me
            .cboTipoSoporte.Value = Activo.UltimoSistema.idTipoSoporte
            .cboTipoRating.Value = Activo.UltimoSistema.TipoRating
            .cboPlaza.Value = Activo.UltimoSistema.idPlaza
            .cboTarget1.SelectedItem = Activo.UltimoSistema.Target1
            .cboTarget2.SelectedItem = Activo.UltimoSistema.Target2
            .txtBRFBruto.Text = Format(Activo.UltimoSistema.Bruto, "##,##")
            .txtBRFNeto.Text = Format(Activo.UltimoSistema.Neto, "##,##")
            .txtDef.Text = Activo.UltimoSistema.Deflactacion
            .txtDescripcion.Text = Activo.UltimoSistema.Descripcion
            'AG 12/05/2016 ================================================
            '.dtpFechaFin.Value = Activo.UltimoSistema.FechaFin
            '.dtpFechaInicio.Value = Activo.UltimoSistema.FechaInicio
            '================================================================
            .cboDatePart.Value = Activo.UltimoSistema.idFranja
            If Activo.UltimoSistema.FechaInicioAud.Year > 1900 Then
                .dtpFechaInicioAudiencia.Value = Activo.UltimoSistema.FechaInicioAud
                .dtpFechaFinAudiencia.Value = Activo.UltimoSistema.FechaFinAud
            Else
                .dtpFechaInicioAudiencia.Value = Activo.FechaDesdeCampaña
                .dtpFechaFinAudiencia.Value = Activo.FechaFinCampaña
            End If
        End With
    End Sub

    Private Sub CopiarDatosUltimos()
        Dim i As ItemLista
        With Activo.UltimoSistema
            .idCampaña = Activo.IDCampaña
            .idPlaza = Activo.IDPlaza
            .Descripcion = Me.txtDescripcion.Text
            .FechaInicio = dtpFechaInicio.Value
            .FechaFin = dtpFechaFin.Value
            If Activo.IDMedio = 3 Or Activo.IDMedio = 4 Or Activo.IDMedio = 5 Then
                .FechaInicioAud = dtpFechaInicio.Value
                .FechaFinAud = Me.dtpFechaFin.Value
            Else
                .FechaFinAud = Me.dtpFechaFinAudiencia.Value
                .FechaInicioAud = Me.dtpFechaInicioAudiencia.Value
            End If

            Me.FechaAudHastaAnterior = Me.dtpFechaFinAudiencia.Value
            Me.FechaAudDesdeAnterior = Me.dtpFechaInicioAudiencia.Value
            .Neto = Me.txtBRFNeto.Text
            .Bruto = Me.txtBRFBruto.Text
            .FechaOpcional = Me.dtpFechaVigor.Value
            .Deflactacion = Me.txtDef.Text
            If Not cboTipoRating.SelectedRow Is Nothing Then
                .TipoRating = Me.cboTipoRating.SelectedRow.Cells("Id_TipoRating").Text
            End If
            If Not Me.cboDatePart.SelectedRow Is Nothing Then
                .idFranja = Me.cboDatePart.SelectedRow.Cells("id_franja").Text
            End If
            If Not Me.cboTipoSoporte.SelectedRow Is Nothing Then
                .idTipoSoporte = Me.cboTipoSoporte.SelectedRow.Cells("Id_tipo_soporte").Text
            End If

            i = DirectCast(Me.cboTarget1.SelectedItem, ItemLista)
            .Target1 = i
            i = DirectCast(Me.cboTarget2.SelectedItem, ItemLista)
            .Target2 = i
        End With
    End Sub
    Private Sub txtBRFNeto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBRFNeto.Leave
        txtBRFNeto.Text = Format(Val(txtBRFNeto.Text), "##,##")
    End Sub
    Private Sub txtBRFBruto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBRFBruto.Leave
        txtBRFBruto.Text = Format(Val(txtBRFBruto.Text), "##,##")
    End Sub

    Public Sub CargarFranjas()
        'day part
        Dim F As New Franjas
        Dim Dt As DataTable

        Me.cboDatePart.DisplayMember = "descripcion"
        Me.cboDatePart.ValueMember = "id_franja"

        Dt = F.ObtenerPorCliente(Activo.IDCliente)

        'si el cliente no tiene franjas, usa las franjas del cliente "0" CERO
        If Dt.Rows.Count = 0 Then
            Dt = F.ObtenerPorCliente(0)
        End If

        Me.cboDatePart.DataSource = Dt

        Listas.OcultarColumnas(cboDatePart, "id_franja", "h_desde", "h_hasta", "id_cliente")
        Listas.OcultarHeader(cboDatePart)
    End Sub

    Private Sub txtDef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDef.TextChanged
        DebeGuardar = True
    End Sub

    Private Sub dtpFechaFinAudiencia_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaFinAudiencia.ValueChanged
        Guardo = False
    End Sub

    Private Sub dtpFechaInicioAudiencia_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaInicioAudiencia.ValueChanged
        Guardo = False
    End Sub

    Private Sub cboTarget1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTarget1.TextChanged
        Guardo = False
    End Sub

    Private Sub cboTarget2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTarget2.TextChanged
        Guardo = False
    End Sub
    Private Sub cboTarget1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTarget1.SelectionChangeCommitted
        Guardo = False
    End Sub
    Private Sub cboTarget2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTarget2.SelectionChangeCommitted
        Guardo = False
    End Sub

    Private Sub fraOtros_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraOtros.Enter

    End Sub

    Private Sub fraTarget_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraTarget.Enter

    End Sub

    Private Sub CboMedio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.ValueChanged
        Call CargarTipoSoporte()
        Call cboTipoSoporte_AfterCloseUp(Nothing, Nothing)
        Select Case CboMedio.Value
            Case 1 'Televion
                lblTipoRating.Visible = True
                fraTarget.Visible = True
                cboTipoRating.Visible = True
                fraAudiencia.Visible = True
                fraAudienciaRadio.Visible = False
                fraOtros.Visible = True
                cboTarget2.Visible = True
                Me.Height = 596
                fraBrief.Top = 352
                fraObjetivos.Top = 410
                fraTarget.Visible = True
                fraTarget.Height = 72

                'AG 22/10/2013 ========================
                Me.Label21.Visible = True
                Me.cboTipoSoporte.Visible = True
                '=====================================

                'AG CP ++++++++++++++++++++++++
                Me.rgTipoSistema.SelectedIndex = 0
                Me.rgTipoSistema.Enabled = True
                '+++++++++++++++++++++++++++++

            Case 6 'Radio
                lblTipoRating.Visible = False
                cboTipoRating.Visible = False
                If cboAudienciaRadio.DataSource Is Nothing Then
                    Call CargarOlas()
                End If
                fraAudiencia.Visible = False
                fraAudienciaRadio.Visible = True
                fraTarget.Visible = True
                cboTarget2.Enabled = False
                fraOtros.Visible = True
                Me.Height = 596
                fraBrief.Top = 352
                fraObjetivos.Top = 410
                'AG 22/10/2013 ========================
                Me.Label21.Visible = True
                Me.cboTipoSoporte.Visible = True
                '=====================================

                Me.cboPlaza.Enabled = True
                'AG CP ++++++++++++++++++++++++
                Me.rgTipoSistema.SelectedIndex = 0
                Me.rgTipoSistema.Enabled = False
                If Me.cboTipoSoporte.Value = 2 Then
                    cboPlaza.Enabled = True
                Else
                    cboPlaza.Enabled = False
                End If
                '+++++++++++++++++++++++++++++
            Case 3, 4, 5, 7 ' Exterior, Prensa, Revista, AG Produccion
                lblTipoRating.Visible = False
                cboTipoRating.Visible = False
                fraAudiencia.Visible = False
                fraAudienciaRadio.Visible = False
                fraBrief.Visible = True
                fraOtros.Visible = False
                fraBrief.Top = 152
                fraObjetivos.Top = 200
                Me.Height = 388
                fraTarget.Visible = True
                fraTarget.Height = 44

                'AG 22/10/2013 ========================
                Me.Label21.Visible = True
                Me.cboTipoSoporte.Visible = True
                '=====================================

                'AG CP ++++++++++++++++++++++++
                Me.rgTipoSistema.SelectedIndex = 0

                Me.rgTipoSistema.Enabled = False
                If CboMedio.Value = 5 Then
                    Me.cboPlaza.Value = 1
                    Me.cboPlaza.Enabled = False
                End If
                '+++++++++++++++++++++++++++++

            Case 2
                'AG 22/10/2013 DIGITAL =========================
                If Me.CboMedio.Value = 2 Then
                    Me.Label21.Visible = False
                    Me.cboTipoSoporte.Visible = False
                End If

                lblTipoRating.Visible = False
                cboTipoRating.Visible = False
                fraAudiencia.Visible = False
                fraAudienciaRadio.Visible = False
                fraBrief.Visible = True
                fraOtros.Visible = False
                fraBrief.Top = 152
                fraObjetivos.Top = 200
                Me.Height = 388
                fraTarget.Visible = True
                fraTarget.Height = 44
                '===============================================

        End Select
    End Sub

    Private Sub cboAudienciaRadio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAudienciaRadio.ValueChanged
        If Not CboMedio.Value Is Nothing AndAlso CboMedio.Value = MedioRadio Then
            If Not cboAudienciaRadio.SelectedRow Is Nothing AndAlso Not cboAudienciaRadio.Value Is Nothing Then
                Me.dtpFechaInicioAudiencia.Value = cboAudienciaRadio.SelectedRow.Cells(1).Value
                Me.dtpFechaFinAudiencia.Value = cboAudienciaRadio.SelectedRow.Cells(2).Value
            End If
        End If
    End Sub

    Private Sub fraObjetivos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraObjetivos.Enter

    End Sub

    Private Sub cboTipoSoporte_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboTipoSoporte.InitializeLayout

    End Sub

    Private Sub CboMedio_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles CboMedio.InitializeLayout

    End Sub

    Private Sub fraBrief_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraBrief.Enter

    End Sub

    Private Sub fraAudiencia_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraAudiencia.Enter

    End Sub

    Private Sub fraGeneral_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraGeneral.Enter

    End Sub

    Private Sub rgTipoSistema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipoSistema.SelectedIndexChanged
        'AG CP ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If rgTipoSistema.SelectedIndex = 1 Then 'Si selecciona TipoSistema CostoPunto
            Me.CboMedio.Rows(6).Selected = True ' Seteo el medio TELEVISION
            cboTipoSoporte.Rows(0).Selected = True
            cboTipoSoporte.Enabled = False
            cboTipoRating.Rows(1).Selected = True
            txtDescripcion.Text = cboTipoSoporte.Text & " - C.P"
            'cboTipoRating.SelectedRow = cboTipoRating.Rows(0)
            cboTipoRating.Enabled = False
            cboPlaza.Value = 1
            'Me.cboPlaza.Rows(1).Selected = True
            Me.cboPlaza.Enabled = False
            'Me.cboTarget2.Enabled = True
            'cboTipoSoporte.Enabled = False
        Else
            cboTipoRating.Enabled = True
            txtDescripcion.Text = cboTipoSoporte.Text
            cboTipoSoporte.Enabled = True
            cboTipoSoporte.Rows(0).Selected = True
            If cboTipoSoporte.Value = 2 Then
                Me.cboPlaza.Enabled = True
            Else
                Me.cboPlaza.Enabled = False
            End If
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    End Sub
End Class
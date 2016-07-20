Public Class frmAltaTarifa
    Inherits System.Windows.Forms.Form

    Private Const MedioRadio As Integer = 6
    Dim tarifa As Tarifas_tv
    Public Cancelar As Boolean
    Private mTipoSoporte As TipoAudiencia
    Public IdCliente As Integer
    Public idSoporte As Integer
    Public DesCliente As String
    Public DesSoporte As String
    Public DescTelereport As String
    Public IdTelereport As Int16
    Public Property TipoSoporte() As TipoAudiencia
        Get
            Return mTipoSoporte
        End Get
        Set(ByVal Value As TipoAudiencia)
            mTipoSoporte = Value
        End Set
    End Property

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id_soporte As System.Windows.Forms.Label
    Friend WithEvents id_cliente As System.Windows.Forms.Label
    Friend WithEvents ChkEvento As QUETOOL.chkCheck
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents txtSoporte As QUETOOL.txtTexto
    Friend WithEvents txtPrograma As QUETOOL.txtTexto
    Friend WithEvents TxtHInicio As QUETOOL.txtTexto
    Friend WithEvents TxtHFin As QUETOOL.txtTexto
    Friend WithEvents ChkLunes As QUETOOL.chkCheck
    Friend WithEvents ChkMartes As QUETOOL.chkCheck
    Friend WithEvents ChkMiercoles As QUETOOL.chkCheck
    Friend WithEvents ChkJueves As QUETOOL.chkCheck
    Friend WithEvents ChkViernes As QUETOOL.chkCheck
    Friend WithEvents ChkSabado As QUETOOL.chkCheck
    Friend WithEvents ChkDomingo As QUETOOL.chkCheck
    Friend WithEvents DtpFInicio As QUETOOL.dtpFecha
    Friend WithEvents DtpFFin As QUETOOL.dtpFecha
    Friend WithEvents TxtTarifa As QUETOOL.txtTexto
    Friend WithEvents ChkLunesViernes As QUETOOL.chkCheck
    Friend WithEvents txtIDPrograma As QUETOOL.txtTexto
    Friend WithEvents id_tarifa_tv As System.Windows.Forms.Label
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents txtTelereport As QUETOOL.txtTexto
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAltaTarifa))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ChkEvento = New QUETOOL.chkCheck
        Me.txtCliente = New QUETOOL.txtTexto
        Me.txtSoporte = New QUETOOL.txtTexto
        Me.txtPrograma = New QUETOOL.txtTexto
        Me.TxtHInicio = New QUETOOL.txtTexto
        Me.TxtHFin = New QUETOOL.txtTexto
        Me.ChkLunesViernes = New QUETOOL.chkCheck
        Me.ChkLunes = New QUETOOL.chkCheck
        Me.ChkMartes = New QUETOOL.chkCheck
        Me.ChkMiercoles = New QUETOOL.chkCheck
        Me.ChkJueves = New QUETOOL.chkCheck
        Me.ChkViernes = New QUETOOL.chkCheck
        Me.ChkSabado = New QUETOOL.chkCheck
        Me.ChkDomingo = New QUETOOL.chkCheck
        Me.DtpFInicio = New QUETOOL.dtpFecha
        Me.DtpFFin = New QUETOOL.dtpFecha
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtTarifa = New QUETOOL.txtTexto
        Me.Label6 = New System.Windows.Forms.Label
        Me.id_soporte = New System.Windows.Forms.Label
        Me.id_cliente = New System.Windows.Forms.Label
        Me.txtIDPrograma = New QUETOOL.txtTexto
        Me.id_tarifa_tv = New System.Windows.Forms.Label
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.txtTelereport = New QUETOOL.txtTexto
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Soporte:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(384, 330)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 19
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmdAceptar.Location = New System.Drawing.Point(24, 330)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 18
        Me.cmdAceptar.Text = "Agregar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre Programa:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hora Inicio:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(232, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hora Fin:"
        '
        'ChkEvento
        '
        Me.ChkEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkEvento.Location = New System.Drawing.Point(280, 288)
        Me.ChkEvento.Name = "ChkEvento"
        Me.ChkEvento.TabIndex = 17
        Me.ChkEvento.Text = "Evento especial"
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(120, 16)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(256, 20)
        Me.txtCliente.SoloLetra = False
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 11
        Me.txtCliente.TabStop = False
        Me.txtCliente.Text = ""
        '
        'txtSoporte
        '
        Me.txtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSoporte.ConDecimal = False
        Me.txtSoporte.Location = New System.Drawing.Point(120, 40)
        Me.txtSoporte.Maximo = 0
        Me.txtSoporte.Name = "txtSoporte"
        Me.txtSoporte.ReadOnly = True
        Me.txtSoporte.Size = New System.Drawing.Size(256, 20)
        Me.txtSoporte.SoloLetra = False
        Me.txtSoporte.SoloNumero = False
        Me.txtSoporte.TabIndex = 12
        Me.txtSoporte.TabStop = False
        Me.txtSoporte.Text = ""
        '
        'txtPrograma
        '
        Me.txtPrograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrograma.ConDecimal = False
        Me.txtPrograma.Location = New System.Drawing.Point(120, 64)
        Me.txtPrograma.Maximo = 0
        Me.txtPrograma.MaxLength = 60
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.Size = New System.Drawing.Size(256, 20)
        Me.txtPrograma.SoloLetra = False
        Me.txtPrograma.SoloNumero = False
        Me.txtPrograma.TabIndex = 0
        Me.txtPrograma.Text = ""
        '
        'TxtHInicio
        '
        Me.TxtHInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHInicio.ConDecimal = False
        Me.TxtHInicio.Location = New System.Drawing.Point(120, 112)
        Me.TxtHInicio.Maximo = 0
        Me.TxtHInicio.MaxLength = 5
        Me.TxtHInicio.Name = "TxtHInicio"
        Me.TxtHInicio.Size = New System.Drawing.Size(81, 20)
        Me.TxtHInicio.SoloLetra = False
        Me.TxtHInicio.SoloNumero = False
        Me.TxtHInicio.TabIndex = 2
        Me.TxtHInicio.Text = ""
        '
        'TxtHFin
        '
        Me.TxtHFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHFin.ConDecimal = False
        Me.TxtHFin.Location = New System.Drawing.Point(296, 112)
        Me.TxtHFin.Maximo = 0
        Me.TxtHFin.MaxLength = 5
        Me.TxtHFin.Name = "TxtHFin"
        Me.TxtHFin.Size = New System.Drawing.Size(80, 20)
        Me.TxtHFin.SoloLetra = False
        Me.TxtHFin.SoloNumero = False
        Me.TxtHFin.TabIndex = 3
        Me.TxtHFin.Text = ""
        '
        'ChkLunesViernes
        '
        Me.ChkLunesViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLunesViernes.Location = New System.Drawing.Point(12, 17)
        Me.ChkLunesViernes.Name = "ChkLunesViernes"
        Me.ChkLunesViernes.TabIndex = 5
        Me.ChkLunesViernes.Text = "Lunes-Viernes"
        '
        'ChkLunes
        '
        Me.ChkLunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLunes.Location = New System.Drawing.Point(12, 44)
        Me.ChkLunes.Name = "ChkLunes"
        Me.ChkLunes.Size = New System.Drawing.Size(54, 24)
        Me.ChkLunes.TabIndex = 6
        Me.ChkLunes.Text = "Lunes"
        '
        'ChkMartes
        '
        Me.ChkMartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkMartes.Location = New System.Drawing.Point(64, 44)
        Me.ChkMartes.Name = "ChkMartes"
        Me.ChkMartes.Size = New System.Drawing.Size(57, 24)
        Me.ChkMartes.TabIndex = 7
        Me.ChkMartes.Text = "Martes"
        '
        'ChkMiercoles
        '
        Me.ChkMiercoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkMiercoles.Location = New System.Drawing.Point(121, 44)
        Me.ChkMiercoles.Name = "ChkMiercoles"
        Me.ChkMiercoles.Size = New System.Drawing.Size(70, 24)
        Me.ChkMiercoles.TabIndex = 8
        Me.ChkMiercoles.Text = "Miércoles"
        '
        'ChkJueves
        '
        Me.ChkJueves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkJueves.Location = New System.Drawing.Point(193, 44)
        Me.ChkJueves.Name = "ChkJueves"
        Me.ChkJueves.Size = New System.Drawing.Size(58, 24)
        Me.ChkJueves.TabIndex = 9
        Me.ChkJueves.Text = "Jueves"
        '
        'ChkViernes
        '
        Me.ChkViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkViernes.Location = New System.Drawing.Point(253, 44)
        Me.ChkViernes.Name = "ChkViernes"
        Me.ChkViernes.Size = New System.Drawing.Size(61, 24)
        Me.ChkViernes.TabIndex = 10
        Me.ChkViernes.Text = "Viernes"
        '
        'ChkSabado
        '
        Me.ChkSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSabado.Location = New System.Drawing.Point(312, 44)
        Me.ChkSabado.Name = "ChkSabado"
        Me.ChkSabado.Size = New System.Drawing.Size(61, 24)
        Me.ChkSabado.TabIndex = 11
        Me.ChkSabado.Text = "Sábado"
        '
        'ChkDomingo
        '
        Me.ChkDomingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkDomingo.Location = New System.Drawing.Point(372, 44)
        Me.ChkDomingo.Name = "ChkDomingo"
        Me.ChkDomingo.Size = New System.Drawing.Size(66, 24)
        Me.ChkDomingo.TabIndex = 12
        Me.ChkDomingo.Text = "Domingo"
        '
        'DtpFInicio
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.DtpFInicio.Appearance = Appearance1
        Me.DtpFInicio.FlatMode = True
        Me.DtpFInicio.Location = New System.Drawing.Point(104, 24)
        Me.DtpFInicio.Name = "DtpFInicio"
        Me.DtpFInicio.Size = New System.Drawing.Size(98, 21)
        Me.DtpFInicio.TabIndex = 14
        '
        'DtpFFin
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.DtpFFin.Appearance = Appearance2
        Me.DtpFFin.FlatMode = True
        Me.DtpFFin.Location = New System.Drawing.Point(272, 24)
        Me.DtpFFin.Name = "DtpFFin"
        Me.DtpFFin.Size = New System.Drawing.Size(96, 21)
        Me.DtpFFin.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(56, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Inicio:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(236, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 14)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Fin:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DtpFInicio)
        Me.GroupBox2.Controls.Add(Me.DtpFFin)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 60)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha de Vigencia"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.Location = New System.Drawing.Point(380, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkDomingo)
        Me.GroupBox1.Controls.Add(Me.ChkSabado)
        Me.GroupBox1.Controls.Add(Me.ChkViernes)
        Me.GroupBox1.Controls.Add(Me.ChkJueves)
        Me.GroupBox1.Controls.Add(Me.ChkMiercoles)
        Me.GroupBox1.Controls.Add(Me.ChkLunesViernes)
        Me.GroupBox1.Controls.Add(Me.ChkMartes)
        Me.GroupBox1.Controls.Add(Me.ChkLunes)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 76)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Día de la semana"
        '
        'TxtTarifa
        '
        Me.TxtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTarifa.ConDecimal = True
        Me.TxtTarifa.Location = New System.Drawing.Point(124, 292)
        Me.TxtTarifa.Maximo = 0
        Me.TxtTarifa.MaxLength = 15
        Me.TxtTarifa.Name = "TxtTarifa"
        Me.TxtTarifa.Size = New System.Drawing.Size(96, 20)
        Me.TxtTarifa.SoloLetra = False
        Me.TxtTarifa.SoloNumero = False
        Me.TxtTarifa.TabIndex = 16
        Me.TxtTarifa.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(48, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Tarifa Bruta"
        '
        'id_soporte
        '
        Me.id_soporte.Location = New System.Drawing.Point(384, 39)
        Me.id_soporte.Name = "id_soporte"
        Me.id_soporte.TabIndex = 35
        Me.id_soporte.Text = "id_soporte"
        '
        'id_cliente
        '
        Me.id_cliente.Location = New System.Drawing.Point(384, 16)
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.TabIndex = 34
        Me.id_cliente.Text = "id_cliente"
        '
        'txtIDPrograma
        '
        Me.txtIDPrograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDPrograma.ConDecimal = False
        Me.txtIDPrograma.Location = New System.Drawing.Point(412, 64)
        Me.txtIDPrograma.Maximo = 0
        Me.txtIDPrograma.MaxLength = 60
        Me.txtIDPrograma.Name = "txtIDPrograma"
        Me.txtIDPrograma.Size = New System.Drawing.Size(52, 20)
        Me.txtIDPrograma.SoloLetra = False
        Me.txtIDPrograma.SoloNumero = False
        Me.txtIDPrograma.TabIndex = 36
        Me.txtIDPrograma.Text = ""
        Me.txtIDPrograma.Visible = False
        '
        'id_tarifa_tv
        '
        Me.id_tarifa_tv.Location = New System.Drawing.Point(24, 4)
        Me.id_tarifa_tv.Name = "id_tarifa_tv"
        Me.id_tarifa_tv.Size = New System.Drawing.Size(72, 16)
        Me.id_tarifa_tv.TabIndex = 37
        Me.id_tarifa_tv.Text = "id_tarifa_tv"
        Me.id_tarifa_tv.Visible = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmdModificar.Location = New System.Drawing.Point(44, 330)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.TabIndex = 38
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.Visible = False
        '
        'txtTelereport
        '
        Me.txtTelereport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelereport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelereport.ConDecimal = False
        Me.txtTelereport.Location = New System.Drawing.Point(120, 88)
        Me.txtTelereport.Maximo = 0
        Me.txtTelereport.MaxLength = 60
        Me.txtTelereport.Name = "txtTelereport"
        Me.txtTelereport.Size = New System.Drawing.Size(256, 20)
        Me.txtTelereport.SoloLetra = False
        Me.txtTelereport.SoloNumero = False
        Me.txtTelereport.TabIndex = 39
        Me.txtTelereport.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(24, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 19)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Telereport:"
        '
        'frmAltaTarifa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(472, 364)
        Me.Controls.Add(Me.txtTelereport)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.id_tarifa_tv)
        Me.Controls.Add(Me.txtIDPrograma)
        Me.Controls.Add(Me.TxtTarifa)
        Me.Controls.Add(Me.TxtHFin)
        Me.Controls.Add(Me.TxtHInicio)
        Me.Controls.Add(Me.txtPrograma)
        Me.Controls.Add(Me.txtSoporte)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.id_soporte)
        Me.Controls.Add(Me.id_cliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ChkEvento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAltaTarifa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Tarifa"
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Function devolverhora(ByVal s As String) As Integer
        ' devuelve la hora dado un string en formato hh:mm
        Dim i As Integer

        i = CInt(s.Split(":").GetValue(0))
        Return i

    End Function

    Private Function devolverminutos(ByVal s As String) As Integer
        ' devuelve los minutos dado un string en formato hh:mm
        Dim i As Integer

        i = CInt(s.Split(":").GetValue(1))
        Return i
    End Function
    Private Function FormularioOK() As Boolean

        Dim hora1, minuto1 As Integer
        Dim hora2, minuto2 As Integer

        Dim hora1Aux As Integer
        Dim hora2Aux As Integer


        If txtPrograma.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el nombre del programa")
            txtPrograma.Focus()
            Return False

        End If

        If Not (ChkLunes.Checked Or ChkMartes.Checked Or ChkMiercoles.Checked Or ChkJueves.Checked Or ChkViernes.Checked Or ChkSabado.Checked Or ChkDomingo.Checked) Then
            Mensajes.Mensaje("Debe seleccionar al menos 1 día de la semana")
            ChkLunesViernes.Focus()
            Return False

        End If

        If DtpFFin.Value < DtpFInicio.Value Then
            Mensajes.Mensaje("Fecha de inicio de vigencia no puede ser posterior a la de fin")
            DtpFFin.Focus()
            Return False

        End If

        If TxtHInicio.Text = "" Then
            Mensajes.Mensaje("Debe ingresar la hora de inicio del programa")
            TxtHInicio.Focus()
            Return False
        End If

        If TxtHFin.Text = "" Then
            Mensajes.Mensaje("Debe ingresar la hora de fin del programa")
            TxtHFin.Focus()
            Return False
        End If

        hora1 = devolverhora(TxtHInicio.Text)
        minuto1 = devolverminutos(TxtHInicio.Text)
        hora2 = devolverhora(TxtHFin.Text)
        minuto2 = devolverminutos(TxtHFin.Text)

        If Activo.IDMedio <> MedioRadio Then
            If hora1 < 6 Or hora1 > 29 Then
                Mensajes.Mensaje("La hora de inicio debe estar entre las 6:00 y las 29:59")
                TxtHInicio.Focus()
                Return False
            End If

            If minuto1 < 0 Or minuto1 > 59 Then
                Mensajes.Mensaje("Los minutos de la hora de inicio deben ser un valor entre 0 y 59")
                TxtHInicio.Focus()
                Return False
            End If

            If hora2 < 6 Or hora2 > 29 Then
                Mensajes.Mensaje("La hora de fin debe estar entre las 6:00 y las 29:59")
                TxtHInicio.Focus()
                Return False
            End If

            If minuto2 < 0 Or minuto2 > 59 Then
                Mensajes.Mensaje("Los minutos de la hora de fin deben ser un valor entre 0 y 59")
                TxtHFin.Focus()
                Return False
            End If

            If (hora1 > hora2) OrElse (hora1 = hora2 AndAlso minuto1 > minuto2) Then
                Mensajes.Mensaje("La hora de inicio de programa no puede ser posterior a la de fin")
                TxtHInicio.Focus()
                Return False
            End If
        Else
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
                Mensajes.Mensaje("La hora de inicio debe estar entre las 28:00 y las 27:59")
                TxtHInicio.Focus()
                Return False
            End If

            If minuto1 < 0 Or minuto1 > 59 Then
                Mensajes.Mensaje("Los minutos de la hora de inicio deben ser un valor entre 0 y 59")
                TxtHInicio.Focus()
                Return False
            End If

            If hora2 < 6 Or hora2 > 29 Then
                Mensajes.Mensaje("La hora de fin debe estar entre las 28:00 y las 27:59")
                TxtHInicio.Focus()
                Return False
            End If

            If minuto2 < 0 Or minuto2 > 59 Then
                Mensajes.Mensaje("Los minutos de la hora de fin deben ser un valor entre 0 y 59")
                TxtHFin.Focus()
                Return False
            End If

            If (hora1Aux > hora2Aux) OrElse (hora1Aux = hora2Aux AndAlso minuto1 > minuto2) Then
                Mensajes.Mensaje("La hora de inicio de programa no puede ser posterior a la de fin")
                TxtHInicio.Focus()
                Return False
            End If
        End If


        If TxtTarifa.Text = "" Then
            Mensajes.Mensaje("Debe ingresar una tarifa")
            TxtTarifa.Focus()
            Return False
            'Else
            '    If TxtTarifa.Text.Replace(".", ",") = 0 Then
            '        Mensajes.Mensaje("Debe ingresar una tarifa válida")
            '        TxtTarifa.Focus()
            '        Return False
            '    End If
        End If
        If Me.ChkEvento.Checked Then
            If Me.DtpFInicio.Value <> Me.DtpFFin.Value Then
                Mensajes.Mensaje("Los Programas marcados como Evento Especial, Deben Tener la Misma Fecha de Inicio y Fin", TipoMensaje.Informacion)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim t As New Tarifas_tv

        If FormularioOK() Then


            t.Id_tarifa_tv = 1 ' el sequence lo hace en el insert 


            t.Id_medio = Activo.IDMedio
            t.Id_soporte = Me.id_soporte.Text
            t.Id_cliente = Me.id_cliente.Text
            t.Programa = Me.txtPrograma.Text

            If Me.ChkLunes.Checked Then
                t.D_l = "X"
            End If
            If Me.ChkMartes.Checked Then
                t.D_m = "X"
            End If
            If Me.ChkMiercoles.Checked Then
                t.D_x = "X"
            End If
            If Me.ChkJueves.Checked Then
                t.D_j = "X"
            End If
            If Me.ChkViernes.Checked Then
                t.D_v = "X"
            End If
            If Me.ChkSabado.Checked Then
                t.D_s = "X"
            End If
            If Me.ChkDomingo.Checked Then
                t.D_d = "X"
            End If

            t.H_desde = devolverhora(TxtHInicio.Text)
            t.M_desde = devolverminutos(TxtHInicio.Text)
            t.H_hasta = devolverhora(TxtHFin.Text)
            t.M_hasta = devolverminutos(TxtHFin.Text)
            t.F_inicio_vig = Me.DtpFInicio.DateTime.Date
            t.F_fin_vig = Me.DtpFFin.DateTime.Date
            If Me.ChkEvento.Checked Then
                t.Ind_especial = 1
            Else
                t.Ind_especial = 0
            End If
            If Me.txtIDPrograma.Text <> "" Then
                t.Id_programa = CLng(Me.txtIDPrograma.Text)
            Else
                t.Id_programa = CLng(0)
            End If
            t.Bruto = Me.TxtTarifa.Text


            If t.Existe() Then
                Mensajes.Mensaje("Ya existe una tarifa cargada para ese horario, dia o vigencia")
            Else
                ' inserta
                Try
                    t.Agregar()

                    inicializarComponentes()
                    Me.txtPrograma.Focus()
                Catch ex As Oracle.DataAccess.Client.OracleException
                    Mensajes.Mensaje("Error al intentar guardar los datos")

                End Try

            End If

        End If

    End Sub



    Public Sub inicializarComponentes()
        Dim findeanio As New Date(Now.Date.Year, 12, 31)
        Tamaño()
        With Me
            .txtPrograma.Text = ""
            .TxtTarifa.Text = ""
            .ChkLunesViernes.Checked = False
            .ChkDomingo.Checked = False
            .ChkLunes.Checked = False
            .ChkMartes.Checked = False
            .ChkMiercoles.Checked = False
            .ChkJueves.Checked = False
            .ChkViernes.Checked = False
            .ChkSabado.Checked = False
            .DtpFFin.DateTime = findeanio

            .DtpFInicio.DateTime = Now.Date
            .ChkEvento.Checked = False
            .txtIDPrograma.Text = ""
            .TxtHFin.Text = ""
            .TxtHInicio.Text = ""

        End With
    End Sub
    Public Sub pasa_tarifa_Tv(ByVal tt As Tarifas_tv)
        tarifa = tt
    End Sub

    Public Sub ocultar_agregar()
        ' esta subrutina oculta el boton de agregar y muestra el boton de actualizar que esta
        ' en el mismo sitio pero que tiene otra funcionalidad
        cmdAceptar.Visible = False
        cmdModificar.Visible = True

    End Sub
    Private Sub frmAltaTarifa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cancelar = False

    End Sub
    Private Sub Tamaño()
        If Me.TipoSoporte = TipoAudiencia.Abierta Then
            Me.Height = 388
            Me.cmdAceptar.Top = 330
            Me.cmdCancelar.Top = 330
            Me.cmdModificar.Top = 330
            Me.ChkEvento.Top = 292
            Me.TxtTarifa.Top = 292
            Me.Label6.Top = 292
            Me.Label4.Top = 112
            Me.Label5.Top = 112
            Me.TxtHFin.Top = 112
            Me.TxtHInicio.Top = 112
            Me.GroupBox1.Top = 140
            Me.GroupBox2.Top = 220
            Me.Label10.Visible = True
            Me.txtTelereport.Visible = True
        Else
            Me.Height = 366
            Me.cmdAceptar.Top = 308
            Me.cmdCancelar.Top = 308
            Me.cmdModificar.Top = 308
            Me.ChkEvento.Top = 272
            Me.TxtTarifa.Top = 272
            Me.Label6.Top = 272
            Me.GroupBox2.Top = 200
            Me.GroupBox1.Top = 116
            Me.Label4.Top = 88
            Me.Label5.Top = 88
            Me.TxtHFin.Top = 88
            Me.TxtHInicio.Top = 88
            Me.Label10.Visible = False
            Me.txtTelereport.Visible = False
        End If
    End Sub

    Private Sub ChkCheck2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLunesViernes.CheckedChanged
        If Me.ChkLunesViernes.Checked Then
            Me.ChkLunes.Checked = True
            Me.ChkMartes.Checked = True
            Me.ChkMiercoles.Checked = True
            Me.ChkJueves.Checked = True
            Me.ChkViernes.Checked = True
        Else
            Me.ChkLunes.Checked = False
            Me.ChkMartes.Checked = False
            Me.ChkMiercoles.Checked = False
            Me.ChkJueves.Checked = False
            Me.ChkViernes.Checked = False
        End If
    End Sub
    Public Sub CargarFormulario(ByVal IdTarifa As Integer, ByVal EstaModificando As Boolean)

        Dim tt As New Tarifas_tv
        Dim indice As Integer
        Dim id_Tarifa As Int64
        Call Tamaño()
        'indice = UltraGrid1.ActiveRow.Index
        id_Tarifa = IdTarifa ' UltraGrid1.Rows(indice).Cells(0).Value()
        tt.Id_tarifa_tv = id_Tarifa
        tt.BuscarPorID()

        ' Dim f As New frmAltaTarifa

        If EstaModificando Then
            Me.Text = "Modificar tarifa"
            Me.id_cliente.Text = IdCliente
            Me.id_soporte.Text = idSoporte
            Me.txtCliente.Text = DesCliente
            Me.txtSoporte.Text = DesSoporte
            Me.ocultar_agregar()
        Else
            Me.Text = "Nueva tarifa"
        End If


        Me.id_tarifa_tv.Text = tt.Id_tarifa_tv
        Me.txtPrograma.Text = tt.Programa

        If Me.TipoSoporte = TipoAudiencia.Abierta Then
            Me.txtTelereport.Text = Me.DescTelereport
            Me.txtTelereport.Tag = tt.Id_programa
        End If

        If tt.D_l = "X" Then
            Me.ChkLunes.Checked = True
        End If
        If tt.D_m = "X" Then
            Me.ChkMartes.Checked = True
        End If
        If tt.D_x = "X" Then
            Me.ChkMiercoles.Checked = True
        End If
        If tt.D_j = "X" Then
            Me.ChkJueves.Checked = True
        End If
        If tt.D_v = "X" Then
            Me.ChkViernes.Checked = True
        End If
        If tt.D_s = "X" Then
            Me.ChkSabado.Checked = True
        End If
        If tt.D_d = "X" Then
            Me.ChkDomingo.Checked = True
        End If
        Me.TxtHInicio.Text = Format(tt.H_desde, "00") + ":" + Format(tt.M_desde, "00")
        Me.TxtHFin.Text = Format(tt.H_hasta, "00") + ":" + Format(tt.M_hasta, "00")
        Me.DtpFInicio.Value = tt.F_inicio_vig
        'Cambio para que Gudarde La fecha Nueva 

        If EstaModificando Then
            Me.DtpFFin.Value = tt.F_fin_vig
            Me.DtpFInicio.Value = tt.F_inicio_vig
        Else
            Dim d As New Date(Now.Date.Year, 12, 31)
            Me.DtpFFin.Value = d
            Me.DtpFInicio.Value = Now
        End If


        If tt.Ind_especial = "1" Then
            Me.ChkEvento.Checked = True
        End If

        Me.txtIDPrograma.Text = tt.Id_programa
        Me.TxtTarifa.Text = tt.Bruto

        ' Me.ocultar_agregar()
        Me.pasa_tarifa_Tv(tt)

        If EstaModificando Then
            Me.ShowDialog()
        End If


    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

        If Me.TipoSoporte <> TipoAudiencia.Abierta Then
            Dim Fb As New frmBuscar

            Fb.CargarFormulario(SeccionActiva.Programa, txtPrograma, txtIDPrograma, "id_programa", "descripcion", "Código", "Programa", CInt(id_soporte.Text), Activo.IDMedio)

            Fb.ShowDialog()
            Exit Sub
        End If

        Dim f As New frmTarifasAnteriores

        f.IdMedio = Activo.IDMedio
        f.IdCliente = Me.id_cliente.Text
        f.IdSoporte = Me.id_soporte.Text
        f.Cliente = Me.txtCliente.Text
        f.Soporte = Me.txtSoporte.Text

        f.CargarTarifas()
        f.ShowDialog()

        If f.idtarifa = -1 Then
            Exit Sub
        End If
        Me.TipoSoporte = f.TipoSoporte
        Me.DescTelereport = f.DesTele
        Me.CargarFormulario(f.idtarifa, False)

    End Sub



    Private Sub TxtHInicio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHInicio.LostFocus
        Dim s As String
        Dim hi, minutos, hora As String
        Dim l, indice As Integer

        hi = TxtHInicio.Text

        l = hi.Length

        If l > 0 Then


            indice = hi.IndexOf(":")
            If indice > 0 Then ' tiene dos puntos, no necesito agregarlo

            Else
                If l = 1 Or l = 2 Then ' ingreso sin minutos
                    minutos = "00"
                    hora = hi
                Else
                    minutos = hi.Substring(l - 2)
                    If l = 4 Then
                        hora = hi.Substring(0, 2)
                    ElseIf l = 3 Then
                        hora = hi.Substring(0, 1)
                    Else ' error

                    End If

                End If
                TxtHInicio.Text = hora & ":" & minutos
            End If
            'hi.Split(":") ' separa hora de minuto

        End If
    End Sub


    Private Sub TxtHFin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHFin.LostFocus
        Dim s As String
        Dim hf, minutos, hora As String
        Dim l, indice As Integer

        hf = TxtHFin.Text

        l = hf.Length

        If l > 0 Then
            indice = hf.IndexOf(":")
            If indice > 0 Then ' tiene dos puntos, no necesito agregarlo

            Else
                If l = 1 Or l = 2 Then ' ingreso sin minutos
                    minutos = "59"
                    hora = hf
                Else
                    minutos = hf.Substring(l - 2)
                    If l = 4 Then
                        hora = hf.Substring(0, 2)
                    ElseIf l = 3 Then
                        hora = hf.Substring(0, 1)
                    End If

                End If
                TxtHFin.Text = hora & ":" & minutos
            End If
        End If
    End Sub

    Private Sub txtPrograma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrograma.KeyPress

        If Me.TipoSoporte <> TipoAudiencia.Abierta Then
            If e.KeyChar <> Chr(13) And e.KeyChar <> Chr(9) Then
                txtIDPrograma.Text = ""
            End If

            If e.KeyChar = Chr(13) And txtPrograma.Text = "" Then
                Dim F As New frmBuscar

                F.CargarFormulario(SeccionActiva.Programa, txtPrograma, txtIDPrograma, "id_programa", "descripcion", "Código", "Programa", CInt(id_soporte.Text))

                F.ShowDialog()
            End If
        End If
    End Sub

    Private Sub TxtTarifa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTarifa.TextChanged

    End Sub

    Private Sub TxtTarifa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTarifa.LostFocus
        TxtTarifa.Text = TxtTarifa.Text.Replace(".", ",")
    End Sub
    Public Sub Modificar()

        tarifa.Id_tarifa_tv = Me.id_tarifa_tv.Text
        tarifa.Programa = Me.txtPrograma.Text

        If Me.ChkLunes.Checked Then
            tarifa.D_l = "X"
        Else
            tarifa.D_l = ""
        End If
        If Me.ChkMartes.Checked Then
            tarifa.D_m = "X"
        Else
            tarifa.D_m = ""
        End If
        If Me.ChkMiercoles.Checked Then
            tarifa.D_x = "X"
        Else
            tarifa.D_x = ""
        End If
        If Me.ChkJueves.Checked Then
            tarifa.D_j = "X"
        Else
            tarifa.D_j = ""
        End If
        If Me.ChkViernes.Checked Then
            tarifa.D_v = "X"
        Else
            tarifa.D_v = ""
        End If
        If Me.ChkSabado.Checked Then
            tarifa.D_s = "X"
        Else
            tarifa.D_s = ""
        End If
        If Me.ChkDomingo.Checked Then
            tarifa.D_d = "X"
        Else
            tarifa.D_d = ""
        End If

        tarifa.H_desde = devolverhora(TxtHInicio.Text)
        tarifa.M_desde = devolverminutos(TxtHInicio.Text)
        tarifa.H_hasta = devolverhora(TxtHFin.Text)
        tarifa.M_hasta = devolverminutos(TxtHFin.Text)
        tarifa.F_inicio_vig = Me.DtpFInicio.DateTime.Date
        tarifa.F_fin_vig = Me.DtpFFin.DateTime.Date
        If Me.ChkEvento.Checked Then
            tarifa.Ind_especial = 1
        Else
            tarifa.Ind_especial = 0
        End If

        Try
            If Me.txtIDPrograma.Text <> "" Then
                tarifa.Id_programa = CLng(Me.txtIDPrograma.Text)
            Else
                tarifa.Id_programa = 0
            End If
            tarifa.Bruto = Me.TxtTarifa.Text

            If tarifa.Existe() Then
                Mensajes.Mensaje("Ya existe una tarifa cargada para ese horario, dia o vigencia")
            Else
                ' inserta
                Try
                    tarifa.Modificar()

                    inicializarComponentes()
                    Me.txtPrograma.Focus()
                Catch ex As Oracle.DataAccess.Client.OracleException
                    Mensajes.Mensaje("Error al intentar guardar los datos modificados")

                End Try

            End If

        Catch ex As Exception
            MsgBox("ACA: " & ex.Message)
        End Try
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click


        If FormularioOK() Then
            Modificar()

        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar = True
    End Sub

    Private Sub ChkEvento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEvento.CheckedChanged

    End Sub

    Private Sub txtPrograma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrograma.TextChanged

    End Sub

    Private Sub txtIDPrograma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDPrograma.TextChanged

    End Sub
End Class

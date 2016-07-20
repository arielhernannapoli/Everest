Public Class frmCopiarTarifa
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents txtCodigo As QUETOOL.txtTexto
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtDescSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtIDSoporte As QUETOOL.txtTexto
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SoporteDestino As QUETOOL.txtTexto
    Friend WithEvents ClienteDestino As QUETOOL.txtTexto
    Friend WithEvents TxtDescSoporteDestino As QUETOOL.txtTexto
    Friend WithEvents TxtDesClienteDestino As QUETOOL.txtTexto
    Friend WithEvents dtpFVigencia As QUETOOL.dtpFecha
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CboMedio As QUETOOL.cboCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCopiarTarifa))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.txtCodigo = New QUETOOL.txtTexto
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtDescSoporte = New QUETOOL.txtTexto
        Me.TxtIDSoporte = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDescSoporteDestino = New QUETOOL.txtTexto
        Me.SoporteDestino = New QUETOOL.txtTexto
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtDesClienteDestino = New QUETOOL.txtTexto
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ClienteDestino = New QUETOOL.txtTexto
        Me.dtpFVigencia = New QUETOOL.dtpFecha
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CboMedio = New QUETOOL.cboCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFVigencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(148, 40)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(244, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TabStop = False
        Me.txtDescripcion.Text = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ConDecimal = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(12, 40)
        Me.txtCodigo.Maximo = 0
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(80, 21)
        Me.txtCodigo.SoloLetra = False
        Me.txtCodigo.SoloNumero = True
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = ""
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(28, 316)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Procesar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtDescSoporte)
        Me.GroupBox1.Controls.Add(Me.TxtIDSoporte)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente / Soporte origen"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label8.Location = New System.Drawing.Point(108, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 21)
        Me.Label8.TabIndex = 4
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDescSoporte
        '
        Me.TxtDescSoporte.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDescSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescSoporte.ConDecimal = False
        Me.TxtDescSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescSoporte.Location = New System.Drawing.Point(148, 80)
        Me.TxtDescSoporte.Maximo = 0
        Me.TxtDescSoporte.Name = "TxtDescSoporte"
        Me.TxtDescSoporte.ReadOnly = True
        Me.TxtDescSoporte.Size = New System.Drawing.Size(244, 21)
        Me.TxtDescSoporte.SoloLetra = False
        Me.TxtDescSoporte.SoloNumero = False
        Me.TxtDescSoporte.TabIndex = 15
        Me.TxtDescSoporte.TabStop = False
        Me.TxtDescSoporte.Text = ""
        '
        'TxtIDSoporte
        '
        Me.TxtIDSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIDSoporte.ConDecimal = False
        Me.TxtIDSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDSoporte.Location = New System.Drawing.Point(12, 80)
        Me.TxtIDSoporte.Maximo = 0
        Me.TxtIDSoporte.MaxLength = 4
        Me.TxtIDSoporte.Name = "TxtIDSoporte"
        Me.TxtIDSoporte.Size = New System.Drawing.Size(84, 21)
        Me.TxtIDSoporte.SoloLetra = False
        Me.TxtIDSoporte.SoloNumero = True
        Me.TxtIDSoporte.TabIndex = 3
        Me.TxtIDSoporte.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Soporte"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(108, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(340, 316)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtDescSoporteDestino)
        Me.GroupBox2.Controls.Add(Me.SoporteDestino)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtDesClienteDestino)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ClienteDestino)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente / Soporte Destino"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(108, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDescSoporteDestino
        '
        Me.TxtDescSoporteDestino.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDescSoporteDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescSoporteDestino.ConDecimal = False
        Me.TxtDescSoporteDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescSoporteDestino.Location = New System.Drawing.Point(148, 80)
        Me.TxtDescSoporteDestino.Maximo = 0
        Me.TxtDescSoporteDestino.Name = "TxtDescSoporteDestino"
        Me.TxtDescSoporteDestino.ReadOnly = True
        Me.TxtDescSoporteDestino.Size = New System.Drawing.Size(244, 21)
        Me.TxtDescSoporteDestino.SoloLetra = False
        Me.TxtDescSoporteDestino.SoloNumero = False
        Me.TxtDescSoporteDestino.TabIndex = 15
        Me.TxtDescSoporteDestino.TabStop = False
        Me.TxtDescSoporteDestino.Text = ""
        '
        'SoporteDestino
        '
        Me.SoporteDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SoporteDestino.ConDecimal = False
        Me.SoporteDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoporteDestino.Location = New System.Drawing.Point(12, 80)
        Me.SoporteDestino.Maximo = 0
        Me.SoporteDestino.MaxLength = 4
        Me.SoporteDestino.Name = "SoporteDestino"
        Me.SoporteDestino.Size = New System.Drawing.Size(84, 21)
        Me.SoporteDestino.SoloLetra = False
        Me.SoporteDestino.SoloNumero = True
        Me.SoporteDestino.TabIndex = 3
        Me.SoporteDestino.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Soporte"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(108, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDesClienteDestino
        '
        Me.TxtDesClienteDestino.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDesClienteDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesClienteDestino.ConDecimal = False
        Me.TxtDesClienteDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesClienteDestino.Location = New System.Drawing.Point(148, 40)
        Me.TxtDesClienteDestino.Maximo = 0
        Me.TxtDesClienteDestino.Name = "TxtDesClienteDestino"
        Me.TxtDesClienteDestino.ReadOnly = True
        Me.TxtDesClienteDestino.Size = New System.Drawing.Size(244, 21)
        Me.TxtDesClienteDestino.SoloLetra = False
        Me.TxtDesClienteDestino.SoloNumero = False
        Me.TxtDesClienteDestino.TabIndex = 1
        Me.TxtDesClienteDestino.TabStop = False
        Me.TxtDesClienteDestino.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(148, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Descripción"
        '
        'ClienteDestino
        '
        Me.ClienteDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClienteDestino.ConDecimal = False
        Me.ClienteDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteDestino.Location = New System.Drawing.Point(12, 40)
        Me.ClienteDestino.Maximo = 0
        Me.ClienteDestino.MaxLength = 4
        Me.ClienteDestino.Name = "ClienteDestino"
        Me.ClienteDestino.Size = New System.Drawing.Size(80, 21)
        Me.ClienteDestino.SoloLetra = False
        Me.ClienteDestino.SoloNumero = True
        Me.ClienteDestino.TabIndex = 1
        Me.ClienteDestino.Text = ""
        '
        'dtpFVigencia
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFVigencia.Appearance = Appearance1
        Me.dtpFVigencia.FlatMode = True
        Me.dtpFVigencia.Location = New System.Drawing.Point(144, 284)
        Me.dtpFVigencia.Name = "dtpFVigencia"
        Me.dtpFVigencia.Size = New System.Drawing.Size(96, 21)
        Me.dtpFVigencia.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Fecha de vigencia"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CboMedio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 40)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'CboMedio
        '
        Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboMedio.DisplayMember = ""
        Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedio.Location = New System.Drawing.Point(48, 12)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(245, 21)
        Me.CboMedio.TabIndex = 79
        Me.CboMedio.Tag = ""
        Me.CboMedio.ValueMember = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Medio"
        '
        'frmCopiarTarifa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(438, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpFVigencia)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCopiarTarifa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar Tarifas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtpFVigencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'es para que el form que llama, sepa si se apreto cancelar
    Public Cancelar As Boolean

    'es para saber si esta cargando por 1ra vez o se esta cambiando de cliente
    Public CargandoPrimeraVez As Boolean

    Shared vIDMedio As Integer
    Shared vIDCliente As Integer
    Shared vIDSoporte As Integer
    Shared vDescCliente As String
    Shared vDescSoporte As String
    Shared vSoloVigente As Boolean

    Public Shared Property idmedio() As Integer
        Get
            Return vIDMedio
        End Get
        Set(ByVal value As Integer)
            vIDMedio = value
        End Set
    End Property
    Public Shared Property SoloVigentes() As Boolean
        Get
            Return vSoloVigente
        End Get
        Set(ByVal value As Boolean)
            vSoloVigente = value
        End Set
    End Property
    Public Shared Property idCliente() As Integer
        Get
            Return vIDCliente
        End Get
        Set(ByVal Value As Integer)
            vIDCliente = Value
        End Set
    End Property

    Public Shared Property idSoporte() As Integer
        Get
            Return vIDSoporte
        End Get
        Set(ByVal Value As Integer)
            vIDSoporte = Value
        End Set
    End Property

    Public Shared Property DescripcionCliente() As String
        Get
            Return vDescCliente
        End Get
        Set(ByVal Value As String)
            vDescCliente = Value
        End Set
    End Property
    Public Shared Property DescripcionSoporte() As String
        Get
            Return vDescSoporte
        End Get
        Set(ByVal Value As String)
            vDescSoporte = Value
        End Set
    End Property


    Private Sub CopiarTarifa()

        Dim tn As New Tarifas_tv
        tn.Id_medio = Activo.IDMedio
        tn.Id_cliente = Me.txtCodigo.Text
        tn.Id_soporte = Me.TxtIDSoporte.Text


        Dim dtn As New DataTable
        dtn = tn.TraerTodosConVigencia(dtpFVigencia.DateTime.Date)

        If dtn.Rows.Count > 0 Then
            Dim drn As DataRow

            For Each drn In dtn.Rows
                Dim tdestino As New Tarifas_tv

                tdestino.Id_tarifa_tv = drn("id_Tarifa_tv")
                tdestino.Id_medio = drn("id_medio")
                tdestino.Id_soporte = SoporteDestino.Text
                tdestino.Id_cliente = ClienteDestino.Text
                tdestino.Programa = drn("programa")

                If Not IsDBNull(drn("d_l")) Then
                    tdestino.D_l = drn("d_l")
                End If
                If Not IsDBNull(drn("d_m")) Then
                    tdestino.D_m = drn("d_m")
                End If

                If Not IsDBNull(drn("d_x")) Then
                    tdestino.D_x = drn("d_x")
                End If

                If Not IsDBNull(drn("d_j")) Then
                    tdestino.D_j = drn("d_j")
                End If

                If Not IsDBNull(drn("d_v")) Then
                    tdestino.D_v = drn("d_v")
                End If
                If Not IsDBNull(drn("d_s")) Then
                    tdestino.D_s = drn("d_s")
                End If
                If Not IsDBNull(drn("d_d")) Then
                    tdestino.D_d = drn("D_d")
                End If

                tdestino.H_desde = drn("h_desde")
                tdestino.M_desde = drn("m_desde")
                tdestino.H_hasta = drn("h_hasta")
                tdestino.M_hasta = drn("m_hasta")
                If drn("f_inicio_vig") < dtpFVigencia.DateTime.Date Then
                    tdestino.F_inicio_vig = dtpFVigencia.DateTime.Date
                Else
                    tdestino.F_inicio_vig = drn("f_inicio_vig")
                End If
                tdestino.F_fin_vig = drn("f_fin_vig")
                If Not IsDBNull(drn("ind_especial")) Then
                    tdestino.Ind_especial = drn("ind_especial")
                End If
                'tdestino.Id_programa = 0
                tdestino.Bruto = drn("bruto")


                Try
                    tdestino.Agregar()


                Catch ex As Oracle.DataAccess.Client.OracleException
                    Mensajes.Mensaje("Error al intentar agregar una tarifa")
                    Exit Sub
                End Try

            Next
            Mensajes.Mensaje("La copia de tarifas finalizó exitosamente.  Se copiaron " + dtn.Rows.Count.ToString + " tarifas.")
        Else
            Mensajes.Mensaje("no hay tarifas para copiar en ese soporte y cliente")
        End If

    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If txtCodigo.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Cliente de origen")
            txtCodigo.Select()
            Exit Sub
        End If

        If TxtIDSoporte.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Soporte de origen")
            TxtIDSoporte.Select()
            Exit Sub
        End If
        If ClienteDestino.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Cliente de destino")
            ClienteDestino.Select()
            Exit Sub
        End If

        If TxtDesClienteDestino.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Soporte de destino")
            TxtDesClienteDestino.Select()
            Exit Sub
        End If

        Dim t As New Tarifas_tv
        t.Id_medio = Activo.IDMedio
        t.Id_cliente = Me.ClienteDestino.Text
        t.Id_soporte = Me.SoporteDestino.Text

        Dim dt As New DataTable

        dt = t.TraerTodosConVigencia(dtpFVigencia.DateTime.Date)
        Dim resp As Integer

        If dt.Rows.Count > 0 Then
            Dim st As String

            st = "Atención! Existen " + dt.Rows.Count.ToString + " tarifas cargadas en donde se intenta insertar. " + Chr(10) + Chr(13)
            st = st + "Se bajarán la vigencia de esos registros y se copiaran los nuevos ¿Está seguro? "


            resp = Mensajes.Mensaje(st, TipoMensaje.SiNo)
            If resp = DialogResult.Yes Then
                ' BAJAR LA VIGENCIA DE TODOS LOS REGISTROS
                Dim dr As DataRow
                Dim id As Integer
                Dim f_inicio As Date
                Dim f_fin As Date

                For Each dr In dt.Rows
                    id = dr("id_tarifa_Tv")

                    f_inicio = dr("F_inicio_vig")
                    f_fin = dr("F_fin_vig")

                    f_fin = dtpFVigencia.DateTime.Date.AddDays(-1)

                    Try
                        t.actualizarVigencia(id, f_fin)
                    Catch ex As Oracle.DataAccess.Client.OracleException
                        Mensajes.Mensaje("Error al intentar bajar la vigencia de los datos existentes")
                    End Try

                Next

                ' BORRAR SI EXISTE ALGO DE VIGENCIA SIGUIENTE A ESE REGISTRO
                Try
                    t.BorrarMayores(Activo.IDMedio, SoporteDestino.Text, ClienteDestino.Text, dtpFVigencia.DateTime.Date)
                Catch ex As Oracle.DataAccess.Client.OracleException
                    Mensajes.Mensaje("Error al intentar borrar las tarifas posteriores a la fecha de vigencia")
                End Try

                CopiarTarifa()
            End If
        Else
            ' BORRAR SI EXISTE ALGO DE VIGENCIA SIGUIENTE A ESE REGISTRO
            Try
                t.BorrarMayores(Activo.IDMedio, SoporteDestino.Text, ClienteDestino.Text, dtpFVigencia.DateTime.Date)
            Catch ex As Oracle.DataAccess.Client.OracleException
                Mensajes.Mensaje("Error al intentar borrar las tarifas posteriores a la fecha de vigencia")
            End Try
            CopiarTarifa()


        End If




        Cancelar = False
        Me.Hide()


    End Sub

    Private Sub BuscarCliente()
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Cliente, txtDescripcion, txtCodigo, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()
    End Sub

    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarCliente()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub txtCodigo_SePresionoBarra() Handles txtCodigo.SePresionoBarra
        BuscarCliente()
    End Sub

    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated
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

            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try

            'txtDescripcion.Text = C.Descripcion
        End If
    End Sub




    Private Sub frmElegirCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Activo.IDMedio = 1
        Call CargarMedios()
        If CargandoPrimeraVez Then
            cmdCancelar.Visible = False

            cmdAceptar.Left = cmdCancelar.Left
            cmdAceptar.Top = cmdCancelar.Top
        End If
    End Sub

    Private Sub CargarMedios()
        Dim Medio As New Soportes
        Listas.CargarCombo(Me.CboMedio, Medio.ObtenerMediosActivos, "Id_Medio", "descripcion")

        Listas.OcultarColumnas(CboMedio, "Id_Medio")
        Listas.OcultarHeader(CboMedio)
        CboMedio.SelectedRow = CboMedio.Rows(0)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar = True

        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Soporte, TxtDescSoporte, TxtIDSoporte, "id_soporte", "descripcion", "Código", "Soporte", Activo.IDMedio)

        F.ShowDialog()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub TxtIDSoporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtIDSoporte_Validated_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        BuscarCliente()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Soporte, TxtDescSoporte, TxtIDSoporte, "id_soporte", "descripcion", "Código", "Soporte", Activo.IDMedio)

        F.ShowDialog()
    End Sub

    Private Sub TxtIDSoporte_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIDSoporte.TextChanged

    End Sub

    Private Sub TxtIDSoporte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIDSoporte.Validated
        If TxtIDSoporte.Text <> "" Then

            Dim s As New Soportes

            Try

                s.Id_medio = Activo.IDMedio
                TxtDescSoporte.Text = s.ObtenerDescripcion(TxtIDSoporte.Text)

                If TxtDescSoporte.Text = "" Then
                    Mensajes.Mensaje("El soporte No Existe ")
                    TxtIDSoporte.Text = ""
                    TxtIDSoporte.Select()
                    Exit Sub
                End If

            Catch ex As Exception

                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try

            'txtDescripcion.Text = C.Descripcion
        End If
    End Sub

    Private Sub TxtIDSoporte_SePresionoBarra() Handles TxtIDSoporte.SePresionoBarra

    End Sub

    Private Sub TxtTexto4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteDestino.TextChanged

    End Sub

    Private Sub ClienteDestino_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClienteDestino.Validated
        If ClienteDestino.Text <> "" Then

            Dim U As New Usuario

            Try

                U.IDPerfil_Datos = Activo.IDPerfil_Datos
                TxtDesClienteDestino.Text = U.ObtenerDescripcion(ClienteDestino.Text)

                If TxtDesClienteDestino.Text = "" Then
                    Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                    ClienteDestino.Text = ""
                    ClienteDestino.Select()
                    Exit Sub
                End If

            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try

            'txtDescripcion.Text = C.Descripcion
        End If
    End Sub

    Private Sub SoporteDestino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoporteDestino.TextChanged

    End Sub

    Private Sub SoporteDestino_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SoporteDestino.Validated
        If SoporteDestino.Text <> "" Then

            Dim s As New Soportes

            Try

                s.Id_medio = Activo.IDMedio
                TxtDescSoporteDestino.Text = s.ObtenerDescripcion(SoporteDestino.Text)

                If TxtDescSoporteDestino.Text = "" Then
                    Mensajes.Mensaje("El soporte No Existe ")
                    SoporteDestino.Text = ""
                    SoporteDestino.Select()
                    Exit Sub
                End If

            Catch ex As Exception

                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try

            'txtDescripcion.Text = C.Descripcion
        End If
    End Sub

    Private Sub dtpFVigencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFVigencia.ValueChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Cliente, TxtDesClienteDestino, ClienteDestino, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()
    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Soporte, TxtDescSoporteDestino, SoporteDestino, "id_soporte", "descripcion", "Código", "Soporte", Activo.IDMedio)

        F.ShowDialog()
    End Sub

    Private Sub CboMedio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.ValueChanged
        Activo.IDMedio = CboMedio.Value
        TxtIDSoporte.Text = String.Empty
        TxtDescSoporte.Text = String.Empty
        SoporteDestino.Text = String.Empty
        TxtDescSoporteDestino.Text = String.Empty
    End Sub
End Class

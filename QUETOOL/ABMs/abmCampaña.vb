Public Class abmCampaña
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
    Friend WithEvents txtObservaciones As QUETOOL.txtTexto
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents txtBRFBruto As QUETOOL.txtTexto
    Friend WithEvents txtBRFNeto As QUETOOL.txtTexto
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVar2Texto As QUETOOL.txtTexto
    Friend WithEvents txtVar1Texto As QUETOOL.txtTexto
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents fraObservacion As System.Windows.Forms.GroupBox
    Friend WithEvents fraGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents fraBrief As System.Windows.Forms.GroupBox
    Friend WithEvents fraObjetivos As System.Windows.Forms.GroupBox
    Friend WithEvents txtVar1 As QUETOOL.txtTexto
    Friend WithEvents txtVar2 As QUETOOL.txtTexto
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaFin As QUETOOL.dtpFecha
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.fraObservacion = New System.Windows.Forms.GroupBox
        Me.txtObservaciones = New QUETOOL.txtTexto
        Me.fraGeneral = New System.Windows.Forms.GroupBox
        Me.dtpFechaFin = New QUETOOL.dtpFecha
        Me.dtpFechaInicio = New QUETOOL.dtpFecha
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.fraBrief = New System.Windows.Forms.GroupBox
        Me.txtBRFBruto = New QUETOOL.txtTexto
        Me.txtBRFNeto = New QUETOOL.txtTexto
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.fraObjetivos = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtVar2 = New QUETOOL.txtTexto
        Me.txtVar1 = New QUETOOL.txtTexto
        Me.txtVar2Texto = New QUETOOL.txtTexto
        Me.txtVar1Texto = New QUETOOL.txtTexto
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.fraObservacion.SuspendLayout()
        Me.fraGeneral.SuspendLayout()
        CType(Me.dtpFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraBrief.SuspendLayout()
        Me.fraObjetivos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraObservacion
        '
        Me.fraObservacion.Controls.Add(Me.txtObservaciones)
        Me.fraObservacion.Enabled = False
        Me.fraObservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraObservacion.Location = New System.Drawing.Point(0, 320)
        Me.fraObservacion.Name = "fraObservacion"
        Me.fraObservacion.Size = New System.Drawing.Size(452, 80)
        Me.fraObservacion.TabIndex = 3
        Me.fraObservacion.TabStop = False
        Me.fraObservacion.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.ConDecimal = False
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 20)
        Me.txtObservaciones.Maximo = 0
        Me.txtObservaciones.MaxLength = 400
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(428, 48)
        Me.txtObservaciones.SoloLetra = False
        Me.txtObservaciones.SoloNumero = False
        Me.txtObservaciones.TabIndex = 0
        Me.txtObservaciones.Text = ""
        '
        'fraGeneral
        '
        Me.fraGeneral.Controls.Add(Me.dtpFechaFin)
        Me.fraGeneral.Controls.Add(Me.dtpFechaInicio)
        Me.fraGeneral.Controls.Add(Me.Label6)
        Me.fraGeneral.Controls.Add(Me.Label5)
        Me.fraGeneral.Controls.Add(Me.Label4)
        Me.fraGeneral.Controls.Add(Me.txtDescripcion)
        Me.fraGeneral.Enabled = False
        Me.fraGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraGeneral.Location = New System.Drawing.Point(0, 64)
        Me.fraGeneral.Name = "fraGeneral"
        Me.fraGeneral.Size = New System.Drawing.Size(452, 80)
        Me.fraGeneral.TabIndex = 0
        Me.fraGeneral.TabStop = False
        Me.fraGeneral.Text = "Información General"
        '
        'dtpFechaFin
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFechaFin.Appearance = Appearance1
        Me.dtpFechaFin.FlatMode = True
        Me.dtpFechaFin.Location = New System.Drawing.Point(320, 48)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(120, 21)
        Me.dtpFechaFin.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicio.Appearance = Appearance2
        Me.dtpFechaInicio.FlatMode = True
        Me.dtpFechaInicio.Location = New System.Drawing.Point(96, 48)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(120, 21)
        Me.dtpFechaInicio.TabIndex = 1
        Me.dtpFechaInicio.Tag = "Fecha de Inicio de la Campaña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Fecha de Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Fecha de Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 24)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 20)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(344, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.Tag = "Muestra la Información de la Campaña !!!"
        Me.txtDescripcion.Text = ""
        '
        'fraBrief
        '
        Me.fraBrief.Controls.Add(Me.txtBRFBruto)
        Me.fraBrief.Controls.Add(Me.txtBRFNeto)
        Me.fraBrief.Controls.Add(Me.Label8)
        Me.fraBrief.Controls.Add(Me.Label7)
        Me.fraBrief.Enabled = False
        Me.fraBrief.Location = New System.Drawing.Point(0, 148)
        Me.fraBrief.Name = "fraBrief"
        Me.fraBrief.Size = New System.Drawing.Size(452, 52)
        Me.fraBrief.TabIndex = 1
        Me.fraBrief.TabStop = False
        Me.fraBrief.Text = "Información de Brief"
        '
        'txtBRFBruto
        '
        Me.txtBRFBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBRFBruto.ConDecimal = False
        Me.txtBRFBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRFBruto.Location = New System.Drawing.Point(308, 20)
        Me.txtBRFBruto.Maximo = 0
        Me.txtBRFBruto.MaxLength = 10
        Me.txtBRFBruto.Name = "txtBRFBruto"
        Me.txtBRFBruto.Size = New System.Drawing.Size(132, 21)
        Me.txtBRFBruto.SoloLetra = False
        Me.txtBRFBruto.SoloNumero = True
        Me.txtBRFBruto.TabIndex = 1
        Me.txtBRFBruto.Text = ""
        Me.txtBRFBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBRFNeto
        '
        Me.txtBRFNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBRFNeto.ConDecimal = False
        Me.txtBRFNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBRFNeto.Location = New System.Drawing.Point(92, 20)
        Me.txtBRFNeto.Maximo = 0
        Me.txtBRFNeto.MaxLength = 10
        Me.txtBRFNeto.Name = "txtBRFNeto"
        Me.txtBRFNeto.Size = New System.Drawing.Size(124, 21)
        Me.txtBRFNeto.SoloLetra = False
        Me.txtBRFNeto.SoloNumero = True
        Me.txtBRFNeto.TabIndex = 0
        Me.txtBRFNeto.Text = ""
        Me.txtBRFNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(228, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Inversión Bruta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Inversión Neta"
        '
        'fraObjetivos
        '
        Me.fraObjetivos.Controls.Add(Me.Label1)
        Me.fraObjetivos.Controls.Add(Me.Label2)
        Me.fraObjetivos.Controls.Add(Me.txtVar2)
        Me.fraObjetivos.Controls.Add(Me.txtVar1)
        Me.fraObjetivos.Controls.Add(Me.txtVar2Texto)
        Me.fraObjetivos.Controls.Add(Me.txtVar1Texto)
        Me.fraObjetivos.Controls.Add(Me.Label16)
        Me.fraObjetivos.Controls.Add(Me.Label14)
        Me.fraObjetivos.Enabled = False
        Me.fraObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraObjetivos.Location = New System.Drawing.Point(0, 204)
        Me.fraObjetivos.Name = "fraObjetivos"
        Me.fraObjetivos.Size = New System.Drawing.Size(452, 112)
        Me.fraObjetivos.TabIndex = 2
        Me.fraObjetivos.TabStop = False
        Me.fraObjetivos.Text = "Objetivos de Comunicación"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 20)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "%"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(420, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVar2
        '
        Me.txtVar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar2.ConDecimal = False
        Me.txtVar2.Location = New System.Drawing.Point(372, 64)
        Me.txtVar2.Maximo = 100
        Me.txtVar2.Name = "txtVar2"
        Me.txtVar2.Size = New System.Drawing.Size(48, 20)
        Me.txtVar2.SoloLetra = False
        Me.txtVar2.SoloNumero = True
        Me.txtVar2.TabIndex = 3
        Me.txtVar2.Text = ""
        Me.txtVar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVar1
        '
        Me.txtVar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar1.ConDecimal = False
        Me.txtVar1.Location = New System.Drawing.Point(372, 20)
        Me.txtVar1.Maximo = 100
        Me.txtVar1.Name = "txtVar1"
        Me.txtVar1.Size = New System.Drawing.Size(48, 20)
        Me.txtVar1.SoloLetra = False
        Me.txtVar1.SoloNumero = True
        Me.txtVar1.TabIndex = 1
        Me.txtVar1.Text = ""
        Me.txtVar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVar2Texto
        '
        Me.txtVar2Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar2Texto.ConDecimal = False
        Me.txtVar2Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar2Texto.Location = New System.Drawing.Point(36, 64)
        Me.txtVar2Texto.Maximo = 0
        Me.txtVar2Texto.MaxLength = 100
        Me.txtVar2Texto.Multiline = True
        Me.txtVar2Texto.Name = "txtVar2Texto"
        Me.txtVar2Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVar2Texto.Size = New System.Drawing.Size(328, 36)
        Me.txtVar2Texto.SoloLetra = False
        Me.txtVar2Texto.SoloNumero = False
        Me.txtVar2Texto.TabIndex = 2
        Me.txtVar2Texto.Text = ""
        '
        'txtVar1Texto
        '
        Me.txtVar1Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVar1Texto.ConDecimal = False
        Me.txtVar1Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVar1Texto.Location = New System.Drawing.Point(36, 20)
        Me.txtVar1Texto.Maximo = 0
        Me.txtVar1Texto.MaxLength = 100
        Me.txtVar1Texto.Multiline = True
        Me.txtVar1Texto.Name = "txtVar1Texto"
        Me.txtVar1Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVar1Texto.Size = New System.Drawing.Size(328, 36)
        Me.txtVar1Texto.SoloLetra = False
        Me.txtVar1Texto.SoloNumero = False
        Me.txtVar1Texto.TabIndex = 0
        Me.txtVar1Texto.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 16)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "1)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 16)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "2)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'lblCliente
        '
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Blue
        Me.lblCliente.Location = New System.Drawing.Point(12, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(428, 21)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'abmCampaña
        '
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fraObservacion)
        Me.Controls.Add(Me.fraGeneral)
        Me.Controls.Add(Me.fraObjetivos)
        Me.Controls.Add(Me.fraBrief)
        Me.Name = "abmCampaña"
        Me.Size = New System.Drawing.Size(456, 404)
        Me.fraObservacion.ResumeLayout(False)
        Me.fraGeneral.ResumeLayout(False)
        CType(Me.dtpFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraBrief.ResumeLayout(False)
        Me.fraObjetivos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim C As New Campaña

    Dim mModificar As Boolean
    Dim mDebeGuardar As Boolean

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

    Public Sub Guardar() Implements IABM.Guardar
        If Not Me.fraGeneral.Enabled Then
            Exit Sub
        End If

        If Not Me.CargarObjeto() Then
            Exit Sub
        End If

        If Not Me.Modificar Then
            Activo.IDCampaña = C.Agregar()
        Else
            If Not Me.VerificarSistemaFueraRango Then
                C.Modificar()
            Else
                Mensajes.Mensaje("Existen sistemas asociados a esta campaña cuyos rangos de fechas " & Chr(13) & _
                "quedan afuera de la nueva configuración de la campaña", TipoMensaje.Informacion)
            End If
        End If
        'Activo.IDCampaña = C.ID_Campania
        Me.Modificar = True
        Me.DebeGuardar = False
    End Sub

    Public Sub Cargar() Implements IABM.Cargar
        C.ID_Campania = Activo.IDCampaña

        C.BuscarPorID()

        'pasa las fechas a la variable compartida
        Activo.FechaInicioCampaña = C.F_inicio
        Activo.FechaFinCampaña = C.F_fin
        Activo.Campaña = Me.txtDescripcion.Text
        'Activo.IDTipoSoporte = 

        With C
            Me.txtDescripcion.Text = .Descripcion

            Me.dtpFechaInicio.Value = .F_inicio
            Me.dtpFechaFin.Value = .F_fin

            Me.txtBRFNeto.Text = Format(.Brf_neto, "##,##")
            Me.txtBRFBruto.Text = Format(.Brf_bruto, "##,##")

            Me.txtVar1Texto.Text = .Var1_texto
            Me.txtVar1.Text = .Var1_valor

            Me.txtVar2Texto.Text = .Var2_texto
            Me.txtVar2.Text = .Var2_valor

            Me.txtObservaciones.Text = .Observacion
        End With

        Me.DebeGuardar = False
        Me.fraBrief.Enabled = True
        Me.fraGeneral.Enabled = True
        Me.fraObjetivos.Enabled = True
        Me.fraObservacion.Enabled = True
    End Sub

    Protected Function CargarObjeto() As Boolean Implements IABM.CargarObjeto
        With Me
            If Me.txtDescripcion.Text.Trim = "" Then
                Mensajes.Mensaje("Debe Ingresar la Descripción")
                txtDescripcion.Select()
                Return False
            End If

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

            If dtpFechaInicio.Value > dtpFechaFin.Value Then
                Mensajes.Mensaje("La Fecha de Inicio Debe ser Menor a la Fecha de Fin")
                dtpFechaInicio.Select()
                Return False
            End If

            Me.CambiaCero(.txtBRFBruto.Text)
            Me.CambiaCero(.txtBRFNeto.Text)
            Me.CambiaCero(.txtVar1.Text)
            Me.CambiaCero(.txtVar2.Text)

            C.ID_Campania = Activo.IDCampaña
            C.ID_Cliente = Activo.IDCliente

            C.Descripcion = .txtDescripcion.Text

            C.F_inicio = .dtpFechaInicio.Value
            C.F_fin = .dtpFechaFin.Value

            'actualiza las fechas por defecto
            Activo.FechaInicioCampaña = .dtpFechaInicio.Value
            Activo.FechaFinCampaña = .dtpFechaFin.Value

            C.Brf_neto = .txtBRFNeto.Text.Replace(".", "")
            C.Brf_bruto = .txtBRFBruto.Text.Replace(".", "")

            C.ID_Campania_est = 1

            C.Var1_texto = .txtVar1Texto.Text
            C.Var1_valor = .txtVar1.Text
            C.Var2_texto = .txtVar2Texto.Text
            C.Var2_valor = .txtVar2.Text

            C.Observacion = .txtObservaciones.Text

            C.F_alta = Date.Today
            C.U_alta = Activo.Login

            C.U_modi = Activo.Login
            C.F_modi = Date.Today

            Return True
        End With
    End Function

    Public Sub LimpiarControles() Implements IABM.LimpiarControles
        Dim L As New LimpiarObjetoTexto(Me)

        L.LimpiarTextos()

        Me.fraBrief.Enabled = True
        Me.fraGeneral.Enabled = True
        Me.fraObjetivos.Enabled = True
        Me.fraObservacion.Enabled = True

        txtDescripcion.Select()
    End Sub

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


    Public Sub Cancelar() Implements Framework.IABM.Cancelar
        Me.LimpiarControles()

        Me.fraBrief.Enabled = False
        Me.fraGeneral.Enabled = False
        Me.fraObjetivos.Enabled = False
        Me.fraObservacion.Enabled = False
    End Sub

    Private Sub CambiaCero(ByRef S As String)
        If S = "" Then
            S = "0"
        End If
    End Sub

#Region "Cambiar los Colores de Fondo Cuando se Cancela"
    Private Sub fraBrief_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraBrief.EnabledChanged
        If Me.fraBrief.Enabled Then
            Me.txtBRFBruto.BackColor = SystemColors.Window
            Me.txtBRFNeto.BackColor = SystemColors.Window
        Else
            Me.txtBRFBruto.BackColor = SystemColors.InactiveBorder
            Me.txtBRFNeto.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub fraGeneral_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraGeneral.EnabledChanged
        If Me.fraGeneral.Enabled Then
            Me.txtDescripcion.BackColor = SystemColors.Window
        Else
            Me.txtDescripcion.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub fraObservacion_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraObservacion.EnabledChanged
        If Me.fraObservacion.Enabled Then
            Me.txtObservaciones.BackColor = SystemColors.Window
        Else
            Me.txtObservaciones.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub fraObjetivos_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraObjetivos.EnabledChanged
        If Me.fraObjetivos.Enabled Then
            Me.txtVar1Texto.BackColor = SystemColors.Window
            Me.txtVar2Texto.BackColor = SystemColors.Window
        Else
            Me.txtVar1Texto.BackColor = SystemColors.InactiveBorder
            Me.txtVar2Texto.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub txtObservaciones_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservaciones.Leave
        If Me.fraObservacion.Enabled Then
            Me.txtObservaciones.BackColor = SystemColors.Window
        Else
            Me.txtObservaciones.BackColor = SystemColors.InactiveBorder
        End If
    End Sub
#End Region

    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        DebeGuardar = True
    End Sub

    Private Sub dtpFechaInicio_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaInicio.AfterCloseUp
        DebeGuardar = True
    End Sub

    Private Sub dtpFechaFin_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaFin.AfterCloseUp
        DebeGuardar = True
    End Sub

    Private Function VerificarSistemaFueraRango() As Boolean
        Dim c As New Campaña

        c.ID_Campania = Activo.IDCampaña
        c.F_inicio = dtpFechaInicio.Value
        c.F_fin = dtpFechaFin.Value
        VerificarSistemaFueraRango = c.VerificarSistemaFueraRango()
    End Function

    Private Sub txtBRFNeto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBRFNeto.Leave
        txtBRFNeto.Text = Format(Val(txtBRFNeto.Text), "##,##")
    End Sub

    Private Sub txtBRFBruto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBRFBruto.Leave
        txtBRFBruto.Text = Format(Val(txtBRFBruto.Text), "##,##")
    End Sub

    Private Sub fraBrief_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraBrief.Enter

    End Sub
End Class
Public Class frmElegirSoporteFecha
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
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDescSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtIDSoporte As QUETOOL.txtTexto
    Friend WithEvents dtpFecha As QUETOOL.dtpFecha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboMedio As QUETOOL.cboCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmElegirSoporteFecha))
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDescSoporte = New QUETOOL.txtTexto
        Me.TxtIDSoporte = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpFecha = New QUETOOL.dtpFecha
        Me.CboMedio = New QUETOOL.cboCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(152, 140)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(232, 140)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboMedio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDescSoporte)
        Me.GroupBox2.Controls.Add(Me.TxtIDSoporte)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 124)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Soporte"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(260, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Vigencia"
        '
        'TxtDescSoporte
        '
        Me.TxtDescSoporte.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDescSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescSoporte.ConDecimal = False
        Me.TxtDescSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescSoporte.Location = New System.Drawing.Point(80, 68)
        Me.TxtDescSoporte.Maximo = 0
        Me.TxtDescSoporte.Name = "TxtDescSoporte"
        Me.TxtDescSoporte.ReadOnly = True
        Me.TxtDescSoporte.Size = New System.Drawing.Size(200, 21)
        Me.TxtDescSoporte.SoloLetra = False
        Me.TxtDescSoporte.SoloNumero = False
        Me.TxtDescSoporte.TabIndex = 10
        Me.TxtDescSoporte.TabStop = False
        Me.TxtDescSoporte.Text = ""
        '
        'TxtIDSoporte
        '
        Me.TxtIDSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIDSoporte.ConDecimal = False
        Me.TxtIDSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDSoporte.Location = New System.Drawing.Point(80, 44)
        Me.TxtIDSoporte.Maximo = 0
        Me.TxtIDSoporte.MaxLength = 4
        Me.TxtIDSoporte.Name = "TxtIDSoporte"
        Me.TxtIDSoporte.Size = New System.Drawing.Size(172, 21)
        Me.TxtIDSoporte.SoloLetra = False
        Me.TxtIDSoporte.SoloNumero = True
        Me.TxtIDSoporte.TabIndex = 4
        Me.TxtIDSoporte.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripción"
        '
        'dtpFecha
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFecha.Appearance = Appearance1
        Me.dtpFecha.FlatMode = True
        Me.dtpFecha.Location = New System.Drawing.Point(80, 92)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 21)
        Me.dtpFecha.TabIndex = 15
        '
        'CboMedio
        '
        Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboMedio.DisplayMember = ""
        Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedio.Location = New System.Drawing.Point(80, 20)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(202, 21)
        Me.CboMedio.TabIndex = 81
        Me.CboMedio.Tag = ""
        Me.CboMedio.ValueMember = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Medio"
        '
        'frmElegirSoporteFecha
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(318, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmElegirSoporteFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Tarifas - Cliente Genérico"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'es para que el form que llama, sepa si se apreto cancelar
    Public Cancelar As Boolean

    'es para saber si esta cargando por 1ra vez o se esta cambiando de cliente
    Public CargandoPrimeraVez As Boolean

    Shared vIDMedio As Integer

    Shared vIDSoporte As Integer

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


    Public Shared Property idSoporte() As Integer
        Get
            Return vIDSoporte
        End Get
        Set(ByVal Value As Integer)
            vIDSoporte = Value
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
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click



        If TxtIDSoporte.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Soporte")
            TxtIDSoporte.Select()
            Exit Sub
        End If


        Me.idSoporte = TxtIDSoporte.Text

        Me.DescripcionSoporte = TxtDescSoporte.Text

        Me.idmedio = Activo.IDMedio

        Cancelar = False
        Me.Hide()


    End Sub





    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub




    Private Sub frmElegirCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Activo.IDMedio = 1
        Call CargarMedios()
        dtpFecha.DateTime = Now.Date
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

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Soporte, TxtDescSoporte, TxtIDSoporte, "id_soporte", "descripcion", "Código", "Soporte", Activo.IDMedio)

        F.ShowDialog()
    End Sub

    Private Sub CboMedio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.ValueChanged
        Activo.IDMedio = CboMedio.Value
        TxtIDSoporte.Text = String.Empty
        TxtDescSoporte.Text = String.Empty
    End Sub
End Class

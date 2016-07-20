Imports MSL
Imports HM.Contratos
Imports HM.Comun.Utilidades
Imports Framework
Imports System.ComponentModel
Imports MPG.DBL

Public Class frmLogIn
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As QUETOOL.txtTexto
    Friend WithEvents txtContraseña As QUETOOL.txtTexto
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents marqueeCarga As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.marqueeCarga = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.txtContraseña = New QUETOOL.txtTexto
        Me.txtUsuario = New QUETOOL.txtTexto
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 64)
        Me.Label1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(228, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "INICIO DE SESIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(0, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(468, 1)
        Me.Label5.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(-12, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(468, 1)
        Me.Label6.TabIndex = 14
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(216, 204)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 24)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Location = New System.Drawing.Point(128, 204)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 24)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(165, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 124)
        Me.Label7.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(128, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 190)
        Me.Label8.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(229, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 24)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Powered by MMS"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(17, 111)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(95, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'marqueeCarga
        '
        Me.marqueeCarga.EditValue = "Cargando..."
        Me.marqueeCarga.Location = New System.Drawing.Point(232, 154)
        Me.marqueeCarga.Name = "marqueeCarga"
        Me.marqueeCarga.Size = New System.Drawing.Size(164, 20)
        Me.marqueeCarga.TabIndex = 26
        '
        'BackgroundWorker1
        '
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.ConDecimal = False
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(232, 113)
        Me.txtContraseña.Maximo = 0
        Me.txtContraseña.MaxLength = 20
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(164, 22)
        Me.txtContraseña.SoloLetra = False
        Me.txtContraseña.SoloNumero = False
        Me.txtContraseña.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.ConDecimal = False
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(232, 85)
        Me.txtUsuario.Maximo = 0
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(164, 22)
        Me.txtUsuario.SoloLetra = False
        Me.txtUsuario.SoloNumero = False
        Me.txtUsuario.TabIndex = 0
        '
        'BackgroundWorker2
        '
        '
        'frmLogIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(406, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.marqueeCarga)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLogIn"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido a Everest 2010"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Declare Sub EncriptaHex Lib "encriptadll.dll" Alias "?EncriptaHex@Encripta@@QAEXPAD0@Z" _
    (ByVal sEntrada As String, ByVal sSalida As String)

    Dim mEsLoginCorrecto As Boolean
    'Ariel-->
    'Dim Archivo As String = "C:\Archivos de Programa\MPG\Quetool\Perfiles\"
    '-->Ariel
    Dim U As New Usuario
    Dim p As Usuario

    Public Property EsLoginCorrecto() As Boolean
        Get
            Return mEsLoginCorrecto
        End Get
        Set(ByVal Value As Boolean)
            mEsLoginCorrecto = Value
        End Set
    End Property

    Private Sub BuscarCarpeta()
        Dim D As System.IO.Directory
        'Ariel-->
        Try
            D.GetDirectories(FuncionesRuta.RutaAppDataUsuarioPerfiles)
        Catch ex As System.IO.DirectoryNotFoundException
            D.CreateDirectory(FuncionesRuta.RutaAppDataUsuarioPerfiles)
        End Try
        '-->Ariel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'guarda el nombre de usuario
        'Ariel-->
        Dim XML As New AMS.Profile.Xml(FuncionesRuta.RutaAppDataUsuarioPerfiles & "usuario.xml")
        '-->Ariel
        ''AGREGAR OBJETO USUARIO

        XML.SetValue("login", "usuario", txtUsuario.Text)

        Me.EsLoginCorrecto = False

        If txtUsuario.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Usuario")
            Exit Sub
        End If

        If txtContraseña.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar la Contraseña")
            Exit Sub
        End If

        HabilitarControles(False, "Ingresando al MMS...")
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.marqueeCarga.Enabled = False

        Me.BuscarCarpeta()

        'Ariel-->
        Dim XML As New AMS.Profile.Xml(FuncionesRuta.RutaAppDataUsuarioPerfiles & "usuario.xml")
        '-->Ariel

        txtUsuario.Text = XML.GetValue("login", "usuario")

        If txtUsuario.Text <> "" Then
            txtContraseña.Select()
        End If


    End Sub

    Private Sub txtContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnAceptar_Click(Me, New System.EventArgs)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Login()
        U.Login = txtUsuario.Text
        p = U.ValidarUsuario(txtUsuario.Text, txtContraseña.Text)
    End Sub

    Private Sub TraerSoportes()
        Dim OMsl As New Maestros
        Dim OSop As New MPG.DBL.Soportes

        Activo.DTSoportesCache = OSop.ObtenerSoportesMMSVistaMaterializada(MSL.Constantes.COD_PAIS_ARGENTINA)
        'Activo.DTSoportesCache = OMsl.ObtenerSoportes(MSL.Constantes.COD_PAIS_ARGENTINA)
    End Sub

    Private Sub HabilitarControles(ByVal habilitado As Boolean, ByVal accion As String)

        marqueeCarga.Enabled = Not habilitado
        marqueeCarga.Text = accion
        marqueeCarga.Properties.ShowTitle = Not habilitado

        txtUsuario.Enabled = habilitado
        txtContraseña.Enabled = habilitado
        btnAceptar.Enabled = habilitado
        btnSalir.Enabled = habilitado

    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Call Login()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        HabilitarControles(True, "")

        If Not p Is Nothing Then
            HabilitarControles(False, "Obteniendo datos...")
            BackgroundWorker2.RunWorkerAsync()
            Dim dtSoportes As New DataTable()
            ''dtSoportes = OMsl.ObtenerSoportes(32)

            With U
                Activo.IDUsuario = p.IDUsuario
                Activo.Login = p.Login
                Activo.PassWd = p.PassWd
                Activo.Nombre = p.Nombre
                Activo.Apellido1 = p.Apellido1
                Activo.Apellido2 = p.Apellido2
                Activo.IDPerfil_Datos = p.IDPerfil_Datos
                Activo.CodCapacidad = 6
            End With

        Else
            txtContraseña.Text = ""
            HabilitarControles(True, "")
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        TraerSoportes()
        
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Me.EsLoginCorrecto = True
        Me.Close()
    End Sub
End Class

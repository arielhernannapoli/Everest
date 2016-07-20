Imports System.Data.OleDb
Imports System.IO

Public Class frmProgresoCargaGrilla
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
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents pgbProgreso1 As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.pgbProgreso1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(8, 11)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(240, 16)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Cargando Herramienta de Planificación..."
        '
        'pgbProgreso1
        '
        Me.pgbProgreso1.Location = New System.Drawing.Point(8, 35)
        Me.pgbProgreso1.Name = "pgbProgreso1"
        Me.pgbProgreso1.Size = New System.Drawing.Size(328, 8)
        Me.pgbProgreso1.TabIndex = 3
        '
        'frmProgresoCargaGrilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 54)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbProgreso1)
        Me.Controls.Add(Me.lblMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProgresoCargaGrilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private mMin1 As Integer
    Private mMax1 As Long
    Private mTexto As String
    Shared mInstancia As frmProgresoCargaGrilla
    Public Sub Reset()
        Me.pgbProgreso1.Maximum = 0
    End Sub
    Public Shared Property Instancia() As frmProgresoCargaGrilla
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmProgresoCargaGrilla
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As frmProgresoCargaGrilla)
            mInstancia = Value
        End Set
    End Property

    Public Property Texto() As String
        Get
            Return mTexto
        End Get
        Set(ByVal Value As String)
            mTexto = Value
            Me.lblMensaje.Text = Value
        End Set
    End Property
    Public Property Min1() As Integer
        Get
            Return mMin1
        End Get
        Set(ByVal Value As Integer)
            mMin1 = Value
            Me.pgbProgreso1.Minimum = Value
        End Set
    End Property
    Public Property Max1() As Long
        Get
            Return mMax1
        End Get
        Set(ByVal Value As Long)
            mMax1 = Value
            Me.pgbProgreso1.Maximum = Value
        End Set
    End Property

    Public Sub Incrementar(ByVal Valor As Integer)
        Me.pgbProgreso1.Value += Valor
    End Sub
    Private Sub frmProgresoCargaGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Instancia = Me

    End Sub

    Private Sub pgbProgreso1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pgbProgreso1.Click

    End Sub
End Class

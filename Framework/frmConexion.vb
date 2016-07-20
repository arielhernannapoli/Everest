Public Class frmConexion
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
    Friend WithEvents lblConexiones As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblConexiones = New System.Windows.Forms.Label
        Me.lblEstado = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conexiones"
        '
        'lblConexiones
        '
        Me.lblConexiones.AutoSize = True
        Me.lblConexiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexiones.ForeColor = System.Drawing.Color.Red
        Me.lblConexiones.Location = New System.Drawing.Point(104, 4)
        Me.lblConexiones.Name = "lblConexiones"
        Me.lblConexiones.Size = New System.Drawing.Size(15, 22)
        Me.lblConexiones.TabIndex = 1
        Me.lblConexiones.Text = "0"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Red
        Me.lblEstado.Location = New System.Drawing.Point(72, 28)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(57, 22)
        Me.lblEstado.TabIndex = 3
        Me.lblEstado.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado"
        '
        'frmConexion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(136, 53)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblConexiones)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(870, 650)
        Me.Name = "frmConexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Conexión"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared mInstancia As frmConexion

    Public Shared Property Instancia() As frmConexion
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmConexion
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As frmConexion)
            mInstancia = Value
        End Set
    End Property

    Public Sub Sumar()
        lblConexiones.Text = CInt(Me.lblConexiones.Text) + 1
    End Sub

    Public Sub Estado(ByVal e As String)
        Me.lblEstado.Text = e
    End Sub

    Private Sub frmConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Instancia = Me
    End Sub
End Class

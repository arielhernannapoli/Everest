Public Class FrmVigencia
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
    Friend WithEvents DtpFInicio As QUETOOL.dtpFecha
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.DtpFInicio = New QUETOOL.dtpFecha
        Me.cmdAceptar = New System.Windows.Forms.Button
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpFInicio
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.DtpFInicio.Appearance = Appearance1
        Me.DtpFInicio.FlatMode = True
        Me.DtpFInicio.Location = New System.Drawing.Point(8, 8)
        Me.DtpFInicio.Name = "DtpFInicio"
        Me.DtpFInicio.Size = New System.Drawing.Size(168, 21)
        Me.DtpFInicio.TabIndex = 15
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(96, 40)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 16
        Me.cmdAceptar.Text = "Aceptar"
        '
        'FrmVigencia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(178, 66)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.DtpFInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmVigencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio De Vigencia"
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private mFecha As Date
    Private mcerrado As Boolean = True
    Private mFechaInicio As Date

    Public Property IdTarifa() As Date
        Get
            Return mFechaInicio
        End Get
        Set(ByVal Value As Date)
            mFechaInicio = Value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return mFecha
        End Get
        Set(ByVal Value As Date)
            mFecha = Value
        End Set
    End Property
    Public Property Cerrado() As Boolean
        Get
            Return mcerrado
        End Get
        Set(ByVal Value As Boolean)
            mcerrado = Value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        mcerrado = False
        mFecha = Me.DtpFInicio.Value

        Me.Close()
    End Sub
End Class

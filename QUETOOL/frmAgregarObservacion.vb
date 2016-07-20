Public Class frmAgregarObservacion
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
    Friend WithEvents txtObservacion As QUETOOL.txtTexto
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.txtObservacion = New QUETOOL.txtTexto
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(397, 237)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(474, 237)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Salir"
        '
        'txtObservacion
        '
        Me.txtObservacion.AcceptsReturn = True
        Me.txtObservacion.AcceptsTab = True
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.ConDecimal = False
        Me.txtObservacion.Location = New System.Drawing.Point(5, 8)
        Me.txtObservacion.Maximo = 0
        Me.txtObservacion.MaxLength = 255
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(544, 224)
        Me.txtObservacion.SoloLetra = False
        Me.txtObservacion.SoloNumero = False
        Me.txtObservacion.TabIndex = 0
        Me.txtObservacion.Text = ""
        '
        'frmAgregarObservacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(556, 264)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarObservacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observación"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mObservaciones As String
#End Region

#Region "Propiedades Publicas"
    Public Property Observaciones()
        Get
            Return mObservaciones
        End Get
        Set(ByVal Value)
            mObservaciones = Value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmAgregarObservacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtObservacion.Text = mObservaciones
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        mObservaciones = txtObservacion.Text.Trim
        Me.Close()
    End Sub
#End Region

End Class

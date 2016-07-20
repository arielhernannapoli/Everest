Public Class frmMessage

    Private _messageTitle As String
    Public Property Title() As String
        Get
            Return _messageTitle
        End Get
        Set(ByVal value As String)
            _messageTitle = value
        End Set
    End Property

    Private _messageBody As String
    Public Property Body() As String
        Get
            Return _messageBody
        End Get
        Set(ByVal value As String)
            _messageBody = value
        End Set
    End Property

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmMessage_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.lblTitle.Text = Me.Title
        Me.txtResultados.Text = Me.Body
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

End Class
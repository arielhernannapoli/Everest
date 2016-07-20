Public Class frmPAPCAsignados

    Dim mDescripcion As String

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal value As String)
            mDescripcion = value
        End Set

    End Property

    Private Sub frmPAPCAsignados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtdescripcion.Text = FormatearRegistros(Me.mDescripcion)
    End Sub

    Private Sub btosalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btosalir.Click
        Me.Close()
    End Sub

    Private Function FormatearRegistros(ByVal Trama As String)

        Dim TramaSeparadaNivel1() As String
        Dim TramaSeparadaNivel2() As String
        Dim Resultado As String
        Dim i As Integer

        TramaSeparadaNivel1 = Trama.Split("|")
        Resultado = TramaSeparadaNivel1(0) + vbCrLf
        For i = 0 To TramaSeparadaNivel1.Length - 1
            If i > 0 Then
                Resultado += TramaSeparadaNivel1(i).Replace("=", "|").ToString.Trim + vbCrLf
            End If
        Next

        Return Resultado

    End Function
End Class
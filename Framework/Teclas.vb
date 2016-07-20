
Public Class Teclas
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer

    Public Shared Function CapsActivado() As Boolean
        Dim iKeyState As Integer
        iKeyState = GetKeyState(20)
        CapsActivado = (iKeyState = 1 Or iKeyState = -127)
    End Function
End Class

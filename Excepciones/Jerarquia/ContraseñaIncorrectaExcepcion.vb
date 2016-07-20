Public Class ContraseñaIncorrectaExcepcion
    Inherits SeguridadExcepcion

    Sub New(ByVal Mensaje As String)
        MyBase.New(Mensaje)
    End Sub
End Class

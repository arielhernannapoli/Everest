Public Class Contrase�aIncorrectaExcepcion
    Inherits SeguridadExcepcion

    Sub New(ByVal Mensaje As String)
        MyBase.New(Mensaje)
    End Sub
End Class

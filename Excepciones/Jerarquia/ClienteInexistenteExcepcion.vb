Public Class ClienteInexistenteExcepcion
    Inherits NegocioExcepcion

    Sub New(ByVal Mensaje As String)
        MyBase.New(Mensaje)
    End Sub
End Class

Public Class UsuarioConexion
    Private Declare Sub DesencriptaHex Lib "encriptadll.dll" Alias "?DesencriptaHex@Encripta@@QAEXPAD0@Z" _
    (ByVal sEntrada As String, ByVal sSalida As String)

    Public Function DesencriptarContrase�a(ByVal Contrase�aEncriptada As String) As String
        'hay que cargar los 16 espacios que puede tener la contrase�a desencriptada
        Dim Salida As String = "0123456789123456"

        DesencriptaHex(Contrase�aEncriptada, Salida)

        Dim Contrase�a As String

        'recorre todos los caracteres de la contrase�a desencriptada
        For i As Integer = 0 To Salida.Length

            'cuando encuentra un caracter nothing, significa que se termino la contrase�a real
            ', el resto de los caracteres, son los de relleno ("123456789123456")
            If Not Salida.Chars(i) = Nothing Then
                Contrase�a &= Salida.Chars(i)
            Else
                Return Contrase�a
            End If
        Next

        Return Contrase�a
    End Function
End Class
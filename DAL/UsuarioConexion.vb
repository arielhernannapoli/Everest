Public Class UsuarioConexion
    Private Declare Sub DesencriptaHex Lib "encriptadll.dll" Alias "?DesencriptaHex@Encripta@@QAEXPAD0@Z" _
    (ByVal sEntrada As String, ByVal sSalida As String)

    Public Function DesencriptarContraseña(ByVal ContraseñaEncriptada As String) As String
        'hay que cargar los 16 espacios que puede tener la contraseña desencriptada
        Dim Salida As String = "0123456789123456"

        DesencriptaHex(ContraseñaEncriptada, Salida)

        Dim Contraseña As String

        'recorre todos los caracteres de la contraseña desencriptada
        For i As Integer = 0 To Salida.Length

            'cuando encuentra un caracter nothing, significa que se termino la contraseña real
            ', el resto de los caracteres, son los de relleno ("123456789123456")
            If Not Salida.Chars(i) = Nothing Then
                Contraseña &= Salida.Chars(i)
            Else
                Return Contraseña
            End If
        Next

        Return Contraseña
    End Function
End Class
Public Class MapeoColores
    Dim mColorConFoco As Color
    Dim mLetraConFoco As Color

    Public Property ColorConFoco() As Color
        Get
            Return mColorConFoco
        End Get
        Set(ByVal Value As Color)
            mColorConFoco = Value
        End Set
    End Property

    Public Property LetraConFoco() As Color
        Get
            Return mLetraConFoco
        End Get
        Set(ByVal Value As Color)
            mLetraConFoco = Value
        End Set
    End Property

    Public Sub GuardarColores(ByVal ColorFoco As Color, ByVal LetraFoco As Color)
        Dim ini As New AMS.Profile.Ini

        ini.SetValue("Colores", "ColorConFoco", ColorFoco.ToArgb)
        ini.SetValue("Colores", "LetraConFoco", LetraFoco.ToArgb)

        ini = Nothing
    End Sub

    Public Sub LeerColores()
        Dim ini As New AMS.Profile.Ini

        mColorConFoco = mColorConFoco.FromArgb(ini.GetValue("Colores", "ColorConFoco"))
        mLetraConFoco = mLetraConFoco.FromArgb(ini.GetValue("Colores", "LetraConFoco"))

        ini = Nothing
    End Sub
End Class

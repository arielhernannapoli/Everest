'Imports System.Environment
'Ariel-->
Module FuncionesRuta

    Public ReadOnly Property RutaAppDataUsuarioPerfiles() As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Quetool\Perfiles\"
        End Get
    End Property

    Public ReadOnly Property RutaAppDataUsuarioQuetool() As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Quetool\"
        End Get
    End Property

    Public ReadOnly Property RutaAppDataUsuario() As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        End Get
    End Property

    Private ReadOnly Property RutaAplicacion() As String
        Get
            Return Application.StartupPath()
        End Get
    End Property

    Public ReadOnly Property RutaPerfiles() As String
        Get
            Return RutaAplicacion & "\Perfiles\"
        End Get
    End Property

    Public ReadOnly Property RutaAudCable() As String
        Get
            Return RutaAplicacion & "\AudCable\"
        End Get
    End Property
    Public ReadOnly Property RutaAudInterior() As String
        Get
            Return RutaAplicacion & "\AudInterior\"
        End Get
    End Property

    Public Sub TomaArchivoDesdeRed(ByVal urlOrigen As String, ByVal urlDestino As String)
        My.Computer.FileSystem.CopyFile(urlOrigen, urlDestino, True)
    End Sub
End Module

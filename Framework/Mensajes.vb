'Muestra un MsgBox en base a los parametros que se pasan, con esta clase se simplifica
'llamar a un mensaje, solo requiere 3 parametros
Public Enum TipoMensaje As Byte
    SiNo = 1
    DeError = 2
    Informacion = 3
    SiNoCancelar = 4
End Enum

Public Class Mensajes
    Public Shared Function MensajeErrorInterno(ByVal e As Exception, Optional ByVal Procedimiento As String = "") As MsgBoxResult
        'Dim F As New frmError()

        'GuardarError(e, Procedimiento)

        'F.Procedimiento = Procedimiento
        'F.Escepcion = e

        'manda un mail reportando el error
        'Dim Mail As New email.Mail()

        'Mail.EnviarMail("Karina@inta.gov.ar", "esteban", _
        '"www.cerebrodigital.com.ar", "esteban@cerebrodigital.com.ar", _
        '"Error " & Date.Now, F.Procedimiento & vbCrLf & e.Message & vbCrLf & e.StackTrace)

        'F.ShowDialog()
    End Function

    Private Shared Sub GuardarError(ByVal e As Exception, Optional ByVal Procedimiento As String = "")
        Dim Escribir = System.IO.File.AppendText(Application.StartupPath & "\Errores.txt")

        Escribir.WriteLine("Fecha: " & Date.Now) 'fecha
        Escribir.WriteLine("Procedimiento: " & Procedimiento) 'procedimiento
        Escribir.WriteLine("Descripción: " & e.Message) 'mensaje de error
        Escribir.WriteLine("Origen: " & e.StackTrace & vbCrLf) 'origen

        Escribir.Close()

        Escribir = Nothing
    End Sub

    Public Shared Function Mensaje(ByVal Texto As String, Optional ByVal TipoMensaje As TipoMensaje = TipoMensaje.Informacion, Optional ByVal BotonDefecto As MessageBoxDefaultButton = MessageBoxDefaultButton.Button2) As DialogResult
        Dim Botones As MessageBoxButtons
        Dim Icono As MessageBoxIcon

        'configura los parametros
        Select Case TipoMensaje
            Case TipoMensaje.SiNo
                Botones = MessageBoxButtons.YesNo
                Icono = MessageBoxIcon.Question
                BotonDefecto = MessageBoxDefaultButton.Button2

            Case TipoMensaje.DeError
                Botones = MessageBoxButtons.OK
                Icono = MessageBoxIcon.Error

            Case TipoMensaje.Informacion
                Botones = MessageBoxButtons.OK
                Icono = MessageBoxIcon.Information

            Case TipoMensaje.SiNoCancelar
                Botones = MessageBoxButtons.YesNoCancel
                Icono = MessageBoxIcon.Question
                BotonDefecto = MessageBoxDefaultButton.Button3

        End Select

        'muestra el mensaje
        Return MessageBox.Show(Texto, "Everest v." & Application.ProductVersion, Botones, Icono, BotonDefecto)
    End Function
End Class

Imports Framework.Mensajes
Imports HM.Comun.Varios
Imports HM.Contratos.Entidad.Seguridad
Imports HM.MMS.AR.Client.Reportes
Imports HM.MMS.AR.Utils
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text.RegularExpressions

Public Class frmMailFax
    Dim mParametros As String
    Dim mContrato As Integer
    Dim agente As New UsuarioAgente
    Dim usuario As UsuarioEntidad = agente.ObtenerUsuarioActivo()
    Dim rutaContrato As String
    Dim envioExitoso As Boolean
    Dim mensajeMail As New System.Text.StringBuilder()
    Dim cuerpo As String

#Region "Propiedades"
    Public Property Parametros() As String
        Get
            Return mParametros
        End Get
        Set(ByVal Value As String)
            mParametros = Value
        End Set
    End Property

    Public Property Contrato() As Integer
        Get
            Return mContrato
        End Get
        Set(ByVal Value As Integer)
            mContrato = Value
        End Set
    End Property
#End Region

    Private Sub frmMailFax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InicializarControles()
    End Sub

    Private Sub InicializarControles()
        Dim datos As String() = Parametros.Split(New Char() {"|"c}, StringSplitOptions.RemoveEmptyEntries)
        Dim asunto As String = "Envio orden de publicidad - OP Nº: " + Contrato.ToString() + " / " + datos(0)
        mensajeMail.Append("{\rtf1\ansi")
        mensajeMail.Append("{\colortbl;\red0\green0\blue0;\red255\green0\blue0;}")
        mensajeMail.Append("Cliente: ")
        mensajeMail.Append(datos(1))
        mensajeMail.Append("\par Campaña: ")
        mensajeMail.Append(datos(2))
        mensajeMail.Append("\par Período: desde ")
        mensajeMail.Append(datos(3))
        mensajeMail.Append(" hasta ")
        mensajeMail.Append(datos(4))
        mensajeMail.Append("\par URL de destino o código de trakeo:")
        mensajeMail.Append("\par Detalle: horas/días/impresiones/clicks (lo que se haya contratado) x formato")
        mensajeMail.Append("\par Materiales:")
        mensajeMail.Append("\par Orden (con código avisador y número de cuenta para La Nación) + print de SGP para Clarín.")
        mensajeMail.Append("\par \par  \b Nota:")
        mensajeMail.Append("\par Por disposición del cliente, vamos a implementar trackeo de impresiones y clicks para formatos Rich Media y códigos de Servido para formatos Tradicionales a través de DoubleClick.")
        mensajeMail.Append("\par Les pedimos que utilicen el código de formato <IFRAME SRC=...> para servir las piezas desde Doubleclick.")
        mensajeMail.Append("\par Ante cualquier duda con respecto a la implementación de los mismos no duden en consultarnos.")
        mensajeMail.Append("\par Insistimos en esto ya que ante un error en la implementación, el medio deberá hacerse cargo de los costos correspondientes.")
        mensajeMail.Append("\par A su vez, dado que el cliente solo considerará los valores reportados por el adserver de DoubleClick, se le otorgará al medio un acceso correspondiente para que pueda corroborar las diferencias entre este adserver y el propio. En caso de diferencias mayores al 10%, el medio deberá entregar impresiones de más hasta compensar la diferencia")
        mensajeMail.Append("\b0 ")
        mensajeMail.Append(".")
        mensajeMail.Append("\cf2")
        mensajeMail.Append("\par \par Le informamos que a partir del 01 de Marzo de 2014, ")
        mensajeMail.Append(" \b todas las órdenes de publicidad deberán estar respaldadas por su correspondiente certificación")
        mensajeMail.Append(" \b0 ")
        mensajeMail.Append(". La misma deberá ser entregada junto con la facturación y enviada al responsable de la cuenta que haya realizado la implementación de la misma. Las órdenes de publicidad que no reciban dicho respaldo, ")
        mensajeMail.Append(" \b no podrán ser pagadas\b0 .")
        mensajeMail.Append("}")
        Dim mailUsuario As String = ObtenerMailUsuario()
        rutaContrato = "C:\Temp\" + datos(5) + ".pdf"
        Me.mpbEnvioMail.Enabled = False
        txtAsunto.Text = asunto
        txtMensaje.Rtf = mensajeMail.ToString()
        txtDe.Text = mailUsuario
        txtCC.Text = mailUsuario
    End Sub

    Private Function Validar() As Boolean
        If txtDe.Text = String.Empty Then
            Mensaje("Debe ingresar su correo electronico.", TipoMensaje.Informacion)
            Return False
        End If
        If txtPara.Text = String.Empty Then
            Mensaje("Debe ingresar el correo electronico del destinatario.", TipoMensaje.Informacion)
            Return False
        End If
        If txtAsunto.Text = String.Empty Then
            Mensaje("Debe ingresar el asunto.", TipoMensaje.Informacion)
            Return False
        End If
        If txtMensaje.Text = String.Empty Then
            Mensaje("Debe ingresar un mensaje.", TipoMensaje.Informacion)
            Return False
        End If
        If Not ValidarMails(txtPara.Text) Then
            Mensaje("Formato de mail PARA incorrecto.", TipoMensaje.Informacion)
            Return False
        End If
        If Not ValidarMails(txtPara.Text) Then
            Mensaje("Formato de mail CC incorrecto.", TipoMensaje.Informacion)
            Return False
        End If
        Return True
    End Function

    Private Function ValidarMails(ByVal pMails As String) As Boolean
        Dim esValido As Boolean = False
        Dim mails As List(Of String) = pMails.Split(New Char() {";"c}, StringSplitOptions.RemoveEmptyEntries).ToList()
        If mails.Count > 0 Then
            esValido = True
            For Each mail As String In mails
                If esValido Then
                    esValido = Regex.IsMatch(mail.Trim(), "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                Else
                    Exit For
                End If
            Next
        End If
        Return esValido
    End Function

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If Me.Validar Then
            btnEnviar.Enabled = False
            btnCancelar.Enabled = False
            mpbEnvioMail.Enabled = True
            mpbEnvioMail.Text = "Enviando mail..."
            cuerpo = Me.ConvertToHTML(txtMensaje)
            mpbEnvioMail.Properties.ShowTitle = True
            BackgroundWorkerEnvio.WorkerReportsProgress = True
            BackgroundWorkerEnvio.WorkerSupportsCancellation = True
            BackgroundWorkerEnvio.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorkerEnvio_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles BackgroundWorkerEnvio.DoWork
        Try
            Dim mail As New Mail()
            'Dim cuerpo As String = txtMensaje.Text
            Dim adjuntoContrato As New Attachment(rutaContrato, MediaTypeNames.Application.Pdf)
            Dim dispositionContrato As ContentDisposition = adjuntoContrato.ContentDisposition
            Dim mails As List(Of String) = txtPara.Text.Split(New Char() {";"c}, StringSplitOptions.RemoveEmptyEntries).ToList()
            mail.From = txtDe.Text
            For Each mailPara As String In mails
                mail.To = mailPara
            Next
            mails = txtCC.Text.Split(New Char() {";"c}, StringSplitOptions.RemoveEmptyEntries).ToList()
            For Each mailCC As String In mails
                mail.To = mailCC
            Next
            dispositionContrato.CreationDate = File.GetCreationTime(rutaContrato)
            dispositionContrato.ModificationDate = File.GetLastWriteTime(rutaContrato)
            dispositionContrato.ReadDate = File.GetLastAccessTime(rutaContrato)
            mail.AddAttachment(adjuntoContrato)
            If txtAdjunto.Text.Length > 0 Then
                Dim adjuntoRuta As String = txtAdjunto.Text
                Dim adjunto As New Attachment(adjuntoRuta)
                Dim disposition As ContentDisposition = adjunto.ContentDisposition
                disposition.CreationDate = File.GetCreationTime(adjuntoRuta)
                disposition.ModificationDate = File.GetLastWriteTime(adjuntoRuta)
                disposition.ReadDate = File.GetLastAccessTime(adjuntoRuta)
                mail.AddAttachment(adjunto)
            End If
            mail.Subject = txtAsunto.Text
            'cuerpo = cuerpo.Replace("{\rtf1\ansi", "")
            'cuerpo = cuerpo.Replace("{\colortbl;\red0\green0\blue0;\red255\green0\blue0;}", "")
            'cuerpo = cuerpo.Replace("\b0 ", "</b>")
            'cuerpo = cuerpo.Replace("\b ", "<b>")
            'cuerpo = cuerpo.Replace("\cf2", "<font color=#C80000>")
            'cuerpo = cuerpo.Replace("}", "</font>")
            'cuerpo = cuerpo.Replace("\par ", "<br>")
            mail.Body = cuerpo
            mail.isHTML = True
            mail.Send()
            envioExitoso = True
        Catch ex As Exception
            envioExitoso = False
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Sub

    Public Function ConvertToHTML(ByVal Box As RichTextBox) As String
        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim strFont As String
        Dim shtSize As Short
        Dim lngOriginalStart As Long
        Dim lngOriginalLength As Long
        Dim intCount As Integer
        ' If nothing in the box, exit
        If Box.Text.Length = 0 Then Exit Function
        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Box.TextLength
        Box.Select(0, 1)
        ' Add HTML header
        strHTML = "<html>"
        ' Set up initial parameters
        strColour = Box.SelectionColor.ToKnownColor.ToString
        blnBold = Box.SelectionFont.Bold
        blnItalic = Box.SelectionFont.Italic
        strFont = Box.SelectionFont.FontFamily.Name
        shtSize = Box.SelectionFont.Size
        ' Include first 'style' parameters in the HTML
        strHTML += "<span style=""font-family: " & strFont & _
          "; font-size: " & shtSize & "pt; color: " _
                          & strColour & """>"
        ' Include bold tag, if required
        If blnBold = True Then
            strHTML += "<b>"
        End If
        ' Include italic tag, if required
        If blnItalic = True Then
            strHTML += "<i>"
        End If
        ' Finally, add our first character
        strHTML += Box.Text.Substring(0, 1)
        ' Loop around all remaining characters
        For intCount = 2 To Box.Text.Length
            ' Select current character
            Box.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Box.Text.Substring(intCount - 1, 1) = _
                   Convert.ToChar(10) Then
                strHTML += "<br>"
            End If
            ' Check/implement any changes in style
            If Box.SelectionColor.ToKnownColor.ToString <> strColour Or Box.SelectionFont.FontFamily.Name _
               <> strFont Or Box.SelectionFont.Size <> shtSize _
               Then
                strHTML += "</span><span style=""font-family: " _
                  & Box.SelectionFont.FontFamily.Name & _
                  "; font-size: " & Box.SelectionFont.Size & _
                  "pt; color: " & _
                  Box.SelectionColor.ToKnownColor.ToString & """>"
            End If
            ' Check for bold changes
            If Box.SelectionFont.Bold <> blnBold Then
                If Box.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If
            End If
            ' Check for italic changes
            If Box.SelectionFont.Italic <> blnItalic Then
                If Box.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If
            ' Add the actual character
            strHTML += Mid(Box.Text, intCount, 1)
            ' Update variables with current style
            strColour = Box.SelectionColor.ToKnownColor.ToString
            blnBold = Box.SelectionFont.Bold
            blnItalic = Box.SelectionFont.Italic
            strFont = Box.SelectionFont.FontFamily.Name
            shtSize = Box.SelectionFont.Size
        Next
        ' Close off any open bold/italic tags
        If blnBold = True Then strHTML += ""
        If blnItalic = True Then strHTML += ""
        ' Terminate outstanding HTML tags
        strHTML += "</span></html>"
        ' Restore original RichTextBox selection
        Box.Select(lngOriginalStart, lngOriginalLength)
        ' Return HTML
        Return strHTML
    End Function

    Private Sub BackgroundWorkerEnvio_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerEnvio.RunWorkerCompleted
        mpbEnvioMail.Enabled = False
        mpbEnvioMail.Text = String.Empty
        btnCancelar.Enabled = True
        btnEnviar.Enabled = True
        If e.Cancelled Then
            Mensaje("Se canceló el envío", TipoMensaje.DeError)
        Else
            If envioExitoso Then
                Mensaje("E-mail enviado con éxito. Verifique el envío del contrato en su dirección de correo electrónico", TipoMensaje.Informacion)
                Me.Close()
            End If
        End If

    End Sub

    Public Function ObtenerMailUsuario() As String
        Dim mail As String = String.Empty
        Dim parametos As New Dictionary(Of String, Object)
        Dim dt As DataTable
        parametos.Add("cod_usuario", usuario.CodUsuario)
        dt = Sqlhelper.ExecuteProcedure("PKG_AR_USUARIO", "SELECT_FROM_MAIL", "Data", parametos)
        If dt.Rows.Count > 0 Then
            mail = dt.Rows(0).Item("mail_usuario").ToString()
            btnEnviar.Enabled = True
        End If
        Return mail
    End Function

    Private Sub btnEliminarAdjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAdjunto.Click
        Try
            txtAdjunto.Text = String.Empty
        Catch ex As Exception
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Sub

    Private Sub btnBuscarAdjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAdjunto.Click
        Try
            mpbEnvioMail.Enabled = True
            mpbEnvioMail.Text = "Cargando Adjunto..."
            mpbEnvioMail.Properties.ShowTitle = True

            BackgroundWorkerAdjunto.WorkerReportsProgress = True
            BackgroundWorkerAdjunto.WorkerSupportsCancellation = True
            BackgroundWorkerAdjunto.RunWorkerAsync()
        Catch ex As Exception
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Sub

    Private Sub BackgroundWorkerAdjunto_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles BackgroundWorkerAdjunto.DoWork

    End Sub

    Private Sub BackgroundWorkerAdjunto_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerAdjunto.RunWorkerCompleted
        Try

            OpenFileDialog.InitialDirectory = "C:\"
            OpenFileDialog.CheckFileExists = True
            OpenFileDialog.Multiselect = False
            OpenFileDialog.Title = "Seleccione un archivo"
            If OpenFileDialog.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
                txtAdjunto.Text = OpenFileDialog.FileName

            End If
            mpbEnvioMail.Enabled = False
            mpbEnvioMail.Text = String.Empty
        Catch ex As Exception
            mpbEnvioMail.Enabled = False
            mpbEnvioMail.Text = String.Empty
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnVerOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerOP.Click
        Try
            Process.Start(rutaContrato)
        Catch ex As Exception
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Sub

End Class
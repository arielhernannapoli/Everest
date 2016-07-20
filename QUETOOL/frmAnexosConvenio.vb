Imports System.IO
Imports System.Collections.Generic
Imports System.Drawing
Imports Infragistics.Win.UltraWinGrid

#Region "Enumeradores"
Public Enum ModoPantallaAnexos
    Edicion
    Visualizacion
End Enum
#End Region

Public Class frmAnexosConvenio

#Region "Miembros Privados"
    Private mExtensionArchivo As List(Of String) = New List(Of String)(New String() {".bmp", ".gif", ".jpg", ".jpeg", ".pdf"})
#End Region

#Region "Propiedades"
    Private mAnexos As List(Of AnexoConvenio)
    Private mModoPantalla As ModoPantallaAnexos

    Public Property Anexos() As List(Of AnexoConvenio)
        Get
            Return mAnexos
        End Get
        Set(ByVal value As List(Of AnexoConvenio))
            mAnexos = value
        End Set
    End Property

    Public Property ModoPantalla() As ModoPantallaAnexos
        Get
            Return mModoPantalla
        End Get
        Set(ByVal value As ModoPantallaAnexos)
            mModoPantalla = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub lnkAnexarArchivo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAnexarArchivo.LinkClicked
        Dim x As Integer
        Dim r As DialogResult
        Dim f As New OpenFileDialog
        f.Multiselect = True
        f.Filter = "Image Files (*.bmp, *.gif, *.jpg, *.jpeg)| *.bmp;*.gif;*.jpg;*.jpeg |Pdf Files (*.pdf) | *.pdf"
        r = f.ShowDialog()
        If r = Windows.Forms.DialogResult.OK Then
            For x = 0 To f.FileNames.Count - 1
                If mExtensionArchivo.Contains(Path.GetExtension(f.FileNames(x))) Then
                    Dim oAnexoConvenio As New AnexoConvenio
                    oAnexoConvenio.Bytes = File.ReadAllBytes(f.FileNames(x))
                    oAnexoConvenio.Extension = Path.GetExtension(f.FileNames(x))
                    oAnexoConvenio.NombreArchivo = Path.GetFileName(f.FileNames(x))
                    oAnexoConvenio.IdAnexo = Me.mAnexos.Count + 1
                    Me.mAnexos.Add(oAnexoConvenio)
                End If
            Next
            Me.ugAnexos.DataBind()
        End If
    End Sub

    Private Sub frmAnexosConvenio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pctImagen.Visible = False
        Me.pctImagen.SizeMode = PictureBoxSizeMode.AutoSize
        Me.pnlImage.Visible = False
        Me.pnlImage.AutoScroll = True
        Me.ugAnexos.DataSource = Me.Anexos

        If Me.ModoPantalla = ModoPantallaAnexos.Visualizacion Then
            Me.lnkAnexarArchivo.Visible = False
            Me.lnkAnexarDelPortapapeles.Visible = False
        End If

        Me.ugAnexos.DisplayLayout.Bands(0).Columns("Bytes").Hidden = True
        Me.ugAnexos.DisplayLayout.Bands(0).Columns("IdConvenio").Hidden = True
        Me.ugAnexos.DisplayLayout.Bands(0).Columns("Extension").Hidden = True

        Me.ugAnexos.DisplayLayout.Bands(0).Columns("NombreArchivo").Width = 300
    End Sub

    Private Sub optAnexarArchivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAnexarArchivos.CheckedChanged
        If optAnexarArchivos.Checked Then
            Me.ugAnexos.Visible = True
            Me.pctImagen.Visible = False
            Me.pnlImage.Visible = False
        End If
    End Sub

    Private Sub optVerImagen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVerImagen.CheckedChanged
        If optVerImagen.Checked Then
            For Each anexo As UltraGridRow In Me.ugAnexos.Rows
                If anexo.Selected Then
                    If anexo.Cells(1).Value.ToString() <> ".pdf" Then
                        Me.ugAnexos.Visible = False
                        Me.pctImagen.Visible = True
                        Me.pnlImage.Visible = True
                        Me.pctImagen.Image = Imagen.GetImageFromByteArray(anexo.Cells(0).Value)
                    Else
                        Dim bytes() As Byte = anexo.Cells(0).Value
                        Dim fileName As String = String.Format("{0}{1}.{2}", System.IO.Path.GetTempPath(), Guid.NewGuid().ToString(), ".pdf")
                        Dim f As New FileStream(fileName, FileMode.Create)
                        f.Write(bytes, 0, bytes.Length)
                        f.Close()
                        System.Diagnostics.Process.Start(fileName)
                        Me.optAnexarArchivos.Checked = True
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub lnkAnexarDelPortapapeles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAnexarDelPortapapeles.LinkClicked
        Dim vImagen As System.Drawing.Image
        vImagen = Clipboard.GetImage
        If Not vImagen Is Nothing Then
            Me.pctImagen.Image = vImagen
            Dim oAnexoConvenio As New AnexoConvenio
            oAnexoConvenio.Bytes = Imagen.GetByteArrayFromImage(vImagen, System.Drawing.Imaging.ImageFormat.Gif)
            oAnexoConvenio.Extension = ".gif"
            oAnexoConvenio.NombreArchivo = "CapturaPantalla.gif"
            oAnexoConvenio.IdAnexo = Me.mAnexos.Count + 1
            Me.mAnexos.Add(oAnexoConvenio)
            Me.ugAnexos.DataBind()
        End If
    End Sub
#End Region

#Region "Constructor"
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Anexos = New List(Of AnexoConvenio)
        Me.ModoPantalla = ModoPantallaAnexos.Edicion
    End Sub

    Public Sub New(ByVal modoPantalla As ModoPantallaAnexos)
        InitializeComponent()
        Me.Anexos = New List(Of AnexoConvenio)
        Me.ModoPantalla = modoPantalla
    End Sub
#End Region

End Class
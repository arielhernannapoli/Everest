Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports System.Xml
Imports System.IO
Public Class frmPerfiles

    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lstArchivos As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lstArchivos = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Perfiles"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(8, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(208, 2)
        Me.Label18.TabIndex = 91
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(136, 280)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 90
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(56, 280)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 89
        Me.cmdAceptar.Text = "Aceptar"
        '
        'lstArchivos
        '
        Me.lstArchivos.Location = New System.Drawing.Point(8, 24)
        Me.lstArchivos.Name = "lstArchivos"
        Me.lstArchivos.Size = New System.Drawing.Size(200, 238)
        Me.lstArchivos.TabIndex = 92
        '
        'frmPerfiles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(218, 306)
        Me.Controls.Add(Me.lstArchivos)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPerfiles"
        Me.Text = "Seleccionar Perfil."
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mGrid As UltraGrid
    Dim mRuta As String
    Dim Archivos() As String
    Dim GrillaFormato As New GrillaFormato

    Public Property Ruta() As String
        Get
            Return mRuta
        End Get
        Set(ByVal value As String)
            mRuta = Value
        End Set
    End Property

    Public Property Grid() As UltraGrid
        Get
            Return mGrid
        End Get
        Set(ByVal Value As UltraGrid)
            mGrid = Value
        End Set
    End Property
    Private Sub frmPerfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Archivos = Directory.GetFiles(Ruta)
        Catch ex As Exception
            Mensajes.Mensaje("frmPerfiles_Load" & ex.Message)
            Me.Close()
        End Try
        If Archivos.Length = 0 Then
            Mensajes.Mensaje("No hay perfiles guardados")
            Me.Close()
        Else
            CargarArchivos()
        End If

    End Sub
    Public Sub CargarArchivos()
        Dim file As String
        For Each s As String In Archivos
            file = Replace(Replace(s, Ruta, ""), ".xml", "")
            If file <> "usuario" Then
                lstArchivos.Items.Add(file)
            End If
        Next
    End Sub
    Private Sub CargarXML(ByVal Archivo As String)
        Dim Convertir As New System.Drawing.ColorConverter
        Dim Dom As New XmlDocument
        Dim i As Integer
        Dom.Load(Me.Ruta & Archivo & ".xml")
        Dim nPerfil As XmlNodeList = Dom.DocumentElement.ChildNodes
        Dim eIDs As XmlElement = Dom.DocumentElement
        Dim Campaña As Integer = CInt(eIDs.Attributes("campania").InnerText)
        Dim Sistema As Integer = CInt(eIDs.Attributes("sistema").InnerText)

        Dim Orden As UltraWinGrid.SortIndicator


        'If Not Campaña = Activo.IDCampaña Then
        '    Mensajes.Mensaje("Este Perfil no es Compatible con La campaña seleccionada")
        '    Exit Sub
        'End If

        'If Not Sistema = Activo.IDSistema Then
        '    Mensajes.Mensaje("Este Perfil no es Compatible con el sistema seleccionada")
        '    Exit Sub
        'End If
        Try
            For Each N As XmlNode In Dom.DocumentElement.ChildNodes
                With Grid.DisplayLayout.Bands(0)
                    '  If N.Attributes("key").InnerText.IndexOf("Banda") < 0 Then
                    .Columns(N.Attributes("key").InnerText).Width = CInt(N.FirstChild.InnerText)
                    .Columns(N.Attributes("key").InnerText).Header.VisiblePosition = CInt(N.FirstChild.NextSibling.InnerText)
                    .Columns(N.Attributes("key").InnerText).Header.Fixed = CBool(N.FirstChild.NextSibling.NextSibling.InnerText)
                    '.Columns(N(i).Attributes("sumatoria").InnerText).Header.VisiblePosition = CInt(N(i).FirstChild.NextSibling.NextSibling.NextSibling.InnerText)
                    .Columns(N.Attributes("key").InnerText).Hidden = CBool(N.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.InnerText)
                    .Columns(N.Attributes("key").InnerText).SortIndicator = ObtenerOrden(CInt(N.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText))
                    ' .Columns(N(i).Attributes("key").InnerText).Header.VisiblePosition = CInt(N(i).FirstChild.InnerText)
                    '.Columns(N(i).Attributes("key").InnerText).Header.VisiblePosition = CInt(N(i).FirstChild.InnerText)

                    '.Columns(N(i).Attributes("key").InnerText).Header.VisiblePosition = CInt(N(i).FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText)
                    If Not N.ChildNodes(8) Is Nothing Then
                        For i = 0 To (N.ChildNodes.Count) - 9
                            Grid.Rows(CInt(N.ChildNodes(8 + i).Attributes("fila").InnerText)).Cells(N.Attributes("key").InnerText).Appearance.BackColor = Convertir.ConvertFromString(N.ChildNodes(8 + i).FirstChild.InnerText)
                            Grid.Rows(CInt(N.ChildNodes(8 + i).Attributes("fila").InnerText)).Cells(N.Attributes("key").InnerText).Appearance.ForeColor = Convertir.ConvertFromString(N.ChildNodes(8 + i).FirstChild.NextSibling.InnerText)
                        Next
                    End If
                    ' i += 1
                    'If i = 69 Then
                    'Stop
                    'End If
                End With
            Next

        Catch e As Exception
            MsgBox("CargarXML " & e.Message)
        End Try

        GrillaFormato.ReocultarColumnasHijos(Grid)
    End Sub
    Private Function ObtenerOrden(ByVal orden As Int64) As UltraWinGrid.SortIndicator
        Select Case orden
            Case 1
                Return SortIndicator.Ascending
            Case 2
                Return SortIndicator.Descending
            Case 3
                Return SortIndicator.Disabled
            Case 0
                Return SortIndicator.None
        End Select
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        CargarXML(DirectCast(lstArchivos.SelectedItem, String))
        'Me.ShowDialog()
        Me.Close()
    End Sub
End Class

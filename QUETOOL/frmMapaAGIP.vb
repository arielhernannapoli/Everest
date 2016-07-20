Imports System.Net
Imports System.Net.Dns
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports System.Collections.Generic
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Xml.XPath

Public Class frmMapaAGIP
    Dim mCodigosAGIP As Dictionary(Of String, List(Of Detalle_AGIP))
    Dim latitud As Double = -34.6037069
    Dim longitud As Double = -58.3809568

#Region "Propiedadese"
    Public Property CodigosAGIP() As Dictionary(Of String, List(Of Detalle_AGIP))
        Get
            Return mCodigosAGIP
        End Get
        Set(ByVal Value As Dictionary(Of String, List(Of Detalle_AGIP)))
            mCodigosAGIP = Value
        End Set
    End Property
#End Region

    Private Sub frmMapaAGIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Mapa.MapProvider = MapProviders.GoogleMapProvider.Instance
        Mapa.MinZoom = 0
        Mapa.MaxZoom = 24
        Mapa.Zoom = 12
        Mapa.DragButton = Windows.Forms.MouseButtons.Left
        AddHandler Mapa.OnMarkerClick, AddressOf MarkerClick
        Me.AgregarMarcadoresProvincia()
        Me.AgregarMarcadores()
        Me.MostrarCheckCapas()

    End Sub

    Private Sub AgregarMarcadores()
        Dim i As Integer = 0
        Dim color() As Integer = {2, 8, 18, 21, 24, 27, 31, 13, 4, 10, 19, 23, 25, 33, 15, 36, 3, 6, 7, 9, 22, 28, 32, 37, 14, 5, 11, 20, 26, 30, 34, 17}
        For Each par As KeyValuePair(Of String, List(Of Detalle_AGIP)) In CodigosAGIP
            Dim capa As New GMapOverlay(par.Key)
            For Each detalleAGIP As Detalle_AGIP In par.Value
                If detalleAGIP.Provincia = "Capital Federal" Then
                    Dim dtCoordenadas As DataTable
                    Dim dtDetalle As DataTable
                    dtCoordenadas = detalleAGIP.ObtenerCoordenadas(detalleAGIP.CodigoAGIP)
                    dtDetalle = detalleAGIP.BuscarPorCodigoAGIP(detalleAGIP.CodigoAGIP)
                    If dtCoordenadas.Rows.Count > 0 And dtDetalle.Rows.Count > 0 Then
                        If dtCoordenadas.Rows(0).Item(1).ToString() <> 0 And dtCoordenadas.Rows(0).Item(2).ToString() <> 0 Then
                            latitud = Convert.ToDouble(dtCoordenadas.Rows(0).Item(1).ToString())
                            longitud = Convert.ToDouble(dtCoordenadas.Rows(0).Item(2).ToString())
                            'Dim Img As New Bitmap("C:\Lucio\Marcadores\Marcador_01.jpg")
                            'Dim marcador As New GMarkerGoogle(New PointLatLng(latitud, longitud), Img)
                            Dim marcador As New GMarkerGoogle(New PointLatLng(latitud, longitud), color(i))
                            marcador.ToolTipMode = MarkerTooltipMode.Never
                            marcador.ToolTipText = "Proveedor: " & par.Key & vbCrLf & " Dirección: " & _
                                dtDetalle.Rows(0).Item(10).ToString() & " N° " & dtDetalle.Rows(0).Item(11).ToString()
                            capa.Markers.Add(marcador)
                        End If
                    End If
                End If
            Next
            If capa.Markers.Count > 0 Then
                i += 1
                Mapa.Overlays.Add(capa)
            End If
        Next
        Mapa.Position = New PointLatLng(latitud, longitud)
    End Sub

    Private Sub AgregarMarcadoresProvincia()
        Dim codigos() As String
        Dim capa As New GMapOverlay("Provincia")
        For Each par As KeyValuePair(Of String, List(Of Detalle_AGIP)) In CodigosAGIP
            For Each detalleAGIP As Detalle_AGIP In par.Value
                If detalleAGIP.Provincia <> "Capital Federal" Then
                    detalleAGIP.ObtenerCoordenadasGoogle(detalleAGIP)
                    If detalleAGIP.Latitud <> 0 And detalleAGIP.Longitud <> 0 Then
                        Dim marcador As New GMarkerGoogle(New PointLatLng(detalleAGIP.Latitud, detalleAGIP.Longitud), GMarkerGoogleType.purple_dot)
                        marcador.ToolTipMode = MarkerTooltipMode.Never
                        marcador.ToolTipText = "Proveedor: " & par.Key & vbCrLf & "Localidad: " & detalleAGIP.Localidad & vbCrLf & " Dirección: " & detalleAGIP.Direccion
                        capa.Markers.Add(marcador)
                        latitud = detalleAGIP.Latitud
                        longitud = detalleAGIP.Longitud
                        capa.IsVisibile = False
                    End If
                End If
            Next
            If capa.Markers.Count > 0 Then
                Mapa.Overlays.Add(capa)
            End If
        Next
        Mapa.Position = New PointLatLng(latitud, longitud)
    End Sub

    Private Sub MostrarCheckCapas()
        Dim y As Integer = 30
        Dim grupo As New GroupBox
        grupo.Text = "Proveedores"
        grupo.Location = New Point(10, 10)
        grupo.Width = 300
        For Each capa As GMapOverlay In Mapa.Overlays
            Dim check As New CheckBox
            check.Name = capa.Id
            check.Text = capa.Id
            check.Checked = capa.Id <> "Provincia"
            check.Location = New Point(20, y)
            check.Width = 280
            AddHandler check.CheckedChanged, AddressOf CheckedChanged
            y += 25
            Me.pnlLeyendas.Controls.Add(check)
        Next
        grupo.Height = y
        Me.pnlLeyendas.Controls.Add(grupo)
    End Sub

    Private Sub CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim check As CheckBox = DirectCast(sender, CheckBox)
        For Each capa As GMapOverlay In Mapa.Overlays
            If capa.Id = check.Name Then
                capa.IsVisibile = check.Checked
                If capa.Id = "Provincia" And check.Checked Then
                    If Mapa.Overlays(0).Markers.Count > 0 Then
                        Mapa.Position = Mapa.Overlays(0).Markers(Mapa.Overlays(0).Markers.Count - 1).Position
                    End If
                Else
                    Mapa.Position = Mapa.Overlays(Mapa.Overlays.Count - 1).Markers(Mapa.Overlays(Mapa.Overlays.Count - 1).Markers.Count - 1).Position
                End If
            End If
        Next

    End Sub

    Private Sub MarkerClick(ByVal item As GMapMarker, ByVal e As MouseEventArgs)
        Dim x As Double = Mapa.FromLatLngToLocal(item.Position).X
        Dim y As Double = Mapa.FromLatLngToLocal(item.Position).Y
        y -= 80
        Dim t As ToolTip = New ToolTip()
        t.IsBalloon = True
        t.InitialDelay = 1500
        t.Show(item.ToolTipText, Mapa, x, y, 1000)
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
        Dim imagen As System.Drawing.Image = Mapa.ToImage()
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> String.Empty Then
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    imagen.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case 2
                    imagen.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case 3
                    imagen.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
            End Select
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
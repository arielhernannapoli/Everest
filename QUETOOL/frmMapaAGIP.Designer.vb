<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapaAGIP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Mapa = New GMap.NET.WindowsForms.GMapControl
        Me.btnCopiar = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btnSalir = New System.Windows.Forms.Button
        Me.pnlLeyendas = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'Mapa
        '
        Me.Mapa.Bearing = 0.0!
        Me.Mapa.CanDragMap = True
        Me.Mapa.EmptyTileColor = System.Drawing.Color.Navy
        Me.Mapa.GrayScaleMode = False
        Me.Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.Mapa.LevelsKeepInMemmory = 5
        Me.Mapa.Location = New System.Drawing.Point(13, 13)
        Me.Mapa.MarkersEnabled = True
        Me.Mapa.MaxZoom = 2
        Me.Mapa.MinZoom = 2
        Me.Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.Mapa.Name = "Mapa"
        Me.Mapa.NegativeMode = False
        Me.Mapa.PolygonsEnabled = True
        Me.Mapa.RetryLoadTile = 0
        Me.Mapa.RoutesEnabled = True
        Me.Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Mapa.ShowTileGridLines = False
        Me.Mapa.Size = New System.Drawing.Size(794, 628)
        Me.Mapa.TabIndex = 0
        Me.Mapa.Zoom = 0
        '
        'btnCopiar
        '
        Me.btnCopiar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopiar.Location = New System.Drawing.Point(813, 618)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(75, 23)
        Me.btnCopiar.TabIndex = 5
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(1064, 618)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pnlLeyendas
        '
        Me.pnlLeyendas.AutoScroll = True
        Me.pnlLeyendas.Location = New System.Drawing.Point(814, 13)
        Me.pnlLeyendas.Name = "pnlLeyendas"
        Me.pnlLeyendas.Size = New System.Drawing.Size(325, 599)
        Me.pnlLeyendas.TabIndex = 7
        '
        'frmMapaAGIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 653)
        Me.Controls.Add(Me.pnlLeyendas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.Mapa)
        Me.Name = "frmMapaAGIP"
        Me.Text = "Mapa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mapa As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents btnCopiar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pnlLeyendas As System.Windows.Forms.Panel
End Class

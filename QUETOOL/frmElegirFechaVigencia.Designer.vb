<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElegirFechaVigencia
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.DtpFechaDesde = New QUETOOL.dtpFecha
        Me.dtpFechaHasta = New QUETOOL.dtpFecha
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpFechaDesde)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 104)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha de Vigencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Vigencia Desde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Vigencia Hasta"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(223, 127)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 86
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(143, 127)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 85
        Me.cmdAceptar.Text = "Aceptar"
        '
        'DtpFechaDesde
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.DtpFechaDesde.Appearance = Appearance1
        Me.DtpFechaDesde.DateTime = New Date(2013, 9, 20, 0, 0, 0, 0)
        Me.DtpFechaDesde.FlatMode = True
        Me.DtpFechaDesde.Location = New System.Drawing.Point(97, 22)
        Me.DtpFechaDesde.Name = "DtpFechaDesde"
        Me.DtpFechaDesde.Size = New System.Drawing.Size(98, 21)
        Me.DtpFechaDesde.TabIndex = 82
        Me.DtpFechaDesde.Value = New Date(2013, 9, 20, 0, 0, 0, 0)
        '
        'dtpFechaHasta
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaHasta.Appearance = Appearance2
        Me.dtpFechaHasta.DateTime = New Date(2013, 9, 20, 0, 0, 0, 0)
        Me.dtpFechaHasta.FlatMode = True
        Me.dtpFechaHasta.Location = New System.Drawing.Point(97, 54)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(98, 21)
        Me.dtpFechaHasta.TabIndex = 15
        Me.dtpFechaHasta.Value = New Date(2013, 9, 20, 0, 0, 0, 0)
        '
        'frmElegirFechaVigencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 157)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmElegirFechaVigencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Tarifa Promedio"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As QUETOOL.dtpFecha
    Friend WithEvents DtpFechaDesde As QUETOOL.dtpFecha
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
End Class

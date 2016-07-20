<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeguimientoCPR
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtImporteTV = New System.Windows.Forms.TextBox
        Me.txtTarget = New System.Windows.Forms.TextBox
        Me.txtCPRTelefe = New System.Windows.Forms.TextBox
        Me.txtCPRAmerica = New System.Windows.Forms.TextBox
        Me.txtCPRC9 = New System.Windows.Forms.TextBox
        Me.txtCPRC13 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.txttarget2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpFechaHasta = New QUETOOL.dtpFecha
        Me.dtpFechaDesde = New QUETOOL.dtpFecha
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Desde"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttarget2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtImporteTV)
        Me.GroupBox1.Controls.Add(Me.txtTarget)
        Me.GroupBox1.Controls.Add(Me.txtCPRTelefe)
        Me.GroupBox1.Controls.Add(Me.txtCPRAmerica)
        Me.GroupBox1.Controls.Add(Me.txtCPRC9)
        Me.GroupBox1.Controls.Add(Me.txtCPRC13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 172)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Datos Solicitados ( CPR ) :"
        '
        'txtImporteTV
        '
        Me.txtImporteTV.Location = New System.Drawing.Point(117, 137)
        Me.txtImporteTV.Name = "txtImporteTV"
        Me.txtImporteTV.Size = New System.Drawing.Size(178, 20)
        Me.txtImporteTV.TabIndex = 5
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(18, 104)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(172, 20)
        Me.txtTarget.TabIndex = 24
        '
        'txtCPRTelefe
        '
        Me.txtCPRTelefe.Location = New System.Drawing.Point(66, 49)
        Me.txtCPRTelefe.Name = "txtCPRTelefe"
        Me.txtCPRTelefe.Size = New System.Drawing.Size(124, 20)
        Me.txtCPRTelefe.TabIndex = 2
        '
        'txtCPRAmerica
        '
        Me.txtCPRAmerica.Location = New System.Drawing.Point(257, 21)
        Me.txtCPRAmerica.Name = "txtCPRAmerica"
        Me.txtCPRAmerica.Size = New System.Drawing.Size(124, 20)
        Me.txtCPRAmerica.TabIndex = 3
        '
        'txtCPRC9
        '
        Me.txtCPRC9.Location = New System.Drawing.Point(257, 48)
        Me.txtCPRC9.Name = "txtCPRC9"
        Me.txtCPRC9.Size = New System.Drawing.Size(124, 20)
        Me.txtCPRC9.TabIndex = 4
        '
        'txtCPRC13
        '
        Me.txtCPRC13.Location = New System.Drawing.Point(66, 22)
        Me.txtCPRC13.Name = "txtCPRC13"
        Me.txtCPRC13.Size = New System.Drawing.Size(124, 20)
        Me.txtCPRC13.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Importe TV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Target 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telefe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "America"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Canal 9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Canal 13"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(247, 226)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(331, 226)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Cancelar"
        '
        'txttarget2
        '
        Me.txttarget2.Location = New System.Drawing.Point(205, 104)
        Me.txttarget2.Name = "txttarget2"
        Me.txttarget2.Size = New System.Drawing.Size(176, 20)
        Me.txttarget2.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(202, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Target 2"
        '
        'dtpFechaHasta
        '
        Appearance3.FontData.SizeInPoints = 9.0!
        Me.dtpFechaHasta.Appearance = Appearance3
        Me.dtpFechaHasta.DateTime = New Date(2012, 5, 30, 0, 0, 0, 0)
        Me.dtpFechaHasta.FlatMode = True
        Me.dtpFechaHasta.Location = New System.Drawing.Point(294, 12)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(112, 21)
        Me.dtpFechaHasta.TabIndex = 5
        Me.dtpFechaHasta.Value = New Date(2012, 5, 30, 0, 0, 0, 0)
        '
        'dtpFechaDesde
        '
        Appearance4.FontData.SizeInPoints = 9.0!
        Me.dtpFechaDesde.Appearance = Appearance4
        Me.dtpFechaDesde.DateTime = New Date(2012, 5, 30, 0, 0, 0, 0)
        Me.dtpFechaDesde.FlatMode = True
        Me.dtpFechaDesde.Location = New System.Drawing.Point(90, 12)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(115, 21)
        Me.dtpFechaDesde.TabIndex = 4
        Me.dtpFechaDesde.Value = New Date(2012, 5, 30, 0, 0, 0, 0)
        '
        'FrmSeguimientoCPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 257)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.MaximizeBox = False
        Me.Name = "FrmSeguimientoCPR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtros Seguimiento CPR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaDesde As QUETOOL.dtpFecha
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTarget As System.Windows.Forms.TextBox
    Friend WithEvents txtCPRTelefe As System.Windows.Forms.TextBox
    Friend WithEvents txtCPRAmerica As System.Windows.Forms.TextBox
    Friend WithEvents txtCPRC9 As System.Windows.Forms.TextBox
    Friend WithEvents txtCPRC13 As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteTV As System.Windows.Forms.TextBox
    Friend WithEvents txttarget2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class

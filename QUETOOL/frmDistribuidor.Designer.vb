<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribuidor
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttotaltemas = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPorcentajeSoporte = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rdcprbajo = New System.Windows.Forms.RadioButton
        Me.rdfranjaratalto = New System.Windows.Forms.RadioButton
        Me.txtAvisos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtvalortipoObjetico = New System.Windows.Forms.TextBox
        Me.rdgrps = New System.Windows.Forms.RadioButton
        Me.rdinversion = New System.Windows.Forms.RadioButton
        Me.dtpFechaFinD = New QUETOOL.dtpFecha
        Me.dtpFechaInicioD = New QUETOOL.dtpFecha
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.uigTemas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.iugSoportes = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.uigTemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.iugSoportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttotaltemas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPorcentajeSoporte)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1068, 625)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Datos Solicitados :"
        '
        'txttotaltemas
        '
        Me.txttotaltemas.Location = New System.Drawing.Point(936, 491)
        Me.txttotaltemas.Name = "txttotaltemas"
        Me.txttotaltemas.Size = New System.Drawing.Size(118, 20)
        Me.txttotaltemas.TabIndex = 7
        Me.txttotaltemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(759, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TOTAL PORCENTAJE TEMAS :"
        '
        'txtPorcentajeSoporte
        '
        Me.txtPorcentajeSoporte.Location = New System.Drawing.Point(524, 585)
        Me.txtPorcentajeSoporte.Name = "txtPorcentajeSoporte"
        Me.txtPorcentajeSoporte.Size = New System.Drawing.Size(118, 20)
        Me.txtPorcentajeSoporte.TabIndex = 5
        Me.txtPorcentajeSoporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 592)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TOTAL PORCENTAJE SOPORTE :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.txtAvisos)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.dtpFechaFinD)
        Me.GroupBox5.Controls.Add(Me.dtpFechaInicioD)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(95, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(878, 114)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Criterios"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdcprbajo)
        Me.GroupBox6.Controls.Add(Me.rdfranjaratalto)
        Me.GroupBox6.Location = New System.Drawing.Point(291, 47)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(242, 49)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo de Franja :"
        '
        'rdcprbajo
        '
        Me.rdcprbajo.AutoSize = True
        Me.rdcprbajo.Location = New System.Drawing.Point(127, 19)
        Me.rdcprbajo.Name = "rdcprbajo"
        Me.rdcprbajo.Size = New System.Drawing.Size(103, 17)
        Me.rdcprbajo.TabIndex = 1
        Me.rdcprbajo.TabStop = True
        Me.rdcprbajo.Text = "CPR MAS BAJO"
        Me.rdcprbajo.UseVisualStyleBackColor = True
        '
        'rdfranjaratalto
        '
        Me.rdfranjaratalto.AutoSize = True
        Me.rdfranjaratalto.Location = New System.Drawing.Point(15, 19)
        Me.rdfranjaratalto.Name = "rdfranjaratalto"
        Me.rdfranjaratalto.Size = New System.Drawing.Size(87, 17)
        Me.rdfranjaratalto.TabIndex = 0
        Me.rdfranjaratalto.TabStop = True
        Me.rdfranjaratalto.Text = "RAT + ALTO"
        Me.rdfranjaratalto.UseVisualStyleBackColor = True
        '
        'txtAvisos
        '
        Me.txtAvisos.Location = New System.Drawing.Point(191, 63)
        Me.txtAvisos.Name = "txtAvisos"
        Me.txtAvisos.Size = New System.Drawing.Size(66, 20)
        Me.txtAvisos.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 28)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cantidad Maxima de Avisos / Hora :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtvalortipoObjetico)
        Me.GroupBox2.Controls.Add(Me.rdgrps)
        Me.GroupBox2.Controls.Add(Me.rdinversion)
        Me.GroupBox2.Location = New System.Drawing.Point(557, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 66)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Objetivo :"
        '
        'txtvalortipoObjetico
        '
        Me.txtvalortipoObjetico.Location = New System.Drawing.Point(137, 17)
        Me.txtvalortipoObjetico.Name = "txtvalortipoObjetico"
        Me.txtvalortipoObjetico.Size = New System.Drawing.Size(92, 20)
        Me.txtvalortipoObjetico.TabIndex = 4
        '
        'rdgrps
        '
        Me.rdgrps.AutoSize = True
        Me.rdgrps.Location = New System.Drawing.Point(26, 42)
        Me.rdgrps.Name = "rdgrps"
        Me.rdgrps.Size = New System.Drawing.Size(74, 17)
        Me.rdgrps.TabIndex = 1
        Me.rdgrps.TabStop = True
        Me.rdgrps.Text = "Por GRPS"
        Me.rdgrps.UseVisualStyleBackColor = True
        '
        'rdinversion
        '
        Me.rdinversion.AutoSize = True
        Me.rdinversion.Location = New System.Drawing.Point(26, 19)
        Me.rdinversion.Name = "rdinversion"
        Me.rdinversion.Size = New System.Drawing.Size(103, 17)
        Me.rdinversion.TabIndex = 0
        Me.rdinversion.TabStop = True
        Me.rdinversion.Text = "Por INVERSION"
        Me.rdinversion.UseVisualStyleBackColor = True
        '
        'dtpFechaFinD
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFechaFinD.Appearance = Appearance1
        Me.dtpFechaFinD.FlatMode = True
        Me.dtpFechaFinD.Location = New System.Drawing.Point(378, 20)
        Me.dtpFechaFinD.Name = "dtpFechaFinD"
        Me.dtpFechaFinD.Size = New System.Drawing.Size(116, 21)
        Me.dtpFechaFinD.TabIndex = 2
        '
        'dtpFechaInicioD
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicioD.Appearance = Appearance2
        Me.dtpFechaInicioD.FlatMode = True
        Me.dtpFechaInicioD.Location = New System.Drawing.Point(106, 20)
        Me.dtpFechaInicioD.Name = "dtpFechaInicioD"
        Me.dtpFechaInicioD.Size = New System.Drawing.Size(116, 21)
        Me.dtpFechaInicioD.TabIndex = 1
        Me.dtpFechaInicioD.Value = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(293, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Fecha Hasta :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fecha Desde :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.uigTemas)
        Me.GroupBox4.Location = New System.Drawing.Point(650, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(407, 341)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Distribucion de Temas :"
        '
        'uigTemas
        '
        Me.uigTemas.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance3.BackColor = System.Drawing.Color.White
        Me.uigTemas.DisplayLayout.Appearance = Appearance3
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.uigTemas.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.uigTemas.DisplayLayout.Override.CellPadding = 3
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigTemas.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.uigTemas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.LightGray
        Appearance6.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigTemas.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.PowderBlue
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.uigTemas.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.uigTemas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigTemas.DisplayLayout.UseFixedHeaders = True
        Me.uigTemas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uigTemas.FlatMode = True
        Me.uigTemas.Location = New System.Drawing.Point(3, 16)
        Me.uigTemas.Name = "uigTemas"
        Me.uigTemas.Size = New System.Drawing.Size(401, 322)
        Me.uigTemas.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.iugSoportes)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(630, 435)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Soportes :"
        '
        'iugSoportes
        '
        Me.iugSoportes.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance8.BackColor = System.Drawing.Color.White
        Me.iugSoportes.DisplayLayout.Appearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.iugSoportes.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Me.iugSoportes.DisplayLayout.Override.CellPadding = 3
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugSoportes.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.iugSoportes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance11.BorderColor = System.Drawing.Color.LightGray
        Appearance11.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugSoportes.DisplayLayout.Override.RowAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.PowderBlue
        Appearance12.BorderColor = System.Drawing.Color.Black
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.iugSoportes.DisplayLayout.Override.SelectedRowAppearance = Appearance12
        Me.iugSoportes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugSoportes.DisplayLayout.UseFixedHeaders = True
        Me.iugSoportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugSoportes.FlatMode = True
        Me.iugSoportes.Location = New System.Drawing.Point(3, 16)
        Me.iugSoportes.Name = "iugSoportes"
        Me.iugSoportes.Size = New System.Drawing.Size(624, 416)
        Me.iugSoportes.TabIndex = 11
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(991, 644)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 14
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(903, 644)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 13
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmDistribuidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 677)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDistribuidor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distribuidor de Pases"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.uigTemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.iugSoportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtvalortipoObjetico As System.Windows.Forms.TextBox
    Friend WithEvents rdgrps As System.Windows.Forms.RadioButton
    Friend WithEvents rdinversion As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents iugSoportes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents uigTemas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdcprbajo As System.Windows.Forms.RadioButton
    Friend WithEvents rdfranjaratalto As System.Windows.Forms.RadioButton
    Friend WithEvents txtAvisos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinD As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaInicioD As QUETOOL.dtpFecha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txttotaltemas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeSoporte As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

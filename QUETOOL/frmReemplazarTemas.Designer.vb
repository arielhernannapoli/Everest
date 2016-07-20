<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReemplazarTemas
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
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.uigTemasNuevos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.dtpFechaFinD = New QUETOOL.dtpFecha
        Me.dtpFechaInicioD = New QUETOOL.dtpFecha
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdinversion = New System.Windows.Forms.RadioButton
        Me.rdgrp = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.uigTemas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.uigTemasNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.uigTemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(815, 501)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Datos Solicitados :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.uigTemasNuevos)
        Me.GroupBox3.Location = New System.Drawing.Point(358, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 386)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Temas Reemplazo :"
        '
        'uigTemasNuevos
        '
        Me.uigTemasNuevos.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance25.BackColor = System.Drawing.Color.White
        Me.uigTemasNuevos.DisplayLayout.Appearance = Appearance25
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Me.uigTemasNuevos.DisplayLayout.Override.CardAreaAppearance = Appearance26
        Me.uigTemasNuevos.DisplayLayout.Override.CellPadding = 3
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigTemasNuevos.DisplayLayout.Override.HeaderAppearance = Appearance27
        Me.uigTemasNuevos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance28.BorderColor = System.Drawing.Color.LightGray
        Appearance28.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigTemasNuevos.DisplayLayout.Override.RowAppearance = Appearance28
        Appearance29.BackColor = System.Drawing.Color.PowderBlue
        Appearance29.BorderColor = System.Drawing.Color.Black
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.uigTemasNuevos.DisplayLayout.Override.SelectedRowAppearance = Appearance29
        Me.uigTemasNuevos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigTemasNuevos.DisplayLayout.UseFixedHeaders = True
        Me.uigTemasNuevos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uigTemasNuevos.FlatMode = True
        Me.uigTemasNuevos.Location = New System.Drawing.Point(3, 16)
        Me.uigTemasNuevos.Name = "uigTemasNuevos"
        Me.uigTemasNuevos.Size = New System.Drawing.Size(444, 367)
        Me.uigTemasNuevos.TabIndex = 11
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(795, 81)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Criterios"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtpFechaFinD)
        Me.GroupBox6.Controls.Add(Me.dtpFechaInicioD)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(411, 54)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Vigencia Sistema"
        '
        'dtpFechaFinD
        '
        Appearance30.FontData.SizeInPoints = 9.0!
        Me.dtpFechaFinD.Appearance = Appearance30
        Me.dtpFechaFinD.FlatMode = True
        Me.dtpFechaFinD.Location = New System.Drawing.Point(302, 17)
        Me.dtpFechaFinD.Name = "dtpFechaFinD"
        Me.dtpFechaFinD.Size = New System.Drawing.Size(97, 21)
        Me.dtpFechaFinD.TabIndex = 20
        '
        'dtpFechaInicioD
        '
        Appearance31.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicioD.Appearance = Appearance31
        Me.dtpFechaInicioD.FlatMode = True
        Me.dtpFechaInicioD.Location = New System.Drawing.Point(97, 17)
        Me.dtpFechaInicioD.Name = "dtpFechaInicioD"
        Me.dtpFechaInicioD.Size = New System.Drawing.Size(104, 21)
        Me.dtpFechaInicioD.TabIndex = 19
        Me.dtpFechaInicioD.Value = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(217, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Fecha Hasta :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Fecha Desde :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdinversion)
        Me.GroupBox2.Controls.Add(Me.rdgrp)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 52)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Aplicacion :"
        '
        'rdinversion
        '
        Me.rdinversion.AutoSize = True
        Me.rdinversion.Location = New System.Drawing.Point(191, 19)
        Me.rdinversion.Name = "rdinversion"
        Me.rdinversion.Size = New System.Drawing.Size(103, 17)
        Me.rdinversion.TabIndex = 1
        Me.rdinversion.TabStop = True
        Me.rdinversion.Text = "Por INVERSION"
        Me.rdinversion.UseVisualStyleBackColor = True
        '
        'rdgrp
        '
        Me.rdgrp.AutoSize = True
        Me.rdgrp.Location = New System.Drawing.Point(6, 19)
        Me.rdgrp.Name = "rdgrp"
        Me.rdgrp.Size = New System.Drawing.Size(164, 17)
        Me.rdgrp.TabIndex = 0
        Me.rdgrp.TabStop = True
        Me.rdgrp.Text = "Por CANT / AVISOS / GRPS"
        Me.rdgrp.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.uigTemas)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 386)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Temas Aplicados :"
        '
        'uigTemas
        '
        Me.uigTemas.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance32.BackColor = System.Drawing.Color.White
        Me.uigTemas.DisplayLayout.Appearance = Appearance32
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Me.uigTemas.DisplayLayout.Override.CardAreaAppearance = Appearance33
        Me.uigTemas.DisplayLayout.Override.CellPadding = 3
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigTemas.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.uigTemas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance35.BorderColor = System.Drawing.Color.LightGray
        Appearance35.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigTemas.DisplayLayout.Override.RowAppearance = Appearance35
        Appearance36.BackColor = System.Drawing.Color.PowderBlue
        Appearance36.BorderColor = System.Drawing.Color.Black
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.uigTemas.DisplayLayout.Override.SelectedRowAppearance = Appearance36
        Me.uigTemas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigTemas.DisplayLayout.UseFixedHeaders = True
        Me.uigTemas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uigTemas.FlatMode = True
        Me.uigTemas.Location = New System.Drawing.Point(3, 16)
        Me.uigTemas.Name = "uigTemas"
        Me.uigTemas.Size = New System.Drawing.Size(336, 367)
        Me.uigTemas.TabIndex = 11
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(727, 512)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 16
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(639, 512)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 15
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmReemplazarTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReemplazarTemas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reemplazo de Temas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.uigTemasNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.uigTemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdinversion As System.Windows.Forms.RadioButton
    Friend WithEvents rdgrp As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents uigTemas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents uigTemasNuevos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinD As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaInicioD As QUETOOL.dtpFecha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

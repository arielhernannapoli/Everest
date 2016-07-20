<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvisosDiferencia
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
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.iugAvisos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblLeyenda = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.iugAvisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(868, 474)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 24)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "NO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.iugAvisos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(940, 456)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avisos con diferencias de importes"
        '
        'iugAvisos
        '
        Me.iugAvisos.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance11.BackColor = System.Drawing.Color.White
        Me.iugAvisos.DisplayLayout.Appearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.iugAvisos.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Me.iugAvisos.DisplayLayout.Override.CellPadding = 3
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugAvisos.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.iugAvisos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance14.BorderColor = System.Drawing.Color.LightGray
        Appearance14.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugAvisos.DisplayLayout.Override.RowAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.PowderBlue
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.iugAvisos.DisplayLayout.Override.SelectedRowAppearance = Appearance15
        Me.iugAvisos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugAvisos.DisplayLayout.UseFixedHeaders = True
        Me.iugAvisos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugAvisos.FlatMode = True
        Me.iugAvisos.Location = New System.Drawing.Point(3, 16)
        Me.iugAvisos.Name = "iugAvisos"
        Me.iugAvisos.Size = New System.Drawing.Size(934, 437)
        Me.iugAvisos.TabIndex = 11
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(778, 474)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 24)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "SI"
        '
        'lblLeyenda
        '
        Me.lblLeyenda.AutoSize = True
        Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeyenda.Location = New System.Drawing.Point(12, 488)
        Me.lblLeyenda.Name = "lblLeyenda"
        Me.lblLeyenda.Size = New System.Drawing.Size(579, 13)
        Me.lblLeyenda.TabIndex = 10
        Me.lblLeyenda.Text = "Existen diferencias en los importes de compra y venta de los avisos. ¿Desea conti" & _
            "nuar con el envio?"
        '
        'frmAvisosDiferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 510)
        Me.Controls.Add(Me.lblLeyenda)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAvisosDiferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Avisos con Diferencias en Importes Compra y Venta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.iugAvisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents iugAvisos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblLeyenda As System.Windows.Forms.Label
End Class

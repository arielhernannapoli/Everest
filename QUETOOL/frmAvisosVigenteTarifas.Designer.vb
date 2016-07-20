<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvisosVigenteTarifas
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.iugTarifasVigentes = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.iugTarifasVigentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.iugTarifasVigentes)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1483, 529)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control Vigencia de Tarifas por Avisos :"
        '
        'iugTarifasVigentes
        '
        Me.iugTarifasVigentes.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance6.BackColor = System.Drawing.Color.White
        Me.iugTarifasVigentes.DisplayLayout.Appearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.iugTarifasVigentes.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Me.iugTarifasVigentes.DisplayLayout.Override.CellPadding = 3
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugTarifasVigentes.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.iugTarifasVigentes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance9.BorderColor = System.Drawing.Color.LightGray
        Appearance9.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugTarifasVigentes.DisplayLayout.Override.RowAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.PowderBlue
        Appearance10.BorderColor = System.Drawing.Color.Black
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.iugTarifasVigentes.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.iugTarifasVigentes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugTarifasVigentes.DisplayLayout.UseFixedHeaders = True
        Me.iugTarifasVigentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugTarifasVigentes.FlatMode = True
        Me.iugTarifasVigentes.Location = New System.Drawing.Point(3, 16)
        Me.iugTarifasVigentes.Name = "iugTarifasVigentes"
        Me.iugTarifasVigentes.Size = New System.Drawing.Size(1477, 510)
        Me.iugTarifasVigentes.TabIndex = 10
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(1405, 540)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 24)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        '
        'frmAvisosVigenteTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1502, 578)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAvisosVigenteTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avisos Sin Vigencia Tarifas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.iugTarifasVigentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents iugTarifasVigentes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class

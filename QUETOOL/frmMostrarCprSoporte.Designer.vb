<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarCprSoporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.cmdaceptar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.iugCPRSoporte = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox3.SuspendLayout()
        CType(Me.iugCPRSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Location = New System.Drawing.Point(205, 308)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(117, 27)
        Me.cmdaceptar.TabIndex = 3
        Me.cmdaceptar.Text = "Aceptar"
        Me.cmdaceptar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(328, 308)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(115, 27)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.iugCPRSoporte)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 293)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Soportes :"
        '
        'iugCPRSoporte
        '
        Me.iugCPRSoporte.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance6.BackColor = System.Drawing.Color.White
        Me.iugCPRSoporte.DisplayLayout.Appearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.iugCPRSoporte.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Me.iugCPRSoporte.DisplayLayout.Override.CellPadding = 3
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugCPRSoporte.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.iugCPRSoporte.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance9.BorderColor = System.Drawing.Color.LightGray
        Appearance9.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugCPRSoporte.DisplayLayout.Override.RowAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.PowderBlue
        Appearance10.BorderColor = System.Drawing.Color.Black
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.iugCPRSoporte.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.iugCPRSoporte.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugCPRSoporte.DisplayLayout.UseFixedHeaders = True
        Me.iugCPRSoporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugCPRSoporte.FlatMode = True
        Me.iugCPRSoporte.Location = New System.Drawing.Point(3, 16)
        Me.iugCPRSoporte.Name = "iugCPRSoporte"
        Me.iugCPRSoporte.Size = New System.Drawing.Size(437, 274)
        Me.iugCPRSoporte.TabIndex = 11
        '
        'frmMostrarCprSoporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdaceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMostrarCprSoporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CPR's Soporte TV Abierta"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.iugCPRSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdaceptar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents iugCPRSoporte As Infragistics.Win.UltraWinGrid.UltraGrid
End Class

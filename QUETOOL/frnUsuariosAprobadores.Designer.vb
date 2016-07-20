<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnUsuariosAprobadores
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
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.uigUsuarios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        CType(Me.uigUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uigUsuarios
        '
        Me.uigUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.uigUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance16.BackColor = System.Drawing.Color.White
        Me.uigUsuarios.DisplayLayout.Appearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.uigUsuarios.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Me.uigUsuarios.DisplayLayout.Override.CellPadding = 3
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigUsuarios.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.uigUsuarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance19.BorderColor = System.Drawing.Color.LightGray
        Appearance19.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigUsuarios.DisplayLayout.Override.RowAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.Color.PowderBlue
        Appearance20.BorderColor = System.Drawing.Color.Black
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.uigUsuarios.DisplayLayout.Override.SelectedRowAppearance = Appearance20
        Me.uigUsuarios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigUsuarios.DisplayLayout.UseFixedHeaders = True
        Me.uigUsuarios.FlatMode = True
        Me.uigUsuarios.Location = New System.Drawing.Point(3, 5)
        Me.uigUsuarios.Name = "uigUsuarios"
        Me.uigUsuarios.Size = New System.Drawing.Size(419, 265)
        Me.uigUsuarios.TabIndex = 12
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(347, 276)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 18
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(259, 276)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 17
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frnUsuariosAprobadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.uigUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frnUsuariosAprobadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobadores"
        CType(Me.uigUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uigUsuarios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
End Class

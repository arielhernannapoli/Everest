<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionarTConvRentabilidad
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RBfpro = New System.Windows.Forms.RadioButton
        Me.RBnc = New System.Windows.Forms.RadioButton
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBfpro)
        Me.GroupBox1.Controls.Add(Me.RBnc)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rentabilidad :"
        '
        'RBfpro
        '
        Me.RBfpro.AutoSize = True
        Me.RBfpro.Location = New System.Drawing.Point(188, 19)
        Me.RBfpro.Name = "RBfpro"
        Me.RBfpro.Size = New System.Drawing.Size(109, 17)
        Me.RBfpro.TabIndex = 1
        Me.RBfpro.TabStop = True
        Me.RBfpro.Text = "FC PROVEEDOR"
        Me.RBfpro.UseVisualStyleBackColor = True
        '
        'RBnc
        '
        Me.RBnc.AutoSize = True
        Me.RBnc.Location = New System.Drawing.Point(23, 19)
        Me.RBnc.Name = "RBnc"
        Me.RBnc.Size = New System.Drawing.Size(111, 17)
        Me.RBnc.TabIndex = 0
        Me.RBnc.TabStop = True
        Me.RBnc.Text = "NC PROVEEDOR"
        Me.RBnc.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(269, 63)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmSeleccionarTConvRentabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 95)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionarTConvRentabilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Tipo de Rentabilidad del Convenio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents RBfpro As System.Windows.Forms.RadioButton
    Friend WithEvents RBnc As System.Windows.Forms.RadioButton
End Class

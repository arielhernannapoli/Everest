<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRol
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRol))
        Me.cmdControl = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPlanif = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SuspendLayout()
        '
        'cmdControl
        '
        Me.cmdControl.Image = CType(resources.GetObject("cmdControl.Image"), System.Drawing.Image)
        Me.cmdControl.Location = New System.Drawing.Point(44, 12)
        Me.cmdControl.Name = "cmdControl"
        Me.cmdControl.Size = New System.Drawing.Size(40, 38)
        Me.cmdControl.TabIndex = 1
        Me.cmdControl.Text = "}"
        '
        'cmdPlanif
        '
        Me.cmdPlanif.Image = CType(resources.GetObject("cmdPlanif.Image"), System.Drawing.Image)
        Me.cmdPlanif.Location = New System.Drawing.Point(113, 12)
        Me.cmdPlanif.Name = "cmdPlanif"
        Me.cmdPlanif.Size = New System.Drawing.Size(40, 38)
        Me.cmdPlanif.TabIndex = 1
        Me.cmdPlanif.Text = "SimpleButton1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(36, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "CONTROL"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(113, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "CONVENIOS"
        '
        'frmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPlanif)
        Me.Controls.Add(Me.cmdControl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRol"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegí tu rol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdControl As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPlanif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

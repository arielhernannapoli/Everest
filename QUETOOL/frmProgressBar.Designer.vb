﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgressBar
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
        Me.pgbEnvioCompras = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'pgbEnvioCompras
        '
        Me.pgbEnvioCompras.Location = New System.Drawing.Point(12, 14)
        Me.pgbEnvioCompras.Name = "pgbEnvioCompras"
        Me.pgbEnvioCompras.Size = New System.Drawing.Size(487, 23)
        Me.pgbEnvioCompras.TabIndex = 0
        '
        'frmProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 49)
        Me.Controls.Add(Me.pgbEnvioCompras)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProgressBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Envio a Compras :: "
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgbEnvioCompras As System.Windows.Forms.ProgressBar
End Class

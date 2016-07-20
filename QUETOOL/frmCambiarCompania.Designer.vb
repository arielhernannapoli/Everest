<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarCompania
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CboDelegacion = New QUETOOL.cboCombo
        Me.CboCompania = New QUETOOL.cboCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.marqueeCarga = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.GroupBox2.SuspendLayout()
        CType(Me.CboDelegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCompania, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboDelegacion)
        Me.GroupBox2.Controls.Add(Me.CboCompania)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 124)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'CboDelegacion
        '
        Me.CboDelegacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboDelegacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboDelegacion.DisplayMember = ""
        Me.CboDelegacion.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboDelegacion.FlatMode = True
        Me.CboDelegacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDelegacion.Location = New System.Drawing.Point(80, 44)
        Me.CboDelegacion.Name = "CboDelegacion"
        Me.CboDelegacion.Size = New System.Drawing.Size(202, 21)
        Me.CboDelegacion.TabIndex = 82
        Me.CboDelegacion.Tag = ""
        Me.CboDelegacion.ValueMember = ""
        '
        'CboCompania
        '
        Me.CboCompania.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboCompania.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboCompania.DisplayMember = ""
        Me.CboCompania.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboCompania.FlatMode = True
        Me.CboCompania.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCompania.Location = New System.Drawing.Point(80, 20)
        Me.CboCompania.Name = "CboCompania"
        Me.CboCompania.Size = New System.Drawing.Size(202, 21)
        Me.CboCompania.TabIndex = 81
        Me.CboCompania.Tag = ""
        Me.CboCompania.ValueMember = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Compañía"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Delegación"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(212, 131)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(132, 131)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "Aceptar"
        '
        'BackgroundWorker1
        '
        '
        'marqueeCarga
        '
        Me.marqueeCarga.EditValue = "Cargando..."
        Me.marqueeCarga.Location = New System.Drawing.Point(4, 131)
        Me.marqueeCarga.Name = "marqueeCarga"
        Me.marqueeCarga.Size = New System.Drawing.Size(122, 20)
        Me.marqueeCarga.TabIndex = 26
        '
        'frmCambiarCompania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 164)
        Me.Controls.Add(Me.marqueeCarga)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarCompania"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Usuario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CboDelegacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCompania, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents CboCompania As QUETOOL.cboCombo
    Friend WithEvents CboDelegacion As QUETOOL.cboCombo
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents marqueeCarga As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class

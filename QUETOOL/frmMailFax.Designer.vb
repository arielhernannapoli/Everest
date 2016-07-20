<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMailFax
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
        Me.txtDe = New System.Windows.Forms.TextBox
        Me.txtPara = New System.Windows.Forms.TextBox
        Me.txtCC = New System.Windows.Forms.TextBox
        Me.txtAsunto = New System.Windows.Forms.TextBox
        Me.txtAdjunto = New System.Windows.Forms.TextBox
        Me.lblDe = New System.Windows.Forms.Label
        Me.lblPara = New System.Windows.Forms.Label
        Me.lblCC = New System.Windows.Forms.Label
        Me.lblAsunto = New System.Windows.Forms.Label
        Me.lblAdjunto = New System.Windows.Forms.Label
        Me.lblCuerpo = New System.Windows.Forms.Label
        Me.btnEliminarAdjunto = New System.Windows.Forms.Button
        Me.btnBuscarAdjunto = New System.Windows.Forms.Button
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.mpbEnvioMail = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.BackgroundWorkerAdjunto = New System.ComponentModel.BackgroundWorker
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.BackgroundWorkerEnvio = New System.ComponentModel.BackgroundWorker
        Me.txtMensaje = New System.Windows.Forms.RichTextBox
        Me.btnVerOP = New System.Windows.Forms.Button
        CType(Me.mpbEnvioMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDe
        '
        Me.txtDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDe.Enabled = False
        Me.txtDe.Location = New System.Drawing.Point(62, 12)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.ReadOnly = True
        Me.txtDe.Size = New System.Drawing.Size(400, 20)
        Me.txtDe.TabIndex = 0
        '
        'txtPara
        '
        Me.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPara.Location = New System.Drawing.Point(62, 38)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(400, 20)
        Me.txtPara.TabIndex = 1
        '
        'txtCC
        '
        Me.txtCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCC.Location = New System.Drawing.Point(62, 64)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(400, 20)
        Me.txtCC.TabIndex = 2
        '
        'txtAsunto
        '
        Me.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsunto.Location = New System.Drawing.Point(62, 90)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(400, 20)
        Me.txtAsunto.TabIndex = 3
        '
        'txtAdjunto
        '
        Me.txtAdjunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdjunto.Enabled = False
        Me.txtAdjunto.Location = New System.Drawing.Point(62, 116)
        Me.txtAdjunto.Name = "txtAdjunto"
        Me.txtAdjunto.ReadOnly = True
        Me.txtAdjunto.Size = New System.Drawing.Size(336, 20)
        Me.txtAdjunto.TabIndex = 4
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(12, 15)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(24, 13)
        Me.lblDe.TabIndex = 6
        Me.lblDe.Text = "De:"
        '
        'lblPara
        '
        Me.lblPara.AutoSize = True
        Me.lblPara.Location = New System.Drawing.Point(12, 41)
        Me.lblPara.Name = "lblPara"
        Me.lblPara.Size = New System.Drawing.Size(32, 13)
        Me.lblPara.TabIndex = 7
        Me.lblPara.Text = "Para:"
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Location = New System.Drawing.Point(12, 67)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(24, 13)
        Me.lblCC.TabIndex = 8
        Me.lblCC.Text = "CC:"
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Location = New System.Drawing.Point(12, 93)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(43, 13)
        Me.lblAsunto.TabIndex = 9
        Me.lblAsunto.Text = "Asunto:"
        '
        'lblAdjunto
        '
        Me.lblAdjunto.AutoSize = True
        Me.lblAdjunto.Location = New System.Drawing.Point(12, 119)
        Me.lblAdjunto.Name = "lblAdjunto"
        Me.lblAdjunto.Size = New System.Drawing.Size(46, 13)
        Me.lblAdjunto.TabIndex = 10
        Me.lblAdjunto.Text = "Adjunto:"
        '
        'lblCuerpo
        '
        Me.lblCuerpo.AutoSize = True
        Me.lblCuerpo.Location = New System.Drawing.Point(11, 144)
        Me.lblCuerpo.Name = "lblCuerpo"
        Me.lblCuerpo.Size = New System.Drawing.Size(44, 13)
        Me.lblCuerpo.TabIndex = 11
        Me.lblCuerpo.Text = "Cuerpo:"
        '
        'btnEliminarAdjunto
        '
        Me.btnEliminarAdjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarAdjunto.Location = New System.Drawing.Point(404, 114)
        Me.btnEliminarAdjunto.Name = "btnEliminarAdjunto"
        Me.btnEliminarAdjunto.Size = New System.Drawing.Size(26, 23)
        Me.btnEliminarAdjunto.TabIndex = 5
        Me.btnEliminarAdjunto.Text = "X"
        Me.btnEliminarAdjunto.UseVisualStyleBackColor = True
        '
        'btnBuscarAdjunto
        '
        Me.btnBuscarAdjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarAdjunto.Location = New System.Drawing.Point(436, 114)
        Me.btnBuscarAdjunto.Name = "btnBuscarAdjunto"
        Me.btnBuscarAdjunto.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscarAdjunto.TabIndex = 6
        Me.btnBuscarAdjunto.Text = "..."
        Me.btnBuscarAdjunto.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Location = New System.Drawing.Point(306, 610)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 9
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(387, 610)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'mpbEnvioMail
        '
        Me.mpbEnvioMail.EditValue = 0
        Me.mpbEnvioMail.Location = New System.Drawing.Point(103, 610)
        Me.mpbEnvioMail.Name = "mpbEnvioMail"
        Me.mpbEnvioMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.mpbEnvioMail.Properties.EndColor = System.Drawing.Color.Maroon
        Me.mpbEnvioMail.Properties.StartColor = System.Drawing.Color.Maroon
        Me.mpbEnvioMail.Size = New System.Drawing.Size(197, 23)
        Me.mpbEnvioMail.TabIndex = 94
        '
        'BackgroundWorkerAdjunto
        '
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'BackgroundWorkerEnvio
        '
        '
        'txtMensaje
        '
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Location = New System.Drawing.Point(62, 141)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(400, 463)
        Me.txtMensaje.TabIndex = 7
        Me.txtMensaje.Text = ""
        '
        'btnVerOP
        '
        Me.btnVerOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerOP.Location = New System.Drawing.Point(62, 611)
        Me.btnVerOP.Name = "btnVerOP"
        Me.btnVerOP.Size = New System.Drawing.Size(35, 23)
        Me.btnVerOP.TabIndex = 8
        Me.btnVerOP.Text = "OP"
        Me.btnVerOP.UseVisualStyleBackColor = True
        '
        'frmMailFax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 646)
        Me.Controls.Add(Me.btnVerOP)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.mpbEnvioMail)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnBuscarAdjunto)
        Me.Controls.Add(Me.btnEliminarAdjunto)
        Me.Controls.Add(Me.lblCuerpo)
        Me.Controls.Add(Me.lblAdjunto)
        Me.Controls.Add(Me.lblAsunto)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.lblPara)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.txtAdjunto)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.txtDe)
        Me.Name = "frmMailFax"
        Me.Text = "Envio Contratos por Mail"
        CType(Me.mpbEnvioMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDe As System.Windows.Forms.TextBox
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjunto As System.Windows.Forms.TextBox
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents lblPara As System.Windows.Forms.Label
    Friend WithEvents lblCC As System.Windows.Forms.Label
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents lblAdjunto As System.Windows.Forms.Label
    Friend WithEvents lblCuerpo As System.Windows.Forms.Label
    Friend WithEvents btnEliminarAdjunto As System.Windows.Forms.Button
    Friend WithEvents btnBuscarAdjunto As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents mpbEnvioMail As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents BackgroundWorkerAdjunto As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackgroundWorkerEnvio As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents btnVerOP As System.Windows.Forms.Button
End Class

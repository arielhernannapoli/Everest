<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltrarPadronAGIPMasivo
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
        Me.lblCodigosAGIP = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigosAGIP = New QUETOOL.txtTexto
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.marqueeCarga = New DevExpress.XtraEditors.MarqueeProgressBarControl
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigosAGIP
        '
        Me.lblCodigosAGIP.AutoSize = True
        Me.lblCodigosAGIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigosAGIP.Location = New System.Drawing.Point(9, 4)
        Me.lblCodigosAGIP.Name = "lblCodigosAGIP"
        Me.lblCodigosAGIP.Size = New System.Drawing.Size(85, 13)
        Me.lblCodigosAGIP.TabIndex = 15
        Me.lblCodigosAGIP.Text = "Codigos AGIP"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(154, 357)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(245, 357)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 2)
        Me.Label1.TabIndex = 12
        '
        'txtCodigosAGIP
        '
        Me.txtCodigosAGIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigosAGIP.ConDecimal = False
        Me.txtCodigosAGIP.Location = New System.Drawing.Point(12, 20)
        Me.txtCodigosAGIP.Maximo = 0
        Me.txtCodigosAGIP.Multiline = True
        Me.txtCodigosAGIP.Name = "txtCodigosAGIP"
        Me.txtCodigosAGIP.Size = New System.Drawing.Size(308, 319)
        Me.txtCodigosAGIP.SoloLetra = False
        Me.txtCodigosAGIP.SoloNumero = False
        Me.txtCodigosAGIP.TabIndex = 1
        '
        'marqueeCarga
        '
        Me.marqueeCarga.EditValue = "Cargando..."
        Me.marqueeCarga.Location = New System.Drawing.Point(12, 358)
        Me.marqueeCarga.Name = "marqueeCarga"
        Me.marqueeCarga.Size = New System.Drawing.Size(136, 20)
        Me.marqueeCarga.TabIndex = 29
        '
        'frmFiltrarPadronAGIPMasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.marqueeCarga)
        Me.Controls.Add(Me.txtCodigosAGIP)
        Me.Controls.Add(Me.lblCodigosAGIP)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFiltrarPadronAGIPMasivo"
        Me.Text = "Elegir Códigos AGIP"
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigosAGIP As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigosAGIP As QUETOOL.txtTexto
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents marqueeCarga As DevExpress.XtraEditors.MarqueeProgressBarControl
End Class

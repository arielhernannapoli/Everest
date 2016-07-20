<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarPadronAGIP
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.marqueeCarga = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.lblArchivo = New System.Windows.Forms.Label
        Me.btnArchivo = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.dtpFecha = New QUETOOL.dtpFecha
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.txtArchivo = New QUETOOL.txtTexto
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 17)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 42)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(300, 111)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(219, 111)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'marqueeCarga
        '
        Me.marqueeCarga.EditValue = "Cargando..."
        Me.marqueeCarga.Location = New System.Drawing.Point(12, 113)
        Me.marqueeCarga.Name = "marqueeCarga"
        Me.marqueeCarga.Size = New System.Drawing.Size(201, 20)
        Me.marqueeCarga.TabIndex = 27
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(12, 67)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(43, 13)
        Me.lblArchivo.TabIndex = 28
        Me.lblArchivo.Text = "Archivo"
        '
        'btnArchivo
        '
        Me.btnArchivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchivo.Location = New System.Drawing.Point(343, 62)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Size = New System.Drawing.Size(32, 23)
        Me.btnArchivo.TabIndex = 3
        Me.btnArchivo.Text = "..."
        Me.btnArchivo.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dtpFecha
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFecha.Appearance = Appearance1
        Me.dtpFecha.FlatMode = True
        Me.dtpFecha.Location = New System.Drawing.Point(81, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(256, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Location = New System.Drawing.Point(81, 39)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(256, 20)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 2
        '
        'txtArchivo
        '
        Me.txtArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArchivo.ConDecimal = False
        Me.txtArchivo.Enabled = False
        Me.txtArchivo.Location = New System.Drawing.Point(81, 65)
        Me.txtArchivo.Maximo = 0
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(256, 20)
        Me.txtArchivo.SoloLetra = False
        Me.txtArchivo.SoloNumero = False
        Me.txtArchivo.TabIndex = 6
        '
        'frmCargarPadronAGIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 148)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnArchivo)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.marqueeCarga)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFecha)
        Me.Name = "frmCargarPadronAGIP"
        Me.Text = "Cargar Padron AGIP"
        CType(Me.marqueeCarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents marqueeCarga As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents btnArchivo As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dtpFecha As QUETOOL.dtpFecha
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents txtArchivo As QUETOOL.txtTexto
End Class

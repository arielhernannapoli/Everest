<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDuplicarConvenios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDuplicarConvenios))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.txtCodigo = New QUETOOL.txtTexto
        Me.dtpFechaFinD = New QUETOOL.dtpFecha
        Me.dtpFechaInicioD = New QUETOOL.dtpFecha
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtDescripcionDestino = New QUETOOL.txtTexto
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCodigoDestino = New QUETOOL.txtTexto
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinD)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicioD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 59)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese las Fechas del Convenio"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(222, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Fecha Hasta :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Fecha Desde :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.lblDescripcion)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 80)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Cliente Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Image = CType(resources.GetObject("lblDescripcion.Image"), System.Drawing.Image)
        Me.lblDescripcion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(399, 20)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(21, 21)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Location = New System.Drawing.Point(371, 261)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 26
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(290, 261)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 25
        Me.cmdAceptar.Text = "Aceptar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(88, 48)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(305, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ConDecimal = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(88, 20)
        Me.txtCodigo.Maximo = 0
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(305, 21)
        Me.txtCodigo.SoloLetra = False
        Me.txtCodigo.SoloNumero = True
        Me.txtCodigo.TabIndex = 0
        '
        'dtpFechaFinD
        '
        Appearance3.FontData.SizeInPoints = 9.0!
        Me.dtpFechaFinD.Appearance = Appearance3
        Me.dtpFechaFinD.FlatMode = True
        Me.dtpFechaFinD.Location = New System.Drawing.Point(307, 22)
        Me.dtpFechaFinD.Name = "dtpFechaFinD"
        Me.dtpFechaFinD.Size = New System.Drawing.Size(116, 21)
        Me.dtpFechaFinD.TabIndex = 24
        '
        'dtpFechaInicioD
        '
        Appearance4.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicioD.Appearance = Appearance4
        Me.dtpFechaInicioD.FlatMode = True
        Me.dtpFechaInicioD.Location = New System.Drawing.Point(95, 22)
        Me.dtpFechaInicioD.Name = "dtpFechaInicioD"
        Me.dtpFechaInicioD.Size = New System.Drawing.Size(116, 21)
        Me.dtpFechaInicioD.TabIndex = 23
        Me.dtpFechaInicioD.Value = Nothing
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescripcionDestino)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtCodigoDestino)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 80)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Cliente Destino"
        '
        'txtDescripcionDestino
        '
        Me.txtDescripcionDestino.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcionDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionDestino.ConDecimal = False
        Me.txtDescripcionDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionDestino.Location = New System.Drawing.Point(88, 48)
        Me.txtDescripcionDestino.Maximo = 0
        Me.txtDescripcionDestino.Name = "txtDescripcionDestino"
        Me.txtDescripcionDestino.ReadOnly = True
        Me.txtDescripcionDestino.Size = New System.Drawing.Size(305, 21)
        Me.txtDescripcionDestino.SoloLetra = False
        Me.txtDescripcionDestino.SoloNumero = False
        Me.txtDescripcionDestino.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Código"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripción"
        '
        'txtCodigoDestino
        '
        Me.txtCodigoDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoDestino.ConDecimal = False
        Me.txtCodigoDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoDestino.Location = New System.Drawing.Point(88, 20)
        Me.txtCodigoDestino.Maximo = 0
        Me.txtCodigoDestino.MaxLength = 4
        Me.txtCodigoDestino.Name = "txtCodigoDestino"
        Me.txtCodigoDestino.Size = New System.Drawing.Size(305, 21)
        Me.txtCodigoDestino.SoloLetra = False
        Me.txtCodigoDestino.SoloNumero = True
        Me.txtCodigoDestino.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(399, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDuplicarConvenios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 297)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDuplicarConvenios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicar Convenios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinD As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaInicioD As QUETOOL.dtpFecha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As QUETOOL.txtTexto
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionDestino As QUETOOL.txtTexto
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoDestino As QUETOOL.txtTexto
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

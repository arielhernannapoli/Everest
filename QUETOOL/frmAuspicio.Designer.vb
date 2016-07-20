<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuspicio
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtImporteD = New QUETOOL.txtTexto
        Me.dtpFechaFinD = New QUETOOL.dtpFecha
        Me.dtpFechaInicioD = New QUETOOL.dtpFecha
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.iugTemas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkDomingo = New System.Windows.Forms.CheckBox
        Me.chkSabado = New System.Windows.Forms.CheckBox
        Me.chkViernes = New System.Windows.Forms.CheckBox
        Me.chkJueves = New System.Windows.Forms.CheckBox
        Me.chkMiercoles = New System.Windows.Forms.CheckBox
        Me.chkMartes = New System.Windows.Forms.CheckBox
        Me.chkLunes = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.iugTemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtImporteD)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFinD)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicioD)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(579, 358)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese los Datos Solicitados"
        '
        'TxtImporteD
        '
        Me.TxtImporteD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtImporteD.ConDecimal = False
        Me.TxtImporteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImporteD.Location = New System.Drawing.Point(460, 329)
        Me.TxtImporteD.Maximo = 0
        Me.TxtImporteD.MaxLength = 10
        Me.TxtImporteD.Name = "TxtImporteD"
        Me.TxtImporteD.Size = New System.Drawing.Size(104, 21)
        Me.TxtImporteD.SoloLetra = False
        Me.TxtImporteD.SoloNumero = False
        Me.TxtImporteD.TabIndex = 17
        Me.TxtImporteD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaFinD
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFechaFinD.Appearance = Appearance1
        Me.dtpFechaFinD.FlatMode = True
        Me.dtpFechaFinD.Location = New System.Drawing.Point(340, 16)
        Me.dtpFechaFinD.Name = "dtpFechaFinD"
        Me.dtpFechaFinD.Size = New System.Drawing.Size(116, 21)
        Me.dtpFechaFinD.TabIndex = 16
        '
        'dtpFechaInicioD
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicioD.Appearance = Appearance2
        Me.dtpFechaInicioD.FlatMode = True
        Me.dtpFechaInicioD.Location = New System.Drawing.Point(109, 16)
        Me.dtpFechaInicioD.Name = "dtpFechaInicioD"
        Me.dtpFechaInicioD.Size = New System.Drawing.Size(116, 21)
        Me.dtpFechaInicioD.TabIndex = 15
        Me.dtpFechaInicioD.Value = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.iugTemas)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 219)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temas : "
        '
        'iugTemas
        '
        Me.iugTemas.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance3.BackColor = System.Drawing.Color.White
        Me.iugTemas.DisplayLayout.Appearance = Appearance3
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.iugTemas.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.iugTemas.DisplayLayout.Override.CellPadding = 3
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugTemas.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.iugTemas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.LightGray
        Appearance6.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugTemas.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.PowderBlue
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.iugTemas.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.iugTemas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugTemas.DisplayLayout.UseFixedHeaders = True
        Me.iugTemas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugTemas.FlatMode = True
        Me.iugTemas.Location = New System.Drawing.Point(3, 16)
        Me.iugTemas.Name = "iugTemas"
        Me.iugTemas.Size = New System.Drawing.Size(552, 200)
        Me.iugTemas.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nro. Avisos por Dia  :"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(255, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha Hasta :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = " "
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Desde :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Importe Bruto :"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(505, 372)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(417, 372)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 11
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkDomingo)
        Me.GroupBox3.Controls.Add(Me.chkSabado)
        Me.GroupBox3.Controls.Add(Me.chkViernes)
        Me.GroupBox3.Controls.Add(Me.chkJueves)
        Me.GroupBox3.Controls.Add(Me.chkMiercoles)
        Me.GroupBox3.Controls.Add(Me.chkMartes)
        Me.GroupBox3.Controls.Add(Me.chkLunes)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(561, 46)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dias a considerar"
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Location = New System.Drawing.Point(476, 19)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(68, 17)
        Me.chkDomingo.TabIndex = 6
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = True
        Me.chkSabado.Location = New System.Drawing.Point(396, 19)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 17)
        Me.chkSabado.TabIndex = 5
        Me.chkSabado.Text = "Sabado"
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = True
        Me.chkViernes.Location = New System.Drawing.Point(318, 19)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(61, 17)
        Me.chkViernes.TabIndex = 4
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = True
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = True
        Me.chkJueves.Location = New System.Drawing.Point(241, 19)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(60, 17)
        Me.chkJueves.TabIndex = 3
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = True
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = True
        Me.chkMiercoles.Location = New System.Drawing.Point(154, 19)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(71, 17)
        Me.chkMiercoles.TabIndex = 2
        Me.chkMiercoles.Text = "Miercoles"
        Me.chkMiercoles.UseVisualStyleBackColor = True
        '
        'chkMartes
        '
        Me.chkMartes.AutoSize = True
        Me.chkMartes.Location = New System.Drawing.Point(82, 19)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(58, 17)
        Me.chkMartes.TabIndex = 1
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.UseVisualStyleBackColor = True
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = True
        Me.chkLunes.Location = New System.Drawing.Point(9, 19)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(55, 17)
        Me.chkLunes.TabIndex = 0
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = True
        '
        'frmAuspicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 407)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAuspicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distribución Automatica"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpFechaFinD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.iugTemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAvisosDias As QUETOOL.txtTexto
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents iugTemas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents TxtImporte As QUETOOL.txtTexto
    Friend WithEvents dtpFechaInicio As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaFin As QUETOOL.dtpFecha
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
    Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
    Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
    Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
    Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaFinD As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaInicioD As QUETOOL.dtpFecha
    Friend WithEvents TxtImporteD As QUETOOL.txtTexto
End Class

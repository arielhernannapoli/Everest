<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestosPA
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.iugPautaSoporte = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uigpanticipado = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btoelegir = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.txttinversion = New QUETOOL.txtTexto
        Me.lblinversion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtTexto1 = New QUETOOL.txtTexto
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.iugPautaSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uigpanticipado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.iugPautaSoporte)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 424)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pauta / Soportes  "
        '
        'iugPautaSoporte
        '
        Me.iugPautaSoporte.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Me.iugPautaSoporte.DisplayLayout.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.iugPautaSoporte.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.iugPautaSoporte.DisplayLayout.Override.CellPadding = 3
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugPautaSoporte.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.iugPautaSoporte.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.LightGray
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugPautaSoporte.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.PowderBlue
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.iugPautaSoporte.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.iugPautaSoporte.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugPautaSoporte.DisplayLayout.UseFixedHeaders = True
        Me.iugPautaSoporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugPautaSoporte.FlatMode = True
        Me.iugPautaSoporte.Location = New System.Drawing.Point(3, 16)
        Me.iugPautaSoporte.Name = "iugPautaSoporte"
        Me.iugPautaSoporte.Size = New System.Drawing.Size(554, 405)
        Me.iugPautaSoporte.TabIndex = 10
        '
        'uigpanticipado
        '
        Me.uigpanticipado.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance6.BackColor = System.Drawing.Color.White
        Me.uigpanticipado.DisplayLayout.Appearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.uigpanticipado.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Me.uigpanticipado.DisplayLayout.Override.CellPadding = 3
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigpanticipado.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.uigpanticipado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance9.BorderColor = System.Drawing.Color.LightGray
        Appearance9.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigpanticipado.DisplayLayout.Override.RowAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.PowderBlue
        Appearance10.BorderColor = System.Drawing.Color.Black
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.uigpanticipado.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.uigpanticipado.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigpanticipado.DisplayLayout.UseFixedHeaders = True
        Me.uigpanticipado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uigpanticipado.FlatMode = True
        Me.uigpanticipado.Location = New System.Drawing.Point(3, 16)
        Me.uigpanticipado.Name = "uigpanticipado"
        Me.uigpanticipado.Size = New System.Drawing.Size(509, 470)
        Me.uigpanticipado.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.uigpanticipado)
        Me.GroupBox2.Location = New System.Drawing.Point(716, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 489)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccion Pago Anticipado    "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btoelegir)
        Me.GroupBox3.Location = New System.Drawing.Point(578, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 103)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(17, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 24)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Confirmar P.A"
        '
        'btoelegir
        '
        Me.btoelegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoelegir.Location = New System.Drawing.Point(17, 22)
        Me.btoelegir.Name = "btoelegir"
        Me.btoelegir.Size = New System.Drawing.Size(97, 24)
        Me.btoelegir.TabIndex = 27
        Me.btoelegir.Text = "Buscar P.A"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(1147, 535)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 24)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        '
        'txttinversion
        '
        Me.txttinversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttinversion.ConDecimal = False
        Me.txttinversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinversion.Location = New System.Drawing.Point(467, 507)
        Me.txttinversion.Maximo = 0
        Me.txttinversion.Name = "txttinversion"
        Me.txttinversion.Size = New System.Drawing.Size(102, 22)
        Me.txttinversion.SoloLetra = False
        Me.txttinversion.SoloNumero = False
        Me.txttinversion.TabIndex = 26
        '
        'lblinversion
        '
        Me.lblinversion.AutoSize = True
        Me.lblinversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinversion.Location = New System.Drawing.Point(262, 511)
        Me.lblinversion.Name = "lblinversion"
        Me.lblinversion.Size = New System.Drawing.Size(0, 16)
        Me.lblinversion.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1001, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Monto Consumido :"
        Me.Label1.Visible = False
        '
        'TxtTexto1
        '
        Me.TxtTexto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto1.ConDecimal = False
        Me.TxtTexto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto1.Location = New System.Drawing.Point(1124, 507)
        Me.TxtTexto1.Maximo = 0
        Me.TxtTexto1.Name = "TxtTexto1"
        Me.TxtTexto1.Size = New System.Drawing.Size(102, 22)
        Me.TxtTexto1.SoloLetra = False
        Me.TxtTexto1.SoloNumero = False
        Me.TxtTexto1.TabIndex = 30
        Me.TxtTexto1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtdia)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtBuscar)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 55)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Aplicar Filtros :"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(436, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 24)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Limpiar Filtros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Mes"
        '
        'txtdia
        '
        Me.txtdia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdia.Location = New System.Drawing.Point(364, 19)
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(50, 20)
        Me.txtdia.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Soportes "
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(75, 19)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(244, 20)
        Me.txtBuscar.TabIndex = 33
        '
        'frmPresupuestosPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 566)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TxtTexto1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblinversion)
        Me.Controls.Add(Me.txttinversion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPresupuestosPA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar y Relacionar Pago Anticipado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.iugPautaSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uigpanticipado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents iugPautaSoporte As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uigpanticipado As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btoelegir As System.Windows.Forms.Button
    Friend WithEvents txttinversion As QUETOOL.txtTexto
    Friend WithEvents lblinversion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTexto1 As QUETOOL.txtTexto
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

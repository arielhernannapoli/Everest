<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminPerfil))
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtregistrosCantidad = New QUETOOL.txtTexto
        Me.rdSinPermiso = New System.Windows.Forms.RadioButton
        Me.btobuscar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.iugUsuario = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.rdConPermiso = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtFiltroapellido = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtFoco = New System.Windows.Forms.TextBox
        Me.dtpFecha = New QUETOOL.dtpFecha
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtapeadmin = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnomadmin = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtregistrosCantidad
        '
        Me.txtregistrosCantidad.AcceptsReturn = True
        Me.txtregistrosCantidad.AcceptsTab = True
        Me.txtregistrosCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtregistrosCantidad.ConDecimal = False
        Me.txtregistrosCantidad.Location = New System.Drawing.Point(183, 609)
        Me.txtregistrosCantidad.Maximo = 0
        Me.txtregistrosCantidad.MaxLength = 5
        Me.txtregistrosCantidad.Name = "txtregistrosCantidad"
        Me.txtregistrosCantidad.ReadOnly = True
        Me.txtregistrosCantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtregistrosCantidad.SoloLetra = False
        Me.txtregistrosCantidad.SoloNumero = True
        Me.txtregistrosCantidad.TabIndex = 121
        Me.txtregistrosCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdSinPermiso
        '
        Me.rdSinPermiso.AutoSize = True
        Me.rdSinPermiso.Location = New System.Drawing.Point(169, 20)
        Me.rdSinPermiso.Name = "rdSinPermiso"
        Me.rdSinPermiso.Size = New System.Drawing.Size(118, 17)
        Me.rdSinPermiso.TabIndex = 10
        Me.rdSinPermiso.TabStop = True
        Me.rdSinPermiso.Text = "Mostrar Sin Permiso"
        Me.rdSinPermiso.UseVisualStyleBackColor = True
        '
        'btobuscar
        '
        Me.btobuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btobuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btobuscar.Location = New System.Drawing.Point(332, 17)
        Me.btobuscar.Name = "btobuscar"
        Me.btobuscar.Size = New System.Drawing.Size(90, 23)
        Me.btobuscar.TabIndex = 11
        Me.btobuscar.Text = "Buscar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 616)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 13)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Cantidad Registros Encontrados :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(435, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'iugUsuario
        '
        Me.iugUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Appearance7.BackColor = System.Drawing.Color.White
        Me.iugUsuario.DisplayLayout.Appearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.iugUsuario.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Me.iugUsuario.DisplayLayout.Override.CellPadding = 3
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugUsuario.DisplayLayout.Override.HeaderAppearance = Appearance9
        Appearance10.BorderColor = System.Drawing.Color.LightGray
        Appearance10.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugUsuario.DisplayLayout.Override.RowAppearance = Appearance10
        Me.iugUsuario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance11.BackColor = System.Drawing.Color.PowderBlue
        Appearance11.BorderColor = System.Drawing.Color.Black
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.iugUsuario.DisplayLayout.Override.SelectedRowAppearance = Appearance11
        Me.iugUsuario.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugUsuario.FlatMode = True
        Me.iugUsuario.Location = New System.Drawing.Point(7, 103)
        Me.iugUsuario.Name = "iugUsuario"
        Me.iugUsuario.Size = New System.Drawing.Size(560, 400)
        Me.iugUsuario.TabIndex = 34
        '
        'rdConPermiso
        '
        Me.rdConPermiso.AutoSize = True
        Me.rdConPermiso.Location = New System.Drawing.Point(12, 20)
        Me.rdConPermiso.Name = "rdConPermiso"
        Me.rdConPermiso.Size = New System.Drawing.Size(122, 17)
        Me.rdConPermiso.TabIndex = 9
        Me.rdConPermiso.TabStop = True
        Me.rdConPermiso.Text = "Mostrar Con Permiso"
        Me.rdConPermiso.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.iugUsuario)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 507)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuarios Sin Asignacion:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.btobuscar)
        Me.GroupBox3.Controls.Add(Me.rdSinPermiso)
        Me.GroupBox3.Controls.Add(Me.rdConPermiso)
        Me.GroupBox3.Controls.Add(Me.txtFiltroapellido)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(485, 78)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro Usuarios:"
        '
        'txtFiltroapellido
        '
        Me.txtFiltroapellido.Location = New System.Drawing.Point(111, 46)
        Me.txtFiltroapellido.Name = "txtFiltroapellido"
        Me.txtFiltroapellido.Size = New System.Drawing.Size(315, 20)
        Me.txtFiltroapellido.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Filtro por Nombre :"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(417, 606)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 118
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtFoco)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapeadmin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnomadmin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 77)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuario Administrador:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(524, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(225, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'txtFoco
        '
        Me.txtFoco.Location = New System.Drawing.Point(405, 48)
        Me.txtFoco.Name = "txtFoco"
        Me.txtFoco.Size = New System.Drawing.Size(105, 20)
        Me.txtFoco.TabIndex = 22
        Me.txtFoco.Visible = False
        '
        'dtpFecha
        '
        Appearance12.FontData.SizeInPoints = 9.0!
        Me.dtpFecha.Appearance = Appearance12
        Me.dtpFecha.FlatMode = True
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(355, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(161, 21)
        Me.dtpFecha.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Actual:"
        '
        'txtapeadmin
        '
        Me.txtapeadmin.Location = New System.Drawing.Point(71, 44)
        Me.txtapeadmin.Name = "txtapeadmin"
        Me.txtapeadmin.Size = New System.Drawing.Size(141, 20)
        Me.txtapeadmin.TabIndex = 3
        Me.txtapeadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido:"
        '
        'txtnomadmin
        '
        Me.txtnomadmin.Location = New System.Drawing.Point(71, 18)
        Me.txtnomadmin.Name = "txtnomadmin"
        Me.txtnomadmin.Size = New System.Drawing.Size(141, 20)
        Me.txtnomadmin.TabIndex = 1
        Me.txtnomadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(500, 606)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 119
        Me.cmdCancelar.Text = "Cancelar"
        '
        'frmAdminPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 636)
        Me.Controls.Add(Me.txtregistrosCantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdminPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Usuario Perfil"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtregistrosCantidad As QUETOOL.txtTexto
    Friend WithEvents rdSinPermiso As System.Windows.Forms.RadioButton
    Friend WithEvents btobuscar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents iugUsuario As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents rdConPermiso As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltroapellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFoco As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As QUETOOL.dtpFecha
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtapeadmin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnomadmin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class

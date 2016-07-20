<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaTarifasInternet
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpFecha = New QUETOOL.dtpFecha
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDesMedio = New QUETOOL.txtTexto
        Me.TxtSoporte = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDesCliente = New QUETOOL.txtTexto
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtApellidoUsuario = New QUETOOL.txtTexto
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombreUsuario = New QUETOOL.txtTexto
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtoSalir = New System.Windows.Forms.Button
        Me.BtoActualizarFila = New System.Windows.Forms.Button
        Me.BtoEliminarFila = New System.Windows.Forms.Button
        Me.BtoAgregarFila = New System.Windows.Forms.Button
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape14 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape13 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape12 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.iugTarifas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDesMedio)
        Me.GroupBox1.Controls.Add(Me.TxtSoporte)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDesCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(339, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Maestros :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Fecha Actual Carga"
        '
        'dtpFecha
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFecha.Appearance = Appearance1
        Me.dtpFecha.FlatMode = True
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(462, 57)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(107, 21)
        Me.dtpFecha.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Medio"
        '
        'txtDesMedio
        '
        Me.txtDesMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesMedio.ConDecimal = False
        Me.txtDesMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesMedio.Location = New System.Drawing.Point(401, 20)
        Me.txtDesMedio.Maximo = 0
        Me.txtDesMedio.MaxLength = 4
        Me.txtDesMedio.Name = "txtDesMedio"
        Me.txtDesMedio.Size = New System.Drawing.Size(170, 21)
        Me.txtDesMedio.SoloLetra = False
        Me.txtDesMedio.SoloNumero = True
        Me.txtDesMedio.TabIndex = 18
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSoporte.Location = New System.Drawing.Point(56, 54)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.MaxLength = 4
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.Size = New System.Drawing.Size(293, 21)
        Me.TxtSoporte.SoloLetra = False
        Me.TxtSoporte.SoloNumero = True
        Me.TxtSoporte.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Soporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Cliente"
        '
        'txtDesCliente
        '
        Me.txtDesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesCliente.ConDecimal = False
        Me.txtDesCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesCliente.Location = New System.Drawing.Point(56, 21)
        Me.txtDesCliente.Maximo = 0
        Me.txtDesCliente.MaxLength = 4
        Me.txtDesCliente.Name = "txtDesCliente"
        Me.txtDesCliente.Size = New System.Drawing.Size(293, 21)
        Me.txtDesCliente.SoloLetra = False
        Me.txtDesCliente.SoloNumero = True
        Me.txtDesCliente.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtApellidoUsuario)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(30, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuario Responsable :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Apellido :"
        '
        'txtApellidoUsuario
        '
        Me.txtApellidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellidoUsuario.ConDecimal = False
        Me.txtApellidoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoUsuario.Location = New System.Drawing.Point(65, 49)
        Me.txtApellidoUsuario.Maximo = 0
        Me.txtApellidoUsuario.MaxLength = 4
        Me.txtApellidoUsuario.Name = "txtApellidoUsuario"
        Me.txtApellidoUsuario.Size = New System.Drawing.Size(164, 21)
        Me.txtApellidoUsuario.SoloLetra = False
        Me.txtApellidoUsuario.SoloNumero = True
        Me.txtApellidoUsuario.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre :"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.ConDecimal = False
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(65, 22)
        Me.txtNombreUsuario.Maximo = 0
        Me.txtNombreUsuario.MaxLength = 4
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(164, 21)
        Me.txtNombreUsuario.SoloLetra = False
        Me.txtNombreUsuario.SoloNumero = True
        Me.txtNombreUsuario.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtoSalir)
        Me.GroupBox3.Controls.Add(Me.BtoActualizarFila)
        Me.GroupBox3.Controls.Add(Me.BtoEliminarFila)
        Me.GroupBox3.Controls.Add(Me.BtoAgregarFila)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(980, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 89)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operaciones :"
        '
        'BtoSalir
        '
        Me.BtoSalir.BackColor = System.Drawing.Color.Gray
        Me.BtoSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtoSalir.ForeColor = System.Drawing.Color.White
        Me.BtoSalir.Location = New System.Drawing.Point(122, 51)
        Me.BtoSalir.Name = "BtoSalir"
        Me.BtoSalir.Size = New System.Drawing.Size(101, 30)
        Me.BtoSalir.TabIndex = 3
        Me.BtoSalir.Text = "&Salir"
        Me.BtoSalir.UseVisualStyleBackColor = False
        '
        'BtoActualizarFila
        '
        Me.BtoActualizarFila.BackColor = System.Drawing.Color.Gray
        Me.BtoActualizarFila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtoActualizarFila.ForeColor = System.Drawing.Color.White
        Me.BtoActualizarFila.Location = New System.Drawing.Point(122, 19)
        Me.BtoActualizarFila.Name = "BtoActualizarFila"
        Me.BtoActualizarFila.Size = New System.Drawing.Size(101, 30)
        Me.BtoActualizarFila.TabIndex = 2
        Me.BtoActualizarFila.Text = "&Actualizar Tarifa"
        Me.BtoActualizarFila.UseVisualStyleBackColor = False
        '
        'BtoEliminarFila
        '
        Me.BtoEliminarFila.BackColor = System.Drawing.Color.Gray
        Me.BtoEliminarFila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtoEliminarFila.ForeColor = System.Drawing.Color.White
        Me.BtoEliminarFila.Location = New System.Drawing.Point(15, 52)
        Me.BtoEliminarFila.Name = "BtoEliminarFila"
        Me.BtoEliminarFila.Size = New System.Drawing.Size(101, 30)
        Me.BtoEliminarFila.TabIndex = 1
        Me.BtoEliminarFila.Text = "&EliminarTarifa"
        Me.BtoEliminarFila.UseVisualStyleBackColor = False
        '
        'BtoAgregarFila
        '
        Me.BtoAgregarFila.BackColor = System.Drawing.Color.Gray
        Me.BtoAgregarFila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtoAgregarFila.ForeColor = System.Drawing.Color.White
        Me.BtoAgregarFila.Location = New System.Drawing.Point(15, 19)
        Me.BtoAgregarFila.Name = "BtoAgregarFila"
        Me.BtoAgregarFila.Size = New System.Drawing.Size(101, 30)
        Me.BtoAgregarFila.TabIndex = 0
        Me.BtoAgregarFila.Text = "&Nueva Tarifa"
        Me.BtoAgregarFila.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape14, Me.LineShape13, Me.LineShape12, Me.LineShape11, Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1240, 776)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape14
        '
        Me.LineShape14.BorderColor = System.Drawing.Color.Silver
        Me.LineShape14.Name = "LineShape14"
        Me.LineShape14.X1 = 930
        Me.LineShape14.X2 = 967
        Me.LineShape14.Y1 = 65
        Me.LineShape14.Y2 = 65
        '
        'LineShape13
        '
        Me.LineShape13.BorderColor = System.Drawing.Color.Silver
        Me.LineShape13.Name = "LineShape13"
        Me.LineShape13.X1 = 930
        Me.LineShape13.X2 = 967
        Me.LineShape13.Y1 = 59
        Me.LineShape13.Y2 = 59
        '
        'LineShape12
        '
        Me.LineShape12.BorderColor = System.Drawing.Color.Silver
        Me.LineShape12.Name = "LineShape12"
        Me.LineShape12.X1 = 930
        Me.LineShape12.X2 = 967
        Me.LineShape12.Y1 = 52
        Me.LineShape12.Y2 = 52
        '
        'LineShape11
        '
        Me.LineShape11.BorderColor = System.Drawing.Color.Silver
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 930
        Me.LineShape11.X2 = 967
        Me.LineShape11.Y1 = 46
        Me.LineShape11.Y2 = 46
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.Silver
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 930
        Me.LineShape10.X2 = 967
        Me.LineShape10.Y1 = 39
        Me.LineShape10.Y2 = 39
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.Color.Silver
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 930
        Me.LineShape9.X2 = 967
        Me.LineShape9.Y1 = 33
        Me.LineShape9.Y2 = 33
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Silver
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 290
        Me.LineShape8.X2 = 327
        Me.LineShape8.Y1 = 65
        Me.LineShape8.Y2 = 65
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.Silver
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 290
        Me.LineShape7.X2 = 327
        Me.LineShape7.Y1 = 59
        Me.LineShape7.Y2 = 59
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.Silver
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 290
        Me.LineShape6.X2 = 327
        Me.LineShape6.Y1 = 39
        Me.LineShape6.Y2 = 39
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.Silver
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 290
        Me.LineShape5.X2 = 327
        Me.LineShape5.Y1 = 33
        Me.LineShape5.Y2 = 33
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 290
        Me.LineShape4.X2 = 327
        Me.LineShape4.Y1 = 52
        Me.LineShape4.Y2 = 52
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Silver
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 290
        Me.LineShape3.X2 = 327
        Me.LineShape3.Y1 = 46
        Me.LineShape3.Y2 = 46
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 9
        Me.LineShape2.X2 = 1235
        Me.LineShape2.Y1 = 106
        Me.LineShape2.Y2 = 106
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 1235
        Me.LineShape1.Y1 = 101
        Me.LineShape1.Y2 = 101
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.iugTarifas)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(11, 116)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1224, 648)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Confeccion de Tarifas :"
        '
        'iugTarifas
        '
        Me.iugTarifas.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugTarifas.DisplayLayout.Appearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.iugTarifas.DisplayLayout.Override.CardAreaAppearance = Appearance3
        Me.iugTarifas.DisplayLayout.Override.CellPadding = 3
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugTarifas.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.iugTarifas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance5.BorderColor = System.Drawing.Color.LightGray
        Appearance5.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugTarifas.DisplayLayout.Override.RowAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.PowderBlue
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.iugTarifas.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.iugTarifas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugTarifas.DisplayLayout.UseFixedHeaders = True
        Me.iugTarifas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugTarifas.FlatMode = True
        Me.iugTarifas.Location = New System.Drawing.Point(3, 17)
        Me.iugTarifas.Name = "iugTarifas"
        Me.iugTarifas.Size = New System.Drawing.Size(1218, 628)
        Me.iugTarifas.TabIndex = 12
        '
        'frmAltaTarifasInternet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 776)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAltaTarifasInternet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas Internet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSoporte As QUETOOL.txtTexto
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesCliente As QUETOOL.txtTexto
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesMedio As QUETOOL.txtTexto
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoUsuario As QUETOOL.txtTexto
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As QUETOOL.txtTexto
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtoAgregarFila As System.Windows.Forms.Button
    Friend WithEvents BtoEliminarFila As System.Windows.Forms.Button
    Friend WithEvents BtoActualizarFila As System.Windows.Forms.Button
    Friend WithEvents BtoSalir As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape14 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape13 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape12 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As QUETOOL.dtpFecha
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents iugTarifas As Infragistics.Win.UltraWinGrid.UltraGrid
End Class

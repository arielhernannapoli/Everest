Public Class frmConvenios
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub

    'Public Sub New() 'ByVal dtSoportes As DataTable, ByVal f_desde As Date, ByVal f_hasta As Date, Optional ByVal Datos As Infragistics.Win.UltraWinDataSource.UltraDataSource = Nothing, Optional ByVal Spot As DataTable = Nothing)
    '    MyBase.New()

    '    'El Diseñador de Windows Forms requiere esta llamada.
    '    InitializeComponent()

    '    'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    '    'Cargar(dtSoportes, f_desde, f_hasta, Datos, Spot)
    'End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAplicar As System.Windows.Forms.Button
    Friend WithEvents iugConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents TxtSoporte As QUETOOL.txtTexto
    Friend WithEvents txtProducto As QUETOOL.txtTexto
    Friend WithEvents txtDetalle As QUETOOL.txtTexto
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fraDescuentos As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDesc4 As QUETOOL.txtTexto
    Friend WithEvents txtDesc3 As QUETOOL.txtTexto
    Friend WithEvents txtDesc2 As QUETOOL.txtTexto
    Friend WithEvents txtDesc1 As QUETOOL.txtTexto
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDesc5 As QUETOOL.txtTexto
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTexto2 As QUETOOL.txtTexto
    Friend WithEvents fra As System.Windows.Forms.GroupBox
    Friend WithEvents txtParticipacion As QUETOOL.txtTexto
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtHasta As QUETOOL.txtTexto
    Friend WithEvents txtDesde As QUETOOL.txtTexto
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents txtSemana As QUETOOL.txtTexto
    Friend WithEvents lblSemana As System.Windows.Forms.Label
    Friend WithEvents txtNeto As QUETOOL.txtTexto
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.fra = New System.Windows.Forms.GroupBox
        Me.txtSemana = New QUETOOL.txtTexto
        Me.lblSemana = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtHasta = New QUETOOL.txtTexto
        Me.txtDesde = New QUETOOL.txtTexto
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtParticipacion = New QUETOOL.txtTexto
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDetalle = New QUETOOL.txtTexto
        Me.txtProducto = New QUETOOL.txtTexto
        Me.TxtSoporte = New QUETOOL.txtTexto
        Me.txtCliente = New QUETOOL.txtTexto
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAplicar = New System.Windows.Forms.Button
        Me.fraDescuentos = New System.Windows.Forms.GroupBox
        Me.lblCosto = New System.Windows.Forms.Label
        Me.txtNeto = New QUETOOL.txtTexto
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDesc5 = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDesc4 = New QUETOOL.txtTexto
        Me.txtDesc3 = New QUETOOL.txtTexto
        Me.txtDesc2 = New QUETOOL.txtTexto
        Me.txtDesc1 = New QUETOOL.txtTexto
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtTexto2 = New QUETOOL.txtTexto
        CType(Me.iugConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fra.SuspendLayout()
        Me.fraDescuentos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'iugConvenios
        '
        Me.iugConvenios.Cursor = System.Windows.Forms.Cursors.Default
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.iugConvenios.DisplayLayout.Appearance = Appearance13
        Me.iugConvenios.DisplayLayout.GroupByBox.Prompt = "Arrastre el encabezado de la columna aquí para agrupar por esa columna"
        Me.iugConvenios.DisplayLayout.InterBandSpacing = 10
        Me.iugConvenios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.iugConvenios.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.iugConvenios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.iugConvenios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.iugConvenios.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Me.iugConvenios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.iugConvenios.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.ForeColor = System.Drawing.Color.Black
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.iugConvenios.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.iugConvenios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.iugConvenios.DisplayLayout.Override.RowAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.iugConvenios.DisplayLayout.Override.RowSelectorAppearance = Appearance17
        Me.iugConvenios.DisplayLayout.Override.RowSelectorWidth = 12
        Me.iugConvenios.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.iugConvenios.DisplayLayout.Override.SelectedRowAppearance = Appearance18
        Me.iugConvenios.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugConvenios.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugConvenios.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.iugConvenios.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.iugConvenios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.iugConvenios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugConvenios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugConvenios.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.iugConvenios.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.iugConvenios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.iugConvenios.Location = New System.Drawing.Point(12, 8)
        Me.iugConvenios.Name = "iugConvenios"
        Me.iugConvenios.Size = New System.Drawing.Size(672, 236)
        Me.iugConvenios.TabIndex = 17
        '
        'fra
        '
        Me.fra.Controls.Add(Me.txtSemana)
        Me.fra.Controls.Add(Me.lblSemana)
        Me.fra.Controls.Add(Me.Label10)
        Me.fra.Controls.Add(Me.Label11)
        Me.fra.Controls.Add(Me.txtHasta)
        Me.fra.Controls.Add(Me.txtDesde)
        Me.fra.Controls.Add(Me.Label9)
        Me.fra.Controls.Add(Me.txtParticipacion)
        Me.fra.Controls.Add(Me.Label4)
        Me.fra.Controls.Add(Me.Label3)
        Me.fra.Controls.Add(Me.Label2)
        Me.fra.Controls.Add(Me.Label1)
        Me.fra.Controls.Add(Me.txtDetalle)
        Me.fra.Controls.Add(Me.txtProducto)
        Me.fra.Controls.Add(Me.TxtSoporte)
        Me.fra.Controls.Add(Me.txtCliente)
        Me.fra.Location = New System.Drawing.Point(12, 252)
        Me.fra.Name = "fra"
        Me.fra.Size = New System.Drawing.Size(488, 241)
        Me.fra.TabIndex = 18
        Me.fra.TabStop = False
        Me.fra.Text = "Detalle "
        '
        'txtSemana
        '
        Me.txtSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSemana.ConDecimal = False
        Me.txtSemana.Location = New System.Drawing.Point(80, 211)
        Me.txtSemana.Maximo = 0
        Me.txtSemana.Name = "txtSemana"
        Me.txtSemana.Size = New System.Drawing.Size(144, 20)
        Me.txtSemana.SoloLetra = True
        Me.txtSemana.SoloNumero = False
        Me.txtSemana.TabIndex = 63
        Me.txtSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(11, 212)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(46, 13)
        Me.lblSemana.TabIndex = 62
        Me.lblSemana.Text = "Semana"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(261, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Hora Hasta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Hora Desde"
        '
        'txtHasta
        '
        Me.txtHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHasta.ConDecimal = False
        Me.txtHasta.Location = New System.Drawing.Point(332, 185)
        Me.txtHasta.Maximo = 0
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(144, 20)
        Me.txtHasta.SoloLetra = True
        Me.txtHasta.SoloNumero = False
        Me.txtHasta.TabIndex = 11
        Me.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesde
        '
        Me.txtDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesde.ConDecimal = False
        Me.txtDesde.Location = New System.Drawing.Point(80, 185)
        Me.txtDesde.Maximo = 0
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(144, 20)
        Me.txtDesde.SoloLetra = True
        Me.txtDesde.SoloNumero = False
        Me.txtDesde.TabIndex = 10
        Me.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Participación"
        '
        'txtParticipacion
        '
        Me.txtParticipacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParticipacion.ConDecimal = False
        Me.txtParticipacion.Location = New System.Drawing.Point(80, 161)
        Me.txtParticipacion.Maximo = 0
        Me.txtParticipacion.Name = "txtParticipacion"
        Me.txtParticipacion.Size = New System.Drawing.Size(396, 20)
        Me.txtParticipacion.SoloLetra = True
        Me.txtParticipacion.SoloNumero = False
        Me.txtParticipacion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Detalle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Soporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente"
        '
        'txtDetalle
        '
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalle.ConDecimal = False
        Me.txtDetalle.Location = New System.Drawing.Point(80, 92)
        Me.txtDetalle.Maximo = 0
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(396, 60)
        Me.txtDetalle.SoloLetra = True
        Me.txtDetalle.SoloNumero = False
        Me.txtDetalle.TabIndex = 3
        '
        'txtProducto
        '
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProducto.ConDecimal = False
        Me.txtProducto.Location = New System.Drawing.Point(80, 68)
        Me.txtProducto.Maximo = 0
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(396, 20)
        Me.txtProducto.SoloLetra = True
        Me.txtProducto.SoloNumero = False
        Me.txtProducto.TabIndex = 2
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Location = New System.Drawing.Point(80, 44)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.Size = New System.Drawing.Size(396, 20)
        Me.TxtSoporte.SoloLetra = True
        Me.TxtSoporte.SoloNumero = False
        Me.TxtSoporte.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(80, 20)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(396, 20)
        Me.txtCliente.SoloLetra = True
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 0
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(584, 566)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 24)
        Me.cmdSalir.TabIndex = 58
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAplicar
        '
        Me.cmdAplicar.Location = New System.Drawing.Point(492, 566)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.Size = New System.Drawing.Size(88, 24)
        Me.cmdAplicar.TabIndex = 57
        Me.cmdAplicar.Text = "Aplicar"
        '
        'fraDescuentos
        '
        Me.fraDescuentos.Controls.Add(Me.lblCosto)
        Me.fraDescuentos.Controls.Add(Me.txtNeto)
        Me.fraDescuentos.Controls.Add(Me.Label13)
        Me.fraDescuentos.Controls.Add(Me.txtDesc5)
        Me.fraDescuentos.Controls.Add(Me.Label5)
        Me.fraDescuentos.Controls.Add(Me.Label6)
        Me.fraDescuentos.Controls.Add(Me.Label7)
        Me.fraDescuentos.Controls.Add(Me.Label8)
        Me.fraDescuentos.Controls.Add(Me.txtDesc4)
        Me.fraDescuentos.Controls.Add(Me.txtDesc3)
        Me.fraDescuentos.Controls.Add(Me.txtDesc2)
        Me.fraDescuentos.Controls.Add(Me.txtDesc1)
        Me.fraDescuentos.Location = New System.Drawing.Point(504, 252)
        Me.fraDescuentos.Name = "fraDescuentos"
        Me.fraDescuentos.Size = New System.Drawing.Size(180, 172)
        Me.fraDescuentos.TabIndex = 59
        Me.fraDescuentos.TabStop = False
        Me.fraDescuentos.Text = "Descuentos"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(12, 142)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(0, 13)
        Me.lblCosto.TabIndex = 11
        '
        'txtNeto
        '
        Me.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNeto.ConDecimal = False
        Me.txtNeto.Location = New System.Drawing.Point(88, 140)
        Me.txtNeto.Maximo = 0
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Size = New System.Drawing.Size(80, 20)
        Me.txtNeto.SoloLetra = True
        Me.txtNeto.SoloNumero = False
        Me.txtNeto.TabIndex = 10
        Me.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Descuento 5"
        '
        'txtDesc5
        '
        Me.txtDesc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc5.ConDecimal = False
        Me.txtDesc5.Location = New System.Drawing.Point(88, 116)
        Me.txtDesc5.Maximo = 0
        Me.txtDesc5.Name = "txtDesc5"
        Me.txtDesc5.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc5.SoloLetra = True
        Me.txtDesc5.SoloNumero = False
        Me.txtDesc5.TabIndex = 8
        Me.txtDesc5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Descuento 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descuento 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Descuento 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Descuento 1"
        '
        'txtDesc4
        '
        Me.txtDesc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc4.ConDecimal = False
        Me.txtDesc4.Location = New System.Drawing.Point(88, 92)
        Me.txtDesc4.Maximo = 0
        Me.txtDesc4.Name = "txtDesc4"
        Me.txtDesc4.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc4.SoloLetra = True
        Me.txtDesc4.SoloNumero = False
        Me.txtDesc4.TabIndex = 3
        Me.txtDesc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc3
        '
        Me.txtDesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc3.ConDecimal = False
        Me.txtDesc3.Location = New System.Drawing.Point(88, 68)
        Me.txtDesc3.Maximo = 0
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc3.SoloLetra = True
        Me.txtDesc3.SoloNumero = False
        Me.txtDesc3.TabIndex = 2
        Me.txtDesc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc2
        '
        Me.txtDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc2.ConDecimal = False
        Me.txtDesc2.Location = New System.Drawing.Point(88, 44)
        Me.txtDesc2.Maximo = 0
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc2.SoloLetra = True
        Me.txtDesc2.SoloNumero = False
        Me.txtDesc2.TabIndex = 1
        Me.txtDesc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc1
        '
        Me.txtDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc1.ConDecimal = False
        Me.txtDesc1.Location = New System.Drawing.Point(88, 20)
        Me.txtDesc1.Maximo = 0
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc1.SoloLetra = True
        Me.txtDesc1.SoloNumero = False
        Me.txtDesc1.TabIndex = 0
        Me.txtDesc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTexto2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 499)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 64)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Observaciones"
        '
        'TxtTexto2
        '
        Me.TxtTexto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto2.ConDecimal = False
        Me.TxtTexto2.Location = New System.Drawing.Point(12, 16)
        Me.TxtTexto2.Maximo = 0
        Me.TxtTexto2.Multiline = True
        Me.TxtTexto2.Name = "TxtTexto2"
        Me.TxtTexto2.Size = New System.Drawing.Size(648, 40)
        Me.TxtTexto2.SoloLetra = True
        Me.TxtTexto2.SoloNumero = False
        Me.TxtTexto2.TabIndex = 9
        '
        'frmConvenios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(694, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fraDescuentos)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAplicar)
        Me.Controls.Add(Me.fra)
        Me.Controls.Add(Me.iugConvenios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConvenios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenios"
        CType(Me.iugConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fra.ResumeLayout(False)
        Me.fra.PerformLayout()
        Me.fraDescuentos.ResumeLayout(False)
        Me.fraDescuentos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Class cConvenios
        Public Id_Convenio As Int64
        Public Id_Soporte As Int64
        Public Tipo_Convenio As String
        Public Descripcion As String
        Public H_Desde As String
        Public H_Hasta As String
        Public Dcto1 As Single
        Public Dcto2 As Single
        Public Dcto3 As Single
        Public Dcto4 As Single
        Public Dcto5 As Single
        Public Neto As Double

    End Class


    Dim Id_Soporte As Int64
    Dim Tipo_Convenio As String
    Dim Descripcion As String
    Dim H_Desde As String
    Dim H_Hasta As String
    Dim Dcto1 As Single
    Dim Dcto2 As Single
    Dim Dcto3 As Single
    Dim Dcto4 As Single
    Dim Dcto5 As Single
    Dim Neto As Double
    Dim Dias As String
    Dim CPR As Double 'AG CCPR
    Dim Salir As Boolean
#Region "Propiedades"
    Dim mId_Convenio As Int64
    Dim mid_Spot As Int64
    Dim mUltraData As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Dim arConvenios() As ArrayList
    Dim mSoportes As DataTable
    Dim mSpots As DataTable
    Dim mEsGlobal As Boolean
    Dim mRow As Infragistics.Win.UltraWinDataSource.UltraDataRow
    Dim mF_desde As Date
    Dim mF_Hasta As Date

    Public Property F_desde() As Date
        Get
            Return mF_desde
        End Get
        Set(ByVal Value As Date)
            mF_desde = Value
        End Set
    End Property
    Public Property F_Hasta() As Date
        Get
            Return mF_Hasta
        End Get
        Set(ByVal Value As Date)
            mF_Hasta = Value
        End Set
    End Property
    Public Property EsGlobal() As Boolean
        Get
            Return mEsGlobal
        End Get
        Set(ByVal Value As Boolean)
            mEsGlobal = Value
        End Set
    End Property
    Public Property UltraData() As Infragistics.Win.UltraWinDataSource.UltraDataSource
        Get
            Return mUltraData
        End Get
        Set(ByVal Value As Infragistics.Win.UltraWinDataSource.UltraDataSource)
            mUltraData = Value
        End Set
    End Property
    Public Property Soportes() As DataTable
        Get
            Return mSoportes
        End Get
        Set(ByVal Value As DataTable)
            mSoportes = Value
        End Set
    End Property
    Public Property Spots() As DataTable
        Get
            Return mSpots
        End Get
        Set(ByVal Value As DataTable)
            mSpots = Value
        End Set
    End Property
    Public Property Row() As Infragistics.Win.UltraWinDataSource.UltraDataRow
        Get
            Return mRow
        End Get
        Set(ByVal Value As Infragistics.Win.UltraWinDataSource.UltraDataRow)
            mRow = Value
        End Set
    End Property
    Property Id_Convenio()
        Get
            Id_Convenio = mId_Convenio
        End Get
        Set(ByVal Value)
            mId_Convenio = Value
        End Set
    End Property
    Public Property id_Spot() As Int64
        Get
            Return mid_Spot
        End Get
        Set(ByVal Value As Int64)
            mid_Spot = Value
        End Set
    End Property
#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Id_Convenio = -1
        Me.Salir = True
        Me.Close()
    End Sub

    Private Sub iugConvenios_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iugConvenios.MouseUp
        Dim aUIElement As Infragistics.Win.UIElement
        Try
            aUIElement = iugConvenios.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
            ' declare and retrieve a reference to the Cell
            Dim aRow As Infragistics.Win.UltraWinGrid.UltraGridRow
            aRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            ' if a cell was found display the band and column key
            If Not aRow Is Nothing Then
                MostrarFila(iugConvenios.ActiveRow)
            End If
        Catch ex As Exception
            ' no hago nada, lo pongo porque si toca en algun momento los desplazamientos de la grilla, da error y no se modifica nada
        End Try

    End Sub

    Private Sub MostrarFila(ByVal r As Infragistics.Win.UltraWinGrid.UltraGridRow)
        Try

            If r.Cells Is Nothing Then ' esta seleccionado una fila que esta agrupada
                Exit Sub
            End If

            txtCliente.Text = IIf(IsDBNull(r.Cells("descripcion1").Value), "", r.Cells("descripcion1").Value)
            TxtSoporte.Text = IIf(IsDBNull(r.Cells("descripcion").Value), "", r.Cells("descripcion").Value)
            txtProducto.Text = IIf(IsDBNull(r.Cells("descripcion2").Value), "", r.Cells("descripcion2").Value)
            txtDetalle.Text = IIf(IsDBNull(r.Cells("Detalle").Value), "", r.Cells("Detalle").Value)
            txtParticipacion.Text = IIf(IsDBNull(r.Cells("Participacion").Value), "", r.Cells("Participacion").Value)
            txtDesde.Text = IIf(IsDBNull(r.Cells("hh_desde").Value), "", Trim(Str(r.Cells("hh_desde").Value)).PadLeft(2, "0") & ":" & Trim(Str(r.Cells("mm_desde").Value)).PadLeft(2, "0"))
            txtHasta.Text = IIf(IsDBNull(r.Cells("hh_hasta").Value), "", Trim(Str(r.Cells("hh_hasta").Value)).PadLeft(2, "0") & ":" & Trim(Str(r.Cells("mm_hasta").Value)).PadLeft(2, "0"))
            'RM 1/7/2011----------------------------------------------------------------------------
            txtSemana.Text = IIf(IsDBNull(r.Cells("semana").Value), "", r.Cells("semana").Value)
            '----------------------------------------------------------------------------------------
            'AG CCPR Anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'If r.Cells("Tipo_Convenio").Value = "D" Then
            '    txtNeto.Enabled = True
            '    lblCosto.Text = "Costo Bruto"
            '    txtDesc1.Enabled = True
            '    txtDesc2.Enabled = True
            '    txtDesc3.Enabled = True
            '    txtDesc4.Enabled = True
            '    txtDesc5.Enabled = True
            '    txtNeto.Text = IIf(IsDBNull(r.Cells("Neto").Value), "", r.Cells("Neto").Value)
            '    txtDesc1.Text = IIf(IsDBNull(r.Cells("Dcto1").Value), "", r.Cells("Dcto1").Value)
            '    txtDesc2.Text = IIf(IsDBNull(r.Cells("Dcto2").Value), "", r.Cells("Dcto2").Value)
            '    txtDesc3.Text = IIf(IsDBNull(r.Cells("Dcto3").Value), "", r.Cells("Dcto3").Value)
            '    txtDesc4.Text = IIf(IsDBNull(r.Cells("Dcto4").Value), "", r.Cells("Dcto4").Value)
            '    txtDesc5.Text = IIf(IsDBNull(r.Cells("Dcto5").Value), "", r.Cells("Dcto5").Value)
            'Else
            '    txtNeto.Enabled = True
            '    lblCosto.Text = "Costo Neto"
            '    txtDesc1.Enabled = False
            '    txtDesc2.Enabled = False
            '    txtDesc3.Enabled = False
            '    txtDesc4.Enabled = False
            '    txtDesc5.Enabled = False
            '    txtNeto.Text = IIf(IsDBNull(r.Cells("Neto").Value), "", r.Cells("Neto").Value)
            '    txtDesc1.Text = ""
            '    txtDesc2.Text = ""
            '    txtDesc3.Text = ""
            '    txtDesc4.Text = ""
            '    txtDesc5.Text = ""
            'End If
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'AG CCPR  
            If r.Cells("Tipo_Convenio").Value = "D" Then
                txtNeto.Enabled = True
                lblCosto.Text = "Costo Bruto"
                txtDesc1.Enabled = True
                txtDesc2.Enabled = True
                txtDesc3.Enabled = True
                txtDesc4.Enabled = True
                txtDesc5.Enabled = True
                txtNeto.Text = IIf(IsDBNull(r.Cells("Neto").Value), "", r.Cells("Neto").Value)
                txtDesc1.Text = IIf(IsDBNull(r.Cells("Dcto1").Value), "", r.Cells("Dcto1").Value)
                txtDesc2.Text = IIf(IsDBNull(r.Cells("Dcto2").Value), "", r.Cells("Dcto2").Value)
                txtDesc3.Text = IIf(IsDBNull(r.Cells("Dcto3").Value), "", r.Cells("Dcto3").Value)
                txtDesc4.Text = IIf(IsDBNull(r.Cells("Dcto4").Value), "", r.Cells("Dcto4").Value)
                txtDesc5.Text = IIf(IsDBNull(r.Cells("Dcto5").Value), "", r.Cells("Dcto5").Value)
            ElseIf r.Cells("Tipo_Convenio").Value = "T" Then 'AG CCPR
                txtNeto.Enabled = True
                lblCosto.Text = "Costo Neto"
                txtDesc1.Enabled = False
                txtDesc2.Enabled = False
                txtDesc3.Enabled = False
                txtDesc4.Enabled = False
                txtDesc5.Enabled = False
                txtNeto.Text = IIf(IsDBNull(r.Cells("Neto").Value), "", r.Cells("Neto").Value)
                txtDesc1.Text = ""
                txtDesc2.Text = ""
                txtDesc3.Text = ""
                txtDesc4.Text = ""
                txtDesc5.Text = ""
            ElseIf r.Cells("Tipo_Convenio").Value = "C" Then 'AG CCPR
                txtDesc1.Text = IIf(IsDBNull(r.Cells("CPR").Value), "", r.Cells("CPR").Value)
            End If

        Catch ex As Exception
            Mensajes.Mensaje(ex.ToString)
        End Try

    End Sub

    Public Sub Cargar()
        Dim o As New Convenios
        Dim dti As DataTable
        Dim dtf As New DataTable

        Try
            For Each row As DataRow In mSoportes.Rows
                o.Id_cliente = Activo.IDCliente
                o.Id_soporte = row("id_soporte")
                o.F_inicio = F_desde
                o.F_fin = F_Hasta
                o.Id_medio = Activo.IDMedio
                dti = o.CargarGrillaxSoporte()
                If Not dti Is Nothing Then ' si encontro algo
                    CopiarDT(dti, dtf)
                End If
            Next

            If Not dtf.Equals(Nothing) AndAlso dtf.Rows.Count > 0 Then
                iugConvenios.DataSource = dtf
                ConfiguararControles() 'AG CCPR
                FormatearGrilla()
            End If

        Catch ex As Exception
            Mensajes.Mensaje(ex.ToString)
        End Try

    End Sub

    Private Sub FormatearGrilla()
        Dim i As Integer

        Listas.OcultarColumnas(iugConvenios, "id_medio", "id_soporte", "id_cliente", "id_producto", "participacion", "programa", "dcto1", "dcto2", "dcto3", "dcto4", "dcto5", "neto", "observaciones", "semana", "hh_desde", "mm_desde", "hh_hasta", "mm_hasta")
        Listas.CambiarTituloColumna(iugConvenios, "Id_convenio", "CODIGO")
        Listas.CambiarTituloColumna(iugConvenios, "Tipo_Convenio", "TIPO CONVENIO")
        Listas.CambiarTituloColumna(iugConvenios, "descripcion", "SOPORTE")
        Listas.CambiarTituloColumna(iugConvenios, "descripcion1", "CLIENTE")
        Listas.CambiarTituloColumna(iugConvenios, "descripcion2", "PRODUCTO")
        Listas.CambiarTituloColumna(iugConvenios, "F_Inicio", "VIG. DESDE")
        Listas.CambiarTituloColumna(iugConvenios, "F_Fin", "VIG. HASTA")
        With iugConvenios.DisplayLayout
            .Bands(0).Columns("Id_convenio").Header.VisiblePosition = 0
            .Bands(0).Columns("descripcion").Header.VisiblePosition = 1
            .Bands(0).Columns("descripcion1").Header.VisiblePosition = 2
            .Bands(0).Columns("descripcion2").Header.VisiblePosition = 3
            .GroupByBox.Prompt = "Arrastre el encabezado de la columna aquí para agrupar por esa columna"
            'For i = 0 To .Bands(0).Columns.Count - 1
            '    .Bands(0).Columns(i).PerformAutoResize()
            'Next
        End With
    End Sub

    Private Sub CopiarDT(ByVal dtDesde As DataTable, ByRef dtHasta As DataTable)
        Try
            If dtHasta.Columns.Count > 0 Then
                For Each row As DataRow In dtDesde.Rows
                    dtHasta.ImportRow(row)
                Next
            Else ' copio el primero para tener la estructura
                dtHasta = dtDesde.Copy
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub iugConvenios_BeforeSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles iugConvenios.BeforeSelectChange
        MostrarFila(iugConvenios.ActiveRow)
    End Sub

    Private Sub Aplicar()
        With iugConvenios.ActiveRow
            mId_Convenio = IIf(IsDBNull(.Cells("id_convenio").Value), -1, .Cells("id_convenio").Value)
            Id_Soporte = IIf(IsDBNull(.Cells("id_soporte").Value), -1, .Cells("id_soporte").Value)
            Descripcion = IIf(IsDBNull(.Cells("Detalle").Value), -1, .Cells("Detalle").Value)
            Tipo_Convenio = IIf(IsDBNull(.Cells("Tipo_Convenio").Value), -1, .Cells("Tipo_Convenio").Value)
            H_Desde = IIf(IsDBNull(.Cells("hh_desde").Value), "", Trim(Str(.Cells("hh_desde").Value)).PadLeft(2, "0") & ":" & Trim(Str(.Cells("mm_desde").Value)).PadLeft(2, "0"))
            H_Hasta = IIf(IsDBNull(.Cells("hh_hasta").Value), "", Trim(Str(.Cells("hh_hasta").Value)).PadLeft(2, "0") & ":" & Trim(Str(.Cells("mm_hasta").Value)).PadLeft(2, "0"))
            Dcto1 = IIf(IsDBNull(.Cells("Dcto1").Value), 0, .Cells("Dcto1").Value)
            Dcto2 = IIf(IsDBNull(.Cells("Dcto2").Value), 0, .Cells("Dcto2").Value)
            Dcto3 = IIf(IsDBNull(.Cells("Dcto3").Value), 0, .Cells("Dcto3").Value)
            Dcto4 = IIf(IsDBNull(.Cells("Dcto4").Value), 0, .Cells("Dcto4").Value)
            Dcto5 = IIf(IsDBNull(.Cells("Dcto5").Value), 0, .Cells("Dcto5").Value)
            Neto = IIf(IsDBNull(.Cells("Neto").Value), 0, .Cells("Neto").Value)
            Dias = IIf(IsDBNull(.Cells("Semana").Value), "", .Cells("Semana").Value)
            'AG CCPR 
            If Activo.TEjecicioActivo = 1 Then
                CPR = IIf(IsDBNull(.Cells("CPR").Value), "", .Cells("CPR").Value)
            End If
        End With
        AplicarConvenio()
    End Sub
    Private Sub cmdAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAplicar.Click
        If iugConvenios.ActiveRow Is Nothing Then
            Exit Sub
        End If
        Aplicar()
    End Sub

    Private Sub AplicarConvenio()

        Dim Conv As New TipoConvenio
        Dim Condicion As New CondicionConvenio

        With Conv
            .IDConvenio = Me.Id_Convenio
            .Descripcion = Me.Descripcion

            If Me.Tipo_Convenio = "D" Then
                .TipoConvenio = eTipoConvenio.Descuento
            ElseIf Me.Tipo_Convenio = "T" Then  'AG CCPR
                .TipoConvenio = eTipoConvenio.TarifaPlana
            ElseIf Me.Tipo_Convenio = "C" Then  'AG CCPR
                .TipoConvenio = eTipoConvenio.CPR
                .CPR = Me.CPR
            End If

            .Descuento1 = Me.Dcto1
            .Descuento2 = Me.Dcto2
            .Descuento3 = Me.Dcto3
            .Descuento4 = Me.Dcto4
            .Descuento5 = Me.Dcto5
            .Neto = Me.Neto
        End With

        With Condicion
            .HoraDesde = Me.H_Desde
            .HoraHasta = Me.H_Hasta
            .IDSoporte = Me.Id_Soporte
        End With

        If mEsGlobal Then
            Dim GrillaConvenio As New GrillaConvenio
            GrillaConvenio.AplicarConvenioGlobal(mUltraData, mSpots, Conv, Condicion, Dias)
        Else
            ' Dim IDSpot As Integer = Me.iugEjercicio.ActiveRow.Cells("id_spot").Value
            Dim Ur As Infragistics.Win.UltraWinDataSource.UltraDataRow = ObtenerUltraDataRow(mid_Spot)
            Dim GrillaConvenio As New GrillaConvenio
            GrillaConvenio.AplicarConvenioPuntual(Ur, mSpots, Conv, Condicion, Dias)
        End If

    End Sub

    Private Function ObtenerUltraDataRow(ByVal IDSpot As Integer) As Infragistics.Win.UltraWinDataSource.UltraDataRow
        Dim Ur As Infragistics.Win.UltraWinDataSource.UltraDataRow

        For Each Ur In Me.UltraData.Rows
            If Ur.Item("id_spot") = IDSpot Then
                Return Ur
            End If
        Next
    End Function

    Private Sub frmConvenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConfiguararControles()
        'AG CCPR 
        If Activo.TEjecicioActivo = 1 Then
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.Label7.Visible = False
            Me.Label13.Visible = False
            txtDesc2.Visible = False
            txtDesc3.Visible = False
            txtDesc4.Visible = False
            txtDesc5.Visible = False
            txtNeto.Visible = False
            Me.Label8.Text = "CPR"
            Me.lblCosto.Visible = False
        End If

    End Sub

End Class

Imports Infragistics.Win.UltraWinGrid
Imports System.Text

Public Class frmConveniosMedios
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

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
    Friend WithEvents ugConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents fra As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtParticipacion As QUETOOL.txtTexto
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As QUETOOL.txtTexto
    Friend WithEvents txtProducto As QUETOOL.txtTexto
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents fraDescuentos As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDesc5 As QUETOOL.txtTexto
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDesc4 As QUETOOL.txtTexto
    Friend WithEvents txtDesc3 As QUETOOL.txtTexto
    Friend WithEvents txtDesc2 As QUETOOL.txtTexto
    Friend WithEvents txtDesc1 As QUETOOL.txtTexto
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAplicar As System.Windows.Forms.Button
    Friend WithEvents txtSoporte As QUETOOL.txtTexto
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNeto As QUETOOL.txtTexto
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVigenciaDesde As QUETOOL.txtTexto
    Friend WithEvents txtVigenciaHasta As QUETOOL.txtTexto
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ugConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.fra = New System.Windows.Forms.GroupBox
        Me.txtVigenciaHasta = New QUETOOL.txtTexto
        Me.txtVigenciaDesde = New QUETOOL.txtTexto
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtParticipacion = New QUETOOL.txtTexto
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDetalle = New QUETOOL.txtTexto
        Me.txtProducto = New QUETOOL.txtTexto
        Me.txtSoporte = New QUETOOL.txtTexto
        Me.txtCliente = New QUETOOL.txtTexto
        Me.fraDescuentos = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
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
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAplicar = New System.Windows.Forms.Button
        CType(Me.ugConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fra.SuspendLayout()
        Me.fraDescuentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugConvenios
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugConvenios.DisplayLayout.Appearance = Appearance1
        Me.ugConvenios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.ugConvenios.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugConvenios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugConvenios.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugConvenios.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugConvenios.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugConvenios.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugConvenios.DisplayLayout.MaxColScrollRegions = 1
        Me.ugConvenios.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugConvenios.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugConvenios.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugConvenios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ugConvenios.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugConvenios.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ugConvenios.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugConvenios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugConvenios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugConvenios.DisplayLayout.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        Me.ugConvenios.DisplayLayout.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        Me.ugConvenios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugConvenios.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.ugConvenios.DisplayLayout.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.ugConvenios.DisplayLayout.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        Me.ugConvenios.DisplayLayout.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.ugConvenios.DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.ugConvenios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.ugConvenios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugConvenios.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugConvenios.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugConvenios.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugConvenios.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugConvenios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugConvenios.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugConvenios.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugConvenios.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugConvenios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugConvenios.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugConvenios.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugConvenios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugConvenios.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugConvenios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugConvenios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugConvenios.Location = New System.Drawing.Point(3, 2)
        Me.ugConvenios.Name = "ugConvenios"
        Me.ugConvenios.Size = New System.Drawing.Size(672, 236)
        Me.ugConvenios.TabIndex = 0
        Me.ugConvenios.Text = "UltraGrid1"
        '
        'fra
        '
        Me.fra.Controls.Add(Me.txtVigenciaHasta)
        Me.fra.Controls.Add(Me.txtVigenciaDesde)
        Me.fra.Controls.Add(Me.Label12)
        Me.fra.Controls.Add(Me.Label11)
        Me.fra.Controls.Add(Me.Label9)
        Me.fra.Controls.Add(Me.txtParticipacion)
        Me.fra.Controls.Add(Me.Label4)
        Me.fra.Controls.Add(Me.Label3)
        Me.fra.Controls.Add(Me.Label2)
        Me.fra.Controls.Add(Me.Label1)
        Me.fra.Controls.Add(Me.txtDetalle)
        Me.fra.Controls.Add(Me.txtProducto)
        Me.fra.Controls.Add(Me.txtSoporte)
        Me.fra.Controls.Add(Me.txtCliente)
        Me.fra.Location = New System.Drawing.Point(3, 245)
        Me.fra.Name = "fra"
        Me.fra.Size = New System.Drawing.Size(473, 166)
        Me.fra.TabIndex = 19
        Me.fra.TabStop = False
        Me.fra.Text = "Detalle "
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVigenciaHasta.ConDecimal = False
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(328, 140)
        Me.txtVigenciaHasta.Maximo = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.ReadOnly = True
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(136, 20)
        Me.txtVigenciaHasta.SoloLetra = True
        Me.txtVigenciaHasta.SoloNumero = False
        Me.txtVigenciaHasta.TabIndex = 6
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVigenciaDesde.ConDecimal = False
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(89, 140)
        Me.txtVigenciaDesde.Maximo = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.ReadOnly = True
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(136, 20)
        Me.txtVigenciaDesde.SoloLetra = True
        Me.txtVigenciaDesde.SoloNumero = False
        Me.txtVigenciaDesde.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Vigencia Hasta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Vigencia Desde"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Participación"
        '
        'txtParticipacion
        '
        Me.txtParticipacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParticipacion.ConDecimal = False
        Me.txtParticipacion.Location = New System.Drawing.Point(89, 116)
        Me.txtParticipacion.Maximo = 0
        Me.txtParticipacion.Name = "txtParticipacion"
        Me.txtParticipacion.ReadOnly = True
        Me.txtParticipacion.Size = New System.Drawing.Size(375, 20)
        Me.txtParticipacion.SoloLetra = True
        Me.txtParticipacion.SoloNumero = False
        Me.txtParticipacion.TabIndex = 4
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
        Me.txtDetalle.Location = New System.Drawing.Point(89, 92)
        Me.txtDetalle.Maximo = 0
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ReadOnly = True
        Me.txtDetalle.Size = New System.Drawing.Size(375, 20)
        Me.txtDetalle.SoloLetra = True
        Me.txtDetalle.SoloNumero = False
        Me.txtDetalle.TabIndex = 3
        '
        'txtProducto
        '
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProducto.ConDecimal = False
        Me.txtProducto.Location = New System.Drawing.Point(89, 68)
        Me.txtProducto.Maximo = 0
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(375, 20)
        Me.txtProducto.SoloLetra = True
        Me.txtProducto.SoloNumero = False
        Me.txtProducto.TabIndex = 2
        '
        'txtSoporte
        '
        Me.txtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSoporte.ConDecimal = False
        Me.txtSoporte.Location = New System.Drawing.Point(89, 44)
        Me.txtSoporte.Maximo = 0
        Me.txtSoporte.Name = "txtSoporte"
        Me.txtSoporte.ReadOnly = True
        Me.txtSoporte.Size = New System.Drawing.Size(375, 20)
        Me.txtSoporte.SoloLetra = True
        Me.txtSoporte.SoloNumero = False
        Me.txtSoporte.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(89, 20)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(375, 20)
        Me.txtCliente.SoloLetra = True
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 0
        '
        'fraDescuentos
        '
        Me.fraDescuentos.Controls.Add(Me.Label10)
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
        Me.fraDescuentos.Location = New System.Drawing.Point(495, 245)
        Me.fraDescuentos.Name = "fraDescuentos"
        Me.fraDescuentos.Size = New System.Drawing.Size(180, 166)
        Me.fraDescuentos.TabIndex = 60
        Me.fraDescuentos.TabStop = False
        Me.fraDescuentos.Text = "Descuentos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Neto"
        '
        'txtNeto
        '
        Me.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNeto.ConDecimal = True
        Me.txtNeto.Location = New System.Drawing.Point(88, 140)
        Me.txtNeto.Maximo = 0
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.ReadOnly = True
        Me.txtNeto.Size = New System.Drawing.Size(80, 20)
        Me.txtNeto.SoloLetra = False
        Me.txtNeto.SoloNumero = True
        Me.txtNeto.TabIndex = 5
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
        Me.txtDesc5.ConDecimal = True
        Me.txtDesc5.Location = New System.Drawing.Point(88, 116)
        Me.txtDesc5.Maximo = 0
        Me.txtDesc5.Name = "txtDesc5"
        Me.txtDesc5.ReadOnly = True
        Me.txtDesc5.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc5.SoloLetra = False
        Me.txtDesc5.SoloNumero = True
        Me.txtDesc5.TabIndex = 4
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
        Me.txtDesc4.ConDecimal = True
        Me.txtDesc4.Location = New System.Drawing.Point(88, 92)
        Me.txtDesc4.Maximo = 0
        Me.txtDesc4.Name = "txtDesc4"
        Me.txtDesc4.ReadOnly = True
        Me.txtDesc4.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc4.SoloLetra = False
        Me.txtDesc4.SoloNumero = True
        Me.txtDesc4.TabIndex = 3
        Me.txtDesc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc3
        '
        Me.txtDesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc3.ConDecimal = True
        Me.txtDesc3.Location = New System.Drawing.Point(88, 68)
        Me.txtDesc3.Maximo = 0
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.ReadOnly = True
        Me.txtDesc3.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc3.SoloLetra = False
        Me.txtDesc3.SoloNumero = True
        Me.txtDesc3.TabIndex = 2
        Me.txtDesc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc2
        '
        Me.txtDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc2.ConDecimal = True
        Me.txtDesc2.Location = New System.Drawing.Point(88, 44)
        Me.txtDesc2.Maximo = 0
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.ReadOnly = True
        Me.txtDesc2.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc2.SoloLetra = False
        Me.txtDesc2.SoloNumero = True
        Me.txtDesc2.TabIndex = 1
        Me.txtDesc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc1
        '
        Me.txtDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc1.ConDecimal = True
        Me.txtDesc1.Location = New System.Drawing.Point(88, 20)
        Me.txtDesc1.Maximo = 0
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.ReadOnly = True
        Me.txtDesc1.Size = New System.Drawing.Size(80, 20)
        Me.txtDesc1.SoloLetra = False
        Me.txtDesc1.SoloNumero = True
        Me.txtDesc1.TabIndex = 0
        Me.txtDesc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(587, 416)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 24)
        Me.cmdSalir.TabIndex = 64
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAplicar
        '
        Me.cmdAplicar.Location = New System.Drawing.Point(496, 416)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.Size = New System.Drawing.Size(88, 24)
        Me.cmdAplicar.TabIndex = 63
        Me.cmdAplicar.Text = "Aplicar"
        '
        'frmConveniosMedios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 446)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAplicar)
        Me.Controls.Add(Me.fraDescuentos)
        Me.Controls.Add(Me.fra)
        Me.Controls.Add(Me.ugConvenios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConveniosMedios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenios"
        CType(Me.ugConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fra.ResumeLayout(False)
        Me.fra.PerformLayout()
        Me.fraDescuentos.ResumeLayout(False)
        Me.fraDescuentos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mFechaDesde, mFechaHasta As DateTime
    Private mSoportes, mProductos As ArrayList
    Private mIdCliente, mIdMedio As Integer
    Private dtConvenio As DataTable
    Private mPuntual As Boolean
    Private mSinConvenios As Boolean
    Private DtConveniosMultiples As DataTable
#End Region

#Region "Variables y Propiedades Publicas"
    Public Event AplicarConvenio(ByVal pId_Convenio As Integer, ByVal pId_Soporte As Integer, ByVal pId_Producto As Integer, ByVal pD1 As Double, ByVal pD2 As Double, ByVal pD3 As Double, ByVal pD4 As Double, ByVal pD5 As Double, ByVal pNeto As Double, ByVal pTipoConvenio As String, ByVal pPuntual As Boolean)

    Public WriteOnly Property FechaDesde() As DateTime
        Set(ByVal Value As DateTime)
            mFechaDesde = Value
        End Set
    End Property

    Public WriteOnly Property FechaHasta() As DateTime
        Set(ByVal Value As DateTime)
            mFechaHasta = Value
        End Set
    End Property

    Public WriteOnly Property Soportes() As ArrayList
        Set(ByVal Value As ArrayList)
            mSoportes = Value
        End Set
    End Property

    Public WriteOnly Property Productos() As ArrayList
        Set(ByVal Value As ArrayList)
            mProductos = Value
        End Set
    End Property

    Public WriteOnly Property IdCliente() As Integer
        Set(ByVal Value As Integer)
            mIdCliente = Value
        End Set
    End Property

    Public WriteOnly Property IdMedio() As Integer
        Set(ByVal Value As Integer)
            mIdMedio = Value
        End Set
    End Property

    Public WriteOnly Property Puntual() As Boolean
        Set(ByVal Value As Boolean)
            mPuntual = Value
        End Set
    End Property

    Public Property SinConvenios() As Boolean
        Get
            Return mSinConvenios
        End Get
        Set(ByVal Value As Boolean)
            mSinConvenios = Value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmConveniosMedios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LimpiarControles()
        Call CargarConvenios()
    End Sub

    Private Sub ugConvenios_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ugConvenios.AfterSelectChange
        MostrarFila(ugConvenios.ActiveRow)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAplicar.Click
        Call EnviarConvenio()
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub CargarConvenios()

        Dim Convenio As New Convenios
        Dim dtConvenios As DataTable
        Dim FiltroProducto As New StringBuilder

        If Not mSoportes Is Nothing AndAlso mSoportes.Count > 0 Then
            If Not mProductos Is Nothing AndAlso mProductos.Count > 0 Then
                FiltroProducto.Append("Id_Producto IN (0,")
                For Index As Integer = 0 To mProductos.Count - 1
                    FiltroProducto.Append(mProductos(Index))
                    If Index < mProductos.Count - 1 Then
                        FiltroProducto.Append(",")
                    End If
                Next
                FiltroProducto.Append(")")
            End If
            For Index As Integer = 0 To mSoportes.Count - 1
                Convenio.Id_cliente = mIdCliente
                Convenio.Id_soporte = mSoportes(Index)
                Convenio.F_inicio = mFechaDesde
                Convenio.F_fin = mFechaHasta
                Convenio.Id_medio = mIdMedio
                dtConvenios = Convenio.CargarGrillaxSoporte()
                If dtConvenios Is Nothing Then
                    'AG 20/12/2013 ==================================================================
                    'Mensajes.Mensaje("No existen convenios para los parametros especificados", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
                    'SinConvenios = True
                    'Exit Sub
                    '=================================================================================
                Else
                    'AG 20/12/2013 ==================================================================
                    If Not dtConvenios Is Nothing Then
                        dtConvenio = dtConvenios.Clone
                        If DtConveniosMultiples Is Nothing Then
                            DtConveniosMultiples = dtConvenios.Clone
                        End If
                    End If
                    '================================================================================
                    'AG 20/12/2013 Codigo Anterior ==================================================
                    'dtConvenio = dtConvenios.Clone
                    'If DtConveniosMultiples Is Nothing Then
                    'DtConveniosMultiples = dtConvenios.Clone
                    'End If
                    '=================================================================================
                End If
                If Not dtConvenios Is Nothing AndAlso dtConvenios.Rows.Count > 0 Then
                    For Each drConvenios As DataRow In dtConvenios.Select(FiltroProducto.ToString)
                        'dtConvenio.ImportRow(drConvenios) AG 28/11/2013
                        Dim DrFilaNueva As DataRow
                        DtConveniosMultiples.ImportRow(drConvenios)
                    Next
                End If
            Next

            If DtConveniosMultiples Is Nothing Then
                Mensajes.Mensaje("No existen convenios para los parametros especificados", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
                SinConvenios = True
                Exit Sub
            Else
                ugConvenios.DataSource = DtConveniosMultiples 'dtConvenio
                FormatearGrilla()
                If ugConvenios.Rows.Count > 0 Then
                    ugConvenios.ActiveRow = ugConvenios.Rows(0)
                    ugConvenios.Rows(0).Selected = True
                    DtConveniosMultiples = Nothing
                End If
            End If
        End If
    End Sub

    Private Function NuevaFilaConvenio(ByVal Drows As DataRow, ByVal DRowNueva As DataRow) As DataRow

        If Not Drows Is Nothing Then
            DRowNueva("ID_MEDIO") = Drows("ID_MEDIO")
            DRowNueva("ID_SOPORTE") = Drows("ID_SOPORTE")
            DRowNueva("ID_CLIENTE") = Drows("ID_CLIENTE")
            DRowNueva("ID_PRODUCTO") = Drows("ID_PRODUCTO")
            DRowNueva("ID_CONVENIO") = Drows("ID_CONVENIO")
            DRowNueva("F_INICIO") = Drows("F_INICIO")
            DRowNueva("F_FIN") = Drows("F_FIN")
            DRowNueva("DETALLE") = Drows("DETALLE")
            DRowNueva("PARTICIPACION") = Drows("PARTICIPACION")
            DRowNueva("PROGRAMA") = Drows("PROGRAMA")
            DRowNueva("DCTO1") = Drows("DCTO1")
            DRowNueva("DCTO2") = Drows("DCTO2")
            DRowNueva("DCTO3") = Drows("DCTO3")
            DRowNueva("DCTO4") = Drows("DCTO4")
            DRowNueva("DCTO5") = Drows("DCTO5")
            DRowNueva("NETO") = Drows("NETO")
            DRowNueva("OBSERVACIONES") = Drows("OBSERVACIONES")
            DRowNueva("SEMANA") = Drows("SEMANA")
            DRowNueva("HH_DESDE") = Drows("HH_DESDE")
            DRowNueva("HH_HASTA") = Drows("HH_HASTA")
            DRowNueva("MM_DESDE") = Drows("MM_DESDE")
            DRowNueva("MM_HASTA") = Drows("MM_HASTA")
            DRowNueva("TIPO_CONVENIO") = Drows("TIPO_CONVENIO")
        End If

        Return DRowNueva

    End Function

    Private Sub LimpiarControles()
        ugConvenios.DataSource = Nothing
        dtConvenio = Nothing

        txtCliente.Text = String.Empty
        txtSoporte.Text = String.Empty
        txtProducto.Text = String.Empty
        txtDetalle.Text = String.Empty
        txtParticipacion.Text = String.Empty
        txtVigenciaDesde.Text = String.Empty
        txtVigenciaHasta.Text = String.Empty

        txtDesc1.Text = 0
        txtDesc2.Text = 0
        txtDesc3.Text = 0
        txtDesc4.Text = 0
        txtDesc5.Text = 0
        txtNeto.Text = 0
    End Sub

    Private Sub FormatearGrilla()
        ugConvenios.DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.RowSelect

        Listas.OcultarColumnas(ugConvenios, "id_medio", "id_soporte", "id_cliente", "id_producto", "participacion", "programa", "dcto1", "dcto2", "dcto3", "dcto4", "dcto5", "neto", "observaciones", "semana", "hh_desde", "mm_desde", "hh_hasta", "mm_hasta")
        'CF 10/10/2014 AGREGADO DE COLUMNAS DE CODIGO DE CONVENIOS Y FECHA DE VIGENCIA
        Listas.CambiarTituloColumna(ugConvenios, "Id_convenio", "CODIGO")
        Listas.CambiarTituloColumna(ugConvenios, "Tipo_Convenio", "TIPO CONVENIO")
        Listas.CambiarTituloColumna(ugConvenios, "descripcion", "SOPORTE")
        Listas.CambiarTituloColumna(ugConvenios, "descripcion1", "CLIENTE")
        Listas.CambiarTituloColumna(ugConvenios, "descripcion2", "PRODUCTO")
        Listas.CambiarTituloColumna(ugConvenios, "F_Inicio", "VIG. DESDE")
        Listas.CambiarTituloColumna(ugConvenios, "F_Fin", "VIG. HASTA")
        With ugConvenios.DisplayLayout
            .Bands(0).Columns("Id_convenio").Header.VisiblePosition = 0
            .Bands(0).Columns("descripcion").Header.VisiblePosition = 1
            .Bands(0).Columns("descripcion1").Header.VisiblePosition = 2
            .Bands(0).Columns("descripcion2").Header.VisiblePosition = 3
        End With
        For Each Columna As UltraGridColumn In ugConvenios.DisplayLayout.Bands(0).Columns
            Columna.SortIndicator = SortIndicator.Disabled
        Next
    End Sub

    Private Sub MostrarFila(ByVal pConvenio As UltraGridRow)
        Dim DefaultValue As Double

        If pConvenio.Cells Is Nothing Then
            Exit Sub
        End If

        txtCliente.Text = ObtenerValor(pConvenio, "descripcion1")
        txtSoporte.Text = ObtenerValor(pConvenio, "descripcion")
        txtProducto.Text = ObtenerValor(pConvenio, "descripcion2")
        txtDetalle.Text = ObtenerValor(pConvenio, "Detalle")
        txtParticipacion.Text = ObtenerValor(pConvenio, "Participacion")
        txtVigenciaDesde.Text = ObtenerValor(pConvenio, "F_Inicio")
        txtVigenciaHasta.Text = ObtenerValor(pConvenio, "F_Fin")

        If ObtenerValor(pConvenio, "Tipo_Convenio") = "D" Then
            txtDesc1.Text = ObtenerValorNumerico(pConvenio, "Dcto1")
            txtDesc2.Text = ObtenerValorNumerico(pConvenio, "Dcto2")
            txtDesc3.Text = ObtenerValorNumerico(pConvenio, "Dcto3")
            txtDesc4.Text = ObtenerValorNumerico(pConvenio, "Dcto4")
            txtDesc5.Text = ObtenerValorNumerico(pConvenio, "Dcto5")
            'AG 16/06/2014 ==========================================
            txtNeto.Text = ObtenerValorNumerico(pConvenio, "Neto")
            'txtNeto.Text = DefaultValue
            '=======================================================
        Else
            txtDesc1.Text = DefaultValue
            txtDesc2.Text = DefaultValue
            txtDesc3.Text = DefaultValue
            txtDesc4.Text = DefaultValue
            txtDesc5.Text = DefaultValue
            txtNeto.Text = ObtenerValorNumerico(pConvenio, "Neto")
        End If
    End Sub

    Private Sub EnviarConvenio()
        If Not ugConvenios Is Nothing AndAlso ugConvenios.Rows.Count > 0 AndAlso Not ugConvenios.ActiveRow Is Nothing Then
            Dim D1, D2, D3, D4, D5, Neto As Double
            Dim Soporte, Producto, Convenio As Integer
            Dim TipoConvenio As String

            Convenio = Convert.ToInt32(ObtenerValor(ugConvenios.ActiveRow, "Id_Convenio"))
            Soporte = Convert.ToInt32(ObtenerValor(ugConvenios.ActiveRow, "Id_Soporte"))
            Producto = Convert.ToInt32(ObtenerValor(ugConvenios.ActiveRow, "Id_Producto"))
            D1 = ObtenerValorNumerico(ugConvenios.ActiveRow, "Dcto1")
            D2 = ObtenerValorNumerico(ugConvenios.ActiveRow, "Dcto2")
            D3 = ObtenerValorNumerico(ugConvenios.ActiveRow, "Dcto3")
            D4 = ObtenerValorNumerico(ugConvenios.ActiveRow, "Dcto4")
            D5 = ObtenerValorNumerico(ugConvenios.ActiveRow, "Dcto5")
            Neto = ObtenerValorNumerico(ugConvenios.ActiveRow, "Neto")
            TipoConvenio = ObtenerValor(ugConvenios.ActiveRow, "Tipo_Convenio")

            RaiseEvent AplicarConvenio(Convenio, Soporte, Producto, D1, D2, D3, D4, D5, Neto, TipoConvenio, mPuntual)
        End If
    End Sub

    Private Function ObtenerValor(ByVal pConvenio As UltraGridRow, ByVal pColumnName As String) As String
        If pConvenio.Cells(pColumnName).Value Is DBNull.Value Then
            Return String.Empty
        Else
            Return pConvenio.Cells(pColumnName).Value
        End If
    End Function

    Private Function ObtenerValorNumerico(ByVal pConvenio As UltraGridRow, ByVal pColumnName As String) As Double
        Dim DefaultValue As Double
        If pConvenio.Cells(pColumnName).Value Is DBNull.Value Then
            Return DefaultValue
        Else
            Return Double.Parse(pConvenio.Cells(pColumnName).Value)
            'Return Convert.ToDouble(pConvenio.Cells(pColumnName).Value)
        End If
    End Function
#End Region

End Class

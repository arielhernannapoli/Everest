<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConveniosReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConveniosReporte))
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboVigente = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboTipoSoporte = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboMedio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.TxtCodMedio = New QUETOOL.txtTexto
        Me.lblDesCliente = New System.Windows.Forms.Label
        Me.lblDesSoporte = New System.Windows.Forms.Label
        Me.TxtSoporte = New QUETOOL.txtTexto
        Me.TxtCodSoporte = New QUETOOL.txtTexto
        Me.lblSoporte = New System.Windows.Forms.Label
        Me.lblMedio = New System.Windows.Forms.Label
        Me.txtCliente = New QUETOOL.txtTexto
        Me.txtCodCliente = New QUETOOL.txtTexto
        Me.lblCliente = New System.Windows.Forms.Label
        Me.cmdExportar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdLimpiar = New System.Windows.Forms.Button
        Me.uigExportar = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uigGrillaConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtregistrosCantidad = New QUETOOL.txtTexto
        Me.cmdVerAnexos = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uigExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboVigente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboTipoSoporte)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboMedio)
        Me.GroupBox1.Controls.Add(Me.TxtCodMedio)
        Me.GroupBox1.Controls.Add(Me.lblDesCliente)
        Me.GroupBox1.Controls.Add(Me.lblDesSoporte)
        Me.GroupBox1.Controls.Add(Me.TxtSoporte)
        Me.GroupBox1.Controls.Add(Me.TxtCodSoporte)
        Me.GroupBox1.Controls.Add(Me.lblSoporte)
        Me.GroupBox1.Controls.Add(Me.lblMedio)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1013, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de Busqueda :"
        '
        'cboVigente
        '
        Me.cboVigente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVigente.ItemHeight = 13
        Me.cboVigente.Items.AddRange(New Object() {"Si", "No", "Todos"})
        Me.cboVigente.Location = New System.Drawing.Point(69, 45)
        Me.cboVigente.Name = "cboVigente"
        Me.cboVigente.Size = New System.Drawing.Size(103, 21)
        Me.cboVigente.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Vigente"
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.AutoSize = True
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Location = New System.Drawing.Point(417, 47)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.ReadOnly = True
        Me.cboTipoSoporte.Size = New System.Drawing.Size(246, 19)
        Me.cboTipoSoporte.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "T. Soporte"
        '
        'cboMedio
        '
        Me.cboMedio.AutoSize = True
        Me.cboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedio.FlatMode = True
        Me.cboMedio.Location = New System.Drawing.Point(455, 18)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(208, 19)
        Me.cboMedio.TabIndex = 102
        '
        'TxtCodMedio
        '
        Me.TxtCodMedio.AcceptsReturn = True
        Me.TxtCodMedio.AcceptsTab = True
        Me.TxtCodMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodMedio.ConDecimal = False
        Me.TxtCodMedio.Location = New System.Drawing.Point(411, 18)
        Me.TxtCodMedio.Maximo = 0
        Me.TxtCodMedio.MaxLength = 5
        Me.TxtCodMedio.Name = "TxtCodMedio"
        Me.TxtCodMedio.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodMedio.SoloLetra = False
        Me.TxtCodMedio.SoloNumero = True
        Me.TxtCodMedio.TabIndex = 101
        '
        'lblDesCliente
        '
        Me.lblDesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesCliente.Image = CType(resources.GetObject("lblDesCliente.Image"), System.Drawing.Image)
        Me.lblDesCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesCliente.Location = New System.Drawing.Point(325, 19)
        Me.lblDesCliente.Name = "lblDesCliente"
        Me.lblDesCliente.Size = New System.Drawing.Size(21, 21)
        Me.lblDesCliente.TabIndex = 100
        Me.lblDesCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesSoporte
        '
        Me.lblDesSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesSoporte.Enabled = False
        Me.lblDesSoporte.Image = CType(resources.GetObject("lblDesSoporte.Image"), System.Drawing.Image)
        Me.lblDesSoporte.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesSoporte.Location = New System.Drawing.Point(982, 16)
        Me.lblDesSoporte.Name = "lblDesSoporte"
        Me.lblDesSoporte.Size = New System.Drawing.Size(21, 21)
        Me.lblDesSoporte.TabIndex = 104
        Me.lblDesSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Location = New System.Drawing.Point(768, 17)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.ReadOnly = True
        Me.TxtSoporte.Size = New System.Drawing.Size(208, 20)
        Me.TxtSoporte.SoloLetra = False
        Me.TxtSoporte.SoloNumero = False
        Me.TxtSoporte.TabIndex = 109
        Me.TxtSoporte.TabStop = False
        '
        'TxtCodSoporte
        '
        Me.TxtCodSoporte.AcceptsReturn = True
        Me.TxtCodSoporte.AcceptsTab = True
        Me.TxtCodSoporte.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtCodSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodSoporte.ConDecimal = False
        Me.TxtCodSoporte.Location = New System.Drawing.Point(723, 17)
        Me.TxtCodSoporte.Maximo = 0
        Me.TxtCodSoporte.MaxLength = 5
        Me.TxtCodSoporte.Name = "TxtCodSoporte"
        Me.TxtCodSoporte.ReadOnly = True
        Me.TxtCodSoporte.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodSoporte.SoloLetra = False
        Me.TxtCodSoporte.SoloNumero = True
        Me.TxtCodSoporte.TabIndex = 103
        '
        'lblSoporte
        '
        Me.lblSoporte.AutoSize = True
        Me.lblSoporte.Location = New System.Drawing.Point(674, 22)
        Me.lblSoporte.Name = "lblSoporte"
        Me.lblSoporte.Size = New System.Drawing.Size(44, 13)
        Me.lblSoporte.TabIndex = 108
        Me.lblSoporte.Text = "Soporte"
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(354, 22)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(36, 13)
        Me.lblMedio.TabIndex = 107
        Me.lblMedio.Text = "Medio"
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(113, 19)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtCliente.SoloLetra = False
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 106
        Me.txtCliente.TabStop = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.AcceptsReturn = True
        Me.txtCodCliente.AcceptsTab = True
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.ConDecimal = False
        Me.txtCodCliente.Location = New System.Drawing.Point(69, 19)
        Me.txtCodCliente.Maximo = 0
        Me.txtCodCliente.MaxLength = 5
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtCodCliente.SoloLetra = False
        Me.txtCodCliente.SoloNumero = True
        Me.txtCodCliente.TabIndex = 99
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(12, 24)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 105
        Me.lblCliente.Text = "Cliente"
        '
        'cmdExportar
        '
        Me.cmdExportar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExportar.Location = New System.Drawing.Point(912, 701)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(118, 23)
        Me.cmdExportar.TabIndex = 8
        Me.cmdExportar.Text = "Exportar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Location = New System.Drawing.Point(1042, 701)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(118, 23)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "Salir"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Location = New System.Drawing.Point(1035, 17)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(126, 23)
        Me.cmdBuscar.TabIndex = 10
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLimpiar.Location = New System.Drawing.Point(1035, 49)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(126, 23)
        Me.cmdLimpiar.TabIndex = 11
        Me.cmdLimpiar.Text = "Limpiar"
        '
        'uigExportar
        '
        Me.uigExportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uigExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance11.BackColor = System.Drawing.Color.White
        Me.uigExportar.DisplayLayout.Appearance = Appearance11
        Me.uigExportar.DisplayLayout.MaxColScrollRegions = 1
        Me.uigExportar.DisplayLayout.MaxRowScrollRegions = 1
        Me.uigExportar.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.uigExportar.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.uigExportar.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.uigExportar.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.uigExportar.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.uigExportar.DisplayLayout.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        Me.uigExportar.DisplayLayout.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        Me.uigExportar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.uigExportar.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.uigExportar.DisplayLayout.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.uigExportar.DisplayLayout.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        Me.uigExportar.DisplayLayout.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.uigExportar.DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.uigExportar.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.uigExportar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.uigExportar.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Me.uigExportar.DisplayLayout.Override.CellPadding = 3
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigExportar.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.uigExportar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance14.BorderColor = System.Drawing.Color.LightGray
        Appearance14.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigExportar.DisplayLayout.Override.RowAppearance = Appearance14
        Me.uigExportar.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.Color.PowderBlue
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.uigExportar.DisplayLayout.Override.SelectedRowAppearance = Appearance15
        Me.uigExportar.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigExportar.FlatMode = True
        Me.uigExportar.Location = New System.Drawing.Point(184, 274)
        Me.uigExportar.Name = "uigExportar"
        Me.uigExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uigExportar.Size = New System.Drawing.Size(282, 70)
        Me.uigExportar.TabIndex = 42
        '
        'uigGrillaConvenios
        '
        Me.uigGrillaConvenios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uigGrillaConvenios.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance16.BackColor = System.Drawing.Color.White
        Me.uigGrillaConvenios.DisplayLayout.Appearance = Appearance16
        Me.uigGrillaConvenios.DisplayLayout.MaxColScrollRegions = 1
        Me.uigGrillaConvenios.DisplayLayout.MaxRowScrollRegions = 1
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.uigGrillaConvenios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.uigGrillaConvenios.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Me.uigGrillaConvenios.DisplayLayout.Override.CellPadding = 3
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigGrillaConvenios.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.uigGrillaConvenios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance19.BorderColor = System.Drawing.Color.LightGray
        Appearance19.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigGrillaConvenios.DisplayLayout.Override.RowAppearance = Appearance19
        Me.uigGrillaConvenios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.Color.PowderBlue
        Appearance20.BorderColor = System.Drawing.Color.Black
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.uigGrillaConvenios.DisplayLayout.Override.SelectedRowAppearance = Appearance20
        Me.uigGrillaConvenios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigGrillaConvenios.FlatMode = True
        Me.uigGrillaConvenios.Location = New System.Drawing.Point(8, 96)
        Me.uigGrillaConvenios.Name = "uigGrillaConvenios"
        Me.uigGrillaConvenios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uigGrillaConvenios.Size = New System.Drawing.Size(1152, 591)
        Me.uigGrillaConvenios.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 704)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Cantidad Registros Encontrados :"
        '
        'txtregistrosCantidad
        '
        Me.txtregistrosCantidad.AcceptsReturn = True
        Me.txtregistrosCantidad.AcceptsTab = True
        Me.txtregistrosCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtregistrosCantidad.ConDecimal = False
        Me.txtregistrosCantidad.Location = New System.Drawing.Point(179, 697)
        Me.txtregistrosCantidad.Maximo = 0
        Me.txtregistrosCantidad.MaxLength = 5
        Me.txtregistrosCantidad.Name = "txtregistrosCantidad"
        Me.txtregistrosCantidad.ReadOnly = True
        Me.txtregistrosCantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtregistrosCantidad.SoloLetra = False
        Me.txtregistrosCantidad.SoloNumero = True
        Me.txtregistrosCantidad.TabIndex = 113
        Me.txtregistrosCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdVerAnexos
        '
        Me.cmdVerAnexos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdVerAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdVerAnexos.Location = New System.Drawing.Point(776, 701)
        Me.cmdVerAnexos.Name = "cmdVerAnexos"
        Me.cmdVerAnexos.Size = New System.Drawing.Size(118, 23)
        Me.cmdVerAnexos.TabIndex = 114
        Me.cmdVerAnexos.Text = "Ver Anexos"
        '
        'FrmConveniosReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 734)
        Me.Controls.Add(Me.cmdVerAnexos)
        Me.Controls.Add(Me.txtregistrosCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uigGrillaConvenios)
        Me.Controls.Add(Me.uigExportar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConveniosReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenios Reporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uigExportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents uigExportar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uigGrillaConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboMedio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TxtCodMedio As QUETOOL.txtTexto
    Friend WithEvents lblDesCliente As System.Windows.Forms.Label
    Friend WithEvents lblDesSoporte As System.Windows.Forms.Label
    Friend WithEvents TxtSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtCodSoporte As QUETOOL.txtTexto
    Friend WithEvents lblSoporte As System.Windows.Forms.Label
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents txtCodCliente As QUETOOL.txtTexto
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents cboTipoSoporte As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cboVigente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtregistrosCantidad As QUETOOL.txtTexto
    Friend WithEvents cmdVerAnexos As System.Windows.Forms.Button
End Class

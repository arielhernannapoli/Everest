<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvenioEspecial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvenioEspecial))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.cboVigente = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboTipoSoporte = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdLimpiar = New System.Windows.Forms.Button
        Me.txtregistrosCantidad = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.uigGrillaConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdguardar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1013, 85)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de Busqueda :"
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
        'cmdBuscar
        '
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Location = New System.Drawing.Point(1034, 21)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(126, 23)
        Me.cmdBuscar.TabIndex = 13
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLimpiar.Location = New System.Drawing.Point(1034, 53)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(126, 23)
        Me.cmdLimpiar.TabIndex = 14
        Me.cmdLimpiar.Text = "Limpiar"
        '
        'txtregistrosCantidad
        '
        Me.txtregistrosCantidad.AcceptsReturn = True
        Me.txtregistrosCantidad.AcceptsTab = True
        Me.txtregistrosCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtregistrosCantidad.ConDecimal = False
        Me.txtregistrosCantidad.Location = New System.Drawing.Point(179, 608)
        Me.txtregistrosCantidad.Maximo = 0
        Me.txtregistrosCantidad.MaxLength = 5
        Me.txtregistrosCantidad.Name = "txtregistrosCantidad"
        Me.txtregistrosCantidad.ReadOnly = True
        Me.txtregistrosCantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtregistrosCantidad.SoloLetra = False
        Me.txtregistrosCantidad.SoloNumero = True
        Me.txtregistrosCantidad.TabIndex = 118
        Me.txtregistrosCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 615)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Cantidad Registros Encontrados :"
        '
        'uigGrillaConvenios
        '
        Me.uigGrillaConvenios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uigGrillaConvenios.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Me.uigGrillaConvenios.DisplayLayout.Appearance = Appearance1
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
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.uigGrillaConvenios.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.uigGrillaConvenios.DisplayLayout.Override.CellPadding = 3
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigGrillaConvenios.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.uigGrillaConvenios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.LightGray
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigGrillaConvenios.DisplayLayout.Override.RowAppearance = Appearance4
        Me.uigGrillaConvenios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.Color.PowderBlue
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.uigGrillaConvenios.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.uigGrillaConvenios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigGrillaConvenios.FlatMode = True
        Me.uigGrillaConvenios.Location = New System.Drawing.Point(8, 100)
        Me.uigGrillaConvenios.Name = "uigGrillaConvenios"
        Me.uigGrillaConvenios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uigGrillaConvenios.Size = New System.Drawing.Size(1152, 498)
        Me.uigGrillaConvenios.TabIndex = 116
        '
        'cmdguardar
        '
        Me.cmdguardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdguardar.Location = New System.Drawing.Point(913, 604)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(118, 23)
        Me.cmdguardar.TabIndex = 114
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Location = New System.Drawing.Point(1043, 604)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(118, 23)
        Me.cmdSalir.TabIndex = 115
        Me.cmdSalir.Text = "Salir"
        '
        'frmConvenioEspecial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 636)
        Me.Controls.Add(Me.txtregistrosCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uigGrillaConvenios)
        Me.Controls.Add(Me.cmdguardar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConvenioEspecial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenios Especiales "
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboVigente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoSoporte As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents txtregistrosCantidad As QUETOOL.txtTexto
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uigGrillaConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdguardar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class

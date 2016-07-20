<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDuplicarConveniosMasivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDuplicarConveniosMasivo))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtFFin = New QUETOOL.dtpFecha
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpFInicio = New QUETOOL.dtpFecha
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFVigencia = New QUETOOL.dtpFecha
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
        Me.cmdLimpiar = New System.Windows.Forms.Button
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.txtregistrosCantidad = New QUETOOL.txtTexto
        Me.Label2 = New System.Windows.Forms.Label
        Me.uigGrillaConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdDuplicar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtFFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFVigencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtFFin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DtpFInicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFVigencia)
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1100, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de Busqueda :"
        '
        'DtFFin
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.DtFFin.Appearance = Appearance1
        Me.DtFFin.FlatMode = True
        Me.DtFFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFFin.Location = New System.Drawing.Point(988, 47)
        Me.DtFFin.Name = "DtFFin"
        Me.DtFFin.Size = New System.Drawing.Size(107, 21)
        Me.DtFFin.TabIndex = 118
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(913, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "F.Fin Nueva"
        '
        'DtpFInicio
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.DtpFInicio.Appearance = Appearance2
        Me.DtpFInicio.FlatMode = True
        Me.DtpFInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFInicio.Location = New System.Drawing.Point(801, 47)
        Me.DtpFInicio.Name = "DtpFInicio"
        Me.DtpFInicio.Size = New System.Drawing.Size(107, 21)
        Me.DtpFInicio.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(719, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "F.Inicio Nueva"
        '
        'dtpFVigencia
        '
        Appearance3.FontData.SizeInPoints = 9.0!
        Me.dtpFVigencia.Appearance = Appearance3
        Me.dtpFVigencia.FlatMode = True
        Me.dtpFVigencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFVigencia.Location = New System.Drawing.Point(74, 49)
        Me.dtpFVigencia.Name = "dtpFVigencia"
        Me.dtpFVigencia.Size = New System.Drawing.Size(107, 21)
        Me.dtpFVigencia.TabIndex = 114
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "F.Vigencia"
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.AutoSize = True
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Location = New System.Drawing.Point(462, 47)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.ReadOnly = True
        Me.cboTipoSoporte.Size = New System.Drawing.Size(248, 19)
        Me.cboTipoSoporte.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 53)
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
        Me.cboMedio.Location = New System.Drawing.Point(502, 18)
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
        Me.TxtCodMedio.Location = New System.Drawing.Point(456, 18)
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
        Me.lblDesCliente.Location = New System.Drawing.Point(371, 19)
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
        Me.lblDesSoporte.Location = New System.Drawing.Point(1042, 17)
        Me.lblDesSoporte.Name = "lblDesSoporte"
        Me.lblDesSoporte.Size = New System.Drawing.Size(21, 21)
        Me.lblDesSoporte.TabIndex = 104
        Me.lblDesSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Location = New System.Drawing.Point(811, 18)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.ReadOnly = True
        Me.TxtSoporte.Size = New System.Drawing.Size(225, 20)
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
        Me.TxtCodSoporte.Location = New System.Drawing.Point(765, 18)
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
        Me.lblSoporte.Location = New System.Drawing.Point(718, 23)
        Me.lblSoporte.Name = "lblSoporte"
        Me.lblSoporte.Size = New System.Drawing.Size(44, 13)
        Me.lblSoporte.TabIndex = 108
        Me.lblSoporte.Text = "Soporte"
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(399, 22)
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
        Me.txtCliente.Size = New System.Drawing.Size(252, 20)
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
        'cmdLimpiar
        '
        Me.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLimpiar.Location = New System.Drawing.Point(1116, 44)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(106, 23)
        Me.cmdLimpiar.TabIndex = 13
        Me.cmdLimpiar.Text = "Limpiar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Location = New System.Drawing.Point(1116, 12)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(106, 23)
        Me.cmdBuscar.TabIndex = 12
        Me.cmdBuscar.Text = "Buscar"
        '
        'txtregistrosCantidad
        '
        Me.txtregistrosCantidad.AcceptsReturn = True
        Me.txtregistrosCantidad.AcceptsTab = True
        Me.txtregistrosCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtregistrosCantidad.ConDecimal = False
        Me.txtregistrosCantidad.Location = New System.Drawing.Point(186, 704)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 711)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Cantidad Registros Encontrados :"
        '
        'uigGrillaConvenios
        '
        Me.uigGrillaConvenios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uigGrillaConvenios.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance4.BackColor = System.Drawing.Color.White
        Me.uigGrillaConvenios.DisplayLayout.Appearance = Appearance4
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
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.uigGrillaConvenios.DisplayLayout.Override.CardAreaAppearance = Appearance5
        Me.uigGrillaConvenios.DisplayLayout.Override.CellPadding = 3
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Left
        Me.uigGrillaConvenios.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.uigGrillaConvenios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance7.BorderColor = System.Drawing.Color.LightGray
        Appearance7.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.uigGrillaConvenios.DisplayLayout.Override.RowAppearance = Appearance7
        Me.uigGrillaConvenios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.Color.PowderBlue
        Appearance8.BorderColor = System.Drawing.Color.Black
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.uigGrillaConvenios.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.uigGrillaConvenios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.uigGrillaConvenios.FlatMode = True
        Me.uigGrillaConvenios.Location = New System.Drawing.Point(15, 103)
        Me.uigGrillaConvenios.Name = "uigGrillaConvenios"
        Me.uigGrillaConvenios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uigGrillaConvenios.Size = New System.Drawing.Size(1207, 591)
        Me.uigGrillaConvenios.TabIndex = 116
        '
        'cmdDuplicar
        '
        Me.cmdDuplicar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdDuplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDuplicar.Location = New System.Drawing.Point(972, 708)
        Me.cmdDuplicar.Name = "cmdDuplicar"
        Me.cmdDuplicar.Size = New System.Drawing.Size(118, 23)
        Me.cmdDuplicar.TabIndex = 114
        Me.cmdDuplicar.Text = "Duplicar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Location = New System.Drawing.Point(1102, 708)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(118, 23)
        Me.cmdSalir.TabIndex = 115
        Me.cmdSalir.Text = "Salir"
        '
        'frmDuplicarConveniosMasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 743)
        Me.Controls.Add(Me.txtregistrosCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.uigGrillaConvenios)
        Me.Controls.Add(Me.cmdDuplicar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDuplicarConveniosMasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicar Convenios Masivo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtFFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFVigencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoSoporte As Infragistics.Win.UltraWinEditors.UltraComboEditor
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
    Friend WithEvents DtpFInicio As QUETOOL.dtpFecha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFVigencia As QUETOOL.dtpFecha
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtregistrosCantidad As QUETOOL.txtTexto
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents uigGrillaConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdDuplicar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents DtFFin As QUETOOL.dtpFecha
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

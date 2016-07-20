<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteConvenioLog
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
        Me.uigGrillaConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdExportar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.txtregistrosCantidad = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnroconvenio = New QUETOOL.txtTexto
        Me.Label2 = New System.Windows.Forms.Label
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.uigGrillaConvenios.Location = New System.Drawing.Point(9, 5)
        Me.uigGrillaConvenios.Name = "uigGrillaConvenios"
        Me.uigGrillaConvenios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uigGrillaConvenios.Size = New System.Drawing.Size(1288, 591)
        Me.uigGrillaConvenios.TabIndex = 46
        '
        'cmdExportar
        '
        Me.cmdExportar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExportar.Location = New System.Drawing.Point(1049, 608)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(118, 23)
        Me.cmdExportar.TabIndex = 44
        Me.cmdExportar.Text = "Exportar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Location = New System.Drawing.Point(1179, 608)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(118, 23)
        Me.cmdSalir.TabIndex = 45
        Me.cmdSalir.Text = "Salir"
        '
        'txtregistrosCantidad
        '
        Me.txtregistrosCantidad.AcceptsReturn = True
        Me.txtregistrosCantidad.AcceptsTab = True
        Me.txtregistrosCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtregistrosCantidad.ConDecimal = False
        Me.txtregistrosCantidad.Location = New System.Drawing.Point(107, 609)
        Me.txtregistrosCantidad.Maximo = 0
        Me.txtregistrosCantidad.MaxLength = 5
        Me.txtregistrosCantidad.Name = "txtregistrosCantidad"
        Me.txtregistrosCantidad.ReadOnly = True
        Me.txtregistrosCantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtregistrosCantidad.SoloLetra = False
        Me.txtregistrosCantidad.SoloNumero = True
        Me.txtregistrosCantidad.TabIndex = 115
        Me.txtregistrosCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 615)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Cant. Registros :"
        '
        'txtnroconvenio
        '
        Me.txtnroconvenio.AcceptsReturn = True
        Me.txtnroconvenio.AcceptsTab = True
        Me.txtnroconvenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnroconvenio.ConDecimal = False
        Me.txtnroconvenio.Location = New System.Drawing.Point(283, 610)
        Me.txtnroconvenio.Maximo = 0
        Me.txtnroconvenio.MaxLength = 5
        Me.txtnroconvenio.Name = "txtnroconvenio"
        Me.txtnroconvenio.ReadOnly = True
        Me.txtnroconvenio.Size = New System.Drawing.Size(61, 20)
        Me.txtnroconvenio.SoloLetra = False
        Me.txtnroconvenio.SoloNumero = True
        Me.txtnroconvenio.TabIndex = 117
        Me.txtnroconvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 615)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Nro Convenio :"
        '
        'ReporteConvenioLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 651)
        Me.Controls.Add(Me.txtnroconvenio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtregistrosCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uigGrillaConvenios)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.cmdSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ReporteConvenioLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log de Convenios"
        CType(Me.uigGrillaConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uigGrillaConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents txtregistrosCantidad As QUETOOL.txtTexto
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnroconvenio As QUETOOL.txtTexto
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class

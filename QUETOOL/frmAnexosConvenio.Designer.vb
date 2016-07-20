<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnexosConvenio
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.lnkAnexarArchivo = New System.Windows.Forms.LinkLabel
        Me.ugAnexos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.gpAnexos = New System.Windows.Forms.GroupBox
        Me.pnlImage = New System.Windows.Forms.Panel
        Me.pctImagen = New System.Windows.Forms.PictureBox
        Me.optAnexarArchivos = New System.Windows.Forms.RadioButton
        Me.optVerImagen = New System.Windows.Forms.RadioButton
        Me.lnkAnexarDelPortapapeles = New System.Windows.Forms.LinkLabel
        CType(Me.ugAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpAnexos.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkAnexarArchivo
        '
        Me.lnkAnexarArchivo.AutoSize = True
        Me.lnkAnexarArchivo.Location = New System.Drawing.Point(12, 374)
        Me.lnkAnexarArchivo.Name = "lnkAnexarArchivo"
        Me.lnkAnexarArchivo.Size = New System.Drawing.Size(111, 13)
        Me.lnkAnexarArchivo.TabIndex = 0
        Me.lnkAnexarArchivo.TabStop = True
        Me.lnkAnexarArchivo.Text = "Anexar nuevo archivo"
        '
        'ugAnexos
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugAnexos.DisplayLayout.Appearance = Appearance1
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand1.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        UltraGridBand1.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand1.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand1.Override.HeaderAppearance = Appearance2
        Me.ugAnexos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugAnexos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugAnexos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.ugAnexos.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugAnexos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.ugAnexos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugAnexos.DisplayLayout.GroupByBox.Hidden = True
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugAnexos.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.ugAnexos.DisplayLayout.MaxColScrollRegions = 1
        Me.ugAnexos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugAnexos.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugAnexos.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.ugAnexos.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugAnexos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ugAnexos.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugAnexos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugAnexos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugAnexos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.ugAnexos.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugAnexos.DisplayLayout.Override.CellAppearance = Appearance9
        Me.ugAnexos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugAnexos.DisplayLayout.Override.CellPadding = 0
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.ugAnexos.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugAnexos.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.ugAnexos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.ugAnexos.DisplayLayout.Override.RowAppearance = Appearance12
        Me.ugAnexos.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.HideFilteredOutRows
        Me.ugAnexos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugAnexos.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugAnexos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugAnexos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.ugAnexos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugAnexos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugAnexos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugAnexos.FlatMode = True
        Me.ugAnexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugAnexos.Location = New System.Drawing.Point(3, 16)
        Me.ugAnexos.Name = "ugAnexos"
        Me.ugAnexos.Size = New System.Drawing.Size(626, 330)
        Me.ugAnexos.TabIndex = 50
        Me.ugAnexos.TabStop = False
        '
        'gpAnexos
        '
        Me.gpAnexos.Controls.Add(Me.pnlImage)
        Me.gpAnexos.Controls.Add(Me.ugAnexos)
        Me.gpAnexos.Location = New System.Drawing.Point(12, 12)
        Me.gpAnexos.Name = "gpAnexos"
        Me.gpAnexos.Size = New System.Drawing.Size(632, 349)
        Me.gpAnexos.TabIndex = 51
        Me.gpAnexos.TabStop = False
        Me.gpAnexos.Text = "Anexos"
        '
        'pnlImage
        '
        Me.pnlImage.Controls.Add(Me.pctImagen)
        Me.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlImage.Location = New System.Drawing.Point(3, 16)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(626, 330)
        Me.pnlImage.TabIndex = 52
        '
        'pctImagen
        '
        Me.pctImagen.Location = New System.Drawing.Point(61, 34)
        Me.pctImagen.Name = "pctImagen"
        Me.pctImagen.Size = New System.Drawing.Size(0, 0)
        Me.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctImagen.TabIndex = 51
        Me.pctImagen.TabStop = False
        '
        'optAnexarArchivos
        '
        Me.optAnexarArchivos.AutoSize = True
        Me.optAnexarArchivos.Checked = True
        Me.optAnexarArchivos.Location = New System.Drawing.Point(446, 374)
        Me.optAnexarArchivos.Name = "optAnexarArchivos"
        Me.optAnexarArchivos.Size = New System.Drawing.Size(101, 17)
        Me.optAnexarArchivos.TabIndex = 52
        Me.optAnexarArchivos.TabStop = True
        Me.optAnexarArchivos.Text = "Anexar archivos"
        Me.optAnexarArchivos.UseVisualStyleBackColor = True
        '
        'optVerImagen
        '
        Me.optVerImagen.AutoSize = True
        Me.optVerImagen.Location = New System.Drawing.Point(551, 374)
        Me.optVerImagen.Name = "optVerImagen"
        Me.optVerImagen.Size = New System.Drawing.Size(74, 17)
        Me.optVerImagen.TabIndex = 53
        Me.optVerImagen.Text = "Ver Anexo"
        Me.optVerImagen.UseVisualStyleBackColor = True
        '
        'lnkAnexarDelPortapapeles
        '
        Me.lnkAnexarDelPortapapeles.AutoSize = True
        Me.lnkAnexarDelPortapapeles.Location = New System.Drawing.Point(152, 373)
        Me.lnkAnexarDelPortapapeles.Name = "lnkAnexarDelPortapapeles"
        Me.lnkAnexarDelPortapapeles.Size = New System.Drawing.Size(119, 13)
        Me.lnkAnexarDelPortapapeles.TabIndex = 54
        Me.lnkAnexarDelPortapapeles.TabStop = True
        Me.lnkAnexarDelPortapapeles.Text = "Pegar Del Portapapeles"
        '
        'frmAnexosConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 417)
        Me.Controls.Add(Me.lnkAnexarDelPortapapeles)
        Me.Controls.Add(Me.optVerImagen)
        Me.Controls.Add(Me.optAnexarArchivos)
        Me.Controls.Add(Me.gpAnexos)
        Me.Controls.Add(Me.lnkAnexarArchivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnexosConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Convenios (Anexos)"
        CType(Me.ugAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpAnexos.ResumeLayout(False)
        Me.pnlImage.ResumeLayout(False)
        Me.pnlImage.PerformLayout()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkAnexarArchivo As System.Windows.Forms.LinkLabel
    Friend WithEvents ugAnexos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gpAnexos As System.Windows.Forms.GroupBox
    Friend WithEvents optAnexarArchivos As System.Windows.Forms.RadioButton
    Friend WithEvents optVerImagen As System.Windows.Forms.RadioButton
    Friend WithEvents pctImagen As System.Windows.Forms.PictureBox
    Friend WithEvents lnkAnexarDelPortapapeles As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlImage As System.Windows.Forms.Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuboFlex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuboFlex))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton
        Me.btnColapsar = New System.Windows.Forms.ToolStripButton
        Me.btnOcultarTotales = New System.Windows.Forms.ToolStripButton
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.btnExportarHtml = New System.Windows.Forms.ToolStripButton
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.pivotFlex = New QUETOOL.CuboEjercicios
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pivotFlex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimir, Me.btnColapsar, Me.btnOcultarTotales, Me.btnExportarExcel, Me.btnExportarHtml, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1314, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(57, 22)
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnColapsar
        '
        Me.btnColapsar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnColapsar.Image = CType(resources.GetObject("btnColapsar.Image"), System.Drawing.Image)
        Me.btnColapsar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnColapsar.Name = "btnColapsar"
        Me.btnColapsar.Size = New System.Drawing.Size(57, 22)
        Me.btnColapsar.Text = "Colapsar"
        '
        'btnOcultarTotales
        '
        Me.btnOcultarTotales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnOcultarTotales.Image = CType(resources.GetObject("btnOcultarTotales.Image"), System.Drawing.Image)
        Me.btnOcultarTotales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOcultarTotales.Name = "btnOcultarTotales"
        Me.btnOcultarTotales.Size = New System.Drawing.Size(91, 22)
        Me.btnOcultarTotales.Text = "Ocultar Totales"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(92, 22)
        Me.btnExportarExcel.Text = "Exportar a Excel"
        '
        'btnExportarHtml
        '
        Me.btnExportarHtml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExportarHtml.Image = CType(resources.GetObject("btnExportarHtml.Image"), System.Drawing.Image)
        Me.btnExportarHtml.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarHtml.Name = "btnExportarHtml"
        Me.btnExportarHtml.Size = New System.Drawing.Size(93, 22)
        Me.btnExportarHtml.Text = "Exportar a Html"
        '
        'btnSalir
        '
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(33, 22)
        Me.btnSalir.Text = "Salir"
        '
        'pivotFlex
        '
        Me.pivotFlex.Cursor = System.Windows.Forms.Cursors.Default
        Me.pivotFlex.Location = New System.Drawing.Point(0, 28)
        Me.pivotFlex.LookAndFeel.SkinName = "iMaginary"
        Me.pivotFlex.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pivotFlex.Name = "pivotFlex"
        Me.pivotFlex.Size = New System.Drawing.Size(1314, 537)
        Me.pivotFlex.TabIndex = 0
        '
        'CuboFlex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 562)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pivotFlex)
        Me.Name = "CuboFlex"
        Me.Text = "CuboFlex"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pivotFlex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pivotFlex As CuboEjercicios
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnColapsar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOcultarTotales As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportarHtml As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguimientoCPRxFranjaHoraria
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.lblFechaHasta = New System.Windows.Forms.Label
        Me.lblFechaDesde = New System.Windows.Forms.Label
        Me.lblCanal13 = New System.Windows.Forms.Label
        Me.lblAmerica = New System.Windows.Forms.Label
        Me.lblTelefe = New System.Windows.Forms.Label
        Me.lblCanal9 = New System.Windows.Forms.Label
        Me.txtCPRTelefe = New System.Windows.Forms.TextBox
        Me.txtCPRAmerica = New System.Windows.Forms.TextBox
        Me.txtCPRC9 = New System.Windows.Forms.TextBox
        Me.txtCPRC13 = New System.Windows.Forms.TextBox
        Me.lblTarget1 = New System.Windows.Forms.Label
        Me.lblTarget2 = New System.Windows.Forms.Label
        Me.txtTarget1 = New System.Windows.Forms.TextBox
        Me.txtTarget2 = New System.Windows.Forms.TextBox
        Me.lblImporteTV = New System.Windows.Forms.Label
        Me.txtImporteTV = New System.Windows.Forms.TextBox
        Me.iugConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dtpFechaHasta = New QUETOOL.dtpFecha
        Me.dtpFechaDesde = New QUETOOL.dtpFecha
        Me.tblContenedor = New System.Windows.Forms.TableLayoutPanel
        Me.tblBotonesAccion = New System.Windows.Forms.TableLayoutPanel
        Me.tblFiltrosFecha = New System.Windows.Forms.TableLayoutPanel
        Me.tblDatosSolicitadosContenedor = New System.Windows.Forms.TableLayoutPanel
        Me.tblDatosSolicitadosSoportes = New System.Windows.Forms.TableLayoutPanel
        Me.tblDatosSolicitadosTargets = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        CType(Me.iugConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblContenedor.SuspendLayout()
        Me.tblBotonesAccion.SuspendLayout()
        Me.tblFiltrosFecha.SuspendLayout()
        Me.tblDatosSolicitadosContenedor.SuspendLayout()
        Me.tblDatosSolicitadosSoportes.SuspendLayout()
        Me.tblDatosSolicitadosTargets.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Location = New System.Drawing.Point(594, 3)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(681, 3)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(84, 23)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(378, 8)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaHasta.TabIndex = 7
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(41, 8)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(71, 13)
        Me.lblFechaDesde.TabIndex = 6
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'lblCanal13
        '
        Me.lblCanal13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCanal13.AutoSize = True
        Me.lblCanal13.Location = New System.Drawing.Point(50, 6)
        Me.lblCanal13.Name = "lblCanal13"
        Me.lblCanal13.Size = New System.Drawing.Size(49, 13)
        Me.lblCanal13.TabIndex = 7
        Me.lblCanal13.Text = "Canal 13"
        '
        'lblAmerica
        '
        Me.lblAmerica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAmerica.AutoSize = True
        Me.lblAmerica.Location = New System.Drawing.Point(386, 6)
        Me.lblAmerica.Name = "lblAmerica"
        Me.lblAmerica.Size = New System.Drawing.Size(45, 13)
        Me.lblAmerica.TabIndex = 7
        Me.lblAmerica.Text = "America"
        '
        'lblTelefe
        '
        Me.lblTelefe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefe.AutoSize = True
        Me.lblTelefe.Location = New System.Drawing.Point(56, 33)
        Me.lblTelefe.Name = "lblTelefe"
        Me.lblTelefe.Size = New System.Drawing.Size(37, 13)
        Me.lblTelefe.TabIndex = 7
        Me.lblTelefe.Text = "Telefe"
        '
        'lblCanal9
        '
        Me.lblCanal9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCanal9.AutoSize = True
        Me.lblCanal9.Location = New System.Drawing.Point(387, 33)
        Me.lblCanal9.Name = "lblCanal9"
        Me.lblCanal9.Size = New System.Drawing.Size(43, 13)
        Me.lblCanal9.TabIndex = 7
        Me.lblCanal9.Text = "Canal 9"
        '
        'txtCPRTelefe
        '
        Me.txtCPRTelefe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCPRTelefe.Location = New System.Drawing.Point(153, 29)
        Me.txtCPRTelefe.Name = "txtCPRTelefe"
        Me.txtCPRTelefe.Size = New System.Drawing.Size(170, 20)
        Me.txtCPRTelefe.TabIndex = 2
        '
        'txtCPRAmerica
        '
        Me.txtCPRAmerica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCPRAmerica.Location = New System.Drawing.Point(494, 3)
        Me.txtCPRAmerica.Name = "txtCPRAmerica"
        Me.txtCPRAmerica.Size = New System.Drawing.Size(206, 20)
        Me.txtCPRAmerica.TabIndex = 3
        '
        'txtCPRC9
        '
        Me.txtCPRC9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCPRC9.Location = New System.Drawing.Point(494, 29)
        Me.txtCPRC9.Name = "txtCPRC9"
        Me.txtCPRC9.Size = New System.Drawing.Size(206, 20)
        Me.txtCPRC9.TabIndex = 4
        '
        'txtCPRC13
        '
        Me.txtCPRC13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCPRC13.Location = New System.Drawing.Point(153, 3)
        Me.txtCPRC13.Name = "txtCPRC13"
        Me.txtCPRC13.Size = New System.Drawing.Size(170, 20)
        Me.txtCPRC13.TabIndex = 1
        '
        'lblTarget1
        '
        Me.lblTarget1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTarget1.AutoSize = True
        Me.lblTarget1.Location = New System.Drawing.Point(47, 7)
        Me.lblTarget1.Name = "lblTarget1"
        Me.lblTarget1.Size = New System.Drawing.Size(47, 13)
        Me.lblTarget1.TabIndex = 7
        Me.lblTarget1.Text = "Target 1"
        '
        'lblTarget2
        '
        Me.lblTarget2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTarget2.AutoSize = True
        Me.lblTarget2.Location = New System.Drawing.Point(378, 7)
        Me.lblTarget2.Name = "lblTarget2"
        Me.lblTarget2.Size = New System.Drawing.Size(47, 13)
        Me.lblTarget2.TabIndex = 7
        Me.lblTarget2.Text = "Target 2"
        '
        'txtTarget1
        '
        Me.txtTarget1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTarget1.Location = New System.Drawing.Point(145, 3)
        Me.txtTarget1.Name = "txtTarget1"
        Me.txtTarget1.Size = New System.Drawing.Size(174, 20)
        Me.txtTarget1.TabIndex = 1
        '
        'txtTarget2
        '
        Me.txtTarget2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTarget2.Location = New System.Drawing.Point(485, 3)
        Me.txtTarget2.Name = "txtTarget2"
        Me.txtTarget2.Size = New System.Drawing.Size(205, 20)
        Me.txtTarget2.TabIndex = 2
        '
        'lblImporteTV
        '
        Me.lblImporteTV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblImporteTV.AutoSize = True
        Me.lblImporteTV.Location = New System.Drawing.Point(41, 34)
        Me.lblImporteTV.Name = "lblImporteTV"
        Me.lblImporteTV.Size = New System.Drawing.Size(59, 13)
        Me.lblImporteTV.TabIndex = 7
        Me.lblImporteTV.Text = "Importe TV"
        '
        'txtImporteTV
        '
        Me.txtImporteTV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtImporteTV.Location = New System.Drawing.Point(145, 30)
        Me.txtImporteTV.Name = "txtImporteTV"
        Me.txtImporteTV.Size = New System.Drawing.Size(174, 20)
        Me.txtImporteTV.TabIndex = 3
        '
        'iugConvenios
        '
        Me.iugConvenios.Cursor = System.Windows.Forms.Cursors.Hand
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugConvenios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.iugConvenios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugConvenios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugConvenios.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.iugConvenios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugConvenios.Enabled = False
        Me.iugConvenios.FlatMode = True
        Me.iugConvenios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugConvenios.Location = New System.Drawing.Point(3, 63)
        Me.iugConvenios.Name = "iugConvenios"
        Me.iugConvenios.Size = New System.Drawing.Size(762, 317)
        Me.iugConvenios.TabIndex = 2
        Me.iugConvenios.Text = "Convenios"
        '
        'dtpFechaHasta
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFechaHasta.Appearance = Appearance1
        Me.dtpFechaHasta.DateTime = New Date(2012, 5, 30, 0, 0, 0, 0)
        Me.dtpFechaHasta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpFechaHasta.FlatMode = True
        Me.dtpFechaHasta.Location = New System.Drawing.Point(497, 3)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(206, 21)
        Me.dtpFechaHasta.TabIndex = 2
        Me.dtpFechaHasta.Value = New Date(2012, 5, 30, 0, 0, 0, 0)
        '
        'dtpFechaDesde
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaDesde.Appearance = Appearance2
        Me.dtpFechaDesde.DateTime = New Date(2012, 5, 30, 0, 0, 0, 0)
        Me.dtpFechaDesde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpFechaDesde.FlatMode = True
        Me.dtpFechaDesde.Location = New System.Drawing.Point(157, 3)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(170, 21)
        Me.dtpFechaDesde.TabIndex = 1
        Me.dtpFechaDesde.Value = New Date(2012, 5, 30, 0, 0, 0, 0)
        '
        'tblContenedor
        '
        Me.tblContenedor.AutoSize = True
        Me.tblContenedor.ColumnCount = 1
        Me.tblContenedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblContenedor.Controls.Add(Me.tblBotonesAccion, 0, 2)
        Me.tblContenedor.Controls.Add(Me.tblFiltrosFecha, 0, 0)
        Me.tblContenedor.Controls.Add(Me.tblDatosSolicitadosContenedor, 0, 1)
        Me.tblContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblContenedor.Location = New System.Drawing.Point(3, 16)
        Me.tblContenedor.Name = "tblContenedor"
        Me.tblContenedor.RowCount = 3
        Me.tblContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tblContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.19608!))
        Me.tblContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922!))
        Me.tblContenedor.Size = New System.Drawing.Size(774, 534)
        Me.tblContenedor.TabIndex = 1
        '
        'tblBotonesAccion
        '
        Me.tblBotonesAccion.ColumnCount = 3
        Me.tblBotonesAccion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.96148!))
        Me.tblBotonesAccion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.03852!))
        Me.tblBotonesAccion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.tblBotonesAccion.Controls.Add(Me.cmdAceptar, 1, 0)
        Me.tblBotonesAccion.Controls.Add(Me.cmdCancelar, 2, 0)
        Me.tblBotonesAccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBotonesAccion.Location = New System.Drawing.Point(3, 488)
        Me.tblBotonesAccion.Name = "tblBotonesAccion"
        Me.tblBotonesAccion.RowCount = 1
        Me.tblBotonesAccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBotonesAccion.Size = New System.Drawing.Size(768, 43)
        Me.tblBotonesAccion.TabIndex = 3
        '
        'tblFiltrosFecha
        '
        Me.tblFiltrosFecha.ColumnCount = 5
        Me.tblFiltrosFecha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.tblFiltrosFecha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.tblFiltrosFecha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.tblFiltrosFecha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.tblFiltrosFecha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263.0!))
        Me.tblFiltrosFecha.Controls.Add(Me.lblFechaDesde, 0, 0)
        Me.tblFiltrosFecha.Controls.Add(Me.dtpFechaDesde, 1, 0)
        Me.tblFiltrosFecha.Controls.Add(Me.dtpFechaHasta, 3, 0)
        Me.tblFiltrosFecha.Controls.Add(Me.lblFechaHasta, 2, 0)
        Me.tblFiltrosFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblFiltrosFecha.Location = New System.Drawing.Point(3, 3)
        Me.tblFiltrosFecha.Name = "tblFiltrosFecha"
        Me.tblFiltrosFecha.RowCount = 1
        Me.tblFiltrosFecha.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblFiltrosFecha.Size = New System.Drawing.Size(768, 30)
        Me.tblFiltrosFecha.TabIndex = 1
        '
        'tblDatosSolicitadosContenedor
        '
        Me.tblDatosSolicitadosContenedor.ColumnCount = 1
        Me.tblDatosSolicitadosContenedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDatosSolicitadosContenedor.Controls.Add(Me.tblDatosSolicitadosSoportes, 0, 0)
        Me.tblDatosSolicitadosContenedor.Controls.Add(Me.iugConvenios, 1, 0)
        Me.tblDatosSolicitadosContenedor.Controls.Add(Me.tblDatosSolicitadosTargets, 0, 2)
        Me.tblDatosSolicitadosContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDatosSolicitadosContenedor.Location = New System.Drawing.Point(3, 39)
        Me.tblDatosSolicitadosContenedor.Name = "tblDatosSolicitadosContenedor"
        Me.tblDatosSolicitadosContenedor.RowCount = 3
        Me.tblDatosSolicitadosContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tblDatosSolicitadosContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDatosSolicitadosContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tblDatosSolicitadosContenedor.Size = New System.Drawing.Size(768, 443)
        Me.tblDatosSolicitadosContenedor.TabIndex = 2
        '
        'tblDatosSolicitadosSoportes
        '
        Me.tblDatosSolicitadosSoportes.ColumnCount = 5
        Me.tblDatosSolicitadosSoportes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tblDatosSolicitadosSoportes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.tblDatosSolicitadosSoportes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.tblDatosSolicitadosSoportes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.tblDatosSolicitadosSoportes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253.0!))
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.lblCanal13, 0, 0)
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.txtCPRC13, 1, 0)
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.lblAmerica, 2, 0)
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.txtCPRAmerica, 3, 0)
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.lblTelefe, 0, 1)
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.txtCPRTelefe, 1, 1)
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.lblCanal9, 2, 1)
        Me.tblDatosSolicitadosSoportes.Controls.Add(Me.txtCPRC9, 3, 1)
        Me.tblDatosSolicitadosSoportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDatosSolicitadosSoportes.Location = New System.Drawing.Point(3, 3)
        Me.tblDatosSolicitadosSoportes.Name = "tblDatosSolicitadosSoportes"
        Me.tblDatosSolicitadosSoportes.RowCount = 2
        Me.tblDatosSolicitadosSoportes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815!))
        Me.tblDatosSolicitadosSoportes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185!))
        Me.tblDatosSolicitadosSoportes.Size = New System.Drawing.Size(762, 54)
        Me.tblDatosSolicitadosSoportes.TabIndex = 1
        '
        'tblDatosSolicitadosTargets
        '
        Me.tblDatosSolicitadosTargets.ColumnCount = 5
        Me.tblDatosSolicitadosTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.tblDatosSolicitadosTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tblDatosSolicitadosTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tblDatosSolicitadosTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.tblDatosSolicitadosTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270.0!))
        Me.tblDatosSolicitadosTargets.Controls.Add(Me.lblTarget1, 0, 0)
        Me.tblDatosSolicitadosTargets.Controls.Add(Me.txtTarget1, 1, 0)
        Me.tblDatosSolicitadosTargets.Controls.Add(Me.lblTarget2, 2, 0)
        Me.tblDatosSolicitadosTargets.Controls.Add(Me.txtTarget2, 3, 0)
        Me.tblDatosSolicitadosTargets.Controls.Add(Me.lblImporteTV, 0, 1)
        Me.tblDatosSolicitadosTargets.Controls.Add(Me.txtImporteTV, 1, 1)
        Me.tblDatosSolicitadosTargets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDatosSolicitadosTargets.Location = New System.Drawing.Point(3, 386)
        Me.tblDatosSolicitadosTargets.Name = "tblDatosSolicitadosTargets"
        Me.tblDatosSolicitadosTargets.RowCount = 2
        Me.tblDatosSolicitadosTargets.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosSolicitadosTargets.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosSolicitadosTargets.Size = New System.Drawing.Size(762, 54)
        Me.tblDatosSolicitadosTargets.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tblContenedor)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 553)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de filtros"
        '
        'BackgroundWorker1
        '
        '
        'frmSeguimientoCPRxFranjaHoraria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 553)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeguimientoCPRxFranjaHoraria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CPR por Franja Horaria"
        CType(Me.iugConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblContenedor.ResumeLayout(False)
        Me.tblBotonesAccion.ResumeLayout(False)
        Me.tblFiltrosFecha.ResumeLayout(False)
        Me.tblFiltrosFecha.PerformLayout()
        Me.tblDatosSolicitadosContenedor.ResumeLayout(False)
        Me.tblDatosSolicitadosSoportes.ResumeLayout(False)
        Me.tblDatosSolicitadosSoportes.PerformLayout()
        Me.tblDatosSolicitadosTargets.ResumeLayout(False)
        Me.tblDatosSolicitadosTargets.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaDesde As QUETOOL.dtpFecha
    Friend WithEvents lblCanal13 As System.Windows.Forms.Label
    Friend WithEvents lblAmerica As System.Windows.Forms.Label
    Friend WithEvents lblTelefe As System.Windows.Forms.Label
    Friend WithEvents lblCanal9 As System.Windows.Forms.Label
    Friend WithEvents txtCPRTelefe As System.Windows.Forms.TextBox
    Friend WithEvents txtCPRAmerica As System.Windows.Forms.TextBox
    Friend WithEvents txtCPRC9 As System.Windows.Forms.TextBox
    Friend WithEvents txtCPRC13 As System.Windows.Forms.TextBox
    Friend WithEvents lblTarget1 As System.Windows.Forms.Label
    Friend WithEvents lblTarget2 As System.Windows.Forms.Label
    Friend WithEvents txtTarget1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTarget2 As System.Windows.Forms.TextBox
    Friend WithEvents lblImporteTV As System.Windows.Forms.Label
    Friend WithEvents txtImporteTV As System.Windows.Forms.TextBox
    Friend WithEvents iugConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tblContenedor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblBotonesAccion As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblFiltrosFecha As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblDatosSolicitadosContenedor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblDatosSolicitadosSoportes As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblDatosSolicitadosTargets As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox    

    Private Sub frmSeguimientoCPRxFranjaHoraria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class

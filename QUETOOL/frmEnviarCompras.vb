Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports System.Text
Imports Framework.Mensajes
Imports Framework
Imports MSL
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports System
Imports System.Linq
Imports MPG.DBL

Public Class frmEnviarCompras
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents cboTipoSoporte As QUETOOL.cboCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpF_Hasta As QUETOOL.dtpFecha
    Friend WithEvents dtpF_Desde As QUETOOL.dtpFecha
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents fraPresupuestos As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cboProducto As QUETOOL.cboCombo
    Friend WithEvents cboTarget As QUETOOL.cboCombo
    Friend WithEvents fraCompras As System.Windows.Forms.GroupBox
    Friend WithEvents iugCampanias As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents iugSubCampanias As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents iugPresupuestos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents fraEncab As System.Windows.Forms.GroupBox
    Friend WithEvents FraFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents iugEjercicios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents iugTemasxSop As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Ultra As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents CboMedio As QUETOOL.cboCombo
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents fraGrafica As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMateriales As QUETOOL.cboCombo
    Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents cboConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents lblMat As System.Windows.Forms.Label
    Friend WithEvents bgwEnvioCompras As System.ComponentModel.BackgroundWorker
    Friend WithEvents mpbEnvioCompras As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents pgbSpots As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbSoportes As System.Windows.Forms.ProgressBar
    Friend WithEvents chkSelAll As System.Windows.Forms.CheckBox
    Friend WithEvents lstSoportes As System.Windows.Forms.CheckedListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Me.fraEncab = New System.Windows.Forms.GroupBox
        Me.lblMat = New System.Windows.Forms.Label
        Me.cboMateriales = New QUETOOL.cboCombo
        Me.CboMedio = New QUETOOL.cboCombo
        Me.lblMedio = New System.Windows.Forms.Label
        Me.cboProducto = New QUETOOL.cboCombo
        Me.cboTarget = New QUETOOL.cboCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboTipoSoporte = New QUETOOL.cboCombo
        Me.Label21 = New System.Windows.Forms.Label
        Me.dtpF_Hasta = New QUETOOL.dtpFecha
        Me.dtpF_Desde = New QUETOOL.dtpFecha
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.cmdSiguiente = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdAnterior = New System.Windows.Forms.Button
        Me.fraCompras = New System.Windows.Forms.GroupBox
        Me.iugSubCampanias = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.iugCampanias = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.fraPresupuestos = New System.Windows.Forms.GroupBox
        Me.mpbEnvioCompras = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.pgbSpots = New System.Windows.Forms.ProgressBar
        Me.pgbSoportes = New System.Windows.Forms.ProgressBar
        Me.iugPresupuestos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.FraFiltros = New System.Windows.Forms.GroupBox
        Me.chkSelAll = New System.Windows.Forms.CheckBox
        Me.fraGrafica = New System.Windows.Forms.GroupBox
        Me.lstSoportes = New System.Windows.Forms.CheckedListBox
        Me.cboConcepto = New System.Windows.Forms.ComboBox
        Me.cboSeccion = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.iugTemasxSop = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.iugEjercicios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Ultra = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.bgwEnvioCompras = New System.ComponentModel.BackgroundWorker
        Me.fraEncab.SuspendLayout()
        CType(Me.cboMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpF_Hasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpF_Desde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraCompras.SuspendLayout()
        CType(Me.iugSubCampanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugCampanias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraPresupuestos.SuspendLayout()
        CType(Me.mpbEnvioCompras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFiltros.SuspendLayout()
        Me.fraGrafica.SuspendLayout()
        CType(Me.iugTemasxSop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugEjercicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ultra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ''
        ''fraEncab
        ''
        'Me.fraEncab.Controls.Add(Me.lblMat)
        'Me.fraEncab.Controls.Add(Me.cboMateriales)
        'Me.fraEncab.Controls.Add(Me.CboMedio)
        'Me.fraEncab.Controls.Add(Me.lblMedio)
        'Me.fraEncab.Controls.Add(Me.cboProducto)
        'Me.fraEncab.Controls.Add(Me.cboTarget)
        'Me.fraEncab.Controls.Add(Me.Label1)
        'Me.fraEncab.Controls.Add(Me.Label11)
        'Me.fraEncab.Controls.Add(Me.cboTipoSoporte)
        'Me.fraEncab.Controls.Add(Me.Label21)
        'Me.fraEncab.Controls.Add(Me.dtpF_Hasta)
        'Me.fraEncab.Controls.Add(Me.dtpF_Desde)
        'Me.fraEncab.Controls.Add(Me.Label6)
        'Me.fraEncab.Controls.Add(Me.Label5)
        'Me.fraEncab.Controls.Add(Me.Label4)
        'Me.fraEncab.Controls.Add(Me.txtDescripcion)
        'Me.fraEncab.Location = New System.Drawing.Point(16, 0)
        'Me.fraEncab.Name = "fraEncab"
        'Me.fraEncab.Size = New System.Drawing.Size(572, 129)
        'Me.fraEncab.TabIndex = 0
        'Me.fraEncab.TabStop = False
        'Me.fraEncab.Text = "Filtros"
        ''
        ''lblMat
        ''
        'Me.lblMat.AutoSize = True
        'Me.lblMat.Location = New System.Drawing.Point(268, 36)
        'Me.lblMat.Name = "lblMat"
        'Me.lblMat.Size = New System.Drawing.Size(44, 13)
        'Me.lblMat.TabIndex = 88
        'Me.lblMat.Text = "Material"
        ''
        ''cboMateriales
        ''
        'Me.cboMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        'Me.cboMateriales.Cursor = System.Windows.Forms.Cursors.Default
        'Me.cboMateriales.DisplayMember = ""
        'Me.cboMateriales.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        'Me.cboMateriales.FlatMode = True
        'Me.cboMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.cboMateriales.Location = New System.Drawing.Point(324, 32)
        'Me.cboMateriales.Name = "cboMateriales"
        'Me.cboMateriales.Size = New System.Drawing.Size(156, 21)
        'Me.cboMateriales.TabIndex = 87
        'Me.cboMateriales.Tag = "Tipo de Soporte del Sistema"
        'Me.cboMateriales.ValueMember = ""
        'Me.cboMateriales.Visible = False
        ''
        ''CboMedio
        ''
        'Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        'Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        'Me.CboMedio.DisplayMember = ""
        'Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        'Me.CboMedio.FlatMode = True
        'Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.CboMedio.Location = New System.Drawing.Point(84, 33)
        'Me.CboMedio.Name = "CboMedio"
        'Me.CboMedio.Size = New System.Drawing.Size(156, 21)
        'Me.CboMedio.TabIndex = 0
        'Me.CboMedio.Tag = "Tipo de Soporte del Sistema"
        'Me.CboMedio.ValueMember = ""
        ''
        ''lblMedio
        ''
        'Me.lblMedio.AutoSize = True
        'Me.lblMedio.Location = New System.Drawing.Point(12, 37)
        'Me.lblMedio.Name = "lblMedio"
        'Me.lblMedio.Size = New System.Drawing.Size(36, 13)
        'Me.lblMedio.TabIndex = 86
        'Me.lblMedio.Text = "Medio"
        ''
        ''cboProducto
        ''
        'Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        'Me.cboProducto.Cursor = System.Windows.Forms.Cursors.Default
        'Me.cboProducto.DisplayMember = ""
        'Me.cboProducto.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        'Me.cboProducto.FlatMode = True
        'Me.cboProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.cboProducto.Location = New System.Drawing.Point(324, 80)
        'Me.cboProducto.Name = "cboProducto"
        'Me.cboProducto.Size = New System.Drawing.Size(236, 21)
        'Me.cboProducto.TabIndex = 3
        'Me.cboProducto.Tag = "Tipo de Soporte del Sistema"
        'Me.cboProducto.ValueMember = ""
        ''
        ''cboTarget
        ''
        'Me.cboTarget.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        'Me.cboTarget.Cursor = System.Windows.Forms.Cursors.Default
        'Me.cboTarget.DisplayMember = ""
        'Me.cboTarget.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        'Me.cboTarget.FlatMode = True
        'Me.cboTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.cboTarget.Location = New System.Drawing.Point(84, 80)
        'Me.cboTarget.Name = "cboTarget"
        'Me.cboTarget.Size = New System.Drawing.Size(156, 21)
        'Me.cboTarget.TabIndex = 2
        'Me.cboTarget.Tag = "Tipo de Soporte del Sistema"
        'Me.cboTarget.ValueMember = ""
        ''
        ''Label1
        ''
        'Me.Label1.AutoSize = True
        'Me.Label1.Location = New System.Drawing.Point(264, 84)
        'Me.Label1.Name = "Label1"
        'Me.Label1.Size = New System.Drawing.Size(50, 13)
        'Me.Label1.TabIndex = 84
        'Me.Label1.Text = "Producto"
        ''
        ''Label11
        ''
        'Me.Label11.AutoSize = True
        'Me.Label11.Location = New System.Drawing.Point(10, 84)
        'Me.Label11.Name = "Label11"
        'Me.Label11.Size = New System.Drawing.Size(38, 13)
        'Me.Label11.TabIndex = 82
        'Me.Label11.Text = "Target"
        ''
        ''cboTipoSoporte
        ''
        'Me.cboTipoSoporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        'Me.cboTipoSoporte.Cursor = System.Windows.Forms.Cursors.Default
        'Me.cboTipoSoporte.DisplayMember = ""
        'Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        'Me.cboTipoSoporte.FlatMode = True
        'Me.cboTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.cboTipoSoporte.Location = New System.Drawing.Point(84, 56)
        'Me.cboTipoSoporte.Name = "cboTipoSoporte"
        'Me.cboTipoSoporte.Size = New System.Drawing.Size(456, 21)
        'Me.cboTipoSoporte.TabIndex = 1
        'Me.cboTipoSoporte.Tag = "Tipo de Soporte del Sistema"
        'Me.cboTipoSoporte.ValueMember = ""
        ''
        ''Label21
        ''
        'Me.Label21.AutoSize = True
        'Me.Label21.Location = New System.Drawing.Point(12, 60)
        'Me.Label21.Name = "Label21"
        'Me.Label21.Size = New System.Drawing.Size(68, 13)
        'Me.Label21.TabIndex = 81
        'Me.Label21.Text = "Tipo Soporte"
        ''
        ''dtpF_Hasta
        ''
        'Appearance1.FontData.SizeInPoints = 9.0!
        'Me.dtpF_Hasta.Appearance = Appearance1
        'Me.dtpF_Hasta.FlatMode = True
        'Me.dtpF_Hasta.Location = New System.Drawing.Point(324, 104)
        'Me.dtpF_Hasta.Name = "dtpF_Hasta"
        'Me.dtpF_Hasta.Size = New System.Drawing.Size(236, 21)
        'Me.dtpF_Hasta.TabIndex = 5
        ''
        ''dtpF_Desde
        ''
        'Appearance2.FontData.SizeInPoints = 9.0!
        'Me.dtpF_Desde.Appearance = Appearance2
        'Me.dtpF_Desde.FlatMode = True
        'Me.dtpF_Desde.Location = New System.Drawing.Point(84, 104)
        'Me.dtpF_Desde.Name = "dtpF_Desde"
        'Me.dtpF_Desde.Size = New System.Drawing.Size(156, 21)
        'Me.dtpF_Desde.TabIndex = 4
        'Me.dtpF_Desde.Tag = "Fecha de Inicio de la Campaña"
        ''
        ''Label6
        ''
        'Me.Label6.AutoSize = True
        'Me.Label6.Location = New System.Drawing.Point(248, 108)
        'Me.Label6.Name = "Label6"
        'Me.Label6.Size = New System.Drawing.Size(68, 13)
        'Me.Label6.TabIndex = 79
        'Me.Label6.Text = "Fecha Hasta"
        ''
        ''Label5
        ''
        'Me.Label5.AutoSize = True
        'Me.Label5.Location = New System.Drawing.Point(8, 108)
        'Me.Label5.Name = "Label5"
        'Me.Label5.Size = New System.Drawing.Size(71, 13)
        'Me.Label5.TabIndex = 78
        'Me.Label5.Text = "Fecha Desde"
        ''
        ''Label4
        ''
        'Me.Label4.AutoSize = True
        'Me.Label4.Location = New System.Drawing.Point(12, 14)
        'Me.Label4.Name = "Label4"
        'Me.Label4.Size = New System.Drawing.Size(52, 13)
        'Me.Label4.TabIndex = 77
        'Me.Label4.Text = "Campaña"
        ''
        ''txtDescripcion
        ''
        'Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.txtDescripcion.ConDecimal = False
        'Me.txtDescripcion.Enabled = False
        'Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.txtDescripcion.Location = New System.Drawing.Point(84, 8)
        'Me.txtDescripcion.Maximo = 0
        'Me.txtDescripcion.MaxLength = 80
        'Me.txtDescripcion.Name = "txtDescripcion"
        'Me.txtDescripcion.Size = New System.Drawing.Size(476, 21)
        'Me.txtDescripcion.SoloLetra = False
        'Me.txtDescripcion.SoloNumero = False
        'Me.txtDescripcion.TabIndex = 74
        'Me.txtDescripcion.Tag = "Muestra la Información de la Campaña !!!"
        ''
        ''cmdSiguiente
        ''
        'Me.cmdSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.cmdSiguiente.Location = New System.Drawing.Point(302, 480)
        'Me.cmdSiguiente.Name = "cmdSiguiente"
        'Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        'Me.cmdSiguiente.TabIndex = 8
        'Me.cmdSiguiente.Text = "Siguiente >"
        ''
        ''cmdCerrar
        ''
        'Me.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.cmdCerrar.Location = New System.Drawing.Point(500, 480)
        'Me.cmdCerrar.Name = "cmdCerrar"
        'Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        'Me.cmdCerrar.TabIndex = 9
        'Me.cmdCerrar.Text = "Cerrar"
        ''
        ''cmdAnterior
        ''
        'Me.cmdAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.cmdAnterior.Location = New System.Drawing.Point(222, 480)
        'Me.cmdAnterior.Name = "cmdAnterior"
        'Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        'Me.cmdAnterior.TabIndex = 10
        'Me.cmdAnterior.Text = "< Anterior"
        ''
        ''fraCompras
        ''
        'Me.fraCompras.Controls.Add(Me.iugSubCampanias)
        'Me.fraCompras.Controls.Add(Me.iugCampanias)
        'Me.fraCompras.Location = New System.Drawing.Point(540, 8)
        'Me.fraCompras.Name = "fraCompras"
        'Me.fraCompras.Size = New System.Drawing.Size(572, 343)
        'Me.fraCompras.TabIndex = 11
        'Me.fraCompras.TabStop = False
        'Me.fraCompras.Visible = False
        ''
        ''iugSubCampanias
        ''
        'Me.iugSubCampanias.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.iugSubCampanias.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        'Me.iugSubCampanias.FlatMode = True
        'Me.iugSubCampanias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        'Me.iugSubCampanias.Location = New System.Drawing.Point(12, 192)
        'Me.iugSubCampanias.Name = "iugSubCampanias"
        'Me.iugSubCampanias.Size = New System.Drawing.Size(550, 142)
        'Me.iugSubCampanias.TabIndex = 89
        'Me.iugSubCampanias.Text = "Sub Campañas"
        ''
        ''iugCampanias
        ''
        'Me.iugCampanias.Cursor = System.Windows.Forms.Cursors.Hand
        'UltraGridBand1.Header.Caption = "Campañas"
        'Me.iugCampanias.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        'Me.iugCampanias.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        'Me.iugCampanias.FlatMode = True
        'Me.iugCampanias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        'Me.iugCampanias.Location = New System.Drawing.Point(12, 14)
        'Me.iugCampanias.Name = "iugCampanias"
        'Me.iugCampanias.Size = New System.Drawing.Size(550, 166)
        'Me.iugCampanias.TabIndex = 88
        'Me.iugCampanias.Text = "Campañas"
        ''
        ''fraPresupuestos
        ''
        'Me.fraPresupuestos.Controls.Add(Me.mpbEnvioCompras)
        'Me.fraPresupuestos.Controls.Add(Me.pgbSpots)
        'Me.fraPresupuestos.Controls.Add(Me.pgbSoportes)
        'Me.fraPresupuestos.Controls.Add(Me.iugPresupuestos)
        'Me.fraPresupuestos.Location = New System.Drawing.Point(12, 135)
        'Me.fraPresupuestos.Name = "fraPresupuestos"
        'Me.fraPresupuestos.Size = New System.Drawing.Size(572, 343)
        'Me.fraPresupuestos.TabIndex = 12
        'Me.fraPresupuestos.TabStop = False
        'Me.fraPresupuestos.Visible = False
        ''
        ''mpbEnvioCompras
        ''
        'Me.mpbEnvioCompras.EditValue = 0
        'Me.mpbEnvioCompras.Location = New System.Drawing.Point(12, 297)
        'Me.mpbEnvioCompras.Name = "mpbEnvioCompras"
        'Me.mpbEnvioCompras.Properties.EndColor = System.Drawing.Color.Maroon
        'Me.mpbEnvioCompras.Properties.StartColor = System.Drawing.Color.Maroon
        'Me.mpbEnvioCompras.Size = New System.Drawing.Size(552, 18)
        'Me.mpbEnvioCompras.TabIndex = 93
        ''
        ''pgbSpots
        ''
        'Me.pgbSpots.Enabled = False
        'Me.pgbSpots.Location = New System.Drawing.Point(16, 312)
        'Me.pgbSpots.Name = "pgbSpots"
        'Me.pgbSpots.Size = New System.Drawing.Size(552, 8)
        'Me.pgbSpots.TabIndex = 92
        'Me.pgbSpots.Visible = False
        ''
        ''pgbSoportes
        ''
        'Me.pgbSoportes.Enabled = False
        'Me.pgbSoportes.Location = New System.Drawing.Point(16, 292)
        'Me.pgbSoportes.Name = "pgbSoportes"
        'Me.pgbSoportes.Size = New System.Drawing.Size(552, 8)
        'Me.pgbSoportes.TabIndex = 91
        'Me.pgbSoportes.Visible = False
        ''
        ''iugPresupuestos
        ''
        'Me.iugPresupuestos.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.iugPresupuestos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        'Me.iugPresupuestos.FlatMode = True
        'Me.iugPresupuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        'Me.iugPresupuestos.Location = New System.Drawing.Point(12, 14)
        'Me.iugPresupuestos.Name = "iugPresupuestos"
        'Me.iugPresupuestos.Size = New System.Drawing.Size(550, 240)
        'Me.iugPresupuestos.TabIndex = 90
        'Me.iugPresupuestos.Text = "Presupuestos"
        ''
        ''FraFiltros
        ''
        'Me.FraFiltros.Controls.Add(Me.chkSelAll)
        'Me.FraFiltros.Controls.Add(Me.fraGrafica)
        'Me.FraFiltros.Controls.Add(Me.iugTemasxSop)
        'Me.FraFiltros.Controls.Add(Me.iugEjercicios)
        'Me.FraFiltros.Location = New System.Drawing.Point(16, 129)
        'Me.FraFiltros.Name = "FraFiltros"
        'Me.FraFiltros.Size = New System.Drawing.Size(572, 379)
        'Me.FraFiltros.TabIndex = 13
        'Me.FraFiltros.TabStop = False
        ''
        ''chkSelAll
        ''
        'Me.chkSelAll.AutoSize = True
        'Me.chkSelAll.Location = New System.Drawing.Point(2, 351)
        'Me.chkSelAll.Name = "chkSelAll"
        'Me.chkSelAll.Size = New System.Drawing.Size(15, 14)
        'Me.chkSelAll.TabIndex = 14
        'Me.chkSelAll.UseVisualStyleBackColor = True
        ''
        ''fraGrafica
        ''
        'Me.fraGrafica.Controls.Add(Me.lstSoportes)
        'Me.fraGrafica.Controls.Add(Me.cboConcepto)
        'Me.fraGrafica.Controls.Add(Me.cboSeccion)
        'Me.fraGrafica.Controls.Add(Me.Label7)
        'Me.fraGrafica.Controls.Add(Me.Label3)
        'Me.fraGrafica.Controls.Add(Me.Label2)
        'Me.fraGrafica.Location = New System.Drawing.Point(8, 136)
        'Me.fraGrafica.Name = "fraGrafica"
        'Me.fraGrafica.Size = New System.Drawing.Size(550, 124)
        'Me.fraGrafica.TabIndex = 14
        'Me.fraGrafica.TabStop = False
        'Me.fraGrafica.Text = "Grafica"
        'Me.fraGrafica.Visible = False
        ''
        ''lstSoportes
        ''
        'Me.lstSoportes.CheckOnClick = True
        'Me.lstSoportes.Location = New System.Drawing.Point(16, 36)
        'Me.lstSoportes.Name = "lstSoportes"
        'Me.lstSoportes.Size = New System.Drawing.Size(350, 79)
        'Me.lstSoportes.TabIndex = 89
        ''
        ''cboConcepto
        ''
        'Me.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        'Me.cboConcepto.Location = New System.Drawing.Point(312, 36)
        'Me.cboConcepto.Name = "cboConcepto"
        'Me.cboConcepto.Size = New System.Drawing.Size(152, 21)
        'Me.cboConcepto.TabIndex = 88
        ''
        ''cboSeccion
        ''
        'Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        'Me.cboSeccion.Location = New System.Drawing.Point(164, 36)
        'Me.cboSeccion.Name = "cboSeccion"
        'Me.cboSeccion.Size = New System.Drawing.Size(140, 21)
        'Me.cboSeccion.TabIndex = 87
        ''
        ''Label7
        ''
        'Me.Label7.AutoSize = True
        'Me.Label7.Location = New System.Drawing.Point(312, 20)
        'Me.Label7.Name = "Label7"
        'Me.Label7.Size = New System.Drawing.Size(53, 13)
        'Me.Label7.TabIndex = 85
        'Me.Label7.Text = "Concepto"
        ''
        ''Label3
        ''
        'Me.Label3.AutoSize = True
        'Me.Label3.Location = New System.Drawing.Point(160, 20)
        'Me.Label3.Name = "Label3"
        'Me.Label3.Size = New System.Drawing.Size(46, 13)
        'Me.Label3.TabIndex = 84
        'Me.Label3.Text = "Sección"
        ''
        ''Label2
        ''
        'Me.Label2.AutoSize = True
        'Me.Label2.Location = New System.Drawing.Point(16, 20)
        'Me.Label2.Name = "Label2"
        'Me.Label2.Size = New System.Drawing.Size(44, 13)
        'Me.Label2.TabIndex = 83
        'Me.Label2.Text = "Soporte"
        ''
        ''iugTemasxSop
        ''
        'Me.iugTemasxSop.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.iugTemasxSop.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        'Me.iugTemasxSop.FlatMode = True
        'Me.iugTemasxSop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        'Me.iugTemasxSop.Location = New System.Drawing.Point(12, 152)
        'Me.iugTemasxSop.Name = "iugTemasxSop"
        'Me.iugTemasxSop.Size = New System.Drawing.Size(550, 180)
        'Me.iugTemasxSop.TabIndex = 6
        'Me.iugTemasxSop.Text = "Temas por Soportes"
        ''
        ''iugEjercicios
        ''
        'Me.iugEjercicios.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.iugEjercicios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        'Me.iugEjercicios.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        'Me.iugEjercicios.FlatMode = True
        'Me.iugEjercicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        'Me.iugEjercicios.Location = New System.Drawing.Point(12, 14)
        'Me.iugEjercicios.Name = "iugEjercicios"
        'Me.iugEjercicios.Size = New System.Drawing.Size(550, 116)
        'Me.iugEjercicios.TabIndex = 5
        'Me.iugEjercicios.Text = "Sistemas - Ejercicios"
        ''
        ''bgwEnvioCompras
        ''
        'Me.bgwEnvioCompras.WorkerSupportsCancellation = True
        ''
        ''frmEnviarCompras
        ''
        'Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        'Me.ClientSize = New System.Drawing.Size(751, 672)
        'Me.ControlBox = False
        'Me.Controls.Add(Me.fraPresupuestos)
        'Me.Controls.Add(Me.fraCompras)
        'Me.Controls.Add(Me.cmdAnterior)
        'Me.Controls.Add(Me.cmdSiguiente)
        'Me.Controls.Add(Me.cmdCerrar)
        'Me.Controls.Add(Me.fraEncab)
        'Me.Controls.Add(Me.FraFiltros)
        'Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        'Me.Name = "frmEnviarCompras"
        'Me.Text = "Envio a Compras"
        'Me.fraEncab.ResumeLayout(False)
        'Me.fraEncab.PerformLayout()
        'CType(Me.cboMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.cboTarget, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.dtpF_Hasta, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.dtpF_Desde, System.ComponentModel.ISupportInitialize).EndInit()
        'Me.fraCompras.ResumeLayout(False)
        'CType(Me.iugSubCampanias, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.iugCampanias, System.ComponentModel.ISupportInitialize).EndInit()
        'Me.fraPresupuestos.ResumeLayout(False)
        'CType(Me.mpbEnvioCompras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.iugPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        'Me.FraFiltros.ResumeLayout(False)
        'Me.FraFiltros.PerformLayout()
        'Me.fraGrafica.ResumeLayout(False)
        'Me.fraGrafica.PerformLayout()
        'CType(Me.iugTemasxSop, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.iugEjercicios, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ultra, System.ComponentModel.ISupportInitialize).EndInit()
        'Me.ResumeLayout(False)

        'fraEncab
        '
        Me.fraEncab.Controls.Add(Me.lblMat)
        Me.fraEncab.Controls.Add(Me.cboMateriales)
        Me.fraEncab.Controls.Add(Me.CboMedio)
        Me.fraEncab.Controls.Add(Me.lblMedio)
        Me.fraEncab.Controls.Add(Me.cboProducto)
        Me.fraEncab.Controls.Add(Me.cboTarget)
        Me.fraEncab.Controls.Add(Me.Label1)
        Me.fraEncab.Controls.Add(Me.Label11)
        Me.fraEncab.Controls.Add(Me.cboTipoSoporte)
        Me.fraEncab.Controls.Add(Me.Label21)
        Me.fraEncab.Controls.Add(Me.dtpF_Hasta)
        Me.fraEncab.Controls.Add(Me.dtpF_Desde)
        Me.fraEncab.Controls.Add(Me.Label6)
        Me.fraEncab.Controls.Add(Me.Label5)
        Me.fraEncab.Controls.Add(Me.Label4)
        Me.fraEncab.Controls.Add(Me.txtDescripcion)
        Me.fraEncab.Location = New System.Drawing.Point(7, 0)
        Me.fraEncab.Name = "fraEncab"
        Me.fraEncab.Size = New System.Drawing.Size(728, 129)
        Me.fraEncab.TabIndex = 0
        Me.fraEncab.TabStop = False
        Me.fraEncab.Text = "Filtros"
        '
        'lblMat
        '
        Me.lblMat.AutoSize = True
        Me.lblMat.Location = New System.Drawing.Point(268, 36)
        Me.lblMat.Name = "lblMat"
        Me.lblMat.Size = New System.Drawing.Size(44, 13)
        Me.lblMat.TabIndex = 88
        Me.lblMat.Text = "Material"
        '
        'cboMateriales
        '
        Me.cboMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMateriales.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMateriales.DisplayMember = ""
        Me.cboMateriales.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboMateriales.FlatMode = True
        Me.cboMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMateriales.Location = New System.Drawing.Point(324, 32)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(265, 21)
        Me.cboMateriales.TabIndex = 87
        Me.cboMateriales.Tag = "Tipo de Soporte del Sistema"
        Me.cboMateriales.ValueMember = ""
        Me.cboMateriales.Visible = False
        '
        'CboMedio
        '
        Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboMedio.DisplayMember = ""
        Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedio.Location = New System.Drawing.Point(84, 33)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(178, 21)
        Me.CboMedio.TabIndex = 0
        Me.CboMedio.Tag = "Tipo de Soporte del Sistema"
        Me.CboMedio.ValueMember = ""
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(12, 37)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(36, 13)
        Me.lblMedio.TabIndex = 86
        Me.lblMedio.Text = "Medio"
        '
        'cboProducto
        '
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboProducto.DisplayMember = ""
        Me.cboProducto.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboProducto.FlatMode = True
        Me.cboProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.Location = New System.Drawing.Point(331, 80)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(236, 21)
        Me.cboProducto.TabIndex = 3
        Me.cboProducto.Tag = "Tipo de Soporte del Sistema"
        Me.cboProducto.ValueMember = ""
        '
        'cboTarget
        '
        Me.cboTarget.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTarget.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTarget.DisplayMember = ""
        Me.cboTarget.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTarget.FlatMode = True
        Me.cboTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTarget.Location = New System.Drawing.Point(84, 80)
        Me.cboTarget.Name = "cboTarget"
        Me.cboTarget.Size = New System.Drawing.Size(180, 21)
        Me.cboTarget.TabIndex = 2
        Me.cboTarget.Tag = "Tipo de Soporte del Sistema"
        Me.cboTarget.ValueMember = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Target"
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoSoporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoSoporte.DisplayMember = ""
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoSoporte.Location = New System.Drawing.Point(84, 56)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.Size = New System.Drawing.Size(483, 21)
        Me.cboTipoSoporte.TabIndex = 1
        Me.cboTipoSoporte.Tag = "Tipo de Soporte del Sistema"
        Me.cboTipoSoporte.ValueMember = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "Tipo Soporte"
        '
        'dtpF_Hasta
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpF_Hasta.Appearance = Appearance1
        Me.dtpF_Hasta.FlatMode = True
        Me.dtpF_Hasta.Location = New System.Drawing.Point(339, 104)
        Me.dtpF_Hasta.Name = "dtpF_Hasta"
        Me.dtpF_Hasta.Size = New System.Drawing.Size(223, 21)
        Me.dtpF_Hasta.TabIndex = 5
        '
        'dtpF_Desde
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpF_Desde.Appearance = Appearance2
        Me.dtpF_Desde.FlatMode = True
        Me.dtpF_Desde.Location = New System.Drawing.Point(84, 104)
        Me.dtpF_Desde.Name = "dtpF_Desde"
        Me.dtpF_Desde.Size = New System.Drawing.Size(180, 21)
        Me.dtpF_Desde.TabIndex = 4
        Me.dtpF_Desde.Tag = "Fecha de Inicio de la Campaña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Fecha Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Fecha Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Campaña"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(84, 8)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(505, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 74
        Me.txtDescripcion.Tag = "Muestra la Información de la Campaña !!!"
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSiguiente.Location = New System.Drawing.Point(349, 643)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 8
        Me.cmdSiguiente.Text = "Siguiente >"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrar.Location = New System.Drawing.Point(660, 643)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrar.TabIndex = 9
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdAnterior
        '
        Me.cmdAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAnterior.Location = New System.Drawing.Point(269, 643)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 10
        Me.cmdAnterior.Text = "< Anterior"
        '
        'fraCompras
        '
        Me.fraCompras.Controls.Add(Me.iugSubCampanias)
        Me.fraCompras.Controls.Add(Me.iugCampanias)
        Me.fraCompras.Location = New System.Drawing.Point(747, 10)
        Me.fraCompras.Name = "fraCompras"
        Me.fraCompras.Size = New System.Drawing.Size(726, 484)
        Me.fraCompras.TabIndex = 11
        Me.fraCompras.TabStop = False
        Me.fraCompras.Visible = False
        '
        'iugSubCampanias
        '
        Me.iugSubCampanias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iugSubCampanias.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugSubCampanias.FlatMode = True
        Me.iugSubCampanias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugSubCampanias.Location = New System.Drawing.Point(8, 246)
        Me.iugSubCampanias.Name = "iugSubCampanias"
        Me.iugSubCampanias.Size = New System.Drawing.Size(712, 229)
        Me.iugSubCampanias.TabIndex = 89
        Me.iugSubCampanias.Text = "Sub Campañas"
        '
        'iugCampanias
        '
        Me.iugCampanias.Cursor = System.Windows.Forms.Cursors.Hand
        UltraGridBand1.Header.Caption = "Campañas"
        Me.iugCampanias.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.iugCampanias.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugCampanias.FlatMode = True
        Me.iugCampanias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugCampanias.Location = New System.Drawing.Point(6, 14)
        Me.iugCampanias.Name = "iugCampanias"
        Me.iugCampanias.Size = New System.Drawing.Size(714, 226)
        Me.iugCampanias.TabIndex = 88
        Me.iugCampanias.Text = "Campañas"
        '
        'fraPresupuestos
        '
        Me.fraPresupuestos.Controls.Add(Me.mpbEnvioCompras)
        Me.fraPresupuestos.Controls.Add(Me.pgbSpots)
        Me.fraPresupuestos.Controls.Add(Me.pgbSoportes)
        Me.fraPresupuestos.Controls.Add(Me.iugPresupuestos)
        Me.fraPresupuestos.Location = New System.Drawing.Point(11, 135)
        Me.fraPresupuestos.Name = "fraPresupuestos"
        Me.fraPresupuestos.Size = New System.Drawing.Size(724, 450)
        Me.fraPresupuestos.TabIndex = 12
        Me.fraPresupuestos.TabStop = False
        Me.fraPresupuestos.Visible = False
        '
        'mpbEnvioCompras
        '
        Me.mpbEnvioCompras.EditValue = 0
        Me.mpbEnvioCompras.Location = New System.Drawing.Point(9, 338)
        Me.mpbEnvioCompras.Name = "mpbEnvioCompras"
        Me.mpbEnvioCompras.Properties.EndColor = System.Drawing.Color.Maroon
        Me.mpbEnvioCompras.Properties.StartColor = System.Drawing.Color.Maroon
        Me.mpbEnvioCompras.Size = New System.Drawing.Size(705, 21)
        Me.mpbEnvioCompras.TabIndex = 93
        '
        'pgbSpots
        '
        Me.pgbSpots.Enabled = False
        Me.pgbSpots.Location = New System.Drawing.Point(12, 357)
        Me.pgbSpots.Name = "pgbSpots"
        Me.pgbSpots.Size = New System.Drawing.Size(701, 10)
        Me.pgbSpots.TabIndex = 92
        Me.pgbSpots.Visible = False
        '
        'pgbSoportes
        '
        Me.pgbSoportes.Enabled = False
        Me.pgbSoportes.Location = New System.Drawing.Point(12, 329)
        Me.pgbSoportes.Name = "pgbSoportes"
        Me.pgbSoportes.Size = New System.Drawing.Size(702, 10)
        Me.pgbSoportes.TabIndex = 91
        Me.pgbSoportes.Visible = False
        '
        'iugPresupuestos
        '
        Me.iugPresupuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iugPresupuestos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugPresupuestos.FlatMode = True
        Me.iugPresupuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugPresupuestos.Location = New System.Drawing.Point(8, 14)
        Me.iugPresupuestos.Name = "iugPresupuestos"
        Me.iugPresupuestos.Size = New System.Drawing.Size(706, 309)
        Me.iugPresupuestos.TabIndex = 90
        Me.iugPresupuestos.Text = "Presupuestos"
        '
        'FraFiltros
        '
        Me.FraFiltros.Controls.Add(Me.chkSelAll)
        Me.FraFiltros.Controls.Add(Me.fraGrafica)
        Me.FraFiltros.Controls.Add(Me.iugTemasxSop)
        Me.FraFiltros.Controls.Add(Me.iugEjercicios)
        Me.FraFiltros.Location = New System.Drawing.Point(7, 131)
        Me.FraFiltros.Name = "FraFiltros"
        Me.FraFiltros.Size = New System.Drawing.Size(734, 495)
        Me.FraFiltros.TabIndex = 13
        Me.FraFiltros.TabStop = False
        '
        'chkSelAll
        '
        Me.chkSelAll.AutoSize = True
        Me.chkSelAll.Location = New System.Drawing.Point(2, 351)
        Me.chkSelAll.Name = "chkSelAll"
        Me.chkSelAll.Size = New System.Drawing.Size(15, 14)
        Me.chkSelAll.TabIndex = 14
        Me.chkSelAll.UseVisualStyleBackColor = True
        '
        'fraGrafica
        '
        Me.fraGrafica.Controls.Add(Me.lstSoportes)
        Me.fraGrafica.Controls.Add(Me.cboConcepto)
        Me.fraGrafica.Controls.Add(Me.cboSeccion)
        Me.fraGrafica.Controls.Add(Me.Label7)
        Me.fraGrafica.Controls.Add(Me.Label3)
        Me.fraGrafica.Controls.Add(Me.Label2)
        Me.fraGrafica.Location = New System.Drawing.Point(10, 195)
        Me.fraGrafica.Name = "fraGrafica"
        Me.fraGrafica.Size = New System.Drawing.Size(710, 289)
        Me.fraGrafica.TabIndex = 14
        Me.fraGrafica.TabStop = False
        Me.fraGrafica.Text = "Grafica"
        Me.fraGrafica.Visible = False
        '
        'lstSoportes
        '
        Me.lstSoportes.CheckOnClick = True
        Me.lstSoportes.Location = New System.Drawing.Point(6, 30)
        Me.lstSoportes.Name = "lstSoportes"
        Me.lstSoportes.Size = New System.Drawing.Size(698, 259)
        Me.lstSoportes.TabIndex = 89
        '
        'cboConcepto
        '
        Me.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConcepto.Location = New System.Drawing.Point(542, 36)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(152, 21)
        Me.cboConcepto.TabIndex = 88
        '
        'cboSeccion
        '
        Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeccion.Location = New System.Drawing.Point(300, 36)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(140, 21)
        Me.cboSeccion.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(312, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Concepto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Sección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Soporte"
        '
        'iugTemasxSop
        '
        Me.iugTemasxSop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iugTemasxSop.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugTemasxSop.FlatMode = True
        Me.iugTemasxSop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugTemasxSop.Location = New System.Drawing.Point(9, 196)
        Me.iugTemasxSop.Name = "iugTemasxSop"
        Me.iugTemasxSop.Size = New System.Drawing.Size(710, 288)
        Me.iugTemasxSop.TabIndex = 6
        Me.iugTemasxSop.Text = "Temas por Soportes"
        '
        'iugEjercicios
        '
        Me.iugEjercicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iugEjercicios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.iugEjercicios.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.iugEjercicios.FlatMode = True
        Me.iugEjercicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugEjercicios.Location = New System.Drawing.Point(9, 14)
        Me.iugEjercicios.Name = "iugEjercicios"
        Me.iugEjercicios.Size = New System.Drawing.Size(710, 178)
        Me.iugEjercicios.TabIndex = 5
        Me.iugEjercicios.Text = "Sistemas - Ejercicios"
        '
        'chkSelAll
        '
        Me.chkSelAll.AutoSize = True
        Me.chkSelAll.Location = New System.Drawing.Point(17, 649)
        Me.chkSelAll.Name = "chkSelAll"
        Me.chkSelAll.Size = New System.Drawing.Size(15, 14)
        Me.chkSelAll.TabIndex = 14
        Me.chkSelAll.UseVisualStyleBackColor = True
        '
        'bgwEnvioCompras
        '
        Me.bgwEnvioCompras.WorkerSupportsCancellation = True
        '
        'frmEnviarCompras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(751, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkSelAll)
        Me.Controls.Add(Me.fraPresupuestos)
        Me.Controls.Add(Me.fraCompras)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.fraEncab)
        Me.Controls.Add(Me.FraFiltros)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEnviarCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envio a Compras"
        Me.fraEncab.ResumeLayout(False)
        Me.fraEncab.PerformLayout()
        CType(Me.cboMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpF_Hasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpF_Desde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraCompras.ResumeLayout(False)
        CType(Me.iugSubCampanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugCampanias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraPresupuestos.ResumeLayout(False)
        CType(Me.mpbEnvioCompras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFiltros.ResumeLayout(False)
        Me.FraFiltros.PerformLayout()
        Me.fraGrafica.ResumeLayout(False)
        Me.fraGrafica.PerformLayout()
        CType(Me.iugTemasxSop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugEjercicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ultra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Constantes "
    Private Const COMPANIA_FORWARD As Integer = 41
#End Region

#Region "Propiedades y declaraciones globales"

    Dim mId_Campania As Long
    Dim Envio As New Envio_Compras
    Dim fraActual As Integer
    Dim mFra(2) As GroupBox
    Dim mSeEnvio As Boolean
    Private mCantidadMaxima As Integer = 900
    Private MesesExcedentes As SortedList
    Const MedioRadio As Integer = 6
    Dim MedioActual As Medios
    Dim dsSop As DataSet
    Dim dtSop As DataTable
    Dim cantSpotInsertados As Integer
    Dim dtEnvioSpots As DataTable
    Dim dtEnvioSpotsTv As DataTable
    Dim dtEnvioSpotsDiferencias As DataTable
    Dim dtFiltrosEnvioSpots As DataTable
    Private _maestro As New Maestros
    ''DECLARAMOS ESTA TABLA A NIVEL DE CLASE
    Dim PresuxMes As DataTable

    Dim fInicioSis As DateTime
    Dim fFinSis As DateTime

    Private _id_presupuesto As Integer
    Dim _result As DataTable
    Dim dtResult As DataTable
    Dim dtResultEnvio As DataTable
    Dim dtResultEnvioDoble As DataTable
    Dim conceptoSeleccionado As String
    Dim DtResultadoControlVigencia As New DataTable
    Dim Osecciones As Secciones
    Dim OPresuouestoPA As MSL.Control.Mantenimiento 'AG 11/07/2013
    Dim DtDatosPresPA As New DataTable 'AG 12/07/2013
    Dim dtEnvioSpotsPA As DataTable
    'AG 18/07/2013 ==========================
    Shared mInstancia As frmEnviarCompras
    Dim _DtRelacionPCPAFinal As DataTable
    Dim DtPresupuestosPCPACargados As New DataTable
    Dim IdCampanaPCPA, IdSubCampanaPCPA As Integer
    Dim NoActualizar As Boolean
    Dim DtSoportesPautaTotales As New DataTable
    Dim DtTotalXMesPresupuesto As New DataTable
    Dim DtControlEnvioFinal As DataTable
    Dim DtRelacionPCPAFinalTemporal As New DataTable
    Dim EliminarTemporal As Boolean
    Dim dtControl As New DataTable
    Dim ListaSopPA As New ArrayList
    '===========================================
    Dim DtAvisosEnvioComprasCache As New DataTable
    Dim DtSoportesPautaTotalesCache As New DataTable
    Dim DtPresupuestosPCPACargadosCache As New DataTable
    Dim DtRegistrosPAYaEnviados As New DataTable
    Dim DtRegistrosPAYaEnviadosNuevo As New DataTable
    Dim GrillaFormato As New GrillaFormato
    Dim IdIntercambio As String
    Dim DtResultadoControlVigenciaTarifa As New DataTable
    Dim ningunMesActual As Boolean
    Dim cantidadAvisosSocialyse As Integer

    'CAMBIO EN TEMAS X SOPORTE (AN 10-11-2015)
    Dim DtTemasSoporte As DataTable

    Public Property id_presupuesto() As Integer
        Get
            Return _id_presupuesto
        End Get
        Set(ByVal value As Integer)
            _id_presupuesto = value
        End Set
    End Property

    Private _id_subCampania As Integer
    Public Property id_subcampania() As Integer
        Get
            Return _id_subCampania
        End Get
        Set(ByVal value As Integer)
            _id_subCampania = value
        End Set
    End Property

    Private _id_soporte As Integer
    Public Property id_soporte() As Integer
        Get
            Return _id_soporte
        End Get
        Set(ByVal value As Integer)
            _id_soporte = value
        End Set
    End Property

    Private _id_tema As String
    Public Property id_tema() As String
        Get
            Return _id_tema
        End Get
        Set(ByVal value As String)
            _id_tema = value
        End Set
    End Property

    Public ReadOnly Property SeEnvio() As Boolean
        Get
            Return mSeEnvio
        End Get
    End Property

    Property Id_Campania()
        Get
            Id_Campania = mId_Campania
        End Get
        Set(ByVal Value)
            mId_Campania = Value
        End Set
    End Property

    Public Shared Property Instancia() As frmEnviarCompras
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmEnviarCompras
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As frmEnviarCompras)
            mInstancia = Value
        End Set
    End Property

    Public Property DtRelacionPCPAFinal() As DataTable
        Get
            Return _DtRelacionPCPAFinal
        End Get
        Set(ByVal value As DataTable)
            _DtRelacionPCPAFinal = value
        End Set
    End Property


    Dim _id_campania_mms As Integer
    Dim _id_subcampania_mms As Integer
    Dim _id_presupuesto_mms As Integer
    Dim _id_producto As Integer

    Dim _countTotal As Integer = 0

#End Region

    Private Sub Siguiente()
        'AG 10/05/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Dim Resultado As Boolean
        Dim Spot As New Spots
        Dim Soportes As String
        Dim listasoporte As New ArrayList
        Dim Child As UltraDataRowsCollection
        Dim ChildTemas As UltraDataRowsCollection
        Dim idtema As String
        Dim SoporteNoPermitidos As New ArrayList
        Dim ControlTemaSelccionados As Boolean = False
        'AG 17/04/2013 ++++++++++++++++++++++++++++++++++++
        Dim DtResultado As New DataTable
        Dim frmAvigentes As New frmAvisosVigente
        Osecciones = New Secciones
        '++++++++++++++++++++++++++++++++++++++++++++++++++
        Dim DtResultadoTarifas As New DataTable
        Dim ResultadoTarifas As Boolean
        Dim frmAvigentesTarifas As New frmAvisosVigenteTarifas


        '================ AG 09/09/2014 Control Cliente DANONE Soportes ==============================
        If Activo.IDCliente = 2733 Or Activo.IDCliente = 2734 Or Activo.IDCliente = 2735 Then

            Dim DtResultadoDanoene As DataTable
            Dim DtSoporteDanone As New DataTable
            Dim ObjEnvioCompras As New Envio_Compras
            Dim DtSoporteNoPermitidos As New DataTable
            Dim DescSoporteMensaje As String

            DtSoporteNoPermitidos = Activo.DTSoportesCache.Clone()

            If MedioActual = Medios.Tv Or MedioActual = Medios.Radio Then
                Dim Rows() As DataRow

                'AG 29/02/2016 Bug envio a compras ==================
                '
                'If Not Ultra Is Nothing Then
                '    For p As Integer = 0 To Ultra.Rows.Count - 1
                '        Child = Ultra.Rows(p).GetChildRows("Soportes")
                '        For y As Integer = 0 To Child.Count - 1
                '            If Child.Item(y).GetCellValue("Ok") Then
                '                Rows = Activo.DTSoportesCache.Select("id_medio = " & MedioActual & "and id_soporte = " & CInt(Ultra.Rows(p).Item("id_soporte").ToString()) & " and SOPORTE_DANONE = 0")
                '                If Rows.Length > 0 Then
                '                    DtSoporteNoPermitidos.ImportRow(Rows(0))
                '                End If
                '            End If
                '        Next
                '    Next
                'End If
                '======================================================


                If Not Ultra Is Nothing Then
                    For p As Integer = 0 To Ultra.Rows.Count - 1
                        Child = Ultra.Rows(p).GetChildRows("Soportes")
                        For y As Integer = 0 To Child.Count - 1
                            ChildTemas = Child(y).GetChildRows("Temas")
                            For x As Integer = 0 To ChildTemas.Count - 1
                                If ChildTemas.Item(x).GetCellValue("Ok") Then

                                    Rows = Activo.DTSoportesCache.Select("id_medio = " & MedioActual & "and id_soporte = " & CInt(Child(y).Item("id_soporte").ToString()) & " and SOPORTE_DANONE = 0")
                                    If Rows.Length > 0 Then
                                        DtSoporteNoPermitidos.ImportRow(Rows(0))
                                    End If
                                End If
                            Next
                        Next
                    Next
                End If


                If DtSoporteNoPermitidos.Rows.Count > 0 Then
                    For Each Sop As DataRow In DtSoporteNoPermitidos.Rows
                        DescSoporteMensaje += Sop("DESCRIPCION").ToString() & vbCrLf
                    Next
                    MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes no autorizados para este cliente   " & vbCrLf & vbCrLf & DescSoporteMensaje, MsgBoxStyle.Information)
                    DescSoporteMensaje = ""
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If
            End If


            If MedioActual = Medios.Internet Then

                Dim Rows() As DataRow

                If lstSoportes.CheckedItems.Count = 0 Then
                    MsgBox("Debe Seleccionar algun soporte", MsgBoxStyle.Information, "Everest")
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If

                If lstSoportes.Items.Count > 0 Then
                    SeleccionarSoportes()
                End If

                Dim IdSopor As String = ConcatenarSoportes()
                Dim idso As String()

                If IdSopor <> "" Then
                    idso = IdSopor.Split(",")
                    For v As Integer = 0 To idso.Count - 1
                        Rows = Activo.DTSoportesCache.Select("id_medio = " & MedioActual & "and id_soporte = " & CInt(idso(v)) & " and SOPORTE_DANONE = 0")
                        If Rows.Length > 0 Then
                            DtSoporteNoPermitidos.ImportRow(Rows(0))
                        End If
                    Next
                End If

                If DtSoporteNoPermitidos.Rows.Count > 0 Then
                    For Each Sop As DataRow In DtSoporteNoPermitidos.Rows
                        DescSoporteMensaje += Sop("DESCRIPCION").ToString() & vbCrLf
                    Next
                    MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes no autorizados para este cliente   " & vbCrLf & vbCrLf & DescSoporteMensaje, MsgBoxStyle.Information)
                    DescSoporteMensaje = ""
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If
            End If

            If MedioActual = Medios.Exterior Or MedioActual = Medios.Produccion Then '

                Dim Rows() As DataRow

                If lstSoportes.CheckedItems.Count = 0 Then
                    MsgBox("Debe Seleccionar algun soporte", MsgBoxStyle.Information, "Everest")
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If

                If lstSoportes.Items.Count > 0 Then
                    SeleccionarSoportes()
                End If

                Dim IdSopor As String = ConcatenarSoportes()
                Dim idso As String()

                If IdSopor <> "" Then
                    Resultado = False
                    idso = IdSopor.Split(",")
                    For v As Integer = 0 To idso.Count - 1
                        Rows = Activo.DTSoportesCache.Select("id_medio = " & MedioActual & "and id_soporte = " & CInt(idso(v)) & " and SOPORTE_DANONE = 0")
                        If Rows.Length > 0 Then
                            DtSoporteNoPermitidos.ImportRow(Rows(0))
                        End If
                    Next
                End If

                If DtSoporteNoPermitidos.Rows.Count > 0 Then
                    For Each Sop As DataRow In DtSoporteNoPermitidos.Rows
                        DescSoporteMensaje += Sop("DESCRIPCION").ToString() & vbCrLf
                    Next
                    MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes no autorizados para este cliente   " & vbCrLf & vbCrLf & DescSoporteMensaje, MsgBoxStyle.Information)
                    DescSoporteMensaje = ""
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If
            End If


            If MedioActual = Medios.Prensa Or MedioActual = Medios.Revista Then

                Dim Rows() As DataRow

                If lstSoportes.CheckedItems.Count = 0 Then
                    MsgBox("Debe Seleccionar algun soporte", MsgBoxStyle.Information, "Everest")
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If

                If lstSoportes.Items.Count > 0 Then
                    SeleccionarSoportes()
                    ListaSopPA = SoportesValues()
                End If

                Dim DanoneIdSoportes As String = ConcatenarSoportes()
                Dim Danonenidsop As String()
                Dim Spotspr As New Spots

                If DanoneIdSoportes <> "" Then
                    Danonenidsop = DanoneIdSoportes.Split(",")
                    For d As Integer = 0 To Danonenidsop.Count - 1
                        Rows = Activo.DTSoportesCache.Select("id_medio = " & MedioActual & "and id_soporte = " & CInt(Danonenidsop(d)) & " and SOPORTE_DANONE = 0")
                        If Rows.Length > 0 Then
                            DtSoporteNoPermitidos.ImportRow(Rows(0))
                        End If
                    Next
                End If

                If DtSoporteNoPermitidos.Rows.Count > 0 Then
                    For Each Sop As DataRow In DtSoporteNoPermitidos.Rows
                        DescSoporteMensaje += Sop("DESCRIPCION").ToString() & vbCrLf
                    Next
                    MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes no autorizados para este cliente   " & vbCrLf & vbCrLf & DescSoporteMensaje, MsgBoxStyle.Information)
                    DescSoporteMensaje = ""
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If

            End If
        End If
        '============================= FIN CONTROL ENVIO SOPORTE DANOENE NO PERMITIDOS =============================================



        'LC 30/06/2014 Everest digital restriccion envio a compras
        If MedioActual = Medios.Internet Then
            Dim enviosDt As New DataTable()
            Envio.ListaSoportes = ConcatenarSoportes()
            enviosDt = Envio.traer_avisos_MMS_Internet(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, Id_Campania, _id_presupuesto_mms)
            For Each envioSpots As DataRow In enviosDt.Rows
                If Convert.ToInt32(envioSpots.Item("IMPRESIONES").ToString()) = 0 And Convert.ToInt32(envioSpots.Item("CLICKS").ToString()) = 0 And Convert.ToInt32(envioSpots.Item("VIEWS").ToString()) = 0 Then
                    Dim sopor As New Soportes
                    sopor.Id_soporte = Convert.ToInt32(envioSpots.Item("CODIGOSOPORTE").ToString())
                    sopor.Id_medio = Medios.Internet
                    sopor.Descripcion = sopor.ObtenerDescripcionXid()
                    Mensaje("Hay avisos del soporte " + sopor.Descripcion + " sin impresiones / clicks / views.", TipoMensaje.Informacion)
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If
            Next
        End If

        'CF 15-07-2014 
        If dtpF_Hasta.Value < Date.Now.AddDays(-(Activo.CantidadDiasBloqueoPresupuestoMms + Date.Now.Day - 1)) Then
            MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, debido a que el periodo seleccionado supera los " + Activo.CantidadDiasBloqueoPresupuestoMms.ToString() + " dias", MsgBoxStyle.Information, "Everest")
            cmdSiguiente.Enabled = True
            SoporteNoPermitidos.Clear()
            Exit Sub
        End If
        '+++++++++ CONTROL CONVENIO MEDIO TELEVISION Y RADIO  +++++++++++++++++++++++
        If MedioActual = Medios.Tv Or MedioActual = Medios.Radio Then
            If Not Ultra Is Nothing Then
                For p As Integer = 0 To Ultra.Rows.Count - 1
                    Child = Ultra.Rows(p).GetChildRows("Soportes")
                    For y As Integer = 0 To Child.Count - 1
                        ChildTemas = Child(y).GetChildRows("Temas")
                        For x As Integer = 0 To ChildTemas.Count - 1
                            If ChildTemas.Item(x).GetCellValue("Ok") Then
                                listasoporte.Add(CInt(Child(y).Item("id_soporte").ToString()))
                                idtema = ChildTemas.Item(x).Item("Tema").ToString()
                                ControlTemaSelccionados = True
                                Resultado = Spot.ControlConvenio(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(Child(y).Item("id_soporte").ToString()), MedioActual, idtema, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value)
                                If Resultado = True Then
                                    SoporteNoPermitidos.Add(CInt(Child(y).Item("id_soporte").ToString()))
                                    'Child.Item(y).SetCellValue("Ok", False)
                                End If
                            End If
                        Next
                    Next
                Next

                If ControlTemaSelccionados = False Then
                    MsgBox("Debe seleccionar algun Tema", MsgBoxStyle.Information, "Everest")
                    cmdSiguiente.Enabled = True
                    SoporteNoPermitidos.Clear()
                    Exit Sub
                End If

                For index As Integer = 0 To SoporteNoPermitidos.Count - 1
                    Dim sopor As New Soportes
                    sopor.Id_medio = MedioActual
                    sopor.Id_soporte = CInt(SoporteNoPermitidos(index).ToString)
                    Soportes += sopor.ObtenerDescripcionXid() & vbCrLf
                Next

                If Spot.ControlClienteConvenio(Activo.IDCliente) = False Then
                    If Soportes <> "" Then
                        MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes sin convenios aplicados   " & vbCrLf & vbCrLf & Soportes, MsgBoxStyle.Information)
                        cmdSiguiente.Enabled = True
                        Exit Sub
                    End If
                End If
            End If
        End If



        'AG 17/04/2013 Control de Vigencia de Convenios Aplicados a los Avisos TV y RADIO ++++++++++++++++++
        If MedioActual = Medios.Tv Or MedioActual = Medios.Radio Then
            If Not Ultra Is Nothing Then
                For p As Integer = 0 To Ultra.Rows.Count - 1
                    Child = Ultra.Rows(p).GetChildRows("Soportes")
                    For y As Integer = 0 To Child.Count - 1
                        ChildTemas = Child(y).GetChildRows("Temas")
                        For x As Integer = 0 To ChildTemas.Count - 1
                            If ChildTemas.Item(x).GetCellValue("Ok") Then
                                listasoporte.Add(CInt(Child(y).Item("id_soporte").ToString()))
                                idtema = ChildTemas.Item(x).Item("Tema").ToString()
                                DtResultado = Spot.ControlConvenioVigenciaTVRD(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(Child(y).Item("id_soporte").ToString()), MedioActual, idtema, Activo.IDCliente, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text))
                                If DtResultado.Rows.Count > 0 Then
                                    DtResultadoControlVigencia = CargarDtConveniosVigentes(DtResultado, DtResultadoControlVigencia, 0)
                                End If
                            End If
                        Next
                    Next
                Next
            End If
        End If

        If Not DtResultadoControlVigencia Is Nothing Then
            If DtResultadoControlVigencia.Rows.Count > 0 Then
                MsgBox("El proceso de envio a compras, detecto la existencia de avisos. " & vbCrLf & "Fuera de la fecha de vigencia del convenio aplicado.  ", MsgBoxStyle.Information)
                frmAvigentes.dtAvisosSinVigencia = DtResultadoControlVigencia
                frmAvigentes.idMedio = MedioActual
                frmAvigentes.ShowDialog()
                cmdSiguiente.Enabled = True
                DtResultadoControlVigencia = Nothing
                Exit Sub
            End If
        End If

        'AG 23/08/2013 ==========================
        ListaSopPA = listasoporte
        '========================================
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG 22/07/2014 Control de Tarifas no Vigentes Medios TV y RADIO =========================================================================
        If MedioActual = Medios.Tv Or MedioActual = Medios.Radio Then
            If Not Ultra Is Nothing Then
                For p As Integer = 0 To Ultra.Rows.Count - 1
                    Child = Ultra.Rows(p).GetChildRows("Soportes")
                    For y As Integer = 0 To Child.Count - 1
                        ChildTemas = Child(y).GetChildRows("Temas")
                        For x As Integer = 0 To ChildTemas.Count - 1
                            If ChildTemas.Item(x).GetCellValue("Ok") Then
                                listasoporte.Add(CInt(Child(y).Item("id_soporte").ToString()))
                                DtResultadoTarifas = Spot.ControlTarifasVigenciaTVRD(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(Child(y).Item("id_soporte").ToString()), MedioActual, Activo.IDCliente, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value)
                                If DtResultadoTarifas.Rows.Count > 0 Then
                                    DtResultadoControlVigenciaTarifa = CargarDtTarifasVigentes(DtResultadoTarifas, DtResultadoControlVigenciaTarifa, 0)
                                End If
                            End If
                        Next
                    Next
                Next
            End If
        End If

        If Not DtResultadoControlVigenciaTarifa Is Nothing Then
            If DtResultadoControlVigenciaTarifa.Rows.Count > 0 Then
                MsgBox("El proceso de envio a compras, detecto la existencia de avisos. " & vbCrLf & "Fuera de la fecha de vigencia de las tarifas.  ", MsgBoxStyle.Information)
                frmAvigentesTarifas.dtAvisosSinVigencia = DtResultadoControlVigenciaTarifa
                frmAvigentesTarifas.idMedio = MedioActual
                frmAvigentesTarifas.ShowDialog()
                cmdSiguiente.Enabled = True
                DtResultadoControlVigenciaTarifa = Nothing
                Exit Sub
            End If
        End If
        '========================================================================================================================================





        '+++++++++ CONTROL CONVENIO MEDIO REVISTA Y PRENSA +++++++++++++++++++++++
        If MedioActual = Medios.Prensa Or MedioActual = Medios.Revista Then
            If lstSoportes.CheckedItems.Count = 0 Then
                MsgBox("Debe Seleccionar algun soporte", MsgBoxStyle.Information, "Everest")
                cmdSiguiente.Enabled = True
                Exit Sub
            End If

            If lstSoportes.Items.Count > 0 Then
                SeleccionarSoportes()
                'AG 23/08/2013 ==========================
                ListaSopPA = SoportesValues()
                '========================================
            End If

            Dim IdSoportes As String = ConcatenarSoportes()
            Dim idsop As String()
            Dim Spotspr As New Spots

            If IdSoportes <> "" Then
                Resultado = False
                idsop = IdSoportes.Split(",")
                For v As Integer = 0 To idsop.Count - 1
                    Resultado = Spotspr.ControlConveniopr(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(idsop(v)), MedioActual, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value)
                    If Resultado = True Then
                        SoporteNoPermitidos.Add(CInt(idsop(v)))
                    End If
                Next
            End If

            For index As Integer = 0 To SoporteNoPermitidos.Count - 1
                Dim sopor As New Soportes
                sopor.Id_medio = MedioActual
                sopor.Id_soporte = CInt(SoporteNoPermitidos(index).ToString)
                Soportes += sopor.ObtenerDescripcionXid() & vbCrLf
            Next

            If Spot.ControlClienteConvenio(Activo.IDCliente) = False Then
                If Soportes <> "" Then
                    MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes sin convenios aplicados   " & vbCrLf & vbCrLf & Soportes, MsgBoxStyle.Information)
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If
            End If
        End If



        'AG 17/04/2013 Control de Vigencia de Convenios Aplicados a los Avisos REVISTA Y PRENSA +++++++++++++++++++++++++++++++

        If MedioActual = Medios.Prensa Or MedioActual = Medios.Revista Then
            If lstSoportes.Items.Count > 0 Then
                SeleccionarSoportes()
            End If

            Dim IdSoportesConvenios As String = ConcatenarSoportes()
            Dim idsopo As String()
            Dim Spotspre As New Spots
            Dim OMsl As New Maestros

            'AG 17/04/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'Cargo el Cache de Secciones 
            Osecciones.Id_medio = MedioActual
            Activo.DTSeccionesCache = Osecciones.ObtenerSecciones()
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            If IdSoportesConvenios <> "" Then
                Resultado = False
                idsopo = IdSoportesConvenios.Split(",")
                For b As Integer = 0 To idsopo.Count - 1
                    DtResultado = Spotspre.ControlConvenioVigenciaPRRE(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(idsopo(b)), MedioActual, Activo.IDCliente, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text))
                    If DtResultado.Rows.Count > 0 Then
                        DtResultadoControlVigencia = CargarDtConveniosVigentes(DtResultado, DtResultadoControlVigencia, 1)
                    End If
                Next
            End If

            If Not DtResultadoControlVigencia Is Nothing Then
                If DtResultadoControlVigencia.Rows.Count > 0 Then
                    MsgBox("El proceso de envio a compras, detecto la existencia de avisos. " & vbCrLf & "Fuera de la fecha de vigencia del convenio aplicado.  ", MsgBoxStyle.Information)
                    frmAvigentes.dtAvisosSinVigencia = DtResultadoControlVigencia
                    frmAvigentes.idMedio = MedioActual
                    frmAvigentes.ShowDialog()
                    cmdSiguiente.Enabled = True
                    DtResultadoControlVigencia = Nothing
                    Exit Sub
                End If
            End If
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        '+++++++++ CONTROL CONVENIO MEDIO EXTERIOR  Y PRODUCCION  +++++++++++++++++++++++
        If MedioActual = Medios.Exterior Or MedioActual = Medios.Produccion Then 'AG Produccion +++++++++++++++++++++++
            If lstSoportes.CheckedItems.Count = 0 Then
                MsgBox("Debe Seleccionar algun soporte", MsgBoxStyle.Information, "Everest")
                cmdSiguiente.Enabled = True
                Exit Sub
            End If

            If lstSoportes.Items.Count > 0 Then
                SeleccionarSoportes()
            End If

            Dim IdSopor As String = ConcatenarSoportes()
            Dim idso As String()
            Dim Spotsvp As New Spots

            If IdSopor <> "" Then
                Resultado = False
                idso = IdSopor.Split(",")
                For v As Integer = 0 To idso.Count - 1
                    Resultado = Spotsvp.ControlConveniopr(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(idso(v)), MedioActual, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value)
                    If Resultado = True Then
                        SoporteNoPermitidos.Add(CInt(idso(v)))
                    End If
                Next
            End If

            For index As Integer = 0 To SoporteNoPermitidos.Count - 1
                Dim sopor As New Soportes
                sopor.Id_medio = MedioActual
                sopor.Id_soporte = CInt(SoporteNoPermitidos(index).ToString)
                Soportes += sopor.ObtenerDescripcionXid() & vbCrLf
            Next

            If Spot.ControlClienteConvenio(Activo.IDCliente) = False Then
                If Soportes <> "" Then
                    MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes sin convenios aplicados   " & vbCrLf & vbCrLf & Soportes, MsgBoxStyle.Information)
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If
            End If
        End If

        'AG 17/04/2013 Control de Vigencia de Convenios Aplicados a los Avisos EXTERIOR ++++++++++++++++++++++++++++++++++++++
        If MedioActual = Medios.Exterior Or MedioActual = Medios.Produccion Then


            Dim SpotsEx As New Spots
            Dim OProvincia As New Poblacion
            Dim IdSoporteConvenios As String = ConcatenarSoportes()
            Dim idsop As String()

            'AG 17/04/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'Cargo el Cache de Secciones 
            Osecciones.Id_medio = MedioActual
            Activo.DTProvinciaCache = OProvincia.ObtenerProvincia()
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            If IdSoporteConvenios <> "" Then
                Resultado = False
                idsop = IdSoporteConvenios.Split(",")
                For b As Integer = 0 To idsop.Count - 1
                    Select Case MedioActual
                        Case Medios.Produccion
                            DtResultado = SpotsEx.ControlConvenioVigenciaPRO(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(idsop(b)), MedioActual, Activo.IDCliente, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text))
                        Case Medios.Exterior
                            DtResultado = SpotsEx.ControlConvenioVigenciaEX(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(idsop(b)), MedioActual, Activo.IDCliente, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text))
                    End Select
                    If DtResultado.Rows.Count > 0 Then
                        DtResultadoControlVigencia = CargarDtConveniosVigentes(DtResultado, DtResultadoControlVigencia, 1)
                    End If
                Next
            End If

            If Not DtResultadoControlVigencia Is Nothing Then
                If DtResultadoControlVigencia.Rows.Count > 0 Then
                    MsgBox("El proceso de envio a compras, detecto la existencia de avisos. " & vbCrLf & "Fuera de la fecha de vigencia del convenio aplicado.  ", MsgBoxStyle.Information)
                    frmAvigentes.dtAvisosSinVigencia = DtResultadoControlVigencia
                    frmAvigentes.idMedio = MedioActual
                    frmAvigentes.ShowDialog()
                    cmdSiguiente.Enabled = True
                    DtResultadoControlVigencia = Nothing
                    Exit Sub
                End If
            End If
        End If

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        'AG 19/11/2013 ===================================================================================================
        '+++++++++ CONTROL CONVENIO MEDIO INTERNET  +++++++++++++++++++++++
        If MedioActual = Medios.Internet Then 'AG iNTERNET
            If lstSoportes.CheckedItems.Count = 0 Then
                MsgBox("Debe Seleccionar algun soporte", MsgBoxStyle.Information, "Everest")
                cmdSiguiente.Enabled = True
                Exit Sub
            End If

            If cboProducto.SelectedRow Is Nothing Then
                MsgBox("Debe seleccionar un producto, para el envio a compras de Internet", MsgBoxStyle.Information, "Everest")
                cmdSiguiente.Enabled = True
                cmdAnterior.Enabled = False
                Exit Sub
            End If

            If lstSoportes.Items.Count > 0 Then
                SeleccionarSoportes()
            End If

            Dim IdSopor As String = ConcatenarSoportes()
            Dim idso As String()
            Dim SpotsInt As New Spots

            If IdSopor <> "" Then
                Resultado = False
                idso = IdSopor.Split(",")
                For v As Integer = 0 To idso.Count - 1
                    Resultado = SpotsInt.ControlConvenioInt(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(idso(v)), MedioActual, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value)
                    If Resultado = True Then
                        SoporteNoPermitidos.Add(CInt(idso(v)))
                    End If
                Next
            End If

            For index As Integer = 0 To SoporteNoPermitidos.Count - 1
                Dim sopor As New Soportes
                sopor.Id_medio = MedioActual
                sopor.Id_soporte = CInt(SoporteNoPermitidos(index).ToString)
                Soportes += sopor.ObtenerDescripcionXid() & vbCrLf
            Next

            If Spot.ControlClienteConvenio(Activo.IDCliente) = False Then
                If Soportes <> "" Then
                    MsgBox("El Proceso de Envio a Compras, no puede llevarse a cabo, porque existen soportes sin convenios aplicados   " & vbCrLf & vbCrLf & Soportes, MsgBoxStyle.Information)
                    cmdSiguiente.Enabled = True
                    Exit Sub
                End If
            End If
        End If

        'Control de Vigencia de Convenios Aplicados a los Avisos INTERNET ++++++++++++++++++++++++++++++++++++++
        If MedioActual = Medios.Internet Then
            Dim SpotsInternet As New Spots
            Dim IdSoporteConvenios As String = ConcatenarSoportes()
            Dim idsop As String()

            Osecciones.Id_medio = MedioActual

            If IdSoporteConvenios <> "" Then
                Resultado = False
                idsop = IdSoporteConvenios.Split(",")
                For b As Integer = 0 To idsop.Count - 1
                    Select Case MedioActual
                        Case Medios.Internet
                            DtResultado = SpotsInternet.ControlConvenioVigenciaINT(Me.Id_Campania, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, CInt(idsop(b)), MedioActual, Activo.IDCliente, Me.dtpF_Desde.Value, Me.dtpF_Hasta.Value, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text))
                    End Select
                    If DtResultado.Rows.Count > 0 Then
                        DtResultadoControlVigencia = CargarDtConveniosVigentes(DtResultado, DtResultadoControlVigencia, 1)
                    End If
                Next
            End If

            If Not DtResultadoControlVigencia Is Nothing Then
                If DtResultadoControlVigencia.Rows.Count > 0 Then
                    MsgBox("El proceso de envio a compras, detecto la existencia de avisos. " & vbCrLf & "Fuera de la fecha de vigencia del convenio aplicado.  ", MsgBoxStyle.Information)
                    frmAvigentes.dtAvisosSinVigencia = DtResultadoControlVigencia
                    frmAvigentes.idMedio = MedioActual
                    frmAvigentes.ShowDialog()
                    cmdSiguiente.Enabled = True
                    DtResultadoControlVigencia = Nothing
                    Exit Sub
                End If
            End If

            'LC 30/06/2014
            'For Each spotEnvio As DataRow In dtEnvioSpots.Rows()

            'Next

        End If
        '================================================================================================================

        If Not (MedioActual = Medios.Tv Or MedioActual = Medios.Radio) Then
            SiguienteOtrosMedios()
            Exit Sub
        End If
        Dim i, j, k, z As Integer
        Dim Temaseleccionado As Boolean = False
        Dim ChildR As UltraDataRowsCollection
        If fraActual < mFra.Length - 1 Then
            If fraActual = 0 Then
                If Not Ultra Is Nothing Then
                    k = 0
                    While k < Ultra.Rows.Count
                        ChildR = Ultra.Rows(k).GetChildRows("Soportes")
                        j = 0
                        While j < ChildR.Count
                            ChildTemas = ChildR.Item(j).GetChildRows("Temas")
                            z = 0
                            While z < ChildTemas.Count
                                If ChildTemas.Item(z).GetCellValue("Ok") Then
                                    Temaseleccionado = True
                                    Exit While
                                End If
                                z += 1
                            End While
                            j += 1
                        End While
                        If Temaseleccionado Then
                            Exit While
                        End If
                        k += 1
                    End While
                End If
                If Not Temaseleccionado Then
                    MessageBox.Show("Debe seleccionar al menos un tema.")
                    cmdSiguiente.Enabled = True
                    cmdAnterior.Enabled = False
                    Exit Sub
                End If
                fraEncab.Enabled = False
            End If
            mFra(fraActual).Visible = False
            fraActual = fraActual + 1
            CargarActual()
            mFra(fraActual).Visible = True
            If fraActual = 2 Then
                cmdSiguiente.Text = "Enviar"
            End If
        Else
            'Me.Cursor = Cursors.WaitCursor
            Call ConfigurarPresuxMes(PresuxMes)
            ''Mensaje("mensaje 1", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
            cmdSiguiente.Enabled = False
            cmdAnterior.Enabled = False
            cmdCerrar.Enabled = False
            If Not CheckPresupuesto(PresuxMes) Then ' Cargo el array y chequeo
                Mensajes.Mensaje("No puede seleccionar 2 presupuestos que correspondan a un mismo mes", TipoMensaje.Informacion)
                Me.Cursor = Cursors.Default
                EliminarPCPAEverestTemporal() 'AG 12/08/2013
                Exit Sub
            End If

            'AG 07/08/2013 valido los envios anteriores de PAGO ANTICIPADO =======================================================================================
            Dim Dr As DataRow
            Dim Mensaje As String = ""

            If Not DtPresupuestosPCPACargadosCache Is Nothing Then
                If DtPresupuestosPCPACargadosCache.Rows.Count > 0 Then

                    If Me.MedioActual = Medios.Tv Then
                        DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPA(Me.dtFiltrosEnvioSpots, 0, 0)
                    Else
                        DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPANoTv(Me.DtDatosPresPA, 0, 0)
                    End If

                    If Me.MedioActual = Medios.Tv Then
                        DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCache(DtAvisosEnvioComprasCache)
                    Else
                        DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCacheNoTv(DtAvisosEnvioComprasCache)
                    End If

                    Dim Drs As DataRow
                    Dim DrsCache As DataRow
                    Dim Fila() As DataRow
                    Dim Drows As DataRow
                    Dim dtResult As New DataTable
                    Dim dtResult2 As New DataTable
                    Dim OEnvioCompras As New Envio_Compras
                    Dim Rowsa() As DataRow
                    Dim FilaNueva As DataRow
                    Dim o As Integer

                    'AG 08/08/2013 =======================================================
                    'Controla los existentes y nuevos PA seleccionados obtenidos de la pantalla de seleccion 
                    If Not DtControlEnvioFinal Is Nothing Then
                        If DtControlEnvioFinal.Rows.Count > 0 Then
                            DtControlEnvioFinal = QuitarMesNOSeleccionadoPA(DtControlEnvioFinal) 'AG 20/08/2013 

                            'AG 02/09/2013 ====================================
                            If CheckPresupuestoControlPA() = True Then
                                MsgBox("No se puede seleccionar mas de un mes, para " & vbCrLf & "el proceso de Pago Anticipado.")
                                cmdAnterior.Enabled = True
                                cmdCerrar.Enabled = True
                                Exit Sub
                            End If
                            '==================================================

                            Dim Rowss() As DataRow
                            For Each R As DataRow In DtControlEnvioFinal.Rows
                                Rowss = DtSoportesPautaTotalesCache.Select("PresupuestoPC = " & CInt(R("PresupuestoPC")) & " AND mes = " & R("mes") & " AND Anio = " & CInt(R("anio")))
                                If Rowss.Length > 0 Then
                                    R("SaldoPCEnvio") = Rowss(0)("TotalSoporteEnvio")
                                End If
                            Next

                            If Not DtControlEnvioFinal Is Nothing Then
                                If DtControlEnvioFinal.Rows.Count > 0 Then
                                    DtControlEnvioFinal = RecorrerDtFinalAutorizarEnvios(DtControlEnvioFinal)
                                    '==============================================================================================================
                                    For Each Dr In DtControlEnvioFinal.Rows
                                        If Dr("Autorizado") = False Then
                                            Mensaje += Dr("PresupuestoPA").ToString + " - "
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    Else
                        DtRegistrosPAYaEnviados = OEnvioCompras.ObtenerYaEnviados(CInt(Activo.CodCampaniaActualMms), _id_campania_mms, _id_subcampania_mms, Activo.IDMedio)
                        DtRegistrosPAYaEnviadosNuevo = DtRegistrosPAYaEnviados.Clone

                        'AG 20/08/2013 =================================================================================

                        If Me.MedioActual = Medios.Tv Then
                            DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPA(Me.dtFiltrosEnvioSpots, 0, 0)
                        Else
                            DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPANoTv(Me.DtDatosPresPA, 0, 0)
                        End If

                        If Me.MedioActual = Medios.Tv Then
                            DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCache(DtAvisosEnvioComprasCache)
                        Else
                            DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCacheNoTv(DtAvisosEnvioComprasCache)
                        End If

                        '===============================================================================================

                        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
                            If RowPresupuesto.Cells("Sel").Value = True Then
                                If DtSoportesPautaTotalesCache.Rows.Count > 0 Then
                                    Fila = DtRegistrosPAYaEnviados.Select("codCompania=" & CInt(Activo.CodCampaniaActualMms) & " AND codCampana = " & _id_campania_mms & " AND codSubCampana = " & _id_subcampania_mms & " AND anio = " & CInt(RowPresupuesto.Cells("Ano").Value) & " AND mes = " & CInt(RowPresupuesto.Cells("Mes").Value))
                                    If Fila.Length > 0 Then
                                        For o = 0 To Fila.Length - 1
                                            FilaNueva = DtRegistrosPAYaEnviadosNuevo.NewRow
                                            FilaNueva("codCompania") = Fila(o)("codCompania")
                                            FilaNueva("codCampana") = Fila(o)("codCampana")
                                            FilaNueva("codSubCampana") = Fila(o)("codSubCampana")
                                            FilaNueva("anio") = Fila(o)("anio")
                                            FilaNueva("mes") = Fila(o)("mes")
                                            FilaNueva("PresupuestoPC") = Fila(o)("PresupuestoPC")
                                            FilaNueva("PresupuestoPA") = Fila(o)("PresupuestoPA")
                                            FilaNueva("codsoporte") = Fila(o)("codsoporte")
                                            DtRegistrosPAYaEnviadosNuevo.Rows.Add(FilaNueva)
                                        Next
                                    End If
                                End If
                            End If
                        Next

                        If DtSoportesPautaTotalesCache.Rows.Count > 0 And DtRegistrosPAYaEnviadosNuevo.Rows.Count > 0 Then
                            DtRegistrosPAYaEnviadosNuevo = QuitarMesNOSeleccionadoPA(DtRegistrosPAYaEnviadosNuevo)
                            For Each DrsCache In DtRegistrosPAYaEnviadosNuevo.Rows
                                Fila = DtSoportesPautaTotalesCache.Select("anio=" & DrsCache("anio") & " AND mes = " & DrsCache("mes") & " AND PresupuestoPC = " & DrsCache("PresupuestoPC") & " AND cod_soporte = " & DrsCache("codsoporte"))
                                If Fila.Length > 0 Then
                                    For o = 0 To Fila.Length - 1
                                        DrsCache("SaldoPCEnvio") = Fila(o)("TotalSoporteEnvio")
                                    Next
                                End If
                            Next
                        End If


                        If DtRegistrosPAYaEnviadosNuevo.Rows.Count > 0 Then
                            DtRegistrosPAYaEnviadosNuevo = QuitarMesNOSeleccionadoPA(DtRegistrosPAYaEnviadosNuevo)
                            For Each Drs In DtRegistrosPAYaEnviadosNuevo.Rows
                                dtResult = OEnvioCompras.ObtenerPresupuestoPASaldo(CInt(Activo.CodCampaniaActualMms), Activo.IDMedio, Activo.IDCliente, Drs("CODSOPORTE"), "01/01/1900", "01/01/1900", 0)
                                If dtResult.Rows.Count > 0 Then
                                    Rowsa = dtResult.Select("CODPRESUPUESTOPA=" & Drs("PRESUPUESTOPA"))
                                    If Rowsa.Length > 0 Then
                                        Drs("SALDOPAPERMITIDO") = Rowsa(0)("Saldo")
                                    End If
                                End If
                            Next
                        End If

                        '' AG 21/08/2013 nota debe ingresar a la funcion de control de aca abajo 
                        'AG 20/08/2013 ===========================================================
                        If Not DtRegistrosPAYaEnviadosNuevo Is Nothing Then
                            If DtRegistrosPAYaEnviadosNuevo.Rows.Count > 0 Then
                                DtRegistrosPAYaEnviadosNuevo = QuitarMesNOSeleccionadoPA(DtRegistrosPAYaEnviadosNuevo)
                                DtRegistrosPAYaEnviadosNuevo = RecorrerDtFinalAutorizarEnvios(DtRegistrosPAYaEnviadosNuevo)
                                DtRelacionPCPAFinal = DtRegistrosPAYaEnviadosNuevo

                                'AG 23/08/2013 ========================================================
                                DtSoportesPautaTotalesCache.Columns.Add("CodPresupuestoPa", GetType(Integer))
                                CargarPASeleccionado(DtSoportesPautaTotalesCache)
                                dtControl = DtSoportesPautaTotalesCache

                                dtControl = VerificarSoporteSeleccionado(dtControl, ListaSopPA)
                                '==============================================================================================================
                                For Each Dr In DtRegistrosPAYaEnviadosNuevo.Rows
                                    If Dr("Autorizado") = False Then
                                        Mensaje += Dr("PresupuestoPA").ToString + " - "
                                    End If
                                Next
                            End If
                        End If
                        '=====================================================================
                    End If
                End If
            End If
            'Termina el Control de envio PA =====================================================================

            'AG 22/08/2013 ======================================================
            'If Not DtControlEnvioFinal Is Nothing Then
            'If DtControlEnvioFinal.Rows.Count > 0 Then
            If Not DtRelacionPCPAFinal Is Nothing Then
                If DtRelacionPCPAFinal.Rows.Count > 0 Then
                    Dim DtTempSoportesPA As New DataTable
                    Dim OEnvioCompras As New Envio_Compras
                    Dim DtSoportesPAFinal As DataTable

                    'AG 02/09/2013 ====================================
                    If CheckPresupuestoControlPA() = True Then
                        MsgBox("No se puede seleccionar mas de un mes, para " & vbCrLf & "el proceso de Pago Anticipado.")
                        cmdAnterior.Enabled = True
                        cmdCerrar.Enabled = True
                        EliminarPCPAEverestTemporal()
                        Exit Sub
                    End If
                    '==================================================

                    DtSoportesPAFinal = ArmarEstructuraDtSoportePA()
                    For Each Dr In DtRelacionPCPAFinal.Rows
                        DtTempSoportesPA = OEnvioCompras.ObtenerSoportesPA(CInt(Dr("codCompania")), CInt(Dr("PresupuestoPA")))
                        DtSoportesPAFinal = CargarDtSoportePA(DtSoportesPAFinal, DtTempSoportesPA, CInt(Dr("PresupuestoPC")), CInt(Dr("PresupuestoPA")), CInt(Dr("mes")), CInt(Dr("anio")))
                    Next


                    If ValidarSoportesPAPermitidos(dtControl, DtSoportesPAFinal) = True Then
                        MessageBox.Show("Existen soportes, que no estan ingresados en el Presupuesto P.A " & vbCrLf & "seleccionados.", "Everest.", MessageBoxButtons.OK)
                        cmdAnterior.Enabled = True
                        cmdCerrar.Enabled = True
                        EliminarPCPAEverestTemporal()
                        Exit Sub
                    End If
                Else
                    'MessageBox.Show("No existen soportes, ingresados en el Presupuesto P.A ", "Everest.", MessageBoxButtons.OK)
                    'cmdAnterior.Enabled = True
                    'cmdCerrar.Enabled = True
                    EliminarPCPAEverestTemporal()
                    'Exit Sub
                End If
            Else
                'MessageBox.Show("No existen soportes, ingresados en el Presupuesto P.A ", "Everest.", MessageBoxButtons.OK)
                'cmdAnterior.Enabled = True
                'cmdCerrar.Enabled = True
                EliminarPCPAEverestTemporal()
                'Exit Sub
            End If
            '====================================================================

            If Mensaje <> "" Then
                MessageBox.Show("El envio no se realizara, debido a que estos PRESUPUESTOS P.A  " & vbCrLf & "                                No tienen Saldos Disponibles" & vbCrLf & vbCrLf & "Nro: " & Mensaje, "Everest.", MessageBoxButtons.OK)
                Mensaje = ""
                cmdSiguiente.Enabled = False
                cmdAnterior.Enabled = False
                cmdCerrar.Enabled = True
                Exit Sub
            End If
            '===============================================

            'Thread que se ocupa del envío a compras
            mpbEnvioCompras.Enabled = True
            mpbEnvioCompras.Properties.ShowTitle = True
            bgwEnvioCompras.RunWorkerAsync()
            'EnviarACompras2() 'DCAIME
        End If

        Me.chkSelAll.Visible = fraActual.Equals(0)


    End Sub

    Private Sub SiguienteOtrosMedios()
        If Not Me.ExistenDatos Then
            Mensajes.Mensaje("No Existen datos para ese filtro", TipoMensaje.Informacion)
            Exit Sub
        End If
        If fraActual < mFra.Length - 1 Then
            If fraActual = 0 Then

                If Me.iugEjercicios.ActiveRow Is Nothing Then
                    MessageBox.Show("Debe seleccionar un ejercicio.")
                    cmdSiguiente.Enabled = True
                    cmdAnterior.Enabled = False
                    Exit Sub
                End If

                'AG Internet ==========================================================
                If cboProducto.SelectedRow Is Nothing Then
                    MessageBox.Show("Debe seleccionar un producto.")
                    cmdSiguiente.Enabled = True
                    cmdAnterior.Enabled = False
                    Exit Sub
                End If
                '=====================================================================

                fraEncab.Enabled = False
            End If
            mFra(fraActual).Visible = False
            fraActual = fraActual + 1
            CargarActual()
            mFra(fraActual).Visible = True
            If fraActual = 2 Then
                cmdSiguiente.Text = "Enviar"
            End If
        Else
            'Me.Cursor = Cursors.WaitCursor
            Call ConfigurarPresuxMes(PresuxMes)
            ''Mensaje("mensaje 1", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
            cmdSiguiente.Enabled = False
            cmdAnterior.Enabled = False
            cmdCerrar.Enabled = False
            If Not CheckPresupuesto(PresuxMes) Then ' Cargo el array y chequeo
                Mensajes.Mensaje("No puede seleccionar 2 presupuestos que correspondan a un mismo mes", TipoMensaje.Informacion)
                Me.Cursor = Cursors.Default
                EliminarPCPAEverestTemporal()
                Exit Sub
            End If
            If Not CheckTipoPresupuesto() Then
                Mensajes.Mensaje("Debe seleccionar un tipo de presupuesto para el/los presupuesto/s seleccionado/s", TipoMensaje.Informacion)
                Me.Cursor = Cursors.Default
                EliminarPCPAEverestTemporal()
                Exit Sub
            End If
            'AG 21/08/2013 NUEVO CODIGO ======================================================================
            Dim Dr As DataRow
            Dim Mensajess As String = ""
            Dim Mensaje As String = ""

            ' estos if estaban comentados y hacia que en prensa no se envie si no es
            ' de pago anticipado  lo descomente gw
            If Not DtPresupuestosPCPACargadosCache Is Nothing Then
                If DtPresupuestosPCPACargadosCache.Rows.Count > 0 Then

                    If Me.MedioActual = Medios.Tv Then
                        DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPA(Me.dtFiltrosEnvioSpots, 0, 0)
                    Else
                        DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPANoTv(Me.DtDatosPresPA, 0, 0)
                    End If

                    If Me.MedioActual = Medios.Tv Then
                        DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCache(DtAvisosEnvioComprasCache)
                    Else
                        DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCacheNoTv(DtAvisosEnvioComprasCache)
                    End If

                    Dim Drs As DataRow
                    Dim DrsCache As DataRow
                    Dim Fila() As DataRow
                    Dim dtResult As New DataTable
                    Dim dtResult2 As New DataTable
                    Dim OEnvioCompras As New Envio_Compras
                    Dim Rowsa() As DataRow
                    Dim FilaNueva As DataRow
                    Dim o As Integer

                    'AG 08/08/2013 =======================================================
                    'Controla los existentes y nuevos PA seleccionados obtenidos de la pantalla de seleccion 
                    If Not DtControlEnvioFinal Is Nothing Then
                        If DtControlEnvioFinal.Rows.Count > 0 Then
                            DtControlEnvioFinal = QuitarMesNOSeleccionadoPA(DtControlEnvioFinal)
                            Dim Rowss() As DataRow
                            For Each R As DataRow In DtControlEnvioFinal.Rows
                                Rowss = DtSoportesPautaTotalesCache.Select("PresupuestoPC = " & CInt(R("PresupuestoPC")) & " AND mes = " & R("mes") & " AND Anio = " & CInt(R("anio")))
                                If Rowss.Length > 0 Then
                                    R("SaldoPCEnvio") = Rowss(0)("TotalSoporteEnvio")
                                End If
                            Next

                            If Not DtControlEnvioFinal Is Nothing Then
                                If DtControlEnvioFinal.Rows.Count > 0 Then
                                    DtControlEnvioFinal = RecorrerDtFinalAutorizarEnvios(DtControlEnvioFinal)
                                    For Each Dr In DtControlEnvioFinal.Rows
                                        If Dr("Autorizado") = False Then
                                            Mensaje += Dr("PresupuestoPA").ToString + " - "
                                        End If
                                    Next
                                End If
                            End If
                        End If

                    Else
                        'Obtengo todos los avisos ya enviados anteriormente y que estan relacionado
                        DtRegistrosPAYaEnviados = OEnvioCompras.ObtenerYaEnviados(CInt(Activo.CodCampaniaActualMms), _id_campania_mms, _id_subcampania_mms, Activo.IDMedio)
                        DtRegistrosPAYaEnviadosNuevo = DtRegistrosPAYaEnviados.Clone

                        'Obtengo si hay nuevos avisos que se agregaron a un presupuesto ya enviado anteriormente y asociado a un P.A
                        'CORRIJO PA EN ENVIO A COMPRAS SEGUN MEDIO.
                        If Me.MedioActual = Medios.Tv Then
                            DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPA(Me.dtFiltrosEnvioSpots, 0, 0)
                        Else
                            DtAvisosEnvioComprasCache = ObtenerAvisosFiltradosPANoTv(Me.DtDatosPresPA, 0, 0)
                        End If

                        'Obtengo el total invertido de esos nuevos avisos por soporte, mes, anio, etc
                        If Me.MedioActual = Medios.Tv Then
                            DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCache(DtAvisosEnvioComprasCache)
                        Else
                            DtSoportesPautaTotalesCache = CalcularTotalesXSoporteEnvioCacheNoTv(DtAvisosEnvioComprasCache)
                        End If

                        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
                            If RowPresupuesto.Cells("Sel").Value = True Then
                                If DtSoportesPautaTotalesCache.Rows.Count > 0 Then
                                    Fila = DtRegistrosPAYaEnviados.Select("codCompania=" & CInt(Activo.CodCampaniaActualMms) & " AND codCampana = " & _id_campania_mms & " AND codSubCampana = " & _id_subcampania_mms & " AND anio = " & CInt(RowPresupuesto.Cells("Ano").Value) & " AND mes = " & CInt(RowPresupuesto.Cells("Mes").Value))
                                    If Fila.Length > 0 Then
                                        For o = 0 To Fila.Length - 1
                                            FilaNueva = DtRegistrosPAYaEnviadosNuevo.NewRow
                                            FilaNueva("codCompania") = Fila(o)("codCompania")
                                            FilaNueva("codCampana") = Fila(o)("codCampana")
                                            FilaNueva("codSubCampana") = Fila(o)("codSubCampana")
                                            FilaNueva("anio") = Fila(o)("anio")
                                            FilaNueva("mes") = Fila(o)("mes")
                                            FilaNueva("PresupuestoPC") = Fila(o)("PresupuestoPC")
                                            FilaNueva("PresupuestoPA") = Fila(o)("PresupuestoPA")
                                            FilaNueva("codsoporte") = Fila(o)("codsoporte")
                                            DtRegistrosPAYaEnviadosNuevo.Rows.Add(FilaNueva)
                                        Next
                                    End If
                                End If
                            End If
                        Next

                        'Asigno al nuevo DtCache con los avisos, el valor del monto que se va a enviar
                        If DtSoportesPautaTotalesCache.Rows.Count > 0 And DtRegistrosPAYaEnviadosNuevo.Rows.Count > 0 Then
                            DtRegistrosPAYaEnviadosNuevo = QuitarMesNOSeleccionadoPA(DtRegistrosPAYaEnviadosNuevo)
                            For Each DrsCache In DtRegistrosPAYaEnviadosNuevo.Rows
                                Fila = DtSoportesPautaTotalesCache.Select("anio=" & DrsCache("anio") & " AND mes = " & DrsCache("mes") & " AND PresupuestoPC = " & DrsCache("PresupuestoPC") & " AND cod_soporte = " & DrsCache("codsoporte"))
                                If Fila.Length > 0 Then
                                    For o = 0 To Fila.Length - 1
                                        DrsCache("SaldoPCEnvio") = Fila(o)("TotalSoporteEnvio")
                                    Next
                                End If
                            Next
                        End If

                        'Obtengo el saldo disponible actualizado, para ese soporte cargado en un presupuesto P.A y que se encuentra ya asignado
                        If DtRegistrosPAYaEnviadosNuevo.Rows.Count > 0 Then
                            'Quito o elimino los registros basura que no pertenecen a la seleccion de mes en la grilla de envio a compras
                            DtRegistrosPAYaEnviadosNuevo = QuitarMesNOSeleccionadoPA(DtRegistrosPAYaEnviadosNuevo)
                            For Each Drs In DtRegistrosPAYaEnviadosNuevo.Rows
                                dtResult = OEnvioCompras.ObtenerPresupuestoPASaldo(CInt(Activo.CodCampaniaActualMms), Activo.IDMedio, Activo.IDCliente, Drs("CODSOPORTE"), "01/01/1900", "01/01/1900", 0)
                                If dtResult.Rows.Count > 0 Then
                                    Rowsa = dtResult.Select("CODPRESUPUESTOPA=" & Drs("PRESUPUESTOPA"))
                                    If Rowsa.Length > 0 Then
                                        Drs("SALDOPAPERMITIDO") = Rowsa(0)("Saldo")
                                    End If
                                End If
                            Next
                        End If


                        If Not DtRegistrosPAYaEnviadosNuevo Is Nothing Then
                            If DtRegistrosPAYaEnviadosNuevo.Rows.Count > 0 Then
                                DtRegistrosPAYaEnviadosNuevo = QuitarMesNOSeleccionadoPA(DtRegistrosPAYaEnviadosNuevo)
                                'Obtengo y Valido que el Monto a enviar, no sea mayor o supere al monto permitido dentro del P.A asociado
                                DtRegistrosPAYaEnviadosNuevo = RecorrerDtFinalAutorizarEnvios(DtRegistrosPAYaEnviadosNuevo)
                                DtRelacionPCPAFinal = DtRegistrosPAYaEnviadosNuevo
                                For Each Dr In DtRegistrosPAYaEnviadosNuevo.Rows
                                    If Dr("Autorizado") = False Then
                                        Mensaje += Dr("PresupuestoPA").ToString + " - "
                                    End If
                                Next
                            End If
                        End If


                        'oo
                        '' AG 21/08/2013 nota debe ingresar a la funcion de control de aca abajo 
                        'AG 20/08/2013 ===========================================================
                        If Not DtRegistrosPAYaEnviadosNuevo Is Nothing Then
                            If DtRegistrosPAYaEnviadosNuevo.Rows.Count > 0 Then
                                'AG 23/08/2013 ========================================================
                                DtSoportesPautaTotalesCache.Columns.Add("CodPresupuestoPa", GetType(Integer))
                                CargarPASeleccionado(DtSoportesPautaTotalesCache)
                                dtControl = DtSoportesPautaTotalesCache

                                dtControl = VerificarSoporteSeleccionado(dtControl, ListaSopPA)
                                '==============================================================================================================
                                For Each Dr In DtRegistrosPAYaEnviadosNuevo.Rows
                                    If Dr("Autorizado") = False Then
                                        Mensaje += Dr("PresupuestoPA").ToString + " - "
                                    End If
                                Next
                            End If
                        End If

                    End If
                    'End If
                    'End If
                    '=========================================== FIN ANTERIOR ===========================================


                    'AG 22/08/2013 ======================================================
                    'If Not DtControlEnvioFinal Is Nothing Then
                    'If DtControlEnvioFinal.Rows.Count > 0 Then
                    If Not DtRelacionPCPAFinal Is Nothing Then
                        If DtRelacionPCPAFinal.Rows.Count > 0 Then
                            Dim DtTempSoportesPA As New DataTable
                            Dim DtSoportesPAFinal As DataTable

                            'AG 02/09/2013 ====================================
                            If CheckPresupuestoControlPA() = True Then
                                MsgBox("No se puede seleccionar mas de un mes, para " & vbCrLf & "el proceso de Pago Anticipado.")
                                cmdAnterior.Enabled = True
                                cmdCerrar.Enabled = True
                                EliminarPCPAEverestTemporal()
                                Exit Sub
                            End If
                            '==================================================

                            DtSoportesPAFinal = ArmarEstructuraDtSoportePA()
                            For Each Dr In DtRelacionPCPAFinal.Rows
                                DtTempSoportesPA = OEnvioCompras.ObtenerSoportesPA(CInt(Dr("codCompania")), CInt(Dr("PresupuestoPA")))
                                DtSoportesPAFinal = CargarDtSoportePA(DtSoportesPAFinal, DtTempSoportesPA, CInt(Dr("PresupuestoPC")), CInt(Dr("PresupuestoPA")), CInt(Dr("mes")), CInt(Dr("anio")))
                            Next

                            If ValidarSoportesPAPermitidos(dtControl, DtSoportesPAFinal) = True Then
                                MessageBox.Show("Existen soportes, que no estan ingresados en el Presupuesto P.A " & vbCrLf & "seleccionados.", "Everest.", MessageBoxButtons.OK)
                                cmdAnterior.Enabled = True
                                cmdCerrar.Enabled = True
                                EliminarPCPAEverestTemporal()
                                Exit Sub
                            End If
                        Else ' comentado por gw
                            'MessageBox.how("No existen soportes, ingresados en el Presupuesto P.A ", "Everest.", MessageBoxButtons.OK)
                            'cmdAnterior.Enabled = True
                            'cmdCerrar.Enabled = True
                            EliminarPCPAEverestTemporal()
                            ' Exit Sub
                        End If
                    Else ' comentado por gw
                        'MessageBox.Show("No existen soportes, ingresados en el Presupuesto P.A ", "Everest.", MessageBoxButtons.OK)
                        'cmdAnterior.Enabled = True
                        'cmdCerrar.Enabled = True
                        EliminarPCPAEverestTemporal()
                        'Exit Sub
                    End If
                    '====================================================================
                    ' agregado el endif gw
                End If
                End If

                If Mensaje <> "" Then
                    MessageBox.Show("El envio no se realizara, debido a que estos PRESUPUESTOS P.A  " & vbCrLf & "                                No tienen Saldos Disponibles" & vbCrLf & vbCrLf & "Nro: " & Mensaje, "Everest.", MessageBoxButtons.OK)
                    Mensaje = ""
                    cmdSiguiente.Enabled = False
                    cmdAnterior.Enabled = False
                    cmdCerrar.Enabled = True
                    Exit Sub
                End If
                '===============================================

                'Thread que se ocupa del envío a compras
                mpbEnvioCompras.Enabled = True
                mpbEnvioCompras.Properties.ShowTitle = True
                bgwEnvioCompras.RunWorkerAsync()
                'EnviarACompras2() 'DCAIME
        End If

        Me.chkSelAll.Visible = fraActual.Equals(0)
    End Sub

    Private Sub Anterior()
        If fraActual > 0 Then
            mFra(fraActual).Visible = False
            LimpiarFraActual()
            fraActual = fraActual - 1
            mFra(fraActual).Visible = True
            If fraActual = 0 Then
                fraEncab.Enabled = True
            End If
        End If
        cmdSiguiente.Text = "Siguiente"
        Me.chkSelAll.Visible = fraActual.Equals(0)
    End Sub

    Private Sub CargarActual()
        Select Case fraActual
            Case 0 ' Filtros
                CargarMedios()
            Case 1 ' Campañas
                CargarCampanias()
            Case 2 ' Presupuestos
                CargarPresupuestos()
        End Select
    End Sub

    Private Sub CargarMedios()
        Dim Medios As New Soportes
        Dim dtMedios As DataTable = Medios.ObtenerMediosActivos
        If Not dtMedios Is Nothing AndAlso dtMedios.Rows.Count > 0 Then
            Listas.CargarCombo(Me.CboMedio, dtMedios, "Id_Medio", "descripcion")
            Listas.OcultarColumnas(CboMedio, "Id_Medio")
            Listas.OcultarHeader(CboMedio)
            CboMedio.Value = Activo.IDMedio 'Rows(ObtenerIndiceMedios(Activo.IDMedio)).Selected = True
        End If
    End Sub

    Private Function ObtenerIndiceMedios(ByVal Medio As Medios) As Integer
        Select Case Medio
            Case Medios.Tv
                Return 0
            Case Medios.Exterior
                Return 1
            Case Medios.Prensa
                Return 2
            Case Medios.Revista
                Return 3
            Case Medios.Radio
                Return 4
        End Select
    End Function

    Private Sub Limpiar()
        '  Me.cboTipoSoporte.DataSource = Nothing
        Me.cboProducto.DataSource = Nothing
        Me.cboMateriales.DataSource = Nothing
        Me.iugEjercicios.DataSource = Nothing
        cboSeccion.Items.Clear()
        cboConcepto.Items.Clear()
    End Sub

    Private Sub CargarFiltros()
        Dim TS As New Tipos_soporte
        Dim dtTS As DataTable
        TS.Id_medio = Envio.Id_Medio
        dtTS = TS.TraerTipoSoporte
        If Not dtTS Is Nothing AndAlso dtTS.Rows.Count > 0 Then
            Listas.CargarCombo(Me.cboTipoSoporte, dtTS, "Id_tipo_soporte", "descripcion")
            Listas.OcultarColumnas(cboTipoSoporte, "Id_Tipo_soporte", "id_medio")
            Listas.OcultarHeader(cboTipoSoporte)
        Else
            cboTipoSoporte.DataSource = Nothing
            cboTipoSoporte.Enabled = False
            cmdSiguiente.Enabled = False
        End If
    End Sub

    Private Sub CargarCampanias()
        Dim dt As DataTable
        Dim Id_Producto As Integer

        'Quitar estos harcodeos
        '"04/01/2010"
        '"10/01/2010"
        'Activo.IDCliente = 0
        '----------------------
        'Id_Producto = CInt(cboTipoSoporte.SelectedRow.Cells("Id_Tipo_soporte").Text)
        Id_Producto = CInt(cboProducto.SelectedRow.Cells("Id_producto").Text)
        dt = Envio.TraerCampanias(Activo.IDCompaniaMMS, Activo.IDCliente, Id_Producto, Me.dtpF_Desde.Value.ToString, Me.dtpF_Hasta.Value.ToString)

        Dim row() As Object = {-1, "Nueva", CStr(Today.Day) & "/" & CStr(Today.Month) & "/" & CStr(Today.Year)}
        dt.Rows.Add(row)
        iugCampanias.DataSource = dt
        SetearGrillaCampanias()

        'Quitar este codigo Harcodeado --------
        'Activo.IDCliente = 10
        '--------------------------------------

    End Sub

    Private Sub SetearGrillaCampanias()
        Dim i As Integer

        iugCampanias.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
        iugCampanias.DisplayLayout.MaxRowScrollRegions = 1
        With iugCampanias.DisplayLayout.Bands(0)
            For i = 0 To 2
                .Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
            ' Codigo
            .Columns(0).Header.Caption = "Código"
            .Columns(0).Width = 50
            .Columns(0).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            ' Desc Campaña
            .Columns(1).Header.Caption = "Descripción"
            .Columns(1).Width = 220
            .Columns(1).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            'AGuzzardi MMS Quito estas columnas que no se utilizan ------------------------
            ' Seguimiento
            '.Columns(2).Header.Caption = "T. Seguimiento"
            '.Columns(2).Width = 50
            '.Columns(2).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            '' t. Compra
            '.Columns(3).Header.Caption = "T. Compra"
            '.Columns(3).Width = 50
            '.Columns(3).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            '-------------------------------------------------------------------------------

            ' F Creacion
            .Columns(2).Header.Caption = "F. Creación"
            .Columns(2).Width = 70
            .Columns(2).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
        End With

        'Listas.CambiarTituloColumna(iugCampanias, "id_campania", "Codigo")
        'Listas.CambiarTituloColumna(iugCampanias, "DESCRIPCION", "Descripción")
        'Listas.CambiarTituloColumna(iugCampanias, "FCREACION", "F. Creación")

    End Sub

    Private Sub CargarPresupuestos()
        Dim dtAux, dtFiltro As DataTable
        Dim dt As New DataTable

        'AGuzzardi ----------------------------------------------------------------------------------
        Dim id_campania, id_subcampania As Integer
        Dim f_desde, f_hasta As DateTime
        Dim fe As Date
        Dim DiasenMes As Integer = 0

        _id_campania_mms = Me.iugSubCampanias.ActiveRow.Cells("id_campana").Value
        _id_subcampania_mms = Me.iugSubCampanias.ActiveRow.Cells("id_subcampana").Value

        fe = dtpF_Desde.Value  '' de donde sale esto? D_C
        Dim TipoSoporte As Integer = 0
        DiasenMes = DateTime.DaysInMonth(fe.Year, fe.Month)
        f_desde = DateTime.Parse("1/" & fe.Month.ToString & "/" & fe.Year.ToString)
        f_hasta = DateTime.Parse(DiasenMes.ToString & "/" & fe.Month.ToString & "/" & fe.Year.ToString())

        dt.BeginLoadData()
        dt = Envio.TraerPresupuestosMMS(Activo.IDCompaniaMMS, _id_campania_mms, _id_subcampania_mms, f_desde, dtpF_Hasta.Value) ''f_hasta)
        dtAux = dt.Clone()
        Dim newRow As DataRow
        If MedioActual = Medios.Internet Then
            For Each row As DataRow In dt.Rows
                TipoSoporte = Envio.ObtenerTipoSoporteByPresupuesto(Activo.IDCompaniaMMS, _id_campania_mms, _id_subcampania_mms, row("ID_PRESUPUESTO").ToString(), MedioActual)
                If TipoSoporte > 0 And TipoSoporte <> Me.cboTipoSoporte.SelectedRow.Cells("id_tipo_soporte").Value Then
                    'dtAux.ImportRow(row)
                    row.Delete()
                End If
            Next
        End If
        '--------------------------------------------------------------------------------------------
        dt.AcceptChanges()
        Dim EstaBloqueado As Boolean = False

        For Each row As DataRow In dt.Rows
            EstaBloqueado = Envio.ObtenerEstadoBloqueadoPresupuesto(Activo.IDCompaniaMMS, row("ID_PRESUPUESTO").ToString())
            If EstaBloqueado Then
                row.Delete()
            End If
        Next

        dt.AcceptChanges()
        dt.EndLoadData()
        'Codigo anterior ---------------
        'dt = Envio.TraerPresupuestos
        '-------------------------------

        Dim f As Date
        'CF 15-07-2014 Limitar creacion de presupuestos por fechas
        Dim fMinima As Date

        fMinima = Date.Now.AddDays(-(Activo.CantidadDiasBloqueoPresupuestoMms + Date.Now.Day - 1))

        f = fMinima 'dtpF_Desde.Value

        While Str(f.Year).Trim & Trim(Str(f.Month)).PadLeft(2, "0") <= Str(CDate(dtpF_Hasta.Value).Year).Trim & Trim(Str(CDate(dtpF_Hasta.Value).Month)).PadLeft(2, "0")
            'Codigo original ----------------------------------------------------------------
            'Dim row() As Object = {f.Month.ToString.PadLeft(2, "0"), f.Year.ToString, -1}
            '--------------------------------------------------------------------------------
            'AGuzzardi MMS ---------------------------------------------------------------------------
            Dim row() As Object = {f.Month.ToString.PadLeft(2, "0"), f.Year.ToString, -1}
            '-----------------------------------------------------------------------------------------

            dt.Rows.Add(row)
            f = f.AddMonths(1)
        End While
        dt.Columns.Add("SelTipoPresupuesto")
        dt.Columns.Add("NumeroOC", GetType(String))
        dt.Columns.Add("Sel", GetType(Boolean))
        dt.Columns.Add("Canje", GetType(Boolean))
        dt.Columns.Add("Cod. Canje", GetType(String))
        dt.Columns.Add("BuscarCanje")
        dt.Columns.Add("Avisos", GetType(Integer))

        'AG 12/07/2013 ============================================
        dt.Columns.Add("Cod_PresupuestoPA", GetType(String))
        dt.Columns.Add("SaldoPA", GetType(Double))
        dt.Columns.Add("Saldo", GetType(Double))
        dt.Columns.Add("SelPresupuestoPA")
        '==========================================================


        For Each row As DataRow In dt.Rows
            If Integer.Parse(row("ID_PRESUPUESTO")) > 0 Then
                row("SelTipoPresupuesto") = Envio.ObtenerTipoPresupuestoByPresupuesto(Activo.IDCompaniaMMS, _id_campania_mms, _id_subcampania_mms, row("ID_PRESUPUESTO").ToString(), MedioActual)
                row("NumeroOC") = Envio.ObtenerOCByPresupuesto(Activo.IDCompaniaMMS, _id_campania_mms, _id_subcampania_mms, row("ID_PRESUPUESTO").ToString(), MedioActual)
            Else
                row("SelTipoPresupuesto") = String.Empty
                row("NumeroOC") = String.Empty
            End If
            row("sel") = False
            row("Canje") = False
            If Not row("id_intercambio") Is DBNull.Value AndAlso row("id_intercambio").ToString <> String.Empty Then
                row("Cod. Canje") = row("id_intercambio")
            End If


            'AGuzzardi MMS CON:01 - Consultar este segmento de codigo ------------------------------
            Envio.Id_Presupuesto_Sigeme = row("id_presupuesto")
            If Envio.Id_Presupuesto_Sigeme > 0 Then
                'AGuzzardi se agrego esta linea --------
                row("Avisos") = 0
                '---------------------------------------

                'AGuzzardi Codigo original --------------------------
                'row("Avisos") = Envio.Cantidad_Ordenes_Enviados
                '----------------------------------------------------
            Else
                row("Avisos") = 0
            End If
            '----------------------------------------------------------------------------------------
        Next

        dtFiltro = dt.Clone
        For Each row As DataRow In dt.Select("Avisos < 900", "id_presupuesto desc")
            dtFiltro.ImportRow(row)
        Next

        'AG 17/07/2013 ========================================
        Dim OEnvioCompras As New Envio_Compras
        IdCampanaPCPA = iugSubCampanias.ActiveRow.Cells("id_campana").Value
        IdSubCampanaPCPA = iugSubCampanias.ActiveRow.Cells("id_subcampana").Value

        'AG 07/08/2013 ==============
        DtPresupuestosPCPACargados = OEnvioCompras.ObtenerPACargadosConcatenados(CInt(Activo.CodCampaniaActualMms), IdCampanaPCPA, IdSubCampanaPCPA, 0, 0, 0, 0, 0, MedioActual, 0)

        If DtPresupuestosPCPACargados.Rows.Count > 0 Then
            DtPresupuestosPCPACargadosCache = OEnvioCompras.ObtenerPACargadosConcatenados(CInt(Activo.CodCampaniaActualMms), IdCampanaPCPA, IdSubCampanaPCPA, 0, 0, 0, 0, 0, MedioActual, 1)

            Dim RowPAnticipado() As DataRow
            For Each rows As DataRow In dtFiltro.Rows
                RowPAnticipado = DtPresupuestosPCPACargados.Select("COD_PRESUPUESTO_PC =" & rows("ID_PRESUPUESTO"))
                If RowPAnticipado.Length > 0 Then
                    rows("cod_presupuestoPA") = RowPAnticipado(0)("COD_PRESUPUESTO_PA").ToString
                End If
            Next

            TraerSpotsPA()

        End If
        '======================================================

        iugPresupuestos.DataSource = dtFiltro

        SetearGrillaPrespuestos()

        Dim i As Integer

        While i < iugPresupuestos.Rows.Count
            If iugPresupuestos.Rows(i).Cells("id_presupuesto").Value > 0 Then
                iugPresupuestos.Rows(i).Cells("SelTipoPresupuesto").Activation = Activation.NoEdit
            End If
            i = i + 1
        End While
    End Sub

    Private Sub SetearGrillaPrespuestos()
        Dim i As Integer

        iugPresupuestos.DisplayLayout.Override.CellClickAction = CellClickAction.EditAndSelectText
        iugPresupuestos.DisplayLayout.MaxRowScrollRegions = 1
        With iugPresupuestos.DisplayLayout.Bands(0)
            For i = 0 To 2
                .Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
            ' Codigo
            .Columns(0).Header.Caption = "Mes"
            .Columns(0).Width = 100
            .Columns(0).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            ' Desc Campaña
            .Columns(1).Header.Caption = "Año"
            .Columns(1).Width = 100
            .Columns(1).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            ' Seguimiento
            .Columns(2).Header.Caption = "Presupuesto"
            .Columns(2).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            .Columns("SelTipoPresupuesto").Header.Caption = "Tipo Presupuesto"
            .Columns("SelTipoPresupuesto").CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns("SelTipoPresupuesto").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("SelTipoPresupuesto").Style = ColumnStyle.DropDownList
            '.Columns("SelTipoPresupuesto").CellActivation = Activation.NoEdit 'Activation.Disabled

            .Columns("Cod. Canje").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("BuscarCanje").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("BuscarCanje").Style = ColumnStyle.Button
            .Columns("BuscarCanje").Header.Caption = String.Empty
            .Columns("BuscarCanje").Width = 10


            'AG 15/07/2013 =====================================
            .Columns("Cod_PresupuestoPA").Header.Caption = "Presupuesto P.A"
            .Columns("Cod_PresupuestoPA").CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            .Columns("SelPresupuestoPA").Header.Caption = "Sel.P.A"
            .Columns("SelPresupuestoPA").CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns("SelPresupuestoPA").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("SelPresupuestoPA").Style = ColumnStyle.Button
            .Columns("SaldoPA").Hidden = True
            .Columns("Saldo").Hidden = True

            GrillaFormato.HabilitarEdicionColumna(Me.iugPresupuestos, Activation.NoEdit, "Cod_PresupuestoPA", "SaldoPA")
            '===================================================

            .Columns("Avisos").Hidden = True
            .Columns("id_intercambio").Hidden = True
            .Columns("id_campana").Hidden = True
            .Columns("id_subcampana").Hidden = True



        End With
        iugPresupuestos.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn
    End Sub

    Private Sub LimpiarFraActual()
        Select Case fraActual
            Case 0 ' filtros
                LimpiarFiltros()
            Case 1 ' campañas
                LimpiarCampanias()
            Case 2 ' Presupuestos
                LimpiarPresupuestos()
        End Select
    End Sub

    Private Sub LimpiarFiltros()
        ' cboTipoSoporte.DataSource = Nothing
        cboTarget.DataSource = Nothing
        cboProducto.DataSource = Nothing
        iugEjercicios.DataSource = Nothing
        iugTemasxSop.DataSource = Nothing
    End Sub

    Private Sub LimpiarCampanias()
        iugCampanias.DataSource = Nothing
        iugSubCampanias.DataSource = Nothing
    End Sub

    Private Sub LimpiarPresupuestos()
        iugPresupuestos.DataSource = Nothing
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click

        Dim OEnvio_compras As New Envio_Compras

        OEnvio_compras.EliminarTempPAUsuario(Int(Activo.CodCampaniaActualMms), _id_campania_mms, CInt(Activo.CodUsuarioMms))

        Me.Close()
    End Sub

    Private Sub cmdSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiguiente.Click

        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = True
        Siguiente()
    End Sub

    Private Function ExistenDatos() As Boolean
        Dim ListaSop As String = Me.ConcatenarSoportes
        Envio.ListaSoportes = ListaSop
        Select Case MedioActual
            Case Medios.Prensa, Medios.Revista
                If cboSeccion.SelectedItem Is Nothing Or cboSeccion.SelectedIndex = 0 Then
                    Envio.id_Seccion = -1
                Else
                    Envio.id_Seccion = DirectCast(cboSeccion.SelectedItem, ItemLista).ID
                End If
                If cboConcepto.SelectedItem Is Nothing Or cboConcepto.SelectedIndex = 0 Then
                    Envio.Concepto = ""
                Else
                    Envio.Concepto = DirectCast(cboConcepto.SelectedItem, ItemLista).ID
                End If
                Envio.Id_Material = cboMateriales.SelectedRow.Cells(1).Value
                If Envio.ObtenerSpotsPrensa.Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            Case Medios.Exterior, Medios.Produccion 'AG Produccion ++++++++++++++++++++++++++++++
                If cboSeccion.SelectedItem Is Nothing Or cboSeccion.SelectedIndex = 0 Then
                    Envio.id_Provincia = -1
                Else
                    Envio.id_Provincia = Convert.ToInt32(cboSeccion.SelectedValue.ToString) ''DirectCast(cboSeccion.SelectedItem, ItemLista).ID
                End If
                Return True
                'If Envio.ObtenerSpotsExterior.Rows.Count = 0 Then
                '    Return False
                'Else
                '    Return True
                'End If
            Case Else
                Return True
        End Select
    End Function

    Private Sub cmdAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnterior.Click
        Anterior()
        cmdAnterior.Enabled = (fraActual <> 0)
        cmdSiguiente.Enabled = True
    End Sub

    Private Sub CargarEnvio(ByVal Medio As Medios)
        MedioActual = Medio
        Select Case Medio
            Case Medios.Tv, Medios.Radio
                EnviarTvRadio()
            Case Medios.Exterior, Medios.Prensa, Medios.Revista, Medios.Produccion, Medios.Internet 'AG Produccion +++++
                EnviarOtrosMedios(Medio)
        End Select
    End Sub

    Private Sub EnviarTvRadio()


        mSeEnvio = False
        mFra(0) = FraFiltros
        mFra(1) = fraCompras
        mFra(2) = fraPresupuestos
        fraActual = 0
        cmdAnterior.Enabled = False

        mFra(1).Left = mFra(0).Left
        mFra(1).Top = mFra(0).Top
        mFra(2).Left = mFra(0).Left
        mFra(2).Top = mFra(0).Top

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim Campania As New Campaña

        Campania.ID_Campania = mId_Campania
        Campania.BuscarPorID()

        txtDescripcion.Text = Mid(Campania.Descripcion, 1, 40)
        dtpF_Desde.Value = Campania.F_inicio
        dtpF_Hasta.Value = Campania.F_fin


        Envio.Id_Cliente = Activo.IDCliente
        Envio.Id_Grupo_Usuario = Activo.IDPerfil_Datos
        Envio.Id_Campania = mId_Campania
        Envio.Desc_Campania = Campania.Descripcion
        Envio.Desc_SubCampania = Campania.Descripcion
        Envio.Usuario = Activo.Login
        Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
        Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
        CargarActual()
    End Sub

    Private Sub EnviarOtrosMedios(ByVal Medio As Medios)

        Select Case Medio
            Case Medios.Revista, Medios.Prensa, Medios.Exterior, Medios.Produccion, Medios.Internet
                mSeEnvio = False
                mFra(0) = FraFiltros
                mFra(1) = fraCompras
                mFra(2) = fraPresupuestos
                fraActual = 0
                cmdAnterior.Enabled = False

                mFra(1).Left = mFra(0).Left
                mFra(1).Top = mFra(0).Top
                mFra(2).Left = mFra(0).Left
                mFra(2).Top = mFra(0).Top

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim Campania As New Campaña

                Campania.ID_Campania = mId_Campania
                Campania.BuscarPorID()

                txtDescripcion.Text = Mid(Campania.Descripcion, 1, 40)
                dtpF_Desde.Value = Campania.F_inicio
                dtpF_Hasta.Value = Campania.F_fin


                Envio.Id_Cliente = Activo.IDCliente
                Envio.Id_Grupo_Usuario = Activo.IDPerfil_Datos
                Envio.Id_Campania = mId_Campania
                Envio.Desc_Campania = Campania.Descripcion
                Envio.Desc_SubCampania = Campania.Descripcion
                Envio.Usuario = Activo.Login
                Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
                Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
                CargarActual()


        End Select


    End Sub

    Private Sub frmEnviarCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mpbEnvioCompras.Enabled = False
        CargarEnvio(Activo.IDMedio)
        chkSelAll.Visible = False
    End Sub

    Private Sub CargarTargets()
        Dim dt As DataTable

        'Me.Cursor = Cursors.WaitCursor
        If Not cboTipoSoporte.Value Is Nothing Then
            Envio.Id_Tipo_Soporte = cboTipoSoporte.Value
            dt = Envio.TraerTargets
            If dt.Rows.Count <> 0 Then
                Listas.CargarCombo(Me.cboTarget, dt, "Id_Target_1", "descripcion")
                Listas.OcultarColumnas(Me.cboTarget, "Id_Target_1")
                Listas.OcultarHeader(Me.cboTarget)
            Else
                Mensajes.Mensaje("No hay ejercicios finales en esta campaña para este tipo de soporte", TipoMensaje.Informacion)
                iugTemasxSop.DataSource = Nothing
                iugEjercicios.DataSource = Nothing
                cboProducto.DataSource = Nothing
                cboTarget.DataSource = Nothing
                If Not Ultra Is Nothing Then
                    Ultra.Rows.Clear()
                End If
            End If
            iugEjercicios.DataSource = Nothing
            iugTemasxSop.DataSource = Nothing
            cmdSiguiente.Enabled = SiguienteHabilitado()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cboTipoSoporte_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoSoporte.ValueChanged
        If cboTipoSoporte.SelectedRow Is Nothing Then
            Exit Sub
        End If
        Select Case CInt(CboMedio.SelectedRow.Cells("Id_medio").Text)
            Case Medios.Tv, Medios.Radio
                CargarTargets()
            Case Medios.Exterior, Medios.Revista, Medios.Prensa, Medios.Produccion 'AG Produccion +++++++++++++
                Dim oSpot As Object
                Dim dt As DataTable
                Dim ec As New Envio_Compras
                Limpiar()
                If MedioActual = Medios.Exterior Then
                    oSpot = New Spots_vp
                Else
                    oSpot = New Spots_pr
                End If

                ''dt = oSpot.ObtenerProductos(Activo.IDCampaña, CboMedio.SelectedRow.Cells("Id_medio").Text, cboTipoSoporte.SelectedRow.Cells("Id_Tipo_soporte").Text, Activo.IDCliente)
                dt = _maestro.ProductosTraerTodos(Activo.CodPaisMms, Activo.IDCliente)
                dt = dt.Select("", "DESCRIPCION2 ASC").CopyToDataTable()

                Listas.CargarCombo(cboProducto, dt, "Id_Producto", "descripcion2", False)
                ec.Id_Campania = Activo.IDCampaña
                ec.Id_Medio = CboMedio.SelectedRow.Cells("Id_medio").Text
                ec.Id_Tipo_Soporte = cboTipoSoporte.SelectedRow.Cells("Id_Tipo_soporte").Text
                dt = ec.TraerTargets

                Listas.CargarCombo(Me.cboTarget, dt, "Id_Target_1", "descripcion")
                Listas.OcultarColumnas(Me.cboTarget, "Id_Target_1")
                Listas.OcultarHeader(Me.cboTarget)


                Listas.OcultarColumnas(Me.cboProducto, "Id_Producto", "Id_Cliente", "descripcion", "fechafin")
                Listas.OcultarHeader(Me.cboProducto)

            Case Medios.Internet 'AG Internet
                Dim ec As New Envio_Compras
                Dim dtInternet As DataTable
                Dim DtProducto As DataTable
                'Limpiar()

                DtProducto = _maestro.ProductosTraerTodos(Activo.CodPaisMms, Activo.IDCliente)
                Listas.CargarCombo(cboProducto, DtProducto, "Id_Producto", "descripcion2", False)
                Listas.OcultarColumnas(Me.cboProducto, "Id_Producto", "Id_Cliente", "descripcion", "fechafin")
                Listas.OcultarHeader(Me.cboProducto)

                If Not cboTipoSoporte.Value Is Nothing Then
                    lstSoportes.Items.Clear()
                    ec.Id_Campania = Activo.IDCampaña
                    ec.Id_Medio = CboMedio.SelectedRow.Cells("Id_medio").Text
                    ec.Id_Tipo_Soporte = cboTipoSoporte.SelectedRow.Cells("Id_Tipo_soporte").Text

                    Envio.Id_Tipo_Soporte = cboTipoSoporte.SelectedRow.Cells("Id_Tipo_soporte").Text
                    Envio.Id_Campania = mId_Campania
                    Envio.Id_Medio = Activo.Medios.Internet
                    Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
                    Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString

                    dtInternet = Envio.TraerSistemasEjerciciosInternet
                    If dtInternet.Rows.Count <> 0 Then
                        iugEjercicios.DataSource = dtInternet
                        Listas.CambiarTituloColumna(iugEjercicios, "F_INICIO", "Fecha Inicio")
                        Listas.CambiarTituloColumna(iugEjercicios, "F_FIN", "Fecha Fin")
                        cmdSiguiente.Enabled = True
                    Else
                        Me.iugEjercicios.DataSource = Nothing
                        iugEjercicios.DataSource = dtInternet
                        Mensajes.Mensaje("No hay Ejercicios para este filtro", TipoMensaje.Informacion)
                        cmdSiguiente.Enabled = False
                        If TodosLosCamposOk() Then
                            Mensajes.Mensaje("No hay Ejercicios para este filtro", TipoMensaje.Informacion)
                            iugEjercicios.DataSource = Nothing
                            iugTemasxSop.DataSource = Nothing
                            If Not Ultra Is Nothing Then
                                Ultra.Rows.Clear()
                            End If
                        End If
                    End If
                    'cmdSiguiente.Enabled = SiguienteHabilitado()
                End If
                Me.Cursor = Cursors.Default
        End Select
    End Sub

    Private Sub cboTarget_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTarget.ValueChanged

    End Sub

    'Procedimiento nuevo que se encarga de cargar los datos del envio para el filtro. (AN 07-09-2015)
    Private Sub CargarEnvioDatos()
        Envio.Id_Target = cboTarget.Value
        Envio.Id_Tipo_Soporte = cboTipoSoporte.SelectedRow.Cells("Id_Tipo_soporte").Text
        Envio.Id_Campania = mId_Campania
        Envio.Id_Medio = CboMedio.SelectedRow.Cells("Id_medio").Text
        Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
        Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
    End Sub

    Private Sub cboProducto_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProducto.ValueChanged
        Dim dt As DataTable
        If MedioActual = Medios.Tv Or MedioActual = Medios.Radio Then

            'AN 07-09-2015
            Call CargarEnvioDatos()

            Me.Cursor = Cursors.WaitCursor
            If Not cboProducto.Value Is Nothing Then
                Envio.Id_Producto = cboProducto.Value
                If MedioActual = Medios.Radio Or MedioActual = Medios.Tv Then
                    dt = Envio.TraerSistemasEjercicios
                Else
                    dt = Envio.TraerSistemasEjerciciosMedios
                End If

                If dt.Rows.Count <> 0 Then
                    iugEjercicios.DataSource = dt
                Else
                    If TodosLosCamposOk() Then
                        Mensajes.Mensaje("No hay Ejercicios para este filtro", TipoMensaje.Informacion)
                        iugEjercicios.DataSource = Nothing
                        iugTemasxSop.DataSource = Nothing
                        If Not Ultra Is Nothing Then
                            Ultra.Rows.Clear()
                        End If
                    End If
                End If
                cmdSiguiente.Enabled = SiguienteHabilitado()
            End If

            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        'Dim dt As New DataTable
        Dim oSpot As Object

        If MedioActual = Medios.Revista Or MedioActual = Medios.Prensa Then
            oSpot = New Spots_pr
        Else
            oSpot = New Spots_vp
        End If
        If Not cboProducto.SelectedRow Is Nothing Then
            Dim filtro As String = "id_producto=" & cboProducto.SelectedRow.Cells("Id_producto").Text
            ''dt = Listas.FiltrarDT(oSpot.ObtenerMateriales(Activo.IDCampaña, CboMedio.SelectedRow.Cells("Id_medio").Text, cboTipoSoporte.SelectedRow.Cells("Id_Tipo_soporte").Text), filtro)
            ''dt = _maestro.MaterialesTraerTodos(Activo.CodPaisMms, Activo.IDCliente, cboProducto.SelectedRow.Cells("Id_producto").Text)
            dt = _maestro.MaterialesTraerMedio(Activo.CodPaisMms, Activo.IDCliente, cboProducto.SelectedRow.Cells("Id_producto").Text, Activo.IDMedio)
            Listas.CargarCombo(cboMateriales, dt, "Id_Material", "Descripcion", True, "Ninguno")
            Listas.OcultarColumnas(Me.cboMateriales, "id_Material")
            Listas.OcultarColumnas(Me.cboMateriales, "id_producto")
            Listas.OcultarColumnas(Me.cboMateriales, "id_pais")
            Listas.OcultarColumnas(Me.cboMateriales, "id_cliente")
            Listas.OcultarColumnas(Me.cboMateriales, "duracion")
            Listas.OcultarColumnas(Me.cboMateriales, "id_medio")
            Listas.OcultarHeader(Me.cboMateriales)
            If cboMateriales.Rows.Count > 0 Then
                cboMateriales.Rows(0).Selected = True
                cboMateriales.Rows(0).Activated = True

            End If
        End If
    End Sub

    Private Sub dtpF_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpF_Desde.ValueChanged
        Dim dt As DataTable

        Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
        Select Case MedioActual
            Case Medios.Radio, Medios.Tv
                dt = Envio.TraerSistemasEjercicios
            Case Medios.Revista, Medios.Prensa
                dt = Envio.TraerSistemasEjerciciosMedios
            Case Medios.Exterior
                dt = Envio.TraerSistemasEjerciciosExterior
                'AG Produccion ++++++++++++++++++++++++++
            Case Medios.Produccion
                dt = Envio.TraerSistemasEjerciciosProduccion
                '++++++++++++++++++++++++++++++++++++
            Case Medios.Internet 'AG Internet
                dt = Envio.TraerSistemasEjerciciosInternet
        End Select
        If dt.Rows.Count <> 0 Then
            iugEjercicios.DataSource = dt
        Else
            If TodosLosCamposOk() Then
                iugEjercicios.DataSource = Nothing
                iugTemasxSop.DataSource = Nothing
            End If
        End If
        cmdSiguiente.Enabled = SiguienteHabilitado()
    End Sub

    Private Sub dtpF_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpF_Hasta.ValueChanged
        Dim dt As DataTable

        Envio.Fecha_Hasta = dtpF_Hasta.Value
        Select Case MedioActual
            Case Medios.Radio, Medios.Tv
                dt = Envio.TraerSistemasEjercicios
            Case Medios.Revista, Medios.Prensa
                dt = Envio.TraerSistemasEjerciciosMedios
            Case Medios.Exterior
                dt = Envio.TraerSistemasEjerciciosExterior
                'AG Produccion ++++++++++++++++++++++++++
            Case Medios.Produccion
                dt = Envio.TraerSistemasEjerciciosProduccion
                '++++++++++++++++++++++++++++++++++++
            Case Medios.Internet 'AG Internet
                dt = Envio.TraerSistemasEjerciciosInternet

        End Select

        If dt.Rows.Count <> 0 Then
            iugEjercicios.DataSource = dt
        Else
            If TodosLosCamposOk() Then
                iugEjercicios.DataSource = Nothing
                iugTemasxSop.DataSource = Nothing
                'Ultra = Nothing
                Ultra.Rows.Clear()
            End If
        End If
        cmdSiguiente.Enabled = SiguienteHabilitado()
    End Sub

    Private Function SiguienteHabilitado() As Boolean
        Dim ret As Boolean
        Dim i As Integer
        Dim j As Integer
        Dim ChildR As UltraDataRowsCollection

        'Me.Cursor = Cursors.WaitCursor
        ret = False
        Select Case fraActual
            Case 0
                If Not Ultra Is Nothing Then
                    i = 0
                    While i < Ultra.Rows.Count And Not ret
                        ChildR = Ultra.Rows(i).GetChildRows("Soportes")
                        j = 0
                        While j < ChildR.Count And Not ret
                            ret = ChildR.Item(j).GetCellValue("Todos")
                            j = j + 1
                        End While
                        i = i + 1
                    End While
                End If
            Case 1
                ret = IIf(iugCampanias.ActiveRow Is Nothing, False, iugCampanias.ActiveRow.Selected)
                If iugSubCampanias.ActiveRow Is Nothing Then
                    ret = False
                Else
                    ret = ret And iugSubCampanias.ActiveRow.Selected
                End If
            Case 2
                ret = True 'AG 30/09/2013
        End Select

        SiguienteHabilitado = ret
        Me.Cursor = Cursors.Default
    End Function

    Private Function TodosLosCamposOk() As Boolean

        TodosLosCamposOk = (Not cboTipoSoporte.Value Is Nothing) And (Not cboTarget.Value Is Nothing) And (Not cboProducto.Value Is Nothing)

    End Function

    Private Sub iugEjercicios_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugEjercicios.CellChange

    End Sub

    Private Sub iugEjercicios_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugEjercicios.InitializeLayout
        Dim i As Integer

        iugEjercicios.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
        iugEjercicios.DisplayLayout.MaxRowScrollRegions = 1
        With iugEjercicios.DisplayLayout.Bands(0)
            For i = 0 To 5
                .Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
            ' id_sistema
            .Columns(0).Hidden = True
            ' Desc Sistema
            .Columns(1).Header.Caption = "Sistema"
            .Columns(1).Width = 150
            .Columns(1).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            ' Id_ejercicio
            .Columns(2).Hidden = True
            ' Desc Ejercicio
            .Columns(3).Header.Caption = "Ejercicio"
            .Columns(3).Width = 150
            .Columns(3).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            ' F desde
            .Columns(4).Width = 70
            .Columns(4).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            ' F Hasta
            .Columns(5).Width = 70
            .Columns(5).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
        End With
    End Sub

    Private Sub iugEjercicios_BeforeSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles iugEjercicios.BeforeSelectChange
        If iugEjercicios.ActiveRow Is Nothing Then
            Exit Sub
        End If

        Envio.Id_Sistema = iugEjercicios.ActiveRow.Cells("id_sistema").Value
        Envio.Id_Ejercicio = iugEjercicios.ActiveRow.Cells("id_ejercicio").Value
        Envio.Id_Soporte = -1
        Envio.id_Seccion = -1

        'Jsperk: Se setea la fecha de incio y de fin del Sistema para el uso en sub campañas en el caso de que no tenga.
        fInicioSis = iugEjercicios.ActiveRow.Cells("F_INICIO").Value
        fFinSis = iugEjercicios.ActiveRow.Cells("F_FIN").Value

        If cboMateriales.SelectedRow Is Nothing Then
            Envio.Id_Material = ""
        End If

        Select Case MedioActual
            Case Medios.Radio, Medios.Tv
                Envio.Id_Sistema = iugEjercicios.ActiveRow.Cells("id_sistema").Value
                Envio.Id_Ejercicio = iugEjercicios.ActiveRow.Cells("id_ejercicio").Value
                Envio.Id_Campania = Activo.IDCampaña
                Envio.Id_Producto = Me.cboProducto.Value
                DtTemasSoporte = Envio.TraerSoportesTemas
                CargarTemasxSoporte()
                cmdSiguiente.Enabled = SiguienteHabilitado()

                'AG 10/05/2011 +++++++++++++++++++++++++++++++++
                'control de Convenios +++++++++++++++++++++++++++++

                '++++++++++++++++++++++++++++++++++++++++++++
            Case Medios.Prensa, Medios.Revista
                If Not cboProducto.SelectedRow Is Nothing Then
                    Dim Spot As New Spots_pr
                    dsSop = Spot.ObtenerSoportesSeccionesConceptos(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, cboProducto.SelectedRow.Cells(1).Value, cboMateriales.SelectedRow.Cells(1).Value) 'Envio.Id_Material)
                    ''dtSop = _maestro.SoporteTraerbyMedio(Activo.CodPaisMms, Activo.IDMedio) Warning: Jsperk revisar.
                    'Listas.CargarCombo(Me.cboSoporte, dsSop.Tables(0), "Id_Soporte", "Soporte", True)

                    'Aguzzardi Anexar Soportes MMS -----------------------------------------------------------
                    Dim OGAdmin As New GrillAdmin
                    Listas.CargarList(Me.lstSoportes, OGAdmin.AnexarSoportesMMS(dsSop.Tables(0), -1, "Descripcion"), "Id_Soporte", "Descripcion")
                    '-----------------------------------------------------------------------------------------
                    'AGuzzardi Codigo Original -----------------------------------------------------
                    'Listas.CargarList(Me.lstSoportes, dsSop.Tables(0), "Id_Soporte", "Soporte")
                    '-------------------------------------------------------------------------------
                    If lstSoportes.Items.Count > 0 Then
                        For i As Int16 = 0 To lstSoportes.Items.Count - 1
                            lstSoportes.SetItemCheckState(i, CheckState.Checked)
                        Next
                        chkSelAll.Visible = True
                        chkSelAll.Checked = True
                        chkSelAll.Text = "Deseleccionar Todos"
                        SeleccionarSoportes()
                    Else
                        chkSelAll.Visible = False
                    End If
                    'cboSoporte.SelectedIndex = 0
                    cmdSiguiente.Enabled = True
                End If
            Case Medios.Exterior, Medios.Produccion 'AG Produccion +++++++++++++++++++++++++
                If Not cboProducto.SelectedRow Is Nothing Then
                    Dim Spot As New Spots_vp
                    dsSop = Spot.ObtenerSoportesProvincia(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, cboProducto.ActiveRow.Cells(1).Value, cboMateriales.SelectedRow.Cells(1).Value) '', Envio.Id_Material)
                    'Listas.CargarCombo(Me.cboSoporte, dsSop.Tables(0), "Id_Soporte", "Soporte", True)

                    'Aguzzardi Anexar Soportes MMS ---------------------------------------------------
                    Dim OGAdmin As New GrillAdmin
                    Listas.CargarList(Me.lstSoportes, OGAdmin.AnexarSoportesMMS(dsSop.Tables(0), -1, "Soporte", "", 1), "Id_Soporte", "Soporte")

                    'AGuzzardi Codigo Original -----------------------------------------------------
                    'Listas.CargarList(Me.lstSoportes, dsSop.Tables(0), "Id_Soporte", "Soporte")
                    '-------------------------------------------------------------------------------
                    'cboSoporte.SelectedIndex = 0
                    If lstSoportes.Items.Count > 0 Then
                        For i As Int16 = 0 To lstSoportes.Items.Count - 1
                            lstSoportes.SetItemCheckState(i, CheckState.Checked)
                        Next
                        chkSelAll.Visible = True
                        chkSelAll.Checked = True
                        chkSelAll.Text = "Deseleccionar Todos"
                        SeleccionarSoportes()
                    Else
                        chkSelAll.Visible = False
                    End If
                    cmdSiguiente.Enabled = True

                End If

            Case Medios.Internet 'AG Internet

                If Not Me.cboTipoSoporte.SelectedRow Is Nothing Then
                    Dim SpotInternet As New Spots_int
                    dsSop = SpotInternet.ObtenerSoportesInternet(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, cboTipoSoporte.Value)
                    Dim OGAdmin As New GrillAdmin

                    Listas.CargarList(Me.lstSoportes, OGAdmin.AnexarSoportesMMS(dsSop.Tables(0), -1, "Soporte", "", 1), "Id_Soporte", "Soporte")
                    If lstSoportes.Items.Count > 0 Then
                        For i As Int16 = 0 To lstSoportes.Items.Count - 1
                            lstSoportes.SetItemCheckState(i, CheckState.Checked)
                        Next
                        chkSelAll.Visible = True
                        chkSelAll.Checked = True
                        chkSelAll.Text = "Deseleccionar Todos"
                        SeleccionarSoportes()
                    Else
                        chkSelAll.Visible = False
                    End If
                    'cmdSiguiente.Enabled = True
                    cmdSiguiente.Enabled = True
                End If
        End Select
    End Sub

    Private Sub CargarTemasxSoporte()
        Dim i As Integer
        Dim childSoportes As UltraDataBand
        Dim childTemas As UltraDataBand
        Dim row As UltraDataRow
        Dim antId_Soporte As Integer
        Dim antId_Proveedor As Integer
        Dim Cant_Soportes As Integer
        Dim auxTema As DataRow()
        'Me.Cursor = Cursors.WaitCursor
        'dt.Columns.Add("Ok", GetType(Boolean), True)

        If Not DtTemasSoporte Is Nothing Then
            ' TABLA DE TEMAS FILTRADA PARA EVITAR DUPLICADOS (AN 10-11-2015)
            DtTemasSoporte.DefaultView.Sort = "des_proveedor asc, des_soporte asc"
            Dim dt As DataTable = DtTemasSoporte.DefaultView.ToTable(True, "ID_SOPORTE", "DESCRIPCION", "TEMA", "ID_MEDIO", "ID_PROVEEDOR", "DES_PROVEEDOR", "DES_SOPORTE")

            'Me.Cursor = Cursors.WaitCursor
            dt.Columns.Add("Ok", GetType(Boolean), True)

            Ultra = New UltraDataSource
            Ultra.Rows.Clear()
            Ultra.Band.ResetColumns()
            Ultra.Band.ResetChildBands()

            childSoportes = Me.Ultra.Band.ChildBands.Add("Soportes")
            childTemas = childSoportes.ChildBands.Add("Temas")

            Ultra.Band.Columns.Add("Id_Proveedor", GetType(String))
            Ultra.Band.Columns.Add("Proveedor", GetType(String))
            Ultra.Band.Columns.Add("Todos", GetType(Boolean))

            childSoportes.Columns.Add("Id_Soporte", GetType(String))
            childSoportes.Columns.Add("Soporte", GetType(String))
            childSoportes.Columns.Add("Todos", GetType(Boolean))

            childTemas.Columns.Add("Tema", GetType(String))
            childTemas.Columns.Add("Descripción", GetType(String))
            childTemas.Columns.Add("Mes", GetType(Integer))
            childTemas.Columns.Add("Anio", GetType(Integer))
            childTemas.Columns.Add("Ok", GetType(Boolean))

            Dim otema As Temas = New Temas
            Dim dtTema As DataTable
            ''de donde saco el id_campania?
            otema.Id_campania = Me.Id_Campania
            dtTema = otema.ObtenerTemasPorCampaña()

            i = 0
            Cant_Soportes = 0
            While i < dt.Rows.Count
                Me.Ultra.Rows.Add(True)
                row = Me.Ultra.Rows(Me.Ultra.Rows.Count - 1)
                row("id_Proveedor") = dt.Rows(i).Item("Id_proveedor")
                row("Proveedor") = dt.Rows(i).Item("Des_Proveedor")
                row("Todos") = True 'AG 11/01/2015

                antId_Proveedor = dt.Rows(i).Item("id_proveedor")
                While i < dt.Rows.Count AndAlso dt.Rows(i).Item("id_proveedor") = antId_Proveedor
                    Dim childSoportesRows As UltraDataRowsCollection = row.GetChildRows("Soportes")
                    childSoportesRows.Add(True)
                    childSoportesRows.Item(childSoportesRows.Count - 1).SetCellValue("Id_Soporte", dt.Rows(i).Item("id_soporte"))
                    childSoportesRows.Item(childSoportesRows.Count - 1).SetCellValue("Soporte", dt.Rows(i).Item("des_soporte"))
                    childSoportesRows.Item(childSoportesRows.Count - 1).SetCellValue("Todos", True)

                    antId_Soporte = dt.Rows(i).Item("id_soporte")
                    While i < dt.Rows.Count AndAlso dt.Rows(i).Item("id_soporte") = antId_Soporte
                        Dim childRows As UltraDataRowsCollection = childSoportesRows.Item(childSoportesRows.Count - 1).GetChildRows("Temas")
                        childRows.Add(False).SetCellValue("Tema", dt.Rows(i).Item("tema"))
                        auxTema = dtTema.Select("ID_TEMA = '" & dt.Rows(i).Item("tema") & "'")
                        If auxTema.Length = 1 Then
                            childRows.Item(childRows.Count - 1).SetCellValue("Descripción", auxTema(0).Item("tema"))
                        End If
                        childRows.Item(childRows.Count - 1).SetCellValue("Ok", True)
                        i = i + 1
                    End While
                End While
                Cant_Soportes = Cant_Soportes + 1
            End While
            pgbSoportes.Maximum = Cant_Soportes

            iugTemasxSop.DataSource = Ultra
            SetearGrilla()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetearGrilla()
        Dim i As Integer
        Dim j As Integer

        For i = 0 To iugTemasxSop.DisplayLayout.Bands(0).Columns.Count - 1
            iugTemasxSop.DisplayLayout.Bands(0).Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            For j = 0 To iugTemasxSop.DisplayLayout.Bands(1).Columns.Count - 2
                iugTemasxSop.DisplayLayout.Bands(1).Columns(j).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
        Next

        ''//FIJAMOS EL ANCHO DE LAS COLUMNAS DE LA BANDA DE SOPORTES
        iugTemasxSop.DisplayLayout.Bands(0).Columns("Proveedor").Width = 400
        iugTemasxSop.DisplayLayout.Bands(0).Columns("Todos").Width = 10

        ''//FIJAMOS EL ANCHO DE LAS COLUMNAS DE LA BANDA DE TEMAS
        iugTemasxSop.DisplayLayout.Bands(1).Columns("Id_Soporte").Width = 50
        iugTemasxSop.DisplayLayout.Bands(1).Columns("Soporte").Width = 400

        'NUEVO DESARROLLO ENVIO COMPRA LIGERO (AN - 01/09/2015)
        iugTemasxSop.DisplayLayout.Bands(2).Columns("Mes").Hidden = True
        iugTemasxSop.DisplayLayout.Bands(2).Columns("Anio").Hidden = True

        iugTemasxSop.DisplayLayout.Bands(0).Columns("Todos").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        iugTemasxSop.DisplayLayout.Bands(1).Columns("Todos").CellActivation = Activation.AllowEdit

        'OCULTO COLUMNAS DE ID
        iugTemasxSop.DisplayLayout.Bands(0).Columns(0).Hidden = True
        iugTemasxSop.DisplayLayout.Bands(0).Columns(1).ColSpan = 2
        iugTemasxSop.DisplayLayout.Bands(1).Columns(0).Hidden = True
        iugTemasxSop.DisplayLayout.Bands(1).Columns(1).ColSpan = 2

    End Sub

    Private Sub SetearGrillaSubCampania()
        Dim i As Integer

        iugSubCampanias.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
        iugSubCampanias.DisplayLayout.MaxRowScrollRegions = 1
        With iugSubCampanias.DisplayLayout.Bands(0)
            For i = 0 To 3
                .Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
            ' Codigo
            .Columns(0).Header.Caption = "Código"
            .Columns(0).Width = 50
            .Columns(0).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            ' Desc Campaña
            .Columns(1).Header.Caption = "Descripción"
            .Columns(1).Width = 320
            .Columns(1).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

            'AGuzzardi MMS Quito estas columnas que no se utilizan ------------------------
            'Seguimiento()
            .Columns(2).Header.Caption = "CodCampania" '"F. Inicio"
            .Columns(2).Width = 0
            .Columns(2).Hidden = True
            .Columns(2).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            '------------------------------------------------------------------------------

            .Columns(3).Header.Caption = "F. Inicio"
            .Columns(3).Width = 70
            .Columns(3).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke


        End With
        iugSubCampanias.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn
    End Sub

    Private Sub iugCampanias_BeforeSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles iugCampanias.BeforeSelectChange
        Dim dt As DataTable
        Dim IdCampania As Integer
        Dim IdMedio As Integer

        IdCampania = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
        IdMedio = CInt(CboMedio.SelectedRow.Cells("Id_medio").Text)
        Envio.Id_Campania_Sigeme = IdCampania
        dt = Envio.TraerSubCampaniasMMS(Activo.IDCompaniaMMS, IdCampania, IdMedio)  'Envio.TraerSubCampanias

        Dim row() As Object = {-1, "Nueva", -1, CStr(fInicioSis.Day) & "/" & CStr(fInicioSis.Month) & "/" & CStr(fInicioSis.Year)}
        dt.Rows.Add(row)
        iugSubCampanias.DataSource = dt
        SetearGrillaSubCampania()
        cmdSiguiente.Enabled = SiguienteHabilitado()
    End Sub

    Private Sub iugSubCampanias_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles iugSubCampanias.AfterSelectChange

        Envio.Id_SubCampania_Sigeme = iugSubCampanias.ActiveRow.Cells("id_subcampana").Value 'iugSubCampanias.ActiveRow.Cells("cod_subcampana").Value

        cmdSiguiente.Enabled = SiguienteHabilitado()
    End Sub

    Private Sub iugPresupuestos_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles iugPresupuestos.AfterSelectChange
        cmdSiguiente.Enabled = SiguienteHabilitado()
    End Sub

    'Private Sub iugPresupuestos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iugPresupuestos.MouseUp
    '    Try
    '        Dim aUIElement As Infragistics.Win.UIElement
    '        Dim ret As Boolean
    '        Dim i As Integer

    '        aUIElement = iugPresupuestos.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
    '        ' declare and retrieve a reference to the Cell
    '        Dim aCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    '        aCell = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridCell))
    '        ' if a cell was found display the band and column key
    '        If Not aCell Is Nothing Then
    '            If aCell.Column.Header.Caption = "Sel" Then
    '                If aCell.Value Then
    '                    'iugPresupuestos.ActiveRow.Cells("Sel").Value = False
    '                    aCell.Value = False
    '                Else
    '                    'iugPresupuestos.ActiveRow.Cells("Sel").Value = True
    '                    aCell.Value = True
    '                End If
    '            End If
    '            If aCell.Column.Header.Caption = "Canje" Then
    '                If aCell.Value Then
    '                    aCell.Value = False
    '                Else
    '                    aCell.Value = True
    '                End If
    '            End If
    '        End If

    '        i = 0
    '        ret = False
    '        While i < iugPresupuestos.Rows.Count
    '            ret = ret Or iugPresupuestos.Rows(i).Cells("Sel").Value
    '            i = i + 1
    '        End While

    '        cmdSiguiente.Enabled = ret
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Private Sub ConfigurarPresuxMes(ByRef pPresuxMes As DataTable)
        pPresuxMes = New DataTable
        pPresuxMes.Columns.Add("Anio", GetType(Integer))
        pPresuxMes.Columns.Add("Mes", GetType(Integer))
        pPresuxMes.Columns.Add("Cod_Presupuesto", GetType(Integer))
        pPresuxMes.Columns.Add("Cantidad", GetType(Integer))
        pPresuxMes.Columns.Add("Tipo_Presupuesto", GetType(Integer))

    End Sub

    Private Function ValidarPresupuestos() As Boolean
        Dim i As Integer = 0
        Dim valido As Boolean = True
        Dim conversion As Int32 = 0
        While i < iugPresupuestos.Rows.Count
            If iugPresupuestos.Rows(i).Cells("Sel").Value Then
                If Not Int32.TryParse(iugPresupuestos.Rows(i).Cells("SelTipoPresupuesto").Value, conversion) Then
                    valido = False
                    Exit While
                End If
            End If
            i += 1
        End While
        Return valido
    End Function

    'AN 18/02/2016 Nueva función que valida que los importes de compra y venta de los avisos sean iguales.
    Private Function ValidarImportesCompraVentaAvisos() As Boolean
        Dim dtAvisos As DataTable
        Dim oEnvioLigero As New Envio_Ligero_MMS

        Dim importesCorrectos As Boolean = True
        Me.dtEnvioSpotsDiferencias = Me.dtEnvioSpots.Clone()

        If Activo.IDMedio <> Medios.Tv Then
            For Each aviso As DataRow In Me.dtEnvioSpots.Rows
                If Not CDbl(aviso("IMPORTECOMPRANETO")).Equals(CDbl(aviso("IMPORTEVENTANETO"))) Then
                    importesCorrectos = False
                    Me.dtEnvioSpotsDiferencias.Rows.Add(aviso.ItemArray)
                End If
            Next
        Else
            dtAvisos = oEnvioLigero.Obtener_Avisos_Con_Diferencias(Me.dtFiltrosEnvioSpots)
            Me.dtEnvioSpotsDiferencias = dtAvisos.Clone()
            For Each aviso As DataRow In dtAvisos.Rows
                If Not CDbl(aviso("IMPORTECOMPRANETO")).Equals(CDbl(aviso("IMPORTEVENTANETO"))) Then
                    importesCorrectos = False
                    Me.dtEnvioSpotsDiferencias.Rows.Add(aviso.ItemArray)
                End If
            Next
        End If
        Return importesCorrectos
    End Function

    Private Sub EnviarACompras2()
        Me.dtEnvioSpots = New DataTable
        Dim envio As New Envio_Compras
        Dim sMensaje As String
        Dim FechaMensajePresupuesto As Date
        'Dim frmAvisosDiferencia As New frmAvisosDiferencia
        Try

            CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Obteniendo avisos...")
            Call traerSpotsTodos()

            ' ESTO ES UNA VALIDACION NUEVA. SI TRAE PROBLEMAS QUITARLO. AN 04-02-2016
            If Not ValidarPresupuestos() Then
                Mensaje("Existen presupuestos con tipo de presupuesto invalido.")
                Me.bgwEnvioCompras.CancelAsync()
                Exit Sub
            End If

            If (MedioActual = Medios.Internet And ningunMesActual) Then
                Mensaje("No existen spots para el mes del presupuesto seleccionado", TipoMensaje.DeError)
                'Me.bgwEnvioCompras.CancelAsync()
                Exit Sub
            End If


            ' AGREGO MENSAJE POR SI NO HAY DATOS PARA ENVIAR A COMPRAS (AN 18-11-2015)
            If MedioActual = Medios.Tv Then
                If Not Me.dtFiltrosEnvioSpots Is Nothing Then
                    If Me.dtFiltrosEnvioSpots.Rows.Count = 0 Then
                        Mensaje("No existen datos para enviar a compras.", TipoMensaje.DeError)
                        Exit Sub
                    End If
                End If
            End If

            CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Accediendo a la campaña...")
            Call campanamms()
            CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Accediendo a la subcampaña...")
            Call subCampanamms()
            CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Accediendo a los presupuestos...")
            Call presupuestomms(PresuxMes)

            ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015) + INTERNET (AN 16-09-2015)
            If MedioActual = Medios.Tv Or MedioActual = Medios.Internet Then ' TO DO : HACER REINGENIERIA Y SACAR TODOS LOS IFS, PROGRAMAR CON OBJETOS QUE PARA ALGO ESTAN.
                Call AddFiltrosPresupuestos()
            End If

            'AN 18/02/2016 NUEVA VALIDACION DE IMPORTES COMPRA Y VENTA DE AVISOS
            If Not ValidarImportesCompraVentaAvisos() Then
                If Activo.IDCompaniaMMS = Me.COMPANIA_FORWARD Then
                    Mensaje("Existen diferencias en los importes de compra y venta de los avisos.")
                    Me.bgwEnvioCompras.CancelAsync()
                    frmAvisosDiferencia.IdMedio = Activo.IDMedio
                    frmAvisosDiferencia.IdCompania = Activo.IDCompaniaMMS
                    frmAvisosDiferencia.DtAvisosDiferencia = Me.dtEnvioSpotsDiferencias
                    frmAvisosDiferencia.ShowDialog()
                    Exit Sub
                Else
                    frmAvisosDiferencia.IdMedio = Activo.IDMedio
                    frmAvisosDiferencia.IdCompania = Activo.IDCompaniaMMS
                    frmAvisosDiferencia.DtAvisosDiferencia = Me.dtEnvioSpotsDiferencias
                    frmAvisosDiferencia.ShowDialog()
                    If Not frmAvisosDiferencia.Continuar Then
                        Me.bgwEnvioCompras.CancelAsync()
                        Exit Sub
                    End If
                End If
            End If

            ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (SE EVITA LA VALIDACION PARA TV) (AN 27-08-2015)
            If Me.dtEnvioSpots.Rows.Count = 0 And MedioActual <> Medios.Tv And MedioActual <> Medios.Internet Then
                Mensaje("No existen spots para los parámetros ingresados", TipoMensaje.Informacion)
                Me.bgwEnvioCompras.CancelAsync()
                Exit Sub
            End If

            Dim sMes As String
            Dim Presu As Integer
            Dim ano, pmes As Integer
            Dim Rows() As DataRow

            ''aca se cargan los presupuestos al datatable de envios dcaime

            'AG 19/11/2013 ==========================================
            For Each row As DataRow In PresuxMes.Rows
                sMes = row.Item("mes").ToString
                For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                    If CInt(rowEnvio.Item("CODIGOMEDIO")) = Activo.Medios.Internet Then
                        If Convert.ToDateTime(rowEnvio.Item("f_inicio")).Month.ToString = sMes Then
                            rowEnvio.Item("codigopresupuesto") = row.Item("cod_presupuesto")
                        End If
                    Else
                        If Convert.ToDateTime(rowEnvio.Item("f_spot")).Month.ToString = sMes Then
                            rowEnvio.Item("codigopresupuesto") = row.Item("cod_presupuesto")
                        End If
                    End If
                Next
            Next
            '==========================================================

            ''SI QUEDA ALGUN SPOT SIN PRESUPUESTO...
            Dim bHayspotsSinPresupuesto As Boolean = False
            Dim anio, mes As String
            'For Each rowEnvio As DataRow In dtEnvioSpots.Rows
            '    If rowEnvio.Item("codigopresupuesto") = -1 Then
            '        bHayspotsSinPresupuesto = True
            '        sMensaje = "No existe presupuesto seleccionado para los siguientes meses: " & rowEnvio.Item("f_spot").Month.ToString & " desea que Everest lo cree?"
            '        mes = rowEnvio.Item("f_spot").Month.ToString
            '        anio = rowEnvio.Item("f_spot").Year.ToString
            '        FechaMensajePresupuesto = CDate("1" & "/" & mes & "/" & anio)
            '    End If
            'Next

            'AG 20/08/2013 ========================================================================================================================
            ''If Not DtRelacionPCPAFinal Is Nothing Then
            ''    If DtRelacionPCPAFinal.Rows.Count > 0 Then
            ''        For Each row As DataRow In PresuxMes.Rows
            ''            ano = row.Item("Anio").ToString
            ''            pmes = row.Item("mes").ToString
            ''            Presu = row.Item("Cod_Presupuesto").ToString
            ''            Rows = DtRelacionPCPAFinal.Select("PresupuestoPC = " & Presu & " AND Anio = " & ano & " AND Mes = " & pmes) 'Agregar cod_soporte
            ''            If Rows.Length = 0 Then ' Se no lo encuentra se elimina 
            ''                DtRelacionPCPAFinal.Rows.Remove(Rows(0))
            ''            End If
            ''        Next
            ''    End If
            ''End If
            '=======================================================================================================================================

            If bHayspotsSinPresupuesto Then
                'If Mensaje(sMensaje, TipoMensaje.SiNo, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                '    'AGuzzardi 09/06/2010 ------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '    Dim ret As Integer
                '    envio.Id_Cliente = Activo.IDCliente
                '    envio.Id_SubCampania_Sigeme = _id_subcampania_mms
                '    envio.Id_Campania_Sigeme = _id_campania_mms
                '    ret = envio.Inserta_Presupuesto(FechaMensajePresupuesto, Activo.Nombre)
                '    For Each dr As DataRow In dtEnvioSpots.Rows
                '        If dr("codigopresupuesto") = -1 Then 'And dr.Item("f_spot").Month.ToString = FechaMensajePresupuesto.Month.ToString() Then
                '            dr("codigopresupuesto") = ret
                '            'AGuzzardi 10/06/2010 --------------------------------------------------------
                '            'iugPresupuestos.ActiveRow.Cells("id_presupuesto").Value = ret
                '            '------------------------------------------------------------------------------------

                '            Dim drPresuxMes As DataRow
                '            drPresuxMes = PresuxMes.NewRow
                '            drPresuxMes("Anio") = FechaMensajePresupuesto.Year
                '            drPresuxMes("Mes") = FechaMensajePresupuesto.Month
                '            drPresuxMes("Cod_Presupuesto") = ret
                '            drPresuxMes("Cantidad") = 0
                '            PresuxMes.Rows.Add(drPresuxMes)
                '        End If
                '    Next
                '    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Generando envío a compras...")
                '    generaCompraMMS(dtEnvioSpots)
                '    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                'Else
                '    Exit Sub
                'End If
            Else


                CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Generando envío a compras...")

                generaCompraMMS(dtEnvioSpots) 'AG Descomentar

                If Not DtRelacionPCPAFinal Is Nothing Then
                    If DtRelacionPCPAFinal.Rows.Count > 0 Then
                        InsertarRelacionPCPAEverest()
                        InsertarRelacionPCPAMMS()
                    End If
                End If

            End If
            Dim i As Integer
            While i < iugPresupuestos.Rows.Count
                If iugPresupuestos.Rows(i).Cells("id_presupuesto").Value > 0 Then
                    iugPresupuestos.Rows(i).Cells("SelTipoPresupuesto").Activation = Activation.NoEdit
                End If
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.mSeEnvio = False
        End Try
        dtEnvioSpots = Nothing
    End Sub ''FIN EnviarACompras2()

    ''' <summary>
    ''' Valida el medio con el que se esta trabajando y se realiza la inserccion.
    ''' </summary>
    ''' <param name="dtEnvio"></param>
    ''' <remarks></remarks>
    Private Sub generaCompraMMS(ByVal dtEnvio As DataTable)

        Try
            'Me.Cursor = Cursors.WaitCursor
            Envio = New Envio_Compras

            Dim mes, anio, presupuesto As String
            Dim codPresupuesto As Integer = iugPresupuestos.ActiveRow.Cells(2).Value
            Dim idProd As Integer = cboProducto.SelectedRow.Cells(1).Value

            'MedioActual = Me.CboMedio.Value
            Select Case MedioActual
                Case Medios.Prensa
                    Dim idMaterial As Integer = cboMateriales.ActiveRow.Cells(1).Value
                    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Enviando avisos de Prensa...")
                    dtEnvio = QuitaAvisosNoCorrespondiente()  'AG AR
                    dtResultEnvio = Envio.InsertaAvisosPrensa(dtEnvio, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms, idMaterial, idProd, Me.iugCampanias.ActiveRow.Cells(0).Value, codPresupuesto)
                Case Medios.Revista
                    Dim idMaterial As Integer = cboMateriales.ActiveRow.Cells(1).Value
                    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Enviando avisos de Revista...")
                    dtEnvio = QuitaAvisosNoCorrespondiente()  'AG AR
                    dtResultEnvio = Envio.InsertaAvisosPrensa(dtEnvio, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms, idMaterial, idProd, Me.iugCampanias.ActiveRow.Cells(0).Value, codPresupuesto)
                Case Medios.Radio
                    Dim ChildR As UltraDataRowsCollection
                    Dim dt As DataTable
                    Dim id_sistema As Integer = iugEjercicios.ActiveRow.Cells("id_sistema").Value
                    Dim id_ejercicio As Integer = iugEjercicios.ActiveRow.Cells("id_ejercicio").Value
                    Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
                    Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
                    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Enviando avisos de Radio...")
                    'LC 19/08/2014 Envio a compras Radio elimina las filas sin presupuesto
                    dtEnvio = Me.QuitaAvisosNoCorrespondienteTvRadio(dtEnvio)
                    dtResultEnvio = Envio.InsertaAvisosRadio(dtEnvio, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms)
                Case Medios.Tv
                    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Enviando avisos de Televisión...")
                    dtResult = New DataTable
                    dtResultEnvio = InsertarAvisosMMS(dtFiltrosEnvioSpots, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms)
                Case Medios.Exterior
                    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Enviando avisos de Exterior...")
                    dtEnvio = QuitaAvisosNoCorrespondiente()  'AG AR
                    dtResultEnvio = Envio.InsertaAvisos_ext(dtEnvio, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms, codPresupuesto)
                Case Medios.Produccion 'AG Produccion +++++++++++++++++++++++++++
                    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Enviando avisos de Produccion...")
                    QuitaAvisosNoCorrespondiente()  'AG AR
                    dtResultEnvio = Envio.InsertaAvisos_pro(dtEnvio, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms, codPresupuesto)
                Case Medios.Internet '19/11/2013
                    CambiarTextoMarquee_ThreadSafe(Me.mpbEnvioCompras, "Enviando avisos de Internet...")
                    dtResult = New DataTable
                    dtResultEnvio = Envio.InsertaAvisos_Internet(dtEnvio, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms, codPresupuesto, 0, "", "", "", False)                    
                    Call ObtenerPresupuestosEnvioCompras(mes, anio, presupuesto)
                    dtResultEnvioDoble = Envio.InsertaAvisos_Internet(dtFiltrosEnvioSpots, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms, codPresupuesto, Activo.IDCliente, mes, anio, presupuesto, True)
                Case Else
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'NUEVO PROCEDIMIENTO PARA ENVIO A COMPRAS LIGERO DE INTERNET (AN 17-09-2015)
    Private Sub ObtenerPresupuestosEnvioCompras(ByRef mes As String, ByRef anio As String, ByRef presupuesto As String)
        For Each presupuestoMes As DataRow In PresuxMes.Rows
            mes = mes & presupuestoMes("MES") & ","
            anio = anio & presupuestoMes("ANIO") & ","
            presupuesto = presupuesto & presupuestoMes("COD_PRESUPUESTO") & ","
        Next
        mes = mes.Substring(0, mes.Length - 1)
        anio = anio.Substring(0, anio.Length - 1)
        presupuesto = presupuesto.Substring(0, presupuesto.Length - 1)
    End Sub

    Private Function InsertarAvisosMMS(ByVal dtValue As DataTable, ByVal CampaniaMMS As Integer, ByVal SubCampaniaMms As Integer, ByVal codPais As Integer, ByVal IdUsario As Integer, ByVal CampaniaActual As Integer) As DataTable
        Dim dtResultadoEnvio As New DataTable()
        dtResultadoEnvio = InsertarOrdenesTV(dtValue, _id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.IDUsuarioMMS, Activo.CodCampaniaActualMms)
        Return dtResultadoEnvio
    End Function

    ''' <summary>
    ''' Devuelve los temas correspondietnes al soporte.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetTemasBySoporte() As String

    End Function

    Private Sub campanamms()

        Dim n As Integer
        If iugCampanias.ActiveRow.Cells("id_campana").Value = -1 Then '' SI ES UNA NUEVA CAMPANIA SE CREA

            Envio.Id_Cliente = Activo.IDCliente
            Envio.Id_Producto = Me.cboProducto.Value
            'AGuzzardi 10/06/2010 ---------------------------------------
            If Envio.Desc_Campania = "" Then
                Envio.Desc_Campania = Me.txtDescripcion.Text
            End If
            '--------------------------------------------------------------------
            _id_campania_mms = AltaCampania()
            'Envio.Id_Campania_Sigeme = AltaCampania() ' Si es una nueva campaña. La agrego
            'AGuzzardi Controlo que el resultado del insert del Campania proviniente del MMS no sea CERO si asi fuese entonces termino salgo de la funcion 
            If _id_campania_mms = 0 Then ''If Envio.Id_Campania_Sigeme = 0 Then
                MsgBox("No fue posible crear la Campania, dentro del MMS ", MsgBoxStyle.Critical, "Everest Campania MMS ")
                Exit Sub
            End If
        Else
            _id_campania_mms = iugCampanias.ActiveRow.Cells("id_campana").Value
            '------------------------------------------------------------------------------------------------------------------------------
        End If
    End Sub

    Private Sub subCampanamms()
        If iugSubCampanias.ActiveRow.Cells("id_Subcampana").Value = -1 Then
            'AGuzzardi 10/06/2010 ------------------------------------------------------------
            Envio.Id_Cliente = Activo.IDCliente
            Envio.Id_Medio = Activo.IDMedio
            Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
            Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
            '-----------------------------------------------------------------------------------------
            _id_subcampania_mms = AltaSubCampania()
            ''Envio.Id_SubCampania_Sigeme = AltaSubCampania() ' Si es una nueva Sub. La agrego
            'AGuzzardi Controlo que el resultado del insert del SubCampania proviniente del MMS no sea CERO si asi fuese entonces termino salgo de la funcion -------------------------------------------------------------------------------------------------------------------------------
            If _id_subcampania_mms = 0 Then ''If Envio.Id_SubCampania_Sigeme = 0 Then
                MsgBox("No fue posible crear la SubCampania, dentro del MMS para la siguiente   " & vbCrLf & vbCrLf & "Campania : " & Envio.Desc_Campania & "  -- " & "  Codigo : " & Envio.Id_Campania_Sigeme, MsgBoxStyle.Critical, "Everest SubCampania MMS ")
                Exit Sub
            End If
        Else
            _id_subcampania_mms = iugSubCampanias.ActiveRow.Cells("id_Subcampana").Value
            '------------------------------------------------------------------------------------------------------------------------------
        End If
    End Sub

    Private Sub presupuestomms(ByRef PresuxMes As DataTable)
        Call AltaPresupuesto(PresuxMes)

        Call InsertarOC(PresuxMes)

        'AG 17/05/2013 ==============================
        Call CargarPrePAGrilla()
        '===========================================
    End Sub

    Private Sub InsertarOC(ByRef PresuxMes As DataTable)

    End Sub
    ''dcaime warning esto deberia volar!
    'CFANEGO 20/03/2014
    'Private Sub EnviarACompras_()
    '    dtEnvioSpots = New DataTable
    '    Try
    '        'Me.Cursor = Cursors.WaitCursor
    '        Dim PresuxMes As DataTable
    '        Call ConfigurarPresuxMes(PresuxMes)

    '        cmdSiguiente.Enabled = True
    '        If Not CheckPresupuesto(PresuxMes) Then ' Cargo el array y chequeo
    '            Mensajes.Mensaje("No puede seleccionar 2 presupuestos que correspondan a un mismo mes", TipoMensaje.Informacion)
    '            Me.Cursor = Cursors.Default
    '            Exit Sub
    '        End If

    '        ''LLENO ESTE DATATABLE CON LOS SPOTS PARA ENVIAR
    '        ''traerSpotsTodos(dtEnvioSpots)
    '        If Not CheckCantidadSpots(PresuxMes) Then
    '            Me.Cursor = Cursors.Default
    '            Exit Sub
    '        End If
    '        cmdSiguiente.Enabled = False

    '        Envio.Desc_Campania = txtDescripcion.Text
    '        Envio.Id_Grupo_Usuario = Activo.IDPerfil_Datos

    '        If iugCampanias.ActiveRow.Cells("id_campana").Value = -1 Then '' SI ES UNA NUEVA CAMPANIA SE CREA
    '            If ValidaCampania() Then
    '                Envio.Id_Cliente = Activo.IDCliente
    '                Envio.Id_Producto = Me.cboProducto.Value
    '                Envio.Id_Campania_Sigeme = AltaCampania() ' Si es una nueva campaña. La agrego
    '                'AGuzzardi Controlo que el resultado del insert del Campania proviniente del MMS no sea CERO si asi fuese entonces termino salgo de la funcion 
    '                If Envio.Id_Campania_Sigeme = 0 Then
    '                    MsgBox("No fue posible crear la Campania, dentro del MMS ", MsgBoxStyle.Critical, "Everest Campania MMS ")
    '                    Exit Sub
    '                End If
    '                '------------------------------------------------------------------------------------------------------------------------------
    '            Else
    '                Mensaje("Error al Crear Campaña." & vbCrLf & "Verificar existencia del target en SIGEME.", TipoMensaje.DeError)
    '                Exit Sub
    '            End If
    '        End If


    '        If iugSubCampanias.ActiveRow.Cells("id_Subcampana").Value = -1 Then
    '            Envio.Id_SubCampania_Sigeme = AltaSubCampania() ' Si es una nueva Sub. La agrego
    '            'AGuzzardi Controlo que el resultado del insert del SubCampania proviniente del MMS no sea CERO si asi fuese entonces termino salgo de la funcion -------------------------------------------------------------------------------------------------------------------------------
    '            If Envio.Id_SubCampania_Sigeme = 0 Then
    '                MsgBox("No fue posible crear la SubCampania, dentro del MMS para la siguiente   " & vbCrLf & vbCrLf & "Campania : " & Envio.Desc_Campania & "  -- " & "  Codigo : " & Envio.Id_Campania_Sigeme, MsgBoxStyle.Critical, "Everest SubCampania MMS ")
    '                Exit Sub
    '            End If
    '        End If

    '        AltaPresupuesto(PresuxMes) ' Doy de alta los presupuestos seleccionados
    '        AltaPresupuestoExcedentes(PresuxMes)
    '        ActualizarPresupuestos(PresuxMes)

    '        Dim ChildR As UltraDataRowsCollection
    '        Dim i As Integer
    '        Dim j As Integer
    '        Dim ret As String
    '        Dim CantSpots As Long
    '        Dim Temas As StringBuilder
    '        Dim TemasSeleccionados As String

    '        Select Case CboMedio.Value
    '            Case 1, 6 ''TV y RADIO

    '                If Not Ultra Is Nothing Then
    '                    i = 0
    '                    CantSpots = 0
    '                    While i < Ultra.Rows.Count ' recorro todo el ultra data
    '                        ChildR = Ultra.Rows(i).GetChildRows("ChildBand")
    '                        j = 0
    '                        If CboMedio.Value = MedioRadio Then
    '                            pgbSoportes.Increment(1)
    '                            Temas = New StringBuilder
    '                            TemasSeleccionados = String.Empty
    '                            While j < ChildR.Count ' para cada uno de los hijos reviso si esta tildado y genero una condicon para una clausula IN de pl
    '                                If ChildR.Item(j).GetCellValue("Ok") Then
    '                                    Temas.Append(ChildR.Item(j).GetCellValue("Tema"))
    '                                    Temas.Append(",")
    '                                End If
    '                                j = j + 1
    '                            End While
    '                            If Temas.ToString.Length > 0 Then
    '                                TemasSeleccionados = Temas.ToString.Substring(0, Temas.ToString.Length - 1)
    '                                GenerarCompraxSoporte(PresuxMes, TemasSeleccionados, Ultra.Rows(i).Item("id_soporte"), CantSpots)
    '                            End If
    '                        Else ''TV
    '                            While j < ChildR.Count ' para cada uno de los hijos reviso si esta tildado y genero una condicon para una clausula IN de pl
    '                                If ChildR.Item(j).GetCellValue("Ok") Then

    '                                    GenerarCompraxSoporteTema(PresuxMes, ChildR.Item(j).GetCellValue("Tema"), Ultra.Rows(i).Item("id_soporte"), CantSpots)
    '                                End If
    '                                j = j + 1
    '                            End While
    '                        End If


    '                        i = i + 1
    '                    End While
    '                    Mensajes.Mensaje("Se insertaron " & CantSpots & " spots", TipoMensaje.Informacion)
    '                    Me.mSeEnvio = True
    '                End If
    '            Case 4, 5
    '                For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
    '                    Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
    '                    Me.GenerarCompraPrensa(PresuxMes, CantSpots)
    '                Next
    '                Mensajes.Mensaje("Se insertaron " & CantSpots & " spots", TipoMensaje.Informacion)
    '                Me.mSeEnvio = True
    '            Case 3
    '                For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
    '                    Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
    '                    ''Me.GenerarCompraExterior(PresuxMes, CantSpots)
    '                Next

    '                Mensajes.Mensaje("Se insertaron " & CantSpots & " spots", TipoMensaje.Informacion)
    '                Me.mSeEnvio = True
    '        End Select

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Me.mSeEnvio = False
    '    End Try
    '    Me.Cursor = Cursors.Default
    'End Sub

    ''' <summary>
    ''' completa la tabla (dtEnvioSpots global)con los spots para enviar a compras
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub traerSpotsTodos()
        Dim id_material As Integer = 1
        Dim id_campania As Integer = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
        Dim id_subcampania As Integer = CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value)
        Dim dt As New DataTable
        Dim ChildR As UltraDataRowsCollection
        Dim ChildTemas As UltraDataRowsCollection
        Dim i, j, z As Integer
        Dim mes As String = String.Empty
        Dim mesInicio As Integer = -1
        Dim mesFin As Integer = -1
        ningunMesActual = True

        Select Case MedioActual
            Case Medios.Prensa
                'For index As Integer = 0 To lstSoportes.Items.Count
                Envio.ListaSoportes = ConcatenarSoportes()
                dt = Envio.ObtenerSpotsPrensa()
                'For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                '    mes = rowEnvio.Item("f_spot").Month.ToString()
                '    If (mes = iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) Then
                '        ningunMesActual = False
                '        Exit For
                '    End If
                'Next
                CopiarDT(dt, Me.dtEnvioSpots)
                'Next
            Case Medios.Revista
                'For index As Integer = 0 To lstSoportes.Items.Count
                Envio.ListaSoportes = ConcatenarSoportes()
                dt = Envio.ObtenerSpotsPrensa()
                CopiarDT(dt, Me.dtEnvioSpots)
                'For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                '    mes = rowEnvio.Item("f_spot").Month.ToString()
                '    If (mes = iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) Then
                '        ningunMesActual = False
                '        Exit For
                '    End If
                'Next
                'Next
            Case Medios.Radio
                While i < Ultra.Rows.Count ''PROVEEDORES
                    ChildR = Ultra.Rows(i).GetChildRows("Soportes") ''SOPORTES
                    j = 0
                    While j < ChildR.Count ''RECORREMOS LOS SOPORTES
                        ChildTemas = ChildR(j).GetChildRows("Temas")
                        z = 0
                        While z < ChildTemas.Count ''RECORREMOS LOS TEMAS
                            If ChildTemas.Item(z).GetCellValue("Ok") Then ''SI ESTAN OK SE AGREGAN
                                'AGuzzardi 10/06/2010 ----------------------------------------------------------------------------
                                If Envio.Id_Sistema = 0 Then
                                    Envio.Id_Sistema = iugEjercicios.ActiveRow.Cells("id_sistema").Value
                                End If
                                If Envio.Id_Ejercicio = 0 Then
                                    Envio.Id_Ejercicio = iugEjercicios.ActiveRow.Cells("id_ejercicio").Value
                                End If
                                If Envio.Id_Campania = 0 Then
                                    Envio.Id_Campania = Activo.IDCampaña
                                End If
                                Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
                                Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
                                '---------------------------------------------------------------------------------------------------------
                                dt = Envio.Traer_Avisos_MMS_RD(ChildTemas.Item(z).GetCellValue("Tema"), ChildR(j).Item("id_soporte"), id_campania, id_subcampania)
                                CopiarDT(dt, Me.dtEnvioSpots)
                            End If
                            z += 1
                        End While
                        j = j + 1
                    End While
                    i = i + 1
                End While
                'For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                '    mes = rowEnvio.Item("f_spot").Month.ToString()
                '    If (mes = iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) Then
                '        ningunMesActual = False
                '        Exit For
                '    End If
                'Next
            Case Medios.Tv
                    ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)
                    Call InitializeDtFiltros()
                    While i < Ultra.Rows.Count ''SOPORTES
                        ChildR = Ultra.Rows(i).GetChildRows("Soportes") ''SOPORTES
                        If CboMedio.Value = MedioRadio Then
                        Else
                            j = 0
                            While j < ChildR.Count ''RECORREMOS LOS SOPORTES    
                                ChildTemas = ChildR(j).GetChildRows("Temas")
                                z = 0
                                While z < ChildTemas.Count ''RECORREMOS LOS TEMAS
                                    If ChildTemas.Item(z).GetCellValue("Ok") Then ''SI ESTAN OK SE AGREGAN
                                    ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)
                                        ' SE AGREGA PROCESAMIENTO DE TEMAS POR FECHA (AN 10-11-2015)
                                        Dim tema As String = ChildTemas.Item(z).GetCellValue("Tema")
                                        Dim anios = DateDiff(DateInterval.Year, dtpF_Desde.Value, dtpF_Hasta.Value)
                                        Dim fechaDesde As Integer = CInt(CDate(dtpF_Desde.Value).Month.ToString() & CDate(dtpF_Desde.Value).Year.ToString())
                                        Dim fechaHasta As Integer = CInt((CInt(CDate(dtpF_Hasta.Value).Month.ToString()) + (anios * 12)) & CDate(dtpF_Hasta.Value).Year.ToString())
                                        Dim filas As DataRow() = DtTemasSoporte.Select(String.Format("TEMA='{0}'", tema))

                                        For Each fila As DataRow In filas
                                            'REEMPLAZO VALIDACION DE FECHAS (AN 18-11-2015)
                                            If CInt(fila("MES") & fila("ANIO")) >= fechaDesde And CInt(fila("MES") & fila("ANIO")) <= fechaHasta Then
                                            AddFiltroRow(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, Medios.Tv, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text), CDate(dtpF_Desde.Value).ToShortDateString, CDate(dtpF_Hasta.Value).ToShortDateString(), ChildTemas.Item(z).GetCellValue("Tema"), ChildR(j).Item("id_soporte"), id_campania, id_subcampania, 0, 0, fila("MES"), fila("ANIO"))
                                        End If
                                        Next
                                    End If
                                    z += 1
                                End While
                                j = j + 1
                            End While
                        End If
                        i = i + 1
                    End While
                    'For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                    '    mes = rowEnvio.Item("f_spot").Month.ToString()
                    '    If (mes = iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) Then
                    '        ningunMesActual = False
                    '        Exit For
                    '    End If
                    'Next
                    ''FIN TV
            Case Medios.Exterior
                    For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                        Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
                        ''revisar esto creo que no va asi!! dcaime
                        _id_presupuesto_mms = iugPresupuestos.Rows(iugPresupuestos.ActiveRow.Index).Cells(2).Value
                        dtEnvioSpots = Envio.traer_avisos_MMS_EXT(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, cboMateriales.ActiveRow.Cells("id_material").Value, _id_producto, id_campania, _id_presupuesto_mms)
                        ''Me.GenerarCompraExterior(dtEnvioSpots, dtEnvioSpots.Rows.Count) ''PresuxMes, CantSpots)
                    Next
                    'For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                    '    mes = rowEnvio.Item("f_spot").Month.ToString()
                    '    If (mes = iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) Then
                    '        ningunMesActual = False
                    '        Exit For
                    '    End If
                    'Next
                    ''Mensajes.Mensaje("Se insertaron " & CantSpots & " spots", TipoMensaje.Informacion)
                    ''Me.mSeEnvio = True
            Case Medios.Produccion 'AG Produccion ++++++++++++++++++++++++
                    For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                        Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
                        ''revisar esto creo que no va asi!! dcaime
                        _id_presupuesto_mms = iugPresupuestos.Rows(iugPresupuestos.ActiveRow.Index).Cells(2).Value
                        dtEnvioSpots = Envio.traer_avisos_MMS_Produccion(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, cboMateriales.ActiveRow.Cells("id_material").Value, _id_producto, id_campania, _id_presupuesto_mms)

                        'dtEnvioSpots = Envio.traer_avisos_MMS_EXT(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, cboMateriales.ActiveRow.Cells("id_material").Value, _id_producto, id_campania, _id_presupuesto_mms)
                        ''Me.GenerarCompraExterior(dtEnvioSpots, dtEnvioSpots.Rows.Count) ''PresuxMes, CantSpots)
                    Next
                    'For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                    '    mes = rowEnvio.Item("f_spot").Month.ToString()
                    '    If (mes = iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) Then
                    '        ningunMesActual = False
                    '        Exit For
                    '    End If
                    'Next
                    '++++++++++++++++++++++++++++++++++++++++++++++++++
            Case Medios.Internet 'AG Internet 19/11/2013
                    For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                        Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
                        _id_presupuesto_mms = iugPresupuestos.Rows(iugPresupuestos.ActiveRow.Index).Cells(2).Value
                        dtEnvioSpots = Envio.traer_avisos_MMS_Internet(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, id_campania, _id_presupuesto_mms)
                    Next
                    For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                        mesInicio = CInt(rowEnvio.Item("f_inicio").Month.ToString())
                        mesFin = CInt(rowEnvio.Item("f_fin").Month.ToString())
                        If (CInt(iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) = mesInicio Or CInt(iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) = mesFin) Then
                            ningunMesActual = False
                            Exit For
                        End If
                Next
                Dim oEnvioLigero As New Envio_Ligero_MMS
                Dim proveedores As List(Of String) = oEnvioLigero.Obtener_Relacion_Proveedores()

                Call FiltrarAvisosInternetEnvioDoble(dtEnvioSpots, proveedores)

                    If Not dtEnvioSpots Is Nothing Then
                        cantidadAvisosSocialyse = dtEnvioSpots.Rows.Count
                    Else
                        cantidadAvisosSocialyse = 0
                    End If

                    ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO DE INTERNET (AN 15-09-2015)
                    Call InitializeDtFiltros()
                    For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                    If proveedores.Contains(DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).Descripcion.Split("[")(2).Replace("]", "")) Then
                        AddFiltroRow(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, Medios.Internet, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text), CDate(dtpF_Desde.Value).ToShortDateString, CDate(dtpF_Hasta.Value).ToShortDateString(), String.Empty, DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID, id_campania, id_subcampania, 0, 0, 0, 0)
                    End If
                    Next
            Case Else
        End Select
        dt.Dispose()
    End Sub

    ' NUEVO DESARROLLO DE ENVIO DOBLE SOCIALYSE (AN 18-09-2015)
    Private Sub FiltrarAvisosInternetEnvioDoble(ByRef _datos As DataTable, ByVal proveedores As List(Of String))
        Dim tabla As DataTable = _datos.Clone()
        For Each fila As DataRow In _datos.Rows
            'Filtro los registros de socialyse ya que se envian por otro metodo.
            If Not proveedores.Contains(fila("ID_PROVEEDOR").ToString()) Then
                tabla.ImportRow(fila)
            End If
        Next
        _datos = tabla
    End Sub

    ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)
    Private Sub AddFiltrosPresupuestos()
        For Each presupuesto As DataRow In PresuxMes.Rows
            For Each filtro As DataRow In dtFiltrosEnvioSpots.Rows
                If Convert.ToInt32(filtro("MES")) = Convert.ToInt32(presupuesto("MES")) And Convert.ToInt32(filtro("ANIO")) = Convert.ToInt32(presupuesto("ANIO")) Then
                    filtro("MESPRESUPUESTO") = presupuesto("MES")
                    filtro("PRESUPUESTO") = presupuesto("COD_PRESUPUESTO")
                End If
            Next
        Next
    End Sub

    ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)
    Private Sub AddFiltroRow(ByVal campania As Integer, ByVal sistema As Integer, ByVal ejercicio As Integer, ByVal medio As Integer, ByVal producto As Integer, ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal tema As String, ByVal soporte As String, ByVal campaniamms As Integer, ByVal subcampaniamms As Integer, ByVal mespresupuesto As Integer, ByVal presupuesto As Integer, ByVal mes As Integer, ByVal anio As Integer)
        Dim dtFiltrosEnvioSpotsRow As DataRow = dtFiltrosEnvioSpots.NewRow()
        dtFiltrosEnvioSpotsRow("CAMPANIA") = campania
        dtFiltrosEnvioSpotsRow("SISTEMA") = sistema
        dtFiltrosEnvioSpotsRow("EJERCICIO") = ejercicio
        dtFiltrosEnvioSpotsRow("MEDIO") = medio
        dtFiltrosEnvioSpotsRow("PRODUCTO") = producto
        dtFiltrosEnvioSpotsRow("FECHADESDE") = fechadesde.ToShortDateString()
        dtFiltrosEnvioSpotsRow("FECHAHASTA") = fechahasta.ToShortDateString()
        dtFiltrosEnvioSpotsRow("TEMA") = tema
        dtFiltrosEnvioSpotsRow("SOPORTE") = soporte
        dtFiltrosEnvioSpotsRow("MES") = mes
        dtFiltrosEnvioSpotsRow("ANIO") = anio
        dtFiltrosEnvioSpotsRow("MESPRESUPUESTO") = mespresupuesto
        dtFiltrosEnvioSpotsRow("PRESUPUESTO") = presupuesto
        dtFiltrosEnvioSpots.Rows.Add(dtFiltrosEnvioSpotsRow)
    End Sub

    ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)
    Private Sub InitializeDtFiltros()
        dtFiltrosEnvioSpots = New DataTable()
        dtFiltrosEnvioSpots.Columns.Add("CAMPANIA")
        dtFiltrosEnvioSpots.Columns.Add("SISTEMA")
        dtFiltrosEnvioSpots.Columns.Add("EJERCICIO")
        dtFiltrosEnvioSpots.Columns.Add("MEDIO")
        dtFiltrosEnvioSpots.Columns.Add("PRODUCTO")
        dtFiltrosEnvioSpots.Columns.Add("FECHADESDE")
        dtFiltrosEnvioSpots.Columns.Add("FECHAHASTA")
        dtFiltrosEnvioSpots.Columns.Add("TEMA")
        dtFiltrosEnvioSpots.Columns.Add("SOPORTE")
        dtFiltrosEnvioSpots.Columns.Add("MES")
        dtFiltrosEnvioSpots.Columns.Add("ANIO")
        dtFiltrosEnvioSpots.Columns.Add("MESPRESUPUESTO")
        dtFiltrosEnvioSpots.Columns.Add("PRESUPUESTO")
    End Sub

    Private Function QuitaAvisosNoCorrespondiente() As DataTable 'AG AR

        Dim DtPresupuestoAvisosMMS As DataTable = dtEnvioSpots.Clone()

        If dtEnvioSpots.Rows.Count > 0 Then
            For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                If rowEnvio.Item("codigopresupuesto") > -1 Then
                    DtPresupuestoAvisosMMS.ImportRow(rowEnvio)
                End If
            Next
        End If

        dtEnvioSpots = DtPresupuestoAvisosMMS

        Return DtPresupuestoAvisosMMS

    End Function

    Private Function QuitaAvisosNoCorrespondienteTvRadio(ByVal Dt As DataTable) As DataTable 'AG AR

        Dim DtPresupuestoAvisosMMS As DataTable = Dt.Clone()

        If Dt.Rows.Count > 0 Then
            For Each rowEnvio As DataRow In Dt.Rows
                If rowEnvio.Item("codigopresupuesto") > -1 Then
                    DtPresupuestoAvisosMMS.ImportRow(rowEnvio)
                End If
            Next
        End If

        Return DtPresupuestoAvisosMMS

    End Function

    Private Function CheckCantidadSpots(ByRef pPresuxMes As DataTable) As Boolean

        Dim ChildR As UltraDataRowsCollection
        Dim i As Integer
        Dim j As Integer
        Dim ret As String
        Dim CantSpots As Long
        Dim dt As DataTable
        Dim CantEnviados As Integer
        Dim CantidadSpots As New SortedList
        Dim CantidadSpotsEnviados As New SortedList
        Dim Key As String
        Dim Mensaje, Temas As StringBuilder
        Dim TemasSeleccionados As String

        CantSpots = 0
        If Not Ultra Is Nothing Then
            i = 0
            While i < Ultra.Rows.Count ' recorro todo el ultra data
                ''?Ultra.Rows(i).GetChildRows <-> TEMAS
                ''?Ultra.Rows <-> SOPORTES 
                ChildR = Ultra.Rows(i).GetChildRows("ChildBand")
                j = 0
                If CboMedio.Value = MedioRadio Then
                    Temas = New StringBuilder
                    TemasSeleccionados = String.Empty
                    While j < ChildR.Count ' para cada uno de los hijos reviso si esta tildado y genero una condicon para una clausula IN de pl
                        If ChildR.Item(j).GetCellValue("Ok") Then
                            Temas.Append(ChildR.Item(j).GetCellValue("Tema"))
                            Temas.Append(",")
                        End If
                        j = j + 1
                    End While
                    If Temas.ToString.Length > 0 Then
                        TemasSeleccionados = Temas.ToString.Substring(0, Temas.ToString.Length - 1)
                        dt = Envio.Traer_Avisos_Soporte_Radio(TemasSeleccionados, Ultra.Rows(i).Item("id_soporte"))
                        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                            For Each dr As DataRow In dt.Rows
                                Key = Convert.ToDateTime(dr("f_spot")).Year & "-" & Convert.ToDateTime(dr("f_spot")).Month
                                If Not CantidadSpots.ContainsKey(Key) Then
                                    CantidadSpots.Add(Key, 1)
                                Else
                                    CantidadSpots(Key) = Convert.ToInt32(CantidadSpots.Item(Key)) + 1
                                End If
                            Next
                        End If
                    End If
                Else ''OTROS MEDIOS
                    While j < ChildR.Count ' para cada uno de los hijos reviso si esta tildado y genero una condicon para una clausula IN de pl
                        ''ChildR.Item(j) <=> TEMA
                        If ChildR.Item(j).GetCellValue("Ok") Then
                            ''dt = Envio.Traer_Avisos_Soporte(ChildR.Item(j).GetCellValue("Tema"), Ultra.Rows(i).Item("id_soporte"))
                            ''SACAR ESTE HARDCODE
                            Dim id_material As Integer = 1
                            Dim codigoCampanaMms As Integer = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
                            Dim codigoSubCampanaMms As Integer = CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value)
                            ''?iugPresupuestos.Rows(0).Cells(2)<-> ESTO ES EL ID_PRESUPUESTO
                            ''ACA DEBO OBTENER LOS PRESUPUESTOS SELECCIONADOS SOLAMENTE !!
                            ''CELL(6) ES LA QUE DICE SI ESTA SELECCIONADO O NO TRUE OR FALSE
                            ''Dim idPresupuestoMMS As Integer

                            'For index As Integer = 1 To iugPresupuestos.Rows.Count - 1
                            '    If iugPresupuestos.Rows(index).Cells(6).Value Then
                            '        idPresupuestoMMS = iugPresupuestos.Rows(index).Cells("id_Presupuesto").Value
                            ''ACA DEBEMOS RESTAURAR LA FUNCIONALIDAD ANTERIOR Y HACER LA INSERCION EN OTRO LUGAR!!
                            ''REVISADO POR DANIEL CAIME
                            dt = Envio.Traer_Avisos_MMS_TV(ChildR.Item(j).GetCellValue("Tema"), Ultra.Rows(i).Item("id_soporte"), codigoCampanaMms, codigoSubCampanaMms)

                            ''Esto se debe cambiar par apoder enviar avisos de distintos presupuestos.
                            ''Jsperk - Dcaime
                            ''cantSpotInsertados = dt.Rows.Count
                            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                                For Each dr As DataRow In dt.Rows
                                    Key = Convert.ToDateTime(dr("f_spot")).Year & "-" & Convert.ToDateTime(dr("f_spot")).Month
                                    If Not CantidadSpots.ContainsKey(Key) Then
                                        CantidadSpots.Add(Key, 1)
                                    Else
                                        CantidadSpots(Key) = Convert.ToInt32(CantidadSpots.Item(Key)) + 1
                                    End If
                                Next
                            End If
                        End If
                        ''OJO REVISAR ESTO VA ACA?? DANIEL CAIME
                        CopiarDT(dt, dtEnvioSpots)
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
        End If

        Dim ExisteMesSeleccionado As Boolean
        Dim MesesNoSeleccionados As New ArrayList
        Dim KeyMonth As String
        Mensaje = New StringBuilder
        For Index As Integer = 0 To CantidadSpots.Count - 1
            Key = CantidadSpots.GetKey(Index).ToString.Split("-")(1)
            ExisteMesSeleccionado = False
            For RowIndex As Integer = 0 To iugPresupuestos.Rows.Count - 1
                If iugPresupuestos.Rows(RowIndex).Cells("Sel").Value AndAlso Convert.ToInt32(iugPresupuestos.Rows(RowIndex).Cells("Mes").Value) = Key Then
                    ExisteMesSeleccionado = True
                    Exit For
                End If
            Next
            If Not ExisteMesSeleccionado Then
                MesesNoSeleccionados.Add(Key)
            End If
        Next
        If MesesNoSeleccionados.Count > 0 Then
            If MesesNoSeleccionados.Count = 1 Then
                Mensaje.Append("No existe un presupuesto seleccionado para el mes de ")
                Mensaje.Append(MonthName(MesesNoSeleccionados(0)))
                Mensaje.Append(".")
            Else
                Mensaje.Append("No existen presupuestos seleccionados para los siguientes meses: ")
                For Index As Integer = 0 To MesesNoSeleccionados.Count - 1
                    Mensaje.Append(vbCrLf)
                    Mensaje.Append(MonthName(MesesNoSeleccionados(Index)))
                Next
            End If
            Mensaje.Append(vbCrLf)
            Mensaje.Append("Desea que el sistema ")
            If MesesNoSeleccionados.Count > 1 Then
                Mensaje.Append("los")
            Else
                Mensaje.Append("lo")
            End If
            Mensaje.Append(" cree?")
            If Mensajes.Mensaje(Mensaje.ToString, TipoMensaje.SiNo) = DialogResult.No Then
                CheckCantidadSpots = False
                Exit Function
            Else
                Dim MesFaltante As Integer
                For Index As Integer = 0 To MesesNoSeleccionados.Count - 1
                    MesFaltante = MesesNoSeleccionados(Index)
                    For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
                        If RowPresupuesto.Cells("id_presupuesto").Value = -1 AndAlso RowPresupuesto.Cells("Mes").Value = MesFaltante Then
                            RowPresupuesto.Cells("Sel").Value = True
                        End If
                    Next
                Next
            End If
        End If

        i = 0
        CantEnviados = 0
        Dim Cantidad_Spot_Enviados As Integer
        Dim Filtro As StringBuilder
        While i < iugPresupuestos.Rows.Count
            If iugPresupuestos.Rows(i).Cells("Sel").Value And iugPresupuestos.Rows(i).Cells("id_presupuesto").Value <> -1 Then
                Envio.Id_Presupuesto_Sigeme = iugPresupuestos.Rows(i).Cells("id_presupuesto").Value()

                ''DANIEL CAIME
                ''VER DE RECORRER EL DATATABLE PARA INSERTAR EL PRESUPUESTO ACA!!

                'AGuzzardi Este con no se utiliza para MMS ------------------------------------
                'Cantidad_Spot_Enviados = Envio.Cantidad_Ordenes_Enviados
                '-----------------------------------------------------------------------------------------
                'Cantidad_Spot_Enviados -= 1
                CantidadSpotsEnviados.Add(Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Mes").Value).ToString, Cantidad_Spot_Enviados)
                Filtro = New StringBuilder
                Filtro.Append("Mes = ")
                Filtro.Append(Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Mes").Value))
                Filtro.Append(" and Anio = ")
                Filtro.Append(Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Ano").Value))
                Filtro.Append(" and cod_Presupuesto = ")
                Filtro.Append(Convert.ToInt32(iugPresupuestos.Rows(i).Cells("id_presupuesto").Value))
                If pPresuxMes.Select(Filtro.ToString).Length > 0 Then
                    pPresuxMes.Select(Filtro.ToString)(0).Item("Cantidad") = Cantidad_Spot_Enviados
                End If
            End If
            i = i + 1
        End While

        Dim CantidadMaxima As Integer = mCantidadMaxima
        Dim CantidadPresupuestosFaltantes, CantidadSpotsMes, Resto As Integer
        MesesExcedentes = New SortedList
        Mensaje = New StringBuilder
        For Index As Integer = 0 To CantidadSpots.Count - 1
            CantidadMaxima = mCantidadMaxima
            Key = CantidadSpots.GetKey(Index)
            KeyMonth = Key.Split("-")(1)
            CantidadSpotsMes = Convert.ToInt32(CantidadSpots(Key))
            If CantidadSpotsEnviados.Count > 0 AndAlso CantidadSpotsEnviados.ContainsKey(KeyMonth) Then
                CantidadMaxima -= Convert.ToInt32(CantidadSpotsEnviados(KeyMonth))
            End If
            If CantidadSpotsMes > CantidadMaxima Then
                If CantidadMaxima = mCantidadMaxima Then
                    CantidadPresupuestosFaltantes = Math.DivRem(CantidadSpotsMes, mCantidadMaxima, Resto)
                    For RowIndex As Integer = 0 To iugPresupuestos.Rows.Count - 1
                        If iugPresupuestos.Rows(RowIndex).Cells("Sel").Value AndAlso Convert.ToInt32(iugPresupuestos.Rows(RowIndex).Cells("Mes").Value) = KeyMonth Then
                            CantidadPresupuestosFaltantes -= 1
                            Exit For
                        End If
                    Next
                Else
                    CantidadPresupuestosFaltantes = Math.DivRem(CantidadSpotsMes - CantidadMaxima, mCantidadMaxima, Resto)
                End If
                If Resto > 0 Then
                    CantidadPresupuestosFaltantes += 1
                End If
                MesesExcedentes.Add(Key, CantidadPresupuestosFaltantes)
            End If
        Next

        If MesesExcedentes.Count > 0 Then
            If MesesExcedentes.Count = 1 Then
                Mensaje.Append("Existe un excedente de avisos seleccionados permitido para el mes de ")
                Mensaje.Append(MonthName(Convert.ToInt32(MesesExcedentes.GetKey(0).ToString.Split("-")(1))))
                If Convert.ToInt32(MesesExcedentes(MesesExcedentes.GetKey(0))) > 1 Then
                    Mensaje.Append(". Se agregaran ")
                    Mensaje.Append(MesesExcedentes(MesesExcedentes.GetKey(0)))
                    Mensaje.Append(" presupuestos.")
                Else
                    Mensaje.Append(". Se agregara 1 presupuesto.")
                End If
            Else
                Mensaje.Append("Existen excedentes de avisos seleccionados permitidos para los siguientes meses: ")
                For Index As Integer = 0 To MesesExcedentes.Count - 1
                    Mensaje.Append(vbCrLf)
                    Mensaje.Append(MonthName(Convert.ToInt32(MesesExcedentes.GetKey(Index).ToString.Split("-")(1))))
                    If Convert.ToInt32(MesesExcedentes(MesesExcedentes.GetKey(Index))) > 1 Then
                        Mensaje.Append(" (Se agregaran ")
                        Mensaje.Append(Convert.ToInt32(MesesExcedentes(MesesExcedentes.GetKey(Index))))
                        Mensaje.Append(" presupuestos)")
                    Else
                        Mensaje.Append(" (Se agregara 1 presupuesto)")
                    End If
                Next
            End If
            Mensaje.Append(vbCrLf)
            Mensaje.Append("Desea continuar?")
            If Mensajes.Mensaje(Mensaje.ToString, TipoMensaje.SiNo) = DialogResult.No Then
                CheckCantidadSpots = False
            Else
                CheckCantidadSpots = True
            End If
            Exit Function
        End If
        ''dt = dtEnvioSpots
        CheckCantidadSpots = True

    End Function

    Private Function CheckPresupuesto(ByRef pPresuxMes As DataTable) As Boolean
        ' cargo el array y chequeo que no haya 2 prespuestos para el mismo mes
        Dim i As Integer
        Dim ret As Boolean
        Dim Filtro As StringBuilder
        Dim PresuxMes As DataRow

        i = 0
        ret = True
        While i < iugPresupuestos.Rows.Count And ret
            If iugPresupuestos.Rows(i).Cells("Sel").Value Then
                Filtro = New StringBuilder
                Filtro.Append("Mes = ")
                Filtro.Append(Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Mes").Value))
                Filtro.Append(" and Anio = ")
                Filtro.Append(Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Ano").Value))

                If pPresuxMes.Select(Filtro.ToString).Length > 0 Then
                    ret = False
                Else
                    If iugPresupuestos.Rows(i).Cells("id_Presupuesto").Value > 0 Then
                        PresuxMes = pPresuxMes.NewRow
                        PresuxMes("Anio") = Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Ano").Value)
                        PresuxMes("Mes") = Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Mes").Value)
                        PresuxMes("Cod_Presupuesto") = Convert.ToInt32(iugPresupuestos.Rows(i).Cells("id_Presupuesto").Value)
                        PresuxMes("Cantidad") = 0
                        pPresuxMes.Rows.Add(PresuxMes)
                    End If
                End If
            End If
            i = i + 1
        End While

        CheckPresupuesto = ret
    End Function

    Private Function CheckTipoPresupuesto() As Boolean
        ' chequeo que no haya presupuestos seleccionados sin tipo
        Dim i As Integer
        Dim ret As Boolean

        i = 0
        ret = True
        While i < iugPresupuestos.Rows.Count And ret
            If iugPresupuestos.Rows(i).Cells("Sel").Value Then

                If String.IsNullOrEmpty(Convert.ToString(iugPresupuestos.Rows(i).Cells("SelTipoPresupuesto").Value)) Then
                    ret = False
                End If
            End If
            i = i + 1
        End While

        CheckTipoPresupuesto = ret
    End Function

    Private Sub GenerarCompraPrensa(ByRef pPresuxMes As DataTable, ByRef CantSpots As Long)
        Dim dt As DataTable
        Dim presu As Long
        Dim Intercambio, Id_Spot, Duracion As Integer
        Dim Filtro As StringBuilder
        Dim DateSpot As DateTime
        Dim CantidadInserciones As Integer

        Try

            dt = Envio.ObtenerSpotsPrensa
            pgbSpots.Value = 0
            pgbSpots.Maximum = dt.Rows.Count

            For Each row As DataRow In dt.Rows
                Id_Spot = row("id_spot")
                DateSpot = Convert.ToDateTime(row("f_spot"))
                Filtro = New StringBuilder
                Filtro.Append("Mes = ")
                Filtro.Append(DateSpot.Month)
                Filtro.Append(" and Anio = ")
                Filtro.Append(DateSpot.Year)
                Filtro.Append(" and Cantidad < ")
                Filtro.Append(mCantidadMaxima)
                If pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto").Length > 0 Then
                    presu = pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cod_Presupuesto")
                End If
                If presu > 0 Then
                    Intercambio = GetEstado(presu)

                    Envio.Id_Presupuesto_Sigeme = presu
                    ''Warning: Revisar la ejecucion de esta llamada.
                    ''CantidadInserciones = Envio.InsertaAvisosPrensa(Intercambio, row("id_spot"), row("id_Spot_detalle"), Activo.Login)
                    CantSpots = CantSpots + 1

                    pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cantidad") += 1
                End If
                pgbSpots.Increment(1)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''dcaime warning esto deberia volar
    Private Sub GenerarCompraExterior_(ByRef pPresuxMes As DataTable, ByRef CantSpots As Long)
        Dim dt As DataTable
        Dim presu As Long
        Dim Intercambio, Id_Spot, Duracion As Integer
        Dim Filtro As StringBuilder
        Dim DateSpot As DateTime
        Dim CantidadInserciones As Integer

        Try

            Envio.Id_Material = cboMateriales.SelectedRow.Cells(1).Value
            ''dt = Envio.ObtenerSpotsExterior
            pgbSpots.Value = 0
            pgbSpots.Maximum = dt.Rows.Count

            For Each row As DataRow In dt.Rows
                Id_Spot = row("id_spot")
                DateSpot = Convert.ToDateTime(row("f_spot"))
                Filtro = New StringBuilder
                Filtro.Append("Mes = ")
                Filtro.Append(DateSpot.Month)
                Filtro.Append(" and Anio = ")
                Filtro.Append(DateSpot.Year)
                Filtro.Append(" and Cantidad < ")
                Filtro.Append(mCantidadMaxima)
                ''aca la tabla pPresuxMes llega vacia declararla a nivel de clase
                If PresuxMes.Select(Filtro.ToString, "Cod_Presupuesto").Length > 0 Then
                    presu = PresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cod_Presupuesto")
                End If
                If presu > 0 Then
                    ''tiene que funcionar
                    Intercambio = GetEstado(presu)

                    Envio.Id_Presupuesto_Sigeme = presu
                    ''cambio de funcionalidad del metodo D_C
                    ''enviar el dt con los avisos 
                    ''pasar solo los avisos que van en ese presupuesto!!
                    ''CantidadInserciones = Envio.InsertaAvisosExterior(dt, Id_Campania, id_subcampania, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, 1, Envio.Id_Producto, Id_Campania, presu).Rows.Count
                    ''Intercambio, row("id_spot"), row("id_Spot_detalle"), Activo.Login)
                    CantSpots = CantSpots + 1

                    PresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cantidad") += 1
                End If
                pgbSpots.Increment(1)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GenerarCompraxSoporte(ByRef pPresuxMes As DataTable, ByVal Temas As String, ByVal Id_Soporte As Long, ByRef CantSpots As Long)
        Dim dt As DataTable
        Dim presu As Long
        Dim Intercambio, Id_Spot, Duracion As Integer
        Dim Filtro As StringBuilder
        Dim DateSpot As DateTime
        Dim CantidadInserciones As Integer

        Try

            dt = Envio.Traer_Avisos_Soporte_Radio(Temas, Id_Soporte)
            pgbSpots.Value = 0
            pgbSpots.Maximum = dt.Rows.Count

            For Each row As DataRow In dt.Rows
                Id_Spot = row("id_spot")
                Duracion = row("duracion")
                DateSpot = Convert.ToDateTime(row("f_spot"))
                Filtro = New StringBuilder
                Filtro.Append("Mes = ")
                Filtro.Append(DateSpot.Month)
                Filtro.Append(" and Anio = ")
                Filtro.Append(DateSpot.Year)
                Filtro.Append(" and Cantidad < ")
                Filtro.Append(mCantidadMaxima)
                If pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto").Length > 0 Then
                    presu = pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cod_Presupuesto")
                End If
                If presu > 0 Then
                    Intercambio = GetEstado(presu)

                    Envio.Id_Presupuesto_Sigeme = presu
                    CantidadInserciones = 0 ''Envio.InsertaAvisosRadio(Intercambio, Id_Soporte, Temas, Id_Spot, Duracion, DateSpot)
                    CantSpots = CantSpots + CantidadInserciones

                    pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cantidad") += 1
                End If
                pgbSpots.Increment(1)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GenerarCompraxSoporteTema(ByRef pPresuxMes As DataTable, ByVal temas As String, ByVal id_soporte As Long, ByRef CantSpots As Long)
        Dim dt As DataTable
        Dim presu As Long
        Dim Intercambio As Integer
        Dim tema As New Temas
        Dim Filtro As StringBuilder
        Dim DateSpot As DateTime
        Try

            ''dt = Envio.Traer_Avisos_Soporte(temas, id_soporte)
            dt = Envio.Traer_Avisos_MMS_TV(temas, id_soporte, Me.Id_Campania, CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value))
            ''Envio.Traer_Avisos_MMS(ChildR.Item(j).GetCellValue("Tema"), Ultra.Rows(i).Item("id_soporte"), id_material, codigoCampanaMms, codigoSubCampanaMms)
            pgbSoportes.Increment(1)
            pgbSpots.Value = 0
            pgbSpots.Maximum = dt.Rows.Count

            tema.Id_campania = mId_Campania
            tema.Id_tema = temas
            tema.Id_producto = cboProducto.Value
            tema.BuscarPorID()

            For Each row As DataRow In dt.Rows
                DateSpot = Convert.ToDateTime(row("f_spot"))
                Filtro = New StringBuilder
                Filtro.Append("Mes = ")
                Filtro.Append(DateSpot.Month)
                Filtro.Append(" and Anio = ")
                Filtro.Append(DateSpot.Year)
                Filtro.Append(" and Cantidad < ")
                Filtro.Append(mCantidadMaxima)
                presu = 0
                If pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto").Length > 0 Then
                    presu = pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cod_Presupuesto")
                End If
                If presu > 0 Then

                    'AGuzzardi Se quita la validacion del Estado, esto solo lo usa el Everest ------------------------------
                    'If row("ID_SPOT_ESTADO") = "P" Then
                    '------------------------------------------------------------------------------------------------------------------------
                    'Intercambio = GetEstado(presu)
                    Envio.Id_Presupuesto_Sigeme = presu
                    Envio.Id_Material = tema.Id_material

                    ''DANIEL CAIME
                    ''PARECE QUE ACA IRIA EL INSERT DE MMS
                    Dim id_material As Integer = 1
                    Dim codigoCampanaMms As Integer = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
                    Dim codigoSubCampanaMms As Integer = CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value)
                    Dim pais As Integer = 32
                    'Envio.InsertaAvisosMMS(dt, codigoCampanaMms, codigoSubCampanaMms, pais, Activo.IDUsuarioMMS)
                    ''Envio.InsertaAvisos(Intercambio, row("id_spot"), row("id_spot_detalle"))

                    CantSpots = CantSpots + 1

                    pPresuxMes.Select(Filtro.ToString, "Cod_Presupuesto")(0).Item("Cantidad") += 1
                End If
                'End If
                pgbSpots.Increment(1)
            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function GetEstado(ByVal p As Long) As Integer
        For Each r As UltraGridRow In iugPresupuestos.Rows

            If r.Cells("id_presupuesto").Value = p Then
                If r.Cells.Exists("id_intercambio") AndAlso Not r.Cells("id_intercambio").Value Is "" AndAlso r.Cells("id_intercambio").Value > 0 Then
                    ''DBNull.Value
                    Return 1
                Else
                    Return 0
                End If
            End If
        Next
        Return 0
    End Function

    Private Function ValidaCampania() As Boolean
        Return Envio.ExisteCampania()
    End Function

    Private Function AltaCampania() As Long
        Dim ret As Long

        Try
            ret = Envio.Inserta_Campania(CDate(iugCampanias.ActiveRow.Cells(2).Value))
            'AGuzzardi Controlo que el resultado del insert del Campania proviniente del MMS no sea CERO si asi fuese entonces termino salgo de la funcion 
            If ret = 0 Then
                Exit Function
            End If
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            iugCampanias.ActiveRow.Cells("id_campana").Value = ret
            iugCampanias.ActiveRow.Cells("descripcion").Value = txtDescripcion.Text
            AltaCampania = ret
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function AltaSubCampania() As Long
        Dim ret As Long

        Try
            'LC 26/03/2014 Al crear la subcampania se crea con el tipo de soporte como descripcion
            Envio.Desc_SubCampania = cboTipoSoporte.Text
            ret = Envio.Inserta_SubCampania(Str(Today.Day) & "/" & CStr(Today.Month) & "/" & CStr(Today.Year))
            'AGuzzardi Controlo que el resultado del insert del SubCampania proviniente del MMS no sea CERO si asi fuese entonces termino salgo de la funcion -----------------------------------------------------------------------------------------------------------------------------------
            If ret = 0 Then
                Exit Function
            End If
            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            iugSubCampanias.ActiveRow.Cells("id_subcampana").Value = ret
            iugSubCampanias.ActiveRow.Cells("descripcion").Value = txtDescripcion.Text '.Substring(1, 39)
            iugSubCampanias.ActiveRow.Cells("finicio").Value = Envio.Fecha_Desde
            AltaSubCampania = ret
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'CFANEGO 20/03/2014
    'Private Sub AltaPresupuestoExcedentes(ByRef pPresuxMes As DataTable)
    '    Dim ret As Integer
    '    Dim Fecha As Date
    '    Dim Mes, Anio, Cantidad As Integer
    '    Dim Key As String
    '    Dim PresuxMes As DataRow

    '    If Not MesesExcedentes Is Nothing Then
    '        For Index As Integer = 0 To MesesExcedentes.Count - 1
    '            Key = MesesExcedentes.GetKey(Index)
    '            Anio = Key.Split("-")(0)
    '            Mes = Key.Split("-")(1)
    '            Fecha = New DateTime(Anio, Mes, 1)
    '            Cantidad = MesesExcedentes(MesesExcedentes.GetKey(Index))
    '            For CantidadAlta As Integer = 0 To Cantidad - 1
    '                ret = Envio.Inserta_Presupuesto(Fecha, Activo.Nombre)
    '                'AGuzzardi Controlo que el resultado del insert del presupuesto proviniente del MMS no sea CERO si asi fuese entonces termino el For y salgo de la funcion -----------------------------------------------------------------------------------------------------------------------------------
    '                If ret = 0 Then
    '                    MsgBox("No Fue posible Crear el presupuesto, dentro del MMS para la siguiente   " & vbCrLf & vbCrLf & "Campania : " & Envio.Desc_Campania & "  -- " & "  Codigo : " & Envio.Id_Campania_Sigeme & vbCrLf & "SubCampania : " & Envio.Desc_SubCampania & "  -- " & "  Codigo : " & Envio.Id_SubCampania_Sigeme, MsgBoxStyle.Critical, "Everest Presupuesto MMS ")
    '                    Exit Sub
    '                End If
    '                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    '                PresuxMes = pPresuxMes.NewRow
    '                PresuxMes("Anio") = Anio
    '                PresuxMes("Mes") = Mes
    '                PresuxMes("Cod_Presupuesto") = ret
    '                PresuxMes("Cantidad") = 0
    '                pPresuxMes.Rows.Add(PresuxMes)
    '            Next
    '        Next
    '    End If
    'End Sub

    Private Sub AltaPresupuesto(ByRef pPresuxMes As DataTable)
        Try
            Dim i As Integer
            Dim ret As Integer
            Dim Fecha As Date
            Dim Filtro As StringBuilder
            Dim PresuxMes As DataRow

            i = 0
            While i < iugPresupuestos.Rows.Count
                If iugPresupuestos.Rows(i).Cells("Sel").Value Then
                    If iugPresupuestos.Rows(i).Cells("id_presupuesto").Value = -1 Then
                        ''Las fecha vienen DbNull jsperk.
                        If iugPresupuestos.Rows(i).Cells("mes").Value = CDate(iugSubCampanias.ActiveRow.Cells("finicio").Value).Month AndAlso iugPresupuestos.Rows(i).Cells("ano").Value = CDate(iugSubCampanias.ActiveRow.Cells("finicio").Value).Year Then
                            ' si es del mes de inicio de la subcampaña, le pongo al presu, como fecha de inicio, la de subcamapaña
                            Fecha = CDate(CDate(iugSubCampanias.ActiveRow.Cells("finicio").Value).Day & "/" & iugPresupuestos.Rows(i).Cells("mes").Value & "/" & iugPresupuestos.Rows(i).Cells("ano").Value)
                        Else
                            ' sino le pongo el primer dia del mes
                            Fecha = CDate("01/" & iugPresupuestos.Rows(i).Cells("mes").Value & "/" & iugPresupuestos.Rows(i).Cells("ano").Value)
                        End If
                        ''SETEAR DATOS DE CAMPANIA_MMS SUB_CAMPANIA
                        'AGuzzardi 10/06/2010 -----------------------------------------------------------
                        If Envio.Id_Cliente = 0 Then
                            Envio.Id_Cliente = Activo.IDCliente
                        End If
                        If Envio.Id_Campania_Sigeme = 0 Then
                            Envio.Id_Campania_Sigeme = iugCampanias.ActiveRow.Cells("id_campana").Value
                        End If
                        If Envio.Id_SubCampania_Sigeme = 0 Then
                            Envio.Id_SubCampania_Sigeme = iugSubCampanias.ActiveRow.Cells("id_subcampana").Value
                        End If

                        'AG 19/09/2013 ================================================================
                        Envio.Id_Intercambio = IdIntercambio
                        'If iugPresupuestos.Rows(i).Cells("Sel").Value And iugPresupuestos.Rows(i).Cells("id_presupuesto").Value = -1 Then

                        '    iugPresupuestos.ActiveRow.Cells("Cod. Canje").Value = String.Empty
                        '    iugPresupuestos.ActiveRow.Cells("canje").Value = False
                        'End If

                        '==============================================================================
                        '----------------------------------------------------------------------------------------
                        ret = Envio.Inserta_Presupuesto(Fecha, Activo.Nombre, Convert.ToInt32(iugPresupuestos.Rows(i).Cells("SelTipoPresupuesto").Value), Convert.ToString(iugPresupuestos.Rows(i).Cells("NumeroOC").Value))
                        'AGuzzardi Controlo que el resultado del insert del presupuesto proviniente del MMS no sea CERO si asi fuese entonces termino el While y salfo de la funcion -----------------------------------------------------------------------------------------------------------------------------------
                        If ret = 0 Then
                            MsgBox("No Fue posible Crear el presupuesto, dentro del MMS para la siguiente   " & vbCrLf & vbCrLf & "Campania : " & Envio.Desc_Campania & "  -- " & "  Codigo : " & Envio.Id_Campania_Sigeme & vbCrLf & "SubCampania : " & Envio.Desc_SubCampania & "  -- " & "  Codigo : " & Envio.Id_SubCampania_Sigeme, MsgBoxStyle.Critical, "Everest Presupuesto MMS ")
                            Exit Sub
                        End If
                        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                        iugPresupuestos.Rows(i).Cells("id_presupuesto").Value = ret
                        PresuxMes = pPresuxMes.NewRow
                        PresuxMes("Anio") = Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Ano").Value)
                        PresuxMes("Mes") = Convert.ToInt32(iugPresupuestos.Rows(i).Cells("Mes").Value)
                        PresuxMes("Cod_Presupuesto") = ret
                        PresuxMes("Cantidad") = 0
                        'PresuxMes("Tipo_Presupuesto") = Convert.ToInt32(iugPresupuestos.Rows(i).Cells("SelTipoPresupuesto").Value)
                        'Envio.ActualizarOCPresupuesto(ret)
                        pPresuxMes.Rows.Add(PresuxMes)
                    Else
                        Envio.ActualizarOCPresupuesto(Activo.IDCompaniaMMS, Convert.ToInt32(iugPresupuestos.Rows(i).Cells("id_presupuesto").Value), Convert.ToString(iugPresupuestos.Rows(i).Cells("NumeroOC").Value))
                    End If
                End If
                i = i + 1
            End While

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizarPresupuestos(ByVal pPresuxMes As DataTable)
        Dim CodPresupuesto As Double
        Dim CodCanje As Double

        For Each Presupuesto As UltraGridRow In iugPresupuestos.Rows
            If Presupuesto.Cells("Sel").Value AndAlso Not Presupuesto.Cells("Cod. Canje").Value Is DBNull.Value AndAlso Presupuesto.Cells("Cod. Canje").Value <> String.Empty Then
                CodCanje = Convert.ToDouble(Presupuesto.Cells("Cod. Canje").Value)

                Dim Filtro As New StringBuilder
                Filtro.Append("Mes = ")
                Filtro.Append(Convert.ToInt32(Presupuesto.Cells("mes").Value))
                Filtro.Append(" and Anio = ")
                Filtro.Append(Convert.ToInt32(Presupuesto.Cells("ano").Value))
                For Each NuevoPresupuesto As DataRow In pPresuxMes.Select(Filtro.ToString)
                    CodPresupuesto = Convert.ToDouble(NuevoPresupuesto("Cod_Presupuesto"))
                    'AGuzzardi Chequear como se Actualiza los datos del presupuesto en MMS --------------------------------
                    Envio.ActualizarPresupuesto(CodPresupuesto, CodCanje)
                    '-----------------------------------------------------------------------------------------------------------------------------
                Next
            End If
        Next
    End Sub

    Private Sub iugPresupuestos_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugPresupuestos.ClickCellButton

        'Proceso Canje
        If e.Cell.Column.Header.Column.Header.Caption = "" Then 'AG 19/09/2013
            If Convert.ToBoolean(iugPresupuestos.ActiveRow.Cells("Sel").Text) AndAlso Convert.ToBoolean(iugPresupuestos.ActiveRow.Cells("Canje").Text) Then
                'AG 19/09/2013 ================================================================================
                'Controla que si tiene un presupuesto ya cagado y tiene canje asignado no permite editar o cambiar el canje ya enviado
                If Convert.ToInt32(iugPresupuestos.ActiveRow.Cells("ID_PRESUPUESTO").Value) <> -1 And iugPresupuestos.ActiveRow.Cells("Canje").Text <> "" Then
                    MsgBox("No puede modificarse el CANJE, una vez enviado a Compras este Presupuesto")
                    Exit Sub
                End If
                '==============================================================================================
                Dim Año, Mes As Integer
                Año = Convert.ToInt32(iugPresupuestos.ActiveRow.Cells("ano").Value)
                Mes = Convert.ToInt32(iugPresupuestos.ActiveRow.Cells("mes").Value)
                Dim FechaIntercambio As DateTime = New DateTime(Año, Mes, 1)
                Dim BuscarIntercambios As New frmBuscarIntercambio
                BuscarIntercambios.FechaIntercambio = FechaIntercambio
                BuscarIntercambios.ShowDialog()
                If BuscarIntercambios.Aceptar AndAlso BuscarIntercambios.CodigoIntercambio > 0 Then
                    iugPresupuestos.ActiveRow.Cells("Cod. Canje").Value = BuscarIntercambios.CodigoIntercambio
                    IdIntercambio = iugPresupuestos.ActiveRow.Cells("Cod. Canje").Value.ToString
                End If
                Exit Sub
            End If
        End If

        If e.Cell.Column.Header.Column.Header.Caption = "Tipo Presupuesto" Then '19/03/2014

        End If

        'Proceso Pago Anticipado
        If e.Cell.Column.Header.Column.Header.Caption = "Sel.P.A" Then '19/09/2013

            'AG 15/07/2013 =======================================================================================
            If Activo.IDMedio = Medios.Internet Then
                MsgBox("El medio INTERNET, no posee el proceso de Pago Anticipado. ", MsgBoxStyle.Information, "Everest")
                Exit Sub
            End If

            If Convert.ToBoolean(iugPresupuestos.ActiveRow.Cells("Sel").Text) Then
                Dim Año, Mes, fila, codpresupuesto As Integer
                Dim codPresuPAnticipado As Integer
                Dim codcampanaMMS, codsubcampanaMMS As Integer
                fila = iugPresupuestos.ActiveRow.Index
                codpresupuesto = Convert.ToInt32(iugPresupuestos.ActiveRow.Cells("ID_PRESUPUESTO").Value)
                Año = Convert.ToInt32(iugPresupuestos.ActiveRow.Cells("ano").Value)
                Mes = Convert.ToInt32(iugPresupuestos.ActiveRow.Cells("mes").Value)
                Dim BuscarPAnticipado As New frmPresupuestosPA
                Me.DtDatosPresPA = New DataTable
                TraerSpotsPA()

                'AG 02/09/2013 ====================================
                If CheckPresupuestoControlPA() = True Then
                    MsgBox("No se puede seleccionar mas de un mes, para " & vbCrLf & "el proceso de Pago Anticipado.")
                    Exit Sub
                End If
                '==================================================

                If PermitirMostrarPantalaSeleccionPA() = True Then
                    With BuscarPAnticipado
                        .IdCampana = IdCampanaPCPA
                        .IdSubCampana = IdSubCampanaPCPA
                        .MesPauta = Mes
                        .AnioPauta = Año
                        .PresupuestoPC = codpresupuesto
                        .IdMedio = Activo.IDMedio
                        .NoActualizar = Me.NoActualizar

                        'comento por prueba (AN - 02-09-2015)
                        'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
                        If Me.MedioActual = Medios.Tv Then                        
                            .DtAvisosEnvioCompras = ObtenerAvisosFiltradosXmesPA(Me.dtFiltrosEnvioSpots, Año, Mes)
                            DtSoportesPautaTotales = CalcularTotalesXSoporteEnvio(.DtAvisosEnvioCompras)  'AG 23/07/2013
                        Else
                            .DtAvisosEnvioCompras = ObtenerAvisosFiltradosXmesPANoTv(Me.DtDatosPresPA, Año, Mes)
                            DtSoportesPautaTotales = CalcularTotalesXSoporteEnvioCacheNoTv(.DtAvisosEnvioCompras)
                        End If

                        'DtSoportesPautaTotales = CalcularTotalesXSoporteEnvio(.DtAvisosEnvioCompras)  'AG 23/07/2013
                        .DtFiltroSoporte = DtSoportesPautaTotales.DefaultView.ToTable(True, "anio", "mes", "PresupuestoPC", "cod_soporte", "soporte", "TotalSoporteEnvio")
                        frmEnviarCompras.Instancia = Me
                        .ShowDialog()
                        DtControlEnvioFinal = DtRelacionPCPAFinal
                        'AG 23/08/2013 ========================================================
                        DtSoportesPautaTotales.Columns.Add("CodPresupuestoPa", GetType(Integer))
                        CargarPASeleccionado(DtSoportesPautaTotales)
                        dtControl = DtSoportesPautaTotales
                        dtControl = VerificarSoporteSeleccionado(dtControl, ListaSopPA) 'AG 23/08/2013
                        '======================================================================
                        Call CargarPrePAGrilla()
                    End With
                Else
                    'MsgBox("Ya se encuentra relacionado, este presupuesto seleccionado " & vbCrLf & "a un presupuesto de Pago Anticipado.")
                End If
            Else
                MsgBox("         Si desea relacionar un Presupuesto de P.A, debera " & vbCrLf & "pulsar en cualquier boton, de los Presupuesto seleccionados .")
            End If
        End If

        '=====================================================================================================
    End Sub

    Private Sub iugPresupuestos_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugPresupuestos.CellChange
        If e.Cell.Column.Header.Caption = "Sel" Then
            If CType(CType(iugPresupuestos.ActiveRow.Cells("sel"), Infragistics.Win.UltraWinGrid.UltraGridCell).EditorResolved, Infragistics.Win.CheckEditor).CheckState = CheckState.Unchecked Then
                iugPresupuestos.ActiveRow.Cells("canje").Value = False
                iugPresupuestos.ActiveRow.Cells("Cod. Canje").Value = String.Empty
                If iugPresupuestos.ActiveRow.Cells("id_presupuesto").Value < 0 Then
                    iugPresupuestos.ActiveRow.Cells("SelTipoPresupuesto").Value = String.Empty
                    iugPresupuestos.ActiveRow.Cells("NumeroOC").Value = String.Empty
                End If
                iugPresupuestos.ActiveRow.Cells("SelTipoPresupuesto").Activation = Activation.NoEdit 'Activation.Disabled
            Else
                If iugPresupuestos.ActiveRow.Cells("id_presupuesto").Value < 0 Then
                    iugPresupuestos.ActiveRow.Cells("SelTipoPresupuesto").Activation = Activation.AllowEdit  'Activation.ActivateOnly
                End If
            End If
        ElseIf e.Cell.Column.Header.Caption = "Canje" Then
            If Not iugPresupuestos.ActiveRow.Cells("sel").Value Then
                iugPresupuestos.ActiveRow.Cells("canje").Value = False
            ElseIf Convert.ToInt32(iugPresupuestos.ActiveRow.Cells("Avisos").Value) > 0 Then
                iugPresupuestos.ActiveRow.Cells("canje").Value = False
                Mensaje("El presupuesto tiene avisos asociados.")
            ElseIf CType(CType(iugPresupuestos.ActiveRow.Cells("canje"), Infragistics.Win.UltraWinGrid.UltraGridCell).EditorResolved, Infragistics.Win.CheckEditor).CheckState = CheckState.Unchecked Then
                iugPresupuestos.ActiveRow.Cells("Cod. Canje").Value = String.Empty
            End If
        End If

        Dim ret As Boolean = False
        For Each Presupuesto As UltraGridRow In iugPresupuestos.Rows
            If Convert.ToBoolean(Presupuesto.Cells("sel").Text) Then
                ret = True
                Exit For
            End If
        Next

        cmdSiguiente.Enabled = ret
    End Sub

    Private Sub cboTarget_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboTarget.InitializeLayout

    End Sub

    Private Sub CboMedio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.ValueChanged
        If Not CboMedio.Value Is Nothing Then
            Limpiar()
            Envio.Id_Medio = CboMedio.Value
            Activo.IDMedio = CboMedio.Value
            MedioActual = CboMedio.Value
            RearmarFormulario(Activo.IDMedio)
            LimpiarFiltros()
            CargarFiltros()
        End If
        cmdSiguiente.Enabled = False
        chkSelAll.Visible = False
    End Sub

    Private Sub RearmarFormulario(ByVal Medio As Medios)
        'Select Case Medio
        '    Case Medios.Tv, Medios.Radio
        '        'Oculto los Componentes
        '        '----------------------

        '        Me.cboTarget.Visible = True
        '        Me.cboMateriales.Visible = False
        '        Me.iugTemasxSop.Visible = True
        '        Me.fraGrafica.Visible = False

        '        Me.cboProducto.Top = 80
        '        Me.cboProducto.Left = 324
        '        Me.Label1.Top = 84
        '        Me.Label1.Left = 264
        '        lblMat.Visible = False
        '        'pgbSoportes.Visible = True

        '        cboTipoSoporte.Width = 476
        '        cboTipoSoporte.Top = 56
        '        cboTipoSoporte.Left = 84
        '        Label21.Left = 12
        '        Label21.Top = 60

        '    Case Medios.Exterior, Medios.Produccion  'AG Produccion +++++++++++++++++
        '        Me.cboTarget.Visible = True
        '        Me.cboMateriales.Visible = True
        '        Me.iugTemasxSop.Visible = False
        '        Me.fraGrafica.Visible = True
        '        Me.cboMateriales.Top = 80
        '        Me.lblMat.Top = 84
        '        Me.cboProducto.Top = 32
        '        Me.Label1.Top = 36
        '        lblMat.Visible = True
        '        'pgbSoportes.Visible = False

        '        Me.cboMateriales.Top = 56
        '        Me.cboMateriales.Left = 324
        '        Me.lblMat.Top = 60
        '        Me.lblMat.Left = 260

        '        Me.cboProducto.Top = 56
        '        Me.cboProducto.Left = 84
        '        Me.Label1.Top = 60
        '        Me.Label1.Left = 12

        '        cboTipoSoporte.Width = 156
        '        cboTipoSoporte.Top = 32
        '        cboTipoSoporte.Left = 324
        '        Label21.Left = 252
        '        Label21.Top = 36

        '        Me.dtpF_Hasta.Width = Me.dtpF_Desde.Width
        '        Me.txtDescripcion.Width = 476
        '        Me.cboProducto.Width = 156
        '        Me.cboTipoSoporte.Left = 405
        '        Me.cboMateriales.Left = 405
        '        Me.dtpF_Hasta.Left = 405
        '        Me.lblMat.Left = 320
        '        Me.Label6.Left = 320
        '        Me.Label21.Left = 320
        '        Me.cboProducto.Width = 230
        '        Me.CboMedio.Width = 230
        '        Me.cboTarget.Width = 230
        '        Me.dtpF_Desde.Width = 230
        '        Me.Label3.Left = 405
        '        Me.cboSeccion.Left = 405

        '        cboConcepto.Visible = False
        '        Label7.Visible = False

        '        'AG Produccion +++++++++++++++++++++++++++++++
        '        If Medio = Medios.Produccion Then
        '            Me.fraGrafica.Text = "Produccion"
        '        Else
        '            Me.fraGrafica.Text = "Exterior"
        '        End If
        '        '+++++++++++++++++++++++++++++++++++++++++
        '        Label3.Text = "Provincia"

        '        'AG Produccion +++++++++++++++++++++++++++++++
        '        If Medio = Medios.Produccion Then
        '            Me.cboMateriales.Visible = False
        '            Me.lblMat.Visible = False
        '            Me.cboTarget.Visible = False
        '            Me.Label11.Visible = False
        '            Me.cboProducto.Width = 480
        '        End If
        '        '+++++++++++++++++++++++++++++++++++++++++
        '    Case Medios.Prensa, Medios.Revista
        '        'Oculto los Componentes
        '        '----------------------
        '        cboConcepto.Visible = True
        '        Label7.Visible = True

        '        Me.cboTarget.Visible = True
        '        Me.cboMateriales.Visible = True
        '        Me.iugTemasxSop.Visible = False
        '        Me.fraGrafica.Visible = True
        '        Me.cboMateriales.Top = 80
        '        Me.lblMat.Top = 84
        '        Me.cboProducto.Top = 32
        '        Me.Label1.Top = 36
        '        lblMat.Visible = True
        '        pgbSoportes.Visible = False
        '        Label3.Text = "Seccion"
        '        Me.cboMateriales.Top = 56
        '        Me.cboMateriales.Left = 324
        '        Me.lblMat.Top = 60
        '        Me.lblMat.Left = 260

        '        Me.cboProducto.Top = 56
        '        Me.cboProducto.Left = 84
        '        Me.Label1.Top = 60
        '        Me.Label1.Left = 12

        '        cboTipoSoporte.Width = 156
        '        cboTipoSoporte.Top = 32
        '        cboTipoSoporte.Left = 324
        '        Label21.Left = 252
        '        Label21.Top = 36

        '        Me.dtpF_Hasta.Width = Me.dtpF_Desde.Width
        '        Me.txtDescripcion.Width = 476
        '        Me.cboProducto.Width = 156
        '        Me.cboTipoSoporte.Left = 405
        '        Me.cboMateriales.Left = 405
        '        Me.dtpF_Hasta.Left = 405
        '        Me.lblMat.Left = 320
        '        Me.Label6.Left = 320
        '        Me.Label21.Left = 320
        '        Me.cboProducto.Width = 230
        '        Me.CboMedio.Width = 230
        '        Me.cboTarget.Width = 230
        '        Me.dtpF_Desde.Width = 230
        '        Me.lstSoportes.Width = 140

        '        Me.fraGrafica.Text = "Prensa/Revista"

        '    Case Medio.Internet
        '        'AG Internet +++++++++++++++++++++++++++++++
        '        Me.fraGrafica.Text = "Internet"
        '        Me.cboMateriales.Visible = False
        '        Me.cboTarget.Visible = False
        '        Me.cboProducto.Visible = True
        '        Me.cboTarget.Visible = False
        '        Me.cboMateriales.Visible = False
        '        Me.cboSeccion.Visible = False

        '        Me.lblMat.Visible = False
        '        Me.Label1.Visible = True
        '        Me.Label11.Visible = False
        '        Me.iugTemasxSop.Visible = False
        '        Me.fraGrafica.Visible = True
        '        Me.Label3.Visible = False

        '        Me.cboMateriales.Top = 80
        '        Me.lblMat.Top = 84
        '        Me.cboProducto.Top = 32
        '        Me.Label1.Top = 36
        '        Me.lstSoportes.Width = 360

        '        Me.cboMateriales.Top = 56
        '        Me.cboMateriales.Left = 324
        '        Me.lblMat.Top = 60
        '        Me.lblMat.Left = 260

        '        Me.cboProducto.Top = 56
        '        Me.cboProducto.Left = 84
        '        Me.Label1.Top = 60
        '        Me.Label1.Left = 12

        '        Me.dtpF_Hasta.Width = Me.dtpF_Desde.Width
        '        Me.txtDescripcion.Width = 396
        '        Me.cboProducto.Width = 396
        '        Me.lstSoportes.Width = 420

        '        cboTipoSoporte.Width = 156
        '        cboTipoSoporte.Top = 32
        '        cboTipoSoporte.Left = 324
        '        Label21.Left = 252
        '        Label21.Top = 36
        '        cboConcepto.Visible = False
        '        Label7.Visible = False

        'End Select

        Select Case Medio
            Case Medios.Tv, Medios.Radio
                'Oculto los Componentes
                '----------------------

                Me.cboTarget.Visible = True
                Me.cboMateriales.Visible = False
                Me.iugTemasxSop.Visible = True
                Me.fraGrafica.Visible = False

                Me.cboProducto.Top = 80
                Me.cboProducto.Left = 324
                Me.Label1.Top = 84
                Me.Label1.Left = 264
                lblMat.Visible = False
                'pgbSoportes.Visible = True

                cboTipoSoporte.Width = 476
                cboTipoSoporte.Top = 56
                cboTipoSoporte.Left = 84
                Label21.Left = 12
                Label21.Top = 60

            Case Medios.Exterior, Medios.Produccion  'AG Produccion +++++++++++++++++
                Me.cboTarget.Visible = True
                Me.cboMateriales.Visible = True
                Me.iugTemasxSop.Visible = False
                Me.fraGrafica.Visible = True
                Me.cboMateriales.Top = 80
                Me.lblMat.Top = 84
                Me.cboProducto.Top = 32
                Me.Label1.Top = 36
                lblMat.Visible = True
                'pgbSoportes.Visible = False

                Me.cboMateriales.Top = 56
                Me.cboMateriales.Left = 324
                Me.lblMat.Top = 60
                Me.lblMat.Left = 260

                Me.cboProducto.Top = 56
                Me.cboProducto.Left = 84
                Me.Label1.Top = 60
                Me.Label1.Left = 12

                cboTipoSoporte.Width = 156
                cboTipoSoporte.Top = 32
                cboTipoSoporte.Left = 324
                Label21.Left = 252
                Label21.Top = 36

                Me.dtpF_Hasta.Width = Me.dtpF_Desde.Width
                Me.txtDescripcion.Width = 501
                Me.cboProducto.Width = 156
                Me.cboTipoSoporte.Left = 405
                Me.cboMateriales.Left = 405
                Me.dtpF_Hasta.Left = 405
                Me.lblMat.Left = 320
                Me.Label6.Left = 320
                Me.Label21.Left = 320
                Me.cboProducto.Width = 230
                Me.CboMedio.Width = 230
                Me.cboTarget.Width = 230
                Me.dtpF_Desde.Width = 230
                Me.Label3.Left = 405
                Me.cboSeccion.Left = 405

                cboConcepto.Visible = False
                Label7.Visible = False

                Me.lstSoportes.Width = 390
                Me.lstSoportes.Height = 247

                Me.cboMateriales.Width = 180
                Me.cboTipoSoporte.Width = 180

                'AG Produccion +++++++++++++++++++++++++++++++
                If Medio = Medios.Produccion Then
                    Me.fraGrafica.Text = "Produccion"
                Else
                    Me.fraGrafica.Text = "Exterior"
                End If
                '+++++++++++++++++++++++++++++++++++++++++
                Label3.Text = "Provincia"

                'AG Produccion +++++++++++++++++++++++++++++++
                If Medio = Medios.Produccion Then
                    Me.cboMateriales.Visible = False
                    Me.lblMat.Visible = False
                    Me.cboTarget.Visible = False
                    Me.Label11.Visible = False
                    Me.cboProducto.Width = 501
                End If
                '+++++++++++++++++++++++++++++++++++++++++
            Case Medios.Prensa, Medios.Revista
                'Oculto los Componentes
                '----------------------
                cboConcepto.Visible = True
                Label7.Visible = True

                Me.cboTarget.Visible = True
                Me.cboMateriales.Visible = True
                Me.iugTemasxSop.Visible = False
                Me.fraGrafica.Visible = True
                Me.cboMateriales.Top = 80
                Me.lblMat.Top = 84
                Me.cboProducto.Top = 32
                Me.Label1.Top = 36
                lblMat.Visible = True
                pgbSoportes.Visible = False
                Label3.Text = "Seccion"
                Me.cboMateriales.Top = 56
                Me.cboMateriales.Left = 324
                Me.lblMat.Top = 60
                Me.lblMat.Left = 260

                Me.cboProducto.Top = 56
                Me.cboProducto.Left = 84
                Me.Label1.Top = 60
                Me.Label1.Left = 12

                cboTipoSoporte.Width = 156
                cboTipoSoporte.Top = 32
                cboTipoSoporte.Left = 324
                Label21.Left = 252
                Label21.Top = 36

                Me.dtpF_Hasta.Width = Me.dtpF_Desde.Width
                Me.txtDescripcion.Width = 501
                Me.cboProducto.Width = 156
                Me.cboTipoSoporte.Left = 405
                Me.cboMateriales.Left = 405
                Me.dtpF_Hasta.Left = 405
                Me.lblMat.Left = 320
                Me.Label6.Left = 320
                Me.Label21.Left = 320
                Me.cboProducto.Width = 230
                Me.CboMedio.Width = 230
                Me.cboTarget.Width = 230
                Me.dtpF_Desde.Width = 230
                Me.fraGrafica.Text = "Prensa/Revista"

                Me.lstSoportes.Width = 371
                Me.lstSoportes.Height = 256
                Me.cboSeccion.Left = 390
                Me.Label3.Left = 390
                Me.Label7.Left = 540
                Me.cboMateriales.Width = Me.dtpF_Hasta.Width
                Me.cboTipoSoporte.Width = Me.dtpF_Hasta.Width

            Case Medio.Internet
                'AG Internet +++++++++++++++++++++++++++++++
                Me.fraGrafica.Text = "Internet"
                Me.cboMateriales.Visible = False
                Me.cboTarget.Visible = False
                Me.cboProducto.Visible = True
                Me.cboTarget.Visible = False
                Me.cboMateriales.Visible = False
                Me.cboSeccion.Visible = False

                Me.lblMat.Visible = False
                Me.Label1.Visible = True
                Me.Label11.Visible = False
                Me.iugTemasxSop.Visible = False
                Me.fraGrafica.Visible = True
                Me.Label3.Visible = False

                Me.cboMateriales.Top = 80
                Me.lblMat.Top = 84

                Me.Label1.Top = 36
                Me.lstSoportes.Width = 698 'AG Agrandar
                Me.lstSoportes.Height = 258 'AG Agrandar

                Me.cboMateriales.Top = 56
                Me.cboMateriales.Left = 324
                Me.lblMat.Top = 60
                Me.lblMat.Left = 260

                Me.cboProducto.Top = 56
                ''Me.cboProducto.Left = 95
                Me.Label1.Top = 60
                Me.Label1.Left = 12

                Me.dtpF_Hasta.Width = Me.dtpF_Desde.Width
                Me.txtDescripcion.Width = 410
                Me.cboProducto.Width = 410
                Me.cboProducto.Left = 70 'AG Agrandar
                Me.cboProducto.Top = 60

                Me.lstSoportes.Width = 698 'AG Agrandar

                Me.CboMedio.Left = 70 'AG Agrandar
                Me.txtDescripcion.Left = 70 'AG Agrandar

                cboTipoSoporte.Width = 156
                cboTipoSoporte.Top = 32
                cboTipoSoporte.Left = 324

                Label21.Left = 250 'AG Agrandar
                Label21.Top = 36
                cboConcepto.Visible = False
                Label7.Visible = False

        End Select
    End Sub

    Private Sub cboSeccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.SelectedIndexChanged
        Dim id As Integer
        If cboSeccion.SelectedIndex = 0 Then
            id = -1
        Else
            If cboSeccion.SelectedValue Is Nothing Then
                id = DirectCast(cboSeccion.SelectedItem, ItemLista).ID
            Else
                id = Convert.ToInt32(cboSeccion.SelectedValue.ToString)
            End If
            ''id = Convert.ToInt32(cboSeccion.SelectedValue.ToString) ''DirectCast(cboSeccion.SelectedItem, ItemLista).ID
        End If
        If MedioActual = Medios.Exterior Then
            Envio.id_Provincia = id
        Else
            Envio.id_Seccion = id
        End If

    End Sub

    Private Sub cboConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.SelectedIndexChanged
        If cboConcepto.SelectedIndex = 0 Then
            Envio.Concepto = ""
        Else
            Envio.Concepto = DirectCast(cboConcepto.SelectedItem, ItemLista).ID
        End If

        'If Envio.Concepto <> "" And cboConcepto.Text <> "--- NINGUNO ---" Then
        '    conceptoSeleccionado = cboConcepto.Text
        'End If
    End Sub

    Private Sub cboProducto_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProducto.AfterCloseUp
        If Not cboProducto.SelectedRow Is Nothing Then
            Envio.Id_Producto = cboProducto.SelectedRow.Cells(1).Value
            'AG Produccion +++++++++++++++++++++++++++++++++++++++
            If MedioActual = Medios.Produccion Then
                cboTarget_AfterCloseUp(Nothing, Nothing)
            End If
            If MedioActual = Medios.Internet Then
                If cmdSiguiente.Enabled = False Then
                    cmdSiguiente.Enabled = True
                    cmdAnterior.Enabled = False
                End If
            End If

            '++++++++++++++++++++++++++++++++++++++++++++++++++++
        End If
    End Sub

    Private Sub cboTarget_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTarget.AfterCloseUp
        'AG Produccion ++++++++++++++++++++++++++++++++
        If MedioActual <> Medios.Produccion Then
            If cboTarget.SelectedRow Is Nothing Then
                Exit Sub
            End If
        End If

        If MedioActual <> Medios.Produccion Then
            Envio.Id_Target = Me.cboTarget.SelectedRow.Cells("Id_Target_1").Value
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG Codigo Anterior ++++++++++++++++++++++++++++++++++++++
        'Envio.Id_Target = Me.cboTarget.SelectedRow.Cells("Id_Target_1").Value
        '++++++++++++++++++++++++++++++++++++++++++++++++++++

        'Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable
        Select Case MedioActual
            Case Medios.Radio, Medios.Tv
                If Not cboTarget.Value Is Nothing Then
                    Envio.Id_Target = cboTarget.Value
                    dt = Envio.TraerProductos
                    dt = dt.Select("", "DESCRIPCION2 ASC").CopyToDataTable()

                    If dt.Rows.Count <> 0 Then
                        Listas.CargarCombo(Me.cboProducto, dt, "Id_producto", "descripcion2")
                        Listas.OcultarColumnas(Me.cboProducto, "Id_cliente", "Id_producto", "descripcion", "fechafin")
                        Listas.OcultarHeader(Me.cboProducto)
                    Else
                        Mensajes.Mensaje("No hay productos comprados para este filtro", TipoMensaje.Informacion)
                        iugTemasxSop.DataSource = Nothing
                        iugEjercicios.DataSource = Nothing
                        cboProducto.DataSource = Nothing
                        iugEjercicios.DataSource = Nothing
                        iugTemasxSop.DataSource = Nothing
                        If Not Ultra Is Nothing Then
                            Ultra.Rows.Clear()
                        End If
                    End If
                    iugEjercicios.DataSource = Nothing
                    iugTemasxSop.DataSource = Nothing
                    cmdSiguiente.Enabled = SiguienteHabilitado()
                End If
            Case Medios.Exterior, Medios.Revista, Medios.Prensa, Medios.Produccion 'AG Produccion +++++++++++++++++
                If Not cboProducto.Value Is Nothing Then
                    Envio.Id_Producto = cboProducto.Value

                    Envio.Id_Tipo_Soporte = Me.cboTipoSoporte.SelectedRow.Cells("id_tipo_soporte").Value

                    'AG Codigo Anterior 16/09/2011 +++++++++++++++++++++++++++++
                    'If MedioActual = Medios.Exterior Then
                    '    dt = Envio.TraerSistemasEjerciciosExterior
                    'Else
                    '    dt = Envio.TraerSistemasEjerciciosMedios
                    'End If
                    '++++++++++++++++++++++++++++++++++++++++++++++++++++

                    'AG Produccion ++++++++++++++++++++++++++++++++
                    Select Case MedioActual
                        Case Medios.Exterior
                            dt = Envio.TraerSistemasEjerciciosExterior
                        Case Medios.Revista, Medios.Prensa
                            dt = Envio.TraerSistemasEjerciciosMedios
                        Case Medios.Produccion
                            dt = Envio.TraerSistemasEjerciciosProduccion
                    End Select
                    '+++++++++++++++++++++++++++++++++++++++++++

                    If dt.Rows.Count <> 0 Then
                        iugEjercicios.DataSource = dt
                    Else
                        If TodosLosCamposOk() Then
                            Mensajes.Mensaje("No hay Ejercicios para este filtro", TipoMensaje.Informacion)
                            iugEjercicios.DataSource = Nothing
                            iugTemasxSop.DataSource = Nothing
                            If Not Ultra Is Nothing Then
                                Ultra.Rows.Clear()
                            End If
                        End If
                    End If
                    If Me.cboMateriales.SelectedRow Is Nothing Then
                        Exit Sub
                    End If
                    Envio.Id_Material = IIf(Me.cboMateriales.SelectedRow.Cells(0).Text = "Ninguno", "", Me.cboMateriales.SelectedRow.Cells(0).Text)
                    cmdSiguiente.Enabled = SiguienteHabilitado()
                End If
        End Select

        Me.Cursor = Cursors.Default
    End Sub

    Private Function ConcatenarSoportes() As String
        Dim ret As String = ""
        'Jose...hay que revisar esta parte que despues cuando arma el DT recorre los soportes y esta repitiendo valores al ir a buscar cada vez los datos a la base
        If lstSoportes.CheckedItems.Count = 0 Then
            For Each l As ItemLista In lstSoportes.Items
                ret &= DirectCast(l, ItemLista).ID & ","
            Next
        Else
            For Each l As ItemLista In lstSoportes.CheckedItems
                ret &= DirectCast(l, ItemLista).ID & ","
            Next
        End If
        Return ret.Substring(0, ret.Length - 1)
    End Function

    Private Function SoportesValues() As ArrayList
        Dim ret As String = ""
        Dim _returnValues As New ArrayList

        If lstSoportes.CheckedItems.Count = 0 Then
            For Each l As ItemLista In lstSoportes.Items
                _returnValues.Add(l.ID)
                ''ret &= DirectCast(l, ItemLista).ID & ","
            Next
        Else
            For Each l As ItemLista In lstSoportes.CheckedItems
                _returnValues.Add(l.ID)
                ''ret &= DirectCast(l, ItemLista).ID & ","
            Next
        End If

        Return _returnValues
        ''Return ret.Substring(0, ret.Length - 1)
    End Function

    Private Sub lstSoportes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSoportes.SelectedIndexChanged
        SeleccionarSoportes()
    End Sub

    Private Sub SeleccionarSoportes()
        Dim idSop As String = ConcatenarSoportes()
        Dim _dtData As DataTable = Activo.DTSoportesCache.Clone()
        Dim _soportesList As ArrayList = Me.SoportesValues()

        For index As Integer = 0 To _soportesList.Count - 1
            For Each row As DataRow In Activo.DTSoportesCache.Select("id_soporte =" & _soportesList.Item(index))
                _dtData.ImportRow(row)
                Exit For
            Next
        Next

        If _soportesList.Count <> 0 Then
            If MedioActual = Medios.Prensa Or MedioActual = Medios.Revista Then
                Listas.CargarCombo(Me.cboSeccion, Listas.FiltrarDT(dsSop.Tables(1), "id_soporte in (" & idSop & ")"), "idSeccion", "Seccion", True)
                cboSeccion.SelectedIndex = 0
                Listas.CargarCombo(Me.cboConcepto, Listas.FiltrarDT(dsSop.Tables(2), "id_soporte in (" & idSop & ")"), "Concepto", "Concepto", True)
                cboConcepto.SelectedIndex = 0
            Else
                Me.cboSeccion.DisplayMember = "des_cobertura"
                Me.cboSeccion.ValueMember = "Cod_cobertura"
                Me.cboSeccion.DataSource = _dtData

                ''Listas.CargarCombo(Me.cboSeccion, Listas.FiltrarDT(dsSop.Tables(1), "id_soporte in (" & idSop & ")"), "id_provincia", "provincia", True)
                Me.cboSeccion.SelectedIndex = 0

            End If
        End If
    End Sub

    Private Function FormatDataTable(ByVal dtSeccion As DataTable) As DataTable
        For i As Integer = 1 To dtSeccion.Rows.Count


        Next
    End Function

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

    Public Function InsertarOrdenesTV(ByVal dtValue As DataTable, ByVal CampaniaMMS As Integer, ByVal SubCampaniaMms As Integer, ByVal codPais As Integer, ByVal IdUsuario As Integer, ByVal CampaniaActual As Integer) As DataTable

        _result = Envio.InsertaAvisosMMS(dtValue, CampaniaMMS, SubCampaniaMms, codPais, IdUsuario, CampaniaActual, Activo.IDCliente)

        If dtResult Is Nothing Then
            dtResult = _result.Clone()
        End If

        If _result.Rows.Count <> 0 Then
            For Each row As DataRow In _result.Rows

            Next
        End If

        dtResult = _result

        Return dtResult

    End Function

#Region "Metodos"

#End Region

    'Delegado
    Delegate Sub CambiarTextoMarquee_Delegate(ByVal [Marquee] As MarqueeProgressBarControl, ByVal [text] As String)

    'La subrutina del delegado - Al usar backgroundWorker necesitamos que la interacción entre threads sea segura
    Private Sub CambiarTextoMarquee_ThreadSafe(ByVal [Marquee] As MarqueeProgressBarControl, ByVal [text] As String)
        ' InvokeRequired comprar el ID del thread que realiza la llamada con el del que fue creado.
        ' Si son distintos, devuelte true
        If [Marquee].InvokeRequired Then
            Dim MyDelegate As New CambiarTextoMarquee_Delegate(AddressOf CambiarTextoMarquee_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[Marquee], [text]})
        Else
            [Marquee].Text = [text]
        End If
    End Sub

    Private Sub bgwEnvioCompras_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles bgwEnvioCompras.Disposed

    End Sub

    Private Sub bgwEnvioCompras_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwEnvioCompras.DoWork
        EnviarACompras2()
    End Sub

    Private Function GetTotalOrdenesInternet(ByVal datos As DataTable) As Integer
        Dim total As Integer = 0
        For Each dato As DataRow In datos.Rows
            If datos.Columns.IndexOf("TOTAL_ORDENES") <> -1 Then
                total = total + dato("TOTAL_ORDENES")
            End If
        Next
        Return total
    End Function

    Private Sub bgwEnvioCompras_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwEnvioCompras.ProgressChanged

    End Sub

    Private Sub bgwEnvioCompras_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwEnvioCompras.RunWorkerCompleted
        mpbEnvioCompras.Enabled = False
        mpbEnvioCompras.Properties.ShowTitle = False
        cmdCerrar.Enabled = True
        If dtResultEnvio Is Nothing Then
            'AN 21-03-2016 AGREGADO A PEDIDO DE GUZZARDI.
            Me.cmdAnterior.Enabled = True
            Exit Sub
        End If
        If dtResultEnvio.Rows.Count > 0 Or Not dtResultEnvioDoble Is Nothing Then
            Dim cantidadOrdenes As Integer

            ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN) Y AGREGO INTERNET (AN 16-09-2015)
            If Activo.IDMedio = 1 Then
                cantidadOrdenes = dtResultEnvio.Rows(0)("TOTAL_ORDENES")
            ElseIf Activo.IDMedio = 2 And Not dtResultEnvioDoble Is Nothing Then
                If dtResultEnvioDoble.Rows.Count > 0 Then
                    cantidadOrdenes = cantidadAvisosSocialyse + (GetTotalOrdenesInternet(dtResultEnvioDoble) * 2) ' son 2 companias
                Else
                    cantidadOrdenes = dtResultEnvio.Rows.Count
                End If
            Else
                cantidadOrdenes = dtResultEnvio.Rows.Count
            End If

            Dim sMensaje As String = "Se insertaron " & cantidadOrdenes & " avisos con éxito! "

            'AG 05/01/2015 Comentar para quitar envio mail y contrato ==================================
            If dtResultEnvio.Columns.Contains("id_contrato") Then
                Dim view As New DataView(dtResultEnvio)
                'LC 24/07/2014 Envio mail con los contratos
                Dim contratos As DataTable = view.ToTable(True, "id_contrato", "datos_mail")
                For Each fila As DataRow In contratos.Rows
                    Dim frmMail As New frmMailFax
                    If frmMail.ObtenerMailUsuario() <> String.Empty Then
                        frmMail.Contrato = fila.Item("id_contrato")
                        frmMail.Parametros = fila.Item("datos_mail")
                        frmMail.ShowDialog()
                    Else
                        MsgBox("El usuario no posee un mail", MsgBoxStyle.Information, AcceptButton)
                    End If
                Next
            End If

            ' AGREGO PRESUPUESTOS PARA MOSTRAR EN PANTALLA PARA ENVIO INTERNET SOCIALYSE (AN 24-09-2015)
            'LC 02/07/2014 Envio a compras avisos digital Emitidos y con contrato
            Dim sContratos As String = String.Empty
            Dim sPresupuestos As String = String.Empty
            For Each envio As DataRow In dtResultEnvio.Rows
                If dtResultEnvio.Columns.Contains("id_contrato") Then
                    If Not sContratos.Contains(envio.Item("id_contrato").ToString()) Then
                        sContratos += envio.Item("id_contrato").ToString() + ", "
                    End If
                    If Not sPresupuestos.Contains(envio.Item("id_presupuesto").ToString()) Then
                        sPresupuestos += envio.Item("id_presupuesto").ToString() + ", "
                    End If
                End If
            Next
            If sContratos <> String.Empty Then
                sContratos = sContratos.Remove(sContratos.Length - 2, 2)
                sMensaje += Environment.NewLine + "Se insertaron los siguientes contratos: " + sContratos
            End If
            If sPresupuestos <> String.Empty Then
                sPresupuestos = sPresupuestos.Remove(sPresupuestos.Length - 2, 2)
            End If

            If Activo.IDMedio = 2 Then
                ' NUEVO DESARROLLO ENVIO INTERNET LIGERO (AN 23-09-2015)
                Dim frmMessage As New frmMessage
                If Not dtResultEnvioDoble Is Nothing And dtResultEnvioDoble.Rows.Count > 0 And dtResultEnvioDoble.Columns.IndexOf("TOTAL_ORDENES") <> -1 Then
                    frmMessage.Body = GetBodyMessageSocialyse(dtResultEnvioDoble, cantidadOrdenes, sContratos, sPresupuestos)
                Else
                    frmMessage.Body = sMensaje
                End If
                frmMessage.ShowDialog()
            Else
                MsgBox(sMensaje, MsgBoxStyle.Information, AcceptButton)
            End If

            'AGuzzardi 11/06/2010 Solo se DeHabilita el boton Anterior para el medio Prensa y Revista ------
            If Activo.IDMedio = 4 Or Activo.IDMedio = 5 Then
                Me.cmdAnterior.Enabled = False
            Else
                Me.cmdAnterior.Enabled = True
            End If
        Else
            MsgBox("Se insertaron " & Me.dtResultEnvio.Rows.Count & " avisos con éxito! ")
        End If
    End Sub

    Private Function FillTo8(ByVal cadena As String) As String
        cadena = cadena & Space(8 - cadena.Length)
        Return cadena        
    End Function

    Private Function GetBodyMessageSocialyse(ByVal datos As DataTable, ByVal cantidadOrdenes As Integer, ByVal contratos As String, ByVal presupuestos As String) As String
        Dim message As StringBuilder
        Dim errorMessage As StringBuilder
        Dim companiaActual As String
        message = New StringBuilder
        errorMessage = New StringBuilder
        companiaActual = Me._maestro.ObtenerDescripcionCompaniaActual().Split(" ")(0)

        With message
            .Append("Se insertaron " & cantidadOrdenes & " avisos con éxito! ")
            .Append(vbNewLine)
            .Append("Detalle del envio a compras:")
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("COMPANIA")
            .Append(vbTab)
            .Append("PRESUPUESTO")
            .Append(vbTab)
            .Append("CONTRATO")
            .Append(vbNewLine)

            ' Estos contratos vienen del envio de SOCIALYSE.
            For Each dato As DataRow In datos.Rows
                If dato(9) = "-1" Then
                    .Append(FillTo8(dato(3)))
                    .Append(vbTab)
                    .Append(vbTab)
                    .Append(FillTo8(dato(1)))
                    .Append(vbTab)
                    .Append(vbTab)
                    .Append(FillTo8(dato(2)))
                    .Append(vbNewLine)
                Else
                    errorMessage.AppendLine(dato(9))
                End If
            Next            

            ' Estos contratos vienen del envio NORMAL.
            If Not String.IsNullOrEmpty(contratos) Then
                For Each contrato As String In contratos.Split(",")
                    .Append(FillTo8(companiaActual))
                    .Append(vbTab)
                    .Append(vbTab)
                    .Append(FillTo8(presupuestos))
                    .Append(vbTab)
                    .Append(vbTab)
                    .Append(FillTo8(contrato))
                    .Append(vbNewLine)
                Next
            End If

            ' Estos contratos vienen del envio de SOCIALYSE.
            For Each dato As DataRow In datos.Rows
                If dato(9) = "-1" Then
                    .Append(FillTo8(dato(7)))
                    .Append(vbTab)
                    .Append(vbTab)
                    .Append(FillTo8(dato(5)))
                    .Append(vbTab)
                    .Append(vbTab)
                    .Append(FillTo8(dato(6)))
                    .Append(vbNewLine)
                End If
            Next

            ' Muestro mensaje de error de Socialyse
            If Not String.IsNullOrEmpty(errorMessage.ToString()) Then
                .Append(vbNewLine)
                .Append(vbNewLine)
                .Append("Errores del envio a compras:")
                .Append(vbNewLine)
                .Append(errorMessage)
                .Append(vbNewLine)
                .Append(vbNewLine)
            End If
        End With

        Return message.ToString()
    End Function

    Private Sub iugTemasxSop_AfterCardsScroll(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterCardsScrollEventArgs) Handles iugTemasxSop.AfterCardsScroll

    End Sub

    Private Sub chkSelAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelAll.CheckedChanged
        Dim i, j, k, x As Integer
        Dim Temaseleccionado As Boolean = False
        Dim ChildR As UltraDataRowsCollection
        Dim ChildTemas As UltraDataRowsCollection

        Select Case MedioActual
            Case Medios.Radio, Medios.Tv
                If Not Ultra Is Nothing Then
                    k = 0

                    While k < Ultra.Rows.Count
                        ChildR = Ultra.Rows(k).GetChildRows("Soportes")
                        j = 0                        
                        While j < ChildR.Count
                            ChildTemas = Ultra.Rows(k).GetChildRows("Soportes")(j).GetChildRows("Temas")
                            x = 0
                            While x < ChildTemas.Count
                                ChildTemas.Item(x).SetCellValue("Ok", chkSelAll.CheckState)
                                x = x + 1
                            End While
                            ChildR.Item(j).SetCellValue("Todos", chkSelAll.CheckState)
                            j += 1
                        End While
                        k += 1
                    End While
                End If

                If chkSelAll.Checked Then
                    chkSelAll.Text = "Deseleccionar Todos"
                    TildarTodosGrillaSoporteTemas(chkSelAll.Checked) 'AG 01/11/2016
                Else
                    chkSelAll.Text = "Seleccionar Todos"
                    TildarTodosGrillaSoporteTemas(chkSelAll.Checked) 'AG 01/11/2016
                End If
            Case Medios.Prensa, Medios.Revista
                If Not cboProducto.SelectedRow Is Nothing Then

                    If lstSoportes.Items.Count > 0 Then
                        For i = 0 To lstSoportes.Items.Count - 1
                            lstSoportes.SetItemCheckState(i, chkSelAll.CheckState)
                        Next

                        If chkSelAll.Checked Then
                            chkSelAll.Text = "Deseleccionar Todos"
                        Else
                            chkSelAll.Text = "Seleccionar todos"
                        End If

                    End If

                End If
            Case Medios.Exterior
                If Not cboProducto.SelectedRow Is Nothing Then

                    If lstSoportes.Items.Count > 0 Then
                        For i = 0 To lstSoportes.Items.Count - 1
                            lstSoportes.SetItemCheckState(i, chkSelAll.CheckState)
                        Next

                        If chkSelAll.Checked Then
                            chkSelAll.Text = "Deseleccionar Todos"
                        Else
                            chkSelAll.Text = "Seleccionar todos"
                        End If

                    End If

                End If

            Case Medios.Internet
                If Not cboProducto.SelectedRow Is Nothing Then

                    If lstSoportes.Items.Count > 0 Then
                        For i = 0 To lstSoportes.Items.Count - 1
                            lstSoportes.SetItemCheckState(i, chkSelAll.CheckState)
                        Next

                        If chkSelAll.Checked Then
                            chkSelAll.Text = "Deseleccionar Todos"
                        Else
                            chkSelAll.Text = "Seleccionar todos"
                        End If
                    End If
                End If

            Case Medios.Produccion
                If Not cboProducto.SelectedRow Is Nothing Then
                    If lstSoportes.Items.Count > 0 Then
                        For i = 0 To lstSoportes.Items.Count - 1
                            lstSoportes.SetItemCheckState(i, chkSelAll.CheckState)
                        Next

                        If chkSelAll.Checked Then
                            chkSelAll.Text = "Deseleccionar Todos"
                        Else
                            chkSelAll.Text = "Seleccionar todos"
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Function CargarDtConveniosVigentes(ByVal Dt As DataTable, ByVal dtConvenios As DataTable, ByVal idmedio As Integer) As DataTable

        Dim dr As DataRow

        If dtConvenios Is Nothing OrElse dtConvenios.Rows.Count = 0 Then
            dtConvenios = Dt.Clone
        End If

        For Each dr In Dt.Rows
            dtConvenios.ImportRow(dr)
        Next

        Return dtConvenios

    End Function

    Private Sub TildarTodosGrillaSoporteTemas(ByVal Valor)

        If Not iugTemasxSop Is Nothing Then
            For Each r As UltraGridRow In iugTemasxSop.Rows
                r.Cells("Todos").Value = Valor
            Next
        End If

    End Sub

    Private Sub iugTemasxSop_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugTemasxSop.CellChange

        Dim ChildR As UltraDataRowsCollection
        Dim ChildTemas As UltraDataRowsCollection
        Dim j As Integer
        Dim x As Integer
        Dim o As Integer = iugTemasxSop.ActiveRow.Index

        If iugTemasxSop.ActiveCell.Band.Key = "Band 0" Then

            If e.Cell.Column.Key = "Todos" Then

                Dim k As Integer = iugTemasxSop.ActiveRow.Index
                Dim valor As Boolean = iugTemasxSop.ActiveRow.Cells("Todos").Value

                ChildR = Ultra.Rows(k).GetChildRows("Soportes")
                j = 0
                While j < ChildR.Count

                    ChildTemas = ChildR.Item(j).GetChildRows("Temas")
                    x = 0
                    While x < ChildTemas.Count
                        If valor = True Then
                            ChildTemas.Item(x).SetCellValue("OK", False)
                            iugTemasxSop.ActiveRow.Cells("Todos").Value = False
                            x += 1
                        Else
                            ChildTemas.Item(x).SetCellValue("OK", True)
                            iugTemasxSop.ActiveRow.Cells("Todos").Value = True
                            x += 1
                        End If
                    End While

                    If valor = True Then
                        ChildR.Item(j).SetCellValue("Todos", False)
                        iugTemasxSop.ActiveRow.Cells("Todos").Value = False
                        j += 1
                    Else
                        ChildR.Item(j).SetCellValue("Todos", True)
                        iugTemasxSop.ActiveRow.Cells("Todos").Value = True
                        j += 1
                    End If
                End While
            End If

        ElseIf iugTemasxSop.ActiveCell.Band.Key = "Soportes" Then

            If e.Cell.Column.Key = "Todos" Then

                Dim i As Integer = iugTemasxSop.ActiveRow.ParentRow.Index
                Dim k As Integer = iugTemasxSop.ActiveRow.Index
                Dim valor As Boolean = iugTemasxSop.ActiveRow.Cells("Todos").Value

                ChildR = Ultra.Rows(i).GetChildRows("Soportes")(k).GetChildRows("Temas")
                j = 0
                While j < ChildR.Count
                    If valor = True Then
                        ChildR.Item(j).SetCellValue("OK", False)
                        iugTemasxSop.ActiveRow.Cells("Todos").Value = False
                        j += 1
                    Else
                        ChildR.Item(j).SetCellValue("OK", True)
                        iugTemasxSop.ActiveRow.Cells("Todos").Value = True
                        j += 1
                    End If
                End While
            End If

        ElseIf iugTemasxSop.ActiveCell.Band.Key = "Temas" Then
            Dim oo As Integer = iugTemasxSop.ActiveRow.ParentRow.Index

            If e.Cell.Column.Key = "Ok" Then
                Dim aplicar As Boolean

                ChildR = Ultra.Rows(oo).GetChildRows("Soportes")
                j = 0

                Dim valor As Boolean = iugTemasxSop.ActiveRow.Cells("Ok").Value

                If valor = False Then
                    e.Cell.Row.ParentRow.Cells("Todos").Value = True
                Else
                    e.Cell.Row.ParentRow.Cells("Todos").Value = False
                End If
            End If
        End If
    End Sub

    Private Sub iugTemasxSop_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugTemasxSop.InitializeLayout
        chkSelAll.Visible = True
        chkSelAll.Checked = True
        chkSelAll.Text = "Borrar selección de todos"
    End Sub

    Private Function CargarDtTarifasVigentes(ByVal Dt As DataTable, ByVal dtTarifas As DataTable, ByVal idmedio As Integer) As DataTable

        Dim dr As DataRow

        If dtTarifas Is Nothing OrElse dtTarifas.Rows.Count = 0 Then
            dtTarifas = Dt.Clone
        End If

        For Each dr In Dt.Rows
            dtTarifas.ImportRow(dr)
        Next

        Return dtTarifas

    End Function

#Region "Funciones de PA"

    Private Function ObtenerAvisosFiltradosXmesPA(ByVal Dt As DataTable, ByVal Anio As Integer, ByVal mes As Integer) As DataTable

        Dim DtFiltradoAvisos As New DataTable
        DtFiltradoAvisos = Dt.Clone
        DtFiltradoAvisos.Columns.Add("PresupuestoPC", GetType(Integer))
        Dim DtSoportes As DataTable = Dt.DefaultView.ToTable(True, "SOPORTE")
        Dt.DefaultView.Sort = "SOPORTE ASC"

        'AG 20/08/2013 = Codigo Anterior ================================================================================================
        'For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
        '    If RowPresupuesto.Cells("Sel").Value = True Then
        '        For Each rowAviosPA As DataRow In Dt.Rows
        '            If CInt(Convert.ToDateTime(rowAviosPA.Item("f_spot")).Month.ToString) = CInt(RowPresupuesto.Cells("Mes").Value) Then
        '                DtFiltradoAvisos.ImportRow(rowAviosPA)
        '            End If
        '        Next
        '    End If
        'Next
        '===============================================================================================================================

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True And RowPresupuesto.Cells("id_presupuesto").Value = -1 Then
                For Each rowAviosPA As DataRow In Dt.Rows
                    'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
                    'If CInt(Convert.ToDateTime(rowAviosPA.Item("f_spot")).Month.ToString) = CInt(RowPresupuesto.Cells("Mes").Value) Then
                    If CInt(rowAviosPA.Item("MES")) = CInt(RowPresupuesto.Cells("Mes").Value) Then
                        DtFiltradoAvisos.ImportRow(rowAviosPA)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================
        
        'AG 20/08/2013 = Codigo Anterior ================================================================================================
        'For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
        '    If RowPresupuesto.Cells("Sel").Value = True Then
        '        For Each dr As DataRow In DtFiltradoAvisos.Rows
        '            If CInt(dr("mes")) = CInt(RowPresupuesto.Cells("Mes").Value) Then
        '                dr("PresupuestoPC") = CInt(RowPresupuesto.Cells("id_presupuesto").Value)
        '            End If
        '        Next
        '    End If
        'Next
        '================================================================================================================================

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True Then
                For Each dr As DataRow In DtFiltradoAvisos.Rows
                    If CInt(dr("mes")) = CInt(RowPresupuesto.Cells("Mes").Value) And CInt(RowPresupuesto.Cells("id_presupuesto").Value) = -1 Then
                        dr("PresupuestoPC") = CInt(RowPresupuesto.Cells("id_presupuesto").Value)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================

        DtFiltradoAvisos.DefaultView.Sort = "MES DESC"

        Return DtFiltradoAvisos

    End Function

    Private Function ObtenerAvisosFiltradosPA(ByVal Dt As DataTable, ByVal Anio As Integer, ByVal mes As Integer) As DataTable

        Dim DtFiltradoAvisos As New DataTable
        DtFiltradoAvisos = Dt.Clone
        DtFiltradoAvisos.Columns.Add("PresupuestoPC", GetType(Integer))
        Dim DtSoportes As DataTable = Dt.DefaultView.ToTable(True, "SOPORTE")
        Dt.DefaultView.Sort = "SOPORTE ASC"

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True And Not RowPresupuesto.Cells("Cod_PresupuestoPA").Value Is DBNull.Value Then
                For Each rowAviosPA As DataRow In Dt.Rows
                    If CInt(rowAviosPA.Item("MES")) = CInt(RowPresupuesto.Cells("Mes").Value) Then
                        DtFiltradoAvisos.ImportRow(rowAviosPA)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True Then
                For Each dr As DataRow In DtFiltradoAvisos.Rows
                    If CInt(dr("mes")) = CInt(RowPresupuesto.Cells("Mes").Value) And Not RowPresupuesto.Cells("Cod_PresupuestoPA").Value Is DBNull.Value Then
                        dr("PresupuestoPC") = CInt(RowPresupuesto.Cells("id_presupuesto").Value)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================

        DtFiltradoAvisos.DefaultView.Sort = "MES DESC"

        Return DtFiltradoAvisos

    End Function

    Private Function ObtenerAvisosFiltradosXmesPANoTv(ByVal Dt As DataTable, ByVal Anio As Integer, ByVal mes As Integer) As DataTable

        Dim DtFiltradoAvisos As New DataTable
        DtFiltradoAvisos = Dt.Clone
        DtFiltradoAvisos.Columns.Add("Mes", GetType(Integer))
        DtFiltradoAvisos.Columns.Add("Anio", GetType(Integer))
        DtFiltradoAvisos.Columns.Add("PresupuestoPC", GetType(Integer))
        Dim DtSoportes As DataTable = Dt.DefaultView.ToTable(True, "CODIGOSOPORTE")

        Dt.DefaultView.Sort = "CODIGOSOPORTE ASC"

        'AG 20/08/2013 = Codigo Anterior ================================================================================================
        'For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
        '    If RowPresupuesto.Cells("Sel").Value = True Then
        '        For Each rowAviosPA As DataRow In Dt.Rows
        '            If CInt(Convert.ToDateTime(rowAviosPA.Item("f_spot")).Month.ToString) = CInt(RowPresupuesto.Cells("Mes").Value) Then
        '                DtFiltradoAvisos.ImportRow(rowAviosPA)
        '            End If
        '        Next
        '    End If
        'Next
        '===============================================================================================================================

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True And RowPresupuesto.Cells("id_presupuesto").Value = -1 Then
                For Each rowAviosPA As DataRow In Dt.Rows
                    If CInt(Convert.ToDateTime(rowAviosPA.Item("f_spot")).Month.ToString) = CInt(RowPresupuesto.Cells("Mes").Value) Then
                        DtFiltradoAvisos.ImportRow(rowAviosPA)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================


        For Each dr As DataRow In DtFiltradoAvisos.Rows
            dr("Mes") = Convert.ToDateTime(dr("f_spot")).Month
            dr("Anio") = Convert.ToDateTime(dr("f_spot")).Year
        Next

        'AG 20/08/2013 = Codigo Anterior ================================================================================================
        'For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
        '    If RowPresupuesto.Cells("Sel").Value = True Then
        '        For Each dr As DataRow In DtFiltradoAvisos.Rows
        '            If CInt(dr("mes")) = CInt(RowPresupuesto.Cells("Mes").Value) Then
        '                dr("PresupuestoPC") = CInt(RowPresupuesto.Cells("id_presupuesto").Value)
        '            End If
        '        Next
        '    End If
        'Next
        '================================================================================================================================

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True Then
                For Each dr As DataRow In DtFiltradoAvisos.Rows
                    If CInt(dr("mes")) = CInt(RowPresupuesto.Cells("Mes").Value) And CInt(RowPresupuesto.Cells("id_presupuesto").Value) = -1 Then
                        dr("PresupuestoPC") = CInt(RowPresupuesto.Cells("id_presupuesto").Value)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================

        DtFiltradoAvisos.DefaultView.Sort = "MES DESC"

        Return DtFiltradoAvisos

    End Function

    Private Function ObtenerAvisosFiltradosPANoTv(ByVal Dt As DataTable, ByVal Anio As Integer, ByVal mes As Integer) As DataTable

        Dim DtFiltradoAvisos As New DataTable
        DtFiltradoAvisos = Dt.Clone
        DtFiltradoAvisos.Columns.Add("Mes", GetType(Integer))
        DtFiltradoAvisos.Columns.Add("Anio", GetType(Integer))
        DtFiltradoAvisos.Columns.Add("PresupuestoPC", GetType(Integer))
        Dim DtSoportes As DataTable = Dt.DefaultView.ToTable(True, "CODIGOSOPORTE")

        Dt.DefaultView.Sort = "CODIGOSOPORTE ASC"

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True And Not RowPresupuesto.Cells("Cod_PresupuestoPA").Value Is DBNull.Value Then
                For Each rowAviosPA As DataRow In Dt.Rows
                    If CInt(Convert.ToDateTime(rowAviosPA.Item("f_spot")).Month.ToString) = CInt(RowPresupuesto.Cells("Mes").Value) Then
                        DtFiltradoAvisos.ImportRow(rowAviosPA)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================


        For Each dr As DataRow In DtFiltradoAvisos.Rows
            dr("Mes") = Convert.ToDateTime(dr("f_spot")).Month
            dr("Anio") = Convert.ToDateTime(dr("f_spot")).Year
        Next

        'AG 20/08/2013 = Solo filtra los presupuesto que esten tildados y que sean -1 el presupuesto ====================================
        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True Then
                For Each dr As DataRow In DtFiltradoAvisos.Rows
                    If CInt(dr("mes")) = CInt(RowPresupuesto.Cells("Mes").Value) And Not RowPresupuesto.Cells("Cod_PresupuestoPA").Value Is DBNull.Value Then
                        dr("PresupuestoPC") = CInt(RowPresupuesto.Cells("id_presupuesto").Value)
                    End If
                Next
            End If
        Next
        '=================================================================================================================================

        DtFiltradoAvisos.DefaultView.Sort = "MES DESC"

        Return DtFiltradoAvisos

    End Function

    Private Function CalcularTotalesXSoporteEnvio(ByVal DtFitradoAvisos As DataTable) As DataTable

        Dim id_campania As Integer = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
        Dim id_subcampania As Integer = CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value)
        Dim DrSoporte, DrAvisos, FilaNueva As DataRow
        Dim DtSoportesPauta As New DataTable
        Dim OSoporte As New Soportes

        DtSoportesPauta = ArmarEstructuraDtSoportesPauta(DtSoportesPauta)
        Dim DtSoportes As DataTable = DtFitradoAvisos.DefaultView.ToTable(True, "SOPORTE", "MEDIO", "MES", "ANIO", "EJERCICIO", "SISTEMA", "PRODUCTO", "TEMA", "FECHADESDE", "FECHAHASTA", "PRESUPUESTO")
        Dim Rows() As DataRow
        Dim DtOrdenado As New DataTable
        DtOrdenado = DtSoportesPauta.Clone

        For Each DrSoporte In DtSoportes.Rows
            FilaNueva = DtSoportesPauta.NewRow
            FilaNueva("anio") = DrSoporte("ANIO")
            FilaNueva("mes") = DrSoporte("MES")
            Rows = DtFitradoAvisos.Select("SOPORTE = " & DrSoporte("SOPORTE") & "AND MES = " & DrSoporte("MES"))
            FilaNueva("PresupuestoPC") = CInt(Rows(0)("PresupuestoPC").ToString)
            FilaNueva("cod_soporte") = DrSoporte("SOPORTE")
            With OSoporte
                .Id_medio = DrSoporte("MEDIO")
                FilaNueva("soporte") = .ObtenerDescripcion(FilaNueva("cod_soporte"))
            End With
            Dim oEnvioComprasLigero As New Envio_Ligero_MMS
            Dim retorno As DataTable = oEnvioComprasLigero.Obtener_Total_Soportes_PA_TV(Activo.IDCampaña, DrSoporte("SISTEMA"), DrSoporte("EJERCICIO"), DrSoporte("PRODUCTO"), DrSoporte("SOPORTE"), DrSoporte("TEMA"), DrSoporte("FECHADESDE"), DrSoporte("FECHAHASTA"), DrSoporte("MES"), DrSoporte("ANIO"), Activo.CodCampaniaActualMms, id_subcampania, id_campania, DrSoporte("PRESUPUESTO"))

            'NUEVO DESARROLLO DE ENVIO LIGERO (AN 07-09-2015)
            If Not retorno Is Nothing And retorno.Rows.Count > 0 Then 'SE CORRIJE BUG CUANDO LA TABLA NO DEVUELVE FILAS. (AN 14-03-2016)
                FilaNueva("TotalSoporteEnvio") = retorno.Rows(0)("IMPORTE_COMPRA_NETO_MMS")
            Else
                FilaNueva("TotalSoporteEnvio") = 0
            End If

            DtSoportesPauta.Rows.Add(FilaNueva)
        Next
        DtSoportesPauta.DefaultView.Sort = ("Mes")

        Return DtSoportesPauta

    End Function

    Private Function QuitarMesNOSeleccionadoPA(ByVal Dt As DataTable) As DataTable

        Dim DtTemp As New DataTable
        Dim Rows() As DataRow

        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = False And Not RowPresupuesto.Cells("Cod_PresupuestoPA").Value Is DBNull.Value Then
                Rows = Dt.Select("PresupuestoPC = " & CInt(RowPresupuesto.Cells("id_Presupuesto").Value) & " AND mes = " & RowPresupuesto.Cells("Mes").Value & " AND Anio = " & CInt(RowPresupuesto.Cells("ano").Value))
                If Rows.Length = 1 Then
                    Dt.Rows.Remove(Rows(0))
                End If

            End If
        Next

        Dt = QuitaRegistrosBasura(Dt)
        Return Dt

    End Function

    Private Function QuitaRegistrosBasura(ByVal dt As DataTable) As DataTable

        Dim DtFiltro As DataTable = dt.DefaultView.ToTable(True, "anio", "mes")
        Dim Rows() As DataRow
        Dim DrMes As DataRow
        Dim DtTemp As New DataTable

        DtTemp = dt.Clone

        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True And Not RowPresupuesto.Cells("Cod_PresupuestoPA").Value Is DBNull.Value Then
                Rows = dt.Select("mes = " & RowPresupuesto.Cells("mes").Value & " AND Anio = " & RowPresupuesto.Cells("ano").Value)
                If Rows.Length = 1 Then
                    DtTemp.ImportRow(Rows(0))
                End If
            End If
        Next

        Return DtTemp

    End Function

    Private Function CalcularTotalesXSoporteEnvioCacheNoTv(ByVal DtFitradoAvisos As DataTable) As DataTable

        Dim DrSoporte, DrAvisos, FilaNueva As DataRow
        Dim DtSoportesPauta As New DataTable
        Dim OSoporte As New Soportes

        DtSoportesPauta = ArmarEstructuraDtSoportesPauta(DtSoportesPauta)
        Dim DtSoportes As DataTable = DtFitradoAvisos.DefaultView.ToTable(True, "CODIGOSOPORTE", "CODIGOMEDIO", "MES", "ANIO", "PRESUPUESTOPC")
        Dim Rows() As DataRow
        Dim DtOrdenado As New DataTable
        DtOrdenado = DtSoportesPauta.Clone

        For Each DrSoporte In DtSoportes.Rows
            FilaNueva = DtSoportesPauta.NewRow
            FilaNueva("anio") = DrSoporte("ANIO")
            FilaNueva("mes") = DrSoporte("MES")
            Rows = DtFitradoAvisos.Select("CODIGOSOPORTE = " & DrSoporte("CODIGOSOPORTE") & "AND MES = " & DrSoporte("MES"))
            FilaNueva("PresupuestoPC") = CInt(Rows(0)("PresupuestoPC").ToString) 'CInt(Rows(0)(48).ToString
            FilaNueva("cod_soporte") = DrSoporte("CODIGOSOPORTE")
            With OSoporte
                .Id_medio = DrSoporte("CODIGOMEDIO")
                FilaNueva("soporte") = .ObtenerDescripcion(FilaNueva("cod_soporte"))
            End With
            FilaNueva("TotalSoporteEnvio") = DtFitradoAvisos.Compute("Sum(IMPORTECOMPRANETO)", "CODIGOSOPORTE = " & DrSoporte("CODIGOSOPORTE") & "AND MES = " & DrSoporte("MES"))

            DtSoportesPauta.Rows.Add(FilaNueva)
        Next
        DtSoportesPauta.DefaultView.Sort = ("Mes")

        Return DtSoportesPauta

        'Dim id_campania As Integer = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
        'Dim id_subcampania As Integer = CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value)
        'Dim DrSoporte, DrAvisos, FilaNueva As DataRow
        'Dim DtSoportesPauta As New DataTable
        'Dim OSoporte As New Soportes

        'DtSoportesPauta = ArmarEstructuraDtSoportesPauta(DtSoportesPauta)
        'Dim DtSoportes As DataTable = DtFitradoAvisos.DefaultView.ToTable(True, "CODIGOSOPORTE", "CODIGOMEDIO", "MES", "ANIO", "PRESUPUESTOPC")
        'Dim Rows() As DataRow
        'Dim DtOrdenado As New DataTable
        'DtOrdenado = DtSoportesPauta.Clone

        'For Each DrSoporte In DtSoportes.Rows
        '    FilaNueva = DtSoportesPauta.NewRow
        '    FilaNueva("anio") = DrSoporte("ANIO")
        '    FilaNueva("mes") = DrSoporte("MES")
        '    Rows = DtFitradoAvisos.Select("CODIGOSOPORTE = " & DrSoporte("CODIGOSOPORTE") & "AND MES = " & DrSoporte("MES"))
        '    FilaNueva("PresupuestoPC") = CInt(Rows(0)("PresupuestoPC").ToString) 'CInt(Rows(0)(48).ToString
        '    FilaNueva("cod_soporte") = DrSoporte("CODIGOSOPORTE")
        '    With OSoporte
        '        .Id_medio = DrSoporte("CODIGOMEDIO")
        '        FilaNueva("soporte") = .ObtenerDescripcion(FilaNueva("cod_soporte"))
        '    End With
        '    FilaNueva("TotalSoporteEnvio") = DtFitradoAvisos.Compute("Sum(IMPORTECOMPRANETO)", "CODIGOSOPORTE = " & DrSoporte("CODIGOSOPORTE") & "AND MES = " & DrSoporte("MES"))

        '    Dim oEnvioComprasLigero As New Envio_Ligero_MMS
        '    Dim retorno As DataTable = oEnvioComprasLigero.Obtener_Total_Soportes_PA_TV(Activo.IDCampaña, DrSoporte("SISTEMA"), DrSoporte("EJERCICIO"), DrSoporte("PRODUCTO"), DrSoporte("SOPORTE"), DrSoporte("TEMA"), DrSoporte("FECHADESDE"), DrSoporte("FECHAHASTA"), DrSoporte("MES"), DrSoporte("ANIO"), Activo.CodCampaniaActualMms, id_subcampania, id_campania, DrSoporte("PRESUPUESTO"))

        '    'NUEVO DESARROLLO DE ENVIO LIGERO (AN 07-09-2015)
        '    If Not retorno Is Nothing Then
        '        FilaNueva("TotalSoporteEnvio") = retorno.Rows(0)("IMPORTE_COMPRA_NETO_MMS")
        '    Else
        '        FilaNueva("TotalSoporteEnvio") = 0
        '    End If

        '    'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
        '    'FilaNueva("TotalSoporteEnvio") = DtFitradoAvisos.Compute("Sum(IMPORTECOMPRANETO)", "SOPORTE = " & DrSoporte("SOPORTE") & "AND MES = " & DrSoporte("MES"))

        '    DtSoportesPauta.Rows.Add(FilaNueva)
        'Next
        'DtSoportesPauta.DefaultView.Sort = ("Mes")

        'Return DtSoportesPauta

    End Function

    Private Function CalcularTotalesXSoporteEnvioCache(ByVal DtFitradoAvisos As DataTable) As DataTable

        Dim id_campania As Integer = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
        Dim id_subcampania As Integer = CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value)
        Dim DrSoporte, DrAvisos, FilaNueva As DataRow
        Dim DtSoportesPauta As New DataTable
        Dim OSoporte As New Soportes
        Dim DtSoportes As DataTable

        DtSoportesPauta = ArmarEstructuraDtSoportesPauta(DtSoportesPauta)
        DtSoportes = DtFitradoAvisos.DefaultView.ToTable(True, "SOPORTE", "MEDIO", "MES", "ANIO", "EJERCICIO", "SISTEMA", "PRODUCTO", "TEMA", "FECHADESDE", "FECHAHASTA", "PRESUPUESTO")

        Dim Rows() As DataRow
        Dim DtOrdenado As New DataTable
        DtOrdenado = DtSoportesPauta.Clone

        For Each DrSoporte In DtSoportes.Rows
            FilaNueva = DtSoportesPauta.NewRow
            FilaNueva("anio") = DrSoporte("ANIO")
            FilaNueva("mes") = DrSoporte("MES")
            Rows = DtFitradoAvisos.Select("SOPORTE = " & DrSoporte("SOPORTE") & "AND MES = " & DrSoporte("MES"))
            FilaNueva("PresupuestoPC") = CInt(Rows(0)("PresupuestoPC").ToString)
            FilaNueva("cod_soporte") = DrSoporte("SOPORTE")
            With OSoporte
                .Id_medio = DrSoporte("MEDIO")
                FilaNueva("soporte") = .ObtenerDescripcion(FilaNueva("cod_soporte"))
            End With

            Dim oEnvioComprasLigero As New Envio_Ligero_MMS
            Dim retorno As DataTable = oEnvioComprasLigero.Obtener_Total_Soportes_PA_TV(Activo.IDCampaña, DrSoporte("SISTEMA"), DrSoporte("EJERCICIO"), DrSoporte("PRODUCTO"), DrSoporte("SOPORTE"), DrSoporte("TEMA"), DrSoporte("FECHADESDE"), DrSoporte("FECHAHASTA"), DrSoporte("MES"), DrSoporte("ANIO"), Activo.CodCampaniaActualMms, id_subcampania, id_campania, DrSoporte("PRESUPUESTO"))

            'NUEVO DESARROLLO DE ENVIO LIGERO (AN 07-09-2015)
            If Not retorno Is Nothing Then
                FilaNueva("TotalSoporteEnvio") = retorno.Rows(0)("IMPORTE_COMPRA_NETO_MMS")
            Else
                FilaNueva("TotalSoporteEnvio") = 0
            End If

            DtSoportesPauta.Rows.Add(FilaNueva)
        Next
        DtSoportesPauta.DefaultView.Sort = ("Mes")

        Return DtSoportesPauta

    End Function

    Private Function RecorrerDtFinalAutorizarEnvios(ByVal Dt As DataTable) As DataTable

        Dim Dr As DataRow

        For Each Dr In Dt.Rows
            If Not IsDBNull(Dr("SaldoPCEnvio")) Then

                If Dr("SaldoPAPermitido") >= Dr("SaldoPCEnvio") Then
                    Dr("Autorizado") = True 'Permite Enviar 
                Else
                    Dr("Autorizado") = False 'NO Permite Enviar 
                End If
            Else
                Dr("Autorizado") = False
            End If
        Next

        Return Dt

    End Function

    Private Function CalcularInversionPermitidaCache() As DataTable

        'AG 09/08/2013 NO SE UTILIZA 
        DtControlEnvioFinal = New DataTable

        Dim DrDistint, FilaNueva As DataRow
        Dim DtDistint As DataTable = DtRegistrosPAYaEnviadosNuevo.DefaultView.ToTable(True, "codCompania", "codCampana", "Cod_SubCampana", "codsoporte", "PresupuestoPA", "SaldoPAPermitido")
        Dim TotalCalculado As Double

        DtControlEnvioFinal = DtRegistrosPAYaEnviadosNuevo.Clone

        For Each DrDistint In DtDistint.Rows
            FilaNueva = DtControlEnvioFinal.NewRow
            FilaNueva("codCompania") = DrDistint("codCompania")
            FilaNueva("codCampana") = DrDistint("codCampana")
            FilaNueva("Cod_SubCampana") = DrDistint("Cod_SubCampana")
            FilaNueva("PresupuestoPA") = DrDistint("PresupuestoPA")
            TotalCalculado = DtRegistrosPAYaEnviadosNuevo.Compute("Sum(SaldoPCEnvio)", "codsoporte = " & DrDistint("codsoporte"))
            If TotalCalculado > DrDistint("SaldoPAPermitido") Then
                FilaNueva("Autorizado") = False
            Else
                FilaNueva("Autorizado") = True
            End If
            FilaNueva("SaldoPCEnvio") = TotalCalculado
            FilaNueva("SaldoPAPermitido") = DrDistint("SaldoPAPermitido")
            DtControlEnvioFinal.Rows.Add(FilaNueva)
        Next

        Return DtControlEnvioFinal

    End Function

    Private Function CalcularInversionPermitida() As DataTable

        'AG 09/08/2013 NO SE UTILIZA 
        DtControlEnvioFinal = New DataTable

        Dim DrDistint, FilaNueva As DataRow
        Dim DtDistint As DataTable = DtRelacionPCPAFinal.DefaultView.ToTable(True, "codCompania", "codCampana", "CodSubCampana", "codsoporte", "PresupuestoPA", "SaldoPAPermitido")
        Dim TotalCalculado As Double

        DtControlEnvioFinal = DtRelacionPCPAFinal.Clone

        For Each DrDistint In DtDistint.Rows
            FilaNueva = DtControlEnvioFinal.NewRow
            FilaNueva("codCompania") = DrDistint("codCompania")
            FilaNueva("codCampana") = DrDistint("codCampana")
            FilaNueva("CodSubCampana") = DrDistint("CodSubCampana")
            FilaNueva("PresupuestoPA") = DrDistint("PresupuestoPA")
            TotalCalculado = DtRelacionPCPAFinal.Compute("Sum(SaldoPCEnvio)", "codsoporte = " & DrDistint("codsoporte"))
            If TotalCalculado > DrDistint("SaldoPAPermitido") Then
                FilaNueva("Autorizado") = False
            Else
                FilaNueva("Autorizado") = True
            End If
            FilaNueva("SaldoPCEnvio") = TotalCalculado
            FilaNueva("SaldoPAPermitido") = DrDistint("SaldoPAPermitido")
            DtControlEnvioFinal.Rows.Add(FilaNueva)
        Next

        Return DtControlEnvioFinal

    End Function

    Private Function ArmarEstructuraDtSoportesPauta(ByVal Dt As DataTable) As DataTable

        With Dt.Columns
            .Add("anio", GetType(Integer))
            .Add("mes", GetType(Integer))
            .Add("PresupuestoPC", GetType(Integer))
            .Add("cod_soporte", GetType(Integer))
            .Add("soporte", GetType(String))
            .Add("TotalSoporteEnvio", GetType(Double))
            .Add("TotalSoportePermintido", GetType(Double))
            .Add("Autorizado", GetType(Boolean))
        End With

        Return Dt
    End Function

    Private Sub ArmarEstructuraDtPresupuestoPA()

        With DtDatosPresPA.Columns
            .Add("Medio", GetType(String))
            .Add("Soporte", GetType(String))
            .Add("Saldo", GetType(Double))
            .Add("SelPresupuestoPA", GetType(Boolean))
        End With

    End Sub

    Private Sub CargarPrePAGrilla()

        Dim RowsSinPresupuesto() As DataRow
        Dim RowsConPresupuesto() As DataRow
        Dim i As Integer
        Dim PAnticipadoConcatenado As String
        Dim Dr As DataRow
        Dim CarfarPresupuestoPC As Boolean
        Dim oSoporte As New Soportes


        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True Then
                If DtRelacionPCPAFinal Is Nothing Then
                    Exit Sub
                End If
                If Me.DtRelacionPCPAFinal.Rows.Count > 0 Then

                    RowsSinPresupuesto = Me.DtRelacionPCPAFinal.Select("anio = " & RowPresupuesto.Cells("ano").Value & " AND mes = " & RowPresupuesto.Cells("mes").Value & " AND PresupuestoPC = " & -1)
                    If RowsSinPresupuesto.Length > 0 Then
                        PAnticipadoConcatenado = ""
                        For i = 0 To RowsSinPresupuesto.Length - 1
                            oSoporte.Id_medio = MedioActual
                            PAnticipadoConcatenado += RowsSinPresupuesto(i)("PresupuestoPA").ToString + " : " + oSoporte.ObtenerDescripcion(CInt(RowsSinPresupuesto(i)("codsoporte"))) + " | "
                        Next
                        CarfarPresupuestoPC = True
                        RowPresupuesto.Cells("Cod_PresupuestoPA").Value = PAnticipadoConcatenado
                    End If

                    RowsConPresupuesto = Me.DtRelacionPCPAFinal.Select("anio = " & RowPresupuesto.Cells("ano").Value & " AND mes = " & RowPresupuesto.Cells("mes").Value & " AND PresupuestoPC = " & RowPresupuesto.Cells("id_presupuesto").Value)
                    If RowsConPresupuesto.Length > 0 Then
                        PAnticipadoConcatenado = ""
                        For i = 0 To RowsConPresupuesto.Length - 1
                            oSoporte.Id_medio = MedioActual
                            PAnticipadoConcatenado += RowsConPresupuesto(i)("PresupuestoPA").ToString + " : " + oSoporte.ObtenerDescripcion(CInt(RowsConPresupuesto(i)("codsoporte"))) + " | "
                        Next
                        RowPresupuesto.Cells("Cod_PresupuestoPA").Value = PAnticipadoConcatenado
                    End If
                End If
            End If
        Next

        'AG 17/07/2013 == Cargo los nuevos presupuesto =
        If CarfarPresupuestoPC = True Then
            For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
                If RowPresupuesto.Cells("Sel").Value = True Then
                    For t As Integer = 0 To Me.DtRelacionPCPAFinal.Rows.Count - 1
                        If Me.DtRelacionPCPAFinal.Rows(t)("anio") = RowPresupuesto.Cells("ano").Value And Me.DtRelacionPCPAFinal.Rows(t)("mes") = RowPresupuesto.Cells("mes").Value And Me.DtRelacionPCPAFinal.Rows(t)("PresupuestoPC") = -1 Then
                            Me.DtRelacionPCPAFinal.Rows(t)("PresupuestoPC") = RowPresupuesto.Cells("id_presupuesto").Value
                        End If
                    Next
                End If
            Next
        End If

    End Sub

    Private Sub TraerSpotsPA()

        Dim id_material As Integer = 1
        Dim id_campania As Integer = CInt(iugCampanias.ActiveRow.Cells("ID_CAMPANA").Value)
        Dim id_subcampania As Integer = CInt(iugSubCampanias.ActiveRow.Cells("id_subcampana").Value)
        Dim dt As New DataTable
        Dim ChildR As UltraDataRowsCollection
        Dim ChildTemas As UltraDataRowsCollection
        Dim mesInicio As Integer = -1
        Dim mesFin As Integer = -1
        Dim i, j, z As Integer

        Select Case MedioActual
            Case Medios.Prensa
                Envio.ListaSoportes = ConcatenarSoportes()
                dt = Envio.ObtenerSpotsPrensaPA() 'AG 15/08/2013
                CopiarDT(dt, Me.DtDatosPresPA)
            Case Medios.Revista
                Envio.ListaSoportes = ConcatenarSoportes()
                dt = Envio.ObtenerSpotsPrensaPA() 'AG 15/08/2013
                CopiarDT(dt, Me.DtDatosPresPA)
            Case Medios.Radio
                'AG 03/03/2016 ================================================================================================================
                While i < Ultra.Rows.Count ''PROVEEDORES
                    ChildR = Ultra.Rows(i).GetChildRows("Soportes") ''SOPORTES
                    j = 0
                    While j < ChildR.Count ''RECORREMOS LOS SOPORTES
                        ChildTemas = ChildR(j).GetChildRows("Temas")
                        z = 0
                        While z < ChildTemas.Count ''RECORREMOS LOS TEMAS
                            If ChildTemas.Item(z).GetCellValue("Ok") Then ''SI ESTAN OK SE AGREGAN
                                'AGuzzardi 10/06/2010 ----------------------------------------------------------------------------
                                If Envio.Id_Sistema = 0 Then
                                    Envio.Id_Sistema = iugEjercicios.ActiveRow.Cells("id_sistema").Value
                                End If
                                If Envio.Id_Ejercicio = 0 Then
                                    Envio.Id_Ejercicio = iugEjercicios.ActiveRow.Cells("id_ejercicio").Value
                                End If
                                If Envio.Id_Campania = 0 Then
                                    Envio.Id_Campania = Activo.IDCampaña
                                End If
                                Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
                                Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
                                '---------------------------------------------------------------------------------------------------------
                                dt = Envio.Traer_Avisos_MMS_RD(ChildTemas.Item(z).GetCellValue("Tema"), ChildR(j).Item("id_soporte"), id_campania, id_subcampania)
                                CopiarDT(dt, Me.DtDatosPresPA)
                            End If
                            z += 1
                        End While
                        j = j + 1
                    End While
                    i = i + 1
                End While

                'ANTERIOR ================================================================================================================
                'While i < Ultra.Rows.Count ''SOPORTES
                '    ChildR = Ultra.Rows(i).GetChildRows("ChildBand") ''TEMAS
                '    j = 0
                '    While j < ChildR.Count ''RECORREMOS LOS TEMAS
                '        If ChildR.Item(j).GetCellValue("Ok") Then ''SI ESTAN OK SE AGREGAN
                '            'AGuzzardi 10/06/2010 ----------------------------------------------------------------------------
                '            If Envio.Id_Sistema = 0 Then
                '                Envio.Id_Sistema = iugEjercicios.ActiveRow.Cells("id_sistema").Value
                '            End If
                '            If Envio.Id_Ejercicio = 0 Then
                '                Envio.Id_Ejercicio = iugEjercicios.ActiveRow.Cells("id_ejercicio").Value
                '            End If
                '            If Envio.Id_Campania = 0 Then
                '                Envio.Id_Campania = Activo.IDCampaña
                '            End If
                '            Envio.Fecha_Desde = CDate(dtpF_Desde.Value).ToShortDateString
                '            Envio.Fecha_Hasta = CDate(dtpF_Hasta.Value).ToShortDateString
                '            '---------------------------------------------------------------------------------------------------------
                '            dt = Envio.Traer_Avisos_MMS_RD(ChildR.Item(j).GetCellValue("Tema"), Ultra.Rows(i).Item("id_soporte"), id_campania, id_subcampania)
                '            CopiarDT(dt, Me.DtDatosPresPA)
                '        End If
                '        j = j + 1
                '    End While
                '    i = i + 1
                'End While
                '============================================================================================================================
            Case Medios.Tv
                ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 01-09-2015)
                Call InitializeDtFiltros()

                'AG 03/03/2016 ================================================================================================================
                While i < Ultra.Rows.Count ''SOPORTES
                    ChildR = Ultra.Rows(i).GetChildRows("Soportes") ''SOPORTES
                    If CboMedio.Value = MedioRadio Then
                    Else
                        j = 0
                        While j < ChildR.Count ''RECORREMOS LOS SOPORTES    
                            ChildTemas = ChildR(j).GetChildRows("Temas")
                            z = 0
                            While z < ChildTemas.Count ''RECORREMOS LOS TEMAS
                                If ChildTemas.Item(z).GetCellValue("Ok") Then ''SI ESTAN OK SE AGREGAN
                                    Dim tema As String = ChildTemas.Item(z).GetCellValue("Tema")
                                    Dim anios = DateDiff(DateInterval.Year, dtpF_Desde.Value, dtpF_Hasta.Value)

                                    Dim fechaDesde As Integer = CInt(CDate(dtpF_Desde.Value).Month.ToString() & CDate(dtpF_Desde.Value).Year.ToString())
                                    Dim fechaHasta As Integer = CInt((CInt(CDate(dtpF_Hasta.Value).Month.ToString()) + (anios * 12)) & CDate(dtpF_Hasta.Value).Year.ToString())
                                    Dim filas As DataRow() = DtTemasSoporte.Select(String.Format("TEMA='{0}'", tema))

                                    For Each fila As DataRow In filas
                                        'REEMPLAZO VALIDACION DE FECHAS (AN 18-11-2015)
                                        If CInt(fila("MES") & fila("ANIO")) >= fechaDesde And CInt(fila("MES") & fila("ANIO")) <= fechaHasta Then
                                            AddFiltroRow(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, Medios.Tv, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text), CDate(dtpF_Desde.Value).ToShortDateString, CDate(dtpF_Hasta.Value).ToShortDateString(), ChildTemas.Item(z).GetCellValue("Tema"), ChildR(j).Item("id_soporte"), id_campania, id_subcampania, 0, 0, fila("MES"), fila("ANIO"))
                                        End If
                                    Next
                                End If
                                z += 1
                            End While
                            j = j + 1
                        End While
                    End If
                    i = i + 1
                End While
                
                'ANTERIOR ================================================================================================================
                'While i < Ultra.Rows.Count ''SOPORTES
                '    ChildR = Ultra.Rows(i).GetChildRows("Soportes") ''TEMAS 'AG 03/03/2016  ChildBand
                '    If CboMedio.Value = MedioRadio Then
                '    Else
                '        j = 0
                '        While j < ChildR.Count ''RECORREMOS LOS TEMAS
                '            If ChildR.Item(j).GetCellValue("Ok") Then ''SI ESTAN OK SE AGREGAN
                '                ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 01-09-2015)
                '                ' SE AGREGA PROCESAMIENTO DE TEMAS POR FECHA (AN 10-11-2015)
                '                Dim tema As String = ChildR.Item(j).GetCellValue("Tema")
                '                Dim fechaDesde As Integer = CInt(CDate(dtpF_Desde.Value).Month.ToString() & CDate(dtpF_Desde.Value).Year.ToString())
                '                Dim fechaHasta As Integer = CInt(CDate(dtpF_Hasta.Value).Month.ToString() & CDate(dtpF_Hasta.Value).Year.ToString())
                '                Dim filas As DataRow() = DtTemasSoporte.Select(String.Format("TEMA='{0}'", tema))

                '                For Each fila As DataRow In filas
                '                    If CInt(fila("MES") & fila("ANIO")) >= fechaDesde And CInt(fila("MES") & fila("ANIO")) <= fechaHasta Then
                '                        AddFiltroRow(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, Medios.Tv, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text), CDate(dtpF_Desde.Value).ToShortDateString, CDate(dtpF_Hasta.Value).ToShortDateString(), ChildR.Item(j).GetCellValue("Tema"), Ultra.Rows(i).Item("id_soporte"), id_campania, id_subcampania, 0, 0, fila("MES"), fila("ANIO"))
                '                    End If
                '                Next
                '                '-----------------------------------------------------------------------------------------------------
                '                ' SE COMENTA POR EL NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 01-09-2015)
                '                'dt = Envio.Traer_Avisos_MMS_TV(ChildR.Item(j).GetCellValue("Tema"), Ultra.Rows(i).Item("id_soporte"), id_campania, id_subcampania)
                '                'CopiarDT(dt, Me.DtDatosPresPA)
                '            End If
                '            j = j + 1
                '        End While
                '    End If
                '    i = i + 1
                'End While
                '============================================================================================================================
            Case Medios.Exterior
                For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                    Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
                    If iugPresupuestos.Rows.Count = 0 Then
                        _id_presupuesto_mms = 0
                    Else
                        _id_presupuesto_mms = iugPresupuestos.Rows(iugPresupuestos.ActiveRow.Index).Cells(2).Value
                    End If
                    DtDatosPresPA = Envio.traer_avisos_MMS_EXTPA(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, cboMateriales.ActiveRow.Cells("id_material").Value, _id_producto, id_campania, _id_presupuesto_mms)
                Next
            Case Medios.Produccion 'AG Produccion ++++++++++++++++++++++++
                For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                    Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
                    If iugPresupuestos.Rows.Count = 0 Then
                        _id_presupuesto_mms = 0
                    Else
                        _id_presupuesto_mms = iugPresupuestos.Rows(iugPresupuestos.ActiveRow.Index).Cells(2).Value
                    End If
                    DtDatosPresPA = Envio.traer_avisos_MMS_ProduccionPA(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, cboMateriales.ActiveRow.Cells("id_material").Value, _id_producto, id_campania, _id_presupuesto_mms)
                Next
                '++++++++++++++++++++++++++++++++++++++++++++++++++
            Case Medios.Internet

                For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                    Envio.Id_Soporte = DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID
                    _id_presupuesto_mms = iugPresupuestos.Rows(iugPresupuestos.ActiveRow.Index).Cells(2).Value
                    DtDatosPresPA = Envio.traer_avisos_MMS_Internet(_id_campania_mms, _id_subcampania_mms, Activo.CodPaisMms, Activo.CodUsuarioMms, Activo.CodCampaniaActualMms, id_campania, _id_presupuesto_mms)
                Next
                For Each rowEnvio As DataRow In dtEnvioSpots.Rows
                    mesInicio = CInt(rowEnvio.Item("f_inicio").Month.ToString())
                    mesFin = CInt(rowEnvio.Item("f_fin").Month.ToString())
                    If (CInt(iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) = mesInicio Or CInt(iugPresupuestos.ActiveRow.Cells("mes").Value.ToString()) = mesFin) Then
                        ningunMesActual = False
                        Exit For
                    End If
                Next
                Dim oEnvioLigero As New Envio_Ligero_MMS
                Dim proveedores As List(Of String) = oEnvioLigero.Obtener_Relacion_Proveedores()

                Call FiltrarAvisosInternetEnvioDoble(dtEnvioSpots, proveedores)

                If Not dtEnvioSpots Is Nothing Then
                    cantidadAvisosSocialyse = dtEnvioSpots.Rows.Count
                Else
                    cantidadAvisosSocialyse = 0
                End If

                ' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO DE INTERNET (AN 15-09-2015)
                Call InitializeDtFiltros()
                For index As Integer = 0 To lstSoportes.CheckedItems.Count - 1
                    If proveedores.Contains(DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).Descripcion.Split("[")(2).Replace("]", "")) Then
                        AddFiltroRow(Activo.IDCampaña, iugEjercicios.ActiveRow.Cells("id_sistema").Value, iugEjercicios.ActiveRow.Cells("id_ejercicio").Value, Medios.Internet, CInt(cboProducto.SelectedRow.Cells("Id_producto").Text), CDate(dtpF_Desde.Value).ToShortDateString, CDate(dtpF_Hasta.Value).ToShortDateString(), String.Empty, DirectCast(lstSoportes.CheckedItems.Item(index), ItemLista).ID, id_campania, id_subcampania, 0, 0, 0, 0)
                    End If
                Next
            Case Else
        End Select
        dt.Dispose()
    End Sub

    Private Sub InsertarRelacionPCPAMMS()

        Dim OEnvioCompras As New Envio_Compras
        Dim Dr As DataRow

        If Me.DtRelacionPCPAFinal.Rows.Count > 0 Then
            For Each Dr In Me.DtRelacionPCPAFinal.Rows
                OEnvioCompras.InsertarRelacionPCPAMMS(Dr("codCompania"), Dr("PresupuestoPC"), Dr("PresupuestoPA"))
            Next
            Me.NoActualizar = True
        End If

    End Sub

    Private Sub InsertarRelacionPCPAEverest()

        Dim OEnvioCompras As New Envio_Compras
        Dim Dr As DataRow

        If Me.DtRelacionPCPAFinal.Rows.Count > 0 Then
            For Each Dr In Me.DtRelacionPCPAFinal.Rows
                OEnvioCompras.EliminarTempPA(CInt(Activo.CodCampaniaActualMms), _id_campania_mms, _id_subcampania_mms, Dr("PresupuestoPC"), Dr("PresupuestoPA"), Dr("anio"), Dr("mes"), Activo.IDMedio, Dr("CodSoporte"), CInt(Activo.CodUsuarioMms))
                OEnvioCompras.InsertarRelacionPCPAEverest(CInt(Activo.CodCampaniaActualMms), _id_campania_mms, _id_subcampania_mms, Dr("PresupuestoPC"), Dr("PresupuestoPA"), Dr("codsoporte"), Dr("anio"), Dr("mes"), CInt(Activo.CodUsuarioMms), Dr("SaldoPAPermitido"), Dr("SaldoPCEnvio"), Dr("Autorizado"), Activo.IDMedio)
                Dr("codCampana") = _id_campania_mms
                Dr("codSubCampana") = _id_subcampania_mms
            Next
        End If

    End Sub

    Private Sub EliminarPCPAEverestTemporal()

        Dim OEnvioCompras As New Envio_Compras
        Dim Dr As DataRow

        If Not Me.DtRelacionPCPAFinal Is Nothing Then
            If Me.DtRelacionPCPAFinal.Rows.Count > 0 Then
                For Each Dr In Me.DtRelacionPCPAFinal.Rows
                    OEnvioCompras.EliminarTempPA(CInt(Activo.CodCampaniaActualMms), _id_campania_mms, _id_subcampania_mms, Dr("PresupuestoPC"), Dr("PresupuestoPA"), Dr("anio"), Dr("mes"), Activo.IDMedio, Dr("CodSoporte"), CInt(Activo.CodUsuarioMms))
                Next
            End If
        End If
    End Sub

    Private Function PermitirMostrarPantalaSeleccionPA() As Boolean

        Dim Resultado As Boolean = False

        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True And CInt(RowPresupuesto.Cells("id_Presupuesto").Value) = -1 And RowPresupuesto.Cells("cod_PresupuestoPA").Value Is DBNull.Value Then
                Resultado = True
                Exit For
            End If
        Next

        Return Resultado

    End Function

    Private Function ValidarSoportesPAPermitidos(ByVal DtSoporteEnvioFinal As DataTable, ByVal DtPaSoportes As DataTable) As Boolean

        Dim Resultado As Boolean = False
        Dim Drs As DataRow
        Dim Rows() As DataRow
        Dim Dr As DataRow


        If DtPaSoportes Is Nothing Then
            Return Resultado = True
            Exit Function
        End If

        If DtSoporteEnvioFinal.Rows.Count > 0 Then
            For Each Dr In DtSoporteEnvioFinal.Rows
                Rows = DtPaSoportes.Select("codsoporte = " & Dr("cod_soporte") & " AND anio = " & Dr("anio") & " AND mes = " & Dr("mes") & " AND CodPresupuestoPc = " & Dr("PresupuestoPc"))
                If Rows.Length = 0 Then
                    Resultado = True
                    Exit For
                End If
            Next
        End If

        'Si es = treu entonces no deja ENVIAR

        Return Resultado

    End Function

    Private Sub iugPresupuestos_DoubleClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles iugPresupuestos.DoubleClickCell

        'AG 18/07/2013 =================================================
        If e.Cell.Column.Header.Column.Header.Caption = "Presupuesto P.A" Then
            Dim FrmPAPCAsignados As New frmPAPCAsignados
            FrmPAPCAsignados.GroupBox1.Text = "Presupuesto Consumo Nro: " & iugPresupuestos.ActiveRow.Cells("ID_PRESUPUESTO").Value
            FrmPAPCAsignados.Descripcion = "============================== Presupuestos Anticipados Relacionados Nro: ==============================" & vbCrLf & vbCrLf & iugPresupuestos.ActiveRow.Cells("Cod_PresupuestoPA").Value
            FrmPAPCAsignados.txtdescripcion.ReadOnly = True
            FrmPAPCAsignados.Show()
        End If
        '===============================================================

    End Sub

    Private Function ArmarEstructuraDtSoportePA() As DataTable

        Dim Dt As New DataTable

        With Dt
            .Columns.Add("anio", GetType(Integer))
            .Columns.Add("mes", GetType(Integer))
            .Columns.Add("CodPresupuestoPc", GetType(Integer))
            .Columns.Add("CodPresupuestoPa", GetType(Integer))
            .Columns.Add("CodSoporte", GetType(Integer))
        End With

        Return Dt

    End Function

    Private Function CargarDtSoportePA(ByVal Dt As DataTable, ByVal DtSoportePA As DataTable, ByVal PresupuestoPc As Integer, ByVal PresupuestoPa As Integer, ByVal mes As Integer, ByVal anio As Integer) As DataTable

        Dim FilaNueva As DataRow

        For Each DatoPA As DataRow In DtSoportePA.Rows
            FilaNueva = Dt.NewRow
            FilaNueva("anio") = anio
            FilaNueva("mes") = mes
            FilaNueva("CodPresupuestoPc") = PresupuestoPc
            FilaNueva("CodPresupuestoPa") = PresupuestoPa
            FilaNueva("CodSoporte") = CInt(DatoPA("CodSoporte"))
            Dt.Rows.Add(FilaNueva)
        Next

        Return Dt

    End Function

    Private Sub CargarPASeleccionado(ByVal Dt As DataTable)

        Dim Rows() As DataRow
        Dim Dr As DataRow

        If Not DtRelacionPCPAFinal Is Nothing Then
            If DtRelacionPCPAFinal.Rows.Count > 0 Then
                'For Each Dr In DtSoportesPautaTotales.Rows
                For Each Dr In Dt.Rows
                    Rows = DtRelacionPCPAFinal.Select("anio = " & Dr("anio") & " AND mes = " & Dr("mes") & " AND codsoporte = " & Dr("cod_soporte"))
                    If Rows.Length > 0 Then
                        Dr("CodPresupuestoPa") = CInt(Rows(0)("PresupuestoPA"))
                    End If
                Next
            End If
        End If

    End Sub

    Private Function VerificarSoporteSeleccionado(ByVal Dt As DataTable, ByVal lista As ArrayList) As DataTable

        Dim Rows() As DataRow
        Dim DtTemp As New DataTable
        Dim i As Integer
        Dim Dr As DataRow
        Dim o As Integer
        Dim lis As New ArrayList
        Dim u As Integer
        Dim y As Integer
        Dim DtDistint As DataTable = Dt.DefaultView.ToTable(True, "cod_soporte")


        For u = 0 To lista.Count - 1
            If lis.IndexOf(lista(u)) = -1 Then
                lis.Add(lista(u))
            End If
        Next

        DtTemp = Dt.Clone

        For y = 0 To lis.Count - 1
            Rows = Dt.Select("cod_soporte = " & lista(y))
            If Rows.Length > 0 Then
                For o = 0 To Rows.Length - 1
                    DtTemp.ImportRow(Rows(o))
                Next
            End If
        Next

        Return DtTemp

    End Function

    Private Function CheckPresupuestoControlPA() As Boolean

        Dim Resultado As Boolean = False
        Dim CantSeleccionado As Integer = 0

        For Each RowPresupuesto As UltraGridRow In iugPresupuestos.Rows
            If RowPresupuesto.Cells("Sel").Value = True Then
                CantSeleccionado += 1
            End If
        Next

        If CantSeleccionado >= 2 Then
            Resultado = True
        End If

        Return Resultado

    End Function


#End Region

    Private Sub iugPresupuestos_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugPresupuestos.InitializeLayout

        Dim layout As UltraGridLayout = e.Layout
        Dim band As UltraGridBand = layout.Bands.GetItem(0)
        Dim column As UltraGridColumn = band.Columns.GetItem(6)

        If column.Header.Caption = "SelTipoPresupuesto" Then

            column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            column.CellAppearance.ImageHAlign = HAlign.Center
            column.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always

            If layout.ValueLists.Count = 0 Then
                Dim vl As ValueList = layout.ValueLists.Add("TiposPresupuestos")
                vl.Appearance.ImageHAlign = HAlign.Left
                Dim vli As ValueListItem = vl.ValueListItems.Add(1, "Publicidad")
                vli = vl.ValueListItems.Add(2, "Moneda Extranjera")
                vli = vl.ValueListItems.Add(3, "Pago Anticipado")
                vli = vl.ValueListItems.Add(4, "Exportacion")
                vli = vl.ValueListItems.Add(5, "Innovación y creatividad en medios")
                vli = vl.ValueListItems.Add(6, "Planificado")
                vl.DisplayStyle = ValueListDisplayStyle.DisplayText
                column.ValueList = vl
            Else
                column.ValueList = layout.ValueLists.GetItem(0)
            End If
            'column.CellActivation = Activation.NoEdit
        End If

    End Sub

End Class

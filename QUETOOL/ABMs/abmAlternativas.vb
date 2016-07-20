Imports System.Collections.Generic

Public Class abmAlternativas
    Inherits System.Windows.Forms.UserControl
    Implements IABM

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Friend WithEvents fraDescripcion As System.Windows.Forms.GroupBox
    Friend WithEvents lstTema As System.Windows.Forms.ListBox
    Friend WithEvents cmdAgregarTema As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarTodosSistema As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarSistema As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarTodosTema As System.Windows.Forms.Button
    Friend WithEvents treAlternativaSistema As System.Windows.Forms.TreeView
    Friend WithEvents lstAlternativaTema As System.Windows.Forms.ListBox
    Friend WithEvents cboAlternativa As QUETOOL.cboCombo
    Friend WithEvents cmdQuitarTodosTema As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarTema As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarTodasAlternativa As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarAlternativa As System.Windows.Forms.Button
    Friend WithEvents treSistemaSoporte As System.Windows.Forms.TreeView
    Friend WithEvents fraSistemaSoporte As System.Windows.Forms.GroupBox
    Friend WithEvents fraTema As System.Windows.Forms.GroupBox
    Friend WithEvents fraSistemaSoporteAlternativa As System.Windows.Forms.GroupBox
    Friend WithEvents fraTemaAlternativa As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEvaluacion As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdResumenPrograma As System.Windows.Forms.Button
    Friend WithEvents cmdResumenEconomico As System.Windows.Forms.Button
    Friend WithEvents cmdResumenInversion As System.Windows.Forms.Button
    Friend WithEvents cmdResumenInversionExt As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents CboMedio As QUETOOL.cboCombo
    Friend WithEvents btoSeguiCPR As System.Windows.Forms.Button
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.treSistemaSoporte = New System.Windows.Forms.TreeView
        Me.lstTema = New System.Windows.Forms.ListBox
        Me.fraDescripcion = New System.Windows.Forms.GroupBox
        Me.CboMedio = New QUETOOL.cboCombo
        Me.lblMedio = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdResumenInversionExt = New System.Windows.Forms.Button
        Me.cmdResumenInversion = New System.Windows.Forms.Button
        Me.cmdResumenEconomico = New System.Windows.Forms.Button
        Me.cmdResumenPrograma = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cboAlternativa = New QUETOOL.cboCombo
        Me.cmdAgregarTema = New System.Windows.Forms.Button
        Me.fraSistemaSoporte = New System.Windows.Forms.GroupBox
        Me.cmdAgregarTodosSistema = New System.Windows.Forms.Button
        Me.cmdAgregarSistema = New System.Windows.Forms.Button
        Me.fraTema = New System.Windows.Forms.GroupBox
        Me.cmdAgregarTodosTema = New System.Windows.Forms.Button
        Me.fraSistemaSoporteAlternativa = New System.Windows.Forms.GroupBox
        Me.cmdQuitarTodasAlternativa = New System.Windows.Forms.Button
        Me.cmdQuitarAlternativa = New System.Windows.Forms.Button
        Me.treAlternativaSistema = New System.Windows.Forms.TreeView
        Me.cmdQuitarTodosTema = New System.Windows.Forms.Button
        Me.cmdQuitarTema = New System.Windows.Forms.Button
        Me.lstAlternativaTema = New System.Windows.Forms.ListBox
        Me.fraTemaAlternativa = New System.Windows.Forms.GroupBox
        Me.cmdEvaluacion = New System.Windows.Forms.Button
        Me.btoSeguiCPR = New System.Windows.Forms.Button
        Me.fraDescripcion.SuspendLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAlternativa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraSistemaSoporte.SuspendLayout()
        Me.fraTema.SuspendLayout()
        Me.fraSistemaSoporteAlternativa.SuspendLayout()
        Me.fraTemaAlternativa.SuspendLayout()
        Me.SuspendLayout()
        '
        'treSistemaSoporte
        '
        Me.treSistemaSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treSistemaSoporte.FullRowSelect = True
        Me.treSistemaSoporte.HideSelection = False
        Me.treSistemaSoporte.Location = New System.Drawing.Point(12, 20)
        Me.treSistemaSoporte.Name = "treSistemaSoporte"
        Me.treSistemaSoporte.Size = New System.Drawing.Size(240, 240)
        Me.treSistemaSoporte.TabIndex = 0
        '
        'lstTema
        '
        Me.lstTema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTema.Location = New System.Drawing.Point(12, 26)
        Me.lstTema.Name = "lstTema"
        Me.lstTema.Size = New System.Drawing.Size(240, 171)
        Me.lstTema.TabIndex = 2
        '
        'fraDescripcion
        '
        Me.fraDescripcion.Controls.Add(Me.btoSeguiCPR)
        Me.fraDescripcion.Controls.Add(Me.CboMedio)
        Me.fraDescripcion.Controls.Add(Me.lblMedio)
        Me.fraDescripcion.Controls.Add(Me.lblDescripcion)
        Me.fraDescripcion.Controls.Add(Me.cmdEliminar)
        Me.fraDescripcion.Controls.Add(Me.cmdResumenInversionExt)
        Me.fraDescripcion.Controls.Add(Me.cmdResumenInversion)
        Me.fraDescripcion.Controls.Add(Me.cmdResumenEconomico)
        Me.fraDescripcion.Controls.Add(Me.cmdResumenPrograma)
        Me.fraDescripcion.Controls.Add(Me.cmdImprimir)
        Me.fraDescripcion.Controls.Add(Me.cboAlternativa)
        Me.fraDescripcion.Location = New System.Drawing.Point(0, 4)
        Me.fraDescripcion.Name = "fraDescripcion"
        Me.fraDescripcion.Size = New System.Drawing.Size(608, 141)
        Me.fraDescripcion.TabIndex = 3
        Me.fraDescripcion.TabStop = False
        Me.fraDescripcion.Text = "Descripción"
        '
        'CboMedio
        '
        Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboMedio.DisplayMember = ""
        Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboMedio.Enabled = False
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedio.Location = New System.Drawing.Point(80, 40)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(216, 21)
        Me.CboMedio.TabIndex = 79
        Me.CboMedio.Tag = "Tipo de Soporte del Sistema"
        Me.CboMedio.ValueMember = ""
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(13, 42)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(36, 13)
        Me.lblMedio.TabIndex = 80
        Me.lblMedio.Text = "Medio"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 18)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 78
        Me.lblDescripcion.Text = "Descripción"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdEliminar.Location = New System.Drawing.Point(308, 64)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(136, 27)
        Me.cmdEliminar.TabIndex = 27
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdResumenInversionExt
        '
        Me.cmdResumenInversionExt.Enabled = False
        Me.cmdResumenInversionExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdResumenInversionExt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResumenInversionExt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdResumenInversionExt.Location = New System.Drawing.Point(459, 101)
        Me.cmdResumenInversionExt.Name = "cmdResumenInversionExt"
        Me.cmdResumenInversionExt.Size = New System.Drawing.Size(136, 26)
        Me.cmdResumenInversionExt.TabIndex = 26
        Me.cmdResumenInversionExt.Text = "Resumen de Inv. Ext"
        '
        'cmdResumenInversion
        '
        Me.cmdResumenInversion.Enabled = False
        Me.cmdResumenInversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdResumenInversion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResumenInversion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdResumenInversion.Location = New System.Drawing.Point(308, 101)
        Me.cmdResumenInversion.Name = "cmdResumenInversion"
        Me.cmdResumenInversion.Size = New System.Drawing.Size(136, 26)
        Me.cmdResumenInversion.TabIndex = 25
        Me.cmdResumenInversion.Text = "Resumen de Inversión"
        '
        'cmdResumenEconomico
        '
        Me.cmdResumenEconomico.Enabled = False
        Me.cmdResumenEconomico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdResumenEconomico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResumenEconomico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdResumenEconomico.Location = New System.Drawing.Point(159, 101)
        Me.cmdResumenEconomico.Name = "cmdResumenEconomico"
        Me.cmdResumenEconomico.Size = New System.Drawing.Size(136, 26)
        Me.cmdResumenEconomico.TabIndex = 24
        Me.cmdResumenEconomico.Text = "Resumen Económico"
        '
        'cmdResumenPrograma
        '
        Me.cmdResumenPrograma.Enabled = False
        Me.cmdResumenPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdResumenPrograma.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResumenPrograma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdResumenPrograma.Location = New System.Drawing.Point(13, 101)
        Me.cmdResumenPrograma.Name = "cmdResumenPrograma"
        Me.cmdResumenPrograma.Size = New System.Drawing.Size(136, 26)
        Me.cmdResumenPrograma.TabIndex = 23
        Me.cmdResumenPrograma.Text = "Resumen por Prog"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdImprimir.Location = New System.Drawing.Point(159, 64)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(136, 27)
        Me.cmdImprimir.TabIndex = 22
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cboAlternativa
        '
        Me.cboAlternativa.AutoEdit = False
        Me.cboAlternativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAlternativa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cboAlternativa.DisplayMember = ""
        Me.cboAlternativa.FlatMode = True
        Me.cboAlternativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlternativa.Location = New System.Drawing.Point(80, 16)
        Me.cboAlternativa.Name = "cboAlternativa"
        Me.cboAlternativa.Size = New System.Drawing.Size(516, 21)
        Me.cboAlternativa.TabIndex = 1
        Me.cboAlternativa.ValueMember = ""
        '
        'cmdAgregarTema
        '
        Me.cmdAgregarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregarTema.Location = New System.Drawing.Point(260, 20)
        Me.cmdAgregarTema.Name = "cmdAgregarTema"
        Me.cmdAgregarTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarTema.TabIndex = 11
        Me.cmdAgregarTema.Text = "4"
        '
        'fraSistemaSoporte
        '
        Me.fraSistemaSoporte.Controls.Add(Me.cmdAgregarTodosSistema)
        Me.fraSistemaSoporte.Controls.Add(Me.cmdAgregarSistema)
        Me.fraSistemaSoporte.Controls.Add(Me.treSistemaSoporte)
        Me.fraSistemaSoporte.Enabled = False
        Me.fraSistemaSoporte.Location = New System.Drawing.Point(0, 151)
        Me.fraSistemaSoporte.Name = "fraSistemaSoporte"
        Me.fraSistemaSoporte.Size = New System.Drawing.Size(300, 267)
        Me.fraSistemaSoporte.TabIndex = 13
        Me.fraSistemaSoporte.TabStop = False
        Me.fraSistemaSoporte.Text = "Sistemas / Soportes"
        '
        'cmdAgregarTodosSistema
        '
        Me.cmdAgregarTodosSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTodosSistema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregarTodosSistema.Location = New System.Drawing.Point(260, 52)
        Me.cmdAgregarTodosSistema.Name = "cmdAgregarTodosSistema"
        Me.cmdAgregarTodosSistema.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarTodosSistema.TabIndex = 15
        Me.cmdAgregarTodosSistema.Text = "8"
        '
        'cmdAgregarSistema
        '
        Me.cmdAgregarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarSistema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregarSistema.Location = New System.Drawing.Point(260, 20)
        Me.cmdAgregarSistema.Name = "cmdAgregarSistema"
        Me.cmdAgregarSistema.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarSistema.TabIndex = 14
        Me.cmdAgregarSistema.Text = "4"
        '
        'fraTema
        '
        Me.fraTema.Controls.Add(Me.cmdAgregarTodosTema)
        Me.fraTema.Controls.Add(Me.lstTema)
        Me.fraTema.Controls.Add(Me.cmdAgregarTema)
        Me.fraTema.Enabled = False
        Me.fraTema.Location = New System.Drawing.Point(0, 422)
        Me.fraTema.Name = "fraTema"
        Me.fraTema.Size = New System.Drawing.Size(300, 204)
        Me.fraTema.TabIndex = 14
        Me.fraTema.TabStop = False
        Me.fraTema.Text = "Temas"
        '
        'cmdAgregarTodosTema
        '
        Me.cmdAgregarTodosTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTodosTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregarTodosTema.Location = New System.Drawing.Point(260, 52)
        Me.cmdAgregarTodosTema.Name = "cmdAgregarTodosTema"
        Me.cmdAgregarTodosTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarTodosTema.TabIndex = 12
        Me.cmdAgregarTodosTema.Text = "8"
        '
        'fraSistemaSoporteAlternativa
        '
        Me.fraSistemaSoporteAlternativa.Controls.Add(Me.cmdQuitarTodasAlternativa)
        Me.fraSistemaSoporteAlternativa.Controls.Add(Me.cmdQuitarAlternativa)
        Me.fraSistemaSoporteAlternativa.Controls.Add(Me.treAlternativaSistema)
        Me.fraSistemaSoporteAlternativa.Enabled = False
        Me.fraSistemaSoporteAlternativa.Location = New System.Drawing.Point(304, 150)
        Me.fraSistemaSoporteAlternativa.Name = "fraSistemaSoporteAlternativa"
        Me.fraSistemaSoporteAlternativa.Size = New System.Drawing.Size(300, 268)
        Me.fraSistemaSoporteAlternativa.TabIndex = 14
        Me.fraSistemaSoporteAlternativa.TabStop = False
        Me.fraSistemaSoporteAlternativa.Text = "Sistemas / Soportes de la Alternativa"
        '
        'cmdQuitarTodasAlternativa
        '
        Me.cmdQuitarTodasAlternativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTodasAlternativa.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdQuitarTodasAlternativa.Location = New System.Drawing.Point(8, 52)
        Me.cmdQuitarTodasAlternativa.Name = "cmdQuitarTodasAlternativa"
        Me.cmdQuitarTodasAlternativa.Size = New System.Drawing.Size(32, 28)
        Me.cmdQuitarTodasAlternativa.TabIndex = 17
        Me.cmdQuitarTodasAlternativa.Text = "7"
        '
        'cmdQuitarAlternativa
        '
        Me.cmdQuitarAlternativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarAlternativa.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdQuitarAlternativa.Location = New System.Drawing.Point(8, 20)
        Me.cmdQuitarAlternativa.Name = "cmdQuitarAlternativa"
        Me.cmdQuitarAlternativa.Size = New System.Drawing.Size(32, 28)
        Me.cmdQuitarAlternativa.TabIndex = 16
        Me.cmdQuitarAlternativa.Text = "3"
        '
        'treAlternativaSistema
        '
        Me.treAlternativaSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treAlternativaSistema.FullRowSelect = True
        Me.treAlternativaSistema.HideSelection = False
        Me.treAlternativaSistema.Location = New System.Drawing.Point(48, 20)
        Me.treAlternativaSistema.Name = "treAlternativaSistema"
        Me.treAlternativaSistema.Size = New System.Drawing.Size(240, 240)
        Me.treAlternativaSistema.TabIndex = 1
        '
        'cmdQuitarTodosTema
        '
        Me.cmdQuitarTodosTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTodosTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdQuitarTodosTema.Location = New System.Drawing.Point(8, 52)
        Me.cmdQuitarTodosTema.Name = "cmdQuitarTodosTema"
        Me.cmdQuitarTodosTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdQuitarTodosTema.TabIndex = 19
        Me.cmdQuitarTodosTema.Text = "7"
        '
        'cmdQuitarTema
        '
        Me.cmdQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTema.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdQuitarTema.Location = New System.Drawing.Point(8, 20)
        Me.cmdQuitarTema.Name = "cmdQuitarTema"
        Me.cmdQuitarTema.Size = New System.Drawing.Size(32, 28)
        Me.cmdQuitarTema.TabIndex = 18
        Me.cmdQuitarTema.Text = "3"
        '
        'lstAlternativaTema
        '
        Me.lstAlternativaTema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstAlternativaTema.Location = New System.Drawing.Point(48, 20)
        Me.lstAlternativaTema.Name = "lstAlternativaTema"
        Me.lstAlternativaTema.Size = New System.Drawing.Size(240, 171)
        Me.lstAlternativaTema.TabIndex = 3
        '
        'fraTemaAlternativa
        '
        Me.fraTemaAlternativa.Controls.Add(Me.cmdQuitarTema)
        Me.fraTemaAlternativa.Controls.Add(Me.lstAlternativaTema)
        Me.fraTemaAlternativa.Controls.Add(Me.cmdQuitarTodosTema)
        Me.fraTemaAlternativa.Enabled = False
        Me.fraTemaAlternativa.Location = New System.Drawing.Point(308, 422)
        Me.fraTemaAlternativa.Name = "fraTemaAlternativa"
        Me.fraTemaAlternativa.Size = New System.Drawing.Size(300, 204)
        Me.fraTemaAlternativa.TabIndex = 20
        Me.fraTemaAlternativa.TabStop = False
        Me.fraTemaAlternativa.Text = "Temas de la Alternativa"
        '
        'cmdEvaluacion
        '
        Me.cmdEvaluacion.Enabled = False
        Me.cmdEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEvaluacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEvaluacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdEvaluacion.Location = New System.Drawing.Point(13, 68)
        Me.cmdEvaluacion.Name = "cmdEvaluacion"
        Me.cmdEvaluacion.Size = New System.Drawing.Size(136, 27)
        Me.cmdEvaluacion.TabIndex = 21
        Me.cmdEvaluacion.Text = "Evaluación"
        '
        'btoSeguiCPR
        '
        Me.btoSeguiCPR.Enabled = False
        Me.btoSeguiCPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoSeguiCPR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoSeguiCPR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btoSeguiCPR.Location = New System.Drawing.Point(460, 64)
        Me.btoSeguiCPR.Name = "btoSeguiCPR"
        Me.btoSeguiCPR.Size = New System.Drawing.Size(136, 27)
        Me.btoSeguiCPR.TabIndex = 82
        Me.btoSeguiCPR.Text = "Seguimiento CPR"
        '
        'abmAlternativas
        '
        Me.Controls.Add(Me.cmdEvaluacion)
        Me.Controls.Add(Me.fraTemaAlternativa)
        Me.Controls.Add(Me.fraSistemaSoporteAlternativa)
        Me.Controls.Add(Me.fraDescripcion)
        Me.Controls.Add(Me.fraSistemaSoporte)
        Me.Controls.Add(Me.fraTema)
        Me.Name = "abmAlternativas"
        Me.Size = New System.Drawing.Size(612, 641)
        Me.fraDescripcion.ResumeLayout(False)
        Me.fraDescripcion.PerformLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAlternativa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraSistemaSoporte.ResumeLayout(False)
        Me.fraTema.ResumeLayout(False)
        Me.fraSistemaSoporteAlternativa.ResumeLayout(False)
        Me.fraTemaAlternativa.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim A As New Alternativas

    Dim mModificar As Boolean
    Dim mDebeGuardar As Boolean

    Dim mSoportes As DataTable
    Dim mSoportesAlternativa As DataTable

    Dim MedioAnterior As Integer
    Dim Modif As Boolean = False
    Dim PraVez As Boolean

    Private Const MedioRadio As Integer = 6
    Dim ControlManejo As Integer

    Private Property Soportes() As DataTable
        Get
            Return mSoportes
        End Get
        Set(ByVal Value As DataTable)
            mSoportes = Value
        End Set
    End Property

    Private Property SoportesAlternativa() As DataTable
        Get
            If mSoportesAlternativa Is Nothing Then
                mSoportesAlternativa = New DataTable

                mSoportesAlternativa.Columns.Add("Sistema", System.Type.GetType("System.String"))
                mSoportesAlternativa.Columns.Add("ID_Sistema", System.Type.GetType("System.Int32"))

                mSoportesAlternativa.Columns.Add("Ejercicio", System.Type.GetType("System.String"))
                mSoportesAlternativa.Columns.Add("ID_Ejercicio", System.Type.GetType("System.Int32"))

                mSoportesAlternativa.Columns.Add("Soportes", System.Type.GetType("System.String"))
                mSoportesAlternativa.Columns.Add("ID_Soporte", System.Type.GetType("System.Int32"))

                mSoportesAlternativa.Columns.Add("ID_Medio", System.Type.GetType("System.Int32"))
            End If

            Return mSoportesAlternativa
        End Get
        Set(ByVal Value As DataTable)
            mSoportesAlternativa = Value
        End Set
    End Property

    Public ReadOnly Property Alto() As Integer Implements Framework.IABM.Alto
        Get
            Return Me.Height
        End Get
    End Property

    Public ReadOnly Property Ancho() As Integer Implements Framework.IABM.Ancho
        Get
            Return Me.Width
        End Get
    End Property

    Public Sub Cargar() Implements Framework.IABM.Cargar
        Modif = True
        MedioAnterior = Me.CboMedio.Value

        CargarAlternativas()

        Cancelar()

        Me.DebeGuardar = False
    End Sub

    Private Sub CargarAlternativas()
        A.Id_campania = Activo.IDCampaña

        'llena el combo con las alternativas
        Listas.CargarCombo(cboAlternativa, A.ObtenerPorCampaña, "id_alternativa", "descripcion", True)
        Listas.OcultarColumnas(cboAlternativa, "id_campania", "id_alternativa", "alternativa")
        Listas.OcultarHeader(cboAlternativa)


        If Me.cboAlternativa.Rows.Count = 1 Then
            cboAlternativa.Enabled = False
        Else
            cboAlternativa.Enabled = True

        End If
        If Me.cboAlternativa.Rows.Count > 0 And Not Modificar Then
            Me.cboAlternativa.SelectedRow = cboAlternativa.Rows(cboAlternativa.Rows.Count - 1)
        End If

    End Sub

    Private Sub CargarTemas()
        'carga los temas de la campaña en el tree
        A.Id_alternativa = Activo.IDAlternativa

        'Cambiar a que tome el medio del row seleccionado en el combo.
        Dim Medio As Integer = Activo.IDMedio

        If Not CboMedio.Value Is Nothing Then
            Medio = CboMedio.Value
        End If


        If Not MedioAnterior = Medio Then
            If Not Me.SoportesAlternativa Is Nothing Then
                If CboMedio.Enabled = True Then
                    PraVez = False
                    If Not PraVez Then
                        ActualizarSoportesTemas()
                        Me.SoportesAlternativa = Nothing
                    End If
                End If
            End If
        End If


        A.Id_campania = Activo.IDCampaña
        Me.Soportes = A.ObtenerSoportesCompletos(Medio)

        'AGuzzardi 18/05/2010 ----------------------------------------
        If Me.Soportes Is Nothing Then
            Me.lstAlternativaTema.Items.Clear()
            Me.treAlternativaSistema.Nodes.Clear()
            Me.treSistemaSoporte.Nodes.Clear()
            'Me.SoportesAlternativa = Nothing
        End If

        'If Medio = 0 Or Medio = 1 Or Medio = 6 Then
        If Not Soportes Is Nothing Then
            CargarTree(Me.treSistemaSoporte, Me.Soportes)
        End If
        'End If
        '---------------------------------------------------------------------
        'Para los medios 3, 4 y 5 no carga temas
        If Medio = 2 Or Medio = 3 Or Medio = 4 Or Medio = 5 Then

            MedioAnterior = Medio

            Me.CboMedio.Enabled = True
            Me.fraDescripcion.Enabled = True
            Me.fraSistemaSoporte.Enabled = True
            Me.fraSistemaSoporteAlternativa.Enabled = True
            Me.fraTema.Visible = False
            Me.fraTemaAlternativa.Visible = False
            Me.fraSistemaSoporte.Height = 475
            Me.treSistemaSoporte.Height = 444
            Me.fraSistemaSoporteAlternativa.Height = 475
            Me.treAlternativaSistema.Height = 444

        Else
            'llena la lista de temas
            Dim T As New Temas

            T.Id_campania = Activo.IDCampaña

            Listas.CargarList(lstTema, T.ObtenerTemasPorCampaña, "id_tema", "tema")

            MedioAnterior = Medio

            Me.CboMedio.Enabled = True
            Me.fraDescripcion.Enabled = True
            Me.fraSistemaSoporte.Enabled = True
            Me.fraSistemaSoporteAlternativa.Enabled = True
            Me.fraTema.Visible = True
            Me.fraTemaAlternativa.Visible = True
            Me.fraTema.Enabled = True
            Me.fraTemaAlternativa.Enabled = True
            Me.fraSistemaSoporte.Height = 267
            Me.treSistemaSoporte.Height = 240
            Me.fraSistemaSoporteAlternativa.Height = 267
            Me.treAlternativaSistema.Height = 240
        End If

    End Sub

    Public Function CargarObjeto() As Boolean Implements Framework.IABM.CargarObjeto
        With Me
            If .cboAlternativa.Text = "" Then
                Mensajes.Mensaje("Debe Ingresar la Descripción")
                .cboAlternativa.Select()
                Return False
            End If

            A.Descripcion = .cboAlternativa.Text

            A.Id_campania = Activo.IDCampaña
            A.Id_alternativa = Activo.IDAlternativa

            'Activo.Login = "pepe"

            A.F_alta = Date.Today
            A.U_alta = Activo.Login
            A.F_modi = Date.Today
            A.U_modi = Activo.Login
        End With

        Return True
    End Function

    Public Property DebeGuardar() As Boolean Implements Framework.IABM.DebeGuardar
        Get
            Return mDebeGuardar
        End Get
        Set(ByVal Value As Boolean)
            mDebeGuardar = Value
        End Set
    End Property

    Public Sub Guardar() Implements Framework.IABM.Guardar
        If Not Me.CargarObjeto Then
            Exit Sub
        End If

        If Me.cboAlternativa.Text.Trim = "" Then
            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Not Me.ControlTree Then
            Exit Sub
        End If
        'NUEVA ALTERANTIVA
        A.IniciarTransaccion()

        Try
            Dim Soportes As New Alternativas_soportes
            Dim Temas As New Alternativas_temas

            If Not Modificar Then
                Activo.IDAlternativa = A.Agregar()
                Activo.Alternativanueva = 0
            Else
                'borra todos los soportes anteriores
                Soportes.Id_campania = Activo.IDCampaña
                Soportes.Id_alternativa = Activo.IDAlternativa
                Soportes.BorrarSoportes()

                'borra todos los temas anteriores
                Temas.Id_campania = Activo.IDCampaña
                Temas.Id_alternativa = Activo.IDAlternativa
                Temas.BorrarTemas()

                A.Modificar()
            End If

            'agregar alternativas soporte
            Dim Dr As DataRow

            For Each Dr In Me.SoportesAlternativa.Rows
                With Soportes
                    .Id_alternativa = Activo.IDAlternativa
                    .Id_campania = Activo.IDCampaña
                    .Id_sistema = Dr("id_sistema")
                    .Id_ejercicio = Dr("id_ejercicio")
                    .Id_soporte = Dr("id_soporte")

                    .Agregar()
                End With
            Next

            If Me.CboMedio.Value <> 2 And Me.CboMedio.Value <> 3 Or Me.CboMedio.Value <> 4 Or Me.CboMedio.Value <> 5 Then

                'agregar alternativas temas
                Dim L As ItemLista

                For Each L In Me.lstAlternativaTema.Items
                    Temas.Id_campania = Activo.IDCampaña
                    Temas.Id_alternativa = Activo.IDAlternativa
                    Temas.Id_tema = L.ID

                    Temas.Agregar()
                Next
            End If

            A.TerminarTransaccion()
        Catch ex As Exception
            A.AbortarTransaccion()

            Me.Modificar = False

            Mensajes.Mensaje("abmAlternativas.Guardar: " & vbCrLf & ex.Message, TipoMensaje.DeError)
        End Try

        Me.DebeGuardar = False
        Me.Modificar = True

        CargarAlternativas()
        'If Not Modificar Then
        ' M() 'e.cboAlternativa.SelectedRow = cboAlternativa.Rows(cboAlternativa.Rows.Count - 1)
        ' End If
        CboMedio.Enabled = False
        cmdImprimir.Enabled = True
        cmdEliminar.Enabled = True
        cmdResumenPrograma.Enabled = True
        cmdResumenEconomico.Enabled = True
        cmdResumenInversion.Enabled = True
        If Me.CboMedio.Value = 3 Or Me.CboMedio.Value = 4 Or Me.CboMedio.Value = 5 Then
            cmdResumenInversionExt.Enabled = False
            cmdResumenPrograma.Enabled = False
            cmdResumenEconomico.Enabled = False
        End If
        If Me.CboMedio.Value = 1 Then
            Me.cmdEvaluacion.Enabled = True
        Else
            Me.cmdEvaluacion.Enabled = False
        End If

        Call Me.EnableBtnSeguimientoCPR()

    End Sub

    Public Sub LimpiarControles() Implements Framework.IABM.LimpiarControles
        Me.fraDescripcion.Enabled = True
        Me.fraSistemaSoporte.Enabled = True
        Me.fraSistemaSoporteAlternativa.Enabled = True
        Me.fraTema.Enabled = True
        Me.fraTemaAlternativa.Enabled = True

        Me.cboAlternativa.Text = ""
        cboAlternativa.Enabled = True

        Me.treAlternativaSistema.Nodes.Clear()
        Me.lstAlternativaTema.Items.Clear()

        Me.SoportesAlternativa = Nothing

        Me.CargarTemas()

        cmdImprimir.Enabled = False
        cmdEliminar.Enabled = False
        cmdEvaluacion.Enabled = False
        cmdResumenPrograma.Enabled = False
        cmdResumenEconomico.Enabled = False
        cmdResumenInversion.Enabled = False
        cmdResumenInversionExt.Enabled = False
        btoSeguiCPR.Enabled = False
    End Sub

    Public Property Modificar() As Boolean Implements Framework.IABM.Modificar
        Get
            Return mModificar
        End Get
        Set(ByVal Value As Boolean)
            mModificar = Value
        End Set
    End Property

#Region "Funciones Para Manejar los TreeViews y los ListBox"
    Private Sub AgregarTema()
        'agrega elementos a las listas
        If lstTema.SelectedItem Is Nothing Then
            Exit Sub
        End If

        'agrega en alternativa
        Me.lstAlternativaTema.ValueMember = "ID"
        Me.lstAlternativaTema.DisplayMember = "Descripcion"

        'agrega el item en la alternativa
        Me.lstAlternativaTema.Items.Add(Me.lstTema.SelectedItem)

        'lo saca de temas
        Me.lstTema.Items.RemoveAt(Me.lstTema.SelectedIndex)

        Me.DebeGuardar = True
    End Sub

    Private Sub AgregarTodosTemas()
        'carga todos los elementos de las alternativas
        Me.lstAlternativaTema.ValueMember = "ID"
        Me.lstAlternativaTema.DisplayMember = "Descripcion"

        'agrega los items en la alternativa
        Me.lstAlternativaTema.Items.AddRange(Me.lstTema.Items)

        'borra los items de temas
        Me.lstTema.Items.Clear()

        Me.DebeGuardar = True
    End Sub

    Private Sub QuitarTema()
        If Me.lstAlternativaTema.SelectedItem Is Nothing Then
            Exit Sub
        End If

        'agrega en temas
        Me.lstTema.Items.Add(Me.lstAlternativaTema.SelectedItem)

        'lo saca de alternativa
        Me.lstAlternativaTema.Items.RemoveAt(Me.lstAlternativaTema.SelectedIndex)

        Me.DebeGuardar = True
    End Sub

    Private Sub QuitarTodosTemas()
        'saca todos los temas de la alternativa y los mueve a los temas no seleccionados
        Me.lstAlternativaTema.ValueMember = "ID"
        Me.lstAlternativaTema.DisplayMember = "Descripcion"

        Me.lstTema.Items.AddRange(Me.lstAlternativaTema.Items)

        Me.lstAlternativaTema.Items.Clear()

        Me.DebeGuardar = True
    End Sub

    Private Function ObtenerNivel(ByVal Tre As TreeView) As String
        With Tre
            If Not .SelectedNode.Parent Is Nothing Then

                If Not .SelectedNode.Parent.Parent Is Nothing Then
                    Return "soporte"
                Else
                    Return "ejercicio"
                End If

            Else
                Return "sistema"
            End If
        End With
    End Function

    Private Sub AgregarSistema(ByVal Destino As DataTable, ByVal Origen As DataTable, ByVal Nodo As TreeNode)
        Dim E As TreeNode
        Dim N As TreeNode
        'creo una matriz de Nodos, porque no se puede borrar los mismos nodos que se recorren
        Dim Nodos(Nodo.Nodes.Count - 1) As TreeNode

        Nodo.Nodes.CopyTo(Nodos, 0) 'lleno la matriz con los nodos del ejercicio
        'recorre los ejercicios del sistema
        For Each E In Nodos
            Me.AgregarEjercicio(Destino, Origen, E)
        Next
    End Sub
    'Private Sub AgregarSistema(ByVal Destino As DataTable, ByVal Origen As DataTable, ByVal Nodo As TreeNode)
    '    Dim E As TreeNode
    '    Dim N As TreeNode
    '    'creo una matriz de Nodos, porque no se puede borrar los mismos nodos que se recorren
    '    Dim Nodos(Nodo.Nodes.Count - 1) As TreeNode

    '    Nodo.Nodes.CopyTo(Nodos, 0) 'lleno la matriz con los nodos del ejercicio
    '    'recorre los ejercicios del sistema
    '    For Each E In Nodos
    '        Me.AgregarEjercicio(Destino, Origen, E)
    '    Next
    'End Sub

    Private Sub AgregarEjercicio(ByVal Destino As DataTable, ByVal Origen As DataTable, ByVal Nodo As TreeNode)
        Dim N As TreeNode

        'creo una matriz de Nodos, porque no se puede borrar los mismos nodos que se recorren
        Dim Nodos(Nodo.Nodes.Count - 1) As TreeNode

        Nodo.Nodes.CopyTo(Nodos, 0) 'lleno la matriz con los nodos del ejercicio

        'recorre los soportes del ejercicio
        For Each N In Nodos
            AgregarSoporte(Destino, Origen, N, Nodo)
        Next
    End Sub

    Private Sub AgregarSoporte(ByVal Destino As DataTable, ByVal Origen As DataTable, ByVal Nodo As TreeNode, Optional ByVal Padre As TreeNode = Nothing)
        Dim idMedioSoporte As Integer
        Dim idSoporte As Integer

        'AGuzzardi 19/05/2010 -------------------------------------------------------------------------------------------------------------------------------------------------
        If ControlManejo = 2 Then
            Dim Rows() As DataRow
            Dim idmedio As Integer
            Rows = Origen.Select("ID_SOPORTE=" & Nodo.Tag & " and " & "ID_Ejercicio=" & Nodo.Parent.Tag)
            If Rows.Length > 0 Then
                idmedio = CInt(Rows(0).Item("ID_MEDIO").ToString)
                idMedioSoporte = idmedio
                idSoporte = Nodo.Tag
            End If
            Dim Soporte() As Object = {Nodo.Parent.Parent.Text, Nodo.Parent.Parent.Tag, Nodo.Parent.Text, Nodo.Parent.Tag, idmedio, Nodo.Text, Nodo.Tag}
            If Listas.FiltrarDT(Destino, "ID_Ejercicio=" & Nodo.Parent.Tag & "and ID_Soporte=" & Nodo.Tag).Rows.Count = 0 Then
                Destino.Rows.Add(Soporte)
            End If
        ElseIf ControlManejo = 1 Then
            Dim Soporte() As Object = {Nodo.Parent.Parent.Text, Nodo.Parent.Parent.Tag, Nodo.Parent.Text, Nodo.Parent.Tag, Nodo.Text, Nodo.Tag}
            If Listas.FiltrarDT(Destino, "ID_Ejercicio=" & Nodo.Parent.Tag & "and ID_Soporte=" & Nodo.Tag).Rows.Count = 0 Then
                Destino.Rows.Add(Soporte)
                Dim Rows() As DataRow
                Rows = Origen.Select("ID_SOPORTE=" & Nodo.Tag & " and " & "ID_Ejercicio=" & Nodo.Parent.Tag)
                If Rows.Length > 0 Then

                    'AG 18/12/2012 +'++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    ' Se tiene que validar la existencia de la columan ID_MEDIO si existe no cargo el valor del id_medio y si no existe
                    'entonces creo la columan y cargo el valor del id_medio Activo o del combo 

                    Dim Columnas As DataColumnCollection = Destino.Columns

                    If Columnas.Contains("ID_MEDIO") = False Then
                        Destino.Columns.Add("ID_MEDIO", System.Type.GetType("System.Int32"))
                        For Each row As DataRow In Destino.Rows
                            row.Item("ID_MEDIO") = Activo.IDMedio
                        Next
                    End If


                    For Each row As DataRow In Destino.Rows
                        If IsDBNull(row("ID_MEDIO")) Then
                            row("ID_MEDIO") = Rows(0).Item("ID_MEDIO")
                            If CInt(row("ID_MEDIO")) = CInt(Rows(0).Item("ID_MEDIO")) And CInt(row.Item("ID_SOPORTE")) = CInt(Rows(0).Item("ID_SOPORTE")) Then
                                row.Item("ID_SOPORTE") = Rows(0).Item("ID_SOPORTE").ToString
                                row.Item("ID_MEDIO") = Rows(0).Item("ID_MEDIO").ToString
                            End If
                        ElseIf CInt(row("ID_MEDIO")) <> Activo.IDMedio And IsDBNull(row("ID_SOPORTE")) Then
                            row.Item("ID_MEDIO") = Rows(0).Item("ID_MEDIO").ToString
                            row.Item("ID_SOPORTE") = Rows(0).Item("ID_SOPORTE").ToString
                        Else
                            If CInt(row("ID_MEDIO")) = CInt(Rows(0).Item("ID_MEDIO")) And CInt(row.Item("ID_SOPORTE")) = CInt(Rows(0).Item("ID_SOPORTE")) Then
                                row.Item("ID_SOPORTE") = Rows(0).Item("ID_SOPORTE").ToString
                                row.Item("ID_MEDIO") = Rows(0).Item("ID_MEDIO").ToString
                            End If
                        End If
                        idMedioSoporte = CInt(Rows(0).Item("ID_MEDIO").ToString)
                        idSoporte = CInt(Rows(0).Item("ID_SOPORTE").ToString)
                    Next

                    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    'For Each row As DataRow In Destino.Rows
                    '    If CInt(row("ID_MEDIO")) = CInt(Rows(0).Item("ID_SOPORTE")) Then
                    '        row.Item("ID_SOPORTE") = Rows(0).Item("ID_SOPORTE").ToString
                    '        row.Item("ID_MEDIO") = Rows(0).Item("ID_MEDIO").ToString
                    '    End If
                    'Next

                End If
            End If
        ElseIf ControlManejo = 3 Then
            Dim Rows() As DataRow = Origen.Select("ID_SOPORTE=" & Nodo.Tag & " and " & "ID_Ejercicio=" & Nodo.Parent.Tag)
            Dim Soporte() As Object = {Nodo.Parent.Parent.Text, Nodo.Parent.Parent.Tag, Nodo.Parent.Text, Nodo.Parent.Tag, Nodo.Text, Nodo.Tag, Rows(0)("ID_MEDIO")}

            'busca si el Dt destino tiene el soporte
            If Listas.FiltrarDT(Destino, "ID_Ejercicio=" & Nodo.Parent.Tag & "and ID_Soporte=" & Nodo.Tag).Rows.Count = 0 Then
                Destino.Rows.Add(Soporte)
            End If
            idMedioSoporte = 1
            idSoporte = Nodo.Tag
        ElseIf ControlManejo = 4 Then
            Dim RowsMedio As DataTable
            Dim idmedio As Integer
            Dim Sistemas As New Sistemas
            Sistemas.Id_campania = Activo.IDCampaña
            Sistemas.Id_sistema = CInt(Nodo.Parent.Parent.Tag)
            Sistemas.Id_ejercicio_final = CInt(Nodo.Parent.Tag)
            RowsMedio = Sistemas.ObtenermedioAlternativa

            If RowsMedio.Rows.Count > 0 Then
                idmedio = CInt(RowsMedio.Rows(0).Item("id_medio").ToString)
                Dim Soporte() As Object = {Nodo.Parent.Parent.Text, Nodo.Parent.Parent.Tag, Nodo.Parent.Text, Nodo.Parent.Tag, idmedio, Nodo.Text, Nodo.Tag}
                If Listas.FiltrarDT(Destino, "ID_Ejercicio=" & Nodo.Parent.Tag & "and ID_Soporte=" & Nodo.Tag).Rows.Count = 0 Then
                    Destino.Rows.Add(Soporte)
                End If

                idMedioSoporte = idmedio
                idSoporte = CInt(Nodo.Tag)
            End If

        End If
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'ORIGINAL ---------------------------------------------
        'Dim Soporte() As Object = {Nodo.Parent.Parent.Text, Nodo.Parent.Parent.Tag, Nodo.Parent.Text, Nodo.Parent.Tag, Nodo.Text, Nodo.Tag}
        'busca si el Dt destino tiene el soporte
        'If Listas.FiltrarDT(Destino, "ID_Ejercicio=" & Nodo.Parent.Tag & "and ID_Soporte=" & Nodo.Tag).Rows.Count = 0 Then
        '    Destino.Rows.Add(Soporte)
        'ORIGINAL ---------------------------------------------

        'saca la fila del origen
        Listas.BorrarFilaDT(Origen, "id_sistema=" & Nodo.Parent.Parent.Tag & " and id_ejercicio=" & Nodo.Parent.Tag & " and ID_soporte=" & Nodo.Tag)
        'Else
        'Dim ds As New DataSet
        'ds.Tables.Add(Destino)
        'Original -------------------------------
        'End If
        '-----------------------------------------

        'DESHABILITO BOTON DE SEGUIMIENTO CPR SI HAY SOPORTES QUE NO SEAN DE MEDIO TV CAPITAL (AN 11-11-2015)
        If Activo.IDAlternativa <> 0 Then
            Me.btoSeguiCPR.Enabled = True
            If idMedioSoporte = 1 Then
                Using SoportesDBL As New MPG.DBL.Soportes
                    Dim tipo_soporte As Integer
                    If idSoporte <> 0 And idMedioSoporte <> 0 Then
                        tipo_soporte = SoportesDBL.ObtenerTipoSoporteByMedioAndSoporte(idMedioSoporte, idSoporte)
                        If tipo_soporte <> 1 Then
                            Me.btoSeguiCPR.Enabled = False
                        End If
                    End If
                End Using
            Else
                Me.btoSeguiCPR.Enabled = False
            End If
        End If

        Dim Ejercicio As TreeNode = Nodo.Parent
        Dim Sistema As TreeNode

        Nodo.Remove()

        'si el ejercicio no tiene mas nodos, lo borra
        If Ejercicio.Nodes.Count = 0 Then
            Sistema = Ejercicio.Parent

            Ejercicio.Remove()
        Else
            Exit Sub
        End If

        'si el sistema no tiene nodos, lo borra
        If Sistema.Nodes.Count = 0 Then
            Sistema.Remove()
        End If
    End Sub

    Private Sub AgregarSistemaSoporte(ByVal SacarDe As TreeView, ByVal AgregarEn As TreeView, ByVal Origen As DataTable, ByVal Destino As DataTable)
        Select Case Me.ObtenerNivel(SacarDe)
            Case "sistema"
                AgregarSistema(Destino, Origen, SacarDe.SelectedNode)
            Case "ejercicio"
                AgregarEjercicio(Destino, Origen, SacarDe.SelectedNode)
            Case "soporte"
                AgregarSoporte(Destino, Origen, SacarDe.SelectedNode)
        End Select

        Listas.CargarTree(AgregarEn, Destino, "ID_Sistema", "Sistema", "ID_Ejercicio", "Ejercicio", "ID_Soporte", "Soportes")
        Me.DebeGuardar = True
    End Sub

    Private Sub QuitarTodosSistemaSoporte(ByVal treOrigen As TreeView, ByVal dtOrigen As DataTable, ByVal treDestino As TreeView, ByVal dtDestino As DataTable)
        Dim N As TreeNode

        'creo una matriz de Nodos, porque no se puede borrar los mismos nodos que se recorren
        Dim Nodos(treOrigen.Nodes.Count - 1) As TreeNode

        treOrigen.Nodes.CopyTo(Nodos, 0) 'lleno la matriz con los nodos del ejercicio

        'carga el tre de destino
        For Each N In Nodos
            AgregarSistema(dtDestino, dtOrigen, N)
        Next

        CargarTree(treDestino, dtDestino)

        'borra el tree y el datatable de origen
        dtOrigen.Clear()

        'For Each r As DataRow In dtOrigen.Rows
        '''r.Delete()
        'Next



        treOrigen.Nodes.Clear()

        Me.DebeGuardar = True
    End Sub

    Private Sub CargarTree(ByVal Tre As TreeView, ByVal Dt As DataTable)
        Listas.CargarTree(Tre, Dt, "ID_Sistema", "Sistema", "ID_Ejercicio", "Ejercicio", "ID_Soporte", "Soportes")
    End Sub

    Private Sub cmdAgregarTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTema.Click
        AgregarTema()
    End Sub

    Private Sub cmdAgregarTodosTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTodosTema.Click
        AgregarTodosTemas()
    End Sub

    Private Sub cmdAgregarTodosSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTodosSistema.Click
        'AGuzzardi ----------------------
        If Activo.Alternativanueva = 3 Then
            ControlManejo = 3
        Else
            ControlManejo = 1
        End If
        '-----------------------------------
        Me.QuitarTodosSistemaSoporte(Me.treSistemaSoporte, Me.Soportes, Me.treAlternativaSistema, Me.SoportesAlternativa)
    End Sub

    Private Sub cmdAgregarSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarSistema.Click
        If Me.treSistemaSoporte.Nodes.Count = 0 Or treSistemaSoporte.SelectedNode Is Nothing Then
            Exit Sub
        End If

        'AGuzzardi ----------------------
        If Activo.Alternativanueva = 3 Then
            ControlManejo = 3
        Else
            ControlManejo = 1
        End If
        '-----------------------------------

        AgregarSistemaSoporte(Me.treSistemaSoporte, Me.treAlternativaSistema, Me.Soportes, Me.SoportesAlternativa)
    End Sub

    Private Sub treSistemaSoporte_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treSistemaSoporte.DoubleClick
        If Me.treSistemaSoporte.Nodes.Count = 0 Then
            Exit Sub
        End If
        'AGuzzardi ----------------------
        If Activo.Alternativanueva = 3 Then
            ControlManejo = 3
        Else
            ControlManejo = 1
        End If
        '-----------------------------------
        AgregarSistemaSoporte(Me.treSistemaSoporte, Me.treAlternativaSistema, Me.Soportes, Me.SoportesAlternativa)

        Me.EnableBtnSeguimientoCPR()
    End Sub

    Private Sub treAlternativaSistema_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treAlternativaSistema.DoubleClick
        If Me.treAlternativaSistema.Nodes.Count = 0 Then
            Exit Sub
        End If
        'AGuzzardi ----------------------
        If Activo.Alternativanueva = 3 Then
            ControlManejo = 4 '3
        Else
            ControlManejo = 2
        End If
        '-----------------------------------

        Me.AgregarSistemaSoporte(Me.treAlternativaSistema, Me.treSistemaSoporte, Me.SoportesAlternativa, Me.Soportes)

        Me.EnableBtnSeguimientoCPR()
    End Sub

    Private Sub cmdQuitarAlternativa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarAlternativa.Click
        If Me.treAlternativaSistema.Nodes.Count = 0 Or treAlternativaSistema.SelectedNode Is Nothing Then
            Exit Sub
        End If
        'AGuzzardi ----------------------
        If Activo.Alternativanueva = 3 Then
            ControlManejo = 4 '3
        Else
            ControlManejo = 2
        End If
        '-----------------------------------
        Me.AgregarSistemaSoporte(Me.treAlternativaSistema, Me.treSistemaSoporte, Me.SoportesAlternativa, Me.Soportes)

        'DESHABILITO BOTON DE SEGUIMIENTO CPR SI HAY SOPORTES QUE NO SEAN DE MEDIO TV CAPITAL (AN 11-11-2015)
        'Me.btoSeguiCPR.Enabled = True
        Call Me.EnableBtnSeguimientoCPR()
    End Sub

    Private Sub cmdQuitarTodasAlternativa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTodasAlternativa.Click
        'AGuzzardi ----------------------
        If Activo.Alternativanueva = 3 Then
            ControlManejo = 4 '3
        Else
            ControlManejo = 2
        End If
        '-----------------------------------
        QuitarTodosSistemaSoporte(Me.treAlternativaSistema, Me.SoportesAlternativa, Me.treSistemaSoporte, Me.Soportes)
        Call Me.EnableBtnSeguimientoCPR()
    End Sub

    Private Sub cmdQuitarTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTema.Click
        QuitarTema()
    End Sub

    Private Sub cmdQuitarTodosTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTodosTema.Click
        QuitarTodosTemas()
    End Sub

    Private Sub lstTema_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTema.DoubleClick
        AgregarTema()
    End Sub

    Private Sub lstAlternativaTema_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstAlternativaTema.DoubleClick
        QuitarTema()
    End Sub

    Private Sub cboAlternativa_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlternativa.AfterCloseUp
        If cboAlternativa.Value Is Nothing OrElse cboAlternativa.SelectedRow Is Nothing OrElse cboAlternativa.SelectedRow.Cells(1).Text.Trim = "-1" Then
            Me.Modificar = False

            Me.cmdImprimir.Enabled = False
            Me.cmdEliminar.Enabled = False
            Me.cmdEvaluacion.Enabled = False
            Me.cmdResumenEconomico.Enabled = False
            Me.cmdResumenPrograma.Enabled = False
            Me.cmdResumenInversion.Enabled = False
            Me.cmdResumenInversionExt.Enabled = False
            Me.btoSeguiCPR.Enabled = False

            Me.CboMedio.SelectedRow = CboMedio.Rows(1)
            Me.CboMedio.Enabled = False

            Me.fraSistemaSoporte.Enabled = False
            Me.fraTema.Enabled = False
            Me.fraTemaAlternativa.Enabled = False
            Me.fraSistemaSoporteAlternativa.Enabled = False
            Exit Sub
        End If


        'If cboAlternativa.SelectedRow Is Nothing Then
        'Me.cmdImprimir.Enabled = True
        'Me.cmdEliminar.Enabled = True
        'Me.cmdEvaluacion.Enabled = True
        'Me.cmdResumenEconomico.Enabled = True
        'Me.cmdResumenPrograma.Enabled = True
        'Me.cmdResumenInversion.Enabled = True
        'Me.cmdResumenInversionExt.Enabled = True
        'Me.CboMedio.Enabled = True
        'End If

        If IsDBNull(cboAlternativa.Value) OrElse CStr(cboAlternativa.Value) = "" Then
            Me.Modificar = False

            'limpia el tre y el list de la alternativa
            Me.treAlternativaSistema.Nodes.Clear()
            Me.lstAlternativaTema.Items.Clear()

            Exit Sub
        End If

        frmPrincipal.Instancia.MostrarOcultarBotonToolBar(1, True)

        Dim A As New Alternativas

        A.Id_campania = Activo.IDCampaña
        A.Id_alternativa = Me.cboAlternativa.Value

        'pasa el id a la clase general
        Activo.IDAlternativa = Me.cboAlternativa.Value

        Me.SoportesAlternativa = A.ObtenerSoportesGuardados

        'carga los sistemas / ejercicios / soportes de la alternativa
        Listas.CargarTree(Me.treAlternativaSistema, Me.SoportesAlternativa, "ID_Sistema", "Sistema", "ID_Ejercicio", "Ejercicio", "ID_Soporte", "Soportes")

        'carga los temas de la alternativa
        Listas.CargarList(Me.lstAlternativaTema, A.ObtenerTemasGuardados, "id_tema", "tema")

        'Posiciona Medio
        Dim Medio As Integer = 1
        If Not Me.SoportesAlternativa Is Nothing AndAlso Me.SoportesAlternativa.Rows.Count > 0 Then
            Medio = Me.SoportesAlternativa.Rows(0)("id_medio")
        End If
        Me.Modificar = True
        Combo_Position(CboMedio, "id_medio", Medio)
        Activo.IDMedio = Medio



        'habilitación botones cuando selecciono una alternativa guardada
        cmdImprimir.Enabled = True
        cmdEliminar.Enabled = True
        cmdResumenPrograma.Enabled = True
        cmdResumenEconomico.Enabled = True
        cmdResumenInversion.Enabled = True
        Me.btoSeguiCPR.Enabled = True
        If Medio = 3 Or Medio = 4 Or Medio = 5 Then
            cmdResumenInversionExt.Enabled = False
        Else
            cmdResumenInversionExt.Enabled = True
        End If
        If Medio = 1 Then
            Me.cmdEvaluacion.Enabled = True
        Else
            Me.cmdEvaluacion.Enabled = False
        End If

        'carga los soportes en el tre principal
        CargarTemas()

        CboMedio.Enabled = False

        MedioAnterior = CboMedio.Value

        'saca los soportes que ya estan agregados en la alternativa
        ActualizarSoportesTemas()

        'DESHABILITO BOTON DE SEGUIMIENTO CPR SI HAY SOPORTES QUE NO SEAN DE MEDIO TV CAPITAL (AN 11-11-2015)
        Call Me.EnableBtnSeguimientoCPR()

        '      Me.Modificar = True
        Me.DebeGuardar = False
    End Sub

    'NUEVA FUNCION QUE SETEA EL ESTADO DE HABILITACION DEL BOTON DE SEGUIMIENTO DE CPR SEGUN SOPORTES DE LA ALTERNATIVA. (AN 11-11-2015)
    Private Sub EnableBtnSeguimientoCPR()
        ' Si no hay alternativa elegida evito el algoritmo
        If Activo.IDAlternativa = 0 Then
            Exit Sub
        End If

        Me.btoSeguiCPR.Enabled = True
        If Me.SoportesAlternativa.Rows.Count = 0 Then
            Me.btoSeguiCPR.Enabled = False
            Exit Sub
        End If
        For Each dr As DataRow In Me.SoportesAlternativa.Rows
            If Not System.DBNull.Value.Equals(dr("id_medio")) Then
                If CInt(dr("id_medio")) = 1 Then
                    Using SoportesDBL As New MPG.DBL.Soportes
                        Dim tipo_soporte As Integer
                        tipo_soporte = SoportesDBL.ObtenerTipoSoporteByMedioAndSoporte(CInt(dr("id_medio")), CInt(dr("id_soporte")))
                        If tipo_soporte <> 1 Then
                            Me.btoSeguiCPR.Enabled = False
                            Exit For
                        End If
                    End Using
                Else
                    Me.btoSeguiCPR.Enabled = False
                    Exit For
                End If
            Else
                Me.btoSeguiCPR.Enabled = False
                Exit For
            End If
        Next
    End Sub

    Private Sub Combo_Position(ByVal pCombo As cboCombo, ByVal pColumnName As String, ByVal pValue As String)
        For Each Row As Infragistics.Win.UltraWinGrid.UltraGridRow In pCombo.Rows
            If Not Row.Cells(pColumnName).Value Is DBNull.Value Then
                If Row.Cells(pColumnName).Value = pValue Then
                    pCombo.SelectedRow = Row
                    Exit Sub
                End If
            End If
        Next
        pCombo.SelectedRow = pCombo.Rows(0)
    End Sub

    Private Sub ActualizarSoportesTemas()
        'saca los soportes que ya estan agregados en la alternativa
        Dim Dr As DataRow

        For Each Dr In Me.SoportesAlternativa.Rows
            Listas.BorrarFilaDT(Me.Soportes, "id_sistema= " & Dr("id_sistema") & " and id_ejercicio= " & Dr("id_ejercicio") & "and id_soporte= " & Dr("id_soporte"))
        Next

        'Aguzzardi 19/05/2010 ---------------------------------------------
        If Not Me.Soportes Is Nothing Then
            CargarTree(Me.treSistemaSoporte, Me.Soportes)
        End If
        'Original ----------------------------------------------------------------
        'CargarTree(Me.treSistemaSoporte, Me.Soportes)
        '--------------------------------------------------------------------------

        'saca los temas que ya estan agregados en la alternativa
        Dim L As ItemLista

        For Each L In Me.lstAlternativaTema.Items
            Listas.BorrarItemList(Me.lstTema, L.ID)
        Next
    End Sub

    Public Sub Cancelar() Implements Framework.IABM.Cancelar
        Me.treSistemaSoporte.Nodes.Clear()
        Me.treAlternativaSistema.Nodes.Clear()
        Me.lstTema.Items.Clear()
        Me.lstAlternativaTema.Items.Clear()

        Me.CargarAlternativas()

        'solo desactiva el Frame si la campaña no tiene alternativas
        If Me.cboAlternativa.Rows.Count = 1 Then
            cboAlternativa.Enabled = False
        Else
            cboAlternativa.Enabled = True
        End If


        ''jsperk - Se toma el Medio segun el sistema seleccionado y se setea en el combo.
        For index As Integer = 0 To CboMedio.Rows.Count - 1
            If CboMedio.Rows(index).Cells(0).Value = Activo.IDMedio Then
                CboMedio.SelectedRow = CboMedio.Rows(index)
                Exit For
            End If
        Next

        Me.CboMedio.Enabled = False

        Me.fraSistemaSoporte.Enabled = False
        Me.fraSistemaSoporteAlternativa.Enabled = False
        Me.fraTema.Enabled = False
        Me.fraTemaAlternativa.Enabled = False

        Me.SoportesAlternativa = Nothing
        Me.Soportes = Nothing

        Me.cboAlternativa.Text = ""
        Me.cboAlternativa.Value = ""
    End Sub
#End Region

#Region "Cambia el Color de Fondo de los Trees y Lists"
    Private Sub fraSistemaSoporte_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraSistemaSoporte.EnabledChanged
        If Me.fraSistemaSoporte.Enabled Then
            Me.treSistemaSoporte.BackColor = SystemColors.Window
        Else
            Me.treSistemaSoporte.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub fraSistemaSoporteAlternativa_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraSistemaSoporteAlternativa.EnabledChanged
        If Me.fraSistemaSoporteAlternativa.Enabled Then
            Me.treAlternativaSistema.BackColor = SystemColors.Window
        Else
            Me.treAlternativaSistema.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub fraTema_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraTema.EnabledChanged
        If Me.fraTema.Enabled Then
            Me.lstTema.BackColor = SystemColors.Window
        Else
            Me.lstTema.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub fraTemaAlternativa_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraTemaAlternativa.EnabledChanged
        If Me.fraTemaAlternativa.Enabled Then
            Me.lstAlternativaTema.BackColor = SystemColors.Window
        Else
            Me.lstAlternativaTema.BackColor = SystemColors.InactiveBorder
        End If
    End Sub
#End Region

    Private Sub cboAlternativa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlternativa.TextChanged
        DebeGuardar = True
    End Sub

    Private Function ControlTree() As Boolean
        If Me.treAlternativaSistema.GetNodeCount(True) = 0 Then
            MsgBox("Debe Seleccionar por lo Menos UN Soporte", MsgBoxStyle.Information)
            Return False
        End If
        If Me.lstAlternativaTema.Items.Count = 0 AndAlso (Me.CboMedio.Value <> 2 And Me.CboMedio.Value <> 3 And Me.CboMedio.Value <> 4 And Me.CboMedio.Value <> 5) Then
            MsgBox("Debe Seleccionar por lo Menos UN Tema", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub cmdEvaluacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEvaluacion.Click
        If Me.cboAlternativa.Text = "" Then
            Exit Sub
        End If
        If Not ControlTree() Then
            Exit Sub
        End If
        If Activo.IDMedio = MedioRadio Then
            Mensajes.Mensaje("La alternativa seleccionada no es de medio tv.", TipoMensaje.Informacion)
            Exit Sub
        End If
        Dim F As New frmEvaluar

        F.Id_Campania = Activo.IDCampaña
        F.Id_Alternativa = Me.cboAlternativa.Value

        F.ShowDialog()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If Activo.IDCampaña <= 0 Then
            MessageBox.Show("Debe Seleccionar una Campaña", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Activo.IDAlternativa <= 0 Then
            MessageBox.Show("Debe Seleccionar una Alernativa", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Not Me.CargarObjeto OrElse Not Me.ControlTree Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim Alternativa As New Alternativas
        Alternativa.Id_campania = Activo.IDCampaña
        Alternativa.Id_alternativa = Activo.IDAlternativa
        Alternativa.Borrar()

        Dim Soportes As New Alternativas_soportes
        Soportes.Id_campania = Activo.IDCampaña
        Soportes.Id_alternativa = Activo.IDAlternativa
        Soportes.Borrar()
        Dim medio = Me.CboMedio.Value

        If Me.CboMedio.Value <> 3 And Me.CboMedio.Value <> 4 And Me.CboMedio.Value <> 5 Then
            Dim Temas As New Alternativas_temas
            Temas.Id_campania = Activo.IDCampaña
            Temas.Id_alternativa = Activo.IDAlternativa
            Temas.Borrar()
        End If

        Call Cancelar()
        cmdImprimir.Enabled = False
        cmdEliminar.Enabled = False
        cmdEvaluacion.Enabled = False
        cmdResumenPrograma.Enabled = False
        cmdResumenEconomico.Enabled = False
        cmdResumenInversion.Enabled = False
        cmdResumenInversionExt.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If cboAlternativa.Text = "" Then
            Exit Sub
        End If
        If Not ControlTree() Then
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim P As New Plazas
        Dim Plazas As DataTable
        Dim PlazasMostradas As New ArrayList

        Plazas = P.PorAlternativa(Activo.IDCampaña, Activo.IDAlternativa)

        Dim plazasId As New List(Of Integer)
        Dim plazasDescripcion As New List(Of String)
        plazasId = Plazas.AsEnumerable().Select(Function(dr) CInt(dr(0).ToString())).ToList()
        plazasDescripcion = Plazas.AsEnumerable().Select(Function(dr) dr(2).ToString()).ToList()

        For Each Dr As DataRow In Plazas.Rows
            If Not PlazasMostradas.Contains(Dr("id_plaza")) Then
                PlazasMostradas.Add(Dr("id_plaza"))

                Dim F As New frmFormulaOne
                F.Descripcion = cboAlternativa.Text
                If Me.CboMedio.Value = 4 Or Me.CboMedio.Value = 5 Then
                    F.CargarReporteCalendarioDiarioPrensa(Dr("id_plaza"), Dr("descripcion"))
                ElseIf Me.CboMedio.Value = 3 Then
                    F.CargarReporteCalendarioDiarioExterior(Dr("id_plaza"), Dr("descripcion"))
                ElseIf Me.CboMedio.Value = 2 Then
                    F.CargarReporteCalendarioDiarioInternet(Dr("id_plaza"), Dr("descripcion"))
                Else
                    Try
                        F.CargarReporteCalendarioDiarioNew(plazasId, plazasDescripcion, cboAlternativa.Text)
                    Catch ex As Exception
                        Dim err As String = ex.Message
                        MessageBox.Show("Hubo un error en la confección del calendario diario", "Calendario Diario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    If F.Cancelar Then
                        Me.Cursor = Cursors.Default
                        F.Close()

                        Exit Sub
                    End If
                    F.Show()
                    Exit For
                End If

                If F.Cancelar Then
                    Me.Cursor = Cursors.Default
                    F.Close()

                    Exit Sub
                End If

                F.Show()
            End If
        Next

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdResumenPrograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResumenPrograma.Click
        'RESUMEN DE PROGRAMAS
        If cboAlternativa.Text = "" Then
            Exit Sub
        End If
        If Not ControlTree() Then
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor



        Dim P As New Plazas
        Dim Plazas As DataTable
        Dim PlazasMostradas As New ArrayList

        Plazas = P.PorAlternativa(Activo.IDCampaña, Activo.IDAlternativa)

        For Each Dr As DataRow In Plazas.Rows
            If Not PlazasMostradas.Contains(Dr("id_plaza")) Then
                PlazasMostradas.Add(Dr("id_plaza"))

                Dim F As New frmFormulaOne
                F.Descripcion = cboAlternativa.Text
                F.CargarReporteResumenPrograma(Dr("id_plaza"), Dr("descripcion"))

                F.Show()

                If F.Cancelar Then
                    F.Close()
                End If
            End If

        Next

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdResumenEconomico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResumenEconomico.Click
        'RESUMEN ECONOMICO


        If cboAlternativa.Text = "" Then
            Exit Sub
        End If
        If Not ControlTree() Then
            Exit Sub
        End If

        Dim s As New Spots_detalle

        If s.ResumenEconomico_Ver_Franjas(Activo.IDCampaña).Rows.Count = 0 And Activo.IDMedio <> MedioRadio Then
            If Mensajes.Mensaje("No se ha Seleccionado una Franja en el Sistema. ¿Desea Generar el Resumen Economico Sin el Desglose por Franjas?", TipoMensaje.SiNo) = DialogResult.No Then
                Exit Sub
            End If
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim P As New Plazas
        Dim Plazas As DataTable
        Plazas = P.PorAlternativa(Activo.IDCampaña, Activo.IDAlternativa)

        For Each Dr As DataRow In Plazas.Rows
            Dim F As New frmFormulaOne
            F.Descripcion = Me.cboAlternativa.Text
            If Activo.IDMedio <> MedioRadio Then
                F.CargarReporteResumenEconomico(Dr("id_plaza"), Dr("descripcion"), Dr("id_sistema"))
            Else
                F.CargarReporteResumenEconomicoRadio(Dr("id_plaza"), Dr("descripcion"), Dr("id_sistema"))
            End If

            F.Show()

            If F.Cancelar Then
                F.Close()
            End If
        Next

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdResumenInversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResumenInversion.Click
        If cboAlternativa.Text = "" Then
            Exit Sub
        End If
        If Not ControlTree() Then
            Exit Sub
        End If
        Dim frmCub As New Cubo
        Dim dt As DataTable
        Dim c As New Cubo_Listados



        c.Id_Campania = Activo.IDCampaña
        c.Id_Alternativa = Activo.IDAlternativa

        Try
            dt = c.Cubo_Inversion

            frmCub.Nombre = "CuboInversion"
            frmCub.Titulo = "Resumen de inversión" & Chr(13) & _
                "Cliente: " & Activo.Cliente & Chr(13) & _
                "Campaña: " & Activo.Campaña

            frmCub.Modo = 0
            frmCub.DataTableCub = dt
            frmCub.Show()
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)
        End Try
    End Sub

    Private Sub cmdResumenInversionExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResumenInversionExt.Click

        If cboAlternativa.Text = "" Then
            Exit Sub
        End If
        If Not ControlTree() Then
            Exit Sub
        End If
        Dim frmCub As New Cubo
        Dim dt As DataTable
        Dim c As New Cubo_Listados


        c.Id_Campania = Activo.IDCampaña
        c.Id_Alternativa = Activo.IDAlternativa

        Try
            dt = c.Cubo_InversionExt

            frmCub.Nombre = "CuboInversionExt"
            frmCub.Titulo = "Resumen de inversión Extendida" & Chr(13) & _
                "Cliente: " & Activo.Cliente & Chr(13) & _
                "Campaña: " & Activo.Campaña

            frmCub.Modo = 0
            frmCub.DataTableCub = dt
            frmCub.Show()
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)
        End Try
    End Sub

    Private Sub abmAlternativas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Medio As New Soportes
        PraVez = True
        Listas.CargarCombo(Me.CboMedio, Medio.ObtenerMediosActivos, "Id_Medio", "descripcion")

        Listas.OcultarColumnas(CboMedio, "Id_Medio")
        Listas.OcultarHeader(CboMedio)

        'Jsperk - Verifico cual es el medio que se encuentra activo y lo selecciono en el combo de medios.
        For index As Integer = 0 To CboMedio.Rows.Count - 1
            If CboMedio.Rows(index).Cells(0).Value = Activo.IDMedio Then
                CboMedio.SelectedRow = CboMedio.Rows(index)
                Exit For
            End If
        Next
    End Sub

    Private Sub treSistemaSoporte_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treSistemaSoporte.AfterSelect

    End Sub

    Private Sub cboAlternativa_AfterColPosChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterColPosChangedEventArgs) Handles cboAlternativa.AfterColPosChanged

    End Sub

    Private Sub fraSistemaSoporte_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraSistemaSoporte.Enter

    End Sub

    Private Sub fraDescripcion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraDescripcion.Enter

    End Sub

    Private Sub CboMedio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.ValueChanged

        If Not Me.Modificar Then 'Si cargo el CboMedio 
            If Not MedioAnterior = CboMedio.Value Then
                If CboMedio.Enabled = True Then
                    PraVez = False
                    If Not PraVez Then
                        Me.lstAlternativaTema.Items.Clear()
                        Me.treAlternativaSistema.Nodes.Clear()
                        Me.SoportesAlternativa = Nothing
                    End If
                End If
            End If
        End If

        'carga los soportes en el tre principal
        CargarTemas()

    End Sub

    Private Sub CboMedio_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles CboMedio.InitializeLayout

    End Sub

    Private Sub btoSeguiCPR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoSeguiCPR.Click

        If cboAlternativa.Text = "" Then
            Exit Sub
        End If
        If Not ControlTree() Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim P As New Plazas
        Dim Plazas As DataTable
        Dim PlazasMostradas As New ArrayList
        'Dim FrmSeguimientoCPR As New FrmSeguimientoCPR
        Dim ObSistemas As New Sistemas

        '+++ AG Cargo los parametros al Formulario Seguimientop CPR ++++++++
        'For Each Dr As DataRow In SoportesAlternativa.Rows
        '    FrmSeguimientoCPR.IdCampania = Activo.IDCampaña
        '    FrmSeguimientoCPR.IdSistema = Dr("id_sistema")
        '    FrmSeguimientoCPR.IdAlternativa = Activo.IDAlternativa
        '    ObSistemas.Id_campania = Activo.IDCampaña
        '    ObSistemas.Id_sistema = Dr("id_sistema")
        '    ObSistemas.BuscarPorID()
        '    FrmSeguimientoCPR.FDesde = ObSistemas.F_inicio
        '    FrmSeguimientoCPR.FHasta = ObSistemas.F_fin
        '    FrmSeguimientoCPR.IdTarget = ObSistemas.Id_target_1
        '    FrmSeguimientoCPR.IdTarget2 = ObSistemas.Id_target_2 'AG 15/03/2013
        '    Exit For
        'Next
        'FrmSeguimientoCPR.DtDatosAlternativa = Me.SoportesAlternativa
        'FrmSeguimientoCPR.Show()
        '++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim FrmSeguimientoCPR As New frmSeguimientoCPRxFranjaHoraria(Me.SoportesAlternativa)
        FrmSeguimientoCPR.Show()

        Me.Cursor = Cursors.Default
    End Sub

End Class
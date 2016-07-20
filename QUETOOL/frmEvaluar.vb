Imports System.IO

Public Class frmEvaluar

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
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaInicio As QUETOOL.dtpFecha
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pgbProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpMenorFecha As QUETOOL.dtpFecha
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAlternativa As System.Windows.Forms.Label
    Friend WithEvents fraFechas As System.Windows.Forms.GroupBox
    Friend WithEvents fraTomm As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAbrirDlg As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents lblAnuncio As System.Windows.Forms.Label
    Friend WithEvents cboTarget1 As QUETOOL.cboComboWindows
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanal As System.Windows.Forms.CheckBox
    Friend WithEvents chkTema As System.Windows.Forms.CheckBox
    Friend WithEvents chkSemana As System.Windows.Forms.CheckBox
    Friend WithEvents rdbCaldendario As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSietedias As System.Windows.Forms.RadioButton
    Friend WithEvents npdFrec As System.Windows.Forms.NumericUpDown
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.fraFechas = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbSietedias = New System.Windows.Forms.RadioButton
        Me.rdbCaldendario = New System.Windows.Forms.RadioButton
        Me.chkSemana = New System.Windows.Forms.CheckBox
        Me.chkTema = New System.Windows.Forms.CheckBox
        Me.chkCanal = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.npdFrec = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboTarget1 = New QUETOOL.cboComboWindows
        Me.dtpMenorFecha = New QUETOOL.dtpFecha
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFechaInicio = New QUETOOL.dtpFecha
        Me.Label5 = New System.Windows.Forms.Label
        Me.pgbProgreso = New System.Windows.Forms.ProgressBar
        Me.lblEstado = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblAlternativa = New System.Windows.Forms.Label
        Me.fraTomm = New System.Windows.Forms.GroupBox
        Me.cmdAbrirDlg = New System.Windows.Forms.Button
        Me.lblArchivo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblAnuncio = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.fraFechas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.npdFrec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMenorFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.fraTomm.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(292, 272)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(372, 272)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Salir"
        '
        'fraFechas
        '
        Me.fraFechas.Controls.Add(Me.GroupBox1)
        Me.fraFechas.Controls.Add(Me.Label4)
        Me.fraFechas.Controls.Add(Me.npdFrec)
        Me.fraFechas.Controls.Add(Me.Label3)
        Me.fraFechas.Controls.Add(Me.cboTarget1)
        Me.fraFechas.Controls.Add(Me.dtpMenorFecha)
        Me.fraFechas.Controls.Add(Me.Label1)
        Me.fraFechas.Controls.Add(Me.dtpFechaInicio)
        Me.fraFechas.Controls.Add(Me.Label5)
        Me.fraFechas.Location = New System.Drawing.Point(4, 88)
        Me.fraFechas.Name = "fraFechas"
        Me.fraFechas.Size = New System.Drawing.Size(448, 148)
        Me.fraFechas.TabIndex = 20
        Me.fraFechas.TabStop = False
        Me.fraFechas.Text = "Fecha de simulacion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbSietedias)
        Me.GroupBox1.Controls.Add(Me.rdbCaldendario)
        Me.GroupBox1.Controls.Add(Me.chkSemana)
        Me.GroupBox1.Controls.Add(Me.chkTema)
        Me.GroupBox1.Controls.Add(Me.chkCanal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 64)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes"
        '
        'rdbSietedias
        '
        Me.rdbSietedias.Enabled = False
        Me.rdbSietedias.Location = New System.Drawing.Point(296, 40)
        Me.rdbSietedias.Name = "rdbSietedias"
        Me.rdbSietedias.Size = New System.Drawing.Size(96, 16)
        Me.rdbSietedias.TabIndex = 6
        Me.rdbSietedias.Text = "Pauta"
        '
        'rdbCaldendario
        '
        Me.rdbCaldendario.Enabled = False
        Me.rdbCaldendario.Location = New System.Drawing.Point(296, 20)
        Me.rdbCaldendario.Name = "rdbCaldendario"
        Me.rdbCaldendario.Size = New System.Drawing.Size(96, 16)
        Me.rdbCaldendario.TabIndex = 5
        Me.rdbCaldendario.Text = "Calendario"
        '
        'chkSemana
        '
        Me.chkSemana.Location = New System.Drawing.Point(212, 28)
        Me.chkSemana.Name = "chkSemana"
        Me.chkSemana.Size = New System.Drawing.Size(72, 16)
        Me.chkSemana.TabIndex = 4
        Me.chkSemana.Text = "Semana"
        '
        'chkTema
        '
        Me.chkTema.Location = New System.Drawing.Point(112, 28)
        Me.chkTema.Name = "chkTema"
        Me.chkTema.Size = New System.Drawing.Size(54, 16)
        Me.chkTema.TabIndex = 3
        Me.chkTema.Text = "Temas"
        '
        'chkCanal
        '
        Me.chkCanal.Location = New System.Drawing.Point(12, 28)
        Me.chkCanal.Name = "chkCanal"
        Me.chkCanal.Size = New System.Drawing.Size(56, 16)
        Me.chkCanal.TabIndex = 2
        Me.chkCanal.Text = "Canal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Contactos (frec.)"
        '
        'npdFrec
        '
        Me.npdFrec.Location = New System.Drawing.Point(328, 48)
        Me.npdFrec.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.npdFrec.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.npdFrec.Name = "npdFrec"
        Me.npdFrec.Size = New System.Drawing.Size(60, 20)
        Me.npdFrec.TabIndex = 81
        Me.npdFrec.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Target"
        '
        'cboTarget1
        '
        Me.cboTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTarget1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTarget1.Location = New System.Drawing.Point(60, 20)
        Me.cboTarget1.Name = "cboTarget1"
        Me.cboTarget1.Size = New System.Drawing.Size(380, 21)
        Me.cboTarget1.TabIndex = 79
        '
        'dtpMenorFecha
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpMenorFecha.Appearance = Appearance1
        Me.dtpMenorFecha.Enabled = False
        Me.dtpMenorFecha.FlatMode = True
        Me.dtpMenorFecha.Location = New System.Drawing.Point(318, 20)
        Me.dtpMenorFecha.Name = "dtpMenorFecha"
        Me.dtpMenorFecha.Size = New System.Drawing.Size(120, 21)
        Me.dtpMenorFecha.TabIndex = 77
        Me.dtpMenorFecha.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(236, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Inicio del primer sistema"
        Me.Label1.Visible = False
        '
        'dtpFechaInicio
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaInicio.Appearance = Appearance2
        Me.dtpFechaInicio.FlatMode = True
        Me.dtpFechaInicio.Location = New System.Drawing.Point(60, 48)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(172, 21)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Inicio"
        '
        'pgbProgreso
        '
        Me.pgbProgreso.Location = New System.Drawing.Point(4, 260)
        Me.pgbProgreso.Name = "pgbProgreso"
        Me.pgbProgreso.Size = New System.Drawing.Size(444, 8)
        Me.pgbProgreso.TabIndex = 21
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(4, 240)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(444, 16)
        Me.lblEstado.TabIndex = 22
        Me.lblEstado.Text = "Esperando para comenzar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAlternativa)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 52)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alternativa"
        '
        'lblAlternativa
        '
        Me.lblAlternativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlternativa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlternativa.ForeColor = System.Drawing.Color.Blue
        Me.lblAlternativa.Location = New System.Drawing.Point(12, 20)
        Me.lblAlternativa.Name = "lblAlternativa"
        Me.lblAlternativa.Size = New System.Drawing.Size(428, 21)
        Me.lblAlternativa.TabIndex = 0
        Me.lblAlternativa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fraTomm
        '
        Me.fraTomm.Controls.Add(Me.cmdAbrirDlg)
        Me.fraTomm.Controls.Add(Me.lblArchivo)
        Me.fraTomm.Controls.Add(Me.Label2)
        Me.fraTomm.Location = New System.Drawing.Point(8, 110)
        Me.fraTomm.Name = "fraTomm"
        Me.fraTomm.Size = New System.Drawing.Size(448, 52)
        Me.fraTomm.TabIndex = 80
        Me.fraTomm.TabStop = False
        Me.fraTomm.Text = "Archivo para importar en TomMicro"
        '
        'cmdAbrirDlg
        '
        Me.cmdAbrirDlg.Location = New System.Drawing.Point(420, 21)
        Me.cmdAbrirDlg.Name = "cmdAbrirDlg"
        Me.cmdAbrirDlg.Size = New System.Drawing.Size(20, 20)
        Me.cmdAbrirDlg.TabIndex = 7
        Me.cmdAbrirDlg.Text = "..."
        '
        'lblArchivo
        '
        Me.lblArchivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArchivo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblArchivo.Location = New System.Drawing.Point(96, 21)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(320, 20)
        Me.lblArchivo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Archivo"
        '
        'lblAnuncio
        '
        Me.lblAnuncio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnuncio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnuncio.ForeColor = System.Drawing.Color.Blue
        Me.lblAnuncio.Location = New System.Drawing.Point(12, 56)
        Me.lblAnuncio.Name = "lblAnuncio"
        Me.lblAnuncio.Size = New System.Drawing.Size(428, 28)
        Me.lblAnuncio.TabIndex = 81
        Me.lblAnuncio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 24)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(480, 104)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(96, 134)
        Me.ListBox1.TabIndex = 83
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(148, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 24)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Button2"
        Me.Button2.Visible = False
        '
        'frmEvaluar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(458, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAnuncio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.pgbProgreso)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.fraFechas)
        Me.Controls.Add(Me.fraTomm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEvaluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Evaluación"
        Me.fraFechas.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.npdFrec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMenorFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.fraTomm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim IDnuevo As Long
    Dim mId_Alternativa As Int32
    Dim mId_Campania As Int32
    Dim mTipo_Evaluacion As Integer ' 1 abierta, 2 cable, 3 interior 4 abierta y cable
    Dim dtSopAlternativas As DataTable
    Dim dtTemas As DataTable
    Dim Alter As New Alternativas
    Dim Cod_SPS As Long
    Dim CantSpotInsertados As Integer
    Dim UltimoFspot As Date
    Dim MayorFecha As Date
    Dim dtSoportesIbope As New DataTable
    Dim ConEvaluador As Boolean = False
    Dim TipoMedicion As Medicion
    Dim Fechas As New ArrayList
    Dim IdPlaza As Integer
    Dim auxSoporte As Integer
    Dim Reportes As New ArrayList
    Dim Totales As New ArrayList
    Dim idArchivo As String

    ' id's de la view de tipo_soportes
    Const TVA = 0
    Const TVI = 1
    Const TVC = 2

    Dim Tipo_soportes() As Boolean = {False, False, False}

    Public Property Id_Campania()
        Get
            Id_Campania = mId_Campania
        End Get
        Set(ByVal Value)
            mId_Campania = Value
        End Set
    End Property

    Public Property Id_Alternativa()
        Get
            Id_Alternativa = mId_Alternativa
        End Get
        Set(ByVal Value)
            mId_Alternativa = Value
        End Set
    End Property

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim ds As DataSet
        Dim P As New Pautas_mp

        If npdFrec.Value < 4 Or npdFrec.Value > 20 Then
            Mensajes.Mensaje("El Numero de Contactos debe estar entre 4 y 20", TipoMensaje.Informacion)
            Exit Sub
        End If

        If chkSemana.Checked Then
            If Me.rdbCaldendario.Checked = False And Me.rdbSietedias.Checked = False Then
                Mensajes.Mensaje("Debe elegir un tipo de semana", TipoMensaje.Informacion)
                Exit Sub
            End If
        End If

        IDnuevo = P.NuevoID + 1

        Try
            Cursor.Current = Cursors.WaitCursor

            If Not ValidarSeleccionSoportes() Then
                Exit Sub
            End If

            If Me.mTipo_Evaluacion <> 3 Then
                If Not FechasOk() Then
                    Exit Sub
                End If
            Else
                If Me.ConEvaluador Then
                    If Me.TipoMedicion = Medicion.PeopleMeter Then
                        If Not FechasOk() Then
                            Exit Sub
                        End If
                    ElseIf Me.TipoMedicion = Medicion.Cuadernillo Then

                        If dtpFechaInicio.Value.DayOfWeek <> DayOfWeek.Monday Then
                            MsgBox("La fecha de Inicio debe ser Lunes", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        Dim S As New Soportes
                        S.Id_soporte = auxSoporte
                        S.Id_medio = Activo.IDMedio
                        S.BuscarPorID_Soporte()

                        Dim fa As New Audiencias_fechas
                        fa.Id_plaza = S.Id_plaza
                        fa.Id_medio = S.Id_medio
                        fa.Id_tipo_soporte = S.Id_tipo_soporte
                        fa.F_inicio = Me.dtpFechaInicio.Value

                        If Not fa.ExisteSemana Then
                            MsgBox("No Se encuentra la Semana", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    End If
                End If
            End If
            Application.DoEvents()
            lblEstado.Text = "Procesando"
            ' traigo el codigo para la alternativa
            ds = Alter.EjecutarSQL("select sq_avisos_nautilus.nextval from dual")
            Cod_SPS = ds.Tables(0).Rows(0)(0)

            pgbProgreso.Maximum = dtSopAlternativas.Rows.Count
            ' cargo los temas a evaluar.
            dtTemas = Alter.ObtenerTemasGuardados

            If Not GuardarProductos(dtTemas) Then
                Exit Sub
            End If
            CantSpotInsertados = 0

            If Me.mTipo_Evaluacion = 3 Then
                If Not ConEvaluador Then
                    If lblArchivo.Text <> "" Then
                        If Cantidad_Semanas_Alternativa() < 24 Then
                            ProcesaInterior()
                            lblEstado.Text = "El proceso finalizo con exito"
                            'Mensajes.Mensaje("Se insertaron " & CantSpotInsertados & " spots para evaluar en el archivo " & Chr(13) & lblArchivo.Text)
                        Else
                            lblEstado.Text = "El proceso finalizo con errores"
                            Mensajes.Mensaje("Para plazas de interior no puede mandar a evaluar un período mayor a 23 semanas")
                        End If
                    Else
                        Mensajes.Mensaje("Debe ingresar el archivo de salida")
                    End If
                Else

                    If Cantidad_Semanas_Alternativa() < 24 Then
                        Me.ProcesaInteriorNuevo()

                        If Not EvaluarMotorP() Then
                            Throw (New Exception("Error Previo a Ejecutar MotorP"))
                        Else
                            lblEstado.Text = "El proceso finalizo con exito"
                            ' Mensajes.Mensaje("Se insertaron " & CantSpotInsertados & " spots para evaluar en el archivo " & Chr(13) & lblArchivo.Text)
                        End If
                    Else
                            Mensajes.Mensaje("Para plazas de interior no puede mandar a evaluar un período mayor a 23 semanas")
                        End If
                        'EvaluarMotorP()
                    End If
            Else
                For Each row As DataRow In dtSopAlternativas.Rows
                    lblEstado.Text = "Procesando soporte " & row("soportes")
                    Procesar(row("id_sistema"), row("id_ejercicio"), row("id_soporte"))
                    pgbProgreso.Increment(1)
                Next
                Application.DoEvents()
                If Not EvaluarMotorP() Then
                    'Throw (New Exception("Error Previo a Ejecutar MotorP"))
                    lblEstado.Text = "El proceso finalizo con errores"
                Else

                    lblEstado.Text = "El proceso finalizo con exito"
                    'Mensajes.Mensaje("Se e " & CantSpotInsertados & " spots para evaluar, ahora debe ingresar a Nautilus" & Chr(13) & " para realizar la evaluación usando el período " & dtpFechaInicio.Value & " - " & UltimoFspot)
                End If



            End If

            Cursor.Current = Cursors.Default


        Catch ex As Exception
            lblEstado.Text = "Proceso finalizado con errores"
            Mensajes.Mensaje(ex.Message)
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Function Cantidad_Semanas_Alternativa() As Integer
        Dim ret As Integer
        ret = DateDiff(DateInterval.Day, dtpMenorFecha.Value, MayorFecha)

        Cantidad_Semanas_Alternativa = Int(ret / 7)
    End Function

    Private Function esAlternativaInterior() As Boolean
        Dim s As New Soportes

        s.Id_soporte = dtSopAlternativas.Rows(0).Item("id_soporte")
        s.Id_medio = Activo.IDMedio
        s.BuscarPorID_Soporte()
        Select Case s.Id_tipo_soporte - 1
            Case TVA
                esAlternativaInterior = False
            Case TVC
                esAlternativaInterior = False
            Case TVI
                esAlternativaInterior = True
        End Select

    End Function

    Private Function GuardarProductos(ByVal dt As DataTable) As Boolean
        Dim p As New Productos_Nautilus
        Dim cli As New Clientes
        Dim ds As DataSet
        Dim desc As String


        ' debo insetar un solo producto con el sequence
        p.Cod_Sps = Cod_SPS
        desc = dt.Rows(0).Item("descripcion")
        If desc.Length >= 32 Then
            desc = desc.Substring(0, 32)
        End If

        p.Nom_Sps = mId_Campania & " " & desc & " " & Now.ToShortDateString & " " & Now.ToShortTimeString
        p.Sec_Sps = 90
        p.Gru_Sps = 90
        p.Pro_Sps = 90
        ' &&&& agregarlo a un spk
        ds = Alter.EjecutarSQL("select cod_cli_nau from clientes_sigeme_nautilus where cod_cli_sig = " & Activo.IDCliente)
        If ds.Tables(0).Rows.Count > 0 Then

            p.Can_Sps = ds.Tables(0).Rows(0)(0)
            p.Fal_Sps = Now.ToShortDateString
            p.Agregar()
            GuardarProductos = True
        Else
            Mensajes.Mensaje("No se ha hecho la relación de cliente Sigeme - Nautilus", TipoMensaje.Informacion)
            GuardarProductos = False
        End If

    End Function

    Private Sub GuardarAviso(ByVal fecha As Date, ByVal id_soporte As Int32, ByVal minuto As Integer, ByVal duracion As Integer, ByVal bloque As Integer, ByVal importe As Single, ByVal NombrePrograma As String, ByVal alternativa As String)
        Dim a As New Avisos_Nautilus

        a.Fec_Spt = fecha
        a.Cad_Spt = GetCadena(id_soporte)
        a.Hm_Spt = minuto
        a.Ss_Spt = 0
        a.Cod_Spt = Cod_SPS
        a.Dur_Spt = duracion
        'a.Pos_Spt = bloque
        a.Pos_Spt = 0
        a.Nsb_Spt = 1
        a.Tip_Spt = 1
        a.Pre_Spt = importe * duracion
        a.ZpNomb = Strings.Right(NombrePrograma.Length, 30) & " " & Strings.Right(alternativa, 24) & " " & Now.ToShortTimeString
        a.Vem_Spt = 1
        a.Tip_Cmp = 2
        a.HomoCre = 0
        a.Agregar()
    End Sub

    Private Function GetCadena(ByVal id_soporte) As String
        Dim s As New Soportes

        s.Id_soporte = id_soporte
        s.Id_medio = Activo.IDMedio
        s.BuscarPorID_Soporte()
        GetCadena = s.Id_cadena
    End Function

    Private Sub Procesar(ByVal Id_Sistema As Int32, ByVal Id_Ejercicio As Int32, ByVal Id_Soporte As Int32)
        Dim s As New Soportes

        s.Id_soporte = Id_Soporte
        s.Id_medio = Activo.IDMedio
        s.BuscarPorID_Soporte()
        UltimoFspot = CDate("01/01/1900")
        Select Case s.Id_tipo_soporte - 1
            Case TVA
                ProcesaTVA(Id_Sistema, Id_Ejercicio, Id_Soporte)
            Case TVC
                ProcesaTVC(Id_Sistema, Id_Ejercicio, Id_Soporte)
        End Select
    End Sub

    Private Sub ProcesaTVA(ByVal Id_Sistema As Int32, ByVal Id_Ejercicio As Int32, ByVal Id_Soporte As Int32)
        Dim sistema As New Sistemas

        Try
            sistema.Id_campania = mId_Campania
            sistema.Id_sistema = Id_Sistema
            sistema.BuscarPorID()
            ProcesaTVA(sistema.Tipo_rating, Id_Sistema, Id_Ejercicio, Id_Soporte, sistema.F_inicio, sistema.F_fin)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ProcesaTVA(ByVal tipo_rating As String, ByVal Id_Sistema As Int32, ByVal Id_Ejercicio As Int32, ByVal Id_Soporte As Int32, ByVal F_inicio_sistema As Date, ByVal F_fin_sistema As Date)
        Dim Spot As New Spots_detalle
        Dim Tandas As New Tandas_tva
        Dim Sistema As New Sistemas
        Dim dtSpots As DataTable
        Dim dtTandas As DataTable
        Dim Rows() As DataRow
        Dim HoraInicio As String
        Dim HoraFin As String
        Dim arProgramas(1) As String
        Dim arBloquesUsados() As Boolean
        Dim antId_tarifa As Int32
        Dim antFecha As Date
        Dim i As Integer
        Dim j As Integer
        Dim minuto As Integer
        Dim nBloque As Integer
        Dim Filtro As String

        Try
            dtSpots = Spot.ObtenerSpotPorSoporte(mId_Campania, Id_Sistema, Id_Ejercicio, Id_Soporte)
            If dtSpots Is Nothing Then
                Exit Sub
            End If
            Filtro = ArmarFiltroTemas(dtTemas)
            Rows = dtSpots.Select(Filtro, "Id_Tarifa_tv, f_Spot") ' traigo los spots del soporte actual
            antId_tarifa = -1
            i = 0
            While i < Rows.Length
                Application.DoEvents()
                ' inicializo las variables con la fecha teorica del programa
                HoraInicio = Trim(Rows(i).Item("h_inicio")).PadLeft(2, "0") & Trim(Rows(i).Item("m_inicio")).PadLeft(2, "0")
                HoraFin = Trim(Rows(i).Item("h_fin")).PadLeft(2, "0") & Trim(Rows(i).Item("m_fin")).PadLeft(2, "0")
                ' traigo el horario en el que se emitio el programa, si no existia deja la hora teorica
                getHorario(Rows(i).Item("id_soporte"), IIf(IsDBNull(Rows(i).Item("id_programa")), -1, Rows(i).Item("id_programa")), Rows(i).Item("f_spot"), F_inicio_sistema, F_fin_sistema, HoraInicio, HoraFin)
                'Tandas.F_programa = getDia(dtpFechaInicio.Value, CDate(Rows(i).Item("f_spot")).DayOfWeek, getNroSemana(F_inicio_sistema, Rows(i).Item("f_spot")))
                Tandas.Id_medio = 1
                Tandas.Id_soporte = Id_Soporte
                Tandas.Id_plaza = 1
                Tandas.F_programa = getDia(Rows(i).Item("f_spot"))
                Tandas.H_inicio = HoraInicio
                Tandas.H_fin = HoraFin
                Tandas.Id_target = Sistema.Id_target_1
                dtTandas = Tandas.TraerTandasPorHora()
                ReDim arProgramas(1)
                ' si no existe ninguna tanda en el rango del programa, 
                ' tomo una hora/minuto dentro del rango total del programa
                If (tipo_rating = "P") Or (dtTandas.Rows.Count = 0) Then
                    arProgramas(0) = HoraInicio
                    arProgramas(1) = HoraFin
                Else
                    arProgramas(0) = ""
                    arProgramas(1) = ""
                End If
                CargarHoras(dtTandas, arProgramas)
                ReDim arBloquesUsados((arProgramas.Length / 2) - 1)
                For j = 0 To (arProgramas.Length / 2) - 1
                    arBloquesUsados(j) = False
                Next
                antId_tarifa = Rows(i).Item("id_Tarifa_tv")
                antFecha = Rows(i).Item("f_spot")
                While i < Rows.Length AndAlso (antId_tarifa = Rows(i).Item("id_Tarifa_tv") And antFecha = Rows(i).Item("f_spot"))
                    nBloque = ElegirBloque(arProgramas, arBloquesUsados)
                    minuto = ElegirMinuto(arProgramas, nBloque)
                    GuardarAviso(getDia(Rows(i).Item("f_spot")), Id_Soporte, minuto, Rows(i).Item("duracion"), nBloque, Rows(i).Item("neto"), Rows(i).Item("programa"), Alter.Descripcion)
                    'Agregado Cristian para El MEGA EVALUADOR DEL AMIGO DE MICHAEL
                    Me.CargarPautas(i, Rows(i).Item("f_spot"), minuto, Id_Soporte, Rows(i).Item("id_tema"), Rows(i).Item("programa"))
                    '---------------------------------
                    If UltimoFspot < getDia(Rows(i).Item("f_spot")) Then
                        UltimoFspot = getDia(Rows(i).Item("f_spot"))
                    End If
                    CantSpotInsertados = CantSpotInsertados + 1
                    i = i + 1
                End While
            End While

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ElegirBloque(ByVal ar() As String, ByRef arUtilizados() As Boolean) As Integer
        ' Elijo un bloque aleatoriamente de los que no esten en uso, si estan todos utilizados, blanqueo el array y lo elijo
        Dim ok As Boolean
        Dim i As Integer
        Dim j As Integer

        Randomize()
        'Int((Límite_superior - límite_inferior + 1) * Rnd() + límite_inferior)
        i = Int((UBound(arUtilizados) - 0 + 1) * Rnd() + 0)  ' busco random una posicion libre en el array de utilizados
        While arUtilizados(i)
            i = Int((UBound(arUtilizados) - 0 + 1) * Rnd() + 0)
        End While
        arUtilizados(i) = True

        ' verifico que no este todo utilizado
        ok = True
        For j = 0 To UBound(arUtilizados)
            ok = ok And arUtilizados(i)
        Next

        If ok Then
            ' si esta todo utilizado, lo "cereo" para poder hacer una nueva busqueda.
            For j = 0 To UBound(arUtilizados)
                arUtilizados(i) = False
            Next
        End If

        ElegirBloque = i
    End Function

    Private Function ElegirMinuto(ByVal arPrg() As String, ByVal bloque As Integer) As Integer
        Dim minD As Integer
        Dim minH As Integer
        Dim ret As String

        minD = arPrg(bloque * 2)
        minH = arPrg((bloque * 2) + 1)

        Randomize()
        'Int((Límite_superior - límite_inferior + 1) * Rnd() + límite_inferior)
        ret = "3100"
        While ret.Substring(2, 2) >= 60 Or ret.Substring(0, 2) > 30 Or ret.Substring(0, 2) < 6
            ret = Int((minH - minD + 1) * Rnd() + minD).ToString.PadLeft(4, "0")
        End While

        ElegirMinuto = ret
    End Function

    Private Sub CargarHoras(ByVal dt As DataTable, ByRef Horas() As String)
        ' como viene con las horas de inicio y fin cargadas, solo resta agregarle las tandas al medio
        For Each row As DataRow In dt.Rows
            If UBound(Horas) = 1 And Horas(0) = "" Then ' si no tengo ninguna cargada.
                Horas(0) = row("h_inicio")
                Horas(1) = row("h_fin")
            Else
                ReDim Preserve Horas(Horas.Length + 1)
                Horas(Horas.Length - 2) = row("h_inicio")
                Horas(Horas.Length - 1) = row("h_fin")
            End If
        Next
        Array.Sort(Horas) 'lo ordeno para que me queden las horas de como comenzo cada bloque
    End Sub

    Private Sub getHorario(ByVal id_soporte As Int32, ByVal id_programa As Int32, ByVal f_programa As Date, ByVal f_inicio_sistema As Date, ByVal f_fin_sistema As Date, ByRef HI As String, ByRef HF As String)
        Dim dia As Date

        'dia = getDia(dtpFechaInicio.Value, f_programa.DayOfWeek, getNroSemana(f_inicio_sistema, f_programa))
        dia = getDia(f_programa)
        If id_programa >= 0 Then ' Si tengo el id_programa, puedo ir a buscar la hora real del programa.
            getHorarioReal(id_soporte, id_programa, dia, HI, HF)
        End If

    End Sub

    Private Sub getHorarioReal(ByVal id_soporte As Int32, ByVal id_programa As Int32, ByVal f_programa As Date, ByRef HI As String, ByRef HF As String)
        Dim a As New Audiencia_Tva

        a.Id_Medio = 1
        a.Id_Soporte = id_soporte
        a.Id_Programa = id_programa
        a.F_Programa = f_programa
        a.ObtenerHoraIniFinPrg()
        If a.H_Inicio <> "" And a.H_Fin <> "" Then
            HI = a.H_Inicio
            HF = a.H_Fin
        End If

    End Sub

    Private Sub ProcesaTVC(ByVal Id_Sistema As Int32, ByVal Id_Ejercicio As Int32, ByVal Id_Soporte As Int32)
        Dim Spot As New Spots_detalle
        Dim Tandas As New Tandas_tva
        Dim Sistema As New Sistemas
        Dim dtSpots As DataTable
        Dim dtTandas As DataTable
        Dim Rows() As DataRow
        Dim HoraInicio As String
        Dim HoraFin As String
        Dim arProgramas(1) As String
        Dim arBloquesUsados() As Boolean
        Dim antId_tarifa As Int32
        Dim antFecha As Date
        Dim i As Integer
        Dim j As Integer
        Dim minuto As Integer
        Dim nBloque As Integer
        Dim Filtro As String

        Try
            dtSpots = Spot.ObtenerSpotPorSoporte(mId_Campania, Id_Sistema, Id_Ejercicio, Id_Soporte)
            If dtSpots Is Nothing Then
                Exit Sub
            End If
            Filtro = ArmarFiltroTemas(dtTemas)
            Rows = dtSpots.Select(Filtro, "Id_Tarifa_tv, f_Spot") ' traigo los spots del soporte actual
            antId_tarifa = -1
            i = 0
            While i < Rows.Length
                Application.DoEvents()
                ' inicializo las variables con la fecha teorica del programa
                HoraInicio = Trim(Rows(i).Item("h_inicio")).PadLeft(2, "0") & Trim(Rows(i).Item("m_inicio")).PadLeft(2, "0")
                HoraFin = Trim(Rows(i).Item("h_fin")).PadLeft(2, "0") & Trim(Rows(i).Item("m_fin")).PadLeft(2, "0")
                ReDim arProgramas(1)
                arProgramas(0) = HoraInicio
                arProgramas(1) = HoraFin
                EmularFranjas(arProgramas, HoraInicio, HoraFin)
                ReDim arBloquesUsados((arProgramas.Length / 2) - 1)
                For j = 0 To (arProgramas.Length / 2) - 1
                    arBloquesUsados(j) = False
                Next
                antId_tarifa = Rows(i).Item("id_Tarifa_tv")
                antFecha = Rows(i).Item("f_spot")
                While i < Rows.Length AndAlso (antId_tarifa = Rows(i).Item("id_Tarifa_tv") And antFecha = Rows(i).Item("f_spot"))
                    nBloque = ElegirBloque(arProgramas, arBloquesUsados)
                    minuto = ElegirMinuto(arProgramas, nBloque)
                    GuardarAviso(getDia(Rows(i).Item("f_spot")), Id_Soporte, minuto, Rows(i).Item("duracion"), 1, Rows(i).Item("bruto"), Rows(i).Item("programa"), Alter.Descripcion)
                    'Agregado Cristian para El MEGA EVALUADOR DEL AMIGO DE MICHAEL
                    Me.CargarPautas(i, Rows(i).Item("f_spot"), minuto, Id_Soporte, Rows(i).Item("id_tema"), Rows(i).Item("programa"))
                    '-------------------------------------
                    If UltimoFspot < getDia(Rows(i).Item("f_spot")) Then
                        UltimoFspot = getDia(Rows(i).Item("f_spot"))
                    End If
                    CantSpotInsertados = CantSpotInsertados + 1
                    i = i + 1
                End While
            End While

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EmularFranjas(ByRef ar() As String, ByVal hi As String, ByVal hf As String)
        Dim i As Integer

        i = 2
        hi = Listas.SumarHoras(hi, "1500", "mmmmm").Substring(0, 4)
        While hi < hf And (hi <> "0600" Or hf <> "2959") ' en la suma de horas, si tengo 29:45 y le sumo 15, se va a 6 horas, entonces tengo que controlarlo.
            ReDim Preserve ar(UBound(ar) + 2)
            ar(i) = hi
            ar(i + 1) = hi
            hi = Listas.SumarHoras(hi, "1500", "mmmmm").Substring(0, 4)
            i = i + 2
        End While
        Array.Sort(ar)

    End Sub

    Private Sub ProcesaInterior()
        Dim NomArc As String
        Dim Arc As StreamWriter
        Try

            Arc = File.CreateText(lblArchivo.Text)
            For Each row As DataRow In dtSopAlternativas.Rows
                ProcesaTVI(Arc, row("id_sistema"), row("id_ejercicio"), row("id_soporte"))
            Next
            Arc.Close()

        Catch ex As Exception
            If Not Arc Is Nothing Then
                Arc.Close()
                File.Delete(NomArc)
            End If
            Throw ex
        End Try
    End Sub

    Private Sub ProcesaInteriorNuevo()
        Dim NomArc As String
        Try
            For Each row As DataRow In dtSopAlternativas.Rows
                Select Case TipoMedicion
                    Case Medicion.PeopleMeter
                        Me.ProcesaTVIPm(row("id_sistema"), row("id_ejercicio"), row("id_soporte"))
                    Case Medicion.Cuadernillo
                        Me.ProcesaTVICua(row("id_sistema"), row("id_ejercicio"), row("id_soporte"))
                End Select
            Next
        Catch ex As Exception
            MsgBox("ProcesaInteriorNuevo " & ex.Message)
        End Try
    End Sub

    Private Sub ProcesaTVI(ByRef arc As StreamWriter, ByVal id_sistema As Integer, ByVal id_ejercicio As Integer, ByVal id_soporte As Integer)
        Dim sist As New Sistemas
        Dim Spot As New Spots_detalle
        Dim dtSpots As DataTable
        Dim Rows() As DataRow
        Dim i As Integer
        Dim Filtro As String
        Dim s As New Soportes_Interior

        Dim NombrePrograma As String
        Dim Canal As String
        Dim DiaSemana As String
        Dim Hora As String
        Dim Cuarto As String
        Dim TarifaNeta As String
        Dim CantAvisos As String
        Dim sep As String = ";"
        Dim HoraTemp As String
        Dim arSemanas(23) As Integer
        Dim linea As String
        Dim j As Integer
        Dim fIni As Date

        Try
            dtSpots = Spot.ObtenerSpotPorSoporte(mId_Campania, id_sistema, id_ejercicio, id_soporte)
            If dtSpots Is Nothing Then
                Exit Sub
            End If

            s.Id_Soporte = id_soporte
            s.BuscarPorID_Soporte()
            Canal = s.TraerCodTom.Trim

            Filtro = ArmarFiltroTemas(dtTemas)
            Rows = dtSpots.Select(Filtro, "Id_Tarifa_tv, f_Spot") ' traigo los spots del soporte actual
            i = 0
            While i < Rows.Length
                Application.DoEvents()

                If Rows(i).Item("f_spot") >= dtpMenorFecha.Value Then
                    NombrePrograma = lblAlternativa.Text
                    DiaSemana = GetDiaSemana(Rows(i).Item("f_spot"))
                    HoraTemp = SeleccionarCuarto(Rows(i).Item("h_inicio"), Rows(i).Item("m_inicio"), Rows(i).Item("h_fin"), Rows(i).Item("m_fin"))
                    Hora = HoraTemp.Substring(0, 2)
                    Cuarto = HoraTemp.Substring(2, 2)
                    TarifaNeta = Math.Round(Rows(i).Item("neto"))
                    UbicarSemana(arSemanas, dtpMenorFecha.Value, Rows(i).Item("f_spot"))
                    CantAvisos = 1
                    If Canal <> "" Then

                        linea = NombrePrograma & sep & Canal.PadRight(6, " ") & DiaSemana & Hora & "." & Cuarto _
                        & sep & "100" & sep & "      " & sep & TarifaNeta & sep & "0,00"
                        For j = 0 To arSemanas.Length - 1
                            linea = linea & sep & arSemanas(j)
                        Next
                        arc.WriteLine(linea)
                        CantSpotInsertados = CantSpotInsertados + 1
                    End If
                End If
                i = i + 1
            End While
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function UbicarSemana(ByRef ar() As Integer, ByVal fini As Date, ByVal fspot As Date)
        Dim temp As Integer
        Dim i As Integer

        temp = DateDiff(DateInterval.Day, fini, fspot)
        For i = 0 To ar.Length - 1
            ar(i) = 0
        Next

        ar(Int(temp / 7)) = 1

    End Function

    Private Function GetDiaSemana(ByVal f As Date) As String
        Dim Semana() As String = {"D", "L", "M", "X", "J", "V", "S"}

        GetDiaSemana = Semana(f.DayOfWeek)
    End Function

    Private Function SeleccionarCuarto(ByVal h_inicio As Integer, ByVal m_inicio As Integer, ByVal h_fin As Integer, ByVal m_fin As Integer) As String
        Dim HoraDesde As Date
        Dim HoraHasta As Date
        Dim ret As Integer

        If h_inicio >= 24 Then
            h_inicio = h_inicio - 24
        End If

        If h_fin >= 24 Then
            h_fin = h_fin - 24
        End If

        HoraDesde = Trim(Str(h_inicio)).PadLeft(2, "0") & ":" & Trim(Str(m_inicio)).PadLeft(2, "0")
        HoraHasta = Trim(Str(h_fin)).PadLeft(2, "0") & ":" & Trim(Str(m_fin)).PadLeft(2, "0")

        ret = DateDiff(DateInterval.Minute, HoraDesde, HoraHasta)

        ret = Int(ret / 15) ' saco los cuartos

        Randomize()
        ' Elijo el cuarto random
        ret = Int((ret - 1 + 1) * Rnd() + 1) * 15

        HoraDesde = DateAdd(DateInterval.Minute, ret, HoraDesde)

        If HoraDesde.Hour < 6 Then
            SeleccionarCuarto = Trim(Str(HoraDesde.Hour + 24)).PadLeft(2, "0") & Trim(Str(HoraDesde.Minute)).PadLeft(2, "0")
        Else
            SeleccionarCuarto = Trim(Str(HoraDesde.Hour)).PadLeft(2, "0") & Trim(Str(HoraDesde.Minute)).PadLeft(2, "0")
        End If


    End Function

    Private Function FechasOk() As Boolean
        Dim ret As Boolean = True
        Dim Fecha_Inicio As Date
        Dim arDias(6) As String

        arDias(0) = "Domingo"
        arDias(1) = "Lunes"
        arDias(2) = "Martes"
        arDias(3) = "Miercoles"
        arDias(4) = "Jueves"
        arDias(5) = "Viernes"
        arDias(6) = "Sabado"

        If ret And DateDiff(DateInterval.DayOfYear, dtpFechaInicio.Value, Now) < 0 Then
            Mensajes.Mensaje("Debe seleccionar una fecha en el pasado", TipoMensaje.Informacion)
            ret = False
        End If
        Fecha_Inicio = dtpMenorFecha.Value
        If ret And Fecha_Inicio.DayOfWeek <> CDate(dtpFechaInicio.Value).DayOfWeek Then
            Mensajes.Mensaje("La fecha de inicio debe comenzar un " & arDias(Fecha_Inicio.DayOfWeek), TipoMensaje.Informacion)
            ret = False
        End If

        FechasOk = ret
    End Function

    Public Function ValidarSeleccionSoportes() As Boolean
        ' este proceso se corre antes de llamar al show del formulario. Como ya tiene los calculos
        ' aprovecho y guardo los datos.

        Dim s As New Soportes


        For Each row As DataRow In dtSopAlternativas.Rows
            s.Id_soporte = row("id_soporte")
            s.Id_medio = 1
            auxSoporte = row("id_soporte")
            ''Jsperk - Remplazar por lo traido en el inicio de la session.
            s.BuscarPorID_Soporte()
            Tipo_soportes(s.Id_tipo_soporte - 1) = True
        Next

        mTipo_Evaluacion = 0
        If (Tipo_soportes(TVA) And Not Tipo_soportes(TVC) And Not Tipo_soportes(TVI)) Then
            mTipo_Evaluacion = 1 ' abierta
            TipoMedicion = Medicion.PeopleMeter
        End If
        If (Not Tipo_soportes(TVA) And Tipo_soportes(TVC) And Not Tipo_soportes(TVI)) Then
            mTipo_Evaluacion = 2 ' cable
            TipoMedicion = Medicion.PeopleMeter
        End If
        If (Not Tipo_soportes(TVA) And Not Tipo_soportes(TVC) And Tipo_soportes(TVI)) Then
            mTipo_Evaluacion = 3 ' interior
            Select Case EsPeopleMeter(auxSoporte)
                Case TresEstados.Verdadero
                    TipoMedicion = Medicion.PeopleMeter
                Case TresEstados.Falso
                    TipoMedicion = Medicion.Cuadernillo
                Case Else
                    TipoMedicion = Medicion.Ninguna
            End Select
        End If
        If (Tipo_soportes(TVA) And Tipo_soportes(TVC) And Not Tipo_soportes(TVI)) Then
            mTipo_Evaluacion = 4 ' cable y abierta
            TipoMedicion = Medicion.PeopleMeter
        End If

        If mTipo_Evaluacion = 0 Then
            Mensajes.Mensaje("No se puede evaluar TVA o TVC al mismo tiempo que con TVI", TipoMensaje.Informacion)
            ValidarSeleccionSoportes = False
        Else
            ValidarSeleccionSoportes = True
        End If
    End Function

    Private Sub frmEvaluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ardias() As String = {"domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"}
        Dim CantDifDias As Integer
        Dim Aud_Fec As New Audiencias_fechas
        Dim P As New Pautas_mp
        Dim MaxFecha As Date

        Dim s As New Soportes
        Try
            Reportes.Add("frecuencia")
            Reportes.Add("pbr")

            Alter.Id_campania = mId_Campania
            Alter.Id_alternativa = mId_Alternativa
            Alter.BuscarPorID()
            Me.dtSoportesIbope = Alter.ObtenerSoportesIbope

            lblAlternativa.Text = Alter.Descripcion

            dtpMenorFecha.Value = Alter.ObtenerMinFIniSist()

            MayorFecha = Alter.ObtenerMaxFFinSist

            dtSopAlternativas = Alter.ObtenerSoportesGuardados

            s.Id_soporte = dtSopAlternativas.Rows(0).Item("id_soporte")
            s.Id_medio = dtSopAlternativas.Rows(0).Item("id_medio")
            s.BuscarPorID_Soporte()

            Dim r As DataRow, NuevaFecha As Date, dias As Integer
            r = dtSoportesIbope.Select("id_soporte=" & s.Id_soporte)(0)
            'r = dtSoportesIbope.Select("id_soporte=" & dtSopAlternativas.Rows(0).Item("id_soporte"))(0)

            idArchivo = r("id_archivo")
            IdPlaza = r("plaza")
            P.Plaza = IdPlaza

            dias = DateDiff(DateInterval.Day, dtpMenorFecha.Value, MayorFecha)            
            NuevaFecha = Me.ObtenerUltimaFecha(P.ObtenerUltimaFechaAudiencia, dias, CDate(dtpMenorFecha.Value).DayOfWeek)

            ValidarSeleccionSoportes() ' Lo invoco solo para llenar el array Tipo_soportes
            If TipoMedicion = Medicion.Ninguna Then
                Mensajes.Mensaje("La Plaza Seleccionada No puede ser Evaluada")
                Me.Close()
                Exit Sub
            End If
            TipoMedicion = Medicion.Cuadernillo
            If Tipo_soportes(TVI) Then

                fraTomm.Visible = False
                fraFechas.Visible = True
                Aud_Fec.Id_medio = s.Id_medio
                Aud_Fec.Id_tipo_soporte = s.Id_tipo_soporte
                dtpFechaInicio.Value = NuevaFecha 'DateAdd(DateInterval.Day, -1 * CantDifDias, Aud_Fec.Consulta_Ultima_Fecha())
                ConEvaluador = True
                If Me.EsPeopleMeter(s.Id_soporte) = TresEstados.Verdadero Then
                    TipoMedicion = Medicion.PeopleMeter
                End If
                'End If

            ElseIf Tipo_soportes(TVA) And Tipo_soportes(TVC) Then
                fraTomm.Visible = False
                fraFechas.Visible = True
                Aud_Fec.Id_medio = s.Id_medio
                Aud_Fec.Id_tipo_soporte = s.Id_tipo_soporte
                'dtpFechaInicio.Value = Aud_Fec.Consulta_Ultima_Fecha()
                dtpFechaInicio.Value = NuevaFecha
                TipoMedicion = Medicion.PeopleMeter

            ElseIf Tipo_soportes(TVA) And Not Tipo_soportes(TVC) Then
                fraTomm.Visible = False
                fraFechas.Visible = True
                Aud_Fec.Id_medio = s.Id_medio
                Aud_Fec.Id_tipo_soporte = s.Id_tipo_soporte
                'dtpFechaInicio.Value = Aud_Fec.Consulta_Ultima_Fecha()
                dtpFechaInicio.Value = NuevaFecha
                TipoMedicion = Medicion.PeopleMeter

            ElseIf Not Tipo_soportes(TVA) And Tipo_soportes(TVC) Then
                fraTomm.Visible = False
                fraFechas.Visible = True
                Aud_Fec.Id_medio = s.Id_medio
                Aud_Fec.Id_tipo_soporte = s.Id_tipo_soporte
                dtpFechaInicio.Value = NuevaFecha 'DateAdd(DateInterval.Day, -1 * CantDifDias, Aud_Fec.Consulta_Ultima_Fecha())
                TipoMedicion = Medicion.PeopleMeter
            End If

            CantDifDias = DateDiff(DateInterval.Day, dtpMenorFecha.Value, MayorFecha)
            If Me.TipoMedicion = Medicion.Cuadernillo Then
                Dim au As New Audiencias_fechas

                au.Id_plaza = s.Id_plaza
                au.Id_medio = s.Id_medio
                au.Id_tipo_soporte = s.Id_tipo_soporte

                Me.dtpFechaInicio.Value = au.Consulta_Ultima_Fecha_Plaza
                lblAnuncio.Text = "La alternativa contiene " & CantDifDias & " días. Serán simulados en una semana"
            Else
                lblAnuncio.Text = "La alternativa contiene " & CantDifDias & " días comenzando un " & ardias(CDate(dtpMenorFecha.Value).DayOfWeek)
            End If



            Dim t As New Targets
            Dim DtTarget As DataTable = t.TraetTargetsIbope(s.Id_tipo_soporte)
            Listas.CargarCombo(Me.cboTarget1, DtTarget, "ID_TARGET_MOTORP", "DESCRIPCION", False)
            Me.cboTarget1.SelectedIndex = 0


            Dim item As New ItemLista
            Dim id_target As Integer = Alter.ObtenerTarget

            item.ID = DtTarget.Select("id_target=" & id_target)(0)("ID_TARGET_MOTORP")
            item.Descripcion = DtTarget.Select("id_target=" & id_target)(0)("DESCRIPCION")

            cboTarget1.SelectedIndex = cboTarget1.FindStringExact(item.Descripcion)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function getNroSemana(ByVal FD As Date, ByVal fecha As Date) As Integer
        ' devuelve el nro de semana dentro del rango de evaluacion
        getNroSemana = DateDiff(DateInterval.Day, FD, fecha) Mod 7
    End Function
    Private Function getDia(ByVal fSpot As Date) As Date
        Dim dia As Date
        ' calcula el dia por diferencia contra el dia de inicio mas chioo de todos los sistemas que mando a evaluar
        'dia = CDate(dtpFechaInicio.Value).AddDays(DateDiff(DateInterval.Day, dtpFechaInicio.Value, fSpot, FirstDayOfWeek.Monday))
        'While dia.DayOfWeek <> fSpot.DayOfWeek ' no va a pasar pero por las dudas si hay algun defasaje, esto lo corregiria
        '    dia = dia.AddDays(1)
        'End While
        'getDia = dia


        ' calcula el dia por diferencia contra el dia de inicio mas chioo de todos los sistemas que mando a evaluar
        dia = CDate(dtpFechaInicio.Value).AddDays(DateDiff(DateInterval.Day, dtpMenorFecha.Value, fSpot, FirstDayOfWeek.Monday))
        While dia.DayOfWeek <> fSpot.DayOfWeek ' no va a pasar pero por las dudas si hay algun defasaje, esto lo corregiria
            dia = dia.AddDays(1)
        End While
        getDia = dia

    End Function

    Private Function getDia(ByVal FD As Date, ByVal diadelasemana As Integer, ByVal nrosemana As Integer) As Date
        ' calcula el dia teniendo en cuenta la posicion relativa del spot con respecto al incio del sistema.
        Dim i As Integer
        Dim j As Integer
        Dim dias As Date

        i = 0
        j = 0
        dias = FD
        While i <= nrosemana
            While diadelasemana <> Int(dias.DayOfWeek)
                dias = dias.AddDays(1)
            End While
            i = i + 1
        End While

        getDia = FD.AddDays(j + nrosemana * 7)
    End Function

    Private Function ArmarFiltroTemas(ByVal dt As DataTable) As String
        Dim ret As String
        Dim i As Integer

        If dt.Rows.Count >= 1 Then
            ret = "id_tema = '" & dt.Rows(0).Item("id_tema") & "'"
        End If

        For i = 1 To dt.Rows.Count - 1
            ret = ret & " or id_tema = '" & dt.Rows(i).Item("id_tema") & "'"
        Next

        ArmarFiltroTemas = ret
    End Function

    Private Sub cmdAbrirDlg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbrirDlg.Click
        ' Busco el archivo de audiencia
        Dim OpenDLG As New SaveFileDialog

        Try
            OpenDLG.Title = "Crear el archivo"
            OpenDLG.InitialDirectory = GetSetting(Application.ProductName, "Parametros", "DirTomM", "c:\")
            OpenDLG.Filter = "Archivo de Texto (*.txt)|*.txt"
            OpenDLG.FilterIndex = 2
            OpenDLG.RestoreDirectory = True

            If OpenDLG.ShowDialog() = DialogResult.OK Then
                lblArchivo.Text = OpenDLG.FileName
                SaveSetting(Application.ProductName, "Parametros", "DirTomM", Path.GetDirectoryName(OpenDLG.FileName))
            Else
                lblArchivo.Text = ""
            End If
        Catch ex As Exception

        End Try

    End Sub

#Region "NUEVO EVALUADOR"
    Private Function ObtenerUltimaFecha(ByVal UltimaFecha As Date, ByVal cantDias As Integer, ByVal Dia As DayOfWeek) As Date
        Dim fec As Date = UltimaFecha.AddDays(cantDias * -1)

        While Not fec.DayOfWeek.Equals(Dia)
            fec = fec.AddDays(-1)
        End While

        Return fec
    End Function


    Private Sub ProcesaTVIPm(ByVal Id_Sistema As Int32, ByVal Id_Ejercicio As Int32, ByVal Id_Soporte As Int32)

        Dim Spot As New Spots_detalle
        Dim Tandas As New Tandas_tva
        Dim Sistema As New Sistemas
        Dim dtSpots As DataTable
        Dim dtTandas As DataTable
        Dim Rows() As DataRow
        Dim HoraInicio As String
        Dim HoraFin As String
        Dim arProgramas(1) As String
        Dim arBloquesUsados() As Boolean
        Dim antId_tarifa As Int32
        Dim antFecha As Date
        Dim i As Integer
        Dim j As Integer
        Dim minuto As Integer
        Dim nBloque As Integer
        Dim Filtro As String

        Try
            dtSpots = Spot.ObtenerSpotPorSoporte(mId_Campania, Id_Sistema, Id_Ejercicio, Id_Soporte)
            If dtSpots Is Nothing Then
                Exit Sub
            End If
            Filtro = ArmarFiltroTemas(dtTemas)
            Rows = dtSpots.Select(Filtro, "Id_Tarifa_tv, f_Spot") ' traigo los spots del soporte actual
            antId_tarifa = -1
            i = 0
            While i < Rows.Length
                Application.DoEvents()
                ' inicializo las variables con la fecha teorica del programa
                HoraInicio = Trim(Rows(i).Item("h_inicio")).PadLeft(2, "0") & Trim(Rows(i).Item("m_inicio")).PadLeft(2, "0")
                HoraFin = Trim(Rows(i).Item("h_fin")).PadLeft(2, "0") & Trim(Rows(i).Item("m_fin")).PadLeft(2, "0")
                ReDim arProgramas(1)
                arProgramas(0) = HoraInicio
                arProgramas(1) = HoraFin
                EmularFranjas(arProgramas, HoraInicio, HoraFin)
                ReDim arBloquesUsados((arProgramas.Length / 2) - 1)
                For j = 0 To (arProgramas.Length / 2) - 1
                    arBloquesUsados(j) = False
                Next
                antId_tarifa = Rows(i).Item("id_Tarifa_tv")
                antFecha = Rows(i).Item("f_spot")
                While i < Rows.Length AndAlso (antId_tarifa = Rows(i).Item("id_Tarifa_tv") And antFecha = Rows(i).Item("f_spot"))
                    nBloque = ElegirBloque(arProgramas, arBloquesUsados)
                    minuto = ElegirMinuto(arProgramas, nBloque)
                    GuardarAviso(getDia(Rows(i).Item("f_spot")), Id_Soporte, minuto, Rows(i).Item("duracion"), 1, Rows(i).Item("bruto"), Rows(i).Item("programa"), Alter.Descripcion)
                    'Agregado Cristian para El MEGA EVALUADOR DEL AMIGO DE MICHAEL
                    Me.CargarPautas(i, Rows(i).Item("f_spot"), minuto, Id_Soporte, Rows(i).Item("id_tema"), Rows(i).Item("programa"))
                    '-------------------------------------
                    If UltimoFspot < getDia(Rows(i).Item("f_spot")) Then
                        UltimoFspot = getDia(Rows(i).Item("f_spot"))
                    End If
                    CantSpotInsertados = CantSpotInsertados + 1
                    i = i + 1
                End While
            End While

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub ProcesaTVICua(ByVal Id_Sistema As Int32, ByVal Id_Ejercicio As Int32, ByVal Id_Soporte As Int32)

        Dim Spot As New Spots_detalle
        Dim Tandas As New Tandas_tva
        Dim Sistema As New Sistemas
        Dim dtSpots As DataTable
        Dim dtTandas As DataTable
        Dim Rows() As DataRow
        Dim HoraInicio As String
        Dim HoraFin As String
        Dim arProgramas(1) As String
        Dim arBloquesUsados() As Boolean
        Dim antId_tarifa As Int32
        Dim antFecha As Date
        Dim i As Integer
        Dim j As Integer
        Dim minuto As Integer
        Dim nBloque As Integer
        Dim Filtro As String

        Try
            dtSpots = Spot.ObtenerSpotPorSoporte(mId_Campania, Id_Sistema, Id_Ejercicio, Id_Soporte)
            If dtSpots Is Nothing Then
                Exit Sub
            End If
            Me.CargarFechas(Me.dtpFechaInicio.Value)
            Filtro = ArmarFiltroTemas(dtTemas)
            Rows = dtSpots.Select(Filtro, "Id_Tarifa_tv, f_Spot") ' traigo los spots del soporte actual
            antId_tarifa = -1
            i = 0
            While i < Rows.Length
                Application.DoEvents()
                ' inicializo las variables con la fecha teorica del programa
                HoraInicio = Trim(Rows(i).Item("h_inicio")).PadLeft(2, "0") & Trim(Rows(i).Item("m_inicio")).PadLeft(2, "0")
                HoraFin = Trim(Rows(i).Item("h_fin")).PadLeft(2, "0") & Trim(Rows(i).Item("m_fin")).PadLeft(2, "0")
                ReDim arProgramas(1)
                arProgramas(0) = HoraInicio
                arProgramas(1) = HoraFin
                EmularFranjas(arProgramas, HoraInicio, HoraFin)
                ReDim arBloquesUsados((arProgramas.Length / 2) - 1)
                For j = 0 To (arProgramas.Length / 2) - 1
                    arBloquesUsados(j) = False
                Next
                antId_tarifa = Rows(i).Item("id_Tarifa_tv")
                antFecha = Rows(i).Item("f_spot")
                While i < Rows.Length AndAlso (antId_tarifa = Rows(i).Item("id_Tarifa_tv") And antFecha = Rows(i).Item("f_spot"))
                    nBloque = ElegirBloque(arProgramas, arBloquesUsados)
                    minuto = ElegirMinuto(arProgramas, nBloque)
                    GuardarAviso(getDia(Rows(i).Item("f_spot")), Id_Soporte, minuto, Rows(i).Item("duracion"), 1, Rows(i).Item("bruto"), Rows(i).Item("programa"), Alter.Descripcion)
                    'Agregado Cristian para El MEGA EVALUADOR DEL AMIGO DE MICHAEL
                    Dim nuevafecha As Date = Me.HubicarFechaSemana(Rows(i).Item("f_spot"))
                    Me.CargarPautas(i, nuevafecha, minuto, Id_Soporte, Rows(i).Item("id_tema"), Rows(i).Item("programa"))
                    '-------------------------------------
                    If UltimoFspot < getDia(Rows(i).Item("f_spot")) Then
                        UltimoFspot = getDia(Rows(i).Item("f_spot"))
                    End If
                    CantSpotInsertados = CantSpotInsertados + 1
                    i = i + 1
                End While
            End While

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Function EsPeopleMeter(ByVal Soporte As Integer) As TresEstados
        Try
            Dim r As DataRow = dtSoportesIbope.Select("id_soporte = " & Soporte)(0)

            If r("medicion") = "P" Then
                Return TresEstados.Verdadero
            Else
                Return TresEstados.Falso
            End If

        Catch ex As Exception
            Return TresEstados.Igual
        End Try

    End Function
    Private Sub CargarPautas(ByVal Aviso As Long, ByVal Fecha As Date, ByVal Hora As String, ByVal Canal As Integer, ByVal Tema As String, ByVal Programa As String)
        'INSERTA EM EL SINONIMO DE LA TABLA PAUTAS MP PARA EL NUEVO EVALUADOR
        'PARA ABIERTE, CABLE, e INTERIOR CON PEOPLEMETER
        Dim P As New Pautas_mp
        Dim Plaza As Integer

        Try
            Dim idSoprote_Ibope As DataRow = dtSoportesIbope.Select("id_soporte = " & Canal)(0)
            If Programa.Length > 19 Then ' La tabla tiene un maxlen de 20
                Programa = Mid(Programa, 1, 19)
            End If
            P.Id = IDnuevo
            If Me.TipoMedicion = Medicion.Cuadernillo Then
                P.Fecha = Fecha
            Else
                P.Fecha = getDia(Fecha)
            End If

            P.Hora = Hora
            P.Canal = idSoprote_Ibope("id_ibope")
            P.Programa = Programa
            P.tema = Tema
            P.Plaza = idSoprote_Ibope("plaza")

            P.Agregar()
        Catch e As Exception
            MsgBox(e.Message)
        End Try

    End Sub
    Private Sub CargarFechas(ByVal Fecha As Date)
        'Carga un Array list con las fechas correspondientes a una semana a partir de una fecha
        Dim Fec As FechaDia
        Dim auxFec As Date = Fecha
        Dim auxFec2 As Date = Fecha

        Do
            Fec = New FechaDia
            Fec.Fecha = auxFec
            Fec.Dia = auxFec.DayOfWeek
            If Not BuscarDia(Fec.Dia) Then
                Fechas.Add(Fec)
            End If
            auxFec = auxFec.AddDays(1)
        Loop While auxFec.DayOfWeek <> DayOfWeek.Monday

        Do
            Fec = New FechaDia
            Fec.Fecha = auxFec2
            Fec.Dia = auxFec2.DayOfWeek
            If Not BuscarDia(Fec.Dia) Then
                Fechas.Add(Fec)
            End If
            auxFec2 = auxFec2.AddDays(-1)
        Loop While auxFec2.DayOfWeek <> DayOfWeek.Sunday And Fechas.Count < 7

    End Sub
    Private Function BuscarDia(ByVal dia As DayOfWeek) As Boolean
        For Each f As FechaDia In Fechas
            If f.Dia = dia Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function HubicarFechaSemana(ByVal f_spot As Date) As Date
        Dim dia As System.DayOfWeek = f_spot.DayOfWeek

        Dim Dspot As New FechaDia
        Dspot.Dia = dia
        Dim NuevaFecha As Date

        For Each f As FechaDia In Fechas
            If f.Dia = Dspot.Dia Then
                NuevaFecha = f.Fecha
                Exit For
            End If
        Next
        Return NuevaFecha
    End Function

    Private Function EvaluarMotorP() As Boolean
        Dim Motor As New MotorP
        Dim dtReportes As New ArrayList
        Dim Reporte As DataTable
        Cursor.Current = Cursors.WaitCursor
        Me.lblEstado.Text = "Evaluando..."
        pgbProgreso.Maximum = 40
        pgbProgreso.Value = 1
        Try
            With Motor
                .Progreso = pgbProgreso
                .Target = DirectCast(cboTarget1.SelectedItem, ItemLista).ID
                .Plaza = IdPlaza
                .Sistema = idArchivo

                .Pauta = IDnuevo

                .FrecuenciaMaxima = Me.npdFrec.Value '+ 1
                .Conectar()

                If .MensajeError <> "" Then
                    Throw New Exception(.MensajeError)
                    Return False
                End If

                Dim Dt As DataTable
                For Each r As String In Reportes
                    ' pgbProgreso.Increment(.Estado)
                    Select Case r
                        Case "frecuencia"
                            Dt = .ObtenerFecuencias
                            Dt.TableName = "frecuencia"
                            dtReportes.Add(Dt)
                        Case "pbr"
                            Dt = .ObtenerPBRxAvisos
                            Dt.TableName = "pbr"
                            dtReportes.Add(Dt)
                        Case "canal"
                            Dt = .ObtenerAperturaCadena
                            Dt.TableName = "canal"
                            dtReportes.Add(Dt)
                            Totales.Add(.TotalSoporte)
                        Case "tema"
                            Dt = .ObtenerAperturaTemas
                            Dt.TableName = "tema"
                            dtReportes.Add(Dt)
                            Totales.Add(.TotalTema)
                        Case "pauta"
                            Dt = .ObtenerAperturaSemanaP
                            Dt.TableName = "pauta"
                            dtReportes.Add(Dt)
                            Totales.Add(.Totalsemanap)
                        Case "calendario"
                            Dt = .ObtenerAperturaSemanaC
                            Dt.TableName = "calendario"
                            dtReportes.Add(Dt)
                            Totales.Add(.Totalsemanac)
                    End Select

                Next
            End With


            Dim f As New frmFormulaOne
            f.CargarReporteMotorP(ReporteMotorP.General, dtReportes, IDnuevo, cboTarget1.Text, Motor.TasaRepeticion, Motor.NoContactados, Motor.TotalGrps, Motor.CoberturaNeta, Motor.Avisos, Motor.FrecuenciaMaxima, Me.dtSoportesIbope, lblAlternativa.Text, Totales)
            Motor.Desconectar()

            Return True

        Catch ex As Exception
            Motor.Desconectar()
            MsgBox(ex.Message)
            Cursor.Current = Cursors.Default
            Return False
        End Try
        'Cursor.Current = Cursors.Default

    End Function
#End Region

    Private Enum Medicion
        PeopleMeter = 1
        Cuadernillo = 2
        Ninguna = 3
    End Enum

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Motor As New MotorP
        Dim dt As DataTable
        Dim arr As New ArrayList
        With Motor
            .Sistema = "MEQ"
            .Plaza = 110
            .Target = 1
            .Pauta = 1003
            .FrecuenciaMaxima = 10

            .Conectar()
            If Not .MensajeError = "" Then
                MsgBox(.MensajeError)
                Exit Sub
            End If
            dt = .ObtenerPBRxAvisos
            arr.Add(dt)
            dt = .ObtenerFecuencias
            arr.Add(dt)
            dt = .ObtenerAperturaTemas
            arr.Add(dt)
            dt = .ObtenerAperturaCadena
            arr.Add(dt)
            dt = .ObtenerAperturaSemanaC
            arr.Add(dt)
            dt = .ObtenerAperturaSemanaP
            arr.Add(dt)
            Dim f As New frmFormulaOne

            f.CargarReporteMotorP(ReporteMotorP.General, arr, 1182, "20 a 30 BC", .TasaRepeticion, .NoContactados, .TotalGrps, .CoberturaNeta, .Avisos, .FrecuenciaMaxima, Me.dtSoportesIbope, lblAlternativa.Text)

            .Desconectar()

        End With
    End Sub

    Private Sub fraFechas_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraFechas.Enter

    End Sub

    Private Sub chkSemana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSemana.CheckedChanged
        Me.rdbCaldendario.Enabled = Me.chkSemana.Checked
        Me.rdbSietedias.Enabled = Me.chkSemana.Checked
        If Not chkSemana.Checked Then
            SacarReporte("pauta")
            SacarReporte("calendario")
            Me.rdbSietedias.Checked = False
            Me.rdbCaldendario.Checked = False

        End If

        ' cargar()
    End Sub

    Private Sub chkCanal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCanal.CheckedChanged
        If chkCanal.Checked Then
            AgregarReporte("canal")
        Else
            SacarReporte("canal")
        End If
        ' cargar()
    End Sub

    Private Sub AgregarReporte(ByVal Reporte As String)
        If Not Reportes.Contains(Reporte) Then
            Reportes.Add(Reporte)
        End If
        ' cargar()
    End Sub

    Private Sub SacarReporte(ByVal Reporte As String)
        If Reportes.Contains(Reporte) Then
            Reportes.Remove(Reporte)
        End If
        ' cargar()
    End Sub

    Private Sub chkTema_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTema.CheckedChanged
        If chkTema.Checked Then
            AgregarReporte("tema")
        Else
            SacarReporte("tema")
        End If
        ' cargar()
    End Sub

    Private Sub rdbCaldendario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCaldendario.CheckedChanged
        If Not chkSemana.Checked Then
            Exit Sub
        End If
        If rdbCaldendario.Checked Then
            AgregarReporte("calendario")
        Else
            SacarReporte("calendario")
        End If
        '   cargar()
    End Sub

    Private Sub rdbSietedias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSietedias.CheckedChanged
        If Not chkSemana.Checked Then
            Exit Sub
        End If
        If rdbSietedias.Checked Then
            AgregarReporte("pauta")
        Else
            SacarReporte("pauta")
        End If
        '  cargar()
    End Sub

    Private Sub cargar()
        ListBox1.Items.Clear()
        For Each s As String In Reportes
            ListBox1.Items.Add(s)
        Next
    End Sub

    Private Sub Button1_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.DragLeave

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Motor As New MotorP
        Dim dtReportes As New ArrayList
        Dim Reporte As DataTable
        Cursor.Current = Cursors.WaitCursor
        Try
            With Motor
                .Target = 11 ' DirectCast(cboTarget1.SelectedItem, ItemLista).ID
                .Plaza = 110 'IdPlaza
                .Sistema = "MEQ" ' idArchivo
                IDnuevo = 1405
                .Pauta = 1405 ' IDnuevo

                .FrecuenciaMaxima = Me.npdFrec.Value '+ 1
                .Conectar()

                If .MensajeError <> "" Then
                    Throw New Exception(.MensajeError)
                    'Return False
                End If

                Dim Dt As DataTable
                For Each r As String In Reportes
                    Select Case r
                        Case "frecuencia"
                            Dt = .ObtenerFecuencias
                            Dt.TableName = "frecuencia"
                            dtReportes.Add(Dt)
                        Case "pbr"
                            Dt = .ObtenerPBRxAvisos
                            Dt.TableName = "pbr"
                            dtReportes.Add(Dt)
                        Case "canal"
                            Dt = .ObtenerAperturaCadena
                            Dt.TableName = "canal"
                            dtReportes.Add(Dt)
                            Totales.Add(.TotalSoporte)
                        Case "tema"
                            Dt = .ObtenerAperturaTemas
                            Dt.TableName = "tema"
                            dtReportes.Add(Dt)
                            Totales.Add(.TotalTema)
                        Case "pauta"
                            Dt = .ObtenerAperturaSemanaP
                            Dt.TableName = "pauta"
                            dtReportes.Add(Dt)
                            Totales.Add(.Totalsemanap)
                        Case "calendario"
                            Dt = .ObtenerAperturaSemanaC
                            Dt.TableName = "calendario"
                            dtReportes.Add(Dt)
                            Totales.Add(.Totalsemanac)
                    End Select

                Next
            End With
        Catch ex As Exception
            '  Motor.Desconectar()
            MsgBox(ex.Message)
            Cursor.Current = Cursors.Default
            '  Return False
        End Try
        Dim f As New frmFormulaOne
        f.CargarReporteMotorP(ReporteMotorP.General, dtReportes, IDnuevo, cboTarget1.Text, Motor.TasaRepeticion, Motor.NoContactados, Motor.TotalGrps, Motor.CoberturaNeta, Motor.Avisos, Motor.FrecuenciaMaxima, Me.dtSoportesIbope, lblAlternativa.Text, Totales)
        Motor.Desconectar()
        'Cursor.Current = Cursors.Default
        ' Return True
    End Sub
End Class

Class FechaDia
    Public Fecha As Date
    Public Dia As System.DayOfWeek
End Class
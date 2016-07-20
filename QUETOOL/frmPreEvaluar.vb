Imports System.IO

Public Class frmPreEvaluar
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
    Friend WithEvents tabPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tabAlternativa As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents iugSpots As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents fraTarget As System.Windows.Forms.GroupBox
    Friend WithEvents cboTarget2 As QUETOOL.cboCombo
    Friend WithEvents cboTarget1 As QUETOOL.cboCombo
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.tabAlternativa = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.iugSpots = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.fraTarget = New System.Windows.Forms.GroupBox
        Me.cboTarget2 = New QUETOOL.cboCombo
        Me.cboTarget1 = New QUETOOL.cboCombo
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.tabPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdEjecutar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.tabAlternativa.SuspendLayout()
        CType(Me.iugSpots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraTarget.SuspendLayout()
        CType(Me.cboTarget2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTarget1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAlternativa
        '
        Me.tabAlternativa.Controls.Add(Me.iugSpots)
        Me.tabAlternativa.Controls.Add(Me.fraTarget)
        Me.tabAlternativa.Location = New System.Drawing.Point(1, 20)
        Me.tabAlternativa.Name = "tabAlternativa"
        Me.tabAlternativa.Size = New System.Drawing.Size(747, 479)
        '
        'iugSpots
        '
        Me.iugSpots.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance1.BorderColor = System.Drawing.Color.DimGray
        Me.iugSpots.DisplayLayout.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugSpots.DisplayLayout.CaptionAppearance = Appearance2
        Me.iugSpots.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugSpots.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False
        Me.iugSpots.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.iugSpots.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugSpots.FlatMode = True
        Me.iugSpots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugSpots.Location = New System.Drawing.Point(16, 88)
        Me.iugSpots.Name = "iugSpots"
        Me.iugSpots.Size = New System.Drawing.Size(720, 384)
        Me.iugSpots.TabIndex = 20
        '
        'fraTarget
        '
        Me.fraTarget.Controls.Add(Me.cboTarget2)
        Me.fraTarget.Controls.Add(Me.cboTarget1)
        Me.fraTarget.Controls.Add(Me.Label11)
        Me.fraTarget.Controls.Add(Me.Label12)
        Me.fraTarget.Location = New System.Drawing.Point(12, 8)
        Me.fraTarget.Name = "fraTarget"
        Me.fraTarget.Size = New System.Drawing.Size(724, 72)
        Me.fraTarget.TabIndex = 19
        Me.fraTarget.TabStop = False
        Me.fraTarget.Text = "Target"
        '
        'cboTarget2
        '
        Me.cboTarget2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTarget2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTarget2.DisplayMember = ""
        Me.cboTarget2.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTarget2.FlatMode = True
        Me.cboTarget2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTarget2.Location = New System.Drawing.Point(60, 40)
        Me.cboTarget2.Name = "cboTarget2"
        Me.cboTarget2.Size = New System.Drawing.Size(652, 21)
        Me.cboTarget2.TabIndex = 31
        Me.cboTarget2.ValueMember = ""
        '
        'cboTarget1
        '
        Me.cboTarget1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTarget1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTarget1.DisplayMember = ""
        Me.cboTarget1.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTarget1.FlatMode = True
        Me.cboTarget1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTarget1.Location = New System.Drawing.Point(60, 16)
        Me.cboTarget1.Name = "cboTarget1"
        Me.cboTarget1.Size = New System.Drawing.Size(652, 21)
        Me.cboTarget1.TabIndex = 0
        Me.cboTarget1.ValueMember = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 16)
        Me.Label11.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 16)
        Me.Label12.TabIndex = 29
        '
        'tabPrincipal
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.ForeColor = System.Drawing.Color.Blue
        Me.tabPrincipal.ActiveTabAppearance = Appearance3
        Me.tabPrincipal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabPrincipal.Controls.Add(Me.tabAlternativa)
        Me.tabPrincipal.Location = New System.Drawing.Point(7, 5)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabPrincipal.Size = New System.Drawing.Size(749, 500)
        Me.tabPrincipal.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.tabPrincipal.TabIndex = 54
        UltraTab1.Key = "Evaluación"
        UltraTab1.TabPage = Me.tabAlternativa
        UltraTab1.Text = "Evaluación"
        Me.tabPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(747, 479)
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(668, 512)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 24)
        Me.cmdSalir.TabIndex = 56
        Me.cmdSalir.Text = "Salir"
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(576, 512)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(88, 24)
        Me.cmdEjecutar.TabIndex = 55
        Me.cmdEjecutar.Text = "Evaluar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Button1"
        '
        'frmPreEvaluar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.tabPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPreEvaluar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPreEvaluar"
        Me.tabAlternativa.ResumeLayout(False)
        CType(Me.iugSpots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraTarget.ResumeLayout(False)
        CType(Me.cboTarget2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTarget1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Const gPathSimulacion = "C:\Documents and Settings\sescuin\Escritorio\DPS\EVA_IBO\"
    Const gPathEvaIbo = "C:\Documents and Settings\sescuin\Escritorio\DPS\EVA_IBO\"
    Dim Dia_Sem(7) As String
    Dim mdtSpots As DataTable
    Dim mId_target1 As Integer
    Dim mId_target2 As Integer
    Dim mF_Desde As Date
    Dim mF_Hasta As Date
    Dim mId_Campania As Int64

    Public Property dtSpots()
        Get
            dtSpots = mdtSpots
        End Get
        Set(ByVal Value)
            mdtSpots = Value
        End Set
    End Property

    Public Property Id_target1()
        Get
            Id_target1 = mId_target1
        End Get
        Set(ByVal Value)
            mId_target1 = Value
        End Set
    End Property

    Public Property Id_target2()
        Get
            Id_target2 = mId_target2
        End Get
        Set(ByVal Value)
            mId_target2 = Value
        End Set
    End Property

    Public Property F_Desde()
        Get
            F_Desde = mF_Desde
        End Get
        Set(ByVal Value)
            mF_Desde = Value
        End Set
    End Property

    Public Property F_Hasta()
        Get
            F_Hasta = mF_Hasta
        End Get
        Set(ByVal Value)
            mF_Hasta = Value
        End Set
    End Property

    Public Property Id_Campania()
        Get
            Id_Campania = mId_Campania
        End Get
        Set(ByVal Value)
            mId_Campania = Value
        End Set
    End Property

    Private Function NroSemanaMes(ByVal dDia As Date) As Integer
        Dim dPrimerDia As Date
        dPrimerDia = CDate("01/" & dDia.Month & "/" & dDia.Year)
        NroSemanaMes = DateDiff(DateInterval.WeekOfYear, dPrimerDia, dDia) + 1
    End Function

    Private Sub CargarTargets()
        Dim T As New Targets
        Dim Dt As DataTable

        '&&&& traer todos los de TV abierta
        Dt = T.TraerTodos(1)

        Listas.CargarCombo(cboTarget1, Dt, "Id_Target", "Descripcion")
        Listas.CargarCombo(cboTarget2, Dt, "Id_Target", "Descripcion", True)

        Listas.OcultarColumnas(cboTarget1, "Id_Target")
        Listas.OcultarColumnas(cboTarget2, "Id_Target")

        Listas.OcultarHeader(cboTarget1)
        Listas.OcultarHeader(cboTarget2)
    End Sub

    Private Sub CargarSpots()
        Dim row As DataRow
        Dim oSop As New Soportes
        Dim oTar As New Tarifas_tv
        Dim Hora As Date
        Dim Duracion As Integer
        ' deberiamos agregar en soportes un campo que sea id_EvaIbo
        For Each row In mdtSpots.Rows
            row("Procesar") = True
            row("Dia") = Dia_Sem(Weekday(row("Fecha")))
            oSop.Id_soporte = row("Id_Soporte")
            oSop.Id_medio = Activo.IDMedio
            oSop.BuscarPorID_Soporte()
            row("Soporte") = oSop.Descripcion
            row("SoporteEvaIbo") = oSop.Descripcion
            oTar.Id_tarifa_tv = row("Id_Tarifa")
            oTar.BuscarPorID()
            row("Programa") = oTar.Programa
            row("Costo") = oTar.Bruto
            row("Hora") = oTar.H_desde
            Duracion = (oTar.H_hasta - oTar.H_desde) * 60 + (oTar.M_hasta - oTar.M_desde)
            row("Hora") = Listas.SumarHoras(oTar.H_desde.ToString.PadLeft(2, "0") & ":" & oTar.M_desde.ToString.PadLeft(2, "0"), Int(Duracion / 2), "mmmm")
            row("DayPart") = CalcularDayPart(Hora)
            row("Rotlvsd") = CalcularRotacion(Weekday(row("Fecha")))
        Next

        iugSpots.DataSource = dtSpots

        Listas.OcultarColumnas(iugSpots, "Id", "Dia", "Hora", "SoporteEvaIbo", "Spots", _
                                "Id_Soporte", "Id_Tarifa", "Rotlvsd", "DayPart", _
                                "Costo", "FechaReal", "PBR_1", "PBR_2", "CPR1_1", "CPR1_2")

        Listas.CambiarTituloColumna(iugSpots, "Rotlvsd", "L-V S-D")
        Listas.CambiarTituloColumna(iugSpots, "Duracion", "Duración")
        Listas.CambiarTituloColumna(iugSpots, "PBR_1", "PBR 1")
        Listas.CambiarTituloColumna(iugSpots, "PBR_2", "PBR 2")
        Listas.CambiarTituloColumna(iugSpots, "CPR1_1", "CPR:1 1")
        Listas.CambiarTituloColumna(iugSpots, "CPR1_2", "CPR:1 2")

        iugSpots.DisplayLayout.Bands(0).Columns("Procesar").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        Listas.AplicarFormato(iugSpots)

        Dim G As New GrillaFormato

        G.CambiarFormatoColumna(iugSpots, "Fecha", Formato.FechaCorta)
    End Sub

    Private Function CalcularRotacion(ByVal dia As Integer) As String
        Select Case dia
            Case 1, 2, 3, 4, 5
                CalcularRotacion = "L-V"
            Case 6, 7
                CalcularRotacion = "S-D"
        End Select
    End Function

    Private Function CalcularDayPart(ByVal pHora As Date) As Integer
        CalcularDayPart = 1
    End Function

    Private Sub frmPreEvaluar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dia_Sem(1) = "L"
        Dia_Sem(2) = "M"
        Dia_Sem(3) = "C"
        Dia_Sem(4) = "J"
        Dia_Sem(5) = "V"
        Dia_Sem(6) = "S"
        Dia_Sem(7) = "D"

        CargarTargets()
        CargarSpots()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEjecutar.Click
        Dim nSemana As Byte
        Dim nCantSem As Byte
        Dim dFecAux As Date
        Dim sr As StreamWriter
        Dim Dif_Dias As Integer
        Dim File_Out As String
        Dim File_Out2 As String
        Dim Archivo As String
        Dim registro As String
        Dim Secuencia As Integer
        Dim Act_Dir As String
        Dim dTxtF_final As Date
        Dim mvarLeyenda As String
        Dim mvarIdTema As String
        Dim i As Integer
        Dim ParametroGBAInt As String
        Dim ShellProcess As New Process
        Dim sEvaIbo As String
        Dim CodInst As String

        Dim Page As New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Dim reDF As ResEvaluacionDF
        Dim reRA As ResEvaluacionRA
        Dim iutTab As New Infragistics.Win.UltraWinTabControl.UltraTab

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Randomize()
        mvarLeyenda = "AA" & Format(CInt(Int((999999 * Rnd()) + 1)), "000000")

        nSemana = NroSemanaMes(F_Desde)
        If Me.cboTarget1.Text = "" Then
            Mensajes.Mensaje("Falta seleccionar un target primario")
            Cursor.Current = System.Windows.Forms.Cursors.Default()
            Exit Sub
        End If

        '' Parche horrible de german, con garompa incluida (semana desganada)
        '' Es por si no existe el archivo para la semana pedida, lo "emula" tomando los ratings de otro archivo
        'If nSemana >= 5 Then nSemana = 4

        'If Dir(gPathSimulacion & CStr(Year(F_Desde)) & Format(Month(F_Desde), "00") & CStr(nSemana) & "*.a10") = "" Then
        '    MsgBox("No hay información para la semana inicial " & Chr(13) & _
        '        "Seleccione otra semana para comenzar ...", vbInformation, "SIMULACION")
        '    Cursor.Current = System.Windows.Forms.Cursors.Default()
        '    Exit Sub
        'End If

        dFecAux = F_Desde
        nCantSem = DateDiff(DateInterval.WeekOfYear, F_Desde, F_Hasta)
        dTxtF_final = DateAdd("d", DateDiff("d", F_Desde, F_Hasta), F_Desde)

        'For x = 1 To nCantSem
        '    If DateAdd("ww", 1, dFecAux) > F_Hasta Then
        '        dFecAux = F_Hasta
        '    Else
        '        dFecAux = DateAdd("ww", 1, dFecAux)
        '    End If

        '    nSemana = NroSemanaMes(dFecAux)
        '    If nSemana < 5 Then
        '        If Dir(gPathSimulacion & CStr(Year(dFecAux)) & Format(Month(dFecAux), "00") & CStr(nSemana) & "*.a10") = "" Then
        '            MsgBox("Probable inconcistencia de datos, revise los resultados cuando termine la evaluación", vbInformation, "SIMULACION")
        '            Cursor.Current = System.Windows.Forms.Cursors.Default()
        '        End If
        '    End If
        'Next x

        File_Out2 = mvarLeyenda.Substring(2, 6)

        Kill(gPathEvaIbo & "DF" & File_Out2 & ".*")   ' Borra resultados anteriores
        Kill(gPathEvaIbo & "RA" & File_Out2 & ".*")   ' Borra resultados anteriores

        File_Out = gPathSimulacion & "EV" & File_Out2
        Archivo = gPathSimulacion & "EV" & File_Out2 & ".TXT"
        Dif_Dias = DateDiff("d", CDate(F_Desde), CDate(F_Desde))

        sr = File.CreateText(Archivo)
        ' Lee la Plaza
        registro = "GBA" & vbCr & vbLf
        ' Lee fecha
        registro = registro & Format(F_Desde, "ddmmyyyy") & vbCr & vbLf
        ' Lee el target 1
        registro = registro & cboTarget1.ActiveRow.Cells("id_Target").Value & vbCr & vbLf
        ' Lee el target 2 si lo hubiese
        If (cboTarget2.ActiveRow.Cells("descripcion").Value <> "") Then
            registro = registro & cboTarget2.ActiveRow.Cells("id_Target").Value & vbCr & vbLf
        Else
            registro = registro & vbCr & vbLf & vbCr & vbLf & vbCr & vbLf & vbCr & vbLf
        End If
        registro = registro & mvarLeyenda.Substring(0, 18)
        'Imprime cabecera
        sr.WriteLine(registro)

        Secuencia = 0
        For i = 0 To iugSpots.Rows.Count - 1
            If dtSpots.Rows(i).Item("Marca") Then
                registro = ""
                Secuencia = Secuencia + 1
                registro = registro & Trim(CStr(Secuencia)) & ","
                dFecAux = DateAdd("d", Dif_Dias, dtSpots.Rows(i).Item("Fecha"))
                registro = registro & Format(dFecAux, "ddmmyyyy") & ","
                registro = registro & Dia_Sem(Weekday(dFecAux) - 1) & ","
                registro = registro & Format(dtSpots.Rows(i).Item("hora") & dtSpots.Rows(i).Item("hora"), "hhmm") & "00" & ","
                registro = registro & dtSpots.Rows(i).Item("SoporteEvaIbo") & ","   ' Medio para el Eva Ibo
                registro = registro & "1"
                sr.WriteLine(registro)
            End If
        Next i

        sr.Close()

        CodInst = "GBA"

        sEvaIbo = "EVA_IBO.EXE " & ParametroGBAInt & " IBO T " & CodInst & " " & Format$(F_Desde, "DDMMYYYY") & " " & Format$(dTxtF_final, "DDMMYYYY") & " " & File_Out & " 1 1 " & File_Out2 & " S 2"

        Act_Dir = CurDir()
        ChDrive(gPathEvaIbo.Substring(0, 1))
        ChDir(gPathEvaIbo)

        ShellProcess.StartInfo.FileName = gPathEvaIbo & sEvaIbo
        ShellProcess.StartInfo.UseShellExecute = True
        ShellProcess.Start()
        ShellProcess.WaitForExit()

        Cursor.Current = System.Windows.Forms.Cursors.Default()
        ChDrive(Act_Dir.Substring(0, 1))
        ChDir(Act_Dir)

        If File.Exists("DF" & File_Out2 & ".txt") And File.Exists("RA" & File_Out2 & ".txt") Then
            ' cargo la solapa de distribucion de frecuencia
            reDF = New ResEvaluacionDF(gPathEvaIbo, "057994", 240, 31442, 20)
            Me.tabPrincipal.Controls.Add(Page)
            Page.Controls.Add(reDF)
            Page.Tab.Text = "Resultados " & tabPrincipal.Tabs.Count - 1
            iutTab.TabPage = Page

            ' cargo la solapa de ratings
            reRA = New ResEvaluacionRA
            Me.tabPrincipal.Controls.Add(Page)
            Page.Controls.Add(reRA)
            Page.Tab.Text = "Resultados " & tabPrincipal.Tabs.Count - 1
            iutTab.TabPage = Page
        End If
        Cursor.Current = System.Windows.Forms.Cursors.Default()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Page As New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Dim Page2 As New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Dim re As ResEvaluacionDF
        Dim reRA As ResEvaluacionRA
        Dim iutTab1 As New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim iutTab2 As New Infragistics.Win.UltraWinTabControl.UltraTab


        re = New ResEvaluacionDF(gPathEvaIbo, "057994", 240, 31442, 20)

        Me.tabPrincipal.Controls.Add(Page)
        Page.Controls.Add(re)
        Page.Tab.Text = "Resultados " & tabPrincipal.Tabs.Count - 1
        iutTab1.TabPage = Page

        ' cargo la solapa de ratings
        reRA = New ResEvaluacionRA(gPathEvaIbo, "057994", mdtSpots)

        Me.tabPrincipal.Controls.Add(Page2)
        Page2.Controls.Add(reRA)
        Page2.Tab.Text = "Resultado " & tabPrincipal.Tabs.Count - 1
        iutTab2.TabPage = Page2
    End Sub

    Private Sub iugSpots_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iugSpots.MouseUp
        Dim aUIElement As Infragistics.Win.UIElement
        aUIElement = iugSpots.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
        ' declare and retrieve a reference to the Cell
        Dim aRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        aRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
        ' if a cell was found display the band and column key
        If Not aRow Is Nothing Then
            If iugSpots.ActiveRow.Cells("Procesar").Value Then
                iugSpots.ActiveRow.Cells("Procesar").Value = False
            Else
                iugSpots.ActiveRow.Cells("Procesar").Value = True
            End If
        End If

    End Sub
End Class


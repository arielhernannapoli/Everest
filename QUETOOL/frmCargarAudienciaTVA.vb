Imports System
Imports System.IO

Public Class frmCargarAudienciaTVA
    Inherits System.Windows.Forms.Form

    Const TIPO_SOPORTE = 1
    Const PLAZA = 1
    Const MEDIO = 1

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
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAbrirDlg As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblArchivoAudiencia As System.Windows.Forms.Label
    Friend WithEvents pgbProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents txtTandasTVA As System.Windows.Forms.TextBox
    Friend WithEvents txtAudienciaSalida As System.Windows.Forms.TextBox
    Friend WithEvents cmdAudiencia As System.Windows.Forms.Button
    Friend WithEvents cmdTandas As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents chkLoader As System.Windows.Forms.CheckBox
    Friend WithEvents fraArcSalida As System.Windows.Forms.GroupBox
    Friend WithEvents fraAudiencia As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdEjecutar = New System.Windows.Forms.Button
        Me.fraArcSalida = New System.Windows.Forms.GroupBox
        Me.cmdTandas = New System.Windows.Forms.Button
        Me.cmdAudiencia = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTandasTVA = New System.Windows.Forms.TextBox
        Me.txtAudienciaSalida = New System.Windows.Forms.TextBox
        Me.fraAudiencia = New System.Windows.Forms.GroupBox
        Me.cmdAbrirDlg = New System.Windows.Forms.Button
        Me.lblArchivoAudiencia = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pgbProgreso = New System.Windows.Forms.ProgressBar
        Me.lblEstado = New System.Windows.Forms.Label
        Me.chkLoader = New System.Windows.Forms.CheckBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.fraArcSalida.SuspendLayout()
        Me.fraAudiencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(396, 200)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(88, 24)
        Me.cmdEjecutar.TabIndex = 4
        Me.cmdEjecutar.Text = "Ejecutar"
        '
        'fraArcSalida
        '
        Me.fraArcSalida.Controls.Add(Me.cmdTandas)
        Me.fraArcSalida.Controls.Add(Me.cmdAudiencia)
        Me.fraArcSalida.Controls.Add(Me.Label2)
        Me.fraArcSalida.Controls.Add(Me.Label1)
        Me.fraArcSalida.Controls.Add(Me.txtTandasTVA)
        Me.fraArcSalida.Controls.Add(Me.txtAudienciaSalida)
        Me.fraArcSalida.Enabled = False
        Me.fraArcSalida.Location = New System.Drawing.Point(8, 72)
        Me.fraArcSalida.Name = "fraArcSalida"
        Me.fraArcSalida.Size = New System.Drawing.Size(584, 88)
        Me.fraArcSalida.TabIndex = 4
        Me.fraArcSalida.TabStop = False
        '
        'cmdTandas
        '
        Me.cmdTandas.Location = New System.Drawing.Point(552, 54)
        Me.cmdTandas.Name = "cmdTandas"
        Me.cmdTandas.Size = New System.Drawing.Size(20, 20)
        Me.cmdTandas.TabIndex = 8
        Me.cmdTandas.Text = "..."
        '
        'cmdAudiencia
        '
        Me.cmdAudiencia.Location = New System.Drawing.Point(552, 22)
        Me.cmdAudiencia.Name = "cmdAudiencia"
        Me.cmdAudiencia.Size = New System.Drawing.Size(20, 20)
        Me.cmdAudiencia.TabIndex = 7
        Me.cmdAudiencia.Text = "..."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tandas TVA"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Audiencia"
        '
        'txtTandasTVA
        '
        Me.txtTandasTVA.Location = New System.Drawing.Point(93, 54)
        Me.txtTandasTVA.Name = "txtTandasTVA"
        Me.txtTandasTVA.Size = New System.Drawing.Size(459, 20)
        Me.txtTandasTVA.TabIndex = 3
        Me.txtTandasTVA.Text = ""
        '
        'txtAudienciaSalida
        '
        Me.txtAudienciaSalida.Location = New System.Drawing.Point(93, 22)
        Me.txtAudienciaSalida.Name = "txtAudienciaSalida"
        Me.txtAudienciaSalida.Size = New System.Drawing.Size(459, 20)
        Me.txtAudienciaSalida.TabIndex = 2
        Me.txtAudienciaSalida.Text = ""
        '
        'fraAudiencia
        '
        Me.fraAudiencia.Controls.Add(Me.cmdAbrirDlg)
        Me.fraAudiencia.Controls.Add(Me.lblArchivoAudiencia)
        Me.fraAudiencia.Controls.Add(Me.Label5)
        Me.fraAudiencia.Location = New System.Drawing.Point(8, 8)
        Me.fraAudiencia.Name = "fraAudiencia"
        Me.fraAudiencia.Size = New System.Drawing.Size(584, 56)
        Me.fraAudiencia.TabIndex = 6
        Me.fraAudiencia.TabStop = False
        Me.fraAudiencia.Text = "Archivo de entrada"
        '
        'cmdAbrirDlg
        '
        Me.cmdAbrirDlg.Location = New System.Drawing.Point(552, 24)
        Me.cmdAbrirDlg.Name = "cmdAbrirDlg"
        Me.cmdAbrirDlg.Size = New System.Drawing.Size(20, 20)
        Me.cmdAbrirDlg.TabIndex = 4
        Me.cmdAbrirDlg.Text = "..."
        '
        'lblArchivoAudiencia
        '
        Me.lblArchivoAudiencia.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblArchivoAudiencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArchivoAudiencia.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblArchivoAudiencia.Location = New System.Drawing.Point(96, 24)
        Me.lblArchivoAudiencia.Name = "lblArchivoAudiencia"
        Me.lblArchivoAudiencia.Size = New System.Drawing.Size(456, 20)
        Me.lblArchivoAudiencia.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Audiencia"
        '
        'pgbProgreso
        '
        Me.pgbProgreso.Location = New System.Drawing.Point(8, 184)
        Me.pgbProgreso.Name = "pgbProgreso"
        Me.pgbProgreso.Size = New System.Drawing.Size(572, 8)
        Me.pgbProgreso.TabIndex = 7
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(12, 164)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(137, 16)
        Me.lblEstado.TabIndex = 8
        Me.lblEstado.Text = "Esperando para comenzar"
        '
        'chkLoader
        '
        Me.chkLoader.Location = New System.Drawing.Point(25, 72)
        Me.chkLoader.Name = "chkLoader"
        Me.chkLoader.Size = New System.Drawing.Size(159, 16)
        Me.chkLoader.TabIndex = 9
        Me.chkLoader.Text = "Cargar desde SQL Loader"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(492, 200)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 24)
        Me.cmdSalir.TabIndex = 19
        Me.cmdSalir.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Generar Relación"
        Me.Button1.Visible = False
        '
        'frmCargarAudienciaTVA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(598, 231)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.chkLoader)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.pgbProgreso)
        Me.Controls.Add(Me.fraAudiencia)
        Me.Controls.Add(Me.fraArcSalida)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCargarAudienciaTVA"
        Me.ShowInTaskbar = False
        Me.Text = "Cargar Audiencia TVA"
        Me.fraArcSalida.ResumeLayout(False)
        Me.fraAudiencia.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEjecutar.Click
        Dim i As Long
        Dim linea As String
        Dim arlinea() As String
        Dim ar(0) As Integer
        Dim arFechas(0) As String
        Dim antPrograma As String
        Dim antProgramaFecha As String
        Dim actPrograma As String
        Dim actProgramaFecha As String
        ' defino las variables para no tener que buscar los id constantemente.
        Dim auxId_Medio As Integer
        Dim auxId_Soporte As Integer
        Dim auxId_Programa As Integer

        Dim sr As StreamReader
        Dim FileAudi As StreamWriter
        Dim FileTanda As StreamWriter
        Dim fso As FileAttributes
        Dim fi As FileInfo
        Dim cntBytes As Long
        Dim ok As Boolean
        Dim InicioProceso As Date
        Dim oAudiencia_TVA As New Audiencia_Tva
        Dim j As Integer

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''' Valido la entrada de datos ''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        pgbProgreso.Value = 0
        cmdEjecutar.Enabled = False
        fraAudiencia.Enabled = False
        If chkLoader.Checked Then
            fraArcSalida.Enabled = False
        End If
        InicioProceso = Now
        lblEstado.Text = "Verificando datos"
        lblEstado.Refresh()
        ok = True
        If Trim(lblArchivoAudiencia.Text) = "" Then
            MsgBox("Debe especificar un archivo de audiencia", MsgBoxStyle.Information)
            ok = False
        Else
            If Not File.Exists(lblArchivoAudiencia.Text) Then
                MsgBox("No existe " & lblArchivoAudiencia.Text)
                ok = False
            End If
        End If

        If chkLoader.Checked Then
            If Trim(txtAudienciaSalida.Text) = "" And ok Then
                MsgBox("Debe especificar un archivo de salida de audiencia", MsgBoxStyle.Information)
                txtAudienciaSalida.Focus()
                ok = False
            Else
                If File.Exists(txtAudienciaSalida.Text) And ok Then
                    If MsgBox("El archivo " & txtAudienciaSalida.Text & " ya existe. Desea sobreescribirlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1) = MsgBoxResult.No Then
                        ok = False
                    End If
                End If
            End If

            If Trim(txtTandasTVA.Text) = "" And ok Then
                MsgBox("Debe especificar un archivo de salida de Tandas TVA", MsgBoxStyle.Information)
                txtTandasTVA.Focus()
                ok = False
            Else
                If File.Exists(txtTandasTVA.Text) And ok Then
                    If MsgBox("El archivo " & txtTandasTVA.Text & " ya existe. Desea sobreescribirlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1) = MsgBoxResult.No Then
                        ok = False
                    End If
                End If
            End If

            If Trim(txtTandasTVA.Text) = Trim(lblArchivoAudiencia.Text) And ok Then
                MsgBox("Los archivos de salida deben tener distintos nombres", MsgBoxStyle.Information)
                ok = False
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If ok Then
            Try
                lblEstado.Text = "Chequeando fechas y targets para proceso"
                lblEstado.Refresh()
                GetTargetsFechasAudiencia(lblArchivoAudiencia.Text, ar, arFechas) ' calculo todas las fechas que se van a procesar
                sr = File.OpenText(lblArchivoAudiencia.Text) ' abro el archivo de audiencia
                ' Archivos de salida
                Dim oPrograma As cProgramaBT
                If chkLoader.Checked Then
                    FileAudi = File.CreateText(txtAudienciaSalida.Text)
                    FileTanda = File.CreateText(txtTandasTVA.Text)

                    EscribeHeaderSQLLoader_Audi(FileAudi)
                    EscribeHeaderSQLLoader_Tanda(FileTanda)
                    oPrograma = New cProgramaBT(FileAudi, FileTanda)
                Else
                    oPrograma = New cProgramaBT
                End If

                ' verifico reprocesos y los presento por pantalla
                lblEstado.Text = "Verificando audiencia cargada"
                lblEstado.Refresh()
                If Not VerificaBorraAudienciaExistente(ar, arFechas) Then
                    sr.Close()
                    If chkLoader.Checked Then
                        FileAudi.Close()
                        FileTanda.Close()
                    End If
                    cmdEjecutar.Enabled = True
                    fraAudiencia.Enabled = True
                    If chkLoader.Checked Then
                        fraArcSalida.Enabled = True
                    End If
                    Exit Sub
                End If
                ' preparo la barra de progreso
                fi = New FileInfo(lblArchivoAudiencia.Text)
                pgbProgreso.Maximum = fi.Length
                '''''''''''''''''''''''''''''''''''''''''
                ' recorro el archivo hasta el primer dato
                '''''''''''''''''''''''''''''''''''''''''
                linea = NextLinea(sr, cntBytes)
                arlinea = Split(linea, ";")
                pgbProgreso.Increment(cntBytes)
                '''''''''''''''''''''''''''''''''''''''''
                oPrograma.arTarget = ar
                antPrograma = Listas.GetNombreSinBarras(arlinea(cProgramaBT.ccNombre))
                antProgramaFecha = arlinea(cProgramaBT.ccFecha)
                ' Guardo el actual
                actPrograma = antPrograma
                actProgramaFecha = arlinea(cProgramaBT.ccFecha)
                i = 0
                j = 0
                lblEstado.Text = "Iniciando proceso de generación de audiencia"
                lblEstado.Refresh()
                While Not linea Is Nothing
                    While (Not linea Is Nothing) And (actPrograma = antPrograma)
                        While (Not linea Is Nothing) And (actPrograma = antPrograma) And (actProgramaFecha = antProgramaFecha)
                            ' Cargo el programa de la linea
                            Application.DoEvents()
                            oPrograma.Cargar(linea)
                            linea = NextLinea(sr, cntBytes)
                            arlinea = Split(linea, ";")
                            If linea <> Nothing Then ' parche para el ultimo registro HORRIBLE!
                                actPrograma = Listas.GetNombreSinBarras(arlinea(cProgramaBT.ccNombre))
                                actProgramaFecha = arlinea(cProgramaBT.ccFecha)
                                pgbProgreso.Increment(cntBytes)
                                i = i + 1
                            End If
                        End While
                        oPrograma.InsertaTXT(FileAudi, oAudiencia_TVA, j)  ' Inserto la audiencia
                        j = j + 1
                        antProgramaFecha = actProgramaFecha
                        oPrograma.LimpiaTargets() ' Pongo en 0 los targets para recalcular los promedios tanda
                    End While
                    ' Se saca porque puede llegar a generar confusion con el matcho automatico, se va a hacer todo manual.
                    'GeneraRelacionProgramaTarifas(oPrograma.Id_Programa, oPrograma.Id_Plaza, oPrograma.Id_Medio, oPrograma.Id_Soporte, oPrograma.Nombre, oPrograma.DiaSem, antProgramaFecha)
                    antPrograma = actPrograma
                    oPrograma.LiberaTargets()
                End While
                lblEstado.Text = "Generando log de ejecución"
                lblEstado.Refresh()
                GeneraLogEjecucion(arFechas, ar, oPrograma.Id_Medio, TIPO_SOPORTE, oPrograma.Id_Plaza)
                ' calculo el j como: j es la cantidad de inserciones, por cada insercion se hacen 2 (T y B) por cada target 
                MsgBox("Finalizó la carga de audiencia. Se procesaron " & j * 2 * ar.Length & " registros." & Chr(13) & " el proceso demoro " & DateDiff(DateInterval.Second, InicioProceso, Now))

            Catch ex As Exception
                lblEstado.Text = ""
                Mensajes.Mensaje(ex.Message & " " & i, TipoMensaje.DeError)
            End Try

            If Not sr Is Nothing Then
                sr.Close()
                If chkLoader.Checked Then
                    FileAudi.Close()
                    FileTanda.Close()
                End If
            End If
        End If
        cmdEjecutar.Enabled = True
        fraAudiencia.Enabled = True
        If chkLoader.Checked Then
            fraArcSalida.Enabled = True
        End If
    End Sub
    Private Sub GeneraRelacionProgramaTarifas(ByVal pId_Programa As Int32, ByVal pId_Plaza As Int32, ByVal pId_Medio As Int32, ByVal pId_Soporte As Int32, ByVal pNombre As String, ByVal pDia As String, ByVal p_Inicio_Vig As String)
        Dim oTarifas_TV As New Tarifas_tv
        Dim oPrograma As New Programas
        Dim ds As New DataSet

        Try
            oPrograma.Id_programa = pId_Programa
            oPrograma.BuscarPorID()
            If oPrograma.Marca <> "X" Then ' si el programa ya esta relacionado, no hago nada
                With oTarifas_TV
                    .Id_medio = pId_Medio
                    .Id_soporte = pId_Soporte
                    .Programa = pNombre
                    .Id_programa = pId_Programa
                    ' no se relaciona nada hasta que definamos como debe relacionarse correctamente
                    'ds = .Modificar_IdPrograma()
                    If ds.Tables(0).Rows.Count > 0 Then
                        oPrograma.Marca = "X"
                        oPrograma.Modificar()
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function VerificaBorraAudienciaExistente(ByVal ar() As Integer, ByVal arfechas() As String) As Boolean
        Dim i As Integer
        Dim j As Integer
        Dim texto As String
        Dim oT As New Targets_telereport
        Dim oAudiencias_Fechas As New Audiencias_fechas
        Dim oAudiencias_TVA As New Audiencia_Tva
        Dim ok As Boolean
        Dim fdesde As Date
        Dim fhasta As Date
        Dim k As Date
        Dim oTandas_TVA As New Tandas_tva
        Dim dt As DataTable
        Dim TargetsaBorrar As New ArrayList

        Try
            ok = True
            fdesde = Mid(arfechas(0), 5, 2) & "/" & Mid(arfechas(0), 3, 2) & "/" & Mid(arfechas(0), 1, 2)
            fhasta = Mid(arfechas(arfechas.Length - 1), 5, 2) & "/" & Mid(arfechas(arfechas.Length - 1), 3, 2) & "/" & Mid(arfechas(arfechas.Length - 1), 1, 2)
            lblEstado.Text = "Verificando datos cargados"
            lblEstado.Refresh()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''' Verifico logs de fechas ''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For i = 0 To ar.Length - 1
                With oAudiencias_Fechas
                    .Id_plaza = PLAZA
                    .Id_medio = MEDIO
                    .Id_tipo_soporte = TIPO_SOPORTE
                    k = fdesde
                    While k <= fhasta
                        .Id_target = ar(i)
                        .F_inicio = k
                        .F_fin = IIf(fdesde <> fhasta, k.AddDays(6), k) ' si tengo un rago de fechas
                        dt = .ConsultarCarga_Datos()
                        If dt.Rows.Count > 0 Then
                            oT.Id_target = ar(i)
                            oT.BuscarPorID()
                            texto = texto & Chr(13) & "Existe audiencia para el target " & oT.Descripcion & " en el rango de " & fdesde & "  al " & fhasta & " "
                            'Modificacion
                            TargetsaBorrar.Add(ar(i))
                            '-------------
                            If fdesde = fhasta Then
                                If dt.Rows(0).Item("f_inicio") <> dt.Rows(0).Item("f_fin") Then
                                    MsgBox("Hay una semana completa cargada, no puede reprocesar sólo un dia, debe reprocesar la semana completa")
                                    VerificaBorraAudienciaExistente = False
                                    Exit Function
                                End If
                            End If
                            Exit While
                        End If
                        k = k.AddDays(7)
                    End While
                End With
            Next i

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' verifico que el comienzo y el fin de la audiencia sean lunes y domingo '
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If (fdesde.DayOfWeek <> DayOfWeek.Monday) Or (fhasta.DayOfWeek <> DayOfWeek.Sunday) Then
                If arfechas.Length > 1 Then  ' si hay una unica fecha, la tengo que procesar
                    lblEstado.Text = "Solo se aceptan semanas completas"
                    VerificaBorraAudienciaExistente = False
                    Exit Function
                End If
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Si encontro audiencia, la borro antes de comenzar a cargar, para cada target '
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If texto <> "" Then
                If MsgBox(texto & Chr(13) & "Desea reprocesar estas fechas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ' borro primero audiencia_fechas
                    Application.DoEvents()
                    lblEstado.Text = "Borrando logs de fechas "
                    lblEstado.Refresh()

                    'For i = 0 To ar.Length - 1
                    'For i = 0 To TargetsaBorrar.Count
                    For Each t As Integer In TargetsaBorrar
                        With oAudiencias_Fechas
                            .Id_plaza = PLAZA
                            .Id_medio = MEDIO
                            .Id_tipo_soporte = TIPO_SOPORTE
                            k = fdesde
                            While k <= fhasta
                                .Id_target = t
                                .F_inicio = k
                                .F_fin = k.AddDays(6)
                                .BorrarCarga_Datos()
                                k = k.AddDays(7)
                            End While
                        End With
                    Next

                    pgbProgreso.Maximum = TargetsaBorrar.Count ' - 1
                    ' para cada target borro toda la audiencia de audiencias_tva y de tandas_tva
                    'For i = 0 To ar.Length - 1
                    For Each t As Integer In TargetsaBorrar
                        lblEstado.Text = "Borrando audiencia cargada para el target " & t
                        lblEstado.Refresh()
                        With oAudiencias_TVA
                            .Id_Plaza = PLAZA
                            .Id_Target = t
                            .Id_Medio = MEDIO
                            .BorrarDatos_Carga(fdesde, fhasta)
                        End With
                        With oTandas_TVA
                            .Id_plaza = PLAZA
                            .Id_target = t
                            .Id_medio = MEDIO
                            .BorrarDatos_Carga(fdesde, fhasta)
                        End With
                        pgbProgreso.Increment(1)
                    Next
                    pgbProgreso.Value = 0
                    VerificaBorraAudienciaExistente = True
                Else
                        VerificaBorraAudienciaExistente = False
                End If
            Else

                pgbProgreso.Value = 0
                pgbProgreso.Maximum = ar.Length - 1
                VerificaBorraAudienciaExistente = True
            End If
            'Else
            '    pgbProgreso.Value = 0
            '    pgbProgreso.Maximum = TargetsaBorrar.Count
            '    ' para cada target borro toda la audiencia de audiencias_tva y de tandas_tva
            '    ' For i = 0 To ar.Length - 1
            '    For i = 0 To TargetsaBorrar.Count
            '        lblEstado.Text = "Borrando audiencia cargada para el target " & TargetsaBorrar(i)
            '        lblEstado.Refresh()
            '        With oAudiencias_TVA
            '            .Id_Plaza = PLAZA
            '            .Id_Target = TargetsaBorrar(i)
            '            .Id_Medio = MEDIO
            '            .BorrarDatos_Carga(fdesde, fhasta)
            '        End With
            '        With oTandas_TVA
            '            .Id_plaza = PLAZA
            '            .Id_target = TargetsaBorrar(i)
            '            .Id_medio = MEDIO
            '            .BorrarDatos_Carga(fdesde, fhasta)
            '        End With
            '        pgbProgreso.Increment(1)
            '    Next i
            '    pgbProgreso.Value = 0
            '    VerificaBorraAudienciaExistente = True
            ' End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub GeneraLogEjecucion(ByVal parFecha() As String, ByVal parTarget() As Integer, ByVal p_id_medio As Int64, ByVal p_id_tipo_soporte As Int64, ByVal p_id_plaza As String)
        ' Genera un log de ejecucion en audiencia_fechas. Guarda por target por semana, la fecha de inicio y f fin son redundantes
        Dim oAudiencias_Fechas As New Audiencias_fechas
        Dim i As Integer
        Dim j As Integer
        Dim d As Date

        Try
            With oAudiencias_Fechas
                .Id_plaza = PLAZA
                .Id_medio = MEDIO
                .Id_tipo_soporte = TIPO_SOPORTE
                '.Anio = Mid(parFecha(0), 1, 2)
                .Anio = obtenerAñoSemana(parFecha(0))
                For j = 0 To parFecha.Length - 1 ' el ciclo es para recorrer todas las fechas, en la 1era siempre entra
                    ' si tiene mas de 1 semana, agrega tantos registros como semanas abarque la consulta
                    d = Mid(parFecha(j), 5, 2) & "/" & Mid(parFecha(j), 3, 2) & "/" & Mid(parFecha(j), 1, 2)
                    If parFecha.Length > 1 Then ' si tengo mas de un dia
                        If d.DayOfWeek = DayOfWeek.Monday Then
                            .Semana = Listas.GetSemana(d)
                            .F_inicio = d
                            .F_fin = d.AddDays(6)
                            For i = 0 To parTarget.Length - 1
                                .Id_target = parTarget(i)
                                .Agregar()
                            Next i
                        End If
                    Else
                        .Semana = Listas.GetSemana(d)
                        .F_inicio = d
                        .F_fin = d
                        For i = 0 To parTarget.Length - 1
                            .Id_target = parTarget(i)
                            .Agregar()
                        Next i
                    End If
                Next j
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Function obtenerAñoSemana(ByVal fec As String) As Integer

        'AGREGADO CHV PARA CONTROLAR LA CLAVE DUPLICADA DE AUDIENCIA FECHAS
        'para el casa que el 29,30,31 de diciembre caiga lunes martes o miercoles la semana
        'pertenese al año siguinete, la solucion es medio trucha pero eficiente


        Dim fecha As Date
        fecha = Mid(fec, 5, 2) & "/" & Mid(fec, 3, 2) & "/" & Mid(fec, 1, 2)

        If fecha.Month = 12 Then
            Select Case fecha.Day
                Case 29
                    If fecha.DayOfWeek = DayOfWeek.Monday Then
                        Return fecha.Year + 1
                    End If
                Case 30
                    If fecha.DayOfWeek = DayOfWeek.Monday Or fecha.DayOfWeek = DayOfWeek.Tuesday Then
                        Return fecha.Year + 1
                    End If
                Case 31
                    If fecha.DayOfWeek = DayOfWeek.Monday Or fecha.DayOfWeek = DayOfWeek.Tuesday Or fecha.DayOfWeek = DayOfWeek.Thursday Then
                        Return fecha.Year + 1
                    End If
            End Select
        End If
        Return fecha.Year
    End Function

    Private Sub EscribeHeaderSQLLoader_Audi(ByVal FileAudi As StreamWriter)
        With FileAudi
            .WriteLine("OPTIONS (DIRECT=TRUE)")
            .WriteLine("UNRECOVERABLE")
            .WriteLine("Load Data")
            .WriteLine("INFILE *")
            .WriteLine("APPEND")
            .WriteLine("INTO TABLE QUETOOL.AUDIENCIA_TVA")
            .WriteLine("FIELDS TERMINATED BY "";""")
            .WriteLine("TRAILING NULLCOLS")
            .Write("(ID_AUDIENCIA,")
            .Write("ID_PLAZA,")
            .Write("ID_TARGET,")
            .Write("F_PROGRAMA DATE ""DD/MM/YY"",")
            .Write("ID_MEDIO,")
            .Write("ID_SOPORTE,")
            .Write("ID_PROGRAMA,")
            .Write("PROGRAMA_TANDA,")
            .Write("H_INICIO,")
            .Write("H_FIN,")
            .Write("RAT,")
            .Write("SHR,")
            .Write("AFF,")
            .Write("RCH,")
            .Write("RAT_M,")
            .WriteLine("FID)")
            .WriteLine("BEGINDATA")
        End With
    End Sub

    Private Sub EscribeHeaderSQLLoader_Tanda(ByVal FileTanda As StreamWriter)
        With FileTanda
            .WriteLine("OPTIONS (DIRECT=TRUE)")
            .WriteLine("UNRECOVERABLE")
            .WriteLine("Load Data")
            .WriteLine("INFILE *")
            .WriteLine("APPEND")
            .WriteLine("INTO TABLE QUETOOL.TANDAS_TVA")
            .WriteLine("FIELDS TERMINATED BY "";""")
            .WriteLine("TRAILING NULLCOLS")
            .Write("(ID_TANDA,")
            .Write("ID_MEDIO,")
            .Write("ID_SOPORTE,")
            .Write("ID_PLAZA,")
            .Write("ID_TARGET,")
            .Write("F_PROGRAMA DATE ""DD/MM/YY"",")
            .Write("H_INICIO,")
            .WriteLine("H_FIN")
            .WriteLine("BEGINDATA")
        End With
    End Sub

    Private Sub GetTargetsFechasAudiencia(ByVal f As String, ByRef arTargets() As Integer, ByRef arFechas() As String)
        ' Abro el archivo antes de procesarlo, para saber cuales son las fechas que contiene adentro.
        ' Me sirve para poder verificar la audiencia procesada.
        Dim linea
        Dim cntBytes As Long
        Dim arlinea() As String
        Dim i As Integer
        Dim j As Integer
        Dim psr As StreamReader
        Dim salir As Boolean
        'Dim antfecha As Date
        Dim oTarget As New Targets_telereport
        Dim Cadena As String
        Dim antCadena As String

        Try
            psr = File.OpenText(f)
            linea = psr.ReadLine()

            ' Leo la primer linea del archivo, en el encabezado tiene la lista de todos los targets
            ' que se van a procesar. Busco-inserto estos targets en la tabla y me quedo con los Id's

            linea = Replace(linea, """", "", 1) ' saco las comillas
            arlinea = Split(linea, ";")
            i = 0
            j = 0
            i = cProgramaBT.cccntDatos + (cVariablesTarget.ccCntDatos * j)
            While i < arlinea.Length - 1
                ReDim Preserve arTargets(j)
                oTarget.Descripcion = arlinea(i)
                oTarget.BuscarAgregar()
                arTargets(j) = oTarget.Id_target
                j = j + 1
                i = cProgramaBT.cccntDatos + (cVariablesTarget.ccCntDatos * j)
            End While
            oTarget = Nothing

            linea = NextLinea(psr, cntBytes)
            arlinea = Split(linea, ";")
            '''''''''''''''''''''''''''''''''''''''''
            i = 0
            salir = False
            antCadena = arlinea(cProgramaBT.ccCadena)
            Cadena = antCadena
            While Not linea Is Nothing And Cadena = antCadena
                InsertaFechas(arFechas, arlinea(cProgramaBT.ccFecha))
                i = i + 1
                linea = NextLinea(psr, cntBytes)
                If linea <> Nothing Then
                    arlinea = Split(linea, ";")
                    antCadena = arlinea(cProgramaBT.ccCadena)
                End If
            End While
            psr.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InsertaFechas(ByRef par() As String, ByVal pfecha As String)
        Dim i As Integer

        If Not par(0) Is Nothing Then ' para el primero
            i = Array.BinarySearch(par, pfecha)
            If i < 0 Then
                i = UBound(par) + 1
                ReDim Preserve par(i)
                par(i) = pfecha
                Array.Sort(par)
            End If
        Else
            par(0) = pfecha
        End If
    End Sub
    Private Function NextLinea(ByVal psr As StreamReader, ByRef pcntBytes As Long) As String
        ' Pasa de linea a linea, se mueve solo por las que contienen datos
        Dim linea As String
        Dim salir As Boolean

        pcntBytes = 0
        linea = psr.ReadLine()
        pcntBytes = Len(linea)
        salir = IsNumeric(Mid(linea, 1, 1))
        Do While (Not linea Is Nothing) And Not salir
            If IsNumeric(Mid(linea, 1, 1)) Then
                salir = True
            Else
                linea = psr.ReadLine()
                pcntBytes = pcntBytes + Len(linea)
            End If
        Loop
        linea = Replace(linea, """", "", 1) ' saco las comillas
        NextLinea = linea
    End Function

    Private Sub cmdAbrirDlg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbrirDlg.Click
        ' Busco el archivo de audiencia
        Dim OpenDLG As New OpenFileDialog

        Try
            OpenDLG.InitialDirectory = GetSetting(Application.ProductName, "Parametros", "DirAudiencia", "c:\")
            OpenDLG.Filter = "Archivos dbf (*.dbf)|*.dbs|Todos los archivos (*.*)|*.*"
            OpenDLG.FilterIndex = 2
            OpenDLG.RestoreDirectory = True

            If OpenDLG.ShowDialog() = DialogResult.OK Then
                lblArchivoAudiencia.Text = OpenDLG.FileName
                SaveSetting(Application.ProductName, "Parametros", "DirAudiencia", Path.GetDirectoryName(OpenDLG.FileName))
            Else
                lblArchivoAudiencia.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAudiencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAudiencia.Click
        'Selecciona el nombre del archivo de audiencia para el sql loader
        Dim SaveDLG As New SaveFileDialog

        SaveDLG.InitialDirectory = "c:\"
        SaveDLG.Filter = "Todos los archivos (*.ctl)|*.ctl"
        SaveDLG.FilterIndex = 2
        SaveDLG.RestoreDirectory = True

        If SaveDLG.ShowDialog() = DialogResult.OK Then
            txtAudienciaSalida.Text = SaveDLG.FileName
        Else
            txtAudienciaSalida.Text = ""
        End If
    End Sub

    Private Sub cmdTandas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTandas.Click
        'Selecciona el nombre del archivo de Tandas para el sql loader
        Dim SaveDLG As New SaveFileDialog

        SaveDLG.InitialDirectory = "c:\"
        SaveDLG.Filter = "Todos los archivos (*.ctl)|*.ctl"
        SaveDLG.FilterIndex = 2
        SaveDLG.RestoreDirectory = True

        If SaveDLG.ShowDialog() = DialogResult.OK Then
            txtTandasTVA.Text = SaveDLG.FileName
        Else
            txtTandasTVA.Text = ""
        End If
    End Sub

    Private Sub chkLoader_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLoader.CheckedChanged
        If chkLoader.Checked Then
            fraArcSalida.Enabled = True
        Else
            fraArcSalida.Enabled = False
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim d As DataTable
        Dim p As New Programas
        Dim s As New Spots
        Dim t As New Tarifas_tv

        d = p.TraerTodos

        lblEstado.Text = "Relacionando programas con tarifas"
        pgbProgreso.Value = 0
        pgbProgreso.Maximum = d.Rows.Count
        For Each row As DataRow In d.Rows
            Application.DoEvents()
            GeneraRelacionProgramaTarifas(row("id_Programa"), 1, row("Id_Medio"), row("Id_Soporte"), row("Descripcion"), "L", Now)
            pgbProgreso.Increment(1)
        Next

        d = s.TraerPrgSinRelacion
        pgbProgreso.Value = 0
        pgbProgreso.Maximum = d.Rows.Count
        lblEstado.Text = "Relacionando programas en spots"
        For Each row As DataRow In d.Rows
            Application.DoEvents()
            t.Id_tarifa_tv = row("Id_tarifa_tv")
            t.BuscarPorID()
            If t.Id_programa <> 0 Then
                s.Id_spot = row("id_spot")
                s.BuscarPorID()
                s.Id_programa = t.Id_programa
                s.Modificar()
            End If
            pgbProgreso.Increment(1)
        Next
    End Sub

    Private Sub frmCargarAudienciaTVA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class ccProgramaBT
    Const TANDA = "T"
    Const PROGRAMA = "P"
    Const PLAZA = 1

    Const ccID = 0
    Public Const ccFecha = 1 ' lo necesito publicos para optimizar los accesos a la base
    Public Const ccCadena = 2 ' Idem
    Public Const ccNombre = 3 ' Idem
    Const ccHora = 4
    Const ccGenero = 5
    Const ccTipo = 6
    Const ccNivel = 7
    Const ccDur = 8
    Const ccDiaSem = 9
    Const ccCodGen = 10
    Const ccTDur = 11
    Const ccFinal = 12
    Const ccDs = 13
    Const ccBsh = 14
    Const ccSat = 15

    Public Const cccntDatos = 13 ' cantidad de datos que fijos (cantidad de variables)

    Dim m_Id As Integer
    Dim mFecha As String
    Dim mCadena As String
    Dim mNombre As String
    Dim mHora As String
    Dim mGenero As String
    Dim mTipo As String
    Dim mNivel As Integer
    Dim mDur As String
    Dim mDiaSem As String
    Dim mCodGen As String
    Dim mTDur As String
    Dim mFinal As String
    Dim mDs As String
    Dim mBsh As String
    Dim mSat As String

    Dim marTarget() As Integer ' array con los ID de los targets que se van a utilizar
    Dim varTargetBloque() As cVariablesTarget
    Dim varTargetTanda() As cVariablesTarget

    Dim mId_Audiencia As Int64
    Dim mId_Medio As Integer
    Dim mId_Soporte As Integer
    Dim mId_Programa As Integer
    Dim mId_Plaza As Integer

    Dim mFileTanda As StreamWriter
    Dim mId_Tanda As Int64 ' Contador de id's para generar el sql loader
    Dim mFileAudi As StreamWriter

    Dim mHorainiPrograma As String
    Dim mHoraFinPrograma As String

#Region "Propiedades"

    Public Property Id_Audiencia()
        Get
            Id_Audiencia = mId_Audiencia
        End Get
        Set(ByVal Value)
            mId_Audiencia = Value
        End Set
    End Property

    Public Property Id()
        Get
            Id = m_Id
        End Get
        Set(ByVal Value)
            m_Id = Value
        End Set
    End Property
    Public Property Fecha()
        Get
            Fecha = mFecha
        End Get
        Set(ByVal Value)
            mFecha = Value
        End Set
    End Property
    Public Property Cadena()
        Get
            Cadena = mCadena
        End Get
        Set(ByVal Value)
            mCadena = Value
        End Set
    End Property
    Public Property Nombre()
        Get
            Nombre = mNombre
        End Get
        Set(ByVal Value)
            mNombre = Value
        End Set
    End Property
    Public Property Hora()
        Get
            Hora = mHora
        End Get
        Set(ByVal Value)
            mHora = Value
        End Set
    End Property
    Public Property Genero()
        Get
            Genero = mGenero
        End Get
        Set(ByVal Value)
            mGenero = Value
        End Set
    End Property
    Public Property Tipo()
        Get
            Tipo = mTipo
        End Get
        Set(ByVal Value)
            mTipo = Value
        End Set
    End Property
    Public Property Nivel()
        Get
            Nivel = mNivel
        End Get
        Set(ByVal Value)
            mNivel = Value
        End Set
    End Property
    Public Property Dur()
        Get
            Dur = mDur
        End Get
        Set(ByVal Value)
            mDur = Value
        End Set
    End Property
    Public Property DiaSem()
        Get
            DiaSem = mDiaSem
        End Get
        Set(ByVal Value)
            mDiaSem = Value
        End Set
    End Property
    Public Property CodGen()
        Get
            CodGen = mCodGen
        End Get
        Set(ByVal Value)
            mCodGen = Value
        End Set
    End Property
    Public Property TDur()
        Get
            TDur = mTDur
        End Get
        Set(ByVal Value)
            mTDur = Value
        End Set
    End Property
    Public Property Final()
        Get
            Final = mFinal
        End Get
        Set(ByVal Value)
            mFinal = Value
        End Set
    End Property
    Public Property Ds()
        Get
            Ds = mDs
        End Get
        Set(ByVal Value)
            mDs = Value
        End Set
    End Property
    Public Property Bsh()
        Get
            Bsh = mBsh
        End Get
        Set(ByVal Value)
            mBsh = Value
        End Set
    End Property
    Public Property Sat()
        Get
            Sat = mSat
        End Get
        Set(ByVal Value)
            mSat = Value
        End Set
    End Property
    Property arTarget()
        Get
            arTarget = marTarget
        End Get
        Set(ByVal Value)
            marTarget = Value
        End Set
    End Property
    Public Property Id_Programa()
        Get
            Id_Programa = mId_Programa
        End Get
        Set(ByVal Value)
            mId_Programa = Value
        End Set
    End Property
    Public Property Id_Medio()
        Get
            Id_Medio = mId_Medio
        End Get
        Set(ByVal Value)
            mId_Medio = Value
        End Set
    End Property
    Public Property Id_Soporte()
        Get
            Id_Soporte = mId_Soporte
        End Get
        Set(ByVal Value)
            mId_Soporte = Value
        End Set
    End Property
    Public Property Id_Plaza()
        Get
            Id_Plaza = mId_Plaza
        End Get
        Set(ByVal Value)
            mId_Plaza = Value
        End Set
    End Property

#End Region

    ' al create del objeto lo creo con los archivos de texto correspondientes para poder grabar lo parseado
    Sub New(ByRef pFileAudi As StreamWriter, ByRef pFileTanda As StreamWriter)
        Dim oA_TV As New Audiencia_Tva
        Dim ds As DataSet
        Dim oT_TVA As New Tandas_tva

        ds = oA_TV.EjecutarSQL("select max(id_audiencia) from AUDIENCIA_TVA")
        mId_Audiencia = IIf(IsDBNull(ds.Tables(0).Rows(0)(0)), 0, ds.Tables(0).Rows(0)(0)) + 1
        ds.Dispose()

        ds = oT_TVA.EjecutarSQL("select max(id_tanda) from TANDAS_TVA")
        mId_Tanda = IIf(IsDBNull(ds.Tables(0).Rows(0)(0)), 0, ds.Tables(0).Rows(0)(0)) + 1

        Id_Programa = -1
        Id_Soporte = -1
        mFileAudi = pFileAudi
        mFileTanda = pFileTanda
    End Sub

    Sub New()
        Dim oA_TV As New Audiencia_Tva
        Dim ds As DataSet
        Dim oT_TVA As New Tandas_tva

        ds = oA_TV.EjecutarSQL("select max(id_audiencia) from AUDIENCIA_TVA")
        mId_Audiencia = IIf(IsDBNull(ds.Tables(0).Rows(0)(0)), 0, ds.Tables(0).Rows(0)(0)) + 1
        ds.Dispose()

        ds = oT_TVA.EjecutarSQL("select max(id_tanda) from TANDAS_TVA")
        mId_Tanda = IIf(IsDBNull(ds.Tables(0).Rows(0)(0)), 0, ds.Tables(0).Rows(0)(0)) + 1

        Id_Programa = -1
        Id_Soporte = -1
    End Sub
    Public Sub Cargar(ByVal pLinea As String)
        ' cargo la linea que me pasan por parametro. Tengo 2 tipos de lineas, las de bloque y las de tandas.
        ' las trato por separado ya que las de bloque me vienen calculadas y las de tandas las debo calcular
        ' aparte genero las tandas por separado para cargar la tabla Tandas_TVA. Para que sea mas eficiente
        ' evito que cada vez que cargo una linea tenga que acceder a la base para buscar datos que ya estan cargados
        Dim ar()
        Dim i As Integer
        Dim oVariableTarget As cVariablesTarget
        Dim hayTarget As Boolean
        Dim oPrograma As New Programas
        Dim oSoporte As New Soportes_sigeme_telereport
        Dim oTandas_TVA As New Tandas_tva

        Try
            ar = Split(pLinea, ";")
            If IsNumeric(ar(ccID)) Then ' si no es numerico no es una linea con datos
                If (ar(ccTipo) = PROGRAMA And ar(ccNivel) = 2) Then ' si es programa no lo cargo de nuevo, ya tengo el % no necesito el nivel 2
                    Exit Sub
                End If
                If mCadena <> ar(ccCadena) Then ' no lo conozco, lo busco
                    oSoporte.Id_soporte_telereport = ar(ccCadena)
                    oSoporte.BuscarPorDescripcion()
                    mId_Soporte = oSoporte.Id_soporte
                End If
                If (mNombre <> Listas.GetNombreSinBarras(ar(ccNombre))) Or mId_Programa = -1 Then ' no lo conozco, lo busco
                    oSoporte.Id_soporte_telereport = ar(ccCadena)
                    oSoporte.BuscarPorDescripcion()
                    mId_Medio = oSoporte.Id_medio
                    oPrograma.Id_medio = mId_Medio
                    oPrograma.Id_programa_monitor = " "
                    oPrograma.Id_soporte = mId_Soporte
                    oPrograma.Descripcion = Listas.GetNombreSinBarras(ar(ccNombre))
                    oPrograma.BuscarAgregar()
                    mId_Programa = oPrograma.Id_programa
                    ReDim varTargetTanda(marTarget.Length)
                    ReDim varTargetBloque(marTarget.Length)
                    For i = 0 To marTarget.Length
                        If Not varTargetBloque(i) Is Nothing Then
                            varTargetBloque(i) = Nothing
                        End If
                        If Not varTargetTanda(i) Is Nothing Then
                            varTargetTanda(i) = Nothing
                        End If
                        varTargetBloque(i) = New cVariablesTarget
                        varTargetTanda(i) = New cVariablesTarget
                    Next
                    mHorainiPrograma = ar(ccHora)
                    mTDur = Replace(ar(ccTDur), ":", "").PadLeft(4, "0")
                    mHoraFinPrograma = Listas.SumarHoras(mHorainiPrograma, ar(ccTDur), "mm:ss")
                End If

                m_Id = ar(ccID)
                mId_Plaza = PLAZA
                mFecha = ar(ccFecha)
                mCadena = ar(ccCadena)
                Nombre = Listas.GetNombreSinBarras(ar(ccNombre))
                mHora = ar(ccHora)
                mGenero = ar(ccGenero)
                mTipo = ar(ccTipo)
                mNivel = ar(ccNivel)
                mDur = Replace(ar(ccDur), ":", "").PadLeft(4, "0")
                mDiaSem = ar(ccDiaSem)
                mCodGen = ar(ccCodGen)
                mTDur = Replace(ar(ccDur), ":", "").PadLeft(4, "0")
                mFinal = Listas.SumarHoras(mHora, ar(ccTDur), "mm:ss")
                'mDs = ar(ccDs)
                'mBsh = ar(ccBsh)
                'mSat = ar(ccSat)

                If ar(ccTipo) = PROGRAMA Then
                    i = 0
                    hayTarget = True
                    While hayTarget
                        If Not varTargetBloque(i).CargarBloque(ar, i) Then
                            hayTarget = False
                            If i = 0 Then
                                varTargetBloque = Nothing
                            End If
                        End If
                        i = i + 1
                    End While
                Else
                    i = 0
                    hayTarget = True
                    While hayTarget
                        If Not varTargetTanda(i).CargarTanda(ar, cccntDatos, i, Listas.ConvMin2Seg(ar(ccTDur), "mm:ss")) Then
                            hayTarget = False
                        Else
                            oTandas_TVA.Id_tanda = mId_Tanda
                            oTandas_TVA.Id_medio = mId_Medio
                            oTandas_TVA.Id_soporte = mId_Soporte
                            oTandas_TVA.Id_plaza = mId_Plaza
                            oTandas_TVA.Id_target = marTarget(i)
                            oTandas_TVA.F_programa = CDate(Mid(ar(ccFecha), 5, 2) & "/" & Mid(ar(ccFecha), 3, 2) & "/" & Mid(ar(ccFecha), 1, 2))
                            oTandas_TVA.H_inicio = Replace(mHora, ":", "").Substring(0, 4) ' le saco los ":" y le lo dejo mmss 
                            oTandas_TVA.H_fin = Replace(mFinal, ":", "").Substring(0, 4)
                            If mFileTanda Is Nothing Then
                                oTandas_TVA.Agregar()
                            Else
                                oTandas_TVA.AgregarTXT(mFileTanda)
                            End If
                            mId_Tanda = mId_Tanda + 1
                        End If
                        i = i + 1
                    End While
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LimpiaTargets()
        ' vacio los array de targets
        Dim i As Integer

        For i = 0 To marTarget.Length - 1
            varTargetBloque(i).Limpiar()
            varTargetTanda(i).Limpiar()
        Next i
    End Sub

    Public Sub LiberaTargets()
        ' Destruyo todos objetos target
        Dim i As Integer

        For i = 0 To marTarget.Length - 1
            varTargetBloque(i) = Nothing
            If Not varTargetTanda Is Nothing Then ' puede ser que el programa no tenga tanda
                varTargetTanda(i) = Nothing
            End If
        Next i
        varTargetBloque = Nothing
        varTargetTanda = Nothing
    End Sub

    Public Function InsertaTXT(ByRef pFileAudi As StreamWriter, ByVal oATV As Audiencia_Tva, ByVal j As Integer) As Boolean
        ' inserto una linea nueva en el TXT de audiencia, si es un bloque lo calculo antes de insertarlo.
        Dim ok As Boolean
        Dim i As Integer

        Try
            For i = 0 To marTarget.Length - 1 ' para cada target
                If Not pFileAudi Is Nothing Then ' estoy cargando para SQL Loader
                    pFileAudi.Write(mId_Audiencia & ";" & mId_Plaza & ";" & marTarget(i) & ";" & Mid(mFecha, 5, 2) & "/" & Mid(mFecha, 3, 2) & "/" & Mid(mFecha, 1, 2) & ";" & mId_Medio & ";" & mId_Soporte & ";" & mId_Programa & ";" & PROGRAMA & ";" & Mid(Replace(mHorainiPrograma, ":", ""), 1, 4) & ";" & Mid(Replace(mHoraFinPrograma, ":", ""), 1, 4) & ";")
                    With varTargetBloque(i)
                        pFileAudi.WriteLine(.rat & ";" & .shr & ";" & .aff & ";" & .rch & ";" & .rat_m & ";" & .fid)
                    End With
                    mId_Audiencia = mId_Audiencia + 1

                    pFileAudi.Write(mId_Audiencia & ";" & mId_Plaza & ";" & marTarget(i) & ";" & Mid(mFecha, 5, 2) & "/" & Mid(mFecha, 3, 2) & "/" & Mid(mFecha, 1, 2) & ";" & mId_Medio & ";" & mId_Soporte & ";" & mId_Programa & ";" & TANDA & ";" & Mid(Replace(mHorainiPrograma, ":", ""), 1, 4) & ";" & Mid(Replace(mHoraFinPrograma, ":", ""), 1, 4) & ";")
                    With varTargetTanda(i)
                        If .DurSeg > 0 Then
                            pFileAudi.WriteLine(Format(.rat / .DurSeg, "##,##0.0000") & ";" & Format(.shr / .DurSeg, "##,##0.0000") & ";" & Format(.aff / .DurSeg, "##,##0.0000") & ";" & Format(.rch / .DurSeg, "##,##0.0000") & ";" & Format(.rat_m / .DurSeg, "##,##0.0000") & ";" & Format(.fid / .DurSeg, "##,##0.0000"))
                            'Else
                            '    pFileAudi.WriteLine("0;0;0;0;0;0")
                        End If
                    End With
                    mId_Audiencia = mId_Audiencia + 1
                Else
                    With oATV
                        .Id_Audiencia = mId_Audiencia
                        .Id_Plaza = 1
                        .Id_Target = marTarget(i)
                        .F_Programa = CDate(Mid(mFecha, 5, 2) & "/" & Mid(mFecha, 3, 2) & "/" & Mid(mFecha, 1, 2))
                        .Id_Medio = mId_Medio
                        .Id_Soporte = mId_Soporte
                        .Id_Programa = mId_Programa
                        .Programa_Tanda = PROGRAMA
                        .H_Inicio = Mid(Replace(mHorainiPrograma, ":", ""), 1, 4)
                        .H_Fin = Mid(Replace(mHoraFinPrograma, ":", ""), 1, 4)
                        .Rat = varTargetBloque(i).rat
                        .Shr = varTargetBloque(i).shr
                        .Aff = varTargetBloque(i).aff
                        .Rch = varTargetBloque(i).rch
                        .Rat_m = varTargetBloque(i).rat_m
                        .Fid = varTargetBloque(i).fid
                        .Agregar()
                    End With
                    mId_Audiencia = mId_Audiencia + 1
                    If TieneTanda() Then
                        With oATV
                            .Id_Audiencia = mId_Audiencia
                            .Id_Plaza = 1
                            .Id_Target = marTarget(i)
                            .F_Programa = CDate(Mid(mFecha, 5, 2) & "/" & Mid(mFecha, 3, 2) & "/" & Mid(mFecha, 1, 2))
                            .Id_Medio = mId_Medio
                            .Id_Soporte = mId_Soporte
                            .Id_Programa = mId_Programa
                            .Programa_Tanda = TANDA
                            .H_Inicio = Mid(Replace(mHorainiPrograma, ":", ""), 1, 4)
                            .H_Fin = Mid(Replace(mHoraFinPrograma, ":", ""), 1, 4)
                            .Rat = IIf(varTargetTanda(i).DurSeg <> 0, varTargetTanda(i).rat / varTargetTanda(i).DurSeg, 0)
                            .Shr = IIf(varTargetTanda(i).DurSeg <> 0, varTargetTanda(i).shr / varTargetTanda(i).DurSeg, 0)
                            .Aff = IIf(varTargetTanda(i).DurSeg <> 0, varTargetTanda(i).aff / varTargetTanda(i).DurSeg, 0)
                            .Rch = IIf(varTargetTanda(i).DurSeg <> 0, varTargetTanda(i).rch / varTargetTanda(i).DurSeg, 0)
                            .Rat_m = IIf(varTargetTanda(i).DurSeg <> 0, varTargetTanda(i).rat_m / varTargetTanda(i).DurSeg, 0)
                            .Fid = IIf(varTargetTanda(i).DurSeg <> 0, varTargetTanda(i).fid / varTargetTanda(i).DurSeg, 0)
                            .Agregar()
                        End With
                        mId_Audiencia = mId_Audiencia + 1
                    End If
                End If

            Next i
            InsertaTXT = ok
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function TieneTanda() As Boolean
        Dim i As Integer
        Dim dur As Long

        For i = 0 To marTarget.Length - 1 ' para cada target
            dur = varTargetTanda(i).DurSeg()
        Next

        TieneTanda = (dur > 0)

    End Function
End Class

Public Class ccVariablesTarget

    Const ccrat = 0
    Const ccshr = 1
    Const ccrch = 2
    Const ccfid = 3
    Const ccaff = 4
    Const ccrat_m = 5

    Const ccatv = 0
    Const cctvr = 2
    Const ccats = 5
    Const ccadh = 8
    Const ccalf = 9
    Const ccbet = 10
    Const ccrsh = 11
    Const ccrch_m = 13
    Const cctvr_m = 14
    Const ccatt = 15
    Const ccgrp = 16

    Public Const ccCntDatos = 7

    Dim mrat As Single
    Dim matv As Single
    Dim mtvr As Single
    Dim mshr As Single
    Dim mrch As Single
    Dim mats As Single
    Dim mfid As Single
    Dim maff As Single
    Dim madh As Single
    Dim malf As Single
    Dim mbet As Single
    Dim mrsh As Single
    Dim mrat_m As Single
    Dim mrch_m As Single
    Dim mtvr_m As Single
    Dim matt As Single
    Dim mgrp As Single

    Dim mDurSeg As Integer ' acumula los tiempos para despues poder calcular el % de cada variable en segundos

#Region "Propiedades"
    Property rat()
        Get
            rat = mrat
        End Get
        Set(ByVal Value)
            mrat = Value
        End Set
    End Property
    Property atv()
        Get
            atv = matv
        End Get
        Set(ByVal Value)
            matv = Value
        End Set
    End Property
    Property tvr()
        Get
            tvr = mtvr
        End Get
        Set(ByVal Value)
            mtvr = Value
        End Set
    End Property
    Property shr()
        Get
            shr = mshr
        End Get
        Set(ByVal Value)
            mshr = Value
        End Set
    End Property

    Property rch()
        Get
            rch = mrch
        End Get
        Set(ByVal Value)
            mrch = Value
        End Set
    End Property

    Property ats()
        Get
            ats = mats
        End Get
        Set(ByVal Value)
            mats = Value
        End Set
    End Property
    Property fid()
        Get
            fid = mfid
        End Get
        Set(ByVal Value)
            mfid = Value
        End Set
    End Property
    Property aff()
        Get
            aff = maff
        End Get
        Set(ByVal Value)
            maff = Value
        End Set
    End Property
    Property adh()
        Get
            adh = madh
        End Get
        Set(ByVal Value)
            madh = Value
        End Set
    End Property
    Property alf()
        Get
            alf = malf
        End Get
        Set(ByVal Value)
            malf = Value
        End Set
    End Property
    Property bet()
        Get
            bet = mbet
        End Get
        Set(ByVal Value)
            mbet = Value
        End Set
    End Property
    Property rsh()
        Get
            rsh = mrsh
        End Get
        Set(ByVal Value)
            mrsh = Value
        End Set
    End Property
    Property rat_m()
        Get
            rat_m = mrat_m
        End Get
        Set(ByVal Value)
            mrat_m = Value
        End Set
    End Property
    Property rch_m()
        Get
            rch_m = mrch_m
        End Get
        Set(ByVal Value)
            mrch_m = Value
        End Set
    End Property
    Property tvr_m()
        Get
            tvr_m = mtvr_m
        End Get
        Set(ByVal Value)
            mtvr_m = Value
        End Set
    End Property
    Property att()
        Get
            att = matt
        End Get
        Set(ByVal Value)
            matt = Value
        End Set
    End Property
    Property grp()
        Get
            grp = mgrp
        End Get
        Set(ByVal Value)
            mgrp = Value
        End Set
    End Property

    Property DurSeg()
        Get
            DurSeg = mDurSeg
        End Get
        Set(ByVal Value)
            mDurSeg = Value
        End Set
    End Property
#End Region

    Sub New()
        Limpiar()
    End Sub

    Public Function CargarBloque(ByVal par() As Object, ByVal pnTarget As Integer) As Boolean
        ' cargo del vector par() el sector de datos correspondiente al target i. 
        Dim n As Integer

        n = cProgramaBT.cccntDatos + (ccCntDatos * pnTarget)
        If UBound(par) > n Then
            ' Donde comienza el Target es la cantidad de datos de un prog + el target que estoy examinando
            'mrat = IIf(IsNumeric(par(ccrat + n)), Replace(par(ccrat + n), ",", "."), 0)
            'mshr = IIf(IsNumeric(par(ccshr + n)), Replace(par(ccshr + n), ",", "."), 0)
            'mrch = IIf(IsNumeric(par(ccrch + n)), Replace(par(ccrch + n), ",", "."), 0)
            'mfid = IIf(IsNumeric(par(ccfid + n)), Replace(par(ccfid + n), ",", "."), 0)
            'maff = IIf(IsNumeric(par(ccaff + n)), Replace(par(ccaff + n), ",", "."), 0)
            'mrat_m = IIf(IsNumeric(par(ccrat_m + n)), Replace(par(ccrat_m + n), ",", "."), 0)
            mrat = IIf(IsNumeric(par(ccrat + n)), par(ccrat + n), 0)
            mshr = IIf(IsNumeric(par(ccshr + n)), par(ccshr + n), 0)
            mrch = IIf(IsNumeric(par(ccrch + n)), par(ccrch + n), 0)
            mfid = IIf(IsNumeric(par(ccfid + n)), par(ccfid + n), 0)
            maff = IIf(IsNumeric(par(ccaff + n)), par(ccaff + n), 0)
            mrat_m = IIf(IsNumeric(par(ccrat_m + n)), par(ccrat_m + n), 0)

            'matv = par(ccatv + n)
            'mtvr = par(cctvr + n)            'mats = par(ccats + n)
            'madh = par(ccadh + n)
            'malf = par(ccalf + n)
            'mbet = par(ccbet + n)
            'mrsh = par(ccrsh + n)            'mrch_m = par(ccrch_m + n)
            'mtvr_m = par(cctvr_m + n)
            'matt = par(ccatt + n)
            'mgrp = par(ccgrp + n)
            CargarBloque = True
        Else
            CargarBloque = False
        End If
    End Function

    Public Function CargarTanda(ByVal par() As Object, ByVal pmntDatos As Integer, ByVal pnTarget As Integer, ByVal pnDur As Integer) As Boolean
        ' cargo del vector par() el sector de datos correspondiente al target i. 
        Dim n As Integer

        mDurSeg = mDurSeg + pnDur
        n = cProgramaBT.cccntDatos + (ccCntDatos * pnTarget)
        If UBound(par) > n Then
            ' Donde comienza el Target es la cantidad de datos de un prog + el target que estoy examinando
            mrat = mrat + IIf(IsNumeric(par(ccrat + n)), par(ccrat + n), 0) * pnDur
            mshr = mshr + IIf(IsNumeric(par(ccshr + n)), par(ccshr + n), 0) * pnDur
            mrch = mrch + IIf(IsNumeric(par(ccrch + n)), par(ccrch + n), 0) * pnDur
            mfid = mfid + IIf(IsNumeric(par(ccfid + n)), par(ccfid + n), 0) * pnDur
            maff = maff + IIf(IsNumeric(par(ccaff + n)), par(ccaff + n), 0) * pnDur
            mrat_m = mrat_m + IIf(IsNumeric(par(ccrat_m + n)), par(ccrat_m + n), 0) * pnDur
            'mrat = mrat + IIf(IsNumeric(par(ccrat + n)), Replace(par(ccrat + n), ",", "."), 0) * pnDur
            'mshr = mshr + IIf(IsNumeric(par(ccshr + n)), Replace(par(ccshr + n), ",", "."), 0) * pnDur
            'mrch = mrch + IIf(IsNumeric(par(ccrch + n)), Replace(par(ccrch + n), ",", "."), 0) * pnDur
            'mfid = mfid + IIf(IsNumeric(par(ccfid + n)), Replace(par(ccfid + n), ",", "."), 0) * pnDur
            'maff = maff + IIf(IsNumeric(par(ccaff + n)), Replace(par(ccaff + n), ",", "."), 0) * pnDur
            'mrat_m = mrat_m + IIf(IsNumeric(par(ccrat_m + n)), Replace(par(ccrat_m + n), ",", "."), 0) * pnDur

            'mats = mats + IIf(IsNumeric(par(ccats + n)), par(ccats + n), 0) * pnDur
            'madh = madh + IIf(IsNumeric(par(ccadh + n)), par(ccadh + n), 0) * pnDur
            'malf = malf + IIf(IsNumeric(par(ccalf + n)), par(ccalf + n), 0) * pnDur
            'mbet = mbet + IIf(IsNumeric(par(ccbet + n)), par(ccbet + n), 0) * pnDur
            'mrsh = mrsh + IIf(IsNumeric(par(ccrsh + n)), par(ccrsh + n), 0) * pnDur
            'matv = matv + IIf(IsNumeric(par(ccatv + n)), par(ccatv + n), 0) * pnDur
            'mtvr = mtvr + IIf(IsNumeric(par(cctvr + n)), par(cctvr + n), 0) * pnDur
            'mrch_m = mrch_m + IIf(IsNumeric(par(ccrch_m + n)), par(ccrch_m + n), 0) * pnDur
            'mtvr_m = mtvr_m + IIf(IsNumeric(par(cctvr_m + n)), par(cctvr_m + n), 0) * pnDur
            'matt = matt + IIf(IsNumeric(par(ccatt + n)), par(ccatt + n), 0) * pnDur
            'mgrp = mgrp + IIf(IsNumeric(par(ccgrp + n)), par(ccgrp + n), 0) * pnDur
            CargarTanda = True
        Else
            CargarTanda = False
        End If
    End Function

    Public Sub Limpiar()
        mrat = 0
        matv = 0
        mtvr = 0
        mshr = 0
        mrch = 0
        mats = 0
        mfid = 0
        maff = 0
        madh = 0
        malf = 0
        mbet = 0
        mrsh = 0
        mrat_m = 0
        mrch_m = 0
        mtvr_m = 0
        matt = 0
        mgrp = 0

        mDurSeg = 0
    End Sub
End Class
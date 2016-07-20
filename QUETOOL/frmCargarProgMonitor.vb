Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms.CommonDialog
Imports System.IO
Imports System.DateTime

Public Class frmCargaProgMonitor

    Inherits System.Windows.Forms.Form
    Dim Cancelar As Boolean

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblArchivoMonitor As System.Windows.Forms.Label
    Friend WithEvents cmdAbrirDlg As System.Windows.Forms.Button
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents pgbProceso As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAbrirDlg = New System.Windows.Forms.Button
        Me.lblArchivoMonitor = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdEjecutar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.pgbProceso = New System.Windows.Forms.ProgressBar
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAbrirDlg)
        Me.GroupBox1.Controls.Add(Me.lblArchivoMonitor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Archivo"
        '
        'cmdAbrirDlg
        '
        Me.cmdAbrirDlg.Location = New System.Drawing.Point(552, 24)
        Me.cmdAbrirDlg.Name = "cmdAbrirDlg"
        Me.cmdAbrirDlg.Size = New System.Drawing.Size(20, 20)
        Me.cmdAbrirDlg.TabIndex = 4
        Me.cmdAbrirDlg.Text = "..."
        '
        'lblArchivoMonitor
        '
        Me.lblArchivoMonitor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblArchivoMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArchivoMonitor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblArchivoMonitor.Location = New System.Drawing.Point(68, 24)
        Me.lblArchivoMonitor.Name = "lblArchivoMonitor"
        Me.lblArchivoMonitor.Size = New System.Drawing.Size(480, 20)
        Me.lblArchivoMonitor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Monitor"
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(393, 89)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(96, 24)
        Me.cmdEjecutar.TabIndex = 2
        Me.cmdEjecutar.Text = "Ejecutar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(497, 89)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 24)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'pgbProceso
        '
        Me.pgbProceso.Location = New System.Drawing.Point(8, 73)
        Me.pgbProceso.Name = "pgbProceso"
        Me.pgbProceso.Size = New System.Drawing.Size(584, 8)
        Me.pgbProceso.TabIndex = 6
        '
        'frmCargaProgMonitor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 117)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbProceso)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCargaProgMonitor"
        Me.Text = "Carga de Programas"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAbrirDlg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbrirDlg.Click
        Dim OpenDLG As New OpenFileDialog

        OpenDLG.InitialDirectory = "c:\"
        OpenDLG.Filter = "Archivos dbf (*.dbf)|*.dbs|Todos los archivos (*.*)|*.*"
        OpenDLG.FilterIndex = 2
        OpenDLG.RestoreDirectory = True

        If OpenDLG.ShowDialog() = DialogResult.OK Then
            lblArchivoMonitor.Text = OpenDLG.FileName
        Else
            lblArchivoMonitor.Text = ""
        End If
    End Sub

    Private Sub cmdEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEjecutar.Click
        Dim cn As New ConnectToVFP
        Dim TablaMonitor As DataSet
        Dim Registro As DataRow
        Dim cntReg As Integer
        Dim oProgramas_Monitor As New Programas_Monitor
        Dim oTarifas_TV As New Tarifas_tv
        Dim oProgramas As New Programas
        Dim oSoportes_Sigeme_Monitor As New Soportes_sigeme_monitor
        Dim aux As String
        Dim i As Long
        Dim ds As New DataSet
        Dim ret As Long

        If lblArchivoMonitor.Text = "" Then
            Exit Sub
        End If

        cmdEjecutar.Enabled = False
        pgbProceso.Value = 0
        Cancelar = False
        cmdCancelar.Text = "Cancelar"
        Try
            If cn.ConectarVFP(lblArchivoMonitor.Text) Then ' abro el archivo dbf que viene de monitor
                TablaMonitor = cn.EjecutarSQL("SELECT * FROM " & Path.GetFileName(lblArchivoMonitor.Text) & " WHERE TIPO_VEHIC = 'INT'")
                cntReg = 0
                pgbProceso.Maximum = TablaMonitor.Tables(0).Rows.Count
                i = 0
                While i <= TablaMonitor.Tables(0).Rows.Count - 1 And Not Cancelar
                    'For Each Registro In TablaMonitor.Tables(0).Rows ' Consulto la tabla Programas_Monitor
                    Registro = TablaMonitor.Tables(0).Rows(i)
                    Application.DoEvents()
                    aux = Trim(Str(CLng(Registro("EMISION"))))
                    If Len(aux) = 7 Then ' completo la fecha para que me quede ddmmyyyy
                        aux = "0" & aux
                    End If
                    ''''''''''''''''''''''''''''''''''''''''''''''
                    ''''' Agrego a la tabla programas_monitor ''''
                    ''''''''''''''''''''''''''''''''''''''''''''''
                    oProgramas_Monitor.F_Emision = CType(Mid(aux, 1, 2) & "/" & Mid(aux, 3, 2) & "/" & Mid(aux, 5, 4), Date)
                    oProgramas_Monitor.Cadena_Monitor = IIf(Trim(Registro("CADENA")) = "", " ", Trim(Registro("CADENA")))
                    oProgramas_Monitor.Canal_Monitor = IIf(Trim(Registro("CANAL")) = "", " ", Trim(Registro("CANAL")))
                    oProgramas_Monitor.Plaza_Monitor = IIf(Trim(Registro("PLAZA")) = "", " ", Trim(Registro("PLAZA")))
                    oProgramas_Monitor.Id_programa_Monitor = IIf(Trim(Registro("PROGNAME")) = "", " ", Trim(Registro("PROGNAME")))
                    oProgramas_Monitor.Descripcion = IIf(Trim(Registro("D_PROG")) = "", " ", Trim(Registro("D_PROG")))
                    oProgramas_Monitor.HoInProg = Registro("HOINPROG")
                    oProgramas_Monitor.HoFiProg = Registro("HOFIPROG")
                    oProgramas_Monitor.TipoVehic = IIf(Trim(Registro("TIPO_VEHIC")) = "", " ", Trim(Registro("TIPO_VEHIC")))
                    oProgramas_Monitor.BuscarAgregar()
                    ' busco por cadena + plaza en soportes_sigeme_monitor el id_soporte y el id_medio 
                    oSoportes_Sigeme_Monitor.Cadena_monitor = oProgramas_Monitor.Cadena_Monitor
                    oSoportes_Sigeme_Monitor.Plaza_monitor = oProgramas_Monitor.Plaza_Monitor
                    If oSoportes_Sigeme_Monitor.Select_Cadena_Plaza Then ' si lo encuentro, agrego en programas
                        ''''''''''''''''''''''''''''''''''''''''''''''
                        ''''' Busco y agrego a la tabla programas ''''
                        ''''''''''''''''''''''''''''''''''''''''''''''
                        oProgramas.Id_medio = oSoportes_Sigeme_Monitor.Id_medio
                        oProgramas.Id_soporte = oSoportes_Sigeme_Monitor.Id_soporte
                        oProgramas.Descripcion = oProgramas_Monitor.Descripcion
                        oProgramas.Id_programa_monitor = oProgramas_Monitor.Id_programa_Monitor
                        oProgramas.Marca = " "
                        oProgramas.BuscarAgregar() ' si agrego debo buscar la relacion con Tarifas_tv
                        If oProgramas.Marca <> "X" Then
                            oTarifas_TV.Id_medio = oSoportes_Sigeme_Monitor.Id_medio
                            oTarifas_TV.Id_soporte = oSoportes_Sigeme_Monitor.Id_soporte
                            oTarifas_TV.Programa = oProgramas_Monitor.Descripcion
                            oTarifas_TV.Id_programa = oProgramas.Id_programa
                            ds = oTarifas_TV.Modificar_IdPrograma()
                            If ds.Tables(0).Rows.Count > 0 Then
                                oProgramas.Marca = "X"
                                oProgramas.Modificar()
                            End If
                        End If
                        cntReg = cntReg + 1
                    End If
                    cntReg = cntReg + 1
                    pgbProceso.Increment(1)
                    i = i + 1
                End While
            End If
            Mensajes.Mensaje("Se procesaron " & cntReg & " registros")
            cmdCancelar.Text = "Salir"
            Cancelar = True
            cn = Nothing
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)
        End Try
        cmdEjecutar.Enabled = True
        pgbProceso.Value = 0
    End Sub
    '    Private Function esTVCapoInt(ByVal pVehiculo As String) As Boolean
    '        If Trim(pVehiculo) = "INT" Or Trim(pVehiculo) = "CP" Then
    '            esTVCapoInt = True
    '        Else
    '            esTVCapoInt = False
    '        End If
    '    End Function
    '    Private Class ProgramasGuachos
    '        Dim dataTable As New DataTable("ProgramasGuachos")
    '        Dim mId_Cadena As Int64
    '        Dim mCadena As String
    '        Dim mId_Programa As Int64
    '        Dim mPrograma As String
    '        Dim mHoraIni As String
    '        Dim mHoraFin As String
    '        Dim mDia As Int16

    '#Region "Propiedades"

    '        Property Tabla()
    '            Get
    '                Tabla = dataTable
    '            End Get
    '            Set(ByVal Value)

    '            End Set
    '        End Property
    '        Property IdCadena()
    '            Get
    '                IdCadena = mId_Cadena
    '            End Get
    '            Set(ByVal Value)
    '                mId_Cadena = Value
    '            End Set
    '        End Property
    '        Property Cadena()
    '            Get
    '                Cadena = mCadena
    '            End Get
    '            Set(ByVal Value)
    '                mCadena = Value
    '            End Set
    '        End Property
    '        Property IdPrograma()
    '            Get
    '                IdPrograma = mId_Programa
    '            End Get
    '            Set(ByVal Value)
    '                mId_Programa = Value
    '            End Set
    '        End Property
    '        Property Programa()
    '            Get
    '                Programa = mPrograma
    '            End Get
    '            Set(ByVal Value)
    '                mPrograma = Value
    '            End Set
    '        End Property
    '        Property HoraIni()
    '            Get
    '                HoraIni = mHoraIni
    '            End Get
    '            Set(ByVal Value)
    '                mHoraIni = Value
    '            End Set
    '        End Property
    '        Property HoraFin()
    '            Get
    '                HoraFin = mHoraFin
    '            End Get
    '            Set(ByVal Value)
    '                mHoraFin = Value
    '            End Set
    '        End Property
    '        Property Dia()
    '            Get
    '                Dia = mDia
    '            End Get
    '            Set(ByVal Value)
    '                mDia = Value
    '            End Set
    '        End Property
    '#End Region

    '        Sub New()
    '            Dim colWork As New DataColumn("IdCadena", GetType(Int64))
    '            dataTable.Columns.Add(colWork)
    '            Dim Keys(0) As DataColumn
    '            Keys(0) = colWork
    '            dataTable.PrimaryKey = Keys

    '            colWork = New DataColumn("Cadena", GetType(String))
    '            colWork.MaxLength = 50
    '            dataTable.Columns.Add(colWork)

    '            colWork = New DataColumn("IdPrograma", GetType(Int64))
    '            dataTable.Columns.Add(colWork)

    '            colWork = New DataColumn("Programa", GetType(String))
    '            colWork.MaxLength = 50
    '            dataTable.Columns.Add(colWork)

    '            colWork = New DataColumn("HoraIni", GetType(String))
    '            colWork.MaxLength = 5
    '            dataTable.Columns.Add(colWork)

    '            colWork = New DataColumn("HoraFin", GetType(String))
    '            colWork.MaxLength = 5
    '            dataTable.Columns.Add(colWork)

    '            colWork = New DataColumn("Día", GetType(Int16))
    '            dataTable.Columns.Add(colWork)
    '        End Sub
    '        Public Sub Agregar()
    '            Dim row As DataRow = dataTable.NewRow()

    '            row("IdCadena") = mId_Cadena
    '            row("Cadena") = mCadena
    '            row("IdPrograma") = mId_Programa
    '            row("Programa") = mPrograma
    '            row("HoraIni") = mHoraIni
    '            row("HoraFin") = mHoraFin
    '            row("Día") = mDia

    '            dataTable.Rows.Add(row)
    '        End Sub
    '    End Class

    '    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '        Dim o As New Soportes_sigeme_monitor
    '        Dim a As New Programas_Monitor
    '        Dim ds As New DataSet
    '        Dim dr1 As DataRow
    '        ds = a.EjecutarSQL("select distinct 1, cadena_monitor, plaza_monitor from programas_monitor")
    '        Dim i As Integer

    '        i = 0
    '        For Each dr1 In ds.Tables(0).Rows
    '            o.Id_medio = 1
    '            o.Id_soporte = i
    '            o.Cadena_Monitor = dr1("cadena_monitor")
    '            o.Plaza_monitor = dr1("plaza_monitor")
    '            o.Agregar()
    '            i = i + 1
    '        Next
    '    End Sub

    '    Private Sub frmCargaProgMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Cancelar Then
            Me.Close()
        Else
            Cancelar = True
            pgbProceso.Value = 0
            cmdEjecutar.Enabled = True
            cmdCancelar.Text = "Salir"
        End If
    End Sub

    Private Sub frmCargaProgMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cancelar = True
    End Sub
End Class

Public Class ConnectToVFP
    Dim Conexion As OleDbConnection

    Public Function ConectarVFP(ByVal pTabla As String) As Boolean
        Dim bIsConnected As Boolean = True
        Try
            Conexion = New OleDbConnection("Provider=VFPOLEDB.1; Data Source=" & pTabla & ";")
            Conexion.Open()
        Catch e As System.Exception
            bIsConnected = False
        End Try
        Return bIsConnected
    End Function
    Public Function DesconctarVFP()
        Conexion.Close()
        Conexion = Nothing
    End Function
    Public Function EjecutarSQL(ByVal SQL As String) As DataSet
        Dim Cmd As New OleDbCommand
        Dim Ds As New DataSet
        Dim Da As New OleDbDataAdapter

        Cmd.CommandText = SQL
        Cmd.CommandType = CommandType.Text
        Cmd.Connection = Me.Conexion

        Da.SelectCommand = Cmd

        Try
            Da.Fill(Ds)
        Catch ex As OleDbException
            Mensajes.Mensaje(ex.Message)
        End Try

        Return Ds
    End Function
End Class
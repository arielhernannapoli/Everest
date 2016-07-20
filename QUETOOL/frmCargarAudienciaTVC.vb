Imports System.IO
Imports IAEN_LIB

Public Class frmCargarAudienciaTVC
    Inherits System.Windows.Forms.Form
    Public Ejecutando As Boolean
    Private mSoportes() As Long
    Private mSistema As Sistemas
    Private mHayError As Boolean
    Private mEstaAgregandoProgramacion As Boolean
    Dim IdTarget1N As Integer
    Dim idTarget2N As Integer
    Dim Grilladmin As New GrillAdmin

    Public Property Soportes() As Long()
        Get
            Return mSoportes
        End Get
        Set(ByVal Value As Long())
            mSoportes = Value
        End Set
    End Property
    Public Property HayError() As Boolean
        Get
            Return mHayError
        End Get
        Set(ByVal Value As Boolean)
            mHayError = Value
        End Set
    End Property

    Public Property Sistema() As Sistemas
        Get
            Return mSistema
        End Get
        Set(ByVal Value As Sistemas)
            mSistema = Value
        End Set
    End Property

    Public Property EstaAgregandoProgramacion() As Boolean
        Get
            Return mEstaAgregandoProgramacion
        End Get
        Set(ByVal Value As Boolean)
            mEstaAgregandoProgramacion = Value
        End Set
    End Property

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
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents pgbProgreso As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.pgbProgreso = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(8, 13)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(165, 16)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Generando Audiencias de cable"
        '
        'pgbProgreso
        '
        Me.pgbProgreso.Location = New System.Drawing.Point(8, 42)
        Me.pgbProgreso.Name = "pgbProgreso"
        Me.pgbProgreso.Size = New System.Drawing.Size(328, 8)
        Me.pgbProgreso.TabIndex = 2
        '
        'frmCargarAudienciaTVC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 61)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbProgreso)
        Me.Controls.Add(Me.lblMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCargarAudienciaTVC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Declare Function NautilusLauncher Lib "AudCable\iaenDLL.dll" Alias "_NautilusLauncher@16" (ByVal a As Integer, ByVal b As Integer, ByVal str1 As String, ByVal str2 As String) As Short

    Private Sub CargarAudiencia_TVC(ByRef pSistema As Sistemas, ByVal pSoportes() As Long)
        Dim oTarget_ext As New Targets_ext
        Dim id_Consulta As Long
        Dim HoraInicio As Date
        Dim nret As Short
        Dim Mensaje As String
        Dim ds As DataSet
        Dim Dirviejo As String

        Try
            Ejecutando = True

            HoraInicio = Now
            ds = oTarget_ext.EjecutarSQL("select sq_consulta_externa.nextval from dual")
            id_Consulta = ds.Tables(0).Rows(0)(0)

            lblMensaje.Text = "Insertando soportes"
            lblMensaje.Refresh()
            InsertarSoportes(pSoportes, id_Consulta, Activo.IDCliente, pSistema.F_inicio_aud, pSistema.F_fin_aud, pSistema.F_inicio, pSistema.F_fin)

            lblMensaje.Text = "Insertando targets"
            lblMensaje.Refresh()
            InsertarTargets(id_Consulta, pSistema)

            lblMensaje.Text = "Generando audiencia de cable"
            lblMensaje.Refresh()
            'AGREGADO CRISTIAN--- CORRECCCION DE TARGETS



            '**************************

            ''dcaime 18/06/2010
            ''Dirviejo = Application.StartupPath
            Dirviejo = My.Computer.FileSystem.CurrentDirectory
            'My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory + "\AudCable"

            'JJP 07012010  - Toma la ruta de inicio de la aplicación que es donde está la carpeta de Audiencia
            My.Computer.FileSystem.CurrentDirectory = Application.StartupPath + "\AudCable"

            ''ChDir(Dirviejo + "\\AudCable")

            ''Dim testIaen As New LLAMADA_IAEN
            ''testIaen.Generar(id_Consulta)
            nret = NautilusLauncher(2, id_Consulta, "NAUTILUS", "97GF945929B1867E")

            'ChDir(Dirviejo)
            My.Computer.FileSystem.CurrentDirectory = Dirviejo

            Mensaje = VerificarError(nret)
            If nret = 0 Then ' no hubo error 
                lblMensaje.Text = "Borrando audiencia"
                lblMensaje.Refresh()
                BorrarAudiencia(pSistema, pSoportes)
                lblMensaje.Text = "Copiando audiencia"
                lblMensaje.Refresh()
                CopiarAudiencia_TVC(id_Consulta, 0)
                lblMensaje.Text = "El proceso termino en " & DateDiff(DateInterval.Second, HoraInicio, Now) & " segundos"
                lblMensaje.Refresh()
            Else

                If pSistema.Id_tipo_soporte = 2 Or pSistema.Id_tipo_soporte = 3 Or pSistema.Id_tipo_soporte = 5 And nret = 10 Then
                    lblMensaje.Text = "Borrando audiencia"
                    lblMensaje.Refresh()
                    BorrarAudiencia(pSistema, pSoportes)
                    lblMensaje.Text = "El proceso termino en " & DateDiff(DateInterval.Second, HoraInicio, Now) & " segundos"
                    lblMensaje.Refresh()
                    HayError = False
                Else
                    lblMensaje.Text = Mensaje
                    lblMensaje.Refresh()
                    Mensajes.Mensaje("frmCargarAudienciaTVC.CargarAudiencia_TVC: " & Mensaje)
                End If
            End If

        Catch ex As Exception
            Mensajes.Mensaje("frmCargarAudienciaTVC.CargarAudiencia_TVC: " & ex.Message)
        End Try
    End Sub

    Private Sub BorrarAudiencia(ByVal pSistema As Sistemas, ByVal pSoportes() As Long)
        ' antes de ejecutar borro la audiencia que estoy por cargar
        Dim oA As New Audiencia_tvc
        Dim i As Integer

        With pSistema
            oA.Id_plaza = .ID_Plaza
            oA.Id_medio = .Id_medio
            For i = 0 To pSoportes.Length - 1
                oA.Id_soporte = pSoportes(i)
                oA.Id_target_1 = .Id_target_1
                oA.Id_target_2 = IIf(IsNothing(.Id_target_2), -1, .Id_target_2)
                oA.BorrarAudiencia(pSistema.F_inicio_aud, pSistema.F_fin_aud)
            Next
        End With
    End Sub
    Private Function VerificarError(ByVal pCod As Integer) As String
        Dim Mensaje As String
        HayError = True
        Select Case pCod
            Case Is = 0 ' finalizo ok
                Mensaje = ""
                HayError = False
            Case Is = 1
                Mensaje = "ATENCIÓN: No se encuentran emisiones del tipo solicitado asociadas al identificador de consulta"
            Case Is = 2
                Mensaje = "ATENCIÓN: No hay targets asociados al identificador de consulta"
            Case Is = 3
                Mensaje = "ATENCIÓN: No se encuentra fichero de trabajo para alguna de las fechas para las que se han encontrado emisiones"
            Case Is = 4
                Mensaje = "ATENCIÓN: Usuario no válido"
            Case Is = 5
                Mensaje = "ATENCIÓN: El número de targets aociados al identificador de consulta es mayor que el máximo permitido"
            Case Is = 6
                Mensaje = "ATENCIÓN: No hay datos para el día procesado en el fichero de trabajo"
            Case Is = 8
                Mensaje = "ERROR: Errores de lectura y/o escritura en fichero"
            Case Is = 9
                Mensaje = "ERROR: Desconocido"
            Case Is = 10
                Mensaje = "ERROR ORACLE: No se completa correctamente cualquier inserción o borrado en alguna de las tablas"
            Case Else
                Mensaje = "ERROR: Desconocido"
        End Select
        VerificarError = Mensaje
    End Function

    Private Sub CopiarAudiencia_TVC(ByVal pId_Consulta As Long, ByVal pCliente As Long)
        ' tomo la tabla generada por la dll y la cargo en la tabla de audiencia
        Dim oAudiencia_TVC As New Audiencia_tvc
        Dim oAudProg_Ext As New Audprog_ext
        Dim oSoporte As New Soportes
        Dim ds As New DataSet
        Dim i As Integer
        Dim d As Date
        Dim target1 As Long
        Dim target2 As Long
        Dim DsTarget1 As DataRow()
        Dim DsTarget2 As DataRow()
        Dim dtsop As DataTable
        Dim strs As String
        Dim DrSoportes As DataRow


        target1 = -999999
        target2 = -999999

        Const PLAZA = 1


        IdTarget1N = GetTargetNautilus(Sistema.Id_target_1)
        If Sistema.Id_target_2 > -1 Then
            idTarget2N = GetTargetNautilus(Sistema.Id_target_2)
        Else
            idTarget2N = -1
        End If
        Try
            strs = ""
            For i = 0 To mSoportes.Length - 1
                strs = strs & mSoportes(i) & ","
            Next
            strs = strs.Substring(0, strs.Length - 1)

            'JJP 17052011 Se estaba obteniendo los soportes de la base en vez del activo
            'dtsop = oSoporte.EjecutarSQL("select id_Medio, id_soporte, id_cadena from soportes where id_tipo_soporte=3 and id_soporte IN (" & strs & ")").Tables(0)

            oAudProg_Ext.Id_consulta = pId_Consulta
            ds = oAudProg_Ext.BuscarPorId()
            DsTarget1 = ds.Tables(0).Select("id_trgt =" & IdTarget1N)
            pgbProgreso.Maximum = DsTarget1.Length - 1

            If Sistema.Id_target_2 > -1 Then
                DsTarget2 = ds.Tables(0).Select("id_trgt =" & idTarget2N)
            End If
            i = 0
            For Each r As DataRow In DsTarget1
                'La validación por la cadena U80 es por los soporte que no tienen fuente y se les coloca esa cadena
                'Al cargar los spots en la hoja, no va a pisar la información de distintos soporte con misma cadena
                If Not r("Cad_apr") = "U80" Then
                    With oAudiencia_TVC
                        ' Busco el soporte utilizando el id_cadena en la tabla soportes
                        .Id_plaza = PLAZA
                        .F_franja = r("Fec_apr")

                        'JJP 17052011 Se estaba obteniendo los soportes de la base en vez del activo
                        DrSoportes = Activo.DTSoportesCache.Select("cod_tipo_soporte = 3 and id_medio = 1 and id_cadena = '" & r("Cad_apr") & "' and id_soporte IN (" & strs & ")")(0)
                        'DrSoportes = dtsop.Select("id_cadena = '" & r("Cad_apr") & "'")(0)

                        .Id_medio = DrSoportes.Item("id_medio")
                        .Id_soporte = DrSoportes.Item("id_soporte")
                        .Id_tarifa_tv = r("Id_Tarifas_tv")
                        .H_inicio = Trim(Str(r("Hor_Apr") / 100)).PadLeft(4, "0") ' lo divido porque esta en format hhmmss 
                        .H_fin = Listas.SumarHoras(.H_inicio, r("Duracion"), "mmmm").Substring(0, 4)

                        .Id_target_1 = Sistema.Id_target_1
                        .Rat_1 = DsTarget1(i)("Ame_apr")

                        If Sistema.Id_target_2 > -1 Then
                            .Id_target_2 = Sistema.Id_target_2
                            .Rat_2 = DsTarget2(i)("Ame_apr")
                        Else
                            .Id_target_2 = -1
                            .Rat_2 = 0
                        End If

                        .Agregar()
                        pgbProgreso.Increment(1)
                    End With
                End If
                i += 1
            Next


            'For i = 0 To ds.Tables(0).Rows.Count - 1
            '    With oAudiencia_TVC
            '        ' Busco el soporte utilizando el id_cadena en la tabla soportes
            '        .Id_plaza = PLAZA
            '        .F_franja = ds.Tables(0).Rows(i)("Fec_apr")
            '        DrSoportes = dtsop.Select("id_cadena = '" & ds.Tables(0).Rows(i)("Cad_apr") & "'")(0)
            '        .Id_medio = DrSoportes.Item("id_medio")
            '        .Id_soporte = DrSoportes.Item("id_soporte")
            '        .Id_tarifa_tv = ds.Tables(0).Rows(i)("Id_Tarifas_tv")
            '        .H_inicio = Trim(Str(ds.Tables(0).Rows(i)("Hor_Apr") / 100)).PadLeft(4, "0") ' lo divido porque esta en format hhmmss 
            '        .H_fin = Listas.SumarHoras(.H_inicio, ds.Tables(0).Rows(i)("Duracion"), "mmmm").Substring(0, 4)

            '        '---AGREGADO CRISTIAN CORRECCION DE TARGETS

            '        If target2 = -999999 Then ' lo hago para no tener que acceder a la tabla tantas veces cuando los targets pueden ser solo 2
            '            target2 = GetTarget(ds.Tables(0).Rows(i)("Id_trgt"))
            '        End If
            '        '------------------------------------


            '        .Id_target_2 = target2
            '        .Rat_1 = ds.Tables(0).Rows(i)("Ame_apr")
            '        ' Si tiene 2 targets verifico el 2do, porque lo tengo que agregar en el mismo registro de audiencia
            '        If i < ds.Tables(0).Rows.Count - 1 Then
            '            ' Verifico que se trate de la misma franja y que lo unico que cambia el id_trgt
            '            If pId_Consulta = ds.Tables(0).Rows(i + 1)("Id_Consulta") And _
            '              ds.Tables(0).Rows(i)("Cad_apr") = ds.Tables(0).Rows(i + 1)("Cad_apr") And _
            '              ds.Tables(0).Rows(i)("Fec_Apr") = ds.Tables(0).Rows(i + 1)("Fec_Apr") And _
            '              ds.Tables(0).Rows(i)("Hor_Apr") = ds.Tables(0).Rows(i + 1)("Hor_Apr") And _
            '              ds.Tables(0).Rows(i)("Id_trgt") <> ds.Tables(0).Rows(i + 1)("Id_trgt") Then
            '                i = i + 1
            '                If target2 = -999999 Then
            '                    target2 = GetTarget(ds.Tables(0).Rows(i)("Id_trgt"))
            '                End If
            '                .Id_target_2 = target2
            '                .Rat_2 = ds.Tables(0).Rows(i)("Ame_apr")
            '            Else
            '                .Id_target_2 = -1
            '                .Rat_2 = 0
            '            End If
            '        End If
            '        .Agregar()
            '        pgbProgreso.Increment(IIf(target2 = -999999, 1, 2))
            '    End With
            'Next i
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GetTargetNautilus(ByVal id_target As Integer) As Integer
        Dim oTarget_Nautilus As New Targets_nautilus

        oTarget_Nautilus.Id_target = id_target
        oTarget_Nautilus.BuscarPorTarget()
        Return oTarget_Nautilus.Id_target_nautilus

    End Function
    Private Function GetTarget(ByVal pTrg_Nautilus) As Integer
        Dim oTarget_Nautilus As New Targets_nautilus

        oTarget_Nautilus.Id_target_nautilus = pTrg_Nautilus
        oTarget_Nautilus.BuscarPorID()
        GetTarget = oTarget_Nautilus.Id_target

    End Function

    Private Sub InsertarSoportes(ByVal pSoportes() As Int64, ByVal pId_Consulta As Integer, ByVal pCliente As Long, ByVal F_Aud_Desde As Date, ByVal F_Aud_Hasta As Date, ByVal F_Sis_Desde As Date, ByVal F_Sis_Hasta As Date)
        Dim oSoporte As New Soportes
        Dim oPrograma_Ext As New Programa_Ext
        Dim i As Integer

        pgbProgreso.Maximum = pSoportes.Length - 1
        For i = 0 To pSoportes.Length - 1
            oSoporte.Id_soporte = pSoportes(i)
            oSoporte.Id_medio = 1
            oSoporte.BuscarPorID_Soporte()
            oPrograma_Ext.Id_Consulta = pId_Consulta
            oPrograma_Ext.Cad_Prg = oSoporte.Id_cadena
            If mEstaAgregandoProgramacion Then
                oPrograma_Ext.CargarAudienciaReducida(oSoporte.Id_medio, oSoporte.Id_soporte, pCliente, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta, Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)
            Else
                oPrograma_Ext.CargarAudiencia(oSoporte.Id_medio, oSoporte.Id_soporte, oSoporte.Id_cadena, pCliente, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta)
            End If
            pgbProgreso.Increment(1)
        Next i
    End Sub

    Private Sub InsertarTargets(ByVal pId_Consulta As Int32, ByVal pSistema As Sistemas)
        ' Convierte e inserta los targets del sistema (1 o 2) en la tabla de target para 
        'procesar con la dll de nautilus
        Dim TN As New Targets_nautilus
        Dim oTargets_Ext As New Targets_ext

        TN.Id_target = pSistema.Id_target_1
        TN.BuscarPorTarget()

        oTargets_Ext.Id_consulta = pId_Consulta
        oTargets_Ext.Id_trgt = TN.Id_target_nautilus
        oTargets_Ext.Agregar()

        If pSistema.Id_target_2 > -1 Then
            TN.Id_target = pSistema.Id_target_2
            TN.BuscarPorTarget()

            oTargets_Ext.Id_consulta = pId_Consulta
            oTargets_Ext.Id_trgt = TN.Id_target_nautilus
            oTargets_Ext.Agregar()
        End If
    End Sub

    Private Sub frmAudienciaCable_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        '   Dim oSistema As New Sistemas
        '  Dim arSoportes() As Long

        If Not Ejecutando Then ' lo hago porque si falla, lanza un msgbox y pierde el activate, cuando vuelve, se ejecuta nuevamente
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            CargarAudiencia_TVC(Me.Sistema, Me.Soportes)
            Cursor.Current = System.Windows.Forms.Cursors.Default()
        End If
        Me.Close()
    End Sub

    Private Sub frmCargarAudienciaTVC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ejecutando = False
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class

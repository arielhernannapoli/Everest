Imports System.Data.OleDb
Imports System.IO
Imports System.Reflection
Imports Framework

Public Class frmCargarAudienciaTVI
    Inherits System.Windows.Forms.Form
    Public Ejecutando As Boolean
    Private mSoportes() As Long
    Private mSistema As Sistemas
    Private mHayError As Boolean
    Private Target As New SortedList
    Private mEstaAgregandoProgramacion As Boolean
    Public Property HayError() As Boolean
        Get
            Return mHayError
        End Get
        Set(ByVal Value As Boolean)
            mHayError = Value
        End Set
    End Property
    Public Property Soportes() As Long()
        Get
            Return mSoportes
        End Get
        Set(ByVal Value As Long())
            mSoportes = Value
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
        Me.lblMensaje.Size = New System.Drawing.Size(173, 16)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Generando Audiencias de interior"
        '
        'pgbProgreso
        '
        Me.pgbProgreso.Location = New System.Drawing.Point(8, 42)
        Me.pgbProgreso.Name = "pgbProgreso"
        Me.pgbProgreso.Size = New System.Drawing.Size(328, 8)
        Me.pgbProgreso.TabIndex = 2
        '
        'frmCargarAudienciaTVI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 61)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbProgreso)
        Me.Controls.Add(Me.lblMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCargarAudienciaTVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Declare Function NautilusLauncher Lib "AudInterior\iaenDLL.dll" Alias "_NautilusLauncher@16" (ByVal a As Integer, ByVal b As Integer, ByVal str1 As String, ByVal str2 As String) As Short

    Private Sub CargarAudiencia_TVI(ByRef pSistema As Sistemas, ByVal pSoportes() As Long)
        Dim dirViejo As String
        Dim HoraInicio As Date
        Dim Tarifas As New Tarifas_tv
        Dim dsTarifas As DataSet
        Dim dsTarifaCliente As DataSet
        Dim IdClienteTarifaSoporte, CantidadClienteTarifaSoporte As Integer
        Try
            Ejecutando = True

            If Not PlazaTieneMedidicion(pSistema.ID_Plaza) Then
                Exit Sub
            End If

            ''dcaime 18/06/2010
            dirViejo = My.Computer.FileSystem.CurrentDirectory
            'My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory + "\AudInterior"

            'JJP 07012010  - Toma la ruta de inicio de la aplicación que es donde está la carpeta de Audiencia
            My.Computer.FileSystem.CurrentDirectory = Application.StartupPath + "\AudInterior"

            'dirViejo = 'Application.StartupPath
            'ChDir(dirViejo & "\AudInterior")
            HoraInicio = Now

            For Index As Integer = 0 To pSoportes.Length - 1
                dsTarifas = New DataSet
                Tarifas.Id_cliente = Activo.IDCliente
                Tarifas.Id_medio = pSistema.Id_medio
                Tarifas.Id_soporte = pSoportes(Index)
                Tarifas.F_inicio_vig = pSistema.F_inicio
                Tarifas.F_fin_vig = pSistema.F_fin

                dsTarifaCliente = Tarifas.TraerTarifasCliente
                If Not dsTarifaCliente Is Nothing AndAlso Not dsTarifaCliente.Tables(0) Is Nothing AndAlso dsTarifaCliente.Tables(0).Rows.Count > 0 Then
                    CantidadClienteTarifaSoporte = dsTarifaCliente.Tables(0).Rows(0)("CANTIDADCLIENTE")
                End If
                If CantidadClienteTarifaSoporte > 0 Then
                    IdClienteTarifaSoporte = Activo.IDCliente
                End If

                Dim oS As New Soportes_Interior
                oS.Id_Soporte = pSoportes(Index)
                oS.BuscarPorID_Soporte()

                dsTarifas = Tarifas.TraerTarifasSoporteConVigencia(oS.Id_Medio, oS.Id_Soporte, IdClienteTarifaSoporte, pSistema.F_inicio_aud, pSistema.F_fin_aud, pSistema.F_inicio, pSistema.F_fin)
                If Not dsTarifas Is Nothing AndAlso Not dsTarifas.Tables(0) Is Nothing Then
                    Call ProcesarTarifas(dsTarifas, IdClienteTarifaSoporte, oS, pSistema, pSoportes, Index)
                End If
            Next
            If Not HayError Then
                lblMensaje.Text = "El proceso termino en " & DateDiff(DateInterval.Second, HoraInicio, Now) & " segundos"
                lblMensaje.Refresh()
            End If
            ''ChDir(dirViejo)
            My.Computer.FileSystem.CurrentDirectory = dirViejo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProcesarTarifas(ByVal dsTarifas As DataSet, ByVal IdClienteTarifaSoporte As Integer, ByVal oS As Soportes_Interior, ByRef pSistema As Sistemas, ByVal pSoportes() As Long, ByVal Index As Integer)
        Dim TarifasGenerales As New DataTable
        Dim TarifasSolapadas As New DataTable
        TarifasGenerales = dsTarifas.Tables(0).Clone
        TarifasSolapadas = dsTarifas.Tables(0).Clone
        Dim Existe, MismoIdTarifa As Boolean
        For Each drTarifas As DataRow In dsTarifas.Tables(0).Rows
            Existe = False
            MismoIdTarifa = False
            If Not TarifasGenerales Is Nothing AndAlso TarifasGenerales.Rows.Count > 0 Then
                For Each drTarifasGenerales As DataRow In TarifasGenerales.Rows
                    If drTarifasGenerales("H_Desde") = drTarifas("H_Desde") AndAlso drTarifasGenerales("M_Desde") = drTarifas("M_Desde") AndAlso drTarifasGenerales("Fecha") = drTarifas("Fecha") Then
                        Existe = True
                        Exit For
                    End If
                Next
            End If
            If Not MismoIdTarifa Then
                If Not Existe Then
                    TarifasGenerales.ImportRow(drTarifas)
                Else
                    TarifasSolapadas.ImportRow(drTarifas)
                End If
            End If
        Next
        Call ProcesarTarifas(TarifasGenerales, IdClienteTarifaSoporte, oS, pSistema, pSoportes, Index)
        If Not TarifasSolapadas Is Nothing AndAlso TarifasSolapadas.Rows.Count > 0 Then
            Dim dsTarifasSolapadas As New DataSet
            dsTarifasSolapadas.Tables.Add(TarifasSolapadas)
            Call ProcesarTarifas(dsTarifasSolapadas, IdClienteTarifaSoporte, oS, pSistema, pSoportes, Index)
        End If
    End Sub

    Private Sub ProcesarTarifas(ByVal pDatos As DataTable, ByVal IdClienteTarifaSoporte As Integer, ByVal oS As Soportes_Interior, ByRef pSistema As Sistemas, ByVal pSoportes() As Long, ByVal Index As Integer)
        Dim id_Consulta As Long

        Dim ds As DataSet
        Dim oTarget_ext As New Targets_ext
        Dim nret As Integer
        Dim Mensaje As String

        If Not pDatos Is Nothing AndAlso pDatos.Rows.Count > 0 Then
            ds = oTarget_ext.EjecutarSQL("select i_sq_consulta_externa.nextval from dual")
            id_Consulta = ds.Tables(0).Rows(0)(0)

            Dim FiltroIdTarifaTV As DataTable = pDatos.Clone
            Dim IdTarifasTV As New ArrayList
            For Each drTarifas As DataRow In pDatos.Rows
                If Not IdTarifasTV.Contains(drTarifas("Id_Tarifa_TV")) Then
                    IdTarifasTV.Add(drTarifas("Id_Tarifa_TV"))
                    FiltroIdTarifaTV.ImportRow(drTarifas)
                End If
            Next


            lblMensaje.Text = "Insertando soportes de Interior"
            lblMensaje.Refresh()
            pgbProgreso.Maximum = FiltroIdTarifaTV.Rows.Count - 1
            pgbProgreso.Value = 0
            For Each drTarifas As DataRow In FiltroIdTarifaTV.Rows
                InsertarSoportes(IdClienteTarifaSoporte, oS, pSoportes(Index), drTarifas("Id_Tarifa_TV"), id_Consulta, Activo.IDCliente, pSistema.F_inicio_aud, pSistema.F_fin_aud, pSistema.F_inicio, pSistema.F_fin)
                pgbProgreso.Increment(1)
            Next

            pgbProgreso.Maximum = 2
            pgbProgreso.Value = 0
            lblMensaje.Text = "Insertando targets"
            lblMensaje.Refresh()
            InsertarTargets(id_Consulta, pSistema)
            pgbProgreso.Increment(1)
            lblMensaje.Text = "Generando audiencia de interior"
            lblMensaje.Refresh()
            nret = NautilusLauncher(2, id_Consulta, "NAUTILUS", "97GF945929B1867E")
            Mensaje = VerificarError(nret)
            pgbProgreso.Increment(1)

            If nret = 0 Then ' no hubo error 
                lblMensaje.Text = "Borrando audiencia"
                lblMensaje.Refresh()
                pgbProgreso.Maximum = FiltroIdTarifaTV.Rows.Count - 1
                pgbProgreso.Value = 0
                For Each drTarifas As DataRow In FiltroIdTarifaTV.Rows
                    BorrarAudiencia(drTarifas("Id_Tarifa_TV"), pSistema, pSoportes(0))
                    pgbProgreso.Increment(1)
                Next
                lblMensaje.Text = "Copiando audiencia interior"
                lblMensaje.Refresh()
                pgbProgreso.Maximum = FiltroIdTarifaTV.Rows.Count - 1
                pgbProgreso.Value = 0
                For Each drTarifas As DataRow In FiltroIdTarifaTV.Rows
                    If Not CopiarAudiencia_TVI(oS, id_Consulta, Activo.IDCliente, pSoportes(Index), drTarifas("Id_Tarifa_TV"), pSistema) Then
                        HayError = True
                    End If
                    pgbProgreso.Increment(1)
                Next
            Else
                lblMensaje.Text = Mensaje
                lblMensaje.Refresh()
                MsgBox(Mensaje)
                HayError = True
            End If
        End If
    End Sub

    Private Function PlazaTieneMedidicion(ByVal id_plaza As Long) As Boolean
        Dim p As New Plazas_Medicion

        p.Id_Plaza = id_plaza
        p.BuscarPorID()
        PlazaTieneMedidicion = (p.Id_Plaza > -1)
    End Function

    Private Sub BorrarAudiencia(ByVal pId_Tarifa_TV As Integer, ByVal pSistema As Sistemas, ByVal pSoporte As Long)
        Dim oA As New Audiencia_TVI
        Dim i As Integer

        With pSistema
            oA.Id_Plaza = .ID_Plaza
            oA.Id_Medio = .Id_medio
            oA.Id_Soporte = pSoporte
            oA.Id_Target_1 = .Id_target_1
            oA.Id_Target_2 = IIf(IsNothing(.Id_target_2), -1, .Id_target_2)
            oA.BorrarAudiencia(pId_Tarifa_TV, pSistema.F_inicio_aud, pSistema.F_fin_aud)
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

    Private Function CopiarAudiencia_TVI(ByVal oS As Soportes_Interior, ByVal pId_Consulta As Long, ByVal pCliente As Long, ByVal pSoporte As Long, ByVal pId_Tarifa_TV As Integer, ByRef pSistema As Sistemas) As Boolean
        ' tomo la tabla generada por la dll y la cargo en la tabla de audiencia
        Dim oAudiencia_TVI As New Audiencia_TVI
        Dim oAudProg_Ext As New I_AudProg_Ext
        Dim ds As New DataSet
        Dim ret As Boolean = False
        Dim Filtro As New System.Text.StringBuilder
        Dim Target1, Target2 As Integer

        Try
            oAudProg_Ext.Id_Consulta = pId_Consulta
            ds = oAudProg_Ext.BuscarPorId() ' traigo la audiencia generada
            If ds.Tables(0).Rows.Count = 0 Then ' por si no trajo nada, ya o dejo que salga.
                'pgbProgreso.Maximum = 0
                Exit Function
            Else
                'pgbProgreso.Maximum = ds.Tables(0).Rows.Count - 1
            End If

            For Index As Integer = 0 To Target.Count - 1
                If Target.GetValueList.Item(Index) = pSistema.Id_target_1 Then
                    Target1 = Target.GetKey(Index)
                End If
                If Target.GetValueList.Item(Index) = pSistema.Id_target_2 Then
                    Target2 = Target.GetKey(Index)
                End If
            Next

            Filtro.Append("Id_Tarifas_TV = '")
            Filtro.Append(pId_Tarifa_TV)
            Filtro.Append("' and Cob_apr = '")
            Filtro.Append(oS.Cob_Cad)
            Filtro.Append("' and Id_Trgt = '")
            Filtro.Append(Target1)
            Filtro.Append("'")

            For Each drAudiencia As DataRow In ds.Tables(0).Select(Filtro.ToString)
                With oAudiencia_TVI
                    .Id_Plaza = oS.Id_Plaza
                    .F_Programa = drAudiencia("Fec_apr")
                    .Id_Medio = oS.Id_Medio
                    .Id_Soporte = oS.Id_Soporte
                    .Id_Tarifa_TV = drAudiencia("Id_Tarifas_tv")
                    .H_Inicio = Int(drAudiencia("Hor_Apr") / 100).ToString ' lo divido porque esta en format hhmmss 
                    .H_Fin = Listas.SumarHoras(.H_Inicio, drAudiencia("Duracion"), "mmmm").Substring(0, 4)
                    .Id_Target_1 = pSistema.Id_target_1
                    .Rat_1 = drAudiencia("Ame_apr")
                    If Target2 <> 0 Then
                        Dim FiltroTarget As New System.Text.StringBuilder
                        FiltroTarget.Append("Id_Tarifas_tv = '")
                        FiltroTarget.Append(drAudiencia("Id_Tarifas_tv"))
                        FiltroTarget.Append("' and Fec_Apr = '")
                        FiltroTarget.Append(drAudiencia("Fec_Apr"))
                        FiltroTarget.Append("' and Id_Trgt = '")
                        FiltroTarget.Append(Target2)
                        FiltroTarget.Append("' and Cob_apr = '")
                        FiltroTarget.Append(oS.Cob_Cad)
                        FiltroTarget.Append("'")

                        For Each drTarget2 As DataRow In ds.Tables(0).Select(FiltroTarget.ToString)
                            .Id_Target_2 = pSistema.Id_target_2
                            .Rat_2 = drTarget2("Ame_apr")
                        Next
                    Else
                        .Id_Target_2 = -1
                        .Rat_2 = 0
                    End If

                    .Agregar()
                    'pgbProgreso.Increment(IIf(Target2 = -999999, 1, 2))
                End With
            Next
            ret = True
        Catch ex As Exception
            Throw ex
        Finally
            CopiarAudiencia_TVI = ret
        End Try
    End Function
    Private Function GetCob_Apr(ByVal ps As Long) As Integer
        ' uso el soporte para ir a buscar a soportes de interior el cob_apr
        Dim oS As New Soportes_Interior

        oS.Id_Soporte = ps
        oS.BuscarPorID_Soporte()

        GetCob_Apr = oS.Cob_Cad
    End Function
    Private Function GetTarget(ByVal pTrg_Nautilus) As Integer
        Dim oTarget_Nautilus As New Targets_Nautilus_Interior

        oTarget_Nautilus.Id_Target_Nautilus = pTrg_Nautilus
        oTarget_Nautilus.BuscarPorID()
        GetTarget = oTarget_Nautilus.Id_Target

    End Function

    Private Sub InsertarSoportes(ByVal IdClienteTarifaSoporte As Integer, ByVal oSoporte As Soportes_Interior, ByVal pIdSoporte As Integer, ByVal pId_Tarifa_TV As Integer, ByVal pId_Consulta As Integer, ByVal pCliente As Long, ByVal F_Aud_Desde As Date, ByVal F_Aud_Hasta As Date, ByVal F_Sis_Desde As Date, ByVal F_Sis_Hasta As Date)
        Dim oPrograma_Ext As New I_Programa_Ext
        Dim i As Integer
        Try
            oPrograma_Ext.Id_Consulta = pId_Consulta
            oPrograma_Ext.Cad_prg = oSoporte.Id_Cadena
            oPrograma_Ext.CargarAudienciaC(oSoporte.Id_Medio, oSoporte.Id_Soporte, oSoporte.Id_Cadena, IdClienteTarifaSoporte, pId_Tarifa_TV, F_Aud_Desde, F_Aud_Hasta, F_Sis_Desde, F_Sis_Hasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function esPlazaPeopleMeter(ByVal pPlaza As Integer) As Boolean
        Dim p As New Plazas_Medicion

        p.Id_Plaza = pPlaza
        p.BuscarPorID()
        esPlazaPeopleMeter = (p.Medicion = "P")

    End Function
    Private Sub InsertarTargets(ByVal pId_Consulta As Int32, ByVal pSistema As Sistemas)
        ' Convierte e inserta los targets del sistema (1 o 2) en la tabla de target para 
        'procesar con la dll de nautilus
        Dim TN As New Targets_Nautilus_Interior
        Dim oTargets_Ext As New I_Targets_Ext
        Dim TargetNautilus As Integer = 0

        Try
            If Not Target Is Nothing AndAlso Target.Count > 0 Then
                For Index As Integer = 0 To Target.Count - 1
                    If Target.GetValueList.Item(Index) = pSistema.Id_target_1 Then
                        TargetNautilus = Target.GetKey(Index)
                    End If
                Next
            End If
            If TargetNautilus <= 0 Then
                TN.Id_Target = pSistema.Id_target_1
                TN.BuscarPorTarget()
                TargetNautilus = TN.Id_Target_Nautilus
            End If

            If TargetNautilus = -1 Then
                Mensajes.Mensaje("No se encuentra para el primer target (" & pSistema.Id_target_1 & ") su relación con el target nautilus")
            Else
                If Not Target.Contains(TargetNautilus) Then
                    Target.Add(TargetNautilus, pSistema.Id_target_1)
                End If

                oTargets_Ext.Id_Consulta = pId_Consulta
                oTargets_Ext.Id_Trgt = TargetNautilus
                oTargets_Ext.Agregar()
            End If

            If pSistema.Id_target_2 > -1 Then
                TargetNautilus = 0
                If Not Target Is Nothing AndAlso Target.Count > 0 Then
                    For Index As Integer = 0 To Target.Count - 1
                        If Target.GetValueList.Item(Index) = pSistema.Id_target_2 Then
                            TargetNautilus = Target.GetKey(Index)
                        End If
                    Next
                End If
                If TargetNautilus <= 0 Then
                    TN.Id_Target = pSistema.Id_target_2
                    TN.BuscarPorTarget()
                    TargetNautilus = TN.Id_Target_Nautilus
                End If
                If TargetNautilus = -1 Then
                    Mensajes.Mensaje("No se encuentra para el segundo target (" & pSistema.Id_target_2 & ") su relación con el target nautilus")
                Else
                    If Not Target.Contains(TargetNautilus) Then
                        Target.Add(TargetNautilus, pSistema.Id_target_2)
                    End If

                    oTargets_Ext.Id_Consulta = pId_Consulta
                    oTargets_Ext.Id_Trgt = TargetNautilus
                    oTargets_Ext.Agregar()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmCargarAudienciaTVI_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim oSistema As New Sistemas
        Dim arSoportes() As Long

        If Not Ejecutando Then ' lo hago porque si falla, lanza un msgbox y pierde el activate, cuando vuelve, se ejecuta nuevamente
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            CargarAudiencia_TVI(Me.Sistema, Me.Soportes)
            Cursor.Current = System.Windows.Forms.Cursors.Default()
        End If

        Me.Close()
    End Sub

    Private Sub frmCargarAudienciaTVI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ejecutando = False
    End Sub
End Class

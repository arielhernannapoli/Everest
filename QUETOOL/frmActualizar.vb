Public Class frmActualizar
    Inherits System.Windows.Forms.Form

    Dim Sistema As New Sistemas
    Dim mId_Target1 As Int32
    Dim mId_Target2 As Int32
    Dim mF_Desde As Date
    Dim mF_Hasta As Date
    Dim mDeflactacion As Decimal
    Dim Ejecutando As Boolean
    Dim mTerminoOk As Boolean

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub

    Public Sub New(ByVal id_campania As Long, ByVal id_sistema As Long, ByVal id_target1 As Int32, ByVal id_target2 As Int32, ByVal f_desde As Date, ByVal f_hasta As Date, ByVal Deflactacion As Decimal)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Sistema.Id_campania = id_campania
        Sistema.Id_sistema = id_sistema
        Sistema.BuscarPorID()

        txtDescripcion.Text = Sistema.Descripcion

        'If Sistema.Id_medio = MedioRadio Then
        '    SistemaRadio.F_inicio = Sistema.F_inicio
        '    SistemaRadio.F_fin = Sistema.F_fin
        '    SistemaRadio.F_inicio_aud = Sistema.F_inicio_aud
        '    SistemaRadio.F_fin_aud = Sistema.F_fin_aud
        '    SistemaRadio.Id_target_1 = Sistema.Id_target_1
        '    SistemaRadio.Id_target_2 = Sistema.Id_target_2
        'End If

        mId_Target1 = id_target1
        mId_Target2 = id_target2
        mF_Desde = f_desde
        mF_Hasta = f_hasta
        mDeflactacion = Deflactacion
        Ejecutando = False
        TerminoOK = False
    End Sub

    Public Sub New(ByVal id_campania As Long)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Sistema.Id_campania = -1
        Ejecutando = False
        TerminoOK = False
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCambiosManuales As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnviadosCompras As System.Windows.Forms.CheckBox
    Friend WithEvents chkReprogramados As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents pgbProgreso As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkReprogramados = New System.Windows.Forms.CheckBox
        Me.chkEnviadosCompras = New System.Windows.Forms.CheckBox
        Me.chkCambiosManuales = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.pgbProgreso = New System.Windows.Forms.ProgressBar
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(288, 180)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(368, 180)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 2)
        Me.Label1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkReprogramados)
        Me.GroupBox1.Controls.Add(Me.chkEnviadosCompras)
        Me.GroupBox1.Controls.Add(Me.chkCambiosManuales)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 108)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incluir  los avisos"
        '
        'chkReprogramados
        '
        Me.chkReprogramados.Checked = True
        Me.chkReprogramados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReprogramados.Location = New System.Drawing.Point(24, 76)
        Me.chkReprogramados.Name = "chkReprogramados"
        Me.chkReprogramados.Size = New System.Drawing.Size(148, 16)
        Me.chkReprogramados.TabIndex = 2
        Me.chkReprogramados.Text = "Reprogramados"
        '
        'chkEnviadosCompras
        '
        Me.chkEnviadosCompras.Checked = True
        Me.chkEnviadosCompras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnviadosCompras.Location = New System.Drawing.Point(24, 52)
        Me.chkEnviadosCompras.Name = "chkEnviadosCompras"
        Me.chkEnviadosCompras.Size = New System.Drawing.Size(148, 16)
        Me.chkEnviadosCompras.TabIndex = 1
        Me.chkEnviadosCompras.Text = "Enviados a compras "
        '
        'chkCambiosManuales
        '
        Me.chkCambiosManuales.Checked = True
        Me.chkCambiosManuales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCambiosManuales.Location = New System.Drawing.Point(24, 28)
        Me.chkCambiosManuales.Name = "chkCambiosManuales"
        Me.chkCambiosManuales.Size = New System.Drawing.Size(188, 16)
        Me.chkCambiosManuales.TabIndex = 0
        Me.chkCambiosManuales.Text = "Cambios manuales de audiencia"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 8)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(348, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 72
        Me.txtDescripcion.Text = ""
        '
        'pgbProgreso
        '
        Me.pgbProgreso.Location = New System.Drawing.Point(12, 152)
        Me.pgbProgreso.Name = "pgbProgreso"
        Me.pgbProgreso.Size = New System.Drawing.Size(432, 8)
        Me.pgbProgreso.TabIndex = 74
        '
        'frmActualizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbProgreso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmActualizar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Spots"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Const MedioRadio As Integer = 6
#End Region

    Public Property TerminoOK() As Boolean
        Get
            Return mTerminoOk
        End Get
        Set(ByVal Value As Boolean)
            mTerminoOk = Value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim dts As DataTable
        Dim ret As Boolean

        TerminoOK = False
        Ejecutando = True
        cmdAceptar.Enabled = False
        cmdCancelar.Text = "Cancelar"

        If Sistema.Id_campania = -1 Then
            Sistema.Id_campania = Activo.IDCampaña
            dts = Sistema.ObtenerSistemas

            ret = True
            For Each row As DataRow In dts.Rows
                Sistema.Id_sistema = row("id_sistema")
                Sistema.BuscarPorID()
                Actualizar()
            Next
        Else
            Sistema.Id_campania = Activo.IDCampaña
            Sistema.F_inicio_aud = mF_Desde
            Sistema.F_fin_aud = mF_Hasta
            Sistema.Id_target_1 = mId_Target1
            Sistema.Id_target_2 = mId_Target2
            Sistema.Deflactacion = mDeflactacion
            Actualizar()
        End If

        If TerminoOK Then
            Me.Close()
        End If
    End Sub
    Private Sub Actualizar()
        If Sistema.Id_medio = MedioRadio Then
            Select Case Sistema.Id_tipo_soporte
                Case 1 ' Abierta
                    ActualizarRadio()
            End Select
        Else
            Select Case Sistema.Id_tipo_soporte
                Case 1 ' Abierta
                    ActualizarTVA()
                Case 2 ' Interior
                    ActualizarTVI()
                Case 3 ' Cable
                    ActualizarTVC()
            End Select
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Ejecutando Then
            Ejecutando = False
            cmdAceptar.Enabled = True
            cmdCancelar.Text = "Salir"
            pgbProgreso.Value = 0
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ActualizarRadio()
        Dim S As New Spots
        Dim dtGrilla As DataTable
        Dim dt As DataTable
        Dim Audiencia As New Audiencia_rd
        Dim TT As New Tarifas_tv
        Dim FilaAudiencia As DataRow()
        Dim Procesa As Boolean
        'Dim i As Integer
        Dim antId_Soporte As Integer

        Dim SpotsDetalle As New Spots_detalle
        Dim dsSpotsDetalle As DataSet
        Dim IdSpot As Integer

        S.Id_campania = Sistema.Id_campania
        S.Id_sistema = Sistema.Id_sistema
        S.Id_ejercicio = -1 ' que los traiga todos sin importar el ejercicio.
        dt = S.ObtenerSpots

        If dt.Rows.Count > 0 Then
            pgbProgreso.Maximum = dt.Rows.Count

            antId_Soporte = -1
            For Each rSpot As DataRow In dt.Select("1 = 1", "id_soporte ASC") ' lo ordeno para tener menos accesos.
                Application.DoEvents()
                If Not Ejecutando Then
                    Exit Sub
                End If
                If antId_Soporte <> rSpot("id_soporte") Then
                    dtGrilla = Audiencia.ObtenerAudienciaRadio(rSpot("id_soporte"), Sistema.F_inicio, Sistema.F_fin, Sistema.F_inicio_aud, Sistema.F_fin_aud, Sistema.Id_target_1, Sistema.Id_target_2)
                    antId_Soporte = rSpot("id_soporte")
                End If

                FilaAudiencia = dtGrilla.Select("id_tarifa_tv = " & rSpot("id_tarifa_tv"))
                If Not IsNothing(FilaAudiencia) AndAlso FilaAudiencia.Length > 0 Then ' encontre audiencia
                    Procesa = True
                    If Not chkCambiosManuales.Checked Then
                        If rSpot("Tipo_Planificacion") <> 0 Then
                            Procesa = False
                        End If
                    End If
                    If Not chkEnviadosCompras.Checked OrElse Not chkReprogramados.Checked Then
                        IdSpot = Convert.ToInt32(rSpot("Id_Spot"))
                        dsSpotsDetalle = SpotsDetalle.BuscarPorSpot(IdSpot)
                    End If
                    If Not chkEnviadosCompras.Checked Then
                        If SpotEnviadoaCompras(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If
                    If Not chkReprogramados.Checked Then
                        If SpotReprogramado(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If

                    If Procesa Then
                        S.Id_spot = rSpot("Id_spot")
                        S.BuscarPorID()
                        S.Rat_prog_target_1 = FilaAudiencia(0).Item("PROMEDIO")
                        S.Modificar()
                    End If
                End If
                pgbProgreso.Increment(1)
            Next

        End If

        TerminoOK = True
        Ejecutando = False
        cmdAceptar.Enabled = True
        cmdCancelar.Text = "Salir"
        pgbProgreso.Value = 0
    End Sub

    Private Sub ActualizarTVA()
        Dim S As New Spots
        Dim dtGrilla As DataTable
        Dim dt As DataTable
        Dim Audiencia As New Audiencia_Tva
        Dim TT As New Tarifas_tv
        Dim FilaAudiencia As DataRow()
        Dim Procesa As Boolean
        Dim i As Integer
        Dim antId_Soporte As Integer

        Dim SpotsDetalle As New Spots_detalle
        Dim dsSpotsDetalle As DataSet
        Dim IdSpot As Integer

        S.Id_campania = Sistema.Id_campania
        S.Id_sistema = Sistema.Id_sistema
        S.Id_ejercicio = -1 ' que los traiga todos sin importar el ejercicio.
        dt = S.ObtenerSpots

        pgbProgreso.Maximum = dt.Rows.Count

        antId_Soporte = -1
        For Each rSpot As DataRow In dt.Select("1 = 1", "id_soporte ASC") ' lo ordeno para tener menos accesos.
            Application.DoEvents()
            If Not Ejecutando Then
                Exit Sub
            End If
            If antId_Soporte <> rSpot("id_soporte") Then
                Audiencia.Id_Medio = 1
                Audiencia.Id_Soporte = rSpot("id_soporte")
                dtGrilla = Audiencia.ObtenerAudienciaTVA(mF_Desde, mF_Hasta, mId_Target1, mId_Target2)
                antId_Soporte = rSpot("id_soporte")
            End If

            If IsDBNull(rSpot("id_programa")) OrElse rSpot("id_programa") = 0 Then ' si no tiene id_programa, vuelvo a tarifas_tv a ver si lo agregaron
                TT.Id_tarifa_tv = rSpot("id_tarifa_tv")
                TT.BuscarPorID()
                rSpot("id_programa") = TT.Id_programa
            End If
            If (Not IsDBNull(rSpot("id_programa"))) AndAlso (rSpot("id_programa") <> 0) Then  ' pregunto nuevamente para ver si encontro el id
                FilaAudiencia = dtGrilla.Select("id_programa = " & rSpot("id_programa"))
                If Not IsNothing(FilaAudiencia) Then ' encontre audiencia
                    Procesa = True
                    If Not chkCambiosManuales.Checked Then
                        If rSpot("Tipo_Planificacion") <> 0 Then
                            Procesa = False
                        End If
                    End If
                    If chkEnviadosCompras.Checked OrElse chkReprogramados.Checked Then
                        IdSpot = Convert.ToInt32(rSpot("Id_Spot"))
                        dsSpotsDetalle = SpotsDetalle.BuscarPorSpot(IdSpot)
                    End If
                    If Not chkEnviadosCompras.Checked Then
                        If SpotEnviadoaCompras(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If
                    If Not chkReprogramados.Checked Then
                        If SpotReprogramado(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If

                    If Procesa Then
                        S.Id_spot = rSpot("Id_spot")
                        S.BuscarPorID()
                        S.Id_programa = rSpot("id_programa") ' le fuerzo el id_programa, por si antes no tenia y lo agregaron 
                        For i = 0 To FilaAudiencia.Length - 1 ' pueden venir hasta 4 registros.
                            ' los recorro y analizo para cada uno que debo hacer, porque los tengo todos en una sola fila.
                            If FilaAudiencia(i).Item("id_target") = Sistema.Id_target_1 And FilaAudiencia(i).Item("Programa_Tanda") = "P" Then
                                S.Rat_prog_target_1 = FilaAudiencia(i).Item("rat") * Sistema.Deflactacion
                                S.Shr_prog_target_1 = FilaAudiencia(i).Item("shr") * Sistema.Deflactacion
                                S.Aff_prog_target_1 = FilaAudiencia(i).Item("aff") * Sistema.Deflactacion
                                S.Rch_prog_target_1 = FilaAudiencia(i).Item("rch") * Sistema.Deflactacion
                                S.Rat_m_prog_target_1 = FilaAudiencia(i).Item("rat_m") * Sistema.Deflactacion
                                S.Fid_prog_target_1 = FilaAudiencia(i).Item("fid") * Sistema.Deflactacion
                            End If

                            If FilaAudiencia(i).Item("id_target") = Sistema.Id_target_1 And FilaAudiencia(i).Item("Programa_Tanda") = "T" Then
                                S.Rat_tanda_target_1 = FilaAudiencia(i).Item("rat") * Sistema.Deflactacion
                                S.Shr_tanda_target_1 = FilaAudiencia(i).Item("shr") * Sistema.Deflactacion
                                S.Aff_tanda_target_1 = FilaAudiencia(i).Item("aff") * Sistema.Deflactacion
                                S.Rch_tanda_target_1 = FilaAudiencia(i).Item("rch") * Sistema.Deflactacion
                                S.Rat_m_tanda_target_1 = FilaAudiencia(i).Item("rat_m") * Sistema.Deflactacion
                                S.Fid_tanda_target_1 = FilaAudiencia(i).Item("fid") * Sistema.Deflactacion
                            End If

                            If Sistema.Id_target_2 <> -1 Then ' Tiene target 2
                                If FilaAudiencia(i).Item("id_target") = Sistema.Id_target_2 And FilaAudiencia(i).Item("Programa_Tanda") = "P" Then
                                    S.Rat_prog_target_2 = FilaAudiencia(i).Item("rat") * Sistema.Deflactacion
                                    S.Shr_prog_target_2 = FilaAudiencia(i).Item("shr") * Sistema.Deflactacion
                                    S.Aff_prog_target_2 = FilaAudiencia(i).Item("aff") * Sistema.Deflactacion
                                    S.Rch_prog_target_2 = FilaAudiencia(i).Item("rch") * Sistema.Deflactacion
                                    S.Rat_m_prog_target_2 = FilaAudiencia(i).Item("rat_m") * Sistema.Deflactacion
                                    S.Fid_prog_target_2 = FilaAudiencia(i).Item("fid") * Sistema.Deflactacion
                                End If

                                If FilaAudiencia(i).Item("id_target") = Sistema.Id_target_2 And FilaAudiencia(i).Item("Programa_Tanda") = "T" Then
                                    S.Rat_tanda_target_2 = FilaAudiencia(i).Item("rat") * Sistema.Deflactacion
                                    S.Shr_tanda_target_2 = FilaAudiencia(i).Item("shr") * Sistema.Deflactacion
                                    S.Aff_tanda_target_2 = FilaAudiencia(i).Item("aff") * Sistema.Deflactacion
                                    S.Rch_tanda_target_2 = FilaAudiencia(i).Item("rch") * Sistema.Deflactacion
                                    S.Rat_m_tanda_target_2 = FilaAudiencia(i).Item("rat_m") * Sistema.Deflactacion
                                    S.Fid_tanda_target_2 = FilaAudiencia(i).Item("fid") * Sistema.Deflactacion
                                End If
                            Else ' si no tiene target 2 lo limpio por las dudas.
                                S.Rat_prog_target_2 = 0
                                S.Shr_prog_target_2 = 0
                                S.Aff_prog_target_2 = 0
                                S.Rch_prog_target_2 = 0
                                S.Rat_m_prog_target_2 = 0
                                S.Fid_prog_target_2 = 0

                                S.Rat_tanda_target_2 = 0
                                S.Shr_tanda_target_2 = 0
                                S.Aff_tanda_target_2 = 0
                                S.Rch_tanda_target_2 = 0
                                S.Rat_m_tanda_target_2 = 0
                                S.Fid_tanda_target_2 = 0
                            End If
                        Next
                        If FilaAudiencia.Length > 1 Then
                            S.Modificar()
                        End If
                    End If
                End If
            End If
            pgbProgreso.Increment(1)
        Next
        TerminoOK = True
        Ejecutando = False
        cmdAceptar.Enabled = True
        cmdCancelar.Text = "Salir"
        pgbProgreso.Value = 0
    End Sub

    Private Sub ActualizarTVC()
        Dim S As New Spots
        Dim dtGrilla As DataTable
        Dim dt As DataTable
        Dim Audiencia As New Audiencia_tvc
        Dim TT As New Tarifas_tv
        Dim FilaAudiencia As DataRow()
        Dim Procesa As Boolean
        'Dim i As Integer
        Dim antId_Soporte As Integer

        Dim SpotsDetalle As New Spots_detalle
        Dim dsSpotsDetalle As DataSet
        Dim IdSpot As Integer

        S.Id_campania = Sistema.Id_campania
        S.Id_sistema = Sistema.Id_sistema
        S.Id_ejercicio = -1 ' que los traiga todos sin importar el ejercicio.
        dt = S.ObtenerSpots

        If dt.Rows.Count > 0 Then
            Dim f As New frmCargarAudienciaTVC
            f.Sistema = Sistema
            f.EstaAgregandoProgramacion = False
            f.Soportes = GetSoportes(dt)
            f.ShowDialog()

            pgbProgreso.Maximum = dt.Rows.Count

            antId_Soporte = -1
            For Each rSpot As DataRow In dt.Select("1 = 1", "id_soporte ASC") ' lo ordeno para tener menos accesos.
                Application.DoEvents()
                If Not Ejecutando Then
                    Exit Sub
                End If
                If antId_Soporte <> rSpot("id_soporte") Then
                    Audiencia.Id_medio = 1
                    Audiencia.Id_soporte = rSpot("id_soporte")
                    dtGrilla = Audiencia.ObtenerAudienciaTVC(mF_Desde, mF_Hasta, mId_Target1, mId_Target2)
                    antId_Soporte = rSpot("id_soporte")
                End If

                FilaAudiencia = dtGrilla.Select("id_tarifa_tv = " & rSpot("id_tarifa_tv"))
                If Not IsNothing(FilaAudiencia) AndAlso FilaAudiencia.Length > 0 Then ' encontre audiencia
                    Procesa = True
                    If Not chkCambiosManuales.Checked Then
                        If rSpot("Tipo_Planificacion") <> 0 Then
                            Procesa = False
                        End If
                    End If
                    If Not chkEnviadosCompras.Checked OrElse Not chkReprogramados.Checked Then
                        IdSpot = Convert.ToInt32(rSpot("Id_Spot"))
                        dsSpotsDetalle = SpotsDetalle.BuscarPorSpot(IdSpot)
                    End If
                    If Not chkEnviadosCompras.Checked Then
                        If SpotEnviadoaCompras(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If
                    If Not chkReprogramados.Checked Then
                        If SpotReprogramado(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If

                    If Procesa Then
                        S.Id_spot = rSpot("Id_spot")
                        S.BuscarPorID()
                        S.Rat_prog_target_1 = FilaAudiencia(0).Item("rating 1") * Sistema.Deflactacion
                        S.Rat_prog_target_2 = FilaAudiencia(0).Item("rating 2") * Sistema.Deflactacion
                        S.Modificar()
                    End If
                End If
                pgbProgreso.Increment(1)
            Next

        End If

        TerminoOK = True
        Ejecutando = False
        cmdAceptar.Enabled = True
        cmdCancelar.Text = "Salir"
        pgbProgreso.Value = 0
    End Sub

    Private Sub ActualizarTVI()
        Dim S As New Spots
        Dim dtGrilla As DataTable
        Dim dt As DataTable
        Dim Audiencia As New Audiencia_TVI
        Dim TT As New Tarifas_tv
        Dim FilaAudiencia As DataRow()
        Dim Procesa As Boolean
        Dim i As Integer
        Dim antId_Soporte As Integer

        Dim SpotsDetalle As New Spots_detalle
        Dim dsSpotsDetalle As DataSet
        Dim IdSpot As Integer

        S.Id_campania = Sistema.Id_campania
        S.Id_sistema = Sistema.Id_sistema
        S.Id_ejercicio = -1 ' que los traiga todos sin importar el ejercicio.
        dt = S.ObtenerSpots

        If dt.Rows.Count > 0 Then
            Dim f As New frmCargarAudienciaTVI
            f.Sistema = Sistema
            f.EstaAgregandoProgramacion = False
            f.Soportes = GetSoportes(dt)
            f.ShowDialog()
            pgbProgreso.Maximum = dt.Rows.Count

            antId_Soporte = -1
            For Each rSpot As DataRow In dt.Select("1 = 1", "id_soporte ASC") ' lo ordeno para tener menos accesos.
                Application.DoEvents()
                If Not Ejecutando Then
                    Exit Sub
                End If
                If antId_Soporte <> rSpot("id_soporte") Then
                    Audiencia.Id_Medio = 1
                    Audiencia.Id_Soporte = rSpot("id_soporte")
                    dtGrilla = Audiencia.ObtenerAudienciaTVI(mF_Desde, mF_Hasta, mId_Target1, mId_Target2)
                    antId_Soporte = rSpot("id_soporte")
                End If

                FilaAudiencia = dtGrilla.Select("id_tarifa_tv = " & rSpot("id_tarifa_tv"))
                If Not IsNothing(FilaAudiencia) AndAlso FilaAudiencia.Length > 0 Then ' encontre audiencia                    Procesa = True
                    Procesa = True
                    If Not chkCambiosManuales.Checked Then
                        If rSpot("Tipo_Planificacion") <> 0 Then
                            Procesa = False
                        End If
                    End If
                    If chkEnviadosCompras.Checked OrElse chkReprogramados.Checked Then
                        IdSpot = Convert.ToInt32(rSpot("Id_Spot"))
                        dsSpotsDetalle = SpotsDetalle.BuscarPorSpot(IdSpot)
                    End If
                    If Not chkEnviadosCompras.Checked Then
                        If SpotEnviadoaCompras(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If
                    If Not chkReprogramados.Checked Then
                        If SpotReprogramado(rSpot, dsSpotsDetalle) Then
                            Procesa = False
                        End If
                    End If

                    If Procesa Then
                        S.Id_spot = rSpot("Id_spot")
                        S.BuscarPorID()
                        S.Rat_prog_target_1 = FilaAudiencia(0).Item("rating 1") * Sistema.Deflactacion
                        S.Rat_prog_target_2 = FilaAudiencia(0).Item("rating 2") * Sistema.Deflactacion
                        S.Modificar()
                    End If
                End If
                pgbProgreso.Increment(1)
            Next
        End If
        TerminoOK = True
        Ejecutando = False
        cmdAceptar.Enabled = True
        cmdCancelar.Text = "Salir"
        pgbProgreso.Value = 0
    End Sub

    Private Function GetSoportes(ByVal dt As DataTable) As Long()
        Dim ar() As Long
        Dim antSoporte As Long

        antSoporte = -1
        For Each row As DataRow In dt.Select("1 = 1", "id_soporte ASC")
            If antSoporte <> row("id_soporte") Then
                If IsNothing(ar) Then
                    ReDim ar(0)
                Else
                    ReDim Preserve ar(ar.Length)
                End If
                ar(ar.Length - 1) = row("id_soporte")
                antSoporte = ar(ar.Length - 1)
            End If
        Next

        GetSoportes = ar

    End Function

    Private Function SpotEnviadoaCompras(ByVal row As DataRow, ByVal SpotsDetalle As DataSet) As Boolean
        ' Verificar como veo que esta enviado a compras
        Dim EnviadoCompra As Boolean = False

        If Not SpotsDetalle Is Nothing AndAlso Not SpotsDetalle.Tables(0) Is Nothing Then
            For Each drSpotsDetalle As DataRow In SpotsDetalle.Tables(0).Select("Id_Spot_Estado = 'C'")
                EnviadoCompra = True
                Exit For
            Next
        End If

        SpotEnviadoaCompras = EnviadoCompra
    End Function

    Private Function SpotReprogramado(ByVal row As DataRow, ByVal SpotsDetalle As DataSet) As Boolean
        ' Verificar como veo que esta enviado a compras
        Dim Reprogramado As Boolean = False

        If Not SpotsDetalle Is Nothing AndAlso Not SpotsDetalle.Tables(0) Is Nothing Then
            For Each drSpotsDetalle As DataRow In SpotsDetalle.Tables(0).Select("Id_Spot_Estado = 'S'")
                Reprogramado = True
                Exit For
            Next
        End If

        SpotReprogramado = Reprogramado
    End Function
End Class

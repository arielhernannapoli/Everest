Public Class abmEjercicios
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
    Friend WithEvents txtObservaciones As QUETOOL.txtTexto
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents fraObservacion As System.Windows.Forms.GroupBox
    Friend WithEvents fraDescripcion As System.Windows.Forms.GroupBox
    Friend WithEvents fraSoporte As System.Windows.Forms.GroupBox
    Friend WithEvents lstSoporte As QUETOOL.lstLista
    Friend WithEvents lbltarifa As System.Windows.Forms.Label
    Friend WithEvents chkTipoEjercicio As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPlanificar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.fraObservacion = New System.Windows.Forms.GroupBox
        Me.txtObservaciones = New QUETOOL.txtTexto
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.fraDescripcion = New System.Windows.Forms.GroupBox
        Me.cmdPlanificar = New System.Windows.Forms.Button
        Me.fraSoporte = New System.Windows.Forms.GroupBox
        Me.lstSoporte = New QUETOOL.lstLista
        Me.lbltarifa = New System.Windows.Forms.Label
        Me.chkTipoEjercicio = New System.Windows.Forms.CheckBox
        Me.fraObservacion.SuspendLayout()
        Me.fraDescripcion.SuspendLayout()
        Me.fraSoporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraObservacion
        '
        Me.fraObservacion.Controls.Add(Me.txtObservaciones)
        Me.fraObservacion.Enabled = False
        Me.fraObservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraObservacion.Location = New System.Drawing.Point(0, 271)
        Me.fraObservacion.Name = "fraObservacion"
        Me.fraObservacion.Size = New System.Drawing.Size(418, 80)
        Me.fraObservacion.TabIndex = 1
        Me.fraObservacion.TabStop = False
        Me.fraObservacion.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.ConDecimal = False
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 20)
        Me.txtObservaciones.Maximo = 0
        Me.txtObservaciones.MaxLength = 400
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(400, 48)
        Me.txtObservaciones.SoloLetra = False
        Me.txtObservaciones.SoloNumero = False
        Me.txtObservaciones.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 20)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(278, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 0
        '
        'fraDescripcion
        '
        Me.fraDescripcion.Controls.Add(Me.cmdPlanificar)
        Me.fraDescripcion.Controls.Add(Me.txtDescripcion)
        Me.fraDescripcion.Enabled = False
        Me.fraDescripcion.Location = New System.Drawing.Point(0, 4)
        Me.fraDescripcion.Name = "fraDescripcion"
        Me.fraDescripcion.Size = New System.Drawing.Size(418, 52)
        Me.fraDescripcion.TabIndex = 0
        Me.fraDescripcion.TabStop = False
        Me.fraDescripcion.Text = "Descripción"
        '
        'cmdPlanificar
        '
        Me.cmdPlanificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPlanificar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlanificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdPlanificar.Location = New System.Drawing.Point(296, 20)
        Me.cmdPlanificar.Name = "cmdPlanificar"
        Me.cmdPlanificar.Size = New System.Drawing.Size(112, 21)
        Me.cmdPlanificar.TabIndex = 1
        Me.cmdPlanificar.Text = "Planificación"
        '
        'fraSoporte
        '
        Me.fraSoporte.Controls.Add(Me.lstSoporte)
        Me.fraSoporte.Enabled = False
        Me.fraSoporte.Location = New System.Drawing.Point(0, 91)
        Me.fraSoporte.Name = "fraSoporte"
        Me.fraSoporte.Size = New System.Drawing.Size(418, 176)
        Me.fraSoporte.TabIndex = 3
        Me.fraSoporte.TabStop = False
        Me.fraSoporte.Text = "Soportes"
        '
        'lstSoporte
        '
        Me.lstSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSoporte.Location = New System.Drawing.Point(12, 20)
        Me.lstSoporte.Name = "lstSoporte"
        Me.lstSoporte.Size = New System.Drawing.Size(400, 145)
        Me.lstSoporte.TabIndex = 0
        '
        'lbltarifa
        '
        Me.lbltarifa.AutoSize = True
        Me.lbltarifa.Location = New System.Drawing.Point(21, 68)
        Me.lbltarifa.Name = "lbltarifa"
        Me.lbltarifa.Size = New System.Drawing.Size(397, 13)
        Me.lbltarifa.TabIndex = 7
        Me.lbltarifa.Text = "Ejercicio Tipo negociacion ( No se envia a Compras, No se Actualzian las Tarifas." & _
            " )"
        '
        'chkTipoEjercicio
        '
        Me.chkTipoEjercicio.AutoSize = True
        Me.chkTipoEjercicio.Enabled = False
        Me.chkTipoEjercicio.Location = New System.Drawing.Point(3, 67)
        Me.chkTipoEjercicio.Name = "chkTipoEjercicio"
        Me.chkTipoEjercicio.Size = New System.Drawing.Size(15, 14)
        Me.chkTipoEjercicio.TabIndex = 6
        Me.chkTipoEjercicio.UseVisualStyleBackColor = True
        '
        'abmEjercicios
        '
        Me.Controls.Add(Me.lbltarifa)
        Me.Controls.Add(Me.chkTipoEjercicio)
        Me.Controls.Add(Me.fraSoporte)
        Me.Controls.Add(Me.fraDescripcion)
        Me.Controls.Add(Me.fraObservacion)
        Me.Name = "abmEjercicios"
        Me.Size = New System.Drawing.Size(424, 362)
        Me.fraObservacion.ResumeLayout(False)
        Me.fraObservacion.PerformLayout()
        Me.fraDescripcion.ResumeLayout(False)
        Me.fraDescripcion.PerformLayout()
        Me.fraSoporte.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Ejercicio As New Ejercicios
    Dim FechaAlta As Date
    Dim mModificar As Boolean
    Dim mDebeGuardar As Boolean

    Public Property DebeGuardar() As Boolean Implements Framework.IABM.DebeGuardar
        Get
            Return mDebeGuardar
        End Get
        Set(ByVal Value As Boolean)
            mDebeGuardar = Value
        End Set
    End Property

    Public Property Modificar() As Boolean Implements Framework.IABM.Modificar
        Get
            Return mModificar
        End Get
        Set(ByVal Value As Boolean)
            mModificar = Value
        End Set
    End Property

    Public Sub Guardar() Implements IABM.Guardar
        If Not Me.fraDescripcion.Enabled Then
            Exit Sub
        End If

        If Not Me.CargarObjeto() Then
            Exit Sub
        End If

        If Not Me.Modificar Then
            Activo.IDEjercicio = Ejercicio.Agregar()
            'AG 05/06/2014 ===================
            If Me.chkTipoEjercicio.Checked = True Then
                Me.chkTipoEjercicio.Enabled = False
            End If
            '=================================
        Else
            Ejercicio.Modificar()
            'AG 05/06/2014 ===================
            If Me.chkTipoEjercicio.Checked = True Then
                Me.chkTipoEjercicio.Enabled = False
            End If
            '=================================
        End If

        Me.Modificar = True
        Me.DebeGuardar = False
        Me.cmdPlanificar.Enabled = True


    End Sub

    Public Sub Cargar() Implements IABM.Cargar
        Try
            With Ejercicio
                Me.fraDescripcion.Enabled = True
                Me.fraObservacion.Enabled = True
                Me.fraSoporte.Enabled = True

                'AG 05/06/2014 ======================================================
                If Activo.IDMedio = Medios.Tv Or Activo.IDMedio = Medios.Radio Then
                    Me.chkTipoEjercicio.Visible = True
                    Me.lbltarifa.Visible = True
                Else
                    Me.chkTipoEjercicio.Visible = False
                    Me.lbltarifa.Visible = False
                End If
                '====================================================================

                .Id_campania = Activo.IDCampaña
                .Id_sistema = Activo.IDSistema
                .Id_ejercicio = Activo.IDEjercicio

                .BuscarPorID()

                Activo.IDEjercicio = .Id_ejercicio
                Activo.Ejercicio = .Descripcion
                FechaAlta = .F_alta

                'AG 05/06/2014 ============================
                Activo.IDTipoEjercicio = .IDTipoEjercicio
                If Activo.IDTipoEjercicio = 1 Then
                    Me.chkTipoEjercicio.Checked = True
                    Me.chkTipoEjercicio.Enabled = False
                Else
                    Me.chkTipoEjercicio.Checked = False
                    Me.chkTipoEjercicio.Enabled = True
                End If
                '===========================================

                Me.txtDescripcion.Text = .Descripcion
                Me.txtObservaciones.Text = .Observacion
            End With

            Me.CargarSoportesSpots()

            Me.cmdPlanificar.Enabled = True
        Catch ex As EjercicioInexistenteExcepcion
            Mensajes.Mensaje(ex.Message)
        End Try

        Me.DebeGuardar = False
    End Sub

    Protected Function CargarObjeto() As Boolean Implements IABM.CargarObjeto
        With Me
            If Me.txtDescripcion.Text.Trim = "" Then
                Mensajes.Mensaje("Debe Ingresar la Descripción")
                txtDescripcion.Select()
                Return False
            End If

            Ejercicio.Id_ejercicio = Activo.IDEjercicio
            Ejercicio.Descripcion = txtDescripcion.Text

            Ejercicio.Id_campania = Activo.IDCampaña
            Ejercicio.Id_sistema = Activo.IDSistema

            Ejercicio.Observacion = .txtObservaciones.Text

            Ejercicio.U_alta = Activo.Login
            Ejercicio.U_modi = Activo.Login

            Ejercicio.F_alta = FechaAlta
            Ejercicio.F_modi = Date.Today

            'AG 05/06/2014 =======================
            If Me.chkTipoEjercicio.Checked = True Then
                'Ejercicio.Id_ejercicio_est = 1
                Ejercicio.IDTipoEjercicio = 1
            Else
                Ejercicio.IDTipoEjercicio = 0
            End If
            '=====================================

            Return True
        End With
    End Function

    Public Sub LimpiarControles() Implements IABM.LimpiarControles
        Dim L As New LimpiarObjetoTexto(Me)

        L.LimpiarTextos()

        Me.fraDescripcion.Enabled = True
        Me.fraObservacion.Enabled = True
        Me.fraSoporte.Enabled = True
        Me.lstSoporte.Items.Clear()
        'AG 05/06/2014 ====================
        Me.chkTipoEjercicio.Enabled = True
        '==================================

        Me.cmdPlanificar.Enabled = False

        txtDescripcion.Select()
        'frmprincipal.Instancia.treSistema.


    End Sub

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

    Public Sub Cancelar() Implements Framework.IABM.Cancelar
        Me.txtDescripcion.Text = ""
        Me.txtObservaciones.Text = ""
        Me.lstSoporte.Items.Clear()

        Me.fraDescripcion.Enabled = False
        Me.fraObservacion.Enabled = False
        Me.fraSoporte.Enabled = False
        'AG 05/06/2014 ========================
        Me.chkTipoEjercicio.Enabled = False
        Me.chkTipoEjercicio.Checked = False
        '=====================================
    End Sub

    Public Sub CargarSoportesSpots()
        Ejercicio.Id_campania = Activo.IDCampaña
        Ejercicio.Id_sistema = Activo.IDSistema
        Ejercicio.Id_ejercicio = Activo.IDEjercicio

        Listas.CargarList(Me.lstSoporte, Ejercicio.ObtenerSoportesSpots, "id_soporte", "Descripcion")
    End Sub

    Private Sub fraDescripcion_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fraDescripcion.EnabledChanged
        'se pone NOT porque el Enable cambia despues de pasar por el evento
        If Not Me.fraSoporte.Enabled Then
            Me.lstSoporte.BackColor = System.Drawing.SystemColors.Window
            Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
            Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Else
            Me.lstSoporte.BackColor = System.Drawing.SystemColors.InactiveBorder
            Me.txtDescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder
            Me.txtObservaciones.BackColor = System.Drawing.SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub txtObservaciones_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservaciones.Leave
        If Me.fraObservacion.Enabled Then
            Me.txtObservaciones.BackColor = SystemColors.Window
        Else
            Me.txtObservaciones.BackColor = SystemColors.InactiveBorder
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        DebeGuardar = True
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        DebeGuardar = True
    End Sub

    Private Sub cmdPlanificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlanificar.Click
        Dim G As New Grilla
        Dim Ejer As EjercicioActivo
        Ejer.IDCampaña = Activo.IDCampaña
        Ejer.IDSistema = Activo.IDSistema
        Ejer.IDEjercicio = Activo.IDEjercicio

        If G.ComprobarEjercicioActivo(Ejer) Then
            Mensajes.Mensaje("Ya Existe un Ejercicio Activo", TipoMensaje.Informacion)
            Exit Sub
        End If

        'AG CP +++++++++++++++++++++++++++++++++++++++++
        Dim TEjercicio As Integer
        If Activo.TEjecicioActivo = Activo.TipoEjercicio.Estandar Then
            TEjercicio = Activo.TipoEjercicio.Estandar
        Else
            TEjercicio = Activo.TipoEjercicio.CPunto
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++

        'Select Case Activo.IDMedio
        '    Case 1, 6
        'G.Cargar(True, Activo.IDTipoSoporte - 1)
        '    Case 3, 4, 5
        'G.Cargar(Activo.IDMedio)
        'End Select

        Select Case Activo.IDMedio
            Case 1, 6
                Select Case Activo.IDTipoSoporte
                    Case 1
                        G.Cargar(True, TipoAudiencia.Abierta, TEjercicio)
                    Case 2
                        G.Cargar(True, TipoAudiencia.Intetior, TEjercicio)
                    Case 3
                        G.Cargar(True, TipoAudiencia.Cable, TEjercicio)
                    Case 4
                        G.Cargar(True, TipoAudiencia.Satelital, TEjercicio)
                    Case 5
                        G.Cargar(True, TipoAudiencia.Cable, TEjercicio)
                End Select
            Case 3, 4, 5, 7 'AG Produccion +++++++++++++++++++++
                Select Case Activo.IDTipoSoporte
                    Case 1
                        G.Cargar(Activo.IDMedio)
                    Case 2
                        G.Cargar(Activo.IDMedio)
                    Case 3
                        G.Cargar(Activo.IDMedio)
                End Select
            Case 2
                'AG 22/10/2013 DIGITAL =======================
                G.CargarInternet(Activo.IDMedio)
                '=============================================

        End Select

        'Select Case Activo.IDTipoSoporte
        '    Case 1
        'G.Cargar(TipoAudiencia.Abierta)
        '    Case 2
        'G.Cargar(TipoAudiencia.Intetior)
        '    Case 3
        'G.Cargar(TipoAudiencia.Cable)
        '    Case 4
        'G.Cargar(TipoAudiencia.Satelital)
        'End Select


        'Select Case Activo.IDTipoSoporte
        '    Case 1
        'G.CargarOtrosMedios()
        '    Case 2
        'G.Cargar(TipoAudiencia.Intetior)

        '    Case 3
        'G.Cargar(TipoAudiencia.Cable)
        '    Case 4
        'G.Cargar(TipoAudiencia.Satelital)
        'End Select
    End Sub
    Public Sub ControlarTemas()
        Dim t As New Temas
        t.Id_campania = Activo.IDCampaña
        If t.ObtenerTemasPorCampaña.Rows.Count <= 0 Then
            cmdPlanificar.Enabled = False
        Else
            cmdPlanificar.Enabled = True
        End If
    End Sub

   
  
End Class

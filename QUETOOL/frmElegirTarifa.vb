Public Class frmElegirTarifa
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents txtCodigo As QUETOOL.txtTexto
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDescSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtIDSoporte As QUETOOL.txtTexto
    Friend WithEvents chkVigentes As QUETOOL.chkCheck
    Friend WithEvents dtpFecha As QUETOOL.dtpFecha
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboMedio As QUETOOL.cboCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmElegirTarifa))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.txtCodigo = New QUETOOL.txtTexto
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CboMedio = New QUETOOL.cboCombo
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtDescSoporte = New QUETOOL.txtTexto
        Me.TxtIDSoporte = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkVigentes = New QUETOOL.chkCheck
        Me.dtpFecha = New QUETOOL.dtpFecha
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(88, 48)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(244, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TabStop = False
        Me.txtDescripcion.Text = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ConDecimal = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(88, 16)
        Me.txtCodigo.Maximo = 0
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(220, 21)
        Me.txtCodigo.SoloLetra = False
        Me.txtCodigo.SoloNumero = True
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = ""
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(176, 224)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(312, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(272, 224)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboMedio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtDescSoporte)
        Me.GroupBox2.Controls.Add(Me.TxtIDSoporte)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 104)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Soporte"
        '
        'CboMedio
        '
        Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboMedio.DisplayMember = ""
        Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedio.Location = New System.Drawing.Point(80, 24)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(245, 21)
        Me.CboMedio.TabIndex = 77
        Me.CboMedio.Tag = ""
        Me.CboMedio.ValueMember = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Medio"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(304, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDescSoporte
        '
        Me.TxtDescSoporte.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDescSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescSoporte.ConDecimal = False
        Me.TxtDescSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescSoporte.Location = New System.Drawing.Point(80, 72)
        Me.TxtDescSoporte.Maximo = 0
        Me.TxtDescSoporte.Name = "TxtDescSoporte"
        Me.TxtDescSoporte.ReadOnly = True
        Me.TxtDescSoporte.Size = New System.Drawing.Size(244, 21)
        Me.TxtDescSoporte.SoloLetra = False
        Me.TxtDescSoporte.SoloNumero = False
        Me.TxtDescSoporte.TabIndex = 10
        Me.TxtDescSoporte.TabStop = False
        Me.TxtDescSoporte.Text = ""
        '
        'TxtIDSoporte
        '
        Me.TxtIDSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIDSoporte.ConDecimal = False
        Me.TxtIDSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDSoporte.Location = New System.Drawing.Point(80, 48)
        Me.TxtIDSoporte.Maximo = 0
        Me.TxtIDSoporte.MaxLength = 4
        Me.TxtIDSoporte.Name = "TxtIDSoporte"
        Me.TxtIDSoporte.Size = New System.Drawing.Size(220, 21)
        Me.TxtIDSoporte.SoloLetra = False
        Me.TxtIDSoporte.SoloNumero = True
        Me.TxtIDSoporte.TabIndex = 4
        Me.TxtIDSoporte.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripción"
        '
        'chkVigentes
        '
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVigentes.Location = New System.Drawing.Point(16, 200)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(136, 24)
        Me.chkVigentes.TabIndex = 9
        Me.chkVigentes.Text = "Solo vigentes:"
        '
        'dtpFecha
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFecha.Appearance = Appearance1
        Me.dtpFecha.FlatMode = True
        Me.dtpFecha.Location = New System.Drawing.Point(32, 224)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 21)
        Me.dtpFecha.TabIndex = 15
        '
        'frmElegirTarifa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(362, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.chkVigentes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmElegirTarifa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Tarifas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'es para que el form que llama, sepa si se apreto cancelar
    Public Cancelar As Boolean
    Private mPopularCliente As Boolean = False
    Private mMedioSeleccionado As Integer

    'es para saber si esta cargando por 1ra vez o se esta cambiando de cliente
    Public CargandoPrimeraVez As Boolean

    Shared vIDMedio As Integer
    Shared vIDCliente As Integer
    Shared vIDSoporte As Integer
    Shared vDescCliente As String
    Shared vDescSoporte As String
    Shared vSoloVigente As Boolean
    Shared mDescripcionMedioSeleccionado As String



    Public Shared Property idmedio() As Integer
        Get
            Return vIDMedio
        End Get
        Set(ByVal value As Integer)
            vIDMedio = value
        End Set
    End Property
    Public Shared Property SoloVigentes() As Boolean
        Get
            Return vSoloVigente
        End Get
        Set(ByVal value As Boolean)
            vSoloVigente = value
        End Set
    End Property
    Public Shared Property idCliente() As Integer
        Get
            Return vIDCliente
        End Get
        Set(ByVal Value As Integer)
            vIDCliente = Value
        End Set
    End Property

    Public Shared Property idSoporte() As Integer
        Get
            Return vIDSoporte
        End Get
        Set(ByVal Value As Integer)
            vIDSoporte = Value
        End Set
    End Property

    Public Shared Property DescripcionCliente() As String
        Get
            Return vDescCliente
        End Get
        Set(ByVal Value As String)
            vDescCliente = Value
        End Set
    End Property

    Public Shared Property DescripcionSoporte() As String
        Get
            Return vDescSoporte
        End Get
        Set(ByVal Value As String)
            vDescSoporte = Value
        End Set
    End Property

    Public WriteOnly Property PopularCliente() As Boolean
        Set(ByVal Value As Boolean)
            mPopularCliente = Value
        End Set
    End Property

    Public Property MedioSeleccionado() As Integer
        Get
            Return CboMedio.Value
        End Get
        Set(ByVal Value As Integer)
            mMedioSeleccionado = Value
        End Set
    End Property

    Public Property DescripcionMedioSeleccionado() As String
        Get
            Return mDescripcionMedioSeleccionado
        End Get
        Set(ByVal Value As String)
            mDescripcionMedioSeleccionado = Value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If txtCodigo.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Cliente")
            txtCodigo.Select()
            Exit Sub
        End If

        If TxtIDSoporte.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Soporte")
            TxtIDSoporte.Select()
            Exit Sub
        End If

        Me.idCliente = txtCodigo.Text
        Me.idSoporte = TxtIDSoporte.Text
        Me.DescripcionCliente = txtDescripcion.Text
        Me.DescripcionSoporte = TxtDescSoporte.Text
        Me.SoloVigentes = chkVigentes.Checked
        Me.idmedio = Activo.IDMedio
        Me.DescripcionMedioSeleccionado = CboMedio.Text
        Cancelar = False
        Me.Hide()


    End Sub

    Private Sub BuscarCliente()
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Cliente, txtDescripcion, txtCodigo, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()
    End Sub

    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarCliente()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub txtCodigo_SePresionoBarra() Handles txtCodigo.SePresionoBarra
        BuscarCliente()
    End Sub

    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated
        If txtCodigo.Text <> "" Then
            Dim C As New Clientes
            Dim U As New Usuario

            'C.Id_cliente = txtCodigo.Text

            Try
                C.BuscarPorID()

                U.IDPerfil_Datos = Activo.IDPerfil_Datos
                txtDescripcion.Text = U.ObtenerDescripcion(txtCodigo.Text)

                If txtDescripcion.Text = "" Then
                    Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                    txtCodigo.Text = ""
                    txtCodigo.Select()
                    Exit Sub
                End If

            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try

            'txtDescripcion.Text = C.Descripcion
        End If
    End Sub




    Private Sub frmElegirCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Activo.IDMedio = 1
        'dtpFecha.DateTime = Now.Date
        Call CargarMedios()
        If CargandoPrimeraVez Then
            cmdCancelar.Visible = False

            cmdAceptar.Left = cmdCancelar.Left
            cmdAceptar.Top = cmdCancelar.Top
        End If
        If mPopularCliente Then
            txtCodigo.Text = idCliente
            Call txtCodigo_Validated(Nothing, Nothing)
            txtCodigo.Enabled = False
            Label3.Enabled = False
            txtDescripcion.Enabled = False
            Call Combo_Position(CboMedio, "Id_Medio", mMedioSeleccionado)
        End If
    End Sub

    Private Sub CargarMedios()
        Dim Medio As New Soportes
        Listas.CargarCombo(Me.CboMedio, Medio.ObtenerMediosActivos, "Id_Medio", "descripcion")

        Listas.OcultarColumnas(CboMedio, "Id_Medio")
        Listas.OcultarHeader(CboMedio)
        CboMedio.SelectedRow = CboMedio.Rows(0)
    End Sub

    Private Sub Combo_Position(ByVal pCombo As cboCombo, ByVal pColumnName As String, ByVal pValue As String)
        For Each Row As Infragistics.Win.UltraWinGrid.UltraGridRow In pCombo.Rows
            If Not Row.Cells(pColumnName).Value Is DBNull.Value Then
                If pColumnName = String.Empty Then
                    If Row.Cells(pColumnName).Value = pValue Then
                        pCombo.SelectedRow = Row
                        Exit Sub
                    End If
                Else
                    If Row.Cells(pColumnName).Value = pValue Then
                        pCombo.SelectedRow = Row
                        Exit Sub
                    End If
                End If
            End If
        Next
        pCombo.SelectedRow = pCombo.Rows(0)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar = True

        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        BuscarCliente()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Soporte, TxtDescSoporte, TxtIDSoporte, "id_soporte", "descripcion", "Código", "Soporte", Activo.IDMedio)

        F.ShowDialog()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub TxtIDSoporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIDSoporte.TextChanged

    End Sub

    Private Sub TxtIDSoporte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIDSoporte.Validated
        If TxtIDSoporte.Text <> "" Then

            Dim s As New Soportes
            s.Id_soporte = TxtIDSoporte.Text

            Try

                s.Id_medio = Activo.IDMedio
                TxtDescSoporte.Text = s.ObtenerDescripcion(TxtIDSoporte.Text)

                If TxtDescSoporte.Text = "" Then
                    Mensajes.Mensaje("El soporte No Existe ")
                    TxtIDSoporte.Text = ""
                    TxtIDSoporte.Select()
                    Exit Sub
                End If

            Catch ex As Exception

                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try

            'txtDescripcion.Text = C.Descripcion
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub TxtDescSoporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescSoporte.TextChanged

    End Sub

    Private Sub CboMedio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.ValueChanged
        Activo.IDMedio = CboMedio.Value
        TxtIDSoporte.Text = String.Empty
        TxtDescSoporte.Text = String.Empty
    End Sub
End Class


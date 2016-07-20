Public Class frmFiltroCalendario
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    'Public Sub New()
    '    MyBase.New()

    '    'El Diseñador de Windows Forms requiere esta llamada.
    '    InitializeComponent()

    '    'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    'End Sub

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaHasta As QUETOOL.dtpFecha
    Friend WithEvents chkIVA As QUETOOL.chkCheck
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents fraIva As System.Windows.Forms.GroupBox
    Friend WithEvents optSoloAgencia As QUETOOL.optOpcion
    Friend WithEvents optNetoAgencia As QUETOOL.optOpcion
    Friend WithEvents fraSemana As System.Windows.Forms.GroupBox
    Friend WithEvents OptOpcion1 As QUETOOL.optOpcion
    Friend WithEvents fraMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents OptNumeros As QUETOOL.optOpcion
    Friend WithEvents OptLetras As QUETOOL.optOpcion
    Friend WithEvents OptNatural As QUETOOL.optOpcion
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.fraIva = New System.Windows.Forms.GroupBox
        Me.fraSemana = New System.Windows.Forms.GroupBox
        Me.OptOpcion1 = New QUETOOL.optOpcion
        Me.OptNatural = New QUETOOL.optOpcion
        Me.optSoloAgencia = New QUETOOL.optOpcion
        Me.optNetoAgencia = New QUETOOL.optOpcion
        Me.chkIVA = New QUETOOL.chkCheck
        Me.dtpFechaHasta = New QUETOOL.dtpFecha
        Me.dtpFechaDesde = New QUETOOL.dtpFecha
        Me.fraMaterial = New System.Windows.Forms.GroupBox
        Me.OptNumeros = New QUETOOL.optOpcion
        Me.OptLetras = New QUETOOL.optOpcion
        Me.fraIva.SuspendLayout()
        Me.fraSemana.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Hasta"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(188, 327)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 24)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(104, 327)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 24)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(-140, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(624, 2)
        Me.Label3.TabIndex = 11
        '
        'fraIva
        '
        Me.fraIva.Controls.Add(Me.optSoloAgencia)
        Me.fraIva.Controls.Add(Me.optNetoAgencia)
        Me.fraIva.Controls.Add(Me.chkIVA)
        Me.fraIva.Location = New System.Drawing.Point(8, 187)
        Me.fraIva.Name = "fraIva"
        Me.fraIva.Size = New System.Drawing.Size(260, 132)
        Me.fraIva.TabIndex = 12
        Me.fraIva.TabStop = False
        Me.fraIva.Text = "IVA"
        '
        'fraSemana
        '
        Me.fraSemana.Controls.Add(Me.OptOpcion1)
        Me.fraSemana.Controls.Add(Me.OptNatural)
        Me.fraSemana.Location = New System.Drawing.Point(8, 125)
        Me.fraSemana.Name = "fraSemana"
        Me.fraSemana.Size = New System.Drawing.Size(260, 56)
        Me.fraSemana.TabIndex = 13
        Me.fraSemana.TabStop = False
        Me.fraSemana.Text = "Semana"
        '
        'OptOpcion1
        '
        Me.OptOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptOpcion1.Location = New System.Drawing.Point(96, 20)
        Me.OptOpcion1.Name = "OptOpcion1"
        Me.OptOpcion1.Size = New System.Drawing.Size(88, 28)
        Me.OptOpcion1.TabIndex = 7
        Me.OptOpcion1.Text = "Cada 7 Dias"
        '
        'OptNatural
        '
        Me.OptNatural.Checked = True
        Me.OptNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptNatural.Location = New System.Drawing.Point(16, 20)
        Me.OptNatural.Name = "OptNatural"
        Me.OptNatural.Size = New System.Drawing.Size(64, 28)
        Me.OptNatural.TabIndex = 6
        Me.OptNatural.TabStop = True
        Me.OptNatural.Text = "Natural"
        '
        'optSoloAgencia
        '
        Me.optSoloAgencia.Enabled = False
        Me.optSoloAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSoloAgencia.Location = New System.Drawing.Point(12, 92)
        Me.optSoloAgencia.Name = "optSoloAgencia"
        Me.optSoloAgencia.Size = New System.Drawing.Size(236, 32)
        Me.optSoloAgencia.TabIndex = 6
        Me.optSoloAgencia.Text = "Calcular el importe del IVA únicamente sobre el Servicio de Agencia"
        '
        'optNetoAgencia
        '
        Me.optNetoAgencia.Enabled = False
        Me.optNetoAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNetoAgencia.Location = New System.Drawing.Point(12, 52)
        Me.optNetoAgencia.Name = "optNetoAgencia"
        Me.optNetoAgencia.Size = New System.Drawing.Size(236, 32)
        Me.optNetoAgencia.TabIndex = 5
        Me.optNetoAgencia.Text = "Calcular el importe del IVA sobre el Neto más el Servicio de Agencia"
        '
        'chkIVA
        '
        Me.chkIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkIVA.Location = New System.Drawing.Point(16, 20)
        Me.chkIVA.Name = "chkIVA"
        Me.chkIVA.Size = New System.Drawing.Size(128, 20)
        Me.chkIVA.TabIndex = 2
        Me.chkIVA.Text = "Calcular IVA"
        '
        'dtpFechaHasta
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFechaHasta.Appearance = Appearance1
        Me.dtpFechaHasta.FlatMode = True
        Me.dtpFechaHasta.Location = New System.Drawing.Point(88, 36)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(128, 21)
        Me.dtpFechaHasta.TabIndex = 1
        '
        'dtpFechaDesde
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaDesde.Appearance = Appearance2
        Me.dtpFechaDesde.FlatMode = True
        Me.dtpFechaDesde.Location = New System.Drawing.Point(88, 8)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(128, 21)
        Me.dtpFechaDesde.TabIndex = 0
        '
        'fraMaterial
        '
        Me.fraMaterial.Controls.Add(Me.OptNumeros)
        Me.fraMaterial.Controls.Add(Me.OptLetras)
        Me.fraMaterial.Location = New System.Drawing.Point(8, 63)
        Me.fraMaterial.Name = "fraMaterial"
        Me.fraMaterial.Size = New System.Drawing.Size(260, 56)
        Me.fraMaterial.TabIndex = 14
        Me.fraMaterial.TabStop = False
        Me.fraMaterial.Text = "Material"
        '
        'OptNumeros
        '
        Me.OptNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptNumeros.Location = New System.Drawing.Point(136, 20)
        Me.OptNumeros.Name = "OptNumeros"
        Me.OptNumeros.Size = New System.Drawing.Size(112, 28)
        Me.OptNumeros.TabIndex = 7
        Me.OptNumeros.Text = "Mostrar Numeros"
        '
        'OptLetras
        '
        Me.OptLetras.Checked = True
        Me.OptLetras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptLetras.Location = New System.Drawing.Point(16, 20)
        Me.OptLetras.Name = "OptLetras"
        Me.OptLetras.Size = New System.Drawing.Size(95, 28)
        Me.OptLetras.TabIndex = 6
        Me.OptLetras.TabStop = True
        Me.OptLetras.Text = "Mostrar Letras"
        '
        'frmFiltroCalendario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(278, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraMaterial)
        Me.Controls.Add(Me.fraSemana)
        Me.Controls.Add(Me.fraIva)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFiltroCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones para la Impresión del Calendario"
        Me.fraIva.ResumeLayout(False)
        Me.fraSemana.ResumeLayout(False)
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraMaterial.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim mFechaDesde As Date
    Dim mFechaHasta As Date
    Dim mCancelar As Boolean
    Dim mSemanaNatural As Boolean
    Dim Errorfecha As Boolean = False

    Public Sub New(ByVal FechaDesde As Date, ByVal FechaHasta As Date)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        mFechaDesde = FechaDesde
        mFechaHasta = FechaHasta

        Me.dtpFechaDesde.Value = FechaDesde
        Me.dtpFechaHasta.Value = FechaHasta
    End Sub
    Public Property SemanaNatural() As Boolean
        Get
            Return mSemanaNatural
        End Get
        Set(ByVal Value As Boolean)
            mSemanaNatural = Value
        End Set
    End Property
    Public Property Cancelar() As Boolean
        Get
            Return mCancelar
        End Get
        Set(ByVal Value As Boolean)
            mCancelar = Value
        End Set
    End Property

    Public ReadOnly Property FechaDesde() As Date
        Get
            Return Me.dtpFechaDesde.Value
        End Get
    End Property

    Public ReadOnly Property FechaHasta() As Date
        Get
            Return Me.dtpFechaHasta.Value
        End Get
    End Property

    Public ReadOnly Property CalcularIVA() As Boolean
        Get
            Return Me.chkIVA.Checked
        End Get
    End Property

    Public ReadOnly Property CalcularIVANetoAgencia() As Boolean
        Get
            Return Me.optNetoAgencia.Checked
        End Get
    End Property

    Public ReadOnly Property CalcularIVASoloAgencia() As Boolean
        Get
            Return Me.optSoloAgencia.Checked
        End Get
    End Property

    Public ReadOnly Property MostrarLetras() As Boolean
        Get
            Return Me.OptLetras.Checked
        End Get
    End Property

    Public ReadOnly Property MostrarNumeros() As Boolean
        Get
            Return Me.OptNumeros.Checked
        End Get
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Errorfecha = False
        If Not Errorfecha Then
            Me.Cancelar = False
            Me.Close()
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Cancelar = True
        Me.Close()
    End Sub

    Private Sub ValidarFecha(ByVal dtpFecha As dtpFecha)
        If dtpFecha.Value < mFechaDesde Then
            Mensajes.Mensaje("La Fecha No Puede ser Menor a la Fecha Más Chica de la Alternativa")

            dtpFecha.Value = mFechaDesde
            Errorfecha = True
        End If

        If dtpFecha.Value > mFechaHasta Then
            Mensajes.Mensaje("La Fecha No Puede ser Mayor a la Fecha Más Alta de la Alternativa")

            dtpFecha.Value = mFechaHasta
            Errorfecha = True
        End If
    End Sub

    Private Sub dtpFechaDesde_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.AfterCloseUp
        Me.ValidarFecha(Me.dtpFechaDesde)
    End Sub

    Private Sub dtpFechaHasta_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.AfterCloseUp
        Me.ValidarFecha(Me.dtpFechaHasta)

    End Sub

    Private Sub chkIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIVA.CheckedChanged
        If chkIVA.Checked Then
            Me.optNetoAgencia.Enabled = True
            Me.optSoloAgencia.Enabled = True
            Me.optNetoAgencia.Checked = True
        Else
            Me.optNetoAgencia.Enabled = False
            Me.optSoloAgencia.Enabled = False
            Me.optNetoAgencia.Checked = False
            Me.optSoloAgencia.Checked = False
        End If
    End Sub



    Private Sub OptNatural_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptNatural.Click
        SemanaNatural = True
    End Sub

    Private Sub OptOpcion1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptOpcion1.Click
        SemanaNatural = False
    End Sub

    Private Sub OptNatural_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptNatural.CheckedChanged

    End Sub

    Private Sub frmFiltroCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SemanaNatural = True
    End Sub

    Private Sub dtpFechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.ValueChanged

    End Sub
End Class

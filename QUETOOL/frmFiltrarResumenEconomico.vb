Public Class frmFiltrarResumenEconomico
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaHasta As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaDesde As QUETOOL.dtpFecha
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.dtpFechaHasta = New QUETOOL.dtpFecha
        Me.dtpFechaDesde = New QUETOOL.dtpFecha
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha Desde"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(-172, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(624, 2)
        Me.Label3.TabIndex = 21
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(56, 80)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 24)
        Me.cmdAceptar.TabIndex = 19
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(140, 80)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 24)
        Me.cmdCancelar.TabIndex = 20
        Me.cmdCancelar.Text = "Cancelar"
        '
        'dtpFechaHasta
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFechaHasta.Appearance = Appearance1
        Me.dtpFechaHasta.FlatMode = True
        Me.dtpFechaHasta.Location = New System.Drawing.Point(92, 36)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(128, 21)
        Me.dtpFechaHasta.TabIndex = 13
        '
        'dtpFechaDesde
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaDesde.Appearance = Appearance2
        Me.dtpFechaDesde.FlatMode = True
        Me.dtpFechaDesde.Location = New System.Drawing.Point(92, 8)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(128, 21)
        Me.dtpFechaDesde.TabIndex = 12
        '
        'frmFiltrarResumenEconomico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(232, 113)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFiltrarResumenEconomico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Económico"
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mFechaDesde As Date
    Dim mFechaHasta As Date
    Dim mCancelar As Boolean

    Public Sub New(ByVal FechaDesde As Date, ByVal FechaHasta As Date)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        mFechaDesde = FechaDesde
        mFechaHasta = FechaHasta

        Me.dtpFechaDesde.Value = FechaDesde
        Me.dtpFechaHasta.Value = FechaHasta
    End Sub

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

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Cancelar = False

        Me.Close()

        Application.DoEvents()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Cancelar = True
        Me.Close()
    End Sub

    Private Sub ValidarFecha(ByVal dtpFecha As dtpFecha)
        If dtpFecha.Value < mFechaDesde Then
            Mensajes.Mensaje("La Fecha No Puede ser Menor a la Fecha Más Chica de la Alternativa")

            dtpFecha.Value = mFechaDesde
        End If

        If dtpFecha.Value > mFechaHasta Then
            Mensajes.Mensaje("La Fecha No Puede ser Mayor a la Fecha Más Alta de la Alternativa")

            dtpFecha.Value = mFechaHasta
        End If
    End Sub

    Private Sub dtpFechaDesde_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.AfterCloseUp
        Me.ValidarFecha(Me.dtpFechaDesde)
    End Sub

    Private Sub dtpFechaHasta_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.AfterCloseUp
        Me.ValidarFecha(Me.dtpFechaHasta)
    End Sub

End Class

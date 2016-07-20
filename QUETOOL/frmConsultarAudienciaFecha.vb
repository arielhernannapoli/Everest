Public Class frmConsultarAudienciaFecha
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
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents iugAudiencia As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugAudiencia = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        CType(Me.iugAudiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugAudiencia
        '
        Me.iugAudiencia.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance1.BorderColor = System.Drawing.Color.DimGray
        Me.iugAudiencia.DisplayLayout.Appearance = Appearance1
        Me.iugAudiencia.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugAudiencia.DisplayLayout.CaptionAppearance = Appearance2
        Me.iugAudiencia.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugAudiencia.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.iugAudiencia.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.iugAudiencia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.iugAudiencia.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.iugAudiencia.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.iugAudiencia.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.iugAudiencia.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.iugAudiencia.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugAudiencia.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugAudiencia.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugAudiencia.FlatMode = True
        Me.iugAudiencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugAudiencia.Location = New System.Drawing.Point(8, 8)
        Me.iugAudiencia.Name = "iugAudiencia"
        Me.iugAudiencia.Size = New System.Drawing.Size(396, 336)
        Me.iugAudiencia.TabIndex = 2
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(320, 352)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(84, 24)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(232, 352)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(84, 24)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmConsultarAudienciaFecha
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(410, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.iugAudiencia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultarAudienciaFecha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Fechas de Audiencia"
        CType(Me.iugAudiencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mIDTipoSoporte As Integer
    Dim mIDTarget As Integer
    Dim mIDMedio As Integer
    Dim mFechaInicioAudiencia As Date
    Dim mFechaFinAudiencia As Date
    Dim mId_Plaza As Integer

    Dim mFechasAudiencia As DataTable

    Public Property IDTipoSoporte() As Integer
        Get
            Return mIDTipoSoporte
        End Get
        Set(ByVal Value As Integer)
            mIDTipoSoporte = Value
        End Set
    End Property

    Public Property IDTarget() As Integer
        Get
            Return mIDTarget
        End Get
        Set(ByVal Value As Integer)
            mIDTarget = Value
        End Set
    End Property

    Public Property IDMedio() As Integer
        Get
            Return mIDMedio
        End Get
        Set(ByVal Value As Integer)
            mIDMedio = Value
        End Set
    End Property

    Public Property FechasAudiencia() As DataTable
        Get
            Return mFechasAudiencia
        End Get
        Set(ByVal Value As DataTable)
            mFechasAudiencia = Value
        End Set
    End Property

    Public Property FechaInicioAudiencia() As Date
        Get
            Return mFechaInicioAudiencia
        End Get
        Set(ByVal Value As Date)
            mFechaInicioAudiencia = Value
        End Set
    End Property

    Public Property FechaFinAudiencia() As Date
        Get
            Return mFechaFinAudiencia
        End Get
        Set(ByVal Value As Date)
            mFechaFinAudiencia = Value
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

    Private Sub frmConsultarAudienciaFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim A As New Audiencias_fechas

        A.Id_medio = Me.IDMedio
        A.Id_tipo_soporte = Me.IDTipoSoporte
        A.Id_plaza = Me.Id_Plaza
        'si es capital se pasa el target
        If Me.IDTipoSoporte = 1 Then
            A.Id_target = Me.IDTarget
        Else
            'para cable o interio pasa un CERO en el target
            A.Id_target = 0
        End If

        Me.FechasAudiencia = A.ObtenerFechasAudiencias

        Me.iugAudiencia.DataSource = Me.FechasAudiencia

        Listas.AplicarFormato(Me.iugAudiencia)

        Dim GrillaFormato As New GrillaFormato

        GrillaFormato.CambiarColorColumna(iugAudiencia, Color.WhiteSmoke, 0, "semana", "Fecha Hasta")
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim inicio As Date
        Dim fin As Date
        If Me.iugAudiencia.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        'AG 02/11/2011 +++++++++++++++++++++++++++++++++++++++++++++++++
        If Me.IDMedio = Medios.Tv Then
            Select Case Me.IDTipoSoporte
                Case 2
                    If Me.iugAudiencia.Selected.Rows.Count > 1 Then
                        MsgBox("La audiencia Tv Interior solo permite seleccionar una SEMANA", MsgBoxStyle.Information, "Everest")
                        Exit Sub
                    End If
            End Select
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'Me.FechaInicioAudiencia = 
        inicio = Me.iugAudiencia.Selected.Rows(Me.iugAudiencia.Selected.Rows.Count - 1).Cells("Fecha Desde").Text
        'Me.FechaFinAudiencia = 
        fin = Me.iugAudiencia.Selected.Rows(0).Cells("Fecha Hasta").Text

        If inicio > fin Then
            fin = Me.iugAudiencia.Selected.Rows(Me.iugAudiencia.Selected.Rows.Count - 1).Cells("Fecha Hasta").Text
            inicio = Me.iugAudiencia.Selected.Rows(0).Cells("Fecha Desde").Text
        End If

        Me.FechaFinAudiencia = fin
        Me.FechaInicioAudiencia = inicio
        'For Each r As Infragistics.Win.UltraWinGrid.UltraGridRow In iugAudiencia.Selected.Rows

        'Next
    End Sub
End Class

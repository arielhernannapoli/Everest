Public Class frmMostrarEmisiones
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
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents iugEmisiones As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Visible")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Columna")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Visible")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Columna")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Visible")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Columna")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.iugEmisiones = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugEmisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraDataSource3
        '
        UltraDataColumn1.DataType = GetType(System.Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn1.ReadOnly = Infragistics.Win.DefaultableBoolean.False
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2})
        '
        'UltraDataSource2
        '
        UltraDataColumn3.DataType = GetType(System.Boolean)
        UltraDataColumn3.ReadOnly = Infragistics.Win.DefaultableBoolean.True
        UltraDataColumn4.ReadOnly = Infragistics.Win.DefaultableBoolean.False
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn3, UltraDataColumn4})
        '
        'UltraDataSource1
        '
        UltraDataColumn5.DataType = GetType(System.Boolean)
        UltraDataColumn5.DefaultValue = False
        UltraDataColumn6.ReadOnly = Infragistics.Win.DefaultableBoolean.True
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6})
        '
        'iugEmisiones
        '
        Me.iugEmisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance1.BorderColor = System.Drawing.Color.DimGray
        Me.iugEmisiones.DisplayLayout.Appearance = Appearance1
        Me.iugEmisiones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugEmisiones.DisplayLayout.CaptionAppearance = Appearance2
        Me.iugEmisiones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugEmisiones.DisplayLayout.GroupByBox.Prompt = "Arrastre el encabezado de la columna aquí para agrupar por esa columna."
        Me.iugEmisiones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.iugEmisiones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.iugEmisiones.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugEmisiones.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugEmisiones.FlatMode = True
        Me.iugEmisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugEmisiones.Location = New System.Drawing.Point(8, 4)
        Me.iugEmisiones.Name = "iugEmisiones"
        Me.iugEmisiones.Size = New System.Drawing.Size(444, 372)
        Me.iugEmisiones.TabIndex = 17
        '
        'frmMostrarEmisiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(460, 380)
        Me.Controls.Add(Me.iugEmisiones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmMostrarEmisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisiones de :"
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugEmisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mDescripcion As String
    Dim mId_Soporte As Long
    Dim mId_Programa As Long
    Dim mId_Plaza As Integer
    Dim mId_Medio As Integer

    Property Descripcion()
        Get
            Descripcion = mDescripcion
        End Get
        Set(ByVal Value)
            mDescripcion = Value
        End Set
    End Property

    Property Id_Soporte()
        Get
            Id_Soporte = mId_Soporte
        End Get
        Set(ByVal Value)
            mId_Soporte = Value
        End Set
    End Property

    Property Id_programa()
        Get
            Id_programa = mId_Programa
        End Get
        Set(ByVal Value)
            mId_Programa = Value
        End Set
    End Property

    Property Id_Medio()
        Get
            Id_Medio = mId_Medio
        End Get
        Set(ByVal Value)
            mId_Medio = Value
        End Set
    End Property

    Private Sub frmMostrarEmisiones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim tva As New Audiencia_Tva
        Dim prgmon As New Programas_Monitor
        Dim ssm As New Soportes_sigeme_monitor

        Dim s As New Soportes
        Dim prg As New Programas

        s.Id_soporte = mId_Soporte
        s.Id_medio = mId_Medio
        s.BuscarPorID_Soporte()

        ssm.Id_medio = Activo.IDMedio
        ssm.Id_soporte = s.Id_soporte
        ssm.Select_Medio_Soporte()

        prg.Id_programa = mId_Programa
        prg.BuscarPorID()

        If s.Id_plaza = 1 Then
            tva.Id_Medio = Activo.IDMedio
            tva.Id_Soporte = Id_Soporte
            tva.Id_Programa = Id_programa
            dt = tva.TraerAudienciaParaMatcheo(Now.AddDays(-21), Now)
            iugEmisiones.DataSource = dt

            Me.Text = "Emisiones de: " & mDescripcion & " desde el " & Now.AddDays(-21).ToShortDateString & " hasta " & Now.ToShortDateString
        Else
            prgmon.Id_programa_Monitor = prg.Id_programa_monitor
            prgmon.Cadena_Monitor = ssm.Cadena_monitor()
            prgmon.Plaza_Monitor = ssm.Plaza_monitor
            dt = prgmon.TraerProgramasParaMatcheo(Now.AddDays(-21), Now)
            iugEmisiones.DataSource = dt

            Me.Text = "Emisiones de: " & mDescripcion & " desde el " & Now.AddDays(-21).ToShortDateString & " hasta " & Now.ToShortDateString
        End If

    End Sub

    Private Sub iugEmisiones_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugEmisiones.InitializeLayout
        Dim i As Integer

        For i = 0 To iugEmisiones.DisplayLayout.Bands(0).Columns.Count - 1
            iugEmisiones.DisplayLayout.Bands(0).Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next
    End Sub
End Class

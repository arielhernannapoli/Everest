Public Class frmDetalle
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
    Friend WithEvents iugDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rating")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dia")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rating")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Día")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rating")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dia")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rating")
        Me.iugDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        CType(Me.iugDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugDetalle
        '
        Me.iugDetalle.DataSource = Me.UltraDataSource3
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance1.BorderColor = System.Drawing.Color.DimGray
        Me.iugDetalle.DisplayLayout.Appearance = Appearance1
        Me.iugDetalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.iugDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugDetalle.DisplayLayout.CaptionAppearance = Appearance2
        Me.iugDetalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.iugDetalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.iugDetalle.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.iugDetalle.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.iugDetalle.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.iugDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.iugDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.iugDetalle.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugDetalle.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugDetalle.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugDetalle.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugDetalle.FlatMode = True
        Me.iugDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugDetalle.Location = New System.Drawing.Point(0, 0)
        Me.iugDetalle.Name = "iugDetalle"
        Me.iugDetalle.Size = New System.Drawing.Size(154, 154)
        Me.iugDetalle.TabIndex = 0
        '
        'UltraDataSource3
        '
        UltraDataColumn2.DefaultValue = ""
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2})
        '
        'UltraDataSource1
        '
        UltraDataColumn4.DataType = GetType(System.Single)
        UltraDataColumn4.DefaultValue = 0.0!
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn3, UltraDataColumn4})
        '
        'UltraDataSource2
        '
        UltraDataColumn6.DataType = GetType(System.Single)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6})
        '
        'frmDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(154, 154)
        Me.Controls.Add(Me.iugDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetalle"
        Me.Text = "Detalle de Rating"
        CType(Me.iugDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mIDPrograma As Integer
    Dim mFprograma As Date
    Dim mIDSoporte As Integer
    Dim mFinicio As Date
    Dim mFfin As Date
    Dim mTipoRating As String
    Dim mIDTarget1 As Integer




    Dim GrillaFormato As New GrillaFormato
    Public Property TipoRating() As String
        Get
            Return mTipoRating
        End Get
        Set(ByVal Value As String)
            mTipoRating = Value
        End Set
    End Property
    Public Property Ffin() As Date
        Get
            Return mFfin
        End Get
        Set(ByVal Value As Date)
            mFfin = Value
        End Set
    End Property
    Public Property Fprograma() As Date
        Get
            Return mFprograma
        End Get
        Set(ByVal Value As Date)
            mFprograma = Value
        End Set
    End Property
    Public Property Finicio() As Date
        Get
            Return mFinicio
        End Get
        Set(ByVal Value As Date)
            mFinicio = Value
        End Set
    End Property
    Public Property IDPrograma() As Integer
        Get
            Return mIDPrograma
        End Get
        Set(ByVal Value As Integer)
            mIDPrograma = Value
        End Set
    End Property
    Public Property IDSoporte() As Integer
        Get
            Return mIDSoporte
        End Get
        Set(ByVal Value As Integer)
            mIDSoporte = Value
        End Set
    End Property
    Public Property IDTarget1() As Integer
        Get
            Return mIDTarget1
        End Get
        Set(ByVal Value As Integer)
            mIDTarget1 = Value
        End Set
    End Property
    Private Sub Formato()
        GrillaFormato.CambiarColorColumna(iugDetalle, Color.WhiteSmoke, 0, "dia")

        GrillaFormato.HabilitarEdicionColumna(iugDetalle.DisplayLayout.Bands(0).Columns(0), Infragistics.Win.UltraWinGrid.Activation.NoEdit)
        GrillaFormato.HabilitarEdicionColumna(iugDetalle.DisplayLayout.Bands(0).Columns(1), Infragistics.Win.UltraWinGrid.Activation.NoEdit)

        GrillaFormato.AutoAjustarColumnas(iugDetalle, 0)
        GrillaFormato.AutoAjustarColumnas(iugDetalle, 1)

    End Sub
    Private Sub FormatoRatReal()

        GrillaFormato.HabilitarEdicionColumna(iugDetalle.DisplayLayout.Bands(0).Columns(0), Infragistics.Win.UltraWinGrid.Activation.NoEdit)
        GrillaFormato.AutoAjustarColumnas(iugDetalle, 0)


    End Sub
    Public Sub MostrarDetalle(ByVal Tipo As TipoAudiencia, ByVal TipoRating As String)

        Select Case Tipo
            Case TipoAudiencia.Abierta

                Dim a As New Audiencia_Tva
                Dim DT As DataTable = a.ObtenerDetalleAudienciaTVA(Activo.IDMedio, IDSoporte, IDPrograma, Activo.FechaInicioAudiencia, Activo.FechaFinAudiencia, IDTarget1, TipoRating)
                iugDetalle.DataSource = DT

            Case TipoAudiencia.Cable
                Dim a As New Audiencia_tvc
                Dim DT As DataTable = a.ObtenerDetalleAudienciaTVA(Activo.IDMedio, IDSoporte, IDPrograma, Activo.FechaInicioAudiencia, Activo.FechaFinAudiencia, IDTarget1)

                iugDetalle.DataSource = DT

            Case TipoAudiencia.Intetior
                Dim a As New Audiencia_TVI
                Dim DT As DataTable = a.ObtenerDetalleAudienciaTVA(Activo.IDMedio, IDSoporte, IDPrograma, Activo.FechaInicioAudiencia, Activo.FechaFinAudiencia, IDTarget1)

                iugDetalle.DataSource = DT
        End Select
        Formato()
    End Sub
    Public Sub MostrarRatingReal(ByVal Tipo As TipoAudiencia, ByVal TipoRating As String)

        Dim Rating As Single
        Select Case Tipo
            Case TipoAudiencia.Abierta

                Dim a As New Audiencia_Tva
                Rating = a.ObtenerRatingReal(Activo.IDMedio, IDSoporte, IDPrograma, Activo.FechaInicioAudiencia, Activo.FechaFinAudiencia, IDTarget1, TipoRating)
                CargarValor(Rating)

            Case TipoAudiencia.Cable
                Dim a As New Audiencia_tvc
                Rating = a.ObtenerRatingReal(Activo.IDMedio, IDSoporte, IDPrograma, Activo.FechaInicioAudiencia, Activo.FechaFinAudiencia, IDTarget1)
                CargarValor(Rating)

            Case TipoAudiencia.Intetior
                Dim a As New Audiencia_TVI
                Rating = a.ObtenerRatingReal(Activo.IDMedio, IDSoporte, IDPrograma, Activo.FechaInicioAudiencia, Activo.FechaFinAudiencia, IDTarget1)
                CargarValor(Rating)
        End Select
        FormatoRatReal()
    End Sub
    Private Sub CargarValor(ByVal Valor As Single)

        'iugDetalle.DisplayLayout.Bands(0).Columns.Add("ratingreal", "Rating")
        iugDetalle.DisplayLayout.Bands(0).AddNew.Cells(1).Value = Valor

    End Sub
    Private Sub iugDetalle_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugDetalle.InitializeLayout

    End Sub

    Private Sub frmDetalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

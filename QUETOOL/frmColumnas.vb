Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid


Public Class frmColumnas
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
    Friend WithEvents iugColumnas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Visible")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Columna")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Visible")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Columna")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Visible")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Columna")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Visible")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Columna")
        Me.iugColumnas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        CType(Me.iugColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugColumnas
        '
        Me.iugColumnas.DataSource = Me.UltraDataSource3
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance1.BorderColor = System.Drawing.Color.DimGray
        Me.iugColumnas.DisplayLayout.Appearance = Appearance1
        Me.iugColumnas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 38
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.iugColumnas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugColumnas.DisplayLayout.CaptionAppearance = Appearance2
        Me.iugColumnas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugColumnas.DisplayLayout.MaxColScrollRegions = 1
        Me.iugColumnas.DisplayLayout.MaxRowScrollRegions = 1
        Me.iugColumnas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes
        Me.iugColumnas.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.iugColumnas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.iugColumnas.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.iugColumnas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.iugColumnas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.iugColumnas.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.iugColumnas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugColumnas.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.None
        Me.iugColumnas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugColumnas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugColumnas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugColumnas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugColumnas.FlatMode = True
        Me.iugColumnas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugColumnas.Location = New System.Drawing.Point(0, 0)
        Me.iugColumnas.Name = "iugColumnas"
        Me.iugColumnas.Size = New System.Drawing.Size(176, 256)
        Me.iugColumnas.TabIndex = 0
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
        'frmColumnas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(176, 256)
        Me.Controls.Add(Me.iugColumnas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmColumnas"
        Me.Text = "Seleccionar Columnas"
        CType(Me.iugColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim GrillaFormato As New GrillaFormato
    Dim Grilladmin As New GrillAdmin
    Dim mGrid As UltraGrid
    Dim ColumnasExcluidas As New ArrayList


    Public Property Grid() As UltraGrid
        Get
            Return mGrid
        End Get
        Set(ByVal Value As UltraGrid)
            mGrid = Value
        End Set
    End Property
    Private Sub Formato()
        GrillaFormato.CambiarColorColumna(iugColumnas, Color.WhiteSmoke, 0, "Visible")

        GrillaFormato.HabilitarEdicionColumna(iugColumnas, "Columna", Infragistics.Win.UltraWinGrid.Activation.NoEdit)
        GrillaFormato.HabilitarEdicionColumna(iugColumnas, "Visible", Infragistics.Win.UltraWinGrid.Activation.AllowEdit)

        GrillaFormato.AutoAjustarColumnas(iugColumnas, "visible")
        GrillaFormato.AutoAjustarColumnas(iugColumnas, "columna")

    End Sub
    Public Sub ExcluirColumnas(ByVal ParamArray Columnas() As String)
        Dim i As Integer
        For Each S As String In Columnas
            ColumnasExcluidas.Add(S.Trim.ToLower)
        Next
        For Each C As UltraGridColumn In Grid.DisplayLayout.Bands(0).Columns
            If Grilladmin.EsColumnaCalendario(C) Or C.Key.IndexOf("Band") > -1 Then
                ColumnasExcluidas.Add(C.Key.Trim.ToLower)
            End If
        Next
        ColumnasExcluidas.Add("L")
        ColumnasExcluidas.Add("M")
        ColumnasExcluidas.Add("X")
        ColumnasExcluidas.Add("J")
        ColumnasExcluidas.Add("V")
        ColumnasExcluidas.Add("S")
        ColumnasExcluidas.Add("D")
    End Sub
    Public Sub Mostrar()
        CargarColumnas()
        Formato()
        Me.ShowDialog()
    End Sub
    Private Sub CargarColumnas()

        For Each c As UltraGridColumn In Grid.DisplayLayout.Bands(0).Columns
            If ColumnasExcluidas.IndexOf(c.Key.Trim.ToLower) < 0 Then
                With iugColumnas.DisplayLayout.Bands(0).AddNew
                    .Cells("columna").Tag = c.Key
                    .Cells("columna").Value = Replace(c.Header.Caption, vbCrLf, " ")
                    .Cells("visible").Value = IIf(c.Hidden = True, False, True)
                End With
            End If
        Next
    End Sub

    Private Sub iugColumnas_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugColumnas.CellChange
        If iugColumnas.ActiveCell Is Nothing Or iugColumnas.ActiveCell.Column.Key = "Columna" Then
            Exit Sub
        End If

        Dim key As String = iugColumnas.Rows(e.Cell.Row.Index).Cells("columna").Tag
        Dim Check As Boolean = IIf(iugColumnas.Rows(e.Cell.Row.Index).Cells("Visible").Text = True, False, True)

        With Grid.DisplayLayout.Bands(0).Columns(key)
            .Hidden = Check
        End With

        Grid.DisplayLayout.Bands(0).Columns(key).PerformAutoResize()
        GrillaFormato.ReocultarColumnasHijos(Grid)


    End Sub


    Private Sub iugColumnas_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugColumnas.InitializeLayout

    End Sub
End Class

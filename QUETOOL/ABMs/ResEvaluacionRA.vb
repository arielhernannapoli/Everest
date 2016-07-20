Imports System.IO

Public Class ResEvaluacionRA
    Inherits System.Windows.Forms.UserControl

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal PathEvaIbo As String, ByVal NomArc As String, ByVal mdtSpots As DataTable)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        CargarRA(PathEvaIbo, NomArc, mdtSpots)
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
    Friend WithEvents iugSpots As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugSpots = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.iugSpots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugSpots
        '
        Me.iugSpots.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.iugSpots.DisplayLayout.Appearance = Appearance1
        Me.iugSpots.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.iugSpots.DisplayLayout.InterBandSpacing = 10
        Me.iugSpots.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.iugSpots.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.iugSpots.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.iugSpots.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.iugSpots.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.iugSpots.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.iugSpots.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.iugSpots.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Me.iugSpots.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.iugSpots.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.iugSpots.DisplayLayout.Override.RowSelectorWidth = 12
        Me.iugSpots.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.iugSpots.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.iugSpots.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugSpots.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugSpots.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugSpots.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Me.iugSpots.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.iugSpots.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugSpots.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugSpots.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.iugSpots.DisplayLayout.UseFixedHeaders = True
        Me.iugSpots.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.iugSpots.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.iugSpots.Location = New System.Drawing.Point(12, 12)
        Me.iugSpots.Name = "iugSpots"
        Me.iugSpots.Size = New System.Drawing.Size(724, 452)
        Me.iugSpots.TabIndex = 29
        '
        'ResEvaluacionRA
        '
        Me.Controls.Add(Me.iugSpots)
        Me.Name = "ResEvaluacionRA"
        Me.Size = New System.Drawing.Size(747, 479)
        CType(Me.iugSpots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub CargarRA(ByVal PathEvaIbo As String, ByVal NomArc As String, ByVal mdtSpots As DataTable)
        Dim cadena As String
        Dim ArcRes As StreamReader
        Dim row As DataRow
        Dim arCadena() As Object
        Dim iugRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        ' Estas constantes salen de la especificacion de eva_ibo para el archivo de ratings
        Const FECHA_REAL = 6
        Const RATING_1 = 7
        Const RATING_2 = 8

        ArcRes = File.OpenText(PathEvaIbo & "RA" & NomArc & ".TXT")
        cadena = ArcRes.ReadLine
        For Each row In mdtSpots.Rows
            If row("procesar") Then
                arCadena = Split(cadena, vbTab)
                row("PBR_1") = arCadena(RATING_1)
                row("PBR_2") = arCadena(RATING_2)
                row("CPR1_1") = row("Costo") / arCadena(RATING_1) / row("Duracion")
                row("CPR1_2") = row("Costo") / arCadena(RATING_2) / row("Duracion")
            End If
            cadena = ArcRes.ReadLine
        Next
        ArcRes.Close()
        iugSpots.DataSource = mdtSpots

        For Each iugRow In iugSpots.Rows
            If Not iugRow.Cells("procesar").Value Then
                iugRow.Hidden = True
            End If
        Next

        Listas.OcultarColumnas(iugSpots, "Id", "Procesar", "Hora", "SoporteEvaIbo", "Spots", _
                                "Id_Soporte", "Id_Tarifa", "FechaReal")

        Listas.CambiarTituloColumna(iugSpots, "Rotlvsd", "L-V S-D")
        Listas.CambiarTituloColumna(iugSpots, "Duracion", "Duración")
        Listas.CambiarTituloColumna(iugSpots, "PBR_1", "PBR 1")
        Listas.CambiarTituloColumna(iugSpots, "PBR_2", "PBR 2")
        Listas.CambiarTituloColumna(iugSpots, "CPR1_1", "CPR:1 1")
        Listas.CambiarTituloColumna(iugSpots, "CPR1_2", "CPR:1 2")



        Listas.AplicarFormato(iugSpots)

    End Sub
End Class

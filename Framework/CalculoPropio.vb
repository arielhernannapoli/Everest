Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics.Shared

Public Class CalculoPropio
    Implements ICustomSummaryCalculator

    Public Resultado As Integer

    Public Sub AggregateCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal row As Infragistics.Win.UltraWinGrid.UltraGridRow) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.AggregateCustomSummary
        Resultado = Resultado + row.Cells(summarySettings.SourceColumn).Text.Length
    End Sub

    Public Sub BeginCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.BeginCustomSummary
        Resultado = 0
    End Sub

    Public Function EndCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) As Object Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.EndCustomSummary
        Return Resultado
    End Function
End Class
Public Class CalculoRatingSpot
    Implements ICustomSummaryCalculator
    Dim Resultado As Single
    Dim Spots As Integer

    Public Sub AggregateCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal row As Infragistics.Win.UltraWinGrid.UltraGridRow) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.AggregateCustomSummary
        Dim rat As Single

        'AG Codigo anterior +++++++++++++++++++++++++++
        'rat = row.Cells(GrillAdmin.ColumnaRatingTarget1).Value
        '+++++++++++++++++++++++++++++++++++++++++
        Try
            'AG CP ++++++++++++++++++++++++++++++++++++++++
            If Activo.TEjecicioActivo = Activo.TipoEjercicio.Estandar Then
                rat = row.Cells(GrillAdmin.ColumnaRatingTarget1).Value
            Else
                rat = row.Cells(GrillAdminCp.ColumnaRatingTarget1).Value
            End If
            '+++++++++++++++++++++++++++++++++++++++++++++
            Spots = row.Cells(summarySettings.SourceColumn).Text.Length
            Resultado += Format((Spots * rat), "0.00")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub BeginCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.BeginCustomSummary
        Resultado = 0
        Spots = 0
    End Sub

    Public Function EndCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) As Object Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.EndCustomSummary
        Return Resultado
    End Function
End Class
Public Class CalculoCPR
    Implements ICustomSummaryCalculator
    Dim mlblCPR As Label
    Public Property lblCPR() As Label
        Get
            Return mlblCPR
        End Get
        Set(ByVal Value As Label)
            mlblCPR = Value
        End Set
    End Property
    Dim Cpr As Double
    Public Sub AggregateCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal row As Infragistics.Win.UltraWinGrid.UltraGridRow) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.AggregateCustomSummary
        Cpr = CDbl(mlblCPR.Tag)
    End Sub
    Public Sub BeginCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.BeginCustomSummary
    End Sub
    Public Function EndCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) As Object Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.EndCustomSummary
        Return Cpr
    End Function
End Class

'Public Class CalculoGRP
'    Implements ICustomSummaryCalculator
'    Public GRP As Label
'    Public Sub AggregateCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal row As Infragistics.Win.UltraWinGrid.UltraGridRow) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.AggregateCustomSummary
'    End Sub
'    Public Sub BeginCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.BeginCustomSummary
'    End Sub

'    Public Function EndCustomSummary(ByVal summarySettings As Infragistics.Win.UltraWinGrid.SummarySettings, ByVal rows As Infragistics.Win.UltraWinGrid.RowsCollection) As Object Implements Infragistics.Win.UltraWinGrid.ICustomSummaryCalculator.EndCustomSummary
'        Return CDec(GRP.Text)
'    End Function
'End Class
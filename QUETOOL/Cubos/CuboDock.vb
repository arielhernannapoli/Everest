Imports DevExpress.XtraPivotGrid

Public Class CuboDock
    Inherits Cubos.Cubo

    Protected Overrides Sub SetFields()
        Me.Fields("RN_TEMA").Area = PivotArea.RowArea
        Me.Fields("RN_TEMA").AreaIndex = 0
        Me.Fields("RN_TEMA").Caption = "TEMA"

        Me.Fields("DS_DURACION").Area = PivotArea.DataArea
        Me.Fields("DS_DURACION").AreaIndex = 0
        Me.Fields("DS_DURACION").Caption = "DURACION"
        Me.Fields("DS_DURACION").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        Me.Fields("DS_DURACION_PORC").Area = PivotArea.DataArea
        Me.Fields("DS_DURACION_PORC").AreaIndex = 1
        Me.Fields("DS_DURACION_PORC").Caption = "DURACION %"
        Me.Fields("DS_DURACION_PORC").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Fields("DS_DURACION_PORC").CellFormat.FormatString = "P"
        Me.Fields("DS_DURACION_PORC").SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn

        Me.Fields("DS_CANTIDAD").Area = PivotArea.DataArea
        Me.Fields("DS_CANTIDAD").AreaIndex = 2
        Me.Fields("DS_CANTIDAD").Caption = "CANTIDAD"

        Me.Fields("DS_CANTIDAD_PORC").Area = PivotArea.DataArea
        Me.Fields("DS_CANTIDAD_PORC").AreaIndex = 3
        Me.Fields("DS_CANTIDAD_PORC").Caption = "CANTIDAD %"
        Me.Fields("DS_CANTIDAD_PORC").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Fields("DS_CANTIDAD_PORC").CellFormat.FormatString = "P"
        Me.Fields("DS_CANTIDAD_PORC").SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn

        Me.Fields("DS_RAT TARGET 1").Area = PivotArea.DataArea
        Me.Fields("DS_RAT TARGET 1").AreaIndex = 4
        Me.Fields("DS_RAT TARGET 1").Caption = "RAT TARGET 1"

        Me.Fields("DS_RAT TARGET 1_PORC").Area = PivotArea.DataArea
        Me.Fields("DS_RAT TARGET 1_PORC").AreaIndex = 5
        Me.Fields("DS_RAT TARGET 1_PORC").Caption = "RAT TARGET 1 %"
        Me.Fields("DS_RAT TARGET 1_PORC").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Fields("DS_RAT TARGET 1_PORC").CellFormat.FormatString = "P"
        Me.Fields("DS_RAT TARGET 1_PORC").SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn

        Me.Fields("DS_RAT TARGET 2").Area = PivotArea.DataArea
        Me.Fields("DS_RAT TARGET 2").AreaIndex = 6
        Me.Fields("DS_RAT TARGET 2").Caption = "RAT TARGET 2"

        Me.Fields("DS_RAT TARGET 2_PORC").Area = PivotArea.DataArea
        Me.Fields("DS_RAT TARGET 2_PORC").AreaIndex = 7
        Me.Fields("DS_RAT TARGET 2_PORC").Caption = "RAT TARGET 2 %"
        Me.Fields("DS_RAT TARGET 2_PORC").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Fields("DS_RAT TARGET 2_PORC").CellFormat.FormatString = "P"
        Me.Fields("DS_RAT TARGET 2_PORC").SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn

        Me.Fields("DS_NETO").Area = PivotArea.DataArea
        Me.Fields("DS_NETO").AreaIndex = 8
        Me.Fields("DS_NETO").Caption = "NETO"

        Me.Fields("DS_NETO_PORC").Area = PivotArea.DataArea
        Me.Fields("DS_NETO_PORC").AreaIndex = 9
        Me.Fields("DS_NETO_PORC").Caption = "NETO %"
        Me.Fields("DS_NETO_PORC").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Fields("DS_NETO_PORC").CellFormat.FormatString = "P"
        Me.Fields("DS_NETO_PORC").SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn

        Me.Fields("DS_BRUTO ORI").Area = PivotArea.DataArea
        Me.Fields("DS_BRUTO ORI").AreaIndex = 10
        Me.Fields("DS_BRUTO ORI").Caption = "BRUTO ORI"

        Me.Fields("DS_BRUTO ORI_PORC").Area = PivotArea.DataArea
        Me.Fields("DS_BRUTO ORI_PORC").AreaIndex = 11
        Me.Fields("DS_BRUTO ORI_PORC").Caption = "BRUTO ORI %"
        Me.Fields("DS_BRUTO ORI_PORC").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Fields("DS_BRUTO ORI_PORC").CellFormat.FormatString = "P"
        Me.Fields("DS_BRUTO ORI_PORC").SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn

        Me.Fields("DS_BRUTO ACTUAL").Area = PivotArea.DataArea
        Me.Fields("DS_BRUTO ACTUAL").AreaIndex = 12
        Me.Fields("DS_BRUTO ACTUAL").Caption = "BRUTO ACTUAL"

        Me.Fields("DS_BRUTO ACTUAL_PORC").Area = PivotArea.DataArea
        Me.Fields("DS_BRUTO ACTUAL_PORC").AreaIndex = 13
        Me.Fields("DS_BRUTO ACTUAL_PORC").Caption = "BRUTO ACTUAL %"
        Me.Fields("DS_BRUTO ACTUAL_PORC").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Fields("DS_BRUTO ACTUAL_PORC").CellFormat.FormatString = "P"
        Me.Fields("DS_BRUTO ACTUAL_PORC").SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn

        Me.Fields("PN_SOPORTE").Caption = "SOPORTE"
        Me.Fields("PN_PROVEEDOR").Caption = "PROVEEDOR"
        Me.Fields("PN_PROGRAMA").Caption = "PROGRAMA"
        Me.Fields("PN_FRANJA").Caption = "FRANJA"
        Me.Fields("RN_SEMANA").Caption = "SEMANA"
        Me.Fields("RN_LAB FES").Caption = "LAB FES"
        Me.Fields("RN_SEM CAL").Caption = "SEM CAL"
        Me.Fields("RN_DIA SEMANA").Caption = "DIA SEMANA"
        Me.Fields("RN_MES").Caption = "MES"

        Me.Fields.Remove(Me.Fields("ID_SOPORTE"))
        Me.Fields.Remove(Me.Fields("ID_MEDIO"))

    End Sub

End Class

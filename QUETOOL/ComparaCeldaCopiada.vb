Imports Infragistics.Win.UltraWinGrid

Public Class ComparaCeldaCopiada
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim Celda1 As CeldaCopiada = DirectCast(x, CeldaCopiada)
        Dim Celda2 As CeldaCopiada = DirectCast(y, CeldaCopiada)

        If Celda1.IndiceFila < Celda2.IndiceFila Then
            Return -1
        End If

        If Celda1.IndiceFila > Celda2.IndiceFila Then
            Return 1
        End If

        If Celda1.IndiceFila = Celda2.IndiceFila Then
            If Celda1.IndiceColumna < Celda2.IndiceColumna Then
                Return -1
            End If

            If Celda1.IndiceColumna > Celda2.IndiceColumna Then
                Return 1
            End If

            Return 0
        End If
    End Function

    'Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
    '    Dim Celda1 As UltraGridCell = DirectCast(x, UltraGridCell)
    '    Dim Celda2 As UltraGridCell = DirectCast(y, UltraGridCell)

    '    If Celda1.Row.Index < Celda2.Row.Index Then
    '        Return -1
    '    End If

    '    If Celda1.Row.Index > Celda2.Row.Index Then
    '        Return 1
    '    End If

    '    If Celda1.Row.Index = Celda2.Row.Index Then
    '        If Celda1.Column.Index < Celda2.Column.Index Then
    '            Return -1
    '        End If

    '        If Celda1.Column.Index > Celda2.Column.Index Then
    '            Return 1
    '        End If

    '        Return 0
    '    End If
    'End Function
End Class

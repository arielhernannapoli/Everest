Public Class Valores
    Public Shared Function CastDBNull(ByVal Valor As Object) As Single
        If Valor Is DBNull.Value Then
            Return 0
        Else
            Return Val(Valor)
        End If
    End Function

    Public Shared Function CastDBNullString(ByVal Valor As String) As String
        If Valor Is DBNull.Value Then
            Return ""
        Else
            Return Valor
        End If
    End Function

    Public Shared Function CastDBNullObject(ByVal Valor As Object) As String
        If Valor Is DBNull.Value Then
            Return ""
        Else
            Return Valor
        End If
    End Function

    Public Shared Function CastDBNullDate(ByVal Valor As Object) As Date
        If Valor Is DBNull.Value Then
            Return Now
        Else
            Return Valor
        End If
    End Function

    Public Shared Function CastNulo(ByVal Valor As Single) As Single
        If Valor.ToString = "NeuN" Or Valor.ToString = "Infinito" Then
            Return 0
        Else
            Return Format(Valor, "0.00")
        End If
    End Function

    Public Shared Function CastNuloString(ByVal Valor As Single) As String
        If Valor.ToString = "NeuN" Or Valor.ToString = "Infinito" Then
            Return ""
        Else
            Return Format(Valor, "0.00")
        End If
    End Function

    Public Shared Function Redondear(ByVal Valor As String, Optional ByVal Formato As String = "") As String
        Return Math.Round(CType(Valor, Double), 2).ToString(Formato)
    End Function

    Public Shared Function CastNothingString(ByVal Valor As Object) As String
        If Valor Is Nothing Then
            Return ""
        Else
            Return Valor.ToString
        End If
    End Function
End Class

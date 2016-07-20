Public Class Algoritmos
    Public Shared Function EsPar(ByVal Numero As Integer) As Boolean
        If Int(Numero / 2) = (Numero / 2) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function ObtenerHora(ByVal Hora As Integer, ByVal Minuto As Integer) As String
        Dim Hs As String, Mn As String
        Dim ret As String
        'Si llega como h_inicio un 7    
        If CStr(Hora).Length < 2 Then
            'se le agrega un 0 delante 
            Hs = Trim("0" & Hora) '& ":"
        Else
            'si es 07 o un hs_inicio de 2 char
            Hs = Hora '& ":"
        End If

        'Si llega como m_inicio un 5    
        If CStr(Minuto).Length < 2 Then
            'se le agrega un 0 delante , osea 05
            Mn &= Trim("0" & Minuto)
        Else
            'si es 07 o un m_inicio de 2 no hace nada, solo lo concatena a la h_inicio
            Mn &= Minuto
        End If

        ret = Trim(Hs & ":" & Mn)

        Return ret

    End Function
    Public Shared Function ObtenerHora(ByVal Hora As Integer) As String
        Dim Hs As String
        Dim Min As String
        Dim ret As String

        If Hora.ToString.Length = 4 Then
            Hs = Hora.ToString.Substring(0, 2)
            Min = Hora.ToString.Substring(2, 2)
            ret = Hs & ":" & Min
        Else
            If Hora.ToString.Length = 3 Then
                Hs = Hora.ToString.Substring(0, 1)
                Min = Hora.ToString.Substring(1, 2)
                ret = "0" & Hs & ":" & Min
            End If
        End If

        Return ret
    End Function
    Public Shared Function ObtenerConstantesSuma(ByVal Suma As Integer) As ArrayList
        '***
        'DEVUELVE UNA COLECCION CON LOS VALORES DE LAS CONSTANTES QUE ENCUENTRA
        'EN LA SUMA DEL VALOR DECIMAL
        '***
        Dim i As Integer
        Dim Binario As String
        Dim Constantes As New ArrayList

        'pasa el valor decimal a binario
        Binario = DecimalBinario(Suma)

        'recorre cada digito del numero binario de atras hacia adelante
        For i = 0 To Binario.Length - 1
            Dim s As String

            'trae todos los digitos a partir del actual
            s = Binario.Substring(Binario.Length - i - 1, i + 1)

            'si es digito actual es 1, se agrega a la coleccion
            If s.Substring(0, 1) = "1" Then
                'reemplaza con CEROS todos los digitos despues del 1,
                'ej.: "1101" -> "1000"
                If s.Length > 1 Then
                    s = s.Substring(0, 1) & s.Substring(1, s.Length - 1).Replace("1", "0")
                End If

                'pasa el valor a decimal
                s = BinarioDecimal(s)

                'y lo agrega a la coleccion
                Constantes.Add(s)
            End If
        Next

        Return Constantes
    End Function

    Public Shared Function ArrayString(ByVal Arr As ArrayList) As String
        Dim cadena As String

        For Each o As Object In Arr
            cadena &= o & ","
        Next

        Return cadena.Substring(0, cadena.Length - 1)

    End Function
    Public Shared Function DecimalBinario(ByVal Valor As Integer) As String
        Dim Resultado As String

        Do While Valor <> 0
            If (Valor Mod 2) = 0 Then
                Resultado &= "0"
                Valor = Int(Valor / 2)
            Else
                Resultado &= "1"
                Valor = Int(Valor / 2)
            End If
        Loop

        Return StrReverse(Resultado)
    End Function

    Public Shared Function BinarioDecimal(ByVal Valor As String) As Integer
        Dim i, a, b, c As Integer

        Valor = StrReverse(Valor)

        For i = 1 To Valor.Length
            a = CInt(Mid$(Valor, i, 1))
            b = a * (2 ^ (i - 1))
            c = c + b
        Next

        Return c
    End Function

    Public Shared Function ContarLetra(ByVal Inicio As Integer, ByVal Cadena As String, ByVal Caracter As String)
        Dim Resultado As Integer
        Dim Cuantos As Integer
        Try
            Resultado = InStr(Inicio, Cadena, Caracter)
            Do While Resultado > 0
                Cuantos = Cuantos + 1
                Inicio = Resultado + 1
                Resultado = InStr(Inicio, Cadena, Caracter)
            Loop
        Catch e As Exception
            MsgBox(e.Message)
        End Try

        Return Cuantos
    End Function
    Public Shared Function ArmarArray(ByVal Original As String, ByVal Nuevo As String) As ArrayList
        Dim Spot As CantidadSpots
        Dim Arr As New ArrayList
        Try
            For Each c As Char In NoRepetidos(Original, Nuevo)
                Spot = New CantidadSpots
                Spot.Letra = c
                Spot.Cantidad = ContarLetra(1, Nuevo, c) - ContarLetra(1, Original, c)
                Arr.Add(Spot)
            Next
        Catch e As Exception
            MsgBox(e.Message)
        End Try
        Return Arr
    End Function
    Public Shared Function SonIguales(ByVal String1 As String, ByVal String2 As String) As Boolean
        Dim str1 As Long
        Dim str2 As Long
        For Each c As Char In String1
            str1 += Asc(c)
        Next
        For Each c As Char In String2
            str2 += Asc(c)
        Next

        If str1 = str2 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function NoRepetidos(ByVal Original As String, ByVal Nuevo As String) As String
        Dim Ret As String = ""
        Dim Cadena As String = Original & Nuevo

        For Each c As Char In Cadena
            If Ret.IndexOf(c) < 0 Then
                Ret &= c
            End If
        Next
        Return Ret
    End Function
    Public Shared Function ProximoDia(ByVal Fecha As Date, ByVal Dia As DayOfWeek) As Date
        Dim Ret As Date = Fecha
        Dim auxFecha As Date = Fecha

        While Ret.DayOfWeek <> Dia

            Fecha = Fecha.AddDays(1)
            Ret = Fecha
        End While

        Return Ret
    End Function
    Public Shared Function ObtenerDiaSemana(ByVal FSpot As DateTime) As Integer
        Select Case FSpot.DayOfWeek
            Case DayOfWeek.Monday
                Return 1
            Case DayOfWeek.Tuesday
                Return 2
            Case DayOfWeek.Wednesday
                Return 3
            Case DayOfWeek.Thursday
                Return 4
            Case DayOfWeek.Friday
                Return 5
            Case DayOfWeek.Saturday
                Return 6
            Case DayOfWeek.Sunday
                Return 7
        End Select
    End Function
    Public Shared Function CalcSemana(ByVal Calendario As Boolean, ByVal FSpot As Date, ByVal Fsistema As Date) As Integer
        Dim semana As Integer
        Dim diasDomingo As Integer
        Dim diasDif As Integer
        Select Case Calendario
            Case True
                If Fsistema.DayOfWeek = DayOfWeek.Monday Then
                    semana = (DateDiff(DateInterval.Day, Fsistema, FSpot) \ 7) + 1
                Else
                    diasDif = DateDiff(DateInterval.Day, Fsistema, FSpot)
                    diasDomingo = DateDiff(DateInterval.Day, Fsistema, ProximoDia(Fsistema, DayOfWeek.Sunday))
                    If diasDif > diasDomingo Then
                        If ObtenerDiaSemana(FSpot) > (7 - (diasDomingo + 1)) Then
                            semana = (DateDiff(DateInterval.Day, Fsistema, FSpot) \ 7) + 1
                        Else
                            semana = (DateDiff(DateInterval.Day, Fsistema, FSpot) \ 7) + 2
                        End If
                    Else
                        semana = 1
                    End If
                End If

            Case False
                semana = (DateDiff(DateInterval.Day, Fsistema, FSpot, ) \ 7) + 1
        End Select

        Return semana
    End Function
    Public Shared Function ObtenerCPR(ByVal Neto As Single, ByVal Cantidad As Integer, ByVal Grp As Single, ByVal Segundos As Integer)

        If Grp > 0 Then
            Return (Neto * Cantidad) / (Grp * Segundos)
        Else
            Return 0
        End If


    End Function
    Public Shared Function ObtenerFranja(ByVal HI As Integer, ByVal MI As Integer, ByVal Franjas As DataTable) As String

        Dim filtro As String
        Dim r As DataRow()

        filtro = "h_desde <=" & HI & " and m_desde <=" & MI
        filtro &= " AND h_hasta >=" & HI & " and m_hasta >=" & MI

        r = Franjas.Select(filtro)

        If r.Length = 0 Then
            Return "Unica"
            Exit Function
        End If

        Return r(0)("Descripcion")

    End Function

    Public Shared Function ArrayDt(ByVal array As ArrayList, ByVal ID As String, ByVal Descripcion As String) As DataTable

        Dim dt As New DataTable, r As DataRow
        dt.Columns.Add(ID, GetType(Integer))
        dt.Columns.Add(Descripcion, GetType(String))

        For Each i As ItemLista In array
            r = dt.NewRow
            r(ID) = i.ID
            r(Descripcion) = i.Descripcion
            dt.Rows.Add(r)
        Next

        Return dt
    End Function
    Public Shared Function BorrarCaracter(ByVal Caracter As String, ByVal Cadena As String) As String
        Return Cadena.Remove(Cadena.IndexOf(Caracter), 1)
    End Function
End Class

Public Class CantidadSpots
    Public Letra As String
    Public Cantidad As Integer
End Class
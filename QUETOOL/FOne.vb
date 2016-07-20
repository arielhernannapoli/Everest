Imports AxVCF150
Imports System.Runtime.InteropServices


Public Class AdminFormulaOne
    Dim mGrilla As AxF1Book
    

    Public Property Grilla() As AxF1Book
        Get
            If mGrilla Is Nothing Then
                Throw New Exception("El Objeto F1Book No se Ha Asignado a la Propiedad 'Grilla' de la Clase AdminFormulaOne")
            End If
            Return mGrilla
        End Get
        Set(ByVal Value As AxF1Book)
            mGrilla = Value
        End Set
    End Property

    Public Sub CargarDato(ByVal Valor As String, ByVal Fila As Integer, ByVal Col As Integer, Optional ByVal Concatenar As Boolean = False)
        Try
            If Not Concatenar Then
                If Not IsNumeric(Valor) Then
                    Grilla.set_TextRC(Fila, Col, Valor.Substring(0, IIf(Valor.Length < 255, Valor.Length, 255)))
                Else
                    Grilla.set_NumberRC(Fila, Col, Valor)
                End If
            Else
                Dim T As String

                T = Grilla.get_TextRC(Fila, Col)

                If Not IsNumeric(Valor) Then
                    T &= Valor
                Else
                    If Not IsNumeric(T) Then
                        T = 0
                    End If
                    T = CInt(T) + Valor
                End If

                If T.Length > 255 Then
                    T = T.Substring(0, 252) & "..."
                End If

                If Not IsNumeric(T) Then
                    Grilla.set_TextRC(Fila, Col, T)
                Else
                    Grilla.set_NumberRC(Fila, Col, T)
                End If
            End If
        Catch ex As Exception
            Throw New Exception
        End Try
    End Sub
    Public Sub CargarNumero(ByVal Valor As Double, ByVal Fila As Integer, ByVal Columna As Integer)
        Dim numero As Double = Math.Round(Valor, 2)

        Grilla.set_NumberRC(Fila, Columna, numero)
        'grilla

    End Sub
    Public Sub CargarFormula(ByVal Formula As String, ByVal fila As Integer, ByVal Columna As Integer)
        Try
            Grilla.set_FormulaRC(fila, Columna, Formula)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertarDato(ByVal Valor As Object, ByVal Fila As Integer, ByVal Col As Integer)
        '  Dim texto As String
        If Valor Is DBNull.Value Then
            Valor = "--"
        End If
        'If Valor.GetType Is GetType(Date) Then
        'Valor = CStr(Valor)
        'End If
        '  texto = DirectCast(Valor, String)

        ' If texto = ": a :" Then
        ' t'exto = "--"
        ' End If

        Grilla.set_TextRC(Fila, Col, CStr(Valor).Substring(0, IIf(CStr(Valor).Length < 255, CStr(Valor).Length, 255)))

    End Sub
    Public Function LeerDato(ByVal Fila As Integer, ByVal Col As Integer) As String
        Return Grilla.get_TextRC(Fila, Col)
    End Function

    Public Sub CambiarFuente(ByVal Fila As Integer, ByVal Col As Integer, ByVal Letra As String, ByVal Tamaño As Integer, ByVal Negrita As Boolean, ByVal Cursiva As Boolean)
        Grilla.SetSelection(Fila, Col, Fila, Col)

        Grilla.SetFont(Letra, 10, Negrita, Cursiva, False, False, New System.UInt32, False, False)
    End Sub

    Public Sub CambiarFuente(ByVal Fila As Integer, ByVal Col As Integer, ByVal Negrita As Boolean)
        Grilla.SetSelection(Fila, Col, Fila, Col)

        Grilla.SetFont("", 10, Negrita, False, False, False, New System.UInt32, False, False)
    End Sub

    Public Sub DuplicarFila(ByVal Fila As Integer, ByVal ColDesde As Integer, ByVal ColHasta As Integer)
        Dim cellFormat As VCF150.F1CellFormat
        Dim formula As String

        'agrega una nueva fila
        Grilla.InsertRange(Fila + 1, ColDesde, Fila + 1, ColHasta, VCF150.F1ShiftTypeConstants.F1ShiftVertical)

        'pega el formato en la nueva fila, columna por columna
        For nroColumna As Integer = ColDesde To ColHasta
            Grilla.SetSelection(Fila, nroColumna, Fila, nroColumna)
            cellFormat = Grilla.GetCellFormat()
            formula = Grilla.Formula

            Grilla.SetSelection(Fila + 1, nroColumna, Fila + 1, nroColumna)
            Grilla.SetCellFormat(cellFormat)
            If formula.Length > 0 Then
                Grilla.Formula = formula.Replace(Fila, Fila + 1)
            End If
        Next
    End Sub

    Public Sub DuplicarColumna(ByVal Col As Integer, ByVal FilaDesde As Integer, ByVal FilaHasta As Integer)
        Dim cellFormat As VCF150.F1CellFormat
        Grilla.InsertRange(FilaDesde, Col, FilaHasta, Col, VCF150.F1ShiftTypeConstants.F1ShiftHorizontal)

        If Grilla.MaxCol < 256 Then
            Grilla.MaxCol += 1 'amplia las columnas de la grilla
        End If

        'pega el formato copiado en la nueva columna, fila por fila
        For nroFila As Integer = FilaDesde To FilaHasta
            Grilla.SetSelection(nroFila, Col + 1, nroFila, Col + 1)
            cellFormat = Grilla.GetCellFormat()

            Grilla.SetSelection(nroFila, Col, nroFila, Col)
            Grilla.SetCellFormat(cellFormat)
        Next
    End Sub

    Public Sub CargarBorde(ByVal Fila As Integer, ByVal ColDesde As Integer, ByVal ColHasta As Integer, ByVal Left As TipoBorde, ByVal Right As TipoBorde, ByVal Top As TipoBorde, ByVal Bottom As TipoBorde, Optional ByVal AnchoBorde As Integer = 1)
        Dim O As System.UInt32
        Try
            Grilla.SetSelection(Fila, ColDesde, Fila, ColHasta)

            Grilla.SetBorder(AnchoBorde, Left, Right, Top, Bottom, 1, O, O, O, O, O)
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)

        End Try

    End Sub
    Public Sub SetBorde(ByVal Filadesde As Integer, ByVal ColDesde As Integer, ByVal FilaHasta As Integer, ByVal ColHasta As Integer, ByVal Left As TipoBorde, ByVal Right As TipoBorde, ByVal Top As TipoBorde, ByVal Bottom As TipoBorde)
        Dim O As System.UInt32
        Try
            Grilla.SetSelection(Filadesde, ColDesde, FilaHasta, ColHasta)

            Grilla.SetBorder(1, Left, Right, Top, Bottom, 1, O, O, O, O, O)
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)

        End Try

    End Sub

    ' Public Sub CargarBorde(ByVal Fila As Integer, ByVal Col As Integer, ByVal Left As TipoBorde, ByVal Right As TipoBorde, ByVal Top As TipoBorde, ByVal Bottom As TipoBorde, Optional ByVal AnchoBorde As Integer = 1)
    '    Dim O As System.UInt32
    '    Try
    '        Grilla.SetSelection(Fila, Col, Fila, Col)''''

    '    Grilla.SetBorder(AnchoBorde, Left, Right, Top, Bottom, 1, O, O, O, O, O)
    'grilla.SetBorder
    '  Catch ex As Exception
    '     Mensajes.Mensaje(ex.Message)

    '  End Try

    ' End Sub
    Public Sub CargarTitulos(ByVal Col As Integer, ByVal Fila As Integer, ByVal ParamArray Titulos() As String)
        For Each Titulo As String In Titulos
            Grilla.set_TextRC(Fila, Col, Titulo)

            Col += 1
        Next
    End Sub

    Public Sub CargarTemplate(ByVal NombreTemplate As String)
        Try
            Grilla.Read(NombreTemplate, 1)
        Catch ex As System.Runtime.InteropServices.COMException
            Throw New Exception("El Archivo '" & NombreTemplate & "' de Template No Existe")
        End Try
    End Sub
End Class

Public Enum TipoBorde
    SinCambio = -1
    SinBorde = 0
    BordeFino = 1
    BordeMedio = 2
    Lineas = 3
    Puntos = 4
    Doble = 6
End Enum
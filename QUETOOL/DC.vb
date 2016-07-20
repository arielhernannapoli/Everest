Public Class DC
    'Private Declare Function GetSysColor Lib "user32" (ByVal nIndex As Long) As Long
    'Private Const COLOR_ACTIVEBORDER = 10
    'Private Const COLOR_ACTIVECAPTION = 2
    'Private Const COLOR_APPWORKSPACE = 12
    'Private Const COLOR_BACKGROUND = 1
    'Private Const COLOR_BTNFACE = 15
    'Private Const COLOR_BTNHIGHLIGHT = 20
    'Private Const COLOR_BTNSHADOW = 16
    'Private Const COLOR_BTNTEXT = 18
    'Private Const COLOR_CAPTIONTEXT = 9
    'Private Const COLOR_GRAYTEXT = 17
    'Private Const COLOR_HIGHLIGHT = 13
    'Private Const COLOR_HIGHLIGHTTEXT = 14
    'Private Const COLOR_INACTIVEBORDER = 11
    'Private Const COLOR_INACTIVECAPTION = 3
    'Private Const COLOR_INACTIVECAPTIONTEXT = 19
    'Private Const COLOR_MENU = 4
    'Private Const COLOR_MENUTEXT = 7
    'Private Const COLOR_SCROLLBAR = 0
    'Private Const COLOR_WINDOW = 5
    'Private Const COLOR_WINDOWFRAME = 6
    'Private Const COLOR_WINDOWTEXT = 8


    Public Structure udtField
        Public Name As String
        Public Caption As String
        Public Orient As Integer
        Public GFCaption As String
        Public GFType As Integer
    End Structure

    Public Structure udtRange
        Public dStart As Double
        Public dEnd As Long
        Public lColor As UInt32
    End Structure

    Public Enum eDCModo
        Datos = 0
        Graficos = 1
    End Enum

    Public dcCurrent As Control
    Private Data(0, 0) As Array
    Public Shared gaRanges() As udtRange
    Public Shared giRanges As Long

    Public Function GetCurrDataField(ByVal DC As Object) As Integer
        Dim i, j As Integer
        Dim iFlds As Integer

        iFlds = 0

        For i = 0 To (DC.DataFields.Count - 1)
            If DC.DataFields(i).Visible Then iFlds = iFlds + 1
        Next

        i = DC.SelStartCol Mod iFlds

        For j = 0 To DC.DataFields.Count - 1
            If DC.DataFields(j).Visible And i = 0 Then
                GetCurrDataField = j
                Exit Function
            End If
            i = i - 1
        Next

    End Function
    Public Function getHeadingFromPoint(ByVal dcube As DynamiCubeLib.DCube, _
    ByVal sFieldCaption As String, _
                                        ByVal iRow As Long, _
                                        ByVal iCol As Long) As String


        Dim oField As DynamiCubeLib.Field ' object

        ' Need to use CStr for some reason.  DC doesn't recognize string unless cstr is used
        oField = dcube.Fields.Item(CStr(sFieldCaption))

        If oField Is Nothing Then
            getHeadingFromPoint = ""
        End If

        ' Find orientation of field
        Select Case oField.Orientation
            Case DynamiCubeLib.OrientationConstants.DCRow
                getHeadingFromPoint = dcube.RowHeading(iRow, oField.Position + 1)
            Case DynamiCubeLib.OrientationConstants.DCColumn
                getHeadingFromPoint = dcube.ColHeading(iCol, oField.Position + 1)
            Case Else ' page or data, don't bother
                getHeadingFromPoint = ""
        End Select

    End Function


    Public Function getDataFieldByPosition(ByVal dcube As DynamiCubeLib.DCube, ByVal iDataPosition As Long)
        Dim cnt As Long
        Dim invisCount() As Long
        Dim iRunningCount As Long

        ReDim invisCount(dcube.DataFields.Count - 1)

        For cnt = 0 To dcube.DataFields.Count - 1

            With dcube.DataFields.Item(cnt)
                ' .Position is 0 based
                ' set each individual field's position to visible or not by 1 or 0
                If Not .Visible Then
                    invisCount(.Position) = 1
                Else
                    invisCount(.Position) = 0
                End If
            End With
        Next cnt

        ' Now go back through the array and put in the visible count up until that position
        iRunningCount = 0
        For cnt = 0 To UBound(invisCount)
            iRunningCount = iRunningCount + invisCount(cnt)
            invisCount(cnt) = iRunningCount
        Next cnt

        ' now we have an array that tells us how many fields are invisible before
        ' each position.  Each element in array is a position (0, 1, 2,...)
        ' dataFieldIndex might be negative to indicate a total line
        For cnt = 0 To dcube.DataFields.Count - 1
            With dcube.DataFields.Item(cnt)
                ' If it's not visible we definately do not want it.
                If True = .Visible Then
                    If iDataPosition + invisCount(.Position) = (.Position) Then

                        getDataFieldByPosition = dcube.DataFields.Item(cnt)

                        Exit Function

                    End If
                End If
            End With
        Next cnt


    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' say you have 3 visible data fields, and you click on column 6, then this function will
    ' tell you that the click occured on the dataFeild that is dispalyed at *position* 3
    ' |1|2|3|4|5|6|7|8|9|10|11|12|
    ' |1|2|3|1|2|3|1|2|3| 1| 2| 3|
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function getDataFieldPositionFromColumn(ByVal dcube As DynamiCubeLib.DCube, ByVal iColumn As Long) As Long
        Dim iVisDataFieldCount As Long
        Dim iDivisor As Long

        iVisDataFieldCount = GetVisibleDataFieldCount(dcube)

        iDivisor = Fix(iColumn / iVisDataFieldCount)

        If iDivisor > 0 Then
            getDataFieldPositionFromColumn = iColumn - (iVisDataFieldCount * iDivisor)
        Else
            getDataFieldPositionFromColumn = iColumn
        End If

    End Function

    Public Function GetVisibleDataFieldCount(ByVal DC As DynamiCubeLib.DCube) As Long
        Dim cnt As Long
        Dim visCount As Long

        For cnt = 0 To DC.DataFields.Count - 1
            If True = DC.DataFields.Item(cnt).Visible Then
                visCount = visCount + 1
            End If
        Next cnt

        GetVisibleDataFieldCount = visCount

    End Function

    '    Public Function GetMatrizDatos(ByVal DC As DynamiCubeLib.DCube, ByVal bSwapAxis As Boolean) As Object
    '        Dim iCol As Long, iRow As Long, iDepth As Long
    '        Dim iColMax As Long, iRowMax As Long, iColMin As Long, iRowMin As Long
    '        'Dim bSwapAxis As Boolean
    '        Dim iColIndex As Long, iRowIndex As Long
    '        Dim iRowCount As Long, iColCount As Long


    '        ' determine starting point and ending points
    '        If DC.SelEndCol >= DC.SelStartCol Then
    '            iColMax = DC.SelEndCol
    '            iColMin = DC.SelStartCol
    '        Else
    '            iColMax = DC.SelStartCol
    '            iColMin = DC.SelEndCol
    '        End If

    '        If DC.SelEndRow >= DC.SelStartRow Then
    '            iRowMax = DC.SelEndRow
    '            iRowMin = DC.SelStartRow
    '        Else
    '            iRowMax = DC.SelStartRow
    '            iRowMin = DC.SelEndRow
    '        End If

    '        ' Count Rows
    '        iRowCount = 0
    '        iRow = iRowMin
    '        Do While iRow <= iRowMax
    '            iRowCount = iRowCount + 1
    '            iRow = DC.GetNextRow(iRow)
    '        Loop ' iRow

    '        ' Count cols
    '        iColCount = 0
    '        iCol = iColMin
    '        Do While iCol <= iColMax
    '            iColCount = iColCount + 1
    '            iCol = DC.GetNextCol(iCol)
    '        Loop ' iCol

    '        ' Creo la matriz de datos
    '        If bSwapAxis = True Then
    '            ReDim Data(0 To iRowCount, 0 To iColCount)
    '        Else
    '            ReDim Data(0 To iColCount, 0 To iRowCount)
    '        End If

    '        '***********************************************************************
    '        ' set labels - remember that the upper left data point (0,0) is not used
    '        '***********************************************************************

    '        ' col labels

    '        If bSwapAxis = True Then
    '            iCol = iColMin
    '            iColIndex = 0
    '            Do While iCol <= iColMax
    '                For iDepth = 1 To IIf(DC.GetColDepth(iCol) = 0, 1, DC.GetColDepth(iCol))
    '                    Data(0, (iColIndex) + 1) = Data(0, iColIndex + 1) + IIf(Data(0, iColIndex + 1) = "", "", " - ") + CStr(DC.ColHeading(iCol, iDepth))
    '                Next iDepth
    '                iColIndex = iColIndex + 1
    '                iCol = DC.GetNextCol(iCol)
    '            Loop 'iCol
    '        Else
    '            iCol = iColMin
    '            iColIndex = 0
    '            Do While iCol <= iColMax
    '                For iDepth = 1 To IIf(DC.GetColDepth(iCol) = 0, 1, DC.GetColDepth(iCol))
    '                    Data((iColIndex) + 1, 0) = Data((iColIndex) + 1, 0) + IIf(Data((iColIndex) + 1, 0) Is "", "", " - ") + CStr(DC.ColHeading(iCol, iDepth))
    '                Next iDepth
    '                iColIndex = iColIndex + 1
    '                iCol = DC.GetNextCol(iCol)
    '            Loop 'iCol
    '        End If

    '        'row labels
    '        If bSwapAxis = True Then
    '            iRowIndex = 0
    '            iRow = iRowMin
    '            Do While iRow <= iRowMax
    '                For iDepth = 1 To DC.GetRowDepth(iRow)
    '                    Data((iRowIndex + 1), 0) = Data((iRowIndex + 1), 0) + IIf(Data((iRowIndex + 1), 0) = "", "", " - ") + CStr(DC.RowHeading(iRow, iDepth))
    '                Next iDepth
    '                iRowIndex = iRowIndex + 1
    '                iRow = DC.GetNextRow(iRow)
    '            Loop 'iRow
    '        Else
    '            iRowIndex = 0
    '            iRow = iRowMin
    '            Do While iRow <= iRowMax
    '                For iDepth = 1 To DC.GetRowDepth(iRow)
    '                    Data(0, (iRowIndex) + 1) = Data(0, (iRowIndex) + 1) + IIf(Data(0, (iRowIndex) + 1) = "", "", " - ") + CStr(DC.RowHeading(iRow, iDepth))
    '                Next iDepth
    '                iRowIndex = iRowIndex + 1
    '                iRow = DC.GetNextRow(iRow)
    '            Loop 'iRow
    '        End If

    '        ' get data
    '        If bSwapAxis = True Then
    '            iCol = iColMin
    '            iColIndex = 0
    '            Do While iCol <= iColMax
    '                iRow = iRowMin
    '                iRowIndex = 0
    '                Do While iRow <= iRowMax
    '                    Data((iRowIndex) + 1, (iColIndex) + 1) = DC.DataValue(iRow, iCol)
    '                    iRow = DC.GetNextRow(iRow)
    '                    iRowIndex = iRowIndex + 1
    '                Loop ' irow
    '                iCol = DC.GetNextCol(iCol)
    '                iColIndex = iColIndex + 1
    '            Loop 'iCol
    '        Else
    '            iCol = iColMin
    '            iColIndex = 0
    '            Do While iCol <= iColMax
    '                iRow = iRowMin
    '                iRowIndex = 0
    '                Do While iRow <= iRowMax
    '                    Data((iColIndex) + 1, (iRowIndex) + 1) = DC.DataValue(iRow, iCol)
    '                    iRow = DC.GetNextRow(iRow)
    '                    iRowIndex = iRowIndex + 1
    '                Loop 'iRow
    '                iCol = DC.GetNextCol(iCol)
    '                iColIndex = iColIndex + 1
    '            Loop 'iCol
    '        End If

    '        GetMatrizDatos = Data

    '        Exit Function

    'ehLocal:

    '        MsgBox("No se puede crear el gráfico. Error: " + Err.Description, vbCritical)
    '        '  GraphMSChart = False

    '    End Function
    'Public Sub ExportToText(ByVal DC As DynamiCubeLib.DCube, ByVal sfilename As String)
    '    Dim hFile As Integer
    '    Dim iRow, iCol, iDepth As Integer
    '    Dim iRowFields, iColFields As Integer
    '    Dim iSpaces As Integer

    '    hFile = FreeFile()
    'Open sfilename For Output As #hFile ' Create file.

    '    iRowFields = DC.GetRowDepth(0)
    '    iColFields = DC.GetColDepth(0)

    '    For iDepth = 1 To DC.GetColDepth(iCol)
    '        iCol = 0
    '        ' space for rowheading area
    '        For iSpaces = 1 To iRowFields
    '        Print #hFile, Chr(9);
    '        Next
    '        ' column headings
    '        Do While (iCol < DC.ColCount)
    '        Print #hFile, Left(DC.ColHeading(iCol, iDepth), 7) + Chr(9);
    '            iCol = DC.GetNextCol(iCol)
    '        Loop
    '    Print #hFile,
    '    Next

    '    iRow = 0
    '    Do While (iRow < DC.RowCount)
    '        ' output row headings
    '        For iDepth = 1 To DC.GetRowDepth(iRow)
    '        Print #hFile, Left(DC.RowHeading(iRow, iDepth), 7) + Chr(9);
    '        Next
    '        ' if current iDepth is smaller than maxsize output spaces
    '        Do While iDepth <= iRowFields
    '        Print #hFile, Chr(9);
    '            iDepth = iDepth + 1
    '        Loop

    '        '---- now output data----

    '        iCol = 0

    '        Do While iCol < DC.ColCount
    '        Print #hFile, Left(Str$(DC.DataValue(iRow, iCol)), 7) + Chr(9);
    '            iCol = DC.GetNextCol(iCol)
    '        Loop
    '        ' incr loop counters for rows
    '        iRow = DC.GetNextRow(iRow)
    '    Print #hFile,
    '    Loop

    'Close #hFile
    'End Sub
    'Public Sub ExportToExcel(ByVal DC As DynamiCubeLibCtl.dcube)
    'Dim oXLApp As Object, cnt As Integer, iMaxRowDepth As Integer, iMaxColDepth As Integer
    'Dim iCol As Integer, iRow As Integer, iColDepth As Integer, iRowDepth As Integer
    'Dim xlCol As Integer, xlRow As Integer, iTempMaxColDepth As Integer, viscnt As Integer
    ''avg
    'On Error Resume Next
    '
    '  Screen.MousePointer = 11
    '
    '  If DC.ColCount > 256 Then
    '    MsgBox "La vista tiene demasiadas columnas para ser manejadas por el Excel.", vbCritical
    '    Screen.MousePointer = 0
    '    Exit Sub
    '  End If
    '
    '  ' Creates OLE object to Excel
    '  Set oXLApp = CreateObject("excel.application")
    '  If Err Or (oXLApp Is Nothing) Then
    '    Call MsgBox("No se puede crear un Excel.  Por favor chequee su instalación de Excel.", vbCritical, App.Title)
    '    Exit Sub
    '  End If
    '  oXLApp.Workbooks.Add
    '  oXLApp.Visible = True
    '
    '  ' Find out MaxRowDepth
    '  cnt = 0
    '  Do While cnt < DC.RowCount
    '    If DC.GetRowDepth(cnt) > iMaxRowDepth Then iMaxRowDepth = DC.GetRowDepth(cnt)
    '    cnt = DC.GetNextRow(cnt)
    '  Loop
    '  ' Find out MaxColDepth
    '  iMaxColDepth = 1
    '  cnt = 0
    '  Do While cnt < DC.ColCount - 1
    '    If iMaxColDepth < DC.GetColDepth(cnt) Then iMaxColDepth = DC.GetColDepth(cnt)
    '    cnt = DC.GetNextCol(cnt)
    '  Loop
    '
    '  ' Export Column Headings; start at iMaxRowDepth
    '  If MultipleVisDatas(DC) Then
    '    iTempMaxColDepth = (iMaxColDepth + 1)
    '  Else
    '    iTempMaxColDepth = iMaxColDepth
    '  End If
    '
    '  For iColDepth = 1 To (iTempMaxColDepth)
    '    iCol = 0
    '    xlCol = (iMaxRowDepth + 1)
    '    Do While iCol < DC.ColCount
    '      If MultipleVisDatas(DC) Then
    '        If iColDepth <= DC.GetColDepth(iCol) + 1 Then
    '          oXLApp.Cells(iColDepth, xlCol).Value = DC.ColHeading(iCol, iColDepth)
    '        End If
    '      Else
    '        If iColDepth <= DC.GetColDepth(iCol) Then
    '          oXLApp.Cells(iColDepth, xlCol).Value = DC.ColHeading(iCol, iColDepth)
    '        End If
    '      End If
    '      iCol = DC.GetNextCol(iCol)
    '      xlCol = xlCol + 1
    '    Loop
    '  Next iColDepth
    '
    '  If MultipleVisDatas(DC) Then
    '    ' multiple visible datafields confirmed, now export captions
    '    xlCol = (iMaxRowDepth + 1)
    '    xlRow = (iMaxColDepth + 1) ' Works for multi datas
    '
    '    iCol = 0
    '    Do While iCol < DC.ColCount
    '      oXLApp.Cells(xlRow, xlCol).Value = DC.ColHeading(iCol, (DC.ColFields.Count + 1))
    '      iCol = DC.GetNextCol(iCol)
    '      xlCol = (xlCol + 1)
    '    Loop
    '  End If
    '
    '  ' Now export RowHeadings and Data
    '  iRow = 0
    '
    '  xlRow = (IIf(iMaxColDepth = 0, 1, iMaxColDepth) + 1)
    '
    '  Do While iRow < DC.RowCount
    '      ' Get RowHeading(s)
    '    xlCol = 1
    '    For iRowDepth = 1 To DC.GetRowDepth(iRow)
    '      oXLApp.Cells(xlRow, xlCol).Value = DC.RowHeading(iRow, iRowDepth)
    '      xlCol = xlCol + 1
    '    Next iRowDepth
    '' Get Data
    '    iCol = 0
    '    xlCol = (iMaxRowDepth + 1)
    '    Do While iCol < DC.ColCount
    '      oXLApp.Cells(xlRow, xlCol).Value = DC.DataValue(iRow, iCol)
    '      iCol = DC.GetNextCol(iCol)
    '      xlCol = (xlCol + 1)
    '    Loop ' iCol
    '    iRow = DC.GetNextRow(iRow)
    '    xlCol = 1
    '    xlRow = (xlRow + 1)
    '  Loop ' iRow
    '
    '  Screen.MousePointer = 0
    '
    '  oXLApp.Cells.Select
    '  oXLApp.Cells.EntireColumn.AutoFit
    '  oXLApp.Range("A1").Select
    '  oXLApp.Range(Selection, ActiveCell.SpecialCells(xlLastCell)).Select
    '  oXLApp.Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    '  oXLApp.Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    '  With oXLApp.Selection.Borders(xlEdgeLeft)
    '    .LineStyle = xlContinuous
    '    .Weight = xlThin
    '    .ColorIndex = xlAutomatic
    '  End With
    '  With oXLApp.Selection.Borders(xlEdgeTop)
    '    .LineStyle = xlContinuous
    '    .Weight = xlThin
    '    .ColorIndex = xlAutomatic
    '  End With
    '  With oXLApp.Selection.Borders(xlEdgeBottom)
    '    .LineStyle = xlContinuous
    '    .Weight = xlThin
    '    .ColorIndex = xlAutomatic
    '  End With
    '  With oXLApp.Selection.Borders(xlEdgeRight)
    '    .LineStyle = xlContinuous
    '    .Weight = xlThin
    '    .ColorIndex = xlAutomatic
    '  End With
    '  With oXLApp.Selection.Borders(xlInsideVertical)
    '    .LineStyle = xlContinuous
    '    .Weight = xlThin
    '    .ColorIndex = xlAutomatic
    '  End With
    '  With oXLApp.Selection.Borders(xlInsideHorizontal)
    '    .LineStyle = xlContinuous
    '    .Weight = xlThin
    '    .ColorIndex = xlAutomatic
    '  End With
    '
    'End Sub
    'Public Sub ExportToExcel(ByVal DC As DynamiCubeLib.DCube)
    '    Dim oXLApp As Object, cnt As Integer, iMaxRowDepth As Integer, iMaxColDepth As Integer
    '    Dim iCol As Integer, iRow As Integer, iColDepth As Integer, iRowDepth As Integer
    '    Dim xlCol As Integer, xlRow As Integer, iTempMaxColDepth As Integer, viscnt As Integer
    '    Dim bMultiVistas As Boolean
    '    'avg
    '    On Error Resume Next

    '    Screen.MousePointer = 11

    '    If DC.ColCount > 256 Then
    '        MsgBox("La vista tiene demasiadas columnas para ser manejadas por el Excel.", vbCritical)
    '        Screen.MousePointer = 0
    '        Exit Sub
    '    End If

    '    ' Creates OLE object to Excel
    '    oXLApp = CreateObject("excel.application")
    '    If Err() Or (oXLApp Is Nothing) Then
    '        Call MsgBox("No se puede crear un Excel.  Por favor chequee su instalación de Excel.", vbCritical, App.Title)
    '        Exit Sub
    '    End If
    '    oXLApp.Workbooks.Add()
    '    oXLApp.Visible = True

    '    ' Find out MaxRowDepth
    '    cnt = 0
    '    Do While cnt < DC.RowCount
    '        If DC.GetRowDepth(cnt) > iMaxRowDepth Then iMaxRowDepth = DC.GetRowDepth(cnt)
    '        cnt = DC.GetNextRow(cnt)
    '    Loop
    '    ' Find out MaxColDepth
    '    iMaxColDepth = 1
    '    cnt = 0
    '    Do While cnt < DC.ColCount - 1
    '        If iMaxColDepth < DC.GetColDepth(cnt) Then iMaxColDepth = DC.GetColDepth(cnt)
    '        cnt = DC.GetNextCol(cnt)
    '    Loop

    '    bMultiVistas = MultipleVisDatas(DC)

    '    ' Export Column Headings; start at iMaxRowDepth
    '    If bMultiVistas Then
    '        iTempMaxColDepth = (iMaxColDepth + 1)
    '    Else
    '        iTempMaxColDepth = iMaxColDepth
    '    End If

    '    For iColDepth = 1 To (iTempMaxColDepth)
    '        iCol = 0
    '        xlCol = (iMaxRowDepth + 1)
    '        Do While iCol < DC.ColCount
    '            If bMultiVistas Then
    '                If iColDepth <= DC.GetColDepth(iCol) + 1 Then
    '                    oXLApp.Cells(iColDepth, xlCol).Value = DC.ColHeading(iCol, iColDepth)
    '                End If
    '            Else
    '                If iColDepth <= DC.GetColDepth(iCol) Then
    '                    oXLApp.Cells(iColDepth, xlCol).Value = DC.ColHeading(iCol, iColDepth)
    '                End If
    '            End If
    '            iCol = DC.GetNextCol(iCol)
    '            xlCol = xlCol + 1
    '        Loop
    '    Next iColDepth

    '    If MultipleVisDatas(DC) Then
    '        ' multiple visible datafields confirmed, now export captions
    '        xlCol = (iMaxRowDepth + 1)
    '        xlRow = (iMaxColDepth + 1) ' Works for multi datas

    '        iCol = 0
    '        Do While iCol < DC.ColCount
    '            oXLApp.Cells(xlRow, xlCol).Value = DC.ColHeading(iCol, (DC.ColFields.Count + 1))
    '            iCol = DC.GetNextCol(iCol)
    '            xlCol = (xlCol + 1)
    '        Loop
    '    End If

    '    ' Now export RowHeadings and Data
    '    iRow = 0

    '    xlRow = (IIf(iMaxColDepth = 0, 1, iMaxColDepth) + 1)

    '    Do While iRow < DC.RowCount
    '        ' Get RowHeading(s)
    '        xlCol = 1
    '        For iRowDepth = 1 To DC.GetRowDepth(iRow)
    '            oXLApp.Cells(xlRow, xlCol).Value = DC.RowHeading(iRow, iRowDepth)
    '            xlCol = xlCol + 1
    '        Next iRowDepth
    '        ' Get Data
    '        iCol = 0
    '        xlCol = (iMaxRowDepth + 1)
    '        Do While iCol < DC.ColCount
    '            oXLApp.Cells(xlRow, xlCol).Value = DC.DataValue(iRow, iCol)
    '            iCol = DC.GetNextCol(iCol)
    '            xlCol = (xlCol + 1)
    '        Loop ' iCol
    '        iRow = DC.GetNextRow(iRow)
    '        xlCol = 1
    '        xlRow = (xlRow + 1)
    '    Loop ' iRow

    '    Screen.MousePointer = 0

    '    oXLApp.Cells.Select()
    '    oXLApp.Cells.EntireColumn.AutoFit()
    '    oXLApp.Range("A1").Select()
    '    oXLApp.Range(Selection, ActiveCell.SpecialCells(xlLastCell)).Select()
    '    oXLApp.Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    '    oXLApp.Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    '    With oXLApp.Selection.Borders(xlEdgeLeft)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlEdgeTop)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlEdgeBottom)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlEdgeRight)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlInsideVertical)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlInsideHorizontal)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With

    'End Sub

    '    Public Sub PasarRecordsetAPivotTable(ByVal Rc As ADODB.Recordset, ByVal Titulo As String, ByVal DC As dcube, Optional ByVal MostrarCabecera As Boolean = True, Optional ByVal AjustarAnchos As Boolean = True, Optional ByVal FilaInicial As Long = 1)
    '        Dim Excel As New Excel.Application, Hoja As Excel.Worksheet, f As Long, C As Long, NumCampos As Long
    '        Dim sUltimaCol As String

    '        On Error GoTo hError

    '        Screen.MousePointer = vbHourglass
    '        Hoja = Excel.Workbooks.Add.Worksheets(1)
    '        NumCampos = Rc.Fields.Count - 1

    '        If NumCampos >= 26 Then
    '            sUltimaCol = "A" & Chr(65 + NumCampos - 26)
    '        Else
    '            sUltimaCol = Chr(65 + NumCampos)
    '        End If

    '        f = IIf(FilaInicial <= 0, 1, FilaInicial) : Hoja.Cells(f, 1) = Titulo : f = f + 1

    '        If MostrarCabecera Then
    '            For C = 0 To NumCampos
    '                Hoja.Cells(f, C + 1) = Rc(C).Name
    '            Next C
    '            Excel.Range("A" & f & ":" & sUltimaCol & f).Select()
    '            With Excel.Selection
    '                .Borders(1).Weight = 3 : .Borders(2).Weight = 3 : .Borders(3).Weight = 3 : .Borders(4).Weight = 3 : .Interior.ColorIndex = 15 : .Font.Bold = True
    '            End With
    '        End If
    '        f = f + 1
    '        Hoja.Cells(f, 1).CopyFromRecordset(Rc)
    '        If AjustarAnchos Then
    '            With Excel
    '                .Range("A" & FilaInicial & ":" & sUltimaCol & FilaInicial).Select()
    '                .Selection.Merge()
    '                .Columns("A:" & sUltimaCol).Select()
    '                .Columns("A:" & sUltimaCol).EntireColumn.AutoFit()
    '                .Cells.Select() : Excel.Cells.EntireRow.AutoFit()
    '            End With
    '        End If
    '        Excel.Range("A" & IIf(FilaInicial <= 0, 1, FilaInicial)).Select()

    '        Excel.Range("A2").Select()
    '        Excel.Range(Excel.Selection, Excel.ActiveCell.SpecialCells(xlLastCell)).Select()
    '        Excel.ActiveWorkbook.PivotCaches.Add(SourceType:=xlDatabase, SourceData:= _
    '           "Hoja1!R2C1:R" & Rc.RecordCount & "C" & Rc.Fields.Count).CreatePivotTable(TableDestination:="", TableName:= _
    '           "Tabla dinámica1")
    '        Excel.ActiveSheet.PivotTableWizard(TableDestination:=Excel.ActiveSheet.Cells(3, 1))
    '        Excel.ActiveSheet.Cells(3, 1).Select()
    '        Excel.ActiveSheet.PivotTables("Tabla dinámica1").SmallGrid = False

    '        Dim aTransFormatoDC(5) As Object
    '        Dim aTransFuncionesDC(8) As Object

    '        aTransFormatoDC(DCHidden) = xlHidden
    '        aTransFormatoDC(DCColumn) = xlColumnField
    '        aTransFormatoDC(DCRow) = xlRowField
    '        aTransFormatoDC(DCData) = xlDataField
    '        aTransFormatoDC(DCPage) = xlPageField

    '        aTransFuncionesDC(DCSum) = xlSum
    '        aTransFuncionesDC(DCCount) = xlCount
    '        aTransFuncionesDC(DCAvg) = xlAverage
    '        aTransFuncionesDC(DCMax) = xlMax
    '        aTransFuncionesDC(DCMin) = xlMin
    '        aTransFuncionesDC(DCStDev) = xlStDev
    '        aTransFuncionesDC(DCStDevP) = xlStDev
    '        aTransFuncionesDC(DCVar) = xlVar
    '        aTransFuncionesDC(DCVarP) = xlVarP

    '        Dim aPosiciones(4) As Integer

    '        aPosiciones(0) = 1
    '        aPosiciones(1) = 1
    '        aPosiciones(2) = 1
    '        aPosiciones(3) = 1
    '        aPosiciones(4) = 1
    '        Dim i As Integer
    '        For i = 0 To DC.Fields.Count - 1
    '            With Excel.ActiveSheet.PivotTables("Tabla dinámica1").PivotFields(DC.Fields(i).Name)
    '                .Orientation = aTransFormatoDC(DC.Fields(i).Orientation)
    '                .Position = aPosiciones(DC.Fields(i).Orientation)
    '                aPosiciones(DC.Fields(i).Orientation) = aPosiciones(DC.Fields(i).Orientation) + 1
    '                If DC.Fields(i).Orientation = 3 Then ' Cuando es data
    '                    .Function = aTransFuncionesDC(DC.Fields(i).AggregateFunc)
    '                End If
    '            End With
    '        Next i

    '        '''''''''''''''''

    '        ' Muestro el Excel
    '        Excel.Visible = True
    '        Screen.MousePointer = vbDefault
    '        Hoja = Nothing : Excel = Nothing
    '        Exit Sub

    'hError:
    '        Hoja = Nothing : Excel = Nothing
    '        If Err.Number <> 1004 Then
    '            MsgBox("No se pudo realizar la exportación a tabla dinámica", vbCritical, App.Title)
    '        End If
    '    End Sub

    '    Public Sub ExportToClipboard(ByVal DC As DynamiCubeLibCtl.dcube, ByVal sDelimiter As String)
    '        Screen.MousePointer = 11
    '        Dim cnt As Integer, iMaxRowDepth As Integer, iMaxColDepth As Integer
    '        Dim iCol As Integer, iRow As Integer, iColDepth As Integer, iRowDepth As Integer
    '        Dim iTempMaxColDepth As Integer, viscnt As Integer
    '        Dim sClip As String
    '        Dim bMultiDatas As Boolean

    '        Const NEWLINECHAR As String = vbCrLf

    '        ' If there are more than one visible datafields
    '        bMultiDatas = MultipleVisDatas(DC)

    '        ' Find out MaxRowDepth
    '        cnt = 0
    '        Do While cnt < DC.RowCount
    '            If DC.GetRowDepth(cnt) > iMaxRowDepth Then iMaxRowDepth = DC.GetRowDepth(cnt)
    '            cnt = DC.GetNextRow(cnt)
    '        Loop
    '        ' Find out MaxColDepth
    '        iMaxColDepth = 0
    '        cnt = 0
    '        Do While cnt < DC.ColCount - 1
    '            If iMaxColDepth < DC.GetColDepth(cnt) Then iMaxColDepth = DC.GetColDepth(cnt)
    '            cnt = DC.GetNextCol(cnt)
    '        Loop

    '        ' Export Column Headings; start at iMaxRowDepth

    '        ' use a greater max col depth if we need to export data field captions
    '        If bMultiDatas Then
    '            iTempMaxColDepth = iMaxColDepth
    '        Else
    '            iTempMaxColDepth = (iMaxColDepth + 1)
    '        End If


    '        sClip = GetDelimiters(iMaxRowDepth, sDelimiter)

    '        For iColDepth = 1 To iTempMaxColDepth - 1
    '            iCol = 0
    '            Do While iCol < DC.ColCount
    '                If bMultiDatas Then
    '                    ' export col headings for view with multivis datas
    '                    If iColDepth < DC.GetColDepth(iCol) Then

    '                        sClip = sClip & DC.ColHeading(iCol, iColDepth) & sDelimiter

    '#If debugging Then
    '                        If "Total" = DC.ColHeading(iCol, iColDepth) Then Stop
    '                        Debug.Print DC.ColHeading(iCol, iColDepth) & sDelimiter
    '#End If

    '                    Else
    '                        ' if we get here, something is collapsed in this column, so we don't export anything but a space
    '                        sClip = sClip & sDelimiter

    '                    End If
    '                Else ' export colheadings for view with single datafield
    '                    If iColDepth <= DC.GetColDepth(iCol) Then

    '#If debugging Then
    '                        If "Total" = DC.ColHeading(iCol, iColDepth) Then Stop
    '#End If

    '                        sClip = sClip & DC.ColHeading(iCol, iColDepth) & sDelimiter

    '                    End If
    '                End If
    '                iCol = DC.GetNextCol(iCol)
    '            Loop
    '            ' if this is not the last time through then put line break, and space for row headings,
    '            ' if it is last then don't put extra line break.
    '            If iColDepth < (iTempMaxColDepth - 1) Then
    '                sClip = sClip & NEWLINECHAR & GetDelimiters(iMaxRowDepth, sDelimiter)
    '            End If

    '        Next iColDepth

    '        If bMultiDatas Then
    '            ' multiple visible datafields confirmed, now export datafield captions
    '            iCol = 0
    '            sClip = sClip & NEWLINECHAR & GetDelimiters(iMaxRowDepth, sDelimiter)
    '            Do While iCol < DC.ColCount
    '                sClip = sClip & DC.ColHeading(iCol, (DC.ColFields.Count + 1)) & sDelimiter
    '                iCol = DC.GetNextCol(iCol)
    '            Loop
    '        End If

    '        ' Now export RowHeadings and Data
    '        sClip = sClip & NEWLINECHAR
    '        iRow = 0

    '        Do While iRow < DC.RowCount
    '            ' Get RowHeading(s)
    '            For iRowDepth = 1 To DC.GetRowDepth(iRow)
    '                If DC.GetRowDepth(iRow) < iMaxRowDepth And iRowDepth = DC.GetRowDepth(iRow) Then
    '                    sClip = sClip & DC.RowHeading(iRow, iRowDepth) & GetDelimiters(iMaxRowDepth - (DC.GetRowDepth(iRow) - 1), sDelimiter)
    '                Else
    '                    sClip = sClip & DC.RowHeading(iRow, iRowDepth) & sDelimiter
    '                End If
    '            Next iRowDepth
    '            ' Get Data
    '            iCol = 0
    '            Do While iCol < DC.ColCount
    '                sClip = sClip & DC.DataValue(iRow, iCol) & sDelimiter
    '                iCol = DC.GetNextCol(iCol)
    '            Loop ' iCol
    '            iRow = DC.GetNextRow(iRow)
    '            sClip = sClip & NEWLINECHAR
    '        Loop ' iRow

    '        ' now set the string to the clipboard
    '        Clipboard.Clear()
    '        Clipboard.SetText(sClip)

    '        Screen.MousePointer = 0

    '    End Sub

    Private Function GetDelimiters(ByVal iNumber As Integer, ByVal sDelimiter As Object) As String
        Dim cnt As Long

        For cnt = 1 To iNumber
            GetDelimiters = GetDelimiters & sDelimiter
        Next cnt

    End Function

    'Public Sub colorCube(ByVal DC As DynamiCubeLib.DCube)
    '    DC.BackColor = GetSysColor(COLOR_WINDOW)
    '    DC.FieldsBackColor = GetSysColor(COLOR_ACTIVECAPTION)
    '    DC.FieldsForeColor = GetSysColor(COLOR_CAPTIONTEXT)
    '    DC.ForeColor = GetSysColor(COLOR_BTNTEXT)
    '    DC.GridColor = GetSysColor(COLOR_BTNSHADOW)
    '    DC.HeadingsBackColor = GetSysColor(COLOR_BTNFACE)
    '    DC.HeadingsForeColor = GetSysColor(COLOR_BTNTEXT)
    '    DC.PrinterGridColor = vbBlack
    '    DC.TotalsBackColor = GetSysColor(COLOR_ACTIVECAPTION)
    '    DC.TotalsForeColor = GetSysColor(COLOR_CAPTIONTEXT)
    'End Sub

    'Public Sub CargarPerfil(ByVal fil As String, ByVal aColW As Object)
    '    Dim fso As New FileSystemObject
    '    Dim arc As TextStream
    '    Dim linea As String
    '    Dim i As Integer

    '    If fso.FileExists(Mid(fil, 1, Len(fil) - 4) + ".cfg") And fso.FileExists(fil) Then
    '        arc = fso.OpenTextFile(Mid(fil, 1, Len(fil) - 4) + ".cfg")
    '        linea = arc.ReadLine
    '        If linea = "[ColWidth]" Then
    '            linea = arc.ReadLine
    '            i = 0
    '            While Not arc.AtEndOfStream And (linea <> "[Color]")
    '                aColW(i) = Val(linea)
    '                linea = arc.ReadLine
    '                i = i + 1
    '            End While
    '            i = 0
    '            If Not arc.AtEndOfStream Then
    '                ReDim gaRanges(1)
    '                linea = arc.ReadLine
    '                While Not arc.AtEndOfStream
    '                    ReDim Preserve gaRanges(i + 1)
    '                    gaRanges(i).dStart = linea
    '                    linea = arc.ReadLine
    '                    gaRanges(i).dEnd = linea
    '                    linea = arc.ReadLine
    '                    gaRanges(i).lColor = linea
    '                    If Not arc.AtEndOfStream Then
    '                        linea = arc.ReadLine
    '                    End If
    '                    i = i + 1
    '                End While
    '                giRanges = i
    '            Else
    '                giRanges = 0
    '                ReDim gaRanges(1)
    '            End If
    '        Else
    '            MsgBox("El archivo de configuraciones del cubo esta corrupto, no se puede abrir", vbExclamation, "Atención")
    '        End If
    '    Else
    '        MsgBox("No se encuentra completo el archivo de configuraciones. Imposible Cargar el perfil", vbExclamation, "Atención")
    '    End If
    '    fso = Nothing
    'End Sub

    'Public Sub ExportToFlex(ByVal DC As DynamiCubeLib.DCube, ByVal msFlex As Control)

    '    Dim cnt As Integer, iMaxRowDepth As Integer, iMaxColDepth As Integer
    '    Dim iCol As Integer, iRow As Integer, iColDepth As Integer, iRowDepth As Integer
    '    Dim iFlexCol As Integer, iFlexRow As Integer, iTempMaxColDepth As Integer, viscnt As Integer
    '    Dim sNumberFormat As String

    '    On Error Resume Next
    '    Screen.MousePointer = 11

    '    ' Find out MaxRowDepth
    '    cnt = 0
    '    Do While cnt < DC.RowCount
    '        If DC.GetRowDepth(cnt) > iMaxRowDepth Then iMaxRowDepth = DC.GetRowDepth(cnt)
    '        cnt = DC.GetNextRow(cnt)
    '    Loop
    '    ' Find out MaxColDepth
    '    iMaxColDepth = 0
    '    cnt = 0
    '    Do While cnt < DC.ColCount - 1
    '        If iMaxColDepth < DC.GetColDepth(cnt) Then iMaxColDepth = DC.GetColDepth(cnt)
    '        cnt = DC.GetNextCol(cnt)
    '    Loop

    '    ' Setup Flex:
    '    msFlex.Cols = DC.ColCount + iMaxRowDepth + 1 ' el  +1 es por los header
    '    msFlex.Rows = DC.RowCount + iMaxColDepth + 1


    '    ' Export Column Headings; start at iMaxRowDepth
    '    If MultipleVisDatas(DC) Then
    '        iTempMaxColDepth = (iMaxColDepth + 1)
    '    Else
    '        iTempMaxColDepth = iMaxColDepth
    '    End If

    '    For iColDepth = 1 To (iTempMaxColDepth)
    '        iCol = 0
    '        iFlexCol = (iMaxRowDepth + 1)
    '        Do While iCol < DC.ColCount

    '            If MultipleVisDatas(DC) Then
    '                If iColDepth < DC.GetColDepth(iCol) Then
    '                    msFlex.Col = iFlexCol
    '                    msFlex.Row = iColDepth
    '                    msFlex.CellBackColor = getDcHeadingsColor(DC)
    '                    msFlex.Text = DC.ColHeading(iCol, iColDepth)

    '                End If
    '            Else
    '                If iColDepth <= DC.GetColDepth(iCol) Then
    '                    msFlex.Col = iFlexCol
    '                    msFlex.Row = iColDepth
    '                    msFlex.CellBackColor = getDcHeadingsColor(DC)
    '                    msFlex.Text = DC.ColHeading(iCol, iColDepth)

    '                End If
    '            End If

    '            iCol = DC.GetNextCol(iCol)
    '            iFlexCol = iFlexCol + 1
    '        Loop
    '    Next iColDepth

    '    If MultipleVisDatas(DC) Then
    '        ' multiple visible datafields confirmed, now export captions
    '        iFlexCol = (iMaxRowDepth + 1)
    '        iFlexRow = (iMaxColDepth) ' Works for multi datas

    '        iCol = 0
    '        Do While iCol < DC.ColCount
    '            msFlex.Row = iFlexRow
    '            msFlex.Col = iFlexCol
    '            msFlex.CellBackColor = getDcHeadingsColor(DC)
    '            msFlex.Text = DC.ColHeading(iCol, (DC.ColFields.Count + 1))
    '            iCol = DC.GetNextCol(iCol)
    '            iFlexCol = (iFlexCol + 1)
    '        Loop
    '    End If

    '    ' Now export RowHeadings and Data
    '    iRow = 0

    '    iFlexRow = (iMaxColDepth + 1)

    '    Do While iRow < DC.RowCount
    '        ' Get RowHeading(s)
    '        iFlexCol = 1
    '        For iRowDepth = 1 To DC.GetRowDepth(iRow)

    '            msFlex.Row = iFlexRow
    '            msFlex.Col = iFlexCol
    '            msFlex.CellBackColor = getDcHeadingsColor(DC)
    '            msFlex.Text = DC.RowHeading(iRow, iRowDepth)
    '            iFlexCol = iFlexCol + 1
    '        Next iRowDepth
    '        ' Get Data
    '        iCol = 0
    '        iFlexCol = (iMaxRowDepth + 1)
    '        Do While iCol < DC.ColCount
    '            msFlex.Row = iFlexRow
    '            msFlex.Col = iFlexCol

    '            '''' we need to apply a numberformat to the data

    '            sNumberFormat = getDataFieldByPosition(DC, getDataFieldPositionFromColumn(DC, iCol)).NumberFormat

    '            ''''
    '            msFlex.CellBackColor = DC.BackColor
    '            msFlex.Text = Format(DC.DataValue(iRow, iCol), sNumberFormat)


    '            iCol = DC.GetNextCol(iCol)
    '            iFlexCol = (iFlexCol + 1)
    '        Loop ' iCol
    '        iRow = DC.GetNextRow(iRow)
    '        iFlexCol = 1
    '        iFlexRow = (iFlexRow + 1)
    '    Loop ' iRow


    '    Screen.MousePointer = 0

    'End Sub

    Function MultipleVisDatas(ByVal DC As DynamiCubeLib.DCube) As Boolean
        ' This function returns true if there are mulitple VISIBLE data fields else it returns false
        Dim viscnt As Integer, cnt As Integer

        If DC.DataFields.Count > 1 Then ' There more than one, now see if they're all visible
            viscnt = 0
            For cnt = 0 To DC.DataFields.Count - 1
                If DC.DataFields.Item(cnt).Visible = False Then viscnt = viscnt + 1
            Next cnt
            If viscnt > 0 Then ' at least one datfield is set to invisible
                If (DC.DataFields.Count - viscnt) > 1 Then ' there are multiple datafields visible
                    MultipleVisDatas = True
                    Exit Function
                Else ' then only one datafield is actually visible
                    MultipleVisDatas = False
                    Exit Function
                End If
            Else 'There are no invisible datafields
                MultipleVisDatas = True
                Exit Function
            End If

        End If
    End Function

    'Private Function getDcHeadingsColor(ByVal DC As DynamiCubeLib.DCube) As OLE_COLOR

    '    If DC.ColStyle = DCFlat Then
    '        getDcHeadingsColor = DC.HeadingsBackColor
    '    Else
    '        getDcHeadingsColor = vbButtonFace
    '    End If

    'End Function

    Public Function BuscarDC(ByVal m_cube As DynamiCubeLib.DCube, ByVal fieldObject As DynamiCubeLib.Field, ByVal textToFind As String, Optional ByVal showResultsOnRow As Boolean = False) As Long
        Dim looper As Integer
        Dim found As Long

        ' initialize
        found = 0

        ' loop through all the dataitems in this field
        For looper = 0 To fieldObject.DataItems.Count - 1
            With fieldObject.DataItems.Item(looper)

                ' if the criteria matches at least one
                ' dataitem, set a flag and exit the loop
                If InStr(1, .Caption, Trim(textToFind), vbTextCompare) > 0 Then
                    found = found + 1
                End If

            End With
        Next looper

        ' was it found?
        If found >= 1 Then

            ' this prevents "InvalidFilter" errors
            ClearAllFilters(m_cube)

            ' loop through all the dataitems in this field
            For looper = 0 To fieldObject.DataItems.Count - 1
                With fieldObject.DataItems.Item(looper)

                    ' if the criteria matches at least one
                    ' dataitem, set a flag and exit the loop
                    .Visible = (InStr(1, .Caption, Trim$(textToFind), vbTextCompare) > 0)

                End With
            Next looper

            ' user only wants to see the found information on the
            ' row axis all by itself...
            If showResultsOnRow Then

                For looper = 0 To m_cube.Fields.Count - 1
                    With m_cube.Fields.Item(looper)
                        If .Orientation = .Orientation.DCColumn _
                        Or .Orientation = .Orientation.DCRow _
                        Or .Orientation = .Orientation.DCPage Then

                            If .Name = fieldObject.Name Then
                                .Orientation = .Orientation.DCRow
                            Else
                                .Orientation = .Orientation.DCPage
                            End If

                        End If
                    End With
                Next looper
            End If

        End If
    End Function

    Private Sub ClearAllFilters(ByVal m_cube As DynamiCubeLib.DCube)
        Dim fieldObject As DynamiCubeLib.Field
        Dim dataItem As DynamiCubeLib.DataItem

        For Each fieldObject In m_cube.Fields
            For Each dataItem In fieldObject.DataItems
                dataItem.Visible = True
            Next dataItem
        Next fieldObject

    End Sub

    Public Function DataFilter(ByVal DC As DynamiCubeLib.DCube) As String

        Dim lRow As Long, lColumn As Long, lRowDepth As Long, lColumnDepth As Long
        Dim sRowFilter As String, sColumnFilter As String, sFilter As String
        Dim lDataItemsReduction As Long, lItems As Long, sTemp As String, lCells As Long
        Dim lFromRow As Long, lToRow As Long, lFromCol As Long, lToCol As Long
        Dim oField As DynamiCubeLib.Field, oDataItem As DynamiCubeLib.DataItem

        If DC.DataFields.Count > 1 Then lDataItemsReduction = 1

        lFromRow = DC.SelStartRow
        lToRow = DC.SelEndRow
        lFromCol = DC.SelStartCol
        lToCol = DC.SelEndCol

        SortSelection(lFromRow, lToRow)
        SortSelection(lFromCol, lToCol)

        For Each oField In DC.Fields
            lItems = 0
            'sFilter = Brackets(oField.Name)
            sFilter = oField.Name
            sTemp = ""
            For Each oDataItem In oField.DataItems
                If oDataItem.Visible Then
                    lItems = lItems + 1
                    AddFilterIN(sTemp, sFilter & " = " & DataValue(oField.DataType, oDataItem.Name))
                End If
            Next
            If oField.DataItems.Count <> lItems Then
                If lCells > 1 Then
                    DataFilter = "(" & DataFilter & ")"
                    lCells = 0
                End If
                AddFilterAND(DataFilter, "(" & sTemp & ")")
            End If
        Next

    End Function

    Private Function GetFieldWithPosition(ByVal Depth As Long, ByRef Fields As DynamiCubeLib.Fields) As DynamiCubeLib.Field

        Dim lIndex As Long

        On Error Resume Next
        For lIndex = 0 To Fields.Count - 1
            If Depth = Fields.Item(lIndex).Position Then
                GetFieldWithPosition = Fields.Item(lIndex)
                Exit Function
            End If
        Next

    End Function

    Private Function Brackets(ByVal Value As String) As String

        On Error Resume Next
        If (Left$(Value, 1) = "[") Or (Right$(Value, 1) = "]") Then
            Brackets = Value
        ElseIf InStr(Value, "datepart") <= 0 Then
            Brackets = "[" & Value & "]"
        Else
            Brackets = Value
        End If

    End Function

    Private Function DataValue(ByVal DataType As Long, ByVal ItemValue As String) As String

        On Error Resume Next
        Select Case DataType
            Case 1
                '// Alphanumeric
                DataValue = "'" & Replace(ItemValue, "'", "''") & "'"
            Case 5
                '// Numeric
                DataValue = ItemValue
            Case 9
                '// Date
                DataValue = "'" & ItemValue & "'"
            Case 101
                '// Fractional
                DataValue = Replace(ItemValue, ",", ".")
            Case Else
                '// Put brackets around, just in case
                DataValue = "'" & Replace(ItemValue, "'", "''") & "'"
        End Select

    End Function

    Private Sub AddFilterAND(ByRef Filter As String, ByVal SubFilter As String)

        On Error Resume Next
        If Filter = "" Then
            Filter = SubFilter
        Else
            Filter = Filter & " AND " & SubFilter
        End If

    End Sub

    Private Sub AddFilterOR(ByRef Filter As String, ByVal RowFilter As String, ByVal ColumnFilter As String)

        Dim sTemp As String

        On Error Resume Next
        If RowFilter <> "" Then sTemp = RowFilter
        If ColumnFilter <> "" Then
            If sTemp = "" Then
                sTemp = ColumnFilter
            Else
                sTemp = sTemp & " AND " & ColumnFilter
            End If
        End If

        If sTemp <> "" Then
            If Filter = "" Then
                Filter = "(" & sTemp & ")"
            Else
                Filter = Filter & " OR (" & sTemp & ")"
            End If
        End If

    End Sub

    Private Sub AddFilterIN(ByRef Filter As String, ByVal SubFilter As String)

        On Error Resume Next
        If Filter = "" Then
            Filter = SubFilter
        Else
            Filter = Filter & " OR " & SubFilter
        End If

    End Sub

    Private Sub SortSelection(ByRef FromPoint As Long, ByRef ToPoint As Long)

        Dim lValue As Long

        On Error Resume Next
        If ToPoint < FromPoint Then
            lValue = ToPoint
            ToPoint = FromPoint
            FromPoint = lValue
        End If

    End Sub

    Public Shared Function DC_Function(ByVal s As String) As Byte
        ' Devuelve el tipo de funcion que tiene el campo (que corresponde a data) para mostrar
        Dim ret As Byte

        Select Case Mid(s, 2, 1)
            Case "N"    'sin function
                ret = 255
            Case "S"    'Sum
                ret = DynamiCubeLib.AggregateFunctions.DCSum
            Case "P"    'Avg
                ret = DynamiCubeLib.AggregateFunctions.DCAvg
            Case "C"    'Count
                ret = DynamiCubeLib.AggregateFunctions.DCCount
            Case "A"    'Min
                ret = DynamiCubeLib.AggregateFunctions.DCMin
            Case "Z"    'Max
                ret = DynamiCubeLib.AggregateFunctions.DCMax
        End Select

        DC_Function = ret
    End Function
    Public Shared Function DC_Position(ByVal s As String) As DynamiCubeLib.OrientationConstants
        ' Devuelve a que parte del cube corresponde el campo que se le pasa por parametro

        Dim ret As DynamiCubeLib.OrientationConstants

        Select Case Mid(s, 1, 1)
            Case "R" ' Filas
                ret = DynamiCubeLib.OrientationConstants.DCRow
            Case "C" ' Columnas
                ret = DynamiCubeLib.OrientationConstants.DCColumn
            Case "P" ' Pagina
                ret = DynamiCubeLib.OrientationConstants.DCPage
            Case "D" ' Datos
                ret = DynamiCubeLib.OrientationConstants.DCData
            Case "N" ' Oculto
                ret = DynamiCubeLib.OrientationConstants.DCHidden
        End Select

        DC_Position = ret

    End Function
    Public Shared Function DC_Name(ByVal s As String) As String
        ' devuelve el nombre del campo que se la pasa por parametro
        DC_Name = Mid(s, 4)
    End Function

    'Public Sub ExportToExcelFormato(ByVal DC As DynamiCubeLib.DCube)
    '    Dim oXLApp1 As Object, cnt As Integer, iMaxRowDepth As Integer, iMaxColDepth As Integer
    '    Dim iCol As Integer, iRow As Integer, iColDepth As Integer, iRowDepth As Integer
    '    Dim xlCol As Integer, xlRow As Integer, iTempMaxColDepth As Integer, viscnt As Integer
    '    Dim oXLApp As New Excel.Application
    '    'av

    '    If DC.ColCount > 256 Then
    '        MsgBox("La vista tiene demasiadas columnas para ser manejadas por el Excel.", vbCritical)

    '        Exit Sub
    '    End If

    '    ' Creates OLE object to Excel
    '    oXLApp = CreateObject("excel.application")
    '    If Err() Or (oXLApp Is Nothing) Then
    '        MsgBox("No se puede crear una aplicación Excel. Por favor chequee la instalación del Excel.", vbCritical, "Oops")
    '        Exit Sub
    '    End If
    '    oXLApp.Workbooks.Add()
    '    oXLApp.Visible = True

    '    ' Find out MaxRowDepth
    '    cnt = 0
    '    Do While cnt < DC.RowCount
    '        If DC.GetRowDepth(cnt) > iMaxRowDepth Then iMaxRowDepth = DC.GetRowDepth(cnt)
    '        cnt = DC.GetNextRow(cnt)
    '    Loop
    '    ' Find out MaxColDepth
    '    iMaxColDepth = 0
    '    cnt = 0
    '    Do While cnt < DC.ColCount - 1
    '        If iMaxColDepth < DC.GetColDepth(cnt) Then iMaxColDepth = DC.GetColDepth(cnt)
    '        cnt = DC.GetNextCol(cnt)
    '    Loop

    '    ' Export Column Headings; start at iMaxRowDepth
    '    If MultipleVisDatas(DC) Then
    '        iTempMaxColDepth = (iMaxColDepth + 1)
    '    Else
    '        iTempMaxColDepth = iMaxColDepth
    '    End If

    '    For iColDepth = 1 To (iTempMaxColDepth)
    '        iCol = 0
    '        xlCol = (iMaxRowDepth + 1)
    '        Do While iCol < DC.ColCount
    '            If MultipleVisDatas(DC) Then
    '                If iColDepth <= DC.GetColDepth(iCol) + 1 Then
    '                    oXLApp.Cells(iColDepth, xlCol).Value = DC.ColHeading(iCol, iColDepth)
    '                End If
    '            Else
    '                If iColDepth <= DC.GetColDepth(iCol) Then
    '                    oXLApp.Cells(iColDepth, xlCol).Value = DC.ColHeading(iCol, iColDepth)
    '                End If
    '            End If
    '            iCol = DC.GetNextCol(iCol)
    '            xlCol = xlCol + 1
    '        Loop
    '    Next iColDepth

    '    If MultipleVisDatas(DC) Then
    '        ' multiple visible datafields confirmed, now export captions
    '        xlCol = (iMaxRowDepth + 1)
    '        xlRow = (iMaxColDepth) ' Works for multi datas

    '        iCol = 0
    '        Do While iCol < DC.ColCount
    '            oXLApp.Cells(xlRow, xlCol).Value = DC.ColHeading(iCol, (DC.ColFields.Count + 1))
    '            iCol = DC.GetNextCol(iCol)
    '            xlCol = (xlCol + 1)
    '        Loop
    '    End If

    '    ' Now export RowHeadings and Data
    '    iRow = 0

    '    xlRow = IIf(iMaxColDepth = 0, 2, iMaxColDepth + 1)
    '    Dim xlColAnt As Long

    '    xlColAnt = 0
    '    ReDim arrRows(DC.GetRowDepth(iRow))
    '    Do While iRow < DC.RowCount
    '        ' Get RowHeading(s)
    '        xlCol = 1
    '        For iRowDepth = 1 To DC.GetRowDepth(iRow)
    '            If arrRows(iRowDepth) <> DC.RowHeading(iRow, iRowDepth) Then
    '                If xlColAnt > xlCol And (iMaxRowDepth > xlCol) Then   ' verifico como viene la identacion de los rows, si bajo de nivel, acomodo el total del nivel
    '                    oXLApp.Cells(xlRow - 1, xlCol).Value = oXLApp.Cells(xlRow - 1, xlCol + 1).Value & " " & arrRows(iRowDepth)
    '                    oXLApp.Cells(xlRow - 1, xlCol + 1).Value = ""

    '                    oXLApp.Range("A" & (xlRow - 1) & ":" & Chr(64 + iMaxRowDepth) & (xlRow - 1)).Select()
    '                    With oXLApp.Selection.Interior
    '                        .ColorIndex = xlCol + 3
    '                        .Pattern = xlSolid
    '                    End With
    '                    oXLApp.Selection.Font.ColorIndex = 1
    '                    oXLApp.Selection.Font.Bold = True
    '                End If
    '                If (xlColAnt <> xlCol) And (iMaxRowDepth > xlCol) Then
    '                    oXLApp.Range("A" & xlRow & ":" & Chr(64 + iMaxRowDepth) & xlRow).Select()
    '                    With oXLApp.Selection.Interior
    '                        .ColorIndex = xlCol + 3
    '                        .Pattern = xlSolid
    '                    End With
    '                    oXLApp.Selection.Font.ColorIndex = 2
    '                    oXLApp.Selection.Font.Bold = True
    '                End If

    '                oXLApp.Cells(xlRow, xlCol).Value = DC.RowHeading(iRow, iRowDepth)
    '                xlColAnt = xlCol
    '                arrRows(iRowDepth) = DC.RowHeading(iRow, iRowDepth)
    '                xlRow = xlRow + 1
    '            End If
    '            xlCol = xlCol + 1
    '        Next iRowDepth
    '        ' Get Data
    '        iCol = 0
    '        xlCol = (iMaxRowDepth + 1)
    '        xlRow = xlRow - 1
    '        Do While iCol < DC.ColCount
    '            oXLApp.Cells(xlRow, xlCol).Value = DC.DataValue(iRow, iCol)
    '            iCol = DC.GetNextCol(iCol)
    '            xlCol = (xlCol + 1)
    '        Loop ' iCol
    '        iRow = DC.GetNextRow(iRow)
    '        xlCol = 1
    '        xlRow = (xlRow + 1)
    '    Loop ' iRow

    '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    '''''''''''''''''' Acomoda el Excel '''''''''''''''''''''''
    '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '    oXLApp.Range("A1").Select()
    '    oXLApp.Columns(Chr(64 + iMaxRowDepth) & ":Z").Select()
    '    oXLApp.Cells.EntireColumn.AutoFit()

    '    oXLApp.Range("A1").Select()
    '    oXLApp.Columns("A:" & Chr(64 + iMaxRowDepth - 1)).Select()
    '    oXLApp.Selection.ColumnWidth = 5

    '    oXLApp.Range("A1").Select()
    '    oXLApp.Range(Selection, ActiveCell.SpecialCells(xlLastCell)).Select()

    '    oXLApp.Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    '    oXLApp.Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    '    With oXLApp.Selection.Borders(xlEdgeLeft)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlEdgeTop)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlEdgeBottom)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlEdgeRight)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlInsideVertical)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    With oXLApp.Selection.Borders(xlInsideHorizontal)
    '        .LineStyle = xlContinuous
    '        .Weight = xlThin
    '        .ColorIndex = xlAutomatic
    '    End With
    '    oXLApp.Range("A1").Select()
    '    Screen.MousePointer = 0
    'End Sub
End Class

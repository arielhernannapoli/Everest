imports System
imports System.Windows.Forms
imports Infragistics.Win.UltraWinGrid

imports System.Diagnostics

' <summary>
' This class will work with an UltraGrid and provide keyboard searching
' functionality.
' 
' In order for this to work, there are 3 conditions that must be met:
'		1) The grid must have focus.
'		2) There must be at least one sorted column in the grid. The
'			search takes place on the first (primary) sorted column.
'		3) A cell cannot be in edit mode. If a cell is in edit mode, the 
'			assumption is that the user wants to edit the cell, not 
'			search.
'		
'		Also, the class only searches the root (Band 0) level of the 
'			grid. It is intended for use with a flat list of data. 
'			
'		As long as these conditions are met, the user may type on the 
'			keyboard and cell whose value matches what is typed will be 
'			scrolled into view and the cell activated.
'			
'		The search behavior is similar to that of Windows Explorer. 
'			Characters that are typed in rapid succession are assumed to 
'			be part of a single search. If there is a delay between 
'			characters, then a new search begins. This delay can be 
'			adjusted imports the BufferTimeOut property. The default is 
'			500 milliseconds (half a second).
' </summary>
Public Class WinGridKeyboardSearchHelper
#Region " Private Members "

    Private m_grid As UltraGrid = Nothing
    Private m_timer As Timer = Nothing
    Private m_bufferTimeOut As Integer = 500
    Private m_keyboardBuffer As String = String.Empty
    Private m_enabled As Boolean = True

#End Region  'Private Members

#Region " Constructor "
    ' <summary>
    ' Initializes a new instances of the WinGridKeyboardSearchHelper
    ' </summary>
    ' <param name="grid">The grid that will have keyboard searching capability.</param>
    Public Sub New(ByVal grid As UltraGrid)
        ' Set the Grid property. 
        Me.Grid = grid
    End Sub
#End Region  'Constructor

#Region " Public Properties "

#Region " BufferTimeOut "
    ' <summary>
    ' The time (in milliseconds) before the keyboard search times out.
    ' </summary>
    ' <remarks>
    ' When user types a key and the grid has focus, the m_timer starts. If
    ' the user types another key before the time elapsed, then the m_timer
    ' starts over. If the time elapses, the keyboard buffer is cleared
    ' and a new search begins.
    ' </remarks>
    Public Property BufferTimeOut() As Integer
        Get
            Return Me.m_bufferTimeOut
        End Get
        Set(ByVal Value As Integer)
            Me.m_bufferTimeOut = Value

            ' Set the Interval property on the m_timer.
            Me.m_timer.Interval = Me.m_bufferTimeOut
        End Set
    End Property
#End Region  'BufferTimeOut

#Region " Enabled "
    ' <summary>
    ' Enables / disables the keyboard search functionality.
    ' </summary>
    ' <remarks>
    ' Setting this property to false will stop the keyboard search
    ' from being performed. 
    ' </remarks>
    Public Property Enabled() As Boolean
        Get
            Return Me.m_enabled
        End Get
        Set(ByVal Value As Boolean)
            Me.m_enabled = Value
        End Set
    End Property
#End Region  'Enabled

#Region " Grid "
    ' <summary>
    ' The grid that will have keyboard searching m_enabled. 
    ' </summary>
    Public Property Grid() As UltraGrid
        Get
            Return Me.m_grid
        End Get
        Set(ByVal Value As UltraGrid)
            ' Unhook from the KeyPress event of the previous grid (if there was one).
            Me.UnHookKeyPress()

            ' Set the member.
            Me.m_grid = Value

            ' Stop the Timer, just in case it was going.
            Me.StopTimer()

            ' Clear the keyboard buffer.
            Me.m_keyboardBuffer = String.Empty

            ' Hook the KeyPress event of the new grid (if there is one).
            Me.HookKeyPress()
        End Set
    End Property
#End Region      'Grid

#End Region  'Public Properties

#Region " Private Properties "

#Region " Timer "
    ' <summary>
    ' Timer used to determine when the buffer time out expires.
    ' </summary>
    Private ReadOnly Property Timer() As Timer
        Get
            If (Me.m_timer Is Nothing) Then
                ' If the m_timer is Nothing, create a new one. Use the static
                ' CreateTimer method to work around an issue in VS2003.
                Me.m_timer = Infragistics.Win.Utilities.CreateTimer()

                ' Set the Interval.
                Me.m_timer.Interval = Me.m_bufferTimeOut

                ' Hook the Tick event.
                AddHandler Me.m_timer.Tick, AddressOf Me.OnTimerTick
            End If

            Return Me.m_timer
        End Get
    End Property
#End Region  'Timer

#End Region  'Private Properties

#Region " Private Methods "

#Region " StartTimer "
    ' <summary>
    '  Starts the keyboard buffer timout m_timer
    ' </summary>
    Private Sub StartTimer()
        ' Start the Timer.
        Me.Timer.Start()
    End Sub
#End Region  'StartTimer

#Region " StopTimer "
    ' <summary>
    ' Stops the keyboard buffer timeout m_timer.
    ' </summary>
    Private Sub StopTimer()
        ' Stop the m_timer, if it's not Nothing.
        If (Not Me.m_timer Is Nothing) Then
            Me.m_timer.Stop()
        End If
    End Sub
#End Region  'StopTimer

#Region " HookKeyPress "
    ' <summary>
    ' Hooks into the KeyPress event of the grid. 
    ' </summary>
    Private Sub HookKeyPress()
        ' If the grid is not Nothing, hook the KeyPress event.
        If (Not Me.m_grid Is Nothing) Then
            AddHandler Me.m_grid.KeyPress, AddressOf Me.OnKeyPress
        End If
    End Sub
#End Region  'HookKeyPress

#Region " UnHookKeyPress "
    ' <summary>
    ' Unhooks from the KeyPress event of the grid. 
    ' </summary>
    Private Sub UnHookKeyPress()
        ' If the grid is not Nothing, unhook the KeyPress event.
        If (Not Me.m_grid Is Nothing) Then
            AddHandler Me.m_grid.KeyPress, AddressOf Me.OnKeyPress
        End If
    End Sub
#End Region  'UnHookKeyPress

#Region " GetGrid "
    ' <summary>
    ' Gets a grid from a column
    ' </summary>
    ' <param name="column">An UltraGridColumn</param>
    ' <returns>Returns the grid to which the column belongs.</returns>
    Private Shared Function GetGrid(ByVal column As UltraGridColumn) As UltraGrid
        ' If the column is Nothing, return Nothing
        If (column Is Nothing) Then Return Nothing

        ' If the layout is Nothing, return Nothing
        If (column.Layout Is Nothing) Then Return Nothing

        ' Return the grid.
        Return DirectCast(column.Layout.Grid, UltraGrid)
    End Function
#End Region  'GetGrid

#Region " FindRow "

    ' <summary>
    ' Finds a row in the grid based on the current keyboard buffer text.
    ' </summary>
    ' <returns>An UltraGrid row where the first sorted columns value begins with the keyboard buffer value.</returns>
    ' <remarks>
    ' This method searches the grid specified by the Grid property. The search will be performed on the first sorted column in the grid. If there are no sorted columns, the method will return Nothing. 
    ' The text that is searched for is a string that starts with the string in the current keyboard buffer. 
    ' </remarks>
    Private Function FindRow() As UltraGridRow
        ' Call FindRow with the current m_keyboardBuffer text.
        Return Me.FindRow(Me.m_keyboardBuffer)
    End Function
#End Region  'FindRow

#Region " PerformSearch "
    ' <summary>
    ' Finds a row in the grid based on the current keyboard buffer text and activates the cell if found.
    ' </summary>
    ' <returns>An UltraGrid row where the first sorted columns value begins with the keyboard buffer value.</returns>
    ' <remarks>
    ' This method searches the grid specified by the Grid property. The search will be performed on the first sorted column in the grid. If there are no sorted columns, the method will return Nothing. 
    ' The text that is searched for is a string that starts with the string in the current keyboard buffer. 
    ' This method is different from FindRow in that it automatically activates the row and cell if it finds a match.
    ' </remarks>
    Private Function PerformSearch() As UltraGridRow
        ' Call PerformSearch with the current m_keyboardBuffer text.
        Return Me.PerformSearch(Me.m_keyboardBuffer)
    End Function
#End Region  'PerformSearch

#Region " GetFirstSortedColumn "
    ' <summary>
    ' Gets the first sorted column in the grid, if there is on.
    ' </summary>
    ' <returns>The first sorted column in the grid, or Nothing if there are no sorted columns.</returns>
    Private Function GetFirstSortedColumn() As UltraGridColumn
        ' If the grid is Nothing, return Nothing
        If (Me.m_grid Is Nothing) Then Return Nothing

        ' If there are no sorted columns, return Nothing
        If (Me.m_grid.DisplayLayout.Bands(0).SortedColumns.Count = 0) Then Return Nothing

        ' return the first sorted column.
        Return Me.m_grid.DisplayLayout.Bands(0).SortedColumns(0)
    End Function
#End Region  'GetFirstSortedColumn

#Region " DoesRowMeetSearchCriteria "
    ' <summary>
    ' Determines if the row matches the search criteria based on the search string.
    ' </summary>
    ' <param name="row">The row to be evaluated.</param>
    ' <param name="column">The column being searched.</param>
    ' <param name="searchString">The string to search for. The searchString should be in all lower case.</param>
    ' <returns></returns>
    Private Shared Function DoesRowMeetSearchCriteria(ByVal row As UltraGridRow, ByVal column As UltraGridColumn, ByVal searchString As String) As Boolean
        ' If this row is hidden, it should never be picked up by a 
        ' keyboard search.
        If (row.HiddenResolved) Then Return False

        ' Get the text of the specified column in this row. Convert
        ' it to lower case so the search is no case sensitive.
        Dim rowText As String = row.GetCellText(column).ToLower()

        ' If the row text starts with the searchString, return true
        Return rowText.StartsWith(searchString)
    End Function
#End Region  'DoesRowMeetSearchCriteria

#End Region  'Private Methods

#Region " Public Methods "

#Region " FindRow "

    ' <summary>
    ' Finds a row in the grid based on the specified string.
    ' </summary>
    ' <param name="searchString">A string to search for in the grid.</param>
    ' <returns>An UltraGrid row where the first sorted columns value begins with the specified searchString.</returns>
    ' <remarks>
    ' This method searches the grid specified by the Grid property. The search will be performed on the first sorted column in the grid. If there are no sorted columns, the method will return Nothing. 
    ' The text that is searched for is a string that starts with the searchString passed in.
    ' </remarks>
    Public Function FindRow(ByVal searchString As String) As UltraGridRow
        ' Call FindRow with the first sorted column in the grid. 
        Dim firstSortedColumn As UltraGridColumn = Me.GetFirstSortedColumn()
        Return WinGridKeyboardSearchHelper.FindRow(searchString, firstSortedColumn)
    End Function

    ' <summary>
    ' Finds a row in the grid based on the specified string and column.
    ' </summary>
    ' <param name="searchString">A string to search for in the grid.</param>
    ' <param name="column">The column to search.</param>
    ' <returns>An UltraGrid row where the specified column value begins with the specified searchString.</returns>
    ' <remarks>
    ' This method searches the specified column.
    ' The text that is searched for is a string that starts with the searchString passed in.
    ' </remarks>
    Public Shared Function FindRow(ByVal searchString As String, ByVal column As UltraGridColumn) As UltraGridRow
        ' If the searchString is empty, return Nothing
        If (searchString.Length = 0) Then Return Nothing

        ' If the column is Nothing, return Nothing. 			
        If (column Is Nothing) Then Return Nothing

        ' Get the grid from the column. 
        Dim grid As UltraGrid = WinGridKeyboardSearchHelper.GetGrid(column)

        ' If the grid is Nothing, return Nothing
        If (grid Is Nothing) Then Return Nothing

        ' If the grid has no rows, return Nothing
        If (grid.Rows.Count = 0) Then Return Nothing

        ' Get the ActiveRow in the grid. This will be where the search starts.
        Dim startRow As UltraGridRow = grid.ActiveRow

        ' If there is no active row, use the first row in the grid as the starting point.
        If (startRow Is Nothing) Then
            startRow = grid.Rows(0)
        End If

        ' Convert the search string to lower case, so the search is not 
        ' case sensitive.
        searchString = searchString.ToLower()

        ' Begin at the startRow and go to the last row in the grid.
        Dim i As Integer
        For i = startRow.Index To grid.Rows.Count - 1
            ' Get the row to be evaluated.
            Dim row As UltraGridRow = grid.Rows(i)

            ' Determine if this row meets the search criteria and if so, return it. 
            If (WinGridKeyboardSearchHelper.DoesRowMeetSearchCriteria(row, column, searchString)) Then
                Return row
            End If
        Next

        ' If we failed to find the row, go back up to the top of the grid
        ' and search down from there. First, make sure we did not already
        ' start at the top.
        If (startRow.Index > 0) Then
            ' Start at the first row in the grid and go to the original
            ' starting row.
            For i = 0 To startRow.Index - 1
                ' Get the row to be evaluated.
                Dim row As UltraGridRow = grid.Rows(i)

                ' Determine if this row meets the search criteria and if so, return it. 
                If (WinGridKeyboardSearchHelper.DoesRowMeetSearchCriteria(row, column, searchString)) Then
                    Return row
                End If
            Next
        End If

        ' If we have gotten to this point and have not found the row, 
        ' return Nothing.
        Return Nothing
    End Function
#End Region  'FindRow

#Region " PerformSearch "

    ' <summary>
    ' Finds a row in the grid based on the specified searchString and activates the cell if found.
    ' </summary>
    ' <param name="searchString">A string to search for in the grid.</param>
    ' <returns>An UltraGrid row where the first sorted columns value begins with the specified searchString.</returns>
    ' <remarks>
    ' This method searches the grid specified by the Grid property. The search will be performed on the first sorted column in the grid. If there are no sorted columns, the method will return Nothing. 
    ' The text that is searched for is a string that starts with the specified searchString. 
    ' This method is different from FindRow in that it automatically activates the row and cell if it finds a match.
    ' </remarks>
    Public Function PerformSearch(ByVal searchString As String) As UltraGridRow
        ' Call PerformSearch imports the first sorted column in the grid.
        Dim firstSortedColumn As UltraGridColumn = Me.GetFirstSortedColumn()
        Return WinGridKeyboardSearchHelper.PerformSearch(searchString, firstSortedColumn)
    End Function

    ' <summary>
    ' Finds a row in the grid based on the specified searchString and column and activates the cell if found.
    ' </summary>
    ' <param name="searchString">A string to search for in the grid.</param>
    ' <param name="column">The column to search.</param>
    ' <returns>An UltraGrid row where the specified column value begins with the specified searchString.</returns>
    ' <remarks>
    ' This method searches the specified column. 
    ' The text that is searched for is a string that starts with the specified searchString. 
    ' This method is different from FindRow in that it automatically activates the row and cell if it finds a match.
    ' </remarks>
    Public Shared Function PerformSearch(ByVal searchString As String, ByVal column As UltraGridColumn) As UltraGridRow
        ' Find the row.
        Dim row As UltraGridRow = WinGridKeyboardSearchHelper.FindRow(searchString, column)

        ' If the row was found, scroll it into view and activate the cell.
        If (Not row Is Nothing) Then
            ' Get the grid.
            Dim grid As UltraGrid = WinGridKeyboardSearchHelper.GetGrid(column)

            ' Scroll the row into view on the ActiveRowScrollRegion.
            grid.ActiveRowScrollRegion.ScrollRowIntoView(row)

            ' Set the ActiveRow.
            grid.ActiveRow = row

            ' Set the ActiveCell.
            grid.ActiveCell = row.Cells(column)
        End If

        ' Return the row that was found.
        Return row
    End Function
#End Region  'PerformSearch

#End Region  'Public Methods

#Region " Event Handlers "

#Region " OnTimerTick "
    ' <summary>
    ' Handles the tick event of the m_timer.
    ' </summary>
    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)

        ' Once the m_timer has elapsed, stop the m_timer. 
        Me.StopTimer()

        ' Clear the keyboard buffer. 
        Me.m_keyboardBuffer = String.Empty
    End Sub
#End Region  'OnTimerTick

#Region " OnKeyPress "
    ' <summary>
    ' Handles the KeyPress event of the grid.
    ' </summary>
    Private Sub OnKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        ' If the m_enabled is false, do nothing.
        If (Not Me.m_enabled) Then Return

        ' If there is an active cell in the grid that is in edit
        ' mode, then we don't want to respond to the key press, since 
        ' this would interfere with the user typing into a cell.
        Dim activeCell As UltraGridCell = Me.m_grid.ActiveCell
        If (Not activeCell Is Nothing AndAlso activeCell.IsInEditMode) Then
            Return
        End If

        ' Start the m_timer. 
        Me.StartTimer()

        ' Append the new keystroke onto the keyboard buffer, unless
        ' it's a tab key. 
        If (e.KeyChar <> vbTab) Then
            Me.m_keyboardBuffer += e.KeyChar
        End If

        ' Perform a search.
        Me.PerformSearch()
    End Sub
#End Region  'OnKeyPress

#End Region 'Event Handlers

#Region " Implementation of IDisposable "
    ' <summary>
    ' Should be invoked when the class is disposed.
    ' </summary>
    Public Sub Dispose()
        ' If the m_timer isn't Nothing, clean it up.
        If (Not Me.m_timer Is Nothing) Then

            ' Unhook from the Tick event
            RemoveHandler m_timer.Tick, AddressOf Me.OnTimerTick

            ' Dispose the m_timer.
            Me.m_timer.Dispose()
        End If

        ' Unhook from the KeyPress event of the grid.
        Me.UnHookKeyPress()
    End Sub
#End Region  ' Dispose

End Class

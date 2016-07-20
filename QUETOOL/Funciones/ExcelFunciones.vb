Imports MyExcel = Microsoft.Office.Interop.Excel
Imports System.IO


Module ExcelFunciones

    Declare Function SetLastError Lib "kernel32.dll" (ByVal dwErrCode As Integer) As IntPtr
    Declare Function EndTask Lib "user32.dll" (ByVal hWnd As IntPtr) As Integer
    Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" _
           (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Declare Function GetWindowThreadProcessId Lib "user32.dll" _
           (ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer

    Private _templateXLS As String
    Private _tempFolder As String
    Private _destino As String
    Private _colInicio As String
    Private _colDestino As String
    Private _datos(,) As String
    Private _rowInicio As Integer

    Private backgroundWorker1(1) As System.ComponentModel.BackgroundWorker

    Public Property TemplateXLS() As String
        Get
            Return _templateXLS
        End Get
        Set(ByVal value As String)
            _templateXLS = value
        End Set
    End Property

    Public Property TempFolder() As String
        Get
            Return _tempFolder
        End Get
        Set(ByVal value As String)
            _tempFolder = value
        End Set
    End Property

    Public Property CarpetaDestino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    Public Property ColumnaInicio() As String
        Get
            Return _colInicio
        End Get
        Set(ByVal value As String)
            _colInicio = value
        End Set
    End Property

    Public Property ColumnaFin() As String
        Get
            Return _colDestino
        End Get
        Set(ByVal value As String)
            _colDestino = value
        End Set
    End Property

    Public Property RegistroInicio() As String
        Get
            Return _rowInicio
        End Get
        Set(ByVal value As String)
            _rowInicio = value
        End Set
    End Property

    Public Property Datos() As Object
        Get
            Return _datos
        End Get
        Set(ByVal value As Object)
            _datos = value
        End Set
    End Property


    Public Sub GeneraExcelReporteAvisosMacheados(ByVal args As ArgumentType)
        backgroundWorker1(1) = New System.ComponentModel.BackgroundWorker
        backgroundWorker1(1).WorkerReportsProgress = True
        backgroundWorker1(1).WorkerSupportsCancellation = False
        AddHandler backgroundWorker1(1).DoWork, AddressOf WorkerDoWorkReporteAvisosMacheados
        AddHandler backgroundWorker1(1).ProgressChanged, AddressOf WorkerProgressChangedReporteAvisosMacheados
        AddHandler backgroundWorker1(1).RunWorkerCompleted, AddressOf WorkerCompletedReporteAvisosMacheados
        backgroundWorker1(1).RunWorkerAsync(args)
    End Sub

    Public Sub EnsureProcessKilled(ByVal MainWindowHandle As IntPtr, ByVal Caption As String)

        SetLastError(0)
        ' for Excel versions <10, this won't be set yet
        If IntPtr.Equals(MainWindowHandle, IntPtr.Zero) Then _
      MainWindowHandle = FindWindow(Nothing, Caption)
        If IntPtr.Equals(MainWindowHandle, IntPtr.Zero) Then _
      Exit Sub ' at this point, presume the window has been closed.
        Dim iRes, iProcID As Integer
        iRes = GetWindowThreadProcessId(MainWindowHandle, iProcID)
        If iProcID = 0 Then ' can’t get Process ID
            If EndTask(MainWindowHandle) <> 0 Then Exit Sub ' success
            Throw New ApplicationException("Failed to close.")
        End If
        Dim proc As System.Diagnostics.Process
        proc = System.Diagnostics.Process.GetProcessById(iProcID)
        proc.CloseMainWindow()
        proc.Refresh()
        If proc.HasExited Then Exit Sub
        proc.Kill()

    End Sub

    Private Sub WorkerDoWorkReporteAvisosMacheados(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        Dim excelApplication As Microsoft.Office.Interop.Excel.ApplicationClass = New Microsoft.Office.Interop.Excel.ApplicationClass()
        Dim excelWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet

        Try
            Dim args As ArgumentType = e.Argument
            Dim CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture()
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")


            excelWorkbook = excelApplication.Workbooks.Open(TemplateXLS)
            worksheet = excelWorkbook.Worksheets(1)

            Dim paramExportFormat As Microsoft.Office.Interop.Excel.XlFixedFormatType = _
                Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF
            Dim paramExportQuality As Microsoft.Office.Interop.Excel.XlFixedFormatQuality = _
                Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard
            Dim paramOpenAfterPublish As Boolean = False
            Dim paramIncludeDocProps As Boolean = True
            Dim paramIgnorePrintAreas As Boolean = True
            Dim paramFromPage As Object = Type.Missing
            Dim paramToPage As Object = Type.Missing

            worksheet.Cells(4, 4).Value = args._Cliente
            worksheet.Cells(5, 4).Value = args._Producto

            Dim i As Integer

            Dim value_range As MyExcel.Range = worksheet.Range(ColumnaInicio + RegistroInicio.ToString(), ColumnaFin + (args._Fila + RegistroInicio).ToString())
            value_range.Value2 = Datos
            value_range.Borders.LineStyle = MyExcel.XlLineStyle.xlContinuous

            If Not excelWorkbook Is Nothing Then
                excelWorkbook.ExportAsFixedFormat(paramExportFormat, _
                    TempFolder, paramExportQuality, _
                    paramIncludeDocProps, paramIgnorePrintAreas, _
                    paramFromPage, paramToPage, paramOpenAfterPublish)
            End If

            excelApplication.Caption = System.Guid.NewGuid.ToString.ToUpper
            If File.Exists(CarpetaDestino) Then
                File.Delete(CarpetaDestino)
            End If
            File.Move(TempFolder, CarpetaDestino)
        Catch ex As Exception
            ' respond to the error
            MessageBox.Show("Ocurrió el siguiente error al generar el archivo excel: " + ex.Message)
        Finally
            EnsureProcessKilled(0, excelApplication.Caption)
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Dim CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture()
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        End Try
    End Sub

    Private Sub WorkerProgressChangedReporteAvisosMacheados(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs)
        ' I did something!
    End Sub

    Private Sub WorkerCompletedReporteAvisosMacheados(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        ' I'm done!
    End Sub

End Module

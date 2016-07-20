Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Enum TipoArchivo
    PDF
    Excel
    HTML
    Word
End Enum

Public Class Reporte
    Const Usuario As String = "sa"
    Const Contraseña As String = "codigo12"

    Dim mReporte As ReportClass
    Dim mSelectionFormula As String
    Dim mFormulas As Hashtable

    Public Property Reporte() As ReportClass
        Get
            Return mReporte
        End Get
        Set(ByVal Value As ReportClass)
            mReporte = Value
        End Set
    End Property

    Public Property SelectionFormula() As String
        Get
            Return mSelectionFormula
        End Get
        Set(ByVal Value As String)
            mSelectionFormula = Value
        End Set
    End Property

    Public Property Formulas() As Hashtable
        Get
            If mFormulas Is Nothing Then
                mFormulas = New Hashtable
            End If

            Return mFormulas
        End Get
        Set(ByVal Value As Hashtable)
            mFormulas = Value
        End Set
    End Property

    Public Sub SeleccionRangoFechas(ByVal Campo As String, ByVal FechaDesde As Date, ByVal FechaHasta As Date)
        If Me.SelectionFormula <> "" Then
            Me.SelectionFormula &= " and "
        End If

        'crystal no toma las fechas inclusive en el rango, _
        'entonces se resta y suma 1 dia para que la fechas sean inclusive
        FechaDesde = FechaDesde.Subtract(New System.TimeSpan(1, 0, 0, 0))
        FechaHasta = FechaHasta.Add(New System.TimeSpan(1, 0, 0, 0))

        'formatea las fechas a Mes / Dia / Año y setea la seleccion
        Me.SelectionFormula &= "{" & Campo & "} in #" & FechaDesde.Date.ToString("MM/dd/yyyy") & _
        "# to #" & FechaHasta.Date.ToString("MM/dd/yyyy") & "#"
    End Sub

    Public Sub SeleccionIgualValor(ByVal Campo As String, ByVal Valor As Object, Optional ByVal Convertir As Boolean = True)
        If Valor Is Nothing Then
            Exit Sub
        End If

        'si se pasa un numero y convertir es true, castea el valor a single (single encierra, enteros y decimales)
        If Convertir AndAlso IsNumeric(Valor) Then
            Valor = CSng(Valor)
        End If

        'si es string y esta vacio, no hace la igualacion
        If TypeOf Valor Is String AndAlso Valor = "" Then
            Exit Sub
        End If

        If Me.SelectionFormula <> "" Then
            Me.SelectionFormula &= " and "
        End If

        If TypeOf Valor Is Integer Or TypeOf Valor Is Byte Or TypeOf Valor Is Single Or TypeOf Valor Is Short Then
            Me.SelectionFormula &= "{" & Campo & "} = " & Valor
        End If

        If TypeOf Valor Is String Then
            Me.SelectionFormula &= "{" & Campo & "} = '" & Valor & "'"
        End If
    End Sub

    Public Sub MostrarReporte()
        Dim F As New frmReporte
        Dim Formula As FormulaFieldDefinition

        F.CRV.ReportSource = SetearConexionReporte(DirectCast(Reporte, ReportClass), "quetool", "quetool", "ketul")

        'setea los valores de las formulas
        If Not Formulas Is Nothing Then
            For Each Formula In Reporte.DataDefinition.FormulaFields
                If Formula.Text = """""" Then
                    Formula.Text = """" & Formulas.Item(Formula.Name) & """"
                End If
            Next
        End If

        F.CRV.SelectionFormula = SelectionFormula

        F.Show()
    End Sub

    Public Function Exportar(ByVal Reporte As ReportClass, ByVal Ruta As String, ByVal Archivo As String, ByVal TipoArchivo As TipoArchivo)
        Dim Destino As New CrystalDecisions.Shared.DiskFileDestinationOptions

        'prepara la ruta y el nombre del archivo
        Ruta = Ruta.Replace("\", "\\")

        Destino.DiskFileName = Ruta & IIf(Ruta.Substring(Ruta.Length - 2) = "\\", "", "\\") & Archivo

        'elige el tipo de archivo
        Select Case TipoArchivo
            Case TipoArchivo.PDF
                Reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
            Case TipoArchivo.Excel
                Reporte.ExportOptions.ExportFormatType = ExportFormatType.Excel

                Dim Ex As New ExcelFormatOptions

                Reporte.ExportOptions.FormatOptions = Ex

            Case TipoArchivo.HTML
                Reporte.ExportOptions.ExportFormatType = ExportFormatType.HTML40

                Dim HT As New HTMLFormatOptions

                HT.HTMLFileName = Archivo
                HT.HTMLBaseFolderName = Ruta

                Reporte.ExportOptions.FormatOptions = HT

            Case TipoArchivo.Word
                Reporte.ExportOptions.ExportFormatType = ExportFormatType.WordForWindows
        End Select

        'setea las propiedades
        Reporte.ExportOptions.DestinationOptions = Destino
        Reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile

        SetearConexionReporte(Reporte, "quetool", "quetool", "ketul")

        Reporte.Export()
    End Function

    Private Function SetearConexionReporte(ByVal Reporte As ReportClass, ByVal InicioSesion As String, ByVal Usuario As String, ByVal Contraseña As String) As ReportClass
        '***
        'Recibe un reporte (dimensionado asi: Dim Reporte as New rptNombreReporte) y 
        'le carga los datos de conexion
        '***
        Dim Database As Database
        Dim Tables As Tables
        Dim Table As Table
        Dim TableLogOnInfo As TableLogOnInfo
        Dim ConnectionInfo As ConnectionInfo

        ConnectionInfo = New ConnectionInfo
        With ConnectionInfo
            .ServerName = InicioSesion
            .UserID = Usuario
            .Password = Contraseña
        End With

        Database = Reporte.Database
        Tables = Database.Tables

        For Each Table In Tables
            TableLogOnInfo = Table.LogOnInfo
            TableLogOnInfo.ConnectionInfo = ConnectionInfo
            Table.ApplyLogOnInfo(TableLogOnInfo)
            Table.Location = Table.Name
        Next

        Return Reporte
    End Function
End Class
